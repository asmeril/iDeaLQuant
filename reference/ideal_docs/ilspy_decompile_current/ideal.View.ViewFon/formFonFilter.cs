using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal.View.ViewFon;

public class formFonFilter : Form
{
	public static decimal? YonetimUcretiMin;

	public static decimal? YonetimUcretiMax;

	public static string SearchText;

	public static List<string> KurucuKodList;

	public static List<string> SemsiyeTurList;

	public static short RiskDegeriMin;

	public static short RiskDegeriMax;

	public static bool Tefas;

	public static bool Befas;

	public static short AlimSatimValorMin;

	public static short AlimSatimValorMax;

	private bool BoolSend;

	public static formFonFilter Reference;

	private IContainer components;

	private CheckBox checkBoxTefas;

	private CheckBox checkBoxBefas;

	private Timer timer100;

	private RangeTrackBar rangeTrackBarRiskDegeri;

	private Label labelRiskDegeri;

	private ListBox listBoxKurucu;

	private Label labelHRiskDegeri;

	private PHTextBox textBoxSearch;

	private BindingSource cxFonKurucuBindingSource;

	private Label label1;

	private MyButton myButtonClear;

	private ListBox listBoxSemsiyetur;

	private BindingSource cxFonSemsiyeTurBindingSource;

	private Label label2;

	private Label label3;

	private TextBox textBoxYonetimUcretiMin;

	private TextBox textBoxYonetimUcretiMax;

	private RangeTrackBar rangeTrackBarAlimSatimValoru;

	private Label labelAlimSatimValoru;

	private Label label5;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formFonFilter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formFonFilter_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formFonFilter_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timer100_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rangeTrackBarRiskDegeri_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rangeTrackBarAlimSatimValoru_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonClear_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void listBoxSemsiyetur_SelectedValueChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxSearch_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBoxTefas_CheckedChanged(object sender, EventArgs e)
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
	static formFonFilter()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		YonetimUcretiMin = null;
		YonetimUcretiMax = null;
		SearchText = "";
		KurucuKodList = new List<string>();
		SemsiyeTurList = new List<string>();
		RiskDegeriMin = 0;
		RiskDegeriMax = 7;
		Tefas = true;
		Befas = true;
		AlimSatimValorMin = 0;
		AlimSatimValorMax = 3;
	}
}
