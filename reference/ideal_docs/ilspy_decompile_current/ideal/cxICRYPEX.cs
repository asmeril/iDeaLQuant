using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class cxICRYPEX
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public string symbol;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass24_0()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003COrderInsert_003Eb__0(Pair x)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec__DisplayClass24_0()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CCancelOrders_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public cxPortfolio.AccountRecord accountX;

		public string orderId;

		private HttpClient _003Cclient_003E5__1;

		private StringBuilder _003Csbusr_003E5__2;

		private HttpResponseMessage _003Cresponse_003E5__3;

		private string _003Cmessage_003E5__4;

		private HttpResponseMessage _003C_003Es__5;

		private string _003C_003Es__6;

		private Exception _003Cerror_003E5__7;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__2;

		private TaskAwaiter<string> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CCancelOrders_003Ed__19()
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
		static _003CCancelOrders_003Ed__19()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetAccountInfo_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<AccountInfoModel> _003C_003Et__builder;

		public cxPortfolio.AccountRecord accountX;

		private HttpClient _003Cclient_003E5__1;

		private AccountInfoModel _003CoReturn_003E5__2;

		private JavaScriptSerializer _003Cserializer_003E5__3;

		private StringBuilder _003Csbusr_003E5__4;

		private HttpResponseMessage _003Cresponse_003E5__5;

		private string _003Cdata_003E5__6;

		private HttpStatusCode _003C_003Es__7;

		private string _003C_003Es__8;

		private Exception _003Cerror_003E5__9;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CGetAccountInfo_003Ed__16()
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
		static _003CGetAccountInfo_003Ed__16()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetAsets_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public cxPortfolio.AccountRecord accountX;

		private string _003Cresultobj_003E5__1;

		private HttpClient _003Cclient_003E5__2;

		private StringBuilder _003Csbusr_003E5__3;

		private HttpResponseMessage _003Cresponse_003E5__4;

		private HttpResponseMessage _003C_003Es__5;

		private string _003C_003Es__6;

		private Exception _003Cerror_003E5__7;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__2;

		private TaskAwaiter<string> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CGetAsets_003Ed__32()
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
		static _003CGetAsets_003Ed__32()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetFutureExchangeInfo_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public cxPortfolio.AccountRecord accountX;

		private HttpClient _003Cclient_003E5__1;

		private StringBuilder _003Csbusr_003E5__2;

		private HttpResponseMessage _003Cresponse_003E5__3;

		private string _003Cmessage_003E5__4;

		private HttpResponseMessage _003C_003Es__5;

		private string _003C_003Es__6;

		private Exception _003Cerror_003E5__7;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__2;

		private TaskAwaiter<string> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CGetFutureExchangeInfo_003Ed__21()
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
		static _003CGetFutureExchangeInfo_003Ed__21()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetFutureOrders_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public cxPortfolio.AccountRecord accountX;

		private HttpClient _003Cclient_003E5__1;

		private StringBuilder _003Csbusr_003E5__2;

		private HttpResponseMessage _003Cresponse_003E5__3;

		private string _003Cmessage_003E5__4;

		private HttpResponseMessage _003C_003Es__5;

		private string _003C_003Es__6;

		private Exception _003Cerror_003E5__7;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__2;

		private TaskAwaiter<string> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CGetFutureOrders_003Ed__23()
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
		static _003CGetFutureOrders_003Ed__23()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetFuturePozitions_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public cxPortfolio.AccountRecord accountX;

		private HttpClient _003Cclient_003E5__1;

		private StringBuilder _003Csbusr_003E5__2;

		private HttpResponseMessage _003Cresponse_003E5__3;

		private string _003Cmessage_003E5__4;

		private HttpResponseMessage _003C_003Es__5;

		private string _003C_003Es__6;

		private Exception _003Cerror_003E5__7;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__2;

		private TaskAwaiter<string> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CGetFuturePozitions_003Ed__22()
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
		static _003CGetFuturePozitions_003Ed__22()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetKlineHistory_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public cxPortfolio.AccountRecord accountX;

		private HttpClient _003Cclient_003E5__1;

		private StringBuilder _003Csbusr_003E5__2;

		private HttpResponseMessage _003Cresponse_003E5__3;

		private string _003Cmessage_003E5__4;

		private HttpResponseMessage _003C_003Es__5;

		private string _003C_003Es__6;

		private Exception _003Cerror_003E5__7;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__2;

		private TaskAwaiter<string> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CGetKlineHistory_003Ed__35()
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
		static _003CGetKlineHistory_003Ed__35()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetOrders_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public cxPortfolio.AccountRecord accountX;

		private HttpClient _003Cclient_003E5__1;

		private StringBuilder _003Csbusr_003E5__2;

		private HttpResponseMessage _003Cresponse_003E5__3;

		private string _003Cmessage_003E5__4;

		private HttpResponseMessage _003C_003Es__5;

		private string _003C_003Es__6;

		private Exception _003Cerror_003E5__7;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__2;

		private TaskAwaiter<string> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CGetOrders_003Ed__20()
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
		static _003CGetOrders_003Ed__20()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetOrdersHistory_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public cxPortfolio.AccountRecord accountX;

		private HttpClient _003Cclient_003E5__1;

		private StringBuilder _003Csbusr_003E5__2;

		private DateTime _003CstartTime_003E5__3;

		private DateTime _003CcurrentTime_003E5__4;

		private long _003Ctime1_003E5__5;

		private long _003Ctime2_003E5__6;

		private HttpResponseMessage _003Cresponse_003E5__7;

		private string _003Cmessage_003E5__8;

		private HttpResponseMessage _003C_003Es__9;

		private string _003C_003Es__10;

		private Exception _003Cerror_003E5__11;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__2;

		private TaskAwaiter<string> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CGetOrdersHistory_003Ed__18()
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
		static _003CGetOrdersHistory_003Ed__18()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetSymbols_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public cxPortfolio.AccountRecord accountX;

		private Symbols _003Cresultobj_003E5__1;

		private HttpClient _003Cclient_003E5__2;

		private StringBuilder _003Csbusr_003E5__3;

		private HttpResponseMessage _003Cresponse_003E5__4;

		private string _003Cmessage_003E5__5;

		private List<Pair> _003Cpairs_003E5__6;

		private List<Asset> _003Cassets_003E5__7;

		private JavaScriptSerializer _003Cserializer_003E5__8;

		private OrderIcry _003Cresult_003E5__9;

		private HttpResponseMessage _003C_003Es__10;

		private string _003C_003Es__11;

		private List<Pair>.Enumerator _003C_003Es__12;

		private Pair _003Cp_003E5__13;

		private string _003Cidealsembol_003E5__14;

		private bool _003Cstatus_003E5__15;

		private SymbolClass _003Csym_003E5__16;

		private SymbolClass _003Csym_003E5__17;

		private List<Asset>.Enumerator _003C_003Es__18;

		private Asset _003Ca_003E5__19;

		private string _003Cidealsembol_003E5__20;

		private Exception _003Cerror_003E5__21;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__2;

		private TaskAwaiter<string> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CGetSymbols_003Ed__31()
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
		static _003CGetSymbols_003Ed__31()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetTickers_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public cxPortfolio.AccountRecord accountX;

		private HttpClient _003Cclient_003E5__1;

		private StringBuilder _003Csbusr_003E5__2;

		private HttpResponseMessage _003Cresponse_003E5__3;

		private string _003Cmessage_003E5__4;

		private HttpResponseMessage _003C_003Es__5;

		private string _003C_003Es__6;

		private Exception _003Cerror_003E5__7;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__2;

		private TaskAwaiter<string> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CGetTickers_003Ed__39()
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
		static _003CGetTickers_003Ed__39()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetTrades_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public cxPortfolio.AccountRecord accountX;

		private HttpClient _003Cclient_003E5__1;

		private StringBuilder _003Csbusr_003E5__2;

		private DateTime _003CstartTime_003E5__3;

		private DateTime _003CcurrentTime_003E5__4;

		private long _003Ctime1_003E5__5;

		private long _003Ctime2_003E5__6;

		private HttpResponseMessage _003Cresponse_003E5__7;

		private string _003Cmessage_003E5__8;

		private HttpResponseMessage _003C_003Es__9;

		private string _003C_003Es__10;

		private Exception _003Cerror_003E5__11;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__2;

		private TaskAwaiter<string> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CGetTrades_003Ed__38()
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
		static _003CGetTrades_003Ed__38()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetTradesOhlc_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public cxPortfolio.AccountRecord accountX;

		private HttpClient _003Cclient_003E5__1;

		private StringBuilder _003Csbusr_003E5__2;

		private HttpResponseMessage _003Cresponse_003E5__3;

		private string _003Cmessage_003E5__4;

		private HttpResponseMessage _003C_003Es__5;

		private string _003C_003Es__6;

		private Exception _003Cerror_003E5__7;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__2;

		private TaskAwaiter<string> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CGetTradesOhlc_003Ed__36()
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
		static _003CGetTradesOhlc_003Ed__36()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetUserTrades_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public cxPortfolio.AccountRecord accountX;

		private HttpClient _003Cclient_003E5__1;

		private DateTime _003CstartTime_003E5__2;

		private DateTime _003CcurrentTime_003E5__3;

		private long _003Ctime1_003E5__4;

		private long _003Ctime2_003E5__5;

		private StringBuilder _003Csbusr_003E5__6;

		private HttpResponseMessage _003Cresponse_003E5__7;

		private string _003Cmessage_003E5__8;

		private HttpResponseMessage _003C_003Es__9;

		private string _003C_003Es__10;

		private Exception _003Cerror_003E5__11;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__2;

		private TaskAwaiter<string> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CGetUserTrades_003Ed__27()
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
		static _003CGetUserTrades_003Ed__27()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetWallet_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public cxPortfolio.AccountRecord accountX;

		private HttpClient _003Cclient_003E5__1;

		private StringBuilder _003Csbusr_003E5__2;

		private HttpResponseMessage _003Cresponse_003E5__3;

		private string _003Cmessage_003E5__4;

		private HttpResponseMessage _003C_003Es__5;

		private string _003C_003Es__6;

		private Exception _003Cerror_003E5__7;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__2;

		private TaskAwaiter<string> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CGetWallet_003Ed__34()
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
		static _003CGetWallet_003Ed__34()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003COrderHistoryBySymbol_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public cxPortfolio.AccountRecord accountX;

		public string marketSymbolX;

		private HttpClient _003Cclient_003E5__1;

		private DateTime _003CstartTime_003E5__2;

		private DateTime _003CcurrentTime_003E5__3;

		private long _003Ctime1_003E5__4;

		private long _003Ctime2_003E5__5;

		private StringBuilder _003Csbusr_003E5__6;

		private HttpResponseMessage _003Cresponse_003E5__7;

		private string _003Cmessage_003E5__8;

		private HttpResponseMessage _003C_003Es__9;

		private string _003C_003Es__10;

		private Exception _003Cerror_003E5__11;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__2;

		private TaskAwaiter<string> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003COrderHistoryBySymbol_003Ed__28()
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
		static _003COrderHistoryBySymbol_003Ed__28()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003COrderInsert_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public cxPortfolio.AccountRecord accountX;

		public cxPortfolio.BuySellRecord buySellX;

		public cxICRYPEX _003C_003E4__this;

		private HttpClient _003Cclient_003E5__1;

		private string _003Coreturn_003E5__2;

		private _003C_003Ec__DisplayClass24_0 _003C_003E8__3;

		private OrderRequest _003Cor_003E5__4;

		private double _003Cquantity_003E5__5;

		private cxBasic _003CBasic_003E5__6;

		private string _003Cside_003E5__7;

		private List<Pair> _003CsymPairList_003E5__8;

		private string _003Ctotalm_003E5__9;

		private string _003Curl_003E5__10;

		private string _003CsType_003E5__11;

		private string _003C_003Es__12;

		private OrderRequest _003Cmodel_003E5__13;

		private string _003Cjson_003E5__14;

		private StringContent _003CstringContent_003E5__15;

		private HttpResponseMessage _003Cresponse_003E5__16;

		private Exception _003Cex_003E5__17;

		private ErrorMessages _003CreturnData_003E5__18;

		private ErrorsList _003CerrList_003E5__19;

		private string _003C_003Es__20;

		private string _003C_003Es__21;

		private StringBuilder _003Csb_003E5__22;

		private List<Error>.Enumerator _003C_003Es__23;

		private Error _003Citem_003E5__24;

		private string _003C_003Es__25;

		private string _003C_003Es__26;

		private _003C_003Ef__AnonymousType0<string, string, string, string> _003Cmodel_003E5__27;

		private string _003Cjson_003E5__28;

		private StringContent _003CstringContent_003E5__29;

		private HttpResponseMessage _003Cresponse_003E5__30;

		private ErrorMessages _003CreturnData_003E5__31;

		private string _003C_003Es__32;

		private string _003C_003Es__33;

		private Exception _003Cerror_003E5__34;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003COrderInsert_003Ed__24()
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
		static _003COrderInsert_003Ed__24()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003COrderbook_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public cxPortfolio.AccountRecord accountX;

		public string marketSymbolX;

		private HttpClient _003Cclient_003E5__1;

		private StringBuilder _003Csbusr_003E5__2;

		private HttpResponseMessage _003Cresponse_003E5__3;

		private string _003Cmessage_003E5__4;

		private HttpResponseMessage _003C_003Es__5;

		private string _003C_003Es__6;

		private Exception _003Cerror_003E5__7;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__2;

		private TaskAwaiter<string> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003COrderbook_003Ed__30()
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
		static _003COrderbook_003Ed__30()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public static Dictionary<string, SymbolClass> SembolDict;

	public static Dictionary<string, Pair> PairSembolDict;

	public static Dictionary<string, Asset> AssetSembolDict;

	public static ConcurrentQueue<string> LogQueue;

	public static Dictionary<string, Pair> PairDict;

	public static string RequestLink;

	public static string ApiKey
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public static string SecretKey
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxICRYPEX(cxPortfolio.AccountRecord accountX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddLogQueue(string strX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CGetAccountInfo_003Ed__16))]
	public static Task<AccountInfoModel> GetAccountInfo(cxPortfolio.AccountRecord accountX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetaccountSnapshot(cxPortfolio.AccountRecord accountX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetOrdersHistory_003Ed__18))]
	[DebuggerStepThrough]
	public static Task<string> GetOrdersHistory(cxPortfolio.AccountRecord accountX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CCancelOrders_003Ed__19))]
	public static Task<string> CancelOrders(cxPortfolio.AccountRecord accountX, string orderId)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetOrders_003Ed__20))]
	[DebuggerStepThrough]
	public static Task<string> GetOrders(cxPortfolio.AccountRecord accountX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetFutureExchangeInfo_003Ed__21))]
	[DebuggerStepThrough]
	public static Task<string> GetFutureExchangeInfo(cxPortfolio.AccountRecord accountX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CGetFuturePozitions_003Ed__22))]
	public static Task<string> GetFuturePozitions(cxPortfolio.AccountRecord accountX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetFutureOrders_003Ed__23))]
	[DebuggerStepThrough]
	public static Task<string> GetFutureOrders(cxPortfolio.AccountRecord accountX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003COrderInsert_003Ed__24))]
	public Task<string> OrderInsert(cxPortfolio.AccountRecord accountX, cxPortfolio.BuySellRecord buySellX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetOpenOrders(cxPortfolio.AccountRecord accountX, string marketSymbolX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetPlaceOrder(cxPortfolio.AccountRecord accountX, string marketSymbolX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetUserTrades_003Ed__27))]
	[DebuggerStepThrough]
	public static Task<string> GetUserTrades(cxPortfolio.AccountRecord accountX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003COrderHistoryBySymbol_003Ed__28))]
	public static Task<string> OrderHistoryBySymbol(cxPortfolio.AccountRecord accountX, string marketSymbolX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string TradesOfTheOrder(cxPortfolio.AccountRecord accountX, string OrderId)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COrderbook_003Ed__30))]
	[DebuggerStepThrough]
	public static Task<string> Orderbook(cxPortfolio.AccountRecord accountX, string marketSymbolX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CGetSymbols_003Ed__31))]
	public static void GetSymbols(cxPortfolio.AccountRecord accountX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CGetAsets_003Ed__32))]
	public static Task<string> GetAsets(cxPortfolio.AccountRecord accountX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetLastTradesBySymbol(cxPortfolio.AccountRecord accountX, string marketSymbolX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CGetWallet_003Ed__34))]
	public static Task<string> GetWallet(cxPortfolio.AccountRecord accountX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetKlineHistory_003Ed__35))]
	[DebuggerStepThrough]
	public static Task<string> GetKlineHistory(cxPortfolio.AccountRecord accountX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetTradesOhlc_003Ed__36))]
	[DebuggerStepThrough]
	public static Task<string> GetTradesOhlc(cxPortfolio.AccountRecord accountX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetWalletSpot(cxPortfolio.AccountRecord accountX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CGetTrades_003Ed__38))]
	public static Task<string> GetTrades(cxPortfolio.AccountRecord accountX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CGetTickers_003Ed__39))]
	public static Task<string> GetTickers(cxPortfolio.AccountRecord accountX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetChartData(string marketSymbolX, long startdateX, long enddateX, double intervalX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static cxICRYPEX()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		SembolDict = new Dictionary<string, SymbolClass>();
		PairSembolDict = new Dictionary<string, Pair>();
		AssetSembolDict = new Dictionary<string, Asset>();
		LogQueue = new ConcurrentQueue<string>();
		PairDict = new Dictionary<string, Pair>();
		RequestLink = "https://api.icrypex.com";
	}
}
