---
description: Build and Publish IdealQuant (PyInstaller)
---
// turbo-all

## 0. Pre-Flight Check (CRITICAL)
**Yayınlamadan önce KESİNLİKLE kontrol et:**
1.  **Yeni Parametre/Özellik Var mı?**
    - Eğer yeni bir strateji (S7 gibi) eklediysen, bunun `ROADMAP.md` ve `DEVLOG.md` içindeki durumunun güncel olduğundan emin ol.
2.  **Sinyal Doğrulaması:**
    - `verify_s7_precompute.py` gibi testlerin başarılı geçtiğinden emin ol.

## 1. Update Version & Documentation (Single Command)

> **📌 Sürüm Numarası Kuralı:** Mevcut sürüm `4.1` ise, yeni sürüm `4.2` olmalıdır. 

```powershell
python update-version.py --version "4.2"
```
**Otomatik güncellenenler:**
- `src/ui/main.py` (applicationVersion)
- `build_idealquant.py` (Name and EXE paths)
- `ROADMAP.md` (Title and Version Align)

## 2. Clean & Build (PyInstaller)
```powershell
python build_idealquant.py
```

## 3. Verify
`dist/IdealQuant_v{VERSION}/IdealQuant_v{VERSION}.exe` dosyasını kontrol et ve bir kez çalıştırarak arayüzün (S6/S7 sekmeleriyle birlikte) açıldığını doğrula. 
**(Opsiyonel)**: `dist/` klasörünü bir `.zip` haline getirip dağıtabilirsin.
