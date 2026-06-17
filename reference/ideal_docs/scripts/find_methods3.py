import re

lines = open(r'D:\Projects\_secfix\ideal_analysis\ideal_meta.il', encoding='utf-8', errors='ignore').readlines()
typedef_re = re.compile(r'^\s*//\s+TypeDef #\d+')
starts = [i for i, l in enumerate(lines) if typedef_re.match(l)]

print(f"TypeDef blogu: {len(starts)}")

for bi, s in enumerate(starts):
    e = starts[bi+1] if bi+1 < len(starts) else len(lines)
    block = lines[s:e]

    methods = []
    for l in block:
        m = re.search(r'MethodName:\s+(\w+)', l)
        if m:
            methods.append(m.group(1))

    if 'CalculateTeminat' in methods:
        # TypDefName
        classname = ''
        for l in block[:15]:
            td = re.search(r'TypDefName:\s+(\S+)', l)
            if td:
                classname = td.group(1)
                break
        print(f"\n=== SINIF: {classname} (Blok {bi+1}) ===")
        print(f"Toplam metod: {len(methods)}")
        for m in methods:
            print(f"  {m}")

# Teminat property'leri
print("\n\n=== Teminat property'lerini iceren sinif ===")
for bi, s in enumerate(starts):
    e = starts[bi+1] if bi+1 < len(starts) else len(lines)
    block = lines[s:e]
    methods = []
    for l in block:
        m = re.search(r'MethodName:\s+(\w+)', l)
        if m:
            methods.append(m.group(1))
    tems = [m for m in methods if 'eminat' in m.lower()]
    if tems:
        classname = ''
        for l in block[:15]:
            td = re.search(r'TypDefName:\s+(\S+)', l)
            if td:
                classname = td.group(1)
                break
        # fields de alalim
        fields = []
        for l in block:
            fld = re.search(r'Field Name:\s+(\S+)', l)
            if fld:
                fields.append(fld.group(1))
        print(f"\nSinif: {classname}")
        print(f"  Teminat metodlari: {tems}")
        if fields:
            print(f"  Alanlar: {fields}")
