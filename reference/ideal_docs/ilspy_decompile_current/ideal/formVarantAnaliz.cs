using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class formVarantAnaliz : Form
{
	public static cxBasic ActiveVarant;

	public static cxBasic ActiveBaseSymbol;

	public static double dividedsembolsonfiyat;

	public static bool isdividedsybol;

	public static bool comboAktif;

	public static string activeChartSeri;

	public static double activeBondRate;

	public static string Hesaplama;

	public static string SdegerTip;

	public List<cxBasic> varantOpsiyonlist;

	public static string yon;

	private IContainer components;

	private TextBox txtAra;

	private ListView listViewVaranList;

	private ColumnHeader columnno;

	private ColumnHeader columnVarant;

	private ColumnHeader columnTanim;

	private ColumnHeader columnVKG;

	private Panel panel1;

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

	private TextBox txtTemettuV;

	private TextBox txtFaizO;

	private TextBox txtIkoyma;

	private TextBox txtDayanakPrice;

	private TextBox txtIpldVol;

	private TextBox txtVarantPrice;

	private ComboBox comboTipSec;

	private Chart chart1;

	private Button btnVaranPriceDown;

	private Button btnVaranPriceUp;

	private Button btnTemettuDown;

	private Button btnFaizODown;

	private Button btnIslemeKoyDown;

	private Button btnBasePriceDown;

	private Button btnImpVolDown;

	private Button btnTemettuUp;

	private Button btnFaizOUp;

	private Button btnIslemeKoyUp;

	private Button btnBasePriceUp;

	private Button btnImpVolUp;

	private ComboBox comboIhracci;

	private ComboBox comboDayanak;

	private ComboBox comboGrafikSec;

	private ContextMenuStrip contextMenuVAChart;

	private ToolStripMenuItem boyutSeçToolStripMenuItem;

	private ToolStripMenuItem dToolStripMenuItem;

	private ToolStripMenuItem dToolStripMenuItem1;

	private Button btnTarihVadeDown;

	private Button btnTarihHesapDown;

	private Button btnTarihVadeUp;

	private Button btnTarihHesapUp;

	private DataGridView gridVarantDef;

	private DataGridView gridVarantSimulasyon;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn Column11;

	private DataGridViewTextBoxColumn Alan2;

	private DataGridViewTextBoxColumn Deger2;

	private Label lblvarantKarZarar;

	private Button button1;

	private ComboBox cmbVade;

	private ComboBox cmbKullanimFiyati;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formVarantAnaliz()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formVarantAnaliz_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chkVarant_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chkOptions_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chkCertifica_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnVaranPriceDown_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnVaranPriceUp_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnImpVolDown_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnImpVolUp_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnBasePriceDown_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnBasePriceUp_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnIslemeKoyDown_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnIslemeKoyUp_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnFaizODown_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnFaizOUp_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnTemettuDown_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnTemettuUp_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnTarihHesapDown_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnTarihHesapUp_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnTarihVadeDown_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnTarihVadeUp_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void txtAra_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void txtAra_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboIhracci_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboDayanak_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboGrafikSec_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboTipSec_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void listViewVaranList_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dToolStripMenuItem1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void varantOpsiyonSecListele()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void varantOpsiyonSecTumListele()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double getRiskFreeRate(string ParaBirimi, int VadeyeKalanGun)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double VarantPriceNormalize(cxBasic varantX, out double varantval)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double VarantPriceAjdust(cxBasic varantX, double varantval)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private double GetArtisMiktari()
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void grafikCiz()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void grafikCizSimuslasyon()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VarantOptionsListDoldur()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void txtSimulaston_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOptions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetVarants()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cmbVade_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void button1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cmbVade_SelectedIndexChanged_1(object sender, EventArgs e)
	{
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
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static formVarantAnaliz()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		ActiveVarant = new cxBasic();
		ActiveBaseSymbol = new cxBasic();
		dividedsembolsonfiyat = 0.0;
		isdividedsybol = false;
		comboAktif = false;
		activeChartSeri = "Varant Fiyatı";
		activeBondRate = 0.0;
		Hesaplama = "Gercek";
		SdegerTip = "";
		yon = "";
	}
}
