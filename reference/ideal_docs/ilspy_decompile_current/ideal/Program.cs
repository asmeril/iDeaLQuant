using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

internal static class Program
{
	public static System.Timers.Timer LastMethodTimer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[STAThread]
	private static void Main()
	{
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		cxDir.Root = WZEAZNCq9LPdxh5oqF1.r7iItWL60(WZEAZNCq9LPdxh5oqF1.bA0NbEjtnU);
		cxSetting.OperationMode = 2;
		Assembly assembly = A1WmsZvdWEEwqm7EB23.r7iItWL60(A1WmsZvdWEEwqm7EB23.tLgvcTXxyB);
		FileVersionInfo fileVersionInfo = cnbdcLvy6tv9HejtVs4.r7iItWL60(o7H0hOt64KQ3ZErDEO9.r7iItWL60(assembly, o7H0hOt64KQ3ZErDEO9.quuvrCKaFw), cnbdcLvy6tv9HejtVs4.LLAvR7g8ek);
		string version = otrd6JwS8reKf2sc9p.r7iItWL60(bHrV53IpH0AnrEUelcJ.r7iItWL60(o7H0hOt64KQ3ZErDEO9.r7iItWL60(fileVersionInfo, o7H0hOt64KQ3ZErDEO9.X1nvz5cWMC), new char[1] { '.' }, bHrV53IpH0AnrEUelcJ.CREIh0JrVd)[0], ".", bHrV53IpH0AnrEUelcJ.r7iItWL60(o7H0hOt64KQ3ZErDEO9.r7iItWL60(fileVersionInfo, o7H0hOt64KQ3ZErDEO9.X1nvz5cWMC), new char[1] { '.' }, bHrV53IpH0AnrEUelcJ.CREIh0JrVd)[1], bHrV53IpH0AnrEUelcJ.r7iItWL60(o7H0hOt64KQ3ZErDEO9.r7iItWL60(fileVersionInfo, o7H0hOt64KQ3ZErDEO9.X1nvz5cWMC), new char[1] { '.' }, bHrV53IpH0AnrEUelcJ.CREIh0JrVd)[2], otrd6JwS8reKf2sc9p.J9J3ehWP1);
		string text = bHrV53IpH0AnrEUelcJ.r7iItWL60(o7H0hOt64KQ3ZErDEO9.r7iItWL60(fileVersionInfo, o7H0hOt64KQ3ZErDEO9.X1nvz5cWMC), new char[1] { '.' }, bHrV53IpH0AnrEUelcJ.CREIh0JrVd)[3];
		cxSetting.Version = version;
		string text2 = WZEAZNCq9LPdxh5oqF1.r7iItWL60(WZEAZNCq9LPdxh5oqF1.mM3CCyecEP);
		if (NwbWAV09QBXX076a8H.r7iItWL60(text2, "DESKTOP-HTQON31", NwbWAV09QBXX076a8H.yEHPEPwSP))
		{
		}
		if (NwbWAV09QBXX076a8H.r7iItWL60(text2, "IDEAL-CNGZ23", NwbWAV09QBXX076a8H.yEHPEPwSP))
		{
		}
		if (NwbWAV09QBXX076a8H.r7iItWL60(text2, "IDNB-KERIMYALCI", NwbWAV09QBXX076a8H.yEHPEPwSP))
		{
			cxDir.Root = "D:\\iDeal2";
			cxHelper.ConsoleWriteEnable = true;
		}
		if (cxSetting.IndirVersion)
		{
			cxSetting.BetaVersion = "indir Versiyon";
		}
		Random random = new Random();
		int num = GBbayJq9KuqRgwSjxSL.r7iItWL60(random, 0, 2000000000, GBbayJq9KuqRgwSjxSL.i9NqSKulou);
		cxSetting.SessionID = NRNiQbqbqx5n6lNJe21.r7iItWL60(ref num, "0", NRNiQbqbqx5n6lNJe21.EsGqdnjfQ3);
		G118eyNZXujbyQm4Idg.r7iItWL60(G118eyNZXujbyQm4Idg.ml7OATZ5V3);
		chpihLOIWsdrEbS1Wwk.r7iItWL60(false, chpihLOIWsdrEbS1Wwk.gVCOT4QLfm);
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		X9Zdrw1cQO7TE87mZD1.r7iItWL60(cxTime.Tick, X9Zdrw1cQO7TE87mZD1.AlmS67eWwZ);
		cxDir.Init();
		cxFile.Init();
		string text3 = MfFTrg5y0jcZlPpwbv.r7iItWL60(cxDir.Config, "\\MultiUser.Txt", MfFTrg5y0jcZlPpwbv.VqaBlIV2g);
		if (!Jr8wAYIsJDt2ig9hiA8.r7iItWL60(text3, Jr8wAYIsJDt2ig9hiA8.PAAIFNO63L))
		{
			string text4 = zduMpLiMCWWDr5Gtfhv.r7iItWL60(dGvhldXlviwQmnnD8jS.r7iItWL60(dGvhldXlviwQmnnD8jS.XBVXXbAyLD), zduMpLiMCWWDr5Gtfhv.OLV2RUCZyK);
			Process[] array = mqpQVyOm4yViIIERpnZ.r7iItWL60(text4, mqpQVyOm4yViIIERpnZ.BgvOWcDlMs);
			if (array.Length > 1)
			{
				I0MId5ZDNnvem1uBW7s.r7iItWL60("Program Zaten Çalışıyor (!)", I0MId5ZDNnvem1uBW7s.OPRZLMcvZu);
				return;
			}
		}
		c55bdAOeAl1D6eym78K.r7iItWL60(Application_ThreadException, c55bdAOeAl1D6eym78K.SyqOqv3Ujb);
		Gtwl0kOFWTcLLBpE0h8.r7iItWL60(XMwFJaOCBGHycHZLFbT.r7iItWL60(XMwFJaOCBGHycHZLFbT.plSOsbBTRx), CurrentDomain_UnhandledException, Gtwl0kOFWTcLLBpE0h8.P9yOjaXBQu);
		VoBFpLOxCOvLNSXtjER.r7iItWL60((Form)(object)new MainForm(), VoBFpLOxCOvLNSXtjER.ef1OMpUmha);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void LastMethodTimer_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Program()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		LastMethodTimer = new System.Timers.Timer();
	}
}
