using ns24;
using ns3;
using osu_common;
using System;

namespace ns76
{
	// Token: 0x02000443 RID: 1091
	internal sealed class Class514 : Class512
	{
		// Token: 0x06002350 RID: 9040
		// RVA: 0x0001BF2E File Offset: 0x0001A12E
		internal Class514(Struct13 struct13_0, string string_6) : base(struct13_0, string_6)
		{
			this.playModes_0 = PlayModes.OsuMania;
		}

		// Token: 0x06002351 RID: 9041
		// RVA: 0x0001BF3F File Offset: 0x0001A13F
		internal Class514(Class296 class296_1, string string_6) : base(class296_1, string_6)
		{
			this.playModes_0 = PlayModes.OsuMania;
		}

		// Token: 0x06002352 RID: 9042
		// RVA: 0x0001BF50 File Offset: 0x0001A150
		internal Class514(string string_6, Class296 class296_1) : base(string_6, class296_1)
		{
			this.playModes_0 = PlayModes.OsuMania;
		}

		// Token: 0x0600234F RID: 9039
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal override bool vmethod_0()
		{
			return false;
		}

		// Token: 0x06002353 RID: 9043
		// RVA: 0x000D5A88 File Offset: 0x000D3C88
		internal override float vmethod_1()
		{
			if (this.vmethod_2() == 0)
			{
				return 1f;
			}
			return (float)(this.ushort_2 * 50 + this.ushort_0 * 100 + this.ushort_4 * 200 + (this.ushort_1 + this.ushort_3) * 300) / (float)(this.vmethod_2() * 300);
		}

		// Token: 0x06002354 RID: 9044
		// RVA: 0x0001BF61 File Offset: 0x0001A161
		internal override int vmethod_2()
		{
			return (int)(this.ushort_2 + this.ushort_0 + this.ushort_1 + this.ushort_5 + this.ushort_3 + this.ushort_4);
		}

		// Token: 0x06002355 RID: 9045
		// RVA: 0x0001BF8C File Offset: 0x0001A18C
		internal override int vmethod_3()
		{
			return (int)(this.ushort_2 + this.ushort_0 + this.ushort_1 + this.ushort_3 + this.ushort_4);
		}

		// Token: 0x06002356 RID: 9046
		// RVA: 0x000D5AE8 File Offset: 0x000D3CE8
		internal override Rankings vmethod_4()
		{
			float num = this.vmethod_1();
			if (!this.bool_2)
			{
				return Rankings.F;
			}
			if (num == 1f)
			{
				if (!Class876.smethod_6(this.class623_0, Mods.Hidden | Mods.Flashlight | Mods.FadeIn))
				{
					return Rankings.X;
				}
				return Rankings.XH;
			}
			else if ((double)num > 0.95)
			{
				if (!Class876.smethod_6(this.class623_0, Mods.Hidden | Mods.Flashlight | Mods.FadeIn))
				{
					return Rankings.S;
				}
				return Rankings.SH;
			}
			else
			{
				if ((double)num > 0.9)
				{
					return Rankings.A;
				}
				if ((double)num > 0.8)
				{
					return Rankings.B;
				}
				if ((double)num > 0.7)
				{
					return Rankings.C;
				}
				return Rankings.D;
			}
		}
	}
}
