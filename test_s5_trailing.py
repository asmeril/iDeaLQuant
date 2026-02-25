"""Quick diagnostic: compare backtest with trailing stop ON vs OFF"""
import sys, os
sys.path.insert(0, os.path.abspath('.'))

import numpy as np
from src.optimization.strategy5_optimizer import fast_backtest_strategy5, IndicatorCache, load_data_and_mask

if __name__ == '__main__':
    import multiprocessing
    multiprocessing.freeze_support()
    
    df, mask = load_data_and_mask("ENDEKS")
    cache = IndicatorCache(df)
    
    n = len(cache.closes)
    closes = np.ascontiguousarray(cache.closes, dtype=np.float64)
    highs = np.ascontiguousarray(cache.highs, dtype=np.float64)
    lows = np.ascontiguousarray(cache.lows, dtype=np.float64)
    vols = np.ascontiguousarray(cache.volume, dtype=np.float64)
    mask_arr = np.ones(n, dtype=np.bool_)
    times = cache.times_arr
    
    # Default params
    ema_fast = np.ascontiguousarray(cache.get_ema(10), dtype=np.float64)
    ema_slow = np.ascontiguousarray(cache.get_ema(20), dtype=np.float64)
    adx = np.ascontiguousarray(cache.get_adx(14), dtype=np.float64)
    hhv = np.ascontiguousarray(cache.get_hhv(10), dtype=np.float64)
    llv = np.ascontiguousarray(cache.get_llv(10), dtype=np.float64)
    vol_ma = np.ascontiguousarray(cache.get_vol_ma(20), dtype=np.float64)
    
    print(f"Toplam bar: {n}")
    print(f"Fiyat araligi: {closes[0]:.2f} - {closes[-1]:.2f}")
    print()
    
    # Test 1: Trailing Stop = 0 (devre disi)
    r1 = fast_backtest_strategy5(closes, highs, lows, vols, ema_fast, ema_slow, adx, hhv, llv, vol_ma, mask_arr, times, 20.0, 0.0)
    print(f"Trailing Stop OFF (0%):  NP={r1[0]:.0f}  Trades={r1[1]}  PF={r1[2]:.2f}  DD={r1[3]:.0f}  Sharpe={r1[4]:.3f}")
    
    # Test 2: Trailing Stop = 1.5%
    r2 = fast_backtest_strategy5(closes, highs, lows, vols, ema_fast, ema_slow, adx, hhv, llv, vol_ma, mask_arr, times, 20.0, 0.015)
    print(f"Trailing Stop ON (1.5%): NP={r2[0]:.0f}  Trades={r2[1]}  PF={r2[2]:.2f}  DD={r2[3]:.0f}  Sharpe={r2[4]:.3f}")
    
    # Test 3: Trailing Stop = 3%
    r3 = fast_backtest_strategy5(closes, highs, lows, vols, ema_fast, ema_slow, adx, hhv, llv, vol_ma, mask_arr, times, 20.0, 0.03)
    print(f"Trailing Stop ON (3.0%): NP={r3[0]:.0f}  Trades={r3[1]}  PF={r3[2]:.2f}  DD={r3[3]:.0f}  Sharpe={r3[4]:.3f}")
    
    # Test 4: ADX threshold 15
    r4 = fast_backtest_strategy5(closes, highs, lows, vols, ema_fast, ema_slow, adx, hhv, llv, vol_ma, mask_arr, times, 15.0, 0.0)
    print(f"ADX=15, TS OFF:          NP={r4[0]:.0f}  Trades={r4[1]}  PF={r4[2]:.2f}  DD={r4[3]:.0f}  Sharpe={r4[4]:.3f}")
    
    # Optimizator params (ema_fast=13, ema_slow=10)
    ema_f13 = np.ascontiguousarray(cache.get_ema(13), dtype=np.float64)
    ema_s10 = np.ascontiguousarray(cache.get_ema(10), dtype=np.float64)
    adx28 = np.ascontiguousarray(cache.get_adx(28), dtype=np.float64)
    hhv15 = np.ascontiguousarray(cache.get_hhv(15), dtype=np.float64)
    llv15 = np.ascontiguousarray(cache.get_llv(15), dtype=np.float64)
    vol_ma27 = np.ascontiguousarray(cache.get_vol_ma(27), dtype=np.float64)
    
    r5 = fast_backtest_strategy5(closes, highs, lows, vols, ema_f13, ema_s10, adx28, hhv15, llv15, vol_ma27, mask_arr, times, 20.0, 0.0)
    print(f"\nOptimizer best (13/10):  NP={r5[0]:.0f}  Trades={r5[1]}  PF={r5[2]:.2f}  DD={r5[3]:.0f}  Sharpe={r5[4]:.3f}")
    
    r6 = fast_backtest_strategy5(closes, highs, lows, vols, ema_f13, ema_s10, adx28, hhv15, llv15, vol_ma27, mask_arr, times, 20.0, 0.01)
    print(f"Optimizer best + 1% TS:  NP={r6[0]:.0f}  Trades={r6[1]}  PF={r6[2]:.2f}  DD={r6[3]:.0f}  Sharpe={r6[4]:.3f}")
