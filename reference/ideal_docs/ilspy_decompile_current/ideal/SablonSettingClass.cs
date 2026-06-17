using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class SablonSettingClass
{
	public List<SablonRobotClass> RobotList;

	public bool MailBool;

	public bool SmsBool;

	public bool ViopVadeGecisBool;

	public bool SembolTaraSinyalBool;

	public int SembolTaraBar;

	public string TelNo;

	public string MailServerAdres;

	public int MailServerPort;

	public string MailGonderenAdres;

	public string MailGonderenSifre;

	public string MailAlici;

	public Color GetiriRenk;

	public bool GetiriAciklamaBool;

	public bool MaxDdLineBool;

	public bool MaxDdRegionBool;

	public bool FeedbackGetiriTekBool;

	public int OptIslemLimit;

	public int OptHaricAy;

	public bool EmirListesiSilinmesin;

	public bool PortfoyKontrolBool;

	public bool YeniSinyalBool;

	public bool PortfoyKarAlBool;

	public double PortfoyKarAlLevel;

	public bool PortfoyStopBool;

	public double PortfoyStopLevel;

	public double PortfoyStopMarj;

	public bool PortfoySabitStopBool;

	public double PortfoySabitStopLevel;

	public decimal MiktarSermaye;

	public Dictionary<string, decimal> MiktarDictionary;

	public int KanalSayisi;

	public int Vites;

	public static ConcurrentQueue<int> RobotQueue;

	public string UzakIp;

	public int UzakPort;

	public static SablonSettingClass Setting;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Deserialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SablonSettingClass()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SablonSettingClass()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		RobotQueue = new ConcurrentQueue<int>();
		Setting = new SablonSettingClass();
	}
}
