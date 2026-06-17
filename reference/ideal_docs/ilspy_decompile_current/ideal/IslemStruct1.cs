using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using dg3ypDAonQcOidMs0w;

namespace ideal;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct IslemStruct1
{
	public int TradeID;

	public int SembolId;

	public int BuyerID;

	public int SellerID;

	public byte Hour;

	public byte Minute;

	public byte Second;

	public float Price;

	public float Size;

	public byte Deleted;

	public byte AggresiveParty;

	public byte NasdaqTradeType;

	public byte Tip;

	public float Vol;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetTimeNumeric()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetTimeString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IslemStruct1 GetShallowCopy()
	{
		return (IslemStruct1)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte GetDirection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string HourMinuteString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetTimeIndex()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static IslemStruct1()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
