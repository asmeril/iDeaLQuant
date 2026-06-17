using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formTahta : Form
{
	public static formTahta Referans;

	private int Timer5Sn;

	public string SistemSembol;

	public string SistemPeriyot;

	public string SistemName;

	private string SenderID;

	private Rectangle DragDropRect;

	private string DragDropString;

	private bool OptRunningBool;

	private int OptCount;

	private bool OptLastDisplay;

	private Thread ThreadOpt;

	private cxSistem SistemOpt;

	private bool OptSortAscendingBool;

	private string OptSortColName;

	private int TimerSayac5000;

	private IContainer components;

	private TabControl tab;

	private TabPage tabTahta1;

	private Timer timer1000;

	private Timer timer100;

	private Panel panelHeader;

	private Label labelHeader;

	public PictureBox pictureBoxHeader;

	private Label labelCloseWindow;

	private Label labelMinimizeWindow;

	private TabControl tab1;

	private TabPage tabRobot1;

	private MyButton myButtonRobot1KZ;

	private Label labelToplamKZ;

	private MyButton myButtonRobot1Portfoy;

	private Label label18;

	private MyButton myButtonRobot1Baslat;

	private Panel panelRobot1Sanal;

	private RadioButton radioButtonRobot1Sanal01;

	private RadioButton radioButtonRobot1Sanal00;

	private DataGridView gridRobot1;

	private DataGridViewTextBoxColumn ColTradeNo;

	private DataGridViewTextBoxColumn ColTradeDirection;

	private DataGridViewTextBoxColumn ColTradeLot;

	private DataGridViewTextBoxColumn ColTradeBuyDate;

	private DataGridViewTextBoxColumn ColTradeBuyPrice;

	private DataGridViewTextBoxColumn ColTradeSellDate;

	private DataGridViewTextBoxColumn ColTradeSellPrice;

	private DataGridViewTextBoxColumn ColTradeProfit;

	private DataGridViewTextBoxColumn ColTradeSellCash;

	private TabPage tabIslem1;

	private MyButton myButtonRobot1Ekle;

	private MyButton myButtonRobot1Menu;

	private Label label6;

	private CheckBox checkBoxRobot1AksamKapat;

	private Label labelRobot1AksamPozKapat;

	private ContextMenuStrip menuRobot1;

	private ToolStripMenuItem menuRobot1SatirTemizle;

	private ToolStripMenuItem menuRobot1SatirSil;

	private ToolStripSeparator toolStripSeparator2;

	private ToolStripMenuItem menuRobot1TumTemizle;

	private ToolStripMenuItem menuRobot1TumSil;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripMenuItem menuRobot1Excel;

	private ToolStripSeparator toolStripMenuItem1;

	private ToolStripMenuItem menuRobot1KurusGoster;

	private MyButton myButtonIslem1Excel;

	private MyButton myButtonIslem1Temizle;

	private DataGridView gridIslem1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;

	private TabPage tabTahta2;

	private TabControl tab2;

	private TabPage tabRobot2;

	private Label labelRobot2AksamPozKapat;

	private Label label2;

	private CheckBox checkBoxRobot2AksamKapat;

	private MyButton myButtonRobot2Menu;

	private MyButton myButtonRobot2Ekle;

	private MyButton myButtonRobot2KZ;

	private Label label3;

	private MyButton myButtonRobot2Portfoy;

	private Label label4;

	private MyButton myButtonRobot2Baslat;

	private Panel panelRobot2Sanal;

	private RadioButton radioButtonRobot2Sanal01;

	private RadioButton radioButtonRobot2Sanal00;

	private DataGridView gridRobot2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;

	private TabPage tabIslem2;

	private MyButton myButtonIslem2Excel;

	private MyButton myButtonIslem2Temizle;

	private DataGridView gridIslem2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;

	private ContextMenuStrip menuRobot2;

	private ToolStripMenuItem menuRobot2SatirTemizle;

	private ToolStripMenuItem menuRobot2SatirSil;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripMenuItem menuRobot2TumTemizle;

	private ToolStripMenuItem menuRobot2TumSil;

	private ToolStripSeparator toolStripSeparator4;

	private ToolStripMenuItem menuRobot2Excel;

	private Label label7;

	private Label labelRobot2EmirSure;

	private Label label5;

	private TabPage tabTimsahAgzi;

	private TabControl tabHisseAnaliz;

	private TabPage tabSistem;

	private Panel panel9;

	private Label label52;

	private CheckBox checkBoxPozKapat;

	private TextBox textBoxPozKapatSaat;

	private Panel panel6;

	private Label label48;

	private Label label47;

	private TextBox textBoxGetiriKayma;

	private Panel panelStopYontem;

	private Label label15;

	private RadioButton radioBoxStopYontem01;

	private RadioButton radioBoxStopYontem00;

	private MyButton myButtonSil;

	private MyButton myButtonFarkliKaydet;

	private MyButton myButtonKaydet;

	private Panel panelKarAl;

	private RadioButton radioBoxKarAl01;

	private RadioButton radioBoxKarAl00;

	private TextBox textBoxKarAlPuan;

	private CheckBox checkBoxKarAl;

	private TextBox textBoxKarAl;

	private Panel panelStop;

	private Label label50;

	private TextBox textBoxStopSabitPuan;

	private RadioButton radioBoxStop04;

	private Label label49;

	private TextBox textBoxStopIzleyenPuan;

	private RadioButton radioBoxStop03;

	private Label label17;

	private Label label19;

	private CheckBox checkBoxStop;

	private Label label20;

	private TextBox textBoxStopHL;

	private TextBox textBoxStopSabit;

	private TextBox textBoxStopIzleyen;

	private RadioButton radioBoxStop02;

	private RadioButton radioBoxStop01;

	private RadioButton radioBoxStop00;

	private Panel panelParametre;

	private MyButton myButtonPeriyot;

	private MyButton myButtonSembol;

	private CheckBox chkDxKesisim;

	private CheckBox chkDxA;

	private CheckBox chkDxS;

	private Label label23;

	private TextBox txtDx_P1A;

	private TextBox txtDx_P1O2;

	private TextBox txtDx_P1O1;

	private TextBox txtDx_P1;

	private Label label24;

	private Label label14;

	private Label label16;

	private Label label21;

	private Label label25;

	private Label label22;

	private RadioButton radioButtonCiftYon02;

	private RadioButton radioButtonCiftYon00;

	private RadioButton radioButtonCiftYon01;

	private ListBox listBoxSistemler;

	private TabPage tabRobot;

	private Panel panelRobotListe;

	private DataGridView gridRobot;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;

	private Panel panelRobotInfo;

	private MyButton myButtonRobotKonsolide;

	private Label labelRobotRowNo;

	private MyButton myButtonRobotEkle;

	private MyButton myButtonRobotBaslat;

	private TabPage tabPageAyarlar;

	private TextBox textBoxOptHaricAy;

	private TextBox textBoxOptIslemFilter;

	private Label label56;

	private Label label55;

	private Label label53;

	private Label label51;

	private CheckBox checkBoxAyarGetiriAciklamaBool;

	private Label labelAyarGetiriRenk;

	private Label label46;

	private TextBox textBoxAyarMailAlici;

	private Label label45;

	private TextBox textBoxAyarMailGonderenSifre;

	private Label label44;

	private TextBox textBoxAyarMailGonderenAdres;

	private Label label43;

	private TextBox textBoxAyarMailServerPort;

	private Label label42;

	private TextBox textBoxAyarMailServerAdres;

	private Label label41;

	private TextBox textBoxAyarTel;

	private Label label40;

	private TextBox textBoxRobotTime2;

	private TextBox textBoxRobotTime1;

	private Label label28;

	private CheckBox checkBoxRobotWeekend;

	private CheckBox checkBoxVadeGecis;

	private CheckBox checkBoxSms;

	private CheckBox checkBoxMail;

	private MyButton myButtonKaydetAyarlar;

	private ContextMenuStrip menuRobot;

	private ToolStripMenuItem menuRobotOzellikler;

	private ToolStripSeparator toolStripSeparator5;

	private ToolStripMenuItem menuRobotTumAktif;

	private ToolStripMenuItem menuRobotTumPasif;

	private ToolStripMenuItem menuRobotTumGercek;

	private ToolStripMenuItem menuRobotTumSanal;

	private ToolStripMenuItem menuRobotTumPozisyonSifir;

	private ToolStripSeparator toolStripSeparator6;

	private ToolStripMenuItem menuRobotTumSil;

	private ToolStripMenuItem menuRobotPasifSil;

	private ToolStripMenuItem menuRobotSanalSil;

	private ToolStripMenuItem menuRobotSatirSil;

	private ToolStripSeparator toolStripSeparator7;

	private ToolStripMenuItem menuRobotKapat;

	private TabPage tabPageIslemler;

	private MyButton myButtonIslemlerExcel;

	private MyButton myButtonIslemlerListeyiTemizle;

	private Panel panelIslemlerListe;

	private DataGridView gridIslemler;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;

	private Panel panelIslemlerTur;

	private RadioButton radioButtonIslemlerTur02;

	private RadioButton radioButtonIslemlerTur00;

	private RadioButton radioButtonIslemlerTur01;

	private TabPage tabPagePerformans;

	private Panel panel1;

	private MyButton myButtonPerformansProfitFaktor;

	private MyButton myButtonPerformansIslemSayisi;

	private Label label1;

	private Label label12;

	private Label label11;

	private MyButton myButtonPerformansGetiri;

	private MyButton myButtonPerformansMaxDD;

	private Label labelPerformansMaxDDDate;

	private Label labelPerformansMaxDDVal;

	private Label labelPerformansMaxDDDate2;

	private Label labelPerformansMaxDDDate1;

	private Panel panel4;

	private DataGridView gridPerformansSummary;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;

	private DataGridViewTextBoxColumn Column3;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn Column2;

	private Panel panel3;

	public TextBox textBoxPerformansLot;

	private Label label8;

	public TextBox textBoxPerformansCash;

	private Label label9;

	private Panel panel2;

	private MyButton myButtonPerformansYenile;

	private TextBox textBoxPerformansBitis;

	private Label label10;

	private TextBox textBoxPerformansBaslangic;

	private Label label13;

	private Label label26;

	private ComboBox comboBoxPerformansPeriod;

	private Label label27;

	private ComboBox comboBoxPerformansSistemler;

	private Label label29;

	public TextBox textBoxPerformansSymbol;

	private CheckBox chkRSIKesisim;

	private CheckBox chkRSIA;

	private CheckBox chkRSIS;

	private Label label30;

	private TextBox txtRSI_P1A;

	private TextBox txtRSI_P1O2;

	private TextBox txtRSI_P1O1;

	private Label label33;

	private Label label32;

	private TextBox txtRSI_P2;

	private TextBox txtRSI_P1;

	private TextBox txtRSI_P2A;

	private TextBox txtRSI_P2O2;

	private TextBox txtRSI_P2O1;

	private Label label31;

	private TabPage tabPageOpt;

	private Panel panelOptSummary;

	private DataGridView gridOptSummary;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;

	private Panel panelOptHeader;

	private Panel panelOptInfo;

	private Label labelOptListCount;

	private MyButton myButtonOptMax;

	private MyButton myButtonOptKarZarar;

	private MyButton myButtonOptAciklama;

	private MyButton myButtonOptSistemName;

	private Label label34;

	private Label label35;

	private TextBox textBoxOptSatirSayisi;

	private Label label36;

	private MyButton myButtonOptExcel;

	private MyButton myButtonOptYenile;

	private TextBox textBoxOptBitis;

	private Label label37;

	private TextBox textBoxOptBaslangic;

	private Label label38;

	private Label label39;

	private ComboBox comboBoxOptPeriod;

	private Label label54;

	private ComboBox comboBoxOptSistemler;

	private Label label57;

	public TextBox textBoxOptSymbol;

	private ComboBox comboBoxRSIMA;

	private ComboBox comboBoxATRMA;

	private Label label58;

	private Label label59;

	private TextBox txtATR_P2;

	private TextBox txtATR_P1;

	private CheckBox chkATRKesisim;

	private CheckBox chkATRA;

	private CheckBox chkATRS;

	private TextBox txtATR_P2A;

	private Label label60;

	private TextBox txtATR_P2O2;

	private TextBox txtATR_P1A;

	private TextBox txtATR_P2O1;

	private TextBox txtATR_P1O2;

	private TextBox txtATR_P1O1;

	private ComboBox comboBoxMACDMA;

	private Label label61;

	private Label label62;

	private TextBox txtMACD_P2;

	private TextBox txtMACD_P1;

	private CheckBox chkMACDKesisim;

	private CheckBox chkMACDA;

	private CheckBox chkMACDS;

	private TextBox txtMACD_P2A;

	private Label label63;

	private TextBox txtMACD_P2O2;

	private TextBox txtMACD_P1A;

	private TextBox txtMACD_P2O1;

	private TextBox txtMACD_P1O2;

	private TextBox txtMACD_P1O1;

	private CheckBox chkMACD1Opt;

	private CheckBox chkMACDOpt;

	private CheckBox chkATRMAOpt;

	private CheckBox chkATROpt;

	private CheckBox chkRSIMAOpt;

	private CheckBox chkRSIOpt;

	private CheckBox chkDXOpt;

	private Label label64;

	private ProgressBar HisseAnalizProgressOpt;

	private CheckBox chkFX1Opt;

	private CheckBox chkFXOpt;

	private CheckBox chkTSFOpt;

	private ComboBox comboBoxFXMA;

	private Label label70;

	private Label label69;

	private Label label66;

	private CheckBox chkHLVOpt;

	private TextBox txtFX_P2;

	private TextBox txtFX_P1;

	private TextBox txtTSF_P1;

	private CheckBox chkFXKesisim;

	private CheckBox chkFXA;

	private CheckBox chkTSFA;

	private CheckBox chkFXS;

	private Label label72;

	private CheckBox chkTSFS;

	private TextBox txtFX_P2A;

	private Label label68;

	private Label label65;

	private TextBox txtFX_P2O2;

	private TextBox txtFX_P1A;

	private TextBox txtTSF_P1A;

	private TextBox txtFX_P2O1;

	private TextBox txtFX_P1O2;

	private TextBox txtTSF_P1O2;

	private TextBox txtFX_P1O1;

	private TextBox txtTSF_P1O1;

	private CheckBox chkHLVKesisim;

	private CheckBox chkHLVA;

	private CheckBox chkHLVS;

	private Label label71;

	private TextBox txtHLV_P1A;

	private TextBox txtHLV_P1O2;

	private TextBox txtHLV_P1O1;

	private TextBox txtHLV_P1;

	private CheckBox chkFXMAOpt;

	private TextBox txtFX_P3O1;

	private TextBox txtFX_P3O2;

	private TextBox txtFX_P3A;

	private Label label74;

	private TextBox txtFX_P3;

	private Panel panel10;

	private Panel panel11;

	private Panel panel12;

	private Panel panel13;

	private CheckBox chkMACDMAOpt;

	private TextBox txtMACD_P3O1;

	private TextBox txtMACD_P3O2;

	private TextBox txtMACD_P3A;

	private Label label73;

	private TextBox txtMACD_P3;

	private Panel panelCiftYon;

	private Panel panel8;

	private Panel panel5;

	private TextBox txtHLV_P2;

	private TextBox txtHLV_P2O1;

	private TextBox txtHLV_P2O2;

	private TextBox txtHLV_P2A;

	private Label label75;

	private CheckBox chkHLV1Opt;

	private CheckBox chkTSFMAOpt;

	private TextBox txtTSF_P2O1;

	private TextBox txtTSF_P2O2;

	private TextBox txtTSF_P2A;

	private TextBox txtTSF_P2;

	private Label label67;

	private ComboBox comboBoxTSFMA;

	private CheckBox chkTSFKesisim;

	private ToolTip toolTip1;

	private ToolStripMenuItem menuRobot1Aktif;

	private ToolStripMenuItem menuRobot1Pasif;

	private TextBox textBoxAra;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formTahta()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTahta_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTahta_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTahta_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTahta_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTahta_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTahta_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTahta_SizeChanged(object sender, EventArgs e)
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
	private void checkBoxRobot1AksamKapat_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBoxRobot2AksamKapat_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridIslem1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridIslem2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridOptSummary_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridOptSummary_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridOptSummary_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobot1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobot2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobot2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobot1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobot1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobot2_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelAyarGetiriRenk_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelRobot1AksamPozKapat_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelRobot2AksamPozKapat_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelRobot2EmirSure_MouseDown(object sender, MouseEventArgs e)
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
	private void listBoxSistemler_MouseDoubleClick(object sender, MouseEventArgs e)
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
	private void listBoxSistemler_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobot1SatirTemizle_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobot2SatirTemizle_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobot1SatirSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobot2SatirSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobot1TumTemizle_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobot2TumTemizle_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobot1TumSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobot2TumSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobot1Excel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobot2Excel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobot1KurusGoster_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonPerformansMaxDD__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonRobot1Menu__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonRobot2Menu__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonIslem1Excel__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonIslem2Excel__OnClick(object sender, EventArgs e)
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
	private void myButtonIslem1Temizle__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonIslem2Temizle__OnClick(object sender, EventArgs e)
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
	private void myButtonRobot1Ekle__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonRobot2Ekle__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonRobot1Baslat__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonRobot2Baslat__OnClick(object sender, EventArgs e)
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
	private void radioButtonIslemlerTur00_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tab_SelectedIndexChanged(object sender, EventArgs e)
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
	private void timer100_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timer1000_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Timer200_Opt()
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
	private void CalculatePerformance()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeSistem(string sistemnameX, string senderIDX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillIslem1()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillRobot1()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillIslem2()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillRobot2()
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
	private void ResizeWindow()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetSistem()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IndicatorParameterToggle(string indicatorNameX, bool toggleX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowWindow(string sistemNameX, string activeSymbolX, string periodX, string senderidX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonHisseaRobotBaslat__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonKaydetAyarlar__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonKaydet__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonSil__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonFarkliKaydet__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonRobotEkle__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobotTumSil_Click(object sender, EventArgs e)
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
	private void menuRobotKapat_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tabHisseAnaliz_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chkIndicatorChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelParametre_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobot1Aktif_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobot1AktifPasif_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxAra_TextChanged(object sender, EventArgs e)
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
	static formTahta()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
