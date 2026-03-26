"""
v9: 500 bin barlık veride index kaydırma analizleri.
1. İdealData'nın geçmiş bar verilerinde "High[i-1]", "Low[i]" vs kaydırması.
2. Formülde TrueRange hesabını yaparken C[i-1] yerine C[i] gibi varyasyonlar.
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
    h_c = next((c for c in cols if 'ksek' in c or 'High' in c), None)
    l_c  = next((c for c in cols if 'k' in c or 'Low' in c), None)
    c_c= next((c for c in cols if 'pan' in c or 'Close' in c), None)
    
    h = df_bars[h_c].astype(str).str.replace(',', '.').astype(float).values
    l = df_bars[l_c].astype(str).str.replace(',', '.').astype(float).values
    c = df_bars[c_c].astype(str).str.replace(',', '.').astype(float).values
    
    n = len(c)
    
    df_ideal = pd.read_csv(r"d:\Projects\IdealQuant\data\ideal_supertrend.csv", sep=';')
    first_target_idx = int(df_ideal.iloc[0]['BarNo'])
    
    factor = 3.0
    pd_val = 14
    
    # 1. Standart TR: max(H-L, abs(H-C[i-1]), abs(L-C[i-1]))
    # 2. TR Shift: max(H-L, abs(H-C[i]), abs(L-C[i])) (Some apps do this badly)
    
    for tr_type in ['standard', 'no_prev_close']:
        tr = np.zeros(n)
        tr[0] = h[0] - l[0]
        if tr_type == 'standard':
            for i in range(1, n):
                tr[i] = max(h[i] - l[i], abs(h[i] - c[i-1]), abs(l[i] - c[i-1]))
        else:
            for i in range(1, n):
                tr[i] = max(h[i] - l[i], abs(h[i] - c[i]), abs(l[i] - c[i]))
                
        for method in ['rma', 'ema']:
            atr = np.zeros(n)
            if method == 'rma':
                alpha = 1.0 / pd_val
            else:
                alpha = 2.0 / (pd_val + 1.0)
                
            atr[0] = tr[0]
            for i in range(1, n):
                atr[i] = tr[i] * alpha + atr[i-1] * (1.0 - alpha)
                
            # Mid types
            for mid_type in ['hl2', 'hlc3']:
                if mid_type == 'hl2':
                    mid = (h + l) / 2.0
                else:
                    mid = (h + l + c) / 3.0
                    
                for factor_val in [3.0, 3.01, 2.99]:
                    up = mid + factor_val * atr
                    dn = mid - factor_val * atr
                    st = np.zeros(n); st[0] = up[0]
                    t = -1
                    
                    for i in range(1, n):
                        if t == 1:
                            st[i] = max(dn[i], st[i-1])
                            if c[i] < st[i]: t = -1; st[i] = up[i]
                        else:
                            st[i] = min(up[i], st[i-1])
                            if c[i] > st[i]: t = 1; st[i] = dn[i]
                            
                    diffs = []
                    for j, row in df_ideal.iterrows():
                        idx = int(row['BarNo'])
                        if idx < n:
                            iv = row['SuperTrend']
                            if abs(iv) > 0:
                                diff = abs(st[idx] - iv) / iv * 100
                                diffs.append(diff)
                                
                    if diffs:
                        avg_diff = np.mean(diffs)
                        if avg_diff < 0.05:
                            print(f"TR={tr_type}, ATR={method}, MID={mid_type}, F={factor_val} -> Ort: %{avg_diff:.6f}, Max: %{np.max(diffs):.6f}")

if __name__ == "__main__":
    main()
