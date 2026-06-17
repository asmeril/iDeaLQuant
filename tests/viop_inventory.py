# -*- coding: utf-8 -*-
"""
Tam VIOP Kontratlari Envanteri
- Yakin vade: Nisan 2026 (0426)
- Uzak vade:
    * Spot/hisse vadeliler: Mayis 2026 (0526)
    * Endeks + cift-ay kapananlar: Haziran 2026 (0626)
"""
import sys
sys.path.insert(0, 'd:/Projects/IdealQuant')
from src.data.ideal_parser import read_ideal_data
from pathlib import Path
import pandas as pd

BASE = Path('D:/iDeal/ChartData')
VIP_1M = BASE / 'VIP' / '01'

# Tum 0426, 0526, 0626 dosyalarini tara
files_0426 = {f.stem.split('F_')[1].replace('0426','') : f 
              for f in VIP_1M.glob("*F_*0426.01") if 'F_' in f.stem and f.stem.endswith('0426')}
files_0526 = {f.stem.split('F_')[1].replace('0526','') : f 
              for f in VIP_1M.glob("*F_*0526.01") if 'F_' in f.stem and f.stem.endswith('0526')}
files_0626 = {f.stem.split('F_')[1].replace('0626','') : f 
              for f in VIP_1M.glob("*F_*0626.01") if 'F_' in f.stem and f.stem.endswith('0626')}

# Kategoriler
# Spot vadeliler: 0426 + 0526 cifte var
# Endeks/cift-ay: 0426 + 0626 cifte var (ama 0526 YOK)

spot_symbols     = sorted(set(files_0426.keys()) & set(files_0526.keys()))
index_cy_symbols = sorted((set(files_0426.keys()) & set(files_0626.keys())) - set(files_0526.keys()))
only_0426        = sorted(set(files_0426.keys()) - set(files_0526.keys()) - set(files_0626.keys()))

def get_info(filepath):
    """Bar bilgisi ozeti"""
    try:
        df = read_ideal_data(str(filepath))
        if len(df) == 0:
            return None
        return {
            'bars': len(df),
            'start': df['DateTime'].min().strftime('%Y-%m-%d'),
            'end':   df['DateTime'].max().strftime('%Y-%m-%d %H:%M'),
            'last_close': df['Close'].iloc[-1],
        }
    except Exception as e:
        return None

print("="*80)
print("VIOP 1DK KONTRATLARI ENVANTERI")
print("  Yakin vade: Nisan 2026 (0426)")
print("  Uzak vade : Mayis 2026 (0526) - spot/hisse")
print("            : Haziran 2026 (0626) - endeks/cift-ay")
print("="*80)

rows = []

print(f"\n--- SPOT/HISSE VADELILER ({len(spot_symbols)} adet) ---")
print(f"{'Sembol':<16} {'N-bar(0426)':>12} {'N-bar(0526)':>12} {'Kapanis(0426)':>14} {'Kapanis(0526)':>14} {'Spread':>10}")
print("-"*80)
for sym in spot_symbols:
    ni = get_info(files_0426[sym])
    fi = get_info(files_0526[sym])
    if ni and fi:
        spread = fi['last_close'] - ni['last_close']
        pct    = spread / ni['last_close'] * 100 if ni['last_close'] != 0 else 0
        print(f"{sym:<16} {ni['bars']:>12,} {fi['bars']:>12,} {ni['last_close']:>14.4f} {fi['last_close']:>14.4f} {spread:>+10.4f} ({pct:+.2f}%)")
        rows.append({'Sembol': sym, 'Kategori': 'Spot', 'Yakin': '0426', 'Uzak': '0526',
                     'Bar_Yakin': ni['bars'], 'Bar_Uzak': fi['bars'],
                     'Son_Yakin': ni['last_close'], 'Son_Uzak': fi['last_close'],
                     'Spread': spread, 'Spread_Pct': pct})

print(f"\n--- ENDEKS/CIFT-AY VADELILER ({len(index_cy_symbols)} adet) ---")
print(f"{'Sembol':<16} {'N-bar(0426)':>12} {'N-bar(0626)':>12} {'Kapanis(0426)':>14} {'Kapanis(0626)':>14} {'Spread':>10}")
print("-"*80)
for sym in index_cy_symbols:
    ni = get_info(files_0426[sym])
    fi = get_info(files_0626[sym])
    if ni and fi:
        spread = fi['last_close'] - ni['last_close']
        pct    = spread / ni['last_close'] * 100 if ni['last_close'] != 0 else 0
        print(f"{sym:<16} {ni['bars']:>12,} {fi['bars']:>12,} {ni['last_close']:>14.4f} {fi['last_close']:>14.4f} {spread:>+10.4f} ({pct:+.2f}%)")
        rows.append({'Sembol': sym, 'Kategori': 'Endeks/CiftAy', 'Yakin': '0426', 'Uzak': '0626',
                     'Bar_Yakin': ni['bars'], 'Bar_Uzak': fi['bars'],
                     'Son_Yakin': ni['last_close'], 'Son_Uzak': fi['last_close'],
                     'Spread': spread, 'Spread_Pct': pct})

if only_0426:
    print(f"\n--- SADECE 0426 OLAN (uzak vade yok) ---")
    for sym in only_0426:
        ni = get_info(files_0426[sym])
        if ni:
            print(f"  {sym}: {ni['bars']:,} bar | son: {ni['end']} | kapanis: {ni['last_close']:.4f}")

# CSV kaydet
df_out = pd.DataFrame(rows)
out_path = 'd:/Projects/IdealQuant/tests/viop_inventory.csv'
df_out.to_csv(out_path, index=False, encoding='utf-8-sig')
print(f"\n\nEnvanter CSV kaydedildi: {out_path}")
print(f"Toplam: {len(rows)} kontrat cifti analiz edildi")
