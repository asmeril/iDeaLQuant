using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formBuySellVip : FormControl
{
	public string AccountName;

	public string AccountNo;

	public string Symbol;

	public string SartSymbol;

	public double Price;

	public double Lot;

	public string Duration;

	public string OrderType;

	public string PriceType;

	public string SartTip;

	public string Direction;

	public bool improveBool;

	public bool AksamSeansBool;

	public double StopLevel;

	public DateTime EndDate;

	public bool AlgoEdit;

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

	private Label lblEmirTipi;

	private Label lblSure;

	private Label lblMiktar;

	private ComboBox comboOrderType;

	private ComboBox comboDuration;

	private ComboBox comboLot;

	private ComboBox comboPrice;

	private Label lblFiyat;

	private Label lblSozlesme;

	private Button buttonSend;

	private Label labelAccountNo;

	private ComboBox comboAccountNo;

	private Label labelAccountName;

	private ComboBox comboAccountName;

	private ComboBox comboBuySell;

	private Button buttonImproveOrder;

	private ComboBox comboSartTipi;

	private Label lblSartTipi;

	private ComboBox comboStopLevel;

	private Label labelStopLevel;

	private DateTimePicker dateEndDate;

	private Label lblTarih;

	private ComboBox comboSymbol;

	private Label labelAlgo;

	private ComboBox comboSartSozlesme;

	private Label lblSartSozlesme;

	private Panel panelSart;

	private CheckBox checkSartEmir;

	private CheckBox checkAksamSeans;

	private ComboBox comboSessionType;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formBuySellVip(int leftX, int topX, cxPage.BuySell pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBuySellVip_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBuySellVip_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBuySellVip_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBuySellVip_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBuySellVip_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBuySellVip_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBuySellVip_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonImproveOrder_Click(object sender, EventArgs e)
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
	private void comboBuySell_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboDuration_SelectedValueChanged(object sender, EventArgs e)
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
	private void comboOrderType_SelectedValueChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboPriceType_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboSymbol_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboSartSozlesme_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelAlgo_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PortfolioReceived(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckControls()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CheckAksamSeansTime()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool grup1Check(string Symbolx)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillPriceList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillSartPriceList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillSartSemboller(string Symbolx)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillSureCombo()
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
	private void SetDefaultFiyat()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetAksamSeans(string symbolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMainToolbarSymbol()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] ConvertPageToByteArray()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ImproveOrder()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxPortfolio.BuySellRecord PrepareBuySell(bool showmessageboxX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkSartEmir_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkAksamSeans_CheckedChanged(object sender, EventArgs e)
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
	static formBuySellVip()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
