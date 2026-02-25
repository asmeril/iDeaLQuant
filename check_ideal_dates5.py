import os
import pandas as pd
from src.data.ideal_parser import read_ideal_data

paths = {
    "VIP-X030": r"D:\iDeal\ChartData\VIP\01\VIP'VIP-X030.01",
    "VIP-X030-T": r"D:\iDeal\ChartData\VIP\01\VIP'VIP-X030-T.01"
}

with open('check_out5.txt', 'w') as f:
    for name, path in paths.items():
        if os.path.exists(path):
            try:
                df = read_ideal_data(path)
                if df is not None:
                    f.write(f"--- {name} ---\n")
                    f.write(f"Total bars: {len(df)}\n")
                    f.write(f"Start: {df['DateTime'].iloc[0]}\n")
                    f.write(f"End: {df['DateTime'].iloc[-1]}\n")
            except Exception as e:
                f.write(f"{name}: Error: {e}\n")
        else:
            f.write(f"{name}: Not found at {path}\n")
