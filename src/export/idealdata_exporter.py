# -*- coding: utf-8 -*-
"""
IdealData Export Module
-----------------------
Optimizasyon sonuçlarını IdealData uyumlu strateji ve robot kodlarına çevirir.

Kullanım:
    exporter = IdealDataExporter(symbol="VIP'VIP-X030", period="5")
    exporter.export_strategy1(params1, "ENDEKS")
    exporter.export_strategy2(params2, "ENDEKS")
    exporter.export_combined_robot()
"""

from pathlib import Path
from datetime import datetime
from typing import Dict, Any, Optional
import json


class IdealDataExporter:
    """Strateji ve robot kodu export sınıfı."""
    
    def __init__(
        self,
        symbol: str = "VIP'VIP-X030",
        period: str = "5",
        output_dir: str = None
    ):
        """
        Args:
            symbol: IdealData sembol adı (örn: VIP'VIP-X030)
            period: Grafik periyodu (1, 5, 15, 60, G)
            output_dir: Çıktı klasörü (None ise proje/output/idealdata)
        """
        self.symbol = symbol
        self.period = period
        self.symbol_short = symbol.replace("VIP'VIP-", "").replace("VIP'", "")
        
        if output_dir:
            self.output_dir = Path(output_dir)
        else:
            self.output_dir = Path(__file__).parent.parent.parent / "output" / "idealdata"
        
        self.output_dir.mkdir(parents=True, exist_ok=True)
        
        # Oluşturulan dosya isimleri
        self.strategy1_filename: Optional[str] = None
        self.strategy2_filename: Optional[str] = None
        self.strategy3_filename: Optional[str] = None
        self.robot_filename: Optional[str] = None
    
    def _generate_filename(self, strategy_num: int, vade_tipi: str) -> str:
        """Sistematik dosya adı oluşturur."""
        # Format: S{num}_{sembol}_{periyot}_{vade}_{tarih}
        date_str = datetime.now().strftime("%Y%m%d")
        filename = f"S{strategy_num}_{self.symbol_short}_{self.period}DK_{vade_tipi}_{date_str}"
        return filename
    
    def export_strategy1(
        self, 
        params: Dict[str, Any], 
        vade_tipi: str = "ENDEKS"
    ) -> str:
        """
        Strateji 1 (Yatay Filtre + Scoring) kodunu export eder.
        
        Args:
            params: Optimizasyon parametreleri
            vade_tipi: "ENDEKS" veya "SPOT"
            
        Returns:
            Oluşturulan dosya yolu
        """
        filename = self._generate_filename(1, vade_tipi)
        self.strategy1_filename = filename
        
        code = self._generate_strategy1_code(params, vade_tipi)
        
        filepath = self.output_dir / f"{filename}.cs"
        filepath.write_text(code, encoding='utf-8')
        
        # Parametreleri JSON olarak da kaydet
        params_path = self.output_dir / f"{filename}_params.json"
        params_path.write_text(json.dumps(params, indent=2, default=str), encoding='utf-8')
        
        return str(filepath)
    
    def export_strategy2(
        self, 
        params: Dict[str, Any], 
        vade_tipi: str = "ENDEKS"
    ) -> str:
        """
        Strateji 2 (ARS Trend) kodunu export eder.
        
        Args:
            params: Optimizasyon parametreleri
            vade_tipi: "ENDEKS" veya "SPOT"
            
        Returns:
            Oluşturulan dosya yolu
        """
        filename = self._generate_filename(2, vade_tipi)
        self.strategy2_filename = filename
        
        code = self._generate_strategy2_code(params, vade_tipi)
        
        filepath = self.output_dir / f"{filename}.cs"
        filepath.write_text(code, encoding='utf-8')
        
        # Parametreleri JSON olarak da kaydet
        params_path = self.output_dir / f"{filename}_params.json"
        params_path.write_text(json.dumps(params, indent=2, default=str), encoding='utf-8')
        
        return str(filepath)
    


    def _get_performance_panel_code(self) -> str:
        """Kullanıcının talep ettiği standart performans paneli kodu."""
        return '''// ===============================================================================================
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

if (Sistem.Parametreler.Count > 3 && Sistem.Parametreler[3] == "X")
{
    int ilksatirY = 33;
    var Sure = ((DateTime.Now - dateBaslangicTarih).TotalDays / 30.4);
    var SureTxt = Sure.ToString("0.0");
    
    var kzSure = SanalGetiri[Grafikler.Count - 1].ToString("0.0");
    var kzbugun = gunluk_getiri.ToString("0.0");
    var yuzde_kz = (O[InitBarNo] != 0) ? (( SanalGetiri[Grafikler.Count - 1] * 100.0f ) / O[InitBarNo]) : 0;
    var kzSure_yuzde = "  %" + yuzde_kz.ToString("0.0");

    string ToplamIslem = Sistem.GetiriToplamIslem.ToString("0");
    double safeSure = Sure <= 0 ? 0.001 : Sure;
    string OrtalamaIslem = (((double)Sistem.GetiriToplamIslem) / safeSure).ToString("0");
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
'''

    def _generate_strategy1_code(self, params: Dict[str, Any], vade_tipi: str) -> str:
        """Strateji 1 IdealData kodu oluşturur (v4.1 - Bayram/Vade Yönetimi dahil)."""
        
        # Varsayılan parametreler (v4.1) - TÜM parametreler dahil
        # Period parametreleri int() ile sarmalanarak integer olmaları garanti edilir
        p = {
            'min_score': int(params.get('min_score', 3)),
            'exit_score': int(params.get('exit_score', 3)),
            'ars_period': int(params.get('ars_period', 3)),
            'ars_k': params.get('ars_k', 0.01),
            'adx_period': int(params.get('adx_period', 17)),
            'adx_threshold': params.get('adx_threshold', 25.0),
            'netlot_threshold': params.get('netlot_threshold', 20),
            'netlot_period': int(params.get('netlot_period', 5)),
            'macdv_short': int(params.get('macdv_short', 13)),
            'macdv_long': int(params.get('macdv_long', 28)),
            'macdv_signal': int(params.get('macdv_signal', 8)),
            'macdv_threshold': params.get('macdv_threshold', 0),
            # Yatay Filtre parametreleri
            'yatay_ars_bars': int(params.get('yatay_ars_bars', 10)),
            'ars_mesafe_threshold': params.get('ars_mesafe_threshold', 0.25),
            'yatay_adx_threshold': params.get('yatay_adx_threshold', 20.0),
            'bb_period': int(params.get('bb_period', 20)),
            'bb_std': params.get('bb_std', 2.0),
            'bb_width_multiplier': params.get('bb_width_multiplier', 0.8),
            'bb_avg_period': int(params.get('bb_avg_period', 50)),
            'filter_score_threshold': int(params.get('filter_score_threshold', 2)),
            'yon_modu': params.get('yon_modu', 'CIFT')
        }

        

        code = f'''// ===============================================================================================
// STRATEJI 1: GATEKEEPER (MACDV + ARS + ADX + NETLOT)
// ===============================================================================================
// Sembol: {self.symbol}
// Periyot: {self.period} dakika
// Vade Tipi: {vade_tipi}
// Oluşturma: {datetime.now().strftime("%Y-%m-%d %H:%M")}
// ===============================================================================================

// --- PARAMETRELER ---
var MIN_ONAY_SKORU = {p['min_score']};
var CIKIS_HASSASIYETI = {p['exit_score']};
var ARS_PERIYOT = {p['ars_period']};
var ARS_K = {p['ars_k']};
var ADX_PERIOD = {p['adx_period']};
var ADX_ESIK = {p['adx_threshold']}f;
var NETLOT_ESIK = {p['netlot_threshold']}f;
var NETLOT_PERIOD = {p['netlot_period']};
var MACDV_K = {p['macdv_short']};
var MACDV_U = {p['macdv_long']};
var MACDV_SIG = {p['macdv_signal']};
var MACDV_ESIK = {p['macdv_threshold']}f;

// --- YATAY FİLTRE PARAMETRELERİ ---
var YATAY_ARS_BARS = {p['yatay_ars_bars']};
var ARS_MESAFE_ESIK = {p['ars_mesafe_threshold']}f;
var YATAY_ADX_ESIK = {p['yatay_adx_threshold']}f;
var BB_PERIOD = {p['bb_period']};
var BB_STD = {p['bb_std']}f;
var BB_WIDTH_MULT = {p['bb_width_multiplier']}f;
var BB_AVG_PERIOD = {p['bb_avg_period']};
var FILTRE_SKOR_ESIK = {p['filter_score_threshold']};

// --- VADE TİPİ & YÖN MODU ---
string VadeTipi = "{vade_tipi}";
string YON_MODU = "{p['yon_modu']}";


// ===============================================================================================
// DİNAMİK BAYRAM TARİHLERİ (2024-2030)
// ===============================================================================================
int yil = DateTime.Now.Year;
DateTime Ramazan, Kurban;

switch(yil)
{{
    case 2024: Ramazan = new DateTime(2024, 4, 10); Kurban = new DateTime(2024, 6, 16); break;
    case 2025: Ramazan = new DateTime(2025, 3, 30); Kurban = new DateTime(2025, 6, 6); break;
    case 2026: Ramazan = new DateTime(2026, 3, 20); Kurban = new DateTime(2026, 5, 27); break;
    case 2027: Ramazan = new DateTime(2027, 3, 9); Kurban = new DateTime(2027, 5, 16); break;
    case 2028: Ramazan = new DateTime(2028, 2, 26); Kurban = new DateTime(2028, 5, 5); break;
    case 2029: Ramazan = new DateTime(2029, 2, 14); Kurban = new DateTime(2029, 4, 24); break;
    case 2030: Ramazan = new DateTime(2030, 2, 3); Kurban = new DateTime(2030, 4, 13); break;
    default: Ramazan = new DateTime(yil, 3, 15); Kurban = new DateTime(yil, 5, 20); break;
}}

// Optimizasyon için tüm yıllar
DateTime R2024 = new DateTime(2024, 4, 10); DateTime K2024 = new DateTime(2024, 6, 16);
DateTime R2025 = new DateTime(2025, 3, 30); DateTime K2025 = new DateTime(2025, 6, 6);
DateTime R2026 = new DateTime(2026, 3, 20); DateTime K2026 = new DateTime(2026, 5, 27);
DateTime R2027 = new DateTime(2027, 3, 9); DateTime K2027 = new DateTime(2027, 5, 16);

string[] resmiTatiller = new string[] {{ "01.01","04.23","05.01","05.19","07.15","08.30","10.29" }};

var V = Sistem.GrafikVerileri;
var O = Sistem.GrafikFiyatSec("Acilis");
var H = Sistem.GrafikFiyatSec("Yuksek");
var L = Sistem.GrafikFiyatSec("Dusuk");
var C = Sistem.GrafikFiyatSec("Kapanis");
var T = Sistem.GrafikFiyatSec("Tipik");

// ===============================================================================================
// VADE SONU İŞ GÜNÜ HESAPLAMA
// ===============================================================================================
Func<DateTime, DateTime> VadeSonuIsGunu = (dt) =>
{{
    var aySonu = new DateTime(dt.Year, dt.Month, DateTime.DaysInMonth(dt.Year, dt.Month));
    var d = aySonu;
    
    for (int k = 0; k < 15; k++)
    {{
        if (d.DayOfWeek == DayOfWeek.Saturday || d.DayOfWeek == DayOfWeek.Sunday)
        {{ d = d.AddDays(-1); continue; }}
        
        string mmdd = d.ToString("MM.dd");
        bool tatil = false;
        for (int t = 0; t < resmiTatiller.Length; t++)
            if (resmiTatiller[t] == mmdd) {{ tatil = true; break; }}
        if (tatil) {{ d = d.AddDays(-1); continue; }}
        
        if ((d >= R2024 && d <= R2024.AddDays(3)) || (d >= K2024 && d <= K2024.AddDays(4)) ||
            (d >= R2025 && d <= R2025.AddDays(3)) || (d >= K2025 && d <= K2025.AddDays(4)) ||
            (d >= R2026 && d <= R2026.AddDays(3)) || (d >= K2026 && d <= K2026.AddDays(4)) ||
            (d >= R2027 && d <= R2027.AddDays(3)) || (d >= K2027 && d <= K2027.AddDays(4)))
        {{ d = d.AddDays(-1); continue; }}
        
        break;
    }}
    return d.Date;
}};

// --- 1. ARS ---
var ARS_EMA = Sistem.MA(T, "Exp", ARS_PERIYOT);
var ARS = Sistem.Liste(0);
for (int i = 1; i < Sistem.BarSayisi; i++) {{
    float altBand = (float)(ARS_EMA[i] * (1 - ARS_K));
    float ustBand = (float)(ARS_EMA[i] * (1 + ARS_K));
    if (altBand > ARS[i - 1]) ARS[i] = altBand;
    else if (ustBand < ARS[i - 1]) ARS[i] = ustBand;
    else ARS[i] = ARS[i - 1];
}}

// --- 2. MACDV ---
var EMA_S = Sistem.MA(C, "Exp", MACDV_K);
var EMA_L = Sistem.MA(C, "Exp", MACDV_U);

var TR_List = Sistem.Liste(0);
for (int i = 1; i < Sistem.BarSayisi; i++) {{
    float hl = H[i] - L[i];
    float hc = Math.Abs(H[i] - C[i-1]);
    float lc = Math.Abs(L[i] - C[i-1]);
    TR_List[i] = Math.Max(hl, Math.Max(hc, lc));
}}
var ATRe = Sistem.MA(TR_List, "Exp", MACDV_U);

var MACDV = Sistem.Liste(0);
for (int i = 0; i < Sistem.BarSayisi; i++) {{
    if (ATRe[i] != 0)
        MACDV[i] = ((EMA_S[i] - EMA_L[i]) / ATRe[i]) * 100;
}}
var MACDV_Sinyal = Sistem.MA(MACDV, "Exp", MACDV_SIG);

// --- 3. YATAY FILTRE ---
var ARS_Degisim = Sistem.Liste(0);
for (int i = YATAY_ARS_BARS; i < Sistem.BarSayisi; i++) {{
    bool arsAyni = true;
    for (int j = 1; j <= YATAY_ARS_BARS; j++)
        if (ARS[i] != ARS[i - j]) {{ arsAyni = false; break; }}
    ARS_Degisim[i] = arsAyni ? 0 : 1;
}}

var ARS_Mesafe = Sistem.Liste(0);
for (int i = 1; i < Sistem.BarSayisi; i++)
    ARS_Mesafe[i] = Math.Abs(C[i] - ARS[i]) / ARS[i] * 100;

var ADX14 = Sistem.ADX(ADX_PERIOD);

var BBUp = Sistem.BollingerUp("Simple", BB_PERIOD, BB_STD);
var BBDown = Sistem.BollingerDown("Simple", BB_PERIOD, BB_STD);
var BBMid = Sistem.BollingerMid("Simple", BB_PERIOD, BB_STD);
var BBWidth = Sistem.Liste(0);
for (int i = 1; i < Sistem.BarSayisi; i++)
    if (BBMid[i] != 0) BBWidth[i] = ((BBUp[i] - BBDown[i]) / BBMid[i]) * 100;
var BBWidth_Avg = Sistem.MA(BBWidth, "Simple", BB_AVG_PERIOD);

var YatayFiltre = Sistem.Liste(0);
for (int i = BB_AVG_PERIOD; i < Sistem.BarSayisi; i++) {{
    int skor = 0;
    if (ARS_Degisim[i] == 1) skor++;
    if (ARS_Mesafe[i] > ARS_MESAFE_ESIK) skor++;
    if (ADX14[i] > YATAY_ADX_ESIK) skor++;
    if (BBWidth[i] > BBWidth_Avg[i] * BB_WIDTH_MULT) skor++;
    YatayFiltre[i] = (skor >= FILTRE_SKOR_ESIK) ? 1 : 0;
}}

// --- 4. NET HACİM ---
var NetLot = Sistem.Liste(0);
for (int i = 1; i < Sistem.BarSayisi; i++) {{
    float barHacim = (H[i] - L[i]) > 0 ? (C[i] - O[i]) / (H[i] - L[i]) : 0;
    NetLot[i] = barHacim * 100;
}}
var NetLot_MA = Sistem.MA(NetLot, "Simple", NETLOT_PERIOD);


// --- SINYAL ---
for (int i = 1; i < V.Count; i++) Sistem.Yon[i] = "";
var SonYon = "";

int vadeCooldownBar = Math.Max(ARS_PERIYOT, Math.Max(ADX_PERIOD, Math.Max(MACDV_K, MACDV_U))) + 10;
int warmupBars = Math.Max(50, vadeCooldownBar);
int warmupBaslangicBar = -999;
bool warmupAktif = false;
bool arefeFlat = false;

for (int i = warmupBars; i < Sistem.BarSayisi; i++)
{{
    var Sinyal = "";
    var dt = V[i].Date;
    var t = dt.TimeOfDay;
    
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
    {{
        if (SonYon != "F") Sinyal = "F";
        warmupAktif = true;
        warmupBaslangicBar = -999;
        arefeFlat = false;
    }}
    else if (arefe && !vadeSonuGun && t > new TimeSpan(11,30,0))
    {{
        if (SonYon != "F") Sinyal = "F";
        arefeFlat = true;
    }}
    else if (vadeSonuGun && t > new TimeSpan(17,40,0))
    {{
        if (SonYon != "F") Sinyal = "F";
        warmupAktif = true;
        warmupBaslangicBar = -999;
        arefeFlat = false;
    }}
    
    if (Sinyal == "F")
    {{
        if (SonYon != Sinyal) {{ Sistem.Yon[i] = Sinyal; SonYon = Sinyal; }}
        continue;
    }}
    if ((arefe && t > new TimeSpan(11,30,0)) || (vadeSonuGun && !arefe && t > new TimeSpan(17,40,0)))
        continue;
    
    if (warmupAktif && warmupBaslangicBar == -999)
    {{
        bool yeniSeansBaslangici = false;
        if (aksamSeansi && i > 0 && V[i-1].Date.TimeOfDay < new TimeSpan(19,0,0))
            yeniSeansBaslangici = true;
        if (gunSeansi && t >= new TimeSpan(9,30,0) && t < new TimeSpan(9,35,0))
            if (i > 0 && dt.Date != V[i-1].Date.Date)
                yeniSeansBaslangici = true;
        if (yeniSeansBaslangici)
            warmupBaslangicBar = i;
    }}
    
    if (warmupAktif && warmupBaslangicBar > 0)
    {{
        if ((i - warmupBaslangicBar) < vadeCooldownBar) continue;
        else warmupAktif = false;
    }}
    
    if (arefeFlat && i > 0 && dt.Date != V[i-1].Date.Date)
        arefeFlat = false;
    
    // --- SKORLAMA ---
    int longScore = 0;
    int shortScore = 0;

    if (C[i] > ARS[i]) longScore++; else if (C[i] < ARS[i]) shortScore++;
    if (MACDV[i] > (MACDV_Sinyal[i] + MACDV_ESIK)) longScore++; else if (MACDV[i] < (MACDV_Sinyal[i] - MACDV_ESIK)) shortScore++;
    if (NetLot_MA[i] > NETLOT_ESIK) longScore++; else if (NetLot_MA[i] < -NETLOT_ESIK) shortScore++;
    if (ADX14[i] > ADX_ESIK) {{ longScore++; shortScore++; }}


    // --- ÇIKIŞ MANTIĞI ---
    if (SonYon == "A") {{
        if (C[i] < ARS[i] || shortScore >= CIKIS_HASSASIYETI) Sinyal = "F";
    }}
    else if (SonYon == "S") {{
        if (C[i] > ARS[i] || longScore >= CIKIS_HASSASIYETI) Sinyal = "F";
    }}
    
    // --- GİRİŞ MANTIĞI ---
    if (Sinyal == "" && SonYon != "A" && SonYon != "S") {{
        if (YatayFiltre[i] == 1) {{
            if (longScore >= MIN_ONAY_SKORU && shortScore < 2 && YON_MODU != "SADECE_SAT") Sinyal = "A";
            else if (shortScore >= MIN_ONAY_SKORU && longScore < 2 && YON_MODU != "SADECE_AL") Sinyal = "S";
        }}
    }}
    
    // --- POZİSYON GÜNCELLEME ---
    if (Sinyal != "" && SonYon != Sinyal) {{
        SonYon = Sinyal;
        Sistem.Yon[i] = SonYon;
    }}
}}

// --- CIZIMLER ---
Sistem.Cizgiler[3].Deger = ARS;
Sistem.Cizgiler[3].Aciklama = "ARS";
Sistem.Cizgiler[3].ActiveBool = true;
Sistem.Cizgiler[3].Renk = Color.Yellow;
Sistem.Cizgiler[3].Kalinlik = 2;

Sistem.Cizgiler[4].Deger = MACDV;
Sistem.Cizgiler[4].Aciklama = "MACDV";
Sistem.Cizgiler[4].ActiveBool = false;

var son = Sistem.BarSayisi - 1;
string info = "MACDV: " + Sistem.SayiYuvarla(MACDV[son], 2) + " Sig: " + Sistem.SayiYuvarla(MACDV_Sinyal[son], 2);
Sistem.Dortgen(1, 100, 300, 200, 50, Color.Black, Color.White, Color.Black);
Sistem.YaziEkle(info, 1, 15, 35, Color.Yellow, "Tahoma", 10);

{self._get_performance_panel_code()}
'''
        return code

    
    def _generate_strategy2_code(self, params: Dict[str, Any], vade_tipi: str) -> str:
        """Strateji 2 IdealData kodu oluşturur (v4.1 - Bayram/Vade/Volume/DC Exit dahil)."""
        
        p = {
            'ars_ema': int(params.get('ars_ema_period', 3)),
            'ars_atr_p': int(params.get('ars_atr_period', 10)),
            'ars_atr_m': params.get('ars_atr_mult', 0.5),
            'ars_min_band': params.get('ars_min_band', 0.002),
            'ars_max_band': params.get('ars_max_band', 0.015),
            'momentum_p': int(params.get('momentum_period', 5)),
            'momentum_threshold': params.get('momentum_threshold', 100.0),
            'momentum_base': params.get('momentum_base', 200.0),
            'breakout_p': int(params.get('breakout_period', 10)),
            'mfi_p': int(params.get('mfi_period', 14)),
            'mfi_hhv_p': int(params.get('mfi_hhv_period', 14)),
            'mfi_llv_p': int(params.get('mfi_llv_period', 14)),
            'volume_hhv_p': int(params.get('volume_hhv_period', 14)),
            'atr_exit_p': int(params.get('atr_exit_period', 14)),
            'atr_sl_mult': params.get('atr_sl_mult', 2.0),
            'atr_tp_mult': params.get('atr_tp_mult', 5.0),
            'atr_trail_mult': params.get('atr_trail_mult', 2.0),
            'exit_confirm_mult': params.get('exit_confirm_mult', 1.0),
            'volume_mult': params.get('volume_mult', 0.8),
            'yon_modu': params.get('yon_modu', 'CIFT')
        }
        
        code = f'''// ===============================================================================================
// STRATEJİ 2: ARS TREND TAKİP SİSTEMİ v4.1
// ===============================================================================================
// Sembol: {self.symbol}
// Periyot: {self.period} dakika
// Vade Tipi: {vade_tipi}
// Oluşturma: {datetime.now().strftime("%Y-%m-%d %H:%M")}
// ===============================================================================================

// --- VADE TİPİ & YÖN MODU ---
string VadeTipi = "{vade_tipi}";
string YON_MODU = "{p['yon_modu']}";

// --- ATR EXIT PARAMETRELER ---
int ATR_Exit_Period = {p['atr_exit_p']};
double ATR_SL_Mult = {p['atr_sl_mult']};
double ATR_TP_Mult = {p['atr_tp_mult']};
double ATR_Trail_Mult = {p['atr_trail_mult']};
int Exit_Confirm_Bars = {p.get('exit_confirm_bars', 3)};
double Exit_Confirm_Mult = {p['exit_confirm_mult']};

// --- ARS PARAMETRELER ---
int ARS_EMA_Period = {p['ars_ema']};
int ARS_ATR_Period = {p['ars_atr_p']};
double ARS_ATR_Mult = {p['ars_atr_m']};
double ARS_Min_Band = {p['ars_min_band']};
double ARS_Max_Band = {p['ars_max_band']};

// --- GİRİŞ SİNYALİ PARAMETRELER ---
int MOMENTUM_Period = {p['momentum_p']};
double MOMENTUM_THRESHOLD = {p['momentum_threshold']};
double MOMENTUM_BASE = {p['momentum_base']};
int BREAKOUT_Period = {p['breakout_p']};
double VOLUME_MULT = {p['volume_mult']};

// ===============================================================================================
// DİNAMİK BAYRAM TARİHLERİ (2024-2030)
// ===============================================================================================
int yil = DateTime.Now.Year;
DateTime Ramazan, Kurban;

switch(yil)
{{
    case 2024: Ramazan = new DateTime(2024, 4, 10); Kurban = new DateTime(2024, 6, 16); break;
    case 2025: Ramazan = new DateTime(2025, 3, 30); Kurban = new DateTime(2025, 6, 6); break;
    case 2026: Ramazan = new DateTime(2026, 3, 20); Kurban = new DateTime(2026, 5, 27); break;
    case 2027: Ramazan = new DateTime(2027, 3, 9); Kurban = new DateTime(2027, 5, 16); break;
    case 2028: Ramazan = new DateTime(2028, 2, 26); Kurban = new DateTime(2028, 5, 5); break;
    case 2029: Ramazan = new DateTime(2029, 2, 14); Kurban = new DateTime(2029, 4, 24); break;
    case 2030: Ramazan = new DateTime(2030, 2, 3); Kurban = new DateTime(2030, 4, 13); break;
    default: Ramazan = new DateTime(yil, 3, 15); Kurban = new DateTime(yil, 5, 20); break;
}}

DateTime R2024 = new DateTime(2024, 4, 10); DateTime K2024 = new DateTime(2024, 6, 16);
DateTime R2025 = new DateTime(2025, 3, 30); DateTime K2025 = new DateTime(2025, 6, 6);
DateTime R2026 = new DateTime(2026, 3, 20); DateTime K2026 = new DateTime(2026, 5, 27);
DateTime R2027 = new DateTime(2027, 3, 9); DateTime K2027 = new DateTime(2027, 5, 16);

string[] resmiTatiller = new string[] {{ "01.01","04.23","05.01","05.19","07.15","08.30","10.29" }};

// ===============================================================================================
// VERİ HAZIRLIĞI
// ===============================================================================================
var V = Sistem.GrafikVerileri;
var O = Sistem.GrafikFiyatSec("Acilis");
var H = Sistem.GrafikFiyatSec("Yuksek");
var L = Sistem.GrafikFiyatSec("Dusuk");
var C = Sistem.GrafikFiyatSec("Kapanis");
var T = Sistem.GrafikFiyatSec("Tipik");
var Lot = Sistem.GrafikFiyatSec("Lot");

// ===============================================================================================
// ARS HESAPLAMA
// ===============================================================================================
var ATR = Sistem.AverageTrueRange(ARS_ATR_Period);
var ARS_EMA = Sistem.MA(T, "Exp", ARS_EMA_Period);
var ARS = Sistem.Liste(0);

for (int i = 1; i < Sistem.BarSayisi; i++)
{{
    float dinamikK;
    if (ARS_ATR_Mult > 0) {{
        dinamikK = (ATR[i] / ARS_EMA[i]) * (float)ARS_ATR_Mult;
        dinamikK = Math.Max((float)ARS_Min_Band, Math.Min((float)ARS_Max_Band, dinamikK));
    }} else {{
        dinamikK = (float)ARS_Min_Band;
    }}
    
    float altBand = ARS_EMA[i] * (1 - dinamikK);
    float ustBand = ARS_EMA[i] * (1 + dinamikK);
    
    if (altBand > ARS[i - 1])
        ARS[i] = altBand;
    else if (ustBand < ARS[i - 1])
        ARS[i] = ustBand;
    else
        ARS[i] = ARS[i - 1];
    
    float roundStep = ARS_ATR_Mult > 0 ? Math.Max(0.01f, ATR[i] * 0.1f) : 0.025f;
    ARS[i] = Sistem.SayiYuvarla(ARS[i], roundStep);
}}

// TREND BELİRLEME
var TrendYonu = Sistem.Liste(0);
for (int i = 1; i < Sistem.BarSayisi; i++)
{{
    if (C[i] > ARS[i]) TrendYonu[i] = 1;
    else if (C[i] < ARS[i]) TrendYonu[i] = -1;
    else TrendYonu[i] = TrendYonu[i-1];
}}

var ATR_Exit = Sistem.AverageTrueRange(ATR_Exit_Period);

// GİRİŞ SİNYAL İNDİKATÖRLERİ
var Momentum = Sistem.Momentum(MOMENTUM_Period);
var HHV = Sistem.HHV(BREAKOUT_Period, "Yuksek");
var LLV = Sistem.LLV(BREAKOUT_Period, "Dusuk");

var MFI = Sistem.MoneyFlowIndex({p['mfi_p']});
var MFI_HHV = Sistem.HHV({p['mfi_hhv_p']}, MFI);
var MFI_LLV = Sistem.LLV({p['mfi_llv_p']}, MFI);

var Vol_HHV = Sistem.HHV({p['volume_hhv_p']}, "Lot");

// ===============================================================================================
// VADE SONU İŞ GÜNÜ HESAPLAMA
// ===============================================================================================
Func<DateTime, DateTime> VadeSonuIsGunu = (dt) =>
{{
    var aySonu = new DateTime(dt.Year, dt.Month, DateTime.DaysInMonth(dt.Year, dt.Month));
    var d = aySonu;
    
    for (int k = 0; k < 15; k++)
    {{
        if (d.DayOfWeek == DayOfWeek.Saturday || d.DayOfWeek == DayOfWeek.Sunday)
        {{ d = d.AddDays(-1); continue; }}
        
        string mmdd = d.ToString("MM.dd");
        bool tatil = false;
        for (int t = 0; t < resmiTatiller.Length; t++)
            if (resmiTatiller[t] == mmdd) {{ tatil = true; break; }}
        if (tatil) {{ d = d.AddDays(-1); continue; }}
        
        if ((d >= R2024 && d <= R2024.AddDays(3)) || (d >= K2024 && d <= K2024.AddDays(4)) ||
            (d >= R2025 && d <= R2025.AddDays(3)) || (d >= K2025 && d <= K2025.AddDays(4)) ||
            (d >= R2026 && d <= R2026.AddDays(3)) || (d >= K2026 && d <= K2026.AddDays(4)) ||
            (d >= R2027 && d <= R2027.AddDays(3)) || (d >= K2027 && d <= K2027.AddDays(4)))
        {{ d = d.AddDays(-1); continue; }}
        
        break;
    }}
    return d.Date;
}};

// ===============================================================================================
// SİNYAL ÜRETİM DÖNGÜSÜ
// ===============================================================================================
for (int i = 1; i < V.Count; i++) Sistem.Yon[i] = "";

var Sinyal = "";
var SonYon = "";

float entryPrice = 0;
int entryBar = 0;
float extremePrice = 0;
int belowArsCount = 0;
int aboveArsCount = 0;

int vadeCooldownBar = Math.Max(ARS_EMA_Period, Math.Max(BREAKOUT_Period, Math.Max(ARS_ATR_Period, MOMENTUM_Period))) + 10;
int warmupBars = vadeCooldownBar;
int warmupBaslangicBar = -999;
bool warmupAktif = false;
bool arefeFlat = false;

for (int i = warmupBars; i < V.Count; i++)
{{
    Sinyal = "";
    var dt = V[i].Date;
    var t = dt.TimeOfDay;
    
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
    {{
        if (SonYon != "F") Sinyal = "F";
        warmupAktif = true;
        warmupBaslangicBar = -999;
        arefeFlat = false;
    }}
    else if (arefe && !vadeSonuGun && t > new TimeSpan(11,30,0))
    {{
        if (SonYon != "F") Sinyal = "F";
        arefeFlat = true;
    }}
    else if (vadeSonuGun && t > new TimeSpan(17,40,0))
    {{
        if (SonYon != "F") Sinyal = "F";
        warmupAktif = true;
        warmupBaslangicBar = -999;
        arefeFlat = false;
    }}
    
    if (Sinyal == "F")
    {{
        if (SonYon != Sinyal) {{ Sistem.Yon[i] = Sinyal; SonYon = Sinyal; }}
        continue;
    }}
    if ((arefe && t > new TimeSpan(11,30,0)) || (vadeSonuGun && !arefe && t > new TimeSpan(17,40,0)))
        continue;
    
    if (warmupAktif && warmupBaslangicBar == -999)
    {{
        bool yeniSeansBaslangici = false;
        if (aksamSeansi && i > 0 && V[i-1].Date.TimeOfDay < new TimeSpan(19,0,0))
            yeniSeansBaslangici = true;
        if (gunSeansi && t >= new TimeSpan(9,30,0) && t < new TimeSpan(9,35,0))
            if (i > 0 && dt.Date != V[i-1].Date.Date)
                yeniSeansBaslangici = true;
        if (yeniSeansBaslangici)
            warmupBaslangicBar = i;
    }}
    
    if (warmupAktif && warmupBaslangicBar > 0)
    {{
        if ((i - warmupBaslangicBar) < vadeCooldownBar) continue;
        else warmupAktif = false;
    }}
    
    if (arefeFlat && i > 0 && dt.Date != V[i-1].Date.Date)
        arefeFlat = false;
    
    // === ÇIKIŞ MANTIĞI (ATR-Based + Double Confirmation) ===
    if (SonYon == "A")
    {{
        if (H[i] > extremePrice) extremePrice = H[i];
        float atr = ATR_Exit[i];
        
        // Double Confirmation: N bar ARS altında + mesafe yeterli
        if (C[i] < ARS[i]) belowArsCount++; else belowArsCount = 0;
        float distanceThreshold = (float)(atr * ARS_ATR_Mult * Exit_Confirm_Mult);
        if (belowArsCount >= Exit_Confirm_Bars && (ARS[i] - C[i]) > distanceThreshold)
            Sinyal = "F";
        
        // Take Profit
        float tpLevel = entryPrice + (float)(atr * ATR_TP_Mult);
        if (C[i] >= tpLevel) Sinyal = "F";
        
        // Stop Loss / Trailing
        float initialStop = entryPrice - (float)(atr * ATR_SL_Mult);
        float trailStop = extremePrice - (float)(atr * ATR_Trail_Mult);
        float stopLevel = Math.Max(initialStop, trailStop);
        if (C[i] < stopLevel) Sinyal = "F";
    }}
    else if (SonYon == "S")
    {{
        if (L[i] < extremePrice) extremePrice = L[i];
        float atr = ATR_Exit[i];
        
        if (C[i] > ARS[i]) aboveArsCount++; else aboveArsCount = 0;
        float distanceThreshold = (float)(atr * ARS_ATR_Mult * Exit_Confirm_Mult);
        if (aboveArsCount >= Exit_Confirm_Bars && (C[i] - ARS[i]) > distanceThreshold)
            Sinyal = "F";
        
        float tpLevel = entryPrice - (float)(atr * ATR_TP_Mult);
        if (C[i] <= tpLevel) Sinyal = "F";
        
        float initialStop = entryPrice + (float)(atr * ATR_SL_Mult);
        float trailStop = extremePrice + (float)(atr * ATR_Trail_Mult);
        float stopLevel = Math.Min(initialStop, trailStop);
        if (C[i] > stopLevel) Sinyal = "F";
    }}
    
    // === GİRİŞ MANTIĞI ===
    if (Sinyal == "" && SonYon != "A" && SonYon != "S")
    {{
        if (TrendYonu[i] == 1 && YON_MODU != "SADECE_SAT")
        {{
            bool yeniZirve = H[i] >= HHV[i-1] && HHV[i] > HHV[i-1];
            bool pozitifMomentum = Momentum[i] > MOMENTUM_THRESHOLD; // momentum > 100 (assuming threshold is 100)
            bool mfiOnay = MFI[i] >= MFI_HHV[i-1];
            bool volumeOnay = Lot[i] >= Vol_HHV[i-1] * (float)VOLUME_MULT;
            if (yeniZirve && pozitifMomentum && mfiOnay && volumeOnay) Sinyal = "A";
        }}
        else if (TrendYonu[i] == -1 && YON_MODU != "SADECE_AL")
        {{
            bool yeniDip = L[i] <= LLV[i-1] && LLV[i] < LLV[i-1];
            bool negatifMomentum = Momentum[i] < MOMENTUM_THRESHOLD; // Fixed from (MOMENTUM_BASE - MOMENTUM_THRESHOLD) to match python mom < 100
            bool mfiOnay = MFI[i] <= MFI_LLV[i-1];
            bool volumeOnay = Lot[i] >= Vol_HHV[i-1] * (float)VOLUME_MULT;
            if (yeniDip && negatifMomentum && mfiOnay && volumeOnay) Sinyal = "S";
        }}
    }}
    
    if (Sinyal != "" && SonYon != Sinyal)
    {{
        if (Sinyal == "A")
        {{
            entryPrice = C[i];
            entryBar = i;
            extremePrice = H[i];
            belowArsCount = 0;
        }}
        else if (Sinyal == "S")
        {{
            entryPrice = C[i];
            entryBar = i;
            extremePrice = L[i];
            aboveArsCount = 0;
        }}
        else if (Sinyal == "F")
        {{
            entryPrice = 0;
            extremePrice = 0;
            belowArsCount = 0;
            aboveArsCount = 0;
        }}
        
        SonYon = Sinyal;
        Sistem.Yon[i] = SonYon;
    }}
}}

// --- GÖSTERGELERİ ÇİZ ---
Sistem.Cizgiler[0].Deger = ARS;
Sistem.Cizgiler[0].Aciklama = "ARS";
Sistem.Cizgiler[0].ActiveBool = true;
Sistem.Cizgiler[0].Renk = Color.Yellow;
Sistem.Cizgiler[0].Kalinlik = 2;

Sistem.Cizgiler[1].Deger = HHV;
Sistem.Cizgiler[1].Aciklama = "HHV";

Sistem.Cizgiler[2].Deger = LLV;
Sistem.Cizgiler[2].Aciklama = "LLV";

// ===============================================================================================
{self._get_performance_panel_code()}
'''
        return code

    def _generate_strategy3_code(self, params: Dict[str, Any], vade_tipi: str) -> str:
        """Strateji 3 (Paradise) IdealData kodu oluşturur."""
        
        # Parametreler
        p = {
            'ema_period': int(params.get('ema_period', 21)),
            'dsma_period': int(params.get('dsma_period', 50)),
            'ma_period': int(params.get('ma_period', 20)),
            'hh_period': int(params.get('hh_period', 25)),
            'vol_hhv_period': int(params.get('vol_hhv_period', 14)),
            'mom_period': int(params.get('mom_period', 60)),
            'mom_alt': params.get('mom_alt', 98.0),
            'mom_ust': params.get('mom_ust', 102.0),
            'atr_period': int(params.get('atr_period', 14)),
            'atr_sl': params.get('atr_sl', 2.0),
            'atr_tp': params.get('atr_tp', 4.0),
            'atr_trail': params.get('atr_trail', 2.5),
            'yon_modu': params.get('yon_modu', 'CIFT'),
        }

        code = f'''// ===============================================================================================
// STRATEJI 3: PARADISE v2.0 (Vade/Tatil Korumalı)
// ===============================================================================================
// Sembol: {self.symbol}
// Periyot: {self.period} dakika
// Vade Tipi: {vade_tipi}
// Olusturma: {datetime.now().strftime("%Y-%m-%d %H:%M")}
// ===============================================================================================

// --- VADE TİPİ ---
string VadeTipi = "{vade_tipi}";
string YON_MODU = "{p['yon_modu']}"; // CIFT veya SADECE_AL

// --- PARAMETRELER ---
var ema_period = {p['ema_period']};
var dsma_period = {p['dsma_period']};
var ma_period = {p['ma_period']};
var hh_period = {p['hh_period']};
var vol_hhv_period = {p['vol_hhv_period']};
var mom_period = {p['mom_period']};
var mom_alt = {p['mom_alt']}f;
var mom_ust = {p['mom_ust']}f;
var atr_period = {p['atr_period']};
var atr_sl = {p['atr_sl']}f;
var atr_tp = {p['atr_tp']}f;
var atr_trail = {p['atr_trail']}f;

// ===============================================================================================
// DİNAMİK BAYRAM TARİHLERİ (2024-2030)
// ===============================================================================================
int yil = DateTime.Now.Year;
DateTime Ramazan, Kurban;

switch(yil)
{{
    case 2024: Ramazan = new DateTime(2024, 4, 10); Kurban = new DateTime(2024, 6, 16); break;
    case 2025: Ramazan = new DateTime(2025, 3, 30); Kurban = new DateTime(2025, 6, 6); break;
    case 2026: Ramazan = new DateTime(2026, 3, 20); Kurban = new DateTime(2026, 5, 27); break;
    case 2027: Ramazan = new DateTime(2027, 3, 9); Kurban = new DateTime(2027, 5, 16); break;
    case 2028: Ramazan = new DateTime(2028, 2, 26); Kurban = new DateTime(2028, 5, 5); break;
    case 2029: Ramazan = new DateTime(2029, 2, 14); Kurban = new DateTime(2029, 4, 24); break;
    case 2030: Ramazan = new DateTime(2030, 2, 3); Kurban = new DateTime(2030, 4, 13); break;
    default: Ramazan = new DateTime(yil, 3, 15); Kurban = new DateTime(yil, 5, 20); break;
}}

DateTime R2024 = new DateTime(2024, 4, 10); DateTime K2024 = new DateTime(2024, 6, 16);
DateTime R2025 = new DateTime(2025, 3, 30); DateTime K2025 = new DateTime(2025, 6, 6);
DateTime R2026 = new DateTime(2026, 3, 20); DateTime K2026 = new DateTime(2026, 5, 27);
DateTime R2027 = new DateTime(2027, 3, 9); DateTime K2027 = new DateTime(2027, 5, 16);

string[] resmiTatiller = new string[] {{ "01.01","04.23","05.01","05.19","07.15","08.30","10.29" }};

var Veriler = Sistem.GrafikVerileri;
var C = Sistem.GrafikFiyatSec("Kapanis");
var H = Sistem.GrafikFiyatSec("Yuksek");
var L = Sistem.GrafikFiyatSec("Dusuk");
var O = Sistem.GrafikFiyatSec("Acilis");
var V = Sistem.GrafikFiyatSec("Lot");

// ===============================================================================================
// VADE SONU İŞ GÜNÜ HESAPLAMA
// ===============================================================================================
Func<DateTime, DateTime> VadeSonuIsGunu = (dt) =>
{{
    var aySonu = new DateTime(dt.Year, dt.Month, DateTime.DaysInMonth(dt.Year, dt.Month));
    var d = aySonu;
    
    for (int k = 0; k < 15; k++)
    {{
        if (d.DayOfWeek == DayOfWeek.Saturday || d.DayOfWeek == DayOfWeek.Sunday)
        {{ d = d.AddDays(-1); continue; }}
        
        string mmdd = d.ToString("MM.dd");
        bool tatil = false;
        for (int t = 0; t < resmiTatiller.Length; t++)
            if (resmiTatiller[t] == mmdd) {{ tatil = true; break; }}
        if (tatil) {{ d = d.AddDays(-1); continue; }}
        
        if ((d >= R2024 && d <= R2024.AddDays(3)) || (d >= K2024 && d <= K2024.AddDays(4)) ||
            (d >= R2025 && d <= R2025.AddDays(3)) || (d >= K2025 && d <= K2025.AddDays(4)) ||
            (d >= R2026 && d <= R2026.AddDays(3)) || (d >= K2026 && d <= K2026.AddDays(4)) ||
            (d >= R2027 && d <= R2027.AddDays(3)) || (d >= K2027 && d <= K2027.AddDays(4)))
        {{ d = d.AddDays(-1); continue; }}
        
        break;
    }}
    return d.Date;
}};

// --- INDIKATOR HESAPLAMALARI ---
var EMA = Sistem.MA(C, "Exp", ema_period);
var DSMA1 = Sistem.MA(C, "Simple", dsma_period);
var DSMA = Sistem.MA(DSMA1, "Simple", dsma_period);
var MA = Sistem.MA(C, "Simple", ma_period);
var MOM = Sistem.Momentum(mom_period);
var ATR = Sistem.AverageTrueRange(atr_period);

var HH = Sistem.HHV(hh_period, "Yuksek");
var LL = Sistem.LLV(hh_period, "Dusuk");
var VOL_HHV = Sistem.HHV(vol_hhv_period, "Lot");

// --- LOOP & SINYAL ---
var SonYon = "";
var Pos = 0; 
var EntryPrice = 0.0f;
var ExtremePrice = 0.0f;
var EntryATR = 0.0f;

for (int i = 1; i < Veriler.Count; i++) Sistem.Yon[i] = "";

int vadeCooldownBar = Math.Max(dsma_period * 2, Math.Max(hh_period, mom_period)) + 10;
int warmupBars = Math.Max(50, vadeCooldownBar);
int warmupBaslangicBar = -999;
bool warmupAktif = false;
bool arefeFlat = false;

for (int i = warmupBars; i < Veriler.Count; i++)
{{
    // --- VADE VE TATİL KONTROLLERİ ---
    string Sinyal = "";
    var dt = Veriler[i].Date;
    var t = dt.TimeOfDay;
    
    bool gunSeansi = t >= new TimeSpan(9,30,0) && t < new TimeSpan(18,15,0);
    bool aksamSeansi = t >= new TimeSpan(19,0,0) && t < new TimeSpan(23,0,0);
    if (!(gunSeansi || aksamSeansi)) continue;

    bool vadeAyi = (VadeTipi == "SPOT") || (dt.Month % 2 == 0);
    bool vadeSonuGun = vadeAyi && (dt.Date == VadeSonuIsGunu(dt));
    
    bool arefe = dt.Date == R2024.AddDays(-1).Date || dt.Date == K2024.AddDays(-1).Date ||
                 dt.Date == R2025.AddDays(-1).Date || dt.Date == K2025.AddDays(-1).Date ||
                 dt.Date == R2026.AddDays(-1).Date || dt.Date == K2026.AddDays(-1).Date ||
                 dt.Date == R2027.AddDays(-1).Date || dt.Date == K2027.AddDays(-1).Date;

    // Vade/Arefe Flat Kuralları
    if (arefe && vadeSonuGun && t > new TimeSpan(11,30,0))
    {{
        if (SonYon != "F") Sinyal = "F";
        warmupAktif = true; warmupBaslangicBar = -999; arefeFlat = false;
    }}
    else if (arefe && !vadeSonuGun && t > new TimeSpan(11,30,0))
    {{
        if (SonYon != "F") Sinyal = "F";
        arefeFlat = true;
    }}
    else if (vadeSonuGun && t > new TimeSpan(17,40,0))
    {{
        if (SonYon != "F") Sinyal = "F";
        warmupAktif = true; warmupBaslangicBar = -999; arefeFlat = false;
    }}
    
    if (Sinyal == "F") {{
        if (SonYon != Sinyal) {{ Sistem.Yon[i] = Sinyal; SonYon = Sinyal; Pos = 0; }}
        continue;
    }}
    
    if ((arefe && t > new TimeSpan(11,30,0)) || (vadeSonuGun && !arefe && t > new TimeSpan(17,40,0))) continue;

    // Warmup Kontrolü
    if (warmupAktif && warmupBaslangicBar == -999) {{
        bool yeniSeans = false;
        if (aksamSeansi && i>0 && Veriler[i-1].Date.TimeOfDay < new TimeSpan(19,0,0)) yeniSeans = true;
        if (gunSeansi && i>0 && dt.Date != Veriler[i-1].Date.Date) yeniSeans = true;
        if (yeniSeans) warmupBaslangicBar = i;
    }}
    if (warmupAktif && warmupBaslangicBar > 0) {{
        if ((i - warmupBaslangicBar) < vadeCooldownBar) continue;
        else warmupAktif = false;
    }}
    if (arefeFlat && i>0 && dt.Date != Veriler[i-1].Date.Date) arefeFlat = false;


    // --- ÇIKIŞ KONTROLLERİ (ATR) ---
    if (Pos == 1)
    {{
        if (C[i] > ExtremePrice) ExtremePrice = C[i];
        
        bool exit = false;
        if (C[i] <= EntryPrice - EntryATR * atr_sl) exit = true; 
        else if (C[i] >= EntryPrice + EntryATR * atr_tp) exit = true; 
        else if (C[i] <= ExtremePrice - EntryATR * atr_trail) exit = true; 
        
        if (exit) Sinyal = "F";
    }}
    else if (Pos == -1)
    {{
        if (C[i] < ExtremePrice) ExtremePrice = C[i];
        
        bool exit = false;
        if (C[i] >= EntryPrice + EntryATR * atr_sl) exit = true; 
        else if (C[i] <= EntryPrice - EntryATR * atr_tp) exit = true; 
        else if (C[i] >= ExtremePrice + EntryATR * atr_trail) exit = true; 
        
        if (exit) Sinyal = "F";
    }}

    // --- GİRİŞ KONTROLLERİ ---
    if (Sinyal == "" && Pos == 0)
    {{
        // Momentum Filtresi: Alt ve Üst bant arasında (sıkışma)
        bool mom_bandinda = MOM[i] > mom_alt && MOM[i] < mom_ust;
        bool vol_ok = V[i] >= VOL_HHV[i-1] * 0.8f;
        
        if (mom_bandinda && vol_ok)
        {{
            // LONG: HH Breakout + EMA > DSMA + C > MA + MOM > 100
            bool hh_ok = H[i] > HH[i-1];
            bool trend_ok = EMA[i] > DSMA[i] && C[i] > MA[i];
            bool mom_ok = MOM[i] > 100; // Bant içinde ama 100 üstü
            
            if (hh_ok && trend_ok && mom_ok)
            {{
                Sinyal = "A";
            }}
            // SHORT: LL Breakdown + EMA < DSMA + C < MA + MOM < 100
            else if (YON_MODU == "CIFT")
            {{
                bool ll_ok = L[i] < LL[i-1];
                bool trend_short = EMA[i] < DSMA[i] && C[i] < MA[i];
                bool mom_short = MOM[i] < 100; // Bant içinde ama 100 altı
                
                if (ll_ok && trend_short && mom_short)
                {{
                    Sinyal = "S";
                }}
            }}
        }}
    }}
    
    // --- POZİSYON GÜNCELLEME ---
    if (Sinyal != "" && SonYon != Sinyal)
    {{
        Sistem.Yon[i] = Sinyal;
        SonYon = Sinyal;
        
        if (Sinyal == "A") {{ Pos = 1; EntryPrice = C[i]; ExtremePrice = C[i]; EntryATR = ATR[i]; }}
        else if (Sinyal == "S") {{ Pos = -1; EntryPrice = C[i]; ExtremePrice = C[i]; EntryATR = ATR[i]; }}
        else if (Sinyal == "F") {{ Pos = 0; }}
    }}
}}

Sistem.Cizgiler[3].Deger = EMA;
Sistem.Cizgiler[4].Deger = DSMA;
Sistem.Cizgiler[5].Deger = MA;

{self._get_performance_panel_code()}
'''
        return code


    
    def _generate_robot_code(self, lot_size: int) -> str:
        """S1 + S2 birleşik robot kodu oluşturur."""
        
        code = f'''// ===============================================================================================
// ROBOT: S1 + S2 BİRLEŞİK İŞLEM ROBOTU
// ===============================================================================================
// Strateji 1: {self.strategy1_filename} (Gatekeeper - Yön Belirler)
// Strateji 2: {self.strategy2_filename} (İşlem Motoru)
// Sembol: {self.symbol}
// Periyot: {self.period} dakika
// Lot: {lot_size}
// Oluşturma: {datetime.now().strftime("%Y-%m-%d %H:%M")}
// ===============================================================================================

// --- AYARLAR ---
var LotSize = {lot_size};
var Sembol = "{self.symbol}";
var Periyot = "{self.period}";
var YON_MODU = "{self.yon_modu if hasattr(self, 'yon_modu') else 'CIFT'}";

// --- STRATEJİLERİ GETİR ---
var Sistem1 = Sistem.SistemGetir("{self.strategy1_filename}", Sembol, Periyot);
var Sistem2 = Sistem.SistemGetir("{self.strategy2_filename}", Sembol, Periyot);

if (Sistem1 == null || Sistem2 == null)
{{
    Sistem.Mesaj(Sistem.Name + " - Strateji bulunamadı!", Color.Red);
    return null;
}}

// --- SAAT KONTROLÜ ---
var Saat = DateTime.Now.TimeOfDay;
bool SeansSaati = (Saat >= new TimeSpan(9, 30, 0) && Saat < new TimeSpan(18, 15, 0)) ||
                  (Saat >= new TimeSpan(19, 0, 0) && Saat < new TimeSpan(23, 0, 0));

if (!SeansSaati)
{{
    return null;
}}

// --- SİNYAL BİRLEŞTİRME ---
// S1: Kapı açık mı? (Yön belirleme)
// S2: İşlem sinyali var mı?

var Yon1 = Sistem1.SonYon;  // A, S veya F
var Yon2 = Sistem2.SonYon;  // A, S veya F

string Sinyal = "";

// Kapı LONG açık ve S2 LONG sinyali
if (Yon1 == "A" && Yon2 == "A" && YON_MODU != "SADECE_SAT")
{{
    Sinyal = "A";
}}
// Kapı SHORT açık ve S2 SHORT sinyali
else if (Yon1 == "S" && Yon2 == "S" && YON_MODU != "SADECE_AL")
{{
    Sinyal = "S";
}}
// Kapı kapalı veya sinyal uyuşmazlığı
else
{{
    Sinyal = "F";
}}

// --- POZİSYON YÖNETİMİ ---
var EmirSembol = Sembol;
var SonFiyat = Sistem.SonFiyat(EmirSembol);
var Anahtar = Sistem.Name + "," + EmirSembol;

double IslemFiyat = 0;
DateTime IslemTarih;
var Rezerv = "";
var Pozisyon = Sistem.PozisyonKontrolOku(Anahtar, out IslemFiyat, out IslemTarih);

double Miktar = 0;

if (Sinyal == "F" && Pozisyon != 0)
{{
    // Pozisyonu kapat
    Miktar = -Pozisyon;
    Rezerv = "POZİSYON KAPATILDI";
}}
else if (Sinyal == "A" && Pozisyon != LotSize)
{{
    // Long aç/artır
    Miktar = LotSize - Pozisyon;
    Rezerv = "LONG AÇ";
}}
else if (Sinyal == "S" && Pozisyon != -LotSize)
{{
    // Short aç/artır
    Miktar = -LotSize - Pozisyon;
    Rezerv = "SHORT AÇ";
}}

// --- EMİR GÖNDER ---
if (Miktar != 0)
{{
    var Islem = Miktar > 0 ? "ALIS" : "SATIS";
    
    Sistem.PozisyonKontrolGuncelle(Anahtar, Miktar + Pozisyon, SonFiyat, Rezerv);
    
    Sistem.EmirSembol = EmirSembol;
    Sistem.EmirIslem = Islem;
    Sistem.EmirSuresi = "KIE";
    Sistem.EmirTipi = "Piyasa";
    Sistem.EmirMiktari = Math.Abs(Miktar);
    Sistem.EmirGonder();
    
    Sistem.Mesaj(Sistem.Name + " | " + Rezerv + " | Lot: " + Math.Abs(Miktar), Color.Green);
}}

// --- BİLGİ PANELİ ---
string panelInfo = "══════ S1+S2 ROBOT ══════" + Environment.NewLine +
                   "S1 (Kapı): " + Yon1 + Environment.NewLine +
                   "S2 (İşlem): " + Yon2 + Environment.NewLine +
                   "─────────────────────" + Environment.NewLine +
                   "Sinyal: " + Sinyal + Environment.NewLine +
                   "Pozisyon: " + Pozisyon + Environment.NewLine +
                   "Fiyat: " + SonFiyat.ToString("0.00");

var panelRenk = Color.DarkBlue;
if (Pozisyon > 0) panelRenk = Color.DarkGreen;
else if (Pozisyon < 0) panelRenk = Color.DarkRed;

Sistem.Dortgen(1, 10, 30, 180, 120, panelRenk, Color.Black, Color.White);
Sistem.GradientYaziEkle(panelInfo, 1, 15, 35, Color.White, Color.LightBlue, "Consolas", 9);

return null;
'''
        return code
    
    
    def _generate_strategy4_code(self, params: Dict[str, Any], vade_tipi: str) -> str:
        """Strateji 4 (TOMA + Momentum + TRIX) IdealData kodu oluşturur."""
        
        # Parametreler
        p = {
            'mom_period': int(params.get('mom_period', 1900)),
            'mom_upper': params.get('mom_limit_high', params.get('mom_upper', 101.5)),
            'mom_lower': params.get('mom_limit_low', params.get('mom_lower', 98.0)),
            'trix_period': int(params.get('trix_period', 120)),
            'trix_lb1': int(params.get('trix_lb1', 145)),
            'trix_lb2': int(params.get('trix_lb2', 160)),
            'hhv1_p': int(params.get('hhv1_period', params.get('hh_ll_period', 20))),
            'llv1_p': int(params.get('llv1_period', params.get('hh_ll_period', 20))),
            'hhv2_p': int(params.get('hhv2_period', params.get('hh_ll_long1', 150))),
            'llv2_p': int(params.get('llv2_period', params.get('hh_ll_long2', 190))),
            'hhv3_p': int(params.get('hhv3_period', 150)),
            'llv3_p': int(params.get('llv3_period', 190)),
            'toma_period': int(params.get('toma_period', 2)),
            'toma_opt': params.get('toma_opt', 2.1),
            'kar_al': params.get('kar_al', 0.0),
            'iz_stop': params.get('iz_stop', 0.0),
            'yon_modu': params.get('yon_modu', 'CIFT')
        }

        code = f'''// ===============================================================================================
// STRATEJI 4: TOMA + MOMENTUM + TRIX SİSTEMİ
// ===============================================================================================
// Sembol: {self.symbol}
// Periyot: {self.period} dakika
// Vade Tipi: {vade_tipi}
// Oluşturma: {datetime.now().strftime("%Y-%m-%d %H:%M")}
// ===============================================================================================

// --- VADE TİPİ & YÖN MODU ---
string VadeTipi = "{vade_tipi}";
string YON_MODU = "{p['yon_modu']}";

// --- PARAMETRELER ---
var MOM_PERIOD = {p['mom_period']};
var MOM_UPPER = {p['mom_upper']}f;
var MOM_LOWER = {p['mom_lower']}f;
var TRIX_PERIOD = {p['trix_period']};
var TRIX_LB1 = {p['trix_lb1']};
var TRIX_LB2 = {p['trix_lb2']};
var HHV1_PERIOD = {p['hhv1_p']};
var LLV1_PERIOD = {p['llv1_p']};
var HHV2_PERIOD = {p['hhv2_p']};
var LLV2_PERIOD = {p['llv2_p']};
var HHV3_PERIOD = {p['hhv3_p']};
var LLV3_PERIOD = {p['llv3_p']};
var TOMA_PERIOD = {p['toma_period']};
var TOMA_OPT = {p['toma_opt']}f;
var KAR_AL_YUZDE = {p['kar_al']}f;
var IZLEYEN_STOP_YUZDE = {p['iz_stop']}f;

// ===============================================================================================
// DİNAMİK BAYRAM TARİHLERİ (2024-2030)
// ===============================================================================================
int yil = DateTime.Now.Year;
DateTime Ramazan, Kurban;

switch(yil)
{{
    case 2024: Ramazan = new DateTime(2024, 4, 10); Kurban = new DateTime(2024, 6, 16); break;
    case 2025: Ramazan = new DateTime(2025, 3, 30); Kurban = new DateTime(2025, 6, 6); break;
    case 2026: Ramazan = new DateTime(2026, 3, 20); Kurban = new DateTime(2026, 5, 27); break;
    case 2027: Ramazan = new DateTime(2027, 3, 9); Kurban = new DateTime(2027, 5, 16); break;
    case 2028: Ramazan = new DateTime(2028, 2, 26); Kurban = new DateTime(2028, 5, 5); break;
    case 2029: Ramazan = new DateTime(2029, 2, 14); Kurban = new DateTime(2029, 4, 24); break;
    case 2030: Ramazan = new DateTime(2030, 2, 3); Kurban = new DateTime(2030, 4, 13); break;
    default: Ramazan = new DateTime(yil, 3, 15); Kurban = new DateTime(yil, 5, 20); break;
}}

DateTime R2024 = new DateTime(2024, 4, 10); DateTime K2024 = new DateTime(2024, 6, 16);
DateTime R2025 = new DateTime(2025, 3, 30); DateTime K2025 = new DateTime(2025, 6, 6);
DateTime R2026 = new DateTime(2026, 3, 20); DateTime K2026 = new DateTime(2026, 5, 27);
DateTime R2027 = new DateTime(2027, 3, 9); DateTime K2027 = new DateTime(2027, 5, 16);

string[] resmiTatiller = new string[] {{ "01.01","04.23","05.01","05.19","07.15","08.30","10.29" }};

var V = Sistem.GrafikVerileri;
var O = Sistem.GrafikFiyatSec("Acilis");
var C = Sistem.GrafikFiyatSec("Kapanis");
var H = Sistem.GrafikFiyatSec("Yuksek");
var L = Sistem.GrafikFiyatSec("Dusuk");

// ===============================================================================================
// VADE SONU İŞ GÜNÜ HESAPLAMA
// ===============================================================================================
Func<DateTime, DateTime> VadeSonuIsGunu = (dt) =>
{{
    var aySonu = new DateTime(dt.Year, dt.Month, DateTime.DaysInMonth(dt.Year, dt.Month));
    var d = aySonu;
    
    for (int k = 0; k < 15; k++)
    {{
        if (d.DayOfWeek == DayOfWeek.Saturday || d.DayOfWeek == DayOfWeek.Sunday)
        {{ d = d.AddDays(-1); continue; }}
        
        string mmdd = d.ToString("MM.dd");
        bool tatil = false;
        for (int t = 0; t < resmiTatiller.Length; t++)
            if (resmiTatiller[t] == mmdd) {{ tatil = true; break; }}
        if (tatil) {{ d = d.AddDays(-1); continue; }}
        
        if ((d >= R2024 && d <= R2024.AddDays(3)) || (d >= K2024 && d <= K2024.AddDays(4)) ||
            (d >= R2025 && d <= R2025.AddDays(3)) || (d >= K2025 && d <= K2025.AddDays(4)) ||
            (d >= R2026 && d <= R2026.AddDays(3)) || (d >= K2026 && d <= K2026.AddDays(4)) ||
            (d >= R2027 && d <= R2027.AddDays(3)) || (d >= K2027 && d <= K2027.AddDays(4)))
        {{ d = d.AddDays(-1); continue; }}
        
        break;
    }}
    return d.Date;
}};

// --- INDIKATORLER ---
var MA_TOMA = Sistem.MA(C, "Exp", TOMA_PERIOD);
var TOMA_Line = Sistem.Liste(0);
var TOMA_Trend = Sistem.Liste(0);

TOMA_Line[0] = MA_TOMA[0];
TOMA_Trend[0] = 1; 

for (int j = 1; j < V.Count; j++)
{{
    double yuzdeCarpan = TOMA_OPT / 100.0;
    float altBant = (float)(MA_TOMA[j] * (1 - yuzdeCarpan));
    float ustBant = (float)(MA_TOMA[j] * (1 + yuzdeCarpan));

    if (TOMA_Trend[j-1] == 1)
    {{
        TOMA_Line[j] = Math.Max(TOMA_Line[j-1], altBant);
        if (MA_TOMA[j] < TOMA_Line[j])
        {{
            TOMA_Trend[j] = -1;
            TOMA_Line[j] = ustBant;
        }}
        else
        {{
            TOMA_Trend[j] = 1;
        }}
    }}
    else
    {{
        TOMA_Line[j] = Math.Min(TOMA_Line[j-1], ustBant);
        if (MA_TOMA[j] > TOMA_Line[j])
        {{
            TOMA_Trend[j] = 1;
            TOMA_Line[j] = altBant;
        }}
        else
        {{
            TOMA_Trend[j] = -1;
        }}
    }}
}}

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
{{
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
    {{
        if (SonYon != "F") Sinyal = "F";
        warmupAktif = true; warmupBaslangicBar = -999; arefeFlat = false;
    }}
    else if (arefe && !vadeSonuGun && t > new TimeSpan(11,30,0))
    {{
        if (SonYon != "F") Sinyal = "F";
        arefeFlat = true;
    }}
    else if (vadeSonuGun && t > new TimeSpan(17,40,0))
    {{
        if (SonYon != "F") Sinyal = "F";
        warmupAktif = true; warmupBaslangicBar = -999; arefeFlat = false;
    }}
    
    if (Sinyal == "F") {{
        if (SonYon != Sinyal) {{ Sistem.Yon[i] = Sinyal; SonYon = Sinyal; Pos = 0; }}
        continue;
    }}
    
    if ((arefe && t > new TimeSpan(11,30,0)) || (vadeSonuGun && !arefe && t > new TimeSpan(17,40,0))) continue;

    if (warmupAktif && warmupBaslangicBar == -999) {{
        bool yeniSeans = false;
        if (aksamSeansi && i>0 && V[i-1].Date.TimeOfDay < new TimeSpan(19,0,0)) yeniSeans = true;
        if (gunSeansi && i>0 && dt.Date != V[i-1].Date.Date) yeniSeans = true;
        if (yeniSeans) warmupBaslangicBar = i;
    }}
    if (warmupAktif && warmupBaslangicBar > 0) {{
        if ((i - warmupBaslangicBar) < 100) continue; // Min 100 bar cooldown
        else warmupAktif = false;
    }}
    if (arefeFlat && i>0 && dt.Date != V[i-1].Date.Date) arefeFlat = false;


    // --- STRATEJİ MANTIĞI ---
    
    // Kural 1: MOM > ÜST SINIR
    if (MOM1[i] > MOM_UPPER)
    {{
        if (HH2[i] > HH2[i-1] && TRIX1[i] < TRIX1[i-TRIX_LB1] && TRIX1[i] > TRIX1[i-1] && YON_MODU != "SADECE_SAT") Sinyal = "A"; 
        if (LL2[i] < LL2[i-1] && TRIX1[i] > TRIX1[i-TRIX_LB1] && TRIX1[i] < TRIX1[i-1] && YON_MODU != "SADECE_AL") Sinyal = "S"; 
    }}
    
    // Kural 2: MOM < ALT SINIR
    if (MOM1[i] < MOM_LOWER)
    {{
        if (HH3[i] > HH3[i-1] && TRIX2[i] < TRIX2[i-TRIX_LB2] && TRIX2[i] > TRIX2[i-1] && YON_MODU != "SADECE_SAT") Sinyal = "A"; 
        if (LL3[i] < LL3[i-1] && TRIX2[i] > TRIX2[i-TRIX_LB2] && TRIX2[i] < TRIX2[i-1] && YON_MODU != "SADECE_AL") Sinyal = "S"; 
    }}
    
    // Kural 3: TOMA + HHV/LLV (Ana Trend - Öncelikli, önceki sinyalleri ezer)
    if (HH1[i] > HH1[i-1] && C[i] > TOMA_Line[i] && YON_MODU != "SADECE_SAT") Sinyal = "A";
    if (LL1[i] < LL1[i-1] && C[i] < TOMA_Line[i] && YON_MODU != "SADECE_AL") Sinyal = "S";

    // --- POZİSYON GÜNCELLEME (Giriş / Reverse) ---
    if (Sinyal != "" && SonYon != Sinyal)
    {{
        SonYon = Sinyal;
        Sistem.Yon[i] = SonYon;
        EntryPrice = C[i];
        ExtremePrice = C[i];
        if (Sinyal == "A") Pos = 1;
        else if (Sinyal == "S") Pos = -1;
        else Pos = 0;
    }}

    // --- EXIT LOGIC (Kar Al / İzleyen Stop) ---
    if (Pos == 1) {{
        if (ExtremePrice < C[i]) ExtremePrice = C[i];
        if (KAR_AL_YUZDE > 0 && C[i] >= EntryPrice * (1 + KAR_AL_YUZDE/100.0)) {{
            Sistem.Yon[i] = "F"; Pos = 0;
        }}
        if (IZLEYEN_STOP_YUZDE > 0 && C[i] <= ExtremePrice * (1 - IZLEYEN_STOP_YUZDE/100.0)) {{
            Sistem.Yon[i] = "F"; Pos = 0;
        }}
    }}
    else if (Pos == -1) {{
        if (ExtremePrice == 0 || ExtremePrice > C[i]) ExtremePrice = C[i];
        if (KAR_AL_YUZDE > 0 && C[i] <= EntryPrice * (1 - KAR_AL_YUZDE/100.0)) {{
            Sistem.Yon[i] = "F"; Pos = 0;
        }}
        if (IZLEYEN_STOP_YUZDE > 0 && C[i] >= ExtremePrice * (1 + IZLEYEN_STOP_YUZDE/100.0)) {{
            Sistem.Yon[i] = "F"; Pos = 0;
        }}
    }}
}}

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

{self._get_performance_panel_code()}
'''
        return code

    def _generate_strategy5_code(self, params: Dict[str, Any], vade_tipi: str) -> str:
        """Strateji 5 (Oliver Kell) IdealData kodu oluşturur."""
        ema_fast = int(params.get('ema_fast', 10))
        ema_slow = int(params.get('ema_slow', 20))
        breakout_p = int(params.get('breakout_period', 10))
        adx_p = int(params.get('adx_period', 14))
        adx_thresh = float(params.get('adx_threshold', 20.0))
        vol_ma_p = int(params.get('vol_ma_period', 20))
        trail_pct = float(params.get('trailing_stop_pct', 1.5))

        # Yön Modu (3 mod)
        if vade_tipi == "SPOT":
            yon_code = """
// SPOT Hisse (EREGL, ASELS vb.): Sadece AL / FLAT
string YON = "AL";
"""
            mode_label = "SPOT Hisse — Tek Yön (AL/FLAT)"
        elif vade_tipi == "VIOP_SPOT":
            yon_code = """
// Vadeli Spot Hisse (VIP-THYAO vb.): Çift Yönlü + Vade Geçişi
string YON = "CIFT";
"""
            mode_label = "VIOP Spot Vadeli — Çift Yön"
        else:  # VIOP_ENDEKS (veya eski "ENDEKS")
            yon_code = """
// Vadeli Endeks (VIP-X030 vb.): Çift Yönlü + Vade Geçişi
string YON = "CIFT";
"""
            mode_label = "VIOP Endeks Vadeli — Çift Yön"
        
        is_spot = (vade_tipi == "SPOT")

        code = f'''// ===============================================================================================
// STRATEJI 5: Oliver Kell — Base 'n Break
// 2020 US Investing Championship Şampiyonu
// Mod: {mode_label}
// Otomatik: IdealQuant Export | Tarih: {datetime.now().strftime('%Y-%m-%d %H:%M')}
// ===============================================================================================
{yon_code}

// === PARAMETRELER ===
int EMA_Fast_P = {ema_fast};
int EMA_Slow_P = {ema_slow};
int Breakout_P = {breakout_p};
int ADX_P = {adx_p};
float ADX_Threshold = {adx_thresh}f;
int VolMA_P = {vol_ma_p};
float TrailingStopPct = {trail_pct}f;

// === GRAFİK BİLGİSİ ===
var Grafikler = Sistem.GrafikVerileri;
var O = Sistem.GrafikFiyatSec("Acilis");
var H = Sistem.GrafikFiyatSec("Yuksek");
var L = Sistem.GrafikFiyatSec("Dusuk");
var C = Sistem.GrafikFiyatSec("Kapanis");
var T = Sistem.GrafikFiyatSec("Tipik");
var V = Sistem.GrafikVerileri;

// === İNDİKATÖRLER ===
var EMA_Fast = Sistem.MA(C, "Exp", EMA_Fast_P);
var EMA_Slow = Sistem.MA(C, "Exp", EMA_Slow_P);
var ADX_Val = Sistem.ADX(ADX_P);
var HH = Sistem.HHV(Breakout_P, "Yuksek");
var LL = Sistem.LLV(Breakout_P, "Dusuk");

// Hacim Ortalaması (SMA)
var Vol = Sistem.GrafikFiyatOku(V, "Hacim");
var VolMA = Sistem.MA(Vol, "Simple", VolMA_P);

// === STRATEJI MANTIGI ===
for (int i = Math.Max(EMA_Slow_P, Math.Max(ADX_P, Math.Max(Breakout_P, VolMA_P))) + 2; i < Grafikler.Count; i++)
{{
    if (Sistem.Yon[i] != "") continue; // Zaten sinyal var

    // --- LONG KOSULLARI ---
    bool longTrend = C[i] > EMA_Fast[i] && C[i] > EMA_Slow[i];
    bool longBreak = C[i] > HH[i - 1];
    bool longADX   = ADX_Val[i] > ADX_Threshold && EMA_Fast[i] > EMA_Fast[i - 1];
    bool gucluHacim = Vol[i] > VolMA[i];

    // --- SHORT KOSULLARI ---
    bool shortTrend = C[i] < EMA_Fast[i] && C[i] < EMA_Slow[i];
    bool shortBreak = C[i] < LL[i - 1];
    bool shortADX   = ADX_Val[i] > ADX_Threshold && EMA_Fast[i] < EMA_Fast[i - 1];

    // --- GIRIS ---
    if (longTrend && longBreak && longADX && gucluHacim)
    {{
        Sistem.Yon[i] = "A"; // AL
    }}
    {"" if is_spot else '''else if (shortTrend && shortBreak && shortADX && gucluHacim)
    {
        Sistem.Yon[i] = "S"; // SAT
    }'''}
}}

// === ÇIKIŞ: EMA CROSSBACK + İZLEYEN STOP ===
float iz_yuzde = TrailingStopPct / 100.0f;
float ucUcMesafe = 0f;
float stopSeviyesi = 0f;
int pozisyon = 0; // 0=F, 1=A{'' if is_spot else ', -1=S'}

for (int i = 1; i < Grafikler.Count; i++)
{{
    if (Sistem.Yon[i] == "A")
    {{
        {'' if is_spot else 'if (pozisyon == -1) { Sistem.Yon[i] = "A"; } // Reverse'}
        pozisyon = 1;
        ucUcMesafe = C[i];
        stopSeviyesi = L[i];
    }}
    {'' if is_spot else '''else if (Sistem.Yon[i] == "S")
    {{
        if (pozisyon == 1) {{ Sistem.Yon[i] = "S"; }} // Reverse
        pozisyon = -1;
        ucUcMesafe = C[i];
        stopSeviyesi = H[i];
    }}'''}
    else if (pozisyon == 1)
    {{
        // Trailing stop güncelle
        if (C[i] > ucUcMesafe)
        {{
            ucUcMesafe = C[i];
            float yeniStop = ucUcMesafe * (1.0f - iz_yuzde);
            if (yeniStop > stopSeviyesi) stopSeviyesi = yeniStop;
        }}
        // Çıkış: EMA crossback veya İzleyen Stop (bar-içi: L[i] kontrol)
        bool emaCrossback = C[i] < EMA_Fast[i] && C[i] < EMA_Slow[i];
        if (emaCrossback || L[i] <= stopSeviyesi)
        {{
            Sistem.Yon[i] = "F"; // FLAT
            pozisyon = 0;
            ucUcMesafe = 0f;
            stopSeviyesi = 0f;
        }}
    }}
    {'' if is_spot else '''else if (pozisyon == -1)
    {{
        // Trailing stop güncelle
        if (C[i] < ucUcMesafe)
        {{
            ucUcMesafe = C[i];
            float yeniStop = ucUcMesafe * (1.0f + iz_yuzde);
            if (yeniStop < stopSeviyesi || stopSeviyesi == 0) stopSeviyesi = yeniStop;
        }}
        // Çıkış: EMA crossback veya İzleyen Stop (bar-içi: H[i] kontrol)
        bool emaCrossback = C[i] > EMA_Fast[i] && C[i] > EMA_Slow[i];
        if (emaCrossback || H[i] >= stopSeviyesi)
        {{
            Sistem.Yon[i] = "F"; // FLAT
            pozisyon = 0;
            ucUcMesafe = 0f;
            stopSeviyesi = 0f;
        }}
    }}'''}
}}

// === ÇİZİMLER (Index 3+ — Pro Performance Panel ile çakışmaz) ===
Sistem.Cizgiler[3].Deger = EMA_Fast;
Sistem.Cizgiler[3].Aciklama = "EMA {ema_fast}";
Sistem.Cizgiler[3].ActiveBool = true;

Sistem.Cizgiler[4].Deger = EMA_Slow;
Sistem.Cizgiler[4].Aciklama = "EMA {ema_slow}";
Sistem.Cizgiler[4].ActiveBool = true;

Sistem.Cizgiler[5].Deger = HH;
Sistem.Cizgiler[5].Aciklama = "HH {breakout_p}";
Sistem.Cizgiler[5].ActiveBool = true;

{self._get_performance_panel_code()}
'''
        return code

    # ==========================================================================
    # STRATEGY 6: TOTT_HOTT
    # ==========================================================================

    def _generate_strategy6_code(self, params: Dict[str, Any], vade_tipi: str) -> str:
        """Strateji 6 (TOTT_HOTT) IdealData kodu oluşturur."""
        ott_period = int(params.get('ott_period', 30))
        ott_pct_big = float(params.get('ott_pct_big', 7.0))
        ott_pct_small = float(params.get('ott_pct_small', 3.5))
        ott_mult = float(params.get('ott_mult', 0.0008))
        sott_pct = float(params.get('sott_pct', 0.3))
        gate_period = int(params.get('gate_period', 20))
        gate_pct = float(params.get('gate_pct', 0.5))
        stoch_k = int(params.get('stoch_k', 500))
        stoch_smooth = int(params.get('stoch_smooth', 200))

        # Yön Modu
        is_spot = (vade_tipi == "SPOT")
        if is_spot:
            yon_code = '// SPOT Hisse: Sadece AL / FLAT\nstring YON_MODU = "SADECE_AL";'
            mode_label = "SPOT Hisse — Tek Yön (AL/FLAT)"
        else:
            yon_code = '// Vadeli: Çift Yönlü\nstring YON_MODU = "CIFT";'
            mode_label = f"VIOP — Çift Yön ({vade_tipi})"
        
        half_gate = max(1, gate_period // 2)

        code = f'''// ===============================================================================================
// STRATEJI 6: TOTT_HOTT — OTT Tabanlı Trend + Stochastic Bölge + HHV/LLV Kapı
// Mod: {mode_label}
// Otomatik: IdealQuant Export | Tarih: {datetime.now().strftime('%Y-%m-%d %H:%M')}
// ===============================================================================================
{yon_code}

// === PARAMETRELER ===
int OTT_Period = {ott_period};
float OTT_Pct_Big = {ott_pct_big}f;
float OTT_Pct_Small = {ott_pct_small}f;
float OTT_Mult = {ott_mult}f;
float SOTT_Pct = {sott_pct}f;
int Gate_Period = {gate_period};
float Gate_Pct = {gate_pct}f;
int Stoch_K = {stoch_k};
int Stoch_Smooth = {stoch_smooth};

// === GRAFİK BİLGİSİ ===
var Veriler = Sistem.GrafikVerileri;
var O = Sistem.GrafikFiyatSec("Acilis");
var H = Sistem.GrafikFiyatSec("Yuksek");
var L = Sistem.GrafikFiyatSec("Dusuk");
var C = Sistem.GrafikFiyatSec("Kapanis");

string VadeTipi = "{vade_tipi}";

// ===============================================================================================
// DİNAMİK BAYRAM TARİHLERİ (2024-2030)
// ===============================================================================================
int yil = DateTime.Now.Year;
DateTime Ramazan, Kurban;

switch(yil)
{{
    case 2024: Ramazan = new DateTime(2024, 4, 10); Kurban = new DateTime(2024, 6, 16); break;
    case 2025: Ramazan = new DateTime(2025, 3, 30); Kurban = new DateTime(2025, 6, 6); break;
    case 2026: Ramazan = new DateTime(2026, 3, 20); Kurban = new DateTime(2026, 5, 27); break;
    case 2027: Ramazan = new DateTime(2027, 3, 9); Kurban = new DateTime(2027, 5, 16); break;
    case 2028: Ramazan = new DateTime(2028, 2, 26); Kurban = new DateTime(2028, 5, 5); break;
    case 2029: Ramazan = new DateTime(2029, 2, 14); Kurban = new DateTime(2029, 4, 24); break;
    case 2030: Ramazan = new DateTime(2030, 2, 3); Kurban = new DateTime(2030, 4, 13); break;
    default: Ramazan = new DateTime(yil, 3, 15); Kurban = new DateTime(yil, 5, 20); break;
}}

DateTime R2024 = new DateTime(2024, 4, 10); DateTime K2024 = new DateTime(2024, 6, 16);
DateTime R2025 = new DateTime(2025, 3, 30); DateTime K2025 = new DateTime(2025, 6, 6);
DateTime R2026 = new DateTime(2026, 3, 20); DateTime K2026 = new DateTime(2026, 5, 27);
DateTime R2027 = new DateTime(2027, 3, 9); DateTime K2027 = new DateTime(2027, 5, 16);

string[] resmiTatiller = new string[] {{ "01.01","04.23","05.01","05.19","07.15","08.30","10.29" }};

// ===============================================================================================
// VADE SONU İŞ GÜNÜ HESAPLAMA
// ===============================================================================================
Func<DateTime, DateTime> VadeSonuIsGunu = (dt) =>
{{
    var aySonu = new DateTime(dt.Year, dt.Month, DateTime.DaysInMonth(dt.Year, dt.Month));
    var d = aySonu;
    
    for (int k = 0; k < 15; k++)
    {{
        if (d.DayOfWeek == DayOfWeek.Saturday || d.DayOfWeek == DayOfWeek.Sunday)
        {{ d = d.AddDays(-1); continue; }}
        
        string mmdd = d.ToString("MM.dd");
        bool tatil = false;
        for (int t = 0; t < resmiTatiller.Length; t++)
            if (resmiTatiller[t] == mmdd) {{ tatil = true; break; }}
        if (tatil) {{ d = d.AddDays(-1); continue; }}
        
        if ((d >= R2024 && d <= R2024.AddDays(3)) || (d >= K2024 && d <= K2024.AddDays(4)) ||
            (d >= R2025 && d <= R2025.AddDays(3)) || (d >= K2025 && d <= K2025.AddDays(4)) ||
            (d >= R2026 && d <= R2026.AddDays(3)) || (d >= K2026 && d <= K2026.AddDays(4)) ||
            (d >= R2027 && d <= R2027.AddDays(3)) || (d >= K2027 && d <= K2027.AddDays(4)))
        {{ d = d.AddDays(-1); continue; }}
        
        break;
    }}
    return d.Date;
}};

// ===============================================================================================
// İNDİKATÖR HESAPLAMALARI
// ===============================================================================================
// 1. Variable MA (MOV)
var MOV = Sistem.MA(C, "Variable", OTT_Period);

// 2. OTT — Büyük (Ana trend filtre)
var OTT_Big = Sistem.OTT(C, OTT_Period, OTT_Pct_Big, "Variable");

// 3. OTT — Küçük (Fallback + band check)
var OTT_Small = Sistem.OTT(C, OTT_Period, OTT_Pct_Small, "Variable");

// 4. Stochastic + VMA Smooth + Offset → SOTT
var StochRaw = Sistem.StochasticFast(Stoch_K, 1);  
var StochSmooth = Sistem.MA(StochRaw, "Variable", Stoch_Smooth);
var STOSK_X = Sistem.Liste(0);
for (int i = 0; i < Veriler.Count; i++)
    STOSK_X[i] = StochSmooth[i] + 1000.0f;
var SOTT = Sistem.OTT(STOSK_X, 2, SOTT_Pct, "Variable");

// 5. HHV/LLV Kapı — Half period
var HHV_Full = Sistem.HHV(Gate_Period, "Yuksek");
var LLV_Full = Sistem.LLV(Gate_Period, "Dusuk");
var HHV_Half = Sistem.HHV({half_gate}, "Yuksek");
var LLV_Half = Sistem.LLV({half_gate}, "Dusuk");
var HOTT = Sistem.OTT(HHV_Half, 2, Gate_Pct, "Variable");
var LOTT = Sistem.OTT(LLV_Half, 2, Gate_Pct, "Variable");

// ===============================================================================================
// SİNYAL ÜRETME
// ===============================================================================================
for (int i = 1; i < Veriler.Count; i++) Sistem.Yon[i] = "";
var SonYon = "";

int vadeCooldownBar = Stoch_K + Stoch_Smooth + 50;
int warmupBars = Math.Max(100, vadeCooldownBar);
int warmupBaslangicBar = -999;
bool warmupAktif = false;
bool arefeFlat = false;

float mult_up = 1.0f + OTT_Mult;
float mult_dn = 1.0f - OTT_Mult;

for (int i = warmupBars; i < Veriler.Count; i++)
{{
    string Sinyal = "";
    var dt = Veriler[i].Date;
    var t = dt.TimeOfDay;
    
    bool gunSeansi = t >= new TimeSpan(9,30,0) && t < new TimeSpan(18,15,0);
    bool aksamSeansi = t >= new TimeSpan(19,0,0) && t < new TimeSpan(23,0,0);
    if (!(gunSeansi || aksamSeansi)) continue;
    
    bool vadeAyi = (VadeTipi == "SPOT") || (dt.Month % 2 == 0);
    bool vadeSonuGun = vadeAyi && (dt.Date == VadeSonuIsGunu(dt));
    
    bool arefe = dt.Date == R2024.AddDays(-1).Date || dt.Date == K2024.AddDays(-1).Date ||
                 dt.Date == R2025.AddDays(-1).Date || dt.Date == K2025.AddDays(-1).Date ||
                 dt.Date == R2026.AddDays(-1).Date || dt.Date == K2026.AddDays(-1).Date ||
                 dt.Date == R2027.AddDays(-1).Date || dt.Date == K2027.AddDays(-1).Date;
    
    // Vade/Arefe Flat
    if (arefe && vadeSonuGun && t > new TimeSpan(11,30,0))
    {{
        if (SonYon != "F") Sinyal = "F";
        warmupAktif = true; warmupBaslangicBar = -999; arefeFlat = false;
    }}
    else if (arefe && !vadeSonuGun && t > new TimeSpan(11,30,0))
    {{
        if (SonYon != "F") Sinyal = "F";
        arefeFlat = true;
    }}
    else if (vadeSonuGun && t > new TimeSpan(17,40,0))
    {{
        if (SonYon != "F") Sinyal = "F";
        warmupAktif = true; warmupBaslangicBar = -999; arefeFlat = false;
    }}
    
    if (Sinyal == "F") {{
        if (SonYon != Sinyal) {{ Sistem.Yon[i] = Sinyal; SonYon = Sinyal; }}
        continue;
    }}
    if ((arefe && t > new TimeSpan(11,30,0)) || (vadeSonuGun && !arefe && t > new TimeSpan(17,40,0))) continue;
    
    // Warmup
    if (warmupAktif && warmupBaslangicBar == -999) {{
        bool yeniSeans = false;
        if (aksamSeansi && i>0 && Veriler[i-1].Date.TimeOfDay < new TimeSpan(19,0,0)) yeniSeans = true;
        if (gunSeansi && i>0 && dt.Date != Veriler[i-1].Date.Date) yeniSeans = true;
        if (yeniSeans) warmupBaslangicBar = i;
    }}
    if (warmupAktif && warmupBaslangicBar > 0) {{
        if ((i - warmupBaslangicBar) < 150) continue; // Sabit kısa cooldown, STOSK süresi strateji başı geçerli
        else warmupAktif = false;
    }}
    if (arefeFlat && i>0 && dt.Date != Veriler[i-1].Date.Date) arefeFlat = false;

    // === TOTT_HOTT SİNYAL MANTIĞI ===
    float mov_i = MOV[i];
    float ott_big_i = OTT_Big[i];
    float ott_small_i = OTT_Small[i];
    float sx_i = STOSK_X[i];
    float sott_i = SOTT[i];
    float hhv_prev = HHV_Full[i - 1];
    float llv_prev = LLV_Full[i - 1];
    
    // Kapı koşulları
    bool hott_gate = (H[i] > HOTT[i]) && (H[i] > hhv_prev);
    bool lott_gate = (L[i] < LOTT[i]) && (L[i] < llv_prev);
    
    // Bölge (SOTT)
    bool sott_long = sx_i > sott_i;
    bool sott_short = sx_i < sott_i;
    
    // AL Koşulları
    bool al = false;
    if (mov_i > ott_big_i)
    {{
        // Ana trend yukarı
        al = (mov_i > ott_small_i * mult_up) && sott_long && hott_gate;
    }}
    else
    {{
        // Fallback
        al = (mov_i > ott_small_i) && (mov_i > ott_small_i * mult_up) && sott_long && hott_gate;
    }}
    
    // SAT Koşulları
    bool sat = false;
    {"" if is_spot else '''if (mov_i > ott_big_i)
    {{
        sat = (mov_i < ott_small_i * mult_dn) && sott_short && lott_gate;
    }}
    else
    {{
        sat = (mov_i < ott_small_i) && sott_short && lott_gate;
    }}'''}
    
    if (al && SonYon != "A" && YON_MODU != "SADECE_SAT")
    {{
        Sinyal = "A";
    }}
    {"" if is_spot else '''else if (sat && SonYon != "S" && YON_MODU != "SADECE_AL")
    {{
        Sinyal = "S";
    }}'''}
    else if (SonYon == "A" && !al)
    {{
        Sinyal = "F";
    }}
    {"" if is_spot else '''else if (SonYon == "S" && !sat)
    {{
        Sinyal = "F";
    }}'''}
    
    // Yön Modu Kontrolü (Ekstra Güvenlik)
    if (YON_MODU == "SADECE_AL" && Sinyal == "S") Sinyal = "F";
    if (YON_MODU == "SADECE_SAT" && Sinyal == "A") Sinyal = "F";

    // Pozisyon güncelle
    if (Sinyal != "" && SonYon != Sinyal)
    {{
        Sistem.Yon[i] = Sinyal;
        SonYon = Sinyal;
    }}
}}

// === ÇİZİMLER ===
Sistem.Cizgiler[3].Deger = MOV;
Sistem.Cizgiler[3].Aciklama = "MOV(Variable, {ott_period})";
Sistem.Cizgiler[3].ActiveBool = true;
Sistem.Cizgiler[3].Renk = Color.Cyan;

Sistem.Cizgiler[4].Deger = OTT_Big;
Sistem.Cizgiler[4].Aciklama = "OTT Big ({ott_pct_big}%)";
Sistem.Cizgiler[4].ActiveBool = true;
Sistem.Cizgiler[4].Renk = Color.Red;

Sistem.Cizgiler[5].Deger = OTT_Small;
Sistem.Cizgiler[5].Aciklama = "OTT Small ({ott_pct_small}%)";
Sistem.Cizgiler[5].ActiveBool = true;
Sistem.Cizgiler[5].Renk = Color.Yellow;

// --- EKRANDA GÖRÜNTÜLEMEK (DEBUG ETMEK) İÇİN EKLENEN HOTT/SOTT ÇİZGİLERİ ---
Sistem.Cizgiler[6].Deger = HOTT;
Sistem.Cizgiler[6].Aciklama = "HOTT Kapısı";
Sistem.Cizgiler[6].ActiveBool = true;
Sistem.Cizgiler[6].Renk = Color.Orange;

Sistem.Cizgiler[7].Deger = HHV_Half;
Sistem.Cizgiler[7].Aciklama = "HHV Kapısı Tavanı";
Sistem.Cizgiler[7].ActiveBool = true;
Sistem.Cizgiler[7].Renk = Color.Green;

// Sistem.Cizgiler[8].Deger = STOSK_X; // Değerler 1000'lerde olduğu için fiyat grafiğini bozabilir, panele çizilmeli.
// Sistem.Cizgiler[8].Aciklama = "STOSK_X (1000+)";
// Sistem.Cizgiler[8].Panel = 2;
// Sistem.Cizgiler[8].ActiveBool = true;
// Sistem.Cizgiler[8].Renk = Color.White;
// 
// Sistem.Cizgiler[9].Deger = SOTT;
// Sistem.Cizgiler[9].Aciklama = "SOTT (1000+)";
// Sistem.Cizgiler[9].Panel = 2;
// Sistem.Cizgiler[9].ActiveBool = true;
// Sistem.Cizgiler[9].Renk = Color.Magenta;

{self._get_performance_panel_code()}
'''
        return code

    def export_strategy6(
        self, 
        params: Dict[str, Any], 
        vade_tipi: str = "ENDEKS"
    ) -> str:
        """
        Strateji 6 (TOTT_HOTT) Kodunu Export Eder
        """
        filename = self._generate_filename(6, vade_tipi)
        
        code = self._generate_strategy6_code(params, vade_tipi)
        
        filepath = self.output_dir / f"{filename}.cs"
        filepath.write_text(code, encoding='utf-8')
        
        # Parametreleri JSON olarak da kaydet
        params_path = self.output_dir / f"{filename}_params.json"
        params_path.write_text(json.dumps(params, indent=2, default=str), encoding='utf-8')
        
        return str(filepath)
    


    def _generate_strategy7_code(self, params: Dict[str, Any], vade_tipi: str) -> str:
        """Strateji 7 (DeepScalp v1.2) IdealData kodu oluşturur."""
        
        p = {
            'ars_k': params.get('ars_k', 1.23),
            'ars_ema_period': int(params.get('ars_ema_period', 3)),
            
            'st_factor': params.get('st_factor', 3.0),
            'st_hhv_period': int(params.get('st_hhv_period', 10)),
            'st_atr_period': int(params.get('st_atr_period', 14)),
            'ema_fast_period': int(params.get('ema_fast_period', 9)),
            'ema_slow_period': int(params.get('ema_slow_period', 21)),
            
            'toma_period1': int(params.get('toma_period1', 1)),
            'toma_period2': params.get('toma_period2', 2.1),
            'hhv_period': int(params.get('hhv_period', 12)),
            'llv_period': int(params.get('llv_period', 12)),
            
            'mfi_period': int(params.get('mfi_period', 14)),
            'mfi_hhv_period': int(params.get('mfi_hhv_period', 5)),
            'mfi_llv_period': int(params.get('mfi_llv_period', 5)),
            'mfi_long': params.get('mfi_long', 55.0),
            'mfi_short': params.get('mfi_short', 45.0),
            'vol_ratio': params.get('vol_ratio', 0.80),
            
            'atr_period': int(params.get('atr_period', 14)),
            'atr_stop_mult_long': params.get('atr_stop_mult_long', 1.5),
            'atr_stop_mult_short': params.get('atr_stop_mult_short', 1.5),
            'kar_al_yuzde_long': params.get('kar_al_yuzde_long', 2.0),
            'kar_al_yuzde_short': params.get('kar_al_yuzde_short', 2.0),
            
            'min_hold_bars': int(params.get('min_hold_bars', 2)),
            'max_hold_bars': int(params.get('max_hold_bars', 20)),
            'cooldown_bars': int(params.get('cooldown_bars', 2)),
            
            'vade_type': params.get('vade_type', vade_tipi),
            'yon_modu': params.get('yon_modu', 'CIFT')
        }

        # For the template, we'll write the complete DeepScalp C# script
        code = f'''// ===============================================================================================
// STRATEJI 7: DEEPSCALP v1.2 SİSTEMİ
// ===============================================================================================
// Sembol: {self.symbol}
// Periyot: {self.period} dakika
// Vade Tipi: {vade_tipi}
// Oluşturma: {datetime.now().strftime("%Y-%m-%d %H:%M")}
// ===============================================================================================

// --- VADE TİPİ & YÖN MODU ---
string VadeTipi = "{vade_tipi}";
string YON_MODU = "{p['yon_modu']}";

// --- PARAMETRELER ---
// Layer 1
float ARS_K = {p['ars_k']}f;
int ARS_EMA_PERIOD = {p['ars_ema_period']};
// Layer 2
float ST_FACTOR = {p['st_factor']}f;
int ST_HHV_PERIOD = {p['st_hhv_period']}; // ATR Period in Python 
int ST_ATR_PERIOD = {p['st_atr_period']};
int EMA_FAST_PERIOD = {p['ema_fast_period']};
int EMA_SLOW_PERIOD = {p['ema_slow_period']};
// Layer 3
int TOMA_PERIOD = {p['toma_period1']};
float TOMA_OPT = {p['toma_period2']}f;
int HHV_TETIK_PERIOD = {p['hhv_period']};
int LLV_TETIK_PERIOD = {p['llv_period']};
// Layer 4
int MFI_PERIOD = {p['mfi_period']};
int MFI_HHV_PERIOD = {p['mfi_hhv_period']};
int MFI_LLV_PERIOD = {p['mfi_llv_period']};
float MFI_LONG = {p['mfi_long']}f;
float MFI_SHORT = {p['mfi_short']}f;
float VOL_RATIO = {p['vol_ratio']}f;
// Layer 5
int ATR_PERIOD = {p['atr_period']};
float ATR_STOP_MULT_LONG = {p['atr_stop_mult_long']}f;
float ATR_STOP_MULT_SHORT = {p['atr_stop_mult_short']}f;
float KAR_AL_YUZDE_LONG = {p['kar_al_yuzde_long']}f;
float KAR_AL_YUZDE_SHORT = {p['kar_al_yuzde_short']}f;
// Layer 6
int MIN_HOLD_BARS = {p['min_hold_bars']};
int MAX_HOLD_BARS = {p['max_hold_bars']};
int COOLDOWN_BARS = {p['cooldown_bars']};

// ===============================================================================================
// DİNAMİK BAYRAM TARİHLERİ (2024-2030)
// ===============================================================================================
int yil = DateTime.Now.Year;
DateTime Ramazan, Kurban;

switch(yil)
{{
    case 2024: Ramazan = new DateTime(2024, 4, 10); Kurban = new DateTime(2024, 6, 16); break;
    case 2025: Ramazan = new DateTime(2025, 3, 30); Kurban = new DateTime(2025, 6, 6); break;
    case 2026: Ramazan = new DateTime(2026, 3, 20); Kurban = new DateTime(2026, 5, 27); break;
    case 2027: Ramazan = new DateTime(2027, 3, 9); Kurban = new DateTime(2027, 5, 16); break;
    case 2028: Ramazan = new DateTime(2028, 2, 26); Kurban = new DateTime(2028, 5, 5); break;
    case 2029: Ramazan = new DateTime(2029, 2, 14); Kurban = new DateTime(2029, 4, 24); break;
    case 2030: Ramazan = new DateTime(2030, 2, 3); Kurban = new DateTime(2030, 4, 13); break;
    default: Ramazan = new DateTime(yil, 3, 15); Kurban = new DateTime(yil, 5, 20); break;
}}

DateTime R2024 = new DateTime(2024, 4, 10); DateTime K2024 = new DateTime(2024, 6, 16);
DateTime R2025 = new DateTime(2025, 3, 30); DateTime K2025 = new DateTime(2025, 6, 6);
DateTime R2026 = new DateTime(2026, 3, 20); DateTime K2026 = new DateTime(2026, 5, 27);
DateTime R2027 = new DateTime(2027, 3, 9); DateTime K2027 = new DateTime(2027, 5, 16);

string[] resmiTatiller = new string[] {{ "01.01","04.23","05.01","05.19","07.15","08.30","10.29" }};

var V = Sistem.GrafikVerileri;
var O = Sistem.GrafikFiyatSec("Acilis");
var C = Sistem.GrafikFiyatSec("Kapanis");
var H = Sistem.GrafikFiyatSec("Yuksek");
var L = Sistem.GrafikFiyatSec("Dusuk");
var LotData = Sistem.GrafikFiyatSec("Hacim");

// ===============================================================================================
// VADE SONU İŞ GÜNÜ HESAPLAMA
// ===============================================================================================
Func<DateTime, DateTime> VadeSonuIsGunu = (dt) =>
{{
    var aySonu = new DateTime(dt.Year, dt.Month, DateTime.DaysInMonth(dt.Year, dt.Month));
    var d = aySonu;
    
    for (int k = 0; k < 15; k++)
    {{
        if (d.DayOfWeek == DayOfWeek.Saturday || d.DayOfWeek == DayOfWeek.Sunday)
        {{ d = d.AddDays(-1); continue; }}
        
        string mmdd = d.ToString("MM.dd");
        bool tatil = false;
        for (int t = 0; t < resmiTatiller.Length; t++)
            if (resmiTatiller[t] == mmdd) {{ tatil = true; break; }}
        if (tatil) {{ d = d.AddDays(-1); continue; }}
        
        if ((d >= R2024 && d <= R2024.AddDays(3)) || (d >= K2024 && d <= K2024.AddDays(4)) ||
            (d >= R2025 && d <= R2025.AddDays(3)) || (d >= K2025 && d <= K2025.AddDays(4)) ||
            (d >= R2026 && d <= R2026.AddDays(3)) || (d >= K2026 && d <= K2026.AddDays(4)) ||
            (d >= R2027 && d <= R2027.AddDays(3)) || (d >= K2027 && d <= K2027.AddDays(4)))
        {{ d = d.AddDays(-1); continue; }}
        
        break;
    }}
    return d.Date;
}};

// ===============================================================================================
// LAYER 1: ARS Regime
// ===============================================================================================
var ARS_EMA = Sistem.MA(C, "Exp", ARS_EMA_PERIOD);
var ARS_Band = Sistem.Liste(0);
for (int i = 0; i < V.Count; i++) {{
    ARS_Band[i] = ARS_EMA[i] * ARS_K;
    ARS_Band[i] = (float)Sistem.SayiYuvarla(ARS_Band[i], 0.01f);
}}

// ===============================================================================================
// LAYER 2: SuperTrend + EMA
// ===============================================================================================
var ST = Sistem.SuperTrend(ST_FACTOR, ST_HHV_PERIOD, ST_ATR_PERIOD);

var EMA_FAST = Sistem.MA(C, "Exp", EMA_FAST_PERIOD);
var EMA_SLOW = Sistem.MA(C, "Exp", EMA_SLOW_PERIOD);


// ===============================================================================================
// LAYER 3: TOMA + HHV/LLV
// ===============================================================================================
var MA_TOMA = Sistem.MA(C, "Exp", TOMA_PERIOD);
var TOMA_Line = Sistem.Liste(0);
var TOMA_Trend = Sistem.Liste(0);

TOMA_Line[0] = MA_TOMA[0];
TOMA_Trend[0] = 1; 

for (int j = 1; j < V.Count; j++)
{{
    double yuzdeCarpan = TOMA_OPT / 100.0;
    float altBant = (float)(MA_TOMA[j] * (1 - yuzdeCarpan));
    float ustBant = (float)(MA_TOMA[j] * (1 + yuzdeCarpan));

    if (TOMA_Trend[j-1] == 1)
    {{
        TOMA_Line[j] = Math.Max(TOMA_Line[j-1], altBant);
        if (MA_TOMA[j] < TOMA_Line[j])
        {{
            TOMA_Trend[j] = -1;
            TOMA_Line[j] = ustBant;
        }}
        else
        {{
            TOMA_Trend[j] = 1;
        }}
    }}
    else
    {{
        TOMA_Line[j] = Math.Min(TOMA_Line[j-1], ustBant);
        if (MA_TOMA[j] > TOMA_Line[j])
        {{
            TOMA_Trend[j] = 1;
            TOMA_Line[j] = altBant;
        }}
        else
        {{
            TOMA_Trend[j] = -1;
        }}
    }}
}}

var TETIK_HHV = Sistem.HHV(HHV_TETIK_PERIOD, "Yuksek");
var TETIK_LLV = Sistem.LLV(LLV_TETIK_PERIOD, "Dusuk");

// ===============================================================================================
// LAYER 4: MFI + VOLUME
// ===============================================================================================
var MFI = Sistem.MoneyFlowIndex(MFI_PERIOD);
var MFI_HHV = Sistem.HHV(MFI_HHV_PERIOD, MFI);
var MFI_LLV = Sistem.LLV(MFI_LLV_PERIOD, MFI);
var VOL_MA = Sistem.MA(LotData, "Simple", 20);

// ===============================================================================================
// LAYER 5: ATR Stops
// ===============================================================================================
var ATR = Sistem.AverageTrueRange(ATR_PERIOD);

// ===============================================================================================
// SİNYAL DÖNGÜSÜ
// ===============================================================================================

var SonYon = "";
var Sinyal = "";
bool inLong = false;
bool inShort = false;
float entryPrice = 0f;
float extremeVal = 0f;
float stopLevel = 0f;
int barsInPos = 0;
int cooldownCt = 0;

for (int i = 1; i < V.Count; i++) Sistem.Yon[i] = "";

int warmBars = Math.Max(MFI_PERIOD, Math.Max(ST_ATR_PERIOD, Math.Max(EMA_SLOW_PERIOD, TOMA_PERIOD))) + 50;
int warmupBaslangicBar = -999;
bool warmupAktif = false;
bool arefeFlat = false;

for (int i = warmBars; i < V.Count; i++)
{{
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
    {{
        if (SonYon != "F") Sinyal = "F";
        warmupAktif = true; warmupBaslangicBar = -999; arefeFlat = false;
    }}
    else if (arefe && !vadeSonuGun && t > new TimeSpan(11,30,0))
    {{
        if (SonYon != "F") Sinyal = "F";
        arefeFlat = true;
    }}
    else if (vadeSonuGun && t > new TimeSpan(17,40,0))
    {{
        if (SonYon != "F") Sinyal = "F";
        warmupAktif = true; warmupBaslangicBar = -999; arefeFlat = false;
    }}
    
    if (Sinyal == "F") {{
        if (SonYon != Sinyal) {{ 
            Sistem.Yon[i] = Sinyal; 
            SonYon = Sinyal; 
            inLong = false; inShort = false; cooldownCt=COOLDOWN_BARS; barsInPos=0; 
        }}
        continue;
    }}
    
    if ((arefe && t > new TimeSpan(11,30,0)) || (vadeSonuGun && !arefe && t > new TimeSpan(17,40,0))) continue;

    if (warmupAktif && warmupBaslangicBar == -999) {{
        bool yeniSeans = false;
        if (aksamSeansi && i>0 && V[i-1].Date.TimeOfDay < new TimeSpan(19,0,0)) yeniSeans = true;
        if (gunSeansi && i>0 && dt.Date != V[i-1].Date.Date) yeniSeans = true;
        if (yeniSeans) warmupBaslangicBar = i;
    }}
    if (warmupAktif && warmupBaslangicBar > 0) {{
        if ((i - warmupBaslangicBar) < 100) continue; // Min 100 bar cooldown
        else warmupAktif = false;
    }}
    if (arefeFlat && i>0 && dt.Date != V[i-1].Date.Date) arefeFlat = false;

    // --- COOLDOWN ---
    if (cooldownCt > 0) cooldownCt--;

    // --- CONDITIONS ---
    bool rejim_long = (C[i] > ARS_EMA[i]) && (C[i] < ARS_EMA[i] + ARS_Band[i]);
    bool rejim_short = (C[i] < ARS_EMA[i]) && (C[i] > ARS_EMA[i] - ARS_Band[i]);
    
    bool st_long = (ST[i] < C[i]);
    bool st_short = (ST[i] > C[i]);
    bool ema_long = (EMA_FAST[i] > EMA_SLOW[i]);
    bool ema_short = (EMA_FAST[i] < EMA_SLOW[i]);
    
    bool trend_long = st_long && ema_long;
    bool trend_short = st_short && ema_short;

    bool toma_kros_up = (TOMA_Trend[i] > 0) && (TOMA_Trend[i - 1] <= 0);
    bool toma_kros_down = (TOMA_Trend[i] < 0) && (TOMA_Trend[i - 1] >= 0);
    
    bool hhv_break = C[i] > TETIK_HHV[i-1];
    bool llv_break = C[i] < TETIK_LLV[i-1];
    
    bool tetik_long = toma_kros_up || hhv_break;
    bool tetik_short = toma_kros_down || llv_break;
    
    bool mfi_long_ok = (MFI[i] > MFI_LONG) && (MFI[i] > MFI_HHV[i-1]);
    bool mfi_short_ok = (MFI[i] < MFI_SHORT) && (MFI[i] < MFI_LLV[i-1]);
    
    bool vol_ok = (LotData[i] >= VOL_MA[i-1] * VOL_RATIO);
    
    bool onay_long = mfi_long_ok && vol_ok;
    bool onay_short = mfi_short_ok && vol_ok;
    bool cooldown_ok = (cooldownCt == 0);
    
    // --- GİRİŞ MANTIĞI ---
    bool giris_long = (!inLong) && (!inShort) && rejim_long && trend_long && tetik_long && onay_long && cooldown_ok && YON_MODU != "SADECE_SAT";
    bool giris_short = (!inLong) && (!inShort) && rejim_short && trend_short && tetik_short && onay_short && cooldown_ok && YON_MODU != "SADECE_AL" && VadeTipi != "SPOT";

    if (Sinyal == "")
    {{
        if (giris_long)
        {{
            Sinyal = "A";
            inLong = true;
            entryPrice = C[i];
            extremeVal = C[i];
            stopLevel = entryPrice - ATR[i] * ATR_STOP_MULT_LONG;
            barsInPos = 0;
        }}
        else if (giris_short)
        {{
            Sinyal = "S";
            inShort = true;
            entryPrice = C[i];
            extremeVal = C[i];
            stopLevel = entryPrice + ATR[i] * ATR_STOP_MULT_SHORT;
            barsInPos = 0;
        }}
    }}

    // --- LONG ÇIKIŞ MANTIĞI ---
    if (inLong && Sinyal == "")
    {{
        barsInPos++;
        if (C[i] > extremeVal) {{
            extremeVal = C[i];
            stopLevel = extremeVal - ATR[i] * ATR_STOP_MULT_LONG;
        }}
        
        float kar_al_fiyat = entryPrice * (1.0f + KAR_AL_YUZDE_LONG / 100.0f);
        bool stop_hit = (C[i] <= stopLevel);
        bool kar_al_hit = (C[i] >= kar_al_fiyat);
        bool rejim_kirildi = !rejim_long;
        bool trend_kirildi = !trend_long;
        bool min_hold_ok = (barsInPos >= MIN_HOLD_BARS);
        bool max_hold_hit = (barsInPos >= MAX_HOLD_BARS);
        
        if (stop_hit || kar_al_hit || rejim_kirildi || (trend_kirildi && min_hold_ok) || max_hold_hit)
        {{
            Sinyal = "F";
            inLong = false;
            cooldownCt = COOLDOWN_BARS;
            barsInPos = 0;
            entryPrice = 0f;
            extremeVal = 0f;
            stopLevel = 0f;
        }}
    }}

    // --- SHORT ÇIKIŞ MANTIĞI ---
    if (inShort && Sinyal == "")
    {{
        barsInPos++;
        if (C[i] < extremeVal) {{
            extremeVal = C[i];
            stopLevel = extremeVal + ATR[i] * ATR_STOP_MULT_SHORT;
        }}
        
        float kar_al_fiyat = entryPrice * (1.0f - KAR_AL_YUZDE_SHORT / 100.0f);
        bool stop_hit = (C[i] >= stopLevel);
        bool kar_al_hit = (C[i] <= kar_al_fiyat);
        bool rejim_kirildi = !rejim_short;
        bool trend_kirildi = !trend_short;
        bool min_hold_ok = (barsInPos >= MIN_HOLD_BARS);
        bool max_hold_hit = (barsInPos >= MAX_HOLD_BARS);
        
        if (stop_hit || kar_al_hit || rejim_kirildi || (trend_kirildi && min_hold_ok) || max_hold_hit)
        {{
            Sinyal = "F";
            inShort = false;
            cooldownCt = COOLDOWN_BARS;
            barsInPos = 0;
            entryPrice = 0f;
            extremeVal = 0f;
            stopLevel = 0f;
        }}
    }}

    // --- YÖN GÜNCELLEME ---
    if (Sinyal != "" && SonYon != Sinyal)
    {{
        SonYon = Sinyal;
        Sistem.Yon[i] = SonYon;
    }}
}}

// --- ÇİZİMLER ---
Sistem.Cizgiler[0].Deger = ST;
Sistem.Cizgiler[0].Aciklama = "SuperTrend";
Sistem.Cizgiler[0].ActiveBool = true;
Sistem.Cizgiler[0].Renk = Color.Yellow;
Sistem.Cizgiler[1].Deger = TOMA_Line;
Sistem.Cizgiler[1].Aciklama = "TOMA";
Sistem.Cizgiler[2].Deger = ARS_EMA;
Sistem.Cizgiler[2].Aciklama = "ARS EMA";

{self._get_performance_panel_code()}
'''
        return code

    def export_strategy7(

        self, 
        params: Dict[str, Any], 
        vade_tipi: str = "ENDEKS"
    ) -> str:
        """
        Strateji 7 (DeepScalp) Kodunu Export Eder
        """
        filename = self._generate_filename(7, vade_tipi)
        
        code = self._generate_strategy7_code(params, vade_tipi)
        
        filepath = self.output_dir / f"{filename}.cs"
        filepath.write_text(code, encoding='utf-8')
        
        # Parametreleri JSON olarak da kaydet
        params_path = self.output_dir / f"{filename}_params.json"
        params_path.write_text(json.dumps(params, indent=2, default=str), encoding='utf-8')
        
        return str(filepath)

    def _generate_strategy8_code(self, params: Dict[str, Any], vade_tipi: str) -> str:
        """Strateji 8 (Gap Reversal v1.0) IdealData kodu oluşturur."""

        p = {
            'min_gap_pct':      params.get('min_gap_pct', 0.05),
            'max_gap_pct':      params.get('max_gap_pct', 2.00),
            'cuma_aktif':       params.get('cuma_aktif', False),
            'or_bars':          int(params.get('or_bars', 15)),
            'rsi_filtre_aktif': params.get('rsi_filtre_aktif', True),
            'rsi_period':       int(params.get('rsi_period', 5)),
            'rsi_ob':           params.get('rsi_ob', 62.0),
            'rsi_os':           params.get('rsi_os', 38.0),
            'hacim_filtre_aktif': params.get('hacim_filtre_aktif', True),
            'hacim_ma_period':  int(params.get('hacim_ma_period', 20)),
            'hacim_oran':       params.get('hacim_oran', 0.8),
            'atr_period':       int(params.get('atr_period', 14)),
            'atr_stop_mult':    params.get('atr_stop_mult', 0.5),
            'gap_window_bars':  int(params.get('gap_window_bars', 210)),
            'cooldown_bars':    int(params.get('cooldown_bars', 3)),
            'yon_modu':         params.get('yon_modu', 'CIFT'),
        }
        boolstr = lambda b: 'true' if b else 'false'

        code = f'''// ===============================================================================================
// STRATEJİ 8: VIP_X030-T 1DK GAP REVERSAL v1.0
// ===============================================================================================
// Sembol   : {self.symbol}
// Periyot  : {self.period}
// Vade Tipi: {vade_tipi}
// Oluşturma: {datetime.now().strftime("%Y-%m-%d %H:%M")}
// ===============================================================================================
//
// [MANTIK]
//   BIST30 vadeli piyasasında gece gap'lerinin %92'si aynı gün içinde kapanmaktadır.
//   TEMEL FİKİR: Gap = Yay. Ne kadar gerilirse, o kadar geri döner.
//   Strateji gap yönünün TERSİNE girer. Hedef = önceki günün kapanışı (gap fill seviyesi).
// ===============================================================================================

string VadeTipi = "{vade_tipi}";
string YON_MODU = "{p['yon_modu']}";               // "SADECE_AL" | "SADECE_SAT" | "CIFT"

// ─── KATMAN 1: GAP FİLTRE ─────────────────────────────────────────────────────
float MIN_GAP_PCT       = {p['min_gap_pct']}f;
float MAX_GAP_PCT       = {p['max_gap_pct']}f;
bool  CUMA_AKTIF        = {boolstr(p['cuma_aktif'])};

// ─── KATMAN 2: AÇILIŞ ARIĞI ───────────────────────────────────────────────────
int   OR_BARS           = {p['or_bars']};

// ─── KATMAN 4: RSI ────────────────────────────────────────────────────────────
bool  RSI_FILTRE_AKTIF  = {boolstr(p['rsi_filtre_aktif'])};
int   RSI_PERIOD        = {p['rsi_period']};
float RSI_OB            = {p['rsi_ob']}f;
float RSI_OS            = {p['rsi_os']}f;

// ─── KATMAN 5: HACİM ──────────────────────────────────────────────────────────
bool  HACIM_FILTRE_AKTIF = {boolstr(p['hacim_filtre_aktif'])};
int   HACIM_MA_PERIOD   = {p['hacim_ma_period']};
float HACIM_ORAN        = {p['hacim_oran']}f;

// ─── KATMAN 6: ATR STOPU ──────────────────────────────────────────────────────
int   ATR_PERIOD        = {p['atr_period']};
float ATR_STOP_MULT     = {p['atr_stop_mult']}f;

// ─── KATMAN 8: ZAMAN STOPU ────────────────────────────────────────────────────
int   GAP_WINDOW_BARS   = {p['gap_window_bars']};

// ─── GENEL ────────────────────────────────────────────────────────────────────
int   COOLDOWN_BARS     = {p['cooldown_bars']};

// ===============================================================================================
// TATİL VE VADE SONU
// ===============================================================================================
int yil = DateTime.Now.Year;
DateTime R2024 = new DateTime(2024, 4, 10); DateTime K2024 = new DateTime(2024, 6, 16);
DateTime R2025 = new DateTime(2025, 3, 30); DateTime K2025 = new DateTime(2025, 6, 6);
DateTime R2026 = new DateTime(2026, 3, 20); DateTime K2026 = new DateTime(2026, 5, 27);
DateTime R2027 = new DateTime(2027, 3, 9);  DateTime K2027 = new DateTime(2027, 5, 16);
string[] resmiTatiller = new string[] {{ "01.01","04.23","05.01","05.19","07.15","08.30","10.29" }};

Func<DateTime, DateTime> VadeSonuIsGunu = (dt) =>
{{
    var d = new DateTime(dt.Year, dt.Month, DateTime.DaysInMonth(dt.Year, dt.Month));
    for (int k = 0; k < 15; k++)
    {{
        if (d.DayOfWeek == DayOfWeek.Saturday || d.DayOfWeek == DayOfWeek.Sunday)
            {{ d = d.AddDays(-1); continue; }}
        string mmdd = d.ToString("MM.dd");
        bool tatil = false;
        for (int tx = 0; tx < resmiTatiller.Length; tx++)
            if (resmiTatiller[tx] == mmdd) {{ tatil = true; break; }}
        if (tatil) {{ d = d.AddDays(-1); continue; }}
        if ((d >= R2024 && d <= R2024.AddDays(3)) || (d >= K2024 && d <= K2024.AddDays(4)) ||
            (d >= R2025 && d <= R2025.AddDays(3)) || (d >= K2025 && d <= K2025.AddDays(4)) ||
            (d >= R2026 && d <= R2026.AddDays(3)) || (d >= K2026 && d <= K2026.AddDays(4)) ||
            (d >= R2027 && d <= R2027.AddDays(3)) || (d >= K2027 && d <= K2027.AddDays(4)))
            {{ d = d.AddDays(-1); continue; }}
        break;
    }}
    return d.Date;
}};

// ===============================================================================================
// VERİ & GÖSTERGELER
// ===============================================================================================
var V       = Sistem.GrafikVerileri;
var O       = Sistem.GrafikFiyatSec("Acilis");
var C       = Sistem.GrafikFiyatSec("Kapanis");
var H       = Sistem.GrafikFiyatSec("Yuksek");
var L       = Sistem.GrafikFiyatSec("Dusuk");
var LotData = Sistem.GrafikFiyatSec("Hacim");

var ATR      = Sistem.AverageTrueRange(ATR_PERIOD);
var EMA50    = Sistem.MA(C, "Exp", 50);
var HacimMA  = Sistem.MA(LotData, "Simple", HACIM_MA_PERIOD);

// ─── RSI Manuel Hesaplama (Wilder's Smoothing) ────────────────────────────────
var RSI_Ser = Sistem.Liste(50f);
{{
    float ag = 0f, al = 0f;
    for (int j = 1; j < V.Count; j++)
    {{
        float delta = C[j] - C[j - 1];
        float gain  = delta > 0f ? delta : 0f;
        float loss  = delta < 0f ? -delta : 0f;

        if (j < RSI_PERIOD)
        {{
            ag += gain; al += loss;
            RSI_Ser[j] = 50f;
        }}
        else if (j == RSI_PERIOD)
        {{
            ag = (ag + gain) / RSI_PERIOD;
            al = (al + loss) / RSI_PERIOD;
            RSI_Ser[j] = al == 0f ? 100f : 100f - (100f / (1f + ag / al));
        }}
        else
        {{
            ag = (ag * (RSI_PERIOD - 1) + gain) / RSI_PERIOD;
            al = (al * (RSI_PERIOD - 1) + loss) / RSI_PERIOD;
            RSI_Ser[j] = al == 0f ? 100f : 100f - (100f / (1f + ag / al));
        }}
    }}
}}

// ─── Görselleştirme Serileri ──────────────────────────────────────────────────
var _ORHigh  = Sistem.Liste(0f);
var _ORLow   = Sistem.Liste(0f);
var _FillLvl = Sistem.Liste(0f);
var _StopLvl = Sistem.Liste(0f);

// ===============================================================================================
// DURUM DEĞİŞKENLERİ
// ===============================================================================================
string SonYon = "", Sinyal = "";
bool  inLong  = false, inShort = false;
float entryPrice = 0f, stopLevel = 0f;
int   barsInPos  = 0,  cooldownCt = 0;

bool  gapActive  = false;
float gapFillLvl = 0f;
float gapPctAbs  = 0f;
int   gapDir     = 0;

bool  orComplete = false;
float orHigh     = 0f;
float orLow      = float.MaxValue;
int   orStartBar = -1;
int   posStartBar = -1;

for (int i = 1; i < V.Count; i++) Sistem.Yon[i] = "";
int warmBars = Math.Max(ATR_PERIOD, Math.Max(50, HACIM_MA_PERIOD)) + RSI_PERIOD + 30;

// ===============================================================================================
// SINYAL DÖNGÜSÜ
// ===============================================================================================
for (int i = warmBars; i < V.Count; i++)
{{
    Sinyal = "";
    var dt = V[i].Date;
    var t  = dt.TimeOfDay;

    bool emirToplama = t >= new TimeSpan(9, 25, 0)  && t < new TimeSpan(9, 30, 0);
    bool gunSeansi   = t >= new TimeSpan(9, 30, 0)  && t <= new TimeSpan(18, 9, 59);
    bool aksamSeansi = t >= new TimeSpan(19, 0, 0)  && t <= new TimeSpan(22, 59, 59);
    if (!(emirToplama || gunSeansi || aksamSeansi)) continue;

    bool vadeAyi  = (dt.Month % 2 == 0);
    bool vadeSonu = vadeAyi && (dt.Date == VadeSonuIsGunu(dt));
    bool arefe    = dt.Date == R2024.AddDays(-1).Date || dt.Date == K2024.AddDays(-1).Date ||
                    dt.Date == R2025.AddDays(-1).Date || dt.Date == K2025.AddDays(-1).Date ||
                    dt.Date == R2026.AddDays(-1).Date || dt.Date == K2026.AddDays(-1).Date ||
                    dt.Date == R2027.AddDays(-1).Date || dt.Date == K2027.AddDays(-1).Date;

    if ((arefe || vadeSonu) && t > new TimeSpan(11, 30, 0))
    {{
        if (SonYon != "F") Sinyal = "F";
        inLong = false; inShort = false; gapActive = false;
        orComplete = false; posStartBar = -1;
        if (Sinyal != "" && SonYon != Sinyal) {{ SonYon = Sinyal; Sistem.Yon[i] = SonYon; }}
        continue;
    }}

    if (i > warmBars)
    {{
        double saatFark = (V[i].Date - V[i - 1].Date).TotalHours;
        bool geceSonrasi = (saatFark > 6.0 && saatFark < 15.0) && emirToplama;

        if (geceSonrasi)
        {{
            if ((inLong || inShort) && SonYon != "F")
            {{
                Sinyal     = "F";
                inLong     = false; inShort = false;
                barsInPos  = 0;    cooldownCt = COOLDOWN_BARS;
                entryPrice = 0f;   stopLevel  = 0f;
                posStartBar = -1;
            }}

            float prevClose = C[i - 1];
            float todayOpen = O[i];
            float rawGap    = todayOpen - prevClose;
            float rawGapPct = prevClose > 0f ? (rawGap / prevClose) * 100f : 0f;

            bool buyukYeterli = Math.Abs(rawGapPct) >= MIN_GAP_PCT;
            bool asiriDegil   = Math.Abs(rawGapPct) <= MAX_GAP_PCT;
            bool cumaOk       = (dt.DayOfWeek != DayOfWeek.Friday) || CUMA_AKTIF;

            gapActive  = buyukYeterli && asiriDegil && cumaOk;
            gapFillLvl = prevClose;
            gapPctAbs  = Math.Abs(rawGapPct);
            gapDir     = rawGap > 0f ? 1 : -1;

            orComplete = false;
            orStartBar = gapActive ? i : -1;
            orHigh     = H[i];
            orLow      = L[i];
            posStartBar = -1;
        }}
    }}

    if (gapActive && !orComplete && orStartBar >= 0)
    {{
        if (!gunSeansi)
        {{
        }}
        else
        {{
            int elapsed = i - orStartBar;
            if (elapsed < OR_BARS)
            {{
                orHigh = Math.Max(orHigh, H[i]);
                orLow  = Math.Min(orLow,  L[i]);
            }}
            else
            {{
                orComplete = true;
            }}
        }}
    }}

    if (gapActive)
    {{
        _ORHigh[i]  = orHigh;
        _ORLow[i]   = orLow;
        _FillLvl[i] = gapFillLvl;
    }}
    if (inLong || inShort)
    {{
        _StopLvl[i] = stopLevel;
    }}

    if (cooldownCt > 0) cooldownCt--;

    bool yeniGirisIzni = gunSeansi;

    bool girisOnKosul = yeniGirisIzni && gapActive && orComplete &&
                        !inLong && !inShort && cooldownCt == 0 && posStartBar < 0;

    if (girisOnKosul && Sinyal == "")
    {{
        int orEndBar = orStartBar + OR_BARS;
        bool zamanOk = (i - orEndBar) < GAP_WINDOW_BARS;
        bool hacimOk = !HACIM_FILTRE_AKTIF || (LotData[i] >= HacimMA[i] * HACIM_ORAN);

        if (gapDir == 1 && YON_MODU != "SADECE_AL" && VadeTipi != "SPOT")
        {{
            bool orKirildi  = C[i] < orLow;
            bool fillOlmadi = C[i] > gapFillLvl;
            bool rsiOk      = !RSI_FILTRE_AKTIF || RSI_Ser[i] > RSI_OB;

            if (zamanOk && orKirildi && fillOlmadi && hacimOk && rsiOk)
            {{
                Sinyal      = "S";
                inShort     = true;
                entryPrice  = C[i];
                stopLevel   = orHigh + ATR[i] * ATR_STOP_MULT;
                barsInPos   = 0;
                posStartBar = i;
            }}
        }}

        if (gapDir == -1 && YON_MODU != "SADECE_SAT")
        {{
            bool orKirildi  = C[i] > orHigh;
            bool fillOlmadi = C[i] < gapFillLvl;
            bool rsiOk      = !RSI_FILTRE_AKTIF || RSI_Ser[i] < RSI_OS;

            if (zamanOk && orKirildi && fillOlmadi && hacimOk && rsiOk)
            {{
                Sinyal      = "A";
                inLong      = true;
                entryPrice  = C[i];
                stopLevel   = orLow - ATR[i] * ATR_STOP_MULT;
                barsInPos   = 0;
                posStartBar = i;
            }}
        }}
    }}

    if (inLong && Sinyal == "")
    {{
        barsInPos++;

        bool stopHit    = L[i] <= stopLevel;
        bool targetHit  = H[i] >= gapFillLvl || C[i] >= gapFillLvl;
        bool zamanDoldu = posStartBar > 0 && (i - posStartBar) >= GAP_WINDOW_BARS;
        bool aksamKapa  = aksamSeansi && t >= new TimeSpan(22, 50, 0);
        bool ters       = C[i] < orLow && barsInPos > 3;

        if (stopHit || targetHit || zamanDoldu || aksamKapa || ters)
        {{
            Sinyal      = "F";
            inLong      = false;
            gapActive   = false;
            cooldownCt  = COOLDOWN_BARS;
            barsInPos   = 0;
            entryPrice  = 0f; stopLevel = 0f; posStartBar = -1;
        }}
    }}

    if (inShort && Sinyal == "")
    {{
        barsInPos++;

        bool stopHit    = H[i] >= stopLevel;
        bool targetHit  = L[i] <= gapFillLvl || C[i] <= gapFillLvl;
        bool zamanDoldu = posStartBar > 0 && (i - posStartBar) >= GAP_WINDOW_BARS;
        bool aksamKapa  = aksamSeansi && t >= new TimeSpan(22, 50, 0);
        bool ters       = C[i] > orHigh && barsInPos > 3;

        if (stopHit || targetHit || zamanDoldu || aksamKapa || ters)
        {{
            Sinyal      = "F";
            inShort     = false;
            gapActive   = false;
            cooldownCt  = COOLDOWN_BARS;
            barsInPos   = 0;
            entryPrice  = 0f; stopLevel = 0f; posStartBar = -1;
        }}
    }}

    if (Sinyal != "" && SonYon != Sinyal)
    {{
        SonYon = Sinyal;
        Sistem.Yon[i] = SonYon;
    }}
}}

// ===============================================================================================
// ÇİZİMLER
// ===============================================================================================
Sistem.Cizgiler[0].Deger      = _ORHigh;
Sistem.Cizgiler[0].Aciklama   = "OR High (Açılış Aralığı Üst)";
Sistem.Cizgiler[0].Renk       = Color.DodgerBlue;
Sistem.Cizgiler[0].ActiveBool = true;

Sistem.Cizgiler[1].Deger      = _ORLow;
Sistem.Cizgiler[1].Aciklama   = "OR Low (Açılış Aralığı Alt)";
Sistem.Cizgiler[1].Renk       = Color.OrangeRed;
Sistem.Cizgiler[1].ActiveBool = true;

Sistem.Cizgiler[2].Deger      = _FillLvl;
Sistem.Cizgiler[2].Aciklama   = "Gap Fill Hedefi (Önceki Kapanış)";
Sistem.Cizgiler[2].Renk       = Color.Gold;
Sistem.Cizgiler[2].ActiveBool = true;

Sistem.Cizgiler[3].Deger      = _StopLvl;
Sistem.Cizgiler[3].Aciklama   = "Stop Seviyesi";
Sistem.Cizgiler[3].Renk       = Color.Tomato;
Sistem.Cizgiler[3].ActiveBool = true;

Sistem.Cizgiler[4].Deger      = EMA50;
Sistem.Cizgiler[4].Aciklama   = "EMA(50) — Bağlam";
Sistem.Cizgiler[4].Renk       = Color.DimGray;
Sistem.Cizgiler[4].ActiveBool = true;

{self._get_performance_panel_code()}'''

        return code

    def export_strategy8(
        self,
        params: Dict[str, Any],
        vade_tipi: str = "ENDEKS"
    ) -> str:
        """
        Strateji 8 (Gap Reversal v1.0) Kodunu Export Eder
        """
        filename = self._generate_filename(8, vade_tipi)

        code = self._generate_strategy8_code(params, vade_tipi)

        filepath = self.output_dir / f"{filename}.cs"
        filepath.write_text(code, encoding='utf-8')

        # Parametreleri JSON olarak da kaydet
        params_path = self.output_dir / f"{filename}_params.json"
        params_path.write_text(json.dumps(params, indent=2, default=str), encoding='utf-8')

        return str(filepath)

    def export_strategy5(
        self, 
        params: Dict[str, Any], 
        vade_tipi: str = "ENDEKS"
    ) -> str:
        """
        Strateji 5 (Oliver Kell) Kodunu Export Eder
        """
        filename = self._generate_filename(5, vade_tipi)
        
        code = self._generate_strategy5_code(params, vade_tipi)
        
        filepath = self.output_dir / f"{filename}.cs"
        filepath.write_text(code, encoding='utf-8')
        
        # Parametreleri JSON olarak da kaydet
        params_path = self.output_dir / f"{filename}_params.json"
        params_path.write_text(json.dumps(params, indent=2, default=str), encoding='utf-8')
        
        return str(filepath)

    def export_strategy3(
        self, 
        params: Dict[str, Any], 
        vade_tipi: str = "ENDEKS"
    ) -> str:
        """
        Strateji 3 Kodunu Export Eder
        """
        filename = self._generate_filename(3, vade_tipi)
        
        code = self._generate_strategy3_code(params, vade_tipi)
        
        filepath = self.output_dir / f"{filename}.cs"
        filepath.write_text(code, encoding='utf-8')
        
        # Parametreleri JSON olarak da kaydet
        params_path = self.output_dir / f"{filename}_params.json"
        params_path.write_text(json.dumps(params, indent=2, default=str), encoding='utf-8')
        
        return str(filepath)

    def export_strategy4(
        self, 
        params: Dict[str, Any], 
        vade_tipi: str = "ENDEKS"
    ) -> str:
        """
        Strateji 4 Kodunu Export Eder
        """
        filename = self._generate_filename(4, vade_tipi)
        
        code = self._generate_strategy4_code(params, vade_tipi)
        
        filepath = self.output_dir / f"{filename}.cs"
        filepath.write_text(code, encoding='utf-8')
        
        # Parametreleri JSON olarak da kaydet
        params_path = self.output_dir / f"{filename}_params.json"
        params_path.write_text(json.dumps(params, indent=2, default=str), encoding='utf-8')
        
        return str(filepath)
    
    def export_all(
        self,
        params1: Dict[str, Any],
        params2: Dict[str, Any],
        params3: Dict[str, Any],
        params4: Dict[str, Any],
        params5: Dict[str, Any] = None,
        params6: Dict[str, Any] = None,
        params7: Dict[str, Any] = None,
        vade_tipi: str = "ENDEKS",
        lot_size: int = 1
    ) -> Dict[str, str]:
        """
        Tüm dosyaları tek seferde export eder.
        
        Returns:
            Dict with 'strategy1', 'strategy2', 'strategy3', 'strategy4', 'strategy5', 'strategy6', 'strategy7', 'robot' paths
        """
        s1_path = self.export_strategy1(params1, vade_tipi)
        s2_path = self.export_strategy2(params2, vade_tipi)
        s3_path = self.export_strategy3(params3, vade_tipi)
        s4_path = self.export_strategy4(params4, vade_tipi)
        
        s5_path = self.export_strategy5(params5, vade_tipi) if params5 else None
        s6_path = self.export_strategy6(params6, vade_tipi) if params6 else None
        s7_path = self.export_strategy7(params7, vade_tipi) if params7 else None
        
        robot_path = self.export_combined_robot(lot_size)
        
        return {
            'strategy1': s1_path,
            'strategy2': s2_path,
            'strategy3': s3_path,
            'strategy4': s4_path,
            'strategy5': s5_path,
            'strategy6': s6_path,
            'strategy7': s7_path,
            'robot': robot_path
        }

# --- TEST ---
if __name__ == "__main__":
    params1 = {}
    params2 = {
        'exit_confirm_bars': 3
    }
    params3 = {}
    params4 = {}
    
    exporter = IdealDataExporter(
        symbol="VIP'VIP-X030",
        period="5"
    )
    
    result = exporter.export_strategy2(params2, "ENDEKS")
    
    print("Export tamamlandı!")
    print(f"Strateji: {result}")
