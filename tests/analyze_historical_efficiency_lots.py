import sys
import pandas as pd
import numpy as np

ou_path = 'd:/Projects/IdealQuant/tests/ou_halflife_results.csv'
liq_path = 'd:/Projects/IdealQuant/tests/viop_liquidity_ranking.csv'
inv_path = 'd:/Projects/IdealQuant/tests/viop_inventory.csv'

# Robot V2 Faz 3.5 - SPAN Teminat Riskleri
span_teminat = {
    "XU030": 9510, "AKBNK": 820, "AKSEN": 865, "BRSAN": 6570,
    "GARAN": 1415, "THYAO": 3175, "TUPRS": 2620, "ASELS": 4475,
    "EREGL": 330, "ISCTR": 145, "YKBNK": 415, "PETKM": 230,
    "SAHOL": 1095, "KCHOL": 1900, "TCELL": 1115, "SISE": 470,
    "HALKB": 465, "VAKBN": 355, "PGSUS": 1940, "FROTO": 1060,
    "TOASO": 2945, "BIMAS": 6085, "DOHOL": 215
}

try:
    df_ou  = pd.read_csv(ou_path)
    df_liq = pd.read_csv(liq_path)
    df_inv = pd.read_csv(inv_path)
except Exception as e:
    print(f"Hata! CSV'ler yuklenemedi: {e}")
    sys.exit()

# Birlestirmeler
df_ana = pd.merge(df_ou, df_liq, left_on='Sembol', right_on='Symbol', how='inner')
df_ana = pd.merge(df_ana, df_inv[['Sembol', 'Son_Yakin']], on='Sembol', how='inner')

# Likidite Filtresi (Çok Sığları At)
df_ana = df_ana[df_ana['AvgHacimTL'] > 1000000].copy()

# Sozlesme Carpanlari (Endeks 10, Hisse 100)
def get_contract_multiplier(sym):
    return 10 if sym in ['XU030', 'XLBNK'] else 100

df_ana['Carpan'] = df_ana['Sembol'].apply(get_contract_multiplier)
df_ana['Bloke_1Lot'] = df_ana['Sembol'].apply(lambda x: span_teminat.get(x, 1500)*1.20)
df_ana['Beklenen_Kar_1Lot_TL'] = df_ana['Son_Yakin'] * (df_ana['SpreadStd%'] / 100) * df_ana['Carpan']

# -- HEDEF LOT HESAPLAMASI VE DERİNLİK (Slippage) SINIRLAMASI --
TRG_MARGIN = 20000.0 # Bakiye Yönetimi İçin Sabit Blokaj Hedefi

def calculate_lots(row):
    sym = row['Sembol']
    avg_lot_per_min = row['AvgLot']
    
    # 1. Sermaye Riski Baglaminda İstenen Lot
    cost_per_lot = span_teminat.get(sym, 1500) * 1.20
    teorik_lot = max(1, int(np.floor(TRG_MARGIN / cost_per_lot)))
    
    # 2. Tahta Derinliği Bağlamında Gerçekçi Lot (Fiyatı kaydırmamak için AvgLot'un max %50'si)
    tahta_kapasitesi = max(1, int(np.floor(avg_lot_per_min * 0.50)))
    
    gerceklesebilir_lot = min(teorik_lot, tahta_kapasitesi)
    
    return pd.Series([teorik_lot, gerceklesebilir_lot, tahta_kapasitesi])

df_ana[['Teorik_Lot', 'Gerceklesebilir_Lot', 'Tahta_Kapasitesi']] = df_ana.apply(calculate_lots, axis=1)

# Nihai Edilecek Kâr (Gerçekleşebilir lotlarla)
df_ana['Beklenen_Islem_Kari'] = df_ana['Beklenen_Kar_1Lot_TL'] * df_ana['Gerceklesebilir_Lot']

# Verimlilik Skoru ((Kar / Baglanan_Sermaye) * MeanReversionGucu) / HalfLife
df_ana['Baglanan_Sermaye'] = df_ana['Gerceklesebilir_Lot'] * df_ana['Bloke_1Lot']
df_ana['RoM_Pct'] = (df_ana['Beklenen_Islem_Kari'] / df_ana['Baglanan_Sermaye']) * 100

df_ana['HalfLife_Bar'] = df_ana['HalfLife_Bar'].replace(0, 1)
df_ana['Verim_Skoru'] = (df_ana['RoM_Pct'] * df_ana['R2']) / df_ana['HalfLife_Bar'] * 100

# Siralama
df_final = df_ana.sort_values('Verim_Skoru', ascending=False)

print("="*125)
print(f"TARİHSEL KAPANIS & SPAN OPTİMİZASYONU: DERİNLİK/LİKİDİTE SINIRLI LİSTE")
print("="*125)
header = f"{'Sembol':<8} | {'RoM_Pct':>8} | {'Teorik_Lot':>11} | {'Derinlik_Kps':>12} | {'Güvenli_Lot':>11} | {'Islem_Kari':>10} | {'Hız(HL)':>8}"
print(header)
print("-" * 125)

for _, r in df_final.iterrows():
    rom = f"%{r['RoM_Pct']:.2f}"
    ik = f"{r['Beklenen_Islem_Kari']:.0f} TL"
    hl = f"{r['HalfLife_Bar']:.1f} dk"
    print(f"{r['Sembol']:<8} | {rom:>8} | {r['Teorik_Lot']:>7.0f} lot | {r['Tahta_Kapasitesi']:>8.0f} lot | {r['Gerceklesebilir_Lot']:>7.0f} lot | {ik:>10} | {hl:>8}")

df_final.to_csv('d:/Projects/IdealQuant/tests/viop_historical_efficiency_lots.csv', index=False, float_format='%.3f')
print("\n- Tam Liste Kaydedildi: viop_historical_efficiency_lots.csv")
