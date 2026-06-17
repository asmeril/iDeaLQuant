# -*- coding: utf-8 -*-
import io, sys
sys.stdout = io.TextIOWrapper(sys.stdout.buffer, encoding='utf-8', errors='replace')
"""
Ornstein-Uhlenbeck Mean Reversion Half-Life Analizi
=====================================================
VIOP yakin/uzak vade kontrat ciftleri uzerinde OLS regresyon ile
OU Half-Life hesaplar.

Spread_t = ((Close_Uzak_t - Close_Yakin_t) / Close_Yakin_t) * 100
dS_t = lambda * S_{t-1} + mu
Half_Life = -ln(2) / lambda   (lambda < 0 ise)
"""

import sys
import os
import warnings
import numpy as np
import pandas as pd
from pathlib import Path
from scipy import stats

warnings.filterwarnings('ignore')

sys.path.insert(0, 'd:/Projects/IdealQuant')
from src.data.ideal_parser import read_ideal_data

# ───────────────────────────────────────────────────
# YAPILANDIRMA
# ───────────────────────────────────────────────────
BASE       = Path('D:/iDeal/ChartData')
VIP_1M     = BASE / 'VIP' / '01'
OUT_CSV    = Path('d:/Projects/IdealQuant/tests/ou_halflife_results.csv')
MIN_BARS   = 500          # Analize dahil edilecek minimum ortak bar sayisi
MIN_OU_R2  = 0.005        # Cok dusuk R2 sonuclari anlamsiz - zayif filtre

# ───────────────────────────────────────────────────
# KONTRAT CIFTLERI
# ───────────────────────────────────────────────────
def get_contract_pairs():
    """
    0 Spot/hisse vadeliler : yakin=0426, uzak=0526
    1 Endeks/cift-ay       : yakin=0426, uzak=0626
    """
    f0426 = {}
    f0526 = {}
    f0626 = {}

    for f in VIP_1M.glob("*F_*0426.01"):
        if "'F_" in f.name and f.stem.endswith('0426'):
            try:
                sym = f.stem.split("F_")[1].replace('0426', '')
                f0426[sym] = f
            except Exception:
                pass

    for f in VIP_1M.glob("*F_*0526.01"):
        if "'F_" in f.name and f.stem.endswith('0526'):
            try:
                sym = f.stem.split("F_")[1].replace('0526', '')
                f0526[sym] = f
            except Exception:
                pass

    for f in VIP_1M.glob("*F_*0626.01"):
        if "'F_" in f.name and f.stem.endswith('0626'):
            try:
                sym = f.stem.split("F_")[1].replace('0626', '')
                f0626[sym] = f
            except Exception:
                pass

    pairs = []

    # Spot vadeliler: 0526 olan her seyin 0426'si varsa
    for sym in sorted(set(f0426) & set(f0526)):
        pairs.append({
            'symbol':    sym,
            'category':  'Spot/Hisse',
            'near_file': f0426[sym],
            'far_file':  f0526[sym],
            'near_tag':  '0426',
            'far_tag':   '0526',
        })

    # Endeks/cift-ay: 0626 var ama 0526 yok
    only_0626 = set(f0626) - set(f0526)
    for sym in sorted(set(f0426) & only_0626):
        pairs.append({
            'symbol':    sym,
            'category':  'Endeks/CiftAy',
            'near_file': f0426[sym],
            'far_file':  f0626[sym],
            'near_tag':  '0426',
            'far_tag':   '0626',
        })

    return pairs


# ───────────────────────────────────────────────────
# VERI YUKLEME & MERGE
# ───────────────────────────────────────────────────
def load_and_merge(near_file: Path, far_file: Path) -> pd.DataFrame | None:
    """
    Iki kontrat dosyasini yukle, DateTime'a gore hizala.
    Bosluklar ffill ile doldurulur.
    Sadece Close kolonunu al.
    """
    try:
        df_n = read_ideal_data(str(near_file))[['DateTime', 'Close']].rename(
            columns={'Close': 'Close_Near'})
        df_f = read_ideal_data(str(far_file))[['DateTime', 'Close']].rename(
            columns={'Close': 'Close_Far'})
    except Exception as e:
        return None

    # Merge outer, ffill
    merged = pd.merge_asof(
        df_n.sort_values('DateTime'),
        df_f.sort_values('DateTime'),
        on='DateTime',
        direction='backward'
    )

    # Geceli/hafta sonu bosluklari ffill
    merged['Close_Near'] = merged['Close_Near'].ffill()
    merged['Close_Far']  = merged['Close_Far'].ffill()
    merged = merged.dropna()

    if len(merged) < MIN_BARS:
        return None

    return merged


# ───────────────────────────────────────────────────
# OU HALF-LIFE HESABI
# ───────────────────────────────────────────────────
def compute_ou_halflife(spread: pd.Series):
    """
    OLS regresyonu: dS_t = lambda * S_{t-1} + mu + epsilon
    Returns dict with lambda, mu, r2, half_life (bars)
    """
    S   = spread.values
    dS  = np.diff(S)
    S_1 = S[:-1]            # S_{t-1}

    # OLS: dS ~ S_1  (intercept dahil)
    slope, intercept, r_value, p_value, std_err = stats.linregress(S_1, dS)

    lam = slope              # lambda (negatif olmali)
    mu  = intercept

    if lam >= 0:
        half_life = np.nan
        mean_rev  = False
    else:
        half_life = -np.log(2) / lam
        mean_rev  = True

    return {
        'lambda':      lam,
        'mu':          mu,
        'r2':          r_value ** 2,
        'p_value':     p_value,
        'half_life':   half_life,
        'mean_rev':    mean_rev,
        'spread_mean': np.mean(S),
        'spread_std':  np.std(S),
        'n_bars':      len(S),
    }


# ───────────────────────────────────────────────────
# RAPORLAMA
# ───────────────────────────────────────────────────
def half_life_to_zscore_window(hl: float) -> str:
    """
    Yaygin pratik kural:
    Optimum Z-Score penceresi = 2x - 3x Half-Life
    """
    if np.isnan(hl):
        return "N/A"
    lo = int(round(hl * 2))
    hi = int(round(hl * 3))
    # Ek yorum
    if hl < 15:
        tag = "COK KISA (scalping)"
    elif hl < 60:
        tag = "KISA (30dk-1sa)"
    elif hl < 180:
        tag = "ORTA (2-3sa)"
    elif hl < 480:
        tag = "UZUN (yarim gun)"
    else:
        tag = "COK UZUN (gunler)"
    return f"~{lo}-{hi} bar  [{tag}]"


# ───────────────────────────────────────────────────
# ANA AKIS
# ───────────────────────────────────────────────────
def main():
    pairs = get_contract_pairs()
    print(f"Toplam {len(pairs)} kontrat cifti bulundu.")
    print("="*100)

    results = []

    for pair in pairs:
        sym  = pair['symbol']
        cat  = pair['category']
        ntag = pair['near_tag']
        ftag = pair['far_tag']

        merged = load_and_merge(pair['near_file'], pair['far_file'])
        if merged is None:
            print(f"  [{sym:16s}] ATLANDI - yetersiz ortak bar")
            continue

        # Spread % hesabi
        # KORU: Sifir fiyatli barlari ele
        valid_mask = (merged['Close_Near'] > 0) & (merged['Close_Far'] > 0)
        merged = merged[valid_mask]
        if len(merged) < MIN_BARS:
            print(f"  [{sym:16s}] ATLANDI - sifir fiyat filtresi sonrasi yetersiz")
            continue

        spread = ((merged['Close_Far'] - merged['Close_Near']) / merged['Close_Near']) * 100

        # OU analizi
        ou = compute_ou_halflife(spread)

        # R2 filtresi
        if ou['r2'] < MIN_OU_R2:
            mr_flag = "ZAYIF R2"
        else:
            mr_flag = "OK"

        row = {
            'Sembol':       sym,
            'Kategori':     cat,
            'YakinVade':    ntag,
            'UzakVade':     ftag,
            'OrthakBar':    ou['n_bars'],
            'SpreadMean%':  round(ou['spread_mean'], 4),
            'SpreadStd%':   round(ou['spread_std'],  4),
            'Lambda':       round(ou['lambda'],       6),
            'Mu':           round(ou['mu'],           6),
            'R2':           round(ou['r2'],            6),
            'P_Value':      round(ou['p_value'],       6),
            'MeanRev':      ou['mean_rev'],
            'HalfLife_Bar': round(ou['half_life'], 1) if ou['mean_rev'] else np.nan,
            'Flag':         mr_flag,
        }
        results.append(row)

        # Konsol ciktisi
        if ou['mean_rev']:
            hl   = ou['half_life']
            win  = half_life_to_zscore_window(hl)
            flag = "[OK]" if mr_flag == "OK" else "[~]"
            print(f"  {flag} [{sym:<16s}] {cat:<15s} | "
                  f"bars={ou['n_bars']:>6,} | "
                  f"spread={ou['spread_mean']:>+7.3f}%+/-{ou['spread_std']:.3f} | "
                  f"lambda={ou['lambda']:>+.5f} | "
                  f"HL={hl:>7.1f} bar | "
                  f"pencere={win}")
        else:
            print(f"  [X] [{sym:<16s}] {cat:<15s} | "
                  f"bars={ou['n_bars']:>6,} | "
                  f"lambda={ou['lambda']:>+.5f}  >> ORTALAMAYA DONMUYOR")

    # ─── OZET ───────────────────────────────────────
    df_res = pd.DataFrame(results)
    mean_rev_df = df_res[df_res['MeanRev'] == True].copy()

    print("\n" + "="*100)
    print("OZET")
    print("="*100)
    print(f"Analiz edilen cifT sayisi : {len(results)}")
    print(f"Ortalamaya donen cifT     : {len(mean_rev_df)}  ({100*len(mean_rev_df)/max(len(results),1):.1f}%)")

    if len(mean_rev_df) > 0:
        hl_median   = mean_rev_df['HalfLife_Bar'].median()
        hl_mean     = mean_rev_df['HalfLife_Bar'].mean()
        hl_min      = mean_rev_df['HalfLife_Bar'].min()
        hl_max      = mean_rev_df['HalfLife_Bar'].max()

        print(f"\nYari-Omur Istatistikleri (1dk barlar):")
        print(f"  Medyan : {hl_median:.1f} bar  = {hl_median/60:.1f} saat")
        print(f"  Ortalama: {hl_mean:.1f} bar  = {hl_mean/60:.1f} saat")
        print(f"  Min    : {hl_min:.1f} bar  = {hl_min/60:.1f} saat")
        print(f"  Max    : {hl_max:.1f} bar  = {hl_max/60:.1f} saat")

        print(f"\nOptimum Z-Score Olcum Penceresi Tavsiyesi (medyan kullanilarak):")
        print(f"  Medyan HL = {hl_median:.1f} bar")
        print(f"  Pratik kural (2x-3x HL): ~{int(hl_median*2)}-{int(hl_median*3)} bar")
        print(f"  {half_life_to_zscore_window(hl_median)}")

        print(f"\nKategori bazinda medyan Half-Life:")
        for cat, grp in mean_rev_df.groupby('Kategori'):
            cat_hl = grp['HalfLife_Bar'].median()
            print(f"  {cat:<18s}: medyan HL = {cat_hl:.1f} bar ({cat_hl/60:.1f} sa) "
                  f"-> pencere ~{int(cat_hl*2)}-{int(cat_hl*3)} bar")

        print(f"\nEN HIZ ORTALAMAYA DONEN (HL < 60 bar = < 1 saat):")
        fast_df = mean_rev_df[mean_rev_df['HalfLife_Bar'] < 60].sort_values('HalfLife_Bar')
        if len(fast_df) > 0:
            for _, r in fast_df.iterrows():
                print(f"  {r['Sembol']:<16s} HL={r['HalfLife_Bar']:.1f} bar "
                      f"| spread={r['SpreadMean%']:+.3f}%±{r['SpreadStd%']:.3f} "
                      f"| lambda={r['Lambda']:+.5f}")
        else:
            print("  Yok (hepsi > 1 saat)")

        print(f"\nEN YAVAS ORTALAMAYA DONEN (HL > 240 bar = > 4 saat):")
        slow_df = mean_rev_df[mean_rev_df['HalfLife_Bar'] > 240].sort_values('HalfLife_Bar', ascending=False)
        for _, r in slow_df.head(10).iterrows():
            print(f"  {r['Sembol']:<16s} HL={r['HalfLife_Bar']:.1f} bar ({r['HalfLife_Bar']/60:.1f}sa) "
                  f"| spread={r['SpreadMean%']:+.3f}%±{r['SpreadStd%']:.3f}")

        # En iyi R2 siralamasiyla TOP 10
        print(f"\nTOP 10 - En Yuksek R2 (OU Model Uyumu):")
        top10 = mean_rev_df.sort_values('R2', ascending=False).head(10)
        for _, r in top10.iterrows():
            print(f"  {r['Sembol']:<16s} R2={r['R2']:.5f} | HL={r['HalfLife_Bar']:.1f} bar "
                  f"| spread={r['SpreadMean%']:+.3f}%±{r['SpreadStd%']:.3f}")

    # CSV kaydet
    df_res.to_csv(OUT_CSV, index=False, encoding='utf-8-sig')
    print(f"\nDetayli sonuclar kaydedildi: {OUT_CSV}")
    print("="*100)

    return df_res


if __name__ == '__main__':
    df = main()
