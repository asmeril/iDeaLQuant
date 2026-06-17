using System.Collections.Generic;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class cxIslemDagilim
{
	public int KurumID;

	public int SembolID;

	public double AlisLot;

	public double AlisHacim;

	public double AlisMaliyet;

	public double SatisLot;

	public double SatisHacim;

	public double SatisMaliyet;

	public double NetLot;

	public double NetHacim;

	public double NetMaliyet;

	public double ToplamLot;

	public double ToplamHacim;

	public double NetHacimY;

	public double KZ;

	public string KurumName;

	public string SembolName;

	public float LastPrice;

	public static Dictionary<int, Dictionary<int, cxIslemDagilim>> KurumHisseMap;

	public static Dictionary<int, Dictionary<int, cxIslemDagilim>> HisseKurumMap;

	public static Dictionary<int, cxIslemDagilim> MaksAlanMap;

	public static Dictionary<int, cxIslemDagilim> MaksSatanMap;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddIslem(IslemStruct1 islem)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static cxIslemDagilim GetIslemDagilim(string kurum, string sembol)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static cxIslemDagilim GetIslemDagilim(int kurumid, string sembol)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static cxIslemDagilim GetMaksAlan(string sembol)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static cxIslemDagilim GetMaksSatan(string sembol)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double Pgc5Lot(string sembol)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double Pgc5SatisToplam(string sembol)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double Pgc5AlisToplam(string sembol)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double AlisToplamTum(string sembol)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double SatisToplamTum(string sembol)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double Pgc5Oran(string sembol)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double Pgc5Tl(string sembol)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double Pgc5TlAlisToplam(string sembol)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double Pgc5TlSatisToplam(string sembol)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double Pgc5TlOran(string sembol)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double MaksAlanYuzde(string sembol)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double MaksSatanYuzde(string sembol)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static PGCKurumMaliyet PGCKurummaliyet(string sembolX, int kurumsayisiX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static PgcClass Pgc(string sembolX, int kurumsayisiX, int suretipX, int sureX, int lottltipX, int veritipX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<cxIslemDagilim> GetOneCikan(double netfilter, double yuzdefilter)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxIslemDagilim()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static cxIslemDagilim()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		KurumHisseMap = new Dictionary<int, Dictionary<int, cxIslemDagilim>>();
		HisseKurumMap = new Dictionary<int, Dictionary<int, cxIslemDagilim>>();
		MaksAlanMap = new Dictionary<int, cxIslemDagilim>();
		MaksSatanMap = new Dictionary<int, cxIslemDagilim>();
	}
}
