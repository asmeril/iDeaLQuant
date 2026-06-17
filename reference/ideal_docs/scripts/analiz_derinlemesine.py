from collections import defaultdict
from datetime import datetime

with open('D:/Projects/Sinyal_Log_Database.txt', encoding='utf-8') as f:
    lines = f.readlines()

kapali = []
for line in lines:
    line = line.strip()
    if not line: continue
    cols = line.split('|')
    if len(cols) < 10: continue
    if cols[5] != 'KAPALI': continue
    try:
        tarih_str = cols[3]
        t = None
        for fmt in ('%Y-%m-%dT%H:%M:%S.%f', '%d.%m.%Y %H:%M:%S', '%Y-%m-%dT%H:%M:%S'):
            try:
                t = datetime.strptime(tarih_str[:19], fmt[:19])
                break
            except:
                pass
        if t is None:
            continue
        pnl = float(cols[8].replace(',','.'))
        maxpnl = float(cols[10].replace(',','.')) if len(cols)>10 and cols[10].strip() else 0
        kapali.append({
            'sembol': cols[0], 'strat': cols[1], 'per': cols[2],
            'tarih': t, 'pnl': pnl, 'maxpnl': maxpnl, 'sebep': cols[9],
            'saat': t.hour
        })
    except:
        pass

print(f"Analiz edilen: {len(kapali)} kapali trade")
print()

# 1. SAAT BAZLI PERFORMANS
print("=== 1. SAAT BAZLI PERFORMANS (Giris Saati) ===")
saat_data = defaultdict(list)
for t in kapali:
    saat_data[t['saat']].append(t['pnl'])
for s in sorted(saat_data.keys()):
    pnls = saat_data[s]
    kaz = sum(1 for p in pnls if p > 0)
    ort = sum(pnls) / len(pnls)
    top = sum(pnls)
    print(f"  {s:02d}:xx  {len(pnls):>4} trade  Win:{kaz/len(pnls)*100:>5.1f}%  Ort:{ort:>+6.2f}%  Toplam:{top:>+8.1f}%")
print()

# 2. PERIYOT BAZLI
print("=== 2. PERİYOT BAZLI PERFORMANS ===")
per_data = defaultdict(list)
for t in kapali:
    per_data[t['per']].append(t['pnl'])
for p in sorted(per_data.keys()):
    pnls = per_data[p]
    kaz = sum(1 for x in pnls if x > 0)
    ort = sum(pnls) / len(pnls)
    top = sum(pnls)
    print(f"  {p:<5}  {len(pnls):>4} trade  Win:{kaz/len(pnls)*100:>5.1f}%  Ort:{ort:>+6.2f}%  Toplam:{top:>+8.1f}%")
print()

# 3. KAZANAN vs KAYBEDEN MaxPnL profili
kazananlar = [t for t in kapali if t['pnl'] > 0]
kaybedenler = [t for t in kapali if t['pnl'] < 0]
print("=== 3. KAZANAN vs KAYBEDEN MaxPnL PROFİLİ ===")
k_maxpnl_ort = sum(t['maxpnl'] for t in kazananlar) / len(kazananlar)
y_maxpnl_ort = sum(t['maxpnl'] for t in kaybedenler) / len(kaybedenler)
k_pnl_ort = sum(t['pnl'] for t in kazananlar) / len(kazananlar)
print(f"  Kazanan ort MaxPnL: {k_maxpnl_ort:.2f}%")
print(f"  Kaybeden ort MaxPnL: {y_maxpnl_ort:.2f}%")
hic_yok = sum(1 for t in kaybedenler if t['maxpnl'] == 0)
print(f"  Kaybedenlerden MaxPnL=0: {hic_yok}/{len(kaybedenler)} ({hic_yok/len(kaybedenler)*100:.1f}%)")
top_k = sum(t['pnl'] for t in kazananlar)
top_maxpnl_k = sum(t['maxpnl'] for t in kazananlar)
print(f"  Kazananlar ort cikis: +{k_pnl_ort:.2f}%  MaxPnL ort: {k_maxpnl_ort:.2f}%")
print(f"  Toplam MaxPnL/PnL orani (kazananlar): {top_maxpnl_k/max(top_k,0.001):.2f}x -- ne kadar firsat birakildi")
print()

# 4. SINYAL SAATI vs SONUC
print("=== 4. SAAT DİLİMİ vs SONUÇ ===")
oncesi  = [t for t in kapali if t['saat'] < 15]
ortasi  = [t for t in kapali if 15 <= t['saat'] < 17]
sonrasi = [t for t in kapali if t['saat'] >= 17]
for label, grp in [('10-14:xx (sabah/oglen)', oncesi), ('15-16:xx (ogleden sonra)', ortasi), ('17-18:xx (kapanis)', sonrasi)]:
    if not grp:
        continue
    kaz = sum(1 for t in grp if t['pnl'] > 0)
    ort = sum(t['pnl'] for t in grp) / len(grp)
    print(f"  {label}: {len(grp)} trade | Win:{kaz/len(grp)*100:.1f}% | Ort PnL:{ort:+.2f}%")
print()

# 5. STRATEJİ + SAAT
print("=== 5. STRATEJİ + SAAT DİLİMİ ===")
for strat in ['SNIPER', 'ANKA', 'K+B+T', 'K+T', 'B+T', 'K+B']:
    s_grp = [t for t in kapali if t['strat'] == strat]
    if not s_grp:
        continue
    erken = [t for t in s_grp if t['saat'] < 15]
    orta  = [t for t in s_grp if 15 <= t['saat'] < 17]
    gec   = [t for t in s_grp if t['saat'] >= 17]
    for label2, grp2 in [('SABAH', erken), ('ORTA', orta), ('GEC', gec)]:
        if not grp2:
            continue
        kaz = sum(1 for t in grp2 if t['pnl'] > 0)
        ort = sum(t['pnl'] for t in grp2) / len(grp2)
        print(f"  {strat:<12} {label2:<6} {len(grp2):>3} trade  Win:{kaz/len(grp2)*100:>5.1f}%  Ort:{ort:>+5.2f}%")
print()

# 6. ENDEKS MODU EKSİKLİĞİ (SNIPER)
print("=== 6. SNIPER PİYASA MODU YOK ===")
sniper = [t for t in kapali if t['strat'] == 'SNIPER']
kt     = [t for t in kapali if t['strat'] == 'K+T']
kbt    = [t for t in kapali if t['strat'] == 'K+B+T']
for label3, grp3 in [('SNIPER (modu yok)', sniper), ('K+T (modlu)', kt), ('K+B+T (modlu)', kbt)]:
    if not grp3:
        continue
    kaz = sum(1 for t in grp3 if t['pnl'] > 0)
    ort = sum(t['pnl'] for t in grp3) / len(grp3)
    print(f"  {label3:<22}: {len(grp3):>4} trade | Win:{kaz/len(grp3)*100:.1f}% | Ort:{ort:+.2f}%")
print()

# 7. DÖNÜŞÜM: Potansiyel vs gerçekleşen
print("=== 7. POTANSIYEL vs GERÇEKLEŞEN DÖNÜŞÜM ===")
for thr in [0.5, 1.0, 1.5, 2.0]:
    gercek = sum(1 for t in kapali if t['pnl'] >= thr)
    potans = sum(1 for t in kapali if t['maxpnl'] >= thr)
    donusm = gercek / max(potans, 1) * 100
    print(f"  PnL>={thr:.1f}% gerceklesen: {gercek:>4} | MaxPnL>={thr:.1f}% potansiyel: {potans:>4} | Donusum: {donusm:>5.1f}%")
print()

# 8. K+T neden bu kadar iyi? Profil analizi
print("=== 8. K+T NEDEN İYİ? vs SNIPER ===")
for strat, label4 in [('K+T','K+T (en iyi)'), ('SNIPER','SNIPER (sorunlu)')]:
    g = [t for t in kapali if t['strat'] == strat]
    if not g:
        continue
    kaz = [t for t in g if t['pnl'] > 0]
    kay = [t for t in g if t['pnl'] < 0]
    kaz_maxpnl = sum(t['maxpnl'] for t in kaz) / len(kaz) if kaz else 0
    kay_maxpnl = sum(t['maxpnl'] for t in kay) / len(kay) if kay else 0
    m0 = sum(1 for t in kay if t['maxpnl'] == 0)
    print(f"  {label4}:")
    print(f"    Win:{len(kaz)}/{len(g)} ({len(kaz)/len(g)*100:.1f}%)  Kaz_MaxPnL_ort:{kaz_maxpnl:.2f}%  Kay_MaxPnL_ort:{kay_maxpnl:.2f}%  MaxPnL=0:{m0}/{len(kay)}")
print()

# 9. KAÇIRILAN FIRSAT - izl stop
print("=== 9. IZLSTOP: KAÇIRILAN FIRSAT ===")
izl = [t for t in kapali if 'ZL' in t['sebep']]
izl_erken = [t for t in izl if t['maxpnl'] > t['pnl'] + 1.0]
print(f"  IZLSTOP toplam: {len(izl)}")
print(f"  MaxPnL > PnL+1.0% (cok erken kapandi): {len(izl_erken)} ({len(izl_erken)/len(izl)*100:.1f}%)")
if izl_erken:
    kac = sum(t['maxpnl'] - t['pnl'] for t in izl_erken) / len(izl_erken)
    print(f"  Ortalama kacirildi: {kac:.2f}% / trade")
print()

# 10. SEMBOL TEKRARI
print("=== 10. AYNI SEMBOL FARKLI STRATEJİ (Korelasyon Riski) ===")
gun_groups = defaultdict(list)
for t in kapali:
    gun_groups[t['tarih'].date()].append(t)
cok_tekrar = 0
for gun, trades in gun_groups.items():
    sembol_sayac = defaultdict(int)
    for t in trades:
        sembol_sayac[t['sembol']] += 1
    for s, cnt in sembol_sayac.items():
        if cnt >= 3:
            cok_tekrar += 1
print(f"  Ayni sembol ayni gun 3+ sinyal: {cok_tekrar} sembol-gun kombinasyonu")
ort_gun = sum(len(v) for v in gun_groups.values()) / len(gun_groups)
print(f"  Ortalama sinyal/gun: {ort_gun:.1f} -- cok fazla sinyal kalite dusuruyor mu?")
print()

# 11. SPESIFIK SORUN: SNIPER'da piyasa skoru yok - simulation
print("=== 11. SNIPER EKSIK: Piyasa skoru yok (simülasyon) ===")
# Her günün sniper trades'ini al
gun_sniper = defaultdict(list)
for t in kapali:
    if t['strat'] == 'SNIPER':
        gun_sniper[t['tarih'].date()].append(t)

gun_win_rates = []
for gun, trades in sorted(gun_sniper.items()):
    kaz = sum(1 for t in trades if t['pnl'] > 0)
    wr = kaz / len(trades) * 100
    gun_win_rates.append((gun, len(trades), wr))

# Kötü günler (win < 30%) vs iyi günler
kotu_gunler = [(g, n, w) for g, n, w in gun_win_rates if w < 30 and n >= 3]
iyi_gunler  = [(g, n, w) for g, n, w in gun_win_rates if w > 55 and n >= 3]
print(f"  Kotu gun (win<%30, en az 3 trade): {len(kotu_gunler)}")
print(f"  Iyi  gun (win>%55, en az 3 trade): {len(iyi_gunler)}")
if kotu_gunler:
    print(f"  Kotu gunler ornegi: {kotu_gunler[:5]}")
if iyi_gunler:
    print(f"  Iyi gunler ornegi:  {iyi_gunler[:5]}")
