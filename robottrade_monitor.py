#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
RoboTrade Monitor v1.0
Sunucudaki iDeal robot işlemlerini izler, PnL hesaplar, stop koşullarını kontrol eder.

Kullanım:
  python robottrade_monitor.py [--check-only] [--stop-level 8000] [--profit-level 11000]
  
Özellikler:
  - VIOP işlem dosyasından net pozisyon hesapla
  - Robot başına PnL takibi
  - Portföy seviye stop loss ve kar al
  - Trailing stop desteği
"""

import struct
import json
import csv
from pathlib import Path
from collections import defaultdict
from datetime import datetime
import argparse


# Geriye donuk fallback mapping (CSV okunamazsa)
ROBOT_SYMBOLS = {
    'RBT_VIP_GARAN_5_S3': "VIP'GARAN",
    'RBT_VIP_HALKB_15_AHLTMF': "VIP'HALKB",
    'RBT_VIP_THYAO_5_TOMA': "VIP'THYAO",
    'RBT_VIP_X030T_1_S1': "VIP'X030-T",
    'RBT_VIP_X030T_1_S2': "VIP'X030-T",
    'RBT_VIP_X030T_1_TOMA': "VIP'X030-T",
    'RBT_VIP_X030T_1_TOMA_2': "VIP'X030-T",
}

# Sembol → Default lot miktarı
SYMBOL_LOTS = {
    "VIP'GARAN": 10,
    "VIP'HALKB": 10,
    "VIP'THYAO": 10,
    "VIP'X030-T": 5,
}

# Sembol ID → Sembol adı (iDeal'den bilinen mappings)
SEMBOL_ID_MAP = {}  # Dosyadan yüklenecek


def _normalize_robot_symbol(raw_symbol):
    """CSV'deki VIP'VIP-XXXX formatini monitor formatina cevir."""
    if not raw_symbol:
        return None
    s = raw_symbol.strip()
    s = s.replace("VIP'VIP-", "VIP'")
    s = s.replace("VIP'VIP", "VIP'")
    return s


def _safe_float_tr(value, default=0.0):
    if value is None:
        return default
    txt = str(value).strip().replace('.', '').replace(',', '.')
    try:
        return float(txt)
    except Exception:
        return default


def load_live_robot_table(csv_path):
    """robot_list_live.csv icinden robot/symbol/pozisyon tablosunu oku."""
    path = Path(csv_path)
    if not path.exists():
        return {}

    table = {}
    with path.open('r', encoding='utf-8-sig', newline='') as f:
        reader = csv.reader(f, delimiter=';')
        for row in reader:
            if not row or row[0] != 'grid' or len(row) < 3:
                continue
            if row[1] != 'DataGridViewRow':
                continue

            # row[2] -> "_____RBT_...,VIP'VIP-..."
            robot_and_symbol = row[2]
            parts = robot_and_symbol.split(',', 1)
            robot_name = parts[0].lstrip('_').strip() if parts else ''
            symbol = _normalize_robot_symbol(parts[1] if len(parts) > 1 else '')

            if not robot_name or not symbol:
                continue

            position = _safe_float_tr(row[3] if len(row) > 3 else 0)
            entry = _safe_float_tr(row[4] if len(row) > 4 else 0)

            table[robot_name] = {
                'symbol': symbol,
                'position': position,
                'entry_price': entry,
            }

    return table


class IslemParser:
    """VIOP işlem dosyasını parse et ve net pozisyon hesapla."""
    
    RECORD_SIZE = 35  # IslemStruct1 size
    
    def __init__(self, filepath):
        self.filepath = Path(filepath)
        self.data = self.filepath.read_bytes()
        self.records = len(self.data) // self.RECORD_SIZE
    
    def parse(self):
        """
        Dosyayı parse et, sembol başına net poz + avg price döndür.
        Returns: {symbol_id: {'net_poz': float, 'avg_price': float, 'trades': int}}
        """
        symbol_data = defaultdict(lambda: {
            'buy_count': 0, 'sell_count': 0,
            'buy_size': 0.0, 'sell_size': 0.0,
            'prices': []
        })
        
        for i in range(self.records):
            offset = i * self.RECORD_SIZE
            record = self.data[offset:offset+self.RECORD_SIZE]
            
            # Parse struct fields
            trade_id, sym_id = struct.unpack('<II', record[0:8])
            price, size = struct.unpack('<ff', record[19:27])
            aggr_party = record[28]
            
            s = symbol_data[sym_id]
            s['prices'].append(price)
            
            # aggr_party byte değeri: 0x01 (byte 1) = seller aggr (SELL)
            #                         0x02 (byte 2) = buyer aggr (BUY)
            # Ama dosyadaki değerler farklı olabilir - HEX değerlerine bak
            if aggr_party in (0x02, 2):  # buyer aggressive = long
                s['buy_count'] += 1
                s['buy_size'] += size
            elif aggr_party in (0x01, 1):  # seller aggressive = short
                s['sell_count'] += 1
                s['sell_size'] += size
        
        # Summarize
        results = {}
        for sym_id, data in symbol_data.items():
            if data['buy_count'] + data['sell_count'] > 0:
                net_poz = data['buy_size'] - data['sell_size']
                avg_price = sum(data['prices']) / len(data['prices']) if data['prices'] else 0
                results[sym_id] = {
                    'net_poz': net_poz,
                    'avg_price': avg_price,
                    'trades': data['buy_count'] + data['sell_count'],
                    'buy_cnt': data['buy_count'],
                    'sell_cnt': data['sell_count'],
                }
        
        return results


class RoboTradeMonitor:
    """Robot işlem izleme ve stop kontrol."""
    
    def __init__(self, viop_file, portfoy_stop_tl=8000, portfoy_karal_tl=11000, robot_csv=None):
        self.viop_file = Path(viop_file)
        self.portfoy_stop = portfoy_stop_tl
        self.portfoy_karal = portfoy_karal_tl
        self.parser = IslemParser(str(viop_file))
        self.symbol_positions = self.parser.parse()
        self.live_robot_table = load_live_robot_table(robot_csv) if robot_csv else {}
    
    def get_portfolio_pnl(self, current_prices=None):
        """
        Portföy seviyesinde PnL hesapla.
        current_prices: {sembol_adi: float_fiyat}
        Returns: {'total_pnl': float, 'by_robot': {...}, 'by_symbol': {...}}
        """
        if current_prices is None:
            current_prices = {}
        
        total_pnl = 0.0
        by_robot = {}
        by_symbol = {}
        
        # Oncelik: canli CSV'den gelen robot pozisyonlari
        if self.live_robot_table:
            for robot_name, row in self.live_robot_table.items():
                symbol = row['symbol']
                net_poz = row['position']
                entry_price = row['entry_price']

                if symbol in current_prices:
                    current_price = current_prices[symbol]
                    lot_size = SYMBOL_LOTS.get(symbol, 1)
                    pnl = net_poz * lot_size * (current_price - entry_price)
                    total_pnl += pnl

                    by_robot[robot_name] = {
                        'pnl': round(pnl, 2),
                        'position': net_poz,
                        'entry_price': round(entry_price, 4),
                        'current_price': current_price,
                        'status': 'active',
                        'symbol': symbol,
                    }
                else:
                    by_robot[robot_name] = {
                        'pnl': 0,
                        'position': net_poz,
                        'entry_price': round(entry_price, 4),
                        'status': 'no_price',
                        'symbol': symbol,
                    }

            return {
                'total_pnl': round(total_pnl, 2),
                'by_robot': by_robot,
                'stop_loss_triggered': total_pnl <= -self.portfoy_stop,
                'take_profit_triggered': total_pnl >= self.portfoy_karal,
            }

        active_robot_map = ROBOT_SYMBOLS

        # Fallback: sembol-id tabanli eski yontem
        for robot_name, symbol in active_robot_map.items():
            sym_ids = [sid for sid, data in self.symbol_positions.items()
                      if self._symbol_id_to_name(sid) == symbol]

            if not sym_ids:
                by_robot[robot_name] = {'pnl': 0, 'position': 0, 'status': 'no_trades', 'symbol': symbol}
                continue

            sym_id = sym_ids[0]
            pos_data = self.symbol_positions[sym_id]
            net_poz = pos_data['net_poz']
            entry_price = pos_data['avg_price']
            
            if symbol in current_prices:
                current_price = current_prices[symbol]
                lot_size = SYMBOL_LOTS.get(symbol, 1)
                pnl = net_poz * lot_size * (current_price - entry_price)
                total_pnl += pnl
                
                by_robot[robot_name] = {
                    'pnl': round(pnl, 2),
                    'position': net_poz,
                    'entry_price': round(entry_price, 2),
                    'current_price': current_price,
                    'status': 'active',
                    'symbol': symbol,
                }
            else:
                by_robot[robot_name] = {
                    'pnl': 0,
                    'position': net_poz,
                    'entry_price': round(entry_price, 2),
                    'status': 'no_price',
                    'symbol': symbol,
                }
        
        return {
            'total_pnl': round(total_pnl, 2),
            'by_robot': by_robot,
            'stop_loss_triggered': total_pnl <= -self.portfoy_stop,
            'take_profit_triggered': total_pnl >= self.portfoy_karal,
        }
    
    def _symbol_id_to_name(self, sym_id):
        """SembolId → sembol adı (TODO: gerçek mapping gerekli)."""
        # Bu basit versiyonda bilinmiyor - mapping dosyası gerekli
        return SEMBOL_ID_MAP.get(sym_id, f'UNKNOWN_{sym_id}')
    
    def check_stop_conditions(self, current_prices=None):
        """Stop koşullarını kontrol et."""
        pnl_data = self.get_portfolio_pnl(current_prices)
        
        result = {
            'timestamp': datetime.now().isoformat(),
            'total_pnl': pnl_data['total_pnl'],
            'stop_loss_triggered': pnl_data['stop_loss_triggered'],
            'take_profit_triggered': pnl_data['take_profit_triggered'],
            'action': 'NONE'
        }
        
        if pnl_data['stop_loss_triggered']:
            result['action'] = 'CLOSE_ALL'
            result['reason'] = f"Portfolio loss {pnl_data['total_pnl']} TL <= stop level {-self.portfoy_stop} TL"
        elif pnl_data['take_profit_triggered']:
            result['action'] = 'CLOSE_ALL'
            result['reason'] = f"Portfolio profit {pnl_data['total_pnl']} TL >= target level {self.portfoy_karal} TL"
        
        return result


def main():
    parser = argparse.ArgumentParser(description='RoboTrade Monitor')
    parser.add_argument('--check-only', action='store_true', help='Durum göster, işlem yapma')
    parser.add_argument('--viop-file', default=r'D:\iDeal\IslemlerVip3\VipIslem20260410.002',
                       help='VIOP işlem dosyası')
    parser.add_argument('--stop-level', type=float, default=8000, help='Portföy stop loss TL')
    parser.add_argument('--profit-level', type=float, default=11000, help='Portföy target profit TL')
    parser.add_argument('--robot-csv', default=r'D:\iDeal\robot_list_live.csv', help='iDeal robot export CSV')
    args = parser.parse_args()
    
    print("=" * 70)
    print("RoboTrade Monitor v1.0")
    print(f"File: {args.viop_file}")
    print(f"Robot CSV: {args.robot_csv}")
    print(f"Stop Loss: {args.stop_level} TL")
    print(f"Target Profit: {args.profit_level} TL")
    print("=" * 70)
    
    # Monitor başlat
    monitor = RoboTradeMonitor(args.viop_file, args.stop_level, args.profit_level, args.robot_csv)

    if monitor.live_robot_table:
        print(f"Canli robot kaydi: {len(monitor.live_robot_table)}")
    else:
        print("Uyari: Robot CSV okunamadi, fallback hardcoded mapping kullaniliyor")
    
    # Test: Fiyatları dummy olarak set et (gerçek API'dari gelecek)
    test_prices = {
        'VIP\'GARAN': 36.25,
        'VIP\'HALKE': 45.10,
        'VIP\'THYAO': 28.50,
        'VIP\'X030-T': 120.30,
    }
    
    # Stop kontrol
    stop_result = monitor.check_stop_conditions(test_prices)
    
    print("\nPORTFÖY PnL:")
    pnl_data = monitor.get_portfolio_pnl(test_prices)
    print(f"  Total PnL: {pnl_data['total_pnl']:+.2f} TL")
    print(f"  Stop Triggered: {pnl_data['stop_loss_triggered']}")
    print(f"  Target Triggered: {pnl_data['take_profit_triggered']}")
    
    print("\nROBOT DURUMLARI:")
    for robot_name, data in pnl_data['by_robot'].items():
        if data['status'] != 'no_trades':
            print(f"  {robot_name:40} {data.get('symbol', ''):12} PnL={data.get('pnl', 0):+8.2f} Poz={data.get('position', 0):+6.0f}")
    
    print("\nSTOP KONTROL SONUCU:")
    print(json.dumps(stop_result, indent=2))
    
    if stop_result['action'] == 'CLOSE_ALL' and not args.check_only:
        print("\n⚠️  MASS CLOSE işlemi başlatılacak!")
        print(f"Reason: {stop_result['reason']}")
        # TODO: Gerçek close işlemi (iDeal API'sine emir gönder)


if __name__ == '__main__':
    main()
