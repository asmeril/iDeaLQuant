using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class Symbols
{
	[JsonProperty("version")]
	public string Version;

	[JsonProperty("assets")]
	public List<Asset> Assets;

	[JsonProperty("pairs")]
	public List<Pair> Pairs;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Symbols()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Symbols()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
