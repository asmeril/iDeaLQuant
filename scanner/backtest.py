"""
backtest.py — Tarihsel Olay Çalışması (Bootstrap Kalibrasyon)

Tüm hisselerin günlük verilerinde büyük hareket günlerini (>%5) bulur,
T-1, T-2, T-3 öncesindeki özellik değerlerini hesaplar ve
ilk ağırlık kalibrasyonu için hit-rate tablosu üretir.

Kullanım:
    python backtest.py                    → tüm data üzerinde çalıştır
    python backtest.py --threshold 0.05   → %5 eşiği
    python backtest.py --save-weights     → ağırlıkları memory klasörüne yaz
"""
from __future__ import annotations
import sys
import json
import argparse
import numpy as np
import pandas as pd
from pathlib import Path
from typing import Dict, List, Any

sys.path.insert(0, str(Path(__file__).parent.parent / "src"))

from config import (
    BAR_DIR, MEMORY_BACKTEST, MEMORY_WEIGHTS_FILE,
    BIG_MOVE_THRESHOLD, LOOKBACK_DAYS, INITIAL_WEIGHTS, EMA_ALPHA
)
from loader import load, list_available_symbols
from features import compute_all_features
from patterns import detect_all_patterns
from scorer import load_weights, save_weights, effective_weight


# ═══════════════════════════════════════════════════════════════════
# OLAY ÇALIŞMASI
# ═══════════════════════════════════════════════════════════════════

def find_big_move_days(df: pd.DataFrame, threshold: float) -> List[int]:
    """Günlük DataFrame'de %threshold üstü günlük getirilerin bar indekslerini döner."""
    if len(df) < 2:
        return []
    indices = []
    for i in range(1, len(df)):
        prev_c = df["close"].iloc[i-1]
        curr_c = df["close"].iloc[i]
        if prev_c > 0 and (curr_c / prev_c - 1) >= threshold:
            indices.append(i)
    return indices


def evaluate_features_at(
    df_G: pd.DataFrame,
    event_idx: int,
    lookback: int,
    df_xu100: pd.DataFrame = None,
) -> Dict[str, Any]:
    """
    Olay günü=event_idx, T-lookback günündeki özellikleri döner.
    """
    target_idx = event_idx - lookback
    if target_idx < 30:
        return {}
    try:
        feats = compute_all_features(df_G, bi=target_idx, df_xu100=df_xu100)
        pats  = detect_all_patterns(df_G, bi=target_idx)
        feats["_patterns"] = pats
        return feats
    except Exception:
        return {}


# ═══════════════════════════════════════════════════════════════════
# KALİBRASYON
# ═══════════════════════════════════════════════════════════════════

def run_backtest(threshold: float = BIG_MOVE_THRESHOLD) -> Dict:
    """
    Tüm semboller üzerinde backtest çalıştır.
    Her özellik için:
        - Toplam tetiklenme sayısı
        - Kaçında T+1 büyük hareket yaşandı (hit)
        - Hit rate
    """
    symbols = list_available_symbols("Gunluk")
    print(f"\nBacktest baslıyor: {len(symbols)} sembol, esik >= {threshold*100:.1f}%\n")

    # Her özellik için hit count
    feat_names = list(INITIAL_WEIGHTS.keys())
    pat_names  = [
        "hammer", "pin_bar", "bullish_engulfing", "morning_star",
        "dragonfly_doji", "three_white_soldiers", "bullish_harami",
        "doji", "vcp_full", "flag_pennant", "double_bottom", "ascending_triangle"
    ]
    all_names  = feat_names + pat_names

    stats: Dict[str, Dict] = {
        name: {"hit": 0, "total": 0} for name in all_names
    }

    total_events = 0
    symbol_event_counts = {}

    try:
        df_xu100 = load("XU100", "Gunluk")
    except Exception:
        df_xu100 = None

    for sym in symbols:
        df_G = load(sym, "Gunluk")
        if df_G is None or len(df_G) < 60:
            continue

        event_days = find_big_move_days(df_G, threshold)
        symbol_event_counts[sym] = len(event_days)
        total_events += len(event_days)

        # Non-event günleri bul (rastgele örneklem — olay/non-olay karşılaştırması için)
        all_indices = set(range(30, len(df_G) - 1))
        event_set   = set(event_days)
        non_event_days = sorted(all_indices - event_set)

        # Non-event'den örneklem al: olay sayısının 3 katı ama max 100
        import random
        sample_size  = min(len(event_days) * 3, 100)
        non_event_sample = random.sample(non_event_days, min(sample_size, len(non_event_days)))

        # EVENT günleri → T-1'de özellik var mı?
        for event_idx in event_days:
            feats = evaluate_features_at(df_G, event_idx, lookback=1, df_xu100=df_xu100)
            if not feats:
                continue

            for name in feat_names:
                raw = feats.get(name, 0)
                triggered = bool(raw >= 0.5) if isinstance(raw, (int, float)) else bool(raw)
                if triggered:
                    stats[name]["hit"]   += 1
                    stats[name]["total"] += 1
                else:
                    stats[name]["total"] += 1  # tetiklenmedi ama olay gününe ait

            pats = feats.get("_patterns", {})
            for name in pat_names:
                if pats.get(name, 0) >= 0.5:
                    stats[name]["hit"]   += 1
                    stats[name]["total"] += 1
                else:
                    stats[name]["total"] += 1

        # NON-EVENT günleri → özellik var ama hareket yok → false positive sayacı
        for ne_idx in non_event_sample:
            feats = evaluate_features_at(df_G, ne_idx + 1, lookback=1, df_xu100=df_xu100)
            if not feats:
                continue

            for name in feat_names:
                raw = feats.get(name, 0)
                triggered = bool(raw >= 0.5) if isinstance(raw, (int, float)) else bool(raw)
                if triggered:
                    # Tetiklendi ama büyük hareket YOK → false positive
                    stats[name]["total"] += 1
                    # hit += 0

            pats = feats.get("_patterns", {})
            for name in pat_names:
                if pats.get(name, 0) >= 0.5:
                    stats[name]["total"] += 1

    # Hit rate hesapla
    results = {}
    for name, s in stats.items():
        total = s["total"]
        hit   = s["hit"]
        hr    = hit / total if total > 0 else 0.5
        results[name] = {
            "hit":        hit,
            "total":      total,
            "hit_rate":   round(hr, 4),
        }

    summary = {
        "threshold":     threshold,
        "total_symbols": len(symbols),
        "total_events":  total_events,
        "feature_stats": results,
        "top_symbols":   sorted(symbol_event_counts.items(), key=lambda x: -x[1])[:10],
    }

    print(f"\n{'='*60}")
    print(f"BACKTEST ÖZET")
    print(f"{'='*60}")
    print(f"Toplam sembol : {len(symbols)}")
    print(f"Buyuk hareket: {total_events} olay (>={threshold*100:.1f}%)")
    print()
    print(f"{'ÖZELLİK':<25} {'HIT':>5} {'TOPLAM':>7} {'HIT RATE':>10}")
    print("-" * 55)

    sorted_feats = sorted(results.items(), key=lambda x: -x[1]["hit_rate"])
    for name, s in sorted_feats[:20]:
        if s["total"] >= 10:
            print(f"{name:<25} {s['hit']:>5} {s['total']:>7} {s['hit_rate']:>9.1%}")

    return summary


def calibrate_weights(backtest_results: Dict) -> Dict:
    """
    Backtest sonuçlarına göre ağırlıkları kalibre et.
    Yeni ağırlık: base_weight × (0.5 + hit_rate × 1.0)
    """
    weights = load_weights()
    feat_stats = backtest_results.get("feature_stats", {})

    for name, w in weights.items():
        if name in feat_stats:
            s = feat_stats[name]
            if s["total"] >= 20:
                # Güvenilir veri varsa hit_rate_ema'yı güncelle
                observed_hr = s["hit_rate"]
                old_ema     = w.get("hit_rate_ema", 0.5)
                new_ema     = EMA_ALPHA * observed_hr + (1 - EMA_ALPHA) * old_ema
                w["hit_rate_ema"]  = round(new_ema, 4)
                w["total_count"]   = s["total"]
                w["hit_count"]     = s["hit"]
            else:
                # Yetersiz veri → başlangıç değerini koru
                w.setdefault("hit_rate_ema", 0.5)

    return weights


# ═══════════════════════════════════════════════════════════════════
# GÜN SONU DEĞERLENDİRME (Trainer için kullanılır)
# ═══════════════════════════════════════════════════════════════════

def evaluate_candidates_next_day(
    symbol_list: List[str],
    scan_date: str,
    hold_days: int = 1,
) -> Dict[str, float]:
    """
    scan_date'de taranan sembollerin hold_days sonraki getirisini döner.
    scan_date format: "2026-04-09"
    """
    target_dt = pd.to_datetime(scan_date)
    results   = {}

    for sym in symbol_list:
        df = load(sym, "Gunluk")
        if df is None:
            continue
        mask = df["dt"].dt.normalize() == target_dt
        if not mask.any():
            continue
        scan_idx = int(df.index[mask][-1])
        future_idx = scan_idx + hold_days
        if future_idx >= len(df):
            continue
        c_now   = df["close"].iloc[scan_idx]
        c_future = df["close"].iloc[future_idx]
        if c_now > 0:
            results[sym] = round((c_future / c_now - 1), 4)

    return results


# ═══════════════════════════════════════════════════════════════════
# ANA
# ═══════════════════════════════════════════════════════════════════

def main():
    parser = argparse.ArgumentParser(description="Pre-Move Scanner Backtest")
    parser.add_argument("--threshold", type=float, default=BIG_MOVE_THRESHOLD,
                        help="Büyük hareket eşiği (varsayılan 0.05 = yüzde 5)")
    parser.add_argument("--save-weights", action="store_true",
                        help="Kalibrasyon sonuçlarını memory klasörüne kaydet")
    args = parser.parse_args()

    results = run_backtest(args.threshold)

    # JSON kaydet
    MEMORY_BACKTEST.parent.mkdir(parents=True, exist_ok=True)
    with open(MEMORY_BACKTEST, "w", encoding="utf-8") as f:
        json.dump(results, f, ensure_ascii=False, indent=2, default=str)
    print(f"\nBacktest sonuçları: {MEMORY_BACKTEST}")

    if args.save_weights:
        weights = calibrate_weights(results)
        save_weights(weights)
        print(f"Ağırlıklar güncellendi: {MEMORY_WEIGHTS_FILE}")

        # Efektif ağırlıkları göster
        print("\nEfektif Ağırlıklar (en yüksek ↓):")
        ew = sorted(
            [(k, effective_weight(v)) for k, v in weights.items()],
            key=lambda x: -x[1]
        )
        for k, v in ew[:10]:
            print(f"  {k:<25} {v:.2f}")


if __name__ == "__main__":
    main()
