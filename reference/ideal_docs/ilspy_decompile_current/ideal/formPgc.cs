using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class formPgc : FormControl
{
	private class Record
	{
		public float Price;

		public double Pgc;

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

	private int FillOpacity;

	private int Timer3000;

	private float LastPrice;

	private double Max1;

	private double Min1;

	private double Inc1;

	private double Max2;

	private double Min2;

	private double Inc2;

	private string DrawStatus;

	private bool DrawStartedBool;

	private PgcTrendClass NewTrend;

	public static List<PgcTrendClass> TrendList;

	public static Color TrendColor;

	public static int Stil;

	public static int Kalinlik;

	public static bool ExtendRightBool;

	private IContainer components;

	private Timer timerRefresh;

	private Panel panelChart0;

	private Panel panelChart1;

	private TextBox textSymbolSearch;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formPgc(int leftX, int topX, string symbolX, cxPage.Pgc pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formPgc_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formPgc_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formPgc_Deactivate(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formPgc_DragDrop(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formPgc_DragEnter(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formPgc_FormClosed(object sender, FormClosedEventArgs e)
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
	private void formPgc_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formPgc_SizeChanged(object sender, EventArgs e)
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
	private void SetPageParams(cxPage.Pgc pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowMenu(object sender, Point pointX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart0_MouseDoubleClick(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawTrend(PgcTrendClass trend, string sembol, string panelname, Graphics grx)
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
	static formPgc()
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
