import os
import re

S7_EVAL_CODE = '''    def _evaluate_strategy7(self, params: dict) -> dict:
        """Strateji 7 (DeepScalp) icin fitness hesapla."""
        try:
            from src.optimization.strategy7_optimizer import fast_backtest_strategy7, DeepScalpCache
            import numpy as np
            import pandas as pd
            from src.optimization.fitness import quick_fitness
            
            # Genetic/Bayesian cross-compatibility for cache structure
            opt_cache = None
            if hasattr(self, 'cache'):
                if 's7_cache' not in self.cache._cache:
                    self.cache._cache['s7_cache'] = DeepScalpCache(self.cache.df)
                opt_cache = self.cache._cache['s7_cache']
            else:
                if 's7_cache' not in self._indicator_cache:
                    self._indicator_cache['s7_cache'] = DeepScalpCache(self.df)
                opt_cache = self._indicator_cache['s7_cache']
            
            # Params
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
            if vt == 'SPOT': vt_code = 0
            elif vt == 'VIOP_SPOT': vt_code = 2
                
            # Get base arrays
            ars_ema_arr = opt_cache.get_ema(ars_ema_per)
            st_val_arr = opt_cache.get_st(st_fac, st_hh_p, st_atr_p)
            ema_f_arr = opt_cache.get_ema(ema_f)
            ema_s_arr = opt_cache.get_ema(ema_s)
            toma_arr = opt_cache.get_toma(toma1, toma2)[1] # toma_val
            mfi_arr = opt_cache.get_mfi(mfi_p)
            atr_arr = opt_cache.get_atr(atr_p)
            
            # PRE-COMPUTE Rolling arrays using Pandas (Performance Boost fix)
            hhv_shifted = pd.Series(opt_cache.highs).shift(1).rolling(hhv_p, min_periods=1).max().fillna(0).values.astype(np.float64)
            llv_shifted = pd.Series(opt_cache.lows).shift(1).rolling(llv_p, min_periods=1).min().fillna(9999999).values.astype(np.float64)
            mfi_hhv_shifted = pd.Series(mfi_arr).shift(1).rolling(mfi_hhv, min_periods=1).max().fillna(0).values.astype(np.float64)
            mfi_llv_shifted = pd.Series(mfi_arr).shift(1).rolling(mfi_llv, min_periods=1).min().fillna(9999999).values.astype(np.float64)
            vol_ma_shifted = pd.Series(opt_cache.volumes).shift(1).rolling(20, min_periods=1).mean().fillna(0).values.astype(np.float64)
            
            try:
                from src.engine.data import OHLCV
                df_src = self.cache.df if hasattr(self, 'cache') else self.df
                mask_arr = OHLCV(df_src).get_trading_mask(vt).astype(bool)
            except:
                mask_arr = np.ones(len(opt_cache.closes), dtype=bool)
                
            # RUN fast kernel (NEW SIGNATURE)
            result = fast_backtest_strategy7(
                opt_cache.closes, opt_cache.highs, opt_cache.lows, opt_cache.volumes,
                ars_ema_arr, st_val_arr, ema_f_arr, ema_s_arr, toma_arr,
                mfi_arr, atr_arr, mask_arr, opt_cache.times_arr,
                hhv_shifted, llv_shifted, mfi_hhv_shifted, mfi_llv_shifted, vol_ma_shifted,
                ars_k, mfi_l, mfi_s,
                v_rat, atr_sl_l, atr_sl_s, ka_l, ka_s, mh_b, mx_b, cd_b, vt_code
            )
            
            np_val, tr, pf_val, max_dd_val, sharpe_val, adays, tdays = result
            if tr == 0 or np_val <= -999:
                return {'net_profit': -999, 'trades': 0, 'pf': 0, 'max_dd': 999, 'fitness': -999}
            
            fitness = quick_fitness(
                np_val, pf_val, max_dd_val, tr, sharpe=sharpe_val,
                active_days=adays, total_days=tdays, commission=0.0, slippage=0.0
            )
            return {'net_profit': np_val,'trades': tr,'pf': pf_val,'max_dd': max_dd_val,'sharpe': sharpe_val,'fitness': fitness}
        except Exception as e:
            return {'net_profit': -999999, 'trades': 0, 'pf': 0, 'max_dd': 999999, 'fitness': -999999}
'''

def fix_bayesian():
    fpath = 'src/optimization/bayesian_optimizer.py'
    with open(fpath, 'r', encoding='utf-8') as f:
        content = f.read()
    
    # Regex ile eski fonksiyonu bul ve değiştir
    pattern = re.compile(r'    def _evaluate_strategy7\(self, params: Dict\[str, Any\]\) -> Dict\[str, float]:.*?        except Exception as e:\n            return \{\'net_profit\': -999999, \'trades\': 0, \'pf\': 0, \'max_dd\': 999999, \'fitness\': -999999\}', re.DOTALL)
    
    if pattern.search(content):
        new_content = pattern.sub(S7_EVAL_CODE.replace('dict', 'Dict[str, float]', 1).replace('dict', 'Dict[str, Any]', 1), content)
        with open(fpath, 'w', encoding='utf-8') as f:
            f.write(new_content)
        print("bayesian_optimizer.py FIX EDILDI.")
    else:
        print("bayesian_optimizer.py DÜZENLENEMEDİ (Eski patern bulunamadı).")

def fix_genetic():
    fpath = 'src/optimization/genetic_optimizer.py'
    with open(fpath, 'r', encoding='utf-8') as f:
        content = f.read()
        
    # Zaten eklenmiş mi?
    if 'def _evaluate_strategy7' in content:
        print("genetic_optimizer.py zaten S7 eval iceriyor.")
        return

    # S6_eval bitisini bulup arasina S7'yi ekle
    # S6 evaluasyonu satirina bakalim:
    s6_pattern = re.compile(r'(    def _evaluate_strategy6\(self, params: Dict\[str, Any\]\) -> Dict\[str, float]:.*?        except Exception as e:\n            return \{\'net_profit\': -999999, \'trades\': 0, \'pf\': 0, \'max_dd\': 999999, \'fitness\': -999999\}\n)', re.DOTALL)
    
    match = s6_pattern.search(content)
    if match:
        insertion = "\n" + S7_EVAL_CODE.replace('dict', 'Dict[str, float]', 1).replace('dict', 'Dict[str, Any]', 1) + "\n"
        new_content = content[:match.end()] + insertion + content[match.end():]
        with open(fpath, 'w', encoding='utf-8') as f:
            f.write(new_content)
        print("genetic_optimizer.py FIX EDILDI.")
    else:
        print("genetic_optimizer.py DÜZENLENEMEDİ (S6 paterni bulunamadı).")

if __name__ == '__main__':
    fix_bayesian()
    fix_genetic()
