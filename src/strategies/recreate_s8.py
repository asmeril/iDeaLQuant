import re

filepath = r'd:\Projects\IdealQuant\src\strategies\S8_S9_Gap_Strateji.txt'
outpath = r'd:\Projects\IdealQuant\src\strategies\S8_Gap_Strateji.txt'

with open(filepath, 'r', encoding='utf-8') as f:
    content = f.read()

# Replace header
content = content.replace('STRATEJİ: S8 GAP REVERSAL + S9 GAP MOMENTUM', 'STRATEJİ: S8 GAP REVERSAL')

# Remove variable declarations
content = re.sub(r'double S9_Izleyen_Stop_Yuzde = 1\.20;.*?stop\r?\n', '', content)
content = re.sub(r'double S9_Kar_Al_Yuzde = 0\.0;.*?calissin\r?\n', '', content)
content = content.replace('double extreme_price_s9 = 0;\n', '')
content = content.replace('bool is_s9 = false;\n', '')
content = content.replace('is_s8 = true; is_s9 = false;', 'is_s8 = true;')
content = content.replace('bool s9_zaman_ok = (i - or_end_bar) < 330; // S9 zaman limiti (~15:00)\n', '')

# Remove S9 Entry block (Long)
content = re.sub(r'\s*// S9 Aynı Yön Kırılım \(Long\)\s*else if \(s9_zaman_ok .*?Sinyal = "[AS]";\s*\}', '', content, flags=re.DOTALL)

# Remove S9 Entry block (Short)
content = re.sub(r'\s*// S9 Aynı Yön Kırılım \(Short\)\s*else if \(s9_zaman_ok .*?Sinyal = "[AS]";\s*\}', '', content, flags=re.DOTALL)

# Remove S9 Exit blocks (Long and Short)
# The block starts with `else if (is_s9) {` and ends with `C[i]));\n            }\n        }`
content = re.sub(r'\s*else if \(is_s9\) \{.*?GercekFiyat\[i\].*?\;\s*\}\s*\}', '', content, flags=re.DOTALL)

with open(outpath, 'w', encoding='utf-8') as f:
    f.write(content)
print('Successfully recreated S8_Gap_Strateji.txt')
