using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class cxPage
{
	[Serializable]
	public class Watchlist
	{
		public int ClassVersion;

		public int Left;

		public int Top;

		public int Width;

		public int Height;

		public Font FontData;

		public int LineSpace;

		public bool GridlineVisible;

		public bool VbarVisible;

		public int SortField;

		public int SortDirection;

		public int SortPeriod;

		public string WatchlistName;

		public string HeaderName;

		public bool HeaderVisible;

		public bool ActiveCellPainting;

		public bool RelationalPainting;

		public string SearchString;

		public string ExcelFileName;

		public bool ExcelPeriodic;

		public int ExcelInterval;

		public bool TopMostEnabled;

		public byte CurrencyPrice;

		public byte CurrencyVolume;

		public bool VipFilter;

		public string VipSymbol;

		public bool VipFutures;

		public bool VipOptions;

		public bool VipPut;

		public bool VipCall;

		public string VipExpiry;

		public bool TitleVisible;

		public int ScrollPeriod;

		public bool VarantFilter;

		public string VarantFilterSymbol;

		public bool VarantFilterPut;

		public bool VarantFilterCall;

		public string VarantFilterExpiry;

		public string HesapRumuz;

		public bool FonFilter;

		public int[] ColCode;

		public int[] ColWidth;

		public int[] ColKurumId;

		public Dictionary<string, string> SymbolDictionary;

		public Color HeaderBorderColor;

		public Color HeaderBackColor1;

		public Color HeaderBackColor2;

		public Color HeaderButtonPassiveColor;

		public Color HeaderButtonActiveColor;

		public Color HeaderTextForeColor;

		public Color HeaderMenuForeColor;

		public Color[] RowBackColors;

		public Color[] HighLowColors;

		public Color SymbolBackColor;

		public Color SymbolForeColor;

		public Color RelationalNewsColor;

		public Color SearchColor;

		public Color UniqueSearchColor;

		public Color GridlineColor;

		public Color TitleBackColor1;

		public Color TitleBackColor2;

		public Color TitleForeColor;

		public Color TitleBorderColor;

		public Color ActiveCellBackColor1;

		public Color ActiveCellBackColor2;

		public Color ActiveCellForeColor;

		public Color[] UpdateBackColors;

		public Color[] UpdateForeColors;

		public Color VbarBackColor1;

		public Color VbarBackColor2;

		public Color VbarForeColor;

		public Color VbarBorderColor;

		public Color VbarButtonBackColor1;

		public Color VbarButtonBackColor2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Watchlist()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Watchlist()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[Serializable]
	public class Depth
	{
		public int ClassVersion;

		public int Left;

		public int Top;

		public int Width;

		public int Height;

		public string ActiveSymbol;

		public Font FontData;

		public int LineSpace;

		public bool GridlineVisible;

		public bool TradeVisible;

		public bool BasicVisible;

		public bool MoneyflowVisible;

		public bool DepthHeaderVisible;

		public bool TradeHeaderVisible;

		public int CompositeShow;

		public bool PistonVisible;

		public bool TopMostEnabled;

		public int DepthLineCount;

		public bool GrupMember;

		public bool Average1Visible;

		public bool Average2Visible;

		public bool LastTradeVisible;

		public byte VolumeFormat;

		public bool UseHighLowColorinDepth;

		public bool BasicSingleRow;

		public bool InnerTopMostEnabled;

		public bool EmirVisible;

		public int EmirTipi;

		public int EmirMiktar;

		public bool EmirOnay;

		public bool PgcVisible;

		public string PgcPeriyot;

		public int PgcSeviye;

		public bool TwitterVisible;

		public cxGrid TradeGrid;

		public cxGrid DepthGrid;

		public cxGrid BasicGrid;

		public cxGrid MoneyflowGrid;

		public int[,] BasicColCode;

		public Color HeaderBorderColor;

		public Color HeaderBackColor1;

		public Color HeaderBackColor2;

		public Color HeaderButtonPassiveColor;

		public Color HeaderButtonActiveColor;

		public Color HeaderTextForeColor;

		public Color HeaderMenuForeColor;

		public Color TitleBackColor1;

		public Color TitleBackColor2;

		public Color TitleForeColor;

		public Color TitleBorderColor;

		public Color ActiveCellBackColor1;

		public Color ActiveCellBackColor2;

		public Color ActiveCellForeColor;

		public Color GridBackColor;

		public Color GridForeColor;

		public Color NormalColor;

		public Color HighColor;

		public Color LowColor;

		public Color RelationalNewsColor;

		public Color AverageLineBackColor;

		public Color AverageLineForeColor;

		public Color CurrentLineBackColor;

		public Color CurrentLineForeColor;

		public Color GridlineColor;

		public Color MarketMakerBidBackColor;

		public Color MarketMakerBidForeColor;

		public Color MarketMakerAskBackColor;

		public Color MarketMakerAskForeColor;

		public Color UpdateNormalBackColor;

		public Color UpdateNormalForeColor;

		public Color UpdateHighBackColor;

		public Color UpdateHighForeColor;

		public Color UpdateLowBackColor;

		public Color UpdateLowForeColor;

		public Color VbarBackColor1;

		public Color VbarBackColor2;

		public Color VbarForeColor;

		public Color VbarBorderColor;

		public Color VbarButtonBackColor1;

		public Color VbarButtonBackColor2;

		public Color BasicHeaderBackColor;

		public Color BasicHeaderForeColor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Depth()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Depth()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[Serializable]
	public class MultiDepth
	{
		public int ClassVersion;

		public int Left;

		public int Top;

		public int Width;

		public int Height;

		public Font FontData;

		public int LineSpace;

		public bool GridlineVisible;

		public int VisibleRows;

		public bool Average1Visible;

		public bool Average2Visible;

		public bool TimeVisible;

		public int TimeWidth;

		public bool OrderVisible;

		public int OrderWidth;

		public bool VolVisible;

		public int VolWidth;

		public bool SizeVisible;

		public int SizeWidth;

		public bool PriceVisible;

		public int PriceWidth;

		public int FrameColCount;

		public bool PistonVisible;

		public byte SessionChangeSelected;

		public bool TopMostEnabled;

		public List<string> SerializeSymbolNames;

		public List<int> SerializeSymbolRows;

		public List<int> SerializeSymbolCols;

		public Color HeaderBorderColor;

		public Color HeaderBackColor1;

		public Color HeaderBackColor2;

		public Color HeaderButtonPassiveColor;

		public Color HeaderButtonActiveColor;

		public Color HeaderTextForeColor;

		public Color HeaderMenuForeColor;

		public Color GridBackColor;

		public Color GridForeColor;

		public Color SymbolColor;

		public Color NormalColor;

		public Color HighColor;

		public Color LowColor;

		public Color RelationalNewsColor;

		public Color AverageLineBackColor;

		public Color AverageLineForeColor;

		public Color CurrentLineBackColor;

		public Color CurrentLineForeColor;

		public Color PassiveBorderColor;

		public Color ActiveBorderColor;

		public Color MarketMakerBidBackColor;

		public Color MarketMakerBidForeColor;

		public Color MarketMakerAskBackColor;

		public Color MarketMakerAskForeColor;

		public Color SymbolLineBackColor1;

		public Color SymbolLineBackColor2;

		public Color SymbolLineBorderColor;

		public Color UpdateNormalBackColor;

		public Color UpdateNormalForeColor;

		public Color UpdateHighBackColor;

		public Color UpdateHighForeColor;

		public Color UpdateLowBackColor;

		public Color UpdateLowForeColor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MultiDepth()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static MultiDepth()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[Serializable]
	public class Chart
	{
		public int ClassVersion;

		public int Left;

		public int Top;

		public int Width;

		public int Height;

		public string Period;

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

		public bool TopMostEnabled;

		public bool GrupMember;

		public bool IndicatorValueVisible;

		public string SistemName;

		public bool LineChartBoxBool;

		public int DonguPeriyot;

		public float ScaleMax;

		public float ScaleMin;

		public string ScaleSymbol;

		public string ScalePeriod;

		public float RenkoBrickSize;

		public bool KademeVisible;

		public bool DerinlikVisible;

		public List<cxFrame> SerializeFrames;

		public List<cxElement> SerializeElements;

		public List<cxSymbol> SerializeSymbols;

		public List<ChartControl.SerbestDrawClass> SerbestLines;

		public Color HeaderBorderColor;

		public Color HeaderBackColor1;

		public Color HeaderBackColor2;

		public Color HeaderButtonPassiveColor;

		public Color HeaderButtonActiveColor;

		public Color HeaderTextForeColor;

		public Color HeaderMenuForeColor;

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

		public Color[] SymbolColors;

		public Color BuyArrowColor;

		public Color SellArrowColor;

		public Color FlatArrowColor;

		public Color DataWindowBackColor1;

		public Color DataWindowBackColor2;

		public Color DataWindowForeColor;

		public Color DataWindowBorderColor;

		public int DataWindowOpacity;

		public Color LastLevelBackColor1;

		public Color LastLevelBackColor2;

		public Color LastLevelForeColor;

		public Color LastLevelBorderColor;

		public Color MeasurementBackColor1;

		public Color MeasurementBackColor2;

		public Color MeasurementForeColor;

		public Color MeasurementBorderColor;

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

		public Color TarihBackColor1;

		public Color TarihBackColor2;

		public bool TarihColoring;

		public Color ToolBarBackColor;

		public Color ToolBarForeColor;

		public Color ToolBarActiveColor;

		public bool ToolBarVisible;

		public bool TrendValueVisible;

		public Color PrevCloseBackColor1;

		public Color PrevCloseBackColor2;

		public Color PrevCloseForeColor;

		public Color PrevCloseBorderColor;

		public Color PrevCloseLineColor;

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

		public decimal Rkademe;

		public Font FontSkala;

		public bool HacimBool;

		public int HacimKurumId;

		public int HacimDayCount;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Chart()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Chart()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[Serializable]
	public class Trade
	{
		public int ClassVersion;

		public int Left;

		public int Top;

		public int Width;

		public int Height;

		public Font FontData;

		public int LineSpace;

		public bool GridlineVisible;

		public int CompositeShow;

		public string SymbolFilter;

		public string SymbolSelectString;

		public byte Period;

		public DateTime HistoricDate;

		public double VolumeFilter;

		public int TitleHeight;

		public bool SummaryVisible;

		public cxGrid TradeGrid;

		public cxGrid MoneyflowGrid;

		public Color HeaderBorderColor;

		public Color HeaderBackColor1;

		public Color HeaderBackColor2;

		public Color HeaderButtonPassiveColor;

		public Color HeaderButtonActiveColor;

		public Color HeaderTextForeColor;

		public Color HeaderMenuForeColor;

		public Color TitleBackColor1;

		public Color TitleBackColor2;

		public Color TitleForeColor;

		public Color TitleBorderColor;

		public Color ActiveCellBackColor1;

		public Color ActiveCellBackColor2;

		public Color ActiveCellForeColor;

		public Color GridBackColor;

		public Color GridForeColor;

		public Color NormalColor;

		public Color HighColor;

		public Color LowColor;

		public Color CurrentLineBackColor;

		public Color CurrentLineForeColor;

		public Color GridlineColor;

		public Color UpdateNormalBackColor;

		public Color UpdateNormalForeColor;

		public Color UpdateHighBackColor;

		public Color UpdateHighForeColor;

		public Color UpdateLowBackColor;

		public Color UpdateLowForeColor;

		public Color VbarBackColor1;

		public Color VbarBackColor2;

		public Color VbarForeColor;

		public Color VbarBorderColor;

		public Color VbarButtonBackColor1;

		public Color VbarButtonBackColor2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Trade()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Trade()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[Serializable]
	public class NewsHeader
	{
		public int Left;

		public int Top;

		public int Width;

		public int Height;

		public Font FontData;

		public int LineSpace;

		public bool GridlineVisible;

		public int SelectionStatus;

		public string SearchString;

		public string SelectString;

		public bool TooltipEnabled;

		public bool TopMostEnabled;

		public bool GrupMember;

		public bool SourceTRK;

		public bool SourceDJBN;

		public bool SourceDJA;

		public bool SourceDJCS;

		public bool SourceDJES;

		public bool SourceDJF;

		public bool SourceDJN;

		public int ClassVersion;

		public Color KapColor;

		public string SymbolString;

		public cxGrid DataGrid;

		public Color HeaderBorderColor;

		public Color HeaderBackColor1;

		public Color HeaderBackColor2;

		public Color HeaderButtonPassiveColor;

		public Color HeaderButtonActiveColor;

		public Color HeaderTextForeColor;

		public Color HeaderMenuForeColor;

		public Color TitleBackColor1;

		public Color TitleBackColor2;

		public Color TitleForeColor;

		public Color TitleBorderColor;

		public Color GridBackColor;

		public Color GridForeColor;

		public Color CurrentLineBackColor;

		public Color CurrentLineForeColor;

		public Color GridlineColor;

		public Color FlashBackColor;

		public Color FlashForeColor;

		public Color FilterColor;

		public Color SelectColor;

		public Color VbarBackColor1;

		public Color VbarBackColor2;

		public Color VbarForeColor;

		public Color VbarBorderColor;

		public Color VbarButtonBackColor1;

		public Color VbarButtonBackColor2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NewsHeader()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static NewsHeader()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[Serializable]
	public class TopStocks
	{
		public int Left;

		public int Top;

		public int Width;

		public int Height;

		public Font FontData;

		public int LineSpace;

		public bool GridlineVisible;

		public string SelectString;

		public string SymbolString;

		public string PeriodString;

		public bool TooltipEnabled;

		public bool TopMostEnabled;

		public DateTime Interval1;

		public DateTime Interval2;

		public cxGrid DataGrid;

		public Color HeaderBorderColor;

		public Color HeaderBackColor1;

		public Color HeaderBackColor2;

		public Color HeaderButtonPassiveColor;

		public Color HeaderButtonActiveColor;

		public Color HeaderTextForeColor;

		public Color HeaderMenuForeColor;

		public Color TitleBackColor1;

		public Color TitleBackColor2;

		public Color TitleForeColor;

		public Color TitleBorderColor;

		public Color GridBackColor;

		public Color GridForeColor;

		public Color NormalColor;

		public Color HighColor;

		public Color LowColor;

		public Color CurrentLineBackColor;

		public Color CurrentLineForeColor;

		public Color GridlineColor;

		public Color SelectColor;

		public Color VbarBackColor1;

		public Color VbarBackColor2;

		public Color VbarForeColor;

		public Color VbarBorderColor;

		public Color VbarButtonBackColor1;

		public Color VbarButtonBackColor2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TopStocks()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TopStocks()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[Serializable]
	public class StocksStatus
	{
		public int Left;

		public int Top;

		public int Width;

		public int Height;

		public Font FontData;

		public int LineSpace;

		public bool GridlineVisible;

		public string SelectString;

		public string StatusKodString;

		public string PeriodString;

		public bool TooltipEnabled;

		public DateTime Interval1;

		public DateTime Interval2;

		public cxGrid DataGrid;

		public Color HeaderBorderColor;

		public Color HeaderBackColor1;

		public Color HeaderBackColor2;

		public Color HeaderButtonPassiveColor;

		public Color HeaderButtonActiveColor;

		public Color HeaderTextForeColor;

		public Color HeaderMenuForeColor;

		public Color TitleBackColor1;

		public Color TitleBackColor2;

		public Color TitleForeColor;

		public Color TitleBorderColor;

		public Color GridBackColor;

		public Color GridForeColor;

		public Color NormalColor;

		public Color HighColor;

		public Color LowColor;

		public Color CurrentLineBackColor;

		public Color CurrentLineForeColor;

		public Color GridlineColor;

		public Color SelectColor;

		public Color VbarBackColor1;

		public Color VbarBackColor2;

		public Color VbarForeColor;

		public Color VbarBorderColor;

		public Color VbarButtonBackColor1;

		public Color VbarButtonBackColor2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StocksStatus()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static StocksStatus()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[Serializable]
	public class Detail
	{
		public int Left;

		public int Top;

		public int Width;

		public int Height;

		public string ActiveSymbol;

		public Font FontData;

		public int LineSpace;

		public bool GrupMember;

		public byte CurrencyPrice;

		public byte CurrencyVolume;

		public short PGCGosterim;

		public Color HeaderBorderColor;

		public Color HeaderBackColor1;

		public Color HeaderBackColor2;

		public Color HeaderButtonPassiveColor;

		public Color HeaderButtonActiveColor;

		public Color HeaderTextForeColor;

		public Color HeaderMenuForeColor;

		public Color FormBackColor;

		public Color LabelBackColor1;

		public Color LabelBackColor2;

		public Color LabelForeColor;

		public Color LabelBorderColor;

		public Color ValueBackColor1;

		public Color ValueBackColor2;

		public Color ValueBorderColor;

		public Color NormalColor;

		public Color HighColor;

		public Color LowColor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Detail()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Detail()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[Serializable]
	public class Step
	{
		public int ClassVersion;

		public int Left;

		public int Top;

		public int Width;

		public int Height;

		public string ActiveSymbol;

		public string PeriodString;

		public Font FontData;

		public int LineSpace;

		public bool GridlineVisible;

		public bool GrupMember;

		public DateTime HistoricDate;

		public DateTime Interval1;

		public DateTime Interval2;

		public string Hour1;

		public string Hour2;

		public cxGrid DataGrid;

		public Color HeaderBorderColor;

		public Color HeaderBackColor1;

		public Color HeaderBackColor2;

		public Color HeaderButtonPassiveColor;

		public Color HeaderButtonActiveColor;

		public Color HeaderTextForeColor;

		public Color HeaderMenuForeColor;

		public Color TitleBackColor1;

		public Color TitleBackColor2;

		public Color TitleForeColor;

		public Color TitleBorderColor;

		public Color GridBackColor;

		public Color GridForeColor;

		public Color NormalColor;

		public Color HighColor;

		public Color LowColor;

		public Color CurrentLineBackColor1;

		public Color CurrentLineBackColor2;

		public Color CurrentLineBorderColor;

		public Color GridlineColor;

		public Color VbarBackColor1;

		public Color VbarBackColor2;

		public Color VbarForeColor;

		public Color VbarBorderColor;

		public Color VbarButtonBackColor1;

		public Color VbarButtonBackColor2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Step()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Step()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[Serializable]
	public class Tcmb
	{
		public int Left;

		public int Top;

		public int Width;

		public int Height;

		public Font FontData;

		public int LineSpace;

		public bool GridlineVisible;

		public bool TooltipEnabled;

		public string PageKey;

		public cxGrid DataGrid;

		public Color HeaderBorderColor;

		public Color HeaderBackColor1;

		public Color HeaderBackColor2;

		public Color HeaderButtonPassiveColor;

		public Color HeaderButtonActiveColor;

		public Color HeaderTextForeColor;

		public Color HeaderMenuForeColor;

		public Color TitleBackColor1;

		public Color TitleBackColor2;

		public Color TitleForeColor;

		public Color TitleBorderColor;

		public Color GridBackColor;

		public Color GridForeColor;

		public Color CurrentLineBackColor;

		public Color CurrentLineForeColor;

		public Color GridlineColor;

		public Color VbarBackColor1;

		public Color VbarBackColor2;

		public Color VbarForeColor;

		public Color VbarBorderColor;

		public Color VbarButtonBackColor1;

		public Color VbarButtonBackColor2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Tcmb()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Tcmb()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[Serializable]
	public class Interbank
	{
		public int Left;

		public int Top;

		public int Width;

		public int Height;

		public Font FontData;

		public int LineSpace;

		public bool GridlineVisible;

		public cxGrid BasicGrid;

		public Color HeaderBorderColor;

		public Color HeaderBackColor1;

		public Color HeaderBackColor2;

		public Color HeaderButtonPassiveColor;

		public Color HeaderButtonActiveColor;

		public Color HeaderTextForeColor;

		public Color HeaderMenuForeColor;

		public Color TitleBackColor1;

		public Color TitleBackColor2;

		public Color TitleForeColor;

		public Color TitleBorderColor;

		public Color GridBackColor;

		public Color GridForeColor;

		public Color NormalColor;

		public Color HighColor;

		public Color LowColor;

		public Color CurrentLineBackColor;

		public Color CurrentLineForeColor;

		public Color GridlineColor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Interbank()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Interbank()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[Serializable]
	public class Clock
	{
		public int Left;

		public int Top;

		public int Width;

		public int Height;

		public Font FontData;

		public int TimeDifference;

		public string CityName;

		public bool HeaderVisible;

		public bool TopMostEnabled;

		public Color HeaderBorderColor;

		public Color HeaderBackColor1;

		public Color HeaderBackColor2;

		public Color HeaderButtonPassiveColor;

		public Color HeaderButtonActiveColor;

		public Color HeaderTextForeColor;

		public Color HeaderMenuForeColor;

		public Color BackColor1;

		public Color BackColor2;

		public Color BorderColor;

		public Color ForeColor1;

		public Color ForeColor2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Clock()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Clock()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[Serializable]
	public class Map
	{
		public int Left;

		public int Top;

		public int Width;

		public int Height;

		public Font FontData;

		public int LineSpace;

		public string SymbolString;

		public string PeriodString;

		public bool TooltipEnabled;

		public int ColWidth;

		public bool ValueVisible;

		public int SortDirection;

		public int SortField;

		public int SymbolCount;

		public Color HeaderBorderColor;

		public Color HeaderBackColor1;

		public Color HeaderBackColor2;

		public Color HeaderButtonPassiveColor;

		public Color HeaderButtonActiveColor;

		public Color HeaderTextForeColor;

		public Color HeaderMenuForeColor;

		public Color GridBackColor;

		public Color GridForeColor;

		public Color GridLineColor;

		public Color NormalColor;

		public Color HighColor;

		public Color LowColor;

		public Color GridlineColor;

		public Color VolumeColor;

		public Color VbarBackColor1;

		public Color VbarBackColor2;

		public Color VbarForeColor;

		public Color VbarBorderColor;

		public Color VbarButtonBackColor1;

		public Color VbarButtonBackColor2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Map()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Map()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[Serializable]
	public class MainWindow
	{
		public Color MainWindowBackColor;

		public Color PanelBackColor1;

		public Color PanelBackColor2;

		public Color DownBackColor1;

		public Color DownBackColor2;

		public Color ActiveBackColor1;

		public Color ActiveBackColor2;

		public Color Part1BackColor1;

		public Color Part1BackColor2;

		public Color Part1BorderColor;

		public Color Part1ForeColor1;

		public Color Part1ForeColor2;

		public Color Part2BackColor1;

		public Color Part2BackColor2;

		public Color Part2BorderColor;

		public Color Part2ForeColor;

		public Color Part4BackColor1;

		public Color Part4BackColor2;

		public Color Part4BorderColor;

		public Color Part4ForeColor;

		public Color Part4NormalColor;

		public Color Part4HighColor;

		public Color Part4LowColor;

		public Color Part5BackColor1;

		public Color Part5BackColor2;

		public Color Part5BorderColor;

		public Color Part5ForeColor;

		public Color ControlBackColor;

		public Color ControlForeColor;

		public Color ControlShadow1Color;

		public Color ControlShadow2Color;

		public Color MenuBackColor1;

		public Color MenuBackColor2;

		public Color MenuForeColor;

		public Color MenuActiveBackColor1;

		public Color MenuActiveBackColor2;

		public Color MenuIconBackColor1;

		public Color MenuIconBackColor2;

		public Color MenuSeperatorColor;

		public Color HeaderBorderColor;

		public Color HeaderBackColor1;

		public Color HeaderBackColor2;

		public Color HeaderButtonPassiveColor;

		public Color HeaderButtonActiveColor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MainWindow()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static MainWindow()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[Serializable]
	public class Cancelled
	{
		public int Left;

		public int Top;

		public int Width;

		public int Height;

		public string ActiveSymbol;

		public Font FontData;

		public int LineSpace;

		public bool GridlineVisible;

		public bool BasicVisible;

		public bool DepthHeaderVisible;

		public bool GrupMember;

		public cxGrid DepthGrid;

		public cxGrid BasicGrid;

		public Color HeaderBorderColor;

		public Color HeaderBackColor1;

		public Color HeaderBackColor2;

		public Color HeaderButtonPassiveColor;

		public Color HeaderButtonActiveColor;

		public Color HeaderTextForeColor;

		public Color HeaderMenuForeColor;

		public Color TitleBackColor1;

		public Color TitleBackColor2;

		public Color TitleForeColor;

		public Color TitleBorderColor;

		public Color GridBackColor;

		public Color GridForeColor;

		public Color NormalColor;

		public Color HighColor;

		public Color LowColor;

		public Color GridlineColor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Cancelled()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Cancelled()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[Serializable]
	public class DovizBufe
	{
		public int Left;

		public int Top;

		public int Width;

		public int Height;

		public Font FontData;

		public int LineSpace;

		public bool GridlineVisible;

		public string SelectString;

		public byte SymbolType;

		public double VolumeFilter;

		public cxGrid DataGrid;

		public Color HeaderBorderColor;

		public Color HeaderBackColor1;

		public Color HeaderBackColor2;

		public Color HeaderButtonPassiveColor;

		public Color HeaderButtonActiveColor;

		public Color HeaderTextForeColor;

		public Color HeaderMenuForeColor;

		public Color TitleBackColor1;

		public Color TitleBackColor2;

		public Color TitleForeColor;

		public Color TitleBorderColor;

		public Color GridBackColor;

		public Color GridForeColor;

		public Color HighColor;

		public Color LowColor;

		public Color GridlineColor;

		public Color SelectColor;

		public Color VbarBackColor1;

		public Color VbarBackColor2;

		public Color VbarForeColor;

		public Color VbarBorderColor;

		public Color VbarButtonBackColor1;

		public Color VbarButtonBackColor2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DovizBufe()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DovizBufe()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[Serializable]
	public class BuySell
	{
		public int Left;

		public int Top;

		public int Width;

		public int Height;

		public string AccountName;

		public string AccountNo;

		public string Symbol;

		public double Price;

		public double Lot;

		public string Duration;

		public string OrderType;

		public string Direction;

		public string SellType;

		public string AcigaSatisKapama;

		public string DisplayType;

		public string Piyasa;

		public string Tab;

		public bool AksamSeansBool;

		public bool GrupMember;

		public List<int> HesapColWidthPozisyonBIST;

		public List<int> HesapColWidthBekleyenBIST;

		public List<int> HesapColWidthGerceklesenBIST;

		public List<int> HesapColWidthMaliyetBIST;

		public List<int> HesapColWidthHesapBIST;

		public List<int> HesapColWidthPozisyonVIOP;

		public List<int> HesapColWidthBekleyenVIOP;

		public List<int> HesapColWidthGerceklesenVIOP;

		public List<int> HesapColWidthMaliyetVIOP;

		public List<int> HesapColWidthHesapVIOP;

		public List<int> HesapColWidthPozisyonGHOST;

		public List<int> HesapColWidthBekleyenGHOST;

		public List<int> HesapColWidthGerceklesenGHOST;

		public List<int> HesapColWidthMaliyetGHOST;

		public Font HesapFont;

		public string PriceType;

		public double StopLevel;

		public DateTime EndDate;

		public Color HeaderBorderColor;

		public Color HeaderBackColor1;

		public Color HeaderBackColor2;

		public Color HeaderButtonPassiveColor;

		public Color HeaderButtonActiveColor;

		public Color HeaderTextForeColor;

		public Color HeaderMenuForeColor;

		public Color WindowBuyBackColor;

		public Color WindowBuyForeColor;

		public Color WindowSellBackColor;

		public Color WindowSellForeColor;

		public Color ButtonBuyBackColor;

		public Color ButtonBuyForeColor;

		public Color ButtonSellBackColor;

		public Color ButtonSellForeColor;

		public int Kep2AktifEmirTip;

		public bool Kep2GerceklesenSutunlarBool;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BuySell()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static BuySell()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[Serializable]
	public class Hucresel
	{
		public int Left;

		public int Top;

		public int Width;

		public int Height;

		public Font FontData;

		public int RowHeight;

		public bool GridlineVisible;

		public bool HeaderVisible;

		public bool TooltipEnabled;

		public string[,] FormulArray;

		public int[,] DecPointArray;

		public Color[,] BackColorArray;

		public Color[,] ForeColorArray;

		public byte[] ColAlign;

		public int[] ColWidth;

		public Color GridColor;

		public Color HeaderBorderColor;

		public Color HeaderBackColor1;

		public Color HeaderBackColor2;

		public Color HeaderButtonPassiveColor;

		public Color HeaderButtonActiveColor;

		public Color HeaderTextForeColor;

		public Color HeaderMenuForeColor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Hucresel()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Hucresel()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[Serializable]
	public class Pgc
	{
		public int Left;

		public int Top;

		public int Width;

		public int Height;

		public string ActiveSymbol;

		public Font FontData;

		public int LineSpace;

		public bool GrupMember;

		public short PGCGosterim;

		public Color HeaderBorderColor;

		public Color HeaderBackColor1;

		public Color HeaderBackColor2;

		public Color HeaderButtonPassiveColor;

		public Color HeaderButtonActiveColor;

		public Color HeaderTextForeColor;

		public Color HeaderMenuForeColor;

		public Color ChartBackColor;

		public Color GridlineColor;

		public Color ChartForeColor;

		public Color UpColor;

		public Color DownColor;

		public Color LineColor;

		public Color PgcColor;

		public Color PanelBackColor;

		public Color PanelForeColor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Pgc()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Pgc()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[Serializable]
	public class DepBuySell
	{
		public int Left;

		public int Top;

		public int Width;

		public int Height;

		public bool TopMost;

		public string AccountName;

		public string AccountNo;

		public string Symbol;

		public double Price;

		public double Lot;

		public string Duration;

		public string OrderType;

		public string Direction;

		public string SellType;

		public string AcigaSatisKapama;

		public string DisplayType;

		public string Piyasa;

		public bool AksamSeansBool;

		public bool GrupMember;

		public List<double> KademeLotList;

		public bool DEPBilgiGizle;

		public bool DEPDerinlikGizle;

		public bool DEPEmirleriGizle;

		public int DepthLineCount;

		public string PriceType;

		public Color HeaderBorderColor;

		public Color HeaderBackColor1;

		public Color HeaderBackColor2;

		public Color HeaderButtonPassiveColor;

		public Color HeaderButtonActiveColor;

		public Color HeaderTextForeColor;

		public Color HeaderMenuForeColor;

		public Color WindowBuyBackColor;

		public Color WindowBuyForeColor;

		public Color WindowSellBackColor;

		public Color WindowSellForeColor;

		public Color ButtonBuyBackColor;

		public Color ButtonBuyForeColor;

		public Color ButtonSellBackColor;

		public Color ButtonSellForeColor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DepBuySell()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DepBuySell()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxPage()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static cxPage()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
