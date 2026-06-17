using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class LoadingButton : Button
{
	private bool isLoading;

	private Timer animationTimer;

	private Timer timeoutTimer;

	private int currentFrame;

	private string originalText;

	private LoadingEffectType currentEffect;

	private float[] dotPositions;

	public LoadingEffectType LoadingEffect
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (LoadingEffectType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public int TimeoutSeconds
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public bool IsLoading
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public event EventHandler OnLoadingTimeout
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LoadingButton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TimeoutTimer_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopLoading()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AnimationTimer_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateDotPositions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnPaint(PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawBarsEffect(Graphics g)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawCirclesEffect(Graphics g)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawSpinnerEffect(Graphics g)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawBouncingDotsEffect(Graphics g)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static LoadingButton()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
