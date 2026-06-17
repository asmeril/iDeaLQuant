# iDeal Platform — Sistem API Referansı (Özet)

## Kaynak
- PDF: `D:/Projects/IdealQuant/reference/iDeal_SistemGenel.pdf` (211 sayfa, Sezai Kılıç)
- Full text: `D:/Projects/IdealQuant/reference/ideal_docs/ideal_sistem_genel_FULL.txt`

## Platform Yapısı
- C# bazlı formül yazma sistemi
- 4 kullanım modu: **Sistem** (grafik), **Robot** (otomatik emir), **Sorgu** (tarama), **Optimizasyon**
- Robotlar Portföy penceresindeki ROBOT sekmesinden çalışır (SANAL veya GERÇEK mod)

## Emir Fonksiyonları (p.63-65)

### Tüm Piyasalar (Hisse/Varant/VİOP):
```csharp
Sistem.EmirSembol = "IMKBH'GARAN";     // Piyasa kodu + sembol
Sistem.EmirIslem = "Alış";              // veya "SATIS" / "Satış"
Sistem.EmirMiktari = 1;                 // Lot miktarı
Sistem.EmirTipi = "Limit";             // veya "Piyasa"
Sistem.EmirFiyati = 9.50;              // Sadece Limit emirler için
Sistem.EmirSuresi = "GUN";             // GUN, SNS, IKG, KIE
Sistem.EmirAltHesap = "1";             // Opsiyonel
Sistem.EmirHesapAdi = "123456, ABC YATIRIM"; // Opsiyonel
Sistem.EmirSatisTipi = "ACIGA";        // Açığa satış için
Sistem.EmirGonder();                    // EMRİ GÖNDER
```

### Sadece VİOP:
```csharp
Sistem.EmirAksamSeansi = 1;            // Akşam seansında geçerli
Sistem.EmirSartBool = true;            // Şartlı emir
Sistem.EmirSartSembol = "VIP'F_XU0300620";
Sistem.EmirSartFiyat = 132.500;
Sistem.EmirSartTipi = "ALIŞ >= Şart Fiyat";
```

### Önemli Notlar:
- Piyasa emirlerinde süre = **KIE** olmalı
- Piyasa emrinde EmirFiyati gereksiz
- Hisse: EmirTipi = "Limit", VİOP: EmirTipi = "**Limitli**"
- Sembol yazımı: `"IMKBH'GARAN"` veya `"VIP'F_XU0300620"`
- VİOP akşam seansında piyasa emri yasak → Limitli olarak TAVAN/TABAN'a gönderilir

### Emir Süresi Kodları:
- **KIE**: Kalanı İptal Et (piyasa emri için)
- **GUN**: Gün sonuna kadar
- **SNS**: Seans sonuna kadar
- **IKG**: İptal edilene kadar geçerli

## Robot Fonksiyonları (p.149-151)

### Tek Satırlık Robotlar:
```csharp
// Hisse - Açığa satış VAR
Sistem.RobotHisseAktifAcigaVar(SistemAdi, BazSembol, EmirSembol, Periyot, Miktar);

// Hisse - Açığa satış YOK
Sistem.RobotHisseAktifAcigaYok(SistemAdi, BazSembol, EmirSembol, Periyot, Miktar);

// VİOP - Piyasa Emri
Sistem.RobotViopAktif(SistemAdi, BazSembol, EmirSembol, Periyot, Miktar);

// VİOP - Akşam seansı dahil
Sistem.RobotViopAktifTumGun(SistemAdi, BazSembol, EmirSembol, Periyot, Miktar);

// VİOP - Gün sonu pozisyon kapat
Sistem.RobotViopGunSonuKapat(SistemAdi, EmirSembol);

// Tüm robotları durdur
Sistem.RobotStop();
```

### Robot Kalıp Kodu (p.14-16):
```csharp
var LotSize = 1;
var SistemAdi = "xxxx";
var GrafikSembolu = "IMKBH'DOHOL";
var GrafikPeriyodu = "60";
var EmirSembol = "IMKBH'DOHOL";

var MySistem = Sistem.SistemGetir(SistemAdi, GrafikSembolu, GrafikPeriyodu);
var SonFiyat = Sistem.SonFiyat(EmirSembol);
var Anahtar = Sistem.Name + "," + EmirSembol;
double IslemFiyat = 0;
DateTime IslemTarih;
var Miktar = 0.0;
var Rezerv = "";
var Pozisyon = Sistem.PozisyonKontrolOku(Anahtar, out IslemFiyat, out IslemTarih);

var SonYon = Sistem.SonYonGetir(SistemAdi, GrafikSembolu, GrafikPeriyodu);

if (SonYon == "F" && Pozisyon != 0)      Miktar = -Pozisyon;      // Flat
else if (SonYon == "A" && Pozisyon != LotSize)  Miktar = LotSize - Pozisyon;  // Al
else if (SonYon == "S" && Pozisyon != -LotSize) Miktar = -LotSize - Pozisyon; // Sat

// Emir gönder...
```

## Pozisyon Yönetimi (p.131-133)

```csharp
// Pozisyon durumu oku
var Anahtar = Sistem.Name + "," + Sembol;
double IslemFiyati = 0;
DateTime IslemTarih;
var Rezerv = "";
var Pozisyon = Sistem.PozisyonKontrolOku(Anahtar, out IslemFiyati, out IslemTarih, out Rezerv);

// Pozisyon güncelle
Sistem.PozisyonKontrolGuncelle(Anahtar, YeniPozisyon, Fiyat, Aciklama);
```

## State Yönetimi (p.148-149)

```csharp
// Sayı tablosu (kalıcı sayısal veri)
Sistem.SayiTablosunuGuncelle("AnahtarAdi", 123.45);
double deger = Sistem.SayiTablosunuOku("AnahtarAdi");

// Sözcük tablosu (kalıcı metin veri)  
Sistem.SozcukTablosunuGuncelle("AnahtarAdi", "MerhaBa");
string metin = Sistem.SozcukTablosunuOku("AnahtarAdi");
```

## VİOP Hesap Okuma (p.194-197)

```csharp
var ViopHesap = Sistem.ViopHesapOku();
if (ViopHesap != null)
{
    // Teminatlar
    ViopHesap.TeminatToplam;
    ViopHesap.TeminatBaslangic;
    ViopHesap.TeminatSurdurme;
    ViopHesap.TeminatKullanilabilir;
    ViopHesap.TeminatCekilebilir;
    
    // Pozisyonlar
    var PozList = ViopHesap.Pozisyonlar;
    PozList[i].Symbol;
    PozList[i].NetAmount;
    PozList[i].ProfitAnlik;  // anlık fiyata göre KZ
    PozList[i].Profit;       // uzlaşıya göre KZ
    
    // Gerçekleşen Emirler
    var GerceklesenList = ViopHesap.GerceklesenEmirler;
    GerceklesenList[i].OrderNo;
    GerceklesenList[i].OrderDate;
    GerceklesenList[i].Symbol;
    GerceklesenList[i].BuySell;
    GerceklesenList[i].Session;
    GerceklesenList[i].OrderType;
    GerceklesenList[i].Price;
    GerceklesenList[i].Status;
    GerceklesenList[i].GAmount;
    
    // Bekleyen Emirler
    var BekleyenList = ViopHesap.BekleyenEmirler;
    // Aynı alanlar...
}
```

## Hisse Hesap Okuma (p.35-37)

```csharp
var BistHesap = Sistem.BistHesapOku();
BistHesap.IslemLimit;
BistHesap.Bakiye;
BistHesap.Pozisyonlar;      // Liste
BistHesap.BekleyenEmirler;   // Liste
BistHesap.GerceklesenEmirler; // Liste

// Pozisyon detayları
PozList[i].Symbol;
PozList[i].Lot;
PozList[i].Cost;
PozList[i].Profit;
PozList[i].LastPrice;
```

## Gerçek Zamanlı Veri Fonksiyonları

```csharp
Sistem.SonFiyat(Sembol);          // Son işlem fiyatı
Sistem.AlisFiyat(Sembol);         // En iyi alış fiyatı
Sistem.SatisFiyat(Sembol);        // En iyi satış fiyatı
Sistem.AlisLot(Sembol);           // En iyi alıştaki lot
Sistem.SatisLot(Sembol);          // En iyi satıştaki lot
Sistem.SonHacim(Sembol);          // Son hacim
Sistem.SonLot(Sembol);            // Son lot
Sistem.Hacim(Sembol);             // Toplam hacim
Sistem.Lot(Sembol);               // Toplam lot
Sistem.Fark(Sembol);              // Fark
Sistem.Yuzde(Sembol);             // Yüzde değişim
Sistem.OncekiKapanis(Sembol);     // Önceki kapanış
Sistem.Tavan(Sembol);             // Tavan fiyat
Sistem.Taban(Sembol);             // Taban fiyat
Sistem.Yuksek(Sembol);            // Günün yükseği
Sistem.Dusuk(Sembol);             // Günün düşüğü
```

## Derinlik & Kademe Verisi

```csharp
// Kademe Analizi (Alış-Satış Baskısı)
var Kademeler = Sistem.KademeAnalizOku(Sembol);
Kademeler.AlisLot;
Kademeler.SatisLot;
Kademeler.AlisAdet;
Kademeler.SatisAdet;

// Derinlik Verisi (Emir Defteri)
var Derinlik = Sistem.DerinlikVerisiOku(Sembol);
// 5 kademe alış-satış fiyat ve lot bilgisi
```

## Grafik Verisi

```csharp
// Mevcut grafik
var Veriler = Sistem.GrafikVerileri;
var Kapanislar = Sistem.GrafikFiyatSec("Kapanis");

// Farklı sembol veya periyot
var Veriler2 = Sistem.GrafikVerileriniOku("IMKBH'GARAN", "60");
var Kapanislar2 = Sistem.GrafikFiyatOku(Veriler2, "Kapanis");

// Bar verisi erişimi
Veriler[i].Open, .High, .Low, .Close, .Vol, .Date
```

## Zaman Kontrol Fonksiyonları

```csharp
Sistem.Saat;                                    // Anlık saat
Sistem.SaatAraligi("09:30", "17:40");          // Saat aralığı kontrolü
Sistem.TarihAraligi("2024.01.01", "2024.12.31"); // Tarih aralığı
Sistem.ZamanKontrolSaniye(Anahtar);            // Son çalışmadan kaç saniye geçti
Sistem.ZamanKontrolGuncelle(Anahtar);          // Zamanlayıcıyı sıfırla
Sistem.HaftaSonu;                               // Hafta sonu mu?
```

## Önemli Sembol Kodları (VİOP)

```
Aktif endeks kontratı: Sistem.AktifViopKontrat
Hisse futures: "VIP'F_GARAN0426"  (GARAN Nisan 2026)
Endeks futures: "VIP'F_XU0300426"
Döviz futures: "VIP'F_USDTRY0426"
Opsiyon: "VIP'O_GARANEP426C650"  (GARAN Call Put Nisan strike 650)
Hisse: "IMKBH'GARAN"
Endeks: "IMKBX'XU100"
```

## Tablo Fonksiyonları (UI)

```csharp
Sistem.Tablo(TabloAd, X, Y, Width, Height, SutunSayisi, SatirSayisi, GenislikArray, HizalaArray, BaslikArray);
Sistem.TabloTemizle(TabloAd);
Sistem.TabloYazdir(TabloAd, Sutun, Satir, Metin, YaziRenk, ZeminRenk);
```

## İndikatörler (100+)

MA, RSI, MACD, Bollinger, ATR, ADX, Stochastic, CCI, Ichimoku, SuperTrend, 
Parabolic SAR, ZigZag, Alligator, Aroon, Vortex, TOMA, Fibonacci, vb.

Tüm indikatörler 3 kullanım formu destekler:
1. `Sistem.RSI(14)` — mevcut grafik kapanış
2. `Sistem.RSI(Liste, 14)` — özel liste
3. `Sistem.RSI(Veriler, 14)` — farklı grafik verisi
