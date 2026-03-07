# -*- coding: utf-8 -*-
import sys
import os
import numpy as np
import pandas as pd

# Proje kök dizini
sys.path.insert(0, os.path.abspath(os.path.join(os.path.dirname(__file__), '..')))

from src.optimization.strategy5_optimizer import IndicatorCache, fast_backtest_strategy5
from src.engine.data import OHLCV

def run_robust_test():
    # 1. PARAMETRELER (Analizden gelen en sağlam set)
    # TOMA_P=1, TOMA_Y=2.9, HH=6, KAR_AL_Y=2.25, IZ_STOP_Y=2.00, ATR_MA=6
    params = {
        'ema_fast': 10,  # HH (Breakout) periyodu 6 ise EMA fast genelde 10-20 arasıdır
        'ema_slow': 50,  # Klasik Oliver Kell
        'breakout_period': 6,
        'adx_period': 14,
        'adx_threshold': 20.0,
        'vol_ma_period': 20,
        'trailing_stop_pct': 2.0, # IZ_STOP_Y=2.00
        'yon_modu': 1 # SADECE_AL (Spot Market)
    }

    print(f"--- S5 Robust Test Calistiriliyor ---")
    print(f"Parametreler: {params}")

    # 2. VERİ YÜKLEME 
    csv_path = r"D:\Projects\IdealQuant\data\ideal_ind_export.csv"
    
    try:
        # custom loading for semicolon csv
        df = pd.read_csv(csv_path, sep=';')
        # Map columns: Close -> close, Date+Time -> datetime, Hacim -> volume
        df['datetime'] = pd.to_datetime(df['Date'] + ' ' + df['Time'], dayfirst=True)
        df.rename(columns={'Close': 'close', 'Hacim': 'volume', 'Yuksek': 'high', 'Dusuk': 'low'}, inplace=True)
        
        # Eğer Yuksek/Dusuk yoksa (headerda gorunmuyor ama Oliver Kell icin lazim)
        # Genelde ideal ind exportunda bunlar Close'a esit veya eksik olabilir.
        # Kontrol edelim
        if 'high' not in df.columns: df['high'] = df['close']
        if 'low' not in df.columns: df['low'] = df['close']
        
        print(f"Sembol: {csv_path.split('\\')[-1]} | Bar Sayisi: {len(df)}")
        
        # Spot piyasa için vade geçişi olmaz (maske hep True)
        mask = np.ones(len(df), dtype=bool)
        times_arr = df['datetime'].astype('datetime64[s]').astype(np.int64).values
        
        # Göstergeler
        cache = IndicatorCache(df)

        ema_fast_arr = cache.get_ema(params['ema_fast'])
        ema_slow_arr = cache.get_ema(params['ema_slow'])
        adx_arr = cache.get_adx(params['adx_period'])
        hhv_arr = cache.get_hhv(params['breakout_period'])
        llv_arr = cache.get_llv(params['breakout_period'])
        vol_ma_arr = cache.get_vol_ma(params['vol_ma_period'])
        
        # 3. BACKTEST
        res = fast_backtest_strategy5(
            cache.closes, cache.highs, cache.lows, cache.volume,
            ema_fast_arr, ema_slow_arr,
            adx_arr, hhv_arr, llv_arr, vol_ma_arr,
            mask, times_arr,
            params['adx_threshold'], params['trailing_stop_pct'] / 100.0,
            params['yon_modu']
        )
        
        net_profit, trades, pf, max_dd, sharpe, active_days, total_days = res
        
        print("\n--- TEST SONUÇLARI ---")
        print(f"Net Kar/Zarar: {net_profit:,.2f}")
        print(f"İşlem Sayısı: {trades}")
        print(f"Profit Factor: {pf:.2f}")
        print(f"Max Drawdown: {max_dd:,.2f}")
        print(f"Sharpe Ratio: {sharpe:.2f}")
        print(f"Aktif Gün / Toplam Gün: {active_days} / {total_days}")
        
    except Exception as e:
        print(f"ERROR: {e}")

if __name__ == "__main__":
    run_robust_test()
