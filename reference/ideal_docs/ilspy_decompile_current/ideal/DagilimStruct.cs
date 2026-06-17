using System.Runtime.InteropServices;

namespace ideal;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct DagilimStruct
{
	public int SembolId;

	public int KurumID;

	public int BuyLot;

	public double BuyVol;

	public int SellLot;

	public double SellVol;

	public double BuyVolOrj;

	public double SellVolOrj;
}
