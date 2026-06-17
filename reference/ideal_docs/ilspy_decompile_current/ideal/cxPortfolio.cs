using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml;
using Binance.Net;
using Newtonsoft.Json;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class cxPortfolio
{
	public class TrustAllCertificatePolicy : ICertificatePolicy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TrustAllCertificatePolicy()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CheckValidationResult(ServicePoint sp, X509Certificate cert, WebRequest req, int problem)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TrustAllCertificatePolicy()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class Log
	{
		public static volatile string LogString;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetEndString(AccountRecord accountX, string strX, long milisecondX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string HidePassword(AccountRecord accountX, string strX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void WriteLogString()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Log()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Log()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			WP6RZJql8gZrNhVA9v.w65ov7siki();
			hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
			LogString = "";
		}
	}

	public class WebTradeLog
	{
		public class Rec
		{
			public string Username;

			public string TR_REMOTEIP;

			public string TR_GIDENMESAJ;

			public string TR_DONENMESAJ;

			public string TR_DATETIME;

			public int TR_SURE;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Rec()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Rec()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public static List<Rec> LogList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Insert(string username, string ip, string request, string response, int sure)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Write()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WebTradeLog()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static WebTradeLog()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			WP6RZJql8gZrNhVA9v.w65ov7siki();
			hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
			LogList = new List<Rec>();
		}
	}

	[Serializable]
	public class AccountRecord
	{
		public string Broker;

		public string AccountName;

		public string ActiveAccountNo;

		public string ApiKey_R;

		public string SecretKey_R;

		public string SuccsessLoginTime;

		public string FailedLoginTime;

		public bool Remember;

		public bool ViopHesapKapaliBool;

		public bool Selected;

		public bool SanalHesapBool;

		[NonSerialized]
		public string ApiKey;

		[NonSerialized]
		public string BackOfficeIp;

		[NonSerialized]
		public string BackOfficeBIST_IP;

		[NonSerialized]
		public string BackOfficeVIOP_IP;

		[NonSerialized]
		public string SecretKey;

		[NonSerialized]
		public string Password;

		[NonSerialized]
		public string OriginalPassword;

		[NonSerialized]
		public string OldPassword;

		[NonSerialized]
		public string Parola;

		[NonSerialized]
		public string remoteIP;

		[NonSerialized]
		public string localIP;

		[NonSerialized]
		public string LocalPort;

		[NonSerialized]
		public bool Loggedin;

		[NonSerialized]
		public string LoginType;

		[NonSerialized]
		public string WebLogin;

		[NonSerialized]
		public List<string> AccountNoList;

		[NonSerialized]
		public string LoginUrl;

		[NonSerialized]
		public string WebUrl;

		[NonSerialized]
		public string ImkbUrl;

		[NonSerialized]
		public string VipUrl;

		[NonSerialized]
		public string ImkbBackOffice;

		[NonSerialized]
		public string VipBackOffice;

		[NonSerialized]
		public string GeneksVendorCode;

		[NonSerialized]
		public string WebAccountName;

		[NonSerialized]
		public string WebParola;

		[NonSerialized]
		public string WebPassword;

		[NonSerialized]
		public Dictionary<string, string> AcigaSatisKapamaDictionary;

		[NonSerialized]
		public string SmsSifre;

		[NonSerialized]
		public string SmsSure;

		[NonSerialized]
		public string HttpMethod;

		[NonSerialized]
		public string Token;

		[NonSerialized]
		public string PasswordChangeToken;

		[NonSerialized]
		public int MagnusSendCount;

		[NonSerialized]
		public int MagnusTabActive;

		[NonSerialized]
		public int MagnusNext;

		[NonSerialized]
		public string Otp;

		[NonSerialized]
		public string Id;

		[NonSerialized]
		public string Msg;

		[NonSerialized]
		public Token TokenObj;

		[NonSerialized]
		public Artiox.Cookie Cookie;

		[NonSerialized]
		public string Code2FA;

		[NonSerialized]
		public string IP;

		[NonSerialized]
		public string StateID;

		[NonSerialized]
		public int FAZ;

		[NonSerialized]
		public string bsSessionId;

		[NonSerialized]
		public string throwMsg;

		[NonSerialized]
		public string IsYatTransactionId;

		[NonSerialized]
		public string sessionId;

		[NonSerialized]
		public string tokenVersion;

		[NonSerialized]
		public string verificationType;

		[NonSerialized]
		public string phoneNumber;

		[NonSerialized]
		public string HesapYetki;

		[NonSerialized]
		public string username;

		[NonSerialized]
		public string personName;

		[NonSerialized]
		public string email;

		[NonSerialized]
		public string musteriNo;

		[NonSerialized]
		public string unvan;

		[NonSerialized]
		public double AcarVipMaliyet;

		[NonSerialized]
		public string MagnusToken;

		[NonSerialized]
		public string MagnusTransactionID;

		[NonSerialized]
		public string MSG;

		[NonSerialized]
		public string PushMsg;

		[NonSerialized]
		public string Device;

		[NonSerialized]
		public string DeviceId;

		[NonSerialized]
		public string DeviceName;

		[NonSerialized]
		public string OTPDurum;

		[NonSerialized]
		public string PN;

		[NonSerialized]
		public string UserId;

		[NonSerialized]
		public string CustomerNo;

		[NonSerialized]
		public string VirmanYetkisi;

		[NonSerialized]
		public Dictionary<string, TebHesapClass> TebHesapDict;

		[NonSerialized]
		public Dictionary<string, IsYatırım.Accounts> IsYatirimHesapDict;

		[NonSerialized]
		public bool DropCopyBool;

		public string Tanim
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string Password_R
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string Parola_R
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string RemoteImkbIPPort
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string RemoteVIOPIPPort
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public int OrderId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResolveIP()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TebHesapClass GetTebSubAccout(string hesapNoX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccountRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static AccountRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class BrokerRecord
	{
		public string BrokerName;

		public string LoginType;

		public string WebLogin;

		public string LoginUrl;

		public string ImkbUrl;

		public string VipUrl;

		public string ImkbBackOffice;

		public string VipBackOffice;

		public string MenuLabel;

		public string Code;

		public string WebUrl;

		public string HttpMethod;

		public int FAZ;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BrokerRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static BrokerRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[Serializable]
	public class BuySellRecord
	{
		public string LocalOrderKey;

		public string AccountName;

		public string AccountNo;

		public string Prefix;

		public string Symbol;

		public double Price;

		public double Amount;

		public double AmountShowing;

		public string Duration;

		public string OrderType;

		public string Direction;

		public string SellType;

		public string AcigaSatisKapama;

		public bool AcigaSatisKapamaBool;

		public bool Selected;

		public string Kriter;

		public bool ZincirGKY;

		public bool SmsBool;

		public bool MailBool;

		public bool GenelSatis;

		public string Leverage;

		public string LotSize;

		public string MagnusTransaction;

		public RiskBildirimSonuc RiskBildirimOnay;

		public bool AksamSeansBool;

		public string SeansType;

		public string PriceType;

		public bool SartBool;

		public string SartSymbol;

		public string SartType;

		public double SartPrice;

		public double Stop;

		public DateTime EndDate;

		public string AlgoKey;

		public string AlgoSistem;

		public string AlgoReturnedText;

		public string AlgoExecutionTime;

		public string AlgoChartPeriod;

		public bool RobotBool;

		public IDealOrderType iDealOrderType;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AksamSeansCheckWithTime()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BuySellRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static BuySellRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public enum IDealOrderType
	{
		Normal,
		Robot,
		iDealGo,
		TaramaRobot,
		RoboTrade,
		OtoTrade,
		GridBot,
		TrendBot,
		YatayBot,
		PacalBot,
		Arbitraj,
		TrendAlarm,
		EgzotikRobot,
		ExecutionAlgo
	}

	public class GtpContractDef
	{
		public class Record
		{
			public string ContractName;

			public string ContractId;

			public string Description;

			public string GroupId;

			public string FI_TYPE;

			public string FIN_INST_ID;

			public string LAST_TRADABLE_DATE;

			public string PRICE_LEN;

			public string PUT_CALL;

			public string RES_FIN_INST_ID;

			public string RES_NAME;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Record()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Record()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public static Dictionary<string, Record> Dictionary;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Record GetContract(string contractname, string hesapkurum)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GtpContractDef()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GtpContractDef()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			WP6RZJql8gZrNhVA9v.w65ov7siki();
			hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
			Dictionary = new Dictionary<string, Record>();
		}
	}

	public class MoneyTransfer
	{
		public string HesapName;

		public string Balance;

		public static List<MoneyTransfer> List;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MoneyTransfer()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static MoneyTransfer()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			WP6RZJql8gZrNhVA9v.w65ov7siki();
			hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
			List = new List<MoneyTransfer>();
		}
	}

	[Serializable]
	public class SistemMultiRecord
	{
		public string SistemName;

		public bool Enabled;

		public Color Color;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SistemMultiRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SistemMultiRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class ImkbPositionRecord
	{
		public string Symbol;

		public double Lot;

		public double LastPrice;

		public double Sellable;

		public double Cost;

		public double Bloke;

		public double ProfitX;

		public string PortfolioType;

		public string uniqueSymbol;

		public string equityType;

		public double balanceT;

		public double balanceT1;

		public double balanceT2;

		public double balanceT3;

		public double avgPrice;

		public string depotCode;

		public double currentAmount;

		public double Total;

		public string AssetType;

		public string BalanceType;

		public double LotT1;

		public double LotT2;

		public double PortfoyOran;

		public string Rumuz;

		public string HesapName;

		public string AltHesap;

		public string DovizCinsi;

		public double DovizDegeri;

		public double Price;

		public double Profit
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0.0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		public double ProfitYuzde
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0.0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		public double TotalTL
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0.0;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ImkbPositionRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ImkbPositionRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class ImkbTransactionReport
	{
		public string AccountNo;

		public string ProcessDate;

		public string Symbol;

		public string BuySell;

		public double Price;

		public int BuyLot;

		public int SellLot;

		public double BuyTotalTL;

		public double SellTotalTL;

		public double CommissionAmount;

		public double Commission;

		public double BSMV;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ImkbTransactionReport()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ImkbTransactionReport()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class TransactionReportSummary
	{
		public double BuyTotal;

		public double SellTotal;

		public double NetAmount;

		public double VolumeTotal;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TransactionReportSummary()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TransactionReportSummary()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class ImkbOrderRecord
	{
		public string LongAccountName;

		public string AccountName;

		public string AccountNo;

		public string OrderNo;

		public string Symbol;

		public string BuySell;

		public double Amount;

		public double AmountShowing;

		public double GAmount;

		public double Balance;

		public double GPrice;

		public double Price;

		public double Total;

		public double GTotal;

		public string ValorDate;

		public string Status;

		public string StatusCode;

		public string Session;

		public string OrderPermit;

		public string OrderDate;

		public string OrderUpdateDate;

		public string OrderEndDate;

		public string OrderType;

		public string CancelPermit;

		public string AmendPermit;

		public string ImprovePermit;

		public string OneSessionPermit;

		public string OrderRef;

		public string OrderSessionNo;

		public string ZincirRef;

		public string Note;

		public string Validity;

		public string SatisTip;

		public string GSaat;

		public int EmirUpdateNum;

		public int SiraNo;

		public int MaxZincirSiraNo;

		public string RefNo;

		public string BorsaRefNo;

		public string SessionName;

		public string ExecutionStatus;

		public byte Selected;

		public string OrderNoString
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ImkbOrderRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ImkbOrderRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class ImkbWaitingRecord
	{
		public List<string> OrderNoList;

		public string Symbol;

		public string BuySell;

		public double Amount;

		public double GAmount;

		public double Balance;

		public double GPrice;

		public double Price;

		public double Total;

		public double GTotal;

		public string Status;

		public string SessionName;

		public string OrderRef;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ImkbWaitingRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ImkbWaitingRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class ProfitRecord
	{
		public string Symbol;

		public double BotLot;

		public double BotLira;

		public double BotAvr;

		public double BotPercent;

		public double SoldLot;

		public double SoldLira;

		public double SoldAvr;

		public double SoldPercent;

		public double NetLot;

		public double NetLira;

		public double LastPrice;

		public double Cost;

		public double Profit;

		public double TotalLot;

		public double TotalLira;

		public static double BotLiraSum;

		public static double SoldLiraSum;

		public static double NetLiraSum;

		public static double ProfitSum;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ProfitRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ProfitRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class PositionInfo
	{
		public string Symbol;

		public double GPrice;

		public double Price;

		public string buySell;

		public double GAmount;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PositionInfo()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static PositionInfo()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class ProfitConsolideRecord
	{
		public List<string> AddedAccountList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ProfitConsolideRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ProfitConsolideRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class ImkbStatementRecord
	{
		public string ProcessDate;

		public string ValorDate;

		public string Description;

		public double Debt;

		public double Credit;

		public double Balance;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ImkbStatementRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ImkbStatementRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class VipTransactionReport
	{
		public string AccountNo;

		public string ProcessDate;

		public string Time;

		public string Transaction;

		public string Contract;

		public string Market;

		public string BuySell;

		public double Price;

		public int Lot;

		public double Volume;

		public string CrossMember;

		public string OrderTime;

		public string Type;

		public string Session;

		public int OpenLot;

		public double OpenCommission;

		public double MarketCommission;

		public double Commission;

		public double BSMV;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VipTransactionReport()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static VipTransactionReport()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class VipPositionRecord
	{
		public string Symbol;

		public double BuyAmount;

		public double SellAmount;

		public double OpenAmount;

		public double NetAmount;

		public double UnitAmount;

		public double OpenPosition;

		public double Profit;

		public decimal PozSize;

		public decimal ProfitAnlik;

		public decimal ProfitAnlikSettlementPrice;

		public decimal SettlementPriceUzlasi;

		public decimal ProfitAnlikLastPrice;

		public decimal ProfitFifo;

		public double SonUzlasi;

		public string Status;

		public string Direction;

		public double Total;

		public double Price;

		public double LastPrice;

		public double SettlementPrice;

		public string ContractType;

		public string Tip;

		public string Risk;

		public string PositionDate;

		public string Currency;

		public double Cost;

		public string Nominal;

		public double GunBasiFifoMaliyet;

		public double NetFifoMaliyet;

		public double NetMaliyet;

		public double OpsiyonPrimiNet;

		public double FifoMaliyet;

		public double AcilisMaliyet;

		public string uniqueSymbol;

		public string depotCode;

		public double balanceT;

		public double balanceT1;

		public double balanceT2;

		public double balanceT3;

		public double avgPrice;

		public double currentAmount;

		public double profitLoss;

		public int assetCoef;

		public int sellCoef;

		public float qty;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VipPositionRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static VipPositionRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class VipOrderRecord
	{
		public string LongAccountName;

		public string AccountName;

		public string AccountNo;

		public string OrderNo;

		public string RecordNo;

		public string Symbol;

		public string BuySell;

		public string SubMarket;

		public double Amount;

		public double GAmount;

		public double Balance;

		public double GPrice;

		public double Price;

		public double Stop;

		public double Total;

		public decimal GTotal;

		public string ValorDate;

		public string Status;

		public string StatusCode;

		public string State;

		public string CancelReason;

		public string PositionClosing;

		public string SpanDurum;

		public string BorsaDurum;

		public string Session;

		public string OrderPermit;

		public string OrderDate;

		public string OrderTime;

		public string OrderType;

		public string EndDate;

		public string PriceType;

		public string CancelPermit;

		public string AmendPermit;

		public string Nominal;

		public string BorsaEmirNo;

		public string TemsilciRef;

		public double EnteredAmount;

		public double InvisibleAmount;

		public double VisibleBalance;

		public string OrderRef;

		public string Orj_sysId;

		public string OrderSender;

		public string GSaat;

		public string SeansType;

		public string RefNo;

		public bool AksamSeansBool;

		public string SartTip;

		public string SartYon;

		public string SartTipStr;

		public string SartSembol;

		public double SartFiyat;

		public bool SartBool;

		public string SessionName;

		public string ExecutionStatus;

		public string DurationConvert;

		public string OrderTypeConvert;

		public string PriceTypeConvert;

		public DateTime EndDateConvert;

		public DateTime OrderDateConvert;

		public byte Selected;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VipOrderRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static VipOrderRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class VipStatementRecord
	{
		public string ProcessDate;

		public string ValorDate;

		public string Description;

		public double Debt;

		public double Credit;

		public double Balance;

		public double TeminatBakiye;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VipStatementRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static VipStatementRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class VipProfitRecord
	{
		public string MusteriID;

		public string HesapID;

		public string MenukulID;

		public string Sozlesme;

		public string Nominal;

		public string ShortLong;

		public string ItfaTarihi;

		public string KapanisFiyati;

		public string Maliyet;

		public string Adet;

		public string KarZarar;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VipProfitRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static VipProfitRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class VipKZRaporRecord
	{
		public string Sozlesme;

		public double KarZarar;

		public int AcikUzunPoz;

		public int AcikKisaPoz;

		public string UzunKisa;

		public string ParaBirimi;

		public string VadeSonu;

		public float KulFiyat;

		public string Aciklama;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VipKZRaporRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static VipKZRaporRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class VipContractGtp
	{
		public class Record
		{
			public string ContractName;

			public string ContractId;

			public string Description;

			public string GroupId;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Record()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Record()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public static Dictionary<string, Record> Dictionary;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Record GetContract(string keyX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VipContractGtp()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static VipContractGtp()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			WP6RZJql8gZrNhVA9v.w65ov7siki();
			hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
			Dictionary = new Dictionary<string, Record>();
		}
	}

	public class GerceklesenIslemClass
	{
		public string Sembol;

		public decimal Miktar;

		public decimal Fiyat;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GerceklesenIslemClass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GerceklesenIslemClass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[Serializable]
	public class RobotPositionClass
	{
		public double Position;

		public double SonIslemFiyat;

		public DateTime SonIslemTarih;

		public string Rezerv;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RobotPositionClass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static RobotPositionClass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class AkDuyuruOnayClass
	{
		public string Mesaj_ID;

		public string MesajText;

		public static List<AkDuyuruOnayClass> DuyuruOnayList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AkDuyuruOnayClass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static AkDuyuruOnayClass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			WP6RZJql8gZrNhVA9v.w65ov7siki();
			hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
			DuyuruOnayList = new List<AkDuyuruOnayClass>();
		}
	}

	public class FonPositionRecord
	{
		public string FonAdi;

		public string FonKodu;

		public float Adet;

		public float SatilabilirAdet;

		public float Maliyet;

		public float DegerlendirmeFiyati;

		public float VarlikTutari;

		public float KarZarar;

		public double PortfoyOrani;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FonPositionRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static FonPositionRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class FonIslemRecord
	{
		public string AlSat;

		public string IslemNo;

		public string FonAdi;

		public string FonKodu;

		public string ValorTarihi;

		public string Durum;

		public string Aciklama;

		public decimal Fiyat;

		public decimal ToplamAdet;

		public decimal GerceklesenAdet;

		public decimal Tutar;

		public string FonId;

		public string IptalStr;

		public string TalepIptal;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FonIslemRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static FonIslemRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class FonTanimRecord
	{
		public string FonKodu;

		public string FonAdi;

		public string FonTipi;

		public string AdetTutarTip;

		public decimal BirimFiyat;

		public string Aciklama;

		public string Durum;

		public string FonId;

		public string IhbarGun;

		public decimal AdetYuvarlama;

		public string BaslangicSaat;

		public string BitisSaat;

		public decimal Miktar;

		public decimal OrtalamaMaliyet;

		public decimal ToplamMaliyet;

		public decimal BugunkuDeger;

		public decimal KarZarar;

		public decimal BlokeMiktar;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FonTanimRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static FonTanimRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class VarlikRecord
	{
		public string Sembol;

		public string Tip;

		public string KiymetAciklama;

		public decimal Adet;

		public decimal Kapanis;

		public decimal TutarSon;

		public decimal Maliyet;

		public decimal TutarIlk;

		public decimal ToplamKz;

		public string UzunKisa;

		public decimal GuniciKz;

		public decimal Teminat;

		public decimal CariBakiye;

		public decimal DovizBakiye;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VarlikRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static VarlikRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class CriptoPositionRecord
	{
		public string Symbol;

		public string Coin;

		public string Description;

		public double Lot;

		public double Locked;

		public double LastPrice;

		public double Sellable;

		public double Cost;

		public double Bloke;

		public double ProfitX;

		public double Request;

		public double Blocked;

		public double Available;

		public string AssetType;

		public string BalanceType;

		public int id;

		public string Asset
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string Order
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public double Total
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0.0;
			}
		}

		public double Profit
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0.0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CriptoPositionRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static CriptoPositionRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class CriptoOrderRecord
	{
		public string LongAccountName;

		public string AccountName;

		public string AccountNo;

		public string OrderNo;

		public string Symbol;

		public string Kod;

		public string BuySell;

		public decimal Amount;

		public double AmountShowing;

		public double GAmount;

		public double Balance;

		public double GPrice;

		public decimal Price;

		public decimal StopPrice;

		public double Total;

		public double GTotal;

		public string ValorDate;

		public string Status;

		public string StatusCode;

		public string Session;

		public string OrderPermit;

		public string OrderDate;

		public string OrderEndDate;

		public string OrderType;

		public string CancelPermit;

		public string AmendPermit;

		public string ImprovePermit;

		public string OneSessionPermit;

		public string OrderRef;

		public string OrderSessionNo;

		public string ZincirRef;

		public string Note;

		public string Validity;

		public string SatisTip;

		public string SessionName;

		public string ExecutionStatus;

		public byte Selected;

		public string OrderNoString
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CriptoOrderRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static CriptoOrderRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class CriptoTradeRecord
	{
		public string Symbol
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string Kod
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public int Id
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public long OrderId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public int OrderListId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public decimal Price
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (decimal)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public decimal Quantity
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (decimal)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public decimal QuoteQuantity
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (decimal)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public decimal Commission
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (decimal)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string CommissionAsset
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public DateTime TradeTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (DateTime)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsBuyer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsMaker
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsBestMatch
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CriptoTradeRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static CriptoTradeRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class CriptoBinanceAcoountSnapShotRrebord
	{
		public List<BalanceCripto> balances
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public decimal totalAssetOfBtc
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (decimal)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public DateTime Timestamp
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (DateTime)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CriptoBinanceAcoountSnapShotRrebord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static CriptoBinanceAcoountSnapShotRrebord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class BalanceCripto
	{
		public string asset
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string free
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string locked
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BalanceCripto()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static BalanceCripto()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class BalanceHistoryRecord
	{
		public DateTime Time
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (DateTime)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public double Balance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BalanceHistoryRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static BalanceHistoryRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class BinanceFuture
	{
		public class RequestMethods
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public string GetAccountInformation()
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public string GetPositionInformation()
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public string GetOpenOrders()
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public string GetOrderHistory()
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public string GetTradeHistory()
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public string GetTransactionHistory()
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public string GetAssets()
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public string GetLeverageLimits()
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public string GetExchangeInformation()
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public string GetCurrentMultiAssetsMode()
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public string SendNewOrder(string symbol, string side, string positionSide, string type, string timeInForce, string quantity, string price, string stopPrice)
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ResponseClasses.CancelOrderResult SendCancelOrder(long orderId, string symbol)
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public string ChangeMarginType(string symbol, string marginType)
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public string ChangeLeverageLimit(string leverageLimit, string symbol)
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public RequestMethods()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static RequestMethods()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public static class Helper
		{
			internal static class ApiPaths
			{
				public static string FutureAccountInformationPath;

				public static string FuturePositionInformationPath;

				public static string FutureOpenOrdersPath;

				public static string FutureAllOrdersPath;

				public static string FutureTradeHistoryPath;

				public static string FutureTransactionHistoryPath;

				public static string FutureAssetsPath;

				public static string FutureSendOrder;

				public static string FutureLeverageLimitsPath;

				public static string FutureCurrentMultiAssetsModePath;

				public static string FutureMarginTypePath;

				public static string FutureChangeLeverageLimit;

				public static string FutureExchangeInformationPath;

				[MethodImpl(MethodImplOptions.NoInlining)]
				static ApiPaths()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
					WP6RZJql8gZrNhVA9v.w65ov7siki();
					hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
					FutureAccountInformationPath = "/fapi/v2/account";
					FuturePositionInformationPath = "/fapi/v2/positionRisk";
					FutureOpenOrdersPath = "/fapi/v1/openOrders";
					FutureAllOrdersPath = "/fapi/v1/allOrders";
					FutureTradeHistoryPath = "/fapi/v1/userTrades";
					FutureTransactionHistoryPath = "/fapi/v1/income";
					FutureAssetsPath = "/fapi/v2/balance";
					FutureSendOrder = "/fapi/v1/order";
					FutureLeverageLimitsPath = "/fapi/v1/leverageBracket";
					FutureCurrentMultiAssetsModePath = "/fapi/v1/multiAssetsMargin";
					FutureMarginTypePath = "/fapi/v1/marginType";
					FutureChangeLeverageLimit = "/fapi/v1/leverage";
					FutureExchangeInformationPath = "/fapi/v1/exchangeInfo";
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static string CreateUrl(string baseUrl, string apiPath, Dictionary<string, string> parameters, string apiSecret, bool secure = true)
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static string CreateBinanceSignature(string parametersStringQuery, string apiSecret)
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static string ParametersToStringConverter(Dictionary<string, string> parameters)
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static string SendRequest(string url, string apiKey, string requestMethod = "GET")
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Helper()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ResponseClasses
		{
			public class WebException
			{
				public int code
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string msg
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public WebException()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static WebException()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class ExchangeInformationAsset
			{
				public string asset
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool marginAvailable
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string autoAssetExchange
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public ExchangeInformationAsset()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static ExchangeInformationAsset()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class ExchangeInformationFilter
			{
				public string minPrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string maxPrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string filterType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string tickSize
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string stepSize
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string maxQty
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string minQty
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long limit
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string notional
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string multiplierDown
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string multiplierUp
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string multiplierDecimal
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public ExchangeInformationFilter()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static ExchangeInformationFilter()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class ExchangeInformationRateLimit
			{
				public string rateLimitType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string interval
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long intervalNum
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long limit
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public ExchangeInformationRateLimit()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static ExchangeInformationRateLimit()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class ExchangeInformation
			{
				public string timezone
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long serverTime
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string futuresType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public List<ExchangeInformationRateLimit> rateLimits
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public List<object> exchangeFilters
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public List<ExchangeInformationAsset> assets
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public List<ExchangeInformationSymbol> symbols
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public ExchangeInformation()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static ExchangeInformation()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class ExchangeInformationSymbol
			{
				public string symbol
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string pair
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string contractType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public object deliveryDate
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public object onboardDate
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string status
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string maintMarginPercent
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string requiredMarginPercent
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string baseAsset
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string quoteAsset
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string marginAsset
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long pricePrecision
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long quantityPrecision
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long baseAssetPrecision
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long quotePrecision
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string underlyingType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public List<string> underlyingSubType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long settlePlan
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string triggerProtect
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string liquidationFee
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string marketTakeBound
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public List<ExchangeInformationFilter> filters
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public List<string> orderTypes
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public List<string> timeInForce
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public ExchangeInformationSymbol()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static ExchangeInformationSymbol()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class Bracket
			{
				public int bracket
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public int initialLeverage
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public object notionalCap
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public int notionalFloor
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public double maintMarginRatio
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0.0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public double cum
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0.0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public Bracket()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static Bracket()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class Leverage
			{
				public string symbol
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public List<Bracket> brackets
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public Leverage()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static Leverage()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class AccountInformationAsset
			{
				public string asset
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string walletBalance
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string unrealizedProfit
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string marginBalance
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string maintMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string initialMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string positionInitialMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string openOrderInitialMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string maxWithdrawAmount
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string crossWalletBalance
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string crossUnPnl
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string availableBalance
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool marginAvailable
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long updateTime
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public AccountInformationAsset()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static AccountInformationAsset()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class AccountInformationPosition
			{
				public string symbol
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string initialMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string maintMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string unrealizedProfit
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string positionInitialMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string openOrderInitialMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string leverage
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool isolated
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string entryPrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string maxNotional
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string positionSide
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string positionAmt
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string notional
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string isolatedWallet
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long updateTime
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string bidNotional
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string askNotional
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public AccountInformationPosition()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static AccountInformationPosition()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class AccountInformation
			{
				public long feeTier
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool canTrade
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool canDeposit
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool canWithdraw
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long updateTime
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string totalInitialMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string totalMaintMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string totalWalletBalance
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string totalUnrealizedProfit
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string totalMarginBalance
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string totalPositionInitialMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string totalOpenOrderInitialMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string totalCrossWalletBalance
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string totalCrossUnPnl
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string availableBalance
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string maxWithdrawAmount
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public List<AccountInformationAsset> assets
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public List<AccountInformationPosition> positions
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public AccountInformation()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static AccountInformation()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class Position
			{
				public string symbol
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string positionAmt
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string entryPrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string markPrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string unRealizedProfit
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string liquidationPrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string leverage
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string maxNotionalValue
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string marginType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string isolatedMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string isAutoAddMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string positionSide
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string notional
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string isolatedWallet
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public object updateTime
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public Position()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static Position()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class OpenOrderIcry
			{
				[JsonProperty("version")]
				public string Version;

				[JsonProperty("assets")]
				public List<Assets> Assets;

				[JsonProperty("pairs")]
				public List<Pair> Pairs;

				[MethodImpl(MethodImplOptions.NoInlining)]
				public OpenOrderIcry()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static OpenOrderIcry()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class Assets
			{
				[JsonProperty("symbol")]
				public string Symbol;

				[JsonProperty("name")]
				public string Name;

				[JsonProperty("categories")]
				public List<string> Categories;

				[JsonProperty("description")]
				public string Description;

				[JsonProperty("type")]
				public string Type;

				[JsonProperty("isEnabled")]
				public bool IsEnabled;

				[JsonProperty("isNew")]
				public bool IsNew;

				[JsonProperty("isWithdrawalEnabled")]
				public bool IsWithdrawalEnabled;

				[JsonProperty("isDepositEnabled")]
				public bool IsDepositEnabled;

				[JsonProperty("precision")]
				public int Precision;

				[JsonProperty("displayPrecision")]
				public int DisplayPrecision;

				[JsonProperty("minDeposit")]
				public string MinDeposit;

				[JsonProperty("minWithdrawal")]
				public string MinWithdrawal;

				[JsonProperty("updatedDate")]
				public int UpdatedDate;

				[JsonProperty("createdDate")]
				public int CreatedDate;

				[MethodImpl(MethodImplOptions.NoInlining)]
				public Assets()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static Assets()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class Pair
			{
				[JsonProperty("symbol")]
				public string Symbol;

				[JsonProperty("base")]
				public string Base;

				[JsonProperty("quote")]
				public string Quote;

				[JsonProperty("minExchangeValue")]
				public string MinExchangeValue;

				[JsonProperty("minPrice")]
				public string MinPrice;

				[JsonProperty("maxPrice")]
				public string MaxPrice;

				[JsonProperty("quantityPrecision")]
				public int QuantityPrecision;

				[JsonProperty("pricePrecision")]
				public int PricePrecision;

				[JsonProperty("totalPrecision")]
				public int TotalPrecision;

				[JsonProperty("commissionPrecision")]
				public int CommissionPrecision;

				[JsonProperty("displayOrder")]
				public int DisplayOrder;

				[JsonProperty("status")]
				public string Status;

				[JsonProperty("marketTypes")]
				public List<string> MarketTypes;

				[JsonProperty("orderTypes")]
				public List<string> OrderTypes;

				[JsonProperty("tickSize")]
				public string TickSize;

				[MethodImpl(MethodImplOptions.NoInlining)]
				public Pair()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static Pair()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class OpenOrder
			{
				public long orderId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string symbol
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string status
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string clientOrderId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string price
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string avgPrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string origQty
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string executedQty
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string cumQuote
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string timeInForce
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string type
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool reduceOnly
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool closePosition
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string side
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string positionSide
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string stopPrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string workingType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool priceProtect
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string origType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long time
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long updateTime
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public OpenOrder()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static OpenOrder()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class OrderHistory
			{
				public object orderId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string symbol
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string status
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string clientOrderId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string price
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string avgPrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string origQty
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string executedQty
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string cumQuote
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string timeInForce
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string type
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool reduceOnly
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool closePosition
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string side
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string positionSide
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string stopPrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string workingType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool priceProtect
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string origType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long time
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public object updateTime
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public OrderHistory()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static OrderHistory()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class TradeHistory
			{
				public string symbol
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public int id
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public object orderId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string side
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string price
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string qty
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string realizedPnl
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string marginAsset
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string quoteQty
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string commission
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string commissionAsset
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long time
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string positionSide
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool maker
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool buyer
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public TradeHistory()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static TradeHistory()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class TransactionHistory
			{
				public string symbol
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string incomeType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string income
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string asset
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long time
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string info
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public object tranId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string tradeId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public TransactionHistory()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static TransactionHistory()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class Asset
			{
				public string accountAlias
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string asset
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string balance
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string crossWalletBalance
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string crossUnPnl
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string availableBalance
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string maxWithdrawAmount
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool marginAvailable
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long updateTime
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public Asset()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static Asset()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class CurrentMultiAssetMode
			{
				public bool multiAssetsMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public CurrentMultiAssetMode()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static CurrentMultiAssetMode()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class NewOrderResult
			{
				public long orderId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string symbol
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string status
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string clientOrderId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string price
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string avgPrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string origQty
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string executedQty
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string cumQty
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string cumQuote
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string timeInForce
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string type
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool reduceOnly
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool closePosition
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string side
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string positionSide
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string stopPrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string workingType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool priceProtect
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string origType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long updateTime
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public NewOrderResult()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static NewOrderResult()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class CancelOrderResult
			{
				public string clientOrderId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string cumQty
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string cumQuote
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string executedQty
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long orderId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string origQty
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string origType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string price
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool reduceOnly
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string side
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string positionSide
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string status
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string stopPrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool closePosition
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string symbol
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string timeInForce
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string type
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string activatePrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string priceRate
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long updateTime
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string workingType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool priceProtect
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public CancelOrderResult()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static CancelOrderResult()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class MarginChangedResult
			{
				public int code
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string msg
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public MarginChangedResult()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static MarginChangedResult()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class LeverageChangedResult
			{
				public string symbol
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public int leverage
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string maxNotionalValue
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public LeverageChangedResult()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static LeverageChangedResult()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ResponseClasses()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ResponseClasses()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public static string ApiKey
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public static string ApiSecret
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public static string BaseUrl
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public RequestMethods request
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public ResponseClasses response
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BinanceFuture(string apiKey, string apiSecret, string baseUrl)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BinanceFuture()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFutureApiCredential(string apiKey, string apiSecret, string baseUrl)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static BinanceFuture()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class IcrypexFuture
	{
		public class RequestMethods
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public string GetAccountInformation()
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public string GetPositionInformation()
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public string GetOpenOrders()
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public string GetOrderHistory()
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public string GetTradeHistory()
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public string GetTransactionHistory()
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public string GetAssets()
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public string GetLeverageLimits()
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public string GetExchangeInformation()
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public string GetCurrentMultiAssetsMode()
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public string SendNewOrder(string symbol, string side, string positionSide, string type, string timeInForce, string quantity, string price, string stopPrice)
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ResponseClasses.CancelOrderResult SendCancelOrder(AccountRecord accountRecord, long orderId, string symbol)
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public string ChangeMarginType(string symbol, string marginType)
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public string ChangeLeverageLimit(string leverageLimit, string symbol)
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public RequestMethods()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static RequestMethods()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public static class Helper
		{
			internal static class ApiPaths
			{
				public static string FutureAccountInformationPath;

				public static string FuturePositionInformationPath;

				public static string FutureOpenOrdersPath;

				public static string FutureAllOrdersPath;

				public static string FutureTradeHistoryPath;

				public static string FutureTransactionHistoryPath;

				public static string FutureAssetsPath;

				public static string FutureSendOrder;

				public static string FutureLeverageLimitsPath;

				public static string FutureCurrentMultiAssetsModePath;

				public static string FutureMarginTypePath;

				public static string FutureChangeLeverageLimit;

				public static string FutureExchangeInformationPath;

				[MethodImpl(MethodImplOptions.NoInlining)]
				static ApiPaths()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
					WP6RZJql8gZrNhVA9v.w65ov7siki();
					hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
					FutureAccountInformationPath = "/fapi/v2/account";
					FuturePositionInformationPath = "/fapi/v2/positionRisk";
					FutureOpenOrdersPath = "/fapi/v1/openOrders";
					FutureAllOrdersPath = "/fapi/v1/allOrders";
					FutureTradeHistoryPath = "/fapi/v1/userTrades";
					FutureTransactionHistoryPath = "/fapi/v1/income";
					FutureAssetsPath = "/fapi/v2/balance";
					FutureSendOrder = "/fapi/v1/order";
					FutureLeverageLimitsPath = "/fapi/v1/leverageBracket";
					FutureCurrentMultiAssetsModePath = "/fapi/v1/multiAssetsMargin";
					FutureMarginTypePath = "/fapi/v1/marginType";
					FutureChangeLeverageLimit = "/fapi/v1/leverage";
					FutureExchangeInformationPath = "/fapi/v1/exchangeInfo";
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static string CreateUrl(string baseUrl, string apiPath, Dictionary<string, string> parameters, string apiSecret, bool secure = true)
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static string CreateBinanceSignature(string parametersStringQuery, string apiSecret)
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static string ParametersToStringConverter(Dictionary<string, string> parameters)
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static string SendRequest(string url, string apiKey, string requestMethod = "GET")
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Helper()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ResponseClasses
		{
			public class WebException
			{
				public int code
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string msg
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public WebException()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static WebException()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class ExchangeInformationAsset
			{
				public string asset
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool marginAvailable
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string autoAssetExchange
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public ExchangeInformationAsset()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static ExchangeInformationAsset()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class ExchangeInformationFilter
			{
				public string minPrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string maxPrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string filterType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string tickSize
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string stepSize
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string maxQty
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string minQty
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long limit
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string notional
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string multiplierDown
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string multiplierUp
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string multiplierDecimal
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public ExchangeInformationFilter()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static ExchangeInformationFilter()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class ExchangeInformationRateLimit
			{
				public string rateLimitType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string interval
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long intervalNum
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long limit
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public ExchangeInformationRateLimit()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static ExchangeInformationRateLimit()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class ExchangeInformation
			{
				public string timezone
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long serverTime
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string futuresType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public List<ExchangeInformationRateLimit> rateLimits
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public List<object> exchangeFilters
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public List<ExchangeInformationAsset> assets
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public List<ExchangeInformationSymbol> symbols
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public ExchangeInformation()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static ExchangeInformation()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class ExchangeInformationSymbol
			{
				public string symbol
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string pair
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string contractType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public object deliveryDate
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public object onboardDate
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string status
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string maintMarginPercent
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string requiredMarginPercent
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string baseAsset
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string quoteAsset
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string marginAsset
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long pricePrecision
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long quantityPrecision
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long baseAssetPrecision
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long quotePrecision
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string underlyingType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public List<string> underlyingSubType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long settlePlan
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string triggerProtect
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string liquidationFee
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string marketTakeBound
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public List<ExchangeInformationFilter> filters
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public List<string> orderTypes
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public List<string> timeInForce
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public ExchangeInformationSymbol()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static ExchangeInformationSymbol()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class Bracket
			{
				public int bracket
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public int initialLeverage
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public object notionalCap
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public int notionalFloor
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public double maintMarginRatio
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0.0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public double cum
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0.0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public Bracket()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static Bracket()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class Leverage
			{
				public string symbol
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public List<Bracket> brackets
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public Leverage()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static Leverage()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class AccountInformationAsset
			{
				public string asset
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string walletBalance
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string unrealizedProfit
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string marginBalance
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string maintMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string initialMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string positionInitialMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string openOrderInitialMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string maxWithdrawAmount
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string crossWalletBalance
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string crossUnPnl
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string availableBalance
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool marginAvailable
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long updateTime
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public AccountInformationAsset()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static AccountInformationAsset()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class AccountInformationPosition
			{
				public string symbol
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string initialMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string maintMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string unrealizedProfit
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string positionInitialMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string openOrderInitialMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string leverage
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool isolated
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string entryPrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string maxNotional
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string positionSide
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string positionAmt
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string notional
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string isolatedWallet
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long updateTime
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string bidNotional
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string askNotional
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public AccountInformationPosition()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static AccountInformationPosition()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class AccountInformation
			{
				public long feeTier
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool canTrade
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool canDeposit
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool canWithdraw
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long updateTime
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string totalInitialMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string totalMaintMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string totalWalletBalance
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string totalUnrealizedProfit
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string totalMarginBalance
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string totalPositionInitialMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string totalOpenOrderInitialMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string totalCrossWalletBalance
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string totalCrossUnPnl
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string availableBalance
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string maxWithdrawAmount
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public List<AccountInformationAsset> assets
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public List<AccountInformationPosition> positions
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public AccountInformation()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static AccountInformation()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class Position
			{
				public string symbol
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string positionAmt
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string entryPrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string markPrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string unRealizedProfit
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string liquidationPrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string leverage
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string maxNotionalValue
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string marginType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string isolatedMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string isAutoAddMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string positionSide
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string notional
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string isolatedWallet
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public object updateTime
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public Position()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static Position()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class OpenOrder
			{
				public long orderId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string symbol
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string status
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string clientOrderId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string price
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string avgPrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string origQty
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string executedQty
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string cumQuote
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string timeInForce
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string type
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool reduceOnly
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool closePosition
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string side
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string positionSide
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string stopPrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string workingType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool priceProtect
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string origType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long time
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long updateTime
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public OpenOrder()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static OpenOrder()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class OrderHistory
			{
				public object orderId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string symbol
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string status
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string clientOrderId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string price
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string avgPrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string origQty
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string executedQty
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string cumQuote
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string timeInForce
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string type
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool reduceOnly
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool closePosition
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string side
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string positionSide
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string stopPrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string workingType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool priceProtect
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string origType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long time
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public object updateTime
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public OrderHistory()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static OrderHistory()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class TradeHistory
			{
				public string symbol
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public int id
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public object orderId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string side
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string price
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string qty
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string realizedPnl
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string marginAsset
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string quoteQty
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string commission
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string commissionAsset
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long time
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string positionSide
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool maker
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool buyer
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public TradeHistory()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static TradeHistory()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class TransactionHistory
			{
				public string symbol
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string incomeType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string income
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string asset
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long time
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string info
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public object tranId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string tradeId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public TransactionHistory()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static TransactionHistory()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class Asset
			{
				public string accountAlias
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string asset
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string balance
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string crossWalletBalance
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string crossUnPnl
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string availableBalance
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string maxWithdrawAmount
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool marginAvailable
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long updateTime
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public Asset()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static Asset()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class Assets
			{
				[JsonProperty("symbol")]
				public string Symbol;

				[JsonProperty("name")]
				public string Name;

				[JsonProperty("categories")]
				public List<string> Categories;

				[JsonProperty("description")]
				public string Description;

				[JsonProperty("type")]
				public string Type;

				[JsonProperty("isEnabled")]
				public bool? IsEnabled;

				[JsonProperty("isNew")]
				public bool? IsNew;

				[JsonProperty("isWithdrawalEnabled")]
				public bool? IsWithdrawalEnabled;

				[JsonProperty("isDepositEnabled")]
				public bool? IsDepositEnabled;

				[JsonProperty("precision")]
				public int? Precision;

				[JsonProperty("displayPrecision")]
				public int? DisplayPrecision;

				[JsonProperty("minDeposit")]
				public string MinDeposit;

				[JsonProperty("minWithdrawal")]
				public string MinWithdrawal;

				[JsonProperty("updatedDate")]
				public int? UpdatedDate;

				[JsonProperty("createdDate")]
				public int? CreatedDate;

				[MethodImpl(MethodImplOptions.NoInlining)]
				public Assets()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static Assets()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class CurrentMultiAssetMode
			{
				public bool multiAssetsMargin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public CurrentMultiAssetMode()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static CurrentMultiAssetMode()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class NewOrderResult
			{
				public long orderId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string symbol
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string status
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string clientOrderId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string price
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string avgPrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string origQty
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string executedQty
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string cumQty
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string cumQuote
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string timeInForce
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string type
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool reduceOnly
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool closePosition
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string side
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string positionSide
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string stopPrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string workingType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool priceProtect
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string origType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long updateTime
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public NewOrderResult()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static NewOrderResult()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class CancelOrderResult
			{
				public string clientOrderId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string cumQty
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string cumQuote
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string executedQty
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long orderId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string origQty
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string origType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string price
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool reduceOnly
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string side
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string positionSide
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string status
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string stopPrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool closePosition
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string symbol
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string timeInForce
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string type
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string activatePrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string priceRate
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public long updateTime
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string workingType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public bool priceProtect
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public CancelOrderResult()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static CancelOrderResult()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class MarginChangedResult
			{
				public int code
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string msg
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public MarginChangedResult()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static MarginChangedResult()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			public class LeverageChangedResult
			{
				public string symbol
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public int leverage
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				public string maxNotionalValue
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					set
					{
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public LeverageChangedResult()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static LeverageChangedResult()
				{
					WP6RZJql8gZrNhVA9v.prXoP4RuYp();
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ResponseClasses()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ResponseClasses()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public static string ApiKey
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public static string ApiSecret
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public static string BaseUrl
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public RequestMethods request
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public ResponseClasses response
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IcrypexFuture(string apiKey, string apiSecret, string baseUrl)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IcrypexFuture()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFutureApiCredential(string apiKey, string apiSecret, string baseUrl)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static IcrypexFuture()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[Serializable]
	public class RiskBildirimSonuc
	{
		public bool ShowBool
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string Market
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public bool LoginStatus
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string Symbol
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string Yon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public bool ShowAll
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public bool FirstTradeBool
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RiskBildirimSonuc()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static RiskBildirimSonuc()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class Artiox
	{
		public class ReqArtioxLogin
		{
			public string auth_password
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public Client_Info client_info
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string client_ip
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string password
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sid
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string user_email
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ReqArtioxLogin()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ReqArtioxLogin()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class Client_Info
		{
			public string ip
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string city
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string country
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string loc
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Client_Info()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Client_Info()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ReqArtioxUserService
		{
			public Cookie cookie
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string client_ip
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sid
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ReqArtioxUserService()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ReqArtioxUserService()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ReqArtioxCancelOrder
		{
			public Cookie cookie
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string client_ip
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int order_id
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string order_type
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int[] pair_id
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sid
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ReqArtioxCancelOrder()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ReqArtioxCancelOrder()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ReqArtioxSendOrder
		{
			public Cookie cookie
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sid
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string client_ip
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int[] pair_id
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string order_type
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float amount
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float price
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ReqArtioxSendOrder()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ReqArtioxSendOrder()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ResArtioxSendOrder
		{
			public int code
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool is_okay
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string type
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string symbol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float amount
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ResArtioxSendOrder()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ResArtioxSendOrder()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ResArtioxCancelOrder
		{
			public int code
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool is_okay
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ResArtioxCancelOrder()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ResArtioxCancelOrder()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ResArtioxLogin
		{
			public int code
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool is_okay
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string session_key
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool logged_in
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public Cookie cookie
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ResArtioxLogin()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ResArtioxLogin()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class Cookie
		{
			public string sessionKey
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool loggedIn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Cookie()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Cookie()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ResArtioxUserService
		{
			public int id
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string email
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public Art_Product_List[] art_product_list
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public Currency_List[] currency_list
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public Pair_List[] pair_list
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool account_verified
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool kyc_verified
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool second_level_kyc_verified
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string second_level_kyc_status
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool two_factor_auth
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public long creation_time
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int account_level
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float daily_deposit_limit
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float daily_withdrawal_limit
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float monthly_deposit_limit
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float monthly_withdrawal_limit
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string deposit_reference_code
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool open_tooltip
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool vip
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ResArtioxUserService()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ResArtioxUserService()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ResArtioxOrder
		{
			public int id
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object order_to_cancel
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int user_id
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int[] pair_id
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string kind
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string type
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool commission_free
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float amount
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float init_amount
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float price
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float percent
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string status
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public long creation_time
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ResArtioxOrder()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ResArtioxOrder()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ResArtioxTrade
		{
			public int id
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int[] pair_id
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int buyer_id
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int seller_id
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int buy_order_id
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int sell_order_id
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float amount
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float price
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string type
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public long creation_time
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string side
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ResArtioxTrade()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ResArtioxTrade()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class Art_Product_List
		{
			public int art_product_id
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float available_amount
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float total_amount
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string address
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Art_Product_List()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Art_Product_List()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class Currency_List
		{
			public int currency_id
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float available_amount
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float total_amount
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string address
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Currency_List()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Currency_List()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class Pair_List
		{
			public int[] pair_id
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool is_favorite
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Pair_List()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Pair_List()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class Artiox_Products
		{
			public int id
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string name
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string symbol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float value
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string value_type
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float pre_sale_supply_ratio
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float pre_sale_circulating_supply
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float pre_sale_supply_stock
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float public_sale_supply_ratio
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float public_sale_circulating_supply
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float public_sale_supply_stock
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float circulating_supply_ratio
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float circulating_supply
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float total_supply
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float right_to_own_ratio
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string contract_address
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public long creation_time
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string[] color
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Artiox_Products()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Artiox_Products()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ResArtioxBlance
		{
			public long creation_time
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double total_balance
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ResArtioxBlance()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ResArtioxBlance()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ResArtioxTradeItem
		{
			public int id
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int[] pair_id
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int buyer_id
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int seller_id
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int buy_order_id
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int sell_order_id
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float amount
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float price
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string type
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public long creation_time
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ResArtioxTradeItem()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ResArtioxTradeItem()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ReqArtioxOrderBook
		{
			public int[] pair_id
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int limit
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ReqArtioxOrderBook()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ReqArtioxOrderBook()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ResArtioxOrderBook
		{
			public float amount
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float price
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string type
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ResArtioxOrderBook()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ResArtioxOrderBook()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ReqArtioxChart
		{
			public int[] pair_id
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string zoom_level
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int limit
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ReqArtioxChart()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ReqArtioxChart()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class Bar
		{
			public float time
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float open
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float close
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float high
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float low
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float volume
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Bar()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Bar()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public static string ArtioxApiURL;

		public static List<Artiox_Products> ProductList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string SendHttpRequestArtiox(AccountRecord accountX, string urlX, string requestX, bool logbool)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void FillArtioxProductsList(bool refresxBoolX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<ResArtioxOrderBook> getOrderBook(int[] pairX, int limitX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<ResArtioxOrderBook> getOrderDepthBook(int[] pairX, int limitX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<ResArtioxTradeItem> getOrderTradeHistory(int[] pairX, int limitX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<Bar> getOrderChartHistory(int[] pairX, string periyotX, int limitX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Artiox_Products getArtioxProductDetail(int idX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Artiox_Products getArtioxProductBySymbol(string symbolX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static DateTime ToDateTimeForEpochMSec(double microseconds)
		{
			return (DateTime)(object)null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string TranslateMessage(int codX, string messageX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Artiox()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Artiox()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			WP6RZJql8gZrNhVA9v.w65ov7siki();
			hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
			ArtioxApiURL = "";
			ProductList = new List<Artiox_Products>();
		}
	}

	[Serializable]
	public class SettingRecord
	{
		public int ClassVersion;

		public string Username;

		public int DefaultWindowImkb;

		public bool TopMost;

		public int WindowLeft;

		public int WindowTop;

		public int WindowWidth;

		public int WindowHeight;

		public string ActiveAccountName;

		public bool WarningGeneral;

		public bool PozKapat;

		public bool WarningReadyBuySell;

		public bool CloseBuySellWindow;

		public int RefreshPeriod;

		public int RequestTimeout;

		public string DefaultImkbOrderDuration;

		public string DefaultVipOrderDuration;

		public int DecimalImkbAmount;

		public int DecimalImkbCost;

		public bool BuySellTopMost;

		public bool BuySell2TotalVisible;

		public bool BuySell2LimitVisible;

		public bool BuySell2BuyableVisible;

		public bool BuySell2SellableVisible;

		public int MessageLeft;

		public int MessageTop;

		public int MessageWidth;

		public int MessageHeight;

		public bool MessageSound;

		public bool MessageAutoOpen;

		public string DefaultPriceString;

		public bool MessageLogEnabled;

		public int LogoutInterval;

		public string SellDefaultLot;

		public bool BinlikAyrac;

		public bool SifreParoladanOnce;

		public int WindowOpacity;

		public bool RobotBeep;

		public bool SistemErrorBool;

		public bool BuySellWindowLoadPositionBool;

		public int BuySellWindowLoadPositionLeft;

		public int BuySellWindowLoadPositionTop;

		public bool BistUyariReadBool;

		public bool Consolidated;

		public int ConsolidatedOrders;

		public int ConsolidatedBistKZ;

		public int VipPozTum;

		public bool RobotKorumaBool;

		public bool GrupUyariBool;

		public bool AksamSeansGonderBool;

		public bool LogTumBool;

		[NonSerialized]
		public bool BCDGroupAlertBool;

		public Color MainWindowBuyPositionBackColor;

		public Color MainWindowBuyPositionForeColor;

		public Color MainWindowSellPositionBackColor;

		public Color MainWindowSellPositionForeColor;

		public Color MainWindowBuyButtonBackColor;

		public Color MainWindowBuyButtonForeColor;

		public Color MainWindowSellButtonBackColor;

		public Color MainWindowSellButtonForeColor;

		public Color MainWindowCloseButtonBackColor;

		public Color MainWindowCloseButtonForeColor;

		public Color MainWindowGridColor;

		public Color MainWindowWaitingOrderBuyBackColor;

		public Color MainWindowWaitingOrderBuyForeColor;

		public Color MainWindowWaitingOrderSellBackColor;

		public Color MainWindowWaitingOrderSellForeColor;

		public Color MainWindowCancelledOrderBuyBackColor;

		public Color MainWindowCancelledOrderBuyForeColor;

		public Color MainWindowCancelledOrderSellBackColor;

		public Color MainWindowCancelledOrderSellForeColor;

		public Color MainWindowClosedOrderBuyBackColor;

		public Color MainWindowClosedOrderBuyForeColor;

		public Color MainWindowClosedOrderSellBackColor;

		public Color MainWindowClosedOrderSellForeColor;

		public Color BuyWindowHeaderBorderColor;

		public Color BuyWindowHeaderBackColor1;

		public Color BuyWindowHeaderBackColor2;

		public Color BuyWindowHeaderButtonPassiveColor;

		public Color BuyWindowHeaderButtonActiveColor;

		public Color BuyWindowHeaderTextForeColor;

		public Color BuyWindowHeaderMenuForeColor;

		public Color BuyWindowBodyBackColor;

		public Color BuyWindowBodyForeColor;

		public Color BuyWindowButtonBackColor;

		public Color BuyWindowButtonForeColor;

		public Color SellWindowHeaderBorderColor;

		public Color SellWindowHeaderBackColor1;

		public Color SellWindowHeaderBackColor2;

		public Color SellWindowHeaderButtonPassiveColor;

		public Color SellWindowHeaderButtonActiveColor;

		public Color SellWindowHeaderTextForeColor;

		public Color SellWindowHeaderMenuForeColor;

		public Color SellWindowBodyBackColor;

		public Color SellWindowBodyForeColor;

		public Color SellWindowButtonBackColor;

		public Color SellWindowButtonForeColor;

		public Color SellWindowAcigaHeaderBorderColor;

		public Color SellWindowAcigaHeaderBackColor1;

		public Color SellWindowAcigaHeaderBackColor2;

		public Color SellWindowAcigaBodyBackColor;

		public Color Window2HeaderBorderColor;

		public Color Window2HeaderBackColor1;

		public Color Window2HeaderBackColor2;

		public Color Window2HeaderButtonPassiveColor;

		public Color Window2HeaderButtonActiveColor;

		public Color Window2HeaderTextForeColor;

		public Color Window2HeaderMenuForeColor;

		public Color Window2LabelBackColor;

		public Color Window2LabelForeColor;

		public Color Window2BuyBackColor;

		public Color Window2BuyForeColor;

		public Color Window2SellBackColor;

		public Color Window2SellForeColor;

		public Dictionary<string, AccountRecord> AccountDictionary;

		public List<BuySellRecord> ImkbBuySellList;

		public Dictionary<string, double> SymbolDefaultLotDictionary;

		public Dictionary<string, double> WeightedImkbDictionary;

		public List<BuySellRecord> AlgoList;

		public List<string> RobotList;

		public Dictionary<string, double> RobotPositionDictionary;

		public Dictionary<string, RobotPositionClass> RobotPositionDictionaryExtended;

		public List<SistemMultiRecord> SistemMultiList;

		public List<BuySellRecord> MagnusOrderList;

		public List<BuySellRecord> MagnusCallBackList;

		public List<string> MagnusCallBackCancelList;

		public List<BuySellRecord> MagnusOrderType;

		public string KademeBistSure;

		public string KademeVipSure;

		public string KademeBistOrderType;

		public string KademeVipOrderType;

		public List<double> KademeLotList;

		public Dictionary<string, double> KademeLotDictionary;

		public bool KademeOnayBool;

		public int KademeRefreshPeriod;

		public Dictionary<string, double> KademeLotDictionary2;

		public byte KademeDefaultWindow;

		public List<int> HesapColWidthPozisyonBIST;

		public List<int> HesapColWidthBekleyenBIST;

		public List<int> HesapColWidthGerceklesenBIST;

		public List<int> HesapColWidthMaliyetBIST;

		public List<int> HesapColWidthHesapBIST;

		public List<int> HesapColWidthPozisyonVIOP;

		public List<int> HesapColWidthBekleyenVIOP;

		public List<int> HesapColWidthGerceklesenVIOP;

		public List<int> HesapColWidthMaliyetVIOP;

		public List<int> HesapColWidthHesapVIOP;

		public Font HesapFont;

		public int HesapWidth;

		public int HesapHeight;

		public bool Kademe1ToolbarVisible;

		public bool Kademe2ToolbarVisible;

		public bool Kademe1AutoCenter;

		public int Kademe1Count;

		public bool Kademe1KZHesapla;

		public Dictionary<string, decimal> GhostLotDictionary;

		public int LogCounter;

		public bool LogSifreleBool;

		public bool BuySell3KucukBool;

		public Color Kep2BaslikZeminRenk;

		public Color Kep2BaslikYaziRenk;

		public Color Kep2FiyatAlisZeminRenk;

		public Color Kep2FiyatAlisYaziRenk;

		public Color Kep2FiyatSatisZeminRenk;

		public Color Kep2FiyatSatisYaziRenk;

		public Color Kep2AlistaBekleyenZeminRenk;

		public Color Kep2AlistaBekleyenYaziRenk;

		public Color Kep2SatistaBekleyenZeminRenk;

		public Color Kep2SatistaBekleyenYaziRenk;

		public Color Kep2DerinlikDegisimZeminRenk;

		public Color Kep2DerinlikDegisimYaziRenk;

		public Color Kep2CizgiRenk;

		public Color Kep2AktifSatirAlisZeminRenk;

		public Color Kep2AktifSatirAlisYaziRenk;

		public Color Kep2AktifSatirSatisZeminRenk;

		public Color Kep2AktifSatirSatisYaziRenk;

		public bool Kep2AktifSatirRenkBool;

		public int DEPKademeSayisi;

		public bool DEPEmirleriGizle;

		public bool DEPDerinlikGizle;

		public bool DEPBilgiGizle;

		public int VipSeansTip;

		public bool VerticalScrollbarVisible;

		public bool ViopMevcutSeansBool;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SettingRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SettingRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class Portfoy
	{
		public List<ImkbPositionRecord> ImkbPositionList;

		public List<ImkbOrderRecord> ImkbOrderList;

		public List<ImkbStatementRecord> ImkbStatementList;

		public List<ImkbTransactionReport> ImkbTransactionReports;

		public Dictionary<string, string> ImkbSummaryDictionary;

		public Dictionary<string, string> ImkbCreditStatusDictionary;

		public Dictionary<string, string> ImkbEquitySummaryDictionary;

		public Dictionary<string, double> ImkbStockSellableDictionary;

		public Dictionary<string, double> ImkbStockLimitDictionary;

		public Dictionary<string, string> ImkbRiskDictionary;

		public List<CriptoBinanceAcoountSnapShotRrebord> CriptoBinanceAcoountSnapsotList;

		public List<CriptoOrderRecord> CriptoOrderList;

		public List<CriptoTradeRecord> CriptoTradeList;

		public List<CriptoPositionRecord> CriptoPositionList;

		public List<BalanceHistoryRecord> BalanceHistoryList;

		public BinanceFuture.ResponseClasses.AccountInformation CriptoFutureAccountInformation;

		public BinanceFuture.ResponseClasses.ExchangeInformation CriptoFutureExchangeInformation;

		public List<BinanceFuture.ResponseClasses.Leverage> CriptoFutureLeverageLimits;

		public List<BinanceFuture.ResponseClasses.Position> CriptoFuturePositions;

		public List<BinanceFuture.ResponseClasses.OpenOrder> CriptoFutureOpenOrders;

		public BinanceFuture.ResponseClasses.CurrentMultiAssetMode CriptoFutureCurrentMultiAssetMode;

		public List<BinanceFuture.ResponseClasses.TradeHistory> CriptoFutureTradeHistory;

		public List<BinanceFuture.ResponseClasses.OrderHistory> CriptoFutureOrderHistory;

		public List<BinanceFuture.ResponseClasses.TransactionHistory> CriptoFutureTransactionHistory;

		public List<BinanceFuture.ResponseClasses.Asset> CriptoFutureAssetList;

		public List<IcrypexFuture.ResponseClasses.Assets> IcrypexFutureeAssetList;

		public List<IcrypexFuture.ResponseClasses.OpenOrder> IcrypexFutureOpenOrders;

		public double ImkbLimit;

		public double ImkbKrediDahilLimit;

		public double ImkbOverall;

		public double ImkbCariBakiye;

		public double ImkbKrediRiskBakiyesi;

		public double ImkbKrediBorcu;

		public double DovizBakiye;

		public double ImkbOncekiBakiye;

		public double ImkbSonBakiye;

		public double ImkbBakiyeFarkNet;

		public double ImkbBakiyeFarkYuzde;

		public List<VipPositionRecord> VipPositionList;

		public List<VipOrderRecord> VipOrderList;

		public List<VipOrderRecord> VipGerceklesenList;

		public List<VipStatementRecord> VipStatementList;

		public Dictionary<string, string> VipCollateralDictionary;

		public Dictionary<string, string> VipKZRaporSummaryDictionary;

		public List<VipProfitRecord> VipProfitList;

		public List<VipKZRaporRecord> VipKZRaporList;

		public List<VipTransactionReport> VipTransactionReports;

		public Dictionary<string, string> VipTransactionReportsSummaryDict;

		public volatile string VipTeyidString;

		public volatile string VipAcikString;

		public volatile string VipGayriString;

		public List<FonIslemRecord> FonIslemList;

		public List<FonPositionRecord> FonPositionList;

		public Dictionary<string, string> FonKurucuDict;

		public List<FonTanimRecord> FonTanimList;

		public string ReturnMessageStr;

		public List<VarlikRecord> VarlikList;

		public double ViopTeminatToplam;

		public double ViopTeminatBaslangic;

		public double ViopTeminatSurdurme;

		public double ViopTeminatKullanilabilir;

		public double ViopTeminatCekilebilir;

		public double ViopTeminatCagri;

		public double ViopNetMaliyet;

		public double ViopOpsiyonPrimiNet;

		public double ViopFifoMaliyet;

		public double ToplamTeminat;

		public double GayriNakdiTeminat;

		public double MaksimumPortfoyDegerLimit;

		public double KullanilanPortfoyDegeri;

		public double StopOutRiskOrani;

		public double BaslangictTakas;

		public double Baslangict;

		public double ViopOpsiyonPrimToplam;

		public double FifoMaliyet;

		public double ToplamFifoMaliyet;

		public double NetMaliyet;

		public double ToplamNetMaliyet;

		public double ViopMaxEmirFuture;

		public double ViopMaxEmirOpsion;

		public double ViopPozlimit;

		public double ViopNakitTeminat;

		public double ViopDigerTeminat;

		public double ViopOpsiyonPrim;

		public double ViopExercieTeminat;

		public double ViopScenerioTeminat;

		public double ViopPozisyonTeminat;

		public double ViopProfitLoss;

		public double ViopInterspreadTeminat;

		public double ViopSpanKontrolOran;

		public double ViopRiskOranı;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Portfoy()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Portfoy()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class TebReqClass
	{
		public static bool Test;

		public TebReqInput[] Inputs
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string Token
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public int VersionNo
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string TransactionId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string Password
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string UserName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string ServiceName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetUsername()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetPassword()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TebReqClass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TebReqClass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class TebReqInput
	{
		public string Key
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public object Value
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TebReqInput()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TebReqInput()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class TebKeyValue
	{
		public string Key
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string Value
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TebKeyValue()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TebKeyValue()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class TebHesapClass
	{
		public int CevapKodu
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string CevapMesaj
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public int MusteriNo
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public int EkNo
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string Urun
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string Menkul
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public float Stok
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public float Blokaj
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public float IslemStogu
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public float Maliyet
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public float Fiyat
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public float Tutar
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string Degisim
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string KarZarar
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string KarZararYuzde
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string Renk
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string PozisyonBuyuklugu
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string UzlasmaFiyati
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TebHesapClass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TebHesapClass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[DataContract]
	public class TebOrderclass
	{
		[DataMember(IsRequired = false)]
		public int? CevapKodu
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public string CevapMesaj
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public DateTime? Tarih
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public string Hisse
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public string AlisSatis
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public string Adet
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public decimal? Fiyat
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public string EmirTuru
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public string EmirTipi
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public string EmirGecerlilik
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public string EmirId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public int? Status
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public int? UpdateNum
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public decimal? GerceklesmeFiyati
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public string BekleyenAdet
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public int? MidPoint
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public int? Iceberg
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public string GorunenAdet
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public string Hesap
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public decimal? Tutar
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public string Referans
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public string Aciklama
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public string InsertTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public string UpdateTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public int? SiraNo
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public string TalimatId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public int? IptalEklemeYapilabilir
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public string OrjAnaEmirReferans
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public string Emir
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public int? MaxZincirSiraNo
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(IsRequired = false)]
		public int? Islem
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public DateTime? SiralamZaman
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TebOrderclass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TebOrderclass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class TebExtreResponseClass
	{
		public int CevapKodu
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string CevapMesaj
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string Veri
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TebExtreResponseClass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TebExtreResponseClass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class TebHisseIslemLimitleriHavuz
	{
		public int CevapKodu
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string CevapMesaj
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public int MusteriNo
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public decimal? A1IslemLimiti
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public decimal? A2IslemLimiti
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public decimal? A3IslemLimiti
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public decimal? A4IslemLimiti
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public decimal? BIslemLimiti
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public decimal? CDIslemLimiti
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public decimal? NakitIslemLimiti
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public decimal? AcigaSatisIslemLimiti
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public decimal? KrediRasyo
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public decimal? KrediLimiti
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public decimal? KullanilabilirKrediLimiti
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public decimal? Overall
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public decimal? ToplamAlis
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public decimal? ToplamSatis
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TebHisseIslemLimitleriHavuz()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TebHisseIslemLimitleriHavuz()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class TebHisseNakitHareketleriClass
	{
		public int CevapKodu
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string CevapMesaj
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string HisseNakitHareketleri
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public decimal? T0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public decimal? T1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public decimal? T2
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TebHisseNakitHareketleriClass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TebHisseNakitHareketleriClass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class TebOrderResultClass
	{
		public int CevapKodu
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string CevapMesaj
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TebOrderResultClass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TebOrderResultClass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class TebOrderCancelorEditResultClass
	{
		public int CevapKodu
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string CevapMesaj
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public int BlokajId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public float BlokajTutar
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public int TarihliEmir
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string TarihliEmirMesaj
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TebOrderCancelorEditResultClass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TebOrderCancelorEditResultClass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class IsYatırım
	{
		public class ReqIsYatirimLogin
		{
			public string username
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string password
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string loginType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string verificationType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string appCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string appPassword
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string key
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sessionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ReqIsYatirimLogin()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ReqIsYatirimLogin()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ReqEquitySendOrder
		{
			public string appCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string appPassword
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string accountId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string clOrdId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string instrumentSymbol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string uniqueSymbol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string instrumentType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double qty
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double price
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sideId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool closeShortSell
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string orderTypeId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string timeInForceId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string token
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string tokenVersion
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string marketSegmentAlert
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double maxFloor
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ReqEquitySendOrder()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ReqEquitySendOrder()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ReqFutOptSendOrder
		{
			public string appCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string appPassword
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string accountId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string clOrdId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string instrumentSymbol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double qty
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double price
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sideId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string orderTypeId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string timeInForceId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string token
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string tokenVersion
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string tradingSessionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string endDate
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ReqFutOptSendOrder()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ReqFutOptSendOrder()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ReqFutOptTriggerSendOrder
		{
			public string appCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string appPassword
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string accountId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string clOrdId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string instrumentSymbol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double qty
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double price
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sideId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string orderTypeId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string timeInForceId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string token
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string tokenVersion
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string endDate
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool triggerOrder
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string triggerTypeId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string triggerPriceTypeId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string triggerPriceDirectionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string triggerSymbol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string triggerPrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string tradingSessionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ReqFutOptTriggerSendOrder()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ReqFutOptTriggerSendOrder()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ReqEquityChainSendOrder
		{
			public string accountId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string clOrdId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string instrumentSymbol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string instrumentType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double qty
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double price
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sideId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool closeShortSell
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string orderTypeId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string timeInForceId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string token
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public long tokenVersion
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool chainOrder
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string marketSegmentAlert
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string parentOrderId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ReqEquityChainSendOrder()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ReqEquityChainSendOrder()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ResEquityOrder
		{
			public bool ok
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string transactionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string value
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ResEquityOrder()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ResEquityOrder()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class LoginRes
		{
			public bool ok
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string transactionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public Value value
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public LoginRes()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static LoginRes()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class Value
		{
			public string sessionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string bsSessionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string verificationType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object phoneNumber
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string token
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string tokenVersion
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Value()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Value()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class UserInfoBasic
		{
			public bool ok
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string transactionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public UserInfoBasicValue value
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public UserInfoBasic()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static UserInfoBasic()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class UserInfoBasicValue
		{
			public string username
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string personName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string email
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public UserInfoBasicValue()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static UserInfoBasicValue()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class UserInfoGetCustomerId
		{
			public bool ok
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string transactionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string value
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public UserInfoGetCustomerId()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static UserInfoGetCustomerId()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class EquityPosition
		{
			public bool ok
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string transactionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public EquityValue[] value
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public EquityPosition()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static EquityPosition()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class EquityValue
		{
			public string accountId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string depotCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string depotDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string uniqueSymbol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double balanceT
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double balanceT1
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double balanceT2
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double balanceT3
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double useableQty
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double avgPrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double lastPrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double currentAmount
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double currentAmountT2
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double profitLoss
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int assetCoef
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int sellCoef
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public long lastChange
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double dpProfitLoss
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double dpAmount
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string dpPosKey
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string equitySymbol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string equityType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public EquityValue()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static EquityValue()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FutOpt
		{
			public bool ok
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string transactionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public FutOptValue[] value
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FutOpt()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FutOpt()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FutOptValue
		{
			public string accountId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string depotCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string depotDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string uniqueSymbol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float balanceT
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float balanceT1
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float balanceT2
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float balanceT3
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float useableQty
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float intradayCost
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float lastPrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float currentAmount
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float currentAmountT2
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float profitLoss
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int assetCoef
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int sellCoef
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public long lastChange
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float dpProfitLoss
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float dpAmount
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string dpPosKey
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FutOptValue()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FutOptValue()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class EquityList
		{
			public bool ok
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string transactionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public EquityListValue[] value
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public EquityList()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static EquityList()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class EquityListValue
		{
			public int instrumentId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string symbol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string name
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string type
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string group
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string isinCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float minPrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float maxPrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public EquityListPricesteplist[] priceStepList
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public EquityListValue()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static EquityListValue()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class EquityListPricesteplist
		{
			public float minPx
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float maxPx
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float tickSize
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public EquityListPricesteplist()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static EquityListPricesteplist()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class HisseSummary
		{
			public bool ok
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string transactionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public HisseSummaryValue value
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public HisseSummary()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static HisseSummary()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class HisseSummaryValue
		{
			public Accounttotals accountTotals
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public Cashpositionlist[] cashPositionList
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public HisseSummaryValue()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static HisseSummaryValue()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class Accounttotals
		{
			public double totalPortfolioValue
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double fonPayAlimSatim
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double fon_PayStokTransferValue
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double onaylanmayan_Kredi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double aciga_Satista_Kullanilan
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double currencyValueEUR
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double currencyValueUSD
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double creditInterest
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double dividendIncome
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double usedCredit
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double priorityRight
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double creditLimit
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Accounttotals()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Accounttotals()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class Cashpositionlist
		{
			public int state
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string symbol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double todaysValue
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double price
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double percentage
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string stateDescr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double amtT2
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double amtT3
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double amt
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double amtT1
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double amtNet
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Cashpositionlist()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Cashpositionlist()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class HisseSummary2
		{
			public bool ok
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string transactionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public HisseSummary2Value value
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public HisseSummary2()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static HisseSummary2()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class HisseSummary2Value
		{
			public string accountId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double netAssetBuyLimit
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double openTradeLimit
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double availablecreditlimit
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double accountshortSellLimit
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public HisseSummary2Value()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static HisseSummary2Value()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class Summary
		{
			public bool ok
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string transactionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public SummaryValue value
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Summary()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Summary()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class SummaryValue
		{
			public string accountId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double cashCollateral
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double otherCollateral
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double longOptionPremium
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double exerciseCollateral
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double scenerioCollateral
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double positionCollateral
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double profitLoss
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double interSpreadCollateral
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double spanControlRatio
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double drawableCollateral
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double usableCollateral
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double requiredCollateral
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double accountRiskRatio
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double maintanenceCollateral
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double requiredCollateralTakasbankStart
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public SummaryValue()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static SummaryValue()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class Logout
		{
			public bool ok
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string transactionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool value
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Logout()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Logout()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class AccountsList
		{
			public bool ok
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string transactionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public Accounts[] value
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public AccountsList()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static AccountsList()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class Accounts
		{
			public string accountId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int customerId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string accountName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string afkCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool privateAccount
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int accountTypeId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string complianceScore
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string legitimacyScore
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Accounts()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Accounts()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class AccountSummaryCash
		{
			public bool ok
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string transactionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public AccountSummaryCashValue value
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public AccountSummaryCash()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static AccountSummaryCash()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class AccountSummaryCashValue
		{
			public Accounttotalcash[] accountTotals
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public Accountcashposition[] accountCashPositions
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public AccountSummaryCashValue()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static AccountSummaryCashValue()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class Accounttotalcash
		{
			public string accountId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float swapEquityRatio
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float totalEquityValue
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float totalAmountInAcctCcy
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float totalEquityValueT2
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float totalPortfolioValue
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object dividendIncome
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public long lastChange
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Accounttotalcash()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Accounttotalcash()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class Accountcashposition
		{
			public string accountId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int secId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string depotCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string depotDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string uniqueSymbol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float balanceT
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float balanceT1
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float balanceT2
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float balanceT3
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float useableQty
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float avgPrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float lastPrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float currentAmount
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float currentAmountT2
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object profitLoss
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int assetCoef
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int sellCoef
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public long lastChange
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float dpProfitLoss
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float dpAmount
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string dpPosKey
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Accountcashposition()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Accountcashposition()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class AccountSummaryCredit
		{
			public bool ok
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string transactionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public AccountSummaryCreditValue[] value
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public AccountSummaryCredit()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static AccountSummaryCredit()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class AccountSummaryCreditValue
		{
			public string accountId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int secId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string depotCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string depotDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string uniqueSymbol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float balanceT
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float balanceT1
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float balanceT2
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float balanceT3
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float useableQty
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float avgPrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float lastPrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float currentAmount
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float currentAmountT2
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object profitLoss
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int assetCoef
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int sellCoef
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public long lastChange
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float dpProfitLoss
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float dpAmount
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string dpPosKey
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float usedCredit
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float creditInterest
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public AccountSummaryCreditValue()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static AccountSummaryCreditValue()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class PasswordChangeRes
		{
			public bool ok
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string transactionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string value
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public PasswordChangeRes()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static PasswordChangeRes()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class PasswordChangeReq
		{
			public string oldPassword
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string newPassword
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public PasswordChangeReq()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static PasswordChangeReq()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class EquityOrder
		{
			public bool ok
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string transactionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public EquityOrderValue[] value
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public EquityOrder()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static EquityOrder()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class EquityOrderValue
		{
			public string orderId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string clOrdId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string origClOrdId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string accountId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string instrumentId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string instrumentSymbol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string instrumentType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string orderTypeId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string orderTypeDescTr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string orderTypeDescEn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string timeInForceId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string timeInForceDescTr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string timeInForceDesEn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sideId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sideDescTr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sideDescEn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string orderStatusId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string orderStatusDescTr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string orderStatusDescEn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string orderReference
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double price
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double qty
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double avgPrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double remainingQty
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double realizedQty
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double realizedAmt
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double maxFloor
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string pendingClOrdId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float pendingPrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float pendingQty
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string pendingTimeInForceId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public long valueDate
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string valueDateStr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public long createdDate
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string createdDateStr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string createdByName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public long endDate
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string endDateStr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string description
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public long lastUpdateTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string lastUpdateTimeStr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public long lastRealizeTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string lastRealizeTimeStr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string lastUpdateByName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool chainOrder
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string parentOrderId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool triggerOrder
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string triggerTypeId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object triggerTypeDescTr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object triggerTypeDescEn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string triggerPriceTypeId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object triggerPriceTypeDescTr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object triggerPriceTypeDescEn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string triggerPriceDirectionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object triggerPriceDirectionDescTr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object triggerPriceDirectionDescEn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string triggerSymbol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double triggerPrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool triggerWorking
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool cancelable
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool replaceable
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool chainable
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object tradingSessionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public EquityOrderValue()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static EquityOrderValue()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class EquityReplaceOrder
		{
			public object errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string transactionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool ok
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string orderId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string clOrdId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int qty
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string timeInForceId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float price
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string token
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public long tokenVersion
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public EquityReplaceOrder()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static EquityReplaceOrder()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class EquityCancelOrder
		{
			public string orderId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string clOrdId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string token
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public long tokenVersion
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public EquityCancelOrder()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static EquityCancelOrder()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FutOptOrder
		{
			public bool ok
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string transactionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public FutOptOrderValue[] value
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FutOptOrder()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FutOptOrder()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FutOptOrderValue
		{
			public string orderId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string clOrdId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string origClOrdId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string accountId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string instrumentId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string instrumentSymbol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string instrumentType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string orderTypeId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string orderTypeDescTr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string orderTypeDescEn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string timeInForceId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string timeInForceDescTr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string timeInForceDesEn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sideId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sideDescTr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sideDescEn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string orderStatusId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string orderStatusDescTr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string orderStatusDescEn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string orderReference
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float price
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float qty
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float avgPrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float remainingQty
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float realizedQty
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float realizedAmt
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float maxFloor
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string pendingClOrdId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float pendingPrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float pendingQty
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string pendingTimeInForceId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public long valueDate
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string valueDateStr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public long createdDate
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string createdDateStr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string createdByName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public long endDate
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string endDateStr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string description
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public long lastUpdateTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string lastUpdateTimeStr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public long lastRealizeTime
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string lastRealizeTimeStr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string lastUpdateByName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool chainOrder
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string parentOrderId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool triggerOrder
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string triggerTypeId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object triggerTypeDescTr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object triggerTypeDescEn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string triggerPriceTypeId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object triggerPriceTypeDescTr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object triggerPriceTypeDescEn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string triggerPriceDirectionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object triggerPriceDirectionDescTr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object triggerPriceDirectionDescEn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string triggerSymbol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float triggerPrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool triggerWorking
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool cancelable
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool replaceable
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool chainable
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string tradingSessionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FutOptOrderValue()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FutOptOrderValue()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FutOptReplaceOrder
		{
			public object errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string transactionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool ok
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string orderId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string clOrdId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double qty
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string timeInForceId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double price
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string token
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public long tokenVersion
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string endDate
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FutOptReplaceOrder()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FutOptReplaceOrder()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FutOptCancelOrder
		{
			public string orderId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string clOrdId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string token
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public long tokenVersion
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FutOptCancelOrder()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FutOptCancelOrder()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FonPosition
		{
			public bool ok
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object errorDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string transactionId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public FonPositionValue[] value
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FonPosition()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FonPosition()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FonPositionValue
		{
			public string accountId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int secId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string depotCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string depotDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string uniqueSymbol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float balanceT
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float balanceT1
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float balanceT2
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float balanceT3
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float useableQty
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float avgPrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float lastPrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float currentAmount
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float currentAmountT2
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float profitLoss
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int assetCoef
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int sellCoef
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public long lastChange
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float dpProfitLoss
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float dpAmount
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string dpPosKey
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string fundName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FonPositionValue()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FonPositionValue()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string SendHttpFirstLoginRequestIsYatirim(AccountRecord accountX, string urlX, string requestX, bool logbool)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string SendHttpGetRequestIsYatirim(AccountRecord accountX, string urlX, string requestX, bool logbool)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string SendHttpPostRequestIsYatirim(AccountRecord accountX, string urlX, string requestX, bool logbool)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ByteToStringIsYatSignature(byte[] buff)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void UserManagementBasiInfo(AccountRecord accountX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void UserManagementGetCustomerId(AccountRecord accountX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool GetIsYatirimSessionControl(string response)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IsYatırım()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static IsYatırım()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public static class butonMagnusControl
	{
		public static int MagnustanGidenEmir;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static butonMagnusControl()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class Optimus
	{
		public class ErrorResponse
		{
			public object Data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool Success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string Message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int StatusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ErrorResponse()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ErrorResponse()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class Login1
		{
			public string password
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string username
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string loginBySMS
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Login1()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Login1()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class Login2
		{
			public int username
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string password
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string otpCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string loginBySMS
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Login2()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Login2()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class LoginSifreUpdate
		{
			public string data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public LoginSifreUpdate()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static LoginSifreUpdate()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ZorunluSifreReq
		{
			public string username
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string password
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string otpCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string passwordChangeToken
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string newPassword
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ZorunluSifreReq()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ZorunluSifreReq()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ZorunluSifreResponse
		{
			public ZorunluSifreResponseData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ZorunluSifreResponse()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ZorunluSifreResponse()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ZorunluSifreResponseData
		{
			public string accessToken
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int expiresIn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public ZorunluSifreResponseUserdata userData
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ZorunluSifreResponseData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ZorunluSifreResponseData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ZorunluSifreResponseUserdata
		{
			public string sicilNo
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string ad
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string soyad
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public DateTime sonGiris
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (DateTime)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int kalanGun
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ZorunluSifreResponseUserdata()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ZorunluSifreResponseUserdata()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class LoginResponse
		{
			public object data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public LoginResponse()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static LoginResponse()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class LoginResponseData
		{
			public string accessToken
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int expiresIn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public Userdata userData
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public LoginResponseData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static LoginResponseData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class Userdata
		{
			public string sicilNo
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string ad
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string soyad
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public DateTime sonGiris
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (DateTime)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int kalanGun
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Userdata()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Userdata()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class SmsYenidenGonderimSure
		{
			public int data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public SmsYenidenGonderimSure()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static SmsYenidenGonderimSure()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class SifreKalanSure
		{
			public Data data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public SifreKalanSure()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static SifreKalanSure()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class Data
		{
			public int kalanGun
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Data()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Data()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class HesapListesi
		{
			public HesapListesiData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public HesapListesi()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static HesapListesi()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class HesapListesiData
		{
			public string ADI
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string SOYADI
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int VirmanliSatisButonu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int AltPazarRBF
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int OTOMATIK_ALIM_SATIM_SZL
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int VERI_DAGITIM_OZEL_EKRAN
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int ReturnValue
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string errorMessage
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int errorUniqueCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public HesapListesiData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static HesapListesiData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class HissePortfolioReq
		{
			public int anlikBakiye
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public HissePortfolioReq()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static HissePortfolioReq()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class HissePortfolioResponse
		{
			public HissePortfolioData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public HissePortfolioResponse()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static HissePortfolioResponse()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class HissePortfolioData
		{
			public List[] list
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public HissePortfolioData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static HissePortfolioData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class List
		{
			public string tip
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double miktar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float kapanis
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double overall_Miktar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string maliyet
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string menkulKodu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float tstok
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float t1stok
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float tutar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float ttutar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float t1tutar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float kar_zarar_yuzde
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public List()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static List()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class EksrteReq
		{
			public string ilkTarih
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sonTarih
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public EksrteReq()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static EksrteReq()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class EkstreResponse
		{
			public EkstreData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public EkstreResponse()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static EkstreResponse()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class EkstreData
		{
			public EkstreList[] list
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public EkstreData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static EkstreData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class EkstreList
		{
			public DateTime valorTarihi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (DateTime)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string aciklama
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float borc
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float alacak
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float tutar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public EkstreList()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static EkstreList()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class AuthPasswordRemainingTimeResponse
		{
			public bool isSuccess
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool hasData
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string[] messages
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public AuthPasswordRemainingTimeResponseData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int? dataCount
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string[] errors
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int? errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public AuthPasswordRemainingTimeResponse()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static AuthPasswordRemainingTimeResponse()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class AuthPasswordRemainingTimeResponseData
		{
			public int kalanGun
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public AuthPasswordRemainingTimeResponseData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static AuthPasswordRemainingTimeResponseData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class AccountInformationResponse
		{
			public AccountInformationResponseData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public AccountInformationResponse()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static AccountInformationResponse()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class AccountInformationResponseData
		{
			public AccountInformationResponseIslem[] islem
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public AccountInformationResponseData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static AccountInformationResponseData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class AccountInformationResponseIslem
		{
			public string islemKodu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string bakiye
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string aciklama
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public AccountInformationResponseIslem()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static AccountInformationResponseIslem()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class TwoDateTransactionReq
		{
			public string hisse
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string grupKodu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string hisseGrupKodu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string baslangicTarihi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string bitisTarihi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public TwoDateTransactionReq()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static TwoDateTransactionReq()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class TwoDateTransactionResponse
		{
			public TwoDateTransactionResponseData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public TwoDateTransactionResponse()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static TwoDateTransactionResponse()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class TwoDateTransactionResponseData
		{
			public TwoDateTransactionResponseDetay[] detay
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public TwoDateTransactionResponseOutput[] output
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public TwoDateTransactionResponseData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static TwoDateTransactionResponseData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class TwoDateTransactionResponseDetay
		{
			public int hesap
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public DateTime tarih
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (DateTime)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string hisse
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string aS
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double fiyat
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float alisMiktar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float satisMiktar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double alisTutar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double satisTutar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float komOrn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double komisyon
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double bsmv
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public TwoDateTransactionResponseDetay()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static TwoDateTransactionResponseDetay()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class TwoDateTransactionResponseOutput
		{
			public int returnValue
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public TwoDateTransactionResponseOutput()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static TwoDateTransactionResponseOutput()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class StockImproveReq
		{
			public decimal eskiMiktar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (decimal)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public decimal eskiFiyat
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (decimal)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public decimal yeniMiktar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (decimal)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public decimal? yeniFiyat
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public decimal? gorunenMiktar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string @ref
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string imkbEmirNo
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sureTarih
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public StockImproveReq()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static StockImproveReq()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class StockImproveResponse
		{
			public StockImproveResponseData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public StockImproveResponse()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static StockImproveResponse()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class StockImproveResponseData
		{
			public string cal
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string errorMessage
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int errorUniqueCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public StockImproveResponseData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static StockImproveResponseData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class AccountDailyTransaction
		{
			public int gerceklesenOzet
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public AccountDailyTransaction()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static AccountDailyTransaction()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class AccountDailyTransactionResponse
		{
			public AccountDailyTransactionData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public AccountDailyTransactionResponse()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static AccountDailyTransactionResponse()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class AccountDailyTransactionData
		{
			public AccountDailyTransactionHgi[] hgi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public AccountDailyTransactionData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static AccountDailyTransactionData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class AccountDailyTransactionHgi
		{
			public string hesapNo
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string referans
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string hisseAdi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string alSat
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float adet
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float kalan
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double fiyat
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float tutar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string valor
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string islemDurumu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string emirGecerlilikSuresi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string editOpsiyonlari
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int lotAdet
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string islemTuru
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string saat
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string saat2
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string imkbEmirNo
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int orjSysId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float gerceklesenMiktar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public DateTime emirGecerlilikTarihi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (DateTime)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string emirTipi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float? gorunenMiktar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int? zincirVar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int? zincirId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int? zincirUstId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public DateTime? emirGirisTarihi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public AccountDailyTransactionHgi()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static AccountDailyTransactionHgi()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class StockCancelledOrder
		{
			public StockCancelledOrderData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public StockCancelledOrder()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static StockCancelledOrder()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class StockCancelledOrderData
		{
			public StockCancelledOrderList[] list
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public StockCancelledOrderData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static StockCancelledOrderData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class StockCancelledOrderList
		{
			public string menkul
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string islem
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float miktar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float fiyat
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float tutar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string aciklama
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string islemeZamani
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int sysId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int musteri
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sureNew
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string emirTipiNew
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float maxFloor
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public StockCancelledOrderList()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static StockCancelledOrderList()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class StockTrading
		{
			public string hisse
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string grupKodu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string komut
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public decimal miktar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (decimal)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public decimal fiyat
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (decimal)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string emirTipi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sureTarih
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string orderType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public decimal gorunenMiktar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (decimal)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int altPazarRbf
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string smsGonderimi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string imkbIslemGrubu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public StockTrading()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static StockTrading()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class StockTrtadingResponse
		{
			public StockTrtadingResponseData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public StockTrtadingResponse()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static StockTrtadingResponse()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class StockTrtadingResponseData
		{
			public string hsr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string limitAciklama
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string errorMessage
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int errorUniqueCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public StockTrtadingResponseData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static StockTrtadingResponseData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ChainBuySellTSell
		{
			public string hisse
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string grupKodu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string @ref
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string orderType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public decimal miktar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (decimal)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public decimal fiyat
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (decimal)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string emirTipi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public decimal gorunenMiktar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (decimal)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int altPazarRbf
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object sureTarih
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string imkbEmirNo
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ChainBuySellTSell()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ChainBuySellTSell()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ChainBuySellTSellResponse
		{
			public ChainBuySellTSellResponseData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ChainBuySellTSellResponse()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ChainBuySellTSellResponse()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ChainBuySellTSellResponseData
		{
			public object hsr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string errorMessage
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int errorUniqueCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ChainBuySellTSellResponseData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ChainBuySellTSellResponseData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class RiskOnayReq
		{
			public string apYipPoipRbf
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public RiskOnayReq()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static RiskOnayReq()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class RiskOnayResponse
		{
			public RiskOnayResponseData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public RiskOnayResponse()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static RiskOnayResponse()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class RiskOnayResponseData
		{
			public int errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string errorMessage
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int errorUniqueCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public RiskOnayResponseData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static RiskOnayResponseData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class StockOrderDeleteReq
		{
			public string @ref
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public StockOrderDeleteReq()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static StockOrderDeleteReq()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class StockOrderDeleteResponse
		{
			public StockOrderDeleteResponseData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public StockOrderDeleteResponse()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static StockOrderDeleteResponse()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class StockOrderDeleteResponseData
		{
			public string cal
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string errorMessage
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int errorUniqueCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public StockOrderDeleteResponseData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static StockOrderDeleteResponseData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class MusteriHesapOzetiReq
		{
			public string tarih
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public MusteriHesapOzetiReq()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static MusteriHesapOzetiReq()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class MusteriHesapOzetiResponse
		{
			public MusteriHesapOzetiData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public MusteriHesapOzetiResponse()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static MusteriHesapOzetiResponse()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class MusteriHesapOzetiData
		{
			public Menkulkiymet[] menkulKiymet
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public Menkulkiymetturklirasi[] menkulKiymetTurkLirasi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public Toplamoverall[] toplamOverall
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public ViopPozisyon[] viopPozisyon
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public MusteriHesapOzetiData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static MusteriHesapOzetiData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class Menkulkiymet
		{
			public string aciklama
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int ana
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string tur
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float adet
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float t1Adet
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float t2Adet
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float kapanis
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float maliyet
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float tutar3
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string tradeKodu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Menkulkiymet()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Menkulkiymet()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class Menkulkiymetturklirasi
		{
			public string aciklama
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float adet
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float t1Adet
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int ana
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float t2Adet
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Menkulkiymetturklirasi()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Menkulkiymetturklirasi()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class Toplamoverall
		{
			public string aciklama
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float tBakiye
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float t1Bakiye
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float t2Bakiye
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string tip
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Toplamoverall()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Toplamoverall()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ViopPozisyon
		{
			public string sozlesmeKodu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string uzunKisa
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int pozisyonSayisi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float maliyet
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float kapanis
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float parasalTutar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float guniciKz
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ViopPozisyon()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ViopPozisyon()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class MusteriVarlikDegisimi
		{
			public MusteriVarlikDegisimiData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public MusteriVarlikDegisimi()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static MusteriVarlikDegisimi()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class MusteriVarlikDegisimiData
		{
			public MusteriVarlikDegisimiList[] list
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public MusteriVarlikDegisimiData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static MusteriVarlikDegisimiData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class MusteriVarlikDegisimiList
		{
			public DateTime bugunTarih
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (DateTime)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float bugunOverall
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public DateTime dunTarih
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (DateTime)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float dunOverall
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public MusteriVarlikDegisimiList()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static MusteriVarlikDegisimiList()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ViopOrderCancelReq
		{
			public string @ref
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string imkbEmirNo
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ViopOrderCancelReq()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ViopOrderCancelReq()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ViopOrderCancelResponse
		{
			public ViopOrderCancelResponseData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ViopOrderCancelResponse()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ViopOrderCancelResponse()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class ViopOrderCancelResponseData
		{
			public string cal
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string errorMessage
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int errorUniqueCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ViopOrderCancelResponseData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ViopOrderCancelResponseData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class VipAccountSummaryResponse
		{
			public VipAccountSummaryResponseData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VipAccountSummaryResponse()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static VipAccountSummaryResponse()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class VipAccountSummaryResponseData
		{
			public VipAccountSummaryResponseBvtm[] bvtm
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VipAccountSummaryResponseData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static VipAccountSummaryResponseData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class VipAccountSummaryResponseBvtm
		{
			public DateTime tarih
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (DateTime)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int hesap
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string teminatTipi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string riskDurumu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float nakitTeminatlar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float digerTeminatlar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float seanslikTeminat
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float baslangicTeminati
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float surdurmeTeminatiMarji
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float kalanTeminat
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float teminatTamamlamaCagrisiHesaplama
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float teminatTamamlamaCagrisiMiktari
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float cekilebilirTeminat
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string hesapDurumu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float karzarar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float pasifDahilGerekliBaslangic
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float kz_sonFiyat
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float primToplami
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float primToplamiBorc
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float primToplamiAlacak
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float cekilebilirTeminatPasifDahil
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float anlikkzmaliyet
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VipAccountSummaryResponseBvtm()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static VipAccountSummaryResponseBvtm()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class VipOrdersReq
		{
			public string _ref
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string gerceklesenDetay
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VipOrdersReq()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static VipOrdersReq()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class VipOrdersResponse
		{
			public VipOrdersResponseData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VipOrdersResponse()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static VipOrdersResponse()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class VipOrdersResponseData
		{
			public VipOrdersResponseArr[] emirler
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VipOrdersResponseData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static VipOrdersResponseData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class VipOrdersResponseArr
		{
			public int hesapNo
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int sysId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string emirDurum
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string hisseKodu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string emir
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float miktar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double fiyat
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float tutar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string durum
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string imkbEmirNo
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double gerceklesenMiktar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double gerceklesenOrtalama
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string seans
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public DateTime sonTarih
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (DateTime)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string emirTipiNew
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int orj_SysId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string triggerTypeDesc
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float triggerPrice
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string iptalAciklama
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string emirGirisAni
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float veriDagiticiMiktar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string tetikSozlesme
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string seansNew
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float orjinalTutar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string gerceklesmeSonZaman
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VipOrdersResponseArr()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static VipOrdersResponseArr()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class VipPositions
		{
			public VipPositionsData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VipPositions()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static VipPositions()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class VipPositionsData
		{
			public VipPositionsBvp[] bvps
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VipPositionsData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static VipPositionsData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class VipPositionsBvp
		{
			public string tarih
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int hesap
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string tip
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float karzarar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sozlesme
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int uzunpoztoplami
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int kisapoztoplami
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int acikpoztoplami
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int netpozisyon
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int acikpozisyondeger
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string hesapdurumu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float maliyet
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float kapanis
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float tutar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string doviztutar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float kzsonfiyat
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float gunicikzsonfiyat
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float anlikkzmaliyet
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float sonfiyatkzmaliyet
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float agirortmaliyet
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VipPositionsBvp()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static VipPositionsBvp()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class VipReportCashReq
		{
			public string basTarih
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string bitTarih
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VipReportCashReq()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static VipReportCashReq()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class VipReportCashResponse
		{
			public VipReportCashResponseData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VipReportCashResponse()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static VipReportCashResponse()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class VipReportCashResponseData
		{
			public VipReportCashResponseList[] list
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VipReportCashResponseData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static VipReportCashResponseData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class VipReportCashResponseList
		{
			public DateTime valorTarihi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (DateTime)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string aciklama
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float borc
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float alacak
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VipReportCashResponseList()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static VipReportCashResponseList()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class VipProfitLossReportReq
		{
			public string basTarih
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string bitTarih
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sozlesmeTuru
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VipProfitLossReportReq()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static VipProfitLossReportReq()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class VipProfitLossResponse
		{
			public VipProfitLossResponseData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VipProfitLossResponse()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static VipProfitLossResponse()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class VipProfitLossResponseData
		{
			public Vrd[] vrd
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public Vr[] vrs
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VipProfitLossResponseData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static VipProfitLossResponseData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class Vrd
		{
			public string aciklama
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public DateTime sonIslemGunu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (DateTime)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string kod
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float karzarar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int acikUzun
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int acikKisa
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string uzunKisa
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float kullanımFiyati
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string doviz
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Vrd()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Vrd()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class Vr
		{
			public string aciklama
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float tutar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Vr()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Vr()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class VipOrderImprovementReq
		{
			public string @ref
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string imkbEmirNo
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public decimal fiyat
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (decimal)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public decimal eskiFiyat
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (decimal)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int miktar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int eskiMiktar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int acikKapali
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sureTarih
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VipOrderImprovementReq()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static VipOrderImprovementReq()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class VipOrderImproveResponse
		{
			public VipOrderImroveData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VipOrderImproveResponse()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static VipOrderImproveResponse()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class VipOrderImroveData
		{
			public string cal
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string errorMessage
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int errorUniqueCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VipOrderImroveData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static VipOrderImroveData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class VipSendOrderReq
		{
			public string sozlesme
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string islem
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int miktar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public decimal fiyat
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (decimal)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string orderType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sureTarih
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public decimal gorunenMiktar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (decimal)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int tetikTipi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int tetikFiyat
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object tetikSozlesme
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int acikKapali
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string smsGonderimi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string aksamSeansi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VipSendOrderReq()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static VipSendOrderReq()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class VipSendOrderResponse
		{
			public VipSendOrderResponseDataData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VipSendOrderResponse()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static VipSendOrderResponse()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class VipSendOrderResponseDataData
		{
			public string hsr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string errorMessage
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int errorUniqueCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VipSendOrderResponseDataData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static VipSendOrderResponseDataData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class VipTransactionsReq
		{
			public string sozlesme
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string baslangicTarihi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string bitisTarihi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VipTransactionsReq()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static VipTransactionsReq()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class VipTransactionResponse
		{
			public VipTransactionResponseData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VipTransactionResponse()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static VipTransactionResponse()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class VipTransactionResponseData
		{
			public VipTransactionResponseVrd[] vrd
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VipTransactionResponseData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static VipTransactionResponseData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class VipTransactionResponseVrd
		{
			public int hesap
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public DateTime tarih
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (DateTime)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string saat
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int islem
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string sozlesme
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string pazar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string alisSatis
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double fiyat
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int miktar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float hacim
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string karsiUye
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string emirSaati
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string tip
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int seans
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int acikMiktar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int acikKomisyon
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double borsaPayi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double komisyon
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double bsmv
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public VipTransactionResponseVrd()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static VipTransactionResponseVrd()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FonAlSat
		{
			public FonAlSatData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FonAlSat()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FonAlSat()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FonAlSatData
		{
			public int MIKTAR
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float FIYAT
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float TUTAR
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string FON_UNVANI
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string FON_TIPI
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public DateTime TAKAS_TARIHI
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (DateTime)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float MUSTERI_NET_BAKIYE
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int LIKIT_SYS_NO
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string MIKTAR_TUTAR
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int HESAPLANAN_MIKTAR
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float HESAPLANAN_TUTAR
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int IHBAR_SYS_NO
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int FIYAT_MARJ_ORANI
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int ReturnValue
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string errorMessage
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int errorUniqueCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FonAlSatData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FonAlSatData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FonAlSatReq
		{
			public string fonId
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string fonIslem
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public decimal adet
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (decimal)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public decimal tutar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (decimal)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int kontrol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FonAlSatReq()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FonAlSatReq()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FonIptalResponse
		{
			public FonIptalResponseData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FonIptalResponse()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FonIptalResponse()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FonIptalResponseData
		{
			public int errorCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string errorMessage
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int errorUniqueCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FonIptalResponseData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FonIptalResponseData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class fonIptalReq
		{
			public int islemNo
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public fonIptalReq()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static fonIptalReq()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FonSatimList
		{
			public FonSatimListData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FonSatimList()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FonSatimList()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FonSatimListData
		{
			public FonSatimListList[] list
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FonSatimListData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FonSatimListData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FonSatimListList
		{
			public int menkulNo
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int bakiye
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string unvani
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float satisFiyat
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string imkbKodu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string tipi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int minPay
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float tutar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float maliyet
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float toplamMaliyet
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float karZarar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string islemBaslSaati
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string islemBitisSaati
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float fifoMaliyet
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float karZararFifo
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string satisIslemTercihi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int alisGunArtimi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int satisGunArtimi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string satimValorAtlatmaSaati
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FonSatimListList()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FonSatimListList()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FonAlimListesiReq
		{
			public int fonSahiplikFiltre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int tefaspFonTuru
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string kurucuUye
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FonAlimListesiReq()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FonAlimListesiReq()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FonAlimListesi
		{
			public FonAlimListesiData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FonAlimListesi()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FonAlimListesi()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FonAlimListesiData
		{
			public FonAlimListesiList[] list
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FonAlimListesiData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FonAlimListesiData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FonAlimListesiList
		{
			public int menkulNo
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string imkbKodu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string tipi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string unvani
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int minPay
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float alisFiyat
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float satisFiyat
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string islemTercihi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string alimValorAtlatmaSaati
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int alisGunArtimi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int satisGunArtimi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string islemBaslSaati
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string islemBitisSaati
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FonAlimListesiList()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FonAlimListesiList()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FonTipListesi
		{
			public FonTipListesiData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FonTipListesi()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FonTipListesi()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FonTipListesiData
		{
			public FonTipListesiList[] list
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FonTipListesiData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FonTipListesiData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FonTipListesiList
		{
			public int kod
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string aciklama
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FonTipListesiList()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FonTipListesiList()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FonKurucuListe
		{
			public FonKurucuListeData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FonKurucuListe()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FonKurucuListe()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FonKurucuListeData
		{
			public FonKurucuListeList[] list
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FonKurucuListeData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FonKurucuListeData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FonKurucuListeList
		{
			public string kod
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string aciklama
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FonKurucuListeList()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FonKurucuListeList()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FonTalepListesi
		{
			public FonTalepListesiData data
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public bool success
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return true;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public object message
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int statusCode
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FonTalepListesi()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FonTalepListesi()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FonTalepListesiData
		{
			public FonTalepListesiList[] list
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FonTalepListesiData()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FonTalepListesiData()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public class FonTalepListesiList
		{
			public string imkbKodu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string unvani
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int sysNo
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string emir
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float miktar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float fiyat
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float tutar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public DateTime valorTarihi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (DateTime)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string talepIptal
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int iptalEdilebilir
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string tefaspDurum
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string tefaspHataAciklama
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int menkulNo
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public int gercekesenMiktar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FonTalepListesiList()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FonTalepListesiList()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string SendHttpRequestOptimus(AccountRecord accountX, string urlX, string methodX, string requestX, bool logbool, BuySellRecord buysellX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Optimus()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Optimus()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class ViopRobotHesapClass
	{
		public List<VipPositionRecord> Pozisyonlar;

		public List<VipOrderRecord> GerceklesenEmirler;

		public List<VipOrderRecord> BekleyenEmirler;

		public double TeminatToplam;

		public double TeminatBaslangic;

		public double TeminatSurdurme;

		public double TeminatKullanilabilir;

		public double TeminatCekilebilir;

		public double TeminatCagri;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ViopRobotHesapClass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ViopRobotHesapClass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class BistRobotHesapClass
	{
		public List<ImkbPositionRecord> Pozisyonlar;

		public List<ImkbOrderRecord> GerceklesenEmirler;

		public List<ImkbOrderRecord> BekleyenEmirler;

		public double IslemLimit;

		public double Bakiye;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BistRobotHesapClass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static BistRobotHesapClass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class Token
	{
		public DateTime timestamp;

		public string nextToken;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Token()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Token()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class Request
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass60_0
		{
			public AccountRecord account;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _003C_003Ec__DisplayClass60_0()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void _003CLogin_003Eb__0()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static _003C_003Ec__DisplayClass60_0()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetRemoteIP_003Ed__42 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public AccountRecord account;

			private string _003Clocalip_003E5__1;

			private string _003Clocalport_003E5__2;

			private string _003Cremoteport_003E5__3;

			private string _003Cbroker_003E5__4;

			private string _003CBackOfficceImkb_003E5__5;

			private string _003CBackOfficceVip_003E5__6;

			private string _003CexternalIP_003E5__7;

			private bool _003CisYapiKredi_003E5__8;

			private bool _003ClocalIpFound_003E5__9;

			private string _003CfallbackMethodUsed_003E5__10;

			private string _003CsuccessLog_003E5__11;

			private IPHostEntry _003CipHostInfo_003E5__12;

			private IPAddress _003CipAddress_003E5__13;

			private Exception _003CdnsEx_003E5__14;

			private string _003CdnsError_003E5__15;

			private Exception _003CniEx_003E5__16;

			private string _003CniError_003E5__17;

			private string _003CfallbackError_003E5__18;

			private int _003Ci_003E5__19;

			private string _003Cadres_003E5__20;

			private string _003Cerrorline_003E5__21;

			private HttpClientHandler _003Chandler_003E5__22;

			private HttpClient _003Cclient_003E5__23;

			private HttpResponseMessage _003Cresponse_003E5__24;

			private HttpResponseMessage _003C_003Es__25;

			private string _003Cres_003E5__26;

			private string _003C_003Es__27;

			private WebClient _003Cwc_003E5__28;

			private Exception _003Cex_003E5__29;

			private string _003Cerrorline_003E5__30;

			private Exception _003Cerror_003E5__31;

			private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

			private TaskAwaiter<string> _003C_003Eu__2;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _003CGetRemoteIP_003Ed__42()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static _003CGetRemoteIP_003Ed__42()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		[CompilerGenerated]
		private sealed class _003CLogin_003Ed__60 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public string accountnameX;

			public string passwordX;

			public string parolaX;

			private _003C_003Ec__DisplayClass60_0 _003C_003E8__1;

			private string _003CloginErrorline_003E5__2;

			private string _003Ckurum_003E5__3;

			private string _003CsoftOtp_003E5__4;

			private string _003CbackOffice_003E5__5;

			private Thread _003Cthd1_003E5__6;

			private List<string>.Enumerator _003C_003Es__7;

			private string _003Citem_003E5__8;

			private StringBuilder _003Csbuilder_003E5__9;

			private string _003Cresponse_003E5__10;

			private string[] _003Clinearray_003E5__11;

			private string[] _003Cfieldarray_003E5__12;

			private int _003Ckalangun_003E5__13;

			private JavaScriptSerializer _003Cserializer_003E5__14;

			private string _003CreqStr_003E5__15;

			private string _003Cresponse_003E5__16;

			private Optimus.SifreKalanSure _003Cjsonobj_003E5__17;

			private int _003CkalanGun_003E5__18;

			private StringBuilder _003Csbuilder_003E5__19;

			private string _003Cresponse_003E5__20;

			private string[] _003Clinearray_003E5__21;

			private int _003Ci_003E5__22;

			private string _003Cfieldvalue_003E5__23;

			private string _003Cfieldcode_003E5__24;

			private string _003C_003Es__25;

			private int _003Ckalangun_003E5__26;

			private string _003C_003Es__27;

			private StringBuilder _003Csbuilder_003E5__28;

			private string _003Cresponse_003E5__29;

			private string[] _003Clinearray_003E5__30;

			private string _003Cpassword_003E5__31;

			private int _003Ci_003E5__32;

			private string _003Cfieldvalue_003E5__33;

			private string _003Cfieldcode_003E5__34;

			private string _003C_003Es__35;

			private StringBuilder _003Csbuilder_003E5__36;

			private string _003Cresponse_003E5__37;

			private string[] _003Clinearray_003E5__38;

			private int _003Ci_003E5__39;

			private string _003Cfieldvalue_003E5__40;

			private string _003Cfieldcode_003E5__41;

			private string _003C_003Es__42;

			private string _003Cpoststr_003E5__43;

			private string _003Cresponse_003E5__44;

			private string _003Cinfomessage_003E5__45;

			private string _003Cnexttoken_003E5__46;

			private XmlDocument _003Cxmldoc_003E5__47;

			private StringBuilder _003Csbuilder_003E5__48;

			private string _003Cerrmessage_003E5__49;

			private XmlNode _003Cnode1_003E5__50;

			private string _003Cerrormessage_003E5__51;

			private string _003Cresultmessage_003E5__52;

			private string _003Cerrormessage_003E5__53;

			private XmlNode _003Cnodeauth_003E5__54;

			private string _003CinvestmentCustomerNo_003E5__55;

			private string _003CnextToken_003E5__56;

			private string _003Cresultmessage_003E5__57;

			private string _003Cerrormessage_003E5__58;

			private XmlNode _003Cnodeauth_003E5__59;

			private string _003CinvestmentCustomerNo_003E5__60;

			private string _003CnextToken_003E5__61;

			private StringBuilder _003CauthBuilder_003E5__62;

			private string _003CauthResponse_003E5__63;

			private string _003CauthErrMessage_003E5__64;

			private StringBuilder _003CauthBuilder_003E5__65;

			private string _003CauthResponse_003E5__66;

			private string _003CauthErrMessage_003E5__67;

			private XmlNodeList _003Cnodes_003E5__68;

			private string _003Chesapkurum_003E5__69;

			private IEnumerator _003C_003Es__70;

			private XmlNode _003Cnode_003E5__71;

			private string _003Caccountno_003E5__72;

			private string _003Cowner_003E5__73;

			private string _003CKurumKontrolKey_003E5__74;

			private IEnumerator _003C_003Es__75;

			private XmlNode _003Cnode_003E5__76;

			private GtpContractDef.Record _003Ccontract_003E5__77;

			private string _003CKurumKontrolKey_003E5__78;

			private IEnumerator _003C_003Es__79;

			private XmlNode _003Cnode_003E5__80;

			private GtpContractDef.Record _003Ccontract_003E5__81;

			private StringBuilder _003Csbuilder_003E5__82;

			private string _003Cresponse_003E5__83;

			private string[] _003Clinearray_003E5__84;

			private int _003Ci_003E5__85;

			private string _003Cfieldvalue_003E5__86;

			private string _003Cfieldcode_003E5__87;

			private string _003C_003Es__88;

			private List<TebReqInput> _003Cintputlist_003E5__89;

			private string _003Cresult_003E5__90;

			private TebReqClass _003Cobj_003E5__91;

			private List<TebKeyValue> _003Cresultobj_003E5__92;

			private List<TebKeyValue>.Enumerator _003C_003Es__93;

			private TebKeyValue _003Cro_003E5__94;

			private List<TebHesapClass> _003Chesapobj_003E5__95;

			private int _003Ci_003E5__96;

			private string _003Ckey_003E5__97;

			private StringBuilder _003Csbuilder_003E5__98;

			private string _003Cresponse_003E5__99;

			private string[] _003Clinearray_003E5__100;

			private int _003Ci_003E5__101;

			private string _003Cfieldvalue_003E5__102;

			private string _003Cfieldcode_003E5__103;

			private string _003C_003Es__104;

			private StringBuilder _003Csbuilder_003E5__105;

			private string _003Cresponse_003E5__106;

			private string[] _003Clinearray_003E5__107;

			private int _003Ci_003E5__108;

			private string _003Cfieldvalue_003E5__109;

			private string _003Cfieldcode_003E5__110;

			private string _003C_003Es__111;

			private int _003Ci_003E5__112;

			private string _003Cfieldvalue_003E5__113;

			private string _003Cfieldcode_003E5__114;

			private string[] _003Csplitarray_003E5__115;

			private string _003C_003Es__116;

			private int _003Cj_003E5__117;

			private string _003CmsjIdstr_003E5__118;

			private string _003CmsjTextstr_003E5__119;

			private AkDuyuruOnayClass _003CakDuyuruObj_003E5__120;

			private StringBuilder _003Csbuilder_003E5__121;

			private XmlDocument _003Cxmldoc_003E5__122;

			private string _003Cresponse_003E5__123;

			private XmlNodeList _003Cnodes_003E5__124;

			private IEnumerator _003C_003Es__125;

			private XmlNode _003Cnode_003E5__126;

			private string _003Csube_003E5__127;

			private string _003Chesap_003E5__128;

			private string _003Caccountno_003E5__129;

			private int _003Ci_003E5__130;

			private StringBuilder _003Csbuilder_003E5__131;

			private string _003Cresponse_003E5__132;

			private string[] _003Clinearray_003E5__133;

			private string _003CacoountNo_003E5__134;

			private string _003CbinanceFutureBaseUrl_003E5__135;

			private BinanceSpotClient _003Cclient_003E5__136;

			private BinanceSpotClient.AccountInfo _003Cresponce_003E5__137;

			private string _003CfutureResponse_003E5__138;

			private JavaScriptSerializer _003Cserializer_003E5__139;

			private BinanceFuture.ResponseClasses.AccountInformation _003CfutureInformation_003E5__140;

			private BinanceSpotClient.AccountInfo _003C_003Es__141;

			private string _003CacoountNo_003E5__142;

			private Portfoy _003CactivePortfoy_003E5__143;

			private AccountInfoModel _003Coreturn_003E5__144;

			private JavaScriptSerializer _003Cserializer_003E5__145;

			private string _003CacoountNo_003E5__146;

			private string _003CreqStr_003E5__147;

			private Artiox.ReqArtioxLogin _003CreqArtioxLogin_003E5__148;

			private JavaScriptSerializer _003Cserializer_003E5__149;

			private string _003Cresponse_003E5__150;

			private Artiox.ResArtioxLogin _003Cjsonobj_003E5__151;

			private string _003CacoountNo_003E5__152;

			private JavaScriptSerializer _003Cserializer_003E5__153;

			private string _003CreqStr_003E5__154;

			private string _003Cresponse_003E5__155;

			private IsYatırım.AccountsList _003Cjsonobj_003E5__156;

			private IsYatırım.Accounts[] _003C_003Es__157;

			private int _003C_003Es__158;

			private IsYatırım.Accounts _003Cro_003E5__159;

			private JavaScriptSerializer _003Cserializer_003E5__160;

			private string _003CreqStr_003E5__161;

			private string _003Cresponse_003E5__162;

			private Optimus.HesapListesi _003Cjsonobj_003E5__163;

			private Exception _003Cerror_003E5__164;

			private Exception _003Cerror_003E5__165;

			private TaskAwaiter<BinanceSpotClient.AccountInfo> _003C_003Eu__1;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _003CLogin_003Ed__60()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static _003CLogin_003Ed__60()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public static volatile ConcurrentDictionary<string, bool> BusyCheckDictionary;

		private static List<string> AdressesforRemoteIP;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string SendHttpRequest(AccountRecord accountX, string requestX, string methodX, string urlX, bool logbool)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string SendHttpRequest2(AccountRecord accountX, string requestX, string methodX, string urlX, bool logbool)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string RequestHTTP(AccountRecord accountX, string urlX, string requestX, string methodX, bool logbool)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool Busy(string keyX, string accountnameX, string accountnoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ConvertImkbReceivedSymbol(string backofficeX, string strX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ConvertImkbReceivedSymbol(string hesapnameX, string backofficeX, string strX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ConvertImkbSenderSymbol(string backofficeX, string strX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetSymbolSeri(string backofficeX, string strX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetBISHeader(AccountRecord accountX, string accountnoX, string piyasaX, BuySellRecord buysellX = null)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetAkYatirimOTPHeader(AccountRecord accountX, string accountnoX, string urlX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetGeneksHeader(AccountRecord accountX, string accountnoX, string urlX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetIsYatirimAppCode(AccountRecord accountX, bool robotboolX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string IsYatirimEquityList(AccountRecord accountX, string symbolX, string accountnameX, string accountnoX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string IsYatirimFutOptList(AccountRecord accountX, string symbolX, string accountnameX, string accountnoX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetIsYatirimAppPassword(AccountRecord accountX, bool robotboolX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetIsYatirimPortHeader(string hedefUrlX, string piyasaX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetGeneksPasswordEncripted(string brokerX, string passCleanX, int fazX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetResolveDns(Uri urix)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetGeneksIPHeader(string hedefUrlX, string piyasaX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetBISUygulamaNo(AccountRecord accountX, string piyasaX, BuySellRecord buysellX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetBISIPHeader(string hedefUrlX, string piyasaX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string EncryptPasswordTextAes128(string plainText, string key, string iv)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetGeneksVipRandomID()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetGeneksGeneratedUniqueKey(AccountRecord accountX, string p0, out string uniqueKey)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetGTPClientType(AccountRecord accountX, bool robotboolX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetGtpHeader(AccountRecord accountX, string accountnoX, string postmessageX, bool robotboolX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetIDBHeader(AccountRecord accountX, BuySellRecord buysellX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetInfinaHeader(AccountRecord accountX, string accountnoX, string postmessageX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetIdbUygulamaNo(AccountRecord accountX, BuySellRecord buysellX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetTebAdjustedSembol(string symbolX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetTEB2ViopHeader(AccountRecord accountX, string messageTypeX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetTebKey(string strX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<GerceklesenIslemClass> GetGerceklesenViopIslemler(AccountRecord accountX, string accountnoX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static decimal CalculateViopKZAnlik(string sembolX, List<GerceklesenIslemClass> islemlerX, decimal pozisyonX)
		{
			return (decimal)(object)null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static decimal CalculateViopPositionSize(string sembolX, List<GerceklesenIslemClass> islemlerX, decimal pozisyonX)
		{
			return (decimal)(object)null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static decimal CalculateViopSettlementPrice(string sembolX, List<GerceklesenIslemClass> islemlerX, decimal pozisyonX)
		{
			return (decimal)(object)null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static decimal CalculateViopKZ(string sembolX, List<GerceklesenIslemClass> islemlerX, decimal pozisyonX)
		{
			return (decimal)(object)null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static decimal CalculateViopKZLastPrice(string sembolX, double netMaliyetX, List<GerceklesenIslemClass> islemlerX, decimal pozisyonX)
		{
			return (decimal)(object)null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static decimal CalculateViopKZFifoMaliyet(string sembolX, double fifoMaliyetX, List<GerceklesenIslemClass> islemlerX, decimal pozisyonX)
		{
			return (decimal)(object)null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(_003CGetRemoteIP_003Ed__42))]
		public static Task<bool> GetRemoteIP(AccountRecord account)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string GetLocalIPAddressFromNetworkInterface()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool GTP_Token_All(AccountRecord accountX, string responseX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool GetHalkGtpToken(AccountRecord accountX, string response)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool GetGtpToken(AccountRecord accountX, string response)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool GeneksSessionControl(string response)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool BISSessionControl(string response)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool InfinaSessionControl(string response)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IDBSessionControl(string response, string accountX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool GTPSifreHataControl(AccountRecord accountX, string response)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string SHA_Hash(string valuex)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string getTEB2Authentication()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void timerTEB2GetToken()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetTEBKaynakKod(string piyasa)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool TEBSessionControl(int? cevapKodX, string cevapMesajX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool GetTEBOperationToken(AccountRecord accountX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string SendTEB2HttpRequest(AccountRecord accountX, TebReqClass reqObj, bool logbool)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string SendTEB2VIOPHttpRequest(AccountRecord accountX, string requestX, bool logbool)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(_003CLogin_003Ed__60))]
		public static void Login(string accountnameX, string passwordX, string parolaX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Logout(string accountnameX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ChangePassword(string accountnameX, string parolaX, string oldpasswordX, string newpasswordX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GetCustomerAccounts(string accountnameX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void TransferMoney(string accountnameX, string hesapname, string directionX, double amountX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RiskOnayFormCheck(string accountnameX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RiskOnayFormOnay(string accountnameX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RiskBildirimSonuc RiskBildirimShowBool(string accountnameX, string accountnoX, string SymbolX, string buySellX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void _ImkbCancelOrder(ImkbOrderRecord orderX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ImkbCancelOrder(ImkbOrderRecord orderX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ImkbCancelOrders(List<ImkbOrderRecord> orderlistX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _ImkbGetIslemLimit(string accountnameX, string accountnoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ImkbGetIslemLimit(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _ImkbGetVarlikDegisim(string accountnameX, string accountnoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ImkbGetVarlikDegisim(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _ImkbGetOrders(string accountnameX, string accountnoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ImkbGetOrders(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _ImkbGetPositions(string accountnameX, string accountnoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ImkbGetPositions(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ImkbGetRiskSimulation(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void _ImkbGetSellableAmount(string accountnameX, string accountnoX, string symbolX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ImkbGetSellableAmount(string accountnameX, string accountnoX, string symbolX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ImkbGetStatement(string accountnameX, string accountnoX, DateTime date1X, DateTime date2X)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void _ImkbGetSummary(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ImkbGetSummary(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void _ImkbGetCreditStatus(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ImkbGetCreditStatus(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void _ImkbGetSymbolInfo(string accountnameX, string accountnoX, string symbolX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ImkbGetSymbolInfo(string accountnameX, string accountnoX, string symbolX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void _ImkbImproveOrder(ImkbOrderRecord orderX, double newpriceX, double lotX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void _ImkbImproveOrder(ImkbOrderRecord orderX, double newpriceX, double lotX, double GlotX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ImkbImproveOrders(List<ImkbOrderRecord> orderlistX, double newpriceX, double lotX, double GlotX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void _ImkbSendOrder(BuySellRecord buysellX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ImkbSendOrder(BuySellRecord buysellX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ImkbSendOrders(List<BuySellRecord> buyselllistX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ImkbSendZincir(ImkbOrderRecord orderX, BuySellRecord buysellX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void _ImkbSendOrderAcigaKapa(BuySellRecord buysellX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ImkbSendOrderAcigaKapa(BuySellRecord buysellX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AkDuyuruOnaySend(string accountnameX, string accountnoX, string mesajIDx)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void _ImkbTransactionReport(string accountnameX, string accountnoX, DateTime date1X, DateTime date2X, string hisseX, string codeX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ImkbTransactionReport(string accountnameX, string accountnoX, DateTime date1X, DateTime date2X, string hisseX, string codeX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void _VipCancelOrder(VipOrderRecord orderX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void VipCancelOrder(VipOrderRecord orderX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void VipCancelOrders(List<VipOrderRecord> orderlistX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void VipGetAcik(string accountnameX, string accountnoX, DateTime date1X)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _VipGetCollateral(string accountnameX, string accountnoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void VipGetCollateral(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _VipGetFillPrice(string accountnameX, string accountnoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void VipGetFillPrice(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void VipGetGayri(string accountnameX, string accountnoX, DateTime date1X, DateTime date2X)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _VipGetOrders(string accountnameX, string accountnoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void VipGetOrders(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _VipGetPositions(string accountnameX, string accountnoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void VipGetPositions(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void VipGetStatement(string accountnameX, string accountnoX, DateTime date1X, DateTime date2X)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void VipGetProfit(string accountnameX, string accountnoX, DateTime date1X, DateTime date2X)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void VipGetKZRapor(string accountnameX, string accountnoX, DateTime date1X, DateTime date2X)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void VipGetTeyid(string accountnameX, string accountnoX, DateTime date1X)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void _VipImproveOrder(VipOrderRecord orderX, BuySellRecord buysellX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void VipImproveOrder(VipOrderRecord orderX, BuySellRecord buysellX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void VipImproveOrders(List<VipOrderRecord> orderlistX, BuySellRecord buysellX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void _VipSendOrder(BuySellRecord buysellX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void VipSendOrder(BuySellRecord buysellX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void VipSendOrders(List<BuySellRecord> buyselllistX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void _VipTransactionReport(string accountnameX, string accountnoX, DateTime date1X, DateTime date2X, string sozlesmeX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void VipTransactionReport(string accountnameX, string accountnoX, DateTime date1X, DateTime date2X, string sozlesmeX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _FonGetIslemler(string accountnameX, string accountnoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _FonGetKurucular(string accountnameX, string accountnoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _FonGetPosition(string accountnameX, string accountnoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _FonGetFonTipleri(string accountnameX, string accountnoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _FonGetAlimListesi(string accountnameX, string accountnoX, string kurucuX, bool tipboolX, string tipstrX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _FonGetSatimListesi(string accountnameX, string accountnoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _FonSendOrder(string accountnameX, string accountnoX, string fonidX, decimal miktarX, string yonstrX, string adettutarstrX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _FonCancelOrder(string accountnameX, string accountnoX, string islemnoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _GetVarliklar(string accountnameX, string accountnoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ImkbCancelOrdersKEP(List<ImkbOrderRecord> ordersX, bool positionsboolX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ImkbImproveOrdersKEP(List<ImkbOrderRecord> ordersX, double priceX, bool positionsboolX, double lotx = 0.0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ImkbSendOrderKEP(BuySellRecord buysellX, bool positionsboolX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ImkbGetHesapKEP(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ImkbGetOrdersKEP(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ImkbGetPositionsKEP(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void VipCancelOrdersKEP(List<VipOrderRecord> ordersX, bool positionsboolX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void VipImproveOrdersKEP(List<VipOrderRecord> ordersX, List<BuySellRecord> buysellsX, bool positionsboolX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void VipSendOrderKEP(BuySellRecord buysellX, bool positionsboolX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void VipGetCollateralKEP(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void VipGetFillPriceKEP(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void VipGetOrdersKEP(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void VipGetPositionsKEP(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ViopRobotHesapClass VipGetHesapRobot()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ViopRobotHesapClass VipGetPozisyonRobot()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static BistRobotHesapClass BistGetHesapRobot()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void _CriptoCancelOrder(CriptoOrderRecord orderX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CriptoCancelOrder(CriptoOrderRecord orderX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CriptoCancelOrders(List<CriptoOrderRecord> orderlistX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string CriptoAddAcoount(string ApikeyX, string SecretkeyX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void _CriptoGetExchangeInfo(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _CriptoGetPositions(string accountnameX, string accountnoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CriptoGetPositions(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _CriptoGetDailySpotAccountSnapshot(string accountnameX, string accountnoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CriptoGetDailySpotAccountSnapshot(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CriptoGetFutureExchangeInfo(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _CriptoGetFutureExchangeInfo(string accountnameX, string accountnoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CriptoFutureAccountInfo(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool _CriptoFutureAccountInfo(string accountnameX, string accountnoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _CriptoGetFuturePositions(string accountnameX, string accountnoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CriptoGetFuturePositions(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _CriptoGetFutureOrders(string accountnameX, string accountnoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CriptoGetFutureOrders(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _CriptoGetFutureLeverageLimits(string accountnameX, string accountnoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CriptoGetFutureLeverageLimits(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CriptoGetFutureMultiAssetsMode(string accountNameX, string accountNoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _CriptoGetFutureMultiAssetsMode(string accountNameX, string accountNoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CriptoGetFutureTradeHistory(string accountNameX, string accountNoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool _CriptoGetFutureTradeHistory(string accountNameX, string accountNoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CriptoGetFutureOrderHistory(string accountNameX, string accountNoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool _CriptoGetFutureOrderHistory(string accountNameX, string accountNoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CriptoGetFutureTransactionHistory(string accountNameX, string accountNoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool _CriptoGetFutureTransactionHistory(string accountNameX, string accountNoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CriptoGetFutureAssets(string accountNameX, string accountNoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool _CriptoGetFutureAssets(string accountNameX, string accountNoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CriptoFutureCancelOrders(List<BinanceFuture.ResponseClasses.OpenOrder> orderlistX, string accountName)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CrypexCriptoFutureCancelOrders(List<BinanceFuture.ResponseClasses.OpenOrder> orderlistX, string accountName)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void _CriptoFutureCancelOrder(BinanceFuture.ResponseClasses.OpenOrder orderX, string accountName)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void _CrypexCriptoFutureCancelOrder(IcrypexFuture.ResponseClasses.OpenOrder orderX, string accountName)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CriptoFutureSendOrder(BuySellRecord buysellX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void _CriptoFutureSendOrder(BuySellRecord buysellX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CriptoFutureChangeLeverageLimit(string leverageLimit, string symbol, string accountName, string accountNo)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void _CriptoFutureChangeLeverageLimit(string leverageLimit, string symbol, string accountName, string accountNo)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool ChangeMarginType(bool isolated, string symbol, string accountName, string accountNo)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool _ChangeMarginType(bool isolated, string symbol, string accountName, string accountNo)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void _CriptoSendOrder(BuySellRecord buysellX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CriptoSendOrder(BuySellRecord buysellX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CriptoSendOrders(List<BuySellRecord> buyselllistX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _CriptoGetOrders(string accountnameX, string accountnoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CriptoGetOrders(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _CriptoGetTrades(string accountnameX, string accountnoX, string symbolX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CriptoGetTrades(string accountnameX, string accountnoX, string symbolX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void _NFTCancelOrder(CriptoOrderRecord orderX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void NFTCancelOrders(List<CriptoOrderRecord> orderlistX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _NFTGetPositions(string accountnameX, string accountnoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void NFTGetPositions(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _NFTGetOrders(string accountnameX, string accountnoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void NFTGetOrders(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _NFTGetTrades(string accountnameX, string accountnoX, string symbolX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void NFTGetTrades(string accountnameX, string accountnoX, string symbolX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void _NFTSendOrder(BuySellRecord buysellX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void NFTSendOrder(BuySellRecord buysellX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void NFTSendOrders(List<BuySellRecord> buyselllistX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _NFTGetBalanceHistory(string accountnameX, string accountnoX)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void NFTGetBalanceHistory(string accountnameX, string accountnoX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void _MagnusLogin()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void _MagnusSendRequest10Second()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string Base64UrlEncoder_Encode(byte[] data)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GenerateTokenJWT(string usernameX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void TransactionCallback()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void MagnusCanceOrderSymbol(string symbolX, string transactionIdX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Request()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Request()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			WP6RZJql8gZrNhVA9v.w65ov7siki();
			hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
			BusyCheckDictionary = new ConcurrentDictionary<string, bool>();
			AdressesforRemoteIP = new List<string> { "https://ip.idealdata.com.tr/", "https://myexternalip.com/raw" };
		}
	}

	public static string BrokerrName;

	private static DateTime TimeImkbGetHesapKEP;

	private static DateTime TimeImkbGetOrdersKEP;

	private static DateTime TimeImkbGetPositionsKEP;

	private static DateTime TimeVipGetCollateralKEP;

	private static DateTime TimeVipGetFillPriceKEP;

	private static DateTime TimeVipGetOrdersKEP;

	private static DateTime TimeVipGetPositionsKEP;

	public static Dictionary<string, Portfoy> PortfoyDictionary;

	public static Dictionary<string, BrokerRecord> BrokerDictionary;

	public static SettingRecord Setting;

	public static ConcurrentQueue<string> EventQueue;

	public static BuySellRecord BuySellItem;

	public static ImkbOrderRecord ImkbOrder;

	public static VipOrderRecord VipOrder;

	public static List<string> MessageList;

	public static double PositionCloseRatio;

	public static double PositionCloseMoney;

	public static byte ImkbOrderFilterStatus;

	public static bool ImkbOrderFilterBuy;

	public static bool ImkbOrderFilterSell;

	public static bool ImkbOrderFilterAllStocks;

	public static string ImkbOrderFilterStock;

	public static string ImkbOrderFilterPrice;

	public static string ImkbOrderFilterLot;

	public static string SelectedTab;

	public static byte ImkbWaitingBuySellFilter;

	public static byte ImkbWaitingDisplayFilter;

	public static bool ImkbWaitingAllStockFilter;

	public static string ImkbWaitingStockFilter;

	public static DateTime LoginTime;

	public static string VipOrderSymbolFilter;

	public static string VipOrderExpiryFilter;

	public static int SistemMultiNo;

	public static bool SistemMultiGridVisible;

	public static List<List<string>> SistemMultiYonList;

	public static List<List<decimal>> SistemMultiCashList;

	public static ConcurrentQueue<string> EventQueueKEP;

	public static CookieContainer CookieMain;

	public static string remoteIP;

	public static string localIp;

	public static string BackOfficeBIST_IP;

	public static string BackOfficeVIOP_IP;

	public static BinanceClient BinanceRestClient;

	public static BinanceFuture BinanceFutureClass;

	public static IcrypexFuture IcrypexFutureClass;

	public static Dictionary<string, string> FileSifreDict;

	public static Dictionary<string, decimal> BinanceHariciSembolFiyatlar;

	public static List<string> GTPSembolKurumList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddPortfoy(string accountnameX, string accountnoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Portfoy GetActivePortfoy()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double GetImkbLimit(string accountnameX, string accountnoX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double GetImkbOverall(string accountnameX, string accountnoX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Portfoy GetPortfoy(string accountnameX, string accountnoX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemovePortfoy(string accountnameX, string accountnoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReadFileSifreler()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CheckLogin(string accountnameX)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CheckZincirYetki(string brokerX)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Deserialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetActiveAccountNo(string accountnameX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static AccountRecord GetAccount(string accountnameX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<string> GetAccountNoList(string accountnameX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DateTime GetGtpValorTarih()
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<decimal> GetPriceSteps(string symbolX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float CalculatePriceStep(string symbolX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetImkbCurrentSessionFromAccountName(string accountnameX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetKurumUnvan(string kurumX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetKurumMetodType(string kurumX, string backofficeX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double GetSymbolDefaultLot(string symbolX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetTestData(string filenamex)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double GetViopMultiplier(string Symbolx)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double GetViopMultiplierForPozSize(string Symbolx)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InsertEvent(string eventmessageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InsertBuySellToAlgo(BuySellRecord buysellX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InsertBuySellToList(BuySellRecord buysellX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string PeperSalt_Hash(string valuex)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReadBrokers()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetKurumNameKisaForOTP(AccountRecord accountX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetGeneksSoftOTP(AccountRecord accountX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool GetOTPCheckBool(AccountRecord accountX)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string CriptoTranslateMessage(string strX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxPortfolio()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static cxPortfolio()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		BrokerrName = "";
		TimeImkbGetHesapKEP = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
		TimeImkbGetOrdersKEP = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
		TimeImkbGetPositionsKEP = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
		TimeVipGetCollateralKEP = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
		TimeVipGetFillPriceKEP = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
		TimeVipGetOrdersKEP = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
		TimeVipGetPositionsKEP = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
		PortfoyDictionary = new Dictionary<string, Portfoy>();
		BrokerDictionary = new Dictionary<string, BrokerRecord>();
		Setting = new SettingRecord();
		EventQueue = new ConcurrentQueue<string>();
		BuySellItem = new BuySellRecord();
		ImkbOrder = new ImkbOrderRecord();
		VipOrder = new VipOrderRecord();
		MessageList = new List<string>();
		PositionCloseRatio = 0.0;
		PositionCloseMoney = 0.0;
		ImkbOrderFilterStatus = 0;
		ImkbOrderFilterBuy = true;
		ImkbOrderFilterSell = true;
		ImkbOrderFilterAllStocks = true;
		ImkbOrderFilterStock = "SENET";
		ImkbOrderFilterPrice = "Fiyat";
		ImkbOrderFilterLot = "Miktar";
		SelectedTab = "";
		ImkbWaitingBuySellFilter = 0;
		ImkbWaitingDisplayFilter = 0;
		ImkbWaitingAllStockFilter = true;
		ImkbWaitingStockFilter = "SENET";
		LoginTime = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
		VipOrderSymbolFilter = "";
		VipOrderExpiryFilter = "";
		SistemMultiNo = -1;
		SistemMultiGridVisible = true;
		EventQueueKEP = new ConcurrentQueue<string>();
		CookieMain = new CookieContainer();
		remoteIP = "";
		localIp = "";
		BackOfficeBIST_IP = "";
		BackOfficeVIOP_IP = "";
		BinanceRestClient = new BinanceClient();
		BinanceFutureClass = new BinanceFuture();
		IcrypexFutureClass = new IcrypexFuture();
		FileSifreDict = new Dictionary<string, string>();
		BinanceHariciSembolFiyatlar = new Dictionary<string, decimal>();
		GTPSembolKurumList = new List<string>();
	}
}
