from .core import HHV, LLV

def get_highest_high(data, period):
    return HHV(data, period)

def get_lowest_low(data, period):
    return LLV(data, period)

def safe_round_ideal(value, step=0.01):
    """
    iDeal platformundaki Sistem.SayiYuvarla(val, step) fonksiyonuyla
    aynı mantıkta çalışan yuvarlama fonksiyonu.
    Python'ın Banker's Rounding (0.5'i çifte yuvarlama) hatasını önler.
    """
    if step == 0: return value
    # Epsilon ekleyerek standart yuvarlama (round-half-up) simülasyonu
    return round(value / step + 1e-9) * step

try:
    from numba import njit
    @njit
    def safe_round_ideal_numba(value, step=0.01):
        if step == 0: return value
        # Numba içerisinde standart yuvarlama
        return round(value / step + 1e-9) * step
except ImportError:
    safe_round_ideal_numba = safe_round_ideal
