using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formBalanceSummary : FormControl
{
	private class Record
	{
		public string Description;

		public string FieldValue;

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

	private Font FontData;

	public string ActiveSymbol;

	private int LineSpace;

	private bool GridlineVisible;

	private Color TitleBackColor1;

	private Color TitleBackColor2;

	private Color TitleForeColor;

	private Color TitleBorderColor;

	private Color GridBackColor;

	private Color GridForeColor;

	private Color NormalColor;

	private Color HighColor;

	private Color LowColor;

	private Color CurrentLineBackColor1;

	private Color CurrentLineBackColor2;

	private Color CurrentLineBorderColor;

	private Color GridlineColor;

	private Color VbarBackColor1;

	private Color VbarBackColor2;

	private Color VbarForeColor;

	private Color VbarBorderColor;

	private Color VbarButtonBackColor1;

	private Color VbarButtonBackColor2;

	private cxPage.Step PageParams;

	private string InitialSymbol;

	private int InitialLeft;

	private int InitialTop;

	private int TitleHeight;

	private int RowHeight;

	private bool RefreshNeeded;

	private List<Record> DataList;

	private cxGrid Grid;

	private int[] CharWidth;

	private bool FormLoaded;

	private cxFont.Margin FontMargin;

	private Font FontHeader;

	private cxButton HeaderButtons;

	private Pen Pen1;

	private Pen Pen2;

	private SolidBrush Brush1;

	private SolidBrush BrushBack;

	private SolidBrush BrushFore;

	private Rectangle Rect1;

	private Rectangle Rect2;

	private string Str1;

	private Point Point1;

	private IContainer components;

	private Timer timerRefresh;

	private Panel panelGrid;

	public ContextMenuStrip menu;

	private ToolStripMenuItem menuProperty;

	private ToolStripMenuItem menuPropertyMemCopy;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripMenuItem menuPropertyColor;

	private ToolStripMenuItem menuPropertyFont;

	private ToolStripMenuItem menuPropertyGridlines;

	private ToolStripMenuItem menuPropertyLinespace;

	private ToolStripMenuItem menuPattern;

	private ToolStripMenuItem menuMainPatternSave;

	private ToolStripMenuItem menuMainPatternSaveas;

	public ToolStripComboBox menuMainPatternChange;

	private ToolStripMenuItem menuMainPatternDelete;

	private ToolStripMenuItem menuMainPatternDeleteAll;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripMenuItem menuClose;

	private TextBox textSymbolSearch;

	private ToolStripMenuItem menuGrup;

	private ToolStripMenuItem menuMainPatternDefault;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formBalanceSummary(int leftX, int topX, string symbolX, cxPage.Step pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBalanceSummary_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBalanceSummary_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBalanceSummary_Deactivate(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBalanceSummary_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBalanceSummary_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBalanceSummary_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBalanceSummary_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBalanceSummary_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuClose_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGrup_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPatternChange_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainPatternDefault_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPatternDelete_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPatternDeleteAll_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPatternSave_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPatternSaveas_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPropertyColor_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPropertyFont_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPropertyGridlines_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPropertyLinespace_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPropertyMemCopy_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelGrid_DragDrop(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelGrid_DragEnter(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelGrid_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelGrid_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelGrid_Paint(object sender, PaintEventArgs e)
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
	private void timerRefresh_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BasicDataReceived(string symbolX, string updatetypeX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MessageReceived(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InvalidateAll()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrepareTables()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPageParams(cxPage.Step pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMainToolbarSymbol()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowMenu(object sender, Point pointX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowMenuCol(object sender, Point pointX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeColors(cxColorEditor coloritemX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] ConvertPageToByteArray()
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
	static formBalanceSummary()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
