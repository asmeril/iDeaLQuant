using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Binance.Net;
using Binance.Net.Objects;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formDepthCripto : FormControl
{
	[CompilerGenerated]
	private sealed class _003CConnectDepth_003Ed__157 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string url;

		public formDepthCripto _003C_003E4__this;

		private Exception _003Ce_003E5__1;

		private string _003Cexx_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CConnectDepth_003Ed__157()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CConnectDepth_003Ed__157()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CConnectTrade_003Ed__160 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string url;

		public formDepthCripto _003C_003E4__this;

		private Exception _003Ce_003E5__1;

		private string _003Cexx_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CConnectTrade_003Ed__160()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CConnectTrade_003Ed__160()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CReceiveDepth_003Ed__159 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ClientWebSocket ws;

		public formDepthCripto _003C_003E4__this;

		private byte[] _003Cbuffer_003E5__1;

		private WebSocketReceiveResult _003Cresult_003E5__2;

		private WebSocketReceiveResult _003C_003Es__3;

		private string _003Cresultstr_003E5__4;

		private TaskAwaiter<WebSocketReceiveResult> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CReceiveDepth_003Ed__159()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CReceiveDepth_003Ed__159()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CReceiveTrade_003Ed__162 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ClientWebSocket ws;

		public formDepthCripto _003C_003E4__this;

		private byte[] _003Cbuffer_003E5__1;

		private WebSocketReceiveResult _003Cresult_003E5__2;

		private WebSocketReceiveResult _003C_003Es__3;

		private string _003Cresultstr_003E5__4;

		private TaskAwaiter<WebSocketReceiveResult> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CReceiveTrade_003Ed__162()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CReceiveTrade_003Ed__162()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CSendDepth_003Ed__158 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ClientWebSocket ws;

		public formDepthCripto _003C_003E4__this;

		private UTF8Encoding _003C_encoding_003E5__1;

		private string _003Cs_003E5__2;

		private byte[] _003Cbuffer_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CSendDepth_003Ed__158()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CSendDepth_003Ed__158()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CSendTrade_003Ed__161 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ClientWebSocket ws;

		public formDepthCripto _003C_003E4__this;

		private UTF8Encoding _003C_encoding_003E5__1;

		private string _003Cs_003E5__2;

		private byte[] _003Cbuffer_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CSendTrade_003Ed__161()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CSendTrade_003Ed__161()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private Font FontData;

	public string ActiveSymbol;

	private int LineSpace;

	private bool GridlineVisible;

	private bool TradeVisible;

	private bool BasicVisible;

	private bool MoneyflowVisible;

	private bool DepthHeaderVisible;

	private bool TradeHeaderVisible;

	private int CompositeShow;

	private bool PistonVisible;

	private int DepthLineCount;

	private bool TopMostEnabled;

	private bool Average1Visible;

	private bool Average2Visible;

	private bool LastTradeVisible;

	private byte VolumeFormat;

	private byte SizeFormat;

	private int ClassVersion;

	private bool UseHighLowColorinDepth;

	private bool BasicSingleRow;

	private bool InnerTopMostEnabled;

	private bool EmirVisible;

	private int EmirTipi;

	private int EmirMiktar;

	private bool EmirOnay;

	private Color TitleBackColor1;

	private Color TitleBackColor2;

	private Color TitleForeColor;

	private Color TitleBorderColor;

	private Color ActiveCellBackColor1;

	private Color ActiveCellBackColor2;

	private Color ActiveCellForeColor;

	private Color GridBackColor;

	private Color GridForeColor;

	private Color NormalColor;

	private Color HighColor;

	private Color LowColor;

	private Color RelationalNewsColor;

	private Color AverageLineBackColor;

	private Color AverageLineForeColor;

	private Color CurrentLineBackColor;

	private Color CurrentLineForeColor;

	private Color GridlineColor;

	private Color MarketMakerBidBackColor;

	private Color MarketMakerBidForeColor;

	private Color MarketMakerAskBackColor;

	private Color MarketMakerAskForeColor;

	private Color UpdateNormalBackColor;

	private Color UpdateNormalForeColor;

	private Color UpdateHighBackColor;

	private Color UpdateHighForeColor;

	private Color UpdateLowBackColor;

	private Color UpdateLowForeColor;

	private Color VbarBackColor1;

	private Color VbarBackColor2;

	private Color VbarForeColor;

	private Color VbarBorderColor;

	private Color VbarButtonBackColor1;

	private Color VbarButtonBackColor2;

	private Color BasicHeaderBackColor;

	private Color BasicHeaderForeColor;

	private cxPage.Depth PageParams;

	private bool FormActivated;

	private string InitialSymbol;

	private int InitialLeft;

	private int InitialTop;

	private Rectangle InvRect1;

	private Rectangle InvRect2;

	private Color InvBackColor;

	private Color InvForeColor;

	private StringFormat InvAlign;

	private string InvString;

	private Font InvFont;

	private bool VbarVisible;

	private string MenuSender;

	private int TitleHeight;

	private int RowHeight;

	private string DragString;

	private Point DragPoint;

	private List<cxTrade> DataList;

	private List<cxTrade> DataBuffer;

	private cxGrid Grid;

	private long TradeUpdateTime;

	private int TradeUpdateCount;

	private int TradeCheckID;

	private int[] TradeCharWidth;

	private cxDepth DepthItem;

	private cxGrid DepthGrid;

	private int Average1RowNo;

	private int Average2RowNo;

	private long DepthPacketReceiveTime;

	private int[] DepthBidColorStatus;

	private int[] DepthAskColorStatus;

	private long[] DepthBidUpdateTime;

	private long[] DepthAskUpdateTime;

	private int[] DepthCharWidth;

	private long DepthAveragePaintTime;

	private long Interval1000;

	private int MouseDownColNo;

	private int MouseDownRowNo;

	private decimal TradePrice;

	private string TradeDirection;

	private cxBasic BasicItem;

	private cxGrid BasicGrid;

	private int BasicRowCount;

	private int[,] BasicColCode;

	private string LastTradeTime;

	private float LastTradeSize;

	private float LastTradePrice;

	private byte LastTradeDirection;

	private int LastTradeID;

	private bool FormLoaded;

	private bool DataLoaded;

	private Stopwatch CheckTime;

	private long DownloadMoment;

	private bool DownloadReceived;

	private cxFont.Margin FontMargin;

	private Font FontHeader;

	private cxButton HeaderButtons;

	private Pen Pen1;

	private Pen Pen2;

	private SolidBrush Brush1;

	private SolidBrush BrushBack;

	private SolidBrush BrushFore;

	private Rectangle Rect1;

	private Rectangle Rect2;

	private string Str1;

	private Point Point1;

	private bool MovingObject;

	private Point MoveCursor;

	private Rectangle MoveRect;

	private float ScrollMidLength;

	private float ScrollSideLength;

	private int ScrollDirection;

	private long ScrollTime;

	private Rectangle VbarMidRect;

	private Rectangle VbarBottomRect;

	private Rectangle VbarTopRect;

	private cxButton EmirButtons;

	private string LocalOrderKey;

	private cxButton PgcButtons;

	private bool PgcVisible;

	private string PgcPeriyot;

	private int PgcSeviye;

	private bool InvalidateBool;

	private List<cKademe> BidKademe;

	private List<cKademe> AskKademe;

	private int SocketDepthInterval;

	private ConcurrentQueue<BinanceOrderBookEntry> BidQuene;

	private ConcurrentQueue<BinanceOrderBookEntry> AskQuene;

	private BinanceSocketClient Socket;

	private ClientWebSocket WS_Depth_Icrypex;

	private ClientWebSocket WS_Trade_Icrypex;

	private IContainer components;

	private Timer timerUpdate;

	private TextBox textSymbolSearch;

	private Panel panelVbar;

	private Panel panelBasic;

	private Panel panelDepth;

	private Panel panelTrade;

	private Panel panelLast;

	private Panel panelPiston;

	private Timer timerScroll;

	private ToolTip toolTip;

	private Label labelDrag;

	private Panel panelEmir;

	private TextBox textEmirMiktar;

	private Label labelEmirBekle;

	private Timer timerBid;

	private Timer timerAsk;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formDepthCripto(int leftX, int topX, string symbolX, cxPage.Depth pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDepthCripto_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void getOrderBookPrint()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CConnectDepth_003Ed__157))]
	[DebuggerStepThrough]
	public Task ConnectDepth(string url)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CSendDepth_003Ed__158))]
	private Task SendDepth(ClientWebSocket ws)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CReceiveDepth_003Ed__159))]
	private Task ReceiveDepth(ClientWebSocket ws)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CConnectTrade_003Ed__160))]
	public Task ConnectTrade(string url)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CSendTrade_003Ed__161))]
	private Task SendTrade(ClientWebSocket ws)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CReceiveTrade_003Ed__162))]
	private Task ReceiveTrade(ClientWebSocket ws)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CloseSocket()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Parse_Depth_Icrypex(string dataX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Parse_Trade_Icrypex(string dataX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDepthCripto_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDepthCripto_Deactivate(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDepthCripto_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDepthCripto_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDepthCripto_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDepthCripto_MouseWheel(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDepthCripto_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formDepthCripto_SizeChanged(object sender, EventArgs e)
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
	private void labelEmirBekle_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelBasic_MouseDoubleClick(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelBasic_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelBasic_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelBasic_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelDepth_DragDrop(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelDepth_DragEnter(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelDepth_MouseDoubleClick(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelDepth_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelDepth_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelDepth_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelDepth_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelEmir_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelEmir_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelLast_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelPiston_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelTrade_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelTrade_MouseDoubleClick(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelTrade_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelTrade_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelTrade_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelVbar_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelVbar_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelVbar_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelVbar_Paint(object sender, PaintEventArgs e)
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
	private void textSymbolSearch_Leave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerScroll_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerUpdate_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BasicDataReceived(string symbolX, string updatetypeX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DepthInsertRowReceived(string symbolX, char bidasktypeX, int rownoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DepthRefreshed(string symbolX, char bidasktypeX, int rownoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DepthUpdateRowReceived(string symbolX, char bidasktypeX, int rownoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DepthDeleteRowReceived(string symbolX, char bidasktypeX, int rownoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MessageReceived(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TradeReceived(cxTrade itemX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PortfolioReceived(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CopyToExcel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CopyToExcel2()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InsertDataBuffer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InvalidateAll()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PaintCell(Graphics grx, bool refreshpaintX, string strX, Font fontX, Color backcolorX, Color forecolorX, Rectangle rect1X, Rectangle rect2X, StringFormat alignX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrepareTables()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintDepthLine(Graphics grx, bool refreshpaintX, char bidaskX, int rownoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPageParams(cxPage.Depth pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMainToolbarSymbol()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowMenu(object sender, Point pointX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowMenuTradeCol(object sender, Point pointX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowMenuDepthColumn(object sender, Point pointX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowMenuBasicColumn(object sender, Point pointX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowMenuPgcPeriod(object sender, Point pointX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetLanguage()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyPattern(cxPage.Depth pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeColors(cxColorEditor coloritemX)
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
	private void BidParse()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AskParse()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerBid_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerAsk_Tick(object sender, EventArgs e)
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
	static formDepthCripto()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
