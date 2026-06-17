using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class cxBasic
{
	public string Symbol;

	public int SembolId;

	public string Root;

	public string Prefix;

	public string Description;

	public string Exchange;

	public int ExchangeID;

	public string MarketCode;

	public string SubMarket;

	public string Sector;

	public int DecimalPoint;

	public int DecimalPointSize;

	public string IndexType;

	public string Grup;

	public string Seri;

	public string Yontem;

	public string Durum;

	public string NasdaqId;

	public float LastPrice;

	public int LastSize;

	public float LastVol;

	public string Direction;

	public decimal BidPriceDec;

	public float BidPrice;

	public int BidSize;

	public float BidVol;

	public decimal AskPriceDec;

	public float AskPrice;

	public int AskSize;

	public float AskVol;

	public float ClosePrice;

	public float OpenSession;

	public float OpenDay;

	public float LimitUp;

	public float LimitDown;

	public float BazPrice;

	public string MarketMakerCode;

	public float MarketMakerBid;

	public float MarketMakerAsk;

	public float PriceStep;

	public int TickSession;

	public int TickDay;

	public float IzafiSession;

	public string Date;

	public string Time;

	public float WaitingBidWavr;

	public float WaitingAskWavr;

	public float WaitingBidSize;

	public float WaitingAskSize;

	public float WaitingBidRate;

	public float WaitingAskRate;

	public float HighSession;

	public float HighDay;

	public float HighWeek;

	public float HighWeek1;

	public float HighMonth;

	public float HighMonth1;

	public float HighMonth3;

	public float HighMonth6;

	public float HighYear;

	public float HighYear1;

	public float LowSession;

	public float LowDay;

	public float LowWeek;

	public float LowWeek1;

	public float LowMonth;

	public float LowMonth1;

	public float LowMonth3;

	public float LowMonth6;

	public float LowYear;

	public float LowYear1;

	public float PrevCloseSession;

	public float PrevCloseDay;

	public float PrevCloseWeek;

	public float PrevCloseWeek1;

	public float PrevCloseMonth;

	public float PrevCloseMonth1;

	public float PrevCloseMonth3;

	public float PrevCloseMonth6;

	public float PrevCloseYear;

	public float PrevCloseYear1;

	public float NetDifSession;

	public float NetDifDay;

	public float NetDifWeek;

	public float NetDifWeek1;

	public float NetDifMonth;

	public float NetDifMonth1;

	public float NetDifMonth3;

	public float NetDifMonth6;

	public float NetDifYear;

	public float NetDifYear1;

	public float NetPerSession;

	public float NetPerDay;

	public float NetPerWeek;

	public float NetPerWeek1;

	public float NetPerMonth;

	public float NetPerMonth1;

	public float NetPerMonth3;

	public float NetPerMonth6;

	public float NetPerYear;

	public float NetPerYear1;

	public double SizeSession;

	public double SizeDay;

	public double SizeWeek;

	public double SizeWeek1;

	public double SizeMonth;

	public double SizeMonth1;

	public double SizeMonth3;

	public double SizeMonth6;

	public double SizeYear;

	public double SizeYear1;

	public double VolSession;

	public double VolDay;

	public double VolWeek;

	public double VolWeek1;

	public double VolMonth;

	public double VolMonth1;

	public double VolMonth3;

	public double VolMonth6;

	public double VolYear;

	public double VolYear1;

	public float WavrSession;

	public float WavrDay;

	public float WavrPeriodic;

	public float Wavr2Session;

	public float Wavr2Week;

	public float Wavr2Week1;

	public float Wavr2Month;

	public float Wavr2Month1;

	public float Wavr2Month3;

	public float Wavr2Month6;

	public float Wavr2Year;

	public float Wavr2Year1;

	public float MoneyflowInput;

	public float MoneyflowOutput;

	public float MoneyflowTotal;

	public float MoneyflowNetDif;

	public float MoneyflowNetPer;

	public float MoneyflowGraph;

	public float GraphSession;

	public float GraphWeek;

	public float GraphWeek1;

	public float GraphMonth;

	public float GraphMonth1;

	public float GraphMonth3;

	public float GraphMonth6;

	public float GraphYear;

	public float GraphYear1;

	public string BalanceSheetPeriod;

	public double Capital;

	public double OzCapital;

	public double PiyDegDefDeg;

	public double NetProfit;

	public double PublicRatio;

	public double NumberOfShares;

	public double PriceEarningRatio;

	public double PriceEarningValue;

	public double MarketValue;

	public double BookValue;

	public float BorrowBid;

	public float BorrowAsk;

	public float BorrowLast;

	public float PrevSettlement;

	public float SettlementPrice;

	public float FixingPrice;

	public string ExpiryDate;

	public int DaysToExpiry;

	public int OpenInterest;

	public int OpenInterestDif;

	public float AI;

	public float BSP;

	public float BidRate;

	public float AskRate;

	public float ASP;

	public float LastRate;

	public float LastTakas;

	public float CY;

	public int DTM;

	public int DTC;

	public float RYLD;

	public float PrevRate;

	public float PrevPrice;

	public string PrevDate;

	public float AV;

	public float SY;

	public float AVSP;

	public float MinRate;

	public float MaxRate;

	public float AvrRate;

	public string BidTime;

	public string AskTime;

	public string Vade;

	public string Valor;

	public int Day;

	public string Isin;

	public string Risk;

	public int Line;

	public float AVRCY;

	public float FI182;

	public float FI273;

	public float FI365;

	public float FI456;

	public float FIGENEL;

	public string Maturity;

	public string Currency;

	public float Coupon;

	public float Spread;

	public float Duration;

	public double OptionPremiumDay;

	private string baseSymbol;

	public string OptionType;

	public string OptionKind;

	public float StrikePrice;

	public string GrupName;

	public string GrupNo;

	public string StartDate;

	public float Multiplier;

	public string DeliveryType;

	public string PrevSymbol;

	public string Action;

	public string SessionName;

	public string Broker;

	public float Barrier;

	public float TeorikVal;

	public float TeorikDif;

	public float TeorikPer;

	public byte RelationalNews;

	public string DecFormat;

	public bool BoolBidPrice;

	public bool BoolAskPrice;

	public bool BoolLastPrice;

	public bool BoolRefreshed;

	public float LastPriceForDir;

	public bool PushEnabled;

	public int ChartIndexDay;

	public int ChartIndexMin60;

	public int ChartIndexMin05;

	public int ChartIndexMin01;

	public double SizeWeekCalc;

	public double SizeMonthCalc;

	public double SizeYearCalc;

	public double SizeWeek1Calc;

	public double SizeMonth1Calc;

	public double SizeMonth3Calc;

	public double SizeMonth6Calc;

	public double SizeYear1Calc;

	public double VolWeekCalc;

	public double VolMonthCalc;

	public double VolYearCalc;

	public double VolWeek1Calc;

	public double VolMonth1Calc;

	public double VolMonth3Calc;

	public double VolMonth6Calc;

	public double VolYear1Calc;

	public string OutString;

	public int ColorType;

	public int AlignType;

	public float DengeFiyat;

	public double DengeMiktar;

	public double DengeBidKalan;

	public double DengeAskKalan;

	public float DengeLastFark;

	public float DengeLastFarkY;

	public double DengeLotFark;

	public double KurumNetLot;

	public double KurumNetHacim;

	public double KurumNetMaliyet;

	public double KurumToplamLot;

	public double KurumToplamHacim;

	public double KurumAlisLot;

	public double KurumAlisHacim;

	public double KurumAlisMaliyet;

	public double KurumSatisLot;

	public double KurumSatisHacim;

	public double KurumSatisMaliyet;

	public int MaksAlanId;

	public double MaksAlanNet;

	public double MaksAlanYuzde;

	public int MaksSatanId;

	public double MaksSatanNet;

	public double MaksSatanYuzde;

	public double Pgc5Lot;

	public double Pgc5AlisToplam;

	public double Pgc5SatisToplam;

	public double Pgc5Oran;

	public double Pgc5Tl;

	public double Pgc5TlAlisToplam;

	public double Pgc5TlSatisToplam;

	public double Pgc5TlOran;

	public double PgcDigerLot;

	public double PgcDigerAlisToplam;

	public double PgcDigerSatisToplam;

	public double PgcDigerOran;

	public double PgcDigerTl;

	public double PgcDigerTlAlisToplam;

	public double PgcDigerTlSatisToplam;

	public double PgcDigerTlOran;

	public double MaksAlanMaliyet;

	public double MaksSatanMaliyet;

	public string TakasBirKurumKod;

	public double TakasBirLot;

	public double TakasBirYuzde;

	public double TakasYabanciLot;

	public double TakasYabanciYuzde;

	public double TakasYabanciHaftaFark;

	public double TakasYabanciHaftaYuzde;

	public double TakasYabanciAyFark;

	public double TakasYabanciAyYuzde;

	public float DayanakFiyat;

	public float DayanakFark1;

	public float DayanakFark2;

	public float DayanakAlSat;

	public float DayanakSatAl;

	public string Dipnot;

	public double LastPrice2;

	public double OpenPrice2;

	public double LowPrice2;

	public double HighPrice2;

	public double LastSize2;

	public double LastVol2;

	public double BidSize2;

	public double AskSize2;

	public double NetDifDay2;

	public float SettleFark;

	public float SettleFarkY;

	public double BolunmeOncesiWavr;

	[NonSerialized]
	public bool WebUpdateBool;

	[NonSerialized]
	public int WebLastSize;

	[NonSerialized]
	public decimal WebBidPrice;

	[NonSerialized]
	public int WebBidSize;

	[NonSerialized]
	public decimal WebAskPrice;

	[NonSerialized]
	public int WebAskSize;

	[NonSerialized]
	public float WebLimitUp;

	[NonSerialized]
	public float WebLimitDown;

	[NonSerialized]
	public float WebPriceStep;

	[NonSerialized]
	public float WebWavrSession;

	[NonSerialized]
	public double WebVolSession;

	[NonSerialized]
	public double WebSizeSession;

	[NonSerialized]
	public double WebSizeDay;

	[NonSerialized]
	public float WebHighSession;

	[NonSerialized]
	public float WebLowSession;

	[NonSerialized]
	public float WebPrevCloseSession;

	[NonSerialized]
	public long WebAjaxTime;

	[NonSerialized]
	public long WebDrnUpdateTime;

	[NonSerialized]
	public long WebIslemUpdateTime;

	[NonSerialized]
	public string WebSymbolCatagory;

	public static volatile Dictionary<string, cxBasic> Dictionary;

	public static Dictionary<string, string> RootDictionary;

	public static string[] FieldHeaderArray;

	public static Dictionary<string, int> FieldHeaderDictionary;

	public static int[] FieldAlignArray;

	public static Dictionary<string, string> TooltipDictionary;

	public static AutoCompleteStringCollection AutoCompleteImkb;

	public static AutoCompleteStringCollection AutoCompleteVip;

	public static AutoCompleteStringCollection AutoCompleteSase;

	public static AutoCompleteStringCollection AutoCompleteAll;

	public static AutoCompleteStringCollection AutoCompleteImkbVip;

	public static AutoCompleteStringCollection AutoCompleteTahvil;

	public static AutoCompleteStringCollection AutoCompleteTurib;

	public static AutoCompleteStringCollection AutoCompleteFon;

	public static float UsdValue;

	public static float EurValue;

	public static float RepoValue;

	public static Dictionary<int, string> IdSembolMap;

	public static Dictionary<int, string> IdSembolRootMap;

	public static Dictionary<int, cxBasic> IdDictionary;

	public static Dictionary<string, string> DipnotDictionary;

	public static Dictionary<string, Bitmap> IkonDictionary;

	public string BaseSymbol
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalculateChartIndex()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalculateDaysToExpiry()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalculateHighLowChange(string updatetypeX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalculateHighLowChangeTuribGosterge(string updatetypeX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalculatePriceStep()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalculateTeorikPrice()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalculateTeminat()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetAlertPrice(string pricetypeX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetFieldAsString(int fieldnoX, byte currencypriceX, byte currencyvolumeX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetRootWithGrup()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static decimal SetPriceAdjustedStep(cxBasic basicX, decimal priceX)
	{
		return (decimal)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddItem(string symbolX, string marketX, int decpointX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ContainsItem(string symbolX)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DeleteExpiredCharts()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Deserialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void FillAutoCompleteLists()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetCriptoKod()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetTooltip(string keyX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static cxBasic GetItem(string symbolX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetSortedListString(List<cxBasic> listX, int fieldX, int directionX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float GetBondRate()
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetPazarNameFromGrup(string grupKodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetDurumSringFromCode(string durumKodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InitFieldAlign()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InitFieldHeaders()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InitTooltip()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReadDolarEuro()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemoveItem(string symbolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetFieldValue(string symbolX, string fieldnameX, string fielddataX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SortList(ref List<cxBasic> listX, int fieldX, int directionX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void MapRoot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CalculateTavanTaban()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string IdToSembol(int id)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string IdToRoot(int id)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static cxBasic GetWithId(int id)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReadDipnot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteDipnot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxBasic()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static cxBasic()
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		Dictionary = new Dictionary<string, cxBasic>();
		RootDictionary = new Dictionary<string, string>();
		FieldHeaderArray = new string[288];
		FieldHeaderDictionary = new Dictionary<string, int>();
		FieldAlignArray = new int[300];
		TooltipDictionary = new Dictionary<string, string>();
		AutoCompleteImkb = new AutoCompleteStringCollection();
		AutoCompleteVip = new AutoCompleteStringCollection();
		AutoCompleteSase = new AutoCompleteStringCollection();
		AutoCompleteAll = new AutoCompleteStringCollection();
		AutoCompleteImkbVip = new AutoCompleteStringCollection();
		AutoCompleteTahvil = new AutoCompleteStringCollection();
		AutoCompleteTurib = new AutoCompleteStringCollection();
		AutoCompleteFon = new AutoCompleteStringCollection();
		UsdValue = 0f;
		EurValue = 0f;
		RepoValue = 0f;
		IdSembolMap = new Dictionary<int, string>();
		IdSembolRootMap = new Dictionary<int, string>();
		IdDictionary = new Dictionary<int, cxBasic>();
		DipnotDictionary = new Dictionary<string, string>();
		IkonDictionary = new Dictionary<string, Bitmap>();
	}
}
