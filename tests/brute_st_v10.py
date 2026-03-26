"""
v10: Bar No yerine Tarih-Saat eşleştirmesi ile 500 bin barlık kontrol.
Eğer veride eksik/fazla barlar varsa veya başlama indexi bizim beklediğimiz gibi '499000' değilse
hesaplama kayacaktır. Datetime eşleştirmesi ile doğrulayalım.
"""
import pandas as pd
import numpy as np
from src.indicators.trend import get_supertrend

def main():
    print("Veriler yükleniyor...")
    bar_path = r"d:\Projects\IdealQuant\data\VIPX030T_1Dk_BarData.csv"
    
    try:
        df_bars = pd.read_csv(bar_path, sep=';', encoding='utf-8')
    except:
        df_bars = pd.read_csv(bar_path, sep=';', encoding='iso-8859-9')
        
    cols = list(df_bars.columns)
    
    # Generate a Datetime key for bars
    df_bars['DT_Key'] = df_bars[cols[0]].astype(str) + " " + df_bars[cols[1]].astype(str)
    
    # 500000 vars
    high_col = next((c for c in cols if 'ksek' in c or 'High' in c), None)
    low_col  = next((c for c in cols if 'k' in c or 'Low' in c), None)
    close_col= next((c for c in cols if 'pan' in c or 'Close' in c), None)
    
    h = df_bars[high_col].astype(str).str.replace(',', '.').astype(float).values
    l = df_bars[low_col].astype(str).str.replace(',', '.').astype(float).values
    c = df_bars[close_col].astype(str).str.replace(',', '.').astype(float).values
    
    # Calculate Python SuperTrend with the best parameters we know
    factor = 3.0
    hhv_p = 10
    atr_p = 14
    
    st_py, _, _ = get_supertrend(h.tolist(), l.tolist(), c.tolist(), hhv_p, atr_p, factor)
    df_bars['ST_Py'] = st_py
    
    # Load IdealExport
    # Note: the user's export script didn't include datetime!
    # "sb.AppendLine("BarNo;High;Low;Close;SuperTrend");"
    # But it HAS High, Low, Close. We can match by sequence!
    
    df_ideal = pd.read_csv(r"d:\Projects\IdealQuant\data\ideal_supertrend.csv", sep=';')
    
    # Find the EXACT sequence in df_bars that matches df_ideal's High, Low, Close
    print(f"İdealData'dan {len(df_ideal)} satır sonuç bulundu.")
    
    ideal_h = df_ideal['High'].values
    ideal_l = df_ideal['Low'].values
    ideal_c = df_ideal['Close'].values
    ideal_st = df_ideal['SuperTrend'].values
    
    seq_len = 10  # Match a sequence of 10 to find exact index
    search_h = ideal_h[:seq_len]
    search_l = ideal_l[:seq_len]
    search_c = ideal_c[:seq_len]
    
    matched_idx = -1
    for i in range(len(df_bars) - seq_len):
        if (np.allclose(h[i:i+seq_len], search_h, atol=0.01) and 
            np.allclose(l[i:i+seq_len], search_l, atol=0.01) and 
            np.allclose(c[i:i+seq_len], search_c, atol=0.01)):
            matched_idx = i
            break
            
    if matched_idx == -1:
        print("HATA: İdealData export dosyasındaki fiyat serisi ana veride BULUNAMADI!")
        return
        
    print(f"EŞLEŞME BULUNDU! İdealData Bar 0 == Python Bar {matched_idx}")
    
    # Let's verify the first target index. Was it exactly what we assumed?
    expected_start = int(df_ideal.iloc[0]['BarNo'])
    print(f"Export Bar No: {expected_start}, Gerçek Index: {matched_idx}")
    
    if expected_start != matched_idx:
        print(">>> İndeks Oynaması Tespit Edildi! (BarNo vs Array Index farkı var) <<<")
    
    # Now compare exactly offset-matched ST values
    diffs = []
    
    for i in range(len(df_ideal)):
        py_idx = matched_idx + i
        if py_idx < len(st_py):
            pv = st_py[py_idx]
            iv = ideal_st[i]
            pct = abs(pv - iv) / iv * 100
            diffs.append(pct)
            
    avg_diff = np.mean(diffs)
    max_diff = np.max(diffs)
    
    print("\n--- ZAMAN EŞLEŞTİRMELİ DOĞRULAMA ---")
    print(f"Ortalama % Fark: {avg_diff:.8f}")
    print(f"Maksimum % Fark: {max_diff:.8f}")
    
    if max_diff < 0.0001:
        print("✨ BAŞARILI: İndeks kayması düzeltilince sıfır hata sağlandı!")
    else:
        print("Hata hala sıfır değil, formülde de ince farklar var.")

if __name__ == "__main__":
    main()
