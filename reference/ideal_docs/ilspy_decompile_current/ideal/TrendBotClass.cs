using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class TrendBotClass
{
	public long ID;

	public decimal Pozisyon;

	public string Sembol;

	public string Hesap;

	public string AltHesap;

	public int AktifPasif;

	public int GercekSanal;

	public string BaslangicSaat;

	public string KapanisSaat;

	public bool AksamPozKapatBool;

	public bool CumaPozKapatBool;

	public bool SoundBool;

	public string AksamPozKapatSaat;

	public string CumaPozKapatSaat;

	public bool AlisYonBool;

	public bool SatisYonBool;

	public bool StoplandiBool;

	public bool KarAldiBool;

	public string Durum;

	public string Isim;

	public bool ZararBool;

	public decimal ZararLevel;

	public bool EmirLimitBool;

	public int EmirLimitVal;

	public bool KarAlBool;

	public decimal KarAlLevel;

	public List<TrendBotLineClass> BuyLevelList;

	public List<TrendBotLineClass> SellLevelList;

	public decimal AlisLot;

	public decimal AlisVol;

	public decimal SatisLot;

	public decimal SatisVol;

	[NonSerialized]
	public decimal KZ;

	[NonSerialized]
	public decimal AOrt;

	[NonSerialized]
	public decimal SOrt;

	[NonSerialized]
	public List<DateTime> EmirTimeList;

	[NonSerialized]
	public bool KodStartBool;

	public static bool RunningMode;

	public static int RunningRowNo;

	public static string RunningDescription;

	public static List<RobotOrderClass> IslemList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TrendBotClass()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalculateKZ()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EmirGonder(decimal miktarX, string aciklamaX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static TrendBotClass()
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
