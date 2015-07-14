using ns14;
using ns18;
using ns59;
using ns63;
using ns70;
using ns76;
using osu_common;
using System;

namespace ns23
{
	// Token: 0x02000551 RID: 1361
	internal sealed class Class302 : Class297
	{
		// Token: 0x06002BEF RID: 11247
		// RVA: 0x0011CAE8 File Offset: 0x0011ACE8
		internal Class302(bool bool_2) : base(bool_2)
		{
			if (this.class911_0 != null)
			{
				this.class911_0.method_4(true, null);
			}
		}

		// Token: 0x06002BF4 RID: 11252
		// RVA: 0x0011CBE0 File Offset: 0x0011ADE0
		internal void method_34(float float_2)
		{
			int num = 0;
			float num2 = float_2 / 2f;
			float num3 = num2;
			for (int i = 0; i < this.int_14 - 1; i++)
			{
				Class316 class = this.list_3[i] as Class316;
				if (!(class is Class317) && !(class is Class318))
				{
					Class304 class2 = this.list_3[i + 1];
					while (class2 is Class317 || class2 is Class318)
					{
						if (++i == this.int_14 - 1)
						{
							IL_87:
							int num4 = (class2.Position.X > class.Position.X) ? 1 : -1;
							float num5 = (float)(class2.StartTime - class.EndTime) - 4.16666651f;
							float num6 = Math.Abs(class2.Position.X - class.Position.X) - ((num == num4) ? num3 : num2);
							if (num5 < num6)
							{
								class.method_9(class2);
								num3 = num2;
							}
							else
							{
								class.float_0 = num5 - num6;
								num3 = Class778.smethod_2(num5 - num6, 0f, num2);
							}
							num = num4;
							goto IL_11C;
						}
						class2 = this.list_3[i + 1];
					}
					goto IL_87;
				}
				IL_11C:;
			}
		}

		// Token: 0x06002BF5 RID: 11253
		// RVA: 0x0011CD1C File Offset: 0x0011AF1C
		internal override Enum61 vmethod_10(Class304 class304_2)
		{
			this.class304_0 = class304_2;
			Enum61 enum = class304_2.vmethod_2();
			if (Class62.class512_0 != null && Class876.smethod_6(this.class623_0, Mods.Perfect) && (enum & Enum61.flag_11) > Enum61.flag_5)
			{
				enum = Enum61.flag_3;
			}
			if (enum == Enum61.flag_3)
			{
				this.int_11++;
			}
			int num = this.list_3.BinarySearch(class304_2);
			this.int_13 = ((num < 0) ? (~num) : num);
			string string_ = string.Empty;
			if (this.int_13 == this.int_14 - 1 || this.list_3[this.int_13 + 1].NewCombo)
			{
				string_ = ((this.int_11 == 0) ? "g" : "b");
				if (enum == Enum61.flag_16 && this.int_11 == 0)
				{
					enum |= Enum61.flag_8;
				}
				this.int_11 = 0;
			}
			base.method_15(enum, string_, class304_2);
			return enum;
		}

		// Token: 0x06002BF3 RID: 11251
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected override void vmethod_18()
		{
		}

		// Token: 0x06002BF2 RID: 11250
		// RVA: 0x0011CB84 File Offset: 0x0011AD84
		protected override void vmethod_20(Class325 class325_0)
		{
			foreach (Class317 current in ((Class327)class325_0).list_2)
			{
				this.Add(current, false);
			}
		}

		// Token: 0x06002BF1 RID: 11249
		// RVA: 0x0011CB1C File Offset: 0x0011AD1C
		protected override void vmethod_21(Class320 class320_0)
		{
			((Class323)class320_0).vmethod_24(false);
			foreach (Class316 current in ((Class323)class320_0).list_11)
			{
				this.Add(current, false);
			}
		}

		// Token: 0x06002BF0 RID: 11248
		// RVA: 0x00021813 File Offset: 0x0001FA13
		internal override Class494 vmethod_7()
		{
			return new Class496(this);
		}
	}
}
