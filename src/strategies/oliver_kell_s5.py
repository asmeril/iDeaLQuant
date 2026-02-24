# -*- coding: utf-8 -*-
"""
Strategy 5: Oliver Kell (Base 'n Break)
---------------------------------------
2020 US Investing Championship şampiyonu Oliver Kell'ın stratejisi.

Kurallar:
1. LONG: C > EMA10 > EMA20, C > HH10[i-1], ADX > Sınır, EMA10 Yönü Yukarı, Hacim > VolMA
2. SHORT: C < EMA10 < EMA20, C < LL10[i-1], ADX > Sınır, EMA10 Yönü Aşağı, Hacim > VolMA
3. ÇIKIŞ: EMA Crossback VEYA İzleyen Stop patlaması

Parametreler (Default):
    ema_fast: 10
    ema_slow: 20
    breakout_period: 10
    adx_period: 14
    adx_threshold: 20
    vol_ma_period: 20
    trailing_stop_pct: 1.5
"""

from typing import Dict, Any, List
from ..indicators.core import EMA, ADX, HHV, LLV
from .common import Signal


class OliverKellStrategy:
    def __init__(self, params: Dict[str, Any]):
        self.ema_fast_period = int(params.get('ema_fast', 10))
        self.ema_slow_period = int(params.get('ema_slow', 20))
        self.breakout_period = int(params.get('breakout_period', 10))
        self.adx_period = int(params.get('adx_period', 14))
        self.adx_threshold = float(params.get('adx_threshold', 20.0))
        self.vol_ma_period = int(params.get('vol_ma_period', 20))
        self.trailing_stop_pct = float(params.get('trailing_stop_pct', 1.5))
        
        self.yon_modu = params.get('yon_modu', 'CIFT')
        
        # Minimum veri gereksinimi
        self.min_bars = max(self.ema_slow_period, self.adx_period, self.breakout_period, self.vol_ma_period) + 5
        self.cache = None

    @classmethod
    def from_config_dict(cls, data, config: Dict[str, Any], dates: List[Any] = None) -> 'OliverKellStrategy':
        params = {
            'ema_fast': config.get('ema_fast', 10),
            'ema_slow': config.get('ema_slow', 20),
            'breakout_period': config.get('breakout_period', 10),
            'adx_period': config.get('adx_period', 14),
            'adx_threshold': config.get('adx_threshold', 20.0),
            'vol_ma_period': config.get('vol_ma_period', 20),
            'trailing_stop_pct': config.get('trailing_stop_pct', 1.5),
            'yon_modu': config.get('yon_modu', 'CIFT'),
        }
        
        instance = cls(params)
        
        if hasattr(data, 'closes'):
            instance.cache = data
            instance.closes = data.closes
            instance.highs = data.highs
            instance.lows = data.lows
            instance.volumes = data.volume if hasattr(data, 'volume') else data.volumes
        else:
            instance.closes = data.get('closes', [])
            instance.highs = data.get('highs', [])
            instance.lows = data.get('lows', [])
            instance.volumes = data.get('volumes', [])
        
        return instance

    def generate_all_signals(self):
        from .common import Signal
        signals = self.calculate_signals(self.closes, self.highs, self.lows, self.volumes)
        n = len(signals)
        exits_long = [False] * n
        exits_short = [False] * n
        
        pos = 0  # 0=flat, 1=long, -1=short
        for i in range(n):
            sig = signals[i]
            
            # Yön Modu Filtresi
            if self.yon_modu == "SADECE_AL" and sig == Signal.SHORT:
                sig = Signal.FLAT
            elif self.yon_modu == "SADECE_SAT" and sig == Signal.LONG:
                sig = Signal.FLAT
                
            if sig == Signal.LONG:
                if pos == -1:
                    exits_short[i] = True
                pos = 1
            elif sig == Signal.SHORT:
                if pos == 1:
                    exits_long[i] = True
                pos = -1
            elif sig == Signal.FLAT:
                if pos == 1:
                    exits_long[i] = True
                elif pos == -1:
                    exits_short[i] = True
                pos = 0
        
        # Convert Signal enum to int for backtest compatibility
        int_signals = [0] * n
        for i in range(n):
            if signals[i] == Signal.LONG and self.yon_modu != "SADECE_SAT":
                int_signals[i] = 1
            elif signals[i] == Signal.SHORT and self.yon_modu != "SADECE_AL":
                int_signals[i] = -1
        
        return int_signals, exits_long, exits_short

    def calculate_signals(self, closes, highs, lows, volumes) -> List[Signal]:
        n = len(closes)
        signals = [Signal.NONE] * n
        
        if n < self.min_bars:
            return signals
        
        # Convert to lists if numpy arrays
        closes_list = list(closes) if hasattr(closes, 'tolist') else closes
        highs_list = list(highs) if hasattr(highs, 'tolist') else highs
        lows_list = list(lows) if hasattr(lows, 'tolist') else lows
        volumes_list = list(volumes) if hasattr(volumes, 'tolist') else volumes

        # --- INDIKATORLER ---
        ema_fast = EMA(closes_list, self.ema_fast_period)
        ema_slow = EMA(closes_list, self.ema_slow_period)
        adx_arr = ADX(highs_list, lows_list, closes_list, self.adx_period)
        hh = HHV(highs_list, self.breakout_period)
        ll = LLV(lows_list, self.breakout_period)
        
        # Hacim Ortalaması (Simple MA)
        vol_ma = [0.0] * n
        for i in range(self.vol_ma_period - 1, n):
            s = 0.0
            for j in range(self.vol_ma_period):
                s += volumes_list[i - j]
            vol_ma[i] = s / self.vol_ma_period

        # --- STRATEJI ---
        pozisyon = 0  # 0=F, 1=A, -1=S
        uc_uc_mesafe = 0.0
        stop_seviyesi = 0.0
        iz_yuzde = self.trailing_stop_pct / 100.0
        
        start_idx = self.min_bars
        
        for i in range(start_idx, n):
            # LONG koşulları
            long_trend = closes_list[i] > ema_fast[i] and closes_list[i] > ema_slow[i]
            long_break = closes_list[i] > hh[i - 1]
            trend_gucu_long = adx_arr[i] > self.adx_threshold and ema_fast[i] > ema_fast[i - 1]
            
            # SHORT koşulları
            short_trend = closes_list[i] < ema_fast[i] and closes_list[i] < ema_slow[i]
            short_break = closes_list[i] < ll[i - 1]
            trend_gucu_short = adx_arr[i] > self.adx_threshold and ema_fast[i] < ema_fast[i - 1]
            
            guclu_hacim = volumes_list[i] > vol_ma[i]
            
            # EMA Crossback
            ema_crossback_long = closes_list[i] < ema_fast[i] and closes_list[i] < ema_slow[i]
            ema_crossback_short = closes_list[i] > ema_fast[i] and closes_list[i] > ema_slow[i]
            
            if pozisyon == 0:
                if long_trend and long_break and guclu_hacim and trend_gucu_long:
                    signals[i] = Signal.LONG
                    pozisyon = 1
                    uc_uc_mesafe = closes_list[i]
                    stop_seviyesi = lows_list[i]
                elif short_trend and short_break and guclu_hacim and trend_gucu_short:
                    signals[i] = Signal.SHORT
                    pozisyon = -1
                    uc_uc_mesafe = closes_list[i]
                    stop_seviyesi = highs_list[i]
                    
            elif pozisyon == 1:
                # Trailing stop güncelle
                if closes_list[i] > uc_uc_mesafe:
                    uc_uc_mesafe = closes_list[i]
                    yeni_stop = uc_uc_mesafe * (1.0 - iz_yuzde)
                    if yeni_stop > stop_seviyesi:
                        stop_seviyesi = yeni_stop
                
                # Çıkış kontrolü (bar-içi stop: L[i] kullan, kapanış bekleme)
                if ema_crossback_long or lows_list[i] <= stop_seviyesi:
                    if short_trend and short_break and guclu_hacim and trend_gucu_short:
                        signals[i] = Signal.SHORT
                        pozisyon = -1
                        uc_uc_mesafe = closes_list[i]
                        stop_seviyesi = highs_list[i]
                    else:
                        signals[i] = Signal.FLAT
                        pozisyon = 0
                        
            elif pozisyon == -1:
                # Trailing stop güncelle
                if closes_list[i] < uc_uc_mesafe:
                    uc_uc_mesafe = closes_list[i]
                    yeni_stop = uc_uc_mesafe * (1.0 + iz_yuzde)
                    if yeni_stop < stop_seviyesi or stop_seviyesi == 0:
                        stop_seviyesi = yeni_stop
                
                # Çıkış kontrolü (bar-içi stop: H[i] kullan, kapanış bekleme)
                if ema_crossback_short or highs_list[i] >= stop_seviyesi:
                    if long_trend and long_break and guclu_hacim and trend_gucu_long:
                        signals[i] = Signal.LONG
                        pozisyon = 1
                        uc_uc_mesafe = closes_list[i]
                        stop_seviyesi = lows_list[i]
                    else:
                        signals[i] = Signal.FLAT
                        pozisyon = 0
        
        return signals
