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

public class formIndicatorValues : Form
{
	private class ValueClass
	{
		public string Symbol;

		public List<string> IndicatorValue;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ValueClass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ValueClass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public static formIndicatorValues Reference;

	public static Point LocationThis;

	public static Size SizeThis;

	public static string SymbolFilter;

	private string InfoStatus;

	private string Period;

	private bool SortAscending;

	private int SortCol;

	private List<cxIndicator> IndicatorList;

	private List<ValueClass> DataList;

	private Thread ThreadProcess;

	private IContainer components;

	private DataGridView gridData;

	private ComboBox comboPeriod;

	private Button buttonSymbols;

	private Timer timerRefresh;

	private Label labelInfoStatus;

	private TextBox textSearch;

	private Button buttonRefresh;

	private Button buttonExcel;

	private DataGridViewTextBoxColumn ColNo;

	private DataGridViewTextBoxColumn ColSymbol;

	private DataGridViewTextBoxColumn ColDirection;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn Column2;

	private DataGridViewTextBoxColumn Column3;

	private DataGridViewTextBoxColumn Column4;

	private DataGridViewTextBoxColumn Column5;

	private DataGridViewTextBoxColumn Column6;

	private DataGridViewTextBoxColumn Column7;

	private DataGridViewTextBoxColumn Column8;

	private DataGridViewTextBoxColumn Column9;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formIndicatorValues()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formIndicatorValues_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formIndicatorValues_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonExcel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonRefresh_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonSymbols_Click(object sender, EventArgs e)
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
	private void textSearch_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerRefresh_Tick(object sender, EventArgs e)
	{
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
	private void MessageReceived(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessMenuMessage(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RefreshData(string periodX, List<cxIndicator> indicatorlistX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridData_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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
	static formIndicatorValues()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		LocationThis = new Point(100, 50);
		SizeThis = new Size(912, 365);
		SymbolFilter = "XU-30";
	}
}
