using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;
using nsoftware.IPWorks;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class formClearingBank : Form
{
	private class FileRecord
	{
		public string Symbol;

		public string BrokerCode;

		public double Lot;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FileRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static FileRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class StockBasedRecord
	{
		public string BrokerCode;

		public string BrokerDesc;

		public double TotalLot1;

		public double Percent1;

		public double ValueTL1;

		public double TotalLot2;

		public double Percent2;

		public double ValueTL2;

		public double DifLot;

		public double DifTL;

		public double DifPercent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StockBasedRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static StockBasedRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class BrokerBasedRecord
	{
		public string Stock;

		public double TotalLot1;

		public double TotalLot2;

		public double Price1;

		public double Price2;

		public double Percent1;

		public double Percent2;

		public double ValueTL1;

		public double ValueTL2;

		public double StockLot1;

		public double StockLot2;

		public double StockPercent1;

		public double StockPercent2;

		public double StockTL1;

		public double StockTL2;

		public double DifLot;

		public double DifTL;

		public double DifPercent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BrokerBasedRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static BrokerBasedRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class TypeStock
	{
		public string Symbol;

		public string Date1;

		public double ClosePrice1;

		public string Date2;

		public double ClosePrice2;

		public string TimeOfData;

		public double TotalSize1;

		public double TotalTL1;

		public double TotalSize2;

		public double TotalTL2;

		public double DifSize;

		public double DifTotalInc;

		public double DifTotalDec;

		public int LevelCount;

		public double LevelSize;

		public double LevelTL;

		public double LevelPercent;

		public double BuyersFiveTotal;

		public double SellersFiveTotal;

		public bool LotOrTL;

		public List<StockBasedRecord> DataList;

		public List<StockBasedRecord> LevelList;

		public List<StockBasedRecord> GroupList;

		public List<StockBasedRecord> BuyersList;

		public List<StockBasedRecord> SellersList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TypeStock()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TypeStock()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class TypeBroker
	{
		public string BrokerCode;

		public string BrokerDesc;

		public string Date1;

		public string Date2;

		public double TotalSize1;

		public double TotalSize2;

		public double TotalTL1;

		public double TotalTL2;

		public double ImkbLot1;

		public double ImkbLot2;

		public double ImkbTL1;

		public double ImkbTL2;

		public int LevelCount;

		public List<BrokerBasedRecord> DataList;

		public List<BrokerBasedRecord> LevelList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TypeBroker()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TypeBroker()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private class ForeignRecord
	{
		public string Date;

		public float ForeignVolume;

		public float ForeignRate;

		public float LocalVolume;

		public float LocalRate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForeignRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ForeignRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private class DistributionStockRecord
	{
		public string Broker;

		public double BuyLot;

		public double BuyVol;

		public double BuyAvr;

		public double SellLot;

		public double SellVol;

		public double SellAvr;

		public double Total;

		public double TotalPercent;

		public double Net;

		public double NetPercent;

		public double Cost;

		public double TakasRT;

		public double TksYuzde;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DistributionStockRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DistributionStockRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private class DistributionBrokerRecord
	{
		public string Stock;

		public int SembolId;

		public double BuyLot;

		public double BuyVol;

		public double BuyAvr;

		public double SellLot;

		public double SellVol;

		public double SellAvr;

		public double Total;

		public double Net;

		public double Percent;

		public double Cost;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DistributionBrokerRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DistributionBrokerRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class KurumHacimRecord
	{
		public int KurumId;

		public string Broker;

		public double VolumeBuy;

		public double VolumeBuyP;

		public double VolumeSell;

		public double VolumeSellP;

		public double VolumeSum;

		public double VolumeSumP;

		public double VolumeDif;

		public double VolumeDifP;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KurumHacimRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static KurumHacimRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class DistributionRecord
	{
		public string Stock;

		public string Broker;

		public int BuyLot;

		public float BuyVol;

		public int SellLot;

		public float SellVol;

		public string BuySell;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DistributionRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DistributionRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public delegate void ControlInvoker();

	private class stockDetails
	{
		public string stockName;

		public double NetAlis;

		public double NetAlisYuzde;

		public double NetAlisOrt;

		public double NetSatis;

		public double NetSatisYuzde;

		public double NetSatisOrt;

		public double Pgc;

		public double DigerAlis;

		public double DigerSatis;

		public double DigerFark;

		public double Maliyet;

		public double ToplamHacim;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public stockDetails()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static stockDetails()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private class stockRecord
	{
		public string symbolname;

		public string root;

		public string indexType;

		public Dictionary<string, DistributionStockRecord> DictionaryKurum;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public double SatisNetHacim(int seviye)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public double DigerSatisNetHacim(int seviye)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public double AlisNetHacim(int seviye)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public double DigerAlisNetHacim(int seviye)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public double ToplamHacim()
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public double AortAl(int seviye)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public double AortSat(int seviye)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public stockRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static stockRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class SenetHacimRecord
	{
		public string Stock;

		public double AlisLot;

		public double SatisLot;

		public double AlisHacim;

		public double SatisHacim;

		public double ToplamLot;

		public double ToplamHacim;

		public double NetLot;

		public double NetHacim;

		public double Yuzde;

		public double Maliyet;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hesapla()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SenetHacimRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SenetHacimRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class SembolRec1
	{
		public int SembolId;

		public double BuyLot;

		public double BuyVol;

		public double SellLot;

		public double SellVol;

		public double NetLot;

		public double NetVol;

		public double Maliyet;

		public double Miktar;

		public double Yuzde;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SembolRec1()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SembolRec1()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class HacimRec1
	{
		public int KurumId;

		public double BuyMiktar;

		public double BuyMiktarY;

		public double SellMiktar;

		public double SellMiktarY;

		public double ToplamMiktar;

		public double ToplamMiktarY;

		public double NetMiktar;

		public double NetMiktarY;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HacimRec1()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static HacimRec1()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class KurumRec1
	{
		public int KurumId;

		public double BuyLot;

		public double BuyVol;

		public double SellLot;

		public double SellVol;

		public double NetLot;

		public double NetVol;

		public double Maliyet;

		public double Miktar;

		public double Yuzde;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KurumRec1()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static KurumRec1()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class PgcRec1
	{
		public int SembolId;

		public double NetBuy;

		public double FiveBuy;

		public double DigerBuy;

		public double FiveBuyY;

		public double AvrBuy;

		public double NetSell;

		public double FiveSell;

		public double DigerSell;

		public double FiveSellY;

		public double AvrSell;

		public double Pgc;

		public double DigerFark;

		public double ToplamMiktar;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PgcRec1()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static PgcRec1()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public static formClearingBank Reference;

	private string FormCaption;

	private WebClient Downloader;

	private Dictionary<string, string> DownloadDictionary;

	private Queue<string> DownloadQueue;

	public string ActiveSymbol;

	public static string Date1;

	public static string Date2;

	private DataGridView ActiveGrid;

	public static string Disclamer1;

	public static string Disclamer2;

	public static string Disclamer3;

	public static string Disclamer4;

	public static string Disclamer5;

	public static string Disclamer6;

	public static int CoordLeft;

	public static int CoordTop;

	public static bool PiteBool;

	public static bool PitBool;

	public static bool VitBool;

	public static bool ViopVadeBasiBool;

	public static DateTime PrevViopStartDate;

	private static List<FileRecord> FileRecordList;

	private static string TimeOfData;

	private string TakasStockSymbol;

	private int ColForeign;

	private TypeStock StockDayItem;

	private TypeStock StockDifItem;

	private TypeBroker BrokerDayInst;

	private TypeBroker BrokerDifInst;

	private cxDataGrid.SortRecord SortParamStock1;

	private cxDataGrid.SortRecord SortParamStock2;

	private cxDataGrid.SortRecord SortParamBroker3;

	private cxDataGrid.SortRecord SortParamBroker4;

	private string DistributionStockSymbol;

	private string PiteStockSymbol;

	public static DateTime DateDistributionStock1;

	public static DateTime DateDistributionStock2;

	public static DateTime DatePiteStock1;

	public static DateTime DatePiteStock2;

	public static byte DistributionStockAmoutType;

	public static byte PiteStockAmoutType;

	public static int DistributionStockMostCount;

	public static int PiteStockMostCount;

	private int DistributionStockSortColumn;

	private int PiteStockSortColumn;

	private byte DistributionStockSortDirection;

	private byte PiteStockSortDirection;

	private List<DistributionStockRecord> DistributionStockList;

	private List<DistributionStockRecord> PiteStockList;

	private double DistributionStockNetBuySum;

	private double DistributionStockNetSellSum;

	private double DistributionStockNetBuyMost;

	private double DistributionStockNetSellMost;

	private double DistributionStockNetDifMost;

	private double DistributionStockTotalMost;

	private double PiteStockNetBuySum;

	private double PiteStockNetSellSum;

	private double PiteStockNetBuyMost;

	private double PiteStockNetSellMost;

	private double PiteStockNetDifMost;

	private double PiteStockTotalMost;

	private volatile string DistributionBrokerName;

	private volatile string PiteBrokerName;

	public static string SymbolFilter;

	public static string SymbolFilterPiteBroker;

	private Dictionary<int, int> SymbolDictionary;

	private Dictionary<string, string> SymbolDictionaryPite;

	private Dictionary<string, string> SymbolDictionaryPiteBroker;

	public static DateTime DateDistributionBroker1;

	public static DateTime DateDistributionBroker2;

	public static byte DistributionBrokerAmoutType;

	public static byte PiteBrokerAmoutType;

	public static byte PiteKurumHacimAmoutType;

	public static int DistributionBrokerMostCount;

	public static int PiteBrokerMostCount;

	public static int PiteKurumHacimMostCount;

	private int DistributionBrokerSortColumn;

	private int PiteBrokerSortColumn;

	private byte DistributionBrokerSortDirection;

	private byte PiteBrokerSortDirection;

	private List<DistributionBrokerRecord> DistributionBrokerList;

	private List<DistributionBrokerRecord> PiteBrokerList;

	private double DistributionBrokerTotalBuy;

	private double DistributionBrokerTotalSell;

	private double DistributionBrokerTotalVolume;

	private double DistributionBrokerTotalDif1;

	private double DistributionBrokerTotalDif2;

	private double DistributionBrokerNetBuySum;

	private double DistributionBrokerNetSellSum;

	private double DistributionBrokerNetBuyMost;

	private double DistributionBrokerNetSellMost;

	private double DistributionBrokerNetDif;

	private double PiteBrokerTotalBuy;

	private double PiteBrokerTotalSell;

	private double PiteBrokerTotalVolume;

	private double PiteBrokerTotalDif1;

	private double PiteBrokerTotalDif2;

	private double PiteBrokerNetBuySum;

	private double PiteBrokerNetSellSum;

	private double PiteBrokerNetBuyMost;

	private double PiteBrokerNetSellMost;

	private double PiteBrokerNetDif;

	private Thread DistributionBrokerThread;

	private Thread PiteBrokerThread;

	private bool RestartDistributionBrokerThread;

	private bool RestartPiteBrokerThread;

	private bool DistributionBrokerThreadFinished;

	private bool PiteBrokerThreadFinished;

	private volatile string DistributionBrokerStatus;

	private volatile string PiteBrokerStatus;

	private List<KurumHacimRecord> KurumHacimList;

	private double KurumHacimVolumeBuy;

	private double KurumHacimVolumeSell;

	private double KurumHacimVolumeSum;

	private double KurumHacimNetBuy;

	private double KurumHacimNetSell;

	private double KurumHacimNetBuyMost;

	private double KurumHacimNetSellMost;

	public static DateTime DateKurumHacim1;

	public static DateTime DateKurumHacim2;

	public static int KurumHacimMostCount;

	public static int KurumHacimMostKurumCount;

	private int KurumHacimSortColumn;

	private byte KurumHacimSortDirection;

	private int PiteKurumHacimSortColumn;

	private byte PiteKurumHacimSortDirection;

	private Thread KurumHacimThread;

	private bool RestartKurumHacimThread;

	private bool KurumHacimThreadFinished;

	private string KurumHacimStatus;

	private string PiteKurumHacimStatus;

	private Dictionary<string, stockRecord> dictionaryStockRecod;

	private List<stockDetails> StockDetailsList;

	public int SortColoumn;

	public bool SortType;

	public string PitePGCStatus;

	public bool acilis;

	public bool hacimType;

	private Dictionary<string, Dictionary<string, SenetHacimRecord>> PiteKurumSenetHacimDictionary;

	private static int WindowWidth;

	private static int WindowHeight;

	private static int WindowTop;

	private static int WindowLeft;

	private static string LastYBODownloadDate;

	private bool ComboPiteStockSymbolDropDown;

	private Dictionary<int, Dictionary<int, SembolRec1>> KurumSembolMap;

	private List<HacimRec1> HacimList;

	private Dictionary<int, Dictionary<int, KurumRec1>> SembolKurumMap;

	private List<PgcRec1> PgcList;

	private string FormHeader;

	private IContainer components;

	private TabControl tabControl1;

	private TabPage tabTakasStock1;

	private TabPage tabTakasStock2;

	private TabPage tabTakasBroker1;

	private TabPage tabTakasBroker2;

	private Label lblDisclaimer;

	private DataGridView gridStock1;

	private DataGridView gridLevel1;

	private DataGridView gridGroup1;

	private TabPage tabPage5;

	private CheckedListBox lstBoxBroker;

	private ListBox lstBoxGroup;

	private Button buttonDelete;

	private Button buttonSave;

	private TextBox textSearch1;

	private DateTimePicker datetimeStock1;

	private ComboBox comboStock1;

	private Button buttonDownload;

	private Label lblStockClose1;

	private TextBox textSearch2;

	private DataGridView gridGroup2;

	private DataGridView gridStock2;

	private DateTimePicker datetimeStart2;

	private ComboBox comboStock2;

	private DateTimePicker datetimeEnd2;

	private DataGridView gridSellers2;

	private DataGridView gridBuyers2;

	private DataGridView gridBroker3;

	private DateTimePicker datetimeBroker3;

	private ComboBox comboBroker3;

	private TextBox textSearch3;

	private DataGridView gridLevel3;

	private RadioButton radioTL;

	private RadioButton radioLot;

	private Label lblRatio3;

	private Label lblClearingTotalTL3;

	private Label lblBrokerTotalTL3;

	private Label label6;

	private Label label5;

	private Label label4;

	private DataGridView gridBroker4;

	private ComboBox comboBroker4;

	private DateTimePicker datetimeEnd4;

	private DateTimePicker datetimeStart4;

	private TextBox textSearch4;

	private Timer timerDownload;

	private Http http1;

	private Label label7;

	private Label label8;

	private Label label9;

	private Label label10;

	private TextBox textName;

	private TabPage tabForeign;

	private DataGridView gridForeign;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn66;

	private Button buttonDownload2;

	public ContextMenuStrip menu;

	private ToolStripMenuItem menuExcel;

	private ToolStripSeparator toolStripSeparator5;

	private ToolStripMenuItem menuClose;

	private ToolStripMenuItem menuJPG;

	private ToolStripMenuItem menuBMP;

	private TabPage tabDistributionStock;

	private DateTimePicker datetimeDistributionStock2;

	private DateTimePicker datetimeDistributionStock1;

	private Label label11;

	private TextBox textDistributionStockSearch;

	private DataGridView gridDistributionStock1;

	private DataGridView gridDistributionStock2;

	private ComboBox comboDistributionStockSymbol;

	private Timer timerRefresh;

	private Panel panel1;

	private RadioButton radioDistributionStockLot1;

	private RadioButton radioDistributionStockLot0;

	private DataGridView gridDistributionStock3;

	private Panel panelDistributionStockSummary;

	private TextBox textDistributionStockLevel;

	private TabPage tabDistributionBroker;

	private Label labelDistributionBrokerStatus;

	private Panel panel3;

	private RadioButton radioDistributionBrokerLot1;

	private RadioButton radioDistributionBrokerLot0;

	private ComboBox comboDistributionBrokerName;

	private Button buttonDistributionBrokerDownload;

	private Label label12;

	private TextBox textDistributionBrokerSearch;

	private DateTimePicker datetimeDistributionBroker2;

	private DateTimePicker datetimeDistributionBroker1;

	private Panel panelDistributionBrokerSummary;

	private TextBox textDistributionBrokerLevel;

	private DataGridView gridDistributionBroker3;

	private DataGridView gridDistributionBroker2;

	private DataGridView gridDistributionBroker1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;

	private DataGridViewTextBoxColumn No;

	private DataGridViewTextBoxColumn AraciKurum;

	private DataGridViewTextBoxColumn TakasLot;

	private DataGridViewTextBoxColumn TakasYuzde;

	private DataGridViewTextBoxColumn TakasTL;

	private Panel panelStockChangeSummary;

	private Button buttonDownloadKurum1;

	private Button buttonDownloadKurum2;

	private Button buttonStockSelect;

	private TabPage tabKurumHacim;

	private Panel panelKurumHacimSummary;

	private Label labelKurumHacimStatus;

	private DataGridView gridKurumHacim3;

	private DataGridView gridKurumHacim2;

	private Button buttonKurumHacimDownload;

	private Label label2;

	private TextBox textKurumHacimSymbolSearch;

	private DataGridView gridKurumHacim1;

	private DateTimePicker datetimeKurumHacim2;

	private DateTimePicker datetimeKurumHacim1;

	private DataGridView gridKurumHacim4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn97;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn102;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn113;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn114;

	private DataGridView gridDistributionStock4;

	private Button buttonDistributionStockDownload;

	private Panel panel2;

	private RadioButton radioDistributionStockListe;

	private RadioButton radioDistributionStockPasta;

	private Button buttonKademeHesapla1;

	private CheckBox checkSaatFiltresi1;

	private ComboBox comboKademeUst1;

	private ComboBox comboKademeAlt1;

	private Label label13;

	private Label label3;

	private Label label1;

	private Button buttonApply1;

	private TextBox textSaatBitis1;

	private TextBox textSaatBasla1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn67;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn68;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn69;

	private DataGridViewTextBoxColumn Column16;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn71;

	private DataGridViewTextBoxColumn Column17;

	private DataGridViewTextBoxColumn Column8;

	private DataGridViewTextBoxColumn Column23;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn73;

	private DataGridViewTextBoxColumn Column9;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn74;

	private Label label14;

	private TextBox textDistributionStockTotalSum;

	private TextBox textDistributionStockNetSum;

	private Label label15;

	private Label label16;

	private TextBox textDistributionStockNetDif2Most;

	private Label labelDistributionStockNetDif2Most;

	private TextBox textDistributionStockNetDif1Most;

	private Label labelDistributionStockNetDif1Most;

	private TextBox textDistributionStockNetSellMost;

	private Label labelDistributionStockNetSellMost;

	private TextBox textDistributionStockNetBuyMost;

	private Label labelDistributionStockNetBuyMost;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn Column2;

	private DataGridViewTextBoxColumn Column3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;

	private DataGridViewTextBoxColumn Fark;

	private DataGridViewTextBoxColumn colTakas2Yuzde;

	private DataGridViewTextBoxColumn ColDif2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;

	private DataGridViewTextBoxColumn Column4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;

	private DataGridViewTextBoxColumn Column5;

	private DataGridViewTextBoxColumn Column6;

	private DataGridViewTextBoxColumn Column7;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn93;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn94;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn95;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn96;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn98;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn99;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn100;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn101;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn103;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn104;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn105;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn106;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn107;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn108;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn109;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn110;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn111;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn112;

	private Panel panelPiyasa;

	private RadioButton radioPiyasaViop;

	private RadioButton radioPiyasaHisse;

	private Panel panelHacimPiyasa;

	private RadioButton radioButtonHacimViop;

	private RadioButton radioButtonHacimHisse;

	private Panel panelKurumDagilimViop;

	private RadioButton radioKDagilimViop;

	private RadioButton radioKDagilimHisse;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn82;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn85;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn86;

	private DataGridViewTextBoxColumn Column14;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn87;

	private DataGridViewTextBoxColumn Column15;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn88;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn89;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn91;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn92;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn79;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn80;

	private DataGridViewTextBoxColumn Column12;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn81;

	private DataGridViewTextBoxColumn Column20;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn76;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn77;

	private DataGridViewTextBoxColumn Column13;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn78;

	private DataGridViewTextBoxColumn Column21;

	private TabPage tabPiteStock;

	private Label label27;

	private TextBox textPiteStockNetDif2Most;

	private Label labelPiteStockNetDif2Most;

	private TextBox textPiteStockNetDif1Most;

	private Label labelPiteStockNetDif1Most;

	private TextBox textPiteStockNetSellMost;

	private Label labelPiteStockNetSellMost;

	private TextBox textPiteStockNetBuyMost;

	private Label labelPiteStockNetBuyMost;

	private Label label21;

	private TextBox textPiteStockNetSum;

	private Label label22;

	private TextBox textPiteStockTotalSum;

	private Label label23;

	private Button buttonPiteStockApply;

	private TextBox textPiteStockSaatBitis;

	private TextBox textPiteStockSaatBasla;

	private CheckBox checkPiteStockSaatFiltresi;

	private ComboBox comboPiteStockKademeUst;

	private ComboBox comboPiteStockKademeAlt;

	private Button buttonPiteKademeHesapla;

	private Button buttonPiteStockDownload;

	private Panel panel4;

	private RadioButton radioPiteStockLot1;

	private RadioButton radioPiteStockLot0;

	private TextBox textPiteStockLevel;

	private ComboBox comboPiteStockSymbol;

	private TextBox textPiteStockSearch;

	private DateTimePicker datetimePiteStock2;

	private DateTimePicker datetimePiteStock1;

	private Panel panel5;

	private RadioButton radioPiteStockListe;

	private RadioButton radioPiteStockPasta;

	private Label label26;

	private Timer timerPite;

	private Label label17;

	private TextBox textPiteStockInterval;

	private Panel panelPiteLisansKontrol;

	private Label labelLisansKontrol;

	private TabPage tabPiteBroker;

	private DateTimePicker datetimePiteBroker2;

	private DateTimePicker datetimePiteBroker1;

	private Button buttonPiteBrokerStockSelect;

	private Label labelPiteBrokerStatus;

	private Panel panel6;

	private RadioButton radioPiteBrokerLot0;

	private RadioButton radioPiteBrokerLot1;

	private ComboBox comboPiteBrokerName;

	private Button buttonPiteBrokerDownload;

	private Label label19;

	private TextBox textPiteBrokerSearch;

	private TextBox textPiteBrokerLevel;

	private DataGridView gridPiteBroker3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn147;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn148;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn149;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn150;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn151;

	private DataGridView gridPiteBroker2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn152;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn153;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn154;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn155;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn156;

	private DataGridView gridPiteBroker1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn157;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn158;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn159;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn160;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn161;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn162;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn163;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn164;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn165;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn166;

	private Panel panelPiteBrokerLisansKontrol;

	private Label label18;

	private Label labelPiteBrokerRefresh;

	private TextBox textPiteBrokerInterval;

	private TabPage tabPiteKurumHacim;

	private TextBox textPiteKurumHacimLevel;

	private DataGridView gridPiteKurumHacim2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn177;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn178;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn179;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn180;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn181;

	private DataGridView gridPiteKurumHacim1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn182;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn183;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn184;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn185;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn186;

	private Label labelPiteKurumHacimStatus;

	private DateTimePicker datetimePiteKurumHacim2;

	private DateTimePicker datetimePiteKurumHacim1;

	private DataGridView gridPiteKurumHacim;

	private Panel panel7;

	private RadioButton radioPiteKurumHacimLot0;

	private RadioButton radioPiteKurumHacimLot1;

	private Label label20;

	private TextBox textPiteKurumHacimSearch;

	private Panel panelPiteKurumHacimSummary;

	private Panel panelPiteBrokerSummary;

	private TextBox textPiteKurumHacimKurumLevel;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn167;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn168;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn169;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn170;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn171;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn172;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn173;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn174;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn175;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn176;

	private Panel panelPiteKurumHacimLisansKontrol;

	private Label label28;

	private TabPage tabPitePGC;

	private Button buttonPitePGCDownload;

	private Panel panel8;

	private RadioButton radioButtonPitePGCLot0;

	private RadioButton radioButtonPitePGCLot1;

	private Label labelLoadStatus;

	private Label label29;

	private TextBox textSeviye;

	private DateTimePicker dtPicker2;

	private DateTimePicker dtPicker1;

	private Label lblLabelFark;

	private Label lblLabelNetHacim;

	private DataGridView gridAliciSaticiOzet;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn187;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn188;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn189;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn190;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn191;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn192;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn193;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn194;

	private DataGridView gridEndeksOzet;

	private DataGridViewTextBoxColumn KEY;

	private DataGridViewTextBoxColumn VALUE;

	private DataGridViewTextBoxColumn VALUE1;

	private DataGridViewTextBoxColumn VALUE2;

	private DataGridViewTextBoxColumn VALUE3;

	private DataGridView gridDistributionSeller;

	private DataGridView gridDistributionBuyer;

	private Label label30;

	private TextBox textSenetBul;

	private DataGridView gridStocks;

	private Label lblFiyatNetHacim;

	private Label lblFiyatFark;

	private Label label31;

	private TextBox textPitePGCInterval;

	private Panel panelPitePGCLisansKontrol;

	private Label label32;

	private Panel panelHacimViopFiltre;

	private ComboBox comboHacimViopPiyasa;

	private ComboBox comboHacimViopVadeliTip;

	private ComboBox comboHacimViopOpsiyonTip;

	private ComboBox comboHacimViopSozlesme;

	private Panel PanelPiteStocksSeansSec;

	private RadioButton radioPiteStockS2;

	private RadioButton radioPiteStockS1;

	private RadioButton radioPiteStockGun;

	private RadioButton radioPiteStock2TarihArasi;

	private RadioButton radioPiteStockTarihsel;

	private Panel panel9;

	private RadioButton radioButtonHAVIOP;

	private RadioButton radioButtonHAHisse;

	private MyButton myButtonYBOGuncelle;

	private RadioButton radioHacimAnaliziTarihArasi;

	private RadioButton radioHacimAnaliziTarihsel;

	private Button buttonPiteKurumHacimDownload;

	private RadioButton radioKurumHacimTarihArasi;

	private RadioButton radioKurumHacimTarihsel;

	private Label label37;

	private Label label38;

	private Label lblIslemFark2;

	private Label lblIslemFark1;

	private Label lblIslemSeller2;

	private Label lblIslemSeller1;

	private Label lblIslemBuyer2;

	private Label lblIslemBuyer1;

	private Label lblIslemMiktar2;

	private Label lblIslemMiktar1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn205;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn206;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn207;

	private DataGridViewTextBoxColumn Ayuzde;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn208;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn209;

	private DataGridViewTextBoxColumn Syuzde;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn210;

	private DataGridViewTextBoxColumn PGC;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn211;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn212;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn213;

	private MyPie chartStock1;

	private MyPie chartSellers2;

	private MyPie chartBuyers2;

	private MyPie chartBroker3;

	private MyPie chartPiteStock3;

	private MyPie chartPiteStock2;

	private MyPie chartPiteStock1;

	private MyPie chartPiteBroker2;

	private MyPie chartPiteBroker1;

	private MyPie chartSaticilar;

	private MyPie chartAlicilar;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn195;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn196;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn197;

	private DataGridViewTextBoxColumn slot;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn198;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn199;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn200;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn201;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn202;

	private DataGridViewTextBoxColumn lot;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn203;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn204;

	private MyPie chartDistributionStock3;

	private MyPie chartDistributionStock2;

	private MyPie chartDistributionStock1;

	private MyPie chartDistributionBroker2;

	private MyPie chartDistributionBroker1;

	private MyPie chartPiteKurumHacim2;

	private MyPie chartPiteKurumHacim1;

	private MyPie chartKurumHacim2;

	private MyPie chartKurumHacim1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn115;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn116;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn117;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn118;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn119;

	private DataGridViewTextBoxColumn Column22;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn70;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn72;

	private DataGridViewTextBoxColumn Column11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn75;

	private DataGridViewTextBoxColumn Column19;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn83;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn84;

	private DataGridViewTextBoxColumn Column10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn90;

	private DataGridViewTextBoxColumn Column18;

	private Http http2;

	private RadioButton rbTakasVarant;

	private RadioButton rbTakasHisse;

	private RadioButton rbTakasVarant2;

	private RadioButton rbTakasHisse2;

	private Panel panel10;

	private DataGridView gridPiteStock1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn136;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn137;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn138;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn139;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn140;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn141;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn142;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn143;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn144;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn145;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn146;

	private DataGridViewTextBoxColumn takasRT;

	private DataGridViewTextBoxColumn TksYuzde;

	private DataGridView gridPiteStock4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn125;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn126;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn127;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn128;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn129;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn130;

	private DataGridViewTextBoxColumn columnTksYuzdeT;

	private DataGridView gridPiteStock3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn131;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn132;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn133;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn134;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn135;

	private DataGridViewTextBoxColumn columnTksYuzdeS;

	private DataGridView gridPiteStock2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn120;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn121;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn122;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn123;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn124;

	private DataGridViewTextBoxColumn columnTksYuzdeA;

	private CheckBox chkPitePGCSadeceHisseler;

	private Panel panelHeader;

	private PictureBox pictureboxTwitter;

	private Label labelMinimizeWindow;

	private Label labelCloseWindow;

	private Label labelHeader;

	private TextBox textSaatBitirHisseKurum;

	private TextBox textSaatBaslaHisseKurum;

	private CheckBox checkSaatFiltreHisseKurum;

	private Button buttonApplyBroker;

	private Button buttonApplyVolume;

	private TextBox textSaatBitirHacimAnaliz;

	private TextBox textSaatBaslaHacimAnaliz;

	private CheckBox checkSaatFiltreHacimAnalizi;

	private Button buttonYeniHacimAnalizi;

	private Button buttonYeniHacimAnalizi2;

	private Panel panel11;

	private RadioButton radioButtonHisseAkdHS;

	private RadioButton radioButtonHisseAkdVS;

	private CheckBox checkBoxVadeBasi;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formClearingBank()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formClearingBank_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formClearingBank_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formClearingBank_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonApply1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonDelete_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonDownload_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonDownload2_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonDownloadKurum1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonDownloadKurum2_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonDistributionBrokerDownload_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonDistributionStockDownload_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonKademeHesapla1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonKurumHacimDownload_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonSave_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonStockSelect_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonPiteKademeHesapla_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonPiteStockApply_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonPiteStockDownload_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonPiteBrokerStockSelect_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonPitePGCDownload_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkSaatFiltresi1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkPiteStockSaatFiltresi_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chkPitePGCSadeceHisseler_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBoxVadeBasi_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBroker3_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBroker4_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboStock1_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboStock2_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboDistributionBrokerName_SelectedValueChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboDistributionStockSymbol_SelectedValueChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboPiteStockSymbol_SelectedValueChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboPiteBrokerName_SelectedValueChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeBroker3_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeDistributionBroker_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeDistributionStock_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeEnd2_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeEnd4_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeKurumHacim_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeStart2_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeStart4_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeStock1_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimePiteStock1_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimePiteBroker1_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimePiteKurumHacim1_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dtPicker1_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void grid_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridBuyers2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridBroker3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridBroker3_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridBroker4_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridBroker4_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridDistributionBroker1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridDistributionBroker2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridDistributionBroker3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridDistributionBroker1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridDistributionStock1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridDistributionStock2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridDistributionStock3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridDistributionStock4_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridDistributionStock1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKurumHacim1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKurumHacim1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKurumHacim2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKurumHacim3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKurumHacim4_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridForeign_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridForeign_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridGroup1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridGroup2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridLevel1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridLevel3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridSellers2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridStock1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridStock1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridStock2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridStock2_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridPiteStock1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridPiteStock2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridPiteStock3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridPiteStock4_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridPiteStock1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridPiteBroker1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridPiteBroker2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridPiteBroker3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridPiteBroker1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridPiteKurumHacim_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridPiteKurumHacim_SelectionChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridPiteKurumHacim1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridPiteKurumHacim2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridPiteKurumHacim_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridStocks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridStocks_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridStocks_SelectionChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void http1_OnEndTransfer(object sender, HttpEndTransferEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void http1_OnTransfer(object sender, HttpTransferEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void http1_OnError(object sender, HttpErrorEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void http1_OnRedirect(object sender, HttpRedirectEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lstBoxGroup_SelectedValueChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuBMP_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuClose_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuExcel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuJPG_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelDistributionBrokerSummary_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelPiteBrokerSummary_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelStockChangeSummary_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelKurumHacimSummary_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioDistributionBrokerLot0_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioDistributionStockLot0_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioDistributionStockPasta_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioLot_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioPiyasaViop_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioPiyasaHisse_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioButtonHacimHisse_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioButtonHacimViop_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioKDagilimHisse_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioKDagilimViop_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioPiteStockPasta_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioPiteStockS1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioPiteStockLot0_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioPiteStockTarihSecimi_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioPiteBrokerLot1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioPiteKurumHacimLot0_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioButtonPitePGCLot0_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rbTakas_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textDistributionBrokerSearch_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textDistributionStockSearch_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textKurumHacimSymbolSearch_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSearch1_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSearch2_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSearch3_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSearch4_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textPiteBrokerLevel_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textPiteBrokerSearch_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textPiteBrokerInterval_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textDistributionBrokerLevel_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textDistributionStockLevel_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textPiteStockLevel_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textPiteStockInterval_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textPiteStockSearch_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textPiteKurumHacimLevel_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textPiteKurumHacimSearch_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textPiteKurumHacimKurumLevel_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSeviye_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textPitePGCInterval_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSenetBul_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerPite_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerDownload_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ConvertOldToNew(string filenameX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerRefresh_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DownloaderProgressChanged(object sender, DownloadProgressChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DownloaderCompleted(object sender, AsyncCompletedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CheckStockVip(string Sembol)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayDistributionBroker()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayPiteBroker()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayDistributionStock()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayPiteStock()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayData3()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayData4()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayForeignChart()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayForeignGrid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayKurumHacim()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool SeansDisiBist()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ViopEskiSenetPazarKontrol(List<string> sembolListx, string pazarX, string AltPazarX, string sembolX)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayPiteKurumHacim()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayPitePGC()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillDistributionBroker()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillDistributionStock()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillDistributionStockSymbol()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillPiteBroker()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillPiteStock()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillKurumHacim()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillPiteKurumHacim()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillPiteKurumHacimSenetler()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillGroup()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillPitePGC()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fillTakasSymbols(ComboBox cbox)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fillAKDSymbols(ComboBox cbox)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SelectDistributionBrokerDisplayType()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<DistributionRecord> GetDistributionList(int statusX, DateTime dateX, string stockX, string brokerX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ReadData(string date)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowGroupBrokers(string xGroup)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowMenu(object sender, Point pointX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AdjustPiteWindowDate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeSymbol(string strSymbol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void aliciSaticiGridleriDoldur(string stockname)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisplayData1()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisplayData2()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GetStockDayData(ref TypeStock stockitemX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GetStockDayGroupData(ref TypeStock xStockClass)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GetStockDifData(ref TypeStock stockitemX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GetBrokerData(ref TypeBroker xBrokerClass)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private StockBasedRecord getTKSKurum(List<StockBasedRecord> dataList, string kurumKodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessMenuMessage(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowKurumHacim()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowPGC()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowStockDistribution(string symbolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowStockPite(string symbolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboHacimViopPiyasa_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboPiteStockSymbol_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboPiteStockSymbol_DropDown(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboPiteStockSymbol_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioButtonHAHisse_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioButtonHAVIOP_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonYBOGuncelle__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioHacimAnaliziTarihArasi_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonPiteKurumHacimDownload_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioKurumHacimTarihArasi_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioHacimAnaliziTarihArasi_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridStocks_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelHeader_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelHeader_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pictureboxTwitter_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelMinimizeWindow_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelCloseWindow_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelCloseWindow_MouseHover(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelCloseWindow_MouseLeave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkSaatFiltreHisseKurum_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonApplyBroker_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonApplyVolume_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkSaatFiltreHacimAnalizi_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonYeniHacimAnalizi_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioButtonHisseAkdSembolSec_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static formClearingBank()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		Reference = null;
		Date1 = "";
		Date2 = "";
		Disclamer1 = "mkk'dan alınan ve takasbank tarafından ";
		Disclamer2 = " ve saat ";
		Disclamer3 = " itibariyle yayınlanan menkul kıymet bazında hesap bakiyeleri...   ";
		Disclamer4 = "Not 1 - her kıymet için verilen toplam bilgileri, mkk nezdinde kayden izlenen hisse senedi toplamlarıdır...   ";
		Disclamer5 = "Not 2 - hisse senedi bazında ve üye detayında verilen saklama bakiyelerinin toplamı ile takasbank tarafından verilen toplam...   ";
		Disclamer6 = "(kapalı aracı kurumlar için açılan hesaplar, icralı hesaplar ve takas işlemlerinden bağımsız olarak Takasbank tarafından kullanılmak üzere açılan hesaplar) kaynaklanmaktadır.";
		CoordLeft = 0;
		CoordTop = 0;
		PiteBool = false;
		PitBool = false;
		VitBool = false;
		ViopVadeBasiBool = false;
		PrevViopStartDate = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
		FileRecordList = new List<FileRecord>();
		DateDistributionStock1 = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.oHGUaoueC);
		DateDistributionStock2 = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.oHGUaoueC);
		DatePiteStock1 = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.oHGUaoueC);
		DatePiteStock2 = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.oHGUaoueC);
		DistributionStockAmoutType = 0;
		PiteStockAmoutType = 1;
		DistributionStockMostCount = 5;
		PiteStockMostCount = 5;
		SymbolFilter = "Tüm Semboller";
		SymbolFilterPiteBroker = "Tüm Semboller";
		DateDistributionBroker1 = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.oHGUaoueC);
		DateDistributionBroker2 = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.oHGUaoueC);
		DistributionBrokerAmoutType = 1;
		PiteBrokerAmoutType = 1;
		PiteKurumHacimAmoutType = 1;
		DistributionBrokerMostCount = 5;
		PiteBrokerMostCount = 5;
		PiteKurumHacimMostCount = 5;
		DateKurumHacim1 = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.oHGUaoueC);
		DateKurumHacim2 = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.oHGUaoueC);
		KurumHacimMostCount = 5;
		KurumHacimMostKurumCount = 5;
		WindowWidth = 1050;
		WindowHeight = 610;
		WindowTop = 50;
		WindowLeft = 50;
		LastYBODownloadDate = "";
	}
}
