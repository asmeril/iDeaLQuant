using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class RoboTradeClass
{
	public long RoboTradeID;

	public double Miktar;

	public double Pozisyon;

	public string IslemSembol;

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

	public decimal AlisFiyat;

	public decimal DonusKademe;

	public decimal StopKademe;

	public bool StopKullanBool;

	public int CiftYonKullanBool;

	public bool StoplandiBool;

	public string Durum;

	public string Isim;

	[NonSerialized]
	public double KZ;

	public static bool RunningMode;

	public static int RunningRowNo;

	public static string RunningDescription;

	public static List<RobotOrderClass> IslemList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EmirGonder(double miktarX, string aciklamaX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RoboTradeClass()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoboTradeClass()
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
