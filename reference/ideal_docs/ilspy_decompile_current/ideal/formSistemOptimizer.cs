using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class formSistemOptimizer : Form
{
	private cxSistem SistemItem;

	public static formSistemOptimizer Reference;

	public static Point FormLocation;

	public static Size FormSize;

	private string Symbol;

	private string Period;

	private List<OptimizerClass> OptimizerList;

	private string SortKey;

	private bool SortAscending;

	private Thread ThreadProcess;

	private int ThreadStatus;

	private Color GridlineColor;

	private Color ChartForeColor;

	private Color UpColor;

	private Color DownColor;

	private Color LineColor;

	private Color PanelBackColor;

	private Color PanelForeColor;

	private int FillOpacity;

	private IContainer components;

	private DataGridView gridData;

	private ComboBox comboSistemName;

	public TextBox textSymbolSearch;

	private Label label1;

	private Label label2;

	private Label label3;

	private ComboBox comboPeriod;

	private Label label4;

	public TextBox textBarCount;

	private CheckBox checkShortSellAllowed;

	private Button buttonExcel;

	private DataGridViewTextBoxColumn ColTradeNo;

	private DataGridViewTextBoxColumn ColTradeDirection;

	private DataGridViewTextBoxColumn ColTradeLot;

	private DataGridViewTextBoxColumn ColTradeBuyDate;

	private DataGridViewTextBoxColumn ColTradeBuyPrice;

	private DataGridViewTextBoxColumn ColTradeSellDate;

	private DataGridViewTextBoxColumn ColTradeSellPrice;

	private DataGridViewTextBoxColumn ColTradeProfit;

	private DataGridViewTextBoxColumn ColTradeSellCash;

	private Button buttonFormul;

	private Button buttonHesapla;

	private Timer timerDisplay;

	private CheckBox checkHizliMod;

	private Panel panelChart0;

	private Timer timerChart;

	private Label label5;

	private Label label8;

	private TextBox textBaslangic;

	private TextBox textBitis;

	private CheckBox checkMaxDD;

	private Panel panelDisplay;

	private Label labelSistemName;

	private Button buttonClearResult;

	private Button buttonShowResult;

	private Label label7;

	private Label label6;

	private Label labelMaxKar;

	private Label labelKarZarar;

	private Label labelAciklama;

	private Button buttonStop;

	private Label label10;

	private Label labelSymbolName;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formSistemOptimizer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSistemOptimizer_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSistemOptimizer_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSistemOptimizer_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonClearResult_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonExcel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonFormul_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonHesapla_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonShowResult_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkShortSellAllowed_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonStop_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboSistemName_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboPeriod_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridData_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart0_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart0_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart0_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart0_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBarCount_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbolSearch_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbolSearch_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbolSearch_Leave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbolSearch_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerChart_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerDisplay_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private double CalculateIncrement(double highval, double lowval)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeSystem(string symbolX, string periodX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string ConvertDateToString(DateTime datetimeX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CalculateData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayData()
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
	static formSistemOptimizer()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		Reference = null;
		FormLocation = new Point(100, 100);
		FormSize = new Size(1300, 500);
	}
}
