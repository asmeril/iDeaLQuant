using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formSistemCompare : Form
{
	private class TradeClass
	{
		public string Direction;

		public float Lot1;

		public float Lot2;

		public DateTime BuyDate;

		public float BuyPrice;

		public DateTime SellDate;

		public float SellPrice;

		public float Profit1;

		public float Profit2;

		public float Cash;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TradeClass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TradeClass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private class ProfitClass
	{
		public string SistemName;

		public int TradeCount;

		public int WinnerCount;

		public int LoserCount;

		public float Net;

		public float Percent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ProfitClass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ProfitClass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private string Symbol;

	private string Period;

	private string InfoStatus;

	private string SortKey;

	private bool SortAscending;

	private List<ProfitClass> ProfitList;

	private Thread ThreadProcess;

	private IContainer components;

	private DataGridView gridSystems;

	private ComboBox comboPeriod;

	private Timer timerRefresh;

	private Label label1;

	public TextBox textSymbolSearch;

	public TextBox textBarCount;

	private Label label4;

	private Label label3;

	private CheckedListBox listSystems;

	private Button buttonStart;

	private Button buttonSelectAll;

	private Button buttonSelectNone;

	private Label labelInfoStatus;

	private Button buttonExcel;

	private DataGridViewTextBoxColumn ColNo;

	private DataGridViewTextBoxColumn ColSistem;

	private DataGridViewTextBoxColumn ColTradeCount;

	private DataGridViewTextBoxColumn ColWinnerCount;

	private DataGridViewTextBoxColumn ColLoserCount;

	private DataGridViewTextBoxColumn ColPercent;

	private DataGridViewTextBoxColumn CoNet;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formSistemCompare()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSistemCompare_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSistemCompare_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonExcel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonSelectAll_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonSelectNone_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonStart_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboPeriod_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridSystems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridSystems_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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
	private void timerRefresh_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string ConvertDateToString(DateTime datetimeX)
	{
		return null;
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
	private void ProcessData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeParameters(string symbolX, string periodX)
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
	static formSistemCompare()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
