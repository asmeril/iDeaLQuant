using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class OrderItems
{
	[JsonProperty("pageIndex")]
	public int PageIndex;

	[JsonProperty("pageSize")]
	public int PageSize;

	[JsonProperty("totalCount")]
	public int TotalCount;

	[JsonProperty("totalPages")]
	public int TotalPages;

	[JsonProperty("indexFrom")]
	public int IndexFrom;

	[JsonProperty("hasPreviousPage")]
	public bool HasPreviousPage;

	[JsonProperty("hasNextPage")]
	public bool HasNextPage;

	[JsonProperty("items")]
	public List<Item> Items;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OrderItems()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderItems()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
