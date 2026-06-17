using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formClock : FormControl
{
	private Font FontData;

	private int TimeDifference;

	private string CityName;

	private bool TopMostEnabled;

	private Color BackColor1;

	private Color BackColor2;

	private Color BorderColor;

	private Color ForeColor1;

	private Color ForeColor2;

	private cxPage.Clock PageParams;

	private int InitialLeft;

	private int InitialTop;

	private string TimeString;

	private bool FormLoaded;

	private Pen Pen1;

	private Pen Pen2;

	private SolidBrush Brush1;

	private SolidBrush Brush2;

	private Rectangle Rect1;

	private Rectangle Rect2;

	private string Str1;

	private Dictionary<string, int> CityDictionary;

	private IContainer components;

	private Timer timerUpdate;

	private Panel panelBasic;

	public ContextMenuStrip menu;

	private ToolStripMenuItem menuProperty;

	private ToolStripMenuItem menuPropertyMemCopy;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripMenuItem menuPropertyColor;

	private ToolStripMenuItem menuPropertyFont;

	private ToolStripMenuItem menuPattern;

	private ToolStripMenuItem menuMainPatternSave;

	private ToolStripMenuItem menuMainPatternSaveas;

	public ToolStripComboBox menuMainPatternChange;

	private ToolStripMenuItem menuMainPatternDelete;

	private ToolStripMenuItem menuMainPatternDeleteAll;

	private ToolStripSeparator toolStripSeparator5;

	private ToolStripMenuItem menuClose;

	private ToolStripMenuItem menuPropertyTimeDif;

	private ToolStripMenuItem menuPropertyHeader;

	private ToolStripMenuItem menuPropertyShowHeader;

	public ToolStripMenuItem menuPropertyTopmost;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripComboBox menuCities;

	private ToolStripMenuItem menuMainPatternDefault;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formClock(int leftX, int topX, cxPage.Clock pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formClock_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formClock_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formClock_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formClock_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuCities_DropDownClosed(object sender, EventArgs e)
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
	private void menuPropertyHeader_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPropertyMemCopy_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPropertyShowHeader_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPropertyTimeDif_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPropertyTopmost_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelBasic_MouseDown(object sender, MouseEventArgs e)
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
	private void InvalidateAll()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrepareTables()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPageParams(cxPage.Clock pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowMenu(object sender, Point pointX)
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
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static formClock()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
