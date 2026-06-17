using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;

namespace ideal;

[Serializable]
public class SepetGetiriRecord
{
	[Serializable]
	public class SembolRecord
	{
		public string SembolName;

		public string SistemName;

		public string Period;

		public float Kayma;

		public float Miktar;

		public int Kalinlik;

		public Color Renk;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SembolRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SembolRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public string SepetName;

	public List<SembolRecord> SembolList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SepetGetiriRecord DeepCopy()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SepetGetiriRecord()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SepetGetiriRecord()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
