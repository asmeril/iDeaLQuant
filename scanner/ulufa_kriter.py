"""ULUFA kriter breakdown — 09.04.2026 kapanisi bazli Robot simuasyonu"""
import csv
from pathlib import Path

def flt(v):
    try: return float(str(v).replace(',','.'))
    except: return 0.0

def ema(prices, n):
    result = [0.0]*len(prices)
    k = 2/(n+1)
    result[n-1] = sum(prices[:n])/n
    for i in range(n, len(prices)):
        result[i] = prices[i]*k + result[i-1]*(1-k)
    return result

def sma(prices, n):
    result = [0.0]*len(prices)
    for i in range(n-1, len(prices)):
        result[i] = sum(prices[i-n+1:i+1])/n
    return result

def load_csv(path):
    rows = []
    with open(path, encoding='utf-8-sig') as f:
        rdr = csv.DictReader(f, delimiter=';')
        for row in rdr:
            rows.append(row)
    return rows

def analyze(sembol, bi_offset=2):
    """bi_offset=2 => 09.04 (son bar 10.04, bir onceki 09.04)"""
    path = Path(f'D:/Projects/IdealQuant/reference/ideal_docs/BarData_Export/{sembol}_Gunluk_5000bar.csv')
    if not path.exists():
        print(f"HATA: {path} bulunamadi")
        return

    rows = load_csv(path)
    bi = len(rows) - bi_offset

    C   = [flt(r['Kapanis']) for r in rows]
    H   = [flt(r['Yuksek'])  for r in rows]
    L   = [flt(r['Dusuk'])   for r in rows]
    Vol = [flt(r['Hacim'])   for r in rows]
    tarihler = [r['Tarih'] for r in rows]

    EMA9    = ema(C, 9)
    EMA21   = ema(C, 21)
    EMA50   = ema(C, 50)
    EMA200  = ema(C, 200)
    VolMA20 = sma(Vol, 20)

    print(f"\n{'='*65}")
    print(f"  {sembol} — kriter analizi  ({tarihler[bi]} kapanisi)")
    print(f"  Fiyat: {C[bi]:.2f}  Vol: {Vol[bi]:.0f}  VMA20: {VolMA20[bi]:.0f}")
    print(f"{'='*65}")

    # ── 1. EMA STACK ──────────────────────────────────────────────
    ema_p = [
        (4, C[bi]    > EMA9[bi],   f"C({C[bi]:.2f}) > EMA9({EMA9[bi]:.3f})"),
        (4, EMA9[bi] > EMA21[bi],  f"EMA9({EMA9[bi]:.3f}) > EMA21({EMA21[bi]:.3f})"),
        (4, EMA21[bi]> EMA50[bi],  f"EMA21({EMA21[bi]:.3f}) > EMA50({EMA50[bi]:.3f})"),
        (4, EMA50[bi]> EMA200[bi], f"EMA50({EMA50[bi]:.3f}) > EMA200({EMA200[bi]:.3f})"),
        (4, EMA50[bi]> EMA50[bi-5],f"EMA50 egim ({EMA50[bi]:.3f} vs {EMA50[bi-5]:.3f})"),
    ]
    ema_score = sum(p for p,ok,_ in ema_p if ok)
    print(f"\n  EMA STACK ({ema_score}/20):")
    for p,ok,desc in ema_p:
        tick = "OK" if ok else "--"
        pts  = f"+{p}p" if ok else f"  {p}p"
        print(f"    [{tick}] {pts}  {desc}")

    # ── 2. UP HACİM ORANI ─────────────────────────────────────────
    upVolGun = sum(1 for k in range(bi-19, bi+1)
                   if C[k]>C[k-1] and VolMA20[k]>0 and Vol[k]>VolMA20[k])
    uvRatio  = upVolGun / 20
    if   uvRatio >= 0.50: uvScore = 35
    elif uvRatio >= 0.25: uvScore = (uvRatio-0.25)/0.25*30+5
    else:                 uvScore = 0
    print(f"\n  UP HACİM ORANI ({uvScore:.0f}/35):  {upVolGun}/20 gun = {uvRatio:.2f}")
    print(f"  Son 20 gun detayi:")
    for k in range(bi-19, bi+1):
        is_up  = C[k]>C[k-1]
        is_vol = VolMA20[k]>0 and Vol[k]>VolMA20[k]
        flag   = "UP+VOL" if (is_up and is_vol) else ("up    " if is_up else "      ")
        chg    = (C[k]-C[k-1])/C[k-1]*100 if C[k-1]>0 else 0
        print(f"    {tarihler[k]} {flag}  C:{C[k]:.2f}({chg:+.1f}%)  Vol:{Vol[k]:>10.0f}  VMA20:{VolMA20[k]:>10.0f}")

    # ── 3. POCKET PIVOT ───────────────────────────────────────────
    maxDownVol   = max((Vol[k] for k in range(bi-10,bi) if C[k]<C[k-1]), default=0)
    bugun_yukari = C[bi]>C[bi-1]
    vol_buyuk    = maxDownVol>0 and Vol[bi]>maxDownVol
    vol_ort_ust  = VolMA20[bi]>0 and Vol[bi]>VolMA20[bi]
    ppScore = 15 if (bugun_yukari and vol_buyuk and vol_ort_ust) else (8 if (bugun_yukari and vol_buyuk) else 0)
    print(f"\n  POCKET PIVOT ({ppScore}/15):")
    print(f"    yukari={bugun_yukari}  vol>maxDown={vol_buyuk}  vol>ort={vol_ort_ust}")
    print(f"    Vol={Vol[bi]:.0f}  maxDownVol={maxDownVol:.0f}  VMA20={VolMA20[bi]:.0f}")

    # ── 4. VCP ────────────────────────────────────────────────────
    vcpLookback = min(60, bi)
    vcpStart    = bi - vcpLookback

    pivotH, pivotL = [], []
    for k in range(vcpStart+2, bi-1):
        hMax = max(H[k-2:k+3])
        lMin = min(L[k-2:k+3])
        if H[k] == hMax: pivotH.append(H[k])
        if L[k] == lMin: pivotL.append(L[k])

    widths = []
    minPairs = min(len(pivotH), len(pivotL))
    for k in range(min(minPairs-1, 5)):
        hv = pivotH[-(k+1)]
        lv = pivotL[-(k+1)]
        if hv > 0: widths.append((hv-lv)/hv)

    vcpScore = 0
    if len(widths) >= 2:
        vcpScore += 6 if len(widths)>=3 else 3
        narrowCount = sum(1 for k in range(len(widths)-1,0,-1) if widths[k-1]<widths[k]*0.90)
        vcpScore += 6 if narrowCount>=2 else (3 if narrowCount>=1 else 0)
        cut = vcpLookback//3
        earlyVol  = sum(Vol[vcpStart:vcpStart+cut])/max(cut,1)
        recentVol = sum(Vol[bi-cut+1:bi+1])/max(cut,1)
        if earlyVol>0 and recentVol<earlyVol*0.75: vcpScore += 4
        vol5  = sum(Vol[bi-4:bi+1])/5
        vol20 = sum(Vol[bi-19:bi+1])/20
        if vol20>0 and vol5<vol20*0.60: vcpScore += 4

    r_bugun = H[bi]-L[bi]
    isNR7   = all((H[k]-L[k])>r_bugun for k in range(bi-6,bi))
    if isNR7: vcpScore = min(20, vcpScore+4)
    vcpScore = min(20, vcpScore)

    print(f"\n  VCP+NR7 ({vcpScore}/20):")
    print(f"    Pivot sayisi: H={len(pivotH)} L={len(pivotL)}")
    print(f"    Genislikler: {[round(w,3) for w in widths]}")
    print(f"    NR7: {isNR7}  range={r_bugun:.3f}")

    # ── TOPLAM ────────────────────────────────────────────────────
    total = ema_score + uvScore + ppScore + vcpScore
    print(f"\n  {'─'*40}")
    print(f"  EMA:{ema_score}  UV:{uvScore:.0f}  PP:{ppScore}  VCP:{vcpScore}  = {total:.0f}p")
    print(f"  (Mom+Bonus tahmini ~4-8p eklersek: {total+6:.0f}p)")
    print()

    return ema_score, uvScore, ppScore, vcpScore

# ── Ana sembolleri karşılaştır ────────────────────────────────────
# Robot'un bulduğu iyi hisseler vs bulamadığı hisseler
robot_hits   = ["ULUFA", "RALYH", "KAPLM", "DOGUB"]   # HIT5 olanlar
robot_misses = ["ADEL", "TKFEN", "KRDMB"]              # flat/miss olanlar
python_only  = ["METRO", "DAGI", "ASELS", "EDATA"]    # Python buldu Robot bulmadi

print("\n" + "="*65)
print("  ROBOT HIT5 SEMBOLLERİ (neden yakaladı?)")
print("="*65)
for s in robot_hits:
    try: analyze(s)
    except Exception as e: print(f"  {s}: {e}")

print("\n" + "="*65)
print("  ROBOT FLAT/MISS SEMBOLLERİ (neden düşük puan?)")
print("="*65)
for s in robot_misses:
    try: analyze(s)
    except Exception as e: print(f"  {s}: {e}")

print("\n" + "="*65)
print("  PYTHON BULDU, ROBOT BULMADI (neden Python görüyor Robot görmüyor?)")
print("="*65)
for s in python_only:
    try: analyze(s)
    except Exception as e: print(f"  {s}: {e}")
