using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formAlanSatanChart : FormControl
{
	public static formAlanSatanChart Reference;

	private string Sembol;

	private List<IslemStruct1> IslemList;

	private List<decimal> PozList;

	private List<AlanSatanClass> AlanSatanList;

	private bool SortAscendingBool;

	private string SortColName;

	private string KurumKod;

	private string DataTip;

	private bool RefreshNeededBool;

	private int Timer4;

	private bool BaslangicClickStartBool;

	private bool BaslangicBool;

	private int BaslangicHour;

	private int BaslangicMinute;

	private int BaslangicSecond;

	private bool BitisClickStartBool;

	private bool BitisBool;

	private int BitisHour;

	private int BitisMinute;

	private int BitisSecond;

	private Color ChartBackColor;

	private Color GridlineColor;

	private Color ChartForeColor;

	private Color LineColor;

	private Color PozColor;

	private Color UpColor;

	private Color DownColor;

	private Color PanelBackColor;

	private Color PanelForeColor;

	private IContainer components;

	private DataGridView gridData;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

	private Panel panelChart0;

	private Panel panelChart1;

	private Panel panelButtons;

	private MyButton myButtonTum;

	private MyButton myButtonEnd;

	private MyButton myButtonStart;

	private Timer timer500;

	private Label labelDataTip;

	private Label labelKurum;

	private Label label1;

	private TextBox textBoxSearch;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formAlanSatanChart()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formAlanSatanChart_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formAlanSatanChart_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formAlanSatanChart_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formAlanSatanChart_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formAlanSatanChart_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formAlanSatanChart_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridData_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonStart__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonEnd__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonTum__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart0_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart0_Paint(object sender, PaintEventArgs e)
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
	private void textBoxSearch_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timer500_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BasicDataReceived(string symbolX, string updatetypeX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private double CalculateIncrement(double highval, double lowval, bool pricebool)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DisplayData(string sembol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<IslemStruct1> GetList()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillGrid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReadPozisyon()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResizeWindow()
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
	static formAlanSatanChart()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
