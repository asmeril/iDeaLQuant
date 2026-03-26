"""
v8: 500 bin barlık veride gerçek doğruluğu bulma.
- Numba ile yüzlerce varyasyonu tek seferde test edeceğiz.
- Orijinal VIPX030T_1Dk verisini kullanıyoruz.
- En azından bir formül %0.000 (ya da < %0.001) vermeli.
"""
import pandas as pd
import numpy as np
import time

def main():
    bar_path = r"d:\Projects\IdealQuant\data\VIPX030T_1Dk_BarData.csv"
    try:
        df_bars = pd.read_csv(bar_path, sep=';', encoding='utf-8')
    except:
        df_bars = pd.read_csv(bar_path, sep=';', encoding='iso-8859-9')
        
    cols = list(df_bars.columns)
    high_col = next((c for c in cols if 'ksek' in c or 'High' in c), None)
    low_col  = next((c for c in cols if 'k' in c or 'Low' in c), None)
    close_col= next((c for c in cols if 'pan' in c or 'Close' in c), None)
    
    # 500000 bars
    h = df_bars[high_col].astype(str).str.replace(',', '.').astype(float).values
    l = df_bars[low_col].astype(str).str.replace(',', '.').astype(float).values
    c = df_bars[close_col].astype(str).str.replace(',', '.').astype(float).values
    
    n = len(c)
    
    # Target (last 1000 bars)
    df_ideal = pd.read_csv(r"d:\Projects\IdealQuant\data\ideal_supertrend.csv", sep=';')
    ideal_values = df_ideal['SuperTrend'].values
    
    # Get the BarNo mapping (assume straight mapping for now, but let's confirm)
    # The first BarNo in export is likely around 499000
    first_target_idx = int(df_ideal.iloc[0]['BarNo'])
    print(f"Data size: {n}, First target idx: {first_target_idx}")
    if first_target_idx >= n:
        print("Uyumsuz index")
        return
        
    factor = 3.0
    
    # Pre-calc TR
    tr = np.zeros(n)
    tr[0] = h[0] - l[0]
    for i in range(1, n):
        tr[i] = max(h[i] - l[i], abs(h[i] - c[i-1]), abs(l[i] - c[i-1]))
    
    results = []
    
    for pd_val in [10, 14]:
        for method in ['rma', 'ema', 'rma_sma', 'ema_sma', 'wilder_classic']:
            # Calculate ATR
            atr = np.zeros(n)
            
            if method == 'rma':
                alpha = 1.0 / pd_val
                atr[0] = tr[0]
                for i in range(1, n):
                    atr[i] = tr[i] * alpha + atr[i-1] * (1.0 - alpha)
                    
            elif method == 'ema':
                alpha = 2.0 / (pd_val + 1.0)
                atr[0] = tr[0]
                for i in range(1, n):
                    atr[i] = tr[i] * alpha + atr[i-1] * (1.0 - alpha)
                    
            elif method == 'rma_sma':
                alpha = 1.0 / pd_val
                sma_sum = sum(tr[:pd_val])
                atr[pd_val-1] = sma_sum / pd_val
                for i in range(pd_val, n):
                    atr[i] = tr[i] * alpha + atr[i-1] * (1.0 - alpha)
                for i in range(pd_val-1): atr[i] = atr[pd_val-1]
                
            elif method == 'ema_sma':
                alpha = 2.0 / (pd_val + 1.0)
                sma_sum = sum(tr[:pd_val])
                atr[pd_val-1] = sma_sum / pd_val
                for i in range(pd_val, n):
                    atr[i] = tr[i] * alpha + atr[i-1] * (1.0 - alpha)
                for i in range(pd_val-1): atr[i] = atr[pd_val-1]
                
            elif method == 'wilder_classic':
                sma_sum = sum(tr[:pd_val])
                atr[pd_val-1] = sma_sum / pd_val
                for i in range(pd_val, n):
                    atr[i] = (atr[i-1] * (pd_val - 1) + tr[i]) / pd_val
                for i in range(pd_val-1): atr[i] = atr[pd_val-1]
            
            # Mid types
            for mid_type in ['hl2', 'c', 'hlc3']:
                if mid_type == 'hl2':
                    mid = (h + l) / 2.0
                elif mid_type == 'c':
                    mid = c
                else:
                    mid = (h + l + c) / 3.0
                    
                up = mid + factor * atr
                dn = mid - factor * atr
                st = np.zeros(n); st[0] = up[0]
                t = -1
                
                for i in range(1, n):
                    if t == 1:
                        st[i] = max(dn[i], st[i-1])
                        if c[i] < st[i]: t = -1; st[i] = up[i]
                    else:
                        st[i] = min(up[i], st[i-1])
                        if c[i] > st[i]: t = 1; st[i] = dn[i]
                        
                # Compare only with ideal targets
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
                    max_diff = np.max(diffs)
                    results.append((avg_diff, max_diff, pd_val, method, mid_type))
                    
    results.sort()
    print("\n--- 500 BIN BAR SONUÇLARI ---")
    for a, m, p, meth, mt in results[:10]:
        print(f"PD={p}, ATR={meth}, MID={mt} -> Ort: %{a:.8f}, Max: %{m:.6f}")

if __name__ == "__main__":
    main()
