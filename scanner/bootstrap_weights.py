"""bootstrap_weights.py — Tek seferlik bootstrap çalıştırıcı

hit_rate_ema, backtest_results.json'dan alınır (varsa).
Backtest'te ölçülen gerçek hit oranları ile başlanır,
böylece trainer'ın ilk günden doğru diferansiyasyon ile çalışması sağlanır.
"""
import sys, json
from pathlib import Path
sys.path.insert(0, str(Path(__file__).parent))
from config import INITIAL_WEIGHTS, MEMORY_DIR

MEMORY_DIR.mkdir(parents=True, exist_ok=True)
weights_file   = MEMORY_DIR / "feature_weights.json"
backtest_file  = MEMORY_DIR / "backtest_results.json"

# Backtest hit rate'lerini yükle (varsa)
backtest_hits: dict = {}
if backtest_file.exists():
    try:
        with open(backtest_file, encoding="utf-8") as f:
            bt = json.load(f)
        for feat, v in bt.get("feature_stats", {}).items():
            hr = v.get("hit_rate", 0.5)
            if 0 < hr < 1:                       # geçerli oran
                backtest_hits[feat] = float(hr)
    except Exception:
        pass

bootstrap = {}
for name, w in INITIAL_WEIGHTS.items():
    # Backtest'te ölçülmüşse onu kullan, yoksa nötr 0.5
    ema_init = backtest_hits.get(name, 0.5)
    bootstrap[name] = {
        "base":         w["base"],
        "category":     w["category"],
        "desc":         w.get("desc", ""),
        "hit_rate_ema": round(ema_init, 4),
        "total_count":  0,
        "hit_count":    0,
    }

with open(weights_file, "w", encoding="utf-8") as f:
    json.dump(bootstrap, f, ensure_ascii=False, indent=2)

print(f"Oluşturuldu: {weights_file}")
print(f"  Backtest hit rate yüklendi: {len(backtest_hits)} özellik")
print(f"  Toplam özellik: {len(bootstrap)}")
print()
# Effective weight = base × (hit_rate_ema / 0.5) — sıralı göster
rows = [(k, v["base"], v["hit_rate_ema"]*100, v["base"]*(v["hit_rate_ema"]/0.5)) for k, v in bootstrap.items()]
rows.sort(key=lambda x: -x[3])
print("%-28s  BASE   HIT%%   EFF.W" % "OZELLIK")
print("-"*50)
for k, base, hr, eff in rows:
    print("%-28s %5.1f %6.1f%%  %5.2f" % (k, base, hr, eff))

