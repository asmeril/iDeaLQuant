using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class Asset
{
	[JsonProperty("symbol")]
	public string Symbol;

	[JsonProperty("name")]
	public string Name;

	[JsonProperty("categories")]
	public List<string> Categories;

	[JsonProperty("description")]
	public string Description;

	[JsonProperty("type")]
	public string Type;

	[JsonProperty("isEnabled")]
	public bool IsEnabled;

	[JsonProperty("isNew")]
	public bool IsNew;

	[JsonProperty("isWithdrawalEnabled")]
	public bool IsWithdrawalEnabled;

	[JsonProperty("isDepositEnabled")]
	public bool IsDepositEnabled;

	[JsonProperty("precision")]
	public int Precision;

	[JsonProperty("displayPrecision")]
	public int DisplayPrecision;

	[JsonProperty("minDeposit")]
	public string MinDeposit;

	[JsonProperty("minWithdrawal")]
	public string MinWithdrawal;

	[JsonProperty("updatedDate")]
	public int UpdatedDate;

	[JsonProperty("createdDate")]
	public int CreatedDate;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Asset()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Asset()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
