"""
v6: 500 bin barlık tüm veri seti üzerinde SuperTrend doğrulama.
Kullanıcının belirttiği gibi `ideal_supertrend.csv` dosyası 500000 bar.
Eşleşmeyi baştan sona kontrol edip gerçek hatayı tespit edeceğiz.
"""
import pandas as pd
import numpy as np
from src.indicators.trend import get_supertrend

def main():
    print("500.000 barlık veri yükleniyor...")
    df = pd.read_csv(r"d:\Projects\IdealQuant\data\ideal_supertrend.csv", sep=';')
    
    n = len(df)
    print(f"Toplam bar sayısı: {n}")
    
    h = df['High'].tolist()
    l = df['Low'].tolist()
    c = df['Close'].tolist()
    ideal = df['SuperTrend'].values
    
    # Parametreler (kullanıcının onayladığı)
    factor = 3.0
    hhv_p = 10 # This is used as atr_p in the python implementation
    atr_p = 14 # Ignored
    
    print("Python SuperTrend hesaplanıyor...")
    st_py, up, dn = get_supertrend(h, l, c, hhv_p, atr_p, factor)
    
    # 500 bin bar - ilk 200 barı warmup olarak yine de geçiyoruz 
    # (İdealData kendi içinde muhtemelen data'nın en başından hesaplamıştır)
    skip = min(200, n//2) 
    
    diff = np.abs(ideal[skip:] - st_py[skip:])
    pct_mean = (diff / ideal[skip:]).mean() * 100
    pct_max = (diff / ideal[skip:]).max() * 100
    abs_mean = diff.mean()
    
    print("\n=== KALİBRASYON SONUÇLARI (TÜM VERİ) ===")
    print(f"Ortalama Yüzde Fark: %{pct_mean:.6f}")
    print(f"Maksimum Yüzde Fark: %{pct_max:.6f}")
    print(f"Ortalama Mutlak Puan Farkı: {abs_mean:.4f}")
    
    # Hata analizi
    if pct_max > 0.05:
        print("\nUYARI: Beklenenden büyük farklar bulundu!")
        df['ST_Py'] = st_py
        df['Diff'] = df['SuperTrend'] - df['ST_Py']
        df['Pct'] = (df['Diff'].abs() / df['SuperTrend']) * 100
        
        comp_df = df.iloc[skip:]
        worst = comp_df.sort_values('Pct', ascending=False).head(10)
        print("\nEn Büyük 10 Sapma:")
        print(worst[['BarNo', 'Close', 'SuperTrend', 'ST_Py', 'Diff', 'Pct']])

if __name__ == "__main__":
    main()
