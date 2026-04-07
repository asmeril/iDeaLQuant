# -*- coding: utf-8 -*-
"""
IdealQuant - Main Entry Point
Uygulamayı başlatır
"""

import sys
import os
import multiprocessing

# CRITICAL: freeze_support MUST be called UNCONDITIONALLY at module level.
# When PyInstaller spawns a worker sub-process, it re-executes this file with
# __name__ == '__main__'. freeze_support() detects that it's a worker and
# exits early — BEFORE Qt/GUI imports happen. If it's inside an if-guard,
# the worker may run the full main() and cause WinError 5 / PermissionError.
multiprocessing.freeze_support()

# Proje kök dizinini path'e ekle
sys.path.insert(0, os.path.abspath(os.path.join(os.path.dirname(__file__), '..', '..')))


def _cleanup_workers():
    """Uygulama kapanirken tum alt islemleri temizle"""
    for child in multiprocessing.active_children():
        try:
            child.terminate()
            child.join(timeout=1)
        except Exception:
            pass


def main():
    """Ana uygulama başlatıcı"""
    # Heavy imports INSIDE main() — worker sub-processes must NOT import PySide6
    import atexit
    from PySide6.QtWidgets import QApplication
    from PySide6.QtCore import Qt
    from PySide6.QtGui import QFont
    from src.ui.main_window import MainWindow

    # Frozen (PyInstaller) exe'de worker'ların doğru EXE'yi kullanmasını sağla
    if getattr(sys, 'frozen', False):
        multiprocessing.set_executable(sys.executable)

    atexit.register(_cleanup_workers)
    
    print("[DEBUG] App Starting...")
    # High DPI desteği
    QApplication.setHighDpiScaleFactorRoundingPolicy(
        Qt.HighDpiScaleFactorRoundingPolicy.PassThrough
    )
    
    app = QApplication(sys.argv)
    app.setApplicationName("IdealQuant")
    app.setApplicationVersion("5.0")
    app.setOrganizationName("IdealQuant")
    
    # Varsayılan font
    font = QFont("Segoe UI", 10)
    app.setFont(font)
    
    # Ana pencere
    window = MainWindow()
    window.showMaximized()
    
    # Uygulama döngüsü
    exit_code = app.exec()
    _cleanup_workers()
    sys.exit(exit_code)


if __name__ == "__main__":
    # Explicitly set spawn method for Windows — prevents WinError 5 (handle
    # inheritance blocked by UAC/antivirus in frozen executables).
    try:
        multiprocessing.set_start_method('spawn', force=True)
    except RuntimeError:
        pass  # Already set (e.g. in development mode)
    main()

