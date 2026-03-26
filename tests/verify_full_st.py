"""
SuperTrend Tam Veri-Seti (500 bin Bar) Kalibrasyonu.
İdealData'nın hesapladığı tüm veriyi Python'da aynı şekilde
baştan hesaplarız ve sadece son N barı (export edilen değerleri) 
kıyaslarız. Bu sayede "Warmup" kaynaklı farklar sıfıra iner.
"""
import pandas as pd
import numpy as np
from src.indicators.trend import get_supertrend
import sys

def calibrate_full_data():
    # 1. VIPX030T_1Dk_BarData.csv yükle
    bar_path = r"d:\Projects\IdealQuant\data\VIPX030T_1Dk_BarData.csv"
    print(f"[{bar_path}] yükleniyor...")
    
    # Encoding and separator might need care, usually ';'
    try:
        df_bars = pd.read_csv(bar_path, sep=';', encoding='utf-8')
    except UnicodeDecodeError:
        df_bars = pd.read_csv(bar_path, sep=';', encoding='iso-8859-9')
        
    print(f"Toplam {len(df_bars)} bar yüklendi.")
    
    # Sütun isimleri: Tarih;Saat;Açılış;Yüksek;Düşük;Kapanış...
    # Let's map dynamically
    cols = list(df_bars.columns)
    high_col = next((c for c in cols if 'ksek' in c or 'High' in c), None)
    low_col  = next((c for c in cols if 'k' in c or 'Low' in c), None)
    close_col= next((c for c in cols if 'pan' in c or 'Close' in c), None)
    
    h = df_bars[high_col].astype(str).str.replace(',', '.').astype(float).values
    l = df_bars[low_col].astype(str).str.replace(',', '.').astype(float).values
    c = df_bars[close_col].astype(str).str.replace(',', '.').astype(float).values
    
    # 2. Python tarafı tam veride hesaplasın
    factor = 3.0
    hhv_p = 10
    atr_p = 14
    print(f"Python SuperTrend ({factor}, {hhv_p}, {atr_p}) hesaplanıyor...")
    
    st_py, _, _ = get_supertrend(h.tolist(), l.tolist(), c.tolist(), hhv_p, atr_p, factor)
    
    # 3. İdealData Export Yükle (son 1000 bar)
    ideal_path = r"d:\Projects\IdealQuant\data\ideal_supertrend.csv"
    print(f"[{ideal_path}] İdealData sonuçları yükleniyor...")
    df_ideal = pd.read_csv(ideal_path, sep=';')
    print(f"İdealData'dan {len(df_ideal)} satır sonuç bulundu.")
    
    # df_ideal['BarNo'] corresponds to index in df_bars (hopefully 0-indexed matches)
    # df_ideal BarNo starts around 499000
    
    # 4. Kalibrasyon karşılaştırması
    diffs = []
    pct_diffs = []
    
    valid_count = 0
    total_diff = 0.0
    
    for i, row in df_ideal.iterrows():
        bar_no = int(row['BarNo'])
        if bar_no < len(st_py):
            py_val = st_py[bar_no]
            id_val = row['SuperTrend']
            d = abs(py_val - id_val)
            pct = (d / id_val) * 100
            diffs.append((bar_no, id_val, py_val, pct))
            total_diff += d
            pct_diffs.append(pct)
            valid_count += 1
            
    if valid_count == 0:
        print("Hata: BarNo eşleşmesi bulunamadı.")
        return
        
    avg_pct = np.mean(pct_diffs)
    max_pct = np.max(pct_diffs)
    
    print("\n================ KALİBRASYON SONUCU ================")
    print(f"Karşılaştırılan Bar Sayısı: {valid_count}")
    print(f"Ortalama Sapma Yüzdesi: %{avg_pct:.8f}")
    print(f"Maksimum Sapma Yüzdesi: %{max_pct:.8f}")
    
    # Let's say < 0.0001% is our absolute success metric
    if max_pct < 0.0001:
        print("\n✨ MÜKEMMEL EŞLEŞME: Hata payı teknik olarak sıfıra indi! ✨")
    else:
        print("\nUyarı: Hala ufak sapmalar var.")
        diffs.sort(key=lambda x: x[3], reverse=True)
        print("\nEn Büyük 5 Sapma:")
        print("BarNo \t Ideal \t\t Python \t PctError")
        for bar_no, id_val, py_val, pct in diffs[:5]:
            print(f"{bar_no} \t {id_val:.2f} \t {py_val:.2f} \t %{pct:.6f}")

if __name__ == "__main__":
    calibrate_full_data()
