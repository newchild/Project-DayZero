using ns24;
using ns25;
using ns26;
using ns29;
using ns30;
using ns64;
using System;

namespace ns14
{
	// Token: 0x020005C5 RID: 1477
	internal static class Class789
	{
		// Token: 0x020005C6 RID: 1478
		private enum Enum76
		{
			// Token: 0x04002729 RID: 10025
			const_0,
			// Token: 0x0400272A RID: 10026
			const_1,
			// Token: 0x0400272B RID: 10027
			const_2
		}

		// Token: 0x04002724 RID: 10020
		private static bool bool_0 = true;

		// Token: 0x04002725 RID: 10021
		private static Class296 class296_0;

		// Token: 0x04002727 RID: 10023
		private static double double_0;

		// Token: 0x04002726 RID: 10022
		private static Class789.Enum76 enum76_0;

		// Token: 0x06002EE1 RID: 12001
		// RVA: 0x00130BE4 File Offset: 0x0012EDE4
		internal static void smethod_0()
		{
			if (Class789.bool_0 && Class115.smethod_91() <= 600000 && Class809.bool_4)
			{
				if (!Class331.smethod_79() && Class466.Current != Class789.class296_0)
				{
					Class789.class296_0 = Class466.Current;
					Class789.enum76_0 = Class789.Enum76.const_0;
					Class789.double_0 = 0.0;
					if (Class789.class296_0 == null)
					{
						return;
					}
				}
				if (!Class331.smethod_79())
				{
					Class789.double_0 += Class115.double_9;
					switch (Class789.enum76_0)
					{
					case Class789.Enum76.const_0:
						if (Class789.double_0 > 3000.0)
						{
							Class789.enum76_0 = Class789.Enum76.const_1;
							Class789.smethod_1(false);
							return;
						}
						break;
					case Class789.Enum76.const_1:
						if (Class789.double_0 > 40000.0 || Class789.double_0 > (double)(Class331.smethod_31() / 2))
						{
							Class789.enum76_0 = Class789.Enum76.const_2;
							Class789.smethod_1(true);
							return;
						}
						break;
					case Class789.Enum76.const_2:
						if (Class789.double_0 > (double)Class331.smethod_31())
						{
							Class789.enum76_0 = Class789.Enum76.const_0;
							Class789.double_0 = 0.0;
						}
						break;
					default:
						return;
					}
				}
				return;
			}
		}

		// Token: 0x06002EE2 RID: 12002
		// RVA: 0x00130CEC File Offset: 0x0012EEEC
		private static void smethod_1(bool bool_1)
		{
			if (Class789.class296_0 == null)
			{
				return;
			}
			string string_ = string.Concat(new object[]
			{
				"http://osu.ppy.sh/web/lastfm.php?b=",
				Class789.class296_0.int_2,
				"&action=",
				bool_1 ? "scrobble" : "np",
				"&us=",
				Class341.class605_20,
				"&ha=",
				Class341.class605_17
			});
			Class133 class = new Class133(string_);
			class.method_0(new Class133.Delegate17(Class789.smethod_2));
			Class169.smethod_0(class);
		}

		// Token: 0x06002EE3 RID: 12003
		// RVA: 0x00130D90 File Offset: 0x0012EF90
		private static void smethod_2(string string_0, Exception exception_0)
		{
			if (string_0 == null)
			{
				return;
			}
			try
			{
				int num = int.Parse(string_0);
				if (num == -3)
				{
					Class789.bool_0 = false;
				}
			}
			catch
			{
			}
		}
	}
}
