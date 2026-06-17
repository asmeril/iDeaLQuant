namespace ideal;

public enum OrderStatus
{
	New = 0,
	PartiallyFilled = 1,
	Filled = 2,
	DoneForDay = 3,
	Canceled = 4,
	Replaced = 5,
	PendingCancel = 6,
	Stopped = 7,
	Rejected = 8,
	Suspended = 9,
	PendingNew = 65,
	Calculated = 66,
	Expired = 67,
	AcceptedForBidding = 68,
	PendingReplace = 69
}
