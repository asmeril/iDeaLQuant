"""
robot_master_guard.py

Amaç:
1) iDeal config dosyalarındaki gerçek + aktif robotları okumak
2) Canlı PnL kaynağını izlemek (CSV veya .002 akış-proxy)
3) Hedef kar sonrası trailing-stop ile tetiklenince tüm robotları durdurmak

Not:
- Dışarıdan iDeal icindeki Sistem.RobotStop() metodunu dogrudan cagiramadigimiz icin
  toplu durdurma asamasinda config dosyalarinda AktifPasif=0 yazilir.
- Bu script varsayilan olarak dry-run modunda calisir.
"""

from __future__ import annotations

import argparse
import csv
import json
import os
import struct
import subprocess
import sys
import time
from dataclasses import dataclass, asdict
from datetime import datetime
from pathlib import Path
from typing import Dict, List, Optional, Tuple


IDEAL_ROOT = Path(r"D:\iDeal")
CONFIG_DIR = IDEAL_ROOT / "Config"
STATE_FILE = Path(__file__).with_name("robot_master_guard_state.json")

BIST_FILE = IDEAL_ROOT / "IslemlerImkb3"
VIOP_FILE = IDEAL_ROOT / "IslemlerVip3"


@dataclass
class GuardConfig:
    profit_target: float
    trailing_drawdown: float
    poll_seconds: int
    dry_run: bool
    pnl_csv: Optional[Path]
    use_trade_proxy: bool


@dataclass
class GuardState:
    max_pnl: float = 0.0
    current_pnl: float = 0.0
    trailing_stop: float = 0.0
    target_reached: bool = False
    stop_triggered: bool = False
    stop_reason: str = ""
    last_bist_trade_id: int = 0
    last_viop_trade_id: int = 0
    last_update: str = ""


def now_str() -> str:
    return datetime.now().strftime("%Y-%m-%d %H:%M:%S")


def pick_latest_file(folder: Path, prefix: str) -> Optional[Path]:
    if not folder.exists():
        return None
    files = sorted(folder.glob(f"{prefix}*.002"))
    return files[-1] if files else None


def parse_islem_struct1_records(path: Path) -> List[Dict[str, float]]:
    """
    IslemStruct1 layout (packing=1, 35 byte):
    i4 TradeID
    i4 SembolId
    i4 BuyerID
    i4 SellerID
    u1 Hour
    u1 Minute
    u1 Second
    f4 Price
    f4 Size
    u1 Deleted
    u1 AggresiveParty
    u1 NasdaqTradeType
    u1 Tip
    f4 Vol
    """
    raw = path.read_bytes()
    if len(raw) % 35 != 0:
        return []

    out: List[Dict[str, float]] = []
    for off in range(0, len(raw), 35):
        trade_id = struct.unpack_from("<i", raw, off)[0]
        sembol_id = struct.unpack_from("<i", raw, off + 4)[0]
        price = struct.unpack_from("<f", raw, off + 19)[0]
        size = struct.unpack_from("<f", raw, off + 23)[0]
        deleted = raw[off + 27]
        aggr = raw[off + 28]
        tip = raw[off + 30]
        vol = struct.unpack_from("<f", raw, off + 31)[0]
        out.append(
            {
                "TradeID": float(trade_id),
                "SembolId": float(sembol_id),
                "Price": float(price),
                "Size": float(size),
                "Deleted": float(deleted),
                "AggresiveParty": float(aggr),
                "Tip": float(tip),
                "Vol": float(vol),
            }
        )
    return out


def aggr_side(aggr_val: float) -> int:
    """
    AggresiveParty byte'i cogu kayitta ASCII karakter tasiyor.
    'B' buy, 'S' sell varsayimi ile money-flow proxy uretir.
    """
    x = int(aggr_val)
    if x == ord("B"):
        return 1
    if x == ord("S"):
        return -1
    return 0


def load_state() -> GuardState:
    if not STATE_FILE.exists():
        return GuardState()
    try:
        data = json.loads(STATE_FILE.read_text(encoding="utf-8"))
        return GuardState(**data)
    except Exception:
        return GuardState()


def save_state(state: GuardState) -> None:
    state.last_update = now_str()
    STATE_FILE.write_text(json.dumps(asdict(state), indent=2), encoding="utf-8")


def run_powershell(ps_script: str) -> subprocess.CompletedProcess:
    return subprocess.run(
        ["powershell", "-NoProfile", "-Command", ps_script],
        text=True,
        capture_output=True,
    )


def read_real_active_robots() -> List[Dict[str, str]]:
    """Config dosyalarindan gercek+aktif robotlari toplar."""
    ps = rf"""
$ErrorActionPreference = 'Stop'
Set-Location '{IDEAL_ROOT}'
[void][System.Reflection.Assembly]::LoadFrom('{IDEAL_ROOT / 'ideal.exe'}')
$bf = New-Object System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
$out = @()

function Read-RobotFile($path, $listProp, $nameProp) {{
    if (!(Test-Path $path)) {{ return }}
    $fs = [System.IO.File]::OpenRead($path)
    try {{
        $obj = $bf.Deserialize($fs)
    }} finally {{
        $fs.Close()
    }}
    $list = $obj.$listProp
    if ($null -eq $list) {{ return }}

    foreach($r in $list) {{
        $gs = 0
        $ap = 0
        if ($r.PSObject.Properties.Name -contains 'GercekSanal') {{ $gs = [int]$r.GercekSanal }}
        if ($r.PSObject.Properties.Name -contains 'AktifPasif')  {{ $ap = [int]$r.AktifPasif }}
        if ($gs -eq 1 -and $ap -eq 1) {{
            $nm = ''
            if ($r.PSObject.Properties.Name -contains $nameProp) {{ $nm = [string]$r.$nameProp }}
            $sym = ''
            if ($r.PSObject.Properties.Name -contains 'IslemSembol') {{ $sym = [string]$r.IslemSembol }}
            $out += [PSCustomObject]@{{
                Source = [System.IO.Path]::GetFileName($path)
                Name = $nm
                Symbol = $sym
                Hesap = ($(if($r.PSObject.Properties.Name -contains 'Hesap'){{[string]$r.Hesap}}else{{''}}))
                AltHesap = ($(if($r.PSObject.Properties.Name -contains 'AltHesap'){{[string]$r.AltHesap}}else{{''}}))
            }}
        }}
    }}
}}

Read-RobotFile '{CONFIG_DIR / 'KodRobot.001'}' 'RobotList' 'SistemName'
Read-RobotFile '{CONFIG_DIR / 'RoboTrade.001'}' 'RoboTradeList' 'Isim'
Read-RobotFile '{CONFIG_DIR / 'NagantsRobot.001'}' 'RobotList' 'SistemName'
Read-RobotFile '{CONFIG_DIR / 'SablonRobot.001'}' 'RobotList' 'SistemName'
Read-RobotFile '{CONFIG_DIR / 'TaramaRobot.001'}' 'RobotList' 'SistemName'

$out | ConvertTo-Json -Depth 4 -Compress
"""
    cp = run_powershell(ps)
    if cp.returncode != 0:
        return []
    text = (cp.stdout or "").strip()
    if not text:
        return []
    try:
        data = json.loads(text)
        if isinstance(data, dict):
            return [data]
        return data
    except Exception:
        return []


def disable_all_real_robots(dry_run: bool) -> Tuple[bool, str]:
    """Gercek+aktif robotlarin AktifPasif alanini 0 yapar."""
    if dry_run:
        return True, "DRY-RUN: Robot durdurma emri simule edildi"

    ps = rf"""
$ErrorActionPreference = 'Stop'
Set-Location '{IDEAL_ROOT}'
[void][System.Reflection.Assembly]::LoadFrom('{IDEAL_ROOT / 'ideal.exe'}')
$bf = New-Object System.Runtime.Serialization.Formatters.Binary.BinaryFormatter

function Disable-RobotFile($path, $listProp) {{
    if (!(Test-Path $path)) {{ return 0 }}
    $fs = [System.IO.File]::OpenRead($path)
    try {{ $obj = $bf.Deserialize($fs) }} finally {{ $fs.Close() }}

    $changed = 0
    $list = $obj.$listProp
    if ($null -ne $list) {{
        foreach($r in $list) {{
            if (($r.PSObject.Properties.Name -contains 'GercekSanal') -and
                ($r.PSObject.Properties.Name -contains 'AktifPasif')) {{
                if ([int]$r.GercekSanal -eq 1 -and [int]$r.AktifPasif -eq 1) {{
                    $r.AktifPasif = 0
                    $changed += 1
                }}
            }}
        }}
    }}

    if ($changed -gt 0) {{
        $fsw = [System.IO.File]::Open($path, [System.IO.FileMode]::Create, [System.IO.FileAccess]::Write)
        try {{ $bf.Serialize($fsw, $obj) }} finally {{ $fsw.Close() }}
    }}
    return $changed
}}

$total = 0
$total += Disable-RobotFile '{CONFIG_DIR / 'KodRobot.001'}' 'RobotList'
$total += Disable-RobotFile '{CONFIG_DIR / 'RoboTrade.001'}' 'RoboTradeList'
$total += Disable-RobotFile '{CONFIG_DIR / 'NagantsRobot.001'}' 'RobotList'
$total += Disable-RobotFile '{CONFIG_DIR / 'SablonRobot.001'}' 'RobotList'
$total += Disable-RobotFile '{CONFIG_DIR / 'TaramaRobot.001'}' 'RobotList'

Write-Output "DISABLED=$total"
"""
    cp = run_powershell(ps)
    if cp.returncode != 0:
        return False, f"PowerShell hata: {cp.stderr.strip()}"
    return True, (cp.stdout or "").strip()


def read_pnl_from_csv(path: Path) -> Optional[float]:
    """
    Beklenen kolonlardan birini arar: total_pnl, pnl, kar, profit.
    Birden fazla satir varsa toplamini alir.
    """
    if not path.exists():
        return None

    with path.open("r", encoding="utf-8", errors="replace", newline="") as f:
        reader = csv.DictReader(f)
        if not reader.fieldnames:
            return None
        keys = {k.lower().strip(): k for k in reader.fieldnames}
        col = None
        for c in ("total_pnl", "pnl", "kar", "profit"):
            if c in keys:
                col = keys[c]
                break
        if col is None:
            return None

        total = 0.0
        found = False
        for row in reader:
            try:
                v = str(row[col]).strip().replace(",", ".")
                if v:
                    total += float(v)
                    found = True
            except Exception:
                pass
        return total if found else None


def read_pnl_from_trade_proxy(state: GuardState) -> Tuple[Optional[float], int, int]:
    """
    IslemStruct1 kayitlarindan net money-flow proxy uretir.
    Bu deger gercek hesap PnL'i degildir, yalnizca fallback metriktir.
    """
    pnl = state.current_pnl

    bist_latest = pick_latest_file(BIST_FILE, "ImkbIslem")
    viop_latest = pick_latest_file(VIOP_FILE, "VipIslem")

    last_b = state.last_bist_trade_id
    last_v = state.last_viop_trade_id

    if bist_latest and bist_latest.exists():
        recs = parse_islem_struct1_records(bist_latest)
        for r in recs:
            tid = int(r["TradeID"])
            if tid <= last_b:
                continue
            if int(r["Deleted"]) != 0:
                continue
            side = aggr_side(r["AggresiveParty"])
            pnl += side * r["Price"] * r["Size"]
            if tid > last_b:
                last_b = tid

    if viop_latest and viop_latest.exists():
        recs = parse_islem_struct1_records(viop_latest)
        for r in recs:
            tid = int(r["TradeID"])
            if tid <= last_v:
                continue
            if int(r["Deleted"]) != 0:
                continue
            side = aggr_side(r["AggresiveParty"])
            pnl += side * r["Price"] * r["Size"]
            if tid > last_v:
                last_v = tid

    return pnl, last_b, last_v


def clear_screen() -> None:
    os.system("cls" if os.name == "nt" else "clear")


def print_panel(cfg: GuardConfig, state: GuardState, robots: List[Dict[str, str]], source: str) -> None:
    clear_screen()
    print("=" * 84)
    print("ROBOT MASTER GUARD")
    print("=" * 84)
    print(f"Zaman                : {now_str()}")
    print(f"PnL Kaynagi          : {source}")
    print(f"Mod                  : {'DRY-RUN' if cfg.dry_run else 'LIVE'}")
    print(f"Aktif Gercek Robot   : {len(robots)}")
    print(f"Kar Hedefi           : {cfg.profit_target:.2f}")
    print(f"Trailing DD          : {cfg.trailing_drawdown:.2f}")
    print("-" * 84)
    print(f"Current PnL          : {state.current_pnl:.2f}")
    print(f"Max PnL              : {state.max_pnl:.2f}")
    print(f"Trailing Stop        : {state.trailing_stop:.2f}")
    print(f"Target Reached       : {state.target_reached}")
    print(f"Stop Triggered       : {state.stop_triggered}")
    if state.stop_reason:
        print(f"Stop Reason          : {state.stop_reason}")
    print("-" * 84)
    if robots:
        print("Kaynak  | Robot Adi                     | Sembol       | Hesap/AltHesap")
        print("-" * 84)
        for r in robots[:20]:
            source = str(r.get("Source", ""))[:7].ljust(7)
            name = str(r.get("Name", ""))[:28].ljust(28)
            sym = str(r.get("Symbol", ""))[:12].ljust(12)
            hh = f"{r.get('Hesap', '')}/{r.get('AltHesap', '')}"[:28]
            print(f"{source} | {name} | {sym} | {hh}")
        if len(robots) > 20:
            print(f"... +{len(robots) - 20} robot daha")
    else:
        print("Gercek + aktif robot bulunamadi.")
    print("=" * 84)


def compute_and_guard(cfg: GuardConfig, state: GuardState) -> GuardState:
    source = "none"

    pnl_val: Optional[float] = None
    if cfg.pnl_csv:
        pnl_val = read_pnl_from_csv(cfg.pnl_csv)
        if pnl_val is not None:
            source = f"csv:{cfg.pnl_csv.name}"

    if pnl_val is None and cfg.use_trade_proxy:
        pnl_val, lb, lv = read_pnl_from_trade_proxy(state)
        state.last_bist_trade_id = lb
        state.last_viop_trade_id = lv
        source = "trade_proxy"

    if pnl_val is None:
        return state

    state.current_pnl = pnl_val
    state.max_pnl = max(state.max_pnl, state.current_pnl)

    if state.current_pnl >= cfg.profit_target:
        state.target_reached = True

    if state.target_reached:
        state.trailing_stop = max(cfg.profit_target, state.max_pnl - cfg.trailing_drawdown)
        if not state.stop_triggered and state.current_pnl <= state.trailing_stop:
            ok, msg = disable_all_real_robots(cfg.dry_run)
            state.stop_triggered = ok
            state.stop_reason = f"Trailing stop tetiklendi: {msg}"

    return state


def parse_args() -> GuardConfig:
    p = argparse.ArgumentParser(description="iDeal Robot Master Guard")
    p.add_argument("--profit-target", type=float, default=5000.0, help="Hedef kar")
    p.add_argument("--trailing-dd", type=float, default=1000.0, help="Trailing drawdown")
    p.add_argument("--poll", type=int, default=5, help="Panel yenileme saniyesi")
    p.add_argument("--live", action="store_true", help="Gercek stop yazimi yap")
    p.add_argument("--pnl-csv", type=str, default="", help="PnL kaynagi CSV (opsiyonel)")
    p.add_argument(
        "--no-trade-proxy",
        action="store_true",
        help=".002 trade proxy fallback'ini kapat",
    )
    a = p.parse_args()

    pnl_csv = Path(a.pnl_csv) if a.pnl_csv else None
    return GuardConfig(
        profit_target=a.profit_target,
        trailing_drawdown=a.trailing_dd,
        poll_seconds=max(1, int(a.poll)),
        dry_run=not a.live,
        pnl_csv=pnl_csv,
        use_trade_proxy=not a.no_trade_proxy,
    )


def main() -> None:
    cfg = parse_args()
    state = load_state()

    print("Robot Master Guard baslatiliyor...")
    print(f"Mode: {'DRY-RUN' if cfg.dry_run else 'LIVE'}")
    print("Cikis: Ctrl+C")
    time.sleep(1)

    while True:
        robots = read_real_active_robots()
        prev = state.stop_triggered
        state = compute_and_guard(cfg, state)

        src = "trade_proxy"
        if cfg.pnl_csv and read_pnl_from_csv(cfg.pnl_csv) is not None:
            src = f"csv:{cfg.pnl_csv.name}"

        print_panel(cfg, state, robots, src)
        save_state(state)

        if state.stop_triggered and not prev:
            print("\nSTOP TETIKLENDI. 3 saniye sonra cikiliyor...")
            time.sleep(3)
            break

        time.sleep(cfg.poll_seconds)


if __name__ == "__main__":
    try:
        main()
    except KeyboardInterrupt:
        print("\nKullanici tarafindan durduruldu.")
