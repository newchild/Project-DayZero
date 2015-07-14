using ns18;
using ns22;
using ns25;
using ns29;
using ns7;
using ns90;
using osu;
using osu_common;
using System;

namespace ns88
{
	// Token: 0x02000506 RID: 1286
	internal sealed class Class670 : Class668
	{
		// Token: 0x04002246 RID: 8774
		private bool bool_1;

		// Token: 0x0600295B RID: 10587
		// RVA: 0x0001FCB1 File Offset: 0x0001DEB1
		public Class670(Class64 class64_1) : base(class64_1)
		{
		}

		// Token: 0x0600295C RID: 10588
		// RVA: 0x0001FCBA File Offset: 0x0001DEBA
		internal override bool vmethod_1()
		{
			return !this.bool_1;
		}

		// Token: 0x0600295D RID: 10589
		// RVA: 0x00104D38 File Offset: 0x00102F38
		internal override void vmethod_10(int int_0)
		{
			base.vmethod_10(int_0);
			SlotTeams slotTeams = this.class64_0.list_4[int_0].method_0();
			bool flag = true;
			foreach (Class660 current in this.class64_0.list_4)
			{
				if (current != null && current.method_0() == slotTeams && current.bool_3)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				if (this.class64_0.class660_0.method_0() == slotTeams)
				{
					this.class64_0.class427_0.class410_0.vmethod_10(0.0);
					this.class64_0.vmethod_22();
					this.bool_1 = true;
					return;
				}
				Class809.smethod_34(Enum3.const_49, null);
				this.class64_0.method_83();
				Class115.smethod_70(OsuModes.RankingTeam, false);
				Class723.smethod_2(null, null);
			}
		}

		// Token: 0x0600295E RID: 10590
		// RVA: 0x0001FCC5 File Offset: 0x0001DEC5
		internal override void vmethod_8()
		{
			Class809.smethod_34(Enum3.const_49, null);
			Class115.smethod_70(OsuModes.RankingTeam, false);
			this.class64_0.method_83();
			Class723.smethod_2(null, null);
		}
	}
}
