using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class cxTrade
{
	public class Tahvil
	{
		public static int LocalTradeId;

		public static List<cxTrade> List;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddItem(cxTrade itemX, bool updateboolX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<cxTrade> GetList(string symbolX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<cxTrade> GetList()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ReadItems()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void WriteItems()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Tahvil()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Tahvil()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			WP6RZJql8gZrNhVA9v.w65ov7siki();
			hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
			LocalTradeId = 0;
			List = new List<cxTrade>();
		}
	}

	public class Turib
	{
		public static string DirName;

		public static List<cxTrade> List;

		private static volatile List<cxTrade> TradeBuffer;

		public static bool MoneyFlowRecalculate;

		public static int LocalTradeId;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddItem(cxTrade itemX, bool updateboolX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static cxTrade GetItem(int posX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<cxTrade> GetList(string symbolX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<cxTrade> GetList(byte periodX, string dateX, string filterX, Dictionary<string, string> symboldictX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<cxTrade> GetList(string dateX, string symbolX)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ReadItems()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RecalculateMoneyFlow()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RemoveItem(int posX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void UpdateMoneyFlow(cxTrade tradeitemX, cxBasic basicitemX)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void WriteBuffer()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Turib()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Turib()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			WP6RZJql8gZrNhVA9v.w65ov7siki();
			hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
			DirName = "";
			List = new List<cxTrade>();
			TradeBuffer = new List<cxTrade>();
			MoneyFlowRecalculate = false;
			LocalTradeId = 0;
		}
	}

	public int TradeID;

	public string Symbol;

	public byte Hour;

	public byte Minute;

	public byte Second;

	public float Price;

	public float Bid;

	public float Ask;

	public float Size;

	public string Tip;

	public string BuyerCode;

	public string SellerCode;

	public byte Deleted;

	public byte AggresiveParty;

	public string NasdaqTradeId;

	public byte NasdaqTradeType;

	public float Vol;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxTrade GetShallowCopy()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte GetDirection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetTimeString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetTimeNumeric()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string HourMinuteString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxTrade()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static cxTrade()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
