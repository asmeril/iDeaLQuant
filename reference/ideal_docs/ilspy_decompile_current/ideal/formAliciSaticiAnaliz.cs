using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using dg3ypDAonQcOidMs0w;
using nsoftware.IPWorks;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class formAliciSaticiAnaliz : Form
{
	public delegate void ControlInvoker();

	public class stockDetails
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

	public class DistributionStockRecord
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

	public class stockRecord
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

	private Dictionary<string, string> DownloadDictionary;

	public static Dictionary<string, stockRecord> dictionaryStockRecod;

	public List<stockDetails> StockDetailsList;

	public double alicilarTum;

	public double alicilarX100;

	public double alicilarX050;

	public double alicilarX030;

	public double digeralicilarNet;

	public double saticilarTUM;

	public double saticilarX100;

	public double saticilarX050;

	public double saticilarX030;

	public double digersaticilarNet;

	public double toplamTUM;

	public double toplamX100;

	public double toplamX050;

	public double toplamX030;

	public double digerToplam;

	public int SortColoumn;

	public bool SortType;

	public string loadStatus;

	public bool acilis;

	public bool hacimType;

	private int gridStocksSelectedindex;

	private string FormCaption;

	private WebClient Downloader;

	private IContainer components;

	private DateTimePicker dtPicker1;

	private DateTimePicker dtPicker2;

	private DataGridView gridStocks;

	private Label label16;

	private TextBox textSeviye;

	private DataGridView gridDistributionSeller;

	private DataGridView gridDistributionBuyer;

	private DataGridView gridEndeksOzet;

	private Label labelLoadStatus;

	private Timer timerRefresh;

	private Panel panel1;

	private RadioButton radioTL;

	private RadioButton radioLot;

	private Chart chartAlicilar;

	private Chart chartSaticilar;

	private TextBox textSenetBul;

	private Label label1;

	private Label lblLabelNetHacim;

	private Label lblFiyatNetHacim;

	private Label lblLabelFark;

	private Label lblFiyatFark;

	private DataGridView gridAliciSaticiOzet;

	private DataGridViewTextBoxColumn KEY;

	private DataGridViewTextBoxColumn VALUE;

	private DataGridViewTextBoxColumn VALUE1;

	private DataGridViewTextBoxColumn VALUE2;

	private DataGridViewTextBoxColumn VALUE3;

	private ContextMenuStrip contextMgridStocks;

	private ToolStripMenuItem exceleAktarToolStripMenuItem;

	private DataGridViewTextBoxColumn Column2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

	private DataGridViewTextBoxColumn Column3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn70;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn72;

	private DataGridViewTextBoxColumn Column11;

	private DataGridViewTextBoxColumn slot;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn75;

	private DataGridViewTextBoxColumn Column19;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn83;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn84;

	private DataGridViewTextBoxColumn Column10;

	private DataGridViewTextBoxColumn lot;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn90;

	private DataGridViewTextBoxColumn Column18;

	private Button buttonDownload;

	private Timer timerDownload;

	private Http http1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn67;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn68;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn69;

	private DataGridViewTextBoxColumn Ayuzde;

	private DataGridViewTextBoxColumn Column16;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn71;

	private DataGridViewTextBoxColumn Syuzde;

	private DataGridViewTextBoxColumn Column17;

	private DataGridViewTextBoxColumn PGC;

	private DataGridViewTextBoxColumn Column8;

	private DataGridViewTextBoxColumn Column23;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn73;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formAliciSaticiAnaliz()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonDownload_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formAliciSaticiAnaliz_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dtPicker1_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dtPicker2_CloseUp(object sender, EventArgs e)
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
	private void gridAliciSaticiOzet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridEndeksOzet_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridEndeksOzet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridStocks_SelectionChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridStocks_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridStocks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void exceleAktarToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioLot_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioTL_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSenetBul_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSeviye_KeyPress(object sender, KeyPressEventArgs e)
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
	private void DownloaderProgressChanged(object sender, DownloadProgressChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DownloaderCompleted(object sender, AsyncCompletedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void anaGridDoldur()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AliciSaticiOzetDoldur()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void aliciSaticiGridleriDoldur(string stockname)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chartAlicilarDoldur()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chartSatiicilarDoldur()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void clearValues()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void endeksOzetDoldur()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void loadData()
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
	static formAliciSaticiAnaliz()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		dictionaryStockRecod = new Dictionary<string, stockRecord>();
	}
}
