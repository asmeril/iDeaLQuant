#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
ideal_disk_cache_export.py
==========================
iDeal veri terminalinin yerel disk cache'inden (D:/iDeal/ChartData/)
OHLC bar verilerini okuyarak CSV formatında export eder.

Piyasa saati dışında da çalışır — iDeal uygulamasının açık olmasına gerek yok.

Format: Tarih;Saat;Acilis;Yuksek;Dusuk;Kapanis;Ortalama;Hacim;Lot
Encoding: Windows-1254 (cp1254)
"""

import struct
import datetime
import os
import sys

# =============================================================================
# YAPILANDIRMA
# =============================================================================

# iDeal ChartData klasörü
CHART_DATA_DIR = r"D:\iDeal\ChartData\IMKBH"

# CSV çıktı klasörü
OUTPUT_DIR = r"D:\Projects\IdealQuant\reference\ideal_docs\BarData_Export"

# Kaç bar geriye gidilsin (maks 5000)
MAX_BARS = 5000

# Encoding
ENCODING = "cp1254"

# Timestamp Epoch (1-dk, 5-dk, 60-dk dosyaları için dakika bazlı)
# Doğrulama: ts=20058355 → 2026-04-09 10:00 TRT
EPOCH_MIN_UTC = datetime.datetime(1988, 2, 18, 21, 5, 0)
TRT_OFFSET = datetime.timedelta(hours=3)

# Günlük (G) dosyası için referans: ts=778089 = 2026-04-09
DAILY_REF_DATE = datetime.date(2026, 4, 9)
DAILY_REF_TS = 778089

# Sembol listesi — TeFo.txt'den dinamik yüklenir
# Format: her satır "IMKBH'SEMBOL" veya "VIP'VIP-SEMBOL"
# Dönüş: [(sembol_adi, piyasa), ...] — piyasa: "IMKBH" veya "VIP"
TEFO_PATH = r"D:\Projects\IdealQuant\scanner\TeFo.txt"

def load_semboller_from_tefo(path: str) -> list:
    semboller = []
    try:
        with open(path, "r", encoding="cp1254") as f:
            for line in f:
                s = line.strip()
                if s.startswith("IMKBH'"):
                    semboller.append((s[6:], "IMKBH"))  # "IMKBH'" = 6 karakter
                elif s.startswith("VIP'"):
                    semboller.append((s[4:], "VIP"))    # "VIP'" = 4 karakter → "VIP-AKBNK"
    except FileNotFoundError:
        print(f"UYARI: TeFo.txt bulunamadi: {path}")
    return semboller

SEMBOLLER = load_semboller_from_tefo(TEFO_PATH)

# Periyot tanımları
PERIYOTLAR = [
    {"etiket": "1dk",    "kaynak": "01",  "tip": "intraday", "dakika": 1},
    {"etiket": "5dk",    "kaynak": "05",  "tip": "intraday", "dakika": 1},   # Native 5dk — scalp
    {"etiket": "15dk",   "kaynak": "05",  "tip": "agregat",  "dakika": 1,  "agregat_dakika": 15},  # 5dk'dan aggregate
    {"etiket": "60dk",   "kaynak": "60",  "tip": "intraday", "dakika": 60},
    {"etiket": "Gunluk", "kaynak": "G",   "tip": "gunluk",   "dakika": None},
]

# =============================================================================
# YARDIMCI FONKSİYONLAR
# =============================================================================

RECORD_SIZE = 32
CSV_BASLIK = "Tarih;Saat;Acilis;Yuksek;Dusuk;Kapanis;Ortalama;Hacim;Lot"


def ts_to_datetime_trt(ts_raw: int, period_min: int) -> datetime.datetime:
    """
    İndeks tipine göre zaman damgasını TRT saatine dönüştürür.
    period_min: 1 = dakikabar, 60 = saatlik bar
    """
    total_min = ts_raw * period_min if period_min != 1 else ts_raw
    # 60-dk dosyası ts = saat sayısı (period_min=60 → dakikaya çevir)
    if period_min == 60:
        return EPOCH_MIN_UTC + datetime.timedelta(hours=ts_raw) + TRT_OFFSET
    else:
        return EPOCH_MIN_UTC + datetime.timedelta(minutes=ts_raw) + TRT_OFFSET


def daily_ts_to_date(ts_day: int) -> datetime.date:
    """Günlük dosya ts'ini tarih nesnesine çevirir."""
    return DAILY_REF_DATE + datetime.timedelta(days=ts_day - DAILY_REF_TS)


def read_binary_bars(filepath: str) -> list:
    """
    32-byte kayıt formatını okur.
    Dönüş: [(ts_raw, open, high, low, close, lot_count, tl_vol), ...]
    """
    with open(filepath, "rb") as f:
        data = f.read()
    n = len(data) // RECORD_SIZE
    bars = []
    for i in range(n):
        offset = i * RECORD_SIZE
        # Yapi: Int32 ts, float Open, float High, float Low, float Close,
        #        float lot_sayisi, float tl_hacim, Int32 sifir
        ts, o, h, l, c, lot_f, tl_f, _pad = struct.unpack_from("<IffffffI", data, offset)
        bars.append((ts, o, h, l, c, lot_f, tl_f))
    return bars


def bars_to_csv_lines_intraday(bars: list, period_min: int,
                                max_bars: int = MAX_BARS) -> list:
    """
    İntraday bar listesini CSV satırlarına dönüştürür.
    period_min=1 → dakika, period_min=60 → saat
    """
    # Son max_bars kadarını al
    bars = bars[-max_bars:]
    lines = []
    for (ts, o, h, l, c, lot_f, tl_f) in bars:
        dt = ts_to_datetime_trt(ts, period_min)
        tarih = dt.strftime("%d.%m.%Y")
        saat = dt.strftime("%H:%M")
        ort = (h + l) / 2.0
        # Hacim = TL hacim (tl_f), Lot = lot sayısı (lot_f)
        hacim = int(tl_f) if tl_f > 0 else int(lot_f)
        lot = 0
        lines.append(
            f"{tarih};{saat};{o:.2f};{h:.2f};{l:.2f};{c:.2f};{ort:.2f};{hacim};{lot}"
        )
    return lines


def aggregate_to_15min(bars_1dk: list) -> list:
    """
    1-dakikalık barları 15-dakikalık barlara agregat eder.
    Her 15-dakika penceresi:
      - Açılış = ilk bar Açılış
      - Yüksek = Maks Yüksek
      - Düşük = Min Düşük
      - Kapanış = son bar Kapanış
      - Hacim = Toplam TL hacim
      - Lot = 0
    Pencereye hizalama: minute % 15 == 0 noktalarında kapanan grouplar
    """
    groups = {}  # key: (tarih, 15-dk slot başlangıcı) → bar listesi

    for (ts, o, h, l, c, lot_f, tl_f) in bars_1dk:
        dt = ts_to_datetime_trt(ts, 1)
        # 15-dk penceresine hizala: bu dakikanın ait olduğu pencerenin başlangıcı
        minute_of_day = dt.hour * 60 + dt.minute
        slot_start_minute = (minute_of_day // 15) * 15
        slot_start_dt = dt.replace(
            hour=slot_start_minute // 60,
            minute=slot_start_minute % 60,
            second=0, microsecond=0
        )
        key = slot_start_dt
        if key not in groups:
            groups[key] = []
        groups[key].append((ts, o, h, l, c, lot_f, tl_f))

    # Sıralı grupları işle
    result = []
    for slot_dt in sorted(groups.keys()):
        group = groups[slot_dt]
        o_agg = group[0][1]              # İlk barın açılışı
        h_agg = max(bar[2] for bar in group)   # Maksimum yüksek
        l_agg = min(bar[3] for bar in group)   # Minimum düşük
        c_agg = group[-1][4]             # Son barın kapanışı
        vol_agg = sum(bar[6] for bar in group)  # TL hacim toplamı
        result.append((slot_dt, o_agg, h_agg, l_agg, c_agg, vol_agg))

    return result


def agg_bars_to_csv_lines(agg_bars: list, max_bars: int = MAX_BARS) -> list:
    """aggregate_to_15min() çıktısını CSV satırlarına çevirir."""
    agg_bars = agg_bars[-max_bars:]
    lines = []
    for (dt, o, h, l, c, vol) in agg_bars:
        tarih = dt.strftime("%d.%m.%Y")
        saat = dt.strftime("%H:%M")
        ort = (h + l) / 2.0
        lines.append(
            f"{tarih};{saat};{o:.2f};{h:.2f};{l:.2f};{c:.2f};{ort:.2f};{int(vol)};0"
        )
    return lines


def bars_to_csv_lines_gunluk(bars: list, max_bars: int = MAX_BARS) -> list:
    """Günlük bar listesini CSV satırlarına dönüştürür."""
    bars = bars[-max_bars:]
    lines = []
    for (ts, o, h, l, c, lot_f, tl_f) in bars:
        d = daily_ts_to_date(ts)
        tarih = d.strftime("%d.%m.%Y")
        saat = "00:00"
        ort = (h + l) / 2.0
        hacim = int(tl_f) if tl_f > 0 else int(lot_f)
        lot = 0
        lines.append(
            f"{tarih};{saat};{o:.2f};{h:.2f};{l:.2f};{c:.2f};{ort:.2f};{hacim};{lot}"
        )
    return lines


def get_filepath(sembol: str, period_dir: str, piyasa: str = "IMKBH") -> str:
    """iDeal disk cache dosya yolunu oluşturur."""
    ext_map = {"01": ".01", "05": ".05", "15": ".15", "60": ".60", "G": ".G"}
    ext = ext_map.get(period_dir, "." + period_dir)
    if piyasa == "VIP":
        vip_base = os.path.join(r"D:\iDeal\ChartData\VIP", period_dir)
        return os.path.join(vip_base, f"VIP'{sembol}{ext}")
    return os.path.join(CHART_DATA_DIR, period_dir, f"IMKBH'{sembol}{ext}")


# =============================================================================
# ANA FONKSİYON
# =============================================================================

def main():
    os.makedirs(OUTPUT_DIR, exist_ok=True)
    log_path = os.path.join(OUTPUT_DIR, "_export_log.txt")

    def log(msg: str):
        line = datetime.datetime.now().strftime("%H:%M:%S") + "  " + msg
        print(line)
        with open(log_path, "a", encoding=ENCODING) as f:
            f.write(line + "\n")

    log("=" * 60)
    log(f"EXPORT BASLIYOR - {datetime.datetime.now().strftime('%d.%m.%Y %H:%M:%S')}")
    log(f"Kaynak: {CHART_DATA_DIR}")
    log(f"Hedef : {OUTPUT_DIR}")
    imkbh_sayisi = sum(1 for _, p in SEMBOLLER if p == "IMKBH")
    vip_sayisi   = sum(1 for _, p in SEMBOLLER if p == "VIP")
    log(f"Semboller: {len(SEMBOLLER)} (IMKBH:{imkbh_sayisi} + VIP:{vip_sayisi}), Periyotlar: {len(PERIYOTLAR)}")

    yazilan = 0
    atlanan = 0
    hata = 0
    eksik_dosya = []

    for (sembol, piyasa) in SEMBOLLER:
        for per in PERIYOTLAR:
            etiket = per["etiket"]
            out_path = os.path.join(OUTPUT_DIR, f"{sembol}_{etiket}_5000bar.csv")

            # Bugün zaten yazıldıysa atla, eski dosyaysa üzerine yaz
            if os.path.exists(out_path):
                mtime = datetime.date.fromtimestamp(os.path.getmtime(out_path))
                if mtime == datetime.date.today():
                    atlanan += 1
                    continue
                # Eski dosya → üzerine yaz (yeni bar geldi)

            try:
                if per["tip"] == "intraday":
                    src_path = get_filepath(sembol, per["kaynak"], piyasa)
                    if not os.path.exists(src_path):
                        eksik_dosya.append(f"{sembol}_{etiket}")
                        log(f"EKSIK: {sembol} {etiket} ({src_path})")
                        hata += 1
                        continue
                    bars = read_binary_bars(src_path)
                    if not bars:
                        log(f"BOŞ: {sembol} {etiket}")
                        hata += 1
                        continue
                    lines = bars_to_csv_lines_intraday(bars, per["dakika"])

                elif per["tip"] == "agregat":
                    # 1-dk verisinden 15-dk oluştur
                    src_path = get_filepath(sembol, per["kaynak"], piyasa)
                    if not os.path.exists(src_path):
                        eksik_dosya.append(f"{sembol}_{etiket}")
                        log(f"EKSIK: {sembol} {etiket} (kaynak: {src_path})")
                        hata += 1
                        continue
                    bars_1dk = read_binary_bars(src_path)
                    if not bars_1dk:
                        log(f"BOŞ: {sembol} {etiket}")
                        hata += 1
                        continue
                    agg = aggregate_to_15min(bars_1dk)
                    lines = agg_bars_to_csv_lines(agg)

                elif per["tip"] == "gunluk":
                    src_path = get_filepath(sembol, per["kaynak"], piyasa)
                    if not os.path.exists(src_path):
                        eksik_dosya.append(f"{sembol}_{etiket}")
                        log(f"EKSIK: {sembol} {etiket} ({src_path})")
                        hata += 1
                        continue
                    bars = read_binary_bars(src_path)
                    if not bars:
                        log(f"BOŞ: {sembol} {etiket}")
                        hata += 1
                        continue
                    lines = bars_to_csv_lines_gunluk(bars)

                else:
                    log(f"BILINMEYEN TIP: {per['tip']}")
                    continue

                # CSV dosyasına yaz
                csv_content = CSV_BASLIK + "\n" + "\n".join(lines) + "\n"
                with open(out_path, "w", encoding=ENCODING) as f:
                    f.write(csv_content)

                yazilan += 1
                if yazilan % 20 == 0:
                    log(f"  {yazilan} dosya tamamlandi... Son: {sembol} {etiket} ({len(lines)} bar)")

            except Exception as ex:
                log(f"HATA: {sembol} {etiket} -> {str(ex)[:100]}")
                hata += 1

    log("=" * 60)
    log(f"TAMAMLANDI: {yazilan} dosya yazildi  |  {atlanan} mevcut (atlandi)  |  {hata} hata/eksik")
    if eksik_dosya:
        log(f"Eksik semboller: {', '.join(eksik_dosya)}")


if __name__ == "__main__":
    main()
