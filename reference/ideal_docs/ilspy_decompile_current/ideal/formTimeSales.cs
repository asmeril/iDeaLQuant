using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formTimeSales : FormControl
{
	private Font FontData;

	public string ActiveSymbol;

	private int LineSpace;

	private bool GridlineVisible;

	private bool TradeVisible;

	private bool BasicVisible;

	private bool MoneyflowVisible;

	private bool DepthHeaderVisible;

	private int CompositeShow;

	private Color TitleBackColor1;

	private Color TitleBackColor2;

	private Color TitleForeColor;

	private Color TitleBorderColor;

	private Color ActiveCellBackColor1;

	private Color ActiveCellBackColor2;

	private Color ActiveCellForeColor;

	private Color GridBackColor;

	private Color GridForeColor;

	private Color NormalColor;

	private Color HighColor;

	private Color LowColor;

	private Color RelationalNewsColor;

	private Color AverageLineBackColor;

	private Color AverageLineForeColor;

	private Color CurrentLineBackColor;

	private Color CurrentLineForeColor;

	private Color GridlineColor;

	private Color UpdateNormalBackColor;

	private Color UpdateNormalForeColor;

	private Color UpdateHighBackColor;

	private Color UpdateHighForeColor;

	private Color UpdateLowBackColor;

	private Color UpdateLowForeColor;

	private Color VbarBackColor1;

	private Color VbarBackColor2;

	private Color VbarForeColor;

	private Color VbarBorderColor;

	private Color VbarButtonBackColor1;

	private Color VbarButtonBackColor2;

	private cxPage.Depth PageParams;

	private string InitialSymbol;

	private int InitialLeft;

	private int InitialTop;

	private Color InvBackColor;

	private Color InvForeColor;

	private StringFormat InvAlign;

	private bool VbarVisible;

	private string MenuSender;

	private int TitleHeight;

	private int RowHeight;

	private bool TopMostEnabled;

	private List<IslemStruct1> DataList;

	private List<IslemStruct1> DataBuffer;

	private cxGrid Grid;

	private long TradeUpdateTime;

	private int TradeUpdateCount;

	private int TradeCheckID;

	private int[] TradeCharWidth;

	private cxGrid MoneyflowGrid;

	private cxBasic BasicItem;

	private bool boolL1;

	private bool boolL1P;

	private bool boolL2;

	private bool FormLoaded;

	private bool DataLoaded;

	private bool boolBistOrVip;

	private Stopwatch CheckTime;

	private long RequestTime;

	private long DownloadMoment;

	private bool DownloadReceived;

	private cxFont.Margin FontMargin;

	private Font FontHeader;

	private Font FontArrow;

	private Font FontMoneyflowData;

	private Font FontMoneyflowArrow;

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

	private IContainer components;

	private Timer timerUpdate;

	private TextBox textSymbolSearch;

	private Panel panelVbar;

	private Panel panelMoneyflow;

	private Panel panelTrade;

	private Timer timerScroll;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formTimeSales(int leftX, int topX, string symbolX, cxPage.Depth pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTimeSales_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTimeSales_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTimeSales_Deactivate(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTimeSales_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTimeSales_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTimeSales_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTimeSales_MouseWheel(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTimeSales_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTimeSales_SizeChanged(object sender, EventArgs e)
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
	private void panelMoneyflow_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelMoneyflow_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelMoneyflow_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelTrade_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelTrade_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelTrade_Paint(object sender, PaintEventArgs e)
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
	private void timerScroll_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerUpdate_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BasicDataReceived(string symbolX, string updatetypeX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChartDataReceived(string symbolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TradeDataBISTReceived(IslemStruct1 tradeItem)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TradeDataVIPReceived(IslemStruct1 tradeItem)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MessageReceived(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CopyToExcel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CopyToExcel2()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InsertDataBuffer()
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
	private void PrepareTables()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPageParams(cxPage.Depth pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMainToolbarSymbol()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowMenu(object sender, Point pointX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowMenuTradeCol(object sender, Point pointX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyPattern(cxPage.Depth pageparamsX)
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
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static formTimeSales()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
