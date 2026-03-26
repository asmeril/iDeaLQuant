from .core import HHV, LLV

def get_highest_high(data, period):
    return HHV(data, period)

def get_lowest_low(data, period):
    return LLV(data, period)
