using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class cxTrendAlarm
{
	public long TrendID;

	public enAlarmTip AlarmTip;

	public enElementTypes TrendType;

	public string Symbol;

	public string Period;

	public DateTime StartDate;

	public float StartValue;

	public DateTime EndDate;

	public float EndValue;

	public Color ForeColor;

	public DashStyle Dash;

	public int Tickness;

	public bool ActiveBool;

	public bool SesBool;

	public bool EmirBool;

	public bool AcigaSatisBool;

	public string EmirIslem;

	public bool GerceklestiBool;

	public DateTime KayitSaat;

	public DateTime GerceklestiSaat;

	public bool SmsBool;

	public bool CepBool;

	public int KirmaTipi;

	public string Yon;

	public List<long> ZincirList;

	public List<KeyValuePair<string, double>> EmirList;

	public string Hesap;

	public string AltHesap;

	public int LogMode;

	public string DipNot;

	public bool KesismeBool;

	public int DataTip;

	public decimal YakinindaVal;

	public float Param1;

	public float Param2;

	public float Param3;

	public float Param4;

	public enAvrMethods MaYontem;

	public int KiyaslaTip;

	public float KiyaslaMaPeriyot;

	public enAvrMethods KiyaslaMaYontem;

	public float KiyaslaSeviye;

	public int KiyaslaOncekiBar;

	public string SistemName;

	public int SistemBarSayisi;

	public int SistemLine1;

	public int SistemLine2;

	public float KiyaslaFiyatMaPeriyot;

	public enAvrMethods KiyaslaFiyatMaYontem;

	public decimal ListeParam1;

	public decimal ListeParam2;

	public string ListeName;

	public int ArdisikYukselen;

	public int ArdisikDusen;

	public int OtoTrendBar1;

	public int OtoTrendBar2;

	public int EgzoKurumSayisi;

	public int EgzoSureTip;

	public int EgzoSureSaniye;

	public int EgzoSureDakika;

	public int EgzoVeriTip;

	public decimal EgzoBreakLevel;

	public int EgzoLotTlTip;

	[NonSerialized]
	public float KesimSeviyesi;

	[NonSerialized]
	public float SonFiyat;

	[NonSerialized]
	public float SonFiyatFark;

	[NonSerialized]
	public string KesimString;

	[NonSerialized]
	public float Val1;

	[NonSerialized]
	public float Val2;

	[NonSerialized]
	public float ValO1;

	[NonSerialized]
	public float ValO2;

	public static List<cxTrendAlarm> TrendAlarmList;

	public static bool ShowBool;

	public static bool RunningMode;

	public static int RunningRowNo;

	public static string RunningDescription;

	public static long ChartActiveAlarmTrendId;

	public static long RunningSayac;

	public string AlarmTipString
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetBreakValue(List<cxBar> V, out string yonX)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<cxIndicator> GetIndicator()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetNameString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Deserialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxTrendAlarm()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static cxTrendAlarm()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		TrendAlarmList = new List<cxTrendAlarm>();
		ShowBool = false;
		RunningMode = false;
		RunningRowNo = 0;
		RunningDescription = "";
		ChartActiveAlarmTrendId = 0L;
		RunningSayac = 0L;
	}
}
