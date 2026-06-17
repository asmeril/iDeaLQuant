using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;

namespace ideal;

internal class cxEvent
{
	public delegate void MessageDataHandler(string messageX);

	public delegate void NewsDataHandler(long dateX);

	public delegate void TcmbDataHandler(string pagekeyX, int linenoX);

	public delegate void BasicDataHandler(string symbolX, string updatetypeX);

	public delegate void ChartDataHandler(string symbolX);

	public delegate void ChartDataBasicHandler(string symbolX);

	public delegate void DepthHandler(string symbolX, char bidasktypeX, int rowX);

	public delegate void DepthListHandler(string symbolX, List<int> rowlistX);

	public delegate void TradeHandler(cxTrade itemX);

	public delegate void BistIslemHandler(IslemStruct1 itemX);

	public delegate void ViopIslemHandler(IslemStruct1 itemX);

	public delegate void CizilenHandler(cxCizilen itemX);

	public delegate void EmirSiraHandler(string symbolX, string datastrX);

	public delegate void FixRouterTradeEvent(FixOrderData fixOrderData);

	public static event Action<string, string> ApiServerMessageReceived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event MessageDataHandler MessageReceived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event MessageDataHandler EventKEP
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event MessageDataHandler EventYeniPortfoy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event MessageDataHandler EventGhost
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event MessageDataHandler DovizQuoteReceived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event MessageDataHandler PortfolioReceived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event MessageDataHandler DebugReceived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event MessageDataHandler PrintMessageRecevied
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event NewsDataHandler NewsDataReceived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event NewsDataHandler NewsDataDeleted
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event TcmbDataHandler TcmbDataReceived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event BasicDataHandler BasicDataReceived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event ChartDataHandler ChartDataReceived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event ChartDataBasicHandler ChartDataBasicReceived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event DepthHandler DepthRefreshed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event DepthHandler DepthUpdateRowReceived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event DepthListHandler DepthUpdateListReceived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event TradeHandler ImkbTradeReceived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event TradeHandler VipTradeReceived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event TradeHandler TuribTradeReceived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event TradeHandler TahvilTradeReceived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event BistIslemHandler BistIslemReceived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event ViopIslemHandler ViopIslemReceived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event CizilenHandler CizilenReceived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event EmirSiraHandler EmirSiraUpdateReceived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event EmirSiraHandler EmirSiraRefreshReceived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event FixRouterTradeEvent fixRouterTradeEvent
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnApiServerMessageReceived(string cmdX, string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnMessageReceived(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void KEP(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void YeniPortfoy(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GHOST(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnDovizQuoteReceived(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnPortfolioReceived(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnDebugReceived(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnPrintMessageRecevied(string Mesaj)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnNewsReceived(long dateX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnNewsDeleted(long dateX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnTcmbReceived(string pagekeyX, int linenoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnBasicReceived(string symbolX, string updatetypeX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnChartReceived(string symbolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnChartBasicReceived(string symbolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnDepthRefreshed(string symbolX, char bidasktypeX, int rowX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnDepthUpdateRowReceived(string symbolX, char bidasktypeX, int rowX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnDepthUpdateListReceived(string symbolX, List<int> rowlistX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnImkbTradeReceived(cxTrade itemX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnVipTradeReceived(cxTrade itemX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnTuribTradeReceived(cxTrade itemX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnTahvilTradeReceived(cxTrade itemX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnBistIslemReceived(IslemStruct1 itemX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnViopIslemReceived(IslemStruct1 itemX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnCizilenReceived(cxCizilen itemX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnEmirSiraUpdateReceived(string symbolX, string datastrX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnEmirSiraRefreshReceived(string symbolX, string datastrX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnFixRouterTradeReceived(FixOrderData fixOrderData)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxEvent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static cxEvent()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
