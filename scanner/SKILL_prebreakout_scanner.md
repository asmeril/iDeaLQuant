# Pre-Breakout Scanner Skill

## Görev

Bu skill BIST hisse senetlerinde kırılmadan önce güçlü özelliklere sahip hisseleri tespit eder. `D:\Projects\IdealQuant\scanner\` dizinindeki sistemi yönetir.

---

## Sistem Mimarisi

```
scanner/
├── config.py          → Yollar, semboller, eşikler, başlangıç ağırlıkları
├── loader.py          → CSV yükleme (cp1254, ; sep, Türkçe float format)
├── features.py        → 30+ özellik (VCP, Pocket Pivot, BB Squeeze, vb.)
├── patterns.py        → 12 formasyon (Hammer, Morning Star, VCP, Flag, vb.)
├── scorer.py          → Ağırlıklı puanlama, ağırlık dosyası I/O
├── backtest.py        → Tarihsel kalibrasyon (find_big_move_days → features)
├── trainer.py         → Günlük öz-iyileştirme (EMA hit rate güncelleme)
├── runner.py          → Ana orkestratör
└── memory/
    ├── feature_weights.json   → Canlı ağırlıklar (24 özellik)
    ├── daily_log.jsonl        → Günlük tarama kayıtları
    ├── performance_log.jsonl  → Hit rate log
    └── backtest_results.json  → Kalibrasyon sonuçları
```

---

## Günlük Kullanım

### Bugün tara:
```powershell
D:\Projects\.venv\Scripts\python.exe D:\Projects\IdealQuant\scanner\runner.py
```

### Geçmiş güne bak:
```powershell
D:\Projects\.venv\Scripts\python.exe runner.py --tarih 2026-04-08 --no-train
```

### Performans raporu:
```powershell
D:\Projects\.venv\Scripts\python.exe runner.py --perf-rapor
```

### Backtest (ağırlıkları kalibre et):
```powershell
D:\Projects\.venv\Scripts\python.exe backtest.py --save-weights
```

---

## Teknik Referans

### Veri Yolları
- **BAR_DIR:** `D:\Projects\IdealQuant\reference\ideal_docs\BarData_Export\`
- **Formatı:** `{SEMBOL}_Gunluk.csv`, `{SEMBOL}_60dk.csv`, vb.
- **Encoding:** cp1254 | Ayraç: `;` | Tarih: `dd.MM.yyyy`
- **Float format:** Türkçe (nokta=binlik, virgül=ondalık) → `_num()` fonksiyonu

### İndikatör Import Doğru İsimleri
```python
from indicators.core import EMA, SMA, RSI, ATR, ADX         # BÜYÜK HARF
from indicators.volume import OBV, ChaikinOsc
from indicators.volatility import BollingerWidth, TrueRange
from indicators.oscillators import MACD, StochasticFast
from indicators.trend import DI_Plus, DI_Minus, LinearRegSlope
```

> ⚠️ `ema`, `sma` (küçük harf) YANLIŞ. `EMA`, `SMA` (büyük harf) DOĞRU.

### MACD Unpack
```python
macd_line, signal_line, histogram = MACD(c, 12, 26, 9)  # 3-tuple
```

### Türkçe Float Fix
```python
def _num(s):
    s = str(s).strip()
    if ',' in s:
        s = s.replace('.', '').replace(',', '.')
    return float(s)
```

---

## Özellik Kategorileri

| Kategori | Özellikler | Kaynak |
|----------|------------|--------|
| **Compression** | vcp_score, bb_squeeze, nr7, nr4, inside_day_streak, atr_pct_rank | Minervini VCP, Bollinger, Crabel |
| **Volume** | pocket_pivot, vol_dryup, obv_slope, cmf_positive, up_vol_ratio | Gil Morales, O'Neil |
| **Structure** | ema_stack_score, ema50_slope_up, below_52w_high, rs_vs_xu100, base_position_ok | O'Neil CAN SLIM |
| **Momentum** | rsi_zone, rsi_slope_up, macd_hist_rising, macd_crossing, stoch_turning, adx_rising_low | — |

---

## Puanlama

- **🟢 Yüksek Öncelik:** ≥ 70 puan
- **🟡 Takipte:** 50-70 puan
- **🔴 Gözle:** < 50 puan

Efektif ağırlık formülü:
```python
eff_weight = base_weight × (0.5 + hit_rate_ema × 0.5)
```

---

## Öz-İyileştirme Döngüsü

```
Her iş günü akşamı:
1. runner.py → tahminleri kaydet (daily_log.jsonl)
2. Ertesi gün → trainer.evaluate_and_update() → gerçek hareketle karşılaştır
3. hit_rate_ema güncelleniyor (α=0.1)
4. feature_weights.json yeniden yazılıyor
```

---

## Sık Yapılan Hatalar

1. **Import hatası:** `from indicators.core import ema` → ❌ küçük harf
2. **Float bozulması:** `"3.3".replace(".", "") = "33"` → sadece virgül varsa replace yap
3. **09:05 barı geçersiz:** Pre-market flat bar → `active_bars[dt.hour >= 10].iloc[0]` kullan
4. **GapPrim EOD'dan hesaplama:** Tarama anında intraday close kullan
5. **Pattern summary fmt hatası:** `get_pattern_summary()` `[(name, score)]` tuple döndürür, `name` çıkarmak için `[p[0] for p in pats]`
