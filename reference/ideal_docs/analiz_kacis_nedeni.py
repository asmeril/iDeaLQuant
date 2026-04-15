#!/usr/bin/env python3
r"""
Reverse Engineering: En çok yükselen 70 hisse neden taramakodarından kaçtı?

Kaynak veri: D:/Projects/IdealQuant/reference/ideal_docs/BarData_Export/
Referans tarih: 09.04.2026 (veya tablonun günü)

Analiz akışı:
1. Her sembol için giriş barı öncesindeki GLOBAL + King/Bomba/TeFo koşullarını hesaplar
2. Hangi filtrede elendiğini gösterir
3. Genel "kaçış nedeni" tablosu üretir

Kullanım:
    python.exe analiz_kacis_nedeni.py [--tarih 2026-04-09]
"""

import os
import sys
import argparse
import pandas as pd
import numpy as np
from pathlib import Path

# --- BAĞIMLILIKLAR ---
sys.path.insert(0, r"D:\Projects\IdealQuant\src")
try:
    from indicators.core import EMA, SMA, ATR
    INDS_OK = True
except ImportError as e:
    print(f"[WARN] İndikatör kütüphanesi yüklenemedi: {e}")
    INDS_OK = False

# --- YAPILANDIRMA ---
BAR_DIR  = Path(r"D:\Projects\IdealQuant\reference\ideal_docs\BarData_Export")
OUT_DIR  = BAR_DIR  # Sonuç dosyaları aynı klasöre
ENCODING = "cp1254"

SEMBOLLER = [
    "ANELE","BORLS","KONTR","SMRVA","SVGYO","ADEL","AAGYO","TKFEN","CEOEM","DMRGD",
    "GLRMK","DGNMO","VRGYO","ALVES","BRMEN","KLMDE","DOGUB","SANFM","OBASE","BRKO",
    "TRHOL","ULUSE","KTSKR","LIDER","CVKMD","KRDMD","RNPOL","DCTTR","AYCES","BASSO",
    "GATEG","KLMSN","SEKUR","ASUZU","KRDMA","KERVN","ERSU","EMKEL","ALCTL","RYGYO",
    "GZNMI","SMRTG","OZRDN","KRABB","TERA","ARMGD","YGGYO","MOBTL","EDATA","SEGYO",
    "MAGEN","ICUGS","CWENE","ASELS","ARZUM","DEVA","TUNGE","TEKTU","RALYH","DURDO",
    "GOKNR","BIOEN","TEZOL","OYAYO","MOGAN","ODAS","BYDNR","SOKM","YAYLA","ENTRA",
]

# Her sembolün BÜYÜK HAREKET yaptığı tarih/saat (tablodaki gün)
# Script otomatik bulur ama manuel override de eklenebilir
HAREKET_TARIHI = "2026-04-09"   # Analiz günü


# --------------------------------------------------------------------------- #
# YARDIMCI: CSV Okuma
# --------------------------------------------------------------------------- #
def load_csv(symbol: str, period: str) -> pd.DataFrame | None:
    """standard format: Tarih;Saat;Acilis;Yuksek;Dusuk;Kapanis;Ortalama;Hacim;Lot"""
    path = BAR_DIR / f"{symbol}_{period}_5000bar.csv"
    if not path.exists():
        return None
    for enc in [ENCODING, "utf-8-sig", "latin-1"]:
        try:
            df = pd.read_csv(path, sep=";", encoding=enc)
            break
        except Exception:
            df = None
    if df is None:
        return None

    def num(x):
        s = str(x)
        if "," in s:
            # Türkçe format: 1.234,56 -> 1234.56
            return float(s.replace(".", "").replace(",", "."))
        return float(s)

    cols = df.columns.tolist()
    # Pozisyonel okuma (başlık isimlerinden bağımsız)
    out = pd.DataFrame({
        "date":  df.iloc[:, 0].astype(str),
        "time":  df.iloc[:, 1].astype(str),
        "open":  df.iloc[:, 2].map(num),
        "high":  df.iloc[:, 3].map(num),
        "low":   df.iloc[:, 4].map(num),
        "close": df.iloc[:, 5].map(num),
        "vol":   df.iloc[:, 7].map(num),
    })
    out["dt"] = pd.to_datetime(out["date"] + " " + out["time"],
                               dayfirst=True, errors="coerce")
    return out.dropna(subset=["dt"]).reset_index(drop=True)


# --------------------------------------------------------------------------- #
# GLOBAL FİLTRE KONTROLÜ
# --------------------------------------------------------------------------- #
def check_global_filters(df60: pd.DataFrame, dfG: pd.DataFrame, ref_dt: pd.Timestamp) -> dict:
    """
    Analize tarihinde GLOBAL_FILTERS_OK'yi geçip geçmediğini kontrol eder.
    Geçmediğinde nedenini döner.

    Filtreler (Robot_King_Bomba_TeFo_Taramali.txt koduna göre):
      filter_Trend      : C > EMA50  (60dk)
      filter_VolQuality : Vol > VolMA20*1.5  AND  closePos > 60%
      filter_Volatility : ATR/C < 3%
      filter_Overextended: (C - EMA20) / EMA20 < 5%
      filter_GapPrim    : gap < 2.5%  AND  daily_chg < 4%
    """
    result = {
        "filter_Trend":       None,
        "filter_VolQuality":  None,
        "filter_Volatility":  None,
        "filter_Overextended":None,
        "filter_GapPrim":     None,
        "GLOBAL_OK":          False,
        "fail_reason":        [],
    }

    if df60 is None or len(df60) < 60:
        result["fail_reason"].append("VERİ YOK (60dk)")
        return result

    # Referans barı bul
    mask = df60["dt"] <= ref_dt
    if not mask.any():
        result["fail_reason"].append("BAR BULUNAMADI (60dk)")
        return result
    bi = df60.index[mask][-1]
    row = df60.loc[bi]

    C   = df60["close"].values
    H   = df60["high"].values
    L   = df60["low"].values
    Vol = df60["vol"].values

    if not INDS_OK:
        result["fail_reason"].append("İNDİKATÖR KÜTÜPHANESİ EKSİK")
        return result

    C_list   = C.tolist()
    H_list   = H.tolist()
    L_list   = L.tolist()
    Vol_list = Vol.tolist()

    # --- EMA50 ---
    ema50 = np.array(EMA(C_list, 50))
    result["filter_Trend"] = bool(C[bi] > ema50[bi])
    if not result["filter_Trend"]:
        result["fail_reason"].append(
            f"filter_Trend FAIL: C={C[bi]:.2f} EMA50={ema50[bi]:.2f}"
        )

    # --- VolQuality ---
    vol_ma20 = np.array(SMA(Vol_list, 20))
    candle_range = H[bi] - L[bi] + 0.01
    close_pos    = (C[bi] - L[bi]) / candle_range
    vq_vol  = Vol[bi] > vol_ma20[bi] * 1.5
    vq_pos  = close_pos > 0.60
    result["filter_VolQuality"] = bool(vq_vol and vq_pos)
    if not result["filter_VolQuality"]:
        result["fail_reason"].append(
            f"filter_VolQuality FAIL: Vol={Vol[bi]:.0f} vs VolMA20*1.5={vol_ma20[bi]*1.5:.0f}  "
            f"closePos={close_pos:.2f}"
        )

    # --- Volatility ---
    atr = np.array(ATR(H_list, L_list, C_list, 14))
    atr_ratio = atr[bi] / C[bi] if C[bi] > 0 else 0
    result["filter_Volatility"] = bool(atr_ratio < 0.03)
    if not result["filter_Volatility"]:
        result["fail_reason"].append(
            f"filter_Volatility FAIL: ATR/C={atr_ratio*100:.1f}% (>3%)"
        )

    # --- Overextended ---
    ema20 = np.array(EMA(C_list, 20))
    dist = (C[bi] - ema20[bi]) / ema20[bi] if ema20[bi] > 0 else 0
    result["filter_Overextended"] = bool(dist < 0.05)
    if not result["filter_Overextended"]:
        result["fail_reason"].append(
            f"filter_Overextended FAIL: dist_EMA20={dist*100:.1f}% (>5%)"
        )

    # --- GapPrim (Günlük veri gerektirir) ---
    # gap = bugün açılış / dünkü kapanış, dchg = intraday current close / dünkü kapanış
    if dfG is not None and len(dfG) >= 2:
        maskG = dfG["dt"].dt.normalize() <= ref_dt.normalize()
        if maskG.any():
            gi  = dfG.index[maskG][-1]
            gi1 = dfG.index[maskG][-2] if maskG.sum() >= 2 else gi
            prevc = dfG.loc[gi1, "close"]
            # Bugünkü açılışı kullan (gap)
            gap   = (dfG.loc[gi, "open"] / prevc - 1) * 100 if prevc > 0 else 0
            # dchg: taranan bar'daki intraday close (EOD değil, scan anı)
            dchg  = (C[bi] / prevc - 1) * 100 if prevc > 0 else 0
            result["filter_GapPrim"] = bool(gap < 2.5 and dchg < 4.0)
            if not result["filter_GapPrim"]:
                result["fail_reason"].append(
                    f"filter_GapPrim FAIL: gap={gap:+.1f}%  dchg_intraday={dchg:+.1f}%"
                )
        else:
            result["filter_GapPrim"] = True  # Veri yoksa pass
    else:
        result["filter_GapPrim"] = True

    result["GLOBAL_OK"] = all([
        result["filter_Trend"],
        result["filter_VolQuality"],
        result["filter_Volatility"],
        result["filter_Overextended"],
        result["filter_GapPrim"] if result["filter_GapPrim"] is not None else True,
    ])

    return result


# --------------------------------------------------------------------------- #
# HAREKET BÜYÜKLÜĞÜ: Tablodaki günde ne kadar yükseldi?
# --------------------------------------------------------------------------- #
def get_move_stats(dfG: pd.DataFrame, ref_date: str) -> dict:
    """Günlük hareketi hesapla"""
    if dfG is None or len(dfG) < 2:
        return {}
    target = pd.to_datetime(ref_date)
    maskG  = dfG["dt"].dt.normalize() == target
    if not maskG.any():
        # En yakın tarihe bak
        maskG = dfG["dt"].dt.normalize() <= target
        if not maskG.any():
            return {}
    gi  = dfG.index[maskG if maskG.any() else (dfG["dt"].dt.normalize() <= target)][-1]
    if gi == 0:
        return {}
    prevc = dfG.loc[gi - 1, "close"]
    row   = dfG.loc[gi]
    gap   = (row["open"]  / prevc - 1) * 100 if prevc > 0 else 0
    dchg  = (row["close"] / prevc - 1) * 100 if prevc > 0 else 0
    hl_range = (row["high"] / row["low"] - 1) * 100 if row["low"] > 0 else 0
    close_pos = (row["close"] - row["low"]) / (row["high"] - row["low"] + 0.01)
    return {
        "gap_pct":   round(gap, 2),
        "daily_chg": round(dchg, 2),
        "hl_range":  round(hl_range, 2),
        "close_pos": round(close_pos, 2),
        "open":      row["open"],
        "high":      row["high"],
        "low":       row["low"],
        "close":     row["close"],
    }


# --------------------------------------------------------------------------- #
# ANA ANALİZ
# --------------------------------------------------------------------------- #
def main():
    parser = argparse.ArgumentParser()
    parser.add_argument("--tarih", default=HAREKET_TARIHI)
    args = parser.parse_args()

    ref_dt = pd.to_datetime(args.tarih)
    print(f"\n{'='*70}")
    print(f"  TERS MÜHENDİSLİK: NEDEN LISTEDE YOK?  —  {args.tarih}")
    print(f"{'='*70}\n")

    rows = []
    filter_counts = {
        "filter_Trend":       0,
        "filter_VolQuality":  0,
        "filter_Volatility":  0,
        "filter_Overextended":0,
        "filter_GapPrim":     0,
        "GLOBAL_OK":          0,
        "VERİ YOK":           0,
    }

    for sym in SEMBOLLER:
        df60 = load_csv(sym, "60dk")
        dfG  = load_csv(sym, "Gunluk")
        df15 = load_csv(sym, "15dk")

        if df60 is None:
            filter_counts["VERİ YOK"] += 1
            rows.append({
                "sembol": sym,
                "GLOBAL_OK": False,
                "fail_reason": "VERİ YOK",
                "gap_pct": None, "daily_chg": None,
            })
            continue

        # --- Günlük hareket ---
        mv = get_move_stats(dfG, args.tarih)

        # --- Global filtre durumu (hareket öncesi son 60dk bar'ı tespit et) ---
        # Büyük hareket genellikle gün başında — saat 10:xx-11:xx arası ilk bar
        day_start = ref_dt.normalize() + pd.Timedelta(hours=9, minutes=55)
        day_bars  = df60[df60["dt"].dt.normalize() == ref_dt.normalize()]

        if len(day_bars) == 0:
            # Günün önceki kapanış barına bak
            prior = df60[df60["dt"] < ref_dt.normalize()]
            ref_bar_dt = prior["dt"].iloc[-1] if len(prior) > 0 else ref_dt
        else:
            # İlk gerçek işlem barı ~ 10:05 (09:05 pre-market flat barını atla)
            # iDeal 60dk barları saat:05 formatında → 10:05 = gerçek açılış barı
            active_bars = day_bars[day_bars["dt"].dt.hour >= 10]
            if len(active_bars) > 0:
                ref_bar_dt = active_bars.iloc[0]["dt"]   # 10:05 barı
            else:
                ref_bar_dt = day_bars.iloc[0]["dt"]       # Yoksa ilk bar

        gf = check_global_filters(df60, dfG, ref_bar_dt)

        row = {
            "sembol":      sym,
            "GLOBAL_OK":   gf["GLOBAL_OK"],
            "fail_reason": " | ".join(gf["fail_reason"]) if gf["fail_reason"] else "—",
            "gap_pct":     mv.get("gap_pct"),
            "daily_chg":   mv.get("daily_chg"),
            "hl_range":    mv.get("hl_range"),
            "close_pos":   mv.get("close_pos"),
        }
        rows.append(row)

        # Sayaç güncelle
        for fk in ["filter_Trend","filter_VolQuality","filter_Volatility",
                   "filter_Overextended","filter_GapPrim"]:
            if gf.get(fk) is False:
                filter_counts[fk] += 1
        if gf["GLOBAL_OK"]:
            filter_counts["GLOBAL_OK"] += 1

    # --- SONUÇ TABLOSU ---
    df_out = pd.DataFrame(rows)
    n = len(df_out)

    print(f"{'SEMBOL':<10} {'GLOBAL':^8} {'GAP%':>6} {'GÜNLÜK%':>8}  BAŞARISIZ FİLTRELER")
    print("-" * 80)
    for _, r in df_out.iterrows():
        ok_str  = "✓ GEÇTİ" if r["GLOBAL_OK"] else "✗ ELENDİ"
        gap_str = f"{r['gap_pct']:+.1f}%" if r["gap_pct"] is not None else "  —  "
        chg_str = f"{r['daily_chg']:+.1f}%" if r["daily_chg"] is not None else "  —  "
        print(f"{r['sembol']:<10} {ok_str:^8} {gap_str:>6} {chg_str:>8}  {r['fail_reason']}")

    print()
    print("=" * 70)
    print("ÖZET: KAÇ HİSSE HANGİ FİLTREDE ELENDI?")
    print("=" * 70)
    total = len(SEMBOLLER)
    print(f"  Toplam hisse               : {total}")
    print(f"  Veri yok                   : {filter_counts['VERİ YOK']}")
    print(f"  filter_Trend FAIL          : {filter_counts['filter_Trend']}")
    print(f"  filter_VolQuality FAIL     : {filter_counts['filter_VolQuality']}")
    print(f"  filter_Volatility FAIL     : {filter_counts['filter_Volatility']}")
    print(f"  filter_Overextended FAIL   : {filter_counts['filter_Overextended']}")
    print(f"  filter_GapPrim FAIL        : {filter_counts['filter_GapPrim']}")
    print(f"  GLOBAL_OK (geçenler)       : {filter_counts['GLOBAL_OK']}")
    print()

    # --- CSV kaydet ---
    out_csv = OUT_DIR / f"kacis_analizi_{args.tarih.replace('-','')}.csv"
    df_out.to_csv(out_csv, index=False, encoding="utf-8-sig")
    print(f"Sonuç CSV: {out_csv}")


if __name__ == "__main__":
    main()
