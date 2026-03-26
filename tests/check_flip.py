"""
Investigate the specific bar where Python and IdealData diverge completely in trend direction.
"""
import pandas as pd
import numpy as np

def main():
    bar_path = r"d:\Projects\IdealQuant\data\VIPX030T_1Dk_BarData.csv"
    try:
        df_bars = pd.read_csv(bar_path, sep=';', encoding='utf-8')
    except:
        df_bars = pd.read_csv(bar_path, sep=';', encoding='iso-8859-9')
        
    cols = list(df_bars.columns)
    h = df_bars[cols[3]].astype(str).str.replace(',', '.').astype(float).values
    l = df_bars[cols[4]].astype(str).str.replace(',', '.').astype(float).values
    c = df_bars[cols[5]].astype(str).str.replace(',', '.').astype(float).values
    
    ideal_path = r"d:\Projects\IdealQuant\data\ideal_supertrend.csv"
    df_ideal = pd.read_csv(ideal_path, sep=';')
    ideal_dict = {int(r['BarNo']): r['SuperTrend'] for i,r in df_ideal.iterrows()}
    
    # Calculate Standard RMA(10) SuperTrend
    n = len(c)
    tr = np.zeros(n)
    tr[0] = h[0] - l[0]
    for i in range(1, n):
        tr[i] = max(h[i] - l[i], abs(h[i] - c[i-1]), abs(l[i] - c[i-1]))
        
    atr = np.zeros(n)
    alpha = 1.0 / 10
    atr[0] = tr[0]
    for i in range(1, n):
        atr[i] = tr[i] * alpha + atr[i-1] * (1.0 - alpha)
        
    mid = (h + l) / 2.0
    factor = 3.0
    up = mid + factor * atr
    dn = mid - factor * atr
    
    st = np.zeros(n); st[0] = up[0]
    t = np.zeros(n); t[0] = -1
    
    for i in range(1, n):
        if t[i-1] == 1:
            st[i] = max(dn[i], st[i-1])
            if c[i] < st[i]: 
                t[i] = -1
                st[i] = up[i]
            else:
                t[i] = 1
        else:
            st[i] = min(up[i], st[i-1])
            if c[i] > st[i]:
                t[i] = 1
                st[i] = dn[i]
            else:
                t[i] = -1
                
    # Look at the 498004 area
    target_bar = 498004
    start_b = target_bar - 20
    end_b = target_bar + 5
    
    print(f"{'BarNo':<8} {'Close':<8} {'ST_Py':<12} {'DirPy':<6} {'ST_Id':<12} {'DirId':<6}")
    print("-" * 60)
    for b in range(start_b, end_b):
        if b in ideal_dict:
            iv = ideal_dict[b]
            id_dir = 1 if c[b] > iv else -1
            print(f"{b:<8} {c[b]:<8.2f} {st[b]:<12.2f} {int(t[b]):<6} {iv:<12.2f} {id_dir:<6}")

if __name__ == "__main__":
    main()
