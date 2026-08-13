import re

# 1. Read recovered.txt and extract panel
with open(r'd:\Projects\IdealQuant\recovered.txt', 'r', encoding='utf-8') as f:
    lines = f.readlines()
    
panel_lines = lines[2:258] # Lines 3 to 257 (0-indexed 2 to 258 exclusive)
panel_code = "".join(panel_lines)

# 2. Modify panel code for visual fixes
# "Karlı günler kırmızı zararlı günler yeşil" -> swap colors
panel_code = panel_code.replace("Sistem.DolguEkle(0, 1, Color.Red, Color.Green);", "Sistem.DolguEkle(0, 1, Color.Green, Color.Red);")

# Remove blue lines (transparent)
panel_code = panel_code.replace(
    "Sistem.Cizgiler[0].ActiveBool = true;",
    "Sistem.Cizgiler[0].ActiveBool = true;\n    Sistem.Cizgiler[0].Renk = Color.Transparent;"
)
panel_code = panel_code.replace(
    "Sistem.Cizgiler[1].ActiveBool = true;",
    "Sistem.Cizgiler[1].ActiveBool = true;\n    Sistem.Cizgiler[1].Renk = Color.Transparent;"
)

# Fix Environment.NewLine formatting which Ideal doesn't always like, change to \r\n
panel_code = panel_code.replace(' + Environment.NewLine + ', ' + "\\r\\n" + ')
panel_code = panel_code.replace(' + Environment.NewLine', ' + "\\r\\n"')
panel_code = panel_code.replace('Environment.NewLine + ', '"\\r\\n" + ')
# Fix bug in user code: Sistem.GetiriKZGun is an Ideal specific system command but they are using SanalGetiri!
# Oh wait, in recovered.txt the user changed to Sistem.GetiriKZGun. But they previously used CizgiKapaliKZ!
# Wait! S9_Gap_Strateji.txt that user uploaded uses SanalGetiri instead of GetiriHesapla.
