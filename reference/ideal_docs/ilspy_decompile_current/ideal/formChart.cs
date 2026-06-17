using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;
using nsoftware.IPWorks;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class formChart : FormControl
{
	private WebClient Downloader;

	private Dictionary<string, string> DownloadDictionary;

	public cxPage.Chart PageParams;

	private string InitialSymbol;

	private string InitialPeriod;

	private int InitialLeft;

	private int InitialTop;

	public bool FormLoaded;

	public bool FormActivated;

	public string ActiveSymbol;

	public string ActivePeriod;

	public bool TopMostEnabled;

	public string ActiveFile;

	public bool HacimBool;

	public int HacimKurumId;

	public int HacimDayCount;

	private int ClassVersion;

	public Color ToolBarBackColor;

	public Color ToolBarForeColor;

	public Color ToolBarActiveColor;

	public bool ToolBarVisible;

	private int DonguPeriyot;

	private cxButton HeaderButtons;

	private Rectangle Rect1;

	private Rectangle Rect2;

	private Pen Pen1;

	private Pen Pen2;

	private SolidBrush Brush1;

	private string Str1;

	public static formChart Referance;

	public static ChartControl ChartControlReferance;

	private static int LeftAlarm;

	private static int TopAlarm;

	private static int WidthAlarm;

	private static int HeightAlarm;

	private bool formasyongoster;

	private IContainer components;

	private ChartControl Chart;

	private Timer timerDownload;

	private Http http1;

	private Label labelDownload;

	private Timer timerRefresh;

	private ContextMenuStrip menuSistem;

	private ToolStripMenuItem menuSistemNone;

	private ToolStripMenuItem menuSistemDefinitions;

	private ToolStripMenuItem menuSistemPerformance;

	private ToolStripMenuItem menuSistemPosition;

	private ToolStripMenuItem menuSistemCompare;

	private ToolStripMenuItem menuSistemMulti;

	public ComboBox comboFiles;

	private ToolStripMenuItem menuSistemIndicatorPerformance;

	private ToolStripMenuItem menuSistemArrowPosition;

	private ToolStripMenuItem menuSistemArrowPosition0;

	private ToolStripMenuItem menuSistemArrowPosition1;

	private ToolStripMenuItem menuSistemArrowPosition2;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripMenuItem menuSistemBuySellLine;

	private ToolStripMenuItem menuSistemOptimizasyon;

	private ToolStripMenuItem menuSistemSorgu;

	private ToolStripMenuItem menuSistemBuySellColor;

	private Timer timerDongu;

	private ToolStripMenuItem menuSistemArrowPosition3;

	private ToolStripMenuItem menuSistemCompileLib;

	private ToolStripMenuItem menuSistemSinyalFiyat;

	private ToolStripMenuItem menuSistemSinyalBarKaydir;

	private ToolStripMenuItem menuSistemKilavuz;

	private ToolStripMenuItem menuSistemKumulatifGetiri;

	private ToolStripMenuItem menuSistemYukselenDusenRenk;

	private ToolStripMenuItem menuSistemSablonRobot;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripMenuItem menuSistemRedrawSystem;

	private ColorDialog colorDialog1;

	private ToolStripMenuItem menuSistemTarama;

	private ToolStripMenuItem menuSistemTaramaRobot;

	private ToolStripSeparator toolStripSeparator4;

	private ToolStripMenuItem menuBmcTarama;

	private ToolStripMenuItem menuTahta;

	private ToolStripMenuItem menuParaViop;

	private ToolStripMenuItem toolStripMenuItem3;

	private ToolStripMenuItem menuFsystem;

	private PictureBox pictureboxTwitter;

	private ToolStripMenuItem menuEgzotik;

	private ToolStripMenuItem menuSepetGetiri;

	private ToolStripMenuItem menuHedefPanel;

	private ToolStripMenuItem menuSistemGetiriTur;

	private ToolStripMenuItem menuSistemGetiriTurPuan;

	private ToolStripMenuItem menuSistemGetiriTurYuzde;

	private ToolStripMenuItem menuRobotPaneli;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formChart(int leftX, int topX, string symbolX, cxPage.Chart fieldsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formChart(string symbolX, string periodX, cxPage.Chart fieldsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formChart_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formChart_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formChart_Deactivate(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formChart_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formChart_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formChart_MouseDoubleClick(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formChart_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formChart_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formChart_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboFiles_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboFiles_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void http1_OnEndTransfer(object sender, HttpEndTransferEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void http1_OnTransfer(object sender, HttpTransferEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSistemArrowPosition0_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSistemArrowPosition1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSistemArrowPosition2_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSistemArrowPosition3_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSistemBuySellLine_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSistemBuySellColor_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSistemRedrawSystem_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSistemKilavuz_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSistemSablonRobot_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSistemSinyalFiyat_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSistemCompare_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSistemSinyalBarKaydir_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSistemCompileLib_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSistemDefinitions_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSistemIndicatorPerformance_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSistemMulti_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSistemNone_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSistemOptimizasyon_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSistemPerformance_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSistemPosition_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSistemSorgu_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSistemKumulatifGetiri_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSistemYukselenDusenRenk_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerDownload_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Downloader_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerRefresh_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerDongu_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChartDataReceived(string symbolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChartDataBasicReceived(string symbolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChartMessageReceived(object sender, DateTime msgTimeX, string msgTypeX, object msgObjectX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DownloaderProgressChanged(object sender, DownloadProgressChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DownloaderCompleted(object sender, AsyncCompletedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MessageReceived(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PortfolioReceived(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TradeReceived(IslemStruct1 itemX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMainToolbarSymbol()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPageParams(cxPage.Chart pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetLanguage()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HacimOtoDownload()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeColors(cxColorEditor coloritemX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeSymbolPeriod(string symbolCode, string period)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] ConvertPageToByteArray()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessMenuMessage(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InsertIndicators(List<cxIndicator> indicatorsx)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveOtoTrend()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SaveOtoTrend()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSistemTarama_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSistemTaramaRobot_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuBmcTarama_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTahta_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuParaViop_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuHedefPanel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void toolStripMenuItem3_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuFsystem_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pictureboxTwitter_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuEgzotik_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSepetGetiri_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSistemGetiriTurPuan_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSistemGetiriTurYuzde_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobotPaneli_Click(object sender, EventArgs e)
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
	static formChart()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		Referance = null;
		ChartControlReferance = null;
		LeftAlarm = 50;
		TopAlarm = 50;
		WidthAlarm = 700;
		HeightAlarm = 500;
	}
}
