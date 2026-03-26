"""
v7: 500 bin Barlık Gerçek Kalibrasyon (RMA(10) vs Diğerleri)
"""
import pandas as pd
import numpy as np
from src.indicators.trend import get_supertrend

def calibrate_full_data():
    bar_path = r"d:\Projects\IdealQuant\data\VIPX030T_1Dk_BarData.csv"
    print(f"[{bar_path}] yükleniyor...")
    
    try:
        df_bars = pd.read_csv(bar_path, sep=';', encoding='utf-8')
    except UnicodeDecodeError:
        df_bars = pd.read_csv(bar_path, sep=';', encoding='iso-8859-9')
        
    cols = list(df_bars.columns)
    high_col = next((c for c in cols if 'ksek' in c or 'High' in c), None)
    low_col  = next((c for c in cols if 'k' in c or 'Low' in c), None)
    close_col= next((c for c in cols if 'pan' in c or 'Close' in c), None)
    
    h = df_bars[high_col].astype(str).str.replace(',', '.').astype(float).values
    l = df_bars[low_col].astype(str).str.replace(',', '.').astype(float).values
    c = df_bars[close_col].astype(str).str.replace(',', '.').astype(float).values
    
    # İdealData Export Yükle
    ideal_path = r"d:\Projects\IdealQuant\data\ideal_supertrend.csv"
    df_ideal = pd.read_csv(ideal_path, sep=';')
    
    results = []
    
    # Hangi parametrenin (10 veya 14) ATR periyodu olduğunu doğrulamak için ikisini de dene
    for h_p in [10, 14]:
        for a_p in [10, 14]:
            print(f"Test -> HHV_P={h_p}, ATR_P={a_p}")
            st_py, _, _ = get_supertrend(h.tolist(), l.tolist(), c.tolist(), h_p, a_p, 3.0)
            
            diff_sum = 0
            valid = 0
            pct_list = []
            
            for i, row in df_ideal.iterrows():
                bar_no = int(row['BarNo'])
                if bar_no < len(st_py):
                    pv = st_py[bar_no]
                    iv = row['SuperTrend']
                    pct = (abs(pv - iv) / iv) * 100
                    pct_list.append(pct)
                    valid += 1
                    
            if valid > 0:
                avg = np.mean(pct_list)
                mx = np.max(pct_list)
                results.append((avg, mx, h_p, a_p))

    results.sort()
    print("\n--- SON NOKTA 500 BIN BAR SONUÇLARI ---")
    for avg, mx, hp, ap in results:
        print(f"HHV_P={hp}, ATR_P={ap} -> Ort: %{avg:.8f}, Max: %{mx:.6f}")
        
if __name__ == "__main__":
    calibrate_full_data()
