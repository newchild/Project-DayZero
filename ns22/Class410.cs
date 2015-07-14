using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns18;
using ns26;
using ns29;
using ns77;
using ns79;
using ns80;
using osu.Graphics.Sprites;
using osu_common;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns22
{
	// Token: 0x020003C0 RID: 960
	internal class Class410
	{
		// Token: 0x040017BF RID: 6079
		[CompilerGenerated]
		private static Action<Class531> action_0;

		// Token: 0x040017C0 RID: 6080
		[CompilerGenerated]
		private static Action<Class531> action_1;

		// Token: 0x040017B5 RID: 6069
		internal bool bool_0 = true;

		// Token: 0x040017B9 RID: 6073
		private bool bool_1 = true;

		// Token: 0x040017BB RID: 6075
		protected bool bool_2;

		// Token: 0x040017AE RID: 6062
		protected internal readonly Class531 class531_0;

		// Token: 0x040017AF RID: 6063
		protected readonly Class531 class531_1;

		// Token: 0x040017BA RID: 6074
		private Class531 class531_2;

		// Token: 0x040017AD RID: 6061
		protected readonly Class538 class538_0;

		// Token: 0x040017B0 RID: 6064
		protected readonly Class731 class731_0;

		// Token: 0x040017B1 RID: 6065
		protected readonly Class731 class731_1;

		// Token: 0x040017B2 RID: 6066
		protected readonly Class731 class731_2;

		// Token: 0x040017B3 RID: 6067
		protected readonly Class911 class911_0;

		// Token: 0x040017B7 RID: 6071
		internal double double_0 = 0.02;

		// Token: 0x040017B8 RID: 6072
		internal double double_1;

		// Token: 0x040017BC RID: 6076
		[CompilerGenerated]
		private double double_2;

		// Token: 0x040017BD RID: 6077
		[CompilerGenerated]
		private double double_3;

		// Token: 0x040017BE RID: 6078
		[CompilerGenerated]
		private double double_4;

		// Token: 0x040017B6 RID: 6070
		internal int int_0;

		// Token: 0x040017B4 RID: 6068
		protected readonly List<Class531> list_0 = new List<Class531>();

		// Token: 0x040017C1 RID: 6081
		[CompilerGenerated]
		private static Predicate<Class746> predicate_0;

		// Token: 0x040017C2 RID: 6082
		[CompilerGenerated]
		private static Predicate<Class746> predicate_1;

		// Token: 0x06001DE6 RID: 7654
		// RVA: 0x000A2D5C File Offset: 0x000A0F5C
		internal Class410(Class911 class911_1)
		{
			this.class911_0 = class911_1;
			Class731[] array = this.vmethod_1("scorebar-colour");
			Class731[] array2 = this.vmethod_1("scorebar-marker");
			this.bool_2 = (array[0].enum112_0 == Enum112.flag_1 || array2[0].enum112_0 == Enum112.flag_2);
			if (this.bool_2)
			{
				if (array[0].string_0 == "scorebar-colour-0" && array[0].enum112_0 == Enum112.flag_1)
				{
					array = new Class731[]
					{
						this.vmethod_2("scorebar-colour")
					};
				}
				this.class731_2 = array2[0];
				this.class731_0 = array2[0];
				this.class731_1 = array2[0];
				this.class538_0 = new Class538(array, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(7.5f, 7.8f), 0.965f, true, Color.get_White(), null);
				this.class531_1 = new Class531(this.class731_2, Enum115.const_15, Origins.Centre, Enum114.const_0, new Vector2(this.method_8(), 10.625f * Class115.float_4), 0.97f, true, Color.get_White(), null);
				this.class531_1.bool_7 = true;
			}
			else
			{
				this.class731_2 = this.vmethod_2("scorebar-ki");
				this.class731_0 = this.vmethod_2("scorebar-kidanger");
				this.class731_1 = this.vmethod_2("scorebar-kidanger2");
				this.class538_0 = new Class538(array, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(3f, 10f), 0.965f, true, Color.get_White(), null);
				this.class531_1 = new Class531(this.class731_2, Enum115.const_15, Origins.Centre, Enum114.const_0, new Vector2(0f, 10f * Class115.float_4), 0.97f, true, Color.get_White(), null);
			}
			this.class538_0.int_4 = 0;
			this.class538_0.method_61();
			this.class538_0.bool_15 = true;
			this.class531_0 = new Class531(this.vmethod_2("scorebar-bg"), Enum115.const_5, Origins.TopLeft, Enum114.const_0, Vector2.get_Zero(), 0.96f, true, Color.get_White(), null);
			this.list_0.Add(this.class531_0);
			this.list_0.Add(this.class538_0);
			this.list_0.Add(this.class531_1);
			if (!Class62.bool_15 && !Class62.bool_16)
			{
				if (class911_1 != null)
				{
					class911_1.Add<Class531>(this.list_0);
				}
			}
			else
			{
				this.method_7(false);
			}
			this.vmethod_5();
		}

		// Token: 0x06001DEC RID: 7660
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void Draw()
		{
		}

		// Token: 0x06001DDC RID: 7644
		// RVA: 0x00018919 File Offset: 0x00016B19
		[CompilerGenerated]
		internal double method_0()
		{
			return this.double_2;
		}

		// Token: 0x06001DDD RID: 7645
		// RVA: 0x00018921 File Offset: 0x00016B21
		[CompilerGenerated]
		private void method_1(double double_5)
		{
			this.double_2 = double_5;
		}

		// Token: 0x06001DDE RID: 7646
		// RVA: 0x0001892A File Offset: 0x00016B2A
		[CompilerGenerated]
		internal double method_2()
		{
			return this.double_3;
		}

		// Token: 0x06001DDF RID: 7647
		// RVA: 0x00018932 File Offset: 0x00016B32
		[CompilerGenerated]
		private void method_3(double double_5)
		{
			this.double_3 = double_5;
		}

		// Token: 0x06001DE0 RID: 7648
		// RVA: 0x0001893B File Offset: 0x00016B3B
		[CompilerGenerated]
		internal double method_4()
		{
			return this.double_4;
		}

		// Token: 0x06001DE1 RID: 7649
		// RVA: 0x00018943 File Offset: 0x00016B43
		[CompilerGenerated]
		private void method_5(double double_5)
		{
			this.double_4 = double_5;
		}

		// Token: 0x06001DE2 RID: 7650
		// RVA: 0x0001894C File Offset: 0x00016B4C
		internal bool method_6()
		{
			return this.bool_1;
		}

		// Token: 0x06001DE3 RID: 7651
		// RVA: 0x00018954 File Offset: 0x00016B54
		internal void method_7(bool bool_3)
		{
			if (this.bool_1 == bool_3)
			{
				return;
			}
			this.vmethod_0(bool_3);
			this.bool_1 = bool_3;
		}

		// Token: 0x06001DE5 RID: 7653
		// RVA: 0x0001896E File Offset: 0x00016B6E
		internal float method_8()
		{
			return (this.class538_0.vector2_1.X + (float)this.class538_0.int_4 / 1.6f) * Class115.float_4;
		}

		// Token: 0x06001DF4 RID: 7668
		// RVA: 0x00018A00 File Offset: 0x00016C00
		internal void method_9(double double_5)
		{
			this.method_1(double_5);
		}

		// Token: 0x06001DF5 RID: 7669
		// RVA: 0x00018A09 File Offset: 0x00016C09
		internal virtual void Reset()
		{
			this.method_3(200.0);
			this.method_5(200.0);
			this.method_1(0.0);
		}

		// Token: 0x06001DF6 RID: 7670
		// RVA: 0x00018A38 File Offset: 0x00016C38
		[CompilerGenerated]
		private static void smethod_0(Class531 class531_3)
		{
			class531_3.method_14(100, Enum70.const_0);
		}

		// Token: 0x06001DF7 RID: 7671
		// RVA: 0x00018A43 File Offset: 0x00016C43
		[CompilerGenerated]
		private static void smethod_1(Class531 class531_3)
		{
			class531_3.method_16(100, Enum70.const_0);
		}

		// Token: 0x06001DF8 RID: 7672
		// RVA: 0x00018A4E File Offset: 0x00016C4E
		[CompilerGenerated]
		private static bool smethod_2(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Colour;
		}

		// Token: 0x06001DF9 RID: 7673
		// RVA: 0x00018A5A File Offset: 0x00016C5A
		[CompilerGenerated]
		private static bool smethod_3(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Scale;
		}

		// Token: 0x06001DE4 RID: 7652
		// RVA: 0x000A2CF8 File Offset: 0x000A0EF8
		protected virtual void vmethod_0(bool bool_3)
		{
			if (bool_3)
			{
				List<Class531> arg_26_0 = this.list_0;
				if (Class410.action_0 == null)
				{
					Class410.action_0 = new Action<Class531>(Class410.smethod_0);
				}
				arg_26_0.ForEach(Class410.action_0);
				return;
			}
			List<Class531> arg_4F_0 = this.list_0;
			if (Class410.action_1 == null)
			{
				Class410.action_1 = new Action<Class531>(Class410.smethod_1);
			}
			arg_4F_0.ForEach(Class410.action_1);
		}

		// Token: 0x06001DE7 RID: 7655
		// RVA: 0x00018999 File Offset: 0x00016B99
		protected virtual Class731[] vmethod_1(string string_0)
		{
			return Class885.smethod_27(string_0, Enum112.flag_6, true);
		}

		// Token: 0x06001DF1 RID: 7665
		// RVA: 0x000189D4 File Offset: 0x00016BD4
		internal virtual void vmethod_10(double double_5)
		{
			this.method_3(Math.Max(0.0, Math.Min(200.0, double_5)));
			this.method_5(double_5);
		}

		// Token: 0x06001DF2 RID: 7666
		// RVA: 0x000A375C File Offset: 0x000A195C
		internal virtual void vmethod_11(double double_5)
		{
			if (Class62.bool_12 && this.bool_0)
			{
				this.bool_0 = false;
			}
			this.method_5(Math.Max(0.0, this.method_4() - double_5));
			this.method_3(Math.Max(0.0, this.method_2() - double_5));
		}

		// Token: 0x06001DF3 RID: 7667
		// RVA: 0x000A37B8 File Offset: 0x000A19B8
		internal virtual void vmethod_12(double double_5)
		{
			if (Class62.bool_12 && this.bool_0)
			{
				this.bool_0 = false;
			}
			this.method_5(this.method_4() + double_5);
			this.method_3(Math.Max(0.0, Math.Min(200.0, this.method_2() + double_5)));
		}

		// Token: 0x06001DE8 RID: 7656
		// RVA: 0x000189A3 File Offset: 0x00016BA3
		protected virtual Class731 vmethod_2(string string_0)
		{
			return Class885.Load(string_0, Enum112.flag_6);
		}

		// Token: 0x06001DE9 RID: 7657
		// RVA: 0x000A2FE4 File Offset: 0x000A11E4
		internal virtual void vmethod_3()
		{
			this.class538_0.method_16(500, Enum70.const_0);
			this.class531_0.method_16(500, Enum70.const_0);
			this.class531_1.method_16(500, Enum70.const_0);
			if (this.class531_2 != null)
			{
				this.class531_2.method_16(50, Enum70.const_0);
			}
			Vector2 vector;
			vector..ctor(0f, 20f);
			this.class538_0.method_18(this.class538_0.vector2_0 - vector, 500);
			this.class531_0.method_18(this.class531_0.vector2_0 - vector, 500);
			this.class531_1.vector2_0 = new Vector2(this.class531_1.vector2_1.X, this.class531_1.vector2_0.Y);
			this.class531_1.class26_0.Add(new Class746(TransformationType.Scale, 1f, 1.6f, Class115.int_1, Class115.int_1 + 500, Enum70.const_0));
		}

		// Token: 0x06001DEA RID: 7658
		// RVA: 0x000A30F0 File Offset: 0x000A12F0
		internal virtual void vmethod_4()
		{
			this.class538_0.method_14(500, Enum70.const_0);
			this.class531_0.method_14(500, Enum70.const_0);
			this.class531_1.method_14(500, Enum70.const_0);
			this.class538_0.method_18(this.class538_0.vector2_0, 500);
			this.class531_0.method_18(this.class531_0.vector2_0, 500);
			this.class531_1.class26_0.Add(new Class746(TransformationType.Scale, 1.6f, 1f, Class115.int_1, Class115.int_1 + 500, Enum70.const_0));
		}

		// Token: 0x06001DEB RID: 7659
		// RVA: 0x000A3198 File Offset: 0x000A1398
		internal virtual void vmethod_5()
		{
			if (Class62.bool_6)
			{
				this.class538_0.int_4 = 0;
			}
			if (!this.bool_0 || this.int_0 > 0)
			{
				if (this.bool_2 && Class62.Mode == PlayModes.Osu)
				{
					if (this.method_0() < 40.0)
					{
						this.class531_1.color_0 = (this.class538_0.color_0 = Class610.smethod_3(Color.get_Black(), Color.get_Red(), Math.Max(0f, (float)((40.0 - this.method_0()) / 40.0))));
						this.class531_1.method_8(true);
					}
					else if (this.method_0() < 100.0)
					{
						this.class531_1.color_0 = (this.class538_0.color_0 = Class610.smethod_3(Color.get_White(), Color.get_Black(), Math.Max(0f, (float)((100.0 - this.method_0()) / 100.0))));
						this.class531_1.bool_7 = false;
						this.class531_1.method_8(false);
					}
					else
					{
						this.class538_0.color_0 = Color.get_White();
						this.class531_1.color_0 = Color.get_White();
						this.class531_1.bool_7 = true;
						this.class531_1.method_8(false);
					}
				}
				if (this.method_0() < 40.0)
				{
					if (this.class531_1.class731_0 != this.class731_1)
					{
						this.class531_1.class731_0 = this.class731_1;
					}
				}
				else if (this.method_0() < 100.0)
				{
					if (this.class531_1.class731_0 != this.class731_0)
					{
						this.class531_1.class731_0 = this.class731_0;
					}
				}
				else if (this.class531_1.class731_0 != this.class731_2)
				{
					this.class531_1.class731_0 = this.class731_2;
				}
			}
			if (this.method_0() < this.method_2())
			{
				if (this.bool_0)
				{
					if (this.int_0 < Class331.int_7 && (Class62.bool_13 || Class331.enum100_0 == Enum100.const_1))
					{
						this.method_1(Math.Min(200.0, this.method_0() + this.double_0 * (Class62.bool_13 ? Class115.double_9 : Class331.double_3)));
						if (this.class531_1.class26_0.Count == 0)
						{
							this.class531_1.class26_0.Add(new Class746(TransformationType.Scale, 1.2f, 0.8f, Class115.int_1, Class115.int_1 + 150, Enum70.const_0));
						}
					}
				}
				else
				{
					this.method_1(Math.Min(200.0, this.method_0() + Math.Abs(this.method_2() - this.method_0()) / 4.0 * Class115.double_0));
				}
			}
			else if (this.method_0() > this.method_2())
			{
				this.bool_0 = false;
				this.method_1(Math.Max(0.0, this.method_0() - Math.Abs(this.method_0() - this.method_2()) / 6.0 * Class115.double_0));
			}
			this.class538_0.int_4 = (int)Math.Min((double)this.class538_0.int_6, Math.Max(0.0, (double)this.class538_0.int_6 * (this.method_0() / 200.0)));
			this.vmethod_6();
		}

		// Token: 0x06001DED RID: 7661
		// RVA: 0x000189AC File Offset: 0x00016BAC
		protected virtual void vmethod_6()
		{
			this.class531_1.vector2_1 = new Vector2(this.method_8(), this.class531_1.vector2_1.Y);
		}

		// Token: 0x06001DEE RID: 7662
		// RVA: 0x000A3530 File Offset: 0x000A1730
		internal virtual void vmethod_7(Color color_0)
		{
			List<Class746> arg_28_0 = this.class531_1.class26_0;
			if (Class410.predicate_0 == null)
			{
				Class410.predicate_0 = new Predicate<Class746>(Class410.smethod_2);
			}
			Class746 class = arg_28_0.Find(Class410.predicate_0);
			if (class != null)
			{
				this.class531_1.color_0 = class.color_1;
				this.class531_1.class26_0.Remove(class);
			}
			Class746 item = new Class746(this.class531_1.color_0, color_0, Class115.int_1, Class115.int_1 + 400);
			this.class531_1.class26_0.Add(item);
		}

		// Token: 0x06001DEF RID: 7663
		// RVA: 0x000A35C4 File Offset: 0x000A17C4
		internal virtual void vmethod_8()
		{
			List<Class746> arg_28_0 = this.class531_1.class26_0;
			if (Class410.predicate_1 == null)
			{
				Class410.predicate_1 = new Predicate<Class746>(Class410.smethod_3);
			}
			arg_28_0.RemoveAll(Class410.predicate_1);
			this.class531_1.class26_0.Add(new Class746(TransformationType.Scale, 1.2f, 0.8f, Class115.int_1, Class115.int_1 + 150, Enum70.const_0));
		}

		// Token: 0x06001DF0 RID: 7664
		// RVA: 0x000A3630 File Offset: 0x000A1830
		internal virtual void vmethod_9()
		{
			if (!this.bool_1)
			{
				return;
			}
			this.class531_2 = new Class531(this.class731_2, Enum115.const_15, Origins.Centre, Enum114.const_0, this.class531_1.vector2_1, 1f, false, Color.get_White(), null);
			Class746 class;
			Class746 class2;
			if (this.class531_1.bool_7)
			{
				this.class531_2.bool_7 = this.class531_1.bool_7;
				class = new Class746(TransformationType.Fade, 0.5f, 0f, Class115.int_1, Class115.int_1 + 120, Enum70.const_0);
				class2 = new Class746(TransformationType.Scale, 1f, 2f, Class115.int_1, Class115.int_1 + 120, Enum70.const_0);
			}
			else
			{
				class = new Class746(TransformationType.Fade, 1f, 0f, Class115.int_1, Class115.int_1 + 120, Enum70.const_0);
				class2 = new Class746(TransformationType.Scale, 1f, 1.6f, Class115.int_1, Class115.int_1 + 120, Enum70.const_0);
			}
			class2.enum70_0 = Enum70.const_1;
			class.enum70_0 = Enum70.const_1;
			this.class531_2.class26_0.Add(class2);
			this.class531_2.class26_0.Add(class);
			if (this.class911_0 != null)
			{
				this.class911_0.Add(this.class531_2);
			}
		}
	}
}
