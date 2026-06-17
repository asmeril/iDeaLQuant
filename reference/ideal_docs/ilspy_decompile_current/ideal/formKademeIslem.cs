using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formKademeIslem : FormControl
{
	public string AccountName;

	public string AccountNo;

	public string Symbol;

	private cxPage.BuySell PageParams;

	private decimal BidPrice;

	private decimal AskPrice;

	private int BidLine;

	private int AskLine;

	private List<float> Bids;

	private List<float> Asks;

	private bool[] BidUpdate;

	private bool[] AskUpdate;

	private Dictionary<decimal, int> PriceDictionary;

	private bool ReCenterBool;

	private Stopwatch StopWatch1;

	private List<cxPortfolio.ImkbOrderRecord> ImkbOrderList;

	private List<cxPortfolio.VipOrderRecord> VipOrderList;

	private List<cxPortfolio.ImkbPositionRecord> ImkbPositionList;

	private List<cxPortfolio.VipPositionRecord> VipPositionList;

	private Dictionary<string, string> ImkbSummaryDictionary;

	private Rectangle DragDropRect;

	private int MouseDownRowNo;

	private cxButton HeaderButtons;

	private cxButton Buttons1;

	private cxButton Buttons2;

	private IContainer components;

	private Panel panelGrid;

	private ContextMenuStrip menu;

	private DataGridView gridKademe;

	private ToolStripMenuItem menuBistSure;

	private ToolStripMenuItem menuBistSureSeans;

	private ToolStripMenuItem menuBistSureSeans1;

	private ToolStripMenuItem menuBistSureSeans2;

	private ToolStripMenuItem menuBistSureGun;

	private ToolStripMenuItem menuVipSure;

	private ToolStripMenuItem menuVipSureIEK;

	private ToolStripMenuItem menuVipSureGun;

	private TextBox textSymbolSearch;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	private DataGridViewTextBoxColumn Column1;

	private DataGridView gridDefault;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

	private Timer timerDisplay;

	private ToolStripMenuItem menuOnay;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripMenuItem menuCancelBuy;

	private ToolStripMenuItem menuCancelSell;

	private ToolStripMenuItem menuCancelAll;

	public ComboBox comboAccountName;

	public ComboBox comboAccountNo;

	private TextBox textPosition;

	private Label label1;

	private Label labelMaliyet;

	private Label labelProfit;

	private Timer timerRequest;

	private ToolStripMenuItem menuRequestPeriod;

	private ToolStripSeparator toolStripSeparator2;

	private ToolStripMenuItem menuWarning;

	private ToolStripMenuItem menuCloseAllBist;

	private ToolStripMenuItem menuCloseSymbolPositions;

	private Label labelOverall;

	private CheckBox checkAciga;

	private ToolStripMenuItem menuToolbar;

	private ToolStripMenuItem menuAutoCenter;

	private ToolStripMenuItem menuKademeCount;

	private Panel panelButtons;

	private ToolStripMenuItem menuBistEmirTip;

	private ToolStripMenuItem menuBistEmirTipNormal;

	private ToolStripMenuItem menuBistEmirTipKPY;

	private ToolStripMenuItem menuBistEmirTipKIE;

	private ToolStripMenuItem menuVipSureKIE;

	private ToolStripMenuItem menuVipSureGIE;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formKademeIslem(cxPage.BuySell pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formKademeIslem_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formKademeIslem_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formKademeIslem_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formKademeIslem_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formKademeIslem_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formKademeIslem_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formKademeIslem_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkAciga_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboAccountName_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboAccountName_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboAccountNo_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboAccountNo_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridDefault_CellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridDefault_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridDefault_CurrentCellChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKademe_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKademe_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKademe_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKademe_DragDrop(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKademe_DragOver(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKademe_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKademe_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKademe_Scroll(object sender, ScrollEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuAutoCenter_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuBistSureSub_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuBistEmirTipSub_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuCancelAll_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuCancelBuy_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuCancelSell_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuCloseAllBist_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuCloseSymbolPositions_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuKademeCount_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuOnay_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRequestPeriod_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuToolbar_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuVipSureSub_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuWarning_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelButtons_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelButtons_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelGrid_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelGrid_Paint(object sender, PaintEventArgs e)
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
	private void textSymbolSearch_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerDisplay_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerRequest_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] ConvertPageToByteArray()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayDefault()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DragDropMethod(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DragEnterMethod(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EventKEP(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrepareTables()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RequestData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMainToolbarSymbol()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPageParams(cxPage.BuySell pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateGrid()
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
	static formKademeIslem()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
