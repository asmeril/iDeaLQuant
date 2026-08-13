import os
import re

with open(r'd:\Projects\IdealQuant\src\strategies\S8_S9_Gap_Strateji.txt', 'r', encoding='utf-8') as f:
    s8_content = f.read()

s8_content = s8_content.replace('S8 GAP REVERSAL + S9 GAP MOMENTUM', 'S8 GAP REVERSAL')
s8_content = s8_content.replace('double S9_Izleyen_Stop_Yuzde = 1.20;', '')
s8_content = s8_content.replace('double S9_Kar_Al_Yuzde = 0.0;', '')
s8_content = s8_content.replace('double extreme_price_s9 = 0;', '')
s8_content = s8_content.replace('bool is_s9 = false;', '')
s8_content = s8_content.replace('is_s8 = true; is_s9 = false;', 'is_s8 = true;')

# Match S9 logic inside the loop
s8_content = re.sub(r'\s*// S9 Ayn[^\n]+K[^\n]+[L|S]ong\)\s*else if \(s9_zaman_ok.*?Sinyal = "[AS]";\s*\}', '', s8_content, flags=re.DOTALL)
s8_content = re.sub(r'else if \(is_s9\)\s*\{.*?GercekFiyat\[i\] =.*?\;\s*\}\s*', '', s8_content, flags=re.DOTALL)

with open(r'd:\Projects\IdealQuant\src\strategies\S8_Gap_Strateji.txt', 'w', encoding='utf-8') as f:
    f.write(s8_content)

print("S8 successfully generated!")
