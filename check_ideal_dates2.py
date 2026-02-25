import pandas as pd
from src.data.ideal_parser import load_ideal_data

with open('check_out2.txt', 'w') as f:
    try:
        df = load_ideal_data(r'D:\iDeal\ChartData', 'VIP', 'VIP-X030-T', '01')
        if df is not None:
            f.write(f"Total bars: {len(df)}\n")
            f.write(f"Start: {df['DateTime'].iloc[0]}\n")
            f.write(f"End: {df['DateTime'].iloc[-1]}\n")
            
            df_2023 = df[df['DateTime'].dt.year >= 2023]
            f.write(f"Bars since 2023: {len(df_2023)}\n")
            
            df_2024 = df[df['DateTime'].dt.year >= 2024]
            f.write(f"Bars since 2024: {len(df_2024)}\n")
        else:
            f.write("DF is NONE\n")
    except Exception as e:
        f.write(f"Error: {e}\n")
