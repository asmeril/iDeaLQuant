# -*- coding: utf-8 -*-
"""
Genetic Algorithm Optimizer for Strategy 2 (ARS Trend v2)
Hibrit yaklaÅŸÄ±m: Grid Search + Genetic Algorithm

Avantajlar:
- Daha az kombinasyon denemesi
- Yerel optimumlara takÄ±lmaz
- YÃ¼ksek boyutlu parametre uzaylarÄ±nda etkili
"""

import sys
import os
import numpy as np
import pandas as pd
from time import time
from multiprocessing import Pool, cpu_count
from dataclasses import dataclass
from typing import List, Tuple, Dict, Any, Optional, Callable
import random

# Proje kÃ¶k dizini
sys.path.insert(0, os.path.abspath(os.path.join(os.path.dirname(__file__), '..', '..')))

from src.indicators.core import EMA, ATR, Momentum, HHV, LLV, ARS_Dynamic, MoneyFlowIndex
from src.strategies.tott_hott_strategy import TOTT_HOTTStrategy

# ==============================================================================
# GENETIC ALGORITHM CONFIG
# ==============================================================================
@dataclass
class GeneticConfig:
    """Genetik Algoritma KonfigÃ¼rasyonu"""
    population_size: int = 50          # PopÃ¼lasyon boyutu
    generations: int = 30              # Nesil sayÄ±sÄ±
    elite_ratio: float = 0.1           # Elit oran (%10)
    crossover_rate: float = 0.8        # Ã‡aprazlama oranÄ±
    mutation_rate: float = 0.15        # Mutasyon oranÄ±
    tournament_size: int = 5           # Turnuva boyutu
    
    # Erken durdurma
    early_stop_generations: int = 8    # Ä°yileÅŸme olmadan bekleme
    min_improvement: float = 0.01      # Minimum iyileÅŸme oranÄ±


# ==============================================================================
# PARAMETER SPACE
# ==============================================================================

# Strateji 1 Parametre UzayÄ± (20 parametre)
STRATEGY1_PARAMS = {
    # ARS
    'ars_period': (2, 15, 1, True),
    'ars_k': (0.005, 0.03, 0.005, False),
    # ADX
    'adx_period': (10, 30, 2, True),
    'adx_threshold': (15.0, 35.0, 5.0, False),
    # MACD-V
    'macdv_short': (8, 18, 1, True),
    'macdv_long': (20, 40, 2, True),
    'macdv_signal': (5, 15, 1, True),
    'macdv_threshold': (0.0, 5.0, 0.5, False),  # MACDV sinyal farkÄ± eÅŸiÄŸi (gerÃ§ekÃ§i aralÄ±k)
    # NetLot
    'netlot_period': (3, 10, 1, True),
    'netlot_threshold': (10.0, 50.0, 5.0, False),
    # Yatay Filtre
    'ars_mesafe_threshold': (0.1, 0.5, 0.05, False),
    'bb_period': (15, 30, 5, True),
    'bb_std': (1.5, 3.0, 0.5, False),
    'bb_width_multiplier': (0.5, 1.5, 0.1, False),
    'bb_avg_period': (30, 100, 10, True),
    'yatay_ars_bars': (5, 20, 5, True),
    'yatay_adx_threshold': (15.0, 30.0, 5.0, False),
    'filter_score_threshold': (1, 4, 1, True),
    # Skor
    'min_score': (2, 4, 1, True),
    'exit_score': (2, 4, 1, True),
}

# Strateji 2 Parametre UzayÄ± (20 parametre)
STRATEGY2_PARAMS = {
    # ARS Dinamik
    'ars_ema_period': (2, 12, 1, True),
    'ars_atr_period': (7, 20, 2, True),
    'ars_atr_mult': (0.3, 1.5, 0.1, False),
    'ars_min_band': (0.001, 0.005, 0.001, False),
    'ars_max_band': (0.010, 0.025, 0.005, False),
    # GiriÅŸ Filtreleri
    'momentum_period': (3, 10, 1, True),
    'momentum_threshold': (50.0, 200.0, 25.0, False),
    'breakout_period': (5, 30, 5, True),
    'mfi_period': (10, 21, 2, True),
    'mfi_hhv_period': (10, 21, 2, True),
    'mfi_llv_period': (10, 21, 2, True),
    'volume_hhv_period': (10, 21, 2, True),
    # Ã‡Ä±kÄ±ÅŸ/Risk
    'atr_exit_period': (10, 21, 2, True),
    'atr_sl_mult': (1.0, 4.0, 0.5, False),
    'atr_tp_mult': (3.0, 8.0, 1.0, False),
    'atr_trail_mult': (1.0, 4.0, 0.5, False),
    'exit_confirm_bars': (1, 5, 1, True),
    'exit_confirm_mult': (0.5, 2.0, 0.25, False),
    # Ä°nce Ayar
    'volume_mult': (0.5, 1.5, 0.1, False),
    'volume_llv_period': (10, 21, 2, True),
}

# Strateji 3 (Paradise) Parametre Uzayi (12 parametre)
STRATEGY3_PARAMS = {
    # Trend
    'ema_period': (5, 80, 1, True),
    'dsma_period': (15, 150, 5, True),
    'ma_period': (5, 80, 1, True),
    # Breakout
    'hh_period': (5, 80, 1, True),
    'vol_hhv_period': (5, 50, 1, True),
    # Momentum
    'mom_period': (10, 150, 5, True),
    'mom_alt': (90.0, 99.5, 0.5, False),
    'mom_ust': (100.5, 110.0, 0.5, False),
    # Risk
    'atr_period': (5, 30, 1, True),
    'atr_sl': (0.5, 5.0, 0.25, False),
    'atr_tp': (1.0, 10.0, 0.5, False),
    'atr_trail': (0.5, 6.0, 0.25, False),
}

# Strateji 4 (TOMA) Parametre Uzayi (17 parametre)
# NOT: Genetik/Bayesian icin genis aralik - Grid'den daha genis tutulmustur.
# Grid (brute-force) dar aralik kullanir, Genetik/Bayesian akilli arama yapar.
STRATEGY4_PARAMS = {
    # TOMA (Layer 3 - Izleyen Stop) â€” fiziksel sinir, dar tutulmali
    'toma_period': (1, 3, 1, True),
    'toma_opt': (0.1, 5.0, 0.1, False),
    'hhv1_period': (10, 500, 5, True),
    'llv1_period': (10, 500, 5, True),
    
    # Global Settings â€” genis aralik, akilli arama avantaji
    'mom_period': (100, 3000, 50, True),
    'trix_period': (10, 300, 5, True),
    'trix_period2': (10, 300, 5, True),  # TRIX2 for Layer 2 (MOM < low)
    
    # Layer 1 (Mom High)
    'mom_limit_high': (100.25, 115.0, 0.25, False),
    'trix_lb1': (10, 300, 5, True),
    'hhv2_period': (10, 500, 5, True),
    'llv2_period': (10, 500, 5, True),
    
    # Layer 2 (Mom Low)
    'mom_limit_low': (85.0, 99.75, 0.25, False),
    'trix_lb2': (10, 300, 5, True),
    'hhv3_period': (10, 500, 5, True),
    'llv3_period': (10, 500, 5, True),
    
    # Risk
    'kar_al': (0.0, 15.0, 0.5, False),
    'iz_stop': (0.0, 5.0, 0.25, False),
}

# Strateji 5 (Oliver Kell) Parametre Uzayi (7 parametre)
STRATEGY5_PARAMS = {
    # EMA Trend
    'ema_fast': (5, 20, 1, True),
    'ema_slow': (10, 50, 1, True),
    # Breakout
    'breakout_period': (5, 30, 1, True),
    # ADX Chop Filter
    'adx_period': (7, 30, 1, True),
    'adx_threshold': (10.0, 35.0, 1.0, False),
    # Volume
    'vol_ma_period': (5, 40, 1, True),
    # Risk / Trailing Stop
    'trailing_stop_pct': (0.5, 5.0, 0.25, False),
}

# Strateji 6 (TOTT_HOTT) Parametre UzayÄ± (7 parametre)
STRATEGY6_PARAMS = {
    # Trend
    'ott_period': (20, 50, 5, True),
    'ott_pct_big': (6.0, 9.0, 0.5, False),
    'ott_pct_small': (2.8, 4.0, 0.2, False),
    # Bolge
    'ott_mult': (0.0005, 0.0011, 0.0003, False),
    'sott_pct': (0.2, 0.4, 0.1, False),
    # Kapi
    'gate_period': (10, 34, 6, True),
    'gate_pct': (0.4, 0.6, 0.1, False),
}

# Strateji 7 (DeepScalp v1.2) Parametre Uzayi (12 ana parametre)
STRATEGY7_PARAMS = {
    # Layer 1: Risk & Regime
    'ars_k': (0.8, 2.0, 0.2, False),
    'atr_stop_mult_long': (1.0, 2.5, 0.25, False),
    'atr_stop_mult_short': (1.0, 2.5, 0.25, False),
    'kar_al_yuzde_long': (1.0, 4.0, 0.5, False),
    'kar_al_yuzde_short': (1.0, 4.0, 0.5, False),
    'hhv_period': (8, 20, 2, True),
    'llv_period': (8, 20, 2, True),
    'vol_ratio': (0.60, 1.00, 0.10, False),
    
    # Layer 2: Trend
    'st_factor': (2.0, 4.0, 0.5, False),
    'ema_fast_period': (5, 13, 2, True),
    'ema_slow_period': (15, 30, 3, True),
    'mfi_hhv_period': (3, 9, 2, True),
    'mfi_llv_period': (3, 9, 2, True),
    
    # Layer 3 & 4: Timing
    'toma_period2': (1.5, 3.0, 0.2, False),
    'mfi_long': (45.0, 65.0, 5.0, False),
    'mfi_short': (35.0, 55.0, 5.0, False),
    
    # Layer 5: Time filters
    'min_hold_bars': (1, 4, 1, True),
    'max_hold_bars': (10, 30, 5, True),
    'cooldown_bars': (1, 4, 1, True),
}

# Strateji 8 (Gap Reversal v1.0) Parametre Uzayi
STRATEGY8_PARAMS = {
    'min_gap_pct': (0.01, 0.50, 0.05, False),
    'max_gap_pct': (0.50, 5.00, 0.50, False),
    'or_bars': (5, 40, 5, True),
    'rsi_period': (3, 14, 1, True),
    'rsi_ob': (55.0, 75.0, 5.0, False),
    'rsi_os': (25.0, 45.0, 5.0, False),
    'hacim_ma_period': (10, 30, 5, True),
    'hacim_oran': (0.3, 1.5, 0.1, False),
    'atr_period': (7, 21, 3, True),
    'atr_stop_mult': (0.2, 2.0, 0.25, False),
    'gap_window_bars': (60, 360, 30, True),
    'cooldown_bars': (1, 6, 1, True),
}

# Import S4 Optimizer components
# Try/Except block to avoid circular import issues during initialization if imported at top
try:
    from src.optimization.strategy4_optimizer import fast_backtest_strategy4, IndicatorCache as S4IndicatorCache
except ImportError:
    pass # Will be handled inside evaluate



class ParameterSpace:
    """Parametre uzayÄ± tanÄ±mÄ± - Her iki strateji iÃ§in"""
    def __init__(self, strategy_index: int = 1, narrowed_ranges: dict = None):
        """
        Args:
            strategy_index: 0=Gatekeeper, 1=ARS Trend v2, 2=ARS Pulse
            narrowed_ranges: Cascade modunda dar araliklar {param_name: (min, max)}
        """
        self.strategy_index = strategy_index
        # Orijinal parametreleri kopyala
        if strategy_index == 0:
            base_params = STRATEGY1_PARAMS
        elif strategy_index == 1:
            base_params = STRATEGY2_PARAMS
        elif strategy_index == 2:
            base_params = STRATEGY3_PARAMS
        elif strategy_index == 3:
            base_params = STRATEGY4_PARAMS
        elif strategy_index == 4:
            base_params = STRATEGY5_PARAMS
        elif strategy_index == 5:
            base_params = STRATEGY6_PARAMS
        elif strategy_index == 6:
            base_params = STRATEGY7_PARAMS
        elif strategy_index == 7:
            base_params = STRATEGY8_PARAMS
        else:
            raise ValueError(f"Gecersiz strategy_index: {strategy_index}. 0/1/2/3/4/5/6/7 desteklenir.")
            
        self.params = {k: list(v) for k, v in base_params.items()}  # Mutable copy
        
        # Cascade: Dar aralik varsa uygula
        if narrowed_ranges:
            self._apply_narrowed_ranges(narrowed_ranges)
        
        self.param_names = list(self.params.keys())
        self.n_params = len(self.param_names)
    
    def _apply_narrowed_ranges(self, narrowed_ranges: dict):
        """Cascade modunda dar araliklari uygula"""
        for param_name, (new_min, new_max) in narrowed_ranges.items():
            if param_name in self.params:
                original = self.params[param_name]
                # original: [min, max, step, is_int]
                orig_min, orig_max, step, is_int = original
                
                # Yeni araligi orijinal sinirlar icinde tut
                final_min = max(new_min, orig_min)
                final_max = min(new_max, orig_max)
                
                # Gecerlilik kontrolu
                if final_min <= final_max:
                    self.params[param_name] = [final_min, final_max, step, is_int]
                    print(f"  [CASCADE] {param_name}: [{orig_min:.4g}-{orig_max:.4g}] => [{final_min:.4g}-{final_max:.4g}]")
        
    def random_individual(self) -> np.ndarray:
        """Rastgele birey oluÅŸtur"""
        genes = []
        for name in self.param_names:
            min_val, max_val, step, is_int = self.params[name]
            if is_int:
                val = random.choice(range(int(min_val), int(max_val) + 1, int(step)))
            else:
                n_steps = int((max_val - min_val) / step) + 1
                val = min_val + random.randint(0, n_steps - 1) * step
            genes.append(val)
        return np.array(genes)
    
    def decode(self, genes: np.ndarray) -> Dict[str, Any]:
        """Genleri parametre sÃ¶zlÃ¼ÄŸÃ¼ne Ã§evir (numpy tiplerini native Python'a Ã§evir)"""
        result = {}
        for i, name in enumerate(self.param_names):
            val = genes[i]
            is_int = self.params[name][3]  # (min, max, step, is_int)
            result[name] = int(round(val)) if is_int else float(val)
        return result
    
    def mutate(self, genes: np.ndarray) -> np.ndarray:
        """Mutasyon uygula"""
        new_genes = genes.copy()
        for i, name in enumerate(self.param_names):
            if random.random() < 0.3:  # Her gen iÃ§in %30 ÅŸans
                min_val, max_val, step, is_int = self.params[name]
                # Rastgele yeni deÄŸer veya Â±step
                if random.random() < 0.5:
                    # KÃ¼Ã§Ã¼k mutasyon
                    delta = step * random.choice([-1, 1])
                    new_val = np.clip(new_genes[i] + delta, min_val, max_val)
                    # Period parametreleri iÃ§in integer zorunluluÄŸu
                    new_genes[i] = int(round(new_val)) if is_int else new_val
                else:
                    # Tamamen yeni deÄŸer
                    if is_int:
                        new_genes[i] = random.choice(range(int(min_val), int(max_val) + 1, int(step)))
                    else:
                        n_steps = int((max_val - min_val) / step) + 1
                        new_genes[i] = min_val + random.randint(0, n_steps - 1) * step
        return new_genes

    
    def crossover(self, parent1: np.ndarray, parent2: np.ndarray) -> Tuple[np.ndarray, np.ndarray]:
        """Ä°ki noktalÄ± Ã§aprazlama"""
        n = len(parent1)
        if n < 3:
            return parent1.copy(), parent2.copy()
        
        # Ä°ki nokta seÃ§
        points = sorted(random.sample(range(1, n), 2))
        p1, p2 = points
        
        child1 = np.concatenate([parent1[:p1], parent2[p1:p2], parent1[p2:]])
        child2 = np.concatenate([parent2[:p1], parent1[p1:p2], parent2[p2:]])
        
        return child1, child2


# ==============================================================================
# FITNESS FUNCTION (Strategy-based Backtest wrapper)
# ==============================================================================
class FitnessEvaluator:
    """Fitness deÄŸerlendirici - Her iki strateji iÃ§in backtest wrapper"""
    
    def __init__(self, df: pd.DataFrame, strategy_index: int = 1, commission: float = 0.0, slippage: float = 0.0, vade_tipi: str = "ENDEKS"):
        """
        Args:
            df: Veri DataFrame'i
            strategy_index: 0 = Strateji 1 (Gatekeeper), 1 = Strateji 2 (ARS Trend v2)
            commission: Ä°ÅŸlem baÅŸÄ± komisyon
            slippage: Ä°ÅŸlem baÅŸÄ± kayma
        """
        self.df = df
        self.strategy_index = strategy_index
        self.commission = commission
        self.slippage = slippage
        self.vade_tipi = vade_tipi
        
        # Hem Ä°ngilizce hem TÃ¼rkÃ§e kolon isimlerini destekle
        open_col = 'Acilis' if 'Acilis' in df.columns else 'Open'
        high_col = 'Yuksek' if 'Yuksek' in df.columns else 'High'
        low_col = 'Dusuk' if 'Dusuk' in df.columns else 'Low'
        close_col = 'Kapanis' if 'Kapanis' in df.columns else 'Close'
        vol_col = 'Lot' if 'Lot' in df.columns else 'Volume'
        
        self.opens = df[open_col].to_numpy().flatten()
        self.highs = df[high_col].to_numpy().flatten()
        self.lows = df[low_col].to_numpy().flatten()
        self.closes = df[close_col].to_numpy().flatten()
        self.typical = df['Tipik'].values.flatten() if 'Tipik' in df.columns else ((df[high_col] + df[low_col] + df[close_col]) / 3).values.flatten()
        self.volumes = df[vol_col].values.flatten()
        self.lots = df[vol_col].values.flatten()
        self.n = len(self.closes)
        
        # Tarih bilgisi
        if 'DateTime' in df.columns:
            self.dates = df['DateTime'].tolist()
            self.times = df['DateTime'].tolist()
        else:
            self.dates = None
            self.times = None
        
        # Cache for indicators
        self._indicator_cache = {}
    
    def _get_cached(self, key, calc_fn):
        if key not in self._indicator_cache:
            self._indicator_cache[key] = calc_fn()
        return self._indicator_cache[key]
    
    def evaluate(self, params: Dict[str, Any]) -> Dict[str, float]:
        """Birey fitness'Ä±nÄ± hesapla - strateji bazlÄ±"""
        params['vade_tipi'] = self.vade_tipi
        try:
            if self.strategy_index == 0:
                return self._evaluate_strategy1(params)
            elif self.strategy_index == 1:
                return self._evaluate_strategy2(params)
            elif self.strategy_index == 2:
                return self._evaluate_strategy3(params)

            elif self.strategy_index == 3:
                return self._evaluate_strategy4(params)
            elif self.strategy_index == 4:
                return self._evaluate_strategy5(params)
            elif self.strategy_index == 5:
                return self._evaluate_strategy6(params)
            elif self.strategy_index == 6:
                return self._evaluate_strategy7(params)
            elif self.strategy_index == 7:
                return self._evaluate_strategy8(params)
            else:
                raise ValueError(f"Gecersiz strategy_index: {self.strategy_index}")
        except Exception as e:
            import traceback
            traceback.print_exc()
            print(f"DEBUG: Genetic Eval Failed: {str(e)}")
            return {'net_profit': -999999, 'trades': 0, 'pf': 0, 'max_dd': 999999, 'fitness': -999999}


    def _evaluate_strategy1(self, params: Dict[str, Any]) -> Dict[str, float]:
        """Strateji 1 (Gatekeeper) iÃ§in fitness hesapla"""
        from src.strategies.score_based import ScoreBasedStrategy
        from src.optimization.hybrid_group_optimizer import fast_backtest
        from src.optimization.fitness import quick_fitness
        
        # Kendi cache'imizi oluÅŸtur (from_config_dict iÃ§in)
        class SimpleCache:
            def __init__(self, evaluator):
                self.opens = evaluator.opens
                self.highs = evaluator.highs
                self.lows = evaluator.lows
                self.closes = evaluator.closes
                self.typical = evaluator.typical
                self.lots = evaluator.volumes
                self.volumes = evaluator.volumes
                self.dates = evaluator.dates
                self.times = evaluator.dates
                self.n = evaluator.n
                self.df = evaluator.df
        
        cache = SimpleCache(self)
        
        # Strateji oluÅŸtur ve sinyal Ã¼ret
        strategy = ScoreBasedStrategy.from_config_dict(cache, params)
        signals, exits_long, exits_short = strategy.generate_all_signals()
        
        # Trading days calculation
        trading_days = 252.0
        if self.dates and len(self.dates) > 1:
            try:
                trading_days = (self.dates[-1] - self.dates[0]).days
            except:
                pass
        
        # Backtest
        np_val, trades, pf, dd, sharpe = fast_backtest(self.closes, signals, exits_long, exits_short, self.commission, self.slippage, trading_days=trading_days)
        
        # Fitness hesapla - Maliyetler np_val icinde dusuruldu, commission/slippage=0.0 gonderilmeli
        fitness = quick_fitness(
            np_val, pf, dd, trades, sharpe=sharpe,
            initial_capital=10000.0,
            commission=0.0,
            slippage=0.0
        )
        
        return {
            'net_profit': np_val,
            'trades': trades,
            'pf': pf,
            'max_dd': dd,
            'sharpe': sharpe,
            'fitness': fitness
        }
    
    def _evaluate_strategy2(self, params: Dict[str, Any]) -> Dict[str, float]:
        """Strateji 2 (ARS Trend v2) iÃ§in fitness hesapla"""
        try:
            from src.strategies.ars_trend_v2 import ARSTrendStrategyV2
            from src.optimization.hybrid_group_optimizer import fast_backtest
            from src.optimization.fitness import quick_fitness
            
            # Simple wrapper for cache
            class SimpleCache:
                def __init__(self, evaluator):
                    self.opens = evaluator.opens
                    self.highs = evaluator.highs
                    self.lows = evaluator.lows
                    self.closes = evaluator.closes
                    self.typical = evaluator.typical
                    self.lots = evaluator.volumes
                    self.volumes = evaluator.volumes
                    self.dates = evaluator.dates
                    self.times = evaluator.dates
                    self.n = evaluator.n
                    self.df = evaluator.df

            cache = SimpleCache(self)
            
            # Gercek strateji sinifini kullan (Seans saati, tatil filtreleri vb. icin)
            strategy = ARSTrendStrategyV2.from_config_dict(cache, params)
            signals, exits_long, exits_short = strategy.generate_all_signals()
            
            # Trading days calculation
            trading_days = 252.0
            if self.dates and len(self.dates) > 1:
                try:
                    trading_days = (self.dates[-1] - self.dates[0]).days
                except: pass
            
            # Backtest (Hibrit ile ayni fonksiyonu kullan)
            np_val, trades, pf, dd, sharpe = fast_backtest(
                self.closes, signals, exits_long, exits_short, 
                self.commission, self.slippage, trading_days=trading_days
            )
            
            # Fitness - Maliyetler np_val icinde, burada 0.0 gonderilmeli
            fitness = quick_fitness(
                np_val, pf, dd, trades, sharpe=sharpe,
                commission=0.0, slippage=0.0
            )
            
            return {
                'net_profit': np_val,
                'trades': trades,
                'pf': pf,
                'max_dd': dd,
                'sharpe': sharpe,
                'fitness': fitness
            }
        except Exception as e:
            import traceback
            traceback.print_exc()
            return {'net_profit': -999999, 'trades': 0, 'pf': 0, 'max_dd': 999999, 'fitness': -999999}

    def _evaluate_strategy3(self, params: Dict[str, Any]) -> Dict[str, float]:
        """Strateji 3 (Paradise) icin fitness hesapla"""
        try:
            from src.strategies.paradise_strategy import ParadiseStrategy
            from src.optimization.hybrid_group_optimizer import fast_backtest
            from src.optimization.fitness import quick_fitness
            
            class SimpleCache:
                def __init__(self, evaluator):
                    self.opens = evaluator.opens
                    self.highs = evaluator.highs
                    self.lows = evaluator.lows
                    self.closes = evaluator.closes
                    self.typical = evaluator.typical
                    self.lots = evaluator.volumes
                    self.volumes = evaluator.volumes
                    self.dates = evaluator.dates
                    self.times = evaluator.dates
                    self.n = evaluator.n
                    self.df = evaluator.df

            cache = SimpleCache(self)
            strategy = ParadiseStrategy.from_config_dict(cache, params)
            signals, exits_long, exits_short = strategy.generate_all_signals()
            
            trading_days = 252.0
            if self.dates and len(self.dates) > 1:
                try:
                    trading_days = (self.dates[-1] - self.dates[0]).days
                except: pass
            
            np_val, trades, pf, dd, sharpe = fast_backtest(
                self.closes, signals, exits_long, exits_short, 
                self.commission, self.slippage, trading_days=trading_days
            )
            
            fitness = quick_fitness(
                np_val, pf, dd, trades, sharpe=sharpe,
                commission=0.0, slippage=0.0
            )
            
            return {
                'net_profit': np_val,
                'trades': trades,
                'pf': pf,
                'max_dd': dd,
                'sharpe': sharpe,
                'fitness': fitness
            }
        except Exception as e:
            import traceback
            traceback.print_exc()
            return {'net_profit': -999999, 'trades': 0, 'pf': 0, 'max_dd': 999999, 'fitness': -999999}

    def _evaluate_strategy4(self, params: Dict[str, Any]) -> Dict[str, float]:
        """Strateji 4 (TOMA) icin fitness hesapla"""
        try:
            from src.optimization.strategy4_optimizer import fast_backtest_strategy4, IndicatorCache
            import numpy as np
            from src.optimization.fitness import quick_fitness
            
            # Cache Management
            if 's4_cache' not in self._indicator_cache:
                self._indicator_cache['s4_cache'] = IndicatorCache(self.df)
            cache = self._indicator_cache['s4_cache']
            
            # Extract Params
            toma_period = int(params.get('toma_period', 97))
            toma_opt = float(params.get('toma_opt', 1.5))
            hhv1_p = int(params.get('hhv1_period', 20))
            llv1_p = int(params.get('llv1_period', 20))
            
            mom_period = int(params.get('mom_period', 1900))
            trix_period = int(params.get('trix_period', 120))
            trix_period2 = int(params.get('trix_period2', 100))
            
            mh = float(params.get('mom_limit_high', 101.5))
            trix_lb1 = int(params.get('trix_lb1', 145))
            hhv2_p = int(params.get('hhv2_period', 150))
            llv2_p = int(params.get('llv2_period', 190))
            
            ml = float(params.get('mom_limit_low', 99.0))
            trix_lb2 = int(params.get('trix_lb2', 160))
            hhv3_p = int(params.get('hhv3_period', 150))
            llv3_p = int(params.get('llv3_period', 190))
            
            ka = float(params.get('kar_al', 0.0))
            iz = float(params.get('iz_stop', 0.0))
            
            # Get Indicator Arrays (using cache)
            toma_val, toma_trend = cache.get_toma(toma_period, toma_opt)
            hhv1 = cache.get_hhv(hhv1_p)
            llv1 = cache.get_llv(llv1_p)
            
            mom_arr = cache.get_mom(mom_period)
            trix1_arr = cache.get_trix(trix_period)
            trix2_arr = cache.get_trix(trix_period2)
            
            hhv2 = cache.get_hhv(hhv2_p)
            llv2 = cache.get_llv(llv2_p)
            
            hhv3 = cache.get_hhv(hhv3_p)
            llv3 = cache.get_llv(llv3_p)
            
            # Mask (Get from dataframe based on vade_tipi)
            if hasattr(self.df, 'get_trading_mask'):
                mask_series = self.df.get_trading_mask(self.vade_tipi)
                mask_arr = mask_series.values
            else:
                mask_arr = np.ones(len(self.closes), dtype=bool)
            
            # Run Fast Backtest
            result = fast_backtest_strategy4(
                self.closes, 
                toma_trend, toma_val, 
                hhv1, llv1, 
                hhv2, llv2, 
                hhv3, llv3, 
                mom_arr, trix1_arr, trix2_arr,
                mask_arr, cache.times_arr,
                ml, mh, 
                trix_lb1, trix_lb2, 
                ka / 100.0, iz / 100.0,
                3  # phase_mode=3: all layers
            )
            
            np_val, trades, pf, max_dd, sharpe, active_days, total_days = result
            
            if trades == 0 or np_val <= -999:
                return {'net_profit': -999, 'trades': 0, 'pf': 0, 'max_dd': 999, 'fitness': -999}
            
            # Fitness Calc
            fitness = quick_fitness(
                np_val, pf, max_dd, trades, sharpe=sharpe,
                active_days=active_days, total_days=total_days,
                commission=0.0, slippage=0.0
            )
            
            return {
                'net_profit': np_val,
                'trades': trades,
                'pf': pf,
                'max_dd': max_dd,
                'sharpe': sharpe,
                'fitness': fitness
            }
            
        except Exception as e:
            # print(f"S4 Eval Error: {e}")
            return {'net_profit': -999999, 'trades': 0, 'pf': 0, 'max_dd': 999999, 'fitness': -999999}

    def _evaluate_strategy5(self, params: Dict[str, Any]) -> Dict[str, float]:
        """Strateji 5 (Oliver Kell) icin fitness hesapla"""
        try:
            from src.optimization.strategy5_optimizer import fast_backtest_strategy5, IndicatorCache as S5IndicatorCache
            import numpy as np
            from src.optimization.fitness import quick_fitness
            
            # Cache Management
            if 's5_cache' not in self._indicator_cache:
                self._indicator_cache['s5_cache'] = S5IndicatorCache(self.df)
            cache = self._indicator_cache['s5_cache']
            
            # Extract Params
            ema_fast_p = int(params.get('ema_fast', 10))
            ema_slow_p = int(params.get('ema_slow', 20))
            breakout_p = int(params.get('breakout_period', 10))
            adx_p = int(params.get('adx_period', 14))
            adx_thresh = float(params.get('adx_threshold', 20.0))
            vol_ma_p = int(params.get('vol_ma_period', 20))
            trail_pct = float(params.get('trailing_stop_pct', 1.5))
            
            # Get Indicator Arrays (using cache)
            ema_fast_arr = cache.get_ema(ema_fast_p)
            ema_slow_arr = cache.get_ema(ema_slow_p)
            adx_arr = cache.get_adx(adx_p)
            hhv_arr = cache.get_hhv(breakout_p)
            llv_arr = cache.get_llv(breakout_p)
            vol_ma_arr = cache.get_vol_ma(vol_ma_p)
            
            # Mask
            try:
                from src.engine.data import OHLCV
                mask_arr = OHLCV(self.df).get_trading_mask(self.vade_tipi).astype(bool)
            except:
                mask_arr = np.ones(len(self.closes), dtype=bool)
            
            # Run Fast Backtest
            result = fast_backtest_strategy5(
                self.closes, self.highs, self.lows, self.volumes,
                ema_fast_arr, ema_slow_arr,
                adx_arr, hhv_arr, llv_arr, vol_ma_arr,
                mask_arr, cache.times_arr,
                adx_thresh, trail_pct / 100.0
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

    def _evaluate_strategy6(self, params: Dict[str, Any]) -> Dict[str, float]:
        """Strateji 6 (TOTT_HOTT) icin fitness hesapla"""
        try:
            from src.strategies.tott_hott_strategy import TOTT_HOTTStrategy
            from src.optimization.hybrid_group_optimizer import fast_backtest
            from src.optimization.fitness import quick_fitness

            class SimpleCache:
                def __init__(self, evaluator):
                    self.opens = evaluator.opens
                    self.highs = evaluator.highs
                    self.lows = evaluator.lows
                    self.closes = evaluator.closes
                    self.typical = evaluator.typical
                    self.lots = evaluator.volumes
                    self.volumes = evaluator.volumes
                    self.dates = evaluator.dates
                    self.times = evaluator.dates
                    self.n = evaluator.n
                    self.df = evaluator.df

            cache = SimpleCache(self)
            strategy = TOTT_HOTTStrategy.from_config_dict(cache, params)
            signals, exits_long, exits_short = strategy.generate_all_signals()

            trading_days = 252.0
            if self.dates and len(self.dates) > 1:
                try:
                    trading_days = (self.dates[-1] - self.dates[0]).days
                except: pass

            np_val, trades, pf, dd, sharpe = fast_backtest(
                self.closes, signals, exits_long, exits_short,
                self.commission, self.slippage, trading_days=trading_days
            )

            fitness = quick_fitness(
                np_val, pf, dd, trades, sharpe=sharpe,
                commission=0.0, slippage=0.0
            )

            return {
                'net_profit': np_val,
                'trades': trades,
                'pf': pf,
                'max_dd': dd,
                'sharpe': sharpe,
                'fitness': fitness
            }
        except Exception as e:
            import traceback
            traceback.print_exc()
            return {'net_profit': -999999, 'trades': 0, 'pf': 0, 'max_dd': 999999, 'fitness': -999999}
    def _evaluate_strategy7(self, params: dict) -> dict:
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

    def _evaluate_strategy8(self, params: Dict[str, Any]) -> Dict[str, float]:
        """Strateji 8 (Gap Reversal) icin fitness hesapla."""
        try:
            from src.strategies.gap_reversal_strategy import GapReversalStrategy
            from src.optimization.hybrid_group_optimizer import fast_backtest
            from src.optimization.fitness import quick_fitness

            class SimpleCache:
                def __init__(self, evaluator):
                    self.opens = evaluator.opens
                    self.highs = evaluator.highs
                    self.lows = evaluator.lows
                    self.closes = evaluator.closes
                    self.typical = evaluator.typical
                    self.lots = evaluator.volumes
                    self.volumes = evaluator.volumes
                    self.dates = evaluator.dates
                    self.times = evaluator.dates
                    self.n = evaluator.n
                    self.df = evaluator.df

            cache = SimpleCache(self)
            strategy = GapReversalStrategy.from_config_dict(cache, params)
            signals, exits_long, exits_short = strategy.generate_all_signals()

            trading_days = 252.0
            if self.dates and len(self.dates) > 1:
                try:
                    trading_days = (self.dates[-1] - self.dates[0]).days
                except:
                    pass

            np_val, trades, pf, dd, sharpe = fast_backtest(
                self.closes, signals, exits_long, exits_short,
                self.commission, self.slippage, trading_days=trading_days
            )

            fitness = quick_fitness(
                np_val, pf, dd, trades, sharpe=sharpe,
                commission=0.0, slippage=0.0
            )

            return {
                'net_profit': np_val,
                'trades': trades,
                'pf': pf,
                'max_dd': dd,
                'sharpe': sharpe,
                'fitness': fitness
            }
        except Exception:
            import traceback
            traceback.print_exc()
            return {'net_profit': -999999, 'trades': 0, 'pf': 0, 'max_dd': 999999, 'fitness': -999999}



# ==============================================================================
# GENETIC ALGORITHM ENGINE
# ==============================================================================
# Global variable for pool workers to avoid data copying (pickling)
_global_evaluator: Optional['FitnessEvaluator'] = None

def _init_pool(df, strategy_index, commission=0.0, slippage=0.0, vade_tipi="ENDEKS"):
    global _global_evaluator
    _global_evaluator = FitnessEvaluator(df, strategy_index, commission, slippage, vade_tipi)

def _evaluate_individual(individual_and_param_space):
    individual, param_space = individual_and_param_space
    params = param_space.decode(individual)
    result = _global_evaluator.evaluate(params)
    return individual, result

class GeneticOptimizer:
    """Genetik Algoritma Optimizasyon Motoru - Her iki strateji iÃ§in"""
    
    def __init__(self, df: pd.DataFrame, config: Optional[GeneticConfig] = None, 
                 strategy_index: int = 1, n_parallel: int = 4,
                 commission: float = 0.0, slippage: float = 0.0,
                 is_cancelled_callback: Optional[Callable[[], bool]] = None,
                 narrowed_ranges: dict = None, vade_tipi: str = "ENDEKS"):
        """
        Args:
            df: Veri DataFrame'i
            config: Genetik algoritma konfigÃ¼rasyonu
            strategy_index: 0 = Strateji 1, 1 = Strateji 2
            n_parallel: Paralel iÅŸlem sayÄ±sÄ±
            narrowed_ranges: Cascade modu iÃ§in dar parametre aralÄ±klarÄ±
        """
        self.df = df
        self.config = config or GeneticConfig()
        self.strategy_index = strategy_index
        self.n_parallel = n_parallel
        self.commission = commission
        self.slippage = slippage
        self.vade_tipi = vade_tipi
        self.param_space = ParameterSpace(strategy_index, narrowed_ranges)  # Cascade destegi
        self.evaluator = FitnessEvaluator(df, strategy_index, commission, slippage, vade_tipi)
        self.is_cancelled_callback = is_cancelled_callback
        
        self.population: List[np.ndarray] = []
        self.fitness_scores: List[float] = []
        self.best_individual: Optional[np.ndarray] = None
        self.best_fitness: float = -float('inf')
        self.best_params: Optional[Dict] = None
        self.best_result: Optional[Dict] = None
        
        self.generation_history: List[Dict] = []
        self.on_generation_complete = None # Callback function(gen, max_gen, best_fitness)
        
    def initialize_population(self):
        """Ä°lk popÃ¼lasyonu oluÅŸtur"""
        self.population = [
            self.param_space.random_individual() 
            for _ in range(self.config.population_size)
        ]
        
    def evaluate_population(self, pool: Optional[Pool] = None):
        """TÃ¼m popÃ¼lasyonu deÄŸerlendir"""
        self.fitness_scores = [0] * len(self.population)
        
        if self.n_parallel > 1:
            tasks = [(ind, self.param_space) for ind in self.population]
            
            if pool:
                results = pool.map(_evaluate_individual, tasks)
            else:
                with Pool(processes=self.n_parallel, initializer=_init_pool, 
                         initargs=(self.df, self.strategy_index, self.commission, self.slippage, self.vade_tipi)) as p:
                    results = p.map(_evaluate_individual, tasks)
                
            for i, (individual, result) in enumerate(results):
                self.fitness_scores[i] = result['fitness']
                if result['fitness'] > self.best_fitness:
                    self.best_fitness = result['fitness']
                    self.best_individual = individual.copy()
                    self.best_params = self.param_space.decode(individual)
                    self.best_result = result.copy()
        else:
            # Single-threaded
            for i, individual in enumerate(self.population):
                params = self.param_space.decode(individual)
                result = self.evaluator.evaluate(params)
                self.fitness_scores[i] = result['fitness']
                
                if result['fitness'] > self.best_fitness:
                    self.best_fitness = result['fitness']
                    self.best_individual = individual.copy()
                    self.best_params = params.copy()
                    self.best_result = result.copy()
                
    def tournament_selection(self) -> np.ndarray:
        """Turnuva seÃ§imi"""
        indices = random.sample(range(len(self.population)), self.config.tournament_size)
        best_idx = max(indices, key=lambda i: self.fitness_scores[i])
        return self.population[best_idx].copy()
    
    def evolve(self):
        """Bir nesil evrimleÅŸtir"""
        new_population = []
        
        # Elitizm
        n_elite = max(1, int(self.config.population_size * self.config.elite_ratio))
        elite_indices = np.argsort(self.fitness_scores)[-n_elite:]
        for idx in elite_indices:
            new_population.append(self.population[idx].copy())
        
        # Yeni bireyler oluÅŸtur
        while len(new_population) < self.config.population_size:
            parent1 = self.tournament_selection()
            parent2 = self.tournament_selection()
            
            if random.random() < self.config.crossover_rate:
                child1, child2 = self.param_space.crossover(parent1, parent2)
            else:
                child1, child2 = parent1.copy(), parent2.copy()
            
            if random.random() < self.config.mutation_rate:
                child1 = self.param_space.mutate(child1)
            if random.random() < self.config.mutation_rate:
                child2 = self.param_space.mutate(child2)
            
            new_population.append(child1)
            if len(new_population) < self.config.population_size:
                new_population.append(child2)
        
        self.population = new_population[:self.config.population_size]
        
    def run(self, verbose: bool = True) -> Dict:
        """Optimizasyonu Ã§alÄ±ÅŸtÄ±r"""
        start_time = time()
        
        if verbose:
            print(f"Genetik Algoritma Basliyor...")
            print(f"  Populasyon: {self.config.population_size}")
            print(f"  Nesil: {self.config.generations}")
            print(f"  Paralel: {self.n_parallel}")
        
        # Pool'u bir kez oluÅŸtur ve tÃ¼m run boyunca kullan
        pool = None
        if self.n_parallel > 1:
            pool = Pool(processes=self.n_parallel, initializer=_init_pool, initargs=(self.df, self.strategy_index, self.commission, self.slippage, self.vade_tipi))
            
        try:
            # Ä°lk popÃ¼lasyon
            self.initialize_population()
            self.evaluate_population(pool=pool)
            
            no_improve_count = 0
            prev_best = self.best_fitness
            
            for gen in range(self.config.generations):
                # Ä°ptal kontrolÃ¼
                if self.is_cancelled_callback and self.is_cancelled_callback():
                    if verbose: print("Optimizasyon kullanici tarafindan durduruldu.")
                    break

                # Evrim
                self.evolve()
                self.evaluate_population(pool=pool)
                
                # Progress callback
                if self.on_generation_complete:
                    self.on_generation_complete(gen + 1, self.config.generations, self.best_fitness)
                
                if verbose and (gen + 1) % 5 == 0:
                    print(f"  Nesil {gen+1:3d}: Best={self.best_fitness:,.0f}")
                
                # Erken durdurma kontrolÃ¼
                improvement = (self.best_fitness - prev_best) / max(abs(prev_best), 1)
                if improvement < self.config.min_improvement:
                    no_improve_count += 1
                else:
                    no_improve_count = 0
                prev_best = self.best_fitness
                
                if no_improve_count >= self.config.early_stop_generations:
                    break
        finally:
            if pool:
                pool.close()
                pool.join()
        
        elapsed = time() - start_time
        
        # === ROBUST RE-RANKING ===
        # Son popÃ¼lasyondan tÃ¼m sonuÃ§larÄ± topla ve kÃ¼me yoÄŸunluÄŸuna gÃ¶re yeniden sÄ±rala
        try:
            from src.optimization.fitness import calculate_robust_fitness
            all_evaluated = []
            for ind in self.population:
                params = self.param_space.decode(ind)
                result = self.evaluator.evaluate(params)
                result.update(params)
                all_evaluated.append(result)
            
            if len(all_evaluated) >= 3:
                calculate_robust_fitness(all_evaluated)
                all_evaluated.sort(key=lambda x: x.get('robust_fitness', 0), reverse=True)
                
                # En iyi robust sonucu seÃ§
                best_robust = all_evaluated[0]
                old_fitness = self.best_fitness
                
                # Parametre anahtarlarÄ±nÄ± ayÄ±r
                param_names = set(self.param_space.param_names)
                self.best_params = {k: v for k, v in best_robust.items() if k in param_names}
                self.best_result = {k: v for k, v in best_robust.items() if k not in param_names}
                self.best_fitness = best_robust.get('robust_fitness', best_robust.get('fitness', 0))
                
                print(f"  [ROBUST] Re-rank: raw_best={old_fitness:,.0f} -> robust_best={self.best_fitness:,.2f} (density={best_robust.get('density_score', 0):.2f})")
        except Exception as e:
            print(f"  [WARN] Robust re-rank skipped: {e}")
        
        result = {
            'best_params': self.best_params,
            'best_fitness': self.best_fitness,
            'best_result': self.best_result,
            'generations_run': len(self.generation_history),
            'elapsed_time': elapsed,
            'history': self.generation_history
        }
        
        if verbose:
            print(f"\nSonuc:")
            print(f"  Sure: {elapsed:.1f}sn")
            print(f"  Best Fitness: {self.best_fitness:,.0f}")
            print(f"  Net Kar: {self.best_result['net_profit']:,.0f}")
            print(f"  PF: {self.best_result['pf']:.2f}")
            print(f"  Islem: {self.best_result['trades']}")
            print(f"  MaxDD: {self.best_result['max_dd']:,.0f}")
            print(f"\nEn Iyi Parametreler:")
            for k, v in self.best_params.items():
                print(f"  {k}: {v}")
        
        return result


# ==============================================================================
# MAIN
# ==============================================================================
def load_data() -> pd.DataFrame:
    # Hardcoded path kaldÄ±rÄ±ldÄ±
    return None


def run_genetic_optimization():
    """Ana fonksiyon"""
    df = load_data()
    
    config = GeneticConfig(
        population_size=50,
        generations=30,
        elite_ratio=0.1,
        crossover_rate=0.8,
        mutation_rate=0.15,
        tournament_size=5,
        early_stop_generations=8
    )
    
    optimizer = GeneticOptimizer(df, config)
    result = optimizer.run(verbose=True)
    
    # SonuÃ§larÄ± kaydet
    result_df = pd.DataFrame([{
        **result['best_params'],
        **result['best_result']
    }])
    
    os.makedirs("d:/Projects/IdealQuant/results", exist_ok=True)
    result_df.to_csv("d:/Projects/IdealQuant/results/genetic_optimizer_result.csv", index=False)
    print("\nSonuc kaydedildi: results/genetic_optimizer_result.csv")
    
    return result


if __name__ == "__main__":
    try:
        run_genetic_optimization()
    except KeyboardInterrupt:
        print("\nIptal edildi.")
