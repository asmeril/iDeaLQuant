using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class NagantsRobotClass
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

	public int AktifPasif;

	public int GercekSanal;

	public string BaslangicSaat;

	public string KapanisSaat;

	public bool AksamPozKapatBool;

	public bool AksamAlisKapatBool;

	public bool AksamSatisKapatBool;

	public bool CumaPozKapatBool;

	public string AksamPozKapatSaat;

	public string CumaPozKapatSaat;

	public bool AcigaSatisBool;

	public string SinyalTarih;

	public string PrevSinyalTarih;

	public bool YeniSinyalBekle;

	public static bool RunningMode;

	public static int RunningRowNo;

	public static string RunningDescription;

	public static List<RobotOrderClass> IslemList;

	public string PozTasiIslemSembol;

	public bool PozisyonTasiBool;

	public int PozisyonTasiKalanGun;

	public string PozisyonTasiSaat;

	public string SonPozisyonDegistirmeZamani;

	[NonSerialized]
	public bool PozTasiAktif;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool PozTasiGunSembolHesapla(out string yeniVadeSembolX)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EmirGonder(double miktarX, string aciklamaX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MailGonder(string mesaj)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SmsGonder(string numara, string mesaj)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetRobotKey()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NagantsRobotClass()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static NagantsRobotClass()
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
