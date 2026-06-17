using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formSistemMulti : Form
{
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

	private int DisplayedBarNo;

	private List<ProfitClass> ProfitList;

	private IContainer components;

	private ComboBox comboPeriod;

	public TextBox textSymbolSearch;

	public TextBox textBarCount;

	private DataGridView gridSistem;

	private Panel panelSistemSelect;

	private ListBox listSistemSelect;

	private Button buttonSistemSelectClose;

	private DataGridViewTextBoxColumn ColLineNo;

	private DataGridViewTextBoxColumn ColLineName;

	private DataGridViewTextBoxColumn ColLineActive;

	private DataGridViewTextBoxColumn ColLineColor;

	private DataGridViewTextBoxColumn ColLinePanel;

	private Button buttonSistemAdd;

	private Button buttonSistemDelete;

	private Button buttonCalculate;

	private ChartControl Chart;

	private Timer timerRefresh;

	private Button buttonGridShow;

	private Button buttonGridHide;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formSistemMulti()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSistemMulti_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSistemMulti_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonCalculate_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonGridHide_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonGridShow_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonSistemAdd_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonSistemDelete_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonSistemSelectClose_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboPeriod_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridSistem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridSistem_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridSistem_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridSistem_CurrentCellChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void listSistemSelect_MouseDoubleClick(object sender, MouseEventArgs e)
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
	private void InitSistemGrid()
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
	static formSistemMulti()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
