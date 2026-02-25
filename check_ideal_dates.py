import pandas as pd
from src.data.ideal_parser import load_ideal_data

try:
    df = load_ideal_data(r'D:\iDeal\ChartData', 'VIP', 'VIP-X030-T', '01')
    if df is not None:
        print(f"Total bars: {len(df)}")
        print(f"Start: {df['DateTime'].iloc[0]}")
        print(f"End: {df['DateTime'].iloc[-1]}")
        
        df_2023 = df[df['DateTime'].dt.year >= 2023]
        print(f"Bars since 2023: {len(df_2023)}")
        
        df_2024 = df[df['DateTime'].dt.year >= 2024]
        print(f"Bars since 2024: {len(df_2024)}")
except Exception as e:
    print(f"Error: {e}")
