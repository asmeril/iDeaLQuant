# -*- coding: utf-8 -*-
"""
IdealQuant - TOTT_HOTT (Strategy 6)
Referans: TOTT_SOTT_ve_HOTT_LOTT formul1.docx

Formül (Düzeltilmiş):
AL:
  if(MOV(C,opt1,VAR) > OTT(C,opt1,ott_pct_big),
     MOV > OTT(C,opt1,ott_pct_small) * (1+ott_mult)
     AND STOSK+1000 > OTT(STOSK+1000, 2, sott_pct)
     AND H > OTT(HHV(H,gate_period/2), 2, gate_pct)
     AND H > REF(HHV(H,gate_period), -1),
     [fallback: MOV > OTT(C,opt1,3.5) + aynı diğer şartlar])
SAT: Simetrik
"""

from typing import List, Optional, Dict, Any
from dataclasses import dataclass
from datetime import datetime
import numpy as np

from src.indicators.core import MA, HHV, LLV
from src.indicators.trend import OTT
from src.indicators.oscillators import StochasticFast
from .common import Signal


@dataclass
class StrategyConfigTottHott:
    """TOTT_HOTT (Strategy 6) Konfigürasyonu — Referans Doküman"""

    # --- Trend ---
    ott_period: int = 30          # MOV/OTT period (20-50, adım 10)
    ott_pct_big: float = 7.0      # Büyük OTT% — ana trend filtresi (6-9, adım 0.5)
    ott_pct_small: float = 3.5    # Küçük OTT% — fallback koşulu (2.8-4.0, adım 0.2)

    # --- Bölge ---
    ott_mult: float = 0.0008      # Band çarpanı (0.0005-0.0011, adım 0.0003)
    sott_pct: float = 0.3         # SOTT yüzdesi (0.2-0.4, adım 0.1)

    # --- Kapı ---
    gate_period: int = 20         # HHV/LLV periyodu (10-34, adım 6)
    gate_pct: float = 0.5         # Kapı OTT% (0.4-0.6, adım 0.1)

    # --- Stochastic (genelde sabit) ---
    stoch_k: int = 500            # Stochastic K periyodu
    stoch_smooth: int = 200       # Stochastic VMA smooth periyodu

    def get_max_period(self) -> int:
        return self.stoch_k + self.stoch_smooth + 50


class TOTT_HOTTStrategy:
    """TOTT_HOTT (Strategy 6) — Referans Doküman Formülü"""

    def __init__(self,
                 opens: List[float],
                 highs: List[float],
                 lows: List[float],
                 closes: List[float],
                 typical: List[float],
                 times: List[datetime],
                 volumes: Optional[List[float]] = None,
                 config: Optional[StrategyConfigTottHott] = None,
                 config_dict: Optional[Dict[str, Any]] = None):

        self.n = len(closes)
        self.opens = opens
        self.highs = highs
        self.lows = lows
        self.closes = closes
        self.typical = typical
        self.times = times
        self.volumes = volumes

        self.config = config or StrategyConfigTottHott()
        if config_dict:
            for key, value in config_dict.items():
                if hasattr(self.config, key):
                    setattr(self.config, key, value)

        self.warmup_bars = self.config.get_max_period()
        self._calculate_indicators()

    def _calculate_indicators(self):
        """Referans Doküman formülüne göre indikatörler."""
        cfg = self.config
        C = self.closes
        H = self.highs
        L = self.lows

        # --- Trend ---
        self.mov = MA(C, "variable", cfg.ott_period)
        self.ott_big, _ = OTT(C, cfg.ott_period, cfg.ott_pct_big, "variable")
        self.ott_small, _ = OTT(C, cfg.ott_period, cfg.ott_pct_small, "variable")

        # --- Bölge ---
        raw_stoch = StochasticFast(H, L, C, cfg.stoch_k)
        stoch_vma = MA(raw_stoch, "variable", cfg.stoch_smooth)
        self.stosk_x = [v + 1000.0 for v in stoch_vma]
        self.sott, _ = OTT(self.stosk_x, 2, cfg.sott_pct, "variable")

        # --- Kapı ---
        half = max(1, cfg.gate_period // 2)
        self.hhv_full = HHV(H, cfg.gate_period)
        self.llv_full = LLV(L, cfg.gate_period)
        hhv_half = HHV(H, half)
        llv_half = LLV(L, half)
        self.hott, _ = OTT(hhv_half, 2, cfg.gate_pct, "variable")
        self.lott, _ = OTT(llv_half, 2, cfg.gate_pct, "variable")

    def get_signal(self, i: int, current_position: str,
                   entry_price: float = 0,
                   extreme_price: float = 0,
                   return_flat_reason: bool = False) -> Signal:

        if i < self.warmup_bars or i < 1:
            return (Signal.NONE, None) if return_flat_reason else Signal.NONE

        cfg = self.config
        mov_i = self.mov[i]
        H_i = self.highs[i]
        L_i = self.lows[i]
        sx_i = self.stosk_x[i]
        sott_i = self.sott[i]
        hhv_prev = self.hhv_full[i - 1]
        llv_prev = self.llv_full[i - 1]

        # Kapı koşulları
        hott_gate = (H_i > self.hott[i]) and (H_i > hhv_prev)
        lott_gate = (L_i < self.lott[i]) and (L_i < llv_prev)

        # Bölge
        sott_long = sx_i > sott_i
        sott_short = sx_i < sott_i

        # Band katsayısı
        mult_up = 1.0 + cfg.ott_mult
        mult_dn = 1.0 - cfg.ott_mult

        # AL Koşulları
        if mov_i > self.ott_big[i]:
            # Ana trend yukarı: OTT_small ile band check
            al = (mov_i > self.ott_small[i] * mult_up) and sott_long and hott_gate
        else:
            # Fallback: MOV > OTT_small VE MOV > OTT_small * mult
            al = (mov_i > self.ott_small[i]) and \
                 (mov_i > self.ott_small[i] * mult_up) and \
                 sott_long and hott_gate

        # SAT Koşulları
        if mov_i > self.ott_big[i]:
            sat = (mov_i < self.ott_small[i] * mult_dn) and sott_short and lott_gate
        else:
            sat = (mov_i < self.ott_small[i]) and sott_short and lott_gate

        signal = Signal.NONE
        if al:
            signal = Signal.LONG
        elif sat:
            signal = Signal.SHORT

        return (signal, None) if return_flat_reason else signal

    def generate_all_signals(self, mask: Optional[np.ndarray] = None, yon_modu: str = "CIFT") -> tuple:
        signals = np.zeros(self.n, dtype=int)
        exits_long = np.zeros(self.n, dtype=bool)
        exits_short = np.zeros(self.n, dtype=bool)
        position = "FLAT"

        for i in range(self.warmup_bars, self.n):
            # Vade sonu maskesi kontrolü: Eğer mask False ise pozisyonu kapat
            if mask is not None and not mask[i]:
                if position == "LONG":
                    exits_long[i] = True
                elif position == "SHORT":
                    exits_short[i] = True
                position = "FLAT"
                continue

            sig = self.get_signal(i, position)
            
            # Yön Modu Filtreleri
            if yon_modu == "SADECE_AL" and sig == Signal.SHORT:
                sig = Signal.NONE
            elif yon_modu == "SADECE_SAT" and sig == Signal.LONG:
                sig = Signal.NONE

            if sig == Signal.LONG:
                if position != "LONG":
                    signals[i] = 1
                    if position == "SHORT": exits_short[i] = True
                    position = "LONG"
            elif sig == Signal.SHORT:
                if position != "SHORT":
                    signals[i] = -1
                    if position == "LONG": exits_long[i] = True
                    position = "SHORT"
            elif sig == Signal.FLAT:
                if position == "LONG": exits_long[i] = True
                elif position == "SHORT": exits_short[i] = True
                position = "FLAT"

        return signals, exits_long, exits_short

    @classmethod
    def from_config_dict(cls, data_cache, config_dict: dict, times=None):
        """Optimizer ve WFA fabrika metodu"""
        valid_keys = {f.name for f in __import__('dataclasses').fields(StrategyConfigTottHott)}
        config = StrategyConfigTottHott(**{k: v for k, v in config_dict.items() if k in valid_keys})

        def _get(obj, key, fallback=None):
            if hasattr(obj, key): return list(getattr(obj, key))
            if isinstance(obj, dict): return obj.get(key, fallback)
            return fallback

        return cls(
            opens=_get(data_cache, 'opens', []),
            highs=_get(data_cache, 'highs', []),
            lows=_get(data_cache, 'lows', []),
            closes=_get(data_cache, 'closes', []),
            typical=_get(data_cache, 'typical', _get(data_cache, 'closes', [])),
            times=times or _get(data_cache, 'times', []),
            volumes=_get(data_cache, 'volumes', None),
            config=config,
        )
