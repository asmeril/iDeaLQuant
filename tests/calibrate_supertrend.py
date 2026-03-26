import os
import pandas as pd
import numpy as np
from src.indicators.trend import get_supertrend

def calibrate():
    # 1. Load Updated Verification Data
    data_path = r"d:\Projects\IdealQuant\data\ideal_supertrend.csv"
    if not os.path.exists(data_path):
        print(f"Hata: {data_path} bulunamadı!")
        return

    df = pd.read_csv(data_path, sep=';')
    print(f"Veri yüklendi: {len(df)} bar (OHLC + ST).")

    # 2. Extract Columns
    highs = df['High'].tolist()
    lows = df['Low'].tolist()
    closes = df['Close'].tolist()
    ideal_st = df['SuperTrend'].tolist()

    # 3. Calculate Python SuperTrend
    # Params from DeepScalp
    factor = 3.0
    hhv_p = 10
    atr_p = 14
    
    print("Python SuperTrend hesaplanıyor...")
    st_py, _, _ = get_supertrend(highs, lows, closes, hhv_p, atr_p, factor)
    
    # 4. Compare
    df['ST_Py'] = st_py
    df['Diff'] = abs(df['SuperTrend'] - df['ST_Py'])
    df['PctDiff'] = (df['Diff'] / df['SuperTrend']) * 100
    
    # SuperTrend might take a few bars to align trailing state
    # We skip first 50 bars for stable comparison
    comp_df = df.iloc[50:]
    
    max_diff = comp_df['PctDiff'].max()
    avg_diff = comp_df['PctDiff'].mean()
    
    print(f"\nKalibrasyon Sonuçları (İlk 50 bar atlanmıştır):")
    print(f"Maksimum Fark: %{max_diff:.6f}")
    print(f"Ortalama Fark: %{avg_diff:.6f}")
    
    if max_diff < 0.001: # 0.001% tolerance (due to float precision in export)
        print("\nBAŞARILI: Python implementasyonu İdealData ile tam uyumlu!")
    else:
        print("\nUYARI: Farklar tespit edildi. Algoritma incelemesi gerekebilir.")
        print("\nEn büyük farklar:")
        print(comp_df.sort_values('PctDiff', ascending=False).head(10)[['BarNo', 'Close', 'SuperTrend', 'ST_Py', 'Diff', 'PctDiff']])

if __name__ == "__main__":
    calibrate()
