import struct
from datetime import datetime, timedelta
import os

# Dosya yolu (tek tirnak sorun cikariyor, os.path ile coz)
base_dir = os.path.join("D:", os.sep, "iDeal", "ChartData", "VIP", "01")
fname = "VIP'VIP-X030-T.01"
file_path = os.path.join(base_dir, fname)

print(f"Dosya: {file_path}")
print(f"Mevcut mu: {os.path.exists(file_path)}")

with open(file_path, 'rb') as f:
    data = f.read()

RECORD_SIZE = 32
num_records = len(data) // RECORD_SIZE
print(f'Toplam kayit: {num_records:,}')
print(f'Dosya boyutu: {len(data):,} byte')

BASE_DATE_CURRENT = datetime(1988, 2, 24)  # Mevcut kod
# Alternatif base date'ler
BASE_DATE_ALT1 = datetime(1988, 2, 28)     # Yorumlarda belirtilen
BASE_DATE_ALT2 = datetime(1970, 1, 1)       # UNIX epoch

print()
print('--- son 5 kayit (ham) ---')
for i in range(num_records-5, num_records):
    offset = i * RECORD_SIZE
    chunk = data[offset:offset + RECORD_SIZE]
    vals = struct.unpack('<i6fi', chunk)
    time_minutes = vals[0]
    dt_current = BASE_DATE_CURRENT + timedelta(minutes=time_minutes)
    dt_alt1 = BASE_DATE_ALT1 + timedelta(minutes=time_minutes)
    print(f'  Kayit {i}: minutes={time_minutes:,}')
    print(f'    -> BASE_224: {dt_current}')
    print(f'    -> BASE_228: {dt_alt1}')
    print(f'    -> C={vals[4]:.0f}, Flags={vals[7]}')

print()
# Beklenen: 03.04.2026 23:59
expected = datetime(2026, 4, 3, 23, 59)
print(f'Beklenen son bar: {expected}')
for base_label, base in [("1988-02-24", BASE_DATE_CURRENT), ("1988-02-28", BASE_DATE_ALT1)]:
    offset = (num_records-1) * RECORD_SIZE
    chunk = data[offset:offset + RECORD_SIZE]
    vals = struct.unpack('<i6fi', chunk)
    actual_minutes = vals[0]
    calculated = base + timedelta(minutes=actual_minutes)
    delta_days = (calculated - expected).days
    print(f'  Base={base_label}: Son bar = {calculated}, Fark = {delta_days} gun')
