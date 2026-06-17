import re

lines = open(r'D:\Projects\_secfix\ideal_analysis\ideal_meta.il', encoding='utf-8', errors='ignore').readlines()

# ---- 1. TypeDef bloklarını bul ----
# Her TypeDef bloğu "TypeName: X" ile başlar
# Aynı blok içindeki MethodName'ler o sınıfa ait

typedef_starts = []  # (line_idx, ns, name)
for i, l in enumerate(lines):
    if re.search(r'^\s*//\s+TypeDef #\d+', l):
        typedef_starts.append(i)

print(f"Toplam TypeDef blogu: {len(typedef_starts)}")

# ---- 2. Her blok için TypeName + MethodName topla ----
# Blok: typedef_starts[i] .. typedef_starts[i+1]-1
type_info = []  # (ns, name, [methods])

for bi, start in enumerate(typedef_starts):
    end = typedef_starts[bi+1] if bi+1 < len(typedef_starts) else len(lines)
    block = lines[start:end]

    ns = ''
    name = ''
    methods = []
    for l in block:
        m = re.search(r'TypeNamespace:\s+(\S+)', l)
        if m: ns = m.group(1)
        m = re.search(r'TypeName:\s+(\S+)', l)
        if m: name = m.group(1)
        m = re.search(r'MethodName:\s+(\w+)', l)
        if m: methods.append(m.group(1))

    type_info.append((ns, name, methods))

# ---- 3. CalculateTeminat veya Teminat içerenleri goster ----
print("\n=== CalculateTeminat iceren siniflar ===")
for ns, name, methods in type_info:
    if 'CalculateTeminat' in methods:
        full = f"{ns}.{name}" if ns else name
        print(f"\n  Sinif: {full}")
        calcs = sorted(set(m for m in methods if m.startswith('Calculate')))
        print(f"  Calculate metodlari ({len(calcs)}):")
        for c in calcs:
            print(f"    {c}")
        gets = sorted(set(m for m in methods if 'get_' in m))
        if gets:
            print(f"  Property get'ler ({len(gets)}):")
            for g in gets[:20]:
                print(f"    {g}")

print("\n=== Teminat property'leri iceren siniflar ===")
for ns, name, methods in type_info:
    tems = [m for m in methods if 'eminat' in m.lower() and 'CalculateTeminat' not in m]
    if tems:
        full = f"{ns}.{name}" if ns else name
        print(f"\n  Sinif: {full}")
        for m in sorted(set(tems)):
            # get_/set_ temizle
            pretty = re.sub(r'^(?:get|set)_', '', m)
            print(f"    {pretty}  ({m})")
