using ns24;
using ns3;
using osu_common;
using System;

namespace ns76
{
	// Token: 0x0200055D RID: 1373
	internal sealed class Class516 : Class512
	{
		// Token: 0x06002C81 RID: 11393
		// RVA: 0x00021B81 File Offset: 0x0001FD81
		internal Class516(Struct13 struct13_0, string string_6) : base(struct13_0, string_6)
		{
			this.playModes_0 = PlayModes.CatchTheBeat;
		}

		// Token: 0x06002C82 RID: 11394
		// RVA: 0x00021B92 File Offset: 0x0001FD92
		internal Class516(Class296 class296_1, string string_6) : base(class296_1, string_6)
		{
			this.playModes_0 = PlayModes.CatchTheBeat;
		}

		// Token: 0x06002C83 RID: 11395
		// RVA: 0x00021BA3 File Offset: 0x0001FDA3
		internal Class516(string string_6, Class296 class296_1) : base(string_6, class296_1)
		{
			this.playModes_0 = PlayModes.CatchTheBeat;
		}

		// Token: 0x06002C80 RID: 11392
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal override bool vmethod_0()
		{
			return false;
		}

		// Token: 0x06002C86 RID: 11398
		// RVA: 0x00021BD8 File Offset: 0x0001FDD8
		internal override float vmethod_1()
		{
			if (this.vmethod_2() == 0)
			{
				return 1f;
			}
			return (float)this.vmethod_3() / (float)this.vmethod_2();
		}

		// Token: 0x06002C84 RID: 11396
		// RVA: 0x00021BB4 File Offset: 0x0001FDB4
		internal override int vmethod_2()
		{
			return (int)(this.ushort_2 + this.ushort_0 + this.ushort_1 + this.ushort_5 + this.ushort_4);
		}

		// Token: 0x06002C85 RID: 11397
		// RVA: 0x0001BE00 File Offset: 0x0001A000
		internal override int vmethod_3()
		{
			return (int)(this.ushort_2 + this.ushort_0 + this.ushort_1);
		}

		// Token: 0x06002C87 RID: 11399
		// RVA: 0x00120C10 File Offset: 0x0011EE10
		internal override Rankings vmethod_4()
		{
			float num = this.vmethod_1();
			if (!this.bool_2)
			{
				return Rankings.F;
			}
			if (num == 1f)
			{
				if (!Class876.smethod_6(this.class623_0, Mods.Hidden) && !Class876.smethod_6(this.class623_0, Mods.Flashlight))
				{
					return Rankings.X;
				}
				return Rankings.XH;
			}
			else if ((double)num > 0.98)
			{
				if (!Class876.smethod_6(this.class623_0, Mods.Hidden) && !Class876.smethod_6(this.class623_0, Mods.Flashlight))
				{
					return Rankings.S;
				}
				return Rankings.SH;
			}
			else
			{
				if ((double)num > 0.94)
				{
					return Rankings.A;
				}
				if ((double)num > 0.9)
				{
					return Rankings.B;
				}
				if ((double)num > 0.85)
				{
					return Rankings.C;
				}
				return Rankings.D;
			}
		}
	}
}
