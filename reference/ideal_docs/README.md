# iDeal Platform Referans Merkezi (`ideal_docs`)

Bu klasör, iDeal Platformu (`ideal.exe`) ile ilgili hem üst seviye C# formül editörü (scripting) API'ını hem de düşük seviyeli .NET assembly tersine mühendislik (reflection) analiz verilerini bir araya getiren **nihai ve tek gerçek referans kaynağıdır** (Source of Truth).

## Klasör Yapısı ve İçeriği

*   **`IDEAL_ULTIMATE_GUIDE.md`**: Klasördeki tüm bilgilerin bir sentezi olan, hem kullanıcıların hem de yapay zeka (LLM) modellerinin doğrudan okuyup hatasız kod üretebilmesi için hazırlanmış **Kapsamlı Başvuru Rehberi**.
*   **`manuals/`**: iDeal platformunun resmi C# API dökümantasyonu, fonksiyon kullanımları, parametre detayları ve sayfa sayfa (p001 - p211) kılavuz dosyaları.
*   **`exe_analysis/`**: `ideal.exe` çalıştırılabilir dosyasının .NET metadata, veri sınıfları, enum yapıları, DLL import tanımları ve IL (Intermediate Language) yansıtma (reflection) çıktısı.
*   **`scripts/`**: Platform analizi, metot tespiti, veri ayıklama ve rapor hazırlama için kullanılan python ve powershell betikleri.
*   **`contracts/`**: VİOP vadeli işlem sözleşmelerinin özellikleri ve PDF formatındaki resmi belgeler.

## Temel Kullanım Yönergesi

Herhangi bir C# robotu, indikatörü veya sistem tasarımı geliştirirken:
1. Öncelikle **`IDEAL_ULTIMATE_GUIDE.md`** dosyasını ana başvuru kaynağı olarak kullanın.
2. Fonksiyon parametreleri ve örnek kullanım kalıpları için **`manuals/`** altındaki dosyaları (özellikle `critical_pages.txt` ve genel kılavuzu) arayın (`grep_search` kullanarak).
3. Veri sınıfları (`ImkbOrderRecord`, `VipPositionRecord`, `Portfoy` vb.) ve veri alanlarının tam yazılımları için **`exe_analysis/`** altındaki dosyaları (özellikle `14_finance_classes.txt` veya enumaration listesini) referans alın.
