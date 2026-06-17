using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formZincirImkb : FormControl
{
	public string ActiveSymbol;

	public string AccountName;

	public string AccountNo;

	public string Symbol;

	public double Price;

	public double Lot;

	public string Duration;

	public string OrderType;

	public string SellType;

	public string Direction;

	private string LocalOrderKey;

	private DateTime EndDate;

	private cxPage.BuySell PageParams;

	private int InitialLeft;

	private int InitialTop;

	private cxPortfolio.ImkbOrderRecord OrderImkb;

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

	private Label textAccountNameRef;

	private Label textAccountNoRef;

	private Label textBuyable;

	private Label labelBuyable;

	private Label textLimit;

	private Label labelLimit;

	private Label textTotal;

	private Label labelTotal;

	private ContextMenuStrip menuprice;

	private ToolStripComboBox menupriceCombo;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripMenuItem menupriceLast;

	private ToolStripMenuItem menupriceBid;

	private ToolStripMenuItem menupriceAsk;

	private ToolStripMenuItem menupriceMax;

	private ToolStripMenuItem menupriceMin;

	private ToolStripSeparator toolStripSeparator2;

	private ToolStripMenuItem menupriceLastPlus3;

	private ToolStripMenuItem menupriceLastPlus2;

	private ToolStripMenuItem menupriceLastPlus1;

	private ToolStripMenuItem menupriceLastMinus1;

	private ToolStripMenuItem menupriceLastMinus2;

	private ToolStripMenuItem menupriceLastMinus3;

	private ContextMenuStrip menuordertype;

	private ToolStripMenuItem menuordertypeLimit;

	private ToolStripMenuItem menuordertypePiyasa;

	private ToolStripMenuItem menuordertypePiyasadanLimit;

	private ContextMenuStrip menuduration;

	private ToolStripMenuItem menudurationGun;

	private ToolStripMenuItem menudurationKIE;

	private ToolStripMenuItem menudurationDenge;

	private Label labelSell;

	private Label labelBuy;

	private ContextMenuStrip menuheader;

	private ToolStripMenuItem menuheaderSellType;

	private ToolStripMenuItem menuheaderSellTypeNormal;

	private ToolStripMenuItem menuheaderSellTypeAciga;

	private ToolStripMenuItem menuheaderSellTypeVirmandan;

	private Panel panelLot;

	private ComboBox comboLot;

	private Label label1;

	private Label labelOrderRef;

	private Label labelSymbolRef;

	private Label label2;

	private Label labelPriceRef;

	private Label label5;

	private Label labelLotRef;

	private Label label4;

	private Label labelDirectionRef;

	private Label label6;

	private CheckBox checkZincirGKY;

	private Label textTarih;

	private Label labelTarih;

	private ToolStripMenuItem menuordertypeDenge;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formZincirImkb(int leftX, int topX, cxPortfolio.ImkbOrderRecord orderX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formZincirImkb_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formZincirImkb_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formZincirImkb_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formZincirImkb_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formZincirImkb_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formZincirImkb_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkZincirGKY_CheckedChanged(object sender, EventArgs e)
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
	private void labelTarih_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuduration_Click(object sender, EventArgs e)
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
	private void menupriceCombo_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menupriceSelect_Click(object sender, EventArgs e)
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
	private void textPrice_MouseDown(object sender, MouseEventArgs e)
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
	private void textSymbol_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textTarih_MouseDown(object sender, MouseEventArgs e)
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
	private void SetColors()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowTotal()
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
	static formZincirImkb()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
