"""
ideal.exe — İndikatör Hesaplama Analizi
İndikatör parametrelerini, çıktı alanlarını ve hesaplama mantığını çıkarır.
"""
import re, json

lines = open(r'D:\Projects\_secfix\ideal_analysis\ideal_meta.il', encoding='utf-8', errors='ignore').readlines()
typedef_re = re.compile(r'^\s*//\s+TypeDef #\d+')
starts = [i for i, l in enumerate(lines) if typedef_re.match(l)]

def get_methods(block):
    result = []
    for l in block:
        m = re.search(r'MethodName:\s+(\w+)', l)
        if m: result.append(m.group(1))
    return result

def get_fields(block):
    result = []
    for l in block:
        m = re.search(r'Field Name:\s+(\S+)', l)
        if m: result.append(m.group(1))
    return result

def get_method_sigs(block):
    """Method adı → (dönüş tipi, parametreler) dict"""
    msig = {}
    mstarts = [i for i,l in enumerate(block) if re.search(r'//\s+Method #\d+\s+\(', l)]
    for mi, ms in enumerate(mstarts):
        me = mstarts[mi+1] if mi+1 < len(mstarts) else len(block)
        mb = block[ms:me]
        mname = ''
        for l in mb[:5]:
            m = re.search(r'MethodName:\s+(\w+)', l)
            if m: mname = m.group(1); break
        if not mname: continue
        ret, params = '', []
        for l in mb:
            if 'ReturnType:' in l: ret = l.strip().split('ReturnType:')[-1].strip()
            pm = re.search(r'Name\s+:\s+(\w+)\s+flags', l)
            if pm: params.append(pm.group(1))
        msig[mname] = {'return': ret, 'params': params}
    return msig

# ────────────────────────────────────────────────────────────────────────────
# 1. İndikatör değer/parametre sınıflarını bul
# ────────────────────────────────────────────────────────────────────────────
ind_classes = {}
for bi, s in enumerate(starts):
    e = starts[bi+1] if bi+1 < len(starts) else len(lines)
    block = lines[s:e]
    classname = ''
    for l in block[:15]:
        td = re.search(r'TypDefName:\s+(\S+)', l)
        if td: classname = td.group(1); break
    if not classname: continue
    if any(k in classname for k in ['Indicat','cxInd','IndParam','IndVal','TechInd','Indikat']):
        fields  = get_fields(block)
        methods = get_methods(block)
        ind_classes[classname] = {'fields': fields, 'methods': [m for m in methods if not m.startswith(('get_','set_','<'))]}

print(f"{'='*60}")
print(f"İNDİKATÖR SINIFLAR: {len(ind_classes)}")
print(f"{'='*60}")
for cls, d in sorted(ind_classes.items()):
    print(f"\n{cls}")
    if d['fields']:  print(f"  Fields ({len(d['fields'])}): {d['fields'][:15]}")
    if d['methods']: print(f"  Methods: {d['methods'][:20]}")

# cxBasic'teki *indikatör sonuç* fieldları ara
# (Result, Val, Line, Output, Ind, Buf gibi kelimeler içeren)
print(f"\n{'='*60}")
print("cxBasic İNDİKATÖR SONUÇ ALANLARI")
print(f"{'='*60}")
for bi, s in enumerate(starts):
    e = starts[bi+1] if bi+1 < len(starts) else len(lines)
    block = lines[s:e]
    classname = ''
    for l in block[:15]:
        td = re.search(r'TypDefName:\s+(\S+)', l)
        if td: classname = td.group(1); break
    if classname != 'ideal.cxBasic': continue
    fields = get_fields(block)
    # Indikatör çıktısı gibi görünen alanlar
    ind_fields = [f for f in fields if any(k in f for k in
        ['Line','Output','Result','Buf','Ind','Value','Val','Upper','Lower','Band',
         'Signal','Hist','Macd','Rsi','Bb','Ma','Ema','Atr','Stoch','Adx','Cci',
         'Obv','Pvt','Mfi','Roc','Trix','Aroon','Sar','Ichimoku','Keltner',
         'Bollinger','Alligator','Zigzag','Pivot','Fibonacci',
         'Chart','Ind','Calcul'])]
    print(f"  İndikatör benzeri alan sayısı: {len(ind_fields)}")
    for f in ind_fields[:50]:
        print(f"    {f}")
    break
