using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formViopKurumHacim2 : FormControl
{
	private bool DisplayActiveRowBool;

	private DataGridView ActiveGrid;

	private Dictionary<string, string> DownloadDictionary;

	private Queue<string> DownloadQueue;

	private string DownloadStatus;

	private WebClient Downloader;

	private List<formClearingBank.KurumHacimRecord> KurumHacimList;

	private double KurumHacimNetBuy;

	private double KurumHacimNetBuyMost;

	private double KurumHacimNetSell;

	private double KurumHacimNetSellMost;

	private int KurumHacimSortColumn;

	private byte KurumHacimSortDirection;

	private string KurumHacimStatus;

	private Thread KurumHacimThread;

	private bool KurumHacimThreadFinished;

	private double KurumHacimVolumeBuy;

	private double KurumHacimVolumeSell;

	private double KurumHacimVolumeSum;

	private cxPage.BuySell PageParams;

	private bool RestartKurumHacimThread;

	private int SummaryTabIndex;

	private bool DetailMode;

	private IContainer components;

	private Button buttonIndir;

	private Button buttonYenile;

	private ComboBox comboHacimViopPiyasa;

	private ComboBox comboHacimViopVadeliTip;

	private ComboBox comboHacimViopOpsiyonTip;

	private ComboBox comboHacimViopSozlesme;

	private ContextMenuStrip menu;

	private DateTimePicker dateTimeEnd;

	private DateTimePicker dateTimeStart;

	private DataGridView gridAlan;

	private DataGridView gridKurumHacim;

	private DataGridView gridSatan;

	private DataGridView gridTopHacim;

	private GroupBox groupFiltre;

	private Label labelDetay;

	private Label labelKurumSayisi;

	private Label labelListe;

	private Label labelStatus;

	private Label labelTabTopHacim;

	private Label labelTabAlanlar;

	private Label labelTabSatanlar;

	private NumericUpDown numericKurumSayisi;

	private Panel panelMain;

	private Panel panelOzet;

	private Panel panelSummary;

	private Panel panelTop;

	private MyPie pieAlan;

	private MyPie pieTopHacim;

	private PictureBox pictureboxTwitter;

	private MyPie pieSatan;

	private RadioButton radioIkiTarArasi;

	private RadioButton radioTarihsel;

	private TextBox textAra;

	private Timer timerDownload;

	private Timer timerRefresh;

	private ToolStripMenuItem menuExcel;

	private ToolStripMenuItem menuJPG;

	private ToolStripMenuItem menuBMP;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripMenuItem menuClose;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formViopKurumHacim2(cxPage.BuySell pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formViopKurumHacim2_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formViopKurumHacim2_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formViopKurumHacim2_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formViopKurumHacim2_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formViopKurumHacim2_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formViopKurumHacim2_Shown(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formViopKurumHacim2_SizeChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonYenile_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonIndir_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKurumHacim_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKurumHacim_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKurumHacim_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pictureboxTwitter_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKurumHacim_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuExcel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuJPG_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuBMP_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuClose_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioDateMode_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplyDateMode()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboViopFiltre_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelViewMode_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelTab_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SelectSummaryTab(int tabIndex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelOzet_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridSummary_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textAra_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerDownload_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerRefresh_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowNewForm(cxPage.BuySell pageparamsX, int aktiftabx, string symbolX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] ConvertPageToByteArray()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Downloader_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Downloader_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayKurumHacim()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillKurumHacim()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillAlanSatan(formClearingBank.KurumHacimRecord[] mostbuyers, formClearingBank.KurumHacimRecord[] mostsellers, int mostCount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillTopHacim(List<formClearingBank.KurumHacimRecord> toptenlist, int mostCount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DateTime GetDefaultStartDate()
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResizeForm()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<string> GetViopSymbolFilter()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ViopEskiSenetPazarKontrol(List<string> sembolListx, string pazarX, string AltPazarX, string sembolX)
	{
		return true;
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
	static formViopKurumHacim2()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
