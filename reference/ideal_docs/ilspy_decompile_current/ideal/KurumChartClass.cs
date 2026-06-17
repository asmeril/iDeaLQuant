using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class KurumChartClass
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct KurumStruct
	{
		public byte Hour;

		public byte Minute;

		public int SembolId;

		public float NetLot;

		public float NetVol;
	}

	public class KurumRecord
	{
		public byte Hour;

		public byte Minute;

		public int SembolId;

		public float NetLot;

		public float NetVol;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KurumRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static KurumRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public static Dictionary<int, Dictionary<string, KurumRecord>> KurumBugunDictionary;

	public static DateTime DateConverted;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ConvertIslemlerTarih(string datestrX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ConvertIslemlerDayCount(int daycountX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ConvertIslemlerToday()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<DateTime> GetDateListFromCount(int countX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<cxBar> GetKurumChart(string sembolX, int kurumIdX, int daycount, bool kumulatifbool, out float kzX, out float kumulatifnetX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<KurumRecord> ReadKurumTarihsel(string filenameX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteKurumTarihsel(List<KurumRecord> listX, string filenameX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddIslemxx(IslemStruct1 tradeitem)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KurumChartClass()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static KurumChartClass()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		KurumBugunDictionary = new Dictionary<int, Dictionary<string, KurumRecord>>();
		DateTime dateTime = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
		DateConverted = gr7jwURt1t3VJtiGGT.r7iItWL60(ref dateTime, -1.0, gr7jwURt1t3VJtiGGT.z9nxy3dm7u);
	}
}
