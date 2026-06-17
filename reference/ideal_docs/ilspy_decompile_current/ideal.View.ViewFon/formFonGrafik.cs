using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using dg3ypDAonQcOidMs0w;

namespace ideal.View.ViewFon;

public class formFonGrafik : FormControl
{
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

	private bool RedrawBool;

	private int LastPriceTime;

	private cxButton HeaderButtons;

	private bool FormActivated;

	private IContainer components;

	private Timer timerRefresh;

	private TextBox textSymbolSearch;

	private Panel panelHeader;

	private Panel panelChart1;

	private Panel panelChart2;

	private Panel panelChart3;

	private Chart chartYatirimciSayisi;

	private Chart chartFonToplamDeger;

	private Chart chartNakitGirisCikis;

	private Label labelHFonAdi;

	private Label labelFonAdi;

	private Label labelHLastPrice;

	private Label labelLastPrice;

	private Label labelHYatirimciSayisi;

	private Label labelHFonBuyuklugu;

	private Label labelYatirimciSayisi;

	private Label labelFonBuyuklugu;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formFonGrafik(int leftX, int topX, string symbolX, cxPage.Pgc pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formFonGenel_Load(object sender, EventArgs e)
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
	private void formFonGrafik_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formFonGenel_SizeChanged(object sender, EventArgs e)
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
	private void BasicDataReceived(string symbolX, string updatetypeX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MessageReceived(string messageX)
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
	private void timerRefresh_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelHeader_Paint(object sender, PaintEventArgs e)
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
	public StringFormat CellHizala(string hizalastr)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formFonGrafik_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chartYatirimciSayisi_GetToolTipText(object sender, ToolTipEventArgs e)
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
	static formFonGrafik()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
