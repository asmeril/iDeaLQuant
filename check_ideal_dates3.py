import pandas as pd
from src.data.ideal_parser import read_ideal_data

# VIP-X030 Sürekli Vadeli Kontrat (Tüm Veri)
vip_t_path = r"D:\iDeal\ChartData\VIP\VIP'VIP-X030-T.01"

with open('check_out3.txt', 'w') as f:
    try:
        df = read_ideal_data(vip_t_path)
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
