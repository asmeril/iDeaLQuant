"""
loader.py — OHLCV Yükleme & Önbellekleme Motoru
Önce iDeal native binary cache'inden (D:/iDeal/ChartData/) okur.
Bulunamazsa BarData_Export CSV'lerine fallback yapar.
"""
from __future__ import annotations
import sys
import pandas as pd
import numpy as np
from pathlib import Path
from functools import lru_cache
from typing import Optional, Dict

from config import BASE_DIR, BAR_DIR, ENCODING, CSV_SEP, DATE_FMT, MIN_BARS, SEMBOLLER_70

# ─────────────────── iDeal Native Parser Import ──────────────────
# ideal_disk_cache_export.py proje kök dizininde (BASE_DIR).
# Sadece parse fonksiyonları kullanılır; main()/CSV-yazma çağrılmaz.
_ideal_export_path = str(BASE_DIR)
if _ideal_export_path not in sys.path:
    sys.path.insert(0, _ideal_export_path)

try:
    from ideal_disk_cache_export import (
        read_binary_bars,
        get_filepath,
        daily_ts_to_date,
        ts_to_datetime_trt,
        aggregate_to_15min,
    )
    _IDE_AVAILABLE = True
except ImportError:
    _IDE_AVAILABLE = False

# ─────────────────────────── ÖNBELLEK ────────────────────────────
_cache: Dict[str, pd.DataFrame] = {}


def _cache_key(symbol: str, period: str) -> str:
    return f"{symbol}_{period}"


def _num(x) -> float:
    """Türkçe formatlı sayı veya standart float'ı parse et."""
    s = str(x)
    if "," in s:
        return float(s.replace(".", "").replace(",", "."))
    try:
        return float(s)
    except ValueError:
        return float("nan")


# Periyot → (binary_dir, tip) eşlemesi
# 15dk: 5dk barlardan aggregate (1dk yerine — daha az gürültü, tam hizalanmış pencereler)
_PERIOD_MAP = {
    "Gunluk": ("G",  "gunluk"),
    "60dk":   ("60", "intraday"),
    "15dk":   ("05", "agregat"),   # 5dk barlardan aggregate
    "5dk":    ("05", "intraday"),  # Native 5dk — scalp analizi için
    "1dk":    ("01", "intraday"),
}


def _binary_to_df(symbol: str, period: str) -> Optional[pd.DataFrame]:
    """
    iDeal native binary cache'inden doğrudan DataFrame üretir.
    Başarısız olursa None döner (CSV fallback için).
    """
    if not _IDE_AVAILABLE:
        return None
    if period not in _PERIOD_MAP:
        return None

    src_dir, tip = _PERIOD_MAP[period]
    filepath = get_filepath(symbol, src_dir)
    if not Path(filepath).exists():
        return None

    try:
        raw_bars = read_binary_bars(filepath)
        if not raw_bars:
            return None

        rows = []
        if tip == "gunluk":
            for (ts, o, h, l, c, lot_f, tl_f) in raw_bars:
                d = daily_ts_to_date(ts)
                rows.append({
                    "dt":    pd.Timestamp(d),
                    "open":  float(o), "high": float(h),
                    "low":   float(l), "close": float(c),
                    "vol":   float(tl_f) if tl_f > 0 else float(lot_f),
                })
        elif tip == "intraday":
            period_min = 60 if period == "60dk" else 1
            for (ts, o, h, l, c, lot_f, tl_f) in raw_bars:
                dt = ts_to_datetime_trt(ts, period_min)
                rows.append({
                    "dt":    pd.Timestamp(dt),
                    "open":  float(o), "high": float(h),
                    "low":   float(l), "close": float(c),
                    "vol":   float(tl_f) if tl_f > 0 else float(lot_f),
                })
        elif tip == "agregat":
            for (dt, o, h, l, c, vol) in aggregate_to_15min(raw_bars):
                rows.append({
                    "dt":    pd.Timestamp(dt),
                    "open":  float(o), "high": float(h),
                    "low":   float(l), "close": float(c),
                    "vol":   float(vol),
                })

        if not rows:
            return None

        df = pd.DataFrame(rows)
        df = df[df["close"] > 0].reset_index(drop=True)
        min_bars = MIN_BARS.get(period, 50)
        return df if len(df) >= min_bars else None

    except Exception:
        return None


def _csv_to_df(symbol: str, period: str) -> Optional[pd.DataFrame]:
    """BarData_Export CSV dosyasından DataFrame üretir (fallback)."""
    path = BAR_DIR / f"{symbol}_{period}_5000bar.csv"
    if not path.exists():
        return None

    raw = None
    for enc in [ENCODING, "utf-8-sig", "latin-1"]:
        try:
            raw = pd.read_csv(path, sep=CSV_SEP, encoding=enc)
            break
        except Exception:
            raw = None

    if raw is None or len(raw) < 2:
        return None

    out = pd.DataFrame({
        "date":  raw.iloc[:, 0].astype(str),
        "time":  raw.iloc[:, 1].astype(str),
        "open":  raw.iloc[:, 2].map(_num).astype(float),
        "high":  raw.iloc[:, 3].map(_num).astype(float),
        "low":   raw.iloc[:, 4].map(_num).astype(float),
        "close": raw.iloc[:, 5].map(_num).astype(float),
        "vol":   raw.iloc[:, 7].map(_num).astype(float),
    })
    out["dt"] = pd.to_datetime(out["date"] + " " + out["time"], dayfirst=True, errors="coerce")
    out = out.dropna(subset=["dt"]).reset_index(drop=True)
    out = out[out["close"] > 0].reset_index(drop=True)

    min_bars = MIN_BARS.get(period, 50)
    return out if len(out) >= min_bars else None


def load(symbol: str, period: str, force_reload: bool = False) -> Optional[pd.DataFrame]:
    """
    Bir sembolün belirli periyodunu yükler.
    1. iDeal native binary cache (D:/iDeal/ChartData/) — öncelikli
    2. BarData_Export CSV — fallback
    Önbellek kullanır; force_reload=True ile bayat cache atlanır.

    Returns:
        DataFrame kolonları: dt, open, high, low, close, vol
        None: Veri yoksa veya minimum bar koşulu sağlanmazsa
    """
    key = _cache_key(symbol, period)
    if not force_reload and key in _cache:
        return _cache[key]

    df = _binary_to_df(symbol, period)
    if df is None:
        df = _csv_to_df(symbol, period)

    if df is not None:
        _cache[key] = df
    return df


def load_all(symbol: str) -> Dict[str, Optional[pd.DataFrame]]:
    """Bir sembolün tüm periyotlarını yükler (5dk dahil)."""
    return {p: load(symbol, p) for p in ["Gunluk", "60dk", "15dk", "5dk", "1dk"]}


def get_daily_returns(df: pd.DataFrame) -> pd.Series:
    """Günlük kapanış getirilerini hesapla."""
    return df["close"].pct_change()


def get_true_range(df: pd.DataFrame) -> pd.Series:
    """True Range hesapla."""
    prev_close = df["close"].shift(1)
    tr = pd.concat([
        df["high"] - df["low"],
        (df["high"] - prev_close).abs(),
        (df["low"]  - prev_close).abs(),
    ], axis=1).max(axis=1)
    return tr


def align_to_date(df: pd.DataFrame, target_date: pd.Timestamp, period: str = "Gunluk") -> Optional[int]:
    """
    Belirli bir tarih için DataFrame'deki bar indeksini döner.
    Günlük için: o gün veya önceki en yakın gün.
    İntraday için: o gün 10:05 barı (açılış barı).
    """
    if df is None or len(df) == 0:
        return None

    if period == "Gunluk":
        mask = df["dt"].dt.normalize() <= target_date
        if not mask.any():
            return None
        return int(df.index[mask][-1])
    else:
        # İntraday: hedef günün >= 10:00 ilk barı
        day_mask = (df["dt"].dt.normalize() == target_date) & (df["dt"].dt.hour >= 10)
        if day_mask.any():
            return int(df.index[day_mask][0])
        # Yoksa önceki güne dön
        prior = df[df["dt"] < target_date]
        return int(prior.index[-1]) if len(prior) > 0 else None


def get_market_df() -> Optional[pd.DataFrame]:
    """
    XU100 günlük verisini döner (referans: BarData_Export'ta yoksa None).
    Relative strength hesabı için kullanılır.
    """
    # XU100 CSV mevcut değilse None döner, RS hesabı atlanır
    xu_path = BAR_DIR / "XU100_Gunluk_5000bar.csv"
    if not xu_path.exists():
        return None
    return load("XU100", "Gunluk")


def clear_cache():
    """Tüm önbelleği temizle (günlük yenileme için)."""
    _cache.clear()


def list_available_symbols(period: str = "Gunluk") -> list:
    """Belirli periyotta mevcut tüm sembolleri listele."""
    return sorted([
        p.name.replace(f"_{period}_5000bar.csv", "")
        for p in BAR_DIR.glob(f"*_{period}_5000bar.csv")
        if not p.name.startswith("_")
    ])
