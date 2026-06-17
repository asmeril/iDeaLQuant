using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class cxDepth
{
	[Serializable]
	public class Line
	{
		public string Time;

		public float Price;

		public float OrderCount;

		public float Size;

		public float Rate;

		public float ColPrice;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetImkbVolume()
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Line()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Line()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public string Symbol;

	public string MarketCode;

	public int DecPoint;

	public int Level;

	public string PriceFormat;

	public List<Line> Bids;

	public List<Line> Asks;

	public Line Average1Bid;

	public Line Average1Ask;

	public Line Average2Bid;

	public Line Average2Ask;

	public static int ImkbLevelCount;

	public const int TuribLevelCount = 25;

	public static volatile Dictionary<string, cxDepth> Dictionary;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalculateAverage1(int linecountX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalculateAverage2()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeleteAskLine(int rownoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeleteBidLine(int rownoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InsertAskLine(int rownoX, string timeX, float priceX, float ordercountX, float sizeX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InsertBidLine(int rownoX, string timeX, float priceX, float ordercountX, float sizeX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateAskData(int rownoX, string timeX, float priceX, float ordercountX, float sizeX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateBidData(int rownoX, string timeX, float priceX, float ordercountX, float sizeX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static cxDepth AddItem(string symbolX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DeserializeItems()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static cxDepth GetItem(string symbolX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemoveItem(string symbolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxDepth()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static cxDepth()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		ImkbLevelCount = 5;
		Dictionary = new Dictionary<string, cxDepth>();
	}
}
