// ===============================================================================================
// STRATEJİ: VIP_X030-T 1DK GAP REVERSAL v1.0
// ===============================================================================================
// Sembol   : VIP_X030-T
// Periyot  : 1 dakika
// Vade Tipi: ENDEKS
// Oluşturma: 2026-04-07
// ===============================================================================================
//
// [MANTIK]
//   BIST30 vadeli piyasasında gece gap'lerinin %92'si aynı gün içinde kapanmaktadır.
//   (ML Analizi: 458 gap, 2023-2026, VIP_X030-T 1Dk bar verisi — gap_trainer.py)
//
//   TEMEL FİKİR: Gap = Yay. Ne kadar gerilirse, o kadar geri döner.
//   Strateji gap yönünün TERSİNE girer. Hedef = önceki günün kapanışı (gap fill seviyesi).
//
// [KATMANLAR]
//   1. GAP TESPİT    : 6-15 saatlik gece aralığı sonrası açılış farkı tespit edilir.
//                      MIN (%0.05) ve MAX (%2) filtresi gürültüyü ve haber gap'lerini eler.
//   2. AÇILIŞ ARIĞI  : İlk OR_BARS bar (= dakika) yüksek/düşük → Opening Range (OR)
//   3. GİRİŞ TETİĞİ  : OR kırılması, gap yönünün TERSİNDE
//                      • Yukarı gap → OR_Low kırılması = SHORT
//                      • Aşağı gap → OR_High kırılması = LONG
//   4. RSI(5) ONAYI  : Hızlı momentum ölçümü (toggle: RSI_FILTRE_AKTIF)
//   5. HACİM ONAYI   : İşlem hacmi 20-bar ortalamasının üzerinde mi?
//   6. ATR STOPU     : OR extreme + ATR * çarpan (ihlal = gap fill tezi geçersiz)
//   7. GAP FILL HEDEFİ: Önceki günün kapanışı = doğal kar alma seviyesi
//   8. ZAMAN STOPU   : GAP_WINDOW_BARS (varsayılan ~3.5 saat) içinde dolmayan pozisyon kapatılır
//   9. AKŞAM KORUMA  : Akşam seansı başlamadan açık gap pozisyonu kapatılır
//
// [NEDEN BU GÖSTERGELER?]
//   • Pivot/Fibo  : Gap fill seviyesi (önceki kapanış) ZATEN doğal bir pivot seviyesidir.
//                  Ek pivot hesabı, aynı seviyeye farklı isim verir. Gereksiz karmaşıklık.
//   • Bollinger   : Büyük gap'ler zaten BB dışında açılır; OR filtresi bu rolü üstlenir.
//                  Opsiyonel: "BB dışı açılış = güçlü reversal" koşulu v2'ye eklenebilir.
//   • VWAP        : Sabah seansının ilk 30 dk'sında VWAP fiyatla iç içedir, anlamlı filtre
//                  değildir. Günün ortasında (12:00+) geçerlilik kazanır → v2'de eklenebilir.
//   • Hareketli Ort.: EMA(50) sadece görsel bağlam için çizilir, giriş koşuluna dahil değildir.
//   • OR + RSI    : OR kırılması momentum'un yönünü, RSI momentum'un gücünü ölçer.
//                  İkisi birlikte "gap yönüne karşı güç birikmesi" durumunu yakalar.
// ===============================================================================================

string VadeTipi = "ENDEKS";
string YON_MODU = "CIFT";                  // "SADECE_AL" | "SADECE_SAT" | "CIFT"

// ─── KATMAN 1: GAP FİLTRE ─────────────────────────────────────────────────────
float MIN_GAP_PCT       = 0.05f;           // Minimum gap büyüklüğü (%), gürültüyü eler
float MAX_GAP_PCT       = 2.00f;           // Maksimum gap büyüklüğü (%), haber kaynaklı dışla
bool  CUMA_AKTIF        = false;           // Cuma açılış gap'leri işlensin mi?

// ─── KATMAN 2: AÇILIŞ ARIĞI ───────────────────────────────────────────────────
int   OR_BARS           = 15;              // OR süresi: ilk N bar (= dakika @ 1dk grafik)

// ─── KATMAN 4: RSI ────────────────────────────────────────────────────────────
bool  RSI_FILTRE_AKTIF  = true;            // false → RSI koşulunu devre dışı bırak
int   RSI_PERIOD        = 5;              // Hızlı RSI (5 bar ≈ 5 dakika)
float RSI_OB            = 62f;            // Yukarı gap SHORT için RSI alt eşiği
float RSI_OS            = 38f;            // Aşağı gap LONG için RSI üst eşiği

// ─── KATMAN 5: HACİM ──────────────────────────────────────────────────────────
bool  HACIM_FILTRE_AKTIF = true;          // false → hacim koşulunu devre dışı bırak
int   HACIM_MA_PERIOD   = 20;
float HACIM_ORAN        = 0.8f;           // Giriş barı hacmi ≥ HACIM_MA * HACIM_ORAN

// ─── KATMAN 6: ATR STOPU ──────────────────────────────────────────────────────
int   ATR_PERIOD        = 14;
float ATR_STOP_MULT     = 0.5f;           // Stop = OR extreme + ATR * çarpan

// ─── KATMAN 8: ZAMAN STOPU ────────────────────────────────────────────────────
int   GAP_WINDOW_BARS   = 210;            // Pozisyondaki max bar süresi (210 dk ≈ 3.5 saat)

// ─── GENEL ────────────────────────────────────────────────────────────────────
int   COOLDOWN_BARS     = 3;

// ===============================================================================================
// TATİL VE VADE SONU (DeepScalp v1.2 ile aynı yapı)
// ===============================================================================================
int yil = DateTime.Now.Year;
DateTime R2024 = new DateTime(2024, 4, 10); DateTime K2024 = new DateTime(2024, 6, 16);
DateTime R2025 = new DateTime(2025, 3, 30); DateTime K2025 = new DateTime(2025, 6, 6);
DateTime R2026 = new DateTime(2026, 3, 20); DateTime K2026 = new DateTime(2026, 5, 27);
DateTime R2027 = new DateTime(2027, 3, 9);  DateTime K2027 = new DateTime(2027, 5, 16);
string[] resmiTatiller = new string[] { "01.01","04.23","05.01","05.19","07.15","08.30","10.29" };

Func<DateTime, DateTime> VadeSonuIsGunu = (dt) =>
{
    var d = new DateTime(dt.Year, dt.Month, DateTime.DaysInMonth(dt.Year, dt.Month));
    for (int k = 0; k < 15; k++)
    {
        if (d.DayOfWeek == DayOfWeek.Saturday || d.DayOfWeek == DayOfWeek.Sunday)
            { d = d.AddDays(-1); continue; }
        string mmdd = d.ToString("MM.dd");
        bool tatil = false;
        for (int tx = 0; tx < resmiTatiller.Length; tx++)
            if (resmiTatiller[tx] == mmdd) { tatil = true; break; }
        if (tatil) { d = d.AddDays(-1); continue; }
        if ((d >= R2024 && d <= R2024.AddDays(3)) || (d >= K2024 && d <= K2024.AddDays(4)) ||
            (d >= R2025 && d <= R2025.AddDays(3)) || (d >= K2025 && d <= K2025.AddDays(4)) ||
            (d >= R2026 && d <= R2026.AddDays(3)) || (d >= K2026 && d <= K2026.AddDays(4)) ||
            (d >= R2027 && d <= R2027.AddDays(3)) || (d >= K2027 && d <= K2027.AddDays(4)))
            { d = d.AddDays(-1); continue; }
        break;
    }
    return d.Date;
};

// ===============================================================================================
// VERİ & GÖSTERGELER
// ===============================================================================================
var V       = Sistem.GrafikVerileri;
var O       = Sistem.GrafikFiyatSec("Acilis");
var C       = Sistem.GrafikFiyatSec("Kapanis");
var H       = Sistem.GrafikFiyatSec("Yuksek");
var L       = Sistem.GrafikFiyatSec("Dusuk");
var LotData = Sistem.GrafikFiyatSec("Hacim");

var ATR      = Sistem.AverageTrueRange(ATR_PERIOD);
var EMA50    = Sistem.MA(C, "Exp", 50);      // Görsel bağlam (giriş koşulu değil)
var HacimMA  = Sistem.MA(LotData, "Simple", HACIM_MA_PERIOD);

// ─── RSI Manuel Hesaplama (Wilder's Smoothing) ────────────────────────────────
var RSI_Ser = Sistem.Liste(50f);
{
    float ag = 0f, al = 0f;
    for (int j = 1; j < V.Count; j++)
    {
        float delta = C[j] - C[j - 1];
        float gain  = delta > 0f ? delta : 0f;
        float loss  = delta < 0f ? -delta : 0f;

        if (j < RSI_PERIOD)
        {
            ag += gain; al += loss;
            RSI_Ser[j] = 50f;
        }
        else if (j == RSI_PERIOD)
        {
            ag = (ag + gain) / RSI_PERIOD;
            al = (al + loss) / RSI_PERIOD;
            RSI_Ser[j] = al == 0f ? 100f : 100f - (100f / (1f + ag / al));
        }
        else
        {
            ag = (ag * (RSI_PERIOD - 1) + gain) / RSI_PERIOD;
            al = (al * (RSI_PERIOD - 1) + loss) / RSI_PERIOD;
            RSI_Ser[j] = al == 0f ? 100f : 100f - (100f / (1f + ag / al));
        }
    }
}

// ─── Görselleştirme Serileri ──────────────────────────────────────────────────
var _ORHigh  = Sistem.Liste(0f);   // OR Yüksek
var _ORLow   = Sistem.Liste(0f);   // OR Düşük
var _FillLvl = Sistem.Liste(0f);   // Gap Fill Hedefi
var _StopLvl = Sistem.Liste(0f);   // Aktif Stop Seviyesi

// ===============================================================================================
// DURUM DEĞİŞKENLERİ
// ===============================================================================================
string SonYon = "", Sinyal = "";
bool  inLong  = false, inShort = false;
float entryPrice = 0f, stopLevel = 0f;
int   barsInPos  = 0,  cooldownCt = 0;

// Gap durumu (her sabah sıfırlanır)
bool  gapActive  = false;
float gapFillLvl = 0f;      // Hedef = önceki günün kapanışı
float gapPctAbs  = 0f;      // Gap yüzdesi (mutlak değer)
int   gapDir     = 0;       // +1 = Yukari gap,  -1 = Asagi gap

// Opening Range durumu
bool  orComplete = false;
float orHigh     = 0f;
float orLow      = float.MaxValue;
int   orStartBar = -1;

// Pozisyon zamanlaması
int   posStartBar = -1;

for (int i = 1; i < V.Count; i++) Sistem.Yon[i] = "";
int warmBars = Math.Max(ATR_PERIOD, Math.Max(50, HACIM_MA_PERIOD)) + RSI_PERIOD + 30;

// ===============================================================================================
// SINYAL DÖNGÜSÜ
// ===============================================================================================
for (int i = warmBars; i < V.Count; i++)
{
    Sinyal = "";
    var dt = V[i].Date;
    var t  = dt.TimeOfDay;

    // VİOP: 09:25 emir toplama / 09:30 açılış / 18:09:59 gün sonu / 19:00 akşam / 22:59:59 akşam sonu
    bool emirToplama = t >= new TimeSpan(9, 25, 0)  && t < new TimeSpan(9, 30, 0);
    bool gunSeansi   = t >= new TimeSpan(9, 30, 0)  && t <= new TimeSpan(18, 9, 59);
    bool aksamSeansi = t >= new TimeSpan(19, 0, 0)  && t <= new TimeSpan(22, 59, 59);
    if (!(emirToplama || gunSeansi || aksamSeansi)) continue;

    bool vadeAyi  = (dt.Month % 2 == 0);
    bool vadeSonu = vadeAyi && (dt.Date == VadeSonuIsGunu(dt));
    bool arefe    = dt.Date == R2024.AddDays(-1).Date || dt.Date == K2024.AddDays(-1).Date ||
                    dt.Date == R2025.AddDays(-1).Date || dt.Date == K2025.AddDays(-1).Date ||
                    dt.Date == R2026.AddDays(-1).Date || dt.Date == K2026.AddDays(-1).Date ||
                    dt.Date == R2027.AddDays(-1).Date || dt.Date == K2027.AddDays(-1).Date;

    // Arefe / vade sonu → düz
    if ((arefe || vadeSonu) && t > new TimeSpan(11, 30, 0))
    {
        if (SonYon != "F") Sinyal = "F";
        inLong = false; inShort = false; gapActive = false;
        orComplete = false; posStartBar = -1;
        if (Sinyal != "" && SonYon != Sinyal) { SonYon = Sinyal; Sistem.Yon[i] = SonYon; }
        continue;
    }

    // ===========================================================================
    // KATMAN 1: GECE GAP TESPİT
    // Sabah 09:25 emir toplama başladığında ilk bar = gece gap'ini taşır.
    // Önceki günün son barı (akşam seansı kapanışı ~22:59) ile
    // bugünün 09:25 barı arasında 10+ saatlik boşluk = gece gap'i.
    // ===========================================================================
    if (i > warmBars)
    {
        double saatFark = (V[i].Date - V[i - 1].Date).TotalHours;
        // 09:25 emir toplama barı → önceki gece 22:59 kapanışı arası ≈ 10-11 saat
        bool geceSonrasi = (saatFark > 6.0 && saatFark < 15.0) && emirToplama;

        if (geceSonrasi)
        {
            // Gece kalmış pozisyon varsa zorla kapat
            if ((inLong || inShort) && SonYon != "F")
            {
                Sinyal     = "F";
                inLong     = false; inShort = false;
                barsInPos  = 0;    cooldownCt = COOLDOWN_BARS;
                entryPrice = 0f;   stopLevel  = 0f;
                posStartBar = -1;
            }

            // Yeni gap hesapla
            float prevClose = C[i - 1];
            float todayOpen = O[i];
            float rawGap    = todayOpen - prevClose;
            float rawGapPct = prevClose > 0f ? (rawGap / prevClose) * 100f : 0f;

            bool buyukYeterli = Math.Abs(rawGapPct) >= MIN_GAP_PCT;
            bool asiriDegil   = Math.Abs(rawGapPct) <= MAX_GAP_PCT;
            bool cumaOk       = (dt.DayOfWeek != DayOfWeek.Friday) || CUMA_AKTIF;

            gapActive  = buyukYeterli && asiriDegil && cumaOk;
            gapFillLvl = prevClose;
            gapPctAbs  = Math.Abs(rawGapPct);
            gapDir     = rawGap > 0f ? 1 : -1;

            // OR sıfırla
            orComplete = false;
            orStartBar = gapActive ? i : -1;
            orHigh     = H[i];
            orLow      = L[i];
            posStartBar = -1;
        }
    }

    // ===========================================================================
    // KATMAN 2: OPENING RANGE (OR) GÜNCELLEME
    // 09:30 açılışından itibaren ilk OR_BARS bar → OR_High ve OR_Low oluşur
    // Emir toplama seansı (09:25-09:29) gerçek fiyat değildir, OR dışında tutulur
    // ===========================================================================
    if (gapActive && !orComplete && orStartBar >= 0)
    {
        // OR yalnızca gün seansı (09:30+) barlarını say
        if (!gunSeansi)
        {
            // Emir toplama veya seans dışı → geç
        }
        else
        {
        int elapsed = i - orStartBar;
            if (elapsed < OR_BARS)
            {
                orHigh = Math.Max(orHigh, H[i]);
                orLow  = Math.Min(orLow,  L[i]);
            }
            else
            {
                orComplete = true;
            }
        }
    }

    // Görsel çizim (gap aktifken)
    if (gapActive)
    {
        _ORHigh[i]  = orHigh;
        _ORLow[i]   = orLow;
        _FillLvl[i] = gapFillLvl;
    }
    if (inLong || inShort)
    {
        _StopLvl[i] = stopLevel;
    }

    // Cooldown sayacı
    if (cooldownCt > 0) cooldownCt--;

    // Akşam seansında yeni giriş yok — sadece bekle veya çık
    bool yeniGirisIzni = gunSeansi;

    // ===========================================================================
    // KATMAN 3-5: GİRİŞ MANTIĞI
    // Or tamamlanmış, gap aktif, pozisyon yok, gün seansı
    // ===========================================================================
    bool girisOnKosul = yeniGirisIzni && gapActive && orComplete &&
                        !inLong && !inShort && cooldownCt == 0 && posStartBar < 0;

    if (girisOnKosul && Sinyal == "")
    {
        // Zaman penceresi: OR bitişinden itibaren GAP_WINDOW_BARS bar
        int orEndBar = orStartBar + OR_BARS;
        bool zamanOk = (i - orEndBar) < GAP_WINDOW_BARS;

        // Hacim konfirmasyonu
        bool hacimOk = !HACIM_FILTRE_AKTIF || (LotData[i] >= HacimMA[i] * HACIM_ORAN);

        // ── YUKARI GAP → SHORT ──────────────────────────────────────────────────
        if (gapDir == 1 && YON_MODU != "SADECE_AL" && VadeTipi != "SPOT")
        {
            // OR_Low kırılması = açılış konsolidasyonu aşağı bozuldu → gap fill başlıyor
            bool orKirildi  = C[i] < orLow;
            // Henüz gap fill olmadı (yoksa işlem yapmaya gerek yok)
            bool fillOlmadi = C[i] > gapFillLvl;
            // RSI: yukarı gap sonrası aşırı alım bölgesi (geri dönüş momentumu var)
            bool rsiOk      = !RSI_FILTRE_AKTIF || RSI_Ser[i] > RSI_OB;

            if (zamanOk && orKirildi && fillOlmadi && hacimOk && rsiOk)
            {
                Sinyal      = "S";
                inShort     = true;
                entryPrice  = C[i];
                // Stop = OR yüksek + ATR tamponu (bu seviye kırılırsa gap fill tezi bozulmuştur)
                stopLevel   = orHigh + ATR[i] * ATR_STOP_MULT;
                barsInPos   = 0;
                posStartBar = i;
            }
        }

        // ── ASAGI GAP → LONG ────────────────────────────────────────────────────
        if (gapDir == -1 && YON_MODU != "SADECE_SAT")
        {
            // OR_High kırılması = açılış konsolidasyonu yukarı bozuldu → gap fill başlıyor
            bool orKirildi  = C[i] > orHigh;
            // Henüz gap fill olmadı
            bool fillOlmadi = C[i] < gapFillLvl;
            // RSI: aşağı gap sonrası aşırı satım bölgesi (toparlanma momentumu var)
            bool rsiOk      = !RSI_FILTRE_AKTIF || RSI_Ser[i] < RSI_OS;

            if (zamanOk && orKirildi && fillOlmadi && hacimOk && rsiOk)
            {
                Sinyal      = "A";
                inLong      = true;
                entryPrice  = C[i];
                // Stop = OR düşük - ATR tamponu
                stopLevel   = orLow - ATR[i] * ATR_STOP_MULT;
                barsInPos   = 0;
                posStartBar = i;
            }
        }
    }

    // ===========================================================================
    // LONG ÇIKIŞ
    // ===========================================================================
    if (inLong && Sinyal == "")
    {
        barsInPos++;

        // Hedef: gap fill seviyesi (önceki günün kapanışı)
        bool stopHit    = L[i] <= stopLevel;
        bool targetHit  = H[i] >= gapFillLvl || C[i] >= gapFillLvl;
        bool zamanDoldu = posStartBar > 0 && (i - posStartBar) >= GAP_WINDOW_BARS;
        // Akşam seansı başlamadan önce kapat (gap fill stratejisi geceye taşınmaz)
        bool aksamKapa  = aksamSeansi && t >= new TimeSpan(22, 50, 0);
        // Güvenlik: OR_Low tekrar kırılırsa gap fill yönü tersine döndü
        bool ters       = C[i] < orLow && barsInPos > 3;

        if (stopHit || targetHit || zamanDoldu || aksamKapa || ters)
        {
            Sinyal      = "F";
            inLong      = false;
            gapActive   = false;
            cooldownCt  = COOLDOWN_BARS;
            barsInPos   = 0;
            entryPrice  = 0f; stopLevel = 0f; posStartBar = -1;
        }
    }

    // ===========================================================================
    // SHORT ÇIKIŞ
    // ===========================================================================
    if (inShort && Sinyal == "")
    {
        barsInPos++;

        bool stopHit    = H[i] >= stopLevel;
        bool targetHit  = L[i] <= gapFillLvl || C[i] <= gapFillLvl;
        bool zamanDoldu = posStartBar > 0 && (i - posStartBar) >= GAP_WINDOW_BARS;
        bool aksamKapa  = aksamSeansi && t >= new TimeSpan(22, 50, 0);
        // Güvenlik: OR_High tekrar kırılırsa gap devam ediyor demektir
        bool ters       = C[i] > orHigh && barsInPos > 3;

        if (stopHit || targetHit || zamanDoldu || aksamKapa || ters)
        {
            Sinyal      = "F";
            inShort     = false;
            gapActive   = false;
            cooldownCt  = COOLDOWN_BARS;
            barsInPos   = 0;
            entryPrice  = 0f; stopLevel = 0f; posStartBar = -1;
        }
    }

    // YÖN GÜNCELLEME
    if (Sinyal != "" && SonYon != Sinyal)
    {
        SonYon = Sinyal;
        Sistem.Yon[i] = SonYon;
    }
}

// ===============================================================================================
// ÇİZİMLER
// ===============================================================================================
Sistem.Cizgiler[0].Deger      = _ORHigh;
Sistem.Cizgiler[0].Aciklama   = "OR High (Açılış Aralığı Üst)";
Sistem.Cizgiler[0].Renk       = Color.DodgerBlue;
Sistem.Cizgiler[0].ActiveBool = true;

Sistem.Cizgiler[1].Deger      = _ORLow;
Sistem.Cizgiler[1].Aciklama   = "OR Low (Açılış Aralığı Alt)";
Sistem.Cizgiler[1].Renk       = Color.OrangeRed;
Sistem.Cizgiler[1].ActiveBool = true;

Sistem.Cizgiler[2].Deger      = _FillLvl;
Sistem.Cizgiler[2].Aciklama   = "Gap Fill Hedefi (Önceki Kapanış)";
Sistem.Cizgiler[2].Renk       = Color.Gold;
Sistem.Cizgiler[2].ActiveBool = true;

Sistem.Cizgiler[3].Deger      = _StopLvl;
Sistem.Cizgiler[3].Aciklama   = "Stop Seviyesi";
Sistem.Cizgiler[3].Renk       = Color.Tomato;
Sistem.Cizgiler[3].ActiveBool = true;

Sistem.Cizgiler[4].Deger      = EMA50;
Sistem.Cizgiler[4].Aciklama   = "EMA(50) — Bağlam";
Sistem.Cizgiler[4].Renk       = Color.DimGray;
Sistem.Cizgiler[4].ActiveBool = true;
