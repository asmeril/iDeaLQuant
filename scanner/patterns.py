"""
patterns.py — Mum Formasyonları & Grafik Formasyonları

Literatür destekli kantitatif formasyon tespiti:
- 8 mum formasyonu (Steve Nison, Thomas Bulkowski)
- 5 grafik formasyonu (O'Neil, Minervini, Edwards & Magee)

Her fonksiyon:
  - Girdi: df (OHLCV DataFrame), bi (bar index)
  - Çıktı: 0.0–1.0 arası güven skoru (0 = yok, 1 = tam formasyon)
"""
from __future__ import annotations
import numpy as np
import pandas as pd
from typing import Dict


# ═══════════════════════════════════════════════════════════════════
# YARDIMCI HESAPLAMALAR
# ═══════════════════════════════════════════════════════════════════

def _body(o, c):
    return abs(c - o)

def _upper_shadow(o, c, h):
    return h - max(o, c)

def _lower_shadow(o, c, l):
    return min(o, c) - l

def _is_bullish(o, c):
    return c > o

def _is_bearish(o, c):
    return c < o

def _range(h, l):
    return h - l + 1e-9

def _avg_body(df: pd.DataFrame, bi: int, n: int = 14) -> float:
    start = max(0, bi - n)
    bodies = abs(df["close"].values[start:bi+1] - df["open"].values[start:bi+1])
    return float(np.mean(bodies)) + 1e-9


# ═══════════════════════════════════════════════════════════════════
# BÖLÜM I — MUM FORMASYONLARI
# ═══════════════════════════════════════════════════════════════════

def pat_hammer(df: pd.DataFrame, bi: int) -> float:
    """
    Hammer (Tokmak):
    - Küçük body (ortalamanın < %50'si)
    - Alt gölge ≥ body × 2
    - Üst gölge ≤ body × 0.5
    - Düşüş trendinin ardından (son 5 günde düşüş var)
    Steve Nison: Tek en güvenilir dip dönüş sinyali.
    """
    if bi < 5:
        return 0.0
    o, h, l, c = df["open"].iloc[bi], df["high"].iloc[bi], df["low"].iloc[bi], df["close"].iloc[bi]
    body = _body(o, c)
    avg_b = _avg_body(df, bi)
    upper = _upper_shadow(o, c, h)
    lower = _lower_shadow(o, c, l)

    if body > avg_b * 0.7:
        return 0.0
    if lower < body * 2:
        return 0.0
    if upper > body * 0.5:
        return 0.0

    # Trend bağlamı: son 5 barda düşüş
    prev_closes = df["close"].values[bi-5:bi]
    in_downtrend = prev_closes[-1] < prev_closes[0]

    score = 0.8
    if in_downtrend:
        score += 0.2
    return round(min(score, 1.0), 3)


def pat_pin_bar(df: pd.DataFrame, bi: int) -> float:
    """
    Bullish Pin Bar:
    - Alt gölge ≥ toplam aralığın %60'ı
    - Body küçük (aralığın < %25'i)
    - Kapanış üst %33'te
    Destekte oluşması krediyi artırır.
    """
    if bi < 3:
        return 0.0
    o, h, l, c = df["open"].iloc[bi], df["high"].iloc[bi], df["low"].iloc[bi], df["close"].iloc[bi]
    rng = _range(h, l)
    if rng < 1e-9:
        return 0.0
    body = _body(o, c)
    lower = _lower_shadow(o, c, l)
    close_pos = (c - l) / rng

    if lower / rng < 0.60:
        return 0.0
    if body / rng > 0.30:
        return 0.0
    if close_pos < 0.60:
        return 0.0

    return round(min(1.0, 0.7 + 0.3 * (close_pos - 0.60) / 0.40), 3)


def pat_bullish_engulfing(df: pd.DataFrame, bi: int) -> float:
    """
    Bullish Engulfing (Yutucu):
    - Dün küçük bearish mum
    - Bugün bugünkü body dünün body'sini tamamen yutuyor
    - Bugün kapanış dünün açılışının üstünde
    Steve Nison: 2 günlük trend dönüş formasyonu.
    """
    if bi < 2:
        return 0.0
    o1 = df["open"].iloc[bi-1];  c1 = df["close"].iloc[bi-1]
    o0 = df["open"].iloc[bi];    c0 = df["close"].iloc[bi]

    if not _is_bearish(o1, c1):
        return 0.0
    if not _is_bullish(o0, c0):
        return 0.0
    if not (o0 <= c1 and c0 >= o1):
        return 0.0

    # Engulf oranı
    dun_body = max(_body(o1, c1), 1e-9)
    bugun_body = _body(o0, c0)
    engulf_ratio = bugun_body / dun_body

    return round(min(engulf_ratio / 2, 1.0), 3)


def pat_morning_star(df: pd.DataFrame, bi: int) -> float:
    """
    Morning Star (3 mum):
    1. Büyük bearish mum
    2. Küçük body (yıldız) — gap down oluşabilir
    3. Büyük bullish mum — 1. mumun ortasına kadar kapanır
    Steve Nison: En güçlü 3 mumlu dip dönüş formasyonu.
    """
    if bi < 2:
        return 0.0
    o2 = df["open"].iloc[bi-2]; c2 = df["close"].iloc[bi-2]  # büyük bearish
    o1 = df["open"].iloc[bi-1]; c1 = df["close"].iloc[bi-1]  # yıldız
    o0 = df["open"].iloc[bi];   c0 = df["close"].iloc[bi]    # bullish

    if not _is_bearish(o2, c2):
        return 0.0
    if not _is_bullish(o0, c0):
        return 0.0

    body2 = _body(o2, c2)
    body1 = _body(o1, c1)
    body0 = _body(o0, c0)
    avg = _avg_body(df, bi)

    # Yıldız küçük body olmalı
    if body1 > avg * 0.5:
        return 0.0
    # 3. mum 1. mumun en az ortasına kadar kapanmalı
    midpoint_day1 = (o2 + c2) / 2
    if c0 < midpoint_day1:
        return 0.0

    # Puan: ne kadar derin kapandı?
    penetration = (c0 - midpoint_day1) / max(body2, 1e-9)
    return round(min(0.6 + penetration * 0.4, 1.0), 3)


def pat_dragonfly_doji(df: pd.DataFrame, bi: int) -> float:
    """
    Dragonfly Doji:
    - Open ≈ Close ≈ High (fark body ≤ range × 0.1)
    - Uzun alt gölge (≥ range × 0.7)
    Destek bölgesinde oluşursa güçlü.
    """
    if bi < 2:
        return 0.0
    o, h, l, c = df["open"].iloc[bi], df["high"].iloc[bi], df["low"].iloc[bi], df["close"].iloc[bi]
    rng = _range(h, l)
    if rng < 1e-9:
        return 0.0
    body = _body(o, c)
    upper = _upper_shadow(o, c, h)
    lower = _lower_shadow(o, c, l)

    if body / rng > 0.10:
        return 0.0
    if lower / rng < 0.70:
        return 0.0

    return round(min(1.0, 0.6 + 0.4 * (lower / rng - 0.70) / 0.30), 3)


def pat_three_white_soldiers(df: pd.DataFrame, bi: int) -> float:
    """
    Three White Soldiers (3 Beyaz Asker):
    - 3 ardışık bullish gün
    - Her gün öncekini aşıyor
    - Her gün kapanış ≥ günün üst %70'inde
    - Hacim artıyor
    Bulkowski: +%82 yukarı devam ihtimali.
    """
    if bi < 3:
        return 0.0
    bars = [(df["open"].iloc[bi-i], df["close"].iloc[bi-i],
             df["high"].iloc[bi-i], df["low"].iloc[bi-i],
             df["vol"].iloc[bi-i]) for i in range(2, -1, -1)]

    for o, c, h, l, v in bars:
        if not _is_bullish(o, c):
            return 0.0
        rng = _range(h, l)
        close_pos = (c - l) / rng
        if close_pos < 0.60:
            return 0.0

    # Kapanışlar yükseliyor mu?
    if not (bars[1][1] > bars[0][1] and bars[2][1] > bars[1][1]):
        return 0.0

    # Hacim artıyor mu?
    vol_rising = bars[1][4] >= bars[0][4] and bars[2][4] >= bars[1][4]
    return 1.0 if vol_rising else 0.7


def pat_bullish_harami(df: pd.DataFrame, bi: int) -> float:
    """
    Bullish Harami (Bebek):
    - Dün büyük bearish mum
    - Bugün küçük bullish mum (dü nün body'si içinde)
    Daha zayıf formasyon — genellikle teyide ihtiyaç duyar.
    """
    if bi < 2:
        return 0.0
    o1 = df["open"].iloc[bi-1]; c1 = df["close"].iloc[bi-1]
    o0 = df["open"].iloc[bi];   c0 = df["close"].iloc[bi]

    if not _is_bearish(o1, c1):
        return 0.0
    if not _is_bullish(o0, c0):
        return 0.0
    # Bugünkü body öncekinin içinde mi?
    if not (c0 <= o1 and o0 >= c1):
        return 0.0

    # Küçüklük oranı
    body1 = max(_body(o1, c1), 1e-9)
    body0 = _body(o0, c0)
    if body0 / body1 > 0.5:
        return 0.3
    return 0.6


def pat_doji(df: pd.DataFrame, bi: int) -> float:
    """
    Genel Doji (Tereddüt):
    - Body ≤ toplam range × 0.08
    Belirsizlik anı — bağlamla değerlendirilmeli.
    """
    if bi < 1:
        return 0.0
    o, h, l, c = df["open"].iloc[bi], df["high"].iloc[bi], df["low"].iloc[bi], df["close"].iloc[bi]
    rng = _range(h, l)
    body = _body(o, c)
    if body / rng <= 0.08:
        return 0.8
    return 0.0


# ═══════════════════════════════════════════════════════════════════
# BÖLÜM II — GRAFİK FORMASYONLARI
# ═══════════════════════════════════════════════════════════════════

def pat_vcp_full(df: pd.DataFrame, bi: int) -> float:
    """
    VCP (Volatility Contraction Pattern) tam grafik formasyonu skoru.
    Minervini (2013): Büyük kırılmaların %80'inden fazlası VCP'den gelir.

    Kriterler (0-1 arası puan):
    1. Son 20-60 barda en az 3 contraction (0.30p)
    2. Her contraction bir öncekinden %50 daha dar (0.30p)
    3. Hacim her contraction'da azalıyor (0.20p)
    4. Son contraction hacim VDU durumunda (0.20p)
    """
    if bi < 30:
        return 0.0

    lookback = min(60, bi)
    start    = bi - lookback
    highs    = df["high"].values[start:bi+1]
    lows     = df["low"].values[start:bi+1]
    vols     = df["vol"].values[start:bi+1]
    n        = len(highs)

    # Pivot noktaları (2 bar smooth)
    ph = []  # (index, value)
    pl = []
    for i in range(2, n - 2):
        if highs[i] == max(highs[i-2:i+3]):
            ph.append((i, highs[i]))
        if lows[i] == min(lows[i-2:i+3]):
            pl.append((i, lows[i]))

    if len(ph) < 3 or len(pl) < 2:
        return 0.0

    # Her pivot arasında contraction genişliğini hesapla
    widths = []
    for k in range(min(len(ph), len(pl)) - 1):
        # En son kontraksiyonlara bak
        idx_h = len(ph) - 1 - k
        idx_l = len(pl) - 1 - k
        if idx_h < 0 or idx_l < 0:
            break
        h_val = ph[idx_h][1]
        l_val = pl[idx_l][1]
        if h_val > 0:
            widths.append((h_val - l_val) / h_val)

    if len(widths) < 2:
        return 0.0

    score = 0.0
    # 1. Kontrasyon sayısı (min 3)
    if len(widths) >= 3:
        score += 0.30
    elif len(widths) >= 2:
        score += 0.15

    # 2. Her kontrasyon daraldı mı? (%80 oranı)
    narrowing = sum(1 for i in range(len(widths)-1, 0, -1)
                    if widths[i-1] < widths[i] * 0.90)
    if narrowing >= 2:
        score += 0.30
    elif narrowing >= 1:
        score += 0.15

    # 3. Kontraksyon başına ortalama hacim azalıyor mu?
    if len(ph) >= 3:
        cut = n // 3
        early_vol  = np.mean(vols[:cut])
        recent_vol = np.mean(vols[2*cut:])
        if recent_vol < early_vol * 0.75:
            score += 0.20

    # 4. Son 5 bar VDU
    recent5 = np.mean(vols[-5:])
    avg20   = np.mean(vols[-20:])
    if avg20 > 0 and recent5 < avg20 * 0.60:
        score += 0.20

    return round(min(score, 1.0), 3)


def pat_flag_pennant(df: pd.DataFrame, bi: int) -> float:
    """
    Flag / Pennant (Bayrak / Flama):
    1. 5-15 günlük keskin yükseliş (flagpole): >%8
    2. 5-15 günlük hacim azalmalı konsolidasyon
    3. Konsolidasyon derinliği < flagpole'ün %38'i
    Edwards & Magee: Kırılma hedefi = flagpole boyunda.
    """
    if bi < 25:
        return 0.0

    # Flagpole tespiti (son 15 bar içinde)
    best_score = 0.0
    for pole_len in range(5, 16):
        if bi < pole_len + 5:
            continue
        pole_start = bi - pole_len - 10
        pole_end   = bi - 10
        if pole_end <= pole_start or pole_start < 0:
            continue

        pole_low  = df["low"].values[pole_start:pole_end].min()
        pole_high = df["high"].values[pole_start:pole_end].max()
        if pole_low == 0:
            continue
        pole_gain = (pole_high - pole_low) / pole_low

        if pole_gain < 0.08:
            continue  # Yetersiz flagpole

        # Konsolidasyon bölgesi (son 10 bar)
        cons_bars = df.iloc[bi-9:bi+1]
        cons_high = cons_bars["high"].max()
        cons_low  = cons_bars["low"].min()
        cons_range = (cons_high - cons_low) / pole_high if pole_high > 0 else 1.0

        # Konsolidasyon derinliği < %38.2 Fibonacci
        if cons_range > 0.40:
            continue

        # Hacim azalması konsolidasyonda
        vol_cons = cons_bars["vol"].mean()
        vol_pole = df["vol"].values[pole_start:pole_end].mean()
        vol_declining = vol_cons < vol_pole * 0.70

        # Konsolidasyon fiyatların flagpole üst yarısında
        in_upper_half = cons_low > (pole_low + (pole_high - pole_low) * 0.50)

        s = 0.4
        if vol_declining:
            s += 0.3
        if in_upper_half:
            s += 0.2
        s += max(0, (0.40 - cons_range) / 0.40 * 0.1)

        best_score = max(best_score, s)

    return round(min(best_score, 1.0), 3)


def pat_double_bottom(df: pd.DataFrame, bi: int) -> float:
    """
    Double Bottom (W Formasyonu):
    - İki yakın seviyede dip (fark < %3)
    - İkinci dip birinciden biraz yüksek (düşmeyen alıcı)
    - Dipten sonra hacim artarak yükseliş
    - Neckline (boyun çizgisi) kırılması yakın
    """
    if bi < 30:
        return 0.0

    lookback = min(60, bi)
    start    = bi - lookback
    lows     = df["low"].values[start:bi+1]
    highs    = df["high"].values[start:bi+1]
    vols     = df["vol"].values[start:bi+1]
    n        = len(lows)

    # Yerel dip noktaları
    bottoms = []
    for i in range(2, n - 2):
        if lows[i] == min(lows[i-2:i+3]):
            bottoms.append((i, lows[i]))

    if len(bottoms) < 2:
        return 0.0

    # Son iki dip
    b1_i, b1_v = bottoms[-2]
    b2_i, b2_v = bottoms[-1]

    if b2_i <= b1_i or (b2_i - b1_i) < 5:
        return 0.0  # Çok yakın dippler

    # Diplar yakın fiyatta mı?
    if b1_v == 0:
        return 0.0
    diff = abs(b2_v - b1_v) / b1_v
    if diff > 0.04:
        return 0.0

    # İkinci dip biraz daha yüksek (daha güçlü)
    higher_low = b2_v > b1_v

    # Dipten sonra hacim artıyor mu?
    vol_after_b2 = np.mean(vols[b2_i:]) if b2_i < n - 1 else 1
    vol_at_b2    = vols[b2_i]
    vol_confirming = vol_after_b2 > vol_at_b2 * 0.8

    # Neckline: diplar arası en yüksek
    neckline = max(highs[b1_i:b2_i+1])
    cl = df["close"].iloc[bi]
    near_neckline = cl >= neckline * 0.97 if neckline > 0 else False

    score = 0.5
    if higher_low:      score += 0.2
    if vol_confirming:  score += 0.15
    if near_neckline:   score += 0.15
    return round(min(score, 1.0), 3)


def pat_ascending_triangle(df: pd.DataFrame, bi: int) -> float:
    """
    Ascending Triangle (Yükselen Üçgen):
    - Yatay direnç (tepeler benzer seviye)
    - Yükselen dipler (trend çizgisi yukarı)
    - Hacim kırılma yaklaştıkça azalıyor
    Edwards & Magee: %63 bullish kırılma ihtimali.
    """
    if bi < 20:
        return 0.0

    lookback = min(40, bi)
    start    = bi - lookback
    highs    = df["high"].values[start:bi+1]
    lows     = df["low"].values[start:bi+1]
    vols     = df["vol"].values[start:bi+1]
    n        = len(highs)

    # Zirve noktaları
    peaks = [(i, highs[i]) for i in range(2, n-1)
             if highs[i] >= highs[i-1] and highs[i] >= highs[i+1]]

    if len(peaks) < 2:
        return 0.0

    # Tepeler yatay mı? (son 3 tepe benzer seviyede, ±3%)
    last_peaks = peaks[-3:] if len(peaks) >= 3 else peaks
    peak_vals  = [p[1] for p in last_peaks]
    peak_std   = np.std(peak_vals) / (np.mean(peak_vals) + 1e-9)
    if peak_std > 0.03:
        return 0.0

    # Dipler yükseliyor mu?
    troughs = [(i, lows[i]) for i in range(2, n-1)
               if lows[i] <= lows[i-1] and lows[i] <= lows[i+1]]
    if len(troughs) < 2:
        return 0.0

    last_troughs = troughs[-3:]
    trough_vals  = [t[1] for t in last_troughs]
    rising_troughs = all(trough_vals[i] < trough_vals[i+1]
                         for i in range(len(trough_vals)-1))

    if not rising_troughs:
        return 0.0

    # Hacim azalması
    vol_recent = np.mean(vols[-5:])
    vol_avg    = np.mean(vols)
    vol_declining = vol_recent < vol_avg * 0.80

    score = 0.5
    if vol_declining:  score += 0.3
    score += max(0, (0.03 - peak_std) / 0.03 * 0.2)
    return round(min(score, 1.0), 3)


# ═══════════════════════════════════════════════════════════════════
# ANA FONKSİYON: TÜM FORMASYONLARI HESAPLA
# ═══════════════════════════════════════════════════════════════════

def detect_all_patterns(df: pd.DataFrame, bi: int = None) -> Dict[str, float]:
    """
    Tüm mum ve grafik formasyonlarını tespit eder.
    Çıktı: Her formasyon için 0.0–1.0 güven skoru.
    """
    if df is None or len(df) < 10:
        return {}

    if bi is None:
        bi = len(df) - 1

    pats: Dict[str, float] = {}

    # ── Mum Formasyonları ──────────────────────────────────────────
    pats["hammer"]             = pat_hammer(df, bi)
    pats["pin_bar"]            = pat_pin_bar(df, bi)
    pats["bullish_engulfing"]  = pat_bullish_engulfing(df, bi)
    pats["morning_star"]       = pat_morning_star(df, bi)
    pats["dragonfly_doji"]     = pat_dragonfly_doji(df, bi)
    pats["three_white_soldiers"] = pat_three_white_soldiers(df, bi)
    pats["bullish_harami"]     = pat_bullish_harami(df, bi)
    pats["doji"]               = pat_doji(df, bi)

    # ── Grafik Formasyonları ───────────────────────────────────────
    pats["vcp_full"]           = pat_vcp_full(df, bi)
    pats["flag_pennant"]       = pat_flag_pennant(df, bi)
    pats["double_bottom"]      = pat_double_bottom(df, bi)
    pats["ascending_triangle"] = pat_ascending_triangle(df, bi)

    # Güvenlik: tüm değerleri [0.0, 1.0] aralığına sınırla
    import math
    for key in pats:
        v = pats[key]
        if not isinstance(v, (int, float)) or math.isnan(v) or math.isinf(v):
            pats[key] = 0.0
        else:
            pats[key] = max(0.0, min(1.0, float(v)))

    return pats


def get_pattern_summary(pats: Dict[str, float], threshold: float = 0.5) -> list:
    """Eşiği geçen formasyonları listele."""
    return sorted(
        [(k, v) for k, v in pats.items() if v >= threshold],
        key=lambda x: -x[1]
    )
