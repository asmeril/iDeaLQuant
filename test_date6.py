import pandas as pd
import numpy as np

s = pd.Series(["01.01.2024", "02.01.2024"])

try:
    arr = s.astype('datetime64[s]').astype(np.int64).values
    print("Parsed!", arr)
except Exception as e:
    print("Exception:", e)
