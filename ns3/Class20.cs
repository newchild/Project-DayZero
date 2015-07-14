using ns8;
using osu_common.Bancho;
using System;

namespace ns3
{
	// Token: 0x02000182 RID: 386
	internal class Class20 : bSerializable
	{
		// Token: 0x0400066F RID: 1647
		internal int int_0;

		// Token: 0x0400066D RID: 1645
		public string string_0;

		// Token: 0x0400066E RID: 1646
		public string string_1;

		// Token: 0x06000E3F RID: 3647
		// RVA: 0x00005E0F File Offset: 0x0000400F
		public Class20()
		{
		}

		// Token: 0x06000E40 RID: 3648
		// RVA: 0x0000EB90 File Offset: 0x0000CD90
		public Class20(Class32 class32_0)
		{
			this.string_0 = class32_0.ReadString();
			this.string_1 = class32_0.ReadString();
			this.int_0 = (int)class32_0.ReadInt16();
		}

		// Token: 0x06000E41 RID: 3649
		// RVA: 0x000060D8 File Offset: 0x000042D8
		public void ReadFromStream(Class32 class32_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000E3D RID: 3645
		// RVA: 0x0000EB7F File Offset: 0x0000CD7F
		public virtual int vmethod_0()
		{
			return this.int_0;
		}

		// Token: 0x06000E3E RID: 3646
		// RVA: 0x0000EB87 File Offset: 0x0000CD87
		public virtual void vmethod_1(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x06000E42 RID: 3650
		// RVA: 0x0000EBBC File Offset: 0x0000CDBC
		public void WriteToStream(Class31 class31_0)
		{
			class31_0.Write(this.string_0);
			class31_0.Write(this.string_1);
			class31_0.Write(this.vmethod_0());
		}
	}
}
