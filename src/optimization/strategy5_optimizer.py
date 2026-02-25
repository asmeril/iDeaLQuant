# -*- coding: utf-8 -*-
"""
Strategy 5 Optimizer (Oliver Kell - Base 'n Break)
Hedef: Oliver Kell stratejisi için en iyi parametreleri bulmak.
Yöntem: Numba JIT + Vade/Tatil Maskesi (Hız + Doğruluk)
"""

import sys
import os
import numpy as np
import pandas as pd
from time import time
from multiprocessing import Pool, cpu_count, current_process
from numba import jit

# Proje kök dizini
sys.path.insert(0, os.path.abspath(os.path.join(os.path.dirname(__file__), '..', '..')))

from src.indicators.core import EMA, ADX, HHV, LLV
from src.engine.data import OHLCV

# Global cache
g_cache = None
g_mask = None


# --- INDICATOR CACHE ---
class IndicatorCache:
    def __init__(self, df):
        # Support both English and Turkish column names
        if 'close' in df.columns:
            self.closes = df['close'].values.astype(np.float64)
            self.highs = df['high'].values.astype(np.float64)
            self.lows = df['low'].values.astype(np.float64)
            self.volume = df['volume'].values.astype(np.float64)
        elif 'Kapanis' in df.columns:
            self.closes = df['Kapanis'].values.astype(np.float64)
            self.highs = df['Yuksek'].values.astype(np.float64)
            self.lows = df['Dusuk'].values.astype(np.float64)
            vol_col = 'Lot' if 'Lot' in df.columns else 'Hacim'
            self.volume = df[vol_col].values.astype(np.float64)
        else:
            raise ValueError("DataFrame must contain 'close' or 'Kapanis' columns")
            
        if 'datetime' in df.columns:
            self.times_arr = df['datetime'].astype('datetime64[s]').astype(np.int64).values
        elif 'date' in df.columns:
            self.times_arr = df['date'].astype('datetime64[s]').astype(np.int64).values
        elif 'Tarih' in df.columns:
            self.times_arr = df['Tarih'].astype('datetime64[s]').astype(np.int64).values
        elif 'DateTime' in df.columns:
            self.times_arr = df['DateTime'].astype('datetime64[s]').astype(np.int64).values
        elif 'time' in df.columns:
            self.times_arr = df['time'].astype('datetime64[s]').astype(np.int64).values
        else:
            self.times_arr = np.zeros(len(df), dtype=np.int64)
        
        # Caches
        self.ema_cache = {}     # period -> values
        self.adx_cache = {}     # period -> values
        self.hhv_cache = {}     # period -> values
        self.llv_cache = {}     # period -> values
        self.vol_ma_cache = {}  # period -> values

    def get_ema(self, period):
        if period not in self.ema_cache:
            self.ema_cache[period] = np.array(EMA(self.closes.tolist(), int(period)), dtype=np.float64)
        return self.ema_cache[period]
    
    def get_adx(self, period):
        if period not in self.adx_cache:
            self.adx_cache[period] = np.array(
                ADX(self.highs.tolist(), self.lows.tolist(), self.closes.tolist(), int(period)),
                dtype=np.float64
            )
        return self.adx_cache[period]
    
    def get_hhv(self, period):
        if period not in self.hhv_cache:
            self.hhv_cache[period] = np.array(HHV(self.highs.tolist(), int(period)), dtype=np.float64)
        return self.hhv_cache[period]

    def get_llv(self, period):
        if period not in self.llv_cache:
            self.llv_cache[period] = np.array(LLV(self.lows.tolist(), int(period)), dtype=np.float64)
        return self.llv_cache[period]
    
    def get_vol_ma(self, period):
        """Simple Moving Average of Volume"""
        if period not in self.vol_ma_cache:
            n = len(self.volume)
            vol_ma = np.zeros(n, dtype=np.float64)
            for i in range(period - 1, n):
                s = 0.0
                for j in range(period):
                    s += self.volume[i - j]
                vol_ma[i] = s / period
            self.vol_ma_cache[period] = vol_ma
        return self.vol_ma_cache[period]


# --- DATA LOADING ---
def load_data_and_mask(vade_tipi="ENDEKS"):
    csv_path = "d:/Projects/IdealQuant/data/VIP_X030T_1dk_.csv"
    try:
        data = OHLCV.from_ideal_export(csv_path)
        if current_process().name == 'MainProcess':
            print(f"Veri Yuklendi: {len(data)} Bar")
            
        mask = data.get_trading_mask(vade_tipi)
        return data.df, mask
    except Exception as e:
        print(f"Hata: {e}")
        return None, None

def worker_init(vade_tipi="ENDEKS"):
    global g_cache, g_mask
    df, mask = load_data_and_mask(vade_tipi)
    if df is not None:
        g_cache = IndicatorCache(df)
        g_mask = mask


# --- PARALLEL WORKER FUNCTIONS ---
_g_s5 = {}  # Global shared state for worker processes

def s5_parallel_init(shared_data):
    """Initializer for parallel workers. shared_data is a dict of ALL needed arrays."""
    global _g_s5
    _g_s5 = shared_data
    import signal
    try:
        signal.signal(signal.SIGINT, signal.SIG_IGN)
    except (OSError, ValueError):
        pass

def s5_eval(params):
    """
    Single parameter combination evaluation.
    params: (ema_fast, ema_slow, breakout_p, adx_p, adx_thresh, vol_ma_p, trail_pct)
    Returns: result dict or None
    """
    from src.optimization.fitness import quick_fitness
    
    ema_fast, ema_slow, breakout_p, adx_p, adx_thresh, vol_ma_p, trail_pct = params
    g = _g_s5
    
    # Get indicator arrays from pre-cached data using keys
    ema_fast_arr = g['ema'].get(ema_fast)
    ema_slow_arr = g['ema'].get(ema_slow)
    adx_arr = g['adx'].get(adx_p)
    hhv_arr = g['hhv'].get(breakout_p)
    llv_arr = g['llv'].get(breakout_p)
    vol_ma_arr = g['vol_ma'].get(vol_ma_p)
    
    if any(v is None for v in [ema_fast_arr, ema_slow_arr, adx_arr, hhv_arr, llv_arr, vol_ma_arr]):
        return None
    
    res = fast_backtest_strategy5(
        g['closes'], g['highs'], g['lows'], g['volume'],
        ema_fast_arr, ema_slow_arr,
        adx_arr, hhv_arr, llv_arr, vol_ma_arr,
        g['mask'], g['times_arr'],
        adx_thresh, trail_pct / 100.0
    )
    
    np_val, tr, pf, dd, sh, adays, tdays = res
    
    if np_val > 0 and pf >= 1.0 and tr >= 5:
        fitness = quick_fitness(np_val, pf, dd, tr, active_days=adays, total_days=tdays, sharpe=sh)
        if fitness > 0:
            return {
                'ema_fast': ema_fast, 'ema_slow': ema_slow,
                'breakout_period': breakout_p, 'adx_period': adx_p,
                'adx_threshold': adx_thresh, 'vol_ma_period': vol_ma_p,
                'trailing_stop_pct': trail_pct,
                'net_profit': np_val, 'trades': tr, 'pf': pf, 'max_dd': dd,
                'sharpe': sh, 'fitness': fitness,
                'active_days': adays, 'total_days': tdays
            }
    return None


# --- FAST BACKTEST (Strategy 5 Logic - Oliver Kell) ---
@jit(nopython=True)
def fast_backtest_strategy5(closes, highs, lows, volume,
                             ema_fast, ema_slow,
                             adx_arr, hhv_arr, llv_arr, vol_ma_arr,
                             mask_arr, times_arr,
                             # Params
                             adx_threshold, trailing_stop_ratio):
    """
    Numba JIT optimized backtest for Oliver Kell strategy.
    Returns: (net_profit, trades, pf, max_dd, sharpe, active_days, total_days)
    """
    n = len(closes)
    pos = 0  # 0=Flat, 1=Long, -1=Short
    entry_price = 0.0
    uc_uc_mesafe = 0.0
    stop_seviyesi = 0.0
    
    gross_profit = 0.0
    gross_loss = 0.0
    trades = 0
    max_dd = 0.0
    peak_equity = 0.0
    current_equity = 0.0
    
    # Sharpe accumulators (online mean/var)
    sum_pnl = 0.0
    sum_pnl_sq = 0.0
    n_closed = 0
    
    last_trade_day = -1
    active_days = 0
    total_days = 0
    last_day = -1
    
    # Warmup: enough data for all indicators
    min_warmup = 50  # Conservative: EMA slow (max 50) + ADX (max 30) + Breakout (max 50)
    
    for i in range(min_warmup, n):
        current_day = times_arr[i] // 86400
        if current_day != last_day:
            total_days += 1
            last_day = current_day
        
        # --- TRADING MASK CHECK ---
        if not mask_arr[i]:
            if pos != 0:
                # Force Close
                pnl = closes[i] - entry_price if pos == 1 else entry_price - closes[i]
                if pnl > 0: gross_profit += pnl
                else: gross_loss += abs(pnl)
                current_equity += pnl
                sum_pnl += pnl
                sum_pnl_sq += pnl * pnl
                n_closed += 1
                pos = 0
                uc_uc_mesafe = 0.0
                stop_seviyesi = 0.0
                
                if current_equity > peak_equity: peak_equity = current_equity
                dd = peak_equity - current_equity
                if dd > max_dd: max_dd = dd
            continue
        
        # --- KOŞULLAR ---
        # LONG
        long_trend = closes[i] > ema_fast[i] and closes[i] > ema_slow[i]
        long_break = closes[i] > hhv_arr[i - 1]
        trend_gucu_long = adx_arr[i] > adx_threshold and ema_fast[i] > ema_fast[i - 1]
        
        # SHORT 
        short_trend = closes[i] < ema_fast[i] and closes[i] < ema_slow[i]
        short_break = closes[i] < llv_arr[i - 1]
        trend_gucu_short = adx_arr[i] > adx_threshold and ema_fast[i] < ema_fast[i - 1]
        
        guclu_hacim = volume[i] > vol_ma_arr[i]
        
        # EMA Crossback
        ema_crossback_long = closes[i] < ema_fast[i] and closes[i] < ema_slow[i]
        ema_crossback_short = closes[i] > ema_fast[i] and closes[i] > ema_slow[i]
        
        # --- POZİSYON YÖNETİMİ ---
        if pos == 0:
            # GİRİŞ
            if long_trend and long_break and guclu_hacim and trend_gucu_long:
                pos = 1
                entry_price = closes[i]
                uc_uc_mesafe = closes[i]
                stop_seviyesi = lows[i] if trailing_stop_ratio > 0 else 0.0
                trades += 1
                if current_day != last_trade_day:
                    active_days += 1
                    last_trade_day = current_day
            elif short_trend and short_break and guclu_hacim and trend_gucu_short:
                pos = -1
                entry_price = closes[i]
                uc_uc_mesafe = closes[i]
                stop_seviyesi = highs[i] if trailing_stop_ratio > 0 else 999999.0
                trades += 1
                if current_day != last_trade_day:
                    active_days += 1
                    last_trade_day = current_day
                    
        elif pos == 1:
            # LONG yönetimi
            # Trailing stop güncelle (sadece aktifse)
            if trailing_stop_ratio > 0:
                if closes[i] > uc_uc_mesafe:
                    uc_uc_mesafe = closes[i]
                    yeni_stop = uc_uc_mesafe * (1.0 - trailing_stop_ratio)
                    if yeni_stop > stop_seviyesi:
                        stop_seviyesi = yeni_stop
            
            # Çıkış kontrolü
            exit_long = ema_crossback_long
            if trailing_stop_ratio > 0 and lows[i] <= stop_seviyesi:
                exit_long = True
            
            if exit_long:
                pnl = closes[i] - entry_price
                if pnl > 0: gross_profit += pnl
                else: gross_loss += abs(pnl)
                current_equity += pnl
                sum_pnl += pnl
                sum_pnl_sq += pnl * pnl
                n_closed += 1
                
                # Reverse check: çıkış anında karşı yönde giriş var mı?
                if short_trend and short_break and guclu_hacim and trend_gucu_short:
                    pos = -1
                    entry_price = closes[i]
                    uc_uc_mesafe = closes[i]
                    stop_seviyesi = highs[i] if trailing_stop_ratio > 0 else 999999.0
                    trades += 1
                    if current_day != last_trade_day:
                        active_days += 1
                        last_trade_day = current_day
                else:
                    pos = 0
                    uc_uc_mesafe = 0.0
                    stop_seviyesi = 0.0
                    
        elif pos == -1:
            # SHORT yönetimi
            # Trailing stop güncelle (sadece aktifse)
            if trailing_stop_ratio > 0:
                if closes[i] < uc_uc_mesafe:
                    uc_uc_mesafe = closes[i]
                    yeni_stop = uc_uc_mesafe * (1.0 + trailing_stop_ratio)
                    if yeni_stop < stop_seviyesi or stop_seviyesi == 0:
                        stop_seviyesi = yeni_stop
            
            # Çıkış kontrolü
            exit_short = ema_crossback_short
            if trailing_stop_ratio > 0 and highs[i] >= stop_seviyesi:
                exit_short = True
            
            if exit_short:
                pnl = entry_price - closes[i]
                if pnl > 0: gross_profit += pnl
                else: gross_loss += abs(pnl)
                current_equity += pnl
                sum_pnl += pnl
                sum_pnl_sq += pnl * pnl
                n_closed += 1
                
                # Reverse check
                if long_trend and long_break and guclu_hacim and trend_gucu_long:
                    pos = 1
                    entry_price = closes[i]
                    uc_uc_mesafe = closes[i]
                    stop_seviyesi = lows[i] if trailing_stop_ratio > 0 else 0.0
                    trades += 1
                    if current_day != last_trade_day:
                        active_days += 1
                        last_trade_day = current_day
                else:
                    pos = 0
                    uc_uc_mesafe = 0.0
                    stop_seviyesi = 0.0
        
        # Update DD
        if current_equity > peak_equity: peak_equity = current_equity
        dd = peak_equity - current_equity
        if dd > max_dd: max_dd = dd

    net_profit = gross_profit - gross_loss
    pf = (gross_profit / gross_loss) if gross_loss > 0 else 999.0
    
    # Sharpe Ratio (Trade-Based)
    sharpe = 0.0
    if n_closed > 1:
        mean_pnl = sum_pnl / n_closed
        var_pnl = (sum_pnl_sq / n_closed) - (mean_pnl * mean_pnl)
        if var_pnl > 0:
            std_pnl = var_pnl ** 0.5
            sharpe = mean_pnl / std_pnl
    
    return net_profit, trades, pf, max_dd, sharpe, active_days, total_days


# --- WORKER TASK ---
def solve_chunk(args):
    """Phase 1: Grid search over a chunk of parameter combos."""
    ema_fast_p, ema_slow_p, params_grid = args
    
    global g_cache, g_mask
    if g_cache is None: return []
    
    results = []
    
    # Get cached arrays
    try:
        ema_fast_arr = g_cache.get_ema(ema_fast_p)
        ema_slow_arr = g_cache.get_ema(ema_slow_p)
    except Exception:
        return []
    
    breakout_ps = params_grid.get('breakout_periods', [10])
    adx_ps = params_grid.get('adx_periods', [14])
    adx_thresholds = params_grid.get('adx_thresholds', [20.0])
    vol_ma_ps = params_grid.get('vol_ma_periods', [20])
    trail_pcts = params_grid.get('trailing_stop_pcts', [1.5])
    
    for bp in breakout_ps:
        hhv = g_cache.get_hhv(bp)
        llv = g_cache.get_llv(bp)
        for adx_p in adx_ps:
            adx = g_cache.get_adx(adx_p)
            for adx_t in adx_thresholds:
                for vp in vol_ma_ps:
                    vol_ma = g_cache.get_vol_ma(vp)
                    for tp in trail_pcts:
                        np_val, tr, pf, dd, sh, adays, tdays = fast_backtest_strategy5(
                            g_cache.closes, g_cache.highs, g_cache.lows, g_cache.volume,
                            ema_fast_arr, ema_slow_arr,
                            adx, hhv, llv, vol_ma,
                            g_mask, g_cache.times_arr,
                            adx_t, tp / 100.0
                        )
                        
                        if np_val > 0:
                            results.append({
                                'NP': np_val, 'PF': pf, 'DD': dd, 'Tr': tr,
                                'Sharpe': sh,
                                'EMA_F': ema_fast_p, 'EMA_S': ema_slow_p,
                                'BP': bp, 'ADX_P': adx_p, 'ADX_T': adx_t,
                                'VOL_P': vp, 'TRAIL': tp,
                                'active_days': adays, 'total_days': tdays
                            })
    
    return results


def run_strategy5_optimization():
    print("--- S5 (Oliver Kell) Optimization Starting ---")
    
    grid = {
        'ema_fasts': list(range(5, 21, 5)),       # 5, 10, 15, 20
        'ema_slows': list(range(10, 51, 5)),       # 10, 15, ... 50
        'breakout_periods': list(range(5, 31, 5)), # 5, 10, ... 30
        'adx_periods': [10, 14, 20],
        'adx_thresholds': [15.0, 20.0, 25.0, 30.0],
        'vol_ma_periods': [10, 15, 20, 30],
        'trailing_stop_pcts': [1.0, 1.5, 2.0, 2.5, 3.0],
    }
    
    tasks = []
    for ef in grid['ema_fasts']:
        for es in grid['ema_slows']:
            if es > ef:  # EMA slow must be > EMA fast
                tasks.append((ef, es, grid))
    
    print(f"Total Tasks (EMA Chunks): {len(tasks)}")
    
    start_time = time()
    final_results = []
    
    with Pool(processes=min(16, cpu_count()), initializer=worker_init) as pool:
        for res in pool.imap_unordered(solve_chunk, tasks):
            final_results.extend(res)
    
    elapsed = time() - start_time
    print(f"Done in {elapsed:.1f}s. Results: {len(final_results)}")
    
    if final_results:
        df = pd.DataFrame(final_results)
        df['Score'] = df['NP'] * df['PF']
        best = df.nlargest(1, 'Score').iloc[0]
        print(f"\nBEST S5 Result:\n{best.to_string()}")
        os.makedirs(r"d:\Projects\IdealQuant\results", exist_ok=True)
        df.sort_values('Score', ascending=False).head(50).to_csv(r"d:\Projects\IdealQuant\results\strategy5_results.csv")


if __name__ == "__main__":
    import multiprocessing
    multiprocessing.freeze_support()
    run_strategy5_optimization()
