using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[StructLayout(LayoutKind.Sequential, Size = 1)]
internal struct cxTime
{
	private struct SystemTime
	{
		public short Year;

		public short Month;

		public short DayOfWeek;

		public short Day;

		public short Hour;

		public short Minute;

		public short Second;

		public short Milliseconds;
	}

	public static Stopwatch Tick;

	public static string DateTimeString;

	public static string LongDateString;

	public static string ShortDateString;

	public static string LongTimeString1;

	public static string LongTimeString2;

	public static string ShortTimeString;

	public static int TimeNumeric;

	public static DateTime Date;

	public static bool DateReceived;

	public static bool SeansStartBool;

	public static int Year;

	public static int Month;

	public static int Day;

	public static int Hour;

	public static int Minute;

	public static int Second;

	public static int ChartIndexDay;

	public static int ChartIndexMin60;

	public static int ChartIndexMin05;

	public static int ChartIndexMin01;

	public static string BugunValor;

	public static string YarinValor;

	public static string ImkbUlusalPazarOpen;

	public static string ImkbSessionNo;

	public static string ImkbStartStr1;

	public static string ImkbEndStr1;

	public static string ImkbStartStr2;

	public static string ImkbEndStr2;

	public static string VipStartStr;

	public static string VipEndStr;

	public static string SaseStartStr;

	public static string SaseEndStr;

	public static int ImkbStartNum1;

	public static int ImkbEndNum1;

	public static int ImkbStartNum2;

	public static int ImkbEndNum2;

	public static int VipStartNum;

	public static int VipEndNum;

	public static int SaseStartNum;

	public static int SaseEndNum;

	public static string ImkbResetTime1;

	public static string ImkbResetTime2;

	public static string VipResetTime1;

	public static bool isWeekend;

	public static bool ImkbSessionStartBool;

	public static bool RemoveExpiredBusy;

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern int SetLocalTime(ref SystemTime lpSystemTime);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetSystemTime(string timeX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetServerDateTime()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ProcessTimeTick(string datestringX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CheckLicenseExpiry()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DeleteDosyalar()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReadPriceEarning()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemoveBonds()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemoveExpiredContracts()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemoveFiles()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemoveSymbol(string symbolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ResetConsolidatedBonds()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ResetNews()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static cxTime()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		Tick = new Stopwatch();
		DateTimeString = "";
		LongDateString = "";
		ShortDateString = "";
		LongTimeString1 = "";
		LongTimeString2 = "";
		ShortTimeString = "";
		TimeNumeric = 0;
		DateReceived = false;
		SeansStartBool = false;
		Year = 0;
		Month = 0;
		Day = 0;
		Hour = 0;
		Minute = 0;
		Second = 0;
		ChartIndexDay = 0;
		ChartIndexMin60 = 0;
		ChartIndexMin05 = 0;
		ChartIndexMin01 = 0;
		DateTime dateTime = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
		int num = otNWcBYnHdLbQlalsG.r7iItWL60(ref dateTime, otNWcBYnHdLbQlalsG.hh6bUnUwm);
		string text = NRNiQbqbqx5n6lNJe21.r7iItWL60(ref num, "00", NRNiQbqbqx5n6lNJe21.EsGqdnjfQ3);
		dateTime = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
		num = otNWcBYnHdLbQlalsG.r7iItWL60(ref dateTime, otNWcBYnHdLbQlalsG.RM1hHQdDN);
		BugunValor = sslKcLsTa6aHD1oC7G.r7iItWL60(text, "/", NRNiQbqbqx5n6lNJe21.r7iItWL60(ref num, "00", NRNiQbqbqx5n6lNJe21.EsGqdnjfQ3), sslKcLsTa6aHD1oC7G.DWtFgablW);
		dateTime = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
		num = otNWcBYnHdLbQlalsG.r7iItWL60(ref dateTime, otNWcBYnHdLbQlalsG.hh6bUnUwm);
		string text2 = NRNiQbqbqx5n6lNJe21.r7iItWL60(ref num, "00", NRNiQbqbqx5n6lNJe21.EsGqdnjfQ3);
		dateTime = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
		num = otNWcBYnHdLbQlalsG.r7iItWL60(ref dateTime, otNWcBYnHdLbQlalsG.RM1hHQdDN);
		YarinValor = sslKcLsTa6aHD1oC7G.r7iItWL60(text2, "/", NRNiQbqbqx5n6lNJe21.r7iItWL60(ref num, "00", NRNiQbqbqx5n6lNJe21.EsGqdnjfQ3), sslKcLsTa6aHD1oC7G.DWtFgablW);
		ImkbUlusalPazarOpen = "0";
		ImkbSessionNo = "1";
		ImkbStartStr1 = "100000";
		ImkbEndStr1 = "125959";
		ImkbStartStr2 = "140000";
		ImkbEndStr2 = "180959";
		VipStartStr = "091500";
		VipEndStr = "225959";
		SaseStartStr = "100000";
		SaseEndStr = "142959";
		ImkbStartNum1 = 0;
		ImkbEndNum1 = 0;
		ImkbStartNum2 = 0;
		ImkbEndNum2 = 0;
		VipStartNum = 0;
		VipEndNum = 0;
		SaseStartNum = 0;
		SaseEndNum = 0;
		ImkbResetTime1 = "08:30";
		ImkbResetTime2 = "13:05";
		VipResetTime1 = "08:30";
		isWeekend = false;
		ImkbSessionStartBool = false;
		RemoveExpiredBusy = false;
	}
}
