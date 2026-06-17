# Focused ideal.exe API Report

This report filters compiler-generated state machines and highlights likely usable iDeal/finance APIs.

Interesting types: 392

## Accountcashposition

Extends: `System.Object`


Properties:
- `string accountId`
- `int assetCoef`
- `float avgPrice`
- `float balanceT`
- `float balanceT1`
- `float balanceT2`
- `float balanceT3`
- `float currentAmount`
- `float currentAmountT2`
- `string depotCode`
- `string depotDescription`
- `float dpAmount`
- `string dpPosKey`
- `float dpProfitLoss`
- `long lastChange`
- `float lastPrice`
- `object profitLoss`
- `int secId`
- `int sellCoef`
- `string uniqueSymbol`
- `float useableQty`

## AccountDailyTransaction

Extends: `System.Object`


Properties:
- `int gerceklesenOzet`

## AccountDailyTransactionData

Extends: `System.Object`


Properties:
- `class AccountDailyTransactionHgi[] hgi`

## AccountDailyTransactionHgi

Extends: `System.Object`


Properties:
- `float adet`
- `string alSat`
- `string editOpsiyonlari`
- `string emirGecerlilikSuresi`
- `valuetype System.DateTime emirGecerlilikTarihi`
- `System.Nullable`1<valuetype System.DateTime> emirGirisTarihi`
- `string emirTipi`
- `double fiyat`
- `float gerceklesenMiktar`
- `System.Nullable`1<float> gorunenMiktar`
- `string hesapNo`
- `string hisseAdi`
- `string imkbEmirNo`
- `string islemDurumu`
- `string islemTuru`
- `float kalan`
- `int lotAdet`
- `int orjSysId`
- `string referans`
- `string saat`
- `string saat2`
- `float tutar`
- `string valor`
- `System.Nullable`1<int> zincirId`
- `System.Nullable`1<int> zincirUstId`
- `System.Nullable`1<int> zincirVar`

## AccountDailyTransactionResponse

Extends: `System.Object`


Properties:
- `class AccountDailyTransactionData data`
- `object message`
- `int statusCode`
- `bool success`

## AccountInfo

Extends: `System.Object`


Properties:
- `System.Collections.Generic.List`1<class BalanceItem> Balances`
- `bool CanDeposit`
- `bool CanTrade`
- `bool CanWithdraw`
- `class Error Error`
- `bool Success`
- `valuetype System.DateTimeOffset UpdateTime`

## AccountInformation

Extends: `System.Object`


Properties:
- `System.Collections.Generic.List`1<class AccountInformationAsset> assets`
- `System.Collections.Generic.List`1<class AccountInformationAsset> assets`
- `string availableBalance`
- `string availableBalance`
- `bool canDeposit`
- `bool canDeposit`
- `bool canTrade`
- `bool canTrade`
- `bool canWithdraw`
- `bool canWithdraw`
- `long feeTier`
- `long feeTier`
- `string maxWithdrawAmount`
- `string maxWithdrawAmount`
- `System.Collections.Generic.List`1<class AccountInformationPosition> positions`
- `System.Collections.Generic.List`1<class AccountInformationPosition> positions`
- `string totalCrossUnPnl`
- `string totalCrossUnPnl`
- `string totalCrossWalletBalance`
- `string totalCrossWalletBalance`
- `string totalInitialMargin`
- `string totalInitialMargin`
- `string totalMaintMargin`
- `string totalMaintMargin`
- `string totalMarginBalance`
- `string totalMarginBalance`
- `string totalOpenOrderInitialMargin`
- `string totalOpenOrderInitialMargin`
- `string totalPositionInitialMargin`
- `string totalPositionInitialMargin`
- `string totalUnrealizedProfit`
- `string totalUnrealizedProfit`
- `string totalWalletBalance`
- `string totalWalletBalance`
- `long updateTime`
- `long updateTime`

## AccountInformation

Extends: `System.Object`


Properties:
- `System.Collections.Generic.List`1<class AccountInformationAsset> assets`
- `System.Collections.Generic.List`1<class AccountInformationAsset> assets`
- `string availableBalance`
- `string availableBalance`
- `bool canDeposit`
- `bool canDeposit`
- `bool canTrade`
- `bool canTrade`
- `bool canWithdraw`
- `bool canWithdraw`
- `long feeTier`
- `long feeTier`
- `string maxWithdrawAmount`
- `string maxWithdrawAmount`
- `System.Collections.Generic.List`1<class AccountInformationPosition> positions`
- `System.Collections.Generic.List`1<class AccountInformationPosition> positions`
- `string totalCrossUnPnl`
- `string totalCrossUnPnl`
- `string totalCrossWalletBalance`
- `string totalCrossWalletBalance`
- `string totalInitialMargin`
- `string totalInitialMargin`
- `string totalMaintMargin`
- `string totalMaintMargin`
- `string totalMarginBalance`
- `string totalMarginBalance`
- `string totalOpenOrderInitialMargin`
- `string totalOpenOrderInitialMargin`
- `string totalPositionInitialMargin`
- `string totalPositionInitialMargin`
- `string totalUnrealizedProfit`
- `string totalUnrealizedProfit`
- `string totalWalletBalance`
- `string totalWalletBalance`
- `long updateTime`
- `long updateTime`

## AccountInformationAsset

Extends: `System.Object`


Properties:
- `string asset`
- `string asset`
- `string availableBalance`
- `string availableBalance`
- `string crossUnPnl`
- `string crossUnPnl`
- `string crossWalletBalance`
- `string crossWalletBalance`
- `string initialMargin`
- `string initialMargin`
- `string maintMargin`
- `string maintMargin`
- `bool marginAvailable`
- `bool marginAvailable`
- `string marginBalance`
- `string marginBalance`
- `string maxWithdrawAmount`
- `string maxWithdrawAmount`
- `string openOrderInitialMargin`
- `string openOrderInitialMargin`
- `string positionInitialMargin`
- `string positionInitialMargin`
- `string unrealizedProfit`
- `string unrealizedProfit`
- `long updateTime`
- `long updateTime`
- `string walletBalance`
- `string walletBalance`

## AccountInformationAsset

Extends: `System.Object`


Properties:
- `string asset`
- `string asset`
- `string availableBalance`
- `string availableBalance`
- `string crossUnPnl`
- `string crossUnPnl`
- `string crossWalletBalance`
- `string crossWalletBalance`
- `string initialMargin`
- `string initialMargin`
- `string maintMargin`
- `string maintMargin`
- `bool marginAvailable`
- `bool marginAvailable`
- `string marginBalance`
- `string marginBalance`
- `string maxWithdrawAmount`
- `string maxWithdrawAmount`
- `string openOrderInitialMargin`
- `string openOrderInitialMargin`
- `string positionInitialMargin`
- `string positionInitialMargin`
- `string unrealizedProfit`
- `string unrealizedProfit`
- `long updateTime`
- `long updateTime`
- `string walletBalance`
- `string walletBalance`

## AccountInformationPosition

Extends: `System.Object`


Properties:
- `string askNotional`
- `string askNotional`
- `string bidNotional`
- `string bidNotional`
- `string entryPrice`
- `string entryPrice`
- `string initialMargin`
- `string initialMargin`
- `bool isolated`
- `bool isolated`
- `string isolatedWallet`
- `string isolatedWallet`
- `string leverage`
- `string leverage`
- `string maintMargin`
- `string maintMargin`
- `string maxNotional`
- `string maxNotional`
- `string notional`
- `string notional`
- `string openOrderInitialMargin`
- `string openOrderInitialMargin`
- `string positionAmt`
- `string positionAmt`
- `string positionInitialMargin`
- `string positionInitialMargin`
- `string positionSide`
- `string positionSide`
- `string symbol`
- `string symbol`
- `string unrealizedProfit`
- `string unrealizedProfit`
- `long updateTime`
- `long updateTime`

## AccountInformationPosition

Extends: `System.Object`


Properties:
- `string askNotional`
- `string askNotional`
- `string bidNotional`
- `string bidNotional`
- `string entryPrice`
- `string entryPrice`
- `string initialMargin`
- `string initialMargin`
- `bool isolated`
- `bool isolated`
- `string isolatedWallet`
- `string isolatedWallet`
- `string leverage`
- `string leverage`
- `string maintMargin`
- `string maintMargin`
- `string maxNotional`
- `string maxNotional`
- `string notional`
- `string notional`
- `string openOrderInitialMargin`
- `string openOrderInitialMargin`
- `string positionAmt`
- `string positionAmt`
- `string positionInitialMargin`
- `string positionInitialMargin`
- `string positionSide`
- `string positionSide`
- `string symbol`
- `string symbol`
- `string unrealizedProfit`
- `string unrealizedProfit`
- `long updateTime`
- `long updateTime`

## AccountInformationResponse

Extends: `System.Object`


Properties:
- `class AccountInformationResponseData data`
- `object message`
- `int statusCode`
- `bool success`

## AccountInformationResponseData

Extends: `System.Object`


Properties:
- `class AccountInformationResponseIslem[] islem`

## AccountInformationResponseIslem

Extends: `System.Object`


Properties:
- `string aciklama`
- `string bakiye`
- `string islemKodu`

## AccountRecord

Extends: `System.Object`

Methods:
- `public class TebHesapClass GetTebSubAccout(string)`
- `public void ResolveIP()`

Properties:
- `int OrderId`
- `string Parola_R`
- `string Password_R`
- `string RemoteImkbIPPort`
- `string RemoteVIOPIPPort`
- `string Tanim`

Fields:
- `public double AcarVipMaliyet`
- `public string AccountName`
- `public System.Collections.Generic.List`1<string> AccountNoList`
- `public System.Collections.Generic.Dictionary`2<string, string> AcigaSatisKapamaDictionary`
- `public string ActiveAccountNo`
- `public string ApiKey`
- `public string ApiKey_R`
- `public string BackOfficeBIST_IP`
- `public string BackOfficeIp`
- `public string BackOfficeVIOP_IP`
- `public string Broker`
- `public string Code2FA`
- `public class Cookie Cookie`
- `public string CustomerNo`
- `public string Device`
- `public string DeviceId`
- `public string DeviceName`
- `public bool DropCopyBool`
- `public int FAZ`
- `public string FailedLoginTime`
- `public string GeneksVendorCode`
- `public string HesapYetki`
- `public string HttpMethod`
- `public string IP`
- `public string Id`
- `public string ImkbBackOffice`
- `public string ImkbUrl`
- `public string IsYatTransactionId`
- `public System.Collections.Generic.Dictionary`2<string, class Accounts> IsYatirimHesapDict`
- `public string LocalPort`
- `public bool Loggedin`
- `public string LoginType`
- `public string LoginUrl`
- `public string MSG`
- `public int MagnusNext`
- `public int MagnusSendCount`
- `public int MagnusTabActive`
- `public string MagnusToken`
- `public string MagnusTransactionID`
- `public string Msg`
- `public string OTPDurum`
- `public string OldPassword`
- `public string OriginalPassword`
- `public string Otp`
- `public string PN`
- `public string Parola`
- `public string Password`
- `public string PasswordChangeToken`
- `public string PushMsg`
- `public bool Remember`
- `public bool SanalHesapBool`
- `public string SecretKey`
- `public string SecretKey_R`
- `public bool Selected`
- `public string SmsSifre`
- `public string SmsSure`
- `public string StateID`
- `public string SuccsessLoginTime`
- `public System.Collections.Generic.Dictionary`2<string, class TebHesapClass> TebHesapDict`
- `public string Token`
- `public class Token TokenObj`
- `public string UserId`
- `public bool ViopHesapKapaliBool`
- `public string VipBackOffice`
- `public string VipUrl`
- `public string VirmanYetkisi`
- `public string WebAccountName`
- `public string WebLogin`
- `public string WebParola`
- `public string WebPassword`
- `public string WebUrl`
- `public string bsSessionId`
- `public string email`
- `public string localIP`
- `public string musteriNo`
- `public string personName`
- `public string phoneNumber`
- `public string remoteIP`
- `public string sessionId`
- `public string throwMsg`

## Accounts

Extends: `System.Object`


Properties:
- `string accountId`
- `string accountName`
- `int accountTypeId`
- `string afkCode`
- `string complianceScore`
- `int customerId`
- `string legitimacyScore`
- `bool privateAccount`

## AccountsList

Extends: `System.Object`


Properties:
- `object errorCode`
- `object errorDescription`
- `bool ok`
- `string transactionId`
- `class Accounts[] value`

## AccountSummaryCash

Extends: `System.Object`


Properties:
- `object errorCode`
- `object errorDescription`
- `bool ok`
- `string transactionId`
- `class AccountSummaryCashValue value`

## AccountSummaryCashValue

Extends: `System.Object`


Properties:
- `class Accountcashposition[] accountCashPositions`
- `class Accounttotalcash[] accountTotals`

## AccountSummaryCredit

Extends: `System.Object`


Properties:
- `object errorCode`
- `object errorDescription`
- `bool ok`
- `string transactionId`
- `class AccountSummaryCreditValue[] value`

## AccountSummaryCreditValue

Extends: `System.Object`


Properties:
- `string accountId`
- `int assetCoef`
- `float avgPrice`
- `float balanceT`
- `float balanceT1`
- `float balanceT2`
- `float balanceT3`
- `float creditInterest`
- `float currentAmount`
- `float currentAmountT2`
- `string depotCode`
- `string depotDescription`
- `float dpAmount`
- `string dpPosKey`
- `float dpProfitLoss`
- `long lastChange`
- `float lastPrice`
- `object profitLoss`
- `int secId`
- `int sellCoef`
- `string uniqueSymbol`
- `float useableQty`
- `float usedCredit`

## Accounttotalcash

Extends: `System.Object`


Properties:
- `string accountId`
- `object dividendIncome`
- `long lastChange`
- `float swapEquityRatio`
- `float totalAmountInAcctCcy`
- `float totalEquityValue`
- `float totalEquityValueT2`
- `float totalPortfolioValue`

## Accounttotals

Extends: `System.Object`


Properties:
- `double aciga_Satista_Kullanilan`
- `double creditInterest`
- `double creditLimit`
- `double currencyValueEUR`
- `double currencyValueUSD`
- `double dividendIncome`
- `double fonPayAlimSatim`
- `double fon_PayStokTransferValue`
- `double onaylanmayan_Kredi`
- `double priorityRight`
- `double totalPortfolioValue`
- `double usedCredit`

## Bar

Extends: `System.Object`


Properties:
- `float close`
- `float high`
- `float low`
- `float open`
- `float time`
- `float volume`

## BistIslemHandler

Extends: `System.MulticastDelegate`

Methods:
- `public class System.IAsyncResult BeginInvoke(valuetype ideal.IslemStruct1; class System.AsyncCallback; object)`
- `public void EndInvoke(class System.IAsyncResult)`
- `public void Invoke(valuetype ideal.IslemStruct1)`

## BistRobotHesapClass

Extends: `System.Object`


Fields:
- `public double Bakiye`
- `public System.Collections.Generic.List`1<class ImkbOrderRecord> BekleyenEmirler`
- `public System.Collections.Generic.List`1<class ImkbOrderRecord> GerceklesenEmirler`
- `public double IslemLimit`
- `public System.Collections.Generic.List`1<class ImkbPositionRecord> Pozisyonlar`

## CancelOrder

Extends: `ideal.IdealMessage`


Properties:
- `string Account`
- `int OrderId`
- `valuetype ideal.OrderSide OrderSide`
- `string OrderUuid`
- `double Quantity`
- `string Symbol`

## CancelOrderResult

Extends: `System.Object`


Properties:
- `string activatePrice`
- `string activatePrice`
- `string clientOrderId`
- `string clientOrderId`
- `bool closePosition`
- `bool closePosition`
- `string cumQty`
- `string cumQty`
- `string cumQuote`
- `string cumQuote`
- `string executedQty`
- `string executedQty`
- `long orderId`
- `long orderId`
- `string origQty`
- `string origQty`
- `string origType`
- `string origType`
- `string positionSide`
- `string positionSide`
- `string price`
- `string price`
- `bool priceProtect`
- `bool priceProtect`
- `string priceRate`
- `string priceRate`
- `bool reduceOnly`
- `bool reduceOnly`
- `string side`
- `string side`
- `string status`
- `string status`
- `string stopPrice`
- `string stopPrice`
- `string symbol`
- `string symbol`
- `string timeInForce`
- `string timeInForce`
- `string type`
- `string type`
- `long updateTime`
- `long updateTime`
- `string workingType`
- `string workingType`

## CancelOrderResult

Extends: `System.Object`


Properties:
- `string activatePrice`
- `string activatePrice`
- `string clientOrderId`
- `string clientOrderId`
- `bool closePosition`
- `bool closePosition`
- `string cumQty`
- `string cumQty`
- `string cumQuote`
- `string cumQuote`
- `string executedQty`
- `string executedQty`
- `long orderId`
- `long orderId`
- `string origQty`
- `string origQty`
- `string origType`
- `string origType`
- `string positionSide`
- `string positionSide`
- `string price`
- `string price`
- `bool priceProtect`
- `bool priceProtect`
- `string priceRate`
- `string priceRate`
- `bool reduceOnly`
- `bool reduceOnly`
- `string side`
- `string side`
- `string status`
- `string status`
- `string stopPrice`
- `string stopPrice`
- `string symbol`
- `string symbol`
- `string timeInForce`
- `string timeInForce`
- `string type`
- `string type`
- `long updateTime`
- `long updateTime`
- `string workingType`
- `string workingType`

## CancelReplaceOrder

Extends: `ideal.IdealMessage`


Properties:
- `string Account`
- `int OrderId`
- `valuetype ideal.OrderSide OrderSide`
- `valuetype ideal.OrderType OrderType`
- `string OrderUuid`
- `double Price`
- `double Quantity`
- `string Symbol`

## Cashpositionlist

Extends: `System.Object`


Properties:
- `double amt`
- `double amtNet`
- `double amtT1`
- `double amtT2`
- `double amtT3`
- `double percentage`
- `double price`
- `int state`
- `string stateDescr`
- `string symbol`
- `double todaysValue`

## Chart

Extends: `System.Object`

Methods:
- `public void Change(string)`
- `public void Default()`
- `public void Delete()`
- `public void DeleteAll()`
- `public System.Collections.Generic.List`1<string> GetNames()`
- `public void Init()`
- `public void Read()`
- `public void Save(byte[])`
- `public void Saveas(byte[])`
- `public void Write()`

Fields:
- `public string ActiveName`
- `public class Chart ActiveObject`
- `public System.Collections.Generic.List`1<string> AllList`
- `public valuetype System.Drawing.Color AverageColor`
- `public bool AverageVisible`
- `public System.Collections.Generic.List`1<string> BarList`
- `public float BarSpace`
- `public bool BarStyleLine`
- `public valuetype System.Drawing.Color BuyArrowColor`
- `public string ChartInProgress`
- `public int ClassVersion`
- `public valuetype System.Drawing.Color CurrentBarColor`
- `public valuetype System.Drawing.Color DataWindowBackColor1`
- `public valuetype System.Drawing.Color DataWindowBackColor2`
- `public valuetype System.Drawing.Color DataWindowBorderColor`
- `public valuetype System.Drawing.Color DataWindowForeColor`
- `public int DataWindowOpacity`
- `public bool DataWindowVisible`
- `public string DateStart`
- `public bool DerinlikVisible`
- `public string DividerBaseSymbol`
- `public int DividerMode`
- `public int DonguPeriyot`
- `public valuetype ideal.enDrawStyles DrawStyle`
- `public float EmptySpaceWidth`
- `public valuetype System.Drawing.Color FillColor1`
- `public valuetype System.Drawing.Color FillColor2`
- `public int FillOpacity`
- `public valuetype System.Drawing.Color FlatArrowColor`
- `public class System.Drawing.Font FontSkala`
- `public valuetype System.Drawing.Color FrameActiveColor`
- `public valuetype System.Drawing.Color FrameBackColor1`
- `public valuetype System.Drawing.Color FrameBackColor2`
- `public valuetype System.Drawing.Color FrameBorderColor`
- `public int FrameCount`
- `public valuetype System.Drawing.Color FrameForeColor`
- `public valuetype System.Drawing.Color GridlineColor`
- `public bool GrupMember`
- `public bool HBarVisible`
- `public bool HacimBool`
- `public int HacimDayCount`
- `public int HacimKurumId`
- `public valuetype System.Drawing.Color HbarBackColor1`
- `public valuetype System.Drawing.Color HbarBackColor2`
- `public valuetype System.Drawing.Color HbarBorderColor`
- `public valuetype System.Drawing.Color HbarForeColor`
- `public valuetype System.Drawing.Color HbarMidBackColor1`
- `public valuetype System.Drawing.Color HbarMidBackColor2`
- `public valuetype System.Drawing.Color HbarMidBorderColor`
- `public valuetype System.Drawing.Color HeaderBackColor1`
- `public valuetype System.Drawing.Color HeaderBackColor2`
- `public valuetype System.Drawing.Color HeaderBorderColor`
- `public valuetype System.Drawing.Color HeaderButtonActiveColor`
- `public valuetype System.Drawing.Color HeaderButtonPassiveColor`
- `public valuetype System.Drawing.Color HeaderMenuForeColor`
- `public valuetype System.Drawing.Color HeaderTextForeColor`
- `public int Height`
- `public valuetype System.Drawing.Color HighColor1`
- `public valuetype System.Drawing.Color HighColor2`
- `public bool HorizontalGridVisible`
- `public bool IndicatorValueVisible`
- `public valuetype System.Drawing.Color IndicatorWindowBackColor1`
- `public valuetype System.Drawing.Color IndicatorWindowBackColor2`
- `public valuetype System.Drawing.Color IndicatorWindowBorderColor`
- `public valuetype System.Drawing.Color IndicatorWindowForeColor`
- `public bool KademeVisible`
- `public valuetype System.Drawing.Color LastLevelBackColor1`
- `public valuetype System.Drawing.Color LastLevelBackColor2`
- `public valuetype System.Drawing.Color LastLevelBorderColor`
- `public valuetype System.Drawing.Color LastLevelForeColor`
- `public bool LastLevelVisible`
- `public int Left`
- `public valuetype System.Drawing.Color LineBoxColor`
- `public bool LineChartBoxBool`
- `public int LogMode`
- `public valuetype System.Drawing.Color LowColor1`
- `public valuetype System.Drawing.Color LowColor2`
- `public valuetype System.Drawing.Color MeasurementBackColor1`
- `public valuetype System.Drawing.Color MeasurementBackColor2`
- `public valuetype System.Drawing.Color MeasurementBorderColor`

## Chart

Extends: `System.Object`

Methods:
- `public void Change(string)`
- `public void Default()`
- `public void Delete()`
- `public void DeleteAll()`
- `public System.Collections.Generic.List`1<string> GetNames()`
- `public void Init()`
- `public void Read()`
- `public void Save(byte[])`
- `public void Saveas(byte[])`
- `public void Write()`

Fields:
- `public string ActiveName`
- `public class Chart ActiveObject`
- `public System.Collections.Generic.List`1<string> AllList`
- `public valuetype System.Drawing.Color AverageColor`
- `public bool AverageVisible`
- `public System.Collections.Generic.List`1<string> BarList`
- `public float BarSpace`
- `public bool BarStyleLine`
- `public valuetype System.Drawing.Color BuyArrowColor`
- `public string ChartInProgress`
- `public int ClassVersion`
- `public valuetype System.Drawing.Color CurrentBarColor`
- `public valuetype System.Drawing.Color DataWindowBackColor1`
- `public valuetype System.Drawing.Color DataWindowBackColor2`
- `public valuetype System.Drawing.Color DataWindowBorderColor`
- `public valuetype System.Drawing.Color DataWindowForeColor`
- `public int DataWindowOpacity`
- `public bool DataWindowVisible`
- `public string DateStart`
- `public bool DerinlikVisible`
- `public string DividerBaseSymbol`
- `public int DividerMode`
- `public int DonguPeriyot`
- `public valuetype ideal.enDrawStyles DrawStyle`
- `public float EmptySpaceWidth`
- `public valuetype System.Drawing.Color FillColor1`
- `public valuetype System.Drawing.Color FillColor2`
- `public int FillOpacity`
- `public valuetype System.Drawing.Color FlatArrowColor`
- `public class System.Drawing.Font FontSkala`
- `public valuetype System.Drawing.Color FrameActiveColor`
- `public valuetype System.Drawing.Color FrameBackColor1`
- `public valuetype System.Drawing.Color FrameBackColor2`
- `public valuetype System.Drawing.Color FrameBorderColor`
- `public int FrameCount`
- `public valuetype System.Drawing.Color FrameForeColor`
- `public valuetype System.Drawing.Color GridlineColor`
- `public bool GrupMember`
- `public bool HBarVisible`
- `public bool HacimBool`
- `public int HacimDayCount`
- `public int HacimKurumId`
- `public valuetype System.Drawing.Color HbarBackColor1`
- `public valuetype System.Drawing.Color HbarBackColor2`
- `public valuetype System.Drawing.Color HbarBorderColor`
- `public valuetype System.Drawing.Color HbarForeColor`
- `public valuetype System.Drawing.Color HbarMidBackColor1`
- `public valuetype System.Drawing.Color HbarMidBackColor2`
- `public valuetype System.Drawing.Color HbarMidBorderColor`
- `public valuetype System.Drawing.Color HeaderBackColor1`
- `public valuetype System.Drawing.Color HeaderBackColor2`
- `public valuetype System.Drawing.Color HeaderBorderColor`
- `public valuetype System.Drawing.Color HeaderButtonActiveColor`
- `public valuetype System.Drawing.Color HeaderButtonPassiveColor`
- `public valuetype System.Drawing.Color HeaderMenuForeColor`
- `public valuetype System.Drawing.Color HeaderTextForeColor`
- `public int Height`
- `public valuetype System.Drawing.Color HighColor1`
- `public valuetype System.Drawing.Color HighColor2`
- `public bool HorizontalGridVisible`
- `public bool IndicatorValueVisible`
- `public valuetype System.Drawing.Color IndicatorWindowBackColor1`
- `public valuetype System.Drawing.Color IndicatorWindowBackColor2`
- `public valuetype System.Drawing.Color IndicatorWindowBorderColor`
- `public valuetype System.Drawing.Color IndicatorWindowForeColor`
- `public bool KademeVisible`
- `public valuetype System.Drawing.Color LastLevelBackColor1`
- `public valuetype System.Drawing.Color LastLevelBackColor2`
- `public valuetype System.Drawing.Color LastLevelBorderColor`
- `public valuetype System.Drawing.Color LastLevelForeColor`
- `public bool LastLevelVisible`
- `public int Left`
- `public valuetype System.Drawing.Color LineBoxColor`
- `public bool LineChartBoxBool`
- `public int LogMode`
- `public valuetype System.Drawing.Color LowColor1`
- `public valuetype System.Drawing.Color LowColor2`
- `public valuetype System.Drawing.Color MeasurementBackColor1`
- `public valuetype System.Drawing.Color MeasurementBackColor2`
- `public valuetype System.Drawing.Color MeasurementBorderColor`

## Chart

Extends: `System.Object`

Methods:
- `public void Change(string)`
- `public void Default()`
- `public void Delete()`
- `public void DeleteAll()`
- `public System.Collections.Generic.List`1<string> GetNames()`
- `public void Init()`
- `public void Read()`
- `public void Save(byte[])`
- `public void Saveas(byte[])`
- `public void Write()`

Fields:
- `public string ActiveName`
- `public class Chart ActiveObject`
- `public System.Collections.Generic.List`1<string> AllList`
- `public valuetype System.Drawing.Color AverageColor`
- `public bool AverageVisible`
- `public System.Collections.Generic.List`1<string> BarList`
- `public float BarSpace`
- `public bool BarStyleLine`
- `public valuetype System.Drawing.Color BuyArrowColor`
- `public string ChartInProgress`
- `public int ClassVersion`
- `public valuetype System.Drawing.Color CurrentBarColor`
- `public valuetype System.Drawing.Color DataWindowBackColor1`
- `public valuetype System.Drawing.Color DataWindowBackColor2`
- `public valuetype System.Drawing.Color DataWindowBorderColor`
- `public valuetype System.Drawing.Color DataWindowForeColor`
- `public int DataWindowOpacity`
- `public bool DataWindowVisible`
- `public string DateStart`
- `public bool DerinlikVisible`
- `public string DividerBaseSymbol`
- `public int DividerMode`
- `public int DonguPeriyot`
- `public valuetype ideal.enDrawStyles DrawStyle`
- `public float EmptySpaceWidth`
- `public valuetype System.Drawing.Color FillColor1`
- `public valuetype System.Drawing.Color FillColor2`
- `public int FillOpacity`
- `public valuetype System.Drawing.Color FlatArrowColor`
- `public class System.Drawing.Font FontSkala`
- `public valuetype System.Drawing.Color FrameActiveColor`
- `public valuetype System.Drawing.Color FrameBackColor1`
- `public valuetype System.Drawing.Color FrameBackColor2`
- `public valuetype System.Drawing.Color FrameBorderColor`
- `public int FrameCount`
- `public valuetype System.Drawing.Color FrameForeColor`
- `public valuetype System.Drawing.Color GridlineColor`
- `public bool GrupMember`
- `public bool HBarVisible`
- `public bool HacimBool`
- `public int HacimDayCount`
- `public int HacimKurumId`
- `public valuetype System.Drawing.Color HbarBackColor1`
- `public valuetype System.Drawing.Color HbarBackColor2`
- `public valuetype System.Drawing.Color HbarBorderColor`
- `public valuetype System.Drawing.Color HbarForeColor`
- `public valuetype System.Drawing.Color HbarMidBackColor1`
- `public valuetype System.Drawing.Color HbarMidBackColor2`
- `public valuetype System.Drawing.Color HbarMidBorderColor`
- `public valuetype System.Drawing.Color HeaderBackColor1`
- `public valuetype System.Drawing.Color HeaderBackColor2`
- `public valuetype System.Drawing.Color HeaderBorderColor`
- `public valuetype System.Drawing.Color HeaderButtonActiveColor`
- `public valuetype System.Drawing.Color HeaderButtonPassiveColor`
- `public valuetype System.Drawing.Color HeaderMenuForeColor`
- `public valuetype System.Drawing.Color HeaderTextForeColor`
- `public int Height`
- `public valuetype System.Drawing.Color HighColor1`
- `public valuetype System.Drawing.Color HighColor2`
- `public bool HorizontalGridVisible`
- `public bool IndicatorValueVisible`
- `public valuetype System.Drawing.Color IndicatorWindowBackColor1`
- `public valuetype System.Drawing.Color IndicatorWindowBackColor2`
- `public valuetype System.Drawing.Color IndicatorWindowBorderColor`
- `public valuetype System.Drawing.Color IndicatorWindowForeColor`
- `public bool KademeVisible`
- `public valuetype System.Drawing.Color LastLevelBackColor1`
- `public valuetype System.Drawing.Color LastLevelBackColor2`
- `public valuetype System.Drawing.Color LastLevelBorderColor`
- `public valuetype System.Drawing.Color LastLevelForeColor`
- `public bool LastLevelVisible`
- `public int Left`
- `public valuetype System.Drawing.Color LineBoxColor`
- `public bool LineChartBoxBool`
- `public int LogMode`
- `public valuetype System.Drawing.Color LowColor1`
- `public valuetype System.Drawing.Color LowColor2`
- `public valuetype System.Drawing.Color MeasurementBackColor1`
- `public valuetype System.Drawing.Color MeasurementBackColor2`
- `public valuetype System.Drawing.Color MeasurementBorderColor`

## ChartDataBasicHandler

Extends: `System.MulticastDelegate`

Methods:
- `public class System.IAsyncResult BeginInvoke(string; class System.AsyncCallback; object)`
- `public void EndInvoke(class System.IAsyncResult)`
- `public void Invoke(string)`

## ChartDataHandler

Extends: `System.MulticastDelegate`

Methods:
- `public class System.IAsyncResult BeginInvoke(string; class System.AsyncCallback; object)`
- `public void EndInvoke(class System.IAsyncResult)`
- `public void Invoke(string)`

## ChartEmirClass

Extends: `System.Object`


Fields:
- `public float CizgiSeviye`
- `public valuetype System.Decimal Fiyat`
- `public valuetype System.Drawing.Rectangle IptalRect`
- `public valuetype System.Decimal Miktar`
- `public string Yon`

## ChartRecord

Extends: `System.Object`

Methods:
- `public class ChartRecord ShallowCopy()`

Fields:
- `public float Close`
- `public float High`
- `public int Index`
- `public float Low`
- `public float Open`
- `public float Opint`
- `public string Period`
- `public float Size`
- `public string Symbol`
- `public float Vol`

## ChartResponse

Extends: `System.Object`


Properties:
- `class Getchartdata getchartdata`

## CriptoOrderRecord

Extends: `System.Object`


Properties:
- `string OrderNoString`

Fields:
- `public string AccountName`
- `public string AccountNo`
- `public string AmendPermit`
- `public valuetype System.Decimal Amount`
- `public double AmountShowing`
- `public double Balance`
- `public string BuySell`
- `public string CancelPermit`
- `public string ExecutionStatus`
- `public double GAmount`
- `public double GPrice`
- `public double GTotal`
- `public string ImprovePermit`
- `public string Kod`
- `public string LongAccountName`
- `public string Note`
- `public string OneSessionPermit`
- `public string OrderDate`
- `public string OrderEndDate`
- `public string OrderNo`
- `public string OrderPermit`
- `public string OrderRef`
- `public string OrderSessionNo`
- `public string OrderType`
- `public valuetype System.Decimal Price`
- `public string SatisTip`
- `public byte Selected`
- `public string Session`
- `public string SessionName`
- `public string Status`
- `public string StatusCode`
- `public valuetype System.Decimal StopPrice`
- `public string Symbol`
- `public double Total`
- `public string Validity`
- `public string ValorDate`
- `public string ZincirRef`

## CriptoPositionRecord

Extends: `System.Object`


Properties:
- `string Asset`
- `string Order`
- `double Profit`
- `double Total`

Fields:
- `public string AssetType`
- `public double Available`
- `public string BalanceType`
- `public double Blocked`
- `public double Bloke`
- `public string Coin`
- `public double Cost`
- `public string Description`
- `public double LastPrice`
- `public double Locked`
- `public double Lot`
- `public double ProfitX`
- `public double Request`
- `public double Sellable`
- `public string Symbol`
- `public int id`

## DepthImkb

Extends: `System.Object`

Methods:
- `public void ApplyAllForms(byte[])`
- `public void Change(string)`
- `public void Default()`
- `public void Delete()`
- `public void DeleteAll()`
- `public System.Collections.Generic.List`1<string> GetNames()`
- `public void Init()`
- `public void Save(byte[])`
- `public void Saveas(byte[])`

Fields:
- `public string ActiveName`
- `public class Depth ActiveObject`

## DepthVip

Extends: `System.Object`

Methods:
- `public void ApplyAllForms(byte[])`
- `public void Change(string)`
- `public void Default()`
- `public void Delete()`
- `public void DeleteAll()`
- `public System.Collections.Generic.List`1<string> GetNames()`
- `public void Init()`
- `public void Save(byte[])`
- `public void Saveas(byte[])`

Fields:
- `public string ActiveName`
- `public class Depth ActiveObject`

## EmirSira

Extends: `System.Object`

Methods:
- `public void ApplyAllForms(byte[])`
- `public void Change(string)`
- `public void Default()`
- `public void Delete()`
- `public void DeleteAll()`
- `public System.Collections.Generic.List`1<string> GetNames()`
- `public void Init()`
- `public void Save(byte[])`
- `public void Saveas(byte[])`

Fields:
- `public string ActiveName`
- `public class Depth ActiveObject`

## EmirSiraHandler

Extends: `System.MulticastDelegate`

Methods:
- `public class System.IAsyncResult BeginInvoke(string; string; class System.AsyncCallback; object)`
- `public void EndInvoke(class System.IAsyncResult)`
- `public void Invoke(string; string)`

## EquityCancelOrder

Extends: `System.Object`


Properties:
- `string clOrdId`
- `string orderId`
- `string token`
- `long tokenVersion`

## EquityListPricesteplist

Extends: `System.Object`


Properties:
- `float maxPx`
- `float minPx`
- `float tickSize`

## EquityOrder

Extends: `System.Object`


Properties:
- `object errorCode`
- `object errorDescription`
- `bool ok`
- `string transactionId`
- `class EquityOrderValue[] value`

## EquityOrderValue

Extends: `System.Object`


Properties:
- `string accountId`
- `double avgPrice`
- `bool cancelable`
- `bool chainOrder`
- `bool chainable`
- `string clOrdId`
- `string createdByName`
- `long createdDate`
- `string createdDateStr`
- `string description`
- `long endDate`
- `string endDateStr`
- `string instrumentId`
- `string instrumentSymbol`
- `string instrumentType`
- `long lastRealizeTime`
- `string lastRealizeTimeStr`
- `string lastUpdateByName`
- `long lastUpdateTime`
- `string lastUpdateTimeStr`
- `double maxFloor`
- `string orderId`
- `string orderReference`
- `string orderStatusDescEn`
- `string orderStatusDescTr`
- `string orderStatusId`
- `string orderTypeDescEn`
- `string orderTypeDescTr`
- `string orderTypeId`
- `string origClOrdId`
- `string parentOrderId`
- `string pendingClOrdId`
- `float pendingPrice`
- `float pendingQty`
- `string pendingTimeInForceId`
- `double price`
- `double qty`
- `double realizedAmt`
- `double realizedQty`
- `double remainingQty`
- `bool replaceable`
- `string sideDescEn`
- `string sideDescTr`
- `string sideId`
- `string timeInForceDesEn`
- `string timeInForceDescTr`
- `string timeInForceId`
- `object tradingSessionId`
- `bool triggerOrder`
- `double triggerPrice`
- `object triggerPriceDirectionDescEn`
- `object triggerPriceDirectionDescTr`
- `string triggerPriceDirectionId`
- `object triggerPriceTypeDescEn`
- `object triggerPriceTypeDescTr`
- `string triggerPriceTypeId`
- `string triggerSymbol`
- `object triggerTypeDescEn`
- `object triggerTypeDescTr`
- `string triggerTypeId`
- `bool triggerWorking`
- `long valueDate`
- `string valueDateStr`

## EquityPosition

Extends: `System.Object`


Properties:
- `object errorCode`
- `object errorDescription`
- `bool ok`
- `string transactionId`
- `class EquityValue[] value`

## EquityReplaceOrder

Extends: `System.Object`


Properties:
- `string clOrdId`
- `object errorCode`
- `object errorDescription`
- `bool ok`
- `string orderId`
- `float price`
- `int qty`
- `string timeInForceId`
- `string token`
- `long tokenVersion`
- `string transactionId`

## FonPosition

Extends: `System.Object`


Properties:
- `object errorCode`
- `object errorDescription`
- `bool ok`
- `string transactionId`
- `class FonPositionValue[] value`

## FonPositionRecord

Extends: `System.Object`


Fields:
- `public float Adet`
- `public float DegerlendirmeFiyati`
- `public string FonAdi`
- `public string FonKodu`
- `public float KarZarar`
- `public float Maliyet`
- `public double PortfoyOrani`
- `public float SatilabilirAdet`
- `public float VarlikTutari`

## FonPositionValue

Extends: `System.Object`


Properties:
- `string accountId`
- `int assetCoef`
- `float avgPrice`
- `float balanceT`
- `float balanceT1`
- `float balanceT2`
- `float balanceT3`
- `float currentAmount`
- `float currentAmountT2`
- `string depotCode`
- `string depotDescription`
- `float dpAmount`
- `string dpPosKey`
- `float dpProfitLoss`
- `string fundName`
- `long lastChange`
- `float lastPrice`
- `float profitLoss`
- `int secId`
- `int sellCoef`
- `string uniqueSymbol`
- `float useableQty`

## FutOptCancelOrder

Extends: `System.Object`


Properties:
- `string clOrdId`
- `string orderId`
- `string token`
- `long tokenVersion`

## FutOptOrder

Extends: `System.Object`


Properties:
- `object errorCode`
- `object errorDescription`
- `bool ok`
- `string transactionId`
- `class FutOptOrderValue[] value`

## FutOptOrderValue

Extends: `System.Object`


Properties:
- `string accountId`
- `float avgPrice`
- `bool cancelable`
- `bool chainOrder`
- `bool chainable`
- `string clOrdId`
- `string createdByName`
- `long createdDate`
- `string createdDateStr`
- `string description`
- `long endDate`
- `string endDateStr`
- `string instrumentId`
- `string instrumentSymbol`
- `string instrumentType`
- `long lastRealizeTime`
- `string lastRealizeTimeStr`
- `string lastUpdateByName`
- `long lastUpdateTime`
- `string lastUpdateTimeStr`
- `float maxFloor`
- `string orderId`
- `string orderReference`
- `string orderStatusDescEn`
- `string orderStatusDescTr`
- `string orderStatusId`
- `string orderTypeDescEn`
- `string orderTypeDescTr`
- `string orderTypeId`
- `string origClOrdId`
- `string parentOrderId`
- `string pendingClOrdId`
- `float pendingPrice`
- `float pendingQty`
- `string pendingTimeInForceId`
- `float price`
- `float qty`
- `float realizedAmt`
- `float realizedQty`
- `float remainingQty`
- `bool replaceable`
- `string sideDescEn`
- `string sideDescTr`
- `string sideId`
- `string timeInForceDesEn`
- `string timeInForceDescTr`
- `string timeInForceId`
- `string tradingSessionId`
- `bool triggerOrder`
- `float triggerPrice`
- `object triggerPriceDirectionDescEn`
- `object triggerPriceDirectionDescTr`
- `string triggerPriceDirectionId`
- `object triggerPriceTypeDescEn`
- `object triggerPriceTypeDescTr`
- `string triggerPriceTypeId`
- `string triggerSymbol`
- `object triggerTypeDescEn`
- `object triggerTypeDescTr`
- `string triggerTypeId`
- `bool triggerWorking`
- `long valueDate`
- `string valueDateStr`

## FutOptReplaceOrder

Extends: `System.Object`


Properties:
- `string clOrdId`
- `string endDate`
- `object errorCode`
- `object errorDescription`
- `bool ok`
- `string orderId`
- `double price`
- `double qty`
- `string timeInForceId`
- `string token`
- `long tokenVersion`
- `string transactionId`

## GetAccounts

Extends: `ideal.IdealMessage`


## GetAccountsResponse

Extends: `ideal.IdealMessage`


Properties:
- `string Account`

## Getchartdata

Extends: `System.Object`


Properties:
- `double close`
- `double high`
- `double low`
- `double open`
- `long ts`
- `double volume`

## GetOrder

Extends: `ideal.IdealMessage`


Properties:
- `int Id`

## GetOrders

Extends: `ideal.IdealMessage`


Properties:
- `string EndDate`
- `System.Nullable`1<int> Page`
- `System.Nullable`1<int> PageSize`
- `string StartDate`

## HacimRec1

Extends: `System.Object`


Fields:
- `public double BuyMiktar`
- `public double BuyMiktarY`
- `public int KurumId`
- `public double NetMiktar`
- `public double NetMiktarY`
- `public double SellMiktar`
- `public double SellMiktarY`
- `public double ToplamMiktar`
- `public double ToplamMiktarY`

## HesapClass

Extends: `System.Object`


Fields:
- `public valuetype System.Decimal Bakiye`
- `public System.Collections.Generic.List`1<class PozisyonClass> PozisyonList`
- `public valuetype System.Decimal Teminat`

## HesapListesi

Extends: `System.Object`


Properties:
- `class HesapListesiData data`
- `object message`
- `int statusCode`
- `bool success`

## HesapListesiData

Extends: `System.Object`


Properties:
- `string ADI`
- `int AltPazarRBF`
- `int OTOMATIK_ALIM_SATIM_SZL`
- `int ReturnValue`
- `string SOYADI`
- `int VERI_DAGITIM_OZEL_EKRAN`
- `int VirmanliSatisButonu`
- `string errorMessage`
- `int errorUniqueCode`

## HisseAnalizIndicatorClass

Extends: `System.Object`

Methods:
- `public System.Collections.Generic.List`1<class HisseAnalizIndicatorClass> CloneIndicator(System.Collections.Generic.List`1<class HisseAnalizIndicatorClass>)`

Fields:
- `public bool AlisBool`
- `public string Discription`
- `public string IndicatorName`
- `public bool KesisimBool`
- `public System.Collections.Generic.List`1<class ParameterHA> Parameters`
- `public bool SatisBool`

## HissePortfolioData

Extends: `System.Object`


Properties:
- `class List[] list`

## HissePortfolioReq

Extends: `System.Object`


Properties:
- `int anlikBakiye`

## HissePortfolioResponse

Extends: `System.Object`


Properties:
- `class HissePortfolioData data`
- `object message`
- `int statusCode`
- `bool success`

## ideal.AccountInfoModel

Extends: `System.Object`


Properties:
- `bool AuthenticatorTfaEnabled`
- `string Email`
- `bool EmailConfirmed`
- `bool EmailTfaEnabled`
- `string FirstName`
- `int GroupId`
- `string Gsm`
- `bool GsmConfirmed`
- `string IdentityNumber`
- `bool IsLocal`
- `bool KycEnabled`
- `string LastLoginIp`
- `valuetype System.DateTime LastLoginTime`
- `string LastName`
- `bool PhoneTfaEnabled`
- `string Status`
- `int UserId`

## ideal.AccountSpotWallet

Extends: `System.Object`


Properties:
- `string Available`
- `string Blocked`
- `double Request`
- `string Total`

Fields:
- `public string Asset`
- `public string Order`

## ideal.AccountType

Extends: `System.Enum`


Fields:
- `public valuetype ideal.AccountType AccountIsCarriedOnCustomerSideOfTheBooks`
- `public valuetype ideal.AccountType AccountIsCarriedOnNonCustomerSideOfBooks`
- `public valuetype ideal.AccountType AccountIsCarriedOnNonCustomerSideOfBooksAndIsCrossMargined`
- `public valuetype ideal.AccountType AccountIsHouseTraderAndIsCrossMargined`
- `public valuetype ideal.AccountType FloorTrader`
- `public valuetype ideal.AccountType HouseTrader`
- `public valuetype ideal.AccountType JointBackOfficeAccount`
- `public int value__`

## ideal.BasicTakas

Extends: `System.Object`

Methods:
- `public void ReadTakas()`

Fields:
- `public string KurumKod`
- `public double TakasVal`

## ideal.BmcEmirClass

Extends: `System.Object`


Fields:
- `public string Aciklama`
- `public valuetype System.Decimal Fiyat`
- `public valuetype System.Decimal KarZarar`
- `public valuetype System.Decimal Miktar`
- `public string Periyot`
- `public int SanalGercek`
- `public string Sembol`
- `public string Tarama`
- `public valuetype System.DateTime Tarih`
- `public int Tekrar`

## ideal.BmcPozisyonClass

Extends: `System.Object`


Fields:
- `public string Aciklama`
- `public valuetype System.Decimal AlisFiyat`
- `public valuetype System.Decimal AlisMiktar`
- `public valuetype System.DateTime AlisTarih`
- `public valuetype System.Decimal IzleyenFiyat`
- `public valuetype System.Decimal Miktar`
- `public string Periyot`
- `public valuetype System.Decimal Pozisyon`
- `public valuetype System.Decimal SatisFiyat`
- `public valuetype System.DateTime SatisTarih`
- `public string Sembol`
- `public bool SeviyeIzleyenAktif`
- `public valuetype System.Decimal SonFiyat`
- `public string Tarama`

## ideal.CancelOrderResponse

Extends: `System.Object`


Fields:
- `public string Code`
- `public int Id`
- `public bool Ok`

## ideal.CancelOrdersResult

Extends: `System.Object`


Properties:
- `string code`
- `int id`
- `bool ok`

## ideal.ChartControl

Extends: `System.Windows.Forms.UserControl`

Methods:
- `public void ActivateNextStock()`
- `public void ActivateSymbolEnrty(string; int)`
- `public void AddNewSymbol(int)`
- `public void ChangeBlackEdition()`
- `public void ChangeEurolineEdition()`
- `public void ChangeLinLog(int)`
- `public void ChangePeriod(string)`
- `public void ChangeSymbol(string)`
- `public void CheckCustomIndSaved(string)`
- `public void CopyIndicator()`
- `public void CopyToExcel()`
- `public void DeleteAllBars()`
- `public void DeleteBar()`
- `public void DownloadTakas()`
- `public void DrawAll(bool; bool; int)`
- `public void DrawIndicatorsOnly()`
- `public void EditBar()`
- `public void ExportToFile()`
- `public void FaizEkle()`
- `public void FaizSil()`
- `public void FiyatAlarmiEkle()`
- `public string GetActiveSymbolName()`
- `public int GetCurrentBarNo()`
- `public string GetDivideModeString()`
- `public string GetDrawStyleString()`
- `public bool GetFormasyon(string)`
- `public string GetPeriodString()`
- `public void GoBackward()`
- `public void GoForward()`
- `public void ImportFromFile()`
- `public void ImportFromFileMetaTrader()`
- `public void IndikatorAlarmiEkle()`
- `public void InsertElement(string)`
- `public void InsertFormasyon(string; bool)`
- `public void InsertIndicator()`
- `public void InsertIndicator(int)`
- `public void InsertIndicatorForSistemMulti()`
- `public void InsertIndicators(System.Collections.Generic.List`1<class ideal.cxIndicator>)`
- `public void InsertSymbol(string)`
- `public void LoopNextStock()`
- `public void LoopPreviousStock()`
- `public void ParalelTrendCiz()`
- `public void PasteImage()`
- `public void PasteIndicator()`
- `public void PrepareReplayData()`
- `public void ProcessBirimSeviyeMenu(int)`
- `public void ProcessBirimYontemMenu(int)`
- `public void ProcessKurumData(valuetype ideal.IslemStruct1)`
- `public void ProcessParamMenu(string)`
- `public void ProcessRealTimeData(string; bool)`
- `public void ReadData()`
- `public void ReadTakasDegisim()`
- `public void ReadTakasGun()`
- `public void RecalculateSistem()`
- `public void RemoveFrame(int)`
- `public void RemoveSymbol(int)`
- `public void RequestData()`
- `public void SanalModBellektenYapistir()`
- `public void SanalModFiyatTersYapistir()`
- `public void SanalModTersYapistir()`
- `public void SanalModVeriDegistir()`
- `public void SanalModVeriEkle()`
- `public void SanalModVeriSil()`
- `public void ScaleBackward()`
- `public void ScaleCompress()`
- `public void ScaleCompressToolbar()`
- `public void ScaleDown()`
- `public void ScaleEnd()`
- `public void ScaleExpand()`
- `public void ScaleForward()`
- `public void ScaleHome()`
- `public void ScaleHome2()`
- `public void ScaleLeft()`
- `public void ScalePageDown()`
- `public void ScalePageUp()`
- `public void ScaleRight()`
- `public void ScaleUp()`
- `public void SetDivider(int)`
- `public void SetLanguage()`
- `public void SetSize()`

Properties:
- `valuetype System.Decimal _Rkademe`

Fields:
- `public valuetype System.Drawing.Color AverageColor`
- `public bool AverageVisible`
- `public float BarSpace`
- `public bool BarStyleLine`
- `public valuetype System.Drawing.Color BuyArrowColor`
- `public class MessageDelegate ChartMessageEvent`
- `public valuetype System.Drawing.Color CurrentBarColor`
- `public int CurrentBarNo`
- `public valuetype System.Drawing.Color DataWindowBackColor1`
- `public valuetype System.Drawing.Color DataWindowBackColor2`
- `public valuetype System.Drawing.Color DataWindowBorderColor`
- `public valuetype System.Drawing.Color DataWindowForeColor`
- `public int DataWindowOpacity`
- `public bool DataWindowVisible`
- `public string DateStart`
- `public bool DerinlikVisible`
- `public string DividerBaseSymbol`
- `public int DividerMode`
- `public bool DrawEnabled`
- `public valuetype ideal.enDrawStyles DrawStyle`
- `public System.Collections.Generic.List`1<class ideal.cxElement> Elements`
- `public valuetype System.Decimal EmirPenceresiFiyat`
- `public float EmptySpaceWidth`
- `public valuetype System.Drawing.Color FillColor1`
- `public valuetype System.Drawing.Color FillColor2`
- `public int FillOpacity`
- `public valuetype System.Drawing.Color FlatArrowColor`
- `public class System.Drawing.Font FontSkala`
- `public valuetype System.Drawing.Color FrameActiveColor`
- `public valuetype System.Drawing.Color FrameBackColor1`
- `public valuetype System.Drawing.Color FrameBackColor2`
- `public valuetype System.Drawing.Color FrameBorderColor`
- `public int FrameCount`
- `public valuetype System.Drawing.Color FrameForeColor`
- `public System.Collections.Generic.List`1<class ideal.cxFrame> Frames`
- `public valuetype System.Drawing.Color GridlineColor`
- `public bool HBarVisible`
- `public bool HacimBool`
- `public int HacimDayCount`
- `public bool HacimDownloadBool`
- `public bool HacimKumulatifBool`
- `public int HacimKurumId`
- `public bool HacimKzBool`
- `public bool HacimMaliyetBool`
- `public class System.Threading.Thread Hacim_Thread`
- `public valuetype System.Drawing.Color HbarBackColor1`
- `public valuetype System.Drawing.Color HbarBackColor2`
- `public valuetype System.Drawing.Color HbarBorderColor`
- `public valuetype System.Drawing.Color HbarForeColor`
- `public valuetype System.Drawing.Color HbarMidBackColor1`
- `public valuetype System.Drawing.Color HbarMidBackColor2`
- `public valuetype System.Drawing.Color HbarMidBorderColor`
- `public valuetype System.Drawing.Color HighColor1`
- `public valuetype System.Drawing.Color HighColor2`
- `public bool HorizontalGridVisible`
- `public class ideal.cxIndicator IndicatorToCopy`
- `public bool IndicatorValueVisible`
- `public valuetype System.Drawing.Color IndicatorWindowBackColor1`
- `public valuetype System.Drawing.Color IndicatorWindowBackColor2`
- `public valuetype System.Drawing.Color IndicatorWindowBorderColor`
- `public valuetype System.Drawing.Color IndicatorWindowForeColor`
- `public bool KademeVisible`
- `public int KurumSeviye`
- `public int LastBarNo`
- `public valuetype System.Drawing.Color LastLevelBackColor1`
- `public valuetype System.Drawing.Color LastLevelBackColor2`
- `public valuetype System.Drawing.Color LastLevelBorderColor`
- `public valuetype System.Drawing.Color LastLevelForeColor`
- `public bool LastLevelVisible`
- `public valuetype System.Drawing.Color LineBoxColor`
- `public bool LineChartBoxBool`
- `public int LogMode`
- `public valuetype System.Drawing.Color LowColor1`
- `public valuetype System.Drawing.Color LowColor2`
- `public valuetype System.Drawing.Color MeasurementBackColor1`
- `public valuetype System.Drawing.Color MeasurementBackColor2`
- `public valuetype System.Drawing.Color MeasurementBorderColor`
- `public valuetype System.Drawing.Color MeasurementForeColor`
- `public bool MenuLineVisible`
- `public bool MultiMode`

## ideal.ChartItem

Extends: `System.Object`


Properties:
- `valuetype System.DateTime Date`
- `double Val`

## ideal.clsFixOrder

Extends: `System.Object`

Methods:
- `public void AddOrUpdateAccounts(class GetAccountsResponse)`
- `public void AddOrUpdateFixOrderDictionary(class OrderReport)`
- `public void AddOrUpdateFixOrderDictionary(class Error)`
- `public void AddOrUpdateFixOrderDictionary(valuetype System.Guid; class ideal.FixOrderData)`
- `public bool CancelOrder(class CancelReplaceOrder)`
- `public bool CancelOrders(System.Collections.Generic.List`1<class CancelOrder>)`
- `public bool CancelOrders(System.Collections.Generic.List`1<string>)`
- `public void ClearAccounts()`
- `public void ClearFixOrderDictionary()`
- `public void EmirGonderTest()`
- `public bool GetAccounts()`
- `public class ideal.cxBasic GetCxBasic(string)`
- `public class ideal.FixOrderData GetFixOrderData(string)`
- `public class ideal.FixOrderData GetFixOrderData(valuetype System.Guid)`
- `public bool GetOrders(class GetOrders)`
- `public void GetOrdersToday()`
- `public valuetype ideal.Piyasa GetPiyasa(string)`
- `public bool LoginCheck()`
- `public void LoginFixOrder(string; string)`
- `public bool SendData(string; bool)`
- `public void SendHB()`
- `public bool SendOrder(class NewOrder)`
- `public bool UpdateOrders(System.Collections.Generic.List`1<class CancelReplaceOrder>)`
- `public bool UpdateOrders(System.Collections.Generic.List`1<string>; double)`
- `public string toFixOrderDateTime(valuetype System.DateTime)`
- `public valuetype System.DateTime toFixOrderDateTime(string)`
- `public string toFixOrderGuid(valuetype System.Guid)`

Properties:
- `System.Collections.Generic.Dictionary`2<valuetype System.Guid, class ideal.FixOrderData> GetOrderDictionary`
- `valuetype ideal.ConnectionState State`

Fields:
- `public string BeginString`
- `public string BeginString_IDEALPAY`
- `public string BeginString_IDEALVIOP`
- `public valuetype System.DateTime ConnectionTime`
- `public string DateTimeFormat`
- `public valuetype System.DateTime LoginTime`
- `public string Sender`
- `public class System.Type _Error`
- `public class System.Type _GetAccountsResponse`
- `public class System.Type _Heartbeat`
- `public class System.Type _LoginResponse`
- `public class System.Type _LogoutResponse`
- `public class System.Type _OrderReport`
- `public class System.Globalization.CultureInfo default_culture_info`
- `public System.Collections.Generic.List`1<class ideal.FixRouterAccountData> fixRouterAccountDatas`

## ideal.cxBar

Extends: `System.Object`

Methods:
- `public float AveragePrice()`
- `public int GetIndexFromDate(string)`
- `public float GetRenkoBrickSize(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public System.Collections.Generic.List`1<class ideal.cxBar> GetRenkoList(System.Collections.Generic.List`1<class ideal.cxBar>; float)`
- `public string GetStringFromDate(string)`
- `public System.Collections.Generic.List`1<float> PeriodAdjust(System.Collections.Generic.List`1<class ideal.cxBar>; System.Collections.Generic.List`1<class ideal.cxBar>; System.Collections.Generic.List`1<float>)`
- `public void Read(string; string; System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void ReadBarCount(string; string; System.Collections.Generic.List`1<class ideal.cxBar>; int)`
- `public void ReadData(string; string; System.Collections.Generic.List`1<class ideal.cxBar>; int)`
- `public void ReadRbar(string; string; System.Collections.Generic.List`1<class ideal.cxBar>; valuetype System.Decimal)`
- `public float TypicalPrice()`

Fields:
- `public float Close`
- `public valuetype System.DateTime Date`
- `public float DividerVal`
- `public float High`
- `public float Low`
- `public float Open`
- `public float Opint`
- `public float Size`
- `public bool Split`
- `public float Vol`

## ideal.cxBistMarket

Extends: `System.Object`

Methods:
- `public void ReadFile()`

Fields:
- `public System.Collections.Generic.Dictionary`2<string, string> Dictionary`

## ideal.cxBistSeri

Extends: `System.Object`

Methods:
- `public void ReadFile()`

Fields:
- `public System.Collections.Generic.Dictionary`2<string, string> Dictionary`

## ideal.cxBrutTakas

Extends: `System.Object`

Methods:
- `public void ReadFile()`

Fields:
- `public string Aciklama`
- `public string Date1`
- `public string Date2`
- `public System.Collections.Generic.Dictionary`2<string, class ideal.cxBrutTakas> Dictionary`
- `public string Symbol`
- `public string Uyari`

## ideal.cxChartData

Extends: `System.Object`

Methods:
- `public double CalculateVolatility(string; int)`
- `public int ConvertDateToIndex(valuetype System.DateTime; string)`
- `public valuetype System.DateTime ConvertIndexToDate(int; string)`
- `public string ConvertIndexToString(int; string)`
- `public valuetype System.DateTime ConvertStringToDate(string)`
- `public int ConvertStringToIndex(string; string)`
- `public string GetChartPeriodName(string)`
- `public float GetHistoricClosingPrice(string; int)`
- `public class ChartRecord GetHistoricDataRec(string; int; string)`
- `public void InsertBarsToChartFile(System.Collections.Generic.List`1<class DownloadRecord>)`
- `public void InsertDownloadedBarsToChartFile()`
- `public void ReadFromFile(string; string)`
- `public void RemoveBarsFromChartFile(System.Collections.Generic.List`1<class DownloadRecord>)`
- `public void RepairChartFile(string; string; int)`
- `public void RepairChartFileDate(string; string; valuetype System.DateTime)`
- `public void SplitEndeksBirim(string; string; int; valuetype System.Decimal)`
- `public void SplitEndeksChart(string; string; int; valuetype System.Decimal)`
- `public void SplitIndexAllPeriods(string; valuetype System.Decimal)`
- `public void SplitStock(string; string; int; float)`
- `public void SplitStock5S(string; int; float)`
- `public void SplitStockAllPeriods(string; string; float)`
- `public void UpdateChartBuffers(class ideal.cxBasic)`
- `public void UpdateChartGunBuffer(class ideal.cxBasic)`
- `public void UpdateNewTickBuffer(string; float; float; int; int; int)`
- `public void UpdateTickBuffer(string)`
- `public void WriteBufferToChartFile(string; string)`
- `public void WriteBufferToTickFile(string)`

Fields:
- `public System.Collections.Generic.Dictionary`2<string, int> ChartDownloadTime`
- `public System.Collections.Generic.List`1<string> DirectoryList`
- `public bool DownloadAllChartBool`
- `public bool DownloadWritingBool`
- `public class ChartRecord[] FileImage`

## ideal.cxChartLoop

Extends: `System.ValueType`

Methods:
- `public void Read()`
- `public void Sort()`
- `public void Write()`

Fields:
- `public System.Collections.Generic.List`1<string> List`

## ideal.cxEmirSira

Extends: `System.Object`

Methods:
- `public void ClearData()`
- `public class ideal.cxEmirSira GetItem(string)`

Fields:
- `public System.Collections.Generic.List`1<class Line> Asks`
- `public System.Collections.Generic.List`1<class Line> Bids`
- `public string DecFormat`
- `public int DecPoint`
- `public modreq ET_0x82 Dictionary`
- `public string MarketCode`
- `public string Symbol`

## ideal.cxImkbIndex

Extends: `System.Object`

Methods:
- `public void ReadIndices()`
- `public void ReadStocks()`

Fields:
- `public System.Collections.Generic.Dictionary`2<string, string> IndexDictionary`
- `public System.Collections.Generic.Dictionary`2<string, string> StockDictionary`

## ideal.cxImkbIndexWeight

Extends: `System.Object`

Methods:
- `public void Deserialize()`
- `public float getSymbolIndexWeight(string; string)`

Fields:
- `public System.Collections.Concurrent.ConcurrentDictionary`2<string, System.Collections.Generic.List`1<string>> EndeksSembolleriDictionary`
- `public System.Collections.Generic.Dictionary`2<string, class SymbolIW> StockDictionary`

## ideal.cxImkbOrder

Extends: `System.Object`

Methods:
- `public System.Collections.Generic.List`1<class DistributionRecord> GetDistributionList(int; valuetype System.DateTime; string; string)`

## ideal.cxImkbTedbir

Extends: `System.Object`

Methods:
- `public void Deserialize()`

Properties:
- `string JsonStr`

Fields:
- `public class TedbirClass TedbirObject`
- `public string filename`

## ideal.cxIndicator

Extends: `System.Object`

Methods:
- `public void Calculate(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public System.Collections.Generic.List`1<float> CalculateATR(System.Collections.Generic.List`1<float>; float)`
- `public void CalculateAccumulationDistribution(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateAccumulationSwingIndex(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateAlligator(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateAroonOscillator(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateAroonUpDown(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateAverageDirectionalIndex(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateAverageDirectionalIndex(System.Collections.Generic.List`1<float>)`
- `public void CalculateAverageDirectionalIndexE(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateAverageDirectionalRating(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateAverageTrueRange(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateAwesomeOscillator(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateBilancoFK(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateBilancoNetKar(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateBilancoOdenmisSerm(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateBilancoOzSerm(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateBilancoPD(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateBilancoPDDD(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateBollingerBands(System.Collections.Generic.List`1<float>)`
- `public void CalculateBollingerBandsStatic(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateBollingerWidth(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateChaikinMoneyFlow(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateChaikinOscillator(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateChaikinVolatility(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateChandeMomentum(System.Collections.Generic.List`1<float>)`
- `public void CalculateCommodityChannelIndex(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateCommoditySelectionIndex(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateDUBIX(System.Collections.Generic.List`1<float>)`
- `public void CalculateDema(System.Collections.Generic.List`1<float>)`
- `public void CalculateDemandIndex(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateDetrendedPriceOscillator(System.Collections.Generic.List`1<float>)`
- `public void CalculateDigerSymbol(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateDirectionalIndicator(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateDirectionalMovement(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateDoubleMA(System.Collections.Generic.List`1<float>; System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateEaseOfMovement(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateEhlersDistCoefFilter(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateEhlersFilter(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateElliotWaveOscillator(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateEnvelope(System.Collections.Generic.List`1<float>)`
- `public void CalculateEnvelopeStatic(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateFaizMb(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateFibonacciBands(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateFisherTransform(System.Collections.Generic.List`1<float>)`
- `public void CalculateForecastOscillator(System.Collections.Generic.List`1<float>)`
- `public void CalculateFxSniper(System.Collections.Generic.List`1<float>)`
- `public System.Collections.Generic.List`1<float> CalculateHHV(System.Collections.Generic.List`1<float>; float)`
- `public void CalculateHighLowBox(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateHighLowRange(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateHullMA(System.Collections.Generic.List`1<float>)`
- `public void CalculateIchimoku(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateIntradayMomentumIndex(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateKairi(System.Collections.Generic.List`1<float>)`
- `public void CalculateKeltnerChannel(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateKlingerOscillator(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public System.Collections.Generic.List`1<float> CalculateLLV(System.Collections.Generic.List`1<float>; float)`
- `public void CalculateLinearRegression(System.Collections.Generic.List`1<float>)`
- `public void CalculateLinearRegressionIndicator(System.Collections.Generic.List`1<float>)`
- `public void CalculateLinearRegressionIntercept(System.Collections.Generic.List`1<float>)`
- `public void CalculateLinearRegressionSlope(System.Collections.Generic.List`1<float>)`
- `public void CalculateLot(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public System.Collections.Generic.List`1<float> CalculateMA(System.Collections.Generic.List`1<float>; valuetype ideal.enAvrMethods; float)`
- `public void CalculateMMA(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateMacd(System.Collections.Generic.List`1<float>)`
- `public void CalculateMacdHistogram(System.Collections.Generic.List`1<float>)`
- `public void CalculateMassIndex(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateMomentum(System.Collections.Generic.List`1<float>)`
- `public void CalculateMoneyFlowIndex(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateMovingAverage(System.Collections.Generic.List`1<float>)`
- `public void CalculateMovingAverageStatic(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateNegativeVolumeIndex(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateNonlinearEhlersFilter(System.Collections.Generic.List`1<class ideal.cxBar>; float)`
- `public void CalculateOnBalanceVolume(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateOpenInterest(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculatePGC(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculatePHPL01(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateParabolicSAR(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public void CalculateParabolicSAR(System.Collections.Generic.List`1<float>)`
- `public void CalculatePerformance(System.Collections.Generic.List`1<class ideal.cxBar>)`

Properties:
- `int SpecialDrawing`

Fields:
- `public valuetype System.Drawing.Color AvrColor`
- `public valuetype System.Drawing.Color AvrColor2`
- `public valuetype System.Drawing.Color AvrColor3`
- `public valuetype ideal.enAvrMethods AvrMethod`
- `public valuetype ideal.enAvrMethods AvrMethod2`
- `public valuetype ideal.enAvrMethods AvrMethod3`
- `public int AvrPeriod`
- `public int AvrPeriod2`
- `public int AvrPeriod3`
- `public bool AvrShow`
- `public string ChartPeriod`
- `public int ClassVersion`
- `public valuetype System.Drawing.Drawing2D.DashStyle Dash`
- `public class DataSeries[] Data`
- `public string DecimalFormat`
- `public bool Deleted`
- `public bool Display`
- `public bool DoubleColorActive`
- `public class ideal.cxIndicator EditedIndicator`
- `public valuetype System.Drawing.Color FillColor1`
- `public valuetype System.Drawing.Color FillColor2`
- `public float FillLevel`
- `public int FillOpacity`
- `public bool Filled`
- `public int FirstBarOnDisplay`
- `public class System.Drawing.Font Font`
- `public valuetype System.Drawing.Color ForeColor`
- `public int HorizontalShift`
- `public System.Collections.Generic.List`1<float> Ichimoku3`
- `public System.Collections.Generic.List`1<float> Ichimoku4`
- `public System.Collections.Generic.Dictionary`2<string, string> IndicatorDefaults`
- `public valuetype ideal.exIndicatorTypes IndicatorType`
- `public valuetype ideal.enPriceFields InputType`
- `public System.Collections.Generic.Dictionary`2<string, class ideal.cxIndicator> Items`
- `public valuetype System.Decimal[] KurumHacim`
- `public string[] KurumKod`
- `public valuetype System.Decimal[] KurumLot`
- `public int KurumYontem`
- `public valuetype System.Drawing.Color[] LineColor`
- `public valuetype System.Drawing.Drawing2D.DashStyle[] LineDash`
- `public float[] LineValue`
- `public bool[] LineVisible`
- `public int[] LineWidth`
- `public string LongName`
- `public valuetype ideal.enPriceFields[] MultiMaFiyatTip`
- `public valuetype ideal.enAvrMethods[] MultiMaMethod`
- `public float[] MultiMaPeriyot`
- `public string[] OtoKurum`
- `public float Param1`
- `public float Param2`
- `public float Param3`
- `public float Param4`
- `public float Param5`
- `public string PrevCalculateSembol`
- `public int PrevCalculateTime`
- `public int Region`
- `public string SelectedItemName`
- `public string ShortName`
- `public bool SonDegerHesaplaBool`
- `public string StaticPeriod`
- `public string StaticPeriod1`
- `public string StaticPeriod2`
- `public string StaticSymbol`
- `public string SymbolAndBroker`
- `public string TakasCode`
- `public System.Collections.Generic.Dictionary`2<string, double> TakasDictionary`
- `public int Tickness`
- `public string VolumeSymbol`
- `public System.Collections.Generic.List`1<float> Volumes`

## ideal.cxPortfolio

Extends: `System.Object`

Methods:
- `public void AddPortfoy(string; string)`
- `public float CalculatePriceStep(string)`
- `public bool CheckLogin(string)`
- `public bool CheckZincirYetki(string)`
- `public void Deserialize()`
- `public class AccountRecord GetAccount(string)`
- `public System.Collections.Generic.List`1<string> GetAccountNoList(string)`
- `public string GetActiveAccountNo(string)`
- `public class Portfoy GetActivePortfoy()`
- `public string GetGeneksSoftOTP(class AccountRecord)`
- `public valuetype System.DateTime GetGtpValorTarih()`
- `public string GetImkbCurrentSessionFromAccountName(string)`
- `public double GetImkbLimit(string; string)`
- `public double GetImkbOverall(string; string)`
- `public string GetKurumMetodType(string; string)`
- `public string GetKurumNameKisaForOTP(class AccountRecord)`
- `public string GetKurumUnvan(string)`
- `public bool GetOTPCheckBool(class AccountRecord)`
- `public class Portfoy GetPortfoy(string; string)`
- `public System.Collections.Generic.List`1<valuetype System.Decimal> GetPriceSteps(string)`
- `public double GetSymbolDefaultLot(string)`
- `public string GetTestData(string)`
- `public double GetViopMultiplier(string)`
- `public double GetViopMultiplierForPozSize(string)`
- `public void InsertBuySellToAlgo(class BuySellRecord)`
- `public void InsertBuySellToList(class BuySellRecord)`
- `public void InsertEvent(string)`
- `public string PeperSalt_Hash(string)`
- `public void ReadBrokers()`
- `public void ReadFileSifreler()`
- `public void RemovePortfoy(string; string)`
- `public void Serialize()`

Fields:
- `public string BackOfficeBIST_IP`
- `public string BackOfficeVIOP_IP`
- `public class BinanceFuture BinanceFutureClass`
- `public System.Collections.Generic.Dictionary`2<string, valuetype System.Decimal> BinanceHariciSembolFiyatlar`
- `public class Binance.Net.BinanceClient BinanceRestClient`
- `public System.Collections.Generic.Dictionary`2<string, class BrokerRecord> BrokerDictionary`
- `public string BrokerrName`
- `public class BuySellRecord BuySellItem`
- `public class System.Net.CookieContainer CookieMain`
- `public System.Collections.Concurrent.ConcurrentQueue`1<string> EventQueue`
- `public System.Collections.Concurrent.ConcurrentQueue`1<string> EventQueueKEP`
- `public System.Collections.Generic.Dictionary`2<string, string> FileSifreDict`
- `public System.Collections.Generic.List`1<string> GTPSembolKurumList`
- `public class IcrypexFuture IcrypexFutureClass`
- `public class ImkbOrderRecord ImkbOrder`
- `public bool ImkbOrderFilterAllStocks`
- `public bool ImkbOrderFilterBuy`
- `public string ImkbOrderFilterLot`
- `public string ImkbOrderFilterPrice`
- `public bool ImkbOrderFilterSell`
- `public byte ImkbOrderFilterStatus`
- `public string ImkbOrderFilterStock`
- `public bool ImkbWaitingAllStockFilter`
- `public byte ImkbWaitingBuySellFilter`
- `public byte ImkbWaitingDisplayFilter`
- `public string ImkbWaitingStockFilter`
- `public valuetype System.DateTime LoginTime`
- `public System.Collections.Generic.List`1<string> MessageList`
- `public System.Collections.Generic.Dictionary`2<string, class Portfoy> PortfoyDictionary`
- `public double PositionCloseMoney`
- `public double PositionCloseRatio`
- `public string SelectedTab`
- `public class SettingRecord Setting`
- `public System.Collections.Generic.List`1<System.Collections.Generic.List`1<valuetype System.Decimal>> SistemMultiCashList`
- `public bool SistemMultiGridVisible`
- `public int SistemMultiNo`
- `public System.Collections.Generic.List`1<System.Collections.Generic.List`1<string>> SistemMultiYonList`
- `public class VipOrderRecord VipOrder`
- `public string VipOrderExpiryFilter`
- `public string VipOrderSymbolFilter`
- `public string localIp`
- `public string remoteIP`

## ideal.cxRobotLisansController

Extends: `System.Object`

Methods:
- `public bool LisansDurum(bool)`
- `public void RobotLisansKontrol(string; int; int)`
- `public bool RobotLisansKontrol(string)`
- `public void ShowGKKULMessage()`

## ideal.cxSiraOrderRec

Extends: `System.Object`


Fields:
- `public int ID`
- `public float LeftAmount`
- `public float Lot`
- `public string Time`

## ideal.cxSistem

Extends: `System.Object`

Methods:
- `public System.Collections.Generic.List`1<float> ADR(object)`
- `public System.Collections.Generic.List`1<float> ADR(System.Collections.Generic.List`1<class ideal.cxBar>; object)`
- `public System.Collections.Generic.List`1<float> ADX(object)`
- `public System.Collections.Generic.List`1<float> ADX(System.Collections.Generic.List`1<class ideal.cxBar>; object)`
- `public System.Collections.Generic.List`1<float> ADX(System.Collections.Generic.List`1<float>; object)`
- `public System.Collections.Generic.List`1<float> ADXE(object)`
- `public System.Collections.Generic.List`1<float> ADXE(System.Collections.Generic.List`1<class ideal.cxBar>; object)`
- `public class ideal.PGCKurumMaliyet AKDHesapla(string; int)`
- `public System.Collections.Generic.List`1<float> AccumulationDistribution()`
- `public System.Collections.Generic.List`1<float> AccumulationDistribution(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public System.Collections.Generic.List`1<float> AccumulationSwingIndex(object)`
- `public System.Collections.Generic.List`1<float> AccumulationSwingIndex(System.Collections.Generic.List`1<class ideal.cxBar>; object)`
- `public float AlisFiyat(string)`
- `public float AlisLot(string)`
- `public System.Collections.Generic.List`1<float> Alligator1()`
- `public System.Collections.Generic.List`1<float> Alligator1(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public System.Collections.Generic.List`1<float> Alligator2()`
- `public System.Collections.Generic.List`1<float> Alligator2(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public System.Collections.Generic.List`1<float> Alligator3()`
- `public System.Collections.Generic.List`1<float> Alligator3(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public System.Collections.Generic.List`1<float> AroonDown(object)`
- `public System.Collections.Generic.List`1<float> AroonDown(System.Collections.Generic.List`1<class ideal.cxBar>; object)`
- `public System.Collections.Generic.List`1<float> AroonOsc(object)`
- `public System.Collections.Generic.List`1<float> AroonOsc(System.Collections.Generic.List`1<class ideal.cxBar>; object)`
- `public System.Collections.Generic.List`1<float> AroonUp(object)`
- `public System.Collections.Generic.List`1<float> AroonUp(System.Collections.Generic.List`1<class ideal.cxBar>; object)`
- `public bool AsagiKestiyse(System.Collections.Generic.List`1<float>; System.Collections.Generic.List`1<float>)`
- `public bool AsagiKestiyse(System.Collections.Generic.List`1<float>; object)`
- `public System.Collections.Generic.List`1<float> AverageTrueRange(object)`
- `public System.Collections.Generic.List`1<float> AverageTrueRange(System.Collections.Generic.List`1<class ideal.cxBar>; object)`
- `public System.Collections.Generic.List`1<float> AverageTrueRange(System.Collections.Generic.List`1<float>; object)`
- `public System.Collections.Generic.List`1<float> AwesomeOsc(object; object)`
- `public System.Collections.Generic.List`1<float> AwesomeOsc(System.Collections.Generic.List`1<class ideal.cxBar>; object; object)`
- `public void BarCiz(int; int; System.Collections.Generic.List`1<float>; System.Collections.Generic.List`1<float>; System.Collections.Generic.List`1<float>; System.Collections.Generic.List`1<float>; valuetype System.Drawing.Color; valuetype System.Drawing.Color)`
- `public void BarRengi(int; valuetype System.Drawing.Color; int; int)`
- `public System.Collections.Generic.List`1<float> BilancoFK(string; System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public System.Collections.Generic.List`1<float> BilancoFK()`
- `public System.Collections.Generic.List`1<float> BilancoNetKar(string; System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public System.Collections.Generic.List`1<float> BilancoNetKar()`
- `public System.Collections.Generic.List`1<float> BilancoOdenmisSerm(string; System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public System.Collections.Generic.List`1<float> BilancoOdenmisSerm()`
- `public System.Collections.Generic.List`1<float> BilancoOzSerm(string; System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public System.Collections.Generic.List`1<float> BilancoOzSerm()`
- `public System.Collections.Generic.List`1<float> BilancoPD(string; System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public System.Collections.Generic.List`1<float> BilancoPD()`
- `public System.Collections.Generic.List`1<float> BilancoPDDD(string; System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public System.Collections.Generic.List`1<float> BilancoPDDD()`
- `public class BistRobotHesapClass BistHesapOku()`
- `public System.Collections.Generic.List`1<float> BollingerDown(object; object; object)`
- `public System.Collections.Generic.List`1<float> BollingerDown(System.Collections.Generic.List`1<class ideal.cxBar>; object; object; object)`
- `public System.Collections.Generic.List`1<float> BollingerDown(System.Collections.Generic.List`1<float>; object; object; object)`
- `public System.Collections.Generic.List`1<float> BollingerMid(object; object; object)`
- `public System.Collections.Generic.List`1<float> BollingerMid(System.Collections.Generic.List`1<class ideal.cxBar>; object; object; object)`
- `public System.Collections.Generic.List`1<float> BollingerMid(System.Collections.Generic.List`1<float>; object; object; object)`
- `public System.Collections.Generic.List`1<float> BollingerUp(object; object; object)`
- `public System.Collections.Generic.List`1<float> BollingerUp(System.Collections.Generic.List`1<class ideal.cxBar>; object; object; object)`
- `public System.Collections.Generic.List`1<float> BollingerUp(System.Collections.Generic.List`1<float>; object; object; object)`
- `public System.Collections.Generic.List`1<float> BollingerWidth(object; object)`
- `public System.Collections.Generic.List`1<float> BollingerWidth(System.Collections.Generic.List`1<class ideal.cxBar>; object; object)`
- `public float CalculateMaxDD(System.Collections.Generic.List`1<float>)`
- `public void CalculateMaxDdDate(System.Collections.Generic.List`1<float>)`
- `public System.Collections.Generic.List`1<float> ChaikinMoneyFlow(object)`
- `public System.Collections.Generic.List`1<float> ChaikinMoneyFlow(System.Collections.Generic.List`1<class ideal.cxBar>; object)`
- `public System.Collections.Generic.List`1<float> ChaikinOsc()`
- `public System.Collections.Generic.List`1<float> ChaikinOsc(System.Collections.Generic.List`1<class ideal.cxBar>)`
- `public System.Collections.Generic.List`1<float> ChaikinVolatility(object; object)`
- `public System.Collections.Generic.List`1<float> ChaikinVolatility(System.Collections.Generic.List`1<class ideal.cxBar>; object; object)`
- `public System.Collections.Generic.List`1<float> ChandeMomentum(object)`
- `public System.Collections.Generic.List`1<float> ChandeMomentum(System.Collections.Generic.List`1<class ideal.cxBar>; object)`
- `public System.Collections.Generic.List`1<float> ChandeMomentum(System.Collections.Generic.List`1<float>; object)`
- `public void CizgiCiz(int; int; object; int; object; valuetype System.Drawing.Color; int; int)`
- `public System.Collections.Generic.List`1<float> CommodityChannelIndex(object)`
- `public System.Collections.Generic.List`1<float> CommodityChannelIndex(System.Collections.Generic.List`1<class ideal.cxBar>; object)`
- `public void CompileLib()`
- `public void CompileSistem(string)`
- `public valuetype ideal.enAvrMethods ConvertAverageMethod(string)`
- `public System.Collections.Generic.List`1<float> DEMA(object)`
- `public System.Collections.Generic.List`1<float> DEMA(System.Collections.Generic.List`1<class ideal.cxBar>; object)`
- `public System.Collections.Generic.List`1<float> DEMA(System.Collections.Generic.List`1<float>; object)`
- `public System.Collections.Generic.List`1<float> DUBIX(object)`

Properties:
- `string AktifDolarKontrat`
- `string AktifEuroKontrat`
- `string AktifViopKontrat`
- `bool BaglantiVar`
- `bool HaftaSonu`
- `string Saat`
- `string Tarih`

Fields:
- `public string AlgoAciklama`
- `public string AlgoAction`
- `public string AlgoIslem`
- `public int AlgoListPos`
- `public bool AlgoRunning`
- `public bool BMC`
- `public System.Collections.Generic.List`1<System.Collections.Generic.List`1<class ideal.cxBar>> BarDataList`
- `public System.Collections.Generic.List`1<valuetype System.Drawing.Color> BarDusenRenkList`
- `public System.Collections.Generic.List`1<int> BarPanelList`
- `public int BarSayisi`
- `public System.Collections.Generic.List`1<int> BarTipList`
- `public System.Collections.Generic.List`1<valuetype System.Drawing.Color> BarYukselenRenkList`
- `public valuetype System.DateTime BistHesapTime`
- `public bool CanliKarAlBool`
- `public bool CanliPozKapatBool`
- `public bool CanliStopBool`
- `public int CiftTip`
- `public System.Collections.Generic.List`1<class ideal.cxSistemLineRecord> Cizgiler`
- `public int ClassVersion`
- `public byte Compiler`
- `public string CumaKapatSaat`
- `public bool CumaKapat_Bool`
- `public int DecimalPoint`
- `public class ideal.cxDepth DerinlikVeri`
- `public System.Collections.Generic.Dictionary`2<string, class ideal.cxSistem> Dictionary`
- `public System.Collections.Generic.List`1<class ideal.SistemDolguClass> DolguList`
- `public System.Collections.Generic.Dictionary`2<string, object> DynamicDictionary`
- `public string EditDayanakSistem`
- `public string EditYontem`
- `public string EmirAcigaSatisKapama`
- `public string EmirAciklama`
- `public byte EmirAksamSeansi`
- `public string EmirAltHesap`
- `public string EmirBitisTarih`
- `public valuetype System.DateTime EmirEndDate`
- `public string EmirFiyatTipi`
- `public object EmirFiyati`
- `public bool EmirGenelSatis`
- `public string EmirHesapAdi`
- `public string EmirIslem`
- `public double EmirMiktari`
- `public bool EmirSartBool`
- `public object EmirSartFiyat`
- `public string EmirSartSembol`
- `public string EmirSartTipi`
- `public string EmirSatisTipi`
- `public string EmirSembol`
- `public object EmirStop`
- `public string EmirSuresi`
- `public valuetype System.Decimal EmirTeyidFiyat`
- `public int EmirTeyidMiktar`
- `public string EmirTeyidSembol`
- `public string EmirTipi`
- `public string ErrorCode`
- `public string ErrorMessage`
- `public bool FSYSTEM`
- `public valuetype System.Decimal Feedback01_Param1`
- `public valuetype System.Decimal Feedback01_Param2`
- `public valuetype System.Decimal Feedback01_Param3`
- `public valuetype System.Decimal Feedback01_Param4`
- `public valuetype System.Decimal Feedback02_Param1`
- `public valuetype System.Decimal Feedback02_Param2`
- `public valuetype System.Decimal Feedback02_Param3`
- `public valuetype System.Decimal Feedback03_Param1`
- `public valuetype System.Decimal Feedback03_Param2`
- `public valuetype System.Decimal Feedback03_Param3`
- `public valuetype System.Decimal Feedback04_Param1`
- `public valuetype System.Decimal Feedback04_Param2`
- `public valuetype System.Decimal Feedback05_Param1`
- `public valuetype System.Decimal Feedback05_Param2`
- `public valuetype System.Decimal Feedback05_Param3`
- `public valuetype System.Decimal Feedback06_Param1`
- `public valuetype System.Decimal Feedback06_Param2`
- `public valuetype System.Decimal Feedback06_Param3`
- `public valuetype System.Decimal Feedback07_Param1`
- `public valuetype System.Decimal Feedback07_Param2`
- `public valuetype System.Decimal Feedback07_Param3`
- `public valuetype System.Decimal Feedback08_Param1`
- `public valuetype System.Decimal Feedback08_Param2`
- `public valuetype System.Decimal Feedback09_Param1`

## ideal.cxSistemLineRecord

Extends: `System.Object`


Fields:
- `public string Aciklama`
- `public bool ActiveBool`
- `public int BarKaydir`
- `public valuetype System.Drawing.Color Color`
- `public System.Collections.Generic.List`1<float> Deger`
- `public int FrameNo`
- `public int Kalinlik`
- `public int Panel`
- `public valuetype System.Drawing.Color Renk`
- `public System.Collections.Generic.List`1<valuetype System.Drawing.Color> RenkListesi`
- `public int Stil`

## ideal.cxTakasGroups

Extends: `System.ValueType`

Methods:
- `public void AddItem(string; string)`
- `public string[] GetBrokerArray(string)`
- `public System.Collections.Generic.Dictionary`2<string, string> GetBrokerDictionary(string)`
- `public string GetItem(string)`
- `public string GetKey(string)`
- `public string[] GetKeyArray()`
- `public double GetStockGrupDateTakas(string; System.Collections.Generic.Dictionary`2<string, bool>&; string)`
- `public void ReadItems()`
- `public void RemoveItem(string)`
- `public void WriteItems()`

Fields:
- `public System.Collections.Generic.Dictionary`2<string, string> Dictionary`

## ideal.cxVipOrder

Extends: `System.Object`

Methods:
- `public System.Collections.Generic.List`1<class DistributionRecord> GetDistributionList(int; valuetype System.DateTime; string; string)`

## ideal.DurumRobot

Extends: `System.Object`


Fields:
- `public bool Durum`
- `public bool LisansBool`
- `public bool ModBool`
- `public string PanelAdi`
- `public int SanalGercek`
- `public string Urun`

## ideal.EgzotikEmirClass

Extends: `System.Object`


Fields:
- `public string Aciklama`
- `public valuetype System.Decimal Fiyat`
- `public string Hesap`
- `public string Kriter`
- `public valuetype System.Decimal Miktar`
- `public int SanalGercek`
- `public string Sembol`
- `public string SinyalBarNo`
- `public string SinyalPatern`
- `public valuetype System.DateTime Tarih`

## ideal.EmirRec

Extends: `System.Object`

Methods:
- `public class ideal.EmirRec StringToItem(string)`

Fields:
- `public string AllocId`
- `public double BekleyenMiktar`
- `public double EmirFiyat`
- `public string EmirId`
- `public double EmirMiktar`
- `public string EmirStatus`
- `public string EmirSure`
- `public string EmirTip`
- `public double GerceklesenFiyat`
- `public double GerceklesenMiktar`
- `public string HesapNo`
- `public string IslemYon`
- `public int Piyasa`
- `public string RefNo`
- `public string SembolId`
- `public string SembolIdeal`
- `public string SembolKod`
- `public string SembolRoot`
- `public int SiraNo`
- `public string TimeString`
- `public string TransactTime`
- `public string TrdMatchID`
- `public valuetype System.DateTime TurkishTime`

## ideal.enPriceFields

Extends: `System.Enum`


Fields:
- `public valuetype ideal.enPriceFields Average`
- `public valuetype ideal.enPriceFields Close`
- `public valuetype ideal.enPriceFields High`
- `public valuetype ideal.enPriceFields Low`
- `public valuetype ideal.enPriceFields Mid`
- `public valuetype ideal.enPriceFields Open`
- `public valuetype ideal.enPriceFields Typical`
- `public int value__`

## ideal.exIndicatorTypes

Extends: `System.Enum`


Fields:
- `public valuetype ideal.exIndicatorTypes AccumulationDistribution`
- `public valuetype ideal.exIndicatorTypes AccumulationSwingIndex`
- `public valuetype ideal.exIndicatorTypes Alligator`
- `public valuetype ideal.exIndicatorTypes AroonOscillator`
- `public valuetype ideal.exIndicatorTypes AroonUpDown`
- `public valuetype ideal.exIndicatorTypes AverageDirectionalIndex`
- `public valuetype ideal.exIndicatorTypes AverageDirectionalRating`
- `public valuetype ideal.exIndicatorTypes AverageTrueRange`
- `public valuetype ideal.exIndicatorTypes AwesomeOscillator`
- `public valuetype ideal.exIndicatorTypes BilancoFK`
- `public valuetype ideal.exIndicatorTypes BilancoNetKar`
- `public valuetype ideal.exIndicatorTypes BilancoOdenmisSerm`
- `public valuetype ideal.exIndicatorTypes BilancoOzSerm`
- `public valuetype ideal.exIndicatorTypes BilancoPD`
- `public valuetype ideal.exIndicatorTypes BilancoPDDD`
- `public valuetype ideal.exIndicatorTypes BollingerBands`
- `public valuetype ideal.exIndicatorTypes BollingerWidth`
- `public valuetype ideal.exIndicatorTypes ChaikinMoneyFlow`
- `public valuetype ideal.exIndicatorTypes ChaikinOscillator`
- `public valuetype ideal.exIndicatorTypes ChaikinVolatility`
- `public valuetype ideal.exIndicatorTypes ChandeMomentum`
- `public valuetype ideal.exIndicatorTypes CommodityChannelIndex`
- `public valuetype ideal.exIndicatorTypes CommoditySelectionIndex`
- `public valuetype ideal.exIndicatorTypes Dema`
- `public valuetype ideal.exIndicatorTypes DemandIndex`
- `public valuetype ideal.exIndicatorTypes DetrendedPriceOscillator`
- `public valuetype ideal.exIndicatorTypes DigerSymbol`
- `public valuetype ideal.exIndicatorTypes DirectionalIndicator`
- `public valuetype ideal.exIndicatorTypes DirectionalMovement`
- `public valuetype ideal.exIndicatorTypes DoubleMA`
- `public valuetype ideal.exIndicatorTypes EaseOfMovement`
- `public valuetype ideal.exIndicatorTypes EhlersDistCoefFilter`
- `public valuetype ideal.exIndicatorTypes EhlersFilter`
- `public valuetype ideal.exIndicatorTypes ElliotWaveOscillator`
- `public valuetype ideal.exIndicatorTypes Envelope`
- `public valuetype ideal.exIndicatorTypes FaizMb`
- `public valuetype ideal.exIndicatorTypes FibonacciBand`
- `public valuetype ideal.exIndicatorTypes FisherTransform`
- `public valuetype ideal.exIndicatorTypes ForecastOscillator`
- `public valuetype ideal.exIndicatorTypes FxSniper`
- `public valuetype ideal.exIndicatorTypes HHV`
- `public valuetype ideal.exIndicatorTypes HighLowBox`
- `public valuetype ideal.exIndicatorTypes HighLowRange`
- `public valuetype ideal.exIndicatorTypes HullMA`
- `public valuetype ideal.exIndicatorTypes Ichimoku`
- `public valuetype ideal.exIndicatorTypes IntradayMomentumIndex`
- `public valuetype ideal.exIndicatorTypes Kairi`
- `public valuetype ideal.exIndicatorTypes KeltnerChannel`
- `public valuetype ideal.exIndicatorTypes KlingerOscillator`
- `public valuetype ideal.exIndicatorTypes KurumAnaliz`
- `public valuetype ideal.exIndicatorTypes LLV`
- `public valuetype ideal.exIndicatorTypes LinearRegression`
- `public valuetype ideal.exIndicatorTypes LinearRegressionIndicator`
- `public valuetype ideal.exIndicatorTypes LinearRegressionSlope`
- `public valuetype ideal.exIndicatorTypes Lot`
- `public valuetype ideal.exIndicatorTypes MMA`
- `public valuetype ideal.exIndicatorTypes Macd`
- `public valuetype ideal.exIndicatorTypes MacdHistogram`
- `public valuetype ideal.exIndicatorTypes MassIndex`
- `public valuetype ideal.exIndicatorTypes Momentum`
- `public valuetype ideal.exIndicatorTypes MoneyFlowIndex`
- `public valuetype ideal.exIndicatorTypes MovingAverage`
- `public valuetype ideal.exIndicatorTypes NegativeVolumeIndex`
- `public valuetype ideal.exIndicatorTypes None`
- `public valuetype ideal.exIndicatorTypes OnBalanceVolume`
- `public valuetype ideal.exIndicatorTypes OpenInterest`
- `public valuetype ideal.exIndicatorTypes PGC`
- `public valuetype ideal.exIndicatorTypes PHPL01`
- `public valuetype ideal.exIndicatorTypes ParabolicSAR`
- `public valuetype ideal.exIndicatorTypes Performance`
- `public valuetype ideal.exIndicatorTypes Pivot`
- `public valuetype ideal.exIndicatorTypes PivotBand`
- `public valuetype ideal.exIndicatorTypes PolarizedFractalEfficiency`
- `public valuetype ideal.exIndicatorTypes PositiveVolumeIndex`
- `public valuetype ideal.exIndicatorTypes PriceChannel`
- `public valuetype ideal.exIndicatorTypes PriceOscillatorPercent`
- `public valuetype ideal.exIndicatorTypes PriceOscillatorPercentHistogram`
- `public valuetype ideal.exIndicatorTypes PriceOscillatorPoints`
- `public valuetype ideal.exIndicatorTypes PriceOscillatorPointsHistogram`
- `public valuetype ideal.exIndicatorTypes PriceRocPercent`

## ideal.exSistemObjectTypes

Extends: `System.Enum`


Fields:
- `public valuetype ideal.exSistemObjectTypes BackgroundText`
- `public valuetype ideal.exSistemObjectTypes BarRengi`
- `public valuetype ideal.exSistemObjectTypes Cizgi`
- `public valuetype ideal.exSistemObjectTypes DikeyCizgi`
- `public valuetype ideal.exSistemObjectTypes Dortgen`
- `public valuetype ideal.exSistemObjectTypes GradientText`
- `public valuetype ideal.exSistemObjectTypes NormalText`
- `public valuetype ideal.exSistemObjectTypes ResimPng`
- `public valuetype ideal.exSistemObjectTypes RoundedRectangle`
- `public valuetype ideal.exSistemObjectTypes Ucgen`
- `public valuetype ideal.exSistemObjectTypes Yay`
- `public valuetype ideal.exSistemObjectTypes Yay4`
- `public int value__`

## ideal.FixEmirRec

Extends: `System.Object`


Fields:
- `public double BekleyenMiktar`
- `public double EmirFiyat`
- `public double EmirMiktar`
- `public double GerceklesenFiyat`
- `public double GerceklesenMiktar`
- `public string IslemYon`
- `public string OrderId`
- `public string OrderUuid`
- `public valuetype System.DateTime TurkishTime`
- `public string symbol`

## ideal.FixHesapRec

Extends: `System.Object`


Fields:
- `public string Aciklama`
- `public System.Collections.Generic.Dictionary`2<string, System.Collections.Generic.List`1<class ideal.FixEmirRec>> EmirUpdateDict`
- `public string HesapNo`
- `public string KisaAd`

## ideal.FixOrderData

Extends: `System.Object`


Properties:
- `class OrderReport cancelOrderReport`
- `class Error error`
- `class NewOrder newOrder`
- `class OrderReport orderReport`
- `valuetype ideal.Piyasa piyasa`

## ideal.FixPortfoy

Extends: `System.Object`

Methods:
- `public void DefineFields()`
- `public class ideal.FixHesapRec GetRumuzHesap(string; string)`
- `public void PrepareHesapNoRumuzDict()`
- `public void ReadFixOrder()`
- `public void SetDefaultParam()`
- `public void SetTema(int)`
- `public void ShowOmsKep(string; class BuySell)`
- `public void WriteFixOrder()`

Fields:
- `public valuetype System.Drawing.Color BekleyenAlisBackColor`
- `public valuetype System.Drawing.Color BekleyenAlisForeColor`
- `public valuetype System.Drawing.Color BekleyenSatisBackColor`
- `public valuetype System.Drawing.Color BekleyenSatisForeColor`
- `public valuetype System.DateTime FixOrderHeartbeatTime`
- `public string FixOrderIp`
- `public string FixOrderPassword`
- `public int FixOrderPort`
- `public string FixOrderUser`
- `public valuetype System.Drawing.Color FormBackColor`
- `public valuetype System.Drawing.Color FormBorderColor`
- `public valuetype System.Drawing.Color FormButtonColor`
- `public valuetype System.Drawing.Color FormForeColor`
- `public valuetype System.Drawing.Color FormHeaderBackColor`
- `public valuetype System.Drawing.Color FormHeaderForeColor`
- `public int FormHeight`
- `public int FormWidth`
- `public valuetype System.Drawing.Color GerceklesenAlisBackColor`
- `public valuetype System.Drawing.Color GerceklesenAlisForeColor`
- `public valuetype System.Drawing.Color GerceklesenSatisBackColor`
- `public valuetype System.Drawing.Color GerceklesenSatisForeColor`
- `public valuetype System.Drawing.Color GridBackColor`
- `public class System.Drawing.Font GridFont`
- `public valuetype System.Drawing.Color GridForeColor`
- `public valuetype System.Drawing.Color GridLineColor`
- `public valuetype System.Drawing.Color HeaderBackColor`
- `public valuetype System.Drawing.Color HeaderForeColor`
- `public System.Collections.Concurrent.ConcurrentDictionary`2<string, string> HesapNameRumuzDict`
- `public System.Collections.Concurrent.ConcurrentDictionary`2<string, string> HesapNoRumuzDict`
- `public System.Collections.Generic.List`1<class ideal.FixFieldRec> HisseBekleyenFieldDefs`
- `public System.Collections.Generic.List`1<class ideal.FixFieldRec> HisseBekleyenFieldList`
- `public System.Collections.Generic.List`1<class ideal.FixFieldRec> HisseGerceklesenFieldDefs`
- `public System.Collections.Generic.List`1<class ideal.FixFieldRec> HisseGerceklesenFieldList`
- `public System.Collections.Generic.List`1<class ideal.FixFieldRec> HisseIptalFieldDefs`
- `public System.Collections.Generic.List`1<class ideal.FixFieldRec> HisseIptalFieldList`
- `public System.Collections.Generic.List`1<class ideal.FixFieldRec> HisseKzFieldDefs`
- `public System.Collections.Generic.List`1<class ideal.FixFieldRec> HisseKzFieldList`
- `public System.Collections.Generic.List`1<class ideal.FixFieldRec> HisseOzetFieldDefs`
- `public System.Collections.Generic.List`1<class ideal.FixFieldRec> HisseOzetFieldList`
- `public System.Collections.Generic.List`1<class ideal.FixFieldRec> HissePozisyonFieldDefs`
- `public System.Collections.Generic.List`1<class ideal.FixFieldRec> HissePozisyonFieldList`
- `public class ideal.FixPortfoy Instance`
- `public valuetype System.Drawing.Color IptalAlisBackColor`
- `public valuetype System.Drawing.Color IptalAlisForeColor`
- `public valuetype System.Drawing.Color IptalSatisBackColor`
- `public valuetype System.Drawing.Color IptalSatisForeColor`
- `public valuetype System.Drawing.Color KzAlisBackColor`
- `public valuetype System.Drawing.Color KzAlisForeColor`
- `public valuetype System.Drawing.Color KzNetBackColor`
- `public valuetype System.Drawing.Color KzNetForeColor`
- `public valuetype System.Drawing.Color KzSatisBackColor`
- `public valuetype System.Drawing.Color KzSatisForeColor`
- `public valuetype System.Drawing.Color LabelBackColor1`
- `public valuetype System.Drawing.Color LabelBackColor2`
- `public valuetype System.Drawing.Color LabelBorderColor`
- `public valuetype System.Drawing.Color LabelForeColor`
- `public valuetype System.Drawing.Color LogoutBackColor`
- `public valuetype System.Drawing.Color LogoutBorderColor`
- `public valuetype System.Drawing.Color LogoutForeColor`
- `public valuetype System.Drawing.Color PushOffBackColor1`
- `public valuetype System.Drawing.Color PushOffBackColor2`
- `public valuetype System.Drawing.Color PushOffBorderColor`
- `public valuetype System.Drawing.Color PushOffForeColor`
- `public valuetype System.Drawing.Color PushOnBackColor1`
- `public valuetype System.Drawing.Color PushOnBackColor2`
- `public valuetype System.Drawing.Color PushOnBorderColor`
- `public valuetype System.Drawing.Color PushOnForeColor`
- `public bool ReconnectBool`
- `public int RowHeight`
- `public System.Collections.Concurrent.ConcurrentDictionary`2<string, class ideal.FixHesapRec> RumuzDict`
- `public valuetype System.Drawing.Color RumuzInColor`
- `public valuetype System.Drawing.Color RumuzOutColor`
- `public bool RumuzVisible`
- `public string SessionId`
- `public int TemaTip`
- `public int Version`
- `public System.Collections.Generic.List`1<class ideal.FixFieldRec> ViopBekleyenFieldDefs`
- `public System.Collections.Generic.List`1<class ideal.FixFieldRec> ViopBekleyenFieldList`
- `public System.Collections.Generic.List`1<class ideal.FixFieldRec> ViopGerceklesenFieldDefs`
- `public System.Collections.Generic.List`1<class ideal.FixFieldRec> ViopGerceklesenFieldList`

## ideal.FixRouterAccountData

Extends: `System.Object`


Properties:
- `string account`
- `valuetype ideal.FixRouterAccountEnum account_type`

## ideal.FixRouterAccountEnum

Extends: `System.Enum`


Fields:
- `public valuetype ideal.FixRouterAccountEnum PAY`
- `public valuetype ideal.FixRouterAccountEnum VIOP`
- `public short value__`

## ideal.formAccounts

Extends: `System.Windows.Forms.Form`

Methods:
- `public void NotBinance()`
- `family void Dispose(bool)`

Fields:
- `public class ideal.formAccounts Reference`

## ideal.formAcSatKapaImkbOrder

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public double AmountShowing`
- `public string FiyatTip`
- `public double Lot`
- `public double Price`
- `public string Sure`
- `public string Symbol`
- `public class BuySellRecord buysell`

## ideal.formAlanSatanChart

Extends: `ideal.FormControl`

Methods:
- `public void DisplayData(string)`
- `family void Dispose(bool)`

Fields:
- `public class ideal.formAlanSatanChart Reference`

## ideal.formAmendImkbOrder

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public class ImkbOrderRecord AmendOrderRecord`
- `public double AmountShowing`
- `public double Lot`
- `public double Price`
- `public string Symbol`

## ideal.formAmendImkbStock

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public string Symbol`

## ideal.formAmendVipStocks

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public string Symbol`

## ideal.formBakiyeGrafik

Extends: `System.Windows.Forms.Form`

Methods:
- `public void ShowForm()`
- `family void Dispose(bool)`

Fields:
- `public System.Collections.Generic.List`1<class BakiyeClass> BakiyeList`
- `public float IlkBakiye`
- `public class ideal.formBakiyeGrafik Reference`

## ideal.formBinanceChartDownload

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public class System.Threading.CancellationTokenSource Csource`
- `public class System.Threading.Tasks.Task MainTask`
- `public string SonDurum`
- `public string filename`
- `public class ideal.formBinanceChartDownload reference`

## ideal.formBirimGrafikSplit

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

## ideal.formBistUyari

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

## ideal.formBookImkb

Extends: `ideal.FormControl`

Methods:
- `public void ChangeColors(class ideal.cxColorEditor)`
- `public byte[] ConvertPageToByteArray()`
- `public void ProcessMenuMessage(string)`
- `family void Dispose(bool)`
- `family void OnPaintBackground(class System.Windows.Forms.PaintEventArgs)`
- `family bool ProcessCmdKey(valuetype System.Windows.Forms.Message&; valuetype System.Windows.Forms.Keys)`

Fields:
- `public valuetype System.DateTime SelectedDate`
- `public class System.Windows.Forms.ContextMenuStrip menuMain`
- `public class System.Windows.Forms.ToolStripComboBox menuMainPatternChange`

## ideal.formBookVip

Extends: `ideal.FormControl`

Methods:
- `public void ChangeColors(class ideal.cxColorEditor)`
- `public byte[] ConvertPageToByteArray()`
- `public void ProcessMenuMessage(string)`
- `family void Dispose(bool)`
- `family void OnPaintBackground(class System.Windows.Forms.PaintEventArgs)`
- `family bool ProcessCmdKey(valuetype System.Windows.Forms.Message&; valuetype System.Windows.Forms.Keys)`

Fields:
- `public valuetype System.DateTime SelectedDate`
- `public class System.Windows.Forms.ContextMenuStrip menuMain`
- `public class System.Windows.Forms.ToolStripComboBox menuMainPatternChange`

## ideal.formBrutTakas

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public class ideal.formBrutTakas Referance`

## ideal.formBrutTakasRiskUyari

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public class RiskBildirimSonuc RiskBildirimSonuc`
- `public class ideal.formBrutTakasRiskUyari reference`

## ideal.formBuySellImkb1

Extends: `ideal.FormControl`

Methods:
- `public byte[] ConvertPageToByteArray()`
- `public void EditReadyOrder()`
- `public class BuySellRecord PrepareBuySell(bool)`
- `family void Dispose(bool)`

Fields:
- `public string AccountName`
- `public string AccountNo`
- `public string AcigaSatisKapama`
- `public string Direction`
- `public string Duration`
- `public double Lot`
- `public string OrderType`
- `public double Price`
- `public string SellType`
- `public string Symbol`

## ideal.formBuySellImkb2

Extends: `ideal.FormControl`

Methods:
- `public byte[] ConvertPageToByteArray()`
- `family void Dispose(bool)`

Fields:
- `public string AccountName`
- `public string AccountNo`
- `public string Direction`
- `public string Duration`
- `public double Lot`
- `public string OrderType`
- `public double Price`
- `public string SellType`
- `public string Symbol`
- `public valuetype System.DateTime ValorDate`

## ideal.formBuySellImkb3

Extends: `ideal.FormControl`

Methods:
- `public byte[] ConvertPageToByteArray()`
- `public void EditOrder()`
- `public class BuySellRecord PrepareBuySell(bool)`
- `family void Dispose(bool)`

Fields:
- `public string AccountName`
- `public string AccountNo`
- `public string AcigaSatisKapama`
- `public string Direction`
- `public string Duration`
- `public bool KucukBool`
- `public double Lot`
- `public string OrderType`
- `public double Price`
- `public string SellType`
- `public string Symbol`
- `public valuetype System.DateTime ValorDate`

## ideal.formBuySellImkb4

Extends: `ideal.FormControl`

Methods:
- `public byte[] ConvertPageToByteArray()`
- `family void Dispose(bool)`

Fields:
- `public string AccountName`
- `public string AccountNo`
- `public string Direction`
- `public string Duration`
- `public double Lot`
- `public string OrderType`
- `public double Price`
- `public string SellType`
- `public valuetype System.Decimal Step`
- `public string Symbol`
- `public int activeLotPicker`
- `public int activePicker`
- `public valuetype System.Drawing.Color btnpickercolor1`
- `public valuetype System.Drawing.Color btnpickercolor2`
- `public string decformat`

## ideal.formBuySellVip

Extends: `ideal.FormControl`

Methods:
- `public byte[] ConvertPageToByteArray()`
- `public void ImproveOrder()`
- `public class BuySellRecord PrepareBuySell(bool)`
- `family void Dispose(bool)`

Fields:
- `public string AccountName`
- `public string AccountNo`
- `public bool AksamSeansBool`
- `public bool AlgoEdit`
- `public string Direction`
- `public string Duration`
- `public valuetype System.DateTime EndDate`
- `public double Lot`
- `public string OrderType`
- `public double Price`
- `public string PriceType`
- `public string SartSymbol`
- `public string SartTip`
- `public double StopLevel`
- `public string Symbol`
- `public bool improveBool`

## ideal.formCancelImkb

Extends: `ideal.FormControl`

Methods:
- `family void Dispose(bool)`

Fields:
- `public string ActiveSymbol`

## ideal.formCancelMultiImkb

Extends: `ideal.FormControl`

Methods:
- `family void Dispose(bool)`

Fields:
- `public string ActiveSymbol`

## ideal.formCancelMultiVip

Extends: `ideal.FormControl`

Methods:
- `family void Dispose(bool)`

Fields:
- `public string ActiveSymbol`

## ideal.formCancelVip

Extends: `ideal.FormControl`

Methods:
- `family void Dispose(bool)`

Fields:
- `public string ActiveSymbol`

## ideal.formChart

Extends: `ideal.FormControl`

Methods:
- `public void ChangeColors(class ideal.cxColorEditor)`
- `public void ChangeSymbolPeriod(string; string)`
- `public byte[] ConvertPageToByteArray()`
- `public void HacimOtoDownload()`
- `public void InsertIndicators(System.Collections.Generic.List`1<class ideal.cxIndicator>)`
- `public void ProcessMenuMessage(string)`
- `public void RemoveOtoTrend()`
- `public void SaveOtoTrend()`
- `public void TradeReceived(valuetype ideal.IslemStruct1)`
- `family void Dispose(bool)`
- `family void OnPaintBackground(class System.Windows.Forms.PaintEventArgs)`
- `family bool ProcessCmdKey(valuetype System.Windows.Forms.Message&; valuetype System.Windows.Forms.Keys)`

Fields:
- `public string ActiveFile`
- `public string ActivePeriod`
- `public string ActiveSymbol`
- `public class ideal.ChartControl ChartControlReferance`
- `public bool FormActivated`
- `public bool FormLoaded`
- `public bool HacimBool`
- `public int HacimDayCount`
- `public int HacimKurumId`
- `public class Chart PageParams`
- `public class ideal.formChart Referance`
- `public valuetype System.Drawing.Color ToolBarActiveColor`
- `public valuetype System.Drawing.Color ToolBarBackColor`
- `public valuetype System.Drawing.Color ToolBarForeColor`
- `public bool ToolBarVisible`
- `public bool TopMostEnabled`
- `public class System.Windows.Forms.ComboBox comboFiles`

## ideal.formChartDataEdit

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public class ideal.cxBar Bar`
- `public string Period`
- `public string Symbol`

## ideal.formChartDataSplit

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public string Symbol`

## ideal.formChartIndicatorEdit

Extends: `System.Windows.Forms.Form`

Methods:
- `public string AnalizTipToString(int)`
- `public void GetParameters(class ideal.ChartControl)`
- `public void ProcessBirimSeviyeMenu(int)`
- `public void ProcessBirimYontemMenu(int)`
- `public void ShowBirimSeviyeMenu(object; class ideal.cxIndicator)`
- `public void ShowBirimYontemMenu(object; class ideal.cxIndicator)`
- `family void Dispose(bool)`

Fields:
- `public class ideal.formChartIndicatorEdit ChartIndicatorEdit`
- `public class System.Windows.Forms.ContextMenuStrip menuBirim`
- `public class System.Windows.Forms.ContextMenuStrip menuBirimSeviye`
- `public class System.Windows.Forms.TextBox textVolumeSymbol`

## ideal.formChartIndicators

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

## ideal.formChartList

Extends: `System.Windows.Forms.Form`

Methods:
- `public void SetSymbol(string)`
- `family void Dispose(bool)`

Fields:
- `public class ideal.formChartList Reference`
- `public string Symbol`

## ideal.formChartParamMenu

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

## ideal.formChartTrendMenu

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public class ideal.formChartTrendMenu Referance`

## ideal.formDefaultLotImkb

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

## ideal.formDepthImkb

Extends: `ideal.FormControl`

Methods:
- `public void ApplyPattern(class Depth)`
- `public void ChangeColors(class ideal.cxColorEditor)`
- `public byte[] ConvertPageToByteArray()`
- `public void ProcessMenuMessage(string)`
- `family void Dispose(bool)`
- `family void OnPaintBackground(class System.Windows.Forms.PaintEventArgs)`
- `family bool ProcessCmdKey(valuetype System.Windows.Forms.Message&; valuetype System.Windows.Forms.Keys)`

Fields:
- `public string ActiveSymbol`

## ideal.formDepthVip

Extends: `ideal.FormControl`

Methods:
- `public void ApplyPattern(class Depth)`
- `public void ChangeColors(class ideal.cxColorEditor)`
- `public byte[] ConvertPageToByteArray()`
- `public void ProcessMenuMessage(string)`
- `family void Dispose(bool)`
- `family void OnPaintBackground(class System.Windows.Forms.PaintEventArgs)`
- `family bool ProcessCmdKey(valuetype System.Windows.Forms.Message&; valuetype System.Windows.Forms.Keys)`

Fields:
- `public string ActiveSymbol`

## ideal.formDerinlikliEmirPenceresi

Extends: `ideal.FormControl`

Methods:
- `public byte[] ConvertPageToByteArray()`
- `family void Dispose(bool)`
- `family bool ProcessCmdKey(valuetype System.Windows.Forms.Message&; valuetype System.Windows.Forms.Keys)`

Fields:
- `public string AccountName`
- `public string AccountNo`
- `public string AcigaSatisKapama`
- `public string ActiveSymbol`
- `public bool DEPBilgiGizle`
- `public bool DEPDerinlikGizle`
- `public bool DEPEmirleriGizle`
- `public int DecimalPoint`
- `public string Direction`
- `public string Duration`
- `public System.Collections.Generic.List`1<double> KademeLotList`
- `public bool KucukBool`
- `public double Lot`
- `public string OrderType`
- `public string Prefix`
- `public double Price`
- `public string SellType`
- `public string Symbol`

## ideal.formDistributionImkb

Extends: `System.Windows.Forms.Form`

Methods:
- `public void ChangeSymbol(string)`
- `family void Dispose(bool)`

Fields:
- `public string ActiveSymbol`
- `public class ideal.formDistributionImkb Reference`
- `public class System.Windows.Forms.ContextMenuStrip menu`

## ideal.formDownloadBistIslem

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public class ideal.formDownloadBistIslem reference`

## ideal.formDownloadChart

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public class ideal.formDownloadChart Reference`

## ideal.formDurumTumRobot

Extends: `System.Windows.Forms.Form`

Methods:
- `public void ShowWindow()`
- `family void Dispose(bool)`

Fields:
- `public class ideal.formDurumTumRobot Referans`

## ideal.formEgzotikRobot

Extends: `System.Windows.Forms.Form`

Methods:
- `public void ShowWindow()`
- `family void Dispose(bool)`

Fields:
- `public class ideal.formEgzotikRobot Referans`

## ideal.formEmirSira

Extends: `ideal.FormControl`

Methods:
- `public void ApplyPattern(class Depth)`
- `public void ChangeColors(class ideal.cxColorEditor)`
- `public byte[] ConvertPageToByteArray()`
- `public void ProcessMenuMessage(string)`
- `family void Dispose(bool)`
- `family void OnPaintBackground(class System.Windows.Forms.PaintEventArgs)`
- `family bool ProcessCmdKey(valuetype System.Windows.Forms.Message&; valuetype System.Windows.Forms.Keys)`

Fields:
- `public string ActiveSymbol`

## ideal.formFixPortfoy

Extends: `System.Windows.Forms.Form`

Methods:
- `public void ChangeColors(class ideal.cxColorEditor)`
- `public void ProcessMenuMessage(string)`
- `public void setTabPage(string)`
- `family void Dispose(bool)`

Fields:
- `public class ideal.formFixPortfoy Reference`

## ideal.formFixPortfoyHesapEkle

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public bool InsertBool`
- `public class ideal.FixHesapRec Item`
- `public bool ModifiedBool`

## ideal.formGetiriGrafik

Extends: `System.Windows.Forms.Form`

Methods:
- `public void GrafikCiz(System.Collections.Generic.List`1<class ideal.Takvim>)`
- `public void GrafikCiz(System.Collections.Generic.List`1<class ideal.cxBasic>)`
- `public void GrafikCiz(System.Collections.Generic.List`1<string>; System.Collections.Generic.List`1<class ideal.cxBasic>)`
- `public void TakvimGrafikPiyasaSec()`
- `public void comboDeger()`
- `public void grafikBoyutSec()`
- `public void grafikTipSec()`
- `family void Dispose(bool)`

Fields:
- `public class ideal.formGetiriGrafik Reference`
- `public int TakvimTurIndex`

## ideal.formGridChart

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public string ActiveSymbol`
- `public class ideal.formGridChart Referans`

## ideal.formHacim

Extends: `ideal.FormControl`

Methods:
- `public byte[] ConvertPageToByteArray()`
- `public void ShowNewFrom(class BuySell; int; string)`
- `family void Dispose(bool)`

Fields:
- `public class System.Windows.Forms.ContextMenuStrip menuDate`
- `public class System.Windows.Forms.ToolStripMenuItem menuDateDay`

## ideal.formHesap

Extends: `ideal.FormControl`

Methods:
- `public byte[] ConvertPageToByteArray()`
- `family void Dispose(bool)`

Fields:
- `public string AccountName`
- `public string AccountNo`
- `public class ideal.cxButton Buttons`
- `public string Piyasa`
- `public string Tab`
- `public class System.Windows.Forms.ContextMenuStrip menuImkbOrder`
- `public class System.Windows.Forms.ToolStripMenuItem menuImkbOrderActive`
- `public class System.Windows.Forms.ToolStripMenuItem menuImkbOrderCancel`
- `public class System.Windows.Forms.ToolStripMenuItem menuImkbOrderChangeSession`
- `public class System.Windows.Forms.ToolStripMenuItem menuImkbOrderEditOrder`
- `public class System.Windows.Forms.ContextMenuStrip menuVipOrder`
- `public class System.Windows.Forms.ToolStripMenuItem menuVipOrderSubCancel`
- `public class System.Windows.Forms.ToolStripMenuItem menuVipOrderSubEditOrder`

## ideal.formHesapEkle

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public bool InsertBool`
- `public class ideal.HesapRec Item`
- `public bool ModifiedBool`

## ideal.formHesapGrup

Extends: `System.Windows.Forms.Form`

Methods:
- `public void AddGrup(string)`
- `public void FillGruplar(string)`
- `public void FillHesaplar(string)`
- `family void Dispose(bool)`

Fields:
- `public string AltHesap`
- `public string HesapName`
- `public string RumuzName`

## ideal.formHesapRumuz

Extends: `System.Windows.Forms.Form`

Methods:
- `public void FillRumuzlar(string)`
- `family void Dispose(bool)`

Fields:
- `public string AltHesap`
- `public class ideal.HesapNameClass HesapItem`
- `public string HesapName`
- `public string RumuzName`

## ideal.formHisseAnalizRobotEkle

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public bool EklendiBool`

## ideal.formICRYPEXChartDownload

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public class System.Threading.CancellationTokenSource Csource`
- `public class System.Threading.Tasks.Task MainTask`
- `public string SonDurum`
- `public string filename`
- `public class ideal.formICRYPEXChartDownload reference`

## ideal.formIndicatorValues

Extends: `System.Windows.Forms.Form`

Methods:
- `public void ProcessMenuMessage(string)`
- `public void RefreshData(string; System.Collections.Generic.List`1<class ideal.cxIndicator>)`
- `family void Dispose(bool)`

Fields:
- `public valuetype System.Drawing.Point LocationThis`
- `public class ideal.formIndicatorValues Reference`
- `public valuetype System.Drawing.Size SizeThis`
- `public string SymbolFilter`

## ideal.formKademeCancelOrder

Extends: `ideal.FormControl`

Methods:
- `family void Dispose(bool)`

## ideal.formKodRobot

Extends: `System.Windows.Forms.Form`

Methods:
- `public void AddRobot(string; string; string)`
- `public void ShowForm()`
- `family void Dispose(bool)`

Fields:
- `public valuetype System.Drawing.Color NotRunningColor`
- `public class ideal.formKodRobot Referans`
- `public valuetype System.Drawing.Color RunningColor`

## ideal.formKodRobotEkle

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public bool EklendiBool`

## ideal.formKurumSec

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public string KurumName`

## ideal.formMultiOrderMenu

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public class ideal.cxButton MenuButtons`

## ideal.formNagantsRobotEkle

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public bool EklendiBool`

## ideal.formPacalChart

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public string ActiveSymbol`
- `public class ideal.formPacalChart Referans`

## ideal.formParaViop

Extends: `System.Windows.Forms.Form`

Methods:
- `public string GetString(string)`
- `public void ProcessParaYonler(string)`
- `public void ShowWindow()`
- `family void Dispose(bool)`

Fields:
- `public object IdealParaDll`
- `public bool IdealParaLoaded`
- `public string IdealParaViopStartString`
- `public class ideal.formParaViop Referans`

## ideal.formParaViopEkle

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

## ideal.formPgcRobotEkle

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public bool EklendiBool`

## ideal.formPortfolio

Extends: `System.Windows.Forms.Form`

Methods:
- `public void AddAccount()`
- `public void BuyImkbLimit()`
- `public void BuyImkbMoney()`
- `public void BuyImkbMyPosition()`
- `public void ChangeColors(class ideal.cxColorEditor)`
- `public void CloseImkbPositionsAll()`
- `public void CloseImkbPositionsPercent()`
- `public void ProcessMenuMessage(string)`
- `public void StartRobot()`
- `public void StopRobot()`
- `family void Dispose(bool)`

Fields:
- `public bool EmirlerSilinmesinBool`
- `public class ideal.cxButton ImkbOrderButtons`
- `public class ideal.cxButton ImkbPortfolioButtons`
- `public class ideal.cxButton ImkbReadyButtons`
- `public class ideal.cxButton ImkbWaitingButtons`
- `public class ideal.cxButton MagnusButtons`
- `public class ideal.formPortfolio Reference`
- `public class ideal.cxButton TabButtons`
- `public class ideal.cxButton ToolbarButtons`
- `public class ideal.cxButton VipOrderButtons`
- `public class ideal.cxButton VipPortfolioButtons`
- `public class System.Windows.Forms.ComboBox comboVipExpiry`
- `public class System.Windows.Forms.ComboBox comboVipSymbols`

## ideal.formPortfolioMessage

Extends: `System.Windows.Forms.Form`

Methods:
- `public void Clear()`
- `public void SetMessages(string; System.Collections.Generic.List`1<string>)`
- `public void SetSize()`
- `family void Dispose(bool)`
- `family bool ProcessCmdKey(valuetype System.Windows.Forms.Message&; valuetype System.Windows.Forms.Keys)`

Fields:
- `public class ideal.formPortfolioMessage Reference`

## ideal.formPortfolioSetting

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public class ideal.formPortfolioSetting Reference`

## ideal.formPortfoyum

Extends: `System.Windows.Forms.Form`

Methods:
- `public void AddAccount()`
- `public void BuyImkbLimit()`
- `public void BuyImkbMoney()`
- `public void BuyImkbMyPosition()`
- `public void ChangeColors(class ideal.cxColorEditor)`
- `public void CloseImkbPositionsAll()`
- `public void CloseImkbPositionsPercent()`
- `public System.Collections.Generic.List`1<class VarlikRecord> ConvertPositionToVarlik(class Portfoy; string)`
- `public System.Collections.Generic.List`1<object> FonEmriIletemeyenKurumlar(string)`
- `public void ProcessMenuMessage(string)`
- `public void ShowAgirlikliList()`
- `family void Dispose(bool)`

Fields:
- `public bool EmirlerSilinmesinBool`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> GridFieldDefs`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> GridFieldList`
- `public string ImkbGrupPortfoyAciklama`
- `public string ImkbGrupPortfoyHata`
- `public string ImkbGrupPortfoySortKey`
- `public string ImkbGrupPortfoyStatus`
- `public class ideal.cxButton ImkbOrderButtons`
- `public class ideal.cxButton ImkbPortfolioButtons`
- `public string ImkbProfitAciklama`
- `public string ImkbProfitHata`
- `public string ImkbProfitStatus`
- `public class ideal.cxButton ImkbReadyButtons`
- `public class ideal.cxButton ImkbWaitingButtons`
- `public class ideal.formPortfoyum Reference`
- `public class ideal.cxButton TabButtons`
- `public class ideal.cxButton ToolbarButtons`
- `public string VarlikAciklama`
- `public string VarlikHata`
- `public string VarlikStatus`
- `public class ideal.cxButton VipOrderButtons`
- `public class ideal.cxButton VipPortfolioButtons`
- `public class System.Windows.Forms.ComboBox comboVipExpiry`
- `public class System.Windows.Forms.ComboBox comboVipSymbols`
- `public class System.Windows.Forms.ContextMenuStrip menu`
- `public class System.Windows.Forms.ContextMenuStrip menuFavori`
- `public class System.Windows.Forms.ContextMenuStrip menuTab`

## ideal.formRobotOnay

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public class ideal.formRobotOnay reference`

## ideal.formRoboTradeEkle

Extends: `System.Windows.Forms.Form`

Methods:
- `public void SetMiktarPopup(valuetype System.Decimal)`
- `public void SetPricePopup(valuetype System.Decimal)`
- `family void Dispose(bool)`

Fields:
- `public bool EklendiBool`

## ideal.FormRobotServer

Extends: `System.Windows.Forms.Form`

Methods:
- `public string ErrorMessageParse(class System.Exception)`
- `public string GetGtpHeader(string; string; string; string; string)`
- `public void RobotServerAtaHisseSistem1(class ideal.cxSistem; string)`
- `public void RobotServerMeksaHisseSistem1(class ideal.cxSistem; string)`
- `public void RobotServerPozisyonEsitle(class ideal.cxSistem; string; int; string; valuetype System.Drawing.Color)`
- `public string SendHttpRequest(string; string; string)`
- `public bool ValidateServerCertificate(object; class System.Security.Cryptography.X509Certificates.X509Certificate; class System.Security.Cryptography.X509Certificates.X509Chain; valuetype System.Net.Security.SslPolicyErrors)`
- `family void Dispose(bool)`

Fields:
- `public long AtaKey1`
- `public long AtaKey2`
- `public bool EditLineBool`
- `public class LineClass LineItem`
- `public class ideal.FormRobotServer Reference`
- `public class nsoftware.IPWorks.Ipdaemon hostRobotServer`

## ideal.FormRobotServerEditLine

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

## ideal.FormRobotServerError

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public int HeightParam`
- `public int LeftParam`
- `public class ideal.FormRobotServerError Reference`
- `public int TopParam`
- `public int WidthParam`
- `public class System.Windows.Forms.Label labelUyari`
- `public class System.Windows.Forms.TextBox textUyari`

## ideal.formSablonRobot

Extends: `System.Windows.Forms.Form`

Methods:
- `public void ChangeSistem(string; string)`
- `public void ProcessMenuMessage(string)`
- `public void SelectTab(valuetype idealgoTab)`
- `public void ShowSablonRobot()`
- `public void StartRoboTrade()`
- `family void Dispose(bool)`

Fields:
- `public class ideal.formSablonRobot Referans`
- `public string SembolTaraSembolFilter`
- `public string SistemName`
- `public string SistemPeriyot`
- `public string SistemSembol`
- `public class System.Windows.Forms.ContextMenuStrip menuGrid`
- `public class System.Windows.Forms.PictureBox pictureBoxIdealBE`
- `public class System.Windows.Forms.PictureBox pictureBoxTvitter`
- `public class System.Windows.Forms.PictureBox pictureBoxYouTube`
- `public class System.Windows.Forms.TextBox textBoxOptSymbol`
- `public class System.Windows.Forms.TextBox textBoxPerformansCash`
- `public class System.Windows.Forms.TextBox textBoxPerformansLot`
- `public class System.Windows.Forms.TextBox textBoxPerformansSymbol`
- `public class System.Windows.Forms.TextBox textBoxSistemTaraSymbol`

## ideal.formSablonRobotEkle

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public bool EklendiBool`

## ideal.formSablonRobotPortfoy

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

## ideal.formSinyalDonus

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public class System.Windows.Forms.TextBox textKademe`
- `public class System.Windows.Forms.TextBox textSymbolSearch`

## ideal.formSistemCompare

Extends: `System.Windows.Forms.Form`

Methods:
- `public void ChangeParameters(string; string)`
- `family void Dispose(bool)`

Fields:
- `public class System.Windows.Forms.TextBox textBarCount`
- `public class System.Windows.Forms.TextBox textSymbolSearch`

## ideal.formSistemDefine

Extends: `System.Windows.Forms.Form`

Methods:
- `public void ChangeSistem(string; string)`
- `family void Dispose(bool)`

## ideal.formSistemError

Extends: `System.Windows.Forms.Form`

Methods:
- `public void SetMessages(string)`
- `family void Dispose(bool)`

Fields:
- `public class ideal.formSistemError Reference`
- `public string SistemErrorString`
- `public int WindowHeight`
- `public int WindowLeft`
- `public int WindowTop`
- `public int WindowWidth`
- `public class System.Windows.Forms.TextBox textError`

## ideal.formSistemGetiriEgrisi

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public valuetype System.DateTime DateEnd`
- `public valuetype System.DateTime DateStart`
- `public bool FormDisplayed`
- `public class ideal.formSistemGetiriEgrisi FormHandle`
- `public string Symbol`

## ideal.formSistemMesaj

Extends: `System.Windows.Forms.Form`

Methods:
- `public void ShowMesaj(class MesajQueueClass)`
- `family void Dispose(bool)`

Fields:
- `public System.Collections.Generic.Queue`1<class MesajQueueClass> SistemMesajQueue`
- `public class System.Windows.Forms.TextBox textMessage`

## ideal.formSistemMulti

Extends: `System.Windows.Forms.Form`

Methods:
- `public void ChangeParameters(string; string)`
- `family void Dispose(bool)`
- `family bool ProcessCmdKey(valuetype System.Windows.Forms.Message&; valuetype System.Windows.Forms.Keys)`

Fields:
- `public class System.Windows.Forms.TextBox textBarCount`
- `public class System.Windows.Forms.TextBox textSymbolSearch`

## ideal.formSistemOptimizer

Extends: `System.Windows.Forms.Form`

Methods:
- `public void ChangeSystem(string; string)`
- `family void Dispose(bool)`

Fields:
- `public valuetype System.Drawing.Point FormLocation`
- `public valuetype System.Drawing.Size FormSize`
- `public class ideal.formSistemOptimizer Reference`
- `public class System.Windows.Forms.TextBox textBarCount`
- `public class System.Windows.Forms.TextBox textSymbolSearch`

## ideal.formSistemPerformance

Extends: `System.Windows.Forms.Form`

Methods:
- `public void ChangeSistem(string; string; string)`
- `family void Dispose(bool)`

Fields:
- `public class System.Windows.Forms.TextBox textBarCount`
- `public class System.Windows.Forms.TextBox textCash`
- `public class System.Windows.Forms.TextBox textLot`
- `public class System.Windows.Forms.TextBox textSymbolSearch`

## ideal.formSistemPosition

Extends: `System.Windows.Forms.Form`

Methods:
- `public void ChangeSistem(string; string)`
- `public void ProcessMenuMessage(string)`
- `family void Dispose(bool)`

## ideal.formSistemSorgu

Extends: `System.Windows.Forms.Form`

Methods:
- `public void ChangeSistem(string)`
- `public void ProcessMenuMessage(string)`
- `family void Dispose(bool)`

Fields:
- `public valuetype System.Drawing.Point FormLocation`
- `public valuetype System.Drawing.Size FormSize`
- `public string Period`
- `public class ideal.formSistemSorgu Reference`
- `public string SymbolFilter`

## ideal.formTahtaRobot1Ekle

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

## ideal.formTahtaRobot2Ekle

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

## ideal.formTakasAnaliz

Extends: `System.Windows.Forms.Form`

Methods:
- `public void ChangeSymbol(string)`
- `public void ChangeTabIndex(int)`
- `public void GetBrokerData(class TypeBroker&)`
- `public valuetype System.DateTime GetProperDateForSYSKT()`
- `public void GetStockAllDifData(class TypeStockAll&)`
- `public void GetStockDayData(class TypeStock&)`
- `public void GetStockDayGroupData(class TypeStock&)`
- `public void GetStockDifData(class TypeStock&)`
- `public void ProcessMenuMessage(string)`
- `public void ReadData(string)`
- `public void ReadDataToplams(string)`
- `public void ShowWindow()`
- `public void ShowWindow(int)`
- `family void Dispose(bool)`
- `family bool ProcessCmdKey(valuetype System.Windows.Forms.Message&; valuetype System.Windows.Forms.Keys)`

Fields:
- `public string ActiveSymbol`
- `public bool BolunmeEtkisi`
- `public bool BolunmeEtkisiSD`
- `public string Disclamer1`
- `public string Disclamer2`
- `public string Disclamer3`
- `public string Disclamer4`
- `public string Disclamer5`
- `public string Disclamer6`
- `public class ideal.formTakasAnaliz Referans`
- `public class System.Windows.Forms.ContextMenuStrip menu`

## ideal.formTakasDosyaDuzenle

Extends: `System.Windows.Forms.Form`

Methods:
- `public void ShowWindow()`
- `family void Dispose(bool)`

Fields:
- `public string SonDurum`
- `public class ideal.formTakasDosyaDuzenle reference`

## ideal.formTaramaRobot

Extends: `System.Windows.Forms.Form`

Methods:
- `public void ProcessMenuMessage(string)`
- `public void ShowTaramaRobot()`
- `family void Dispose(bool)`

Fields:
- `public class ideal.formTaramaRobot Referans`

## ideal.formTradeImkb

Extends: `ideal.FormControl`

Methods:
- `public void ChangeColors(class ideal.cxColorEditor)`
- `public void ConvertDownloaded(string)`
- `public byte[] ConvertPageToByteArray()`
- `public void ProcessMenuMessage(string)`
- `public void StartDownloadForThisDay()`
- `family void Dispose(bool)`
- `family void OnPaintBackground(class System.Windows.Forms.PaintEventArgs)`
- `family bool ProcessCmdKey(valuetype System.Windows.Forms.Message&; valuetype System.Windows.Forms.Keys)`

Fields:
- `public class System.Windows.Forms.ContextMenuStrip menuMain`
- `public class System.Windows.Forms.ToolStripComboBox menuMainPatternChange`
- `public class System.Windows.Forms.ToolStripMenuItem menuMainShowCombined`
- `public class System.Windows.Forms.ToolStripMenuItem menuMainShowOpen`

## ideal.formTradeVip

Extends: `ideal.FormControl`

Methods:
- `public void ChangeColors(class ideal.cxColorEditor)`
- `public void ConvertDownloaded(string)`
- `public byte[] ConvertPageToByteArray()`
- `public void ProcessMenuMessage(string)`
- `public void StartDownloadForThisDay()`
- `family void Dispose(bool)`
- `family void OnPaintBackground(class System.Windows.Forms.PaintEventArgs)`
- `family bool ProcessCmdKey(valuetype System.Windows.Forms.Message&; valuetype System.Windows.Forms.Keys)`

Fields:
- `public class System.Windows.Forms.ContextMenuStrip menuMain`
- `public class System.Windows.Forms.ToolStripComboBox menuMainPatternChange`
- `public class System.Windows.Forms.ToolStripMenuItem menuMainShowCombined`
- `public class System.Windows.Forms.ToolStripMenuItem menuMainShowOpen`
- `public class System.Windows.Forms.ToolStripComboBox menuSymbolComboFilter`

## ideal.formTrendAlarmEmir

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

## ideal.formTrendBotChart

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public string ActiveSymbol`
- `public class ideal.formTrendBotChart Referans`

## ideal.formViopKurumHacim2

Extends: `ideal.FormControl`

Methods:
- `public byte[] ConvertPageToByteArray()`
- `public void ShowNewForm(class BuySell; int; string)`
- `family void Dispose(bool)`

## ideal.formVolumesImkb

Extends: `System.Windows.Forms.Form`

Methods:
- `public void GetGunHacim(string; string; double&; double&)`
- `public void ReadFile(string)`
- `family void Dispose(bool)`

Fields:
- `public class ideal.formVolumesImkb Referance`
- `public class System.Windows.Forms.ContextMenuStrip menu`

## ideal.formWeightedListImkb

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

## ideal.formYatayBotChart

Extends: `System.Windows.Forms.Form`

Methods:
- `family void Dispose(bool)`

Fields:
- `public string ActiveSymbol`
- `public class ideal.formYatayBotChart Referans`

## ideal.formZincirImkb

Extends: `ideal.FormControl`

Methods:
- `family void Dispose(bool)`

Fields:
- `public string AccountName`
- `public string AccountNo`
- `public string ActiveSymbol`
- `public string Direction`
- `public string Duration`
- `public double Lot`
- `public string OrderType`
- `public double Price`
- `public string SellType`
- `public string Symbol`

## ideal.fromTakasDownload

Extends: `System.Windows.Forms.Form`

Methods:
- `public void ShowWindow()`
- `family void Dispose(bool)`

Fields:
- `public string SonDurum`
- `public class ideal.fromTakasDownload reference`

## ideal.GrupEmirClass

Extends: `System.Object`


Fields:
- `public double GuncelFiyat`
- `public double GuncelTutar`
- `public double KzBirim`
- `public double KzTutar`
- `public double KzYuzde`
- `public double Lot`
- `public double MaliyetBirim`
- `public double MaliyetTutar`
- `public double PortfoyOran`
- `public string Sembol`

## ideal.GrupHesapClass

Extends: `System.Object`


Fields:
- `public string AltHesap`
- `public double GuncelTutar`
- `public string HesapName`
- `public double KzTutar`
- `public double PortfoyOran`
- `public string RumuzName`

## ideal.HacimClass

Extends: `System.Object`

Methods:
- `public void CalculateHacim()`
- `public void UpdateHacim()`
- `public void UpdateKz()`

Fields:
- `public double BistToplam`
- `public System.Collections.Generic.List`1<class ideal.HacimRecord> Buyer5List`
- `public double Buyer5Net`
- `public string FilterIndexCode`
- `public System.Collections.Generic.Dictionary`2<int, class ideal.HacimRecord> HacimDictionary`
- `public System.Collections.Generic.List`1<class ideal.HacimRecord> HacimList`
- `public bool KzBusyBool`
- `public bool OzelEmirBool`
- `public string Saat1`
- `public string Saat2`
- `public System.Collections.Generic.List`1<class ideal.HacimRecord> Seller5List`
- `public double Seller5Net`
- `public string SureTip`
- `public int SureVal`
- `public double Toplam5`
- `public System.Collections.Generic.List`1<class ideal.HacimRecord> Toplam5List`
- `public double TotalBuy`
- `public double TotalDif`
- `public double TotalSell`
- `public double TotalSum`

## ideal.HacimRecord

Extends: `System.Object`


Fields:
- `public double KZ`
- `public int KurumId`
- `public string KurumName`
- `public double LotBuy`
- `public double LotSell`
- `public double Maliyet`
- `public int SembolId`
- `public string SembolName`
- `public string Seri`
- `public double VolumeBuy`
- `public double VolumeBuyP`
- `public double VolumeDif`
- `public double VolumeDifP`
- `public double VolumeSell`
- `public double VolumeSellP`
- `public double VolumeSum`
- `public double VolumeSumP`

## ideal.HacimTickRecord

Extends: `System.Object`

Methods:
- `public int GetTimeIndex()`

Fields:
- `public float EndeksVal`
- `public int Hour`
- `public int Minute`
- `public double NetVol`
- `public int Second`

## ideal.HedefEmirClass

Extends: `System.Object`

Methods:
- `public void Log()`

Fields:
- `public string Aciklama`
- `public valuetype System.Decimal Fiyat`
- `public double KarZarar`
- `public double Miktar`
- `public string RobotName`
- `public int SanalGercek`
- `public string Sembol`
- `public string StratejiTip`
- `public valuetype System.DateTime Tarih`
- `public string Yon`

## ideal.HesapNameClass

Extends: `System.Object`

Methods:
- `public string GetRumuz(string; string)`

Fields:
- `public string AltHesap`
- `public string HesapName`
- `public string RumuzName`

## ideal.HesapRec

Extends: `System.Object`


Fields:
- `public string Aciklama`
- `public string AltHesap`
- `public System.Collections.Generic.Dictionary`2<string, class ideal.EmirRec> BekleyenDict`
- `public string DropcopyHesap`
- `public System.Collections.Generic.List`1<class ideal.EmirRec> EmirList`
- `public System.Collections.Generic.Dictionary`2<string, System.Collections.Generic.List`1<class ideal.EmirRec>> EmirUpdateDict`
- `public string HesapAd`
- `public string KisaAd`

## ideal.HisseAnalizRobotClass

Extends: `System.Object`

Methods:
- `public void EmirGonder(double; string)`
- `public string GetRobotKey()`
- `public void MailGonder(string)`
- `public void SmsGonder(string; string)`

Fields:
- `public bool AcigaSatisBool`
- `public bool AksamAlisKapatBool`
- `public bool AksamPozKapatBool`
- `public string AksamPozKapatSaat`
- `public bool AksamSatisKapatBool`
- `public int AktifPasif`
- `public string AltHesap`
- `public string AnalizSembol`
- `public string BaslangicSaat`
- `public bool CumaPozKapatBool`
- `public string CumaPozKapatSaat`
- `public int GercekSanal`
- `public string Hesap`
- `public System.Collections.Generic.List`1<class ideal.RobotOrderClass> IslemList`
- `public string IslemSembol`
- `public string KapanisSaat`
- `public double Miktar`
- `public string Periyot`
- `public double Pozisyon`
- `public long RobotID`
- `public string RunningDescription`
- `public bool RunningMode`
- `public int RunningRowNo`
- `public string SistemName`

## ideal.KodRobotClass

Extends: `System.Object`

Methods:
- `public void CalculateIslemKasa(double)`
- `public void CalculateKZ()`
- `public void CalculateStartKasa()`
- `public class ideal.KodRobotClass DeepCopy()`
- `public void EmirGonder(double; string; long)`
- `public string GetRobotKey()`
- `public void SmsGonder(string; string)`

Fields:
- `public bool AcigaSatisBool`
- `public string AltHesap`
- `public string AnalizSembol`
- `public string BaslangicSaat`
- `public int CanliBarSure`
- `public int EmirBarTip`
- `public int GercekSanal`
- `public double GunKz`
- `public int GunKzGun`
- `public double GunKzIslemKasa`
- `public double GunKzStartKasa`
- `public string Hesap`
- `public double IslemFiyat`
- `public System.Collections.Generic.List`1<class ideal.RobotOrderClass> IslemList`
- `public string IslemSembol`
- `public string IslemYon`
- `public string KapanisSaat`
- `public double Kz`
- `public double Miktar`
- `public string Periyot`
- `public double Pozisyon`
- `public long RobotID`
- `public string RunningDescSure`
- `public string RunningDescTime`
- `public bool RunningMode`
- `public valuetype System.DateTime SinyalTime`
- `public string SistemName`
- `public double SonFiyat`
- `public bool SonSinyalBool`
- `public string SonSinyalSaat`

## ideal.KodRobotSettingClass

Extends: `System.Object`

Methods:
- `public void Read()`
- `public void Write()`

Fields:
- `public System.Collections.Generic.List`1<class ideal.KodRobotClass> RobotList`
- `public class ideal.KodRobotSettingClass Setting`
- `public bool SmsBool`
- `public string TelNo`
- `public int WindowHeight`
- `public int WindowLeft`
- `public int WindowTop`
- `public int WindowWidth`
- `public bool YeniSinyalBool`
- `public string YeniSinyalSaat`
- `public string YeniSinyalTarih`

## ideal.KurumAkdClass

Extends: `System.Object`

Methods:
- `public void CalculateAkd(int)`
- `public void CalculateKurumHisse(int)`
- `public void CalculateKurumTum(int)`

Fields:
- `public System.Collections.Generic.Dictionary`2<int, class ideal.HacimRecord> AkdDictionary`
- `public System.Collections.Generic.List`1<class ideal.HacimRecord> AkdList`
- `public double BistToplam`
- `public System.Collections.Generic.List`1<class ideal.HacimRecord> Buyer5List`
- `public double Buyer5Net`
- `public string FilterIndexCode`
- `public bool OzelEmirBool`
- `public string Saat1`
- `public string Saat2`
- `public System.Collections.Generic.List`1<class ideal.HacimRecord> Seller5List`
- `public double Seller5Net`
- `public int SembolId`
- `public string SureTip`
- `public int SureVal`
- `public System.Collections.Generic.List`1<class ideal.HacimTickRecord> TickList`
- `public double Toplam5`
- `public System.Collections.Generic.List`1<class ideal.HacimRecord> Toplam5List`
- `public double TotalBuy`
- `public double TotalDif`
- `public double TotalSell`
- `public double TotalSum`

## ideal.KurumChartClass

Extends: `System.Object`

Methods:
- `public void AddIslemxx(valuetype ideal.IslemStruct1)`
- `public void ConvertIslemlerDayCount(int)`
- `public void ConvertIslemlerTarih(string)`
- `public void ConvertIslemlerToday()`
- `public System.Collections.Generic.List`1<valuetype System.DateTime> GetDateListFromCount(int)`
- `public System.Collections.Generic.List`1<class ideal.cxBar> GetKurumChart(string; int; int; bool; float&; float&)`
- `public System.Collections.Generic.List`1<class KurumRecord> ReadKurumTarihsel(string)`
- `public void WriteKurumTarihsel(System.Collections.Generic.List`1<class KurumRecord>; string)`

Fields:
- `public valuetype System.DateTime DateConverted`
- `public System.Collections.Generic.Dictionary`2<int, System.Collections.Generic.Dictionary`2<string, class KurumRecord>> KurumBugunDictionary`

## ideal.KurumHacimClass

Extends: `System.Object`


Fields:
- `public System.Collections.Generic.List`1<float> Hacim`
- `public System.Collections.Generic.List`1<float> Yuzde`

## ideal.KurumMaliyet

Extends: `System.Object`


Fields:
- `public string Kurum`
- `public double Maliyet`
- `public double NetLot`
- `public double NetOran`

## ideal.MenuChart

Extends: `System.Windows.Forms.Form`

Methods:
- `public void Init()`
- `public void Render()`
- `family void Dispose(bool)`

Fields:
- `public class System.Windows.Forms.ToolStripMenuItem Data`
- `public class System.Windows.Forms.ToolStripMenuItem DataMaxBars`
- `public class System.Windows.Forms.ToolStripMenuItem Download4`
- `public class System.Windows.Forms.ToolStripMenuItem F_Saatler_Gunduz`
- `public class System.Windows.Forms.ToolStripMenuItem F_Saatler_Tum`
- `public class System.Windows.Forms.ToolStripMenuItem FileSaveActive`
- `public class System.Windows.Forms.ToolStripMenuItem GrafikFlushPeriyot`
- `public class System.Windows.Forms.ToolStripMenuItem Grup`
- `public class System.Windows.Forms.ToolStripMenuItem KodRobotEkle`
- `public class System.Windows.Forms.ToolStripMenuItem MorningBarBool`
- `public class System.Windows.Forms.ToolStripMenuItem MorningVIOPBarBool`
- `public class System.Windows.Forms.ToolStripMenuItem MumGrafikTip0`
- `public class System.Windows.Forms.ToolStripMenuItem MumGrafikTip1`
- `public class System.Windows.Forms.ToolStripMenuItem MumGrafikTip2`
- `public class System.Windows.Forms.ToolStripMenuItem Pattern`
- `public class System.Windows.Forms.ToolStripComboBox PatternChange`
- `public class System.Windows.Forms.ToolStripMenuItem PatternSave`
- `public class System.Windows.Forms.ToolStripMenuItem PatternSaveas`
- `public class System.Windows.Forms.ToolStripMenuItem PortfolioBuy`
- `public class System.Windows.Forms.ToolStripMenuItem PortfolioSell`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyDataWindowOpacity`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyDonguPeriyot`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyEmirYazilarKalinlik`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyEmirYazilariGorunsun`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyEmirYazilariLokasyon`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyEmirlerGorunsun`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyEmptySpace`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyFiboRetLog0`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyFiboRetLog1`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyFiboRetTextPositionSag`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyFiboRetTextPositionSol`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyFillOpacity`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyGoruntuModGoruntu`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyGoruntuModPerformans`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyHorizontalDensity0`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyHorizontalDensity1`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyHorizontalDensity2`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyLineWidth`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyMouseWheel0`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyMouseWheel1`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyPeriod`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyPeriodHeader`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyPozisyonlarGorunsun`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyPriceWidth`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyShowLineBox`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyShowPrevClose`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyToolBarVisible`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyTopmost`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyTrendBarSayisiVisible`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyTrendEgimVisible`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyTrendPercentVisible`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyTrendReferansNo`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyTrendSkalaVisible`
- `public class System.Windows.Forms.ToolStripMenuItem PropertyTrendValueVisible`
- `public class System.Windows.Forms.ToolStripMenuItem ReadingBarCount`
- `public class ideal.MenuChart Reference`
- `public class System.Windows.Forms.ContextMenuStrip SubMenu`
- `public class System.Windows.Forms.ToolStripMenuItem ToolbarsSkalaVisible`

## ideal.MenuImkbMain

Extends: `System.Windows.Forms.Form`

Methods:
- `public void Init()`
- `public void Render()`
- `family void Dispose(bool)`

Fields:
- `public class System.Windows.Forms.ToolStripMenuItem Market`
- `public class ideal.MenuImkbMain Reference`
- `public class System.Windows.Forms.ToolStripMenuItem Seri`
- `public class System.Windows.Forms.ContextMenuStrip SubMenu`

## ideal.MenuImkbSymbol

Extends: `System.Windows.Forms.Form`

Methods:
- `public void Init()`
- `public void Init(string)`
- `public void Render()`
- `family void Dispose(bool)`

Fields:
- `public class System.Windows.Forms.ToolStripMenuItem All`
- `public class System.Windows.Forms.ToolStripComboBox ComboFilter`
- `public class ideal.MenuImkbSymbol Reference`
- `public class System.Windows.Forms.ToolStripMenuItem Stocks`
- `public class System.Windows.Forms.ContextMenuStrip SubMenu`
- `public class System.Windows.Forms.ToolStripMenuItem Varants`
- `public class System.Windows.Forms.ToolStripMenuItem XU100`
- `public class System.Windows.Forms.ToolStripMenuItem XU30`
- `public class System.Windows.Forms.ToolStripMenuItem XU50`

## ideal.MenuPortfolio

Extends: `System.Windows.Forms.Form`

Methods:
- `public void Init()`
- `public void Render()`
- `family void Dispose(bool)`

Fields:
- `public class ideal.MenuPortfolio Reference`
- `public class System.Windows.Forms.ContextMenuStrip menuCriptoOrderSub`
- `public class System.Windows.Forms.ToolStripMenuItem menuCriptoOrderSubCancel`
- `public class System.Windows.Forms.ContextMenuStrip menuImkbOrderSub`
- `public class System.Windows.Forms.ToolStripMenuItem menuImkbOrderSubActive`
- `public class System.Windows.Forms.ToolStripMenuItem menuImkbOrderSubActiveSelected`
- `public class System.Windows.Forms.ToolStripMenuItem menuImkbOrderSubAvgPriceSummarize`
- `public class System.Windows.Forms.ToolStripMenuItem menuImkbOrderSubCancel`
- `public class System.Windows.Forms.ToolStripMenuItem menuImkbOrderSubChangeSession`
- `public class System.Windows.Forms.ToolStripMenuItem menuImkbOrderSubEditOrder`
- `public class System.Windows.Forms.ToolStripMenuItem menuImkbOrderSubEditStock`
- `public class System.Windows.Forms.ToolStripMenuItem menuImkbOrderSubNotSummarize`
- `public class System.Windows.Forms.ToolStripMenuItem menuImkbOrderSubReady`
- `public class System.Windows.Forms.ToolStripMenuItem menuImkbOrderSubShowType`
- `public class System.Windows.Forms.ToolStripMenuItem menuImkbOrderSubSummarize`
- `public class System.Windows.Forms.ToolStripMenuItem menuImkbOrderSubZincir`
- `public class System.Windows.Forms.ContextMenuStrip menuImkbWaitingSub`
- `public class System.Windows.Forms.ToolStripMenuItem menuImkbWaitingSubActiveAll`
- `public class System.Windows.Forms.ToolStripMenuItem menuImkbWaitingSubCancelAll`
- `public class System.Windows.Forms.ToolStripMenuItem menuImkbWaitingSubDeleteOrder`
- `public class System.Windows.Forms.ToolStripMenuItem menuImkbWaitingSubEditOrder`
- `public class System.Windows.Forms.ToolStripMenuItem menuImkbWaitingSubSessionAll`
- `public class System.Windows.Forms.ToolStripMenuItem menuImkbWaitingSubZincir`
- `public class System.Windows.Forms.ContextMenuStrip menuPrice`
- `public class System.Windows.Forms.ToolStripMenuItem menuPriceActive`
- `public class System.Windows.Forms.ToolStripMenuItem menuPriceAsk`
- `public class System.Windows.Forms.ToolStripMenuItem menuPriceBid`
- `public class System.Windows.Forms.ToolStripComboBox menuPriceCombo`
- `public class System.Windows.Forms.ToolStripMenuItem menuPriceLast`
- `public class System.Windows.Forms.ToolStripMenuItem menuPriceLastMinus1`
- `public class System.Windows.Forms.ToolStripMenuItem menuPriceLastMinus2`
- `public class System.Windows.Forms.ToolStripMenuItem menuPriceLastMinus3`
- `public class System.Windows.Forms.ToolStripMenuItem menuPriceLastPlus1`
- `public class System.Windows.Forms.ToolStripMenuItem menuPriceLastPlus2`
- `public class System.Windows.Forms.ToolStripMenuItem menuPriceLastPlus3`
- `public class System.Windows.Forms.ToolStripMenuItem menuPriceMax`
- `public class System.Windows.Forms.ToolStripMenuItem menuPriceMin`
- `public class System.Windows.Forms.ContextMenuStrip menuRobotOrder`
- `public class System.Windows.Forms.ContextMenuStrip menuRobotPosition`
- `public class System.Windows.Forms.ContextMenuStrip menuVipOrderSub`
- `public class System.Windows.Forms.ToolStripMenuItem menuVipOrderSubCancel`
- `public class System.Windows.Forms.ToolStripMenuItem menuVipOrderSubEditOrder`

## ideal.MenuToolbarPortfoy

Extends: `System.Windows.Forms.Form`

Methods:
- `public void Init()`
- `public void Render()`
- `family void Dispose(bool)`

Fields:
- `public class System.Windows.Forms.ToolStripMenuItem BringFront`
- `public class ideal.MenuToolbarPortfoy Reference`
- `public class System.Windows.Forms.ToolStripMenuItem SendAll`
- `public class System.Windows.Forms.ToolStripMenuItem SendBuy`
- `public class System.Windows.Forms.ToolStripMenuItem SendSell`
- `public class System.Windows.Forms.ContextMenuStrip SubMenu`

## ideal.MenuVipMain

Extends: `System.Windows.Forms.Form`

Methods:
- `public void Init()`
- `public void Render()`
- `family void Dispose(bool)`

Fields:
- `public class ideal.MenuVipMain Reference`
- `public class System.Windows.Forms.ContextMenuStrip SubMenu`

## ideal.MenuVipSymbol

Extends: `System.Windows.Forms.Form`

Methods:
- `public void Init()`
- `public void Render()`
- `family void Dispose(bool)`

Fields:
- `public class System.Windows.Forms.ToolStripMenuItem All`
- `public class System.Windows.Forms.ToolStripComboBox ComboFilter`
- `public class ideal.MenuVipSymbol Reference`
- `public class System.Windows.Forms.ContextMenuStrip SubMenu`
- `public class System.Windows.Forms.ToolStripMenuItem opsiyon`
- `public class System.Windows.Forms.ToolStripMenuItem vadeli`

## ideal.NagantsRobotClass

Extends: `System.Object`

Methods:
- `public void EmirGonder(double; string)`
- `public string GetRobotKey()`
- `public void MailGonder(string)`
- `public bool PozTasiGunSembolHesapla(string&)`
- `public void SmsGonder(string; string)`

Fields:
- `public bool AcigaSatisBool`
- `public bool AksamAlisKapatBool`
- `public bool AksamPozKapatBool`
- `public string AksamPozKapatSaat`
- `public bool AksamSatisKapatBool`
- `public int AktifPasif`
- `public string AltHesap`
- `public string AnalizSembol`
- `public string BaslangicSaat`
- `public bool CumaPozKapatBool`
- `public string CumaPozKapatSaat`
- `public int GercekSanal`
- `public string Hesap`
- `public System.Collections.Generic.List`1<class ideal.RobotOrderClass> IslemList`
- `public string IslemSembol`
- `public string KapanisSaat`
- `public double Miktar`
- `public string Periyot`
- `public bool PozTasiAktif`
- `public string PozTasiIslemSembol`
- `public double Pozisyon`
- `public bool PozisyonTasiBool`
- `public int PozisyonTasiKalanGun`
- `public string PozisyonTasiSaat`
- `public string PrevSinyalTarih`
- `public long RobotID`
- `public string RunningDescription`
- `public bool RunningMode`
- `public int RunningRowNo`
- `public string SinyalTarih`
- `public string SistemName`
- `public string SonPozisyonDegistirmeZamani`
- `public bool YeniSinyalBekle`

## ideal.OrderCapacity

Extends: `System.Enum`


Fields:
- `public valuetype ideal.OrderCapacity Agency`
- `public valuetype ideal.OrderCapacity AgentForOtherMember`
- `public valuetype ideal.OrderCapacity FundOrder`
- `public valuetype ideal.OrderCapacity Individual`
- `public valuetype ideal.OrderCapacity Principal`
- `public valuetype ideal.OrderCapacity Proprietary`
- `public valuetype ideal.OrderCapacity RisklessPrincipal`
- `public int value__`

## ideal.OrderIcry

Extends: `System.Object`


Fields:
- `public System.Collections.Generic.List`1<class ideal.Asset> Assets`
- `public System.Collections.Generic.List`1<class ideal.Pairs> Pairs`
- `public string Version`

## ideal.OrderItem

Extends: `System.Object`


Properties:
- `string clientId`
- `object createdDate`
- `int id`
- `string leftQuantity`
- `string price`
- `string quantity`
- `string side`
- `string status`
- `string symbol`
- `string totalQuote`
- `string triggerPrice`
- `string type`
- `object updatedDate`

## ideal.OrderItems

Extends: `System.Object`


Fields:
- `public bool HasNextPage`
- `public bool HasPreviousPage`
- `public int IndexFrom`
- `public System.Collections.Generic.List`1<class ideal.Item> Items`
- `public int PageIndex`
- `public int PageSize`
- `public int TotalCount`
- `public int TotalPages`

## ideal.OrderRequest

Extends: `System.Object`


Properties:
- `string ClientId`
- `string Price`
- `string Quantity`
- `string Side`
- `string Symbol`
- `string Total`
- `string Type`

## ideal.OrdersHistory

Extends: `System.Object`


Fields:
- `public bool HasNextPage`
- `public bool HasPreviousPage`
- `public int IndexFrom`
- `public System.Collections.Generic.List`1<class ideal.OrdersHistoryItem> Items`
- `public int PageIndex`
- `public int PageSize`
- `public int TotalCount`
- `public int TotalPages`

## ideal.OrdersHistoryItem

Extends: `System.Object`


Fields:
- `public string ClientId`
- `public int CreatedDate`
- `public int Id`
- `public string LeftQuantity`
- `public string Price`
- `public string Quantity`
- `public string Side`
- `public string Status`
- `public string Symbol`
- `public valuetype System.Decimal Total`
- `public int TradeCount`
- `public string TriggerPrice`
- `public string Type`
- `public int UpdatedDate`

## ideal.OrderSide

Extends: `System.Enum`


Fields:
- `public valuetype ideal.OrderSide AsDefined`
- `public valuetype ideal.OrderSide Borrow`
- `public valuetype ideal.OrderSide Buy`
- `public valuetype ideal.OrderSide BuyMinus`
- `public valuetype ideal.OrderSide Cross`
- `public valuetype ideal.OrderSide CrossShort`
- `public valuetype ideal.OrderSide CrossShortExempt`
- `public valuetype ideal.OrderSide Lend`
- `public valuetype ideal.OrderSide Opposite`
- `public valuetype ideal.OrderSide Redeem`
- `public valuetype ideal.OrderSide Sell`
- `public valuetype ideal.OrderSide SellPlus`
- `public valuetype ideal.OrderSide SellShort`
- `public valuetype ideal.OrderSide SellShortExempt`
- `public valuetype ideal.OrderSide Subscribe`
- `public valuetype ideal.OrderSide Undisclosed`
- `public int value__`

## ideal.OrderStatus

Extends: `System.Enum`


Fields:
- `public valuetype ideal.OrderStatus AcceptedForBidding`
- `public valuetype ideal.OrderStatus Calculated`
- `public valuetype ideal.OrderStatus Canceled`
- `public valuetype ideal.OrderStatus DoneForDay`
- `public valuetype ideal.OrderStatus Expired`
- `public valuetype ideal.OrderStatus Filled`
- `public valuetype ideal.OrderStatus New`
- `public valuetype ideal.OrderStatus PartiallyFilled`
- `public valuetype ideal.OrderStatus PendingCancel`
- `public valuetype ideal.OrderStatus PendingNew`
- `public valuetype ideal.OrderStatus PendingReplace`
- `public valuetype ideal.OrderStatus Rejected`
- `public valuetype ideal.OrderStatus Replaced`
- `public valuetype ideal.OrderStatus Stopped`
- `public valuetype ideal.OrderStatus Suspended`
- `public int value__`

## ideal.OrderType

Extends: `System.Enum`


Fields:
- `public valuetype ideal.OrderType ForexLimit`
- `public valuetype ideal.OrderType ForexMarket`
- `public valuetype ideal.OrderType ForexPreviouslyQuoted`
- `public valuetype ideal.OrderType ForexSwap`
- `public valuetype ideal.OrderType Funari`
- `public valuetype ideal.OrderType Limit`
- `public valuetype ideal.OrderType LimitOnClose`
- `public valuetype ideal.OrderType LimitOrBetter`
- `public valuetype ideal.OrderType LimitWithOrWithout`
- `public valuetype ideal.OrderType Market`
- `public valuetype ideal.OrderType MarketIfTouched`
- `public valuetype ideal.OrderType MarketOnClose`
- `public valuetype ideal.OrderType MarketWithLeftoverAsLimit`
- `public valuetype ideal.OrderType NextFundValuationPoint`
- `public valuetype ideal.OrderType OnBasis`
- `public valuetype ideal.OrderType OnClose`
- `public valuetype ideal.OrderType Pegged`
- `public valuetype ideal.OrderType PreviousFundValuationPoint`
- `public valuetype ideal.OrderType PreviouslyIndicated`
- `public valuetype ideal.OrderType PreviouslyQuoted`
- `public valuetype ideal.OrderType Stop`
- `public valuetype ideal.OrderType StopLimit`
- `public valuetype ideal.OrderType WithOrWithout`
- `public int value__`

## ideal.ParaBirEmirClass

Extends: `System.Object`


Fields:
- `public string Aciklama`
- `public valuetype System.Decimal Fiyat`
- `public string Hesap`
- `public valuetype System.Decimal Miktar`
- `public int SanalGercek`
- `public string Sembol`
- `public string SinyalBarNo`
- `public string SinyalPatern`
- `public string SistemName`
- `public valuetype System.DateTime Tarih`

## ideal.ParaBirPozisyonClass

Extends: `System.Object`

Methods:
- `public void EmirGonder(valuetype System.Decimal)`
- `public void SmsGonder(valuetype System.Decimal)`

Fields:
- `public bool AcigaSatisBool`
- `public string Aciklama`
- `public string AltHesap`
- `public string AnalizSembol`
- `public bool GercekModBool`
- `public string Hesap`
- `public string IslemSembol`
- `public valuetype System.Decimal Miktar`
- `public valuetype System.Decimal Pozisyon`
- `public string PrevTarih`
- `public string SinyalBarNo`
- `public valuetype System.Decimal SinyalFiyat`
- `public string SinyalPatern`
- `public string SinyalTarih`
- `public string SinyalYon`
- `public string SistemName`
- `public valuetype System.Decimal SonFiyat`

## ideal.ParaViopClass

Extends: `System.Object`

Methods:
- `public void Deserialize()`
- `public void Serialize()`

Fields:
- `public int ClassVersion`
- `public System.Collections.Generic.List`1<class ideal.ParaViopEmirClass> EmirList`
- `public bool HesapGosterBool`
- `public System.Collections.Generic.List`1<string> ParaSistemList`
- `public System.Collections.Generic.Dictionary`2<string, class ideal.ParaViopPozisyonClass> PozisyonMap`
- `public bool RunningMode`
- `public class ideal.ParaViopClass Setting`
- `public bool SmsBool`
- `public string TelNo`
- `public bool YeniSinyalBool`

## ideal.ParaViopEmirClass

Extends: `System.Object`


Fields:
- `public string Aciklama`
- `public valuetype System.Decimal Fiyat`
- `public string Hesap`
- `public valuetype System.Decimal Kayma`
- `public valuetype System.Decimal Miktar`
- `public int SanalGercek`
- `public string Sembol`
- `public string SinyalBarNo`
- `public valuetype System.Decimal SinyalFiyat`
- `public string SinyalPatern`
- `public string SistemName`
- `public valuetype System.DateTime Tarih`

## ideal.ParaViopPozisyonClass

Extends: `System.Object`

Methods:
- `public void EmirGonder(valuetype System.Decimal; class ideal.ParaViopPozisyonClass)`
- `public void SmsGonder(valuetype System.Decimal)`

Fields:
- `public bool AcigaSatisBool`
- `public string Aciklama`
- `public string AltHesap`
- `public string AnalizSembol`
- `public bool GercekModBool`
- `public string Hesap`
- `public string IslemSembol`
- `public valuetype System.Decimal Miktar`
- `public valuetype System.Decimal Pozisyon`
- `public string PrevTarih`
- `public string SinyalBarNo`
- `public valuetype System.Decimal SinyalFiyat`
- `public string SinyalPatern`
- `public string SinyalTarih`
- `public string SinyalYon`
- `public string SistemName`
- `public valuetype System.Decimal SonFiyat`

## ideal.PGCKurumMaliyet

Extends: `System.Object`


Fields:
- `public System.Collections.Generic.List`1<class ideal.KurumMaliyet> Alici`
- `public double Pgc`
- `public double Pgc5Oran`
- `public double Pgc5TLOran`
- `public double PgcLot`
- `public System.Collections.Generic.List`1<class ideal.KurumMaliyet> Satici`

## ideal.PgcPozisyonClass

Extends: `System.Object`

Methods:
- `public void EmirGonder(valuetype System.Decimal)`
- `public void SmsGonder(valuetype System.Decimal)`
- `public string VeriTipToString()`

Fields:
- `public bool AcigaSatisBool`
- `public string Aciklama`
- `public bool AksamKapatBool`
- `public string AksamKapatSaat`
- `public string AltHesap`
- `public valuetype System.Decimal BreakLevel`
- `public string Durum`
- `public bool GunHacimBuyukBool`
- `public valuetype System.Decimal GunHacimBuyukVal`
- `public bool GunLotBuyukBool`
- `public valuetype System.Decimal GunLotBuyukVal`
- `public int GunStatus`
- `public bool GunYuzdeBuyukBool`
- `public valuetype System.Decimal GunYuzdeBuyukVal`
- `public bool GunYuzdeKucukBool`
- `public valuetype System.Decimal GunYuzdeKucukVal`
- `public string Hesap`
- `public valuetype System.Decimal KarAlYuzde`
- `public int KurumSayisi`
- `public double LastVal`
- `public int LotTlTip`
- `public valuetype System.Decimal Miktar`
- `public valuetype System.Decimal Pozisyon`
- `public bool PrevBool`
- `public double PrevVal`
- `public string RobotID`
- `public int SanalModTip`
- `public string Sembol`
- `public valuetype System.Decimal SinyalFiyat`
- `public string SinyalTarih`
- `public valuetype System.Decimal SonDeger`
- `public valuetype System.Decimal SonFiyat`
- `public valuetype System.Decimal StopYuzde`
- `public int SureDakika`
- `public int SureSaniye`
- `public int SureTip`
- `public int VeriTip`
- `public int YonTip`

## ideal.PortfoyAyarClass

Extends: `System.Object`

Methods:
- `public void Read()`
- `public void Write()`

Fields:
- `public string AktifFonTabName`
- `public string AktifHisseTabName`
- `public string AktifViopTabName`
- `public valuetype System.Drawing.Color BackColor`
- `public valuetype System.Drawing.Color ButtonBackColor1`
- `public valuetype System.Drawing.Color ButtonBackColor2`
- `public valuetype System.Drawing.Color ButtonBorderColor`
- `public valuetype System.Drawing.Color ButtonForeColor`
- `public System.Collections.Generic.List`1<valuetype System.Drawing.Color> ChartColorList`
- `public int ClassVersion`
- `public bool CustomBarBool`
- `public System.Collections.Generic.List`1<string> CustomBarList`
- `public bool FavoriListeBool`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldImkbOrderAlter`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldImkbOrderAta`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldImkbOrderBis`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldImkbOrderDeniz`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldImkbOrderGeneks`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldImkbOrderGtp`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldImkbOrderGtp2`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldImkbOrderIdb`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldImkbOrderIdeal`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldImkbOrderInfina`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldImkbOrderIs`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldImkbOrderQnbYat`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldImkbOrderTeb`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldImkbOrderTeb2`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldImkbOrderYatfin`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldImkbPositionAtp`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldImkbPositionBis`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldImkbPositionGeneks`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldImkbPositionGtp`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldImkbPositionGtp2`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldImkbPositionIdb`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldImkbPositionIdeal`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldImkbPositionInfina`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldImkbPositionIs`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldImkbPositionTeb`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldImkbPositionTeb2`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldImkbProfit`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldVipMaliyet`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldVipOrderBis`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldVipOrderGeneks`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldVipOrderGtp`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldVipOrderIdb`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldVipOrderInfina`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldVipOrderIs`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldVipOrderTeb2`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldVipPositionAk`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldVipPositionBis`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldVipPositionGeneks`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldVipPositionGtp`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldVipPositionIdb`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldVipPositionInfina`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldVipPositionIs`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldVipPositionMarbas`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldVipPositionTeb2`
- `public System.Collections.Generic.List`1<class ideal.FieldRec> FieldVipPositionYapi`
- `public valuetype System.Drawing.Color ForeColor`
- `public valuetype System.Drawing.Color GridAlisBackColor`
- `public valuetype System.Drawing.Color GridAlisColor`
- `public valuetype System.Drawing.Color GridAlisForeColor`
- `public valuetype System.Drawing.Color GridFlatBackColor`
- `public valuetype System.Drawing.Color GridFlatColor`
- `public valuetype System.Drawing.Color GridFlatForeColor`
- `public class System.Drawing.Font GridFont`
- `public valuetype System.Drawing.Color GridHeaderBackColor`
- `public class System.Drawing.Font GridHeaderFont`
- `public valuetype System.Drawing.Color GridHeaderForeColor`
- `public valuetype System.Drawing.Color GridNoAktifBackColor`
- `public valuetype System.Drawing.Color GridNoAktifForeColor`
- `public valuetype System.Drawing.Color GridNoPasifBackColor`
- `public valuetype System.Drawing.Color GridNoPasifForeColor`
- `public int GridSatirRenkTip`
- `public valuetype System.Drawing.Color GridSatisBackColor`
- `public valuetype System.Drawing.Color GridSatisColor`
- `public valuetype System.Drawing.Color GridSatisForeColor`
- `public valuetype System.Drawing.Color GridToplamBackColor`
- `public valuetype System.Drawing.Color GridlineColor`
- `public bool HesapListeBool`

## ideal.PortfoyGrupClass

Extends: `System.Object`

Methods:
- `public void Read()`
- `public void Write()`

Fields:
- `public System.Collections.Generic.List`1<class ideal.GrupClass> GrupList`
- `public class ideal.PortfoyGrupClass Item`
- `public System.Collections.Generic.List`1<class ideal.HesapNameClass> RumuzList`

## ideal.RiskTakasClass

Extends: `System.Object`

Methods:
- `public void Calculate()`

Fields:
- `public double AlisLot`
- `public double GunFark`
- `public double Karsilama`
- `public System.Collections.Generic.List`1<class ideal.RiskTakasClass> List`
- `public double NetLot`
- `public double SatisLot`
- `public string Sembol`
- `public double Takas`
- `public double ToplamLot`

## ideal.RiskYuksekHacimClass

Extends: `System.Object`

Methods:
- `public void Calculate()`

Fields:
- `public double AlisHacim`
- `public System.Collections.Generic.List`1<class ideal.RiskYuksekHacimClass> List`
- `public double SatisHacim`
- `public string Sembol`
- `public double SembolHacim`
- `public double ToplamHacim`
- `public double Yuzde`

## ideal.RoboEmirClass

Extends: `System.Object`

Methods:
- `public void ChangeBekleyen(string; string; valuetype System.Decimal; valuetype System.Decimal)`
- `public void CheckBekleyenEmirler()`
- `public void DeleteBekleyen(string; string; valuetype System.Decimal)`
- `public void InsertBekleyen(string; string; valuetype System.Decimal; valuetype System.Decimal; bool; valuetype System.Decimal; valuetype System.Decimal; string; string; bool)`
- `public void SendMarketOrder(class ideal.RoboEmirClass)`

Fields:
- `public string AccountName`
- `public string AccountNo`
- `public bool AcigaBool`
- `public System.Collections.Generic.List`1<class ideal.RoboEmirClass> BekleyenList`
- `public valuetype System.Decimal Fiyat`
- `public bool IzleyenBool`
- `public valuetype System.Decimal KaralFiyat`
- `public valuetype System.Decimal KaralTick`
- `public valuetype System.Decimal Lot`
- `public string Sembol`
- `public valuetype System.Decimal StopFiyat`
- `public valuetype System.Decimal StopTick`
- `public string Yon`

## ideal.RobotKorumaClass

Extends: `System.Object`


Fields:
- `public System.Collections.Generic.Dictionary`2<string, int> DefaDictionary`
- `public valuetype System.DateTime Saat`
- `public int SaniyeEmir`

## ideal.RobotOrderClass

Extends: `System.Object`


Fields:
- `public string Aciklama`
- `public string EmirAcigaSatisKapama`
- `public string EmirAksiyon`
- `public string EmirAltHesap`
- `public string EmirBitisTarih`
- `public string EmirFiyatTipi`
- `public string EmirFiyati`
- `public bool EmirGenelSatis`
- `public string EmirHesapAdi`
- `public string EmirIslem`
- `public string EmirMiktari`
- `public string EmirNo`
- `public string EmirPeriyot`
- `public bool EmirSartBool`
- `public string EmirSartFiyat`
- `public string EmirSartSembol`
- `public string EmirSartTipi`
- `public string EmirSatisTipi`
- `public string EmirSembol`
- `public string EmirStop`
- `public string EmirSuresi`
- `public string EmirTipi`
- `public string Isim`
- `public long RobotID`
- `public string SistemName`
- `public string VadeGecisSembol`

## ideal.RoboTradeClass

Extends: `System.Object`

Methods:
- `public void EmirGonder(double; string)`

Fields:
- `public bool AksamPozKapatBool`
- `public string AksamPozKapatSaat`
- `public int AktifPasif`
- `public valuetype System.Decimal AlisFiyat`
- `public string AltHesap`
- `public string BaslangicSaat`
- `public int CiftYonKullanBool`
- `public bool CumaPozKapatBool`
- `public string CumaPozKapatSaat`
- `public valuetype System.Decimal DonusKademe`
- `public string Durum`
- `public int GercekSanal`
- `public string Hesap`
- `public string Isim`
- `public System.Collections.Generic.List`1<class ideal.RobotOrderClass> IslemList`
- `public string IslemSembol`
- `public double KZ`
- `public string KapanisSaat`
- `public double Miktar`
- `public double Pozisyon`
- `public long RoboTradeID`
- `public string RunningDescription`
- `public bool RunningMode`
- `public int RunningRowNo`
- `public valuetype System.Decimal StopKademe`
- `public bool StopKullanBool`
- `public bool StoplandiBool`

## ideal.RoboTradeSettingClass

Extends: `System.Object`

Methods:
- `public void Deserialize()`
- `public void Serialize()`

Fields:
- `public System.Collections.Generic.List`1<class ideal.RoboTradeClass> RoboTradeList`
- `public class ideal.RoboTradeSettingClass Setting`

## ideal.SablonRobotClass

Extends: `System.Object`

Methods:
- `public class ideal.SablonRobotClass DeepCopy()`
- `public void EmirGonder(double; string; long)`
- `public string GetRobotKey()`
- `public void GunKzHesapla()`
- `public void MailGonder(string)`
- `public bool PozTasiGunSembolHesapla(string&)`
- `public void SmsGonder(string; string)`

Fields:
- `public bool AcigaSatisBool`
- `public bool AksamAlisKapatBool`
- `public bool AksamPozKapatBool`
- `public string AksamPozKapatSaat`
- `public bool AksamSatisKapatBool`
- `public int AktifPasif`
- `public string AltHesap`
- `public string AnalizSembol`
- `public int BarKapanmadanSaniye`
- `public bool BarKapanmadanSaniyeBool`
- `public string BaslangicSaat`
- `public bool CumaPozKapatBool`
- `public string CumaPozKapatSaat`
- `public int GercekSanal`
- `public string GunDurum`
- `public float GunKz`
- `public int GunStatus`
- `public string Hesap`
- `public System.Collections.Generic.List`1<class ideal.RobotOrderClass> IslemList`
- `public string IslemSembol`
- `public string KapanisSaat`
- `public double Miktar`
- `public string Periyot`
- `public double PortfoyGunKz`
- `public double PortfoyGunMaxKz`
- `public double PortfoyGunMinKz`
- `public double PortfoyGunStopLevel`
- `public bool PortfoyKontrolBool`
- `public bool PozTasiAktif`
- `public string PozTasiIslemSembol`
- `public double Pozisyon`
- `public bool PozisyonTasiBool`
- `public int PozisyonTasiKalanGun`
- `public string PozisyonTasiSaat`
- `public string PrevSinyalTarih`
- `public long RobotID`
- `public int RunningCount`
- `public string RunningDescription`
- `public bool RunningMode`
- `public string SinyalTarih`
- `public string SistemName`
- `public string SonPozisyonDegistirmeZamani`
- `public bool SonSinyalBool`
- `public string SonSinyalSaat`
- `public valuetype System.DateTime StartTime`

## ideal.SistemDolguClass

Extends: `System.Object`


Fields:
- `public valuetype System.Drawing.Color DownColor`
- `public int LineNo1`
- `public int LineNo2`
- `public valuetype System.Drawing.Color UpColor`

## ideal.SistemObjectClass

Extends: `System.Object`


Fields:
- `public valuetype System.Drawing.Color BackColor`
- `public int BarNo`
- `public int BarNo2`
- `public int BarNo3`
- `public int BarNo4`
- `public string FontName`
- `public int FontSizeX`
- `public valuetype System.Drawing.Color ForeColor`
- `public valuetype System.Drawing.Color FrameColor`
- `public int Height`
- `public int Kalinlik`
- `public valuetype ideal.exSistemObjectTypes ObjectType`
- `public int Panel`
- `public int PosX1`
- `public int PosY1`
- `public float PriceLevel`
- `public float PriceLevel2`
- `public float PriceLevel3`
- `public float PriceLevel4`
- `public int Stil`
- `public string Text`
- `public int Width`

## ideal.Sys_Chart_Item

Extends: `System.Object`


Properties:
- `string t`
- `string v`

## ideal.SYS_Chart_Response

Extends: `System.Object`


Properties:
- `class ideal.Sys_Chart_Item[] d`
- `string s`

## ideal.TahtaEmir1Class

Extends: `System.Object`


Fields:
- `public string Aciklama`
- `public valuetype System.Decimal Fiyat`
- `public valuetype System.Decimal Miktar`
- `public string Name`
- `public int SanalGercek`
- `public string Sembol`
- `public valuetype System.DateTime Tarih`

## ideal.TahtaEmir2Class

Extends: `System.Object`


Fields:
- `public string Aciklama`
- `public string AltHesap`
- `public valuetype System.Decimal Fiyat`
- `public string Hesap`
- `public valuetype System.Decimal Miktar`
- `public int SanalGercek`
- `public string Sembol`
- `public valuetype System.DateTime Tarih`

## ideal.TahtaRobot1Class

Extends: `System.Object`

Methods:
- `public valuetype System.Decimal KZHesapla()`

Properties:
- `valuetype System.Decimal AlisOrtalama`
- `valuetype System.Decimal Maliyet`
- `int Pozisyon`
- `valuetype System.Decimal SatisOrtalama`

Fields:
- `public string Aciklama`
- `public bool AktifBool`
- `public valuetype System.Decimal AlisHacim`
- `public int AlisLot`
- `public string AltHesap`
- `public string Hesap`
- `public string ID`
- `public valuetype System.Decimal KZ`
- `public valuetype System.Decimal KarAlNoktasi`
- `public valuetype System.Decimal KarAlYuzde`
- `public string Kurum`
- `public valuetype System.Decimal MaxPoz`
- `public string Name`
- `public valuetype System.Decimal SatisHacim`
- `public int SatisLot`
- `public string Sembol`
- `public valuetype System.Decimal SonFiyat`
- `public valuetype System.Decimal TakipOran`

## ideal.TahtaRobot2Class

Extends: `System.Object`


Properties:
- `valuetype System.Decimal AlisOrtalama`
- `valuetype System.Decimal Maliyet`
- `int Pozisyon`
- `valuetype System.Decimal SatisOrtalama`

Fields:
- `public string Aciklama`
- `public bool AktifBool`
- `public valuetype System.Decimal AlisHacim`
- `public int AlisLot`
- `public System.Collections.Generic.List`1<string> AltHesapList`
- `public valuetype System.Decimal HedefFiyat`
- `public System.Collections.Generic.List`1<string> HesapList`
- `public valuetype System.Decimal MaxPoz`
- `public System.Collections.Generic.List`1<int> MiktarList`
- `public valuetype System.Decimal SatisHacim`
- `public int SatisLot`
- `public string Sembol`
- `public valuetype System.Decimal SonFiyat`

## ideal.TaramaEmirClass

Extends: `System.Object`


Fields:
- `public string Aciklama`
- `public System.Collections.Generic.List`1<class ideal.TaramaEmirClass> EmirList`
- `public valuetype System.Decimal Fiyat`
- `public string Hesap`
- `public valuetype System.Decimal Miktar`
- `public string Periyot`
- `public int SanalGercek`
- `public string Sembol`
- `public string Tarama`
- `public valuetype System.DateTime Tarih`

## ideal.TaramaPozisyonClass

Extends: `System.Object`


Fields:
- `public string Aciklama`
- `public valuetype System.Decimal AlisFiyat`
- `public valuetype System.Decimal AlisMiktar`
- `public valuetype System.DateTime AlisTarih`
- `public valuetype System.Decimal IzleyenFiyat`
- `public valuetype System.Decimal Miktar`
- `public valuetype System.Decimal Pozisyon`
- `public valuetype System.Decimal SatisFiyat`
- `public valuetype System.DateTime SatisTarih`
- `public string Sembol`
- `public bool SeviyeIzleyenAktif`
- `public valuetype System.Decimal SonFiyat`
- `public string Tarama`

## ideal.TaramaRobotSettingClass

Extends: `System.Object`

Methods:
- `public void Deserialize()`
- `public class ideal.TaramaPozisyonClass GetPozisyon(string; string)`
- `public void Serialize()`
- `public void SetPozisyon(string; string; class ideal.TaramaPozisyonClass)`

Fields:
- `public bool AksamKarKapatBool`
- `public int AksamKarKapatGun`
- `public string AksamKarKapatSaat`
- `public bool AksamPozKapatBool`
- `public string AksamPozKapatSaat`
- `public bool AksamZararKapatBool`
- `public int AksamZararKapatGun`
- `public string AksamZararKapatSaat`
- `public string AltHesap`
- `public System.Collections.Generic.Dictionary`2<string, class ideal.TaramaRobotSettingClass> AyarDict`
- `public string BaslangicSaat`
- `public bool EndeksBuyukAlmaBool`
- `public string EndeksBuyukAlmaSembol`
- `public valuetype System.Decimal EndeksBuyukAlmaVal`
- `public bool EndeksBuyukKapatBool`
- `public int EndeksBuyukKapatGun`
- `public string EndeksBuyukKapatSembol`
- `public valuetype System.Decimal EndeksBuyukKapatVal`
- `public bool EndeksKucukAlmaBool`
- `public string EndeksKucukAlmaSembol`
- `public valuetype System.Decimal EndeksKucukAlmaVal`
- `public bool EndeksKucukKapatBool`
- `public int EndeksKucukKapatGun`
- `public string EndeksKucukKapatSembol`
- `public valuetype System.Decimal EndeksKucukKapatVal`
- `public bool GundeBirKere`
- `public string Hesap`
- `public int HisseMaxTarama`
- `public valuetype System.Decimal IzleyenYuzde`
- `public int KapanisCanliBar`
- `public string KapanisSaat`
- `public valuetype System.Decimal KarAlYuzde`
- `public bool KardaPozKapatBool`
- `public int KardaPozKapatDakika`
- `public bool KodlaKapatBool`
- `public string KodlaKapatPeriyot`
- `public string KodlaKapatSistem`
- `public valuetype System.Decimal MaxHisseFiyat`
- `public int MaxPozisyon`
- `public valuetype System.Decimal MinHisseFiyat`
- `public bool ModifiedBool`
- `public bool PozisyonKapanincaIslemAcmaBool`
- `public int PozisyonKapanincaIslemAcmaDakika`
- `public System.Collections.Generic.Dictionary`2<string, class ideal.TaramaPozisyonClass> Pozisyonlar`
- `public bool RunningMode`
- `public int RunningRowNo`
- `public string RunningSembol`
- `public int RunningSure`
- `public string RunningTarama`
- `public int SanalGercek`
- `public System.Collections.Generic.List`1<string> SembolList`
- `public class ideal.TaramaRobotSettingClass Setting`
- `public bool SeviyeIzleyenBool`
- `public valuetype System.Decimal SeviyeIzleyenStop`
- `public valuetype System.Decimal SeviyeIzleyenYuzde`
- `public bool SistemleKapatBool`
- `public bool SurePozKapatBool`
- `public int SurePozKapatDakika`
- `public valuetype System.Decimal TL`
- `public System.Collections.Generic.List`1<string> TaramaList`
- `public bool YukseldiyseBool`
- `public valuetype System.Decimal YukseldiyseYuzde`

## ideal.TradeBotColorPriceClass

Extends: `System.Object`


Fields:
- `public short PriceType`
- `public string Yon`

## ideal.TradeBotEmirClass

Extends: `System.Object`

Methods:
- `public void ClaculateKarALStop()`

Properties:
- `bool AcigaBool`
- `valuetype System.Decimal AmountMO`
- `valuetype System.Decimal AmountSL`
- `valuetype System.Decimal AmountTP`
- `valuetype System.Decimal BalanceMO`
- `valuetype System.Decimal BalanceSL`
- `valuetype System.Decimal BalanceTP`
- `string BuySell`
- `string Direction`
- `string ExceuteOrderNo`
- `string ExecutionStatusMO`
- `string ExecutionStatusSL`
- `string ExecutionStatusTP`
- `valuetype System.Decimal GAmountMO`
- `valuetype System.Decimal GAmountSL`
- `valuetype System.Decimal GAmountTP`
- `valuetype System.Decimal GpriceMO`
- `valuetype System.Decimal GpriceSL`
- `valuetype System.Decimal GpriceTP`
- `bool IzleyenBool`
- `string OrderNo`
- `valuetype System.Decimal PriceMO`
- `valuetype System.Decimal PriceSL`
- `valuetype System.Decimal PriceTP`
- `string Root`
- `string SLOrderNo`
- `valuetype System.Decimal SPTick`
- `string Symbol`
- `string TPOrderNo`
- `valuetype System.Decimal TPTick`
- `valuetype ideal.TradeBotStatus TradeOderStatus`
- `string Yon`

## ideal.TradeBotOrderType

Extends: `System.Enum`


Fields:
- `public valuetype ideal.TradeBotOrderType Limit`
- `public valuetype ideal.TradeBotOrderType Piyasa`
- `public int value__`

## ideal.View.formViopKurumHacim

Extends: `System.Windows.Forms.Form`

Methods:
- `public void ConvertOldToNew(string)`
- `family void Dispose(bool)`

Fields:
- `public class System.Windows.Forms.ContextMenuStrip menu`

## ideal.View.ViewFon.formFonGrafik

Extends: `ideal.FormControl`

Methods:
- `public void ApplyPattern(class Pgc)`
- `public class System.Drawing.StringFormat CellHizala(string)`
- `public void ChangeColors(class ideal.cxColorEditor)`
- `public byte[] ConvertPageToByteArray()`
- `public void ProcessMenuMessage(string)`
- `family void Dispose(bool)`
- `family void OnPaintBackground(class System.Windows.Forms.PaintEventArgs)`
- `family bool ProcessCmdKey(valuetype System.Windows.Forms.Message&; valuetype System.Windows.Forms.Keys)`

Fields:
- `public string ActiveSymbol`
- `public short PgcGosterim`

## ideal.View.ViewFon.RangeTrackBar

Extends: `System.Windows.Forms.Control`

Methods:
- `family void OnMouseDown(class System.Windows.Forms.MouseEventArgs)`
- `family void OnMouseMove(class System.Windows.Forms.MouseEventArgs)`
- `family void OnMouseUp(class System.Windows.Forms.MouseEventArgs)`
- `family void OnPaint(class System.Windows.Forms.PaintEventArgs)`

Properties:
- `int MaxValue`
- `int MinValue`
- `int SelectedMax`
- `int SelectedMin`

## ideal.ViewPortfolio.formRedirectUri

Extends: `System.Windows.Forms.Form`

Methods:
- `public string IncomingReq(string)`
- `family void Dispose(bool)`

Fields:
- `public class AccountRecord Account`
- `public string accessTokenUrl`
- `public string authTokenUrl`
- `public string clientId`
- `public string clientSecret`
- `public string redirectUri`
- `public class ideal.formHCBCWebLogin reference`
- `public string userInfoUrl`

## IDealOrderType

Extends: `System.Enum`


Fields:
- `public valuetype IDealOrderType Arbitraj`
- `public valuetype IDealOrderType EgzotikRobot`
- `public valuetype IDealOrderType ExecutionAlgo`
- `public valuetype IDealOrderType GridBot`
- `public valuetype IDealOrderType Normal`
- `public valuetype IDealOrderType OtoTrade`
- `public valuetype IDealOrderType PacalBot`
- `public valuetype IDealOrderType RoboTrade`
- `public valuetype IDealOrderType Robot`
- `public valuetype IDealOrderType TaramaRobot`
- `public valuetype IDealOrderType TrendAlarm`
- `public valuetype IDealOrderType TrendBot`
- `public valuetype IDealOrderType YatayBot`
- `public valuetype IDealOrderType iDealGo`
- `public int value__`

## ImkbOrderRecord

Extends: `System.Object`


Properties:
- `string OrderNoString`

Fields:
- `public string AccountName`
- `public string AccountNo`
- `public string AmendPermit`
- `public double Amount`
- `public double AmountShowing`
- `public double Balance`
- `public string BorsaRefNo`
- `public string BuySell`
- `public string CancelPermit`
- `public int EmirUpdateNum`
- `public string ExecutionStatus`
- `public double GAmount`
- `public double GPrice`
- `public string GSaat`
- `public double GTotal`
- `public string ImprovePermit`
- `public string LongAccountName`
- `public int MaxZincirSiraNo`
- `public string Note`
- `public string OneSessionPermit`
- `public string OrderDate`
- `public string OrderEndDate`
- `public string OrderNo`
- `public string OrderPermit`
- `public string OrderRef`
- `public string OrderSessionNo`
- `public string OrderType`
- `public string OrderUpdateDate`
- `public double Price`
- `public string RefNo`
- `public string SatisTip`
- `public byte Selected`
- `public string Session`
- `public string SessionName`
- `public int SiraNo`
- `public string Status`
- `public string StatusCode`
- `public string Symbol`
- `public double Total`
- `public string Validity`
- `public string ValorDate`
- `public string ZincirRef`

## ImkbPositionRecord

Extends: `System.Object`


Properties:
- `double Profit`
- `double ProfitYuzde`
- `double TotalTL`

Fields:
- `public string AltHesap`
- `public string AssetType`
- `public string BalanceType`
- `public double Bloke`
- `public double Cost`
- `public string DovizCinsi`
- `public double DovizDegeri`
- `public string HesapName`
- `public double LastPrice`
- `public double Lot`
- `public double LotT1`
- `public double LotT2`
- `public string PortfolioType`
- `public double PortfoyOran`
- `public double Price`
- `public double ProfitX`
- `public string Rumuz`
- `public double Sellable`
- `public string Symbol`
- `public double Total`
- `public double avgPrice`
- `public double balanceT`
- `public double balanceT1`
- `public double balanceT2`
- `public double balanceT3`
- `public double currentAmount`
- `public string depotCode`
- `public string equityType`
- `public string uniqueSymbol`

## ImkbStatementRecord

Extends: `System.Object`


Fields:
- `public double Balance`
- `public double Credit`
- `public double Debt`
- `public string Description`
- `public string ProcessDate`
- `public string ValorDate`

## ImkbTransactionReport

Extends: `System.Object`


Fields:
- `public string AccountNo`
- `public double BSMV`
- `public int BuyLot`
- `public string BuySell`
- `public double BuyTotalTL`
- `public double Commission`
- `public double CommissionAmount`
- `public double Price`
- `public string ProcessDate`
- `public int SellLot`
- `public double SellTotalTL`
- `public string Symbol`

## ImkbVolume

Extends: `System.Object`

Methods:
- `public void Write()`

Fields:
- `public modreq ET_0x82 ReceiverList`

## ImkbWaitingRecord

Extends: `System.Object`


Fields:
- `public double Amount`
- `public double Balance`
- `public string BuySell`
- `public double GAmount`
- `public double GPrice`
- `public double GTotal`
- `public System.Collections.Generic.List`1<string> OrderNoList`
- `public string OrderRef`
- `public double Price`
- `public string SessionName`
- `public string Status`
- `public string Symbol`
- `public double Total`

## KurumHacimRecord

Extends: `System.Object`


Fields:
- `public string Broker`
- `public string Broker`
- `public int KurumId`
- `public int KurumId`
- `public double VolumeBuy`
- `public double VolumeBuy`
- `public double VolumeBuyP`
- `public double VolumeBuyP`
- `public double VolumeDif`
- `public double VolumeDif`
- `public double VolumeDifP`
- `public double VolumeDifP`
- `public double VolumeSell`
- `public double VolumeSell`
- `public double VolumeSellP`
- `public double VolumeSellP`
- `public double VolumeSum`
- `public double VolumeSum`
- `public double VolumeSumP`
- `public double VolumeSumP`

## KurumHacimRecord

Extends: `System.Object`


Fields:
- `public string Broker`
- `public string Broker`
- `public int KurumId`
- `public int KurumId`
- `public double VolumeBuy`
- `public double VolumeBuy`
- `public double VolumeBuyP`
- `public double VolumeBuyP`
- `public double VolumeDif`
- `public double VolumeDif`
- `public double VolumeDifP`
- `public double VolumeDifP`
- `public double VolumeSell`
- `public double VolumeSell`
- `public double VolumeSellP`
- `public double VolumeSellP`
- `public double VolumeSum`
- `public double VolumeSum`
- `public double VolumeSumP`
- `public double VolumeSumP`

## KurumRec1

Extends: `System.Object`


Fields:
- `public double BuyLot`
- `public double BuyVol`
- `public int KurumId`
- `public double Maliyet`
- `public double Miktar`
- `public double NetLot`
- `public double NetVol`
- `public double SellLot`
- `public double SellVol`
- `public double Yuzde`

## KurumRecord

Extends: `System.Object`


Fields:
- `public byte Hour`
- `public byte Minute`
- `public float NetLot`
- `public float NetVol`
- `public int SembolId`

## KurumStruct

Extends: `System.ValueType`


Fields:
- `public byte Hour`
- `public byte Minute`
- `public float NetLot`
- `public float NetVol`
- `public int SembolId`

## MusteriHesapOzetiData

Extends: `System.Object`


Properties:
- `class Menkulkiymet[] menkulKiymet`
- `class Menkulkiymetturklirasi[] menkulKiymetTurkLirasi`
- `class Toplamoverall[] toplamOverall`
- `class ViopPozisyon[] viopPozisyon`

## MusteriHesapOzetiReq

Extends: `System.Object`


Properties:
- `string tarih`

## MusteriHesapOzetiResponse

Extends: `System.Object`


Properties:
- `class MusteriHesapOzetiData data`
- `object message`
- `int statusCode`
- `bool success`

## NewOrder

Extends: `ideal.IdealMessage`


Properties:
- `string Account`
- `System.Nullable`1<valuetype ideal.AccountType> AccountType`
- `bool OffHoursTrading`
- `System.Nullable`1<valuetype ideal.OrderCapacity> OrderCapacity`
- `valuetype ideal.OrderSide OrderSide`
- `valuetype ideal.OrderType OrderType`
- `string OrderUuid`
- `System.Nullable`1<double> Price`
- `double Quantity`
- `string Symbol`
- `valuetype ideal.TimeInForce TimeInForce`

## NewOrderResult

Extends: `System.Object`


Properties:
- `string avgPrice`
- `string avgPrice`
- `string clientOrderId`
- `string clientOrderId`
- `bool closePosition`
- `bool closePosition`
- `string cumQty`
- `string cumQty`
- `string cumQuote`
- `string cumQuote`
- `string executedQty`
- `string executedQty`
- `long orderId`
- `long orderId`
- `string origQty`
- `string origQty`
- `string origType`
- `string origType`
- `string positionSide`
- `string positionSide`
- `string price`
- `string price`
- `bool priceProtect`
- `bool priceProtect`
- `bool reduceOnly`
- `bool reduceOnly`
- `string side`
- `string side`
- `string status`
- `string status`
- `string stopPrice`
- `string stopPrice`
- `string symbol`
- `string symbol`
- `string timeInForce`
- `string timeInForce`
- `string type`
- `string type`
- `long updateTime`
- `long updateTime`
- `string workingType`
- `string workingType`

## NewOrderResult

Extends: `System.Object`


Properties:
- `string avgPrice`
- `string avgPrice`
- `string clientOrderId`
- `string clientOrderId`
- `bool closePosition`
- `bool closePosition`
- `string cumQty`
- `string cumQty`
- `string cumQuote`
- `string cumQuote`
- `string executedQty`
- `string executedQty`
- `long orderId`
- `long orderId`
- `string origQty`
- `string origQty`
- `string origType`
- `string origType`
- `string positionSide`
- `string positionSide`
- `string price`
- `string price`
- `bool priceProtect`
- `bool priceProtect`
- `bool reduceOnly`
- `bool reduceOnly`
- `string side`
- `string side`
- `string status`
- `string status`
- `string stopPrice`
- `string stopPrice`
- `string symbol`
- `string symbol`
- `string timeInForce`
- `string timeInForce`
- `string type`
- `string type`
- `long updateTime`
- `long updateTime`
- `string workingType`
- `string workingType`

## OpenOrder

Extends: `System.Object`


Properties:
- `string avgPrice`
- `string avgPrice`
- `string clientOrderId`
- `string clientOrderId`
- `bool closePosition`
- `bool closePosition`
- `string cumQuote`
- `string cumQuote`
- `string executedQty`
- `string executedQty`
- `long orderId`
- `long orderId`
- `string origQty`
- `string origQty`
- `string origType`
- `string origType`
- `string positionSide`
- `string positionSide`
- `string price`
- `string price`
- `bool priceProtect`
- `bool priceProtect`
- `bool reduceOnly`
- `bool reduceOnly`
- `string side`
- `string side`
- `string status`
- `string status`
- `string stopPrice`
- `string stopPrice`
- `string symbol`
- `string symbol`
- `long time`
- `long time`
- `string timeInForce`
- `string timeInForce`
- `string type`
- `string type`
- `long updateTime`
- `long updateTime`
- `string workingType`
- `string workingType`

## OpenOrder

Extends: `System.Object`


Properties:
- `string avgPrice`
- `string avgPrice`
- `string clientOrderId`
- `string clientOrderId`
- `bool closePosition`
- `bool closePosition`
- `string cumQuote`
- `string cumQuote`
- `string executedQty`
- `string executedQty`
- `long orderId`
- `long orderId`
- `string origQty`
- `string origQty`
- `string origType`
- `string origType`
- `string positionSide`
- `string positionSide`
- `string price`
- `string price`
- `bool priceProtect`
- `bool priceProtect`
- `bool reduceOnly`
- `bool reduceOnly`
- `string side`
- `string side`
- `string status`
- `string status`
- `string stopPrice`
- `string stopPrice`
- `string symbol`
- `string symbol`
- `long time`
- `long time`
- `string timeInForce`
- `string timeInForce`
- `string type`
- `string type`
- `long updateTime`
- `long updateTime`
- `string workingType`
- `string workingType`

## OpenOrderIcry

Extends: `System.Object`


Fields:
- `public System.Collections.Generic.List`1<class Assets> Assets`
- `public System.Collections.Generic.List`1<class Pair> Pairs`
- `public string Version`

## OrderHistory

Extends: `System.Object`


Properties:
- `string avgPrice`
- `string avgPrice`
- `string clientOrderId`
- `string clientOrderId`
- `bool closePosition`
- `bool closePosition`
- `string cumQuote`
- `string cumQuote`
- `string executedQty`
- `string executedQty`
- `object orderId`
- `object orderId`
- `string origQty`
- `string origQty`
- `string origType`
- `string origType`
- `string positionSide`
- `string positionSide`
- `string price`
- `string price`
- `bool priceProtect`
- `bool priceProtect`
- `bool reduceOnly`
- `bool reduceOnly`
- `string side`
- `string side`
- `string status`
- `string status`
- `string stopPrice`
- `string stopPrice`
- `string symbol`
- `string symbol`
- `long time`
- `long time`
- `string timeInForce`
- `string timeInForce`
- `string type`
- `string type`
- `object updateTime`
- `object updateTime`
- `string workingType`
- `string workingType`

## OrderHistory

Extends: `System.Object`


Properties:
- `string avgPrice`
- `string avgPrice`
- `string clientOrderId`
- `string clientOrderId`
- `bool closePosition`
- `bool closePosition`
- `string cumQuote`
- `string cumQuote`
- `string executedQty`
- `string executedQty`
- `object orderId`
- `object orderId`
- `string origQty`
- `string origQty`
- `string origType`
- `string origType`
- `string positionSide`
- `string positionSide`
- `string price`
- `string price`
- `bool priceProtect`
- `bool priceProtect`
- `bool reduceOnly`
- `bool reduceOnly`
- `string side`
- `string side`
- `string status`
- `string status`
- `string stopPrice`
- `string stopPrice`
- `string symbol`
- `string symbol`
- `long time`
- `long time`
- `string timeInForce`
- `string timeInForce`
- `string type`
- `string type`
- `object updateTime`
- `object updateTime`
- `string workingType`
- `string workingType`

## OrderRecord

Extends: `System.Object`


Fields:
- `public string Buyer`
- `public string Buyer`
- `public byte Hour`
- `public byte Hour`
- `public int Lot`
- `public int Lot`
- `public byte Minute`
- `public byte Minute`
- `public string OrderNo`
- `public string OrderNo`
- `public float Price`
- `public float Price`
- `public byte Second`
- `public byte Second`
- `public string Seller`
- `public string Seller`
- `public string Stock`
- `public string Stock`
- `public double VolOrj`

## OrderRecord

Extends: `System.Object`


Fields:
- `public string Buyer`
- `public string Buyer`
- `public byte Hour`
- `public byte Hour`
- `public int Lot`
- `public int Lot`
- `public byte Minute`
- `public byte Minute`
- `public string OrderNo`
- `public string OrderNo`
- `public float Price`
- `public float Price`
- `public byte Second`
- `public byte Second`
- `public string Seller`
- `public string Seller`
- `public string Stock`
- `public string Stock`
- `public double VolOrj`

## OrderReport

Extends: `NewOrder`


Properties:
- `System.Nullable`1<double> BuyPrice`
- `System.Nullable`1<double> ExecutedQuantity`
- `System.Nullable`1<double> FilledQuantity`
- `int OrderId`
- `string OrderSendingTime`
- `valuetype ideal.OrderStatus OrderStatus`
- `System.Nullable`1<int> OriginalOrderId`
- `string RejectReason`
- `string TransactionTime`

## Portfoy

Extends: `System.Object`


Fields:
- `public System.Collections.Generic.List`1<class BalanceHistoryRecord> BalanceHistoryList`
- `public double Baslangict`
- `public double BaslangictTakas`
- `public System.Collections.Generic.List`1<class CriptoBinanceAcoountSnapShotRrebord> CriptoBinanceAcoountSnapsotList`
- `public class AccountInformation CriptoFutureAccountInformation`
- `public System.Collections.Generic.List`1<class Asset> CriptoFutureAssetList`
- `public class CurrentMultiAssetMode CriptoFutureCurrentMultiAssetMode`
- `public class ExchangeInformation CriptoFutureExchangeInformation`
- `public System.Collections.Generic.List`1<class Leverage> CriptoFutureLeverageLimits`
- `public System.Collections.Generic.List`1<class OpenOrder> CriptoFutureOpenOrders`
- `public System.Collections.Generic.List`1<class OrderHistory> CriptoFutureOrderHistory`
- `public System.Collections.Generic.List`1<class Position> CriptoFuturePositions`
- `public System.Collections.Generic.List`1<class TradeHistory> CriptoFutureTradeHistory`
- `public System.Collections.Generic.List`1<class TransactionHistory> CriptoFutureTransactionHistory`
- `public System.Collections.Generic.List`1<class CriptoOrderRecord> CriptoOrderList`
- `public System.Collections.Generic.List`1<class CriptoPositionRecord> CriptoPositionList`
- `public System.Collections.Generic.List`1<class CriptoTradeRecord> CriptoTradeList`
- `public double DovizBakiye`
- `public double FifoMaliyet`
- `public System.Collections.Generic.List`1<class FonIslemRecord> FonIslemList`
- `public System.Collections.Generic.Dictionary`2<string, string> FonKurucuDict`
- `public System.Collections.Generic.List`1<class FonPositionRecord> FonPositionList`
- `public System.Collections.Generic.List`1<class FonTanimRecord> FonTanimList`
- `public double GayriNakdiTeminat`
- `public System.Collections.Generic.List`1<class OpenOrder> IcrypexFutureOpenOrders`
- `public System.Collections.Generic.List`1<class Assets> IcrypexFutureeAssetList`
- `public double ImkbBakiyeFarkNet`
- `public double ImkbBakiyeFarkYuzde`
- `public double ImkbCariBakiye`
- `public System.Collections.Generic.Dictionary`2<string, string> ImkbCreditStatusDictionary`
- `public System.Collections.Generic.Dictionary`2<string, string> ImkbEquitySummaryDictionary`
- `public double ImkbKrediBorcu`
- `public double ImkbKrediDahilLimit`
- `public double ImkbKrediRiskBakiyesi`
- `public double ImkbLimit`
- `public double ImkbOncekiBakiye`
- `public System.Collections.Generic.List`1<class ImkbOrderRecord> ImkbOrderList`
- `public double ImkbOverall`
- `public System.Collections.Generic.List`1<class ImkbPositionRecord> ImkbPositionList`
- `public System.Collections.Generic.Dictionary`2<string, string> ImkbRiskDictionary`
- `public double ImkbSonBakiye`
- `public System.Collections.Generic.List`1<class ImkbStatementRecord> ImkbStatementList`
- `public System.Collections.Generic.Dictionary`2<string, double> ImkbStockLimitDictionary`
- `public System.Collections.Generic.Dictionary`2<string, double> ImkbStockSellableDictionary`
- `public System.Collections.Generic.Dictionary`2<string, string> ImkbSummaryDictionary`
- `public System.Collections.Generic.List`1<class ImkbTransactionReport> ImkbTransactionReports`
- `public double KullanilanPortfoyDegeri`
- `public double MaksimumPortfoyDegerLimit`
- `public double NetMaliyet`
- `public string ReturnMessageStr`
- `public double StopOutRiskOrani`
- `public double ToplamFifoMaliyet`
- `public double ToplamNetMaliyet`
- `public double ToplamTeminat`
- `public System.Collections.Generic.List`1<class VarlikRecord> VarlikList`
- `public double ViopDigerTeminat`
- `public double ViopExercieTeminat`
- `public double ViopFifoMaliyet`
- `public double ViopInterspreadTeminat`
- `public double ViopMaxEmirFuture`
- `public double ViopMaxEmirOpsion`
- `public double ViopNakitTeminat`
- `public double ViopNetMaliyet`
- `public double ViopOpsiyonPrim`
- `public double ViopOpsiyonPrimToplam`
- `public double ViopOpsiyonPrimiNet`
- `public double ViopPozisyonTeminat`
- `public double ViopPozlimit`
- `public double ViopProfitLoss`
- `public double ViopRiskOranı`
- `public double ViopScenerioTeminat`
- `public double ViopSpanKontrolOran`
- `public double ViopTeminatBaslangic`
- `public double ViopTeminatCagri`
- `public double ViopTeminatCekilebilir`
- `public double ViopTeminatKullanilabilir`
- `public double ViopTeminatSurdurme`
- `public double ViopTeminatToplam`
- `public modreq ET_0x82 VipAcikString`
- `public System.Collections.Generic.Dictionary`2<string, string> VipCollateralDictionary`

## Position

Extends: `System.Object`


Properties:
- `string entryPrice`
- `string entryPrice`
- `string isAutoAddMargin`
- `string isAutoAddMargin`
- `string isolatedMargin`
- `string isolatedMargin`
- `string isolatedWallet`
- `string isolatedWallet`
- `string leverage`
- `string leverage`
- `string liquidationPrice`
- `string liquidationPrice`
- `string marginType`
- `string marginType`
- `string markPrice`
- `string markPrice`
- `string maxNotionalValue`
- `string maxNotionalValue`
- `string notional`
- `string notional`
- `string positionAmt`
- `string positionAmt`
- `string positionSide`
- `string positionSide`
- `string symbol`
- `string symbol`
- `string unRealizedProfit`
- `string unRealizedProfit`
- `object updateTime`
- `object updateTime`

## Position

Extends: `System.Object`


Properties:
- `string entryPrice`
- `string entryPrice`
- `string isAutoAddMargin`
- `string isAutoAddMargin`
- `string isolatedMargin`
- `string isolatedMargin`
- `string isolatedWallet`
- `string isolatedWallet`
- `string leverage`
- `string leverage`
- `string liquidationPrice`
- `string liquidationPrice`
- `string marginType`
- `string marginType`
- `string markPrice`
- `string markPrice`
- `string maxNotionalValue`
- `string maxNotionalValue`
- `string notional`
- `string notional`
- `string positionAmt`
- `string positionAmt`
- `string positionSide`
- `string positionSide`
- `string symbol`
- `string symbol`
- `string unRealizedProfit`
- `string unRealizedProfit`
- `object updateTime`
- `object updateTime`

## PositionClass

Extends: `System.Object`


Fields:
- `public float Change`
- `public valuetype System.DateTime Date`
- `public string Direction`
- `public float LastPrice`
- `public float Percent`
- `public string Symbol`
- `public float TradePrice`

## PositionInfo

Extends: `System.Object`


Fields:
- `public double GAmount`
- `public double GPrice`
- `public double Price`
- `public string Symbol`
- `public string buySell`

## PozisyonClass

Extends: `System.Object`


Fields:
- `public valuetype System.Decimal Mailyet`
- `public int Pozisyon`
- `public string Sembol`
- `public string Tip`
- `public string Yon`
- `public valuetype System.Decimal kz`

## ReqArtioxCancelOrder

Extends: `System.Object`


Properties:
- `string client_ip`
- `class Cookie cookie`
- `int order_id`
- `string order_type`
- `int[] pair_id`
- `string sid`

## ReqArtioxChart

Extends: `System.Object`


Properties:
- `int limit`
- `int[] pair_id`
- `string zoom_level`

## ReqArtioxOrderBook

Extends: `System.Object`


Properties:
- `int limit`
- `int[] pair_id`

## ReqArtioxSendOrder

Extends: `System.Object`


Properties:
- `float amount`
- `string client_ip`
- `class Cookie cookie`
- `string order_type`
- `int[] pair_id`
- `float price`
- `string sid`

## ReqEquityChainSendOrder

Extends: `System.Object`


Properties:
- `string accountId`
- `bool chainOrder`
- `string clOrdId`
- `bool closeShortSell`
- `string instrumentSymbol`
- `string instrumentType`
- `string marketSegmentAlert`
- `string orderTypeId`
- `string parentOrderId`
- `double price`
- `double qty`
- `string sideId`
- `string timeInForceId`
- `string token`
- `long tokenVersion`

## ReqEquitySendOrder

Extends: `System.Object`


Properties:
- `string accountId`
- `string appCode`
- `string appPassword`
- `string clOrdId`
- `bool closeShortSell`
- `string instrumentSymbol`
- `string instrumentType`
- `string marketSegmentAlert`
- `double maxFloor`
- `string orderTypeId`
- `double price`
- `double qty`
- `string sideId`
- `string timeInForceId`
- `string token`
- `string tokenVersion`
- `string uniqueSymbol`

## ReqFutOptSendOrder

Extends: `System.Object`


Properties:
- `string accountId`
- `string appCode`
- `string appPassword`
- `string clOrdId`
- `string endDate`
- `string instrumentSymbol`
- `string orderTypeId`
- `double price`
- `double qty`
- `string sideId`
- `string timeInForceId`
- `string token`
- `string tokenVersion`
- `string tradingSessionId`

## ReqFutOptTriggerSendOrder

Extends: `System.Object`


Properties:
- `string accountId`
- `string appCode`
- `string appPassword`
- `string clOrdId`
- `string endDate`
- `string instrumentSymbol`
- `string orderTypeId`
- `double price`
- `double qty`
- `string sideId`
- `string timeInForceId`
- `string token`
- `string tokenVersion`
- `string tradingSessionId`
- `bool triggerOrder`
- `string triggerPrice`
- `string triggerPriceDirectionId`
- `string triggerPriceTypeId`
- `string triggerSymbol`
- `string triggerTypeId`

## ResArtioxCancelOrder

Extends: `System.Object`


Properties:
- `int code`
- `bool is_okay`
- `string message`

## ResArtioxOrder

Extends: `System.Object`


Properties:
- `float amount`
- `bool commission_free`
- `long creation_time`
- `int id`
- `float init_amount`
- `string kind`
- `object order_to_cancel`
- `int[] pair_id`
- `float percent`
- `float price`
- `string status`
- `string type`
- `int user_id`

## ResArtioxOrderBook

Extends: `System.Object`


Properties:
- `float amount`
- `float price`
- `string type`

## ResArtioxSendOrder

Extends: `System.Object`


Properties:
- `float amount`
- `int code`
- `bool is_okay`
- `string message`
- `string symbol`
- `string type`

## ResEquityOrder

Extends: `System.Object`


Properties:
- `object errorCode`
- `object errorDescription`
- `bool ok`
- `string transactionId`
- `string value`

## RobotPositionClass

Extends: `System.Object`


Fields:
- `public double Position`
- `public string Rezerv`
- `public double SonIslemFiyat`
- `public valuetype System.DateTime SonIslemTarih`

## SenetHacimRecord

Extends: `System.Object`

Methods:
- `public void Hesapla()`

Fields:
- `public double AlisHacim`
- `public double AlisLot`
- `public double Maliyet`
- `public double NetHacim`
- `public double NetLot`
- `public double SatisHacim`
- `public double SatisLot`
- `public string Stock`
- `public double ToplamHacim`
- `public double ToplamLot`
- `public double Yuzde`

## SistemMultiRecord

Extends: `System.Object`


Fields:
- `public valuetype System.Drawing.Color Color`
- `public bool Enabled`
- `public string SistemName`

## SorguClass

Extends: `System.Object`


Fields:
- `public string Aciklama`
- `public valuetype System.Drawing.Color AciklamaYaziRengi`
- `public valuetype System.Drawing.Color AciklamaZeminRengi`
- `public object[] Deger`
- `public int No`
- `public string Periyot`
- `public string Symbol`
- `public valuetype System.Drawing.Color[] YaziRenk`
- `public valuetype System.Drawing.Color[] ZeminRenk`

## StockCancelledOrder

Extends: `System.Object`


Properties:
- `class StockCancelledOrderData data`
- `object message`
- `int statusCode`
- `bool success`

## StockCancelledOrderData

Extends: `System.Object`


Properties:
- `class StockCancelledOrderList[] list`

## StockCancelledOrderList

Extends: `System.Object`


Properties:
- `string aciklama`
- `string emirTipiNew`
- `float fiyat`
- `string islem`
- `string islemeZamani`
- `float maxFloor`
- `string menkul`
- `float miktar`
- `int musteri`
- `string sureNew`
- `int sysId`
- `float tutar`

## StockOrderDeleteReq

Extends: `System.Object`


Properties:
- `string ref`

## StockOrderDeleteResponse

Extends: `System.Object`


Properties:
- `class StockOrderDeleteResponseData data`
- `object message`
- `int statusCode`
- `bool success`

## StockOrderDeleteResponseData

Extends: `System.Object`


Properties:
- `string cal`
- `int errorCode`
- `string errorMessage`
- `int errorUniqueCode`

## Takas

Extends: `System.Object`

Methods:
- `public void Write()`

Fields:
- `public modreq ET_0x82 ReceiverList`

## TakasItem

Extends: `System.Object`


Fields:
- `public string Broker`
- `public string Broker`
- `public int Order`
- `public int Order`
- `public double Percent`
- `public double Percent`
- `public double TotalLot`
- `public double TotalLot`
- `public double ValueTL`
- `public double ValueTL`

## TakasItem

Extends: `System.Object`


Fields:
- `public string Broker`
- `public string Broker`
- `public int Order`
- `public int Order`
- `public double Percent`
- `public double Percent`
- `public double TotalLot`
- `public double TotalLot`
- `public double ValueTL`
- `public double ValueTL`

## Takaslist

Extends: `System.Object`

Methods:
- `public void Change(string)`
- `public void Default()`
- `public void Delete()`
- `public void DeleteAll()`
- `public System.Collections.Generic.List`1<string> GetNames()`
- `public void Init()`
- `public void Save(byte[])`
- `public void Saveas(byte[])`

Fields:
- `public string ActiveName`
- `public class Step ActiveObject`

## TakasPozisyon

Extends: `System.Object`


Fields:
- `public System.Collections.Generic.List`1<float> Deger`
- `public string Kurum`

## TebHesapClass

Extends: `System.Object`


Properties:
- `float Blokaj`
- `int CevapKodu`
- `string CevapMesaj`
- `string Degisim`
- `int EkNo`
- `float Fiyat`
- `float IslemStogu`
- `string KarZarar`
- `string KarZararYuzde`
- `float Maliyet`
- `string Menkul`
- `int MusteriNo`
- `string PozisyonBuyuklugu`
- `string Renk`
- `float Stok`
- `float Tutar`
- `string Urun`
- `string UzlasmaFiyati`

## TebOrderCancelorEditResultClass

Extends: `System.Object`


Properties:
- `int BlokajId`
- `float BlokajTutar`
- `int CevapKodu`
- `string CevapMesaj`
- `int TarihliEmir`
- `string TarihliEmirMesaj`

## TebOrderclass

Extends: `System.Object`


Properties:
- `string Aciklama`
- `string Adet`
- `string AlisSatis`
- `string BekleyenAdet`
- `System.Nullable`1<int> CevapKodu`
- `string CevapMesaj`
- `string Emir`
- `string EmirGecerlilik`
- `string EmirId`
- `string EmirTipi`
- `string EmirTuru`
- `System.Nullable`1<valuetype System.Decimal> Fiyat`
- `System.Nullable`1<valuetype System.Decimal> GerceklesmeFiyati`
- `string GorunenAdet`
- `string Hesap`
- `string Hisse`
- `System.Nullable`1<int> Iceberg`
- `string InsertTime`
- `System.Nullable`1<int> IptalEklemeYapilabilir`
- `System.Nullable`1<int> Islem`
- `System.Nullable`1<int> MaxZincirSiraNo`
- `System.Nullable`1<int> MidPoint`
- `string OrjAnaEmirReferans`
- `string Referans`
- `System.Nullable`1<int> SiraNo`
- `System.Nullable`1<valuetype System.DateTime> SiralamZaman`
- `System.Nullable`1<int> Status`
- `string TalimatId`
- `System.Nullable`1<valuetype System.DateTime> Tarih`
- `System.Nullable`1<valuetype System.Decimal> Tutar`
- `System.Nullable`1<int> UpdateNum`
- `string UpdateTime`

## TebOrderResultClass

Extends: `System.Object`


Properties:
- `int CevapKodu`
- `string CevapMesaj`

## TradeImkb

Extends: `System.Object`

Methods:
- `public void Change(string)`
- `public void Default()`
- `public void Delete()`
- `public void DeleteAll()`
- `public System.Collections.Generic.List`1<string> GetNames()`
- `public void Init()`
- `public void Save(byte[])`
- `public void Saveas(byte[])`

Fields:
- `public string ActiveName`
- `public class Trade ActiveObject`

## TradeVip

Extends: `System.Object`

Methods:
- `public void Change(string)`
- `public void Default()`
- `public void Delete()`
- `public void DeleteAll()`
- `public System.Collections.Generic.List`1<string> GetNames()`
- `public void Init()`
- `public void Save(byte[])`
- `public void Saveas(byte[])`

Fields:
- `public string ActiveName`
- `public class Trade ActiveObject`

## TypeTakasToplam

Extends: `System.Object`


Fields:
- `public System.Collections.Generic.List`1<class TypeTakasToplam> FileRecordToplamList`
- `public double Lot`
- `public double MarketValue`
- `public double MarketValueOfShares`
- `public double NumberOfShares`
- `public double PublicRatio`
- `public string Seri`
- `public bool SortAscending`
- `public int SortIndex`
- `public string Symbol`

## Vb2a5Em3TtCKxkbaRni

Extends: `System.MulticastDelegate`

Methods:
- `public string Invoke(valuetype System.Guid&; string; class System.IFormatProvider)`
- `public string r7iItWL60(valuetype System.Guid&; string; class System.IFormatProvider; class Vb2a5Em3TtCKxkbaRni)`

## ViopIslemHandler

Extends: `System.MulticastDelegate`

Methods:
- `public class System.IAsyncResult BeginInvoke(valuetype ideal.IslemStruct1; class System.AsyncCallback; object)`
- `public void EndInvoke(class System.IAsyncResult)`
- `public void Invoke(valuetype ideal.IslemStruct1)`

## ViopOrderCancelReq

Extends: `System.Object`


Properties:
- `string imkbEmirNo`
- `string ref`

## ViopOrderCancelResponse

Extends: `System.Object`


Properties:
- `class ViopOrderCancelResponseData data`
- `object message`
- `int statusCode`
- `bool success`

## ViopOrderCancelResponseData

Extends: `System.Object`


Properties:
- `string cal`
- `int errorCode`
- `string errorMessage`
- `int errorUniqueCode`

## ViopPozisyon

Extends: `System.Object`


Properties:
- `float guniciKz`
- `float kapanis`
- `float maliyet`
- `float parasalTutar`
- `int pozisyonSayisi`
- `string sozlesmeKodu`
- `string uzunKisa`

## ViopRobotHesapClass

Extends: `System.Object`


Fields:
- `public System.Collections.Generic.List`1<class VipOrderRecord> BekleyenEmirler`
- `public System.Collections.Generic.List`1<class VipOrderRecord> GerceklesenEmirler`
- `public System.Collections.Generic.List`1<class VipPositionRecord> Pozisyonlar`
- `public double TeminatBaslangic`
- `public double TeminatCagri`
- `public double TeminatCekilebilir`
- `public double TeminatKullanilabilir`
- `public double TeminatSurdurme`
- `public double TeminatToplam`

## VipAccountSummaryResponse

Extends: `System.Object`


Properties:
- `class VipAccountSummaryResponseData data`
- `object message`
- `int statusCode`
- `bool success`

## VipAccountSummaryResponseBvtm

Extends: `System.Object`


Properties:
- `float anlikkzmaliyet`
- `float baslangicTeminati`
- `float cekilebilirTeminat`
- `float cekilebilirTeminatPasifDahil`
- `float digerTeminatlar`
- `int hesap`
- `string hesapDurumu`
- `float kalanTeminat`
- `float karzarar`
- `float kz_sonFiyat`
- `float nakitTeminatlar`
- `float pasifDahilGerekliBaslangic`
- `float primToplami`
- `float primToplamiAlacak`
- `float primToplamiBorc`
- `string riskDurumu`
- `float seanslikTeminat`
- `float surdurmeTeminatiMarji`
- `valuetype System.DateTime tarih`
- `float teminatTamamlamaCagrisiHesaplama`
- `float teminatTamamlamaCagrisiMiktari`
- `string teminatTipi`

## VipAccountSummaryResponseData

Extends: `System.Object`


Properties:
- `class VipAccountSummaryResponseBvtm[] bvtm`

## VipContractGtp

Extends: `System.Object`

Methods:
- `public class Record GetContract(string)`

Fields:
- `public System.Collections.Generic.Dictionary`2<string, class Record> Dictionary`

## VipKZRaporRecord

Extends: `System.Object`


Fields:
- `public int AcikKisaPoz`
- `public int AcikUzunPoz`
- `public string Aciklama`
- `public double KarZarar`
- `public float KulFiyat`
- `public string ParaBirimi`
- `public string Sozlesme`
- `public string UzunKisa`
- `public string VadeSonu`

## VipNet

Extends: `System.Object`

Methods:
- `public void Write()`

Fields:
- `public modreq ET_0x82 ReceiverList`

## VipOrderImprovementReq

Extends: `System.Object`


Properties:
- `int acikKapali`
- `valuetype System.Decimal eskiFiyat`
- `int eskiMiktar`
- `valuetype System.Decimal fiyat`
- `string imkbEmirNo`
- `int miktar`
- `string ref`
- `string sure`
- `string sureTarih`

## VipOrderImproveResponse

Extends: `System.Object`


Properties:
- `class VipOrderImroveData data`
- `object message`
- `int statusCode`
- `bool success`

## VipOrderImroveData

Extends: `System.Object`


Properties:
- `string cal`
- `int errorCode`
- `string errorMessage`
- `int errorUniqueCode`

## VipOrderRecord

Extends: `System.Object`


Fields:
- `public string AccountName`
- `public string AccountNo`
- `public bool AksamSeansBool`
- `public string AmendPermit`
- `public double Amount`
- `public double Balance`
- `public string BorsaDurum`
- `public string BorsaEmirNo`
- `public string BuySell`
- `public string CancelPermit`
- `public string CancelReason`
- `public string DurationConvert`
- `public string EndDate`
- `public valuetype System.DateTime EndDateConvert`
- `public double EnteredAmount`
- `public string ExecutionStatus`
- `public double GAmount`
- `public double GPrice`
- `public string GSaat`
- `public valuetype System.Decimal GTotal`
- `public double InvisibleAmount`
- `public string LongAccountName`
- `public string Nominal`
- `public string OrderDate`
- `public valuetype System.DateTime OrderDateConvert`
- `public string OrderNo`
- `public string OrderPermit`
- `public string OrderRef`
- `public string OrderSender`
- `public string OrderTime`
- `public string OrderType`
- `public string OrderTypeConvert`
- `public string Orj_sysId`
- `public string PositionClosing`
- `public double Price`
- `public string PriceType`
- `public string PriceTypeConvert`
- `public string RecordNo`
- `public string RefNo`
- `public bool SartBool`
- `public double SartFiyat`
- `public string SartSembol`
- `public string SartTip`
- `public string SartTipStr`
- `public string SartYon`
- `public string SeansType`
- `public byte Selected`
- `public string Session`
- `public string SessionName`
- `public string SpanDurum`
- `public string State`
- `public string Status`
- `public string StatusCode`
- `public double Stop`
- `public string SubMarket`
- `public string Symbol`
- `public string TemsilciRef`
- `public double Total`
- `public string ValorDate`
- `public double VisibleBalance`

## VipOrdersReq

Extends: `System.Object`


Properties:
- `string _ref`
- `string gerceklesenDetay`

## VipOrdersResponse

Extends: `System.Object`


Properties:
- `class VipOrdersResponseData data`
- `object message`
- `int statusCode`
- `bool success`

## VipOrdersResponseArr

Extends: `System.Object`


Properties:
- `string durum`
- `string emir`
- `string emirDurum`
- `string emirGirisAni`
- `string emirTipiNew`
- `double fiyat`
- `double gerceklesenMiktar`
- `double gerceklesenOrtalama`
- `string gerceklesmeSonZaman`
- `int hesapNo`
- `string hisseKodu`
- `string imkbEmirNo`
- `string iptalAciklama`
- `float miktar`
- `int orj_SysId`
- `float orjinalTutar`
- `string seans`
- `string seansNew`
- `valuetype System.DateTime sonTarih`
- `int sysId`
- `string tetikSozlesme`
- `float triggerPrice`
- `string triggerTypeDesc`
- `float tutar`
- `float veriDagiticiMiktar`

## VipOrdersResponseData

Extends: `System.Object`


Properties:
- `class VipOrdersResponseArr[] emirler`

## VipPositionRecord

Extends: `System.Object`


Fields:
- `public double AcilisMaliyet`
- `public double BuyAmount`
- `public string ContractType`
- `public double Cost`
- `public string Currency`
- `public string Direction`
- `public double FifoMaliyet`
- `public double GunBasiFifoMaliyet`
- `public double LastPrice`
- `public double NetAmount`
- `public double NetFifoMaliyet`
- `public double NetMaliyet`
- `public string Nominal`
- `public double OpenAmount`
- `public double OpenPosition`
- `public double OpsiyonPrimiNet`
- `public string PositionDate`
- `public valuetype System.Decimal PozSize`
- `public double Price`
- `public double Profit`
- `public valuetype System.Decimal ProfitAnlik`
- `public valuetype System.Decimal ProfitAnlikLastPrice`
- `public valuetype System.Decimal ProfitAnlikSettlementPrice`
- `public valuetype System.Decimal ProfitFifo`
- `public string Risk`
- `public double SellAmount`
- `public double SettlementPrice`
- `public valuetype System.Decimal SettlementPriceUzlasi`
- `public double SonUzlasi`
- `public string Status`
- `public string Symbol`
- `public string Tip`
- `public double Total`
- `public double UnitAmount`
- `public int assetCoef`
- `public double avgPrice`
- `public double balanceT`
- `public double balanceT1`
- `public double balanceT2`
- `public double balanceT3`
- `public double currentAmount`
- `public string depotCode`
- `public double profitLoss`
- `public float qty`
- `public int sellCoef`
- `public string uniqueSymbol`

## VipPositions

Extends: `System.Object`


Properties:
- `class VipPositionsData data`
- `object message`
- `int statusCode`
- `bool success`

## VipPositionsBvp

Extends: `System.Object`


Properties:
- `int acikpozisyondeger`
- `int acikpoztoplami`
- `float agirortmaliyet`
- `float anlikkzmaliyet`
- `string doviztutar`
- `float gunicikzsonfiyat`
- `int hesap`
- `string hesapdurumu`
- `float kapanis`
- `float karzarar`
- `int kisapoztoplami`
- `float kzsonfiyat`
- `float maliyet`
- `int netpozisyon`
- `float sonfiyatkzmaliyet`
- `string sozlesme`
- `string tarih`
- `string tip`
- `float tutar`
- `int uzunpoztoplami`

## VipPositionsData

Extends: `System.Object`


Properties:
- `class VipPositionsBvp[] bvps`

## VipProfitLossReportReq

Extends: `System.Object`


Properties:
- `string basTarih`
- `string bitTarih`
- `string sozlesmeTuru`

## VipProfitLossResponse

Extends: `System.Object`


Properties:
- `class VipProfitLossResponseData data`
- `object message`
- `int statusCode`
- `bool success`

## VipProfitLossResponseData

Extends: `System.Object`


Properties:
- `class Vrd[] vrd`
- `class Vr[] vrs`

## VipProfitRecord

Extends: `System.Object`


Fields:
- `public string Adet`
- `public string HesapID`
- `public string ItfaTarihi`
- `public string KapanisFiyati`
- `public string KarZarar`
- `public string Maliyet`
- `public string MenukulID`
- `public string MusteriID`
- `public string Nominal`
- `public string ShortLong`
- `public string Sozlesme`

## VipReportCashReq

Extends: `System.Object`


Properties:
- `string basTarih`
- `string bitTarih`

## VipReportCashResponse

Extends: `System.Object`


Properties:
- `class VipReportCashResponseData data`
- `object message`
- `int statusCode`
- `bool success`

## VipReportCashResponseData

Extends: `System.Object`


Properties:
- `class VipReportCashResponseList[] list`

## VipReportCashResponseList

Extends: `System.Object`


Properties:
- `string aciklama`
- `float alacak`
- `float borc`
- `valuetype System.DateTime valorTarihi`

## VipSendOrderReq

Extends: `System.Object`


Properties:
- `int acikKapali`
- `string aksamSeansi`
- `valuetype System.Decimal fiyat`
- `valuetype System.Decimal gorunenMiktar`
- `string islem`
- `int miktar`
- `string orderType`
- `string smsGonderimi`
- `string sozlesme`
- `string sure`
- `string sureTarih`
- `int tetikFiyat`
- `object tetikSozlesme`
- `int tetikTipi`

## VipSendOrderResponse

Extends: `System.Object`


Properties:
- `class VipSendOrderResponseDataData data`
- `object message`
- `int statusCode`
- `bool success`

## VipSendOrderResponseDataData

Extends: `System.Object`


Properties:
- `int errorCode`
- `string errorMessage`
- `int errorUniqueCode`
- `string hsr`

## VipStatementRecord

Extends: `System.Object`


Fields:
- `public double Balance`
- `public double Credit`
- `public double Debt`
- `public string Description`
- `public string ProcessDate`
- `public double TeminatBakiye`
- `public string ValorDate`

## VipTransactionReport

Extends: `System.Object`


Fields:
- `public string AccountNo`
- `public double BSMV`
- `public string BuySell`
- `public double Commission`
- `public string Contract`
- `public string CrossMember`
- `public int Lot`
- `public string Market`
- `public double MarketCommission`
- `public double OpenCommission`
- `public int OpenLot`
- `public string OrderTime`
- `public double Price`
- `public string ProcessDate`
- `public string Session`
- `public string Time`
- `public string Transaction`
- `public string Type`
- `public double Volume`

## VipTransactionResponse

Extends: `System.Object`


Properties:
- `class VipTransactionResponseData data`
- `object message`
- `int statusCode`
- `bool success`

## VipTransactionResponseData

Extends: `System.Object`


Properties:
- `class VipTransactionResponseVrd[] vrd`

## VipTransactionResponseVrd

Extends: `System.Object`


Properties:
- `int acikKomisyon`
- `int acikMiktar`
- `string alisSatis`
- `double borsaPayi`
- `double bsmv`
- `string emirSaati`
- `double fiyat`
- `float hacim`
- `int hesap`
- `int islem`
- `string karsiUye`
- `double komisyon`
- `int miktar`
- `string pazar`
- `string saat`
- `int seans`
- `string sozlesme`
- `valuetype System.DateTime tarih`
- `string tip`

## VipTransactionsReq

Extends: `System.Object`


Properties:
- `string baslangicTarihi`
- `string bitisTarihi`
- `string sozlesme`
