# -*- coding: utf-8 -*-
"""
Strategy 6 Optimizer (TOTT_HOTT)
Referans: TOTT_SOTT_ve_HOTT_LOTT formul1.docx

3-Fazlı Optimizasyon:
  Faz 1 - Trend Testi:  opt1 (20-50), opt2 (6-9), opt3 (2.8-4.0)
  Faz 2 - Bölge Testi: opt6 (0.2-0.4) — opt4/opt5 sabit 500/200
  Faz 3 - Kapı Testi:  gate_period (10-34), gate_pct (0.4-0.6)

Not: TTI yerine doğrudan OTT() formülü kullanılıyor.
"""

import sys
import os
import numpy as np
import pandas as pd
from time import time
from multiprocessing import Pool, cpu_count, current_process
from numba import jit

sys.path.insert(0, os.path.abspath(os.path.join(os.path.dirname(__file__), '..', '..')))

from src.indicators.core import MA, HHV, LLV
from src.indicators.trend import OTT
from src.indicators.oscillators import StochasticFast
from src.engine.data import OHLCV
from src.optimization.fitness import quick_fitness

g_cache = None
g_mask  = None


# =========================================================================
# INDICATOR CACHE
# =========================================================================

class S6Cache:
    """S6 (TOTT_HOTT) İndikatör Cache — OTT tabanlı"""

    def __init__(self, df):
        if 'close' in df.columns:
            self.closes = df['close'].values.astype(np.float64)
            self.highs  = df['high'].values.astype(np.float64)
            self.lows   = df['low'].values.astype(np.float64)
        elif 'Kapanis' in df.columns:
            self.closes = df['Kapanis'].values.astype(np.float64)
            self.highs  = df['Yuksek'].values.astype(np.float64)
            self.lows   = df['Dusuk'].values.astype(np.float64)
        else:
            raise ValueError("DataFrame must contain 'close' or 'Kapanis' columns")

        if 'datetime' in df.columns:
            self.times_arr = df['datetime'].astype('datetime64[s]').astype(np.int64).values
        elif 'date' in df.columns:
            self.times_arr = df['date'].astype('datetime64[s]').astype(np.int64).values
        else:
            self.times_arr = np.zeros(len(df), dtype=np.int64)

        self._vma   = {}   # period -> array
        self._ott   = {}   # (source_key, period, pct) -> ott_line
        self._stoch = {}   # (k, smooth) -> array
        self._hhv   = {}   # period -> array
        self._llv   = {}   # period -> array

    def vma(self, period):
        if period not in self._vma:
            self._vma[period] = np.array(
                MA(self.closes.tolist(), "variable", int(period)), dtype=np.float64)
        return self._vma[period]

    def ott(self, source_key, source_arr, period, pct):
        """OTT hesapla (Kıvanç formülü). source_arr: np.float64[]"""
        key = (source_key, int(period), round(float(pct), 4))
        if key not in self._ott:
            ott_line, _ = OTT(source_arr.tolist(), int(period), float(pct), "variable")
            self._ott[key] = np.array(ott_line, dtype=np.float64)
        return self._ott[key]

    def stoch_smooth(self, k_period, smooth_period):
        key = (k_period, smooth_period)
        if key not in self._stoch:
            raw = StochasticFast(
                self.highs.tolist(), self.lows.tolist(), self.closes.tolist(), int(k_period))
            vma_stoch = MA(raw, "variable", int(smooth_period))
            self._stoch[key] = np.array(vma_stoch, dtype=np.float64)
        return self._stoch[key]

    def hhv(self, period):
        if period not in self._hhv:
            self._hhv[period] = np.array(HHV(self.highs.tolist(), int(period)), dtype=np.float64)
        return self._hhv[period]

    def llv(self, period):
        if period not in self._llv:
            self._llv[period] = np.array(LLV(self.lows.tolist(), int(period)), dtype=np.float64)
        return self._llv[period]


# =========================================================================
# NUMBA BACKTEST
# =========================================================================

@jit(nopython=True)
def _fast_s6(
    closes, highs, lows, mask_arr, times_arr,
    mov, ott_7, ott_opt2,
    stosk_x, sott,
    hott, lott, hhv_full, llv_full,
    band_factor,
    warmup
):
    """
    Numba JIT backtest — S6 TOTT_HOTT (Referans formül)
    Returns: (net_profit, trades, pf, max_dd, sharpe, active_days, total_days)
    """
    n = len(closes)
    pos = 0
    entry = 0.0
    gp = 0.0; gl = 0.0
    trades = 0
    eq = 0.0; peak = 0.0; max_dd = 0.0
    sp = 0.0; sp2 = 0.0; nc = 0
    last_day = -1; total_days = 0
    last_td  = -1; active_days = 0

    for i in range(warmup, n):
        cd = times_arr[i] // 86400
        if cd != last_day:
            total_days += 1
            last_day = cd

        # Kapı maskesi
        if not mask_arr[i]:
            if pos != 0:
                pnl = (closes[i] - entry) if pos == 1 else (entry - closes[i])
                if pnl > 0: gp += pnl
                else: gl += abs(pnl)
                eq += pnl; sp += pnl; sp2 += pnl*pnl; nc += 1
                pos = 0
                if eq > peak: peak = eq
                dd = peak - eq
                if dd > max_dd: max_dd = dd
            continue

        # Sinyaller
        mov_i  = mov[i]
        ott7_i = ott_7[i]
        ott2_i = ott_opt2[i]
        sx_i   = stosk_x[i]
        so_i   = sott[i]
        H_i    = highs[i]
        L_i    = lows[i]

        hott_gate = (H_i > hott[i]) and (i > 0) and (H_i > hhv_full[i-1])
        lott_gate = (L_i < lott[i]) and (i > 0) and (L_i < llv_full[i-1])

        if mov_i > ott7_i:
            al  = (mov_i > ott2_i * band_factor) and (sx_i > so_i) and hott_gate
            sat = (mov_i < ott2_i / band_factor) and (sx_i < so_i) and lott_gate
        else:
            al  = (mov_i > ott2_i) and (sx_i > so_i) and hott_gate
            sat = (mov_i < ott2_i) and (sx_i < so_i) and lott_gate

        if pos == 0:
            if al:
                pos = 1; entry = closes[i]; trades += 1
                if cd != last_td: active_days += 1; last_td = cd
            elif sat:
                pos = -1; entry = closes[i]; trades += 1
                if cd != last_td: active_days += 1; last_td = cd

        elif pos == 1 and sat:
            pnl = closes[i] - entry
            if pnl > 0: gp += pnl
            else: gl += abs(pnl)
            eq += pnl; sp += pnl; sp2 += pnl*pnl; nc += 1
            pos = -1; entry = closes[i]; trades += 1
            if cd != last_td: active_days += 1; last_td = cd

        elif pos == -1 and al:
            pnl = entry - closes[i]
            if pnl > 0: gp += pnl
            else: gl += abs(pnl)
            eq += pnl; sp += pnl; sp2 += pnl*pnl; nc += 1
            pos = 1; entry = closes[i]; trades += 1
            if cd != last_td: active_days += 1; last_td = cd

        if eq > peak: peak = eq
        dd = peak - eq
        if dd > max_dd: max_dd = dd

    net = gp - gl
    pf  = (gp / gl) if gl > 0 else 999.0
    sharpe = 0.0
    if nc > 1:
        mean = sp / nc
        var  = (sp2 / nc) - mean*mean
        if var > 0:
            sharpe = (mean / var**0.5) * np.sqrt(252*78)

    return net, trades, pf, max_dd, sharpe, active_days, total_days


# =========================================================================
# DATA LOADING
# =========================================================================

def _load_data(vade_tipi="ENDEKS"):
    # Hardcoded path kaldırıldı. GUI üzerinden veri aktarımı esastır.
    # Standalone test için gerekirse buraya geçerli bir yol yazılabilir.
    csv_path = r"data\BAR_DATA.csv" 
    if not os.path.exists(csv_path):
        return None, None
        
    try:
        data = OHLCV.from_ideal_export(csv_path)
        if current_process().name == 'MainProcess':
            print(f"Veri Yuklendi: {len(data)} Bar")
        return data.df, data.get_trading_mask(vade_tipi)
    except Exception as e:
        print(f"Data load hatasi: {e}")
        return None, None


def worker_init(vade_tipi="ENDEKS"):
    global g_cache, g_mask
    df, mask = _load_data(vade_tipi)
    if df is not None:
        g_cache = S6Cache(df)
        g_mask  = mask


# =========================================================================
# EVALUATION FUNC
# =========================================================================

def evaluate_s6(args):
    """Tek konfigürasyon değerlendirme — multiprocessing worker"""
    opt1, opt2, opt3, opt6, gate_period, gate_pct = args
    # opt4/opt5 sabit (bölge testi için değiştirilir)
    opt4, opt5 = 500, 200

    global g_cache, g_mask
    if g_cache is None:
        return None

    try:
        # Trend indikatörleri
        mov_arr   = g_cache.vma(opt1)
        ott7_arr  = g_cache.ott("C", g_cache.closes, opt1, 7.0)
        ott2_arr  = g_cache.ott("C_opt2", g_cache.closes, opt1, opt2)

        # Bölge indikatörleri
        stoch_arr = g_cache.stoch_smooth(opt4, opt5)
        stosk_x   = stoch_arr + 1000.0
        sott_arr  = g_cache.ott("stoch_x", stosk_x, 2, opt6)

        # Kapı indikatörleri
        half = max(1, gate_period // 2)
        hhv_full = g_cache.hhv(gate_period)
        llv_full = g_cache.llv(gate_period)
        hott_arr = g_cache.ott(f"hhv{half}", g_cache.hhv(half), 2, gate_pct)
        lott_arr = g_cache.ott(f"llv{half}", g_cache.llv(half), 2, gate_pct)

        band_factor = 1.0 + (opt3 / 1000.0)
        warmup = opt4 + opt5 + 50

        np_val, tr, pf, dd, sh, adays, tdays = _fast_s6(
            g_cache.closes, g_cache.highs, g_cache.lows,
            g_mask, g_cache.times_arr,
            mov_arr, ott7_arr, ott2_arr,
            stosk_x, sott_arr,
            hott_arr, lott_arr, hhv_full, llv_full,
            band_factor, warmup
        )

        if np_val > 0 and tr >= 10 and pf > 1.1:
            r2 = 0.5  # placeholder
            fitness = quick_fitness(np_val, pf, sh, tr, dd, tdays, adays, r2, 0.0)
            return {
                'opt1': opt1, 'opt2': opt2, 'opt3': opt3,
                'opt6': opt6, 'gate_period': gate_period, 'gate_pct': gate_pct,
                'NP': np_val, 'PF': round(pf, 3), 'DD': round(dd, 1),
                'Trades': tr, 'Sharpe': round(sh, 3), 'Fitness': round(fitness, 4)
            }
    except Exception as e:
        print(f"Eval hatasi: {e}")
    return None


# =========================================================================
# OPTIMIZATION RUNNER
# =========================================================================

def run_s6_optimization(faz=1):
    """
    Faz 1: Trend testi (opt1, opt2, opt3)
    Faz 2: Bölge testi (opt6) — trend sabit
    Faz 3: Kapı testi  (gate_period, gate_pct) — trend+bölge sabit
    """
    print(f"--- S6 (TOTT_HOTT) Faz {faz} Optimizasyonu ---")

    if faz == 1:
        # Trend grid
        tasks = []
        for opt1 in [20, 30, 40, 50]:
            for opt2 in [6.0, 6.5, 7.0, 7.5, 8.0, 8.5, 9.0]:
                for opt3 in [2800, 3000, 3200, 3500, 3800, 4000]:  # /1000 = band factor
                    for opt6 in [0.3]:          # bölge sabit
                        for gp in [20]:         # kapı sabit
                            for gpc in [0.5]:   # kapı sabit
                                tasks.append((opt1, opt2, opt3, opt6, gp, gpc))

    elif faz == 2:
        # En iyi opt1/opt2/opt3'ü bul (önceki sonuçtan oku)
        try:
            prev = pd.read_csv(r"D:\Projects\IdealQuant\results\s6_faz1.csv").iloc[0]
            best_opt1 = int(prev['opt1'])
            best_opt2 = float(prev['opt2'])
            best_opt3 = float(prev['opt3'])
        except Exception:
            best_opt1, best_opt2, best_opt3 = 30, 7.0, 3000
            print("[UYARI] Faz 1 sonucu bulunamadi, varsayilan kullaniliyor.")

        tasks = []
        for opt6 in [0.2, 0.3, 0.4]:
            for gp in [20]:
                for gpc in [0.5]:
                    tasks.append((best_opt1, best_opt2, best_opt3, opt6, gp, gpc))

    elif faz == 3:
        # Kapı testi — trend+bölge sabit
        try:
            prev = pd.read_csv(r"D:\Projects\IdealQuant\results\s6_faz2.csv").iloc[0]
            best_opt1 = int(prev['opt1'])
            best_opt2 = float(prev['opt2'])
            best_opt3 = float(prev['opt3'])
            best_opt6 = float(prev['opt6'])
        except Exception:
            best_opt1, best_opt2, best_opt3, best_opt6 = 30, 7.0, 3000, 0.3
            print("[UYARI] Faz 2 sonucu bulunamadi, varsayilan kullaniliyor.")

        tasks = []
        for gp in [10, 16, 20, 24, 28, 34]:
            for gpc in [0.4, 0.5, 0.6]:
                tasks.append((best_opt1, best_opt2, best_opt3, best_opt6, gp, gpc))
    else:
        raise ValueError(f"Gecersiz faz: {faz}")

    print(f"Grid boyutu: {len(tasks)} konfigurasyon")

    start = time()
    results = []
    with Pool(processes=min(12, cpu_count()), initializer=worker_init) as pool:
        for i, r in enumerate(pool.imap_unordered(evaluate_s6, tasks)):
            if i % 50 == 0 and i > 0:
                print(f"  [{i}/{len(tasks)}] Sonuc sayisi: {len(results)}")
            if r is not None:
                results.append(r)

    elapsed = time() - start
    print(f"Tamamlandi: {elapsed:.1f}s | Sonuc: {len(results)}")

    if results:
        df = pd.DataFrame(results)
        df = df.sort_values('Fitness', ascending=False)
        os.makedirs(r"D:\Projects\IdealQuant\results", exist_ok=True)
        out = rf"D:\Projects\IdealQuant\results\s6_faz{faz}.csv"
        df.head(50).to_csv(out, index=False)
        print(f"\nEn iyi sonuc:\n{df.iloc[0].to_string()}")
        print(f"Sonuclar kaydedildi: {out}")
    else:
        print("Hicbir gecerli sonuc bulunamadi!")


if __name__ == "__main__":
    import multiprocessing
    multiprocessing.freeze_support()

    import argparse
    parser = argparse.ArgumentParser()
    parser.add_argument('--faz', type=int, default=1, help='Optimizasyon fazi (1-3)')
    args = parser.parse_args()
    run_s6_optimization(faz=args.faz)
