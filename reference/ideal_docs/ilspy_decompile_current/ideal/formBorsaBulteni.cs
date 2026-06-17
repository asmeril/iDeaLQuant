using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class formBorsaBulteni : Form
{
	public class TypeAS
	{
		public class TypeASItem
		{
			public string Sembol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string Grup
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string Seri
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float EnDusukASF
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float EnYuksekASF
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float Aof
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double Hacim
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double Adet
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double SozlesmeSay
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public TypeASItem()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static TypeASItem()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public static int OrderColIndex;

		public static bool DescBool;

		public static Dictionary<string, List<TypeASItem>> Dict;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TypeAS()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TypeAS()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			WP6RZJql8gZrNhVA9v.w65ov7siki();
			hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
			OrderColIndex = 6;
			DescBool = true;
			Dict = new Dictionary<string, List<TypeASItem>>();
		}
	}

	public class TypeOI
	{
		public class TypeOIItem
		{
			public string Sembol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string Grup
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string Seri
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float EnDusukOEF
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float EnYuksekOEF
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public float Aof
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double Hacim
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double Adet
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double SozlesmeSay
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public TypeOIItem()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static TypeOIItem()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public static int OrderColIndex;

		public static bool DescBool;

		public static Dictionary<string, List<TypeOIItem>> Dict;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TypeOI()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TypeOI()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			WP6RZJql8gZrNhVA9v.w65ov7siki();
			hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
			OrderColIndex = 6;
			DescBool = true;
			Dict = new Dictionary<string, List<TypeOIItem>>();
		}
	}

	public class TypeMP
	{
		public class TypeMPItem
		{
			public string Sembol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string Grup
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public string Seri
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double Hacim
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double Adet
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double SozlesmeSay
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public TypeMPItem()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static TypeMPItem()
			{
				WP6RZJql8gZrNhVA9v.prXoP4RuYp();
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			}
		}

		public static int OrderColIndex;

		public static bool DescBool;

		public static Dictionary<string, List<TypeMPItem>> Dict;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TypeMP()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TypeMP()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
			WP6RZJql8gZrNhVA9v.w65ov7siki();
			hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
			OrderColIndex = 4;
			DescBool = true;
			Dict = new Dictionary<string, List<TypeMPItem>>();
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public string datestr;

		public formBorsaBulteni _003C_003E4__this;

		public bool result;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass35_0()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003CLoadData_003Eb__0()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec__DisplayClass35_0()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public string url;

		public formBorsaBulteni _003C_003E4__this;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003CbuttonDownload_Click_003Eb__0(double percent)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec__DisplayClass7_0()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CDisplayAcigaSatis_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public formBorsaBulteni _003C_003E4__this;

		private string _003Cdate1str_003E5__1;

		private Exception _003Cerror_003E5__2;

		private TaskAwaiter<bool> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CDisplayAcigaSatis_003Ed__29()
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
		static _003CDisplayAcigaSatis_003Ed__29()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CDisplayMidPoint_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public formBorsaBulteni _003C_003E4__this;

		private string _003Cdate1str_003E5__1;

		private Exception _003Cerror_003E5__2;

		private TaskAwaiter<bool> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CDisplayMidPoint_003Ed__31()
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
		static _003CDisplayMidPoint_003Ed__31()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CDisplayOzelIslemler_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public formBorsaBulteni _003C_003E4__this;

		private string _003Cdate1str_003E5__1;

		private Exception _003Cerror_003E5__2;

		private TaskAwaiter<bool> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CDisplayOzelIslemler_003Ed__30()
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
		static _003CDisplayOzelIslemler_003Ed__30()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CDownloadFileAsync_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string url;

		public string destinationFilePath;

		public IProgress<double> progress;

		public Action onCompleted;

		private string _003CtempFilePath_003E5__1;

		private HttpClient _003Cclient_003E5__2;

		private HttpResponseMessage _003Cresponse_003E5__3;

		private long? _003CtotalBytes_003E5__4;

		private HttpResponseMessage _003C_003Es__5;

		private Stream _003CcontentStream_003E5__6;

		private Stream _003CfileStream_003E5__7;

		private Stream _003C_003Es__8;

		private byte[] _003Cbuffer_003E5__9;

		private long _003CtotalBytesRead_003E5__10;

		private int _003CbytesRead_003E5__11;

		private double _003CprogressPercentage_003E5__12;

		private int _003C_003Es__13;

		private HttpRequestException _003Cex_003E5__14;

		private Exception _003Cex_003E5__15;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter<Stream> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		private TaskAwaiter<int> _003C_003Eu__4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CDownloadFileAsync_003Ed__27()
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
		static _003CDownloadFileAsync_003Ed__27()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CLoadData_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public string datestr;

		public formBorsaBulteni _003C_003E4__this;

		private _003C_003Ec__DisplayClass35_0 _003C_003E8__1;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CLoadData_003Ed__35()
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
		static _003CLoadData_003Ed__35()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	[CompilerGenerated]
	private sealed class _003CbuttonDownload_Click_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		public EventArgs e;

		public formBorsaBulteni _003C_003E4__this;

		private _003C_003Ec__DisplayClass7_0 _003C_003E8__1;

		private string _003Cfilename_003E5__2;

		private Progress<double> _003Cprogress_003E5__3;

		private Exception _003Cerror_003E5__4;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003CbuttonDownload_Click_003Ed__7()
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
		static _003CbuttonDownload_Click_003Ed__7()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private static formBorsaBulteni reference;

	private Dictionary<string, List<BorsaBultenItem>> BultenDictionary;

	private static Dictionary<string, string> SeriDict;

	private IContainer components;

	private Panel panelHeader;

	private Label label4;

	private Label labelMinimizeWindow;

	private Label labelCloseWindow;

	private TabControl tab;

	private TabPage tabPageAcigaSatis;

	private DataGridView gridAcigaSatis;

	private DataGridViewTextBoxColumn colASNo;

	private DataGridViewTextBoxColumn ColASSembol;

	private DataGridViewTextBoxColumn ColASGrup;

	private DataGridViewTextBoxColumn ColASEnDusukASF;

	private DataGridViewTextBoxColumn ColASEnYuksekASF;

	private DataGridViewTextBoxColumn ColASAOF;

	private DataGridViewTextBoxColumn ColASIslemHacmi;

	private DataGridViewTextBoxColumn ColASIslemAdedi;

	private DataGridViewTextBoxColumn ColASSozlesmeSay;

	private TabPage tabPageOzelIslem;

	private DataGridView gridOzelIslemler;

	private Button buttonDownload;

	private DateTimePicker dtDate1;

	private Button buttonExcelAktar;

	private ComboBox comboBoxSeri;

	private Label labeSenetSec;

	private Label label12;

	private TextBox textSembolAra;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;

	private Label labelProgress;

	private TabPage tabPageMidPoint;

	private DataGridView gridMidPoint;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formBorsaBulteni()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CbuttonDownload_Click_003Ed__7))]
	[DebuggerStepThrough]
	private void buttonDownload_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buttonExcelAktar_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBoxSeri_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboBoxSeri_DropDownClosed(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dtDate1_CloseUp(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBorsaBulteni_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formBorsaBulteni_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridAcigaSatis_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridAcigaSatis_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridOzelIslemler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridOzelIslemler_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridMidPoint_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gridMidPoint_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
	private void panelHeader_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tab_DrawItem(object sender, DrawItemEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tab_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void textSembolAra_TextChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string ConvertSembol(string sembolx, out string serix)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CDownloadFileAsync_003Ed__27))]
	public static Task DownloadFileAsync(string url, string destinationFilePath, IProgress<double> progress, Action onCompleted)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayTab()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDisplayAcigaSatis_003Ed__29))]
	[DebuggerStepThrough]
	private void DisplayAcigaSatis()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDisplayOzelIslemler_003Ed__30))]
	[DebuggerStepThrough]
	private void DisplayOzelIslemler()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CDisplayMidPoint_003Ed__31))]
	private void DisplayMidPoint()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillAcigaSatis(string date1str)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillOzelIslemler(string date1str)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillOzeMidPoint(string date1str)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoadData_003Ed__35))]
	[DebuggerStepThrough]
	private Task<bool> LoadData(string datestr)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string CreateFileNameFromDate(string datestr)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowWindow()
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
	static formBorsaBulteni()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		SeriDict = new Dictionary<string, string>();
	}
}
