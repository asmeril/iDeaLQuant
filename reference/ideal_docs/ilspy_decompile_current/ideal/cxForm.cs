using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

internal class cxForm
{
	public static Application ExcellApp;

	public static int MaxFormNo;

	public static int MinFormNo;

	public static bool WorkSpaceBool;

	public static byte[] MemoryBytes;

	public static string MemorySymbols;

	public static int ScreenLeft;

	public static int ScreenTop;

	public static int ScreenWidth;

	public static int ScreenHeight;

	public static string ActiveSymbol;

	public static Form ActiveForm;

	public static List<FormControl> MinimizedFormList;

	public static bool WatchlistMarketMenuDisplayed;

	public static Color[] PieColors;

	public static Color HeaderBorderColor;

	public static Color HeaderBackColor1;

	public static Color HeaderBackColor2;

	public static Color HeaderButtonPassiveColor;

	public static Color HeaderButtonActiveColor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ClearWorkspace()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ConvertBytestoForms(byte[] bytesX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] ConvertFormToBytes(Form formX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DeleteWorkspace(string workspaceX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Point GetCursorPos(Control controlX)
	{
		return (Point)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<string> GetSymbolListFilenames()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<string> GetSymbolListSymbols(string filenameX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Workbook GetExcelWorkbook(string filenameX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Workbook OpenExcelWorkbook(string filenameX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void FillWorkspaceList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void LoadWorkspace()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void MinimizeForm(FormControl formcontrolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ProcessFunctionKey(Keys keyData)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RunExcel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SaveWorkspace(string workspaceX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SendMenuMessage(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetPieColors()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowAccounts()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowAlerts()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowBalancesheet(string symbolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowTrendAlarm()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowBalanceSummary(int leftX, int topX, string symbolX, cxPage.Step pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowBasicFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowBrutTakas()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowBuySellCripto(Point pointX, string symbolX, string buysellX, double priceX, string amountX, cxPage.BuySell pageparamsX, bool topmostX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowBuySellCriptoFuture(Point pointX, string symbolX, string buysellX, double priceX, string amountX, cxPage.BuySell pageparamsX, bool topmostX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowBuySellNFT(Point pointX, string symbolX, string buysellX, double priceX, string amountX, cxPage.BuySell pageparamsX, bool topmostX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowBuySellImkb(Point pointX, string symbolX, string buysellX, double priceX, string amountX, cxPage.BuySell pageparamsX, bool topmostX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowBuySellDerinlik(Point pointX, string symbolX, string buysellX, double priceX, string amountX, cxPage.DepBuySell pageparamsX, bool topmostX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowBuySellVip(Point pointX, string symbolX, string buysellX, string pricetypeX, double priceX, string amountX, cxPage.BuySell pageparamsX, bool topmostX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowBuySellFon(Point pointX, string symbolX, string buysellX, double priceX, string amountX, cxPage.BuySell pageparamsX, bool topmostX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowCapital(string symbolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowChart(string symbolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowClock(int leftX, int topX, cxPage.Clock pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowCompany(string symbolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowConnection()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowDepthBond(int leftX, int topX, string symbolX, cxPage.Depth pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowDepthBorrow(int leftX, int topX, string symbolX, cxPage.Depth pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowDepthClearing(int leftX, int topX, string symbolX, cxPage.Depth pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowDepthGeneral()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowDepthCripto(int leftX, int topX, string symbolX, cxPage.Depth pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowDepthNFT(int leftX, int topX, string symbolX, cxPage.Depth pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowDepthImkb(int leftX, int topX, string symbolX, cxPage.Depth pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowEmirSira(int leftX, int topX, string symbolX, cxPage.Depth pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowDepthMulti(List<string> symbollistX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowDepthRepo(int leftX, int topX, string symbolX, cxPage.Depth pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowDepthSase(int leftX, int topX, string symbolX, cxPage.Depth pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowDepthVip(int leftX, int topX, string symbolX, cxPage.Depth pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowDepthTurib(int leftX, int topX, string symbolX, cxPage.Depth pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowDetail(int leftX, int topX, string symbolX, cxPage.Detail pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowDistribution(string symbolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowDagilimPite(string symbolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowDownloadChart()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowError()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowHesap(string accountnameX, string accountnoX, string piyasaX, string tabX, cxPage.BuySell pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowIndicatorValues()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ShowInputBox(string headerX, string promptX, string defaultX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowInterbankBest(int leftX, int topX, cxPage.Interbank pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowInterbankTable(int leftX, int topX, cxPage.Interbank pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowIslemOzet(string accountnameX, string accountnoX, string symbolX, cxPage.BuySell pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowKademeIslem(string accountnameX, string accountnoX, string symbolX, cxPage.BuySell pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowHacim(cxPage.BuySell pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowKurumHacim()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowMacro()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowGetiriGrafik()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowMedia(int medianoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowMessenger()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowNewsAlert()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowNewsBulten()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowNewsContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowNewsHeader(int leftX, int topX, int filterstatusX, string searchstringX, string symbolstringX, cxPage.NewsHeader pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowNewVersionBox(string uyari = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowObserve()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowPgcChart(int leftX, int topX, string symbolX, cxPage.Pgc pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowHisseGenel(int leftX, int topX, string symbolX, cxPage.Pgc pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowPortfolio()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowFixPortfolio(string tabPageName = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowOmsPortfoy(string tabPageName = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowPortfolioSetting()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowRefreshMonitor()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowServerReceiver()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowSira()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowSistemOptimizer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowSistemSorgu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowStep(int leftX, int topX, string symbolX, cxPage.Step pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowStockDistribution(string symbolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowStockPerformance(int leftX, int topX, string symbolX, cxPage.Step pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowTakas(string symbolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowTakasList(int leftX, int topX, string symbolX, cxPage.Step pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowTimeSales(int leftX, int topX, string symbolX, cxPage.Depth pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowTcmb(int leftX, int topX, string pagekeyX, cxPage.Tcmb pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowToolbox()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowWatchlist(int leftX, int topX, string marketX, cxPage.Watchlist fieldsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowWebServer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowRiskKontrol()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowRobokep()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxForm()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static cxForm()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		MaxFormNo = 0;
		MinFormNo = 0;
		WorkSpaceBool = false;
		MemoryBytes = new byte[0];
		MemorySymbols = "";
		ScreenLeft = 0;
		ScreenTop = 0;
		ScreenWidth = 0;
		ScreenHeight = 0;
		ActiveSymbol = "";
		ActiveForm = null;
		MinimizedFormList = new List<FormControl>();
		WatchlistMarketMenuDisplayed = false;
		HeaderBorderColor = G2EdG5ZqjwWcrjoXdB8.r7iItWL60(G2EdG5ZqjwWcrjoXdB8.OyoZfgolHL);
		HeaderBackColor1 = QydtveTePRRXd343nfj.r7iItWL60(QydtveTePRRXd343nfj.na2TZsWUEF);
		HeaderBackColor2 = QydtveTePRRXd343nfj.r7iItWL60(QydtveTePRRXd343nfj.U4wTD3wlgB);
		HeaderButtonPassiveColor = VmnMVgTR7qQiWjMnyCe.r7iItWL60(VmnMVgTR7qQiWjMnyCe.mGr1Vr13wk);
		HeaderButtonActiveColor = QydtveTePRRXd343nfj.r7iItWL60(QydtveTePRRXd343nfj.OrMTqUcBK6);
	}
}
