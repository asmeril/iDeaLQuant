using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class formSistemGetiriEgrisi : Form
{
	private class TradeClass
	{
		public DateTime Date;

		public decimal Close;

		public decimal Bakiye;

		public decimal Pozisyon;

		public decimal Miktar;

		public decimal[] CloseArray;

		public decimal[] BakiyeArray;

		public decimal[] PozisyonArray;

		public decimal[] MiktarArray;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TradeClass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TradeClass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private class TabloClass
	{
		public string Tarih;

		public decimal StartPrice;

		public decimal EndPrice;

		public decimal BakiyeNominal;

		public decimal BakiyeYuzde;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TabloClass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TabloClass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private decimal MaxDdX1;

	private decimal MaxDdX2;

	private decimal MaxDdY1;

	private decimal MaxDdY2;

	private Font SegoeT8;

	private Font SegoeT14;

	private Font SegoeT24;

	private StringFormat AlignTopLeft;

	private List<Color> ColorList;

	private Application ExcellApp;

	public static string Symbol;

	private List<TradeClass> TradeList;

	private Dictionary<DateTime, TradeClass> TradeDictionary;

	private List<TabloClass> YilList;

	private List<TabloClass> AyList;

	private int ToplamGun;

	private int MutsuzGun;

	public static bool FormDisplayed;

	public static DateTime DateStart;

	public static DateTime DateEnd;

	public static formSistemGetiriEgrisi FormHandle;

	private IContainer components;

	private DataGridView gridSistem;

	private Button buttonSave;

	private Button buttonCalculate;

	private DateTimePicker datetimeStart;

	private DateTimePicker datetimeEnd;

	private Button buttonExcel;

	private Label label1;

	private Label label2;

	private Label labelMaxDD;

	private Label labelGetiri;

	private Panel panelChart0;

	private CheckBox checkKayma;

	private TextBox textKayma;

	private Panel panelChart1;

	private RadioButton radio0;

	private RadioButton radio1;

	private RadioButton radio2;

	private DataGridView gridTablo;

	private DataGridViewTextBoxColumn gridColNo;

	private DataGridViewTextBoxColumn gridColField;

	private DataGridViewTextBoxColumn Column7;

	private DataGridViewTextBoxColumn Column8;

	private DataGridViewTextBoxColumn Column9;

	private DataGridViewTextBoxColumn Column3;

	private DataGridViewComboBoxColumn Column1;

	private DataGridViewTextBoxColumn Column2;

	private DataGridViewTextBoxColumn Column4;

	private DataGridViewTextBoxColumn Column5;

	private DataGridViewTextBoxColumn Column6;

	private DataGridView gridOzet;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	private Button buttonExcelTablo;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formSistemGetiriEgrisi()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FormGetiriEgrisi_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FormGetiriEgrisi_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FormGetiriEgrisi_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FormGetiriEgrisi_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonCalculate_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonExcel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonSave_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkKayma_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridOzet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridTablo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart0_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart0_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart0_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart0_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart1_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart1_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart1_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChart1_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radio0_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CopyToExcel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Workbook GetExcelWorkbook(string filenameX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private decimal GetMaxDD(List<decimal> bakiyelistX)
	{
		return (decimal)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Workbook OpenExcelWorkbook(string filenameX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunExcel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowTablo()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonExcelTablo_Click(object sender, EventArgs e)
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
	static formSistemGetiriEgrisi()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		Symbol = "VIP'VIP-X030";
		FormDisplayed = false;
		DateTime dateTime = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
		DateStart = J1VMblxzaHJMdOdoajS.r7iItWL60(ref dateTime, -3, J1VMblxzaHJMdOdoajS.wCt1gxaEqB);
		DateEnd = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
	}
}
