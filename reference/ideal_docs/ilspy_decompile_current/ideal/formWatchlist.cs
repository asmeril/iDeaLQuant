using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formWatchlist : FormControl
{
	private struct CellStruct
	{
		public string Symbol;

		public string TextDisplay;

		public long UpdateTime;

		public byte ColorStatus;

		public Color BackColor;

		public Color ForeColor;

		public bool Dirty;

		public int SearchWidth;
	}

	public struct FieldStruct
	{
		public int Code;

		public int Width;

		public int LeftPos;

		public int KurumId;
	}

	private struct SelectedCellStruct
	{
		public int RowNo;

		public int ColNo;
	}

	private Font FontData;

	public string HeaderName;

	private int LineSpace;

	private bool GridlineVisible;

	private bool ActiveCellPainting;

	private bool RelationalPainting;

	private string SearchString;

	private int SortField;

	private int SortDirection;

	private int SortPeriod;

	private string ExcelFileName;

	private bool ExcelPeriodic;

	private int ExcelInterval;

	private bool TopMostEnabled;

	private bool VipFilter;

	private string VipFilterSymbol;

	private bool VipFilterFutures;

	private bool VipFilterOptions;

	private bool VipFilterPut;

	private bool VipFilterCall;

	private string VipFilterExpiry;

	private byte CurrencyPrice;

	private byte CurrencyVolume;

	private int ClassVersion;

	private bool TitleVisible;

	private int ScrollPeriod;

	private bool VarantFilter;

	private string VarantFilterSymbol;

	private bool VarantFilterPut;

	private bool VarantFilterCall;

	private string VarantFilterExpiry;

	private bool FonFilter;

	private string HesapRumuz;

	private bool LoginBool;

	private bool RequestBool;

	private bool HesapReadBool;

	public FieldStruct[] ColArray;

	private Dictionary<string, string> SymbolDictionary;

	private Color[] RowBackColors;

	private Color[] HighLowColors;

	private Color SymbolBackColor;

	private Color SymbolForeColor;

	private Color RelationalNewsColor;

	private Color SearchColor;

	private Color UniqueSearchColor;

	private Color GridlineColor;

	private Color TitleBackColor1;

	private Color TitleBackColor2;

	private Color TitleForeColor;

	private Color TitleBorderColor;

	private Color ActiveCellBackColor1;

	private Color ActiveCellBackColor2;

	private Color ActiveCellForeColor;

	private Color[] UpdateBackColors;

	private Color[] UpdateForeColors;

	private Color VbarBackColor1;

	private Color VbarBackColor2;

	private Color VbarForeColor;

	private Color VbarBorderColor;

	private Color VbarButtonBackColor1;

	private Color VbarButtonBackColor2;

	private cxPage.Watchlist PageParams;

	private string MarketString;

	private int InitialLeft;

	private int InitialTop;

	private cxButton HeaderButtons;

	private int InvCol;

	private int InvRow;

	private bool InvDrawActiveRow;

	private bool InvDrawActiveCol;

	private string UniqueSearchString;

	private string[] SearchArray;

	private Rectangle HeaderMenuRect;

	private long RefreshTime;

	private long AutoScrollTime;

	private long SortTime;

	private long ExcelRefreshMoment;

	private bool RequestNeeded;

	private bool InitialRequest;

	private List<string> RequestList;

	public string WatchlistName;

	private Point MouseClickLocation;

	private Point MouseDblClickLocation;

	private string SelectedSymbol;

	private int MaxCols;

	private int MaxRows;

	private int TopRow;

	private int BottomRow;

	private int RowHeight;

	private int DisplayedRows;

	private int TitleHeight;

	private int ActiveRow;

	private int ActiveCol;

	private int PrevRow;

	private int PrevCol;

	private CellStruct[,] CellMatrix;

	private bool GridDirty;

	private SelectedCellStruct MouseCellRec;

	private SelectedCellStruct EditCellRec;

	private bool FormLoaded;

	private bool FormActivated;

	private bool VbarVisible;

	private float ScrollMidLength;

	private float ScrollSideLength;

	private int ScrollDirection;

	private long ScrollTime;

	private long MiliSecond200;

	private long MiliSecond500;

	private long MiliSecond2000;

	private long MiliSecond30000;

	private Rectangle VbarMidRect;

	private Rectangle VbarBottomRect;

	private Rectangle VbarTopRect;

	private bool MovingObject;

	private Point MoveCursor;

	private Rectangle MoveRect;

	private bool MovingColBool;

	private int MovingColNo;

	private Stopwatch CheckTime;

	private cxFont.Margin FontMargin;

	private Font FontHeader;

	private Font FontArrow;

	private Pen Pen1;

	private Point Point1;

	private SolidBrush Brush1;

	private SolidBrush BrushBack;

	private SolidBrush BrushFore;

	private Rectangle Rect1;

	private Rectangle Rect2;

	private Rectangle RectTotal;

	private Rectangle RectPartial;

	private string Str1;

	private Thread ThreadExcel;

	private string MarketType;

	private Dictionary<string, double> HesapAdetDict;

	private Dictionary<string, double> HesapMaliyetDict;

	private double HKZ;

	private IContainer components;

	private Timer timerLocal;

	private Panel panelVbar;

	private Panel panelGrid;

	private Panel panelSymbol;

	private TextBox textSymbolSearch;

	private TextBox textSearch;

	private TextBox textUniqueSearch;

	private ToolTip toolTip;

	public ComboBox comboVipSymbols;

	public ComboBox comboVipExpiry;

	private Timer timerScroll;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formWatchlist(int leftX, int topX, string marketX, cxPage.Watchlist fieldsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formWatchList_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formWatchList_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formWatchList_Deactivate(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formWatchlist_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formWatchlist_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formWatchlist_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formWatchList_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formWatchList_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formWatchList_MouseWheel(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboVipExpiry_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboVipExpiry_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboVipSymbols_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboVipSymbols_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelGrid_DragDrop(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelGrid_DragEnter(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelGrid_MouseDoubleClick(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelGrid_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelGrid_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelGrid_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelGrid_MouseLeave(object sender, EventArgs e)
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
	private void textSearch_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSearch_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSearch_Leave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbolSearch_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbolSearch_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbolSearch_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbolSearch_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textUniqueSearch_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textUniqueSearch_Leave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textUniqueSearch_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textUniqueSearch_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerScroll_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerLocal_Tick(object sender, EventArgs e)
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
	private void BestColWidth()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BuiltSymbolListFromMatrix()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CopyToExcel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void DeleteSymbolsInWatchlist(List<string> listX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string DayanakSembolFormatla(string dynkstr)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplaySymbolEntry()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillMarket()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillMatrix()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillHesapSemboller()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FilterTahvil()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FilterFon()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetDdeColumnCode(int colnoX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetAtivelCol(int colNoX)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetSymbolCol(int colNoX)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<string> GetVipFilteredSymbols()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<string> GetVarantFilteredSymbols()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private double GetViopMultiplier(string symbolX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitIndex(string indexX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitMarket(string marketX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsFon(string markettype)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitSector(string sectorX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitPortfoy(string portfoyStrX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrepareTables()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintActiveCol()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintActiveRow()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintCell(Graphics graphX, int rowX, int colX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReadSymbolData(string symbolX, char pakettypeX, bool refreshX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SelectedCellStruct GetCellNoFromCoord(float X, float Y)
	{
		return (SelectedCellStruct)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCellBackColor(byte xType, int xRow, int xCol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPageCols(cxPage.Watchlist pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPageParams(cxPage.Watchlist pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPagePattern(cxPage.Watchlist pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPageSymbols(cxPage.Watchlist pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowDepth(Point pointX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowMenu(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowMenuCol(object sender, Point pointX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SortData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolStringToDictionary(string symbolstringX)
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
	public void SetSymbols(List<string> symbolsX)
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
	static formWatchlist()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
