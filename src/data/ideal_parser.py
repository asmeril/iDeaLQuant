# -*- coding: utf-8 -*-
"""
IdealData Binary Parser
-----------------------
IdealData dosyalarını okur ve pandas DataFrame'e çevirir.

Format (32 byte per record):
- int32: dakika sayısı (base date'den itibaren)
- float32: Open
- float32: High  
- float32: Low
- float32: Close
- float32: Volume (Lot)
- float32: Amount (Hacim TL)
- int32: Flags

Base Date: 1988-02-19 00:00:00 (IdealData epoch)
Doğrulama: 
  - THYAO vadelisi (Spot) son barı: 18:09 (Binary minutes: 20,050,209)
  - X030-T (Akşam Seanslı) son barı: 22:59 (Binary minutes: 20,050,499)
  (18:09 ile 22:59 arasında tam 290 dakika fark var, binary dosyalar bunu kanıtlıyor)
"""

import struct
from datetime import datetime, timedelta
from pathlib import Path
from typing import List, Optional, Dict
import pandas as pd


# Base Date: 1988-02-19 00:00:00 (IdealData epoch)
BASE_DATE = datetime(1988, 2, 19, 0, 0)






RECORD_SIZE = 32

# Periyot → Klasör ve Uzantı Mapping
PERIOD_MAP: Dict[str, dict] = {
    '1':   {'folder': '01', 'ext': '.01', 'label': '1 Dakika'},
    '5':   {'folder': '05', 'ext': '.05', 'label': '5 Dakika'},
    '15':  {'folder': '15', 'ext': '.15', 'label': '15 Dakika'},
    '60':  {'folder': '60', 'ext': '.60', 'label': '60 Dakika'},
    '240': {'folder': '240', 'ext': '.240', 'label': '4 Saat'},
    'G':   {'folder': 'G', 'ext': '.G', 'label': 'Günlük'},
    'H':   {'folder': 'B', 'ext': '.B', 'label': 'Haftalık'},
}

# Pazar listesi
MARKETS = ['VIP', 'IMKBH', 'IMKBX', 'FX', 'DOVIZ', 'CRP']


def read_ideal_data(file_path: str) -> pd.DataFrame:
    """
    IdealData dosyasını okur.
    
    Args:
        file_path: dosya yolu (.01, .05, .60, .G vb.)
        
    Returns:
        pandas DataFrame with columns: DateTime, Open, High, Low, Close, Volume, Amount
    """
    path = Path(file_path)
    if not path.exists():
        raise FileNotFoundError(f"File not found: {file_path}")
    
    records = []
    
    with open(path, 'rb') as f:
        data = f.read()
    
    num_records = len(data) // RECORD_SIZE
    
    for i in range(num_records):
        offset = i * RECORD_SIZE
        chunk = data[offset:offset + RECORD_SIZE]
        
        if len(chunk) < RECORD_SIZE:
            break
            
        try:
            # Little-endian: int32, float32 x6, int32
            time_minutes, o, h, l, c, volume, amount, flags = struct.unpack('<i6fi', chunk)
            
            # Calculate datetime from minutes since base date
            bar_datetime = BASE_DATE + timedelta(minutes=time_minutes)
            
            records.append({
                'DateTime': bar_datetime,
                'Open': o,
                'High': h,
                'Low': l,
                'Close': c,
                'Volume': volume,  # Lot
                'Amount': amount,  # TL
            })
        except struct.error:
            continue
    
    df = pd.DataFrame(records)
    
    # Tipik fiyat hesapla
    if len(df) > 0:
        df['Tipik'] = (df['High'] + df['Low'] + df['Close']) / 3
        
        # Türkçe kolon alias'ları (strateji ve optimizer uyumluluğu için)
        df['Acilis'] = df['Open']
        df['Yuksek'] = df['High']
        df['Dusuk'] = df['Low']
        df['Kapanis'] = df['Close']
        df['Lot'] = df['Volume']
    
    return df


def resample_bars(df: pd.DataFrame, target_period: int) -> pd.DataFrame:
    """
    1 dakikalık bar verisini daha yüksek periyoda resample et.
    
    Args:
        df: 1dk bar verisi (DateTime, Open, High, Low, Close, Volume, Amount)
        target_period: Hedef periyot (dakika cinsinden: 5, 15, 60, 240)
        
    Returns:
        Resample edilmiş DataFrame
    """
    if 'DateTime' not in df.columns:
        raise ValueError("DataFrame must have 'DateTime' column")
    
    # DateTime'ı index yap
    df_copy = df.copy()
    df_copy.set_index('DateTime', inplace=True)
    
    # OHLC resample kuralları
    resampled = df_copy.resample(f'{target_period}min', label='left', closed='left').agg({
        'Open': 'first',
        'High': 'max',
        'Low': 'min',
        'Close': 'last',
        'Volume': 'sum',
        'Amount': 'sum'
    }).dropna()
    
    # Index'i kolona çevir
    resampled.reset_index(inplace=True)
    
    # Tipik fiyat ekle
    resampled['Tipik'] = (resampled['High'] + resampled['Low'] + resampled['Close']) / 3
    
    # Türkçe kolon alias'ları
    resampled['Acilis'] = resampled['Open']
    resampled['Yuksek'] = resampled['High']
    resampled['Dusuk'] = resampled['Low']
    resampled['Kapanis'] = resampled['Close']
    resampled['Lot'] = resampled['Volume']
    
    return resampled


def load_with_resample(chart_data_path: str, market: str, symbol: str, 
                       target_period: int) -> Optional[pd.DataFrame]:
    """
    1dk verisini yükle ve istenirse resample et.
    
    Args:
        chart_data_path: ChartData klasör yolu
        market: Pazar
        symbol: Sembol
        target_period: Hedef periyot (1, 5, 15, 60, 240)
        
    Returns:
        DataFrame veya None
    """
    # Önce 1dk verisini yükle
    df_1m = load_ideal_data(chart_data_path, market, symbol, '1')
    
    if df_1m is None or len(df_1m) == 0:
        return None
    
    # 1dk istenmişse direkt döndür
    if target_period == 1:
        return df_1m
    
    # Resample et
    return resample_bars(df_1m, target_period)


def get_file_path(chart_data_path: str, market: str, symbol: str, period: str) -> Optional[Path]:
    """
    Sembol ve periyot için dosya yolunu döndür.
    
    Args:
        chart_data_path: ChartData klasör yolu (örn: D:\\iDeal\\ChartData)
        market: Pazar (VIP, IMKBH vb.)
        symbol: Sembol (X030, GARAN vb.)
        period: Periyot ('1', '5', '60', 'G' vb.)
        
    Returns:
        Dosya yolu veya None
    """
    if period not in PERIOD_MAP:
        return None
    
    mapping = PERIOD_MAP[period]
    folder = mapping['folder']
    ext = mapping['ext']
    
    base_path = Path(chart_data_path) / market / folder
    
    if not base_path.exists():
        return None
    
    # Dosya adı pattern'leri dene
    patterns = [
        f"{market}'{market}-{symbol}{ext}",           # VIP'VIP-X030.01
        f"{market}'F_{symbol}{ext}",                   # VIP'F_X030.01
        f"{market}'{symbol}{ext}",                     # VIP'X030.01
    ]
    
    for pattern in patterns:
        file_path = base_path / pattern
        if file_path.exists():
            return file_path
    
    # Glob ile ara
    for f in base_path.glob(f"*{symbol}*{ext}"):
        return f
    
    return None


def list_symbols(chart_data_path: str, market: str = "VIP", period: str = "1") -> List[str]:
    """
    Belirtilen pazar ve periyot için mevcut sembolleri listeler.
    
    Args:
        chart_data_path: ChartData klasör yolu
        market: Pazar
        period: Periyot
        
    Returns:
        Sembol listesi
    """
    if period not in PERIOD_MAP:
        return []
    
    mapping = PERIOD_MAP[period]
    folder = mapping['folder']
    ext = mapping['ext']
    
    path = Path(chart_data_path) / market / folder
    if not path.exists():
        return []
    
    symbols = set()
    for f in path.glob(f"*{ext}"):
        name = f.stem
        # VIP'VIP-X030 -> X030
        # VIP'F_GARAN0226 -> GARAN0226
        if "'" in name:
            parts = name.split("'")
            if len(parts) >= 2:
                symbol = parts[1]
                symbol = symbol.replace(f"{market}-", "")
                symbol = symbol.replace("F_", "")
                symbols.add(symbol)
    
    return sorted(symbols)


def list_available_periods(chart_data_path: str, market: str = "VIP") -> List[str]:
    """
    Belirtilen pazar için mevcut periyotları listeler.
    
    Args:
        chart_data_path: ChartData klasör yolu
        market: Pazar
        
    Returns:
        Periyot listesi
    """
    base_path = Path(chart_data_path) / market
    if not base_path.exists():
        return []
    
    available = []
    for period, mapping in PERIOD_MAP.items():
        folder_path = base_path / mapping['folder']
        if folder_path.exists() and any(folder_path.iterdir()):
            available.append(period)
    
    return available


def load_ideal_data(chart_data_path: str, market: str, symbol: str, period: str) -> Optional[pd.DataFrame]:
    """
    IdealData'dan veri yükle (convenience function).
    
    Args:
        chart_data_path: ChartData klasör yolu
        market: Pazar
        symbol: Sembol
        period: Periyot
        
    Returns:
        DataFrame veya None
    """
    file_path = get_file_path(chart_data_path, market, symbol, period)
    if file_path is None:
        return None
    
    return read_ideal_data(str(file_path))


def write_ideal_data(df: pd.DataFrame, file_path: str) -> int:
    """
    DataFrame'i IdealData binary formatına yazar.
    
    Args:
        df: DateTime, Open, High, Low, Close, Volume, Amount kolonları olan DataFrame
        file_path: Hedef dosya yolu
        
    Returns:
        Yazılan kayıt sayısı
    """
    path = Path(file_path)
    path.parent.mkdir(parents=True, exist_ok=True)
    
    count = 0
    with open(path, 'wb') as f:
        for _, row in df.iterrows():
            dt = pd.Timestamp(row['DateTime'])
            # Dakika farkı: BASE_DATE'den itibaren
            delta = dt - pd.Timestamp(BASE_DATE)
            time_minutes = int(delta.total_seconds() / 60)
            
            o = float(row['Open'])
            h = float(row['High'])
            l = float(row['Low'])
            c = float(row['Close'])
            vol = float(row['Volume'])
            amt = float(row.get('Amount', 0.0))
            flags = 0
            
            f.write(struct.pack('<i6fi', time_minutes, o, h, l, c, vol, amt, flags))
            count += 1
    
    return count


def generate_period_data(chart_data_path: str, market: str, symbol: str,
                         target_period: str, source_period: str = '1') -> dict:
    """
    1 dakikalık (veya başka kaynak) veriden hedef periyot verisini oluşturur ve diske yazar.
    
    Args:
        chart_data_path: ChartData klasör yolu (örn: D:\\iDeal\\ChartData)
        market: Pazar (VIP, IMKBH vb.)
        symbol: Sembol (X030, GARAN vb.)
        target_period: Hedef periyot ('5', '15', '60', '240')
        source_period: Kaynak periyot (varsayılan '1')
        
    Returns:
        dict: {'success': bool, 'message': str, 'bars': int, 'file_path': str}
    """
    if target_period not in PERIOD_MAP:
        return {'success': False, 'message': f'Geçersiz hedef periyot: {target_period}', 'bars': 0, 'file_path': ''}
    
    if source_period not in PERIOD_MAP:
        return {'success': False, 'message': f'Geçersiz kaynak periyot: {source_period}', 'bars': 0, 'file_path': ''}
    
    target_minutes = int(target_period) if target_period.isdigit() else 0
    source_minutes = int(source_period) if source_period.isdigit() else 0
    
    if target_minutes <= source_minutes:
        return {'success': False, 'message': f'Hedef periyot ({target_period}) kaynak periyottan ({source_period}) büyük olmalı', 'bars': 0, 'file_path': ''}
    
    # Kaynak veriyi yükle
    source_df = load_ideal_data(chart_data_path, market, symbol, source_period)
    if source_df is None or len(source_df) == 0:
        return {'success': False, 'message': f'{symbol} için {source_period} dk kaynak verisi bulunamadı', 'bars': 0, 'file_path': ''}
    
    # Resample et
    resampled_df = resample_bars(source_df, target_minutes)
    if resampled_df is None or len(resampled_df) == 0:
        return {'success': False, 'message': 'Resample başarısız oldu', 'bars': 0, 'file_path': ''}
    
    # Hedef dosya yolunu belirle
    mapping = PERIOD_MAP[target_period]
    target_folder = Path(chart_data_path) / market / mapping['folder']
    
    # Kaynak dosyadan dosya adı pattern'ini al
    source_file = get_file_path(chart_data_path, market, symbol, source_period)
    if source_file:
        # Kaynak dosyanın adını kullanarak hedef dosya adını oluştur
        source_stem = source_file.stem  # örn: VIP'VIP-X030
        target_filename = f"{source_stem}{mapping['ext']}"
    else:
        # Fallback: standart format
        target_filename = f"{market}'{market}-{symbol}{mapping['ext']}"
    
    target_path = target_folder / target_filename
    
    # Diske yaz
    bar_count = write_ideal_data(resampled_df, str(target_path))
    
    return {
        'success': True,
        'message': f'{symbol} {target_period} dk verisi oluşturuldu: {bar_count:,} bar',
        'bars': bar_count,
        'file_path': str(target_path)
    }


def generate_period_data_batch(chart_data_path: str, market: str, 
                                target_period: str, source_period: str = '1',
                                symbols: List[str] = None) -> List[dict]:
    """
    Birden fazla sembol için toplu periyot verisi oluşturur.
    
    Args:
        chart_data_path: ChartData klasör yolu
        market: Pazar
        target_period: Hedef periyot
        source_period: Kaynak periyot
        symbols: Sembol listesi (None ise tüm semboller)
        
    Returns:
        Her sembol için sonuç listesi
    """
    if symbols is None:
        symbols = list_symbols(chart_data_path, market, source_period)
    
    results = []
    for sym in symbols:
        result = generate_period_data(chart_data_path, market, sym, target_period, source_period)
        results.append({'symbol': sym, **result})
    
    return results


if __name__ == "__main__":
    # Test
    chart_data = r"D:\iDeal\ChartData"
    
    print("=" * 60)
    print("IdealData Parser Test")
    print("=" * 60)
    
    # Mevcut periyotlari listele
    print("\nVIP icin mevcut periyotlar:")
    periods = list_available_periods(chart_data, "VIP")
    for p in periods:
        print(f"  - {p}: {PERIOD_MAP.get(p, {}).get('label', p)}")
    
    # 1dk sembolleri listele
    print("\nVIP 1dk sembolleri (ilk 10):")
    symbols = list_symbols(chart_data, "VIP", "1")
    for s in symbols[:10]:
        print(f"  - {s}")
    
    # X030 verisini yukle
    print("\nX030 1dk verisi:")
    df = load_ideal_data(chart_data, "VIP", "X030", "1")
    if df is not None:
        print(f"  Toplam bar: {len(df):,}")
        print(f"  Tarih araligi: {df['DateTime'].min()} -> {df['DateTime'].max()}")
        print(f"\n  Ilk 3 bar:")
        print(df.head(3).to_string())
    else:
        print("  Veri bulunamadi!")


