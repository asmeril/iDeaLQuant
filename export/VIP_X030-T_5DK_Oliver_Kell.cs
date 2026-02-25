// ===============================================================================================
// STRATEJI 5: Oliver Kell — Base 'n Break
// 2020 US Investing Championship Şampiyonu
// Mod: VIOP Endeks Vadeli — Çift Yön
// Otomatik: IdealQuant Export | Tarih: 2026-02-25 23:06
// ===============================================================================================

// Vadeli Endeks (VIP-X030 vb.): Çift Yönlü + Vade Geçişi
string YON = "CIFT";


// === PARAMETRELER ===
int EMA_Fast_P = 8;
int EMA_Slow_P = 55;
int Breakout_P = 17;
int ADX_P = 18;
float ADX_Threshold = 22.0f;
int VolMA_P = 20;
float TrailingStopPct = 1.5f;

// === GRAFİK BİLGİSİ ===
var Grafikler = Sistem.GrafikVerileri;
var O = Sistem.GrafikFiyatSec("Acilis");
var H = Sistem.GrafikFiyatSec("Yuksek");
var L = Sistem.GrafikFiyatSec("Dusuk");
var C = Sistem.GrafikFiyatSec("Kapanis");
var T = Sistem.GrafikFiyatSec("Tipik");
var V = Sistem.GrafikVerileri;

// Hacim Dizisi Oluştur
var VolumeArray = Sistem.Liste(0);
for (int i = 0; i < V.Count; i++)
{
    VolumeArray[i] = V[i].Vol; // iDeal Data'da Hacim/Lot verisi bar objesindedir
}

// === İNDİKATÖRLER ===
var EMA_Fast = Sistem.EMA(C, EMA_Fast_P);
var EMA_Slow = Sistem.EMA(C, EMA_Slow_P);
var ADX_Val = Sistem.ADX(H, L, C, ADX_P);
var HH = Sistem.HHV(H, Breakout_P);
var LL = Sistem.LLV(L, Breakout_P);

// Hacim Ortalaması (SMA)
var VolMA = Sistem.SMA(VolumeArray, VolMA_P);

// === STRATEJI MANTIGI ===
float iz_yuzde = TrailingStopPct / 100.0f;
float ucUcMesafe = 0f;
float stopSeviyesi = 0f;
int pozisyon = 0; // 0=F, 1=A, -1=S

// Hacim varsa kullan, yoksa sürekli true (Sistem.Lot boşsa sinyali kesmesin)
bool hacimAktif = true;
if (VolMA[Math.Min(100, VolMA.Count - 1)] <= 0 && VolMA[VolMA.Count - 1] <= 0) hacimAktif = false;

for (int i = Math.Max(EMA_Slow_P, Math.Max(ADX_P, Math.Max(Breakout_P, VolMA_P))) + 2; i < Grafikler.Count; i++)
{
    if (Sistem.Yon[i] != "") continue; // Zaten sinyal var
    
    // Güvenlik kontrolü
    if (i >= EMA_Fast.Count || i >= EMA_Slow.Count || i >= ADX_Val.Count || i >= HH.Count || i >= LL.Count || i >= VolMA.Count) continue;

    // --- LONG KOSULLARI ---
    bool longTrend = C[i] > EMA_Fast[i] && C[i] > EMA_Slow[i];
    bool longBreak = C[i] > HH[i - 1]; // Close, bir önceki barın HH'sini kırıyor mu?
    bool longADX   = ADX_Val[i] >= ADX_Threshold && EMA_Fast[i] >= EMA_Fast[i - 1];
    bool gucluHacim = hacimAktif ? (VolumeArray[i] > VolMA[i]) : true;

    // --- SHORT KOSULLARI ---
    bool shortTrend = C[i] < EMA_Fast[i] && C[i] < EMA_Slow[i];
    bool shortBreak = C[i] < LL[i - 1];
    bool shortADX   = ADX_Val[i] >= ADX_Threshold && EMA_Fast[i] <= EMA_Fast[i - 1];

    if (pozisyon == 0)
    {
        // --- GIRIS ---
        if (longTrend && longBreak && longADX && gucluHacim)
        {
            if (YON == "CIFT" || YON == "SADECE_AL")
            {
                Sistem.Yon[i] = "A"; // AL
                pozisyon = 1;
                ucUcMesafe = C[i];
                stopSeviyesi = L[i];
            }
        }
        else if (shortTrend && shortBreak && shortADX && gucluHacim)
        {
            if (YON == "CIFT" || YON == "SADECE_SAT")
            {
                Sistem.Yon[i] = "S"; // SAT
                pozisyon = -1;
                ucUcMesafe = C[i];
                stopSeviyesi = H[i];
            }
        }
    }
    else if (pozisyon == 1)
    {
        // Trailing stop güncelle
        if (C[i] > ucUcMesafe)
        {
            ucUcMesafe = C[i];
            float yeniStop = ucUcMesafe * (1.0f - iz_yuzde);
            if (yeniStop > stopSeviyesi) stopSeviyesi = yeniStop;
        }
        
        // Çıkış: EMA crossback veya İzleyen Stop (bar-içi: L[i] kontrol)
        bool emaCrossback = C[i] < EMA_Fast[i] && C[i] < EMA_Slow[i];
        if (emaCrossback || L[i] <= stopSeviyesi)
        {
            if (shortTrend && shortBreak && shortADX && gucluHacim && (YON == "CIFT" || YON == "SADECE_SAT"))
            {
                Sistem.Yon[i] = "S";
                pozisyon = -1;
                ucUcMesafe = C[i];
                stopSeviyesi = H[i];
            }
            else
            {
                Sistem.Yon[i] = "F"; // FLAT
                pozisyon = 0;
                ucUcMesafe = 0f;
                stopSeviyesi = 0f;
            }
        }
    }
    else if (pozisyon == -1)
    {
        // Trailing stop güncelle
        if (C[i] < ucUcMesafe)
        {
            ucUcMesafe = C[i];
            float yeniStop = ucUcMesafe * (1.0f + iz_yuzde);
            if (yeniStop < stopSeviyesi || stopSeviyesi == 0) stopSeviyesi = yeniStop;
        }
        
        // Çıkış: EMA crossback veya İzleyen Stop (bar-içi: H[i] kontrol)
        bool emaCrossback = C[i] > EMA_Fast[i] && C[i] > EMA_Slow[i];
        if (emaCrossback || H[i] >= stopSeviyesi)
        {
            if (longTrend && longBreak && longADX && gucluHacim && (YON == "CIFT" || YON == "SADECE_AL"))
            {
                Sistem.Yon[i] = "A";
                pozisyon = 1;
                ucUcMesafe = C[i];
                stopSeviyesi = L[i];
            }
            else
            {
                Sistem.Yon[i] = "F"; // FLAT
                pozisyon = 0;
                ucUcMesafe = 0f;
                stopSeviyesi = 0f;
            }
        }
    }
}

// === ÇİZİMLER (Index 3+ — Pro Performance Panel ile çakışmaz) ===
Sistem.Cizgiler[3].Deger = EMA_Fast;
Sistem.Cizgiler[3].Aciklama = "EMA 8";
Sistem.Cizgiler[3].ActiveBool = true;

Sistem.Cizgiler[4].Deger = EMA_Slow;
Sistem.Cizgiler[4].Aciklama = "EMA 55";
Sistem.Cizgiler[4].ActiveBool = true;

Sistem.Cizgiler[5].Deger = HH;
Sistem.Cizgiler[5].Aciklama = "HH 17";
Sistem.Cizgiler[5].ActiveBool = true;

// ===============================================================================================
// PERFORMANS PANELİ (3 KUTULU PRO SÜRÜM - Gelişmiş Metrikler Eklendi)
// ===============================================================================================
bool GetiriTarihcesiGoster = true;
bool DetayPerformans = true;
string GetiriTarih = "01.01.2024";
float GetiriKayma = 0.0f;

//-----------------------------------------------
var renk = Color.Black;
DateTime dateBaslangicTarih = (DateTime.ParseExact(GetiriTarih, "dd.MM.yyyy", System.Globalization.CultureInfo.CurrentCulture) > Grafikler[0].Date) ? (DateTime.ParseExact(GetiriTarih, "dd.MM.yyyy", System.Globalization.CultureInfo.CurrentCulture)) : Grafikler[0].Date;
Sistem.GetiriHesapla(dateBaslangicTarih.ToString("dd.MM.yyyy"), GetiriKayma); 

int InitBarNo = 0;
for (int i = 0; i < Grafikler.Count; i++)
{{
    if (Grafikler[i].Date >= dateBaslangicTarih) {{ InitBarNo = i; break; }}
}}

// ------------------------------------------------------------------------------------------
// 1. ADIM: SANAL GETİRİ, GERÇEK MAX DD VE İLERİ DÜZEY METRİKLER İÇİN İŞLEM BAZLI HESAPLAMALAR
// ------------------------------------------------------------------------------------------
var SanalGetiri = Sistem.Liste(0);
int poz = 0;
float maliyet = 0;
float kapananKZ = 0;
float kayma = GetiriKayma;

float ZirveBakiye = 0f;
float GercekMaxDD = 0f;
DateTime GercekMaxDDTarih = DateTime.MinValue;

// 3. Panel İçin Gerekli Olan Değişkenler
List<float> IslemGetirileri = new List<float>();
float ToplamKar = 0f;
float ToplamZarar = 0f;
int KarliIslemSayisi = 0;
int ZararliIslemSayisi = 0;

for (int i = 1; i < Grafikler.Count; i++)
{{
    float anlikKapananIslemKari = 0;
    bool islemKapandi = false;

    if (Grafikler[i].Date >= dateBaslangicTarih)
    {{
        if (Sistem.Yon[i] == "A" && poz != 1)
        {{
            if (poz == -1) {{ anlikKapananIslemKari = (maliyet - C[i] - kayma); kapananKZ += anlikKapananIslemKari; islemKapandi = true; }}
            poz = 1;
            maliyet = C[i] + kayma;
        }}
        else if (Sistem.Yon[i] == "S" && poz != -1)
        {{
            if (poz == 1) {{ anlikKapananIslemKari = (C[i] - maliyet - kayma); kapananKZ += anlikKapananIslemKari; islemKapandi = true; }}
            poz = -1;
            maliyet = C[i] - kayma; 
        }}
        else if (Sistem.Yon[i] == "F" && poz != 0)
        {{
            if (poz == 1) {{ anlikKapananIslemKari = (C[i] - maliyet - kayma); islemKapandi = true; }}
            else if (poz == -1) {{ anlikKapananIslemKari = (maliyet - C[i] - kayma); islemKapandi = true; }}
            kapananKZ += anlikKapananIslemKari;
            poz = 0;
            maliyet = 0;
        }}

        // İleri Düzey Metrikler (Sharpe, Payoff vb.) İçin Kapalı İşlemlerin Kaydı
        if (islemKapandi)
        {{
            IslemGetirileri.Add(anlikKapananIslemKari);
            if (anlikKapananIslemKari > 0) {{ ToplamKar += anlikKapananIslemKari; KarliIslemSayisi++; }}
            else if (anlikKapananIslemKari < 0) {{ ToplamZarar += Math.Abs(anlikKapananIslemKari); ZararliIslemSayisi++; }}
        }}

        float acikKZ = 0;
        if (poz == 1) acikKZ = C[i] - maliyet;
        else if (poz == -1) acikKZ = maliyet - C[i];

        SanalGetiri[i] = kapananKZ + acikKZ;

        // Gerçek Floating MaxDD Hesabı
        if (SanalGetiri[i] > ZirveBakiye) ZirveBakiye = SanalGetiri[i];
        float anlikDD = ZirveBakiye - SanalGetiri[i];
        if (anlikDD > GercekMaxDD) {{ GercekMaxDD = anlikDD; GercekMaxDDTarih = Grafikler[i].Date; }}
    }}
}}

// ------------------------------------------------------------------------------------------
// 2. ADIM: "BUGÜN" CANLI GETİRİ HESABI
// ------------------------------------------------------------------------------------------
var DateBugun = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
var DateDunSonBarNo = 0;
for (int i = Grafikler.Count - 1; i > 0; i--)
{{
    if (Grafikler[i].Date < DateBugun) {{ DateDunSonBarNo = i; break; }}
}}

var gunluk_getiri = SanalGetiri[Grafikler.Count - 1] - SanalGetiri[DateDunSonBarNo];
var kzbugunx      = gunluk_getiri.ToString("0.0");
string Labelsx    =  "Bugün" + Environment.NewLine ;
string Resultsx   = kzbugunx + Environment.NewLine ;

if ( gunluk_getiri > 0 ) renk = Color.Green; else if ( gunluk_getiri < 0 ) renk = Color.Red;

int ilksatirYy = 240;
Sistem.Dortgen(1, 10, ilksatirYy - 5, 90, 25, renk, Color.Black, Color.White);
Sistem.GradientYaziEkle(Labelsx, 1, 15, ilksatirYy, Color.White, Color.White, "Tahoma", 8);
Sistem.GradientYaziEkle(Resultsx, 1, 60, ilksatirYy, Color.Yellow, Color.DarkOrange, "Tahoma", 8);
//-----------------------------------------------

if (Sistem.Parametreler[3] == "X")
{{
    int ilksatirY = 33;
    var Sure = ((DateTime.Now - dateBaslangicTarih).TotalDays / 30.4);
    var SureTxt = Sure.ToString("0.0");
    
    var kzSure = SanalGetiri[Grafikler.Count - 1].ToString("0.0");
    var kzbugun = gunluk_getiri.ToString("0.0");
    var yuzde_kz = (O[InitBarNo] != 0) ? (( SanalGetiri[Grafikler.Count - 1] * 100.0f ) / O[InitBarNo]) : 0;
    var kzSure_yuzde = "  %" + yuzde_kz.ToString("0.0");

    string ToplamIslem = Sistem.GetiriToplamIslem.ToString("0");
    string OrtalamaIslem = (((double)Sistem.GetiriToplamIslem) / Sure).ToString("0");
    var KarliIslemOran = Sistem.GetiriKarIslemOran.ToString("0.00");
    var MutluGun = Sistem.GetiriMutluGun.ToString();
    var MutsuzGun = Sistem.GetiriMutsuzGun.ToString();
    var ProfitFactor = Sistem.ProfitFactor.ToString("0.00");

    var MaxDD = GercekMaxDD.ToString("0.0");
    var MaxDDTarihi = (GercekMaxDDTarih != DateTime.MinValue) ? GercekMaxDDTarih.ToString("dd.MM.yyyy") : "-"; 

    // EĞRİLER: (SanalGetiri yerine Sistem.GetiriKZGun yazdım ki o sevdiğin merdiven yapısı grafik üstünde kalsın)
    Sistem.Cizgiler[0].Deger = Sistem.GetiriKZGun; 
    Sistem.Cizgiler[0].Aciklama = "Gün KZ (Kapalı)"; 
    Sistem.Cizgiler[0].ActiveBool = true;
    
    Sistem.Cizgiler[1].Deger = Sistem.GetiriKZGunSonu;
    Sistem.Cizgiler[1].Aciklama = "Gün Sonu KZ"; 
    Sistem.Cizgiler[1].ActiveBool = true;
    
    Sistem.DolguEkle(0, 1, Color.Red, Color.Green);

    Sistem.Cizgiler[2].Deger = Sistem.GetiriKZAy; 
    Sistem.Cizgiler[2].Aciklama =  "Aylık Getiri"; 
    Sistem.Cizgiler[2].ActiveBool = true;

    // ------------------------------------------------------------------------------------------
    // 3. ADIM: YENİ MATEMATİKSEL METRİKLER (PANEL 3 İÇİN)
    // ------------------------------------------------------------------------------------------
    float OrtalamaKar = (KarliIslemSayisi > 0) ? (ToplamKar / KarliIslemSayisi) : 0f;
    float OrtalamaZarar = (ZararliIslemSayisi > 0) ? (ToplamZarar / ZararliIslemSayisi) : 0f;
    float PayoffRatio = (OrtalamaZarar > 0) ? (OrtalamaKar / OrtalamaZarar) : 0f;
    
    float WinRate = (IslemGetirileri.Count > 0) ? ((float)KarliIslemSayisi / IslemGetirileri.Count) : 0f;
    float Expectancy = (WinRate * OrtalamaKar) - ((1f - WinRate) * OrtalamaZarar);
    
    float RecoveryFactor = (GercekMaxDD > 0) ? (SanalGetiri[Grafikler.Count - 1] / GercekMaxDD) : 0f;
    float YillikGetiri = (Sure > 0) ? (SanalGetiri[Grafikler.Count - 1] / (float)(Sure / 12f)) : 0f;
    float CalmarRatio = (GercekMaxDD > 0) ? (YillikGetiri / GercekMaxDD) : 0f;

    // İşlem Bazlı Sharpe Oranı (Ticari Varyans Hesaplaması)
    float ToplamG = 0f; foreach(var r in IslemGetirileri) ToplamG += r;
    float OrtGetiri = (IslemGetirileri.Count > 0) ? (ToplamG / IslemGetirileri.Count) : 0f;
    float KarelerToplami = 0f; foreach(var r in IslemGetirileri) KarelerToplami += (float)Math.Pow(r - OrtGetiri, 2);
    float StandartSapma = (IslemGetirileri.Count > 1) ? (float)Math.Sqrt(KarelerToplami / (IslemGetirileri.Count - 1)) : 0f;
    float SharpeT = (StandartSapma > 0) ? ((OrtGetiri / StandartSapma) * (float)Math.Sqrt(IslemGetirileri.Count)) : 0f;

    if (GetiriTarihcesiGoster)
    {{
        int daysToSubtract = (int)DateTime.Now.DayOfWeek - (int)DayOfWeek.Monday;
        if (daysToSubtract < 0) daysToSubtract += 7; 
        
        var DateHaftaBasi = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddDays(-daysToSubtract);
        var DateHaftaBasiBarNo = 0;
        for (int i = Grafikler.Count - 1; i > 0; i--) if (Grafikler[i].Date < DateHaftaBasi) {{ DateHaftaBasiBarNo = i; break; }}
        var kzBuHafta = (SanalGetiri[Grafikler.Count - 1] - SanalGetiri[DateHaftaBasiBarNo]).ToString("0.0");

        var DateBuAy = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        var DateBuAyBarNo = 0;
        for (int i = Grafikler.Count - 1; i > 0; i--) if (Grafikler[i].Date < DateBuAy) {{ DateBuAyBarNo = i; break; }}
        var kzbuay = (SanalGetiri[Grafikler.Count - 1] - SanalGetiri[DateBuAyBarNo]).ToString("0.0");

        var Date30 = DateTime.Now.AddDays(-30);
        var Date30BarNo = 0;
        for (int i = Grafikler.Count - 1; i > 0; i--) if (Grafikler[i].Date <= Date30) {{ Date30BarNo = i; break; }}
        var kz30 = (SanalGetiri[Grafikler.Count - 1] - SanalGetiri[Date30BarNo]).ToString("0.0");

        var Date60 = DateTime.Now.AddDays(-60);
        var Date60BarNo = 0;
        for (int i = Grafikler.Count - 1; i > 0; i--) if (Grafikler[i].Date <= Date60) {{ Date60BarNo = i; break; }}
        var kz60 = (SanalGetiri[Grafikler.Count - 1] - SanalGetiri[Date60BarNo]).ToString("0.0");

        var Date90 = DateTime.Now.AddDays(-90);
        var Date90BarNo = 0;
        for (int i = Grafikler.Count - 1; i > 0; i--) if (Grafikler[i].Date <= Date90) {{ Date90BarNo = i; break; }}
        var kz90 = (SanalGetiri[Grafikler.Count - 1] - SanalGetiri[Date90BarNo]).ToString("0.0");

        var Date180 = DateTime.Now.AddDays(-180);
        var Date180BarNo = 0;
        for (int i = Grafikler.Count - 1; i > 0; i--) if (Grafikler[i].Date <= Date180) {{ Date180BarNo = i; break; }}
        var kz180 = (SanalGetiri[Grafikler.Count - 1] - SanalGetiri[Date180BarNo]).ToString("0.0");

        var DateYilBasi = new DateTime(DateTime.Now.Year, 1, 1);
        var DateYilBasiBarNo = 0;
        for (int i = Grafikler.Count - 1; i > 0; i--) if (Grafikler[i].Date < DateYilBasi) {{ DateYilBasiBarNo = i; break; }}
        var kzBuYil = (SanalGetiri[Grafikler.Count - 1] - SanalGetiri[DateYilBasiBarNo]).ToString("0.0");

        var Date1Yil = DateTime.Now.AddYears(-1);
        var Date1YilBarNo = 0;
        for (int i = Grafikler.Count - 1; i > 0; i--) if (Grafikler[i].Date <= Date1Yil) {{ Date1YilBarNo = i; break; }}
        var kz1Yil = (SanalGetiri[Grafikler.Count - 1] - SanalGetiri[Date1YilBarNo]).ToString("0.0");

        // --- PANEL 1 ÇİZİMİ (SOL) ---
        string Labels = SureTxt + " Ay" + Environment.NewLine + "Bugün" + Environment.NewLine + "Bu Hafta" + Environment.NewLine + "Bu Ay" + Environment.NewLine + "30 Gün" + Environment.NewLine + "60 Gün" + Environment.NewLine + "90 Gün" + Environment.NewLine + "180 Gün" + Environment.NewLine + "Bu Yıl" + Environment.NewLine + "Son 1 Yıl";
        string Results = kzSure + kzSure_yuzde+  Environment.NewLine + kzbugun + Environment.NewLine + kzBuHafta + Environment.NewLine + kzbuay + Environment.NewLine + kz30 + Environment.NewLine + kz60 + Environment.NewLine + kz90 + Environment.NewLine + kz180 + Environment.NewLine + kzBuYil + Environment.NewLine + kz1Yil;

        Sistem.Dortgen(2, 10, ilksatirY - 8, 230, 180, Color.Black, Color.Black, Color.White);
        Sistem.GradientYaziEkle(Labels, 2, 20, ilksatirY, Color.White, Color.White, "Tahoma", 10);
        Sistem.GradientYaziEkle(Results, 2, 90, ilksatirY, Color.Yellow, Color.DarkOrange, "Tahoma", 10);
    }}

    if (DetayPerformans)
    {{
        // --- PANEL 2 ÇİZİMİ (ORTA) ---
        string Labels2 = "İslem / Ortalama" + Environment.NewLine + "Karlı İşlem Oranı" + Environment.NewLine + "Profit Factor" + Environment.NewLine + "Mutlu Gün" + Environment.NewLine + "Mutsuz Gün" + Environment.NewLine + "MaxDD" + Environment.NewLine + "MaxDD Tarihi";
        string Results2 = ToplamIslem + " / " + OrtalamaIslem + Environment.NewLine + "%" + KarliIslemOran + Environment.NewLine + ProfitFactor + Environment.NewLine + MutluGun + Environment.NewLine + MutsuzGun + Environment.NewLine + MaxDD + Environment.NewLine + MaxDDTarihi;

        Sistem.Dortgen(2, 250, ilksatirY - 8, 215, 130, Color.Black, Color.Black, Color.White);
        Sistem.GradientYaziEkle(Labels2, 2, 260, ilksatirY, Color.White, Color.White, "Tahoma", 10);
        Sistem.GradientYaziEkle(Results2, 2, 380, ilksatirY, Color.Yellow, Color.DarkOrange, "Tahoma", 10);

        // --- PANEL 3 ÇİZİMİ (SAĞ) - İLERİ DÜZEY METRİKLER ---
        string Labels3 = "Ort. Kâr / Zarar" + Environment.NewLine + 
                         "Payoff Ratio (R/R)" + Environment.NewLine + 
                         "Expectancy" + Environment.NewLine + 
                         "Recovery Factor" + Environment.NewLine + 
                         "Calmar Oranı" + Environment.NewLine + 
                         "Sharpe Oranı";

        string Results3 = OrtalamaKar.ToString("0.0") + " / " + OrtalamaZarar.ToString("0.0") + Environment.NewLine +
                          PayoffRatio.ToString("0.00") + Environment.NewLine +
                          Expectancy.ToString("0.0") + " Puan" + Environment.NewLine +
                          RecoveryFactor.ToString("0.00") + Environment.NewLine +
                          CalmarRatio.ToString("0.00") + Environment.NewLine +
                          SharpeT.ToString("0.00");

        // Yeni kutunun X ekseni ayarlandı (475'ten başlıyor)
        Sistem.Dortgen(2, 475, ilksatirY - 8, 215, 115, Color.Black, Color.Black, Color.White);
        Sistem.GradientYaziEkle(Labels3, 2, 485, ilksatirY, Color.White, Color.White, "Tahoma", 10);
        Sistem.GradientYaziEkle(Results3, 2, 605, ilksatirY, Color.Yellow, Color.DarkOrange, "Tahoma", 10);
    }}
}}

