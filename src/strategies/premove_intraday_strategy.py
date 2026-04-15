# -*- coding: utf-8 -*-
"""
S9: PreMove Intraday Strategy
=================================
PreMove Scanner v3.0'ın puan sistemini VIOP 1dk/5dk barlarına uygular.

%100 iDeal Uyumu Garantisi:
  Her hesap fonksiyonu Robot_PreMove_Intraday_S9.txt C# koduyla
  birebir eşleşir. Satır referansları C# dosyasına verilmiştir.

Puan Sistemi (v3.0 ağırlıkları):
  EMA Hizalaması      0-20p   [C# satır ~206-213]
  Up Volume Ratio     0-45p   [C# satır ~219-230]
  VCP + NR7          0-30p   [C# satır ~271-333]
  Pocket Pivot Ceza  -10/-5p  [C# satır ~238-258]
  BB Squeeze          0- 6p   [C# satır ~363-390]
  Pozisyon Bonusu     0- 2p   [C# satır ~393-396]
  Şımarık Tuzağı      -20p   [C# satır ~401-402]
"""

from __future__ import annotations

import numpy as np
import pandas as pd
from dataclasses import dataclass, field
from typing import List, Optional, Any, Tuple
from types import SimpleNamespace

from src.indicators.core import EMA, SMA, HHV, LLV, ATR


# ───────────────────────────────────────────────────────────────────
# KONFİGÜRASYON
# ───────────────────────────────────────────────────────────────────

@dataclass
class PreMoveIntradayConfig:
    """
    S9 PreMove Intraday strateji parametreleri.
    Tüm default değerler Robot_PreMove_Intraday_S9.txt ile eşleşir.
    """
    # Puan Eşikleri
    esik_yuksek:    int   = 65      # Giriş eşiği (≥ bu puan → LONG)
    esik_takip:     int   = 45      # Çıkış eşiği (< bu puan → FLAT)

    # EMA Hizalaması (PreMove: 9/21/50/200)
    ema1:           int   = 9
    ema2:           int   = 21
    ema3:           int   = 50
    ema4:           int   = 200

    # Up Volume Ratio
    upvol_lookback: int   = 20      # Son kaç bar bakılacak
    # (VolMA periyodu zaten 20, upvol_lookback ile aynı)

    # VCP
    vcp_lookback:   int   = 60      # Pivot tespit penceresi (bar)

    # BB Squeeze
    bb_squeeze_win: int   = 20      # Mevcut ATR% hesap penceresi
    bb_squeeze_lb:  int   = 126     # Tarihsel karşılaştırma penceresi
    bb_squeeze_pct: float = 0.85    # Persentil eşiği (alt %15)

    # Pocket Pivot
    pp_lookback:    int   = 10      # Kaç barlık düşen hacim penceresi

    # Pozisyon Bonusu
    base_lookback:  int   = 40      # HHV/LLV penceresi

    # Şımarık Tuzağı
    simarik_pct:    float = 1.5     # %: 5dk için 1.5, 1dk için 0.8

    # ATR Trailing Stop (çıkış)
    atr_period:     int   = 14
    atr_stop_mult:  float = 2.0

    # Genel
    yon_modu:       str   = "SADECE_AL"   # SADECE_AL / CIFT
    warmup_bars:    int   = 250


# ───────────────────────────────────────────────────────────────────
# STRATEJİ
# ───────────────────────────────────────────────────────────────────

class PreMoveIntradayStrategy:
    """
    S9 PreMove Intraday Strategy.
    generate_all_signals() → (signals, exits_long, exits_short)

    %100 uyumluluk notu:
      - BB Squeeze: SMA-bazlı ATR% (core.py ATR() Wilder değil!)
      - VCP: PreMove Scanner C# pivot algoritmasının birebir kopyası
      - Diğer EMA/SMA: core.py EMA/SMA → iDeal Exp/Simple ile aynı
    """

    def __init__(self,
                 opens:   List[float],
                 highs:   List[float],
                 lows:    List[float],
                 closes:  List[float],
                 volumes: List[float],
                 config:  Optional[PreMoveIntradayConfig] = None,
                 dates=None):

        self.opens   = opens
        self.highs   = highs
        self.lows    = lows
        self.closes  = closes
        self.volumes = volumes
        self.config  = config or PreMoveIntradayConfig()
        self.dates   = dates
        self.n       = len(closes)

        self._precompute()

    # ── Ön Hesaplamalar ──────────────────────────────────────────

    def _precompute(self):
        """Tüm indikatörleri üretir + BB Squeeze ATR% önbelleği."""
        cfg = self.config

        # EMA Stack — core.py EMA() = IdealData Exp ile %100 uyumlu
        self.ema_9   = EMA(self.closes, cfg.ema1)
        self.ema_21  = EMA(self.closes, cfg.ema2)
        self.ema_50  = EMA(self.closes, cfg.ema3)
        self.ema_200 = EMA(self.closes, cfg.ema4)

        # Hacim SMA (VolMA20)
        self.vol_ma20 = SMA(self.volumes, 20)

        # ATR Wilder — trailing stop için (IdealData Sistem.ATR ile uyumlu)
        self.atr_vals = ATR(self.highs, self.lows, self.closes, cfg.atr_period)

        # HHV/LLV — pozisyon bonusu için
        self.hhv_40 = HHV(self.highs, cfg.base_lookback)
        self.llv_40 = LLV(self.lows,  cfg.base_lookback)

        # BB Squeeze ATR% — SMA bazlı, PreMove C# ile birebir uyumlu
        # (core.py ATR() Wilder kullanır; BB Squeeze için SMA gerekli)
        self._precompute_atr_pct_bb()

    def _precompute_atr_pct_bb(self):
        """
        Her bar için SMA-bazlı ATR% üret.
        BB Squeeze'de kullanılan formül (PreMove C# satır 363-373):
          TR_k = max(H-L, |H-C_prev|, |L-C_prev|)  [k>=1]
          ATR%(i) = SUM(TR[i-19:i+1]) / (20 * C[i])  [i>=20]
        
        %100 uyumluluk: pandas rolling sum (SMA değil sum, sonra bölüyoruz)
        """
        n = self.n
        H = np.asarray(self.highs,  dtype=np.float64)
        L = np.asarray(self.lows,   dtype=np.float64)
        C = np.asarray(self.closes, dtype=np.float64)

        # True Range
        tr = np.zeros(n)
        tr[0] = H[0] - L[0]
        for i in range(1, n):
            hl = H[i] - L[i]
            hc = abs(H[i] - C[i - 1])
            lc = abs(L[i] - C[i - 1])
            tr[i] = max(hl, hc, lc)

        # 20-bar rolling sum (min_periods=20 → tam 20 bar dolana kadar NaN)
        tr_roll = pd.Series(tr).rolling(20, min_periods=20).sum().values

        # ATR% = sum / (20 * close)
        self.atr_pct_bb = np.zeros(n)
        valid = (tr_roll > 0) & (C > 0) & (~np.isnan(tr_roll))
        self.atr_pct_bb[valid] = tr_roll[valid] / (20.0 * C[valid])

    # ── Puan Fonksiyonları ────────────────────────────────────────
    # Her fonksiyon, Robot_PreMove_Intraday_S9.txt'deki satır
    # referanslarıyla eşleşir. Formüller değiştirilmez.

    def _calc_ema_score(self, i: int) -> float:
        """PreMove C# satır 206-213 — EMA hizalaması (0-20p)."""
        c    = self.closes[i]
        e9   = self.ema_9[i]
        e21  = self.ema_21[i]
        e50  = self.ema_50[i]
        e200 = self.ema_200[i]
        if e9 == 0 or e200 == 0:
            return 0.0
        score = 0.0
        if c   > e9:   score += 4.0
        if e9  > e21:  score += 4.0
        if e21 > e50:  score += 4.0
        if e50 > e200: score += 4.0
        if i >= 5 and self.ema_50[i] > self.ema_50[i - 5]:
            score += 4.0
        return score

    def _calc_upvol_score(self, i: int) -> float:
        """PreMove C# satır 219-230 — Up Hacim Oranı (0-45p).
        
        Temel kriter: Son 20 barda, fiyat YÜKSELİYOR ve hacim
        20-bar ortalamasının ÜSTÜNDE olan bar sayısının oranı.
        """
        cfg    = self.config
        lb20   = min(cfg.upvol_lookback, i - 1)
        if lb20 <= 0:
            return 0.0

        up_vol_gun = 0
        for k in range(i - lb20 + 1, i + 1):
            if (k > 0 and
                    self.closes[k] > self.closes[k - 1] and
                    self.vol_ma20[k] > 0 and
                    self.volumes[k] > self.vol_ma20[k]):
                up_vol_gun += 1

        uv_ratio = up_vol_gun / lb20

        # Doğrusal ölçek: 0.20 → 5p, 0.50 → 45p (v3.0)
        if uv_ratio >= 0.50:
            return 45.0
        elif uv_ratio >= 0.20:
            return (uv_ratio - 0.20) / 0.30 * 40.0 + 5.0
        return 0.0

    def _calc_pp_penalty(self, i: int) -> float:
        """PreMove C# satır 238-258 — Pocket Pivot Zehir Cezası (-10/-5p).
        
        Medyan bazlı: son 10 bar içinde DÜŞEN günlerin hacim MEDYANI.
        Bugün hacimli yukarı kapat = zaten fırlamış → ceza.
        """
        if i < 2:
            return 0.0

        cfg   = self.config
        pp_lb = min(cfg.pp_lookback, i - 1)

        down_vol_list = []
        for k in range(i - pp_lb, i):
            if k > 0 and self.closes[k] < self.closes[k - 1]:
                down_vol_list.append(self.volumes[k])

        med_down_vol = 0.0
        if down_vol_list:
            down_vol_list.sort()
            mid = len(down_vol_list) // 2
            if len(down_vol_list) % 2 == 0:
                med_down_vol = (down_vol_list[mid - 1] + down_vol_list[mid]) / 2.0
            else:
                med_down_vol = down_vol_list[mid]

        bugun_yukari  = self.closes[i] > self.closes[i - 1]
        vol_buyuk     = med_down_vol > 0 and self.volumes[i] > med_down_vol
        vol_orta_ust  = self.vol_ma20[i] > 0 and self.volumes[i] > self.vol_ma20[i]

        if bugun_yukari and vol_buyuk and vol_orta_ust:
            return -10.0   # Tam PP cezası (v3.0)
        elif bugun_yukari and vol_buyuk:
            return -5.0    # Kısmi PP cezası
        return 0.0

    def _calc_vcp_score(self, i: int) -> float:
        """PreMove C# satır 271-333 — VCP Tam Formasyon + NR7 (0-30p).
        
        Algoritma (Python → C# birebir):
          1. 2-bar smooth pivot yüksek/alçak tespiti
          2. Pivot çiftler arası genişlik = (H-L)/H
          3. Her kontraksiyon bir öncekinden %10 dar mı?
          4. Hacim erken → son %75 azalımı
          5. Son 5 bar VDU (ort×0.60 altı)
          NR7: Bugünün range'i son 7 günün en darı → +4p bonus
        """
        cfg      = self.config
        vcp_lb   = min(cfg.vcp_lookback, i)
        vcp_start = i - vcp_lb

        if vcp_lb < 6:
            return 0.0

        # Pivot tespiti (2-bar smooth) — C# satır 280-286
        pivot_h = []
        pivot_l = []
        for k in range(vcp_start + 2, i - 1):
            h_max = self.highs[k]
            l_min = self.lows[k]
            for m in range(k - 2, k + 3):
                if 0 <= m < self.n:
                    if self.highs[m] > h_max: h_max = self.highs[m]
                    if self.lows[m]  < l_min: l_min = self.lows[m]
            if self.highs[k] == h_max:
                pivot_h.append(self.highs[k])
            if self.lows[k] == l_min:
                pivot_l.append(self.lows[k])

        # Genişlik hesabı (max 5 çift, son çiftlerden geriye) — C# satır 289-296
        widths   = []
        min_pairs = min(len(pivot_h), len(pivot_l))
        for k in range(min_pairs - 1):
            if k >= 5:
                break
            hv = pivot_h[len(pivot_h) - 1 - k]
            lv = pivot_l[len(pivot_l) - 1 - k]
            if hv > 0:
                widths.append((hv - lv) / hv)

        if len(widths) < 2:
            return 0.0

        vcp_score = 0.0

        # Kriter 1: Kontraksiyon sayısı — C# satır 300-301
        if len(widths) >= 3:
            vcp_score += 9.0
        else:
            vcp_score += 6.0

        # Kriter 2: Daralma (%90 tolerans) — C# satır 304-308
        narrow_count = 0
        for k in range(len(widths) - 1, 0, -1):
            if widths[k - 1] < widths[k] * 0.90:
                narrow_count += 1
        if narrow_count >= 2:
            vcp_score += 9.0
        elif narrow_count >= 1:
            vcp_score += 6.0

        # Kriter 3: Hacim azalımı — C# satır 311-317
        cut = vcp_lb // 3
        if cut > 0:
            early_vol  = sum(self.volumes[vcp_start:vcp_start + cut]) / cut
            recent_vol = sum(self.volumes[i - cut + 1:i + 1]) / cut
            if early_vol > 0 and recent_vol < early_vol * 0.75:
                vcp_score += 4.0

        # Kriter 4: VDU — C# satır 319-324
        if i >= 19:
            vol5  = sum(self.volumes[i - 4:i + 1]) / 5.0
            vol20 = sum(self.volumes[i - 19:i + 1]) / 20.0
            if vol20 > 0 and vol5 < vol20 * 0.60:
                vcp_score += 4.0

        # NR7 — C# satır 327-333
        r_bugun = self.highs[i] - self.lows[i]
        is_nr7 = True
        for k in range(max(0, i - 6), i):
            if (self.highs[k] - self.lows[k]) <= r_bugun:
                is_nr7 = False
                break
        if is_nr7:
            vcp_score = min(30.0, vcp_score + 4.0)

        return min(30.0, vcp_score)

    def _calc_bb_squeeze_score(self, i: int) -> float:
        """PreMove C# satır 363-390 — BB Squeeze Bonusu (0-6p).
        
        SMA-bazlı ATR% kullanır (NOT Wilder's RMA).
        ATR%(i) = SUM(TR[i-19:i+1]) / (20 * C[i])
        Squeeze = mevcut ATR%, geçmiş 126-barın alt %15 persentilinde
        """
        cfg = self.config
        if i < 20 + 15 + 4:    # Yeterli tarihsel pencere yok
            return 0.0

        curr_atr_pct = self.atr_pct_bb[i]
        if curr_atr_pct <= 0:
            return 0.0

        # Tarihsel pencere: max(20, i-125) → i-5 (C# satır 376)
        hist_start = max(20, i - cfg.bb_squeeze_lb)
        hist_end   = i - 4     # exclusive (C# k < bi-4)

        hist = self.atr_pct_bb[hist_start:hist_end]
        hist_valid = hist[hist > 0]
        bb_tot = len(hist_valid)

        if bb_tot < 15:         # C# bbTot >= 15 koşulu
            return 0.0

        bb_above = int(np.sum(hist_valid > curr_atr_pct))
        squeeze  = (bb_above / bb_tot) >= cfg.bb_squeeze_pct
        return 6.0 if squeeze else 0.0

    def _calc_pos_bonus(self, i: int) -> float:
        """PreMove C# satır 393-396 — Pozisyon Bonusu (0-2p).
        
        40-bar tabanının üst %55'inde kapanış.
        """
        hh40   = self.hhv_40[i]
        ll40   = self.llv_40[i]
        b_range = hh40 - ll40
        b_pos  = (self.closes[i] - ll40) / b_range if b_range > 0.001 else 0.5
        return 2.0 if b_pos >= 0.55 else 0.0

    def _compute_score(self, i: int) -> float:
        """Toplam PreMove puanı [0-100]. C# satır 400-404 ile birebir."""
        if i < self.config.warmup_bars:
            return 0.0

        ema_score  = self._calc_ema_score(i)
        uv_score   = self._calc_upvol_score(i)
        pp_penalty = self._calc_pp_penalty(i)
        vcp_score  = self._calc_vcp_score(i)
        bb_bonus   = self._calc_bb_squeeze_score(i)
        pos_bonus  = self._calc_pos_bonus(i)

        # Şımarık Tuzağı — C# satır 401-402
        fiyat_deg = 0.0
        if i > 0 and self.closes[i - 1] > 0:
            fiyat_deg = (self.closes[i] - self.closes[i - 1]) / self.closes[i - 1] * 100.0
        simarik_ceza = -20.0 if fiyat_deg > self.config.simarik_pct else 0.0

        total = (ema_score + uv_score + pp_penalty + vcp_score +
                 bb_bonus + pos_bonus + simarik_ceza)
        return max(0.0, min(100.0, total))

    # ── Sinyal Üretici ────────────────────────────────────────────

    def generate_all_signals(self) -> Tuple[np.ndarray, np.ndarray, np.ndarray]:
        """
        Tüm barlar için sinyal üret — optimizer/backtest uyumlu.

        Returns:
            signals:     np.int8   (1=LONG, 0=NONE)
            exits_long:  np.bool_
            exits_short: np.bool_  (her zaman False — SADECE_AL)
        """
        n   = self.n
        cfg = self.config

        signals     = np.zeros(n, dtype=np.int8)
        exits_long  = np.zeros(n, dtype=np.bool_)
        exits_short = np.zeros(n, dtype=np.bool_)

        in_long     = False
        entry_price = 0.0
        trail_stop  = 0.0

        for i in range(cfg.warmup_bars, n):
            score = self._compute_score(i)

            # ── LONG Pozisyon Yönetimi ──────────────────────────
            if in_long:
                # ATR trailing stop güncelle (en yüksek seviyeyi koru)
                new_stop = self.closes[i] - cfg.atr_stop_mult * self.atr_vals[i]
                if new_stop > trail_stop:
                    trail_stop = new_stop

                stop_hit   = self.lows[i] <= trail_stop
                skor_dusuk = score < cfg.esik_takip

                if stop_hit or skor_dusuk:
                    exits_long[i] = True
                    in_long       = False
                    entry_price   = trail_stop = 0.0
                continue

            # ── Giriş ───────────────────────────────────────────
            if cfg.yon_modu == "SADECE_SAT":
                continue

            if score >= cfg.esik_yuksek:
                signals[i]  = 1
                in_long     = True
                entry_price = self.closes[i]
                trail_stop  = entry_price - cfg.atr_stop_mult * self.atr_vals[i]

        return signals, exits_long, exits_short

    # ── Fabrika Metodu ────────────────────────────────────────────

    @classmethod
    def from_config_dict(cls, cache: Any, params: dict,
                         dates=None) -> 'PreMoveIntradayStrategy':
        """Optimizer fabrika metodu — cache + dict'ten strateji oluşturur."""
        cfg = PreMoveIntradayConfig(
            esik_yuksek    = int(params.get('esik_yuksek',    65)),
            esik_takip     = int(params.get('esik_takip',     45)),
            ema1           = int(params.get('ema1',            9)),
            ema2           = int(params.get('ema2',           21)),
            ema3           = int(params.get('ema3',           50)),
            ema4           = int(params.get('ema4',          200)),
            upvol_lookback = int(params.get('upvol_lookback', 20)),
            vcp_lookback   = int(params.get('vcp_lookback',   60)),
            bb_squeeze_win = int(params.get('bb_squeeze_win', 20)),
            bb_squeeze_lb  = int(params.get('bb_squeeze_lb', 126)),
            bb_squeeze_pct = float(params.get('bb_squeeze_pct', 0.85)),
            pp_lookback    = int(params.get('pp_lookback',    10)),
            base_lookback  = int(params.get('base_lookback',  40)),
            simarik_pct    = float(params.get('simarik_pct',  1.5)),
            atr_period     = int(params.get('atr_period',     14)),
            atr_stop_mult  = float(params.get('atr_stop_mult', 2.0)),
            yon_modu       = str(params.get('yon_modu', 'SADECE_AL')),
            warmup_bars    = int(params.get('warmup_bars',   250)),
        )

        if isinstance(cache, dict):
            cache = SimpleNamespace(**cache)

        # volumes veya lots (eski iDeal cache uyumu)
        vols = (list(cache.volumes) if hasattr(cache, 'volumes')
                else list(cache.lots))

        return cls(
            opens   = list(cache.opens),
            highs   = list(cache.highs),
            lows    = list(cache.lows),
            closes  = list(cache.closes),
            volumes = vols,
            config  = cfg,
            dates   = dates or getattr(cache, 'dates', None),
        )
