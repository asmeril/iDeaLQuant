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

# Tüm endeks vadeli dosyaları glob ile bul (X030 içeren)
x030_files = sorted([f for f in os.listdir(base_dir) if 'X030' in f and f.endswith('.01')])

print("=== ENDEKS VADELILERI (X030 içeren tüm dosyalar) ===")
for fname in x030_files:
    fp = os.path.join(base_dir, fname)
    info = get_info(fp)
    if info:
        n, first, last = info
        h = last.hour
        seans = "AKSAM(23:xx)" if h >= 22 else ("GUNDUZ_SONU(19:xx)" if h >= 17 else "DIGER")
        aksam_mi = "✓ T-serisi" if '-T.' in fname else ("✓ A-serisi" if '-A.' in fname else "  normal")
        print(f"  {fname}")
        print(f"    Bar sayisi: {n:,}")
        print(f"    Ilk bar  : {first}")
        print(f"    Son bar  : {last}  [{seans}]  {aksam_mi}")

print()
print("=== GUMUS/ALTIN (AGU/XPT) - Gece seansli enstrümanlar ===")
gece_files = sorted([f for f in os.listdir(base_dir) if ('AGUSD' in f or 'XPTUSD' in f or 'XPDUSD' in f or 'GLD' in f) and f.endswith('.01')])
for fname in gece_files[:10]:
    fp = os.path.join(base_dir, fname)
    info = get_info(fp)
    if info:
        n, first, last = info
        print(f"  {fname}: {n:,} bar | Son: {last}")

print()
print("=== ÖZET: Seans Tipi Dağılımı ===")
aksam_sayisi = 0
gunduz_sayisi = 0
diger_sayisi = 0
guncellenmemis = []

all_files = sorted([f for f in os.listdir(base_dir) if f.endswith('.01')])
for fname in all_files:
    fp = os.path.join(base_dir, fname)
    info = get_info(fp)
    if info:
        n, first, last = info
        h = last.hour
        if h >= 22:
            aksam_sayisi += 1
        elif h >= 17:
            gunduz_sayisi += 1
        else:
            diger_sayisi += 1
        if last.date() < datetime(2026, 4, 3).date():
            guncellenmemis.append((fname, last))

print(f"  Aksam seansli (son bar >= 22:00): {aksam_sayisi} dosya")
print(f"  Gunduz seansli (son bar 17-22): {gunduz_sayisi} dosya")
print(f"  Diger (erken kapanma vb): {diger_sayisi} dosya")
print(f"  GUNCELLENMEMIS (son bar < 2026-04-03): {len(guncellenmemis)} dosya")
if guncellenmemis:
    print("  --> Guncellenmemis dosyalar:")
    for fname, last in guncellenmemis[:15]:
        print(f"      {fname}: {last}")

print()
print("=== BASE_DATE TUTARLILIGI KONTROLU ===")
print("Gozlem: Tum semboller icin BASE_DATE sabit mi yoksa sembol bazli mi degisiyor?")
print()
# X030-T icin bilinen dogrulama: son bar = 2026-04-03 23:59 = minutes 20,050,499
fp = os.path.join(base_dir, "VIP'VIP-X030-T.01")
if os.path.exists(fp):
    with open(fp, 'rb') as f:
        data = f.read()
    n = len(data) // RS
    last_minutes = struct.unpack('<i', data[(n-1)*RS:(n-1)*RS+4])[0]
    expected_dt = datetime(2026, 4, 3, 23, 59)
    calculated = BASE + timedelta(minutes=last_minutes)
    print(f"X030-T son bar: minutes={last_minutes:,}")
    print(f"  BASE + minutes = {calculated}")
    print(f"  Beklenen      = {expected_dt}")
    print(f"  ESLESME: {'EVET' if calculated == expected_dt else 'HAYIR - ' + str((calculated-expected_dt).total_seconds()/60) + ' dk fark'}")

# THYAO icin kontrol (spot vadeli, son bar 19:09 olmali)
fp2 = os.path.join(base_dir, "VIP'VIP-THYAO.01")
if os.path.exists(fp2):
    with open(fp2, 'rb') as f:
        data2 = f.read()
    n2 = len(data2) // RS
    last_minutes2 = struct.unpack('<i', data2[(n2-1)*RS:(n2-1)*RS+4])[0]
    calculated2 = BASE + timedelta(minutes=last_minutes2)
    print(f"\nTHYAO son bar: minutes={last_minutes2:,}")
    print(f"  BASE + minutes = {calculated2}")
    print(f"  Gunduz sonu (19:09) ise BASE_DATE tutarli: {'EVET' if 17 <= calculated2.hour <= 20 else 'HAYIR'}")
