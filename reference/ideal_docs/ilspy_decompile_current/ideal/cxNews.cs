using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class cxNews
{
	public class Alert
	{
		public string AlertType;

		public string Kriter;

		public static List<Alert> DefinitionList;

		public static Dictionary<long, cxNews> NewsDictionary;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ReadAlerts()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void WriteAlerts()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Alert()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Alert()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			WP6RZJql8gZrNhVA9v.w65ov7siki();
			hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
			DefinitionList = new List<Alert>();
			NewsDictionary = new Dictionary<long, cxNews>();
		}
	}

	public long NewsID;

	public long ChainID;

	public DateTime Date;

	public int NewsNo;

	public string Stock;

	public string Status;

	public string Catagory;

	public string Link;

	public string Source;

	public string Header;

	public string Manset;

	public string FileName;

	[NonSerialized]
	public StringBuilder ContentSB;

	[NonSerialized]
	public DateTime ReceiveTime;

	[NonSerialized]
	public long WebUpdateTime;

	public static bool ReadBool;

	public static Dictionary<long, cxNews> Dictionary;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Deserialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ReadContent()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WriteContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxNews()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static cxNews()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		ReadBool = false;
		Dictionary = new Dictionary<long, cxNews>();
	}
}
