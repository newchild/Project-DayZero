using ns40;
using ns8;
using osu_common.Bancho;
using System;
using System.Collections.Generic;

namespace ns3
{
	// Token: 0x02000175 RID: 373
	internal sealed class Class13 : bSerializable
	{
		// Token: 0x0400062A RID: 1578
		public Enum0 enum0_0;

		// Token: 0x0400062B RID: 1579
		public int int_0;

		// Token: 0x04000628 RID: 1576
		public List<Class14> list_0;

		// Token: 0x04000629 RID: 1577
		public Struct13 struct13_0;

		// Token: 0x06000E17 RID: 3607
		// RVA: 0x0004DBA8 File Offset: 0x0004BDA8
		public Class13(Class32 class32_0)
		{
			if (Class213.int_0 >= 18)
			{
				this.int_0 = class32_0.ReadInt32();
			}
			this.list_0 = new List<Class14>();
			int num = (int)class32_0.ReadUInt16();
			for (int i = 0; i < num; i++)
			{
				this.list_0.Add(new Class14(class32_0));
			}
			this.enum0_0 = (Enum0)class32_0.ReadByte();
			try
			{
				this.struct13_0 = new Struct13(class32_0);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000E16 RID: 3606
		// RVA: 0x0000EA40 File Offset: 0x0000CC40
		public Class13(List<Class14> list_1, Enum0 enum0_1, Struct13 struct13_1, int int_1)
		{
			this.list_0 = list_1;
			this.enum0_0 = enum0_1;
			this.struct13_0 = struct13_1;
			this.int_0 = int_1;
		}

		// Token: 0x06000E18 RID: 3608
		// RVA: 0x000060D8 File Offset: 0x000042D8
		public void ReadFromStream(Class32 class32_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000E19 RID: 3609
		// RVA: 0x0004DC2C File Offset: 0x0004BE2C
		public void WriteToStream(Class31 class31_0)
		{
			if (Class213.int_0 >= 18)
			{
				class31_0.Write(this.int_0);
			}
			class31_0.Write((ushort)this.list_0.Count);
			foreach (Class14 current in this.list_0)
			{
				current.WriteToStream(class31_0);
			}
			class31_0.Write((byte)this.enum0_0);
			this.struct13_0.WriteToStream(class31_0);
		}
	}
}
