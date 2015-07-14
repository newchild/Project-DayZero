using ns64;
using osu.Input;
using System;

namespace ns82
{
	// Token: 0x02000475 RID: 1141
	internal static class Class575
	{
		// Token: 0x04001E8F RID: 7823
		private static Class576[,] class576_0 = new Class576[19, 2];

		// Token: 0x060024D9 RID: 9433
		// RVA: 0x000DDBD0 File Offset: 0x000DBDD0
		internal static void Initialize()
		{
			for (int i = 1; i <= 18; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					Class576 class = Class575.class576_0[i, j] = new Class576(i, (ManiaLayoutsFor)j);
					string text = Class575.smethod_2((ManiaLayoutsFor)j);
					try
					{
						object obj;
						if (Class341.dictionary_0.TryGetValue(string.Concat(new object[]
						{
							"ManiaLayouts",
							i.ToString(),
							'K',
							text
						}), out obj))
						{
							class.Add(obj.ToString());
						}
					}
					catch
					{
					}
					try
					{
						object obj2;
						if (Class341.dictionary_0.TryGetValue(string.Concat(new object[]
						{
							"ManiaLayoutSelected",
							i.ToString(),
							'K',
							text
						}), out obj2))
						{
							class.method_1(int.Parse(obj2.ToString()));
						}
						goto IL_E7;
					}
					catch
					{
						goto IL_E7;
					}
					break;
					IL_E7:;
				}
			}
		}

		// Token: 0x060024DA RID: 9434
		// RVA: 0x000DDCEC File Offset: 0x000DBEEC
		internal static void smethod_0()
		{
			for (int i = 1; i <= 18; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					Class576 class = Class575.class576_0[i, j];
					string value;
					if (!string.IsNullOrEmpty(value = class.ToString()))
					{
						string text = Class575.smethod_2((ManiaLayoutsFor)j);
						Class341.dictionary_0[string.Concat(new object[]
						{
							"ManiaLayouts",
							i.ToString(),
							'K',
							text
						})] = value;
						Class341.dictionary_0[string.Concat(new object[]
						{
							"ManiaLayoutSelected",
							i.ToString(),
							'K',
							text
						})] = class.method_0().ToString();
					}
				}
			}
		}

		// Token: 0x060024DB RID: 9435
		// RVA: 0x0001CC63 File Offset: 0x0001AE63
		internal static Class576 smethod_1(int int_0, ManiaLayoutsFor maniaLayoutsFor_0)
		{
			return Class575.class576_0[int_0, (int)maniaLayoutsFor_0];
		}

		// Token: 0x060024DC RID: 9436
		// RVA: 0x0001CC71 File Offset: 0x0001AE71
		private static string smethod_2(ManiaLayoutsFor maniaLayoutsFor_0)
		{
			if (maniaLayoutsFor_0 != ManiaLayoutsFor.Normal)
			{
				return maniaLayoutsFor_0.ToString();
			}
			return string.Empty;
		}
	}
}
