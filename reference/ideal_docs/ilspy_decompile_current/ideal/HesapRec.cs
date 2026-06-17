using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;

namespace ideal;

[Serializable]
public class HesapRec
{
	public string KisaAd;

	public string HesapAd;

	public string AltHesap;

	public string Aciklama;

	public string DropcopyHesap;

	[NonSerialized]
	public List<EmirRec> EmirList;

	[NonSerialized]
	public Dictionary<string, EmirRec> BekleyenDict;

	[NonSerialized]
	public Dictionary<string, List<EmirRec>> EmirUpdateDict;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HesapRec()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static HesapRec()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
