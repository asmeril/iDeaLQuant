using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ideal;

public class cxFileTools
{
	public class SysStockItem
	{
		[JsonProperty("d")]
		public string Date
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

		[JsonProperty("s")]
		public string StockCode
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

		[JsonProperty("i")]
		public long InvestorCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SysStockItem()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SysStockItem()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class SkytStockData
	{
		[JsonProperty("dt")]
		public string Date
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

		[JsonProperty("sc")]
		public string StockCode
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

		[JsonProperty("sn")]
		public string StockName
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

		[JsonProperty("is")]
		public string ISIN
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

		[JsonProperty("inv")]
		public List<SkytInvestor> Investors
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SkytStockData()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SkytStockData()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	public class SkytInvestor
	{
		[JsonProperty("it")]
		public string InvestorType
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

		[JsonProperty("nv")]
		public decimal NominalValue
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (decimal)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("np")]
		public decimal NominalPercentage
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (decimal)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SkytInvestor()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SkytInvestor()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}
	}

	private static readonly string s_s;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CompressAndEncryptFile(string inputFilePath, string outputFilePath)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DecryptAndDecompressFile(string inputFilePath, string outputFilePath)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] DecryptAndDecompressToMemory(byte[] encryptedData)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] DecryptAndDecompressToMemory(string encryptedFilePath)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string DecryptAndDecompressToString(byte[] encryptedData)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string DecryptAndDecompressToString(string encryptedFilePath)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GenerateTakasFilenameFromDate(string datestrX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string[] ReadEncryptedAllLines(string encryptedFilePath)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string[] ReadTakasAllLines(string datestrX)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ReadEncryptedAllText(string encryptedFilePath)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteDecryptAllLines(string outputFilePath, string[] lines)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteDecryptAllText(string outputFilePath, string content)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte[] CompressData(byte[] data)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte[] DecryptData(byte[] encryptedData)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte[] DeriveKeyFromPassword(string password, int keySizeInBytes)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte[] EncryptData(byte[] data)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cxFileTools()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static cxFileTools()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		hHEYokUTtehNq5ji0d.JHIBuxHzL6XZs();
		s_s = "iDealFile@2025";
	}
}
