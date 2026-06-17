import re

with open(r"D:\Projects\_secfix\ideal_analysis\ideal_meta.il", "r", encoding="utf-8", errors="replace") as f:
    content = f.read()

typedef_pat = re.compile(r'// TypeDef #\d+ \([0-9a-f]+\)\s*\n// ---+\s*\n(.*?)(?=// TypeDef #\d+|// =====)', re.DOTALL)
result = []

for m in typedef_pat.finditer(content):
    block = m.group(1)
    name_m = re.search(r'TypDefName:\s*(.+?)\s*\(', block)
    if not name_m:
        continue
    name = name_m.group(1).strip()
    if "System.Enum" not in block:
        continue
    vals = []
    for fm in re.finditer(
        r'Field Name:\s*(.+?)\s*\([0-9A-Fa-f]+\).*?'
        r'\n\s*//\s*Flags.*?'
        r'\n(?:.*?\n)*?.*?DefltValue: \(I4\) (\d+)', block):
        fn = fm.group(1).strip()
        fv = fm.group(2)
        if fn != "value__":
            vals.append(f"    {fn} = {fv}")
    if vals:
        result.append(f"\nenum {name}")
        result.extend(vals)

with open(r"D:\Projects\_secfix\ideal_analysis\12_enums_with_values.txt", "w", encoding="utf-8") as f:
    f.write("\n".join(result))

enum_count = len([x for x in result if x.startswith("\nenum ")])
print(f"Enum sayisi: {enum_count}")
for line in result:
    print(line)
