"""
Farklı semboller için binary dosyaları karşılaştır.
BASE_DATE'in tüm semboller için gerçekten aynı olup olmadığını test et.
"""
import struct
from datetime import datetime, timedelta
import os

BASE_DATE = datetime(1988, 2, 19, 1, 0)  # Düzeltilmiş
RECORD_SIZE = 32

def read_first_last(file_path):
    """Dosyanın ilk ve son kaydını oku"""
    with open(file_path, 'rb') as f:
        data = f.read()
    
    num = len(data) // RECORD_SIZE
    if num == 0:
        return None
    
    def parse(chunk):
        vals = struct.unpack('<i6fi', chunk)
        minutes = vals[0]
        dt = BASE_DATE + timedelta(minutes=minutes)
        return dt, vals[4]  # datetime, close
    
    first_dt, first_c = parse(data[:RECORD_SIZE])
    last_dt, last_c = parse(data[(num-1)*RECORD_SIZE:num*RECORD_SIZE])
    
    return {
        'bars': num,
        'first': first_dt,
        'last': last_dt,
        'last_close': last_c
    }

# Test edeceğimiz dosyalar
test_files = [
    # VIP 1dk dosyaları
    r"D:\iDeal\ChartData\VIP\01\VIP'VIP-X030-T.01",    # X030-T akşam seansı dahil
    r"D:\iDeal\ChartData\VIP\01\VIP'VIP-X030.01",       # X030 gündüz
    r"D:\iDeal\ChartData\VIP\01\VIP'VIP-X030-A.01",     # X030-A (başka?)
]

# IMKBH (spot hisseler) da varsa kontrol et
imkbh_dirs = [
    r"D:\iDeal\ChartData\IMKBH\01",
    r"D:\iDeal\ChartData\IMKBX\01",
]

print("=" * 90)
print(f"{'Dosya':<45} {'Barlar':>9} {'İlk Bar':<22} {'Son Bar':<22} {'Son C':>8}")
print("=" * 90)

for fp in test_files:
    if os.path.exists(fp):
        info = read_first_last(fp)
        if info:
            fname = os.path.basename(fp)[:44]
            print(f"{fname:<45} {info['bars']:>9,} {str(info['first']):<22} {str(info['last']):<22} {info['last_close']:>8.0f}")
    else:
        print(f"  [YOK] {os.path.basename(fp)}")

# IMKBH/IMKBX içindeki ilk birkaç dosyayı tara
for d in imkbh_dirs:
    if os.path.exists(d):
        files = [f for f in os.listdir(d) if f.endswith('.01')][:5]
        for fname in files:
            fp = os.path.join(d, fname)
            info = read_first_last(fp)
            if info:
                display = os.path.basename(d) + '/' + fname[:30]
                print(f"{display:<45} {info['bars']:>9,} {str(info['first']):<22} {str(info['last']):<22} {info['last_close']:>8.0f}")

print("=" * 90)
print()
print("KONTROL: Beklenen son bar VIP-X030-T için 2026-04-03 23:59")
print("         Spot vadeliler için akşam seansı YOK -> son bar 18:xx gibi olmalı")
