using System;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class RiskClass
{
	public long ID;

	public int AktifPasif;

	public int RiskTip;

	public string Kurum;

	public string Sembol;

	public int HacimTip;

	public double Limit;

	public bool AlarmBool;

	public bool SmsBool;

	public bool PushBool;

	public string Sure;

	[NonSerialized]
	public double Deger;

	[NonSerialized]
	public bool GerceklestiBool;

	[NonSerialized]
	public string Aciklama;

	[NonSerialized]
	public double KurumMiktar;

	[NonSerialized]
	public double HisseMiktar;

	public static bool RunningMode;

	public static int RunningRowNo;

	public static string RunningDescription;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Calculate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string RiskTipString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string HacimTipString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RiskClass()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RiskClass()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		RunningMode = false;
		RunningRowNo = -1;
		RunningDescription = "";
	}
}
