import pandas as pd
import numpy as np
import os

# Minimum gap büyüklüğü eşiği (gürültüyü eler)
MIN_GAP_PCT = 0.02

def create_labeled_dataset(input_path, output_path):
    """
    Gap verilerini okur ve GÜN İÇİ KAPANMA mantığıyla etiketler.
    
    Label=0: Gap gün içinde kapandı (Reversal / Gap Fill)
    Label=1: Gap gün sonuna kadar kapanmadı (Trend Devam)

    Özellikler (Feature Engineering):
    - Gap_Yuzde          : Gap büyüklüğü (%)
    - Gap_Yon_Binary     : 1=Yukari, 0=Asagi
    - Volatility_Std     : Gap öncesi 20 bar kapanış std'si
    - Volume_Change      : Gap açılış barındaki hacim değişimi (%)
    - Gun_Sira           : Haftanın günü (0=Pzt, 4=Cuma)
    - Pre_Trend_5Gun     : Gap öncesi 5 günlük kapanış trendi (%)
    - Gap_Kategori       : 0=Küçük(<0.1%), 1=Orta(0.1-0.3%), 2=Büyük(>0.3%)
    - Ilk5Bar_Yonu       : Gap açılışından sonraki ilk 5 barın yönü (+1/-1/0)
    """
    print(f"[*] Veri okunuyor: {input_path}")
    try:
        df = pd.read_csv(input_path, sep=';', decimal=',', dtype={'Tarih': str, 'Saat': str})
    except Exception as e:
        return f"Hata (Okuma): {e}"

    df['datetime'] = pd.to_datetime(df['Tarih'] + ' ' + df['Saat'], dayfirst=True)
    df = df.sort_values('datetime').reset_index(drop=True)
    df['date'] = df['datetime'].dt.date

    # Yüksek/Düşük sütun kontrolü (gap fill tespiti için ideal, yoksa kapanış kullanılır)
    has_high_low = 'Yüksek' in df.columns and 'Düşük' in df.columns
    has_volume = 'Hacim' in df.columns
    if not has_high_low:
        print("[!] Uyarı: 'Yüksek'/'Düşük' sütunları bulunamadı — Kapanış fiyatıyla yaklaşık gap fill kontrolü yapılacak.")

    dates = sorted(df['date'].unique())
    gaps_data = []

    print("[*] Gap'ler tespit ediliyor ve etiketleniyor (gün içi kapanma analizi)...")

    for i in range(1, len(dates) - 1):
        prev_date  = dates[i - 1]
        gap_date   = dates[i]

        yesterday_bars = df[df['date'] == prev_date]
        if yesterday_bars.empty:
            continue
        last_bar_yesterday = yesterday_bars.iloc[-1]

        today_bars = df[df['date'] == gap_date]
        if today_bars.empty:
            continue
        first_bar_today = today_bars.iloc[0]

        time_diff = first_bar_today['datetime'] - last_bar_yesterday['datetime']

        # Gece gap'i kontrolü: 6-15 saat arası
        if not (6 * 3600 < time_diff.total_seconds() < 15 * 3600):
            continue

        gap_size = first_bar_today['Açılış'] - last_bar_yesterday['Kapanış']
        gap_pct  = (gap_size / last_bar_yesterday['Kapanış']) * 100

        # Çok küçük gap'leri es geç
        if abs(gap_pct) < MIN_GAP_PCT:
            continue

        # ----------------------------------------------------------------
        # LABELING: Gap gün içinde kapandı mı?
        # Kapanma seviyesi = önceki günün kapanışı (gap_close_level)
        # ----------------------------------------------------------------
        gap_close_level = last_bar_yesterday['Kapanış']
        gap_closed = False

        if has_high_low:
            if gap_size > 0:   # Yukarı gap → gün içinde düşükler kapanış seviyesine gelirse gap kapandı
                gap_closed = (today_bars['Düşük'] <= gap_close_level).any()
            else:              # Aşağı gap → gün içinde yüksekler kapanış seviyesine gelirse gap kapandı
                gap_closed = (today_bars['Yüksek'] >= gap_close_level).any()
        else:
            # Yüksek/Düşük yoksa kapanış fiyatıyla yaklaşık kontrol (%0.1 tolerans)
            tol = gap_close_level * 0.001
            if gap_size > 0:
                gap_closed = (today_bars['Kapanış'] <= gap_close_level + tol).any()
            else:
                gap_closed = (today_bars['Kapanış'] >= gap_close_level - tol).any()

        label = 0 if gap_closed else 1   # 0 = Gap kapandı, 1 = Trend devam

        # ----------------------------------------------------------------
        # FEATURE ENGINEERING
        # ----------------------------------------------------------------
        start_idx = df[df['datetime'] == first_bar_today['datetime']].index[0]

        # 1. Volatilite: gap öncesi 20 bar kapanış std
        pre_window   = df.iloc[max(0, start_idx - 20):start_idx]['Kapanış']
        volatility   = float(pre_window.std()) if len(pre_window) > 1 else 0.0

        # 2. Hacim değişimi
        volume_change = 0.0
        if has_volume and start_idx > 0:
            try:
                cur_vol  = float(df.iloc[start_idx]['Hacim'])
                prev_vol = float(df.iloc[start_idx - 1]['Hacim'])
                volume_change = (cur_vol - prev_vol) / prev_vol if prev_vol != 0 else 0.0
            except Exception:
                pass

        # 3. Haftanın günü (0=Pazartesi, 4=Cuma)
        day_of_week = pd.Timestamp(gap_date).dayofweek

        # 4. Gap öncesi 5 günlük trend (son 5 günün kapanışlarının değişimi %)
        pre_trend = 0.0
        if i >= 5:
            pre_closes = []
            for j in range(max(0, i - 5), i):
                day_bars = df[df['date'] == dates[j]]
                if not day_bars.empty:
                    pre_closes.append(float(day_bars.iloc[-1]['Kapanış']))
            if len(pre_closes) >= 2:
                pre_trend = (pre_closes[-1] - pre_closes[0]) / pre_closes[0] * 100

        # 5. Gap büyüklük kategorisi
        abs_pct = abs(gap_pct)
        if abs_pct < 0.1:
            gap_category = 0   # Küçük
        elif abs_pct < 0.3:
            gap_category = 1   # Orta
        else:
            gap_category = 2   # Büyük

        # 6. İlk 5 barın yönü (gap açılışından sonra piyasanın verdiği ilk tepki)
        first_5 = today_bars.iloc[:5]
        ilk5_yonu = 0
        if len(first_5) >= 2:
            move = float(first_5.iloc[-1]['Kapanış']) - float(first_5.iloc[0]['Açılış'])
            ilk5_yonu = 1 if move > 0 else -1

        gaps_data.append({
            'Gap_Tarihi':       gap_date.strftime('%Y-%m-%d'),
            'Gap_Yuzde':        round(gap_pct, 6),
            'Gap_Yon_Binary':   1 if gap_size > 0 else 0,
            'Volatility_Std':   round(volatility, 6),
            'Volume_Change':    round(volume_change, 6),
            'Gun_Sira':         day_of_week,
            'Pre_Trend_5Gun':   round(pre_trend, 6),
            'Gap_Kategori':     gap_category,
            'Ilk5Bar_Yonu':     ilk5_yonu,
            'Target_Label':     label
        })

    if not gaps_data:
        return "Etiketlenecek gap bulunamadı."

    dataset_df = pd.DataFrame(gaps_data)
    dataset_df.to_csv(output_path, index=False, sep=';', decimal=',')

    label_counts = dataset_df['Target_Label'].value_counts()
    total = len(dataset_df)
    print(f"  → Toplam gap:          {total}")
    print(f"  → Label=0 (Kapandı):   {label_counts.get(0, 0)} ({label_counts.get(0,0)/total*100:.1f}%)")
    print(f"  → Label=1 (Devam):     {label_counts.get(1, 0)} ({label_counts.get(1,0)/total*100:.1f}%)")

    return f"Başarılı! {total} adet etiketli örnek '{output_path}' dosyasına kaydedildi."

if __name__ == "__main__":
    input_csv  = r"D:\Projects\IdealQuant\data\VIPX030T_1Dk_BarData.csv"
    output_csv = r"D:\Projects\IdealQuant\gap_training_dataset.csv"

    if not os.path.exists(input_csv):
        print(f"Hata: {input_csv} bulunamadı.")
    else:
        result = create_labeled_dataset(input_csv, output_csv)
        print(result)
