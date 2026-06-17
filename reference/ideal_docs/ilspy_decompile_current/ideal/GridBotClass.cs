using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class GridBotClass
{
	public long ID;

	public decimal Miktar;

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

	public int IzgaraTip;

	public decimal AltFiyat;

	public decimal IzgaraCount;

	public decimal IzgaraAdim;

	public bool StopKullanBool;

	public decimal StopLevel;

	public bool KarAlBool;

	public decimal KarAlLevel;

	public int CiftYonKullanBool;

	public bool StoplandiBool;

	public string Durum;

	public string Isim;

	public bool ZararBool;

	public decimal ZararLevel;

	public bool EmirLimitBool;

	public int EmirLimitVal;

	public decimal AlisLot;

	public decimal AlisVol;

	public decimal SatisLot;

	public decimal SatisVol;

	public decimal SonSeviye;

	public decimal StartPrice;

	public decimal KZ;

	public decimal AOrt;

	public decimal SOrt;

	public List<DateTime> EmirTimeList;

	public bool KodStartBool;

	public static bool RunningMode;

	public static int RunningRowNo;

	public static string RunningDescription;

	public static List<RobotOrderClass> IslemList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<decimal> GetIzgaraFiyatList(int tipX, decimal countX, decimal altfiyatX, decimal adimX)
	{
		return null;
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
	public List<decimal> GetIzgaraFiyatList()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GridBotClass()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GridBotClass()
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
