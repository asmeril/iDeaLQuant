import sys
import pandas as pd
import numpy as np

# Daha once elde ettigimiz veriler
ou_path  = 'd:/Projects/IdealQuant/tests/ou_halflife_results.csv'
liq_path = 'd:/Projects/IdealQuant/tests/viop_liquidity_ranking.csv'
inv_path = 'd:/Projects/IdealQuant/tests/viop_inventory.csv'

try:
    df_ou  = pd.read_csv(ou_path)
    df_liq = pd.read_csv(liq_path)
    df_inv = pd.read_csv(inv_path)
except Exception as e:
    print(f"Error loading CSVs: {e}")
    sys.exit()

# Tablolari birlestir
df1 = pd.merge(df_ou, df_liq, left_on='Sembol', right_on='Symbol', how='inner')
df  = pd.merge(df1, df_inv[['Sembol', 'Son_Yakin']], on='Sembol', how='inner')

# Sadece Likiditesi makul olanlari al (Olu tahtalari engelle)
df = df[df['AvgHacimTL'] > 1000000].copy() # Ortalama hacmi dakikada 1 Milyon TL ustu olanlar

def get_contract_multiplier(sym):
    if sym in ['XU030', 'XLBNK', 'X10XB', 'SASX10']: return 10
    if 'USD' in sym or 'TRY' in sym or sym in ['XAUTRYM', 'CNHTRY']: return 100 
    return 100 # Cogu hisse senedi 100 paydir

df['Carpan'] = df['Sembol'].apply(get_contract_multiplier)

# 1. 1 Standart Sapmalik Hareketin 1 Lot icin TL Degeri
# Formül: Fiyat * (Spread Std Sapmasi % / 100) * Sözlesme Carpani
df['1_Std_TL_Potansiyel'] = df['Son_Yakin'] * (df['SpreadStd%'] / 100) * df['Carpan']

# 2. Zaman Verimliligi (Half-Life'in dusuklugu -> Hiz)
# Kac dakikada o potansiyel alinir?
df['Zaman_Maliyeti_Dk'] = df['HalfLife_Bar'].replace(0, 1)

# 3. VERIMLILIK SKORU = ((TL Potansiyeli * OU_R2_Gucu) / Zaman_Maliyeti) * 100
# Yani, en kisa surede (HL dusuk), en kararli R2 ile, en yuksek TL voleyini kim atiyor?
df['Verimlilik_Skoru'] = (df['1_Std_TL_Potansiyel'] * df['R2'] / df['Zaman_Maliyeti_Dk']) * 100

# Sonuclari puan sirasina diz
df_final = df.sort_values('Verimlilik_Skoru', ascending=False)

print("="*105)
print("VIOP YAKIN-UZAK VADE SPREAD ARBITRAJI VERIMLILIK VE KARLILIK SIRALAMASI")
print("="*105)
print(f"{'Sembol':<10} | {'Fiyat(Yak)':>10} | {'Hacim/Dk':>14} | {'1_Std_Kar_TL':>12} | {'Donus_Hizi':>10} | {'Verim_Skor':>10}")
print("-" * 105)

for _, row in df_final.head(20).iterrows():
    hacim_str = f"{row['AvgHacimTL']/1000000:.1f} Mln TL"
    print(f"{row['Sembol']:<10} | {row['Son_Yakin']:>10.2f} | {hacim_str:>14} | {row['1_Std_TL_Potansiyel']:>9.1f} TL | {row['HalfLife_Bar']:>6.1f} bar | {row['Verimlilik_Skoru']:>10.2f}")

print("\n--- ANALIZ YORUMU ---")
print("1_Std_Kar_TL: Sadece 1 lotluk işlemde makasın 1 standart sapma (normal bandına) dönmesiyle kazanılacak DİREKT TL tutarıdır.")
print("Donus Hizi (Half-Life): Makasın normaline dönmesi için geçmesi gereken optimum ortalama süre (dakika).")
print("Verim Skoru: Kar tutarının hıza (zamana) bölünmesiyle çıkan katsayıdır. (Yukarıdaki robot karlılığını açıklar!)")

# CSV Kaydet
df_final.to_csv('d:/Projects/IdealQuant/tests/viop_spread_efficiency.csv', index=False, float_format='%.3f')
