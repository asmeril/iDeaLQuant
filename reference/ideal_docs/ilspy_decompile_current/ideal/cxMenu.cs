using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;

namespace ideal;

internal class cxMenu
{
	public class item
	{
		public Rectangle Rect;

		public string Name;

		public bool Active;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DrawLine(Graphics graph, int p1X, int p1Y, int p2X, int p2Y)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DrawBar(Graphics graph, int p1X, int p1Y, int p2X, int p2Y)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DrawDot(Graphics graph, int p1X, int p1Y, int p2X, int p2Y)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DrawArc(Graphics graph, int p1X, int p1Y, int width, int height)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DrawString(Graphics graph, Font font, string str, int p1X, int p1Y)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DrawString(Graphics graph, Font font, string str, int p1X, int p1Y, Color forecolorX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DrawRect(Graphics graph, int p1X, int p1Y, int width, int height)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DrawEllipse(Graphics graph, int p1X, int p1Y, int width, int height)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public item()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static item()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public List<item> Items;

	public Dictionary<string, item> Index;

	public int ActiveNo;

	public Font FontThis;

	public Color PassiveBC1;

	public Color PassiveBC2;

	public Color PassiveStr;

	public Color PassiveLine;

	public Color PassiveBar;

	public Color PassiveBorder;

	public Color ActiveBC1;

	public Color ActiveBC2;

	public Color ActiveStr;

	public Color ActiveLine;

	public Color ActiveBar;

	public Color ActiveBorder;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddItem(string name, Rectangle rect)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PaintAll(Graphics xGraph)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetActiveNo(Point xPoint)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static cxMenu()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
