using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class OrdersHistoryItem
{
	[JsonProperty("id")]
	public int Id;

	[JsonProperty("symbol")]
	public string Symbol;

	[JsonProperty("createdDate")]
	public int CreatedDate;

	[JsonProperty("updatedDate")]
	public int UpdatedDate;

	[JsonProperty("price")]
	public string Price;

	[JsonProperty("quantity")]
	public string Quantity;

	[JsonProperty("leftQuantity")]
	public string LeftQuantity;

	[JsonProperty("triggerPrice")]
	public string TriggerPrice;

	[JsonProperty("total")]
	public decimal Total;

	[JsonProperty("side")]
	public string Side;

	[JsonProperty("status")]
	public string Status;

	[JsonProperty("type")]
	public string Type;

	[JsonProperty("clientId")]
	public string ClientId;

	[JsonProperty("tradeCount")]
	public int TradeCount;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OrdersHistoryItem()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrdersHistoryItem()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
