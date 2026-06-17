using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class FormControl : Form
{
	private enum ButtonTypes
	{
		None,
		CloseLeft,
		AlignMove,
		CloseRight,
		Minimize,
		Maximize,
		Header,
		Resize
	}

	public int FormOrder;

	public bool MoveEnabled;

	public bool HeaderVisible;

	public bool RightButtonsVisible;

	public bool MaximizeEnabled;

	public bool MinimizeEnabled;

	public bool GrupMember;

	public bool Maximized;

	public Rectangle MaximizeRect;

	public int FormHeaderHeight;

	public bool DisableBE;

	public Color HeaderBorderColor;

	public Color HeaderBackColor1;

	public Color HeaderBackColor2;

	public Color HeaderButtonPassiveColor;

	public Color HeaderButtonActiveColor;

	public Color HeaderTextForeColor;

	public Color HeaderMenuForeColor;

	private Color headerbordercolor;

	private Color headerbackcolor1;

	private Color headerbackcolor2;

	private Color headerbuttonpassivecolor;

	private Color headerbuttonactivecolor;

	private ButtonTypes MouseMoveButton;

	private int ButtonWidth;

	private int LeftCloseButtonX1;

	private int AlignMoveButtonX1;

	private int CaptionX1;

	private int RightCloseButtonX1;

	private int MaximizeButtonX1;

	private int MinimizeButtonX1;

	private bool MoveStarted;

	private bool ResizeStarted;

	private bool AlignedMove;

	private Point MouseDownPoint;

	private Rectangle MouseDownRect;

	private IContainer components;

	private Timer timerResize;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FormControl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myFormControl_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myFormControl_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myFormControl_MouseLeave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myFormControl_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myFormControl_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerResize_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CalculateButtonPositions()
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
	static FormControl()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
