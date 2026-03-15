# -*- mode: python ; coding: utf-8 -*-


a = Analysis(
    ['src\\ui\\main.py'],
    pathex=[],
    binaries=[],
    datas=[('src/ui/assets', 'src/ui/assets'), ('src/ui/styles', 'src/ui/styles'), ('presets', 'presets')],
    hiddenimports=['numba', 'optuna', 'scipy.optimize', 'src.strategies', 'src.indicators', 'src.optimization', 'src.core', 'src.export'],
    hookspath=[],
    hooksconfig={},
    runtime_hooks=[],
    excludes=[],
    noarchive=False,
    optimize=0,
)
pyz = PYZ(a.pure)

exe = EXE(
    pyz,
    a.scripts,
    [],
    exclude_binaries=True,
    name='IdealQuant_v4.1',
    debug=False,
    bootloader_ignore_signals=False,
    strip=False,
    upx=True,
    console=False,
    disable_windowed_traceback=False,
    argv_emulation=False,
    target_arch=None,
    codesign_identity=None,
    entitlements_file=None,
)
coll = COLLECT(
    exe,
    a.binaries,
    a.datas,
    strip=False,
    upx=True,
    upx_exclude=[],
    name='IdealQuant_v4.1',
)
