# iDeal Internal API Starter Map

This is a curated starting point from the current `ideal.exe` metadata and ILSpy output. It is not a complete API contract. Use it to find relevant classes, then verify details in the decompiled source and official docs.

## Primary Script Host

### `ideal.cxSistem`

Decompiled file:

`ilspy_decompile_current/ideal/cxSistem.cs`

Observed relevant fields/properties:

- `GrafikVerileri`
- `YuzeyselVeri`
- `DerinlikVeri`
- `SorguDeger`
- `SorguHucreZeminRengi`
- `SorguHucreYaziRengi`
- `SorguSutunTip`
- `SorguSutunHizala`
- `SorguSutunGenislik`
- `SorguOndalik`
- `SorguBaslik`
- `SorguAciklama`
- `OptimizasyonStartDate`
- `OptimizasyonEndDate`
- `OptimizasyonStartBarNo`
- `OptimizasyonEndBarNo`
- `RobotEnabled`
- `EmirHesapAdi`
- `EmirAltHesap`
- `EmirSembol`
- `EmirFiyati`
- `EmirMiktari`
- `EmirSuresi`
- `EmirTipi`
- `EmirIslem`
- `EmirSatisTipi`
- `EmirAcigaSatisKapama`
- `EmirFiyatTipi`
- `EmirStop`
- `EmirBitisTarih`
- `EmirEndDate`
- `EmirAciklama`
- `EmirAksamSeansi`
- `EmirGenelSatis`
- `EmirSartBool`
- `EmirSartSembol`
- `EmirSartFiyat`
- `EmirSartTipi`

Observed relevant methods:

- `EmirGonder()`
- `EmirDuzelt(string emirRefNo, double yeniFiyat, double yeniMiktar, double eskiFiyat, double eskiMiktar)`
- `EmirSil(string emirRefNo)`
- `PozisyonKontrolGuncelle(string key, object lot)`
- `PozisyonKontrolGuncelle(string key, object lot, double fiyat)`
- `PozisyonKontrolGuncelle(string key, object lot, double fiyat, string rezerv)`
- `PozisyonKontrolOku(string key)`
- `PozisyonKontrolOku(string key, out double fiyat)`
- `PozisyonKontrolOku(string key, out double fiyat, out DateTime tarih)`
- `PozisyonKontrolOku(string key, out double fiyat, out DateTime tarih, out string rezerv)`
- `ViopHesapOku()`
- `ViopHesapOku(int delaytime)`
- `ViopPozisyonlar(int delaytime)`
- `ViopPozisyon(dynamic liste, string sembol)`
- `BistHesapOku()`
- `DerinlikVerisiOku(string symbol)`
- `DerinlikPenceresiAc(string sembol)`
- `GetiriHesapla(object datestart, object kayma)`
- `GetiriMaxDDHesapla(object datestart, object dateend)`
- `GrafikPenceresiAc(string sembol)`
- `GrafikFiyatSec(string field)`
- `GrafikFiyatOku(List<cxBar> bars, string field)`
- `GrafikFiyatOku(string symbol, string period, string field)`
- `GrafikGuncelle(cxBasic item)`
- `GrafikVerilerindeTarihHizala(List<cxBar> list1, List<cxBar> list2)`
- `GrafikVerileriniBol(List<cxBar> list1, List<cxBar> list2)`
- `GrafikKapanisHizala(List<cxBar> list1, List<cxBar> list2)`
- `GrafikVerileriniOku(string symbol, string periyot)`
- `GrafikVerileriniOku(string symbol, string periyot, string periyot2)`

Use official docs for public `Sistem` usage first. Use this map when looking for overloads or undocumented behaviors.

## Robot and Order Internals

### `ideal.RoboTradeClass`

Decompiled file:

`ilspy_decompile_current/ideal/RoboTradeClass.cs`

Observed fields:

- `Pozisyon`
- `Hesap`
- `AltHesap`
- `AksamPozKapatBool`
- `CumaPozKapatBool`
- `AksamPozKapatSaat`
- `CumaPozKapatSaat`
- static `RunningMode`
- static `RunningRowNo`
- static `RunningDescription`
- static `IslemList`

Observed method:

- `EmirGonder(double miktar, string aciklama)`

### `ideal.RoboEmirClass`

Decompiled file:

`ilspy_decompile_current/ideal/RoboEmirClass.cs`

Observed members:

- static `BekleyenList`
- static `CheckBekleyenEmirler()`
- static `SendMarketOrder(RoboEmirClass item)`

### `ideal.FormRobotServer`

Decompiled file:

`ilspy_decompile_current/ideal/FormRobotServer.cs`

Observed relevant methods:

- `RobotServerPozisyonEsitle(cxSistem sistem, string symbol, int lot, string info, Color color)`
- `RobotServerAtaHisseSistem1(cxSistem sistem, string filename)`
- `RobotServerMeksaHisseSistem1(cxSistem sistem, string filename)`

This class also contains robot server file serialization, position sync and grid/UI event handlers.

## Portfolio and Account Areas

Primary files/classes:

- `ilspy_decompile_current/ideal/formPortfolio.cs`
- `ilspy_decompile_current/ideal/formTradeVip.cs`
- `ilspy_decompile_current/ideal/formTradeImkb.cs`
- `ilspy_decompile_current/ideal/FormRobotServer.cs`
- `exe_analysis_current/10_focused_api_report.md`
- `exe_analysis_current/11_public_method_index.csv`

Useful public method candidates from `11_public_method_index.csv`:

- `Request.BistGetHesapRobot() -> BistRobotHesapClass`
- `Request.VipGetHesapRobot() -> ViopRobotHesapClass`
- `Request.VipGetPozisyonRobot() -> ViopRobotHesapClass`
- `Request.GetGerceklesenViopIslemler(AccountRecord, string) -> List<GerceklesenIslemClass>`
- `Request.CalculateViopKZ(...) -> decimal`
- `Request.CalculateViopKZAnlik(...) -> decimal`
- `Request.CalculateViopSettlementPrice(...) -> decimal`
- `Request.CalculateViopPositionSize(...) -> decimal`
- `Request.CalculateViopKZLastPrice(...) -> decimal`
- `Request.CalculateViopKZFifoMaliyet(...) -> decimal`
- `Request.ImkbGetHesapKEP(string, string)`

These are internal implementation details. Validate runtime behavior inside iDeal before using assumptions in production code.

## Takas / Kurum / Hacim Areas

Primary files/classes:

- `ilspy_decompile_current/ideal/formTakasAnaliz.cs`
- `ilspy_decompile_current/ideal/formClearingBank.cs`
- `ilspy_decompile_current/ideal/formAliciSaticiAnaliz.cs`
- `ilspy_decompile_current/ideal/formViopKurumHacim2.cs`
- `ilspy_decompile_current/ideal/View/formViopKurumHacim.cs`

Observed classes in `formTakasAnaliz`:

- `BrokerBasedRecord`
- `StockBasedRecord`
- `StockAllSymbolRecord`
- `StockAllBrokerRecord`
- `TypeBroker`
- `TypeStock`
- `TypeStockAll`
- `TypeSkyt`
- `TypeSys`
- `TypeTakasToplam`

Observed method/state-machine names:

- `DisplaySYKT`
- `DisplaySYS`
- `DisplayTakasToplam`
- `FillTakasIst`

Useful public method candidates:

- `KurumAkdClass.CalculateKurumTum(int kurumid)`
- `KurumAkdClass.CalculateKurumHisse(int kurumid)`
- `HisseAkdClass.CalculateHisseKurum(int sembolid)`
- `KurumChartClass.GetKurumChart(string sembol, int kurumId, int daycount, bool kumulatif, out float kz, out float kumulatifnet)`
- `KurumChartClass.ReadKurumTarihsel(string filename)`
- `KurumChartClass.WriteKurumTarihsel(List<KurumRecord>, string filename)`

## Chart / Indicator Areas

Primary files/classes:

- `ilspy_decompile_current/ideal/ChartControl.cs`
- `ilspy_decompile_current/ideal/formChart.cs`
- `ilspy_decompile_current/ideal/formChartIndicators.cs`
- `ilspy_decompile_current/ideal/formChartIndicatorEdit.cs`
- `ilspy_decompile_current/ideal/formIndicatorValues.cs`
- `exe_analysis_current/11_public_method_index.csv`

Useful method candidates:

- `ChartControl.DownloadTakas()`
- `ChartControl.InsertIndicatorForSistemMulti()`
- `ChartControl.ProcessKurumData(IslemStruct1)`
- `ChartControl.ReadTakasGun()`
- `ChartControl.ReadTakasDegisim()`
- `ChartControl.RecalculateSistem()`

## P/Invoke / Native Imports

From `exe_analysis_current/06_pinvoke_implmaps.csv`:

- `ideal.cxTime.SetLocalTime -> kernel32.dll`
- `ideal.cxZip.compress -> zlib64.dll`
- `ideal.cxZip.uncompress -> zlib64.dll`
- `ideal.cxApi.MapVirtualKey -> user32.dll`
- `ideal.cxApi.SendMessage -> user32.dll`
- `ideal.cxApi.ReleaseCapture -> user32.dll`
- `ideal.cxApi.ShowScrollBar -> user32.dll`
- `ideal.cxApi.CreateRoundRectRgn -> Gdi32.dll`
- `ideal.cxApi.WritePrivateProfileString -> kernel32`
- `ideal.cxApi.GetPrivateProfileString -> kernel32`
- `ideal.cxApi.GetCursorPos -> user32.dll`
- `ideal.MainForm.SetWindowLong -> user32`
- `ideal.MainForm.GetWindowLong -> user32`
- `ideal.MainForm.SetWindowPos -> user32`
- obfuscated class imports `LoadLibrary` and `GetProcAddress`

## Recommended Search Commands

```bash
# Find public internal methods by keyword
python3 - <<'PY'
import csv
kw='Viop'
with open('reference/ideal_docs/exe_analysis_current/11_public_method_index.csv', encoding='utf-8') as f:
    for r in csv.DictReader(f):
        if kw.lower() in (r['type']+'.'+r['name']).lower():
            print(r)
PY

# Locate a decompiled class
find reference/ideal_docs/ilspy_decompile_current -name 'cxSistem.cs'
```

## Caution

- Internal APIs can change between iDeal versions.
- Decompile output can be wrong or incomplete around async state machines and obfuscated code.
- Always test inside iDeal when behavior affects orders, positions, account state or UI state.
