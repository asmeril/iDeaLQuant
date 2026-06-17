using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formSira : Form
{
	public static formSira Reference;

	private string Symbol;

	private float Price;

	private string Direction;

	private string SiraKey;

	private int OrderCount;

	private List<cxSiraOrderRec> OrderList;

	private List<cxSiraWaitingRec> SymbolList;

	private List<cxSiraWaitingRec> SiraList;

	private IContainer components;

	private Panel panelStatus;

	private RadioButton radioStatus2;

	private RadioButton radioStatus1;

	private RadioButton radioStatus0;

	private DataGridView gridSira;

	private DataGridViewTextBoxColumn Column1;

	private Panel panelDirection;

	private RadioButton radioDirection2;

	private RadioButton radioDirection1;

	private RadioButton radioDirection0;

	private ContextMenuStrip menu;

	private ToolStripMenuItem menuDisplayWaiting;

	private Timer timerRefresh;

	private ToolStripMenuItem menuDeleteRealized;

	private ToolStripMenuItem menuDeleteAll;

	private DataGridView gridDepth;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private ToolStripMenuItem menuDeleteWaiting;

	private DataGridView gridOrder;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripMenuItem menuTopmost;

	private TextBox textSymbol;

	private Button buttonWarning;

	private Button buttonMenu;

	private Label label1;

	private Panel panelSymbol;

	private RadioButton radioSymbol2;

	private RadioButton radioSymbol1;

	private RadioButton radioSymbol0;

	private ToolStripMenuItem menuDisplayAll;

	private ToolStripMenuItem menuDisplayRealized;

	private ToolStripMenuItem menuDelete;

	private ToolStripSeparator toolStripSeparator2;

	private Label labelMenu;

	private Label labelWarning;

	private Label labelSizeRight;

	private Label labelSizeLeft;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formSira()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSira_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSira_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSira_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonMenu_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonWarning_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridDepth_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridDepth_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridOrder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridSira_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridSira_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridSira_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridSira_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelMenu_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelSizeLeft_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelSizeRight_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelWarning_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuDelete_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuDeleteAll_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuDeleteRealized_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuDeleteWaiting_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuDisplayAll_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuDisplayRealized_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuDisplayWaiting_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTopmost_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioDirection_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioStatus_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioSymbol_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbol_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbol_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbol_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerRefresh_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayDepth()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayOrder()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplaySira()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DragDropMethod(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DragEnterMethod(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FilterSira()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrepareKey()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSymbol(string symbolX)
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
	static formSira()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
