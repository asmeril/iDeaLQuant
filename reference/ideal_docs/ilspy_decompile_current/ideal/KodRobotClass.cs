using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class KodRobotClass
{
	public long RobotID;

	public string SistemName;

	public double Miktar;

	public double Pozisyon;

	public string AnalizSembol;

	public string IslemSembol;

	public string Hesap;

	public string AltHesap;

	public string Periyot;

	public int GercekSanal;

	public string BaslangicSaat;

	public string KapanisSaat;

	public bool AcigaSatisBool;

	public bool SonSinyalBool;

	public string SonSinyalSaat;

	public int EmirBarTip;

	public double IslemFiyat;

	public string IslemYon;

	public int CanliBarSure;

	public DateTime SinyalTime;

	public int GunKzGun;

	public double GunKzStartKasa;

	public double GunKzIslemKasa;

	[NonSerialized]
	public double SonFiyat;

	[NonSerialized]
	public double Kz;

	[NonSerialized]
	public double GunKz;

	public static bool RunningMode;

	public static string RunningDescTime;

	public static string RunningDescSure;

	public static List<RobotOrderClass> IslemList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalculateKZ()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalculateStartKasa()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalculateIslemKasa(double miktar)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KodRobotClass DeepCopy()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EmirGonder(double miktarX, string aciklamaX, long robotidX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetRobotKey()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SmsGonder(string numara, string mesaj)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KodRobotClass()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static KodRobotClass()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		RunningMode = false;
		RunningDescTime = "";
		RunningDescSure = "";
		IslemList = new List<RobotOrderClass>();
	}
}
