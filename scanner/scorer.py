"""
scorer.py — Çok Faktörlü Puanlama Motoru

Özellikler + Formasyonlar → 0-100 puan arası ToplamSkor
Ağırlıklar memory/feature_weights.json'dan yüklenir.
Yoksa config.py'daki INITIAL_WEIGHTS kullanılır.
"""
from __future__ import annotations
import json
import math
import numpy as np
from typing import Dict, Any, List, Tuple
from pathlib import Path

from config import (
    INITIAL_WEIGHTS, MEMORY_WEIGHTS_FILE,
    SCORE_HIGH, SCORE_WATCH, TOP_N,
    MARKET_RALLY_THRESHOLD, MARKET_WEAKNESS_THRESH,
)


# ═══════════════════════════════════════════════════════════════════
# AĞIRLIK YÖNETİMİ
# ═══════════════════════════════════════════════════════════════════

def load_weights() -> Dict[str, Dict]:
    """JSON'dan ağırlıkları yükle. Yoksa başlangıç değerleri döner."""
    if MEMORY_WEIGHTS_FILE.exists():
        with open(MEMORY_WEIGHTS_FILE, "r", encoding="utf-8") as f:
            return json.load(f)
    return {k: dict(v, hit_rate_ema=0.50, total_count=0, hit_count=0)
            for k, v in INITIAL_WEIGHTS.items()}


def save_weights(weights: Dict[str, Dict]) -> None:
    MEMORY_WEIGHTS_FILE.parent.mkdir(parents=True, exist_ok=True)
    with open(MEMORY_WEIGHTS_FILE, "w", encoding="utf-8") as f:
        json.dump(weights, f, ensure_ascii=False, indent=2)


def effective_weight(w: Dict, ema_alpha: float = 0.5) -> float:
    """
    Efektif ağırlık = temel_ağırlık × (ema_alpha + hit_rate_ema × (1 - ema_alpha))
    İlk bootstrap'ta hit_rate_ema = 0.5 → efektif = temel_ağırlık (değişim yok)
    Zaman içinde hit rate kanıtlanırsa ağırlık artar/azalır.
    """
    base  = w.get("base", 3.0)
    hr    = w.get("hit_rate_ema", 0.50)
    return base * (ema_alpha + hr * (1.0 - ema_alpha))


# ═══════════════════════════════════════════════════════════════════
# PUANLAMA MOTORU
# ═══════════════════════════════════════════════════════════════════

# Formasyon ağırlıkları (konfigürasyonda değil, burada tutulur)
PATTERN_WEIGHTS = {
    # Mum formasyonları
    "hammer":             3.0,
    "pin_bar":            3.0,
    "bullish_engulfing":  4.0,
    "morning_star":       5.0,
    "dragonfly_doji":     2.5,
    "three_white_soldiers": 4.0,
    "bullish_harami":     2.0,
    "doji":               1.5,
    # Grafik formasyonları
    "vcp_full":           8.0,
    "flag_pennant":       6.0,
    "double_bottom":      5.0,
    "ascending_triangle": 4.0,
}

# Kategori bonus: Tüm kategoride güçlü sinyal varsa bonus puan
CATEGORY_BONUS = {
    "compression": 3.0,   # 3+ compression özelliği tetiklenirse
    "volume":      3.0,   # Pocket Pivot + VDU birlikte
    "structure":   2.0,
    "momentum":    2.0,
}


class ScoreEngine:
    """Pre-move adaylarını puanlar."""

    def __init__(self):
        self.weights = load_weights()

    def score(
        self,
        features: Dict[str, Any],
        patterns: Dict[str, float],
        market_daily_chg: float = 0.0,
    ) -> Tuple[float, Dict]:
        """
        Toplam puan (0-100) ve kategori bazlı detay döner.

        market_daily_chg: XU100 günlük değişim (%). RALLY modda rs_vs_xu100 pasif.

        Returns:
            (total_score, breakdown_dict)
        """
        if not features:
            return 0.0, {}

        breakdown = {
            "compression": 0.0,
            "volume":      0.0,
            "structure":   0.0,
            "momentum":    0.0,
            "patterns":    0.0,
            "bonus":       0.0,
        }

        # Piyasa rejimi: RALLY modda rs_vs_xu100 nötralize edilir
        is_rally    = market_daily_chg >  MARKET_RALLY_THRESHOLD
        is_weakness = market_daily_chg <  MARKET_WEAKNESS_THRESH

        # ── Özellik Skorları ─────────────────────────────────────
        cat_hit_count: Dict[str, int] = {k: 0 for k in breakdown}

        for feat_name, w_data in self.weights.items():
            # RALLY günü: rs_vs_xu100 anlamsız → ağırlığı sıfırla
            if feat_name == "rs_vs_xu100" and is_rally:
                continue
            cat = w_data.get("category", "momentum")
            eff_w = effective_weight(w_data)

            raw = features.get(feat_name, 0)
            # Normalize: bool → 1.0, float → 0-1
            if isinstance(raw, bool):
                val = 1.0 if raw else 0.0
            elif isinstance(raw, (int, float)) and not math.isnan(raw):
                val = max(0.0, min(1.0, float(raw)))
            else:
                val = 0.0

            contrib = eff_w * val
            if cat in breakdown:
                breakdown[cat] += contrib
                if val >= 0.5:
                    cat_hit_count[cat] += 1

        # ── Formasyon Skorları ───────────────────────────────────
        for pat_name, pat_score in patterns.items():
            pw = PATTERN_WEIGHTS.get(pat_name, 2.0)
            breakdown["patterns"] += pw * float(pat_score)

        # ── Kategori Bonus ────────────────────────────────────────
        # BB Squeeze standalone: kırılma baskısı yüksek (10.04 analizi: 8 atlanmış sembol)
        if features.get("bb_squeeze", 0) > 0.5:
            breakdown["bonus"] += 6.0

        # Compression: VCP + BB squeeze + (NR7 veya NR4)
        comp_strong = (
            features.get("vcp_score", 0) > 0.5 or
            features.get("bb_squeeze", 0) > 0.5
        ) and (features.get("nr7", False) or features.get("nr4", False))
        if comp_strong:
            breakdown["bonus"] += CATEGORY_BONUS["compression"]

        # Volume: Pocket Pivot + Vol Dryup birlikte
        if features.get("pocket_pivot", False) and features.get("vol_dryup", 0) > 0.3:
            breakdown["bonus"] += CATEGORY_BONUS["volume"]

        # Momentum: MACD crossing + RSI zone birlikte
        if features.get("macd_crossing", False) and features.get("rsi_zone", 0) > 0.5:
            breakdown["bonus"] += CATEGORY_BONUS["momentum"]

        # ── Toplam Skor (100 üzerinden normalize) ─────────────────
        raw_total = sum(breakdown.values())
        # Max teorik: ~60 (feature weights) + ~30 (patterns) + ~10 (bonus) = ~100
        # Normalize to 0-100
        total = min(100.0, raw_total)

        breakdown["total"] = round(total, 2)
        for k in breakdown:
            breakdown[k] = round(breakdown[k], 2)

        return round(total, 2), breakdown

    def rank_candidates(
        self,
        symbol_results: List[Tuple[str, float, Dict, Dict]],
        top_n: int = TOP_N,
    ) -> List[Dict]:
        """
        Sembolleri puana göre sıralar.

        symbol_results: [(symbol, score, breakdown, features), ...]
        """
        ranked = sorted(symbol_results, key=lambda x: -x[1])
        output = []
        for sym, score, bd, feats in ranked[:top_n]:
            status = "🔴 BEKLE"
            if score >= SCORE_HIGH:
                status = "🟢 YÜKSEK ÖNCELİK"
            elif score >= SCORE_WATCH:
                status = "🟡 TAKİPTE"

            active_pats = [
                (k, v) for k, v in (feats.get("_patterns", {}) or {}).items()
                if v >= 0.5
            ]
            active_pats_sorted = sorted(active_pats, key=lambda x: -x[1])

            output.append({
                "sembol":   sym,
                "puan":     score,
                "durum":    status,
                "fiyat":    feats.get("_close", 0),
                "kategori_puanlar": {
                    "Sıkışma":  bd.get("compression", 0),
                    "Hacim":    bd.get("volume", 0),
                    "Yapı":     bd.get("structure", 0),
                    "Momentum": bd.get("momentum", 0),
                    "Formasyonlar": bd.get("patterns", 0),
                    "Bonus":    bd.get("bonus", 0),
                },
                "formasyonlar": [p[0] for p in active_pats_sorted[:3]],
                "vcp_score":    round(feats.get("vcp_score", 0), 2),
                "rsi_zone":     round(feats.get("rsi_zone", 0), 2),
                "pocket_pivot": bool(feats.get("pocket_pivot", False)),
                "vol_dryup":    round(feats.get("vol_dryup", 0), 2),
                "bb_squeeze":   round(feats.get("bb_squeeze", 0), 2),
                "nr7":          bool(feats.get("nr7", False)),
            })
        return output

    def reload_weights(self) -> None:
        self.weights = load_weights()


# ═══════════════════════════════════════════════════════════════════
# RAPOR YAZICI
# ═══════════════════════════════════════════════════════════════════

def print_report(ranked: List[Dict], date_str: str = "") -> None:
    """Terminal'e renkli özet tablosu yaz."""
    header = f"\n{'='*75}"
    print(header)
    print(f"  PRE-MOVE SCANNER — {date_str}")
    print(f"{'='*75}")
    print(f"{'SEMBOL':<8} {'PUAN':>5} {'DURUM':<20} {'VCP':>5} {'RSI':>5} {'PP':>4} {'VDU':>5} {'FORMASYONLAR'}")
    print("-" * 75)

    for r in ranked:
        pats_str = ", ".join(r["formasyonlar"][:2]) if r["formasyonlar"] else "—"
        pp_str   = "✓" if r["pocket_pivot"] else "·"
        print(
            f"{r['sembol']:<8} {r['puan']:>5.1f} {r['durum']:<20} "
            f"{r['vcp_score']:>5.2f} {r['rsi_zone']:>5.2f} {pp_str:>4} "
            f"{r['vol_dryup']:>5.2f}  {pats_str}"
        )

    high = sum(1 for r in ranked if r["puan"] >= SCORE_HIGH)
    watch = sum(1 for r in ranked if SCORE_WATCH <= r["puan"] < SCORE_HIGH)
    print(f"\n  Yüksek Öncelik: {high}  |  Takipte: {watch}  |  Toplam: {len(ranked)}")
    print(header)
