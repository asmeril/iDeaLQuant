using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formYatayBotChart : Form
{
	public static formYatayBotChart Referans;

	private YatayBotClass YatayBotItem;

	private List<cxBar> DataList;

	private Color ChartBackColor;

	private Color PanelChartBackColor;

	private Color ChartBorderColor;

	private Color ChartBarColor;

	private Color CharLineHighColor;

	private Color CharLineLowColor;

	private Color ChartStopLevelColor;

	private Color ChartLastPriceLevelColor;

	private int ChartLastPriceLevelLineWidth;

	public string ActiveSymbol;

	private bool RedrawBool;

	private int LastPriceTime;

	private string Periyot;

	private decimal ScalePercent;

	private decimal Max1;

	private decimal Min1;

	private decimal Inc1;

	private IContainer components;

	private Panel panelChart0;

	private Panel panelChart1;

	private Timer timerRefresh;

	private Label labelHAsk;

	private Label labelSLot;

	private Label labelHLastPrice;

	private Label labelALot;

	private Label label2;

	private Label labelSOrt;

	private Label label1;

	private Label labelAOrt;

	private Label label3;

	private Label labelKZ;

	private Label label5;

	private Label labelPozisyon;

	private MyButton myButtonAyar;

	private ContextMenuStrip menu;

	private ToolStripMenuItem menuOzellikler;

	private ToolStripSeparator toolStripSeparator8;

	private ToolStripMenuItem menuBaslatDurdur;

	private Label label4;

	private MyButton myButtonPeriyot120;

	private MyButton myButtonPeriyot30;

	private MyButton myButtonPeriyotTum;

	private MyButton myButtonPeriyot60;

	private Panel panelHeader;

	private Label label7;

	private Label labelSembol;

	private Label labelMinimizeWindow;

	private Label labelCloseWindow;

	private Label labelFrkYuzde;

	private Label label8;

	private TextBox textBoxTime;

	private Label labelStatus;

	private ToolStripMenuItem menuGrafikRenkPatern;

	private ToolStripMenuItem menuGrafikRenkPaternSiyah;

	private ToolStripMenuItem menuGrafikRenkPaternBeyaz;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formYatayBotChart(YatayBotClass YatayBotX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formYatayBotChart_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formYatayBotChart_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formYatayBotChart_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formYatayBotChart_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formYatayBotChart_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formYatayBotChart_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formYatayBotChart_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formYatayBotChart_MouseWheel(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelMinimizeWindow_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelCloseWindow_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuOzellikler_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuBaslatDurdur_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGrafikRenkPaternSiyah_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGrafikRenkPaternBeyaz_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonPeriyot30__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonPeriyot60__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonPeriyot120__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonPeriyotTum__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonAyar__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart0_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart0_DoubleClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart0_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart0_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart0_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart1_Paint(object sender, PaintEventArgs e)
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
	private void timerRefresh_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BasicDataReceived(string symbolX, string updatetypeX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private decimal CalculateIncrement(decimal highval, decimal lowval, bool pricebool)
	{
		return (decimal)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReadData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResizeWindow()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetChartColor()
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
	static formYatayBotChart()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
