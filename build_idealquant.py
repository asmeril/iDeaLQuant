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
        "--name=IdealQuant_v4.8",
        "--onefile",           # Tek bir EXE haline getir
        "--noconfirm",         # Sormadan uzerine yaz
        "--clean",
        "--windowed",          # Konsol penceresi acma (Sadece arayuz)
        "--hidden-import=numba",
        "--hidden-import=optuna",
        "--hidden-import=scipy.optimize",
        "--hidden-import=src.strategies",
        "--hidden-import=src.indicators",
        "--hidden-import=src.optimization",
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
        print(f"Execute edin: {os.path.join(project_root, 'dist', 'IdealQuant_v4.8.exe')}")
    else:
        print("\n=== DERLEME BASARISIZ! ===")
        
if __name__ == "__main__":
    main()
