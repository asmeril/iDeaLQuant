# -*- coding: utf-8 -*-
"""
Strategy 3 Optimizer (Paradise)
Hedef: Paradise stratejisi için en iyi parametreleri bulmak.
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

from src.indicators.core import EMA, SMA, ATR, Momentum, HHV, LLV
from src.engine.data import OHLCV

# Global cache
g_cache = None
g_mask = None

# --- INDICATOR CACHE ---
class IndicatorCache:
    def __init__(self, df):
        if 'close' in df.columns:
            self.closes = df['close'].values
            self.highs = df['high'].values
            self.lows = df['low'].values
            self.volumes = df['volume'].values # Using 'volume' column
        else:
            self.closes = df['Kapanis'].values
            self.highs = df['Yuksek'].values
            self.lows = df['Dusuk'].values
            self.volumes = df['Lot'].values
            
        if 'datetime' in df.columns:
            self.times_arr = df['datetime'].values.astype(np.int64) // 10**9
        elif 'date' in df.columns:
            self.times_arr = df['date'].values.astype(np.int64) // 10**9
        elif 'Tarih' in df.columns:
            self.times_arr = df['Tarih'].values.astype(np.int64) // 10**9
        elif 'DateTime' in df.columns:
            self.times_arr = df['DateTime'].values.astype(np.int64) // 10**9
        elif 'time' in df.columns:
            self.times_arr = df['time'].values.astype(np.int64) // 10**9
        else:
            self.times_arr = np.zeros(len(df), dtype=np.int64)
        
        # Determine actual volume column (lot vs volume)
        if 'lot' in df.columns:
             self.volumes = df['lot'].values
        
        self.ema_cache = {}
        self.dsma_cache = {}
        self.sma_cache = {}
        self.mom_cache = {}
        self.hhv_cache = {}
        self.llv_cache = {}
        self.atr_cache = {}
        self.vol_hhv_cache = {}

    def get_ema(self, period):
        if period not in self.ema_cache:
            self.ema_cache[period] = np.array(EMA(self.closes.tolist(), int(period)))
        return self.ema_cache[period]
        
    def get_dsma(self, period):
        if period not in self.dsma_cache:
            # DSMA = SMA(SMA(C, p), p)
            # Core SMA returns list
            s1 = SMA(self.closes.tolist(), int(period))
            s2 = SMA(s1, int(period))
            self.dsma_cache[period] = np.array(s2)
        return self.dsma_cache[period]

    def get_sma(self, period):
        if period not in self.sma_cache:
            self.sma_cache[period] = np.array(SMA(self.closes.tolist(), int(period)))
        return self.sma_cache[period]

    def get_mom(self, period):
        if period not in self.mom_cache:
            self.mom_cache[period] = np.array(Momentum(self.closes.tolist(), int(period)))
        return self.mom_cache[period]
        
    def get_hhv(self, period):
        if period not in self.hhv_cache:
            self.hhv_cache[period] = np.array(HHV(self.highs.tolist(), int(period)))
        return self.hhv_cache[period]

    def get_llv(self, period):
        if period not in self.llv_cache:
            self.llv_cache[period] = np.array(LLV(self.lows.tolist(), int(period)))
        return self.llv_cache[period]
        
    def get_atr(self, period):
        if period not in self.atr_cache:
            self.atr_cache[period] = np.array(ATR(self.highs.tolist(), self.lows.tolist(), self.closes.tolist(), int(period)))
        return self.atr_cache[period]

    def get_vol_hhv(self, period):
        if period not in self.vol_hhv_cache:
            self.vol_hhv_cache[period] = np.array(HHV(self.volumes.tolist(), int(period)))
        return self.vol_hhv_cache[period]

# --- DATA LOADING ---
def load_data_and_mask(vade_tipi="ENDEKS"):
    csv_path = "d:/Projects/IdealQuant/data/VIP_X030T_1dk_.csv"
    try:
        data = OHLCV.from_csv(csv_path, separator=';')
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
        g_mask = mask.values

# --- FAST BACKTEST (Paradise Logic) ---
@jit(nopython=True)
def fast_backtest_paradise(closes, highs, lows, volumes,
                           ema_arr, dsma_arr, sma_arr, mom_arr, 
                           hh_arr, ll_arr, atr_arr, vol_hhv_arr,
                           mask_arr, times_arr,
                           mom_limit_low, mom_limit_high, # 98, 102
                           atr_sl, atr_tp, atr_trail,
                           yon_modu_cift): # True=CIFT, False=SADECE_AL
    
    n = len(closes)
    
    pos = 0 # 0: Flat, 1: Long, -1: Short
    entry_price = 0.0
    extreme_price = 0.0
    
    gross_profit = 0.0
    gross_loss = 0.0
    trades = 0
    max_dd = 0.0
    peak_equity = 0.0
    current_equity = 0.0
    
    last_trade_day = -1
    active_days = 0
    total_days = 0
    last_day = -1
    
    # Logic:
    # AL: HH > Prev HH, EMA > DSMA, Close > SMA(20), Mom > 100, Vol > VolHHV * 0.8
    # SAT: LL < Prev LL, EMA < DSMA, Close < SMA(20), Mom < 100, Vol > VolHHV * 0.8
    
    for i in range(100, n): # Warmup
        if times_arr[i] != last_day:
            total_days += 1
            last_day = times_arr[i]
            
        # --- TRADING MASK CHECK ---
        if not mask_arr[i]:
            if pos != 0:
                pnl = 0.0
                if pos == 1: pnl = closes[i] - entry_price
                else: pnl = entry_price - closes[i]
                
                if pnl > 0: gross_profit += pnl
                else: gross_loss += abs(pnl)
                current_equity += pnl
                pos = 0
                max_dd = max(max_dd, peak_equity - current_equity)
            continue
            
        atr_val = atr_arr[i]
        
        # --- EXIT LOGIC ---
        if pos == 1:
            if closes[i] > extreme_price: extreme_price = closes[i]
            
            # SL
            if closes[i] <= entry_price - (atr_val * atr_sl):
                pnl = closes[i] - entry_price # Slippage could be added here
                if pnl > 0: gross_profit += pnl
                else: gross_loss += abs(pnl)
                current_equity += pnl
                pos = 0
            # TP
            elif closes[i] >= entry_price + (atr_val * atr_tp):
                pnl = closes[i] - entry_price
                if pnl > 0: gross_profit += pnl
                else: gross_loss += abs(pnl)
                current_equity += pnl
                pos = 0
            # Trailing
            elif closes[i] < extreme_price - (atr_val * atr_trail):
                pnl = closes[i] - entry_price
                if pnl > 0: gross_profit += pnl
                else: gross_loss += abs(pnl)
                current_equity += pnl
                pos = 0
                
            if pos == 0:
                max_dd = max(max_dd, peak_equity - current_equity)
                if current_equity > peak_equity: peak_equity = current_equity

        elif pos == -1:
            if closes[i] < extreme_price: extreme_price = closes[i]
            
            # SL
            if closes[i] >= entry_price + (atr_val * atr_sl):
                pnl = entry_price - closes[i]
                if pnl > 0: gross_profit += pnl
                else: gross_loss += abs(pnl)
                current_equity += pnl
                pos = 0
            # TP
            elif closes[i] <= entry_price - (atr_val * atr_tp):
                pnl = entry_price - closes[i]
                if pnl > 0: gross_profit += pnl
                else: gross_loss += abs(pnl)
                current_equity += pnl
                pos = 0
            # Trailing
            elif closes[i] > extreme_price + (atr_val * atr_trail):
                pnl = entry_price - closes[i]
                if pnl > 0: gross_profit += pnl
                else: gross_loss += abs(pnl)
                current_equity += pnl
                pos = 0
                
            if pos == 0:
                max_dd = max(max_dd, peak_equity - current_equity)
                if current_equity > peak_equity: peak_equity = current_equity

        # --- ENTRY LOGIC ---
        if pos == 0:
            mom = mom_arr[i]
            mom_band = (mom > mom_limit_low) and (mom < mom_limit_high)
            
            if mom_band:
                # Vol Check
                vol_ok = volumes[i] >= vol_hhv_arr[i-1] * 0.8
                if vol_ok:
                    # LONG
                    if (hh_arr[i] > hh_arr[i-1] and 
                        ema_arr[i] > dsma_arr[i] and 
                        closes[i] > sma_arr[i] and
                        mom > 100):
                        
                        pos = 1
                        entry_price = closes[i]
                        extreme_price = closes[i]
                        trades += 1
                        if times_arr[i] != last_trade_day:
                            active_days += 1
                            last_trade_day = times_arr[i]
                        
                    # SHORT (if allowed)
                    elif yon_modu_cift and (ll_arr[i] < ll_arr[i-1] and 
                                            ema_arr[i] < dsma_arr[i] and 
                                            closes[i] < sma_arr[i] and
                                            mom < 100):
                        
                        pos = -1
                        entry_price = closes[i]
                        extreme_price = closes[i]
                        trades += 1
                        if times_arr[i] != last_trade_day:
                            active_days += 1
                            last_trade_day = times_arr[i]

    net_profit = gross_profit - gross_loss
    pf = (gross_profit / gross_loss) if gross_loss > 0 else 999.0
    
    return net_profit, trades, pf, max_dd, active_days, total_days

# --- WORKER TASK ---
def solve_chunk(args):
    # params: atr_p, atr_sl, atr_tp, params_grid
    atr_p, atr_sls, atr_tps, params_grid = args
    
    global g_cache, g_mask
    if g_cache is None: return []
    
    results = []
    
    # Fixed params for now (optimization usually on Risk & Trend)
    ema_p = 21
    dsma_p = 50
    ma_p = 20
    hh_p = 25
    vol_p = 14
    mom_p = 60
    
    # Cached Arrays
    ema_arr = g_cache.get_ema(ema_p)
    dsma_arr = g_cache.get_dsma(dsma_p)
    sma_arr = g_cache.get_sma(ma_p)
    mom_arr = g_cache.get_mom(mom_p)
    hh_arr = g_cache.get_hhv(hh_p)
    ll_arr = g_cache.get_llv(hh_p)
    vol_hhv_arr = g_cache.get_vol_hhv(vol_p)
    atr_arr = g_cache.get_atr(atr_p)
    
    # Iterate other params
    atr_trails = params_grid.get('atr_trails', [2.5])
    mom_lows = params_grid.get('mom_lows', [98.0])
    mom_highs = params_grid.get('mom_highs', [102.0])
    
    # 2. Iterate fixed vars
    for sl in atr_sls:
        for tp in atr_tps:
            for trl in atr_trails:
                for ml in mom_lows:
                    for mh in mom_highs:
                        
                        np_val, tr, pf, dd, active_days, total_days = fast_backtest_paradise(
                            g_cache.closes, g_cache.highs, g_cache.lows, g_cache.volumes,
                            ema_arr, dsma_arr, sma_arr, mom_arr,
                            hh_arr, ll_arr, atr_arr, vol_hhv_arr,
                            g_mask, g_cache.times_arr,
                            ml, mh,
                            sl, tp, trl,
                            True # yon_modu_cift
                        )
                        
                        if np_val > 0:
                            results.append({
                                'NP': np_val, 'PF': pf, 'DD': dd, 'Tr': tr,
                                'ATR_P': atr_p, 'SL': sl, 'TP': tp, 'TRL': trl,
                                 'ML': ml, 'MH': mh,
                                 'active_days': active_days, 'total_days': total_days
                            })
                        
    return results

def run_strategy3_optimization(vade_tipi="ENDEKS"):
    print(f"--- S3 (Paradise) Optimization Starting ({vade_tipi}) ---")
    
    grid = {
        'atr_periods': [10, 14, 20],
        'atr_sls': [1.5, 2.0, 2.5, 3.0],
        'atr_tps': [3.0, 4.0, 5.0, 6.0],
        'atr_trails': [2.0, 2.5, 3.0],
        'mom_lows': [98.0],
        'mom_highs': [102.0]
    }
    
    tasks = []
    for ap in grid['atr_periods']:
        for sl in grid['atr_sls']:
            for tp in grid['atr_tps']:
                tasks.append((ap, sl, tp, grid))
            
    print(f"Total Tasks: {len(tasks)}")
    
    start_time = time()
    final_results = []
    
    with Pool(processes=min(16, cpu_count()), initializer=worker_init, initargs=(vade_tipi,)) as pool:
        for res in pool.imap_unordered(solve_chunk, tasks):
            final_results.extend(res)
            
    elapsed = time() - start_time
    print(f"Done in {elapsed:.1f}s. Results: {len(final_results)}")
    
    if final_results:
        import sys
        sys.path.append(os.path.abspath(os.path.join(os.path.dirname(__file__), '..', '..')))
        from src.optimization.fitness import quick_fitness
        
        df = pd.DataFrame(final_results)
        
        for idx, row in df.iterrows():
             df.at[idx, 'Score'] = quick_fitness(
                 net_profit=row['NP'],
                 pf=row['PF'],
                 max_dd=row['DD'],
                 trades=row['Tr'],
                 initial_capital=100000.0,
                 active_days=row.get('active_days', 0),
                 total_days=row.get('total_days', 0)
             )
             
        df = df.sort_values('Score', ascending=False)
        
        # === OOS VALIDATION (Top 50) ===
        print("\n--- OOS Validation (Top 50) ---")
        df_full, mask_full = load_data_and_mask(vade_tipi)
        if df_full is not None:
            n = len(df_full)
            split = int(n * 0.7)
            df_test = df_full.iloc[split:].reset_index(drop=True)
            mask_test = mask_full[split:]
            test_cache = IndicatorCache(df_test)
            
            top50 = df.head(50).to_dict('records')
            for r in top50:
                try:
                    atr_p = int(r['ATR_P'])
                    ema_arr = test_cache.get_ema(21)
                    dsma_arr = test_cache.get_dsma(50)
                    sma_arr = test_cache.get_sma(20)
                    mom_arr = test_cache.get_mom(60)
                    hh_arr = test_cache.get_hhv(25)
                    ll_arr = test_cache.get_llv(25)
                    atr_arr = test_cache.get_atr(atr_p)
                    vol_hhv_arr = test_cache.get_vol_hhv(14)
                    
                    np_val, tr, pf, dd, adays, tdays = fast_backtest_paradise(
                        test_cache.closes, test_cache.highs, test_cache.lows, test_cache.volumes,
                        ema_arr, dsma_arr, sma_arr, mom_arr,
                        hh_arr, ll_arr, atr_arr, vol_hhv_arr,
                        mask_test, test_cache.times_arr,
                        float(r['ML']), float(r['MH']),
                        float(r['SL']), float(r['TP']), float(r['TRL']),
                        True  # yon_modu_cift
                    )
                    r['test_net'] = np_val
                    r['test_trades'] = tr
                    r['test_pf'] = pf
                    r['test_dd'] = dd
                except Exception as e:
                    print(f"  OOS hata: {e}")
                    r['test_net'] = None
                
                # === OOS-AWARE RE-RANKING via Advanced Fitness ===
                test_net = r.get('test_net', None)
                if test_net is not None:
                    new_score = quick_fitness(
                        net_profit=r['NP'],
                        pf=r['PF'],
                        max_dd=r['DD'],
                        trades=r['Tr'],
                        initial_capital=100000.0,
                        active_days=r.get('active_days', 0),
                        total_days=r.get('total_days', 0),
                        test_net_profit=r['test_net'],
                        test_pf=r['test_pf']
                    )
                    r['oos_penalized_score'] = new_score
                else:
                    r['oos_penalized_score'] = r.get('Score', 0)
            
            # Re-rank by OOS penalized score
            top50.sort(key=lambda x: x.get('oos_penalized_score', 0), reverse=True)
            df_final = pd.DataFrame(top50)
            
            best = df_final.iloc[0]
            print(f"\nBEST S3 Result (OOS Re-Ranked):\n{best.to_string()}")
        else:
            df_final = df.head(50)
            best = df_final.iloc[0]
            print(f"\nBEST S3 Result:\n{best.to_string()}")
        
        os.makedirs(r"d:\Projects\IdealQuant\results", exist_ok=True)
        df_final.to_csv(r"d:\Projects\IdealQuant\results\strategy3_results.csv", index=False)


if __name__ == "__main__":
    import multiprocessing
    multiprocessing.freeze_support()
    run_strategy3_optimization()
