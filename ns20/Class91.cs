using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns26;
using ns27;
using ns29;
using ns69;
using ns77;
using ns79;
using ns8;
using ns80;
using ns82;
using osu.Graphics.Sprites;
using osu_common;
using osu_common.Helpers;
using System;
using System.Runtime.CompilerServices;

namespace ns20
{
	// Token: 0x020003A9 RID: 937
	internal sealed class Class91 : Class89
	{
		// Token: 0x040016F7 RID: 5879
		private Class421 class421_0;

		// Token: 0x040016F0 RID: 5872
		private Class531 class531_1;

		// Token: 0x040016EF RID: 5871
		private Class533[] class533_0;

		// Token: 0x040016F1 RID: 5873
		private Class753 class753_0;

		// Token: 0x040016F5 RID: 5877
		private Class753 class753_1;

		// Token: 0x040016F2 RID: 5874
		private Class762 class762_0;

		// Token: 0x040016F3 RID: 5875
		private Class762 class762_1;

		// Token: 0x040016F4 RID: 5876
		private Class762 class762_2;

		// Token: 0x040016F6 RID: 5878
		private Class762 class762_3;

		// Token: 0x040016ED RID: 5869
		private int int_1;

		// Token: 0x040016EE RID: 5870
		private int int_2;

		// Token: 0x06001CE1 RID: 7393
		// RVA: 0x0009AA40 File Offset: 0x00098C40
		internal Class91()
		{
			EventHandler eventHandler = null;
			Delegate38 delegate = null;
			EventHandler eventHandler2 = null;
			Delegate38 delegate2 = null;
			Delegate38 delegate3 = null;
			Delegate38 delegate4 = null;
			this.int_1 = 4;
			base..ctor(Class41.GetString(OsuString.Options_TabSkin_CustonKey), false);
			Class885.smethod_36();
			this.class911_0.bool_14 = true;
			EventHandler eventHandler_ = delegate(object sender, EventArgs e)
			{
				Class331.smethod_60("menuback", 1f, Enum112.flag_5);
				this.Close(false);
			};
			Class591 class = new Class591(eventHandler_, false, true);
			this.class911_0.Add<Class531>(class.list_0);
			int num = 225 + (int)Class115.smethod_45();
			int num2 = 80;
			int num3 = 35;
			this.class753_0 = new Class753(this.class911_0, string.Empty, new Vector2((float)(num + 10), 80f), 75f, 1f);
			int i = 1;
			while (i <= 18)
			{
				this.class753_0.method_9(this.method_14(i, i >= 10), i);
				this.method_13(ref i);
			}
			Class753 arg_FB_0 = this.class753_0;
			if (eventHandler == null)
			{
				eventHandler = new EventHandler(this.method_15);
			}
			arg_FB_0.method_0(eventHandler);
			this.class762_0 = new Class762(Class41.GetString(OsuString.Options_TabSkin_SplitLayout), new Vector2((float)(num + 105), (float)num2), 0.8f, false);
			Class762 arg_141_0 = this.class762_0;
			if (delegate == null)
			{
				delegate = new Delegate38(this.method_16);
			}
			arg_141_0.method_8(delegate);
			this.class911_0.Add<Class531>(this.class762_0.list_0);
			num2 = 300;
			this.class753_1 = new Class753(this.class911_0, string.Empty, new Vector2((float)(num - 65), 300f), 150f, 0.8f, false, false);
			this.class753_1.method_9(Class41.GetString(OsuString.Options_ManiaSpecial_Normal), 0);
			this.class753_1.method_9(Class41.GetString(OsuString.Options_ManiaSpecial_Left), 1);
			this.class753_1.method_9(Class41.GetString(OsuString.Options_ManiaSpecial_Right), 2);
			Class753 arg_201_0 = this.class753_1;
			if (eventHandler2 == null)
			{
				eventHandler2 = new EventHandler(this.method_17);
			}
			arg_201_0.method_0(eventHandler2);
			this.class762_3 = new Class762(Class41.GetString(OsuString.Options_TabSkin_BindAlternateSpecialKeys), new Vector2((float)(num + 105), (float)num2), 0.8f, false);
			Class762 arg_247_0 = this.class762_3;
			if (delegate2 == null)
			{
				delegate2 = new Delegate38(this.method_18);
			}
			arg_247_0.method_8(delegate2);
			this.class911_0.Add<Class531>(this.class762_3.list_0);
			num2 += num3;
			this.class762_1 = new Class762(Class41.GetString(OsuString.Options_TabSkin_UpsiedDown), new Vector2((float)num, (float)num2), 0.8f, false);
			Class762 arg_2A4_0 = this.class762_1;
			if (delegate3 == null)
			{
				delegate3 = new Delegate38(this.method_19);
			}
			arg_2A4_0.method_8(delegate3);
			this.class911_0.Add<Class531>(this.class762_1.list_0);
			num2 += num3;
			this.class762_2 = new Class762(Class41.GetString(OsuString.Options_TabSkin_ShowJudgement), new Vector2((float)num, (float)num2), 0.8f, false);
			Class762 arg_301_0 = this.class762_2;
			if (delegate4 == null)
			{
				delegate4 = new Delegate38(this.method_20);
			}
			arg_301_0.method_8(delegate4);
			this.class911_0.Add<Class531>(this.class762_2.list_0);
			this.class753_0.method_18(this.int_1, false);
		}

		// Token: 0x06001CE2 RID: 7394
		// RVA: 0x00017CC2 File Offset: 0x00015EC2
		protected override void Dispose(bool bool_5)
		{
			this.method_11();
			base.Dispose(bool_5);
		}

		// Token: 0x06001CE4 RID: 7396
		// RVA: 0x0009B210 File Offset: 0x00099410
		private void method_10(Keys keys_0)
		{
			Class576 class = this.class421_0.method_5();
			if (class.method_0() < 0)
			{
				class.Insert(0, null);
				class.method_1(0);
				this.class421_0.method_15(class.method_2());
			}
			Enum53 enum53_ = this.class762_3.method_2() ? Enum53.const_2 : Enum53.const_1;
			class.method_2()[this.class533_0[this.int_2].int_0, enum53_] = keys_0;
			this.class421_0.method_14();
			for (int i = 0; i < this.int_1; i++)
			{
				if (this.class533_0[i] != null)
				{
					this.class533_0[i].Text = this.method_12(i);
				}
			}
			while (++this.int_2 < this.int_1 && this.class533_0[this.int_2] == null)
			{
			}
			if (this.int_2 >= this.int_1)
			{
				Class885.smethod_20();
				if (this.method_13(ref this.int_1) > 18)
				{
					this.int_1 = 1;
				}
				this.class753_0.method_18(this.int_1, false);
				return;
			}
			this.class531_1.method_20(this.class533_0[this.int_2].vector2_1.X, 300, Enum70.const_1);
		}

		// Token: 0x06001CE6 RID: 7398
		// RVA: 0x00017CE9 File Offset: 0x00015EE9
		private void method_11()
		{
			if (this.class421_0 != null)
			{
				this.class421_0.Dispose();
				this.class421_0 = null;
			}
		}

		// Token: 0x06001CE7 RID: 7399
		// RVA: 0x0009B354 File Offset: 0x00099554
		private string method_12(int int_3)
		{
			return Class795.smethod_6(this.class762_3.method_2() ? this.class421_0.list_0[int_3].method_0() : this.class421_0.list_0[int_3].Key);
		}

		// Token: 0x06001CE8 RID: 7400
		// RVA: 0x00017D05 File Offset: 0x00015F05
		private int method_13(ref int int_3)
		{
			int_3++;
			if (int_3 > 10 && int_3 % 2 != 0)
			{
				int_3++;
			}
			return int_3;
		}

		// Token: 0x06001CE9 RID: 7401
		// RVA: 0x00017D21 File Offset: 0x00015F21
		private string method_14(int int_3, bool bool_5)
		{
			if (bool_5 && int_3 % 2 == 0)
			{
				return int_3 / 2 + "K Co-op";
			}
			return int_3 + "K";
		}

		// Token: 0x06001CEB RID: 7403
		// RVA: 0x00017D68 File Offset: 0x00015F68
		[CompilerGenerated]
		private void method_15(object sender, EventArgs e)
		{
			this.int_1 = (int)sender;
			this.class762_3.method_6(false);
			this.method_9(true);
		}

		// Token: 0x06001CEC RID: 7404
		// RVA: 0x00017D89 File Offset: 0x00015F89
		[CompilerGenerated]
		private void method_16(object object_0, bool bool_5)
		{
			this.method_9(false);
		}

		// Token: 0x06001CED RID: 7405
		// RVA: 0x0009B3A4 File Offset: 0x000995A4
		[CompilerGenerated]
		private void method_17(object sender, EventArgs e)
		{
			switch ((int)sender)
			{
			case 1:
				this.class421_0.class546_0.enum54_0 = Enum54.const_1;
				break;
			case 2:
				this.class421_0.class546_0.enum54_0 = Enum54.const_2;
				break;
			default:
				this.class421_0.class546_0.enum54_0 = Enum54.const_0;
				break;
			}
			Class885.smethod_20();
			this.method_9(false);
		}

		// Token: 0x06001CEE RID: 7406
		// RVA: 0x00017D89 File Offset: 0x00015F89
		[CompilerGenerated]
		private void method_18(object object_0, bool bool_5)
		{
			this.method_9(false);
		}

		// Token: 0x06001CEF RID: 7407
		// RVA: 0x00017D92 File Offset: 0x00015F92
		[CompilerGenerated]
		private void method_19(object object_0, bool bool_5)
		{
			this.class421_0.class546_0.bool_1 = bool_5;
			Class885.smethod_20();
		}

		// Token: 0x06001CF0 RID: 7408
		// RVA: 0x00017DAA File Offset: 0x00015FAA
		[CompilerGenerated]
		private void method_20(object object_0, bool bool_5)
		{
			this.class421_0.class546_0.bool_0 = bool_5;
			Class885.smethod_20();
		}

		// Token: 0x06001CF1 RID: 7409
		// RVA: 0x00017DC2 File Offset: 0x00015FC2
		[CompilerGenerated]
		private void method_21(Class530 class530_0)
		{
			class530_0.method_16(50, Enum70.const_0);
			class530_0.bool_0 = false;
			this.class911_0.Remove(class530_0);
		}

		// Token: 0x06001CF2 RID: 7410
		// RVA: 0x00017DE0 File Offset: 0x00015FE0
		[CompilerGenerated]
		private bool method_22(Class530 class530_0)
		{
			return class530_0.object_0 == this;
		}

		// Token: 0x06001CE3 RID: 7395
		// RVA: 0x0009AD84 File Offset: 0x00098F84
		internal void method_9(bool bool_5)
		{
			this.int_2 = 0;
			this.class911_0.list_2.FindAll(new Predicate<Class530>(this.method_22)).ForEach(new Action<Class530>(this.method_21));
			this.method_11();
			Class546 class = Class885.smethod_21(this.int_1, Mods.None);
			this.class762_0.method_1(this.int_1 > 1 && !class.nullable_0.HasValue);
			if (!bool_5)
			{
				class.method_5(this.class762_0.method_2());
			}
			this.class762_0.method_6(class.method_4());
			this.class753_0.class533_0.Text = this.method_14(this.int_1, class.method_4());
			this.class421_0 = new Class421(class, true, 0f, 480f, float.NaN, 1f, 0, 0);
			this.class421_0.method_15(this.class421_0.method_5().method_2());
			this.class753_1.method_4(this.class421_0.method_35());
			switch (this.class421_0.method_8())
			{
			case Enum54.const_1:
				this.class753_1.method_18(1, true);
				break;
			case Enum54.const_2:
				this.class753_1.method_18(2, true);
				break;
			default:
				this.class753_1.method_18(0, true);
				break;
			}
			this.class762_3.method_1(this.class421_0.method_8() != Enum54.const_0);
			if (this.class421_0.method_8() == Enum54.const_0)
			{
				this.class762_3.method_6(false);
			}
			this.class762_2.method_6(class.bool_0);
			this.class762_1.method_6(class.bool_1);
			float num = 40f;
			float num2 = class.method_4() ? 1f : 0f;
			float num3 = ((float)this.int_1 + num2) * num;
			float num4 = Math.Min(1f, (float)Class115.smethod_43() / num3);
			num3 *= num4;
			num *= num4;
			float num5 = ((float)Class115.smethod_43() - num3) / 2f;
			this.class531_1 = new Class531(Class885.Load("play-warningarrow", Enum112.flag_1), Enum115.const_5, Origins.CentreLeft, Enum114.const_0, new Vector2(0f, 100f), 0.92f, true, Class115.bool_32 ? Color.get_SkyBlue() : Color.get_White(), null);
			this.class531_1.object_0 = this;
			this.class531_1.float_1 = 1.5708f;
			this.class911_0.Add(this.class531_1);
			this.class533_0 = new Class533[this.int_1];
			int int_ = 0;
			for (int i = 0; i < this.int_1; i++)
			{
				bool flag = false;
				if (this.class762_3.method_2())
				{
					flag = true;
					foreach (Class421 current in this.class421_0)
					{
						if (i == current.list_0[current.method_38()])
						{
							flag = false;
						}
					}
				}
				if (!flag)
				{
					Class531 class2 = new Class531(Class885.Load("mania-key1D", Enum112.flag_1), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(num5, 192f), 0.92f, true, this.class421_0.list_0[i].method_16(), null);
					class2.vector2_2 = 1.3f * new Vector2(num4, 1f);
					class2.object_0 = this;
					this.class911_0.Add(class2);
					this.class533_0[i] = new Class533(this.method_12(i), (float)Math.Max(1, (int)Math.Round((double)(14f * num4))), new Vector2(num5 + num / 2f, 232f), 0.93f, true, Color.get_White());
					this.class533_0[i].method_59(true);
					this.class533_0[i].origins_0 = Origins.Centre;
					this.class533_0[i].object_0 = this;
					this.class533_0[i].int_0 = int_;
					this.class911_0.Add(this.class533_0[i]);
					if (int_++ == 0)
					{
						this.int_2 = i;
						this.class531_1.vector2_1.X = num5 + num / 2f;
					}
				}
				num5 += num + num * ((i == this.class421_0.method_39() - 1) ? num2 : 0f);
			}
		}

		// Token: 0x06001CE5 RID: 7397
		// RVA: 0x00017CD1 File Offset: 0x00015ED1
		internal override bool vmethod_5(Keys keys_0)
		{
			if (keys_0 == 27)
			{
				this.Close(false);
			}
			else
			{
				this.method_10(keys_0);
			}
			return true;
		}
	}
}
