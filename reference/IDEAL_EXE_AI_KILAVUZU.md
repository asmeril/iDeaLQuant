# iDeal / ideal.exe — Yapay Zeka Uyumlu Teknik Kılavuz

Bu dosya, iDeal içinde çalışan robotlar, sorgular, dashboard formları ve yardımcı scriptler için hem dokümante edilen hem de çalışma sırasında fiilen tespit edilen davranışları özetler.

Amaç:
- Bir yapay zeka modelinin iDeal ortamını doğru zihinsel modelle anlaması
- Kod üretirken yanlış varsayım yapmaması
- Gerçek hesap, yazılımsal pozisyon, canlı fiyat, grafik verisi ve UI otomasyonu arasındaki farkı bilmesi

---

## 1) Hızlı makine özeti

Yapay zeka için kısa durum kartı:

- Platform tipi: Windows masaüstü terminali
- Çalışma modeli: ideal.exe içi gömülü script host
- Dil: C# benzeri script dili
- UI desteği: WinForms kullanılabiliyor
- Kod çalışma yeri: çoğu kritik nesne yalnızca ideal.exe süreci içinde güvenilir
- Metin kodlaması: Türkçe içerik için cp1254 sık kullanılıyor
- Sayı formatı: Türkçe sayı ayracı sorun çıkarabilir
- Emir modeli: Özellikleri set et, sonra EmirGonder çağır
- Robot içi state: NesneKaydet / NesneGetir ve PozisyonKontrol mekanizması ile tutulur
- Gerçek hesap verisi: ViopHesapOku / BistHesapOku
- Robot mantıksal pozisyonu: PozisyonKontrolOku / PozisyonKontrolGuncelle

---

## 2) iDeal çalışma mantığı

### 2.1 Script host gerçeği
- Kodlar doğrudan ideal.exe içinde çalışır.
- Normal C#'a benzer ama tam .NET proje yapısı beklenmemelidir.
- Local lambda, Action ve Func kullanımı mümkündür.
- WinForms bileşenleri üretilebildiği için form, panel, buton, DataGridView tabanlı dashboard yapılabilir.

### 2.2 Çok önemli pratik sonuç
- Dışarıdan PowerShell veya ayrı bir süreç ile iDeal içindeki statik state, RoboTradeClass listeleri ve bazı WinForms kontrolleri güvenilir okunamaz.
- Güvenilir yöntem: Kodu ideal.exe içinde çalıştır, sonucu dosyaya yaz, sonra dış araçla oku.

---

## 3) Resmî olarak görülen ana API aileleri

### 3.1 Grafik verisi
Kullanım amacı: geçmiş bar verisi, teknik analiz, tarama, multi-timeframe kontrol

Başlıca fonksiyonlar:
- Sistem.GrafikVerileri
- Sistem.GrafikVerileriniOku(sembol, periyot)
- Sistem.GrafikFiyatSec(deger)
- Sistem.GrafikFiyatOku(veri, alan)

Örnek sembol/periyot tipleri:
- IMKBH'GARAN
- IMKBX'XU100
- VIP'VIP-X030
- VIP'VIP-X030-T
- FX'USDTRY

Sık görülen periyotlar:
- G = günlük
- H = haftalık
- A = aylık
- Y = yıllık
- 5, 15, 60, 240 = dakika bazlı

### 3.2 Canlı fiyat ve yüzeysel veri
Kullanım amacı: son fiyat, bid/ask, bazı hızlı alanlar

Başlıca fonksiyon:
- Sistem.YuzeyselVeriOku(sembol)

Sık kullanılan alanlar:
- LastPrice
- BidPriceDec
- AskPriceDec
- bazı özel alanlar: FI182 gibi veri kolonları

### 3.3 Hesap ve portföy verisi
Kullanım amacı: gerçek VIOP hesabı, teminat, pozisyonlar, bekleyen ve gerçekleşen emirler

Başlıca fonksiyonlar:
- Sistem.ViopHesapOku()
- Sistem.BistHesapOku()
- Sistem.HesapKurum()

ViopHesapOku ile alınabilen tipik yapılar:
- TeminatToplam
- TeminatBaslangic
- TeminatSurdurme
- TeminatKullanilabilir
- TeminatCekilebilir
- Pozisyonlar
- BekleyenEmirler
- GerceklesenEmirler

### 3.4 Yazılımsal pozisyon kontrolü
Kullanım amacı: robotun kendi tuttuğu mantıksal pozisyonu ve maliyeti

Başlıca fonksiyonlar:
- Sistem.PozisyonKontrolOku(anahtar)
- Sistem.PozisyonKontrolOku(anahtar, out islemFiyat, out islemTarih)
- Sistem.PozisyonKontrolOku(anahtar, out islemFiyat, out islemTarih, out rezerv)
- Sistem.PozisyonKontrolGuncelle(...)

Kritik ayrım:
- ViopHesapOku = gerçek hesap durumu
- PozisyonKontrolOku = robotun yazılımsal sayacı

### 3.5 Emir gönderme modeli
Tipik akış:
1. Emir alanlarını doldur
2. Emir tipini ve yönünü belirle
3. Sistem.EmirGonder çağır
4. Başarılı kabul edilen mantıkta PozisyonKontrolGuncelle ile robot state'ini güncelle

Sık set edilen alanlar:
- Sistem.EmirSembol
- Sistem.EmirIslem
- Sistem.EmirTipi
- Sistem.EmirMiktari
- Sistem.EmirFiyati
- Sistem.EmirSuresi
- Sistem.EmirHesapAdi
- Sistem.EmirAltHesap
- Sistem.EmirAciklama
- Sistem.EmirAksamSeansi

### 3.6 Kalıcı state ve zaman kilidi
Kullanım amacı: günde bir kez çalışma, spam önleme, tarama penceresi kontrolü

Başlıca fonksiyonlar:
- Sistem.NesneKaydet(key, value)
- Sistem.NesneGetir(key)

Bu yapı günlük scanner, telegram throttling ve “aynı gün tekrar çalışmasın” mantığında etkilidir.

---

## 4) Keşfedilmiş ve pratikte doğrulanmış davranışlar

### 4.1 Türkçe sayı formatı kritik risk alanıdır
Gerçek ortamda şu problemler görüldü:
- binlik ayraç nokta
- ondalık ayraç virgül
- bazı gridlerde karışık biçim: 16080,0000 veya 16.080,0000
- yanlış parse sonucu x10, x100, x10000 ölçek kayması oluşabilir

Yapay zeka için kural:
- Sayıları culture varsayımı ile doğrudan parse etme
- Son ayıracı ondalık kabul eden normalize katmanı yaz
- Görsel çıktıda formatı açıkça zorla

Öneri:
- girişte normalize et
- çıkışta TR biçimi üret
- pozisyon adetlerini tam sayıya yuvarla

### 4.2 Lambda deklarasyon sırası önemlidir
Script host içinde bazı durumlarda lambda değişkenleri local değişken gibi derlenir.
Bu nedenle bir Func veya Action kullanılmadan önce tanımlanmış olmalıdır.

Görülen hata tipi:
- CS0841 benzeri “declaration before use” hatası

Kural:
- Önce null ile deklarasyon yap
- Sonra gövdeyi ata

### 4.3 YuzeyselVeriOku bazı VIOP sembollerinde yetersiz kalabilir
Pratik gözlem:
- Hisse sembollerinde LastPrice çoğu zaman yeterli
- Bazı VIOP futures veya akşam seansı sembollerinde LastPrice beklenen değeri vermeyebilir veya 0 gelebilir

Kural:
- Öncelik: YuzeyselVeriOku(symbol).LastPrice
- Fallback: Sistem.SonFiyat(symbol)
- Gerekirse portföy gridindeki gerçek son fiyat kolonundan tekrar doğrula

### 4.4 Gerçekleşme fiyatı için doğru kaynak seçimi önemlidir
Robot maliyeti okunurken iki farklı dünya vardır:
- robotun kendi PozisyonKontrol sayacı içindeki gerçekleşme fiyatı
- kurum/VIOP portföy gridindeki uzlaşma veya başka kolonlar

Kural:
- Robot satırı maliyeti için öncelik PozisyonKontrolOku out islemFiyat
- Gerçek hesap K/Z için öncelik ViopHesapOku veya portföy özet paneli
- Uzlaşma fiyatını yanlışlıkla robot maliyetinin üstüne yazmak satır K/Z’yi bozar

### 4.5 Peak ve DD değerleri dosya state’inden bozulabilir
Eğer eski dönemde yanlış parse edilen devasa rakam state dosyasına yazıldıysa,
sonraki çalışmalarda Peak ve DD anlamsız büyüklükte kalabilir.

Kural:
- Peak yüklenirken anomali filtresi koy
- Elle sıfırlama butonu ekle
- State dosyasının bozulabileceğini varsay

### 4.6 Gün içi günlük bar mantığına dikkat
Günlük periyotla çalışan scanner robotlarında sabah veya öğlen saatinde yapılan değerlendirme, beklenen kadar “intraday akıllı” olmayabilir.

Pratik sonuç:
- Günlük bar tabanlı model, gün kapanmadan çoğu zaman önceki gün yapısını taşıyarak skor verir
- Gerçek intraday davranış isteniyorsa 5/15/60 dakikalık veri ayrı okunmalıdır

### 4.7 UI otomasyonu mümkün ama kırılgandır
Doğrulanan durumlar:
- Application.OpenForms ile form bulunabilir
- Form içindeki DataGridView nesneleri dolaşılabilir
- Kolon adları Name veya HeaderText üzerinden eşlenebilir

Riskler:
- Türkçe karakter farkı
- kolon adının sürüme göre değişmesi
- aynı formda birden fazla grid olması

Kural:
- tek isme güvenme
- alias listesi kullan
- kolon puanlama veya içerik puanlama yap

---

## 5) Yapay zeka için önerilen veri öncelik matrisi

| İhtiyaç | 1. Kaynak | 2. Kaynak | 3. Kaynak |
|---|---|---|---|
| Canlı son fiyat | YuzeyselVeriOku.LastPrice | SonFiyat | Portföy grid son fiyat kolonu |
| Robot maliyeti | PozisyonKontrolOku out IslemFiyat | robot grid maliyet hücresi | son çare manuel fallback |
| Gerçek VIOP toplam K/Z | ViopHesap özet alanları | portföy summary grid | satır bazında toplama |
| Robot içi pozisyon | PozisyonKontrolOku | robot grid | dosya state |
| Günlük tek çalıştırma | NesneGetir / NesneKaydet | dosya kilidi | zaman filtresi |
| Emir sonrası state | PozisyonKontrolGuncelle | log dosyası | kurumdan tekrar okuma |

---

## 6) iDeal için güvenli kod üretim ilkeleri

Bir yapay zeka modeli iDeal için kod yazarken şu kuralları izlemelidir:

1. Önce null ve count kontrollerini yap
2. Her kritik blokta try/catch kullan
3. Canlı emir ve dry-run modunu ayır
4. Pozisyonları özellikle VIOP tarafında tam sayı kabul et
5. Sayı parse ve formatını açıkça yönet
6. Sembol adlarını normalize et
7. Aynı kaynağa kör güvenme, fallback zinciri kur
8. Sonuçları mutlaka log dosyasına yaz
9. UI grid kolonlarını esnek alias mantığı ile bul
10. Gerçek hesap ile robot state’ini birbirine karıştırma

---

## 7) Sembol ve adlandırma kuralları

Sık görülen piyasa önekleri:
- IMKBH' = hisse
- IMKBX' = endeks
- VIP'VIP- = VIOP
- FX' = döviz/forex

Pratik normalizasyon ihtiyacı:
- VIP'VIP-X030-T
- VIP-X030-T
- X030T
- XU030

Bu tip isimler farklı ekranlarda farklı biçimde gelebilir.
Yapay zeka kodu şu tip temizlikler uygulamalıdır:
- üst harfe çevir
- tire, alt çizgi, tek tırnak ve nokta farklarını normalize et
- gerekli ise vade sonu rakamlarını temizle

---

## 8) UI / dashboard tarafında doğrulanan imkanlar

İdeal içinde WinForms tabanlı özel panel yapılabilir:
- Form
- Panel
- Label
- Button
- CheckBox
- Timer
- DataGridView

Bu sayede:
- portföy monitörü
- kill switch paneli
- performans ekranı
- canlı tarama dashboardu
oluşturmak mümkündür.

Kullanışlı pratikler:
- tekrar açılmayı engellemek için Application.OpenForms taraması
- grid satırlarını doldurmadan önce Rows.Clear
- Timer ile periyodik yenileme
- form kapandığında timer dispose etme

---

## 9) Gelişmiş / yarı gizli bulgular

Bu başlık resmî dokümantasyon dışında pratik ve tersine analiz bulgularını içerir.

### 9.1 Dış süreçten okuma sınırı
- iDeal içindeki WinForms kontrolleri ve static listeler dış PowerShell sürecinden her zaman güvenilir görünmez.
- Sağlam çözüm: iDeal içinde reflection veya dump script çalıştırıp CSV/TXT/JSON benzeri çıktı bırakmak.

### 9.2 Disk cache export yaklaşımı mümkün
- iDeal disk cache verileri dışarı aktarılabilir.
- Bar verileri OHLCV olarak export edilip Python tarafında tekrar analiz edilebilir.
- Türkçe Windows ortamında dosya encoding ve sayı parse konusu ayrıca ele alınmalıdır.

### 9.3 Yapı layout bilgileri
- Bazı iç veri yapılarının sabit byte yerleşimi tespit edilebiliyor.
- Örnek pratik not: IslemStruct1 için 35 byte layout teyidi yapılmıştı.
- Ancak bu tür bulgular sürüm bağımlıdır; üretim kodunda kör güvenle kullanılmamalıdır.

---

## 10) Sık yapılan hatalar

- Gerçek hesap yerine sadece PozisyonKontrol sayacına güvenmek
- Uzlaşma fiyatını canlı son fiyat sanmak
- Türkçe sayı biçimini yanlış parse etmek
- Hisse ve VIOP sembol formatlarını aynı sanmak
- Günlük bar ile intraday mantığı karıştırmak
- Dış süreçten iDeal iç state’ini tam okuyabileceğini varsaymak
- Telegram token veya kurum bilgilerini koda gömmek

---

## 11) Yapay zeka için prompt şablonu

Aşağıdaki yaklaşım iDeal kodu üretirken uygundur:

- Ortam: iDeal içi C# benzeri script host
- Hedef: güvenli, savunmacı, fallback’li robot veya dashboard kodu
- Kısıtlar:
  - null kontrolü zorunlu
  - try/catch zorunlu
  - Türkçe sayı formatı desteklenmeli
  - gerçek hesap ve yazılımsal pozisyon ayrıştırılmalı
  - sembol normalize edilmeli
  - dosya log’u bırakılmalı
  - canlı emir için dry-run seçeneği olmalı

İstenen çıktı türleri:
- Robot
- Sorgu
- Dashboard formu
- Pozisyon takip aracı
- Tarama motoru
- Veri export scripti

---

## 12) Bu workspace içindeki iyi referanslar

İncelenebilecek örnekler:
- [Robots/Robot_PreMove_Scanner.txt](Robots/Robot_PreMove_Scanner.txt)
- [Robots/PortfoyYonetimDashboard_v1.txt](Robots/PortfoyYonetimDashboard_v1.txt)
- [ideal-portfoy-kontrol-paneli/docs/STRATEJI_ROBOTU_TEMPLATE_v4_FINAL.cs](ideal-portfoy-kontrol-paneli/docs/STRATEJI_ROBOTU_TEMPLATE_v4_FINAL.cs)
- [IdealQuant/reference/Robot_VIOP_Pozisyon_Takip.txt](IdealQuant/reference/Robot_VIOP_Pozisyon_Takip.txt)

---

## 13) Son karar özeti

Bir yapay zekanın iDeal için doğru kod yazabilmesi için şu temel ayrımı bilmesi şarttır:

- Grafik verisi başka şeydir
- Canlı yüzeysel veri başka şeydir
- Gerçek kurum hesabı başka şeydir
- Robotun yazılımsal pozisyon sayacı başka şeydir
- UI gridde görünen değerler bazen doğrudan API ile birebir örtüşmeyebilir

Bu yüzden iDeal kodu tek kaynaklı değil, çok kaynaklı ve fallback’li yazılmalıdır.

---

## 14) Güncelleme notu

Bu kılavuz, workspace içindeki robot dosyaları, dashboard denemeleri, scanner çalışmaları ve iDeal kullanım notları üzerinden derlenmiştir. Yeni keşifler oldukça genişletilmelidir.
