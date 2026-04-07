import struct, os
from datetime import datetime, timedelta

BASE = datetime(1988, 2, 19, 1, 0)
RS = 32

def get_info(fp):
    with open(fp, 'rb') as f:
        data = f.read()
    n = len(data) // RS
    if n == 0: return None
    def p(i): m = struct.unpack('<i', data[i*RS:i*RS+4])[0]; return BASE + timedelta(minutes=m)
    return n, p(0), p(n-1)

base_dir = r'D:\iDeal\ChartData\VIP\01'

print("=== ENDEKS VADELILERI ===")
targets = ['VIP-X030-T', 'VIP-X030', 'VIP-X030-A']
for sym in targets:
    fname = "VIP'VIP-" + sym + ".01"
    fp = os.path.join(base_dir, fname)
    if os.path.exists(fp):
        n, first, last = get_info(fp)
        h = last.hour
        seans = "AKSAM(23:59)" if h >= 22 else ("GUNDUZ_SONU(19:xx)" if h >= 17 else "DIGER")
        print(f"  {sym}: {n:,} bar")
        print(f"    Ilk bar : {first}")
        print(f"    Son bar : {last}  [{seans}]")
    else:
        print(f"  {sym}: DOSYA YOK")

print()
print("=== SPOT VADELILER (ilk 6 ornek) ===")
spot_files = [f for f in os.listdir(base_dir) if f.endswith('.01') and 'VIP-VIP-X' not in f and "F_" not in f]
for fname in sorted(spot_files)[:6]:
    fp = os.path.join(base_dir, fname)
    info = get_info(fp)
    if info:
        n, first, last = info
        print(f"  {fname}: {n:,} bar | Son: {last}")

print()
print("=== AYLIK VADELI SOZLESMELER (F_ prefixli) ===")
futures = sorted([f for f in os.listdir(base_dir) if f.startswith("VIP'F_")])
for fname in futures[:8]:
    fp = os.path.join(base_dir, fname)
    info = get_info(fp)
    if info:
        n, first, last = info
        print(f"  {fname}: {n:,} bar | Son: {last}")

print()
print("=== SONUC ANALIZI ===")
print("Son bar 2026-04-03 ise bardata GUNCELLENDI demektir.")
print("Son bar 2026-03-xx ise bardata GUNCELLENMEDI demektir.")

# Ozet istatistik
all_files = [f for f in os.listdir(base_dir) if f.endswith('.01')]
updated = 0
outdated = 0
for fname in all_files:
    fp = os.path.join(base_dir, fname)
    info = get_info(fp)
    if info:
        n, first, last = info
        if last.date() >= datetime(2026, 4, 3).date():
            updated += 1
        else:
            outdated += 1

print(f"\nGuncellenen : {updated} dosya")
print(f"Guncellenmeyen: {outdated} dosya")
