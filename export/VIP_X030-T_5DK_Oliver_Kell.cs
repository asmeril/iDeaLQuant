// --- OLIVER KELL STRATEJİSİ (VİOP - ÇİFT YÖNLÜ) ---
// VİOP Endeks ve Pay Vadeliler için tasarlanmıştır.
// Kaynak: 2020 US Investing Championship (%941)
// IdealQuant Export | Tarih: 2026-02-25
//
// Kurallar:
// 1. Long: EMA üstü, HH Kırılımı, Hacim Artışı, ADX filtre.
// 2. Short: EMA altı, LL Kırılımı, Hacim Artışı, ADX filtre.
// 3. İz Süren Stop: %1.5

var V = Sistem.GrafikVerileri;
var O = Sistem.GrafikFiyatOku(V, "Acilis");
var C = Sistem.GrafikFiyatOku(V, "Kapanis");
var H = Sistem.GrafikFiyatOku(V, "Yuksek");
var L = Sistem.GrafikFiyatOku(V, "Dusuk");
var Vol = Sistem.GrafikFiyatOku(V, "Hacim");

// --- GÖSTERGELER ---
var EMA10 = Sistem.MA(C, "Exp", 8);
var EMA20 = Sistem.MA(C, "Exp", 55);
var VolMA = Sistem.MA(Vol, "Simple", 20);
var ADX = Sistem.ADX(18);
var HH10 = Sistem.HHV(17, "Yuksek");
var LL10 = Sistem.LLV(17, "Dusuk");

// --- EMA YÖNÜ TESTERE FİLTRESİ ---
Sistem.Cizgiler[3].Deger = EMA10;
Sistem.Cizgiler[3].Aciklama = "8 EMA";
Sistem.Cizgiler[3].Renk = Sistem.Renk(255, 0, 0, 255); 
Sistem.Cizgiler[3].ActiveBool = true;

Sistem.Cizgiler[4].Deger = EMA20;
Sistem.Cizgiler[4].Aciklama = "55 EMA";
Sistem.Cizgiler[4].Renk = Sistem.Renk(255, 255, 0, 0); 
Sistem.Cizgiler[4].ActiveBool = true;

// --- STRATEJİ DEĞİŞKENLERİ ---
float IzSurenYuzde = 0.015f;
float UcUcMesafe = 0;
float StopSeviyesi = 0;
string Pozisyon = "F";

for (int i = 20; i < V.Count; i++)
{
    // LONG KOŞULLARI
    bool longTrend = C[i] > EMA10[i] && C[i] > EMA20[i];
    bool longBreak = C[i] > HH10[i-1]; 
    bool trendGucuLong = ADX[i] > 22 && EMA10[i] > EMA10[i-1];
    
    // SHORT KOŞULLARI
    bool shortTrend = C[i] < EMA10[i] && C[i] < EMA20[i];
    bool shortBreak = C[i] < LL10[i-1];
    bool trendGucuShort = ADX[i] > 22 && EMA10[i] < EMA10[i-1];

    bool gucluHacim = Vol[i] > VolMA[i];
    
    // ÇIKIŞ ŞARTLARI (EMA Crossback)
    bool emaCrossbackLongIcin = C[i] < EMA10[i] && C[i] < EMA20[i];
    bool emaCrossbackShortIcin = C[i] > EMA10[i] && C[i] > EMA20[i];

    if (Pozisyon == "F")
    {
        if (longTrend && longBreak && gucluHacim && trendGucuLong)
        {
            Sistem.Yon[i] = "A";
            Pozisyon = "A";
            UcUcMesafe = C[i];
            StopSeviyesi = L[i]; 
        }
        else if (shortTrend && shortBreak && gucluHacim && trendGucuShort)
        {
            Sistem.Yon[i] = "S";
            Pozisyon = "S";
            UcUcMesafe = C[i];
            StopSeviyesi = H[i];
        }
    }
    else if (Pozisyon == "A")
    {
        if (C[i] > UcUcMesafe) {
            UcUcMesafe = C[i];
            float yeniStop = UcUcMesafe * (1.0f - IzSurenYuzde);
            if (yeniStop > StopSeviyesi) StopSeviyesi = yeniStop; 
        }

        if (emaCrossbackLongIcin || C[i] <= StopSeviyesi)
        {
            if (shortTrend && shortBreak && gucluHacim && trendGucuShort) {
                Sistem.Yon[i] = "S";
                Pozisyon = "S";
                UcUcMesafe = C[i]; StopSeviyesi = H[i];
            } else {
                Sistem.Yon[i] = "F"; 
                Pozisyon = "F";
            }
        }
    }
    else if (Pozisyon == "S")
    {
        if (C[i] < UcUcMesafe) {
            UcUcMesafe = C[i];
            float yeniStop = UcUcMesafe * (1.0f + IzSurenYuzde); 
            if (yeniStop < StopSeviyesi || StopSeviyesi == 0) StopSeviyesi = yeniStop; 
        }

        if (emaCrossbackShortIcin || C[i] >= StopSeviyesi)
        {
            if (longTrend && longBreak && gucluHacim && trendGucuLong) {
                Sistem.Yon[i] = "A";
                Pozisyon = "A";
                UcUcMesafe = C[i]; StopSeviyesi = L[i];
            } else {
                Sistem.Yon[i] = "F"; 
                Pozisyon = "F";
            }
        }
    }
}

// ===============================================================================================
// PERFORMANS PANELİ (3 KUTULU PRO SÜRÜM - Gelişmiş Metrikler Eklendi)
// ===============================================================================================
bool GetiriTarihcesiGoster = true;
bool DetayPerformans = true;
string GetiriTarih = "01.01.2024";
float GetiriKayma = 0.0f;

//-----------------------------------------------
var renk = Color.Black;
DateTime dateBaslangicTarih = (DateTime.ParseExact(GetiriTarih, "dd.MM.yyyy", System.Globalization.CultureInfo.CurrentCulture) > V[0].Date) ? (DateTime.ParseExact(GetiriTarih, "dd.MM.yyyy", System.Globalization.CultureInfo.CurrentCulture)) : V[0].Date;
Sistem.GetiriHesapla(dateBaslangicTarih.ToString("dd.MM.yyyy"), GetiriKayma); 

int InitBarNo = 0;
for (int i = 0; i < V.Count; i++)
{
    if (V[i].Date >= dateBaslangicTarih) { InitBarNo = i; break; }
}

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

for (int i = 1; i < V.Count; i++)
{
    float anlikKapananIslemKari = 0;
    bool islemKapandi = false;

    if (V[i].Date >= dateBaslangicTarih)
    {
        if (Sistem.Yon[i] == "A" && poz != 1)
        {
            if (poz == -1) { anlikKapananIslemKari = (maliyet - C[i] - kayma); kapananKZ += anlikKapananIslemKari; islemKapandi = true; }
            poz = 1;
            maliyet = C[i] + kayma;
        }
        else if (Sistem.Yon[i] == "S" && poz != -1)
        {
            if (poz == 1) { anlikKapananIslemKari = (C[i] - maliyet - kayma); kapananKZ += anlikKapananIslemKari; islemKapandi = true; }
            poz = -1;
            maliyet = C[i] - kayma; 
        }
        else if (Sistem.Yon[i] == "F" && poz != 0)
        {
            if (poz == 1) { anlikKapananIslemKari = (C[i] - maliyet - kayma); islemKapandi = true; }
            else if (poz == -1) { anlikKapananIslemKari = (maliyet - C[i] - kayma); islemKapandi = true; }
            kapananKZ += anlikKapananIslemKari;
            poz = 0;
            maliyet = 0;
        }

        // İleri Düzey Metrikler (Sharpe, Payoff vb.) İçin Kapalı İşlemlerin Kaydı
        if (islemKapandi)
        {
            IslemGetirileri.Add(anlikKapananIslemKari);
            if (anlikKapananIslemKari > 0) { ToplamKar += anlikKapananIslemKari; KarliIslemSayisi++; }
            else if (anlikKapananIslemKari < 0) { ToplamZarar += Math.Abs(anlikKapananIslemKari); ZararliIslemSayisi++; }
        }

        float acikKZ = 0;
        if (poz == 1) acikKZ = C[i] - maliyet;
        else if (poz == -1) acikKZ = maliyet - C[i];

        SanalGetiri[i] = kapananKZ + acikKZ;

        // Gerçek Floating MaxDD Hesabı
        if (SanalGetiri[i] > ZirveBakiye) ZirveBakiye = SanalGetiri[i];
        float anlikDD = ZirveBakiye - SanalGetiri[i];
        if (anlikDD > GercekMaxDD) { GercekMaxDD = anlikDD; GercekMaxDDTarih = V[i].Date; }
    }
}

// ------------------------------------------------------------------------------------------
// 2. ADIM: "BUGÜN" CANLI GETİRİ HESABI
// ------------------------------------------------------------------------------------------
var DateBugun = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
var DateDunSonBarNo = 0;
for (int i = V.Count - 1; i > 0; i--)
{
    if (V[i].Date < DateBugun) { DateDunSonBarNo = i; break; }
}

var gunluk_getiri = SanalGetiri[V.Count - 1] - SanalGetiri[DateDunSonBarNo];
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
{
    int ilksatirY = 33;
    var Sure = ((DateTime.Now - dateBaslangicTarih).TotalDays / 30.4);
    var SureTxt = Sure.ToString("0.0");
    
    var kzSure = SanalGetiri[V.Count - 1].ToString("0.0");
    var kzbugun = gunluk_getiri.ToString("0.0");
    var yuzde_kz = (O[InitBarNo] != 0) ? (( SanalGetiri[V.Count - 1] * 100.0f ) / O[InitBarNo]) : 0;
    var kzSure_yuzde = "  %" + yuzde_kz.ToString("0.0");

    string ToplamIslem = Sistem.GetiriToplamIslem.ToString("0");
    string OrtalamaIslem = (((double)Sistem.GetiriToplamIslem) / Sure).ToString("0");
    var KarliIslemOran = Sistem.GetiriKarIslemOran.ToString("0.00");
    var MutluGun = Sistem.GetiriMutluGun.ToString();
    var MutsuzGun = Sistem.GetiriMutsuzGun.ToString();
    var ProfitFactor = Sistem.ProfitFactor.ToString("0.00");

    var MaxDD = GercekMaxDD.ToString("0.0");
    var MaxDDTarihi = (GercekMaxDDTarih != DateTime.MinValue) ? GercekMaxDDTarih.ToString("dd.MM.yyyy") : "-"; 

    // EĞRİLER
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
    
    float RecoveryFactor = (GercekMaxDD > 0) ? (SanalGetiri[V.Count - 1] / GercekMaxDD) : 0f;
    float YillikGetiri = (Sure > 0) ? (SanalGetiri[V.Count - 1] / (float)(Sure / 12f)) : 0f;
    float CalmarRatio = (GercekMaxDD > 0) ? (YillikGetiri / GercekMaxDD) : 0f;

    // İşlem Bazlı Sharpe Oranı (Ticari Varyans Hesaplaması)
    float ToplamG = 0f; foreach(var r in IslemGetirileri) ToplamG += r;
    float OrtGetiri = (IslemGetirileri.Count > 0) ? (ToplamG / IslemGetirileri.Count) : 0f;
    float KarelerToplami = 0f; foreach(var r in IslemGetirileri) KarelerToplami += (float)Math.Pow(r - OrtGetiri, 2);
    float StandartSapma = (IslemGetirileri.Count > 1) ? (float)Math.Sqrt(KarelerToplami / (IslemGetirileri.Count - 1)) : 0f;
    float SharpeT = (StandartSapma > 0) ? ((OrtGetiri / StandartSapma) * (float)Math.Sqrt(IslemGetirileri.Count)) : 0f;

    if (GetiriTarihcesiGoster)
    {
        int daysToSubtract = (int)DateTime.Now.DayOfWeek - (int)DayOfWeek.Monday;
        if (daysToSubtract < 0) daysToSubtract += 7; 
        
        var DateHaftaBasi = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddDays(-daysToSubtract);
        var DateHaftaBasiBarNo = 0;
        for (int i = V.Count - 1; i > 0; i--) if (V[i].Date < DateHaftaBasi) { DateHaftaBasiBarNo = i; break; }
        var kzBuHafta = (SanalGetiri[V.Count - 1] - SanalGetiri[DateHaftaBasiBarNo]).ToString("0.0");

        var DateBuAy = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        var DateBuAyBarNo = 0;
        for (int i = V.Count - 1; i > 0; i--) if (V[i].Date < DateBuAy) { DateBuAyBarNo = i; break; }
        var kzbuay = (SanalGetiri[V.Count - 1] - SanalGetiri[DateBuAyBarNo]).ToString("0.0");

        var Date30 = DateTime.Now.AddDays(-30);
        var Date30BarNo = 0;
        for (int i = V.Count - 1; i > 0; i--) if (V[i].Date <= Date30) { Date30BarNo = i; break; }
        var kz30 = (SanalGetiri[V.Count - 1] - SanalGetiri[Date30BarNo]).ToString("0.0");

        var Date60 = DateTime.Now.AddDays(-60);
        var Date60BarNo = 0;
        for (int i = V.Count - 1; i > 0; i--) if (V[i].Date <= Date60) { Date60BarNo = i; break; }
        var kz60 = (SanalGetiri[V.Count - 1] - SanalGetiri[Date60BarNo]).ToString("0.0");

        var Date90 = DateTime.Now.AddDays(-90);
        var Date90BarNo = 0;
        for (int i = V.Count - 1; i > 0; i--) if (V[i].Date <= Date90) { Date90BarNo = i; break; }
        var kz90 = (SanalGetiri[V.Count - 1] - SanalGetiri[Date90BarNo]).ToString("0.0");

        var Date180 = DateTime.Now.AddDays(-180);
        var Date180BarNo = 0;
        for (int i = V.Count - 1; i > 0; i--) if (V[i].Date <= Date180) { Date180BarNo = i; break; }
        var kz180 = (SanalGetiri[V.Count - 1] - SanalGetiri[Date180BarNo]).ToString("0.0");

        var DateYilBasi = new DateTime(DateTime.Now.Year, 1, 1);
        var DateYilBasiBarNo = 0;
        for (int i = V.Count - 1; i > 0; i--) if (V[i].Date < DateYilBasi) { DateYilBasiBarNo = i; break; }
        var kzBuYil = (SanalGetiri[V.Count - 1] - SanalGetiri[DateYilBasiBarNo]).ToString("0.0");

        var Date1Yil = DateTime.Now.AddYears(-1);
        var Date1YilBarNo = 0;
        for (int i = V.Count - 1; i > 0; i--) if (V[i].Date <= Date1Yil) { Date1YilBarNo = i; break; }
        var kz1Yil = (SanalGetiri[V.Count - 1] - SanalGetiri[Date1YilBarNo]).ToString("0.0");

        // --- PANEL 1 ÇİZİMİ (SOL) ---
        string Labels = SureTxt + " Ay" + Environment.NewLine + "Bugün" + Environment.NewLine + "Bu Hafta" + Environment.NewLine + "Bu Ay" + Environment.NewLine + "30 Gün" + Environment.NewLine + "60 Gün" + Environment.NewLine + "90 Gün" + Environment.NewLine + "180 Gün" + Environment.NewLine + "Bu Yıl" + Environment.NewLine + "Son 1 Yıl";
        string Results = kzSure + kzSure_yuzde+  Environment.NewLine + kzbugun + Environment.NewLine + kzBuHafta + Environment.NewLine + kzbuay + Environment.NewLine + kz30 + Environment.NewLine + kz60 + Environment.NewLine + kz90 + Environment.NewLine + kz180 + Environment.NewLine + kzBuYil + Environment.NewLine + kz1Yil;

        Sistem.Dortgen(2, 10, ilksatirY - 8, 230, 180, Color.Black, Color.Black, Color.White);
        Sistem.GradientYaziEkle(Labels, 2, 20, ilksatirY, Color.White, Color.White, "Tahoma", 10);
        Sistem.GradientYaziEkle(Results, 2, 90, ilksatirY, Color.Yellow, Color.DarkOrange, "Tahoma", 10);
    }

    if (DetayPerformans)
    {
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

        Sistem.Dortgen(2, 475, ilksatirY - 8, 215, 115, Color.Black, Color.Black, Color.White);
        Sistem.GradientYaziEkle(Labels3, 2, 485, ilksatirY, Color.White, Color.White, "Tahoma", 10);
        Sistem.GradientYaziEkle(Results3, 2, 605, ilksatirY, Color.Yellow, Color.DarkOrange, "Tahoma", 10);
    }
}
