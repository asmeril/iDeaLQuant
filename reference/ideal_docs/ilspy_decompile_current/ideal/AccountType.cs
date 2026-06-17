namespace ideal;

public enum AccountType
{
	AccountIsCarriedOnCustomerSideOfTheBooks = 1,
	AccountIsCarriedOnNonCustomerSideOfBooks = 2,
	HouseTrader = 3,
	FloorTrader = 4,
	AccountIsCarriedOnNonCustomerSideOfBooksAndIsCrossMargined = 6,
	AccountIsHouseTraderAndIsCrossMargined = 7,
	JointBackOfficeAccount = 8
}
