using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formBuySellImkb3 : FormControl
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

	public string AcigaSatisKapama;

	public DateTime ValorDate;

	public bool KucukBool;

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

	private ContextMenuStrip menuprice;

	private ToolStripComboBox menupriceCombo;

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

	private ContextMenuStrip menuduration;

	private ToolStripMenuItem menudurationDay;

	private Panel panelAccountName;

	private ComboBox comboAccountName;

	private Panel panelAccountNo;

	private ComboBox comboAccountNo;

	private ContextMenuStrip menuheader;

	private ToolStripMenuItem menuheaderDisplayTotal;

	private ToolStripMenuItem menuheaderDisplayLimit;

	private ToolStripMenuItem menuheaderDisplayBuyable;

	private RadioButton radioSell;

	private RadioButton radioBuy;

	private Label labelSend;

	private Label labelReady;

	private Panel panelLot;

	private ComboBox comboLot;

	private Label labelDurationArrow;

	private Label labelOrderTypeArrow;

	private Label labelLotArrow;

	private Label labelPriceArrow;

	private ToolStripMenuItem menuheaderDisplaySellable;

	private Label textSellable;

	private Label labelSellable;

	private Label labelSellType;

	private ContextMenuStrip menuselltype;

	private ToolStripMenuItem menuselltypeNormal;

	private ToolStripMenuItem menuselltypeAciga;

	private ToolStripMenuItem menuselltypeVirmanli;

	private Label labelAcigaSatisKapama;

	private ContextMenuStrip menuacigasatiskapama;

	private ToolStripMenuItem menuacigasatiskapamaNormal;

	private ToolStripMenuItem menuacigasatiskapamaASK;

	private Label labelAlgo;

	private Label labelEdit;

	private Panel panelSms;

	private CheckBox checkMail;

	private CheckBox checkSms;

	private Label labelValor;

	private DateTimePicker dateTimePicker1;

	private Label labelValorArrow;

	private Label labelValorSelect;

	private ToolStripMenuItem menudurationKIE;

	private ToolStripMenuItem menudurationDenge;

	private ToolStripMenuItem menuordertypeLimit;

	private ToolStripMenuItem menuordertypePiyasa;

	private ToolStripMenuItem menuordertypePiyasadanLimit;

	private ToolStripMenuItem menuordertypeMidpointLimit;

	private ToolStripMenuItem menuordertypeMidpointPiyasa;

	private ToolStripMenuItem menudurationIKG;

	private ToolStripMenuItem menuordertypeDenge;

	private ToolStripMenuItem menuselltypeGuniciAciga;

	private ToolStripMenuItem menupriceLastPlus5;

	private ToolStripMenuItem menupriceLastPlus4;

	private ToolStripMenuItem menupriceLastMinus4;

	private ToolStripMenuItem menupriceLastMinus5;

	private ToolStripMenuItem ıceBergToolStripMenuItem;

	private Label labelAmountShowing;

	private TextBox textAmountShowing;

	private Label labelAmountShowingArrow;

	private Panel panelAmoungShowing;

	private ComboBox comboAmountShowing;

	private ToolStripMenuItem menuheaderKucukBool;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formBuySellImkb3(int leftX, int topX, cxPage.BuySell pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBuySellImkb3_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBuySellImkb3_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBuySellImkb3_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBuySellImkb3_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBuySellImkb3_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBuySellImkb3_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBuySellImkb3_SizeChanged(object sender, EventArgs e)
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
	private void labelAcigaSatisKapama_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelAlgo_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelDuration_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelEdit_Click(object sender, EventArgs e)
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
	private void labelReady_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelSellType_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelSend_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelValorArrow_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuacigasatiskapamaASK_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuacigasatiskapamaNormal_Click(object sender, EventArgs e)
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
	private void menuheaderKucukBool_Click(object sender, EventArgs e)
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
	private void menuselltypeAciga_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuselltypeNormal_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuselltypeVirmanli_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuselltypeGuniciAciga_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioDirection_Click(object sender, EventArgs e)
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
	private void textLot_MouseDown(object sender, MouseEventArgs e)
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
	private void PrepareTables()
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
	private void SetSellLot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowAcigaSatisKapama()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowSellType()
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
	public void EditOrder()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxPortfolio.BuySellRecord PrepareBuySell(bool showmessageboxX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelAmountShowingArrow_MouseDown(object sender, MouseEventArgs e)
	{
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
	private void menuselltypeASK_Click(object sender, EventArgs e)
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
	static formBuySellImkb3()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
