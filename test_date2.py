import sys
import os
import pandas as pd
import numpy as np

sys.path.insert(0, os.path.abspath(os.path.join(os.path.dirname(__file__), '..')))

from src.engine.data import OHLCV
from src.optimization.strategy4_optimizer import IndicatorCache

csv_path = "d:/Projects/IdealQuant/data/VIP_X030T_1dk_.csv"
data = OHLCV.from_ideal_export(csv_path)

print("DataFrame Columns:", data.df.columns)
cache = IndicatorCache(data.df)

print("First 5 times_arr:", cache.times_arr[:5])
print("First 5 times_arr // 86400:", cache.times_arr[:5] // 86400)
print("Unique days in total data:", len(np.unique(cache.times_arr // 86400)))

# Assume index 0 to 10000 is train, rest is test
split_idx = int(len(data.df) * 0.70)
test_df = data.df.iloc[split_idx:].copy()
test_cache = IndicatorCache(test_df)

print("\n--- TEST DATA ---")
print("First 5 test times_arr:", test_cache.times_arr[:5])
print("First 5 test times_arr // 86400:", test_cache.times_arr[:5] // 86400)
print("Unique days in test data:", len(np.unique(test_cache.times_arr // 86400)))
