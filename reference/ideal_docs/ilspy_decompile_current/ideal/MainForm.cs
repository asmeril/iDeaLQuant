using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;
using nsoftware.IPWorks;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class MainForm : Form
{
	public static MainForm Reference;

	public static ComboBox cmbWorkspaceAllRef;

	public bool DownloaderChartEnabled;

	public WebClient DownloaderChartClient;

	public Dictionary<string, string> DownloaderChartDictionary;

	public string DownloaderChartFilename;

	public Queue<string> ChartBufferBackWorkerQueue;

	public Queue<string> ChartBufferTimerQueue;

	private static bool NewVersionDownloaded;

	public static bool iDealloadedbool;

	public static bool newSembolsAdded;

	public static int TopOffset;

	public cxButton ToolbarButtons;

	private Bitmap BitmapShortcut;

	private Bitmap BitmapScreen;

	private Bitmap BitmapSave;

	private Bitmap BitmapDepth;

	private Bitmap BitmapDetail;

	private Bitmap BitmapChart;

	private Bitmap BitmapStep;

	private Bitmap BitmapDistribution;

	private Bitmap BitmapBalancesheet;

	private Bitmap BitmapNews;

	private Bitmap BitmapTakas;

	private Bitmap BitmapPortfolio;

	private Bitmap BitmapOrder;

	private Color MainWindowBackColor;

	private Color PanelBackColor1;

	private Color PanelBackColor2;

	private Color DownBackColor1;

	private Color DownBackColor2;

	private Color ActiveBackColor1;

	private Color ActiveBackColor2;

	private Color Part1BackColor1;

	private Color Part1BackColor2;

	private Color Part1BorderColor;

	private Color Part1ForeColor1;

	private Color Part1ForeColor2;

	private Color Part2BackColor1;

	private Color Part2BackColor2;

	private Color Part2BorderColor;

	private Color Part2ForeColor;

	private Color Part3BackColor1;

	private Color Part3BackColor2;

	private Color Part3BorderColor;

	private Color Part3ForeColor;

	private Color Part4BackColor1;

	private Color Part4BackColor2;

	private Color Part4BorderColor;

	private Color Part4ForeColor;

	private Color Part4NormalColor;

	private Color Part4HighColor;

	private Color Part4LowColor;

	private Color Part5BackColor1;

	private Color Part5BackColor2;

	private Color Part5BorderColor;

	private Color Part5ForeColor;

	private Color ControlBackColor;

	private Color ControlForeColor;

	private Color ControlShadow1Color;

	private Color ControlShadow2Color;

	public WebClient DownloaderVersion;

	private WebClient DownloaderAuto;

	private Dictionary<string, string> DownloadDictionary;

	private Dictionary<string, bool> DataAktarimDictionary;

	public Dictionary<string, string> DownloadTakasDictionary;

	private Stopwatch CheckTimeTerminal;

	private long CheckTimeTerminal100;

	private long CheckTimeTerminal200;

	private long CheckTimeTerminal500;

	private long CheckTimeTerminal1000;

	private long CheckTimeTerminal2000;

	private long CheckTimeTerminal3000;

	private long CheckTimeTerminal10000;

	private long CheckTimeTerminal30000;

	private long CheckTimeTerminal60000;

	private long CheckTimeTerminal120000;

	private long CheckTimeTerminal180000;

	private long CheckTimeTerminal240000;

	private long CheckTimeTerminal300000;

	private long CheckTimeTerminal900000;

	private long CheckTimeTerminal3600000;

	public static Timer TimerRobot;

	public static Timer TimerTrendAlarm;

	public static Timer TimerSablon;

	public static Timer TimerSablon1;

	public static Timer TimerSablon2;

	public static Timer TimerSablon3;

	public static Timer TimerSablon4;

	public static Timer TimerTablom;

	public static Timer TimerArbitraj;

	public static Timer TimerRisk;

	public static Timer TimerRoboTrade;

	public static Timer TimerYarisma;

	public static Timer TimerTaramaRobot;

	public static Timer TimerBmcRobot;

	public static Timer TimerTahta2Robot;

	public static Timer TimerParaViop;

	public static Timer TimerHisseAnaliz;

	public static Timer TimerParaBir;

	public static Timer TimerNagants;

	public static Timer TimerSentimentRobot;

	public static Timer TimerPgc;

	public static Timer TimerGridBot;

	public static Timer TimerPacalBot;

	public static Timer TimerArbitraj1;

	public static Timer TimerTrendBot;

	public static Timer TimerYatayBot;

	public static Timer TimerTwap1;

	public static Timer TimerTwap2;

	public static Timer TimerTwap3;

	public static Timer TimerTwap4;

	public static Timer TimerOms;

	public static Timer TimerPortfoy;

	public static Timer TimerKodRobot;

	private static ConcurrentQueue<cxTrendAlarm> TrendAlarmPopupQueue;

	private List<Rectangle> MinimizedRectList;

	private ConcurrentQueue<string> InputQueue;

	private Queue<string> InputCriptoQueue;

	private Queue<string> InputTuribQueue;

	private static string SEP;

	private static string EOL;

	private static ConcurrentQueue<string> OmsQueue;

	private List<string> FixRouterLog_List;

	private List<string> strlist;

	private string dateText;

	private string filename;

	private Queue<string> ChartFlushQueue;

	private static bool TimerSablonBusy;

	private static bool TimerSablon1Busy;

	private static bool TimerSablon2Busy;

	private static bool TimerSablon3Busy;

	private static bool TimerSablon4Busy;

	public static DateTime TimerSablonTime;

	public static DateTime TimerSablon1Time;

	public static DateTime TimerSablon2Time;

	public static DateTime TimerSablon3Time;

	public static DateTime TimerSablon4Time;

	public static string IdealgoSonRobotString;

	private IContainer components;

	private Timer timerMain;

	private Panel pnlH1;

	private Panel pnlH2;

	private Panel pnlV2;

	private Panel pnlV1;

	public PictureBox pictureFont;

	private Panel panelSymbolSearch;

	private Panel panelWorkspaceAll;

	private Panel panelWorkspaceAllContainer;

	private Panel panelSymbolSearchContainer;

	public TextBox textSymbolSearch;

	private Panel panelWorkspaceAllArrow;

	public Ipport tcpClient1;

	public Ipport tcpClient2;

	public Ipinfo tcpInfo;

	private ToolTip toolTip;

	public Panel panelToolbar;

	public ComboBox comboWorkspaceAll;

	private Http httpAuto;

	public BackgroundWorker backworkerChart;

	public Panel panelMinimize;

	public Http httpNewVersion;

	public TextBox textStatus;

	public Ipdaemon HostIdb;

	public Ipdaemon HostDataAktarim;

	private Timer timerInput;

	public PictureBox pictureBoxIdealBE;

	public PictureBox pictureBoxIdeal;

	public PictureBox pictureBoxIdealGo;

	public PictureBox pictureBoxIdealGoBE;

	public Ipport tcpYarisma;

	public Ipport tcpDropCopy;

	public Timer timerChartFlush;

	private Http httpTakas;

	public Timer timerTakasDownload;

	public Ipport tcpParaViop;

	private Button button1;

	public Ipport tcpParaBir;

	public Ipport tcpCripto;

	public Ipport tcpUzak;

	public Ipport tcpTurib;

	public Ipport tcpFixOrder;

	[DllImport("user32")]
	private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

	[DllImport("user32")]
	private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

	[DllImport("user32")]
	private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, int uFlags);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MainForm()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MainForm_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MainForm_LocationChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MainForm_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MainForm_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void backworkerChart_DoWork(object sender, DoWorkEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboWorkspaceAll_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboWorkspaceAll_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void httpAuto_OnEndTransfer(object sender, HttpEndTransferEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void httpNewVersion_OnEndTransfer(object sender, HttpEndTransferEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void httpNewVersion_OnError(object sender, HttpErrorEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void httpNewVersion_OnTransfer(object sender, HttpTransferEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelMinimize_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelMinimize_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelToolbar_MouseDoubleClick(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelToolbar_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelToolbar_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelToolbar_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelToolbar_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelWorkspaceAllArrow_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelWorkspaceAllArrow_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pictureBoxIdealBE_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pnlV1_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pnlH1_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pnlV2_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pnlH2_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pnlV1_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pnlH1_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pnlV2_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pnlH2_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbolSearch_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbolSearch_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerMain_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerInput_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DownloaderAutoProgressChanged(object sender, DownloadProgressChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DownloaderAutoCompleted(object sender, AsyncCompletedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DownloaderChartClientCompleted(object sender, AsyncCompletedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DownloaderVersionProgressChanged(object sender, DownloadProgressChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DownloaderVersionCompleted(object sender, AsyncCompletedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool AcikPencereKontrol(string typeX, string symbolX)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddAutoDownloadFiles()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CalculateUserEndeks()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CalculateUserSymbols()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckAutoDownloadHttp()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckLastVersion()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckCriptoServer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckTuribServer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckPortConnections()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckPortfolioTimeout()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckTerminalDisconnection()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] ConvertPageToByteArray()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DownloadChart()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillChartQueue()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FinishNewVersionDownloading()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetToolbarSymbolWidth(Graphics grx, string symbolX)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HideToolTip()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InvalidateToolBar()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintToolbarSymbol(Graphics grx, string keyX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintToolbarTime(Graphics grx)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ProcessPortfolioEvent(string eventmessage)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMenuRender()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetIcons()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPageParams(cxPage.MainWindow pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StartChartBackWorker()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerRobot_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerTrendAlarm_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerSablon_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerSablon1_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerSablon2_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerSablon3_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerSablon4_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ProcessSablonRobot(int rowno)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerTablom_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerArbitraj_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerRisk_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerRoboTrade_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerTaramaRobot_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerBmcRobot_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void InsertBmcTaramaEmir(BmcEmirClass taramaemir)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerTahta2Robot_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerParaViop_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerHisseAnaliz_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerParaBir_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerNagants_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerPgc_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerGridBot_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerPacalBot_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerArbitraj1_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerTrendBot_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerYatayBot_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CheckTradePov(IslemStruct1 islem)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ProcessTwap(AlgoClass robotitem)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ProcessTwap_AlgoArbitraj(AlgoClass robotitem, cxBasic basic, HesapRec hesapitem, FixHesapRec fixHesapRec)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerTwap1_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerTwap2_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerTwap3_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerTwap4_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TimerOms_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TimerPortfoy_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TimerKodRobot_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ProcessKodRobot(KodRobotClass robotitem)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WriteBrokerFile()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WriteNewsContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WriteTickBarsx()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeTema()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeColors(cxColorEditor coloritemX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangePattern(string patternnameX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DownloadNewVersion()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManuelDownload()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SavePattern()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SaveAsPattern()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDefaultPattern()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowBlackEditionColors()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowWhiteEditionColors()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowColorWindow()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowLoadedForms()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetLanguage()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tcpClient1_OnConnected(object sender, IpportConnectedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tcpClient1_OnDataIn(object sender, IpportDataInEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tcpClient1_OnDisconnected(object sender, IpportDisconnectedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tcpClient1_OnReadyToSend(object sender, IpportReadyToSendEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerChartBuffer(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tcpClient2_OnConnected(object sender, IpportConnectedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tcpClient2_OnDisconnected(object sender, IpportDisconnectedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tcpClient2_OnDataIn(object sender, IpportDataInEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tcpClient2_OnReadyToSend(object sender, IpportReadyToSendEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerParse2_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HostIdb_OnConnected(object sender, IpdaemonConnectedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HostDataAktarim_OnDataIn(object sender, IpdaemonDataInEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HostDataAktarim_OnConnected(object sender, IpdaemonConnectedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tcpYarisma_OnDataIn(object sender, IpportDataInEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tcpYarisma_OnConnected(object sender, IpportConnectedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tcpDropCopy_OnDataIn(object sender, IpportDataInEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tcpDropCopy_OnConnected(object sender, IpportConnectedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tcpDropCopy_OnDisconnected(object sender, IpportDisconnectedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartDropCopy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ParseOms(string msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SendOmsHeartbeat()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FixRouterLogYaz(string mesaj)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FixRouterLogKaydet()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool FixRouterKontrol()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckFixRouterServer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ConnectFixRouterServer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisconnectFixRouterServer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tcpFixRouter_OnConnected(object sender, IpportConnectedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tcpFixRouter_OnDataIn(object sender, IpportDataInEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ProcessFixRouterMessage(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tcpFixRouter_OnDisconnected(object sender, IpportDisconnectedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tcpFixRouter_OnError(object sender, IpportErrorEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tcpFixRouter_OnReadyToSend(object sender, IpportReadyToSendEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool FixRouterPatternFound(List<byte> source, out int index)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillChartFlush()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerChartFlush_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void httpTakas_OnRedirect(object sender, HttpRedirectEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerTakasDownload_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tcpParaViop_OnConnected(object sender, IpportConnectedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ParaViopHeartBeat(string str)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tcpParaViop_OnDataIn(object sender, IpportDataInEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void button1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tcpParaBir_OnConnected(object sender, IpportConnectedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tcpParaBir_OnDataIn(object sender, IpportDataInEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ParaBirHeartBeat(string str)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tcpCripto_OnDataIn(object sender, IpportDataInEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tcpCripto_OnConnected(object sender, IpportConnectedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tcpTurib_OnConnected(object sender, IpportConnectedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tcpTurib_OnDataIn(object sender, IpportDataInEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DownloadFile(string filename)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tcpUzak_OnConnected(object sender, IpportConnectedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tcpUzak_OnDataIn(object sender, IpportDataInEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ConnectUzakIdealgo()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RequestPortfolioPositions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IdealgoPozisyonEsitle()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IdealgoTumListe()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckDropCopyConnection()
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
	static MainForm()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		NewVersionDownloaded = false;
		iDealloadedbool = false;
		newSembolsAdded = false;
		TopOffset = 28;
		TimerRobot = new Timer();
		TimerTrendAlarm = new Timer();
		TimerSablon = new Timer();
		TimerSablon1 = new Timer();
		TimerSablon2 = new Timer();
		TimerSablon3 = new Timer();
		TimerSablon4 = new Timer();
		TimerTablom = new Timer();
		TimerArbitraj = new Timer();
		TimerRisk = new Timer();
		TimerRoboTrade = new Timer();
		TimerYarisma = new Timer();
		TimerTaramaRobot = new Timer();
		TimerBmcRobot = new Timer();
		TimerTahta2Robot = new Timer();
		TimerParaViop = new Timer();
		TimerHisseAnaliz = new Timer();
		TimerParaBir = new Timer();
		TimerNagants = new Timer();
		TimerSentimentRobot = new Timer();
		TimerPgc = new Timer();
		TimerGridBot = new Timer();
		TimerPacalBot = new Timer();
		TimerArbitraj1 = new Timer();
		TimerTrendBot = new Timer();
		TimerYatayBot = new Timer();
		TimerTwap1 = new Timer();
		TimerTwap2 = new Timer();
		TimerTwap3 = new Timer();
		TimerTwap4 = new Timer();
		TimerOms = new Timer();
		TimerPortfoy = new Timer();
		TimerKodRobot = new Timer();
		TrendAlarmPopupQueue = new ConcurrentQueue<cxTrendAlarm>();
		char c = '\u0003';
		SEP = MRevCNW8EP4EcOtFBfM.r7iItWL60(ref c, MRevCNW8EP4EcOtFBfM.YwsWnroe2w);
		c = '\u0004';
		EOL = MRevCNW8EP4EcOtFBfM.r7iItWL60(ref c, MRevCNW8EP4EcOtFBfM.YwsWnroe2w);
		OmsQueue = new ConcurrentQueue<string>();
		TimerSablonBusy = false;
		TimerSablon1Busy = false;
		TimerSablon2Busy = false;
		TimerSablon3Busy = false;
		TimerSablon4Busy = false;
		TimerSablonTime = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
		TimerSablon1Time = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
		TimerSablon2Time = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
		TimerSablon3Time = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
		TimerSablon4Time = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
		IdealgoSonRobotString = "";
	}
}
