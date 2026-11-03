// Portfoy Yonetim Robotu (iDeal icinde calisir)
// - Portfoy ekranindaki robot gridinden aktif robotlari okur
// - Anlik K/Z hesaplar
// - Kar hedefi, zarar stopu ve izleyen stop uygular
// - Tetikte tum acik robot pozisyonlarini kapatir
// - Robot aksiyonunu YOK moduna almaya calisir

using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;

// =====================
// Ayarlar
// =====================
var KAR_HEDEF_TL = 12000.0;      // Toplam kar bu seviyeye ulasinca koruma aktif olur
var ZARAR_STOP_TL = -8000.0;     // Toplam zarar bu seviyenin altina inerse kapat
var IZLEYEN_STOP_AKTIF = true;   // true ise zirveden dususe gore kapat
var IZLEYEN_DUSUS_TL = 2500.0;   // Zirve K/Z'den bu kadar dusunce kapat
var HESAP_ADI = "102645, Meksa Yatirim";
var ALT_HESAP = "1";

var STATE_FILE = "C:\\iDeal\\PortfoyYonetimState.txt";
var LOG_FILE = "C:\\iDeal\\PortfoyYonetimLog.txt";

// Sembol bazli carpani ihtiyaca gore duzenleyebilirsin.
var SOZLESME_CARPANI = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase)
{
    { "VIP'VIP-X030-T", 1.0 },
    { "VIP'VIP-GARAN", 1.0 },
    { "VIP'VIP-HALKB", 1.0 },
    { "VIP'VIP-THYAO", 1.0 },
    { "VIP'VIP-BRSAN", 1.0 },
};

Action<string> Log = (msg) =>
{
    try
    {
        File.AppendAllText(LOG_FILE, DateTime.Now.ToString("o") + " | " + msg + "\r\n");
    }
    catch { }
};

Func<string, double> ParseTr = (txt) =>
{
    if (string.IsNullOrWhiteSpace(txt))
        return 0.0;

    var s = txt.Trim().Replace(" ", "");
    if (s.Contains(",") && s.Contains("."))
        s = s.Replace(".", "").Replace(",", ".");
    else if (s.Contains(","))
        s = s.Replace(",", ".");

    double v;
    if (double.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out v))
        return v;

    return 0.0;
};

Func<string, double> GetCarpan = (sym) =>
{
    if (string.IsNullOrEmpty(sym))
        return 1.0;

    double c;
    if (SOZLESME_CARPANI.TryGetValue(sym, out c))
        return c;

    return 1.0;
};

Func<Form> GetPortfolioForm = () =>
{
    foreach (Form frm in Application.OpenForms)
    {
        if (frm.Name == "formPortfolio" || (frm.Text != null && frm.Text.IndexOf("Portf", StringComparison.OrdinalIgnoreCase) >= 0))
            return frm;
    }
    return null;
};

Func<Form, DataGridView> GetRobotGrid = (frm) =>
{
    if (frm == null)
        return null;

    string[] names = new string[] { "gridRobotPosition", "gridRobotOrder", "gridMagnus" };
    DataGridView best = null;
    int bestRows = -1;

    foreach (var n in names)
    {
        try
        {
            var found = frm.Controls.Find(n, true);
            if (found == null || found.Length == 0)
                continue;

            var dgv = found[0] as DataGridView;
            if (dgv == null)
                continue;

            int cnt = 0;
            foreach (DataGridViewRow r in dgv.Rows)
                if (r != null && !r.IsNewRow)
                    cnt++;

            if (cnt > bestRows)
            {
                bestRows = cnt;
                best = dgv;
            }
        }
        catch { }
    }

    return best;
};

Action<Form> SetActionYok = (frm) =>
{
    if (frm == null)
        return;

    try
    {
        var found = frm.Controls.Find("radioRobotAction0", true);
        if (found != null && found.Length > 0)
        {
            var rb = found[0] as RadioButton;
            if (rb != null)
            {
                rb.Checked = true;
                Log("Robot aksiyonu YOK moduna alindi (radioRobotAction0). ");
            }
        }
    }
    catch (Exception ex)
    {
        Log("SetActionYok hata: " + ex.Message);
    }
};

Func<string, string, double, double, string> BuildAnahtar = (robotName, symbol, pos, entry) =>
{
    return robotName + "," + symbol;
};

Func<double> LoadPeak = () =>
{
    try
    {
        if (!File.Exists(STATE_FILE))
            return 0.0;
        var t = File.ReadAllText(STATE_FILE).Trim();
        return ParseTr(t);
    }
    catch { }
    return 0.0;
};

Action<double> SavePeak = (peak) =>
{
    try
    {
        File.WriteAllText(STATE_FILE, peak.ToString("0.####", CultureInfo.InvariantCulture));
    }
    catch { }
};

var formPortfolio = GetPortfolioForm();
if (formPortfolio == null)
{
    Sistem.Mesaj("Portfoy formu bulunamadi.");
    Log("Portfoy formu yok.");
}
else
{
    var grid = GetRobotGrid(formPortfolio);
    if (grid == null)
    {
        Sistem.Mesaj("Robot grid bulunamadi.");
        Log("Robot grid yok.");
    }
    else
    {
        // Grid kolonlari beklenen: [0]=Anahtar(robot,symbol), [1]=Pozisyon, [2]=Fiyat, [3]=Tarih, [4]=Rezerv
        var robots = new List<Dictionary<string, object>>();

        foreach (DataGridViewRow row in grid.Rows)
        {
            if (row == null || row.IsNewRow)
                continue;

            string keyAndSymbol = Convert.ToString(row.Cells[0].Value);
            double pos = ParseTr(Convert.ToString(row.Cells[1].Value));
            double entry = ParseTr(Convert.ToString(row.Cells[2].Value));

            if (string.IsNullOrWhiteSpace(keyAndSymbol))
                continue;

            var parts = keyAndSymbol.Split(',');
            var robotName = parts.Length > 0 ? parts[0].Trim().TrimStart('_') : "";
            var symbol = parts.Length > 1 ? parts[1].Trim() : "";
            if (string.IsNullOrWhiteSpace(robotName) || string.IsNullOrWhiteSpace(symbol))
                continue;

            var son = Sistem.SonFiyat(symbol);
            var carpan = GetCarpan(symbol);
            var pnl = (son - entry) * pos * carpan;

            var d = new Dictionary<string, object>();
            d["robot"] = robotName;
            d["symbol"] = symbol;
            d["pos"] = pos;
            d["entry"] = entry;
            d["last"] = son;
            d["pnl"] = pnl;
            robots.Add(d);
        }

        double totalPnl = 0.0;
        foreach (var r in robots)
            totalPnl += Convert.ToDouble(r["pnl"]);

        var peak = LoadPeak();
        if (totalPnl > peak)
            peak = totalPnl;
        SavePeak(peak);

        var drawdown = peak - totalPnl;

        bool trigger = false;
        string reason = "";

        if (totalPnl <= ZARAR_STOP_TL)
        {
            trigger = true;
            reason = "ZARAR_STOP";
        }
        else if (totalPnl >= KAR_HEDEF_TL)
        {
            // Kar hedefi gorulunce izleyen stop devrede kalir, aninda kapatma yok.
            if (!IZLEYEN_STOP_AKTIF)
            {
                trigger = true;
                reason = "KAR_HEDEF";
            }
        }

        if (!trigger && IZLEYEN_STOP_AKTIF && peak >= KAR_HEDEF_TL && drawdown >= IZLEYEN_DUSUS_TL)
        {
            trigger = true;
            reason = "IZLEYEN_STOP";
        }

        var ozet = string.Format("RobotSayisi={0} TotalPnL={1:0.00} Peak={2:0.00} DD={3:0.00}", robots.Count, totalPnl, peak, drawdown);
        Sistem.Mesaj("PM: " + ozet);
        Log("PM: " + ozet + " Trigger=" + trigger + " Reason=" + reason);

        if (trigger)
        {
            SetActionYok(formPortfolio);

            // Tum acik robot pozisyonlarini piyasa emri ile kapat
            foreach (var r in robots)
            {
                var robotName = Convert.ToString(r["robot"]);
                var symbol = Convert.ToString(r["symbol"]);
                var pos = Convert.ToDouble(r["pos"]);
                var last = Convert.ToDouble(r["last"]);

                if (Math.Abs(pos) < 0.0001)
                    continue;

                var islem = pos > 0 ? "SATIS" : "ALIS";
                var miktar = Math.Abs(pos);
                var anahtar = BuildAnahtar(robotName, symbol, pos, Convert.ToDouble(r["entry"]));
                var rezerv = "PM " + reason + " | ToplamKZ=" + totalPnl.ToString("0.00");

                try
                {
                    Sistem.EmirAksamSeansi = 1;
                    Sistem.EmirSembol = symbol;
                    Sistem.EmirIslem = islem;
                    Sistem.EmirSuresi = "KIE";
                    Sistem.EmirTipi = "Piyasa";
                    Sistem.EmirMiktari = miktar;
                    Sistem.EmirHesapAdi = HESAP_ADI;
                    Sistem.EmirAltHesap = ALT_HESAP;
                    Sistem.EmirAciklama = rezerv;
                    Sistem.EmirFiyati = last;
                    Sistem.EmirGonder();

                    Sistem.PozisyonKontrolGuncelle(anahtar, 0, last, rezerv);

                    Log("KAPAT " + robotName + " " + symbol + " " + islem + " " + miktar.ToString("0.####"));
                }
                catch (Exception ex)
                {
                    Log("KAPAT HATA " + robotName + " -> " + ex.Message);
                }
            }

            Sistem.Mesaj("PM tetik: " + reason + " | Tum robotlar icin kapatma denendi.");
        }
    }
}
