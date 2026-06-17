# -*- coding: utf-8 -*-
"""
Strategy: EMA Vur Kaç (5-8-13 Üçlü EMA Kesim)
-----------------------------------------------
Kural seti:
  1. EMA 5, 8, 13 hesapla (günlük bar)
  2. Fiyat üçünün de altında ardışık MIN_ALTI gün kaldıktan sonra
  3. Tek barda üçünü birden yukarı keser ve kapanış üçünün de üzerindeyse → LONG giriş
  4. Bir önceki bar henüz üçünün üzerinde değildi (gerçek kesim kontrolü)
  5. Çıkış: İzleyen stop (trailing_stop_pct)

Parametreler (default):
    min_below       : 3      # min ardışık EMA-altı bar
    trailing_stop_pct: 1.0   # izleyen stop yüzdesi
    yon_modu        : SADECE_AL  # strateji sadece long
"""

from typing import Dict, Any, List
from .common import Signal
try:
    from ..indicators.core import EMA
except ImportError:
    from indicators.core import EMA


class EmaVurKacStrategy:

    def __init__(self, params: Dict[str, Any]):
        self.min_below          = int(params.get('min_below', 3))
        self.trailing_stop_pct  = float(params.get('trailing_stop_pct', 1.0))
        self.yon_modu           = str(params.get('yon_modu', 'SADECE_AL'))

        self.min_bars = 13 + self.min_below + 5   # EMA13 warm-up + bekleme

    # ----------------------------------------------------------------
    @classmethod
    def from_config_dict(cls, data, config: Dict[str, Any],
                         dates: List[Any] = None) -> 'EmaVurKacStrategy':
        params = {
            'min_below':          config.get('min_below', 3),
            'trailing_stop_pct':  config.get('trailing_stop_pct', 1.0),
            'yon_modu':           config.get('yon_modu', 'SADECE_AL'),
        }
        instance = cls(params)

        if hasattr(data, 'closes'):
            instance.closes = list(data.closes)
            instance.highs  = list(data.highs)
            instance.lows   = list(data.lows)
            instance.volumes = list(data.volumes) if hasattr(data, 'volumes') else []
        else:
            instance.closes  = list(data.get('closes', []))
            instance.highs   = list(data.get('highs', []))
            instance.lows    = list(data.get('lows', []))
            instance.volumes = list(data.get('volumes', []))

        return instance

    # ----------------------------------------------------------------
    def generate_all_signals(self):
        """
        BacktestEngine'in beklediği format:
        Döner: (int_signals, exits_long, exits_short)
          int_signals : [0/1/-1]  (0=flat, 1=long, -1=short)
          exits_long  : [bool]
          exits_short : [bool]
        """
        signals = self.calculate_signals(self.closes, self.highs, self.lows)
        n = len(signals)

        exits_long  = [False] * n
        exits_short = [False] * n
        pos = 0

        for i in range(n):
            sig = signals[i]
            if sig == Signal.LONG:
                if pos == -1:
                    exits_short[i] = True
                pos = 1
            elif sig == Signal.FLAT:
                if pos == 1:
                    exits_long[i] = True
                elif pos == -1:
                    exits_short[i] = True
                pos = 0

        int_signals = [0] * n
        for i in range(n):
            if signals[i] == Signal.LONG:
                int_signals[i] = 1

        return int_signals, exits_long, exits_short

    # ----------------------------------------------------------------
    def calculate_signals(self, closes, highs, lows) -> List[Signal]:
        """
        Bar-by-bar sinyal üretimi.
        Trailing stop burada hesaplanır (gün içi low ile tetikleme).
        """
        n = len(closes)
        signals = [Signal.NONE] * n

        if n < self.min_bars:
            return signals

        closes_l = list(closes) if hasattr(closes, 'tolist') else closes
        highs_l  = list(highs)  if hasattr(highs,  'tolist') else highs
        lows_l   = list(lows)   if hasattr(lows,   'tolist') else lows

        e5  = EMA(closes_l, 5)
        e8  = EMA(closes_l, 8)
        e13 = EMA(closes_l, 13)

        pozisyon    = 0      # 0=flat, 1=long
        max_fiyat   = 0.0    # trailing stop için tepe
        stop_seviye = 0.0    # anlık trailing stop seviyesi
        iz_oran     = self.trailing_stop_pct / 100.0

        for i in range(self.min_bars, n):
            c = closes_l[i]
            h = highs_l[i]
            l = lows_l[i]

            # ── POZISYON VAR: trailing stop ve flat kontrol ──────────
            if pozisyon == 1:
                # Yeni yüksek → trailing stop yukarı çek
                if h > max_fiyat:
                    max_fiyat   = h
                    yeni_stop   = max_fiyat * (1.0 - iz_oran)
                    if yeni_stop > stop_seviye:
                        stop_seviye = yeni_stop

                # Gün içi low trailing stop'u kırdı → çık
                if l <= stop_seviye:
                    signals[i] = Signal.FLAT
                    pozisyon    = 0
                    max_fiyat   = 0.0
                    stop_seviye = 0.0
                continue

            # ── SINYAL ARANIYOR ─────────────────────────────────────

            # KOŞUL 1: Bugün üç EMA'nın da üstünde kapanış
            if not (c > e5[i] and c > e8[i] and c > e13[i]):
                continue

            # KOŞUL 2: Dün üçünün de üstünde değildi (gerçek kesim)
            c_prev = closes_l[i - 1]
            if c_prev > e5[i-1] and c_prev > e8[i-1] and c_prev > e13[i-1]:
                continue

            # KOŞUL 3: Geriye ardışık "üçünün de altında" bar sayısı
            ardisik = 0
            for j in range(i - 1, max(i - 50, self.min_bars - 1), -1):
                cj = closes_l[j]
                if cj < e5[j] and cj < e8[j] and cj < e13[j]:
                    ardisik += 1
                else:
                    break
            if ardisik < self.min_below:
                continue

            # ── LONG GİRİŞ ──────────────────────────────────────────
            signals[i]  = Signal.LONG
            pozisyon    = 1
            max_fiyat   = c
            stop_seviye = c * (1.0 - iz_oran)

        return signals
