"""
sinyal_db_analiz.py — Sinyal_Log_Database.txt tam analizi
Aktif pozisyonlar + PnL tahmini (bar verisi bazlı)
"""
import csv, glob
from collections import defaultdict
from pathlib import Path

DB_FILE  = Path("D:/Projects/Sinyal_Log_Database.txt")
BAR_DIR  = Path("D:/Projects/IdealQuant/reference/ideal_docs/BarData_Export")

rows = []
with open(DB_FILE, encoding="cp1254") as f:
    reader = csv.reader(f, delimiter="|")
    next(reader)
    for r in reader:
        if len(r) == 11:
            rows.append(r)

def flt(s):
    try: return float(str(s).replace(",", "."))
    except: return None

def bar_kapanislar(sym):
    """Son 2 günlük kapanışı döndür: (k_onceki, k_son)"""
    bf = BAR_DIR / f"{sym}_Gunluk_5000bar.csv"
    if not bf.exists():
        return None, None
    with open(bf, encoding="utf-8-sig") as f2:
        brows = list(csv.DictReader(f2, delimiter=";"))
    if len(brows) < 2:
        return None, None
    return flt(brows[-2]["Kapanis"]), flt(brows[-1]["Kapanis"])

# ── 1. GENEL ÖZET ────────────────────────────────────────────────
kapali = [r for r in rows if r[5] == "KAPALI"]
aktif  = [r for r in rows if r[5] == "AKTIF"]

print("=" * 70)
print("  SİNYAL LOG VERİTABANI — TAM ANALİZ")
print("=" * 70)
print(f"  Toplam kayıt : {len(rows)}")
print(f"  Kapanmış     : {len(kapali)}")
print(f"  AKTİF        : {len(aktif)}")
print()

# ── 2. STRATEJİ BAZINDA KAPALI PnL ──────────────────────────────
print("  KAPALI POZİSYONLAR — Strateji Bazında Performans")
print(f"  {'-'*65}")
by_strat = defaultdict(list)
for r in kapali:
    pnl = flt(r[8])
    if pnl is not None:
        by_strat[r[1]].append(pnl)
strat_summary = []
for strat, pnls in by_strat.items():
    ort = sum(pnls)/len(pnls)
    pozitif = sum(1 for p in pnls if p > 0)
    win_r   = pozitif/len(pnls)*100
    strat_summary.append((strat, len(pnls), ort, win_r))
strat_summary.sort(key=lambda x: -x[2])
print(f"  {'STRATEJİ':<14} {'İşlem':>6} {'Ort PnL':>9} {'WinRate':>8}")
print(f"  {'-'*42}")
for s, n, ort, wr in strat_summary:
    print(f"  {s:<14} {n:>6} {ort:>+8.2f}% {wr:>7.1f}%")

# ── 3. GÜNLÜK KAPALI PnL (son 5 gün) ────────────────────────────
print()
print("  KAPALI — Gün Bazında (son günler)")
by_date = defaultdict(list)
for r in kapali:
    pnl = flt(r[8])
    if pnl is not None:
        kapanis_t = r[6][:10] if r[6] else r[3][:10]
        by_date[kapanis_t].append(pnl)
print(f"  {'TARİH':<12} {'İşlem':>6} {'Toplam PnL':>12} {'Ort PnL':>9} {'WinRate':>8}")
print(f"  {'-'*52}")
for dt in sorted(by_date.keys())[-7:]:
    pnls = by_date[dt]
    toplam = sum(pnls)
    ort    = toplam/len(pnls)
    wr     = sum(1 for p in pnls if p > 0)/len(pnls)*100
    print(f"  {dt:<12} {len(pnls):>6} {toplam:>+11.2f}% {ort:>+8.2f}% {wr:>7.1f}%")

# ── 4. AKTİF POZİSYONLAR — STRATEJİ & PERİYOT ──────────────────
print()
print("  AKTİF POZİSYONLAR — Strateji & Periyot")
by_strat_aktif = defaultdict(int)
by_per_aktif   = defaultdict(int)
for r in aktif:
    by_strat_aktif[r[1]] += 1
    by_per_aktif[r[2]]   += 1
print(f"  STRATEJİ  : " + "  ".join(f"{s}({n})" for s,n in sorted(by_strat_aktif.items(), key=lambda x:-x[1])))
print(f"  PERİYOT   : " + "  ".join(f"{p}dk({n})" for p,n in sorted(by_per_aktif.items())))

# ── 5. PREMOVE AKTİF — DETAY + BAR VERİSİ ───────────────────────
premove_aktif = [r for r in aktif if r[1] == "PREMOVE"]
print()
print(f"  PREMOVE AKTİF ({len(premove_aktif)} adet) — 10.04'te açıldılar, 11.04 için bar tahmini")
print(f"  {'-'*75}")
print(f"  {'SEMBOL':<12} {'GİRİŞ':>8} {'PENCERE':>8} {'09.04K':>8} {'10.04K':>8} {'10.04%':>8} {'PnL@10.04K':>11}")
print(f"  {'-'*75}")

premove_hits = 0
premove_total = 0
for r in sorted(premove_aktif, key=lambda x: x[3]):
    raw_sym = r[0]
    sym = raw_sym.replace("VIP'VIP-", "VIP-").replace("IMKBH'", "").strip()
    giris = flt(r[4])
    pencere = r[3][11:16] if len(r[3]) > 16 else ""
    db_pnl  = flt(r[8])

    # Bar verisinde VIP- için ayrı dosya olabilir
    k09, k10 = bar_kapanislar(sym)

    if giris and k10:
        pnl_est = (k10 - giris) / giris * 100
        chg = (k10 - k09) / k09 * 100 if k09 else 0
        flag = "HIT5 🏆" if pnl_est >= 5 else ("HIT2" if pnl_est >= 2 else ("MISS ⬇" if pnl_est < -1 else "flat"))
        premove_total += 1
        if pnl_est >= 5: premove_hits += 1
        print(f"  {sym:<12} {giris:>8.2f} {pencere:>8} {k09 or 0:>8.2f} {k10:>8.2f} {chg:>+7.1f}% {pnl_est:>+9.1f}%  {flag}")
    else:
        print(f"  {sym:<12} {giris or 0:>8.2f} {pencere:>8}   bar verisi yok (VIP sembol?)")

if premove_total:
    print(f"\n  PREMOVE ÖZET: HIT≥5%: {premove_hits}/{premove_total} = {premove_hits/premove_total:.0%}")

# ── 6. DİĞER AKTİF STRATEJİLER — PnL DURUMU ────────────────────
diger_strat = ["SNIPER", "ANKA", "DIP_V2", "K+B+T", "K+B", "B+T", "B", "K+T", "T", "K"]
for strat in diger_strat:
    grp = [r for r in aktif if r[1] == strat]
    if not grp:
        continue
    print()
    print(f"  {strat} AKTİF ({len(grp)} adet)")
    print(f"  {'SEMBOL':<12} {'GİRİŞ':>8} {'PER':>5} {'DB PnL':>8} {'10.04K':>8} {'Est PnL':>9}")
    print(f"  {'-'*58}")
    toplam_est = []
    for r in sorted(grp, key=lambda x: flt(x[8]) or 0, reverse=True)[:20]:
        sym = r[0].replace("VIP'VIP-", "VIP-").replace("IMKBH'", "").strip()
        giris  = flt(r[4])
        db_pnl = flt(r[8])
        per    = r[2]
        k09, k10 = bar_kapanislar(sym)
        if giris and k10:
            est = (k10 - giris) / giris * 100
            toplam_est.append(est)
            flag = "HIT5 🏆" if est >= 5 else ("HIT2" if est >= 2 else ("MISS ⬇" if est < -2 else ""))
            print(f"  {sym:<12} {giris:>8.2f} {per:>5} {db_pnl or 0:>+7.2f}% {k10:>8.2f} {est:>+8.1f}%  {flag}")
        else:
            print(f"  {sym:<12} {giris or 0:>8.2f} {per:>5} {db_pnl or 0:>+7.2f}%  no_bar")
    if len(grp) > 20:
        print(f"  ... ve {len(grp)-20} daha")
    if toplam_est:
        print(f"  Ort tahmini PnL: {sum(toplam_est)/len(toplam_est):+.2f}%  ({len(toplam_est)} sembol)")
