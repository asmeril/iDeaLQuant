"""
Strateji 8 (Gap Reversal v1.0) Numba-JIT Support
==================================================
S7 ile aynÄ± mimari:
- Sabit diziler (session, time_gap, day_of_week, late_aksam, mask) bir kez hesaplanÄ±r.
- Parametre bazlÄ± diziler (Wilder RSI, shifted Vol SMA, Wilder ATR) worker-level
  cache'te period â†’ np.array olarak tutulur; her kombinasyon iÃ§in yeniden hesaplanmaz.
- fast_backtest_strategy8: saf Numba nopython kernel, sÄ±fÄ±r Python dÃ¶ngÃ¼sÃ¼.

Pre-computed arrays sayesinde her kombinasyon iÃ§in sadece basit dizi eriÅŸimleri
ve koÅŸul kontrolleri yapÄ±lÄ±r (~40-80x hÄ±zlanma beklenir).
"""
import numpy as np
from numba import jit


# â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€
# PRE-COMPUTATION â€” Worker-level cache iÃ§in Ã§aÄŸrÄ±lÄ±r (Numba JIT)
# â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€

@jit(nopython=True, cache=True)
def precompute_wilder_rsi(closes: np.ndarray, period: int) -> np.ndarray:
    """Wilder Smoothing RSI. period parametreli, tam dizi dÃ¶ner."""
    n = len(closes)
    rsi = np.full(n, 50.0)
    ag = 0.0
    al = 0.0
    for j in range(1, n):
        delta = closes[j] - closes[j - 1]
        gain = delta if delta > 0.0 else 0.0
        loss = (-delta) if delta < 0.0 else 0.0
        if j < period:
            ag += gain
            al += loss
        elif j == period:
            ag = (ag + gain) / period
            al = (al + loss) / period
            rsi[j] = 100.0 - (100.0 / (1.0 + ag / al)) if al != 0.0 else 100.0
        else:
            ag = (ag * (period - 1) + gain) / period
            al = (al * (period - 1) + loss) / period
            rsi[j] = 100.0 - (100.0 / (1.0 + ag / al)) if al != 0.0 else 100.0
    return rsi


@jit(nopython=True, cache=True)
def precompute_atr_wilder(closes: np.ndarray, highs: np.ndarray, lows: np.ndarray, period: int) -> np.ndarray:
    """Wilder ATR. Returns full-length array."""
    n = len(closes)
    atr = np.zeros(n)
    if n < period + 1:
        return atr
    atr_val = 0.0
    for i in range(1, n):
        hl = highs[i] - lows[i]
        hc = abs(highs[i] - closes[i - 1])
        lc = abs(lows[i] - closes[i - 1])
        tr = hl
        if hc > tr:
            tr = hc
        if lc > tr:
            tr = lc
        if i < period:
            atr_val += tr
        elif i == period:
            atr_val = (atr_val + tr) / period
            atr[i] = atr_val
        else:
            atr_val = (atr_val * (period - 1) + tr) / period
            atr[i] = atr_val
    # warm-up barlarÄ± ilk geÃ§erli deÄŸerle doldur
    first_valid = atr[period] if period < n else 0.0
    for i in range(period):
        atr[i] = first_valid
    return atr


@jit(nopython=True, cache=True)
def precompute_sma_shifted(arr: np.ndarray, period: int) -> np.ndarray:
    """Shifted SMA (look-ahead bias yok): result[i] = mean(arr[i-period .. i-1]).
    i < period iÃ§in 0.0 dÃ¶ner."""
    n = len(arr)
    result = np.zeros(n)
    if n <= period:
        return result
    rolling_sum = 0.0
    for i in range(period - 1):
        rolling_sum += arr[i]
    for i in range(period - 1, n - 1):
        rolling_sum += arr[i]
        result[i + 1] = rolling_sum / period
        rolling_sum -= arr[i - period + 1]
    return result


# â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€
# ANA KERNEL
# â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€

@jit(nopython=True, cache=True)
def fast_backtest_strategy8(
    opens: np.ndarray,
    closes: np.ndarray,
    highs: np.ndarray,
    lows: np.ndarray,
    volumes: np.ndarray,
    # Sabit (dataset-level) diziler
    session_arr: np.ndarray,      # int8: 0=dÄ±ÅŸÄ±, 1=emirToplama, 2=gunSeansi, 3=aksamSeansi
    time_gap_arr: np.ndarray,     # float64: Ã¶nceki bar'dan bu yana saat farkÄ±
    day_of_week_arr: np.ndarray,  # int8: 0=Pzt .. 6=Paz
    mask_arr: np.ndarray,         # bool: False = tatil / vade sonu
    late_aksam_arr: np.ndarray,   # bool: True = 22:50+ akÅŸam seansÄ±
    # Parametre-baÄŸÄ±mlÄ± diziler (worker cache'ten gelir)
    rsi_arr: np.ndarray,          # Wilder RSI (period parametreli)
    vol_ma_arr: np.ndarray,       # Shifted SMA of volumes (hacim_ma_period parametreli)
    atr_arr: np.ndarray,          # Wilder ATR (atr_period parametreli)
    # Optimize edilen parametreler
    min_gap_pct: float,
    max_gap_pct: float,
    cuma_aktif: int,              # 0=False, 1=True
    or_bars: int,
    rsi_filtre_aktif: int,        # 0=False, 1=True
    rsi_ob: float,
    rsi_os: float,
    hacim_filtre_aktif: int,      # 0=False, 1=True
    hacim_oran: float,
    atr_stop_mult: float,
    gap_window_bars: int,
    cooldown_bars: int,
    yon_modu: int,                # 0=CIFT, 1=SADECE_AL, 2=SADECE_SAT
    vade_tipi: int,               # 0=SPOT (no short), 1=VIOP_ENDEKS, 2=VIOP_SPOT
):
    """
    Gap Reversal state machine â€” Numba nopython.
    Returns: (net_profit, total_trades, profit_factor, max_dd, sharpe, active_days, total_days)
    """
    n = len(closes)
    WARM = 60  # RSI(14) + ATR(21) + VolMA(30) Ä±sÄ±nmasÄ± iÃ§in yeterli

    in_long = False
    in_short = False
    entry_price = 0.0
    stop_level = 0.0
    bars_in_pos = 0
    cooldown_ct = 0

    gap_active = False
    gap_fill_lvl = 0.0
    gap_dir = 0        # +1=yukarÄ± gap, -1=aÅŸaÄŸÄ± gap
    or_complete = False
    or_high = 0.0
    or_low = 1e18
    or_start_bar = -1
    pos_start_bar = -1

    total_profit = 0.0
    total_loss = 0.0
    winning_trades = 0
    losing_trades = 0
    current_equity = 0.0
    peak_equity = 0.0
    max_dd = 0.0

    trade_profits = []
    active_days = 0

    for i in range(WARM, n):
        sess = session_arr[i]
        is_emir = (sess == 1)
        is_gun = (sess == 2)

        # Seans dÄ±ÅŸÄ± (gece arasÄ±, Ã¶ÄŸle arasÄ±) â†’ atla
        if sess == 0:
            continue

        # â”€â”€ Tatil / Vade Sonu â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€
        if not mask_arr[i]:
            if in_long or in_short:
                trade_pnl = (closes[i] - entry_price) if in_long else (entry_price - closes[i])
                current_equity += trade_pnl
                if trade_pnl > 0.0:
                    total_profit += trade_pnl
                    winning_trades += 1
                else:
                    total_loss += (-trade_pnl)
                    losing_trades += 1
                trade_profits.append(trade_pnl)
                in_long = False
                in_short = False
                gap_active = False
                entry_price = 0.0
                stop_level = 0.0
                pos_start_bar = -1
                cooldown_ct = cooldown_bars
            continue

        # â”€â”€ Cooldown â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€
        if cooldown_ct > 0:
            cooldown_ct -= 1

        # â”€â”€ KATMAN 1: GECE GAP TESPÄ°T â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€
        saat_fark = time_gap_arr[i]
        gece_sonrasi = (saat_fark > 6.0) and (saat_fark < 15.0) and is_emir

        if gece_sonrasi:
            active_days += 1

            # Gece kalmÄ±ÅŸ pozisyonu zorla kapat
            if in_long or in_short:
                trade_pnl = (closes[i] - entry_price) if in_long else (entry_price - closes[i])
                current_equity += trade_pnl
                if trade_pnl > 0.0:
                    total_profit += trade_pnl
                    winning_trades += 1
                else:
                    total_loss += (-trade_pnl)
                    losing_trades += 1
                trade_profits.append(trade_pnl)
                in_long = False
                in_short = False
                entry_price = 0.0
                stop_level = 0.0
                pos_start_bar = -1
                cooldown_ct = cooldown_bars
                gap_active = False

            # Yeni gap hesapla
            prev_close = closes[i - 1]
            today_open = opens[i]
            raw_gap = today_open - prev_close
            raw_gap_pct = (raw_gap / prev_close) * 100.0 if prev_close > 0.0 else 0.0

            abs_gap_pct = raw_gap_pct if raw_gap_pct >= 0.0 else (-raw_gap_pct)
            buyuk_yeterli = (abs_gap_pct >= min_gap_pct)
            asiri_degil = (abs_gap_pct <= max_gap_pct)
            cuma_ok = (day_of_week_arr[i] != 4) or (cuma_aktif == 1)

            gap_active = buyuk_yeterli and asiri_degil and cuma_ok
            gap_fill_lvl = prev_close
            gap_dir = 1 if raw_gap > 0.0 else -1

            or_complete = False
            or_start_bar = i if gap_active else -1
            or_high = highs[i]
            or_low = lows[i]
            pos_start_bar = -1

        # â”€â”€ KATMAN 2: OPENING RANGE â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€
        if gap_active and (not or_complete) and or_start_bar >= 0 and is_gun:
            elapsed = i - or_start_bar
            if elapsed < or_bars:
                if highs[i] > or_high:
                    or_high = highs[i]
                if lows[i] < or_low:
                    or_low = lows[i]
            else:
                or_complete = True

        # â”€â”€ KATMAN 3-5: GÄ°RÄ°Å â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€
        giri_on_kosul = (
            is_gun and gap_active and or_complete and
            (not in_long) and (not in_short) and
            cooldown_ct == 0 and pos_start_bar < 0
        )

        if giri_on_kosul:
            or_end_bar = or_start_bar + or_bars
            zaman_ok = ((i - or_end_bar) < gap_window_bars)

            vol_ma_val = vol_ma_arr[i]
            hacim_ok = (hacim_filtre_aktif == 0) or (vol_ma_val > 0.0 and volumes[i] >= vol_ma_val * hacim_oran)

            # YUKARI GAP â†’ SHORT
            if gap_dir == 1 and yon_modu != 1 and vade_tipi != 0:
                # C# ile ayni: VadeTipi != "SPOT" kosulu (SPOT'ta short yasakli)
                or_kirildi = closes[i] < or_low
                fill_olmadi = closes[i] > gap_fill_lvl
                rsi_ok = (rsi_filtre_aktif == 0) or (rsi_arr[i] > rsi_ob)

                if zaman_ok and or_kirildi and fill_olmadi and hacim_ok and rsi_ok:
                    in_short = True
                    entry_price = closes[i]
                    stop_level = or_high + atr_arr[i] * atr_stop_mult
                    bars_in_pos = 0
                    pos_start_bar = i

            # ASAGI GAP â†’ LONG
            if gap_dir == -1 and yon_modu != 2:
                or_kirildi = closes[i] > or_high
                fill_olmadi = closes[i] < gap_fill_lvl
                rsi_ok = (rsi_filtre_aktif == 0) or (rsi_arr[i] < rsi_os)

                if zaman_ok and or_kirildi and fill_olmadi and hacim_ok and rsi_ok:
                    in_long = True
                    entry_price = closes[i]
                    stop_level = or_low - atr_arr[i] * atr_stop_mult
                    bars_in_pos = 0
                    pos_start_bar = i

        # â”€â”€ LONG Ã‡IKIÅ â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€
        if in_long:
            bars_in_pos += 1

            stop_hit = (lows[i] <= stop_level)
            target_hit = (highs[i] >= gap_fill_lvl) or (closes[i] >= gap_fill_lvl)
            zaman_doldu = (pos_start_bar > 0) and ((i - pos_start_bar) >= gap_window_bars)
            aksam_kapa = late_aksam_arr[i]
            ters = (closes[i] < or_low) and (bars_in_pos > 3)

            if stop_hit or target_hit or zaman_doldu or aksam_kapa or ters:
                trade_pnl = closes[i] - entry_price
                current_equity += trade_pnl
                if trade_pnl > 0.0:
                    total_profit += trade_pnl
                    winning_trades += 1
                else:
                    total_loss += (-trade_pnl)
                    losing_trades += 1
                trade_profits.append(trade_pnl)

                in_long = False
                gap_active = False
                cooldown_ct = cooldown_bars
                bars_in_pos = 0
                entry_price = 0.0
                stop_level = 0.0
                pos_start_bar = -1

        # â”€â”€ SHORT Ã‡IKIÅ â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€
        if in_short:
            bars_in_pos += 1

            stop_hit = (highs[i] >= stop_level)
            target_hit = (lows[i] <= gap_fill_lvl) or (closes[i] <= gap_fill_lvl)
            zaman_doldu = (pos_start_bar > 0) and ((i - pos_start_bar) >= gap_window_bars)
            aksam_kapa = late_aksam_arr[i]
            ters = (closes[i] > or_high) and (bars_in_pos > 3)

            if stop_hit or target_hit or zaman_doldu or aksam_kapa or ters:
                trade_pnl = entry_price - closes[i]
                current_equity += trade_pnl
                if trade_pnl > 0.0:
                    total_profit += trade_pnl
                    winning_trades += 1
                else:
                    total_loss += (-trade_pnl)
                    losing_trades += 1
                trade_profits.append(trade_pnl)

                in_short = False
                gap_active = False
                cooldown_ct = cooldown_bars
                bars_in_pos = 0
                entry_price = 0.0
                stop_level = 0.0
                pos_start_bar = -1

        # â”€â”€ Drawdown Takibi â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€
        if current_equity > peak_equity:
            peak_equity = current_equity
        else:
            dd = peak_equity - current_equity
            if dd > max_dd:
                max_dd = dd

    # â”€â”€ Final Metrikleri â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€
    total_trades = winning_trades + losing_trades
    net_profit = total_profit - total_loss
    profit_factor = total_profit / total_loss if total_loss > 0.0 else 99.0

    sharpe_ratio = 0.0
    if total_trades > 2:
        t_arr = np.array(trade_profits)
        std_dev = np.std(t_arr)
        if std_dev > 0.0:
            sharpe_ratio = np.mean(t_arr) / std_dev * np.sqrt(float(total_trades))

    total_days = active_days if active_days > 0 else 1

    return net_profit, total_trades, profit_factor, max_dd, sharpe_ratio, active_days, total_days

def warmup_strategy8_numba():
    print('[WARMUP] S8 Numba JIT fonksiyonları derleniyor (Multiprocessing kilitlenmesini önlemek için)...')
    closes = np.random.random(100).astype(np.float64)
    highs = closes + 0.1
    lows = closes - 0.1
    vols = np.random.random(100).astype(np.float64)
    session = np.zeros(100, dtype=np.int8)
    time_gap = np.zeros(100, dtype=np.float64)
    dow = np.zeros(100, dtype=np.int8)
    mask = np.ones(100, dtype=np.bool_)
    late = np.zeros(100, dtype=np.bool_)

    rsi = precompute_wilder_rsi(closes, 5)
    atr = precompute_atr_wilder(closes, highs, lows, 14)
    sma = precompute_sma_shifted(vols, 20)
    _ = fast_backtest_strategy8(
        closes, closes, highs, lows, vols,
        session, time_gap, dow, mask, late,
        rsi, sma, atr,
        0.05, 2.0, 0, 15, 1, 62.0, 38.0, 1, 0.8, 0.5, 210, 3,
        0, 1
    )
    print('[WARMUP] S8 Numba JIT derleme tamamlandı.')
