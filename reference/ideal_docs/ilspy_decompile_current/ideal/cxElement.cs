using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class cxElement
{
	public enElementTypes ElementType;

	public string Symbol;

	public int FrameNo;

	public DateTime StartDate;

	public float StartValue;

	public DateTime EndDate;

	public float EndValue;

	public List<cxDatePoint> ThreePoints;

	public bool Snap;

	public bool ExtendRight;

	public int ReflectCount;

	public Color ForeColor;

	public bool Filled;

	public Color FillColor1;

	public Color FillColor2;

	public int FillOpacity;

	public int Tickness;

	public DashStyle Dash;

	public float Unit;

	public float Width;

	public float Height;

	public string TrendText;

	public Font Font;

	public bool Valid;

	public int StartBarNo;

	public int EndBarNo;

	public float Slope;

	public float RaffDif;

	public float StDevDif;

	public float StErrorDif;

	public float EqDif;

	public float EqPoint;

	public PointF PointDraw1;

	public PointF PointDraw2;

	public PointF PointDraw3;

	public bool EqFixed;

	public float[] QuadrantValues;

	public long TrendID;

	public static cxElement ActiveElement;

	public static cxElement DefaultElement;

	public static string ValueString;

	public static bool SnapMode;

	public Color[] FibonacciLevelColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public bool Visible
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxElement ShallowCopy()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetName(enElementTypes xType)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReadDefaultParameters()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SaveDefaultParameters(cxElement elementX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxElement()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static cxElement()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		DefaultElement = new cxElement();
		ValueString = "";
		SnapMode = false;
	}
}
