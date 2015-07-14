using ns40;
using ns8;
using osu_common;
using osu_common.Bancho;
using System;

namespace ns3
{
	// Token: 0x02000173 RID: 371
	internal sealed class Class12 : bSerializable
	{
		// Token: 0x0400061C RID: 1564
		public bStatus bStatus_0;

		// Token: 0x04000619 RID: 1561
		public int int_0;

		// Token: 0x0400061A RID: 1562
		public Mods mods_0;

		// Token: 0x0400061B RID: 1563
		public PlayModes playModes_0;

		// Token: 0x04000618 RID: 1560
		public string string_0;

		// Token: 0x0400061D RID: 1565
		public string string_1;

		// Token: 0x06000E13 RID: 3603
		// RVA: 0x0004DAD0 File Offset: 0x0004BCD0
		public Class12(Class32 class32_0)
		{
			this.bStatus_0 = (bStatus)class32_0.ReadByte();
			this.string_1 = class32_0.ReadString();
			this.string_0 = class32_0.ReadString();
			if (Class213.int_0 > 10)
			{
				this.mods_0 = (Mods)class32_0.ReadUInt32();
			}
			else
			{
				this.mods_0 = (Mods)class32_0.ReadInt16();
			}
			this.playModes_0 = (PlayModes)Math.Max(0, Math.Min(3, class32_0.ReadByte()));
			this.int_0 = class32_0.ReadInt32();
		}

		// Token: 0x06000E12 RID: 3602
		// RVA: 0x0000EA0A File Offset: 0x0000CC0A
		public Class12(bStatus bStatus_1, bool bool_0, string string_2, string string_3, int int_1, Mods mods_1, PlayModes playModes_1)
		{
			this.bStatus_0 = bStatus_1;
			this.string_0 = string_3;
			this.string_1 = string_2;
			this.mods_0 = mods_1;
			this.playModes_0 = playModes_1;
			this.int_0 = int_1;
		}

		// Token: 0x06000E14 RID: 3604
		// RVA: 0x000060D8 File Offset: 0x000042D8
		public void ReadFromStream(Class32 class32_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000E15 RID: 3605
		// RVA: 0x0004DB50 File Offset: 0x0004BD50
		public void WriteToStream(Class31 class31_0)
		{
			class31_0.Write((byte)this.bStatus_0);
			class31_0.Write(this.string_1);
			class31_0.Write(this.string_0);
			class31_0.Write((uint)this.mods_0);
			class31_0.Write((byte)this.playModes_0);
			class31_0.Write(this.int_0);
		}
	}
}
