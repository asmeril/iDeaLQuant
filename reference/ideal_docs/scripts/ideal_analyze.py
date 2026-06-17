"""
ideal.exe — Binary String & PE Metadata Analizi
Çıktı: D:\Projects\_secfix\ideal_analysis\
"""
import os, re, struct, sys

EXE_PATH = r"D:\iDeal\ideal.exe"
OUT_DIR  = r"D:\Projects\_secfix\ideal_analysis"
os.makedirs(OUT_DIR, exist_ok=True)

data = open(EXE_PATH, "rb").read()
print(f"Dosya boyutu: {len(data)/1024/1024:.1f} MB")

# ─── 1) Printable ASCII Strings (min 5 karakter) ──────────────────────────────
print("String'ler taranıyor...")
ascii_strings = re.findall(rb'[ -~]{5,}', data)
ascii_strings = [s.decode('ascii', errors='replace') for s in ascii_strings]
with open(f"{OUT_DIR}\\06_strings_ascii.txt", "w", encoding="utf-8") as f:
    for s in ascii_strings:
        f.write(s + "\n")
print(f"  ASCII string: {len(ascii_strings)}")

# ─── 2) Unicode (UTF-16 LE) Strings ──────────────────────────────────────────
print("Unicode string'ler taranıyor...")
unicode_strings = re.findall(rb'(?:[\x20-\x7e]\x00){4,}', data)
unicode_strings = [s.decode('utf-16-le', errors='replace').strip('\x00') for s in unicode_strings]
with open(f"{OUT_DIR}\\07_strings_unicode.txt", "w", encoding="utf-8") as f:
    for s in unicode_strings:
        f.write(s + "\n")
print(f"  Unicode string: {len(unicode_strings)}")

# ─── 3) .NET UserString Heap (0x70 stream) ────────────────────────────────────
# .NET metadata string heap'ini bul
# Signature: "BSJB" (CLI header magic)
bsjb_pos = data.find(b'BSJB')
net_strings = []
if bsjb_pos != -1:
    print(f"  .NET BSJB header: offset 0x{bsjb_pos:X}")
    # Version string hemen ardından
    ver_len = struct.unpack_from('<I', data, bsjb_pos + 12)[0]
    flags   = struct.unpack_from('<H', data, bsjb_pos + 16 + ver_len)[0]
    streams = struct.unpack_from('<H', data, bsjb_pos + 18 + ver_len)[0]
    print(f"  Stream sayısı: {streams}")
    
    # #US (UserStrings) stream'ini bul
    us_pos = data.find(b'#US\x00')
    if us_pos != -1:
        print(f"  #US stream offset hint: 0x{us_pos:X}")
    
    # #Strings stream
    str_pos = data.find(b'#Strings\x00')
    if str_pos != -1:
        print(f"  #Strings stream offset hint: 0x{str_pos:X}")

# ─── 4) Özel Filtreler: İlgili içerik ─────────────────────────────────────────
print("Kategorik filtreleme...")

categories = {
    "network":    r'(?i)(tcp|udp|http|socket|host|port|connect|ssl|tls|endpoint|server|client|websocket)',
    "database":   r'(?i)(select|insert|update|delete|from|where|join|table|column|sql|sqlite|oledb|odbc)',
    "finance":    r'(?i)(hisse|borsa|fiyat|kapanis|acilis|yuksek|dusuk|hacim|bist|viop|endeks|lot|miktar|macd|rsi|ema)',
    "file_path":  r'(?i)(\\[a-z_]+\\|\.xml|\.json|\.csv|\.txt|\.ini|\.cfg|\.db)',
    "class_like": r'^[A-Z][a-zA-Z0-9_]{3,}$',
    "column_name":r'^[A-Z_][A-Z0-9_]{3,}$',
    "dll_import": r'(?i)(\.dll|import|extern|pinvoke)',
}

cat_results = {k: [] for k in categories}
for s in ascii_strings:
    for cat, pattern in categories.items():
        if re.search(pattern, s):
            cat_results[cat].append(s)

for cat, items in cat_results.items():
    items_unique = sorted(set(items))
    path = f"{OUT_DIR}\\08_cat_{cat}.txt"
    with open(path, "w", encoding="utf-8") as f:
        f.write(f"# Kategori: {cat} ({len(items_unique)} öğe)\n\n")
        for item in items_unique:
            f.write(item + "\n")
    print(f"  {cat}: {len(items_unique)} string")

# ─── 5) PE Section bilgisi ────────────────────────────────────────────────────
print("PE section analizi...")
if data[:2] == b'MZ':
    pe_offset = struct.unpack_from('<I', data, 0x3C)[0]
    sig = data[pe_offset:pe_offset+4]
    if sig == b'PE\x00\x00':
        machine   = struct.unpack_from('<H', data, pe_offset+4)[0]
        sections  = struct.unpack_from('<H', data, pe_offset+6)[0]
        opt_size  = struct.unpack_from('<H', data, pe_offset+20)[0]
        sections_offset = pe_offset + 24 + opt_size
        
        pe_info = [
            f"Machine    : 0x{machine:04X} ({'x86' if machine==0x14C else 'x64' if machine==0x8664 else 'AnyCPU/MSIL'})",
            f"Section sz : {sections}",
        ]
        
        for i in range(sections):
            off = sections_offset + i * 40
            name = data[off:off+8].rstrip(b'\x00').decode('ascii', errors='replace')
            vsize = struct.unpack_from('<I', data, off+8)[0]
            rva   = struct.unpack_from('<I', data, off+12)[0]
            rsize = struct.unpack_from('<I', data, off+16)[0]
            chars = struct.unpack_from('<I', data, off+36)[0]
            pe_info.append(f"  Section [{i}]: {name:<8}  VA=0x{rva:08X}  VSize={vsize:>8}  RSize={rsize:>8}  Flags=0x{chars:08X}")
        
        with open(f"{OUT_DIR}\\09_pe_sections.txt", "w", encoding="utf-8") as f:
            f.write("\n".join(pe_info))
        for line in pe_info:
            print(" ", line)

# ─── 6) Koruma tespiti ────────────────────────────────────────────────────────
print("\nKoruma tespiti...")
protection_signatures = {
    "Dotfuscator":     b'DotfuscatorAttribute',
    "SmartAssembly":   b'SmartAssembly',
    "Obfuscar":        b'obfuscar',
    "Confuser":        b'ConfusedByAttribute',
    "ConfuserEx":      b'ConfuserExAttribute',
    "Reactor":         b'.NET Reactor',
    "DeepSea":         b'DeepSea',
    "Crypto Obfs":     b'CryptoObfuscator',
    "Eazfuscator":     b'Eazfuscator',
    "MaxtoCode":       b'MaxtoCode',
    "ILProtector":     b'ILProtector',
    "Xenocode":        b'Xenocode',
    "NetGuard":        b'NetGuard',
}

found_protections = []
for name, sig in protection_signatures.items():
    if sig.lower() in data.lower():
        found_protections.append(name)
        print(f"  [!] BULUNDU: {name}")

if not found_protections:
    print("  Bilinen koruma imzası bulunamadı — özel/hafif koruma veya korumasız")

with open(f"{OUT_DIR}\\10_protection_analysis.txt", "w", encoding="utf-8") as f:
    f.write("# Koruma Analizi\n\n")
    f.write(f"Bulunan korumalar: {found_protections if found_protections else 'Tespit edilemedi'}\n\n")
    # ildasm hatası zaten "Protected module" dedi, bu flag'i kaydet
    f.write("NOT: ildasm 'Protected module' hatası verdi — CF_STRONGNAME veya custom flag\n")

print(f"\n=== TAMAMLANDI ===")
print(f"Çıktı dizini: {OUT_DIR}")
for fname in sorted(os.listdir(OUT_DIR)):
    fpath = os.path.join(OUT_DIR, fname)
    print(f"  {fname:<45} {os.path.getsize(fpath)/1024:.1f} KB")
