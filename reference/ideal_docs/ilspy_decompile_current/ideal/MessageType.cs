namespace ideal;

public enum MessageType
{
	Unknown = 88,
	NewOrder = 65,
	CancelOrder = 66,
	CancelReplaceOrder = 82,
	GetOrder = 67,
	GetOrders = 68,
	OrderReport = 69,
	Error = 90,
	Heartbeat = 72,
	Login = 76,
	LoginResponse = 75,
	Logout = 77,
	LogoutResponse = 78,
	GetAccounts = 71,
	GetAccountsResponse = 70
}
