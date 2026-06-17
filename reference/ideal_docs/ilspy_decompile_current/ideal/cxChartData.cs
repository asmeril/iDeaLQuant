using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

internal class cxChartData
{
	[Serializable]
	public class ChartRecord
	{
		public string Symbol;

		public string Period;

		public int Index;

		public float Open;

		public float High;

		public float Low;

		public float Close;

		public float Size;

		public float Vol;

		public float Opint;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChartRecord ShallowCopy()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChartRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChartRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class TickRecord
	{
		public int Index;

		public float LastPrice;

		public float LastSize;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TickRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TickRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class DownloadRecord
	{
		public string Key;

		public string Symbol;

		public string Period;

		public int Index;

		public float Open;

		public float High;

		public float Low;

		public float Close;

		public float Size;

		public float Vol;

		public float Opint;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DownloadRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DownloadRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class Update
	{
		[Serializable]
		public class Record
		{
			public Dictionary<int, ChartRecord> Dictionary1;

			public Dictionary<int, ChartRecord> Dictionary5;

			public Dictionary<int, ChartRecord> Dictionary60;

			public Dictionary<int, ChartRecord> DictionaryDay;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Record()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Record()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public static Dictionary<string, Record> ChartDictionary;

		public static Dictionary<string, List<TickRecord>> TickDictionary;

		public static List<DownloadRecord> ChartDownloadList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Deserialize()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Serialize()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Update()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Update()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			WP6RZJql8gZrNhVA9v.w65ov7siki();
			hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
			ChartDictionary = new Dictionary<string, Record>();
			TickDictionary = new Dictionary<string, List<TickRecord>>();
			ChartDownloadList = new List<DownloadRecord>();
		}
	}

	public static ChartRecord[] FileImage;

	public static List<string> DirectoryList;

	public static bool DownloadWritingBool;

	public static bool DownloadAllChartBool;

	public static Dictionary<string, int> ChartDownloadTime;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double CalculateVolatility(string symbolX, int numberX)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int ConvertDateToIndex(DateTime datetimeX, string periodX)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DateTime ConvertIndexToDate(int indexX, string periodX)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ConvertIndexToString(int indexX, string periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DateTime ConvertStringToDate(string datestrX)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int ConvertStringToIndex(string datestrX, string periodX)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetChartPeriodName(string codeX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float GetHistoricClosingPrice(string symbolX, int dayindexX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ChartRecord GetHistoricDataRec(string symbolX, int dayindexX, string periodX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InsertBarsToChartFile(List<DownloadRecord> originallistX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InsertDownloadedBarsToChartFile()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReadFromFile(string symbolX, string periodX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemoveBarsFromChartFile(List<DownloadRecord> originallistX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RepairChartFile(string symbol, string period, int lastindex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RepairChartFileDate(string symbol, string period, DateTime date)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SplitStock(string symbolX, string periodX, int indexX, float ratioX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SplitStock5S(string symbolX, int indexX, float ratioX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SplitStockAllPeriods(string symbolX, string dateX, float ratioX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateChartBuffers(cxBasic basicitemX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateChartGunBuffer(cxBasic basicitemX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateTickBuffer(string symbolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateNewTickBuffer(string symbolX, float islemprice, float lot, int hour, int minute, int second)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteBufferToChartFile(string symbolX, string periodX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteBufferToTickFile(string symbolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SplitIndexAllPeriods(string symbolX, decimal ratioX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SplitEndeksChart(string symbolX, string periodX, int indexX, decimal ratioX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SplitEndeksBirim(string symbolX, string periodX, int indexX, decimal ratioX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxChartData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static cxChartData()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		DirectoryList = new List<string>();
		DownloadWritingBool = false;
		DownloadAllChartBool = false;
		ChartDownloadTime = new Dictionary<string, int>();
	}
}
