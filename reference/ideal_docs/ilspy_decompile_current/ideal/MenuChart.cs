using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class MenuChart : Form
{
	public static MenuChart Reference;

	private IContainer components;

	public ContextMenuStrip SubMenu;

	private ToolStripMenuItem Property;

	private ToolStripMenuItem PropertyMemCopy;

	public ToolStripMenuItem PropertyTopmost;

	private ToolStripSeparator toolStripSeparator22;

	private ToolStripMenuItem PropertyColor;

	public ToolStripMenuItem PropertyPriceWidth;

	public ToolStripMenuItem PropertyEmptySpace;

	public ToolStripMenuItem Pattern;

	public ToolStripMenuItem PatternSave;

	public ToolStripMenuItem PatternSaveas;

	public ToolStripComboBox PatternChange;

	private ToolStripMenuItem PatternDefault;

	private ToolStripMenuItem PatternDelete;

	private ToolStripMenuItem PatternDeleteAll;

	public ToolStripMenuItem Grup;

	private ToolStripMenuItem Tool;

	private ToolStripMenuItem ToolExcelCopy;

	private ToolStripMenuItem ToolJpgCopy;

	private ToolStripMenuItem ToolBmpCopy;

	private ToolStripSeparator toolStripSeparator21;

	private ToolStripMenuItem DataDelete;

	private ToolStripMenuItem DataEdit;

	private ToolStripMenuItem DataSplit;

	private ToolStripSeparator toolStripSeparator45;

	private ToolStripMenuItem DataDeleteAll;

	private ToolStripSeparator toolStripSeparator46;

	public ToolStripMenuItem DataMaxBars;

	private ToolStripMenuItem Split;

	private ToolStripSeparator toolStripSeparator44;

	private ToolStripSeparator toolStripSeparator68;

	private ToolStripMenuItem CloseForm;

	public ToolStripMenuItem PropertyDataWindowOpacity;

	public ToolStripMenuItem PropertyFillOpacity;

	public ToolStripMenuItem PortfolioBuy;

	public ToolStripMenuItem PortfolioSell;

	private ToolStripMenuItem ImportFromFile;

	private ToolStripMenuItem ToolClipboardCopy;

	private ToolStripMenuItem ExportToFile;

	public ToolStripMenuItem PropertyToolBarVisible;

	private ToolStripMenuItem PropertyMouseWheel;

	public ToolStripMenuItem PropertyMouseWheel0;

	public ToolStripMenuItem PropertyMouseWheel1;

	private ToolStripMenuItem PropertyHorizontalDensity;

	public ToolStripMenuItem PropertyHorizontalDensity0;

	public ToolStripMenuItem PropertyHorizontalDensity1;

	public ToolStripMenuItem PropertyHorizontalDensity2;

	public ToolStripMenuItem PropertyShowPrevClose;

	private ToolStripMenuItem PropertyPeriod01;

	private ToolStripMenuItem PropertyPeriod02;

	private ToolStripMenuItem PropertyPeriod17;

	private ToolStripMenuItem PropertyPeriod04;

	private ToolStripMenuItem PropertyPeriod05;

	private ToolStripMenuItem PropertyPeriod06;

	private ToolStripMenuItem PropertyPeriod07;

	private ToolStripMenuItem PropertyPeriod08;

	private ToolStripMenuItem PropertyPeriod09;

	private ToolStripMenuItem PropertyPeriod10;

	private ToolStripMenuItem PropertyPeriod11;

	private ToolStripMenuItem PropertyPeriod12;

	private ToolStripMenuItem PropertyPeriod13;

	private ToolStripMenuItem PropertyPeriod14;

	private ToolStripMenuItem PropertyPeriod15;

	private ToolStripMenuItem PropertyPeriod16;

	public ToolStripMenuItem PropertyPeriod;

	public ToolStripMenuItem PropertyShowLineBox;

	public ToolStripMenuItem PropertyLineWidth;

	private ToolStripMenuItem ToolPrinter;

	public ToolStripMenuItem PropertyDonguPeriyot;

	private ToolStripMenuItem ImportFromFileMetaTrader;

	public ToolStripMenuItem ReadingBarCount;

	private ToolStripMenuItem TrendAlarmListesi;

	private ToolStripMenuItem FiyatAlarmEkle;

	private ToolStripMenuItem IndikatorAlarmEkle;

	private ToolStripSeparator toolStripSeparator2;

	private ToolStripMenuItem SablonRobotEkle;

	private ToolStripMenuItem BirimGrafik;

	public ToolStripMenuItem Data;

	private ToolStripMenuItem IndicatorValue;

	private ToolStripMenuItem Toolbox;

	private ToolStripMenuItem FileSave;

	public ToolStripMenuItem FileSaveActive;

	private ToolStripMenuItem FileDelete;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripMenuItem PropertyTrend;

	public ToolStripMenuItem PropertyTrendValueVisible;

	public ToolStripMenuItem PropertyTrendPercentVisible;

	public ToolStripMenuItem PropertyTrendReferansNo;

	private ToolStripMenuItem PropertyFibo;

	private ToolStripMenuItem PropertyFiboImpulse;

	private ToolStripMenuItem PropertyFiboChannel;

	private ToolStripMenuItem PropertyFiboRet;

	private ToolStripMenuItem PropertyFiboRetLog;

	public ToolStripMenuItem PropertyFiboRetLog0;

	public ToolStripMenuItem PropertyFiboRetLog1;

	private ToolStripMenuItem PropertyFiboRetTextPosition;

	public ToolStripMenuItem PropertyFiboRetTextPositionSol;

	public ToolStripMenuItem PropertyFiboRetTextPositionSag;

	private ToolStripMenuItem PropertyShowPositions;

	public ToolStripMenuItem PropertyEmirlerGorunsun;

	public ToolStripMenuItem PropertyEmirYazilariGorunsun;

	public ToolStripMenuItem PropertyEmirYazilariLokasyon;

	private ToolStripMenuItem PropertyEmirlerAlisCizgiRenk;

	private ToolStripMenuItem PropertyEmirlerAlisZeminRenk;

	private ToolStripMenuItem PropertyEmirlerSatisCizgiRenk;

	private ToolStripMenuItem PropertyEmirlerSatisZeminRenk;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripMenuItem PropertyEmirlerAlisYaziRenk;

	private ToolStripSeparator toolStripSeparator4;

	private ToolStripMenuItem PropertyEmirlerSatisYaziRenk;

	public ToolStripMenuItem PropertyEmirYazilarKalinlik;

	private ToolStripMenuItem PropertyEmirDefaultColor;

	private ToolStripMenuItem BirimGrafikSplit;

	private ToolStripMenuItem Toolbars;

	private ToolStripSeparator toolStripSeparator5;

	private ToolStripMenuItem ToolbarsBackColor1;

	private ToolStripMenuItem ToolbarsBackColor2;

	private ToolStripMenuItem ToolbarsForeColor;

	private ToolStripMenuItem ToolbarsBorderColor;

	public ToolStripMenuItem ToolbarsSkalaVisible;

	private ToolStripMenuItem ToolbarsAktifBackColor;

	private ToolStripMenuItem ToolbarsAktifForeColor;

	private ToolStripMenuItem toolStripMenuItem2;

	private ToolStripMenuItem PropertyPeriod18;

	private ToolStripMenuItem PropertyPeriod19;

	public ToolStripMenuItem PropertyPeriodHeader;

	public ToolStripMenuItem PropertyPozisyonlarGorunsun;

	public ToolStripMenuItem PropertyTrendBarSayisiVisible;

	public ToolStripMenuItem PropertyTrendEgimVisible;

	private ToolStripMenuItem DownloadSub;

	private ToolStripMenuItem Download1;

	private ToolStripMenuItem Download2;

	public ToolStripMenuItem Download4;

	private ToolStripMenuItem DownloadTum;

	private ToolStripMenuItem Download1Dk;

	private ToolStripMenuItem Download3;

	private ToolStripMenuItem DownloadXU30;

	private ToolStripMenuItem DownloadXU50;

	private ToolStripMenuItem DownloadXU100;

	private ToolStripMenuItem DownloadTumSenetler;

	private ToolStripMenuItem DownloadViopAktif;

	private ToolStripMenuItem EndeksYeniBasamak;

	private ToolStripMenuItem EndeksYeniBasamakTumIslemler;

	private ToolStripMenuItem EndeksYeniBasamakDagilim;

	private ToolStripMenuItem F_Saatler;

	public ToolStripMenuItem F_Saatler_Tum;

	public ToolStripMenuItem F_Saatler_Gunduz;

	public ToolStripMenuItem MorningBarBool;

	public ToolStripMenuItem GrafikFlushPeriyot;

	private ToolStripMenuItem Download5;

	private ToolStripMenuItem Download6;

	private ToolStripMenuItem Download7;

	private ToolStripMenuItem BinanceChartIndir;

	private ToolStripMenuItem Menu5SnOlustur;

	private ToolStripMenuItem Menu5SnOlusturTarihSonrasi;

	private ToolStripMenuItem menu5SnGrafikOlusturPrefik;

	private ToolStripMenuItem Grafik5SnTarihtenİtibarenMenuItem;

	private ToolStripMenuItem BirimGrafikTarihtenSonra;

	private ToolStripMenuItem PasteImage;

	private ToolStripMenuItem PropertyGoruntuMod;

	public ToolStripMenuItem PropertyGoruntuModPerformans;

	public ToolStripMenuItem PropertyGoruntuModGoruntu;

	private ToolStripMenuItem ArtioxChartIndir;

	private ToolStripMenuItem IcrypexChartIndir;

	public ToolStripMenuItem MorningVIOPBarBool;

	private ToolStripMenuItem PropertyFont;

	public ToolStripMenuItem PropertyTrendSkalaVisible;

	private ToolStripMenuItem MumGrafikTip;

	public ToolStripMenuItem MumGrafikTip0;

	public ToolStripMenuItem MumGrafikTip1;

	public ToolStripMenuItem MumGrafikTip2;

	private ToolStripMenuItem HacimVeriCevir;

	private ToolStripMenuItem HacimAnalizChartDownload;

	private ToolStripMenuItem IndicatorCopy;

	private ToolStripMenuItem IndicatorPaste;

	private ToolStripSeparator toolStripMenuItem1;

	private ToolStripMenuItem Replay;

	private ToolStripMenuItem SanalMod;

	private ToolStripMenuItem SanalModVeriEkle;

	private ToolStripMenuItem SanalModVeriDegistir;

	private ToolStripMenuItem SanalModVeriSil;

	private ToolStripMenuItem SanalModBellektenYapistir;

	private ToolStripMenuItem SanalModTersYapistir;

	private ToolStripMenuItem SanalModFiyatTersYapistir;

	private ToolStripMenuItem Faiz;

	private ToolStripMenuItem FaizEkle;

	private ToolStripMenuItem FaizSil;

	private ToolStripMenuItem toolStripMenuItem3;

	private ToolStripMenuItem TufeTuikEkle;

	private ToolStripMenuItem TufeTuikSil;

	public ToolStripMenuItem KodRobotEkle;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MenuChart()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CloseForm_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DataDelete_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DataDeleteAll_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DataEdit_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DataMaxBars_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DataSplit_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Download1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Download2_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExportToFile_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FileDelete_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FileSave_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FileSaveActive_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Grup_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ImportFromFile_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ImportFromFileMetaTrader_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IndicatorValue_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReadingBarCount_Click(object sender, EventArgs e)
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
	private void PortfolioBuy_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PortfolioSell_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyColor_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyDataWindowOpacity_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyDonguPeriyot_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyEmptySpace_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyFiboChannel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyFiboImpulse_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyFiboRet_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyFiboRetLog0_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyFiboRetLog1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyFiboRetTextPositionSag_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyFiboRetTextPositionSol_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyFillOpacity_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyHorizontalDensity0_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyHorizontalDensity1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyHorizontalDensity2_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyLineWidth_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyMemCopy_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyMouseWheel0_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyMouseWheel1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyPeriodSub_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyPriceWidth_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyShowLineBox_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyShowPositions_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyShowPrevClose_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyTopmost_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyToolBarVisible_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyTrendReferansNo_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyTrendValueVisible_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyTrendPercentVisible_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SablonRobotEkle_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Split_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Toolbox_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ToolBmpCopy_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ToolClipboardCopy_Click(object sender, EventArgs e)
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
	private void ToolPrinter_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TrendAlarmListesi_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FiyatAlarmEkle_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IndikatorAlarmEkle_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FiyatDegisimDayCount_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Download3_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BirimGrafik_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyTrendSkalaVisible_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Download4_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Replay_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SanalModVeriEkle_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SanalModVeriDegistir_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SanalModBellektenYapistir_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SanalModVeriSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SanalModTersYapistir_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SanalModFiyatTersYapistir_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DownloadXU30_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DownloadXU50_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DownloadXU100_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DownloadTumSenetler_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DownloadViopAktif_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void F_Saatler_Tum_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void F_Saatler_Gunduz_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IndicatorCopy_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IndicatorPaste_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyEmirlerGorunsun_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyEmirYazilariGorunsun_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyEmirYazilariLokasyon_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyEmirlerAlisCizgiRenk_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyEmirlerAlisZeminRenk_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyEmirlerAlisYaziRenk_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyEmirlerSatisCizgiRenk_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyEmirlerSatisZeminRenk_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyEmirlerSatisYaziRenk_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyEmirYazilarKalinlik_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyEmirDefaultColor_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BirimGrafikSplit_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ToolbarsSkalaVisible_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ToolbarsBackColor1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ToolbarsBackColor2_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ToolbarsForeColor_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ToolbarsBorderColor_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ToolbarsAktifBackColor_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ToolbarsAktifForeColor_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyPeriodHeader_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyPozisyonlarGorunsun_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyTrendBarSayisiVisible_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyTrendEgimVisible_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DownloadTum_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Download1Dk_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EndeksYeniBasamak_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EndeksYeniBasamakTumIslemler_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EndeksYeniBasamakDagilim_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MorningBarBool_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MorningVIOPBarBool_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GrafikFlushPeriyot_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Download5_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Download6_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Download7_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BinanceChartIndir_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ArtioxChartIndir_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Menu5SnOlusturTarihSonrasi_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menu5SnGrafikOlusturPrefik_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Grafik5SnTarihtenİtibarenMenuItem_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BirimGrafikTarihtenSonra_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PasteImage_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyGoruntuModPerformans_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyGoruntuModGoruntu_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IcrypexChartIndir_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PropertyFont_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MumGrafikTip0_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MumGrafikTip1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MumGrafikTip2_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HacimVeriCevir_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HacimAnalizChartDownload_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FaizEkle_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FaizSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TufeTuikEkle_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TufeTuikSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void KodRobotEkle_Click(object sender, EventArgs e)
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
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MenuChart()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
