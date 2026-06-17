using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

internal class YeniPort
{
	public string HesapNo;

	public string AltHesap;

	public List<cxPortfolio.ImkbOrderRecord> ImkbOrderList;

	public Dictionary<string, cxPortfolio.ImkbOrderRecord> ImkbOrderDict;

	public List<cxPortfolio.VipOrderRecord> VipOrderList;

	public Dictionary<string, cxPortfolio.VipOrderRecord> VipOrderDict;

	public List<cxPortfolio.VipOrderRecord> VipGerceklesenList;

	public List<cxPortfolio.ImkbPositionRecord> ImkbPositionList;

	public List<cxPortfolio.VipPositionRecord> VipPositionList;

	public Dictionary<string, string> ImkbSummaryDictionary;

	public Dictionary<string, string> VipCollateralDictionary;

	public double ImkbOverall;

	public double ImkbLimit;

	public double ImkbCariBakiye;

	public double ViopTeminatToplam;

	public double ViopTeminatBaslangic;

	public double ViopTeminatSurdurme;

	public double ViopTeminatKullanilabilir;

	public double ViopTeminatCekilebilir;

	public double ViopTeminatCagri;

	public double ViopNetMaliyet;

	public double ViopOpsiyonPrimiNet;

	public double ViopFifoMaliyet;

	public DateTime ImkbGetTumTime;

	public DateTime VipGetTumTime;

	public static ConcurrentDictionary<string, YeniPort> YeniPortDict;

	public static ConcurrentQueue<string> EventQueueYeniPortfoy;

	public static Dictionary<string, bool> RequestTumDict;

	public static Dictionary<string, bool> RequestBusyDict;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static YeniPort GetYeniPort(string hesapno, string althesap)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void _ImkbGetPositionsYeni(string accountnameX, string accountnoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void _ImkbGetOrdersYeni(string accountnameX, string accountnoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void _ImkbGetSummaryYeni(string accountnameX, string accountnoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ImkbGetTumYeni(string accountnameX, string accountnoX, int interval)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ImkbGetPositionsYeni(string accountnameX, string accountnoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ImkbSendOrderYeni(cxPortfolio.BuySellRecord buysellX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ImkbSendOrdersYeni(List<cxPortfolio.BuySellRecord> buyselllistX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ImkbCancelOrdersYeni(List<cxPortfolio.ImkbOrderRecord> ordersX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ImkbCancelOrdersAlgo(HesapRec hesapitem, YeniPort yeniport, List<EmirRec> iptalorders)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ImkbImproveOrdersYeni(List<cxPortfolio.ImkbOrderRecord> ordersX, double priceX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ImkbImproveOrdersAlgo(HesapRec hesapitem, YeniPort yeniport, List<EmirRec> orders, decimal priceX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void _VipGetPositionsYeni(string accountnameX, string accountnoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void _VipGetOrdersYeni(string accountnameX, string accountnoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void _VipGetFillPriceYeni(string accountnameX, string accountnoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void _VipGetCollateralYeni(string accountnameX, string accountnoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void VipGetTumYeni(string accountnameX, string accountnoX, int interval)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void VipGetPositionsYeni(string accountnameX, string accountnoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void VipSendOrderYeni(cxPortfolio.BuySellRecord buysellX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void VipSendOrdersYeni(List<cxPortfolio.BuySellRecord> buyselllistX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void VipCancelOrdersYeni(List<cxPortfolio.VipOrderRecord> ordersX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void VipImproveOrdersYeni(List<cxPortfolio.VipOrderRecord> ordersX, List<cxPortfolio.BuySellRecord> buysellsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void VipImproveOrdersAlgo(HesapRec hesapitem, YeniPort yeniport, List<EmirRec> orders, decimal priceX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public YeniPort()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static YeniPort()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		YeniPortDict = new ConcurrentDictionary<string, YeniPort>();
		EventQueueYeniPortfoy = new ConcurrentQueue<string>();
		RequestTumDict = new Dictionary<string, bool>();
		RequestBusyDict = new Dictionary<string, bool>();
	}
}
