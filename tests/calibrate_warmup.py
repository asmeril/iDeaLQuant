"""
SuperTrend EŞIT KOŞUL kalibrasyonu:
Full 500K bar verisiyle başlatıp, ideal_supertrend.csv barlarını karşılaştırıyoruz.
Böylece warmup barları IdealData ile aynı şekilde çalışmış oluyor.
"""
import pandas as pd
import numpy as np

# --- 1. Tam veriyi yükle ---
df_full = pd.read_csv(
    r'data/VIPX030T_1Dk_BarData.csv',
    sep=';', encoding='utf-8-sig',
    names=['Tarih','Saat','Open','High','Low','Close','Mid','Volume','Lot'],
    header=0,
    dtype=str,
    on_bad_lines='skip'
)
for col in ['High', 'Low', 'Close']:
    df_full[col] = df_full[col].str.replace(',', '.').astype(float, errors='ignore')
    df_full[col] = pd.to_numeric(df_full[col], errors='coerce')

df_full = df_full.dropna(subset=['High','Low','Close'])
df_full = df_full.reset_index(drop=True)
print(f"Full veri: {len(df_full)} bar yüklendi")
print(f"İlk bar: {df_full.iloc[0][['Tarih','Saat','High','Low','Close']].to_dict()}")
print(f"100. bar (idx=99): {df_full.iloc[99][['Tarih','Saat','High','Low','Close']].to_dict()}")
print()

# --- 2. Ideal SuperTrend yükle ---
df_st = pd.read_csv(r'data/ideal_supertrend.csv', sep=';')
print(f"Ideal ST: {len(df_st)} bar, BarNo {df_st['BarNo'].min()} - {df_st['BarNo'].max()}")
ideal = df_st['SuperTrend'].values.astype(float)
print(f"Ideal[0] (Bar 100): H={df_st['High'].iloc[0]} L={df_st['Low'].iloc[0]} ST={ideal[0]}")
print()

# --- 3. Full veri üzerinde SuperTrend çalıştır (hhv_p=10, factor=3.0) ---
h_full = df_full['High'].values.astype(float)
l_full = df_full['Low'].values.astype(float)
c_full = df_full['Close'].values.astype(float)
n = len(c_full)

# TR
tr = np.zeros(n)
tr[0] = h_full[0] - l_full[0]
for i in range(1, n):
    tr[i] = max(h_full[i]-l_full[i], abs(h_full[i]-c_full[i-1]), abs(l_full[i]-c_full[i-1]))

# RMA(10)
alpha = 1.0 / 10
atr = np.zeros(n)
atr[0] = tr[0]
for i in range(1, n):
    atr[i] = tr[i] * alpha + atr[i-1] * (1 - alpha)

# SuperTrend
factor = 3.0
mid = (h_full + l_full) / 2.0
up = mid + factor * atr
dn = mid - factor * atr
st = np.zeros(n)
st[0] = up[0]
t = -1
for i in range(1, n):
    if t == 1:
        st[i] = max(dn[i], st[i-1])
        if c_full[i] < st[i]:
            t = -1
            st[i] = up[i]
    else:
        st[i] = min(up[i], st[i-1])
        if c_full[i] > st[i]:
            t = 1
            st[i] = dn[i]

print(f"ATR[99] (Bar 100) = {atr[99]:.6f}  (expected ~1.109)")
print(f"ST[99]  (Bar 100) = {st[99]:.4f}   (Ideal = {ideal[0]:.4f})")
print()

# --- 4. Compare from bar 100 onwards ---
# ideal_supertrend.csv'nin Bar 100'ü full verideki hangi satıra denk geliyor?
# Full veri 500k bar, ideal_supertrend 499.900 bar => ideal bar 100 = full_idx 99 (0-indexed)
# Check: compare High values
bar_offset = len(df_full) - len(df_st)
print(f"Bar offset: {bar_offset} (ideal starts from full_idx {bar_offset})")
print(f"Full[{bar_offset}]: H={h_full[bar_offset]:.2f} L={l_full[bar_offset]:.2f}")
print(f"Ideal[0]:  H={df_st['High'].iloc[0]:.2f} L={df_st['Low'].iloc[0]:.2f}")
print()

# Slice from offset
st_slice = st[bar_offset:]
diff = np.abs(ideal - st_slice)
pct_diff = diff / np.abs(ideal) * 100

print("=== EŞİT KOŞUL Kalibrasyon Sonuçları ===")
print(f"Parametre: RMA(10), factor=3.0, warmup={bar_offset} bar")
print(f"Karşılaştırma: {len(ideal)} bar")
print(f"Mean Error%: {pct_diff.mean():.6f}%")
print(f"Max Error%:  {pct_diff.max():.4f}%")
print(f"Bars <0.001 TL: {(diff<0.001).sum()} ({(diff<0.001).sum()/len(ideal)*100:.1f}%)")
print(f"Bars <0.01 TL:  {(diff<0.01).sum()} ({(diff<0.01).sum()/len(ideal)*100:.1f}%)")
print(f"Bars <0.1 TL:   {(diff<0.1).sum()} ({(diff<0.1).sum()/len(ideal)*100:.1f}%)")
print()
print("İlk 10 bar karşılaştırması:")
for i in range(10):
    print(f"  Bar {i+100}: Ideal={ideal[i]:.4f}  Py={st_slice[i]:.4f}  Diff={ideal[i]-st_slice[i]:.4f}")
