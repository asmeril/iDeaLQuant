using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class PacalBotClass
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

	public bool StopKullanBool;

	public decimal StopLevel;

	public bool KarAlBool;

	public decimal KarAlLevel;

	public bool StoplandiBool;

	public string Durum;

	public string Isim;

	public int SeviyeTip;

	public decimal BaslangicFiyat;

	public int YonTip;

	public decimal MaliyetMarjLevel;

	public List<SeviyeClass> SeviyeList;

	public bool ZararBool;

	public decimal ZararLevel;

	public bool EmirLimitBool;

	public int EmirLimitVal;

	public decimal AlisLot;

	public decimal AlisVol;

	public decimal SatisLot;

	public decimal SatisVol;

	public decimal SonSeviye;

	[NonSerialized]
	public decimal KZ;

	[NonSerialized]
	public decimal AOrt;

	[NonSerialized]
	public decimal SOrt;

	[NonSerialized]
	public decimal Maliyet1;

	[NonSerialized]
	public decimal Maliyet2;

	[NonSerialized]
	public decimal Stop;

	[NonSerialized]
	public List<DateTime> EmirTimeList;

	public static bool RunningMode;

	public static int RunningRowNo;

	public static string RunningDescription;

	public static List<RobotOrderClass> IslemList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PacalBotClass()
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
	public List<SeviyeClass> GetIzgaraFiyatList()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static PacalBotClass()
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
