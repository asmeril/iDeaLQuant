using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

[Serializable]
public class RiskSettingClass
{
	public List<RiskClass> RiskList;

	public string TakasKurum;

	public double TakasHisseYuzde;

	public double TakasLimit;

	public int TakasHisseYon;

	public bool TakasFiltreliBool;

	public string DusukLotKurum;

	public double DusukLotDefa;

	public double DusukLotLimit;

	public bool DusukLotFiltreliBool;

	public string DusukLotSure;

	public string YuksekHacimKurum;

	public double YuksekHacimLimit;

	public bool YuksekHacimFiltreliBool;

	public string YuksekHacimSure;

	public bool HisselerBool;

	public bool VarantlarBool;

	public int HisseGrup;

	public int HisselerRiskTip;

	public string HisselerKurum;

	public int HisselerHacimTip;

	public double HisselerLimit;

	public string HisselerSure;

	public bool HisselerFiltreliBool;

	public static RiskSettingClass Setting;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Deserialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RiskSettingClass()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RiskSettingClass()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		Setting = new RiskSettingClass();
	}
}
