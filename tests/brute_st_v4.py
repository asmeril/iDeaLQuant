"""
v4: Trend kırılım noktalarını analiz et.
Hem RMA(10) hem EMA(14) ile hesapla, ideal ile karşılaştır.
Kırılım anlarındaki davranışı incele.
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
    
    # Candidate 1: RMA(10)
    alpha1 = 1.0 / 10
    atr1 = np.zeros(n); atr1[0] = tr[0]
    for i in range(1, n):
        atr1[i] = tr[i] * alpha1 + atr1[i-1] * (1.0 - alpha1)
    
    # Candidate 2: EMA(14)
    alpha2 = 2.0 / 15
    atr2 = np.zeros(n); atr2[0] = tr[0]
    for i in range(1, n):
        atr2[i] = tr[i] * alpha2 + atr2[i-1] * (1.0 - alpha2)
    
    mid = (h + l) / 2.0
    
    # Calculate ST for both with trend tracking
    for label, atr in [('RMA10', atr1), ('EMA14', atr2)]:
        up = mid + factor * atr
        dn = mid - factor * atr
        st = np.zeros(n); st[0] = up[0]
        trend = np.zeros(n, dtype=int); trend[0] = -1
        t = -1
        for i in range(1, n):
            trend[i] = t
            if t == 1:
                st[i] = max(dn[i], st[i-1])
                if c[i] < st[i]: t = -1; st[i] = up[i]
            else:
                st[i] = min(up[i], st[i-1])
                if c[i] > st[i]: t = 1; st[i] = dn[i]
            trend[i] = t
        
        diff = np.abs(ideal[200:] - st[200:])
        pct = (diff / ideal[200:]).mean() * 100
        
        # Find trend flip points in ideal
        ideal_flips = []
        for i in range(201, n):
            if abs(ideal[i] - ideal[i-1]) > 20:  # Big jump = flip
                ideal_flips.append(i)
        
        # Check alignment at flips
        aligned = 0
        misaligned = 0
        for idx in ideal_flips:
            py_flip = abs(st[idx] - st[idx-1]) > 20
            if py_flip: aligned += 1
            else: misaligned += 1
        
        print(f"\n=== {label} (Ort: {pct:.6f}%) ===")
        print(f"Trend kırılımları: {len(ideal_flips)}")
        print(f"  Uyumlu: {aligned}, Uyumsuz: {misaligned}")
        
        # Show first few misaligned flips
        mis_count = 0
        for idx in ideal_flips:
            py_flip = abs(st[idx] - st[idx-1]) > 20
            if not py_flip and mis_count < 5:
                print(f"  Uyumsuz @ bar {idx}: Ideal={ideal[idx]:.2f} -> {ideal[idx-1]:.2f}, Py={st[idx]:.2f} -> {st[idx-1]:.2f}")
                mis_count += 1

if __name__ == "__main__":
    main()
