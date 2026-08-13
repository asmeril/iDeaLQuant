import multiprocessing as mp
import time
import struct
import datetime

# ==============================================================================
# S8 (REVERSAL) YUZDESEL IZLEYEN STOP BACKTEST MOTORU
# ==============================================================================

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
            bars.append({
                'dt': dt,
                'open': o,
                'high': h,
                'low': l,
                'close': c
            })
    return bars

def backtest_s8_pct(args):
    bars, min_gap, max_gap, or_bars, kar_al_yuzde, trail_yuzde = args
    
    in_pos = 0
    entry_price = 0
    extreme_price = 0
    
    gap_active = False
    gap_dir = 0
    or_high = 0
    or_low = 999999
    or_complete = False
    or_start_bar = -1
    last_aksam_close = 0
    prev_is_gun = False
    pos_start_bar = -1
    
    total_puan = 0
    trades = 0
    max_dd = 0
    peak_puan = 0
    gross_profit = 0
    gross_loss = 0

    for i in range(1, len(bars)):
        b = bars[i]
        dt = b['dt']
        th = dt.hour + dt.minute / 60.0
        
        is_aksam = 19.0 <= th <= 22.99
        is_gun = 9.5 <= th <= 18.25
        is_first_gun_bar = is_gun and not prev_is_gun
        prev_is_gun = is_gun
        
        if is_aksam and dt.hour >= 22 and dt.minute >= 55:
            last_aksam_close = b['close']
            
        if is_first_gun_bar:
            if in_pos != 0:
                islem_puan = (b['open'] - entry_price) if in_pos == 1 else (entry_price - b['open'])
                total_puan += islem_puan
                trades += 1
                if islem_puan > 0: gross_profit += islem_puan
                else: gross_loss += abs(islem_puan)
                if total_puan > peak_puan: peak_puan = total_puan
                dd = peak_puan - total_puan
                if dd > max_dd: max_dd = dd
                in_pos = 0

            ref_close = last_aksam_close if last_aksam_close > 0 else bars[i-1]['close']
            raw_gap = b['open'] - ref_close
            gap_abs = abs(raw_gap)
            
            if min_gap <= gap_abs <= max_gap:
                gap_active = True
                gap_dir = 1 if raw_gap > 0 else -1
                or_start_bar = i
                or_high = b['high']
                or_low = b['low']
                or_complete = False
            else:
                gap_active = False
            last_aksam_close = 0
            
        if gap_active and not or_complete and is_gun:
            elapsed_or = i - or_start_bar
            if elapsed_or < or_bars:
                if b['high'] > or_high: or_high = b['high']
                if b['low'] < or_low: or_low = b['low']
            else:
                or_complete = True
                or_range = or_high - or_low
                
        if gap_active and or_complete and in_pos == 0:
            or_end_bar = or_start_bar + or_bars
            zaman_ok = (i - or_end_bar) < 120 # S8 2 saat bekler en fazla entry icin
            or_range = or_high - or_low
            
            if zaman_ok and or_range >= 1.0:
                if gap_dir == 1:
                    # YUKARI GAP -> Asagi Kırılım (Reversal) -> SHORT
                    if b['high'] >= or_high:
                        gap_active = False
                    elif b['low'] <= or_low:
                        in_pos = -1
                        entry_price = min(b['open'], or_low)
                        extreme_price = entry_price
                        pos_start_bar = i
                elif gap_dir == -1:
                    # ASAGI GAP -> Yukari Kırılım (Reversal) -> LONG
                    if b['low'] <= or_low:
                        gap_active = False
                    elif b['high'] >= or_high:
                        in_pos = 1
                        entry_price = max(b['open'], or_high)
                        extreme_price = entry_price
                        pos_start_bar = i

        if in_pos == 1:
            if b['close'] > extreme_price: extreme_price = b['close']
            
            kar_al_hit = (kar_al_yuzde > 0) and (b['close'] >= entry_price * (1 + kar_al_yuzde/100.0))
            stop_hit = (trail_yuzde > 0) and (b['close'] <= extreme_price * (1 - trail_yuzde/100.0))
            zaman_doldu = pos_start_bar > 0 and (i - (or_start_bar+or_bars)) >= 120 # S8 pozisyonda max 120dk kalır
            aksam_kapa = is_aksam and th >= (22 + 50.0 / 60.0)
            
            if kar_al_hit or stop_hit or zaman_doldu or aksam_kapa:
                gercek_cikis = b['close']
                islem_puan = gercek_cikis - entry_price
                total_puan += islem_puan
                trades += 1
                if islem_puan > 0: gross_profit += islem_puan
                else: gross_loss += abs(islem_puan)
                
                if total_puan > peak_puan: peak_puan = total_puan
                dd = peak_puan - total_puan
                if dd > max_dd: max_dd = dd
                in_pos = 0
                gap_active = False
                
        elif in_pos == -1:
            if extreme_price == 0 or b['close'] < extreme_price: extreme_price = b['close']
            
            kar_al_hit = (kar_al_yuzde > 0) and (b['close'] <= entry_price * (1 - kar_al_yuzde/100.0))
            stop_hit = (trail_yuzde > 0) and (b['close'] >= extreme_price * (1 + trail_yuzde/100.0))
            zaman_doldu = pos_start_bar > 0 and (i - (or_start_bar+or_bars)) >= 120
            aksam_kapa = is_aksam and th >= (22 + 50.0 / 60.0)
            
            if kar_al_hit or stop_hit or zaman_doldu or aksam_kapa:
                gercek_cikis = b['close']
                islem_puan = entry_price - gercek_cikis
                total_puan += islem_puan
                trades += 1
                if islem_puan > 0: gross_profit += islem_puan
                else: gross_loss += abs(islem_puan)
                
                if total_puan > peak_puan: peak_puan = total_puan
                dd = peak_puan - total_puan
                if dd > max_dd: max_dd = dd
                in_pos = 0
                gap_active = False

    pf = (gross_profit / gross_loss) if gross_loss > 0 else 99.9
    return (total_puan, max_dd, trades, pf, min_gap, max_gap, or_bars, kar_al_yuzde, trail_yuzde)

def worker_init():
    pass

if __name__ == '__main__':
    data_file = r"D:\iDeal\ChartData\VIP\01\VIP'VIP-X030-T.01"
    bars = load_ideal_binary(data_file, 2025)
    
    kar_al_list = [0.0, 0.5, 1.0, 1.5, 2.0, 2.5, 3.0] 
    trail_list = [0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1.0, 1.2, 1.5]
    
    tasks = []
    for kar_al in kar_al_list:
        for trail in trail_list:
            # S8 min_gap = 18.0 idi (Optimize edilmis sonuclar)
            tasks.append((bars, 18.0, 150.0, 1, kar_al, trail))
            
    print(f"S8 Yüzdesel İzleyen Stop Optimizasyonu Başlıyor... Toplam {len(tasks)} kombinasyon test edilecek.")
    
    with mp.Pool(initializer=worker_init) as pool:
        results = pool.map(backtest_s8_pct, tasks)
        
    results.sort(key=lambda x: x[0], reverse=True)
    
    print("\n--- EN IYI 10 SONUC (S8 REVERSAL YUZDESEL STOP) ---")
    for r in results[:10]:
        total_puan, max_dd, trades, pf, min_gap, max_gap, or_bars, kar_al, trail = r
        print(f"KarAl_Yuzde={kar_al:.1f}%, Trail_Yuzde={trail:.1f}% | Puan: {total_puan:.1f}, DD: {max_dd:.1f}, Trades: {trades}, PF: {pf:.2f}")
