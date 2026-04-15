"""
premove_gelistirme.py — 10.04.2026 Yükselen Listesi vs PreMove Kriter Analizi

Amaç:
  10.04.2026'da ≥5% yükselen her hisse için 09.04 kapanış verisine göre
  (son seans günü) mevcut ve önerilen parametreler karşılaştırılır.
  Hangi değişiklik kaç extra hisseyi yakalar?

Çıktı:
  1. Mevcut parametrelerle kaçırılan ≥5% hisseler (false negatives)
  2. Parametre değişikliği ile yakalama oranı karşılaştırması
  3. False positive analizi (düşen ama yüksek puan alan)

Çalıştır:
  d:\Projects\.venv\Scripts\python.exe premove_gelistirme.py
"""

import os, sys, csv
import numpy as np
import pandas as pd
from pathlib import Path

BAR_DIR  = Path("D:/Projects/IdealQuant/reference/ideal_docs/BarData_Export")
CSV_FILE = Path("D:/Projects/IdealQuant/scanner/10.04.2026 Yükselen Düşen tablosu.csv")

# ── 1. Yükselen listesini oku ──────────────────────────────────────
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

hit_list_5 = [s for s, p in yukselenler.items() if p >= 5.0]
hit_list_3 = [s for s, p in yukselenler.items() if p >= 3.0]
print(f"10.04 Yükselenler: {len(yukselenler)} sembol   |   ≥5%: {len(hit_list_5)}   |   ≥3%: {len(hit_list_3)}")
print(f"10.04 Düşenler  : {len(dusenler)} sembol")
print()

# ── 2. Yardımcı: EMA hesabı ────────────────────────────────────────
def ema(arr, n):
    result = np.zeros(len(arr))
    if len(arr) == 0: return result
    k = 2.0 / (n + 1)
    result[0] = arr[0]
    for i in range(1, len(arr)):
        result[i] = arr[i] * k + result[i-1] * (1 - k)
    return result

def sma(arr, n):
    result = np.full(len(arr), np.nan)
    for i in range(n-1, len(arr)):
        result[i] = np.mean(arr[i-n+1:i+1])
    return result

# ── 3. Bar verisi yükle ────────────────────────────────────────────
def load_bar(sembol):
    """Son 300 günlük barı yükle, 09.04.2026 veya öncesindeki son bar bi."""
    fn = BAR_DIR / f"{sembol}_Gunluk_5000bar.csv"
    if not fn.exists():
        return None, -1
    try:
        df = pd.read_csv(fn, sep=";", decimal=",",
                         encoding="cp1254", parse_dates=False)
        df.columns = [c.strip() for c in df.columns]
        # Son 350 bar yeterli
        df = df.tail(350).reset_index(drop=True)
        if len(df) < 130:
            return None, -1

        # 09.04.2026 veya öncesindeki son bar
        # Tarih sütunu DD.MM.YYYY formatında
        def parse_date(s):
            try:
                d, m, y = s.split(".")
                return (int(y), int(m), int(d))
            except:
                return (0, 0, 0)

        cutoff = (2026, 4, 9)
        bi = -1
        for i, row in df.iterrows():
            dt = parse_date(str(row["Tarih"]))
            if dt <= cutoff:
                bi = i

        if bi < 130:   # Yetersiz geçmiş
            return None, -1

        return df, bi
    except Exception as e:
        return None, -1

# ── 4. Tek hisse için kriter hesapla ──────────────────────────────
def hesapla(df, bi, uv_min=0.25, pp_medyan=False):
    """
    Mevcut (uv_min=0.25, pp_medyan=False) veya yeni parametreler ile
    PreMove puanını hesapla. Dict döner.
    """
    C   = df["Kapanis"].values.astype(float)
    H   = df["Yuksek"].values.astype(float)
    L   = df["Dusuk"].values.astype(float)
    Vol = df["Hacim"].values.astype(float)

    if C[bi] <= 0 or C[bi-1] <= 0 or Vol[bi] <= 0:
        return None

    # EMA'lar
    E9   = ema(C, 9)
    E21  = ema(C, 21)
    E50  = ema(C, 50)
    E200 = ema(C, 200)
    V20  = sma(Vol, 20)

    # ── EMA Skoru (0-20p) ─────────────────────────────────────────
    ema_s = 0.0
    if C[bi]   > E9[bi]:   ema_s += 4
    if E9[bi]  > E21[bi]:  ema_s += 4
    if E21[bi] > E50[bi]:  ema_s += 4
    if E50[bi] > E200[bi]: ema_s += 4
    if bi >= 5 and E50[bi] > E50[bi-5]: ema_s += 4

    # ── Up Vol Oranı (0-35p) ──────────────────────────────────────
    lb20 = min(20, bi - 1)
    up_v = 0
    for k in range(bi - lb20 + 1, bi + 1):
        if C[k] > C[k-1] and V20[k] > 0 and Vol[k] > V20[k]:
            up_v += 1
    uv_ratio = up_v / lb20

    uv_s = 0.0
    if uv_ratio >= 0.50:
        uv_s = 35.0
    elif uv_ratio >= uv_min:
        uv_s = (uv_ratio - uv_min) / (0.50 - uv_min) * 30.0 + 5.0

    # ── Pocket Pivot (0-15p) ──────────────────────────────────────
    lb10 = min(10, bi - 1)
    down_vols = []
    for k in range(bi - lb10, bi):
        if C[k] < C[k-1]:
            down_vols.append(Vol[k])

    if pp_medyan:
        maxDV = float(np.median(down_vols)) if down_vols else 0.0
    else:
        maxDV = float(max(down_vols)) if down_vols else 0.0

    bugun_yukari = C[bi] > C[bi-1]
    vol_buyuk    = maxDV > 0 and Vol[bi] > maxDV
    vol_ort_ust  = V20[bi] > 0 and Vol[bi] > V20[bi]

    pp_s = 0.0
    if bugun_yukari and vol_buyuk and vol_ort_ust: pp_s = 15.0
    elif bugun_yukari and vol_buyuk:               pp_s = 8.0

    # ── VCP Skoru (0-20p) ─────────────────────────────────────────
    vcp_lb  = min(60, bi)
    vcp_st  = bi - vcp_lb
    ph, pl  = [], []
    for k in range(vcp_st + 2, bi - 1):
        hmax = max(H[k-2:k+3])
        lmin = min(L[k-2:k+3])
        if H[k] == hmax: ph.append(H[k])
        if L[k] == lmin: pl.append(L[k])

    widths = []
    mp = min(len(ph), len(pl))
    for k in range(min(mp - 1, 5)):
        hv = ph[-(k+1)]; lv = pl[-(k+1)]
        if hv > 0: widths.append((hv - lv) / hv)

    vcp_s = 0.0
    if len(widths) >= 2:
        vcp_s += 6.0 if len(widths) >= 3 else 3.0
        narrow = sum(1 for k in range(1, len(widths)) if widths[k-1] < widths[k] * 0.90)
        vcp_s += 6.0 if narrow >= 2 else (3.0 if narrow >= 1 else 0.0)
        cut = vcp_lb // 3
        ev = np.mean(Vol[vcp_st:vcp_st+cut]) if cut > 0 else 0
        rv = np.mean(Vol[bi-cut+1:bi+1]) if cut > 0 else 0
        if ev > 0 and rv < ev * 0.75: vcp_s += 4.0
        v5  = np.mean(Vol[bi-4:bi+1])
        v20 = np.mean(Vol[bi-19:bi+1])
        if v20 > 0 and v5 < v20 * 0.60: vcp_s += 4.0

    # NR7
    r_today = H[bi] - L[bi]
    nr7 = all((H[bi-k] - L[bi-k]) > r_today for k in range(1, 7))
    if nr7: vcp_s = min(20.0, vcp_s + 4.0)
    vcp_s = min(20.0, vcp_s)

    # ── Momentum (0-8p) ───────────────────────────────────────────
    # RSI basit
    gains, losses = [], []
    for k in range(bi-13, bi+1):
        d = C[k] - C[k-1]
        gains.append(max(d, 0)); losses.append(max(-d, 0))
    ag = np.mean(gains); al = np.mean(losses)
    rsi = 100 - 100/(1 + ag/al) if al > 0 else 100

    mom_s = 0.0
    if 45 < rsi < 72: mom_s += 4

    # ── Bonus (0-2p) ──────────────────────────────────────────────
    HH40 = max(H[max(0,bi-39):bi+1])
    LL40 = min(L[max(0,bi-39):bi+1])
    br   = HH40 - LL40
    bp   = (C[bi] - LL40) / br if br > 0.001 else 0.5
    bon_s = 2.0 if bp >= 0.55 else 0.0

    total = min(100.0, ema_s + uv_s + pp_s + vcp_s + mom_s + bon_s)

    return {
        "ema": ema_s, "uv": uv_s, "pp": pp_s, "vcp": vcp_s,
        "mom": mom_s, "bon": bon_s, "total": total,
        "uv_ratio": uv_ratio, "rsi": rsi
    }

# ── 5. Tüm ≥5% yükselen hisseler için hesapla ────────────────────
print("=" * 90)
print(f"{'SEMBOL':8} {'+%':>6}  {'MEVCUT':>7}  {'E':>3} {'U':>3} {'P':>3} {'V':>3} {'M':>3} │ "
      f"{'UV0.20':>7}  {'PP_MED':>7}  {'KOMBİNE':>8}  YORUM")
print("=" * 90)

ESIK_YUKSEK = 65
ESIK_TAKIP  = 45

stats = {
    "mevcut":   {"caught5": 0, "caught3": 0, "missed5": [], "missed3": []},
    "uv020":    {"caught5": 0, "caught3": 0, "missed5": [], "missed3": []},
    "pp_med":   {"caught5": 0, "caught3": 0, "missed5": [], "missed3": []},
    "kombine":  {"caught5": 0, "caught3": 0, "missed5": [], "missed3": []},
}

all_scores = []  # (sembol, pnl, mevcut_total, uv020_total, ppmed_total, kombi_total)

for sembol, pnl in sorted(yukselenler.items(), key=lambda x: -x[1]):
    if pnl < 3.0:
        break  # ≥3% altını atla

    df, bi = load_bar(sembol)
    if df is None:
        continue

    sc_mev  = hesapla(df, bi, uv_min=0.25, pp_medyan=False)
    sc_uv   = hesapla(df, bi, uv_min=0.20, pp_medyan=False)
    sc_pp   = hesapla(df, bi, uv_min=0.25, pp_medyan=True)
    sc_kombi = hesapla(df, bi, uv_min=0.20, pp_medyan=True)

    if sc_mev is None:
        continue

    tm = sc_mev["total"]; tu = sc_uv["total"]
    tp = sc_pp["total"];  tk = sc_kombi["total"]

    # Yakalama istatistikleri (≥TAKIP eşiği = 45)
    for key, sc in [("mevcut", tm), ("uv020", tu), ("pp_med", tp), ("kombine", tk)]:
        if sc >= ESIK_TAKIP:
            if pnl >= 5.0: stats[key]["caught5"] += 1
            if pnl >= 3.0: stats[key]["caught3"] += 1
        else:
            if pnl >= 5.0: stats[key]["missed5"].append(sembol)
            if pnl >= 3.0: stats[key]["missed3"].append(sembol)

    all_scores.append((sembol, pnl, tm, tu, tp, tk,
                       sc_mev["uv_ratio"], sc_mev["ema"], sc_mev["uv"],
                       sc_mev["pp"], sc_mev["vcp"]))

    # Göster (sadece ≥5% olanlar için detaylar)
    if pnl >= 5.0:
        flag_m = "✓" if tm >= ESIK_TAKIP else "✗"
        flag_k = "✓" if tk >= ESIK_TAKIP else "✗"
        change = ""
        if tm < ESIK_TAKIP and tk >= ESIK_TAKIP:
            change = "← YENİ YAKALANDI"
        elif tm >= ESIK_YUKSEK:
            change = "GÜÇLÜ"
        elif tm >= ESIK_TAKIP:
            change = "takipte"

        print(f"{sembol:8} {pnl:+6.2f}%  {flag_m}{tm:5.0f}p  "
              f"{int(sc_mev['ema']):3} {int(sc_mev['uv']):3} {int(sc_mev['pp']):3} {int(sc_mev['vcp']):3} {int(sc_mev['mom']):3} │ "
              f"{flag_k if tu>=ESIK_TAKIP else '✗'}{tu:5.0f}p  "
              f"{tp:6.0f}p  "
              f"{tk:7.0f}p  {change}")

print()

# ── 6. İstatistik özeti ───────────────────────────────────────────
print("=" * 70)
print(f"{'PARAMETRE':20} {'≥5% YAKALANAN':>15} {'≥3% YAKALANAN':>15}")
print("=" * 70)
n5 = len(hit_list_5)
n3 = len(hit_list_3)

for key, label in [
    ("mevcut",  "Mevcut (UV≥0.25, maxDown)"),
    ("uv020",   "UV eşiği → 0.20          "),
    ("pp_med",  "PP medyan bazlı           "),
    ("kombine", "UV0.20 + PP medyan        "),
]:
    c5 = stats[key]["caught5"]
    c3 = stats[key]["caught3"]
    ps5 = f"{c5}/{n5}" if n5 else "0/0"
    ps3 = f"{c3}/{n3}" if n3 else "0/0"
    r5  = c5/n5*100 if n5 else 0
    r3  = c3/n3*100 if n3 else 0
    print(f"{label:30}  {ps5:>6} = {r5:4.1f}%   {ps3:>6} = {r3:4.1f}%")

print()

# ── 7. "Yeni yakalanan" listesi ───────────────────────────────────
yeni_yakalanan = []
for sym, pnl, tm, tu, tp, tk, uvr, es, us, ps, vs in all_scores:
    if pnl >= 5.0 and tm < ESIK_TAKIP and tk >= ESIK_TAKIP:
        yeni_yakalanan.append((sym, pnl, tm, tk, uvr, es, us, ps, vs))

if yeni_yakalanan:
    print("YENİ YAKALANAN (≥5% ama mevcut parametrelerle kaçırılan):")
    print(f"  {'SEMBOL':8} {'+%':>6}  {'ESK':>4} → {'YNI':>4}  UV_ratio  EMA  UV   PP  VCP")
    for sym, pnl, tm, tk, uvr, es, us, ps, vs in yeni_yakalanan:
        print(f"  {sym:8} {pnl:+6.2f}%   {tm:3.0f} →  {tk:3.0f}  {uvr:.3f}   "
              f"{int(es):3}  {int(us):3}  {int(ps):3}  {int(vs):3}")
    print()

# ── 8. Düşen hisseler için false-positive kontrolü ───────────────
print("FALSE POSITIVE KONTROLÜ (düşenler yüksek puan alıyor mu?):")
print(f"  {'SEMBOL':8} {'Düş%':>6}  {'MEVCUT':>6}  {'KOMBİNE':>8}")
fp_mev = 0; fp_kombi = 0
for sembol, pnl in sorted(dusenler.items(), key=lambda x: x[1])[:30]:  # En çok düşen 30
    df, bi = load_bar(sembol)
    if df is None:
        continue
    sc_mev   = hesapla(df, bi, uv_min=0.25, pp_medyan=False)
    sc_kombi = hesapla(df, bi, uv_min=0.20, pp_medyan=True)
    if sc_mev is None:
        continue
    tm = sc_mev["total"]; tk = sc_kombi["total"]
    if tm >= ESIK_TAKIP:
        fp_mev += 1
        risk = " ← YANLIŞ POZİTİF (mevcut)"
    elif tk >= ESIK_TAKIP:
        fp_kombi += 1
        risk = " ← YANLIŞ POZİTİF (kombine)"
    else:
        risk = ""
    if risk or pnl <= -3.0:
        print(f"  {sembol:8} {pnl:+6.2f}%   {tm:5.0f}p   {tk:7.0f}p  {risk}")

print()
print(f"  Yanlış pozitif (mevcut) : {fp_mev}")
print(f"  Yanlış pozitif (kombine): {fp_kombi}")
print()

# ── 9. Final öneri ────────────────────────────────────────────────
print("=" * 70)
print("ÖZET VE ÖNERI")
print("=" * 70)
n5_mev  = stats["mevcut"]["caught5"]
n5_kombi = stats["kombine"]["caught5"]
gain = n5_kombi - n5_mev
print(f"Mevcut ≥5% yakalama: {n5_mev}/{n5} ({n5_mev/n5*100:.1f}%)")
print(f"Kombine ≥5% yakalama: {n5_kombi}/{n5} ({n5_kombi/n5*100:.1f}%)  [+{gain} hisse]")
print(f"False positive artışı: {fp_kombi - fp_mev} adet")
print()
print("Uygulanan değişiklikler:")
print("  1. UV eşiği: 0.25 → 0.20 (doğrusal ölçek başlangıcı)")
print("  2. PP: maxDownVol → medyan down-vol (tek outlier day etkisini azalt)")
