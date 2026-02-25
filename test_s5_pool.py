import sys
import os
import pandas as pd
from src.engine.data import OHLCV
from src.optimization.hybrid_group_optimizer import HybridGroupOptimizer, _init_group_pool, _evaluate_s5_params
from multiprocessing import Pool

import numpy as np

def test_s5():
    print("Synthesizing random data...")
    dates = pd.date_range("2025-01-01 10:00:00", periods=500, freq="5min")
    df = pd.DataFrame({
        'Tarih': dates.strftime('%Y-%m-%d'),
        'Saat': dates.strftime('%H:%M:%S'),
        'Acilis': np.random.rand(500) * 100 + 8000,
        'Yuksek': np.random.rand(500) * 100 + 8050,
        'Dusuk': np.random.rand(500) * 100 + 7950,
        'Kapanis': np.random.rand(500) * 100 + 8000,
        'Hacim': np.random.randint(10, 1000, 500)
    })
    
    # Pre-process like optimizer does to mix standard and turkish columns to test the bug
    df['datetime'] = pd.to_datetime(df['Tarih'] + ' ' + df['Saat'])
    df['close'] = df['Kapanis']
    df['high'] = df['Yuksek']
    df['low'] = df['Dusuk']
    df['open'] = df['Acilis']
    df['volume'] = df['Hacim']
    # Delete some so that we have a mix
    del df['Tarih'], df['Saat'], df['Acilis'], df['Yuksek'], df['Dusuk']
    
    print("Columns:", df.columns)
    
    # Simulate single process init first
    print("\n--- Testing Data Init ---")
    _init_group_pool(4, df, "ENDEKS")
    print("Data init successful!")
    
    # Simulate an evaluation
    print("\n--- Testing S5 Eval ---")
    params = {'ema_fast': 10, 'ema_slow': 20, 'breakout_period': 10, 'adx_period': 14, 'adx_threshold': 20.0, 'vol_ma_period': 20}
    res = _evaluate_s5_params(params)
    print("S5 evaluation result:", res)
    
    # Simulate pool
    print("\n--- Testing Multiprocessing Pool ---")
    with Pool(processes=2, initializer=_init_group_pool, initargs=(4, df, "ENDEKS")) as pool:
        results = pool.map(_evaluate_s5_params, [params, params])
        print("Pool results:", results)

if __name__ == '__main__':
    test_s5()
