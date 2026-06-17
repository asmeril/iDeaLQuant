using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formSepetGetiri : Form
{
	private class LineClass
	{
		public string SistemName;

		public bool Selected;

		public float Getiri;

		public float Bugun;

		public float Hafta;

		public float Ay1;

		public float Ay3;

		public float Ay6;

		public float MaxDD;

		public float IslemSayisi;

		public float OrtalamaIslem;

		public float OrtalamaPuan;

		public List<float> KZ;

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

	public static formSepetGetiri Referans;

	private SepetGetiriRecord SepetItem;

	private List<LineClass> LineList;

	private LineClass Avr;

	private string Bazperiod;

	private string BazSembol;

	private List<cxBar> BazData;

	private static bool FormActiveBool;

	private float MaxDD;

	private int MaxDdX1;

	private int MaxDdX2;

	private float MaxDdY1;

	private float MaxDdY2;

	private Color ChartBackColor;

	private Color GridGunColor;

	private Color GridAyColor;

	private Color PriceScaleColor;

	private Color Kz1Color;

	private float MaxVal2;

	private float MinVal2;

	private float BarWidth;

	private int CurrentBarNo;

	private int LastBarNo;

	private int FirstBarNo;

	private int BarCount;

	private float RightMargin;

	private IContainer components;

	private Panel panelHeader;

	private Label labelMinimizeWindow;

	private Label labelCloseWindow;

	private Label label4;

	private Label label1;

	private TabControl tab;

	private TabPage tabRobot;

	private MyButton mybtnSatirEkle;

	private DataGridView gridSembol;

	private DataGridViewTextBoxColumn ColTradeNo;

	private DataGridViewTextBoxColumn ColTradeDirection;

	private DataGridViewTextBoxColumn ColTradeLot;

	private DataGridViewTextBoxColumn ColTradeBuyDate;

	private DataGridViewTextBoxColumn ColTradeBuyPrice;

	private DataGridViewTextBoxColumn ColTradeSellDate;

	private DataGridViewTextBoxColumn ColTradeSellPrice;

	private DataGridViewTextBoxColumn ColTradeProfit;

	private DataGridViewTextBoxColumn ColTradeSellCash;

	private TabPage tabGetiri;

	private Label label2;

	private Label label19;

	private ComboBox comboSepet;

	private MyButton myButtonSil;

	private MyButton myButtonFarkliKaydet;

	private MyButton myButtonKaydet;

	private TextBox textSymbolSearch;

	private Label label3;

	private Label label5;

	private ComboBox comboPeriod;

	private Label label6;

	private ComboBox comboSistemName;

	private MyButton myButtonSatirSil;

	private DataGridView gridGetiri;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;

	private MyButton myButtonSecimKaldir;

	private MyButton myButtonTumunuSec;

	private MyButton myButtonKopyala;

	private MyButton myButtonHesapla;

	private CheckBox checkBoxBirlesikEgriGorunsun;

	private MyButton myButtonTumVeri;

	private Label label9;

	private Label label8;

	private Label label7;

	private Label labelBazPeriod;

	private Label labelBazSembol;

	private Panel pnlValKz;

	private Panel pnlKz;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formSepetGetiri()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSepetGetiri_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSepetGetiri_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSepetGetiri_Deactivate(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSepetGetiri_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSepetGetiri_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSepetGetiri_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSepetGetiri_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSepetGetiri_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSepetGetiri_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBoxBirlesikEgriGorunsun_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboSepet_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridSembol_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridSembol_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridGetiri_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridGetiri_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelCloseWindow_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelMinimizeWindow_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonHesapla__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonKopyala__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mybtnSatirEkle__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonSatirSil__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonKaydet__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonFarkliKaydet__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonSil__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonTumunuSec__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonSecimKaldir__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelHeader_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonTumVeri__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelHeader_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pnlKz_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pnlKz_MouseWheel(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pnlKz_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pnlValKz_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tab_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbolSearch_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbolSearch_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSymbolSearch_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float CalculateIncrement(float highval, float lowval)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CalculateMinMax2()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillSembol()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillGrid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillGridRow(int rowno)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillGridAvr()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float GetHorizontalPos(int barNo)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResizeWindow()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetLastBarNo(int lastbarno)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowWindow()
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
	static formSepetGetiri()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
