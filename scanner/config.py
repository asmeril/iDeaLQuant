"""
config.py — Pre-Move Scanner Yapılandırması
Tüm sabitler, yollar ve ayarlar bu dosyadan yönetilir.
"""
from pathlib import Path
import datetime

# ─────────────────────────── YOLLAR ────────────────────────────
BASE_DIR     = Path(r"D:\Projects\IdealQuant")
BAR_DIR      = BASE_DIR / "reference" / "ideal_docs" / "BarData_Export"
SCANNER_DIR  = BASE_DIR / "scanner"
MEMORY_DIR   = SCANNER_DIR / "memory"
EXPORT_SCRIPT = BASE_DIR / "ideal_disk_cache_export.py"

MEMORY_WEIGHTS_FILE  = MEMORY_DIR / "feature_weights.json"
MEMORY_DAILY_LOG     = MEMORY_DIR / "daily_log.jsonl"
MEMORY_BACKTEST      = MEMORY_DIR / "backtest_results.json"
MEMORY_PERF_LOG      = MEMORY_DIR / "performance_log.jsonl"

# ─────────────────────────── VERİ ──────────────────────────────
ENCODING     = "cp1254"
DATE_FMT     = "%d.%m.%Y"
CSV_SEP      = ";"

# Minimum bar sayıları (daha az varsa sembol atlanır)
MIN_BARS = {
    "Gunluk": 126,   # ~6 ay günlük
    "60dk":   200,   # ~2 ay 60dk
    "15dk":   100,
    "5dk":    200,   # ~3-4 günlük seans (scalp analizi için)
    "1dk":    50,
}

# ─────────────────────────── SEMBOL LİSTESİ ─────────────────────
# Mevcut BarData_Export'taki 70 sembol (robot listesiyle tam eşleşir)
# KLMDE, BASSO, KRABB, TUNGE — iDeal'de işlem görmeyebilir, hata alınırsa loader atlar
SEMBOLLER_70 = [
    "ANELE","BORLS","KONTR","SMRVA","SVGYO","ADEL","AAGYO","TKFEN","CEOEM","DMRGD",
    "GLRMK","DGNMO","VRGYO","ALVES","BRMEN","KLMDE","DOGUB","SANFM","OBASE","BRKO",
    "TRHOL","ULUSE","KTSKR","LIDER","CVKMD","KRDMD","RNPOL","DCTTR","AYCES","BASSO",
    "GATEG","KLMSN","SEKUR","ASUZU","KRDMA","KERVN","ERSU","EMKEL","ALCTL","RYGYO",
    "GZNMI","SMRTG","OZRDN","KRABB","TERA","ARMGD","YGGYO","MOBTL","EDATA","SEGYO",
    "MAGEN","ICUGS","CWENE","ASELS","ARZUM","DEVA","TUNGE","TEKTU","RALYH","DURDO",
    "GOKNR","BIOEN","TEZOL","OYAYO","MOGAN","ODAS","BYDNR","SOKM","YAYLA","ENTRA",
]

# ─────────────────────────── PUANLAMA EŞİKLERİ ───────────────────
SCORE_HIGH     = 70    # YÜKSEK ÖNCELİK
SCORE_WATCH    = 50    # TAKİPTE
TOP_N          = 20    # Raporda gösterilecek max sembol sayısı

# ─────────────────────────── ÖZELLİK AĞIRLIKLARI (Başlangıç) ────
# Bu değerler backtest.py tarafından kalibre edilir ve memory/feature_weights.json'a yazılır.
# Kaynak: Minervini VCP, Gil Morales Pocket Pivot, O'Neil CAN SLIM, Bollinger Squeeze

INITIAL_WEIGHTS = {
    # === Volatilite Sıkışması ===
    # vcp_score: backtest %15.3 hit → düşük etki, base düşürüldü (eski: 8.0)
    "vcp_score":          {"base": 3.0,  "category": "compression", "desc": "VCP (3+ pivot, daralma)"},
    # bb_squeeze: backtest %5.9 hit → zayıf sinyal (eski: 6.0)
    "bb_squeeze":         {"base": 2.0,  "category": "compression", "desc": "BB Width persentil < %15"},
    # nr7: backtest %17.2 hit → zayıf ama katkısı var (eski: 3.0)
    "nr7":                {"base": 2.5,  "category": "compression", "desc": "Son 7 günün en dar TrueRange'i"},
    # nr4: backtest %25.0 hit → nr7'den biraz güçlü (eski: 2.0)
    "nr4":                {"base": 2.5,  "category": "compression", "desc": "Son 4 günün en dar TrueRange'i"},
    # inside_day_streak: backtest %21.7 hit (eski: 3.0)
    "inside_day_streak":  {"base": 2.5,  "category": "compression", "desc": "Ard arda iç mum sayısı"},
    # atr_pct_rank: backtest %31.8 hit → orta düzey (eski: 3.0)
    "atr_pct_rank":       {"base": 3.5,  "category": "compression", "desc": "ATR% 126 günlük persentil (düşük=sıkışma)"},
    # range_contraction: backtest %44.0 hit → iyi sinyal (eski: 2.0)
    "range_contraction":  {"base": 5.0,  "category": "compression", "desc": "Son 5 günlük ortalama range küçülüyor"},

    # === Hacim Analizi ===
    # pocket_pivot: backtest %42.1 hit (eski: 8.0)
    "pocket_pivot":       {"base": 7.0,  "category": "volume", "desc": "Pocket Pivot (Gil Morales)"},
    # vol_dryup: backtest %6.4 hit → çok zayıf (eski: 6.0)
    "vol_dryup":          {"base": 2.0,  "category": "volume", "desc": "Hacim Dry-Up (< ort×0.6)"},
    # obv_slope: backtest %0.1 hit → neredeyse sıfır! (eski: 4.0)
    "obv_slope":          {"base": 0.5,  "category": "volume", "desc": "OBV eğimi yukarı (normalize)"},
    # cmf_positive: backtest %2.6 hit → işe yaramaz neredeyse (eski: 3.0)
    "cmf_positive":       {"base": 0.5,  "category": "volume", "desc": "CMF > 0"},
    # up_vol_ratio: backtest %64.2 hit — EN GÜÇLÜ SINYAL! (eski: 4.0)
    "up_vol_ratio":       {"base": 9.0,  "category": "volume", "desc": "Up/Down hacim oranı — son 20g yükselen+güçlü hacimli gün"},

    # === Fiyat Yapısı & Relatif Güç ===
    # ema_stack_score: backtest %49.2 hit → güçlü yapısal sinyal (eski: 6.0)
    "ema_stack_score":    {"base": 7.0,  "category": "structure", "desc": "EMA9>EMA20>EMA50 dizilimi"},
    # ema50_slope_up: backtest %46.6 hit (eski: 3.0)
    "ema50_slope_up":     {"base": 4.0,  "category": "structure", "desc": "EMA50 yukarı"},
    # below_52w_high: backtest %14.7 hit → zayıf (eski: 5.0)
    "below_52w_high":     {"base": 2.0,  "category": "structure", "desc": "52 haftalık zirvenin %0-15 altında"},
    # rs_vs_xu100: backtest %8.7 hit → zayıf (eski: 5.0)
    "rs_vs_xu100":        {"base": 2.0,  "category": "structure", "desc": "XU100'e karşı relatif güç > 0"},
    # base_position_ok: backtest %46.2 hit → iyi (eski: 3.0)
    "base_position_ok":   {"base": 4.0,  "category": "structure", "desc": "Taban üst %50'sinde"},
    # near_support: backtest %10.3 hit → zayıf (eski: 3.0)
    "near_support":       {"base": 1.5,  "category": "structure", "desc": "EMA20/EMA50 yakınında destek"},

    # === Momentum & Osilatörler ===
    # rsi_zone: backtest %38.1 hit (eski: 5.0)
    "rsi_zone":           {"base": 4.5,  "category": "momentum", "desc": "RSI 45-65 birikme bandı"},
    # rsi_slope_up: backtest %45.9 hit (eski: 4.0)
    "rsi_slope_up":       {"base": 4.5,  "category": "momentum", "desc": "RSI son 5 barda yukarı"},
    # macd_hist_rising: backtest %26.3 hit → orta (eski: 5.0)
    "macd_hist_rising":   {"base": 3.0,  "category": "momentum", "desc": "MACD hist 3+ bar artıyor"},
    # macd_crossing: backtest %4.6 hit → neredeyse işe yaramaz (eski: 4.0)
    "macd_crossing":      {"base": 1.0,  "category": "momentum", "desc": "MACD sinyal üstüne geçiyor"},
    # stoch_turning: backtest %0.0 hit — TAMAMEN IŞE YARAMAZ (eski: 4.0)
    "stoch_turning":      {"base": 0.5,  "category": "momentum", "desc": "Stoch oversold'dan dönüyor"},
    # adx_rising_low: backtest %14.0 hit → zayıf (eski: 3.0)
    "adx_rising_low":     {"base": 1.5,  "category": "momentum", "desc": "ADX < 25'ten yükseliyor"},
}

# ─────────────────────────── PİYASA REJİMİ EŞİKLERİ ──────────────
# RS20 filtresi: XU100 günlük getirisi bu eşiği geçince RALLY moduna girer.
# Rally modda rs_vs_xu100 önemi sıfırlanır (piyasa geneli yükselirken RS anlamsız).
MARKET_RALLY_THRESHOLD  = 1.5   # XU100 günlük > +%1.5 → RALLY modu
MARKET_WEAKNESS_THRESH  = -1.5  # XU100 günlük < -%1.5 → ZAYIF modu (RS daha kritik)

# Piyasa filtre ayarları (analysis_kacis_nedeni.py'den alınan değerler, doğrulandı)
MARKET_FILTER = {
    "ema50_above":       True,    # Fiyat > EMA50
    "vol_mult":          1.5,     # Vol > VolMA20 × 1.5
    "close_pos_min":     0.60,    # Kapanış mum aralığında üst %40
    "atr_ratio_max":     0.03,    # ATR / Fiyat < %3
    "ema20_dist_max":    0.05,    # EMA20'den < %5 uzak
    "gap_up_max":        0.025,   # Gap < %2.5
    "daily_chg_max":     0.04,    # Günlük değişim < %4
}

# ─────────────────────────── BACKTEST AYARLARI ────────────────────
BIG_MOVE_THRESHOLD  = 0.05   # Büyük hareket: günlük %5 veya üstü
LOOKBACK_DAYS       = [1, 2, 3, 5]   # T-N gün öncesi özellikler
SUCCESS_WINDOW      = 1      # N gün sonra hareket hesapla

# ─────────────────────────── TRAINER AYARLARI ─────────────────────
EMA_ALPHA           = 0.1    # Hit rate EMA güncelleme hızı
WEIGHT_BLEND        = 0.5    # Base ağırlık ile emprik oranın harmanlama katsayısı
TOP_CANDIDATE_PERCENT = 0.2  # Günlük top-N adaylar (tüm evrenin %20'si)
