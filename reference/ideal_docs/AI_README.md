# iDeal Reference Pack for AI Models and Developers

This folder is the canonical reference pack for iDeal / IdealQuant work.

Primary source tree:

`/media/tevfik/DATA/Projects/IdealQuant/reference/`

Consolidated docs:

`/media/tevfik/DATA/Projects/IdealQuant/reference/ideal_docs/`

## Reading Order

1. `README.md`
2. `IDEAL_ULTIMATE_GUIDE.md`
3. `../IDEAL_EXE_AI_KILAVUZU.md`
4. `../IDEAL_EXE_AI_RULESET.json`
5. `IDEAL_REVERSE_ENGINEERING_GUIDE.md`
6. `IDEAL_INTERNAL_API_STARTER_MAP.md`
7. `exe_analysis_current/README.md`
8. Existing examples in `../Robot_*.txt`, `../Sorgu_*.txt`, `../Strateji_*.txt`, `../Ornek_*.txt`

## Rules for AI Usage

- Do not invent iDeal `Sistem` APIs, enum values, object fields, order types, or symbol prefixes.
- Prefer documented APIs first; use reverse-engineered data to understand internals or exact class fields.
- Treat `Sistem.ViopHesapOku()` and `Sistem.BistHesapOku()` as real account state.
- Treat `Sistem.PozisyonKontrolOku/Guncelle` as robot-local software state.
- For order code, verify `EmirSembol`, `EmirIslem`, `EmirTipi`, `EmirMiktari`, `EmirFiyati`, `EmirSuresi`, `EmirGonder` behavior against docs/examples.
- For VIOP, verify `Limitli` vs `Piyasa`, evening-session behavior, contract size, settlement, and margin fields.
- Normalize Turkish numeric formats before parsing. Do not assume invariant culture.
- Prefer defensive `try/catch`, null guards, and file logging in iDeal script-host code.

## Main Human-Friendly Files

- `IDEAL_ULTIMATE_GUIDE.md`: consolidated official and reverse-engineered reference.
- `IDEAL_REVERSE_ENGINEERING_GUIDE.md`: how the current `ideal.exe` was analyzed and how to regenerate outputs.
- `IDEAL_INTERNAL_API_STARTER_MAP.md`: first-pass curated internal API map from `ideal.exe`.
- `exe_analysis_current/10_focused_api_report.md`: filtered internal finance/API class map.
- `exe_analysis_current/11_public_method_index.csv`: public method index with signatures.
- `exe_analysis_current/06_pinvoke_implmaps.csv`: native DLL imports.
- `ilspy_decompile_current/`: C# decompile output from ILSpy, useful when exact method bodies are needed.

## Current Extraction Scope

The current reverse-engineering output is generated from:

`/media/tevfik/DATA/iDeal/ideal.exe`

The extraction does not bypass licensing or runtime protection. It reads .NET metadata and uses ILSpy decompilation where available.

## Removed Data

`manuals/BarData_Export/` was intentionally removed from the repository because it contained large exported OHLCV CSV files. Do not assume it exists.
