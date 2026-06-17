using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class HedefClass
{
	public string RobotName;

	public DateTime RobotCreateTime;

	public DateTime RobotUpdateTime;

	public decimal TL;

	public double Pozisyon;

	public int GercekSanal;

	public int AktifPasif;

	public string Hesap1;

	public string AltHesap1;

	public string Hesap2;

	public string AltHesap2;

	public string StratejiTip;

	public string Symbol1;

	public string Symbol2;

	public string Symbol3;

	public decimal SpotKomisyon;

	public decimal ViopKomisyon;

	public decimal TakasKomisyon;

	public decimal Temettu;

	public decimal Esik;

	public decimal KademeFark;

	public string BaslaSaat;

	public string BaslaSaat2;

	public string BitisSaat;

	public string BitisSaat2;

	public double MinEmirMiktar;

	public double MaxEmirMiktar;

	public double MaxPozisyon;

	public float YakinSpread;

	public float UzakSpread;

	public static bool RunningMode;

	public static string RunningRobot;

	public static string RunningStrateji;

	public static bool ModifiedBool;

	public static string HedefDirectory;

	public static string HedefDirectoryLog;

	public static string HedefDirectoryIslemLog;

	public static Dictionary<string, HedefClass> Robotlar;

	public static List<HedefEmirClass> EmirList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string DurumToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string StatusToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Deserialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RobotRun()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void LogError(string errorTxt)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void LogHedefServis(string errorTxt)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IslemGonderimBool(string prefiX)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HedefClass()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static HedefClass()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		RunningMode = false;
		RunningRobot = "";
		RunningStrateji = "";
		ModifiedBool = false;
		HedefDirectory = MfFTrg5y0jcZlPpwbv.r7iItWL60(cxDir.Root, "\\HedefPortfoy", MfFTrg5y0jcZlPpwbv.VqaBlIV2g);
		HedefDirectoryLog = MfFTrg5y0jcZlPpwbv.r7iItWL60(cxDir.Root, "\\HedefPortfoy\\Log", MfFTrg5y0jcZlPpwbv.VqaBlIV2g);
		HedefDirectoryIslemLog = MfFTrg5y0jcZlPpwbv.r7iItWL60(cxDir.Root, "\\HedefPortfoy\\IslemLog\\", MfFTrg5y0jcZlPpwbv.VqaBlIV2g);
		Robotlar = new Dictionary<string, HedefClass>();
		EmirList = new List<HedefEmirClass>();
	}
}
