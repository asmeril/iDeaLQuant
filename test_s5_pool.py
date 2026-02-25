"""Quick diagnostic: test S5 Pool pipeline."""
import sys, os, time

def main():
    sys.path.insert(0, '.')
    from src.optimization.hybrid_group_optimizer import (
        HybridGroupOptimizer, STRATEGY5_GROUPS, IndicatorCache, 
        ParameterGroup
    )
    from src.data.ideal_parser import load_ideal_data
    import src.optimization.hybrid_group_optimizer as hgo

    print('[1] Loading data...')
    df = load_ideal_data(r'D:\iDeal\ChartData', 'VIP', 'X030-T', '5')
    print(f'[2] {len(df)} bars loaded')

    hgo.g_cache = IndicatorCache(df)
    print('[3] Cache ready')

    def my_progress(pct, msg):
        print(f'  PROGRESS: {pct}% - {msg}', flush=True)

    opt = HybridGroupOptimizer(
        STRATEGY5_GROUPS,
        strategy_index=4,
        on_progress_callback=my_progress,
        n_parallel=4,
        vade_tipi='VIOP_ENDEKS'
    )

    test_group = ParameterGroup(
        name='TEST_S5',
        params={'ema_fast': [8, 10, 12], 'ema_slow': [18, 20, 22]},
        is_independent=True,
        default_values={'ema_fast': 10, 'ema_slow': 20, 'breakout_period': 10,
                        'adx_period': 14, 'adx_threshold': 20.0, 
                        'vol_ma_period': 20, 'trailing_stop_pct': 1.5}
    )

    print(f'[4] Testing Pool (9 combos, 4 workers)...')
    t0 = time.time()
    results = opt.run_group_optimization(test_group)
    elapsed = time.time() - t0
    print(f'[5] Done in {elapsed:.1f}s, {len(results)} results')
    for r in results[:3]:
        np_val = r.get('net_profit', 0)
        trades = r.get('trades', 0)
        pf = r.get('pf', 0)
        print(f'  net={np_val:.0f}  trades={trades}  pf={pf:.2f}')

if __name__ == '__main__':
    import multiprocessing
    multiprocessing.freeze_support()
    main()
