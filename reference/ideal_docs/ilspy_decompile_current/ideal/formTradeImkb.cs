using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;
using nsoftware.IPWorks;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class formTradeImkb : FormControl
{
	private Font FontData;

	private int LineSpace;

	private bool GridlineVisible;

	private int CompositeShow;

	private string SymbolFilter;

	private byte Period;

	private DateTime HistoricDate;

	private double VolumeFilter;

	private double AdetFilter;

	private int TitleHeight;

	private int ClassVersion;

	private bool SummaryVisible;

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

	private WebClient Downloader;

	private Dictionary<string, string> DownloadDictionary;

	private Queue<string> DownloadQueue;

	private cxPage.Trade PageParams;

	private int InitialLeft;

	private int InitialTop;

	private Dictionary<string, string> SymbolDictionary;

	private bool VbarVisible;

	private string SymbolSelectString;

	private int RowHeight;

	private int GotoRow;

	private int GotoTrade;

	private string GotoTime;

	private string Broker;

	private string SeciliGun;

	private List<IslemStruct1> DataList;

	private List<IslemStruct1> DataBuffer;

	private cxGrid Grid;

	private long TradeUpdateTime;

	private int TradeUpdateCount;

	private int TradeCheckID;

	private int[] TradeCharWidth;

	private cxGrid MoneyflowGrid;

	private double MoneyflowInput;

	private double MoneyflowOutput;

	private double MoneyflowTotal;

	private double MoneyflowNetDif;

	private double MoneyflowNetPer;

	private bool FormLoaded;

	private Stopwatch CheckTime;

	private long DownloadMoment;

	private long ReloadMoment;

	private bool DownloadReceived;

	private string DownloadInfo;

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

	private Thread ThreadExcel;

	private bool InvalidateNeeded;

	private bool PgcHesaplaBool;

	private bool FiltreleriKullanBool;

	private bool DownloadMessageBool;

	private int TimerCounter5;

	private int TimerCounter50;

	private string TumSembollerEng;

	private string SymbolFilterEng;

	private static bool TumDataBool;

	private IContainer components;

	private Timer timerUpdate;

	private ContextMenuStrip menuDate;

	private ToolStripMenuItem menuDateToday;

	private ToolStripSeparator toolStripSeparator2;

	public ContextMenuStrip menuMain;

	private ToolStripMenuItem menuMainProperty;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripMenuItem menuMainPropertyColor;

	private ToolStripMenuItem menuMainPropertyFont;

	private ToolStripSeparator toolStripSeparator4;

	public ToolStripMenuItem menuMainShowOpen;

	public ToolStripMenuItem menuMainShowCombined;

	private ToolStripSeparator toolStripSeparator5;

	private ToolStripMenuItem menuMainClose;

	private ToolStripMenuItem menuMainGotoRowNo;

	private ToolStripMenuItem menuMainGotoTradeNo;

	private ToolStripMenuItem menuMainGotoTime;

	private ToolStripSeparator toolStripSeparator6;

	private Panel panelTrade;

	private Panel panelMoneyflow;

	private Panel panelVbar;

	private ToolStripMenuItem menuMainPropertyMemCopy;

	private ToolStripMenuItem menuMainPropertyGridlines;

	private ToolStripMenuItem menuMainPropertyLinespace;

	private ToolStripMenuItem menuMainPattern;

	private ToolStripMenuItem menuMainPatternSave;

	private ToolStripMenuItem menuMainPatternSaveas;

	public ToolStripComboBox menuMainPatternChange;

	private ToolStripMenuItem menuMainPatternDelete;

	private ToolStripMenuItem menuMainPatternDeleteAll;

	private TextBox textSymbolSearch;

	private ToolStripMenuItem menuMainSymbolFilter;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripMenuItem menuMainDownload;

	private ToolStripSeparator toolStripSeparator8;

	private Http http1;

	private Timer timerDownload;

	private ToolStripMenuItem menuMainDownload2;

	private ToolStripMenuItem menuMainTool;

	private ToolStripMenuItem menuMainToolExcelCopy;

	private ToolStripMenuItem menuMainPatternDefault;

	private Label labelDownload;

	private ToolStripMenuItem menuDateHistoric;

	private DateTimePicker datetimeSelect;

	private Timer timerScroll;

	private ToolStripMenuItem menuMainPropertyHeaderHeight;

	private ToolStripMenuItem menuMainPropertyDoubleClick0;

	private ToolStripMenuItem menuMainPropertyDoubleClick1;

	private ToolStripMenuItem menuMainPropertySummaryVisible;

	private Panel panelFilter;

	private Button buttonFilterOK;

	private CheckBox checkBoxFilterNSE;

	private CheckBox checkBoxFilterTE;

	private CheckBox checkBoxFilterOzel;

	private Button buttonFilterAll;

	private CheckBox checkBoxSadeceAlislar;

	private CheckBox checkBoxSadeceSatislar;

	private ComboBox comboBroker;

	private Button buttonClose;

	private ToolStripMenuItem menuMainToolCsvCopy;

	private ToolStripMenuItem menuMainToolCsvCopyAll;

	private ToolStripSeparator toolStripSeparator7;

	private ToolStripMenuItem menuMainFiltreleriKullan;

	private ToolStripMenuItem menuMainTumDataFalse;

	private ToolStripMenuItem menuMainTumDataTrue;

	private ToolStripSeparator toolStripSeparator9;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formTradeImkb(int leftX, int topX, cxPage.Trade pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTradeImkb_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTradeImkb_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTradeImkb_Deactivate(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTradeImkb_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTradeImkb_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTradeImkb_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTradeImkb_MouseWheel(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTradeImkb_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTradeImkb_SizeChanged(object sender, EventArgs e)
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
	private void buttonFilterOK_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonFilterAll_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonClose_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBroker_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeSelect_Leave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeSelect_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void http1_OnEndTransfer(object sender, HttpEndTransferEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void http1_OnTransfer(object sender, HttpTransferEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuDateHistoric_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuDateToday_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainClose_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainDownload_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainDownload2_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainGotoRowNo_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainGotoTime_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainGotoTradeNo_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainPatternChange_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainPatternDefault_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainPatternDelete_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainPatternDeleteAll_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainPatternSave_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainPatternSaveas_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainPropertyColor_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainPropertyDoubleClick0_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainPropertyDoubleClick1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainPropertyFont_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainPropertyGridlines_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainPropertySummaryVisible_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainPropertyHeaderHeight_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainPropertyLinespace_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainPropertyMemCopy_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainShowCombined_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainShowOpen_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainSymbolFilter_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainToolExcelCopy_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainToolCsvCopy_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainToolCsvCopyAll_Click(object sender, EventArgs e)
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
	private void panelTrade_MouseDoubleClick(object sender, MouseEventArgs e)
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
	private void timerDownload_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ConvertDownloaded(string filenameX)
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
	private void DownloaderProgressChanged(object sender, DownloadProgressChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DownloaderCompleted(object sender, AsyncCompletedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MessageReceived(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IslemReceived(IslemStruct1 newtradeX)
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
	private void CopyToCsv()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CopyToCsvAll()
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
	private void SetPageParams(cxPage.Trade pageparamsX)
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
	public void StartDownloadForThisDay()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainFiltreleriKullan_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainTumDataFalse_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainTumDataTrue_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void http1_OnRedirect(object sender, HttpRedirectEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void http1_OnError(object sender, HttpErrorEventArgs e)
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
	static formTradeImkb()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		TumDataBool = true;
	}
}
