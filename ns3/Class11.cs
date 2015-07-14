using ns4;
using ns40;
using ns8;
using osu_common.Bancho;
using System;

namespace ns3
{
	// Token: 0x02000172 RID: 370
	internal sealed class Class11 : bSerializable, Interface5
	{
		// Token: 0x04000617 RID: 1559
		public int int_0;

		// Token: 0x04000614 RID: 1556
		public object object_0;

		// Token: 0x04000615 RID: 1557
		public string string_0;

		// Token: 0x04000616 RID: 1558
		public string string_1;

		// Token: 0x06000E0E RID: 3598
		// RVA: 0x0004D980 File Offset: 0x0004BB80
		public Class11(Class32 class32_0)
		{
			this.object_0 = class32_0.ReadString();
			this.string_0 = class32_0.ReadString();
			this.string_1 = class32_0.ReadString();
			if (Class213.int_0 > 14)
			{
				this.int_0 = class32_0.ReadInt32();
			}
		}

		// Token: 0x06000E0D RID: 3597
		// RVA: 0x0004D934 File Offset: 0x0004BB34
		public Class11(object object_1, string string_2, string string_3)
		{
			this.object_0 = (object_1 ?? string.Empty);
			this.string_0 = string_3;
			this.string_1 = string_2;
			Class24 class = this.object_0 as Class24;
			if (class != null)
			{
				this.int_0 = class.int_0;
			}
		}

		// Token: 0x06000E11 RID: 3601
		// RVA: 0x0004DA4C File Offset: 0x0004BC4C
		public void imethod_0(Class31 class31_0)
		{
			Class24 class = this.object_0 as Class24;
			string text;
			if (class != null)
			{
				text = class.method_0();
			}
			else
			{
				text = this.object_0.ToString();
			}
			class31_0.method_3(string.Concat(new string[]
			{
				":",
				text,
				" PRIVMSG ",
				this.string_1.Replace(' ', '_'),
				" :",
				this.string_0,
				"\n"
			}));
		}

		// Token: 0x06000E0C RID: 3596
		// RVA: 0x0000E9E6 File Offset: 0x0000CBE6
		public bool method_0()
		{
			return this.string_1.Length == 0 || this.string_1[0] != '#';
		}

		// Token: 0x06000E0F RID: 3599
		// RVA: 0x000060D8 File Offset: 0x000042D8
		public void ReadFromStream(Class32 class32_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000E10 RID: 3600
		// RVA: 0x0004D9CC File Offset: 0x0004BBCC
		public void WriteToStream(Class31 class31_0)
		{
			class31_0.Write(this.object_0.ToString());
			class31_0.Write(this.string_0);
			string value = this.string_1;
			if (this.string_1 != null)
			{
				if (this.string_1.StartsWith("#mp_"))
				{
					value = "#multiplayer";
				}
				else if (this.string_1.StartsWith("#spect_"))
				{
					value = "#spectator";
				}
			}
			class31_0.Write(value);
			class31_0.Write(this.int_0);
		}
	}
}
