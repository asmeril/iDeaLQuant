using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formInterbankTable : FormControl
{
	private Font FontData;

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

	private Color CurrentLineBackColor;

	private Color CurrentLineForeColor;

	private Color GridlineColor;

	private cxPage.Interbank PageParams;

	private int InitialLeft;

	private int InitialTop;

	private int TitleHeight;

	private int RowHeight;

	private cxGrid Grid;

	private List<cxBasic> BidList;

	private List<cxBasic> AskList;

	private bool FormLoaded;

	private cxFont.Margin FontMargin;

	private Font FontHeader;

	private Font FontArrow;

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

	private Timer timerUpdate;

	private Panel panelBasic;

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

	private ToolStripSeparator toolStripSeparator5;

	private ToolStripMenuItem menuClose;

	private ToolStripMenuItem toolStripMenuItem5;

	private ToolStripMenuItem toolStripMenuItem4;

	private ToolStripMenuItem toolStripMenuItem3;

	private ToolStripMenuItem toolStripMenuItem2;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripMenuItem toolStripMenuItem1;

	private ToolStripMenuItem menuMainPatternDefault;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formInterbankTable(int leftX, int topX, cxPage.Interbank pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formInterbankTable_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formInterbankTable_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formInterbankTable_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formInterbankTable_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formInterbankTable_SizeChanged(object sender, EventArgs e)
	{
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
	private void panelBasic_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelBasic_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelBasic_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerUpdate_Tick(object sender, EventArgs e)
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
	private void SetPageParams(cxPage.Interbank pageparamsX)
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
	static formInterbankTable()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
