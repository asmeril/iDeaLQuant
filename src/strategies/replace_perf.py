import os

def replace_perf_panel(filepath, perf_code):
    with open(filepath, 'r', encoding='utf-8-sig', errors='replace') as f:
        lines = f.readlines()
        
    out_lines = []
    for line in lines:
        if "PERFORMANS PANEL" in line:
            break
        out_lines.append(line)
        
    # Append the new perf code
    while out_lines and out_lines[-1].strip() == "":
        out_lines.pop()
        
    out_lines.append("\n\n")
    out_lines.append(perf_code)
    
    with open(filepath, 'w', encoding='utf-8-sig', errors='replace') as f:
        f.writelines(out_lines)

if __name__ == "__main__":
    perf_file = r"d:\Projects\IdealQuant\src\strategies\perf_user.txt"
    with open(perf_file, 'r', encoding='utf-8-sig', errors='replace') as f:
        perf_code = f.read()
        
    files = [
        r"d:\Projects\IdealQuant\src\strategies\S8_Gap_Strateji.txt",
        r"d:\Projects\IdealQuant\src\strategies\S9_Gap_Strateji.txt",
        r"d:\Projects\IdealQuant\src\strategies\S8_S9_Gap_Strateji.txt"
    ]
    
    for file in files:
        replace_perf_panel(file, perf_code)
        print(f"Updated {file}")
