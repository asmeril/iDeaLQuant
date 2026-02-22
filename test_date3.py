import sys
import os
import pandas as pd
import numpy as np

sys.path.insert(0, os.path.abspath(os.path.join(os.path.dirname(__file__), '..')))

from src.engine.data import OHLCV

csv_path = "d:/Projects/IdealQuant/data/VIP_X030T_1dk_.csv"
data = OHLCV.from_ideal_export(csv_path)

dt_series = data.df['datetime']

print("dt_series dtypes:", dt_series.dtype)
print("dt_series first val:", dt_series.iloc[0])

arr = dt_series.values
print("values dtype:", arr.dtype)

arr_int = arr.astype(np.int64)
print("values as int64:", arr_int[:5])

print("To seconds depending on datatype:")
if arr.dtype == 'datetime64[ns]':
    print("It's nanoseconds. Divide by 10**9")
elif arr.dtype == 'datetime64[s]':
    print("It's seconds. Leave as is.")
elif arr.dtype == 'datetime64[ms]':
    print("It's milliseconds. Divide by 10**3")
else:
    print("Unknown dtype")
