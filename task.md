# IdealQuant Tasks

## ✅ Phase 12: Strategy 7 (DeepScalp v1.2)
- [x] Full-Stack Python integration (strategy, optimizer, UI, export skeleton)
- [x] Fix ImportError (indicator aliases: get_ema, get_mfi, get_atr, get_supertrend, get_toma)
- [x] **SuperTrend Calibration:** `get_supertrend` validated vs IdealData (Ort%=0.019, rounding noise only)
- [x] S7 C# Export: Add SuperTrend code to `idealdata_exporter.py`
- [x] End-to-end test with real data (DeepScalp strategy in strategy panel)
- [x] S7 C# Export: Full DeepScalp C# template in `idealdata_exporter.py`

## ✅ Phase 13: Strategy 8 (Gap Reversal v1.0)
- [x] Strategy Logic: Night gap detection + Opening Range (OR) logic
- [x] Indicators: Wilder RSI, Wilder ATR, Volume SMA
- [x] Python Strategy: `gap_reversal_strategy.py`
- [x] Numba-JIT Optimizer: `strategy8_optimizer.py`
- [x] IdealData C# Export: `export_strategy8` and `_generate_strategy8_code` in `idealdata_exporter.py`
- [x] UI Integration: Added to StrategyPanel, OptimizerPanel and ExportPanel
- [x] **v5.0 Bug Fixes:** Fixed multiprocessing `PermissionError` (WinError 5), `vade_tipi` short-selling bug in SPOT, `active_days` in Genetic/Bayesian, and datetime parsing stability.

## 📋 Backlog
- [ ] Robust Analysis: Run first full analysis on real data (S7 & S8)
- [ ] Migrate S1-S4 to 3-mode Vade structure (currently only S5-S8 supports it)
- [ ] Refactor `ideal_parser.py` for performance
- [ ] Excel/PDF Export for Robust Analysis Reports

## 📌 Next Session Start Point
- **Priority 1:** S1-S4 stratejilerini 3-mod vade yapısına (VIOP_ENDEKS / VIOP_SPOT / SPOT) taşımak.
- **Priority 2:** S7 ve S8 için gerçek veri ile tam Robust Analiz (WFA/MC) koşturmak.

