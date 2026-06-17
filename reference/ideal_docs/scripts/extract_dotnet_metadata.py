#!/usr/bin/env python3
"""Extract .NET metadata from ideal.exe without external dependencies.

This does not bypass protection or decrypt method bodies. It reads the CLR
metadata streams (#~, #Strings, #Blob, #GUID) and produces a richer API map:
types, fields, methods, params, properties, events, P/Invoke imports and
external member references.
"""

import argparse
import csv
import json
import os
import re
import struct
from pathlib import Path


TABLE_NAMES = {
    0: "Module", 1: "TypeRef", 2: "TypeDef", 4: "Field", 6: "MethodDef", 8: "Param",
    9: "InterfaceImpl", 10: "MemberRef", 11: "Constant", 12: "CustomAttribute",
    13: "FieldMarshal", 14: "DeclSecurity", 15: "ClassLayout", 16: "FieldLayout",
    17: "StandAloneSig", 18: "EventMap", 20: "Event", 21: "PropertyMap",
    23: "Property", 24: "MethodSemantics", 25: "MethodImpl", 26: "ModuleRef",
    27: "TypeSpec", 28: "ImplMap", 29: "FieldRVA", 32: "Assembly", 35: "AssemblyRef",
    38: "File", 39: "ExportedType", 40: "ManifestResource", 41: "NestedClass",
    42: "GenericParam", 43: "MethodSpec", 44: "GenericParamConstraint",
}

CODED = {
    "TypeDefOrRef": (2, [2, 1, 27]),
    "HasConstant": (2, [4, 8, 23]),
    "HasCustomAttribute": (5, [6, 4, 1, 2, 8, 9, 10, 0, 14, 23, 20, 17, 26, 27, 32, 35, 38, 39, 40, 42, 43]),
    "HasFieldMarshal": (1, [4, 8]),
    "HasDeclSecurity": (2, [2, 6, 32]),
    "MemberRefParent": (3, [2, 1, 26, 6, 27]),
    "HasSemantics": (1, [20, 23]),
    "MethodDefOrRef": (1, [6, 10]),
    "MemberForwarded": (1, [4, 6]),
    "Implementation": (2, [38, 35, 39]),
    "CustomAttributeType": (3, [None, None, 6, 10, None]),
    "ResolutionScope": (2, [0, 26, 35, 1]),
    "TypeOrMethodDef": (1, [2, 6]),
}

ET = {
    0x01: "void", 0x02: "bool", 0x03: "char", 0x04: "sbyte", 0x05: "byte",
    0x06: "short", 0x07: "ushort", 0x08: "int", 0x09: "uint", 0x0A: "long",
    0x0B: "ulong", 0x0C: "float", 0x0D: "double", 0x0E: "string", 0x18: "IntPtr",
    0x19: "UIntPtr", 0x1C: "object", 0x16: "TypedReference",
}


def u16(b, o): return struct.unpack_from("<H", b, o)[0]
def u32(b, o): return struct.unpack_from("<I", b, o)[0]
def u64(b, o): return struct.unpack_from("<Q", b, o)[0]


def read_cstr(buf, off):
    if off <= 0 or off >= len(buf):
        return ""
    end = buf.find(b"\x00", off)
    if end < 0:
        end = len(buf)
    return buf[off:end].decode("utf-8", errors="replace")


def read_compressed_uint(buf, off):
    first = buf[off]
    if (first & 0x80) == 0:
        return first, off + 1
    if (first & 0xC0) == 0x80:
        return ((first & 0x3F) << 8) | buf[off + 1], off + 2
    return ((first & 0x1F) << 24) | (buf[off + 1] << 16) | (buf[off + 2] << 8) | buf[off + 3], off + 4


class PE:
    def __init__(self, path):
        self.path = Path(path)
        self.data = self.path.read_bytes()
        self.sections = []
        self.cli_rva = 0
        self.cli_size = 0
        self._parse()

    def _parse(self):
        d = self.data
        if d[:2] != b"MZ":
            raise ValueError("Not a PE file")
        pe = u32(d, 0x3C)
        if d[pe:pe + 4] != b"PE\0\0":
            raise ValueError("Invalid PE signature")
        machine = u16(d, pe + 4)
        num_sections = u16(d, pe + 6)
        opt_size = u16(d, pe + 20)
        opt = pe + 24
        magic = u16(d, opt)
        dd_base = opt + (96 if magic == 0x10B else 112)
        self.cli_rva = u32(d, dd_base + 14 * 8)
        self.cli_size = u32(d, dd_base + 14 * 8 + 4)
        sec_off = opt + opt_size
        for i in range(num_sections):
            off = sec_off + i * 40
            name = d[off:off + 8].rstrip(b"\0").decode("ascii", errors="replace")
            vsize = u32(d, off + 8)
            va = u32(d, off + 12)
            raw_size = u32(d, off + 16)
            raw_ptr = u32(d, off + 20)
            self.sections.append((name, va, max(vsize, raw_size), raw_ptr, raw_size))
        self.machine = machine
        self.magic = magic

    def rva_to_off(self, rva):
        for _, va, vsize, raw_ptr, raw_size in self.sections:
            if va <= rva < va + vsize:
                return raw_ptr + (rva - va)
        raise ValueError(f"RVA not mapped: 0x{rva:X}")


class Meta:
    def __init__(self, pe):
        self.pe = pe
        self.streams = {}
        self.rows = {}
        self.tables = {}
        self.heap_sizes = 0
        self._parse_root()
        self._parse_tables()

    def _parse_root(self):
        d = self.pe.data
        cli = self.pe.rva_to_off(self.pe.cli_rva)
        md_rva = u32(d, cli + 8)
        md_off = self.pe.rva_to_off(md_rva)
        if d[md_off:md_off + 4] != b"BSJB":
            raise ValueError("No CLR metadata root")
        ver_len = u32(d, md_off + 12)
        p = md_off + 16 + ((ver_len + 3) & ~3)
        p += 2  # flags
        stream_count = u16(d, p)
        p += 2
        for _ in range(stream_count):
            off = u32(d, p)
            size = u32(d, p + 4)
            p += 8
            end = d.find(b"\0", p)
            name = d[p:end].decode("ascii", errors="replace")
            p = (end + 4) & ~3
            self.streams[name] = d[md_off + off:md_off + off + size]

    def str(self, idx):
        return read_cstr(self.streams.get("#Strings", b""), idx)

    def blob(self, idx):
        b = self.streams.get("#Blob", b"")
        if idx <= 0 or idx >= len(b):
            return b""
        ln, p = read_compressed_uint(b, idx)
        return b[p:p + ln]

    def idx_size(self, table):
        return 2 if self.rows.get(table, 0) < 0x10000 else 4

    def coded_size(self, name):
        bits, targets = CODED[name]
        max_rows = max((self.rows.get(t, 0) for t in targets if t is not None), default=0)
        return 2 if max_rows < (1 << (16 - bits)) else 4

    def heap_idx_size(self, kind):
        bit = {"str": 0x01, "guid": 0x02, "blob": 0x04}[kind]
        return 4 if (self.heap_sizes & bit) else 2

    def _schema(self, tid):
        s = self.heap_idx_size("str")
        g = self.heap_idx_size("guid")
        b = self.heap_idx_size("blob")
        ix = self.idx_size
        cx = self.coded_size
        return {
            0: [("Generation", 2), ("Name", s), ("Mvid", g), ("EncId", g), ("EncBaseId", g)],
            1: [("ResolutionScope", cx("ResolutionScope")), ("TypeName", s), ("TypeNamespace", s)],
            2: [("Flags", 4), ("TypeName", s), ("TypeNamespace", s), ("Extends", cx("TypeDefOrRef")), ("FieldList", ix(4)), ("MethodList", ix(6))],
            4: [("Flags", 2), ("Name", s), ("Signature", b)],
            6: [("RVA", 4), ("ImplFlags", 2), ("Flags", 2), ("Name", s), ("Signature", b), ("ParamList", ix(8))],
            8: [("Flags", 2), ("Sequence", 2), ("Name", s)],
            9: [("Class", ix(2)), ("Interface", cx("TypeDefOrRef"))],
            10: [("Class", cx("MemberRefParent")), ("Name", s), ("Signature", b)],
            11: [("Type", 2), ("Parent", cx("HasConstant")), ("Value", b)],
            12: [("Parent", cx("HasCustomAttribute")), ("Type", cx("CustomAttributeType")), ("Value", b)],
            13: [("Parent", cx("HasFieldMarshal")), ("NativeType", b)],
            14: [("Action", 2), ("Parent", cx("HasDeclSecurity")), ("PermissionSet", b)],
            15: [("PackingSize", 2), ("ClassSize", 4), ("Parent", ix(2))],
            16: [("Offset", 4), ("Field", ix(4))],
            17: [("Signature", b)],
            18: [("Parent", ix(2)), ("EventList", ix(20))],
            20: [("EventFlags", 2), ("Name", s), ("EventType", cx("TypeDefOrRef"))],
            21: [("Parent", ix(2)), ("PropertyList", ix(23))],
            23: [("Flags", 2), ("Name", s), ("Type", b)],
            24: [("Semantics", 2), ("Method", ix(6)), ("Association", cx("HasSemantics"))],
            25: [("Class", ix(2)), ("MethodBody", cx("MethodDefOrRef")), ("MethodDeclaration", cx("MethodDefOrRef"))],
            26: [("Name", s)],
            27: [("Signature", b)],
            28: [("MappingFlags", 2), ("MemberForwarded", cx("MemberForwarded")), ("ImportName", s), ("ImportScope", ix(26))],
            29: [("RVA", 4), ("Field", ix(4))],
            32: [("HashAlgId", 4), ("Major", 2), ("Minor", 2), ("Build", 2), ("Revision", 2), ("Flags", 4), ("PublicKey", b), ("Name", s), ("Culture", s)],
            35: [("Major", 2), ("Minor", 2), ("Build", 2), ("Revision", 2), ("Flags", 4), ("PublicKeyOrToken", b), ("Name", s), ("Culture", s), ("HashValue", b)],
            38: [("Flags", 4), ("Name", s), ("HashValue", b)],
            39: [("Flags", 4), ("TypeDefId", 4), ("TypeName", s), ("TypeNamespace", s), ("Implementation", cx("Implementation"))],
            40: [("Offset", 4), ("Flags", 4), ("Name", s), ("Implementation", cx("Implementation"))],
            41: [("NestedClass", ix(2)), ("EnclosingClass", ix(2))],
            42: [("Number", 2), ("Flags", 2), ("Owner", cx("TypeOrMethodDef")), ("Name", s)],
            43: [("Method", ix(6)), ("Instantiation", b)],
            44: [("Owner", ix(42)), ("Constraint", cx("TypeDefOrRef"))],
        }.get(tid, [])

    def _parse_tables(self):
        st = self.streams.get("#~") or self.streams.get("#-")
        if not st:
            raise ValueError("No metadata table stream")
        self.heap_sizes = st[6]
        valid = u64(st, 8)
        p = 24
        tids = [i for i in range(64) if valid & (1 << i)]
        for tid in tids:
            self.rows[tid] = u32(st, p)
            p += 4
        for tid in tids:
            schema = self._schema(tid)
            row_size = sum(sz for _, sz in schema)
            rows = []
            for rid in range(1, self.rows[tid] + 1):
                row = {"rid": rid}
                q = p
                for name, sz in schema:
                    val = u16(st, q) if sz == 2 else u32(st, q)
                    row[name] = val
                    q += sz
                rows.append(row)
                p += row_size
            self.tables[tid] = rows

    def decode_coded(self, name, val):
        bits, targets = CODED[name]
        tag = val & ((1 << bits) - 1)
        rid = val >> bits
        tid = targets[tag] if tag < len(targets) else None
        return tid, rid

    def type_name_from_coded(self, val):
        tid, rid = self.decode_coded("TypeDefOrRef", val)
        if rid <= 0:
            return ""
        if tid == 2:
            row = self.tables.get(2, [])[rid - 1]
            return self.full_type_name(row)
        if tid == 1:
            row = self.tables.get(1, [])[rid - 1]
            ns = self.str(row["TypeNamespace"])
            nm = self.str(row["TypeName"])
            return f"{ns}.{nm}" if ns else nm
        if tid == 27:
            return "TypeSpec"
        return ""

    def full_type_name(self, row):
        ns = self.str(row.get("TypeNamespace", 0))
        nm = self.str(row.get("TypeName", 0))
        return f"{ns}.{nm}" if ns else nm


class Sig:
    def __init__(self, meta):
        self.meta = meta

    def parse_type(self, b, p):
        if p >= len(b):
            return "?", p
        et = b[p]
        p += 1
        if et in ET:
            return ET[et], p
        if et == 0x10:
            t, p = self.parse_type(b, p)
            return t + "&", p
        if et == 0x0F:
            t, p = self.parse_type(b, p)
            return t + "*", p
        if et in (0x11, 0x12):
            val, p = read_compressed_uint(b, p)
            prefix = "valuetype " if et == 0x11 else "class "
            return prefix + self.meta.type_name_from_coded(val), p
        if et == 0x1D:
            t, p = self.parse_type(b, p)
            return t + "[]", p
        if et == 0x14:
            t, p = self.parse_type(b, p)
            rank, p = read_compressed_uint(b, p)
            numsizes, p = read_compressed_uint(b, p)
            for _ in range(numsizes):
                _, p = read_compressed_uint(b, p)
            numlobounds, p = read_compressed_uint(b, p)
            for _ in range(numlobounds):
                _, p = read_compressed_uint(b, p)
            return t + "[" + "," * max(0, rank - 1) + "]", p
        if et == 0x15:
            kind = b[p]
            p += 1
            val, p = read_compressed_uint(b, p)
            base = self.meta.type_name_from_coded(val)
            argc, p = read_compressed_uint(b, p)
            args = []
            for _ in range(argc):
                a, p = self.parse_type(b, p)
                args.append(a)
            return f"{base}<{', '.join(args)}>", p
        if et == 0x13:
            num, p = read_compressed_uint(b, p)
            return f"!{num}", p
        if et == 0x1E:
            num, p = read_compressed_uint(b, p)
            return f"!!{num}", p
        if et == 0x1F:
            t, p = self.parse_type(b, p)
            return "modreq " + t, p
        if et == 0x20:
            t, p = self.parse_type(b, p)
            return "modopt " + t, p
        return f"ET_0x{et:02X}", p

    def method_sig(self, blob):
        try:
            if not blob:
                return {"return": "", "params": [], "raw": ""}
            p = 0
            cc = blob[p]
            p += 1
            gen = None
            if cc & 0x10:
                gen, p = read_compressed_uint(blob, p)
            pc, p = read_compressed_uint(blob, p)
            ret, p = self.parse_type(blob, p)
            params = []
            for _ in range(pc):
                t, p = self.parse_type(blob, p)
                params.append(t)
            return {"return": ret, "params": params, "generic": gen, "callconv": cc}
        except Exception as e:
            return {"return": "?", "params": [], "error": str(e), "raw": blob.hex()}

    def field_sig(self, blob):
        try:
            if not blob or blob[0] != 0x06:
                return "?"
            t, _ = self.parse_type(blob, 1)
            return t
        except Exception:
            return blob.hex()

    def property_sig(self, blob):
        try:
            if not blob:
                return "?"
            p = 0
            cc = blob[p]
            p += 1
            _, p = read_compressed_uint(blob, p)
            t, _ = self.parse_type(blob, p)
            return t
        except Exception:
            return blob.hex()


def flag_access(flags):
    acc = flags & 0x7
    return {
        0: "private_scope", 1: "private", 2: "fam_and_assem", 3: "assembly",
        4: "family", 5: "fam_or_assem", 6: "public",
    }.get(acc, str(acc))


def type_kind(flags):
    if flags & 0x20:
        return "interface"
    if flags & 0x100:
        return "abstract"
    return "class"


def is_finance(name):
    return re.search(r"(?i)(hisse|bist|imkb|viop|vip|order|emir|position|poz|portfoy|portfolio|robot|sistem|signal|sinyal|trade|bar|chart|grafik|fiyat|price|hacim|volume|takas|kurum|seans|spread|arbitraj|indicator|strategy)", name or "") is not None


def safe_name(name):
    return name.replace("\n", " ").replace("\r", " ")


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("exe")
    ap.add_argument("outdir")
    args = ap.parse_args()
    out = Path(args.outdir)
    out.mkdir(parents=True, exist_ok=True)

    pe = PE(args.exe)
    meta = Meta(pe)
    sig = Sig(meta)

    typedefs = meta.tables.get(2, [])
    fields = meta.tables.get(4, [])
    methods = meta.tables.get(6, [])
    params = meta.tables.get(8, [])
    props = meta.tables.get(23, [])
    propmaps = meta.tables.get(21, [])
    events = meta.tables.get(20, [])
    eventmaps = meta.tables.get(18, [])
    semantics = meta.tables.get(24, [])
    memberrefs = meta.tables.get(10, [])
    modulerefs = meta.tables.get(26, [])
    implmaps = meta.tables.get(28, [])

    type_infos = []
    for i, row in enumerate(typedefs, 1):
        next_row = typedefs[i] if i < len(typedefs) else None
        f_start = row["FieldList"]
        f_end = (next_row["FieldList"] if next_row else len(fields) + 1)
        m_start = row["MethodList"]
        m_end = (next_row["MethodList"] if next_row else len(methods) + 1)
        full = meta.full_type_name(row)
        type_infos.append({
            "rid": i, "name": full, "namespace": meta.str(row["TypeNamespace"]), "type_name": meta.str(row["TypeName"]),
            "flags": row["Flags"], "kind": type_kind(row["Flags"]), "extends": meta.type_name_from_coded(row["Extends"]),
            "field_start": f_start, "field_end": f_end, "method_start": m_start, "method_end": m_end,
        })

    def owner_for_method(rid):
        for t in type_infos:
            if t["method_start"] <= rid < t["method_end"]:
                return t
        return None

    def owner_for_field(rid):
        for t in type_infos:
            if t["field_start"] <= rid < t["field_end"]:
                return t
        return None

    method_rows = []
    for rid, row in enumerate(methods, 1):
        owner = owner_for_method(rid)
        ms = sig.method_sig(meta.blob(row["Signature"]))
        p_start = row["ParamList"]
        next_p = methods[rid]["ParamList"] if rid < len(methods) else len(params) + 1
        pnames = []
        for pr in params[p_start - 1:next_p - 1]:
            if pr.get("Sequence", 0) > 0:
                pnames.append(meta.str(pr["Name"]))
        method_rows.append({
            "rid": rid, "type": owner["name"] if owner else "", "name": meta.str(row["Name"]),
            "access": flag_access(row["Flags"]), "flags": row["Flags"], "rva": row["RVA"],
            "return": ms.get("return", ""), "params": ms.get("params", []), "param_names": pnames,
        })

    field_rows = []
    for rid, row in enumerate(fields, 1):
        owner = owner_for_field(rid)
        field_rows.append({
            "rid": rid, "type": owner["name"] if owner else "", "name": meta.str(row["Name"]),
            "access": flag_access(row["Flags"]), "field_type": sig.field_sig(meta.blob(row["Signature"])), "flags": row["Flags"],
        })

    prop_owner_by_start = []
    for i, row in enumerate(propmaps, 1):
        parent = row["Parent"]
        start = row["PropertyList"]
        end = propmaps[i]["PropertyList"] if i < len(propmaps) else len(props) + 1
        tname = type_infos[parent - 1]["name"] if 0 < parent <= len(type_infos) else ""
        prop_owner_by_start.append((start, end, tname))

    sem_by_assoc = {}
    for row in semantics:
        tid, rid = meta.decode_coded("HasSemantics", row["Association"])
        sem_by_assoc.setdefault((tid, rid), []).append(row)

    prop_rows = []
    for rid, row in enumerate(props, 1):
        owner = ""
        for start, end, tname in prop_owner_by_start:
            if start <= rid < end:
                owner = tname
                break
        accessors = []
        for sem in sem_by_assoc.get((23, rid), []):
            mid = sem["Method"]
            if 0 < mid <= len(method_rows):
                accessors.append(method_rows[mid - 1]["name"])
        prop_rows.append({"rid": rid, "type": owner, "name": meta.str(row["Name"]), "property_type": sig.property_sig(meta.blob(row["Type"])), "accessors": accessors})

    event_rows = []
    for i, row in enumerate(eventmaps, 1):
        parent = row["Parent"]
        start = row["EventList"]
        end = eventmaps[i]["EventList"] if i < len(eventmaps) else len(events) + 1
        tname = type_infos[parent - 1]["name"] if 0 < parent <= len(type_infos) else ""
        for rid in range(start, end):
            if 0 < rid <= len(events):
                ev = events[rid - 1]
                event_rows.append({"rid": rid, "type": tname, "name": meta.str(ev["Name"]), "event_type": meta.type_name_from_coded(ev["EventType"])})

    module_names = {i: meta.str(r["Name"]) for i, r in enumerate(modulerefs, 1)}
    impl_rows = []
    for row in implmaps:
        tid, rid = meta.decode_coded("MemberForwarded", row["MemberForwarded"])
        member = ""
        owner = ""
        if tid == 6 and 0 < rid <= len(method_rows):
            member = method_rows[rid - 1]["name"]
            owner = method_rows[rid - 1]["type"]
        elif tid == 4 and 0 < rid <= len(field_rows):
            member = field_rows[rid - 1]["name"]
            owner = field_rows[rid - 1]["type"]
        impl_rows.append({"owner": owner, "member": member, "import": meta.str(row["ImportName"]), "module": module_names.get(row["ImportScope"], ""), "flags": row["MappingFlags"]})

    memberref_rows = []
    for rid, row in enumerate(memberrefs, 1):
        tid, crid = meta.decode_coded("MemberRefParent", row["Class"])
        cls = ""
        if tid == 1 and 0 < crid <= len(meta.tables.get(1, [])):
            tr = meta.tables[1][crid - 1]
            ns = meta.str(tr["TypeNamespace"])
            nm = meta.str(tr["TypeName"])
            cls = f"{ns}.{nm}" if ns else nm
        elif tid == 2 and 0 < crid <= len(type_infos):
            cls = type_infos[crid - 1]["name"]
        elif tid == 26 and 0 < crid <= len(modulerefs):
            cls = module_names.get(crid, "")
        memberref_rows.append({"rid": rid, "class": cls, "name": meta.str(row["Name"]), "sig_hex": meta.blob(row["Signature"]).hex()})

    summary = {
        "exe": str(Path(args.exe).resolve()), "size": os.path.getsize(args.exe),
        "machine": f"0x{pe.machine:04X}", "cli_rva": pe.cli_rva, "streams": {k: len(v) for k, v in meta.streams.items()},
        "tables": {TABLE_NAMES.get(k, str(k)): v for k, v in sorted(meta.rows.items())},
        "counts": {"types": len(type_infos), "fields": len(field_rows), "methods": len(method_rows), "properties": len(prop_rows), "events": len(event_rows), "implmaps": len(impl_rows), "memberrefs": len(memberref_rows)},
    }
    (out / "00_metadata_summary.json").write_text(json.dumps(summary, indent=2, ensure_ascii=False), encoding="utf-8")

    with open(out / "01_types.jsonl", "w", encoding="utf-8") as f:
        for r in type_infos:
            f.write(json.dumps(r, ensure_ascii=False) + "\n")

    with open(out / "02_methods.csv", "w", newline="", encoding="utf-8") as f:
        w = csv.DictWriter(f, fieldnames=["rid", "type", "access", "name", "return", "params", "param_names", "rva", "flags"])
        w.writeheader()
        for r in method_rows:
            rr = dict(r)
            rr["params"] = "; ".join(r["params"])
            rr["param_names"] = "; ".join(r["param_names"])
            w.writerow(rr)

    with open(out / "03_fields.csv", "w", newline="", encoding="utf-8") as f:
        w = csv.DictWriter(f, fieldnames=["rid", "type", "access", "name", "field_type", "flags"])
        w.writeheader()
        w.writerows(field_rows)

    with open(out / "04_properties.csv", "w", newline="", encoding="utf-8") as f:
        w = csv.DictWriter(f, fieldnames=["rid", "type", "name", "property_type", "accessors"])
        w.writeheader()
        for r in prop_rows:
            rr = dict(r)
            rr["accessors"] = "; ".join(r["accessors"])
            w.writerow(rr)

    with open(out / "05_events.csv", "w", newline="", encoding="utf-8") as f:
        w = csv.DictWriter(f, fieldnames=["rid", "type", "name", "event_type"])
        w.writeheader()
        w.writerows(event_rows)

    with open(out / "06_pinvoke_implmaps.csv", "w", newline="", encoding="utf-8") as f:
        w = csv.DictWriter(f, fieldnames=["owner", "member", "import", "module", "flags"])
        w.writeheader()
        w.writerows(impl_rows)

    with open(out / "07_memberrefs.csv", "w", newline="", encoding="utf-8") as f:
        w = csv.DictWriter(f, fieldnames=["rid", "class", "name", "sig_hex"])
        w.writeheader()
        w.writerows(memberref_rows)

    finance_types = [t for t in type_infos if is_finance(t["name"])]
    with open(out / "08_finance_api_map.md", "w", encoding="utf-8") as f:
        f.write("# Finance/API Type Map\n\n")
        f.write(f"Types: {len(finance_types)}\n\n")
        for t in sorted(finance_types, key=lambda x: x["name"].lower()):
            f.write(f"## {t['name']}\n\n")
            if t["extends"]:
                f.write(f"Extends: `{t['extends']}`\n\n")
            fs = [r for r in field_rows if r["type"] == t["name"]]
            ps = [r for r in prop_rows if r["type"] == t["name"]]
            ms = [r for r in method_rows if r["type"] == t["name"] and not r["name"].startswith(("get_", "set_"))]
            if fs:
                f.write("Fields:\n")
                for r in fs[:80]:
                    f.write(f"- `{r['access']} {r['field_type']} {r['name']}`\n")
            if ps:
                f.write("\nProperties:\n")
                for r in ps[:80]:
                    f.write(f"- `{r['property_type']} {r['name']}`\n")
            if ms:
                f.write("\nMethods:\n")
                for r in ms[:120]:
                    f.write(f"- `{r['access']} {r['return']} {r['name']}({', '.join(r['params'])})`\n")
            f.write("\n")

    candidates = [r for r in method_rows if is_finance(r["type"] + "." + r["name"])]
    with open(out / "09_method_candidates.md", "w", encoding="utf-8") as f:
        f.write("# Finance/Robot/Sistem Method Candidates\n\n")
        for r in sorted(candidates, key=lambda x: (x["type"], x["name"])):
            f.write(f"- `{r['type']}.{r['name']}({', '.join(r['params'])}) -> {r['return']}` [{r['access']}]\n")

    print(json.dumps(summary, indent=2, ensure_ascii=False))


if __name__ == "__main__":
    main()
