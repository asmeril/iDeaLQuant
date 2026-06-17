using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
internal class Oms
{
	public int Version;

	public ConcurrentDictionary<string, HesapRec> RumuzDict;

	public bool ReconnectBool;

	public string OmsIp;

	public int OmsPort;

	public string OmsUsername;

	public string OmsPassword;

	public int FormWidth;

	public int FormHeight;

	public Font GridFont;

	public int RowHeight;

	public bool RumuzVisible;

	public int TemaTip;

	public List<FieldRec> HissePozisyonFieldList;

	public List<FieldRec> HisseOzetFieldList;

	public List<FieldRec> HisseBekleyenFieldList;

	public List<FieldRec> HisseGerceklesenFieldList;

	public List<FieldRec> HisseIptalFieldList;

	public List<FieldRec> HisseKzFieldList;

	public List<FieldRec> ViopPozisyonFieldList;

	public List<FieldRec> ViopOzetFieldList;

	public List<FieldRec> ViopBekleyenFieldList;

	public List<FieldRec> ViopGerceklesenFieldList;

	public List<FieldRec> ViopIptalFieldList;

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

	public static Oms Instance;

	public static DateTime OmsHeartbeatTime;

	public static ConcurrentDictionary<string, string> HesapNoRumuzDict;

	public static ConcurrentDictionary<string, string> HesapNameRumuzDict;

	public static string SessionId;

	public static bool OmsLoginBool;

	public static bool OmsStartedOnceBool;

	public static List<FieldRec> HissePozisyonFieldDefs;

	public static List<FieldRec> HisseOzetFieldDefs;

	public static List<FieldRec> HisseBekleyenFieldDefs;

	public static List<FieldRec> HisseGerceklesenFieldDefs;

	public static List<FieldRec> HisseIptalFieldDefs;

	public static List<FieldRec> HisseKzFieldDefs;

	public static List<FieldRec> ViopPozisyonFieldDefs;

	public static List<FieldRec> ViopOzetFieldDefs;

	public static List<FieldRec> ViopBekleyenFieldDefs;

	public static List<FieldRec> ViopGerceklesenFieldDefs;

	public static List<FieldRec> ViopIptalFieldDefs;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DefineFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static HesapRec GetRumuzHesap(string hesapname, string althesap)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void PrepareHesapNoRumuzDict()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReadOms()
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
	public static void WriteOms()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Oms()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Oms()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		Instance = new Oms();
		OmsHeartbeatTime = Pb2We1WNbDbPsuEclR.r7iItWL60(Pb2We1WNbDbPsuEclR.jdOeOEpUv);
		HesapNoRumuzDict = new ConcurrentDictionary<string, string>();
		HesapNameRumuzDict = new ConcurrentDictionary<string, string>();
		SessionId = "";
		OmsLoginBool = false;
		OmsStartedOnceBool = false;
		HissePozisyonFieldDefs = new List<FieldRec>();
		HisseOzetFieldDefs = new List<FieldRec>();
		HisseBekleyenFieldDefs = new List<FieldRec>();
		HisseGerceklesenFieldDefs = new List<FieldRec>();
		HisseIptalFieldDefs = new List<FieldRec>();
		HisseKzFieldDefs = new List<FieldRec>();
		ViopPozisyonFieldDefs = new List<FieldRec>();
		ViopOzetFieldDefs = new List<FieldRec>();
		ViopBekleyenFieldDefs = new List<FieldRec>();
		ViopGerceklesenFieldDefs = new List<FieldRec>();
		ViopIptalFieldDefs = new List<FieldRec>();
	}
}
