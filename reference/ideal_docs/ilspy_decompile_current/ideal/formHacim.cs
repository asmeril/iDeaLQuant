using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formHacim : FormControl
{
	private Dictionary<string, string> endeksMap;

	private HacimClass HacimTumGunItem;

	private KurumAkdClass KurumAkdItem;

	private KurumAkdClass KurumTumItem;

	private HisseAkdClass HisseItem;

	private List<HacimTickRecord> DataList;

	private List<HacimTickRecord> KurumHisseList;

	private List<HacimTickRecord> HisseKurumList;

	private List<cxIslemDagilim> OneCikanList;

	private Thread KurumAkdThread;

	private Thread KurumTumThread;

	private Thread HisseThread;

	private cxButton HeaderButtons;

	private cxPage.BuySell PageParams;

	private string HacimSortColName;

	private bool HacimSortAscendingBool;

	private string PeriodString;

	private string Hour1;

	private string Hour2;

	private int KurumId;

	private int SembolId;

	private bool HacimDisplayActiveRowBool;

	private bool KurumTumDisplayActiveRowBool;

	private string KurumTumSortColName;

	private bool KurumTumSortAscendingBool;

	private bool HisseDisplayActiveRowBool;

	private string HisseSortColName;

	private bool HisseSortAscendingBool;

	private string OneCikanSortColName;

	private bool OneCikanSortAscendingBool;

	private bool InnerTopMostEnabled;

	private bool TopMostEnabled;

	private double Max1;

	private double Min1;

	private double Inc1;

	private double Max2;

	private double Min2;

	private double Inc2;

	private Point MeasuredPoint;

	private bool MeasuredBool;

	private Point ZoomPoint1;

	private Point ZoomPoint2;

	private int ZoomTimeIndex1;

	private int ZoomTimeIndex2;

	private bool ZoomStarted;

	private double NetFilter;

	private double YuzdeFilter;

	private string IndexCodeFilter;

	private string IndexLabelFilter;

	private IContainer components;

	private Panel panelGrid;

	private Timer timerDisplay;

	private TabControl tabControl;

	private TabPage tabPageHacim;

	private Label label2;

	private DataGridView gridToplam5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;

	private TabPage tabPageKurumTum;

	private Label labelNetAlici5;

	private Label labelNetSatici5;

	private Label label3;

	private Label labelBistToplam;

	private Label label6;

	private Label labelNetFark5;

	private Label label4;

	private DataGridView gridAlan5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridView gridSatan5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	private MyButton myButtonDownload;

	private DataGridView gridTum;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

	public ContextMenuStrip menuDate;

	public ToolStripMenuItem menuDateDay;

	private ToolStripSeparator toolStripMenuItem1;

	private ToolStripMenuItem menuDateTime;

	private ToolStripSeparator toolStripSeparator19;

	private ToolStripMenuItem menuDateMinute1;

	private ToolStripMenuItem menuDateMinute5;

	private ToolStripMenuItem menuDateMinute10;

	private Timer timer5000;

	private Label label1;

	private TextBox textKurumBul;

	private Label label5;

	private Label label7;

	private Label labelKurumName;

	private Label labelKurumKz;

	private Label labelKurumNet2;

	private Label labelKurumNet1;

	private DataGridView gridKurumBuy5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private DataGridView gridKurumSell5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

	private Panel panelChartHacim;

	private Label label9;

	private ComboBox comboBoxKurum;

	private DataGridView gridKurumTum;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

	private Panel panelChartKurumTum;

	private Label label10;

	private TextBox textBoxHisseBul;

	private CheckBox checkBoxOzelEmir;

	private TabPage tabPageHisse;

	private Label label11;

	private TextBox textBoxKurumBul;

	private Panel panelChartHisse;

	private DataGridView gridHisse;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

	private Label label12;

	private ComboBox comboBoxHisse;

	private Label labelHisseNetFark5;

	private Label label14;

	private Label labelHisseNetSatici5;

	private Label label16;

	private Label labelHisseNetAlici5;

	private Label label18;

	private DataGridView gridHisseSatan5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

	private DataGridView gridHisseAlan5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;

	private Label labelMaliyet2;

	private Label label21;

	private Label labelSembol2;

	private Label labelKurum2;

	private Label labelKZ2;

	private Label labelNetY2;

	private Label labelNet2;

	private Label label19;

	private Label label20;

	private Label labelMaliyet3;

	private Label label13;

	private Label labelSembol3;

	private Label labelKurum3;

	private Label labelKZ3;

	private Label labelNetY3;

	private Label labelNet3;

	private Label label25;

	private Label label26;

	private TabPage tabPageOneCikan;

	private Label labelNetYuzdeFilter;

	private Label label22;

	private Label labelNetTlFilter;

	private Label label15;

	private DataGridView gridOneCikan;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;

	private ToolTip toolTipSoru;

	private Label labelSoru;

	private Label label8;

	private PictureBox pictureboxTwitter;

	private RadioButton radioButtonTum;

	private RadioButton radioButtonHisse;

	private MyButton myButtonChart1;

	private MyButton myButtonChart2;

	private CheckBox checkBoxTopMost;

	private ContextMenuStrip menuIndexFilter;

	private ToolStripComboBox menuComboIndexFilter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formHacim(cxPage.BuySell pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHacim_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHacim_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHacim_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHacim_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHacim_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHacim_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHacim_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHacim_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHacim_Shown(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBoxOzelEmir_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkBoxTopMost_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBoxKurum_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBoxHisse_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridToplam5_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridToplam5_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridToplam5_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridAlan5_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridAlan5_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridAlan5_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridSatan5_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridSatan5_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridSatan5_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridTum_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridTum_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridTum_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridTum_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKurumBuy5_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKurumBuy5_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKurumBuy5_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKurumSell5_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKurumSell5_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKurumSell5_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKurumTum_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKurumTum_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKurumTum_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKurumTum_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisse_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisse_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisse_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisse_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisseAlan5_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisseAlan5_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisseAlan5_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisseSatan5_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisseSatan5_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHisseSatan5_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridOneCikan_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridOneCikan_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelNetYuzdeFilter_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelNetTlFilter_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelSoru_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuDate_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuComboIndexFilter_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonDownload__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonChart1__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void myButtonChart2__OnClick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChartKurumTum_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChartKurumTum_MouseDoubleClick(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChartKurumTum_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChartKurumTum_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChartKurumTum_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChartHacim_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChartHacim_MouseDoubleClick(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChartHacim_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChartHacim_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChartHacim_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChartHisse_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChartHisse_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChartHisse_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChartHisse_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelChartHisse_MouseDoubleClick(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pictureboxTwitter_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioButtonHisseType_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textKurumBul_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxHisseBul_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textBoxKurumBul_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerDisplay_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timer5000_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MessageReceived(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private double CalculateIncrement(double highval, double lowval, bool pricebool)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string ConvertPeriodToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CalculateData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CalculateAkd()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CalculateKurumTum()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CalculateHisse()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillComboIndex()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillHacim()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillKurumAkd()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillKurumTum()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillKurumTumHeader()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillHisse()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillHisseHeader()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillOneCikan()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillSembolList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResizeForm()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowKurumTab()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowHisseTab()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowNewFrom(cxPage.BuySell pageparamsX, int aktiftabx, string symbolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] ConvertPageToByteArray()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPageParams(cxPage.BuySell pageparamsX)
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
	static formHacim()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
