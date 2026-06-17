using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formSistemPosition : Form
{
	private class PositionClass
	{
		public string Symbol;

		public string Direction;

		public DateTime Date;

		public float TradePrice;

		public float LastPrice;

		public float Change;

		public float Percent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PositionClass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static PositionClass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private string SistemName;

	private string Period;

	private string InfoStatus;

	private List<PositionClass> PositionList;

	private Thread ThreadProcess;

	private string SortKey;

	private bool SortAscending;

	private IContainer components;

	private DataGridView gridPosition;

	private ComboBox comboSistemName;

	private ComboBox comboPeriod;

	private Panel panelDate;

	private RadioButton radioDate1;

	private RadioButton radioDate0;

	private RadioButton radioDate2;

	private Timer timerRefresh;

	private Label labelInfoStatus;

	private DataGridViewTextBoxColumn ColNo;

	private DataGridViewTextBoxColumn ColSymbol;

	private DataGridViewTextBoxColumn ColDirection;

	private DataGridViewTextBoxColumn ColDate;

	private DataGridViewTextBoxColumn ColTradePrice;

	private DataGridViewTextBoxColumn ColLastPrice;

	private DataGridViewTextBoxColumn ColChange;

	private DataGridViewTextBoxColumn ColPercent;

	private RadioButton radioDate3;

	private Button buttonExcel;

	private Button buttonSymbols;

	private RadioButton radioButton1;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formSistemPosition()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSistemPosition_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSistemPosition_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonExcel_Click(object sender, EventArgs e)
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
	private void comboSistemName_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridPosition_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridPosition_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridPosition_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioDate_Click(object sender, EventArgs e)
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
	private void MessageReceived(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetSistem()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeSistem(string sistemnameX, string periodX)
	{
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
	static formSistemPosition()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
