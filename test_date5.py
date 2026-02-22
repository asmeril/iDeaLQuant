import pandas as pd
import numpy as np
import io

csv_content = """Tarih;Saat;Acilis;Yuksek;Dusuk;Kapanis;Ortalama;Hacim;Lot
01.01.2024;09:30:00;100;105;95;102;100;1000;1000
01.01.2024;09:31:00;102;106;101;105;103;2000;2000
02.01.2024;09:30:00;105;110;104;108;106;1500;1500
03.01.2024;09:30:00;108;112;105;110;108;1800;1800"""

df = pd.read_csv(io.StringIO(csv_content), sep=';')
df['DateTime'] = pd.to_datetime(df['Tarih'] + ' ' + df['Saat'], format='%d.%m.%Y %H:%M:%S', errors='coerce')

# Check how IndicatorCache handles it
if 'DateTime' in df.columns:
    try:
        times_arr = df['DateTime'].astype('datetime64[s]').astype(np.int64).values
        print("times_arr:", times_arr)
        days = times_arr // 86400
        print("Days:", days)
        print("Unique Days:", len(np.unique(days)))
    except Exception as e:
        print("Error:", e)
