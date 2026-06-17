namespace ideal;

public enum TimeInForce
{
	Day = 0,
	GoodTillCancel = 1,
	ImmediateOrCancel = 3,
	FillOrKill = 4,
	GoodTillDate = 6,
	AtCrossing = 9,
	GoodTillEndOfSession = 83
}
