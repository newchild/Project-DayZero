using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns18;
using ns23;
using ns24;
using ns26;
using ns29;
using ns3;
using ns59;
using ns60;
using ns64;
using ns70;
using ns76;
using ns77;
using ns79;
using ns80;
using ns81;
using ns82;
using ns89;
using osu.GameplayElements.HitObjects;
using osu.Graphics.Sprites;
using osu.Input;
using osu_common;
using osu_common.Bancho.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns71
{
	// Token: 0x020003D8 RID: 984
	internal class Class429 : Class427
	{
		// Token: 0x020003D9 RID: 985
		internal sealed class Class436 : IComparer<Class14>
		{
			// Token: 0x06001FA8 RID: 8104
			// RVA: 0x00019E1E File Offset: 0x0001801E
			public int Compare(Class14 x, Class14 y)
			{
				return x.int_0.CompareTo(y.int_0);
			}
		}

		// Token: 0x040018F7 RID: 6391
		private Class531 class531_2;

		// Token: 0x040018F9 RID: 6393
		private Class731 class731_1;

		// Token: 0x040018FA RID: 6394
		private static IComparer<Class14> icomparer_0 = new Class429.Class436();

		// Token: 0x040018F8 RID: 6392
		private List<Class531> list_0 = new List<Class531>();

		// Token: 0x040018FB RID: 6395
		[CompilerGenerated]
		private static Predicate<Class746> predicate_1;

		// Token: 0x040018FC RID: 6396
		[CompilerGenerated]
		private static Predicate<Class746> predicate_2;

		// Token: 0x06001F93 RID: 8083
		// RVA: 0x00019D4E File Offset: 0x00017F4E
		public Class429(Class62 class62_1) : base(class62_1)
		{
		}

		// Token: 0x06001F94 RID: 8084
		// RVA: 0x00019D62 File Offset: 0x00017F62
		internal override void Initialize()
		{
			Class802.bool_11 = false;
			this.class731_1 = Class885.Load("cursor-smoke", Enum112.flag_6);
			base.Initialize();
		}

		// Token: 0x06001F9D RID: 8093
		// RVA: 0x000B3344 File Offset: 0x000B1544
		private void method_6()
		{
			if (this.list_0.Count > 0)
			{
				int num = 0;
				foreach (Class531 current in this.list_0)
				{
					if (current.float_3 != 0f)
					{
						List<Class746> arg_5A_0 = current.class26_0;
						if (Class429.predicate_1 == null)
						{
							Class429.predicate_1 = new Predicate<Class746>(Class429.smethod_5);
						}
						Class746 class = arg_5A_0.Find(Class429.predicate_1);
						class.float_0 = 1f;
						class.int_0 = Class115.int_1 + num;
						class.int_1 = Class115.int_1 + num + 8000;
						class.enum70_0 = Enum70.const_2;
						num += 2;
					}
				}
				this.list_0.Clear();
			}
		}

		// Token: 0x06001FA0 RID: 8096
		// RVA: 0x000B341C File Offset: 0x000B161C
		private static int smethod_2(List<Class14> list_1, Class14 class14_0)
		{
			int i = list_1.BinarySearch(class14_0, Class429.icomparer_0);
			if (i < 0)
			{
				i = ~i;
			}
			else
			{
				while (i < list_1.Count)
				{
					if (class14_0.int_0 != list_1[i].int_0)
					{
						break;
					}
					i++;
				}
			}
			return i;
		}

		// Token: 0x06001FA1 RID: 8097
		// RVA: 0x00019DE5 File Offset: 0x00017FE5
		private static void smethod_3(List<Class14> list_1, Class14 class14_0)
		{
			list_1.Insert(Class429.smethod_2(list_1, class14_0), class14_0);
		}

		// Token: 0x06001FA2 RID: 8098
		// RVA: 0x00019DF5 File Offset: 0x00017FF5
		private static Vector2 smethod_4(float float_0, float float_1)
		{
			return new Vector2((float)(Math.Cos((double)float_0) * (double)float_1), (float)(Math.Sin((double)float_0) * (double)float_1));
		}

		// Token: 0x06001FA5 RID: 8101
		// RVA: 0x0001995D File Offset: 0x00017B5D
		[CompilerGenerated]
		private static bool smethod_5(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Fade;
		}

		// Token: 0x06001FA6 RID: 8102
		// RVA: 0x0001925A File Offset: 0x0001745A
		[CompilerGenerated]
		private static bool smethod_6(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Movement;
		}

		// Token: 0x06001F98 RID: 8088
		// RVA: 0x000B2F00 File Offset: 0x000B1100
		internal override bool vmethod_12()
		{
			if (!Class62.bool_12 && (this.class297_0.int_13 + 1 >= this.class297_0.int_14 || Math.Abs(this.class297_0.list_3[this.class297_0.int_13 + 1].StartTime - Class331.int_7) > 3000) && Vector2.Distance(Class800.smethod_19(), this.vector2_0) < 3f && !Class802.bool_8 && !Class802.bool_23)
			{
				this.double_4 += Class115.double_9;
			}
			else
			{
				this.double_4 = 0.0;
			}
			this.vector2_0 = Class800.smethod_19();
			return this.double_4 > 3000.0 && !Class802.smethod_0();
		}

		// Token: 0x06001F97 RID: 8087
		// RVA: 0x000B2EAC File Offset: 0x000B10AC
		internal override void vmethod_19()
		{
			base.vmethod_19();
			Class885.smethod_27("particle50", Enum112.flag_6, true);
			Class885.smethod_27("particle100", Enum112.flag_6, true);
			Class885.smethod_27("particle300", Enum112.flag_6, true);
			Class885.smethod_27("sliderpoint30", Enum112.flag_6, true);
			Class885.smethod_27("sliderpoint10", Enum112.flag_6, true);
		}

		// Token: 0x06001F96 RID: 8086
		// RVA: 0x000B2E48 File Offset: 0x000B1048
		internal override void vmethod_22()
		{
			if (this.class410_0 == null)
			{
				return;
			}
			this.class410_0.double_1 = this.vmethod_52();
			if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.HalfTime))
			{
				this.class410_0.double_1 *= 0.75;
			}
			base.vmethod_22();
		}

		// Token: 0x06001F99 RID: 8089
		// RVA: 0x00019D96 File Offset: 0x00017F96
		internal override void vmethod_26()
		{
			if (Class341.class606_12)
			{
				this.class731_0 = Class885.smethod_27("comboburst", Enum112.flag_6, true);
			}
			base.vmethod_26();
		}

		// Token: 0x06001F95 RID: 8085
		// RVA: 0x00019D81 File Offset: 0x00017F81
		internal override Class297 vmethod_27()
		{
			if (Class62.smethod_1())
			{
				return new Class299();
			}
			return new Class298(true);
		}

		// Token: 0x06001FA3 RID: 8099
		// RVA: 0x000B3464 File Offset: 0x000B1664
		internal override void vmethod_29()
		{
			int num = 0;
			bool flag;
			Enum70 enum = (flag = Class876.smethod_5(Mods.Relax2)) ? Enum70.const_8 : Enum70.const_1;
			Class802.class512_0.list_1 = new List<Class14>();
			List<Class14> list_ = Class802.class512_0.list_1;
			Class429.smethod_3(list_, new Class14(-100000, 256f, 500f, pButtonState.None));
			Class429.smethod_3(list_, new Class14(this.class297_0.list_3[0].StartTime - 1500, 256f, 500f, pButtonState.None));
			Class429.smethod_3(list_, new Class14(this.class297_0.list_3[0].StartTime - 1000, 256f, 192f, pButtonState.None));
			Vector2 vector;
			vector..ctor(256f, 192f);
			int num2 = (int)Class297.smethod_7(100.0);
			for (int i = 0; i < this.class297_0.int_14; i++)
			{
				Class304 class = this.class297_0.list_3[i];
				int num3 = 0;
				if (class is Class328)
				{
					num3 = 1;
				}
				if (flag && i > 0)
				{
					Class304 class2 = this.class297_0.list_3[i - 1];
					if (class.StartTime - 400 > class2.EndTime + this.class297_0.HitWindow50 + 50)
					{
						if (!(class2 is Class325) && class.StartTime - class2.EndTime < 1000)
						{
							Class429.smethod_3(list_, new Class14(class2.EndTime + this.class297_0.HitWindow50, class2.EndPosition.X, class2.EndPosition.Y, pButtonState.None));
						}
						if (!(class is Class325))
						{
							Class429.smethod_3(list_, new Class14(class.StartTime - 400, class.Position.X, class.Position.Y, pButtonState.None));
						}
					}
					else if (class.StartTime - this.class297_0.HitWindow50 > class2.EndTime + this.class297_0.HitWindow50 + 50)
					{
						if (!(class2 is Class325) && class.StartTime - class2.EndTime < 1000)
						{
							Class429.smethod_3(list_, new Class14(class2.EndTime + this.class297_0.HitWindow50, class2.EndPosition.X, class2.EndPosition.Y, pButtonState.None));
						}
						if (!(class is Class325))
						{
							Class429.smethod_3(list_, new Class14(class.StartTime - this.class297_0.HitWindow50, class.Position.X, class.Position.Y, pButtonState.None));
						}
					}
					else if (class.StartTime - this.class297_0.HitWindow100 > class2.EndTime + this.class297_0.HitWindow100 + 50)
					{
						if (!(class2 is Class325) && class.StartTime - class2.EndTime < 1000)
						{
							Class429.smethod_3(list_, new Class14(class2.EndTime + this.class297_0.HitWindow100, class2.EndPosition.X, class2.EndPosition.Y, pButtonState.None));
						}
						if (!(class is Class325))
						{
							Class429.smethod_3(list_, new Class14(class.StartTime - this.class297_0.HitWindow100, class.Position.X, class.Position.Y, pButtonState.None));
						}
					}
				}
				Vector2 vector2 = class.Position;
				Enum70 enum70_ = enum;
				float num4 = -1f;
				if (class is Class325)
				{
					vector2.X = list_[list_.Count - 1].float_0;
					vector2.Y = list_[list_.Count - 1].float_1;
					Vector2 vector3 = vector - vector2;
					float num5 = vector3.Length();
					float num6 = (float)Math.Sqrt((double)(num5 * num5 - 2500f));
					if (num5 > 50f)
					{
						float num7 = (float)Math.Asin((double)(50f / num5));
						if (num7 > 0f)
						{
							num4 = -1f;
						}
						else
						{
							num4 = 1f;
						}
						vector3.X = vector3.X * (float)Math.Cos((double)num7) - vector3.Y * (float)Math.Sin((double)num7);
						vector3.Y = vector3.X * (float)Math.Sin((double)num7) + vector3.Y * (float)Math.Cos((double)num7);
						vector3.Normalize();
						vector3 *= num6;
						vector2 += vector3;
						enum70_ = Enum70.const_2;
					}
					else if (vector3.Length() > 0f)
					{
						vector2 = vector - vector3 * (50f / vector3.Length());
					}
					else
					{
						vector2 = vector + new Vector2(0f, -50f);
					}
				}
				if (list_.Count > 0)
				{
					Class14 class3 = list_[list_.Count - 1];
					int num8 = class.StartTime - (int)Math.Max(0.0, (double)(this.class297_0.PreEmpt - num2));
					if (num8 > class3.int_0)
					{
						class3 = new Class14(num8, class3.float_0, class3.float_1, class3.pButtonState_0);
						Class429.smethod_3(list_, class3);
					}
					Vector2 vector4;
					vector4..ctor(class3.float_0, class3.float_1);
					Class298 class4 = this.class297_0 as Class298;
					double num9 = Class297.smethod_8((double)(class.StartTime - class3.int_0), Class876.class623_0);
					if (class4 != null && num9 > 0.0 && ((double)(vector4 - vector2).Length() > (double)class4.HitObjectRadius * (1.5 + 100.0 / num9) || num9 >= 266.0))
					{
						for (float num10 = (float)class3.int_0 + 16.666666f; num10 < (float)class.StartTime; num10 += 16.666666f)
						{
							Vector2 vector5 = Class778.smethod_15(vector4, vector2, (double)num10, (double)class3.int_0, (float)class.StartTime, enum70_);
							Class429.smethod_3(list_, new Class14((int)num10, vector5.X, vector5.Y, class3.pButtonState_0));
						}
						num = 0;
					}
					else
					{
						num++;
					}
				}
				pButtonState pButtonState = (num % 2 == 0) ? pButtonState.Left1 : pButtonState.Right1;
				Class14 class5 = new Class14(class.StartTime, vector2.X, vector2.Y, pButtonState);
				Class14 class6 = new Class14(class.EndTime + num3, class.EndPosition.X, class.EndPosition.Y, pButtonState.None);
				int num11 = Class429.smethod_2(list_, class5) - 1;
				if (num11 >= 0)
				{
					Class14 class7 = list_[num11];
					pButtonState pButtonState_ = class7.pButtonState_0;
					if (pButtonState_ != pButtonState.None)
					{
						if (pButtonState_ == pButtonState)
						{
							pButtonState = ((pButtonState.Left1 | pButtonState.Right1) & ~pButtonState);
							class5.method_0(pButtonState);
						}
						int num12 = Class429.smethod_2(list_, class6);
						list_.RemoveRange(num11 + 1, num12 - (num11 + 1));
						for (int j = num11 + 1; j < list_.Count; j++)
						{
							if (j < list_.Count - 1 || list_[j].pButtonState_0 == pButtonState_)
							{
								list_[j].method_0(pButtonState);
							}
						}
					}
				}
				Class429.smethod_3(list_, class5);
				if (class is Class328)
				{
					Vector2 vector6 = vector2 - vector;
					float num13 = vector6.Length();
					float num14 = (num13 == 0f) ? 0f : ((float)Math.Atan2((double)vector6.Y, (double)vector6.X));
					float num16;
					for (float num15 = (float)class.StartTime + 16.666666f; num15 < (float)class.EndTime; num15 += 16.666666f)
					{
						num16 = (num15 - (float)class.StartTime) * num4;
						Vector2 vector7 = vector + Class429.smethod_4(num16 / 20f + num14, 50f);
						Class429.smethod_3(list_, new Class14((int)num15, vector7.X, vector7.Y, pButtonState));
					}
					num16 = (float)(class.EndTime - class.StartTime) * num4;
					Vector2 vector8 = vector + Class429.smethod_4(num16 / 20f + num14, 50f);
					Class429.smethod_3(list_, new Class14(class.EndTime, vector8.X, vector8.Y, pButtonState));
					class6.float_0 = vector8.X;
					class6.float_1 = vector8.Y;
				}
				else if (class is Class321)
				{
					Class321 class8 = class as Class321;
					int num17 = 0;
					List<Class746> arg_8CF_0 = class8.class538_1.class26_0;
					if (Class429.predicate_2 == null)
					{
						Class429.predicate_2 = new Predicate<Class746>(Class429.smethod_6);
					}
					foreach (Class746 current in arg_8CF_0.FindAll(Class429.predicate_2))
					{
						if (num17 == 0 || (float)(current.int_0 - num17) >= 16.666666f)
						{
							Class429.smethod_3(list_, new Class14(current.int_0, current.vector2_0.X, current.vector2_0.Y, pButtonState));
							num17 = current.int_0;
						}
					}
					Class429.smethod_3(list_, new Class14(class.EndTime, class.EndPosition.X, class.EndPosition.Y, pButtonState));
				}
				if (list_[list_.Count - 1].int_0 <= class6.int_0)
				{
					Class429.smethod_3(list_, class6);
				}
			}
			Class62.class512_0.list_1 = Class802.class512_0.list_1;
			Class62.class512_0.string_2 = "osu!";
		}

		// Token: 0x06001F9B RID: 8091
		// RVA: 0x000B302C File Offset: 0x000B122C
		internal override void vmethod_31()
		{
			if (this.class531_0 != null)
			{
				Vector2 vector2_;
				vector2_..ctor(Math.Max(0f, Math.Min(640f, (Class802.class531_0.vector2_1.X - (float)Class115.int_26) / Class115.float_4)) + Class115.smethod_45(), Math.Max(0f, Math.Min(480f, Class802.class531_0.vector2_1.Y / Class115.float_4)));
				if (this.class531_0 != null)
				{
					this.class531_0.vector2_1 = Class778.smethod_15(this.class531_0.vector2_1, vector2_, (double)((float)Class115.double_9), 0.0, 120f, Enum70.const_1);
				}
			}
			base.vmethod_31();
		}

		// Token: 0x06001F9A RID: 8090
		// RVA: 0x000B2FD4 File Offset: 0x000B11D4
		internal override void vmethod_34()
		{
			if (this.class410_0 != null && this.class62_0.bool_30)
			{
				this.class410_0.vmethod_11(this.class410_0.double_1 / 1.0 * (double)(Class331.int_7 - Class331.int_9));
			}
			base.vmethod_34();
		}

		// Token: 0x06001F9C RID: 8092
		// RVA: 0x000B30EC File Offset: 0x000B12EC
		internal override void vmethod_36()
		{
			if (Class115.bool_13)
			{
				if ((!Class802.smethod_0() && Class570.smethod_9(Class795.smethod_3(Bindings.OsuSmoke))) || (Class802.smethod_0() && Class802.class14_0 != null && (Class802.class14_0.pButtonState_0 & pButtonState.Smoke) > pButtonState.None))
				{
					float num = (this.class531_2 != null) ? Vector2.Distance(this.class531_2.vector2_1, Class802.vector2_0) : 0f;
					float num2 = Math.Max(2f, (this.class531_2 != null) ? ((float)this.class531_2.int_4 * 0.625f * Class115.float_4 / 4f) : 0f);
					int num3 = Math.Max(1, (int)(num / num2));
					Vector2 vector2_ = Class802.vector2_0;
					if (this.class531_2 == null || this.class531_2.vector2_1 != vector2_)
					{
						Vector2 vector = (this.class531_2 != null) ? (this.class531_2.vector2_1 + Vector2.Normalize(vector2_ - this.class531_2.vector2_1) * Math.Min(num, num2)) : Class802.vector2_0;
						for (int i = 0; i < num3; i++)
						{
							Class531 class = new Class531(this.class731_1, Enum115.const_15, Origins.Centre, Enum114.const_0, Vector2.Lerp(vector, vector2_, (float)i / (float)num3), 1f, false, Color.get_White(), null);
							class.bool_7 = true;
							class.float_3 = 0.6f;
							class.float_2 = 0.5f;
							class.float_1 = Class562.smethod_5(10f);
							class.method_27(class.float_1 + Class562.smethod_6(-0.25f, 0.25f), 500, Enum70.const_1);
							class.method_26(class.float_2 * 1f, 2000, Enum70.const_1);
							class.method_16(4000, Enum70.const_0);
							this.class62_0.class911_4.Add(class);
							this.list_0.Add(class);
							this.class531_2 = class;
						}
					}
					if (this.list_0.Count > 50 && Vector2.Distance(this.class531_2.vector2_1, this.list_0[0].vector2_1) < 10f)
					{
						this.method_6();
					}
				}
				else
				{
					this.method_6();
					this.class531_2 = null;
				}
			}
			base.vmethod_36();
		}

		// Token: 0x06001F9E RID: 8094
		// RVA: 0x00019DBC File Offset: 0x00017FBC
		internal override void vmethod_41(Enum61 enum61_0, Class304 class304_0)
		{
			if (class304_0.LastInCombo && class304_0.bool_0 && enum61_0 != Enum61.flag_5)
			{
				this.class62_0.method_60(enum61_0);
			}
			base.vmethod_41(enum61_0, class304_0);
		}

		// Token: 0x06001F9F RID: 8095
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal override bool vmethod_51()
		{
			return true;
		}

		// Token: 0x06001FA4 RID: 8100
		// RVA: 0x000B3E58 File Offset: 0x000B2058
		internal virtual double vmethod_52()
		{
			double num = 0.05;
			double num2 = this.class297_0.MapDifficultyRange((double)Class466.Current.DifficultyHpDrainRate, 195.0, 160.0, 60.0);
			double num3 = this.class297_0.MapDifficultyRange((double)Class466.Current.DifficultyHpDrainRate, 198.0, 170.0, 80.0);
			double num4 = this.class297_0.MapDifficultyRange((double)Class466.Current.DifficultyHpDrainRate, 198.0, 180.0, 80.0);
			double num5 = this.class297_0.MapDifficultyRange((double)Class466.Current.DifficultyHpDrainRate, 8.0, 4.0, 0.0);
			while (true)
			{
				IL_423:
				this.int_1 = 0;
				this.class410_0.Reset();
				this.class413_0.vmethod_1(0);
				Class62.class512_0.int_3 = 0;
				double num6 = this.class410_0.method_2();
				int num7 = this.class297_0.list_3[0].StartTime - this.class297_0.PreEmpt;
				bool flag = false;
				int count = this.class62_0.class872_0.list_0.Count;
				int num8 = 0;
				int num9 = 0;
				int i = 0;
				while (i < this.class297_0.int_14)
				{
					Class304 class = this.class297_0.list_3[i];
					int num10 = num7;
					int num11 = 0;
					if (count > 0 && num8 < count)
					{
						Class702 class2 = this.class62_0.class872_0.list_0[num8];
						if (class2.int_2 >= num10 && class2.int_0 <= class.StartTime)
						{
							num11 = ((Class466.Current.int_6 < 8) ? class2.Length : (class2.int_0 - num10));
							num8++;
						}
					}
					this.class410_0.vmethod_11(num * (double)(class.StartTime - num7 - num11));
					num7 = class.EndTime;
					if (this.class410_0.method_2() < num6)
					{
						num6 = this.class410_0.method_2();
					}
					if (this.class410_0.method_2() > num2)
					{
						this.class410_0.vmethod_11(num * (double)(class.EndTime - class.StartTime));
						if (class.IsType(HitObjectType.Slider))
						{
							Class321 class3 = (Class321)class;
							int num12 = class3.list_6.Count + 2;
							int num13 = class3.list_7.Count - class3.list_6.Count - 1;
							this.int_1 += num12 + num13 - 1;
							for (int j = 0; j < num12; j++)
							{
								this.vmethod_41(Enum61.flag_12, class);
							}
							for (int k = 0; k < num13; k++)
							{
								this.vmethod_41(Enum61.flag_9, class);
							}
						}
						else if (class.IsType(HitObjectType.Spinner))
						{
							Class328 class4 = (Class328)class;
							for (int l = 0; l < class4.int_9; l++)
							{
								this.vmethod_41(Enum61.flag_25, class);
							}
						}
						if (i != this.class297_0.int_14 - 1 && !this.class297_0.list_3[i + 1].NewCombo)
						{
							this.vmethod_41(Enum61.flag_16, class);
						}
						else
						{
							this.vmethod_41(Enum61.flag_22, class);
							if (this.class410_0.method_2() < num3 && ++num9 > 2)
							{
								this.double_0 *= 1.07;
								this.double_1 *= 1.03;
								flag = true;
								break;
							}
						}
						this.int_1++;
						class.double_0 = this.class410_0.method_2();
						i++;
						continue;
					}
					flag = true;
					num *= 0.96;
					IL_366:
					if (!flag && this.class410_0.method_2() < num4)
					{
						flag = true;
						num *= 0.94;
						this.double_0 *= 1.01;
						this.double_1 *= 1.01;
					}
					double num14 = (this.class410_0.method_4() - 200.0) / (double)this.class297_0.int_14;
					if (!flag && num14 < num5)
					{
						flag = true;
						num *= 0.96;
						this.double_0 *= 1.02;
						this.double_1 *= 1.01;
					}
					if (flag)
					{
						goto IL_423;
					}
					goto IL_4A5;
				}
				goto IL_366;
			}
			IL_4A5:
			if (Class115.bool_25)
			{
				Class63 class5 = this.class62_0 as Class63;
				if (class5 != null)
				{
					class5.int_38 = Class62.class512_0.int_3;
					class5.int_37 = this.class413_0.vmethod_0();
				}
			}
			return num;
		}
	}
}
