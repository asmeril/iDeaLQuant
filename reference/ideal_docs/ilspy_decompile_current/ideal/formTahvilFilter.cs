using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class formTahvilFilter : Form
{
	private bool BoolSend;

	public static formTahvilFilter Reference;

	public static Dictionary<string, bool> ValorDictionary;

	public static List<string> ValorFilterList;

	public static string IsinFilter;

	public static double LotBuyukFilter;

	public static int DtmBuyukFilter;

	public static int DtmKucukFilter;

	public static int DtcBuyukFilter;

	public static int DtcKucukFilter;

	public static int SortField;

	private IContainer components;

	private Timer timer100;

	private Label label4;

	private Label label3;

	private Label label2;

	private TextBox textBoxDtcKucuk;

	private TextBox textBoxDtmKucuk;

	private TextBox textBoxDtcBuyuk;

	private TextBox textBoxDtmBuyuk;

	private TextBox textBoxLotBuyuk;

	private TextBox textBoxIsin;

	private Label label1;

	private CheckedListBox checkedListBoxValor;

	private Button buttonFilterAll;

	private Button buttonClose;

	private RadioButton radiosort0;

	private RadioButton radiosort1;

	private Label label5;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formTahvilFilter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTahvilFilter_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTahvilFilter_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonClose_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonFilterAll_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkedListBoxValor_ItemCheck(object sender, ItemCheckEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radiosort_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxIsin_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBox_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBox_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timer100_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillValor()
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
	static formTahvilFilter()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		ValorDictionary = new Dictionary<string, bool>();
		ValorFilterList = new List<string>();
		IsinFilter = "";
		LotBuyukFilter = 0.0;
		DtmBuyukFilter = 0;
		DtmKucukFilter = 0;
		DtcBuyukFilter = 0;
		DtcKucukFilter = 0;
		SortField = 0;
	}
}
