using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

public static class clsFixOrder
{
	public static string BeginString;

	public static string BeginString_IDEALPAY;

	public static string BeginString_IDEALVIOP;

	public static string Sender;

	public static List<FixRouterAccountData> fixRouterAccountDatas;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static ConnectionState _003CState_003Ek__BackingField;

	public const string DateTimeFormat = "yyyy-MM-ddTHH:mm:ss.fffffff";

	public static CultureInfo default_culture_info;

	public static DateTime ConnectionTime;

	public static DateTime LoginTime;

	public static Type _Error;

	public static Type _OrderReport;

	public static Type _LogoutResponse;

	public static Type _Heartbeat;

	public static Type _LoginResponse;

	public static Type _GetAccountsResponse;

	private static Session.Heartbeat heartbeat;

	private static Dictionary<Guid, FixOrderData> fixOrderDictionary;

	public static ConnectionState State
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ConnectionState)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public static Dictionary<Guid, FixOrderData> GetOrderDictionary
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void LoginFixOrder(string Username, string Password)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool LoginCheck()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SendHB()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool SendOrder(Session.NewOrder order)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool UpdateOrders(List<Session.CancelReplaceOrder> cancelReplaceOrders)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool UpdateOrders(List<string> orderUids, double newPrice)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void CancelOrderBeginString(Session.CancelOrder cancelReplaceOrder)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void CancelOrderBeginString(Session.CancelReplaceOrder cancelOrder)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CancelOrder(Session.CancelReplaceOrder cancelOrder)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CancelOrders(List<Session.CancelOrder> cancelOrders)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CancelOrders(List<string> orderUids)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void EmirGonderTest()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool GetOrders(Session.GetOrders getOrders)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GetOrdersToday()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool GetAccounts()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddOrUpdateAccounts(Session.GetAccountsResponse accountsResponse)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ClearAccounts()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool SendData(string data, bool log = true)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string toFixOrderDateTime(this DateTime date)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DateTime toFixOrderDateTime(this string date)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string toFixOrderGuid(this Guid guid)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static cxBasic GetCxBasic(this string sembol)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Piyasa GetPiyasa(this string sembol)
	{
		return (Piyasa)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddOrUpdateFixOrderDictionary(Session.OrderReport orderReport)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddOrUpdateFixOrderDictionary(Session.Error error)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddOrUpdateFixOrderDictionary(Guid guid, FixOrderData fixOrderData)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ClearFixOrderDictionary()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static FixOrderData GetFixOrderData(string guid)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static FixOrderData GetFixOrderData(Guid guid)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static clsFixOrder()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		BeginString = "IDEAL";
		BeginString_IDEALPAY = "IDEALPAYPROD";
		BeginString_IDEALVIOP = "IDEALVIOP";
		Sender = "";
		fixRouterAccountDatas = new List<FixRouterAccountData>();
		State = ConnectionState.Disconnected;
		default_culture_info = wmBIxFm0B5H9be65eCD.r7iItWL60("en-US", wmBIxFm0B5H9be65eCD.WK3mP8cocf);
		ConnectionTime = DateTime.MinValue;
		LoginTime = DateTime.MinValue;
		_Error = Mni0I9mY6mxNfRIi9vR.r7iItWL60(typeof(Session.Error).TypeHandle, Mni0I9mY6mxNfRIi9vR.v6cmp7XVRL);
		_OrderReport = Mni0I9mY6mxNfRIi9vR.r7iItWL60(typeof(Session.OrderReport).TypeHandle, Mni0I9mY6mxNfRIi9vR.v6cmp7XVRL);
		_LogoutResponse = Mni0I9mY6mxNfRIi9vR.r7iItWL60(typeof(Session.LogoutResponse).TypeHandle, Mni0I9mY6mxNfRIi9vR.v6cmp7XVRL);
		_Heartbeat = Mni0I9mY6mxNfRIi9vR.r7iItWL60(typeof(Session.Heartbeat).TypeHandle, Mni0I9mY6mxNfRIi9vR.v6cmp7XVRL);
		_LoginResponse = Mni0I9mY6mxNfRIi9vR.r7iItWL60(typeof(Session.LoginResponse).TypeHandle, Mni0I9mY6mxNfRIi9vR.v6cmp7XVRL);
		_GetAccountsResponse = Mni0I9mY6mxNfRIi9vR.r7iItWL60(typeof(Session.GetAccountsResponse).TypeHandle, Mni0I9mY6mxNfRIi9vR.v6cmp7XVRL);
		heartbeat = new Session.Heartbeat
		{
			Timestamp = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv).toFixOrderDateTime()
		};
		fixOrderDictionary = new Dictionary<Guid, FixOrderData>();
	}
}
