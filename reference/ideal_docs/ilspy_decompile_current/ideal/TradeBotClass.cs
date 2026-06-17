using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class TradeBotClass
{
	private string _sembol;

	public TradeBotStatus Status;

	public string AccountName;

	public string AccountNo;

	public bool NewLogin;

	public ConcurrentDictionary<string, TradeBotEmirClass> Orders;

	public static string SellType;

	public static int PrevorderCount;

	public string Sembol
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string Prefix
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

	public string Root
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

	public int DecPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TradeBotClass()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetRequestKey(TradeBotRequestType typex)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TradeBotEmirClass GetOrder(decimal pricex)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopOrder(string pricekey)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string SendOrder(TradeBotEmirClass orderx, double price, double amount, string buysell, TradeBotOrderType ordertype, bool alertBool = true)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ChangeBekleyen(string yonx, decimal eskifiyatx, decimal yenifiyatx, decimal lotx)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ChangeAmountBekleyen(TradeBotEmirClass orderX, decimal lotx)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeleteBekleyen(decimal fiyatx, string keyx)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static TradeBotClass()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		SellType = "Normal";
		PrevorderCount = 0;
	}
}
