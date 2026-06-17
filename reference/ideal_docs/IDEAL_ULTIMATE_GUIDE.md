# iDeal Platformu (ideal.exe) Nihai Başvuru ve Yazılım Kılavuzu

Bu doküman, iDeal Algoritmik İşlem Platformu (`ideal.exe`) üzerinde çalışan formüller, robotlar ve indikatörler yazmak isteyen yazılımcılar ve yapay zeka modelleri için hazırlanmış **kapsamlı ve birleştirilmiş tek referans kılavuzudur**. 

Kılavuz, iDeal'in kullanıcıya sunduğu üst seviye **C# Scripting API'ını** (Sistem Sınıfı) ve platformun arka planda kullandığı decompile edilmiş **düşük seviyeli .NET sınıfları ile veri modellerini** bir araya getirir.

---

## BÖLÜM 1: Üst Seviye C# Scripting API (Sistem Sınıfı)

iDeal sistem editöründe yazılan kodlar `Sistem` nesnesi üzerinden platform özelliklerine erişir.

### 1.1 Robot Aktivasyon Fonksiyonları
Robotları grafik sinyallerine bağlamak ve doğrudan emir gönderimini yönetmek için kullanılan tek satırlık hazır fonksiyonlardır.

| Fonksiyon Tanımı | Açıklama |
|------------------|----------|
| `Sistem.RobotHisseAktifAcigaVar(SistemAdi, BazSembol, EmirSembol, Periyot, Miktar)` | Hisse senetlerinde çalışır, AL/SAT yapar ve açığa satış (Short) izni varsa açığa satar. |
| `Sistem.RobotHisseAktifAcigaYok(SistemAdi, BazSembol, EmirSembol, Periyot, Miktar)` | Hisse senetlerinde çalışır, açığa satış yapmaz. Sadece AL yapar ve SAT sinyalinde eldekileri satar. |
| `Sistem.RobotViopAktif(SistemAdi, BazSembol, EmirSembol, Periyot, Miktar)` | VİOP kontratlarında çalışır, sinyal anında aktif fiyattan (Piyasa) emir iletir. |
| `Sistem.RobotViopTumGun(SistemAdi, BazSembol, EmirSembol, Periyot, Miktar)` | VİOP kontratlarında çalışır. Akşam seansı dahil olmak üzere gün boyu emir gönderir. |
| `Sistem.RobotViopGunSonuKapat(SistemAdi, EmirSembol)` | Gün sonunda VİOP pozisyonunu otomatik kapatır. Ertesi gün sistem yönüne göre tekrar pozisyon açar. |
| `Sistem.RobotStop()` | Çalışmakta olan tüm robotları tek komutla durdurur (örn. acil durum stop mekanizmaları için). |

**Parametre Detayları:**
*   `SistemAdi` (string): Sinyal üreten formülün adı (örn. `"MA_Cross"`).
*   `BazSembol` (string): Sinyalin hesaplandığı grafik sembolü (örn. `"IMKBH'GARAN"` veya `"VIP'F_XU0300620"`).
*   `EmirSembol` (string): Sinyal geldiğinde emrin iletileceği sembol (genelde BazSembol ile aynıdır veya vade farkı içerebilir).
*   `Periyot` (string): Grafik periyodu dakika cinsinden (örn. 5 dakika için `"5"`, günlük için `"G"`).
*   `Miktar` (int/double): Sinyal başına gönderilecek lot/kontrat adedi.

---

### 1.2 Manuel Emir Gönderme Parametreleri
Sistem sinyallerine bağlı kalmaksızın, doğrudan kod içinden özel şartlarla emir iletmek için kullanılır. Parametreler set edildikten sonra `Sistem.EmirGonder()` çağrılmalıdır.

```csharp
// Örnek Hisse Alım Emri
Sistem.EmirSembol = "IMKBH'GARAN";
Sistem.EmirIslem = "Alis";            // "Alis" veya "Satis"
Sistem.EmirMiktari = 100;
Sistem.EmirTipi = "Limit";            // Hisse için: "Limit" veya "Piyasa"
Sistem.EmirFiyati = 9.50;
Sistem.EmirSuresi = "GUN";            // "GUN", "KIE" (Kalanı İptal Et)
Sistem.EmirSatisTipi = "";            // Açığa satış için "ACIGA" yazılır
Sistem.EmirGonder();
```

#### VİOP Şartlı Emir Parametreleri (Ekstra Özellikler)
VİOP piyasasında şartlı (tetiklemeli) ve akşam seansı geçerli emirler göndermek için ek parametreler kullanılır:
```csharp
Sistem.EmirSembol = "VIP'F_XU0300620";
Sistem.EmirIslem = "Alis";
Sistem.EmirMiktari = 10;
Sistem.EmirTipi = "Limitli";          // VİOP için limitli emirlerde "Limitli" yazılır
Sistem.EmirFiyati = 132.500;
Sistem.EmirSuresi = "GUN";

// Şart (Tetik) Tanımlamaları
Sistem.EmirSartBool = true;           // Şartlı emri aktif eder
Sistem.EmirSartSembol = "VIP'F_XU0300620";
Sistem.EmirSartFiyat = 132.000;       // Tetik fiyatı
Sistem.EmirSartTipi = "ALIS >= Sart Fiyat"; // "ALIS >= Sart Fiyat", "SATIS <= Sart Fiyat" vb.
Sistem.EmirAksamSeansi = 1;           // Akşam seansında da geçerli olması için 1 (Aktif seanslarda Piyasa emri yasaktır, tavan/tabana limit gönderilir)

Sistem.EmirGonder();
```

---

### 1.3 Zaman ve Saat Fonksiyonları
*   `Sistem.Saat`: Kodun **çalıştığı andaki** bilgisayar/yayın saatini `HH:mm:ss` formatında döner (Grafik bar saati değildir). Zaman kıyaslamaları için C# `CompareTo` metodu kullanılmalıdır:
    ```csharp
    if (Sistem.Saat.CompareTo("17:40:00") >= 0) { /* Saat 17:40 veya sonrası */ }
    ```
*   `Sistem.SaatAraligi("Start", "End")`: Belirli saatler arasında işlem kontrolü sağlar. Boolean değer döner.
    ```csharp
    if (Sistem.SaatAraligi("09:30", "09:50") || Sistem.SaatAraligi("17:50", "18:00"))
    {
        // Bu saat aralıklarında işlem yapma
    }
    ```
*   **Grafik Barlarının Zamanı**: Tarihsel barların saatine erişmek için `Sistem.GrafikVerileri` üzerinden `Date` özelliği okunur:
    ```csharp
    var V = Sistem.GrafikVerileri;
    for (int i = 0; i < V.Count; i++)
    {
        if (V[i].Date.Hour == 18 && V[i].Date.Minute == 05) { /* 18:05 barı */ }
    }
    ```

---

### 1.4 Tablo ve Görsel Arayüz Metotları
Grafik üzerinde veya bağımsız pencerelerde veri tabloları oluşturup güncellemek için kullanılır.

*   `Sistem.Tablo(TabloAd, X, Y, Genislik, Yukseklik, KolonSayisi, SatirSayisi, SutunGenislikler[], SutunHizalamalar[], SutunBasliklar[])`
*   `Sistem.TabloTemizle(TabloAd)`
*   `Sistem.TabloYazdir(TabloAd, KolonIndex, SatirIndex, Metin, YaziRengi, ZeminRengi)`

**Sütun Hizalama Sabitleri:** `0` = Sol, `1` = Orta, `2` = Sağ.

---
---

## BÖLÜM 2: Düşük Seviyeli .NET Sınıfları ve Veri Yapıları

iDeal motorunun (`ideal.exe`) içerisinde tanımlı olan, `Sistem.ViopHesapOku()` veya portföy sorguları tarafından döndürülen gerçek veri nesneleridir.

### 2.1 BIST Hisse Emri Modeli (`ImkbOrderRecord`)
BIST pay piyasasına gönderilen emirlerin tüm detaylarını barındıran veri yapısıdır.

| Alan Adı (Field/Property) | Veri Tipi | Açıklama |
|---------------------------|-----------|----------|
| `OrderNo` / `OrderNoString`| `String`  | Emir numarası |
| `Symbol`                  | `String`  | Hisse kodu (örn: `GARAN`) |
| `BuySell`                 | `String`  | İşlem yönü (`Alış` / `Satış`) |
| `Amount`                  | `Double`  | Gönderilen toplam lot miktarı |
| `GAmount`                 | `Double`  | Gerçekleşen lot miktarı |
| `Balance`                 | `Double`  | Kalan (gerçekleşmeyi bekleyen) lot miktarı |
| `Price`                   | `Double`  | Emrin limit fiyatı |
| `GPrice`                  | `Double`  | Gerçekleşen emirlerin ortalama fiyatı |
| `Total`                   | `Double`  | Toplam emir tutarı (TL) |
| `GTotal`                  | `Double`  | Gerçekleşen emir tutarı (TL) |
| `Status` / `StatusCode`   | `String`  | Emrin durumu (örn: `İletildi`, `Gerçekleşti`, `İptal`) |
| `Session` / `SessionName` | `String`  | Seans bilgisi |
| `OrderDate`               | `DateTime`| Emrin gönderildiği tarih |
| `OrderUpdateDate`         | `DateTime`| Emrin son güncellendiği tarih |
| `OrderRef`                | `String`  | Kullanıcı referans numarası |
| `ZincirRef`               | `String`  | Bağlı olan zincir emrin referansı |
| `SatisTip`                | `String`  | Satış türü (Açığa satış ise `ACIGA`) |
| `AccountName`             | `String`  | Hesap adı |
| `AccountNo`               | `String`  | Hesap numarası |

---

### 2.2 VİOP Emir Modeli (`VipOrderRecord`)
VİOP vadeli işlem ve opsiyon piyasası emir detaylarıdır.

| Alan Adı (Field/Property) | Veri Tipi | Açıklama |
|---------------------------|-----------|----------|
| `OrderNo`                 | `String`  | VİOP borsa emir numarası |
| `Symbol`                  | `String`  | Kontrat kodu (örn: `F_XU0300620`) |
| `BuySell`                 | `String`  | Yön (`Alış` / `Satış`) |
| `Amount` / `EnteredAmount`| `Double`  | Gönderilen sözleşme adedi |
| `GAmount`                 | `Double`  | Gerçekleşen sözleşme adedi |
| `Balance`                 | `Double`  | Kalan sözleşme adedi |
| `Price`                   | `Double`  | Limit fiyatı |
| `GPrice`                  | `Double`  | Gerçekleşen ortalama fiyat |
| `SartTip`                 | `String`  | Tetikleme şartı tipi |
| `SartSembol`              | `String`  | Şartın takip ettiği sembol |
| `SartFiyat`               | `Double`  | Şart tetikleme fiyatı |
| `OrderTime`               | `String`  | Emrin gönderim saati |
| `CancelReason`            | `String`  | Emir iptal edildiyse nedeni |
| `PositionClosing`         | `String`  | Pozisyon kapatma emri mi (`Evet` / `Hayır`) |

---

### 2.3 BIST Pozisyon Modeli (`ImkbPositionRecord`)
Kullanıcının portföyündeki hisse senedi varlıklarının durumunu gösterir.

| Alan Adı (Field/Property) | Veri Tipi | Açıklama |
|---------------------------|-----------|----------|
| `Symbol`                  | `String`  | Sembol adı (örn: `THYAO`) |
| `Lot` / `currentAmount`   | `Double`  | Eldeki toplam lot miktarı |
| `Sellable`                | `Double`  | Satılabilir net lot miktarı |
| `Cost` / `avgPrice`       | `Double`  | Ortalama maliyet fiyatı |
| `LastPrice` / `Price`     | `Double`  | Hisse senedinin son piyasa fiyatı |
| `Bloke`                   | `Double`  | Blokeli lot miktarı |
| `Profit`                  | `Double`  | Net kar/zarar tutarı (TL) |
| `ProfitYuzde`             | `Double`  | Yüzdesel kar/zarar oranı |
| `TotalTL`                 | `Double`  | Pozisyonun güncel toplam TL değeri |
| `balanceT`                | `Double`  | T günündeki bakiye |
| `balanceT1` / `balanceT2` | `Double`  | T+1 ve T+2 valörlü takas bakiyeleri |

---

### 2.4 VİOP Pozisyon Modeli (`VipPositionRecord`)
Kullanıcının VİOP portföyündeki açık pozisyonlarının durumunu gösterir.

| Alan Adı (Field/Property) | Veri Tipi | Açıklama |
|---------------------------|-----------|----------|
| `Symbol`                  | `String`  | Kontrat sembolü (örn: `F_XU0300820`) |
| `BuyAmount`               | `Double`  | Açık Alış (Uzun) kontrat adedi |
| `SellAmount`              | `Double`  | Açık Satış (Kısa) kontrat adedi |
| `NetAmount` / `qty`       | `Double`  | Net pozisyon büyüklüğü (Uzun pozisyonlar pozitif, Kısa pozisyonlar negatif) |
| `Cost` / `avgPrice`       | `Double`  | Ortalama pozisyon açılış maliyeti |
| `LastPrice` / `Price`     | `Double`  | Kontratın son işlem fiyatı |
| `SettlementPrice`         | `Double`  | Gün sonu uzlaşma fiyatı |
| `ProfitAnlik`             | `Double`  | Anlık fiyatlara göre hesaplanan kar/zarar |
| `ProfitFifo`              | `Double`  | FIFO (First-In-First-Out) yöntemine göre gerçekleşen kar/zarar |
| `Direction`               | `String`  | Pozisyon yönü (`L` = Long/Uzun, `S` = Short/Kısa, `F` = Flat/Pozisyonsuz) |

---

### 2.5 Grafik Bar Yapıları

#### Sistem Bar Modeli (`Bar`)
`Sistem.GrafikVerileri` listesinin her bir elemanını temsil eden, indikatör hesaplamalarında kullanılan hafif float tabanlı bar modelidir.
*   `time` (float): Bar zamanı sayısal formatı.
*   `open` (float): Açılış fiyatı.
*   `high` (float): En yüksek fiyat.
*   `low` (float): En düşük fiyat.
*   `close` (float): Kapanış fiyatı.
*   `volume` (float): İşlem hacmi.

#### Detaylı Grafik Bar Modeli (`Getchartdata`)
Grafik çizimlerinde kullanılan yüksek hassasiyetli double ve long tabanlı veri yapısıdır.
*   `ts` (long): Epoch Unix zaman damgası (milisaniye cinsinden bar zamanı).
*   `open` (double): Açılış.
*   `high` (double): Yüksek.
*   `low` (double): Düşük.
*   `close` (double): Kapanış.
*   `volume` (double): Hacim.

---

### 2.6 Ana Portföy Nesnesi (`Portfoy`)
iDeal platformundaki tüm hesap tiplerini ve limitleri tek bir çatı altında toplayan merkezi veri yapısıdır. İçerisinde 80'den fazla alan barındırır. En kritik koleksiyonlar ve limitler şunlardır:

*   **BIST Koleksiyonları**: `ImkbPositionList` (Hisse Pozisyonları), `ImkbOrderList` (Hisse Emirleri).
*   **VİOP Koleksiyonları**: `VipPositionList` (VİOP Pozisyonları), `VipOrderList` (VİOP Bekleyen Emirleri), `VipGerceklesenList` (VİOP Gerçekleşen Emirleri).
*   **Kripto Koleksiyonları**: `CriptoPositionList`, `CriptoOrderList` (Binance/Artiox/Icrypex işlemleri için).
*   **BIST Finansal Limitler**:
    *   `ImkbLimit` (İşlem limiti)
    *   `ImkbOverall` (Toplam portföy değeri)
    *   `ImkbCariBakiye` (Nakit bakiye)
    *   `ImkbKrediDahilLimit` (Kredili satın alma gücü)
*   **VİOP Finansal Limitler**:
    *   `ViopTeminatToplam` (Toplam teminat miktarı)
    *   `ViopTeminatBaslangic` (Başlangıç teminat gereksinimi)
    *   `ViopTeminatSurdurme` (Sürdürme teminatı)
    *   `ViopTeminatKullanilabilir` (Kullanılabilir boş nakit teminat)
    *   `ViopProfitLoss` (Gün içi kar/zarar toplamı)

---

### 2.7 Robot Hesap Durumları

#### BIST Robot Hesap Modeli (`BistRobotHesapClass`)
*   `Pozisyonlar`: `List<ImkbPositionRecord>`
*   `GerceklesenEmirler`: `List<ImkbOrderRecord>`
*   `BekleyenEmirler`: `List<ImkbOrderRecord>`
*   `IslemLimit` (double): Aktif işlem limiti.
*   `Bakiye` (double): Nakit bakiye.

#### VİOP Robot Hesap Modeli (`ViopRobotHesapClass`)
`Sistem.ViopHesapOku()` fonksiyonunun döndürdüğü ana nesnedir.
*   `Pozisyonlar`: `List<VipPositionRecord>`
*   `GerceklesenEmirler`: `List<VipOrderRecord>`
*   `BekleyenEmirler`: `List<VipOrderRecord>`
*   `TeminatToplam` (double): Toplam VİOP teminatı.
*   `TeminatBaslangic` (double): Başlangıç teminatı.
*   `TeminatSurdurme` (double): Sürdürme teminatı.
*   `TeminatKullanilabilir` (double): Kullanılabilir boş teminat (Yeni pozisyon açmak için kullanılabilir nakit).
*   `TeminatCekilebilir` (double): Hesaptan çekilebilecek nakit.
*   `TeminatCagri` (double): Margin Call (Teminat tamamlama çağrısı) tutarı.

---
---

## BÖLÜM 3: Enum Yapıları ve Sayısal Karşılıkları

Yapay zeka modellerinin emir iletirken veya durum kontrolü yaparken doğru tamsayı (integer) değerleri eşleştirebilmesi için gerekli olan enum listeleridir.

### 3.1 Emir Yönü Enum Modeli (`ideal.OrderSide`)
Arka planda borsa API'sine iletilen yön kodlarıdır.

```csharp
Buy = 1,                 // Alış
Sell = 2,                // Satış
BuyMinus = 3,            // Eksi Alış
SellPlus = 4,            // Artı Satış
SellShort = 5,           // Açığa Satış (Short)
SellShortExempt = 6,     // Açığa Satış İstisnası
Cross = 8,               // Karşılıklı İşlem (Kros)
CrossShort = 9,          // Kros Açığa Satış
Lend = 70,               // Ödünç Ver
Borrow = 71              // Ödünç Al
```

### 3.2 Emir Tipi Enum Modeli (`ideal.OrderType`)
```csharp
Market = 1,              // Piyasa Emri (Aktiften)
Limit = 2,               // Limit Fiyatlı Emir
Stop = 3,                // Stop Emri
StopLimit = 4,           // Stop Limitli Emir
MarketOnClose = 5,       // Kapanış Piyasa Emri
LimitOrBetter = 7,       // Limit veya Daha İyi Fiyatlı Emir
OnClose = 65,            // Kapanışta Geçerli
LimitOnClose = 66,       // Kapanış Limitli
Funari = 73,             // Funari Emri (BIST Nasdaq öncesinden kalma)
Pegged = 80              // Pegged (Endekse/Fiyata Dayalı)
```

### 3.3 Emir Durumu Enum Modeli (`ideal.OrderStatus`)
Gelen emir raporlarının durumunu ayrıştırmak için kullanılır.
```csharp
PartiallyFilled = 1,     // Kısmi Gerçekleşti
Filled = 2,              // Tamamı Gerçekleşti (Kapandı)
DoneForDay = 3,          // Günlük İşlem Tamamlandı
Canceled = 4,            // İptal Edildi
Replaced = 5,            // Düzeltildi/Değiştirildi
PendingCancel = 6,       // İptal Bekliyor
Stopped = 7,             // Durduruldu
Rejected = 8,            // Reddedildi
Suspended = 9,           // Askıya Alındı
PendingNew = 65,         // İletilme Aşamasında (Yeni)
Expired = 67,            // Süresi Doldu (İptal Oldu)
PendingReplace = 69      // Düzeltme Bekliyor
```

### 3.4 Emir Geçerlilik Süresi (`ideal.TimeInForce`)
```csharp
GoodTillCancel = 1,      // İptal Edilene Kadar Geçerli (İEKG)
ImmediateOrCancel = 3,   // Kalanı İptal Et (KİE / FAK)
FillOrKill = 4,          // Gerçekleşmezse İptal Et (GİE / FOK)
GoodTillDate = 6,        // Tarihli Emir (Süre Sonuna Kadar)
AtCrossing = 9,          // Eşleşme Seansında Geçerli
GoodTillEndOfSession = 83 // Seans Sonuna Kadar Geçerli
```

### 3.5 Robot / Algoritma Türleri (`IDealOrderType` ve `AlgoTypes`)
iDeal platformundaki farklı trading bot sınıflarıdır.

**`IDealOrderType`:**
*   `Robot = 1` (Standart Grafik Robotu)
*   `iDealGo = 2` (Gelişmiş Strateji Modülü)
*   `TaramaRobot = 3` (Çoklu Sembol Tarayıcı)
*   `RoboTrade = 4` / `OtoTrade = 5`
*   `GridBot = 6` (Izgara Ticaret Botu)
*   `TrendBot = 7` / `YatayBot = 8`
*   `Arbitraj = 10` (Fiyat Farkı Arbitraj Botu)
*   `ExecutionAlgo = 13` (Kurumsal Emir Uygulama Algoritması)

**`ideal.AlgoTypes`:**
*   `VWAP = 2` (Hacim Ağırlıklı Ortalama Fiyat Algoritması)
*   `HCM = 3`
*   `POV = 4` / `POV2 = 5` (Hacim Katılım Oranı Algoritmaları)
*   `ICEBERG = 6` (Buzdağı Emir Algoritması)
*   `ARBITRAJ = 7` (Arbitraj İşlemleri)

---
---

## BÖLÜM 4: Ağ ve Protokol Yapısı (FIX Eşleşmesi)

iDeal platformunun aracı kurumlara ve borsaya emir gönderirken kullandığı içsel FIX Protokolü parametreleri ve tag eşleşmeleridir.

### 4.1 FIX Tag ve `ideal.MessageField` Karşılıkları
iDeal, FIX protokol yapısını `MessageField` enumu üzerinden yönetir:

| Tag | Enum Adı | Karşılık Gelen Değer |
|-----|----------|----------------------|
| **4** | `Type` | `MessageType` (Giriş, Emir İletim, Çıkış vb.) |
| **11** | `Id` / `OrderId` | Tekil emir ID'si |
| **12** | `Symbol` | Sembol kodu |
| **13** | `Quantity` | Lot miktarı |
| **14** | `OrderType` | `OrderType` enum değeri |
| **15** | `OrderSide` | `OrderSide` enum değeri |
| **16** | `TimeInForce` | Geçerlilik süresi kodu |
| **18** | `Account` | Aracı kurum hesap numarası |
| **19** | `Price` | Limit fiyatı |
| **22** | `OrderStatus` | `OrderStatus` enum değeri |
| **24** | `RejectReason`| Reddedilme nedeni metni |
| **25** | `Message` | Sunucudan dönen hata/bilgi mesajı |
| **26** | `Success` | İşlemin başarı durumu (True/False) |

---

### 4.2 API Emir Gönderme İstek Nesneleri

#### BIST Hisse Emir İsteği (`ReqEquitySendOrder`)
Doğrudan soket üzerinden hisse emri gönderirken serileştirilen veri paketidir:
```csharp
class ReqEquitySendOrder {
    string appCode;              // Uygulama kodu
    string appPassword;          // Uygulama şifresi
    string accountId;            // Hesap ID
    string clOrdId;              // Müşteri emir referansı
    string instrumentSymbol;     // Hisse sembolü (örn. GARAN)
    string uniqueSymbol;         // Benzersiz borsa sembol kodu
    int instrumentType;          // Enstrüman tipi (Hisse = 1)
    double qty;                  // Lot miktarı
    double price;                // Fiyat
    int sideId;                  // Yön (OrderSide)
    int orderTypeId;             // Emir Tipi (OrderType)
    int timeInForceId;           // Geçerlilik Süresi (TimeInForce)
    string token;                // Oturum anahtarı
    double maxFloor;             // Maksimum görünecek lot (Buzdağı için)
}
```

#### VİOP Emir İsteği (`VipSendOrderReq`)
Soket üzerinden VİOP emri iletme veri paketidir:
```csharp
class VipSendOrderReq {
    string sozlesme;             // VİOP Kontrat kodu (örn. F_XU0301020)
    string islem;                // "Alis" veya "Satis"
    double miktar;               // Kontrat adedi
    double fiyat;                // Fiyat
    string orderType;            // Emir tipi ("Limitli", "Piyasa" vb.)
    string sure;                 // Süre tipi ("GUN", "KIE" vb.)
    double gorunenMiktar;        // Varsa gizli emir için görünen kısım
    bool aksamSeansi;            // Akşam seansı katılımı (True/False)
    bool smsGonderimi;           // İşlem tamamlandığında SMS bildirimi
}
```
