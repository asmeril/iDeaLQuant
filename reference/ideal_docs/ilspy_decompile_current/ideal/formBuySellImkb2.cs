using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formBuySellImkb2 : FormControl
{
	public string AccountName;

	public string AccountNo;

	public string Symbol;

	public double Price;

	public double Lot;

	public string Duration;

	public string OrderType;

	public string SellType;

	public string Direction;

	public DateTime ValorDate;

	private string LocalOrderKey;

	private cxPage.BuySell PageParams;

	private int InitialLeft;

	private int InitialTop;

	private Font FontHeader;

	private cxButton HeaderButtons;

	private Pen Pen1;

	private Pen Pen2;

	private SolidBrush Brush1;

	private SolidBrush BrushBack;

	private SolidBrush BrushFore;

	private Rectangle Rect1;

	private string Str1;

	private IContainer components;

	private Panel panelGrid;

	private Label labelPrice;

	private TextBox textSymbol;

	private TextBox textPrice;

	private Label labelSymbol;

	private TextBox textLot;

	private Label labelLot;

	private Label textOrderType;

	private Label labelOrderType;

	private Label textDuration;

	private Label labelDuration;

	private Label textAccountName;

	private Label textAccountNo;

	private Label labelAccountNo;

	private Label textBuyable;

	private Label labelBuyable;

	private Label textLimit;

	private Label labelLimit;

	private Label textTotal;

	private Label labelTotal;

	private ContextMenuStrip menuordertype;

	private ToolStripMenuItem menuordertypeLimit;

	private ToolStripMenuItem menuordertypePiyasa;

	private ToolStripMenuItem menuordertypePiyasadanLimit;

	private ToolStripMenuItem menuordertypeDenge;

	private ToolStripMenuItem menuordertypeMidpointLimit;

	private ToolStripMenuItem menuordertypeMidpointPiyasa;

	private ContextMenuStrip menuduration;

	private ToolStripMenuItem menudurationDay;

	private ToolStripMenuItem menudurationKIE;

	private ToolStripMenuItem menudurationDenge;

	private Label labelSell;

	private Label labelBuy;

	private Panel panelAccountName;

	private ComboBox comboAccountName;

	private Panel panelAccountNo;

	private ComboBox comboAccountNo;

	private ContextMenuStrip menuheader;

	private ToolStripMenuItem menuheaderDisplayTotal;

	private ToolStripMenuItem menuheaderDisplayLimit;

	private ToolStripMenuItem menuheaderDisplayBuyable;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripMenuItem menuheaderSellType;

	private ToolStripMenuItem menuheaderSellTypeNormal;

	private ToolStripMenuItem menuheaderSellTypeAciga;

	private ToolStripMenuItem menuheaderSellTypeVirmandan;

	private Panel panelLot;

	private ComboBox comboLot;

	private Label labelPriceArrow;

	private Label labelDurationArrow;

	private Label labelOrderTypeArrow;

	private Label labelLotArrow;

	private Label textSellable;

	private Label labelSellable;

	private ToolStripMenuItem menuheaderDisplaySellable;

	private ToolStripMenuItem iceBergToolStripMenuItem;

	private ToolStripMenuItem menudurationIKG;

	private Panel panelAmoungShowing;

	private ComboBox comboAmountShowing;

	private Label labelValorArrow;

	private Label labelValorSelect;

	private Label labelValor;

	private ContextMenuStrip menuprice;

	private ToolStripComboBox menupriceCombo;

	private ToolStripMenuItem menupriceLast;

	private ToolStripMenuItem menupriceBid;

	private ToolStripMenuItem menupriceAsk;

	private ToolStripMenuItem menupriceMax;

	private ToolStripMenuItem menupriceMin;

	private ToolStripSeparator toolStripSeparator2;

	private ToolStripMenuItem menupriceLastPlus5;

	private ToolStripMenuItem menupriceLastPlus4;

	private ToolStripMenuItem menupriceLastPlus3;

	private ToolStripMenuItem menupriceLastPlus2;

	private ToolStripMenuItem menupriceLastPlus1;

	private ToolStripMenuItem menupriceLastMinus1;

	private ToolStripMenuItem menupriceLastMinus2;

	private ToolStripMenuItem menupriceLastMinus3;

	private ToolStripMenuItem menupriceLastMinus4;

	private ToolStripMenuItem menupriceLastMinus5;

	private TextBox textAmountShowing;

	private Label labelAmountShowing;

	private Label labelAmountShowingArrow;

	private DateTimePicker dateTimePicker1;

	private ToolStripMenuItem menuheaderSellTypeASK;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formBuySellImkb2(int leftX, int topX, cxPage.BuySell pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBuySellImkb2_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBuySellImkb2_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBuySellImkb2_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBuySellImkb2_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBuySellImkb2_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBuySellImkb2_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBuySellImkb2_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboAccountName_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboAccountName_SelectedValueChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboAccountNo_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboAccountNo_SelectedValueChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboLot_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboLot_SelectedValueChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelBuy_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelDuration_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelLot_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelOrderType_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelPrice_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelSell_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuduration_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuheaderDisplayBuyable_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuheaderDisplayLimit_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuheaderDisplaySellable_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuheaderDisplayTotal_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuheaderSellType_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuordertype_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menupriceActive_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menupriceCombo_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menupriceSelect_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textAccountName_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textAccountNo_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textLot_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textLot_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textPrice_TextChanged(object sender, EventArgs e)
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
	private void textSymbol_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PortfolioReceived(string messageX)
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
	private cxPortfolio.BuySellRecord PrepareBuySell()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrepareTables()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SendOrder(string directionX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPageParams(cxPage.BuySell pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetColors()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMainToolbarSymbol()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowTotal()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowValorForm()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] ConvertPageToByteArray()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboAmountShowing_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboAmountShowing_SelectedValueChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelAmountShowingArrow_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelValorArrow_MouseDown(object sender, MouseEventArgs e)
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
	static formBuySellImkb2()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
