#!/usr/bin/env python3
"""Create focused reports from extract_dotnet_metadata.py outputs."""

import argparse
import csv
import json
import re
from collections import defaultdict
from pathlib import Path


KEYWORDS = re.compile(
    r"(?i)(sistem|robot|emir|order|viop|vip|bist|imkb|pozisyon|position|"
    r"portfoy|portfolio|hesap|account|grafik|chart|bar|fiyat|price|"
    r"takas|kurum|hacim|volume|sinyal|signal|strategy|indicator|scanner|sorgu)"
)


def read_csv(path):
    with open(path, newline="", encoding="utf-8") as f:
        return list(csv.DictReader(f))


def is_noise_type(name):
    simple = name.split(".")[-1]
    return simple.startswith("<") or simple in {"<>c", "<>c__DisplayClass"} or "DisplayClass" in simple or ">d__" in simple


def access_rank(access):
    return {"public": 0, "family": 1, "fam_or_assem": 2, "assembly": 3, "private": 4}.get(access, 9)


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("indir")
    args = ap.parse_args()
    base = Path(args.indir)

    types = [json.loads(line) for line in (base / "01_types.jsonl").read_text(encoding="utf-8").splitlines() if line.strip()]
    methods = read_csv(base / "02_methods.csv")
    fields = read_csv(base / "03_fields.csv")
    props = read_csv(base / "04_properties.csv")
    memberrefs = read_csv(base / "07_memberrefs.csv")

    by_type_methods = defaultdict(list)
    by_type_fields = defaultdict(list)
    by_type_props = defaultdict(list)
    for r in methods:
        by_type_methods[r["type"]].append(r)
    for r in fields:
        by_type_fields[r["type"]].append(r)
    for r in props:
        by_type_props[r["type"]].append(r)

    interesting_types = [t for t in types if not is_noise_type(t["name"]) and KEYWORDS.search(t["name"])]
    public_methods = [m for m in methods if m["access"] in {"public", "family", "fam_or_assem"} and not is_noise_type(m["type"]) and KEYWORDS.search(m["type"] + "." + m["name"])]

    with open(base / "10_focused_api_report.md", "w", encoding="utf-8") as f:
        f.write("# Focused ideal.exe API Report\n\n")
        f.write("This report filters compiler-generated state machines and highlights likely usable iDeal/finance APIs.\n\n")
        f.write(f"Interesting types: {len(interesting_types)}\n\n")

        for t in sorted(interesting_types, key=lambda x: x["name"].lower()):
            name = t["name"]
            ms = sorted(by_type_methods[name], key=lambda r: (access_rank(r["access"]), r["name"]))
            fs = sorted(by_type_fields[name], key=lambda r: (access_rank(r["access"]), r["name"]))
            ps = sorted(by_type_props[name], key=lambda r: r["name"])
            if not (ms or fs or ps):
                continue
            f.write(f"## {name}\n\n")
            if t.get("extends"):
                f.write(f"Extends: `{t['extends']}`\n\n")
            publicish = [m for m in ms if m["access"] in {"public", "family", "fam_or_assem"} and not m["name"].startswith(("get_", "set_", "."))]
            if publicish:
                f.write("Methods:\n")
                for m in publicish[:80]:
                    f.write(f"- `{m['access']} {m['return']} {m['name']}({m['params']})`\n")
            if ps:
                f.write("\nProperties:\n")
                for p in ps[:80]:
                    f.write(f"- `{p['property_type']} {p['name']}`\n")
            public_fields = [r for r in fs if r["access"] in {"public", "family", "fam_or_assem"}]
            if public_fields:
                f.write("\nFields:\n")
                for r in public_fields[:80]:
                    f.write(f"- `{r['access']} {r['field_type']} {r['name']}`\n")
            f.write("\n")

    with open(base / "11_public_method_index.csv", "w", newline="", encoding="utf-8") as f:
        cols = ["type", "access", "return", "name", "params", "param_names", "rva"]
        w = csv.DictWriter(f, fieldnames=cols)
        w.writeheader()
        for m in sorted(public_methods, key=lambda r: (r["type"], r["name"])):
            w.writerow({k: m.get(k, "") for k in cols})

    with open(base / "12_reference_call_index.md", "w", encoding="utf-8") as f:
        f.write("# External/Internal MemberRef Index\n\n")
        f.write("Member references filtered by finance/iDeal keywords. Useful for discovering called framework or platform APIs.\n\n")
        for r in sorted(memberrefs, key=lambda x: (x["class"], x["name"])):
            text = r["class"] + "." + r["name"]
            if KEYWORDS.search(text) and not is_noise_type(r["class"]):
                f.write(f"- `{r['class']}.{r['name']}`\n")

    counts = {
        "interesting_types": len(interesting_types),
        "public_keyword_methods": len(public_methods),
    }
    (base / "13_focused_summary.json").write_text(json.dumps(counts, indent=2, ensure_ascii=False), encoding="utf-8")
    print(json.dumps(counts, indent=2, ensure_ascii=False))


if __name__ == "__main__":
    main()
