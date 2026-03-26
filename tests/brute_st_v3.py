"""
v3: İlk 100 barı tamamen hariç tutarak warmup etkisini izole et.
İki en iyi adayı derinlemesine karşılaştır.
Ayrıca: EMA alpha nüansları, SMA warmup uzunluğu (period vs 2*period) dene.
"""
import pandas as pd
import numpy as np

def calc_atr_variants(h, l, c, period):
    """Tüm ATR varyasyonlarını tek seferde hesapla"""
    n = len(c)
    tr = np.zeros(n)
    tr[0] = h[0] - l[0]
    for i in range(1, n):
        tr[i] = max(h[i] - l[i], abs(h[i] - c[i-1]), abs(l[i] - c[i-1]))
    
    variants = {}
    
    # 1. Standard EMA (seed = first TR, alpha = 2/(p+1))
    alpha_ema = 2.0 / (period + 1.0)
    atr = np.zeros(n); atr[0] = tr[0]
    for i in range(1, n):
        atr[i] = tr[i] * alpha_ema + atr[i-1] * (1.0 - alpha_ema)
    variants['ema_std'] = atr.copy()
    
    # 2. EMA with SMA seed
    atr = np.zeros(n)
    sma_sum = sum(tr[:period])
    atr[period-1] = sma_sum / period
    for i in range(period, n):
        atr[i] = tr[i] * alpha_ema + atr[i-1] * (1.0 - alpha_ema)
    for i in range(period-1): atr[i] = atr[period-1]
    variants['ema_sma'] = atr.copy()
    
    # 3. RMA (Wilder's, alpha = 1/p, seed = first TR)
    alpha_rma = 1.0 / period
    atr = np.zeros(n); atr[0] = tr[0]
    for i in range(1, n):
        atr[i] = tr[i] * alpha_rma + atr[i-1] * (1.0 - alpha_rma)
    variants['rma_std'] = atr.copy()
    
    # 4. RMA with SMA seed
    atr = np.zeros(n)
    atr[period-1] = sma_sum / period
    for i in range(period, n):
        atr[i] = tr[i] * alpha_rma + atr[i-1] * (1.0 - alpha_rma)
    for i in range(period-1): atr[i] = atr[period-1]
    variants['rma_sma'] = atr.copy()
    
    # 5. Wilder Classic: (prev * (p-1) + tr) / p  (mathematically same as rma_sma)
    atr = np.zeros(n)
    atr[period-1] = sma_sum / period
    for i in range(period, n):
        atr[i] = (atr[i-1] * (period - 1) + tr[i]) / period
    for i in range(period-1): atr[i] = atr[period-1]
    variants['wilder'] = atr.copy()
    
    # 6. EMA2 (alpha = 1/(p+1) - less common variant)
    alpha2 = 1.0 / (period + 1.0)
    atr = np.zeros(n); atr[0] = tr[0]
    for i in range(1, n):
        atr[i] = tr[i] * alpha2 + atr[i-1] * (1.0 - alpha2)
    variants['ema_alt'] = atr.copy()
    
    # 7. DEMA of TR (Double EMA)
    ema1 = np.zeros(n); ema1[0] = tr[0]
    for i in range(1, n):
        ema1[i] = tr[i] * alpha_ema + ema1[i-1] * (1.0 - alpha_ema)
    ema2 = np.zeros(n); ema2[0] = ema1[0]
    for i in range(1, n):
        ema2[i] = ema1[i] * alpha_ema + ema2[i-1] * (1.0 - alpha_ema)
    variants['dema_tr'] = (2 * ema1 - ema2)
    
    return variants

def calc_st(h, l, c, factor, atr):
    n = len(c)
    mid = (np.array(h) + np.array(l)) / 2.0
    up = mid + factor * atr
    dn = mid - factor * atr
    st = np.zeros(n)
    st[0] = up[0]
    trend = -1
    for i in range(1, n):
        if trend == 1:
            st[i] = max(dn[i], st[i-1])
            if c[i] < st[i]:
                trend = -1; st[i] = up[i]
        else:
            st[i] = min(up[i], st[i-1])
            if c[i] > st[i]:
                trend = 1; st[i] = dn[i]
    return st

def main():
    df = pd.read_csv(r"d:\Projects\IdealQuant\data\ideal_supertrend.csv", sep=';')
    h, l, c = df['High'].values.astype(float), df['Low'].values.astype(float), df['Close'].values.astype(float)
    ideal = df['SuperTrend'].values
    factor = 3.0
    
    # Skip first 200 bars to remove warmup completely
    skip = 200
    
    results = []
    for period in [10, 14]:
        atrs = calc_atr_variants(h, l, c, period)
        for name, atr in atrs.items():
            st = calc_st(h, l, c, factor, atr)
            diff = np.abs(ideal[skip:] - st[skip:])
            pct_mean = (diff / ideal[skip:]).mean() * 100
            pct_max = (diff / ideal[skip:]).max() * 100
            abs_mean = diff.mean()
            results.append((pct_mean, pct_max, abs_mean, period, name))
    
    results.sort()
    print(f"İlk 200 bar atlanmış (warmup izole edildi):\n")
    print(f"{'#':<4} {'Ort%':<12} {'Max%':<10} {'OrtPuan':<10} {'P':<4} {'Yöntem'}")
    print("-" * 55)
    for i, (pct, mx, ap, p, nm) in enumerate(results[:12]):
        marker = " <<<" if i == 0 else ""
        print(f"{i+1:<4} {pct:.6f}%  {mx:.4f}%  {ap:.4f}     {p:<4} {nm}{marker}")

if __name__ == "__main__":
    main()
