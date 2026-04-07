import os
import re
import argparse

def update_version(new_version):
    # Regex: 4.1 or 4.1.0 (X.Y or X.Y.Z)
    version_regex = r'\d+\.\d+(\.\d+)?'
    
    print(f"=== IdealQuant Version Update to v{new_version} ===")
    
    # 1. src/ui/main.py
    main_py_path = os.path.join("src", "ui", "main.py")
    if os.path.exists(main_py_path):
        with open(main_py_path, "r", encoding="utf-8") as f:
            content = f.read()
        
        # app.setApplicationVersion("4.1.0")
        new_content = re.sub(r'app\.setApplicationVersion\("' + version_regex + r'"\)', 
                            f'app.setApplicationVersion("{new_version}")', content)
        
        with open(main_py_path, "w", encoding="utf-8") as f:
            f.write(new_content)
        print(f"[OK] {main_py_path} updated.")

    # 2. build_idealquant.py
    build_py_path = "build_idealquant.py"
    if os.path.exists(build_py_path):
        with open(build_py_path, "r", encoding="utf-8") as f:
            content = f.read()
        
        # "--name=IdealQuant_v4.1"
        new_content = re.sub(r'--name=IdealQuant_v' + version_regex, 
                            f'--name=IdealQuant_v{new_version}', content)
        
        # "dist/IdealQuant_v4.1/IdealQuant_v4.1.exe" (multiple occurrences)
        new_content = re.sub(r'IdealQuant_v' + version_regex, 
                            f'IdealQuant_v{new_version}', new_content)
        
        with open(build_py_path, "w", encoding="utf-8") as f:
            f.write(new_content)
        print(f"[OK] {build_py_path} updated.")

    # 3. ROADMAP.md
    roadmap_path = "ROADMAP.md"
    if os.path.exists(roadmap_path):
        with open(roadmap_path, "r", encoding="utf-8") as f:
            content = f.read()
        
        # "# 🗺️ IdealQuant - Yol Haritası v2.0" -> Sürüm vX.X
        # Actually it has "v2.0" in title and "v4.1 Sistem Hizalaması" in a row.
        # Let's target the "v4.1" specifically if possible or just the first title.
        new_content = re.sub(r'IdealQuant - Yol Haritası v' + version_regex, 
                            f'IdealQuant - Yol Haritası v{new_version}', content)
        
        # Faz 5: v4.1 Sistem Hizalaması
        new_content = re.sub(r'v' + version_regex + r' Sistem Hizalaması', 
                            f'v{new_version} Sistem Hizalaması', new_content)

        with open(roadmap_path, "w", encoding="utf-8") as f:
            f.write(new_content)
        print(f"[OK] {roadmap_path} updated.")

    # 4. src/ui/main_window.py
    mw_path = os.path.join("src", "ui", "main_window.py")
    if os.path.exists(mw_path):
        with open(mw_path, "r", encoding="utf-8") as f:
            content = f.read()

        new_content = re.sub(r'Algorithmic Trading Optimizer v' + version_regex,
                            f'Algorithmic Trading Optimizer v{new_version}', content)

        with open(mw_path, "w", encoding="utf-8") as f:
            f.write(new_content)
        print(f"[OK] {mw_path} updated.")

if __name__ == "__main__":
    parser = argparse.ArgumentParser()
    parser.add_argument("-v", "--version", required=True, help="New version (e.g., 4.2)")
    args = parser.parse_args()
    update_version(args.version)
