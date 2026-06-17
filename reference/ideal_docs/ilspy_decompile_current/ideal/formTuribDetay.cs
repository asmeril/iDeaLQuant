using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formTuribDetay : Form
{
	[CompilerGenerated]
	private sealed class _003CbtnAra_Click_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		public EventArgs e;

		public formTuribDetay _003C_003E4__this;

		private Exception _003Cerror_003E5__1;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CbtnAra_Click_003Ed__10()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CbtnAra_Click_003Ed__10()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CformTuribDetay_Load_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		public EventArgs e;

		public formTuribDetay _003C_003E4__this;

		private bool _003C_003Es__1;

		private TaskAwaiter<bool> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CformTuribDetay_Load_003Ed__8()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CformTuribDetay_Load_003Ed__8()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private int InitialLeft;

	private int InitialTop;

	private bool _lock;

	private static formTuribDetay reference;

	private cxDataGrid.SortRecord SortParamGridTurib;

	private Point dragStartPoint;

	private int DragRowIndex;

	private IContainer components;

	private Panel panelArama;

	private Panel panelGrid;

	private DataGridView gridTurib;

	private BindingSource cxTuribBindingSource;

	private Label label6;

	private TextBox textboxSearch;

	private Button btnAra;

	private Label label1;

	private TextBox textboxIsin;

	private ComboBox comboBoxAnaUrunGrubu;

	private Label label2;

	private BindingSource cxTuribMarketSegmentBindingSource;

	private ComboBox comboBoxUrun;

	private BindingSource cxTuribUrunBindingSource;

	private Label label3;

	private ComboBox comboBoxUrunTipi;

	private Label label4;

	private BindingSource cxTuribUrunTipiBindingSource;

	private ComboBox comboBoxUrunGrubu;

	private Label label5;

	private BindingSource cxTuribUrunGrubuBindingSource;

	private ComboBox comboBoxUrunSinifi;

	private Label label7;

	private BindingSource cxTuribUrunSinifiBindingSource;

	private ComboBox comboBoxStatus;

	private Label label8;

	private BindingSource cxTuribStatusBindingSource;

	private Label lblToplam;

	private ComboBox comboBoxDepo;

	private ComboBox comboBoxIlce;

	private ComboBox comboBoxIl;

	private Label label11;

	private Label label10;

	private Label label9;

	private BindingSource cxTuribIlBindingSource;

	private BindingSource cxTuribIlceBindingSource;

	private BindingSource cxTuribDepoBindingSource;

	private ContextMenuStrip contextMenuTurib;

	private ToolStripMenuItem detayMenuItem;

	private ToolStripMenuItem derinlikMenuItem;

	private ToolStripMenuItem kademeAnliziMenuItem;

	private DataGridViewTextBoxColumn securityIDDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn securityAltIDDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn cFICodeDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn symbolDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn securityDescDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn SecurityStatusText;

	private DataGridViewTextBoxColumn productGradeNameDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn senderCompIDDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn securityIDSourceDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn transactTimeDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn settlementTypeDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn settlDateDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn minQtyDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn prevClosePxDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn securityTypeDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn maturityMonthYearDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn factorDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn contractMultiplierDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn minTradeVolDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn securityStatusDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn unitOfMeasureDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn marketSegmentNameDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn productGroupNameDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn productSubGroupNameDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn marketSubSegmentNameDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn maxTradeVolDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn lowLimitPriceDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn highLimitPriceDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn tradingReferencePriceDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn minLotSizeDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn shortSaleRestrictionDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn tradingMethodDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn basePriceDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn firstTradingDateDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn lastTradingDateDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn harvestYearDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn storeTypeDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn StoreTypeText;

	private DataGridViewTextBoxColumn maxLotSizeDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn tCReportAllowedDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn securityTypeNameDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn securityClassIDDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn securityClassNameDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn settlementDayDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn todayFreeMarginDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn priceDecimalDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn valueStepDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn orderAttributeCodeDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn prevVWapDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn securitySubTypeIDDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn securitySubTypeNameDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn securityAltIDSourceDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn underlyingSymbolDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn underlyingSecurityDescDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn marketIDDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn marketNameDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn marketSegmentIDDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn marketSubSegmentIDDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn startTickPriceRangeDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn endTickPriceRangeDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn tickIncrementDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn countryIDDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn productClassNameDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn productOriginNameDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn countryNameDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn regionIDDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn regionNameDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn districtIDDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn districtNameDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn townIDDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn townNameDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn productGroupIDDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn productSubGroupIDDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn productGradeIDDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn productClassIDDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn productOriginIDDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn branchCodeDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn branchNameDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn warehouseCodeDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn ınstrRegistryDataGridViewTextBoxColumn;

	private ToolStripMenuItem grafikMenuItem;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formTuribDetay(int leftX, int topX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CformTuribDetay_Load_003Ed__8))]
	[DebuggerStepThrough]
	private void formTuribDetay_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<bool> InitialData()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CbtnAra_Click_003Ed__10))]
	[DebuggerStepThrough]
	private void btnAra_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ListDisplayEdit(List<cxTurib> list)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string getDisplayDate(string date)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBoxAnaUrunGrubu_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBoxUrun_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBoxUrunTipi_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBoxUrunGrubu_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBoxIl_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBoxIlce_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridTurib_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridTurib_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridTurib_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textboxSearch_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTuribDetay_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void detayMenuItem_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void derinlikMenuItem_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void grafikMenuItem_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void kademeAnliziMenuItem_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string getSymbolFromGrid()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetComboBoxIndex(ComboBox comboBox, int index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowForm()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridTurib_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridTurib_MouseMove(object sender, MouseEventArgs e)
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
	static formTuribDetay()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
