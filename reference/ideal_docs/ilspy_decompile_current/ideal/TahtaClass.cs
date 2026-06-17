using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class TahtaClass
{
	public Dictionary<string, TahtaRobot1Class> PozMap1;

	public static List<TahtaEmir1Class> EmirList1;

	public int ClassVersion;

	public int Interval;

	public static TahtaClass Setting;

	public bool KurusBool;

	public bool AksamPozKapatBool1;

	public string AksamPozKapatSaat1;

	public static int SanalGercek1;

	public static bool RunningMode1;

	public static bool ModifiedBool1;

	public Dictionary<string, TahtaRobot2Class> PozMap2;

	public static List<TahtaEmir2Class> EmirList2;

	public bool AksamPozKapatBool2;

	public string AksamPozKapatSaat2;

	public static int SanalGercek2;

	public static bool RunningMode2;

	public static bool ModifiedBool2;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CheckTrade1(IslemStruct1 islem)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CheckKarAl1()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Deserialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SendOrder1(TahtaRobot1Class robotitem, int miktar, decimal fiyat, string aciklama)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SendOrder2(TahtaRobot2Class robotitem, int miktar, decimal fiyat, string aciklama)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TahtaClass()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static TahtaClass()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		EmirList1 = new List<TahtaEmir1Class>();
		Setting = new TahtaClass();
		SanalGercek1 = 0;
		RunningMode1 = false;
		ModifiedBool1 = false;
		EmirList2 = new List<TahtaEmir2Class>();
		SanalGercek2 = 0;
		RunningMode2 = false;
		ModifiedBool2 = false;
	}
}
