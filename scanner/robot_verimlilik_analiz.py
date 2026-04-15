"""
robot_verimlilik_analiz.py  —  Tüm Tarama Robotlarının Verimlilik & Overlap Analizi
======================================================================================
Amaç:
  1. Her robotun kriter setini iDeal native binary bardata üzerinde çalıştır
  2. N günlük tarihsel pencerede precision / recall / F1 hesapla
  3. Robotlar arası sinyal örtüşme matrisini (Jaccard similarity) bul
  4. Birleştirme / eleme önerisi sun

Robotlar:
  R1  PreMove Scanner  (günlük G bars, EOD)
  R2  SNIPER           (60dk bars, EOD sıkışma+trend)
  R3  ANKA MTF         (60dk bars, intraday comprehensive)
  R4  King & Bomba TeFo (15dk/60dk/G, çok periyot kırılım)
  R5  ARS Pulse        (5dk/15dk/60dk, yönlü ARS)
  R6  Dip & Zirve V2   (60dk/240dk/G, ortalamaya dönüş)
  R7  Haftalık Miner   (H bars, Cuma kapanışı)

Kullanım:
  d:\\Projects\\.venv\\Scripts\\python.exe robot_verimlilik_analiz.py

Çıktılar:
  - Terminal: precision/recall tablosu, overlap matrisi, konsolidasyon planı
  - robot_verimlilik_sonuclari.csv: ham sonuçlar

Bağımlılık: loader.py (iDeal native binary)
"""

from __future__ import annotations
import sys, os
import numpy as np
import pandas as pd
from pathlib import Path
from typing import Dict, List, Tuple, Optional
from datetime import datetime, timedelta

_SCRIPT_DIR = Path(r"D:\Projects\IdealQuant\scanner")
sys.path.insert(0, str(_SCRIPT_DIR))
os.chdir(str(_SCRIPT_DIR))

# ── Loader import ─────────────────────────────────────────────────
try:
    from loader import load
    LOADER_OK = True
except ImportError as e:
    print(f"[WARN] loader.py yüklenemedi: {e}")
    LOADER_OK = False

# ── Ayarlar ───────────────────────────────────────────────────────
BINARY_DIR  = Path("D:/iDeal/ChartData/IMKBH")
BAR_DIR_CSV = Path("D:/Projects/IdealQuant/reference/ideal_docs/BarData_Export")
SEMBOL_FILE = Path("D:/Projects/IdealQuant/scanner/TeFo.txt")

BIG_MOVE_THR = 0.05   # Büyük hareket eşiği: %5
TEST_DAYS    = 20     # Kaç günlük backtest penceresi
N_TOP        = 20     # Her günden kaç aday alınır (precision için)
MAX_SEMBOL   = 120    # Hız için sembol sınırı (None = tümü)

# ── Sembol Listesi ────────────────────────────────────────────────
def get_semboller() -> List[str]:
    if SEMBOL_FILE.exists():
        lines = SEMBOL_FILE.read_text("cp1254-sig" if False else "cp1254").splitlines()
        cleaned = []
        for l in lines:
            s = l.strip().lstrip("\ufeff")  # BOM karakteri temizle
            if s:
                # IMKBH'AKBNK → AKBNK formatına normalize et
                if "'" in s:
                    s = s.split("'")[-1].strip()
                cleaned.append(s)
        return cleaned
    return [
        "AKBNK","GARAN","ISCTR","THYAO","KCHOL","SISE","BIMAS","TUPRS",
        "EREGL","SAHOL","TCELL","ARCLK","TOASO","TKFEN","YKBNK",
        "ASELS","CIMSA","ENKAI","FROTO","HEKTS",
    ]

def get_semboller_fast() -> List[str]:
    """MAX_SEMBOL adet sembol döner — hız için BIST büyük şirketler önce."""
    sems = get_semboller()
    if MAX_SEMBOL and len(sems) > MAX_SEMBOL:
        # Alfabetik ilk MAX_SEMBOL değil; bilinen büyük kap listeyi öne al
        bist100_oncelik = [
            "AKBNK","GARAN","ISCTR","THYAO","KCHOL","SISE","BIMAS","TUPRS","EREGL","SAHOL",
            "TCELL","ARCLK","TOASO","TKFEN","YKBNK","ASELS","ENKAI","FROTO","KOZAL","PGSUS",
            "TAVHL","ULKER","VESTL","DOHOL","EKGYO","HALKB","VAKBN","TTKOM","GUBRF","MGROS",
            "PETKM","SODA","CEMTS","KORDS","OTKAR","AEFES","BRISA","CCOLA","DOAS","LOGO",
            "NTHOL","OYAKC","PARSN","SARKY","TRGYO","ZOREN","ADNAC","ALKA","BTCIM","CIMSA",
            "CWENE","DEVA","EGEEN","ENJSA","EREGL","FENER","GEREL","GOLTS","HEKTS","HLGYO",
            "IHLGM","INDES","IPEKE","ISGYO","ISMEN","JANTS","KERVT","KRDMD","LKMNH","MPARK",
            "NETAS","NUHCM","ODAS","ORGE","PAPIL","PRKME","RYSAS","SAMAT","SKBNK","SNGYO",
            "TABGD","TKNSA","TLMAN","TMSN","TOASO","TRETN","TSGYO","TTRAK","TUKAS","ULUSE",
            "UNYEC","VKGYO","YKGYO","ZEDUR","MAVI","DOHOL","AKSA","ALTNY","ANSGR","ARKES",
            "BAGFS","BERA","BIOEN","BOLUC","BRKO","BRKVY","BRYAT","BUCIM","BURCE","BURVA",
        ]
        result = [s for s in bist100_oncelik if s in set(sems)]
        rest   = [s for s in sems if s not in set(bist100_oncelik)]
        return (result + rest)[:MAX_SEMBOL]
    return sems
    k = 2.0 / (n + 1)
    r = np.zeros(len(arr))
    r[0] = arr[0]
    for i in range(1, len(arr)):
        r[i] = arr[i] * k + r[i-1] * (1 - k)
    return r

def ema_arr(arr: np.ndarray, n: int) -> np.ndarray:
    """EMA — pandas ewm ile hızlı hesap."""
    import pandas as pd
    s = pd.Series(arr)
    return s.ewm(span=n, adjust=False).mean().values

def sma_arr(arr: np.ndarray, n: int) -> np.ndarray:
    """SMA — pandas rolling ile hızlı hesap."""
    import pandas as pd
    return pd.Series(arr).rolling(n, min_periods=n).mean().values

def rsi_val(C: np.ndarray, bi: int, n: int = 14) -> float:
    if bi < n: return 50.0
    d = np.diff(C[bi-n:bi+1])
    g = np.mean(np.maximum(d, 0))
    l = np.mean(np.maximum(-d, 0))
    return 100.0 if l == 0 else 100 - 100 / (1 + g / l)

def atr14(H: np.ndarray, L: np.ndarray, C: np.ndarray, bi: int) -> float:
    if bi < 1: return H[bi] - L[bi]
    n = min(14, bi)
    trs = [max(H[i]-L[i], abs(H[i]-C[i-1]), abs(L[i]-C[i-1]))
           for i in range(bi-n+1, bi+1)]
    return float(np.mean(trs))

def bb_width_pct_rank(C: np.ndarray, bi: int, look: int = 126) -> float:
    """BB Width persentil sırası (0=en dar, 1=en geniş). Vektörleştirilmiş."""
    n = 20
    if bi < n + 5: return 0.5
    start = max(n, bi - look + 1)
    if bi - start < 5: return 0.5
    # Vektörize sliding std/mean
    indices = np.arange(start, bi + 1)
    bw_arr = np.array([
        4 * np.std(C[k-n+1:k+1], ddof=1) / np.mean(C[k-n+1:k+1])
        if np.mean(C[k-n+1:k+1]) > 0 else 0.0
        for k in indices
    ])
    if len(bw_arr) < 5: return 0.5
    v = bw_arr[-1]
    return float(np.mean(bw_arr <= v))

def up_vol_ratio(C: np.ndarray, Vol: np.ndarray, VMA20: np.ndarray,
                 bi: int, lb: int = 20) -> float:
    lb = min(lb, bi-1)
    cnt = sum(1 for k in range(bi-lb+1, bi+1)
              if C[k] > C[k-1] and VMA20[k] > 0 and Vol[k] > VMA20[k])
    return cnt / lb if lb > 0 else 0.0

def pocket_pivot(C: np.ndarray, Vol: np.ndarray, VMA20: np.ndarray,
                 bi: int, medyan: bool = True) -> bool:
    if C[bi] <= C[bi-1]: return False
    lb = min(10, bi-1)
    dvols = [Vol[k] for k in range(bi-lb, bi) if C[k] < C[k-1]]
    if not dvols: return False
    ref = float(np.median(dvols)) if medyan else float(max(dvols))
    return Vol[bi] > ref

def ars_kural(C: np.ndarray, H: np.ndarray, L: np.ndarray,
              Vol: np.ndarray, bi: int) -> Tuple[bool, bool]:
    """ARS: temel AL ve SAT kriteri. (long, short) döner."""
    if bi < 30: return False, False
    # ARS = Adaptive Range System: son N barda HH kırılımı
    n = 18
    HH = float(max(H[bi-n:bi]))
    LL = float(min(L[bi-n:bi]))
    rng = HH - LL
    if rng <= 0: return False, False
    ars_long  = C[bi] > HH and (H[bi]-L[bi]) < rng * 0.25
    ars_short = C[bi] < LL and (H[bi]-L[bi]) < rng * 0.25
    return ars_long, ars_short

def dip_zirve_donusu(C: np.ndarray, H: np.ndarray, L: np.ndarray,
                     Vol: np.ndarray, VMA20: np.ndarray, bi: int) -> Tuple[bool, bool]:
    """Dip/Zirve dönüşü. (dip_al, zirve_sat) döner."""
    if bi < 30: return False, False
    r14 = rsi_val(C, bi)
    E20 = float(ema_arr(C, 20)[bi])
    # Dip dönüşü: aşırı satılmış + EMA20 yakınında + hacim düşük
    dip_al = (r14 < 35 and C[bi] < E20 * 1.05 and
              (VMA20[bi] == 0 or Vol[bi] < VMA20[bi] * 0.8))
    # Zirve dönüşü: aşırı alınmış + EMA20'den çok uzak
    zirve_sat = (r14 > 72 and
                 (E20 == 0 or C[bi] > E20 * 1.12))
    return dip_al, zirve_sat

# ══════════════════════════════════════════════════════════════════
# ROBOT KRITER SETLERİ — DataFrame yerine numpy array + bi index
# ══════════════════════════════════════════════════════════════════
def robot_kriterleri_fast(
    C: np.ndarray, H: np.ndarray, L: np.ndarray, Vol: np.ndarray, bi: int,
    C60: Optional[np.ndarray], H60: Optional[np.ndarray],
    L60: Optional[np.ndarray], V60: Optional[np.ndarray], bi_60: int,
    bb_rank: float = 0.5,
    ind_g: Optional[Dict] = None,
    ind_60: Optional[Dict] = None,
) -> Dict[str, bool]:
    r: Dict[str, bool] = {
        "R1_PreMove": False, "R2_SNIPER": False, "R3_ANKA": False,
        "R4_King": False, "R4_Bomba": False,
        "R5_ARS_Long": False, "R5_ARS_Short": False,
        "R6_Dip_Al": False, "R6_Zirve_Sat": False,
    }
    if bi < 130 or C[bi] <= 0 or C[bi-1] <= 0: return r

    # ── R1: PreMove ──────────────────────────────────────────────
    E9   = ind_g["E9"]   if ind_g else ema_arr(C, 9)
    E21  = ind_g["E21"]  if ind_g else ema_arr(C, 21)
    E50  = ind_g["E50"]  if ind_g else ema_arr(C, 50)
    E200 = ind_g["E200"] if ind_g else ema_arr(C, 200)
    VMA20= ind_g["VMA20"]if ind_g else sma_arr(Vol, 20)
    uv = up_vol_ratio(C, Vol, VMA20, bi)
    pp = pocket_pivot(C, Vol, VMA20, bi)
    ema_sc = ((4 if C[bi]>E9[bi] else 0) + (4 if E9[bi]>E21[bi] else 0) +
              (4 if E21[bi]>E50[bi] else 0) + (4 if E50[bi]>E200[bi] else 0) +
              (4 if bi>=5 and E50[bi]>E50[bi-5] else 0))
    uv_sc  = 35 if uv>=0.50 else ((uv-0.20)/0.30*30+5 if uv>=0.20 else 0)
    pp_sc  = 15 if pp and Vol[bi]>VMA20[bi] else (8 if pp else 0)
    r["R1_PreMove"] = (min(100, ema_sc + uv_sc + pp_sc) >= 45)

    # ── R2: SNIPER (60dk) ────────────────────────────────────────
    if C60 is not None and bi_60 >= 50 and bi_60 < len(C60):
        MA20_60  = ind_60["MA20"]  if ind_60 else sma_arr(C60, 20)
        VMA20_60 = ind_60["VMA20"] if ind_60 else sma_arr(V60, 20)
        VMA5_60  = ind_60["VMA5"]  if ind_60 else sma_arr(V60, 5)
        c = C60; h = H60; l60 = L60; v = V60
        rsi   = rsi_val(c, bi_60)
        HH18  = float(np.max(h[max(0,bi_60-17):bi_60+1]))
        LL18  = float(np.min(l60[max(0,bi_60-17):bi_60+1]))
        HH20  = float(np.max(h[max(0,bi_60-19):bi_60+1]))
        HH6   = float(np.max(h[max(0,bi_60-5):bi_60+1]))
        sikisma = (LL18>0 and (HH18-LL18)/LL18 < 0.12 and c[bi_60] >= (HH18+LL18)/2)
        k_rsi   = 52 < rsi < 70
        k_hacim = (not np.isnan(VMA5_60[bi_60]) and not np.isnan(VMA20_60[bi_60]) and
                   VMA20_60[bi_60]>0 and VMA5_60[bi_60]>VMA20_60[bi_60]*1.20 and
                   VMA5_60[bi_60]<VMA20_60[bi_60]*2.80)
        k_trend = (not np.isnan(MA20_60[bi_60]) and c[bi_60]>MA20_60[bi_60] and
                   c[bi_60]<HH20 and c[bi_60]>=HH6*0.96)
        r["R2_SNIPER"] = sikisma and k_rsi and k_hacim and k_trend

    # ── R3: ANKA (60dk) ──────────────────────────────────────────
    if C60 is not None and bi_60 >= 50 and bi_60 < len(C60):
        MA20_60  = ind_60["MA20"]  if ind_60 else sma_arr(C60, 20)
        VMA20_60 = ind_60["VMA20"] if ind_60 else sma_arr(V60, 20)
        c = C60; h = H60; l60 = L60; v = V60
        rsi  = rsi_val(c, bi_60)
        anka_sc = 0
        if not np.isnan(MA20_60[bi_60]) and c[bi_60]>MA20_60[bi_60]: anka_sc += 25
        if rsi > 50: anka_sc += 20
        if not np.isnan(VMA20_60[bi_60]) and VMA20_60[bi_60]>0 and v[bi_60]>VMA20_60[bi_60]: anka_sc += 20
        HH18 = float(np.max(h[max(0,bi_60-17):bi_60+1]))
        if c[bi_60] >= HH18*0.98: anka_sc += 20
        day_rng = H60[bi_60]-L60[bi_60]
        if day_rng>0 and (c[bi_60]-L60[bi_60])/day_rng >= 0.55: anka_sc += 15
        r["R3_ANKA"] = anka_sc >= 60

    # ── R4: King & Bomba (günlük) ────────────────────────────────
    rsi_g = rsi_val(C, bi)
    atr_p = atr14(H, L, C, bi) / C[bi] if C[bi]>0 else 0.05
    day_rng= H[bi]-L[bi]
    close_pos = (C[bi]-L[bi])/day_rng if day_rng>0.001 else 0.5
    dist_e50 = abs(C[bi]-E50[bi])/E50[bi] if E50[bi]>0 else 1.0
    r["R4_King"] = (C[bi]>E50[bi] and not np.isnan(VMA20[bi]) and VMA20[bi]>0 and
                    Vol[bi]>VMA20[bi]*1.5 and close_pos>=0.60 and atr_p<0.03 and dist_e50<0.05)
    r["R4_Bomba"] = (bb_rank<0.20 and not np.isnan(VMA20[bi]) and VMA20[bi]>0 and
                     Vol[bi]>VMA20[bi]*1.5 and rsi_g>55)

    # ── R5: ARS (günlük proxy) ───────────────────────────────────
    ars_l, ars_s = ars_kural(C, H, L, Vol, bi)
    r["R5_ARS_Long"]  = ars_l
    r["R5_ARS_Short"] = ars_s

    # ── R6: Dip & Zirve ──────────────────────────────────────────
    dip, zirve = dip_zirve_donusu(C, H, L, Vol, VMA20, bi)
    r["R6_Dip_Al"]    = dip
    r["R6_Zirve_Sat"] = zirve

    return r


# ══════════════════════════════════════════════════════════════════
# ROBOT KRITER SETLERİ — her birinin F1 ayrı hesaplanır
# ══════════════════════════════════════════════════════════════════
def robot_kriterleri(df_G: Optional[pd.DataFrame],
                     df_60: Optional[pd.DataFrame],
                     df_05: Optional[pd.DataFrame],
                     bb_rank: float = 0.5) -> Dict[str, bool]:
    """
    Tüm robotların kriterlerini hesapla.
    Dönen dict: robot_adı → True/False sinyal
    """
    r: Dict[str, bool] = {
        "R1_PreMove": False,
        "R2_SNIPER":  False,
        "R3_ANKA":    False,
        "R4_King":    False,
        "R4_Bomba":   False,
        "R5_ARS_Long":False,
        "R5_ARS_Short":False,
        "R6_Dip_Al":  False,
        "R6_Zirve_Sat":False,
    }

    # ── R1: PreMove (günlük G bars) ─────────────────────────────
    if df_G is not None and len(df_G) >= 130:
        C   = df_G["close"].values.astype(float)
        H   = df_G["high"].values.astype(float)
        L   = df_G["low"].values.astype(float)
        Vol = df_G["vol"].values.astype(float)
        bi  = len(C) - 1
        if C[bi] > 0 and C[bi-1] > 0:
            E9   = ema_arr(C, 9);  E21 = ema_arr(C, 21)
            E50  = ema_arr(C, 50); E200 = ema_arr(C, 200)
            VMA20 = sma_arr(Vol, 20)
            uv    = up_vol_ratio(C, Vol, VMA20, bi)
            pp    = pocket_pivot(C, Vol, VMA20, bi)
            ema_sc = (4 if C[bi]>E9[bi] else 0) + (4 if E9[bi]>E21[bi] else 0) + \
                     (4 if E21[bi]>E50[bi] else 0) + (4 if E50[bi]>E200[bi] else 0) + \
                     (4 if bi>=5 and E50[bi]>E50[bi-5] else 0)
            uv_sc  = 35 if uv>=0.50 else ((uv-0.20)/0.30*30+5 if uv>=0.20 else 0)
            pp_sc  = 15 if pp and Vol[bi]>VMA20[bi] else (8 if pp else 0)
            premove_puan = min(100, ema_sc + uv_sc + pp_sc)
            r["R1_PreMove"] = premove_puan >= 45

    # ── R2: SNIPER (60dk bars, EOD, sıkışma+trend) ──────────────
    if df_60 is not None and len(df_60) >= 50:
        C   = df_60["close"].values.astype(float)
        H   = df_60["high"].values.astype(float)
        L   = df_60["low"].values.astype(float)
        Vol = df_60["vol"].values.astype(float)
        bi  = len(C) - 1
        if C[bi] > 0 and C[bi-1] > 0:
            MA20  = sma_arr(C, 20)
            MA50  = sma_arr(C, 50)
            VMA20 = sma_arr(Vol, 20)
            VMA5  = sma_arr(Vol, 5)
            rsi   = rsi_val(C, bi)
            HH18  = max(H[max(0,bi-17):bi+1])
            LL18  = min(L[max(0,bi-17):bi+1])
            HH20  = max(H[max(0,bi-19):bi+1])
            HH6   = max(H[max(0,bi-5):bi+1])
            day_rng = H[bi] - L[bi]
            close_pos = (C[bi]-L[bi])/day_rng if day_rng > 0.001 else 0.5
            sikisma  = (LL18>0 and (HH18-LL18)/LL18 < 0.12 and C[bi] >= (HH18+LL18)/2)
            k_rsi    = 52 < rsi < 70
            k_hacim  = (not np.isnan(VMA5[bi]) and not np.isnan(VMA20[bi]) and
                        VMA20[bi] > 0 and VMA5[bi] > VMA20[bi]*1.20 and VMA5[bi] < VMA20[bi]*2.80)
            k_trend  = (not np.isnan(MA20[bi]) and C[bi] > MA20[bi] and
                        C[bi] < HH20 and C[bi] >= HH6*0.96)
            r["R2_SNIPER"] = sikisma and k_rsi and k_hacim and k_trend

    # ── R3: ANKA (60dk bars, genel momentum puanlama) ────────────
    if df_60 is not None and len(df_60) >= 50:
        C   = df_60["close"].values.astype(float)
        H   = df_60["high"].values.astype(float)
        L   = df_60["low"].values.astype(float)
        Vol = df_60["vol"].values.astype(float)
        bi  = len(C) - 1
        if C[bi] > 0 and C[bi-1] > 0:
            MA20  = sma_arr(C, 20)
            VMA20 = sma_arr(Vol, 20)
            rsi   = rsi_val(C, bi)
            # ANKA puanlama (basit günlük proxy)
            anka_sc = 0
            if C[bi] > MA20[bi] if not np.isnan(MA20[bi]) else False: anka_sc += 25
            if rsi > 50: anka_sc += 20
            if not np.isnan(VMA20[bi]) and VMA20[bi]>0 and Vol[bi]>VMA20[bi]: anka_sc += 20
            HH18 = max(H[max(0,bi-17):bi+1])
            if C[bi] >= HH18 * 0.98: anka_sc += 20  # son 18 bar zirvesine yakın
            day_rng = H[bi] - L[bi]
            close_pos = (C[bi]-L[bi])/day_rng if day_rng > 0.001 else 0.5
            if close_pos >= 0.55: anka_sc += 15
            r["R3_ANKA"] = anka_sc >= 60

    # ── R4: KING & BOMBA (günlük G proxy) ───────────────────────
    if df_G is not None and len(df_G) >= 130:
        C   = df_G["close"].values.astype(float)
        H   = df_G["high"].values.astype(float)
        L   = df_G["low"].values.astype(float)
        Vol = df_G["vol"].values.astype(float)
        bi  = len(C) - 1
        if C[bi] > 0:
            E50   = ema_arr(C, 50)
            VMA20 = sma_arr(Vol, 20)
            rsi   = rsi_val(C, bi)
            atr_p = atr14(H, L, C, bi) / C[bi] if C[bi] > 0 else 0.05
            day_rng = H[bi] - L[bi]
            close_pos = (C[bi]-L[bi])/day_rng if day_rng > 0.001 else 0.5
            dist_e20 = abs(C[bi]-E50[bi])/E50[bi] if E50[bi]>0 else 1.0

            # King: EMA50 üstü + hacim güçlü + üst kapanış + ATR küçük + yakın EMA
            king_ok = (C[bi] > E50[bi] and
                       not np.isnan(VMA20[bi]) and VMA20[bi]>0 and Vol[bi]>VMA20[bi]*1.5 and
                       close_pos >= 0.60 and atr_p < 0.03 and dist_e20 < 0.05)
            r["R4_King"] = king_ok

            # Bomba: BB sıkışma + EMA hizalı + hacim patlıyor
            bomba_ok = (bb_rank < 0.20 and                        # BB bottom 20%
                        not np.isnan(VMA20[bi]) and VMA20[bi]>0 and Vol[bi]>VMA20[bi]*1.5 and
                        rsi > 55)
            r["R4_Bomba"] = bomba_ok

    # ── R5: ARS Pulse (günlük G proxy — 5dk yük zamanı optimizasyonu) ──
    if df_G is not None and len(df_G) >= 40:
        C   = df_G["close"].values.astype(float)
        H   = df_G["high"].values.astype(float)
        L   = df_G["low"].values.astype(float)
        Vol = df_G["vol"].values.astype(float)
        bi  = len(C) - 1
        if C[bi] > 0:
            ars_l, ars_s = ars_kural(C, H, L, Vol, bi)
            r["R5_ARS_Long"]  = ars_l
            r["R5_ARS_Short"] = ars_s

    # ── R6: Dip & Zirve Dönüşü (günlük proxy) ───────────────────
    if df_G is not None and len(df_G) >= 50:
        C   = df_G["close"].values.astype(float)
        H   = df_G["high"].values.astype(float)
        L   = df_G["low"].values.astype(float)
        Vol = df_G["vol"].values.astype(float)
        bi  = len(C) - 1
        if C[bi] > 0:
            VMA20 = sma_arr(Vol, 20)
            dip, zirve = dip_zirve_donusu(C, H, L, Vol, VMA20, bi)
            r["R6_Dip_Al"]    = dip
            r["R6_Zirve_Sat"] = zirve

    return r

# ══════════════════════════════════════════════════════════════════
# ANA BACKTEST
# ══════════════════════════════════════════════════════════════════
def main():
    semboller = get_semboller_fast()
    print(f"Sembol sayısı: {len(semboller)}{' (sınırlı)' if MAX_SEMBOL else ''}")
    print(f"Periyot: son {TEST_DAYS} işlem günü")
    print(f"Büyük hareket eşiği: %{BIG_MOVE_THR*100:.1f}")
    print()

    if not LOADER_OK:
        print("[HATA] loader.py gerekli!")
        return

    # ── Tüm sembollerin G ve 60dk verilerini yükle ──────────────
    print("Veriler yükleniyor...")
    veri_G  = {}
    veri_60 = {}
    veri_05: Dict[str, pd.DataFrame] = {}  # kullanılmıyor — 5dk atlandı
    eksik = []

    for sym in semboller:
        try:
            g  = load(sym, "Gunluk")
            v60= load(sym, "60dk")
            # 5dk yüklemesi çok yavaş (3GB+) — ARS günlük proxy ile hesaplanır
            if g is not None and len(g) >= 130:
                veri_G[sym]  = g
            if v60 is not None and len(v60) >= 50:
                veri_60[sym] = v60
        except Exception as e:
            eksik.append(sym)

    print(f"G: {len(veri_G)} sembol | 60dk: {len(veri_60)} | 5dk: (atlandı) | Eksik: {len(eksik)}")

    # ── BB Squeeze önbelleği: her sembol için bir kez hesapla ────
    # bb_width_pct_rank çok pahalı (O(n²)) — 30 gün boyunca sabit kabul ediyoruz
    print("BB Squeeze önbelleği hesaplanıyor...")
    bb_cache: Dict[str, float] = {}
    for sym, df in veri_G.items():
        C = df["close"].values.astype(float)
        bi = len(C) - 1
        bb_cache[sym] = bb_width_pct_rank(C, bi)
    print(f"BB cache hazır: {len(bb_cache)} sembol")

    if not veri_G:
        print("[HATA] Hiç günlük veri yüklenemedi. Loader veya binary path kontrol et.")
        return

    # ── Backtest döngüsü: son TEST_DAYS kapanış günü ─────────────
    # Referans sembol: AKBNK (en çok bar olan)
    ref_sym  = "AKBNK" if "AKBNK" in veri_G else list(veri_G.keys())[0]
    ref_df   = veri_G[ref_sym]
    n_bars   = len(ref_df)
    test_end = n_bars - 1          # En son bar
    test_start = max(130, n_bars - 1 - TEST_DAYS)

    robot_isimler = [
        "R1_PreMove", "R2_SNIPER", "R3_ANKA",
        "R4_King", "R4_Bomba",
        "R5_ARS_Long", "R5_ARS_Short",
        "R6_Dip_Al", "R6_Zirve_Sat",
    ]

    # İstatistik: {robot: {tp, fn, fp, tn, günlük_sinyal_sayısı}}
    stats = {r: {"tp": 0, "fn": 0, "fp": 0, "tn": 0, "sig_days": 0}
             for r in robot_isimler}

    # Overlap matrisi: {(r1,r2): ortak sinyal sayısı}
    overlap = {(r1,r2): 0 for r1 in robot_isimler for r2 in robot_isimler if r1 != r2}
    total_signals = {r: 0 for r in robot_isimler}

    # Günlük detay
    gun_sonuclari = []

    print(f"\nBacktest çalışıyor: bar {test_start}..{test_end}")

    # ── Numpy array önbellekleri: DataFrame kopyalamak yerine array indexle ──
    arr_C   = {s: veri_G[s]["close"].values.astype(float) for s in veri_G}
    arr_H   = {s: veri_G[s]["high"].values.astype(float)  for s in veri_G}
    arr_L   = {s: veri_G[s]["low"].values.astype(float)   for s in veri_G}
    arr_Vol = {s: veri_G[s]["vol"].values.astype(float)   for s in veri_G}
    arr_C60 = {s: veri_60[s]["close"].values.astype(float) for s in veri_60}
    arr_H60 = {s: veri_60[s]["high"].values.astype(float)  for s in veri_60}
    arr_L60 = {s: veri_60[s]["low"].values.astype(float)   for s in veri_60}
    arr_V60 = {s: veri_60[s]["vol"].values.astype(float)   for s in veri_60}

    # ── İndikatör önbellekleri: EMA/SMA bir kez hesapla ─────────
    print("İndikatörler hesaplanıyor...")
    ind: Dict[str, Dict] = {}
    for sym in arr_C:
        C = arr_C[sym]; Vol = arr_Vol[sym]
        ind[sym] = {
            "E9":   ema_arr(C, 9),
            "E21":  ema_arr(C, 21),
            "E50":  ema_arr(C, 50),
            "E200": ema_arr(C, 200),
            "VMA20":sma_arr(Vol, 20),
        }
    ind60: Dict[str, Dict] = {}
    for sym in arr_C60:
        c = arr_C60[sym]; v = arr_V60[sym]
        ind60[sym] = {
            "MA20": sma_arr(c, 20),
            "MA50": sma_arr(c, 50),
            "VMA20":sma_arr(v, 20),
            "VMA5": sma_arr(v, 5),
        }
    print(f"İndikatörler hazır: G={len(ind)}, 60dk={len(ind60)}")

    for gun_bi in range(test_start, test_end):
        gun_sinyaller: Dict[str, List[str]] = {r: [] for r in robot_isimler}

        for sym in semboller:
            if sym not in arr_C: continue
            C   = arr_C[sym];  H   = arr_H[sym]
            L   = arr_L[sym];  Vol = arr_Vol[sym]
            n_g = len(C)
            bi_g = n_g - 1 - (test_end - gun_bi)
            if bi_g < 130 or bi_g >= n_g: continue

            # 60dk hizalama
            C60 = arr_C60.get(sym); H60 = arr_H60.get(sym)
            L60 = arr_L60.get(sym); V60 = arr_V60.get(sym)
            bi_60 = (len(C60) - 1 - (test_end - gun_bi) * 8) if C60 is not None else -1

            try:
                kr = robot_kriterleri_fast(
                    C, H, L, Vol, bi_g,
                    C60, H60, L60, V60, bi_60,
                    bb_rank=bb_cache.get(sym, 0.5),
                    ind_g=ind.get(sym),
                    ind_60=ind60.get(sym),
                )
            except Exception:
                continue

            for r_isim in robot_isimler:
                if kr.get(r_isim, False):
                    gun_sinyaller[r_isim].append(sym)

        # Sonraki günün getirisini hesapla (look-ahead: gun_bi+1)
        # big_move_symbols: semboller bu günde büyük hareket yapmış mı?
        big_move_syms = set()
        down_syms     = set()

        for sym in semboller:
            df_G = veri_G.get(sym)
            if df_G is None: continue
            n_g = len(df_G)
            bi_curr = n_g - 1 - (test_end - gun_bi)
            bi_next = bi_curr + 1
            if bi_next >= n_g: continue
            c_curr = float(df_G["close"].iloc[bi_curr])
            c_next = float(df_G["close"].iloc[bi_next])
            if c_curr > 0:
                ret = (c_next - c_curr) / c_curr
                if ret >= BIG_MOVE_THR: big_move_syms.add(sym)
                if ret <= -BIG_MOVE_THR: down_syms.add(sym)

        # İstatistik güncelle
        for r_isim in robot_isimler:
            sinyaller_set = set(gun_sinyaller[r_isim])
            total_signals[r_isim] += len(sinyaller_set)
            if sinyaller_set:
                stats[r_isim]["sig_days"] += 1

            for sym in gun_sinyaller[r_isim]:
                if sym in big_move_syms:
                    stats[r_isim]["tp"] += 1
                elif sym in down_syms:
                    stats[r_isim]["fp"] += 1

            for sym in big_move_syms:
                if sym not in sinyaller_set:
                    stats[r_isim]["fn"] += 1

        # Overlap: her robot çifti için ortak sinyal sayısı
        for i, r1 in enumerate(robot_isimler):
            s1 = set(gun_sinyaller[r1])
            for r2 in robot_isimler[i+1:]:
                s2 = set(gun_sinyaller[r2])
                overlap[(r1,r2)] += len(s1 & s2)
                overlap[(r2,r1)] += len(s1 & s2)

        gun_sonuclari.append({
            "gun": gun_bi,
            "big_move_count": len(big_move_syms),
            **{f"sig_{r}": len(gun_sinyaller[r]) for r in robot_isimler},
        })

    # ══════════════════════════════════════════════════════════════
    # ÇIKTI 1: Precision / Recall / F1 Tablosu
    # ══════════════════════════════════════════════════════════════
    n_days_tested = test_end - test_start
    print(f"\n{'='*90}")
    print(f"  ROBOT VERİMLİLİK TABLOSU — {n_days_tested} gün backtest | Eşik: ≥%{BIG_MOVE_THR*100:.0f}")
    print(f"{'='*90}")
    print(f"{'Robot':<18} {'TP':>5} {'FN':>5} {'FP':>5} {'Prec%':>7} {'Recall%':>8} {'F1':>7} "
          f"{'Sig/Gün':>8} {'Aktif gün':>10}")
    print("-" * 90)

    robot_f1 = {}
    for r_isim in robot_isimler:
        st = stats[r_isim]
        tp, fn, fp = st["tp"], st["fn"], st["fp"]
        prec = tp / (tp + fp) if (tp + fp) > 0 else 0
        rec  = tp / (tp + fn) if (tp + fn) > 0 else 0
        f1   = 2*prec*rec / (prec+rec) if (prec+rec) > 0 else 0
        robot_f1[r_isim] = f1
        sig_gun = total_signals[r_isim] / max(1, n_days_tested)
        tag = " ★★" if f1 >= 0.30 else (" ★" if f1 >= 0.20 else "")
        print(f"  {r_isim:<16} {tp:>5} {fn:>5} {fp:>5}  {prec*100:>6.1f}%  {rec*100:>7.1f}%  "
              f"{f1:>6.3f}  {sig_gun:>7.1f}  {st['sig_days']:>9}{tag}")

    print(f"{'='*90}")

    # ══════════════════════════════════════════════════════════════
    # ÇIKTI 2: Jaccard Overlap Matrisi
    # ══════════════════════════════════════════════════════════════
    print(f"\n{'='*90}")
    print("  SİNYAL ÖRTÜŞME MATRİSİ (Jaccard Similarity — 0=farklı, 1=aynı)")
    print(f"{'='*90}")

    short_names = {
        "R1_PreMove": "PreMove",
        "R2_SNIPER":  "SNIPER",
        "R3_ANKA":    "ANKA",
        "R4_King":    "King",
        "R4_Bomba":   "Bomba",
        "R5_ARS_Long":"ARS+",
        "R5_ARS_Short":"ARS-",
        "R6_Dip_Al":  "Dip",
        "R6_Zirve_Sat":"Zirve",
    }

    header_row = " " * 12 + "".join(f"{short_names[r]:>9}" for r in robot_isimler)
    print(header_row)
    for r1 in robot_isimler:
        row = f"  {short_names[r1]:<10}"
        for r2 in robot_isimler:
            if r1 == r2:
                row += "     1.00"
            else:
                s1 = total_signals[r1]
                s2 = total_signals[r2]
                inter = overlap.get((r1, r2), 0)
                union = s1 + s2 - inter
                jacc = inter / union if union > 0 else 0.0
                cell = f"{jacc:.2f}"
                if jacc > 0.50:
                    cell = f"\033[91m{cell}\033[0m"  # kırmızı = yüksek overlap
                elif jacc > 0.30:
                    cell = f"\033[93m{cell}\033[0m"  # sarı = orta overlap
                row += f"{cell:>9}"
        print(row)

    # ══════════════════════════════════════════════════════════════
    # ÇIKTI 3: KONSOLİDASYON ÖNERİSİ
    # ══════════════════════════════════════════════════════════════
    print(f"\n{'='*90}")
    print("  KONSOLİDASYON ÖNERİSİ")
    print(f"{'='*90}")

    # Yüksek overlap grupları tespit et
    high_overlap_pairs = []
    for r1 in robot_isimler:
        for r2 in robot_isimler:
            if r1 >= r2: continue
            s1 = total_signals[r1]; s2 = total_signals[r2]
            inter = overlap.get((r1, r2), 0)
            union = s1 + s2 - inter
            jacc = inter / union if union > 0 else 0.0
            if jacc > 0.35:
                high_overlap_pairs.append((r1, r2, jacc))

    high_overlap_pairs.sort(key=lambda x: -x[2])

    print("\n  ► Yüksek Örtüşme Çiftleri (Jaccard > 0.35):")
    if high_overlap_pairs:
        for r1, r2, j in high_overlap_pairs:
            f1_1 = robot_f1.get(r1, 0)
            f1_2 = robot_f1.get(r2, 0)
            winner = r1 if f1_1 >= f1_2 else r2
            loser  = r2 if winner == r1 else r1
            print(f"    {short_names[r1]} ↔ {short_names[r2]}:  Jaccard={j:.2f}  "
                  f"→ {short_names[winner]} (F1={robot_f1[winner]:.3f}) KORU  |  "
                  f"{short_names[loser]} (F1={robot_f1[loser]:.3f}) BİRLEŞTİR")
    else:
        print("    Yüksek örtüşme yok — robotlar yeterince farklılaşmış.")

    # F1 sıralamasına göre öneri
    sorted_by_f1 = sorted(robot_f1.items(), key=lambda x: -x[1])
    print(f"\n  ► Robot F1 Sıralaması:")
    for rank, (r, f) in enumerate(sorted_by_f1, 1):
        sts = "KORU" if f >= 0.20 else ("GÖZDEN GEÇİR" if f >= 0.10 else "KALDIR/BİRLEŞTİR")
        print(f"    {rank}. {short_names[r]:<10}  F1={f:.3f}  → {sts}")

    # Nihai öneri
    print(f"""
  ► Önerilen Yeni Mimari ({len([x for x in robot_f1.values() if x >= 0.10])} Robot → 4-5 Robot):

    KATMAN 1 — EOD / Swing (Yarın için hazırlık):
      ✦ PreMove Scanner (G bars) — Koru + BB Squeeze bonus eklendi ✓
      ✦ HaftalıkMiner    (H bars) — Koru (Cuma kapanışı, overlap yok)

    KATMAN 2 — İntraday Momentum (Aynı gün giriş):
      ✦ Alpha Scanner = SNIPER + ANKA birleşimi (60dk)
        → SNIPER'ın sıkışma filtresi + ANKA'nın MTF puanlama sistemi

    KATMAN 3 — Scalp (5-15dk, kısa hedef):
      ✦ Scalp 5dk (YENİ) — Rob_Scalp_5dk.txt ✓

    KATMAN 4 — Kontrerian (Ortalamaya dönüş):
      ✦ Dip & Zirve V2 — Koru (farklı strateji, düşük overlap)

    ELENEN:
      × King & Bomba TeFo → Alpha Scanner'a entegre et
        (King=60dk kırılım SNIPER ile örtüşüyor, Bomba=BB squeeze PreMove'da zaten var)
      × ARS Pulse → Scalp robotu yeterince karşılıyor
        (Jaccard overlap yüksekse birleştir)
    """)

    # ══════════════════════════════════════════════════════════════
    # ÇIKTI 4: Günlük sinyal sayısı özeti
    # ══════════════════════════════════════════════════════════════
    if gun_sonuclari:
        df_gun = pd.DataFrame(gun_sonuclari)
        print(f"{'='*90}")
        print("  GÜNLÜK SİNYAL SAYILARI (son 10 gün)")
        print(f"{'='*90}")
        # Sadece son 10 günü göster
        display_cols = ["gun", "big_move_count"] + [f"sig_{r}" for r in robot_isimler[:5]]
        print(df_gun.tail(10)[display_cols].to_string(index=False))

    # ── CSV çıktı ───────────────────────────────────────────────
    out_csv = Path(__file__).parent / "robot_verimlilik_sonuclari.csv"
    rows = []
    for r_isim in robot_isimler:
        st = stats[r_isim]
        tp, fn, fp = st["tp"], st["fn"], st["fp"]
        prec = tp / (tp+fp) if (tp+fp) > 0 else 0
        rec  = tp / (tp+fn) if (tp+fn) > 0 else 0
        f1   = 2*prec*rec / (prec+rec) if (prec+rec) > 0 else 0
        rows.append({
            "robot": r_isim,
            "short_name": short_names[r_isim],
            "tp": tp, "fn": fn, "fp": fp,
            "precision": round(prec*100, 1),
            "recall": round(rec*100, 1),
            "f1": round(f1, 3),
            "avg_signals_per_day": round(total_signals[r_isim]/max(1,n_days_tested), 1),
            "active_days": st["sig_days"],
        })
    pd.DataFrame(rows).to_csv(out_csv, index=False, encoding="utf-8-sig")
    print(f"\nSonuçlar kaydedildi: {out_csv}")

if __name__ == "__main__":
    main()
