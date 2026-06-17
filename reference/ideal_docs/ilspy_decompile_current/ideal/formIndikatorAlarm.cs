using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class formIndikatorAlarm : Form
{
	private cxTrendAlarm Alarm;

	private Dictionary<string, enAlarmTip> AlarmTipNames;

	private string NewSymbol;

	private string DurumString;

	private bool TaramaBool;

	public static cxTrendAlarm TaramaAlarm;

	private IContainer components;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private TabPage tabPage2;

	private Panel panel6;

	private MyButton myButtonDeleteSepet;

	private MyButton myButtonSaveSepet;

	private MyButton myButtonDeleteRow;

	private MyButton myButtonAddRow;

	private TextBox textSymbolSearch;

	private CheckBox checkEmirBagla;

	private Panel panelAlSat;

	private RadioButton radioEmirIslem0;

	private RadioButton radioEmirIslem1;

	private DataGridView grid;

	private DataGridViewTextBoxColumn Column9;

	private DataGridViewTextBoxColumn Piyasa;

	private DataGridViewTextBoxColumn Column12;

	private Label label8;

	private Label label4;

	private ComboBox comboEndeks;

	private Panel panel3;

	private MyButton myButtonPeriyot;

	private MyButton myButtonSembol;

	private Panel panelKirmaTipi;

	private RadioButton radioKirmaTipi0;

	private Label label2;

	private RadioButton radioKirmaTipi1;

	private CheckBox checkAktif;

	private CheckBox checkSes;

	private Label label5;

	private CheckBox checkCepPush;

	private CheckBox checkSms;

	private Label label3;

	private Panel panelInfo;

	private MyButton myButtonKaydet;

	private Label label7;

	private Label label6;

	private ListBox listBoxIndikator;

	private TextBox textBoxParam1;

	private Label labelParam1;

	private TextBox textBoxParam3;

	private Label labelParam3;

	private TextBox textBoxParam2;

	private Label labelParam2;

	private TextBox textBoxParam4;

	private Label labelParam4;

	private ComboBox comboMA;

	private Label labelMA;

	private Panel panelAksiyon;

	private RadioButton radioButtonAksiyon0;

	private RadioButton radioButtonAksiyon1;

	private Label label1;

	private Panel panelKiyasla;

	private Label label9;

	private RadioButton radioKiyasla0;

	private RadioButton radioKiyasla2;

	private RadioButton radioKiyasla1;

	private TextBox textBoxKiyaslaMaPeriyot;

	private ComboBox comboKiyaslaMA;

	private TextBox textBoxKiyaslaOnceki;

	private TextBox textBoxKiyaslaSeviye;

	private Label label10;

	private Panel panelParam;

	private Label label14;

	private Label labelDurum;

	private Timer timer1000;

	private ComboBox comboBoxAltHesaplar;

	private Label label15;

	private ComboBox comboBoxHesaplar;

	private Label label16;

	private Label label17;

	private Label label18;

	private CheckBox checkBoxAcigaSatis;

	private MyButton myButtonTaramaKaydet;

	private ComboBox comboTaramaPeriod;

	private Label labelTaramaPeriyot;

	private CheckBox checkBoxKesisme;

	private TextBox textBoxNameFilter;

	private Label label19;

	private TextBox textBoxNameSearch;

	private Label label20;

	private Panel panelDataTip;

	private RadioButton radioDataTip06;

	private RadioButton radioDataTip05;

	private RadioButton radioDataTip04;

	private RadioButton radioDataTip03;

	private RadioButton radioDataTip02;

	private RadioButton radioDataTip01;

	private RadioButton radioDataTip00;

	private TextBox textBoxKiyaslaFiyatMaPeriyot;

	private ComboBox comboKiyaslaFiyatMA;

	private RadioButton radioKiyasla4;

	private RadioButton radioKiyasla3;

	private Label labelListe1;

	private TextBox textBoxListe1;

	private ComboBox comboBoxListe;

	private RadioButton radioKiyasla5;

	private Label labelListe2;

	private TextBox textBoxListe2;

	private TextBox textBoxArdisikDusen;

	private RadioButton radioKiyasla7;

	private TextBox textBoxArdisikYukselen;

	private RadioButton radioKiyasla6;

	private Panel panelEgzotik;

	private Panel panelSure;

	private Label label21;

	private TextBox textBoxSureDakika;

	private Label label22;

	private RadioButton radioBoxSure02;

	private Label label23;

	private TextBox textBoxSureSaniye;

	private Label label24;

	private RadioButton radioBoxSure01;

	private RadioButton radioBoxSure00;

	private Label label25;

	private Label label26;

	private TextBox textBoxKurumSayisi;

	private Panel panelLotTl;

	private RadioButton radioBoxLotTl01;

	private RadioButton radioBoxLotTl00;

	private Label label27;

	private Panel panelVeriTip;

	private RadioButton radioBoxVeriTip12;

	private RadioButton radioBoxVeriTip11;

	private RadioButton radioBoxVeriTip10;

	private RadioButton radioBoxVeriTip08;

	private RadioButton radioBoxVeriTip09;

	private RadioButton radioBoxVeriTip07;

	private RadioButton radioBoxVeriTip06;

	private RadioButton radioBoxVeriTip05;

	private RadioButton radioBoxVeriTip04;

	private RadioButton radioBoxVeriTip03;

	private RadioButton radioBoxVeriTip02;

	private RadioButton radioBoxVeriTip01;

	private RadioButton radioBoxVeriTip00;

	private Label label28;

	private TextBox textBoxLevel;

	private RadioButton radioButtonAksiyon2;

	private TextBox textBoxYakininda;

	private Label label29;

	private Panel panelSistem;

	private Label labelFlat;

	private Label labelAlis;

	private TextBox textBoxSistemCizgi2;

	private Label labelCizgi2;

	private TextBox textBoxSistemCizgi1;

	private Label labelCizgi1;

	private ComboBox comboSistem;

	private Label label11;

	private Panel panelOtoTrend;

	private Label label12;

	private TextBox textBoxOtoTrendBar2;

	private Label label13;

	private TextBox textBoxOtoTrendBar1;

	private Label label30;

	private TextBox textBoxSistemBarSayisi;

	private Label label31;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formIndikatorAlarm(cxTrendAlarm alarmX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTrendAlarmParam_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTrendAlarmParam_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboEndeks_SelectedValueChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBoxHesaplar_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void listBoxIndikator_SelectedValueChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonKaydet_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonAddRow__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonDeleteRow__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonSaveSepet__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonDeleteSepet__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonTaramaKaydet__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioButtonAksiyon0_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxNameFilter_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxNameSearch_TextChanged(object sender, EventArgs e)
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
	private void timer1000_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillGrid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowDurum()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetIndikatorParameters()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTarama()
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
	static formIndikatorAlarm()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		TaramaAlarm = new cxTrendAlarm();
	}
}
