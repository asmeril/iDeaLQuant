using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using dg3ypDAonQcOidMs0w;
using nsoftware.IPWorks;

namespace ideal;

public class formMacro : Form
{
	public static formMacro Reference;

	private string FormCaption;

	private WebClient Downloader;

	private Dictionary<string, string> DownloadDictionary;

	private int ColDebt;

	private int ColEmployment;

	private int ColInflation;

	private int ColTrade;

	private DataGridView ActiveGrid;

	private IContainer components;

	private TabControl tabControl;

	private TabPage tabPage1;

	private TabPage tabPage2;

	private TabPage tabPage3;

	private TabPage tabPage4;

	private Timer timerDownload;

	private Http http1;

	private Button buttonDownload;

	private DataGridView gridEmployment;

	private Chart chartEmployment;

	private Chart chartInflation;

	private DataGridView gridInflation;

	private Chart chartDebt;

	private DataGridView gridDebt;

	private Chart chartTrade;

	private DataGridView gridTrade;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn Column2;

	public ContextMenuStrip menu;

	private ToolStripMenuItem menuExcel;

	private ToolStripSeparator toolStripSeparator5;

	private ToolStripMenuItem menuClose;

	private ToolStripMenuItem menuJPG;

	private ToolStripMenuItem menuBMP;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formMacro()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formMacro_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formMacro_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonDownload_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridEmployment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridDebt_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridEmployment_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridEmployment_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridInflation_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridTrade_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void http1_OnTransfer(object sender, HttpTransferEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuBMP_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuClose_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuExcel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuJPG_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerDownload_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DownloaderProgressChanged(object sender, DownloadProgressChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DownloaderCompleted(object sender, AsyncCompletedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayDebt()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayDebtChart()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayEmployment()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayEmploymentChart()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayInflation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayInflationChart()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayTrade()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayTradeChart()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowMenu(object sender, Point pointX)
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
	static formMacro()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
