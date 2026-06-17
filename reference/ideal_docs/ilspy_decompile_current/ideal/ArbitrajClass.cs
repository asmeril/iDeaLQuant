using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class ArbitrajClass
{
	public long ID;

	public string Sembol1;

	public double Miktar1;

	public double Pozisyon1;

	public string Sembol2;

	public double Miktar2;

	public double Pozisyon2;

	public decimal Spread1;

	public decimal Spread2;

	public decimal SpreadDenge;

	public string Hesap;

	public string AltHesap;

	public int AktifPasif;

	public int GercekSanal;

	public string BaslangicSaat;

	public string KapanisSaat;

	public bool AksamPozKapatBool;

	public bool CumaPozKapatBool;

	public string AksamPozKapatSaat;

	public string CumaPozKapatSaat;

	public bool DengedePozKapatBool;

	public static bool RunningMode;

	public static int RunningRowNo;

	public static string RunningDescription;

	public static List<RobotOrderClass> IslemList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EmirGonder(int sembolnoX, double miktarX, string aciklamaX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SmsGonder(string numara, string mesaj)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MailGonder(string mesaj)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ArbitrajClass()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ArbitrajClass()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		RunningMode = false;
		RunningRowNo = -1;
		RunningDescription = "";
		IslemList = new List<RobotOrderClass>();
	}
}
