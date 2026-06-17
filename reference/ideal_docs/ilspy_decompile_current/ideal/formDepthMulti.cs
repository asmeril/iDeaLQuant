using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formDepthMulti : FormControl
{
	private class DepthFrame
	{
		public string Symbol;

		public int Row;

		public int Col;

		public cxBasic BasicItem;

		public cxDepth DepthItem;

		public Rectangle Rectangle;

		public long AveragePaintTime;

		public long DepthPacketReceiveTime;

		public int[] BidColorStatus;

		public long[] BidUpdateTime;

		public long[] AskColorStatus;

		public long[] AskUpdateTime;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DepthFrame()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DepthFrame()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private int ClassVersion;

	private Font FontData;

	private int LineSpace;

	private bool GridlineVisible;

	private int VisibleRows;

	private bool Average1Visible;

	private bool Average2Visible;

	private bool TimeVisible;

	private int TimeWidth;

	private bool OrderVisible;

	private int OrderWidth;

	private bool VolVisible;

	private int VolWidth;

	private bool SizeVisible;

	private int SizeWidth;

	private bool PriceVisible;

	private int PriceWidth;

	private int FrameColCount;

	private bool PistonVisible;

	private byte SessionChangeSelected;

	private bool TopMostEnabled;

	private Color GridBackColor;

	private Color GridForeColor;

	private Color SymbolColor;

	private Color NormalColor;

	private Color HighColor;

	private Color LowColor;

	private Color RelationalNewsColor;

	private Color AverageLineBackColor;

	private Color AverageLineForeColor;

	private Color PassiveBorderColor;

	private Color ActiveBorderColor;

	private Color MarketMakerBidBackColor;

	private Color MarketMakerBidForeColor;

	private Color MarketMakerAskBackColor;

	private Color MarketMakerAskForeColor;

	private Color SymbolLineBackColor1;

	private Color SymbolLineBackColor2;

	private Color SymbolLineBorderColor;

	private Color UpdateNormalBackColor;

	private Color UpdateNormalForeColor;

	private Color UpdateHighBackColor;

	private Color UpdateHighForeColor;

	private Color UpdateLowBackColor;

	private Color UpdateLowForeColor;

	private cxPage.MultiDepth PageParams;

	private int InitialLeft;

	private int InitialTop;

	private Rectangle InvRect1;

	private Rectangle InvRect2;

	private Color InvBackColor;

	private Color InvForeColor;

	private StringFormat InvAlign;

	private Font InvFont;

	private string InvString;

	public string ActiveSymbol;

	private int TitleHeight;

	private int RowHeight;

	private int ActiveCol;

	private int ActiveRow;

	private int DepthRowCount;

	private int DepthColCount;

	private int Average1RowNo;

	private int Average2RowNo;

	private cxGrid DepthGrid;

	private int[] DepthCharWidth;

	private int VerticalMargin;

	private int HorizontaMargin;

	private int FrameWidth;

	private int FrameHeight;

	private Dictionary<string, DepthFrame> FrameDictionary;

	private bool FormLoaded;

	private Stopwatch CheckTime;

	private long RequestTime;

	private cxFont.Margin FontMargin;

	private cxButton HeaderButtons;

	private Pen Pen1;

	private Pen Pen2;

	private SolidBrush Brush1;

	private SolidBrush BrushBack;

	private SolidBrush BrushFore;

	private Rectangle Rect1;

	private Rectangle Rect2;

	private string Str1;

	private bool MovingColBool;

	private IContainer components;

	private Panel panelDepth;

	private Timer timerUpdate;

	private Panel panelColSelect;

	private TextBox textSymbol;

	private TextBox textSearch;

	private ContextMenuStrip menu;

	private ToolStripMenuItem menuProperty;

	private ToolStripMenuItem menuPropertyMemCopy;

	private ToolStripSeparator toolStripMenuItem1;

	private ToolStripMenuItem menuPropertyCols;

	private TextBox textBoxTime;

	private CheckBox checkBoxTime;

	private Button buttonApply;

	private TextBox textBoxOrder;

	private CheckBox checkBoxOrder;

	private TextBox textBoxSize;

	private CheckBox checkBoxSize;

	private TextBox textBoxVol;

	private CheckBox checkBoxVol;

	private TextBox textBoxPrice;

	private CheckBox checkBoxPrice;

	private CheckBox checkBoxAverage1;

	private Label label1;

	private TextBox textBoxLineCount;

	private CheckBox checkBoxAverage2;

	private Label label3;

	private TextBox textBoxLineSpace;

	private Label label2;

	private ToolStripMenuItem menuPropertyColor;

	private ToolStripMenuItem menuPropertyFont;

	private ToolStripMenuItem menuPattern;

	private ToolStripMenuItem menuPatternSave;

	private ToolStripMenuItem menuPatternSaveas;

	public ToolStripComboBox menuPatternChange;

	private ToolStripMenuItem menuPatternDelete;

	private ToolStripMenuItem menuPatternDeleteAll;

	private ToolStripSeparator toolStripMenuItem2;

	private ToolStripMenuItem menuClose;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripMenuItem menuSearch;

	private ToolStripMenuItem menuAutoArrange;

	private ToolStripMenuItem menuDelete;

	public ToolStripMenuItem menuDistribution;

	public ToolStripMenuItem menuDetail;

	public ToolStripMenuItem menuChart;

	private ToolStripMenuItem menuTimeSales;

	public ToolStripMenuItem menuStep;

	public ToolStripMenuItem menuNews;

	public ToolStripMenuItem menuBalanceSheet;

	public ToolStripMenuItem menuTakas;

	public ToolStripMenuItem menuTakasDif;

	private ToolStripSeparator toolStripMenuItem23;

	private ToolStripMenuItem menuMainPatternDefault;

	private ToolStripMenuItem menuTool;

	private ToolStripMenuItem menuToolJpgCopy;

	private ToolStripMenuItem menuToolBmpCopy;

	private GroupBox groupBox1;

	private RadioButton radioDay;

	private RadioButton radioSession;

	private ToolStripMenuItem menuPropertyTopmost;

	private ToolStripMenuItem menuDeleteAll;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formDepthMulti(int leftX, int topX, cxPage.MultiDepth fieldsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void frmDepthMulti_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDepthMulti_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDepthMulti_Deactivate(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDepthMulti_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDepthMulti_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDepthMulti_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDepthMulti_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDepthMulti_SizeChanged(object sender, EventArgs e)
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
	private void buttonApply_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBox_MouseClick(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuAutoArrange_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuBalanceSheet_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuChart_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuClose_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuDelete_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuDeleteAll_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuDetail_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuDistribution_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuNews_Click(object sender, EventArgs e)
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
	private void menuPropertyCols_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPropertyFont_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPropertyMemCopy_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPropertyTopmost_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSearch_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuStep_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTakas_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTakasDif_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTimeSales_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuToolBmpCopy_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuToolJpgCopy_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelDepth_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelDepth_MouseDoubleClick(object sender, MouseEventArgs e)
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
	private void radioSession_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBox_KeyDown(object sender, KeyEventArgs e)
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
	private void textSearch_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbol_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbol_KeyPress(object sender, KeyPressEventArgs e)
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
	private void GetColRowFromPoint(Point pointX, out int colX, out int rowX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Rectangle GetFrameRectangle(int colnoX, int rownoX)
	{
		return (Rectangle)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InvalidateAll()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PaintCell(Graphics grx, bool refreshpaintX, string strX, Font fontX, Color backcolorX, Color forecolorX, Rectangle rect1X, Rectangle rect2X, StringFormat alignX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrepareTables()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintBasicData(Graphics grx, bool refreshpaintX, DepthFrame frameX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintDepthLine(Graphics grx, bool refreshpaintX, DepthFrame frameX, char bidaskX, int rownoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintDepthAverage(Graphics grx, bool refreshpaintX, DepthFrame frameX, char bidaskX, int rownoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetColParams()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPageParams(cxPage.MultiDepth pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPageSymbols(cxPage.MultiDepth pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMainToolbarSymbol()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowColPanel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowMenu(object sender, Point pointX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AutoPlaceSymbols(List<string> symbollistX)
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
	static formDepthMulti()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
