using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class AlgoSettingClass
{
	public List<AlgoClass> RobotList;

	public int OrderType;

	public decimal YilGun;

	public bool RealModBool;

	public bool UyariBool;

	public bool SoundBool;

	public decimal KalanGunLimit;

	public decimal KalanGuneEkleVal;

	public bool KalanGuneEkleBool;

	public bool UzaktakiKadarBool;

	public string EmirTipi;

	[NonSerialized]
	private static ConcurrentDictionary<AlgoTypes, bool> RunningAlgoTips;

	[NonSerialized]
	public Dictionary<string, List<AlgoClass>> PovRobotListDict;

	[NonSerialized]
	public const int OrderTypeBackOfficeOnly = 1;

	[NonSerialized]
	public const int OrderTypeBackOffice_DropCopy = 2;

	[NonSerialized]
	public const int OrderTypeFixRouter = 3;

	[NonSerialized]
	public static AlgoSettingClass Setting;

	[NonSerialized]
	public static volatile string RunningDescriptionArbitraj;

	public static bool RunningModeAny
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public static bool RunningModeAnyArbitrajNotInclude
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool RunningMode(AlgoTypes algoTypes)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool RunningMode(List<AlgoTypes> algoTypes)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void StartRunningMode(AlgoTypes algoTypes)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void StopRunningMode(AlgoTypes algoTypes)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Deserialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AlgoSettingClass()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoSettingClass()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		RunningAlgoTips = new ConcurrentDictionary<AlgoTypes, bool>();
		Setting = new AlgoSettingClass();
		RunningDescriptionArbitraj = "";
	}
}
