using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class cxAlert
{
	public int ClassVersion;

	public int WindowLeft;

	public int WindowTop;

	public int WindowWidth;

	public int WindowHeight;

	public int MessageLeft;

	public int MessageTop;

	public bool SoundBool;

	public string FilterStatus;

	public string FilterDirection;

	public List<cxAlertRecord> List;

	public static Dictionary<string, bool> WaitingDictionary;

	public static bool RefreshBool;

	public static cxAlert Setting;

	public static string SortKey;

	public static bool SortAscending;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Deserialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CheckWaitingDictionary(string symbolX)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void PrepareWaitingDictionary()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxAlert()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static cxAlert()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		WaitingDictionary = new Dictionary<string, bool>();
		RefreshBool = false;
		Setting = new cxAlert();
		SortKey = "";
		SortAscending = true;
	}
}
