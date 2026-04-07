def _evaluate_strategy7(self, params: Dict[str, Any]) -> Dict[str, float]:
        """Strateji 7 (DeepScalp) icin fitness hesapla."""
        try:
            from src.optimization.strategy7_optimizer import fast_backtest_strategy7, DeepScalpCache
            import numpy as np
            from src.optimization.fitness import quick_fitness
            
            if 's7_cache' not in self.cache._cache:
                self.cache._cache['s7_cache'] = DeepScalpCache(self.cache.df)
            cache = self.cache._cache['s7_cache']
            
            # Map params
            ars_k = float(params.get('ars_k', 1.23))
            ars_ema_per = int(params.get('ars_ema_period', 3))
            st_fac = float(params.get('st_factor', 3.0))
            st_hh_p = int(params.get('st_hhv_period', 10))
            st_atr_p = int(params.get('st_atr_period', 14))
            ema_f = int(params.get('ema_fast_period', 9))
            ema_s = int(params.get('ema_slow_period', 21))
            toma1 = int(params.get('toma_period1', 1))
            toma2 = float(params.get('toma_period2', 2.1))
            mfi_p = int(params.get('mfi_period', 14))
            atr_p = int(params.get('atr_period', 14))
            
            hhv_p = int(params.get('hhv_period', 12))
            llv_p = int(params.get('llv_period', 12))
            mfi_hhv = int(params.get('mfi_hhv_period', 5))
            mfi_llv = int(params.get('mfi_llv_period', 5))
            mfi_l = float(params.get('mfi_long', 55.0))
            mfi_s = float(params.get('mfi_short', 45.0))
            v_rat = float(params.get('vol_ratio', 0.8))
            atr_sl_l = float(params.get('atr_stop_mult_long', 1.5))
            atr_sl_s = float(params.get('atr_stop_mult_short', 1.5))
            ka_l = float(params.get('kar_al_yuzde_long', 2.0))
            ka_s = float(params.get('kar_al_yuzde_short', 2.0))
            mh_b = int(params.get('min_hold_bars', 2))
            mx_b = int(params.get('max_hold_bars', 20))
            cd_b = int(params.get('cooldown_bars', 2))
            
            vt = self.vade_tipi
            vt_code = 1
            if vt == 'SPOT':
                vt_code = 0
            elif vt == 'VIOP_SPOT':
                vt_code = 2
                
            # Get arrays from cache
            ars_ema_arr = cache.get_ema(ars_ema_per)
            st_val_arr = cache.get_st(st_fac, st_hh_p, st_atr_p)
            ema_f_arr = cache.get_ema(ema_f)
            ema_s_arr = cache.get_ema(ema_s)
            toma_arr = cache.get_toma(toma1, toma2)
            mfi_arr = cache.get_mfi(mfi_p)
            atr_arr = cache.get_atr(atr_p)
            
            try:
                from src.engine.data import OHLCV
                mask_arr = OHLCV(self.cache.df).get_trading_mask(vt).astype(bool)
            except:
                mask_arr = np.ones(len(self.cache.closes), dtype=bool)
                
            result = fast_backtest_strategy7(
                self.cache.closes, self.cache.highs, self.cache.lows, self.cache.volumes,
                ars_ema_arr, st_val_arr, ema_f_arr, ema_s_arr, toma_arr,
                mfi_arr, atr_arr, mask_arr, cache.times_arr,
                ars_k, hhv_p, llv_p, mfi_hhv, mfi_llv, mfi_l, mfi_s,
                v_rat, atr_sl_l, atr_sl_s, ka_l, ka_s, mh_b, mx_b, cd_b, vt_code
            )
            
            np_val, tr, pf_val, max_dd_val, sharpe_val, adays, tdays = result
            
            if tr == 0 or np_val <= -999:
                return {'net_profit': -999, 'trades': 0, 'pf': 0, 'max_dd': 999, 'fitness': -999}
            
            fitness = quick_fitness(
                np_val, pf_val, max_dd_val, tr, sharpe=sharpe_val,
                active_days=adays, total_days=tdays,
                commission=0.0, slippage=0.0
            )
            
            return {
                'net_profit': np_val,
                'trades': tr,
                'pf': pf_val,
                'max_dd': max_dd_val,
                'sharpe': sharpe_val,
                'fitness': fitness
            }
        except Exception as e:
            return {'net_profit': -999999, 'trades': 0, 'pf': 0, 'max_dd': 999999, 'fitness': -999999}
