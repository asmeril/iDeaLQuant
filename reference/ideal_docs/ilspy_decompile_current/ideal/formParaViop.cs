using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class formParaViop : Form
{
	public static formParaViop Referans;

	public static dynamic IdealParaDll;

	public static bool IdealParaLoaded;

	public static string IdealParaViopStartString;

	private static string ParaUpdateTimestring;

	private static DateTime ParaUpdateDateTime;

	private IContainer components;

	private Timer timerDisplay;

	private Panel panelHeader;

	private Label labelMinimizeWindow;

	private Label labelCloseWindow;

	private Label label4;

	private Label label3;

	private Label label1;

	private TabControl tab;

	private TabPage tabRobot;

	private MyButton mybtnParaUpdateTime;

	private MyButton myButtonConnect;

	private MyButton mybtnBaslat;

	private MyButton mybtnEkle;

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

	private ContextMenuStrip mnuGenel;

	private ToolStripMenuItem mnuMiktarDegistir;

	private ToolStripMenuItem mnuPozisyonDegistir;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripMenuItem mnuSatirSil;

	private ToolStripMenuItem mnuTumSil;

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

	private Timer timer5000;

	private TabPage tabAyar;

	private TextBox textBoxAyarTel;

	private Label label40;

	private CheckBox checkBoxSms;

	private MyButton myButtonKaydetAyarlar;

	private ToolStripMenuItem mnuModSanal;

	private ToolStripMenuItem mnuModGercek;

	private ToolStripSeparator toolStripSeparator1;

	private TabPage tabKonsolide;

	private DataGridView gridKonsolide;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;

	private ToolStripMenuItem mnuModSanalTum;

	private ToolStripMenuItem mnuModGercekTum;

	private CheckBox checkBoxYeniSinyal;

	private CheckBox checkBoxHesapGoster;

	private MyButton mybtnManuelKapat;

	private ToolStripMenuItem mnuAciga;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formParaViop()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formParaViop_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formParaViop_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formParaViop_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formParaViop_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formParaViop_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formParaViop_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formParaViop_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBoxHesapGoster_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBoxYeniSinyal_Click(object sender, EventArgs e)
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
	private void gridRobot_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKonsolide_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
	private void mnuAciga_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mnuMiktarDegistir_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mnuModGercek_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mnuModGercekTum_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mnuModSanal_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mnuModSanalTum_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mnuPozisyonDegistir_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mnuSatirSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mnuTumSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonConnect__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mybtnEkle__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mybtnBaslat__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonIslemExcel__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonIslemleriTemizle__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonKaydetAyarlar__OnClick(object sender, EventArgs e)
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
	private void timerDisplay_Tick(object sender, EventArgs e)
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
	private void timer5000_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ConnectIdealParaViop()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetString(string strx)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string GetStringX(string strx)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillIslem()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillConsolide()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillRobot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ProcessParaYonler(string str)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ProcessParaYonlerX(string strx)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResizeWindow()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void StartIdealPara()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowWindow()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mybtnManuelKapat__OnClick(object sender, EventArgs e)
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
	static formParaViop()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		Referans = null;
		IdealParaLoaded = false;
		IdealParaViopStartString = "";
		ParaUpdateTimestring = "";
		DateTime dateTime = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
		ParaUpdateDateTime = gr7jwURt1t3VJtiGGT.r7iItWL60(ref dateTime, -300.0, gr7jwURt1t3VJtiGGT.G2CDefWNr3);
	}
}
