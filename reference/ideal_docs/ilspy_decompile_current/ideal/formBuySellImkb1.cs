using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formBuySellImkb1 : FormControl
{
	public string AccountName;

	public string AccountNo;

	public string Symbol;

	public double Price;

	public double Lot;

	public string Duration;

	public string OrderType;

	public string Direction;

	public string SellType;

	public string AcigaSatisKapama;

	private string LocalOrderKey;

	private cxPage.BuySell PageParams;

	private int InitialLeft;

	private int InitialTop;

	private bool FormLoaded;

	private Font FontHeader;

	private cxButton HeaderButtons;

	private Pen Pen1;

	private Pen Pen2;

	private SolidBrush Brush1;

	private SolidBrush BrushBack;

	private SolidBrush BrushFore;

	private Rectangle Rect1;

	private Rectangle Rect2;

	private string Str1;

	private IContainer components;

	private Panel panelGrid;

	private Label label5;

	private Label label4;

	private Label label3;

	private ComboBox comboOrderType;

	private ComboBox comboDuration;

	private ComboBox comboLot;

	private ComboBox comboPrice;

	private Label labelFiyat;

	private Label labelHisse;

	private ComboBox comboSellType;

	private Button buttonSend;

	private Label labelAccountNo;

	private ComboBox comboAccountNo;

	private Label labelAccountName;

	private ComboBox comboAccountName;

	private ComboBox comboBuySell;

	private Button buttonReady;

	private Button buttonEditReadyOrder;

	private ComboBox comboSymbol;

	private Label textSellable;

	private Label labelSellable;

	private Label textBuyable;

	private Label labelBuyable;

	private Label textLimit;

	private Label labelLimit;

	private Label textTotal;

	private Label labelTotal;

	private ComboBox comboAcigaSatisKapama;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formBuySellImkb1(int leftX, int topX, cxPage.BuySell pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBuySellImkb_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBuySellImkb_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBuySellImkb_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBuySellImkb_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBuySellImkb_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBuySellImkb_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBuySellImkb_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonEditReadyOrder_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonReady_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonSend_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboAccountName_SelectedValueChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboAccountNo_SelectedValueChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboAcigaSatisKapama_SelectedValueChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBuySell_SelectedValueChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboLot_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboLot_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboPrice_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboSellType_SelectedValueChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboSymbol_SelectionChangeCommitted(object sender, EventArgs e)
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
	private void SetSellLot()
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
	public byte[] ConvertPageToByteArray()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EditReadyOrder()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxPortfolio.BuySellRecord PrepareBuySell(bool showmessageboxX)
	{
		return null;
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
	static formBuySellImkb1()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
