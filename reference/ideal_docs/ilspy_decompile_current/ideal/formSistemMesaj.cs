using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class formSistemMesaj : Form
{
	public class MesajQueueClass
	{
		public string SistemName;

		public string Mesaj;

		public Color Renk;

		public int Left;

		public int Top;

		public int Width;

		public int Height;

		public bool CoordBool;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MesajQueueClass()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static MesajQueueClass()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private string SistemName;

	private static Dictionary<string, formSistemMesaj> MesajMap;

	public static Queue<MesajQueueClass> SistemMesajQueue;

	private IContainer components;

	public TextBox textMessage;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public formSistemMesaj()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void formSistemMesaj_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowMesaj(MesajQueueClass mesajX)
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
	static formSistemMesaj()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		MesajMap = new Dictionary<string, formSistemMesaj>();
		SistemMesajQueue = new Queue<MesajQueueClass>();
	}
}
