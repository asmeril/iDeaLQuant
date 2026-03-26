import os
import pandas as pd
import numpy as np
from src.indicators.core import RMA, SMA, EMA

def get_st_variant(h, l, c, factor, p1, p2, ct, at, ft):
    n = len(c)
    tr = np.zeros(n)
    tr[0] = h[0] - l[0]
    for i in range(1, n):
        tr[i] = max(h[i] - l[i], abs(h[i] - c[i-1]), abs(l[i] - c[i-1]))
    
    if at == 'rma':
        atr = np.array(RMA(tr.tolist(), p2))
    else:
        atr = np.array(EMA(tr.tolist(), p2))
        
    mid = np.zeros(n)
    h_arr, l_arr = np.array(h), np.array(l)
    if ct == 'mid':
        mid = (h_arr + l_arr) / 2.0
    elif ct == 'ema_mid':
        mid = np.array(EMA(((h_arr + l_arr) / 2.0).tolist(), p1))
    elif ct == 'hhv':
        for i in range(p1-1, n):
            mid[i] = (max(h[i-p1+1:i+1]) + min(l[i-p1+1:i+1])) / 2.0
            
    up = mid + factor * atr
    dn = mid - factor * atr
    
    st = np.zeros(n)
    trend = -1
    st[0] = up[0]
    for i in range(1, n):
        if trend == 1:
            st[i] = max(dn[i], st[i-1]) if not np.isnan(dn[i]) else st[i-1]
            check = l[i] if ft == 'hl' else c[i]
            if check < st[i]:
                trend = -1; st[i] = up[i]
        else:
            st[i] = min(up[i], st[i-1]) if not np.isnan(up[i]) else st[i-1]
            check = h[i] if ft == 'hl' else c[i]
            if check > st[i]:
                trend = 1; st[i] = dn[i]
    return st

def solve():
    data_path = r"d:\ProjectIdealQuant\data\ideal_supertrend.csv" # wait path fix
    if not os.path.exists(r"d:\Projects\IdealQuant\data\ideal_supertrend.csv"): return
    df = pd.read_csv(r"d:\Projects\IdealQuant\data\ideal_supertrend.csv", sep=';')
    h, l, c = df['High'].tolist(), df['Low'].tolist(), df['Close'].tolist()
    ideal = df['SuperTrend'].values
    factor = 3.0
    
    print("Testing variations...")
    best_res = []
    for pd1, pd2 in [(10, 14), (14, 10)]:
        for ct in ['mid', 'ema_mid', 'hhv']:
            for at in ['rma', 'ema']:
                for ft in ['close', 'hl']:
                    st_calc = get_st_variant(h, l, c, factor, pd1, pd2, ct, at, ft)
                    diff = np.abs(ideal[100:] - st_calc[100:])
                    pct = (diff / ideal[100:]).mean() * 100
                    best_res.append((pct, pd1, pd2, ct, at, ft))
    
    best_res.sort()
    for res in best_res[:10]:
        print(f"Error: {res[0]:.6f}% | Params: {res[1:]}")

if __name__ == "__main__":
    solve()
