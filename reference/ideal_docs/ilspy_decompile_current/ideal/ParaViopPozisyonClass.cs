using System;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;

namespace ideal;

[Serializable]
public class ParaViopPozisyonClass
{
	public decimal Miktar;

	public decimal Pozisyon;

	public string SistemName;

	public string SinyalTarih;

	public string SinyalYon;

	public decimal SinyalFiyat;

	public string Aciklama;

	public bool GercekModBool;

	public string Hesap;

	public string AltHesap;

	public string AnalizSembol;

	public string IslemSembol;

	public bool AcigaSatisBool;

	[NonSerialized]
	public decimal SonFiyat;

	[NonSerialized]
	public string SinyalPatern;

	[NonSerialized]
	public string SinyalBarNo;

	[NonSerialized]
	public string PrevTarih;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EmirGonder(decimal miktarX, ParaViopPozisyonClass pozisyonitem)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SmsGonder(decimal miktarX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ParaViopPozisyonClass()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParaViopPozisyonClass()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
