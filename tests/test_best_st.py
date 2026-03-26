import os
import pandas as pd
import numpy as np
from src.indicators.core import EMA

def test_best():
    df = pd.read_csv(r"d:\Projects\IdealQuant\data\ideal_supertrend.csv", sep=';')
    h, l, c = df['High'].values, df['Low'].values, df['Close'].values
    ideal = df['SuperTrend'].values
    
    n = len(c)
    tr = np.zeros(n)
    tr[0] = h[0] - l[0]
    for i in range(1, n):
        tr[i] = max(h[i] - l[i], abs(h[i] - c[i-1]), abs(l[i] - c[i-1]))
    
    atr = np.array(EMA(tr.tolist(), 14))
    mid = (h + l) / 2.0
    
    factor = 3.0
    upper = mid + factor * atr
    lower = mid - factor * atr
    
    st = np.zeros(n)
    trend = -1
    st[0] = upper[0]
    for i in range(1, n):
        if trend == 1:
            st[i] = max(lower[i], st[i-1])
            if c[i] < st[i]:
                trend = -1; st[i] = upper[i]
        else:
            st[i] = min(upper[i], st[i-1])
            if c[i] > st[i]:
                trend = 1; st[i] = lower[i]
                
    df['ST_Py'] = st
    df['Diff'] = df['SuperTrend'] - df['ST_Py']
    
    print(df[['BarNo', 'Close', 'SuperTrend', 'ST_Py', 'Diff']].iloc[100:110])
    print(f"\nMean Diff: {df['Diff'].abs().mean():.4f}")

if __name__ == "__main__":
    test_best()
