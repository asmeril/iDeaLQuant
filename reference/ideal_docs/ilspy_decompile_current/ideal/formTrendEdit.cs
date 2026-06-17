using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formTrendEdit : Form
{
	public static bool ElementDelete;

	private Rectangle RectMain;

	private Rectangle RectHeader;

	private Rectangle RectClose;

	private bool InsideClose;

	private bool InsideHeader;

	private bool Loaded;

	private Font FontWingdings2;

	private ChartControl ChartControlRef;

	private cxElement Element;

	public static formTrendEdit Referance;

	private IContainer components;

	private ColorDialog colorDialog1;

	private GroupBox groupBox1;

	private Panel panel2;

	private PictureBox pictureStyle2;

	private PictureBox pictureStyle1;

	private PictureBox pictureStyle0;

	private RadioButton radioDash2;

	private RadioButton radioDash1;

	private RadioButton radioDash0;

	private Panel panel1;

	private PictureBox pictureWidth2;

	private PictureBox pictureWidth1;

	private PictureBox pictureWidth0;

	private RadioButton radioWidth2;

	private RadioButton radioWidth1;

	private RadioButton radioWidth0;

	private Label labelTrendColor;

	private Label label7;

	private Label label6;

	private Label label5;

	private GroupBox groupBox2;

	private Label label13;

	private TextBox textOpacity;

	private Label labelFillColor2;

	private Label label12;

	private Label labelFillColor1;

	private Label label9;

	private CheckBox checkFilled;

	private GroupBox groupPrice;

	private CheckBox checkExtend;

	private CheckBox checkSnap;

	private TextBox textValue2;

	private Label label3;

	private DateTimePicker dateTime2;

	private Label label4;

	private TextBox textValue1;

	private Label label2;

	private DateTimePicker dateTime1;

	private Label label1;

	private Button buttonDefaultSave;

	private TextBox textValue3;

	private Label labelDescValue3;

	private DateTimePicker dateTime3;

	private Label labelDescDate3;

	private TextBox textReflectCount;

	private Label labelDescReflectCount;

	private Button buttonDelete;

	private Button buttonClose;

	private GroupBox groupBoxFiboColor;

	private DataGridView gridFiboColorLevel;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn182;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn183;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formTrendEdit(ChartControl xChartControl)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTrendEdit_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formChartTrendEdit_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formChartTrendEdit_Shown(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formChartTrendEdit_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formChartTrendEdit_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formChartTrendEdit_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formChartTrendEdit_MouseLeave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonClose_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonDefaultSave_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonDelete_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkExtend_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkFilled_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkSnap_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dateTime1_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dateTime1_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dateTime2_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dateTime2_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dateTime3_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dateTime3_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelFillColor1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelFillColor2_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelTrendColor_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pictureStyle0_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pictureStyle1_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pictureStyle2_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pictureWidth0_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pictureWidth1_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pictureWidth2_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioDash0_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioDash1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioDash2_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioWidth0_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioWidth1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioWidth2_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textOpacity_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textReflectCount_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textValue1_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textValue2_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textValue3_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PassParameters()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formTrendEdit_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridFiboColorLevel_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridFiboColorLevel_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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
	static formTrendEdit()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
