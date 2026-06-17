using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formHedefPanel : Form
{
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

	private static formHedefPanel Referans;

	private Color FormZeminRenk;

	private Color FormBaslikZeminRenk1;

	private Color FormBaslikZeminRenk2;

	private Color FormBorderRenk;

	private Color FormBaslikYaziRenk;

	private Color FormHeaderButtonPasifRenk;

	private Color FormHeaderButtonAktifRenk;

	private int HeaderHeight;

	private int RightCloseButtonX1;

	private int ButtonWidth;

	private int MinimizeButtonX1;

	private string SortColNameRobot;

	private string FilterSymbol;

	private List<string> AccountNameList;

	public string HedefPortfoyActiveRobot;

	public bool FormLoaded;

	private ButtonTypes MouseMoveButton;

	private cxButton HeaderButtons;

	private IContainer components;

	private TabPage tabAyarlar;

	private TabPage tabIslem;

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

	private TabControl tab;

	private Button btntest;

	private Timer timer200;

	private TabPage tabRobot;

	private MyButton myButtonAktifRobot;

	private Label labelAktifTarama;

	private MyButton myButtonMenu;

	private Panel panelPozisyonDisplay;

	private RadioButton radioButtonPozisyonDisplay01;

	private RadioButton radioButtonPozisyonDisplay00;

	private MyButton myButtonAktifStrateji;

	private Label labelAktifStrateji;

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

	private Timer timer1000;

	private Timer timer100;

	private ContextMenuStrip contextMenuRobotEdit;

	private ToolStripMenuItem robotSilToolStripMenuItem;

	private ContextMenuStrip menuGenel;

	private ToolStripMenuItem menuGenelTumSil;

	private ToolStripMenuItem menuGenelPozSil;

	private ToolStripSeparator toolStripSeparator2;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripMenuItem menuGenelExcel;

	private ToolStripMenuItem menuGenelGrafikDongu;

	private ToolStripMenuItem menuGenelWatchlist;

	private ToolStripSeparator toolStripMenuItem1;

	private ContextMenuStrip contextMenuRobotList;

	private TextBox textSymbol;

	private MyButton myButtonIslemToplamKZ;

	private Label label1;

	private TabPage tabStrateji;

	private TabPage tabHesaplar;

	private ListBox listBoxRobotlar;

	private Panel panelStrateji;

	private Label label8;

	private ComboBox comboBoxStrateji;

	private MyButton myButtonSil;

	private MyButton myButtonKaydet;

	private DataGridView gridHesaplar;

	private Label label2;

	private TextBox textBoxRobotAdi;

	private Label label9;

	private TabControl tabParametre;

	private TabPage Page_SPOT_AL_VIOP_SAT;

	private TabPage Page_IKI_HISSE_POZ_DONDUR;

	private TabPage Page_ENDEKS_SPREAD;

	private TextBox txtViopSymbol_SpotAlViopSat;

	private TextBox txtHisseSymbol_SpotAlViopSat;

	private Panel panelParametre;

	private TextBox txtBaslangicSaati;

	private TextBox txtKademefark;

	private TextBox txtEsik;

	private TextBox txtTemettu;

	private Label lblBaslangicSaati;

	private TextBox txtTakasKomisyon;

	private Label lblKademeFark;

	private TextBox txtViopKomisyon;

	private Label lblEsik;

	private Label lblTemettu;

	private TextBox txtMaxPoz;

	private TextBox txtMaxEmirMiktar;

	private TextBox txtMinEmirMiktar;

	private TextBox txtSpotKomisyon;

	private Label lbltakasKomisyon;

	private Label lblRepo;

	private Label lblMaxPoz;

	private Label lblViopKomisyon;

	private Label lblMaxEmirMiktar;

	private Label label4;

	private Label lblMinEmirMiktar;

	private Label lblSpotKomisyon;

	private Label label5;

	private Label label6;

	private Label lblHisse1Symbol_IHPD;

	private Label label10;

	private TextBox txtHisse2Symbol_IHPD;

	private TextBox txtHisse1Symbol_IHPD;

	private TextBox txtBitisSaati;

	private Label label14;

	private TextBox txtBitisSaati_IHPD;

	private TextBox txtBaslangicSaati_IHPD;

	private Label label15;

	private Label label16;

	private TextBox txtKademeFark_IHPD;

	private Label label13;

	private Label label11;

	private Label label12;

	private TextBox txtUzakVadeSysmbol_ES;

	private TextBox txtYakinVadeSysmbol_ES;

	private TextBox txtBitis2Saati_ES;

	private TextBox txtBitis1Saati_ES;

	private TextBox txtBaslangic2Saati_ES;

	private TextBox txtBaslangic1Saati_ES;

	private Label label20;

	private Label label19;

	private Label label17;

	private Label label18;

	private TextBox txtUzakSpread_ES;

	private TextBox txtMaxPoz_ES;

	private TextBox txtMaxEmirMiktar_ES;

	private TextBox txtMinEmirMiktar_ES;

	private TextBox txtYakinSpread_ES;

	private Label label23;

	private Label label24;

	private Label label25;

	private Label label26;

	private Label label27;

	private Panel panelHesapEdit;

	private Label lblPanelHesapEditClose;

	private Panel panel1;

	private Label lblHesapEditHesapAdi;

	private Label label21;

	private Button btnHesapEditKaydet;

	private TextBox txtHesapEditHesapTanim;

	private Label label22;

	private ComboBox cboxVIOPEmirHesap;

	private ComboBox cboxHisseEmirHesap;

	private ComboBox cboxHisse2EmirHesap_IHPD;

	private ComboBox cboxHisse1EmirHesap_IHPD;

	private ComboBox cboxUzakVadeHesap_ES;

	private ComboBox cboxYakinVadeHesap_ES;

	private GroupBox groupBox2;

	private GroupBox groupBox1;

	private ComboBox cboxVIOPAltHesap;

	private Label label34;

	private Label label35;

	private ComboBox cboxHisseAltHesap;

	private Label label29;

	private Label label28;

	private GroupBox groupBox4;

	private ComboBox cboxHisse2AltHesap_IHPD;

	private Label label36;

	private Label label37;

	private GroupBox groupBox3;

	private ComboBox cboxHisse1AltHesap_IHPD;

	private Label label30;

	private Label label31;

	private GroupBox groupBox6;

	private ComboBox cboxUzakVadeAltHesap_ES;

	private Label label40;

	private Label label41;

	private GroupBox groupBox5;

	private ComboBox cboxYakinVadeAltHesap_ES;

	private Label label38;

	private Label label39;

	private Panel panelAktifPasif;

	private RadioButton radioBoxAktifPasif00;

	private RadioButton radioBoxAktifPasif01;

	private Panel panelGercekSanal;

	private RadioButton radioBoxGercekSanal00;

	private RadioButton radioBoxGercekSanal01;

	private TextBox txtMaxPoz_IHPD;

	private TextBox txtMaxEmirMiktar_IHPD;

	private TextBox txtMinEmirMiktar_IHPD;

	private Label label32;

	private Label label33;

	private Label label42;

	private MyButton myButtonHesaplaraLoginOl;

	private Label labelYakinSpreadCanli;

	private Label label7;

	private Label labelUzakSpreadCanli;

	private Label label43;

	private ToolStripMenuItem PasifeCekMenuItem;

	private ToolStripMenuItem RobotSilMenuItem;

	private ToolStripMenuItem AktifeCekMenuItem;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formHedefPanel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fillComboHesap(ComboBox cboxAccountName, ComboBox cboxAccountNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHedefPanel_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHedefPanel_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHedefPanel_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHedefPanel_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHedefPanel_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHedefPanel_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHedefPanel_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHedefPanel_SizeChanged(object sender, EventArgs e)
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
	private void myButtonMenu__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGenelExcel_Click(object sender, EventArgs e)
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
	private void robotSilToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGenelGrafikDongu_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGenelWatchlist_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btntest_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tab_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbol_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbol_Enter(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbol_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbol_Leave(object sender, EventArgs e)
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
	public static void ShowWindow()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CalculateButtonPositions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillHesaplar()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillIslem()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RobotListUpdate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillRobot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResizeWindow()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PortfolioReceived(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TogglePanelHesapEdit(bool showBool)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHesaplar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHesaplar_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHesaplar_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonKaydet__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetRobotParameter(string robotNameX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowUyari(string textX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBoxStrateji_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lblPanelHesapEditClose_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnHesapEditKaydet_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cboxHisseEmirHesap_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cboxVIOPEmirHesap_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cboxHisse1EmirHesap_IHPD_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cboxHisse2EmirHesap_IHPD_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cboxYakinVadeHesap_ES_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cboxUzakVadeHesap_ES_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void listBoxRobotlar_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lblHisse1Symbol_IHPD_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonSil__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonHesaplaraLoginOl__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RobotGridSubMenuItem_Click(object sender, EventArgs e)
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
	static formHedefPanel()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
