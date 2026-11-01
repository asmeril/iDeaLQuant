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
    print("Temizleme islemi basliyor (build/ ve dist/)...")
    def _safe_remove(folder):
        if os.path.exists(folder):
            import stat
            for root, dirs, files in os.walk(folder):
                for f in files:
                    try:
                        os.chmod(os.path.join(root, f), stat.S_IWRITE)
                    except Exception:
                        pass
            try:
                shutil.rmtree(folder)
            except Exception as e:
                print(f"Uyari: {folder} tam silinemedi ({e}), PyInstaller --clean ile devam ediliyor.")

    _safe_remove("build")
    _safe_remove("dist")
    
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
        "--hidden-import=src.strategies.common",
        "--hidden-import=src.strategies.base_strategy",
        "--hidden-import=src.strategies.holidays",
        "--hidden-import=src.strategies.ars_trend_strategy",
        "--hidden-import=src.strategies.ars_trend_v2",
        "--hidden-import=src.strategies.ema_vur_kac_strategy",
        "--hidden-import=src.strategies.toma_strategy",
        "--hidden-import=src.strategies.score_based",
        "--hidden-import=src.strategies.paradise_strategy",
        "--hidden-import=src.strategies.gap_reversal_strategy",
        "--hidden-import=src.strategies.gap_momentum_strategy",
        "--hidden-import=src.strategies.deepscalp_strategy",
        "--hidden-import=src.strategies.tott_hott_strategy",
        "--hidden-import=src.strategies.oliver_kell_s5",
        "--hidden-import=src.strategies.premove_intraday_strategy",
        # Optimization
        "--hidden-import=src.optimization",
        "--hidden-import=src.optimization.strategy8_optimizer",
        "--hidden-import=src.optimization.strategy7_optimizer",
        "--hidden-import=src.optimization.strategy6_optimizer",
        "--hidden-import=src.optimization.strategy5_optimizer",
        "--hidden-import=src.optimization.strategy4_optimizer",
        "--hidden-import=src.optimization.strategy3_optimizer",
        "--hidden-import=src.optimization.strategy2_optimizer",
        "--hidden-import=src.optimization.strategy1_optimizer",
        "--hidden-import=src.optimization.hybrid_group_optimizer",
        "--hidden-import=src.optimization.genetic_optimizer",
        "--hidden-import=src.optimization.bayesian_optimizer",
        # Indicators & others
        "--hidden-import=src.indicators",
        "--hidden-import=src.core",
        "--hidden-import=src.export",
        f"--add-data=src/ui/assets{os.pathsep}src/ui/assets",
        f"--add-data=src/ui/styles{os.pathsep}src/ui/styles",
        f"--add-data=presets{os.pathsep}presets", 
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
