# -*- coding: utf-8 -*-
"""
Strategy 6 Optimizer (TOTT_HOTT)
Hedef: TOTT_HOTT (VIP_TUPRS_5DK_Paradise) stratejisi için en iyi parametreleri bulmak.
Yöntem: Numba JIT + Katmanlı Optimizasyon (Ana Trend, Bölge, Kapı Testleri)
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

from src.indicators.core import MA, HHV, LLV
from src.indicators.trend import TTI
from src.indicators.oscillators import StochasticFast
from src.engine.data import OHLCV
from src.optimization.fitness import quick_fitness

# Global cache
g_cache = None
g_mask = None


class TOTT_HOTT_Cache:
    """TOTT_HOTT Stratejisine Özel İndikatör Cache Sistemi"""
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
        else:
            self.times_arr = np.zeros(len(df), dtype=np.int64)
        
        self.raw_stoch_cache = {}    # (period, smooth) -> values
        self.stoch_ma_cache = {}     # (period, smooth, ma_period) -> values
        self.vma_cache = {}          # period -> values
        self.tti_cache = {}          # (source_name, period, opt_param) -> values
        self.hhv_cache = {}
        self.llv_cache = {}
        
    def get_stoch(self, k_period, smooth):
        cache_key = (k_period, smooth)
        if cache_key not in self.raw_stoch_cache:
            stoch = np.array(StochasticFast(self.highs.tolist(), self.lows.tolist(), self.closes.tolist(), int(k_period)), dtype=np.float64)
            if smooth > 1:
                stoch = np.array(MA(stoch.tolist(), "sma", int(smooth)), dtype=np.float64)
            self.raw_stoch_cache[cache_key] = stoch
        return self.raw_stoch_cache[cache_key]

    def get_stoch_ma(self, k_period, smooth, ma_period):
        cache_key = (k_period, smooth, ma_period)
        if cache_key not in self.stoch_ma_cache:
            base_stoch = self.get_stoch(k_period, smooth)
            self.stoch_ma_cache[cache_key] = np.array(MA(base_stoch.tolist(), "variable", int(ma_period)), dtype=np.float64)
        return self.stoch_ma_cache[cache_key]
        
    def get_vma(self, period):
        if period not in self.vma_cache:
            self.vma_cache[period] = np.array(MA(self.closes.tolist(), "variable", int(period)), dtype=np.float64)
        return self.vma_cache[period]
        
    def get_hhv(self, period):
        if period not in self.hhv_cache:
            self.hhv_cache[period] = np.array(HHV(self.highs.tolist(), int(period)), dtype=np.float64)
        return self.hhv_cache[period]
        
    def get_llv(self, period):
        if period not in self.llv_cache:
            self.llv_cache[period] = np.array(LLV(self.lows.tolist(), int(period)), dtype=np.float64)
        return self.llv_cache[period]
        
    def get_tti(self, source_name, source_arr, period, opt_param):
        """source_arr must be double[]"""
        cache_key = (source_name, period, opt_param)
        if cache_key not in self.tti_cache:
            # We do Variable MA inside TTI
            tti_line = np.array(TTI(source_arr.tolist(), int(period), float(opt_param), "variable"), dtype=np.float64)
            self.tti_cache[cache_key] = tti_line
        return self.tti_cache[cache_key]


def load_data_and_mask(vade_tipi="ENDEKS"):
    csv_path = r"D:\Projects\IdealQuant\data\VIPX030T_1Dk_BarData.csv"
        
    try:
        data = OHLCV.from_ideal_export(csv_path)
        
        if current_process().name == 'MainProcess':
            print(f"Veri Yuklendi: {len(data)} Bar - {csv_path}")
            
        mask = data.get_trading_mask(vade_tipi)
        return data.df, mask
    except Exception as e:
        print(f"Hata data load: {e}")
        return None, None

def worker_init(vade_tipi="ENDEKS"):
    global g_cache, g_mask
    df, mask = load_data_and_mask(vade_tipi)
    if df is not None:
        g_cache = TOTT_HOTT_Cache(df)
        g_mask = mask


# =========================================================================
# NUMBA FAST BACKTEST (TOTT_HOTT)
# =========================================================================

# Helper for rolling sum inside numba
@jit(nopython=True)
def calc_rolling_sum(arr, window):
    n = len(arr)
    res = np.zeros(n, dtype=np.float64)
    for i in range(window - 1, n):
        s = 0.0
        for j in range(window):
            s += arr[i - j]
        res[i] = s
    return res

@jit(nopython=True)
def fast_backtest_tott_hott(
    closes, highs, lows, mask_arr, times_arr,
    # Arrays
    mov1, ott1, mov2, ott2, 
    stosk1, sott1, sott2,
    ott3, ott4, mov3, ott5, ott6,
    mov4, ott7, ott8, mov5, ott9,
    # Constants / Multipliers
    l1_mult, l2_mult, sat_mult1, sat_mult2,
    sum11_period, sum22_period, sum33_period, sum44_period
):
    """
    Numba JIT optimized backtest for TOTT_HOTT (Strategy 6).
    Returns (net_profit, trades, pf, max_dd, sharpe, active_days, total_days)
    """
    n = len(closes)
    
    # 1. Prepare secondary arrays internally (Numba supported)
    stoch_x = np.zeros(n, dtype=np.float64)
    sum1_raw = np.zeros(n, dtype=np.float64)
    sum3_raw = np.zeros(n, dtype=np.float64)
    
    for i in range(n):
        stoch_x[i] = stosk1[i] + 1000.0
        if closes[i] > ott3[i]: sum1_raw[i] = -1.0
        if closes[i] > ott8[i]: sum3_raw[i] = -1.0
        
    sum11 = calc_rolling_sum(sum1_raw, sum11_period)
    sum22 = calc_rolling_sum(sum1_raw, sum22_period)
    sum33 = calc_rolling_sum(sum3_raw, sum33_period)
    sum44 = calc_rolling_sum(sum3_raw, sum44_period)
    
    # Precalc L1/L2
    L1 = np.zeros(n, dtype=np.float64)
    L2 = np.zeros(n, dtype=np.float64)
    for i in range(n):
        L1[i] = ott2[i] * (1.0 + l1_mult)
        L2[i] = ott5[i] * (1.0 - l2_mult)
        
    # Variables
    pos = 0  # 0=Flat, 1=Long, -1=Short
    entry_price = 0.0
    
    gross_profit = 0.0
    gross_loss = 0.0
    trades = 0
    max_dd = 0.0
    peak_equity = 0.0
    current_equity = 0.0
    sum_pnl = 0.0
    sum_pnl_sq = 0.0
    n_closed = 0
    
    last_trade_day = -1
    active_days = 0
    total_days = 0
    last_day = -1
    
    # Warmup
    min_warmup = 800  # High period settings
    
    for i in range(min_warmup, n):
        current_day = times_arr[i] // 86400
        if current_day != last_day:
            total_days += 1
            last_day = current_day
            
        if not mask_arr[i]:
            if pos != 0:
                pnl = closes[i] - entry_price if pos == 1 else entry_price - closes[i]
                if pnl > 0: gross_profit += pnl
                else: gross_loss += abs(pnl)
                current_equity += pnl
                sum_pnl += pnl
                sum_pnl_sq += pnl * pnl
                n_closed += 1
                pos = 0
                if current_equity > peak_equity: peak_equity = current_equity
                dd = peak_equity - current_equity
                if dd > max_dd: max_dd = dd
            continue
            
        # AL Conditions
        al_c1 = (mov1[i] > ott1[i]) and (mov2[i] > L1[i]) and \
                (stoch_x[i] > sott1[i]) and (sum11[i] <= -3.0)
                
        al_c2 = (mov1[i] < ott1[i]) and (mov1[i] > ott4[i]) and \
                (mov3[i] > L2[i]) and (stoch_x[i] > sott1[i]) and \
                (sum22[i] <= -3.0)
                
        # SAT Conditions
        sat_c1 = (mov1[i] > ott1[i]) and (mov4[i] < ott7[i] * (1.0 + sat_mult1)) and \
                 (stoch_x[i] < sott2[i]) and (sum33[i] <= -3.0)
                 
        sat_c2 = (mov1[i] < ott1[i]) and (mov5[i] < ott9[i] * (1.0 + sat_mult2)) and \
                 (stoch_x[i] < sott1[i]) and (sum44[i] <= -6.0)
                 
        long_signal = al_c1 or al_c2
        short_signal = sat_c1 or sat_c2
        
        # Position Management
        if pos == 0:
            if long_signal:
                pos = 1
                entry_price = closes[i]
                trades += 1
                if current_day != last_trade_day:
                    active_days += 1; last_trade_day = current_day
            elif short_signal:
                pos = -1
                entry_price = closes[i]
                trades += 1
                if current_day != last_trade_day:
                    active_days += 1; last_trade_day = current_day
                    
        elif pos == 1: # LONG
            if short_signal:
                # Close long
                pnl = closes[i] - entry_price
                if pnl > 0: gross_profit += pnl
                else: gross_loss += abs(pnl)
                current_equity += pnl; sum_pnl += pnl; sum_pnl_sq += pnl*pnl; n_closed += 1
                
                # Reverse short
                pos = -1
                entry_price = closes[i]
                trades += 1
                if current_day != last_trade_day:
                    active_days += 1; last_trade_day = current_day
                    
        elif pos == -1: # SHORT
            if long_signal:
                pnl = entry_price - closes[i]
                if pnl > 0: gross_profit += pnl
                else: gross_loss += abs(pnl)
                current_equity += pnl; sum_pnl += pnl; sum_pnl_sq += pnl*pnl; n_closed += 1
                
                pos = 1
                entry_price = closes[i]
                trades += 1
                if current_day != last_trade_day:
                    active_days += 1; last_trade_day = current_day
                    
        if current_equity > peak_equity: peak_equity = current_equity
        dd = peak_equity - current_equity
        if dd > max_dd: max_dd = dd

    net_profit = gross_profit - gross_loss
    pf = (gross_profit / gross_loss) if gross_loss > 0 else 999.0
    sharpe = 0.0
    if n_closed > 1:
        mean_pnl = sum_pnl / n_closed
        var_pnl = (sum_pnl_sq / n_closed) - (mean_pnl * mean_pnl)
        if var_pnl > 0:
            sharpe = (mean_pnl / (var_pnl ** 0.5)) * np.sqrt(252*78) # Approx annualized
            
    return net_profit, trades, pf, max_dd, sharpe, active_days, total_days


# =========================================================================
# SOLVER IMPLEMENTATION
# =========================================================================

def evaluate_tott_params(args):
    """
    Bölünmüş Optimizasyon Görevi.
    Test Grid'e göre argümanlar alınır.
    """
    mov1_p, ott1_perc, l1_mult, sott1_perc, hhv_p, ott_gate = args
    
    global g_cache, g_mask
    if g_cache is None: return []
    res = []
    
    try:
        # --- Dinamik İndikatörler (Grid Params) ---
        mov1_arr = g_cache.get_vma(mov1_p)
        ott1_arr = g_cache.get_tti("closes", g_cache.closes, mov1_p, ott1_perc) # Ana trend
        
        # Kapı Testi (HHV/LLV)
        hhv1_arr = g_cache.get_hhv(hhv_p)
        llv1_arr = g_cache.get_llv(hhv_p)
        ott3_arr = g_cache.get_tti("hhv1", hhv1_arr, 2, ott_gate)
        ott8_arr = g_cache.get_tti("llv1", llv1_arr, 2, ott_gate)
        
        # Bölge (SOTT)
        stoch_smooth = g_cache.get_stoch_ma(700, 1, 250)
        stoch_x = stoch_smooth + 1000.0
        sott1_arr = g_cache.get_tti("stoch_x", stoch_x, 1, sott1_perc) # 0.6 varsayılan
        sott2_arr = g_cache.get_tti("stoch_x", stoch_x, 1, 0.3) # Sabit varsayım
        
        # --- Sabit / Varsayılan İndikatörler ---
        mov2_arr = g_cache.get_vma(10)
        ott2_arr = g_cache.get_tti("mov2", mov2_arr, 2, 0.3)
        
        ott4_arr = g_cache.get_tti("closes", g_cache.closes, 20, 0.3)
        mov3_arr = g_cache.get_vma(15)
        ott5_arr = g_cache.get_tti("mov3", mov3_arr, 2, 0.6)
        
        hhv2_arr = g_cache.get_hhv(10) # HHV2 hep 10 muydu? Veya HHV_P ile mi orantılı? Sabit 10 diyelim şimdilik.
        ott6_arr = g_cache.get_tti("hhv2", hhv2_arr, 2, 0.6)
        
        mov4_arr = g_cache.get_vma(10)
        ott7_arr = g_cache.get_tti("mov4", mov4_arr, 2, 0.3)
        
        mov5_arr = g_cache.get_vma(20)
        ott9_arr = g_cache.get_tti("mov5", mov5_arr, 2, 0.6)
        
        # Mults
        sat1 = 0.0011
        sat2 = 0.0011
        l2_mult_val = 0.0012
        
        np_val, tr, pf, dd, sh, adays, tdays = fast_backtest_tott_hott(
            g_cache.closes, g_cache.highs, g_cache.lows, g_mask, g_cache.times_arr,
            mov1_arr, ott1_arr, mov2_arr, ott2_arr,
            stoch_smooth, sott1_arr, sott2_arr,
            ott3_arr, ott4_arr, mov3_arr, ott5_arr, ott6_arr,
            mov4_arr, ott7_arr, ott8_arr, mov5_arr, ott9_arr,
            l1_mult, l2_mult_val, sat1, sat2,
            9, 3, 3, 7 # Sum periods
        )
        
        if np_val > 0 and pf > 1.0:
            res.append({
                'MOV1_P': mov1_p, 'OTT1_PERC': ott1_perc, 'L1_MULT': l1_mult,
                'HHV_P': hhv_p, 'OTT_GATE': ott_gate, 'SOTT1_PERC': sott1_perc,
                'NP': np_val, 'PF': pf, 'DD': dd, 'Trades': tr, 'Sharpe': sh
            })
            
    except Exception as e:
        print(f"Error eval_tott: {e}")
        
    return res


def run_tott_hott_optimization():
    """Parametre optimizasyonunu çalıştır"""
    print("--- S6 (TOTT_HOTT) Optimization Starting ---")
    
    # Grid tanımları (Word dosyasından uyarlandı)
    grid_mov1 = [20, 30, 40, 50]         # 20 to 50 step 10
    grid_ott1_perc = [6.0, 7.0, 8.0, 9.0] # 6 to 9 step 0.5/1.0
    grid_l1_mult = [0.0005, 0.0008, 0.0011]# Region multipliers
    grid_sott_perc = [0.4, 0.6, 0.8]      # Modifiye 0.2 - 0.4
    grid_hhv_p = [15, 20, 25, 30]         # 10 to 34 step 6
    grid_ott_gate = [0.4, 0.5, 0.6]       # 0.4 to 0.6 step 0.1
    
    tasks = []
    for m in grid_mov1:
        for o1 in grid_ott1_perc:
            for l1 in grid_l1_mult:
                for so in grid_sott_perc:
                    for hp in grid_hhv_p:
                        for og in grid_ott_gate:
                            tasks.append((m, o1, l1, so, hp, og))
                            
    print(f"Total Configs in Grid: {len(tasks)}")
    
    start_time = time()
    final_results = []
    
    with Pool(processes=min(16, cpu_count()), initializer=worker_init) as pool:
        for i, res in enumerate(pool.imap_unordered(evaluate_tott_params, tasks)):
            if i % 100 == 0 and i > 0:
                print(f"Processed: {i} / {len(tasks)}")
            if res:
                final_results.extend(res)
                
    elapsed = time() - start_time
    print(f"Done in {elapsed:.1f}s. Results: {len(final_results)}")
    
    if final_results:
        df = pd.DataFrame(final_results)
        df['Score'] = df['NP'] * df['PF']
        best = df.nlargest(1, 'Score').iloc[0]
        print(f"\nBEST S6 Result:\n{best.to_string()}")
        os.makedirs(r"d:\Projects\IdealQuant\results", exist_ok=True)
        df.sort_values('Score', ascending=False).head(50).to_csv(r"d:\Projects\IdealQuant\results\strategy6_results.csv", index=False)
        print("Results saved to results/strategy6_results.csv")

if __name__ == "__main__":
    import multiprocessing
    multiprocessing.freeze_support()
    run_tott_hott_optimization()
