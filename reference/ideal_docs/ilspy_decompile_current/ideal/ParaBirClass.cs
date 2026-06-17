using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class ParaBirClass
{
	public Dictionary<string, ParaBirPozisyonClass> PozisyonMap;

	public static List<ParaBirEmirClass> EmirList;

	public static List<string> ParaSistemList;

	public int ClassVersion;

	public string TelNo;

	public bool SmsBool;

	public bool YeniSinyalBool;

	public static ParaBirClass Setting;

	public static bool RunningMode;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Deserialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ParaBirClass()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParaBirClass()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		EmirList = new List<ParaBirEmirClass>();
		ParaSistemList = new List<string>();
		Setting = new ParaBirClass();
		RunningMode = false;
	}
}
