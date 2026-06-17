# Current ideal.exe Analysis Output

Generated from:

`/media/tevfik/DATA/iDeal/ideal.exe`

## Files

- `00_metadata_summary.json`: CLR metadata stream/table summary.
- `01_types.jsonl`: all type definitions.
- `02_methods.csv`: all method definitions with decoded return and parameter types.
- `03_fields.csv`: all fields with decoded types.
- `04_properties.csv`: all properties with decoded types and accessors.
- `05_events.csv`: events.
- `06_pinvoke_implmaps.csv`: native P/Invoke mappings.
- `07_memberrefs.csv`: referenced members.
- `08_finance_api_map.md`: broad finance/trading type map.
- `09_method_candidates.md`: broad keyword-filtered method candidates.
- `10_focused_api_report.md`: noise-reduced iDeal/finance class map.
- `11_public_method_index.csv`: public/family keyword method index.
- `12_reference_call_index.md`: filtered member reference index.
- `13_focused_summary.json`: focused report counts.

## Counts

- TypeDef: 3230
- Field: 44578
- MethodDef: 36403
- Param: 33060
- Property: 2612
- Event: 32
- MemberRef: 6986
- P/Invoke mappings: 18
- Focused interesting types: 392
- Focused public keyword methods: 5686

## Regenerate

```bash
python3 reference/ideal_docs/scripts/extract_dotnet_metadata.py \
  /media/tevfik/DATA/iDeal/ideal.exe \
  reference/ideal_docs/exe_analysis_current

python3 reference/ideal_docs/scripts/summarize_ideal_metadata.py \
  reference/ideal_docs/exe_analysis_current
```

## Pair With ILSpy Output

For method bodies or exact class implementation, use:

`reference/ideal_docs/ilspy_decompile_current/`

Start with:

- `ideal/cxSistem.cs`
- `ideal/RoboTradeClass.cs`
- `ideal/RoboEmirClass.cs`
- `ideal/FormRobotServer.cs`
- `ideal/formPortfolio.cs`
- `ideal/formTradeVip.cs`
- `ideal/formTradeImkb.cs`
- `ideal/formTakasAnaliz.cs`
- `ideal/formClearingBank.cs`
- `ideal/ChartControl.cs`
