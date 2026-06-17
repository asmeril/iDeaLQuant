import re
from collections import defaultdict

lines = open("D:/Projects/Sinyal_Log_Database.txt", encoding="utf-8").readlines()

STRATEGY_ROBOT = {
    "K+B+T": "King+Bomba+TeFo",
    "K+B":   "King+Bomba+TeFo",
    "K+T":   "King+Bomba+TeFo",
    "B+T":   "King+Bomba+TeFo",
    "K":     "King+Bomba+TeFo",
    "B":     "King+Bomba+TeFo",
    "T":     "King+Bomba+TeFo",
    "SNIPER":"SNIPER",
    "DIP_V2":"Dip_Zirve_V2",
    "ZIRVE_V2":"Dip_Zirve_V2",
    "ANKA":  "ANKA",
}

records = []
for i, line in enumerate(lines):
    if i == 0:
        continue
    line = line.strip()
    if not line:
        continue
    parts = line.split("|")
    if len(parts) < 11:
        continue
    try:
        sembol = parts[0]
        strateji = parts[1]
        periyot = parts[2]
        tarih = parts[3]
        durum = parts[5]
        pnl = float(parts[8].replace(",", "."))
        maxpnl = float(parts[10].replace(",", "."))
        sebep = parts[9]
        if durum != "KAPALI":
            continue
        records.append({
            "sembol": sembol,
            "strateji": strateji,
            "robot": STRATEGY_ROBOT.get(strateji, strateji),
            "periyot": periyot,
            "pnl": pnl,
            "maxpnl": maxpnl,
            "sebep": sebep,
            "tarih": tarih,
        })
    except:
        pass

print(f"Toplam kapali islem: {len(records)}\n")

# --- STRATEJI BAZINDA ---
strat_stats = defaultdict(list)
for r in records:
    strat_stats[r["strateji"]].append(r["pnl"])

print("=" * 80)
print("STRATEJİ BAZINDA İSTATİSTİKLER")
print("=" * 80)
print(f"{'Strateji':<12} {'N':>5} {'Kazanan':>8} {'Win%':>7} {'Ort.PnL':>9} {'ToplamPnL':>11} {'Max':>8} {'Min':>8}")
print("-" * 80)
for s, pnls in sorted(strat_stats.items(), key=lambda x: sum(x[1]), reverse=True):
    n = len(pnls)
    win = sum(1 for p in pnls if p > 0)
    win_pct = 100.0 * win / n if n else 0
    ort = sum(pnls) / n
    top = sum(pnls)
    mx = max(pnls)
    mn = min(pnls)
    print(f"{s:<12} {n:>5} {win:>8} {win_pct:>6.1f}% {ort:>9.2f} {top:>11.2f} {mx:>8.2f} {mn:>8.2f}")

print()
print("=" * 80)
print("ROBOT BAZINDA ÖZET")
print("=" * 80)
robot_stats = defaultdict(list)
for r in records:
    robot_stats[r["robot"]].append(r["pnl"])

print(f"{'Robot':<20} {'N':>5} {'Kazanan':>8} {'Win%':>7} {'Ort.PnL':>9} {'ToplamPnL':>11} {'Max':>8} {'Min':>8}")
print("-" * 80)
for s, pnls in sorted(robot_stats.items(), key=lambda x: sum(x[1]), reverse=True):
    n = len(pnls)
    win = sum(1 for p in pnls if p > 0)
    win_pct = 100.0 * win / n
    ort = sum(pnls) / n
    top = sum(pnls)
    mx = max(pnls)
    mn = min(pnls)
    print(f"{s:<20} {n:>5} {win:>8} {win_pct:>6.1f}% {ort:>9.2f} {top:>11.2f} {mx:>8.2f} {mn:>8.2f}")

print()
print("=" * 80)
print("PERİYOT BAZINDA DAĞILIM (tüm robotlar)")
print("=" * 80)
periyot_stats = defaultdict(list)
for r in records:
    periyot_stats[r["periyot"]].append(r["pnl"])

sira = {"15": 0, "60": 1, "240": 2, "G": 3}
for p, pnls in sorted(periyot_stats.items(), key=lambda x: sira.get(x[0], 99)):
    n = len(pnls)
    win = sum(1 for x in pnls if x > 0)
    win_pct = 100.0 * win / n
    ort = sum(pnls) / n
    top = sum(pnls)
    print(f"  {p:>4}: {n:>4} islem | Win%: {win_pct:.1f}% | Ort: {ort:.2f}% | Toplam: {top:.2f}%")

print()
print("=" * 80)
print("ROBOT x PERİYOT MATRISI (ToplamPnL)")
print("=" * 80)
rp_stats = defaultdict(lambda: defaultdict(list))
for r in records:
    rp_stats[r["robot"]][r["periyot"]].append(r["pnl"])

periyotlar = ["15", "60", "240", "G"]
print(f"{'Robot':<20}", end="")
for p in periyotlar:
    print(f"  {p:>8}", end="")
print()
print("-" * 60)
for rob in sorted(robot_stats.keys()):
    print(f"{rob:<20}", end="")
    for p in periyotlar:
        pnls = rp_stats[rob][p]
        if pnls:
            val = f"{sum(pnls):.1f}%"
        else:
            val = "-"
        print(f"  {val:>8}", end="")
    print()

print()
print("=" * 80)
print("ÇIKIŞ SEBEBİ DAĞILIMI")
print("=" * 80)
sebep_stats = defaultdict(list)
for r in records:
    s = r["sebep"]
    if "KÂR AL" in s:
        cat = "KAR AL"
    elif "İZL" in s:
        cat = "IZL.STOP"
    elif "STOP" in s:
        cat = "STOP"
    elif "ZAMAN" in s:
        cat = "ZAMAN"
    else:
        cat = "DIGER"
    sebep_stats[cat].append(r["pnl"])

for s, pnls in sorted(sebep_stats.items(), key=lambda x: -len(x[1])):
    n = len(pnls)
    ort = sum(pnls) / n
    top = sum(pnls)
    print(f"  {s:<12}: {n:>4} islem | Ort: {ort:>7.2f}% | Toplam: {top:.2f}%")

print()
print("=" * 80)
print("MAKSIMUM PNL'E ULAŞIP SONUNDA STOP YIYEN İŞLEMLER (KAYIP ETME POTANSİYELİ)")
print("(MaxPnL >= +2% ama PnL <= 0 olan işlemler)")
print("=" * 80)
wasted = [r for r in records if r["maxpnl"] >= 2.0 and r["pnl"] <= 0]
print(f"Toplam: {len(wasted)} işlem, {100*len(wasted)/len(records):.1f}% oran")
wasted_by_robot = defaultdict(list)
for r in wasted:
    wasted_by_robot[r["robot"]].append((r["pnl"], r["maxpnl"]))
for rob, lst in sorted(wasted_by_robot.items(), key=lambda x: -len(x[1])):
    avg_max = sum(m for _, m in lst) / len(lst)
    avg_pnl = sum(p for p, _ in lst) / len(lst)
    total_n = len(robot_stats[rob])
    print(f"  {rob:<22}: {len(lst):>4} adet ({100*len(lst)/total_n:.1f}%) | Ort.MaxPnL: {avg_max:.2f}% | Ort.Final: {avg_pnl:.2f}%")

print()
print("=" * 80)
print("SEMBOL BAZINDA KAZANMA ORANI (En Az 5 İşlem)")
print("(Hangi tür hisseler kazandırıyor?)")
print("=" * 80)
sembol_stats = defaultdict(list)
for r in records:
    sembol_stats[r["sembol"]].append(r["pnl"])

# Tum semboller icin win rate hesapla
sembol_win = []
for s, pnls in sembol_stats.items():
    if len(pnls) >= 5:
        win = sum(1 for p in pnls if p > 0)
        sembol_win.append((s, len(pnls), win, 100.0*win/len(pnls), sum(pnls)/len(pnls), sum(pnls)))

print("TOP 15 EN YÜKSEK WIN RATE (min 5 işlem):")
for s, n, win, wpct, ort, top in sorted(sembol_win, key=lambda x: -x[3])[:15]:
    print(f"  {s:<8}: {n:>3} işlem | Win%: {wpct:.0f}% | Ort: {ort:.2f}% | Top: {top:.2f}%")

print()
print("EN DÜŞÜK 10 WIN RATE (min 5 işlem):")
for s, n, win, wpct, ort, top in sorted(sembol_win, key=lambda x: x[3])[:10]:
    print(f"  {s:<8}: {n:>3} işlem | Win%: {wpct:.0f}% | Ort: {ort:.2f}% | Top: {top:.2f}%")

print()
print("=" * 80)
print("SNIPER KRİTER ANALİZİ — Kazanan vs Kaybeden işlem profili")
print("(SNIPER sinyalinden sonra +2 gün MaxPnL ve PnL ilişkisi)")
print("=" * 80)
sniper = [r for r in records if r["strateji"] == "SNIPER"]
sniper_win = [r for r in sniper if r["pnl"] > 0]
sniper_lose = [r for r in sniper if r["pnl"] <= 0]
print(f"  Kazanan {len(sniper_win)} işlem:")
print(f"    Ort.PnL: {sum(r['pnl'] for r in sniper_win)/len(sniper_win):.2f}%")
print(f"    Ort.MaxPnL: {sum(r['maxpnl'] for r in sniper_win)/len(sniper_win):.2f}%")
print(f"    MaxPnL = PnL (KAR AL çalışmış): {sum(1 for r in sniper_win if abs(r['maxpnl']-r['pnl'])<0.01)}")
print(f"  Kaybeden {len(sniper_lose)} işlem:")
print(f"    Ort.PnL: {sum(r['pnl'] for r in sniper_lose)/len(sniper_lose):.2f}%")
print(f"    Ort.MaxPnL: {sum(r['maxpnl'] for r in sniper_lose)/len(sniper_lose):.2f}%  <-- Bu ne kadar?"  )
print(f"    MaxPnL > 1% ama kaybeden: {sum(1 for r in sniper_lose if r['maxpnl'] >= 1.0)} adet")
print(f"    MaxPnL = 0 olanlar: {sum(1 for r in sniper_lose if r['maxpnl'] == 0.0)} adet (giriş anında ters döndü)")

print()
print("SNIPER PERİYOT DETAYI:")
sniper_by_periyot = defaultdict(list)
for r in sniper:
    sniper_by_periyot[r["periyot"]].append(r["pnl"])
for p, pnls in sorted(sniper_by_periyot.items(), key=lambda x: ["15","60","240","G"].index(x[0]) if x[0] in ["15","60","240","G"] else 99):
    win = sum(1 for x in pnls if x > 0)
    print(f"  {p:>4}: {len(pnls):>4} işlem | Win%: {100*win/len(pnls):.1f}% | Ort: {sum(pnls)/len(pnls):.2f}% | Toplam: {sum(pnls):.2f}%")

print()
print("=" * 80)
print("STOP YİYEN İŞLEMLERDE GİRİŞ ANINDAKİ MAXPNL=0 ORANI")
print("(Giriş fiyatı hiç kazanmadı = kriter yanlış)")
print("=" * 80)
for rob in sorted(robot_stats.keys()):
    stop_trades = [r for r in records if r["robot"] == rob and "STOP" in r["sebep"] and "İZL" not in r["sebep"]]
    if not stop_trades: continue
    maxpnl0 = sum(1 for r in stop_trades if r["maxpnl"] == 0.0)
    pct = 100.0 * maxpnl0 / len(stop_trades)
    avg_pnl = sum(r['pnl'] for r in stop_trades) / len(stop_trades)
    print(f"  {rob:<22}: {len(stop_trades):>4} STOP | MaxPnL=0: {maxpnl0:>4} ({pct:.1f}%) | Ort.Kayıp: {avg_pnl:.2f}%")
    print(f"    Bu islemlerin %{pct:.0f}'i giris aniyla HIC kazanmadi (yanlis giris kriteri)")

print()
print("=" * 80)
print("KÂR AL İLE KAPANAN STRATEJİ İSTATİSTİKLERİ")
print("=" * 80)
karal_by_strat = defaultdict(list)
toplam_by_strat = defaultdict(list)
for r in records:
    toplam_by_strat[r["strateji"]].append(r["pnl"])
    if "KÂR AL" in r["sebep"]:
        karal_by_strat[r["strateji"]].append(r["pnl"])

print(f"{'Strateji':<12} {'ToplamN':>7} {'KarAlN':>7} {'KarAl%':>8} {'OrtKarAl':>10} {'TopKarAl':>11} {'MaxKarAl':>10}")
print("-" * 75)
for s in sorted(karal_by_strat.keys(), key=lambda x: -len(karal_by_strat[x])):
    ka = karal_by_strat[s]
    total = toplam_by_strat[s]
    n_ka = len(ka)
    n_t = len(total)
    pct = 100.0 * n_ka / n_t
    ort = sum(ka) / n_ka
    top = sum(ka)
    mx = max(ka)
    print(f"{s:<12} {n_t:>7} {n_ka:>7} {pct:>7.1f}% {ort:>10.2f} {top:>11.2f} {mx:>10.2f}")

print()
print("ROBOT BAZINDA KÂR AL ÖZET")
print("-" * 75)
karal_by_robot = defaultdict(list)
toplam_by_robot = defaultdict(list)
for r in records:
    toplam_by_robot[r["robot"]].append(r["pnl"])
    if "KÂR AL" in r["sebep"]:
        karal_by_robot[r["robot"]].append(r["pnl"])

print(f"{'Robot':<20} {'ToplamN':>7} {'KarAlN':>7} {'KarAl%':>8} {'OrtKarAl':>10} {'TopKarAl':>11}")
print("-" * 75)
for s in sorted(karal_by_robot.keys(), key=lambda x: -sum(karal_by_robot[x])):
    ka = karal_by_robot[s]
    total = toplam_by_robot[s]
    n_ka = len(ka)
    n_t = len(total)
    pct = 100.0 * n_ka / n_t
    ort = sum(ka) / n_ka
    top = sum(ka)
    print(f"{s:<20} {n_t:>7} {n_ka:>7} {pct:>7.1f}% {ort:>10.2f} {top:>11.2f}")

print()
print("=" * 80)
print("EN İYİ 10 İŞLEM")
print("=" * 80)
for r in sorted(records, key=lambda x: -x["pnl"])[:10]:
    print(f"  {r['sembol']:<8} {r['strateji']:<12} P:{r['periyot']:>4}  PnL: {r['pnl']:>8.2f}%  MaxPnL: {r['maxpnl']:>8.2f}%")

print()
print("=" * 80)
print("EN KÖTÜ 10 İŞLEM")
print("=" * 80)
for r in sorted(records, key=lambda x: x["pnl"])[:10]:
    print(f"  {r['sembol']:<8} {r['strateji']:<12} P:{r['periyot']:>4}  PnL: {r['pnl']:>8.2f}%  MaxPnL: {r['maxpnl']:>8.2f}%")
