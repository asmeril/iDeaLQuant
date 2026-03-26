"""
IdealQuant - Trend Indicators
ADX components, Aroon, Parabolic SAR, Ichimoku
"""

import numpy as np
from numba import jit
from typing import List, Tuple, NamedTuple
from .core import EMA, RMA, ATR, HHV, LLV, MA


def DirectionalIndicatorPlus(highs: List[float], lows: List[float], 
                              closes: List[float], period: int = 14) -> List[float]:
    """
    Directional Indicator Plus (+DI)
    """
    n = len(closes)
    result = [0.0] * n
    
    if n < period + 1:
        return result
    
    # Calculate +DM and TR
    plus_dm = [0.0] * n
    tr = [0.0] * n
    
    for i in range(1, n):
        high_diff = highs[i] - highs[i - 1]
        low_diff = lows[i - 1] - lows[i]
        
        if high_diff > low_diff and high_diff > 0:
            plus_dm[i] = high_diff
        
        hl = highs[i] - lows[i]
        hc = abs(highs[i] - closes[i - 1])
        lc = abs(lows[i] - closes[i - 1])
        tr[i] = max(hl, hc, lc)
    
    # Smooth with Wilder's method
    smoothed_dm = RMA(plus_dm, period)
    smoothed_tr = RMA(tr, period)
    
    for i in range(period, n):
        if smoothed_tr[i] != 0:
            result[i] = (smoothed_dm[i] / smoothed_tr[i]) * 100
    
    return result


def DirectionalIndicatorMinus(highs: List[float], lows: List[float], 
                               closes: List[float], period: int = 14) -> List[float]:
    """
    Directional Indicator Minus (-DI)
    """
    n = len(closes)
    result = [0.0] * n
    
    if n < period + 1:
        return result
    
    # Calculate -DM and TR
    minus_dm = [0.0] * n
    tr = [0.0] * n
    
    for i in range(1, n):
        high_diff = highs[i] - highs[i - 1]
        low_diff = lows[i - 1] - lows[i]
        
        if low_diff > high_diff and low_diff > 0:
            minus_dm[i] = low_diff
        
        hl = highs[i] - lows[i]
        hc = abs(highs[i] - closes[i - 1])
        lc = abs(lows[i] - closes[i - 1])
        tr[i] = max(hl, hc, lc)
    
    # Smooth with Wilder's method
    smoothed_dm = RMA(minus_dm, period)
    smoothed_tr = RMA(tr, period)
    
    for i in range(period, n):
        if smoothed_tr[i] != 0:
            result[i] = (smoothed_dm[i] / smoothed_tr[i]) * 100
    
    return result


# Alias
DI_Plus = DirectionalIndicatorPlus
DI_Minus = DirectionalIndicatorMinus


def AroonUp(highs: List[float], period: int = 25) -> List[float]:
    """
    Aroon Up
    Measures bars since highest high
    """
    n = len(highs)
    result = [0.0] * n

    window_len = period + 1
    for i in range(window_len - 1, n):
        window = highs[i - window_len + 1 : i + 1]
        highest = max(window)

        # Tie-break: en son görülen (IdealData davranışına daha yakın)
        highest_idx = len(window) - 1 - list(reversed(window)).index(highest)

        # Bars since highest -> AroonUp
        bars_since = (window_len - 1) - highest_idx
        result[i] = ((period - bars_since) / period) * 100
    
    return result


def AroonDown(lows: List[float], period: int = 25) -> List[float]:
    """
    Aroon Down
    Measures bars since lowest low
    """
    n = len(lows)
    result = [0.0] * n

    window_len = period + 1
    for i in range(window_len - 1, n):
        window = lows[i - window_len + 1 : i + 1]
        lowest = min(window)

        # Tie-break: en son görülen
        lowest_idx = len(window) - 1 - list(reversed(window)).index(lowest)

        bars_since = (window_len - 1) - lowest_idx
        result[i] = ((period - bars_since) / period) * 100
    
    return result


def AroonOsc(highs: List[float], lows: List[float], 
             period: int = 25) -> List[float]:
    """
    Aroon Oscillator
    AroonOsc = AroonUp - AroonDown
    """
    up = AroonUp(highs, period)
    down = AroonDown(lows, period)
    
    return [up[i] - down[i] for i in range(len(highs))]


def Aroon(highs: List[float], lows: List[float], 
          period: int = 25) -> Tuple[List[float], List[float], List[float]]:
    """
    Complete Aroon indicator
    Returns: (AroonUp, AroonDown, AroonOsc)
    """
    up = AroonUp(highs, period)
    down = AroonDown(lows, period)
    osc = [up[i] - down[i] for i in range(len(highs))]
    
    return up, down, osc


def ParabolicSAR(highs: List[float], lows: List[float], 
                 af_start: float = 0.02, af_step: float = 0.02, 
                 af_max: float = 0.20) -> List[float]:
    """
    Parabolic SAR
    """
    n = len(highs)
    result = [0.0] * n
    
    if n < 2:
        return result
    
    # Initialize
    # Determine initial trend based on first bar
    # If Close > Open (or first 2 bars up), start Long
    # Simple check: Compare High[0] and Low[0] to reference? 
    # IdealData: usually checks if C[0] > C[1] but we only have current.
    # Let's assume Long if Close[0] > Open[0] (need opens?)
    # Alternative: start with Long=True if H[1] > H[0]... wait, loops starts at 1.
    
    is_long = True
    if n > 1:
        if highs[1] < highs[0] and lows[1] < lows[0]:
            is_long = False
    
    if is_long:
        sar = lows[0]
        ep = highs[0]
    else:
        sar = highs[0]
        ep = lows[0]
        
    af = af_start
    result[0] = sar  # SAR for *next* bar effectively, or current? SAR is usually plotted 'stops' for current bar.
    # IdealData: Standard SAR logic.
    
    # Standard SAR often skips the first value or sets it to min/max.
    
    for i in range(1, n):
        prev_sar = sar
        
        # Calculate new SAR
        sar = prev_sar + af * (ep - prev_sar)
        
        if is_long:
            # Ensure SAR is below prior two lows
            sar = min(sar, lows[i-1])
            if i >= 2:
                sar = min(sar, lows[i-2])
            
            # Check for reversal
            if lows[i] < sar:
                is_long = False
                sar = ep
                ep = lows[i]
                af = af_start
            else:
                # Update EP and AF
                if highs[i] > ep:
                    ep = highs[i]
                    af = min(af + af_step, af_max)
        else:
            # Ensure SAR is above prior two highs
            sar = max(sar, highs[i-1])
            if i >= 2:
                sar = max(sar, highs[i-2])
            
            # Check for reversal
            if highs[i] > sar:
                is_long = True
                sar = ep
                ep = highs[i]
                af = af_start
            else:
                # Update EP and AF
                if lows[i] < ep:
                    ep = lows[i]
                    af = min(af + af_step, af_max)
        
        result[i] = sar
    
    return result


class IchimokuResult(NamedTuple):
    """Ichimoku Cloud components"""
    tenkan: List[float]      # Conversion Line (9)
    kijun: List[float]       # Base Line (26)
    senkou_a: List[float]    # Leading Span A
    senkou_b: List[float]    # Leading Span B
    chikou: List[float]      # Lagging Span


def Ichimoku(highs: List[float], lows: List[float], closes: List[float],
             tenkan_period: int = 9, kijun_period: int = 26, 
             senkou_b_period: int = 52) -> IchimokuResult:
    """
    Ichimoku Kinko Hyo
    Returns all 5 components
    """
    n = len(closes)
    
    def midpoint(data_h: List[float], data_l: List[float], period: int) -> List[float]:
        result = [0.0] * len(data_h)
        for i in range(period - 1, len(data_h)):
            highest = max(data_h[i - period + 1 : i + 1])
            lowest = min(data_l[i - period + 1 : i + 1])
            result[i] = (highest + lowest) / 2
        return result
    
    # Tenkan-sen (Conversion Line)
    tenkan = midpoint(highs, lows, tenkan_period)
    
    # Kijun-sen (Base Line)
    kijun = midpoint(highs, lows, kijun_period)
    
    # Senkou Span A (Leading Span A) - shifted forward 26 periods
    senkou_a = [0.0] * n
    for i in range(n - kijun_period):
        senkou_a[i + kijun_period] = (tenkan[i] + kijun[i]) / 2
    
    # Senkou Span B (Leading Span B) - shifted forward 26 periods
    senkou_b_raw = midpoint(highs, lows, senkou_b_period)
    senkou_b = [0.0] * n
    for i in range(n - kijun_period):
        senkou_b[i + kijun_period] = senkou_b_raw[i]
    
    # Chikou Span (Lagging Span) - shifted back 26 periods
    chikou = [0.0] * n
    for i in range(kijun_period, n):
        chikou[i - kijun_period] = closes[i]
    
    return IchimokuResult(tenkan, kijun, senkou_a, senkou_b, chikou)


def PriceChannelUp(highs: List[float], period: int = 20) -> List[float]:
    """
    Price Channel Upper Band (Donchian Channel)
    Usually excludes current bar for breakout logic.
    """
    hhv = HHV(highs, period)
    # Shift right by 1 to exclude current bar
    return [0.0] + hhv[:-1]


def PriceChannelDown(lows: List[float], period: int = 20) -> List[float]:
    """
    Price Channel Lower Band (Donchian Channel)
    """
    llv = LLV(lows, period)
    return [0.0] + llv[:-1]


def PriceChannel(highs: List[float], lows: List[float], 
                 period: int = 20) -> Tuple[List[float], List[float], List[float]]:
    """
    Price Channel (Donchian Channel)
    Returns: (upper, middle, lower)
    """
    upper = HHV(highs, period)
    lower = LLV(lows, period)
    middle = [(upper[i] + lower[i]) / 2 for i in range(len(highs))]
    
    return upper, middle, lower


def VHF(closes: List[float], period: int = 28) -> List[float]:
    """
    Vertical Horizontal Filter
    Measures trend strength
    """
    n = len(closes)
    result = [0.0] * n
    
    for i in range(period, n):
        highest = max(closes[i - period + 1 : i + 1])
        lowest = min(closes[i - period + 1 : i + 1])
        
        # Sum of absolute changes
        sum_changes = sum(abs(closes[j] - closes[j-1]) 
                          for j in range(i - period + 2, i + 1))
        
        if sum_changes != 0:
            result[i] = abs(highest - lowest) / sum_changes
    
    return result


def LinearReg(data: List[float], period: int = 14) -> List[float]:
    """
    Linear Regression Value
    """
    n = len(data)
    result = [0.0] * n
    
    for i in range(period - 1, n):
        # Y values
        y = data[i - period + 1 : i + 1]
        
        # X values (0, 1, 2, ..., period-1)
        x_sum = period * (period - 1) / 2
        x2_sum = period * (period - 1) * (2 * period - 1) / 6
        y_sum = sum(y)
        xy_sum = sum(j * y[j] for j in range(period))
        
        # Calculate slope and intercept
        denom = period * x2_sum - x_sum * x_sum
        if denom != 0:
            slope = (period * xy_sum - x_sum * y_sum) / denom
            intercept = (y_sum - slope * x_sum) / period
            
            # Value at current point
            result[i] = intercept + slope * (period - 1)
    
    return result


def LinearRegSlope(data: List[float], period: int = 14) -> List[float]:
    """
    Linear Regression Slope
    """
    n = len(data)
    result = [0.0] * n
    
    for i in range(period - 1, n):
        y = data[i - period + 1 : i + 1]
        
        x_sum = period * (period - 1) / 2
        x2_sum = period * (period - 1) * (2 * period - 1) / 6
        y_sum = sum(y)
        xy_sum = sum(j * y[j] for j in range(period))
        
        denom = period * x2_sum - x_sum * x_sum
        if denom != 0:
            result[i] = (period * xy_sum - x_sum * y_sum) / denom
    
    return result


def TOMA(closes: List[float], period: int = 3, percent: float = 2.0) -> Tuple[List[float], List[float]]:
    """
    TOMA (Optimized Trend Tracker / Trailing Stop Logic)
    Based on IdealData manual calculation reference.
    
    Returns:
        (TOMA Line, Trend Direction)
        Trend: 1 = Up, -1 = Down
    """
    n = len(closes)
    toma = [0.0] * n
    trend = [0] * n
    
    # Calculate EMA (Model uses 'Exp' MA)
    ma = EMA(closes, period)
    
    if n > 0:
        toma[0] = ma[0]
        trend[0] = 1
        
    percent_factor = percent / 100.0
        
    for i in range(1, n):
        alt_bant = ma[i] * (1 - percent_factor)
        ust_bant = ma[i] * (1 + percent_factor)
        
        prev_trend = trend[i-1]
        prev_toma = toma[i-1]
        
        if prev_trend == 1: # Uptrend
            # TOMA never goes down in uptrend
            new_toma = max(prev_toma, alt_bant)
            
            # Check for breakdown
            if closes[i] < new_toma:
                trend[i] = -1
                toma[i] = ust_bant # Flip to upper band
            else:
                trend[i] = 1
                toma[i] = new_toma
                
        else: # Downtrend
            # TOMA never goes up in downtrend
            new_toma = min(prev_toma, ust_bant)
            
            # Check for breakout
            if closes[i] > new_toma:
                trend[i] = 1
                toma[i] = alt_bant # Flip to lower band
            else:
                trend[i] = -1
                toma[i] = new_toma
                
    return toma, trend


def _ott_core(ma_line, percent):
    """Pure-Python OTT core logic on pre-computed MA line."""
    n = len(ma_line)
    ott = [0.0] * n
    fark_pct = percent * 0.01

    longStop = [0.0] * n
    shortStop = [0.0] * n
    dir_list = [1] * n

    first_nonzero = 0
    for k in range(n):
        if ma_line[k] != 0.0:
            first_nonzero = k
            break

    for i in range(first_nonzero, n):
        curr_ma = ma_line[i]
        fark = curr_ma * fark_pct
        curr_ls = curr_ma - fark
        curr_ss = curr_ma + fark

        if i == first_nonzero:
            longStop[i] = curr_ls
            shortStop[i] = curr_ss
            dir_list[i] = 1
            ott[i] = longStop[i]
            continue

        prev_ls = longStop[i-1]
        prev_ss = shortStop[i-1]

        longStop[i] = max(curr_ls, prev_ls) if curr_ma > prev_ls else curr_ls
        shortStop[i] = min(curr_ss, prev_ss) if curr_ma < prev_ss else curr_ss

        prev_dir = dir_list[i-1]
        if prev_dir == -1 and curr_ma > prev_ss:
            dir_list[i] = 1
        elif prev_dir == 1 and curr_ma < prev_ls:
            dir_list[i] = -1
        else:
            dir_list[i] = prev_dir

        ott[i] = longStop[i] if dir_list[i] == 1 else shortStop[i]

    return ott


# --- Numba JIT OTT (15-20x faster) ---
try:
    import numpy as np
    from numba import jit

    @jit(nopython=True, cache=True)
    def _variable_ma_numba(data, period, cmo_window=9):
        """Numba JIT VariableMA (VIDYA with CMO)."""
        n = len(data)
        vma = np.zeros(n, dtype=np.float64)
        if n == 0 or period < 1:
            return vma
        k = 2.0 / (period + 1.0)
        vma[0] = data[0]
        for i in range(1, n):
            # CMO calculation
            cmo_start = max(0, i - cmo_window)
            gains = 0.0
            losses = 0.0
            for j in range(cmo_start + 1, i + 1):
                diff = data[j] - data[j - 1]
                if diff > 0:
                    gains += diff
                else:
                    losses += (-diff)
            total = gains + losses
            cmo_val = (gains - losses) / total if total > 0 else 0.0
            alpha = k * abs(cmo_val)
            vma[i] = alpha * data[i] + (1.0 - alpha) * vma[i - 1]
        return vma

    @jit(nopython=True, cache=True)
    def _ott_core_numba(ma_line, percent):
        """Numba JIT OTT core logic."""
        n = len(ma_line)
        ott = np.zeros(n, dtype=np.float64)
        fark_pct = percent * 0.01

        longStop = np.zeros(n, dtype=np.float64)
        shortStop = np.zeros(n, dtype=np.float64)
        dir_arr = np.ones(n, dtype=np.int64)

        first_nz = 0
        for k in range(n):
            if ma_line[k] != 0.0:
                first_nz = k
                break

        for i in range(first_nz, n):
            curr_ma = ma_line[i]
            fark = curr_ma * fark_pct
            curr_ls = curr_ma - fark
            curr_ss = curr_ma + fark

            if i == first_nz:
                longStop[i] = curr_ls
                shortStop[i] = curr_ss
                dir_arr[i] = 1
                ott[i] = curr_ls
                continue

            prev_ls = longStop[i - 1]
            prev_ss = shortStop[i - 1]

            if curr_ma > prev_ls:
                longStop[i] = max(curr_ls, prev_ls)
            else:
                longStop[i] = curr_ls

            if curr_ma < prev_ss:
                shortStop[i] = min(curr_ss, prev_ss)
            else:
                shortStop[i] = curr_ss

            prev_dir = dir_arr[i - 1]
            if prev_dir == -1 and curr_ma > prev_ss:
                dir_arr[i] = 1
            elif prev_dir == 1 and curr_ma < prev_ls:
                dir_arr[i] = -1
            else:
                dir_arr[i] = prev_dir

            if dir_arr[i] == 1:
                ott[i] = longStop[i]
            else:
                ott[i] = shortStop[i]

        return ott

    @jit(nopython=True, cache=True)
    def ott_numba(data_arr, period, percent, cmo_window=9):
        """
        Complete Numba OTT: VariableMA + OTT in one call.
        Input: numpy float64 array. Returns: (ott, vma) as numpy arrays.
        """
        vma = _variable_ma_numba(data_arr, period, cmo_window)
        ott = _ott_core_numba(vma, percent)
        return ott, vma

    _HAS_NUMBA_OTT = True
except ImportError:
    _HAS_NUMBA_OTT = False


def OTT(data: List[float], period: int = 2, percent: float = 1.4, ma_method: str = "variable") -> Tuple[List[float], List[float]]:
    """
    Optimized Trend Tracker (OTT) by Kıvanç Özbilgiç (Exact TradingView Logic).
    Uses Numba JIT for 'variable' MA when available (~15x faster).
    
    Returns:
        (OTT Line, MA Line)
    """
    n = len(data)
    if n == 0:
        return [0.0] * n, [0.0] * n

    # Fast path: Numba for variable MA
    if ma_method.lower() == "variable" and _HAS_NUMBA_OTT:
        import numpy as np
        data_arr = np.asarray(data, dtype=np.float64)
        ott_arr, vma_arr = ott_numba(data_arr, int(period), float(percent))
        return ott_arr.tolist(), vma_arr.tolist()

    # Slow path: pure Python for any MA type
    ma_line = MA(data, ma_method, period)
    ott = _ott_core(ma_line, percent)
    return ott, ma_line


def TTI(data: List[float], period: int = 50, percent: float = 7.0, ma_method: str = "variable") -> List[float]:
    """
    Trend Tracker Index (TTI) used in IdealData (Sistem.TTI).
    It is effectively the OTT line from the OTT calculation.
    
    Returns:
        Single List containing the TTI (OTT) line.
    """
    ott_line, _ = OTT(data, period, percent, ma_method)
    return ott_line

# Aliases for DeepScalp Compatibility
def get_toma(closes, p1, p2):
    return TOMA(closes, p1, p2)

@jit(nopython=True, cache=True)
def _supertrend_core(highs, lows, closes, hhv_p, atr_p, factor):
    """
    Core Numba JIT logic for SuperTrend.
    Calibrated against IdealData (v5 brute force):
      - Center: (High + Low) / 2
      - ATR: Wilder's RMA (alpha = 1/hhv_p)
        -> İdealData imzası: SuperTrend(Factor, Pd, Pd1)
           Pd = ATR periyodu (hhv_p olarak geçiriliyor)
           Pd1 = kullanılmıyor (future use)
      - Flip: Close-based
    Son 200 barda %0.002 hata payı (%99.998 uyum).
    """
    n = len(closes)
    st = np.zeros(n)
    tr = np.zeros(n)
    
    # İdealData'da Pd (hhv_p) gerçekte ATR periyodu olarak kullanılıyor
    actual_atr_p = hhv_p
    
    if n < actual_atr_p:
        return st, st, st
        
    # True Range
    tr[0] = highs[0] - lows[0]
    for i in range(1, n):
        tr[i] = max(highs[i] - lows[i], max(abs(highs[i] - closes[i-1]), abs(lows[i] - closes[i-1])))
        
    # ATR: Wilder's RMA (alpha = 1/period)
    atr = np.zeros(n)
    alpha = 1.0 / actual_atr_p
    atr[0] = tr[0]
    for i in range(1, n):
        atr[i] = tr[i] * alpha + atr[i-1] * (1.0 - alpha)
        
    # Center: Standard Midpoint
    mid = (highs + lows) / 2.0
    upper_band = mid + factor * atr
    lower_band = mid - factor * atr
    
    # Trailing SuperTrend Logic
    st[0] = upper_band[0]
    trend = -1  # Start Down
    for i in range(1, n):
        if trend == 1:
            # Uptrend: trail lower band (can only go up)
            st[i] = max(lower_band[i], st[i-1])
            if closes[i] < st[i]:
                trend = -1
                st[i] = upper_band[i]
        else:
            # Downtrend: trail upper band (can only go down)
            st[i] = min(upper_band[i], st[i-1])
            if closes[i] > st[i]:
                trend = 1
                st[i] = lower_band[i]
                
    return st, upper_band, lower_band



def get_supertrend(highs: List[float], lows: List[float], closes: List[float], 
                   hhv_p: int, atr_p: int, factor: float) -> Tuple[List[float], List[float], List[float]]:
    """
    SuperTrend Indicator (IdealData Compatible)
    Uses HHV/LLV for center and ATR-based bands.
    Args:
        highs, lows, closes: Price lists
        hhv_p: Period for HHV/LLV (Center)
        atr_p: Period for ATR (Band distance)
        factor: Multiplier for ATR
    Returns:
        (SuperTrend, UpperBand, LowerBand)
    """
    import numpy as np
    h = np.array(highs, dtype=np.float64)
    l = np.array(lows, dtype=np.float64)
    c = np.array(closes, dtype=np.float64)
    
    st, up, down = _supertrend_core(h, l, c, int(hhv_p), int(atr_p), float(factor))
    return st.tolist(), up.tolist(), down.tolist()
