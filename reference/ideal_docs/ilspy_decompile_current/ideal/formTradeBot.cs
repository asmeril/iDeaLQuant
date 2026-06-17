using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class formTradeBot : FormControl
{
	public int Kep2AktifEmirTip;

	public string AccountName;

	public string AccountNo;

	public string Symbol;

	public string Seri;

	private cxPage.BuySell PageParams;

	private List<float> Bids;

	private List<float> Asks;

	private static int kademeRowcount;

	private static int kademeRowcountViop;

	private bool[] BidUpdate;

	private bool[] AskUpdate;

	private Dictionary<decimal, int> PriceDictionary;

	private Stopwatch StopWatch1;

	private List<cxPortfolio.ImkbOrderRecord> ImkbOrderList;

	private List<cxPortfolio.VipOrderRecord> VipOrderList;

	private List<cxPortfolio.VipOrderRecord> VipGerOrderList;

	private List<cxPortfolio.ImkbPositionRecord> ImkbPositionList;

	private List<cxPortfolio.VipPositionRecord> VipPositionList;

	private Dictionary<string, string> ImkbSummaryDictionary;

	private ConcurrentDictionary<decimal, TradeBotColorPriceClass> TradeBotColorPrice;

	private Rectangle DragDropRect;

	private int MouseDownRowNo;

	private string MouseDownColName;

	private cxButton HeaderButtons;

	private cxButton Buttons1;

	private int kademeSayRobo;

	public bool OverLoadPrice;

	public string SellType;

	private bool ShowOzetBool;

	private decimal RoboBidPrice;

	private decimal RoboAskPrice;

	private int RoboBidLine;

	private int RoboAskLine;

	private List<float> RoboBids;

	private List<float> RoboAsks;

	private bool[] RoboBidUpdate;

	private bool[] RoboAskUpdate;

	private Dictionary<decimal, int> RoboPriceDictionary;

	private bool RoboReCenterBool;

	private bool RoboInitReCenterBool;

	private int TimerCount30;

	private bool HesapRefreshBool;

	private string ActiveKey;

	private IContainer components;

	private Panel panelRobo;

	private CheckBox checkBoxIzleyen;

	private Label label3;

	private Label label2;

	private NumericUpDown numericStop;

	private NumericUpDown numericKaral;

	private DataGridView gridToplamRobo;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

	private MyButton myButtonRoboAyarlar;

	private MyButton myButtonRoboOrtala;

	private TextBox textRoboPosition;

	private DataGridView gridLot;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

	private TextBox textRoboSymbolSearch;

	private DataGridView gridRobo;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;

	private Timer timerDisplay;

	public ComboBox comboAccountNo;

	public ComboBox comboAccountName;

	private Timer timerRequest;

	private Panel panelOzet;

	private DataGridView gridOzet;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;

	private DataGridViewTextBoxColumn Column2;

	private DataGridViewTextBoxColumn Column3;

	private MyButton myButtonTradeBotlistShow;

	private Panel panelDetay;

	private TextBox txtBoxSP;

	private Label labelDetaySL;

	private Panel panelDetayHeader;

	private Label labelDetayHeaderClose;

	private MyButton myButtonPanelDetayKaydet;

	private Label labelDetayFiyat;

	private Label label1;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formTradeBot(cxPage.BuySell pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTradeBot_Activated(object sender, EventArgs e)
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
	private void formTradeBot_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReCenterGrid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTradeBot_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTradeBot_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTradeBot_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTradeBot_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobo_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobo_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobo_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobo_DragOver(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobo_DragDrop(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonRoboOrtala__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridLot_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridToplamRobo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridOzet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textRoboSymbolSearch_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textRoboSymbolSearch_Leave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textRoboSymbolSearch_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textRoboSymbolSearch_KeyPress(object sender, KeyPressEventArgs e)
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
	private void DisplayRoboData(bool refillfiyatboolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayDefault()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayOzet()
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
	private void SetKademeArray()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetKey()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMainToolbarSymbol()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowTradeBot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DetayPanelShow(TradeBotEmirClass orderx)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DetayPanelClose()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobo_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobo_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonTradeBotlistShow__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelDetayHeaderClose_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridOzet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonPanelDetayKaydet__OnClick(object sender, EventArgs e)
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
	static formTradeBot()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		kademeRowcount = 800;
		kademeRowcountViop = 800;
	}
}
