using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formHesap : FormControl
{
	public string AccountName;

	public string AccountNo;

	public string Piyasa;

	public string Tab;

	private cxPage.BuySell PageParams;

	private cxPortfolio.AccountRecord Account;

	private List<cxPortfolio.ImkbOrderRecord> ImkbOrderList;

	private List<cxPortfolio.VipOrderRecord> VipOrderList;

	private List<cxPortfolio.ImkbPositionRecord> ImkbPositionList;

	private List<cxPortfolio.VipPositionRecord> VipPositionList;

	private List<cxPortfolio.ProfitRecord> ImkbMaliyetList;

	private List<cxPortfolio.ProfitRecord> VipMaliyetList;

	private cxPortfolio.ImkbOrderRecord ImkbOrder;

	private cxPortfolio.VipOrderRecord VipOrder;

	private List<int> HesapColWidthPozisyonBIST;

	private List<int> HesapColWidthBekleyenBIST;

	private List<int> HesapColWidthGerceklesenBIST;

	private List<int> HesapColWidthMaliyetBIST;

	private List<int> HesapColWidthHesapBIST;

	private List<int> HesapColWidthPozisyonVIOP;

	private List<int> HesapColWidthBekleyenVIOP;

	private List<int> HesapColWidthGerceklesenVIOP;

	private List<int> HesapColWidthMaliyetVIOP;

	private List<int> HesapColWidthHesapVIOP;

	private Font HesapFont;

	private cxButton HeaderButtons;

	public cxButton Buttons;

	private IContainer components;

	private Panel panelMain;

	private ComboBox comboAccountNo;

	private ComboBox comboAccountName;

	private DataGridView gridMain;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;

	private Panel panelLogin;

	private TextBox textParola;

	private Label label12;

	private Button buttonChangePassword;

	private TextBox textNewPassword2;

	private Label label10;

	private TextBox textNewPassword1;

	private Label label9;

	private TextBox textOldPassword;

	private Label label8;

	private Button buttonPasswordWindow;

	private Label labelLoginParola;

	private TextBox textLoginParola;

	private Button buttonAccountLogin;

	private TextBox textLoginPassword;

	private Label labelLoginPassword;

	private Timer timerRefresh;

	private Timer timerDisplay;

	public ContextMenuStrip menuVipOrder;

	public ToolStripMenuItem menuVipOrderSubCancel;

	private ToolStripSeparator toolStripSeparator11;

	public ToolStripMenuItem menuVipOrderSubEditOrder;

	public ContextMenuStrip menuImkbOrder;

	public ToolStripMenuItem menuImkbOrderCancel;

	private ToolStripSeparator toolStripSeparator3;

	public ToolStripMenuItem menuImkbOrderEditOrder;

	public ToolStripMenuItem menuImkbOrderActive;

	public ToolStripMenuItem menuImkbOrderChangeSession;

	private Timer timerEventRefresh;

	private ContextMenuStrip menuMain;

	private ToolStripMenuItem menuMainFont;

	private ToolStripMenuItem menuMainSave;

	private ToolStripMenuItem menuMainDefault;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formHesap(cxPage.BuySell pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHesap_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHesap_Activated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHesap_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHesap_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHesap_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHesap_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formHesap_Resize(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonAccountLogin_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonChangePassword_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonPasswordWindow_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboAccountName_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboAccountName_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboAccountNo_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboAccountNo_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridMain_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridMain_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridMain_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridMain_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuImkbOrderActive_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuImkbOrderCancel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuImkbOrderChangeSession_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuImkbOrderEditOrder_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainDefault_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainFont_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuMainSave_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuVipOrderSubCancel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuVipOrderSubEditOrder_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelLogin_Leave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelMain_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void panelMain_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textLoginParola_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textLoginPassword_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerDisplay_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerEventRefresh_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerRefresh_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CalculateImkbMaliyet()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CalculateVipMaliyet()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EventKEP(string messageX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetGridColumnWidth()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Login()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrepareTables()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RequestData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetAccount()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetGridParams()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetLoginColors()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPageParams(cxPage.BuySell pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] ConvertPageToByteArray()
	{
		return null;
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
	static formHesap()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
