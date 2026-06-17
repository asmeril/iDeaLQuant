import re

lines = open(r'D:\Projects\_secfix\ideal_analysis\ideal_meta.il', encoding='utf-8', errors='ignore').readlines()

# Metadata dosyasının yapısı:
# Her typedef bloğu TypeName ile başlar, altında MethodName'ler gelir
# Ama TypeName bir kez geçiyor, MethodName'ler birden fazla TypeDef'e dağılmış
# Token aralıklarını kullanarak eşleştireceğiz

# TypeDef -> token aralıgı: her TypeDef bloğu kendi MethodList token aralığına sahip
# Daha basit yaklaşım: satır numarası bazlı, TypeName gördükten sonra gelen metodları topla

cur_type = ''
cur_ns = ''
type_methods = {}  # (ns.type, line_no) -> [method_names]
type_start = {}

for i, l in enumerate(lines):
    tn = re.search(r'TypeName:\s+(\S+)', l)
    if tn:
        cur_type = tn.group(1)
        cur_ns_disp = cur_ns if cur_ns else 'ideal'
        key = f"{cur_ns_disp}.{cur_type}"
        if key not in type_methods:
            type_methods[key] = []
            type_start[key] = i

    nsm = re.search(r'TypeNamespace:\s+(\S+)', l)
    if nsm:
        cur_ns = nsm.group(1)

    mm = re.search(r'MethodName:\s+(\w+)', l)
    if mm and cur_type:
        cur_ns_disp = cur_ns if cur_ns else 'ideal'
        key = f"{cur_ns_disp}.{cur_type}"
        type_methods.setdefault(key, []).append(mm.group(1))

# Sadece Teminat metodu içerenleri bas
print("=== CalculateTeminat içeren sınıflar ===")
for cls, meths in type_methods.items():
    if 'CalculateTeminat' in meths:
        print(f"\nSinif: {cls}")
        calc = [m for m in meths if m.startswith('Calculate')]
        print(f"  Tüm Calculate metodları ({len(calc)}):")
        for m in sorted(set(calc)):
            print(f"    {m}")

print("\n=== Teminat property/metod içeren sınıflar ===")
for cls, meths in type_methods.items():
    tems = [m for m in meths if 'eminat' in m and 'CalculateTeminat' not in m]
    if tems:
        print(f"\nSinif: {cls}")
        for m in sorted(set(tems)):
            print(f"  {m}")
