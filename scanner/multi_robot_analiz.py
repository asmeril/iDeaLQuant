"""
multi_robot_analiz.py — Robot Kriterleri Karşılaştırmalı Analiz
================================================================
Her robot/stratejinin günlük bar bazlı kriterlerini 09.04.2026 kapanış
verisine uygular ve 10.04.2026 sonucuyla karşılaştırır.

Test Edilen Kriterler (18 adet):
  Grup A — Tek Kriter Bazlı (ne kadar tek başına anlamlı?):
    A1. EMA Stack Tam  (4/4 hizalı: C>E9>E21>E50>E200)
    A2. EMA Stack Kısmi (3/4 hizalı: en az C>E9>E21>E50)
    A3. UV≥0.20 tek başına
    A4. UV≥0.25 tek başına
    A5. UV≥0.40 tek başına
    A6. Pocket Pivot (medyan) tek başına
    A7. VCP Formasyon (≥12p) tek başına
    A8. NR7 tek başına
    A9. RSI 45-72 bandı + artıyor

  Grup B — Robot Yaklaşımları (günlük bar uyarlamaları):
    B1. PreMove Mevcut (UV≥0.25, max PP, eşik: 45p)
    B2. PreMove v2 (UV≥0.20, medyan PP, eşik: 45p)
    B3. SNIPER Günlük Filtresi  (AND: c>MA50 + kapş üst%60 + vol>ma20*1.10 + gap<%2.5 + chg<%4)
    B4. KING Global              (AND: c>EMA50 + vol>ma20*1.5 + kapş üst%60 + ATR<%3 + dist_ema20<%5)
    B5. BOMBA Odağı              (BB squeeze<0.15 + C>BB_mid + Vol>MA20*1.5 + RSI>55)
    B6. SNIPER Sıkışma (günlük)  (HH18-LL18 range<%15 + kapş üst%50)
    B7. En Az 2 Kriter Birlikte  (UV + PP + VCP'den en az 2'si TRUE)
    B8. ANKA Günlük Proxy       (RSI>50 + ADX>20 + PDI>MDI + C>SMA20 + Vol>VolMA20)
    B9. K+T Hibrid               (EMA stack ≥3/4 + UV≥0.20 + hacim kalitesi — K+T en iyi stratejiyi taklit)

Çıktı:
  - Her kriter için Precision (kaçını doğru) / Recall (kaçını yakaladı) / F1
  - 63 adet ≥5% hisse üzerinden hesap
  - False positive (düşen ama sinyal veren) analizi
  - KAÇIRILAN büyük hareketler için kriter breakdown

Çalıştır:
  d:\\Projects\\.venv\\Scripts\\python.exe multi_robot_analiz.py
"""

import os, sys, csv
import numpy as np
import pandas as pd
from pathlib import Path

BAR_DIR  = Path("D:/Projects/IdealQuant/reference/ideal_docs/BarData_Export")
CSV_FILE = Path("D:/Projects/IdealQuant/scanner/10.04.2026 Yükselen Düşen tablosu.csv")

# ══════════════════════════════════════════════════════════════════════
# 1. CSV OKU
# ══════════════════════════════════════════════════════════════════════
yukselenler = {}   # sembol → pnl%
dusenler    = {}   # sembol → pnl%

with open(CSV_FILE, "r", encoding="cp1254") as f:
    reader = csv.reader(f, delimiter=";")
    header = next(reader)
    for row in reader:
        if len(row) < 6:
            continue
        try:
            if row[1] and row[2]:
                sym = row[1].strip()
                pct = float(row[2].replace(",", "."))
                yukselenler[sym] = pct
        except: pass
        try:
            if row[3] and row[4]:
                sym = row[3].strip()
                pct = float(row[4].replace(",", "."))
                dusenler[sym] = pct
        except: pass

hit5 = [s for s, p in yukselenler.items() if p >= 5.0]
hit3 = [s for s, p in yukselenler.items() if p >= 3.0]
print(f"10.04.2026 — Yükselenler: {len(yukselenler)}  |  ≥5%: {len(hit5)}  |  ≥3%: {len(hit3)}")
print(f"              Düşenler: {len(dusenler)}")
print()

# ══════════════════════════════════════════════════════════════════════
# 2. YARDIMCI FONKSİYONLAR
# ══════════════════════════════════════════════════════════════════════
def ema(arr, n):
    r = np.zeros(len(arr))
    if len(arr) == 0: return r
    k = 2.0 / (n + 1)
    r[0] = arr[0]
    for i in range(1, len(arr)):
        r[i] = arr[i] * k + r[i-1] * (1-k)
    return r

def sma(arr, n):
    r = np.full(len(arr), np.nan)
    for i in range(n-1, len(arr)):
        r[i] = np.mean(arr[i-n+1:i+1])
    return r

def rsi14(C, bi):
    if bi < 14: return 50.0
    gains = [max(C[k]-C[k-1], 0) for k in range(bi-13, bi+1)]
    losses= [max(C[k-1]-C[k], 0) for k in range(bi-13, bi+1)]
    ag, al = np.mean(gains), np.mean(losses)
    if al == 0: return 100.0
    return 100 - 100/(1 + ag/al)

def adx14(H, L, C, bi):
    """Basit +DI, -DI, ADX hesabı."""
    if bi < 14: return 0.0, 0.0, 0.0
    n = 14
    dm_plus  = [max(H[k]-H[k-1], 0) if (H[k]-H[k-1]) > (L[k-1]-L[k]) else 0.0 for k in range(bi-n+1, bi+1)]
    dm_minus = [max(L[k-1]-L[k], 0) if (L[k-1]-L[k]) > (H[k]-H[k-1]) else 0.0 for k in range(bi-n+1, bi+1)]
    tr       = [max(H[k]-L[k], abs(H[k]-C[k-1]), abs(L[k]-C[k-1])) for k in range(bi-n+1, bi+1)]
    atr  = np.mean(tr) if np.mean(tr) > 0 else 1.0
    pdi  = np.mean(dm_plus)  / atr * 100
    mdi  = np.mean(dm_minus) / atr * 100
    dx   = abs(pdi - mdi) / (pdi + mdi) * 100 if (pdi + mdi) > 0 else 0.0
    return pdi, mdi, dx

def bb_metrics(C, bi, n=20, std_mult=2.0):
    """BB mid, width (width/mid), C > BB_up."""
    if bi < n: return np.nan, np.nan, False
    window = C[bi-n+1:bi+1]
    mid    = np.mean(window)
    std    = np.std(window, ddof=1)
    up     = mid + std_mult * std
    down   = mid - std_mult * std
    width  = (up - down) / mid if mid > 0 else 0.0
    return mid, width, C[bi] > up

def atr14_pct(H, L, C, bi):
    if bi < 14: return 0.05
    trs = [max(H[k]-L[k], abs(H[k]-C[k-1]), abs(L[k]-C[k-1])) for k in range(bi-13, bi+1)]
    return np.mean(trs) / C[bi] if C[bi] > 0 else 0.05

# ══════════════════════════════════════════════════════════════════════
# 3. BAR YÜKLE
# ══════════════════════════════════════════════════════════════════════
def load_bar(sembol):
    fn = BAR_DIR / f"{sembol}_Gunluk_5000bar.csv"
    if not fn.exists():
        return None, -1
    try:
        df = pd.read_csv(fn, sep=";", decimal=",", encoding="cp1254", parse_dates=False)
        df.columns = [c.strip() for c in df.columns]
        df = df.tail(400).reset_index(drop=True)
        if len(df) < 130: return None, -1

        def parse_date(s):
            try:
                d, m, y = str(s).split(".")
                return (int(y), int(m), int(d))
            except: return (0,0,0)

        cutoff = (2026, 4, 9)
        bi = -1
        for i, row in df.iterrows():
            if parse_date(row["Tarih"]) <= cutoff:
                bi = i

        if bi < 130: return None, -1
        return df, bi
    except:
        return None, -1

# ══════════════════════════════════════════════════════════════════════
# 4. KRITER FONKSİYONLARI
# ══════════════════════════════════════════════════════════════════════
def kriterler(df, bi):
    """
    Tüm kriterleri hesapla. Dict döner.
    """
    C   = df["Kapanis"].values.astype(float)
    H   = df["Yuksek"].values.astype(float)
    L   = df["Dusuk"].values.astype(float)
    Vol = df["Hacim"].values.astype(float)

    if C[bi] <= 0 or C[bi-1] <= 0 or Vol[bi] <= 0:
        return None

    # ── İndikatörler ──────────────────────────────────────────────
    E9   = ema(C, 9)
    E21  = ema(C, 21)
    E50  = ema(C, 50)
    E200 = ema(C, 200)
    MA20 = sma(C, 20)
    MA50 = sma(C, 50)
    V20  = sma(Vol, 20)
    V5   = sma(Vol, 5)
    V10  = sma(Vol, 10)

    rsi  = rsi14(C, bi)
    rsi_prev = rsi14(C, bi-1)
    pdi, mdi, adx = adx14(H, L, C, bi)
    atr_pct = atr14_pct(H, L, C, bi)
    bb_mid, bb_width, c_above_bb = bb_metrics(C, bi)

    # Günlük değişim
    daily_chg = (C[bi] - C[bi-1]) / C[bi-1] * 100 if C[bi-1] > 0 else 0

    # Kapanış pozisyonu (gün range'i içinde)
    day_range = H[bi] - L[bi]
    close_pos = (C[bi] - L[bi]) / day_range if day_range > 0.001 else 0.5

    # EMA'dan uzaklık
    dist_ema20 = (C[bi] - E21[bi]) / E21[bi] if E21[bi] > 0 else 0

    # ── A. Tek Kriter Bazlı ───────────────────────────────────────

    # A1. EMA Stack Tam (4/4): C>E9>E21>E50>E200
    ema_tam = (C[bi] > E9[bi] and E9[bi] > E21[bi] and E21[bi] > E50[bi] and E50[bi] > E200[bi])

    # A2. EMA Stack Kısmi (3/4): en az C>E9>E21>E50
    ema_kismi = (C[bi] > E9[bi] and E9[bi] > E21[bi] and E21[bi] > E50[bi])

    # A3-A5. UV Oranı
    lb20 = min(20, bi-1)
    up_v = sum(1 for k in range(bi-lb20+1, bi+1)
               if C[k] > C[k-1] and V20[k] > 0 and Vol[k] > V20[k])
    uv = up_v / lb20

    # A6. Pocket Pivot (medyan)
    lb10 = min(10, bi-1)
    down_vols = [Vol[k] for k in range(bi-lb10, bi) if C[k] < C[k-1]]
    med_dv = float(np.median(down_vols)) if down_vols else 0.0
    bugun_yukari = C[bi] > C[bi-1]
    pp_medyan = bugun_yukari and med_dv > 0 and Vol[bi] > med_dv

    # Pocket Pivot (max — eski yöntem)
    max_dv = float(max(down_vols)) if down_vols else 0.0
    pp_max = bugun_yukari and max_dv > 0 and Vol[bi] > max_dv

    # A7. VCP Skor hesabı
    vcp_lb = min(60, bi); vcp_st = bi - vcp_lb
    ph, pl = [], []
    for k in range(vcp_st+2, bi-1):
        hmax = max(H[max(0,k-2):k+3])
        lmin = min(L[max(0,k-2):k+3])
        if H[k] == hmax: ph.append(H[k])
        if L[k] == lmin: pl.append(L[k])
    widths = []
    mp = min(len(ph), len(pl))
    for k in range(min(mp-1, 5)):
        hv = ph[-(k+1)]; lv = pl[-(k+1)]
        if hv > 0: widths.append((hv - lv) / hv)
    vcp_s = 0.0
    if len(widths) >= 2:
        vcp_s += 6.0 if len(widths) >= 3 else 3.0
        narrow = sum(1 for k in range(1, len(widths)) if widths[k-1] < widths[k]*0.90)
        vcp_s += 6.0 if narrow >= 2 else (3.0 if narrow >= 1 else 0.0)
        cut = vcp_lb // 3
        ev = np.mean(Vol[vcp_st:vcp_st+cut]) if cut > 0 else 0
        rv = np.mean(Vol[bi-cut+1:bi+1]) if cut > 0 else 0
        if ev > 0 and rv < ev * 0.75: vcp_s += 4.0
        v5m = np.mean(Vol[bi-4:bi+1]); v20m = np.mean(Vol[bi-19:bi+1])
        if v20m > 0 and v5m < v20m * 0.60: vcp_s += 4.0
    r_today = H[bi] - L[bi]
    nr7 = all((H[bi-k]-L[bi-k]) > r_today for k in range(1, 7)) if bi >= 7 else False
    if nr7: vcp_s = min(20.0, vcp_s + 4.0)
    vcp_s = min(20.0, vcp_s)

    # A8. NR7 tek başına
    # A9. RSI 45-72 + artıyor

    # ── B. PreMove Skorları ────────────────────────────────────────
    def premove_score(uv_min, use_med_pp):
        # EMA skoru
        ema_sc = 0
        if C[bi]   > E9[bi]:   ema_sc += 4
        if E9[bi]  > E21[bi]:  ema_sc += 4
        if E21[bi] > E50[bi]:  ema_sc += 4
        if E50[bi] > E200[bi]: ema_sc += 4
        if bi >= 5 and E50[bi] > E50[bi-5]: ema_sc += 4
        # UV
        uv_sc = 0
        if uv >= 0.50: uv_sc = 35
        elif uv >= uv_min: uv_sc = (uv - uv_min)/(0.50 - uv_min)*30 + 5
        # PP
        dv = med_dv if use_med_pp else max_dv
        vol_ort = V20[bi] > 0 and Vol[bi] > V20[bi]
        vol_byk = dv > 0 and Vol[bi] > dv
        pp_sc = 0
        if bugun_yukari and vol_byk and vol_ort: pp_sc = 15
        elif bugun_yukari and vol_byk:           pp_sc = 8
        # VCP + Momentum + Bonus (sabit)
        mom_sc = 0
        if 45 < rsi < 72: mom_sc += 4
        HH40 = max(H[max(0,bi-39):bi+1]); LL40 = min(L[max(0,bi-39):bi+1])
        br = HH40 - LL40
        bp = (C[bi]-LL40)/br if br > 0.001 else 0.5
        bon_sc = 2.0 if bp >= 0.55 else 0.0
        total = min(100.0, ema_sc + uv_sc + pp_sc + vcp_s + mom_sc + bon_sc)
        return total

    pm_mevcut = premove_score(0.25, False)
    pm_v2     = premove_score(0.20, True)

    # ── B3. SNIPER Günlük Filtresi ────────────────────────────────
    # AND mantığı: 5 koşulun hepsi
    sniper_ema50    = C[bi] > MA50[bi] if not np.isnan(MA50[bi]) else False
    sniper_kapanis  = close_pos >= 0.60
    sniper_hacim    = V20[bi] > 0 and Vol[bi] > V20[bi] * 1.10 and not np.isnan(V20[bi])
    sniper_gap      = abs(daily_chg) < 4.0  # gap < 2.5% ayrıca (günlük bar'da tek koşul)
    sniper_ok       = sniper_ema50 and sniper_kapanis and sniper_hacim and sniper_gap

    # ── B4. KING Global Filtresi ──────────────────────────────────
    # AND: C>EMA50 + vol>ma20*1.5 + kapş üst%60 + ATR<%3 + dist_EMA20<%5
    king_ema50  = C[bi] > E50[bi]
    king_vol    = not np.isnan(V20[bi]) and V20[bi] > 0 and Vol[bi] > V20[bi] * 1.5
    king_kap    = close_pos >= 0.60
    king_atr    = atr_pct < 0.03
    king_dist   = abs(dist_ema20) < 0.05
    king_ok     = king_ema50 and king_vol and king_kap and king_atr and king_dist

    # ── B5. BOMBA Odağı ───────────────────────────────────────────
    # BB squeeze<0.15 + C >= BB_mid + Vol>MA20*1.5 + RSI>55
    bomba_squeeze = not np.isnan(bb_width) and bb_width < 0.15 and (bb_mid is not None and C[bi] >= bb_mid)
    bomba_vol     = not np.isnan(V20[bi]) and V20[bi] > 0 and Vol[bi] > V20[bi] * 1.5
    bomba_rsi     = rsi > 55
    bomba_ok      = bomba_squeeze and bomba_vol and bomba_rsi

    # BOMBA Alternatif (daha geniş): BB_width < 0.20 + C >= BB_mid + Vol >= MA20
    bomba_genis   = not np.isnan(bb_width) and bb_width < 0.20 and (bb_mid is not None and C[bi] >= bb_mid) and \
                    not np.isnan(V20[bi]) and V20[bi] > 0 and Vol[bi] >= V20[bi]

    # ── B6. SNIPER Sıkışma (günlük HH18-LL18) ────────────────────
    HH18 = max(H[max(0,bi-17):bi+1]); LL18 = min(L[max(0,bi-17):bi+1])
    sikisma_range = (HH18 - LL18) / LL18 if LL18 > 0 else 1.0
    sikisma_ok    = sikisma_range < 0.15 and C[bi] >= (HH18 + LL18) / 2

    # ── B7. En Az 2 Kriter ───────────────────────────────────────
    iki_kriter = (sum([uv >= 0.20, pp_medyan, vcp_s >= 12]) >= 2)

    # ── B8. ANKA Günlük Proxy ────────────────────────────────────
    anka_rsi  = rsi > 50
    anka_adx  = adx > 20
    anka_pdi  = pdi > mdi
    anka_c_sma= C[bi] > MA20[bi] if not np.isnan(MA20[bi]) else False
    anka_vol  = not np.isnan(V20[bi]) and V20[bi] > 0 and Vol[bi] > V20[bi]
    anka_ok   = anka_rsi and anka_adx and anka_pdi and anka_c_sma and anka_vol

    # ── B9. K+T Hibrid ────────────────────────────────────────────
    # EMA stack ≥3/4 + UV≥0.20 + hacim kalitesi
    kt_ema   = ema_kismi   # C>E9>E21>E50
    kt_uv    = uv >= 0.20
    kt_vol   = not np.isnan(V20[bi]) and V20[bi] > 0 and Vol[bi] > V20[bi] * 1.20 and close_pos >= 0.55
    kt_ok    = kt_ema and kt_uv and kt_vol

    return {
        # Tek kriterler
        "A1_ema_tam":    ema_tam,
        "A2_ema_kismi":  ema_kismi,
        "A3_uv020":      uv >= 0.20,
        "A4_uv025":      uv >= 0.25,
        "A5_uv040":      uv >= 0.40,
        "A6_pp_medyan":  pp_medyan,
        "A7_vcp12":      vcp_s >= 12,
        "A8_nr7":        nr7,
        "A9_rsi_band":   (45 < rsi < 72) and (rsi > rsi_prev),

        # Robot yaklaşımları
        "B1_pm_mevcut":  pm_mevcut >= 45,
        "B2_pm_v2":      pm_v2 >= 45,
        "B3_sniper":     sniper_ok,
        "B4_king":       king_ok,
        "B5_bomba":      bomba_ok,
        "B5b_bomba_genis": bomba_genis,
        "B6_sikisma":    sikisma_ok,
        "B7_iki_kriter": iki_kriter,
        "B8_anka":       anka_ok,
        "B9_kt_hibrid":  kt_ok,

        # Raw değerler (analiz için)
        "_uv": uv, "_rsi": rsi, "_adx": adx, "_vcp_s": vcp_s,
        "_pm_mevcut_puan": pm_mevcut, "_pm_v2_puan": pm_v2,
        "_close_pos": close_pos, "_bb_width": bb_width,
        "_daily_chg": daily_chg,
    }

# ══════════════════════════════════════════════════════════════════════
# 5. HESAPLAMA — EVREN: yükselenler + düşenler (precision/recall için)
# ══════════════════════════════════════════════════════════════════════
KRITER_ISIMLER = [
    "A1_ema_tam", "A2_ema_kismi", "A3_uv020", "A4_uv025", "A5_uv040",
    "A6_pp_medyan", "A7_vcp12", "A8_nr7", "A9_rsi_band",
    "B1_pm_mevcut", "B2_pm_v2", "B3_sniper", "B4_king",
    "B5_bomba", "B5b_bomba_genis", "B6_sikisma", "B7_iki_kriter",
    "B8_anka", "B9_kt_hibrid"
]

# Evren: tüm hisseler için istatistik tutacağız
# sonuc[kriter] = {true_pos5, false_neg5, false_pos_dusen, ...}
istatistik = {k: {"tp5": 0, "fn5": 0, "tp3": 0, "fn3": 0, "fp_dusen": 0, "tn_dusen": 0} for k in KRITER_ISIMLER}

# ≥5% yükselenler için detaylı kayıt
detay5 = {}   # sembol → kriter_dict
bos_bar = []  # bar verisi olmayan semboller

# Önce ≥5% yükselenler
for sembol, pnl in yukselenler.items():
    df, bi = load_bar(sembol)
    if df is None:
        bos_bar.append(sembol)
        continue
    k = kriterler(df, bi)
    if k is None: continue
    if pnl >= 5.0:
        detay5[sembol] = {"pnl": pnl, **k}
    for kriter in KRITER_ISIMLER:
        if k[kriter]:
            if pnl >= 5.0: istatistik[kriter]["tp5"] += 1
            if pnl >= 3.0: istatistik[kriter]["tp3"] += 1
        else:
            if pnl >= 5.0: istatistik[kriter]["fn5"] += 1
            if pnl >= 3.0: istatistik[kriter]["fn3"] += 1

# Düşenler (false positive analizi)
for sembol, pnl in dusenler.items():
    df, bi = load_bar(sembol)
    if df is None: continue
    k = kriterler(df, bi)
    if k is None: continue
    for kriter in KRITER_ISIMLER:
        if k[kriter]:
            istatistik[kriter]["fp_dusen"] += 1
        else:
            istatistik[kriter]["tn_dusen"] += 1

# ══════════════════════════════════════════════════════════════════════
# 6. ÇIKTI — ÖZET TABLO
# ══════════════════════════════════════════════════════════════════════
total5 = len([s for s, p in yukselenler.items() if p >= 5.0 and s not in bos_bar])
total3 = len([s for s, p in yukselenler.items() if p >= 3.0 and s not in bos_bar])
total_dusen = len([s for s in dusenler if s not in bos_bar])

print(f"\nEvren: {total5} hisse ≥5%  |  {total3} hisse ≥3%  |  {total_dusen} düşen  |  Bar yok: {len(bos_bar)}")
print()
print("╔══════════════════════════════════════════════════════════════════════════════════════════════╗")
print("║  KRİTER KARŞILAŞTIRMASI — 09.04.2026 kapanış → 10.04.2026 sonuç                           ║")
print("╠══════════════╦═══════════════════╦════════════════════╦════════════════════╦════════════════╣")
print("║  Kriter      ║  ≥5% Yakala       ║  ≥3% Yakala        ║  FP (düşen)        ║  F1 (≥5%)      ║")
print("║              ║  #  / top  %      ║  #  / top  %       ║  #  / top  %       ║                ║")
print("╠══════════════╬═══════════════════╬════════════════════╬════════════════════╬════════════════╣")

grup_a_sep = False
for kriter in KRITER_ISIMLER:
    st = istatistik[kriter]
    tp5 = st["tp5"]; fn5 = st["fn5"]
    tp3 = st["tp3"]; fn3 = st["fn3"]
    fp  = st["fp_dusen"]

    # Signal sayısı (TP + FP)
    predicted5 = tp5 + fp
    recall5  = tp5 / total5  if total5  > 0 else 0
    precision5 = tp5 / predicted5 if predicted5 > 0 else 0
    f1_5 = 2 * precision5 * recall5 / (precision5 + recall5) if (precision5 + recall5) > 0 else 0

    recall3  = tp3 / total3  if total3  > 0 else 0
    fp_pct   = fp / total_dusen * 100 if total_dusen > 0 else 0

    if kriter.startswith("B") and not grup_a_sep:
        print("╠══════════════╬═══════════════════╬════════════════════╬════════════════════╬════════════════╣")
        grup_a_sep = True

    tag = "★" if f1_5 >= 0.25 else (" " if f1_5 < 0.10 else "·")
    print(f"║ {kriter:<12} ║ {tp5:>3}/{total5:>3} = {recall5*100:4.1f}% ║ "
          f"{tp3:>3}/{total3:>3} = {recall3*100:4.1f}%  ║ "
          f"{fp:>3}/{total_dusen:>3} = {fp_pct:4.1f}%  ║ "
          f"  F1={f1_5:.3f} {tag}     ║")

print("╚══════════════╩═══════════════════╩════════════════════╩════════════════════╩════════════════╝")

# ══════════════════════════════════════════════════════════════════════
# 7. ≥5% KAÇIRILAN / YAKALANAN ANALİZİ (PreMove v2 vs en iyi kriter)
# ══════════════════════════════════════════════════════════════════════
print()
print("═" * 100)
print("KAÇIRILAN ≥5% HİSSELER — Neden Yakalanmıyor? (tüm kriterler FALSE olan hisseler)")
print("═" * 100)
print(f"{'SEMBOL':8} {'%':>6}  {'UV':>5}  {'RSI':>5}  {'ADX':>5}  {'VCPs':>5}  {'CapPos':>6}  AKTIF KRİTERLER")
print("─" * 100)

miss_all = []
for sembol, d in sorted(detay5.items(), key=lambda x: -x[1]["pnl"]):
    aktif = [k for k in KRITER_ISIMLER if d.get(k, False)]
    if len(aktif) == 0:
        miss_all.append((sembol, d["pnl"]))
    # Sadece B2 (pm_v2) gözden kaçıranları listele
    if not d.get("B2_pm_v2", False):
        aktif_str = ",".join(aktif) if aktif else "—NONE—"
        print(f"{sembol:8} {d['pnl']:>6.2f}%  "
              f"UV:{d['_uv']:.2f}  RSI:{d['_rsi']:4.0f}  ADX:{d['_adx']:4.0f}  "
              f"VCP:{d['_vcp_s']:4.0f}  CapPos:{d['_close_pos']:.2f}  [{aktif_str}]")

print()
print(f"Hiçbir kriterle yakalanmayanlar ({len(miss_all)} adet):")
for s, p in miss_all:
    print(f"  {s}: +{p:.2f}%")

# ══════════════════════════════════════════════════════════════════════
# 8. KRİTER KOMBİNASYON ANALİZİ
#    PreMove'a ek hangi kriter en çok "yeni hit" ekler?
# ══════════════════════════════════════════════════════════════════════
print()
print("═" * 80)
print("KOMBİNASYON ANALİZİ — PreMove v2 KAÇIRDIKLARINA başka kriter ne ekler?")
print("═" * 80)

pm_v2_missed = {s for s, d in detay5.items() if not d.get("B2_pm_v2", False)}
print(f"PreMove v2 kaçırdığı ≥5% hisse: {len(pm_v2_missed)}")
print()

extra_cizelgesi = []
for kriter in KRITER_ISIMLER:
    if kriter in ("B1_pm_mevcut", "B2_pm_v2"):
        continue
    extra = sum(1 for s in pm_v2_missed if detay5.get(s, {}).get(kriter, False))
    # Bu kriter TRUE iken ne kadar False Positive üretir (düşenlerden)?
    fp_extra = istatistik[kriter]["fp_dusen"]
    extra_cizelgesi.append((kriter, extra, fp_extra))

extra_cizelgesi.sort(key=lambda x: -x[1])
print(f"{'Kriter':<20}  {'Yeni Hit (≥5%)':>14}  {'FP (düşen)':>12}  {'Net Fayda':>10}")
print("─" * 65)
for kriter, extra, fp_e in extra_cizelgesi:
    net = extra - fp_e * 0.3  # FP'ye 0.3 ağırlık ceza
    print(f"  {kriter:<18}  {extra:>14}  {fp_e:>12}  {net:>10.1f}")

# ══════════════════════════════════════════════════════════════════════
# 9. TEMEL FONKSİYON BULGUSU
#    Her büyük hareket neden kaçırıldı? (DGNMO, KLMSN vb)
# ══════════════════════════════════════════════════════════════════════
print()
print("═" * 80)
print("BÜYÜK HAREKETLER — NEDEN KAÇIRILDI? (≥7% yükselenler)")
print("═" * 80)

for sembol, d in sorted(detay5.items(), key=lambda x: -x[1]["pnl"]):
    if d["pnl"] < 7.0: continue
    aktif = [k for k in KRITER_ISIMLER if d.get(k, False)]
    pm_puan = d.get("_pm_v2_puan", 0)
    print(f"\n{sembol}  +{d['pnl']:.2f}%  [PM_v2={pm_puan:.0f}p]")
    print(f"  UV={d['_uv']:.2f}  RSI={d['_rsi']:.0f}  ADX={d['_adx']:.0f}  "
          f"VCP={d['_vcp_s']:.0f}  CapPos={d['_close_pos']:.2f}  BB_W={d.get('_bb_width', 0):.3f}")
    print(f"  PM_Mevcut={'✓' if d.get('B1_pm_mevcut') else '✗'}  "
          f"PM_v2={'✓' if d.get('B2_pm_v2') else '✗'}  "
          f"SNIPER={'✓' if d.get('B3_sniper') else '✗'}  "
          f"KING={'✓' if d.get('B4_king') else '✗'}  "
          f"BOMBA={'✓' if d.get('B5_bomba') else '✗'}  "
          f"SIKISMA={'✓' if d.get('B6_sikisma') else '✗'}  "
          f"UV020={'✓' if d.get('A3_uv020') else '✗'}  "
          f"EMA_tam={'✓' if d.get('A1_ema_tam') else '✗'}")
    if aktif:
        print(f"  AKTIF: {', '.join(aktif)}")
    else:
        print(f"  *** HİÇBİR KRİTER YAKALAMADI ***")

print()
print("Script tamamlandı.")
