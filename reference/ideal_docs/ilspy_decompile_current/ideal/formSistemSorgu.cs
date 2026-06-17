using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class formSistemSorgu : Form
{
	private class SorguClass
	{
		public int No;

		public string Aciklama;

		public string Symbol;

		public string Periyot;

		public object[] Deger;

		public Color AciklamaZeminRengi;

		public Color AciklamaYaziRengi;

		public Color[] ZeminRenk;

		public Color[] YaziRenk;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SorguClass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SorguClass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public static formSistemSorgu Reference;

	public static Point FormLocation;

	public static Size FormSize;

	public static string SymbolFilter;

	public static string Period;

	private List<SorguClass> SorguList;

	private string SortKey;

	private bool SortAscending;

	private Thread Thread1;

	private volatile string ThreadStatus;

	private bool StopBool;

	private IContainer components;

	private ComboBox comboSistemName;

	private Button buttonSymbols;

	private Timer timerThread;

	private Button buttonHesapla;

	private Button buttonFormul;

	private Button buttonExcel;

	private DataGridView gridData;

	private DataGridViewTextBoxColumn ColTradeNo;

	private DataGridViewTextBoxColumn ColTradeDirection;

	private DataGridViewTextBoxColumn ColTradeLot;

	private DataGridViewTextBoxColumn ColTradeBuyDate;

	private DataGridViewTextBoxColumn ColTradeBuyPrice;

	private DataGridViewTextBoxColumn ColTradeSellDate;

	private DataGridViewTextBoxColumn ColTradeSellPrice;

	private DataGridViewTextBoxColumn ColTradeProfit;

	private DataGridViewTextBoxColumn ColTradeSellCash;

	private TextBox textRefresh;

	private Label label1;

	private Timer timerRefresh;

	private CheckBox checkPeriod2;

	private CheckBox checkPeriod4;

	private CheckBox checkPeriod5;

	private CheckBox checkPeriod8;

	private CheckBox checkPeriod10;

	private CheckBox checkPeriod15;

	private CheckBox checkPeriod20;

	private CheckBox checkPeriod30;

	private CheckBox checkPeriod60;

	private CheckBox checkPeriod120;

	private CheckBox checkPeriod240;

	private CheckBox checkPeriodS;

	private CheckBox checkPeriodG;

	private CheckBox checkPeriodH;

	private CheckBox checkPeriodF;

	private Button buttonStop;

	private CheckBox checkPeriod1;

	private CheckBox checkPeriod5S;

	private CheckBox checkPeriod10S;

	private CheckBox checkPeriod15S;

	private Panel panel1;

	private TextBox textBarSayisi;

	private RadioButton radioButtonBarSayisi01;

	private RadioButton radioButtonBarSayisi00;

	private Panel panel2;

	private RadioButton radioButtonSonBar01;

	private RadioButton radioButtonSonBar00;

	private Label label2;

	private Label label3;

	private Label labelSaat;

	private Label labelTarih;

	private DateTimePicker datetimeSelect;

	private ContextMenuStrip menuGenel;

	private ToolStripMenuItem menuGenelExcel;

	private ToolStripMenuItem menuGenelListeyeKaydet;

	private ToolStripMenuItem menuGenelGrafikDongu;

	private ToolStripMenuItem menuGenelWatchlist;

	private CheckBox checkBoxYenile;

	private Label labelInfoStatus;

	private ToolStripMenuItem menuAktifSatir;

	private CheckBox checkPeriodA;

	private CheckBox checkPeriod3;

	private CheckBox checkPeriodY;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formSistemSorgu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSistemSorgu_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSistemSorgu_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonExcel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonFormul_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonHesapla_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonStop_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonSymbols_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboSistemName_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridData_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textRefresh_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textRefresh_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerRefresh_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerThread_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CalculateData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeSistem(string periodX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string ConvertDateToString(DateTime datetimeX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessMenuMessage(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelTarih_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeSelect_Leave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeSelect_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelSaat_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGenelExcel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGenelListeyeKaydet_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGenelGrafikDongu_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGenelWatchlist_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuAktifSatir_Click(object sender, EventArgs e)
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
	static formSistemSorgu()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		Reference = null;
		FormLocation = new Point(50, 50);
		FormSize = new Size(1100, 500);
		SymbolFilter = "XU-100";
		Period = "G";
	}
}
