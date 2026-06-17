using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class formTarama : Form
{
	public static List<string> BarUsersList;

	public static formTarama Referans;

	public static string TaramaDir;

	private TaramaClass TaramaItem;

	private List<TaramaDataClass> DataList;

	private List<TaramaDataClass> DisplayList;

	private string SembolFilter;

	private Thread Thread1;

	private volatile string ThreadStatus;

	private bool StopBool;

	private string MouseRightColName;

	private int PeriyodikTime;

	private bool FormLoaded;

	private bool SortAscendingBool;

	private int SortColNo;

	private string BosKriterHeader;

	private IContainer components;

	private ComboBox comboBoxTarama;

	private MyButton myButtonKaydet;

	private MyButton myButtonFarkliKaydet;

	private MyButton myButtonSembolSec;

	private MyButton myButtonMenu;

	private Label labelInfoStatus;

	private Panel panelFiltre;

	private RadioButton radioBoxFiltre01;

	private RadioButton radioBoxFiltre00;

	private CheckBox checkBoxYenile;

	private Label label2;

	private TextBox textRefresh;

	private MyButton myButtonGuncelle;

	private MyButton myButtonDur;

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

	private MyButton myButtonSil;

	private ContextMenuStrip menuGenel;

	private ToolStripMenuItem menuGenelExcel;

	private ToolStripMenuItem menuGenelListeyeKaydet;

	private ToolStripMenuItem menuGenelGrafikDongu;

	private ToolStripMenuItem menuGenelWatchlist;

	private Timer timerRefresh;

	private Timer timerThread;

	private Label label3;

	private TextBox textBoxBarIcinde;

	private MyButton myButtonGosterim;

	private ContextMenuStrip menuSutunSub;

	private ToolStripMenuItem menuSutunIndikator;

	private MyButton myButtonYeni;

	private ToolStripMenuItem menuSutunSil;

	private ToolStripMenuItem menuSutunIsim;

	private ContextMenuStrip menuGosterimSub;

	private ToolStripMenuItem menuGosterimYon;

	private ToolStripMenuItem menuGosterim1;

	private ToolStripMenuItem menuGosterim2;

	private ToolStripMenuItem menuSutunDecimal;

	private Panel panelCanliBar;

	private RadioButton radioBoxCanliBar01;

	private RadioButton radioBoxCanliBar00;

	private TextBox textBoxSembolAra;

	private Label label4;

	private ToolStripSeparator toolStripMenuItem1;

	private ToolStripMenuItem menuGenelDownload;

	private ToolStripMenuItem menuGenelDownload1Dk;

	private MyButton myButtonRobot;

	private Panel panelKriterCol;

	private RadioButton radioButtonKriterCol01;

	private RadioButton radioButtonKriterCol00;

	private NumericUpDown nmrKriterKol;

	private Label label1;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formTarama()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTarama_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTarama_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTarama_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTarama_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBoxTarama_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridData_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridData_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGenelDownload_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGenelDownload1Dk_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGenelExcel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGenelGrafikDongu_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGenelListeyeKaydet_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGenelWatchlist_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuGosterim_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSutunDecimal_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSutunIndikator_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSutunIsim_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuSutunSil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonDur__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonGosterim_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonGuncelle__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonKaydet__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonMenu_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonRobot__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonSembolSec__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonSil__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonYeni__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioBoxCanliBar00_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioBoxFiltre00_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxSembolAra_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxSembolAra_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerThread_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerRefresh_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddIndicator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CalculateData()
	{
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
	private void ResizeWindow()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveTarama()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetTarama()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetYeniTarama()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetUserTaramaBarcount(string periyotX)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowTarama()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nmrKriterKol_ValueChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioButtonKriterCol00_MouseUp(object sender, MouseEventArgs e)
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
	static formTarama()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		BarUsersList = new List<string> { "445566", "_sedat", "_sedatID", "_99" };
		Referans = null;
		TaramaDir = MfFTrg5y0jcZlPpwbv.r7iItWL60(cxDir.Root, "\\Tarama", MfFTrg5y0jcZlPpwbv.VqaBlIV2g);
	}
}
