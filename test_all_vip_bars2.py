"""Tüm VIP 01 dosyalarını tara - BASE_DATE doğruluğunu ve farklılıkları analiz et"""
import struct, os, sys
from datetime import datetime, timedelta

# ASCII çıktı için encoding zorla
sys.stdout.reconfigure(encoding='utf-8', errors='replace')

BASE = datetime(1988, 2, 19, 1, 0)
RS = 32

def get_info(fp):
    with open(fp, 'rb') as f:
        data = f.read()
    n = len(data) // RS
    if n == 0: return None
    def p(i):
        m = struct.unpack('<i', data[i*RS:i*RS+4])[0]
        return BASE + timedelta(minutes=m)
    return n, p(0), p(n-1)

base_dir = r'D:\iDeal\ChartData\VIP\01'
files = sorted(os.listdir(base_dir))

print("FILE | BARS | FIRST_BAR | LAST_BAR | LAST_HOUR")
print("-"*100)

for f in files:
    if not f.endswith('.01'):
        continue
    fp = os.path.join(base_dir, f)
    info = get_info(fp)
    if info:
        n, first, last = info
        tag = "AKSAM" if last.hour >= 22 else ("GUNDUZ_SONU" if last.hour >= 17 else "DIGER")
        print(f"{f} | {n:,} | {first} | {last} | {tag}")
