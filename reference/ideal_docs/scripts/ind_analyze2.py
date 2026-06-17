"""
ideal.cxIndicator sınıfını derinlemesine analiz et.
Her CalculateXxx metodunun parametre imzalarını çıkar.
"""
import re, json

lines = open(r'D:\Projects\_secfix\ideal_analysis\ideal_meta.il', encoding='utf-8', errors='ignore').readlines()
typedef_re = re.compile(r'^\s*//\s+TypeDef #\d+')
starts = [i for i, l in enumerate(lines) if typedef_re.match(l)]

def get_method_blocks(block):
    mstarts = [i for i,l in enumerate(block) if re.search(r'//\s+Method #\d+\s+\(', l)]
    out = []
    for mi, ms in enumerate(mstarts):
        me = mstarts[mi+1] if mi+1 < len(mstarts) else len(block)
        out.append(block[ms:me])
    return out

def parse_method(mb):
    mname, ret, params = '', '', []
    for l in mb:
        m = re.search(r'MethodName:\s+(\w+)', l);
        if m and not mname: mname = m.group(1)
        if 'ReturnType:' in l: ret = l.strip().split('ReturnType:')[-1].strip()
        pm = re.search(r'Name\s+:\s+(\w+)\s+flags', l)
        if pm: params.append(pm.group(1))
    # arg types
    arg_types = []
    for l in mb:
        am = re.search(r'Argument #\d+:\s+(.+)', l)
        if am: arg_types.append(am.group(1).strip())
    return mname, ret, params, arg_types

# ────────────────────────────────────────────────────────────────────────────
# 1. cxIndicator'ın tam field + metod imzaları
# ────────────────────────────────────────────────────────────────────────────
for bi, s in enumerate(starts):
    e = starts[bi+1] if bi+1 < len(starts) else len(lines)
    block = lines[s:e]
    classname = ''
    for l in block[:15]:
        td = re.search(r'TypDefName:\s+(\S+)', l)
        if td: classname = td.group(1); break
    if classname != 'ideal.cxIndicator': continue

    print(f"{'='*70}")
    print(f"CLASS: ideal.cxIndicator")
    print(f"{'='*70}")

    # Field adı + tipi
    field_re = re.compile(r'Field #\d+')
    fstarts = [i for i,l in enumerate(block) if field_re.search(l)]
    print(f"\n── FIELDS ({len(fstarts)}) ──")
    for fi, fs in enumerate(fstarts):
        fe = fstarts[fi+1] if fi+1 < len(fstarts) else len(block)
        fb = block[fs:fe]
        fname, ftype = '', ''
        for l in fb:
            fn = re.search(r'Field Name:\s+(\S+)', l)
            if fn: fname = fn.group(1)
            ft = re.search(r'Field type:\s+(.+)', l)
            if ft: ftype = ft.group(1).strip()
        if fname:
            print(f"  {fname:<40} {ftype}")

    # Metod imzaları (Calculate olanlar)
    print(f"\n── CALCULATE METOD İMZALARI ──")
    for mb in get_method_blocks(block):
        mname, ret, params, arg_types = parse_method(mb)
        if not mname.startswith('Calculate'): continue
        typed_params = [f"{t} {p}" if i < len(params) else t
                        for i, (t, p) in enumerate(zip(arg_types, params))]
        # kalan arg_types varsa ekle
        if len(arg_types) > len(params):
            typed_params += arg_types[len(params):]
        sig = f"  {ret} {mname}({', '.join(typed_params) if typed_params else 'void'})"
        print(sig)

    # GetIndicatorValueList imzası
    print(f"\n── DİĞER ÖNEMLİ METODLAR ──")
    for mb in get_method_blocks(block):
        mname, ret, params, arg_types = parse_method(mb)
        if mname in ('GetIndicatorValueList','SelectPriceField','SetAverage',
                     'GetAverageMethod','SetDisplayableBars','ReferensTyepFieldSet',
                     'ShallowCopy'):
            typed_params = [f"{t} {p}" if i < len(params) else t
                            for i, (t, p) in enumerate(zip(arg_types, params))]
            if len(arg_types) > len(params):
                typed_params += arg_types[len(params):]
            sig = f"  {ret} {mname}({', '.join(typed_params) if typed_params else ''})"
            print(sig)
    break

# ────────────────────────────────────────────────────────────────────────────
# 2. GetIndicatorValueList dönüş tipi neyse onu da bul
# ────────────────────────────────────────────────────────────────────────────
print(f"\n{'='*70}")
print("cxIndicator.GetIndicatorValueList imzasının tam metni:")
print(f"{'='*70}")
for bi, s in enumerate(starts):
    e = starts[bi+1] if bi+1 < len(starts) else len(lines)
    block = lines[s:e]
    classname = ''
    for l in block[:15]:
        td = re.search(r'TypDefName:\s+(\S+)', l)
        if td: classname = td.group(1); break
    if classname != 'ideal.cxIndicator': continue
    for mb in get_method_blocks(block):
        mname, _, _, _ = parse_method(mb)
        if mname == 'GetIndicatorValueList':
            for l in mb[:25]:
                print(' ', l.rstrip())
    break

# ────────────────────────────────────────────────────────────────────────────
# 3. İndikatör çıktı sonuç sınıfını bul (cxIndicatorResultRecord, LineRecord vb.)
# ────────────────────────────────────────────────────────────────────────────
print(f"\n{'='*70}")
print("İndikatör sonuç / değer sınıfları:")
print(f"{'='*70}")
for bi, s in enumerate(starts):
    e = starts[bi+1] if bi+1 < len(starts) else len(lines)
    block = lines[s:e]
    classname = ''
    for l in block[:15]:
        td = re.search(r'TypDefName:\s+(\S+)', l)
        if td: classname = td.group(1); break
    if not classname: continue
    keywords = ['LineRecord','IndLine','IndResult','cxSistemLine','IndValue',
                'SistemLine','SistemLineRecord']
    if any(k.lower() in classname.lower() for k in keywords):
        fstarts = [i for i,l in enumerate(block) if re.search(r'Field #\d+', l)]
        fields_typed = []
        for fi, fs in enumerate(fstarts):
            fe = fstarts[fi+1] if fi+1 < len(fstarts) else len(block)
            fb = block[fs:fe]
            fname, ftype = '', ''
            for l in fb:
                fn = re.search(r'Field Name:\s+(\S+)', l)
                if fn: fname = fn.group(1)
                ft = re.search(r'Field type:\s+(.+)', l)
                if ft: ftype = ft.group(1).strip()
            if fname: fields_typed.append(f"{fname}: {ftype}")
        print(f"\n{classname}")
        for ft in fields_typed:
            print(f"  {ft}")
