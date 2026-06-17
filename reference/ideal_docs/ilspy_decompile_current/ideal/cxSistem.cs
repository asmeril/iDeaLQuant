using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using Microsoft.Office.Interop.Excel;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class cxSistem
{
	public class GridMessageClass
	{
		public List<object> Parameters;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GridMessageClass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GridMessageClass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[Serializable]
	public class HisseAnalizIndicatorClass
	{
		public string IndicatorName;

		public string Discription;

		public bool KesisimBool;

		public bool AlisBool;

		public bool SatisBool;

		public List<ParameterHA> Parameters;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<HisseAnalizIndicatorClass> CloneIndicator(List<HisseAnalizIndicatorClass> indicatorX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HisseAnalizIndicatorClass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static HisseAnalizIndicatorClass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[Serializable]
	public class ParameterHA
	{
		public int index;

		public string IndicatorName;

		public double Param;

		public double Opt1;

		public double Opt2;

		public double Step;

		public string MaYontem;

		public bool OptBool;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object Clone()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ParameterHA()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ParameterHA()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private class TakasPozisyon
	{
		public string Kurum;

		public List<float> Deger;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TakasPozisyon()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TakasPozisyon()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public int ClassVersion;

	public string Name;

	public string SourceCode;

	public int DecimalPoint;

	public bool Sifreli;

	public bool IndicatorBool;

	public byte IndicatorRegion;

	public List<cxSistemLineRecord> Cizgiler;

	public List<string> Parametreler;

	public Font Font;

	public byte Compiler;

	public string Tip;

	public bool SablonBool;

	public string StratejiTip;

	public List<float> Parametre;

	public List<float> OptBaslangic;

	public List<float> OptBitis;

	public List<float> OptAdim;

	public int OptParametreSayisi;

	public string MaYontem;

	public int CiftTip;

	public bool StopBool;

	public int StopTip;

	public decimal StopIzleyenYuzdex;

	public decimal StopSabitYuzdex;

	public int StopYuksekDusukBar;

	public bool KarBool;

	public decimal KarYuzdex;

	public bool KarRasyoBool;

	public decimal KarRasyoBindex;

	public string InputSistem;

	public int StopYontem;

	public float GetiriKayma;

	public int KarAlTip;

	public decimal KarAlPuanx;

	public decimal StopIzleyenPuanx;

	public decimal StopSabitPuanx;

	public bool PozKapatBool;

	public string PozKapatSaat;

	public bool SaatOncesiSinyalYokBool;

	public string SaatOncesiSinyalYokSaat;

	public bool FlatSonrasiBarBool;

	public int FlatSonrasiBarCount;

	public bool FlatSonrasiGunBool;

	public bool CumaKapat_Bool;

	public bool HerAyKapat_Bool;

	public bool IkiAyKapat_Bool;

	public string CumaKapatSaat;

	public string HerAyKapatSaat;

	public string IkiAyKapatSaat;

	public bool GunKarBool;

	public decimal GunKarMiktar;

	public bool GunZararBool;

	public decimal GunZararMiktar;

	public bool StopIzleyenYuzdeBool;

	public bool StopSabitYuzdeBool;

	public bool StopBarBool;

	public bool StopIzleyenPuanBool;

	public bool StopSabitPuanBool;

	public bool StopSeviyeIzleyenBool;

	public decimal StopSeviyeIzleyenSeviye;

	public decimal StopSeviyeIzleyenYuzde;

	public string EditDayanakSistem;

	public string EditYontem;

	public decimal Feedback01_Param1;

	public decimal Feedback01_Param2;

	public decimal Feedback01_Param3;

	public decimal Feedback01_Param4;

	public decimal Feedback02_Param1;

	public decimal Feedback02_Param2;

	public decimal Feedback02_Param3;

	public decimal Feedback03_Param1;

	public decimal Feedback03_Param2;

	public decimal Feedback03_Param3;

	public decimal Feedback04_Param1;

	public decimal Feedback04_Param2;

	public decimal Feedback05_Param1;

	public decimal Feedback05_Param2;

	public decimal Feedback05_Param3;

	public decimal Feedback06_Param1;

	public decimal Feedback06_Param2;

	public decimal Feedback06_Param3;

	public decimal Feedback07_Param1;

	public decimal Feedback07_Param2;

	public decimal Feedback07_Param3;

	public decimal Feedback08_Param1;

	public decimal Feedback08_Param2;

	public decimal Feedback09_Param1;

	public decimal Feedback09_Param2;

	public decimal Feedback09_Param3;

	public decimal Feedback10_Param1;

	public decimal Feedback10_Param2;

	public decimal Feedback10_Param3;

	public decimal Feedback10_Param4;

	public decimal Feedback11_Param1;

	public decimal Feedback11_Param2;

	public decimal Feedback12_Param1;

	public decimal Feedback12_Param2;

	public decimal Feedback12_Param3;

	public decimal Feedback13_Param1;

	public decimal Feedback13_Param2;

	public decimal Feedback13_Param3;

	public decimal Feedback14_Param1;

	public decimal Feedback15_Param1;

	public decimal Feedback15_Param2;

	public decimal Feedback16_Param1;

	public decimal Feedback16_Param2;

	public decimal Feedback16_Param3;

	public decimal Feedback17_Param1;

	public decimal Feedback17_Param2;

	public decimal Feedback17_Param3;

	public decimal Feedback18_Param1;

	public decimal Feedback18_Param2;

	public decimal Feedback18_Param3;

	public decimal Feedback19_Param1;

	public decimal Feedback19_Param2;

	public decimal Feedback19_Param3;

	public decimal Feedback20_Param1;

	public decimal Feedback20_Param2;

	public decimal Feedback20_Param3;

	public List<HisseAnalizIndicatorClass> HisseAnalizIndicators;

	[NonSerialized]
	public int SelectBarNo;

	[NonSerialized]
	public DateTime SelectTarih;

	[NonSerialized]
	public object ObjectInstance;

	[NonSerialized]
	public List<string> Yon;

	[NonSerialized]
	public List<float> Seviye;

	[NonSerialized]
	public List<OptimizerClass> OptimizerList;

	[NonSerialized]
	public string OptimizerAciklama;

	[NonSerialized]
	public decimal OptimizerKarZarar;

	[NonSerialized]
	public int OptimizerMaxTryCount;

	[NonSerialized]
	public int OptimizerCurrentTry;

	[NonSerialized]
	public decimal OptimizerMaxKar;

	[NonSerialized]
	public List<TradeClass> TradeList;

	[NonSerialized]
	public bool HizliMod;

	[NonSerialized]
	public string Sembol;

	[NonSerialized]
	public string Periyot;

	[NonSerialized]
	public int BarSayisi;

	[NonSerialized]
	public List<cxBar> GrafikVerileri;

	[NonSerialized]
	public cxBasic YuzeyselVeri;

	[NonSerialized]
	public cxDepth DerinlikVeri;

	[NonSerialized]
	public int FrameCount;

	[NonSerialized]
	public string AlgoIslem;

	[NonSerialized]
	public string AlgoAciklama;

	[NonSerialized]
	public List<SistemObjectClass> ObjectList;

	[NonSerialized]
	public List<SistemDolguClass> DolguList;

	[NonSerialized]
	public object[] SorguDeger;

	[NonSerialized]
	public Color[] SorguHucreZeminRengi;

	[NonSerialized]
	public Color[] SorguHucreYaziRengi;

	[NonSerialized]
	public string[] SorguSutunTip;

	[NonSerialized]
	public string[] SorguSutunHizala;

	[NonSerialized]
	public int[] SorguSutunGenislik;

	[NonSerialized]
	public int[] SorguOndalik;

	[NonSerialized]
	public string[] SorguBaslik;

	[NonSerialized]
	public string SorguAciklama;

	[NonSerialized]
	public Color SorguYaziRengi;

	[NonSerialized]
	public Color SorguZeminRengi;

	[NonSerialized]
	public int SorguAciklamaGenislik;

	[NonSerialized]
	public bool SorguEklendi;

	[NonSerialized]
	public string MailServerAdres;

	[NonSerialized]
	public int MailServerPort;

	[NonSerialized]
	public string MailKonu;

	[NonSerialized]
	public string MailMetin;

	[NonSerialized]
	public string MailGonderenAdres;

	[NonSerialized]
	public string MailGonderenSifre;

	[NonSerialized]
	public string MailGonderenKullaniciAdi;

	[NonSerialized]
	public List<string> MailAliciList;

	[NonSerialized]
	public List<string> MailCcList;

	[NonSerialized]
	public List<string> MailBccList;

	[NonSerialized]
	public List<string> MailDosyaList;

	[NonSerialized]
	public string MailCC;

	[NonSerialized]
	public List<float> GetiriMiktar;

	[NonSerialized]
	public List<float> GetiriPozisyon;

	[NonSerialized]
	public List<float> GetiriKZ;

	[NonSerialized]
	public List<float> GetiriKZPoz;

	[NonSerialized]
	public List<float> GetiriKZGun;

	[NonSerialized]
	public List<float> GetiriKZAy;

	[NonSerialized]
	public List<float> GetiriKZYil;

	[NonSerialized]
	public decimal GetiriKarIslem;

	[NonSerialized]
	public decimal GetiriZararIslem;

	[NonSerialized]
	public decimal GetiriNotrIslem;

	[NonSerialized]
	public decimal GetiriKarIslemOran;

	[NonSerialized]
	public decimal GetiriToplamIslem;

	[NonSerialized]
	public decimal GetiriKarMiktar;

	[NonSerialized]
	public decimal GetiriZararMiktar;

	[NonSerialized]
	public decimal ProfitFactor;

	[NonSerialized]
	public decimal GetiriNetKar;

	[NonSerialized]
	public List<float> GetiriIslemSayisiPoz;

	[NonSerialized]
	public List<float> GetiriIslemSayisiGun;

	[NonSerialized]
	public List<float> GetiriIslemSayisiAy;

	[NonSerialized]
	public List<float> GetiriIslemSayisiYil;

	[NonSerialized]
	public List<float> GetiriKZAyNet;

	[NonSerialized]
	public List<float> GetiriKZAyYuzde;

	[NonSerialized]
	public List<float> GetiriKZYilNet;

	[NonSerialized]
	public DateTime GetiriMaxDDDateStart;

	[NonSerialized]
	public DateTime GetiriMaxDDDateEnd;

	[NonSerialized]
	public DateTime GetiriMaxDDTarih;

	[NonSerialized]
	public decimal GetiriMaxDD;

	[NonSerialized]
	public DateTime OptimizasyonStartDate;

	[NonSerialized]
	public DateTime OptimizasyonEndDate;

	[NonSerialized]
	public int OptimizasyonStartBarNo;

	[NonSerialized]
	public int OptimizasyonEndBarNo;

	[NonSerialized]
	public bool OptimizasyonMaxDDBool;

	[NonSerialized]
	public List<float> GetiriKZGunSonu;

	[NonSerialized]
	public List<float> GetiriKZGunBasi;

	[NonSerialized]
	public decimal GetiriMutluGun;

	[NonSerialized]
	public decimal GetiriMutsuzGun;

	[NonSerialized]
	public List<float> GetiriKZAySonu;

	[NonSerialized]
	public decimal GetiriBuAy;

	[NonSerialized]
	public decimal GetiriBirAy;

	[NonSerialized]
	public List<float> SayiListesi;

	[NonSerialized]
	public string SonYon;

	[NonSerialized]
	public bool CanliKarAlBool;

	[NonSerialized]
	public bool CanliStopBool;

	[NonSerialized]
	public string ErrorMessage;

	[NonSerialized]
	public string LastBarDate1String;

	[NonSerialized]
	public string LastBarDate2String;

	[NonSerialized]
	public bool CanliPozKapatBool;

	[NonSerialized]
	public TimeSpan SonSistemRunTime;

	[NonSerialized]
	public List<float> ProfitFactorList;

	[NonSerialized]
	public List<List<cxBar>> BarDataList;

	[NonSerialized]
	public List<int> BarPanelList;

	[NonSerialized]
	public List<int> BarTipList;

	[NonSerialized]
	public List<Color> BarYukselenRenkList;

	[NonSerialized]
	public List<Color> BarDusenRenkList;

	[NonSerialized]
	public string EmirTeyidSembol;

	[NonSerialized]
	public int EmirTeyidMiktar;

	[NonSerialized]
	public decimal EmirTeyidFiyat;

	[NonSerialized]
	public readonly bool BMC;

	[NonSerialized]
	public readonly bool FSYSTEM;

	[NonSerialized]
	public readonly bool HISSEANALIZ;

	[NonSerialized]
	public List<string> TakasGunKurumList;

	[NonSerialized]
	public List<List<float>> TakasGunDataList;

	[NonSerialized]
	public List<List<float>> TakasGunDataListLot;

	[NonSerialized]
	public List<float> TakasIlkBesTopYuz;

	[NonSerialized]
	public List<float> TakasDigerTopYuz;

	[NonSerialized]
	public string SonSinyalTarih;

	[NonSerialized]
	public int TaramaKapat;

	[NonSerialized]
	public bool RobotEnabled;

	[NonSerialized]
	public bool LisansChecked;

	[NonSerialized]
	public string EmirHesapAdi;

	[NonSerialized]
	public string EmirAltHesap;

	[NonSerialized]
	public string EmirSembol;

	[NonSerialized]
	public object EmirFiyati;

	[NonSerialized]
	public double EmirMiktari;

	[NonSerialized]
	public string EmirSuresi;

	[NonSerialized]
	public string EmirTipi;

	[NonSerialized]
	public string EmirIslem;

	[NonSerialized]
	public string EmirSatisTipi;

	[NonSerialized]
	public string EmirAcigaSatisKapama;

	[NonSerialized]
	public string EmirFiyatTipi;

	[NonSerialized]
	public object EmirStop;

	[NonSerialized]
	public string EmirBitisTarih;

	[NonSerialized]
	public DateTime EmirEndDate;

	[NonSerialized]
	public string EmirAciklama;

	[NonSerialized]
	public byte EmirAksamSeansi;

	[NonSerialized]
	public bool EmirGenelSatis;

	[NonSerialized]
	public bool EmirSartBool;

	[NonSerialized]
	public string EmirSartSembol;

	[NonSerialized]
	public object EmirSartFiyat;

	[NonSerialized]
	public string EmirSartTipi;

	public static formSistemDefine ReferenceDefinition;

	public static Point LocationDefiniton;

	public static Size SizeDefinition;

	public static formSistemPerformance ReferencePerformance;

	public static Point LocationPerformance;

	public static Size SizePerformance;

	public static formSistemPosition ReferencePosition;

	public static Point LocationPosition;

	public static Size SizePosition;

	public static formSistemCompare ReferenceCompare;

	public static Point LocationCompare;

	public static Size SizeCompare;

	public static formSistemMulti ReferenceMulti;

	public static Point LocationMulti;

	public static Size SizeMulti;

	public static Dictionary<string, cxSistem> Dictionary;

	public static bool ReadBool;

	public static bool ReadingFinished;

	public static int PerformanceBarCount;

	public static int OptimizerBarCount;

	public static bool PerformanceShortSellAllowed;

	public static bool OptimizerShortSellAllowed;

	public static decimal PerformanceInitialCash;

	public static decimal PerformanceLot;

	public static string PerformanceLotStyle;

	public static string PositionDateFilter;

	public static string PositionSymbolFilter;

	public static string AlgoAction;

	public static int AlgoListPos;

	public static bool AlgoRunning;

	public static string UserSymbolsSistemName;

	public static int UserSymbolRunCount;

	public static long KeySistem1;

	public static long KeySistem2;

	public static long KeySistem3;

	public static long KeySistem4;

	public static long KeySistem5;

	public static long KeySistem6;

	public static long PortfoyKey1;

	public static long PortfoyKey2;

	public static string RobotAction;

	public static string ErrorCode;

	public static List<RobotOrderClass> RobotOrderList;

	public static Dictionary<string, DateTime> RobotTimeDictionary;

	public static Dictionary<string, int> NewBarDictionary;

	public static Dictionary<string, decimal> SayiDictionary;

	public static Dictionary<string, string> SozcukDictionary;

	public static Dictionary<string, dynamic> DynamicDictionary;

	public static ConcurrentQueue<string> SistemPencereQueue;

	public static Dictionary<string, DateTime> SistemAcikPencereDict;

	public static int SorguAciklamaWidth;

	public static string[] SorguBaslikList;

	public static int[] SorguOndalikList;

	public static string[] SorguSutunTipList;

	public static string[] SorguSutunHizalaList;

	public static int[] SorguSutunGenislikList;

	public static dynamic Lib;

	public static dynamic User;

	public static dynamic User2;

	public static dynamic User3;

	public static bool UserDllLoaded;

	public static bool User2DllLoaded;

	public static bool User3DllLoaded;

	public static Dictionary<string, formGrid> GridDictionary;

	public static ConcurrentQueue<GridMessageClass> GridMessageQueue;

	public static DateTime ViopHesapTime;

	public static DateTime BistHesapTime;

	public static int RobotRunCount;

	public static string RunningRobotName;

	public static List<string> PortfoyLogList;

	public static Application xlApp;

	public static Workbook xlWorkBook;

	public static Worksheet xlWorkSheet;

	public float MaxDdVal;

	public float MaxDdYuzde;

	public int MaxDdX1;

	public int MaxDdX2;

	public string MaxDdDate1;

	public string MaxDdDate2;

	public float MaxDdY1;

	public float MaxDdY2;

	public string AktifViopKontrat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public string AktifDolarKontrat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public string AktifEuroKontrat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public bool BaglantiVar
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public bool HaftaSonu
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public string Saat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public string Tarih
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EmirGonder()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EmirDuzelt(string emirRefNo, double yeniFiyat, double yeniMiktar, double eskiFiyat, double eskiMiktar)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EmirSil(string emirRefNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PortfoyLogin(string hesapX, string passwordX, string parolaX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PozisyonKontrolGuncelle(string strX, object lotX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PozisyonKontrolGuncelle(string strX, object lotX, double fiyatX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PozisyonKontrolGuncelle(string strX, object lotX, double fiyatX, string rezervX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double PozisyonKontrolOku(string strX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double PozisyonKontrolOku(string strX, out double fiyatX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double PozisyonKontrolOku(string strX, out double fiyatX, out DateTime tarihX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double PozisyonKontrolOku(string strX, out double fiyatX, out DateTime tarihX, out string rezervX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ZamanKontrolGuncelle(string strX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public long ZamanKontrolSaniye(string strX)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public long ZamanKontrolDakika(string strX)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxPortfolio.ViopRobotHesapClass ViopHesapOku()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxPortfolio.ViopRobotHesapClass ViopHesapOku(int delaytime)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxPortfolio.ViopRobotHesapClass ViopPozisyonlar(int delaytime)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int ViopPozisyon(dynamic listeX, string sembolX)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxPortfolio.BistRobotHesapClass BistHesapOku()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxSistem()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HisseAnalizCalc()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HisseAnaliz_Final()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HisseAnalizOptimizasyon()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetHisseAnalizOptMaxTry()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string HisseAnalizGetIndicatorKod(string indicatorNameX, int paramX, double valueX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonOptimizasyon()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Final()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Sistem()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Editor()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MACD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOFAST()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOSLOW()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AWESOME()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_FxSniper()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MOM()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSIsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_WR()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TRIX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DEMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TEMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_IMI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CHMOM()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CCI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KAIRI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AROON()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_ChaikinMF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MFI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QSTICK()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TrendScore()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TimeSF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TKE()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DemandIndex()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KLINGER()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Parabolic()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TillsonFyt()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_EWO()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS1MA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS2MA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS3MA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Ichimoku()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RMI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STORSI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QQE()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Tiberius1()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Idealgo101()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Idealgo102()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Idealgo103()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Idealgo104()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Idealgo105()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Idealgo106()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Bollinger1()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Bollinger2()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MACD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOFAST_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOSLOW_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AWESOME_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_FxSniper_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MOM_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSIsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_WR_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TRIX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DEMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TEMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_IMI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CHMOM_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CCI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KAIRI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AROON_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_ChaikinMF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MFI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QSTICK_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TrendScore_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TimeSF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TKE_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DemandIndex_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KLINGER_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_PARABOLIC_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TillsonFyt_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_EWO_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS1MA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS2MA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS3MA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Ichimoku_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RMI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STORSI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QQE_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MA_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MACD_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOFAST_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOSLOW_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AWESOME_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_FxSniper_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MOM_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSI_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSIsvy_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_WR_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TRIX_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DEMA_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TEMA_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_IMI_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CHMOM_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CCI_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KAIRI_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AROON_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_ChaikinMF_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MFI_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QSTICK_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TrendScore_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TimeSF_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TKE_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DemandIndex_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KLINGER_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_PARABOLIC_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TillsonFyt_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_EWO_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS1MA_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS2MA_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS3MA_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Ichimoku_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RMI_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STORSI_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QQE_TOMA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MA_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MACD_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOFAST_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOSLOW_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AWESOME_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_FxSniper_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MOM_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSI_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSIsvy_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_WR_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TRIX_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DEMA_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TEMA_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_IMI_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CHMOM_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CCI_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KAIRI_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AROON_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_ChaikinMF_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MFI_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QSTICK_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TrendScore_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TimeSF_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TKE_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DemandIndex_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KLINGER_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_PARABOLIC_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TillsonFyt_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_EWO_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS1MA_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS2MA_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS3MA_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Ichimoku_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RMI_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STORSI_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QQE_TOMA_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MA_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MACD_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOFAST_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOSLOW_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AWESOME_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_FxSniper_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TOMA_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MOM_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSI_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSIsvy_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_WR_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TRIX_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DEMA_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TEMA_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_IMI_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CHMOM_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CCI_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KAIRI_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AROON_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_ChaikinMF_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MFI_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QSTICK_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TrendScore_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TimeSF_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TKE_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DemandIndex_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KLINGER_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_PARABOLIC_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TillsonFyt_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_EWO_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS1MA_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS2MA_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS3MA_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Ichimoku_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RMI_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STORSI_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QQE_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TTI_DX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MA_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MACD_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOFAST_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOSLOW_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AWESOME_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_FxSniper_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TOMA_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MOM_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSI_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSIsvy_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_WR_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TRIX_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DEMA_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TEMA_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_IMI_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CHMOM_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CCI_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KAIRI_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AROON_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_ChaikinMF_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MFI_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QSTICK_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TrendScore_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TimeSF_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TKE_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DemandIndex_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KLINGER_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_PARABOLIC_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TillsonFyt_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_EWO_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS1MA_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS2MA_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS3MA_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Ichimoku_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RMI_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STORSI_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QQE_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TTI_DX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MA_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MACD_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOFAST_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOSLOW_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AWESOME_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_FxSniper_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TOMA_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MOM_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSI_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSIsvy_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_WR_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TRIX_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DEMA_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TEMA_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_IMI_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CHMOM_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CCI_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KAIRI_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AROON_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_ChaikinMF_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MFI_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QSTICK_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TrendScore_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TimeSF_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TKE_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DemandIndex_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KLINGER_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_PARABOLIC_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TillsonFyt_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_EWO_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS1MA_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS2MA_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS3MA_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Ichimoku_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RMI_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STORSI_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QQE_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TTI_ADX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MA_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MACD_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOFAST_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOSLOW_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AWESOME_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_FxSniper_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TOMA_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MOM_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSI_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSIsvy_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_WR_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TRIX_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DEMA_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TEMA_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_IMI_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CHMOM_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CCI_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KAIRI_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AROON_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_ChaikinMF_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MFI_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QSTICK_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TrendScore_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TimeSF_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TKE_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DemandIndex_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KLINGER_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_PARABOLIC_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TillsonFyt_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_EWO_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS1MA_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS2MA_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS3MA_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Ichimoku_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RMI_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STORSI_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QQE_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TTI_ADXsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MA_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MACD_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOFAST_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOSLOW_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AWESOME_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_FxSniper_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TOMA_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MOM_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSI_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSIsvy_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_WR_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TRIX_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DEMA_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TEMA_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_IMI_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CHMOM_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CCI_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KAIRI_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AROON_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_ChaikinMF_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MFI_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QSTICK_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TrendScore_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TimeSF_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TKE_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DemandIndex_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KLINGER_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_PARABOLIC_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TillsonFyt_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_EWO_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS1MA_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS2MA_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS3MA_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Ichimoku_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RMI_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STORSI_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QQE_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TTI_ADX_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MA_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MACD_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOFAST_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOSLOW_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AWESOME_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_FxSniper_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TOMA_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MOM_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSI_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSIsvy_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_WR_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TRIX_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DEMA_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TEMA_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_IMI_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CHMOM_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CCI_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KAIRI_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AROON_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_ChaikinMF_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MFI_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QSTICK_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TrendScore_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TimeSF_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TKE_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DemandIndex_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KLINGER_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_PARABOLIC_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TillsonFyt_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_EWO_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS1MA_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS2MA_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS3MA_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Ichimoku_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RMI_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STORSI_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QQE_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TTI_ADXsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MA_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MACD_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOFAST_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOSLOW_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AWESOME_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_FxSniper_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TOMA_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MOM_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSI_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSIsvy_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_WR_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TRIX_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DEMA_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TEMA_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_IMI_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CHMOM_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CCI_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KAIRI_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AROON_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_ChaikinMF_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MFI_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QSTICK_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TrendScore_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TimeSF_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TKE_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DemandIndex_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KLINGER_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_PARABOLIC_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TillsonFyt_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_EWO_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS1MA_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS2MA_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS3MA_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Ichimoku_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RMI_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STORSI_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QQE_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TTI_SD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MA_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MACD_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOFAST_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOSLOW_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AWESOME_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_FxSniper_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TOMA_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MOM_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSI_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSIsvy_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_WR_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TRIX_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DEMA_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TEMA_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_IMI_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CHMOM_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CCI_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KAIRI_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AROON_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_ChaikinMF_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MFI_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QSTICK_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TrendScore_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TimeSF_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TKE_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DemandIndex_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KLINGER_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_PARABOLIC_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TillsonFyt_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_EWO_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS1MA_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS2MA_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS3MA_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Ichimoku_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RMI_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STORSI_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QQE_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TTI_SDsvy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MA_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MACD_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOFAST_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOSLOW_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AWESOME_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_FxSniper_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TOMA_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MOM_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSI_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSIsvy_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_WR_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TRIX_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DEMA_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TEMA_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_IMI_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CHMOM_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CCI_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KAIRI_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AROON_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_ChaikinMF_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MFI_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QSTICK_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TrendScore_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TimeSF_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TKE_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DemandIndex_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KLINGER_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_PARABOLIC_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TillsonFyt_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_EWO_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS1MA_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS2MA_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS3MA_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Ichimoku_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RMI_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STORSI_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QQE_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TTI_SD_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MA_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MACD_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOFAST_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOSLOW_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AWESOME_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_FxSniper_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TOMA_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MOM_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSI_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSIsvy_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_WR_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TRIX_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DEMA_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TEMA_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_IMI_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CHMOM_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CCI_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KAIRI_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AROON_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_ChaikinMF_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MFI_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QSTICK_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TrendScore_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TimeSF_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TKE_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DemandIndex_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KLINGER_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_PARABOLIC_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TillsonFyt_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_EWO_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS1MA_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS2MA_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS3MA_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Ichimoku_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RMI_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STORSI_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QQE_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TTI_SDsvy_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MA_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MACD_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOFAST_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOSLOW_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AWESOME_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_FxSniper_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TOMA_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MOM_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSI_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSIsvy_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_WR_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TRIX_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DEMA_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TEMA_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_IMI_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CHMOM_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CCI_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KAIRI_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AROON_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_ChaikinMF_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MFI_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QSTICK_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TrendScore_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TimeSF_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TKE_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DemandIndex_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KLINGER_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_PARABOLIC_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TillsonFyt_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_EWO_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS1MA_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS2MA_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS3MA_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Ichimoku_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RMI_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STORSI_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QQE_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TTI_VHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MA_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MACD_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOFAST_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOSLOW_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AWESOME_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_FxSniper_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TOMA_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MOM_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSI_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSIsvy_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_WR_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TRIX_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DEMA_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TEMA_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_IMI_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CHMOM_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CCI_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KAIRI_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AROON_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_ChaikinMF_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MFI_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QSTICK_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TrendScore_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TimeSF_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TKE_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DemandIndex_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KLINGER_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_PARABOLIC_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TillsonFyt_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_EWO_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS1MA_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS2MA_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS3MA_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Ichimoku_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RMI_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STORSI_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QQE_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TTI_VHF_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MA_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MACD_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOFAST_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOSLOW_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AWESOME_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_FxSniper_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MOM_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSI_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSIsvy_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_WR_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TRIX_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DEMA_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TEMA_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_IMI_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CHMOM_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CCI_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KAIRI_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AROON_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_ChaikinMF_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MFI_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QSTICK_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TrendScore_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TimeSF_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TKE_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DemandIndex_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KLINGER_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_PARABOLIC_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TillsonFyt_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_EWO_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS1MA_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS2MA_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS3MA_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Ichimoku_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RMI_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STORSI_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QQE_TTI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MA_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MACD_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOFAST_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STOSLOW_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AWESOME_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_FxSniper_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MOM_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSI_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RSIsvy_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_WR_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TRIX_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DEMA_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TEMA_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_IMI_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CHMOM_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CCI_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KAIRI_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_AROON_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_ChaikinMF_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_MFI_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QSTICK_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TrendScore_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TimeSF_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TKE_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_DemandIndex_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_KLINGER_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_PARABOLIC_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_TillsonFyt_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_EWO_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS1MA_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS2MA_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_CLS3MA_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_Ichimoku_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_RMI_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_STORSI_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SablonCalc_QQE_TTI_HL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void NagantsOptimizasyon()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void NagantsCalc()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void NagantsCalc_Final()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void NagantsCalc_Sistem()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void NagantsSimpleCalc_Sistem()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AsagiKestiyse(List<float> list1X, List<float> list2X)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AsagiKestiyse(List<float> list1X, object sabitX)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BarRengi(int barnoX, Color color, int kalinlik, int stil)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public enAvrMethods ConvertAverageMethod(string strX)
	{
		return (enAvrMethods)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> EnCokTekrar(List<float> dataListX, int periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float EnCokTekrarDeger(List<float> list)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GoruntuKaydet(string filenameX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxDepth DerinlikVerisiOku(string symbolX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DolguEkle(int line1X, int line2X, Color upcolorX, Color downcolorX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> DonemCevir(List<cxBar> lowbarsX, List<cxBar> highbarsX, List<float> dataX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Debug(string strX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DerinlikPenceresiAc(string sembolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<cxDevreKesici> DevreKesiciListesiniOku()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DikeyCizgiEkle(int barnoX, Color color, int kalinlik, int stil)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> GetKzList(object datestartX, object kaymaX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetiriHesapla(object datestartX, object kaymaX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetiriMaxDDYazdir(object datestartX, object dateendX, int horizontalX, int verticalX, Color colorX, string fontnameX, int fontsizeX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetiriMaxDDHesapla(object datestartX, object dateendX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetLastYonNo()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GradientYaziEkle(string strX, int panelX, int horizontalX, int verticalX, Color colorX, Color color2X, string fontnameX, int fontsizeX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GrafikPenceresiAc(string sembolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> GrafikFiyatSec(string fieldX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> GrafikFiyatOku(List<cxBar> barsX, string fieldX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> GrafikFiyatOku(string symbolX, string periodX, string fieldX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GrafikGuncelle(cxBasic itemX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<cxBar> GrafikVerilerindeTarihHizala(List<cxBar> list1X, List<cxBar> list2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> GetiriHizala(List<cxBar> basebars, List<cxBar> sistembars, List<float> getirilist)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> GrafikVerileriniBol(List<cxBar> list1X, List<cxBar> list2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> GrafikKapanisHizala(List<cxBar> list1X, List<cxBar> list2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<cxBar> GrafikVerileriniOku(string symbolX, string periyotX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<cxBar> GrafikVerileriniOku(string symbolX, string periyotX, string periyot2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GrafikVerisiIndir(object symbolX, object periodX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formGrid Grid(string namex, int leftx, int topx, int widthx, int heightx)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<cxNews> HaberleriGetir()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float IzleyenStopYuzde(object yuzdestopX, int barnoX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float IzleyenStopPuan(object puanstopX, int barnoX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void KepPenceresiAc(string sembolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float KarAlYuzde(object yuzdekarX, int barnoX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float KarAlPuan(object puankarX, int barnoX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void KesismeTara(List<float> list1X, List<float> list2X)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void KesismeTara(List<float> listX, object sabitX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool LisansKontrol(params string[] userlistX)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Liste(object sabitX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Liste(int barsayisiX, object sabitX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MailAliciEkle(string adres)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MailCcEkle(string adres)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MailBccEkle(string adres)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MailDosyaEkle(string dosya)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MailGonder()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Median(List<float> dataListX, int periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float MedianDeger(List<float> list)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Mesaj(string mesajX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Mesaj(string mesajX, Color renkX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Mesaj(string mesajX, int leftX, int topX, int widthX, int heightX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Mesaj(string mesajX, Color renkX, int leftX, int topX, int widthX, int heightX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MultiSembolBirlestirAyniYon(string sistem, params string[] semboller)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void NesneKaydet(string strX, dynamic nesneX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public dynamic NesneGetir(string strX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public decimal NetLot(string strX)
	{
		return (decimal)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public decimal NetLotOran(string strX)
	{
		return (decimal)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public decimal NetHacim(params string[] symbolsX)
	{
		return (decimal)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public decimal NetHacimOran(params string[] symbolsX)
	{
		return (decimal)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public decimal NetHacimBist()
	{
		return (decimal)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public decimal NetHacimBistOran()
	{
		return (decimal)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxIndicator NewIndicator()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxIndicator NewIndicator(int barcount)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Optimizasyon(params object[] aciklamaX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color Renk(int opakX, int redX, int greenX, int blueX)
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResimEkle(string filnameX, int panelX, int horizontalX, int verticalX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RoboKepPenceresiAc(string sembolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RobotStop()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RoboTradeBaslat()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string RobotViopAktif(string sistemnameX, string bazsembolX, string emirsembolX, string periyotX, object miktarX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string RobotViopAktif(string sistemnameX, string bazsembolX, string emirsembolX, string periyotX, object miktarX, object saniyeX, object seanssonuX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string RobotViopTumGun(string sistemnameX, string bazsembolX, string emirsembolX, string periyotX, object miktarX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string RobotViopGunSonuKapat(string sistemnameX, string emirsembolX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string RobotHisseAktifAcigaYok(string sistemnameX, string bazsembolX, string emirsembolX, string periyotX, object miktarX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string RobotHisseAktifAcigaVar(string sistemnameX, string bazsembolX, string emirsembolX, string periyotX, object miktarX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SaatAraligi(string hour1X, string hour2X)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SayiTablosunuGuncelle(string strX, object sayiX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public decimal SayiTablosunuOku(string strX)
	{
		return (decimal)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float SayiYuvarla(object sayiX, object stepX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<cxTrade> SembolIslemleriniOku(string strX, string dateX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxBasic SembolTanimla(string symbolX, int decpointX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Ses()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Ses(string filenameX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetErrorMessage(string errorcodeX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxSistem SistemGetir(string sistemnameX, string sembolX, string periyotX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxSistem SistemGetir(string sistemnameX, List<cxBar> V)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SistemBirlestir(params object[] sistemler)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SistemBirlestirAyniYon(params object[] sistemler)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SorguEkle()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color SorguSicaklikRengi(object deger, object min, object max)
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SozcukTablosunuGuncelle(string strX, object dataX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string SozcukTablosunuOku(string strX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> StDev(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> StDev(List<float> dataListX, int periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float StDevDeger(List<float> list)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopVeyaKarFlatYuzde(object yuzdestopX, object yuzdekarX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopVeyaKarFlatPuan(object puanstopX, object puankarX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Tablo(string namex, int leftx, int topx, int widthx, int heightx, int columncountx, int rowcountx, int[] sutunwidthx, int[] sutunalignx, string[] sutunbaslikx)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Tablo(string namex, int leftx, int topx, int widthx, int heightx, int columncountx, int rowcountx, int[] sutunwidthx, int[] sutunalignx, string[] sutunbaslikx, int baslikvisiblex, float fontsizex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TabloYazdir(string namex, int columnnox, int rownox, string strx)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TabloYazdir(string namex, int columnnox, int rownox, string strx, Color backcolorx, Color forecolorx)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TabloTemizle(string namex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TabloToHtml(string namex, string filenameX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TarihAraligi(string date1X, string date2X)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TakasHesapla(List<cxBar> barsX, string sembolx, int countx)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Telegram(long chatId, string message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TrendAsagiKirilirsa(string symbolX, string periodX, string date1X, object value1X, string date2X, object value2X)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TrendYukariKirilirsa(string symbolX, string periodX, string date1X, object value1X, string date2X, object value2X)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void YaziEkle(string strX, int panelX, int barnoX, float pricelevelX, Color forecolorX, string fontnameX, int fontsizeX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Font YaziTipi(string fontnameX, int fontsizeX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool YukariKestiyse(List<float> list1X, List<float> list2X)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool YukariKestiyse(List<float> list1X, object sabitX)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void YuzeyselGuncelle(cxBasic itemX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxBasic YuzeyselVeriOku(string symbolX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<cxBasic> YuzeyselListeGetir(string kriterX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ZeminYazisiEkle(string strX, int panelX, int horizontalX, int verticalX, Color colorX, string fontnameX, int fontsizeX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string SonYonGetir(string sistemnameX, string bazsembolX, string periyotX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string SonYonGetirCanli(string sistemnameX, string bazsembolX, string periyotX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RobotServerPozisyonEsitle(string symbolX, int lotX, string infoX, Color colorX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RobotServerAtaHisseSistem1(string filename)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RobotServerMeksaHisseSistem1(string filename)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dortgen(int panelX, int horizontalX, int verticalX, int widthX, int heightX, Color color1X, Color color2X, Color color3X)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string HesapKurum()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<cxTrade> OzelEmirleriGetir()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<cxTrade> HisseIslemleriniOku()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<cxTrade> ViopIslemleriniOku()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public dynamic ExcelOku(string filename)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExcelKopyala(object[,] cellarray, string filenameX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TrendCiz(DateTime date1X, object value1X, DateTime date2X, object value2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TrendParalelCiz(List<float> trendlineX, DateTime date1X, DateTime date2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TrendParalelCiz(List<float> trendlineX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string TrendKontrol(string strX, out decimal degerX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> OtoTrendYukselen(int toplambarX, int sonbarX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> OtoTrendDusen(int toplambarX, int sonbarX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> OtoTrendYukselen(List<cxBar> bars, int toplambarX, int sonbarX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> OtoTrendDusen(List<cxBar> bars, int toplambarX, int sonbarX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> OtoTrend(List<float> listX, string yonX, string tipX, int toplambarX, int sonbarX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> SuperTrend(object FactorX, object PdX, object Pd1X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> SuperTrend(List<cxBar> bars, object FactorX, object PdX, object Pd1X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> RelativeVigorIndex(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> RelativeVigorIndex(List<cxBar> bars, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> RelativeVigorIndexSignal(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> RelativeVigorIndexSignal(List<cxBar> bars, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TillsonT3(object periodX, object CarpanX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TillsonT3(List<float> datalistX, object periodX, object CarpanX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> IFISHRSI(object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> IFISHCCI(object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KademeDetayClass KademeAnalizOku(string Sembol)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KademeDetayClass KademeAnalizOku(string Sembol, string Saat1, string Saat2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KademeDetayClass KademeAnalizOku(string Sembol, int Dakika)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KademeDetayClass KademeAnalizHesapla(string SembolX, string Saat1, string Saat2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KademeDetayClass KademeAnalizGun(string SembolX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void KarRasyoFilter(float filterX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ProfitFactorBar(int barX, object kaymaX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ProfitFactorIslem(int islemX, object kaymaX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> KarZararIslem(int islemX, object kaymaX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void YayCiz(int panel, int bar1, object fiyat1, int bar2, object fiyat2, int bar3, object fiyat3, Color framecolor, int width, int fillbool, Color fillcolor, int noktabool, Color noktacolor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void YayCiz4(int panel, int bar1, object fiyat1, int bar2, object fiyat2, int bar3, object fiyat3, int bar4, object fiyat4, Color framecolor, int width, int fillbool, Color fillcolor, int noktabool, Color noktacolor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CizgiCiz(int panel, int bar1, object fiyat1, int bar2, object fiyat2, Color forecolor, int width, int style)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DortgenCiz(int panel, int bar1, object fiyat1, int bar2, object fiyat2, int bar3, object fiyat3, int bar4, object fiyat4, Color framecolor, int width, int fillbool, Color fillcolor, int noktabool, Color noktacolor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UcgenCiz(int panel, int bar1, object fiyat1, int bar2, object fiyat2, int bar3, object fiyat3, Color framecolor, int width, int fillbool, Color fillcolor, int noktabool, Color noktacolor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BarCiz(int panel, int bartip, List<float> openlist, List<float> highlist, List<float> lowlist, List<float> closelist, Color yukselenrenk, Color dusenrenk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> SembolAdListesi(string prefix, string seri)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<cxBasic> SembolVeriListesi(string prefix, string seri)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> EndeksSembolleri(string endeksKodu)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> SektorSembolleri(string sektorKodu)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GridBotBaslat(object adX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GridBotBaslat(object adX, object midpriceX, object aralikX, object countX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GridBotDurdur(object adX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> GetPortfoyLogList()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Test(cxSistem Sistem)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> MA(object periodX, object methodX, object pricetypeX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> MA(List<float> datalistX, object methodX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> MAM(List<float> datalistX, object methodX, params int[] periyotlarX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> MAFARK(List<float> datalistX, object methodX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> MA2(List<float> datalistX, object methodX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> MA3(List<float> datalistX, object methodX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float MOV(List<float> datalistX, string method)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> HHV(object periodX, List<float> listX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> HHV(object periodX, object pricetypeX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> HHV(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> HHV(List<cxBar> barsX, object periodX, object pricetypeX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> LLV(object periodX, List<float> listX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> LLV(object periodX, object pricetypeX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> LLV(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> LLV(List<cxBar> barsX, object periodX, object pricetypeX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> HHLL(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> HHLL(object periodX, List<float> listX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ListeTopla(params List<float>[] datalistX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ListeOrta(params List<float>[] datalistX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ListeFark(List<float> list1, List<float> list2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Ref(List<float> listX, int shiftX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float Sum(List<float> listX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Sum(List<float> listX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> HY(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> LY(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Alligator1()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Alligator1(List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Alligator2()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Alligator2(List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Alligator3()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Alligator3(List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> BollingerMid(object methodX, object periodX, object deviationX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> BollingerMid(List<cxBar> barsX, object methodX, object periodX, object deviationX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> BollingerMid(List<float> datalist, object methodX, object periodX, object deviationX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> BollingerUp(object methodX, object periodX, object deviationX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> BollingerUp(List<cxBar> barsX, object methodX, object periodX, object deviationX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> BollingerUp(List<float> datalist, object methodX, object periodX, object deviationX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> BollingerDown(object methodX, object periodX, object deviationX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> BollingerDown(List<cxBar> barsX, object methodX, object periodX, object deviationX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> BollingerDown(List<float> datalist, object methodX, object periodX, object deviationX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> DEMA(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> DEMA(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> DEMA(List<float> datalistX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> EhlersFilter()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> EhlersFilter(List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> EhlersEhlersDistCoefFilter()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> EhlersEhlersDistCoefFilter(List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> NonlinearEhlersFilter(object nX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> NonlinearEhlersFilter(List<cxBar> barsX, object nX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> EnvelopeMid(object methodX, object periodX, object deviationX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> EnvelopeMid(List<cxBar> barsX, object methodX, object periodX, object deviationX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> EnvelopeUp(object methodX, object periodX, object deviationX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> EnvelopeUp(List<cxBar> barsX, object methodX, object periodX, object deviationX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> EnvelopeDown(object methodX, object periodX, object deviationX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> EnvelopeDown(List<cxBar> barsX, object methodX, object periodX, object deviationX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> FibonacciMid(object ratioX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> FibonacciMid(List<cxBar> barsX, object ratioX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> FibonacciUp(object ratioX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> FibonacciUp(List<cxBar> barsX, object ratioX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> FibonacciDown(object ratioX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> FibonacciDown(List<cxBar> barsX, object ratioX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> KeltnerUp(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> KeltnerUp(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> KeltnerDown(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> KeltnerDown(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> LinearReg(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> LinearReg(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> LinearReg(List<float> datalistX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> LinearReg3(List<float> datalistX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Parabolic(object stepX, object maksimumX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Parabolic(List<cxBar> barsX, object stepX, object maksimumX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Parabolic(List<float> datalistX, object stepX, object maksimumX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PivotMid()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PivotMid(List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PivotUp()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PivotUp(List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PivotDown()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PivotDown(List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PH01(object donemX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PH01(List<cxBar> barsX, object donemX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PL01(object donemX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PL01(List<cxBar> barsX, object donemX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PVT01(object donemX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PVT01(List<cxBar> barsX, object donemX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PriceChannelUp(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PriceChannelUp(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PriceChannelDown(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PriceChannelDown(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ProjectionUp(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ProjectionUp(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ProjectionDown(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ProjectionDown(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> StErMid(object periodX, object deviationX, object avrmethodX, object avrperiodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> StErMid(List<cxBar> barsX, object periodX, object deviationX, object avrmethodX, object avrperiodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> StErUp(object periodX, object deviationX, object avrmethodX, object avrperiodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> StErUp(List<cxBar> barsX, object periodX, object deviationX, object avrmethodX, object avrperiodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> StErDown(object periodX, object deviationX, object avrmethodX, object avrperiodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> StErDown(List<cxBar> barsX, object periodX, object deviationX, object avrmethodX, object avrperiodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TEMA(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TEMA(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TEMA(List<float> datalistX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TimeSeriesForecast(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TimeSeriesForecast(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TimeSeriesForecast(List<float> datalist, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TOMA(object periodX, object percentX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TOMA(List<cxBar> barsX, object periodX, object percentX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TOMA(List<float> datalistX, object periodX, object percentX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TOMA(object periodX, object percentX, object methodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TOMA(List<cxBar> barsX, object periodX, object percentX, object methodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TOMA(List<float> datalistX, object periodX, object percentX, object methodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TOMAS(object periodX, object percentX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TOMAS(List<cxBar> barsX, object periodX, object percentX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TOMAS(List<float> datalistX, object periodX, object percentX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TOMAPUAN(object periodX, object percentX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TOMAPUAN(List<cxBar> barsX, object periodX, object percentX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TOMAPUAN(List<float> datalistX, object periodX, object percentX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> FxSniper(object param1X, object param2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> FxSniper(List<cxBar> barsX, object param1X, object param2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> FxSniper(List<float> datalistX, object param1X, object param2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TypicalPrice()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TypicalPrice(List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> WeightedClose()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> WeightedClose(List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ZigZagPercent(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ZigZagPercent(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ZigZagPercent(List<float> datalistX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ZigZagPoint(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ZigZagPoint(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ZigZagPoint(List<float> datalistX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> AccumulationSwingIndex(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> AccumulationSwingIndex(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> AccumulationDistribution()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> AccumulationDistribution(List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ADX(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ADX(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ADX(List<float> datalistX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ADXE(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ADXE(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ADR(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ADR(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> AroonUp(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> AroonUp(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> AroonDown(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> AroonDown(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> AroonOsc(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> AroonOsc(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> AverageTrueRange(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> AverageTrueRange(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> AverageTrueRange(List<float> datalistX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> AwesomeOsc(object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> AwesomeOsc(List<cxBar> barsX, object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> BilancoFK(string sembolx, List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> BilancoFK()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> BilancoNetKar(string sembolx, List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> BilancoNetKar()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> BilancoOdenmisSerm(string sembolx, List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> BilancoOdenmisSerm()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> BilancoOzSerm(string sembolx, List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> BilancoOzSerm()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> BilancoPD(string sembolx, List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> BilancoPD()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> BilancoPDDD(string sembolx, List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> BilancoPDDD()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> BollingerWidth(object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> BollingerWidth(List<cxBar> barsX, object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ChandeMomentum(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ChandeMomentum(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ChandeMomentum(List<float> datalistX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> CommodityChannelIndex(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> CommodityChannelIndex(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ChaikinMoneyFlow(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ChaikinMoneyFlow(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ChaikinOsc()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ChaikinOsc(List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ChaikinVolatility(object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ChaikinVolatility(List<cxBar> barsX, object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> DemandIndex()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> DemandIndex(List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> DeMarker(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> DeMarker(List<cxBar> bars, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> DirectionalIndicatorPlus(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> DirectionalIndicatorPlus(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> DirectionalIndicatorMinus(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> DirectionalIndicatorMinus(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> DirectionalMovement(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> DirectionalMovement(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> EaseOfMovement(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> EaseOfMovement(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ForecastOsc(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ForecastOsc(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> IMI(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> IMI(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Kairi(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Kairi(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Kairi(List<float> datalistX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> KlingerOsc(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> KlingerOsc(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> LinearRegIndicator(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> LinearRegIndicator(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> LinearRegSlope(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> LinearRegSlope(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> LinearRegSlope(List<float> datalistX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> LinearRegIntercept(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> LinearRegIntercept(List<float> datalistX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Lot()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Lot(List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> MACD(object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> MACD(List<cxBar> barsX, object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> MACD(List<float> datalistX, object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> MassIndex(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> MassIndex(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Momentum(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Momentum(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Momentum(List<float> datalistX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> MoneyFlowIndex(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> MoneyFlowIndex(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> NegativeVolumeIndex()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> NegativeVolumeIndex(List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> OnBalanceVolume()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> OnBalanceVolume(List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> OpenInterest()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> OpenInterest(List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PolarizedFractalEfficiency(object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PolarizedFractalEfficiency(List<cxBar> barsX, object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PolarizedFractalEfficiency(List<float> datalistX, object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PositiveVolumeIndex()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PositiveVolumeIndex(List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PriceOscPercent(object period1X, object period2X, object avrmethodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PriceOscPercent(List<cxBar> barsX, object period1X, object period2X, object avrmethodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PriceOscPoint(object period1X, object period2X, object avrmethodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PriceOscPoint(List<cxBar> barsX, object period1X, object period2X, object avrmethodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PriceRocPercent(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PriceRocPercent(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PriceRocPercent(List<float> datalistX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PriceRocPoint(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PriceRocPoint(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PriceRocPoint(List<float> datalistX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PriceVolumeTrend()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PriceVolumeTrend(List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ProjectionBandwidth(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ProjectionBandwidth(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ProjectionOsc(object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ProjectionOsc(List<cxBar> barsX, object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Qstick(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Qstick(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> RangeIndicator(object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> RangeIndicator(List<cxBar> barsX, object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> RAVI(object period1X, object period2X, object avrmethodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> RAVI(List<cxBar> barsX, object period1X, object period2X, object avrmethodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> RelativeMomIndex(object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> RelativeMomIndex(List<float> datalistX, object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> RelativeMomIndex(List<cxBar> barsX, object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> RSI(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> RSI(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> RSI(List<float> datalistX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TrendScore(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TrendScore(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TrendScore(List<float> datalistX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> RelativeVolatilityIndex(object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> RelativeVolatilityIndex(List<cxBar> barsX, object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> RSIDenvelopeMid(object methodX, object periodX, object deviationX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> RSIDenvelopeMid(List<cxBar> barsX, object methodX, object periodX, object deviationX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> RSIDenvelopeUp(object methodX, object periodX, object deviationX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> RSIDenvelopeUp(List<cxBar> barsX, object methodX, object periodX, object deviationX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> RSIDenvelopeDown(object methodX, object periodX, object deviationX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> RSIDenvelopeDown(List<cxBar> barsX, object methodX, object periodX, object deviationX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Rsquared(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Rsquared(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> StDev(object periodX, object deviationX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> StDev(List<cxBar> barsX, object periodX, object deviationX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> StEr(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> StEr(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> StochasticMomIndex(object period1X, object period2X, object period3X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> StochasticMomIndex(List<cxBar> barsX, object period1X, object period2X, object period3X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> StochasticMomIndex(List<float> datalistX, object period1X, object period2X, object period3X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> StochasticOsc(object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> StochasticOsc(List<cxBar> barsX, object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> StochasticFast(object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> StochasticFast(List<cxBar> barsX, object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> StochasticSlow(object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> StochasticSlow(List<cxBar> barsX, object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> StochasticRSI(object period1X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> StochasticRSI(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> StochasticRSI(List<float> datalistX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> SwingIndex(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> SwingIndex(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TKE()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TKE(List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TRIX(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> DUBIX(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TRIX(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TRIX(List<float> datalistX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> UltimateOsc(object period1X, object period2X, object period3X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> UltimateOsc(List<cxBar> barsX, object period1X, object period2X, object period3X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> VerticalHorizontalFilter(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> VerticalHorizontalFilter(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Volume()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Volume(List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> VolumeOscPercent(object period1X, object period2X, object avrmethodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> VolumeOscPercent(List<cxBar> barsX, object period1X, object period2X, object avrmethodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> VolumeOscPoint(object period1X, object period2X, object avrmethodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> VolumeOscPoint(List<cxBar> barsX, object period1X, object period2X, object avrmethodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> VolumeSymbolPercent(string sembolx)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> VortexMinus(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> VortexMinus(List<cxBar> bars, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> VortexPlus(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> VortexPlus(List<cxBar> bars, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> WilliamsAccDist()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> WilliamsAccDist(List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> WilliamsR(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> WilliamsR(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> WilliamsR(List<float> datalistX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> QQES(object param1X, object param2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> QQES(List<cxBar> barsX, object param1X, object param2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> QQES(List<float> datalistX, object param1X, object param2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> QQEIS(List<float> datalistX, object param1X, object param2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> QQEF(object param1X, object param2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> QQEF(List<cxBar> barsX, object param1X, object param2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> QQEF(List<float> datalistX, object param1X, object param2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> QQEIF(List<float> datalistX, object param1X, object param2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> DetrendedPriceOscillator(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> DetrendedPriceOscillator(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> DetrendedPriceOscillator(List<float> datalistX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> KAMA(object lenX, object fastendX, object slowendX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> KAMA(List<cxBar> barsX, object lenX, object fastendX, object slowendX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> VIDYA(object mX, object nX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> VIDYA(List<cxBar> barsX, object mX, object nX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> FRAMA()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> FRAMA(List<cxBar> barsX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ZigZagClass ZigZagPeakThrough(List<float> datalistX, object periodX, object sayiX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Ichimoku Ichimoku()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ElliotWaveOscillator(object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> ElliotWaveOscillator(List<cxBar> barsX, object period1X, object period2X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KurumHacimClass KurumHacimOku(string kurumX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Dip(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> Zirve(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TTI(object periodX, object percentX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TTI(object periodX, object percentX, object methodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TTI(List<cxBar> barsX, object periodX, object percentX, object methodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> TTI(List<float> datalistX, object periodX, object percentX, object methodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> HullMA(object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> HullMA(List<cxBar> barsX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> HullMA(List<float> datalistX, object periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<float> PGC(object kurumSayisiX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PgcClass PgcHesapla(string sembolX, object kurumsayisiX, object suretipiX, object sureX, object lottltipX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float SonFiyat(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float SonLot(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float SonHacim(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float AlisFiyat(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float AlisLot(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float SatisFiyat(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float SatisLot(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float Tavan(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float Taban(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float YuksekSeans(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float YuksekGun(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float YuksekBuHafta(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float YuksekBirHafta(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float YuksekBuAy(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float YuksekBirAy(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float YuksekUcAy(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float YuksekAltiAy(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float YuksekBuYil(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float YuksekBirYil(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float DusukSeans(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float DusukGun(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float DusukBuHafta(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float DusukBirHafta(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float DusukBuAy(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float DusukBirAy(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float DusukUcAy(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float DusukAltiAy(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float DusukBuYil(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float DusukBirYil(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float OncekiKapanisSeans(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float OncekiKapanisGun(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float OncekiKapanisBuHafta(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float OncekiKapanisBirHafta(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float OncekiKapanisBuAy(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float OncekiKapanisBirAy(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float OncekiKapanisUcAy(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float OncekiKapanisAltiAy(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float OncekiKapanisBuYil(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float OncekiKapanisBirYil(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float FarkSeans(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float FarkGun(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float FarkBuHafta(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float FarkBirHafta(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float FarkBuAy(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float FarkBirAy(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float FarkUcAy(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float FarkAltiAy(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float FarkBuYil(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float FarkBirYil(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float YuzdeSeans(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float YuzdeGun(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float YuzdeBuHafta(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float YuzdeBirHafta(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float YuzdeBuAy(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float YuzdeBirAy(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float YuzdeUcAy(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float YuzdeAltiAy(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float YuzdeBuYil(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float YuzdeBirYil(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double LotSeans(string symbolX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double LotGun(string symbolX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double LotBuHafta(string symbolX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double LotBirHafta(string symbolX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double LotBuAy(string symbolX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double LotBirAy(string symbolX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double LotUcAy(string symbolX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double LotAltiAy(string symbolX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double LotBuYil(string symbolX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double LotBirYil(string symbolX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double HacimSeans(string symbolX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double HacimGun(string symbolX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double HacimBuHafta(string symbolX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double HacimBirHafta(string symbolX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double HacimBuAy(string symbolX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double HacimBirAy(string symbolX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double HacimUcAy(string symbolX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double HacimAltiAy(string symbolX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double HacimBuYil(string symbolX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double HacimBirYil(string symbolX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float OrtalamaSeans(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float OrtalamaGun(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float OrtalamaBuHafta(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float OrtalamaBirHafta(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float OrtalamaBuAy(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float OrtalamaBirAy(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float OrtalamaUcAy(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float OrtalamaAltiAy(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float OrtalamaBuYil(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float OrtalamaBirYil(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PGCKurumMaliyet AKDHesapla(string symbolX, int kurumSayisiX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CompileLib()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CompileSistem(string sistemnameX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Deserialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static decimal FindMaxDD(cxSistem sistemitemX, out int barno)
	{
		return (decimal)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float FindMaxDDDate(List<float> bakiyelist, int startno, int endno, out int barno)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static cxSistem GetSistem(string sistemnameX, string symbolX, string periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static cxSistem GetSistemSorgu(string sistemnameX, string symbolX, string periodX, int sonbartip, DateTime sonbartarih, int barsayisitip, int barsayisicount)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static cxSistem GetSistemChart(string sistemnameX, string symbolX, string periodX, List<cxBar> barslistX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static cxSistem GetSistem(string sistemnameX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InsertRobotOrderToList(RobotOrderClass orderX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ProcessGridMessage(GridMessageClass messagex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RunSistem(cxSistem sistemitemX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize(cxSistem itemX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowCompare()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowDefinitions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowMulti()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowPerformance()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowPerformance(string sistemnameX, string symbolX, string periodX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowPosition()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowSablonRobot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowGridBot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowTrendBot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowYatayBot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowPacalBot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowArbitraj1()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowTwap()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GetExcelWorkbook()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public dynamic ExcelHucreOku(int satirno, int sutunno)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public dynamic ExcelTumOku()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float CalculateMaxDD(List<float> kzlist)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalculateMaxDdDate(List<float> kzlist)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static cxSistem()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		ReferenceDefinition = null;
		LocationDefiniton = new Point(10, 10);
		SizeDefinition = new Size(1200, 620);
		ReferencePerformance = null;
		LocationPerformance = new Point(50, 50);
		SizePerformance = new Size(1025, 660);
		ReferencePosition = null;
		LocationPosition = new Point(100, 50);
		SizePosition = new Size(663, 365);
		ReferenceCompare = null;
		LocationCompare = new Point(100, 50);
		SizeCompare = new Size(923, 391);
		ReferenceMulti = null;
		LocationMulti = new Point(50, 50);
		SizeMulti = new Size(1100, 600);
		Dictionary = new Dictionary<string, cxSistem>();
		ReadBool = false;
		ReadingFinished = false;
		PerformanceBarCount = 1000;
		OptimizerBarCount = 1000;
		PerformanceShortSellAllowed = true;
		OptimizerShortSellAllowed = true;
		PerformanceInitialCash = 100m;
		PerformanceLot = 1m;
		PerformanceLotStyle = "Sabit Lot İle";
		PositionDateFilter = "Tüm";
		PositionSymbolFilter = "XU-30";
		AlgoAction = "Yok";
		AlgoListPos = 0;
		AlgoRunning = false;
		UserSymbolsSistemName = "KullaniciSembolleri";
		UserSymbolRunCount = 0;
		KeySistem1 = 712345678755L;
		KeySistem2 = 321345678772L;
		KeySistem3 = 555123476543L;
		KeySistem4 = 444435628765L;
		KeySistem5 = 190675128974L;
		KeySistem6 = 870955419821L;
		PortfoyKey1 = 198243860912L;
		PortfoyKey2 = 908439071873L;
		RobotAction = "Yok";
		ErrorCode = "";
		RobotOrderList = new List<RobotOrderClass>();
		RobotTimeDictionary = new Dictionary<string, DateTime>();
		NewBarDictionary = new Dictionary<string, int>();
		SayiDictionary = new Dictionary<string, decimal>();
		SozcukDictionary = new Dictionary<string, string>();
		DynamicDictionary = new Dictionary<string, object>();
		SistemPencereQueue = new ConcurrentQueue<string>();
		SistemAcikPencereDict = new Dictionary<string, DateTime>();
		SorguAciklamaWidth = 0;
		SorguBaslikList = new string[50];
		SorguOndalikList = new int[50];
		SorguSutunTipList = new string[50];
		SorguSutunHizalaList = new string[50];
		SorguSutunGenislikList = new int[50];
		UserDllLoaded = false;
		User2DllLoaded = false;
		User3DllLoaded = false;
		GridDictionary = new Dictionary<string, formGrid>();
		GridMessageQueue = new ConcurrentQueue<GridMessageClass>();
		DateTime dateTime = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
		ViopHesapTime = gr7jwURt1t3VJtiGGT.r7iItWL60(ref dateTime, -1.0, gr7jwURt1t3VJtiGGT.z9nxy3dm7u);
		dateTime = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
		BistHesapTime = gr7jwURt1t3VJtiGGT.r7iItWL60(ref dateTime, -1.0, gr7jwURt1t3VJtiGGT.z9nxy3dm7u);
		RobotRunCount = -1;
		RunningRobotName = "";
		PortfoyLogList = new List<string>();
	}
}
