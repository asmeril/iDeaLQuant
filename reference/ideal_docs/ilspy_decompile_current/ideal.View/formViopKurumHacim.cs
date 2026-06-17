using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;
using nsoftware.IPWorks;

namespace ideal.View;

public class formViopKurumHacim : Form
{
	public class KurumHacimRecord
	{
		public int KurumId;

		public string Broker;

		public double VolumeBuy;

		public double VolumeBuyP;

		public double VolumeSell;

		public double VolumeSellP;

		public double VolumeSum;

		public double VolumeSumP;

		public double VolumeDif;

		public double VolumeDifP;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KurumHacimRecord()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static KurumHacimRecord()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetAllControls_003Ed__25 : IEnumerable<Control>, IEnumerable, IEnumerator<Control>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private Control _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private Control control;

		public Control _003C_003E3__control;

		public formViopKurumHacim _003C_003E4__this;

		private Stack<Control> _003Cstack_003E5__1;

		private Control _003CnextControl_003E5__2;

		private IEnumerator _003C_003Es__3;

		private Control _003CchildControl_003E5__4;

		private Exception _003Cerror_003E5__5;

		Control IEnumerator<Control>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public _003CGetAllControls_003Ed__25(int _003C_003E1__state)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator<Control> IEnumerable<Control>.GetEnumerator()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CGetAllControls_003Ed__25()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private DataGridView ActiveGrid;

	private string FormHeader;

	private string FormCaption;

	private int KurumHacimSortColumn;

	private byte KurumHacimSortDirection;

	private List<KurumHacimRecord> KurumHacimList;

	private Dictionary<string, string> DownloadDictionary;

	private Queue<string> DownloadQueue;

	private WebClient Downloader;

	private double KurumHacimVolumeBuy;

	private double KurumHacimVolumeSell;

	private double KurumHacimVolumeSum;

	private double KurumHacimNetBuy;

	private double KurumHacimNetSell;

	private double KurumHacimNetBuyMost;

	private double KurumHacimNetSellMost;

	private Thread KurumHacimThread;

	private bool RestartKurumHacimThread;

	private bool KurumHacimThreadFinished;

	private string KurumHacimStatus;

	private int commanSys;

	private IContainer components;

	private Panel panelHeader;

	private Label labelMinimizeWindow;

	private Label labelCloseWindow;

	private Label labelHeader;

	private FlowLayoutPanel flowLayoutPanels;

	private Panel panelAlanlarGrid;

	private Button btnControlUnVisible;

	private Button btnControlUnVisible1;

	private GroupBox groupBoxColumnHide;

	private CheckBox chcNetYuzde;

	private CheckBox chcNet;

	private CheckBox chcToplamYuzde;

	private CheckBox chcToplam;

	private CheckBox chcSatisYuzde;

	private CheckBox chcSatis;

	private CheckBox chcAlisYuzde;

	private CheckBox chcAlis;

	private CheckBox chcAraciKurum;

	private CheckBox chcNo;

	private DataGridView gridKurumHacim1;

	private Button btnKurumHacim;

	private TableLayoutPanel tableLayoutOzet;

	private GroupBox groupBox1;

	private DataGridView gridKurumHacim4;

	private MyPie chartKurumHacim1;

	private Timer timerRefresh;

	private Panel panelUserControl;

	private DateTimePicker datetimeKurumHacim2;

	private GroupBox groupBox3;

	private Panel panelHacimViopFiltre;

	private ComboBox comboHacimViopSozlesme;

	private ComboBox comboHacimViopOpsiyonTip;

	private ComboBox comboHacimViopVadeliTip;

	private ComboBox comboHacimViopPiyasa;

	private RadioButton radioIkiTarArasi;

	private DateTimePicker dateTimeKurumHacim1;

	private Button btnGetKurumHacim;

	private TextBox textKurumHacimSymbolSearch;

	private RadioButton radioTarihsel;

	private Panel panelKurumHacimSummary;

	private Timer timerDownload;

	private Http http1;

	public ContextMenuStrip menu;

	private ToolStripMenuItem menuExcel;

	private ToolStripMenuItem menuJPG;

	private ToolStripMenuItem menuBMP;

	private ToolStripSeparator toolStripSeparator5;

	private ToolStripMenuItem menuClose;

	private PictureBox pictureboxTwitter;

	private Label labelTwitter;

	private Label labelPencereGizleGoster;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn97;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn102;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn113;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn114;

	private Label labelDistributionBrokerStatus;

	private DataGridViewTextBoxColumn gridNameNo;

	private DataGridViewTextBoxColumn gridAraciKurum;

	private DataGridViewTextBoxColumn gridAlis;

	private DataGridViewTextBoxColumn gridAlisYuzde;

	private DataGridViewTextBoxColumn gridSatis;

	private DataGridViewTextBoxColumn gridSatisYuzde;

	private DataGridViewTextBoxColumn gridToplam;

	private DataGridViewTextBoxColumn gridToplamYuzde;

	private DataGridViewTextBoxColumn gridNet;

	private DataGridViewTextBoxColumn gridNetYuzde;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formViopKurumHacim()
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
	private void EnableDoubleBufferOnControls()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetAllControls_003Ed__25))]
	private IEnumerable<Control> GetAllControls(Control control)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridColumnControls(string command, CheckBox chc, bool visible)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void resizeWinForm(int commandCount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ViopEskiSenetPazarKontrol(List<string> sembolListx, string pazarX, string AltPazarX, string sembolX)
	{
		return true;
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
	private void ShowMenu(object sender, Point pointX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chcNo_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chcAraciKurum_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chcAlis_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chcAlisYuzde_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chcSatis_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chcSatisYuzde_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chcToplam_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chcToplamYuzde_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chcNet_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void chcNetYuzde_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnControlUnVisible_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnControlUnVisible1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnSutunGizle_Click(object sender, EventArgs e)
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
	private void pictureboxTwitter_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioTarihsel_CheckedChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textKurumHacimSymbolSearch_MouseEnter(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textKurumHacimSymbolSearch_MouseLeave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKurumViopHacim_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnGetKurumHacim_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelKurumHacimSummary_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboHacimViopPiyasa_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerRefresh_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioIkiTarArasi_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelHeader_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelHeader_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelCloseWindow_Leave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ConvertOldToNew(string filenameX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerDownload_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textKurumHacimSymbolSearch_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuExcel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKurumHacim1_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKurumHacim4_MouseDown(object sender, MouseEventArgs e)
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
	private void formViopKurumHacim_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dateTimeKurumHacim1_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void datetimeKurumHacim2_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioTarihsel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void http1_OnEndTransfer(object sender, HttpEndTransferEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void http1_OnError(object sender, HttpErrorEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void http1_OnRedirect(object sender, HttpRedirectEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void http1_OnTransfer(object sender, HttpTransferEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formViopKurumHacim_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pictureboxTwitter_MouseHover(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pictureboxTwitter_MouseLeave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnKurumHacim_MouseHover(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnKurumHacim_MouseLeave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnControlUnVisible1_MouseHover(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnControlUnVisible1_MouseLeave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnControlUnVisible_MouseHover(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnControlUnVisible_MouseLeave(object sender, EventArgs e)
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
	static formViopKurumHacim()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
