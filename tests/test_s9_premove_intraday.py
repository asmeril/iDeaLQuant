# -*- coding: utf-8 -*-
"""
S9 PreMove Intraday Strategy — Unit Testler
=========================================
%100 uyumluluk testleri:
  - Import testi
  - Yapısal sinyal üretimi (sinyal üretiyor mu?)
  - VCP scoring edge cases
  - BB Squeeze precomputation
  - Warmup bar koruması
  - C# formül karşılaştırmalı sayısal testler
"""
import sys, os
sys.path.insert(0, os.path.join(os.path.dirname(__file__), '..', '..'))

import pytest
import numpy as np
import random


# ── İmport ──────────────────────────────────────────────────────────

def test_import():
    """S9 strateji paketten düzgün import ediliyor mu?"""
    from src.strategies.premove_intraday_strategy import (
        PreMoveIntradayStrategy,
        PreMoveIntradayConfig,
    )
    assert PreMoveIntradayStrategy is not None
    assert PreMoveIntradayConfig is not None


def test_registry_import():
    """__init__.py üzerinden erişilebiliyor mu?"""
    from src.strategies import PreMoveIntradayStrategy, PreMoveIntradayConfig
    assert PreMoveIntradayStrategy is not None


# ── Yardımcılar ──────────────────────────────────────────────────────

def _make_bars(n: int = 600, seed: int = 42):
    """Gerçekçi sentetik VIOP bar verisi üret."""
    random.seed(seed)
    np.random.seed(seed)
    closes = [100.0]
    for _ in range(n - 1):
        closes.append(closes[-1] * (1 + np.random.normal(0, 0.002)))

    highs   = [c * (1 + abs(np.random.normal(0, 0.001))) for c in closes]
    lows    = [c * (1 - abs(np.random.normal(0, 0.001))) for c in closes]
    opens   = [c * (1 + np.random.normal(0, 0.0005)) for c in closes]
    volumes = [abs(np.random.normal(1e6, 2e5)) for _ in range(n)]
    return opens, highs, lows, closes, volumes


def _make_strategy(n: int = 600, **kwargs):
    from src.strategies.premove_intraday_strategy import (
        PreMoveIntradayStrategy, PreMoveIntradayConfig,
    )
    opens, highs, lows, closes, volumes = _make_bars(n)
    cfg = PreMoveIntradayConfig(**kwargs)
    return PreMoveIntradayStrategy(opens, highs, lows, closes, volumes, cfg)


# ── Temel Testler ────────────────────────────────────────────────────

def test_init_no_error():
    """600 barlık veri ile hata vermeden başlatılıyor mu?"""
    s = _make_strategy(600)
    assert s.n == 600


def test_warmup_protection():
    """Warmup tamamlanmadan sinyal üretilmemeli."""
    s = _make_strategy(600, warmup_bars=250)
    signals, _, _ = s.generate_all_signals()
    # Warmup barından önce hiç sinyal olmamalı
    assert np.all(signals[:250] == 0), "Warmup öncesi sinyal üretildi!"


def test_generate_returns_correct_shapes():
    """generate_all_signals() doğru shape döndürüyor mu?"""
    s = _make_strategy(600)
    signals, exits_long, exits_short = s.generate_all_signals()
    assert signals.shape     == (600,)
    assert exits_long.shape  == (600,)
    assert exits_short.shape == (600,)


def test_exits_short_always_false_in_sadece_al():
    """SADECE_AL modunda exits_short daima False olmalı."""
    s = _make_strategy(600, yon_modu="SADECE_AL")
    _, _, exits_short = s.generate_all_signals()
    assert not np.any(exits_short), "SADECE_AL modunda SHORT çıkışı oluştu!"


def test_no_simultaneous_signal_and_exit():
    """Aynı barda hem sinyal hem çıkış olamaz."""
    s = _make_strategy(600)
    signals, exits_long, _ = s.generate_all_signals()
    bad = (signals != 0) & exits_long
    assert not np.any(bad), "Aynı barda hem giriş hem çıkış oluştu!"


# ── Puan Fonksiyon Testleri ──────────────────────────────────────────

def test_ema_score_range():
    """"EMA skoru [0, 20] aralığında olmalı."""
    s = _make_strategy(600)
    for i in range(s.config.warmup_bars, s.n):
        score = s._calc_ema_score(i)
        assert 0 <= score <= 20, f"EMA puan sınır dışı: bar={i}, puan={score}"


def test_upvol_score_range():
    """UpVol skoru [0, 45] aralığında olmalı."""
    s = _make_strategy(600)
    for i in range(s.config.warmup_bars, s.n):
        score = s._calc_upvol_score(i)
        assert 0 <= score <= 45, f"UpVol puan sınır dışı: bar={i}, puan={score}"


def test_vcp_score_range():
    """VCP skoru [0, 30] aralığında olmalı."""
    s = _make_strategy(600)
    for i in range(s.config.warmup_bars, s.n):
        score = s._calc_vcp_score(i)
        assert 0 <= score <= 30, f"VCP puan sınır dışı: bar={i}, puan={score}"


def test_pp_penalty_values():
    """Pocket Pivot cezası -10, -5 veya 0 olmalı."""
    s = _make_strategy(600)
    for i in range(s.config.warmup_bars, s.n):
        pen = s._calc_pp_penalty(i)
        assert pen in (0.0, -5.0, -10.0), f"PP ceza beklenmedik değer: {pen}"


def test_bb_squeeze_values():
    """BB Squeeze 6.0 veya 0.0 döndürmeli."""
    s = _make_strategy(600)
    for i in range(s.config.warmup_bars, s.n):
        bb = s._calc_bb_squeeze_score(i)
        assert bb in (0.0, 6.0), f"BB Squeeze beklenmedik değer: {bb}"


def test_total_score_range():
    """Toplam puan [0, 100] aralığında olmalı."""
    s = _make_strategy(600)
    for i in range(s.config.warmup_bars, s.n):
        score = s._compute_score(i)
        assert 0 <= score <= 100, f"Toplam puan sınır dışı: bar={i}, puan={score}"


# ── C# Formül Uyumluluk Testleri ─────────────────────────────────────

def test_ema_score_perfect_alignment():
    """Tam hizalı EMA senaryosunda 20p alınmalı."""
    from src.strategies.premove_intraday_strategy import (
        PreMoveIntradayStrategy, PreMoveIntradayConfig,
    )
    # Monoton artan fiyat dizisi → EMA her zaman hizalı
    n = 400
    closes  = [100 + i * 0.1 for i in range(n)]
    highs   = [c + 0.5 for c in closes]
    lows    = [c - 0.5 for c in closes]
    opens   = closes[:]
    volumes = [1e6] * n
    cfg = PreMoveIntradayConfig(warmup_bars=220)
    s = PreMoveIntradayStrategy(opens, highs, lows, closes, volumes, cfg)
    # Son barda tam hizalama bekliyoruz
    score = s._calc_ema_score(n - 1)
    assert score == 20.0, f"Tam hizalı EMA için 20p beklendi, {score} alındı"


def test_vcp_min_bars_guard():
    """VCP lookback'ten az bar varsa 0 döndürmeli."""
    s = _make_strategy(600)
    # Çok küçük i için 0 bekliyoruz
    score = s._calc_vcp_score(4)
    assert score == 0.0, f"Yetersiz bar için VCP=0 beklendi, {score} alındı"


def test_from_config_dict():
    """from_config_dict fabrika metodu düzgün çalışıyor mu?"""
    from src.strategies.premove_intraday_strategy import PreMoveIntradayStrategy
    from types import SimpleNamespace

    n = 600
    opens, highs, lows, closes, volumes = _make_bars(n)
    cache = SimpleNamespace(
        opens=opens, highs=highs, lows=lows,
        closes=closes, volumes=volumes
    )
    params = {'esik_yuksek': 60, 'warmup_bars': 250}
    s = PreMoveIntradayStrategy.from_config_dict(cache, params)
    assert s.config.esik_yuksek == 60
    assert s.n == n


def test_bb_squeeze_nan_safety():
    """BB Squeeze hesabı NaN/inf içermemeli."""
    s = _make_strategy(600)
    for i in range(s.config.warmup_bars, s.n):
        val = s.atr_pct_bb[i]
        assert np.isfinite(val), f"BB ATR% NaN/inf: bar={i}"


if __name__ == "__main__":
    pytest.main([__file__, "-v"])
