using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formBmc : Form
{
	public static formBmc Referans;

	private int Timer5Sn;

	private List<BmcTaramaClass> TaramaList;

	private List<BmcEmirClass> ManuelList;

	private Dictionary<string, int> ManuelTekrarMap;

	private Thread Thread1;

	private bool ManuelFinishedBool;

	private int ManuelTaranan;

	private int ManuelBulunan;

	private string SortColNameRobot;

	public string NTSistemSembol;

	public string NTSistemPeriyot;

	public string NTSistemName;

	private string NTSenderID;

	private Rectangle DragDropRect;

	private bool OptRunningBool;

	private int OptCount;

	private bool OptLastDisplay;

	private Thread ThreadOpt;

	private string DragDropString;

	private cxSistem SistemOpt;

	private bool OptSortAscendingBool;

	private string OptSortColName;

	private int TimerSayac5000;

	private IContainer components;

	private TabControl tab;

	private TabPage tabRobot;

	private TabPage tabIslem;

	private TabPage tabAyarlar;

	private MyButton myButtonToplamKZ;

	private Label labelToplamKZ;

	private MyButton myButtonPozisyonCount;

	private Label label18;

	private MyButton myButtonMenu;

	private Panel panelPozisyonDisplay;

	private RadioButton radioButtonPozisyonDisplay01;

	private RadioButton radioButtonPozisyonDisplay00;

	private MyButton myButtonAktifSembol;

	private Label labelAktifSembol;

	private MyButton myButtonBaslat;

	private DataGridView gridRobot;

	private DataGridViewTextBoxColumn ColTradeNo;

	private DataGridViewTextBoxColumn ColTradeDirection;

	private DataGridViewTextBoxColumn ColTradeLot;

	private DataGridViewTextBoxColumn ColTradeBuyDate;

	private DataGridViewTextBoxColumn ColTradeBuyPrice;

	private DataGridViewTextBoxColumn ColTradeSellDate;

	private DataGridViewTextBoxColumn ColTradeSellPrice;

	private DataGridViewTextBoxColumn ColTradeProfit;

	private DataGridViewTextBoxColumn ColTradeSellCash;

	private DataGridView gridSec;

	private Label label1;

	private Label labelSembolSayisi;

	private CheckBox checkBoxGundeBirKere;

	private Label label21;

	private TextBox textBoxMaxHisse;

	private Label label22;

	private Label label19;

	private TextBox textBoxMinHisse;

	private Label label20;

	private ComboBox comboBoxAltHesaplar;

	private Label label15;

	private ComboBox comboBoxHesaplar;

	private Label label16;

	private Label label14;

	private TextBox textBoxPozisyonKapanincaIslemAcma;

	private CheckBox checkBoxPozisyonKapanincaIslemAcma;

	private Label label10;

	private TextBox textBoxKardaPozKapat;

	private CheckBox checkBoxKardaPozKapat;

	private Label label9;

	private TextBox textBoxSurePozKapat;

	private CheckBox checkBoxSurePozKapat;

	private TextBox textBoxMaxPoz;

	private Label label7;

	private Label label4;

	private Label label3;

	private Label label2;

	private TextBox textBoxTL;

	private Label label6;

	private TextBox textBoxStopFiyat;

	private Label labelStopTip;

	private Label label5;

	private TextBox textBoxKarAlFiyat;

	private Label label8;

	private TextBox textBoxAksamKapatSaat;

	private Label label11;

	private TextBox textBoxKapanisSaat;

	private Label label12;

	private TextBox textBoxBaslangicSaat;

	private CheckBox checkBoxAksamPozKapat;

	private MyButton myButtonKaydet;

	private ListBox listSemboller;

	private MyButton myButtonSembolSec;

	private MyButton myButtonIslemExcel;

	private MyButton myButtonIslemleriTemizle;

	private DataGridView gridIslem;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;

	private MyButton myButtonAktifTarama;

	private Label labelAktifTarama;

	private ContextMenuStrip menuGenel;

	private ToolStripMenuItem menuGenelTumSil;

	private ToolStripMenuItem menuGenelPozSil;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripMenuItem menuGenelExcel;

	private ToolStripMenuItem menuGenelListeyeKaydet;

	private ToolStripMenuItem menuGenelGrafikDongu;

	private ToolStripMenuItem menuGenelWatchlist;

	private ToolStripSeparator toolStripMenuItem1;

	private ToolStripMenuItem menuGenelDownload;

	private ToolStripMenuItem menuGenelDownload1Dk;

	private Timer timer1000;

	private Timer timer100;

	private Label label17;

	private CheckedListBox listPeriyotlar;

	private MyButton myButtonAktifPeriyot;

	private Label labelAktifPeriyot;

	private TabPage tabManuel;

	private DataGridView gridManuelSec;

	private Label label13;

	private DataGridView gridManuelList;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;

	private MyButton myButtonDur;

	private MyButton myButtonGuncelle;

	private MyButton myButtonAktifPeriyot2;

	private MyButton myButtonAktifTarama2;

	private MyButton myButtonAktifSembol2;

	private MyButton myButtonManuelTaranan;

	private CheckBox checkBoxSurekliTara;

	private Label label23;

	private TextBox textBoxYukseldiyse;

	private CheckBox checkBoxYukseldiyse;

	private ToolStripSeparator toolStripSeparator2;

	private ToolStripMenuItem menuGenelHisseMaxTarama;

	private MyButton myButtonExcel;

	private DataGridViewTextBoxColumn Isim;

	private DataGridViewTextBoxColumn Aciklama;

	private DataGridViewCheckBoxColumn Sec;

	private DataGridViewTextBoxColumn Isim2;

	private DataGridViewTextBoxColumn Aciklama2;

	private DataGridViewCheckBoxColumn Sec2;

	private CheckBox checkBoxTekrarLimit;

	private Label labelTekrarLimit;

	private Label label24;

	private TextBox textBoxKomisyon;

	private Label label25;

	private MyButton myButtonUyari;

	private Label label26;

	private TextBox textBoxAksamKardaKapatSaat;

	private CheckBox checkBoxAksamKardaPozKapat;

	private Panel panelHeader;

	private Label labelMinimizeWindow;

	private Label labelCloseWindow;

	private Label labelHeader;

	private MyButton myButtonRobotPortfoy;

	private Label labelPortfoy;

	private Panel panelSanal;

	private RadioButton radioButtonSanal01;

	private RadioButton radioButtonSanal00;

	private CheckedListBox listOrtakSistemler;

	private Label OrtakBulunanLimitLabel;

	private TextBox textOrtakBulunanLimit;

	private GroupBox groupBmcOrtak;

	private MyButton myButtonBulunanSembolleriListeyeKaydet;

	private TabPage tabNagantsTrade;

	private TabControl tabControl1;

	private TabPage tabPageSistemler;

	private Panel panel9;

	private Label label52;

	private CheckBox checkBoxPozKapat;

	private TextBox textBoxPozKapatSaat;

	private Panel panel6;

	private Label label48;

	private Label label47;

	private TextBox textBoxGetiriKayma;

	private Panel panelStopYontem;

	private Label label27;

	private RadioButton radioBoxStopYontem01;

	private RadioButton radioBoxStopYontem00;

	private Panel panelParametreTum;

	private Panel panelParametre;

	private Label labelHeader1;

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

	private MyButton myButtonPeriyot;

	private MyButton myButtonSembol;

	private Panel panelCiftYon;

	private RadioButton radioButtonCiftYon02;

	private RadioButton radioButtonCiftYon00;

	private RadioButton radioButtonCiftYon01;

	private Label label31;

	private ComboBox comboBoxStrateji;

	private MyButton myButtonSil;

	private MyButton myButtonFarkliKaydetNT;

	private MyButton myButtonKaydetNT;

	private Panel panel1;

	private Label label32;

	private CheckBox checkBoxKarZarar;

	private TextBox textBoxKarZarar;

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

	private Label label33;

	private Label label34;

	private CheckBox checkBoxStop;

	private Label label35;

	private TextBox textBoxStopHL;

	private TextBox textBoxStopSabit;

	private TextBox textBoxStopIzleyen;

	private RadioButton radioBoxStop02;

	private RadioButton radioBoxStop01;

	private RadioButton radioBoxStop00;

	private ListBox listBoxSistemler;

	private TabPage tabPagePerformans;

	private Panel panel5;

	private MyButton myButtonPerformansProfitFaktor;

	private MyButton myButtonPerformansIslemSayisi;

	private Label label36;

	private Label label37;

	private Label label38;

	private MyButton myButtonPerformansGetiri;

	private MyButton myButtonPerformansMaxDD;

	private Label labelPerformansMaxDDDate;

	private Label labelPerformansMaxDDVal;

	private Label labelPerformansMaxDDDate2;

	private Label labelPerformansMaxDDDate1;

	private Panel panel4;

	private DataGridView gridPerformansSummary;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;

	private DataGridViewTextBoxColumn Column3;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn Column2;

	private Panel panel3;

	public TextBox textBoxPerformansLot;

	private Label label39;

	public TextBox textBoxPerformansCash;

	private Label label40;

	private Panel panel2;

	private MyButton myButtonPerformansYenile;

	private TextBox textBoxPerformansBitis;

	private Label label41;

	private TextBox textBoxPerformansBaslangic;

	private Label label42;

	private Label label43;

	private ComboBox comboBoxPerformansPeriod;

	private Label label44;

	private ComboBox comboBoxPerformansSistemler;

	private Label label45;

	public TextBox textBoxPerformansSymbol;

	private TabPage tabPageOpt;

	private Panel panelOptSummary;

	private DataGridView gridOptSummary;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;

	private Panel panelOptHeader;

	private Panel panelOptInfo;

	private Label labelOptListCount;

	private MyButton myButtonOptMax;

	private MyButton myButtonOptKarZarar;

	private MyButton myButtonOptAciklama;

	private MyButton myButtonOptSistemName;

	private Label label46;

	private Label label51;

	private TextBox textBoxOptSatirSayisi;

	private Label label53;

	private MyButton myButtonOptExcel;

	private MyButton myButtonOptYenile;

	private TextBox textBoxOptBitis;

	private Label label54;

	private TextBox textBoxOptBaslangic;

	private Label label55;

	private Label label56;

	private ComboBox comboBoxOptPeriod;

	private Label label57;

	private ComboBox comboBoxOptSistemler;

	private Label label58;

	public TextBox textBoxOptSymbol;

	private TabPage tabPageRobot;

	private Panel panelRobotListe;

	private DataGridView gridRobotNagants;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;

	private Panel panelRobotInfo;

	private Label labelRobotRowNo;

	private MyButton myButtonRobotEkle;

	private MyButton myButtonRobotBaslat;

	private TabPage tabPageIslemler;

	private MyButton myButtonIslemlerExcel;

	private MyButton myButtonIslemlerListeyiTemizle;

	private Panel panelIslemlerListe;

	private DataGridView gridIslemler;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;

	private Panel panelIslemlerTur;

	private RadioButton radioButtonIslemlerTur02;

	private RadioButton radioButtonIslemlerTur00;

	private RadioButton radioButtonIslemlerTur01;

	private TabPage tabPageAyarlar;

	private CheckBox checkBoxEmirListesiSilinmesin;

	private TextBox textBoxOptHaricAy;

	private TextBox textBoxOptIslemFilter;

	private Label label70;

	private Label label71;

	private Label label72;

	private Label label73;

	private CheckBox checkBoxAyarGetiriAciklamaBool;

	private Label labelAyarGetiriRenk;

	private Label label74;

	private TextBox textBoxAyarMailAlici;

	private Label label75;

	private TextBox textBoxAyarMailGonderenSifre;

	private Label label76;

	private TextBox textBoxAyarMailGonderenAdres;

	private Label label77;

	private TextBox textBoxAyarMailServerPort;

	private Label label78;

	private TextBox textBoxAyarMailServerAdres;

	private Label label79;

	private TextBox textBoxRobotTime2;

	private TextBox textBoxRobotTime1;

	private Label label81;

	private CheckBox checkBoxRobotWeekend;

	private CheckBox checkBoxVadeGecis;

	private CheckBox checkBoxMail;

	private MyButton myButtonKaydetAyarlar;

	private ContextMenuStrip menuRobot;

	private ToolStripMenuItem menuRobotOzellikler;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripMenuItem menuRobotTumAktif;

	private ToolStripMenuItem menuRobotTumPasif;

	private ToolStripMenuItem menuRobotTumGercek;

	private ToolStripMenuItem menuRobotTumSanal;

	private ToolStripMenuItem menuRobotTumPozisyonSifir;

	private ToolStripSeparator toolStripSeparator4;

	private ToolStripMenuItem menuRobotTumSil;

	private ToolStripMenuItem menuRobotPasifSil;

	private ToolStripMenuItem menuRobotSanalSil;

	private ToolStripMenuItem menuRobotSatirSil;

	private ToolStripSeparator toolStripSeparator5;

	private ToolStripMenuItem menuRobotKapat;

	private Timer timer200;

	private DataGridView dgvParametreAciklama;

	private DataGridViewTextBoxColumn ParameterName;

	private DataGridViewTextBoxColumn ParametreAciklama;

	private CheckBox checkBoxSms;

	private TextBox textBoxAyarTel;

	private Label label28;

	private Panel panel7;

	private Label label29;

	private CheckBox checkSaatOncesiSinyalYok;

	private TextBox textSaatOncesiSinyalYok;

	private Label label163;

	private TextBox textBoxStopIzleyenYuzde;

	private Label label162;

	private TextBox textBoxStopIzleyenSeviye;

	private CheckBox checkBoxStopSeviyeIzleyen;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formBmc()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBmc_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBmc_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBmc_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBmc_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBmc_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBmc_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBmc_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBoxTekrarLimit_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBoxHesaplar_SelectionChangeCommitted(object sender, EventArgs e)
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
	private void comboBoxStrateji_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridIslem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridIslemler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridManuelList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridManuelList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridManuelList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridManuelSec_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobot_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobot_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobot_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobot_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
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
	private void gridOptSummary_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobotNagants_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobotNagants_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobotNagants_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobotNagants_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridSec_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelAyarGetiriRenk_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelTekrarLimit_MouseDown(object sender, MouseEventArgs e)
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
	private void menuGenelDownload_Click(object sender, EventArgs e)
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
	private void menuGenelDownload1Dk_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGenelExcel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGenelGrafikDongu_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGenelHisseMaxTarama_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGenelListeyeKaydet_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGenelPozSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGenelTumSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGenelWatchlist_Click(object sender, EventArgs e)
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
	private void myButtonBaslat__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonDur__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonGuncelle__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonIslemleriTemizle__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonIslemExcel__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonIslemlerListeyiTemizle__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonIslemlerExcel__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonExcel__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonMenu__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonKaydet__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonKaydetAyarlar__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonBulunanSembolleriListeyeKaydet__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonKaydetNT__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonFarkliKaydetNT__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonSil__OnClick(object sender, EventArgs e)
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
	private void myButtonPerformansMaxDD__OnClick(object sender, EventArgs e)
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
	private void myButtonSembolSec__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonUyari__OnClick(object sender, EventArgs e)
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
	private void radioButtonPozisyonDisplay00_Click(object sender, EventArgs e)
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
	private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timer100_Tick(object sender, EventArgs e)
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
	private void CalculateManuel()
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
	private void FillAyarlar()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillGridSec()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillIslem()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillManuel()
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
	private void FillRobot()
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
	private void Guncelle()
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
	public static void ShowWindow(string sistemNameX, string activeSymbolX, string periodX, string senderidX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetSistem()
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
	private void Timer200_Opt()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Timer200_Robot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonOptExcel__OnClick(object sender, EventArgs e)
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
	static formBmc()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
