using ns8;
using osu_common.Bancho;
using System;

namespace ns3
{
	// Token: 0x02000178 RID: 376
	internal struct Struct13 : bSerializable
	{
		// Token: 0x04000647 RID: 1607
		public bool bool_0;

		// Token: 0x04000648 RID: 1608
		public bool bool_1;

		// Token: 0x04000645 RID: 1605
		public byte byte_0;

		// Token: 0x04000644 RID: 1604
		public int int_0;

		// Token: 0x04000649 RID: 1609
		public int int_1;

		// Token: 0x0400064A RID: 1610
		public int int_2;

		// Token: 0x0400064B RID: 1611
		public int int_3;

		// Token: 0x0400063D RID: 1597
		public ushort ushort_0;

		// Token: 0x0400063E RID: 1598
		public ushort ushort_1;

		// Token: 0x0400063F RID: 1599
		public ushort ushort_2;

		// Token: 0x04000640 RID: 1600
		public ushort ushort_3;

		// Token: 0x04000641 RID: 1601
		public ushort ushort_4;

		// Token: 0x04000642 RID: 1602
		public ushort ushort_5;

		// Token: 0x04000643 RID: 1603
		public ushort ushort_6;

		// Token: 0x04000646 RID: 1606
		public ushort ushort_7;

		// Token: 0x06000E1F RID: 3615
		// RVA: 0x0004DD84 File Offset: 0x0004BF84
		public Struct13(Class32 class32_0)
		{
			this.int_1 = class32_0.ReadInt32();
			this.byte_0 = class32_0.ReadByte();
			this.ushort_1 = class32_0.ReadUInt16();
			this.ushort_0 = class32_0.ReadUInt16();
			this.ushort_2 = class32_0.ReadUInt16();
			this.ushort_3 = class32_0.ReadUInt16();
			this.ushort_4 = class32_0.ReadUInt16();
			this.ushort_5 = class32_0.ReadUInt16();
			this.int_2 = class32_0.ReadInt32();
			this.ushort_7 = class32_0.ReadUInt16();
			this.ushort_6 = class32_0.ReadUInt16();
			this.bool_1 = class32_0.ReadBoolean();
			this.int_0 = (int)class32_0.ReadByte();
			this.int_3 = (int)class32_0.ReadByte();
			if (this.int_0 == 254)
			{
				this.int_0 = 0;
				this.bool_0 = false;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x06000E20 RID: 3616
		// RVA: 0x000060D8 File Offset: 0x000042D8
		public void ReadFromStream(Class32 class32_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000E21 RID: 3617
		// RVA: 0x0004DE5C File Offset: 0x0004C05C
		public void WriteToStream(Class31 class31_0)
		{
			class31_0.Write(this.int_1);
			class31_0.Write(this.byte_0);
			class31_0.Write(this.ushort_1);
			class31_0.Write(this.ushort_0);
			class31_0.Write(this.ushort_2);
			class31_0.Write(this.ushort_3);
			class31_0.Write(this.ushort_4);
			class31_0.Write(this.ushort_5);
			class31_0.Write(this.int_2);
			class31_0.Write(this.ushort_7);
			class31_0.Write(this.ushort_6);
			class31_0.Write(this.bool_1);
			class31_0.Write((byte)(this.bool_0 ? this.int_0 : 254));
			class31_0.Write(this.int_3);
		}
	}
}
