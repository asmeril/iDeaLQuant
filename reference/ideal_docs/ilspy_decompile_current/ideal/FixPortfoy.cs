using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
internal class FixPortfoy
{
	public int Version;

	public ConcurrentDictionary<string, FixHesapRec> RumuzDict;

	public bool ReconnectBool;

	public string FixOrderIp;

	public int FixOrderPort;

	public string FixOrderUser;

	public string FixOrderPassword;

	public int FormWidth;

	public int FormHeight;

	public Font GridFont;

	public int RowHeight;

	public bool RumuzVisible;

	public int TemaTip;

	public List<FixFieldRec> HissePozisyonFieldList;

	public List<FixFieldRec> HisseOzetFieldList;

	public List<FixFieldRec> HisseBekleyenFieldList;

	public List<FixFieldRec> HisseGerceklesenFieldList;

	public List<FixFieldRec> HisseIptalFieldList;

	public List<FixFieldRec> HisseKzFieldList;

	public List<FixFieldRec> ViopPozisyonFieldList;

	public List<FixFieldRec> ViopOzetFieldList;

	public List<FixFieldRec> ViopBekleyenFieldList;

	public List<FixFieldRec> ViopGerceklesenFieldList;

	public List<FixFieldRec> ViopIptalFieldList;

	public Color FormBackColor;

	public Color FormForeColor;

	public Color FormBorderColor;

	public Color FormButtonColor;

	public Color FormHeaderBackColor;

	public Color FormHeaderForeColor;

	public Color LabelBackColor1;

	public Color LabelBackColor2;

	public Color LabelForeColor;

	public Color LabelBorderColor;

	public Color RumuzInColor;

	public Color RumuzOutColor;

	public Color LogoutBackColor;

	public Color LogoutForeColor;

	public Color LogoutBorderColor;

	public Color PushOnBackColor1;

	public Color PushOnBackColor2;

	public Color PushOnForeColor;

	public Color PushOnBorderColor;

	public Color PushOffBackColor1;

	public Color PushOffBackColor2;

	public Color PushOffForeColor;

	public Color PushOffBorderColor;

	public Color GridBackColor;

	public Color GridForeColor;

	public Color GridLineColor;

	public Color HeaderBackColor;

	public Color HeaderForeColor;

	public Color BekleyenAlisBackColor;

	public Color BekleyenAlisForeColor;

	public Color BekleyenSatisBackColor;

	public Color BekleyenSatisForeColor;

	public Color GerceklesenAlisBackColor;

	public Color GerceklesenAlisForeColor;

	public Color GerceklesenSatisBackColor;

	public Color GerceklesenSatisForeColor;

	public Color IptalAlisBackColor;

	public Color IptalAlisForeColor;

	public Color IptalSatisBackColor;

	public Color IptalSatisForeColor;

	public Color KzAlisBackColor;

	public Color KzAlisForeColor;

	public Color KzSatisBackColor;

	public Color KzSatisForeColor;

	public Color KzNetBackColor;

	public Color KzNetForeColor;

	public static FixPortfoy Instance;

	public static DateTime FixOrderHeartbeatTime;

	public static ConcurrentDictionary<string, string> HesapNoRumuzDict;

	public static ConcurrentDictionary<string, string> HesapNameRumuzDict;

	public static string SessionId;

	public static List<FixFieldRec> HissePozisyonFieldDefs;

	public static List<FixFieldRec> HisseOzetFieldDefs;

	public static List<FixFieldRec> HisseBekleyenFieldDefs;

	public static List<FixFieldRec> HisseGerceklesenFieldDefs;

	public static List<FixFieldRec> HisseIptalFieldDefs;

	public static List<FixFieldRec> HisseKzFieldDefs;

	public static List<FixFieldRec> ViopPozisyonFieldDefs;

	public static List<FixFieldRec> ViopOzetFieldDefs;

	public static List<FixFieldRec> ViopBekleyenFieldDefs;

	public static List<FixFieldRec> ViopGerceklesenFieldDefs;

	public static List<FixFieldRec> ViopIptalFieldDefs;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DefineFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static FixHesapRec GetRumuzHesap(string hesapname, string althesap)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void PrepareHesapNoRumuzDict()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReadFixOrder()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetDefaultParam()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetTema(int tema)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowOmsKep(string symbolX, cxPage.BuySell pageparamsX)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteFixOrder()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FixPortfoy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static FixPortfoy()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		Instance = new FixPortfoy();
		FixOrderHeartbeatTime = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
		HesapNoRumuzDict = new ConcurrentDictionary<string, string>();
		HesapNameRumuzDict = new ConcurrentDictionary<string, string>();
		SessionId = "";
		HissePozisyonFieldDefs = new List<FixFieldRec>();
		HisseOzetFieldDefs = new List<FixFieldRec>();
		HisseBekleyenFieldDefs = new List<FixFieldRec>();
		HisseGerceklesenFieldDefs = new List<FixFieldRec>();
		HisseIptalFieldDefs = new List<FixFieldRec>();
		HisseKzFieldDefs = new List<FixFieldRec>();
		ViopPozisyonFieldDefs = new List<FixFieldRec>();
		ViopOzetFieldDefs = new List<FixFieldRec>();
		ViopBekleyenFieldDefs = new List<FixFieldRec>();
		ViopGerceklesenFieldDefs = new List<FixFieldRec>();
		ViopIptalFieldDefs = new List<FixFieldRec>();
	}
}
