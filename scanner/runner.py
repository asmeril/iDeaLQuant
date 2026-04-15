"""
runner.py — Ana Orkestratör

Pre-Move Scanner'ı çalıştırır:
    1. Sembolleri yükler
    2. Her sembol için özellik ve formasyon hesaplar
    3. ScoreEngine ile puanlar ve ranklar
    4. Rapor yazdırır
    5. Günlük log kaydeder ve dünkü tahminleri değerlendirir

Kullanım:
    python runner.py                      → bugünkü tarama
    python runner.py --tarih 2026-04-08   → geçmiş tarama
    python runner.py --topn 30            → 30 aday listele
    python runner.py --no-train           → trainer güncelleme kapalı
    python runner.py --perf-rapor         → performans raporu göster
"""
from __future__ import annotations
import sys
import json
import argparse
import traceback
from datetime import date, datetime
from pathlib import Path
from typing import Dict, List, Optional, Any

sys.path.insert(0, str(Path(__file__).parent.parent / "src"))

from config import (
    BAR_DIR, SCANNER_DIR, SCORE_HIGH, SCORE_WATCH, TOP_N,
    SEMBOLLER_70, BIG_MOVE_THRESHOLD
)
from loader import load, list_available_symbols, clear_cache
from features import compute_all_features
from patterns import detect_all_patterns, get_pattern_summary
from scorer import ScoreEngine, print_report
from trainer import DailyTrainer, prev_business_day


# ═══════════════════════════════════════════════════════════════════
# YARDIMCILAR
# ═══════════════════════════════════════════════════════════════════

def today_str() -> str:
    return date.today().strftime("%Y-%m-%d")


def get_symbol_list() -> List[str]:
    """
    Taranan sembol listesi:
    BAR_DIR'de Gunluk CSV'si olan TÜM sembolleri döner.
    config.py'deki SEMBOLLER_70 artık sadece referans — robot yeni sembol
    eklediğinde otomatik olarak taramaya girer.
    """
    available = list_available_symbols("Gunluk")
    # XU100 benchmark olarak kullanılıyor, tarama listesinden çıkar
    return [s for s in available if s not in ("XU100", "XU030")]


def find_scan_idx(df, scan_date_str: str) -> Optional[int]:
    """
    DataFrame'de tarama tarihine en yakın geçerli indeksi bulur.
    scan_date_str: "2026-04-08"
    """
    import pandas as pd
    target = pd.to_datetime(scan_date_str)
    # İlgili gün veya daha önceki son gün
    mask = df["dt"].dt.normalize() <= target
    if not mask.any():
        return None
    return int(df.index[mask][-1])


# ═══════════════════════════════════════════════════════════════════
# TARAMA
# ═══════════════════════════════════════════════════════════════════

def scan_symbol(
    sym: str,
    scan_date_str: str,
    engine: ScoreEngine,
    df_xu100: Optional[Any],
) -> Optional[Dict]:
    """
    Tek sembol için tarama yapar.
    Returns: dict veya None (veri yetersizse)
    """
    df_G = load(sym, "Gunluk")
    if df_G is None or len(df_G) < 50:
        return None

    bi = find_scan_idx(df_G, scan_date_str)
    if bi is None or bi < 30:
        return None

    try:
        features = compute_all_features(df_G, bi=bi, df_xu100=df_xu100)
        patterns = detect_all_patterns(df_G, bi=bi)
    except Exception as e:
        # Hata detayı debug modunda göster
        return None

    # Askıdaki hisse veya stale veri kontrolü
    if features.get("_vol", 1) == 0:
        return None  # İşlem görmüyor (devre dışı/askı)
    data_date = features.get("_date", "")
    if data_date:
        try:
            scan_dt = datetime.strptime(scan_date_str, "%Y-%m-%d")
            data_dt = datetime.strptime(str(data_date)[:10], "%Y-%m-%d")
            if (scan_dt - data_dt).days > 7:
                return None  # 7+ gün eski veri — büyük ihtimalle askıda
        except (ValueError, TypeError):
            pass

    score, breakdown = engine.score(features, patterns)

    return {
        "sembol":   sym,
        "puan":     round(score, 1),
        "durum":    _status_emoji(score),
        "features": features,
        "patterns": patterns,
        "breakdown": breakdown,
        "pat_ozet": get_pattern_summary(patterns),
    }


def _status_emoji(score: float) -> str:
    if score >= SCORE_HIGH:
        return "🟢"
    elif score >= SCORE_WATCH:
        return "🟡"
    else:
        return "🔴"


def run_scan(
    scan_date_str: str,
    symbols: List[str],
    engine: ScoreEngine,
    verbose: bool = True,
) -> List[Dict]:
    """
    Tüm sembolleri tara, puanla, rankla.
    Returns: ranked candidate list
    """
    if verbose:
        print(f"\n[SCANNER] {scan_date_str} tarihli tarama başlıyor ({len(symbols)} sembol)...")

    # XU100 benchmark verisi
    df_xu100 = load("XU100", "Gunluk")

    results = []
    error_count = 0

    for i, sym in enumerate(symbols, 1):
        if verbose and (i % 10 == 0 or i == len(symbols)):
            print(f"  {i}/{len(symbols)} işlendi...", end="\r")

        result = scan_symbol(sym, scan_date_str, engine, df_xu100)
        if result is not None:
            results.append(result)
        else:
            error_count += 1

    if verbose:
        print(f"  {len(results)} sembol analiz edildi, {error_count} adet veri hatası.  ")

    # Puana göre sırala
    ranked = sorted(results, key=lambda x: -x["puan"])
    return ranked


# ═══════════════════════════════════════════════════════════════════
# RAPOR
# ═══════════════════════════════════════════════════════════════════

def print_full_report(ranked: List[Dict], scan_date_str: str, top_n: int) -> None:
    """Detaylı terminal raporu."""
    print(f"\n{'='*70}")
    print(f"  PRE-MOVE SCANNER — {scan_date_str}")
    print(f"{'='*70}")
    print(f"{'#':>3} {'SEMBOL':<8} {'PUAN':>6} {'DM':>3} {'FORMASYONLAR'}")
    print("-" * 70)

    for i, c in enumerate(ranked[:top_n], 1):
        sym    = c["sembol"]
        score  = c["puan"]
        status = c["durum"]
        pats   = c.get("pat_ozet", [])
        # get_pattern_summary → [(name, score), ...] tuple listesi
        pat_names_only = [p[0] if isinstance(p, tuple) else p for p in pats]
        pat_str = ", ".join(pat_names_only[:3]) if pat_names_only else "-"

        print(f"{i:>3}. {sym:<8} {score:>6.1f} {status:>3}  {pat_str}")

    # Breakdown (ilk 5 için)
    if ranked:
        print(f"\n--- TOP 5 DETAY ---")
        for c in ranked[:5]:
            print(f"\n► {c['sembol']} ({c['puan']:.1f})")
            bd = c.get("breakdown", {})
            for cat, val in bd.items():
                print(f"   {cat:<16}: {val:.1f}")

    # İstatistik
    total_count   = len(ranked)
    green_count   = sum(1 for c in ranked if c["puan"] >= SCORE_HIGH)
    yellow_count  = sum(1 for c in ranked if SCORE_WATCH <= c["puan"] < SCORE_HIGH)

    print(f"\n{'─'*70}")
    print(f"  Toplam tarandı: {total_count} | 🟢 Yüksek: {green_count} | 🟡 İzle: {yellow_count}")
    print(f"{'='*70}\n")


def save_report_json(ranked: List[Dict], scan_date_str: str) -> Path:
    """Tarama sonuçlarını JSON olarak kaydet."""
    out_dir = SCANNER_DIR / "output"
    out_dir.mkdir(parents=True, exist_ok=True)
    out_path = out_dir / f"scan_{scan_date_str.replace('-','')}.json"

    # features/patterns büyük olabileceğinden sadece özetini kaydet
    slim = []
    for c in ranked:
        slim.append({
            "sembol":     c["sembol"],
            "puan":       c["puan"],
            "durum":      c["durum"],
            "formasyonlar": c.get("pat_ozet", []),
            "breakdown":  c.get("breakdown", {}),
            "features_summary": {
                k: round(v, 3) if isinstance(v, float) else v
                for k, v in c.get("features", {}).items()
            },
        })

    with open(out_path, "w", encoding="utf-8") as f:
        json.dump({"tarih": scan_date_str, "sonuclar": slim}, f,
                  ensure_ascii=False, indent=2, default=str)
    return out_path


# ═══════════════════════════════════════════════════════════════════
# ANA
# ═══════════════════════════════════════════════════════════════════

def main():
    parser = argparse.ArgumentParser(description="Pre-Move Scanner — BIST")
    parser.add_argument("--tarih",      type=str, default=today_str(),
                        help="Tarama tarihi YYYY-MM-DD (varsayılan: bugün)")
    parser.add_argument("--topn",       type=int, default=TOP_N,
                        help=f"Kaç aday listele (varsayılan {TOP_N})")
    parser.add_argument("--no-train",   action="store_true",
                        help="Trainer güncellemesini atla")
    parser.add_argument("--perf-rapor", action="store_true",
                        help="Performans raporunu göster ve çık")
    parser.add_argument("--save-json",  action="store_true",
                        help="JSON raporu output klasörüne kaydet")
    parser.add_argument("--debug",      action="store_true",
                        help="Hata detaylarını göster")
    args = parser.parse_args()

    # ---- Performans raporu modu
    if args.perf_rapor:
        trainer = DailyTrainer()
        report  = trainer.get_performance_report()
        print(json.dumps(report, ensure_ascii=False, indent=2))
        trainer.print_weight_leaderboard()
        return

    scan_date = args.tarih
    print(f"\n{'─'*70}")
    print(f"  BIST PRE-MOVE SCANNER  |  Tarih: {scan_date}")
    print(f"{'─'*70}")

    # ---- Semboller
    symbols = get_symbol_list()
    print(f"  Aktif sembol sayısı: {len(symbols)}")

    # ---- Tarama
    engine = ScoreEngine()
    clear_cache()
    ranked = run_scan(scan_date, symbols, engine, verbose=True)

    # ---- Rapor
    print_full_report(ranked, scan_date, args.topn)

    # ---- JSON kaydet
    if args.save_json:
        out_path = save_report_json(ranked, scan_date)
        print(f"  JSON: {out_path}")

    # ---- Trainer
    if not args.no_train:
        trainer = DailyTrainer()

        # Bugünkü taramayı kaydet (features ve patterns dahil)
        trainer.record_scan(scan_date, ranked)
        print(f"  Tarama kaydedildi: {scan_date}")

        # Dünkü değerlendirme
        prev_date = prev_business_day(scan_date)
        result = trainer.evaluate_and_update(prev_date, hold_days=1)
        if result:
            hr = result.get("hit_rate")
            if hr is not None:
                print(f"  {prev_date} hit_rate: {hr:.1%}")

    print()


if __name__ == "__main__":
    main()
