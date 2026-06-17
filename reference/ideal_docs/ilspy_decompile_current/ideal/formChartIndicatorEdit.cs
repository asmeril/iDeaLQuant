using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class formChartIndicatorEdit : Form
{
	public static formChartIndicatorEdit ChartIndicatorEdit;

	private ChartControl Sender;

	private cxIndicator Indicator;

	private bool FormLoaded;

	private dynamic SenderForm;

	private IContainer components;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private TabPage tabPage2;

	private GroupBox groupBox1;

	private CheckBox checkLine0;

	private Panel panel2;

	private PictureBox pictureLineStyle02;

	private PictureBox pictureLineStyle01;

	private PictureBox pictureLineStyle00;

	private RadioButton radioLineDash02;

	private RadioButton radioLineDash01;

	private RadioButton radioLineDash00;

	private Panel panel1;

	private PictureBox pictureLineWidth02;

	private PictureBox pictureLineWidth01;

	private PictureBox pictureLineWidth00;

	private RadioButton radioLineWidth02;

	private RadioButton radioLineWidth01;

	private RadioButton radioLineWidth00;

	private Label labelLineColor0;

	private Label label7;

	private Label label6;

	private Label label5;

	private GroupBox groupBox5;

	private Panel panel9;

	private PictureBox pictureLineStyle42;

	private PictureBox pictureLineStyle41;

	private PictureBox pictureLineStyle40;

	private RadioButton radioLineDash42;

	private RadioButton radioLineDash41;

	private RadioButton radioLineDash40;

	private Panel panel10;

	private PictureBox pictureLineWidth42;

	private PictureBox pictureLineWidth41;

	private PictureBox pictureLineWidth40;

	private RadioButton radioLineWidth42;

	private RadioButton radioLineWidth41;

	private RadioButton radioLineWidth40;

	private Label labelLineColor4;

	private Label label17;

	private Label label18;

	private Label label19;

	private CheckBox checkLine4;

	private GroupBox groupBox4;

	private Panel panel7;

	private PictureBox pictureLineStyle32;

	private PictureBox pictureLineStyle31;

	private PictureBox pictureLineStyle30;

	private RadioButton radioLineDash32;

	private RadioButton radioLineDash31;

	private RadioButton radioLineDash30;

	private Panel panel8;

	private PictureBox pictureLineWidth32;

	private PictureBox pictureLineWidth31;

	private PictureBox pictureLineWidth30;

	private RadioButton radioLineWidth32;

	private RadioButton radioLineWidth31;

	private RadioButton radioLineWidth30;

	private Label labelLineColor3;

	private Label label13;

	private Label label14;

	private Label label15;

	private CheckBox checkLine3;

	private GroupBox groupBox3;

	private Panel panel5;

	private PictureBox pictureLineStyle22;

	private PictureBox pictureLineStyle21;

	private PictureBox pictureLineStyle20;

	private RadioButton radioLineDash22;

	private RadioButton radioLineDash21;

	private RadioButton radioLineDash20;

	private Panel panel6;

	private PictureBox pictureLineWidth22;

	private PictureBox pictureLineWidth21;

	private PictureBox pictureLineWidth20;

	private RadioButton radioLineWidth22;

	private RadioButton radioLineWidth21;

	private RadioButton radioLineWidth20;

	private Label labelLineColor2;

	private Label label9;

	private Label label10;

	private Label label11;

	private CheckBox checkLine2;

	private GroupBox groupBox2;

	private Panel panel3;

	private PictureBox pictureLineStyle12;

	private PictureBox pictureLineStyle11;

	private PictureBox pictureLineStyle10;

	private RadioButton radioLineDash12;

	private RadioButton radioLineDash11;

	private RadioButton radioLineDash10;

	private Panel panel4;

	private PictureBox pictureLineWidth12;

	private PictureBox pictureLineWidth11;

	private PictureBox pictureLineWidth10;

	private RadioButton radioLineWidth12;

	private RadioButton radioLineWidth11;

	private RadioButton radioLineWidth10;

	private Label labelLineColor1;

	private Label label2;

	private Label label3;

	private Label label4;

	private CheckBox checkLine1;

	private TextBox textLineValue0;

	private Label label1;

	private TextBox textLineValue4;

	private Label label21;

	private TextBox textLineValue3;

	private Label label20;

	private TextBox textLineValue2;

	private Label label16;

	private Label label8;

	private TextBox textLineValue1;

	private Label label12;

	private ColorDialog colorDialog1;

	private Button buttonClose;

	private Button buttonDelete;

	private Button buttonDefaultSave;

	private GroupBox groupBox6;

	private Panel panel11;

	private PictureBox pictureStyle2;

	private PictureBox pictureStyle1;

	private PictureBox pictureStyle0;

	private RadioButton radioDash2;

	private RadioButton radioDash1;

	private RadioButton radioDash0;

	private Panel panel12;

	private PictureBox pictureWidth2;

	private PictureBox pictureWidth1;

	private PictureBox pictureWidth0;

	private RadioButton radioWidth2;

	private RadioButton radioWidth1;

	private RadioButton radioWidth0;

	private Label labelIndicatorColor;

	private Label label22;

	private Label label23;

	private Label label24;

	private GroupBox groupBox7;

	private Label label25;

	private TextBox textOpacity;

	private Label labelFillColor2;

	private Label label26;

	private Label labelFillColor1;

	private Label label27;

	private CheckBox checkFilled;

	private TextBox textValue03;

	private Label labelName03;

	private TextBox textValue02;

	private Label labelName02;

	private TextBox textValue01;

	private Label labelName01;

	private GroupBox groupInputType;

	private RadioButton radioInputType4;

	private RadioButton radioInputType3;

	private RadioButton radioInputType2;

	private RadioButton radioInputType1;

	private RadioButton radioInputType0;

	private CheckBox checkAvr;

	private Label labelAvrColor;

	private Label labelNameAvrColor;

	private Label labelNameAvrPeriod;

	private TextBox textAvr;

	private ComboBox comboAvrMethods;

	private CheckBox checkDoubleColor;

	private Label labelNameAvr;

	private CheckBox checkDisplay;

	private PictureBox pictureStyle4;

	private RadioButton radioDash4;

	private PictureBox pictureStyle3;

	private RadioButton radioDash3;

	private TextBox textValue04;

	private Label labelName04;

	private RadioButton radioInputType5;

	private RadioButton radioInputType6;

	private ComboBox comboBroker;

	public TextBox textVolumeSymbol;

	private TextBox textAvr3;

	private Label labelNameAvr3;

	private Label labelAvrColor3;

	private TextBox textAvr2;

	private Label labelNameAvr2;

	private Label labelAvrColor2;

	private ComboBox comboAvrMethods3;

	private ComboBox comboAvrMethods2;

	private Panel panelIchiMoku;

	private Label labelIchimoku2;

	private Label label33;

	private Label labelIchimoku1;

	private Label label31;

	private Label labelIchimoku0;

	private Label label29;

	private Label labelIchimoku4;

	private Label label37;

	private Label labelIchimoku3;

	private Label label35;

	private Label label38;

	private TextBox textIchimokuOpacity;

	private Label labelIchimokuFill2;

	private Label label40;

	private Label labelIchimokuFill1;

	private Label label42;

	private Label labelIchimokuHeader;

	private Label label30;

	private TextBox textIchimokuPeriod1;

	private Label label32;

	private TextBox textIchimokuPeriod0;

	private Label label28;

	private TextBox textIchimokuPeriod2;

	private Label label34;

	private TextBox textIchimokuPeriod4;

	private Label label39;

	private TextBox textIchimokuPeriod3;

	private Label label36;

	private ComboBox comboStaticPeriod;

	private Label labelStaticPeriod;

	private Button buttonFont;

	private ComboBox comboStaticPeriod2;

	private Label labelStaticPeriod2;

	private ComboBox comboStaticPeriod1;

	private Label labelStaticPeriod1;

	private Panel panelMMA;

	private DataGridView gridLine;

	private ContextMenuStrip menuLineStil;

	private ToolStripMenuItem menuLineStilDuz;

	private ToolStripMenuItem menuLineStilNokta;

	private ToolStripMenuItem menuLineStilKesik;

	private ToolStripMenuItem menuLineStilKesikNokta;

	private ToolStripMenuItem menuLineStilNoktaNokta;

	private ContextMenuStrip menuVeri;

	private ToolStripMenuItem menuVeriClose;

	private ToolStripMenuItem menuVeriOpen;

	private ToolStripMenuItem menuVeriHigh;

	private ToolStripMenuItem menuVeriLow;

	private ToolStripMenuItem menuVeriAverage;

	private ToolStripMenuItem menuVeriMid;

	private ToolStripMenuItem menuVeriTypical;

	private DataGridViewTextBoxColumn ColLineNo;

	private DataGridViewTextBoxColumn ColLineName;

	private DataGridViewTextBoxColumn ColLineYontem;

	private DataGridViewTextBoxColumn ColLineVeri;

	private DataGridViewTextBoxColumn ColLineColor;

	private DataGridViewTextBoxColumn ColLineKalinlik;

	private DataGridViewTextBoxColumn ColLineStil;

	private ContextMenuStrip menuYontem;

	private ToolStripMenuItem menuYontemSimple;

	private ToolStripMenuItem menuYontemExponential;

	private ToolStripMenuItem menuYontemWeighted;

	private ToolStripMenuItem menuYontemWilder;

	private ToolStripMenuItem menuYontemTimeSeries;

	private ToolStripMenuItem menuYontemTriangular;

	private ToolStripMenuItem menuYontemVariable;

	private ToolStripMenuItem menuYontemVolumeAdjusted;

	private Panel panelKurum;

	private DataGridView gridKurum;

	private ToolStripMenuItem menuBirimListeNetLot;

	private ToolStripMenuItem menuBirimListeMaliyet;

	private ToolStripMenuItem menuBirimListeKZ;

	private ToolStripMenuItem menuBirimListeToplamLot;

	private ToolStripMenuItem menuBirimListeToplamTL;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripMenuItem menuBirimAlanNetLot;

	private ToolStripMenuItem menuBirimAlanMaliyet;

	private ToolStripMenuItem menuBirimAlanKZ;

	private ToolStripMenuItem menuBirimAlanToplamLot;

	private ToolStripMenuItem menuBirimAlanToplamTL;

	private ToolStripSeparator toolStripMenuItem1;

	private ToolStripMenuItem menuBirimSatanNetLot;

	private ToolStripMenuItem menuBirimSatanMaliyet;

	private ToolStripMenuItem menuBirimSatanKZ;

	private ToolStripMenuItem menuBirimSatanToplamLot;

	private ToolStripMenuItem menuBirimSatanToplamTL;

	private ToolStripSeparator toolStripSeparator2;

	private ToolStripMenuItem menuBirimKarEdenKZ;

	private ToolStripMenuItem menuBirimZararEdenKZ;

	public ContextMenuStrip menuBirim;

	private Label label43;

	private Label label41;

	private Button buttonBirimAnalizTip;

	private Button buttonBirimSeviye;

	public ContextMenuStrip menuBirimSeviye;

	private ToolStripMenuItem menuBirimSeviye1;

	private ToolStripMenuItem menuBirimSeviye2;

	private ToolStripMenuItem menuBirimSeviye3;

	private ToolStripMenuItem menuBirimSeviye4;

	private ToolStripMenuItem menuBirimSeviye5;

	private DataGridViewTextBoxColumn ColKurumName;

	private DataGridViewTextBoxColumn ColKurumRenk;

	private DataGridViewTextBoxColumn ColKurumKalinlik;

	private DataGridViewTextBoxColumn ColKurumStil;

	private ToolStripMenuItem menuYontemHullMA;

	private ToolStripMenuItem menuYontemZeroLag;

	private Panel panelTakas;

	private TextBox textTakasGunFilter;

	private Label label44;

	private DataGridView gridTakas;

	private DataGridViewTextBoxColumn ColTakasNo;

	private DataGridViewTextBoxColumn ColTakasRenk;

	private DataGridViewTextBoxColumn ColTakasKalinlik;

	private Panel panelTakasGunDisplay;

	private RadioButton radioBoxTakasGunDisplay01;

	private RadioButton radioBoxTakasGunDisplay00;

	private Label label45;

	private TextBox textTakasDegisimFilter;

	private Label label46;

	private TextBox textTakasDegisimGunSayisi;

	private Label label47;

	private Label label48;

	private Panel panelTakasDegisimDisplay;

	private RadioButton radioBoxTakasDegisimDisplay01;

	private RadioButton radioBoxTakasDegisimDisplay00;

	private Panel panelPivot;

	private DataGridView gridPivot;

	private DataGridViewTextBoxColumn ColLinenAMEPivot;

	private DataGridViewCheckBoxColumn ColStatusPivot;

	private DataGridViewTextBoxColumn ColLineColorPivot;

	private DataGridViewTextBoxColumn ColLineKalinlikPivot;

	private DataGridViewTextBoxColumn ColLineStilPivot;

	private ComboBox comboPivotStaticPeriod;

	private Label labelPivotStaticPeriod;

	private CheckBox checkSadeceSonDeger;

	private Label labelIndicatorColor2;

	private Label labelIndicatorColorDesc2;

	private Label labelIndicatorColor1;

	private Label labelIndicatorColorDesc1;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formChartIndicatorEdit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formChartIndicatorEdit_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formChartIndicatorEdit_KeyDown(object sender, KeyEventArgs e)
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
	private void checkAvr_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkDisplay_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkDoubleColor_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkFilled_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkLine0_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboAvrMethods_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboAvrMethods2_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboAvrMethods3_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBroker_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboStaticPeriod_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboStaticPeriod1_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboStaticPeriod2_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboPivotStaticPeriod_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelAvrColor_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelAvrColor2_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelAvrColor3_Click(object sender, EventArgs e)
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
	private void labelIndicatorColor_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelLineColor0_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelIndicatorColor1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelIndicatorColor2_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pictureLineStyle00_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pictureLineStyle01_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pictureLineStyle02_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pictureLineWidth00_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pictureLineWidth01_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pictureLineWidth02_Paint(object sender, PaintEventArgs e)
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
	private void pictureStyle3_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pictureStyle4_Paint(object sender, PaintEventArgs e)
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
	private void radioLineDash00_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioLineWidth00_Click(object sender, EventArgs e)
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
	private void radioDash3_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void radioDash4_Click(object sender, EventArgs e)
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
	private void radioInputType0_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textAvr_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textAvr2_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textAvr3_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textLineValue0_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textOpacity_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textValue01_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textVolumeSymbol_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textVolumeSymbol_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelIchimokuHeader_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelIchimoku0_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelIchimoku1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelIchimoku2_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelIchimoku3_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelIchimoku4_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelIchimokuFill1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void labelIchimokuFill2_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textIchimokuOpacity_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textIchimokuPeriod0_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textIchimokuPeriod1_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textIchimokuPeriod2_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textIchimokuPeriod3_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textIchimokuPeriod4_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitParameters()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PassParameters()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetParameters(ChartControl senderX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonFont_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridLine_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridLine_CellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridLine_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuLineStil_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuVeri_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuYontem_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridPivot_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridPivot_CellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridPivot_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillGridLineRow(int linenoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillGridPivotLineRow(int linenoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonBirimAnalizTip_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonBirimSeviye_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKurum_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKurum_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridKurum_CellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuBirimListe_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void menuBirimSeviye_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string AnalizTipToString(int analiztip)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillGridKurumRow(int linenoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessBirimYontemMenu(int yontem)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessBirimSeviyeMenu(int seviye)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowBirimYontemMenu(dynamic senderform, cxIndicator indicator)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowBirimSeviyeMenu(dynamic senderform, cxIndicator indicator)
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
	private void gridTakas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillGridTakasRow(int linenoX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkSadeceSonDeger_Click(object sender, EventArgs e)
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
	static formChartIndicatorEdit()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		ChartIndicatorEdit = new formChartIndicatorEdit();
	}
}
