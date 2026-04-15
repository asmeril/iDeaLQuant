import struct, datetime, os

EPOCH_MIN_UTC = datetime.datetime(1988, 2, 18, 21, 5, 0)
TRT = datetime.timedelta(hours=3)
DAILY_REF_DATE = datetime.date(2026, 4, 9)
DAILY_REF_TS = 778089

def test_file(path, label):
    if not os.path.exists(path):
        print(label, "-> DOSYA YOK:", path)
        return
    with open(path, "rb") as f:
        data = f.read()
    n = len(data) // 32
    print(f"{label} -> kayit: {n}  boyut: {len(data)} byte")
    for i in [0, n//2, n-1]:
        if 0 <= i < n:
            ts,o,h,l,c,lot,tl,_ = struct.unpack_from("<IffffffI", data, i*32)
            # Haftalik yorumlama (gunluk ile ayni formul, ama adim fark eder)
            try:
                d_gun = DAILY_REF_DATE + datetime.timedelta(days=ts - DAILY_REF_TS)
            except OverflowError:
                d_gun = "overflow"
            # Dakika yorumlama
            try:
                dt_dk = EPOCH_MIN_UTC + datetime.timedelta(minutes=ts) + TRT
                dk_str = dt_dk.strftime('%Y-%m-%d %H:%M')
            except OverflowError:
                dk_str = "overflow"
            print(f"  [{i:4d}] ts={ts}  gunluk={d_gun}  dakika={dk_str}  kap={c:.4f}")

print("=" * 70)
test_file(r"D:\iDeal\ChartData\IMKBH\B\IMKBH'ADEL.B",   "B  (haftalik/aylik?)")
print()
test_file(r"D:\iDeal\ChartData\IMKBH\5S\IMKBH'ADEL.5S", "5S (5saniye?)")
print()
test_file(r"D:\iDeal\ChartData\IMKBH\15\IMKBH'ESCOM.15", "15 (15dk?)")
print()
test_file(r"D:\iDeal\ChartData\IMKBH\05\IMKBH'ADEL.05", "05 (5dk?)")
