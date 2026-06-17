using System;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class TablomClass
{
	public long TablomID;

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

	public bool AcigaSatisBool;

	public int IlkIslemYon;

	public double IlkIslemFiyat;

	public DateTime IlkIslemTarih;

	public bool IlkIslemBool;

	public double KarAlFiyat;

	public DateTime KarAlTarih;

	public bool KarAlBool;

	public double StopFiyat;

	public DateTime StopTarih;

	public bool StopBool;

	public int StopTip;

	public decimal IzleyenFiyat;

	[NonSerialized]
	public double KZ;

	[NonSerialized]
	public string Durum;

	public static bool RunningMode;

	public static int RunningRowNo;

	public static string RunningDescription;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EmirGonder(double miktarX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TablomClass()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static TablomClass()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		RunningMode = false;
		RunningRowNo = -1;
		RunningDescription = "";
	}
}
