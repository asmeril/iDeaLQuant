"""
ideal_meta.il → yapılandırılmış Class/Field/Property/Enum analizi
Çıktılar: D:\Projects\_secfix\ideal_analysis\
"""
import re, os

META_IL = r"D:\Projects\_secfix\ideal_analysis\ideal_meta.il"
OUT_DIR = r"D:\Projects\_secfix\ideal_analysis"

print("Metadata dosyası okunuyor (42MB)...")
with open(META_IL, "r", encoding="utf-8", errors="replace") as f:
    content = f.read()
print(f"Okundu: {len(content)/1024/1024:.1f} MB")

# ─── TypeDef bloklarını bul ──────────────────────────────────────────────────
# Blok formatı:
# // TypeDef #N (token)
# // -------
# //   TypDefName: ClassName (token)
# //   Flags: ...
# //   Extends: ...
# //     Field #N / Method #N / Property #N ...
typedef_pattern = re.compile(
    r'// TypeDef #\d+ \([0-9a-f]+\)\s*\n'
    r'// ---+\s*\n'
    r'(.*?)(?=// TypeDef #\d+|// =====)',
    re.DOTALL
)

# ─── Parse ─────────────────────────────────────────────────────────────────
classes = []
enum_classes = []

for m in typedef_pattern.finditer(content):
    block = m.group(1)
    
    # TypeDef adı
    name_m = re.search(r'TypDefName:\s*(.+?)\s*\(', block)
    if not name_m:
        continue
    class_name = name_m.group(1).strip()
    
    # Flags
    flags_m = re.search(r'Flags\s*:.+?\(([0-9a-fA-F]+)\)', block)
    flags_str = flags_m.group(0) if flags_m else ""
    is_enum   = "Enum" in flags_str or re.search(r'Extends\s*:.*?System\.Enum', block) is not None
    is_iface  = "Interface" in flags_str
    is_public = "Public" in flags_str or "NestedPublic" in flags_str
    
    # Extends
    extends_m = re.search(r'Extends\s*:\s*[0-9a-f]+\s+\[.+?\]\s*(.+)', block)
    extends = extends_m.group(1).strip() if extends_m else ""
    
    # Fields — real (non-backing) + backing (auto-prop)
    fields = []
    for fm in re.finditer(r'Field Name:\s*(.+?)\s*\([0-9A-Fa-f]+\)\s*\n\s*//\s*Flags[^\n]*\n\s*//\s*CallCnvntn[^\n]*\n\s*//\s*Field type:\s*(.+)', block):
        fn = fm.group(1).strip()
        ft = fm.group(2).strip()
        is_backing = 'k__BackingField' in fn
        fields.append({"name": fn, "type": ft, "backing": is_backing})

    # Properties — public getter metotlarından çıkar (get_Xxx → Xxx)
    props = []
    seen_props = set()
    for mm in re.finditer(r'MethodName:\s*(get_\S+)\s*\([0-9A-Fa-f]+\)\s*\n\s*//\s*Flags\s*:.*?(?=\n)\n\s*//\s*RVA[^\n]*\n\s*//\s*ImplFlags[^\n]*\n\s*//\s*CallCnvntn[^\n]*\n\s*//\s*hasThis\s*\n\s*//\s*ReturnType:\s*(.+)', block):
        pname = mm.group(1)[4:]   # 'get_xxx' → 'xxx'
        ptype = mm.group(2).strip()
        if pname and pname not in seen_props:
            seen_props.add(pname)
            props.append({"name": pname, "type": ptype})

    # Methods (sadece isim, getter/setter hariç)
    methods = re.findall(r'MethodName:\s*([^\s(]+)', block)
    methods = [x for x in methods if not x.startswith('.') and not x.startswith('get_') and not x.startswith('set_')]
    
    entry = {
        "name": class_name,
        "is_enum": is_enum,
        "is_interface": is_iface,
        "is_public": is_public,
        "extends": extends,
        "fields": fields,
        "props": props,
        "methods": methods,
    }
    
    if is_enum:
        enum_classes.append(entry)
    else:
        classes.append(entry)

print(f"Sınıf sayısı    : {len(classes)}")
print(f"Enum sayısı     : {len(enum_classes)}")

# ─── Filtrele: Obfuscated (kısa/anlamsız) vs Anlamlı ─────────────────────────
def is_meaningful(name):
    # Anlamsız: tek harf, hash benzeri, <> içerenler (compiler-gen)
    if len(name) <= 2:             return False
    if name.startswith('<'):       return False
    if re.match(r'^[a-z0-9_]{1,3}$', name): return False
    if re.match(r'^[A-Z0-9]{32,}$', name):  return False  # hash-like
    return True

meaningful = [c for c in classes if is_meaningful(c["name"])]
obfuscated = [c for c in classes if not is_meaningful(c["name"])]

print(f"Anlamlı sınıf   : {len(meaningful)}")
print(f"Obfuscated sınıf: {len(obfuscated)}")

# ─── Enum değerlerini çıkar ────────────────────────────────────────────────
for ec in enum_classes:
    # Enum değerler, field olarak geliyor (Literal flaglı)
    vals = [f["name"] for f in ec["fields"] if not f["name"].startswith("value__")]
    ec["values"] = vals

# ─── Çıktı 1: Tüm anlamlı sınıflar + field/property ─────────────────────────
out1 = []
for c in sorted(meaningful, key=lambda x: x["name"]):
    kind = "interface" if c["is_interface"] else "class"
    ext  = f" : {c['extends']}" if c["extends"] and "Object" not in c["extends"] else ""
    out1.append(f"\n{'='*60}")
    out1.append(f"{kind} {c['name']}{ext}")
    out1.append(f"  public={c['is_public']}")
    
    real_fields = [f for f in c["fields"] if not f["backing"] and not f["name"].startswith('<')]
    for f in real_fields:
        out1.append(f"  [field]    {f['type']:<30} {f['name']}")
    for p in c["props"]:
        out1.append(f"  [property] {p['type']:<30} {p['name']}")
    if c["methods"]:
        out1.append(f"  [methods]  {', '.join(c['methods'][:10])}" + (" ..." if len(c["methods"])>10 else ""))

with open(f"{OUT_DIR}\\11_meaningful_classes.txt", "w", encoding="utf-8") as f:
    f.write("\n".join(out1))
print(f"OK 11_meaningful_classes.txt yazildi")

# ─── Çıktı 2: Enum listesi ────────────────────────────────────────────────────
out2 = []
for ec in sorted(enum_classes, key=lambda x: x["name"]):
    if not is_meaningful(ec["name"]):
        continue
    out2.append(f"\nenum {ec['name']}")
    for v in ec.get("values", []):
        out2.append(f"    {v}")

with open(f"{OUT_DIR}\\12_enums_detailed.txt", "w", encoding="utf-8") as f:
    f.write("\n".join(out2))
print(f"✓ 12_enums_detailed.txt yazıldı")

# ─── Çıktı 3: Veri modeli sınıfları (en çok field/property içerenler) ────────
data_classes = sorted(
    [c for c in meaningful if (len(c["fields"]) + len(c["props"])) > 2],
    key=lambda x: -(len(x["fields"]) + len(x["props"]))
)
out3 = []
out3.append("# Veri Modeli Sınıfları (field+property sayısına göre sıralı)\n")
for c in data_classes[:200]:  # En çok 200
    total = len(c["fields"]) + len(c["props"])
    real_f = [f for f in c["fields"] if not f["backing"] and not f["name"].startswith('<')]
    out3.append(f"\n{'─'*50}")
    out3.append(f"class {c['name']}   [{total} üye]")
    for f in real_f:
        out3.append(f"  field   : {f['type']:<30} {f['name']}")
    for p in c["props"]:
        out3.append(f"  property: {p['type']:<30} {p['name']}")

with open(f"{OUT_DIR}\\13_data_models_top200.txt", "w", encoding="utf-8") as f:
    f.write("\n".join(out3))
print(f"✓ 13_data_models_top200.txt yazıldı")

# ─── Çıktı 4: Finans ile ilgili sınıflar ─────────────────────────────────────
fin_kw = re.compile(r'(?i)(hisse|kapanis|acilis|yuksek|dusuk|hacim|bist|viop|endeks|'
                    r'fiyat|piyasa|portfoy|robot|sistem|sinyal|order|emir|baz|spread|'
                    r'arbitraj|kurum|takas|seans|veri|data|bar|ticker|quote|trade|symbol|'
                    r'position|portfolio|strategy|backtest|indicator|signal)')

fin_classes = [c for c in meaningful if fin_kw.search(c["name"])]

out4 = []
out4.append(f"# Finans/Trading İlgili Sınıflar ({len(fin_classes)} adet)\n")
for c in sorted(fin_classes, key=lambda x: x["name"]):
    kind = "interface" if c["is_interface"] else "class"
    out4.append(f"\n{'─'*50}")
    out4.append(f"{kind} {c['name']}")
    real_f = [f for f in c["fields"] if not f["backing"] and not f["name"].startswith('<')]
    for f in real_f:
        out4.append(f"  field   : {f['type']:<30} {f['name']}")
    for p in c["props"]:
        out4.append(f"  property: {p['type']:<30} {p['name']}")

with open(f"{OUT_DIR}\\14_finance_classes.txt", "w", encoding="utf-8") as f:
    f.write("\n".join(out4))
print(f"✓ 14_finance_classes.txt yazıldı ({len(fin_classes)} sınıf)")

# ─── Çıktı 5: Obfuscated ama field içerenler ─────────────────────────────────
obf_with_fields = [c for c in obfuscated if (len(c["fields"]) + len(c["props"])) > 3]
out5 = []
out5.append(f"# Obfuscated sınıflar (alan içerenler) — {len(obf_with_fields)} adet\n")
out5.append("NOT: Obfuscated sınıflar orijinal isimlerini kaybetmiş ama içerikleri kalıcı\n")
for c in sorted(obf_with_fields, key=lambda x: -(len(x["fields"])+len(x["props"])))[:100]:
    total = len(c["fields"]) + len(c["props"])
    out5.append(f"\nclass {c['name']}  [{total} üye]")
    real_f = [f for f in c["fields"] if not f["backing"] and not f["name"].startswith('<')]
    for f in real_f[:10]:
        out5.append(f"  field: {f['type']:<25} {f['name']}")
    for p in c["props"][:10]:
        out5.append(f"  prop:  {p['type']:<25} {p['name']}")

with open(f"{OUT_DIR}\\15_obfuscated_classes.txt", "w", encoding="utf-8") as f:
    f.write("\n".join(out5))
print(f"✓ 15_obfuscated_classes.txt yazıldı")

# ─── Özet rapor ──────────────────────────────────────────────────────────────
summary = f"""
# ideal.exe — Analiz Özeti
Tarih      : 2026-04-11
Dosya      : D:\\iDeal\\ideal.exe (17.5 MB, .NET 4.6, x86)
MVID       : 54F36D18-35C8-4D4A-A0D4-BC34219BABC3

## Tip İstatistikleri
- Toplam TypeDef    : {len(classes) + len(enum_classes)}
- Anlamlı sınıf    : {len(meaningful)}
- Obfuscated sınıf : {len(obfuscated)}
- Enum             : {len(enum_classes)}
- Veri modeli sınıf: {len(data_classes)}
- Finans sınıfı    : {len(fin_classes)}

## Koruma Durumu
- ildasm: "Protected module" hatası (IL kodu dump edilemedi)
- Metadata: Başarıyla okundu (42MB)
- Bilinen obfuscator imzası: YOK
- Kısa/hash-like sınıf isimleri: {len(obfuscated)} adet → hafif obfuscation var

## Önemli Teknik Alanlar (String Analizi)
- Finans string'leri       : 3068
- DB/SQL ilgili string'ler : 1499
- Network string'leri      : 1021
- Sütun adı benzeri string : 878

## Platform
- Makine: x86 (0x014C)
- Runtime: .NET Framework 4.6
- Sections: .text (17.4MB), .rsrc (22KB), .reloc (0.5KB)

## İlgili Çıktı Dosyaları
- 11_meaningful_classes.txt    — Anlamlı tüm class/interface + fields/props
- 12_enums_detailed.txt        — Tüm enum değerleri
- 13_data_models_top200.txt    — En çok alana sahip 200 veri modeli
- 14_finance_classes.txt       — Finans/Trading ilgili sınıflar
- 15_obfuscated_classes.txt    — Obfuscated ama içerik dolu sınıflar
- 06_strings_ascii.txt         — 111K ASCII string
- 07_strings_unicode.txt       — 26K Unicode string
- 08_cat_finance.txt           — 3068 finans string'i
- 08_cat_column_name.txt       — 878 sütun adı / enum değeri
"""

with open(f"{OUT_DIR}\\00_ANALIZ_OZET.txt", "w", encoding="utf-8") as f:
    f.write(summary)
print(summary)
print("\n=== TAMAMLANDI ===")
