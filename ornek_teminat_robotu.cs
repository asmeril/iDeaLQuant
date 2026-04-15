// ═══════════════════════════════════════════════════════════════════════════
//  VIP-GARAN Teminat Bilgisi Örnek Robotu
//  iDeal robot script (C# benzeri sözdizim)
//
//  İki bilgi kaynağı gösterilmiştir:
//    1) cxBasic.CalculateTeminat()  — sözleşme başına teorik teminat hesabı
//    2) Sistem.ViopHesapOku()       — HESAPTAKİ gerçek teminat bakiyeleri
//
//  Kullanım: Robot sekmesinde "Sanal" modda çalıştır, Mesaj/Log alanında
//            çıktıları gör.
// ═══════════════════════════════════════════════════════════════════════════

var Sembol = "VIP'VIP-GARAN";    // VIOP sembol formatı

// ──────────────────────────────────────────────────────────────────────────
// BÖLÜM 1 : Sözleşme bazında teorik teminat (cxBasic.CalculateTeminat)
//
// Sistem.YuzeyselVeriOku(sembol)  → ideal.cxBasic  (canlı sembol verisi)
// cxBasic.CalculateTeminat()      → void  (hesaplar, sonucu Risk alanına yazar)
// cxBasic.Risk                    → string  (hesaplanan teminat/risk durumu)
// cxBasic.TeorikVal               → double  (teorik değer / premi — opsiyon için)
// ──────────────────────────────────────────────────────────────────────────
var VeriObjesi = Sistem.YuzeyselVeriOku(Sembol);

if (VeriObjesi == null)
{
    Sistem.Mesaj(Sembol + " sembolü yüklenemedi – önce sembolü listeye ekle.");
}
else
{
    // Teminat hesabını tetikle (void, nesneyi günceller)
    VeriObjesi.CalculateTeminat();

    // ─── Sembol bilgileri ───────────────────────────────────────────────
    var SonFiyat       = VeriObjesi.LastPrice;
    var UzlasmFiyat    = VeriObjesi.SettlementPrice;
    var OncekiUzlasma  = VeriObjesi.PrevSettlement;
    var VadeGun        = VeriObjesi.DaysToExpiry;
    var AcikPozisyon   = VeriObjesi.OpenInterest;
    var RiskDurumu     = VeriObjesi.Risk;           // CalculateTeminat sonucu
    var TeorikDeger    = VeriObjesi.TeorikVal;      // Opsiyon teorik değeri
    var TeorikFark     = VeriObjesi.TeorikDif;      // Teorik – Piyasa farkı

    var MesajKismi1 =
        "═══ " + Sembol + " ═══\n" +
        "Son Fiyat      : " + SonFiyat.ToString("N4") + "\n" +
        "Uzlaşma Fiyatı : " + UzlasmFiyat.ToString("N4") + "\n" +
        "Önceki Uzlaşma : " + OncekiUzlasma.ToString("N4") + "\n" +
        "Vadeye Kalan   : " + VadeGun + " gün\n" +
        "Açık Pozisyon  : " + AcikPozisyon.ToString("N0") + "\n" +
        "Risk Durumu    : " + RiskDurumu + "\n" +
        "Teorik Değer   : " + TeorikDeger.ToString("N4") + "\n" +
        "Teorik Fark    : " + TeorikFark.ToString("N4");

    Sistem.Mesaj(MesajKismi1);
}

// ──────────────────────────────────────────────────────────────────────────
// BÖLÜM 2 : Hesap bazında gerçek VIOP teminat bakiyeleri
//           Sistem.ViopHesapOku([delaytime])  → ViopRobotHesapClass
//
// delaytime : Sunucudan bekleme süresi (ms). 0 = önbellekten hemen oku.
//             Canlı modda 2000 (2 sn) önerilir.
// ──────────────────────────────────────────────────────────────────────────
var ViopHesap = Sistem.ViopHesapOku(0);   // 0 = cached, 2000 = fresh

if (ViopHesap == null)
{
    Sistem.Mesaj("ViopHesapOku null döndü – VIOP hesabı tanımlı değil.");
}
else
{
    var MesajKismi2 =
        "═══ VIOP Hesap Teminatları ═══\n" +
        "Toplam Teminat       : " + ViopHesap.TeminatToplam.ToString("N2")      + " TL\n" +
        "Başlangıç Teminatı   : " + ViopHesap.TeminatBaslangic.ToString("N2")   + " TL\n" +
        "Sürdürme Teminatı    : " + ViopHesap.TeminatSurdurme.ToString("N2")    + " TL\n" +
        "Kullanılabilir       : " + ViopHesap.TeminatKullanilabilir.ToString("N2") + " TL\n" +
        "Çekilebilir          : " + ViopHesap.TeminatCekilebilir.ToString("N2") + " TL\n" +
        "Teminat Çağrısı      : " + ViopHesap.TeminatCagri.ToString("N2")       + " TL";

    Sistem.Mesaj(MesajKismi2);

    // ── GARAN sözleşmelerini pozisyonlardan filtrele ─────────────────────
    var Pozisyonlar = ViopHesap.Pozisyonlar;   // List<VipPositionRecord>
    if (Pozisyonlar != null && Pozisyonlar.Count > 0)
    {
        var GaranPoz = "";
        foreach (var Poz in Pozisyonlar)
        {
            if (Poz.Symbol.Contains("GARAN"))
            {
                GaranPoz +=
                    "\n" + Poz.Symbol +
                    "  Yön: " + Poz.Direction +
                    "  Açık: " + Poz.OpenAmount +
                    "  K/Z: " + Poz.Profit.ToString("N2") + " TL" +
                    "  Uzlaşma: " + Poz.SettlementPrice.ToString("N4");
            }
        }
        if (GaranPoz != "")
            Sistem.Mesaj("═══ GARAN Pozisyonları ═══" + GaranPoz);
        else
            Sistem.Mesaj("GARAN adlı açık VIOP pozisyonu bulunamadı.");
    }
}

// ──────────────────────────────────────────────────────────────────────────
// NOT: Bu robot sadece bilgi gösterir, emir GÖNDERMEZ.
//      Emir göndermek için Sistem.EmirGonder() eklenmelidir.
// ──────────────────────────────────────────────────────────────────────────
