using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal.View.ViewFon;

public class formFonGenel : FormControl
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

	private bool RefreshNeeded;

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

	private cxFon fonData;

	private Pen Pen1;

	private Pen Pen2;

	private SolidBrush Brush1;

	private double Max1;

	private double Min1;

	private double Inc1;

	private int chartGunSayisi;

	private bool RedrawBool;

	private int LastPriceTime;

	private cxButton HeaderButtons;

	private bool FormActivated;

	public string AccountName;

	public string AccountNo;

	private cxButton EmirButtons;

	private string LocalOrderKey;

	private int EmirTipi;

	private int EmirMiktar;

	private bool EmirOnay;

	private Color GridBackColor;

	private Label lblTracker;

	private VerticalLineAnnotation vertLine;

	private HorizontalLineAnnotation horLine;

	public static int Stil;

	public static int Kalinlik;

	public static bool ExtendRightBool;

	private IContainer components;

	private Timer timerRefresh;

	private Panel panelChart0;

	private Panel panelChart1;

	private TextBox textSymbolSearch;

	private Label labelLastPrice;

	private Label labelHLastPrice;

	private Label labelHBid;

	private Label labelPlatformIslemDurumu;

	private Label labelSonFiyatTarihiText;

	private Label labelSonFiyatTarihi;

	private Label labelHOncKpn;

	private Label labelOncKpn;

	private Label labelHFark2;

	private Label labelFark2;

	private Label labelHFark1;

	private Label labelFark1;

	private Label labelHAktifAdet;

	private Label labelAktifAdet;

	private Label labelHToplamAdet;

	private Label labelToplamAdet;

	private Panel panelAktifPasif;

	private RadioButton radioBoxPgcTl;

	private RadioButton radioBoxPgcLot;

	private Label labelHIsinKodu;

	private Label labelIsinKodu;

	private Label labelHPlatform;

	private Label labelPlatform;

	private Label labelHHalkaArzTarihi;

	private Label labelHalkaArzTarihi;

	private Label labelHKategori;

	private Label labelKategori;

	private Label labelEma5;

	private Label labelEma200;

	private Label labelEma100;

	private Label labelEma50;

	private Label labelEma20;

	private Label labelEma10;

	private Label labelHYillikYonetimUcreti;

	private Label labelYillikYonetimUcreti;

	private Label labelHFonBuyuklugu;

	private Label labelFonBuyuklugu;

	private Label labelHYatirimciSayisi;

	private Label labelYatirimciSayisi;

	private Label labelHLow;

	private Label labelLow;

	private Label labelHHigh;

	private Label labelHigh;

	private Label labelPivotDirenc;

	private Label labelPivot;

	private Label labelPivotDestek;

	private Panel panelportfoy;

	private Panel panelEmir;

	private Label labelEmirBekle;

	private TextBox textEmirMiktar;

	private Panel panelAccountNo;

	private ComboBox comboAccountNo;

	private Panel panelAccountName;

	private ComboBox comboAccountName;

	private Label labelHAdet;

	private Label textAccountNo;

	private Label textAccountName;

	private Label labelHPazarPayi;

	private Label labelHDolulukOrani;

	private Label labelPazarPayi;

	private Label labelDolulukOrani;

	private Label labelHMaxSatisMik;

	private Label labelMaxSatisMik;

	private Label labelHMaxAlisMik;

	private Label labelMaxAlisMik;

	private Label labelHMinSatisMik;

	private Label labelMinSatisMik;

	private Label labelHMinAlisMik;

	private Label labelMinAlisMik;

	private Label labelHSatisValoru;

	private Label labelSatisValoru;

	private Label labelHAlisValoru;

	private Label labelAlisValoru;

	private Label labelHSonIslemSaati;

	private Label labelSonIslemSaati;

	private Label labelHBaslangicSaati;

	private Label labelBaslangicSaati;

	private Label labelHKurucu;

	private Label labelKurucu;

	private Label labelHFonAdi;

	private Label labelFonAdi;

	private Label labelHRiskDegeri;

	private Label labelRiskDegeri;

	private Label labelHFonKodu;

	private Label labelFonKodu;

	private Chart chartVarlikDagilim;

	private Chart chartData;

	private Panel panelChart0_Header;

	private Panel panel1Hafta;

	private Label label1HaftaText;

	private Label label1HaftaHeader;

	private Panel panel1Ay;

	private Label label1AyText;

	private Label label1AyHeader;

	private Panel panel1Yil;

	private Label label1YilText;

	private Label label1YilHeader;

	private Panel panelMevcutYil;

	private Label labelMevcutYilText;

	private Label labelMevcutYilHeader;

	private Panel panel6Ay;

	private Label label6AyText;

	private Label label6AyHeader;

	private Panel panel5Yil;

	private Label label5YilText;

	private Label label5YilHeader;

	private Panel panelTumu;

	private Label labelTumuText;

	private Label labelTumuHeader;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formFonGenel(int leftX, int topX, string symbolX, cxPage.Pgc pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formFonGenel_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RequestChart()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formFonGenel_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formFonGenel_Deactivate(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formFonGenel_DragDrop(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formFonGenel_DragEnter(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formFonGenel_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formFonGenel_MouseDown(object sender, MouseEventArgs e)
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
	private void formFonGenel_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formFonGenel_SizeChanged(object sender, EventArgs e)
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
	private void ChartDataReceived(string symbolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChartDataBasicReceived(string symbolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReDrawChart()
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
	private string getSonFiyatTarihiText()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string numberShortText(double number)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string valorText(string text)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart1_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StringFormat CellHizala(string hizalastr)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formFonGenel_Resize(object sender, EventArgs e)
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
	private void panelportfoy_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart1_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chartVarlikDagilim_GetToolTipText(object sender, ToolTipEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chartData_GetToolTipText(object sender, ToolTipEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelGetiriGrup_MouseEnter(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelGetiriGrupShow(Panel panel)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelGetiriGrupDefault(Panel panel)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelGetiriGrup_Leave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panel1Hafta_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panel1Ay_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panel6Ay_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelMevcutYil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panel1Yil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panel5Yil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelTumu_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chartData_MouseMove(object sender, MouseEventArgs e)
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
	static formFonGenel()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		Stil = 0;
		Kalinlik = 1;
		ExtendRightBool = true;
	}
}
