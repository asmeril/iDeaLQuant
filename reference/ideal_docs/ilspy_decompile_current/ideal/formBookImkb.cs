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

public class formBookImkb : FormControl
{
	private Font FontData;

	private int LineSpace;

	private bool GridlineVisible;

	private string SymbolSelectString;

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

	private cxPage.Trade PageParams;

	private int InitialLeft;

	private int InitialTop;

	private bool VbarVisible;

	private int TitleHeight;

	private int RowHeight;

	private int GotoRow;

	private int GotoTrade;

	private string GotoTime;

	private string BrokerName;

	public static DateTime SelectedDate;

	private DateTime LocalDate;

	private List<cxImkbOrder.OrderRecord> DataList;

	private cxGrid Grid;

	private int[] TradeCharWidth;

	private bool FormLoaded;

	private Stopwatch CheckTime;

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

	private Thread ExcelThread;

	private string ExportChartFileName1;

	private string ExportChartFileName5;

	private string ExportChartFileName60;

	private string ExportChartFileNameG;

	private IContainer components;

	public ContextMenuStrip menuMain;

	private ToolStripMenuItem menuMainProperty;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripMenuItem menuMainPropertyColor;

	private ToolStripMenuItem menuMainPropertyFont;

	private ToolStripSeparator toolStripSeparator4;

	private ToolStripMenuItem menuMainClose;

	private ToolStripMenuItem menuMainGotoRowNo;

	private ToolStripMenuItem menuMainGotoTradeNo;

	private ToolStripMenuItem menuMainGotoTime;

	private ToolStripSeparator toolStripSeparator6;

	private Panel panelTrade;

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

	private ToolStripSeparator toolStripSeparator8;

	private Http http1;

	private Timer timerDownload;

	private ToolStripMenuItem menuMainDownload2;

	private ToolStripMenuItem menuMainTool;

	private ToolStripMenuItem menuMainToolExcelCopy;

	private ToolStripMenuItem menuMainPatternDefault;

	private Label labelDownload;

	private DateTimePicker datetimeSelect;

	private Timer timerScroll;

	private ContextMenuStrip menuBroker;

	private ToolStripMenuItem menuBrokerAll;

	private ToolStripComboBox menuBrokerCombo;

	private ToolStripMenuItem menuMainSymbolFilter;

	private ToolStripSeparator toolStripSeparator1;

	private TextBox textSymbolSearch;

	private ToolStripMenuItem menuMainToolCsvCopy;

	private ToolStripSeparator toolStripSeparator2;

	private ToolStripMenuItem menuMainIslemlerExport;

	private ToolStripMenuItem menuMainGrafikExport;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formBookImkb(int leftX, int topX, cxPage.Trade pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formImkbBook_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formImkbBook_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formImkbBook_Deactivate(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formImkbBook_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formImkbBook_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formImkbBook_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formImkbBook_MouseWheel(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formImkbBook_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formImkbBook_SizeChanged(object sender, EventArgs e)
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
	private void menuBrokerAll_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuBrokerCombo_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainClose_Click(object sender, EventArgs e)
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
	private void menuMainPropertyFont_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainPropertyGridlines_Click(object sender, EventArgs e)
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
	private void timerDownload_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerScroll_Tick(object sender, EventArgs e)
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
	private void CopyToExcel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CopyToCSV()
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
	private void menuMainGrafikExport_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainIslemlerExport_Click(object sender, EventArgs e)
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
	static formBookImkb()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		SelectedDate = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
	}
}
