using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class formOpsiyonAnaliz : Form
{
	public static string yon;

	public static bool comboAktif;

	public List<cxBasic> OpsiyonListler;

	public static string activeChartSeri;

	public static string Hesaplama;

	public static cxBasic ActiveOpsiyon;

	public static cxBasic ActiveBaseSymbol;

	public static string SdegerTip;

	public static double activeBondRate;

	public static bool isdividedsybol;

	public static double dividedsembolsonfiyat;

	private IContainer components;

	private Button btnTarihHesapDown;

	private Button btnTemettuDown;

	private Button btnFaizODown;

	private Button btnIslemeKoyDown;

	private Button btnBasePriceDown;

	private Button btnImpVolDown;

	private Button btnTarihVadeUp;

	private DataGridView gridOpsiyonDef;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn Column11;

	private DataGridViewTextBoxColumn Alan2;

	private DataGridViewTextBoxColumn Deger2;

	private Button btnVaranPriceDown;

	private ComboBox comboGrafikSec;

	private Button btnTarihVadeDown;

	private ComboBox comboDayanak;

	private ToolStripMenuItem dToolStripMenuItem1;

	private ToolStripMenuItem dToolStripMenuItem;

	private ToolStripMenuItem boyutSeçToolStripMenuItem;

	private ContextMenuStrip contextMenuVAChart;

	private DataGridView gridOpsiyonSimulasyon;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

	private ComboBox comboTipSec;

	private Button btnTarihHesapUp;

	private ComboBox cmbVade;

	private Label lblvarantKarZarar;

	private CheckBox chkCertifica;

	private Button btnTemettuUp;

	private Button btnFaizOUp;

	private Button btnIslemeKoyUp;

	private Button btnBasePriceUp;

	private Button btnImpVolUp;

	private Button btnVaranPriceUp;

	private TextBox txtTemettuV;

	private TextBox txtFaizO;

	private TextBox txtIkoyma;

	private Chart chart1;

	private TextBox txtDayanakPrice;

	private TextBox txtIpldVol;

	private ComboBox cmbKullanimFiyati;

	private ListView listViewOpsiyonList;

	private ColumnHeader columnno;

	private ColumnHeader columnVarant;

	private ColumnHeader columnTanim;

	private ColumnHeader columnVKG;

	private Panel panel1;

	private TextBox txtOpsiyonPrice;

	private DateTimePicker dateTimePVadeS;

	private DateTimePicker dateTimePHespTar;

	private Label label8;

	private Label label7;

	private Label label6;

	private Label label5;

	private Label label4;

	private Label label3;

	private Label label2;

	private Label label1;

	private TextBox txtAra;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formOpsiyonAnaliz()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formOpsiyonAnaliz_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OptionsListDoldur()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OpsiyonSecTumListele()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cmbVade_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OpsiyonSecListele()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboDayanak_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboTipSec_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboGrafikSec_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void grafikCizSimuslasyon()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void grafikCiz()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void listViewOpsiyonList_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double getRiskFreeRate(string ParaBirimi, int VadeyeKalanGun)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cmbKullanimFiyati_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnKolonAdiDegis_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnVaranPriceUp_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnVaranPriceDown_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnImpVolUp_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnImpVolDown_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnBasePriceUp_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnBasePriceDown_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnIslemeKoyUp_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnIslemeKoyDown_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnFaizOUp_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnFaizODown_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnTemettuUp_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnTemettuDown_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnTarihHesapUp_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnTarihHesapDown_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnTarihVadeUp_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnTarihVadeDown_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private double GetArtisMiktari()
	{
		return 0.0;
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
	static formOpsiyonAnaliz()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		yon = "";
		comboAktif = false;
		activeChartSeri = "Opsiyon Fiyatı";
		Hesaplama = "Gercek";
		ActiveOpsiyon = new cxBasic();
		ActiveBaseSymbol = new cxBasic();
		SdegerTip = "";
		activeBondRate = 0.0;
		isdividedsybol = false;
		dividedsembolsonfiyat = 0.0;
	}
}
