using System.Runtime.InteropServices;

namespace ideal;

[StructLayout(LayoutKind.Sequential, Size = 1)]
public struct cxFieldCodes
{
	public const int NullData = 0;

	public const int Symbol = 1;

	public const int Description = 2;

	public const int Exchange = 3;

	public const int MarketCode = 4;

	public const int SubMarket = 5;

	public const int Sector = 6;

	public const int DecimalPoint = 7;

	public const int IndexType = 8;

	public const int Grup = 9;

	public const int Seri = 10;

	public const int Yontem = 11;

	public const int Durum = 12;

	public const int LastPrice = 13;

	public const int LastSize = 14;

	public const int LastSize2 = 15;

	public const int LastVol = 16;

	public const int LastVol2 = 17;

	public const int Direction = 18;

	public const int BidPrice = 19;

	public const int BidSize = 20;

	public const int BidVol = 21;

	public const int AskPrice = 22;

	public const int AskSize = 23;

	public const int AskVol = 24;

	public const int ClosePrice = 25;

	public const int OpenSession = 26;

	public const int OpenDay = 27;

	public const int LimitUp = 28;

	public const int LimitDown = 29;

	public const int BazPrice = 30;

	public const int MarketMakerCode = 31;

	public const int MarketMakerBid = 32;

	public const int MarketMakerAsk = 33;

	public const int PriceStep = 34;

	public const int TickSession = 35;

	public const int TickDay = 36;

	public const int IzafiSession = 37;

	public const int IzafiDay = 38;

	public const int Date = 39;

	public const int Time = 40;

	public const int WaitingBidWavr = 41;

	public const int WaitingAskWavr = 42;

	public const int WaitingBidSize = 43;

	public const int WaitingAskSize = 44;

	public const int WaitingBidRate = 45;

	public const int WaitingAskRate = 46;

	public const int CanceledBidWavr = 47;

	public const int CanceledAskWavr = 48;

	public const int HighSession = 49;

	public const int HighSession1 = 50;

	public const int HighDay = 51;

	public const int HighWeek = 52;

	public const int HighWeek1 = 53;

	public const int HighMonth = 54;

	public const int HighMonth1 = 55;

	public const int HighMonth3 = 56;

	public const int HighMonth6 = 57;

	public const int HighYear = 58;

	public const int HighYear1 = 59;

	public const int LowSession = 60;

	public const int LowSession1 = 61;

	public const int LowDay = 62;

	public const int LowWeek = 63;

	public const int LowWeek1 = 64;

	public const int LowMonth = 65;

	public const int LowMonth1 = 66;

	public const int LowMonth3 = 67;

	public const int LowMonth6 = 68;

	public const int LowYear = 69;

	public const int LowYear1 = 70;

	public const int PrevCloseSession = 71;

	public const int PrevCloseDay = 72;

	public const int PrevCloseWeek = 73;

	public const int PrevCloseWeek1 = 74;

	public const int PrevCloseMonth = 75;

	public const int PrevCloseMonth1 = 76;

	public const int PrevCloseMonth3 = 77;

	public const int PrevCloseMonth6 = 78;

	public const int PrevCloseYear = 79;

	public const int PrevCloseYear1 = 80;

	public const int NetDifSession = 81;

	public const int NetDifDay = 82;

	public const int NetDifWeek = 83;

	public const int NetDifWeek1 = 84;

	public const int NetDifMonth = 85;

	public const int NetDifMonth1 = 86;

	public const int NetDifMonth3 = 87;

	public const int NetDifMonth6 = 88;

	public const int NetDifYear = 89;

	public const int NetDifYear1 = 90;

	public const int NetPerSession = 91;

	public const int NetPerDay = 92;

	public const int NetPerWeek = 93;

	public const int NetPerWeek1 = 94;

	public const int NetPerMonth = 95;

	public const int NetPerMonth1 = 96;

	public const int NetPerMonth3 = 97;

	public const int NetPerMonth6 = 98;

	public const int NetPerYear = 99;

	public const int NetPerYear1 = 100;

	public const int SizeSession = 101;

	public const int SizeSession1 = 102;

	public const int SizeDay = 103;

	public const int SizeWeek = 104;

	public const int SizeWeek1 = 105;

	public const int SizeMonth = 106;

	public const int SizeMonth1 = 107;

	public const int SizeMonth3 = 108;

	public const int SizeMonth6 = 109;

	public const int SizeYear = 110;

	public const int SizeYear1 = 111;

	public const int VolSession = 112;

	public const int VolSession1 = 113;

	public const int VolDay = 114;

	public const int VolWeek = 115;

	public const int VolWeek1 = 116;

	public const int VolMonth = 117;

	public const int VolMonth1 = 118;

	public const int VolMonth3 = 119;

	public const int VolMonth6 = 120;

	public const int VolYear = 121;

	public const int VolYear1 = 122;

	public const int WavrSession = 123;

	public const int WavrSession1 = 124;

	public const int WavrDay = 125;

	public const int WavrPeriodic = 126;

	public const int Wavr2Session = 127;

	public const int Wavr2Session1 = 128;

	public const int Wavr2Day = 129;

	public const int Wavr2Week = 130;

	public const int Wavr2Week1 = 131;

	public const int Wavr2Month = 132;

	public const int Wavr2Month1 = 133;

	public const int Wavr2Month3 = 134;

	public const int Wavr2Month6 = 135;

	public const int Wavr2Year = 136;

	public const int Wavr2Year1 = 137;

	public const int MoneyflowInput = 138;

	public const int MoneyflowOutput = 139;

	public const int MoneyflowTotal = 140;

	public const int MoneyflowNetDif = 141;

	public const int MoneyflowNetPer = 142;

	public const int MoneyflowGraph = 143;

	public const int GraphSession = 144;

	public const int GraphDay = 145;

	public const int GraphWeek = 146;

	public const int GraphWeek1 = 147;

	public const int GraphMonth = 148;

	public const int GraphMonth1 = 149;

	public const int GraphMonth3 = 150;

	public const int GraphMonth6 = 151;

	public const int GraphYear = 152;

	public const int GraphYear1 = 153;

	public const int BalanceSheetPeriod = 154;

	public const int Capital = 155;

	public const int NetProfit = 156;

	public const int PublicRatio = 157;

	public const int NumberOfShares = 158;

	public const int PriceEarningRatio = 159;

	public const int PriceEarningValue = 160;

	public const int MarketValue = 161;

	public const int BookValue = 162;

	public const int BorrowBid = 163;

	public const int BorrowAsk = 164;

	public const int BorrowLast = 165;

	public const int PrevSettlement = 166;

	public const int SettlementPrice = 167;

	public const int FixingPrice = 168;

	public const int ExpiryDate = 169;

	public const int DaysToExpiry = 170;

	public const int OpenInterest = 171;

	public const int OpenInterestDif = 172;

	public const int AI = 173;

	public const int BSP = 174;

	public const int BidRate = 175;

	public const int AskRate = 176;

	public const int ASP = 177;

	public const int LastRate = 178;

	public const int LastTakas = 179;

	public const int CY = 180;

	public const int DTM = 181;

	public const int RYLD = 182;

	public const int PrevRate = 183;

	public const int PrevPrice = 184;

	public const int PrevDate = 185;

	public const int AV = 186;

	public const int SY = 187;

	public const int AVSP = 188;

	public const int MinRate = 189;

	public const int MaxRate = 190;

	public const int AvrRate = 191;

	public const int BidTime = 192;

	public const int AskTime = 193;

	public const int Vade = 194;

	public const int Valor = 195;

	public const int Day = 196;

	public const int Isin = 197;

	public const int Risk = 198;

	public const int Line = 199;

	public const int AVRCY = 200;

	public const int FI182 = 201;

	public const int FI273 = 202;

	public const int FI365 = 203;

	public const int FI456 = 204;

	public const int FIGENEL = 205;

	public const int Maturity = 206;

	public const int Currency = 207;

	public const int Coupon = 208;

	public const int Spread = 209;

	public const int Duration = 210;

	public const int OptionPremiumDay = 211;

	public const int BaseSymbol = 212;

	public const int OptionType = 213;

	public const int OptionKind = 214;

	public const int StrikePrice = 215;

	public const int GrupName = 216;

	public const int GrupNo = 217;

	public const int StartDate = 218;

	public const int Multiplier = 219;

	public const int DeliveryType = 220;

	public const int PrevSymbol = 221;

	public const int Action = 222;

	public const int SessionName = 223;

	public const int Broker = 224;

	public const int Barrier = 225;

	public const int TeorikVal = 226;

	public const int TeorikDif = 227;

	public const int TeorikPer = 228;

	public const int OzCapital = 229;

	public const int PiyDegDefDeg = 230;

	public const int DTC = 231;

	public const int DengeFiyat = 232;

	public const int DengeMiktar = 233;

	public const int DengeBidKalan = 234;

	public const int DengeAskKalan = 235;

	public const int DengeLastFark = 236;

	public const int DengeLastFarkY = 237;

	public const int DengeLotFark = 238;

	public const int SettleFark = 239;

	public const int SettleFarkY = 240;

	public const int KurumNetLot = 241;

	public const int KurumNetHacim = 242;

	public const int KurumNetMaliyet = 243;

	public const int KurumToplamLot = 244;

	public const int KurumToplamHacim = 245;

	public const int KurumAlisLot = 246;

	public const int KurumAlisHacim = 247;

	public const int KurumAlisMaliyet = 248;

	public const int KurumSatisLot = 249;

	public const int KurumSatisHacim = 250;

	public const int KurumSatisMaliyet = 251;

	public const int MaksAlanId = 252;

	public const int MaksAlanNet = 253;

	public const int MaksSatanId = 254;

	public const int MaksSatanNet = 255;

	public const int Pgc5Lot = 256;

	public const int Pgc5AlisToplam = 257;

	public const int Pgc5SatisToplam = 258;

	public const int Pgc5Oran = 259;

	public const int TakasBirKurumKod = 260;

	public const int TakasBirLot = 261;

	public const int TakasBirYuzde = 262;

	public const int TakasYabanciLot = 263;

	public const int TakasYabanciYuzde = 264;

	public const int TakasYabanciHaftaFark = 265;

	public const int TakasYabanciHaftaYuzde = 266;

	public const int TakasYabanciAyFark = 267;

	public const int TakasYabanciAyYuzde = 268;

	public const int DayanakFiyat = 269;

	public const int DayanakFark1 = 270;

	public const int DayanakFark2 = 271;

	public const int DayanakAlSat = 272;

	public const int DayanakSatAl = 273;

	public const int Pgc5Tl = 274;

	public const int Pgc5TlAlisToplam = 275;

	public const int Pgc5TlSatisToplam = 276;

	public const int Pgc5TlOran = 277;

	public const int MaksAlanMaliyet = 278;

	public const int MaksSatanMaliyet = 279;

	public const int MaksAlanYuzde = 280;

	public const int MaksSatanYuzde = 281;

	public const int Dipnot = 282;

	public const int HesapAdet = 283;

	public const int HesapKz1 = 284;

	public const int HesapKz2 = 285;

	public const int HesapMaliyet = 286;

	public const int Ikon = 287;

	public const int SizeWeekCalc = 300;

	public const int SizeMonthCalc = 301;

	public const int SizeYearCalc = 302;

	public const int SizeWeek1Calc = 303;

	public const int SizeMonth1Calc = 304;

	public const int SizeMonth3Calc = 305;

	public const int SizeMonth6Calc = 306;

	public const int SizeYear1Calc = 307;

	public const int VolWeekCalc = 308;

	public const int VolMonthCalc = 309;

	public const int VolYearCalc = 310;

	public const int VolWeek1Calc = 311;

	public const int VolMonth1Calc = 312;

	public const int VolMonth3Calc = 313;

	public const int VolMonth6Calc = 314;

	public const int VolYear1Calc = 315;
}
