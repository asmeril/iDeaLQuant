def _evaluate_s7_params(params: Dict[str, Any], commission: float = 0.0, slippage: float = 0.0) -> Dict[str, float]:
    """S7 DeepScalp parametrelerini Numba kernel ile degerlendir.
    
    v1.3: HHV/LLV/MFI-HHV/MFI-LLV/VolMA hesaplamalari kernel disinda bir kez yapilip
    pre-computed numpy array olarak geciliyor. Her kombinasyon icin sadece basit
    karsilastirmalar kaliyor => ~50-100x hizlanma.
    """
    global g_cache, _s7_arrays, g_mask, _s7_rolling_cache
    zero_result = {'net_profit': 0.0, 'trades': 0, 'pf': 0.0, 'max_dd': 0.0, 'sharpe': 0.0, 'fitness': 0.0}
    if g_cache is None: return zero_result

    try:
        n = len(g_cache.closes)
        if '_s7_arrays' not in dir() or _s7_arrays is None or len(_s7_arrays[0]) != n:
            closes = np.ascontiguousarray(g_cache.closes, dtype=np.float64)
            highs  = np.ascontiguousarray(g_cache.highs, dtype=np.float64)
            lows   = np.ascontiguousarray(g_cache.lows, dtype=np.float64)
            vols   = np.ascontiguousarray(g_cache.volumes, dtype=np.float64)
            mask_arr  = np.array(g_mask, dtype=np.bool_)
            times_arr = np.zeros(n, dtype=np.int64)
            if hasattr(g_cache, 'times') and g_cache.times:
                times_arr = np.array([int(t.timestamp()) for t in g_cache.times], dtype=np.int64)
            _s7_arrays = (closes, highs, lows, vols, mask_arr, times_arr)

        closes, highs, lows, vols, mask_arr, times_arr = _s7_arrays

        # --- Parametre mapping ---
        ars_k   = float(params.get('ars_k', 1.23))
        hhv_p   = int(params.get('hhv_period', 12))
        llv_p   = int(params.get('llv_period', 12))
        mfi_p   = int(params.get('mfi_period', 14))
        mfi_hhv = int(params.get('mfi_hhv_period', 5))
        mfi_llv = int(params.get('mfi_llv_period', 5))
        mfi_l   = float(params.get('mfi_long', 55.0))
        mfi_s   = float(params.get('mfi_short', 45.0))
        v_rat   = float(params.get('vol_ratio', 0.8))
        atr_sl_l = float(params.get('atr_stop_mult_long', 1.5))
        atr_sl_s = float(params.get('atr_stop_mult_short', 1.5))
        ka_l    = float(params.get('kar_al_yuzde_long', 2.0))
        ka_s    = float(params.get('kar_al_yuzde_short', 2.0))
        mh_b    = int(params.get('min_hold_bars', 2))
        mx_b    = int(params.get('max_hold_bars', 20))
        cd_b    = int(params.get('cooldown_bars', 2))

        vt = params.get('vade_tipi', 'ENDEKS')
        vt_code = 1
        if vt == 'SPOT': vt_code = 0
        elif vt == 'VIOP_SPOT': vt_code = 2

        # --- Cached indicator arrays ---
        ars_ema_arr = np.ascontiguousarray(g_cache.get_ema(int(params.get('ars_ema_period', 3))), dtype=np.float64)
        st_val_arr  = np.ascontiguousarray(g_cache.get_st(float(params.get('st_factor', 3.0)), int(params.get('st_hhv_period', 10)), int(params.get('st_atr_period', 14))), dtype=np.float64)
        ema_f_arr   = np.ascontiguousarray(g_cache.get_ema(int(params.get('ema_fast_period', 9))), dtype=np.float64)
        ema_s_arr   = np.ascontiguousarray(g_cache.get_ema(int(params.get('ema_slow_period', 21))), dtype=np.float64)
        _, toma_raw = g_cache.get_toma(1, float(params.get('toma_period2', 2.1)))
        toma_arr    = np.ascontiguousarray(toma_raw, dtype=np.float64)
        mfi_arr     = np.ascontiguousarray(g_cache.get_mfi(mfi_p), dtype=np.float64)
        atr_arr     = np.ascontiguousarray(g_cache.get_atr(int(params.get('atr_period', 14))), dtype=np.float64)

        # --- Pre-computed rolling arrays (worker-level cache ile) ---
        def _cached_roll(key, fn):
            if key not in _s7_rolling_cache:
                _s7_rolling_cache[key] = fn()
            return _s7_rolling_cache[key]

        hhv_shifted     = _cached_roll(('hhv', hhv_p),          lambda: _get_hhv_shifted(g_cache.highs, hhv_p))
        llv_shifted     = _cached_roll(('llv', llv_p),          lambda: _get_llv_shifted(g_cache.lows, llv_p))
        mfi_hhv_shifted = _cached_roll(('mfi_hhv', mfi_p, mfi_hhv), lambda: _get_rolling_max_shifted(mfi_arr, mfi_hhv))
        mfi_llv_shifted = _cached_roll(('mfi_llv', mfi_p, mfi_llv), lambda: _get_rolling_min_shifted(mfi_arr, mfi_llv))
        vol_ma_shifted  = _cached_roll(('vol_ma', 20),          lambda: _get_rolling_mean_shifted(g_cache.volumes, 20))

        res = fast_backtest_strategy7(
            closes, highs, lows, vols,
            ars_ema_arr, st_val_arr, ema_f_arr, ema_s_arr, toma_arr,
            mfi_arr, atr_arr, mask_arr, times_arr,
            hhv_shifted, llv_shifted, mfi_hhv_shifted, mfi_llv_shifted, vol_ma_shifted,
            ars_k, mfi_l, mfi_s,
            v_rat, atr_sl_l, atr_sl_s, ka_l, ka_s, mh_b, mx_b, cd_b, vt_code
        )

        np_val, tr, pf, dd, sh, adays, tdays = res
        fit = quick_fitness(np_val, pf, dd, tr, sharpe=sh, active_days=adays, total_days=tdays)
        return {'net_profit': np_val, 'trades': tr, 'pf': pf, 'max_dd': dd, 'sharpe': sh, 'fitness': fit}

    except Exception as e:
        import traceback
        print(f"[S7_EVAL ERROR] {e}")
        traceback.print_exc()
        return zero_result