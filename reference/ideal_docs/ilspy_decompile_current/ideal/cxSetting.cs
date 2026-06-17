using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
internal class cxSetting
{
	public static int DelayedServer;

	public static int CepServer;

	public static int OperationMode;

	public static int RobotServer;

	public static int ProductTypeNo;

	public static string ProductName;

	public static string Version;

	public static string BetaVersion;

	public static string SessionID;

	public static int ActiveRemoteServerNo;

	public static bool LastVersionCheck;

	public static bool MessengerServerEnabled;

	public static bool MainServerActiveBool;

	public static int IdbPortNo;

	public static int DataAktarimPortNo;

	public static bool ConnectionLogBool;

	public static int RobotServerKota;

	public static bool HizliBool;

	public static string ScmIcinSifre;

	public static bool IndirVersion;

	public static List<string> ServerRobotKapaliKurumList;

	public static List<string> RobotKapaliKurumList;

	public static bool RobotKapaliBool;

	public static bool ViopPriceStepBool;

	private static DateTime _01_01_2026;

	public bool AutoReconnect;

	public string MachineName;

	public bool RememberMe;

	public string Username;

	public string Password;

	public string RemoteDownloaderIP;

	public int RemoteDownloaderPort;

	public string RemoteKriptoServerIP;

	public int RemoteKriptoServerPort;

	public bool RemoteKriptoServerBool;

	public string RemoteTuribServerIP;

	public int RemoteTuribServerPort;

	public bool RemoteTuribServerBool;

	public string HttpDownloadPath;

	public string HttpDownloadPathM;

	public bool AutoOpenConnectionForm;

	public string[] RemoteRealtimeIP;

	public int[] RemoteRealtimePort;

	public int Host1LocalPort;

	public int Host2LocalPort;

	public int LocalTamirPort;

	public string RemoteTamirIP;

	public int RemoteTamirPort;

	public string NasdaqTamirIP;

	public int NasdaqTamirPort;

	public string RemoteSsoIP;

	public int RemoteSsoPort;

	public bool SsoEnabled;

	public int IdbPort;

	public int DataAktarimPort;

	public string GhostHesap;

	public string GhostPassword;

	public bool GhostRememberMe;

	public int GhostServerType;

	public int GhostMinuteDif;

	public bool GhostMessageAuto;

	public bool GhostMessageSound;

	public bool GhostConfirm;

	public string GhostOrderType;

	public int GhostHourDif;

	public string GhostMainCurrency;

	public bool GhostCloseOrderWindowAfterSend;

	public string OptimizerSistem;

	public string SorguSistem;

	public bool AutoErrorWindow;

	public bool SaniyeFarkSesliUyariBool;

	public bool FirewallAutoDetect;

	public int FirewallType;

	public string FirewallHost;

	public int FirewallPort;

	public string FirewallPassword;

	public string FirewallUser;

	public byte HttpAuthorization;

	public string TerminalID;

	public bool OnOff;

	public string Expiry;

	public string ProductType;

	public bool SCMusable;

	public bool Host1Enabled;

	public bool Host2Enabled;

	public string Explanation;

	public bool DDE;

	public bool IMKBL1;

	public bool IMKBL1P;

	public bool IMKBL2;

	public bool IMKBISL;

	public bool PITE;

	public bool IMKBX;

	public bool THVL1;

	public bool THVL1P;

	public bool THVL2;

	public bool VIPL1;

	public bool VIPL1P;

	public bool VIPL2;

	public bool SASEL1;

	public bool SASEL2;

	public bool VIPNET;

	public bool FUTGCK;

	public bool WINX;

	public bool AMEX;

	public bool CBOT;

	public bool CBOTM;

	public bool CME;

	public bool CMEM;

	public bool COMEX;

	public bool DJI;

	public bool EUREX;

	public bool LSE;

	public bool NYMEX;

	public bool NYMEXM;

	public bool NYSE;

	public bool NASDAQ;

	public bool SPI;

	public bool XETRA;

	public bool CHIX;

	public bool GTIS;

	public bool DJBN;

	public bool DJA;

	public bool DJCS;

	public bool DJES;

	public bool DJF;

	public bool DJN;

	public bool Messenger;

	public bool DovizQuote;

	public string KRM;

	private string multiLisans;

	public bool Robot;

	public bool MEKSA;

	public int WebPort;

	public int WebPortAjax;

	public bool DdeServerBool;

	public int ClassVersion;

	public bool ConfirmExit;

	public int ChartBarLimit;

	public int FileTransferPacketLen;

	public int ChartTransferPacketCount;

	public bool ChartTransferEnabledDay;

	public bool ChartTransferEnabled60;

	public bool ChartTransferEnabled5;

	public bool ChartTransferEnabled1;

	public int ChartTransferBarDay;

	public int ChartTransferBar60;

	public int ChartTransferBar5;

	public int ChartTransferBar1;

	public bool NewsFlashBeep;

	public bool NewsAlarmBeep;

	public int NewsDayCount;

	public Font NewsContentFont;

	public int NewsContentLeft;

	public int NewsContentTop;

	public int NewsContentWidth;

	public int NewsContentHeight;

	public bool NewsEnglish;

	public string ActiveWorkSpace;

	public List<string> WorkSpaceShortcutList;

	public List<string> ToolbarSymbolList;

	public int TakasDayCount;

	public int TradeImkbDayCount;

	public int TradeVipDayCount;

	public int VolumeImkbDayCount;

	public int DistributionImkbCount;

	public int OrderImkbCount;

	public int VolumeNetVipDayCount;

	public bool MainFormToolTipEnabled;

	public string LastVersion;

	public string CloseServerPorts;

	public string OpenServerPorts;

	public bool WeekendImkbData;

	public Font HeaderFont;

	public Font IdealFont;

	public int MainFormLeft;

	public int MainFormTop;

	public int MainFormWidth;

	public int MainFormHeight;

	public int FormHeaderHeight;

	public int TableRowHeight;

	public int DerinlikSpeed;

	public Color DefaultHeaderBorderColor;

	public Color DefaultHeaderBackColor1;

	public Color DefaultHeaderBackColor2;

	public Color DefaultHeaderButtonPassiveColor;

	public Color DefaultHeaderButtonActiveColor;

	public Color DefaultHeaderTextForeColor;

	public Color DefaultHeaderMenuForeColor;

	public int NewsAlertLeft;

	public int NewsAlertTop;

	public int NewsAlertWidth;

	public int NewsAlertHeight;

	public bool SiraTopMost;

	public bool MainWindowCoverScreen;

	public bool MinimizeBarVisible;

	public Color MinimizeBackColor1;

	public Color MinimizeBackColor2;

	public Color MinimizeBorderColor;

	public Color MinimizeForeColor;

	public byte AllTradesWindowDoubleClick;

	public byte DepthWindowExcelPrint;

	public bool AlgoSound;

	public int AlgoWindowLeft;

	public int AlgoWindowTop;

	public bool UserSymbolsActive;

	public bool NewVersionWarning;

	public byte ChartMouseWheelAction;

	public byte ChartF_Saatler;

	public byte ChartHorizontalGridDensity;

	public bool ChartShowPrevClose;

	public bool ChartShowPositions;

	public bool ChartShowMaliyet;

	public bool ChartEmirYazilariBool;

	public int ChartEmirYazilariLokasyon;

	public int ChartEmirCizgiKalinlik;

	public Color ChartEmirAlisZeminRenk;

	public Color ChartEmirAlisCizgiRenk;

	public Color ChartEmirAlisYaziRenk;

	public Color ChartEmirSatisZeminRenk;

	public Color ChartEmirSatisCizgiRenk;

	public Color ChartEmirSatisYaziRenk;

	public bool ChartShowIndicatorPerformance;

	public byte ChartFiboRetLog;

	public byte ChartFiboRetTextPosition;

	public bool ChartTrendPercentVisible;

	public bool ChartTrendReferansVisible;

	public bool ChartChartTrendSkalaVisible;

	public bool ChartTrendBarSayisiVisible;

	public bool ChartTrendEgimVisible;

	public int ChartGoruntuMod;

	public int MumGrafikTip;

	public bool YatayAlarmKisaCizgi;

	public List<string> ChartToolBarPeriods;

	public bool ChartToolBarPeriodsHeader;

	public List<float> FibonacciChannelRatios;

	public List<float> FibonacciRetRatios;

	public List<float> FibonacciImpRatios;

	public bool SistemBuySellLineVisible;

	public bool SistemBuySellColoring;

	public byte ArrowOutsideBarStatus;

	public bool GetiriYuzdeBool;

	public bool DailyBarsSaveBool;

	public bool IntraBarsSaveBool;

	public List<string> ChartToolboxList;

	public int ChartToolboxWidth;

	public int ChartToolboxHeight;

	public int ChartLineWidth;

	public bool SozlesmeBool;

	public DateTime FileRemovalDate;

	public int SorguRefreshInterval;

	public bool SorguAutoRefreshBool;

	public bool SorguAktifSatirBool;

	public bool SistemSinyalDegisimFiyatBool;

	public int SistemSinyalBarKaydirSayisi;

	public bool MouseKlikSistemCizdir;

	public DateTime MaxDDDate1;

	public DateTime MaxDDDate2;

	public int ReadingBarCount;

	public bool RobotWeekendEnabled;

	public bool RobotRiskBildirimOnay;

	public string RobotTime1;

	public string RobotTime2;

	public bool PortfoyLoginRemember;

	public int PortfoyForm;

	public string PortfoyLoginParola;

	public string PortfoyLoginPassword;

	public bool SistemLineBuySellColoring;

	public bool OtomatikRestartBool;

	public DateTime OtomatikRestartTime;

	public bool RobotRestart;

	public static bool RobotRestartedBool;

	public string CrmIp;

	public int CrmPort;

	public bool OtomatikSunucuBool;

	public string OtomatikSunucuAdres;

	public int OtomatikSunucuPort;

	public static string OtomatikGelenSunucuAdres;

	public static int OtomatikGelenSunucuPort;

	public int Language;

	public bool Kep2GerceklesenSutunlarBool;

	public bool Kep2BakiyeGizleBool;

	public bool EnUygunSunucuBool;

	public static string EnUygunSunucuAdres;

	public static int EnUygunSunucuPort;

	public int TaramaBarIcinde;

	public bool TaramaRefreshBool;

	public int TaramaRefreshPeriyot;

	public int TaramaDisplayType;

	public int TaramaFilterType;

	public int TaramaLeft;

	public int TaramaTop;

	public int TaramaWidth;

	public int TaramaHeight;

	public int TaramaSutunWidth;

	public int TaramaCanliBarType;

	public bool AnketGizleBool;

	public int AnketGun;

	public bool ChartMorningBarRemoveBool;

	public bool ChartMorningVIOPBarRemoveBool;

	public int ChartFlushPeriyot;

	public int SinyalDonusKademeSayisi;

	public bool TURIBL;

	public bool GKKUL;

	public bool ALGOCRYPT;

	public static int BE;

	public int BlackEdition;

	public Color WindowTitleBackColorBE;

	public Color WindowTitleMenuColorBE;

	public Color WindowButtonPassiveColorBE;

	public Color WindowButtonActiveColorBE;

	public Color WindowBottomBorderColorBE;

	public Color WhiteTitlePassiveColorBE;

	public Color WhiteTitleActiveColorBE;

	public Color WhiteTitleMenuColorBE;

	public Color WhiteButtonPassiveColorBE;

	public Color WhiteButtonActiveColorBE;

	public string ActiveBond;

	public string ActiveTahvilUV;

	public string ActiveUsd;

	public string ActiveEur;

	public string ActiveXu100;

	public string ActiveXuTum;

	public string ActiveAKBNK;

	public string ActiveDOHOL;

	public string ActiveEREGL;

	public string ActiveGARAN;

	public string ActiveISCTR;

	public string ActiveSAHOL;

	public string ActiveTCELL;

	public string ActiveTHYAO;

	public string ActiveTUPRS;

	public string ActiveVAKBN;

	public string ActiveXBN10;

	public string ActiveYKBNK;

	public string ActiveARCLK;

	public string ActiveASELS;

	public string ActiveBIMAS;

	public string ActiveEKGYO;

	public string ActiveENJSA;

	public string ActiveHALKB;

	public string ActiveKCHOL;

	public string ActiveTRMET;

	public string ActiveTRALT;

	public string ActiveKRDMD;

	public string ActivePETKM;

	public string ActivePGSUS;

	public string ActiveSISE;

	public string ActiveSODA;

	public string ActiveSOKM;

	public string ActiveENKAI;

	public string ActiveFROTO;

	public string ActiveMGROS;

	public string ActiveSASA;

	public string ActiveTRKCM;

	public string ActiveTSKB;

	public string ActiveX10XB;

	public string ActiveXLBNK;

	public string ActiveOYAKC;

	public string ActiveGUBRF;

	public string ActiveVESTL;

	public string ActiveAEFES;

	public string ActiveHEKTS;

	public string ActiveODAS;

	public string ActiveAKSEN;

	public string ActiveALARK;

	public string ActiveASTOR;

	public string ActiveKONTR;

	public string ActiveTAVHL;

	public string ActiveTKFEN;

	public string ActiveTOASO;

	public string ActiveTTKOM;

	public string ActiveCIMSA;

	public string ActiveDOAS;

	public string ActiveULKER;

	public string ActiveBRSAN;

	public string ActiveGBP;

	public string ActiveRUB;

	public string ActiveVipIx30;

	public string ActiveVipUsd;

	public string ActiveVipEur;

	public string ActiveVipUsdEur;

	public string ActiveVipGld;

	public string ActiveVipGoz;

	public float VipTemettu;

	public string ActiveVipAgUsd;

	public string ActiveVipXptUsd;

	public string ActiveVipXpdUsd;

	public string ImkbStartStr1;

	public string ImkbEndStr1;

	public string ImkbStartStr2;

	public string ImkbEndStr2;

	public string VipStartStr1;

	public string VipEndStr1;

	public string VipStartStr2;

	public string VipEndStr2;

	public string SaseStartStr1;

	public string SaseEndStr1;

	public string ImkbResetTime1;

	public string ImkbResetTime2;

	public string VipResetTime1;

	public List<string> IndicatorList1;

	public List<string> IndicatorList2;

	public List<string> IndicatorList3;

	public List<Color> IndicatorColor1;

	public List<Color> IndicatorColor2;

	public List<Color> IndicatorColor3;

	public List<Color> TakasLineColor;

	public List<int> TakasLineWidth;

	public float TakasGunFilter;

	public int TakasGunDisplayType;

	public float TakasDegisimFilter;

	public int TakasDegisimGunSayisi;

	public int TakasDegisimDisplayType;

	public int GridBotChartPatern;

	public int TrendBotChartPatern;

	public int YatayBotChartPatern;

	public string SistemExcelWoorkbool;

	public static cxSetting MySetting;

	public string MultiLisans
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CheckNewsLicense(string sourceX)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CheckPrefixLicense(string prefixX, out bool L1, out bool L1P, out bool L2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool MultiLisansCheck(string lisansCode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool MKKLisansCheck(bool showMessageBool)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Deserialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxSetting()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static cxSetting()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		DelayedServer = 0;
		CepServer = 0;
		OperationMode = 0;
		RobotServer = 0;
		ProductTypeNo = 61;
		ProductName = "IDEAL";
		Version = "1.23";
		BetaVersion = "";
		SessionID = "0";
		ActiveRemoteServerNo = 0;
		LastVersionCheck = true;
		MessengerServerEnabled = true;
		MainServerActiveBool = false;
		IdbPortNo = 0;
		DataAktarimPortNo = 0;
		ConnectionLogBool = false;
		RobotServerKota = 0;
		HizliBool = false;
		ScmIcinSifre = "";
		IndirVersion = false;
		ServerRobotKapaliKurumList = new List<string>();
		RobotKapaliKurumList = new List<string>();
		RobotKapaliBool = false;
		ViopPriceStepBool = false;
		_01_01_2026 = new DateTime(2026, 1, 1);
		RobotRestartedBool = false;
		OtomatikGelenSunucuAdres = "";
		OtomatikGelenSunucuPort = 0;
		EnUygunSunucuAdres = "";
		EnUygunSunucuPort = 0;
		BE = 0;
		MySetting = new cxSetting();
	}
}
