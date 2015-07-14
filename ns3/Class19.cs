using ns8;
using osu_common.Bancho;
using System;

namespace ns3
{
	// Token: 0x02000181 RID: 385
	internal sealed class Class19 : bSerializable
	{
		// Token: 0x04000669 RID: 1641
		public Class12 class12_0;

		// Token: 0x04000665 RID: 1637
		public float float_0;

		// Token: 0x04000666 RID: 1638
		public int int_0;

		// Token: 0x04000667 RID: 1639
		public int int_1;

		// Token: 0x0400066B RID: 1643
		public int int_2;

		// Token: 0x04000668 RID: 1640
		public long long_0;

		// Token: 0x0400066A RID: 1642
		public long long_1;

		// Token: 0x0400066C RID: 1644
		public short short_0;

		// Token: 0x06000E3A RID: 3642
		// RVA: 0x0004E290 File Offset: 0x0004C490
		public Class19(Class32 class32_0)
		{
			this.int_2 = class32_0.ReadInt32();
			this.class12_0 = new Class12(class32_0);
			this.long_0 = class32_0.ReadInt64();
			this.float_0 = class32_0.ReadSingle();
			this.int_0 = class32_0.ReadInt32();
			this.long_1 = class32_0.ReadInt64();
			this.int_1 = class32_0.ReadInt32();
			this.short_0 = class32_0.ReadInt16();
		}

		// Token: 0x06000E3B RID: 3643
		// RVA: 0x000060D8 File Offset: 0x000042D8
		public void ReadFromStream(Class32 class32_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000E3C RID: 3644
		// RVA: 0x0004E304 File Offset: 0x0004C504
		public void WriteToStream(Class31 class31_0)
		{
			class31_0.Write(this.int_2);
			this.class12_0.WriteToStream(class31_0);
			class31_0.Write(this.long_0);
			class31_0.Write(this.float_0);
			class31_0.Write(this.int_0);
			class31_0.Write(this.long_1);
			class31_0.Write(this.int_1);
			class31_0.Write(this.short_0);
		}
	}
}
