import os
import pandas as pd
from src.data.ideal_parser import read_ideal_data

vip_path = r"D:\iDeal\ChartData\VIP\01\VIP'VIP-X030-T.01"
print(f"File exists: {os.path.exists(vip_path)}")

if os.path.exists(vip_path):
    df = read_ideal_data(vip_path)
    if df is not None:
        print(f"Total bars: {len(df)}")
        print(f"Start: {df['DateTime'].iloc[0]}")
        print(f"End: {df['DateTime'].iloc[-1]}")
        
        df_2023 = df[df['DateTime'].dt.year >= 2023]
        print(f"Bars since 2023: {len(df_2023)}")
        
        df_2024 = df[df['DateTime'].dt.year >= 2024]
        print(f"Bars since 2024: {len(df_2024)}")
    else:
        print("DF loaded as None")
