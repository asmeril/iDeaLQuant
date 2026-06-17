using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class SablonRobotClass
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

	[NonSerialized]
	public string SinyalTarih;

	[NonSerialized]
	public string PrevSinyalTarih;

	public string PozTasiIslemSembol;

	public bool PozisyonTasiBool;

	public int PozisyonTasiKalanGun;

	public string PozisyonTasiSaat;

	public string SonPozisyonDegistirmeZamani;

	public bool BarKapanmadanSaniyeBool;

	public int BarKapanmadanSaniye;

	public bool PortfoyKontrolBool;

	public bool SonSinyalBool;

	public string SonSinyalSaat;

	[NonSerialized]
	public bool PozTasiAktif;

	[NonSerialized]
	public float GunKz;

	[NonSerialized]
	public int GunStatus;

	[NonSerialized]
	public string GunDurum;

	public static double PortfoyGunKz;

	public static double PortfoyGunMaxKz;

	public static double PortfoyGunMinKz;

	public static double PortfoyGunStopLevel;

	public static bool RunningMode;

	public static DateTime StartTime;

	public static string RunningDescription;

	public static int RunningCount;

	public static List<RobotOrderClass> IslemList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EmirGonder(double miktarX, string aciklamaX, long robotidX)
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
	public string GetRobotKey()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool PozTasiGunSembolHesapla(out string yeniVadeSembolX)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GunKzHesapla()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SablonRobotClass DeepCopy()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SablonRobotClass()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SablonRobotClass()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		PortfoyGunKz = 0.0;
		PortfoyGunMaxKz = 0.0;
		PortfoyGunMinKz = 0.0;
		PortfoyGunStopLevel = 0.0;
		RunningMode = false;
		StartTime = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
		RunningDescription = "";
		RunningCount = 0;
		IslemList = new List<RobotOrderClass>();
	}
}
