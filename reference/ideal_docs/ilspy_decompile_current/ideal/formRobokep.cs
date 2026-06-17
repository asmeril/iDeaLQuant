using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class formRobokep : FormControl
{
	public int Kep2AktifEmirTip;

	public string AccountName;

	public string AccountNo;

	public string Symbol;

	public string Seri;

	private cxPage.BuySell PageParams;

	private decimal BidPrice;

	private decimal AskPrice;

	private int BidLine;

	private int AskLine;

	private List<float> Bids;

	private List<float> Asks;

	private static int kademeRowcount;

	private static int kademeRowcountViop;

	private bool[] BidUpdate;

	private bool[] AskUpdate;

	private Dictionary<decimal, int> PriceDictionary;

	private bool ReCenterBool;

	private Stopwatch StopWatch1;

	private List<cxPortfolio.ImkbOrderRecord> ImkbOrderList;

	private List<cxPortfolio.VipOrderRecord> VipOrderList;

	private List<cxPortfolio.VipOrderRecord> VipGerOrderList;

	private List<cxPortfolio.ImkbPositionRecord> ImkbPositionList;

	private List<cxPortfolio.VipPositionRecord> VipPositionList;

	private Dictionary<string, string> ImkbSummaryDictionary;

	private Rectangle DragDropRect;

	private int MouseDownRowNo;

	private string MouseDownColName;

	private cxButton HeaderButtons;

	private cxButton Buttons1;

	private int kademeSay;

	private int kademeSayRobo;

	public bool OverLoadPrice;

	private int AktifSatirNo;

	private string AktifSutunName;

	private int TimerCount30;

	private decimal BestBekleyenAlisFiyat;

	private decimal BestBekleyenSatisFiyat;

	private bool HesapRefreshBool;

	private int AktifPanelNo;

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

	private decimal RoboBestBekleyenAlisFiyat;

	private decimal RoboBestBekleyenSatisFiyat;

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

	private Label labelGNet;

	private Timer timerRequest;

	private ToolStripMenuItem menuRequestPeriod;

	private ToolStripMenuItem menuWarning;

	private ToolStripMenuItem menuCloseAllBist;

	private ToolStripMenuItem menuCloseSymbolPositions;

	private Label labelOverall;

	private CheckBox checkAciga;

	private ToolStripMenuItem menuToolbar;

	private ToolStripMenuItem menuAutoCenter;

	private ToolStripMenuItem menuKademeCount;

	private ToolStripMenuItem menuBistEmirTip;

	private ToolStripMenuItem menuBistEmirTipNormal;

	private ToolStripMenuItem menuBistEmirTipKPY;

	private ToolStripMenuItem menuBistEmirTipKIE;

	private ToolStripMenuItem menuVipSureKIE;

	private ToolStripMenuItem menuVipSureGIE;

	private ToolStripMenuItem menuKademeRenk;

	private ToolStripMenuItem menuKademeRenkFiyatAlisZemin;

	private ToolStripMenuItem menuKademeRenkFiyatAlisYazi;

	private ToolStripMenuItem menuKademeRenkFiyatSatisZemin;

	private ToolStripMenuItem menuKademeRenkFiyatSatisYazi;

	private ToolStripMenuItem menuKademeRenkAlistaBekleyenZemin;

	private ToolStripMenuItem menuKademeRenkAlistaBekleyenYazi;

	private ToolStripMenuItem menuKademeRenkSatistaBekleyenZemin;

	private ToolStripMenuItem menuKademeRenkSatistaBekleyenYazi;

	private ToolStripMenuItem menuKademeRenkDerinlikDegisimZemin;

	private ToolStripMenuItem menuKademeRenkDerinlikDegisimYazi;

	private ToolStripMenuItem menuKademeRenkCizgi;

	private ToolStripMenuItem menuKademeRenkBaslikZemin;

	private ToolStripMenuItem menuKademeRenkBaslikYazi;

	private ToolStripMenuItem menuAktifEmirTip;

	private ToolStripMenuItem menuAktifEmirTipSub0;

	private ToolStripMenuItem menuAktifEmirTipSub1;

	private ToolStripMenuItem menuDonusMesaj;

	private ToolStripSeparator toolStripSeparator3;

	private MyButton myButtonOrtala;

	private MyButton myButtonAyarlar;

	private Label labelProfit;

	private MyButton myButtonAktifAl;

	private MyButton myButtonAktifSat;

	private MyButton myButtonTumIptal;

	private MyButton myButtonSatislarIptal;

	private MyButton myButtonAlislarIptal;

	private Label labelInfo3;

	private Label labelInfo1;

	private MyButton myButtonInfo4;

	private MyButton myButtonInfo2;

	private DataGridView gridToplam;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private ToolStripMenuItem menuAktifSatirRenklensin;

	private ToolStripMenuItem menuAktifSatirAlisZemin;

	private ToolStripMenuItem menuAktifSatirAlisYazi;

	private ToolStripMenuItem menuAktifSatirSatisZemin;

	private ToolStripMenuItem menuAktifSatirSatisYazi;

	private MyButton myButtonPysLmt;

	private ToolTip toolTip;

	private ToolStripMenuItem menuKademeRenkVarsayilan;

	private ToolStripSeparator toolStripSeparator2;

	private ToolStripMenuItem menuGrup;

	private ToolStripMenuItem menuBakiyeGizle;

	private Panel panelRobo;

	private CheckBox checkBoxIzleyen;

	private Label label3;

	private Label label2;

	private NumericUpDown numericStop;

	private NumericUpDown numericKaral;

	private DataGridView gridToplamRobo;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

	private MyButton myButtonRoboTumIptal;

	private MyButton myButtonRoboSatislarIptal;

	private MyButton myButtonRoboAlislarIptal;

	private MyButton myButtonRoboAyarlar;

	private MyButton myButtonRoboOrtala;

	private CheckBox checkBox1;

	private TextBox textRoboPosition;

	private DataGridView gridLot;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

	private TextBox textRoboSymbolSearch;

	private DataGridView gridRobo;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;

	private MyButton myButtonPortfoyden;

	private MyButton myButtonRoboKepTumIptal;

	private Panel panelOzet;

	private Panel panelIslem;

	private MyButton myButtonRoboEmirIptal;

	private Panel panelPortfoyden;

	private MyButton myButtonPortfoydenEkle;

	private MyButton myButtonPortfoydenVazgec;

	private Label label4;

	private NumericUpDown numericPortfoyden;

	private ContextMenuStrip menuRoboEmirIptal;

	private ToolStripMenuItem menuRoboEmirIptalAlislar;

	private ToolStripMenuItem menuRoboEmirIptalSatislar;

	private ToolStripMenuItem menuRoboEmirIptalTum;

	private ToolStripMenuItem menuRoboEmirIptalTumSemboller;

	private ToolStripSeparator toolStripMenuItem1;

	private DataGridView gridIslemler;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;

	private TextBox textCost;

	private TextBox textKZ;

	private DataGridView gridOzet;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;

	private DataGridViewTextBoxColumn Column2;

	private DataGridViewTextBoxColumn Column3;

	private RadioButton radioSatis;

	private RadioButton radioAlis;

	private ToolTip toolTip1;

	private ToolStripMenuItem menuAksamSeans;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formRobokep(cxPage.BuySell pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formRobokep_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formRobokep_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formRobokep_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formRobokep_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formRobokep_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formRobokep_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formRobokep_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formRobokep_SizeChanged(object sender, EventArgs e)
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
	private void BasicDataReceived(string symbolX, string updatetypeX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayData(bool refillfiyatboolX)
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
	private void MessageReceived(string messageX)
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
	private void SeviyeAyarOkuYaz(bool OkuYazBool)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PaintGridKademe()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridToplam_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKademe_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKademe_MouseLeave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuKademeRenkSub_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuKademeRenkVarsayilan_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuAktifSatirRenklensin_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuAktifEmirTipSub0_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuAktifEmirTipSub1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuDonusMesaj_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuAksamSeans_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonOrtala__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonAyarlar__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonAktifAl__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonAktifSat__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonAlislarIptal__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonSatislarIptal__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonTumIptal__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonPysLmt__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGrup_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuBakiyeGizle_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridIslemler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridLot_CellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridLot_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridLot_CurrentCellChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridOzet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
	private void gridRobo_MouseDown(object sender, MouseEventArgs e)
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
	private void gridToplamRobo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRoboEmirIptalAlislar_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRoboEmirIptalSatislar_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRoboEmirIptalTum_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRoboEmirIptalTumSemboller_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonRoboOrtala__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonRoboAyarlar__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonRoboAlislarIptal__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonRoboSatislarIptal__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonRoboTumIptal__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonRoboKepTumIptal__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonPortfoyden__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonPortfoydenVazgec__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonPortfoydenEkle__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonRoboEmirIptal__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textRoboSymbolSearch_KeyPress(object sender, KeyPressEventArgs e)
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
	private void FillIslemler()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillOzet()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetKademeArray()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobo_Scroll(object sender, ScrollEventArgs e)
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
	static formRobokep()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		kademeRowcount = 800;
		kademeRowcountViop = 800;
	}
}
