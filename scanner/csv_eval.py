"""
csv_eval.py — 10.04.2026 Yükselen/Düşen tablosunu kullanarak
09.04 tarama sonuçlarını değerlendirir ve trainer'ı günceller.

CSV kaynak: gerçek iDeal piyasa verisi — BAR dosyalarından daha doğru.
"""
import sys, json, re
from pathlib import Path

SCANNER_DIR = Path(__file__).parent
CSV_PATH = SCANNER_DIR / "10.04.2026 Yükselen Düşen tablosu.csv"
DAILY_LOG = SCANNER_DIR / "memory" / "daily_log.jsonl"
WEIGHTS_FILE = SCANNER_DIR / "memory" / "feature_weights.json"
PERF_LOG = SCANNER_DIR / "memory" / "perf_log.jsonl"

BIG_MOVE_THRESHOLD = 0.05  # %5
EMA_ALPHA = 0.1

# ── 1. CSV'yi oku: sembol → gerçek % değişim ─────────────────────
actual = {}
with open(CSV_PATH, encoding="cp1254") as f:
    for i, line in enumerate(f):
        if i == 0:
            continue  # başlık
        cols = line.strip().split(";")
        if len(cols) < 3:
            continue
        sym = cols[1].strip()
        pct_str = cols[2].strip().replace(",", ".")
        try:
            pct = float(pct_str)
            if sym:
                actual[sym] = pct
        except ValueError:
            pass

print(f"CSV'den yüklenen sembol: {len(actual)}")
print(f"  En çok yükselen (top 5):")
for s, p in sorted(actual.items(), key=lambda x: -x[1])[:5]:
    print(f"    {s}: +{p:.2f}%")
print(f"  En çok düşen (top 5):")
for s, p in sorted(actual.items(), key=lambda x: x[1])[:5]:
    print(f"    {s}: {p:.2f}%")

# ── 2. 09.04 taramasını daily_log'dan yükle ──────────────────────
scan_entry = None
with open(DAILY_LOG, encoding="utf-8") as f:
    for line in f:
        entry = json.loads(line)
        cands = entry.get("candidates", [])
        if not cands:
            continue
        first_date = str(cands[0].get("features", {}).get("_date", ""))[:10]
        if first_date == "2026-04-09":
            scan_entry = entry
            break  # İlk 09.04 bazlı taramayı al

if scan_entry is None:
    print("HATA: 09.04.2026 bazlı tarama bulunamadı.")
    sys.exit(1)

candidates = scan_entry["candidates"]
print(f"\n09.04 taraması: {len(candidates)} aday (veri bazı: 2026-04-09)")

# ── 3. Her aday için CSV'den gerçek getiriyi eşleştir ────────────
matched   = 0
hit5      = 0
hit2      = 0
miss      = 0
no_data   = 0
details   = []

for cand in candidates:
    sym = cand.get("sembol", "")
    if sym not in actual:
        no_data += 1
        continue
    pct = actual[sym]
    matched += 1
    success5 = pct >= BIG_MOVE_THRESHOLD * 100  # %5
    success2 = pct >= 2.0
    details.append({
        "sembol":  sym,
        "puan":    cand.get("puan", 0),
        "pct":     pct,
        "hit5":    success5,
        "hit2":    success2,
    })
    if success5:
        hit5 += 1
    if success2:
        hit2 += 1
    if pct < -1.0:
        miss += 1

print(f"\n── SONUÇ ─────────────────────────────────────────────")
print(f"  Eşleşen    : {matched} / {len(candidates)}")
print(f"  HIT (≥%5)  : {hit5} = {hit5/matched:.1%}" if matched else "N/A")
print(f"  HIT (≥%2)  : {hit2} = {hit2/matched:.1%}" if matched else "N/A")
print(f"  MISS (<-%1): {miss} = {miss/matched:.1%}" if matched else "N/A")
print(f"  Veri yok   : {no_data}")

# ── 4. Puan-Getiri korelasyonu (top20 vs bottom20) ───────────────
details.sort(key=lambda x: -x["puan"])
top20   = details[:20]
bot20   = details[-20:]
top_avg = sum(d["pct"] for d in top20) / len(top20) if top20 else 0
bot_avg = sum(d["pct"] for d in bot20) / len(bot20) if bot20 else 0

print(f"\n── PUAN-GETİRİ KORİLASYONU ───────────────────────────")
print(f"  Top 20 (en yüksek puan) ortalama getiri: {top_avg:+.2f}%")
print(f"  Bottom 20 (en düşük puan) ort. getiri :  {bot_avg:+.2f}%")
print(f"  Fark: {top_avg - bot_avg:+.2f}p  (pozitif = sistem çalışıyor)")

print(f"\n── TOP 20 DETAY ──────────────────────────────────────")
print(f"  {'SEMBOL':<8} {'PUAN':>6} {'GETIRI':>8} {'SONUÇ'}")
for d in top20:
    sonuc = "HIT5 🏆" if d["hit5"] else ("HIT2" if d["hit2"] else ("MISS ⬇️" if d["pct"] < -1 else "FLAT"))
    print(f"  {d['sembol']:<8} {d['puan']:>6.1f} {d['pct']:>+7.2f}%  {sonuc}")

# ── 5. CSV gerçek verisiyle trainer güncelle ─────────────────────
print(f"\n── TRAINER GÜNCELLEME (CSV bazlı) ─────────────────────")
with open(WEIGHTS_FILE, encoding="utf-8") as f:
    weights = json.load(f)

outcome_dict = {d["sembol"]: d["hit5"] for d in details}

# Feature başına gün içi aggregate
feat_hits   = {}
feat_totals = {}
for cand in candidates:
    sym = cand.get("sembol", "")
    if sym not in outcome_dict:
        continue
    success  = outcome_dict[sym]
    features = cand.get("features", {})
    for feat, raw_val in features.items():
        if feat not in weights:
            continue
        triggered = bool(raw_val >= 0.5) if isinstance(raw_val, (int, float)) else bool(raw_val)
        if not triggered:
            continue
        feat_totals[feat] = feat_totals.get(feat, 0) + 1
        if success:
            feat_hits[feat] = feat_hits.get(feat, 0) + 1

updated = []
for feat, n_total in feat_totals.items():
    if n_total == 0:
        continue
    n_hit = feat_hits.get(feat, 0)
    day_rate = n_hit / n_total
    w = weights[feat]
    old_ema = w.get("hit_rate_ema", 0.5)
    w.setdefault("total_count", 0)
    w.setdefault("hit_count", 0)
    w["total_count"] += n_total
    w["hit_count"]   += n_hit
    w["hit_rate_ema"] = round(EMA_ALPHA * day_rate + (1 - EMA_ALPHA) * old_ema, 4)
    updated.append((feat, old_ema * 100, w["hit_rate_ema"] * 100, n_total))

with open(WEIGHTS_FILE, "w", encoding="utf-8") as f:
    json.dump(weights, f, ensure_ascii=False, indent=2)

updated.sort(key=lambda x: x[2] - x[1])
print(f"  En çok düşen özellikler:")
for r in updated[:5]:
    print(f"    {r[0]:<28} {r[1]:.1f}% → {r[2]:.1f}% (N={r[3]})")
print(f"  En çok yükselen özellikler:")
for r in sorted(updated, key=lambda x: -(x[2]-x[1]))[:5]:
    print(f"    {r[0]:<28} {r[1]:.1f}% → {r[2]:.1f}% (N={r[3]})")

# Performans logu
perf = {
    "scan_date":   "2026-04-10",
    "data_date":   "2026-04-09",
    "source":      "CSV_direct",
    "hold_days":   1,
    "total":       matched,
    "hits5":       hit5,
    "hits2":       hit2,
    "hit_rate5":   round(hit5 / matched, 4) if matched else None,
    "hit_rate2":   round(hit2 / matched, 4) if matched else None,
    "top20_avg_pct": round(top_avg, 3),
    "bot20_avg_pct": round(bot_avg, 3),
}
with open(PERF_LOG, "a", encoding="utf-8") as f:
    f.write(json.dumps(perf, ensure_ascii=False, default=str) + "\n")

print(f"\n  Ağırlıklar güncellendi: {WEIGHTS_FILE}")
print(f"  Performans logu eklendi: source=CSV_direct")
