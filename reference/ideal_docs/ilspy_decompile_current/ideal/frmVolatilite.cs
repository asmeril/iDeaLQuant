using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class frmVolatilite : Form
{
	private class clsVolatilite
	{
		public string opsiyonAdi;

		public string dayanakAdi;

		public string dayanakTipi;

		public string vade;

		public string callOrput;

		public string kullanimFiyati;

		public string vadeyeKalanGun;

		public double alisFiyati;

		public double satisFiyati;

		public double sonFiyat;

		public static List<clsVolatilite> opsiyonList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public clsVolatilite()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static clsVolatilite()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			WP6RZJql8gZrNhVA9v.w65ov7siki();
			hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
			opsiyonList = new List<clsVolatilite>();
		}
	}

	private static List<string> dayanak;

	private static List<string> dayanakTipi;

	private static List<string> tarih;

	private static List<string> degerler;

	private static double activeBondRate;

	private static bool isdividedsybol;

	private static List<string> roots;

	private static cxBasic ActiveBaseSymbol;

	private static cxBasic ActiveOpsiyon;

	private static double dividedsembolsonfiyat;

	private static string baseSembolStr;

	private IContainer components;

	private ComboBox cmbDayanak;

	private ComboBox cmbDayanakTipi;

	private Label label1;

	private Label label2;

	private CheckBox chkCall;

	private CheckBox chkPut;

	private GroupBox grpOpsiyon;

	private DataGridView dgvData;

	private DataGridViewTextBoxColumn KullanimFiyati;

	private Chart chart1;

	private Button btnHesapla;

	private Label label6;

	private Label label5;

	private TextBox txtGirdi;

	private TextBox txtFaiz;

	private TextBox txtSon;

	private Label label3;

	private Label lblSonFiyat;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public frmVolatilite()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void frmVolatilite_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboDoldur()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chkCall_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chkPut_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Listele()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Hsp()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnHesapla_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VolatiliteHsp()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Hesapla()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cmbDayanak_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void hataYaz(string text)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private double getRiskFreeRate(string ParaBirimi, int VadeyeKalanGun)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void grafikCiz(cxBasic ActiveOpsiyon)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dgvData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayData(cxBasic sembol)
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
	static frmVolatilite()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		dayanak = new List<string>();
		dayanakTipi = new List<string>();
		tarih = new List<string>();
		degerler = new List<string>();
		activeBondRate = 0.0;
		isdividedsybol = false;
		roots = new List<string>();
		ActiveBaseSymbol = new cxBasic();
		ActiveOpsiyon = new cxBasic();
		dividedsembolsonfiyat = 0.0;
		baseSembolStr = "";
	}
}
