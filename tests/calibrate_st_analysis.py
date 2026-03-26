"""
SuperTrend kalibrasyon analizi - flip ve non-flip hata dağılımı
"""
import sys, numpy as np, pandas as pd
sys.path.insert(0, '.')

df = pd.read_csv(r'data/ideal_supertrend.csv', sep=';')
h = df['High'].values.astype(float)
l = df['Low'].values.astype(float)
c = df['Close'].values.astype(float)
ideal = df['SuperTrend'].values.astype(float)
n = len(c)

tr = np.zeros(n)
tr[0] = h[0] - l[0]
for i in range(1, n):
    tr[i] = max(h[i]-l[i], abs(h[i]-c[i-1]), abs(l[i]-c[i-1]))

alpha = 1.0/9
atr = np.zeros(n); atr[0] = tr[0]
for i in range(1, n):
    atr[i] = tr[i]*alpha + atr[i-1]*(1-alpha)

mid = (h+l)/2.0
factor = 3.0
up = mid + factor*atr
dn = mid - factor*atr
st = np.zeros(n); st[0] = up[0]; t = -1
flip_idx = np.zeros(n, dtype=bool)
for i in range(1, n):
    if t == 1:
        st[i] = max(dn[i], st[i-1])
        if c[i] < st[i]:
            t = -1; st[i] = up[i]; flip_idx[i] = True
    else:
        st[i] = min(up[i], st[i-1])
        if c[i] > st[i]:
            t = 1; st[i] = dn[i]; flip_idx[i] = True

diff = np.abs(ideal - st)
pct_diff = diff / np.abs(ideal) * 100

flip_errors = pct_diff[flip_idx]
noflip_errors = pct_diff[~flip_idx]
print(f'FLIP bars:     count={flip_idx.sum():6d}, Ort%={flip_errors.mean():.6f}, Max%={flip_errors.max():.4f}')
print(f'NON-FLIP bars: count={(~flip_idx).sum():6d}, Ort%={noflip_errors.mean():.6f}, Max%={noflip_errors.max():.4f}')
print()

big = np.where((pct_diff > 0.01) & (~flip_idx))[0]
print(f'Non-flip bars with >0.01% error: {len(big)}')
for idx in big[:8]:
    left = flip_idx[idx-1] if idx > 0 else '?'
    right = flip_idx[min(idx+1, n-1)]
    print(f'  Bar={idx+100}: Ideal={ideal[idx]:.4f} Py={st[idx]:.4f} Pct%={pct_diff[idx]:.4f}  prev_flip={left} next_flip={right}')

big2 = np.where((pct_diff > 0.01) & flip_idx)[0]
print(f'\nFlip bars with >0.01% error: {len(big2)}')
for idx in big2[:8]:
    print(f'  Bar={idx+100}: Ideal={ideal[idx]:.4f} Py={st[idx]:.4f} Pct%={pct_diff[idx]:.4f}  up={up[idx]:.4f} dn={dn[idx]:.4f}')

# Show consecutive error runs
print('\nConsecutive error runs (5+ bars in a row >0.01%):')
runs = []
run_start = None
for i in range(n):
    if pct_diff[i] > 0.01:
        if run_start is None:
            run_start = i
    else:
        if run_start is not None and i - run_start >= 5:
            runs.append((run_start, i-1, i-run_start))
        run_start = None

for r in runs[:10]:
    s, e, length = r
    print(f'  Bars {s+100}-{e+100} ({length} bars): Ideal={ideal[s]:.4f} Py={st[s]:.4f}  ->  Ideal={ideal[e]:.4f} Py={st[e]:.4f}')
    print(f'    flip_at_start={flip_idx[s]} flip_at_end={flip_idx[e]}')
