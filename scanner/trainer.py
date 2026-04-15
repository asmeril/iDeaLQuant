"""
trainer.py — Günlük Öz-İyileştirme Modülü

Tarama sonuçlarını kaydeder, dünkü tahminleri bugünkü hareketle
karşılaştırır ve özellik ağırlıklarını Bayesian EMA ile günceller.

Kullanım:
    from trainer import DailyTrainer
    trainer = DailyTrainer()
    trainer.record_scan(date_str, ranked_candidates)
    trainer.evaluate_and_update(today_str="2026-04-10")
"""
from __future__ import annotations
import sys
import json
from datetime import date, datetime, timedelta
from pathlib import Path
from typing import Dict, List, Optional, Any

sys.path.insert(0, str(Path(__file__).parent.parent / "src"))

from config import (
    MEMORY_DAILY_LOG, MEMORY_WEIGHTS_FILE, MEMORY_PERF_LOG,
    EMA_ALPHA, BIG_MOVE_THRESHOLD, SCORE_HIGH, SCORE_WATCH,
    INITIAL_WEIGHTS, LOOKBACK_DAYS
)
from loader import load
from scorer import load_weights, save_weights, effective_weight


# ═══════════════════════════════════════════════════════════════════
# DAILY TRAINER
# ═══════════════════════════════════════════════════════════════════

class DailyTrainer:
    """
    Günlük tahmin kaydı, başarı değerlendirmesi ve ağırlık güncellemesi.

    Bir "hit" şudur:
        Sembolün tarama gününden gün gün sonra kapanışı,
        tarama günü kapanışına göre >= BIG_MOVE_THRESHOLD yükselmesi.

    Ağırlık güncellemesi:
        hit_rate_ema = α × observed + (1-α) × hit_rate_ema
        effective_weight = base_weight × (0.5 + hit_rate_ema)
    """

    def __init__(self):
        MEMORY_DAILY_LOG.parent.mkdir(parents=True, exist_ok=True)
        MEMORY_PERF_LOG.parent.mkdir(parents=True, exist_ok=True)

    # ─── Kayıt ──────────────────────────────────────────────────────

    def record_scan(
        self,
        date_str: str,
        ranked_candidates: List[Dict[str, Any]],
    ) -> None:
        """
        Günün tarama sonuçlarını JSONL log dosyasına ekler.

        ranked_candidates: runner.py'dan gelen liste
            [{"sembol": "ANELE", "puan": 87.5, "features": {...}, "patterns": {...}}, ...]
        """
        entry = {
            "date":       date_str,
            "scan_count": len(ranked_candidates),
            "candidates": [
                {
                    "sembol":   c.get("sembol"),
                    "puan":     c.get("puan"),
                    "features": c.get("features", {}),
                    "patterns": c.get("patterns", {}),
                }
                for c in ranked_candidates
            ],
        }
        with open(MEMORY_DAILY_LOG, "a", encoding="utf-8") as f:
            f.write(json.dumps(entry, ensure_ascii=False, default=str) + "\n")

    # ─── Değerlendirme ───────────────────────────────────────────────

    def load_scan(self, date_str: str) -> Optional[Dict]:
        """Log dosyasından belirli günün taramasını yükler."""
        if not MEMORY_DAILY_LOG.exists():
            return None
        with open(MEMORY_DAILY_LOG, "r", encoding="utf-8") as f:
            for line in f:
                if not line.strip():
                    continue
                try:
                    entry = json.loads(line)
                    if entry.get("date") == date_str:
                        return entry
                except json.JSONDecodeError:
                    continue
        return None

    def compute_outcomes(
        self,
        candidates: List[Dict],
        scan_date_str: str,
        hold_days: int = 1,
        threshold: float = BIG_MOVE_THRESHOLD,
    ) -> Dict[str, bool]:
        """
        Her sembol için hold_days sonraki gerçek getiriyi hesaplar.
        Returns: {sembol: success_bool}
        """
        target_dt = _parse_date(scan_date_str)
        results   = {}

        for cand in candidates:
            sym = cand.get("sembol")
            if not sym:
                continue

            df = load(sym, "Gunluk")
            if df is None or len(df) < 2:
                results[sym] = False
                continue

            # Tarama gününü bul
            mask = df["dt"].dt.normalize() == target_dt
            if not mask.any():
                results[sym] = False
                continue

            scan_pos  = int(df.index[mask][-1])
            future_pos = scan_pos + hold_days

            if future_pos >= len(df):
                results[sym] = False
                continue

            c_scan   = df["close"].iloc[scan_pos]
            c_future = df["close"].iloc[future_pos]

            if c_scan > 0:
                ret = c_future / c_scan - 1
                results[sym] = (ret >= threshold)
            else:
                results[sym] = False

        return results

    def evaluate_and_update(
        self,
        scan_date_str: str,
        hold_days: int = 1,
    ) -> Dict:
        """
        scan_date taramasını yükle, hold_days sonraki sonucu hesapla,
        ağırlıkları güncelle.
        Returns: performans özeti
        """
        entry = self.load_scan(scan_date_str)
        if entry is None:
            print(f"[TRAINER] {scan_date_str} için kayıtlı tarama bulunamadı.")
            return {}

        candidates = entry.get("candidates", [])
        if not candidates:
            return {}

        # features._date'i baz al (veri günü), scan_date_str değil (çalışma günü)
        first_features = candidates[0].get("features", {}) if candidates else {}
        data_date_str = str(first_features.get("_date", ""))[:10] or scan_date_str
        if not data_date_str or len(data_date_str) < 8:
            data_date_str = scan_date_str

        outcomes = self.compute_outcomes(candidates, data_date_str, hold_days)
        hit_count  = sum(outcomes.values())
        total      = len([c for c in candidates if c.get("sembol") in outcomes])

        print(f"\n[TRAINER] {scan_date_str} değerlendirmesi ({hold_days}g hold):")
        print(f"  Veri bazı   : {data_date_str}")
        print(f"  Toplam aday : {total}")
        print(f"  Başarılı    : {hit_count}")
        print(f"  Hit rate    : {hit_count/total:.1%}" if total > 0 else "  Hit rate    : N/A")

        # Ağırlık güncelle — per-day aggregate EMA (per-candidate DEĞİL)
        weights = load_weights()
        updated_features: Dict[str, Dict] = {}

        # Önce feature ve pattern başına gün içi hit/total say
        feat_hits:   Dict[str, int] = {}
        feat_totals: Dict[str, int] = {}
        pat_hits:    Dict[str, int] = {}
        pat_totals:  Dict[str, int] = {}

        for cand in candidates:
            sym      = cand.get("sembol")
            success  = outcomes.get(sym, False)
            features = cand.get("features", {})
            patterns = cand.get("patterns", {})

            for feat_name, raw_val in features.items():
                if feat_name not in weights:
                    continue
                triggered = bool(raw_val >= 0.5) if isinstance(raw_val, (int, float)) else bool(raw_val)
                if not triggered:
                    continue
                feat_totals[feat_name] = feat_totals.get(feat_name, 0) + 1
                if success:
                    feat_hits[feat_name] = feat_hits.get(feat_name, 0) + 1

            for pat_name, pat_score in patterns.items():
                if isinstance(pat_score, (int, float)) and pat_score >= 0.5:
                    pat_totals[pat_name] = pat_totals.get(pat_name, 0) + 1
                    if success:
                        pat_hits[pat_name] = pat_hits.get(pat_name, 0) + 1

        # Feature EMA'sını GÜNDE BİR KEZ aggregate hit ile güncelle
        for feat_name, n_total in feat_totals.items():
            if n_total == 0:
                continue
            n_hit = feat_hits.get(feat_name, 0)
            day_hit_rate = n_hit / n_total

            w = weights[feat_name]
            w.setdefault("hit_rate_ema", 0.5)
            w.setdefault("total_count", 0)
            w.setdefault("hit_count", 0)

            w["total_count"] += n_total
            w["hit_count"]   += n_hit
            w["hit_rate_ema"] = round(
                EMA_ALPHA * day_hit_rate + (1 - EMA_ALPHA) * w["hit_rate_ema"], 4
            )
            updated_features[feat_name] = w

        # Pattern ağırlıkları — aynı mantık
        for pat_name, n_total in pat_totals.items():
            if n_total == 0:
                continue
            n_hit = pat_hits.get(pat_name, 0)
            day_hit_rate = n_hit / n_total
            _update_pattern_hit_aggregate(pat_name, day_hit_rate)

        save_weights(weights)

        # Performans logu
        perf_entry = {
            "scan_date":  scan_date_str,
            "data_date":  data_date_str,
            "hold_days":  hold_days,
            "total":      total,
            "hits":       hit_count,
            "hit_rate":   round(hit_count / total, 4) if total > 0 else None,
            "outcomes":   outcomes,
        }
        with open(MEMORY_PERF_LOG, "a", encoding="utf-8") as f:
            f.write(json.dumps(perf_entry, ensure_ascii=False, default=str) + "\n")

        print(f"  Ağırlıklar güncellendi  → {MEMORY_WEIGHTS_FILE}")
        return perf_entry



    def get_performance_report(self, last_n: int = 30) -> Dict:
        """Son N günün performans özetini döner."""
        if not MEMORY_PERF_LOG.exists():
            return {"message": "Henüz değerlendirme verisi yok."}

        entries = []
        with open(MEMORY_PERF_LOG, "r", encoding="utf-8") as f:
            for line in f:
                if line.strip():
                    try:
                        entries.append(json.loads(line))
                    except json.JSONDecodeError:
                        pass

        entries = entries[-last_n:]
        if not entries:
            return {"message": "Veri yok."}

        total_hit   = sum(e.get("hits", 0)  for e in entries)
        total_total = sum(e.get("total", 0) for e in entries)
        overall_hr  = total_hit / total_total if total_total > 0 else 0

        result = {
            "periyot":         f"Son {len(entries)} gün",
            "toplam_aday":     total_total,
            "toplam_hit":      total_hit,
            "overall_hit_rate": f"{overall_hr:.1%}",
            "günlük":          [
                {
                    "tarih":    e.get("scan_date"),
                    "hit_rate": f"{e.get('hit_rate', 0):.1%}" if e.get("hit_rate") is not None else "N/A",
                    "aday":     e.get("total"),
                }
                for e in entries
            ],
        }
        return result

    def print_weight_leaderboard(self, top_n: int = 15) -> None:
        """En etkili n ağırlığı yazdır."""
        weights = load_weights()
        ranked  = sorted(
            [(k, effective_weight(v), v.get("hit_rate_ema", 0.5),
              v.get("total_count", 0)) for k, v in weights.items()],
            key=lambda x: -x[1]
        )
        print(f"\n{'='*62}")
        print(f"ÖZELLİK AĞIRLIK SIRALAMASI (en iyi {top_n})")
        print(f"{'='*62}")
        print(f"{'ÖZELLİK':<28} {'EFF.W':>6} {'HIT%':>7} {'ÖRNK':>6}")
        print("-" * 55)
        for name, eff, hr, cnt in ranked[:top_n]:
            print(f"{name:<28} {eff:>6.2f} {hr:>6.1%} {cnt:>6}")


# ═══════════════════════════════════════════════════════════════════
# YARDIMCI FONKSİYONLAR
# ═══════════════════════════════════════════════════════════════════

def _parse_date(date_str: str) -> "pd.Timestamp":
    import pandas as pd
    return pd.to_datetime(date_str)


_pattern_stats_cache: Dict[str, Dict] = {}

def _update_pattern_hit(pat_name: str, success: bool) -> None:
    """Pattern hit cache'ini günceller (session içi) — per-observation."""
    if pat_name not in _pattern_stats_cache:
        _pattern_stats_cache[pat_name] = {"hit": 0, "total": 0}
    _pattern_stats_cache[pat_name]["total"] += 1
    if success:
        _pattern_stats_cache[pat_name]["hit"] += 1


def _update_pattern_hit_aggregate(pat_name: str, day_hit_rate: float) -> None:
    """Pattern hit cache'ini GÜNDE BİR KEZ aggregate hit rate ile günceller."""
    if pat_name not in _pattern_stats_cache:
        _pattern_stats_cache[pat_name] = {"hit": 0, "total": 0}
    # Aggregate olarak sadece bir kez kayıt (sembolik +1 total)
    _pattern_stats_cache[pat_name]["total"] += 1
    _pattern_stats_cache[pat_name]["hit"] += day_hit_rate  # float aggregate


def prev_business_day(date_str: str) -> str:
    """Bir önceki iş günü (hafta sonu atlayarak)."""
    d = datetime.strptime(date_str, "%Y-%m-%d").date()
    d -= timedelta(days=1)
    while d.weekday() >= 5:  # Cumartesi=5, Pazar=6
        d -= timedelta(days=1)
    return d.strftime("%Y-%m-%d")


# ═══════════════════════════════════════════════════════════════════
# ANA (testing)
# ═══════════════════════════════════════════════════════════════════

if __name__ == "__main__":
    trainer = DailyTrainer()
    report  = trainer.get_performance_report()
    print(json.dumps(report, ensure_ascii=False, indent=2))
    trainer.print_weight_leaderboard()
