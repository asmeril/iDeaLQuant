import struct
import datetime
import os
import itertools
from multiprocessing import Pool, cpu_count
import time

# --- Parser ---
RECORD_SIZE = 32
EPOCH_MIN_UTC = datetime.datetime(1988, 2, 15, 21, 0, 0)
TRT_OFFSET = datetime.timedelta(hours=3)

def ts_to_datetime_trt(ts_raw: int) -> datetime.datetime:
    return EPOCH_MIN_UTC + datetime.timedelta(minutes=ts_raw) + TRT_OFFSET

def load_ideal_binary(filepath: str, min_year: int = 2025):
    print(f"[{datetime.datetime.now()}] Dosya okunuyor: {filepath}")
    with open(filepath, "rb") as f:
        data = f.read()
    n = len(data) // RECORD_SIZE
    bars = []
    
    for i in range(n):
        offset = i * RECORD_SIZE
        ts_raw, o, h, l, c, lot_f, tl_f, _pad = struct.unpack_from("<IffffffI", data, offset)
        dt = ts_to_datetime_trt(ts_raw)
        
        if dt.year >= min_year:
            bars.append({
                'dt': dt,
                'open': o,
                'high': h,
                'low': l,
                'close': c
            })
    print(f"[{datetime.datetime.now()}] {min_year} ve sonrasi yillara ait {len(bars)} bar yuklendi.")
    return bars

# --- S8 / S9 Logic Simulators ---

def backtest_s8(bars, min_gap_puan, max_gap_puan, or_bars, stop_buffer, t2_bonus, trailing_dist):
    net_profit = 0.0
    wins = 0
    losses = 0
    max_dd = 0.0
    peak_equity = 0.0
    
    in_pos = 0 # 1 long, -1 short
    entry_price = 0.0
    stop_level = 0.0
    t1_lvl = 0.0
    t2_lvl = 0.0
    t1_hit = False
    best_price = 0.0
    
    gap_active = False
    gap_dir = 0
    or_high = 0.0
    or_low = float('inf')
    or_complete = False
    or_start_bar = -1
    gap_fill_lvl = 0.0
    
    last_aksam_close = 0.0
    prev_is_gun = False
    
    for i in range(1, len(bars)):
        b = bars[i]
        dt = b['dt']
        th = dt.hour + dt.minute / 60.0
        
        is_aksam = 19.0 <= th <= 22.99
        is_gun = (9 + 30/60.0) <= th <= (18 + 10/60.0)
        is_first_gun_bar = is_gun and not prev_is_gun
        prev_is_gun = is_gun
        
        if is_aksam and dt.hour >= 22 and dt.minute >= 55:
            last_aksam_close = b['close']
            
        if is_first_gun_bar:
            if in_pos != 0:
                pnl = (b['open'] - entry_price) if in_pos == 1 else (entry_price - b['open'])
                net_profit += pnl
                if pnl > 0: wins += 1
                else: losses += 1
                if net_profit > peak_equity: peak_equity = net_profit
                if peak_equity - net_profit > max_dd: max_dd = peak_equity - net_profit
                in_pos = 0
                
            ref_close = last_aksam_close if last_aksam_close > 0 else bars[i-1]['close']
            raw_gap = b['open'] - ref_close
            gap_abs = abs(raw_gap)
            
            if min_gap_puan <= gap_abs <= max_gap_puan:
                gap_active = True
                gap_dir = 1 if raw_gap > 0 else -1
                gap_fill_lvl = ref_close
                or_start_bar = i
                or_high = b['high']
                or_low = b['low']
                or_complete = False
            else:
                gap_active = False
            last_aksam_close = 0.0
            
        if gap_active and not or_complete and is_gun:
            elapsed = i - or_start_bar
            if elapsed < or_bars:
                if b['high'] > or_high: or_high = b['high']
                if b['low'] < or_low: or_low = b['low']
            else:
                or_complete = True
                
        # Entry
        if gap_active and or_complete and in_pos == 0:
            or_end_bar = or_start_bar + or_bars
            zaman_ok = (i - or_end_bar) < 120 
            
            if zaman_ok:
                if gap_dir == 1: # YUKARI GAP -> SHORT
                    if b['low'] <= or_low and b['high'] > gap_fill_lvl:
                        in_pos = -1
                        entry_price = min(b['open'], or_low)
                        stop_level = or_high + stop_buffer
                        t1_lvl = gap_fill_lvl
                        t2_lvl = gap_fill_lvl - t2_bonus
                        t1_hit = False
                        best_price = entry_price
                elif gap_dir == -1: # ASAGI GAP -> LONG
                    if b['high'] >= or_high and b['low'] < gap_fill_lvl:
                        in_pos = 1
                        entry_price = max(b['open'], or_high)
                        stop_level = or_low - stop_buffer
                        t1_lvl = gap_fill_lvl
                        t2_lvl = gap_fill_lvl + t2_bonus
                        t1_hit = False
                        best_price = entry_price
                        
        # Exit
        if in_pos == 1:
            if b['high'] > best_price: best_price = b['high']
            if not t1_hit and b['high'] >= t1_lvl:
                t1_hit = True
            stop_now = (best_price - trailing_dist) if t1_hit else stop_level
            
            stop_hit = b['low'] <= stop_now
            t2_hit = b['high'] >= t2_lvl
            zaman_doldu = (i - (or_start_bar+or_bars)) >= 120
            aksam_kapa = is_aksam and th >= (22 + 50/60.0)
            
            if t2_hit or stop_hit or zaman_doldu or aksam_kapa:
                exit_p = t2_lvl if t2_hit else (stop_now if stop_hit else b['close'])
                if t1_hit:
                    pnl = (exit_p - entry_price) + (exit_p - t1_lvl)
                else:
                    pnl = (exit_p - entry_price)
                
                net_profit += pnl
                if pnl > 0: wins += 1
                else: losses += 1
                if net_profit > peak_equity: peak_equity = net_profit
                if peak_equity - net_profit > max_dd: max_dd = peak_equity - net_profit
                
                in_pos = 0
                gap_active = False
                
        elif in_pos == -1:
            if b['low'] < best_price: best_price = b['low']
            if not t1_hit and b['low'] <= t1_lvl:
                t1_hit = True
            stop_now = (best_price + trailing_dist) if t1_hit else stop_level
            
            stop_hit = b['high'] >= stop_now
            t2_hit = b['low'] <= t2_lvl
            zaman_doldu = (i - (or_start_bar+or_bars)) >= 120
            aksam_kapa = is_aksam and th >= (22 + 50/60.0)
            
            if t2_hit or stop_hit or zaman_doldu or aksam_kapa:
                exit_p = t2_lvl if t2_hit else (stop_now if stop_hit else b['close'])
                if t1_hit:
                    pnl = (entry_price - exit_p) + (t1_lvl - exit_p)
                else:
                    pnl = (entry_price - exit_p)
                
                net_profit += pnl
                if pnl > 0: wins += 1
                else: losses += 1
                if net_profit > peak_equity: peak_equity = net_profit
                if peak_equity - net_profit > max_dd: max_dd = peak_equity - net_profit
                
                in_pos = 0
                gap_active = False
                
    total_trades = wins + losses
    pf = (wins / losses) if losses > 0 else 99.0
    return (net_profit, total_trades, max_dd, pf)

def backtest_s9(bars, min_gap_puan, max_gap_puan, or_bars, t1_mult, t2_mult, stop_mult, trail_mult):
    net_profit = 0.0
    wins = 0
    losses = 0
    max_dd = 0.0
    peak_equity = 0.0
    
    in_pos = 0 
    entry_price = 0.0
    stop_level = 0.0
    t1_lvl = 0.0
    t2_lvl = 0.0
    t1_hit = False
    best_price = 0.0
    
    gap_active = False
    gap_dir = 0
    or_high = 0.0
    or_low = float('inf')
    or_complete = False
    or_start_bar = -1
    
    last_aksam_close = 0.0
    prev_is_gun = False
    
    for i in range(1, len(bars)):
        b = bars[i]
        dt = b['dt']
        th = dt.hour + dt.minute / 60.0
        
        is_aksam = 19.0 <= th <= 22.99
        is_gun = (9 + 30/60.0) <= th <= (18 + 10/60.0)
        is_first_gun_bar = is_gun and not prev_is_gun
        prev_is_gun = is_gun
        
        if is_aksam and dt.hour >= 22 and dt.minute >= 55:
            last_aksam_close = b['close']
            
        if is_first_gun_bar:
            if in_pos != 0:
                pnl = (b['open'] - entry_price) if in_pos == 1 else (entry_price - b['open'])
                net_profit += pnl
                if pnl > 0: wins += 1
                else: losses += 1
                if net_profit > peak_equity: peak_equity = net_profit
                if peak_equity - net_profit > max_dd: max_dd = peak_equity - net_profit
                in_pos = 0
                
            ref_close = last_aksam_close if last_aksam_close > 0 else bars[i-1]['close']
            raw_gap = b['open'] - ref_close
            gap_abs = abs(raw_gap)
            
            if min_gap_puan <= gap_abs <= max_gap_puan:
                gap_active = True
                gap_dir = 1 if raw_gap > 0 else -1
                or_start_bar = i
                or_high = b['high']
                or_low = b['low']
                or_complete = False
            else:
                gap_active = False
                
            last_aksam_close = 0.0
            
        if gap_active and not or_complete and is_gun:
            elapsed = i - or_start_bar
            if elapsed < or_bars:
                if b['high'] > or_high: or_high = b['high']
                if b['low'] < or_low: or_low = b['low']
            else:
                or_complete = True
                
        # Giris (Yonde)
        if gap_active and or_complete and in_pos == 0:
            or_end_bar = or_start_bar + or_bars
            zaman_ok = (i - or_end_bar) < 300 
            or_range = or_high - or_low
            
            if zaman_ok and or_range >= 1.0:
                if gap_dir == 1: # YUKARI GAP -> LONG
                    if b['low'] <= or_low:
                        gap_active = False # Reversal calistiysa S9 iptal
                    elif b['high'] >= or_high:
                        in_pos = 1
                        entry_price = max(b['open'], or_high)
                        stop_level = or_high - (or_range * stop_mult)
                        t1_lvl = or_high + (or_range * t1_mult)
                        t2_lvl = or_high + (or_range * t2_mult)
                        t1_hit = False
                        best_price = entry_price
                elif gap_dir == -1: # ASAGI GAP -> SHORT
                    if b['high'] >= or_high:
                        gap_active = False # Reversal calistiysa S9 iptal
                    elif b['low'] <= or_low:
                        in_pos = -1
                        entry_price = min(b['open'], or_low)
                        stop_level = or_low + (or_range * stop_mult)
                        t1_lvl = or_low - (or_range * t1_mult)
                        t2_lvl = or_low - (or_range * t2_mult)
                        t1_hit = False
                        best_price = entry_price
                        
        if in_pos == 1:
            if b['high'] > best_price: best_price = b['high']
            if not t1_hit and b['high'] >= t1_lvl: t1_hit = True
            
            stop_now = (best_price - (or_range * trail_mult)) if t1_hit else stop_level
            stop_hit = b['low'] <= stop_now
            t2_hit = b['high'] >= t2_lvl
            zaman_doldu = (i - (or_start_bar+or_bars)) >= 300
            aksam_kapa = is_aksam and th >= (22 + 50/60.0)
            
            if t2_hit or stop_hit or zaman_doldu or aksam_kapa:
                exit_p = t2_lvl if t2_hit else (stop_now if stop_hit else b['close'])
                if t1_hit:
                    pnl = (exit_p - entry_price) + (exit_p - t1_lvl)
                else:
                    pnl = (exit_p - entry_price)
                
                net_profit += pnl
                if pnl > 0: wins += 1
                else: losses += 1
                if net_profit > peak_equity: peak_equity = net_profit
                if peak_equity - net_profit > max_dd: max_dd = peak_equity - net_profit
                
                in_pos = 0
                gap_active = False
                
        elif in_pos == -1:
            if b['low'] < best_price: best_price = b['low']
            if not t1_hit and b['low'] <= t1_lvl: t1_hit = True
            
            stop_now = (best_price + (or_range * trail_mult)) if t1_hit else stop_level
            stop_hit = b['high'] >= stop_now
            t2_hit = b['low'] <= t2_lvl
            zaman_doldu = (i - (or_start_bar+or_bars)) >= 300
            aksam_kapa = is_aksam and th >= (22 + 50/60.0)
            
            if t2_hit or stop_hit or zaman_doldu or aksam_kapa:
                exit_p = t2_lvl if t2_hit else (stop_now if stop_hit else b['close'])
                if t1_hit:
                    pnl = (entry_price - exit_p) + (t1_lvl - exit_p)
                else:
                    pnl = (entry_price - exit_p)
                
                net_profit += pnl
                if pnl > 0: wins += 1
                else: losses += 1
                if net_profit > peak_equity: peak_equity = net_profit
                if peak_equity - net_profit > max_dd: max_dd = peak_equity - net_profit
                
                in_pos = 0
                gap_active = False
                
    total_trades = wins + losses
    pf = (wins / losses) if losses > 0 else 99.0
    return (net_profit, total_trades, max_dd, pf)


# --- Workers ---
g_bars = []

def init_worker(bars):
    global g_bars
    g_bars = bars

def worker_s8(params):
    p1, p2, p3, p4, p5, p6 = params
    np_val, tr, dd, pf = backtest_s8(g_bars, p1, p2, p3, p4, p5, p6)
    return (params, np_val, tr, dd, pf)

def worker_s9(params):
    p1, p2, p3, p4, p5, p6, p7 = params
    np_val, tr, dd, pf = backtest_s9(g_bars, p1, p2, p3, p4, p5, p6, p7)
    return (params, np_val, tr, dd, pf)

if __name__ == '__main__':
    FILE_PATH = r"D:\iDeal\ChartData\VIP\01\VIP'VIP-X030-T.01"
    
    # 2025 ve sonrasi
    YIL_FILTRESI = 2025 
    bars = load_ideal_binary(FILE_PATH, YIL_FILTRESI)
    
    print("S8 OPTIMIZATION BASLIYOR (Daraltilmis Robust Grid)...")
    s8_grid = list(itertools.product(
        [18, 19, 20, 21, 22],      # min_gap: 20 etrafinda
        range(140, 181, 10),       # max_gap: 140, 150, 160, 170, 180
        [1],                       # or_bars: 1 net robust cikti
        range(45, 66, 5),          # stop_buffer: 45, 50, 55, 60, 65
        range(130, 171, 10),       # t2_bonus: 130, 140, 150, 160, 170
        range(50, 71, 5)           # trailing_dist: 50, 55, 60, 65, 70
    ))
    # Toplam 3,125 Kombinasyon
    
    start_time = time.time()
    with Pool(processes=cpu_count(), initializer=init_worker, initargs=(bars,)) as p:
        results_s8 = p.map(worker_s8, s8_grid)
    
    results_s8.sort(key=lambda x: x[1], reverse=True)
    print(f"S8 Optimizasyon Tamamlandi ({time.time() - start_time:.2f} sn)")
    print("S8 En Iyi 10 Sonuc:")
    for r in results_s8[:10]:
        print(f"Params: min_gap={r[0][0]:.0f}, max_gap={r[0][1]:.0f}, or={r[0][2]:.0f}, stop={r[0][3]:.0f}, t2={r[0][4]:.0f}, trail={r[0][5]:.0f} | NP: {r[1]:.1f}, Trades: {r[2]}, DD: {r[3]:.1f}, PF: {r[4]:.2f}")
    
    print("\nS9 OPTIMIZATION BASLIYOR (Trailing Stop - Genisletilmis Grid)...")
    s9_grid = list(itertools.product(
        [8, 9, 10, 11, 12],        # min_gap
        [200],                     # max_gap (200 is good enough, limit to save time)
        [1],                       # or_bars
        [0.5, 0.8, 1.0, 1.2, 1.5], # t1_mult (Ekleme yeri)
        [4.0, 5.0],                # t2_mult (Ekstrem hedef)
        [1.0, 1.5, 2.0],           # stop_mult (Ilk sabit stop)
        [1.0, 1.5, 2.0, 2.5]       # trail_mult (T1 sonrasi zirveden takip mesafesi)
    ))
    # Toplam: 5 * 1 * 1 * 5 * 2 * 3 * 4 = 600 Kombinasyon
    
    start_time = time.time()
    with Pool(processes=cpu_count(), initializer=init_worker, initargs=(bars,)) as p:
        results_s9 = p.map(worker_s9, s9_grid)
        
    results_s9.sort(key=lambda x: x[1], reverse=True)
    print(f"S9 Optimizasyon Tamamlandi ({time.time() - start_time:.2f} sn)")
    print("S9 En Iyi 3 Sonuc:")
    for r in results_s9[:3]:
        print(f"Params: min_gap={r[0][0]}, max_gap={r[0][1]}, or={r[0][2]}, t1_mult={r[0][3]}, t2_mult={r[0][4]}, stop_mult={r[0][5]}, trail_mult={r[0][6]} | NP: {r[1]:.1f}, Trades: {r[2]}, DD: {r[3]:.1f}, PF: {r[4]:.2f}")
