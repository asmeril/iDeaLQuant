import struct
import datetime

RECORD_SIZE = 32
EPOCH_MIN_UTC = datetime.datetime(1988, 2, 15, 21, 0, 0)
TRT_OFFSET = datetime.timedelta(hours=3)

def ts_to_datetime_trt(ts_raw: int) -> datetime.datetime:
    return EPOCH_MIN_UTC + datetime.timedelta(minutes=ts_raw) + TRT_OFFSET

def load_ideal_binary(filepath: str, min_year: int = 2025):
    with open(filepath, "rb") as f:
        data = f.read()
    n = len(data) // RECORD_SIZE
    bars = []
    for i in range(n):
        offset = i * RECORD_SIZE
        ts_raw, o, h, l, c, lot_f, tl_f, _pad = struct.unpack_from("<IffffffI", data, offset)
        dt = ts_to_datetime_trt(ts_raw)
        if dt.year >= min_year:
            bars.append({'dt': dt, 'open': o, 'high': h, 'low': l, 'close': c})
    return bars

def backtest_s8(bars, min_gap_puan, max_gap_puan, or_bars, stop_buffer, t2_bonus, trailing_dist):
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
                
        if gap_active and or_complete and in_pos == 0:
            or_end_bar = or_start_bar + or_bars
            zaman_ok = (i - or_end_bar) < 120 
            
            if zaman_ok:
                if gap_dir == 1:
                    if b['low'] <= or_low:
                        in_pos = -1
                        entry_price = min(b['open'], or_low)
                        stop_level = or_low + stop_buffer
                        t1_lvl = gap_fill_lvl
                        t2_lvl = t1_lvl - t2_bonus
                        t1_hit = False
                        best_price = entry_price
                elif gap_dir == -1:
                    if b['high'] >= or_high:
                        in_pos = 1
                        entry_price = max(b['open'], or_high)
                        stop_level = or_high - stop_buffer
                        t1_lvl = gap_fill_lvl
                        t2_lvl = t1_lvl + t2_bonus
                        t1_hit = False
                        best_price = entry_price
                        
        if in_pos == 1:
            if b['high'] > best_price: best_price = b['high']
            if not t1_hit and b['high'] >= t1_lvl: t1_hit = True
            
            stop_now = stop_level
            if t1_hit: stop_now = best_price - trailing_dist
            
            stop_hit = b['low'] <= stop_now
            t2_hit = b['high'] >= t2_lvl
            zaman_doldu = (i - (or_start_bar + or_bars)) >= 120
            aksam_kapa = is_aksam and th >= (22 + 50/60.0)
            
            if t2_hit or stop_hit or zaman_doldu or aksam_kapa:
                gercek_cikis = t2_lvl if t2_hit else (stop_now if stop_hit else b['close'])
                pnl = gercek_cikis - entry_price
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
            
            stop_now = stop_level
            if t1_hit: stop_now = best_price + trailing_dist
            
            stop_hit = b['high'] >= stop_now
            t2_hit = b['low'] <= t2_lvl
            zaman_doldu = (i - (or_start_bar + or_bars)) >= 120
            aksam_kapa = is_aksam and th >= (22 + 50/60.0)
            
            if t2_hit or stop_hit or zaman_doldu or aksam_kapa:
                gercek_cikis = t2_lvl if t2_hit else (stop_now if stop_hit else b['close'])
                pnl = entry_price - gercek_cikis
                net_profit += pnl
                if pnl > 0: wins += 1
                else: losses += 1
                
                if net_profit > peak_equity: peak_equity = net_profit
                if peak_equity - net_profit > max_dd: max_dd = peak_equity - net_profit
                
                in_pos = 0
                gap_active = False
                
    trades = wins + losses
    pf = (wins / losses) if losses > 0 else 99.9
    return net_profit, max_dd, trades, pf

if __name__ == '__main__':
    data_file = r"D:\iDeal\ChartData\VIP\01\VIP'VIP-X030-T.01"
    bars = load_ideal_binary(data_file, 2025)
    np_val, max_dd, trades, pf = backtest_s8(bars, 18.0, 150.0, 1, 55.0, 150.0, 60.0)
    print(f"S8 FIXED TARGETS: Puan: {np_val:.1f}, DD: {max_dd:.1f}, Trades: {trades}")
