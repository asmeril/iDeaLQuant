using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class AlgoClass
{
	[NonSerialized]
	public const int AksiyonAlis = 0;

	[NonSerialized]
	public const int AksiyonSatis = 1;

	[NonSerialized]
	public const int AksiyonAlSat = 2;

	public long ID;

	public decimal Miktar;

	public AlgoTypes AlgoTip;

	public string Sembol;

	public string HesapRumuz;

	public string BaslangicSaat;

	public string KapanisSaat;

	public string Durum;

	public int AktifPasif;

	public int Aksiyon;

	public decimal HedeflenenLot;

	public int MinimumSureSn;

	public int RandomSureSn;

	public bool RandomSureBool;

	public int MiktarTip;

	public int MiktarLot;

	public int RandomMiktarLot;

	public bool RandomMiktarBool;

	public int FiyatTip;

	public bool AortUstundeBool;

	public bool AortAltindaBool;

	public bool FiyatUstundeBool;

	public bool FiyatAltindaBool;

	public decimal FiyatUstundeVal;

	public decimal FiyatAltindaVal;

	public bool YuzdeUstundeBool;

	public bool YuzdeAltindaBool;

	public decimal YuzdeUstundeVal;

	public decimal YuzdeAltindaVal;

	public bool EmirIptalBool;

	public int EmirIptalSn;

	public bool EmirIyilestirBool;

	public int EmirIyilestirSn;

	public decimal ToplamLotLimit;

	public decimal NetLotLimit;

	public bool PozisyonKapatBool;

	public string PozisyonKapatSaat;

	public bool SatisOrtalamaBool;

	public int SatisOrtalamaVal;

	public string ChartPeriyot;

	public int ChartBarCount;

	public bool ChartLastBarBool;

	public int ChartVeriTip;

	public bool SonSaatBool;

	public string SonSaatStr;

	public decimal KademeLot;

	public string Hesap;

	public string AltHesap;

	public string Kurum;

	public decimal FiyatLimiti;

	public decimal TakipOran;

	public bool AlisTakipEtBool;

	public bool SatisTakipEtBool;

	public int HacimTip;

	[NonSerialized]
	public int SonEmirMiktari;

	[NonSerialized]
	public decimal BaslangicLotMiktari;

	public decimal GorunenLot;

	public decimal IslemFiyati;

	public string Sembol1;

	public string Sembol2;

	public bool CumaPozKapatBool;

	public string CumaPozKapatSaat;

	public bool FaizIslemAcBool;

	public decimal FaizIslemAcVal;

	public bool SpreadIslemAcBool;

	public decimal SpreadIslemAcVal;

	public bool FaizIslemKapatBool;

	public decimal FaizIslemKapatVal;

	public bool SpreadIslemKapatBool;

	public decimal SpreadIslemKapatVal;

	public int FaizSpreadTip;

	public bool SeciliBool;

	[NonSerialized]
	public decimal IslemFiyat1;

	[NonSerialized]
	public decimal IslemFiyat2;

	[NonSerialized]
	public HashSet<string> EmirRefNoHashSet;

	[NonSerialized]
	public HashSet<string> YeniGerceklesenEmirRefNoHashSet;

	[NonSerialized]
	public static volatile List<RobotOrderClass> IslemListArbitraj;

	[NonSerialized]
	public string Guncelleme;

	[NonSerialized]
	public decimal GerceklesenHacim;

	[NonSerialized]
	public decimal GerceklesenLot;

	[NonSerialized]
	public decimal ArbitrajGerceklesenLot;

	[NonSerialized]
	public decimal AlisGerceklesenLot;

	[NonSerialized]
	public decimal SatisGerceklesenLot;

	[NonSerialized]
	public decimal AlisBekleyenLot;

	[NonSerialized]
	public decimal SatisBekleyenLot;

	[NonSerialized]
	public int RandomTimeOffset;

	[NonSerialized]
	public DateTime PrevEmirTime;

	[NonSerialized]
	public DateTime? RobotBaslangicTarihi;

	[NonSerialized]
	public bool EmirGonderildiBool;

	public static string RunningDescription;

	public static List<AlgoClass> RobotList1;

	public static List<AlgoClass> RobotList2;

	public static List<AlgoClass> RobotList3;

	public static List<AlgoClass> RobotList4;

	[NonSerialized]
	public static Dictionary<string, DateTime> portfoySorgulamaTarihi;

	[NonSerialized]
	private static TimeSpan defaultTimeOffset;

	public bool RunningMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getFixRouterSembol(string sembol = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool EmirGonder(decimal miktarX, decimal fiyat, string aciklamaX)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static decimal FindEmirKademeFiyat(string sembol, decimal miktar, decimal hedeffiyat)
	{
		return (decimal)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool EmirGonderArbitraj(string sembolX, decimal miktarX, decimal fiyatX, string emirTipX)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IslemArbitrajEkle(string sembolX, decimal miktarX, decimal fiyatX, string emirTipX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendOrderPov(int miktar, decimal fiyat, string aciklama)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetPov2Lot(cxBasic basic)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void portfoySorgulamaTarihiClear()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool portfoySorgulamaSureKontrol(HesapRec hesapitem, string prefix, TimeSpan? timeOffset = null)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AlgoClass()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoClass()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		IslemListArbitraj = new List<RobotOrderClass>();
		RunningDescription = "";
		RobotList1 = new List<AlgoClass>();
		RobotList2 = new List<AlgoClass>();
		RobotList3 = new List<AlgoClass>();
		RobotList4 = new List<AlgoClass>();
		portfoySorgulamaTarihi = new Dictionary<string, DateTime>();
		defaultTimeOffset = yQuYgJGkhQXMr2NRZEn.r7iItWL60(1.0, yQuYgJGkhQXMr2NRZEn.R2xG0LJM1E);
	}
}
