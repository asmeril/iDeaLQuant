using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

[Serializable]
public class cxGrid
{
	[Serializable]
	public class Col
	{
		public int Code;

		public int Width;

		public int AlignInt;

		[NonSerialized]
		public int Left;

		[NonSerialized]
		public StringFormat AlignFmt;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Col()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Col()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public List<Col> Cols;

	[NonSerialized]
	public List<string> Headers;

	[NonSerialized]
	public Panel PanelGrid;

	[NonSerialized]
	public Font Font;

	[NonSerialized]
	public bool ShowForm;

	[NonSerialized]
	public bool ShowHeader;

	[NonSerialized]
	public bool ColResizeStarted;

	[NonSerialized]
	public int ColCount;

	[NonSerialized]
	public int RowCount;

	[NonSerialized]
	public int HeaderHeight;

	[NonSerialized]
	public int Width;

	[NonSerialized]
	public int RowHeight;

	[NonSerialized]
	public int TopRow;

	[NonSerialized]
	public int BottomRow;

	[NonSerialized]
	public int CurrentRow;

	[NonSerialized]
	public int DisplayRows;

	[NonSerialized]
	public int MouseRowNo;

	[NonSerialized]
	public int MouseColNo;

	[NonSerialized]
	public int MousePosX;

	[NonSerialized]
	public int MousePosY;

	[NonSerialized]
	public int HorizontalMargin;

	[NonSerialized]
	public int VerticalMargin;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(int colcountX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(int colcountX, string headerX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalculateColLeft()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ConvertAlignToInt()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ConvertIntToAlign()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeleteAllCols()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeleteCol(int ColNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FindCellNo(float X, float Y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InsertCol(int ColNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessMouseMove(MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessMouseDown(int DataCount, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ProcessMouseWheel(int DataCount, MouseEventArgs e)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCol(int ColNo, int xCode, int xWidth, StringFormat xAlign)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxGrid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static cxGrid()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
