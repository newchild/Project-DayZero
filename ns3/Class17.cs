using ns40;
using ns8;
using osu_common;
using osu_common.Bancho;
using System;

namespace ns3
{
	// Token: 0x0200017D RID: 381
	internal sealed class Class17 : bSerializable
	{
		// Token: 0x0400065A RID: 1626
		public bool bool_0;

		// Token: 0x04000652 RID: 1618
		public byte byte_0;

		// Token: 0x04000653 RID: 1619
		public readonly Enum30 enum30_0;

		// Token: 0x04000657 RID: 1623
		public float float_0;

		// Token: 0x04000658 RID: 1624
		public float float_1;

		// Token: 0x04000654 RID: 1620
		public int int_0;

		// Token: 0x04000655 RID: 1621
		public int int_1;

		// Token: 0x04000659 RID: 1625
		public int int_2;

		// Token: 0x0400065B RID: 1627
		public PlayModes playModes_0;

		// Token: 0x04000656 RID: 1622
		public string string_0;

		// Token: 0x06000E2F RID: 3631
		// RVA: 0x0004E0E0 File Offset: 0x0004C2E0
		public Class17(Class32 class32_0)
		{
			this.int_1 = class32_0.ReadInt32();
			if (this.int_1 < 0)
			{
				this.int_1 = -this.int_1;
			}
			else
			{
				this.bool_0 = (this.int_1 != 0);
			}
			this.string_0 = class32_0.ReadString();
			this.int_0 = (int)(class32_0.ReadByte() - 24);
			this.byte_0 = class32_0.ReadByte();
			byte b = class32_0.ReadByte();
			this.enum30_0 = ((Enum30)b & (Enum30)(-225));
			this.playModes_0 = (PlayModes)Math.Max(0, Math.Min(3, (b & 224) >> 5));
			this.float_0 = class32_0.ReadSingle();
			this.float_1 = class32_0.ReadSingle();
			this.int_2 = class32_0.ReadInt32();
		}

		// Token: 0x06000E30 RID: 3632
		// RVA: 0x000060D8 File Offset: 0x000042D8
		public void ReadFromStream(Class32 class32_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000E31 RID: 3633
		// RVA: 0x0004E1A4 File Offset: 0x0004C3A4
		public void WriteToStream(Class31 class31_0)
		{
			class31_0.Write(this.bool_0 ? this.int_1 : (-this.int_1));
			class31_0.Write(this.string_0);
			class31_0.Write((byte)(this.int_0 + 24));
			class31_0.Write(this.byte_0);
			class31_0.Write((byte)((int)((byte)this.enum30_0) | (int)((byte)this.playModes_0) << 5));
			class31_0.Write(this.float_0);
			class31_0.Write(this.float_1);
			class31_0.Write(this.int_2);
		}
	}
}
