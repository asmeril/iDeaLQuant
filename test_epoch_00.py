import struct, os
from datetime import datetime, timedelta

# Yeni Epoch Hipotezi: 1988-02-19 00:00:00 (Saat 01:00 degil 00:00)
BASE = datetime(1988, 2, 19, 0, 0)
RS = 32

def get_last_bar(fp):
    if not os.path.exists(fp): return None
    with open(fp, 'rb') as f:
        data = f.read()
    n = len(data) // RS
    if n == 0: return None
    m = struct.unpack('<i', data[(n-1)*RS : (n-1)*RS+4])[0]
    dt = BASE + timedelta(minutes=m)
    return dt, m

base_dir = r"D:\iDeal\ChartData\VIP\01"

thyao = get_last_bar(os.path.join(base_dir, "VIP'VIP-THYAO.01"))
x030t = get_last_bar(os.path.join(base_dir, "VIP'VIP-X030-T.01"))
x030  = get_last_bar(os.path.join(base_dir, "VIP'VIP-X030.01"))

print(f"=== YENI EPOCH (00:00) TESTI ===")
if thyao:
    print(f"THYAO Son Bar   : {thyao[0]}  (Binary minutes: {thyao[1]:,}) -- BEKLENEN: 18:09")
if x030t:
    print(f"X030-T Son Bar  : {x030t[0]}  (Binary minutes: {x030t[1]:,}) -- BEKLENEN: 22:59 (Kullanici 23:59 saniyor)")
if x030:
    print(f"X030 Son Bar    : {x030[0]}  (Binary minutes: {x030[1]:,}) -- BEKLENEN: 18:14 veya 18:09?")

# 18:09 ile 23:59 arasindaki gercek dakika farki:
gercek_fark = x030t[1] - thyao[1]
print(f"\nX030-T ve THYAO binary minute Farki: {gercek_fark} dakika")
print(f"Saat cinsinden: {gercek_fark // 60} saat {gercek_fark % 60} dakika")
