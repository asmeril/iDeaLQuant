"""
scanner_ema_vur_kac.py — 5-8-13 EMA Üçlü Kesim Tarayıcısı
═══════════════════════════════════════════════════════════════
STRATEJİ: "GÜNLÜK VUR KAÇ"
  - 5, 8, 13 günlük üstel hareketli ortalama (EMA) kullan
  - Fiyat en az 3 ardışık günlük bar boyunca 3 EMA'nın da altında olacak
  - Sinyal günü: TEK BARDA fiyat 3 EMA'yı yukarı keser ve üstünde kapanır
  - Giriş: Günlük kapanışta (18:00 civarı)
  - Hedef: Ertesi gün minimum +%0.45-0.50 kâr al
  - Stop:  -%1.0

KULLANIM:
  python scanner_ema_vur_kac.py                    # Bugünkü kapanış barı
  python scanner_ema_vur_kac.py --tarih 2026-05-09 # Belirli gün (geçmiş test)
  python scanner_ema_vur_kac.py --min-alti 3       # Min. EMA altı bar sayısı
  python scanner_ema_vur_kac.py --liste bist30      # bist30 / bist50 / bist100 / tumü
  python scanner_ema_vur_kac.py --telegram          # Sinyal bulduktan sonra Telegram gönder
"""
from __future__ import annotations

import sys
import io
# Windows terminal encoding fix
if sys.stdout.encoding and sys.stdout.encoding.lower() in ("cp1254", "cp1252", "ascii"):
    sys.stdout = io.TextIOWrapper(sys.stdout.buffer, encoding="utf-8", errors="replace")
    sys.stderr = io.TextIOWrapper(sys.stderr.buffer, encoding="utf-8", errors="replace")

import argparse
import datetime
from pathlib import Path
from typing import Optional

import numpy as np
import pandas as pd

# ─── Proje yolunu ekle ──────────────────────────────────────────
_SCANNER_DIR = Path(__file__).parent
_BASE_DIR    = _SCANNER_DIR.parent
if str(_SCANNER_DIR) not in sys.path:
    sys.path.insert(0, str(_SCANNER_DIR))
if str(_BASE_DIR) not in sys.path:
    sys.path.insert(0, str(_BASE_DIR))

from config import BAR_DIR, SEMBOLLER_70
from loader import load

# ─── Telegram ───────────────────────────────────────────────────
API_TOKEN   = "8581068218:AAEcQ7_-Bl38JeIs1ifpvZusm4QXBz_uFBY"
CHAT_ID     = "-1003421331174"

def _telegram(msg: str) -> None:
    try:
        import urllib.request, urllib.parse
        url = (f"https://api.telegram.org/bot{API_TOKEN}/sendMessage"
               f"?chat_id={CHAT_ID}&text={urllib.parse.quote(msg)}&parse_mode=HTML")
        urllib.request.urlopen(url, timeout=10)
    except Exception as e:
        print(f"  [Telegram HATA] {e}")

# ─── Sabitler ───────────────────────────────────────────────────
EMA_PERIODS  = (5, 8, 13)  # Üçlü EMA (kısa, orta, uzun)
MIN_BARS_REQ = 40          # EMA 13 için en az 40 bar gerekli (warm-up dahil)

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
BIST100 = BIST50 + [
    "ADEL","ADNAC","AGHOL","AKFGY","AKGRT","AKSA","ALGYO","ALVES",
    "ARSAN","ASUZU","AYCES","AYEN","AYGAZ","BERA","BIOEN","BINHO",
    "BJKAS","BMEKS","BRMEN","BRSAN","BRYAT","BTCIM","BUCIM","BURCE",
    "BURVA","BIZIM","CANTE","CARFA","CELHA","CEMAS","CEMTS","CIMSA",
    "CWENE","DAGI","DEVA","DGKLB","DNISI","DOAS","DOBUR","DOGUB",
    "DOHOL","DURDO","DYOBY","EBEBK","ECILC","EGEEN","EGGUB",
]


def get_symbol_list(name: str) -> list[str]:
    """İsme göre sembol listesi döner. 'tumu' → tüm BarData_Export dosyaları."""
    name_l = name.lower()
    if name_l == "bist30":
        return BIST30
    elif name_l == "bist50":
        return BIST50
    elif name_l == "bist100":
        return BIST100
    elif name_l in ("70", "scanner70"):
        return SEMBOLLER_70
    else:  # "tumu" veya bilinmeyen
        files = sorted(BAR_DIR.glob("*_Gunluk*"))
        syms  = []
        for f in files:
            # Format: SEMBOL_Gunluk.csv veya SEMBOL_G_...
            parts = f.stem.split("_")
            if parts:
                syms.append(parts[0])
        return list(dict.fromkeys(syms))  # tekrar yok, sıra korunur


# ─── EMA Hesaplama ───────────────────────────────────────────────
def ema(series: pd.Series, period: int) -> pd.Series:
    """Standart EMA (Wilder değil, pandas ewm alpha=2/(n+1))."""
    return series.ewm(span=period, adjust=False).mean()


# ─── Ana Sinyal Kontrolü ─────────────────────────────────────────
def check_signal(df: pd.DataFrame, target_idx: int, min_below: int = 3) -> Optional[dict]:
    """
    target_idx'teki bar için sinyal var mı kontrol eder.

    Koşullar:
    1. target_idx barında close > EMA5, EMA8, EMA13 (üçünün de üstünde kapanış)
    2. target_idx - 1 barında close < EMA5 VEYA EMA8 VEYA EMA13'ten en az biri altında
       (yani önceki bar henüz tam üstte değildi — gerçek kesim)
    3. target_idx'den geriye doğru min_below bar ardışık olarak close < EMA5 & EMA8 & EMA13
    
    Returns:
        dict: Sinyal bilgileri (sembol, tarih, EMA değerleri, ardışık altı sayısı)
        None: Sinyal yok
    """
    if target_idx < MIN_BARS_REQ:
        return None
    if target_idx >= len(df):
        return None

    close = df["close"]
    e5  = ema(close, 5)
    e8  = ema(close, 8)
    e13 = ema(close, 13)

    c_now  = close.iloc[target_idx]
    e5_now = e5.iloc[target_idx]
    e8_now = e8.iloc[target_idx]
    e13_now= e13.iloc[target_idx]

    # KOŞUL 1: Bugün üç EMA'nın da üstünde kapanış
    if not (c_now > e5_now and c_now > e8_now and c_now > e13_now):
        return None

    # KOŞUL 2: Önceki barda en az biri altında (gerçek tek-bar kesim)
    c_prev  = close.iloc[target_idx - 1]
    e5_prev = e5.iloc[target_idx - 1]
    e8_prev = e8.iloc[target_idx - 1]
    e13_prev= e13.iloc[target_idx - 1]
    prev_above_all = (c_prev > e5_prev and c_prev > e8_prev and c_prev > e13_prev)
    if prev_above_all:
        return None  # Dün de üstteydi, kesim değil devam

    # KOŞUL 3: Geriye doğru ardışık "üç EMA'nın da altında" sayısını bul
    consecutive_below = 0
    i = target_idx - 1
    while i >= 0:
        ci  = close.iloc[i]
        e5i = e5.iloc[i]
        e8i = e8.iloc[i]
        e13i= e13.iloc[i]
        if ci < e5i and ci < e8i and ci < e13i:
            consecutive_below += 1
            i -= 1
        else:
            break

    if consecutive_below < min_below:
        return None

    # EMA eğimi: son 3 bardaki trend yönü (ek filtre)
    e13_slope = e13.iloc[target_idx] - e13.iloc[max(0, target_idx - 3)]

    # Hacim kıyaslaması: sinyal günü hacim son 5 gün ortalamasına göre
    vol_now  = df["vol"].iloc[target_idx]
    vol_avg5 = df["vol"].iloc[max(0, target_idx - 5):target_idx].mean()
    vol_ratio = vol_now / vol_avg5 if vol_avg5 > 0 else 1.0

    # Kapanışın EMA13'e olan mesafesi (%)
    dist_pct = (c_now - e13_now) / e13_now * 100

    return {
        "tarih":          df["dt"].iloc[target_idx].strftime("%d.%m.%Y"),
        "kapanis":        round(c_now, 4),
        "ema5":           round(e5_now, 4),
        "ema8":           round(e8_now, 4),
        "ema13":          round(e13_now, 4),
        "ardisik_alti":   consecutive_below,
        "ema13_egim":     round(e13_slope, 4),
        "hacim_oran":     round(vol_ratio, 2),
        "kapanis_dist_pct": round(dist_pct, 2),
    }


# ─── Tarama ─────────────────────────────────────────────────────
def tarama(
    tarih: Optional[datetime.date] = None,
    min_below: int = 3,
    sembol_listesi: str = "tumu",
    verbose: bool = False,
) -> list[dict]:
    """
    Tüm sembolleri tarar, sinyal listesi döner.

    Args:
        tarih:          Taranacak gün (None = en son bar)
        min_below:      Min. ardışık EMA-altı bar sayısı
        sembol_listesi: 'bist30', 'bist50', 'bist100', '70', 'tumu'
        verbose:        Her sembol için ayrıntılı log

    Returns:
        Sinyaller listesi [{"sembol": ..., "tarih": ..., ...}]
    """
    target_ts = pd.Timestamp(tarih) if tarih else None
    symbols   = get_symbol_list(sembol_listesi)

    results  = []
    errors   = []
    skipped  = 0

    total = len(symbols)
    for idx, sym in enumerate(symbols, 1):
        if verbose:
            print(f"  [{idx:3}/{total}] {sym:<10}", end=" ")

        df = load(sym, "Gunluk")
        if df is None or len(df) < MIN_BARS_REQ:
            skipped += 1
            if verbose:
                print("SKIP (yetersiz veri)")
            continue

        # Hedef bar indeksini bul
        if target_ts is None:
            bar_idx = len(df) - 1
        else:
            mask = df["dt"].dt.normalize() <= target_ts
            if not mask.any():
                skipped += 1
                if verbose:
                    print("SKIP (tarih aralığı dışı)")
                continue
            bar_idx = int(df.index[mask][-1])

        try:
            sig = check_signal(df, bar_idx, min_below)
        except Exception as e:
            errors.append(f"{sym}: {e}")
            if verbose:
                print(f"HATA: {e}")
            continue

        if sig:
            sig["sembol"] = sym
            results.append(sig)
            if verbose:
                print(f"SİNYAL ✓  kapanis={sig['kapanis']}  "
                      f"EMA13={sig['ema13']}  "
                      f"ardisik_alti={sig['ardisik_alti']}  "
                      f"hacim_oran={sig['hacim_oran']}")
        else:
            if verbose:
                print("—")

    if errors:
        print(f"\n  [UYARI] {len(errors)} sembolde hata:")
        for e in errors[:5]:
            print(f"    {e}")

    return results


# ─── Sıralama & Raporlama ────────────────────────────────────────
def sirala(results: list[dict]) -> list[dict]:
    """
    Sinyalleri öncelik sırasına dizer:
      1. EMA13 eğimi > 0 (yükselen EMA — daha güçlü sinyal)
      2. Ardışık altı sayısı azdan çoğa (3 ideal; çok fazla zayıf hisse işareti)
      3. Hacim oranı büyükten küçüğe (hacimli kesimler daha güvenilir)
    """
    return sorted(
        results,
        key=lambda r: (
            -(1 if r["ema13_egim"] > 0 else 0),  # EMA13 yükselen önce
            r["ardisik_alti"],                    # Az altı gün önce (3-5 ideal)
            -r["hacim_oran"],                     # Yüksek hacim önce
        )
    )


def rapor(results: list[dict], tarih_str: str) -> str:
    """İnsan okunabilir rapor metni üretir."""
    lines = [
        f"📊 5-8-13 EMA VUR KAÇ TARAMASI",
        f"Tarih: {tarih_str}",
        f"Sinyal sayısı: {len(results)}",
        "─" * 42,
    ]

    for r in results:
        yon_ema13 = "↑" if r["ema13_egim"] > 0 else "↓" if r["ema13_egim"] < 0 else "→"
        lines.append(
            f"{r['sembol']:<8}  {r['kapanis']:>8.4f} TL"
            f"  |{r['ardisik_alti']}g altı"
            f"  EMA13{yon_ema13}"
            f"  vol×{r['hacim_oran']:.1f}"
            f"  +{r['kapanis_dist_pct']:.2f}%"
        )

    lines += [
        "─" * 42,
        f"Hedef: +%0.45-0.50 (ertesi gün açılış)",
        f"Stop:  -%1.0",
        f"Giriş: Günlük kapanış (~18:00)",
    ]
    return "\n".join(lines)


# ─── CLI ────────────────────────────────────────────────────────
def main():
    parser = argparse.ArgumentParser(description="5-8-13 EMA Vur Kaç Tarayıcı")
    parser.add_argument("--tarih",    default=None,   help="YYYY-MM-DD (boşsa bugün)")
    parser.add_argument("--min-alti", type=int, default=3, help="Min. ardışık EMA-altı bar (default: 3)")
    parser.add_argument("--liste",    default="tumu", help="bist30 / bist50 / bist100 / 70 / tumu")
    parser.add_argument("--telegram", action="store_true", help="Sonuçları Telegram'a gönder")
    parser.add_argument("--verbose",  action="store_true", help="Her sembol için ayrıntılı çıktı")
    args = parser.parse_args()

    tarih = None
    if args.tarih:
        tarih = datetime.date.fromisoformat(args.tarih)
        tarih_str = args.tarih
    else:
        tarih_str = datetime.date.today().strftime("%Y-%m-%d")

    print(f"\n{'═'*50}")
    print(f"  5-8-13 EMA VUR KAÇ TARAMASI")
    print(f"  Tarih   : {tarih_str}")
    print(f"  Liste   : {args.liste}")
    print(f"  Min. altı: {args.min_alti} bar")
    print(f"{'═'*50}\n")

    symbols = get_symbol_list(args.liste)
    print(f"  Taranacak sembol sayısı: {len(symbols)}\n")

    results = tarama(
        tarih=tarih,
        min_below=args.min_alti,
        sembol_listesi=args.liste,
        verbose=args.verbose,
    )
    sorted_results = sirala(results)

    tarih_display = tarih.strftime("%d.%m.%Y") if tarih else datetime.date.today().strftime("%d.%m.%Y")
    rapor_txt = rapor(sorted_results, tarih_display)
    print("\n" + rapor_txt)

    if args.telegram:
        if sorted_results:
            _telegram(rapor_txt)
            print("\n  [Telegram] Gönderildi.")
        else:
            _telegram(f"📊 EMA Vur Kaç ({tarih_display}): Sinyal bulunamadı.")
            print("\n  [Telegram] 'Sinyal yok' mesajı gönderildi.")


if __name__ == "__main__":
    main()
