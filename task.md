# IdealQuant Tasks

## 🔄 Phase 12: Strategy 7 (DeepScalp v1.2)
- [x] Full-Stack Python integration (strategy, optimizer, UI, export skeleton)
- [x] Fix ImportError (indicator aliases: get_ema, get_mfi, get_atr, get_supertrend, get_toma)
- [x] **SuperTrend Calibration:** `get_supertrend` validated vs IdealData (Ort%=0.019, rounding noise only)
- [ ] S7 C# Export: Add SuperTrend code to `idealdata_exporter.py`
- [ ] End-to-end test with real data (DeepScalp strategy in strategy panel)

## 🔄 Phase 4 S4 Refactor (Completed this session)
- [x] Split `kar_al` + `iz_stop` into Phase 4 (`s4_p4_eval` in `strategy4_optimizer.py`)
- [x] Update `optimizer_panel.py` with Phase 4 pool + checkpoint support

## 📋 Backlog
- [ ] S7 C# Export: Full DeepScalp C# template in `idealdata_exporter.py`
- [ ] Robust Analysis: Run first full analysis on real data
- [ ] Migrate S1-S4 to 3-mode Vade structure (currently only S5 supports it)
- [ ] Refactor `ideal_parser.py` for performance
- [ ] Excel/PDF Export for Robust Analysis Reports

## 📌 Next Session Start Point
- **Priority 1:** S7 SuperTrend → C# Export (`idealdata_exporter.py` → `_generate_strategy7_code`)
- **Priority 2:** DeepScalp strateji paneli uçtan uca test
