import pandas as pd
import numpy as np

def analyze_gaps(file_path):
    # Veriyi oku (Ayraç: ;, Ondalık: ,)
    try:
        df = pd.read_csv(file_path, sep=';', decimal=',', dtype={'Tarih': str, 'Saat': str})
    except Exception as e:
        return f"Veri okuma hatası: {e}"

    # Tarih ve Saat sütunlarını birleştirip tek bir datetime objesi yapalım
    df['datetime'] = pd.to_datetime(df['Tarih'] + ' ' + df['Saat'], dayfirst=True)
    df = df.sort_values('datetime').reset_index(drop=True)

    # Günlük gruplama yaparak her günün son barı ile ertesi günün ilk barını eşleştirelim
    df['date'] = df['datetime'].dt.date
    dates = sorted(df['date'].unique())
    
    gaps = []
    
    for i in range(len(dates) - 1):
        current_date = dates[i]
        next_date = dates[i+1]
        
        # Bugünün son barı (akşam seansı kapanışı civarı)
        today_bars = df[df['date'] == current_date]
        if today_bars.empty: continue
        last_bar_today = today_bars.iloc[-1]
        
        # Yarının ilk barı (sabah açılışı civarı)
        tomorrow_bars = df[df['date'] == next_date]
        if tomorrow_bars.empty: continue
        first_bar_tomorrow = tomorrow_bars.iloc[0]
        
        # İki bar arasındaki zaman farkını kontrol edelim (Gece boyu süren gap)
        time_diff = first_bar_tomorrow['datetime'] - last_bar_today['datetime']
        
        # 6 saat ile 15 saat arası bir fark varsa bu bir gece gap'idir.
        # (Kullanıcı: 22:59 -> 09:25 yaklaşık 10.5 saat, yani kriterimize uygun)
        if 6 * 3600 < time_diff.total_seconds() < 15 * 3600:
            gap_size = first_bar_tomorrow['Açılış'] - last_bar_today['Kapanış']
            gap_pct = (gap_size / last_bar_today['Kapanış']) * 100
            
            gaps.append({
                'Gap_Tarihi': next_date.strftime('%Y-%m-%d'),
                'Akşam_Kapanis': last_bar_today['Kapanış'],
                'Sabah_Acilis': first_bar_tomorrow['Açılış'],
                'Gap_Boyutu_Puan': gap_size,
                'Gap_Yuzde': gap_pct,
                'Yon': 'Yukari' if gap_size > 0 else 'Asagi'
            })

    if not gaps:
        return "Uygun gap (gece boyu süren) bulunamadı. Filtreleri kontrol edin."

    gap_df = pd.DataFrame(gaps)
    
    summary = {
        'Toplam_Gap_Sayisi': len(gap_df),

        'Ortalama_Gap_Yuzde': gap_df['Gap_Yuzde'].mean(),
        'Yukari_Gap_Sayisi': len(gap_df[gap_df['Yon'] == 'Yukari']),
        'Asagi_Gap_Sayisi': len(gap_df[gap_df['Yon'] == 'Asagi'])
    }
    
    return gap_df, summary

if __name__ == "__main__":
    # Dosya yolunu kullanıcının belirttiği veya mevcut yapıdaki yola göre güncellemelisiniz.
    # Burayı test için mevcut dosya yapısına uygun hale getirdim.
    path = r"D:\Projects\IdealQuant\data\VIPX030T_1Dk_BarData.csv" 
    # Not: Eğer dosya yolu farklıysa lütfen burayı güncelleyin.
    
    import os
    # Dosyanın varlığını kontrol et, yoksa hata verme, kullanıcıyı bilgilendir.
    if not os.path.exists(path):
        # Alternatife bak (Dosya listesinden gördüğüm bir yol varsa)
        alt_path = r"D:\Projects\IdealQuant\export\VIP_X030-T_1DK_DeepScalp.cs" # Örnek
        print(f"Hata: {path} bulunamadı.")
    else:
        result = analyze_gaps(path)
        
        if isinstance(result, str):
            print(result)
        else:
            df_gaps, summary = result
            print("--- GAP ANALIZ OZETI ---")
            for k, v in summary.items():
                print(f"{k}: {v}")
            print("\n--- SON 5 GAP ---")
            print(df_gaps.tail(5).to_string())
