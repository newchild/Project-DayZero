using ns4;
using ns8;
using osu_common.Bancho;
using System;

namespace ns3
{
	// Token: 0x0200017F RID: 383
	internal sealed class Class18 : bSerializable, Interface5
	{
		// Token: 0x04000660 RID: 1632
		private Class24 class24_0;

		// Token: 0x0400065F RID: 1631
		public Enum1 enum1_0;

		// Token: 0x0400065D RID: 1629
		public int int_0;

		// Token: 0x0400065E RID: 1630
		public string string_0;

		// Token: 0x06000E36 RID: 3638
		// RVA: 0x0000EB44 File Offset: 0x0000CD44
		public Class18(Class32 class32_0)
		{
			this.int_0 = class32_0.ReadInt32();
			this.enum1_0 = (Enum1)class32_0.ReadByte();
		}

		// Token: 0x06000E37 RID: 3639
		// RVA: 0x0004E234 File Offset: 0x0004C434
		public void imethod_0(Class31 class31_0)
		{
			if (this.enum1_0 != Enum1.const_0)
			{
				return;
			}
			string text = string.Concat(new string[]
			{
				":",
				this.class24_0.method_0(),
				" QUIT :",
				this.string_0,
				"\n"
			});
			class31_0.method_3(text);
		}

		// Token: 0x06000E38 RID: 3640
		// RVA: 0x000060D8 File Offset: 0x000042D8
		public void ReadFromStream(Class32 class32_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000E39 RID: 3641
		// RVA: 0x0000EB64 File Offset: 0x0000CD64
		public void WriteToStream(Class31 class31_0)
		{
			class31_0.Write(this.int_0);
			class31_0.Write((byte)this.enum1_0);
		}
	}
}
