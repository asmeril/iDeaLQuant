# -*- coding: utf-8 -*-
"""
Hybrid Group Optimizer v1.1
===========================
Hibrit yaklaşım: Önce grupları bağımsız optimize et, sonra kombine et.
"""

import sys
import os
import numpy as np
import pandas as pd
from time import time
from multiprocessing import Pool, cpu_count
from dataclasses import dataclass, field
from typing import List, Dict, Any, Optional, Tuple
from itertools import product

sys.path.insert(0, os.path.abspath(os.path.join(os.path.dirname(__file__), '..', '..')))

from src.indicators.core import EMA, ATR, ADX, SMA, ARS, NetLot, MACDV, Momentum, HHV, LLV
from src.indicators.trend import TOMA
from src.indicators.oscillators import TRIX
from src.strategies.score_based import ScoreBasedStrategy
from src.strategies.ars_trend_v2 import ARSTrendStrategyV2
from src.strategies.paradise_strategy import ParadiseStrategy
from src.strategies.tott_hott_strategy import TOTT_HOTTStrategy
from src.optimization.fitness import quick_fitness, calculate_sharpe
from src.strategies.holidays import vade_sonu_is_gunu
from src.optimization.strategy7_optimizer import fast_backtest_strategy7, DeepScalpCache
from src.optimization.strategy8_optimizer import (
    fast_backtest_strategy8, precompute_wilder_rsi,
    precompute_atr_wilder, precompute_sma_shifted
)

# Opsiyonel: Veritabanı entegrasyonu
try:
    from src.core.database import db
    DB_AVAILABLE = True
except ImportError:
    DB_AVAILABLE = False
    db = None

# ==============================================================================
# SATELLITE-DRONE HELPER FUNCTIONS
# ==============================================================================

# Parametre tipi tanımları: (min_range, max_range, satellite_step, drone_step)
PARAM_TYPE_CONFIG = {
    'period_short': (1, 15, 2, 1),      # ars_period, macdv_signal
    'period_medium': (15, 50, 5, 2),    # adx_period, bb_period
    'period_long': (50, 200, 10, 5),    # bb_avg_period
    'k_factor': (0.001, 0.1, 0.005, 0.001),  # ars_k, ars_atr_mult
    'threshold_int': (1, 10, 1, 1),     # min_score, exit_score
    'threshold_float': (10.0, 50.0, 5.0, 1.0),  # adx_threshold, netlot_threshold
    'multiplier': (0.5, 3.0, 0.5, 0.1),  # bb_std, atr_sl_mult
    'threshold_momentum': (50.0, 200.0, 10.0, 5.0),   # Momentum scale (0-200 arası)
    'momentum_band': (90.0, 110.0, 1.0, 0.5),          # Momentum bant (mom_alt, mom_ust)
    'multiplier_wide': (1.0, 10.0, 1.0, 0.25),         # Geniş çarpanlar (TP mult gibi)
    'period_short_wide': (5, 20, 2, 1),                 # Kısa-orta arası periyotlar
    'ott_percent': (0.2, 9.0, 1.0, 0.5),                # OTT yüzdeleri
    'ott_mult': (0.0005, 0.0020, 0.0003, 0.0001),       # Bölge çarpanı
    'vol_ratio': (0.1, 2.0, 0.2, 0.1),                  # Hacim oranı
    'st_factor': (0.5, 5.0, 0.5, 0.1),                  # SuperTrend çarpanı
}

# Hangi parametrenin hangi tipte olduğunu belirler
PARAM_TYPES = {
    # Strategy 7 specific
    'ars_k': 'k_factor',
    'atr_stop_mult_long': 'multiplier',
    'atr_stop_mult_short': 'multiplier',
    'kar_al_yuzde_long': 'threshold_float',
    'kar_al_yuzde_short': 'threshold_float',
    'hhv_period': 'period_short',
    'llv_period': 'period_short',
    'vol_ratio': 'vol_ratio',
    'st_factor': 'st_factor',
    'ema_fast_period': 'period_short',
    'ema_slow_period': 'period_medium',
    'mfi_hhv_period': 'period_short',
    'mfi_llv_period': 'period_short',
    'toma_period2': 'multiplier',
    'mfi_long': 'threshold_float',
    'mfi_short': 'threshold_float',
    'min_hold_bars': 'threshold_int',
    'max_hold_bars': 'period_medium',
    'cooldown_bars': 'threshold_int',
    # Strateji 1
    'ars_period': 'period_short', 'ars_k': 'k_factor',
    'adx_period': 'period_medium', 'adx_threshold': 'threshold_float',
    'macdv_short': 'period_short', 'macdv_long': 'period_medium', 'macdv_signal': 'period_short', 'macdv_threshold': 'multiplier',
    'netlot_period': 'period_short', 'netlot_threshold': 'threshold_float',
    'bb_period': 'period_medium', 'bb_std': 'multiplier', 'bb_avg_period': 'period_long', 'bb_width_multiplier': 'multiplier',
    'ars_mesafe_threshold': 'k_factor', 'yatay_ars_bars': 'period_short', 'yatay_adx_threshold': 'threshold_float',
    'filter_score_threshold': 'threshold_int', 'min_score': 'threshold_int', 'exit_score': 'threshold_int',
    'contrary_score_max': 'threshold_int',
    # Strateji 2
    'ars_ema_period': 'period_short', 'ars_atr_period': 'period_short', 'ars_atr_mult': 'multiplier',
    'ars_min_band': 'k_factor', 'ars_max_band': 'k_factor',
    'momentum_period': 'period_short', 'momentum_threshold': 'threshold_momentum', 'breakout_period': 'period_short_wide',
    'mfi_period': 'period_medium', 'mfi_hhv_period': 'period_medium', 'mfi_llv_period': 'period_medium', 'volume_hhv_period': 'period_medium',
    'atr_exit_period': 'period_medium', 'atr_sl_mult': 'multiplier', 'atr_tp_mult': 'multiplier_wide', 'atr_trail_mult': 'multiplier',
    'exit_confirm_bars': 'threshold_int', 'exit_confirm_mult': 'multiplier', 'volume_mult': 'multiplier', 'volume_llv_period': 'period_medium',
    # Strateji 3 (Paradise)
    'ema_period': 'period_medium', 'dsma_period': 'period_long', 'ma_period': 'period_medium',
    'hh_period': 'period_medium', 'vol_hhv_period': 'period_medium',
    'mom_period': 'period_long', 'mom_alt': 'momentum_band', 'mom_ust': 'momentum_band',
    'atr_period': 'period_medium', 'atr_sl': 'multiplier', 'atr_tp': 'multiplier_wide', 'atr_trail': 'multiplier',
    # Strateji 5 (Oliver Kell)
    'ema_fast': 'period_short_wide', 'ema_slow': 'period_medium',
    'breakout_period': 'period_short_wide', 'adx_period': 'period_medium',
    'adx_threshold': 'threshold_float', 'vol_ma_period': 'period_medium',
    'trailing_stop_pct': 'multiplier',
    # Strateji 6 (TOTT_HOTT)
    'ott_period': 'period_medium', 'ott_pct_big': 'ott_percent',
    'ott_pct_small': 'ott_percent', 'ott_mult': 'ott_mult',
    'sott_pct': 'ott_percent', 'gate_period': 'period_medium',
    'gate_pct': 'ott_percent',
}

def get_step(param_name: str, stage: str = 'satellite', user_step: float = None) -> float:
    """Parametre için Satellite veya Drone adım boyutunu döndürür."""
    param_type = PARAM_TYPES.get(param_name, 'period_medium')
    config = PARAM_TYPE_CONFIG.get(param_type, (1, 100, 5, 1))
    
    # Satellite: En az config'deki kadar veya kullanıcı adımı kadar geniş
    if stage == 'satellite':
        base_step = config[2]
        if user_step is not None:
            return max(base_step, user_step)
        return base_step
    
    # Drone: Config'deki drone adımını kullan, ama kullanıcı adımından küçük olmasın
    # Bu şekilde period_short=1, period_medium=2, period_long=5 farklılıkları korunur
    else:
        drone_base = config[3]  # Parametre tipine göre uygun ince adım
        if user_step is not None:
            # Kullanıcı adımının yarısını taban al, ama config'den küçük olmasın
            return max(drone_base, user_step / 2.0)
        return drone_base





def generate_range(min_val: float, max_val: float, step: float, is_int: bool = False) -> List:
    """Belirli aralık ve adım için değer listesi üretir."""
    if step <= 0: step = 1
    result = []
    current = min_val
    while current <= max_val + (step * 0.01):  # Floating point tolerance
        result.append(int(round(current)) if is_int else round(current, 4))
        current += step
    return result if result else [min_val]

def find_cluster_range(results: List[Dict], param_name: str, original_step: float, original_min: float, original_max: float) -> Tuple[float, float]:
    """
    Kümeleme tabanlı aralık daralması.
    "İyi" sonuçların kümelendiği bölgeyi tespit eder ve 
    o bölgenin min-1adım / max+1adım'ını döndürür.
    """
    if not results: return (original_min, original_max)
    
    # Fitness ortalaması ve standart sapması
    fitnesses = [r.get('fitness', r.get('net_profit', 0)) for r in results]
    if not fitnesses: return (original_min, original_max)
    
    mean_fit = sum(fitnesses) / len(fitnesses)
    variance = sum((f - mean_fit) ** 2 for f in fitnesses) / len(fitnesses)
    std_fit = variance ** 0.5 if variance > 0 else 0
    
    # Eşik: Ortalama + (Std / 2)
    threshold = mean_fit + (std_fit / 2) if std_fit > 0 else mean_fit * 0.8
    
    # "İyi" sonuçları filtrele
    good_results = [r for r, f in zip(results, fitnesses) if f >= threshold]
    if not good_results: good_results = results[:max(1, len(results) // 5)]  # Top %20
    
    # Bu parametre için değerleri topla
    param_values = [r.get(param_name) for r in good_results if param_name in r]
    if not param_values: return (original_min, original_max)
    
    cluster_min = min(param_values)
    cluster_max = max(param_values)
    
    # Bir adım genişlet (boundary'leri kaçırmamak için)
    new_min = max(original_min, cluster_min - original_step)
    new_max = min(original_max, cluster_max + original_step)
    
    return (new_min, new_max)


# ==============================================================================
# GROUP DEFINITIONS
# ==============================================================================
@dataclass
class ParameterGroup:
    """Parametre grubu tanımı"""
    name: str
    params: Dict[str, List[Any]]  # param_name -> [values]
    is_independent: bool = True   # Bağımsız mı, kademeli mi
    default_values: Dict[str, Any] = field(default_factory=dict)  # Diğer gruplar için varsayılanlar

# Strateji 1 Grup Tanımları
STRATEGY1_GROUPS = [
    ParameterGroup(
        name="ARS",
        params={'ars_period': [3, 4, 5, 8, 10, 12], 'ars_k': [0.005, 0.008, 0.01, 0.012, 0.015, 0.02]},
        is_independent=True,
        default_values={'ars_period': 3, 'ars_k': 0.01}
    ),
    ParameterGroup(
        name="ADX",
        params={'adx_period': [14, 17, 21, 25, 30], 'adx_threshold': [20.0, 25.0, 30.0]},
        is_independent=True,
        default_values={'adx_period': 17, 'adx_threshold': 25.0}
    ),
    ParameterGroup(
        name="MACDV",
        params={'macdv_short': [10, 13, 15], 'macdv_long': [24, 28, 32], 'macdv_signal': [7, 8, 9], 'macdv_threshold': [0.0, 0.5, 1.0, 2.0, 3.0, 5.0]},
        is_independent=True,
        default_values={'macdv_short': 13, 'macdv_long': 28, 'macdv_signal': 8, 'macdv_threshold': 0.0}
    ),

    ParameterGroup(
        name="NetLot",
        params={'netlot_period': [3, 5, 8], 'netlot_threshold': [10, 20, 30, 40]},
        is_independent=True,
        default_values={'netlot_period': 5, 'netlot_threshold': 20.0}
    ),
    ParameterGroup(
        name="Yatay_BB",
        params={
            'bb_period': [15, 20, 25], 'bb_std': [1.5, 2.0, 2.5],
            'bb_width_multiplier': [0.6, 0.8, 1.0], 'bb_avg_period': [30, 50, 70],
        },
        is_independent=True,
        default_values={
            'bb_period': 20, 'bb_std': 2.0,
            'bb_width_multiplier': 0.8, 'bb_avg_period': 50
        }
    ),
    ParameterGroup(
        name="Skor_Ayarlari",
        params={'min_score': [2, 3, 4], 'exit_score': [2, 3, 4], 'contrary_score_max': [1, 2, 3]},
        is_independent=True,
        default_values={'min_score': 3, 'exit_score': 3, 'contrary_score_max': 2}
    ),
    ParameterGroup(
        name="Yatay_Onay",
        params={
            'ars_mesafe_threshold': [0.20, 0.25, 0.30], 'yatay_ars_bars': [5, 10, 15],
            'yatay_adx_threshold': [15.0, 20.0, 25.0], 'filter_score_threshold': [1, 2, 3],
        },
        is_independent=False,
        default_values={
            'ars_mesafe_threshold': 0.25, 'yatay_ars_bars': 10,
            'yatay_adx_threshold': 20.0, 'filter_score_threshold': 2
        }
    ),
]

# Strateji 1 Grup Tanimlari — 1 dk (Teorik default degerler, coarse scan icin)
# NOT: Actual ranges _run_hybrid icinde UI param_ranges'den sync edilir.
# Bu listedeki 'params' degerleri, **diger gruplar sabitken** kullanilan coarse scan noktalaridir.
STRATEGY1_GROUPS_1DK = [
    ParameterGroup(
        name="ARS",
        params={'ars_period': [3, 5, 7, 10], 'ars_k': [0.010, 0.020, 0.040, 0.060, 0.080]},
        is_independent=True,
        default_values={'ars_period': 5, 'ars_k': 0.020}
    ),
    ParameterGroup(
        name="ADX",
        params={'adx_period': [10, 12, 14, 18, 22, 26, 30], 'adx_threshold': [20.0, 25.0, 30.0]},
        is_independent=True,
        default_values={'adx_period': 14, 'adx_threshold': 25.0}
    ),
    ParameterGroup(
        name="MACDV",
        params={'macdv_short': [8, 9, 11, 13], 'macdv_long': [18, 21, 24, 28], 'macdv_signal': [5, 6, 7, 9], 'macdv_threshold': [0.0, 1.0, 2.0, 3.0, 5.0]},
        is_independent=True,
        default_values={'macdv_short': 9, 'macdv_long': 21, 'macdv_signal': 6, 'macdv_threshold': 0.0}
    ),
    ParameterGroup(
        name="NetLot",
        params={'netlot_period': [5, 8, 10, 12, 15], 'netlot_threshold': [10, 20, 30, 40]},
        is_independent=True,
        default_values={'netlot_period': 8, 'netlot_threshold': 20.0}
    ),
    ParameterGroup(
        name="Yatay_BB",
        params={
            'bb_period': [15, 20, 25], 'bb_std': [1.5, 2.0, 2.5],
            'bb_width_multiplier': [0.6, 0.8, 1.0], 'bb_avg_period': [30, 50, 70],
        },
        is_independent=True,
        default_values={
            'bb_period': 20, 'bb_std': 2.0,
            'bb_width_multiplier': 0.8, 'bb_avg_period': 50
        }
    ),
    ParameterGroup(
        name="Skor_Ayarlari",
        params={'min_score': [2, 3, 4], 'exit_score': [2, 3, 4], 'contrary_score_max': [1, 2, 3]},
        is_independent=True,
        default_values={'min_score': 3, 'exit_score': 3, 'contrary_score_max': 2}
    ),
    ParameterGroup(
        name="Yatay_Onay",
        params={
            'ars_mesafe_threshold': [0.05, 0.10, 0.15, 0.20, 0.30], 'yatay_ars_bars': [3, 5, 7, 10],
            'yatay_adx_threshold': [15.0, 20.0, 25.0], 'filter_score_threshold': [1, 2, 3],
        },
        is_independent=False,
        default_values={
            'ars_mesafe_threshold': 0.15, 'yatay_ars_bars': 5,
            'yatay_adx_threshold': 20.0, 'filter_score_threshold': 2
        }
    ),
]

# Strateji 2 Grup Tanımları
STRATEGY2_GROUPS = [
    ParameterGroup(
        name="ARS",
        params={
            'ars_ema_period': [2, 3, 5, 8], 'ars_atr_period': [7, 10, 14], 'ars_atr_mult': [0.5, 0.8, 1.0],
            'ars_min_band': [0.002, 0.003], 'ars_max_band': [0.015, 0.020],
        },
        is_independent=True,
        default_values={'ars_ema_period': 3, 'ars_atr_period': 10, 'ars_atr_mult': 0.5, 'ars_min_band': 0.002, 'ars_max_band': 0.015}
    ),
    ParameterGroup(
        name="Giris_Momentum",
        params={
            'momentum_period': [5, 7, 10],
            'momentum_threshold': [90.0, 100.0, 120.0, 150.0],
            # momentum_base sabit 200.0 - optimize edilmemeli (Short sinyallerini bozar)
            'breakout_period': [8, 10, 15],
        },
        is_independent=True,
        default_values={
            'momentum_period': 5, 'momentum_threshold': 100.0,
            'breakout_period': 10,
        }
    ),
    ParameterGroup(
        name="Giris_MFI_Volume",
        params={
            'mfi_period': [10, 14, 17],
            'mfi_hhv_period': [10, 14, 20],
            'mfi_llv_period': [10, 14, 20],
            'volume_hhv_period': [10, 14, 20],
        },
        is_independent=True,
        default_values={
            'mfi_period': 14, 'mfi_hhv_period': 14,
            'mfi_llv_period': 14, 'volume_hhv_period': 14
        }
    ),
    ParameterGroup(
        name="Cikis_Risk",
        params={
            'atr_exit_period': [14, 17],
            'atr_sl_mult': [1.5, 2.0, 2.5],
            'atr_tp_mult': [3.0, 4.0, 5.0, 6.0],
            'atr_trail_mult': [1.5, 2.0, 3.0],
            'exit_confirm_bars': [2, 3],
            'exit_confirm_mult': [0.75, 1.0, 1.25],
        },
        is_independent=True,
        default_values={
            'atr_exit_period': 14, 'atr_sl_mult': 2.0, 'atr_tp_mult': 5.0,
            'atr_trail_mult': 2.0, 'exit_confirm_bars': 2, 'exit_confirm_mult': 1.0
        }
    ),
    ParameterGroup(
        name="Ince_Ayar",
        params={'volume_mult': [0.6, 0.8, 1.0], 'volume_llv_period': [14, 17]},
        is_independent=False,
        default_values={'volume_mult': 0.8, 'volume_llv_period': 14}
    ),
]

# Strateji 3 (Paradise) Grup Tanimlari
STRATEGY3_GROUPS = [
    ParameterGroup(
        name="Trend",
        params={
            'ema_period': [5, 8, 10, 13, 15, 18, 21, 25, 30, 40, 50, 60, 80],
            'dsma_period': [15, 20, 30, 40, 50, 60, 70, 80, 100, 120, 150],
            'ma_period': [5, 8, 10, 13, 15, 18, 20, 25, 30, 40, 50, 60, 80],
        },
        is_independent=True,
        default_values={'ema_period': 21, 'dsma_period': 50, 'ma_period': 20}
    ),
    ParameterGroup(
        name="Breakout",
        params={
            'hh_period': [5, 8, 10, 13, 15, 18, 20, 25, 30, 35, 40, 50, 60, 80],
            'vol_hhv_period': [5, 8, 10, 14, 18, 20, 25, 30, 40, 50],
        },
        is_independent=True,
        default_values={'hh_period': 25, 'vol_hhv_period': 14}
    ),
    ParameterGroup(
        name="Momentum",
        params={
            'mom_period': [10, 15, 20, 30, 40, 50, 60, 80, 100, 120, 150],
            'mom_alt': [90.0, 91.0, 92.0, 93.0, 94.0, 95.0, 96.0, 97.0, 98.0, 99.0, 99.5],
            'mom_ust': [100.5, 101.0, 102.0, 103.0, 104.0, 105.0, 106.0, 107.0, 108.0, 109.0, 110.0],
        },
        is_independent=True,
        default_values={'mom_period': 60, 'mom_alt': 98.0, 'mom_ust': 102.0}
    ),
    ParameterGroup(
        name="Risk",
        params={
            'atr_period': [5, 7, 10, 14, 18, 20, 25, 30],
            'atr_sl': [0.5, 0.75, 1.0, 1.25, 1.5, 2.0, 2.5, 3.0, 3.5, 4.0, 5.0],
            'atr_tp': [1.0, 1.5, 2.0, 2.5, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 10.0],
            'atr_trail': [0.5, 0.75, 1.0, 1.5, 2.0, 2.5, 3.0, 3.5, 4.0, 5.0, 6.0],
        },
        is_independent=False,
        default_values={'atr_period': 14, 'atr_sl': 2.0, 'atr_tp': 4.0, 'atr_trail': 2.5}
    ),
]

# Strateji 5 (Oliver Kell) Grup Tanimlari
# Trend + Chop Filter birlikte optimize edilir (birbirine bagimli)
STRATEGY5_GROUPS = [
    ParameterGroup(
        name="Yapisal",
        params={
            'ema_fast': [5, 7, 8, 10, 12, 15, 18, 20],
            'ema_slow': [10, 15, 18, 20, 25, 30, 35, 40, 50],
            'breakout_period': [5, 7, 10, 12, 15, 18, 20, 25, 30],
            'adx_period': [7, 10, 12, 14, 18, 20, 25, 30],
            'adx_threshold': [10.0, 15.0, 18.0, 20.0, 22.0, 25.0, 28.0, 30.0, 35.0],
            'vol_ma_period': [5, 10, 15, 20, 25, 30, 35, 40],
        },
        is_independent=True,
        default_values={
            'ema_fast': 10, 'ema_slow': 20, 'breakout_period': 10,
            'adx_period': 14, 'adx_threshold': 20.0, 'vol_ma_period': 20
        }
    ),
    ParameterGroup(
        name="Risk",
        params={
            'trailing_stop_pct': [0.5, 0.75, 1.0, 1.25, 1.5, 1.75, 2.0, 2.5, 3.0, 3.5, 4.0, 5.0],
        },
        is_independent=False,
        default_values={'trailing_stop_pct': 1.5}
    ),
]

# Strateji 6 (TOTT_HOTT) Grup Tanimlari
STRATEGY6_GROUPS = [
    ParameterGroup(
        name="Trend",
        params={
            'ott_period': [20, 25, 30, 35, 40, 50],
            'ott_pct_big': [6.0, 6.5, 7.0, 7.5, 8.0, 8.5, 9.0],
            'ott_pct_small': [2.8, 3.0, 3.2, 3.4, 3.6, 3.8, 4.0],
        },
        is_independent=True,
        default_values={'ott_period': 30, 'ott_pct_big': 7.0, 'ott_pct_small': 3.5}
    ),
    ParameterGroup(
        name="Bolge",
        params={
            'ott_mult': [0.0005, 0.0008, 0.0011],
            'sott_pct': [0.2, 0.3, 0.4],
        },
        is_independent=True,
        default_values={'ott_mult': 0.0008, 'sott_pct': 0.3}
    ),
    ParameterGroup(
        name="Kapi",
        params={
            'gate_period': [10, 16, 22, 28, 34],
            'gate_pct': [0.4, 0.5, 0.6],
        },
        is_independent=False,
        default_values={'gate_period': 20, 'gate_pct': 0.5}
    ),
]

# Strateji 7 (DeepScalp v1.2) Grup Tanimlari
# Satellite scan degerleri: Coarse aramada kullanilir, Drone fazinda UI aralik/adim degerlerine donerek darin tarar
# Ref: reference/Optimizasyon_DeepScalp_Rehberi.txt, S4 TOMA tutarliligi
STRATEGY7_GROUPS = [
    ParameterGroup(
        name="Regime_Layer1",
        params={
            'ars_k': [0.8, 1.0, 1.2, 1.4, 1.6, 1.8, 2.0],
            'hhv_period': [6, 8, 10, 12, 16, 20],
            'llv_period': [6, 8, 10, 12, 16, 20],
            'vol_ratio': [0.5, 0.7, 0.8, 1.0, 1.2],
        },
        is_independent=True,
        default_values={'ars_k': 1.23, 'hhv_period': 12, 'llv_period': 12, 'vol_ratio': 0.8}
    ),
    ParameterGroup(
        name="Trend_Layer2",
        params={
            'st_factor': [2.0, 2.5, 3.0, 3.5, 4.0],
            'ema_fast_period': [5, 7, 9, 11, 13, 15],
            'ema_slow_period': [15, 18, 21, 24, 27, 30],
        },
        is_independent=True,
        default_values={'st_factor': 3.0, 'ema_fast_period': 9, 'ema_slow_period': 21}
    ),
    ParameterGroup(
        name="Timing_Layer3",
        params={
            'toma_period2': [0.5, 0.8, 1.0, 1.3, 1.5, 1.8, 2.1, 2.5, 3.0],
            'mfi_period': [10, 14, 18],
            'mfi_hhv_period': [3, 5, 7, 9],
            'mfi_llv_period': [3, 5, 7, 9],
            'mfi_long': [45.0, 50.0, 55.0, 60.0, 65.0],
            'mfi_short': [35.0, 40.0, 45.0, 50.0, 55.0],
        },
        is_independent=True,
        default_values={
            'toma_period2': 2.1, 'mfi_period': 14,
            'mfi_hhv_period': 5, 'mfi_llv_period': 5,
            'mfi_long': 55.0, 'mfi_short': 45.0
        }
    ),
    ParameterGroup(
        name="Risk_Time_Layer4_5",
        params={
            'atr_stop_mult_long': [1.0, 1.25, 1.5, 1.75, 2.0, 2.25, 2.5],
            'atr_stop_mult_short': [1.0, 1.25, 1.5, 1.75, 2.0, 2.25, 2.5],
            'kar_al_yuzde_long': [1.0, 1.5, 2.0, 2.5, 3.0, 3.5, 4.0],
            'kar_al_yuzde_short': [1.0, 1.5, 2.0, 2.5, 3.0, 3.5, 4.0],
            'min_hold_bars': [1, 2, 3, 4],
            'max_hold_bars': [8, 12, 16, 20, 25, 30],
            'cooldown_bars': [1, 2, 3, 4],
        },
        is_independent=False,
        default_values={
            'atr_stop_mult_long': 1.5, 'atr_stop_mult_short': 1.5,
            'kar_al_yuzde_long': 2.0, 'kar_al_yuzde_short': 2.0,
            'min_hold_bars': 2, 'max_hold_bars': 20, 'cooldown_bars': 2
        }
    ),
]

STRATEGY8_GROUPS = [
    ParameterGroup(
        name="Gap_Filter_L1",
        params={
            'min_gap_pct': [0.01, 0.03, 0.05, 0.08, 0.10, 0.15, 0.20],
            'max_gap_pct': [0.5, 1.0, 1.5, 2.0, 2.5, 3.0],
        },
        is_independent=True,
        default_values={'min_gap_pct': 0.05, 'max_gap_pct': 2.0}
    ),
    ParameterGroup(
        name="OpeningRange_L2",
        params={
            'or_bars': [5, 10, 15, 20, 25, 30],
        },
        is_independent=True,
        default_values={'or_bars': 15}
    ),
    ParameterGroup(
        name="RSI_Hacim_L3",
        params={
            'rsi_period':      [3, 5, 7, 9, 11, 14],
            'rsi_ob':          [55.0, 60.0, 62.0, 65.0, 70.0],
            'rsi_os':          [30.0, 35.0, 38.0, 40.0, 45.0],
            'hacim_ma_period': [10, 15, 20, 25, 30],
            'hacim_oran':      [0.3, 0.5, 0.7, 0.8, 1.0, 1.2],
        },
        is_independent=True,
        default_values={
            'rsi_period': 5, 'rsi_ob': 62.0, 'rsi_os': 38.0,
            'hacim_ma_period': 20, 'hacim_oran': 0.8
        }
    ),
    ParameterGroup(
        name="Risk_Timing_L4",
        params={
            'atr_period':      [7, 10, 13, 16, 19],
            'atr_stop_mult':   [0.2, 0.35, 0.5, 0.75, 1.0, 1.25, 1.5, 2.0],
            'gap_window_bars': [60, 90, 120, 150, 180, 210, 270, 360],
            'cooldown_bars':   [1, 2, 3, 4, 5, 6],
        },
        is_independent=False,
        default_values={
            'atr_period': 14, 'atr_stop_mult': 0.5,
            'gap_window_bars': 210, 'cooldown_bars': 3
        }
    ),
]

# ==============================================================================
# DATA & CACHE
# ==============================================================================
g_cache = None
g_mask = None  # Trading mask (vade/tatil filtresi) — _init_group_pool'da doldurulur

def load_data() -> pd.DataFrame:
    # Hardcoded path kaldırıldı.
    return None

class IndicatorCache:
    """
    Turbo Indicator Cache - Tüm indikatörleri önbelleğe alır.
    Her işlemci çekirdeği başına bir tane oluşturulur.
    Aynı parametrelerle çağrılan indikatörler cache'den döner (hesaplama yapılmaz).
    """
    def __init__(self, df):
        self.df = df
        
        # Sütunları güvenli şekilde al (önce standart, yoksa Türkçe)
        open_col = 'open' if 'open' in df.columns else 'Acilis'
        high_col = 'high' if 'high' in df.columns else 'Yuksek'
        low_col = 'low' if 'low' in df.columns else 'Dusuk'
        close_col = 'close' if 'close' in df.columns else 'Kapanis'
        vol_col = 'volume' if 'volume' in df.columns else ('Lot' if 'Lot' in df.columns else 'Hacim')
        
        self.opens = df[open_col].values.flatten()
        self.closes = df[close_col].values.flatten()
        self.highs = df[high_col].values.flatten()
        self.lows = df[low_col].values.flatten()
        
        # Typical price
        if 'Tipik' in df.columns:
            self.typical = df['Tipik'].values.flatten()
        else:
            self.typical = ((self.highs + self.lows + self.closes) / 3.0)
            
        self.lots = df[vol_col].values.flatten()
        self.volumes = df[vol_col].values.flatten()
        self.n = len(self.closes)
        
        # Datetime
        dt_col = 'datetime' if 'datetime' in df.columns else 'DateTime'
        if dt_col in df.columns:
            self.times = df[dt_col].tolist()
        else:
            self.times = [None] * self.n
            
        self.dates = self.times
        self._cache = {}
    
    def _get(self, key: str, calc_fn):
        """Generic cache getter"""
        if key not in self._cache:
            self._cache[key] = calc_fn()
        return self._cache[key]

    # === ARS ===
    def get_ars(self, period: int, k: float) -> np.ndarray:
        key = f'ars_{period}_{k:.4f}'
        return self._get(key, lambda: np.array(ARS(self.typical.tolist(), int(period), float(k))))

    # === ADX ===
    def get_adx(self, period: int) -> np.ndarray:
        key = f'adx_{period}'
        return self._get(key, lambda: np.array(ADX(self.highs.tolist(), self.lows.tolist(), self.closes.tolist(), int(period))))

    # === MACDV ===
    def get_macdv(self, short: int, long: int, signal: int) -> Tuple[np.ndarray, np.ndarray]:
        key = f'macdv_{short}_{long}_{signal}'
        def calc():
            m, s = MACDV(self.closes.tolist(), self.highs.tolist(), self.lows.tolist(), int(short), int(long), int(signal))
            return (np.array(m), np.array(s))
        return self._get(key, calc)

    # === NetLot ===
    def get_netlot(self, period: int = 5) -> Tuple[np.ndarray, np.ndarray]:
        key = f'netlot_{period}'
        def calc():
            nl = np.array(NetLot(self.opens.tolist(), self.highs.tolist(), self.lows.tolist(), self.closes.tolist()))
            nl_ma = pd.Series(nl).rolling(int(period)).mean().fillna(0).values
            return (nl, nl_ma)
        return self._get(key, calc)

    # === EMA ===
    def get_ema(self, period: int) -> np.ndarray:
        key = f'ema_{period}'
        return self._get(key, lambda: np.array(EMA(self.typical.tolist(), int(period))))

    # === ATR ===
    def get_atr(self, period: int) -> np.ndarray:
        key = f'atr_{period}'
        return self._get(key, lambda: np.array(ATR(self.highs.tolist(), self.lows.tolist(), self.closes.tolist(), int(period))))

    # === SMA ===
    def get_sma(self, period: int) -> np.ndarray:
        key = f'sma_{period}'
        return self._get(key, lambda: pd.Series(self.closes).rolling(int(period)).mean().fillna(0).values)

    # === Bollinger Bands ===
    def get_bb(self, period: int, std_mult: float) -> Tuple[np.ndarray, np.ndarray, np.ndarray]:
        key = f'bb_{period}_{std_mult:.1f}'
        def calc():
            sma = pd.Series(self.closes).rolling(int(period)).mean()
            std = pd.Series(self.closes).rolling(int(period)).std()
            upper = (sma + std_mult * std).fillna(0).values
            lower = (sma - std_mult * std).fillna(0).values
            width = np.where(sma != 0, ((upper - lower) / sma) * 100, 0)
            return (upper, lower, width)
        return self._get(key, calc)

    # === BB Width Avg ===
    def get_bb_width_avg(self, bb_period: int, bb_std: float, avg_period: int) -> np.ndarray:
        key = f'bb_width_avg_{bb_period}_{bb_std:.1f}_{avg_period}'
        def calc():
            _, _, width = self.get_bb(bb_period, bb_std)
            return pd.Series(width).rolling(int(avg_period)).mean().fillna(0).values
        return self._get(key, calc)

    # === Paradise Indicator Metodlari ===
    
    # === DSMA (Double SMA) ===
    def get_dsma(self, period: int) -> np.ndarray:
        key = f'dsma_{period}'
        def calc():
            inner = self.get_sma(period)
            return pd.Series(inner).rolling(int(period)).mean().fillna(0).values
        return self._get(key, calc)

    # === Momentum ===
    def get_momentum(self, period: int) -> np.ndarray:
        key = f'mom_{period}'
        return self._get(key, lambda: np.array(Momentum(self.closes.tolist(), int(period))))

    # === HHV ===
    def get_hhv(self, period: int) -> np.ndarray:
        key = f'hhv_{period}'
        return self._get(key, lambda: np.array(HHV(self.highs.tolist(), int(period))))

    # === LLV ===
    def get_llv(self, period: int) -> np.ndarray:
        key = f'llv_{period}'
        return self._get(key, lambda: np.array(LLV(self.lows.tolist(), int(period))))

    # === TRIX ===
    def get_trix(self, period: int) -> np.ndarray:
        key = f'trix_{period}'
        return self._get(key, lambda: np.array(TRIX(self.closes.tolist(), int(period))))

    # === TOMA ===
    def get_toma(self, period: int, opt: float) -> Tuple[np.ndarray, np.ndarray]:
        key = f'toma_{period}_{opt:.2f}'
        def calc():
            toma_val, trend = TOMA(self.closes.tolist(), int(period), float(opt))
            return (np.array(toma_val), np.array(trend))
        return self._get(key, calc)

    # === DeepScalp (S7) Indicators ===
    def get_st(self, factor: float, hh_p: int, atr_p: int) -> np.ndarray:
        key = f'st_{factor:.1f}_{hh_p}_{atr_p}'
        from src.indicators.trend import get_supertrend
        # FIX: get_supertrend imzası (highs, lows, closes, hhv_p, atr_p, factor)
        #      Sadece ST değerini döndür (tuple[0]), upper/lower gereksiz
        return self._get(key, lambda: np.array(get_supertrend(self.highs, self.lows, self.closes, hh_p, atr_p, factor)[0]))

    def get_mfi(self, period: int) -> np.ndarray:
        key = f'mfi_{period}'
        from src.indicators.core import get_mfi
        return self._get(key, lambda: get_mfi(self.highs, self.lows, self.closes, self.volumes, period))

    # === Volume HHV ===
    def get_vol_hhv(self, period: int) -> np.ndarray:
        key = f'vol_hhv_{period}'
        # HHV fonksiyonu list bekler, volumes array'ini list'e cevir
        return self._get(key, lambda: np.array(HHV(self.volumes.tolist(), int(period))))

    # === Volume SMA (S5 Oliver Kell icin) ===
    def get_vol_ma(self, period: int) -> np.ndarray:
        key = f'vol_ma_{period}'
        def calc():
            n = len(self.volumes)
            vol_ma = np.zeros(n, dtype=np.float64)
            for i in range(period - 1, n):
                s = 0.0
                for j in range(period):
                    s += self.volumes[i - j]
                vol_ma[i] = s / period
            return vol_ma
        return self._get(key, calc)

    # === Vade Tarihleri ===
    def get_vade_dates(self, vade_tipi: str) -> set:
        key = f'vade_dates_{vade_tipi}'
        def calc():
            vade_dates = set()
            # self.times datetime objeleri listesi olarak varsayilir (IndicatorCache.__init__ df['DateTime'].tolist() yapiyor)
            # Guvenlik icin pd.to_datetime kullanabiliriz ama maliyetli olabilir. 
            # Eger df['DateTime'] zaten datetimelike ise gerek yok.
            # Ancak process safe olmasi icin array'i Series'e cevirip dt accessor kullanmak en iyisi.
            dates = pd.to_datetime(self.times, dayfirst=True)
            months = dates.to_period('M').unique()
            
            for m in months:
                if "ENDEKS" in vade_tipi.upper() and m.month % 2 != 0:
                    continue
                month_date = m.to_timestamp().date()
                vade_gunu = vade_sonu_is_gunu(month_date, vade_tipi)
                vade_dates.add(vade_gunu)
            return vade_dates
        return self._get(key, calc)

    def get_vade_transitions(self, vade_tipi: str) -> set:
        key = f'vade_trans_{vade_tipi}'
        def calc():
            transitions = set()
            dates = pd.to_datetime(self.times, dayfirst=True)
            # Vectorized approach is faster than loop
            # Pandas shift ile onceki ayi karsilastir
            months = dates.month
            # shift(1) nan getirir, fillna ile ilk ayi koru
            prev_months = pd.Series(months).shift(1).fillna(months[0])
            
            # Ay degisimi olan indeksler
            change_mask = months != prev_months
            change_indices = np.where(change_mask)[0]
            
            for i in change_indices:
                m = months[i]
                if "ENDEKS" in vade_tipi.upper() and m % 2 != 0:
                    # Tek ay ise GECIS yap (Cunku vade sonu CIFT aydadir, 
                    # tek ay basinda eski kontrat biter yeni kontrat baslar mi? 
                    # Hayir, ENDEKS kontratlari CIFT aylarda biter.
                    # Ornegin Subat(2) sonu vade biter, Mart(3) basi GECIS olur.
                    # Yani Mart(3) basinda gecis olmali. Mart tek aydir (3 % 2 == 1).
                    # Yani m % 2 == 1 ise transition ekle.
                    transitions.add(i)
                elif vade_tipi == "SPOT":
                    # Her ay gecis
                    transitions.add(i)
            return transitions
        return self._get(key, calc)



# ==============================================================================
# GLOBAL HELPERS
# ==============================================================================
def _init_group_pool(strategy_index, df_received=None, vade_tipi="ENDEKS"):
    global g_cache, g_mask, _s7_arrays, _s7_rolling_cache, _s8_arrays, _s8_rolling_cache
    if g_cache is None:
        if df_received is not None:
            g_cache = IndicatorCache(df_received)
            from src.engine.data import OHLCV
            g_mask = OHLCV(df_received).get_trading_mask(vade_tipi)
            # Yeni veri yuklendikten sonra S7 array cache'lerini sifirla
            _s7_arrays = None
            _s7_rolling_cache = {}
            # S8 cache'lerini de sifirla
            _s8_arrays = None
            _s8_rolling_cache = {}
        else:
            # GUI disi kullanimda buraya veri paslanmali.
            # Hata firlatmak sessiz basarisizliktan daha iyidir.
            print("[CRITICAL] Worker initializer received NO data!")

def _evaluate_s5_params(params: Dict[str, Any], commission: float = 0.0, slippage: float = 0.0) -> Dict[str, float]:
    """S5 Oliver Kell parametrelerini Numba kernel ile degerlendir."""
    global g_cache, _s5_arrays
    zero_result = {'net_profit': 0.0, 'trades': 0, 'pf': 0.0, 'max_dd': 0.0, 'sharpe': 0.0, 'fitness': 0.0}
    
    if g_cache is None:
        return zero_result
    
    try:
        # Lazy import: top-level'da import edilirse Windows Pool workers crash eder
        from src.optimization.strategy5_optimizer import fast_backtest_strategy5
        
        # Worker basina bir kez: sabit arrayleri hazirla ve cache'le
        # Guncelleme: Eger array boyutu degismisse (ornek: yeni tarih filtresi) cache'i yenile
        n = len(g_cache.closes)
        if '_s5_arrays' not in dir() or _s5_arrays is None or len(_s5_arrays[0]) != n:
            closes_f64 = np.ascontiguousarray(g_cache.closes, dtype=np.float64)
            highs_f64 = np.ascontiguousarray(g_cache.highs, dtype=np.float64)
            lows_f64 = np.ascontiguousarray(g_cache.lows, dtype=np.float64)
            vols_f64 = np.ascontiguousarray(g_cache.volumes, dtype=np.float64)
            mask_arr = np.array(g_mask, dtype=np.bool_)
            times_arr = np.zeros(n, dtype=np.int64)
            if hasattr(g_cache, 'times') and g_cache.times:
                try:
                    times_arr = np.array([int(t.timestamp()) for t in g_cache.times], dtype=np.int64)
                except:
                    pass
            _s5_arrays = (closes_f64, highs_f64, lows_f64, vols_f64, mask_arr, times_arr)
        
        closes_f64, highs_f64, lows_f64, vols_f64, mask_arr, times_arr = _s5_arrays
        
        ema_fast_p = int(params.get('ema_fast', 10))
        ema_slow_p = int(params.get('ema_slow', 20))
        breakout_p = int(params.get('breakout_period', 10))
        adx_p = int(params.get('adx_period', 14))
        adx_thresh = float(params.get('adx_threshold', 20.0))
        vol_ma_p = int(params.get('vol_ma_period', 20))
        trail_pct = float(params.get('trailing_stop_pct', 0))  # Diger stratejilerle tutarli: yapısal fazda kapalı, cascade'de optimize edilir
        
        # Cached indicator arrays
        ema_fast_arr = np.ascontiguousarray(g_cache.get_ema(ema_fast_p), dtype=np.float64)
        ema_slow_arr = np.ascontiguousarray(g_cache.get_ema(ema_slow_p), dtype=np.float64)
        adx_arr = np.ascontiguousarray(g_cache.get_adx(adx_p), dtype=np.float64)
        hhv_arr = np.ascontiguousarray(g_cache.get_hhv(breakout_p), dtype=np.float64)
        llv_arr = np.ascontiguousarray(g_cache.get_llv(breakout_p), dtype=np.float64)
        vol_ma_arr = np.ascontiguousarray(g_cache.get_vol_ma(vol_ma_p), dtype=np.float64)
        
        yon_str = params.get('yon_modu', 'CIFT')
        if yon_str == 'SADECE_AL':
            yon_int = 1
        elif yon_str == 'SADECE_SAT':
            yon_int = 2
        else:
            yon_int = 0
            
        np_val, trades, pf, dd, sharpe, adays, tdays = fast_backtest_strategy5(
            closes_f64, highs_f64, lows_f64, vols_f64,
            ema_fast_arr, ema_slow_arr,
            adx_arr, hhv_arr, llv_arr, vol_ma_arr,
            mask_arr, times_arr,
            adx_thresh, trail_pct / 100.0,
            yon_int
        )
        
        fit = quick_fitness(np_val, pf, dd, trades, sharpe=sharpe, active_days=adays, total_days=tdays)
        return {'net_profit': np_val, 'trades': trades, 'pf': pf, 'max_dd': dd, 'sharpe': sharpe, 'fitness': fit}
    except Exception as e:
        import traceback
        print(f"[S5_EVAL ERROR] {e}")
        traceback.print_exc()
        return zero_result

_s5_arrays = None  # Module-level cache for S5 arrays

# ---------------------------------------------------------------------------
# Pre-compute helpers for S7 (avoid per-bar loops in Numba kernel)
# ---------------------------------------------------------------------------

def _get_hhv_shifted(arr: np.ndarray, period: int) -> np.ndarray:
    """arr'ın period-bar rolling max'i, 1 bar shift'li (önceki bar'ın max'i)."""
    return pd.Series(arr).shift(1).rolling(period, min_periods=1).max().fillna(0.0).values.astype(np.float64)

def _get_llv_shifted(arr: np.ndarray, period: int) -> np.ndarray:
    """arr'ın period-bar rolling min'i, 1 bar shift'li."""
    return pd.Series(arr).shift(1).rolling(period, min_periods=1).min().fillna(9999999.0).values.astype(np.float64)

def _get_rolling_max_shifted(arr: np.ndarray, period: int) -> np.ndarray:
    """Genel rolling max, 1 bar shift'li."""
    return pd.Series(arr).shift(1).rolling(period, min_periods=1).max().fillna(0.0).values.astype(np.float64)

def _get_rolling_min_shifted(arr: np.ndarray, period: int) -> np.ndarray:
    """Genel rolling min, 1 bar shift'li."""
    return pd.Series(arr).shift(1).rolling(period, min_periods=1).min().fillna(9999999.0).values.astype(np.float64)

def _get_rolling_mean_shifted(arr: np.ndarray, period: int) -> np.ndarray:
    """arr'ın period-bar rolling mean'i, 1 bar shift'li."""
    return pd.Series(arr).shift(1).rolling(period, min_periods=1).mean().fillna(0.0).values.astype(np.float64)

# Module-level rolling array cache: (hash_key -> np.ndarray)
# Aynı worker'da aynı parametreler tekrar hesaplanmaz.
_s7_rolling_cache: Dict[tuple, np.ndarray] = {}


def _evaluate_s7_params(params: Dict[str, Any], commission: float = 0.0, slippage: float = 0.0) -> Dict[str, float]:
    """S7 DeepScalp parametrelerini Numba kernel ile degerlendir.
    
    v1.3: HHV/LLV/MFI-HHV/MFI-LLV/VolMA hesaplamalari kernel disinda bir kez yapilip
    pre-computed numpy array olarak geciliyor. Her kombinasyon icin sadece basit
    karsilastirmalar kaliyor => ~50-100x hizlanma.
    """
    global g_cache, _s7_arrays, g_mask, _s7_rolling_cache
    zero_result = {'net_profit': 0.0, 'trades': 0, 'pf': 0.0, 'max_dd': 0.0, 'sharpe': 0.0, 'fitness': 0.0}
    if g_cache is None: return zero_result

    try:
        n = len(g_cache.closes)
        if '_s7_arrays' not in dir() or _s7_arrays is None or len(_s7_arrays[0]) != n:
            closes = np.ascontiguousarray(g_cache.closes, dtype=np.float64)
            highs  = np.ascontiguousarray(g_cache.highs, dtype=np.float64)
            lows   = np.ascontiguousarray(g_cache.lows, dtype=np.float64)
            vols   = np.ascontiguousarray(g_cache.volumes, dtype=np.float64)
            mask_arr  = np.array(g_mask, dtype=np.bool_)
            times_arr = np.zeros(n, dtype=np.int64)
            if hasattr(g_cache, 'times') and g_cache.times:
                times_arr = np.array([int(t.timestamp()) for t in g_cache.times], dtype=np.int64)
            _s7_arrays = (closes, highs, lows, vols, mask_arr, times_arr)

        closes, highs, lows, vols, mask_arr, times_arr = _s7_arrays

        # --- Parametre mapping ---
        ars_k   = float(params.get('ars_k', 1.23))
        hhv_p   = int(params.get('hhv_period', 12))
        llv_p   = int(params.get('llv_period', 12))
        mfi_p   = int(params.get('mfi_period', 14))
        mfi_hhv = int(params.get('mfi_hhv_period', 5))
        mfi_llv = int(params.get('mfi_llv_period', 5))
        mfi_l   = float(params.get('mfi_long', 55.0))
        mfi_s   = float(params.get('mfi_short', 45.0))
        v_rat   = float(params.get('vol_ratio', 0.8))
        atr_sl_l = float(params.get('atr_stop_mult_long', 1.5))
        atr_sl_s = float(params.get('atr_stop_mult_short', 1.5))
        ka_l    = float(params.get('kar_al_yuzde_long', 2.0))
        ka_s    = float(params.get('kar_al_yuzde_short', 2.0))
        mh_b    = int(params.get('min_hold_bars', 2))
        mx_b    = int(params.get('max_hold_bars', 20))
        cd_b    = int(params.get('cooldown_bars', 2))

        vt = params.get('vade_tipi', 'ENDEKS')
        vt_code = 1
        if vt == 'SPOT': vt_code = 0
        elif vt == 'VIOP_SPOT': vt_code = 2

        # --- Cached indicator arrays ---
        ars_ema_arr = np.ascontiguousarray(g_cache.get_ema(int(params.get('ars_ema_period', 3))), dtype=np.float64)
        st_val_arr  = np.ascontiguousarray(g_cache.get_st(float(params.get('st_factor', 3.0)), int(params.get('st_hhv_period', 10)), int(params.get('st_atr_period', 14))), dtype=np.float64)
        ema_f_arr   = np.ascontiguousarray(g_cache.get_ema(int(params.get('ema_fast_period', 9))), dtype=np.float64)
        ema_s_arr   = np.ascontiguousarray(g_cache.get_ema(int(params.get('ema_slow_period', 21))), dtype=np.float64)
        _, toma_raw = g_cache.get_toma(1, float(params.get('toma_period2', 2.1)))
        toma_arr    = np.ascontiguousarray(toma_raw, dtype=np.float64)
        mfi_arr     = np.ascontiguousarray(g_cache.get_mfi(mfi_p), dtype=np.float64)
        atr_arr     = np.ascontiguousarray(g_cache.get_atr(int(params.get('atr_period', 14))), dtype=np.float64)

        # --- Pre-computed rolling arrays (worker-level cache ile) ---
        def _cached_roll(key, fn):
            if key not in _s7_rolling_cache:
                _s7_rolling_cache[key] = fn()
            return _s7_rolling_cache[key]

        hhv_shifted     = _cached_roll(('hhv', hhv_p),          lambda: _get_hhv_shifted(g_cache.highs, hhv_p))
        llv_shifted     = _cached_roll(('llv', llv_p),          lambda: _get_llv_shifted(g_cache.lows, llv_p))
        mfi_hhv_shifted = _cached_roll(('mfi_hhv', mfi_p, mfi_hhv), lambda: _get_rolling_max_shifted(mfi_arr, mfi_hhv))
        mfi_llv_shifted = _cached_roll(('mfi_llv', mfi_p, mfi_llv), lambda: _get_rolling_min_shifted(mfi_arr, mfi_llv))
        vol_ma_shifted  = _cached_roll(('vol_ma', 20),          lambda: _get_rolling_mean_shifted(g_cache.volumes, 20))

        res = fast_backtest_strategy7(
            closes, highs, lows, vols,
            ars_ema_arr, st_val_arr, ema_f_arr, ema_s_arr, toma_arr,
            mfi_arr, atr_arr, mask_arr, times_arr,
            hhv_shifted, llv_shifted, mfi_hhv_shifted, mfi_llv_shifted, vol_ma_shifted,
            ars_k, mfi_l, mfi_s,
            v_rat, atr_sl_l, atr_sl_s, ka_l, ka_s, mh_b, mx_b, cd_b, vt_code
        )

        np_val, tr, pf, dd, sh, adays, tdays = res
        fit = quick_fitness(np_val, pf, dd, tr, sharpe=sh, active_days=adays, total_days=tdays)
        return {'net_profit': np_val, 'trades': tr, 'pf': pf, 'max_dd': dd, 'sharpe': sh, 'fitness': fit}

    except Exception as e:
        import traceback
        print(f"[S7_EVAL ERROR] {e}")
        traceback.print_exc()
        return zero_result

_s7_arrays = None
_s7_rolling_cache = {}
_s8_arrays = None
_s8_rolling_cache: Dict[tuple, np.ndarray] = {}


# ---------------------------------------------------------------------------
# Pre-compute helpers for S8 (dataset-level sabit diziler)
# ---------------------------------------------------------------------------

def _build_s8_arrays(cache: 'IndicatorCache', mask) -> tuple:
    """
    S8 için dataset-level sabit dizileri hesaplar. Worker başına bir kez çağrılır.
    Döner: (opens, closes, highs, lows, vols,
             session_arr, time_gap_arr, day_of_week_arr, mask_arr, late_aksam_arr)
    """
    raw_times = cache.times
    n = len(cache.closes)
    session_arr     = np.zeros(n, dtype=np.int8)
    time_gap_arr    = np.zeros(n, dtype=np.float64)
    day_of_week_arr = np.zeros(n, dtype=np.int8)
    late_aksam_arr  = np.zeros(n, dtype=np.bool_)

    # Robust datetime dönüşümü: string, None, NaT hepsi güvenli şekilde işlenir
    try:
        parsed = pd.to_datetime(raw_times, dayfirst=True, errors='coerce').tolist()
        times = [t if not pd.isna(t) else None for t in parsed]
    except Exception:
        times = raw_times  # Fallback: orijinal değerleri kullan

    for i, dt in enumerate(times):
        if dt is None:
            continue
        try:
            h, m = dt.hour, dt.minute
            t_sec = h * 3600 + m * 60
            if 9 * 3600 + 25 * 60 <= t_sec < 9 * 3600 + 30 * 60:
                session_arr[i] = 1   # emirToplama
            elif 9 * 3600 + 30 * 60 <= t_sec <= 18 * 3600 + 9 * 60 + 59:
                session_arr[i] = 2   # gunSeansi
            elif 19 * 3600 <= t_sec <= 22 * 3600 + 59 * 60 + 59:
                session_arr[i] = 3   # aksamSeansi
            # else: 0 = seans disi
            day_of_week_arr[i] = dt.weekday()   # 0=Pzt, 4=Cum
            late_aksam_arr[i]  = bool(h == 22 and m >= 50)
            if i > 0 and times[i - 1] is not None:
                time_gap_arr[i] = (dt - times[i - 1]).total_seconds() / 3600.0
        except Exception:
            continue  # Tek bir bozuk bar tüm build'i çökertmesin

    opens    = np.ascontiguousarray(cache.opens,   dtype=np.float64)
    closes   = np.ascontiguousarray(cache.closes,  dtype=np.float64)
    highs    = np.ascontiguousarray(cache.highs,   dtype=np.float64)
    lows     = np.ascontiguousarray(cache.lows,    dtype=np.float64)
    vols     = np.ascontiguousarray(cache.volumes, dtype=np.float64)
    mask_arr = np.ascontiguousarray(mask, dtype=np.bool_) if mask is not None else np.ones(n, dtype=np.bool_)

    return (opens, closes, highs, lows, vols,
            session_arr, time_gap_arr, day_of_week_arr, mask_arr, late_aksam_arr)


def _evaluate_s8_params(params: Dict[str, Any], commission: float = 0.0, slippage: float = 0.0) -> Dict[str, float]:
    """S8 Gap Reversal parametrelerini Numba kernel ile değerlendir."""
    global g_cache, g_mask, _s8_arrays, _s8_rolling_cache
    zero_result = {'net_profit': 0.0, 'trades': 0, 'pf': 0.0, 'max_dd': 0.0, 'sharpe': 0.0, 'fitness': 0.0}
    if g_cache is None:
        return zero_result

    try:
        # Worker başına bir kez: sabit dizileri oluştur
        if _s8_arrays is None:
            _s8_arrays = _build_s8_arrays(g_cache, g_mask)

        opens, closes, highs, lows, vols, session_arr, time_gap_arr, dow_arr, mask_arr, late_aksam_arr = _s8_arrays

        # Parametre bazlı diziler (worker-level rolling cache)
        rsi_p   = int(params.get('rsi_period',      5))
        hacim_p = int(params.get('hacim_ma_period', 20))
        atr_p   = int(params.get('atr_period',      14))

        def _c(key, fn):
            if key not in _s8_rolling_cache:
                _s8_rolling_cache[key] = fn()
            return _s8_rolling_cache[key]

        rsi_arr    = _c(('rsi', rsi_p),        lambda: precompute_wilder_rsi(closes, rsi_p))
        vol_ma_arr = _c(('vol_ma', hacim_p),   lambda: precompute_sma_shifted(vols, hacim_p))
        atr_arr    = _c(('atr', atr_p),        lambda: precompute_atr_wilder(closes, highs, lows, atr_p))

        yon = params.get('yon_modu', 'CIFT')
        yon_code = 0 if yon == 'CIFT' else (1 if yon == 'SADECE_AL' else 2)

        # Vade tipi kodu: 0=SPOT (no short), 1=VIOP_ENDEKS, 2=VIOP_SPOT
        vt = params.get('vade_tipi', 'ENDEKS')
        vt_code = 0 if vt == 'SPOT' else (2 if vt == 'VIOP_SPOT' else 1)

        res = fast_backtest_strategy8(
            opens, closes, highs, lows, vols,
            session_arr, time_gap_arr, dow_arr, mask_arr, late_aksam_arr,
            rsi_arr, vol_ma_arr, atr_arr,
            float(params.get('min_gap_pct',        0.05)),
            float(params.get('max_gap_pct',        2.0)),
            1 if params.get('cuma_aktif',          False) else 0,
            int(params.get('or_bars',              15)),
            1 if params.get('rsi_filtre_aktif',    True) else 0,
            float(params.get('rsi_ob',             62.0)),
            float(params.get('rsi_os',             38.0)),
            1 if params.get('hacim_filtre_aktif',  True) else 0,
            float(params.get('hacim_oran',         0.8)),
            float(params.get('atr_stop_mult',      0.5)),
            int(params.get('gap_window_bars',      210)),
            int(params.get('cooldown_bars',        3)),
            yon_code,
            vt_code,   # YENİ: vade_tipi — SPOT'ta short yasak
        )

        np_val, tr, pf, dd, sh, adays, tdays = res
        fit = quick_fitness(np_val, pf, dd, tr, sharpe=sh, active_days=adays, total_days=tdays)
        return {'net_profit': np_val, 'trades': tr, 'pf': pf, 'max_dd': dd, 'sharpe': sh, 'fitness': fit}

    except Exception as e:
        import traceback
        print(f"[S8_EVAL ERROR] {e}")
        traceback.print_exc()
        return zero_result


def _eval_combo_wrapper(params_and_strategy_and_costs):
    params, strategy_index, commission, slippage = params_and_strategy_and_costs
    score = _evaluate_params_static(params, strategy_index, commission, slippage)
    # imap_unordered için param değerlerini score'a ekle
    score.update({k: v for k, v in params.items() if k not in score and k != 'vade_tipi'})
    return score

def _evaluate_params_static(params: Dict[str, Any], strategy_index: int, commission: float = 0.0, slippage: float = 0.0) -> Dict[str, float]:
    global g_cache
    if g_cache is None:
        _init_group_pool(strategy_index)
        
    if strategy_index == 0:
        strategy = ScoreBasedStrategy.from_config_dict(g_cache, params)
        signals, exits_long, exits_short = strategy.generate_all_signals()
    elif strategy_index == 2:
        strategy = ParadiseStrategy.from_config_dict(g_cache, params)
        signals, exits_long, exits_short = strategy.generate_all_signals()
    elif strategy_index == 4:
        # S5 Oliver Kell — Numba kernel ile backtest
        return _evaluate_s5_params(params, commission, slippage)
    elif strategy_index == 5:
        # S6 TOTT_HOTT
        strategy = TOTT_HOTTStrategy.from_config_dict(g_cache, params)
        signals, exits_long, exits_short = strategy.generate_all_signals(
            mask=getattr(g_cache, 'mask', None),
            yon_modu=params.get('yon_modu', 'CIFT')
        )
    elif strategy_index == 6:
        # S7 DeepScalp — Numba kernels can handle backtest
        return _evaluate_s7_params(params, commission, slippage)
    elif strategy_index == 7:
        # S8 Gap Reversal — Numba kernel
        return _evaluate_s8_params(params, commission, slippage)
    else:
        strategy = ARSTrendStrategyV2.from_config_dict(g_cache, params)
        signals, exits_long, exits_short = strategy.generate_all_signals()
    
    # Trading days calculation
    trading_days = 252.0
    if g_cache.dates and len(g_cache.dates) > 1:
        try:
            # g_cache.dates is a list of datetime or strings? 
            # IndicatorCache converts them to list in __init__
            # Let's assume they are comparable or convertable
            start_date = g_cache.dates[0]
            end_date = g_cache.dates[-1]
            if hasattr(start_date, 'date'):
                delta = end_date - start_date
                trading_days = delta.days
            else:
                 # String format fallback if needed, but IndicatorCache usually has datetime objects if parsed correctly
                 pass
        except:
            pass
            
    np_val, trades, pf, dd, sharpe = fast_backtest(g_cache.closes, signals, exits_long, exits_short, commission, slippage, trading_days=trading_days)
    
    # Fitness hesapla - Maliyetler np_val icinde dusuruldu, çift sayımı önlemek için 0.0 gonderilmeli
    fit = quick_fitness(np_val, pf, dd, trades, sharpe=sharpe, commission=0.0, slippage=0.0)
    
    return {'net_profit': np_val, 'trades': trades, 'pf': pf, 'max_dd': dd, 'sharpe': sharpe, 'fitness': fit}

def fast_backtest(closes, signals, exits_long, exits_short, commission: float = 0.0, slippage: float = 0.0, trading_days: float = 252.0) -> Tuple[float, int, float, float, float]:
    pos, entry_price, gross_profit, gross_loss, trades, max_dd, peak_equity, current_equity = 0, 0.0, 0.0, 0.0, 0, 0.0, 0.0, 0.0
    
    # Sharpe hesabı için (Welford's algorithm benzeri kümülatif m2)
    # R: Toplam pnl of trade, N: trade count, M2: Sum of squares of differences from the current mean
    # Yıllık Sharpe = (Mean / Std) * Sqrt(Yıllık Trade Sayısı)
    trade_pnls = []

    cost_per_trade = commission + slippage
    n = len(closes)
    
    for i in range(50, n):
        if pos == 1 and exits_long[i]:
            pnl = (closes[i] - entry_price) - cost_per_trade
            trade_pnls.append(pnl)
            if pnl > 0: gross_profit += pnl
            else: gross_loss += abs(pnl)
            current_equity += pnl
            peak_equity = max(peak_equity, current_equity)
            max_dd = max(max_dd, peak_equity - current_equity)
            pos = 0
            trades += 1
        elif pos == -1 and exits_short[i]:
            pnl = (entry_price - closes[i]) - cost_per_trade
            trade_pnls.append(pnl)
            if pnl > 0: gross_profit += pnl
            else: gross_loss += abs(pnl)
            current_equity += pnl
            peak_equity = max(peak_equity, current_equity)
            max_dd = max(max_dd, peak_equity - current_equity)
            pos = 0
            trades += 1

        if pos == 0:
            if signals[i] == 1: pos = 1; entry_price = closes[i]
            elif signals[i] == -1: pos = -1; entry_price = closes[i]

            
    net_profit = gross_profit - gross_loss
    pf = (gross_profit / gross_loss) if gross_loss > 0 else 999
    
    # Basit Sharpe (Trade-based)
    sharpe = 0.0
    if len(trade_pnls) > 1:
        # Gerçek yıllık trade sayısını hesapla
        # Eğer trading_days 0 veya çok küçükse default 252 kullan
        if trading_days < 1: trading_days = 252.0
        
        # Yıllık trade frekansı = Toplam Trade / (Toplam Gün / 252)
        # Yani: trades * (252 / trading_days)
        trades_per_year_metric = len(trade_pnls) * (252.0 / trading_days)
        
        sharpe = calculate_sharpe(np.array(trade_pnls), trades_per_year=trades_per_year_metric)

    return net_profit, trades, pf, max_dd, sharpe

def backtest_with_trades(closes, signals, exits_long, exits_short, commission: float = 0.0, slippage: float = 0.0) -> List[float]:
    """Her işlemin PnL listesini döndürür (Monte Carlo için)"""
    pos, entry_price, trades_pnl = 0, 0.0, []
    cost_per_trade = commission + slippage
    for i in range(50, len(closes)):
        if pos == 1 and exits_long[i]:
            pnl = (closes[i] - entry_price) - cost_per_trade
            trades_pnl.append(float(pnl))
            pos = 0
        elif pos == -1 and exits_short[i]:
            pnl = (entry_price - closes[i]) - cost_per_trade
            trades_pnl.append(float(pnl))
            pos = 0
        if pos == 0:
            if signals[i] == 1: pos = 1; entry_price = closes[i]
            elif signals[i] == -1: pos = -1; entry_price = closes[i]
    return trades_pnl

# ==============================================================================
# HIBRID OPTIMIZER CLASS
# ==============================================================================
class HybridGroupOptimizer:
    def __init__(self, groups: List[ParameterGroup], process_id: str = None, strategy_index: int = 0, 
                 is_cancelled_callback=None, on_progress_callback=None, n_parallel: int = 4, 
                 commission: float = 0.0, slippage: float = 0.0, vade_tipi: str = "ENDEKS", data_df=None):
        self.groups = groups
        self.independent_groups = [g for g in groups if g.is_independent]
        self.cascaded_groups = [g for g in groups if not g.is_independent]
        self.process_id, self.strategy_index, self.n_parallel, self._is_cancelled = process_id, strategy_index, n_parallel, is_cancelled_callback
        self.on_progress = on_progress_callback
        self.commission, self.slippage = commission, slippage
        self.vade_tipi = vade_tipi
        self.data_df = data_df
        self.group_results, self.combined_results, self.final_results = {}, [], []
        self.pool = None  # Process pool for termination support

    def get_default_params(self, exclude_group: str = None) -> Dict[str, Any]:
        defaults = {}
        for g in self.groups:
            if g.name != exclude_group: defaults.update(g.default_values)
        return defaults

    def stop(self):
        """Optimizasyonu dışarıdan durdur"""
        if self._is_cancelled:
            # Callback returns True -> handled in loops
            pass
            
        if self.pool:
            try:
                self.pool.terminate()
                self.pool.join()
            except Exception as e:
                print(f"Hybrid Pool Terminate Error: {e}")
            finally:
                self.pool = None

    def generate_combinations(self, params: Dict[str, List[Any]]) -> List[Dict[str, Any]]:
        keys, values = list(params.keys()), list(params.values())
        return [dict(zip(keys, v)) for v in product(*values)]

    def run_group_optimization(self, group: ParameterGroup, fixed_params: Dict[str, Any] = None) -> List[Dict]:
        print(f"\n=== Grup: {group.name} (strategy_index={self.strategy_index}) ===")
        base_params = self.get_default_params(exclude_group=group.name)
        if fixed_params: base_params.update(fixed_params)
        combos = self.generate_combinations(group.params)
        total = len(combos)
        print(f"  Toplam kombinasyon: {total}, n_parallel={self.n_parallel}")
        results = []
        if self.n_parallel > 1:
            tasks = [({**base_params, **c, 'vade_tipi': self.vade_tipi}, self.strategy_index, self.commission, self.slippage) for c in combos]
            try:
                self.pool = Pool(
                    processes=self.n_parallel,
                    initializer=_init_group_pool,
                    initargs=(self.strategy_index, self.data_df, self.vade_tipi),
                    maxtasksperchild=200
                )
                raw = []
                best_np = 0.0
                chunk = min(32, max(1, total // (self.n_parallel * 8)))
                progress_interval = max(20, total // 200)  # ~200 guncelleme toplam, min 20
                for idx, score in enumerate(self.pool.imap_unordered(_eval_combo_wrapper, tasks, chunksize=chunk)):
                    raw.append(score)
                    if score['net_profit'] > best_np:
                        best_np = score['net_profit']
                    if (idx + 1) == total or (idx + 1) % progress_interval == 0:
                        if self.on_progress:
                            pct = int((idx + 1) / total * 100)
                            self.on_progress(pct, f"[{group.name}] {idx+1}/{total} tarandı | En iyi: {best_np:.0f}")
                    if self._is_cancelled and self._is_cancelled():
                        break
                self.pool.close()
                self.pool.join()
                self.pool = None
            except Exception as e:
                import traceback
                print(f"Hybrid Pool Error: {e}")
                traceback.print_exc()
                if self.pool:
                    self.pool.terminate()
                    self.pool = None
                return []

            for score in raw:
                if score['net_profit'] > 0:
                    # combos ile sıra eşleşmesi artık yok (unordered), parametreler score içinde
                    results.append({'group': group.name, 'vade_tipi': self.vade_tipi, **score})
        else:
            _init_group_pool(self.strategy_index, self.data_df, self.vade_tipi)
            progress_interval = max(20, total // 200)
            best_np = 0.0
            for idx, combo in enumerate(combos):
                if self._is_cancelled and self._is_cancelled(): break
                score = _evaluate_params_static({**base_params, **combo, 'vade_tipi': self.vade_tipi}, self.strategy_index, self.commission, self.slippage)
                if score['net_profit'] > best_np: best_np = score['net_profit']
                if score['net_profit'] > 0: results.append({'group': group.name, 'vade_tipi': self.vade_tipi, **combo, **score})
                
                if (idx + 1) == total or (idx + 1) % progress_interval == 0:
                    if self.on_progress:
                        pct = int((idx + 1) / total * 100)
                        self.on_progress(pct, f"[{group.name}] {idx+1}/{total} tarandı | En iyi: {best_np:.0f}")
        results.sort(key=lambda x: x['net_profit'], reverse=True)
        top = results[:10]
        print(f"Bulunan: {len(results)}, Top: {len(top)}")
        return top

    def run_independent_phase(self):
        """Eski bağımsız faz - geriye uyumluluk için korunuyor."""
        print("\nPHASE 1: BAĞIMSIZ"); [self.group_results.update({g.name: self.run_group_optimization(g)}) for g in self.independent_groups]

    def run_satellite_drone_phase(self):
        """
        TURBO: Satellite-Drone 2 aşamalı tarama.
        1. Satellite: Geniş adımlarla kaba tarama
        2. Cluster: İyi sonuçların kümelendiği bölgeyi tespit
        3. Drone: Dar aralık, hassas adımlarla ince tarama
        """
        print("\n" + "="*60)
        print("  SATELLITE-DRONE PHASE (TURBO)")
        print("="*60)
        
        total_independent = len(self.independent_groups)
        for i, group in enumerate(self.independent_groups):
            if self._is_cancelled and self._is_cancelled(): break
            
            progress_base = 10 + (i / total_independent) * 70  # Phase 1 is 10-80%
            
            print(f"\n--- Grup: {group.name} ---")
            
            # === SATELLITE SCAN ===
            msg = f"[SAT] {group.name} Satellite Tarama..."
            print(f"  {msg}")
            if self.on_progress: self.on_progress(int(progress_base), msg)
            
            satellite_params = {}
            param_mins, param_maxs = {}, {}
            # ... (rest of param collection)
            for param_name, values in group.params.items():
                param_min, param_max = min(values), max(values)
                param_mins[param_name], param_maxs[param_name] = param_min, param_max
                
                # Kullanıcının adımını hesapla (ilk iki değer arası fark)
                user_step = 1.0
                if len(values) > 1:
                    user_step = abs(values[1] - values[0])
                
                step = get_step(param_name, 'satellite', user_step=user_step)
                is_int = PARAM_TYPES.get(param_name, '').startswith('period') or PARAM_TYPES.get(param_name, '').startswith('threshold_int')
                satellite_params[param_name] = generate_range(param_min, param_max, step, is_int)
            
            satellite_group = ParameterGroup(
                name=group.name + "_SAT",
                params=satellite_params,
                is_independent=True,
                default_values=group.default_values
            )
            satellite_results = self.run_group_optimization(satellite_group)
            
            if not satellite_results:
                print(f"  [!] Satellite sonuc bulunamadi, varsayilan degerler kullanilacak.")
                self.group_results[group.name] = []
                continue
            
            # === CLUSTER ANALYSIS ===
            print("  [CLU] Kumeleme Analizi...")
            drone_params = {}
            
            for param_name, values in group.params.items():
                # Kullanıcının adımını tekrar hesapla
                user_step = 1.0
                if len(values) > 1:
                    user_step = abs(values[1] - values[0])

                sat_step = get_step(param_name, 'satellite', user_step=user_step)
                new_min, new_max = find_cluster_range(
                    satellite_results, param_name, sat_step, 
                    param_mins[param_name], param_maxs[param_name]
                )
                drone_step = get_step(param_name, 'drone', user_step=user_step)
                is_int = PARAM_TYPES.get(param_name, '').startswith('period') or PARAM_TYPES.get(param_name, '').startswith('threshold_int')
                drone_params[param_name] = generate_range(new_min, new_max, drone_step, is_int)
                
                if new_min != param_mins[param_name] or new_max != param_maxs[param_name]:
                    print(f"    {param_name}: [{param_mins[param_name]}-{param_maxs[param_name]}] => [{new_min}-{new_max}]")
            
            # === DRONE SCAN ===
            msg = f"[DRN] {group.name} Drone Tarama..."
            print(f"  {msg}")
            if self.on_progress: self.on_progress(int(progress_base + (0.5 / total_independent) * 70), msg)
            
            drone_group = ParameterGroup(
                name=group.name + "_DRONE",
                params=drone_params,
                is_independent=True,
                default_values=group.default_values
            )
            drone_results = self.run_group_optimization(drone_group)
            
            all_results = satellite_results + drone_results
            from src.optimization.fitness import calculate_robust_fitness
            calculate_robust_fitness(all_results)
            all_results.sort(key=lambda x: x.get('robust_fitness', x.get('fitness', 0)), reverse=True)
            self.group_results[group.name] = all_results[:15]
            print(f"  [OK] {group.name}: {len(all_results)} sonuc => Top 15 secildi")

    def run_iterative_phase(self, max_rounds: int = 3, convergence_threshold: float = 0.05):
        """
        Iterative Coordinate Descent: Her round'da gruplar diger gruplarin 
        EN IYI bulunan degerlerini kullanarak tekrar optimize edilir.
        Checkpoint destegi: Her grup tamamlandiginda diske yazar.
        """
        from src.optimization.checkpoint_manager import CheckpointManager
        ckpt = CheckpointManager()
        job_id = CheckpointManager.make_job_id(
            self.strategy_index, 'Hibrit Grup', self.process_id or 'default'
        )
        
        print("\n" + "="*60)
        print("  ITERATIVE COORDINATE DESCENT")
        print("="*60)
        
        # Resume: checkpoint varsa yukle
        saved = ckpt.load(job_id)
        resume_round = 0
        resume_group_idx = -1
        
        # Baslangic: Tum gruplar default degerlerle
        current_best = {}
        for g in self.groups:
            current_best[g.name] = g.default_values.copy()
        
        if saved and saved.get('phase') == 'iterative':
            resume_round = saved.get('round', 0)
            resume_group_idx = saved.get('group_idx', -1)
            saved_best = saved.get('current_best', {})
            if saved_best:
                current_best.update(saved_best)
            saved_results = saved.get('group_results', {})
            if saved_results:
                self.group_results.update(saved_results)
            print(f"  [RESUME] Round {resume_round}, Grup {resume_group_idx}'den devam ediliyor")
        
        total_groups = len(self.independent_groups)
        
        for round_num in range(1, max_rounds + 1):
            # Resume: tamamlanan round'lari atla
            if round_num < resume_round:
                print(f"\n--- ROUND {round_num}/{max_rounds} [ATLANDI] ---")
                continue
            
            print(f"\n--- ROUND {round_num}/{max_rounds} ---")
            round_start_fitness = {}
            round_end_fitness = {}
            
            for i, group in enumerate(self.independent_groups):
                # Resume: tamamlanan gruplari atla
                if round_num == resume_round and i <= resume_group_idx:
                    print(f"  [RESUME] {group.name} atlandi")
                    continue
                
                if self._is_cancelled and self._is_cancelled():
                    # Durdurma: checkpoint kaydet
                    ckpt.save(job_id, {
                        'phase': 'iterative',
                        'round': round_num,
                        'group_idx': i - 1,
                        'current_best': current_best,
                        'group_results': {k: v[:15] for k, v in self.group_results.items()},
                    })
                    print(f"  [CHECKPOINT] Kaydedildi: Round {round_num}, Grup {i-1}")
                    break
                
                # Progress: Round ve grup bazli
                base_progress = ((round_num - 1) / max_rounds) * 70
                group_progress = (i / total_groups) * (70 / max_rounds)
                progress = int(10 + base_progress + group_progress)
                
                # Diger gruplarin EN IYI degerlerini kullan (default degil!)
                fixed_params = {}
                for other in self.groups:
                    if other.name != group.name:
                        fixed_params.update(current_best[other.name])
                
                msg = f"[R{round_num}] {group.name} optimizing..."
                print(f"  {msg}")
                if self.on_progress:
                    self.on_progress(progress, msg)
                
                # Onceki fitness
                old_results = self.group_results.get(group.name, [])
                round_start_fitness[group.name] = old_results[0].get('fitness', 0) if old_results else 0
                
                # R1: Tam Satellite + Drone  |  R2+: Sadece Drone (önceki en iyinin etrafında)
                if round_num == 1 or not old_results:
                    # Ilk round: genis Satellite taramasi
                    satellite_params = self._generate_satellite_params(group)
                    satellite_group = ParameterGroup(
                        name=group.name + "_SAT",
                        params=satellite_params,
                        is_independent=True,
                        default_values=group.default_values
                    )
                    satellite_results = self.run_group_optimization(satellite_group, fixed_params)
                    
                    if satellite_results:
                        drone_params = self._generate_drone_params(group, satellite_results)
                        if drone_params:
                            drone_group = ParameterGroup(
                                name=group.name + "_DRONE",
                                params=drone_params,
                                is_independent=True,
                                default_values=group.default_values
                            )
                            drone_results = self.run_group_optimization(drone_group, fixed_params)
                            all_results = satellite_results + drone_results
                        else:
                            all_results = satellite_results
                    else:
                        all_results = []
                else:
                    # R2+: Onceki en iyi sonuclarin etrafinda sadece Drone taramasi
                    drone_params = self._generate_drone_params(group, old_results)
                    if drone_params:
                        drone_group = ParameterGroup(
                            name=group.name + f"_R{round_num}_REFINE",
                            params=drone_params,
                            is_independent=True,
                            default_values=group.default_values
                        )
                        drone_results = self.run_group_optimization(drone_group, fixed_params)
                        all_results = old_results + drone_results
                    else:
                        all_results = old_results
                
                if all_results:
                    all_results.sort(key=lambda x: x.get('fitness', x.get('net_profit', 0)), reverse=True)
                    from src.optimization.fitness import calculate_robust_fitness
                    calculate_robust_fitness(all_results)
                    all_results.sort(key=lambda x: x.get('robust_fitness', x.get('fitness', 0)), reverse=True)
                    self.group_results[group.name] = all_results[:15]
                    
                    # current_best guncelle
                    for key in group.params.keys():
                        if key in all_results[0]:
                            current_best[group.name][key] = all_results[0][key]
                    round_end_fitness[group.name] = all_results[0].get('fitness', 0)
                
                # Grup tamamlandi: checkpoint kaydet
                ckpt.save(job_id, {
                    'phase': 'iterative',
                    'round': round_num,
                    'group_idx': i,
                    'current_best': current_best,
                    'group_results': {k: v[:15] for k, v in self.group_results.items()},
                })
            
            # Yakinsama kontrolu
            max_improvement = 0
            for gname in round_start_fitness:
                if round_start_fitness[gname] > 0:
                    improvement = (round_end_fitness.get(gname, 0) - round_start_fitness[gname]) / abs(round_start_fitness[gname])
                    max_improvement = max(max_improvement, improvement)
            
            print(f"  Round {round_num} Max Improvement: {max_improvement:.1%}")
            
            if round_num > 1 and max_improvement < convergence_threshold:
                print(f"  Converged! (Improvement < {convergence_threshold:.0%})")
                break
        
        return current_best
    
    def _generate_satellite_params(self, group: ParameterGroup) -> dict:
        """Grup icin Satellite parametreleri uret."""
        satellite_params = {}
        for param_name, values in group.params.items():
            param_min, param_max = min(values), max(values)
            user_step = abs(values[1] - values[0]) if len(values) > 1 else 1
            step = get_step(param_name, 'satellite', user_step=user_step)
            is_int = param_name.endswith('period') or param_name.endswith('bars')
            satellite_params[param_name] = generate_range(param_min, param_max, step, is_int)
        return satellite_params
    
    def _generate_drone_params(self, group: ParameterGroup, satellite_results: list) -> dict:
        """Satellite sonuclarindan cluster bulup Drone parametreleri uret."""
        if not satellite_results:
            return {}
        
        drone_params = {}
        for param_name, values in group.params.items():
            param_min, param_max = min(values), max(values)
            user_step = abs(values[1] - values[0]) if len(values) > 1 else 1
            sat_step = get_step(param_name, 'satellite', user_step=user_step)
            
            new_min, new_max = find_cluster_range(satellite_results, param_name, sat_step, param_min, param_max)
            drone_step = get_step(param_name, 'drone', user_step=user_step)
            is_int = param_name.endswith('period') or param_name.endswith('bars')
            drone_params[param_name] = generate_range(new_min, new_max, drone_step, is_int)
        
        return drone_params
    
    def run_stability_scoring(self, top_n: int = 3):
        """
        Her parametrenin komsularini test ederek stabilite skoru hesapla.
        Uc degerler elenir.
        """
        print("\n" + "="*60)
        print("  STABILITY SCORING")
        print("="*60)
        
        if self.on_progress:
            self.on_progress(82, "Stability Scoring...")
        
        for group_name, results in self.group_results.items():
            group = next((g for g in self.groups if g.name == group_name), None)
            if not group or not results:
                continue
            
            for result in results[:top_n]:
                stability = self._calculate_stability(result, group)
                result['stability'] = stability
                
                if stability >= 0.6:
                    print(f"  [OK] {group_name}: stability={stability:.0%}")
                else:
                    print(f"  [!] {group_name}: stability={stability:.0%} (edge value warning)")
    
    def _calculate_stability(self, result: dict, group: ParameterGroup) -> float:
        """Komsulari test ederek stabilite orani dondur."""
        original_fitness = result.get('fitness', 0)
        if original_fitness <= 0:
            return 0.0
        
        stable_neighbors = 0
        total_neighbors = 0
        
        # Sabit parametreler (diger gruplardan)
        base_params = result.copy()
        
        for param_name, values in group.params.items():
            if param_name not in result or len(values) < 2:
                continue
            
            current_val = result[param_name]
            step = abs(values[1] - values[0])
            
            for offset in [-step, step]:
                neighbor_val = current_val + offset
                if neighbor_val < min(values) or neighbor_val > max(values):
                    continue
                
                total_neighbors += 1
                
                # Komsuyu test et
                test_params = base_params.copy()
                test_params[param_name] = neighbor_val
                
                try:
                    score = _evaluate_params_static(test_params, self.strategy_index, self.commission, self.slippage)
                    neighbor_fitness = score.get('fitness', 0)
                    
                    # %15 icinde mi?
                    if abs(neighbor_fitness - original_fitness) / abs(original_fitness) < 0.15:
                        stable_neighbors += 1
                except:
                    pass
        
        return stable_neighbors / max(total_neighbors, 1)

    def run_combination_phase(self):
        msg = "PHASE 2: GRUP KOMBINASYONLARI"
        print(f"\n{msg}")
        if self.on_progress: self.on_progress(85, msg)
        
        top_per_group = {n: r[:3] for n, r in self.group_results.items() if r}
        if not top_per_group: return
        
        # Kombinasyonlari olustur
        all_combos = list(product(*top_per_group.values()))
        total_combos = len(all_combos)
        print(f"  Toplam kombinasyon: {total_combos}")
        
        # Paralel islem icin task listesi olustur
        tasks = []
        for combo in all_combos:
            merged = {}
            for res in combo: 
                merged.update({k: v for k, v in res.items() if k not in ['group', 'net_profit', 'trades', 'pf', 'max_dd', 'sharpe', 'fitness', 'stability']})
            # Cascaded gruplarin default degerlerini ekle
            for g in self.cascaded_groups:
                merged.update(g.default_values)
            tasks.append((merged, self.strategy_index, self.commission, self.slippage))
        
        # Paralel calistir
        print(f"  {cpu_count()} cekirdek ile paralel calistiriliyor...")
        try:
            self.pool = Pool(processes=cpu_count())
            results = self.pool.starmap(_evaluate_params_static, tasks)
            self.pool.close()
            self.pool.join()
            self.pool = None
        except Exception as e:
            print(f"Hybrid Combination Pool Error: {e}")
            if self.pool:
                self.pool.terminate()
                self.pool = None
            return
        
        # Sonuclari filtrele ve ekle
        for merged_params, score in zip([t[0] for t in tasks], results):
            if score.get('net_profit', 0) > 0:
                self.combined_results.append({**merged_params, **score})
        
        self.combined_results.sort(key=lambda x: x.get('fitness', x.get('net_profit', 0)), reverse=True)
        print(f"  Toplam basarili kombinasyon: {len(self.combined_results)}")


    def run_cascaded_phase(self):
        msg = "PHASE 3: KADEMELI OPTIMIZASYON"
        print(f"\n{msg}")
        if self.on_progress: self.on_progress(92, msg)
        
        if not self.combined_results: return
        best_base = {k: v for k, v in self.combined_results[0].items() if k not in ['net_profit', 'trades', 'pf', 'max_dd', 'sharpe', 'fitness', 'stability']}
        for group in self.cascaded_groups:
            results = self.run_group_optimization(group, fixed_params=best_base)
            if results: [best_base.update({k: v}) for k, v in results[0].items() if k not in ['group', 'net_profit', 'trades', 'pf', 'max_dd', 'sharpe', 'fitness', 'stability']]
        score = _evaluate_params_static(best_base, self.strategy_index, self.commission, self.slippage)
        self.final_results = [{**best_base, **score}]

    def run(self, turbo: bool = True, iterative: bool = True, max_rounds: int = 3):
        """
        Optimizasyonu calistir.
        
        Args:
            turbo: Satellite-Drone kullan (her zaman True)
            iterative: Iterative Coordinate Descent kullan (yeni!)
            max_rounds: Iteratif mod icin max round sayisi
        """
        if iterative:
            self.run_iterative_phase(max_rounds)
            self.run_stability_scoring()
        elif turbo:
            self.run_satellite_drone_phase()
        else:
            self.run_independent_phase()
        
        self.run_combination_phase()
        self.run_cascaded_phase()
        
        # Basarili tamamlanma: checkpoint temizle
        from src.optimization.checkpoint_manager import CheckpointManager
        ckpt = CheckpointManager()
        job_id = CheckpointManager.make_job_id(
            self.strategy_index, 'Hibrit Grup', self.process_id or 'default'
        )
        ckpt.delete(job_id)
        
        if self.on_progress:
            self.on_progress(100, "Tamamlandi!")
        
        return self.final_results

    def get_best_results(self, top_n=20):
        return sorted(self.final_results or self.combined_results or [r for res in self.group_results.values() for r in res], key=lambda x: x.get('fitness', x.get('net_profit', 0)), reverse=True)[:top_n]

