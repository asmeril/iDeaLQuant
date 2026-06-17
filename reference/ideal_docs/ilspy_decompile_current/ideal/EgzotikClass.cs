using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class EgzotikClass
{
	public List<PgcPozisyonClass> PgcPozisyonList;

	public static List<EgzotikEmirClass> EmirList;

	public int ClassVersion;

	public string TelNo;

	public bool SmsBool;

	public bool YeniSinyalBool;

	public static EgzotikClass Setting;

	public static bool PgcRunningMode;

	public static int PgcRunningRowNo;

	public static string PgcRunningDesc;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Deserialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EgzotikClass()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static EgzotikClass()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		EmirList = new List<EgzotikEmirClass>();
		Setting = new EgzotikClass();
		PgcRunningMode = false;
		PgcRunningRowNo = -1;
		PgcRunningDesc = "";
	}
}
