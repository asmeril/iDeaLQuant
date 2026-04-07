import os
import sys
import subprocess
import shutil

def main():
    print("=== IdealQuant Build Script ===")
    
    # Proje kök dizini
    project_root = os.path.dirname(os.path.abspath(__file__))
    os.chdir(project_root)
    
    # 1. PyInstaller kurulu mu kontrolü
    try:
        import PyInstaller
        print(f"PyInstaller version found: {PyInstaller.__version__}")
    except ImportError:
        print("PyInstaller not found. Installing...")
        subprocess.check_call([sys.executable, "-m", "pip", "install", "pyinstaller"])
    
    # 2. Önceden kalıcı build klasörlerini temizle
    print("Temizleme islami basliyor (build/ ve dist/)...")
    if os.path.exists("build"):
        shutil.rmtree("build")
    if os.path.exists("dist"):
        shutil.rmtree("dist")
    
    # 3. PyInstaller komut argümanları
    main_script = os.path.join("src", "ui", "main.py")
    
    pyinstaller_args = [
        sys.executable, "-m", "PyInstaller",
        "--name=IdealQuant_v5.0",
        "--onefile",           # Tek bir EXE haline getir
        "--noconfirm",         # Sormadan uzerine yaz
        "--clean",
        "--windowed",          # Konsol penceresi acma (Sadece arayuz)
        # Core
        "--hidden-import=multiprocessing.pool",
        "--hidden-import=multiprocessing.util",
        "--hidden-import=multiprocessing.managers",
        "--hidden-import=numba",
        "--hidden-import=numba.core",
        "--hidden-import=numba.typed",
        "--hidden-import=optuna",
        "--hidden-import=scipy.optimize",
        # Strategies
        "--hidden-import=src.strategies",
        "--hidden-import=src.strategies.gap_reversal_strategy",
        "--hidden-import=src.strategies.deepscalp_strategy",
        "--hidden-import=src.strategies.tott_hott_strategy",
        "--hidden-import=src.strategies.oliver_kell_s5",
        # Optimization
        "--hidden-import=src.optimization",
        "--hidden-import=src.optimization.strategy8_optimizer",
        "--hidden-import=src.optimization.strategy7_optimizer",
        "--hidden-import=src.optimization.hybrid_group_optimizer",
        # Indicators & others
        "--hidden-import=src.indicators",
        "--hidden-import=src.core",
        "--hidden-import=src.export",
        "--add-data=src/ui/assets:src/ui/assets",
        "--add-data=src/ui/styles:src/ui/styles",
        "--add-data=presets:presets", 
        main_script
    ]
    
    print("Derleme islemi basliyor, bu islem 1-3 dakika srebilir...")
    print(f"Komut: {' '.join(pyinstaller_args)}")
    
    # 4. Derlemeyi çalıştır
    result = subprocess.run(pyinstaller_args)
    
    if result.returncode == 0:
        print("\n=== DERLEME BASARILI! ===")
        print(f"Execute edin: {os.path.join(project_root, 'dist', 'IdealQuant_v5.0.exe')}")
    else:
        print("\n=== DERLEME BASARISIZ! ===")
        
if __name__ == "__main__":
    main()
