# -*- coding: utf-8 -*-
"""
EOD (Seans Sonu) Sinyal Analizi: 08.04 sonunda yakalanan + 09.04 kapanan pozisyonlar
AmaÃ§: SNIPER'Ä±n ertesi gÃ¼n prim hedefi iÃ§in kriterleri optimize etmek
"""
import os
from datetime import datetime, timedelta
from collections import defaultdict

DB_FILE = r"D:\Projects\Sinyal_Log_Database.txt"

def parse_dt(s):
    """ISO 8601 tarihi parse eder (timezone bilgisini atar)"""
    if not s:
        return None
    s = s.strip()
    # timezone kÄ±smÄ±nÄ± at: +03:00 veya 0000000 uzantÄ±larÄ±
    s = s.split('+')[0].split('Z')[0]
    for fmt in ("%Y-%m-%dT%H:%M:%S.%f", "%Y-%m-%dT%H:%M:%S", "%d.%m.%Y %H:%M:%S"):
        try:
            return datetime.strptime(s, fmt)
        except:
            continue
    return None

def parse_float(s):
    if not s or not s.strip():
        return 0.0
    try:
        return float(s.strip().replace(',', '.'))
    except:
        return 0.0

lines = open(DB_FILE, encoding='utf-8', errors='ignore').readlines()

trades = []
for line in lines:
    line = line.strip()
    if not line or line.startswith('Sembol'):  # header satÄ±rÄ±nÄ± atla
        continue
    cols = line.split('|')
    if len(cols) < 6:
        continue
    giris_dt = parse_dt(cols[3])
    if not giris_dt:
        continue
    pnl = parse_float(cols[8]) if len(cols) > 8 else 0.0
    max_pnl = parse_float(cols[10]) if len(cols) > 10 else 0.0
    cikis_dt = parse_dt(cols[6]) if len(cols) > 6 else None
    durum = cols[5].strip()
    # DB'de "AKTIF" veya "KAPALI" yazÄ±yor
    trades.append({
        'sembol': cols[0],
        'strateji': cols[1],
        'periyot': cols[2],
        'giris_dt': giris_dt,
        'giris_fiyat': parse_float(cols[4]),
        'durum': durum,
        'cikis_dt': cikis_dt,
        'cikis_fiyat': parse_float(cols[7]) if len(cols) > 7 else 0.0,
        'pnl': pnl,
        'sebep': cols[9].strip() if len(cols) > 9 else '',
        'max_pnl': max_pnl,
    })

# === 0. GENEL BAKIÅ ===
print("=" * 60)
print("TOPLAM: {} satÄ±r yÃ¼klendi".format(len(trades)))
tarihler = sorted(set(t['giris_dt'].date() for t in trades))
print("Tarihler: {}".format(tarihler))

# === 1. EOD GÄ°RÄ°Å ANALÄ°ZÄ° (saat >= 14:00 giriÅŸler) ===
print("\n=== 1. EOD GÄ°RÄ°Å SAATI DAÄILIMI (>= 14:00) ===")
eod_trades = [t for t in trades if t['giris_dt'].hour >= 14]
print("14:00+ giren sinyal: {}".format(len(eod_trades)))

# BunlarÄ±n 09.04 sabahÄ± kapananlar
uzun_gece = [t for t in eod_trades if t['cikis_dt'] and t['cikis_dt'].date() > t['giris_dt'].date()]
ayni_gun = [t for t in eod_trades if t['cikis_dt'] and t['cikis_dt'].date() == t['giris_dt'].date()]
aktif_kalan = [t for t in eod_trades if t['durum'] == 'AKTIF']

print("  Gece bekleyip ertesi gÃ¼n kapanan: {}".format(len(uzun_gece)))
print("  AynÄ± gÃ¼n kapanan (EOD girip hÄ±zlÄ± Ã§Ä±kÄ±ÅŸ): {}".format(len(ayni_gun)))
print("  HÃ¢lÃ¢ AKTIF (henÃ¼z kapanmadÄ±): {}".format(len(aktif_kalan)))

# === 2. GECE KALAN POZÄ°SYONLARIN PERFORMANSI ===
print("\n=== 2. GECE KALAN POZÄ°SYONLAR: KAPANIÅ PERFORMANSI ===")
if uzun_gece:
    kazanan = [t for t in uzun_gece if t['pnl'] > 0]
    kaybeden = [t for t in uzun_gece if t['pnl'] <= 0]
    print("  KapandÄ±: {} | Kazanan: {} ({:.1f}%) | Kaybeden: {} ({:.1f}%)".format(
        len(uzun_gece), len(kazanan), 100*len(kazanan)/len(uzun_gece),
        len(kaybeden), 100*len(kaybeden)/len(uzun_gece)
    ))
    toplam_pnl = sum(t['pnl'] for t in uzun_gece)
    ort_pnl = toplam_pnl / len(uzun_gece)
    ort_max = sum(t['max_pnl'] for t in uzun_gece) / len(uzun_gece)
    print("  Toplam PnL: {:.2f}% | Ortalama: {:.2f}% | Ort MaxPnL: {:.2f}%".format(
        toplam_pnl, ort_pnl, ort_max))
    
    # Sebep daÄŸÄ±lÄ±mÄ±
    sebep_dag = defaultdict(int)
    for t in uzun_gece:
        s = t['sebep'] if t['sebep'] else 'BILINMIYOR'
        # Ä°ZL.STOP, KAR_AL, STOP vs.
        sebep_dag[s] += 1
    print("\n  Ã‡Ä±kÄ±ÅŸ Sebebi DaÄŸÄ±lÄ±mÄ±:")
    for s, c in sorted(sebep_dag.items(), key=lambda x: -x[1]):
        print("    {:20s}: {}".format(s, c))

# === 3. STRATEJÄ° x PERÄ°YOT KIRILIMLARI (gece kalanlar) ===
print("\n=== 3. STRATEJÄ° x PERÄ°YOT (gece kalanlar) ===")
if uzun_gece:
    sp_groups = defaultdict(list)
    for t in uzun_gece:
        key = "{}-{}dk".format(t['strateji'], t['periyot'])
        sp_groups[key].append(t)
    for key in sorted(sp_groups.keys()):
        grp = sp_groups[key]
        kazan = [t for t in grp if t['pnl'] > 0]
        tp = sum(t['pnl'] for t in grp)
        mx = sum(t['max_pnl'] for t in grp) / len(grp)
        print("  {:20s}: {} trade | Win:{:.1f}% | PnL:{:+.2f}% | AvgMax:{:.2f}%".format(
            key, len(grp), 100*len(kazan)/len(grp), tp, mx))

# === 4. EOD SNIPER DETAY: MaxPnL daÄŸÄ±lÄ±mÄ± ===
print("\n=== 4. EOD SNIPER GECE KALAN: MaxPnL PROFÄ°LÄ° ===")
sniper_gece = [t for t in uzun_gece if t['strateji'] == 'SNIPER']
if sniper_gece:
    for threshold in [0.0, 0.5, 1.0, 1.5, 2.0, 3.0]:
        count = sum(1 for t in sniper_gece if t['max_pnl'] >= threshold)
        print("  MaxPnL>={:.1f}%: {} / {} ({:.1f}%)".format(
            threshold, count, len(sniper_gece), 100*count/len(sniper_gece)))
    print("\n  SNIPER gece kalan Win/Lose:")
    kazan = [t for t in sniper_gece if t['pnl'] > 0]
    kaybe = [t for t in sniper_gece if t['pnl'] <= 0]
    print("  Kazanan: {} ({:.1f}%) | Ortalama PnL: {:.2f}%".format(
        len(kazan), 100*len(kazan)/len(sniper_gece), 
        sum(t['pnl'] for t in sniper_gece)/len(sniper_gece)))
    
    # Periyot bazlÄ±
    for p in ['15', '60', '240', 'G']:
        grp = [t for t in sniper_gece if t['periyot'] == p]
        if grp:
            k = [t for t in grp if t['pnl'] > 0]
            print("  {}dk: {} trade | Win:{:.1f}% | AvgPnL:{:.2f}% | AvgMax:{:.2f}%".format(
                p, len(grp), 100*len(k)/len(grp),
                sum(t['pnl'] for t in grp)/len(grp),
                sum(t['max_pnl'] for t in grp)/len(grp)))

# === 5. BÃœTÃœN AKTIF (09.04) DURUMU ===
print("\n=== 5. HÃ‚LÃ‚ AKTIF POZÄ°SYONLAR (ertesi gÃ¼n aÃ§Ä±k) ===")
aktif_09 = [t for t in trades if t['durum'] == 'AKTIF']
print("Toplam AKTIF: {}".format(len(aktif_09)))
by_strategy = defaultdict(list)
for t in aktif_09:
    by_strategy[t['strateji']].append(t)
for s in sorted(by_strategy.keys()):
    grp = by_strategy[s]
    by_per = defaultdict(list)
    for t in grp:
        by_per[t['periyot']].append(t)
    per_str = " | ".join("{}: {}".format(p, len(v)) for p, v in sorted(by_per.items()))
    print("  {}: {} adet ({})".format(s, len(grp), per_str))

# === 6. SAAT x BAÅARI MATRISI (tÃ¼m kapanmÄ±ÅŸlar) ===
print("\n=== 6. GÄ°RÄ°Å SAATI x BAÅARI (tÃ¼m kapananlar) ===")
kapali = [t for t in trades if t['durum'] == 'KAPALI']
saat_grp = defaultdict(list)
for t in kapali:
    saat_grp[t['giris_dt'].hour].append(t)
print("  Saat | Cnt | Win%  | TotPnL | AvgMax")
for s in sorted(saat_grp.keys()):
    grp = saat_grp[s]
    k = [t for t in grp if t['pnl'] > 0]
    tp = sum(t['pnl'] for t in grp)
    mx = sum(t['max_pnl'] for t in grp) / len(grp)
    print("  {:5d}| {:3d} | {:5.1f}%| {:+7.2f}%| {:.2f}%".format(
        s, len(grp), 100*len(k)/len(grp), tp, mx))

# === 7. ERTESI GÃœN AÃ‡ILIÅI ANALÄ°ZÄ°: Gece kalan pozisyonlarÄ±n ertesi sabah aÃ§Ä±lÄ±ÅŸÄ± ===
print("\n=== 7. OVERNIGHT HOLD: CÄ°KÄ°Å SAATI DAÄILIMI ===")
if uzun_gece:
    cikis_saat_grp = defaultdict(list)
    for t in uzun_gece:
        if t['cikis_dt']:
            cikis_saat_grp[t['cikis_dt'].hour].append(t)
    print("  CikisSaat | Cnt | Win%  | TotPnL | AvgMax | Sebeplar")
    for s in sorted(cikis_saat_grp.keys()):
        grp = cikis_saat_grp[s]
        k = [t for t in grp if t['pnl'] > 0]
        tp = sum(t['pnl'] for t in grp)
        mx = sum(t['max_pnl'] for t in grp) / len(grp)
        sebep_counts = defaultdict(int)
        for t in grp:
            sebep_counts[t['sebep'] or '?'] += 1
        top_sebep = sorted(sebep_counts.items(), key=lambda x: -x[1])[:3]
        sebep_str = ", ".join("{}:{}".format(sb, cnt) for sb, cnt in top_sebep)
        print("  {:10d}| {:3d} | {:5.1f}%| {:+7.2f}%| {:.2f}% | {}".format(
            s, len(grp), 100*len(k)/len(grp), tp, mx, sebep_str))

# === 8. EOD GÄ°RÄ°Å MAX_PNL vs PNL: KaÃ§an fÄ±rsat notu ===
print("\n=== 8. EOD GÄ°RÄ°Å (>=14:00) MaxPnL vs GerÃ§eleÅŸen PnL ===")
if eod_trades:
    kapali_eod = [t for t in eod_trades if t['durum'] == 'KAPALI']
    if kapali_eod:
        max_pnl_ortalama = sum(t['max_pnl'] for t in kapali_eod) / len(kapali_eod)
        pnl_ortalama = sum(t['pnl'] for t in kapali_eod) / len(kapali_eod)
        kayip = sum(t['max_pnl'] - t['pnl'] for t in kapali_eod) / len(kapali_eod)
        print("  Kapanan EOD: {} | AvgMaxPnL: {:.2f}% | AvgPnL: {:.2f}% | KaÃ§an/trade: {:.2f}%".format(
            len(kapali_eod), max_pnl_ortalama, pnl_ortalama, kayip
        ))

# === 9. ERTESI GUN PRIME KATKILARI ===
print("\n=== 9. ERTESI GÃœN PRÄ°M ANALIZI (08.04 giriÅŸ â†’ 09.04 kapaniÅŸ) ===")
prim = [t for t in uzun_gece if t['cikis_dt'] and t['cikis_dt'].date() >= datetime(2026, 4, 9).date()]
print("  09.04 kapanan overnight: {}".format(len(prim)))
if prim:
    kazanan = [t for t in prim if t['pnl'] > 0]
    print("  Win: {} ({:.1f}%) | Avg PnL: {:.2f}% | Avg MaxPnL: {:.2f}%".format(
        len(kazanan), 100*len(kazanan)/len(prim),
        sum(t['pnl'] for t in prim)/len(prim),
        sum(t['max_pnl'] for t in prim)/len(prim)
    ))
    # Periyot kÄ±rÄ±lÄ±mÄ±
    for p in ['15', '60', '240']:
        grp = [t for t in prim if t['periyot'] == p]
        if grp:
            k = [t for t in grp if t['pnl'] > 0]
            print("  {}dk: {} trade | Win:{:.1f}% | PnL:{:+.2f}% | AvgMax:{:.2f}%".format(
                p, len(grp), 100*len(k)/len(grp),
                sum(t['pnl'] for t in grp)/len(grp),
                sum(t['max_pnl'] for t in grp)/len(grp)))
    
    # Strateji kÄ±rÄ±lÄ±mÄ± overnight iÃ§in
    print("\n  Strateji bazlÄ± (gece kalan):")
    for strat in ['SNIPER', 'ANKA', 'KING', 'BOMBA', 'TEFO', 'DIP_V2', 'ZIRVE_V2']:
        grp = [t for t in prim if t['strateji'] == strat]
        if grp:
            k = [t for t in grp if t['pnl'] > 0]
            print("  {:12s}: {} trade | Win:{:.1f}% | PnL:{:+.2f}% | AvgMax:{:.2f}%".format(
                strat, len(grp), 100*len(k)/len(grp),
                sum(t['pnl'] for t in grp)/len(grp),
                sum(t['max_pnl'] for t in grp)/len(grp)))

# === 10. SNIPER EOD: En iyi ve en kÃ¶tÃ¼ semboller ===
print("\n=== 10. SNIPER GECE KALAN: EN Ä°YÄ°/KÃ–TÃœ SEMBOLLER ===")
if sniper_gece:
    sniper_kapali = [t for t in sniper_gece if t['durum'] == 'KAPALI']
    if sniper_kapali:
        sniper_sirali = sorted(sniper_kapali, key=lambda x: x['pnl'], reverse=True)
        print("  EN Ä°YÄ° 5:")
        for t in sniper_sirali[:5]:
            print("    {} | {}dk | GirisSaat:{} | PnL:{:+.2f}% | Max:{:.2f}% | {}".format(
                t['sembol'], t['periyot'],
                t['giris_dt'].strftime("%H:%M"),
                t['pnl'], t['max_pnl'], t['sebep']))
        print("  EN KÃ–TÃœ 5:")
        for t in sniper_sirali[-5:]:
            print("    {} | {}dk | GirisSaat:{} | PnL:{:+.2f}% | Max:{:.2f}% | {}".format(
                t['sembol'], t['periyot'],
                t['giris_dt'].strftime("%H:%M"),
                t['pnl'], t['max_pnl'], t['sebep']))

print("\n=== ANALÄ°Z TAMAMLANDI ===")

