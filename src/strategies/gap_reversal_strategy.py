"""
Gap Reversal Strategy (Strateji 8) — S8 v1.0
BIST30 vadeli piyasasında gece gap'lerinin tersine işlem yapar.
Gap tespit → Opening Range → Ters kırılma → RSI/Hacim onayı → Gap fill hedefi.
"""

from __future__ import annotations

import numpy as np
from types import SimpleNamespace
from typing import Any

from src.strategies.base_strategy import BaseStrategy
from src.engine.types import StrategyConfig
from src.indicators.core import get_atr


class GapReversalConfig(StrategyConfig):
    """S8 Gap Reversal parametreleri."""

    def __init__(self, **kwargs):
        super().__init__(**kwargs)
        # Katman 1 — Gap filtre
        self.min_gap_pct = float(kwargs.get('min_gap_pct', 0.05))
        self.max_gap_pct = float(kwargs.get('max_gap_pct', 2.00))
        self.cuma_aktif = bool(kwargs.get('cuma_aktif', False))
        # Katman 2 — Opening Range
        self.or_bars = int(kwargs.get('or_bars', 15))
        # Katman 4 — RSI
        self.rsi_filtre_aktif = bool(kwargs.get('rsi_filtre_aktif', True))
        self.rsi_period = int(kwargs.get('rsi_period', 5))
        self.rsi_ob = float(kwargs.get('rsi_ob', 62.0))
        self.rsi_os = float(kwargs.get('rsi_os', 38.0))
        # Katman 5 — Hacim
        self.hacim_filtre_aktif = bool(kwargs.get('hacim_filtre_aktif', True))
        self.hacim_ma_period = int(kwargs.get('hacim_ma_period', 20))
        self.hacim_oran = float(kwargs.get('hacim_oran', 0.8))
        # Katman 6 — ATR stop
        self.atr_period = int(kwargs.get('atr_period', 14))
        self.atr_stop_mult = float(kwargs.get('atr_stop_mult', 0.5))
        # Katman 8 — Zaman stopu
        self.gap_window_bars = int(kwargs.get('gap_window_bars', 210))
        # Genel
        self.cooldown_bars = int(kwargs.get('cooldown_bars', 3))
        self.yon_modu = str(kwargs.get('yon_modu', 'CIFT'))


class GapReversalStrategy(BaseStrategy):
    """
    S8: Gap Reversal v1.0

    Katmanlar
    ---------
    1. Gece gap tespiti (MIN/MAX filtre, cuma filtresi)
    2. Opening Range oluşumu (OR_BARS kadar)
    3. OR kırılması — gap yönünün TERSİNDE giriş
    4. Wilder RSI(5) onayı (toggle)
    5. Hacim onayı (toggle)
    6. ATR tabanlı stop (OR extreme + ATR çarpan)
    7. Gap fill hedefi (prevClose)
    8. Zaman stopu (~3.5 saat)
    9. Akşam seansı koruması
    """

    def __init__(self, config: GapReversalConfig):
        super().__init__(config)
        self.config = config

    @classmethod
    def from_config_dict(cls, cache: Any, params: dict, dates=None) -> 'GapReversalStrategy':
        """
        IndicatorCache nesnesi VEYA plain dict ile çalışır.
        dates keyword arg geriye dönük uyumluluk içindir.
        """
        config = GapReversalConfig(**params)
        instance = cls(config)
        # Dict → SimpleNamespace dönüşümü
        if isinstance(cache, dict):
            instance._cache = SimpleNamespace(**cache)
        else:
            instance._cache = cache
        return instance

    # ------------------------------------------------------------------
    # Yardımcılar
    # ------------------------------------------------------------------

    @staticmethod
    def _wilder_rsi(closes: np.ndarray, period: int) -> np.ndarray:
        """C# ile birebir aynı Wilder RSI hesabı."""
        n = len(closes)
        rsi = np.full(n, 50.0, dtype=np.float64)
        ag = al = 0.0
        for j in range(1, n):
            delta = closes[j] - closes[j - 1]
            gain = delta if delta > 0.0 else 0.0
            loss = -delta if delta < 0.0 else 0.0
            if j < period:
                ag += gain
                al += loss
            elif j == period:
                ag = (ag + gain) / period
                al = (al + loss) / period
                rsi[j] = 50.0 if al == 0.0 else 100.0 - (100.0 / (1.0 + ag / al))
            else:
                ag = (ag * (period - 1) + gain) / period
                al = (al * (period - 1) + loss) / period
                rsi[j] = 50.0 if al == 0.0 else 100.0 - (100.0 / (1.0 + ag / al))
        return rsi

    @staticmethod
    def _simple_sma(arr: np.ndarray, period: int) -> np.ndarray:
        result = np.zeros(len(arr), dtype=np.float64)
        for i in range(period, len(arr)):
            result[i] = arr[i - period:i].mean()
        return result

    # ------------------------------------------------------------------
    # Ana sinyal üretimi
    # ------------------------------------------------------------------

    def generate_all_signals(self):
        """
        Backtest uyumlu sinyal + çıkış dizileri döndür.
        Returns: (signals np.int8, exits_long bool[], exits_short bool[])
        """
        cache = self._cache
        closes = np.asarray(cache.closes, dtype=np.float64)
        highs  = np.asarray(cache.highs,  dtype=np.float64)
        lows   = np.asarray(cache.lows,   dtype=np.float64)
        opens  = np.asarray(cache.opens,  dtype=np.float64)
        try:
            volumes = np.asarray(cache.volumes, dtype=np.float64)
        except AttributeError:
            volumes = np.asarray(cache.lots, dtype=np.float64)

        # dates — IndicatorCache.dates veya SimpleNamespace.dates
        dates = getattr(cache, 'dates', None)

        n = len(closes)

        # Göstergeler
        atr      = get_atr(highs, lows, closes, self.config.atr_period)
        vol_ma   = self._simple_sma(volumes, self.config.hacim_ma_period)
        rsi      = self._wilder_rsi(closes, self.config.rsi_period)

        signals     = np.zeros(n, dtype=np.int8)
        exits_long  = np.zeros(n, dtype=np.bool_)
        exits_short = np.zeros(n, dtype=np.bool_)

        # Durum değişkenleri
        in_long = in_short = False
        entry_price = stop_level = 0.0
        bars_in_pos = cooldown_ct = 0

        # Gap durumu
        gap_active  = False
        gap_fill_lvl = 0.0
        gap_dir      = 0      # +1 yukarı gap, -1 aşağı gap
        or_complete  = False
        or_start_bar = -1
        or_high      = 0.0
        or_low       = float('inf')
        pos_start_bar = -1

        warm_bars = max(self.config.atr_period, self.config.hacim_ma_period,
                        self.config.rsi_period) + 30

        for i in range(warm_bars, n):
            if cooldown_ct > 0:
                cooldown_ct -= 1

            # ----------------------------------------------------------
            # Saat dilimi belirleme
            # ----------------------------------------------------------
            emir_toplama = gun_seansi = aksam_seansi = False
            saat_fark = 0.0
            is_friday = False

            if dates is not None and i < len(dates):
                try:
                    dt   = dates[i]
                    dt_p = dates[i - 1]
                    # Saat tespit
                    t_h = dt.hour + dt.minute / 60.0 + dt.second / 3600.0
                    emir_toplama  = (9 + 25/60) <= t_h < (9 + 30/60)
                    gun_seansi    = (9 + 30/60) <= t_h <= (18 + 9/60 + 59/3600)
                    aksam_seansi  = 19.0       <= t_h <= (22 + 59/60 + 59/3600)
                    # Gece farkı
                    saat_fark = (dt.timestamp() - dt_p.timestamp()) / 3600.0
                    # Cuma kontrolü
                    is_friday = (dt.weekday() == 4)
                except Exception:
                    # dates parse edilemezse ya hep geç ya da gun_seansi=True varsay
                    gun_seansi = True
            else:
                # Tarih yoksa sabahı atlayan mantık çalışamaz — tüm bar işlensin
                gun_seansi = True

            # Aktif seans değilse atla
            if not (emir_toplama or gun_seansi or aksam_seansi):
                continue

            # ----------------------------------------------------------
            # Katman 1: Gece gap tespiti (09:25 emir toplama barı)
            # ----------------------------------------------------------
            gece_sonrasi = (6.0 < saat_fark < 15.0) and emir_toplama

            if gece_sonrasi:
                # Gece kalan açık pozisyonu zorla kapat
                if in_long:
                    exits_long[i]  = True
                    in_long        = False
                    bars_in_pos    = 0
                    cooldown_ct    = self.config.cooldown_bars
                    entry_price    = stop_level = 0.0
                    pos_start_bar  = -1
                elif in_short:
                    exits_short[i] = True
                    in_short       = False
                    bars_in_pos    = 0
                    cooldown_ct    = self.config.cooldown_bars
                    entry_price    = stop_level = 0.0
                    pos_start_bar  = -1

                # Yeni gap hesapla
                prev_close = closes[i - 1]
                today_open = opens[i]
                raw_gap    = today_open - prev_close
                raw_gap_pct = abs(raw_gap / prev_close) * 100.0 if prev_close > 0.0 else 0.0

                cuma_ok = (not is_friday) or self.config.cuma_aktif
                gap_active   = (
                    raw_gap_pct >= self.config.min_gap_pct and
                    raw_gap_pct <= self.config.max_gap_pct and
                    cuma_ok
                )
                gap_fill_lvl  = prev_close
                gap_dir       = 1 if raw_gap > 0.0 else -1

                or_complete  = False
                or_start_bar = i if gap_active else -1
                or_high      = highs[i]
                or_low       = lows[i]
                pos_start_bar = -1

            # ----------------------------------------------------------
            # Katman 2: Opening Range güncelleme (gün seansı barları)
            # ----------------------------------------------------------
            if gap_active and not or_complete and or_start_bar >= 0:
                if gun_seansi:
                    elapsed = i - or_start_bar
                    if elapsed < self.config.or_bars:
                        if highs[i] > or_high:
                            or_high = highs[i]
                        if lows[i] < or_low:
                            or_low = lows[i]
                    else:
                        or_complete = True

            # ----------------------------------------------------------
            # Katman 3-5: Giriş mantığı
            # ----------------------------------------------------------
            giris_on_kosul = (
                gun_seansi and gap_active and or_complete and
                not in_long and not in_short and
                cooldown_ct == 0 and pos_start_bar < 0
            )

            if giris_on_kosul:
                or_end_bar = or_start_bar + self.config.or_bars
                zaman_ok   = (i - or_end_bar) < self.config.gap_window_bars

                hacim_ok = (
                    not self.config.hacim_filtre_aktif or
                    (vol_ma[i] > 0 and volumes[i] >= vol_ma[i] * self.config.hacim_oran)
                )

                # Yukarı gap → SHORT
                if (gap_dir == 1 and
                        self.config.yon_modu != 'SADECE_AL'):
                    or_kirildi  = closes[i] < or_low
                    fill_olmadi = closes[i] > gap_fill_lvl
                    rsi_ok = (
                        not self.config.rsi_filtre_aktif or
                        rsi[i] > self.config.rsi_ob
                    )
                    if zaman_ok and or_kirildi and fill_olmadi and hacim_ok and rsi_ok:
                        signals[i]    = -1
                        in_short      = True
                        entry_price   = closes[i]
                        stop_level    = or_high + atr[i] * self.config.atr_stop_mult
                        bars_in_pos   = 0
                        pos_start_bar = i

                # Aşağı gap → LONG
                if (gap_dir == -1 and
                        self.config.yon_modu != 'SADECE_SAT' and
                        not in_short):
                    or_kirildi  = closes[i] > or_high
                    fill_olmadi = closes[i] < gap_fill_lvl
                    rsi_ok = (
                        not self.config.rsi_filtre_aktif or
                        rsi[i] < self.config.rsi_os
                    )
                    if zaman_ok and or_kirildi and fill_olmadi and hacim_ok and rsi_ok:
                        signals[i]    = 1
                        in_long       = True
                        entry_price   = closes[i]
                        stop_level    = or_low - atr[i] * self.config.atr_stop_mult
                        bars_in_pos   = 0
                        pos_start_bar = i

            # ----------------------------------------------------------
            # Katmanlar 6-9: Çıkış mantığı
            # ----------------------------------------------------------
            if in_long:
                bars_in_pos += 1
                t_h_now = (dates[i].hour + dates[i].minute / 60.0
                           if (dates is not None and i < len(dates))
                           else 0.0)
                stop_hit    = lows[i] <= stop_level
                target_hit  = highs[i] >= gap_fill_lvl or closes[i] >= gap_fill_lvl
                zaman_doldu = pos_start_bar > 0 and (i - pos_start_bar) >= self.config.gap_window_bars
                aksam_kapa  = aksam_seansi and t_h_now >= (22 + 50/60)
                ters        = closes[i] < or_low and bars_in_pos > 3

                if stop_hit or target_hit or zaman_doldu or aksam_kapa or ters:
                    exits_long[i] = True
                    in_long       = False
                    gap_active    = False
                    cooldown_ct   = self.config.cooldown_bars
                    bars_in_pos   = 0
                    entry_price   = stop_level = 0.0
                    pos_start_bar = -1

            if in_short:
                bars_in_pos += 1
                t_h_now = (dates[i].hour + dates[i].minute / 60.0
                           if (dates is not None and i < len(dates))
                           else 0.0)
                stop_hit    = highs[i] >= stop_level
                target_hit  = lows[i] <= gap_fill_lvl or closes[i] <= gap_fill_lvl
                zaman_doldu = pos_start_bar > 0 and (i - pos_start_bar) >= self.config.gap_window_bars
                aksam_kapa  = aksam_seansi and t_h_now >= (22 + 50/60)
                ters        = closes[i] > or_high and bars_in_pos > 3

                if stop_hit or target_hit or zaman_doldu or aksam_kapa or ters:
                    exits_short[i] = True
                    in_short       = False
                    gap_active     = False
                    cooldown_ct    = self.config.cooldown_bars
                    bars_in_pos    = 0
                    entry_price    = stop_level = 0.0
                    pos_start_bar  = -1

        return signals, exits_long, exits_short
