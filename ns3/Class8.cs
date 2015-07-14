using ns8;
using osu_common;
using osu_common.Bancho;
using System;

namespace ns3
{
	// Token: 0x0200016B RID: 363
	internal sealed class Class8 : bSerializable
	{
		// Token: 0x040005E6 RID: 1510
		public int int_0;

		// Token: 0x040005E7 RID: 1511
		public int int_1;

		// Token: 0x040005E8 RID: 1512
		public int int_2;

		// Token: 0x040005E9 RID: 1513
		public int int_3;

		// Token: 0x040005EA RID: 1514
		public int int_4;

		// Token: 0x040005EB RID: 1515
		public Rankings rankings_0 = Rankings.N;

		// Token: 0x040005EC RID: 1516
		public Rankings rankings_1 = Rankings.N;

		// Token: 0x040005ED RID: 1517
		public Rankings rankings_2 = Rankings.N;

		// Token: 0x040005EE RID: 1518
		public Rankings rankings_3 = Rankings.N;

		// Token: 0x040005EF RID: 1519
		public string string_0;

		// Token: 0x06000DF3 RID: 3571
		// RVA: 0x0004D028 File Offset: 0x0004B228
		public Class8(Class32 class32_0)
		{
			this.int_0 = (int)class32_0.ReadInt16();
			this.int_1 = class32_0.ReadInt32();
			this.int_2 = class32_0.ReadInt32();
			this.int_3 = class32_0.ReadInt32();
			this.int_4 = (int)class32_0.ReadByte();
			this.rankings_0 = (Rankings)class32_0.ReadByte();
			this.rankings_2 = (Rankings)class32_0.ReadByte();
			this.rankings_1 = (Rankings)class32_0.ReadByte();
			this.rankings_3 = (Rankings)class32_0.ReadByte();
			this.string_0 = class32_0.ReadString();
		}

		// Token: 0x06000DF4 RID: 3572
		// RVA: 0x000060D8 File Offset: 0x000042D8
		public void ReadFromStream(Class32 class32_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000DF5 RID: 3573
		// RVA: 0x0004D0D4 File Offset: 0x0004B2D4
		public void WriteToStream(Class31 class31_0)
		{
			class31_0.Write((short)this.int_0);
			class31_0.Write(this.int_1);
			class31_0.Write(this.int_2);
			class31_0.Write(this.int_3);
			class31_0.Write((byte)this.int_4);
			class31_0.Write((byte)this.rankings_0);
			class31_0.Write((byte)this.rankings_2);
			class31_0.Write((byte)this.rankings_1);
			class31_0.Write((byte)this.rankings_3);
			class31_0.Write(this.string_0);
		}
	}
}
