import os
import pandas as pd
import numpy as np
from src.indicators.core import ATR

def verify_atr():
    # Load comparison data
    ref_path = r"d:\Projects\IdealQuant\data\ideal_ind_export.csv"
    if not os.path.exists(ref_path): return
    df = pd.read_csv(ref_path, sep=';')
    
    # We need H/L/C to calculate ATR
    # Wait, Step 101 header review: BarNo;Date;Time;Close;Hacim;Lot;SMA20;EMA20;DEMA20;TEMA20;HullMA20;FRAMA;KAMA1030;RSI14;CCI20;Momentum10;ROC10;CMO9;WilliamsR14;StochFast;StochSlow;Qstick10;RVI10;RVI10Sig;MACD1226;HHV20;LLV20;ATR14;...
    # Still no High/Low in export.csv!
    
    print("Export.csv does not have High/Low. Cannot verify ATR logic there.")

if __name__ == "__main__":
    verify_atr()
