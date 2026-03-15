"""
Strateji 7 (DeepScalp) Numba-JIT Support
"""
import numpy as np
from numba import jit

@jit(nopython=True, cache=True)
def fast_backtest_strategy7(
    closes: np.ndarray,
    highs: np.ndarray,
    lows: np.ndarray,
    volumes: np.ndarray,
    ars_ema: np.ndarray,
    st_val: np.ndarray,
    ema_fast: np.ndarray,
    ema_slow: np.ndarray,
    toma_val: np.ndarray,
    mfi_arr: np.ndarray,
    atr_arr: np.ndarray,
    mask_arr: np.ndarray,
    times_arr: np.ndarray,
    # Params
    ars_k: float,
    hhv_period: int,
    llv_period: int,
    mfi_hhv_period: int,
    mfi_llv_period: int,
    mfi_long: float,
    mfi_short: float,
    vol_ratio: float,
    atr_stop_mult_long: float,
    atr_stop_mult_short: float,
    kar_al_yuzde_long: float,
    kar_al_yuzde_short: float,
    min_hold_bars: int,
    max_hold_bars: int,
    cooldown_bars: int,
    vade_tipi: int  # 0: SPOT, 1: VIOP_ENDEKS, 2: VIOP_SPOT
):
    """
    Numba-optimized core logic for DeepScalp.
    Returns: (net_profit, total_trades, profit_factor, max_dd, sharpe_ratio, oos_active_days, total_days)
    """
    n = len(closes)
    
    in_long = False
    in_short = False
    entry_price = 0.0
    extreme_val = 0.0
    stop_level = 0.0
    bars_in_pos = 0
    cooldown_ct = 0
    
    total_profit = 0.0
    total_loss = 0.0
    winning_trades = 0
    losing_trades = 0
    
    peak_equity = 0.0
    max_dd = 0.0
    current_equity = 0.0
    
    trade_profits = []
    
    active_days = 0
    last_day = -1
    
    is_spot = (vade_tipi == 0)
    
    for i in range(1, n):
        # Filter check (holiday / expiry)
        if not mask_arr[i]:
            if (in_long or in_short) and current_equity != 0:
                # Force close
                exit_price = closes[i]
                trade_pnl = 0.0
                if in_long:
                    trade_pnl = exit_price - entry_price
                else:
                    trade_pnl = entry_price - exit_price
                    
                trade_profits.append(trade_pnl)
                current_equity += trade_pnl
                
                if trade_pnl > 0:
                    total_profit += trade_pnl
                    winning_trades += 1
                else:
                    total_loss += abs(trade_pnl)
                    losing_trades += 1
                    
                in_long = False
                in_short = False
                entry_price = 0.0
                extreme_val = 0.0
                stop_level = 0.0
                bars_in_pos = 0
                cooldown_ct = 0
                
            continue
            
        # Count days for OOS stats
        current_day = times_arr[i] // 86400
        if current_day != last_day:
            last_day = current_day
            active_days += 1
            
        if cooldown_ct > 0:
            cooldown_ct -= 1
            
        ars_ema_val = ars_ema[i]
        ars_band = round(ars_ema_val * ars_k, 2)
        
        rejim_long = (closes[i] > ars_ema_val) and (closes[i] < ars_ema_val + ars_band)
        rejim_short = (closes[i] < ars_ema_val) and (closes[i] > ars_ema_val - ars_band)
        
        st_long = (st_val[i] < closes[i])
        st_short = (st_val[i] > closes[i])
        ema_long = (ema_fast[i] > ema_slow[i])
        ema_short = (ema_fast[i] < ema_slow[i])
        
        trend_long = st_long and ema_long
        trend_short = st_short and ema_short
        
        toma_kros_up = (toma_val[i] > 0) and (toma_val[i - 1] <= 0)
        toma_kros_down = (toma_val[i] < 0) and (toma_val[i - 1] >= 0)
        
        prev_hhv = 0.0
        for k in range(1, hhv_period + 1):
            if i - k >= 0 and highs[i - k] > prev_hhv:
                prev_hhv = highs[i - k]
        hhv_break = (closes[i] > prev_hhv)
        
        prev_llv = 9999999.0
        for k in range(1, llv_period + 1):
            if i - k >= 0 and lows[i - k] < prev_llv:
                prev_llv = lows[i - k]
        llv_break = (closes[i] < prev_llv)
        
        tetik_long = toma_kros_up or hhv_break
        tetik_short = toma_kros_down or llv_break
        
        prev_mfi_max = 0.0
        for k in range(1, mfi_hhv_period + 1):
            if i - k >= 0 and mfi_arr[i - k] > prev_mfi_max:
                prev_mfi_max = mfi_arr[i - k]
        mfi_long_ok = (mfi_arr[i] > mfi_long) and (mfi_arr[i] > prev_mfi_max)
        
        prev_mfi_min = 9999999.0
        for k in range(1, mfi_llv_period + 1):
            if i - k >= 0 and mfi_arr[i - k] < prev_mfi_min:
                prev_mfi_min = mfi_arr[i - k]
        mfi_short_ok = (mfi_arr[i] < mfi_short) and (mfi_arr[i] < prev_mfi_min)
        
        vol_avg = 0.0
        v_count = 0
        for k in range(1, 21):
            if i - k >= 0:
                vol_avg += volumes[i - k]
                v_count += 1
        if v_count > 0:
            vol_avg /= float(v_count)
            
        vol_ok = (volumes[i] >= vol_avg * vol_ratio)
        
        onay_long = mfi_long_ok and vol_ok
        onay_short = mfi_short_ok and vol_ok
        cooldown_ok = (cooldown_ct == 0)
        
        giris_long = (not in_long) and (not in_short) and rejim_long and trend_long and tetik_long and onay_long and cooldown_ok
        giris_short = (not in_long) and (not in_short) and rejim_short and trend_short and tetik_short and onay_short and cooldown_ok
        
        if giris_long:
            in_long = True
            entry_price = closes[i]
            extreme_val = entry_price
            stop_level = entry_price - atr_arr[i] * atr_stop_mult_long
            bars_in_pos = 0
        elif giris_short and not is_spot:
            in_short = True
            entry_price = closes[i]
            extreme_val = entry_price
            stop_level = entry_price + atr_arr[i] * atr_stop_mult_short
            bars_in_pos = 0
            
        if in_long:
            bars_in_pos += 1
            if closes[i] > extreme_val:
                extreme_val = closes[i]
                stop_level = extreme_val - atr_arr[i] * atr_stop_mult_long
            
            kar_al_fiyat = entry_price * (1.0 + kar_al_yuzde_long / 100.0)
            
            stop_hit = (closes[i] <= stop_level)
            kar_al_hit = (closes[i] >= kar_al_fiyat)
            rejim_kirildi = not rejim_long
            trend_kirildi = not trend_long
            min_hold_ok = (bars_in_pos >= min_hold_bars)
            max_hold_hit = (bars_in_pos >= max_hold_bars)
            
            if stop_hit or kar_al_hit or rejim_kirildi or (trend_kirildi and min_hold_ok) or max_hold_hit:
                trade_pnl = closes[i] - entry_price
                trade_profits.append(trade_pnl)
                current_equity += trade_pnl
                
                if trade_pnl > 0:
                    total_profit += trade_pnl
                    winning_trades += 1
                else:
                    total_loss += abs(trade_pnl)
                    losing_trades += 1
                    
                in_long = False
                bars_in_pos = 0
                cooldown_ct = cooldown_bars
                
        elif in_short:
            bars_in_pos += 1
            if closes[i] < extreme_val:
                extreme_val = closes[i]
                stop_level = extreme_val + atr_arr[i] * atr_stop_mult_short
            
            kar_al_fiyat = entry_price * (1.0 - kar_al_yuzde_short / 100.0)
            
            stop_hit = (closes[i] >= stop_level)
            kar_al_hit = (closes[i] <= kar_al_fiyat)
            rejim_kirildi = not rejim_short
            trend_kirildi = not trend_short
            min_hold_ok = (bars_in_pos >= min_hold_bars)
            max_hold_hit = (bars_in_pos >= max_hold_bars)
            
            if stop_hit or kar_al_hit or rejim_kirildi or (trend_kirildi and min_hold_ok) or max_hold_hit:
                trade_pnl = entry_price - closes[i]
                trade_profits.append(trade_pnl)
                current_equity += trade_pnl
                
                if trade_pnl > 0:
                    total_profit += trade_pnl
                    winning_trades += 1
                else:
                    total_loss += abs(trade_pnl)
                    losing_trades += 1
                    
                in_short = False
                bars_in_pos = 0
                cooldown_ct = cooldown_bars
                
        # Drawdown tracking
        if current_equity > peak_equity:
            peak_equity = current_equity
        else:
            dd = peak_equity - current_equity
            if dd > max_dd:
                max_dd = dd
                
    total_trades = winning_trades + losing_trades
    net_profit = total_profit - total_loss
    profit_factor = total_profit / total_loss if total_loss > 0 else 99.0
    
    # Sharpe ratio calculation
    sharpe_ratio = 0.0
    if total_trades > 2:
        t_arr = np.array(trade_profits)
        std_dev = np.std(t_arr)
        if std_dev > 0:
            sharpe_ratio = np.mean(t_arr) / std_dev * np.sqrt(total_trades)
            
    total_days = active_days if active_days > 0 else 1
            
    return net_profit, total_trades, profit_factor, max_dd, sharpe_ratio, active_days, total_days


class DeepScalpCache:
    """Pre-computes indicators for fast backtesting"""
    
    def __init__(self, df):
        self.closes = df['close'].values
        self.highs = df['high'].values
        self.lows = df['low'].values
        self.volumes = df['volume'].values
        
        if 'datetime' in df.columns:
             self.times_arr = df['datetime'].values.astype('datetime64[s]').astype(np.int64)
        elif 'date' in df.columns:
             self.times_arr = df['date'].values.astype('datetime64[s]').astype(np.int64)
        else:
             self.times_arr = np.arange(len(df), dtype=np.int64) * 86400

        self.n = len(df)
        self.ema_cache = {}
        self.toma_cache = {}
        self.mfi_cache = {}
        self.atr_cache = {}
        self.st_cache = {}

    def get_ema(self, period):
        if period not in self.ema_cache:
            from src.indicators.core import get_ema
            self.ema_cache[period] = get_ema(self.closes, period)
        return self.ema_cache[period]
        
    def get_mfi(self, period):
        if period not in self.mfi_cache:
            from src.indicators.core import get_mfi
            self.mfi_cache[period] = get_mfi(self.highs, self.lows, self.closes, self.volumes, period)
        return self.mfi_cache[period]

    def get_atr(self, period):
        if period not in self.atr_cache:
            from src.indicators.core import get_atr
            self.atr_cache[period] = get_atr(self.highs, self.lows, self.closes, period)
        return self.atr_cache[period]

    def get_toma(self, p1, p2):
        key = (p1, p2)
        if key not in self.toma_cache:
            from src.indicators.trend import get_toma
            _, toma_val = get_toma(self.closes, p1, p2)
            self.toma_cache[key] = toma_val
        return self.toma_cache[key]
        
    def get_st(self, factor, hhv_p, atr_p):
        key = (factor, hhv_p, atr_p)
        if key not in self.st_cache:
            from src.indicators.trend import get_supertrend
            st_val, _, _ = get_supertrend(self.highs, self.lows, self.closes, hhv_p, atr_p, factor)
            self.st_cache[key] = st_val
        return self.st_cache[key]
