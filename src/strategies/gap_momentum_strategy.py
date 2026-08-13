"""
Gap Momentum Strategy (Strateji 9) — S9 v1.0
=============================================
BIST30 vadeli piyasasında gece gap'lerinin YÖNÜNDE işlem yapar.

Gap günlerinin %56'sında OR önce gap yönünde kırılır (momentum).
S8 bu günleri kaçırır. S9 tam bu günleri hedefler.

Karar mantığı:
  S9: OR gap yönünde kırılırsa tetiklenir (MOM)
  S8: OR gap tersine kırılırsa tetiklenir (REV)
  Her gün ikisinden biri — çakışma yok.

S9 parametreleri:
  or_bars     : 1 (OR1)
  t1_mult     : 0.75 (T1 = giriş + OR × 0.75)
  t2_mult     : 1.25 (T2 = giriş + OR × 1.25)
  stop_mult   : 0.5  (Stop = giriş - OR × 0.5)
  trailing    : KULLANILMIYOR (sabit hedef daha iyi)
  piramit     : T1'de 2. lot
  zaman_stop  : 300 bar (~15:00)
  max_gap     : 150 puan (>200p MAE çok yüksek)
  Pazartesi   : AKTİF (momentum için iyi gün, %80 kazanma)
"""

from __future__ import annotations

import numpy as np
from types import SimpleNamespace
from typing import Any

from src.strategies.base_strategy import BaseStrategy
from src.engine.types import StrategyConfig


class GapMomentumConfig(StrategyConfig):
    """S9 Gap Momentum v1.0 parametreleri."""

    def __init__(self, **kwargs):
        super().__init__(**kwargs)
        # Katman 1 — Gap filtre
        self.min_gap_puan  = float(kwargs.get('min_gap_puan', 10.0))
        self.max_gap_puan  = float(kwargs.get('max_gap_puan', 150.0))  # 100p DEĞİL, 150p!
        # Katman 2 — Opening Range
        self.or_bars       = int(kwargs.get('or_bars', 1))
        # Katman 3 — Hedefler (OR katı cinsinden)
        self.t1_mult       = float(kwargs.get('t1_mult', 0.75))   # T1 = OR × 0.75x
        self.t2_mult       = float(kwargs.get('t2_mult', 1.25))   # T2 = OR × 1.25x (en iyi net)
        # Katman 4 — Stop (OR katı)
        self.stop_mult     = float(kwargs.get('stop_mult', 0.5))   # Stop = OR × 0.5x
        # Katman 5 — Piramit
        self.piramit_aktif = bool(kwargs.get('piramit_aktif', True))
        # Katman 6 — Zaman stopu
        self.gap_window_bars = int(kwargs.get('gap_window_bars', 300))  # ~15:00
        # Genel
        self.cooldown_bars = int(kwargs.get('cooldown_bars', 3))
        self.yon_modu      = str(kwargs.get('yon_modu', 'CIFT'))


class GapMomentumStrategy(BaseStrategy):
    """
    S9: Gap Momentum v1.0

    Katmanlar
    ---------
    1. Gece gap tespiti (09:25 barı, akşam 22:59 referansı)
       - min_gap_puan <= gap_abs <= max_gap_puan
    2. OR1 oluşumu (1 dakika bar)
    3. OR gap YÖNÜNDE kırılırsa giriş (gap yönünde momentum)
       UP gap  → High > OR_High → LONG @ OR_High (şartlı emir sim.)
       DOWN gap→ Low  < OR_Low  → SHORT @ OR_Low
    4. Stop: giriş - OR × stop_mult (UP/LONG) | giriş + OR × stop_mult (DOWN/SHORT)
    5. T1: giriş + OR × t1_mult → piramit (2. lot)
    6. T2: giriş + OR × t2_mult → kalan kapatılır
    7. Trailing stop: KULLANILMIYOR (sabit hedef daha iyi)
    8. Zaman stopu: OR bitişinden gap_window_bars bar (~15:00)
    9. Akşam: 22:50'de kapat

    Not: S8'in ters sinyali olmayan günlerde tetiklenir (OR yönüne göre).
    """

    def __init__(self, config: GapMomentumConfig):
        super().__init__(config)
        self.config = config

    @classmethod
    def from_config_dict(cls, cache: Any, params: dict, dates=None) -> 'GapMomentumStrategy':
        config = GapMomentumConfig(**params)
        instance = cls(config)
        if isinstance(cache, dict):
            instance._cache = SimpleNamespace(**cache)
        else:
            instance._cache = cache
        return instance

    # ------------------------------------------------------------------
    # Ana sinyal üretimi
    # ------------------------------------------------------------------

    def generate_all_signals(self):
        """
        Backtest uyumlu sinyal + çıkış dizileri döndür.
        Returns: (signals np.int8, exits_long bool[], exits_short bool[])
        """
        cache  = self._cache
        closes = np.asarray(cache.closes, dtype=np.float64)
        highs  = np.asarray(cache.highs,  dtype=np.float64)
        lows   = np.asarray(cache.lows,   dtype=np.float64)
        opens  = np.asarray(cache.opens,  dtype=np.float64)
        dates  = getattr(cache, 'dates', None)

        n = len(closes)
        signals     = np.zeros(n, dtype=np.int8)
        exits_long  = np.zeros(n, dtype=np.bool_)
        exits_short = np.zeros(n, dtype=np.bool_)

        # ---------------------------------------------------------------
        # Durum değişkenleri
        # ---------------------------------------------------------------
        in_long = in_short = False
        entry_price   = 0.0
        stop_level    = 0.0
        t1_lvl        = 0.0
        t2_lvl        = 0.0
        t1_hit        = False
        lot_scale     = 1
        bars_in_pos   = 0
        cooldown_ct   = 0

        gap_active    = False
        gap_dir       = 0
        or_complete   = False
        or_start_bar  = -1
        or_high       = 0.0
        or_low        = float('inf')
        or_range      = 0.0
        pos_start_bar = -1

        last_aksam_close = 0.0

        warm_bars = 60

        for i in range(warm_bars, n):
            if cooldown_ct > 0:
                cooldown_ct -= 1

            # ----------------------------------------------------------
            # Saat dilimi
            # ----------------------------------------------------------
            emir_toplama = gun_seansi = aksam_seansi = False
            saat_fark = 0.0

            if dates is not None and i < len(dates):
                try:
                    dt  = dates[i]
                    dtp = dates[i - 1]
                    th  = dt.hour + dt.minute / 60.0
                    emir_toplama = (9 + 25/60) <= th < (9 + 30/60)
                    gun_seansi   = (9 + 30/60) <= th <= (18 + 10/60)
                    aksam_seansi = 19.0 <= th <= (22 + 59/60)
                    saat_fark    = (dt.timestamp() - dtp.timestamp()) / 3600.0
                except Exception:
                    gun_seansi = True
            else:
                gun_seansi = True

            if not (emir_toplama or gun_seansi or aksam_seansi):
                continue

            # Akşam kapanışı güncelle
            if aksam_seansi and dates is not None and i < len(dates):
                if dates[i].hour >= 22 and dates[i].minute >= 55:
                    last_aksam_close = closes[i]

            # ----------------------------------------------------------
            # Katman 1: Gece gap tespiti (09:25 barı)
            # ----------------------------------------------------------
            gece_sonrasi = (6.0 < saat_fark < 15.0) and emir_toplama

            if gece_sonrasi:
                # Açık pozisyon kapat
                if in_long:
                    exits_long[i] = True
                    in_long = False; bars_in_pos = 0
                    cooldown_ct = self.config.cooldown_bars
                    entry_price = stop_level = 0.0
                    t1_hit = False; lot_scale = 1; pos_start_bar = -1
                elif in_short:
                    exits_short[i] = True
                    in_short = False; bars_in_pos = 0
                    cooldown_ct = self.config.cooldown_bars
                    entry_price = stop_level = 0.0
                    t1_hit = False; lot_scale = 1; pos_start_bar = -1

                ref_close = last_aksam_close if last_aksam_close > 0 else closes[i - 1]
                teorik    = closes[i]
                raw_gap   = teorik - ref_close
                gap_abs   = abs(raw_gap)

                gap_active = (self.config.min_gap_puan <= gap_abs <= self.config.max_gap_puan)
                gap_dir    = 1 if raw_gap > 0.0 else -1

                or_complete  = False
                or_start_bar = i if gap_active else -1
                or_high      = highs[i]
                or_low       = lows[i]
                or_range     = 0.0
                pos_start_bar = -1
                last_aksam_close = 0.0

            # ----------------------------------------------------------
            # Katman 2: OR oluşumu
            # ----------------------------------------------------------
            if gap_active and not or_complete and or_start_bar >= 0 and gun_seansi:
                elapsed = i - or_start_bar
                if elapsed < self.config.or_bars:
                    if highs[i] > or_high: or_high = highs[i]
                    if lows[i]  < or_low:  or_low  = lows[i]
                else:
                    or_range    = or_high - or_low
                    or_complete = True

            # OR range sıfırsa giriş yapma (düz bar)
            if or_complete and or_range < 1.0:
                gap_active = False

            # ----------------------------------------------------------
            # Katman 3: Giriş — Gap YÖNÜNDE OR kırılımı
            # ----------------------------------------------------------
            giris_on_kosul = (
                gun_seansi and gap_active and or_complete and
                not in_long and not in_short and
                cooldown_ct == 0 and pos_start_bar < 0
            )

            if giris_on_kosul:
                or_end_bar = or_start_bar + self.config.or_bars
                zaman_ok   = (i - or_end_bar) < self.config.gap_window_bars

                if zaman_ok:
                    # UP gap → LONG: High OR_High'ı yukarı kırarsa (gap yönünde)
                    if gap_dir == 1 and self.config.yon_modu != 'SADECE_SAT':
                        if highs[i] >= or_high:
                            t1_dist    = or_range * self.config.t1_mult
                            t2_dist    = or_range * self.config.t2_mult
                            stop_dist  = or_range * self.config.stop_mult
                            signals[i] = 1
                            in_long    = True
                            entry_price   = or_high
                            stop_level    = or_high - stop_dist
                            t1_lvl        = or_high + t1_dist
                            t2_lvl        = or_high + t2_dist
                            t1_hit        = False
                            lot_scale     = 1
                            bars_in_pos   = 0
                            pos_start_bar = i

                    # DOWN gap → SHORT: Low OR_Low'u aşağı kırarsa
                    if gap_dir == -1 and self.config.yon_modu != 'SADECE_AL' and not in_long:
                        if lows[i] <= or_low:
                            t1_dist    = or_range * self.config.t1_mult
                            t2_dist    = or_range * self.config.t2_mult
                            stop_dist  = or_range * self.config.stop_mult
                            signals[i] = -1
                            in_short   = True
                            entry_price   = or_low
                            stop_level    = or_low + stop_dist
                            t1_lvl        = or_low - t1_dist
                            t2_lvl        = or_low - t2_dist
                            t1_hit        = False
                            lot_scale     = 1
                            bars_in_pos   = 0
                            pos_start_bar = i

            # ----------------------------------------------------------
            # Çıkış — LONG
            # ----------------------------------------------------------
            if in_long:
                bars_in_pos += 1
                th_now = (dates[i].hour + dates[i].minute / 60.0
                          if (dates is not None and i < len(dates)) else 0.0)

                if not t1_hit and highs[i] >= t1_lvl:
                    t1_hit = True
                    if self.config.piramit_aktif:
                        lot_scale = 2

                stop_hit    = lows[i] <= stop_level    # sabit stop (trailing yok!)
                t2_hit_flag = highs[i] >= t2_lvl
                zaman_doldu = pos_start_bar > 0 and (i - pos_start_bar) >= self.config.gap_window_bars
                aksam_kapa  = aksam_seansi and th_now >= (22 + 50/60)

                if t2_hit_flag or stop_hit or zaman_doldu or aksam_kapa:
                    exits_long[i] = True
                    in_long       = False
                    gap_active    = False
                    cooldown_ct   = self.config.cooldown_bars
                    bars_in_pos   = 0
                    entry_price   = stop_level = 0.0
                    t1_hit        = False; lot_scale = 1
                    pos_start_bar = -1

            # ----------------------------------------------------------
            # Çıkış — SHORT
            # ----------------------------------------------------------
            if in_short:
                bars_in_pos += 1
                th_now = (dates[i].hour + dates[i].minute / 60.0
                          if (dates is not None and i < len(dates)) else 0.0)

                if not t1_hit and lows[i] <= t1_lvl:
                    t1_hit = True
                    if self.config.piramit_aktif:
                        lot_scale = 2

                stop_hit    = highs[i] >= stop_level   # sabit stop
                t2_hit_flag = lows[i] <= t2_lvl
                zaman_doldu = pos_start_bar > 0 and (i - pos_start_bar) >= self.config.gap_window_bars
                aksam_kapa  = aksam_seansi and th_now >= (22 + 50/60)

                if t2_hit_flag or stop_hit or zaman_doldu or aksam_kapa:
                    exits_short[i] = True
                    in_short        = False
                    gap_active      = False
                    cooldown_ct     = self.config.cooldown_bars
                    bars_in_pos     = 0
                    entry_price     = stop_level = 0.0
                    t1_hit          = False; lot_scale = 1
                    pos_start_bar   = -1

        return signals, exits_long, exits_short
