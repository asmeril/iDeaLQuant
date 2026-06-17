"""
backtest_ema_vur_kac.py — 5-8-13 EMA Vur Kaç Strateji Backtesti
═══════════════════════════════════════════════════════════════════
GİRİŞ KURALLARI:
  - EMA 5, 8, 13 üçlü geçiş sinyali (scanner_ema_vur_kac.py ile aynı mantık)
  - En az 3 ardışık günlük bar boyunca fiyat < EMA5 & EMA8 & EMA13
  - Sinyal günü tek barda üçünü geçip üstünde kapanış
  - Giriş fiyatı = sinyal günü KAPANIŞ

ÇIKIŞ KURALLARI:
  - Çıkış fiyatı = ertesi gün AÇILIŞ (strateji "açılışta çık" diyor)
  - Hedef: +%0.45 (ertesi açılış bu seviyeyi geçmişse → kâr)
  - Stop:  -%1.0  (ertesi açılış bu seviyenin altında → zarar)
  - Hiç biri değilse: ertesi açılışta ne olursa olsun çık (gerçekçi)

KULLANIM:
  python backtest_ema_vur_kac.py                         # Tüm semboller, tüm tarihler
  python backtest_ema_vur_kac.py --liste bist30          # Sadece BIST30
  python backtest_ema_vur_kac.py --baslangic 2020-01-01  # 2020 sonrası
  python backtest_ema_vur_kac.py --min-alti 5            # Min 5 gün altı
  python backtest_ema_vur_kac.py --hedef 0.50 --stop 1.0 # Farklı hedef/stop
  python backtest_ema_vur_kac.py --csv cikti.csv         # Sonuçları CSV'ye yaz
"""
from __future__ import annotations

import sys
import io
import argparse
import datetime
from pathlib import Path
from typing import Optional

import pandas as pd
import numpy as np

# Windows terminal encoding fix
if sys.stdout.encoding and sys.stdout.encoding.lower() in ("cp1254", "cp1252", "ascii"):
    sys.stdout = io.TextIOWrapper(sys.stdout.buffer, encoding="utf-8", errors="replace")
    sys.stderr = io.TextIOWrapper(sys.stderr.buffer, encoding="utf-8", errors="replace")

_SCANNER_DIR = Path(__file__).parent
_BASE_DIR    = _SCANNER_DIR.parent
for p in [str(_SCANNER_DIR), str(_BASE_DIR)]:
    if p not in sys.path:
        sys.path.insert(0, p)

from config import BAR_DIR, SEMBOLLER_70
from loader import load

# ─── EMA (scanner ile aynı) ─────────────────────────────────────
def ema(series: pd.Series, period: int) -> pd.Series:
    return series.ewm(span=period, adjust=False).mean()

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

def get_symbol_list(name: str) -> list[str]:
    name_l = name.lower()
    if name_l == "bist30":
        return BIST30
    elif name_l == "bist50":
        return BIST50
    elif name_l in ("70", "scanner70"):
        return SEMBOLLER_70
    else:
        files = sorted(BAR_DIR.glob("*_Gunluk*"))
        syms  = [f.stem.split("_")[0] for f in files if f.stem.split("_")[0]]
        return list(dict.fromkeys(syms))


# ─── Tek Sembol Backtest ─────────────────────────────────────────
def _trailing_stop_exit(
    df: pd.DataFrame,
    entry_bar: int,
    entry_px: float,
    trail_pct: float,
    max_bars: int = 20,
) -> tuple[float, str, str, int]:
    """
    Giriş barından itibaren çok-günlü izleyen stop simülasyonu.
    Her gün: trail_stop = max_high_seen * (1 - trail_pct/100)
    Gün içi: low <= trail_stop → o günün trail_stop fiyatından çık
             open <= trail_stop → gap-down, opendan çık

    Returns: (exit_px, sonuc, exit_date_str, baris_tutuldu)
    """
    trail_stop  = entry_px * (1 - trail_pct / 100)
    max_high    = entry_px  # başlangıçta giriş fiyatı tavan

    for k in range(1, max_bars + 1):
        j = entry_bar + k
        if j >= len(df):
            # Veri bitti, son kapanıştan çık
            exit_px = df["close"].iloc[entry_bar + k - 1]
            return exit_px, "VERI_BITTI", df["dt"].iloc[entry_bar + k - 1].strftime("%Y-%m-%d"), k - 1

        o = df["open"].iloc[j]
        h = df["high"].iloc[j]
        l = df["low"].iloc[j]
        c = df["close"].iloc[j]
        dt_str = df["dt"].iloc[j].strftime("%Y-%m-%d")

        # Gap-down açılış: direkt stop
        if o <= trail_stop:
            return o, "TRAIL_STOP", dt_str, k

        # Gün içi high önce mi, low önce mi? → muhafazakar: low kontrol et
        # Eğer low trail_stop altına indiyse, trail_stop fiyatından çık
        if l <= trail_stop:
            return trail_stop, "TRAIL_STOP", dt_str, k

        # Gün içi yeni yüksek → trail_stop güncelle
        if h > max_high:
            max_high   = h
            trail_stop = max_high * (1 - trail_pct / 100)

        # Max bar limitine ulaşıldı → kapanışta çık
        if k == max_bars:
            return c, "MAX_BAR", dt_str, k

    return df["close"].iloc[entry_bar], "HATA", "", 0


def backtest_symbol(
    df: pd.DataFrame,
    symbol: str,
    min_below: int,
    hedef_pct: float,
    stop_pct: float,
    start_date: Optional[pd.Timestamp],
    end_date: Optional[pd.Timestamp],
    mod: str = "hedef_stop",   # "hedef_stop" | "trailing"
    trail_pct: float = 1.0,
    max_bars: int = 20,
) -> list[dict]:
    """
    Bir sembol için tüm bar'ları tarar, her sinyalde işleme girer.

    mod='hedef_stop' : Ertesi gün +hedef_pct veya -stop_pct vurduğunda çık
    mod='trailing'   : Çok-günlü izleyen stop (%trail_pct), max_bars'a kadar tut
    """
    MIN_BARS_REQ = 40

    close = df["close"]
    open_ = df["open"]

    e5  = ema(close, 5)
    e8  = ema(close, 8)
    e13 = ema(close, 13)

    trades = []

    # Sinyal barı için aralık: MIN_BARS_REQ .. len-2 (ertesi bar gerekli)
    for i in range(MIN_BARS_REQ, len(df) - 1):
        dt_i = df["dt"].iloc[i]

        # Tarih filtresi
        if start_date and dt_i < start_date:
            continue
        if end_date and dt_i > end_date:
            continue

        c_now  = close.iloc[i]
        e5_now = e5.iloc[i]
        e8_now = e8.iloc[i]
        e13_now= e13.iloc[i]

        # KOŞUL 1: Bugün üçünün de üstünde
        if not (c_now > e5_now and c_now > e8_now and c_now > e13_now):
            continue

        # KOŞUL 2: Dün en az birinin altında (gerçek kesim)
        c_prev  = close.iloc[i - 1]
        e5_prev = e5.iloc[i - 1]
        e8_prev = e8.iloc[i - 1]
        e13_prev= e13.iloc[i - 1]
        if c_prev > e5_prev and c_prev > e8_prev and c_prev > e13_prev:
            continue

        # KOŞUL 3: Geriye ardışık üç-altı sayısı
        consecutive_below = 0
        j = i - 1
        while j >= 0:
            cj = close.iloc[j]
            if cj < e5.iloc[j] and cj < e8.iloc[j] and cj < e13.iloc[j]:
                consecutive_below += 1
                j -= 1
            else:
                break
        if consecutive_below < min_below:
            continue

        # --- Sinyal Bulundu --- Çıkış ---
        entry_px  = c_now   # Kapanışta giriş (18:00)
        bars_held = 1

        if mod == "trailing":
            exit_px, sonuc, exit_date_str, bars_held = _trailing_stop_exit(
                df, i, entry_px, trail_pct, max_bars
            )
            if sonuc == "HATA":
                continue
            dt_exit = pd.Timestamp(exit_date_str)

        else:  # mod == "hedef_stop"
            next_open  = df["open"].iloc[i + 1]
            next_high  = df["high"].iloc[i + 1]
            next_low   = df["low"].iloc[i + 1]
            next_close = df["close"].iloc[i + 1]
            dt_exit    = df["dt"].iloc[i + 1]

            if pd.isna(next_open) or next_open <= 0:
                continue

            target_px = entry_px * (1 + hedef_pct / 100)
            stop_px   = entry_px * (1 - stop_pct / 100)

            if next_open >= target_px:
                exit_px, sonuc = next_open, "HEDEF"
            elif next_open <= stop_px:
                exit_px, sonuc = next_open, "STOP"
            elif next_high >= target_px and next_low > stop_px:
                exit_px, sonuc = target_px, "HEDEF"
            elif next_low <= stop_px and next_high < target_px:
                exit_px, sonuc = stop_px, "STOP"
            elif next_high >= target_px and next_low <= stop_px:
                exit_px, sonuc = stop_px, "STOP"   # muhafazakâr
            else:
                exit_px, sonuc = next_close, "DIGER"
            exit_date_str = dt_exit.strftime("%Y-%m-%d")

        pnl_pct = (exit_px - entry_px) / entry_px * 100

        # EMA13 eğimi (son 3 bar)
        ema13_slope = e13.iloc[i] - e13.iloc[max(0, i - 3)]

        # Hacim oranı
        vol_now  = df["vol"].iloc[i]
        vol_avg5 = df["vol"].iloc[max(0, i - 5):i].mean()
        vol_ratio = vol_now / vol_avg5 if vol_avg5 > 0 else 1.0

        trades.append({
            "sembol":          symbol,
            "giris_tarihi":    dt_i.strftime("%Y-%m-%d"),
            "cikis_tarihi":    exit_date_str,
            "giris_fiyat":     round(entry_px, 4),
            "cikis_fiyat":     round(exit_px, 4),
            "pnl_pct":         round(pnl_pct, 4),
            "sonuc":           sonuc,
            "ardisik_alti":    consecutive_below,
            "ema13_egim":      round(ema13_slope, 4),
            "hacim_oran":      round(vol_ratio, 2),
            "bars_held":       bars_held,
            "yil":             dt_i.year,
        })

    return trades


# ─── İstatistik ─────────────────────────────────────────────────
def istatistik(trades: list[dict]) -> dict:
    if not trades:
        return {}

    df = pd.DataFrame(trades)
    total     = len(df)
    wins      = (df["pnl_pct"] > 0).sum()
    losses    = (df["pnl_pct"] < 0).sum()
    win_rate  = wins / total * 100

    avg_pnl   = df["pnl_pct"].mean()
    avg_win   = df.loc[df["pnl_pct"] > 0, "pnl_pct"].mean() if wins > 0 else 0
    avg_loss  = df.loc[df["pnl_pct"] < 0, "pnl_pct"].mean() if losses > 0 else 0
    median_pnl= df["pnl_pct"].median()

    hedef_n   = (df["sonuc"] == "HEDEF").sum()
    stop_n    = (df["sonuc"] == "STOP").sum()
    diger_n   = (df["sonuc"] == "DIGER").sum()

    # Kümülatif PnL (sıralı işlemler — tek seferde 1 pozisyon varsayımı)
    cumulative = df["pnl_pct"].cumsum()
    max_dd_val = 0.0
    peak       = cumulative.iloc[0]
    for v in cumulative:
        if v > peak:
            peak = v
        dd = peak - v
        if dd > max_dd_val:
            max_dd_val = dd

    expectancy = (win_rate / 100 * avg_win) + ((1 - win_rate / 100) * avg_loss)

    return {
        "toplam_islem":   total,
        "kazanc_n":       int(wins),
        "kayip_n":        int(losses),
        "win_rate_pct":   round(win_rate, 2),
        "ort_pnl":        round(avg_pnl, 4),
        "ort_kazanc":     round(avg_win, 4),
        "ort_kayip":      round(avg_loss, 4),
        "medyan_pnl":     round(median_pnl, 4),
        "max_drawdown":   round(max_dd_val, 2),
        "expectancy":     round(expectancy, 4),
        "hedef_n":        int(hedef_n),
        "stop_n":         int(stop_n),
        "diger_n":        int(diger_n),
        "toplam_pnl":     round(df["pnl_pct"].sum(), 2),
    }


def yillik_tablo(trades: list[dict]) -> pd.DataFrame:
    df = pd.DataFrame(trades)
    grp = df.groupby("yil").agg(
        islem=("pnl_pct", "count"),
        win_rate=("pnl_pct", lambda x: (x > 0).mean() * 100),
        ort_pnl=("pnl_pct", "mean"),
        toplam_pnl=("pnl_pct", "sum"),
        hedef=("sonuc", lambda x: (x == "HEDEF").sum()),
        stop=("sonuc", lambda x: (x == "STOP").sum()),
    ).round(2)
    return grp


def sembol_tablo(trades: list[dict], top_n: int = 15) -> pd.DataFrame:
    df = pd.DataFrame(trades)
    grp = df.groupby("sembol").agg(
        islem=("pnl_pct", "count"),
        win_rate=("pnl_pct", lambda x: (x > 0).mean() * 100),
        ort_pnl=("pnl_pct", "mean"),
        toplam_pnl=("pnl_pct", "sum"),
    ).round(2)
    return grp.sort_values("toplam_pnl", ascending=False).head(top_n)


# ─── Rapor ──────────────────────────────────────────────────────
def rapor_yazdir(stats: dict, yil_df: pd.DataFrame, sym_df: pd.DataFrame,
                 min_below: int, hedef_pct: float, stop_pct: float,
                 start_str: str, end_str: str, liste: str, mod_label: str = ""):
    sep = "─" * 52

    print(f"\n{'═'*52}")
    print(f"  5-8-13 EMA VUR KAÇ — BACKTEST RAPORU")
    print(f"{'═'*52}")
    print(f"  Sembol listesi : {liste}")
    print(f"  Tarih araligi  : {start_str} → {end_str}")
    print(f"  Min. EMA-alti  : {min_below} bar")
    print(f"  Cikis modu     : {mod_label if mod_label else f'+%{hedef_pct:.2f} hedef / -%{stop_pct:.2f} stop'}")
    print(sep)

    if not stats:
        print("  SONUC: Hic islem bulunamadi.")
        return

    print(f"  Toplam islem   : {stats['toplam_islem']}")
    print(f"  Kazanan        : {stats['kazanc_n']}  ({stats['win_rate_pct']:.1f}%)")
    print(f"  Kaybeden       : {stats['kayip_n']}")
    print(f"  Hedef vuran    : {stats['hedef_n']}  |  Stop yiyen: {stats['stop_n']}  |  Diger: {stats['diger_n']}")
    print(sep)
    print(f"  Ort. PnL/islem : %{stats['ort_pnl']:.4f}")
    print(f"  Ort. kazanc    : %{stats['ort_kazanc']:.4f}")
    print(f"  Ort. kayip     : %{stats['ort_kayip']:.4f}")
    print(f"  Medyan PnL     : %{stats['medyan_pnl']:.4f}")
    print(f"  Expectancy     : %{stats['expectancy']:.4f}")
    print(f"  Kümülatif PnL  : %{stats['toplam_pnl']:.2f}  (tek pozisyon, ardisik)")
    print(f"  Max Drawdown   : %{stats['max_drawdown']:.2f}  (kümülatif PnL üzerinden)")
    print(sep)

    # Yıllık tablo
    print("\n  [ YILLIK DAGILIM ]")
    print(f"  {'Yil':>6}  {'Islem':>6}  {'WinRate':>8}  {'OrtPnL':>8}  {'ToplamPnL':>10}  {'Hedef':>6}  {'Stop':>6}")
    print(f"  {'-'*6}  {'-'*6}  {'-'*8}  {'-'*8}  {'-'*10}  {'-'*6}  {'-'*6}")
    for yil, row in yil_df.iterrows():
        print(f"  {yil:>6}  {int(row['islem']):>6}  "
              f"{row['win_rate']:>7.1f}%  "
              f"{row['ort_pnl']:>+8.3f}%  "
              f"{row['toplam_pnl']:>+9.2f}%  "
              f"{int(row['hedef']):>6}  "
              f"{int(row['stop']):>6}")
    print(sep)

    # En iyi semboller
    print("\n  [ EN İYİ 15 SEMBOL (toplam PnL) ]")
    print(f"  {'Sembol':<10}  {'Islem':>6}  {'WinRate':>8}  {'OrtPnL':>8}  {'ToplamPnL':>10}")
    print(f"  {'-'*10}  {'-'*6}  {'-'*8}  {'-'*8}  {'-'*10}")
    for sym, row in sym_df.iterrows():
        print(f"  {sym:<10}  {int(row['islem']):>6}  "
              f"{row['win_rate']:>7.1f}%  "
              f"{row['ort_pnl']:>+8.3f}%  "
              f"{row['toplam_pnl']:>+9.2f}%")
    print(sep)


# ─── Ana Fonksiyon ───────────────────────────────────────────────
def main():
    parser = argparse.ArgumentParser(description="EMA Vur Kaç Backtest")
    parser.add_argument("--liste",      default="tumu",         help="bist30/bist50/70/tumu")
    parser.add_argument("--baslangic",  default="2015-01-01",   help="YYYY-MM-DD")
    parser.add_argument("--bitis",      default=None,           help="YYYY-MM-DD (bos=bugun)")
    parser.add_argument("--min-alti",   type=int, default=3,    help="Min ardisik EMA-alti bar")
    parser.add_argument("--hedef",      type=float, default=0.45, help="Hedef yuzde (varsayilan: 0.45)")
    parser.add_argument("--stop",       type=float, default=1.0,  help="Stop yuzde (varsayilan: 1.0)")
    parser.add_argument("--mod",        default="hedef_stop",   help="hedef_stop | trailing")
    parser.add_argument("--max-bar",    type=int, default=20,   help="Trailing modda max tutma suresi (gun)")
    parser.add_argument("--csv",        default=None,           help="Tum islemleri bu CSV'ye yaz")
    parser.add_argument("--verbose",    action="store_true")
    args = parser.parse_args()

    start_date = pd.Timestamp(args.baslangic)
    end_date   = pd.Timestamp(args.bitis) if args.bitis else pd.Timestamp.today()
    start_str  = start_date.strftime("%d.%m.%Y")
    end_str    = end_date.strftime("%d.%m.%Y")

    symbols = get_symbol_list(args.liste)
    print(f"\nBacktest basliyor — {len(symbols)} sembol, {start_str} → {end_str}")

    all_trades: list[dict] = []
    errors   = []
    skipped  = 0

    for idx, sym in enumerate(symbols, 1):
        if args.verbose:
            print(f"  [{idx:3}/{len(symbols)}] {sym:<10}", end=" ", flush=True)

        df = load(sym, "Gunluk")
        if df is None or len(df) < 40:
            skipped += 1
            if args.verbose:
                print("SKIP")
            continue

        try:
            trades = backtest_symbol(
                df, sym,
                min_below=args.min_alti,
                hedef_pct=args.hedef,
                stop_pct=args.stop,
                start_date=start_date,
                end_date=end_date,
                mod=args.mod,
                trail_pct=args.stop,
                max_bars=args.max_bar,
            )
        except Exception as e:
            errors.append(f"{sym}: {e}")
            if args.verbose:
                print(f"HATA: {e}")
            continue

        all_trades.extend(trades)
        if args.verbose:
            print(f"{len(trades)} islem")

    print(f"\nTamamlandi: {len(all_trades)} islem, {skipped} sembol atlandı, {len(errors)} hata")

    if errors:
        print(f"  Ilk 5 hata: {errors[:5]}")

    # İstatistikler
    stats   = istatistik(all_trades)
    yil_df  = yillik_tablo(all_trades) if all_trades else pd.DataFrame()
    sym_df  = sembol_tablo(all_trades) if all_trades else pd.DataFrame()

    mod_label = f"trailing stop -%{args.stop} / max {args.max_bar} gun" if args.mod == "trailing" else f"hedef +%{args.hedef} / stop -%{args.stop}"
    rapor_yazdir(
        stats, yil_df, sym_df,
        min_below=args.min_alti,
        hedef_pct=args.hedef,
        stop_pct=args.stop,
        start_str=start_str,
        end_str=end_str,
        liste=args.liste,
        mod_label=mod_label,
    )

    # CSV çıktısı
    if args.csv and all_trades:
        out_path = Path(args.csv)
        pd.DataFrame(all_trades).to_csv(out_path, index=False, encoding="utf-8-sig")
        print(f"\n  Tum islemler yazildi: {out_path}")


if __name__ == "__main__":
    main()
