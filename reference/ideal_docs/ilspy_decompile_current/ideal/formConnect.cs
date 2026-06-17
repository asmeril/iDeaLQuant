using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class formConnect : Form
{
	public static formConnect Reference;

	public static double ToplamBytes;

	public static double ToplamBytesSn;

	public static double HisseToplamPaket;

	public static double ViopToplamPaket;

	public static double HisseToplamPaketSn;

	public static double ViopToplamPaketSn;

	public static double HisseDerinlikPaket;

	public static double HisseIslemPaket;

	public static double HisseYuzeyselPaket;

	public static double HisseVarantPaket;

	public static double HisseEndeksPaket;

	public static double HisseDnrToplamPaket;

	public static double HisseDerinlikPaketSn;

	public static double HisseIslemPaketSn;

	public static double HisseYuzeyselPaketSn;

	public static double HisseVarantPaketSn;

	public static double HisseEndeksPaketSn;

	public static double HisseDnrToplamPaketSn;

	public static float HisseDerinlikPaketYuz;

	public static float HisseIslemPaketYuz;

	public static float HisseYuzeyselPaketYuz;

	public static float HisseVarantPaketYuz;

	public static float HisseEndeksPaketYuz;

	public static float HisseDnrToplamPaketYuz;

	public static double VIOPDerinlikPaket;

	public static double VIOPIslemPaket;

	public static double VIOPYuzeyselPaket;

	public static double ViopDnrToplamPaket;

	public static double VIOPDerinlikPaketSn;

	public static double VIOPIslemPaketSn;

	public static double VIOPYuzeyselPaketSn;

	public static double ViopDnrToplamPaketSn;

	public static float VIOPDerinlikPaketYuz;

	public static float VIOPIslemPaketYuz;

	public static float VIOPYuzeyselPaketYuz;

	public static double TahvilPaket;

	public static double TahvilPaketSn;

	public static double HisseEndeks2Paket;

	public static double HisseEndeks2PaketSn;

	public static double OptionPaket;

	public static double OptionPaketSn;

	public static double BytesSn;

	public static List<double> Bytes10SnList;

	public static List<double> Bytes60SnList;

	public static List<string> YuksekByteList;

	public static List<string> SaniyeFarkList;

	private IContainer components;

	private Timer timerRefresh;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private TabPage tabPage2;

	private TabPage tabPage3;

	private Label label6;

	private Label label4;

	private RadioButton radioServer4;

	private RadioButton radioServer3;

	private RadioButton radioServer2;

	private RadioButton radioServer1;

	private Label labelVersion;

	private Label labelProductType;

	private Label labelExpiry;

	private Label labelTerminal;

	private Label labelMachineName;

	private Label label9;

	private Label label10;

	private Label label12;

	private Label label13;

	private Label label14;

	private Label labelOnOff;

	private TextBox textHost2Port;

	private TextBox textHost2Address;

	private TextBox textPort4;

	private TextBox textServer4;

	private TextBox textPort3;

	private TextBox textServer3;

	private TextBox textPort2;

	private TextBox textServer2;

	private TextBox textPort1;

	private TextBox textServer1;

	private Label labelConnected;

	private CheckBox checkAutoReconnect;

	private CheckBox checkAutoOpen;

	private CheckBox checkRemember;

	private Button buttonConnect;

	private TextBox textUsername;

	private Label label2;

	private Label label1;

	private CheckBox checkMessenger;

	private CheckBox checkDJN;

	private CheckBox checkDJF;

	private CheckBox checkDJES;

	private CheckBox checkDJCS;

	private CheckBox checkDJA;

	private CheckBox checkDJBN;

	private CheckBox checkGTIS;

	private CheckBox checkCHIX;

	private CheckBox checkXETRA;

	private CheckBox checkSPI;

	private CheckBox checkNASDAQ;

	private CheckBox checkNYSE;

	private CheckBox checkNYMEXM;

	private CheckBox checkNYMEX;

	private CheckBox checkLSE;

	private CheckBox checkEUREX;

	private CheckBox checkDJI;

	private CheckBox checkCOMEX;

	private CheckBox checkCMEM;

	private CheckBox checkCME;

	private CheckBox checkCBOTM;

	private CheckBox checkCBOT;

	private CheckBox checkKARMA;

	private CheckBox checkWINX;

	private CheckBox checkFUTGCK;

	private CheckBox checkTHVL2;

	private CheckBox checkTHVL1P;

	private CheckBox checkTHVL1;

	private CheckBox checkVIPL2;

	private CheckBox checkVIPL1P;

	private CheckBox checkVIPL1;

	private CheckBox checkIMKBX;

	private CheckBox checkIMKBL2;

	private CheckBox checkIMKBL1P;

	private CheckBox checkIMKBL1;

	private GroupBox groupBox1;

	private TextBox textNewPass2;

	private Label label15;

	private TextBox textNewPass1;

	private Label label11;

	private Button buttonChangePass;

	private TextBox textPassChange;

	private Label label5;

	private GroupBox groupBox2;

	private TextBox textNick2;

	private Label label16;

	private TextBox textNick1;

	private Label label17;

	private Button buttonChangeNick;

	private TextBox textPassNick;

	private Label label18;

	public TextBox textPassword;

	private CheckBox checkDovizQuote;

	private GroupBox groupBox3;

	private RadioButton radioHttp1;

	private RadioButton radioHttp0;

	private CheckBox checkIMKBISL;

	private RadioButton radioHttp2;

	public TextBox textDownloadPath;

	private CheckBox checkVIPNET;

	private CheckBox checkSASEL2;

	private CheckBox checkSASEL1;

	private CheckBox checkPITE;

	private Panel panel1;

	private Label labelOtomatikPort;

	private Label labelOtomatikAdres;

	private TextBox textBoxOtomatikPort;

	private TextBox textBoxOtomatikAdres;

	private CheckBox checkBoxOtomatikSunucu;

	private GroupBox groupBox4;

	private CheckBox checkBoxEnUygun;

	private Button buttonEnUygunGuncelle;

	private CheckBox checkAMEX;

	private Button buttonKriptoServerConnect;

	private TextBox textKriptoSServerColor;

	private TextBox textKriptoServerIP;

	private CheckBox checkKriptoServer;

	private TextBox textKriptoServerPort;

	private Label lblEnUygunPort;

	private Label lblEnUygunIp;

	private TabPage tabPage4;

	private Button buttonSifirla;

	private Label labelToplamBytes;

	private Label label19;

	private GroupBox groupBox5;

	private Label labelHisseEndeksler;

	private Label label27;

	private Label labelHisseDrnToplam;

	private Label label24;

	private Label labelHisseIslem;

	private Label label25;

	private Label labelHisseYuzeysel;

	private Label label23;

	private Label labelHisseDerinlik;

	private Label label22;

	private Label labelHisseEndekslerSn;

	private Label labelHisseDrnToplamSn;

	private Label labelHisseIslemSn;

	private Label labelHisseYuzeyselSn;

	private Label labelHisseDerinlikSn;

	private GroupBox groupBox6;

	private Label labelVIOPIslemSn;

	private Label labelVIOPYuzeyselSn;

	private Label labelVIOPDerinlikSn;

	private Label labelVIOPIslem;

	private Label label43;

	private Label labelVIOPYuzeysel;

	private Label label45;

	private Label labelVIOPDerinlik;

	private Label label47;

	private Label label30;

	private Label label29;

	private Label label28;

	private Label label20;

	private GroupBox groupBox7;

	private GroupBox groupFirewall;

	private TextBox textFirewallPort;

	private Label label8;

	private TextBox textFirewallUser;

	private Label label7;

	private TextBox textFirewallPassword;

	private Label label3;

	private TextBox textFirewallHost;

	private Label labelHost;

	private CheckBox checkFirewallAuto;

	private RadioButton radioFirewall3;

	private RadioButton radioFirewall2;

	private RadioButton radioFirewall1;

	private RadioButton radioFirewall0;

	private BackgroundWorker backgroundWorker1;

	private GroupBox groupBox8;

	private Label labelToplamBytesSn;

	private Label label32;

	private Label labelHisseVarantSn;

	private Label labelHisseVarant;

	private Label label39;

	private Label labelEndeks2Sn;

	private Label labelEndeks2;

	private Label label40;

	private Label labelTahvilSn;

	private Label labelTahvil;

	private Label label41;

	private Label labelVIOPDrnToplamSn;

	private Label labelVIOPDrnToplam;

	private Label label34;

	private Label labelToplamBytes10Sn;

	private Label label26;

	private Label labelToplamBytes60Sn;

	private Label label31;

	private TabPage tabPage5;

	private ListBox listBoxBytes;

	private Button buttonYuksekBytes;

	private Button buttonclear;

	private Label labelOptionSn;

	private Label labelOption;

	private Label label35;

	private CheckBox checkYayinSaniyefark;

	private Button buttonSaniyeFark;

	private CheckBox checkMagnus;

	private CheckBox checkMKK;

	private GroupBox groupBox9;

	private TextBox textTuribServerColor;

	private TextBox textTuribServerPort;

	private CheckBox checkTuribServer;

	private Button buttonTuribServerConnect;

	private TextBox textTuribServerIP;

	private CheckBox checkTurib;

	private CheckBox checkALGOCRYPT;

	private CheckBox checkGKKUL;

	private CheckBox checkPortalgo;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formConnect()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formConnection_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formConnect_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formConnection_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonChangeNick_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonChangePass_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonConnect_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkAutoOpen_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkAutoReconnect_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkFirewallAuto_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioHttp0_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioFirewall0_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioServer1_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioServer2_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioServer3_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioServer4_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerRefresh_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveParameters()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ConnectKriptoServer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ConnectTuribServer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBoxOtomatikSunucu_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBoxEnUygun_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonEnUygunGuncelle_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonKriptoServerConnect_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkKriptoServer_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonTuribServerConnect_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkTuribServer_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonSifirla_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBoxEnUygun_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonYuksekBytes_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonclear_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkYayinSaniyefark_CheckedChanged(object sender, EventArgs e)
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
	static formConnect()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		Reference = null;
		ToplamBytes = 0.0;
		ToplamBytesSn = 0.0;
		HisseToplamPaket = 0.0;
		ViopToplamPaket = 0.0;
		HisseToplamPaketSn = 0.0;
		ViopToplamPaketSn = 0.0;
		HisseDerinlikPaket = 0.0;
		HisseIslemPaket = 0.0;
		HisseYuzeyselPaket = 0.0;
		HisseVarantPaket = 0.0;
		HisseEndeksPaket = 0.0;
		HisseDnrToplamPaket = 0.0;
		HisseDerinlikPaketSn = 0.0;
		HisseIslemPaketSn = 0.0;
		HisseYuzeyselPaketSn = 0.0;
		HisseVarantPaketSn = 0.0;
		HisseEndeksPaketSn = 0.0;
		HisseDnrToplamPaketSn = 0.0;
		HisseDerinlikPaketYuz = 0f;
		HisseIslemPaketYuz = 0f;
		HisseYuzeyselPaketYuz = 0f;
		HisseVarantPaketYuz = 0f;
		HisseEndeksPaketYuz = 0f;
		HisseDnrToplamPaketYuz = 0f;
		VIOPDerinlikPaket = 0.0;
		VIOPIslemPaket = 0.0;
		VIOPYuzeyselPaket = 0.0;
		ViopDnrToplamPaket = 0.0;
		VIOPDerinlikPaketSn = 0.0;
		VIOPIslemPaketSn = 0.0;
		VIOPYuzeyselPaketSn = 0.0;
		ViopDnrToplamPaketSn = 0.0;
		VIOPDerinlikPaketYuz = 0f;
		VIOPIslemPaketYuz = 0f;
		VIOPYuzeyselPaketYuz = 0f;
		TahvilPaket = 0.0;
		TahvilPaketSn = 0.0;
		HisseEndeks2Paket = 0.0;
		HisseEndeks2PaketSn = 0.0;
		OptionPaket = 0.0;
		OptionPaketSn = 0.0;
		BytesSn = 0.0;
		Bytes10SnList = new List<double>();
		Bytes60SnList = new List<double>();
		YuksekByteList = new List<string>();
		SaniyeFarkList = new List<string>();
	}
}
