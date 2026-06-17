using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formFonDetail : Form
{
	public string ActiveSymbol;

	private Font FontData;

	private Font FontBold;

	private int LineSpace;

	private byte CurrencyPrice;

	private byte CurrencyVolume;

	private Color FormBackColor;

	private Color LabelBackColor1;

	private Color LabelBackColor2;

	private Color LabelForeColor;

	private Color LabelBorderColor;

	private Color ValueBackColor1;

	private Color ValueBackColor2;

	private Color ValueBorderColor;

	private Color NormalColor;

	private Color HighColor;

	private Color LowColor;

	private cxPage.Detail PageParams;

	private cxBasic basicItem;

	private cxFon fonData;

	private bool RefreshNeeded;

	private string InitialSymbol;

	private int InitialLeft;

	private int InitialTop;

	private int[] ColLeft;

	private int[] ColWidth;

	private IContainer components;

	private Panel panelLeft;

	private Panel panelGrafik;

	private Label label1;

	private Label labelKodu;

	private Label label2;

	private Label labelIsinKodu;

	private Label label3;

	private Label labelPlatformIslemDurumu;

	private Label label4;

	private Label labelIslemBaslangicSaati;

	private Label label5;

	private Label labelSonIslemSaati;

	private Label label6;

	private Label labelFonAlisValoru;

	private Label label7;

	private Label labelFonSatisValoru;

	private Label label8;

	private Label labelMinAlisMiktari;

	private Label label9;

	private Label labelMinSatisMiktari;

	private Label label10;

	private Label labelMaxSatisMiktari;

	private Label labelMaxAlisMiktari;

	private Label label12;

	private Label label11;

	private Label labelFonAdi;

	private Label labelKurucu;

	private Label label14;

	private Label label13;

	private Label labelPlatform;

	private Label label15;

	private LinkLabel linkLabelKapUrl;

	private Button buttonOK;

	private TableLayoutPanel tableLayoutPanel1;

	private Chart chartVarlikDagilim;

	private Chart chartYatirimciSayisi;

	private Chart chartFonToplamDeger;

	private Timer timerRefresh;

	private Chart chartNakitGirisCikis;

	private Label labelRiskDegeri;

	private Label label16;

	private Label labelYillikYonetimUcreti;

	private Label label17;

	private Label labelAktifAdet;

	private Label labelToplamAdet;

	private Label label20;

	private Label label19;

	private Label label18;

	private Label labelDolulukOrani;

	private Label label21;

	private Label labelPazarPayi;

	private Label label22;

	private Label labelHalkaArzTarihi;

	private Label label23;

	private Label labelKategori;

	private Label label24;

	private Label labelSonFiyatTarihi;

	private Label labelSonFiyat;

	private Label label26;

	private Label label25;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formFonDetail(int leftX, int topX, string symbolX, cxPage.Detail pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formFonDetail_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitializeChart()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string getSonFiyatTarihiText()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPageParams(cxPage.Detail pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BasicDataReceived(string symbolX, string updatetypeX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MessageReceived(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void linkLabelKapUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chartYatirimciSayisi_GetToolTipText(object sender, ToolTipEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chartFonToplamDeger_GetToolTipText(object sender, ToolTipEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerRefresh_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chartNakitGirisCikis_GetToolTipText(object sender, ToolTipEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chartVarlikDagilim_GetToolTipText(object sender, ToolTipEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string numberShortText(double number)
	{
		return null;
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
	static formFonDetail()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
