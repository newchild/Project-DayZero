using ns24;
using ns8;
using osu_common;
using System;

namespace ns76
{
	// Token: 0x02000442 RID: 1090
	internal sealed class Class513 : Class512
	{
		// Token: 0x04001B85 RID: 7045
		internal float float_0;

		// Token: 0x0600234A RID: 9034
		// RVA: 0x000D5878 File Offset: 0x000D3A78
		public Class513(Class512 class512_0)
		{
			this.bool_2 = class512_0.bool_2;
			this.int_4 = class512_0.int_4;
			this.string_1 = class512_0.string_1;
			this.string_2 = class512_0.string_2;
			this.string_3 = class512_0.string_3;
			this.ushort_1 = class512_0.ushort_1;
			this.ushort_0 = class512_0.ushort_0;
			this.ushort_2 = class512_0.ushort_2;
			this.ushort_3 = class512_0.ushort_3;
			this.ushort_4 = class512_0.ushort_4;
			this.ushort_5 = class512_0.ushort_5;
			this.int_3 = class512_0.int_3;
			this.int_0 = class512_0.int_0;
			this.bool_4 = class512_0.bool_4;
			this.class623_0 = class512_0.class623_0;
			this.string_4 = class512_0.string_4;
			this.dateTime_0 = class512_0.dateTime_0;
		}

		// Token: 0x06002349 RID: 9033
		// RVA: 0x0001BEF6 File Offset: 0x0001A0F6
		public Class513(Class296 class296_1, string string_6) : base(class296_1, string_6)
		{
		}

		// Token: 0x0600234B RID: 9035
		// RVA: 0x0001BF00 File Offset: 0x0001A100
		internal override float vmethod_1()
		{
			return this.float_0 / (float)this.vmethod_2();
		}

		// Token: 0x0600234C RID: 9036
		// RVA: 0x000D5958 File Offset: 0x000D3B58
		internal override Rankings vmethod_4()
		{
			float num = (float)this.ushort_2 / (float)this.vmethod_2();
			if (this.vmethod_1().CompareTo(1f) == 0 && this.bool_4)
			{
				if (!Class876.smethod_6(this.class623_0, Mods.Hidden) && !Class876.smethod_6(this.class623_0, Mods.Flashlight))
				{
					return Rankings.X;
				}
				return Rankings.XH;
			}
			else if ((double)this.vmethod_1() > 0.9 && (double)num <= 0.01 && this.bool_4)
			{
				if (!Class876.smethod_6(this.class623_0, Mods.Hidden) && !Class876.smethod_6(this.class623_0, Mods.Flashlight))
				{
					return Rankings.S;
				}
				return Rankings.SH;
			}
			else
			{
				if (((double)this.vmethod_1() > 0.8 && this.bool_4) || (double)this.vmethod_1() > 0.9)
				{
					return Rankings.A;
				}
				if (((double)this.vmethod_1() > 0.7 && this.bool_4) || (double)this.vmethod_1() > 0.8)
				{
					return Rankings.B;
				}
				if ((double)this.vmethod_1() > 0.6)
				{
					return Rankings.C;
				}
				return Rankings.D;
			}
		}

		// Token: 0x0600234D RID: 9037
		// RVA: 0x0001BF10 File Offset: 0x0001A110
		protected override void vmethod_5(Class32 class32_0)
		{
			this.float_0 = (float)class32_0.ReadDouble();
		}

		// Token: 0x0600234E RID: 9038
		// RVA: 0x0001BF1F File Offset: 0x0001A11F
		protected override void vmethod_6(Class31 class31_0)
		{
			class31_0.Write((double)this.float_0);
		}
	}
}
