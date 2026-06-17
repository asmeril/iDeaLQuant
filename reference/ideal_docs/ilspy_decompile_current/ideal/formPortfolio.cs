using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formPortfolio : Form
{
	public static formPortfolio Reference;

	private string DisplayedAccountName;

	private DataGridView ActiveGrid;

	private Point PointGridMouseDown;

	private string ActiveSymbolImkb;

	private string ActiveSymbolVip;

	private string ImkbOrderSortKey;

	private bool ImkbOrderSortAscending;

	private string ImkbWaitingSortKey;

	private bool ImkbWaitingSortAscending;

	private string ImkbPositionSortKey;

	private bool ImkbPositionSortAscending;

	private string ImkbProfitSortKey;

	private bool ImkbProfitSortAscending;

	private string VipOrderSortKey;

	private bool VipOrderSortAscending;

	private string flagMagnus;

	private List<cxPortfolio.ImkbPositionRecord> ImkbPositionList;

	private List<cxPortfolio.CriptoPositionRecord> CriptoPositionList;

	private List<cxPortfolio.BinanceFuture.ResponseClasses.Position> CriptoFuturePositionList;

	private List<cxPortfolio.BinanceFuture.ResponseClasses.OpenOrder> CriptoFutureOrderList;

	private List<cxPortfolio.BinanceFuture.ResponseClasses.OrderHistory> CriptoFutureOrderHistoryList;

	private List<cxPortfolio.BinanceFuture.ResponseClasses.TradeHistory> CriptoFutureTradeHistoryList;

	private List<cxPortfolio.BinanceFuture.ResponseClasses.TransactionHistory> CriptoFutureTransactionHistoryList;

	private List<cxPortfolio.BinanceFuture.ResponseClasses.Asset> CriptoFutureAssetList;

	private List<cxPortfolio.IcrypexFuture.ResponseClasses.Position> CrypexCriptoFuturePositionList;

	private List<cxPortfolio.IcrypexFuture.ResponseClasses.OpenOrder> CrypexCriptoFutureOrderList;

	private List<cxPortfolio.IcrypexFuture.ResponseClasses.OrderHistory> CrypexCriptoFutureOrderHistoryList;

	private List<cxPortfolio.IcrypexFuture.ResponseClasses.TradeHistory> CrypexCriptoFutureTradeHistoryList;

	private List<cxPortfolio.IcrypexFuture.ResponseClasses.TransactionHistory> CrypexCriptoFutureTransactionHistoryList;

	private List<cxPortfolio.IcrypexFuture.ResponseClasses.Asset> CrypexCriptoFutureAssetList;

	private List<cxPortfolio.ImkbOrderRecord> ImkbOrderList;

	private List<cxPortfolio.PositionInfo> ImkbProfitKonsolide;

	private List<cxPortfolio.CriptoOrderRecord> CriptoOrderList;

	private List<cxPortfolio.CriptoTradeRecord> CriptoTradeList;

	private List<cxPortfolio.CriptoBinanceAcoountSnapShotRrebord> CriptoSnapShotList;

	private List<cxPortfolio.BalanceHistoryRecord> BalanceHistoryList;

	private List<cxPortfolio.ImkbWaitingRecord> ImkbWaitingList;

	private List<cxPortfolio.ProfitRecord> ImkbProfitList;

	private List<cxPortfolio.BuySellRecord> ImkbBuySellList;

	private List<cxPortfolio.BuySellRecord> MagnusBuySellList;

	private Dictionary<string, List<int>> ImkbPortfolioSymbolPositionDictionary;

	private Dictionary<string, List<int>> CriptoPortfolioSymbolPositionDictionary;

	private Dictionary<string, List<int>> CriptoFutureSymbolPositionDictionary;

	private Dictionary<string, bool> ImkbOrderSelectionDictionary;

	private Dictionary<string, bool> CriptoOrderSelectionDictionary;

	private Dictionary<string, bool> CriptoFutureOrderSelectionDictionary;

	private Dictionary<string, List<int>> ImkbOrderSymbolPositionDictionary;

	private Dictionary<string, List<int>> CriptoOrderSymbolPositionDictionary;

	private List<cxPortfolio.VipPositionRecord> VipPositionList;

	private List<cxPortfolio.VipOrderRecord> VipOrderList;

	private Dictionary<string, List<int>> VipPortfolioSymbolPositionDictionary;

	private Dictionary<string, bool> VipOrderSelectionDictionary;

	private Dictionary<string, List<int>> VipOrderSymbolPositionDictionary;

	private List<cxPortfolio.ProfitRecord> VipMaliyetList;

	private cxButton HeaderButtons;

	public cxButton ToolbarButtons;

	public cxButton ImkbReadyButtons;

	public cxButton ImkbPortfolioButtons;

	public cxButton ImkbOrderButtons;

	public cxButton ImkbWaitingButtons;

	public cxButton VipPortfolioButtons;

	public cxButton VipOrderButtons;

	public cxButton TabButtons;

	public cxButton MagnusButtons;

	private string Str1;

	private bool BinlikAyrac;

	public static bool EmirlerSilinmesinBool;

	private List<cxPortfolio.PositionInfo> postlist;

	private IContainer components;

	private Panel panelToolbar;

	private ComboBox comboActiveAccountNo;

	private ComboBox comboActiveAccountName;

	private Panel panelLogin;

	private Button buttonAccountLogin;

	private TextBox textLoginPassword;

	private Label labelLoginPassword;

	private Timer timerRefresh;

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

	private TabControl tabMain;

	private TabPage tabImkbPortfolio;

	private TabPage tabImkbWaiting;

	private DataGridView gridImkbSummary;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

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

	private Panel panelImkbPortfolio;

	private Panel panelImkbWaiting;

	private Panel panel2;

	private RadioButton radioImkbWaitingFilter2;

	private RadioButton radioImkbWaitingFilter1;

	private RadioButton radioImkbWaitingFilter0;

	private TextBox textImkbWaitingSymbol;

	private CheckBox checkImkbWaitingAllStocks;

	private Panel panel4;

	private RadioButton radioImkbWaitingDisplay2;

	private RadioButton radioImkbWaitingDisplay1;

	private RadioButton radioImkbWaitingDisplay0;

	private DataGridView gridImkbWaiting;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn66;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn67;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn68;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn69;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn70;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn71;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn72;

	private TabPage tabImkbOrder;

	private Panel panelImkbOrder;

	private TextBox textImkbOrderLot;

	private TextBox textImkbOrderSymbol;

	private CheckBox checkImkbOrderAllStocks;

	private TextBox textImkbOrderPrice;

	private CheckBox checkImkbOrderSell;

	private CheckBox checkImkbOrderBuy;

	private Panel panel1;

	private RadioButton radioImkbOrder3;

	private RadioButton radioImkbOrder2;

	private RadioButton radioImkbOrder1;

	private RadioButton radioImkbOrder0;

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

	private TabPage tabImkbProfit;

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

	private TabPage tabImkbStatement;

	private DateTimePicker datetimeImkbStatement2;

	private DateTimePicker datetimeImkbStatement1;

	private DataGridView gridImkbStatement;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;

	private TabPage tabImkbReady;

	private Panel panelImkbReady;

	private ComboBox comboKriter;

	private Panel panelImkbReadySymbol;

	private Button buttonImkbReadySymbolSell;

	private Button buttonImkbReadySymbolBuy;

	private Button buttonImkbReadySymbolAll;

	private TextBox textImkbReadySymbol;

	private DataGridView gridImkbReady;

	private DataGridViewTextBoxColumn Column10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;

	private DataGridViewTextBoxColumn Column9;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;

	private DataGridViewTextBoxColumn Column12;

	private TabPage tabAlgo;

	private DataGridView gridAlgo;

	private Panel panelAlgoAction;

	private RadioButton radioAlgoAction2;

	private RadioButton radioAlgoAction1;

	private RadioButton radioAlgoAction0;

	private Label label1;

	private Button buttonAlgoStart;

	private Timer timerAlgo;

	private Button buttonAlgoOrder;

	private Button buttonHelp;

	private TabPage tabVipOrder;

	private Panel panelVipOrder;

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

	private Panel panelVipPortfolio;

	private DataGridView gridVipSummary;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn111;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn112;

	private DataGridView gridVipPosition;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn113;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn114;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn115;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn116;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn117;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn118;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn119;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn120;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn121;

	private TabPage tabVipStatement;

	private DateTimePicker datetimeVipStatement2;

	private DateTimePicker datetimeVipStatement1;

	private DataGridView gridVipStatement;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn122;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn123;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn124;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn125;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn126;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn127;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn128;

	private Panel panelTab;

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

	private DataGridViewTextBoxColumn Column16;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn91;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn92;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn94;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn95;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn89;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn90;

	private DataGridViewTextBoxColumn Column17;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn96;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn98;

	private TabPage tabRobot;

	private Panel panelRobotSelect;

	private Button buttonRobotSelectOK;

	private CheckedListBox listRobotSelect;

	private Button buttonRobotSelectCancel;

	private ListBox listRobotSistem;

	private Button buttonRobotSistemDef;

	private Panel panelRobotAction;

	private RadioButton radioRobotAction2;

	private RadioButton radioRobotAction1;

	private RadioButton radioRobotAction0;

	private Label label2;

	private DataGridView gridRobotOrder;

	private Timer timerRobot;

	private DataGridView gridRobotPosition;

	private Panel panelRobotPositionEdit;

	private Label label4;

	private Label label3;

	private TextBox textRobotPosition;

	private Button buttonHelpRobot;

	private Label labelRunningRobot;

	private TabPage tabVipTeyid;

	private DataGridView gridVipTeyid;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;

	private DateTimePicker datetimeVipTeyid1;

	private TabPage tabVipAcik;

	private DateTimePicker datetimeVipAcik1;

	private DataGridView gridVipAcik;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;

	private TabPage tabVipGayri;

	private DateTimePicker datetimeVipGayri1;

	private DataGridView gridVipGayri;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;

	private DateTimePicker datetimeVipGayri2;

	public ComboBox comboVipExpiry;

	public ComboBox comboVipSymbols;

	private CheckBox checkRobotBeep;

	private TrackBar trackOpacity;

	private Button buttonRobotSelect;

	private DataGridViewTextBoxColumn Column18;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;

	private TabPage tabVipMaliyet;

	private DataGridView gridVipMaliyet;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn136;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn137;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn138;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn139;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn140;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn141;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn142;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn143;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn144;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn145;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn146;

	private Label label5;

	private TextBox textRobotAnahtar;

	private Button buttonDeleteAnahtar;

	private Button buttonAddAnahtar;

	private Timer timerRobotStat;

	private Label labelRobotStatCount;

	private Label labelRobotStatSure;

	private Label labelRobotMili;

	private Label labelRobotStatOrtalama;

	private CheckBox checkRobotWeekend;

	private Label label6;

	private Label labelRobotTime2;

	private Label labelRobotTime1;

	private CheckBox checkConsolidedPortfoy;

	private Timer timerSave;

	private TabControl tabRobotAyar;

	private TabPage tabPage1;

	private TabPage tabPage2;

	private TabPage tabPage3;

	private TextBox textRobotAra2;

	private Label label11;

	private TextBox textRobotAra1;

	private Label label7;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;

	private DataGridViewTextBoxColumn Column19;

	private DataGridViewTextBoxColumn Column20;

	private DataGridViewTextBoxColumn Column21;

	private Button buttonRobotAraUygula;

	private Button buttonDeleteAnahtarAll;

	private CheckBox checkRobotEmirKoruma;

	private CheckBox checkBoxEmirListesiSilinmesin;

	private CheckBox chkHeaderText;

	private TabPage tabCriptoPortfoy;

	private DataGridView gridCriptoPosition;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn147;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn148;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn149;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn150;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn151;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn152;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn153;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn154;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn155;

	private TabPage tabCriptoOrders;

	private DataGridView gridCriptoOrder;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn156;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn157;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn158;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn159;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn160;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn161;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn162;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn163;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn164;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn165;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn166;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn167;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn168;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn169;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn170;

	private CheckBox chkRemember;

	private TabPage tabCriptoTrades;

	private DataGridView gridCriptoTrade;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn171;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn172;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn173;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn174;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn175;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn176;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn177;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn178;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn179;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn180;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn181;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn182;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn183;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn184;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn185;

	private TextBox textCriptoTradeSymbol;

	private Button buttonCriptoGetTrades;

	private MyButton mybtnCriptoOverallUSDT;

	private Timer timerCripto;

	private GroupBox groupBoxOverall;

	private MyButton mybtnCriptoOverallBTC;

	private MyButton mybtnCriptoOverallTRY;

	private TabPage tabCriptoAccountHistory;

	private DataGridView gridCriptoAccountHistory;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn186;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn187;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn188;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn189;

	private Button buttonViopBakiyeiGrafik;

	private TabPage tabViopKZRapor;

	private DateTimePicker datetimeVipKZRapor2;

	private DateTimePicker datetimeVipKZRapor1;

	private DataGridView gridVipKZRapor;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn190;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn191;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn192;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn193;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn194;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn195;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn196;

	private DataGridView gridKZRaporSummary;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn197;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn198;

	private Button buttonSifreUnuttum;

	private CheckBox checkBoxRiskBildirim;

	private TabPage tabGerceklesenIslemRapor;

	private DataGridView gridTransactionReport;

	private Button btnMenkulGoster;

	private TextBox txtMenkul;

	private Label label13;

	private DateTimePicker dtpBaslangic;

	private DateTimePicker dtpBitis;

	private RadioButton radioBist;

	private RadioButton radioViop;

	private DataGridView gridTransactionSummary;

	private TabPage tabCriptoFuturePositions;

	private GroupBox groupBoxFutureOverall;

	private MyButton mybtnCriptoFutureOverallUSDT;

	private MyButton mybtnCriptoFutureOverallBTC;

	private MyButton mybtnCriptoFutureOverallETH;

	private DataGridView gridCriptoFuturePosition;

	private DataGridViewTextBoxColumn Symbol;

	private DataGridViewTextBoxColumn Size;

	private DataGridViewTextBoxColumn Entryprice;

	private DataGridViewTextBoxColumn MarkPrice;

	private DataGridViewTextBoxColumn LiqPrice;

	private DataGridViewTextBoxColumn PNL;

	private DataGridViewTextBoxColumn Buy;

	private DataGridViewTextBoxColumn Sell;

	private DataGridViewTextBoxColumn Close;

	private TabPage tabCriptoFutureOrders;

	private DataGridView gridCriptoFutureOrder;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn199;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn200;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn201;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn202;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn203;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn204;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn205;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn206;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn207;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn208;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn209;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn210;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn211;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn212;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn213;

	private TabPage tabCriptoFutureOrderHistory;

	private DataGridView gridCriptoFutureOrderHistory;

	private TabPage tabCriptoFutureTradeHistory;

	private TabPage tabCriptoFutureTransactionHistory;

	private TabPage tabCriptoFutureAssets;

	private DataGridViewTextBoxColumn Tarih;

	private DataGridViewTextBoxColumn Semol;

	private DataGridViewTextBoxColumn EmirTipi;

	private DataGridViewTextBoxColumn Yon;

	private DataGridViewTextBoxColumn OrtalamaFiyat;

	private DataGridViewTextBoxColumn EmirFiyati;

	private DataGridViewTextBoxColumn GerceklesenMiktar;

	private DataGridViewTextBoxColumn Miktar;

	private DataGridViewTextBoxColumn Status;

	private DataGridView gridCriptoFutureTradeHistory;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn216;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn217;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn219;

	private DataGridViewTextBoxColumn Fiyat;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn223;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn222;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn224;

	private DataGridViewTextBoxColumn Column22;

	private DataGridView gridCriptoFutureTransactionHistory;

	private DataGridView gridCriptoFutureAssets;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn214;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn225;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn215;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn218;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn220;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn228;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn229;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn230;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn231;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn232;

	private TabPage tabMagnus;

	private Panel panelMagnus;

	private DataGridView gridMagnus;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn221;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn226;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn227;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn233;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn234;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn235;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn236;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn237;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn238;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn239;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn240;

	private Timer timerMagnus;

	private CheckBox checkConsolidedOrder;

	private DataGridView gridBistKZKonsolide;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn241;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn242;

	private CheckBox checkConsolideBistKZ;

	private CheckBox checkViopKZTum;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formPortfolio()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formPortfolio_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formPortfolio_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formPortfolio_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formPortfolio_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonAccountLogin_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonAddAnahtar_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonDeleteAnahtarAll_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonAlgoOrder_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonAlgoStart_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonChangePassword_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonCriptoGetTrades_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonDeleteAnahtar_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonHelp_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonHelpRobot_Click(object sender, EventArgs e)
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
	private void buttonPasswordWindow_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonRobotAraUygula_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonRobotSelect_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonRobotSelectCancel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonRobotSelectOK_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonRobotSistemDef_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonSifreUnuttum_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonViopBakiyeiGrafik_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnMenkulGoster_Click(object sender, EventArgs e)
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
	private void checkImkbWaitingAllStocks_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkRobotBeep_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkRobotEmirKoruma_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkRobotWeekend_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBoxRiskBildirim_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBoxEmirListesiSilinmesin_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chkHeaderText_CheckedChanged(object sender, EventArgs e)
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
	private void datetimeImkbStatement1_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeVipAcik1_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeVipGayri1_CloseUp(object sender, EventArgs e)
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
	private void datetimeVipTeyid1_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeVipKZRapor2_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dtpBaslangic_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dtpBitis_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void grid_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridAlgo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridAlgo_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
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
	private void gridCriptoOrder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridCriptoTrade_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridCriptoOrder_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridCriptoPosition_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridCriptoPosition_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
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
	private void gridImkbProfit_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbProfit_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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
	private void gridImkbStatement_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbWaiting_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbWaiting_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbWaiting_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobotPosition_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobotPosition_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobotOrder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobotOrder_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridVipAcik_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridVipMaliyet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
	private void gridVipPosition_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridVipPosition_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
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
	private void gridVipTeyid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelRobotSure_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelRobotTime1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelRobotTime2_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void listRobotSistem_MouseDoubleClick(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelImkbOrder_MouseLeave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelImkbOrder_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelImkbOrder_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelImkbOrder_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelImkbPortfolio_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelImkbPortfolio_MouseLeave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelImkbPortfolio_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelImkbPortfolio_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelImkbReady_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelImkbReady_MouseLeave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelImkbReady_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelImkbReady_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelImkbWaiting_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelImkbWaiting_MouseLeave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelImkbWaiting_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelImkbWaiting_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelLogin_Leave(object sender, EventArgs e)
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
	private void panelToolbar_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelToolbar_MouseLeave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelToolbar_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelToolbar_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelVipOrder_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelVipOrder_MouseLeave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelVipOrder_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelVipOrder_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelVipPortfolio_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelVipPortfolio_MouseLeave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelVipPortfolio_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelVipPortfolio_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioAlgoAction_Click(object sender, EventArgs e)
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
	private void radioRobotAction_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioVipOrder_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioBist_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioViop_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tabMain_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tabRobotAyar_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textCriptoTradeSymbol_Enter(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textCriptoTradeSymbol_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textCriptoTradeSymbol_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textImkbOrderLot_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textImkbOrderLot_Leave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textImkbOrderLot_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textImkbOrderPrice_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textImkbOrderPrice_Leave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textImkbOrderPrice_MouseDown(object sender, MouseEventArgs e)
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
	private void textImkbWaitingSymbol_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textImkbWaitingSymbol_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textImkbWaitingSymbol_MouseDown(object sender, MouseEventArgs e)
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
	private void textRobotAra1_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textRobotPosition_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void trackOpacity_ValueChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerAlgo_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerCripto_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerFilled_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerRefresh_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerRobot_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerRobotStat_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerSave_Tick(object sender, EventArgs e)
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
	private void ChangePriceImkbWaiting(string newpricestrX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CopyToExcel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CriptoOverallHesapla()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CriptoFutureOverallHesapla()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayBinanceUserdata(string apiKeyX, string secretKeyX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FilterImkbPosition()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FilterImkbOrder()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FilterImkbWaiting()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FilterImkbProfit()
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
	private void InsertTabs()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Login()
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
	private void SetActiveGrid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetKriterList()
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
	private void ShowMenuCriptoOrderSub(Control senderX, Point positionX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowMenuImkbWaitingSub()
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
	public void StartRobot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopRobot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridCriptoFuturePosition_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridCriptoFuturePosition_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridCriptoFutureOrder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridCriptoFutureOrder_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void trackOpacity_Scroll(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbSummary_CellClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridMagnus_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridMagnus_CellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridMagnus_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridMagnus_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelMagnus_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelMagnus_MouseLeave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelMagnus_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelMagnus_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerMagnus_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkConsolidedOrder_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkConsolideBistKZ_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridBistKZKonsolide_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridBistKZKonsolide_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridBistKZKonsolide_CellClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridImkbPosition_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkViopKZTum_Click(object sender, EventArgs e)
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
	static formPortfolio()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
