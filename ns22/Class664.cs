using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns18;
using ns24;
using ns29;
using ns5;
using ns64;
using ns76;
using ns79;
using ns80;
using ns82;
using osu.GameModes.Select;
using osu.Graphics.Sprites;
using osu_common;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns22
{
	// Token: 0x020004F7 RID: 1271
	internal class Class664 : IDisposable
	{
		// Token: 0x040021F2 RID: 8690
		internal bool bool_0;

		// Token: 0x040021F3 RID: 8691
		internal bool bool_1;

		// Token: 0x040021FB RID: 8699
		public bool bool_2;

		// Token: 0x040021FC RID: 8700
		public bool bool_3;

		// Token: 0x040021FD RID: 8701
		private bool bool_4;

		// Token: 0x040021FE RID: 8702
		internal bool bool_5 = true;

		// Token: 0x040021F7 RID: 8695
		private Class533 class533_0;

		// Token: 0x040021F8 RID: 8696
		internal Class660 class660_0;

		// Token: 0x040021F6 RID: 8694
		internal Class911 class911_0 = new Class911(true);

		// Token: 0x040021EF RID: 8687
		internal readonly int int_0;

		// Token: 0x040021F4 RID: 8692
		private int int_1;

		// Token: 0x040021F9 RID: 8697
		internal int int_2;

		// Token: 0x040021F0 RID: 8688
		internal readonly List<Class660> list_0 = new List<Class660>();

		// Token: 0x040021F1 RID: 8689
		internal Vector2 vector2_0;

		// Token: 0x040021F5 RID: 8693
		internal Vector2 vector2_1 = new Vector2(0f, 36f);

		// Token: 0x040021FA RID: 8698
		internal Vector2 vector2_2 = new Vector2((float)(Class115.smethod_43() - 115), 0f);

		// Token: 0x060028E1 RID: 10465
		// RVA: 0x00101DAC File Offset: 0x000FFFAC
		internal Class664(int int_3, Class660 class660_1, Vector2 vector2_3, bool bool_6)
		{
			Class885.Load("scoreboard-explosion-1", Enum112.flag_1);
			Class885.Load("scoreboard-explosion-2", Enum112.flag_1);
			this.bool_0 = bool_6;
			this.int_0 = int_3;
			this.vector2_0 = vector2_3;
			if (class660_1 != null)
			{
				this.vmethod_0(class660_1);
			}
		}

		// Token: 0x060028E3 RID: 10467
		// RVA: 0x00101EA0 File Offset: 0x001000A0
		internal void Add(Class660 class660_1)
		{
			this.list_0.Add(class660_1);
			if (this.method_0())
			{
				class660_1.method_3(this.method_0());
			}
			class660_1.class664_0 = this;
			if (class660_1.bool_4)
			{
				if (class660_1.int_2 == 0 && this.bool_2)
				{
					class660_1.class531_0.color_0 = new Color(97, 190, 255, 150);
				}
				else
				{
					class660_1.class531_0.color_0 = new Color(31, 115, 153, 150);
				}
			}
			this.class911_0.Add<Class531>(class660_1.list_0);
		}

		// Token: 0x060028EA RID: 10474
		// RVA: 0x0001F766 File Offset: 0x0001D966
		public void Dispose()
		{
			if (this.class911_0 != null)
			{
				this.class911_0.Dispose();
			}
		}

		// Token: 0x060028E8 RID: 10472
		// RVA: 0x0001F758 File Offset: 0x0001D958
		internal void Draw()
		{
			this.class911_0.Draw();
		}

		// Token: 0x060028E5 RID: 10469
		// RVA: 0x0001F730 File Offset: 0x0001D930
		internal bool method_0()
		{
			return this.bool_4;
		}

		// Token: 0x060028E6 RID: 10470
		// RVA: 0x0001F738 File Offset: 0x0001D938
		internal void method_1(bool bool_6)
		{
			this.bool_4 = bool_6;
			this.list_0.ForEach(new Action<Class660>(this.method_4));
		}

		// Token: 0x060028E7 RID: 10471
		// RVA: 0x00102198 File Offset: 0x00100398
		internal void method_2(bool bool_6)
		{
			int num = this.list_0.IndexOf(this.class660_0);
			int num2 = (num > this.int_0 - 1) ? (num - (this.int_0 - 1)) : 0;
			if (this.bool_2 && num2 > 0)
			{
				num2++;
			}
			int num3 = 0;
			int num4 = 0;
			int num5 = (!Class802.smethod_0() || Class802.bool_16 || Class876.smethod_6(Class62.class512_0.class623_0, Mods.Autoplay)) ? (this.list_0.Count - 1) : (this.int_2 - 1);
			if (!Class802.smethod_0() && this.list_0.Count > 0 && this.list_0[this.list_0.Count - 1].class512_0 != null && this.list_0[this.list_0.Count - 1].class512_0 == Class466.Current.class512_0)
			{
				num5--;
			}
			int num6 = 1;
			for (int i = 0; i < this.list_0.Count; i++)
			{
				Class660 class = this.list_0[i];
				bool flag;
				int num7 = (flag = (this.list_0[i].method_2() || this.method_0())) ? num4 : num3;
				bool flag2;
				if ((flag2 = ((i >= num2 && num7 < this.int_0) || (this.bool_2 && i == 0))) && this.bool_1 && class != this.class660_0 && class.bool_4)
				{
					class.float_0 = 0.8f - (float)i / (float)this.int_2 * 0.3f;
				}
				if (i > 0 && (!this.bool_3 || this.list_0[i - 1].int_3 != class.int_3))
				{
					num6++;
				}
				if (this.bool_5)
				{
					class.int_2 = num6;
					if (class.bool_3)
					{
						class.vmethod_1((Class341.class605_5 == RankingType.Friends || Class341.class605_5 == RankingType.Local || class.int_2 <= num5 || Class72.class10_0 != null) ? (i + 1).ToString() : "??");
					}
				}
				class.method_5(this.vector2_0 + (flag ? this.vector2_2 : Vector2.get_Zero()) + this.vector2_1 * (float)num7, flag2, bool_6);
				if (flag2)
				{
					if (flag)
					{
						num4++;
					}
					else
					{
						num3++;
					}
				}
			}
		}

		// Token: 0x060028E9 RID: 10473
		// RVA: 0x00102420 File Offset: 0x00100620
		public void method_3(string string_0)
		{
			if (this.class533_0 != null)
			{
				this.class533_0.method_16(100, Enum70.const_0);
			}
			this.class533_0 = new Class533(string_0, 12f, this.vector2_0 + (this.method_0() ? this.vector2_2 : Vector2.get_Zero()) - new Vector2(0f, 5f), 1f, false, Color.get_White());
			this.class533_0.origins_0 = Origins.BottomLeft;
			this.class533_0.bool_16 = true;
			this.class533_0.method_16(6000, Enum70.const_0);
			this.class911_0.Add(this.class533_0);
		}

		// Token: 0x060028EB RID: 10475
		// RVA: 0x0001F77B File Offset: 0x0001D97B
		[CompilerGenerated]
		private void method_4(Class660 class660_1)
		{
			class660_1.method_3(this.bool_4);
		}

		// Token: 0x060028E2 RID: 10466
		// RVA: 0x00101E44 File Offset: 0x00100044
		internal virtual void vmethod_0(Class660 class660_1)
		{
			this.class660_0 = class660_1;
			if (!this.list_0.Contains(this.class660_0))
			{
				this.Add(this.class660_0);
			}
			this.class660_0.class531_0.color_0 = new Color(250, 250, 250, 100);
		}

		// Token: 0x060028E4 RID: 10468
		// RVA: 0x00101F40 File Offset: 0x00100140
		internal virtual bool vmethod_1(bool bool_6)
		{
			this.list_0.Sort();
			bool result = false;
			if (this.class660_0 != null)
			{
				int num = this.list_0.IndexOf(this.class660_0);
				bool flag = this.class660_0.method_2() || this.method_0();
				if (num < this.int_1)
				{
					this.class660_0.class531_0.method_40(Color.get_White(), 200);
					Class531 class = new Class531(Class885.Load("scoreboard-explosion-2", Enum112.flag_1), flag ? Origins.CentreRight : Origins.CentreLeft, (flag ? (this.class660_0.class533_2.vector2_1 + new Vector2(24f, 0f)) : this.class660_0.class531_0.vector2_1) + new Vector2(0f, 15f), 0.99f, false, Color.get_White());
					class.bool_7 = true;
					class.method_16(400, Enum70.const_0);
					class.class26_0.Add(new Class746(TransformationType.VectorScale, new Vector2(1f, 1f), new Vector2(16f, 1.2f), Class115.int_1, Class115.int_1 + 200, Enum70.const_1));
					if (flag)
					{
						class.method_45(true);
					}
					this.class911_0.Add(class);
					Class531 class2 = new Class531(Class885.Load("scoreboard-explosion-1", Enum112.flag_1), flag ? Origins.CentreRight : Origins.CentreLeft, (flag ? (this.class660_0.class533_2.vector2_1 + new Vector2(24f, 0f)) : this.class660_0.class531_0.vector2_1) + new Vector2(0f, 15f), 1f, false, Color.get_White());
					this.class911_0.Add(class2);
					class2.method_16(700, Enum70.const_0);
					class2.bool_7 = true;
					class2.class26_0.Add(new Class746(TransformationType.VectorScale, new Vector2(1f, 1f), new Vector2(1f, 1.3f), Class115.int_1, Class115.int_1 + 700, Enum70.const_1));
					if (flag)
					{
						class.method_45(true);
						class2.method_45(true);
					}
				}
				result = (num != this.int_1);
				this.int_1 = num;
				this.method_2(bool_6);
			}
			return result;
		}
	}
}
