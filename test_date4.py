import sys
import os
import pandas as pd
import numpy as np

sys.path.insert(0, os.path.abspath(os.path.join(os.path.dirname(__file__), '..')))

from src.engine.data import OHLCV

csv_path = "d:/Projects/IdealQuant/data/VIP_X030T_1dk_.csv"
data = OHLCV.from_ideal_export(csv_path)

dt_series = data.df['datetime']
seconds_arr = dt_series.astype('datetime64[s]').astype(np.int64).values

print("Using astype('datetime64[s]').astype(int64):")
print(seconds_arr[:5])
print("Divided by 86400 (days):")
print(seconds_arr[:5] // 86400)
print("Unique days:", len(np.unique(seconds_arr // 86400)))
