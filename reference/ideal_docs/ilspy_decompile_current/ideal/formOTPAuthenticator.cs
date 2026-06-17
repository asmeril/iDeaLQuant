using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class formOTPAuthenticator : Form
{
	[CompilerGenerated]
	private sealed class _003CGetAllControls_003Ed__7 : IEnumerable<Control>, IEnumerable, IEnumerator<Control>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private Control _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private Control control;

		public Control _003C_003E3__control;

		public formOTPAuthenticator _003C_003E4__this;

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
		public _003CGetAllControls_003Ed__7(int _003C_003E1__state)
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
		static _003CGetAllControls_003Ed__7()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public cxPortfolio.AccountRecord Account;

	public static formOTPAuthenticator reference;

	public string DurumStr;

	public int TryCount;

	private string state;

	private IContainer components;

	private Label lblBilgi;

	private Timer timerChecker;

	private RichTextBox richTextBoxDurum;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formOTPAuthenticator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplyColorSettingsToControls()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetAllControls_003Ed__7))]
	private IEnumerable<Control> GetAllControls(Control control)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formOTPAuthenticator_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formOTPAuthenticator_Load(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetDate()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string toHex10(int num)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getTime()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GenerateHash(string state)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkSmsLogin()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timerChecker_Tick(object sender, EventArgs e)
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
	static formOTPAuthenticator()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
