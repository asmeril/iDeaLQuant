import sys
import pandas as pd
import numpy as np

# Kaynaklar
log_path = 'd:/Projects/IdealQuant/tests/Spread_Trader_Log.csv'
liq_path = 'd:/Projects/IdealQuant/tests/viop_liquidity_ranking.csv'
ou_path = 'd:/Projects/IdealQuant/tests/ou_halflife_results.csv'

# Takasbank Spread Charge (Vade Ici)
span_teminat = {
    "XU030": 9510, "AKBNK": 820, "AKSEN": 865, "BRSAN": 6570,
    "GARAN": 1415, "THYAO": 3175, "TUPRS": 2620, "ASELS": 4475,
    "EREGL": 330, "ISCTR": 145, "YKBNK": 415, "PETKM": 230,
    "SAHOL": 1095, "KCHOL": 1900, "TCELL": 1115, "SISE": 470,
    "HALKB": 465, "VAKBN": 355, "PGSUS": 1940, "FROTO": 1060,
    "TOASO": 2945, "BIMAS": 6085, "DOHOL": 215
}

try:
    df_trades = pd.read_csv(log_path, header=None, names=[
        'Tarih', 'Saat', 'Yon', 'Sembol', 'Tip', 'Lot', 'FiyatYakin', 'FiyatUzak', 'Makas', 'PnL'
    ])
    df_liq = pd.read_csv(liq_path)
    df_ou = pd.read_csv(ou_path)
except Exception as e:
    print(f"Error loading CSVs: {e}")
    sys.exit()

# Sadece Tamamlanmis Cikis Islemleri PnL Tasir
exits = df_trades[df_trades['Yon'] == 'CIKIS'].copy()
exits['PnL'] = pd.to_numeric(exits['PnL'], errors='coerce')
exits['Lot'] = pd.to_numeric(exits['Lot'], errors='coerce')

# Gercek yatirilan TEMINAT miktarini hesapla (Sermaye blokesi)
# Maliyet = Lot * TekLotSPAN * 1.20 (Sistemin Margin Buffer'ı)
def calc_margin(row):
    sym = row['Sembol']
    lot = row['Lot']
    teminat_per_lot = span_teminat.get(sym, 1000) # Default if not found
    return teminat_per_lot * lot * 1.20

exits['Bloke_Edilen_TL'] = exits.apply(calc_margin, axis=1)

# Gercek Verimlilik: (PnL / Bloke Edilen TL) * %100 = ISLEM BASINA GETIRI (Return on Margin)
exits['RoM_Pct'] = (exits['PnL'] / exits['Bloke_Edilen_TL']) * 100

grouped = exits.groupby('Sembol').agg({
    'PnL': ['sum', 'count'],
    'RoM_Pct': 'mean',          # Islem basina ortalama getiri yuzdesi
    'Bloke_Edilen_TL': 'mean'   # Islem basina ortalama bloke
}).reset_index()
grouped.columns = ['Sembol', 'Toplam_PnL', 'Islem_Adedi', 'Ort_GiriR_Pct', 'Ort_Bloke_Sermaye']

df_final = pd.merge(grouped, df_ou[['Sembol', 'HalfLife_Bar']], on='Sembol', how='inner')
df_final = pd.merge(df_final, df_liq[['Symbol', 'AvgHacimTL']], left_on='Sembol', right_on='Symbol', how='inner')

# Likidite filtresini daraltma ki cogu senet girsin, efsanevi senetleri gormeliyiz.
df_final = df_final.sort_values('Ort_GiriR_Pct', ascending=False)

print("\n" + "="*115)
print(f"VIOP CALENDAR SPREAD - ROBOT LIVE TRADE GERÇEK SERMAYE KÂRLILIK ORANI (Return on Margin)")
print("="*115)
print(f"{'Sembol':<8} | {'Takas_Span':<10} | {'Islm':<5} | {'Toplam K/Z':<12} | {'Ort Blokaj':<12} | {'Gerçek Getiri':<15} | {'Hız(HL)':<10}")
print("-" * 115)

for _, r in df_final.iterrows():
    span_tl = span_teminat.get(r['Sembol'], 0)
    print(f"{r['Sembol']:<8} | {span_tl:>6} TL | {r['Islem_Adedi']:>4.0f} | {r['Toplam_PnL']:>8.1f} TL | {r['Ort_Bloke_Sermaye']:>9.0f} TL | % {r['Ort_GiriR_Pct']:>13.3f} | {r['HalfLife_Bar']:>5.0f} bar")

print("\n--- SONUÇ YORUMU ---")
print("1. 'Gerçek Getiri (Return on Margin)': Bloke edilen her 100 TL teminatın o işlemden yüzde kaç kazandırdığıdır.")
print("2. Eğer listedeki kontratlarda bu yüzdeler birbirine çok yakınsa, robotun arbitraj/fiyatlama algoritması KUSURSUZ çalışıyor demektir.")
print("3. Lot sayısına takılı kalmadan, bakiye yönetimi yaparken kâr oranını standardize etmiş olduk.")
