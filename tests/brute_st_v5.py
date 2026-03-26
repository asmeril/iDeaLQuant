"""
v5: Son 500, 300, 100 bar dilimlerinde hata payını ölç.
Warmup'ın etkisinin azaldığı bölgelerde ne kadar doğruyuz?
"""
import pandas as pd
import numpy as np

def main():
    df = pd.read_csv(r"d:\Projects\IdealQuant\data\ideal_supertrend.csv", sep=';')
    h, l, c = df['High'].values.astype(float), df['Low'].values.astype(float), df['Close'].values.astype(float)
    ideal = df['SuperTrend'].values
    factor = 3.0
    n = len(c)
    
    tr = np.zeros(n)
    tr[0] = h[0] - l[0]
    for i in range(1, n):
        tr[i] = max(h[i] - l[i], abs(h[i] - c[i-1]), abs(l[i] - c[i-1]))
    
    # RMA(10)
    alpha = 1.0 / 10
    atr_rma = np.zeros(n); atr_rma[0] = tr[0]
    for i in range(1, n):
        atr_rma[i] = tr[i] * alpha + atr_rma[i-1] * (1.0 - alpha)
    
    # EMA(14)
    alpha2 = 2.0 / 15
    atr_ema = np.zeros(n); atr_ema[0] = tr[0]
    for i in range(1, n):
        atr_ema[i] = tr[i] * alpha2 + atr_ema[i-1] * (1.0 - alpha2)
    
    mid = (h + l) / 2.0
    
    for label, atr in [('RMA10', atr_rma), ('EMA14', atr_ema)]:
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
        
        print(f"\n=== {label} ===")
        for skip in [50, 100, 200, 300, 500, 700, 800, 900]:
            if skip >= n: continue
            diff = np.abs(ideal[skip:] - st[skip:])
            pct = (diff / ideal[skip:]).mean() * 100
            max_pct = (diff / ideal[skip:]).max() * 100
            abs_mean = diff.mean()
            print(f"  Son {n-skip:4d} bar: Ort={pct:.6f}%  Max={max_pct:.4f}%  OrtPuan={abs_mean:.4f}")

if __name__ == "__main__":
    main()
