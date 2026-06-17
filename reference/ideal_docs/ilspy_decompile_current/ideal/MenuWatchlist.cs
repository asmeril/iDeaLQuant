using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class MenuWatchlist : Form
{
	public static MenuWatchlist Reference;

	private IContainer components;

	public ContextMenuStrip SubMenu;

	private ToolStripMenuItem Property;

	private ToolStripMenuItem PropertyMemCopy;

	public ToolStripMenuItem PropertyTopmost;

	private ToolStripMenuItem PropertyStatic;

	private ToolStripSeparator toolStripSeparator11;

	private ToolStripMenuItem PropertyColor;

	private ToolStripMenuItem PropertyFont;

	private ToolStripMenuItem PropertyHeaderName;

	public ToolStripMenuItem PropertyHeader;

	public ToolStripMenuItem PropertyVipFilter;

	public ToolStripMenuItem PropertyVscroll;

	public ToolStripMenuItem PropertyGridlines;

	public ToolStripMenuItem PropertyActiveColor;

	public ToolStripMenuItem PropertyRelational;

	public ToolStripMenuItem PropertyLinespace;

	public ToolStripMenuItem PropertyCurrency;

	public ToolStripMenuItem PropertyCurrencyPriceOrj;

	public ToolStripMenuItem PropertyCurrencyPriceUsd;

	public ToolStripMenuItem PropertyCurrencyPriceEur;

	private ToolStripSeparator toolStripSeparator75;

	public ToolStripMenuItem PropertyCurrencyVolumeOrj;

	public ToolStripMenuItem PropertyCurrencyVolumeUsd;

	public ToolStripMenuItem PropertyCurrencyVolumeEur;

	public ToolStripMenuItem Pattern;

	public ToolStripMenuItem PatternSave;

	public ToolStripMenuItem PatternSaveas;

	public ToolStripComboBox PatternChange;

	private ToolStripMenuItem PatternDefault;

	private ToolStripMenuItem PatternDelete;

	private ToolStripMenuItem PatternDeleteAll;

	private ToolStripMenuItem Tool;

	private ToolStripMenuItem ToolExcelCopy;

	public ToolStripMenuItem ToolExcelFile;

	public ToolStripMenuItem ToolExcelPeriodic;

	public ToolStripMenuItem ToolExcelInterval;

	private ToolStripMenuItem ToolJpgCopy;

	private ToolStripMenuItem ToolBmpCopy;

	private ToolStripSeparator toolStripSeparator73;

	private ToolStripMenuItem ToolChartLoop;

	private ToolStripSeparator toolStripSeparator77;

	private ToolStripMenuItem ToolSaveSymbolList;

	private ToolStripMenuItem ToolShowSymbolLists;

	private ToolStripSeparator toolStripSeparator9;

	public ToolStripMenuItem Symbol;

	private ToolStripMenuItem SymbolClear;

	private ToolStripMenuItem SymbolMemCopy;

	private ToolStripMenuItem SymbolMemPaste;

	public ToolStripComboBox SymbolSymbolLists;

	private ToolStripSeparator toolStripSeparator13;

	private ToolStripMenuItem SymbolFromList;

	private ToolStripSeparator toolStripSeparator43;

	private ToolStripMenuItem Symbolmkb;

	private ToolStripMenuItem SymbolImkbGenelAll;

	private ToolStripSeparator toolStripSeparator36;

	private ToolStripMenuItem SymbolImkbGenelStock;

	private ToolStripMenuItem SymbolImkbGenelXU100;

	private ToolStripMenuItem SymbolImkbGenelXU050;

	private ToolStripMenuItem SymbolImkbGenelXU030;

	private ToolStripSeparator toolStripSeparator37;

	private ToolStripMenuItem SymbolImkbGenelVarant;

	private ToolStripMenuItem SymbolImkbGenelSertifika;

	private ToolStripSeparator toolStripSeparator38;

	private ToolStripMenuItem SymbolImkbGenelIndices;

	private ToolStripSeparator toolStripSeparator40;

	private ToolStripComboBox SymbolImkbGenelCombo;

	private ToolStripMenuItem SymbolSelectImkbGrup;

	private ToolStripMenuItem SymbolSelectImkbGrupA;

	private ToolStripMenuItem SymbolSelectImkbGrupB;

	private ToolStripMenuItem SymbolSelectImkbGrupC;

	private ToolStripMenuItem menuWatchListSelectVip;

	private ToolStripMenuItem SymbolVipAllMarketsAll;

	private ToolStripMenuItem SymbolVipAllMarketsFutures;

	private ToolStripMenuItem SymbolVipAllMarketsOptions;

	private ToolStripSeparator toolStripSeparator64;

	private ToolStripMenuItem SymbolVipMainAll;

	private ToolStripMenuItem SymbolVipMainFutures;

	private ToolStripMenuItem SymbolVipMainOptions;

	private ToolStripSeparator toolStripSeparator65;

	private ToolStripMenuItem SymbolVipOzelAll;

	private ToolStripMenuItem SymbolVipOzelFutures;

	private ToolStripMenuItem SymbolVipOzelOptions;

	private ToolStripSeparator toolStripSeparator66;

	private ToolStripMenuItem SymbolVipIlanAll;

	private ToolStripMenuItem SymbolVipIlanFutures;

	private ToolStripMenuItem SymbolVipIlanOptions;

	private ToolStripSeparator toolStripSeparator67;

	private ToolStripMenuItem SymbolVipMainActive;

	private ToolStripMenuItem SymbolMarket;

	private ToolStripMenuItem SymbolMarketTcmbKur;

	private ToolStripMenuItem SymbolMarketInterbankKur;

	private ToolStripMenuItem SymbolMarketInterbankOvernight;

	private ToolStripMenuItem SymbolMarketDovizBufe;

	private ToolStripMenuItem SymbolMarketSerbest;

	private ToolStripMenuItem SymbolMarketBankaGise;

	private ToolStripSeparator toolStripSeparator42;

	private ToolStripMenuItem SymbolMarketPariteler;

	private ToolStripMenuItem SymbolMarketMetals;

	private ToolStripMenuItem SymbolMarketWorldIndices;

	private ToolStripMenuItem SymbolMarketWorldBond;

	private ToolStripMenuItem SymbolMarketDelayedFutures;

	private ToolStripMenuItem SymbolMarketLibor;

	private ToolStripMenuItem SymbolMarketSeveral;

	private ToolStripMenuItem SymbolInternational;

	private ToolStripMenuItem SymbolInternationalAMEX;

	private ToolStripMenuItem SymbolInternationalCBOT;

	private ToolStripMenuItem SymbolInternationalCBOTM;

	private ToolStripMenuItem SymbolInternationalCHIX;

	private ToolStripMenuItem SymbolInternationalCME;

	private ToolStripMenuItem SymbolInternationalCMEM;

	private ToolStripMenuItem SymbolInternationalCOMEX;

	private ToolStripMenuItem SymbolInternationalDJI;

	private ToolStripMenuItem SymbolInternationalEUREX;

	private ToolStripMenuItem SymbolInternationalLSE;

	private ToolStripMenuItem SymbolInternationalNYMEX;

	private ToolStripMenuItem SymbolInternationalNYMEXM;

	private ToolStripMenuItem SymbolInternationalNASDAQ;

	private ToolStripMenuItem SymbolInternationalNYSE;

	private ToolStripMenuItem SymbolInternationalSPI;

	private ToolStripMenuItem SymbolInternationalXETRA;

	private ToolStripMenuItem SymbolGTIS;

	private ToolStripMenuItem SymbolGTISPFX;

	private ToolStripMenuItem SymbolGTISAFX;

	private ToolStripMenuItem SymbolGTISEP;

	private ToolStripMenuItem SymbolGTISFI;

	private ToolStripMenuItem SymbolGTISMM;

	private ToolStripMenuItem SymbolGTISPM;

	private ToolStripMenuItem SymbolGTISSFFX;

	private ToolStripMenuItem Search;

	private ToolStripMenuItem InsertRow;

	private ToolStripMenuItem DeleteRow;

	private ToolStripSeparator toolStripSeparator14;

	private ToolStripMenuItem Depth;

	private ToolStripMenuItem BuyerSeller;

	private ToolStripMenuItem Detail;

	private ToolStripMenuItem Chart;

	private ToolStripMenuItem TimeSales;

	private ToolStripMenuItem Step;

	private ToolStripMenuItem News;

	private ToolStripMenuItem Fundamental;

	private ToolStripMenuItem ClearingBank;

	private ToolStripMenuItem Distribution;

	private ToolStripMenuItem MultiDepth;

	private ToolStripSeparator toolStripSeparator10;

	private ToolStripMenuItem CloseForm;

	private ToolStripSeparator toolStripSeparator1;

	public ToolStripMenuItem PortfolioBuy;

	public ToolStripMenuItem PortfolioSell;

	public ToolStripMenuItem PropertyTitle;

	private ToolStripMenuItem Alert;

	private ToolStripMenuItem PropertySendBack;

	public ToolStripMenuItem PropertyScrollPeriod;

	public ToolStripMenuItem DOM;

	public ToolStripMenuItem PortfolioWindow;

	public ToolStripMenuItem YayinRefresh;

	public ToolStripMenuItem ToolDeleteSymbols;

	private ToolStripMenuItem PgcChart;

	private ToolStripMenuItem CellDdeCopy;

	private ToolStripMenuItem CellDdeTahvilBugun;

	private ToolStripMenuItem CellDdeTahvilYarin;

	private ToolStripMenuItem SymbolSelectImkbGrupD;

	public ToolStripMenuItem SymbolImkbSeri;

	private ToolStripMenuItem SymbolSeri0;

	private ToolStripMenuItem SymbolSeri1;

	private ToolStripMenuItem SymbolSeri2;

	private ToolStripMenuItem SymbolSeri3;

	private ToolStripMenuItem SymbolSeri4;

	private ToolStripMenuItem SymbolSeri5;

	private ToolStripMenuItem SymbolSeri6;

	private ToolStripMenuItem SymbolSeri7;

	private ToolStripMenuItem SymbolSeri8;

	private ToolStripMenuItem SymbolSeri9;

	private ToolStripMenuItem SymbolSeri10;

	private ToolStripMenuItem SymbolSeri11;

	private ToolStripMenuItem SymbolSeri12;

	private ToolStripMenuItem SymbolSeri13;

	private ToolStripMenuItem SymbolSeri14;

	private ToolStripMenuItem SymbolSeri15;

	private ToolStripMenuItem SymbolSeri16;

	private ToolStripMenuItem SymbolSeri17;

	private ToolStripMenuItem SymbolSeri18;

	private ToolStripMenuItem SymbolSeri19;

	private ToolStripMenuItem SymbolMarket0;

	private ToolStripMenuItem SymbolMarket1;

	private ToolStripMenuItem SymbolMarket2;

	private ToolStripMenuItem SymbolMarket3;

	private ToolStripMenuItem SymbolMarket4;

	private ToolStripMenuItem SymbolMarket5;

	private ToolStripMenuItem SymbolMarket6;

	private ToolStripMenuItem SymbolMarket7;

	private ToolStripMenuItem SymbolMarket8;

	private ToolStripMenuItem SymbolMarket9;

	private ToolStripMenuItem SymbolMarket10;

	private ToolStripMenuItem SymbolMarket11;

	private ToolStripMenuItem SymbolMarket12;

	private ToolStripMenuItem SymbolMarket13;

	private ToolStripMenuItem SymbolMarket14;

	private ToolStripMenuItem SymbolMarket15;

	private ToolStripMenuItem SymbolMarket16;

	private ToolStripMenuItem SymbolMarket17;

	private ToolStripMenuItem SymbolMarket18;

	private ToolStripMenuItem SymbolMarket19;

	public ToolStripMenuItem SymbolImkbPiyasa;

	private ToolStripMenuItem DolarBased;

	private ToolStripMenuItem DagilimPite;

	private ToolStripMenuItem DownloadChart;

	private ToolStripMenuItem DownloadChart1;

	private ToolStripMenuItem DownloadChart5;

	private ToolStripMenuItem DownloadChart60;

	private ToolStripMenuItem DownloadChartG;

	private ToolStripMenuItem AlanSatanChart;

	private ToolStripMenuItem Robokep;

	private ToolStripMenuItem SymbolSelectImkbGrupE;

	public ToolStripMenuItem Company;

	private ToolStripMenuItem HisseGenel;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MenuWatchlist()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Alert_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BuyerSeller_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Chart_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearingBank_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CloseForm_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DeleteRow_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Depth_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Detail_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Distribution_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DagilimPite_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DolarBased_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DOM_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Fundamental_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ImkbTrades_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ImkbVarant_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InsertRow_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MultiDepth_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void News_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PatternChange_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PatternDefault_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PatternDelete_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PatternDeleteAll_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PatternSave_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PatternSaveas_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PgcChart_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PortfolioBuy_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PortfolioSell_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PortfolioWindow_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyActiveColor_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyColor_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyCurrencyPriceOrj_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyCurrencyPriceUsd_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyCurrencyPriceEur_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyCurrencyVolumeOrj_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyCurrencyVolumeUsd_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyCurrencyVolumeEur_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyFont_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyHeader_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyHeaderName_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyGridlines_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyLinespace_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyMemCopy_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyRelational_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyScrollPeriod_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertySendBack_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyStatic_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyTitle_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyTopmost_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyVipFilter_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyVscroll_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Search_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolClear_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolMemCopy_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolMemPaste_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolSymbolLists_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolFromList_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolImkbGenelAll_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolImkbGenelCombo_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolImkbGenelIndices_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolImkbGenelSertifika_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolImkbGenelStock_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolImkbGenelVarant_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolImkbGenelXU030_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolImkbGenelXU050_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolImkbGenelXU100_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolImkbPiyasaGelisen_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolImkbPiyasaGozalti_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolImkbPiyasaKurumsal_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolImkbPiyasaSerbest_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolImkbPiyasaUlusal1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolImkbPiyasaUlusal2_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolImkbPiyasaYeniSirket_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolSeri_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolMarket_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolImkbGrupA_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolImkbGrupB_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolImkbGrupC_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolSelectImkbGrupD_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolSelectImkbGrupE_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolVipAllMarketsAll_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolVipAllMarketsFutures_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolVipAllMarketsOptions_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolVipMainAll_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolVipMainFutures_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolVipMainOptions_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolVipOzelAll_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolVipOzelFutures_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolVipOzelOptions_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolVipIlanAll_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolVipIlanFutures_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolVipIlanOptions_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolVipMainActive_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolMarketBankaGise_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolMarketDovizBufe_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolMarketDelayedFutures_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolMarketInterbankKur_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolMarketInterbankOvernight_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolMarketMetals_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolMarketLibor_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolMarketPariteler_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolMarketSerbest_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolMarketSeveral_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolMarketTcmbKur_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolMarketWorldBond_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolMarketWorldIndices_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolInternationalAMEX_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolInternationalCBOT_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolInternationalCBOTM_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolInternationalCHIX_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolInternationalCME_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolInternationalCMEM_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolInternationalCOMEX_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolInternationalDJI_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolInternationalEUREX_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolInternationalLSE_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolInternationalNYMEX_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolInternationalNYMEXM_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolInternationalNASDAQ_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolInternationalNYSE_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolInternationalSPI_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolInternationalXETRA_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolGTISAFX_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolGTISEP_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolGTISFI_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolGTISMM_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolGTISPFX_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolGTISPM_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SymbolGTISSFFX_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Step_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TimeSales_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ToolBmpCopy_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ToolChartLoop_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ToolDeleteSymbols_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ToolExcelCopy_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ToolJpgCopy_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ToolExcelFile_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ToolExcelPeriodic_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ToolExcelInterval_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ToolSaveSymbolList_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ToolShowSymbolLists_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void YayinRefresh_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CellDdeCopy_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CellDdeTahvilBugun_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CellDdeTahvilYarin_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Render()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Init()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DownloadChart1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DownloadChart5_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DownloadChart60_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DownloadChartG_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AlanSatanChart_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Robokep_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Company_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HisseGenel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MenuWatchlist()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
