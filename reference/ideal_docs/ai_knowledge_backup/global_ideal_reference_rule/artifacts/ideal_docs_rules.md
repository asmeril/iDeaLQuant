# iDeal Platform Source of Truth

> [!IMPORTANT]
> The directory `D:\Projects\IdealQuant\reference\ideal_docs` is specifically curated by the user to be the **absolute only source of truth** for the iDeal Platform C# API logic and capabilities. 

## Files Available in Primary Directory
The folder contains partitioned API segments for robust and fast querying:
- `critical_pages.txt` (Contains core robot, position lookup, state saving, and generic C# framework logic)
- `ideal_p001_p030.txt` to `ideal_p211_p211.txt` (Segmented documentation files mapped by page ranges, extremely useful for targeted searches without massive tokens)
- `ideal_sistem_genel_FULL.txt` (The full text from Sezai Kılıç's PDF reference)

## Directives that the AI MUST Follow
1. **Always Verify First:** Never hallucinate an `IdealData` C# API call (like `Sistem.Aroon()`, `Sistem.ZamanKontrol()`, etc.); always check the documentation in this folder first using `grep_search` or by reading the relevant segment text file.
2. **Prioritize Native Logic:** Look precisely at how parameters are passed into the `Sistem.XXX` methods as listed in these docs. 
3. **No External Hallucination:** The user specifically stated: "ve bu proje ve idealdata ile ilgili tüm projelerde ana referans kaynağın bu klasördeki dosyalar olacak". Wait and read this directory every time a C# specific IdealData question or syntax mapping arises.
