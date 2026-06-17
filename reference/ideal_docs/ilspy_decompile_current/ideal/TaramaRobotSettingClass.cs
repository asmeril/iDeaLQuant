using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class TaramaRobotSettingClass
{
	public List<string> TaramaList;

	public List<string> SembolList;

	public Dictionary<string, TaramaPozisyonClass> Pozisyonlar;

	public Dictionary<string, TaramaRobotSettingClass> AyarDict;

	public decimal TL;

	public int MaxPozisyon;

	public decimal IzleyenYuzde;

	public decimal KarAlYuzde;

	public string BaslangicSaat;

	public string KapanisSaat;

	public bool AksamPozKapatBool;

	public string AksamPozKapatSaat;

	public bool SurePozKapatBool;

	public int SurePozKapatDakika;

	public bool KardaPozKapatBool;

	public int KardaPozKapatDakika;

	public bool PozisyonKapanincaIslemAcmaBool;

	public int PozisyonKapanincaIslemAcmaDakika;

	public decimal MinHisseFiyat;

	public decimal MaxHisseFiyat;

	public bool GundeBirKere;

	public string Hesap;

	public string AltHesap;

	public bool YukseldiyseBool;

	public decimal YukseldiyseYuzde;

	public int SanalGercek;

	public int KapanisCanliBar;

	public static bool RunningMode;

	public static int RunningRowNo;

	public static string RunningTarama;

	public static string RunningSembol;

	public static int RunningSure;

	public static bool ModifiedBool;

	public int HisseMaxTarama;

	public bool AksamKarKapatBool;

	public string AksamKarKapatSaat;

	public int AksamKarKapatGun;

	public bool AksamZararKapatBool;

	public string AksamZararKapatSaat;

	public int AksamZararKapatGun;

	public bool SeviyeIzleyenBool;

	public decimal SeviyeIzleyenYuzde;

	public decimal SeviyeIzleyenStop;

	public bool EndeksKucukAlmaBool;

	public string EndeksKucukAlmaSembol;

	public decimal EndeksKucukAlmaVal;

	public bool EndeksBuyukAlmaBool;

	public string EndeksBuyukAlmaSembol;

	public decimal EndeksBuyukAlmaVal;

	public bool EndeksKucukKapatBool;

	public string EndeksKucukKapatSembol;

	public decimal EndeksKucukKapatVal;

	public int EndeksKucukKapatGun;

	public bool EndeksBuyukKapatBool;

	public string EndeksBuyukKapatSembol;

	public decimal EndeksBuyukKapatVal;

	public int EndeksBuyukKapatGun;

	public bool KodlaKapatBool;

	public string KodlaKapatSistem;

	public string KodlaKapatPeriyot;

	public bool SistemleKapatBool;

	public static TaramaRobotSettingClass Setting;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Deserialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TaramaPozisyonClass GetPozisyon(string tarama, string sembol)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPozisyon(string tarama, string sembol, TaramaPozisyonClass item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TaramaRobotSettingClass()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaramaRobotSettingClass()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		RunningMode = false;
		RunningRowNo = 0;
		RunningTarama = "";
		RunningSembol = "";
		RunningSure = 0;
		ModifiedBool = false;
		Setting = new TaramaRobotSettingClass();
	}
}
