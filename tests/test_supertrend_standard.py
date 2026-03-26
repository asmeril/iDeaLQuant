"""
Klasik (Standart) SuperTrend algoritmasının testi.
Kullanıcının paylaştığı Pandas-TA uyumlu mantık:
- Median = (H+L)/2
- BasicUp = Median + factor * ATR(10)
- BasicDn = Median - factor * ATR(10)
- FinalUp[i] = BasicUp[i] if BasicUp[i] < FinalUp[i-1] or C[i-1] > FinalUp[i-1] else FinalUp[i-1]
- FinalDn[i] = BasicDn[i] if BasicDn[i] > FinalDn[i-1] or C[i-1] < FinalDn[i-1] else FinalDn[i-1]
- ST[i] = FinalDn[i] if trend=1 else FinalUp[i]
"""
import pandas as pd
import numpy as np
import time

def calc_supertrend_standard(h, l, c, atr_p, multiplier):
    n = len(c)
    tr = np.zeros(n)
    tr[0] = h[0] - l[0]
    for i in range(1, n):
        tr[i] = max(h[i] - l[i], abs(h[i] - c[i-1]), abs(l[i] - c[i-1]))
        
    atr = np.zeros(n)
    
    # User's tip mentions pandas_ta defaults, which uses Wilder's RMA for ATR.
    alpha = 1.0 / atr_p
    atr[0] = tr[0]
    for i in range(1, n):
        atr[i] = tr[i] * alpha + atr[i-1] * (1.0 - alpha)
        
    mid = (h + l) / 2.0
    basic_up = mid + multiplier * atr
    basic_dn = mid - multiplier * atr
    
    final_up = np.zeros(n)
    final_dn = np.zeros(n)
    st = np.zeros(n)
    
    final_up[0] = basic_up[0]
    final_dn[0] = basic_dn[0]
    
    trend = 1
    st[0] = final_up[0]
    
    for i in range(1, n):
        # Final Upperband
        if basic_up[i] < final_up[i-1] or c[i-1] > final_up[i-1]:
            final_up[i] = basic_up[i]
        else:
            final_up[i] = final_up[i-1]
            
        # Final Lowerband
        if basic_dn[i] > final_dn[i-1] or c[i-1] < final_dn[i-1]:
            final_dn[i] = basic_dn[i]
        else:
            final_dn[i] = final_dn[i-1]
            
        # Trend and Supertrend value
        # Trend changes based on close vs previous ST (or final bands)
        if st[i-1] == final_up[i-1]: # Was in downtrend
            if c[i] > final_up[i]:
                trend = 1
            else:
                trend = -1
        else: # Was in uptrend
            if c[i] < final_dn[i]:
                trend = -1
            else:
                trend = 1
                
        if trend == 1:
            st[i] = final_dn[i]
        else:
            st[i] = final_up[i]
            
    return st

def main():
    bar_path = r"d:\Projects\IdealQuant\data\VIPX030T_1Dk_BarData.csv"
    
    try:
        df_bars = pd.read_csv(bar_path, sep=';', encoding='utf-8')
    except:
        df_bars = pd.read_csv(bar_path, sep=';', encoding='iso-8859-9')
        
    cols = list(df_bars.columns)
    h_c = next((c for c in cols if 'ksek' in c or 'High' in c), None)
    l_c = next((c for c in cols if 'k' in c or 'Low' in c), None)
    c_c = next((c for c in cols if 'pan' in c or 'Close' in c), None)
    
    h = df_bars[h_c].astype(str).str.replace(',', '.').astype(float).values
    l = df_bars[l_c].astype(str).str.replace(',', '.').astype(float).values
    c = df_bars[c_c].astype(str).str.replace(',', '.').astype(float).values
    
    print("Python SuperTrend (Standard Algo) hesaplanıyor...")
    
    st_py_10 = calc_supertrend_standard(h, l, c, 10, 3.0)
    st_py_14 = calc_supertrend_standard(h, l, c, 14, 3.0)
    
    ideal_path = r"d:\Projects\IdealQuant\data\ideal_supertrend.csv"
    df_ideal = pd.read_csv(ideal_path, sep=';')
    
    for label, st_py in [("P=10", st_py_10), ("P=14", st_py_14)]:
        diffs = []
        valid = 0
        for j, row in df_ideal.iterrows():
            idx = int(row['BarNo'])
            if idx < len(c):
                iv = row['SuperTrend']
                if abs(iv) > 0:
                    diff = abs(st_py[idx] - iv) / iv * 100
                    diffs.append(diff)
                    valid += 1
                    
        if diffs:
            avg_diff = np.mean(diffs)
            max_diff = np.max(diffs)
            print(f"{label} -> Ort: %{avg_diff:.8f}, Max: %{max_diff:.6f}")

if __name__ == "__main__":
    main()
