# ideal.exe — Kapsamlı Veri Yapısı Analizi
**Tarih:** 2026-04-11  
**Araç:** .NET ildasm metadata + binary string analizi

---

## Temel Bilgiler

| Özellik | Değer |
|---------|-------|
| Platform | .NET Framework 4.6, x86 |
| Versiyon | 0.10.8.6 |
| Boyut | 17.5 MB |
| MVID | 54F36D18-35C8-4D4A-A0D4-BC34219BABC3 |
| Koruma | SuppressIldasmAttribute (IL dump engeli), bilinen obfuscator yok |

### Tip İstatistikleri
- **3221 TypeDef** (class/struct/interface/enum)
- **2126 anlamlı sınıf** | **1060 obfuscated** | **35 enum**
- **1117 veri modeli** sınıfı (field/property içeren)
- **361 finans/trading** sınıfı

---

## Kritik Enum Tanımları

### ideal.OrderSide (Emir Yönü)
```
Buy=1, Sell=2, BuyMinus=3, SellPlus=4, SellShort=5,
SellShortExempt=6, Undisclosed=7, Cross=8, CrossShort=9,
CrossShortExempt=65, AsDefined=66, Opposite=67,
Subscribe=68, Redeem=69, Lend=70, Borrow=71
```

### ideal.OrderType (Emir Tipi)
```
Market=1, Limit=2, Stop=3, StopLimit=4, MarketOnClose=5,
WithOrWithout=6, LimitOrBetter=7, LimitWithOrWithout=8, OnBasis=9,
OnClose=65, LimitOnClose=66, Funari=73, Pegged=80
```

### ideal.OrderStatus
```
PartiallyFilled=1, Filled=2, DoneForDay=3, Canceled=4,
Replaced=5, PendingCancel=6, Rejected=8, PendingNew=65,
Expired=67, PendingReplace=69
```

### ideal.TimeInForce
```
GoodTillCancel=1, ImmediateOrCancel=3, FillOrKill=4,
GoodTillDate=6, AtCrossing=9, GoodTillEndOfSession=83
```

### ideal.MessageType (FIX Protokolü — ASCII değerler)
```
NewOrder=65(A), CancelOrder=66(B), CancelReplaceOrder=82(R),
GetOrder=67(C), GetOrders=68(D), OrderReport=69(E),
Login=76(L), Logout=77(M), Heartbeat=72(H), Error=90(Z)
```

### IDealOrderType (Robot Türleri)
```
Robot=1, iDealGo=2, TaramaRobot=3, RoboTrade=4, OtoTrade=5,
GridBot=6, TrendBot=7, YatayBot=8, PacalBot=9, Arbitraj=10,
TrendAlarm=11, EgzotikRobot=12, ExecutionAlgo=13
```

### ideal.AlgoTypes
```
VWAP=2, HCM=3, POV=4, POV2=5, ICEBERG=6, ARBITRAJ=7
```

### ideal.TradeBotStatus
```
New=1, Start=2, TP=3, PSL=4, SL=5, Stop=6
```

### ideal.ConnectionState
```
Connected=1, Authenticating=2, Authenticated=3, Failed=4, Error=5
```

### ideal.enDrawStyles (Grafik)
```
Candle=1, Line=2, Area=3, HeikinAshi=4, Renko=5
```

### ideal.enAvrMethods (Ortalama Yöntemleri)
```
Exponential=1, Weighted=2, Wilder=3, TimeSeries=4,
Triangular=5, Variable=6, VolumeAdjusted=7, ZeroLag=8, HullMA=9
```

### ideal.exIndicatorTypes (137 teknik indikatör)
Alligator, BollingerBands, Dema, Tema, Ichimoku, MovingAverage,
ParabolicSAR, RSI, MACD, Stochastic, CCI, ATR, ADX, OBV,
TKE, TOMA, QQE, HullMA, FisherTransform, BilancoFK... (+127 daha)

---

## Veri Modeli Sınıfları

### BIST Hisse Emri — `ImkbOrderRecord`
```
LongAccountName, AccountName, AccountNo, OrderNo, Symbol,
BuySell, Amount, GAmount, Balance, GPrice, Price, Total, GTotal,
ValorDate, Status, StatusCode, Session, OrderPermit,
OrderDate, OrderUpdateDate, OrderEndDate, OrderType,
CancelPermit, AmendPermit, OneSessionPermit,
OrderRef, ZincirRef, Note, Validity, SatisTip,
GSaat, EmirUpdateNum, SiraNo, MaxZincirSiraNo,
RefNo, BorsaRefNo, SessionName, ExecutionStatus, Selected
+ property: OrderNoString
```

### VİOP Emri — `VipOrderRecord`
```
LongAccountName, AccountName, AccountNo, OrderNo, RecordNo,
Symbol, BuySell, SubMarket, Amount, GAmount, Balance, GPrice,
Price, Stop, Total, GTotal, ValorDate, Status, StatusCode,
State, CancelReason, PositionClosing, BorsaDurum,
OrderDate, OrderTime, OrderType, EndDate, PriceType,
BorsaEmirNo, TemsilciRef, EnteredAmount, InvisibleAmount,
VisibleBalance, OrderRef, SartTip, SartYon, SartSembol,
SartFiyat, SessionName, ExecutionStatus, Selected
```

### BIST Pozisyon — `ImkbPositionRecord`
```
Symbol, Lot, LastPrice, Sellable, Cost, Bloke, ProfitX,
PortfolioType, uniqueSymbol, equityType,
balanceT/T1/T2/T3, avgPrice, depotCode, currentAmount,
AssetType, BalanceType, LotT1, LotT2, PortfoyOran,
Rumuz, HesapName, AltHesap, DovizCinsi, DovizDegeri, Price
+ properties: Profit, ProfitYuzde, TotalTL
```

### VİOP Pozisyon — `VipPositionRecord`
```
Symbol, BuyAmount, SellAmount, OpenAmount, NetAmount, UnitAmount,
OpenPosition, Profit, PozSize, ProfitAnlik, ProfitFifo,
SonUzlasi, Status, Direction, Price, LastPrice, SettlementPrice,
ContractType, Tip, Risk, Currency, Cost, Nominal,
NetFifoMaliyet, NetMaliyet, OpsiyonPrimiNet, AcilisMaliyet,
balanceT/T1/T2/T3, avgPrice, currentAmount, profitLoss, qty
```

### Kripto Emri — `CriptoOrderRecord`
```
LongAccountName, AccountName, AccountNo, OrderNo, Symbol, Kod,
BuySell, Amount, GAmount, Balance, GPrice, Price, StopPrice,
Total, GTotal, ValorDate, Status, StatusCode, Session,
OrderType, ZincirRef, Note, Validity, SatisTip,
SessionName, ExecutionStatus, Selected
+ property: OrderNoString
```

### Kripto Pozisyon — `CriptoPositionRecord`
```
Symbol, Coin, Description, Lot, Locked, LastPrice, Sellable,
Cost, Bloke, ProfitX, Request, Blocked, Available,
AssetType, BalanceType, id
+ properties: Asset, Order, Total, Profit
```

### Bar (OHLCV) — `Bar`
```
time: R4, open: R4, close: R4, high: R4, low: R4, volume: R4
```

### Bar (Grafik) — `Getchartdata`
```
ts: I8, open: R8, high: R8, low: R8, close: R8, volume: R8
```

### Ana Portföy — `Portfoy` (80+ field)
```
ImkbPositionList, ImkbOrderList, ImkbStatementList
ImkbSummaryDictionary, ImkbStockSellableDictionary
CriptoOrderList, CriptoPositionList, CriptoTradeList
CriptoFuturePositions, CriptoFutureOpenOrders,
VipPositionList, VipOrderList, VipGerceklesenList
FonPositionList, VarlikList
ImkbLimit, ImkbOverall, ImkbCariBakiye, ImkbKrediDahilLimit
ViopTeminatToplam, ViopTeminatBaslangic, ViopTeminatSurdurme,
ViopTeminatKullanilabilir, ViopNetMaliyet, ViopProfitLoss
ToplamTeminat, GayriNakdiTeminat, FifoMaliyet
```

### Finansal Rasyo — `HisseRasyoRecord`
```
Donem, Symbol,
CariOran, LikitOran, NakitOran, KaldiracOran, BorcOzsermayeOran,
AlacakDevHiz, StokDevirHiz, NetIsSerDevHiz, OzkaynakDevHiz,
BurutKarMarj, NetKarMarj, FaliyetKarMarj, AktifKarlilik, OzSerKarlilik,
EsasFaaliyetKari, FAVOK, NetDonemKar, NetIsletmeSer, sector
```

### Kurum Hacim — `KurumHacimRecord`
```
KurumId, Broker, VolumeBuy, VolumeBuyP, VolumeSell,
VolumeSellP, VolumeSum, VolumeSumP, VolumeDif, VolumeDifP
```

### Senet Hacim — `SenetHacimRecord`
```
Stock, AlisLot, SatisLot, AlisHacim, SatisHacim,
ToplamLot, ToplamHacim, NetLot, NetHacim, Yuzde, Maliyet
```

### Emir Gönderme (API) — `ReqEquitySendOrder`
```
appCode, appPassword, accountId, clOrdId,
instrumentSymbol, uniqueSymbol, instrumentType,
qty, price, sideId, closeShortSell, orderTypeId, timeInForceId,
token, tokenVersion, marketSegmentAlert, maxFloor
```

### VIOP Emir Gönderme — `VipSendOrderReq`
```
sozlesme, islem, miktar, fiyat, orderType,
sureTarih, sure, gorunenMiktar,
tetikTipi, tetikFiyat, tetikSozlesme,
acikKapali, smsGonderimi, aksamSeansi
```

### Robot Pozisyon — `RobotPositionClass`
```
Position: R8, SonIslemFiyat: R8, SonIslemTarih: DateTime, Rezerv: String
```

### BIST Robot Hesabı — `BistRobotHesapClass`
```
Pozisyonlar: List<ImkbPositionRecord>
GerceklesenEmirler: List<ImkbOrderRecord>
BekleyenEmirler: List<ImkbOrderRecord>
IslemLimit: R8, Bakiye: R8
```

### VIOP Robot Hesabı — `ViopRobotHesapClass`
```
Pozisyonlar: List<VipPositionRecord>
GerceklesenEmirler: List<VipOrderRecord>
BekleyenEmirler: List<VipOrderRecord>
TeminatToplam, TeminatBaslangic, TeminatSurdurme,
TeminatKullanilabilir, TeminatCekilebilir, TeminatCagri
```

### Artiox Emir — `ReqArtioxSendOrder`
```
cookie, sid, client_ip, pair_id[], order_type, amount, price
```

### Login / Oturum
```csharp
class LoginResponseData { accessToken, expiresIn, userData }
class Userdata { sicilNo, ad, soyad, sonGiris, kalanGun }
```

---

## Borsa Bağlantıları (String Analizi)

Desteklenen piyasalar ve veri kaynakları:
- **BIST**: IMKB, SASE, TURIB (hisse/fon)
- **VIOP**: VİP (vadeli/opsiyon)
- **Kripto**: Binance (Spot+Future), Icrypex (Spot+Future+TRY), Artiox
- **Endeks**: XU100, XUTUM, IMKBX, THVL1/2, VIPL1/2
- **Uluslararası**: NASDAQ, XETRA, EUREX, COMEX, NYMEX, Huobi
- **Döviz**: EURUSD, ETHHL

---

## FIX Protokolü Eşleşmesi (ideal.MessageField)

| Tag | Alan | Değer |
|-----|------|-------|
| 4 | Type | MessageType enum |
| 5 | BodyLength | - |
| 7 | Checksum | - |
| 11 | Id | - |
| 12 | Symbol | Sembol kodu |
| 13 | Quantity | Lot miktarı |
| 14 | OrderType | OrderType enum |
| 15 | OrderSide | OrderSide enum |
| 16 | TimeInForce | TimeInForce enum |
| 17 | OrderCapacity | OrderCapacity enum |
| 18 | Account | Hesap no |
| 19 | Price | Fiyat |
| 22 | OrderStatus | OrderStatus enum |
| 37 | OrderId | - |

---

## Çıktı Dosyaları (D:\Projects\_secfix\ideal_analysis\)

| Dosya | İçerik |
|-------|--------|
| 06_strings_ascii.txt | 111K ASCII string |
| 07_strings_unicode.txt | 26K Unicode string |
| 08_cat_finance.txt | 3068 finans string'i |
| 08_cat_column_name.txt | 878 sütun/sembol adı |
| 08_cat_database.txt | 1499 DB/SQL string'i |
| 11_meaningful_classes.txt | 2126 anlamlı sınıf |
| 12_enums_with_values.txt | 32 enum + sayısal değerler |
| 13_data_models_top200.txt | En çok field içeren 200 model |
| 14_finance_classes.txt | 361 finans sınıfı detayı |
| ideal_meta.il | 42MB ildasm metadata dump |
