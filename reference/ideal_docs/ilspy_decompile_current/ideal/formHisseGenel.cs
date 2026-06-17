using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class formHisseGenel : FormControl
{
	private class Record
	{
		public float Price;

		public byte Hour;

		public byte Minute;

		public byte Second;

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

	private class CollWith
	{
		public float Yuzde;

		public int ColWith;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CollWith()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static CollWith()
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

	private class TakasItem
	{
		public int Order;

		public string Broker;

		public double TotalLot;

		public double Percent;

		public double ValueTL;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TakasItem()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TakasItem()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public string AccountName;

	public string AccountNo;

	private cxButton EmirButtons;

	private string LocalOrderKey;

	private int EmirTipi;

	private int EmirMiktar;

	private bool EmirOnay;

	private Color GridBackColor;

	private Color GridForeColor;

	public string ActiveSymbol;

	public short PgcGosterim;

	private Font FontData;

	private Font FontBold;

	private Color ChartBackColor;

	private Color GridlineColor;

	private Color ChartForeColor;

	private Color UpColor;

	private Color DownColor;

	private Color LineColor;

	private Color PgcColor;

	private Color PanelBackColor;

	private Color PanelForeColor;

	private cxPage.Pgc PageParams;

	private string InitialSymbol;

	private int InitialLeft;

	private int InitialTop;

	private bool FormLoaded;

	private bool TopMostEnabled;

	private Font FontHeader;

	private Rectangle Rect1;

	private Rectangle Rect2;

	private string Str1;

	private cxBasic BasicItem;

	private Pen Pen1;

	private Pen Pen2;

	private SolidBrush Brush1;

	private List<Record> DataList;

	private double Max1;

	private double Min1;

	private double Inc1;

	private bool RedrawBool;

	private int LastPriceTime;

	private cxButton HeaderButtons;

	private bool FormActivated;

	private Color RelationalNewsColor;

	private string DrawStatus;

	private bool DrawStartedBool;

	private PgcTrendClass NewTrend;

	public static List<PgcTrendClass> TrendList;

	public static Color TrendColor;

	public static int Stil;

	public static int Kalinlik;

	public static bool ExtendRightBool;

	private List<FileRecord> FileRecordList;

	private string TimeOfData;

	private List<TakasItem> TakasLevelList;

	private IContainer components;

	private Timer timerRefresh;

	private Panel panelChart0;

	private Panel panelChart1;

	private TextBox textSymbolSearch;

	private Label labelLastPrice;

	private Label labelHLastPrice;

	private Label labelHBid;

	private Label labelBid;

	private Label labelHAsk;

	private Label labelAsk;

	private Label labelHOncKpn;

	private Label labelOncKpn;

	private Label labelHFark2;

	private Label labelFark2;

	private Label labelHFark1;

	private Label labelFark1;

	private Label labelHPDDD;

	private Label labelPDDD;

	private Label labelHDD;

	private Label labelDD;

	private Panel panelAktifPasif;

	private RadioButton radioBoxPgcTl;

	private RadioButton radioBoxPgcLot;

	private Label labelHPgc;

	private Label labelPgc;

	private Label labelHPgcAlisToplam;

	private Label labelPgcAlisToplam;

	private Label labelHPgcSatisToplam;

	private Label labelPgcSatisToplam;

	private Label labelHPgcOran;

	private Label labelPgcOran;

	private Label labelHMaksAlanKurum;

	private Label labelMaksAlanKurum;

	private Label labelHMaksAlanNet;

	private Label labelMaksAlanNet;

	private Label labelHMaksAlanYuzde;

	private Label labelMaksAlanYuzde;

	private Label labelHMaksAlanMaliyet;

	private Label labelMaksAlanMaliyet;

	private Label labelHMaksSatanMaliyet;

	private Label labelMaksSatanMaliyet;

	private Label labelHMaksSatanYuzde;

	private Label labelMaksSatanYuzde;

	private Label labelHMaksSatanNet;

	private Label labelMaksSatanNet;

	private Label labelHMaksSatanKurum;

	private Label labelMaksSatanKurum;

	private Label labelHEma5;

	private Label labelEma5;

	private Label labelHEma200;

	private Label labelEma200;

	private Label labelHEma100;

	private Label labelEma100;

	private Label labelHEma50;

	private Label labelEma50;

	private Label labelHEma20;

	private Label labelEma20;

	private Label labelHEma10;

	private Label labelEma10;

	private Label labelHFK;

	private Label labelFK;

	private Label labelHMarketValue;

	private Label labelMarketValue;

	private Label labelHProfit;

	private Label labelProfit;

	private Label labelHLow;

	private Label labelLow;

	private Label labelHHigh;

	private Label labelHigh;

	private Panel panelTakas;

	private Label labelHPivotDirenc;

	private Label labelPivotDirenc;

	private Label labelHPivot;

	private Label labelPivot;

	private Label labelHPivotDestek;

	private Label labelPivotDestek;

	private Panel panelportfoy;

	private Panel panelAccountName;

	private ComboBox comboAccountName;

	private Label textAccountName;

	private Panel panelAccountNo;

	private ComboBox comboAccountNo;

	private Label textAccountNo;

	private Label labelHAdet;

	private Panel panelEmir;

	private Label labelEmirBekle;

	private TextBox textEmirMiktar;

	private Panel panelDipZirve;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formHisseGenel(int leftX, int topX, string symbolX, cxPage.Pgc pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHisseGenel_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHisseGenel_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHisseGenel_Deactivate(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHisseGenel_DragDrop(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHisseGenel_DragEnter(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHisseGenel_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHisseGenel_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHisseGenel_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHisseGenel_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart0_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart0_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart0_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart0_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart0_MouseDoubleClick(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbolSearch_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbolSearch_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbolSearch_Leave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerRefresh_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BasicDataReceived(string symbolX, string updatetypeX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MessageReceived(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PortfolioReceived(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyPattern(cxPage.Pgc pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private double CalculateIncrement(double highval, double lowval, bool pricebool)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeColors(cxColorEditor coloritemX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] ConvertPageToByteArray()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessMenuMessage(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReadData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Repaint()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMainToolbarSymbol()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPageParams(cxPage.Pgc pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowMenu(object sender, Point pointX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawTrend(PgcTrendClass trend, string sembol, string panelname, Graphics grx)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart1_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillTakas()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillPivot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReadData(string date)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StringFormat CellHizala(string hizalastr)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelTakas_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHisseGenel_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboAccountName_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboAccountName_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboAccountNo_SelectedValueChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboAccountNo_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textAccountName_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textAccountNo_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelEmir_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelEmir_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelDipZirve_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelportfoy_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart1_MouseDown(object sender, MouseEventArgs e)
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
	static formHisseGenel()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		TrendList = new List<PgcTrendClass>();
		TrendColor = QydtveTePRRXd343nfj.r7iItWL60(QydtveTePRRXd343nfj.na2TZsWUEF);
		Stil = 0;
		Kalinlik = 1;
		ExtendRightBool = true;
	}
}
