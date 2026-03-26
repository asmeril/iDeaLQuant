"""
Compare the underlying raw High/Low/Close between VIPX030T and ideal_supertrend.
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
    
    # Check around 498004
    print("Checking Bar 498004...")
    for idx in range(498000, 498010):
        if idx < len(c_bars):
            ideal_row = df_ideal[df_ideal['BarNo'] == idx]
            if not ideal_row.empty:
                ideal_c = ideal_row.iloc[0]['Close']
                ideal_st = ideal_row.iloc[0]['SuperTrend']
                raw_c = c_bars[idx]
                print(f"Bar {idx} | Raw Close: {raw_c} | Ideal Close: {ideal_c} | Ideal ST: {ideal_st}")

if __name__ == "__main__":
    main()
