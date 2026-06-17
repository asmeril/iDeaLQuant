using System;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;

namespace ideal;

[Serializable]
public class PgcPozisyonClass
{
	public string RobotID;

	public string Sembol;

	public decimal Miktar;

	public decimal Pozisyon;

	public string SinyalTarih;

	public decimal SinyalFiyat;

	public string Aciklama;

	public int SanalModTip;

	public string Hesap;

	public string AltHesap;

	public int KurumSayisi;

	public int SureTip;

	public int SureSaniye;

	public int SureDakika;

	public int VeriTip;

	public decimal BreakLevel;

	public int YonTip;

	public decimal StopYuzde;

	public decimal KarAlYuzde;

	public string Durum;

	public bool AksamKapatBool;

	public string AksamKapatSaat;

	public int LotTlTip;

	public bool GunYuzdeBuyukBool;

	public decimal GunYuzdeBuyukVal;

	public bool GunYuzdeKucukBool;

	public decimal GunYuzdeKucukVal;

	public bool GunLotBuyukBool;

	public decimal GunLotBuyukVal;

	public bool GunHacimBuyukBool;

	public decimal GunHacimBuyukVal;

	[NonSerialized]
	public bool PrevBool;

	[NonSerialized]
	public double PrevVal;

	[NonSerialized]
	public double LastVal;

	[NonSerialized]
	public int GunStatus;

	public bool AcigaSatisBool;

	[NonSerialized]
	public decimal SonFiyat;

	[NonSerialized]
	public decimal SonDeger;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EmirGonder(decimal miktarX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SmsGonder(decimal miktarX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string VeriTipToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PgcPozisyonClass()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static PgcPozisyonClass()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
