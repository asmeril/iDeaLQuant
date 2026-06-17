using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class BinanceSpotClient
{
	public class Error
	{
		public string Code
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

		public string Message
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
		public Error()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Error()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class AccountInfo
	{
		public bool CanTrade
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

		public bool CanWithdraw
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

		public bool CanDeposit
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

		public DateTimeOffset UpdateTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (DateTimeOffset)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public List<BalanceItem> Balances
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

		public bool Success
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

		public Error Error
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
		public AccountInfo()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static AccountInfo()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class BalanceItem
	{
		public string Asset
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

		public decimal Free
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (decimal)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public decimal Locked
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (decimal)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BalanceItem()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static BalanceItem()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public string asset;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetAccountBalance_003Eb__0(JToken b)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec__DisplayClass6_0()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetAccountBalance_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<decimal> _003C_003Et__builder;

		public string asset;

		public BinanceSpotClient _003C_003E4__this;

		private _003C_003Ec__DisplayClass6_0 _003C_003E8__1;

		private long _003Ctimestamp_003E5__2;

		private string _003CqueryString_003E5__3;

		private string _003Csignature_003E5__4;

		private string _003Cendpoint_003E5__5;

		private HttpResponseMessage _003Cresponse_003E5__6;

		private string _003Ccontent_003E5__7;

		private JObject _003Cresult_003E5__8;

		private JToken _003Cbalance_003E5__9;

		private HttpResponseMessage _003C_003Es__10;

		private string _003C_003Es__11;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CGetAccountBalance_003Ed__6()
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
		static _003CGetAccountBalance_003Ed__6()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetAccountInfo_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<AccountInfo> _003C_003Et__builder;

		public BinanceSpotClient _003C_003E4__this;

		private long _003Ctimestamp_003E5__1;

		private string _003CqueryString_003E5__2;

		private string _003Csignature_003E5__3;

		private string _003Cendpoint_003E5__4;

		private HttpResponseMessage _003Cresponse_003E5__5;

		private string _003Ccontent_003E5__6;

		private JObject _003CjsonResponse_003E5__7;

		private HttpResponseMessage _003C_003Es__8;

		private string _003C_003Es__9;

		private Exception _003Cex_003E5__10;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CGetAccountInfo_003Ed__9()
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
		static _003CGetAccountInfo_003Ed__9()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetCurrentPrice_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<decimal> _003C_003Et__builder;

		public string symbol;

		public BinanceSpotClient _003C_003E4__this;

		private string _003Cendpoint_003E5__1;

		private HttpResponseMessage _003Cresponse_003E5__2;

		private string _003Ccontent_003E5__3;

		private JObject _003Cresult_003E5__4;

		private HttpResponseMessage _003C_003Es__5;

		private string _003C_003Es__6;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CGetCurrentPrice_003Ed__5()
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
		static _003CGetCurrentPrice_003Ed__5()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CPlaceOrder_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public string symbol;

		public string side;

		public decimal quantity;

		public decimal price;

		public BinanceSpotClient _003C_003E4__this;

		private long _003Ctimestamp_003E5__1;

		private Dictionary<string, string> _003Cparameters_003E5__2;

		private string _003CqueryString_003E5__3;

		private string _003Csignature_003E5__4;

		private string _003Cendpoint_003E5__5;

		private StringContent _003Ccontent_003E5__6;

		private HttpResponseMessage _003Cresponse_003E5__7;

		private HttpResponseMessage _003C_003Es__8;

		private string _003C_003Es__9;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CPlaceOrder_003Ed__7()
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
		static _003CPlaceOrder_003Ed__7()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private readonly string _apiKey;

	private readonly string _apiSecret;

	private readonly HttpClient _httpClient;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BinanceSpotClient(string apiKey, string apiSecret)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CGetCurrentPrice_003Ed__5))]
	public Task<decimal> GetCurrentPrice(string symbol)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CGetAccountBalance_003Ed__6))]
	public Task<decimal> GetAccountBalance(string asset)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CPlaceOrder_003Ed__7))]
	public Task<string> PlaceOrder(string symbol, string side, decimal quantity, decimal price)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GenerateSignature(string queryString)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CGetAccountInfo_003Ed__9))]
	public Task<AccountInfo> GetAccountInfo()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static BinanceSpotClient()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
