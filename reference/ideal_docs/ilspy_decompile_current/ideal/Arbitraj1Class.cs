using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class Arbitraj1Class
{
	public string Isim;

	public long ID;

	public string SpotSembol;

	public string Sembol1;

	public decimal IslemFiyat1;

	public string Sembol2;

	public decimal IslemFiyat2;

	public decimal Miktar;

	public decimal Pozisyon;

	public string Hesap;

	public string AltHesap;

	public bool AksamPozKapatBool;

	public bool CumaPozKapatBool;

	public string AksamPozKapatSaat;

	public string CumaPozKapatSaat;

	public string BaslangicSaat;

	public string KapanisSaat;

	public bool FaizIslemAcBool;

	public decimal FaizIslemAcVal;

	public bool SpreadIslemAcBool;

	public decimal SpreadIslemAcVal;

	public bool FaizIslemKapatBool;

	public decimal FaizIslemKapatVal;

	public bool SpreadIslemKapatBool;

	public decimal SpreadIslemKapatVal;

	public int FaizSpreadTip;

	public bool SeciliBool;

	public static bool RunningMode;

	public static string RunningDescription;

	public static List<RobotOrderClass> IslemList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalculateKZ()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EmirGonder(string sembolX, decimal miktarX, decimal fiyatX, string emirTipX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Arbitraj1Class()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Arbitraj1Class()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		RunningMode = false;
		RunningDescription = "";
		IslemList = new List<RobotOrderClass>();
	}
}
