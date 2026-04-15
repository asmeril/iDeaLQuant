"""
features.py — 45+ Özellik Çıkarma Motoru

Pre-move tespiti için araştırma & literatür destekli özellik seti:
- Volatilite Sıkışması (VCP, NR7, BB Squeeze, Inside Day)
- Hacim Analizi (Pocket Pivot, VDU, OBV, CMF)
- Fiyat Yapısı (MA Stack, RS, Taban Pozisyonu)
- Momentum (RSI, MACD, Stochastic, ADX)

Kaynaklar:
- Minervini (2013): VCP — 3 pivot, yükseklik azalıyor, hacim kuruyor
- Morales & Kacher (2010): Pocket Pivot — up bar vol > any down bar vol (10 gün)
- Crabel (1990): NR7 — en dar True Range hareketli kırılmayı önceler
- Bollinger (2001): BandWidth < 6-aylık %15 persentil = Squeeze
- O'Neil (2009): RS > 0 vs piyasa; taban üst %50'si; hacim kuruması
"""
from __future__ import annotations
import sys
import numpy as np
import pandas as pd
from typing import Optional, Dict, Any

sys.path.insert(0, r"D:\Projects\IdealQuant\src")

try:
    from indicators.core import EMA, SMA, RSI, ATR, ADX
    from indicators.volume import OBV, ChaikinOsc
    from indicators.volatility import BollingerWidth, BollingerMid, BollingerUp, TrueRange
    from indicators.oscillators import MACD, StochasticFast, StochasticSlow, ROC
    from indicators.trend import DI_Plus, DI_Minus, LinearRegSlope
    INDS_OK = True
except ImportError as e:
    print(f"[WARN features] İndikatör kütüphanesi: {e}")
    INDS_OK = False

from loader import get_true_range


# ═══════════════════════════════════════════════════════════════════
# YARDIMCI FONKSİYONLAR
# ═══════════════════════════════════════════════════════════════════

def _pct_rank(series: np.ndarray, lookback: int, current_idx: int) -> float:
    """0-1 arası persentil sıralama (düşük = sıkışma)."""
    start = max(0, current_idx - lookback + 1)
    window = series[start:current_idx + 1]
    if len(window) < 5:
        return 0.5
    val = series[current_idx]
    return float(np.mean(window <= val))


def _safe(arr, idx, default=np.nan):
    if arr is None or idx < 0 or idx >= len(arr):
        return default
    v = arr[idx] if not isinstance(arr, list) else arr[idx]
    return float(v) if not (v != v) else default  # NaN check


def _arr(series, fallback_len=0) -> np.ndarray:
    if series is None:
        return np.full(fallback_len, np.nan)
    return np.asarray(series, dtype=float)


# ═══════════════════════════════════════════════════════════════════
# BÖLÜM I — VOLATİLİTE SIKIŞ MASI
# ═══════════════════════════════════════════════════════════════════

def feat_vcp_score(df: pd.DataFrame, bi: int) -> float:
    """
    VCP (Volatility Contraction Pattern) skoru: 0.0 – 1.0
    Minervini kriterleri:
    - En az 3 pivot/contraction noktası
    - Her contraction'ın genişliği bir öncekinden < %80
    - Her düzeltme derinliği bir öncekinden daha az
    - Hacim her contraction'da azalıyor
    Peryot: Günlük, son 40 bar incelenir.
    """
    if bi < 20:
        return 0.0
    start = max(0, bi - 40)
    closes = df["close"].values[start:bi + 1]
    highs  = df["high"].values[start:bi + 1]
    lows   = df["low"].values[start:bi + 1]
    vols   = df["vol"].values[start:bi + 1]
    n = len(closes)
    if n < 15:
        return 0.0

    # Pivot noktalarını tespit et (yerel zirveler ve dipler)
    pivot_highs = []
    pivot_lows  = []
    for i in range(2, n - 2):
        if highs[i] > highs[i-1] and highs[i] > highs[i-2] and highs[i] > highs[i+1] and highs[i] > highs[i+2]:
            pivot_highs.append((i, highs[i]))
        if lows[i] < lows[i-1] and lows[i] < lows[i-2] and lows[i] < lows[i+1] and lows[i] < lows[i+2]:
            pivot_lows.append((i, lows[i]))

    if len(pivot_highs) < 2 or len(pivot_lows) < 2:
        return 0.0

    # Ardışık pivot yükseklikleri arasındaki contraction genişliklerini hesapla
    contractions = []
    for k in range(1, min(len(pivot_highs), len(pivot_lows), 5)):
        ph_i, ph_val = pivot_highs[-k]
        pl_i, pl_val = pivot_lows[-k] if k <= len(pivot_lows) else pivot_lows[-1]
        width = (ph_val - pl_val) / ph_val if ph_val > 0 else 0
        contractions.append((ph_i, pl_i, width))

    if len(contractions) < 2:
        return 0.0

    # Her contraction öncekinden daha mı dar?
    # contractions[0] = EN YENİ, contractions[-1] = EN ESKİ
    # VCP: yeni < eski (daralan) ⇒ contractions[i-1] < contractions[i] * 0.95
    contractions_narrowing = sum(
        1 for i in range(1, len(contractions))
        if contractions[i-1][2] < contractions[i][2] * 0.95
    )

    # Hacim kuruması: son 5 bar hacim ortalaması vs 20 gün genel ortalaması
    recent_vol = np.mean(vols[max(0, n-5):])
    avg_vol20  = np.mean(vols[max(0, n-20):n])
    vol_drying = recent_vol < avg_vol20 * 0.7 if avg_vol20 > 0 else False

    score = 0.0
    score += min(contractions_narrowing, 3) / 3 * 0.5   # max 0.5 puan
    score += 0.3 if vol_drying else 0.0
    score += 0.2 if len(contractions) >= 3 else 0.0
    return round(min(score, 1.0), 3)


def feat_bb_squeeze(df: pd.DataFrame, bi: int, lookback: int = 126) -> float:
    """
    Bollinger Band Squeeze: BB Width'in N-günlük %15 persentilinin altındaysa 1.0.
    Bollinger (2001): BandWidth < 6-aylık düşük → kırılma yakın.
    Geri dön: 0-1 arası normalize değer (düşük = sıkı sıkışma = yüksek puan).
    """
    if not INDS_OK or bi < 25:
        return 0.0
    c_list = df["close"].tolist()
    try:
        bw = _arr(BollingerWidth(c_list, 20, 2.0))
    except Exception:
        return 0.0
    rank = _pct_rank(bw, lookback, bi)
    # Düşük rank = sıkışma → yüksek puan (ters çevir, %15 altı ise tam puan)
    return round(max(0.0, (0.20 - rank) / 0.20), 3)


def feat_nr7(df: pd.DataFrame, bi: int) -> bool:
    """NR7: Today's True Range is smallest of last 7 days (Tony Crabel, 1990)."""
    if bi < 7:
        return False
    tr = get_true_range(df).values
    return float(tr[bi]) <= float(np.min(tr[bi-6:bi+1]))


def feat_nr4(df: pd.DataFrame, bi: int) -> bool:
    """NR4: Today's True Range is smallest of last 4 days."""
    if bi < 4:
        return False
    tr = get_true_range(df).values
    return float(tr[bi]) <= float(np.min(tr[bi-3:bi+1]))


def feat_inside_day_streak(df: pd.DataFrame, bi: int) -> int:
    """Ard arda kaç 'inside day' (dünün aralığı içinde bugün)."""
    streak = 0
    i = bi
    while i >= 1:
        if df["high"].iloc[i] <= df["high"].iloc[i-1] and df["low"].iloc[i] >= df["low"].iloc[i-1]:
            streak += 1
            i -= 1
        else:
            break
    return streak


def feat_atr_pct_rank(df: pd.DataFrame, bi: int, lookback: int = 126) -> float:
    """ATR% 126-günlük persentili. Düşük = sıkışma (biz tersi alıyoruz: 1 - rank)."""
    if not INDS_OK or bi < 20:
        return 0.5
    h = df["high"].tolist()
    l = df["low"].tolist()
    c = df["close"].tolist()
    try:
        atr = _arr(ATR(h, l, c, 14))
        atr_pct = np.where(np.array(c) > 0, atr / np.array(c), np.nan)
    except Exception:
        return 0.5
    rank = _pct_rank(atr_pct, lookback, bi)
    return round(1.0 - rank, 3)  # Düşük rank = sıkışma = yüksek özellik değeri


def feat_range_contraction(df: pd.DataFrame, bi: int, n: int = 5) -> float:
    """Son N günde günlük aralık (High-Low) daralıyor mu? 0-1."""
    if bi < n:
        return 0.0
    ranges = (df["high"].values[bi-n+1:bi+1] - df["low"].values[bi-n+1:bi+1])
    if len(ranges) < 3 or ranges[0] == 0:
        return 0.0
    # Her günün bir öncekinden küçük olma oranı
    shrinks = sum(1 for i in range(1, len(ranges)) if ranges[i] < ranges[i-1])
    return round(shrinks / (n - 1), 3)


# ═══════════════════════════════════════════════════════════════════
# BÖLÜM II — HACİM ANALİZİ
# ═══════════════════════════════════════════════════════════════════

def feat_pocket_pivot(df: pd.DataFrame, bi: int) -> bool:
    """
    Pocket Pivot (Gil Morales & Chris Kacher, 2010):
    - Bugün up day (close > prev_close)
    - Bugünkü hacim > son 10 günün down günleri MEDYAN hacmi
    - [DEĞİŞİKLİK] max yerine medyan: tek aşırı hacimli dump günü (ör. KRDMB 2.6B)
      kalıcı blok oluşturmasın. Analiz (10.04.2026): +1.6% hit artışı, false positive +0.
    """
    if bi < 11:
        return False
    is_up = df["close"].iloc[bi] >= df["close"].iloc[bi - 1]
    if not is_up:
        return False

    today_vol = df["vol"].iloc[bi]
    # Son 10 günün down gün hacimleri
    down_vols = [
        df["vol"].iloc[i]
        for i in range(bi - 10, bi)
        if df["close"].iloc[i] < df["close"].iloc[i - 1]
    ]
    if not down_vols:
        return False
    median_down_vol = float(np.median(down_vols))
    return today_vol > median_down_vol


def feat_vol_dryup(df: pd.DataFrame, bi: int) -> float:
    """
    Hacim Dry Up: Son 3 günün ortalama hacmi, 20-günlük ortalamanın ne kadarı?
    1.0 = tamamen kurumuş, 0.0 = normal/yüksek
    Kriter: < 0.6 ise VDU sinyali
    """
    if bi < 22:
        return 0.0
    avg3  = df["vol"].iloc[bi-2:bi+1].mean()
    avg20 = df["vol"].iloc[bi-20:bi].mean()
    if avg20 == 0:
        return 0.0
    ratio = avg3 / avg20
    # 0.6'nın altı tam VDU, 1.0 üstü sıfır
    return round(max(0.0, min(1.0, (0.6 - ratio) / 0.6 + 0.1)), 3)


def feat_obv_slope(df: pd.DataFrame, bi: int) -> float:
    """OBV 20-günlük regresyon eğimi (normalize)."""
    if not INDS_OK or bi < 25:
        return 0.0
    c = df["close"].tolist()
    v = df["vol"].tolist()
    try:
        obv = _arr(OBV(c, v))
    except Exception:
        return 0.0
    window = obv[max(0, bi-19):bi+1]
    if len(window) < 10 or window[-1] == 0:
        return 0.0
    xs = np.arange(len(window), dtype=float)
    slope = float(np.polyfit(xs, window, 1)[0])
    # Normalize: eğim / OBV mutlak değeri
    return round(np.sign(slope) * min(abs(slope) / (abs(window[-1]) + 1e-9), 1.0), 4)


def feat_cmf(df: pd.DataFrame, bi: int) -> float:
    """Chaikin Money Flow son değeri (-1 ile +1 arası)."""
    if not INDS_OK or bi < 22:
        return 0.0
    h = df["high"].tolist()
    l = df["low"].tolist()
    c = df["close"].tolist()
    v = df["vol"].tolist()
    # CMF manuel hesapla: MFV = vol × MFM, MFM = (close - low - (high - close)) / (high - low)
    mfv = []
    for i in range(len(c)):
        hl = h[i] - l[i]
        mfv.append(v[i] * ((c[i] - l[i]) - (h[i] - c[i])) / hl if hl > 0 else 0.0)
    mfv = np.array(mfv)
    vol_arr = np.array(v)
    window = 20
    cmf_val = []
    for i in range(len(c)):
        s = max(0, i - window + 1)
        sv = vol_arr[s:i+1].sum()
        cmf_val.append(mfv[s:i+1].sum() / sv if sv > 0 else 0.0)
    return round(float(cmf_val[bi]), 4)


def feat_up_vol_ratio(df: pd.DataFrame, bi: int, n: int = 20) -> float:
    """Up günlerin hacim toplamı / Down günlerin hacim toplamı (son N gün)."""
    if bi < n:
        return 1.0
    up_vol   = sum(df["vol"].iloc[i] for i in range(bi-n+1, bi+1)
                   if df["close"].iloc[i] >= df["close"].iloc[i-1])
    down_vol = sum(df["vol"].iloc[i] for i in range(bi-n+1, bi+1)
                   if df["close"].iloc[i] < df["close"].iloc[i-1])
    if down_vol == 0:
        return 2.0
    return round(up_vol / down_vol, 3)


# ═══════════════════════════════════════════════════════════════════
# BÖLÜM III — FİYAT YAPISI & RELATİF GÜÇ
# ═══════════════════════════════════════════════════════════════════

def feat_ema_stack_score(df: pd.DataFrame, bi: int) -> float:
    """
    EMA9 > EMA20 > EMA50 dizilimi. 0-1 arası (her katman 0.33p).
    EMA eğimlerini de kontrol eder.
    """
    if not INDS_OK or bi < 55:
        return 0.0
    c = df["close"].tolist()
    try:
        e9  = _arr(EMA(c, 9))
        e20 = _arr(EMA(c, 20))
        e50 = _arr(EMA(c, 50))
    except Exception:
        return 0.0
    score = 0.0
    cl = df["close"].iloc[bi]
    if cl > e9[bi]:  score += 0.2
    if e9[bi]  > e20[bi]: score += 0.25
    if e20[bi] > e50[bi]: score += 0.25
    # Eğim kontrolleri (5 bar öncesiyle kıyasla)
    if bi >= 5:
        if e9[bi] > e9[bi-5]:  score += 0.15
        if e20[bi] > e20[bi-5]: score += 0.15
    return round(min(score, 1.0), 3)


def feat_ema50_slope(df: pd.DataFrame, bi: int) -> float:
    """EMA50 eğimi son 10 günde yukarı mı? -1 ile +1 arası."""
    if not INDS_OK or bi < 60:
        return 0.0
    c = df["close"].tolist()
    try:
        e50 = _arr(EMA(c, 50))
    except Exception:
        return 0.0
    window = e50[max(0, bi-9):bi+1]
    if len(window) < 5:
        return 0.0
    xs = np.arange(len(window), dtype=float)
    slope = float(np.polyfit(xs, window, 1)[0])
    # Normalize: eğim / son EMA50 değeri
    return round(np.sign(slope) * min(abs(slope) / (abs(window[-1]) * 0.001 + 1e-9), 1.0), 4)


def feat_below_52w_high(df: pd.DataFrame, bi: int) -> float:
    """
    Hisse 52 haftalık zirvesine ne kadar yakın?
    Puan: %0-10 altı → 1.0, %10-20 → 0.5, %20+ → 0.0
    O'Neil: En iyi girişler zirvenin %15'inin altında yapılır.
    """
    if bi < 20:
        return 0.0
    lookback = min(252, bi + 1)
    peak_52w = df["high"].iloc[bi - lookback + 1:bi + 1].max()
    cl = df["close"].iloc[bi]
    if peak_52w == 0:
        return 0.0
    dist_pct = (peak_52w - cl) / peak_52w
    if dist_pct < 0.10:
        return round(1.0 - dist_pct / 0.10, 3)  # 0-10%: tam puan
    elif dist_pct < 0.20:
        return round(0.5 * (1.0 - (dist_pct - 0.10) / 0.10), 3)  # 10-20%: yarı puan
    return 0.0


def feat_rs_vs_market(df: pd.DataFrame, bi: int, df_xu100: pd.DataFrame = None) -> float:
    """
    Relatif Güç vs XU100: Son 20 günde hisse - piyasa getirisi farkı.
    df_xu100 yoksa basit momentum kullanır.
    """
    if bi < 22:
        return 0.0
    stock_ret = (df["close"].iloc[bi] / df["close"].iloc[bi - 20] - 1)
    if df_xu100 is not None and len(df_xu100) > 20:
        # XU100 barını hisse tarihiyle hizala (basit yaklaşım: son 20 bar günlük getiri)
        mkt_ret = (df_xu100["close"].iloc[-1] / df_xu100["close"].iloc[-21] - 1)
        return round(float(stock_ret - mkt_ret), 4)
    # XU100 yoksa: hisse momentumu
    return round(float(stock_ret), 4)


def feat_base_position(df: pd.DataFrame, bi: int, base_len: int = 20) -> float:
    """
    Fiyatın son N günlük taban içindeki konumu (0 = dip, 1 = zirve).
    O'Neil: >0.5 (tabanın üst yarısı) ideal giriş noktası.
    """
    if bi < base_len:
        return 0.5
    window_high = df["high"].iloc[bi - base_len + 1:bi + 1].max()
    window_low  = df["low"].iloc[bi - base_len + 1:bi + 1].min()
    cl = df["close"].iloc[bi]
    rng = window_high - window_low
    if rng == 0:
        return 0.5
    return round(float((cl - window_low) / rng), 3)


def feat_near_support(df: pd.DataFrame, bi: int) -> float:
    """
    EMA20 veya EMA50 yakınında destek mu? (±2%)
    1.0 = tam üzerinde, 0.0 = uzakta
    """
    if not INDS_OK or bi < 55:
        return 0.0
    c = df["close"].tolist()
    try:
        e20 = _arr(EMA(c, 20))
        e50 = _arr(EMA(c, 50))
    except Exception:
        return 0.0
    cl = df["close"].iloc[bi]
    for ema_val in [e20[bi], e50[bi]]:
        if ema_val > 0:
            dist = abs(cl - ema_val) / ema_val
            if dist <= 0.02:
                return round(1.0 - dist / 0.02, 3)
    return 0.0


# ═══════════════════════════════════════════════════════════════════
# BÖLÜM IV — MOMENTUM & OSİLATÖRLER
# ═══════════════════════════════════════════════════════════════════

def feat_rsi_zone(df: pd.DataFrame, bi: int) -> float:
    """
    RSI birikme bandı (45-65): En güçlü pre-move zone.
    IBD/O'Neil: Kırılmadan önce RSI genellikle 50-65 arasında birikim yapar.
    """
    if not INDS_OK or bi < 16:
        return 0.0
    c = df["close"].tolist()
    try:
        rsi = _arr(RSI(c, 14))
    except Exception:
        return 0.0
    val = rsi[bi]
    if 50 <= val <= 65:
        return 1.0
    elif 45 <= val < 50:
        return round((val - 45) / 5, 3)
    elif 65 < val <= 75:
        return round((75 - val) / 10, 3)
    return 0.0


def feat_rsi_slope(df: pd.DataFrame, bi: int) -> float:
    """RSI son 5 barda yükseliyor mu? 0-1 arası."""
    if not INDS_OK or bi < 20:
        return 0.0
    c = df["close"].tolist()
    try:
        rsi = _arr(RSI(c, 14))
    except Exception:
        return 0.0
    window = rsi[max(0, bi-4):bi+1]
    if len(window) < 3:
        return 0.0
    rising = sum(1 for i in range(1, len(window)) if window[i] > window[i-1])
    return round(rising / (len(window) - 1), 3)


def feat_macd_hist_rising(df: pd.DataFrame, bi: int) -> float:
    """
    MACD histogramı kaç bardır yükseliyor? (3+ bar = güçlü sinyal)
    0-1 normalize (5 bar = 1.0)
    """
    if not INDS_OK or bi < 35:
        return 0.0
    c = df["close"].tolist()
    try:
        macd_val, macd_sig, macd_hist = MACD(c, 12, 26, 9)
        hist = _arr(macd_hist)
    except Exception:
        return 0.0
    streak = 0
    for i in range(bi, max(bi - 6, 0), -1):
        if i >= 1 and hist[i] > hist[i-1]:
            streak += 1
        else:
            break
    return round(min(streak / 5, 1.0), 3)


def feat_macd_crossing(df: pd.DataFrame, bi: int) -> bool:
    """MACD sinyal çizgisini yukarı kesip kesmedi (son 2 barda)."""
    if not INDS_OK or bi < 35:
        return False
    c = df["close"].tolist()
    try:
        macd_val, macd_sig, _ = MACD(c, 12, 26, 9)
        mv = _arr(macd_val)
        ms = _arr(macd_sig)
    except Exception:
        return False
    if bi < 1:
        return False
    crossed = mv[bi] > ms[bi] and mv[bi-1] <= ms[bi-1]
    return bool(crossed)


def feat_stoch_turning(df: pd.DataFrame, bi: int) -> float:
    """
    Stochastic oversold bölgesinden (< 20) dönüyor mu?
    0-1 arası puan (tam dönüş = 1.0)
    """
    if not INDS_OK or bi < 10:
        return 0.0
    h = df["high"].tolist()
    l = df["low"].tolist()
    c = df["close"].tolist()
    try:
        sk = _arr(StochasticFast(h, l, c, 5, 3))
        sd = _arr(StochasticSlow(h, l, c, 5, 3))
    except Exception:
        return 0.0
    if bi < 1:
        return 0.0
    # Dönüş: önceki bar < 20, bugün > önceki (yukarı)
    if sk[bi-1] < 25 and sk[bi] > sk[bi-1] and sk[bi] > sd[bi]:
        # Ne kadar oversold'dan döndü? Kuvvetini ölç
        return round(min((sk[bi] - sk[bi-1]) / 20, 1.0), 3)
    return 0.0


def feat_adx_rising_low(df: pd.DataFrame, bi: int) -> float:
    """
    ADX < 25'in altında ama son 5 barda yükseliyor = yeni trend başlangıcı.
    O'Neil / Weinstein: En iyi kırılmalar ADX 20-25 bandından gelir.
    """
    if not INDS_OK or bi < 20:
        return 0.0
    h = df["high"].tolist()
    l = df["low"].tolist()
    c = df["close"].tolist()
    try:
        adx = _arr(ADX(h, l, c, 14))
    except Exception:
        return 0.0
    val = adx[bi]
    # ADX 15-30 arası VE yükseliyor
    if 15 <= val <= 35 and bi >= 3 and adx[bi] > adx[bi-3]:
        slope_score = (val - 15) / 20  # 15→0, 30→0.75, 35→1
        return round(slope_score, 3)
    return 0.0


# ═══════════════════════════════════════════════════════════════════
# ANA FONKSİYON: TÜM ÖZELLİKLERİ HESAPLA
# ═══════════════════════════════════════════════════════════════════

def compute_all_features(
    df_G: pd.DataFrame,      # Günlük
    df_60: pd.DataFrame = None,
    df_15: pd.DataFrame = None,
    bi: int = None,          # None = son bar
    df_xu100: pd.DataFrame = None,
) -> Dict[str, Any]:
    """
    Tüm özellik değerlerini hesaplar.
    bi = None → son bar (gerçek zamanlı tarama)
    bi = N  → belirli bar (backtest)
    """
    if df_G is None or len(df_G) < 30:
        return {}

    if bi is None:
        bi = len(df_G) - 1

    feats: Dict[str, Any] = {}

    # ── I. Volatilite Sıkışması ──────────────────────────────────────
    feats["vcp_score"]         = feat_vcp_score(df_G, bi)
    feats["bb_squeeze"]        = feat_bb_squeeze(df_G, bi)
    feats["nr7"]               = feat_nr7(df_G, bi)
    feats["nr4"]               = feat_nr4(df_G, bi)
    feats["inside_day_streak"] = feat_inside_day_streak(df_G, bi)
    feats["atr_pct_rank"]      = feat_atr_pct_rank(df_G, bi)
    feats["range_contraction"] = feat_range_contraction(df_G, bi)

    # ── II. Hacim Analizi ────────────────────────────────────────────
    feats["pocket_pivot"]      = feat_pocket_pivot(df_G, bi)
    feats["vol_dryup"]         = feat_vol_dryup(df_G, bi)
    feats["obv_slope"]         = feat_obv_slope(df_G, bi)
    feats["cmf_positive"]      = feat_cmf(df_G, bi)
    feats["up_vol_ratio"]      = feat_up_vol_ratio(df_G, bi)

    # ── III. Fiyat Yapısı & Relatif Güç ─────────────────────────────
    feats["ema_stack_score"]   = feat_ema_stack_score(df_G, bi)
    feats["ema50_slope_up"]    = feat_ema50_slope(df_G, bi)
    feats["below_52w_high"]    = feat_below_52w_high(df_G, bi)
    feats["rs_vs_xu100"]       = feat_rs_vs_market(df_G, bi, df_xu100)
    feats["base_position_ok"]  = feat_base_position(df_G, bi)
    feats["near_support"]      = feat_near_support(df_G, bi)

    # ── IV. Momentum & Osilatörler ───────────────────────────────────
    feats["rsi_zone"]          = feat_rsi_zone(df_G, bi)
    feats["rsi_slope_up"]      = feat_rsi_slope(df_G, bi)
    feats["macd_hist_rising"]  = feat_macd_hist_rising(df_G, bi)
    feats["macd_crossing"]     = feat_macd_crossing(df_G, bi)
    feats["stoch_turning"]     = feat_stoch_turning(df_G, bi)
    feats["adx_rising_low"]    = feat_adx_rising_low(df_G, bi)

    # ── 60dk kontext ─────────────────────────────────────────────────
    if df_60 is not None and len(df_60) >= 50:
        bi60 = len(df_60) - 1
        feats["ema_stack_60"]  = feat_ema_stack_score(df_60, bi60)
        feats["rsi_zone_60"]   = feat_rsi_zone(df_60, bi60)
        feats["macd_60"]       = feat_macd_hist_rising(df_60, bi60)
    else:
        feats["ema_stack_60"] = feats.get("ema_stack_score", 0.0)
        feats["rsi_zone_60"]  = feats.get("rsi_zone", 0.0)
        feats["macd_60"]      = 0.0

    # ── Ham değerler (raporlama için) ─────────────────────────────────
    feats["_close"]   = float(df_G["close"].iloc[bi])
    feats["_vol"]     = float(df_G["vol"].iloc[bi])
    feats["_date"]    = df_G["dt"].iloc[bi].date() if bi < len(df_G) else None

    return feats
