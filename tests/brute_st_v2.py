"""
SuperTrend Kalibrasyon v2 - Hata payını minimuma indirmek için:
1. EMA başlatma yöntemi: first value vs SMA seed
2. Hibrit ATR: SMA warmup + EMA/RMA trailing
3. Farklı alpha formülleri: 2/(n+1) vs 1/n
4. Close/HL shift varyasyonları
"""
import pandas as pd
import numpy as np

def calc_atr(h, l, c, period, method):
    """ATR hesaplaması - çeşitli yöntemlerle"""
    n = len(c)
    tr = np.zeros(n)
    tr[0] = h[0] - l[0]
    for i in range(1, n):
        tr[i] = max(h[i] - l[i], abs(h[i] - c[i-1]), abs(l[i] - c[i-1]))
    
    atr = np.zeros(n)
    
    if method == 'ema':
        # Standard EMA: alpha = 2/(n+1), seed = first value
        alpha = 2.0 / (period + 1.0)
        atr[0] = tr[0]
        for i in range(1, n):
            atr[i] = tr[i] * alpha + atr[i-1] * (1.0 - alpha)
            
    elif method == 'ema_sma_seed':
        # EMA with SMA seed
        alpha = 2.0 / (period + 1.0)
        sma_sum = 0.0
        for i in range(period):
            sma_sum += tr[i]
        atr[period-1] = sma_sum / period
        for i in range(period, n):
            atr[i] = tr[i] * alpha + atr[i-1] * (1.0 - alpha)
        # Fill early values
        for i in range(period-1):
            atr[i] = atr[period-1]
            
    elif method == 'rma':
        # Wilder's RMA: alpha = 1/n
        alpha = 1.0 / period
        atr[0] = tr[0]
        for i in range(1, n):
            atr[i] = tr[i] * alpha + atr[i-1] * (1.0 - alpha)
            
    elif method == 'rma_sma_seed':
        # Wilder's RMA with SMA seed
        alpha = 1.0 / period
        sma_sum = 0.0
        for i in range(period):
            sma_sum += tr[i]
        atr[period-1] = sma_sum / period
        for i in range(period, n):
            atr[i] = tr[i] * alpha + atr[i-1] * (1.0 - alpha)
        for i in range(period-1):
            atr[i] = atr[period-1]
            
    elif method == 'wilder_classic':
        # Classic Wilder: ATR[n] = (ATR[n-1] * (period-1) + TR[n]) / period
        sma_sum = 0.0
        for i in range(period):
            sma_sum += tr[i]
        atr[period-1] = sma_sum / period
        for i in range(period, n):
            atr[i] = (atr[i-1] * (period - 1) + tr[i]) / period
        for i in range(period-1):
            atr[i] = atr[period-1]
            
    return atr

def calc_supertrend(h, l, c, factor, atr, flip='close'):
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
            check = l[i] if flip == 'hl' else c[i]
            if check < st[i]:
                trend = -1; st[i] = up[i]
        else:
            st[i] = min(up[i], st[i-1])
            check = h[i] if flip == 'hl' else c[i]
            if check > st[i]:
                trend = 1; st[i] = dn[i]
    return st

def main():
    df = pd.read_csv(r"d:\Projects\IdealQuant\data\ideal_supertrend.csv", sep=';')
    h, l, c = df['High'].values.astype(float), df['Low'].values.astype(float), df['Close'].values.astype(float)
    ideal = df['SuperTrend'].values
    factor = 3.0
    
    atr_methods = ['ema', 'ema_sma_seed', 'rma', 'rma_sma_seed', 'wilder_classic']
    flip_types = ['close', 'hl']
    atr_periods = [10, 14]
    
    results = []
    for atr_p in atr_periods:
        for method in atr_methods:
            atr = calc_atr(h, l, c, atr_p, method)
            for flip in flip_types:
                st = calc_supertrend(h, l, c, factor, atr, flip)
                skip = 50
                diff = np.abs(ideal[skip:] - st[skip:])
                pct = (diff / ideal[skip:]).mean() * 100
                max_pct = (diff / ideal[skip:]).max() * 100
                results.append((pct, max_pct, atr_p, method, flip))
    
    results.sort()
    print("Top 15 varyasyon (düşükten yükseğe):\n")
    print(f"{'Sıra':<5} {'Ort%':<12} {'Max%':<12} {'ATR_P':<8} {'Yöntem':<18} {'Flip':<8}")
    print("-" * 65)
    for i, (pct, max_pct, atr_p, method, flip) in enumerate(results[:15]):
        print(f"{i+1:<5} {pct:.6f}%   {max_pct:.4f}%   {atr_p:<8} {method:<18} {flip:<8}")
    
    # Ayrıca en iyi sonuçla detay analizi yap
    best = results[0]
    print(f"\n\nEN İYİ SONUÇ: ATR_P={best[2]}, Method={best[3]}, Flip={best[4]}")
    atr = calc_atr(h, l, c, best[2], best[3])
    st = calc_supertrend(h, l, c, factor, atr, best[4])
    
    df['ST_Py'] = st
    df['Diff'] = df['SuperTrend'] - df['ST_Py']
    df['AbsDiff'] = df['Diff'].abs()
    
    print("\nİlk 5 bar karşılaştırma (ısınma sonrası):")
    print(df[['BarNo', 'Close', 'SuperTrend', 'ST_Py', 'Diff']].iloc[50:55].to_string(index=False))
    
    print("\nEn büyük 5 sapma:")
    top5 = df.nlargest(5, 'AbsDiff')
    print(top5[['BarNo', 'Close', 'SuperTrend', 'ST_Py', 'Diff']].to_string(index=False))

if __name__ == "__main__":
    main()
