using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formTaramaRobot : Form
{
	public static formTaramaRobot Referans;

	private int Timer5Sn;

	private IContainer components;

	private TabControl tab;

	private TabPage tabIslem;

	private TabPage tabRobot;

	private TabPage tabAyarlar;

	private Label label1;

	private CheckedListBox listTaramalar;

	private MyButton myButtonSembolSec;

	private ListBox listSemboller;

	private Label label8;

	private TextBox textBoxAksamKapatSaat;

	private Label label11;

	private TextBox textBoxKapanisSaat;

	private Label label12;

	private TextBox textBoxBaslangicSaat;

	private CheckBox checkBoxAksamPozKapat;

	private MyButton myButtonKaydet;

	private TextBox textBoxTL;

	private Label label6;

	private TextBox textBoxStopFiyat;

	private Label labelStopTip;

	private Label label5;

	private TextBox textBoxKarAlFiyat;

	private Label label4;

	private Label label3;

	private Label label2;

	private TextBox textBoxMaxPoz;

	private Label label7;

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

	private Label label10;

	private TextBox textBoxKardaPozKapat;

	private CheckBox checkBoxKardaPozKapat;

	private Label label9;

	private TextBox textBoxSurePozKapat;

	private CheckBox checkBoxSurePozKapat;

	private Label label14;

	private TextBox textBoxPozisyonKapanincaIslemAcma;

	private CheckBox checkBoxPozisyonKapanincaIslemAcma;

	private ComboBox comboBoxAltHesaplar;

	private Label label15;

	private ComboBox comboBoxHesaplar;

	private Label label16;

	private MyButton myButtonBaslat;

	private MyButton myButtonAktifSembol;

	private Label labelAktifSembol;

	private MyButton myButtonAktifTarama;

	private Label label17;

	private Timer timer100;

	private Label label19;

	private TextBox textBoxMinHisse;

	private Label label20;

	private Label label21;

	private TextBox textBoxMaxHisse;

	private Label label22;

	private CheckBox checkBoxGundeBirKere;

	private Label labelSembolSayisi;

	private Panel panelPozisyonDisplay;

	private RadioButton radioButtonPozisyonDisplay01;

	private RadioButton radioButtonPozisyonDisplay00;

	private MyButton myButtonMenu;

	private Timer timer1000;

	private MyButton myButtonPozisyonCount;

	private Label label18;

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

	private MyButton myButtonToplamKZ;

	private Label labelToplamKZ;

	private MyButton myButtonIslemExcel;

	private Panel panelCanliBar;

	private RadioButton radioBoxCanliBar01;

	private RadioButton radioBoxCanliBar00;

	private Panel panelSanal;

	private RadioButton radioButtonSanal00;

	private CheckBox checkBoxYukseldiyse;

	private Label label23;

	private TextBox textBoxYukseldiyse;

	private RadioButton radioButtonSanal01;

	private MyButton myButtonTaramaName;

	private ToolStripMenuItem menuGenelHisseMaxTarama;

	private Label label24;

	private TextBox textBoxAksamZararKapatSaat;

	private CheckBox checkBoxAksamZararKapat;

	private Label label13;

	private TextBox textBoxAksamKarKapatSaat;

	private CheckBox checkBoxAksamKarKapat;

	private Label label25;

	private TextBox textBoxSeviyeIzleyenStop;

	private CheckBox checkBoxSeviyeIzleyen;

	private Label label27;

	private Label label26;

	private TextBox textBoxSeviyeIzleyenYuzde;

	private Label label29;

	private TextBox textBoxEndeksKucukKapatVal;

	private Label label28;

	private TextBox textBoxEndeksKucukAlmaVal;

	private CheckBox checkBoxEndeksKucukKapat;

	private CheckBox checkBoxEndeksKucukAlma;

	private TextBox textBoxEndeksKucukKapatSembol;

	private TextBox textBoxEndeksKucukAlmaSembol;

	private TextBox textBoxEndeksBuyukKapatSembol;

	private Label label31;

	private TextBox textBoxEndeksBuyukKapatVal;

	private CheckBox checkBoxEndeksBuyukKapat;

	private TextBox textBoxEndeksBuyukAlmaSembol;

	private Label label30;

	private TextBox textBoxEndeksBuyukAlmaVal;

	private CheckBox checkBoxEndeksBuyukAlma;

	private CheckBox checkBoxKodlaKapat;

	private MyButton myButtonKodGoster;

	private ComboBox comboKodlaKapatSistem;

	private Label label33;

	private ComboBox comboKodlaKapatPeriod;

	private CheckBox checkBoxSistemleKapat;

	private MyButton myButtonSure;

	private Label labelSure;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formTaramaRobot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTarama_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTarama_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTarama_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTarama_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBoxHesaplar_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridIslem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobot_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGenelDownload_Click(object sender, EventArgs e)
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
	private void myButtonBaslat__OnClick(object sender, EventArgs e)
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
	private void myButtonKaydet__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonMenu_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonSembolSec__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioButtonPozisyonDisplay00_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tab_SelectedIndexChanged(object sender, EventArgs e)
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
	private void FillIslem()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillRobot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillRobotSetting(string robotNameX)
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
	public static void ShowTaramaRobot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobot_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void listTaramalar_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tabAyarlar_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxEndeksKucukAlmaSembol_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxEndeksKucukAlmaSembol_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxEndeksKucukAlmaSembol_Leave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxEndeksKucukAlmaSembol_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxEndeksBuyukAlmaSembol_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxEndeksBuyukAlmaSembol_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxEndeksBuyukAlmaSembol_Leave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxEndeksBuyukAlmaSembol_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxEndeksKucukKapatSembol_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxEndeksKucukKapatSembol_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxEndeksKucukKapatSembol_Leave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxEndeksKucukKapatSembol_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxEndeksBuyukKapatSembol_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxEndeksBuyukKapatSembol_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxEndeksBuyukKapatSembol_Leave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxEndeksBuyukKapatSembol_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonKodGoster__OnClick(object sender, EventArgs e)
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
	static formTaramaRobot()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
