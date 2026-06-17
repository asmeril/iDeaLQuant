using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;
using nsoftware.IPWorks;

namespace ideal;

public class formVolumesImkb : Form
{
	private class FileRecord
	{
		public string BrokerCode;

		public double BrokerVolume;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FileRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static FileRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private class AllBrokersRecord
	{
		public string BrokerCode;

		public string BrokerName;

		public double BrokerVolume;

		public double BrokerPercent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllBrokersRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllBrokersRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private class HistoricDataRecord
	{
		public DateTime Date;

		public double BrokerVolume;

		public double BrokerPercent;

		public double TotalVolume;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HistoricDataRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static HistoricDataRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public static formVolumesImkb Referance;

	private string FormCaption;

	private WebClient Downloader;

	private Dictionary<string, string> DownloadDictionary;

	private DateTime DateEnd;

	private DateTime DateStart;

	private static FileRecord[] FileImage;

	private List<AllBrokersRecord> AllBrokersDataList;

	private cxDataGrid.SortRecord AllBrokersSortParam;

	private double AllBrokersTotalVolume;

	private List<HistoricDataRecord> HistoricDataList;

	private string HistoricBrokerCode;

	private double HistoricBrokerVolume;

	private double HistoricTotalVolume;

	private double HistoricRatio;

	private DataGridView ActiveGrid;

	private IContainer components;

	private DateTimePicker datetimeEnd;

	private DateTimePicker datetimeStart;

	private DataGridView gridAllBrokers;

	private TextBox textSearch;

	private DataGridView gridHistoric;

	private Timer timerDownload;

	private Button buttonDownload;

	private Http http1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

	private Label label7;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;

	private DataGridViewTextBoxColumn Column2;

	public ContextMenuStrip menu;

	private ToolStripMenuItem menuExcel;

	private ToolStripSeparator toolStripSeparator5;

	private ToolStripMenuItem menuClose;

	private ToolStripMenuItem menuJPG;

	private ToolStripMenuItem menuBMP;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formVolumesImkb()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formImkbVolumes_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formVolumesImkb_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonDownload_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeEnd_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeStart_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridAllBrokers_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridAllBrokers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridAllBrokers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridAllBrokers_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridHistoric_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void http1_OnTransfer(object sender, HttpTransferEventArgs e)
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
	private void menuExcel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuJPG_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSearch_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerDownload_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DownloaderProgressChanged(object sender, DownloadProgressChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DownloaderCompleted(object sender, AsyncCompletedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayHistoric()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowMenu(object sender, Point pointX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReadFile(string dateX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GetGunHacim(string dateX, string kurumX, out double kurumhacimX, out double kurumyuzdeX)
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
	static formVolumesImkb()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
