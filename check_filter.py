import os
import pandas as pd
import datetime
from src.data.ideal_parser import read_ideal_data

vip_path = r"D:\iDeal\ChartData\VIP\01\VIP'VIP-X030-T.01"

if os.path.exists(vip_path):
    df_raw = read_ideal_data(vip_path)
    if df_raw is not None:
        print(f"Raw len: {len(df_raw)}")
        
        start = datetime.date(2023, 1, 1)
        end = datetime.date(2026, 2, 25)
        
        filtered = df_raw[
            (df_raw['DateTime'].dt.date >= start) & 
            (df_raw['DateTime'].dt.date <= end)
        ].copy()
        
        print(f"Filtered len: {len(filtered)}")
        
        # Test n rows
        n = 0
        if n > 0:
            filtered = filtered.tail(n)
            
        print(f"Final len: {len(filtered)}")
