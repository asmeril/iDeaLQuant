namespace ideal;

public enum OrderType
{
	Market = 1,
	Limit = 2,
	Stop = 3,
	StopLimit = 4,
	MarketOnClose = 5,
	WithOrWithout = 6,
	LimitOrBetter = 7,
	LimitWithOrWithout = 8,
	OnBasis = 9,
	OnClose = 65,
	LimitOnClose = 66,
	ForexMarket = 67,
	PreviouslyQuoted = 68,
	PreviouslyIndicated = 69,
	ForexLimit = 70,
	ForexSwap = 71,
	ForexPreviouslyQuoted = 72,
	Funari = 73,
	MarketIfTouched = 74,
	MarketWithLeftoverAsLimit = 75,
	PreviousFundValuationPoint = 76,
	NextFundValuationPoint = 77,
	Pegged = 80
}
