import sys
from pathlib import Path
sys.path.insert(0, 'd:/Projects/IdealQuant')
from src.data.ideal_parser import read_ideal_data
import pandas as pd

vip_path = Path('D:/iDeal/ChartData/VIP/01')
files = list(vip_path.glob('*F_*0426.01'))

data = []
for f in files:
    try:
        sym = f.stem.split('F_')[1].replace('0426', '')
        df = read_ideal_data(str(f))
        
        # Son 1 aydaki (yaklasik 10,000 bar) gecerli barlari hesapla
        if len(df) > 0:
            df = df.tail(10000)
            avg_vol = df['Volume'].mean()
            avg_amt = df['Amount'].mean()
            zero_bars = len(df[df['Volume'] == 0]) / len(df) * 100
            data.append({
                'Symbol': sym, 
                'AvgLot': avg_vol, 
                'AvgHacimTL': avg_amt,
                'BosBarOraniPct': zero_bars,
                'ToplamBar': len(df)
            })
    except Exception as e:
        pass

df_res = pd.DataFrame(data).sort_values('AvgHacimTL', ascending=False)
out_csv_path = 'd:/Projects/IdealQuant/tests/viop_liquidity_ranking.csv'
df_res.to_csv(out_csv_path, index=False, encoding='utf-8-sig', float_format='%.2f')

print(f"Top 15 konsola yazdirilmaya devam ediliyor...")
print('--- KADEMELERI EN SAGLAM (ISLEM HACMI EN YUKSEK) TOP 15 KONTRAT (Yakin Vade) ---')
for _, r in df_res.head(15).iterrows():
    print(f"{r['Symbol']:<10} | Ort Hacim/Dk: {r['AvgHacimTL']:>13,.0f} TL | Ort Lot/Dk: {r['AvgLot']:>6,.0f} | Bos Bar: %{r['BosBarOraniPct']:.1f}")

print('\n--- KADEMELERI EN BOS (SIK SIK BOS BAR YAPAN) 5 KONTRAT ---')
for _, r in df_res.sort_values('BosBarOraniPct', ascending=False).head(5).iterrows():
    print(f"{r['Symbol']:<10} | Ort Hacim/Dk: {r['AvgHacimTL']:>13,.0f} TL | Ort Lot/Dk: {r['AvgLot']:>6,.0f} | Bos Bar: %{r['BosBarOraniPct']:.1f}")

print(f"\n[BASARILI] Tam Siralama Listesi CSV'ye Kaydedildi: {out_csv_path}")
