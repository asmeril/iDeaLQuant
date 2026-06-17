using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class OrderIcry
{
	[JsonProperty("version")]
	public string Version;

	[JsonProperty("assets")]
	public List<Asset> Assets;

	[JsonProperty("pairs")]
	public List<Pairs> Pairs;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OrderIcry()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderIcry()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
