using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formRiskKontrol : Form
{
	public static formRiskKontrol Reference;

	private int TimerSayac10;

	private int TimerSayac35;

	private string MenuPeriyodTip;

	private Dictionary<string, bool> SymbolDictionary;

	private string GridHisselerSortColumnName;

	private string GridListeSortColumnName;

	private string GridTakasSortColumnName;

	private string GridDusukLotSortColumnName;

	private string GridYuksekHacimSortColumnName;

	private IContainer components;

	private Timer timer1000;

	private ContextMenuStrip menuRisk;

	private ToolStripMenuItem menuRiskOzellikler;

	private ToolStripSeparator toolStripSeparator4;

	private ToolStripMenuItem menuRiskTumAktif;

	private ToolStripMenuItem menuRiskTumPasif;

	private ToolStripSeparator toolStripSeparator6;

	private ToolStripMenuItem menuRiskTumSil;

	private ToolStripMenuItem menuRiskPasifSil;

	private ToolStripMenuItem menuRiskSatirSil;

	private ToolStripSeparator toolStripSeparator7;

	private ToolStripMenuItem menuRiskKapat;

	private TabControl tabControl;

	private TabPage tabPageKurumHisse;

	private Label labelRiskRowNo;

	private MyButton myButtonEkle;

	private MyButton myButtonBaslat;

	private Panel panelListe;

	private DataGridView gridListe;

	private DataGridViewTextBoxColumn Column1;

	private TabPage tabPageTakas;

	private Panel panelTakas;

	private DataGridView gridTakas;

	private Label label2;

	private ComboBox comboBoxTakasKurumlar;

	private Label label1;

	private TextBox textBoxTakasHisseYuzde;

	private TextBox textBoxTakasLimit;

	private Label label4;

	private Panel panelTakasYon;

	private RadioButton radioBoxTakasYon00;

	private RadioButton radioBoxTakasYon01;

	private MyButton myButtonTakasKaydet;

	private CheckBox checkBoxTakasFiltreli;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private TabPage tabPageDusukLot;

	private CheckBox checkBoxDusukLotFiltreli;

	private TextBox textBoxDusukLotLimit;

	private Label label3;

	private TextBox textBoxDusukLotDefa;

	private Label label5;

	private ComboBox comboBoxDusukLotKurumlar;

	private Label label6;

	private Panel panelDusukLot;

	private DataGridView gridDusukLot;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	private MyButton myButtonDusukLotKaydet;

	private MyButton myButtonDusukLotPeriod;

	private TabPage tabPageYuksekHacim;

	private CheckBox checkBoxYuksekHacimFiltreli;

	private TextBox textBoxYuksekHacimLimit;

	private Label label7;

	private ComboBox comboBoxYuksekHacimKurumlar;

	private Label label8;

	private Panel panelYuksekHacim;

	private DataGridView gridYuksekHacim;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

	private MyButton myButtonYuksekHacimPeriod;

	private MyButton myButtonYuksekHacimKaydet;

	private Panel panelHeader;

	private Panel panelSymbol;

	private RadioButton radioSymbol03;

	private RadioButton radioSymbol02;

	private RadioButton radioSymbol00;

	private RadioButton radioSymbol01;

	private CheckBox checkBoxVarant;

	private CheckBox checkBoxHisseler;

	private TabPage tabPageKurumHisseler;

	private ComboBox comboBoxHisselerKurum;

	private Label label9;

	private Panel panelHisseler;

	private DataGridView gridHisseler;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private Panel panel01HacimTip;

	private RadioButton radioBox01HacimTip02;

	private RadioButton radioBox01HacimTip00;

	private RadioButton radioBox01HacimTip01;

	private Label label10;

	private TextBox textBoxHisselerYuzde;

	private Panel panelRiskTip;

	private RadioButton radioBoxRiskTip01;

	private RadioButton radioBoxRiskTip00;

	private MyButton myButtonPeriod;

	private MyButton myButtonHisselerKaydet;

	private CheckBox checkBoxHisselerFiltreli;

	private Label labelSoru;

	private ToolTip toolTipSoru;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formRiskKontrol()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formRiskKontrol_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formRiskKontrol_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formRiskKontrol_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBoxDusukLotFiltreli_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBoxHisseler_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBoxTakasFiltreli_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBoxYuksekHacimFiltreli_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBoxHisselerKurum_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBoxDusukLotKurumlar_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBoxTakasKurumlar_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBoxYuksekHacimKurumlar_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridListe_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridListe_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridListe_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridDusukLot_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridDusukLot_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridTakas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridTakas_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridYuksekHacim_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridYuksekHacim_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRiskOzellikler_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRiskTumAktif_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRiskTumPasif_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRiskTumSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRiskPasifSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRiskSatirSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuRiskKapat_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonBaslat__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonDusukLotKaydet__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonDusukLotPeriod__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonHisselerKaydet__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonYuksekHacimPeriod__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonTakasKaydet__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonYuksekHacimKaydet__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonEkle__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonPeriod__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioBoxTakasYon00_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioBox01HacimTip00_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxDusukLotLimit_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxYuksekHacimLimit_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxDusukLotDefa_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxTakasHisseYuzde_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxTakasLimit_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxHisselerYuzde_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timer100_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillAllGrids()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillGrid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillRow(int rownoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillDusukLotGrid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillDusukLotRow(int rownoX, RiskDusukLotClass item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillHisselerGrid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillHisselerRow(int rownoX, RiskHisselerClass item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillYuksekHacimGrid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillYuksekHacimRow(int rownoX, RiskYuksekHacimClass item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillTakasGrid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillTakasRow(int rownoX, RiskTakasClass item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrepareSymbols()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResizeWindow()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessMenuMessage(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void grid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisseler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelSoru_Click(object sender, EventArgs e)
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
	static formRiskKontrol()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
