using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class ChartControl : UserControl
{
	public delegate void MessageDelegate(object senderX, DateTime msgTimeX, string msgTypeX, object msgObjectX);

	private class ChartEmirClass
	{
		public string Yon;

		public decimal Fiyat;

		public decimal Miktar;

		public Rectangle IptalRect;

		public float CizgiSeviye;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChartEmirClass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChartEmirClass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[Serializable]
	public class SerbestPoint
	{
		public int Barno;

		public float Level;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SerbestPoint()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SerbestPoint()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[Serializable]
	public class SerbestDrawClass
	{
		public int FrameNo;

		public Color Color;

		public int Width;

		public List<SerbestPoint> Points;

		public bool Visible
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SerbestDrawClass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SerbestDrawClass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public string Period;

	public decimal Rkademe;

	public bool TwoColorUsed;

	public bool DataWindowVisible;

	public bool MenuLineVisible;

	public bool SymbolLineVisible;

	public bool HBarVisible;

	public bool AverageVisible;

	public bool LastLevelVisible;

	public bool HorizontalGridVisible;

	public bool VerticalGridVisible;

	public bool SplitVisible;

	public enDrawStyles DrawStyle;

	public bool MultiMode;

	public bool BarStyleLine;

	public float BarSpace;

	public int LogMode;

	public int DividerMode;

	public string DividerBaseSymbol;

	public int FrameCount;

	public float PriceRegionWidth;

	public float EmptySpaceWidth;

	public string DateStart;

	public bool IndicatorValueVisible;

	public string SistemName;

	public bool SistemMultiBool;

	public bool LineChartBoxBool;

	public float ScaleMax;

	public float ScaleMin;

	public string ScaleSymbol;

	public string ScalePeriod;

	public float RenkoBrickSize;

	public bool KademeVisible;

	public bool DerinlikVisible;

	public Color FrameBackColor1;

	public Color FrameBackColor2;

	public Color FrameForeColor;

	public Color FrameBorderColor;

	public Color FrameActiveColor;

	public Color GridlineColor;

	public Color HighColor1;

	public Color HighColor2;

	public Color LowColor1;

	public Color LowColor2;

	public Color NormalColor;

	public Color AverageColor;

	public Color CurrentBarColor;

	public Color LineBoxColor;

	public Color FillColor1;

	public Color FillColor2;

	public int FillOpacity;

	public List<Color> SymbolColors;

	public Color BuyArrowColor;

	public Color SellArrowColor;

	public Color FlatArrowColor;

	public Color DataWindowBackColor1;

	public Color DataWindowBackColor2;

	public Color DataWindowForeColor;

	public Color DataWindowBorderColor;

	public int DataWindowOpacity;

	public Color IndicatorWindowBackColor1;

	public Color IndicatorWindowBackColor2;

	public Color IndicatorWindowForeColor;

	public Color IndicatorWindowBorderColor;

	public Color HbarBackColor1;

	public Color HbarBackColor2;

	public Color HbarForeColor;

	public Color HbarBorderColor;

	public Color HbarMidBackColor1;

	public Color HbarMidBackColor2;

	public Color HbarMidBorderColor;

	public Color MeasurementBackColor1;

	public Color MeasurementBackColor2;

	public Color MeasurementForeColor;

	public Color MeasurementBorderColor;

	public Color LastLevelForeColor;

	public Color LastLevelBackColor1;

	public Color LastLevelBackColor2;

	public Color LastLevelBorderColor;

	public Color TarihBackColor1;

	public Color TarihBackColor2;

	public bool TarihColoring;

	public bool TrendValueVisible;

	public Color PrevCloseForeColor;

	public Color PrevCloseBackColor1;

	public Color PrevCloseBackColor2;

	public Color PrevCloseBorderColor;

	public Color PrevCloseLineColor;

	private cxButton IndicatorWindowButtons;

	private cxButton IndicatorLabelButtons;

	private cxButton ElementLabelButtons;

	private cxButton MenuButtons;

	private cxButton MultiSymbolButtons;

	private Rectangle MultiModeRect;

	private Rectangle AverageRect;

	private Rectangle SymbolColorRect;

	private Rectangle BarStyleRect;

	private Rectangle DataWindowRect;

	private cxButton VerticalScaleButtons;

	private cxButton HorizontalScaleButtons;

	private Rectangle HbarMidRect;

	private Rectangle HbarLeftRect;

	private Rectangle HbarRightRect;

	private Font LabelFont;

	public Font FontSkala;

	public bool HacimBool;

	public bool HacimMaliyetBool;

	public int HacimKurumId;

	public int HacimDayCount;

	public bool HacimKzBool;

	public bool HacimKumulatifBool;

	public bool HacimDownloadBool;

	public bool DrawEnabled;

	public List<cxSymbol> Symbols;

	private List<cxBar> DividerData;

	private List<float> AverageData;

	private Dictionary<string, Control> ControlNames;

	public List<cxFrame> Frames;

	private cxMouseStatus MouseStatusObj;

	private enInsertAction InsertStatus;

	private List<cxGridLine> GridLines;

	public List<cxElement> Elements;

	private cxElement ActiveElement;

	private bool ElementActivated;

	private int ActiveIndicatorFrame;

	private int ActiveIndicatorNo;

	private cxThreeClick AndrewClick;

	private cxThreeClick FiboImpulseClick;

	private List<float> FiboVal;

	private List<int> FiboZone;

	private string DecimalFormat;

	private string DividerSymbol;

	private int ActiveFrameNo;

	private float FrameHeightRatio;

	private float FrameWidth;

	private float ChartTop;

	private int MenuHeight;

	private float ScrollMidLength;

	private float ScrollSideLength;

	private int ScrollDirection;

	private long ScrollTime;

	private float VerticalOffset;

	private int BarCount;

	public int LastBarNo;

	private int FirstBarNo;

	public int CurrentBarNo;

	private float RegionHeight;

	private int LoopPosition;

	private Queue<string> TakasRequestQueue;

	private Dictionary<string, double> TakasDictionary;

	private Dictionary<string, double> SplitDictionary;

	private long RealTimeUpdateTime;

	private long ReloadTime;

	private long DividerTime;

	private Stopwatch CheckTime;

	private Pen Pen1;

	private Pen PenDot;

	private SolidBrush Brush1;

	private Rectangle Rect1;

	private float X1;

	private float X2;

	private cxSistem SistemItem;

	private string EndeksSymbol;

	private bool EndekslerimBool;

	private string ElementString;

	private Dictionary<string, cxSistem> CustomIndicators;

	private Dictionary<string, decimal> ProfitLoss;

	private decimal PriceStep;

	public int SistemCalculationTime;

	public DateTime SistemBarDate;

	private Thread SistemThread;

	public bool OtoTrendBool;

	public int OtoTrendSure;

	public int OtoTrendSonBarOffset;

	public List<OtoTrendLineClass> OtoTrendLineList;

	public bool OtoTrendFiboExtend;

	public bool OtoTrendLineExtend;

	public bool OtoTrendNoktaVisible;

	public Color OtoTrendNoktaRenk;

	public bool OtoTrendDolguVisible;

	public Color OtoTrendDolguRenk;

	public int OtoTrendSaydamlik;

	public Color ToolboxBackColor1;

	public Color ToolboxBackColor2;

	public Color ToolboxForeColor;

	public Color ToolboxBorderColor;

	public Color ToolboxAktifBackColor;

	public Color ToolboxAktifForeColor;

	public bool SkalaToolboxVisible;

	public int SkalaToolboxX;

	public int SkalaToolboxY;

	public bool PeriyotToolboxVisible;

	public int PeriyotToolboxX;

	public int PeriyotToolboxY;

	private bool SerbestStartedBool;

	private Color SerbestColor;

	private int SerbestWidth;

	private int SerbestFrameNo;

	public List<SerbestDrawClass> SerbestLines;

	public static bool TrendsGizleGosterBool;

	public MessageDelegate ChartMessageEvent;

	private bool MouseUpSistemBool;

	public bool ReplayBool;

	private int ReplayLastBarNo;

	private List<cxBar> ReplayDataList;

	public string ReplayStartDateStr;

	public int ReplayBarDisplay;

	public int ReplayBarSaniye;

	public int ReplayTimerInterval;

	public static List<cxBar> SanalBarList;

	public static List<cxBar> ReplayFullBarList;

	private KademeDetayClass KademeData;

	private int KademeCalculationTime;

	private Color KademeAlis1Color;

	private Color KademeAlis2Color;

	private Color KademeSatis1Color;

	private Color KademeSatis2Color;

	private Color DerinlikAlis1Color;

	private Color DerinlikAlis2Color;

	private Color DerinlikSatis1Color;

	private Color DerinlikSatis2Color;

	private bool KurumBool;

	private DateTime KurumDate;

	public static int KurumSeviye;

	public static cxIndicator IndicatorToCopy;

	private List<IslemStruct1> IslemList;

	private Dictionary<decimal, ChartEmirClass> AlisEmirDictionary;

	private Dictionary<decimal, ChartEmirClass> SatisEmirDictionary;

	private List<ChartEmirClass> EmirList;

	private bool EmirDegistirStarted;

	private decimal EmirDegistirOldPrice;

	private decimal EmirDegistirNewPrice;

	private string EmirDegistirYon;

	public decimal EmirPenceresiFiyat;

	private decimal BestBekleyenAlisFiyat;

	private decimal BestBekleyenSatisFiyat;

	private bool HesapRefreshBool;

	private Rectangle SkalaToolboxRect;

	private Dictionary<string, Rectangle> SkalaToolboxDictionary;

	private bool ZoomStartedBool;

	private bool ZoomDrawStartedBool;

	private float ZoomBarSpace;

	private int ZoomLastBarNo;

	private bool ChartMoveStartedBool;

	private float ChartMoveScaleMax;

	private float ChartMoveScaleMin;

	private int ChartMoveLastBarNo;

	private int PanelTarihXPOS;

	private float PanelTarihWidth;

	private bool PanelTarihMoveBool;

	private int PanelExpandXPOS;

	private bool PanelExpandMoveBool;

	private bool PanelValueXbool;

	private int PanelValueXPOS;

	private float PanelValueWidth;

	private bool PriceLabelBool;

	private int PriceLabelYPOS;

	private Rectangle PriceLabelRect;

	private bool PanelValueYbool;

	private int PanelValueYPOS;

	private Rectangle PeriyotToolboxRect;

	private Dictionary<string, Rectangle> PeriyotToolboxDictionary;

	public static DateTime TakasDownloadTime;

	public static int TakasGunListeSayi;

	public List<string> TakasGunKurumList;

	public List<List<float>> TakasGunDataList;

	public static int TakasDegisimArtanListeSayi;

	public List<string> TakasDegisimArtanKurumList;

	public List<List<float>> TakasDegisimArtanDataList;

	public static int TakasDegisimAzalanListeSayi;

	public List<string> TakasDegisimAzalanKurumList;

	public List<List<float>> TakasDegisimAzalanDataList;

	private Point ImagePoint;

	private Point PictureStartLocation;

	private bool PictureMoveBool;

	private DateTime HacimReadTime;

	private bool HacimRedrawBool;

	public Thread Hacim_Thread;

	private List<cxBar> HacimBarList;

	private float HacimMax1;

	private float HacimMin1;

	private float HacimMax2;

	private float HacimMin2;

	private float HacimKz;

	private float HacimNet;

	private List<float> FaizMbList;

	private List<float> FaizMbExtList;

	private int FaizMbBarNo;

	private List<float> TufeTuikList;

	private int TufeTuikBarNo;

	private FormationRegion RegionDoubleTop;

	private bool DoubleTopBool;

	private IContainer components;

	private Panel panelChart0;

	private Panel panelValue0;

	private Panel panelValue1;

	private Panel panelChart1;

	private Panel panelValue2;

	private Panel panelChart2;

	private Panel panelValue3;

	private Panel panelChart3;

	private Panel panelValue4;

	private Panel panelChart4;

	private Panel panelValue5;

	private Panel panelChart5;

	private Panel panelValue6;

	private Panel panelChart6;

	private Panel panelValue7;

	private Panel panelChart7;

	private Panel panelValue8;

	private Panel panelChart8;

	private Panel panelValue9;

	private Panel panelChart9;

	private Panel panelHBar;

	private ToolTip toolTipChart;

	public TextBox textTrend;

	private ContextMenuStrip menuTrendProperty;

	private ToolStripMenuItem menuTrendPropertyEdit;

	private ToolStripMenuItem menuTrendPropertyParallel;

	private ToolStripMenuItem menuTrendPropertyExtend;

	private ToolStripSeparator toolStripMenuItem1;

	private ToolStripMenuItem menuTrendPropertyDelete;

	private ToolStripMenuItem menuTrendPropertyColor;

	private ToolStripMenuItem menuTrendPropertySnap;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripMenuItem menuTrendPropertyDeleteSymbol;

	private ToolStripMenuItem menuTrendPropertyDeleteAll;

	public TextBox textSymbolAdd;

	public TextBox textSymbolChange;

	private ContextMenuStrip menuDivider;

	private ToolStripMenuItem menuDividerORJ;

	private ToolStripMenuItem menuDividerUSD;

	private ToolStripMenuItem menuDividerEUR;

	private ToolStripMenuItem menuDividerXU100;

	private ToolStripMenuItem menuDividerSymbol;

	public TextBox textSymbolDivide;

	public Timer timerToolTip;

	public Timer timerCursors;

	public BackgroundWorker backworker;

	private Timer timerScroll;

	private ToolStripMenuItem menuTrendPropertyFont;

	private ContextMenuStrip menuPeriod;

	private ToolStripMenuItem menuPeriyodSub01;

	private ToolStripMenuItem menuPeriyodSub02;

	private ToolStripMenuItem menuPeriyodSub03;

	private ToolStripMenuItem menuPeriyodSub04;

	private ToolStripMenuItem menuPeriyodSub05;

	private ToolStripMenuItem toolStripMenuItem06;

	private ToolStripMenuItem menuPeriyodSub07;

	private ToolStripMenuItem menuPeriyodSub08;

	private ToolStripMenuItem menuPeriyodSub09;

	private ToolStripMenuItem menuPeriyodSub10;

	private ToolStripMenuItem menuPeriyodSub11;

	private ToolStripMenuItem menuPeriyodSub12;

	private ToolStripMenuItem menuPeriyodSub13;

	private ToolStripMenuItem menuPeriyodSub0114;

	private ToolStripMenuItem menuPeriyodSub15;

	private ToolStripMenuItem menuPeriyodSub16;

	private ToolStripMenuItem menuPeriyodSub17;

	private ToolStripMenuItem menuPeriyodSub18;

	private ToolStripMenuItem menuPeriyodSub19;

	private ToolStripMenuItem menuPeriyodSub20;

	private ToolStripSeparator toolStripMenuItem2;

	private ToolStripMenuItem menuTrendPropertyAlarm;

	private ToolStripMenuItem menuTrendPropertyAlarmDef;

	private ToolStripMenuItem menuTrendPropertyAlarmListe;

	private ToolStripMenuItem menuTrendPropertyAlarmiSil;

	private ToolStripMenuItem menuTrendPropertyAlarmKisaCizgi;

	private ToolStripMenuItem menuTrendPropertyZincirStop;

	private ToolStripSeparator toolStripSeparator2;

	private ToolStripMenuItem menuPeriyodSub21;

	private ToolStripMenuItem menuPeriyodSub22;

	private ToolStripMenuItem menuPeriyodSub23;

	private ToolStripMenuItem menuPeriyodSub24;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripSeparator toolStripSeparator4;

	public Timer timerReplay;

	private ToolStripSeparator toolStripMenuItem3;

	private ToolStripMenuItem menuBarKopyala;

	public Timer timerKurumBul;

	private ToolStripSeparator toolStripMenuItem4;

	private ToolStripMenuItem menuAlanSatan;

	private ToolStripMenuItem menuPeriyodSub25;

	private PictureBox pictureBox;

	private ToolStripMenuItem menuDividerSpread;

	private ToolStripMenuItem menuDividerFark;

	public decimal _Rkademe
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (decimal)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ChartControl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myChartControl_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myChartControl_MouseWheel(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myChartControl_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void backworker_DoWork(object sender, DoWorkEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void backworker_ProgressChanged(object sender, ProgressChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void backworker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuDivider_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuPeriyodSub_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTrendPropertyAlarmiSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTrendPropertyParallel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTrendPropertyDelete_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTrendPropertyExtend_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTrendPropertyEdit_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTrendPropertyColor_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTrendPropertyFont_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTrendPropertySnap_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTrendPropertyAlarm_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTrendPropertyAlarmDef_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTrendPropertyAlarmListe_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTrendPropertyDeleteSymbol_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTrendPropertyDeleteAll_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTrendPropertyRobotCopy_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTrendPropertyZincirStop_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart0_DragDrop(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart0_DragEnter(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart0_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart0_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart0_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart0_MouseDoubleClick(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart0_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelValue0_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelValue0_MouseDoubleClick(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelValue0_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelValue0_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelValue0_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelHBar_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelHBar_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelHBar_MouseLeave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelHBar_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelHBar_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbolAdd_Leave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbolAdd_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbolAdd_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbolChange_Leave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbolChange_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbolChange_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbolDivide_Leave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbolDivide_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbolDivide_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textTrend_Leave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerCursors_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerScroll_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerToolTip_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float AdjustBarSpace(float xBarSpace)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CalculateRangeSymbol(int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CalculateRangeIndicator(int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float CalculateIncrement(float xHigh, float xLow)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CalculateFiboRet(PointF point1X, PointF point2X, int framenoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CalculateLinReg(int elementNo, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private enCheckTypes CheckElementWithMouse(cxElement element, PointF pointIn, int frameNo)
	{
		return (enCheckTypes)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int CheckIndicatorWithMouse(cxIndicator item, PointF pointCheck, int frameNoX)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ConvertPointsToTrend(bool inserted, PointF pointIn1, PointF pointIn2, int frameNo, enElementTypes elementType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawChartLine(Graphics graph, int panel, int barno1, float price1, int barno2, float price2, Color color, int kalinlik, int stil, bool extendbool, bool pointsbool, Color pointscolor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawIndicatorFill(Graphics graph, cxIndicator indicator, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawIndicatorLine(Graphics graph, int indicatorNoX, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawIndicatorSpecial(Graphics graph, int indicatorNoX, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawSistem(Graphics graph, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawSistemMultiFrame0(Graphics graph)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawSistemMultiFrame1(Graphics graph)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawSistemObjects(Graphics graph, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawTrendLine(Graphics graph, int elementNo, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawTrendAndrew(Graphics graph, int elementNo, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawTrendArrow(Graphics graph, int elementNo, int frameNo, string str)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawTrendCircle(Graphics graph, int elementNo, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawTrendCycle(Graphics graph, int elementNo, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawTrendEqChannel(Graphics graph, int elementNo, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawTrendFiboChannel(Graphics graph, int elementNo, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawTrendFiboArc(Graphics graph, int elementNo, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawTrendFiboFan(Graphics graph, int elementNo, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawTrendFiboImpulse(Graphics graph, int elementNo, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawTrendFiboRet(Graphics graph, int elementNo, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawTrendFiboZone(Graphics graph, int elementNo, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawTrendGannFan(Graphics graph, int elementNo, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawTrendGannGrid(Graphics graph, int elementNo, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawTrendLinReg(Graphics graph, int elementNo, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawTrendRaffChannel(Graphics graph, int elementNo, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawTrendSpeed(Graphics graph, int elementNo, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawTrendStDevChannel(Graphics graph, int elementNo, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawTrendStErrorChannel(Graphics graph, int elementNo, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawTrendQuadrant(Graphics graph, int elementNo, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawTrendSquare(Graphics graph, int elementNo, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawTrendTirone(Graphics graph, int elementNo, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawTrendText(Graphics graph, int elementNo, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawTrendVertical(Graphics graph, int elementNo, int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuTrendPropertyAlarmKisaCizgi_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetBarNoFromPoint(float horizontalPos)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetBarNoFromDate(DateTime dateIn)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetElementString(DateTime date1X, float val1X, DateTime date2X, float val2X)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte GetGridlineColorStatus(byte statusX)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float GetHorizontalPos(int barNo)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float GetHorizontalDiscretePos(float horizontalPos)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetIndicatorValueString(float priceX, int frameNoX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float GetPointFromValue(int frameNo, float valueIn)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float GetPointFromValue(int framenoX, float priceX, float maxX, float minX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetPriceValueString(float priceX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool GetTrendPoints(cxElement element, int frameNo)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PointF GetTrendPointFromY(PointF pointIn1, PointF pointIn2, float verticalPos)
	{
		return (PointF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PointF GetTrendPointFromX(PointF pointIn1, PointF pointIn2, float xX)
	{
		return (PointF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Rectangle GetTrendRectangleFromPoint(PointF pointIn1, PointF pointIn2, PointF pointIn)
	{
		return (Rectangle)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float GetValueFromPoint(int frameNo, float pointIn)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetOtoTrendYukselenPoints(int otostartbarno, int otoendbarno, int sonbaroffset, out int bar1, out float price1, out int bar2, out float price2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetOtoTrendDusenPoints(int otostartbarno, int otoendbarno, int sonbaroffset, out int bar1, out float price1, out int bar2, out float price2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitFiboZone()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadDividerData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrepareGridLines()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCursorType(Cursor cursorIn)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCursors()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetToolTip()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowElementParameters()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActivateNextStock()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActivateSymbolEnrty(string str, int leftValX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddNewSymbol(int leftValX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeBlackEdition()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeEurolineEdition()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeLinLog(int logMode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangePeriod(string periodIn)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeSymbol(string symbolCode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeleteBar()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeleteAllBars()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckCustomIndSaved(string customnameX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CopyToExcel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawAll(bool calculaterangeX, bool calculateindicatorX, int invalidateX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawIndicatorsOnly()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EditBar()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExportToFile()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetActiveSymbolName()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetCurrentBarNo()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetDivideModeString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetDrawStyleString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetFormasyon(string formasyonType)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetPeriodString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ImportFromFile()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ImportFromFileMetaTrader()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InsertElement(string elementType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InsertFormasyon(string formasyonType, bool onoff)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InsertIndicator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InsertIndicator(int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InsertIndicatorForSistemMulti()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InsertIndicators(List<cxIndicator> indicatorsx)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InsertSymbol(string symbolCode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoopNextStock()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoopPreviousStock()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ParalelTrendCiz()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessParamMenu(string keyX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessRealTimeData(string symbolX, bool calclastBarVolBool)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessKurumData(IslemStruct1 itemX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReadData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RecalculateSistem()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveFrame(int frameNo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveSymbol(int no)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ScaleCompress()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ScaleCompressToolbar()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ScaleExpand()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ScaleLeft()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ScaleBackward()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ScaleRight()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ScaleForward()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ScaleEnd()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ScaleHome()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ScaleHome2()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ScaleDown()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ScaleUp()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ScalePageDown()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ScalePageUp()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDivider(int xMode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSize(int leftIn, int topIn, int widthIn, int heightIn)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowDividerMenu(Point point)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowIndicatorValues()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowParamMenu(Point point)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowPeriodMenu(Point point)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowTrendMenu(Point point)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowFormasyonMenu(Point point)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SplitStock()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TrendDelete()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateTrendAlarms()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FiyatAlarmiEkle()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void IndikatorAlarmiEkle()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLanguage()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnMessage(object senderX, DateTime msgTimeX, string msgTypeX, object msgObjectX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuBarKopyala_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerReplay_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PrepareReplayData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartReplay()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GoBackward()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GoForward()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SanalModVeriEkle()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SanalModVeriDegistir()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SanalModBellektenYapistir()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SanalModTersYapistir()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SanalModFiyatTersYapistir()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SanalModVeriSil()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CalculateKademe()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuAlanSatan_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerKurumBul_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CopyIndicator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PasteIndicator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessBirimYontemMenu(int yontem)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessBirimSeviyeMenu(int seviye)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowAlanSatanAktivite(cxElement element)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FaizEkle()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FaizSil()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TufeTuikEkle()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TufeTuikSil()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RequestData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReadEmirler()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DownloadTakas()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReadTakasGun()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReadTakasDegisim()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pictureBox_DoubleClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pictureBox_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pictureBox_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pictureBox_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PasteImage()
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
	static ChartControl()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		TrendsGizleGosterBool = true;
		SanalBarList = new List<cxBar>();
		ReplayFullBarList = new List<cxBar>();
		KurumSeviye = 5;
		IndicatorToCopy = null;
		DateTime dateTime = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
		TakasDownloadTime = gr7jwURt1t3VJtiGGT.r7iItWL60(ref dateTime, -11.0, gr7jwURt1t3VJtiGGT.i6VDqvtbwt);
		TakasGunListeSayi = 10;
		TakasDegisimArtanListeSayi = 10;
		TakasDegisimAzalanListeSayi = 10;
	}
}
