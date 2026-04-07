import struct
from datetime import datetime, timedelta
import os

base_dir = os.path.join("D:", os.sep, "iDeal", "ChartData", "VIP", "01")
fname = "VIP'VIP-X030-T.01"
file_path = os.path.join(base_dir, fname)

with open(file_path, 'rb') as f:
    data = f.read()

RECORD_SIZE = 32

# İlk kayıt
offset = 0
chunk = data[offset:offset + RECORD_SIZE]
vals = struct.unpack('<i6fi', chunk)
first_minutes = vals[0]

base_new = datetime(1988, 2, 19, 1, 0)
base_old = datetime(1988, 2, 24)

print(f'İlk kayıt minutes: {first_minutes:,}')
print(f'İlk kayıt - yeni base (1988-02-19 01:00): {base_new + timedelta(minutes=first_minutes)}')
print(f'İlk kayıt - eski base (1988-02-24 00:00): {base_old + timedelta(minutes=first_minutes)}')
