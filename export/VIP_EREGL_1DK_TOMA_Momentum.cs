// ===============================================================================================
// STRATEJI 4: TOMA + MOMENTUM + TRIX SİSTEMİ
// ===============================================================================================
// Sembol: VIP_EREGL
// Periyot: 1 dakika
// Vade Tipi: SPOT
// Oluşturma: 2026-03-25 18:59
// ===============================================================================================

// --- VADE TİPİ & YÖN MODU ---
string VadeTipi = "SPOT";
string YON_MODU = "CIFT";

// --- PARAMETRELER ---
var MOM_PERIOD = 400;
var MOM_UPPER = 100.5f;
var MOM_LOWER = 99.25f;
var TRIX_PERIOD = 120;
var TRIX_LB1 = 80;
var TRIX_LB2 = 80;
var HHV1_PERIOD = 220;
var LLV1_PERIOD = 240;
var HHV2_PERIOD = 50;
var LLV2_PERIOD = 100;
var HHV3_PERIOD = 90;
var LLV3_PERIOD = 160;
var TOMA_PERIOD = 2;
var TOMA_OPT = 2.1f;
var KAR_AL_YUZDE = 0.0f;
var IZLEYEN_STOP_YUZDE = 0.0f;

// ===============================================================================================
// DİNAMİK BAYRAM TARİHLERİ (2024-2030)
// ===============================================================================================
int yil = DateTime.Now.Year;
DateTime Ramazan, Kurban;

switch(yil)
{
    case 2024: Ramazan = new DateTime(2024, 4, 10); Kurban = new DateTime(2024, 6, 16); break;
    case 2025: Ramazan = new DateTime(2025, 3, 30); Kurban = new DateTime(2025, 6, 6); break;
    case 2026: Ramazan = new DateTime(2026, 3, 20); Kurban = new DateTime(2026, 5, 27); break;
    case 2027: Ramazan = new DateTime(2027, 3, 9); Kurban = new DateTime(2027, 5, 16); break;
    case 2028: Ramazan = new DateTime(2028, 2, 26); Kurban = new DateTime(2028, 5, 5); break;
    case 2029: Ramazan = new DateTime(2029, 2, 14); Kurban = new DateTime(2029, 4, 24); break;
    case 2030: Ramazan = new DateTime(2030, 2, 3); Kurban = new DateTime(2030, 4, 13); break;
    default: Ramazan = new DateTime(yil, 3, 15); Kurban = new DateTime(yil, 5, 20); break;
}

DateTime R2024 = new DateTime(2024, 4, 10); DateTime K2024 = new DateTime(2024, 6, 16);
DateTime R2025 = new DateTime(2025, 3, 30); DateTime K2025 = new DateTime(2025, 6, 6);
DateTime R2026 = new DateTime(2026, 3, 20); DateTime K2026 = new DateTime(2026, 5, 27);
DateTime R2027 = new DateTime(2027, 3, 9); DateTime K2027 = new DateTime(2027, 5, 16);

string[] resmiTatiller = new string[] { "01.01","04.23","05.01","05.19","07.15","08.30","10.29" };

var V = Sistem.GrafikVerileri;
var O = Sistem.GrafikFiyatSec("Acilis");
var C = Sistem.GrafikFiyatSec("Kapanis");
var H = Sistem.GrafikFiyatSec("Yuksek");
var L = Sistem.GrafikFiyatSec("Dusuk");

// ===============================================================================================
// VADE SONU İŞ GÜNÜ HESAPLAMA
// ===============================================================================================
Func<DateTime, DateTime> VadeSonuIsGunu = (dt) =>
{
    var aySonu = new DateTime(dt.Year, dt.Month, DateTime.DaysInMonth(dt.Year, dt.Month));
    var d = aySonu;
    
    for (int k = 0; k < 15; k++)
    {
        if (d.DayOfWeek == DayOfWeek.Saturday || d.DayOfWeek == DayOfWeek.Sunday)
        { d = d.AddDays(-1); continue; }
        
        string mmdd = d.ToString("MM.dd");
        bool tatil = false;
        for (int t = 0; t < resmiTatiller.Length; t++)
            if (resmiTatiller[t] == mmdd) { tatil = true; break; }
        if (tatil) { d = d.AddDays(-1); continue; }
        
        if ((d >= R2024 && d <= R2024.AddDays(3)) || (d >= K2024 && d <= K2024.AddDays(4)) ||
            (d >= R2025 && d <= R2025.AddDays(3)) || (d >= K2025 && d <= K2025.AddDays(4)) ||
            (d >= R2026 && d <= R2026.AddDays(3)) || (d >= K2026 && d <= K2026.AddDays(4)) ||
            (d >= R2027 && d <= R2027.AddDays(3)) || (d >= K2027 && d <= K2027.AddDays(4)))
        { d = d.AddDays(-1); continue; }
        
        break;
    }
    return d.Date;
};

// --- INDIKATORLER ---
var MA_TOMA = Sistem.MA(C, "Exp", TOMA_PERIOD);
var TOMA_Line = Sistem.Liste(0);
var TOMA_Trend = Sistem.Liste(0);

TOMA_Line[0] = MA_TOMA[0];
TOMA_Trend[0] = 1; 

for (int j = 1; j < V.Count; j++)
{
    double yuzdeCarpan = TOMA_OPT / 100.0;
    float altBant = (float)(MA_TOMA[j] * (1 - yuzdeCarpan));
    float ustBant = (float)(MA_TOMA[j] * (1 + yuzdeCarpan));

    if (TOMA_Trend[j-1] == 1)
    {
        TOMA_Line[j] = Math.Max(TOMA_Line[j-1], altBant);
        if (MA_TOMA[j] < TOMA_Line[j])
        {
            TOMA_Trend[j] = -1;
            TOMA_Line[j] = ustBant;
        }
        else
        {
            TOMA_Trend[j] = 1;
        }
    }
    else
    {
        TOMA_Line[j] = Math.Min(TOMA_Line[j-1], ustBant);
        if (MA_TOMA[j] > TOMA_Line[j])
        {
            TOMA_Trend[j] = 1;
            TOMA_Line[j] = altBant;
        }
        else
        {
            TOMA_Trend[j] = -1;
        }
    }
}

var HH1 = Sistem.HHV(HHV1_PERIOD, "Yuksek");
var LL1 = Sistem.LLV(LLV1_PERIOD, "Dusuk");

var HH2 = Sistem.HHV(HHV2_PERIOD, "Yuksek");
var LL2 = Sistem.LLV(LLV2_PERIOD, "Dusuk");

var HH3 = Sistem.HHV(HHV3_PERIOD, "Yuksek");
var LL3 = Sistem.LLV(LLV3_PERIOD, "Dusuk");

var MOM1 = Sistem.Momentum(MOM_PERIOD);
var TRIX1 = Sistem.TRIX(TRIX_PERIOD);
var TRIX2 = Sistem.TRIX(TRIX_PERIOD);

// --- LOOP & SINYAL ---
var SonYon = "";
var Sinyal = "";
double EntryPrice = 0.0;
double ExtremePrice = 0.0;
var Pos = 0;

for (int i = 1; i < V.Count; i++) Sistem.Yon[i] = "";

int warm1 = Math.Max(MOM_PERIOD, TRIX_PERIOD + Math.Max(TRIX_LB1, TRIX_LB2));
int warm2 = Math.Max(HHV1_PERIOD, Math.Max(HHV2_PERIOD, Math.Max(LLV2_PERIOD, Math.Max(HHV3_PERIOD, LLV3_PERIOD))));
int warmupBars = Math.Max(200, Math.Max(warm1, warm2)) + 10;
int warmupBaslangicBar = -999;
bool warmupAktif = false;
bool arefeFlat = false;

for (int i = warmupBars; i < V.Count; i++)
{
    Sinyal = "";
    var dt = V[i].Date;
    var t = dt.TimeOfDay;
    
    // --- VADE/TATİL KONTROLLERİ ---
    bool gunSeansi = t >= new TimeSpan(9,30,0) && t < new TimeSpan(18,15,0);
    bool aksamSeansi = t >= new TimeSpan(19,0,0) && t < new TimeSpan(23,0,0);
    if (!(gunSeansi || aksamSeansi)) continue;

    bool vadeAyi = (VadeTipi == "SPOT") || (dt.Month % 2 == 0);
    bool vadeSonuGun = vadeAyi && (dt.Date == VadeSonuIsGunu(dt));
    
    bool arefe = dt.Date == R2024.AddDays(-1).Date || dt.Date == K2024.AddDays(-1).Date ||
                 dt.Date == R2025.AddDays(-1).Date || dt.Date == K2025.AddDays(-1).Date ||
                 dt.Date == R2026.AddDays(-1).Date || dt.Date == K2026.AddDays(-1).Date ||
                 dt.Date == R2027.AddDays(-1).Date || dt.Date == K2027.AddDays(-1).Date;
                  
    if (arefe && vadeSonuGun && t > new TimeSpan(11,30,0))
    {
        if (SonYon != "F") Sinyal = "F";
        warmupAktif = true; warmupBaslangicBar = -999; arefeFlat = false;
    }
    else if (arefe && !vadeSonuGun && t > new TimeSpan(11,30,0))
    {
        if (SonYon != "F") Sinyal = "F";
        arefeFlat = true;
    }
    else if (vadeSonuGun && t > new TimeSpan(17,40,0))
    {
        if (SonYon != "F") Sinyal = "F";
        warmupAktif = true; warmupBaslangicBar = -999; arefeFlat = false;
    }
    
    if (Sinyal == "F") {
        if (SonYon != Sinyal) { Sistem.Yon[i] = Sinyal; SonYon = Sinyal; Pos = 0; }
        continue;
    }
    
    if ((arefe && t > new TimeSpan(11,30,0)) || (vadeSonuGun && !arefe && t > new TimeSpan(17,40,0))) continue;

    if (warmupAktif && warmupBaslangicBar == -999) {
        bool yeniSeans = false;
        if (aksamSeansi && i>0 && V[i-1].Date.TimeOfDay < new TimeSpan(19,0,0)) yeniSeans = true;
        if (gunSeansi && i>0 && dt.Date != V[i-1].Date.Date) yeniSeans = true;
        if (yeniSeans) warmupBaslangicBar = i;
    }
    if (warmupAktif && warmupBaslangicBar > 0) {
        if ((i - warmupBaslangicBar) < 100) continue; // Min 100 bar cooldown
        else warmupAktif = false;
    }
    if (arefeFlat && i>0 && dt.Date != V[i-1].Date.Date) arefeFlat = false;


    // --- STRATEJİ MANTIĞI ---
    
    // Kural 1: MOM > ÜST SINIR
    if (MOM1[i] > MOM_UPPER)
    {
        if (HH2[i] > HH2[i-1] && TRIX1[i] < TRIX1[i-TRIX_LB1] && TRIX1[i] > TRIX1[i-1] && YON_MODU != "SADECE_SAT") Sinyal = "A"; 
        if (LL2[i] < LL2[i-1] && TRIX1[i] > TRIX1[i-TRIX_LB1] && TRIX1[i] < TRIX1[i-1] && YON_MODU != "SADECE_AL") Sinyal = "S"; 
    }
    
    // Kural 2: MOM < ALT SINIR
    if (MOM1[i] < MOM_LOWER)
    {
        if (HH3[i] > HH3[i-1] && TRIX2[i] < TRIX2[i-TRIX_LB2] && TRIX2[i] > TRIX2[i-1] && YON_MODU != "SADECE_SAT") Sinyal = "A"; 
        if (LL3[i] < LL3[i-1] && TRIX2[i] > TRIX2[i-TRIX_LB2] && TRIX2[i] < TRIX2[i-1] && YON_MODU != "SADECE_AL") Sinyal = "S"; 
    }
    
    // Kural 3: TOMA + HHV/LLV (Ana Trend - Öncelikli, önceki sinyalleri ezer)
    if (HH1[i] > HH1[i-1] && C[i] > TOMA_Line[i] && YON_MODU != "SADECE_SAT") Sinyal = "A";
    if (LL1[i] < LL1[i-1] && C[i] < TOMA_Line[i] && YON_MODU != "SADECE_AL") Sinyal = "S";

    // --- POZİSYON GÜNCELLEME (Giriş / Reverse) ---
    if (Sinyal != "" && SonYon != Sinyal)
    {
        SonYon = Sinyal;
        Sistem.Yon[i] = SonYon;
        EntryPrice = C[i];
        ExtremePrice = C[i];
        if (Sinyal == "A") Pos = 1;
        else if (Sinyal == "S") Pos = -1;
        else Pos = 0;
    }

    // --- EXIT LOGIC (Kar Al / İzleyen Stop) ---
    if (Pos == 1) {
        if (ExtremePrice < C[i]) ExtremePrice = C[i];
        if (KAR_AL_YUZDE > 0 && C[i] >= EntryPrice * (1 + KAR_AL_YUZDE/100.0)) {
            Sistem.Yon[i] = "F"; Pos = 0;
        }
        if (IZLEYEN_STOP_YUZDE > 0 && C[i] <= ExtremePrice * (1 - IZLEYEN_STOP_YUZDE/100.0)) {
            Sistem.Yon[i] = "F"; Pos = 0;
        }
    }
    else if (Pos == -1) {
        if (ExtremePrice == 0 || ExtremePrice > C[i]) ExtremePrice = C[i];
        if (KAR_AL_YUZDE > 0 && C[i] <= EntryPrice * (1 - KAR_AL_YUZDE/100.0)) {
            Sistem.Yon[i] = "F"; Pos = 0;
        }
        if (IZLEYEN_STOP_YUZDE > 0 && C[i] >= ExtremePrice * (1 + IZLEYEN_STOP_YUZDE/100.0)) {
            Sistem.Yon[i] = "F"; Pos = 0;
        }
    }
}

// --- ÇİZİMLER ---
Sistem.Cizgiler[3].Deger = TOMA_Line;
Sistem.Cizgiler[3].Aciklama = "TOMA";
Sistem.Cizgiler[3].Renk = Color.Blue;
Sistem.Cizgiler[3].Kalinlik = 2;

Sistem.Cizgiler[4].Deger = HH1;
Sistem.Cizgiler[4].Aciklama = "HH1";
Sistem.Cizgiler[4].ActiveBool = false;

Sistem.Cizgiler[5].Deger = LL1;
Sistem.Cizgiler[5].Aciklama = "LL1";
Sistem.Cizgiler[5].ActiveBool = false;

// ===============================================================================================
// PERFORMANS PANELİ (3 KUTULU PRO SÜRÜM - Gelişmiş Metrikler Eklendi)
// ===============================================================================================
bool GetiriTarihcesiGoster = true;
bool DetayPerformans = true;
string GetiriTarih = "01.01.2024";
float GetiriKayma = 0.0f;

//-----------------------------------------------
var renk = Color.Black;
var Grafikler = Sistem.GrafikVerileri;

DateTime dateBaslangicTarih = (DateTime.ParseExact(GetiriTarih, "dd.MM.yyyy", System.Globalization.CultureInfo.CurrentCulture) > Grafikler[0].Date) ? (DateTime.ParseExact(GetiriTarih, "dd.MM.yyyy", System.Globalization.CultureInfo.CurrentCulture)) : Grafikler[0].Date;
Sistem.GetiriHesapla(dateBaslangicTarih.ToString("dd.MM.yyyy"), GetiriKayma); 

int InitBarNo = 0;
for (int i = 0; i < Grafikler.Count; i++)
{
    if (Grafikler[i].Date >= dateBaslangicTarih) { InitBarNo = i; break; }
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

for (int i = 1; i < Grafikler.Count; i++)
{
    float anlikKapananIslemKari = 0;
    bool islemKapandi = false;

    if (Grafikler[i].Date >= dateBaslangicTarih)
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
        if (anlikDD > GercekMaxDD) { GercekMaxDD = anlikDD; GercekMaxDDTarih = Grafikler[i].Date; }
    }
}

// ------------------------------------------------------------------------------------------
// 2. ADIM: "BUGÜN" CANLI GETİRİ HESABI
// ------------------------------------------------------------------------------------------
var DateBugun = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
var DateDunSonBarNo = 0;
for (int i = Grafikler.Count - 1; i > 0; i--)
{
    if (Grafikler[i].Date < DateBugun) { DateDunSonBarNo = i; break; }
}

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
{
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
    {
        int daysToSubtract = (int)DateTime.Now.DayOfWeek - (int)DayOfWeek.Monday;
        if (daysToSubtract < 0) daysToSubtract += 7; 
        
        var DateHaftaBasi = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddDays(-daysToSubtract);
        var DateHaftaBasiBarNo = 0;
        for (int i = Grafikler.Count - 1; i > 0; i--) if (Grafikler[i].Date < DateHaftaBasi) { DateHaftaBasiBarNo = i; break; }
        var kzBuHafta = (SanalGetiri[Grafikler.Count - 1] - SanalGetiri[DateHaftaBasiBarNo]).ToString("0.0");

        var DateBuAy = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        var DateBuAyBarNo = 0;
        for (int i = Grafikler.Count - 1; i > 0; i--) if (Grafikler[i].Date < DateBuAy) { DateBuAyBarNo = i; break; }
        var kzbuay = (SanalGetiri[Grafikler.Count - 1] - SanalGetiri[DateBuAyBarNo]).ToString("0.0");

        var Date30 = DateTime.Now.AddDays(-30);
        var Date30BarNo = 0;
        for (int i = Grafikler.Count - 1; i > 0; i--) if (Grafikler[i].Date <= Date30) { Date30BarNo = i; break; }
        var kz30 = (SanalGetiri[Grafikler.Count - 1] - SanalGetiri[Date30BarNo]).ToString("0.0");

        var Date60 = DateTime.Now.AddDays(-60);
        var Date60BarNo = 0;
        for (int i = Grafikler.Count - 1; i > 0; i--) if (Grafikler[i].Date <= Date60) { Date60BarNo = i; break; }
        var kz60 = (SanalGetiri[Grafikler.Count - 1] - SanalGetiri[Date60BarNo]).ToString("0.0");

        var Date90 = DateTime.Now.AddDays(-90);
        var Date90BarNo = 0;
        for (int i = Grafikler.Count - 1; i > 0; i--) if (Grafikler[i].Date <= Date90) { Date90BarNo = i; break; }
        var kz90 = (SanalGetiri[Grafikler.Count - 1] - SanalGetiri[Date90BarNo]).ToString("0.0");

        var Date180 = DateTime.Now.AddDays(-180);
        var Date180BarNo = 0;
        for (int i = Grafikler.Count - 1; i > 0; i--) if (Grafikler[i].Date <= Date180) { Date180BarNo = i; break; }
        var kz180 = (SanalGetiri[Grafikler.Count - 1] - SanalGetiri[Date180BarNo]).ToString("0.0");

        var DateYilBasi = new DateTime(DateTime.Now.Year, 1, 1);
        var DateYilBasiBarNo = 0;
        for (int i = Grafikler.Count - 1; i > 0; i--) if (Grafikler[i].Date < DateYilBasi) { DateYilBasiBarNo = i; break; }
        var kzBuYil = (SanalGetiri[Grafikler.Count - 1] - SanalGetiri[DateYilBasiBarNo]).ToString("0.0");

        var Date1Yil = DateTime.Now.AddYears(-1);
        var Date1YilBarNo = 0;
        for (int i = Grafikler.Count - 1; i > 0; i--) if (Grafikler[i].Date <= Date1Yil) { Date1YilBarNo = i; break; }
        var kz1Yil = (SanalGetiri[Grafikler.Count - 1] - SanalGetiri[Date1YilBarNo]).ToString("0.0");

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

        // Yeni kutunun X ekseni ayarlandı (475'ten başlıyor)
        Sistem.Dortgen(2, 475, ilksatirY - 8, 215, 115, Color.Black, Color.Black, Color.White);
        Sistem.GradientYaziEkle(Labels3, 2, 485, ilksatirY, Color.White, Color.White, "Tahoma", 10);
        Sistem.GradientYaziEkle(Results3, 2, 605, ilksatirY, Color.Yellow, Color.DarkOrange, "Tahoma", 10);
    }
}

