"""
Check if prices match exactly between the raw bar data and ideal_supertrend export.
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
    c_c = next((c for c in cols if 'pan' in c or 'Close' in c), None)
    c_bars = df_bars[c_c].astype(str).str.replace(',', '.').astype(float).values
    
    ideal_path = r"d:\Projects\IdealQuant\data\ideal_supertrend.csv"
    df_ideal = pd.read_csv(ideal_path, sep=';')
    
    mismatches = 0
    for i, row in df_ideal.head(10).iterrows():
        b = int(row['BarNo'])
        ideal_c = row['Close']
        if b < len(c_bars):
            bar_c = c_bars[b]
            if abs(ideal_c - bar_c) > 0.01:
                print(f"Mismatch at Bar {b}! Ideal: {ideal_c}, Raw: {bar_c}")
                mismatches += 1
                
    if mismatches == 0:
        print("İlk 10 barda fiyatlar EŞLEŞİYOR.")
        
    mismatches = 0
    for i, row in df_ideal.tail(10).iterrows():
        b = int(row['BarNo'])
        ideal_c = row['Close']
        if b < len(c_bars):
            bar_c = c_bars[b]
            if abs(ideal_c - bar_c) > 0.01:
                print(f"Mismatch at Bar {b}! Ideal: {ideal_c}, Raw: {bar_c}")
                mismatches += 1
                
    if mismatches == 0:
        print("Son 10 barda fiyatlar EŞLEŞİYOR.")

if __name__ == "__main__":
    main()
