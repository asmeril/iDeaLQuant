using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Timers;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;
using nsoftware.IPWorks;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class FormRobotServer : Form
{
	[Serializable]
	public class LineClass
	{
		public int ClassVersion;

		public int LineNo;

		public string HesapNo;

		public string AltHesap;

		public string Parola;

		public string Sifre;

		public string Strateji;

		public string Miktar;

		public bool AktifBool;

		[NonSerialized]
		public int EmirSayisiLimiti;

		[NonSerialized]
		public int SifreAsimSayisi;

		[NonSerialized]
		public Color UpdateForeColor;

		[NonSerialized]
		public string Info;

		[NonSerialized]
		public decimal Bakiye;

		[NonSerialized]
		public decimal Teminat;

		[NonSerialized]
		public List<PozisyonClass> PozisyonList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LineClass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static LineClass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private class Ata1Class
	{
		public string AktifPasif;

		public string Tip;

		public string Sembol;

		public string FiyatAralik1;

		public string FiyatAralik2;

		public string Hedef1;

		public string Stop1;

		public string Hedef2;

		public string Stop2;

		public string Durum;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Ata1Class()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Ata1Class()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class PozisyonClass
	{
		public string Sembol;

		public string Tip;

		public string Yon;

		public int Pozisyon;

		public decimal Mailyet;

		public decimal kz;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PozisyonClass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static PozisyonClass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private class HesapClass
	{
		public decimal Bakiye;

		public decimal Teminat;

		public List<PozisyonClass> PozisyonList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HesapClass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static HesapClass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private string IniFile;

	private string RobotServerFile;

	private string HttpLogFile;

	private Dictionary<int, LineClass> LineDictionary;

	private int MaxRows;

	private Dictionary<string, int> UsedRobotDictionary;

	private bool RunningBool;

	private int RunningListNo;

	private string RunningSistemName;

	private string RunningLineInfo;

	private string ErrorString;

	private bool ErrorInsertedBool;

	private bool PorfoyGoruntuleBool;

	private Timer TimerRobot;

	public static LineClass LineItem;

	public static bool EditLineBool;

	public static FormRobotServer Reference;

	private ConcurrentQueue<int> UpdateLineQueue;

	private string Kurum;

	private string PayUrl;

	private string ViopUrl;

	private string BilgilendirmeUrl;

	private int EmirSayisiLimiti;

	private int MesajPort;

	public static long AtaKey1;

	public static long AtaKey2;

	private string RemoteIP;

	private string LocalIp;

	private IContainer components;

	private TabControl tabRobotServer;

	private TabPage tabPage1;

	private DataGridView gridRobotServer;

	private DataGridViewTextBoxColumn Column1;

	private ContextMenuStrip menuRobotServer;

	private ToolStripMenuItem menuRobotServerSatirGuncelle;

	private ToolStripMenuItem menuRobotServerSatirAsagi;

	private ToolStripMenuItem menuRobotServerSatirYukari;

	private ToolStripSeparator toolStripMenuItem1;

	private ToolStripMenuItem menuRobotServerKapat;

	private Button buttonStartStop;

	private Label label1;

	private Label labelStrateji;

	private Label labelLineInfo;

	private Label label3;

	private Timer timerRefresh;

	private Label labelKota;

	private Label label4;

	private Timer timer10Min;

	private TabPage tabPage2;

	private TextBox textViopUrl;

	private Label label6;

	private TextBox textPayUrl;

	private Label label5;

	private TextBox textKurum;

	private Label label2;

	private Button buttonKaydet;

	private Label labelError;

	private ToolStripMenuItem menuRobotServerHataDosyasi;

	private ToolStripMenuItem menuRobotServerMesajDosyasi;

	private ToolStripSeparator toolStripSeparator1;

	private TextBox textEmirSayisiLimiti;

	private Label label7;

	private TextBox textMesajPort;

	private Label label8;

	public Ipdaemon hostRobotServer;

	private ToolStripMenuItem menuRobotServerSatirAktif;

	private ToolStripMenuItem menuRobotServerSatirPasif;

	private TextBox textBilgilendirmeUrl;

	private Label label9;

	private Button buttonPortfoyGuncelle;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FormRobotServer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FormRobotServer_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FormRobotServer_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FormRobotServer_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonKaydet_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonPortfoyGuncelle_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonStartStop_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobotServer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobotServer_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridRobotServer_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void hostRobotServer_OnDataIn(object sender, IpdaemonDataInEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobotServerKapat_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobotServerSatirGuncelle_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobotServerSatirAsagi_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobotServerSatirYukari_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobotServerSatirAktif_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobotServerSatirPasif_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobotServerHataDosyasi_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRobotServerMesajDosyasi_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerRefresh_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timer10Min_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TimerRobot_Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InformHttp(string str)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DeserializeRobotServer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillGrid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitHost()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrepareUsedRobotDictionary()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResizeForm()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SerializeRobotServer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowError(string str)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowPortfoy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RobotServerPozisyonEsitle(cxSistem sistemX, string symbolX, int lotX, string infoX, Color colorX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RobotServerAtaHisseSistem1(cxSistem sistem, string filename)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RobotServerMeksaHisseSistem1(cxSistem sistem, string filename)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetUrl(string Piyasa)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetGtpHeader(string AccountName, string Parola, string Password, string accountnoX, string postmessageX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetGeneksHeader(string kurum, string hesapno, string parola, string password, string althesap)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string SendHttpRequest(string requestX, string methodX, string urlX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ErrorMessageParse(Exception errorX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetRemoteIP()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string ConvertImkbReceivedSymbol(string backofficeX, string strX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string ConvertImkbSenderSymbol(string backofficeX, string strX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool AktifEmirGonder(out string errormsg, string hesapnoX, string althesapX, string parolaX, string passwordX, string symbolX, int amountX, string yonX, string satistipiX)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private HesapClass HesapGetir(out string errormsg, out string responsestr, string hesapnoX, string parolaX, string sifreX, string althesapX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PozisyonEsitle(out string errormsg, string hesapnoX, string althesapX, string parolaX, string sifreX, string symbolX, int lotX, int pozisyonX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LogYaz(string type, string reqlogStringX, string logStringX, string hesapnoX, string althesapX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static FormRobotServer()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		LineItem = new LineClass();
		EditLineBool = false;
		Reference = null;
		AtaKey1 = 238941265098L;
		AtaKey2 = 387645098123L;
	}
}
