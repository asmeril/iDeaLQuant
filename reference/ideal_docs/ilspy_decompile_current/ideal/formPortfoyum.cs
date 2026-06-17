using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class formPortfoyum : Form
{
	private static List<string> fonEmirIzinBackOffice;

	public static formPortfoyum Reference;

	private DataGridView ActiveGrid;

	private Point PointGridMouseDown;

	private string ActiveSymbolImkb;

	private string ActiveSymbolVip;

	private string ImkbOrderSortKey;

	private bool ImkbOrderSortAscending;

	private string ImkbProfitSortKey;

	private bool ImkbProfitSortAscending;

	private string VipOrderSortKey;

	private bool VipOrderSortAscending;

	private List<cxPortfolio.FonPositionRecord> FonPositonList;

	private List<cxPortfolio.ImkbPositionRecord> ImkbPositionList;

	private List<cxPortfolio.ImkbPositionRecord> ImkbGrupPortfoyList;

	private List<cxPortfolio.ImkbOrderRecord> ImkbOrderList;

	private List<cxPortfolio.ImkbOrderRecord> ImkbGrupOrderList;

	private List<cxPortfolio.ImkbWaitingRecord> ImkbWaitingList;

	private List<cxPortfolio.ProfitRecord> ImkbProfitList;

	private List<cxPortfolio.BuySellRecord> ImkbBuySellList;

	private Dictionary<string, List<int>> ImkbPortfolioSymbolPositionDictionary;

	private Dictionary<string, bool> ImkbOrderSelectionDictionary;

	private Dictionary<string, List<int>> ImkbOrderSymbolPositionDictionary;

	private List<cxPortfolio.VipPositionRecord> VipPositionList;

	private List<cxPortfolio.VipOrderRecord> VipOrderList;

	private Dictionary<string, List<int>> VipPortfolioSymbolPositionDictionary;

	private Dictionary<string, bool> VipOrderSelectionDictionary;

	private Dictionary<string, List<int>> VipOrderSymbolPositionDictionary;

	private List<cxPortfolio.ProfitRecord> VipMaliyetList;

	private Dictionary<string, GrupEmirClass> ImkbGrupSembolDict;

	private List<GrupHesapClass> ImkbGrupHesapList;

	private List<cxPortfolio.VarlikRecord> VarlikList;

	private cxButton HeaderButtons;

	public cxButton ToolbarButtons;

	public cxButton ImkbReadyButtons;

	public cxButton ImkbPortfolioButtons;

	public cxButton ImkbOrderButtons;

	public cxButton ImkbWaitingButtons;

	public cxButton VipPortfolioButtons;

	public cxButton VipOrderButtons;

	public cxButton TabButtons;

	private string Str1;

	private bool BinlikAyrac;

	public static bool EmirlerSilinmesinBool;

	private DateTime UpdateTime;

	private Color FrameColor;

	private string PiyasaTip;

	private string AktifHisseTabName;

	private string AktifViopTabName;

	private string AktifFonTabName;

	public List<FieldRec> GridFieldList;

	public List<FieldRec> GridFieldDefs;

	private int MouseDownCol;

	private Thread ImkbProfitThread;

	public string ImkbProfitStatus;

	public string ImkbProfitAciklama;

	public string ImkbProfitHata;

	private Thread ImkbGrupPortfoyThread;

	public string ImkbGrupPortfoyStatus;

	public string ImkbGrupPortfoyAciklama;

	public string ImkbGrupPortfoyHata;

	public string ImkbGrupPortfoySortKey;

	private string ImkbPositionSortKey;

	private bool ImkbPositionSortAscending;

	private Thread VarlikThread;

	public string VarlikStatus;

	public string VarlikAciklama;

	public string VarlikHata;

	private double MaxVal;

	private double MinVal;

	private double IncVal;

	private int TarihselLastBarNo;

	private List<OverallRec> TarihselDataList;

	private IContainer components;

	private Panel panelLogin;

	private Button buttonAccountLogin;

	private TextBox textLoginPassword;

	private Label labelLoginPassword;

	private Label labelLoginParola;

	private TextBox textLoginParola;

	private Timer timerFilled;

	private Button buttonPasswordWindow;

	private Button buttonChangePassword;

	private TextBox textNewPassword2;

	private Label label10;

	private TextBox textNewPassword1;

	private Label label9;

	private TextBox textOldPassword;

	private Label label8;

	private TextBox textParola;

	private Label label12;

	private Panel panelTab;

	private Label label5;

	private Timer timerSave;

	private CheckBox chkRemember;

	private Button buttonSifreUnuttum;

	private Panel panelHeader;

	private Label labelHeader;

	private Label labelMinimizeWindow;

	private Label labelCloseWindow;

	private Panel panelMain;

	private Timer timer500;

	private ComboBox comboActiveAccountNo;

	private ComboBox comboActiveAccountName;

	private MyButton myButtonLogin;

	private MyButton myButtonLogout;

	private MyButton myButtonHesaplar;

	private MyButton myButtonUyari;

	private MyButton myButtonGuncelle;

	private MyButton myButtonAyarlar;

	public ContextMenuStrip menu;

	private ToolStripMenuItem menuPortfoy;

	private ToolStripSeparator toolStripSeparator10;

	private ToolStripMenuItem menuRenk;

	private ToolStripMenuItem menuFont;

	private MyButton myButtonExcel;

	private TabPage tabVipTarihselIslem;

	private DataGridView gridVipIslem;

	private TextBox txtVipIslemMenkul;

	private Label labelVipIslem05;

	private DateTimePicker dtpVipIslemBaslangic;

	private DateTimePicker dtpVipIslemBitis;

	private TabPage tabVipKZRapor;

	private DataGridView gridKZRaporSummary;

	private DataGridView gridVipKZRapor;

	private DateTimePicker datetimeVipKZRapor2;

	private DateTimePicker datetimeVipKZRapor1;

	private TabPage tabVipProfit;

	private DateTimePicker datetimeVipProfit2;

	private DateTimePicker datetimeVipProfit1;

	private DataGridView gridVipProfit;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn129;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn130;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn131;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn132;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn133;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn134;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn135;

	private TabPage tabVipStatement;

	private DateTimePicker datetimeVipStatement2;

	private DateTimePicker datetimeVipStatement1;

	private DataGridView gridVipStatement;

	private TabPage tabVipMaliyet;

	private DataGridView gridVipMaliyet;

	private TabPage tabVipOrder;

	private Panel panel6;

	private RadioButton radioVipOrder3;

	private RadioButton radioVipOrder2;

	private RadioButton radioVipOrder1;

	private RadioButton radioVipOrder0;

	private DataGridView gridVipOrder;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn88;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn93;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn97;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn99;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn100;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn101;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn102;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn103;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn104;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn105;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn106;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn107;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn108;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn109;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn110;

	private TabPage tabVipPortfolio;

	private TabPage tabImkbReady;

	private ComboBox comboKriter;

	private Panel panelImkbReadySymbol;

	private Button buttonImkbReadySymbolSell;

	private Button buttonImkbReadySymbolBuy;

	private Button buttonImkbReadySymbolAll;

	private TextBox textImkbReadySymbol;

	private DataGridView gridImkbReady;

	private TabPage tabImkbStatement;

	private DateTimePicker datetimeImkbStatement2;

	private DateTimePicker datetimeImkbStatement1;

	private DataGridView gridImkbStatement;

	private TabPage tabImkbGunKz;

	private DataGridView gridImkbProfit;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn73;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn74;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn75;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn76;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn77;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn78;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn79;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn80;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn81;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn82;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn83;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn84;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn85;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn86;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn87;

	private TabPage tabImkbOrder;

	private CheckBox checkConsolidedOrder;

	private CheckBox chkHeaderText;

	private TextBox textImkbOrderSymbol;

	private DataGridView gridImkbOrder;

	private DataGridViewTextBoxColumn Column11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

	private DataGridViewTextBoxColumn Column2;

	private DataGridViewTextBoxColumn Column3;

	private DataGridViewTextBoxColumn Column5;

	private DataGridViewTextBoxColumn Column4;

	private DataGridViewTextBoxColumn Column6;

	private DataGridViewTextBoxColumn Column7;

	private DataGridViewTextBoxColumn Column8;

	private DataGridViewTextBoxColumn Column13;

	private DataGridViewTextBoxColumn Column14;

	private CheckBox checkImkbOrderAllStocks;

	private CheckBox checkImkbOrderSell;

	private CheckBox checkImkbOrderBuy;

	private TabPage tabImkbPortfolio;

	private CheckBox checkConsolidedPortfoy;

	private DataGridView gridImkbPosition;

	private DataGridViewTextBoxColumn gridColNo;

	private DataGridViewTextBoxColumn gridColField;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;

	private DataGridViewTextBoxColumn gridCol1;

	private DataGridViewTextBoxColumn Column15;

	private DataGridViewTextBoxColumn Fark;

	private DataGridViewTextBoxColumn colTakas2Yuzde;

	private DataGridViewTextBoxColumn Column1;

	private TabControl tabMain;

	private Panel panelBorderLeft;

	private Panel panelBorderRight;

	private Panel panelBorderBottom;

	private Label labelPiyasaTipFon;

	private Label labelPiyasaTipViop;

	private Label labelPiyasaTipHisse;

	private ToolStripMenuItem menuGridSatirTip;

	private ToolStripMenuItem menuGridSatirTip0;

	private ToolStripMenuItem menuGridSatirTip1;

	private ToolStripMenuItem menuHeaderFont;

	private ToolStripMenuItem menuRowHeight;

	private MyButton myButtonAyarKaydet;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripMenuItem menuDefaultAyar;

	private TabPage tabImkbOverall;

	private DataGridView gridImkbSummary;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	private CheckBox checkBoxHisseIptal;

	private CheckBox checkBoxHisseGerceklesen;

	private CheckBox checkBoxHisseBekleyen;

	private MyButton myButtonImkbEmirSat;

	private MyButton myButtonImkbEmirAl;

	private MyButton myButtonImkbEmirMenu;

	private MyButton myButtonImkbEmirTumSil;

	private TabPage tabVipTeminat;

	private DataGridView gridVipSummary;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn111;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn112;

	private RadioButton radioVipOrder4;

	private MyButton myButtonImkbPortfolioTopluIslem;

	private MyButton myButtonImkbPortfolioFiyatPenceresi;

	private MyButton myButtonImkbPortfolioAl;

	private MyButton myButtonImkbPortfolioSat;

	private MyButton myButtonViopPortfolioKapat;

	private MyButton myButtonViopPortfolioSat;

	private MyButton myButtonViopPortfolioAl;

	private MyButton myButtonViopPortfolioFiyatPenceresi;

	public ComboBox comboVipSymbols;

	public ComboBox comboVipExpiry;

	private MyButton myButtonViopEmirMenu;

	private MyButton myButtonViopEmirTumSil;

	private MyButton myButtonViopEmirSat;

	private MyButton myButtonViopEmirAl;

	private MyButton myButtonHesapGrup;

	private Panel panelImkbProfitGrup;

	private CheckBox checkBoxImkbProfitGrup;

	private ComboBox comboBoxImkbProfitGrup;

	private MyButton myButtonImkbProfitDurdur;

	private MyButton myButtonImkbProfitGuncelle;

	private MyButton myButtonImkbSepetTumSec;

	private MyButton myButtonImkbSepetAlislar;

	private MyButton myButtonImkbSepetSecimleriKaldir;

	private MyButton myButtonImkbSepetSatislar;

	private MyButton myButtonImkbSepetHisse;

	private MyButton myButtonImkbSepetKriter;

	private MyButton myButtonImkbSepetSecilenleriSil;

	private MyButton myButtonImkbSepetEmirleriGonder;

	private MyButton myButtonVipIslemGuncelle;

	private Label labelVipIslem01;

	private Label labelVipIslem04;

	private Label labelVipIslem03;

	private Label labelVipIslem02;

	private Label labelVipIslemAlis;

	private Label labelVipIslemToplam;

	private Label labelVipIslemNet;

	private Label labelVipIslemSatis;

	private TabPage tabImkbTarihselIslem;

	private MyButton myButtonImkbIslemGuncelle;

	private TextBox txtImkbIslemMenkul;

	private Label labelImkbIslem05;

	private DateTimePicker dtpImkbIslemBaslangic;

	private DateTimePicker dtpImkbIslemBitis;

	private Label labelImkbIslemToplam;

	private Label labelImkbIslemNet;

	private Label labelImkbIslemSatis;

	private Label labelImkbIslemAlis;

	private Label labelImkbIslem04;

	private Label labelImkbIslem03;

	private Label labelImkbIslem02;

	private Label labelImkbIslem01;

	private DataGridView gridImkbIslem;

	private Label labelImkbPortfolioOverall;

	private Label labelImkbPortfolio01;

	private Label labelImkbPortfolioIslemLimit;

	private Label labelImkbPortfolio02;

	private Label labelImkbPortfolio03;

	private Label labelVipPortfolio03;

	private Label labelVipPortfolioTeminat2;

	private Label labelVipPortfolio02;

	private Label labelVipPortfolioTeminat1;

	private Label labelVipPortfolio01;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn122;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn123;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn124;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn125;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn126;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn127;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn128;

	private MyButton myButtonVipStatementBakiye;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn197;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn198;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn190;

	private Label labelVipKzNetKz;

	private Label labelVipKz01;

	private MyButton myButtonHesapRumuz;

	private MyButton myButtonFavoriSec;

	public ContextMenuStrip menuFavori;

	private ToolStripMenuItem menuFavori01;

	private ToolStripMenuItem menuFavori02;

	private ToolStripMenuItem menuFavori03;

	private ToolStripMenuItem menuFavori04;

	private ToolStripMenuItem menuFavori05;

	private ToolStripMenuItem menuFavori06;

	private ToolStripMenuItem menuFavori07;

	private ToolStripMenuItem menuFavori08;

	private ToolStripMenuItem menuFavori09;

	private ToolStripMenuItem menuFavori10;

	private ToolStripMenuItem menuFavori11;

	private ToolStripMenuItem menuFavori12;

	private ToolStripMenuItem menuFavori13;

	private ToolStripMenuItem menuFavori14;

	private ToolStripMenuItem menuFavori15;

	private ToolStripMenuItem menuFavori16;

	private ToolStripMenuItem menuFavori17;

	private ToolStripMenuItem menuFavori18;

	private ToolStripMenuItem menuFavori19;

	private ToolStripMenuItem menuFavori20;

	private ToolStripMenuItem menuFavori21;

	private ToolStripMenuItem menuFavori22;

	private ToolStripMenuItem menuFavori23;

	private ToolStripMenuItem menuFavori24;

	private ToolStripMenuItem menuFavori25;

	private ToolStripMenuItem menuFavori26;

	private ToolStripMenuItem menuFavori27;

	private ToolStripMenuItem menuFavori28;

	private ToolStripMenuItem menuFavori29;

	private ToolStripMenuItem menuFavori30;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripMenuItem menuFavoriEkle;

	private Label labelImkbProfitStatus;

	private Label labelImkbProfitKz;

	private Label labelImkbProfit02;

	private Label labelImkbProfitNet;

	private Label labelImkbProfit01;

	private Label labelImkbProfitToplam;

	private Label labelImkbProfit03;

	private ToolStripMenuItem menuCustomBar;

	private TabPage tabImkbGrupPortfoy;

	public ContextMenuStrip menuTab;

	private ToolStripMenuItem menuTabSil;

	private ToolStripMenuItem menuTabtabImkbPortfolio;

	private ToolStripMenuItem menuTabtabImkbGrupPortfoy;

	private ToolStripMenuItem menuTabtabImkbOverall;

	private ToolStripMenuItem menuTabtabImkbOrder;

	private ToolStripMenuItem menuTabtabImkbGunKz;

	private ToolStripMenuItem menuTabtabImkbStatement;

	private ToolStripMenuItem menuTabtabImkbReady;

	private ToolStripMenuItem menuTabtabImkbTarihselIslem;

	private ToolStripMenuItem menuTabtabVipPortfolio;

	private ToolStripMenuItem menuTabtabVipTeminat;

	private ToolStripMenuItem menuTabtabVipOrder;

	private ToolStripMenuItem menuTabtabVipMaliyet;

	private ToolStripMenuItem menuTabtabVipStatement;

	private ToolStripMenuItem menuTabtabVipProfit;

	private ToolStripSeparator toolStripSeparator4;

	private ToolStripMenuItem menuTabEmpty;

	private ToolStripMenuItem menuTabtabVipKZRapor;

	private ToolStripMenuItem menuTabtabVipTarihselIslem;

	private ToolStripMenuItem menuTabEkle;

	private ToolStripMenuItem menuHesapListe;

	private Label labelImkbGrupPortfoyStatus;

	private ComboBox comboBoxImkbGrupPortfoy;

	private MyButton myButtonImkbGrupPortfoyDurdur;

	private MyButton myButtonImkbGrupPortfoyGuncelle;

	private DataGridView gridImkbGrupPortfoy;

	private Label labelImkbGrupPortfoyKz2;

	private Label labelImkbGrupPortfoy04;

	private Label labelImkbGrupPortfoyKz1;

	private Label labelImkbGrupPortfoy03;

	private Label labelImkbGrupPortfoyGuncel;

	private Label labelImkbGrupPortfoy02;

	private Label labelImkbGrupPortfoyMaliyet;

	private Label labelImkbGrupPortfoy01;

	private DataGridView gridImkbGrupHesap;

	private Label labelImkbPortfolio06;

	private Label labelImkbPortfolioOnceki;

	private Label labelImkbPortfolio05;

	private Label labelImkbPortfolioSonBakiye;

	private Label labelImkbPortfolio04;

	private MyButton myButtonImkbPortfolioKz;

	private MyButton myButtonImkbPortfolioFark1;

	private MyButton myButtonImkbPortfolioFark2;

	private Label labelImkbPortfolio07;

	private ToolStripMenuItem menuFavoriListe;

	private DataGridView gridFavori;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;

	private Panel panelImkbGrupPortfoyTip;

	private RadioButton radioBoxImkbGrupPortfoyTip02;

	private RadioButton radioBoxImkbGrupPortfoyTip01;

	private RadioButton radioBoxImkbGrupPortfoyTip00;

	private DataGridView gridImkbGrupPortfoyHisse2;

	private DataGridView gridImkbGrupPortfoyHisse1;

	private ToolStripMenuItem menuTema;

	private ToolStripMenuItem menuTemaSiyah1;

	private ToolStripMenuItem menuTemaSiyah2;

	private ToolStripMenuItem menuTemaBeyaz1;

	private ToolStripMenuItem menuTemaBeyaz2;

	private TabPage tabFonPortfoy;

	private ToolStripMenuItem menuTabtabFonPortfoy;

	private DataGridView gridFonPortfoy;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;

	private MyButton myButtonFonPortfoySat;

	private MyButton myButtonFonPortfoyAl;

	private TabPage tabFonIslem;

	private MyButton myButtonFonIslemSat;

	private MyButton myButtonFonIslemAl;

	private DataGridView gridFonIslem;

	private ToolStripMenuItem menuTabtabFonIslem;

	private TabPage tabVarliklar;

	private ToolStripMenuItem menuTabtabVarliklar;

	private Label labelPiyasaTipVarliklar;

	private Panel panelVarlikTip;

	private RadioButton radioButtonVarlikTip04;

	private RadioButton radioButtonVarlikTip03;

	private RadioButton radioButtonVarlikTip02;

	private RadioButton radioButtonVarlikTip01;

	private RadioButton radioButtonVarlikTip00;

	private Label labelVarlikStatus;

	private CheckBox checkBoxVarlikGrup;

	private Panel panelVarlikGrup;

	private ComboBox comboBoxVarlikGrup;

	private MyButton myButtonVarlikDurdur;

	private MyButton myButtonVarlikGuncelle;

	private Chart chartVarlik;

	private DataGridView gridVarlik;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;

	private MyButton myButtonVarlikKz1;

	private Label labelVarlik01;

	private MyButton myButtonVarlikToplam;

	private Label labelVarlik02;

	private RadioButton radioButtonVarlikTip05;

	private ToolStripMenuItem menuPencereGorunum;

	private ToolStripMenuItem menuPencereGorunum0;

	private ToolStripMenuItem menuPencereGorunum1;

	private ToolStripMenuItem menuPencereGorunum2;

	private MyButton myButtonVipPortfolioKz;

	private RadioButton radioButtonVarlikTip06;

	private CheckBox checkBoxVarlikTarihsel;

	private Panel panelVarlikChart;

	private DataGridView gridVipPosition;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;

	private Panel panelVarlikHeader;

	private Panel panelVarlikChartOpt;

	private RadioButton radioButtonVarlikChart01;

	private RadioButton radioButtonVarlikChart00;

	private MyButton myButtonVarlikCari;

	private MyButton myButtonVarlikDoviz;

	private MyButton myButtonVarlikViop;

	private MyButton myButtonVarlikHisse;

	private MyButton myButtonVarlikSabitGetiri;

	private MyButton myButtonVarlikFon;

	private MyButton myButtonVarlikOverall;

	private CheckBox checkBoxTarihselOverall;

	private CheckBox checkBoxTarihselFon;

	private CheckBox checkBoxTarihselCari;

	private CheckBox checkBoxTarihselDoviz;

	private CheckBox checkBoxTarihselViop;

	private CheckBox checkBoxTarihselHisse;

	private CheckBox checkBoxTarihselSabitGetiri;

	private MyButton myButtonVarlikTarih;

	private Label labelVarlik03;

	private RadioButton radioButtonVarlikChart02;

	private Panel panelVarlikSkala;

	private RadioButton radioButtonVarlikSkala01;

	private RadioButton radioButtonVarlikSkala00;

	private Label labelGoruntu;

	private DataGridView gridImkbKrediDurum;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;

	private ToolStripMenuItem menuViopKapPoz;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formPortfoyum()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formPortfoyum_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formPortfoyum_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formPortfoyum_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formPortfoyum_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formPortfoyum_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formPortfoyum_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formPortfoyum_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formPortfoyum_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formPortfoyum_MouseLeave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonAccountLogin_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonChangePassword_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonPasswordWindow_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonSifreUnuttum_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonImkbReadySymbolAll_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonImkbReadySymbolBuy_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonImkbReadySymbolSell_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chartVarlik_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkConsolidedPortfoy_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkImkbOrderAllStocks_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkImkbOrderBuy_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkImkbOrderSell_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkConsolidedOrder_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chkHeaderText_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBoxHisseEmir_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBoxImkbProfitGrup_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBoxVarlikGrup_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBoxVarlikTarihsel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboActiveAccountName_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboActiveAccountNo_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboKriter_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboKriter_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboVipExpiry_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboVipSymbols_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBoxImkbProfitGrup_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBoxImkbGrupPortfoy_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBoxVarlikGrup_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeImkbStatement1_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeVipProfit1_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeVipStatement1_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeVipKZRapor2_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dtpImkbIslemBaslangic_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dtpVipIslemBaslangic_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void grid_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridFavori_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridFavori_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbOrder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbOrder_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbOrder_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbOrder_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbPosition_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbPosition_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbPosition_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbPosition_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbGrupPortfoy_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbGrupPortfoy_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbGrupPortfoy_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbGrupHesap_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbGrupHesap_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbGrupPortfoyHisse1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbGrupPortfoyHisse2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbProfit_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbProfit_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbProfit_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbProfit_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbReady_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbReady_CellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbReady_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbReady_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbSummary_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbSummary_CellClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbStatement_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbIslem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridVipIslem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridVipMaliyet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridVipMaliyet_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridVipMaliyet_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridVipMaliyet_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridVipOrder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridVipOrder_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridVipOrder_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridVipOrder_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridVipPosition_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridVipPosition_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridVipPosition_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridVipProfit_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridVipKZRapor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridVipSummary_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKZRaporSummary_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridVipStatement_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridFonPortfoy_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridFonPortfoy_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridFonIslem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridFonIslem_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridVarlik_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelCloseWindow_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelMinimizeWindow_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelGoruntu_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelPiyasaTip_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuCustomBar_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuFont_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuHeaderFont_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuHesapListe_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuFavoriListe_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRowHeight_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPortfoy_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGridSatirTip_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuDefaultAyar_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTemaSiyah1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTemaSiyah2_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTemaBeyaz1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTemaBeyaz2_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuFavori01_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuFavoriEkle_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRenk_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTab_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPencereGorunum_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonLogin__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonLogout__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonHesaplar__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonUyari__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonGuncelle__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonAyarlar__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonAyarKaydet__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonExcel__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonHesapGrup__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonHesapRumuz__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonImkbPortfolioTopluIslem__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonImkbPortfolioFiyatPenceresi__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonImkbPortfolioAl__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonImkbPortfolioSat__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonImkbEmirMenu__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonImkbEmirTumSil__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonImkbEmirAl__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonImkbEmirSat__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonImkbProfitGuncelle__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonImkbGrupPortfoyGuncelle__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonImkbProfitDurdur__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonImkbGrupPortfoyDurdur__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonImkbSepetTumSec__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonImkbSepetSecimleriKaldir__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonImkbSepetAlislar__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonImkbSepetSatislar__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonImkbSepetHisse__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonImkbSepetKriter__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonImkbSepetEmirleriGonder__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonImkbSepetSecilenleriSil__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonImkbIslemGuncelle__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonViopPortfolioFiyatPenceresi__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonViopPortfolioAl__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonViopPortfolioSat__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonViopPortfolioKapat__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonViopEmirAl__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonViopEmirSat__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonViopEmirTumSil__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonViopEmirMenu__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonVipIslemGuncelle__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonVipStatementBakiye__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonFavoriSec__OnMouseDown(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonFonPortfoyAl__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonFonPortfoySat__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonFonIslemAl__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonFonIslemSat__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonVarlikGuncelle__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonVarlikDurdur__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelHeader_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelHeader_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelLogin_Leave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelMain_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelTab_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelTab_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelTab_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelVarlikChart_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelVarlikChart_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioImkbOrder_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioImkbWaitingDisplay_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioImkbWaitingFilter_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioBoxImkbGrupPortfoyTip_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioVipOrder_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioButtonVarlikTip_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioButtonVarlikChart_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioButtonVarlikSkala_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tabMain_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textImkbOrderSymbol_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textImkbOrderSymbol_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textImkbOrderSymbol_Leave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textImkbOrderSymbol_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textLoginParola_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textLoginPassword_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerFilled_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerSave_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timer500_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PortfolioReceived(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BasicDataReceived(string symbolX, string updatetypeX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CopyToExcel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayGrupPortfoy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayFavoriList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FilterImkbOrder()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FilterImkbPosition()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FilterImkbProfit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FilterImkbGrupProfit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FilterVipOrder()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FilterVipMaliyet()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FonAlSat(string yonX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FonIptal(string islemnoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetColumns()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InsertTabs()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Login()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<cxPortfolio.ImkbPositionRecord> ReadPortfoyDosya(string filename)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReadTarihselVarlik()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RequestData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResizeWindow()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetGrid(DataGridView grid, List<FieldRec> fields)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetColors()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetKriterList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPiyasaTip()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowLoginPanel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowMenuImkbOrderSub(Control senderX, Point positionX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowMenuVipOrderSub(Control senderX, Point positionX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddAccount()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BuyImkbLimit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BuyImkbMoney()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BuyImkbMyPosition()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<cxPortfolio.VarlikRecord> ConvertPositionToVarlik(cxPortfolio.Portfoy portfoy, string backofficeX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeColors(cxColorEditor coloritemX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CloseImkbPositionsAll()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CloseImkbPositionsPercent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessMenuMessage(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowAgirlikliList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<object> FonEmriIletemeyenKurumlar(string BackOfficeX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbKrediDurum_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuViopKapPoz_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbPosition_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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
	static formPortfoyum()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		fonEmirIzinBackOffice = new List<string> { "IDB" };
		Reference = null;
		EmirlerSilinmesinBool = false;
	}
}
