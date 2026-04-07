"""Tüm VIP 01 dosyalarını tara - BASE_DATE doğruluğunu ve farklılıkları analiz et"""
import struct, os
from datetime import datetime, timedelta

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

print(f"{'Dosya':<38} {'Barlar':>9} {'Ilk Bar':<22} {'Son Bar':<22} {'Son Saat'}")
print("-"*100)

for f in files:
    if not f.endswith('.01'):
        continue
    fp = os.path.join(base_dir, f)
    info = get_info(fp)
    if info:
        n, first, last = info
        son_saat = last.strftime("%H:%M")
        marker = "  <- AKŞAM" if last.hour >= 22 else ("  <- ÖĞLEDEN SONRA" if last.hour >= 17 else "")
        print(f"{f:<38} {n:>9,} {str(first):<22} {str(last):<22} {marker}")

print()
print("ÖZET: -T (takılı) semboller akşam seansını içeriyorsa son bar 23:59 civarı olmalı")
print("      Normal spot vadeli/spot hisse son bar 18:xx-19:xx olmalı")
