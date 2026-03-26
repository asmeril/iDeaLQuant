"""
Check error distribution in 500k bars to understand if it's just warmup decay or persistent.
"""
import pandas as pd
import numpy as np
from src.indicators.trend import get_supertrend

def main():
    bar_path = r"d:\Projects\IdealQuant\data\VIPX030T_1Dk_BarData.csv"
    try:
        df_bars = pd.read_csv(bar_path, sep=';', encoding='utf-8')
    except:
        df_bars = pd.read_csv(bar_path, sep=';', encoding='iso-8859-9')
        
    cols = list(df_bars.columns)
    h_c = next((c for c in cols if 'ksek' in c or 'High' in c), None)
    l_c = next((c for c in cols if 'k' in c or 'Low' in c), None)
    c_c = next((c for c in cols if 'pan' in c or 'Close' in c), None)
    
    h = df_bars[h_c].astype(str).str.replace(',', '.').astype(float).values
    l = df_bars[l_c].astype(str).str.replace(',', '.').astype(float).values
    c = df_bars[c_c].astype(str).str.replace(',', '.').astype(float).values
    
    # Python calc with RMA(10) since that was the best
    st_py, _, _ = get_supertrend(h.tolist(), l.tolist(), c.tolist(), 10, 14, 3.0)
    
    ideal_path = r"d:\Projects\IdealQuant\data\ideal_supertrend.csv"
    df_ideal = pd.read_csv(ideal_path, sep=';')
    
    # Store errors by bar_no
    errors = []
    
    for i, row in df_ideal.iterrows():
        b = int(row['BarNo'])
        if b < len(st_py):
            pv = st_py[b]
            iv = row['SuperTrend']
            pct = abs(pv - iv) / iv * 100
            diff = pv - iv
            errors.append({'BarNo': b, 'Ideal': iv, 'Py': pv, 'Diff': diff, 'Pct': pct, 'Close': c[b]})
            
    err_df = pd.DataFrame(errors)
    
    print("--- HATA DAĞILIMI (RMA 10) ---")
    print(f"İlk 100 bar (100-200) ortalama hata: %{err_df[(err_df['BarNo'] >= 100) & (err_df['BarNo'] < 200)]['Pct'].mean():.6f}")
    print(f"Orta 100K bar (200K-300K) ortalama hata: %{err_df[(err_df['BarNo'] >= 200000) & (err_df['BarNo'] < 300000)]['Pct'].mean():.6f}")
    print(f"Son 1000 bar (499K-500K) ortalama hata: %{err_df[err_df['BarNo'] >= 499000]['Pct'].mean():.6f}")
    
    print("\nEn Büyük 5 Sapma:")
    print(err_df.sort_values('Pct', ascending=False).head(5).to_string())

if __name__ == "__main__":
    main()
