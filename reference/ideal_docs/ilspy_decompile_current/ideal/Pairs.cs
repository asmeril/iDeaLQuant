using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class Pairs
{
	[JsonProperty("symbol")]
	public string Symbol;

	[JsonProperty("base")]
	public string Base;

	[JsonProperty("quote")]
	public string Quote;

	[JsonProperty("minExchangeValue")]
	public string MinExchangeValue;

	[JsonProperty("minPrice")]
	public string MinPrice;

	[JsonProperty("maxPrice")]
	public string MaxPrice;

	[JsonProperty("quantityPrecision")]
	public int QuantityPrecision;

	[JsonProperty("pricePrecision")]
	public int PricePrecision;

	[JsonProperty("totalPrecision")]
	public int TotalPrecision;

	[JsonProperty("commissionPrecision")]
	public int CommissionPrecision;

	[JsonProperty("displayOrder")]
	public int DisplayOrder;

	[JsonProperty("status")]
	public string Status;

	[JsonProperty("marketTypes")]
	public List<string> MarketTypes;

	[JsonProperty("orderTypes")]
	public List<string> OrderTypes;

	[JsonProperty("tickSize")]
	public string TickSize;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Pairs()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Pairs()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
