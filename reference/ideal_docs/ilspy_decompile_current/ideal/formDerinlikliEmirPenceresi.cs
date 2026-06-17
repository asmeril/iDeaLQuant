using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formDerinlikliEmirPenceresi : FormControl
{
	public string Symbol;

	public double Price;

	public double Lot;

	public string Duration;

	public string OrderType;

	public string SellType;

	public string Direction;

	public string AcigaSatisKapama;

	public string AccountName;

	public string AccountNo;

	public bool DEPBilgiGizle;

	public bool DEPDerinlikGizle;

	public bool DEPEmirleriGizle;

	private int DepthLineCount;

	private int LineSpace;

	public string ActiveSymbol;

	public string Prefix;

	public int DecimalPoint;

	private cxPage.DepBuySell PageParams;

	private string InitialSymbol;

	private int InitialLeft;

	private int InitialTop;

	public List<double> KademeLotList;

	private int TitleHeight;

	private cxButton HeaderButtons;

	private cxDepth DepthItem;

	private cxBasic BasicItem;

	private bool FormLoaded;

	private Stopwatch CheckTime;

	private cxFont.Margin FontMargin;

	private Font FontHeader;

	private string LocalOrderKey;

	public bool KucukBool;

	private List<cxPortfolio.ImkbOrderRecord> ImkbOrderList;

	private List<cxPortfolio.VipOrderRecord> VipOrderList;

	private List<cxPortfolio.ImkbPositionRecord> ImkbPositionList;

	private List<cxPortfolio.VipPositionRecord> VipPositionList;

	private Dictionary<string, string> ImkbSummaryDictionary;

	private long RequestTime;

	private long ElapsedTimer800;

	private long ElapsedTimer2000;

	private decimal BestBekleyenAlisFiyat;

	private decimal BestBekleyenSatisFiyat;

	private bool HesapRefreshBool;

	private IContainer components;

	private ContextMenuStrip MenuAyarlar;

	private ToolStripMenuItem derinlikToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem2;

	private ToolStripMenuItem toolStripMenuItem3;

	private ToolStripMenuItem emirleriGösterToolStripMenuItem;

	private ToolStripMenuItem gosterToolStrip;

	private ToolStripMenuItem gizleToolStripMenuItem;

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

	private ToolStripMenuItem derinliğiGösterToolStripMenuItem;

	private ToolStripMenuItem gosterToolStripMenuItem;

	private ToolStripMenuItem DerinlikGizleToolStripMenuItem1;

	private ContextMenuStrip menuLot;

	private ToolStripMenuItem toolStripMenuItem10;

	private ToolStripMenuItem toolStripMenuItem11;

	private ToolStripMenuItem toolStripMenuItem7;

	private ToolStripMenuItem toolStripMenuItem8;

	private ToolStripMenuItem toolStripMenuItem4;

	private ToolStripMenuItem toolStripMenuItem5;

	private ToolStripMenuItem Lot1;

	private ToolStripMenuItem Lot2;

	private ToolStripMenuItem Lot5;

	private ToolStripMenuItem Lot10;

	private ToolStripMenuItem Lot20;

	private ToolStripMenuItem Lot50;

	private ToolStripMenuItem LotYuz;

	private ToolStripMenuItem Lot2yuz;

	private ToolStripMenuItem Lot5yuz;

	private ToolStripMenuItem LotBin;

	private ToolStripMenuItem Lot2Bin;

	private ToolStripMenuItem Lot5Bin;

	private ToolStripMenuItem Lot10Bin;

	private ToolStripMenuItem Lot25Bin;

	private ToolStripMenuItem Lot50Bin;

	private ToolStripMenuItem lot75Bin;

	private ToolStripMenuItem Lot100Bin;

	private ToolStripMenuItem Lot250Bin;

	private Timer timerRefresh;

	private ToolStripMenuItem bilgileriGizleToolStripMenuItem;

	private ToolStripMenuItem gizleToolStripMenuItem1;

	private ToolStripMenuItem gosterToolStripMenuItem1;

	private ToolStripMenuItem MenuItemSatisTipi;

	private ToolStripMenuItem MenuItemSatisTipiNormal;

	private ToolStripMenuItem MenuItemSatisTipiAciga;

	private MyButton btnSAT;

	private MyButton btnAL;

	private MyButton btnNormalAl;

	private Label lblSonGerceklesenMik;

	private TextBox textPrice;

	private MyButton btnNormalSat;

	private Label labelPriceArrow;

	private Label labelAKTIFSAT;

	private Label labelLotArrow;

	private Label labelAKTIFAL;

	private ComboBox comboAccountNo;

	private NumericUpDown txtEmirMiktar;

	private ComboBox comboAccountName;

	private ComboBox comboOrderType;

	private ComboBox comboDuration;

	private DataGridView dgvBekleyenIslem;

	private DataGridView dgvDepth;

	private Label btnSatisStok;

	private Label btnAlisStok;

	private Panel panelAltButtonlar;

	private MyButton btnAlisIptal;

	private MyButton btnSatisIptal;

	private MyButton btnEmirlerIptal;

	private Panel panelContainer;

	private ToolStripMenuItem MenuItemEnBuyukPencere;

	private ToolStripMenuItem MenuItemEnKucukPencere;

	private ToolStripMenuItem MenuItemTopMost;

	private TextBox textSymbolSearch;

	private DataGridView gridBilgiler;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn Column11;

	private DataGridViewTextBoxColumn Alan2;

	private DataGridViewTextBoxColumn Deger2;

	private DataGridViewTextBoxColumn alan3;

	private DataGridViewTextBoxColumn deger3;

	private ToolStripMenuItem MenuItemOnayPenceresi;

	private DataGridView gridDefault;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

	private MyButton btnAlisAktif;

	private MyButton btnSatisAktif;

	private NumericUpDown txtGorunenMiktar;

	private Label labelGorununMiktar;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formDerinlikliEmirPenceresi(int leftX, int topX, string symbolX, cxPage.DepBuySell pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnAL_MouseHover(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnAL__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnAlisAktif__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnAlisIptal__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnEmirlerIptal__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnNormalAl__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnNormalSat__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnSAT_MouseHover(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnSAT__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnSatisAktif__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnSatisIptal__OnClick(object sender, EventArgs e)
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
	private void comboAccountNo_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboAccountNo_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboOrderType_SelectedValueChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CxEvent_DepthUpdateRowReceived(string symbolX, char bidasktypeX, int rowX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DepthUpdateListReceived(string symbolX, List<int> listX)
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
	private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
	private void DerinlikGizleToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dgvBekleyenIslem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dgvBekleyenIslem_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dgvBekleyenIslem_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dgvDepth_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gizleToolStripMenuItem1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gosterToolStrip_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gosterToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gosterToolStripMenuItem1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDerinlikliEmirPenceresi_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDerinlikliEmirPenceresi_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDerinlikliEmirPenceresi_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDerinlikliEmirPenceresi_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelLotArrow_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelPriceArrow_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuLot_Click(object sender, EventArgs e)
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
	private void panelContainer_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textPrice_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbolSearch_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbolSearch_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbolSearch_Leave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TextPrice_MouseWheel(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TxtEmirMiktar_MouseWheel(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerRefresh_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DepthCellUpdate(DataGridViewCell cellX, float valueX, Color refreshBackColor, Color refreshForeColor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void toolStripMenuItem2_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void toolStripMenuItem3_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void alSatOnayPenceresi(string yon, string fiyat, bool aciga)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ComboDoldur(bool setBoolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Reorder()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string VipSureConvert(string sureX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayData(char yonX, int rowX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RequestData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DerinlikGridClear()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DerinlikGridDegerler()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fillDepth()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fillIslemler()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fillPortfoyInfoWrite()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MessageReceived(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PortfolioReceived(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private cxPortfolio.BuySellRecord PrepareBuySell(bool showmessageboxX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrepareTables()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMainToolbarSymbol()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPageParams(cxPage.DepBuySell pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] ConvertPageToByteArray()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MenuItemSatisTipiNormal_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MenuItemOnayPenceresi_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MenuItemSatisTipiAciga_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MenuItemEnBuyukPencere_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MenuItemEnKucukPencere_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MenuItemTopMost_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelContainer_DragDrop(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridBilgiler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridDefault_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridDefault_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridDefault_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridDefault_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridDefault_CellClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnAlisAktif__OnClick_1(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnSatisAktif__OnClick_1(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDerinlikliEmirPenceresi_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridBilgiler_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboDuration_SelectedIndexChanged(object sender, EventArgs e)
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
	static formDerinlikliEmirPenceresi()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
