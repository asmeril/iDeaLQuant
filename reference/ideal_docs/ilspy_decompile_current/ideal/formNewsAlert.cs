using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formNewsAlert : Form
{
	public static formNewsAlert Reference;

	private Font FontData;

	private int LineSpace;

	private bool GridlineVisible;

	private Color KapColor;

	private Color TitleBackColor1;

	private Color TitleBackColor2;

	private Color TitleForeColor;

	private Color TitleBorderColor;

	private Color GridBackColor;

	private Color GridForeColor;

	private Color CurrentLineBackColor;

	private Color CurrentLineForeColor;

	private Color GridlineColor;

	private Color FlashBackColor;

	private Color FlashForeColor;

	private Color FilterColor;

	private Color SelectColor;

	private Color VbarBackColor1;

	private Color VbarBackColor2;

	private Color VbarForeColor;

	private Color VbarBorderColor;

	private Color VbarButtonBackColor1;

	private Color VbarButtonBackColor2;

	private Stopwatch CheckTime;

	private bool VbarVisible;

	private int TitleHeight;

	private int RowHeight;

	private List<cxNews> DataList;

	private cxGrid Grid;

	private string[] SearchArray;

	private string[] SymbolArray;

	private cxFont.Margin FontMargin;

	private Font FontHeader;

	private Pen Pen1;

	private Pen Pen2;

	private SolidBrush Brush1;

	private SolidBrush BrushBack;

	private SolidBrush BrushFore;

	private Rectangle Rect1;

	private Rectangle Rect2;

	private string Str1;

	private Point Point1;

	private bool MovingObject;

	private Point MoveCursor;

	private Rectangle MoveRect;

	private float ScrollMidLength;

	private float ScrollSideLength;

	private int ScrollDirection;

	private long ScrollTime;

	private Rectangle VbarMidRect;

	private Rectangle VbarBottomRect;

	private Rectangle VbarTopRect;

	private IContainer components;

	private Panel panelGrid;

	private Panel panelVbar;

	private Timer timerScroll;

	private ContextMenuStrip menu;

	private ToolStripMenuItem menuClear;

	private ToolStripMenuItem menuDefinitions;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripMenuItem menuClose;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formNewsAlert()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formNewsAlert_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formNewsAlert_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formNewsAlert_MouseWheel(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formNewsAlert_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuClear_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuClose_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuDefinitions_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelGrid_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelGrid_MouseDoubleClick(object sender, MouseEventArgs e)
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
	private void panelVbar_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelVbar_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelVbar_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelVbar_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerScroll_Tick(object sender, EventArgs e)
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
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static formNewsAlert()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
