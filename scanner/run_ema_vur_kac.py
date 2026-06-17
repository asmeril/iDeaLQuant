"""
run_ema_vur_kac.py — EMA Vur Kaç Strateji Backtest Runner
==========================================================
IdealQuant altyapısını (loader + indicators) kullanarak
EmaVurKacStrategy'yi tüm semboller üzerinde çalıştırır.

Kullanım:
    python run_ema_vur_kac.py                          # tüm semboller, 2015+
    python run_ema_vur_kac.py --liste bist30           # sadece BIST30
    python run_ema_vur_kac.py --min-below 5 --trail 2  # parametre değiştir
    python run_ema_vur_kac.py --baslangic 2020-01-01   # tarih filtresi
    python run_ema_vur_kac.py --csv sonuc.csv          # CSV çıktısı
"""
from __future__ import annotations

import sys
import io
import argparse
from pathlib import Path
from typing import List, Optional
from datetime import datetime

import pandas as pd
import numpy as np

# Encoding fix
if sys.stdout.encoding and sys.stdout.encoding.lower() in ("cp1254", "cp1252", "ascii"):
    sys.stdout = io.TextIOWrapper(sys.stdout.buffer, encoding="utf-8", errors="replace")
    sys.stderr = io.TextIOWrapper(sys.stderr.buffer, encoding="utf-8", errors="replace")

# Path setup
_SCANNER_DIR = Path(__file__).parent
_BASE_DIR    = _SCANNER_DIR.parent
for p in [str(_SCANNER_DIR), str(_BASE_DIR), str(_BASE_DIR / "src")]:
    if p not in sys.path:
        sys.path.insert(0, p)

from loader import load, list_available_symbols
from config import SEMBOLLER_70
from strategies.ema_vur_kac_strategy import EmaVurKacStrategy
from strategies.common import Signal  # noqa: F401

# ─── Sembol listeleri ────────────────────────────────────────────
BIST30 = [
    "AKBNK","AKSEN","ARCLK","ASELS","BIMAS","DOHOL","EKGYO","EREGL",
    "FROTO","GARAN","GUBRF","HALKB","ISCTR","KCHOL","KOZAA","KOZAL",
    "KRDMD","MGROS","OYAKC","PETKM","PGSUS","SAHOL","SASA","SISE",
    "SOKM","TAVHL","TCELL","THYAO","TKFEN","TOASO","TSKB","TTKOM",
    "TTRAK","TUPRS","VAKBN","VESTL","YKBNK",
]
BIST50 = BIST30 + [
    "AEFES","AFYON","ALARK","ALBRK","ALKIM","ANACM","AYGAZ","BAGFS",
    "BANVT","BRSAN","CCOLA","CEMTS","CIMSA","DOAS","ENKAI",
]

def get_symbols(liste: str) -> List[str]:
    if liste.lower() == "bist30":
        return BIST30
    elif liste.lower() == "bist50":
        return BIST50
    elif liste.lower() in ("70", "scanner70"):
        return SEMBOLLER_70
    else:
        return [s for s in list_available_symbols("Gunluk")
                if s not in ("XU100", "XU030")]


# ─── Tek sembol backtest ─────────────────────────────────────────
def backtest_symbol(
    sym: str,
    min_below: int,
    trail_pct: float,
    start_ts: Optional[pd.Timestamp],
    end_ts: Optional[pd.Timestamp],
) -> List[dict]:
    """
    Bir sembol için tüm işlemleri döner.
    Giriş fiyatı  = sinyal barı kapanışı
    Çıkış fiyatı  = trailing stop tetiklendiği bardaki stop seviyesi
                    (strategy içinde lows[i] <= stop_seviye kontrolü)
    """
    df = load(sym, "Gunluk")
    if df is None or len(df) < 40:
        return []

    closes  = df["close"].tolist()
    highs   = df["high"].tolist()
    lows    = df["low"].tolist()
    volumes = df["vol"].tolist()
    dts     = df["dt"].tolist()

    strategy = EmaVurKacStrategy({
        "min_below":         min_below,
        "trailing_stop_pct": trail_pct,
    })

    signals = strategy.calculate_signals(closes, highs, lows)

    try:
        from indicators.core import EMA as _EMA
    except ImportError:
        from src.indicators.core import EMA as _EMA
    e5  = _EMA(closes, 5)
    e8  = _EMA(closes, 8)
    e13 = _EMA(closes, 13)

    trades    = []
    pozisyon  = 0
    entry_bar = 0
    entry_px  = 0.0
    max_h     = 0.0
    stop_sev  = 0.0
    iz_oran   = trail_pct / 100.0

    n = len(signals)
    for i in range(n):
        dt_i = dts[i]

        # Tarih filtresi (sadece giriş için)
        if pozisyon == 0:
            if start_ts and pd.Timestamp(dt_i) < start_ts:
                continue
            if end_ts and pd.Timestamp(dt_i) > end_ts:
                break

        if pozisyon == 0:
            if signals[i] == Signal.LONG:
                pozisyon  = 1
                entry_bar = i
                entry_px  = closes[i]
                max_h     = closes[i]
                stop_sev  = closes[i] * (1.0 - iz_oran)

        elif pozisyon == 1:
            h = highs[i]
            l = lows[i]

            if h > max_h:
                max_h    = h
                yeni_s   = max_h * (1.0 - iz_oran)
                if yeni_s > stop_sev:
                    stop_sev = yeni_s

            if l <= stop_sev or signals[i] == Signal.FLAT:
                exit_px  = stop_sev if l <= stop_sev else closes[i]
                pnl_pct  = (exit_px - entry_px) / entry_px * 100

                # EMA13 eğimi (giriş barında son 3 bar)
                e13_slope = e13[entry_bar] - e13[max(0, entry_bar - 3)]

                # Hacim oranı (giriş barı)
                vol_avg = (sum(volumes[max(0, entry_bar-5):entry_bar]) /
                           max(1, min(5, entry_bar))) if entry_bar > 0 else 1.0
                vol_ratio = volumes[entry_bar] / vol_avg if vol_avg > 0 else 1.0

                trades.append({
                    "sembol":       sym,
                    "giris_tarihi": pd.Timestamp(dts[entry_bar]).strftime("%Y-%m-%d"),
                    "cikis_tarihi": pd.Timestamp(dt_i).strftime("%Y-%m-%d"),
                    "giris_fiyat":  round(entry_px, 4),
                    "cikis_fiyat":  round(exit_px, 4),
                    "pnl_pct":      round(pnl_pct, 4),
                    "kazanan":      1 if pnl_pct > 0 else 0,
                    "bars_held":    i - entry_bar,
                    "ema13_egim":   round(e13_slope, 4),
                    "hacim_oran":   round(vol_ratio, 2),
                    "yil":          pd.Timestamp(dts[entry_bar]).year,
                })
                pozisyon = 0
                max_h    = 0.0
                stop_sev = 0.0

    return trades


# ─── İstatistikler ───────────────────────────────────────────────
def istatistik(trades: List[dict]) -> dict:
    if not trades:
        return {}
    df = pd.DataFrame(trades)
    total     = len(df)
    wins      = (df["pnl_pct"] > 0).sum()
    losses    = (df["pnl_pct"] < 0).sum()
    win_rate  = wins / total * 100
    avg_win   = df.loc[df["pnl_pct"] > 0, "pnl_pct"].mean() if wins > 0 else 0.0
    avg_loss  = df.loc[df["pnl_pct"] < 0, "pnl_pct"].mean() if losses > 0 else 0.0
    expectancy = (win_rate / 100 * avg_win) + ((1 - win_rate / 100) * avg_loss)

    cum = df["pnl_pct"].cumsum()
    peak = cum.cummax()
    max_dd = (peak - cum).max()

    return {
        "toplam":     total,
        "kazanan":    int(wins),
        "kaybeden":   int(losses),
        "win_rate":   round(win_rate, 2),
        "ort_pnl":    round(df["pnl_pct"].mean(), 4),
        "ort_kazanc": round(avg_win, 4),
        "ort_kayip":  round(avg_loss, 4),
        "expectancy": round(expectancy, 4),
        "max_dd":     round(max_dd, 2),
        "toplam_pnl": round(df["pnl_pct"].sum(), 2),
        "ort_sure":   round(df["bars_held"].mean(), 1),
    }


def yillik(trades: List[dict]) -> pd.DataFrame:
    df = pd.DataFrame(trades)
    return df.groupby("yil").agg(
        islem     = ("pnl_pct", "count"),
        win_rate  = ("kazanan", lambda x: x.mean() * 100),
        ort_pnl   = ("pnl_pct", "mean"),
        toplam    = ("pnl_pct", "sum"),
        ort_sure  = ("bars_held", "mean"),
    ).round(2)


def en_iyi_semboller(trades: List[dict], top: int = 15) -> pd.DataFrame:
    df = pd.DataFrame(trades)
    return df.groupby("sembol").agg(
        islem     = ("pnl_pct", "count"),
        win_rate  = ("kazanan", lambda x: x.mean() * 100),
        ort_pnl   = ("pnl_pct", "mean"),
        toplam    = ("pnl_pct", "sum"),
    ).round(2).sort_values("toplam", ascending=False).head(top)


# ─── Rapor ───────────────────────────────────────────────────────
def rapor(stats, yil_df, sym_df, liste, baslangic, bitis, min_below, trail):
    sep = "-" * 52
    print(f"\n{'='*52}")
    print(f"  EMA 5-8-13 VUR KAC — IdealQuant Backtest")
    print(f"{'='*52}")
    print(f"  Liste      : {liste}")
    print(f"  Tarih      : {baslangic} -> {bitis}")
    print(f"  Min. alti  : {min_below} bar")
    print(f"  Trail stop : %{trail}")
    print(sep)

    if not stats:
        print("  Hic islem bulunamadi.")
        return

    print(f"  Toplam islem  : {stats['toplam']}")
    print(f"  Kazanan       : {stats['kazanan']}  (%{stats['win_rate']:.1f})")
    print(f"  Kaybeden      : {stats['kaybeden']}")
    print(sep)
    print(f"  Ort. PnL/islem: %{stats['ort_pnl']:+.4f}")
    print(f"  Ort. kazanc   : %{stats['ort_kazanc']:+.4f}")
    print(f"  Ort. kayip    : %{stats['ort_kayip']:+.4f}")
    print(f"  Expectancy    : %{stats['expectancy']:+.4f}")
    print(f"  Toplam PnL    : %{stats['toplam_pnl']:+.2f}")
    print(f"  Max Drawdown  : %{stats['max_dd']:.2f}")
    print(f"  Ort. sure     : {stats['ort_sure']:.1f} bar")
    print(sep)

    print("\n  [ YILLIK ]")
    print(f"  {'Yil':>6}  {'Islem':>6}  {'WR%':>6}  {'OrtPnL':>8}  {'Toplam':>9}  {'Sure':>5}")
    print(f"  {'-'*6}  {'-'*6}  {'-'*6}  {'-'*8}  {'-'*9}  {'-'*5}")
    for yil, row in yil_df.iterrows():
        print(f"  {yil:>6}  {int(row['islem']):>6}  "
              f"{row['win_rate']:>5.1f}%  "
              f"{row['ort_pnl']:>+8.3f}%  "
              f"{row['toplam']:>+8.2f}%  "
              f"{row['ort_sure']:>5.1f}")
    print(sep)

    print("\n  [ EN IYI 15 SEMBOL ]")
    print(f"  {'Sembol':<10}  {'Islem':>6}  {'WR%':>6}  {'OrtPnL':>8}  {'Toplam':>9}")
    print(f"  {'-'*10}  {'-'*6}  {'-'*6}  {'-'*8}  {'-'*9}")
    for sym, row in sym_df.iterrows():
        print(f"  {sym:<10}  {int(row['islem']):>6}  "
              f"{row['win_rate']:>5.1f}%  "
              f"{row['ort_pnl']:>+8.3f}%  "
              f"{row['toplam']:>+8.2f}%")
    print(sep)


# ─── Main ────────────────────────────────────────────────────────
def main():
    parser = argparse.ArgumentParser(description="EMA Vur Kac IdealQuant Backtest")
    parser.add_argument("--liste",      default="tumu",       help="bist30/bist50/70/tumu")
    parser.add_argument("--baslangic",  default="2015-01-01", help="YYYY-MM-DD")
    parser.add_argument("--bitis",      default=None,         help="YYYY-MM-DD")
    parser.add_argument("--min-below",  type=int,   default=3,   help="Min ardisik EMA-alti bar")
    parser.add_argument("--trail",      type=float, default=1.0, help="Trailing stop yuzde")
    parser.add_argument("--csv",        default=None,         help="CSV cikti yolu")
    parser.add_argument("--verbose",    action="store_true")
    args = parser.parse_args()

    start_ts = pd.Timestamp(args.baslangic)
    end_ts   = pd.Timestamp(args.bitis) if args.bitis else pd.Timestamp.today()

    symbols = get_symbols(args.liste)
    print(f"\nBasliyor: {len(symbols)} sembol  |  {args.baslangic} -> {end_ts.date()}")
    print(f"Params: min_below={args.min_below}  trail=%{args.trail}\n")

    all_trades = []
    for idx, sym in enumerate(symbols, 1):
        if args.verbose:
            print(f"  [{idx:3}/{len(symbols)}] {sym:<10}", end=" ", flush=True)
        try:
            trades = backtest_symbol(sym, args.min_below, args.trail, start_ts, end_ts)
            all_trades.extend(trades)
            if args.verbose:
                print(f"{len(trades)} islem")
        except Exception as e:
            if args.verbose:
                print(f"HATA: {e}")

    print(f"\nToplam: {len(all_trades)} islem")

    stats  = istatistik(all_trades)
    yil_df = yillik(all_trades)         if all_trades else pd.DataFrame()
    sym_df = en_iyi_semboller(all_trades) if all_trades else pd.DataFrame()

    rapor(stats, yil_df, sym_df,
          liste=args.liste,
          baslangic=args.baslangic,
          bitis=str(end_ts.date()),
          min_below=args.min_below,
          trail=args.trail)

    if args.csv and all_trades:
        out = Path(args.csv)
        pd.DataFrame(all_trades).to_csv(out, index=False, encoding="utf-8-sig")
        print(f"\n  CSV: {out}")


if __name__ == "__main__":
    main()
