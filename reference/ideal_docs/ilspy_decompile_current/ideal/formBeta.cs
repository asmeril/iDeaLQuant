using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formBeta : Form
{
	private class Record
	{
		public string Symbol;

		public double LastPrice;

		public double PriceEarningValue;

		public double NetProfit;

		public double Capital;

		public double PublicRatio;

		public double MarketValue;

		public double ClosingPrice;

		public double Alfa;

		public double Beta;

		public float Weight;

		public float PuanEtki;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Record()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Record()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class ReturnRecord
	{
		public double Alfa;

		public double Beta;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ReturnRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ReturnRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public static formBeta Reference;

	private cxDataGrid.SortRecord BetaSortParam;

	private DataGridView ActiveGrid;

	private Thread LocalThread;

	private string DisplaySymbol;

	private List<Record> DataList;

	private string SortKey;

	private bool SortAscending;

	private Record DataAverage;

	private IContainer components;

	private TextBox textSearch;

	private DataGridView gridBeta;

	private DateTimePicker datetimeBeta;

	private Panel pnlIndexType;

	private RadioButton radioXU100;

	private RadioButton radioXU30;

	private RadioButton radioXU50;

	private Label label1;

	private MaskedTextBox textDays;

	private RadioButton radioXUTUM;

	private Label label6;

	public ContextMenuStrip menu;

	private ToolStripMenuItem menuExcel;

	private ToolStripSeparator toolStripSeparator5;

	private ToolStripMenuItem menuClose;

	private Timer timerThread;

	private Label labelDisplaySymbol;

	private DataGridViewTextBoxColumn No;

	private DataGridViewTextBoxColumn Senet;

	private DataGridViewTextBoxColumn SonFiyat;

	private DataGridViewTextBoxColumn Kapanis;

	private DataGridViewTextBoxColumn Beta;

	private DataGridViewTextBoxColumn Alfa;

	private DataGridViewTextBoxColumn Weight;

	private DataGridViewTextBoxColumn PuanEtki;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formBeta()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBeta_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBeta_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBeta_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeBeta_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridBeta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridBeta_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridBeta_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridBeta_MouseDown(object sender, MouseEventArgs e)
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
	private void radioXU100_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textDays_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSearch_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerThread_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDateTimeTimerPicker(DateTimePicker dtp, DateTime valuex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowMenu(object sender, Point pointX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ReturnRecord GetSymbolData(string SymbolX, string indextype, int dayCount)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessMenuMessage(string messageX)
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
	static formBeta()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
