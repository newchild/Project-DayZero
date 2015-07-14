using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns18;
using ns22;
using ns29;
using ns79;
using ns80;
using osu.Graphics.Sprites;
using osu_common;
using System;
using System.Collections.Generic;

namespace ns87
{
	// Token: 0x020004F0 RID: 1264
	internal sealed class Class657 : IDisposable
	{
		// Token: 0x040021C7 RID: 8647
		private bool bool_0;

		// Token: 0x040021C1 RID: 8641
		private Class531 class531_0;

		// Token: 0x040021C2 RID: 8642
		private Class531 class531_1;

		// Token: 0x040021C5 RID: 8645
		private Class533 class533_0;

		// Token: 0x040021C6 RID: 8646
		private Class533 class533_1;

		// Token: 0x040021BF RID: 8639
		private readonly Class64 class64_0;

		// Token: 0x040021C3 RID: 8643
		internal Class666 class666_0;

		// Token: 0x040021C4 RID: 8644
		internal Class666 class666_1;

		// Token: 0x040021C0 RID: 8640
		private readonly Class911 class911_0;

		// Token: 0x060028BD RID: 10429
		// RVA: 0x001005D8 File Offset: 0x000FE7D8
		internal Class657(Class64 class64_1, Class911 class911_1)
		{
			this.class64_0 = class64_1;
			this.class911_0 = class911_1;
			this.class533_0 = new Class533("Blue Team", 16f, new Vector2(0f, 100f), 1f, true, Color.get_White());
			this.class533_0.bool_16 = true;
			this.class533_0.method_58(true);
			class911_1.Add(this.class533_0);
			this.class533_1 = new Class533("Red Team", 16f, new Vector2((float)Class115.smethod_43(), 100f), 1f, true, Color.get_White());
			this.class533_1.method_58(true);
			this.class533_1.bool_16 = true;
			this.class533_1.origins_0 = Origins.TopRight;
			class911_1.Add(this.class533_1);
			this.bool_0 = (Class64.class10_0.matchScoringType == MatchScoringTypes.Accuracy);
			this.class666_0 = new Class666(class911_1, new Vector2(0f, 120f), false, 0.7f, !this.bool_0, this.bool_0);
			this.class666_1 = new Class666(class911_1, new Vector2(0f, 120f), true, 0.7f, !this.bool_0, this.bool_0);
			this.class531_0 = new Class531(Class885.Load("lobby-crown", Enum112.flag_1), Origins.Centre, new Vector2((float)(Class115.smethod_43() / 2), 90f), 0.99f, true, Color.get_Yellow());
			this.class531_0.float_2 = 1.2f;
			class911_1.Add(this.class531_0);
			this.class531_1 = new Class531(Class885.Load("lobby-crown", Enum112.flag_1), Origins.Centre, new Vector2((float)(Class115.smethod_43() / 2), 90f), 1f, true, Color.get_Yellow());
			this.class531_1.bool_7 = true;
			Class746 class = new Class746(TransformationType.Scale, 1.2f, 1.3f, Class115.int_1, Class115.int_1 + 1000, Enum70.const_2);
			class.bool_0 = true;
			class.int_2 = 1000;
			this.class531_1.class26_0.Add(class);
			class = new Class746(TransformationType.Scale, 1.3f, 1.2f, Class115.int_1 + 1000, Class115.int_1 + 2000, Enum70.const_1);
			class.bool_0 = true;
			class.int_2 = 1000;
			this.class531_1.class26_0.Add(class);
			this.class531_1.float_2 = 1.2f;
			class911_1.Add(this.class531_1);
		}

		// Token: 0x060028C4 RID: 10436
		// RVA: 0x0000653E File Offset: 0x0000473E
		public void Dispose()
		{
		}

		// Token: 0x060028BE RID: 10430
		// RVA: 0x0001F5F5 File Offset: 0x0001D7F5
		internal void Draw()
		{
			this.class666_0.Draw();
			this.class666_1.Draw();
		}

		// Token: 0x060028BC RID: 10428
		// RVA: 0x00100584 File Offset: 0x000FE784
		internal SlotTeams method_0()
		{
			if (Class64.class10_0.matchScoringType == MatchScoringTypes.Accuracy)
			{
				if (this.class666_0.double_1 <= this.class666_1.double_1)
				{
					return SlotTeams.Red;
				}
				return SlotTeams.Blue;
			}
			else
			{
				if (this.class666_0.int_1 <= this.class666_1.int_1)
				{
					return SlotTeams.Red;
				}
				return SlotTeams.Blue;
			}
		}

		// Token: 0x060028BF RID: 10431
		// RVA: 0x0010085C File Offset: 0x000FEA5C
		internal void method_1()
		{
			if (!this.bool_0)
			{
				bool flag;
				int num = (flag = (Class64.class10_0.matchScoringType == MatchScoringTypes.Combo)) ? this.method_3(SlotTeams.Blue) : this.method_2(SlotTeams.Blue);
				int num2 = flag ? this.method_3(SlotTeams.Red) : this.method_2(SlotTeams.Red);
				this.class666_0.vmethod_0(num);
				this.class666_1.vmethod_0(num2);
				this.class666_0.method_1(this.method_4(SlotTeams.Blue) * 100f);
				this.class666_1.method_1(this.method_4(SlotTeams.Red) * 100f);
				float num3 = ((num > num2 && !Class64.smethod_34(SlotTeams.Blue)) || Class64.smethod_34(SlotTeams.Red)) ? (-Math.Min(300f, ((float)num / (float)Math.Max(1, num2) - 1f) * 100f)) : Math.Min(300f, ((float)num2 / (float)Math.Max(1, num) - 1f) * 100f);
				float num4 = (float)(Class115.smethod_43() / 2) + num3;
				this.class531_0.method_19(new Vector2(num4, 90f), 1000, Enum70.const_1);
				this.class531_1.method_19(new Vector2(num4, 90f), 1000, Enum70.const_1);
				return;
			}
			float num5 = this.method_4(SlotTeams.Blue);
			float num6 = this.method_4(SlotTeams.Red);
			this.class666_0.method_1(num5 * 100f);
			this.class666_1.method_1(num6 * 100f);
			float num7 = (num5 > num6) ? (-Math.Min(300f, (num5 / Math.Max(1f, num6) - 1f) * 300f)) : Math.Min(300f, (num6 / Math.Max(1f, num5) - 1f) * 300f);
			float num8 = (float)(Class115.smethod_43() / 2) + num7;
			this.class531_0.method_19(new Vector2(num8, 90f), 1000, Enum70.const_1);
			this.class531_1.method_19(new Vector2(num8, 90f), 1000, Enum70.const_1);
		}

		// Token: 0x060028C0 RID: 10432
		// RVA: 0x00100A70 File Offset: 0x000FEC70
		private int method_2(SlotTeams slotTeams_0)
		{
			int num = 0;
			int num2 = 0;
			List<Class661> list = this.class64_0.list_4 ?? Class64.list_6;
			int count = list.Count;
			for (int i = 0; i < count; i++)
			{
				Class661 class = list[i];
				if (class != null && class.method_0() == slotTeams_0)
				{
					num2++;
					if (class.class512_0 == null || class.class512_0.bool_2)
					{
						num += class.int_3;
					}
				}
			}
			if (num2 == 0)
			{
				return num;
			}
			return num;
		}

		// Token: 0x060028C1 RID: 10433
		// RVA: 0x00100AF0 File Offset: 0x000FECF0
		private int method_3(SlotTeams slotTeams_0)
		{
			int num = 0;
			int num2 = 0;
			List<Class661> list = this.class64_0.list_4 ?? Class64.list_6;
			int count = list.Count;
			for (int i = 0; i < count; i++)
			{
				Class661 class = list[i];
				if (class != null && class.method_0() == slotTeams_0)
				{
					num2++;
					if (class.class512_0 == null || class.class512_0.bool_2)
					{
						num += (int)class.class512_0.ushort_6;
					}
				}
			}
			if (num2 == 0)
			{
				return num;
			}
			return num;
		}

		// Token: 0x060028C2 RID: 10434
		// RVA: 0x00100B78 File Offset: 0x000FED78
		private float method_4(SlotTeams slotTeams_0)
		{
			float num = 0f;
			int num2 = 0;
			List<Class661> list = this.class64_0.list_4 ?? Class64.list_6;
			int count = list.Count;
			for (int i = 0; i < count; i++)
			{
				Class660 class = list[i];
				if (class != null && class.method_0() == slotTeams_0)
				{
					if (class.class512_0 != null)
					{
						num += class.class512_0.vmethod_1();
					}
					num2++;
				}
			}
			return num / (float)num2;
		}

		// Token: 0x060028C3 RID: 10435
		// RVA: 0x00100BF4 File Offset: 0x000FEDF4
		public void method_5()
		{
			this.class666_0.method_2();
			this.class666_1.method_2();
			this.class531_0.method_19(this.class531_0.vector2_1 + new Vector2(0f, -20f), 1000, Enum70.const_1);
			this.class531_1.method_19(this.class531_1.vector2_1 + new Vector2(0f, -20f), 1000, Enum70.const_1);
			this.class533_0.vector2_1 += new Vector2(0f, -20f);
			this.class533_1.vector2_1 += new Vector2(0f, -20f);
			foreach (Class660 current in this.class64_0.list_4)
			{
				if (current != null)
				{
					current.method_8();
				}
			}
		}
	}
}
