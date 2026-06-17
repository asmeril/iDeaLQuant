using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;
using nsoftware.IPWorks;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class formBalanceSheet : Form
{
	private class BalanceSheetRecord
	{
		public string FieldName;

		public string FieldCode;

		public int FieldColor;

		public int FieldSummary;

		public string[] Data;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BalanceSheetRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static BalanceSheetRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private class SectoralRecord
	{
		public string Symbol;

		public double[] Data;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SectoralRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SectoralRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private class RatioRecord
	{
		public string Symbol;

		public string Period;

		public double LastPrice;

		public double PriceEarningRatio;

		public double PriceEarningValue;

		public double Capital;

		public double NetProfit;

		public double NetProfitMultiplier;

		public double MarketValue;

		public double BookValue;

		public double TotalAssets;

		public double NetSales;

		public double OperationProfit;

		public double CurrentRatio;

		public double ShortTermDebt;

		public double TotalDebt;

		public double MarketvalDivideBookval;

		public double NetProfitDivideAssets;

		public double NetProfitDivideCapital;

		public double MarketvalDivideNetsales;

		public double MarketvalDivideOperationprofit;

		public double NetProfitDivideNetSales;

		public double OperationProfitDivideNetSales;

		public double OperationProfitDivideShortTermDebt;

		public double ShortTermDebtDivideTotalAssets;

		public double ShortTermDebtDivideTotalDebt;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RatioRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static RatioRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private class TemelRecord
	{
		public string Symbol;

		public string Period;

		public double LastPrice;

		public double PriceEarningRatio;

		public double PriceEarningValue;

		public double Capital;

		public double OzCapital;

		public double NetProfit;

		public double MarketValue;

		public double BookValue;

		public double OzSermayeKarlilik;

		public double PiyasaDegerDefterDeger;

		public double PublicRatio;

		public double NumberOfShares;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TemelRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TemelRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private class SplitRecord
	{
		public string Date;

		public string Symbol;

		public double WithPayment;

		public double WithoutPayment;

		public double Dividend;

		public double Ratio;

		public string Type;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SplitRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SplitRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private class HisseRasyoRecord
	{
		public string Donem;

		public string Symbol;

		public double CariOran;

		public double LikitOran;

		public double NakitOran;

		public double KaldiracOran;

		public double BorcOzsermayeOran;

		public double MadDurVarOzserOran;

		public double KVadeBorTopBorOran;

		public double AlacakDevHiz;

		public double AlacakTahsilSuresi;

		public double StokDevirHiz;

		public double StokKalmaSure;

		public double NetIsSerDevHiz;

		public double OzkaynakDevHiz;

		public double AktifDevHiz;

		public double TicBorcDevHiz;

		public double TicBorcOdeSure;

		public double BurutKarMarj;

		public double NetKarMarj;

		public double FaliyetKarMarj;

		public double AktifKarlilik;

		public double OzSerKarlilik;

		public double EsasFaaliyetKari;

		public double FAVOK;

		public double NetDonemKar;

		public double NetIsletmeSer;

		public string sector;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HisseRasyoRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static HisseRasyoRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public static formBalanceSheet Referance;

	private WebClient Downloader;

	private Dictionary<string, string> DownloadDictionary;

	private string[] PeriodArray;

	public string ActiveSymbol;

	private string StockType;

	private string BalanceSheetType;

	private string FieldDefFileName;

	private string FormCaption;

	private string ActiveMenu;

	private Dictionary<string, string> FieldCodesCompany;

	private Dictionary<string, string> FieldCodesBank;

	private Dictionary<string, string> FieldCodesInsurance;

	private string SelectedCatagory;

	private string sectorcode;

	private string SelectedFieldCode;

	private string SelectedCompanyField;

	private string SelectedBankField;

	private string SelectedInsuranceField;

	private BalanceSheetRecord[] BalanceSheetArray;

	private int BalanceSheetCount;

	private Dictionary<string, int> FieldMapDict;

	private Dictionary<string, SectoralRecord> SectoralDict;

	private cxDataGrid.SortRecord SortParamSectoral;

	private cxDataGrid.SortRecord SortParamRatio;

	private cxDataGrid.SortRecord SortParamBasic;

	private cxDataGrid.SortRecord SortParamSplit;

	private Dictionary<string, List<HisseRasyoRecord>> DictHisseRasyo;

	private DataGridView ActiveGrid;

	private static int WindowWidth;

	private static int WindowHeight;

	private static int WindowTop;

	private static int WindowLeft;

	private static string flag;

	private static string flag1;

	private static string flag2;

	private IContainer components;

	private Timer timerDownload;

	private Http http1;

	public ContextMenuStrip menu;

	private ToolStripMenuItem menuExcel;

	private ToolStripSeparator toolStripSeparator5;

	private ToolStripMenuItem menuClose;

	private TabPage tabPage4;

	private Button buttonSelectSymbol4;

	private Label label10;

	private Label label6;

	private Label label7;

	private ComboBox comboboxSector4;

	private TextBox textboxSearch4;

	private DataGridView gridBalanceSheet4;

	private TabPage tabPage3;

	private Button buttonSelectSymbol3;

	private Label label8;

	private Label label3;

	private Label label5;

	private ComboBox comboboxSector3;

	private TextBox textboxSearch3;

	private DataGridView gridBalanceSheet3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;

	private DataGridViewTextBoxColumn Column3;

	private DataGridViewTextBoxColumn Column4;

	private DataGridViewTextBoxColumn Column5;

	private DataGridViewTextBoxColumn Column6;

	private DataGridViewTextBoxColumn Column7;

	private DataGridViewTextBoxColumn Column8;

	private DataGridViewTextBoxColumn Column9;

	private TabPage tabPage2;

	private Label label2;

	private Label label4;

	private ComboBox comboboxSector2;

	private TextBox textboxSearch2;

	private DataGridView gridBalanceSheet2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

	private Label label1;

	private ComboBox comboboxField2;

	private TabPage tabPage1;

	private Button buttonDownload;

	private Panel panel1;

	private RadioButton optionKonsolide2;

	private RadioButton optionKonsolide1;

	private ComboBox comboboxDate5;

	private ComboBox comboboxDate4;

	private ComboBox comboboxDate3;

	private ComboBox comboboxDate2;

	private ComboBox comboboxDate1;

	private DataGridView gridBalanceSheet1;

	private DataGridViewTextBoxColumn Column2;

	private DataGridViewTextBoxColumn gridColNo;

	private DataGridViewTextBoxColumn gridColField;

	private DataGridViewTextBoxColumn gridCol1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;

	private DataGridViewTextBoxColumn Fark;

	private DataGridViewTextBoxColumn colTakas2Yuzde;

	private ComboBox comboboxStock1;

	private TabControl tabBalanceSheet;

	private TabPage tabPage5;

	private DataGridView gridHisseRasyo;

	private ComboBox comboboxStock2;

	private Label lblHisseRasyoSektor;

	private Label labelLoadStatus;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;

	private DataGridViewTextBoxColumn Column10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;

	private DataGridViewTextBoxColumn OzsermayeKarOran;

	private DataGridViewTextBoxColumn Column11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;

	private DataGridViewTextBoxColumn PdDd;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formBalanceSheet()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBalanceSheet_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBalanceSheet_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBalanceSheet_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonDownload_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonSelectSymbol3_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonSelectSymbol4_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboboxDate1_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboboxField2_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboboxSector2_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboboxSector3_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboboxSector4_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboboxStock1_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboboxStock2_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridBalanceSheet1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridBalanceSheet1_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridBalanceSheet2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridBalanceSheet3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridBalanceSheet4_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridBalanceSheet2_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridBalanceSheet3_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridBalanceSheet4_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void http1_OnTransfer(object sender, HttpTransferEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void http1_OnEndTransfer(object sender, HttpEndTransferEventArgs e)
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
	private void optionKonsolide1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tabBalanceSheet_Selected(object sender, TabControlEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textboxSearch2_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textboxSearch3_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textboxSearch4_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerDownload_Tick(object sender, EventArgs e)
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
	private void DisplayData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplaySectoralData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayFinancialRatio()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayFundamentalInfo(string flag = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayHisseRasyo()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string DonemStrCevir(string donem)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReadHisseRasyo()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string SektorOrtHesapla(string sector, string donem, int Kalem, int dec)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowMenu(object sender, Point pointX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeSymbol(string symbolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessMenuMessage(string messageX)
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
	static formBalanceSheet()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		Referance = null;
		WindowWidth = 1200;
		WindowHeight = 512;
		WindowTop = 50;
		WindowLeft = 50;
		flag = "a";
		flag1 = "";
		flag2 = "";
	}
}
