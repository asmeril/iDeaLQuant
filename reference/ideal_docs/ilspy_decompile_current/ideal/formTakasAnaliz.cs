using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using dg3ypDAonQcOidMs0w;
using nsoftware.IPWorks;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class formTakasAnaliz : Form
{
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

	public class StockAllSymbolRecord
	{
		public string Stock;

		public double Price1;

		public double Price2;

		public double DifLot;

		public double DifPercent;

		public double OthterDifLot;

		public double OthterDifPercent;

		public double BuyerNet;

		public double SellerNet;

		public double BuyersTopLot1;

		public double BuyersTopLot2;

		public double SellersTopLot1;

		public double SellersTopLot2;

		public double DifTotalInc;

		public double DifTotalDec;

		public double SenetSayisi;

		public double FDoran;

		public string Pazar;

		public Dictionary<string, StockAllBrokerRecord> BrokerDictionary;

		public double TotalLot1
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

		public double TotalLot2
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
		public StockAllSymbolRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static StockAllSymbolRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class StockAllBrokerRecord
	{
		public string Broker;

		public double Lot1;

		public double Lot2;

		public double DifLot;

		public double DifPercent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Calculate()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StockAllBrokerRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static StockAllBrokerRecord()
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

	public class TypeStockAll
	{
		public string Date1;

		public string Date2;

		public string TimeOfData;

		public int LevelCount;

		public bool LotOrTL;

		public Dictionary<string, StockAllSymbolRecord> SymbolDictionary;

		public string SymbolFilter
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
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
		public TypeStockAll()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TypeStockAll()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private class TypeSkyt
	{
		public string sembolx;

		public decimal bireyselVal;

		public decimal bireyselOran;

		public decimal kurumsalVal;

		public decimal kurumsalOran;

		public static int SortIndex;

		public static bool SortAscending;

		public static Color BackColorB;

		public static Color BackColorK;

		public static Dictionary<string, TypeSkyt> date1Dict;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TypeSkyt()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TypeSkyt()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			WP6RZJql8gZrNhVA9v.w65ov7siki();
			hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
			SortIndex = 0;
			SortAscending = false;
			BackColorB = c8dRspTBommxL8GMHQ4.r7iItWL60(200, 255, 200, c8dRspTBommxL8GMHQ4.BpHT9nA4Kq);
			BackColorK = c8dRspTBommxL8GMHQ4.r7iItWL60(255, 200, 200, c8dRspTBommxL8GMHQ4.BpHT9nA4Kq);
			date1Dict = new Dictionary<string, TypeSkyt>();
		}
	}

	private class TypeSys
	{
		public string Sembol;

		public decimal YatirimciSayisi;

		public static int SortIndex;

		public static bool SortAscending;

		public static Dictionary<string, TypeSys> date1Dict;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TypeSys()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TypeSys()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			WP6RZJql8gZrNhVA9v.w65ov7siki();
			hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
			SortIndex = 0;
			SortAscending = false;
			date1Dict = new Dictionary<string, TypeSys>();
		}
	}

	private class TypeTakasToplam
	{
		public string Symbol;

		public string Seri;

		public double Lot;

		public double NumberOfShares;

		public double PublicRatio;

		public double MarketValue;

		public double MarketValueOfShares;

		public static int SortIndex;

		public static bool SortAscending;

		public static List<TypeTakasToplam> FileRecordToplamList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TypeTakasToplam()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TypeTakasToplam()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			WP6RZJql8gZrNhVA9v.w65ov7siki();
			hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
			SortIndex = 0;
			SortAscending = false;
			FileRecordToplamList = new List<TypeTakasToplam>();
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass136_0
	{
		public formTakasAnaliz _003C_003E4__this;

		public string datex;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass136_0()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003CDisplaySYKT_003Eb__0()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec__DisplayClass136_0()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass137_0
	{
		public formTakasAnaliz _003C_003E4__this;

		public string datex;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass137_0()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003CDisplaySYS_003Eb__0()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec__DisplayClass137_0()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass139_0
	{
		public string datex;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass139_0()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003CDisplayTakasToplam_003Eb__0()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec__DisplayClass139_0()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CDisplaySYKT_003Ed__136 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public bool fillBool;

		public string datex;

		public formTakasAnaliz _003C_003E4__this;

		private _003C_003Ec__DisplayClass136_0 _003C_003E8__1;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CDisplaySYKT_003Ed__136()
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
		static _003CDisplaySYKT_003Ed__136()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CDisplaySYS_003Ed__137 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public bool fillBool;

		public string datex;

		public formTakasAnaliz _003C_003E4__this;

		private _003C_003Ec__DisplayClass137_0 _003C_003E8__1;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CDisplaySYS_003Ed__137()
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
		static _003CDisplaySYS_003Ed__137()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CDisplayTakasToplam_003Ed__139 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public bool fillBool;

		public formTakasAnaliz _003C_003E4__this;

		private _003C_003Ec__DisplayClass139_0 _003C_003E8__1;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CDisplayTakasToplam_003Ed__139()
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
		static _003CDisplayTakasToplam_003Ed__139()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CFillTakasIst_003Ed__147 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public string sembolx;

		public formTakasAnaliz _003C_003E4__this;

		private DateTime _003Ccurrdate_003E5__1;

		private string _003Cdate1_003E5__2;

		private string _003CfilenameSytk1_003E5__3;

		private string _003CfilenameSys_003E5__4;

		private TypeSkyt _003Csykt_003E5__5;

		private Exception _003Cerror_003E5__6;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CFillTakasIst_003Ed__147()
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
		static _003CFillTakasIst_003Ed__147()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public static formTakasAnaliz Referans;

	public static bool BolunmeEtkisi;

	public static bool BolunmeEtkisiSD;

	private WebClient Downloader;

	private Dictionary<string, string> DownloadDictionary;

	public string ActiveSymbol;

	private DataGridView ActiveGrid;

	private string LastFastTakasSymbol;

	public static string Disclamer1;

	public static string Disclamer2;

	public static string Disclamer3;

	public static string Disclamer4;

	public static string Disclamer5;

	public static string Disclamer6;

	private string FormHeader;

	private string FormCaption;

	private int TabSelectedIndex;

	private static List<FileRecord> FileRecordList;

	private static string TimeOfData;

	private string TakasStockSymbol;

	private TypeStock StockDayItem;

	private TypeStock StockDifItem;

	private TypeStockAll StockAllDifffItem;

	private TypeBroker BrokerDayInst;

	private TypeBroker BrokerDifInst;

	private cxDataGrid.SortRecord SortParamStock1;

	private cxDataGrid.SortRecord SortParamStock2;

	private cxDataGrid.SortRecord SortAllStockDiff;

	private cxDataGrid.SortRecord SortParamBroker3;

	private cxDataGrid.SortRecord SortParamBroker4;

	private IContainer components;

	private Panel panelHeader;

	private Label labelMinimizeWindow;

	private Label labelCloseWindow;

	private Label label4;

	private TabPage tabTakas;

	private TabControl tab;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private RadioButton rbTakasVarant;

	private RadioButton rbTakasHisse;

	private MyPie chartStock1;

	private Label label7;

	private Button buttonDownload;

	private Label lblStockClose1;

	private DateTimePicker datetimeStock1;

	private ComboBox comboStock1;

	private TextBox textSearch1;

	private DataGridView gridGroup1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;

	private DataGridView gridLevel1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;

	private DataGridView gridStock1;

	private DataGridViewTextBoxColumn No;

	private DataGridViewTextBoxColumn AraciKurum;

	private DataGridViewTextBoxColumn TakasLot;

	private DataGridViewTextBoxColumn TakasYuzde;

	private DataGridViewTextBoxColumn TakasTL;

	private Label lblDisclaimer;

	private Timer timerDownload;

	private Http http1;

	private Timer timerRefresh;

	private TabPage tabTakasStock2;

	private Panel panel10;

	private RadioButton rbTakasHisse2;

	private RadioButton rbTakasVarant2;

	private Panel panelStockChangeSummary;

	private Button buttonDownload2;

	private Label label8;

	private DataGridView gridSellers2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;

	private DataGridView gridBuyers2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;

	private DateTimePicker datetimeEnd2;

	private DateTimePicker datetimeStart2;

	private ComboBox comboStock2;

	private TextBox textSearch2;

	private DataGridView gridGroup2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn Column2;

	private DataGridViewTextBoxColumn Column3;

	private DataGridView gridStock2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;

	private DataGridViewTextBoxColumn Fark;

	private DataGridViewTextBoxColumn colTakas2Yuzde;

	private DataGridViewTextBoxColumn ColDif2;

	private MyPie chartSellers2;

	private MyPie chartBuyers2;

	public ContextMenuStrip menu;

	private ToolStripMenuItem menuExcel;

	private ToolStripMenuItem menuJPG;

	private ToolStripMenuItem menuBMP;

	private ToolStripSeparator toolStripSeparator5;

	private ToolStripMenuItem menuClose;

	private TabPage tabTumSenetDegisim;

	private Button buttonSenetlerDegisimIndir;

	private DateTimePicker dtStocksAllEnd;

	private DateTimePicker dtStocksAllStart;

	private DataGridView gridTumSenetDegisim;

	private Button buttonStockSelect;

	private Label labelSenetlerDegisim;

	private Label label1;

	private NumericUpDown numericSenetlerDegisim;

	private Button buttonSenetlerDegisimHesapla;

	private Label label2;

	private TextBox textSenetlerDegisim;

	private DataGridView gridTumSenetDegisimSatanlar;

	private DataGridView gridTumSenetDegisimAlanlar;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;

	private RadioButton radioTL;

	private RadioButton radioLot;

	private TabPage tabTakasBroker1;

	private MyPie chartBroker3;

	private Button buttonDownloadKurum1;

	private Label label9;

	private Label lblRatio3;

	private Label lblClearingTotalTL3;

	private Label lblBrokerTotalTL3;

	private Label label6;

	private Label label5;

	private Label label3;

	private DataGridView gridLevel3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn66;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn67;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn68;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn69;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn70;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn71;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn72;

	private TextBox textSearch3;

	private ComboBox comboBroker3;

	private DateTimePicker datetimeBroker3;

	private DataGridView gridBroker3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn73;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn74;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn75;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn76;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn77;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn78;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn79;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn80;

	private DataGridViewTextBoxColumn Column4;

	private TabPage tabTakasBroker2;

	private Button buttonDownloadKurum2;

	private Label label10;

	private TextBox textSearch4;

	private DateTimePicker datetimeEnd4;

	private DateTimePicker datetimeStart4;

	private ComboBox comboBroker4;

	private DataGridView gridBroker4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn81;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn82;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn83;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn84;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn85;

	private DataGridViewTextBoxColumn Column5;

	private DataGridViewTextBoxColumn Column6;

	private DataGridViewTextBoxColumn Column7;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn86;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn87;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn88;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;

	private CheckBox checkBolunmeEtkisi;

	private Panel panelTakasFast;

	private Panel panel1;

	private Label lblPanelHesapEditClose;

	private DateTimePicker dateTimeFastTakas;

	private DataGridView gridFastTakas;

	private Label label11;

	private Label labelfastTakasSymbol;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn89;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn90;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn91;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn92;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn93;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;

	private DataGridViewTextBoxColumn DigerFark;

	private DataGridViewTextBoxColumn TAlan1;

	private DataGridViewTextBoxColumn SenetSayisi;

	private DataGridViewTextBoxColumn FDoran;

	private DataGridViewTextBoxColumn Pazar;

	private DataGridViewTextBoxColumn FastTakas;

	private TabPage tabSYKT;

	private DataGridView gridSYKT;

	private DateTimePicker dtSYKT1;

	private Label label12;

	private TextBox textSYKTSembolAra;

	private CheckBox checkBolunmeEtkisiSD;

	private TabPage tabSYS;

	private DataGridView gridSYS;

	private DateTimePicker dtSYS1;

	private Label label13;

	private TextBox textSYSSembolAra;

	private Button buttonSYKTIndir;

	private Button buttonSYSIndir;

	private TextBox textKurumsalYatDeg;

	private Label labeKurumsalYatDeg;

	private TextBox textBireyselYatDeg;

	private Label labeBireyselYatDeg;

	private TextBox textYatirimciSayisi;

	private Label labelYatirimciSayisi;

	private TextBox textBireyselYatOran;

	private Label labeBireyselYatOran;

	private TextBox textKurumsalYatOran;

	private Label labeKurumsalYatOran;

	private Label labeltakaistaciklama;

	private Button buttonSYSExcelAktar;

	private Button buttonSYKTExcelAktar;

	private TabPage tabTakasToplam;

	private DataGridView gridTakasToplam;

	private DateTimePicker dtTakasToplam;

	private Panel panel2;

	private RadioButton rbTT_Hisse;

	private RadioButton rbTT_Tum;

	private RadioButton rbTT_Varant;

	private Label label14;

	private TextBox textTTSembolAra;

	private Button buttonTTExcelAktar;

	private LoadingButton LoadingButton1;

	private Chart chartSYS;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn100;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn101;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn102;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn103;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn104;

	private DataGridViewTextBoxColumn Column_TakasToplam;

	private DataGridViewTextBoxColumn ColumnTakasToplamSenetSay;

	private DataGridViewTextBoxColumn ColumnTakasToplamHalkaAciklik;

	private DataGridViewTextBoxColumn ColumnTakasToplamPiyasaDegeri;

	private DataGridViewTextBoxColumn ColumnTakasToplamFiiliDolasimPiyasaDegeri;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn94;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn95;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn96;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn98;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn97;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn99;

	private DataGridViewImageColumn Column8;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formTakasAnaliz()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTakasAnaliz_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTakasAnaliz_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTakasAnaliz_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTakasAnaliz_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTakasAnaliz_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTakasAnaliz_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTakasAnaliz_FormClosed(object sender, FormClosedEventArgs e)
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
	private void buttonAllDownload_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonTTExcelAktar_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonExcelAktar_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonSenetlerDegisimIndir_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonSenetlerDegisimHesapla_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonStockSelect_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBolunmeEtkisi_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBolunmeEtkisiSD_CheckedChanged(object sender, EventArgs e)
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
	private void comboStock1_KeyUp(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboStock1_SelectedValueChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboStock2_SelectedValueChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboStock2_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeEnd2_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeStart2_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeStock1_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeBroker3_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeEnd4_CloseUp(object sender, EventArgs e)
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
	private void gridBuyers2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
	private void gridFastTakas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
	private void gridSYKT_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridSYS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridSYKT_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridSYS_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridTakasToplam_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridTakasToplam_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridTumSenetDegisim_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridTumSenetDegisim_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridTumSenetDegisim_SelectionChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridTumSenetDegisimAlanlar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridTumSenetDegisimSatanlar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void grid_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelCloseWindow_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelMinimizeWindow_Click(object sender, EventArgs e)
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
	private void numericSenetlerDegisim_KeyPress(object sender, KeyPressEventArgs e)
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
	private void panelStockChangeSummary_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioLot_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rbTakas_Click(object sender, EventArgs e)
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
	private void textSenetlerDegisim_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSYKTSembolAra_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSYSSembolAra_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerDownload_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerRefresh_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboStock1_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tab_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tab_DrawItem(object sender, DrawItemEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApiServerMessageReceived(string cmdx, string messagex)
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
	public void ChangeSymbol(string strSymbol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeTabIndex(int index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayData1()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayData2()
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
	private void DisplayDataStocksAll()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CDisplaySYKT_003Ed__136))]
	private Task DisplaySYKT(bool fillBool, string datex)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CDisplaySYS_003Ed__137))]
	private Task DisplaySYS(bool fillBool, string datex)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplaySYSChart(SYS_Chart_Response jsonobj)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDisplayTakasToplam_003Ed__139))]
	[DebuggerStepThrough]
	private Task DisplayTakasToplam(bool fillBool)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillAllSymbolDiff()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillTakasIstAciklama(string datex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillSYKT(int columnIndex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillSYS(int columnIndex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillTakasToplam(int columnIndex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillAllSymbolsDiffBrokers(string sembolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fillTakasSymbols(ComboBox cbox)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CFillTakasIst_003Ed__147))]
	private void FillTakasIst(string sembolx)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GetBrokerData(ref TypeBroker xBrokerClass)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DateTime GetProperDateForSYSKT()
	{
		return (DateTime)(object)null;
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
	public static void GetStockAllDifData(ref TypeStockAll stockitemX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetStockDayData(ref TypeStock stockitemX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowMenu(object sender, Point pointX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessMenuMessage(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReadData(string date)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReadDataToplams(string date)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResizeWindow()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowWindow()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowWindow(int tabindex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TextSenetlerDegisimSelectAgain()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ToggleTakasFast(bool showBool)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridTumSenetDegisim_CellClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowFastTakas(string symbolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lblPanelHesapEditClose_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dateTimeFastTakas_ValueChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dtSYS1_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dtSYKT1_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rbTT_Hisse_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dtTakasToplam_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textTTSembolAra_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadingButton1_Click(object sender, EventArgs e)
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
	static formTakasAnaliz()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		Referans = null;
		BolunmeEtkisi = false;
		BolunmeEtkisiSD = false;
		Disclamer1 = "MKK'dan alınan ve takasbank tarafından ";
		Disclamer2 = " ve saat ";
		Disclamer3 = " itibariyle yayınlanan menkul kıymet bazında hesap bakiyeleri";
		Disclamer4 = "\nNot 1 - her kıymet için verilen toplam bilgileri, MKK nezdinde kayden izlenen hisse senedi toplamlarıdır.";
		Disclamer5 = "\nNot 2 - hisse senedi bazında ve üye detayında verilen saklama bakiyelerinin toplamı ile takasbank tarafından verilen toplam ";
		Disclamer6 = "(kapalı aracı kurumlar için açılan hesaplar, icralı hesaplar ve takas işlemlerinden bağımsız olarak Takasbank tarafından kullanılmak üzere açılan hesaplar) kaynaklanmaktadır.";
		FileRecordList = new List<FileRecord>();
	}
}
