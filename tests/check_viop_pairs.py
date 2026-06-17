# -*- coding: utf-8 -*-
"""VIOP yakın/uzak vade veri kontrol scripti"""
import sys
sys.path.insert(0, 'd:/Projects/IdealQuant')
from src.data.ideal_parser import read_ideal_data
from pathlib import Path

base = Path('D:/iDeal/ChartData')

test_pairs = [
    # (near_path, far_path, sym)
    ("VIP/01/VIP'F_GARAN0426.01",  "VIP/01/VIP'F_GARAN0526.01",  "GARAN"),
    ("VIP/01/VIP'F_XU0300426.01",  "VIP/01/VIP'F_XU0300626.01",  "XU030"),
    ("VIP/01/VIP'F_USDTRY0426.01", "VIP/01/VIP'F_USDTRY0526.01", "USDTRY"),
    ("VIP/01/VIP'F_THYAO0426.01",  "VIP/01/VIP'F_THYAO0526.01",  "THYAO"),
    ("VIP/01/VIP'F_AKBNK0426.01",  "VIP/01/VIP'F_AKBNK0526.01",  "AKBNK"),
    ("VIP/01/VIP'F_XLBNK0426.01",  "VIP/01/VIP'F_XLBNK0626.01",  "XLBNK (endeks)"),
    ("VIP/01/VIP'F_XAUUSD0426.01", "VIP/01/VIP'F_XAUUSD0626.01", "XAUUSD (cift-ay)"),
]

print("="*70)
print("VIOP Yakin/Uzak Vade Veri Kontrolu")
print("="*70)

for near_path, far_path, sym in test_pairs:
    near_file = base / near_path
    far_file = base / far_path
    
    near_exists = near_file.exists()
    far_exists = far_file.exists()
    
    if near_exists and far_exists:
        df_near = read_ideal_data(str(near_file))
        df_far  = read_ideal_data(str(far_file))
        
        print(f"\n{sym}:")
        print(f"  Yakin vade: {len(df_near):,} bar | "
              f"{df_near['DateTime'].min().strftime('%Y-%m-%d')} -> "
              f"{df_near['DateTime'].max().strftime('%Y-%m-%d %H:%M')}")
        print(f"  Uzak vade:  {len(df_far):,} bar | "
              f"{df_far['DateTime'].min().strftime('%Y-%m-%d')} -> "
              f"{df_far['DateTime'].max().strftime('%Y-%m-%d %H:%M')}")
        
        # Kapanislar
        print(f"  Yakin son fiyat: {df_near['Close'].iloc[-1]:.4f}")
        print(f"  Uzak  son fiyat: {df_far['Close'].iloc[-1]:.4f}")
        spread = df_far['Close'].iloc[-1] - df_near['Close'].iloc[-1]
        print(f"  Spread (uzak - yakin): {spread:.4f}")
    else:
        print(f"\n{sym}: DOSYA YOK (near={near_exists}, far={far_exists})")

print("\n" + "="*70)
print("Kontrol tamamlandi.")
