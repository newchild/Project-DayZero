using ns4;
using ns8;
using System;

namespace ns3
{
	// Token: 0x0200016D RID: 365
	internal sealed class Class9 : Interface5
	{
		// Token: 0x040005F0 RID: 1520
		public Class24 class24_0;

		// Token: 0x040005F1 RID: 1521
		public string string_0;

		// Token: 0x06000DF7 RID: 3575
		// RVA: 0x0004D160 File Offset: 0x0004B360
		public void imethod_0(Class31 class31_0)
		{
			string text = string.Concat(new string[]
			{
				":",
				this.class24_0.method_0(),
				" JOIN :",
				this.string_0,
				"\n"
			});
			string text2 = this.class24_0.method_1();
			string a;
			if (text2.Length > 0 && (a = text2) != null)
			{
				if (!(a == "+"))
				{
					if (a == "@")
					{
						string text3 = text;
						text = string.Concat(new string[]
						{
							text3,
							":BanchoBot!cho@cho.ppy.sh MODE ",
							this.string_0,
							" +o ",
							this.class24_0.string_1,
							"\n"
						});
					}
				}
				else
				{
					string text4 = text;
					text = string.Concat(new string[]
					{
						text4,
						":BanchoBot!cho@cho.ppy.sh MODE ",
						this.string_0,
						" +v ",
						this.class24_0.string_1,
						"\n"
					});
				}
			}
			class31_0.method_3(text);
		}
	}
}
