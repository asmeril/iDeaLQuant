using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formDepthVip : FormControl
{
	private Font FontData;

	public string ActiveSymbol;

	private int LineSpace;

	private bool GridlineVisible;

	private bool TradeVisible;

	private bool BasicVisible;

	private bool MoneyflowVisible;

	private bool DepthHeaderVisible;

	private bool TradeHeaderVisible;

	private int CompositeShow;

	private bool PistonVisible;

	private int DepthLineCount;

	private bool TopMostEnabled;

	private bool InnerTopMostEnabled;

	private bool EmirVisible;

	private int EmirTipi;

	private int EmirMiktar;

	private bool EmirOnay;

	private bool Average1Visible;

	private bool Average2Visible;

	private bool LastTradeVisible;

	private byte VolumeFormat;

	private int ClassVersion;

	private bool UseHighLowColorinDepth;

	private bool BasicSingleRow;

	private bool TwitterVisible;

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

	private Color MarketMakerBidBackColor;

	private Color MarketMakerBidForeColor;

	private Color MarketMakerAskBackColor;

	private Color MarketMakerAskForeColor;

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

	private Color BasicHeaderBackColor;

	private Color BasicHeaderForeColor;

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

	private string DragString;

	private Point DragPoint;

	private int DecimalPoint;

	private List<IslemStruct1> DataList;

	private List<IslemStruct1> DataBuffer;

	private cxGrid Grid;

	private long TradeUpdateTime;

	private int TradeUpdateCount;

	private int TradeCheckID;

	private int[] TradeCharWidth;

	private cxDepth DepthItem;

	private cxGrid DepthGrid;

	private int Average1RowNo;

	private int Average2RowNo;

	private long DepthPacketReceiveTime;

	private int[] DepthBidColorStatus;

	private int[] DepthAskColorStatus;

	private long[] DepthBidUpdateTime;

	private long[] DepthAskUpdateTime;

	private int[] DepthCharWidth;

	private long DepthAveragePaintTime;

	private long Interval1000;

	private int MouseDownColNo;

	private int MouseDownRowNo;

	private decimal TradePrice;

	private string TradeDirection;

	private cxBasic BasicItem;

	private cxGrid BasicGrid;

	private int BasicRowCount;

	private int[,] BasicColCode;

	private cxGrid MoneyflowGrid;

	private double MoneyflowInput;

	private double MoneyflowOutput;

	private double MoneyflowEqual;

	private double MoneyflowTotal;

	private double MoneyflowNetDif;

	private double MoneyflowNetPer;

	private bool MoneyFlowRecalculateBool;

	private long MoneyFlowRecalculateTime;

	private string LastTradeTime;

	private float LastTradeSize;

	private float LastTradePrice;

	private byte LastTradeDirection;

	private int LastTradeID;

	private bool FormLoaded;

	private bool DataLoaded;

	private Stopwatch CheckTime;

	private long DownloadMoment;

	private bool DownloadReceived;

	private long RequestTime;

	private long BasicInvalidateTime;

	private bool BasicInvalidateBool;

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

	private cxButton EmirButtons;

	private string LocalOrderKey;

	private bool DepthInvalidateBool;

	private string OriginalSembolKod;

	private string SeansKod;

	private IContainer components;

	private Timer timerUpdate;

	private TextBox textSymbolSearch;

	private Panel panelVbar;

	private Panel panelMoneyflow;

	private Panel panelBasic;

	private Panel panelDepth;

	private Panel panelTrade;

	private Panel panelLast;

	private Timer timerScroll;

	private Panel panelPiston;

	private Panel panelEmir;

	private Label labelEmirBekle;

	private TextBox textEmirMiktar;

	private ToolTip toolTip;

	private PictureBox pictureboxTwitter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formDepthVip(int leftX, int topX, string symbolX, cxPage.Depth pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDepthVip_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDepthVip_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDepthVip_Deactivate(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDepthVip_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDepthVip_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDepthVip_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDepthVip_MouseWheel(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDepthVip_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDepthVip_SizeChanged(object sender, EventArgs e)
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
	private void labelEmirBekle_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelBasic_MouseDoubleClick(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelBasic_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelBasic_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelBasic_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelDepth_DragDrop(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelDepth_DragEnter(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelDepth_MouseDoubleClick(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelDepth_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelDepth_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelDepth_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelDepth_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelLast_Paint(object sender, PaintEventArgs e)
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
	private void panelPiston_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelTrade_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelTrade_MouseDoubleClick(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelTrade_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelTrade_MouseUp(object sender, MouseEventArgs e)
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
	private void panelEmir_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelEmir_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pictureboxTwitter_Click(object sender, EventArgs e)
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
	private void DepthRefreshed(string symbolX, char bidasktypeX, int rownoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DepthUpdateRowReceived(string symbolX, char bidasktypeX, int rownoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DepthUpdateListReceived(string symbolX, List<int> listX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MessageReceived(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IslemReceived(IslemStruct1 itemX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PortfolioReceived(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CalculateMoneyFlow()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CopyToExcel()
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
	private void PrintDepthLine(Graphics grx, bool refreshpaintX, char bidaskX, int rownoX)
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
	private void ShowMenuDepthColumn(object sender, Point pointX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowMenuBasicColumn(object sender, Point pointX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetLanguage()
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
	static formDepthVip()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
