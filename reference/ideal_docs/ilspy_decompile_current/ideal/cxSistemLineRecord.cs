using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;

namespace ideal;

[Serializable]
public class cxSistemLineRecord
{
	public string Aciklama;

	public bool ActiveBool;

	public int Panel;

	public int FrameNo;

	public Color Renk;

	public Color Color;

	public int Kalinlik;

	public int Stil;

	[NonSerialized]
	public List<float> Deger;

	[NonSerialized]
	public List<Color> RenkListesi;

	[NonSerialized]
	public int BarKaydir;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxSistemLineRecord()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static cxSistemLineRecord()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
