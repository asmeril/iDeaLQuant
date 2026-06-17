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

public class formSablonRobot : Form
{
	private class TradeClass
	{
		public string Direction;

		public decimal Lot;

		public DateTime BuyDate;

		public decimal BuyPrice;

		public DateTime SellDate;

		public decimal SellPrice;

		public decimal ProfitPuan;

		public decimal ProfitYuzde;

		public decimal Cash;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TradeClass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TradeClass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private class SembolTaraClass
	{
		public string SistemName;

		public string Periyot;

		public string Sembol;

		public string SonYon;

		public string SonYonTarih;

		public int SinyalBarNo;

		public decimal Getiri;

		public decimal GetiriYuzde;

		public int ToplamIslemSayisi;

		public int KarliIslemSayisi;

		public int ZararliIslemSayisi;

		public decimal ProfitFactor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SembolTaraClass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SembolTaraClass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private enum ButtonTypes
	{
		None,
		CloseLeft,
		AlignMove,
		CloseRight,
		Minimize,
		Maximize,
		Header,
		Resize
	}

	public enum idealgoTab
	{
		Sistem,
		Performans,
		Optimizasyon,
		SembolTara,
		SistemTara,
		Robotlar,
		OtoTrade,
		RobotTrade,
		Arbitraj,
		İslemler,
		Ayarlar
	}

	public static formSablonRobot Referans;

	public string SistemSembol;

	public string SistemPeriyot;

	public string SistemName;

	private string SenderID;

	private bool OptRunningBool;

	private int OptCount;

	private bool OptLastDisplay;

	private Thread ThreadOpt;

	private cxSistem SistemOpt;

	private cxSistem SistemSembolTara;

	private bool SembolTaraRunningBool;

	private bool SembolTaraLastDisplay;

	private Thread ThreadSembolTara;

	public static string SembolTaraSembolFilter;

	private string SembolTaraTarananSembol;

	private decimal SembolTaraTarananKZ;

	private List<SembolTaraClass> SembolTaraList;

	private int SembolTaraCount;

	private cxSistem SistemSistemTara;

	private bool SistemTaraRunningBool;

	private bool SistemTaraLastDisplay;

	private Thread ThreadSistemTara;

	private string SistemTaraTarananSistem;

	private decimal SistemTaraTarananKZ;

	private List<SembolTaraClass> SistemTaraList;

	private int SistemTaraCount;

	private Rectangle DragDropRect;

	private string DragDropString;

	private DataGridView ActiveGrid;

	private Color FormBaslikZeminRenk1;

	private Color FormBaslikZeminRenk2;

	private Color FormBorderRenk;

	private Color FormHeaderButtonPasifRenk;

	private Color FormHeaderButtonAktifRenk;

	private int HeaderHeight;

	private int RightCloseButtonX1;

	private int ButtonWidth;

	private int MinimizeButtonX1;

	private ButtonTypes MouseMoveButton;

	private cxButton HeaderButtons;

	private bool OptSortAscendingBool;

	private string OptSortColName;

	private int TimerSayac5000;

	private List<TradeClass> TradeList;

	private IContainer components;

	private TabControl tabControl1;

	private TabPage tabPageRobot;

	private TabPage tabPageSistemler;

	private MyButton myButtonSil;

	private MyButton myButtonFarkliKaydet;

	private MyButton myButtonKaydet;

	private Panel panel1;

	private Label label15;

	private CheckBox checkBoxKarZarar;

	private TextBox textBoxKarZarar;

	private Panel panelKarAl;

	private CheckBox checkBoxKarAl;

	private TextBox textBoxKarAl;

	private Panel panelStop;

	private Label label17;

	private Label label14;

	private Label label13;

	private TextBox textBoxStopHL;

	private TextBox textBoxStopSabit;

	private TextBox textBoxStopIzleyen;

	private ListBox listBoxSistemler;

	private Panel panelParametreTum;

	private Panel panelParametre;

	private Label labelHeader1;

	private TextBox textBox10D;

	private TextBox textBox10C;

	private TextBox textBox10B;

	private TextBox textBox10A;

	private Label label10;

	private TextBox textBox09D;

	private TextBox textBox09C;

	private TextBox textBox09B;

	private TextBox textBox09A;

	private Label label09;

	private TextBox textBox08D;

	private TextBox textBox08C;

	private TextBox textBox08B;

	private TextBox textBox08A;

	private Label label08;

	private TextBox textBox07D;

	private TextBox textBox07C;

	private TextBox textBox07B;

	private TextBox textBox07A;

	private Label label07;

	private TextBox textBox06D;

	private TextBox textBox06C;

	private TextBox textBox06B;

	private TextBox textBox06A;

	private Label label06;

	private TextBox textBox05D;

	private TextBox textBox05C;

	private TextBox textBox05B;

	private TextBox textBox05A;

	private Label label05;

	private TextBox textBox04D;

	private TextBox textBox04C;

	private TextBox textBox04B;

	private TextBox textBox04A;

	private Label label04;

	private TextBox textBox03D;

	private TextBox textBox03C;

	private TextBox textBox03B;

	private TextBox textBox03A;

	private Label label03;

	private TextBox textBox02D;

	private TextBox textBox02C;

	private TextBox textBox02B;

	private TextBox textBox02A;

	private Label label02;

	private Label labelHeader4;

	private Label labelHeader3;

	private TextBox textBox01D;

	private TextBox textBox01C;

	private TextBox textBox01B;

	private Label labelHeader2;

	private TextBox textBox01A;

	private Label label01;

	private ComboBox comboBoxMA;

	private Label labelMA;

	private Panel panelStrateji;

	private Panel panelCiftYon;

	private RadioButton radioButtonCiftYon00;

	private RadioButton radioButtonCiftYon01;

	private Label label8;

	private ComboBox comboBoxStrateji;

	private TabPage tabPageAyarlar;

	private CheckBox checkBoxVadeGecis;

	private CheckBox checkBoxMail;

	private MyButton myButtonKaydetAyarlar;

	private Panel panelStopYontem;

	private Label label3;

	private RadioButton radioBoxStopYontem01;

	private RadioButton radioBoxStopYontem00;

	private MyButton myButtonPeriyot;

	private MyButton myButtonSembol;

	private TabPage tabPagePerformans;

	private TabPage tabPageOpt;

	private Panel panel2;

	private Label label1;

	public TextBox textBoxPerformansSymbol;

	private Label label2;

	private ComboBox comboBoxPerformansSistemler;

	private Label label4;

	private ComboBox comboBoxPerformansPeriod;

	private Panel panel3;

	public TextBox textBoxPerformansCash;

	private Label label5;

	public TextBox textBoxPerformansLot;

	private Label label6;

	private TextBox textBoxPerformansBaslangic;

	private Label label7;

	private TextBox textBoxPerformansBitis;

	private Label label9;

	private MyButton myButtonPerformansYenile;

	private Panel panelOptHeader;

	private MyButton myButtonOptYenile;

	private TextBox textBoxOptBitis;

	private Label label19;

	private TextBox textBoxOptBaslangic;

	private Label label20;

	private Label label21;

	private ComboBox comboBoxOptPeriod;

	private Label label22;

	private ComboBox comboBoxOptSistemler;

	private Label label23;

	public TextBox textBoxOptSymbol;

	private Panel panelOptSummary;

	private DataGridView gridOptSummary;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

	private Panel panelRobotListe;

	private Panel panelRobotInfo;

	private MyButton myButtonRobotEkle;

	private MyButton myButtonRobotBaslat;

	private DataGridView gridRobot;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

	private ContextMenuStrip menuRobot;

	private ToolStripMenuItem menuRobotOzellikler;

	private ToolStripSeparator toolStripSeparator2;

	private ToolStripMenuItem menuRobotTumAktif;

	private ToolStripMenuItem menuRobotTumPasif;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripMenuItem menuRobotTumSil;

	private ToolStripMenuItem menuRobotPasifSil;

	private ToolStripMenuItem menuRobotSanalSil;

	private ToolStripMenuItem menuRobotSatirSil;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripMenuItem menuRobotKapat;

	private ToolStripMenuItem menuRobotTumGercek;

	private ToolStripMenuItem menuRobotTumSanal;

	private ToolStripMenuItem menuRobotTumPozisyonSifir;

	private Panel panelSistemParametre;

	private TextBox textBoxOptParametreSayisi;

	private Label label27;

	private Label label26;

	private ComboBox comboBoxInputSistem;

	private TabPage tabPageIslemler;

	private Panel panelIslemlerTur;

	private RadioButton radioButtonIslemlerTur02;

	private RadioButton radioButtonIslemlerTur00;

	private RadioButton radioButtonIslemlerTur01;

	private Panel panelIslemlerListe;

	private DataGridView gridIslemler;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;

	private Label label28;

	private CheckBox checkBoxRobotWeekend;

	private TextBox textBoxRobotTime1;

	private TextBox textBoxRobotTime2;

	private TabPage tabPageSembolTara;

	private Panel panelSembolTaraTablo;

	private DataGridView gridSembolTara;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;

	private Panel panel8;

	private MyButton myButtonSembolTaraYenile;

	private Label label33;

	private ComboBox comboBoxSembolTaraPeriod;

	private Label label34;

	private ComboBox comboBoxSembolTaraSistemler;

	private MyButton myButtonSembolTaraSemboller;

	private Label label31;

	private Label label35;

	private Label label32;

	private CheckBox checkBoxSembolTaraSinyal;

	private TextBox textBoxSembolTaraBar;

	private Panel panelSembolTaraInfo;

	private MyButton myButtonSembolTaraKarZarar;

	private MyButton myButtonSembolTaraSembol;

	private MyButton myButtonSembolTaraSistemName;

	private Label label30;

	private TabPage tabPageSistemTara;

	private Panel panelSistemTaraTablo;

	private DataGridView gridSistemTara;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;

	private Panel panel7;

	private Panel panelSistemTaraInfo;

	private MyButton myButtonSistemTaraKarZarar;

	private MyButton myButtonSistemTaraSembol;

	private MyButton myButtonSistemTaraSistemName;

	private Label label29;

	private Label label38;

	public TextBox textBoxSistemTaraSymbol;

	private Label label36;

	private Label label37;

	private CheckBox checkBoxSistemTaraSinyal;

	private TextBox textBoxSistemTaraBar;

	private MyButton myButtonSistemTaraYenile;

	private Label label39;

	private ComboBox comboBoxSistemTaraPeriod;

	private MyButton myButtonSembolTaraSembolleriKaydet;

	private Timer timer1000;

	private Timer timer200;

	private MyButton myButtonIslemlerListeyiTemizle;

	private Label labelAyarGetiriRenk;

	private Label label46;

	private CheckBox checkBoxAyarGetiriAciklamaBool;

	private TabPage tabPageTablom;

	private Panel panelTablomListe;

	private DataGridView gridTablom;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;

	private Panel panelTablomInfo;

	private Label labelTablomRowNo;

	private MyButton myButtonTablomEkle;

	private MyButton myButtonTablomBaslat;

	private CheckBox checkBoxTablomDetayGoster;

	private ContextMenuStrip menuTablom;

	private ToolStripMenuItem menuTablomOzellikler;

	private ToolStripSeparator toolStripSeparator5;

	private ToolStripMenuItem menuTablomTumSil;

	private ToolStripMenuItem menuTablomGerceklesenleriSil;

	private ToolStripMenuItem menuTablomSatirSil;

	private RadioButton radioBoxKarAl01;

	private RadioButton radioBoxKarAl00;

	private TextBox textBoxKarAlPuan;

	private Label label50;

	private TextBox textBoxStopSabitPuan;

	private Label label49;

	private TextBox textBoxStopIzleyenPuan;

	private TabPage tabPageArbitraj;

	private Panel panelArbitrajListe;

	private DataGridView gridArbitraj;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;

	private Panel panelArbitrajInfo;

	private Label labelArbitrajRowNo;

	private MyButton myButtonArbitrajEkle;

	private MyButton myButtonArbitrajBaslat;

	private ContextMenuStrip menuArbitraj;

	private ToolStripMenuItem menuArbitrajOzellikler;

	private ToolStripSeparator toolStripSeparator4;

	private ToolStripMenuItem menuArbitrajTumAktif;

	private ToolStripMenuItem menuArbitrajTumPasif;

	private ToolStripMenuItem menuArbitrajTumGercek;

	private ToolStripMenuItem menuArbitrajTumSanal;

	private ToolStripSeparator toolStripSeparator6;

	private ToolStripMenuItem menuArbitrajTumSil;

	private ToolStripMenuItem menuArbitrajPasifSil;

	private ToolStripMenuItem menuArbitrajSanalSil;

	private ToolStripMenuItem menuArbitrajSatirSil;

	private ToolStripSeparator toolStripSeparator7;

	private ToolStripMenuItem menuArbitrajKapat;

	private MyButton myButtonOptExcel;

	private TextBox textBoxOptSatirSayisi;

	private Label label16;

	private Panel panelOptInfo;

	private MyButton myButtonOptMax;

	private MyButton myButtonOptKarZarar;

	private MyButton myButtonOptAciklama;

	private MyButton myButtonOptSistemName;

	private Label label24;

	private Label label25;

	private MyButton myButtonIslemlerExcel;

	private Label label51;

	private Label label56;

	private Label label55;

	private Label label53;

	private TextBox textBoxOptIslemFilter;

	private TextBox textBoxOptHaricAy;

	public PictureBox pictureBoxIdealBE;

	private TabPage tabPageRoboTrade;

	private Panel panelRoboTradeSection;

	private RadioButton radioButtonRoboTradeSection02;

	private RadioButton radioButtonRoboTradeSection00;

	private RadioButton radioButtonRoboTradeSection01;

	private Panel panelRoboTradeListe;

	private DataGridView gridRoboTrade;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;

	private MyButton myButtonRoboTradeEkle;

	private MyButton myButtonRoboTradeBaslat;

	private Panel panelRoboTradeOzet;

	private DataGridView gridRoboTradeOzet;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;

	private Panel panelRoboTradeIslemler;

	private DataGridView gridRoboTradeIslemler;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;

	private Panel panelRoboTradeIslemlerHeader;

	private MyButton myButtonRoboTradeIslemlerExcel;

	private MyButton myButtonRoboTradeIslemlerListeyiTemizle;

	private Panel panelRoboTradeIslemlerTur;

	private RadioButton radioButtonRoboTradeIslemlerTur02;

	private RadioButton radioButtonRoboTradeIslemlerTur00;

	private RadioButton radioButtonRoboTradeIslemlerTur01;

	private ContextMenuStrip menuRoboTrade;

	private ToolStripMenuItem menuRoboTradeOzellikler;

	private ToolStripSeparator toolStripSeparator8;

	private ToolStripMenuItem menuRoboTradeBaslatDurdur;

	private ToolStripSeparator toolStripSeparator9;

	private ToolStripMenuItem menuRoboTradeTumunuSil;

	private ToolStripMenuItem menuRoboTradeGerceklesenleriSil;

	private ToolStripMenuItem menuRoboTradeSatirSil;

	private ToolStripMenuItem menuRoboTradeDegerleriTemizle;

	private ToolStripMenuItem menuRoboTradeTumDegerleriTemizle;

	private MyButton myButtonRoboTradeRowNo;

	public PictureBox pictureBoxYouTube;

	public PictureBox pictureBoxTvitter;

	private RadioButton radioButtonCiftYon02;

	private MyButton myButtonRobotKonsolide;

	private Label labelOptListCount;

	public ContextMenuStrip menuGrid;

	private ToolStripMenuItem menuExcel;

	private ToolStripSeparator toolStripSeparator10;

	private ToolStripMenuItem menuClose;

	private CheckBox checkBoxEmirListesiSilinmesin;

	private TextBox textBoxAyarTel;

	private Label label40;

	private CheckBox checkBoxSms;

	private Panel panel11;

	private CheckBox checkIkiAyKapat;

	private CheckBox checkHerAyKapat;

	private CheckBox checkCumaKapat;

	private Label label59;

	private Label label58;

	private TextBox textSaat2AydaBirPozisyonKapat;

	private Label label57;

	private TextBox textSaatHerAyPozisyonKapat;

	private TextBox textSaatCumaPozisyonKapat;

	private Panel panelEditor;

	private Label label61;

	private ComboBox comboBoxEditorSistem;

	private TabControl tabEditor;

	private TabPage tabEditor03;

	private TabPage tabEditor05;

	private TabPage tabEditor06;

	private TabPage tabEditor07;

	private TextBox textBoxEdit03Param1;

	private Label label82;

	private Label label75;

	private Label label76;

	private TextBox textBoxEdit03Param3;

	private Label label77;

	private TextBox textBoxEdit03Param2;

	private Label label81;

	private TabPage tabEditor04;

	private Label label83;

	private Label label84;

	private TextBox textBoxEdit04Param2;

	private Label label85;

	private TextBox textBoxEdit04Param1;

	private Label label89;

	private Label label63;

	private TextBox textBoxEdit05Param2;

	private TextBox textBoxEdit05Param1;

	private Label label64;

	private Label label71;

	private Label label72;

	private TextBox textBoxEdit06Param2;

	private Label label78;

	private TextBox textBoxEdit06Param1;

	private Label label79;

	private Label label65;

	private Label label70;

	private TextBox textBoxEdit05Param3;

	private TextBox textBoxEdit06Param3;

	private TextBox textBoxEdit07Param3;

	private Label label80;

	private Label label86;

	private TextBox textBoxEdit07Param2;

	private Label label87;

	private TextBox textBoxEdit07Param1;

	private Label label88;

	private TabPage tabEditor08;

	private Label label91;

	private TextBox textBoxEdit08Param2;

	private Label label92;

	private TextBox textBoxEdit08Param1;

	private Label label93;

	private Label labelHacimInfo;

	private TabPage tabEditor01;

	private TextBox textBoxEdit01Param3;

	private Label label68;

	private TextBox textBoxEdit01Param1;

	private Label label60;

	private Label label62;

	private TextBox textBoxEdit01Param4;

	private Label label66;

	private TextBox textBoxEdit01Param2;

	private Label label67;

	private MyButton myButtonPortfoyTercih;

	private MyButton myButtonManuelKapat;

	private MyButton myButtonRobotRowNo;

	private Label label69;

	private MyButton myButtonGunKz;

	private Label labelPortfoyMin;

	private Label label90;

	private Label labelPortfoyMax;

	private Label label73;

	private Label labelStopLevel;

	private Label labelKarAlLevel;

	private MyButton myButtonStopLevel;

	private MyButton myButtonKarAlLevel;

	private CheckBox checkBoxPortfoyKontrol;

	private CheckBox checkBoxYeniSinyal;

	private TabPage tabEditor02;

	private Label label98;

	private Label label97;

	private Label label100;

	private TextBox textBoxEdit02Param1;

	private Label label74;

	private Label label94;

	private TextBox textBoxEdit02Param3;

	private Label label95;

	private TextBox textBoxEdit02Param2;

	private Label label96;

	private Label label102;

	private Label label101;

	private Label label99;

	private Label label104;

	private Label label103;

	private Label label106;

	private Label label105;

	private Label label108;

	private Label label107;

	private TabPage tabEditor09;

	private Label label109;

	private TextBox textBoxEdit09Param1;

	private Label label110;

	private Label label111;

	private TextBox textBoxEdit09Param3;

	private Label label112;

	private TextBox textBoxEdit09Param2;

	private Label label113;

	private TabPage tabEditor10;

	private Label label114;

	private Label label115;

	private Label label116;

	private TextBox textBoxEdit10Param3;

	private Label label117;

	private TextBox textBoxEdit10Param1;

	private Label label118;

	private Label label119;

	private TextBox textBoxEdit10Param4;

	private Label label120;

	private TextBox textBoxEdit10Param2;

	private Label label121;

	private TabPage tabEditor11;

	private Label label124;

	private TextBox textBoxEdit11Param2;

	private Label label126;

	private TextBox textBoxEdit11Param1;

	private Label label127;

	private TabPage tabEditor12;

	private TextBox textBoxEdit12Param3;

	private Label label122;

	private Label label123;

	private Label label125;

	private Label label128;

	private TextBox textBoxEdit12Param2;

	private TextBox textBoxEdit12Param1;

	private TabPage tabEditor13;

	private Label label130;

	private TextBox textBoxEdit13Param1;

	private Label label131;

	private Label label132;

	private TextBox textBoxEdit13Param3;

	private Label label133;

	private TextBox textBoxEdit13Param2;

	private Label label134;

	private TabPage tabEditor14;

	private TextBox textBoxEdit14Param1;

	private Label label129;

	private Label label135;

	private TabPage tabEditor15;

	private Label label136;

	private TextBox textBoxEdit15Param2;

	private Label label137;

	private TextBox textBoxEdit15Param1;

	private Label label138;

	private TabPage tabEditor16;

	private TextBox textBoxEdit16Param3;

	private Label label139;

	private Label label140;

	private TextBox textBoxEdit16Param2;

	private Label label141;

	private TextBox textBoxEdit16Param1;

	private Label label142;

	private TabPage tabEditor17;

	private Label label144;

	private TextBox textBoxEdit17Param3;

	private Label label145;

	private Label label146;

	private TextBox textBoxEdit17Param2;

	private Label label147;

	private TextBox textBoxEdit17Param1;

	private Label label148;

	private CheckBox checkBoxFeedbackGetiriTek;

	private TabPage tabEditor18;

	private Label label143;

	private TextBox textBoxEdit18Param2;

	private Label label149;

	private TextBox textBoxEdit18Param1;

	private Label label150;

	private Label label151;

	private TextBox textBoxEdit18Param3;

	private Label label152;

	private Label label153;

	private CheckBox checkBoxMaxDdRegion;

	private CheckBox checkBoxMaxDdLine;

	private TabPage tabEditor19;

	private Label label154;

	private TextBox textBoxEdit19Param1;

	private Label label155;

	private TextBox textBoxEdit19Param3;

	private Label label156;

	private TextBox textBoxEdit19Param2;

	private Label label157;

	private TabPage tabEditor20;

	private Label label158;

	private TextBox textBoxEdit20Param1;

	private Label label159;

	private TextBox textBoxEdit20Param3;

	private Label label160;

	private TextBox textBoxEdit20Param2;

	private Label label161;

	private TabControl tabPerformans;

	private TabPage tabPerformans1;

	private Panel panel4;

	private DataGridView gridPerformansSummary;

	private Panel panel5;

	private TabPage tabPerformans2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	private DataGridViewTextBoxColumn Column3;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn Column2;

	private DataGridView gridPerformansOzet;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;

	private RadioButton radioButtonPerformans1;

	private RadioButton radioButtonPerformans0;

	private DataGridView gridPerformansPuan;

	private MyButton myButtonZararGrafikGoster;

	private RadioButton radioButtonZarar1;

	private RadioButton radioButtonZarar0;

	private Chart chartZarar;

	private Label label11;

	private Label labelZararIslem;

	private Label labelZararYuzde;

	private Label label18;

	private Label label12;

	private CheckBox checkBoxZararOran;

	private TabPage tabPerformans3;

	private CheckBox checkBoxKarOran;

	private Label labelKarIslem;

	private Label labelKarYuzde;

	private Label label164;

	private Label label165;

	private Label label166;

	private Chart chartKar;

	private MyButton myButtonKarGrafikGoster;

	private RadioButton radioButtonKar1;

	private RadioButton radioButtonKar0;

	private TabPage tabPerformans4;

	private MyButton myButtonOlasilikHesapla;

	private DataGridView gridOlasilik1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;

	private DataGridViewTextBoxColumn Column4;

	private DataGridView gridOlasilik2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;

	private DataGridViewTextBoxColumn Column5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;

	private DataGridViewTextBoxColumn Column6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;

	private MyButton myButtonSabitStopLevel;

	private Label labelSabitStopLevel;

	private Label label54;

	private CheckBox checkSaatOncesiSinyalYok;

	private TextBox textSaatOncesiSinyalYok;

	private Label label52;

	private CheckBox checkBoxPozKapat;

	private TextBox textBoxPozKapatSaat;

	private Label label48;

	private Label label47;

	private TextBox textBoxGetiriKayma;

	private CheckBox checkBoxStopBar;

	private CheckBox checkBoxStopSabitPuan;

	private CheckBox checkBoxStopSabitYuzde;

	private CheckBox checkBoxStopIzleyenPuan;

	private CheckBox checkBoxStopIzleyenYuzde;

	private Label label163;

	private TextBox textBoxStopIzleyenYuzde;

	private Label label162;

	private TextBox textBoxStopIzleyenSeviye;

	private CheckBox checkBoxStopSeviyeIzleyen;

	private TextBox textBoxGunKar;

	private CheckBox checkBoxGunKar;

	private TextBox textBoxGunZarar;

	private CheckBox checkBoxGunZarar;

	private Label label168;

	private Label label167;

	private MyButton myButtonMiktarAyarla;

	private Label label169;

	private Label label171;

	private NumericUpDown numericVites;

	private Label label170;

	private NumericUpDown numericKanalSanisi;

	private MyButton myButtonRunningCount;

	private TextBox textBoxUzakIp;

	private Label label173;

	private Label label172;

	private TextBox textBoxUzakPort;

	private Label label174;

	private Label labelUzakRenk;

	private Label label42;

	private Label label41;

	private Label label175;

	private Label label45;

	private Label label44;

	private Label label43;

	private Label labelTimerSablon4;

	private Label labelTimerSablon3;

	private Label labelTimerSablon2;

	private Label labelTimerSablon1;

	private Label labelTimerSablon;

	private Label labelSonRobot;

	private Label label177;

	private Label label176;

	private TextBox textBoxFlatBar;

	private CheckBox checkBoxFlatGun;

	private CheckBox checkBoxFlatBar;

	private ToolStripMenuItem menuHisse;

	private ToolStripMenuItem menuHisseTum;

	private ToolStripMenuItem menuHisse100;

	private ToolStripMenuItem menuHisse50;

	private ToolStripMenuItem menuHisse30;

	private ToolStripComboBox menuHisseCombo;

	private ToolStripSeparator toolStripSeparator11;

	private ToolStripSeparator toolStripSeparator12;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formSablonRobot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSablonRobot_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSablonRobot_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSablonRobot_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSablonRobot_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSablonRobot_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSablonRobot_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSablonRobot_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSablonRobot_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBoxStrateji_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBoxPerformansSistemler_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBoxPerformansPeriod_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridArbitraj_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridArbitraj_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridArbitraj_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridIslemler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridPerformansSummary_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridOptSummary_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridOptSummary_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobot_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobot_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobot_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobot_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridSembolTara_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridSembolTara_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridSembolTara_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridSistemTara_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridSistemTara_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridSistemTara_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridTablom_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridTablom_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridTablom_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridTablom_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void listBoxSistemler_MouseDoubleClick(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void listBoxSistemler_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void listBoxSistemler_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void listBoxSistemler_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void listBoxSistemler_DragOver(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuArbitrajOzellikler_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuArbitrajTumAktif_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuArbitrajTumPasif_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuArbitrajTumGercek_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuArbitrajTumSanal_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuArbitrajTumSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuArbitrajPasifSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuArbitrajSanalSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuArbitrajSatirSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuArbitrajKapat_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobotOzellikler_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobotTumAktif_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobotTumPasif_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobotTumSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobotPasifSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobotSanalSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobotSatirSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobotKapat_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobotTumGercek_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobotTumSanal_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobotTumPozisyonSifir_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTablomOzellikler_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTablomTumSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTablomGerceklesenleriSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTablomSatirSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonArbitrajBaslat__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonArbitrajEkle__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonSil__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonKaydet__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonFarkliKaydet__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonKaydetAyarlar__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonIslemlerExcel__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonIslemlerListeyiTemizle__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonMiktarAyarla__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonOptExcel__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonOptYenile__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonPerformansYenile__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonRobotBaslat__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonRobotEkle__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonSembolTaraSemboller__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonSembolTaraYenile__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonSistemTaraYenile__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonSembolTaraSembolleriKaydet__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonTablomEkle__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonTablomBaslat__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelAyarGetiriRenk_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioButtonIslemlerTur00_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxPerformansCash_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxPerformansLot_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxOptSymbol_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxOptSymbol_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxOptSymbol_Leave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxOptSymbol_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxPerformansSymbol_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxPerformansSymbol_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxPerformansSymbol_Leave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxPerformansSymbol_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxSistemTaraSymbol_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxSistemTaraSymbol_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxSistemTaraSymbol_Leave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxSistemTaraSymbol_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timer200_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timer1000_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CalculatePerformance()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeSistem(string sistemnameX, string senderIDX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayControls()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillArbitrajGrid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillArbitrajRow(int rownoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillIslemlerGrid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillOptGrid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillRobotGrid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillRobotRow(int rownoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillRoboTradeGrid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillRoboTradeRow(int rownoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillSembolTaraGrid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillSistemTaraGrid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillTablomGrid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillTablomRow(int rownoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessMenuMessage(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResizeWindow()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetSistem()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowSablonRobot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Timer200_Arbitraj()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Timer200_Opt()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Timer200_Robot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Timer200_SembolTara()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Timer200_SistemTara()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Timer200_Tablom()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Timer200_RoboTrade()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Timer1000_Arbitraj()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Timer1000_Islemler()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Timer1000_Opt()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Timer1000_Robot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Timer1000_SembolTara()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Timer1000_SistemTara()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Timer1000_Tablom()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Timer1000_RoboTrade()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void StartRoboTrade()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CalculateButtonPositions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SelectTab(idealgoTab selectTabX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowRoboTradePanel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioButtonRoboTradeSection00_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonRoboTradeEkle__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRoboTrade_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRoboTrade_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonRoboTradeBaslat__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRoboTrade_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRoboTradeOzellikler_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRoboTradeBaslatDurdur_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRoboTradeTumunuSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRoboTradeSatirSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRoboTradeIslemler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonRoboTradeIslemlerExcel__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonRoboTradeIslemlerListeyiTemizle__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRoboTradeOzet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRoboTradeDegerleriTemizle_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRoboTradeTumDegerleriTemizle_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pictureBoxTvitter_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pictureBoxYouTube_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonRobotKonsolide__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridOptSummary_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuExcel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonPortfoyTercih__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBoxPortfoyKontrol_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBoxYeniSinyal_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonManuelKapat__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridPerformansOzet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioButtonPerformans0_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioButtonPerformans1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridPerformansPuan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ZararGrafikGoster()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonZararGrafikGoster__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chartZarar_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioButtonZarar0_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioButtonZarar1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBoxZararOran_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void KarGrafikGoster()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonKarGrafikGoster__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chartKar_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioButtonKar0_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioButtonKar1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBoxKarOran_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonOlasilikHesapla__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridOlasilik1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuHisseCombo_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuHisseTum_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuHisse100_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuHisse50_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuHisse30_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HisseUygula(List<string> hisselist)
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
	static formSablonRobot()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		Referans = null;
		SembolTaraSembolFilter = "XU-100";
	}
}
