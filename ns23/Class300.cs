using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns18;
using ns26;
using ns29;
using ns59;
using ns62;
using ns64;
using ns69;
using ns70;
using ns76;
using ns77;
using ns79;
using ns80;
using osu.Graphics.Primitives;
using osu.Graphics.Sprites;
using osu_common;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns23
{
	// Token: 0x02000437 RID: 1079
	internal sealed class Class300 : Class297
	{
		// Token: 0x02000438 RID: 1080
		[CompilerGenerated]
		private sealed class Class507
		{
			// Token: 0x04001B37 RID: 6967
			public int int_0;

			// Token: 0x060022E8 RID: 8936
			// RVA: 0x0001BC8F File Offset: 0x00019E8F
			public bool method_0(Class304 class304_0)
			{
				return class304_0.StartTime > Class331.int_7 && ((Class312)class304_0).class409_0 == this.int_0;
			}
		}

		// Token: 0x04001B30 RID: 6960
		[CompilerGenerated]
		private static Action<Class531> action_5;

		// Token: 0x04001B31 RID: 6961
		[CompilerGenerated]
		private static Action<Class531> action_6;

		// Token: 0x04001B29 RID: 6953
		private bool bool_2;

		// Token: 0x04001B2F RID: 6959
		private Class304 class304_2;

		// Token: 0x04001B2A RID: 6954
		private Class312[] class312_0;

		// Token: 0x04001B1D RID: 6941
		internal int int_16 = 178;

		// Token: 0x04001B1E RID: 6942
		internal int int_17 = 20;

		// Token: 0x04001B1F RID: 6943
		internal int int_18 = 60;

		// Token: 0x04001B20 RID: 6944
		internal int int_19 = 2147483647;

		// Token: 0x04001B21 RID: 6945
		internal int int_20 = -2147483648;

		// Token: 0x04001B22 RID: 6946
		internal int int_21 = -2147483648;

		// Token: 0x04001B23 RID: 6947
		internal int int_22;

		// Token: 0x04001B24 RID: 6948
		internal int int_23;

		// Token: 0x04001B25 RID: 6949
		internal int int_24;

		// Token: 0x04001B2B RID: 6955
		private int[] int_25;

		// Token: 0x04001B2C RID: 6956
		private int[] int_26;

		// Token: 0x04001B2D RID: 6957
		internal int int_27;

		// Token: 0x04001B2E RID: 6958
		private int int_28;

		// Token: 0x04001B26 RID: 6950
		protected List<Class531> list_7;

		// Token: 0x04001B27 RID: 6951
		private List<Class340> list_8;

		// Token: 0x04001B28 RID: 6952
		private List<Class340> list_9;

		// Token: 0x04001B32 RID: 6962
		[CompilerGenerated]
		private static Predicate<Class746> predicate_2;

		// Token: 0x04001B33 RID: 6963
		[CompilerGenerated]
		private static Predicate<Class746> predicate_3;

		// Token: 0x04001B34 RID: 6964
		[CompilerGenerated]
		private static Predicate<Class746> predicate_4;

		// Token: 0x04001B35 RID: 6965
		[CompilerGenerated]
		private static Predicate<Class746> predicate_5;

		// Token: 0x04001B36 RID: 6966
		[CompilerGenerated]
		private static Predicate<Class746> predicate_6;

		// Token: 0x060022C2 RID: 8898
		// RVA: 0x000D0AB4 File Offset: 0x000CECB4
		internal Class300(bool bool_3) : base(bool_3)
		{
			this.int_27 = 0;
			this.int_28 = 0;
		}

		// Token: 0x060022CC RID: 8908
		// RVA: 0x000D0E48 File Offset: 0x000CF048
		internal override void Add(Class304 class304_3, bool bool_3)
		{
			Class911 class911_ = this.class911_0;
			this.class911_0 = null;
			base.Add(class304_3, bool_3);
			this.class911_0 = class911_;
		}

		// Token: 0x060022C3 RID: 8899
		// RVA: 0x0001BB79 File Offset: 0x00019D79
		public override void Dispose()
		{
			if (this.class421_0 != null)
			{
				this.class421_0.Dispose();
			}
			base.Dispose();
		}

		// Token: 0x060022C8 RID: 8904
		// RVA: 0x000D0B14 File Offset: 0x000CED14
		private int method_34(double double_0)
		{
			if (Class876.smethod_6(this.class623_0, Mods.HardRock))
			{
				double_0 /= 1.4;
			}
			else if (Class876.smethod_6(this.class623_0, Mods.Easy))
			{
				double_0 *= 1.4;
			}
			if (Class876.smethod_6(this.class623_0, Mods.DoubleTime))
			{
				double_0 *= 1.5;
			}
			else if (Class876.smethod_6(this.class623_0, Mods.HalfTime))
			{
				double_0 *= 0.75;
			}
			return (int)double_0;
		}

		// Token: 0x060022CA RID: 8906
		// RVA: 0x000D0DB0 File Offset: 0x000CEFB0
		internal int method_35(int int_29)
		{
			if (Class876.smethod_6(this.class623_0, Mods.Random))
			{
				return this.int_25[int_29];
			}
			if (!this.class421_0.method_36())
			{
				return int_29;
			}
			if (int_29 == 0)
			{
				return this.class421_0.list_0.Count - 1;
			}
			return int_29 - 1;
		}

		// Token: 0x060022CB RID: 8907
		// RVA: 0x000D0E08 File Offset: 0x000CF008
		private void method_36(Class312 class312_1)
		{
			switch (class312_1.enum47_0)
			{
			case Enum47.const_0:
				this.int_22++;
				return;
			case Enum47.const_1:
				this.int_23++;
				return;
			default:
				return;
			}
		}

		// Token: 0x060022CD RID: 8909
		// RVA: 0x000D0E74 File Offset: 0x000CF074
		private void method_37(Class312 class312_1)
		{
			if (class312_1.StartTime < this.int_19)
			{
				this.int_19 = class312_1.StartTime;
			}
			if (class312_1.EndTime > this.int_20)
			{
				this.int_20 = class312_1.EndTime;
				this.class304_2 = class312_1;
			}
			if (class312_1.EndTime - class312_1.StartTime > this.int_21)
			{
				this.int_21 = class312_1.EndTime - class312_1.StartTime;
			}
			this.method_36(class312_1);
			this.Add(class312_1, false);
		}

		// Token: 0x060022D2 RID: 8914
		// RVA: 0x000D10A0 File Offset: 0x000CF2A0
		internal void method_38(int int_29)
		{
			bool flag = false;
			bool bool_ = this.class421_0.class546_0.bool_1;
			if (int_29 > this.int_20)
			{
				return;
			}
			if (Class331.enum100_0 == Enum100.const_1)
			{
				Class331.smethod_88();
				flag = true;
			}
			if (this.list_7 != null)
			{
				List<Class531> arg_58_0 = this.list_7;
				if (Class300.action_5 == null)
				{
					Class300.action_5 = new Action<Class531>(Class300.smethod_23);
				}
				arg_58_0.ForEach(Class300.action_5);
				this.list_7.Clear();
			}
			else
			{
				this.list_7 = new List<Class531>();
			}
			foreach (Class304 current in this.list_3)
			{
				if (!((Class312)current).bool_8)
				{
					List<Class531> arg_BD_0 = current.list_1;
					if (Class300.action_6 == null)
					{
						Class300.action_6 = new Action<Class531>(Class300.smethod_24);
					}
					arg_BD_0.ForEach(Class300.action_6);
				}
			}
			foreach (Class421 current2 in this.class421_0)
			{
				current2.class911_3.Clear(false);
				current2.class911_3.method_1(true);
			}
			List<Class340> list = (this.class296_0.method_5() != PlayModes.OsuMania) ? this.class296_0.method_7() : this.class296_0.list_1;
			if (list.Count != 0 && this.list_3.Count != 0)
			{
				this.list_8 = new List<Class340>();
				this.list_9 = new List<Class340>();
				double double_ = list[0].double_0;
				foreach (Class340 current3 in list)
				{
					Class340 class = new Class340();
					class.method_1(false);
					class.double_0 = ((current3.double_0 < 0.0) ? (double_ * (double)current3.method_4()) : current3.double_0);
					class.enum37_0 = current3.enum37_0;
					class.double_1 = current3.double_1;
					if (this.list_8.Count == 1 && current3.double_0 < 0.0 && class.double_1 < (double)this.int_19)
					{
						class.double_1 = this.list_8[0].double_1;
					}
					if (this.list_8.Count > 0 && class.double_1 <= this.list_8[this.list_8.Count - 1].double_1)
					{
						this.list_8.RemoveAt(this.list_8.Count - 1);
					}
					if (this.list_8.Count == 0 || class.double_0 != this.list_8[this.list_8.Count - 1].double_0)
					{
						this.list_8.Add(class);
					}
					if (current3.double_0 >= 0.0)
					{
						this.list_9.Add(class);
						double_ = class.double_0;
					}
				}
				double num;
				for (num = list[0].double_1; num >= 0.0; num -= list[0].double_0 * (double)list[0].enum37_0)
				{
				}
				num -= list[0].double_0 * (double)list[0].enum37_0;
				this.list_8[0].double_1 = num;
				this.list_9[0].double_1 = num;
				this.list_8.Add(new Class340
				{
					double_1 = double.PositiveInfinity
				});
				for (int i = 0; i < this.list_3.Count; i++)
				{
					Class312 class2 = (Class312)this.list_3[i];
					Class313 class3 = this.list_3[i] as Class313;
					if (!class2.bool_8)
					{
						float num2 = this.method_43(class2.class538_0);
						this.method_39(class2.class538_0, (double)class2.StartTime, (double)num2, 0f, 0.0);
						if (class3 != null)
						{
							float num3 = this.method_43(class3.class538_2);
							this.method_39(class3.class538_2, (double)class2.EndTime, (double)num3, 0f, 0.0);
							this.method_39(class3.class538_1, (double)class2.StartTime, (double)(num2 / 2f), -num2 / 2f, (double)(class2.EndTime - class2.StartTime));
							List<Class746> arg_4CA_0 = class3.class538_1.class26_0;
							if (Class300.predicate_2 == null)
							{
								Class300.predicate_2 = new Predicate<Class746>(Class300.smethod_25);
							}
							float float_ = arg_4CA_0.Find(Class300.predicate_2).float_0;
							List<Class746> arg_4FF_0 = class3.class538_1.class26_0;
							if (Class300.predicate_3 == null)
							{
								Class300.predicate_3 = new Predicate<Class746>(Class300.smethod_26);
							}
							float float_2 = arg_4FF_0.FindLast(Class300.predicate_3).float_1;
							float num4 = Math.Abs(float_2 - float_) * 1.6f;
							class3.class538_1.vector2_2.Y = (class3.class538_1.method_42() ? -1f : 1f);
							if (class3.class538_1.bool_15)
							{
								class3.class538_1.bool_15 = false;
								class3.class538_1.vmethod_8();
							}
							Enum55 enum = this.class421_0.class546_0.method_12(class2.class409_0);
							if (enum == Enum55.const_0)
							{
								Class538 expr_59D_cp_0 = class3.class538_1;
								expr_59D_cp_0.vector2_2.Y = expr_59D_cp_0.vector2_2.Y * (num4 / (float)class3.class538_1.int_1);
							}
							else
							{
								Class538 expr_5CA_cp_0 = class3.class538_1;
								expr_5CA_cp_0.vector2_2.Y = expr_5CA_cp_0.vector2_2.Y * this.class421_0.method_31();
								float num5 = (float)class3.class538_1.int_1 / this.class421_0.method_31();
								class3.class538_1.int_1 = (class3.class538_1.int_5 = (int)(num4 / this.class421_0.method_31()));
								class3.class538_1.bool_15 = true;
								switch (enum)
								{
								case Enum55.const_1:
									class3.class538_1.int_3 = (int)(num5 - num4);
									goto IL_68B;
								case Enum55.const_3:
									class3.class538_1.int_3 = (int)((num5 - num4) / 2f);
									goto IL_68B;
								}
								class3.class538_1.int_3 = 0;
							}
							IL_68B:
							class3.class538_1.vmethod_9();
							if (class3.bool_11 || class3.bool_12)
							{
								this.method_44(class3);
							}
							if (class3.bool_12)
							{
								this.method_45(class3);
							}
						}
						class2.class409_0.method_8().class911_3.Add<Class531>(class2.list_1);
					}
				}
				if (!Class341.class606_30)
				{
					Color color_ = this.class421_0.class546_0.method_8("Barline", Color.get_White());
					for (int j = 0; j < this.list_9.Count; j++)
					{
						double num6 = this.list_9[j].double_1;
						double num7 = (double)(this.int_20 + 1);
						if (j + 1 < this.list_9.Count)
						{
							num7 = this.list_9[j + 1].double_1 - 1.0;
						}
						if (num7 >= (double)(int_29 - 1000))
						{
							while (num6 < num7)
							{
								foreach (Class421 current4 in this.class421_0)
								{
									Class531 class4 = new Class531(Class115.class731_0, Enum115.const_5, Origins.CentreLeft, Enum114.const_1, new Vector2(0f, -100f), 0.62f, false, color_, null);
									class4.vector2_2 = new Vector2(current4.float_0 * 1.6f, this.class421_0.class546_0.float_0);
									this.method_39(class4, num6, (double)this.class421_0.class546_0.float_0, 0f, 0.0);
									this.list_7.Add(class4);
									current4.class911_3.Add(class4);
								}
								num6 += this.list_9[j].double_0 * (double)this.list_9[j].enum37_0;
							}
						}
					}
				}
				int num8 = this.int_19 - 1000;
				int num9 = 0;
				while ((double)num8 > this.list_8[0].double_1 && num9 < 3)
				{
					foreach (Class421 current5 in this.class421_0)
					{
						Class531 class5 = new Class531(this.class421_0.class546_0.Load("WarningArrow", "mania-warningarrow", this.class421_0.method_7()), Enum115.const_5, this.class421_0.method_45(Origins.TopCentre), Enum114.const_1, new Vector2(current5.float_0 / 2f, 0f), 0.63f, false, Color.get_White(), null);
						if (Class885.class547_0.double_0 >= 2.4 || current5.method_31() < 1f)
						{
							class5.float_2 = current5.method_33();
						}
						class5.method_43(bool_);
						this.method_39(class5, (double)num8, (double)(-(double)this.method_43(class5)), 0f, 0.0);
						this.list_7.Add(class5);
						current5.class911_3.Add(class5);
					}
					num8 -= 1000;
					num9++;
				}
				foreach (Class421 current6 in this.class421_0)
				{
					current6.class911_3.method_1(false);
				}
				if (flag)
				{
					Class331.smethod_88();
				}
				return;
			}
		}

		// Token: 0x060022D3 RID: 8915
		// RVA: 0x000D1B80 File Offset: 0x000CFD80
		private void method_39(Class531 class531_0, double double_0, double double_1, float float_2, double double_2)
		{
			int int_ = Class300.smethod_22(double_0, this.list_8);
			this.method_40(class531_0, double_0, int_, double_1, float_2);
			this.method_41(class531_0, double_0, int_, double_1, float_2, double_2);
			class531_0.class26_0.Sort();
		}

		// Token: 0x060022D4 RID: 8916
		// RVA: 0x000D1BC0 File Offset: 0x000CFDC0
		private void method_40(Class531 class531_0, double double_0, int int_29, double double_1, float float_2)
		{
			double num = (double)this.class421_0.class546_0.int_0;
			double num2 = 0.0 + Math.Min(double_1, 0.0);
			for (int i = int_29; i >= 0; i--)
			{
				double num3 = this.list_8[i].double_1;
				double num4 = num - Class435.smethod_4(this.list_8[i].double_0, double_0 - num3);
				if (num3 != double_0)
				{
					if (num4 < num2)
					{
						num3 = double_0 - Class435.smethod_6(this.list_8[i].double_0, num - num2);
						num4 = num2;
					}
					class531_0.class26_0.Add(new Class746(TransformationType.MovementY, this.method_42((float)(num4 + (double)float_2)), this.method_42((float)(num + (double)float_2)), (int)num3, (int)double_0, Enum70.const_0)
					{
						byte_0 = 1
					});
					if (num4 == num2)
					{
						return;
					}
					double_0 = num3;
					num = num4;
				}
			}
		}

		// Token: 0x060022D5 RID: 8917
		// RVA: 0x000D1CB0 File Offset: 0x000CFEB0
		private void method_41(Class531 class531_0, double double_0, int int_29, double double_1, float float_2, double double_2)
		{
			double num = (double)this.class421_0.class546_0.int_0;
			double num2 = double.PositiveInfinity;
			double num3 = double_0 + double_2;
			byte byte_ = 2;
			int num4 = int_29;
			while (num4 + 1 < this.list_8.Count)
			{
				while (true)
				{
					double num5 = Math.Min(this.list_8[num4 + 1].double_1, num3);
					double num6 = num + Class435.smethod_4(this.list_8[num4].double_0, num5 - double_0);
					if (double_0 != num5)
					{
						if (num6 > num2)
						{
							num5 = double_0 + Class435.smethod_6(this.list_8[num4].double_0, num2 - num);
							num6 = num2;
						}
						class531_0.class26_0.Add(new Class746(TransformationType.MovementY, this.method_42((float)num + float_2), this.method_42((float)num6 + float_2), (int)double_0, (int)num5, Enum70.const_0)
						{
							byte_0 = byte_
						});
						if (num6 == num2)
						{
							return;
						}
						double_0 = num5;
						num = num6;
					}
					if (num5 != num3)
					{
						break;
					}
					num2 = num6 - (double)this.class421_0.class546_0.int_0 + (double)Class115.int_19 + Math.Max(double_1, 0.0);
					num3 = double.PositiveInfinity;
					byte_ = 3;
				}
				num4++;
			}
		}

		// Token: 0x060022D7 RID: 8919
		// RVA: 0x0001BB9C File Offset: 0x00019D9C
		internal float method_42(float float_2)
		{
			float_2 = (this.class421_0.method_26() ? ((float)Class115.int_19 - float_2) : float_2);
			return float_2 * this.class421_0.method_31();
		}

		// Token: 0x060022D8 RID: 8920
		// RVA: 0x0001BBC5 File Offset: 0x00019DC5
		internal float method_43(Class531 class531_0)
		{
			return Math.Abs((float)class531_0.int_1 / 1.6f * class531_0.float_2 * class531_0.vector2_2.Y / this.class421_0.method_31());
		}

		// Token: 0x060022DB RID: 8923
		// RVA: 0x000D23D4 File Offset: 0x000D05D4
		internal void method_44(Class313 class313_0)
		{
			List<Class746> arg_28_0 = class313_0.class538_0.class26_0;
			if (Class300.predicate_5 == null)
			{
				Class300.predicate_5 = new Predicate<Class746>(Class300.smethod_28);
			}
			arg_28_0.RemoveAll(Class300.predicate_5);
			float num = this.method_42((float)this.class421_0.class546_0.int_0);
			int num2 = class313_0.EndTime + this.HitWindow50;
			class313_0.class538_0.class26_0.method_0(new Class746(TransformationType.MovementY, num, num, num2, num2, Enum70.const_0)
			{
				byte_0 = 4
			});
			Class530 arg_CF_0 = class313_0.class538_2;
			RectangleF? nullable_;
			class313_0.class538_1.method_5(nullable_ = new RectangleF?(class313_0.class409_0.method_8().method_42(0f, (float)this.class421_0.class546_0.int_0 - this.method_43(class313_0.class538_0) / 2f)));
			arg_CF_0.method_5(nullable_);
			class313_0.bool_11 = true;
		}

		// Token: 0x060022DC RID: 8924
		// RVA: 0x000D24BC File Offset: 0x000D06BC
		internal void method_45(Class313 class313_0)
		{
			if (!class313_0.bool_11)
			{
				return;
			}
			List<Class746> arg_31_0 = class313_0.class538_0.class26_0;
			if (Class300.predicate_6 == null)
			{
				Class300.predicate_6 = new Predicate<Class746>(Class300.smethod_29);
			}
			arg_31_0.RemoveAll(Class300.predicate_6);
			int num = class313_0.bool_12 ? class313_0.int_11 : Math.Max(class313_0.StartTime, Class331.int_7);
			this.method_41(class313_0.class538_0, (double)num, Class300.smethod_22((double)num, this.list_8), (double)this.method_43(class313_0.class538_0), 0f, 0.0);
			class313_0.class538_0.class26_0.Sort();
			RectangleF rectangleF_ = class313_0.class538_1.method_4().Value;
			foreach (Class746 current in class313_0.class538_0.class26_0)
			{
				if (current.transformationType_0 == TransformationType.MovementY && current.byte_0 == 3)
				{
					float num2 = current.float_1 - current.float_0;
					RectangleF rectangleF = new RectangleF(rectangleF_.X, rectangleF_.Y + Math.Min(num2, 0f), rectangleF_.Width, rectangleF_.Height + Math.Abs(num2));
					Class746 item = new Class746(rectangleF_, rectangleF, current.int_0, current.int_1, Enum70.const_0);
					class313_0.class538_1.class26_0.Add(item);
					class313_0.class538_2.class26_0.Add(item);
					rectangleF_ = rectangleF;
				}
			}
			class313_0.class538_1.class26_0.Sort();
			class313_0.class538_2.class26_0.Sort();
			class313_0.bool_11 = false;
			class313_0.bool_12 = true;
			class313_0.int_11 = num;
		}

		// Token: 0x060022DD RID: 8925
		// RVA: 0x000D269C File Offset: 0x000D089C
		internal Enum61 method_46(Class313 class313_0)
		{
			this.class304_0 = class313_0;
			Enum61 enum = class313_0.method_11();
			if (enum > Enum61.flag_5)
			{
				base.method_15(enum, "", class313_0);
			}
			return enum;
		}

		// Token: 0x060022DE RID: 8926
		// RVA: 0x000D26CC File Offset: 0x000D08CC
		internal Enum61 method_47(Class313 class313_0)
		{
			this.class304_0 = class313_0;
			return class313_0.method_12();
		}

		// Token: 0x060022D6 RID: 8918
		// RVA: 0x000D1E04 File Offset: 0x000D0004
		private static int smethod_22(double double_0, List<Class340> list_10)
		{
			Class340 class = new Class340();
			class.double_1 = double_0;
			class.method_1(true);
			Class340 item = class;
			int num = list_10.BinarySearch(item);
			if (num < 0)
			{
				num = ~num;
			}
			if (--num < 0)
			{
				num = 0;
			}
			return num;
		}

		// Token: 0x060022E0 RID: 8928
		// RVA: 0x0001BBF8 File Offset: 0x00019DF8
		[CompilerGenerated]
		private static void smethod_23(Class531 class531_0)
		{
			class531_0.class26_0.Clear();
		}

		// Token: 0x060022E1 RID: 8929
		// RVA: 0x0001BC05 File Offset: 0x00019E05
		[CompilerGenerated]
		private static void smethod_24(Class531 class531_0)
		{
			List<Class746> arg_23_0 = class531_0.class26_0;
			if (Class300.predicate_4 == null)
			{
				Class300.predicate_4 = new Predicate<Class746>(Class300.smethod_27);
			}
			arg_23_0.RemoveAll(Class300.predicate_4);
		}

		// Token: 0x060022E2 RID: 8930
		// RVA: 0x0001BC30 File Offset: 0x00019E30
		[CompilerGenerated]
		private static bool smethod_25(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.MovementY && class746_0.byte_0 == 2;
		}

		// Token: 0x060022E3 RID: 8931
		// RVA: 0x0001BC30 File Offset: 0x00019E30
		[CompilerGenerated]
		private static bool smethod_26(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.MovementY && class746_0.byte_0 == 2;
		}

		// Token: 0x060022E4 RID: 8932
		// RVA: 0x0001BC4A File Offset: 0x00019E4A
		[CompilerGenerated]
		private static bool smethod_27(Class746 class746_0)
		{
			return (class746_0.transformationType_0 & (TransformationType.MovementY | TransformationType.ClipRectangle)) > TransformationType.None;
		}

		// Token: 0x060022E5 RID: 8933
		// RVA: 0x0001BC5B File Offset: 0x00019E5B
		[CompilerGenerated]
		private static bool smethod_28(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.MovementY && class746_0.byte_0 == 3;
		}

		// Token: 0x060022E6 RID: 8934
		// RVA: 0x0001BC75 File Offset: 0x00019E75
		[CompilerGenerated]
		private static bool smethod_29(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.MovementY && class746_0.byte_0 == 4;
		}

		// Token: 0x060022C1 RID: 8897
		// RVA: 0x000D08FC File Offset: 0x000CEAFC
		protected override void vmethod_1()
		{
			if (this.class911_0 != null)
			{
				this.class421_0 = new Class421(Class885.smethod_21(Class421.smethod_3(this.class296_0, this.class623_0), this.class623_0), false, 0f, 480f, float.NaN, 1f, 0, 0);
			}
			else
			{
				this.class421_0 = new Class421(this);
			}
			this.class312_0 = new Class312[this.class421_0.list_0.Count];
			this.int_26 = new int[this.class421_0.list_0.Count];
			this.int_25 = new int[this.class421_0.list_0.Count];
			Dictionary<int, bool> dictionary = new Dictionary<int, bool>(this.class421_0.list_0.Count);
			Random random = new Random(Class62.int_12);
			for (int i = 0; i < this.class421_0.list_0.Count; i++)
			{
				if (this.class421_0.method_35() && i == 0)
				{
					if (this.class421_0.method_36())
					{
						this.int_25[0] = this.class421_0.list_0.Count - 1;
						dictionary[this.class421_0.list_0.Count - 1] = true;
					}
					else
					{
						this.int_25[0] = 0;
						dictionary[0] = true;
					}
				}
				else
				{
					int num = random.Next(0, this.class421_0.list_0.Count);
					while (dictionary.ContainsKey(num))
					{
						num = random.Next(0, this.class421_0.list_0.Count);
					}
					this.int_25[i] = num;
					dictionary[num] = true;
				}
			}
			dictionary.Clear();
		}

		// Token: 0x060022DF RID: 8927
		// RVA: 0x000D26E8 File Offset: 0x000D08E8
		internal override Enum61 vmethod_10(Class304 class304_3)
		{
			this.class304_0 = class304_3;
			Enum61 enum = class304_3.vmethod_2();
			int num = this.list_3.BinarySearch(class304_3);
			this.int_13 = ((num < 0) ? (~num) : num);
			if (enum == Enum61.flag_5)
			{
				return enum;
			}
			if (this.bool_2 && enum < Enum61.flag_36)
			{
				enum = Enum61.flag_4;
			}
			Class312 class = (Class312)class304_3;
			if (this.class421_0.class546_0.bool_2)
			{
				class.class409_0.method_8().method_17(enum);
			}
			else
			{
				foreach (Class421 current in this.class421_0)
				{
					current.method_17(enum);
				}
			}
			if (enum > Enum61.flag_5)
			{
				Class62.class62_0.vmethod_31(class304_3);
				class.class409_0.method_22();
				class.class409_0.method_4(false);
			}
			base.method_15(enum, "", class304_3);
			return enum;
		}

		// Token: 0x060022D9 RID: 8921
		// RVA: 0x000D1E44 File Offset: 0x000D0044
		internal override void vmethod_15()
		{
			int num = this.list_3.BinarySearch(new Class330(this, Class331.int_7 - this.PreEmpt - 200));
			if (num < 0)
			{
				num = ~num;
			}
			int num2 = num;
			while (num2 < this.int_14 - 1 && this.list_3[num2].StartTime <= Class331.int_7 + 300)
			{
				num2++;
			}
			if (num == this.int_14)
			{
				this.list_4.Clear();
				return;
			}
			this.list_4 = this.list_3.GetRange(num, 1 + num2 - num);
		}

		// Token: 0x060022DA RID: 8922
		// RVA: 0x000D1EDC File Offset: 0x000D00DC
		internal override void vmethod_16()
		{
			bool[] array = new bool[this.class421_0.list_0.Count];
			Class62.bool_8 = false;
			foreach (Class304 current in this.list_4)
			{
				Class312 class = (Class312)current;
				class.vmethod_6();
				if (class.bool_0)
				{
					if (class.StartTime > Class331.int_7)
					{
						array[class.class409_0] = true;
					}
				}
				else if (!array[class.class409_0] && Class331.int_7 >= class.StartTime - this.int_16)
				{
					if (Class331.int_7 - this.HitWindow100 >= class.EndTime && !class.bool_0)
					{
						this.vmethod_10(class);
					}
					else if (class.class409_0.method_5() && !class.class409_0.bool_2)
					{
						if (class.enum47_0 != Enum47.const_0)
						{
							if (class.enum47_0 != Enum47.const_2)
							{
								if (class.enum47_0 == Enum47.const_1 && !class.bool_6)
								{
									Class62.bool_8 = true;
									class.int_7 = Class331.int_7;
									array[class.class409_0] = true;
									this.class312_0[class.class409_0] = null;
									class.bool_6 = true;
									Class62.class62_0.method_68(class, null);
									this.method_47((Class313)class);
									class.class409_0.method_4(true);
									continue;
								}
								continue;
							}
						}
						class.bool_6 = true;
						class.int_7 = Class331.int_7;
						array[class.class409_0] = true;
						this.class312_0[class.class409_0] = null;
						Class62.class62_0.method_68(class, null);
						this.vmethod_10(class);
					}
					else if (class.class409_0.method_5() && class.class409_0.bool_2)
					{
						if (class.enum47_0 == Enum47.const_1)
						{
							if (class.bool_6)
							{
								array[class.class409_0] = true;
								this.class312_0[class.class409_0] = null;
								this.method_46((Class313)class);
								Class62.bool_8 = true;
								class.class409_0.method_4(true);
							}
							else
							{
								((Class313)class).method_13();
							}
						}
					}
					else if (!class.class409_0.method_5())
					{
						if (class.enum47_0 == Enum47.const_1)
						{
							if (class.bool_6)
							{
								class.bool_6 = false;
								class.int_8 = Class331.int_7;
								Class62.class62_0.method_68(class, new int?(Class331.int_7 - class.EndTime));
								this.vmethod_10(class);
							}
							else
							{
								((Class313)class).method_13();
							}
						}
						class.class409_0.method_4(false);
					}
				}
			}
			if (Class62.class62_0.enum110_0 != Enum110.const_2)
			{
				return;
			}
			Predicate<Class304> predicate = null;
			Class300.Class507 class2 = new Class300.Class507();
			class2.int_0 = 0;
			while (class2.int_0 < this.class421_0.list_0.Count)
			{
				if (this.class421_0.list_0[class2.int_0].method_5() && !this.class421_0.list_0[class2.int_0].bool_2)
				{
					this.int_26[class2.int_0] = Class331.int_7;
				}
				else if (!this.class421_0.list_0[class2.int_0].method_5() && this.class421_0.list_0[class2.int_0].bool_2 && this.int_26[class2.int_0] != 0)
				{
					int num = Class331.int_7 - this.int_26[class2.int_0];
					if (num < 20)
					{
						this.int_27 += 2;
					}
					else if (num < 38)
					{
						this.int_27++;
					}
					if (num < 100)
					{
						this.int_28++;
					}
				}
				if (!array[class2.int_0] && this.class421_0.list_0[class2.int_0].method_5() && !this.class421_0.list_0[class2.int_0].bool_2)
				{
					if (this.class312_0[class2.int_0] == null)
					{
						List<Class304> arg_465_0 = this.list_3;
						if (predicate == null)
						{
							predicate = new Predicate<Class304>(class2.method_0);
						}
						Class312 class3 = (Class312)arg_465_0.Find(predicate);
						this.class312_0[class2.int_0] = class3;
					}
					if (this.class312_0[class2.int_0] != null)
					{
						this.class312_0[class2.int_0].vmethod_12();
					}
				}
				class2.int_0++;
			}
		}

		// Token: 0x060022D1 RID: 8913
		// RVA: 0x000D1018 File Offset: 0x000CF218
		protected override void vmethod_18()
		{
			this.PreEmpt = Math.Max((int)Class435.smethod_5(0, this.class421_0.class546_0.int_0), this.int_21) + 200;
			this.int_24 = this.int_22 + this.int_23;
			this.class296_0.method_5();
			Class512 class512_ = Class62.class512_0;
			if (class512_ != null && Class876.smethod_6(class512_.class623_0, Mods.Perfect))
			{
				this.bool_2 = true;
			}
			this.method_38(-1);
		}

		// Token: 0x060022CE RID: 8910
		// RVA: 0x000D0EF4 File Offset: 0x000CF0F4
		protected override void vmethod_19(Class305 class305_0)
		{
			Class312 class = class305_0 as Class312;
			if (class != null)
			{
				this.method_37(class);
				return;
			}
			foreach (Class312 current in ((Class315)class305_0).list_2)
			{
				this.method_37(current);
			}
		}

		// Token: 0x060022BF RID: 8895
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		protected override bool vmethod_2()
		{
			return true;
		}

		// Token: 0x060022D0 RID: 8912
		// RVA: 0x000D0FBC File Offset: 0x000CF1BC
		protected override void vmethod_20(Class325 class325_0)
		{
			foreach (Class312 current in ((Class326)class325_0).list_2)
			{
				this.method_37(current);
			}
		}

		// Token: 0x060022CF RID: 8911
		// RVA: 0x000D0F60 File Offset: 0x000CF160
		protected override void vmethod_21(Class320 class320_0)
		{
			foreach (Class312 current in ((Class322)class320_0).list_11)
			{
				this.method_37(current);
			}
		}

		// Token: 0x060022C6 RID: 8902
		// RVA: 0x00006D86 File Offset: 0x00004F86
		protected override bool vmethod_22()
		{
			return false;
		}

		// Token: 0x060022C0 RID: 8896
		// RVA: 0x0001BB71 File Offset: 0x00019D71
		internal override Class304 vmethod_4()
		{
			return this.class304_2;
		}

		// Token: 0x060022C5 RID: 8901
		// RVA: 0x00006D86 File Offset: 0x00004F86
		protected override bool vmethod_5()
		{
			return false;
		}

		// Token: 0x060022C4 RID: 8900
		// RVA: 0x00006D86 File Offset: 0x00004F86
		protected override bool vmethod_6()
		{
			return false;
		}

		// Token: 0x060022C7 RID: 8903
		// RVA: 0x0001BB94 File Offset: 0x00019D94
		internal override Class494 vmethod_7()
		{
			return new Class495(this);
		}

		// Token: 0x060022C9 RID: 8905
		// RVA: 0x000D0BB0 File Offset: 0x000CEDB0
		internal override void vmethod_8(bool bool_3, bool bool_4)
		{
			base.vmethod_8(bool_3, bool_4);
			if (this.class296_0.method_5() == PlayModes.OsuMania)
			{
				float num = Math.Min(10f, Math.Max(0f, 10f - this.class296_0.DifficultyOverall));
				this.int_17 = this.method_34(16.0);
				this.HitWindow300 = this.method_34((double)(34f + 3f * num));
				this.int_18 = this.method_34((double)(67f + 3f * num));
				this.HitWindow100 = this.method_34((double)(97f + 3f * num));
				this.HitWindow50 = this.method_34((double)(121f + 3f * num));
				this.int_16 = this.method_34((double)(158f + 3f * num));
				return;
			}
			if (Math.Round((double)this.class296_0.DifficultyOverall) > 4.0)
			{
				this.int_17 = this.method_34(16.0);
				this.HitWindow300 = this.method_34(34.0);
				this.int_18 = this.method_34(67.0);
				this.HitWindow100 = this.method_34(97.0);
				this.HitWindow50 = this.method_34(121.0);
				this.int_16 = this.method_34(158.0);
				return;
			}
			this.int_17 = this.method_34(16.0);
			this.HitWindow300 = this.method_34(47.0);
			this.int_18 = this.method_34(77.0);
			this.HitWindow100 = this.method_34(97.0);
			this.HitWindow50 = this.method_34(121.0);
			this.int_16 = this.method_34(158.0);
		}
	}
}
