# VIP_X030-T Gap Reversal v1.0 — Optimizasyon Rehberi

**Strateji Dosyası:** `VIP_X030-T_1DK_GapReversal.cs`  
**Sembol:** VIP_X030-T | **Periyot:** 1 dakika | **Tarih:** 2026-04-07

---

## Temel İstatistiksel Zemin

ML analizinden (458 gap, 2023-2026):
- **%92** → gap gün içinde kapandı (Label=0, Reversal)
- **%8** → gap kapanmadı, trend devam etti (Label=1)

En güçlü özellikler: `Gap_Yuzde > Volatility_Std > Volume_Change > Pre_Trend_5Gun`

**Strateji bu istatistik üzerine kurulmuştur. Optimizasyon sırasında baz alınacak temel soru:
"Hangi gap'ler o %8'lik trend devam durumudur?" — o gap'lerden kaçınmak, kârlılığı artırır.**

---

## Parametre Sözlüğü

| Parametre | Varsayılan | Açıklama |
|---|---|---|
| `MIN_GAP_PCT` | 0.05 | Minimum gap büyüklüğü (%) — gürültü eşiği |
| `MAX_GAP_PCT` | 2.00 | Maksimum gap büyüklüğü (%) — haber gap'i filtresi |
| `CUMA_AKTIF` | false | Cuma gap'leri dahil edilsin mi? |
| `OR_BARS` | 15 | Opening Range süresi (dakika) |
| `RSI_FILTRE_AKTIF` | true | RSI koşulu aktif mi? |
| `RSI_PERIOD` | 5 | RSI periyodu |
| `RSI_OB` | 62 | SHORT için min RSI eşiği (yukarı gap) |
| `RSI_OS` | 38 | LONG için max RSI eşiği (aşağı gap) |
| `HACIM_FILTRE_AKTIF` | true | Hacim koşulu aktif mi? |
| `HACIM_MA_PERIOD` | 20 | Hacim ortalaması periyodu |
| `HACIM_ORAN` | 0.8 | Giriş barı hacmi ≥ MA × bu oran |
| `ATR_PERIOD` | 14 | ATR periyodu |
| `ATR_STOP_MULT` | 0.5 | Stop = OR extreme + ATR × çarpan |
| `GAP_WINDOW_BARS` | 210 | Pozisyon max süresi (bar = dakika) |
| `COOLDOWN_BARS` | 3 | Çıkış sonrası bekleme (bar) |

---

## Optimizasyon Sıralaması (Önceliğe Göre)

### 1. Önce Sabitlenecek — Gap Filtresi

Gap filtresi tüm stratejinin temelini belirler. İlk optimize edilir.

| Parametre | Test Değerleri | Not |
|---|---|---|
| `MIN_GAP_PCT` | 0.03 / **0.05** / 0.08 / 0.10 | Küçük gap'ler çok sık görülür, sinyal kalitesi düşer |
| `MAX_GAP_PCT` | 1.00 / 1.50 / **2.00** / 3.00 | >%2 genellikle siyasi/haber kaynaklı, kapanmayabilir |
| `CUMA_AKTIF` | **false** / true | Cuma gap'leri hafta sonu belirsizliği taşır |

**Beklenti:** MIN=0.05, MAX=1.50 genellikle en temiz senaryoyu verir.

---

### 2. Opening Range Süresi

OR süresi çok kritik: kısaysa sahte kırılım riski artar, uzunsa giriş geç olur.

| `OR_BARS` | Dakika | Karakteristik |
|---|---|---|
| 5 | 5 dk | Çok kısa, 09:30 açılış volatilitesi yüksek |
| **10** | 10 dk | Dengeli — önerilen başlangıç |
| **15** | 15 dk | Varsayılan |
| 20 | 20 dk | Daha az sinyal, daha güvenilir |
| 30 | 30 dk | Klasik OR, gün ortasına kayar |

**Kural:** OR uzadıkça sinyal sayısı düşer, isabet oranı artar.  
**Önerilen test:** 10 ve 15'i karşılaştır, daha sonra 20'ye bak.

---

### 3. ATR Stop Çarpanı

Stop çok dar → erken çıkış ve kayıp  
Stop çok geniş → büyük zarar, anlamsız stop

| `ATR_STOP_MULT` | Karakter |
|---|---|
| 0.3 | Çok dar — scalp senaryosu |
| **0.5** | Varsayılan — dengeli |
| 0.8 | Orta |
| 1.0 | Geniş — swing toleransı |
| 1.5 | Çok geniş — eğer gap kapanmıyorsa zararı büyütür |

**Not:** Stop = OR_Extreme + ATR × MULT. OR genişliği de zaten doğal bir tampon içeriyor.  
VIP_X030-T ATR ortalaması ≈ 8-15 puan (1 dk). ATR_STOP_MULT=0.5 → ~4-8 puan ek tampon.

---

### 4. Zaman Penceresi

Gap fill ne kadar geç olursa, gün içi kapanma olasılığı düşer.

| `GAP_WINDOW_BARS` | Süre | Not |
|---|---|---|
| 120 | 2 saat | Sadece sabah gap'leri |
| **180** | 3 saat | Önerilen — gün seansının ilk yarısı |
| **210** | 3.5 saat | Varsayılan |
| 300 | 5 saat | Öğleden sonraya uzanır |
| 420 | 7 saat | Gün sonu kapanış dahil |

**Kritik:** Eğer gap 14:00'a kadar kapanmadıysa, kapanma ihtimali dramatik düşer.  
`GAP_WINDOW_BARS = 270` (4.5 saat) genellikle iyi bir hız/isabet dengesi sunar.

---

### 5. RSI Filtresi

RSI filtresi aktifken sinyal sayısı düşer, isabet oranı artabilir veya düşebilir.

**Önce RSI filtresi KAPALI çalıştır.** Sonra açık haliyle karşılaştır.

| Senaryo | `RSI_OB` | `RSI_OS` | Karakter |
|---|---|---|---|
| Gevşek | 55 | 45 | Çok sinyal |
| **Varsayılan** | **62** | **38** | Dengeli |
| Sıkı | 68 | 32 | Az sinyal, yüksek isabet |
| Çok sıkı | 72 | 28 | Nadir sinyal |

**Not:** RSI_PERIOD=5 çok hızlı tepki verir. Daha istikrarlı için RSI_PERIOD=8 veya 14 dene.

---

### 6. Hacim Filtresi

Hacim filtresi sahte OR kırılımlarını engeller.

| `HACIM_ORAN` | Karakter |
|---|---|
| 0.5 | Çok gevşek |
| **0.8** | Varsayılan |
| 1.0 | Ortalama üzeri hacim zorunlu |
| 1.3 | Yüksek hacim zorunlu — agresif filtre |

---

## Optimizasyon Akışı (Adım Adım)

```
ADIM 1:  RSI=kapalı, HACIM=kapalı
         MIN_GAP_PCT değerlerini tara: 0.03 / 0.05 / 0.08 / 0.10
         → En iyi MIN_GAP_PCT'yi bul (A)

ADIM 2:  A sabit, OR_BARS değerlerini tara: 10 / 15 / 20
         → En iyi OR_BARS'ı bul (B)

ADIM 3:  A+B sabit, ATR_STOP_MULT tara: 0.3 / 0.5 / 0.8 / 1.0
         → En iyi ATR_STOP_MULT'u bul (C)

ADIM 4:  A+B+C sabit, GAP_WINDOW_BARS tara: 120 / 180 / 210 / 300
         → En iyi GAP_WINDOW_BARS'ı bul (D)

ADIM 5:  A+B+C+D sabit, RSI filtresi AÇ
         RSI_OB/OS değerlerini tara: (55/45) (62/38) (68/32)
         → RSI KAPALI ile karşılaştır. Anlamlı iyileşme yoksa KAPALI bırak.

ADIM 6:  HACIM filtresi aynı şekilde test et: 0.5 / 0.8 / 1.0 / 1.3

ADIM 7:  CUMA_AKTIF = true ile test et. Cuma gap'leri kâr/zarar dengesini bozuyorsa false bırak.
```

---

## Değerlendirme Metrikleri (Öncelik Sırası)

1. **Kazanç Oranı (Win Rate)** — %60+ hedefle başla
2. **Ortalama Kâr / Ortalama Zarar (Payoff Ratio)** — ≥1.2 olmalı
3. **Beklenti (Expectancy)** = (WR × AvgWin) - ((1-WR) × AvgLoss) → pozitif olmalı
4. **Max Ardışık Kayıp** — 4'ten fazlaya dikkat et (drawdown yönetimi)
5. **Toplam İşlem Sayısı** — <30 ise istatistiksel güven düşük

> **Uyarı:** Tek bir metriği maksimize etme. Win rate %80 ama average loss çok büyükse beklenti negatif olabilir.

---

## Kaçınılacak Durumlar (Kural Bazlı Eklemeler)

Aşağıdaki durumlarda strateji performansı tarihen zayıflar. Filtre olarak eklenmesi değerlendirilebilir:

| Durum | Öneri |
|---|---|
| Gap >%1.5 ve Pazartesi | `MAX_GAP_PCT` düşür veya Pazartesi filtresi ekle |
| Arefe öncesi Cuma gap'leri | `CUMA_AKTIF = false` zaten bu durumu engeller |
| Tatil arkası ilk gün gap'leri | Tatil arefesi mantığı mevcut — kontrol et |
| Gap yönü önceki 5 günlük trendle aynı | `Pre_Trend_5Gun` ML özelliği bunu yakalıyor — eğer agresif trend varsa ML skoru kullan |
| Akşam seansı gap'leri | Kod sadece sabah gap'lerini tespit ediyor (gece 10+ saat boşluk) ✓ |

---

## ML Modeli ile Entegrasyon (gap_model.pkl)

Strateji şu an kural tabanlı. ML modeli ek filtre olarak kullanılabilir:

```
gap_api.py → POST /predict → { "decision": "GAP_KAPANIYOR" veya "TREND_DEVAM" }

Ekleme mantığı:
  TREND_DEVAM → giriş yapma (o günün gap'ini atla)
  GAP_KAPANIYOR + prob_kapanma > 0.75 → giriş yap
```

Bunu uygulamak için `gap_api.py`'yi çalıştır ve `girisOnKosul`'a HTTP çağrısı veya Python bridge ekle.
Bu entegrasyon v2.0 olarak planlandı.

---

## Hızlı Referans — Başlangıç Parametreleri

```csharp
// Muhafazakâr başlangıç (daha az işlem, daha yüksek kalite)
MIN_GAP_PCT      = 0.08f;
MAX_GAP_PCT      = 1.50f;
OR_BARS          = 15;
RSI_FILTRE_AKTIF = false;   // Önce kapat, test et
HACIM_FILTRE_AKTIF = true;
HACIM_ORAN       = 1.0f;
ATR_STOP_MULT    = 0.5f;
GAP_WINDOW_BARS  = 180;
CUMA_AKTIF       = false;
```

```csharp
// Agresif (daha fazla işlem, düşük eşikler)
MIN_GAP_PCT      = 0.05f;
MAX_GAP_PCT      = 2.00f;
OR_BARS          = 10;
RSI_FILTRE_AKTIF = true;
RSI_OB           = 58f;
RSI_OS           = 42f;
HACIM_ORAN       = 0.6f;
ATR_STOP_MULT    = 0.8f;
GAP_WINDOW_BARS  = 270;
CUMA_AKTIF       = false;
```
