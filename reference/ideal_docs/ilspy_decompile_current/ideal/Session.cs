using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class Session
{
	public class AuthResponse : IdealMessage
	{
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

		public string ErrorMessage
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
		public AuthResponse()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static AuthResponse()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class Login : IdealMessage
	{
		private string _Username
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

		public string Username
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

		public string Password
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
		public Login()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Login()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class Logout : IdealMessage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Logout()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Logout()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class LoginResponse : AuthResponse
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LoginResponse()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static LoginResponse()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class LogoutResponse : AuthResponse
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LogoutResponse()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static LogoutResponse()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class Heartbeat : IdealMessage
	{
		public string Timestamp
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
		public Heartbeat()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Heartbeat()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class NewOrder : IdealMessage
	{
		public string OrderUuid
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

		public string Symbol
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

		public double Quantity
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public OrderType OrderType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (OrderType)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public OrderSide OrderSide
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (OrderSide)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public TimeInForce TimeInForce
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (TimeInForce)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public OrderCapacity? OrderCapacity
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

		public string Account
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

		public AccountType? AccountType
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

		public double? Price
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

		public bool OffHoursTrading
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
		public NewOrder()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static NewOrder()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class CancelOrder : IdealMessage
	{
		public string OrderUuid
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

		public int OrderId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string Symbol
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

		public double Quantity
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public OrderSide OrderSide
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (OrderSide)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string Account
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
		public CancelOrder()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static CancelOrder()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class CancelReplaceOrder : IdealMessage
	{
		public string OrderUuid
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

		public int OrderId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string Symbol
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

		public double Quantity
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public double Price
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public OrderSide OrderSide
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (OrderSide)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public OrderType OrderType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (OrderType)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string Account
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
		public CancelReplaceOrder()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static CancelReplaceOrder()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class OrderReport : NewOrder
	{
		public int OrderId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public OrderStatus OrderStatus
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (OrderStatus)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public int? OriginalOrderId
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

		public double? FilledQuantity
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

		public double? ExecutedQuantity
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

		public double? BuyPrice
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

		public string RejectReason
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

		public string TransactionTime
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

		public string OrderSendingTime
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
		public OrderReport()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static OrderReport()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class GetOrder : IdealMessage
	{
		public int Id
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetOrder()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetOrder()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class GetOrders : IdealMessage
	{
		public int? Page
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

		public int? PageSize
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

		public string StartDate
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

		public string EndDate
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
		public GetOrders()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetOrders()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class Error : IdealMessage
	{
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

	public class GetAccounts : IdealMessage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetAccounts()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetAccounts()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class GetAccountsResponse : IdealMessage
	{
		public string Account
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
		public GetAccountsResponse()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetAccountsResponse()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Session()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Session()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
