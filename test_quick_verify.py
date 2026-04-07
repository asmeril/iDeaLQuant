"""Hızlı doğrulama: sadece son 5 kaydı test et (tüm dosyayı parse etmeden)"""
import struct
from datetime import datetime, timedelta
import os, sys

sys.path.insert(0, os.getcwd())
from src.data.ideal_parser import BASE_DATE, RECORD_SIZE

base_dir = os.path.join("D:", os.sep, "iDeal", "ChartData", "VIP", "01")
fname = "VIP'VIP-X030-T.01"
file_path = os.path.join(base_dir, fname)

with open(file_path, 'rb') as f:
    data = f.read()

num_records = len(data) // RECORD_SIZE
print(f"BASE_DATE: {BASE_DATE}")
print(f"Toplam kayıt: {num_records:,}")
print()

# Son 5 kaydı oku
print("--- Son 5 kayıt ---")
for i in range(num_records - 5, num_records):
    offset = i * RECORD_SIZE
    chunk = data[offset:offset + RECORD_SIZE]
    vals = struct.unpack('<i6fi', chunk)
    time_minutes = vals[0]
    bar_datetime = BASE_DATE + timedelta(minutes=time_minutes)
    print(f"  [{i}] {bar_datetime} | Close={vals[4]:.0f}")

print()
print("Beklenen son bar: 2026-04-03 23:59:00")
last_chunk = data[(num_records-1) * RECORD_SIZE : num_records * RECORD_SIZE]
last_minutes = struct.unpack('<i', last_chunk[:4])[0]
last_dt = BASE_DATE + timedelta(minutes=last_minutes)
expected = datetime(2026, 4, 3, 23, 59)
match = last_dt == expected
print(f"Hesaplanan son bar: {last_dt}")
print(f"✓ DOĞRU!" if match else f"✗ HATA! Fark: {(last_dt - expected).days} gün")

# İlk kayıt
first_chunk = data[:RECORD_SIZE]
first_minutes = struct.unpack('<i', first_chunk[:4])[0]
first_dt = BASE_DATE + timedelta(minutes=first_minutes)
print(f"\nİlk bar: {first_dt}")
print("(Beklenen: 2012-11-xx tarihinde bir islem gunu acilisi)")
