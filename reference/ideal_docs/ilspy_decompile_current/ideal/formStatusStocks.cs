using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formStatusStocks : FormControl
{
	private Font FontData;

	private int LineSpace;

	private bool GridlineVisible;

	private string SelectString;

	private string StatusKodString;

	private bool TooltipEnabled;

	private DateTime Interval1;

	private DateTime Interval2;

	private Color TitleBackColor1;

	private Color TitleBackColor2;

	private Color TitleForeColor;

	private Color TitleBorderColor;

	private Color GridBackColor;

	private Color GridForeColor;

	private Color NormalColor;

	private Color HighColor;

	private Color LowColor;

	private Color CurrentLineBackColor;

	private Color CurrentLineForeColor;

	private Color GridlineColor;

	private Color SelectColor;

	private Color VbarBackColor1;

	private Color VbarBackColor2;

	private Color VbarForeColor;

	private Color VbarBorderColor;

	private Color VbarButtonBackColor1;

	private Color VbarButtonBackColor2;

	private string ActiveSymbol;

	private bool VbarVisible;

	private int TitleHeight;

	private int RowHeight;

	private cxPage.StocksStatus PageParams;

	private int InitialLeft;

	private int InitialTop;

	private List<cxBasic> SymbolList;

	private cxGrid Grid;

	private int[] CharWidth;

	private string[] SelectArray;

	private bool FormLoaded;

	private cxFont.Margin FontMargin;

	private Font FontHeader;

	private cxButton HeaderButtons;

	private Pen Pen1;

	private Pen Pen2;

	private SolidBrush Brush1;

	private SolidBrush BrushBack;

	private SolidBrush BrushFore;

	private Rectangle Rect1;

	private Rectangle Rect2;

	private string Str1;

	private Point Point1;

	private bool MovingObject;

	private Point MoveCursor;

	private Rectangle MoveRect;

	private float ScrollMidLength;

	private float ScrollSideLength;

	private int ScrollDirection;

	private long ScrollTime;

	private Rectangle VbarMidRect;

	private Rectangle VbarBottomRect;

	private Rectangle VbarTopRect;

	private Stopwatch CheckTime;

	private Dictionary<string, string> DurumDictionary;

	private IContainer components;

	public ContextMenuStrip menu;

	private ToolStripMenuItem menuProperty;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripMenuItem menuPropertyColor;

	private ToolStripMenuItem menuPropertyFont;

	private ToolStripSeparator toolStripSeparator5;

	private ToolStripMenuItem menuClose;

	private Panel panelGrid;

	private Panel panelVbar;

	private ToolStripMenuItem menuPropertyMemCopy;

	private ToolStripMenuItem menuPropertyGridlines;

	private ToolStripMenuItem menuPropertyLinespace;

	private ToolStripMenuItem menuPattern;

	private ToolStripMenuItem menuMainPatternSave;

	private ToolStripMenuItem menuMainPatternSaveas;

	public ToolStripComboBox menuMainPatternChange;

	private ToolStripMenuItem menuMainPatternDelete;

	private ToolStripMenuItem menuMainPatternDeleteAll;

	private ToolStripMenuItem menuSymbolFilter;

	private ToolStripSeparator toolStripSeparator1;

	private Timer timerRefresh;

	private ToolStripMenuItem menuMainPatternDefault;

	private ToolStripMenuItem menuTool;

	private ToolStripMenuItem menuMainToolExcelCopy;

	private Timer timerScroll;

	public ComboBox comboDurum;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formStatusStocks(int leftX, int topX, cxPage.StocksStatus pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formStatusStocks_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formStatusStocks_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formStatusStocks_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formStatusStocks_Deactivate(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formStatusStocks_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formStatusStocks_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formStatusStocks_MouseWheel(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formStatusStocks_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formStatusStocks_SizeChanged(object sender, EventArgs e)
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
	private void menuClose_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPatternChange_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainPatternDefault_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainToolExcelCopy_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPatternDelete_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPatternDeleteAll_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPatternSave_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPatternSaveas_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPropertyColor_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPropertyFont_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPropertyGridlines_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPropertyLinespace_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPropertyMemCopy_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSymbolFilter_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelGrid_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelGrid_MouseDoubleClick(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelGrid_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelGrid_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelVbar_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelVbar_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelVbar_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelVbar_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerRefresh_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerScroll_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MessageReceived(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string ConvertStatusKodeString(string statusCodeX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string ConvertStringStatusKode(string strX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CopyToExcel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InvalidateAll()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadStatusDescription()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrepareTables()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPageParams(cxPage.StocksStatus pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowMenu(object sender, Point pointX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowMenuCol(object sender, Point pointX)
	{
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
	private void comboDurum_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboDurum_SelectionChangeCommitted(object sender, EventArgs e)
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
	static formStatusStocks()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
