using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formFixPortfoy : Form
{
	public static formFixPortfoy Reference;

	private DateTime Sure500;

	private DateTime Sure1000;

	private string AktifRumuz;

	private volatile bool EmirRefreshBool;

	private bool RequestNeededBool;

	private int MouseDownCol;

	private List<FixHisseKzRec> HisseKzList;

	private double BotLiraSum;

	private double SoldLiraSum;

	private double NetLiraSum;

	private double ProfitSum;

	private IContainer components;

	private TabControl tabControl1;

	private TabPage tabPageHisse;

	private Timer timerGenel;

	private TabPage tabPageHesap;

	private DataGridView gridHesap;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private Button buttonHesapEkle;

	private DataGridView gridRumuz;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	private ContextMenuStrip menuHesap;

	private ToolStripMenuItem menuHesapSatirSil;

	private ToolStripMenuItem menuHesapTumunuSil;

	private MyButton myButtonOmsConnect;

	private TabPage tabPageViop;

	private TabControl tabControlHisse;

	private TabPage tabPageHisseBekleyen;

	private TabPage tabPageHisseGerceklesen;

	private TabPage tabPageHisseIptal;

	private TabPage tabPageHisseKz;

	private DataGridView gridHisseBekleyen;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;

	private DataGridView gridHisseGerceklesen;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

	private DataGridView gridHisseIptal;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private TabControl tabControlViop;

	private TabPage tabPageViopBekleyen;

	private DataGridView gridViopBekleyen;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

	private TabPage tabPageViopGerceklesen;

	private DataGridView gridViopGerceklesen;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

	private TabPage tabPageViopIptal;

	private DataGridView gridViopIptal;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

	private TabPage tabPage4;

	private DataGridView gridHisseKz;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

	private TabPage tabPageHissePozisyon;

	private DataGridView gridHissePozisyon;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;

	private ComboBox comboBoxRumuz;

	private MyButton myButtonLogin;

	private MyButton myButtonLogout;

	private CheckBox checkBoxRumuz;

	private Label labelHisseOverall;

	private MyButton myButtonHisseOverall;

	private Label labelHisseIslemLimit;

	private MyButton myButtonHisseIslemLimit;

	private Panel panelHeader;

	private Label labelHeader;

	private Label labelMinimizeWindow;

	private Label labelCloseWindow;

	private TabPage tabPageHisseOzet;

	private DataGridView gridHisseOzet;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;

	private TabPage tabPageViopPozisyon;

	private TabPage tabPageViopOzet;

	private Label labelViopTeminat2;

	private MyButton myButtonViopTeminat2;

	private Label labelViopTeminat1;

	private MyButton myButtonViopTeminat1;

	private DataGridView gridViopPozisyon;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;

	private DataGridView gridViopOzet;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;

	private TabPage tabPageAyar;

	private TextBox textBoxFixOrderPort;

	private Label label12;

	private TextBox textBoxFixOrderPassword;

	private Label label14;

	private TextBox textBoxFixOrderUser;

	private Label label1;

	private TextBox textBoxFixOrderIp;

	private Label labelFixOrderMsg;

	private Label label3;

	private MyButton myButtonTemaSiyah;

	private MyButton myButtonTemaBeyaz;

	private Label label13;

	private NumericUpDown numericRowHeight;

	private MyButton myButtonDefault;

	private MyButton myButtonFont;

	private MyButton myButtonRenkler;

	private MyButton myButtonAyarKaydet;

	private MyButton myButtonBekleyenIslemIptal;

	private MyButton myButtonEmirGonder;

	private Label label2;

	private DataGridView gridFixRouterHesap;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;

	private Label label4;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formFixPortfoy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formFixPortfoy_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixRouterTradeReceived(FixOrderData fixOrderData)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formFixPortfoy_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formFixPortfoy_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formFixPortfoy_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formFixPortfoy_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formFixPortfoy_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formFixPortfoy_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formFixPortfoy_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setTabPage(string tabPageName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonHesapEkle_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBoxRumuz_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBoxRumuz_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHissePozisyon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHissePozisyon_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHissePozisyon_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHissePozisyon_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisseOzet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisseOzet_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisseOzet_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisseOzet_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisseBekleyen_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisseBekleyen_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisseBekleyen_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisseBekleyen_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisseGerceklesen_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisseGerceklesen_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisseGerceklesen_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisseGerceklesen_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisseIptal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisseIptal_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisseIptal_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisseIptal_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisseKz_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisseKz_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisseKz_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisseKz_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHesap_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHesap_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRumuz_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRumuz_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridViopPozisyon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridViopPozisyon_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridViopPozisyon_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridViopPozisyon_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridViopOzet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridViopOzet_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridViopOzet_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridViopOzet_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridViopBekleyen_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridViopBekleyen_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridViopBekleyen_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridViopBekleyen_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridViopGerceklesen_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridViopGerceklesen_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridViopGerceklesen_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridViopGerceklesen_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridViopIptal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridViopIptal_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridViopIptal_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridViopIptal_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
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
	private void menuHesapSatirSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuHesapTumunuSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonAyarKaydet_OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonFont__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonDefault__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonTemaBeyaz__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonTemaSiyah__OnClick(object sender, EventArgs e)
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
	private void myButtonOmsConnect__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonRenkler__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelHeader_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelHeader_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tabControl1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tabControlHisse_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tabControlHisse_DrawItem(object sender, DrawItemEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tabControlHisse_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tabControlViop_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tabControlViop_DrawItem(object sender, DrawItemEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tabControlViop_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerGenel_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TcpFixRouterStatusUI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CalculateHisseKz()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeColors(cxColorEditor coloritemX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillHissePozisyon()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillHisseOzet()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillHisseBekleyen()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillHisseGerceklesen()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillHisseIptal()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillHisseKz()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillViopPozisyon()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillViopOzet()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillViopBekleyen()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillViopGerceklesen()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillViopIptal()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillAyar()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillHesap()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillFixRouterHesap()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillLabels()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillRumuzGrid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillRumuzCombo()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HesapLogout()
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
	private void RequestData(int milisecond)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetColors()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonBekleyenIslemIptal__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonEmirGonder__OnClick(object sender, EventArgs e)
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
	static formFixPortfoy()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
