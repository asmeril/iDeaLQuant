using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class BmcClass
{
	public Dictionary<string, BmcTaramaClass> Taramalar;

	public Dictionary<string, BmcPozisyonClass> Pozisyonlar;

	public static List<BmcEmirClass> EmirList;

	public int ClassVersion;

	public bool SurekliTaraBool;

	public int HisseMaxTarama;

	public int TekrarLimit;

	public bool TekrarBool;

	public static BmcClass Setting;

	public static int SanalGercek;

	public static bool RunningMode;

	public static string RunningTarama;

	public static string RunningSembol;

	public static string RunningPeriyot;

	public static bool ModifiedBool;

	public static bool ManuelMode;

	public static string ManuelTarama;

	public static string ManuelSembol;

	public static string ManuelPeriyot;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Deserialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BmcPozisyonClass GetPozisyon(string tarama, string periyot, string sembol)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetTaramaResult(string taramanameX, string sembolX, string periyotX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void PozisyonlariKapat()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPozisyon(string tarama, string periyot, string sembol, BmcPozisyonClass item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BmcClass()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static BmcClass()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		EmirList = new List<BmcEmirClass>();
		Setting = new BmcClass();
		SanalGercek = 0;
		RunningMode = false;
		RunningTarama = "";
		RunningSembol = "";
		RunningPeriyot = "";
		ModifiedBool = false;
		ManuelMode = false;
		ManuelTarama = "";
		ManuelSembol = "";
		ManuelPeriyot = "";
	}
}
