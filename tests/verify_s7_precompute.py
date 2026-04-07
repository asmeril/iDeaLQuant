"""
verify_s7_precompute.py
========================
Eski loop-based fast_backtest_strategy7 ile yeni pre-computed versiyonun
aynı sonuçları üretip üretmediğini doğrular.

Ayrıca hız karşılaştırması yapar.
"""
import sys, os, time
sys.path.insert(0, os.path.abspath(os.path.join(os.path.dirname(__file__), '..')))

import numpy as np
import pandas as pd
from numba import jit

# ---- Yeni (pre-computed) kernel ----
from src.optimization.strategy7_optimizer import fast_backtest_strategy7

# ---- Eski (loop-based) kernel — referans implementasyon ----
@jit(nopython=True, cache=False)
def _old_fast_backtest_s7(
    closes, highs, lows, volumes, ars_ema, st_val, ema_fast, ema_slow,
    toma_val, mfi_arr, atr_arr, mask_arr, times_arr,
    ars_k, hhv_period, llv_period, mfi_hhv_period, mfi_llv_period,
    mfi_long, mfi_short, vol_ratio,
    atr_stop_mult_long, atr_stop_mult_short,
    kar_al_yuzde_long, kar_al_yuzde_short,
    min_hold_bars, max_hold_bars, cooldown_bars, vade_tipi
):
    n = len(closes)
    in_long = False; in_short = False
    entry_price = 0.0; extreme_val = 0.0; stop_level = 0.0
    bars_in_pos = 0; cooldown_ct = 0
    total_profit = 0.0; total_loss = 0.0
    winning_trades = 0; losing_trades = 0
    peak_equity = 0.0; max_dd = 0.0; current_equity = 0.0
    trade_profits = []
    active_days = 0; last_day = -1
    is_spot = (vade_tipi == 0)

    for i in range(1, n):
        if not mask_arr[i]:
            if (in_long or in_short) and current_equity != 0:
                exit_price = closes[i]
                trade_pnl = exit_price - entry_price if in_long else entry_price - exit_price
                trade_profits.append(trade_pnl)
                current_equity += trade_pnl
                if trade_pnl > 0: total_profit += trade_pnl; winning_trades += 1
                else: total_loss += abs(trade_pnl); losing_trades += 1
                in_long = False; in_short = False
                entry_price = 0.0; extreme_val = 0.0; stop_level = 0.0
                bars_in_pos = 0; cooldown_ct = 0
            continue

        current_day = times_arr[i] // 86400
        if current_day != last_day: last_day = current_day; active_days += 1
        if cooldown_ct > 0: cooldown_ct -= 1

        ars_ema_val = ars_ema[i]
        ars_band = round(ars_ema_val * ars_k / 0.01 + 1e-9) * 0.01
        rejim_long  = (closes[i] > ars_ema_val) and (closes[i] < ars_ema_val + ars_band)
        rejim_short = (closes[i] < ars_ema_val) and (closes[i] > ars_ema_val - ars_band)
        st_long   = (st_val[i] < closes[i]); st_short  = (st_val[i] > closes[i])
        ema_long  = (ema_fast[i] > ema_slow[i]); ema_short = (ema_fast[i] < ema_slow[i])
        trend_long  = st_long  and ema_long
        trend_short = st_short and ema_short
        toma_kros_up   = (toma_val[i] > 0) and (toma_val[i-1] <= 0)
        toma_kros_down = (toma_val[i] < 0) and (toma_val[i-1] >= 0)

        prev_hhv = 0.0
        for k in range(1, hhv_period+1):
            if i-k >= 0 and highs[i-k] > prev_hhv: prev_hhv = highs[i-k]
        hhv_break = (closes[i] > prev_hhv)

        prev_llv = 9999999.0
        for k in range(1, llv_period+1):
            if i-k >= 0 and lows[i-k] < prev_llv: prev_llv = lows[i-k]
        llv_break = (closes[i] < prev_llv)

        tetik_long  = toma_kros_up  or hhv_break
        tetik_short = toma_kros_down or llv_break

        prev_mfi_max = 0.0
        for k in range(1, mfi_hhv_period+1):
            if i-k >= 0 and mfi_arr[i-k] > prev_mfi_max: prev_mfi_max = mfi_arr[i-k]
        mfi_long_ok = (mfi_arr[i] > mfi_long) and (mfi_arr[i] > prev_mfi_max)

        prev_mfi_min = 9999999.0
        for k in range(1, mfi_llv_period+1):
            if i-k >= 0 and mfi_arr[i-k] < prev_mfi_min: prev_mfi_min = mfi_arr[i-k]
        mfi_short_ok = (mfi_arr[i] < mfi_short) and (mfi_arr[i] < prev_mfi_min)

        vol_avg = 0.0; v_count = 0
        for k in range(1, 21):
            if i-k >= 0: vol_avg += volumes[i-k]; v_count += 1
        if v_count > 0: vol_avg /= float(v_count)
        vol_ok = (volumes[i] >= vol_avg * vol_ratio)

        onay_long  = mfi_long_ok  and vol_ok
        onay_short = mfi_short_ok and vol_ok
        cooldown_ok = (cooldown_ct == 0)

        giris_long  = (not in_long) and (not in_short) and rejim_long  and trend_long  and tetik_long  and onay_long  and cooldown_ok
        giris_short = (not in_long) and (not in_short) and rejim_short and trend_short and tetik_short and onay_short and cooldown_ok

        if giris_long:
            in_long = True; entry_price = closes[i]; extreme_val = entry_price
            stop_level = entry_price - atr_arr[i] * atr_stop_mult_long; bars_in_pos = 0
        elif giris_short and not is_spot:
            in_short = True; entry_price = closes[i]; extreme_val = entry_price
            stop_level = entry_price + atr_arr[i] * atr_stop_mult_short; bars_in_pos = 0

        if in_long:
            bars_in_pos += 1
            if closes[i] > extreme_val: extreme_val = closes[i]; stop_level = extreme_val - atr_arr[i] * atr_stop_mult_long
            kar_al_fiyat = entry_price * (1.0 + kar_al_yuzde_long / 100.0)
            stop_hit = (closes[i] <= stop_level); kar_al_hit = (closes[i] >= kar_al_fiyat)
            rejim_kirildi = not rejim_long; trend_kirildi = not trend_long
            min_hold_ok = (bars_in_pos >= min_hold_bars); max_hold_hit = (bars_in_pos >= max_hold_bars)
            if stop_hit or kar_al_hit or rejim_kirildi or (trend_kirildi and min_hold_ok) or max_hold_hit:
                trade_pnl = closes[i] - entry_price
                trade_profits.append(trade_pnl); current_equity += trade_pnl
                if trade_pnl > 0: total_profit += trade_pnl; winning_trades += 1
                else: total_loss += abs(trade_pnl); losing_trades += 1
                in_long = False; bars_in_pos = 0; cooldown_ct = cooldown_bars
        elif in_short:
            bars_in_pos += 1
            if closes[i] < extreme_val: extreme_val = closes[i]; stop_level = extreme_val + atr_arr[i] * atr_stop_mult_short
            kar_al_fiyat = entry_price * (1.0 - kar_al_yuzde_short / 100.0)
            stop_hit = (closes[i] >= stop_level); kar_al_hit = (closes[i] <= kar_al_fiyat)
            rejim_kirildi = not rejim_short; trend_kirildi = not trend_short
            min_hold_ok = (bars_in_pos >= min_hold_bars); max_hold_hit = (bars_in_pos >= max_hold_bars)
            if stop_hit or kar_al_hit or rejim_kirildi or (trend_kirildi and min_hold_ok) or max_hold_hit:
                trade_pnl = entry_price - closes[i]
                trade_profits.append(trade_pnl); current_equity += trade_pnl
                if trade_pnl > 0: total_profit += trade_pnl; winning_trades += 1
                else: total_loss += abs(trade_pnl); losing_trades += 1
                in_short = False; bars_in_pos = 0; cooldown_ct = cooldown_bars

        if current_equity > peak_equity: peak_equity = current_equity
        else:
            dd = peak_equity - current_equity
            if dd > max_dd: max_dd = dd

    total_trades = winning_trades + losing_trades
    net_profit   = total_profit - total_loss
    profit_factor = total_profit / total_loss if total_loss > 0 else 99.0
    sharpe_ratio = 0.0
    if total_trades > 2:
        t_arr = np.array(trade_profits)
        std_dev = np.std(t_arr)
        if std_dev > 0: sharpe_ratio = np.mean(t_arr) / std_dev * np.sqrt(total_trades)
    total_days = active_days if active_days > 0 else 1
    return net_profit, total_trades, profit_factor, max_dd, sharpe_ratio, active_days, total_days


# ── Sentetik veri oluştur ──────────────────────────────────────────────────
print("Sentetik veri oluşturuluyor…")
N = 50_000
rng = np.random.default_rng(42)
closes  = np.cumprod(1 + rng.normal(0, 0.001, N)) * 100.0
highs   = closes * (1 + rng.uniform(0, 0.005, N))
lows    = closes * (1 - rng.uniform(0, 0.005, N))
volumes = rng.uniform(1e6, 5e6, N)
times_arr = np.arange(N, dtype=np.int64) * 300  # 5 dakika

# Basit indikatörler
def ema(arr, p):
    out = np.zeros_like(arr)
    a = 2/(p+1)
    out[0] = arr[0]
    for i in range(1, len(arr)): out[i] = arr[i]*a + out[i-1]*(1-a)
    return out

def sma(arr, p):
    return pd.Series(arr).rolling(p, min_periods=1).mean().values

def typical_price(h, l, c): return (h + l + c) / 3.0

ars_ema = ema(typical_price(highs, lows, closes), 3)
ema_f   = ema(closes, 9)
ema_s   = ema(closes, 21)

# Supertrend basit mock (ST = fiyatın bir miktar altı/üstü)
st_val = closes * 0.99  # hep long

# MFI mock
mf_pos = closes * volumes
mf_neg = closes * volumes * 0.5
mfi_arr = (pd.Series(mf_pos).rolling(14).sum() /
           (pd.Series(mf_pos).rolling(14).sum() + pd.Series(mf_neg).rolling(14).sum()) * 100
           ).fillna(50).values

# TOMA mock (trend serisi)
toma_val = np.where(closes > ema(closes, 34), 1.0, -1.0)

# ATR mock
atr_arr = sma(highs - lows, 14)

mask_arr  = np.ones(N, dtype=np.bool_)

# ── Parametreler ──────────────────────────────────────────────────────────
HHV_P = 12; LLV_P = 12; MFI_HHV = 5; MFI_LLV = 5
ARS_K = 1.23; MFI_LONG = 55.0; MFI_SHORT = 45.0; VOL_RATIO = 0.8
ATR_SL_L = 1.5; ATR_SL_S = 1.5; KA_L = 2.0; KA_S = 2.0
MH_B = 2; MX_B = 20; CD_B = 2; VT = 1

# Pre-computed arrays (yeni yöntem)
hhv_shifted     = pd.Series(highs).shift(1).rolling(HHV_P,  min_periods=1).max().fillna(0).values.astype(np.float64)
llv_shifted     = pd.Series(lows ).shift(1).rolling(LLV_P,  min_periods=1).min().fillna(9999999).values.astype(np.float64)
mfi_hhv_shifted = pd.Series(mfi_arr).shift(1).rolling(MFI_HHV, min_periods=1).max().fillna(0).values.astype(np.float64)
mfi_llv_shifted = pd.Series(mfi_arr).shift(1).rolling(MFI_LLV, min_periods=1).min().fillna(9999999).values.astype(np.float64)
vol_ma_shifted  = pd.Series(volumes).shift(1).rolling(20,    min_periods=1).mean().fillna(0).values.astype(np.float64)

# ── JIT ısınması ──────────────────────────────────────────────────────────
print("JIT ısınması…")
small = slice(0, 1000)
_ = _old_fast_backtest_s7(
    closes[small], highs[small], lows[small], volumes[small],
    ars_ema[small], st_val[small], ema_f[small], ema_s[small],
    toma_val[small], mfi_arr[small], atr_arr[small], mask_arr[small], times_arr[small],
    ARS_K, HHV_P, LLV_P, MFI_HHV, MFI_LLV, MFI_LONG, MFI_SHORT, VOL_RATIO,
    ATR_SL_L, ATR_SL_S, KA_L, KA_S, MH_B, MX_B, CD_B, VT
)
_ = fast_backtest_strategy7(
    closes[small].astype(np.float64), highs[small].astype(np.float64),
    lows[small].astype(np.float64), volumes[small].astype(np.float64),
    ars_ema[small].astype(np.float64), st_val[small].astype(np.float64),
    ema_f[small].astype(np.float64), ema_s[small].astype(np.float64),
    toma_val[small].astype(np.float64), mfi_arr[small].astype(np.float64),
    atr_arr[small].astype(np.float64), mask_arr[small], times_arr[small],
    hhv_shifted[small], llv_shifted[small], mfi_hhv_shifted[small], mfi_llv_shifted[small], vol_ma_shifted[small],
    ARS_K, MFI_LONG, MFI_SHORT, VOL_RATIO,
    ATR_SL_L, ATR_SL_S, KA_L, KA_S, MH_B, MX_B, CD_B, VT
)
print("JIT hazır.")

# ── Tam karşılaştırma (N=50k) ─────────────────────────────────────────────
REPS = 10

t0 = time.perf_counter()
for _ in range(REPS):
    old_res = _old_fast_backtest_s7(
        closes, highs, lows, volumes,
        ars_ema, st_val, ema_f, ema_s,
        toma_val, mfi_arr, atr_arr, mask_arr, times_arr,
        ARS_K, HHV_P, LLV_P, MFI_HHV, MFI_LLV, MFI_LONG, MFI_SHORT, VOL_RATIO,
        ATR_SL_L, ATR_SL_S, KA_L, KA_S, MH_B, MX_B, CD_B, VT
    )
old_ms = (time.perf_counter() - t0) / REPS * 1000

t0 = time.perf_counter()
for _ in range(REPS):
    new_res = fast_backtest_strategy7(
        closes.astype(np.float64), highs.astype(np.float64),
        lows.astype(np.float64), volumes.astype(np.float64),
        ars_ema.astype(np.float64), st_val.astype(np.float64),
        ema_f.astype(np.float64), ema_s.astype(np.float64),
        toma_val.astype(np.float64), mfi_arr.astype(np.float64),
        atr_arr.astype(np.float64), mask_arr, times_arr,
        hhv_shifted, llv_shifted, mfi_hhv_shifted, mfi_llv_shifted, vol_ma_shifted,
        ARS_K, MFI_LONG, MFI_SHORT, VOL_RATIO,
        ATR_SL_L, ATR_SL_S, KA_L, KA_S, MH_B, MX_B, CD_B, VT
    )
new_ms = (time.perf_counter() - t0) / REPS * 1000

# ── Sonuçlar ──────────────────────────────────────────────────────────────
labels = ["net_profit", "trades", "profit_factor", "max_dd", "sharpe", "active_days", "total_days"]
print("\n── SONUÇ KARŞILAŞTIRMASI ──────────────────────────────")
all_ok = True
for i, lbl in enumerate(labels):
    o, n = old_res[i], new_res[i]
    match = abs(o - n) < 1e-6 if isinstance(o, float) else (o == n)
    status = "✅" if match else "❌"
    if not match: all_ok = False
    print(f"  {status}  {lbl:20s}  eski={o:.6g}  yeni={n:.6g}")

print(f"\n── HIZ KARŞILAŞTIRMASI (N={N:,}, {REPS} tekrar) ────────")
print(f"  Eski (loop):   {old_ms:.2f} ms/çalıştırma")
print(f"  Yeni (array):  {new_ms:.2f} ms/çalıştırma")
if new_ms > 0:
    print(f"  Hızlanma:      {old_ms/new_ms:.1f}x")

if all_ok:
    print("\n✅ Tüm sonuçlar birebir eşleşiyor — refactor güvenli!")
else:
    print("\n❌ FARK VAR — lütfen kontrol et!")
    sys.exit(1)
