using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formTrendAlarmListesi : Form
{
	public static formTrendAlarmListesi Referance;

	private Rectangle DragDropRect;

	private int MouseDownRowNo;

	private Dictionary<long, bool> UsedInZincirDictionary;

	private IContainer components;

	private Panel panel1;

	private Label label1;

	private Label label6;

	private Panel panelListe;

	private DataGridView gridAlarm;

	private DataGridViewTextBoxColumn Column1;

	private Timer timerFillGrid;

	private Label labelRowNo;

	private Timer timer100;

	private ContextMenuStrip menu;

	private ToolStripMenuItem menuOzellikler;

	private ToolStripMenuItem menuTumAktif;

	private ToolStripMenuItem menuTumPasif;

	private ToolStripMenuItem menuTumSil;

	private ToolStripMenuItem menuPasifSil;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripMenuItem menuKapat;

	private ToolStripSeparator toolStripSeparator2;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripMenuItem menuGerceklesenleriSil;

	private ToolStripMenuItem menuGrafik;

	private MyButton myButtonBaslat;

	private ToolStripMenuItem menuSatirSil;

	private ToolStripMenuItem menuZincirBagla;

	private ToolStripMenuItem menuZincirleriKaldir;

	private ToolStripMenuItem menuTumZincirleriKaldir;

	private ToolStripSeparator toolStripSeparator4;

	private ToolStripMenuItem MenuExcel;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formTrendAlarmListesi()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTrendAlarmListesi_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTrendAlarmListesi_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTrendAlarmListesi_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTrendAlarmListesi_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridAlarm_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridAlarm_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridAlarm_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridAlarm_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridAlarm_DragDrop(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridAlarm_DragOver(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridAlarm_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridAlarm_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGerceklesenleriSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGrafik_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuKapat_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuOzellikler_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPasifSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSatirSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSatirSilTrendKalsin_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTumAktif_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTumPasif_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTumSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuZincirBagla_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuZincirleriKaldir_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTumZincirleriKaldir_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MenuExcel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonBaslat__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerFillGrid_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timer100_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillRow(int rownoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillGrid()
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
	static formTrendAlarmListesi()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
