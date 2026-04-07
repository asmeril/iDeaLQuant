import numpy as np
import pandas as pd
from typing import Dict, List, Tuple
from enum import Enum, auto

from numba import jit

from src.indicators.core import get_ema, get_mfi, get_atr
from src.indicators.trend import get_supertrend, get_toma
from src.indicators.math import get_highest_high, get_lowest_low, safe_round_ideal
from src.strategies.base_strategy import BaseStrategy
from src.engine.types import StrategyConfig
from src.engine.events import SignalType


class DeepScalpStrategyConfig(StrategyConfig):
    """Configuration for DeepScalpStrategy."""
    
    def __init__(self, **kwargs):
        super().__init__(**kwargs)
        # Layer 1: ARS Regime
        self.ars_k = kwargs.get('ars_k', 1.23)
        self.ars_ema_period = kwargs.get('ars_ema_period', 3)
        
        # Layer 2: SuperTrend + EMA
        self.st_factor = kwargs.get('st_factor', 3.0)
        self.st_hhv_period = kwargs.get('st_hhv_period', 10)
        self.st_atr_period = kwargs.get('st_atr_period', 14)
        self.ema_fast_period = kwargs.get('ema_fast_period', 9)
        self.ema_slow_period = kwargs.get('ema_slow_period', 21)
        
        # Layer 3: TOMA + HHV/LLV Tetik
        self.toma_period1 = kwargs.get('toma_period1', 1)
        self.toma_period2 = kwargs.get('toma_period2', 2.1)
        self.hhv_period = kwargs.get('hhv_period', 12)
        self.llv_period = kwargs.get('llv_period', 12)
        
        # Layer 4: MFI + Volume
        self.mfi_period = kwargs.get('mfi_period', 14)
        self.mfi_hhv_period = kwargs.get('mfi_hhv_period', 5)
        self.mfi_llv_period = kwargs.get('mfi_llv_period', 5)
        self.mfi_long = kwargs.get('mfi_long', 55.0)
        self.mfi_short = kwargs.get('mfi_short', 45.0)
        self.vol_ratio = kwargs.get('vol_ratio', 0.80)
        
        # Layer 5: ATR Stops & Profit Takes
        self.atr_period = kwargs.get('atr_period', 14)
        self.atr_stop_mult_long = kwargs.get('atr_stop_mult_long', 1.5)
        self.atr_stop_mult_short = kwargs.get('atr_stop_mult_short', 1.5)
        self.kar_al_yuzde_long = kwargs.get('kar_al_yuzde_long', 2.0)
        self.kar_al_yuzde_short = kwargs.get('kar_al_yuzde_short', 2.0)
        
        # Layer 6: Time Filters
        self.min_hold_bars = kwargs.get('min_hold_bars', 2)
        self.max_hold_bars = kwargs.get('max_hold_bars', 20)
        self.cooldown_bars = kwargs.get('cooldown_bars', 2)
        
        # Vade Type (Default to VIOP_ENDEKS for dual directional trading)
        self.vade_type = kwargs.get('vade_type', 'VIOP_ENDEKS')


class DeepScalpStrategy(BaseStrategy):
    """
    DeepScalp v1.2 Strategy.
    6-Layer logic combining ARS Regime, SuperTrend, TOMA, MFI and Trailing ATR stop.
    Includes time hold filters and cooldowns.
    """
    
    def __init__(self, config: DeepScalpStrategyConfig):
        super().__init__(config)
        self.config = config
    
    @classmethod
    def from_config_dict(cls, cache, params: dict):
        """Create strategy from a cache object and parameter dict (OOS validation compat)."""
        config = DeepScalpStrategyConfig(**params)
        instance = cls(config)
        instance._cache = cache
        return instance
    
    def generate_all_signals(self):
        """
        Generate entry signals and exit arrays for backtest compatibility.
        Returns: (signals, exits_long, exits_short) — numpy int8 arrays.
        Uses the same logic as the Numba kernel for consistency.
        """
        cache = self._cache
        closes = np.asarray(cache.closes, dtype=np.float64)
        highs = np.asarray(cache.highs, dtype=np.float64)
        lows = np.asarray(cache.lows, dtype=np.float64)
        volumes = np.asarray(cache.volumes, dtype=np.float64)
        n = len(closes)
        
        # Indicators
        ars_ema = get_ema(closes, self.config.ars_ema_period)
        st_result = get_supertrend(highs, lows, closes, self.config.st_hhv_period, self.config.st_atr_period, self.config.st_factor)
        st_val = np.array(st_result[0], dtype=np.float64)
        ema_fast = get_ema(closes, self.config.ema_fast_period)
        ema_slow = get_ema(closes, self.config.ema_slow_period)
        _, toma_trend = get_toma(closes, self.config.toma_period1, self.config.toma_period2)
        toma_trend = np.array(toma_trend, dtype=np.float64)
        mfi = get_mfi(highs, lows, closes, volumes, self.config.mfi_period)
        atr = get_atr(highs, lows, closes, self.config.atr_period)
        
        is_spot = (self.config.vade_type == 'SPOT')
        
        signals = np.zeros(n, dtype=np.int8)
        exits_long = np.zeros(n, dtype=np.int8)
        exits_short = np.zeros(n, dtype=np.int8)
        
        in_long = False
        in_short = False
        entry_price = 0.0
        extreme_val = 0.0
        stop_level = 0.0
        bars_in_pos = 0
        cooldown_ct = 0
        
        for i in range(1, n):
            if cooldown_ct > 0:
                cooldown_ct -= 1
            
            ars_ema_val = ars_ema[i]
            ars_band = safe_round_ideal(ars_ema_val * self.config.ars_k, 0.01)
            
            rejim_long = (closes[i] > ars_ema_val) and (closes[i] < ars_ema_val + ars_band)
            rejim_short = (closes[i] < ars_ema_val) and (closes[i] > ars_ema_val - ars_band)
            
            st_long = (st_val[i] < closes[i])
            st_short = (st_val[i] > closes[i])
            ema_long = (ema_fast[i] > ema_slow[i])
            ema_short = (ema_fast[i] < ema_slow[i])
            trend_long = st_long and ema_long
            trend_short = st_short and ema_short
            
            toma_kros_up = (toma_trend[i] > 0) and (toma_trend[i - 1] <= 0)
            toma_kros_down = (toma_trend[i] < 0) and (toma_trend[i - 1] >= 0)
            
            prev_hhv = 0.0
            for k in range(1, self.config.hhv_period + 1):
                if i - k >= 0 and highs[i - k] > prev_hhv:
                    prev_hhv = highs[i - k]
            hhv_break = (closes[i] > prev_hhv)
            
            prev_llv = float('inf')
            for k in range(1, self.config.llv_period + 1):
                if i - k >= 0 and lows[i - k] < prev_llv:
                    prev_llv = lows[i - k]
            llv_break = (closes[i] < prev_llv)
            
            tetik_long = toma_kros_up or hhv_break
            tetik_short = toma_kros_down or llv_break
            
            prev_mfi_max = 0.0
            for k in range(1, self.config.mfi_hhv_period + 1):
                if i - k >= 0 and mfi[i - k] > prev_mfi_max:
                    prev_mfi_max = mfi[i - k]
            mfi_long_ok = (mfi[i] > self.config.mfi_long) and (mfi[i] > prev_mfi_max)
            
            prev_mfi_min = float('inf')
            for k in range(1, self.config.mfi_llv_period + 1):
                if i - k >= 0 and mfi[i - k] < prev_mfi_min:
                    prev_mfi_min = mfi[i - k]
            mfi_short_ok = (mfi[i] < self.config.mfi_short) and (mfi[i] < prev_mfi_min)
            
            vol_avg = 0.0
            count = 0
            for k in range(1, 21):
                if i - k >= 0:
                    vol_avg += volumes[i - k]
                    count += 1
            if count > 0:
                vol_avg /= count
            vol_ok = (volumes[i] >= vol_avg * self.config.vol_ratio)
            
            onay_long = mfi_long_ok and vol_ok
            onay_short = mfi_short_ok and vol_ok
            cooldown_ok = (cooldown_ct == 0)
            
            # Entry
            giris_long = (not in_long) and (not in_short) and rejim_long and trend_long and tetik_long and onay_long and cooldown_ok
            giris_short = (not in_long) and (not in_short) and rejim_short and trend_short and tetik_short and onay_short and cooldown_ok
            
            if giris_long:
                signals[i] = 1
                in_long = True
                entry_price = closes[i]
                extreme_val = closes[i]
                stop_level = entry_price - atr[i] * self.config.atr_stop_mult_long
                bars_in_pos = 0
            elif giris_short and not is_spot:
                signals[i] = -1
                in_short = True
                entry_price = closes[i]
                extreme_val = closes[i]
                stop_level = entry_price + atr[i] * self.config.atr_stop_mult_short
                bars_in_pos = 0
            
            # Long management
            if in_long:
                bars_in_pos += 1
                if closes[i] > extreme_val:
                    extreme_val = closes[i]
                    stop_level = extreme_val - atr[i] * self.config.atr_stop_mult_long
                
                kar_al_fiyat = entry_price * (1.0 + self.config.kar_al_yuzde_long / 100.0)
                stop_hit = (closes[i] <= stop_level)
                kar_al_hit = (closes[i] >= kar_al_fiyat)
                rejim_kirildi = not rejim_long
                trend_kirildi = not trend_long
                min_hold_ok = (bars_in_pos >= self.config.min_hold_bars)
                max_hold_hit = (bars_in_pos >= self.config.max_hold_bars)
                
                if stop_hit or kar_al_hit or rejim_kirildi or (trend_kirildi and min_hold_ok) or max_hold_hit:
                    exits_long[i] = 1
                    in_long = False
                    cooldown_ct = self.config.cooldown_bars
                    bars_in_pos = 0
                    entry_price = 0.0
                    extreme_val = 0.0
                    stop_level = 0.0
            
            # Short management
            if in_short:
                bars_in_pos += 1
                if closes[i] < extreme_val:
                    extreme_val = closes[i]
                    stop_level = extreme_val + atr[i] * self.config.atr_stop_mult_short
                
                kar_al_fiyat = entry_price * (1.0 - self.config.kar_al_yuzde_short / 100.0)
                stop_hit = (closes[i] >= stop_level)
                kar_al_hit = (closes[i] <= kar_al_fiyat)
                rejim_kirildi = not rejim_short
                trend_kirildi = not trend_short
                min_hold_ok = (bars_in_pos >= self.config.min_hold_bars)
                max_hold_hit = (bars_in_pos >= self.config.max_hold_bars)
                
                if stop_hit or kar_al_hit or rejim_kirildi or (trend_kirildi and min_hold_ok) or max_hold_hit:
                    exits_short[i] = 1
                    in_short = False
                    cooldown_ct = self.config.cooldown_bars
                    bars_in_pos = 0
                    entry_price = 0.0
                    extreme_val = 0.0
                    stop_level = 0.0
        
        return signals, exits_long.astype(bool), exits_short.astype(bool)
        
    def generate_signals(self, df: pd.DataFrame) -> pd.DataFrame:
        """
        Generate signals for the current dataframe.
        If cache logic is needed, handled in engine.
        For standalone Python run, this evaluates row by row like C#.
        """
        df = df.copy()
        
        # Indicators
        highs = df['high'].values
        lows = df['low'].values
        closes = df['close'].values
        volumes = df['volume'].values
        
        # Layer 1
        ars_ema = get_ema(closes, self.config.ars_ema_period)
        
        # Layer 2
        st_val, st_up, st_down = get_supertrend(highs, lows, closes, self.config.st_hhv_period, self.config.st_atr_period, self.config.st_factor)
        ema_fast = get_ema(closes, self.config.ema_fast_period)
        ema_slow = get_ema(closes, self.config.ema_slow_period)
        
        # Layer 3
        toma_trend, toma_val = get_toma(closes, self.config.toma_period1, self.config.toma_period2)
        
        # Layer 4
        mfi = get_mfi(highs, lows, closes, volumes, self.config.mfi_period)
        
        # Layer 5
        atr = get_atr(highs, lows, closes, self.config.atr_period)
        
        # State variables
        in_long = False
        in_short = False
        entry_price = 0.0
        extreme_val = 0.0
        stop_level = 0.0
        bars_in_pos = 0
        cooldown_ct = 0
        
        signals = []
        is_spot = (self.config.vade_type == 'SPOT')
        
        # Numba-friendly arrays for the loop
        n = len(closes)
        signal_arr = np.zeros(n, dtype=np.int8)  # 0: flat, 1: long, -1: short
        
        # Use python loop since it's just a reference implementation. 
        # (Numba optimizer will use a fast compiled version).
        
        for i in range(1, n):
            if cooldown_ct > 0:
                cooldown_ct -= 1
                
            # Layer 1: ARS Regime
            ars_ema_val = ars_ema[i]
            # Match rounded arithmetic of C# to avoid subtle differences
            # iDeal: Sistem.SayiYuvarla(arsEmaVal * arsK, 0.01f)
            ars_band = safe_round_ideal(ars_ema_val * self.config.ars_k, 0.01)
            
            rejim_long = (closes[i] > ars_ema_val) and (closes[i] < ars_ema_val + ars_band)
            rejim_short = (closes[i] < ars_ema_val) and (closes[i] > ars_ema_val - ars_band)
            
            # Layer 2: SuperTrend + EMA
            st_long = (st_val[i] < closes[i])
            st_short = (st_val[i] > closes[i])
            ema_long = (ema_fast[i] > ema_slow[i])
            ema_short = (ema_fast[i] < ema_slow[i])
            
            trend_long = st_long and ema_long
            trend_short = st_short and ema_short
            
            # Layer 3: TOMA + HHV/LLV
            toma_kros_up = (toma_val[i] > 0) and (toma_val[i - 1] <= 0)
            toma_kros_down = (toma_val[i] < 0) and (toma_val[i - 1] >= 0)
            
            # HHV/LLV Breakout
            prev_hhv = 0.0
            for k in range(1, self.config.hhv_period + 1):
                if i - k >= 0 and highs[i - k] > prev_hhv:
                    prev_hhv = highs[i - k]
            hhv_break = (closes[i] > prev_hhv)
            
            prev_llv = float('inf')
            for k in range(1, self.config.llv_period + 1):
                if i - k >= 0 and lows[i - k] < prev_llv:
                    prev_llv = lows[i - k]
            llv_break = (closes[i] < prev_llv)
            
            tetik_long = toma_kros_up or hhv_break
            tetik_short = toma_kros_down or llv_break
            
            # Layer 4: MFI + Volume
            prev_mfi_max = 0.0
            for k in range(1, self.config.mfi_hhv_period + 1):
                if i - k >= 0 and mfi[i - k] > prev_mfi_max:
                    prev_mfi_max = mfi[i - k]
            mfi_long_ok = (mfi[i] > self.config.mfi_long) and (mfi[i] > prev_mfi_max)
            
            prev_mfi_min = float('inf')
            for k in range(1, self.config.mfi_llv_period + 1):
                if i - k >= 0 and mfi[i - k] < prev_mfi_min:
                    prev_mfi_min = mfi[i - k]
            mfi_short_ok = (mfi[i] < self.config.mfi_short) and (mfi[i] < prev_mfi_min)
            
            # Volume avg
            vol_avg = 0.0
            count = 0
            for k in range(1, 21):
                if i - k >= 0:
                    vol_avg += volumes[i - k]
                    count += 1
            if count > 0:
                vol_avg /= count
                
            vol_ok = (volumes[i] >= vol_avg * self.config.vol_ratio)
            
            onay_long = mfi_long_ok and vol_ok
            onay_short = mfi_short_ok and vol_ok
            cooldown_ok = (cooldown_ct == 0)
            
            # Entry Logic
            giris_long = (not in_long) and (not in_short) and rejim_long and trend_long and tetik_long and onay_long and cooldown_ok
            giris_short = (not in_long) and (not in_short) and rejim_short and trend_short and tetik_short and onay_short and cooldown_ok
            
            if giris_long:
                signal_arr[i] = 1 # A
                in_long = True
                entry_price = closes[i]
                extreme_val = closes[i]
                stop_level = entry_price - atr[i] * self.config.atr_stop_mult_long
                bars_in_pos = 0
            elif giris_short and not is_spot:
                signal_arr[i] = -1 # S
                in_short = True
                entry_price = closes[i]
                extreme_val = closes[i]
                stop_level = entry_price + atr[i] * self.config.atr_stop_mult_short
                bars_in_pos = 0
                
            # Long Position Management
            if in_long:
                bars_in_pos += 1
                
                if closes[i] > extreme_val:
                    extreme_val = closes[i]
                    stop_level = extreme_val - atr[i] * self.config.atr_stop_mult_long
                    
                kar_al_fiyat = entry_price * (1.0 + self.config.kar_al_yuzde_long / 100.0)
                
                stop_hit = (closes[i] <= stop_level)
                kar_al_hit = (closes[i] >= kar_al_fiyat)
                rejim_kirildi = not rejim_long
                trend_kirildi = not trend_long
                min_hold_ok = (bars_in_pos >= self.config.min_hold_bars)
                max_hold_hit = (bars_in_pos >= self.config.max_hold_bars)
                
                cikis_ok = (stop_hit or kar_al_hit) or (rejim_kirildi) or (trend_kirildi and min_hold_ok) or max_hold_hit
                
                if cikis_ok:
                    signal_arr[i] = 0 # F
                    in_long = False
                    cooldown_ct = self.config.cooldown_bars
                    bars_in_pos = 0
                    entry_price = 0.0
                    extreme_val = 0.0
                    stop_level = 0.0
                    
            # Short Position Management
            if in_short:
                bars_in_pos += 1
                
                if closes[i] < extreme_val:
                    extreme_val = closes[i]
                    stop_level = extreme_val + atr[i] * self.config.atr_stop_mult_short
                    
                kar_al_fiyat = entry_price * (1.0 - self.config.kar_al_yuzde_short / 100.0)
                
                stop_hit = (closes[i] >= stop_level)
                kar_al_hit = (closes[i] <= kar_al_fiyat)
                rejim_kirildi = not rejim_short
                trend_kirildi = not trend_short
                min_hold_ok = (bars_in_pos >= self.config.min_hold_bars)
                max_hold_hit = (bars_in_pos >= self.config.max_hold_bars)
                
                cikis_ok = (stop_hit or kar_al_hit) or (rejim_kirildi) or (trend_kirildi and min_hold_ok) or max_hold_hit
                
                if cikis_ok:
                    signal_arr[i] = 0 # F
                    in_short = False
                    cooldown_ct = self.config.cooldown_bars
                    bars_in_pos = 0
                    entry_price = 0.0
                    extreme_val = 0.0
                    stop_level = 0.0
        
        # Mapping back to the DataFrame
        df['signal'] = 0
        df.loc[signal_arr == 1, 'signal'] = 1
        df.loc[signal_arr == -1, 'signal'] = -1
        # Calculate 'position' cumulative from signal changes
        pos_arr = np.zeros(n, dtype=np.int8)
        current_pos = 0
        for i in range(n):
            if signal_arr[i] == 1:
                current_pos = 1
            elif signal_arr[i] == -1:
                current_pos = -1
            elif signal_arr[i] == 0 and (df['signal'].iloc[i] == 0 and sum(signal_arr[:i+1] == 0) > 0): 
                # this check is slightly simplified. We need exact entry/exit signals for dataframe layout
                pass
                
        # Better: use proper events logic
        # In IdealQuant, usually the BaseStrategy is driven by Numba optimized code natively during Backtest.
        
        return df
