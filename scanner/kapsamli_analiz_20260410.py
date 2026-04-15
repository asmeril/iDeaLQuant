#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
kapsamli_analiz_20260410.py
===========================
10.04.2026 tarihli yükselen/düşen listesinin kapsamlı multi-periyot analizi.

Analiz bölümleri:
  A) Mevcut PreMove sisteminin ne kadar yakaladığı (recall/precision)
  B) Günlük price action: mum formasyonları, VCP, PP, RS
  C) Gün içi (60dk + 15dk + 5dk) yapı: EMA hizalama, mini-VCP, momentum
  D) Scalp sinyalleri: 5dk breakout, BB squeeze, ortalamaya dönüş (MRV)
  E) VIP/endeks korelasyonu: XU100, XU030, vadeli, emtia
  F) "Eksik kriter" tespit: hangi yükselen hisseler PreMove'u ATLAMIŞ
  G) Formasyon bazlı isabet oranları — hangi periyotta ne çalışıyor?

Çıktı: kapsamli_analiz_20260410.txt (rapor) + kapsamli_analiz_20260410.csv (ham veri)
"""

import sys, os, math
sys.path.insert(0, r"D:\Projects\IdealQuant\scanner")
sys.path.insert(0, r"D:\Projects\IdealQuant")
sys.path.insert(0, r"D:\Projects\IdealQuant\src")

import pandas as pd
import numpy as np
from datetime import date, datetime
from pathlib import Path
from typing import Optional, Dict, List

from loader import load, _binary_to_df
from config import BASE_DIR

ENC = "cp1254"
ANALIZ_TARIHI = date(2026, 4, 10)
TARGET_DATE_STR = "2026-04-10"

# ══════════════════════════════════════════════════════════════════
# 1) VERİ YÜKLEME: 10.04.2026 Yükselen/Düşen
# ══════════════════════════════════════════════════════════════════

CSV_PATH = Path(r"D:\Projects\IdealQuant\scanner\10.04.2026 Yükselen Düşen tablosu.csv")

def parse_liste():
    df = pd.read_csv(CSV_PATH, sep=";", encoding=ENC, header=0)
    # Sütunlar: No;Yükselen;Y %;Düşen;D %;Senet;Hacim;H %
    yukselen = []
    dusen = []
    for _, row in df.iterrows():
        y = str(row.iloc[1]).strip() if pd.notna(row.iloc[1]) else ""
        yp = str(row.iloc[2]).replace(",", ".").strip() if pd.notna(row.iloc[2]) else "0"
        d = str(row.iloc[3]).strip() if pd.notna(row.iloc[3]) else ""
        dp = str(row.iloc[4]).replace(",", ".").strip() if pd.notna(row.iloc[4]) else "0"
        if y and y != "Yükselen" and y != "nan":
            try: yukselen.append((y, float(yp)))
            except: pass
        if d and d != "Düşen" and d != "nan":
            try: dusen.append((d, float(dp)))
            except: pass
    return yukselen, dusen

# ══════════════════════════════════════════════════════════════════
# 2) YARDIMCI: DataFrame'de belirli tarihe bak
# ══════════════════════════════════════════════════════════════════

def get_bar_idx(df: pd.DataFrame, dt_target: date) -> Optional[int]:
    if df is None or len(df) == 0:
        return None
    ts = pd.Timestamp(dt_target)
    mask = df["dt"].dt.normalize() <= ts
    if not mask.any():
        return None
    return int(df.index[mask][-1])

def safe_ema(arr, period):
    s = pd.Series(arr)
    return s.ewm(span=period, adjust=False).mean().values

def safe_sma(arr, period):
    s = pd.Series(arr)
    return s.rolling(period, min_periods=1).mean().values

def safe_rsi(arr, period=14):
    s = pd.Series(arr)
    delta = s.diff()
    gain = delta.clip(lower=0).rolling(period, min_periods=1).mean()
    loss = (-delta.clip(upper=0)).rolling(period, min_periods=1).mean()
    rs = gain / (loss + 1e-9)
    return (100 - 100 / (1 + rs)).values

def safe_atr(df: pd.DataFrame, period=14):
    h, l, c = df["high"].values, df["low"].values, df["close"].values
    pc = np.roll(c, 1); pc[0] = c[0]
    tr = np.maximum(h - l, np.maximum(abs(h - pc), abs(l - pc)))
    return pd.Series(tr).rolling(period, min_periods=1).mean().values

def bb_bands(arr, period=20, k=2.0):
    mid = safe_sma(arr, period)
    std = pd.Series(arr).rolling(period, min_periods=2).std().values
    upper = mid + k * std
    lower = mid - k * std
    width = (upper - lower) / (mid + 1e-9)
    return upper, mid, lower, width

def macd_arr(arr, fast=12, slow=26, sig=9):
    ema_f = safe_ema(arr, fast)
    ema_s = safe_ema(arr, slow)
    macd  = ema_f - ema_s
    signal = safe_ema(macd, sig)
    return macd, signal

# ══════════════════════════════════════════════════════════════════
# 3) GÜNLÜK ANALİZ BLOĞU
# ══════════════════════════════════════════════════════════════════

def analiz_gunluk(symbol: str) -> Optional[Dict]:
    df = load(symbol, "Gunluk")
    if df is None:
        return None
    bi = get_bar_idx(df, ANALIZ_TARIHI)
    if bi is None or bi < 200:
        return None

    c = df["close"].values
    h = df["high"].values
    l = df["low"].values
    o = df["open"].values
    v = df["vol"].values

    # EMA stack
    e9   = safe_ema(c, 9)
    e21  = safe_ema(c, 21)
    e50  = safe_ema(c, 50)
    e200 = safe_ema(c, 200)
    vma20 = safe_sma(v, 20)
    rsi14 = safe_rsi(c, 14)
    macd_, macds_ = macd_arr(c)
    atr14 = safe_atr(df, 14)
    bb_u, bb_m, bb_l, bb_w = bb_bands(c, 20, 2.0)

    # ── EMA hizalama (0-5)
    ema_stack = sum([
        c[bi] > e9[bi],
        e9[bi] > e21[bi],
        e21[bi] > e50[bi],
        e50[bi] > e200[bi],
        (bi >= 5 and e50[bi] > e50[bi-5])
    ])

    # ── Up Volume Ratio (son 20 gün)
    lb = min(20, bi - 1)
    up_vol_days = sum(1 for k in range(bi - lb + 1, bi + 1)
                      if c[k] > c[k-1] and v[k] > vma20[k])
    uv_ratio = up_vol_days / lb

    # ── Pocket Pivot (medyan tabanlı)
    pp_lb = min(10, bi - 1)
    down_vols = [v[k] for k in range(bi - pp_lb, bi) if c[k] < c[k-1]]
    med_dv = float(np.median(down_vols)) if down_vols else 0
    pp_ok = (c[bi] > c[bi-1]) and (v[bi] > med_dv) and (v[bi] > vma20[bi])
    pp_partial = (c[bi] > c[bi-1]) and (v[bi] > med_dv) and not (v[bi] > vma20[bi])

    # ── VCP (basit): son 60 barda pivot daralmasi
    vcp_start = max(0, bi - 60)
    widths = []
    for k in range(vcp_start + 2, bi - 1):
        if h[k] >= max(h[k-2:k]) and h[k] >= max(h[k+1:k+3]):
            for j in range(k + 1, min(k + 15, bi)):
                if l[j] <= min(l[j-2:j]) if j >= 2 else True:
                    rng = (h[k] - l[j]) / h[k] if h[k] > 0 else 0
                    widths.append(rng)
                    break
    vcp_ok = (len(widths) >= 3 and
              all(widths[i] < widths[i-1] * 0.90 for i in range(1, min(len(widths), 4))))

    # ── NR7
    nr7 = all((h[bi] - l[bi]) < (h[k] - l[k]) for k in range(bi-6, bi))

    # ── BB Squeeze: bandwidth son 6 ayın alt %15'inde
    bb_hist = bb_w[max(0, bi-126):bi+1]
    bb_sq = len(bb_hist) >= 20 and bb_w[bi] <= np.percentile(bb_hist, 15)

    # ── Relative Strength vs XU100 (20 günlük)
    rs20 = 0.0
    df_xu = load("XU100", "Gunluk")
    if df_xu is not None:
        bi_xu = get_bar_idx(df_xu, ANALIZ_TARIHI)
        if bi_xu is not None and bi_xu > 22 and bi > 22:
            cx = df_xu["close"].values
            sem_ret = (c[bi] - c[bi-20]) / (c[bi-20] + 1e-9)
            xu_ret  = (cx[bi_xu] - cx[bi_xu-20]) / (cx[bi_xu-20] + 1e-9)
            rs20 = (sem_ret - xu_ret) * 100

    # ── 52w High mesafe
    hh252 = max(h[max(0, bi-252):bi+1])
    dist52 = (hh252 - c[bi]) / hh252 * 100 if hh252 > 0 else 99

    # ── Günlük değişim
    day_ret = (c[bi] - c[bi-1]) / c[bi-1] * 100 if c[bi-1] > 0 else 0

    # ── Mum formasyonları
    body = abs(c[bi] - o[bi])
    rng  = h[bi] - l[bi] + 1e-9
    low_shadow  = min(o[bi], c[bi]) - l[bi]
    high_shadow = h[bi] - max(o[bi], c[bi])
    avg_body = np.mean(abs(c[max(0,bi-14):bi] - o[max(0,bi-14):bi])) + 1e-9
    # Hammer
    hammer = (body < avg_body * 0.7 and low_shadow >= body * 2 and high_shadow <= body * 0.5
              and c[bi] > c[bi-1])
    # Bullish Engulfing
    engulfing = (c[bi] > o[bi] and o[bi-1] > c[bi-1]
                 and c[bi] > o[bi-1] and o[bi] < c[bi-1])
    # Doji near support
    doji = body < rng * 0.1

    # ── PreMove skor (basit)
    def uvscore(uv):
        if uv >= 0.50: return 35
        if uv >= 0.20: return (uv - 0.20) / 0.30 * 30 + 5
        return 0
    ema_s = min(20, ema_stack * 4)
    pp_s  = 15 if pp_ok else (8 if pp_partial else 0)
    vcp_s = 16 if vcp_ok else (8 if len(widths) >= 2 else 0)
    if nr7: vcp_s = min(20, vcp_s + 4)
    mom_s = 0
    if 45 < rsi14[bi] < 72 and rsi14[bi] > rsi14[bi-1]: mom_s += 4
    if macd_[bi] > macd_[bi-1] and macd_[bi] > macds_[bi]: mom_s += 2
    bonus_s = 2 if (h[max(0,bi-40):bi+1].max() - l[max(0,bi-40):bi+1].min()) > 0 and (
        (c[bi] - l[max(0,bi-40):bi+1].min()) /
        (h[max(0,bi-40):bi+1].max() - l[max(0,bi-40):bi+1].min() + 1e-9) >= 0.55) else 0
    premove_puan = min(100, ema_s + uvscore(uv_ratio) + pp_s + vcp_s + mom_s + bonus_s)

    return {
        "symbol": symbol,
        "close": round(c[bi], 2),
        "day_ret": round(day_ret, 2),
        "ema_stack": ema_stack,
        "uv_ratio": round(uv_ratio, 3),
        "pp_ok": pp_ok,
        "pp_partial": pp_partial,
        "vcp_ok": vcp_ok,
        "vcp_pivots": len(widths),
        "nr7": nr7,
        "bb_squeeze": bb_sq,
        "rs20": round(rs20, 2),
        "dist52w": round(dist52, 1),
        "rsi": round(rsi14[bi], 1),
        "macd_pos": macd_[bi] > macds_[bi],
        "hammer": hammer,
        "engulfing": engulfing,
        "doji": doji,
        "premove_puan": round(premove_puan, 1),
        "atr": round(atr14[bi], 3),
        "vol_ratio": round(v[bi] / (vma20[bi] + 1e-9), 2),
    }

# ══════════════════════════════════════════════════════════════════
# 4) GÜN İÇİ ANALİZ — 60dk, 15dk, 5dk
# ══════════════════════════════════════════════════════════════════

def analiz_intraday(symbol: str, period: str) -> Optional[Dict]:
    df = load(symbol, period)
    if df is None:
        return None

    # O gün içindeki barları al
    ts_target = pd.Timestamp(ANALIZ_TARIHI)
    day_mask = df["dt"].dt.normalize() == ts_target
    if not day_mask.any():
        return None
    day_df = df[day_mask].reset_index(drop=True)
    if len(day_df) < 5:
        return None

    # Tüm geçmiş (EMA için en az 50 bar gerekli)
    bi_end = get_bar_idx(df, ANALIZ_TARIHI)
    if bi_end is None or bi_end < 50:
        return None

    c_all = df["close"].values
    v_all = df["vol"].values
    h_all = df["high"].values
    l_all = df["low"].values

    e9  = safe_ema(c_all, 9)
    e21 = safe_ema(c_all, 21)
    e50 = safe_ema(c_all, 50)
    vma20 = safe_sma(v_all, 20)
    rsi   = safe_rsi(c_all, 14)
    macd_, macds_ = macd_arr(c_all)
    atr = safe_atr(df, 14)
    bb_u, bb_m, bb_l, bb_w = bb_bands(c_all, 20, 2.0)

    bi = bi_end  # Son bar (gün sonu)

    # ── EMA hizalama (günlük karar — son barına göre)
    ema_intra = sum([
        c_all[bi] > e9[bi],
        e9[bi] > e21[bi],
        e21[bi] > e50[bi],
    ])

    # ── Gün içi: açılış - kapanış hareketi
    first_bar  = day_df.iloc[0]
    last_bar   = day_df.iloc[-1]
    open_price = float(first_bar["open"])
    close_price = float(last_bar["close"])
    day_range  = float(day_df["high"].max() - day_df["low"].min())
    intra_ret  = (close_price - open_price) / (open_price + 1e-9) * 100

    # ── Gün içi momentum: son 3 bar yükseliyor mu?
    n_day = len(day_df)
    last3_close = day_df["close"].values[-3:]
    mom3 = float(last3_close[-1]) > float(last3_close[0]) if len(last3_close) == 3 else False

    # ── BB Squeeze (intraday)
    bb_hist = bb_w[max(0, bi-100):bi+1]
    bb_sq = len(bb_hist) >= 20 and bb_w[bi] <= np.percentile(bb_hist, 20)

    # ── Ortalamaya dönüş (MRV): fiyat EMA21'in altında mı, RSI 35 altında mı?
    mrv_sell = c_all[bi] > bb_u[bi] and rsi[bi] > 70  # Üst banddan dönüş
    mrv_buy  = c_all[bi] < bb_l[bi] and rsi[bi] < 30   # Alt banddan dönüş

    # ── Mini-VCP (gün içi — son 20 bar): son 5 bar hacmi kuruyor mu?
    start_20 = max(0, bi - 20)
    vol_20 = np.mean(v_all[start_20:bi+1]) if bi > start_20 else 0
    vol_5  = np.mean(v_all[max(0,bi-4):bi+1])
    intra_vdu = vol_20 > 0 and vol_5 < vol_20 * 0.65

    # ── Breakout: son bar önceki n barın en yükseği kırıyor mu?
    n_bo = 12  # Son 12 bar pivot
    if bi >= n_bo:
        prev_high = max(h_all[bi-n_bo:bi])
        bo_ok = c_all[bi] > prev_high and v_all[bi] > vma20[bi]
    else:
        bo_ok = False

    # ── Gün içi hacim paterni: sabah - öğle - kapanış
    n_day_bars = len(day_df)
    if n_day_bars >= 9:
        sabah_vol = day_df["vol"].values[:3].sum()
        ogle_vol  = day_df["vol"].values[n_day_bars//2-1:n_day_bars//2+2].sum()
        kapan_vol = day_df["vol"].values[-3:].sum()
        vol_pattern = "SABAH_GUÇLÜ" if sabah_vol > ogle_vol and sabah_vol > kapan_vol else (
                      "KAPANIS_GUÇLÜ" if kapan_vol > sabah_vol else "DENGELI")
    else:
        vol_pattern = "VERİ_YOK"

    # ── Scalp skoru (5dk/15dk için)
    scalp = 0
    if period in ("5dk", "15dk"):
        if ema_intra == 3:         scalp += 30  # Tam EMA hizalı
        elif ema_intra == 2:       scalp += 15
        if bo_ok:                  scalp += 25  # Kırılım
        if intra_vdu:              scalp += 15  # VDU öncesi
        if bb_sq:                  scalp += 15  # BB sıkışma
        if mom3:                   scalp += 10  # Son 3 bar momentum
        if rsi[bi] > 55:           scalp += 5
        scalp = min(100, scalp)

    return {
        "symbol": symbol,
        "period": period,
        "open": round(open_price, 2),
        "close": round(close_price, 2),
        "intra_ret": round(intra_ret, 2),
        "day_range_pct": round(day_range / (open_price + 1e-9) * 100, 2),
        "ema_intra": ema_intra,
        "mom3": mom3,
        "bb_squeeze": bb_sq,
        "mrv_buy": mrv_buy,
        "mrv_sell": mrv_sell,
        "vdu": intra_vdu,
        "breakout": bo_ok,
        "vol_pattern": vol_pattern,
        "rsi": round(rsi[bi], 1),
        "scalp_score": scalp,
    }

# ══════════════════════════════════════════════════════════════════
# 5) VIP/ENDEKSLERİN KORELASYONU
# ══════════════════════════════════════════════════════════════════

VIP_SEMBOLLER = {
    "XU100":  ("IMKBH", "G"),   # BIST100 endeksi
    "XU030":  ("IMKBH", "G"),
    "VIOP":   ("VIP",   "G"),    # VIOP F_XU0300426 gibi
}

def analiz_endeksler():
    result = {}
    for sym in ["XU100"]:
        df = load(sym, "Gunluk")
        if df is None:
            continue
        bi = get_bar_idx(df, ANALIZ_TARIHI)
        if bi is None or bi < 50:
            continue
        c = df["close"].values
        e50 = safe_ema(c, 50)
        e200 = safe_ema(c, 200)
        rsi = safe_rsi(c, 14)
        day_ret = (c[bi] - c[bi-1]) / c[bi-1] * 100 if c[bi-1] > 0 else 0
        ret5 = (c[bi] - c[bi-5]) / c[bi-5] * 100 if c[bi-5] > 0 else 0
        above_e50  = c[bi] > e50[bi]
        above_e200 = c[bi] > e200[bi]
        e50_rising = e50[bi] > e50[bi-5]
        result[sym] = {
            "close": round(c[bi], 2),
            "day_ret": round(day_ret, 2),
            "ret_5g": round(ret5, 2),
            "above_ema50": above_e50,
            "above_ema200": above_e200,
            "ema50_yukselen": e50_rising,
            "rsi": round(rsi[bi], 1),
            "mod": "NORMAL" if above_e50 and e50_rising else
                   ("DIKKATLI" if above_e50 or above_e200 else "CRASH"),
        }
    # VIP vadeli/emtia
    vip_dir = Path(r"D:\iDeal\ChartData\VIP\G")
    if vip_dir.exists():
        import struct, datetime as dtmod
        DAILY_REF_DATE = date(2026, 4, 9)
        DAILY_REF_TS = 778089
        vip_files = list(vip_dir.glob("*.G"))[:15]
        vip_sonuc = []
        for fp in vip_files:
            try:
                with open(fp, "rb") as f:
                    data = f.read()
                n = len(data) // 32
                if n < 2:
                    continue
                def r(i):
                    ts,o,h,l,c,lot,tl,_ = struct.unpack_from("<IffffffI", data, i*32)
                    d = DAILY_REF_DATE + dtmod.timedelta(days=ts - DAILY_REF_TS)
                    return d, o, h, l, c
                d_last, o_l, h_l, l_l, c_l = r(n-1)
                d_prev, o_p, h_p, l_p, c_p = r(n-2)
                if d_last != ANALIZ_TARIHI:
                    continue
                ret = (c_l - c_p) / (c_p + 1e-9) * 100
                isim = fp.stem.replace("VIP'", "").replace("VIP-", "")
                vip_sonuc.append((isim, round(c_l, 2), round(ret, 2)))
            except:
                pass
        result["VIP_OZET"] = sorted(vip_sonuc, key=lambda x: abs(x[2]), reverse=True)[:10]
    return result

# ══════════════════════════════════════════════════════════════════
# 6) ANA AKIŞ
# ══════════════════════════════════════════════════════════════════

def main():
    print("=" * 80)
    print("KAPSaMLI ANALİZ — 10.04.2026")
    print("=" * 80)

    yukselen, dusen = parse_liste()
    print(f"Liste: {len(yukselen)} yükselen, {len(dusen)} düşen\n")

    # Yükselen kategoriler
    yukselen_5plus  = [s for s, p in yukselen if p >= 5.0]
    yukselen_3to5   = [s for s, p in yukselen if 3.0 <= p < 5.0]
    yukselen_1to3   = [s for s, p in yukselen if 1.0 <= p < 3.0]

    print(f"  ≥%5  : {len(yukselen_5plus)} sembol: {', '.join(yukselen_5plus)}")
    print(f"  3-5% : {len(yukselen_3to5)} sembol")
    print(f"  1-3% : {len(yukselen_1to3)} sembol")

    # Tüm yükselenleri analiz et
    tum_semboller = [s for s, _ in yukselen[:80]] + [s for s, _ in dusen[:30]]
    tum_semboller = list(dict.fromkeys(tum_semboller))  # tekrar kaldır

    print(f"\n[A] GÜNLÜK ANALİZ ({len(tum_semboller)} sembol)...")
    gunluk_data = {}
    for sym in tum_semboller:
        r = analiz_gunluk(sym)
        if r:
            gunluk_data[sym] = r

    print(f"  Veri bulunan: {len(gunluk_data)}/{len(tum_semboller)}")

    # ── A1: PreMove yakaladı mı?
    yukselen_5_set = {s for s, p in yukselen if p >= 5.0}
    yukselen_3_set = {s for s, p in yukselen if p >= 3.0}

    premove_yuksek = [s for s, d in gunluk_data.items() if d["premove_puan"] >= 65]
    premove_takip  = [s for s, d in gunluk_data.items() if 45 <= d["premove_puan"] < 65]
    premove_atladi = [s for s in yukselen_5_set if s in gunluk_data and gunluk_data[s]["premove_puan"] < 45]

    print(f"\n{'─'*70}")
    print("A) PREMove SCANNER PERFORMANSI (≥5% yükselen için)")
    print(f"{'─'*70}")
    analiz_secim = [s for s in yukselen_5_set if s in gunluk_data]
    if analiz_secim:
        yakaladigi = [s for s in analiz_secim if gunluk_data[s]["premove_puan"] >= 45]
        print(f"  ≥5% toplam {len(yukselen_5_set)} | veri: {len(analiz_secim)} | PreMove≥45p yakaladı: {len(yakaladigi)}")
        if len(analiz_secim) > 0:
            recall = len(yakaladigi) / len(analiz_secim) * 100
            print(f"  Recall: %{recall:.1f}")

        # Eksik kalan hisseler — neden atlandı?
        print(f"\n  [ATLANMIŞ ≥5% hisseler]  (PreMove<45p):")
        for s in premove_atladi[:20]:
            d = gunluk_data[s]
            puan_yukselen = next((p for sym, p in yukselen if sym == s), 0)
            print(f"    {s:8s} +%{puan_yukselen:.1f}  PreMove={d['premove_puan']} | "
                  f"EMA={d['ema_stack']} UV={d['uv_ratio']:.2f} PP={'✓' if d['pp_ok'] else '✗'} "
                  f"VCP={'✓' if d['vcp_ok'] else '✗'} RSI={d['rsi']} "
                  f"BBsq={'✓' if d['bb_squeeze'] else '✗'}")

    # ── B: Hangi kriterler en çok yükseleni ayırt ediyor?
    print(f"\n{'─'*70}")
    print("B) KRİTER BAŞARI ORANLARI (yükselen≥5% vs geri kalan)")
    print(f"{'─'*70}")
    hits = yukselen_5_set & set(gunluk_data.keys())
    rest = set(s for s, p in yukselen if p < 3.0 and s in gunluk_data) | \
           {s for s, _ in dusen if s in gunluk_data}

    kriterler = [
        ("EMA_full(5/5)",      lambda d: d["ema_stack"] == 5),
        ("EMA_partial(≥3)",    lambda d: d["ema_stack"] >= 3),
        ("UV≥0.40",            lambda d: d["uv_ratio"] >= 0.40),
        ("UV≥0.25",            lambda d: d["uv_ratio"] >= 0.25),
        ("UV≥0.20",            lambda d: d["uv_ratio"] >= 0.20),
        ("Pocket_Pivot_tam",   lambda d: d["pp_ok"]),
        ("Pocket_Pivot_kısmi", lambda d: d["pp_ok"] or d["pp_partial"]),
        ("VCP_ok",             lambda d: d["vcp_ok"]),
        ("NR7",                lambda d: d["nr7"]),
        ("BB_Squeeze",         lambda d: d["bb_squeeze"]),
        ("RS20>0",             lambda d: d["rs20"] > 0),
        ("RS20>+2",            lambda d: d["rs20"] > 2),
        ("RSI_45_72",          lambda d: 45 < d["rsi"] < 72),
        ("Hammer",             lambda d: d["hammer"]),
        ("Engulfing",          lambda d: d["engulfing"]),
        ("Dist52w<5%",         lambda d: d["dist52w"] < 5),
        ("VolRatio>1.5",       lambda d: d["vol_ratio"] > 1.5),
        ("PreMove≥65",         lambda d: d["premove_puan"] >= 65),
        ("PreMove≥45",         lambda d: d["premove_puan"] >= 45),
    ]

    kriter_sonuclari = []
    for isim, fn in kriterler:
        hit_true  = sum(1 for s in hits if fn(gunluk_data[s]))
        hit_n     = len(hits)
        rest_true = sum(1 for s in rest if fn(gunluk_data[s]))
        rest_n    = len(rest)
        if hit_n == 0:
            continue
        precision = hit_true / (hit_true + rest_true + 1e-9) * 100
        recall_k  = hit_true / hit_n * 100
        f1 = 2 * precision * recall_k / (precision + recall_k + 1e-9)
        kriter_sonuclari.append((isim, hit_true, hit_n, rest_true, rest_n,
                                  round(precision, 1), round(recall_k, 1), round(f1, 1)))

    kriter_sonuclari.sort(key=lambda x: x[7], reverse=True)
    print(f"  {'Kriter':<22} {'Hit/Tot':>8} {'FP':>5} {'Prec%':>7} {'Rec%':>6} {'F1':>5}")
    print(f"  {'─'*60}")
    for r in kriter_sonuclari:
        print(f"  {r[0]:<22} {r[1]:>3}/{r[2]:<3}    {r[3]:>3}   {r[5]:>6.1f}% {r[6]:>5.1f}% {r[7]:>4.1f}")

    # ── C: 60dk analizi — gün içi yapı
    print(f"\n{'─'*70}")
    print("C) GÜN İÇİ YAPI — 60dk (yükselen ≥5%)")
    print(f"{'─'*70}")
    intra60 = {}
    for s in list(yukselen_5_set)[:40]:
        r = analiz_intraday(s, "60dk")
        if r:
            intra60[s] = r

    if intra60:
        # EMA hizalama dağılımı
        ema_dist = {0:0, 1:0, 2:0, 3:0}
        for d in intra60.values():
            ema_dist[d["ema_intra"]] = ema_dist.get(d["ema_intra"], 0) + 1
        print(f"  60dk EMA hizalama (0-3): " + " | ".join(f"{k}:{v}" for k,v in sorted(ema_dist.items())))

        bo_count = sum(1 for d in intra60.values() if d["breakout"])
        sq_count = sum(1 for d in intra60.values() if d["bb_squeeze"])
        mrv_b    = sum(1 for d in intra60.values() if d["mrv_buy"])
        print(f"  Breakout: {bo_count}/{len(intra60)} | BB_Squeeze: {sq_count}/{len(intra60)} | MRV_buy: {mrv_b}/{len(intra60)}")

        avg_ret = np.mean([d["intra_ret"] for d in intra60.values()])
        print(f"  Gün içi ort. getiri: %{avg_ret:.2f}")

        # En iyi scalp adayları (60dk skoru yüksek)
        vol_patt = {}
        for d in intra60.values():
            vol_patt[d["vol_pattern"]] = vol_patt.get(d["vol_pattern"], 0) + 1
        print(f"  Hacim paterni: " + " | ".join(f"{k}:{v}" for k,v in vol_patt.items()))

    # ── D: 15dk analizi
    print(f"\n{'─'*70}")
    print("D) GÜN İÇİ YAPI — 15dk (yükselen ≥3%)")
    print(f"{'─'*70}")
    analiz_15_setr = list(yukselen_3_set)[:50]
    intra15 = {}
    for s in analiz_15_setr:
        r = analiz_intraday(s, "15dk")
        if r:
            intra15[s] = r
    print(f"  Veri bulunan: {len(intra15)}/{len(analiz_15_setr)}")
    if intra15:
        scalp_guçlü = [(s, d["scalp_score"], d) for s, d in intra15.items() if d["scalp_score"] >= 60]
        scalp_guçlü.sort(key=lambda x: x[1], reverse=True)
        print(f"  15dk Scalp skoru ≥60: {len(scalp_guçlü)} sembol")
        for s, sc, d in scalp_guçlü[:15]:
            pct = next((p for sym, p in yukselen if sym == s), 0)
            print(f"    {s:8s} +%{pct:4.1f}  Scalp={sc:3d} | "
                  f"EMA={d['ema_intra']} BO={'✓' if d['breakout'] else '✗'} "
                  f"VDU={'✓' if d['vdu'] else '✗'} BBsq={'✓' if d['bb_squeeze'] else '✗'} "
                  f"RSI={d['rsi']}")

    # ── E: 5dk scalp analizi
    print(f"\n{'─'*70}")
    print("E) SCALP ODAĞI — 5dk (yükselen ≥5%)")
    print(f"{'─'*70}")
    intra5 = {}
    for s in list(yukselen_5_set)[:40]:
        r = analiz_intraday(s, "5dk")
        if r:
            intra5[s] = r
    print(f"  Veri bulunan: {len(intra5)}/{min(40, len(yukselen_5_set))}")
    if intra5:
        scalp5 = [(s, d["scalp_score"], d) for s, d in intra5.items()]
        scalp5.sort(key=lambda x: x[1], reverse=True)
        print(f"\n  TOP 20 SCALP (5dk skoru):")
        print(f"  {'Sembol':8s} {'Getiri':>7} {'Scalp':>6} {'EMA':>4} {'BO':>4} {'VDU':>4} {'BBsq':>5} {'RSI':>5}")
        print(f"  {'─'*55}")
        for s, sc, d in scalp5[:20]:
            pct = next((p for sym, p in yukselen if sym == s), 0)
            print(f"  {s:8s} +%{pct:4.1f}  {sc:6d}  {d['ema_intra']:>3}  "
                  f"{'✓' if d['breakout'] else '✗':>3}  "
                  f"{'✓' if d['vdu'] else '✗':>3}  "
                  f"{'✓' if d['bb_squeeze'] else '✗':>4}  {d['rsi']:>5.1f}")

        # 5dk için scalp kriter analizi
        all5_hit = [d for s, d in intra5.items() if any(sym == s and p >= 5.0 for sym, p in yukselen)]
        all5_miss = [d for s, d in intra5.items() if any(sym == s and p < 3.0 for sym, p in yukselen)]
        if all5_hit and all5_miss:
            print(f"\n  5dk KRITER KARŞILAŞTIRMASI (≥5% vs <3%):")
            for lbl, fn in [
                ("EMA_hizali(3)",    lambda d: d["ema_intra"] == 3),
                ("Breakout",         lambda d: d["breakout"]),
                ("BB_Squeeze",       lambda d: d["bb_squeeze"]),
                ("VDU",              lambda d: d["vdu"]),
                ("Momentum3",        lambda d: d["mom3"]),
                ("RSI>55",           lambda d: d["rsi"] > 55),
                ("ScalpSkor≥60",     lambda d: d["scalp_score"] >= 60),
            ]:
                hit_r  = sum(fn(d) for d in all5_hit)  / len(all5_hit)  * 100
                miss_r = sum(fn(d) for d in all5_miss) / len(all5_miss) * 100 if all5_miss else 0
                uplift = hit_r - miss_r
                bar = "█" * int(abs(uplift) / 3)
                print(f"    {lbl:<20} Yükselen:%{hit_r:4.0f}  Diğer:%{miss_r:4.0f}  Fark:+%{uplift:4.1f} {bar}")

    # ── F: Endeks & VIP
    print(f"\n{'─'*70}")
    print("F) ENDEKS & VADELİ/EMTİA BAĞLAMI")
    print(f"{'─'*70}")
    endeks = analiz_endeksler()
    for k, v in endeks.items():
        if k == "VIP_OZET":
            print(f"\n  Tepe 10 VIP (10.04 hareketi):")
            for isim, kap, ret in v:
                bar = ("▲" if ret > 0 else "▼") * min(10, int(abs(ret) * 2))
                print(f"    {isim:20s} {kap:>10.2f}  %{ret:+.2f}  {bar}")
        else:
            d = v
            print(f"  {k}: {d['close']}  %{d['day_ret']:+.2f}  "
                  f"[{d['mod']}]  RSI={d['rsi']}  EMA50={'↑' if d['ema50_yukselen'] else '↓'}")

    # ── G: ÖNERILER VE EYLEM PLANI
    print(f"\n{'═'*80}")
    print("G) STRATEJİ BOŞLUK ANALİZİ VE ÖNERİLER")
    print(f"{'═'*80}")

    # En yüksek F1'e göre ipuçları
    if kriter_sonuclari:
        top_kriter = kriter_sonuclari[0]
        print(f"\n  EN GÜÇLÜ GÜNLÜK KRİTER: {top_kriter[0]}")
        print(f"    Hit:{top_kriter[1]}/{top_kriter[2]} | Prec:{top_kriter[5]}% | F1:{top_kriter[7]}")

    # PreMove atladığı ve ≥5% giden hisseler
    onemli_atlanan = [(s, next((p for sym,p in yukselen if sym==s), 0), gunluk_data[s])
                      for s in premove_atladi if s in gunluk_data]
    onemli_atladan = sorted(onemli_atlanan, key=lambda x: x[1], reverse=True)[:10]

    print(f"\n  ─── NEDENİ ATLANMIŞ (%5+ giden ama PreMove<45p) ───")
    for s, pct, d in onemli_atladan:
        print(f"  {s:8s} +%{pct:.1f} | EMA={d['ema_stack']} UV={d['uv_ratio']:.2f} "
              f"PP={'✓' if d['pp_ok'] else '✗'} RSI={d['rsi']:.0f} BBsq={'✓' if d['bb_squeeze'] else '✗'}")

    # BB Squeeze yakalanan ama PreMove'da yok
    bb_ekstra = [s for s, d in gunluk_data.items()
                 if d["bb_squeeze"] and any(sym == s and p >= 3.0 for sym, p in yukselen)
                 and d["premove_puan"] < 45]
    if bb_ekstra:
        print(f"\n  BB Squeeze + ≥3% yükselen ama PreMove<45p: {', '.join(bb_ekstra[:10])}")
        print(f"  → önerim: BB Squeeze'e ayrı 5-8p bonus eklenmeli")

    # NR7 analizi
    nr7_hit = sum(1 for s in yukselen_5_set if s in gunluk_data and gunluk_data[s]["nr7"])
    print(f"\n  NR7 istatistik: ≥5% yükselenlerin {nr7_hit}/{len(yukselen_5_set & set(gunluk_data))} tanesi NR7'deydi")

    print(f"\n  ─── SCALP REHBERİ ───")
    print(f"  5dk YÜKSEK: EMA3/3 + Breakout + VDU  →  hedef: AT14×1.0, stop: AT14×0.7")
    print(f"  15dk MRV:   RSI<30 + BB alt bant      →  ortalamaya dönüş etkisi ≈2bar")
    print(f"  60dk TREND: EMA hizalı + sabah hacim  →  güne trend yönünde gir, öğle çık")

    # ═══════════════════════════════════════════════════════
    # CSV çıktı
    # ═══════════════════════════════════════════════════════
    rows = []
    for s, gd in gunluk_data.items():
        yp = next((p for sym, p in yukselen if sym == s), None)
        dp = next((p for sym, p in dusen   if sym == s), None)
        row = {"liste": "YUK" if yp is not None else ("DUS" if dp is not None else ""),
               "pct_degisim": yp if yp else dp, **gd}
        # intraday ekle
        for per in ["60dk", "15dk", "5dk"]:
            idkey = f"{s}_{per}"
            id_data = intra60.get(s) if per == "60dk" else (
                      intra15.get(s) if per == "15dk" else intra5.get(s))
            if id_data:
                for k, v2 in id_data.items():
                    if k not in ("symbol", "period"):
                        row[f"{per}_{k}"] = v2
        rows.append(row)

    df_out = pd.DataFrame(rows)
    out_csv = Path(r"D:\Projects\IdealQuant\scanner\kapsamli_analiz_20260410.csv")
    df_out.to_csv(out_csv, index=False, encoding=ENC, sep=";")
    print(f"\n  CSV kaydedildi: {out_csv}")
    print(f"  Toplam satır: {len(df_out)}")

    print(f"\n{'═'*80}")
    print(f"ANALİZ TAMAMLANDI — {datetime.now().strftime('%d.%m.%Y %H:%M:%S')}")
    print(f"{'═'*80}")

if __name__ == "__main__":
    main()
