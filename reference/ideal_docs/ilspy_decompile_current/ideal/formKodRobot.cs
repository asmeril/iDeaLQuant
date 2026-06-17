using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formKodRobot : Form
{
	public static formKodRobot Referans;

	public Color RunningColor;

	public Color NotRunningColor;

	private IContainer components;

	private TabControl tabControl1;

	private TabPage tabPageRobot;

	private TabPage tabPageAyarlar;

	private MyButton myButtonKaydetAyarlar;

	private Panel panelRobotListe;

	private Panel panelRobotInfo;

	private MyButton myButtonRobotEkle;

	private MyButton myButtonRobotBaslat;

	private DataGridView gridRobot;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

	private ContextMenuStrip menuRobot;

	private ToolStripMenuItem menuRobotOzellikler;

	private ToolStripSeparator toolStripSeparator2;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripMenuItem menuRobotTumSil;

	private ToolStripMenuItem menuRobotSanalSil;

	private ToolStripMenuItem menuRobotSatirSil;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripMenuItem menuRobotKapat;

	private ToolStripMenuItem menuRobotTumGercek;

	private ToolStripMenuItem menuRobotTumSanal;

	private ToolStripMenuItem menuRobotTumPozisyonSifir;

	private TabPage tabPageIslemler;

	private Panel panelIslemlerTur;

	private RadioButton radioButtonIslemlerTur02;

	private RadioButton radioButtonIslemlerTur00;

	private RadioButton radioButtonIslemlerTur01;

	private Panel panelIslemlerListe;

	private Label label28;

	private CheckBox checkBoxRobotWeekend;

	private TextBox textBoxRobotTime1;

	private TextBox textBoxRobotTime2;

	private Timer timer500;

	private MyButton myButtonIslemlerListeyiTemizle;

	private MyButton myButtonIslemlerExcel;

	private TextBox textBoxAyarTel;

	private Label label40;

	private CheckBox checkBoxSms;

	private Panel panelHeader;

	private Label labelHeader;

	private Label labelMinimizeWindow;

	private Label labelCloseWindow;

	private MyButton myButtonKz;

	private DataGridView gridIslemler;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private MyButton myButtonExcel;

	private MyButton myButtonYeniSinyalSaat;

	private MyButton myButtonYeniSinyalTarih;

	private CheckBox checkBoxYeniSinyal;

	private MyButton myButtonRunningTime;

	private MyButton myButtonRunningSure;

	private Label labelKz;

	private Label label1;

	private MyButton myButtonGunKz;

	private ToolStripMenuItem menuRobotSatirReset;

	private ToolStripMenuItem menuRobotTumPasif;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formKodRobot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formKodRobot_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formKodRobot_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formKodRobot_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formKodRobot_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formKodRobot_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formKodRobot_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formKodRobot_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formKodRobot_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBoxYeniSinyal_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridIslemler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
	private void labelCloseWindow_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelMinimizeWindow_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuExcel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonExcel__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobotOzellikler_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobotTumSil_Click(object sender, EventArgs e)
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
	private void menuRobotSatirReset_Click(object sender, EventArgs e)
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
	private void menuRobotTumPasif_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobotTumPozisyonSifir_Click(object sender, EventArgs e)
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
	private void myButtonRobotBaslat__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonRobotEkle__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonYeniSinyalTarih__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonYeniSinyalSaat__OnClick(object sender, EventArgs e)
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
	private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetColors()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timer500_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillIslemlerGrid()
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
	public static void ShowForm()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddRobot(string sistemname, string periyot, string sembol)
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
	static formKodRobot()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
