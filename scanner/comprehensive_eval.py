"""
comprehensive_eval.py — 10.04.2026 kapsamlı analiz

1. Telegram'daki Robot tarama sonuçları (screenshots'dan manuel girdi)
   10:30 / 14:30 / 17:30 pencereleri
2. Bu sembollerin 10.04.2026'da ne yaptığı (CSV kaynak)
3. Python scanner (09.04 bazlı) vs Robot karşılaştırması
4. Orijinal amaç analizi: PreMove scanner neden kuruldu?
"""
import json, glob
from pathlib import Path

SCANNER_DIR = Path("D:/Projects/IdealQuant/scanner")
CSV_GLOB = str(SCANNER_DIR / "*.csv")

# ── Telegram'dan manuel okunan Robot sonuçları ────────────────────
# Format: sembol → (saat, puan, fiyat)
robot_10_30 = {
    "ULUFA":  (82,  4.46),
    "KRDMB":  (81, 71.60),
    "KAPLM":  (78,570.50),
    "ECZYT":  (75,370.25),
    "ADEL":   (75, 47.56),
    "TKFEN":  (73,109.90),
    "RALYH":  (73,257.00),
    "AKMGY":  (72,307.00),
    "ISKPL":  (72, 15.88),
}
robot_14_30 = {
    "GOLTS":  (85,383.50),
    "DOGUB":  (83,112.40),
    "ULUFA":  (82,  4.50),
    "ADEL":   (80, 46.60),
    "KAPLM":  (78,617.50),
    "EREGL":  (78, 30.92),
    "TKFEN":  (77,108.40),
    "ISKPL":  (77, 16.26),
    "KRDMB":  (76, 71.10),
    "KRDMD":  (76, 37.30),
}
robot_17_30 = {
    "ULUFA":  (92,  4.83),
    "ARZUM":  (90,  3.45),
    "GOLTS":  (85,383.50),
    "EREGL":  (85, 31.61),   # VIP-EREGL
    "DOGUB":  (83,112.70),
    "VAKKO":  (82, 95.40),
    "AKMGY":  (80,310.50),
    "ANELE":  (79, 21.64),
    "KAPLM":  (78,603.00),
    "KTSKR":  (78,105.20),
}

# ── CSV yükle ─────────────────────────────────────────────────────
csvs = glob.glob(CSV_GLOB)
if not csvs:
    print("HATA: CSV bulunamadi")
    exit(1)
csv_path = csvs[0]
print(f"CSV: {csv_path}")

actual = {}
with open(csv_path, encoding="cp1254") as f:
    for i, line in enumerate(f):
        if i == 0:
            continue
        cols = line.strip().split(";")
        if len(cols) < 3:
            continue
        sym_y = cols[1].strip()
        pct_y = cols[2].strip().replace(",", ".")
        if sym_y:
            try:
                actual[sym_y] = float(pct_y)
            except ValueError:
                pass
        if len(cols) >= 5:
            sym_d = cols[3].strip()
            pct_d = cols[4].strip().replace(",", ".")
            if sym_d:
                try:
                    actual[sym_d] = float(pct_d)
                except ValueError:
                    pass

print(f"CSV'de eşsiz sembol: {len(actual)}")

# ── Analiz fonksiyonu ─────────────────────────────────────────────
def analyze_scan(name, scan_dict, hold="ertesi_gun"):
    print(f"\n{'='*60}")
    print(f"  {name} — {len(scan_dict)} sembol")
    print(f"{'='*60}")
    print(f"  {'SEMBOL':<8} {'PUAN':>5} {'GIRIŞ':>8} {'10.04%':>8}  SONUÇ")
    print(f"  {'-'*50}")
    hits5, hits2, flat, miss, total = 0, 0, 0, 0, 0
    for sym, (puan, fiyat) in sorted(scan_dict.items(), key=lambda x: -x[1][0]):
        pct = actual.get(sym, None)
        if pct is None:
            print(f"  {sym:<8} {puan:>5} {fiyat:>8.2f}  {'N/A':>8}")
            continue
        total += 1
        if pct >= 5.0:
            hits5 += 1; tag = "HIT5 🏆"
        elif pct >= 2.0:
            hits2 += 1; tag = "HIT2"
        elif pct < -1.0:
            miss += 1; tag = "MISS ⬇"
        else:
            flat += 1; tag = "flat"
        print(f"  {sym:<8} {puan:>5} {fiyat:>8.2f}  {pct:>+7.2f}%  {tag}")
    if total > 0:
        print(f"\n  ÖZET: HIT≥5%: {hits5}/{total}={hits5/total:.0%}  HIT≥2%: {hits5+hits2}/{total}={(hits5+hits2)/total:.0%}  MISS: {miss}/{total}={miss/total:.0%}")
    return hits5, hits5+hits2, total

h5_10, h2_10, n_10 = analyze_scan("10:30 TARAMASI — intraday sonucu", robot_10_30)
h5_14, h2_14, n_14 = analyze_scan("14:30 TARAMASI — intraday sonucu", robot_14_30)
h5_17, h2_17, n_17 = analyze_scan("17:30 EOD (pazartesi adayları)", robot_17_30)

# ── Puan 10:30→EOD korelasyonu — intraday momentum ────────────────
print(f"\n{'='*60}")
print("  INTRADAY FİYAT HAREKETİ (screenshots'dan)")
print(f"{'='*60}")
print("  ULUFA : 4.46 (10:30) → 4.50 (14:30) → 4.83 (17:30) = +8.3%  ← 10:30'da yakalandı!")
print("  KAPLM : 570.50 (10:30) → 617.50 (14:30) → 603.00 (17:30)")
kaplm_intra = (617.50 - 570.50) / 570.50 * 100
print(f"    14:30 zirvesi: {kaplm_intra:+.1f}%")
print("  ADEL  : 47.56 (10:30) → 46.60 (14:30) = -2.0%  ← 10:30 sonrası düştü")
print("  AKMGY : 307.00 (10:30) → 310.50 (17:30) = +1.1%")

# ── Python Scanner 09.04 adaylarının 10.04 performansı ────────────
print(f"\n{'='*60}")
print("  PYTHON SCANNER (09.04 bazlı) TOP 20 — 10.04 sonucu")
print(f"{'='*60}")
log = Path("D:/Projects/IdealQuant/scanner/memory/daily_log.jsonl")
cands_0904 = []
with open(log, encoding="utf-8") as f:
    for line in f:
        e = json.loads(line)
        cs = e.get("candidates", [])
        if cs and str(cs[0].get("features", {}).get("_date", ""))[:10] == "2026-04-09":
            cands_0904 = cs
            break

cands_0904.sort(key=lambda x: -x.get("puan", 0))
print(f"  {'SEMBOL':<8} {'PUAN':>5} {'10.04%':>8}  SONUÇ")
print(f"  {'-'*40}")
py_hits5, py_total = 0, 0
for c in cands_0904[:20]:
    sym = c.get("sembol", "")
    puan = c.get("puan", 0)
    pct = actual.get(sym, None)
    if pct is None:
        print(f"  {sym:<8} {puan:>5}  {'N/A':>8}")
        continue
    py_total += 1
    if pct >= 5.0:
        py_hits5 += 1; tag = "HIT5 🏆"
    elif pct >= 2.0: tag = "HIT2"
    elif pct < -1.0: tag = "MISS ⬇"
    else: tag = "flat"
    print(f"  {sym:<8} {puan:>5}  {pct:>+7.2f}%  {tag}")

# ── Overlay: Robot'ta var ama Python'da yok / Python'da var ama Robot'ta yok
robot_all = set(robot_10_30) | set(robot_14_30) | set(robot_17_30)
py_top20  = {c["sembol"] for c in cands_0904[:20]}
only_robot = robot_all - py_top20
only_python = py_top20 - robot_all
both = robot_all & py_top20

print(f"\n{'='*60}")
print("  ROBOT vs PYTHON KARŞILAŞTIRMA (top 20)")
print(f"{'='*60}")
print(f"  Sadece Robot buldu ({len(only_robot)}): {sorted(only_robot)}")
print(f"  Sadece Python buldu ({len(only_python)}): {sorted(only_python)}")
print(f"  İkisi de buldu ({len(both)}): {sorted(both)}")

print(f"\n  Sadece Robot'un bulduklarının 10.04 performansı:")
for sym in sorted(only_robot):
    pct = actual.get(sym, None)
    tag = f"{pct:+.2f}%" if pct is not None else "N/A"
    print(f"    {sym:<8} {tag}")

# ── Özet tablo ─────────────────────────────────────────────────────
print(f"\n{'='*60}")
print("  ÖZET KARŞILAŞTIRMA")
print(f"{'='*60}")
print(f"  Robot 10:30 HIT≥5%: {h5_10}/{n_10} = {h5_10/n_10:.0%} (intraday)" if n_10 else "")
print(f"  Robot 14:30 HIT≥5%: {h5_14}/{n_14} = {h5_14/n_14:.0%} (intraday)" if n_14 else "")
print(f"  Robot 17:30 HIT≥5%: {h5_17}/{n_17} = {h5_17/n_17:.0%} (ertesi gun)" if n_17 else "")
print(f"  Python top-20 HIT≥5%(10.04): {py_hits5}/{py_total}" if py_total else "")
