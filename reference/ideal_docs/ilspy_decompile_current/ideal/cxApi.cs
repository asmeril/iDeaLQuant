using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class cxApi
{
	public static int WmNonClientLeftButtonDown;

	public static int HitCaption;

	public static int HitTop;

	public static int HitBottom;

	public static int HitTopLeft;

	public static int HitTopRight;

	public static int HitBottomLeft;

	public static int HitBottomRight;

	public static int HitLeft;

	public static int HitRight;

	public static int SB_HORZ;

	public static int SB_VERT;

	public static int SB_CTL;

	public static int SB_BOTH;

	public const int WM_NCCALCSIZE = 131;

	public static int WM_SETREDRAW;

	public static int CB_SHOWDROPDOWN;

	[DllImport("user32.dll")]
	public static extern int MapVirtualKey(uint uCode, uint uMapType);

	[DllImport("user32.dll")]
	public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

	[DllImport("user32.dll")]
	public static extern bool ReleaseCapture();

	[DllImport("user32.dll")]
	public static extern int ShowScrollBar(IntPtr hWnd, int wBar, int bShow);

	[DllImport("Gdi32.dll")]
	public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

	[DllImport("kernel32")]
	public static extern long WritePrivateProfileString(string xSection, string xKey, string xVal, string xFileName);

	[DllImport("kernel32")]
	public static extern int GetPrivateProfileString(string xSection, string xKey, string xDef, StringBuilder xRetVal, int xSize, string xFileName);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ReadIniFile(string filenameX, string sectionX, string keyX)
	{
		return null;
	}

	[DllImport("user32.dll")]
	public static extern bool GetCursorPos(ref Point lpPoint);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxApi()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static cxApi()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		WmNonClientLeftButtonDown = 161;
		HitCaption = 2;
		HitTop = 12;
		HitBottom = 15;
		HitTopLeft = 13;
		HitTopRight = 14;
		HitBottomLeft = 16;
		HitBottomRight = 17;
		HitLeft = 10;
		HitRight = 11;
		SB_HORZ = 0;
		SB_VERT = 1;
		SB_CTL = 2;
		SB_BOTH = 3;
		WM_SETREDRAW = 11;
		CB_SHOWDROPDOWN = 335;
	}
}
