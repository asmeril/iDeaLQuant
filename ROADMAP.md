# 🗺️ IdealQuant - Yol Haritası v2.0

## 🎯 Ana Hedef
IdealData backtest sonuçları ile **%100 uyumlu** harici backtest + optimizasyon + robust parametre seçim sistemi.

**Deadline:** Pazar Geceyarısı (2 Şubat 00:00)

---

## 📋 Faz Durumları

| Faz | Durum | Açıklama | Öncelik |
|-----|-------|----------|---------|
| Faz 0 | ✅ | Proje Kurulumu | - |
| Faz 1 | ✅ | IdealData Uyumu | - |
| Faz 2 | ✅ | Optimizasyon Motoru | - |
| Faz 3 | ✅ | Robust Parametre | - |
| Faz 4 | ✅ | IdealData Entegrasyonu | - |
| Faz 5 | ✅ | **v4.1 Sistem Hizalaması** | 🔴 Kritik |
| Faz 6 | ✅ | Desktop UI (PySide6) | - |
| Faz 7 | ✅ | Veritabanı Entegrasyonu | - |
| Faz 8 | 🔄 | Agent Dokümantasyonu | 🔴 Sürekli |
| Faz 9 | 🔄 | Canlı Test & S5 Araştırma | 🟡 Düşük |
| Faz 10| ✅ | Strateji 5 (Oliver Kell) | - |
| Faz 11| ✅ | **Strateji 6 (TOTT_HOTT)** | - |

---

## ✅ FAZ 0-2: TAMAMLANDI

<details>
<summary>Detaylar için tıkla</summary>

### Faz 0: Proje Kurulumu
- [x] Proje klasörü, Git repo, temel yapı

### Faz 1: IdealData Uyumu
- [x] Veri okuma %100 uyum
- [x] İndikatörler %99+ uyum
- [x] Sinyal eşleşme %97.8
- [x] P&L eşleşme %97

### Faz 2: Optimizasyon Motoru
- [x] 32-thread paralel işleme
- [x] 3-aşamalı optimizasyon (Satellite-Drone-Stability)
- [x] Hibrit Grid Optimizer
- [x] Genetik Algoritma
- [x] **Bayesian Optimizer (Optuna)** ← YENİ
- [x] **Optimizer Audit & Bug Fixes** (Feb 11) ← YENİ
- [x] **Advanced Fitness Modeling** ← YENİ
  - Stricter Selection (Min PF 1.5)
  - "Sweet Spot" Bonus (PF 1.5-2.5)
  - Equity Smoothness (R²) Reward
  - Anti-Overtrading Logic

### Kalibrasyon (✅ TAMAMLANDI)
| Gösterge | Max Fark |
|----------|----------|
| ARS | ~0.01 |
| Momentum, HHV/LLV | 0.00 |
| Volume HHV/LLV | 0.00 |
| MFI | 0.005 |
| ATR | 0.0001 |
| OBV / ADL | 0.00 (Kümülatif fix) |
| Aroon / Stoch | 0.00 (Formül fix) |
| ARS_Dynamic | 0.00 (Yuvarlama fix) |

</details>

### Strateji Validasyonu (✅ TAMAMLANDI)
- [x] Strateji 1 Python Portu: `score_based.py` (Gatekeeper)
- [x] Strateji 2 Python Portu: `ars_trend_v2.py` (Trend)
- [x] Strateji 3 Python Portu: `paradise_strategy.py` (HH/LL Breakout + Momentum)
- [x] Strateji 4 Python Portu: `toma_strategy.py` (TOMA + Momentum)
- [x] IdealData Kaynak Kodları: `S1`, `S2`, `Paradise`, `TOMA_S4`
- [x] **v4.2 Uyumu:** Tüm stratejiler (S1-S4) senkronize edildi, cache desteği ve C# export eklendi.
- [x] **Numba Optimizasyonu & Tip Düzeltmeleri:** `times_arr` Python PyObject array'lerinden `np.int64` Unix damgalarına dönüştürülerek Numba TypingError çökmesi giderildi.
- [x] **Global OOS Penalty:** Tüm optimizer metodları ve standalone scriptlere (S1-S4) OOS-aware re-ranking entegre edildi.

---

## 🔄 FAZ 3: Robust Parametre Seçimi [AKTİF]

> [!IMPORTANT]
> Bu faz overfitting'i tespit edip güvenli parametreleri belirler.

### 3.1 Walk-Forward Analiz ✅
- [x] `src/robust/walk_forward.py` oluşturuldu
- [x] In-sample / Out-of-sample bölme
- [x] Rolling window implementasyonu
- [x] WFA skoru hesaplama

### 3.2 Monte Carlo Simülasyonu ✅
- [x] `src/robust/monte_carlo.py` oluşturuldu
- [x] Trade shuffle (1000 simülasyon)
- [x] %95 Confidence interval
- [x] Risk of Ruin hesaplama

---

## ✅ FAZ 4: IdealData Entegrasyonu [TAMAMLANDI]

### 4.1 Binary Parser ✅
- [x] `src/data/ideal_parser.py` - .01 dosyalarını okur
- [x] 32-byte record format çözüldü
- [x] Tüm periyotlar destekleniyor (1dk, 5dk, 60dk, G)

### 4.2 Kod Export ✅
- [x] `src/export/idealdata_exporter.py`
- [x] Strateji 1 + 2 + 3 + 4 kod üretimi
- [x] S4 Risk Yönetimi (Kar Al/İzleyen Stop) & Mantık Hizalaması (Feb 22)
- [x] **Pro Performance Panel & Çizgi İndeks Hizalaması** (Feb 25)
- [x] Birleşik robot kodu
- [x] Sistematik dosya isimlendirme
- [ ] Isı haritası

---

## ⏸️ FAZ 4: IdealData Dosya Yapısı

> CSV'ye gerek kalmadan direkt binary okuma.

### 4.1 Binary Analiz
- [ ] IdealData dosya formatı reverse engineering
- [ ] `src/engine/ideal_reader.py` oluştur
- [ ] OHLCV direkt okuma

---

## ⏸️ FAZ 5: Veritabanı Entegrasyonu

### 5.1 SQLite Şema
- [ ] `src/database/` modül oluştur
- [ ] OHLCV tabloları
- [ ] Optimizasyon sonuç tabloları
- [ ] CRUD operasyonları

---

## ⏸️ FAZ 6: Validation Modülü

### 6.1 İndikatör Karşılaştırma
- [ ] `src/validation/` modül oluştur
- [ ] Otomatik indikatör doğrulama
- [ ] Backtest karşılaştırma raporları

---

## 🔄 FAZ 7: Agent Dokümantasyonu [SÜREKLİ]

### 7.1 AI Kuralları
- [x] `CLAUDE.md` güncellendi (Gemini 3 Pro uyumu)
- [ ] Yeni workflow dosyaları

---

## 🟢 FAZ 10: Strateji 5 (Oliver Kell) [YENİ]

> [!NOTE]
> 2020 US Investing Championship şampiyonu Oliver Kell'ın stratejisinin IdealQuant motoruna entegrasyonu.

### 10.1 İdeal C# Prototiplemesi ✅
- [x] Sadece Long (Hisse/Spot) versiyonu
- [x] Çift Yönlü Long/Short (VİOP) versiyonu
- [x] Testere (Chop) Filtresi: `EMA10[i] > EMA10[i-1]` (Lineer regresyon eğimi yerine gerçek hareketli ortalama türevi) ve `ADX > 20`
- [x] Hacim Filtresi: `Volume > MA(Volume, 20)`
- [x] İz Süren Stop Kar Al mekanizması

### 10.2 Python Motoruna Entegrasyon ✅
- [x] `src/strategies/oliver_kell_s5.py` oluşturuldu (EMA/ADX/HH-LL/Volume/Trailing Stop)
- [x] `src/optimization/strategy5_optimizer.py` — Numba JIT + IndicatorCache
- [x] Genetik + Bayesian + Hibrit optimizer dispatch
- [x] Hibrit Grup yeniden yapılandırma: Yapisal (6p) + Risk cascade (1p)
- [x] Satellite-Drone adım boyutları (`PARAM_TYPES` kaydı)
- [x] Tüm UI panelleri (Optimizer, Validation, Export, Strategy, Live Monitor)
- [x] C# export template (`_generate_strategy5_code` + `export_strategy5`)

### 10.3 3-Mod Vade Tipi Desteği (S5) ✅
- [x] `VIOP_ENDEKS` — Vadeli Endeks (VIP-X030), çift yön, vade geçişi
- [x] `VIOP_SPOT` — Vadeli Spot (VIP-THYAO), çift yön, vade geçişi
- [x] `SPOT` — Spot Hisse (EREGL), tek yön (AL/FLAT), vade geçişi yok

> [!WARNING]
> **TODO:** S1-S4 stratejilerini de 3-mod vade tipi yapısına (VIOP_ENDEKS / VIOP_SPOT / SPOT) geçirmek gerekiyor. Şu an sadece S5'te aktif.

---

## 🟢 FAZ 11: Strateji 6 (TOTT_HOTT) [YENİ]

> [!NOTE]
> TOTT_HOTT sistemi. 

### 11.1 İndikatör & Çekirdek Altyapı ✅
- [x] Variable MA (VIDYA) + Sabit CMO Window=9 kalibrasyonu
- [x] OTT ve TTI (Trend Tracker Index) entegrasyonu + Kalibrasyon
- [x] Python sınıfı `tott_hott_strategy.py`

### 11.2 Optimizasyon Motoru ✅
- [x] Numba + Multiprocessing destekli standalone optimizer
- [x] Dökümandaki 3 fazlı (Main, Zone, Gate) konfigürasyonlara uyum

### 11.3 UI ve Genel Entegrasyon ✅
- [x] ExportPanel ve StrategyPanel arayüz desteği
- [x] Validasyon (WFA/MC) paneline bağlanması
- [x] **BUG FIX:** KMeans NaN ve Genetik Entegrasyon sorunları çözüldü.
- [x] **BUG FIX:** Otomatik veri yükleme (data_file persistence) sağlandı.
- [x] **BUG FIX:** C# Export dosyasındaki sinyal uyumsuzluğu (StochasticFast / HHV(5) / Warmup Fix) Onarıldı.

---

## 🔄 FAZ 12: Strateji 7 (DeepScalp v1.2) [AKTİF]

### 12.1 Python Altyapısı ✅
- [x] `deepscalp_strategy.py` — 6 katmanlı strateji (ARS, SuperTrend, TOMA, MFI, ATR, Zaman)
- [x] `strategy7_optimizer.py` — Numba JIT + IndicatorCache
- [x] Genetik & Bayesian optimizer entegrasyonu
- [x] UI panelleri (Optimizer, Strategy, Export) entegrasyonu
- [x] C# Exporter şablonu (`_generate_strategy7_code`)

### 12.2 S4 Optimizasyon Refactoring 🔄
- [ ] **Faz 4 Ayrıştırma:** `kar_al` + `iz_stop` çıkış parametrelerini Faz 3'ten ayırıp bağımsız Faz 4 yap
  - `strategy4_optimizer.py`: `s4_p4_eval` fonksiyonu eklenmeli
  - `optimizer_panel.py`: Faz 3 gen'inden risk_ranges çıkarılmalı, yeni Faz 4 Pool bloğu + checkpoint
- [ ] **SuperTrend Kalibrasyonu:** `get_supertrend` Python impl. + IdealData doğrulaması
- [ ] **C# Export:** S7 SuperTrend kodu C# exporter'a eklenmeli



## ⏸️ FAZ 8: Uygulama Arayüzü [SON ADIM]

> [!IMPORTANT]
> AI'ya ihtiyaç duymadan tek başına kullanılabilen uygulama.

### 8.1 CLI (Command Line Interface)
- [ ] `python -m idealquant optimize --strategy X`
- [ ] `python -m idealquant wfa --strategy X`
- [ ] `python -m idealquant mc --simulations 1000`

### 8.2 Web UI (Streamlit)
- [ ] Parametre grid tanımlama (slider'larla)
- [ ] Tek tıkla optimizasyon
- [ ] İnteraktif sonuç grafikleri
- [ ] Walk-Forward & Monte Carlo dashboard

---

## 📅 Zaman Çizelgesi

```
Cuma       00:55  ─┬─ FAZ 3 Başlangıç (Walk-Forward)
              ↓   │
Cumartesi  12:00  ─┼─ FAZ 3 Monte Carlo
              ↓   │
Cumartesi  18:00  ─┼─ FAZ 3 Stabilite
              ↓   │
Cumartesi  24:00  ─┼─ FAZ 4 IdealData Decompile
              ↓   │
Pazar      12:00  ─┼─ FAZ 5 Veritabanı
              ↓   │
Pazar      18:00  ─┼─ FAZ 6 Validation
              ↓   │
Pazar      24:00  ─┴─ DEADLINE ✓
```

---

## 🔗 İlgili Dosyalar

- [Implementation Plan](../.gemini/antigravity/brain/current/implementation_plan.md)
- [Günlük](DEVLOG.md)
- [AI Kuralları](.agent/CLAUDE.md)
- [Workflows](.agent/workflows/)
