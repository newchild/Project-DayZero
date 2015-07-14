using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns18;
using ns22;
using ns23;
using ns24;
using ns26;
using ns29;
using ns3;
using ns42;
using ns59;
using ns60;
using ns64;
using ns69;
using ns73;
using ns76;
using ns77;
using ns79;
using ns8;
using ns80;
using ns81;
using ns82;
using ns89;
using ns90;
using osu.GameModes.Play.Components;
using osu.GameplayElements.HitObjects;
using osu.Graphics.Sprites;
using osu_common;
using osu_common.Bancho.Objects;
using osu_common.Helpers;
using osu_gameplay;
using osudata;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns70
{
	// Token: 0x020003D1 RID: 977
	internal abstract class Class427 : IDisposable
	{
		// Token: 0x040018BB RID: 6331
		internal bool bool_0;

		// Token: 0x040018D0 RID: 6352
		protected bool bool_1;

		// Token: 0x040018BF RID: 6335
		internal Class103 class103_0;

		// Token: 0x040018B9 RID: 6329
		internal Class297 class297_0;

		// Token: 0x040018C7 RID: 6343
		private Class339 class339_0;

		// Token: 0x040018BA RID: 6330
		internal Class410 class410_0;

		// Token: 0x040018B7 RID: 6327
		internal Class413 class413_0;

		// Token: 0x040018CC RID: 6348
		public static Class427 class427_0;

		// Token: 0x040018B8 RID: 6328
		internal Class512 class512_0;

		// Token: 0x040018C5 RID: 6341
		internal Class531 class531_0;

		// Token: 0x040018C6 RID: 6342
		protected Class531 class531_1;

		// Token: 0x040018BC RID: 6332
		protected Class62 class62_0;

		// Token: 0x040018BE RID: 6334
		protected internal Class666 class666_0;

		// Token: 0x040018C4 RID: 6340
		protected Class731[] class731_0;

		// Token: 0x040018B5 RID: 6325
		protected readonly Class911 class911_0;

		// Token: 0x040018B6 RID: 6326
		protected readonly Class911 class911_1;

		// Token: 0x040018C0 RID: 6336
		protected Class911 class911_2;

		// Token: 0x040018C1 RID: 6337
		protected Class911 class911_3;

		// Token: 0x040018C8 RID: 6344
		internal double double_0 = 1.0;

		// Token: 0x040018C9 RID: 6345
		internal double double_1 = 1.0;

		// Token: 0x040018CA RID: 6346
		internal double double_2 = 1.0;

		// Token: 0x040018CB RID: 6347
		private double double_3 = (double)Class420.int_3;

		// Token: 0x040018CD RID: 6349
		protected double double_4;

		// Token: 0x040018BD RID: 6333
		internal int int_0;

		// Token: 0x040018C2 RID: 6338
		internal int int_1;

		// Token: 0x040018C3 RID: 6339
		protected int int_2;

		// Token: 0x040018CF RID: 6351
		internal int int_3;

		// Token: 0x040018D2 RID: 6354
		[CompilerGenerated]
		private static Predicate<Class746> predicate_0;

		// Token: 0x040018CE RID: 6350
		protected Vector2 vector2_0;

		// Token: 0x040018D1 RID: 6353
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_0;

		// Token: 0x06001F0E RID: 7950
		// RVA: 0x000AE65C File Offset: 0x000AC85C
		internal Class427(Class62 class62_1)
		{
			Class427.class427_0 = this;
			this.class62_0 = class62_1;
			this.class911_0 = class62_1.class911_7;
			this.class911_1 = class62_1.class911_8;
			this.class911_2 = class62_1.class911_3;
			this.class297_0 = this.vmethod_27();
			class62_1.method_66(new Delegate55(this.vmethod_15));
			Class115.smethod_53(new Delegate1(this.vmethod_2));
		}

		// Token: 0x06001F1C RID: 7964
		// RVA: 0x000AE7C8 File Offset: 0x000AC9C8
		public virtual void Dispose()
		{
			Class427.class427_0 = null;
			if (this.class339_0 != null)
			{
				this.class339_0.method_11(true);
			}
			this.class62_0.method_67(new Delegate55(this.vmethod_15));
			if (this.class103_0 != null)
			{
				this.class103_0.Dispose();
			}
			if (this.class531_0 != null)
			{
				this.class531_0.bool_6 = true;
			}
			if (this.class911_3 != null)
			{
				this.class911_3.Dispose();
			}
			Class115.smethod_54(new Delegate1(this.vmethod_2));
		}

		// Token: 0x06001F30 RID: 7984
		// RVA: 0x000AEE14 File Offset: 0x000AD014
		internal virtual void Draw()
		{
			if (!this.bool_0)
			{
				return;
			}
			this.class666_0.Draw();
			if (this.class410_0 != null)
			{
				this.class410_0.Draw();
			}
			this.vmethod_31();
			if (this.class103_0 != null)
			{
				this.class103_0.Draw();
			}
		}

		// Token: 0x06001F1E RID: 7966
		// RVA: 0x000197E6 File Offset: 0x000179E6
		internal virtual void Initialize()
		{
			this.vmethod_23();
			this.vmethod_26();
			this.vmethod_20();
			this.vmethod_28();
			this.vmethod_18();
			this.vmethod_17();
			this.vmethod_22();
			this.vmethod_16();
			this.bool_0 = true;
		}

		// Token: 0x06001F2D RID: 7981
		// RVA: 0x0001987C File Offset: 0x00017A7C
		internal void method_0()
		{
			if (this.class410_0 != null)
			{
				this.class410_0.vmethod_3();
			}
			if (this.class413_0 != null)
			{
				this.class413_0.vmethod_4();
			}
		}

		// Token: 0x06001F2E RID: 7982
		// RVA: 0x000198A4 File Offset: 0x00017AA4
		internal void method_1()
		{
			if (this.class410_0 != null)
			{
				this.class410_0.vmethod_4();
			}
			if (this.class413_0 != null)
			{
				this.class413_0.vmethod_5();
			}
		}

		// Token: 0x06001F32 RID: 7986
		// RVA: 0x000AF16C File Offset: 0x000AD36C
		internal void method_2()
		{
			if (!this.bool_0)
			{
				return;
			}
			this.vmethod_33();
			this.vmethod_34();
			if (this.class410_0 != null)
			{
				this.class410_0.vmethod_5();
			}
			this.vmethod_35();
			if (this.class103_0 != null)
			{
				this.class103_0.imethod_2();
			}
		}

		// Token: 0x06001F39 RID: 7993
		// RVA: 0x000AF3F8 File Offset: 0x000AD5F8
		internal void method_3(bool bool_2)
		{
			if (this.class410_0.method_2() < 160.0)
			{
				this.class410_0.vmethod_12(160.0);
				this.class410_0.bool_0 = true;
				this.class410_0.double_0 = 0.079999998211860657;
				this.class410_0.vmethod_7(Color.get_Red());
				this.class410_0.vmethod_7(Color.get_White());
			}
			if (!bool_2)
			{
				Class62.bool_13 = true;
				Class331.smethod_88();
				Class331.smethod_59("readys", 100, Enum112.flag_6);
			}
			this.class62_0.method_35(false);
			this.int_0--;
		}

		// Token: 0x06001F3B RID: 7995
		// RVA: 0x000198E3 File Offset: 0x00017AE3
		internal void method_4()
		{
			this.class512_0 = Class62.class512_0;
			if (!this.bool_0)
			{
				return;
			}
			if (this.class413_0 != null)
			{
				this.class413_0.Reset();
			}
			if (this.class410_0 != null)
			{
				this.class410_0.Reset();
			}
		}

		// Token: 0x06001F42 RID: 8002
		// RVA: 0x000B0BE0 File Offset: 0x000AEDE0
		internal void method_5()
		{
			this.class62_0.float_1 = 1f;
			this.class62_0.class872_0.method_8(1f);
			for (int i = 0; i < 50; i++)
			{
				int num = Class331.int_7 + i * 10;
				int int_ = num + Class562.smethod_1(300, 1000);
				Class746 class = new Class746(TransformationType.Scale, 1f, Class562.smethod_6(1f, Class341.class606_46 ? 2.1f : 2.8f), num, int_, Enum70.const_0);
				Class746 class2 = new Class746(TransformationType.Fade, 1f, 0f, num, int_, Enum70.const_0);
				Class746 class3 = new Class746(TransformationType.Rotation, Class562.smethod_6(-2f, 2f), Class562.smethod_6(-2f, 2f), num, int_, Enum70.const_0);
				class.enum70_0 = Enum70.const_1;
				class2.enum70_0 = Enum70.const_1;
				class3.enum70_0 = Enum70.const_1;
				Vector2 vector2_;
				vector2_..ctor(30f, 490f);
				Class531 class4 = new Class531(this.class62_0.class731_0, Enum115.const_5, Origins.Centre, Enum114.const_1, vector2_, 0.05f, false, Color.get_White(), null);
				class4.class26_0.Add(class);
				class4.class26_0.Add(class2);
				class4.class26_0.Add(class3);
				this.class911_2.Add(class4);
				Class115.class729_0.Add(class4, new Vector2?(new Vector2((float)Class562.smethod_1(300, 450), (float)Class562.smethod_1(-800, -700))), false).float_0 = 60f;
				vector2_..ctor((float)(Class115.smethod_43() - 30), 490f);
				Class531 class5 = new Class531(this.class62_0.class731_0, Enum115.const_5, Origins.Centre, Enum114.const_1, vector2_, 0.05f, false, Color.get_White(), null);
				class5.class26_0.Add(class);
				class5.class26_0.Add(class2);
				class5.class26_0.Add(class3);
				this.class911_2.Add(class5);
				Class115.class729_0.Add(class5, new Vector2?(new Vector2((float)Class562.smethod_1(-450, -300), (float)Class562.smethod_1(-800, -700))), false).float_0 = 60f;
			}
		}

		// Token: 0x06001F4A RID: 8010
		// RVA: 0x00019948 File Offset: 0x00017B48
		[CompilerGenerated]
		private static void smethod_0()
		{
			Class62.enum43_0 |= Enum43.flag_5;
			Class62.bool_18 = false;
		}

		// Token: 0x06001F4B RID: 8011
		// RVA: 0x0001995D File Offset: 0x00017B5D
		[CompilerGenerated]
		private static bool smethod_1(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Fade;
		}

		// Token: 0x06001F0C RID: 7948
		// RVA: 0x0001975E File Offset: 0x0001795E
		internal virtual Vector2 vmethod_0()
		{
			return new Vector2(0f, 205f);
		}

		// Token: 0x06001F0D RID: 7949
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal virtual bool vmethod_1()
		{
			return false;
		}

		// Token: 0x06001F17 RID: 7959
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal virtual bool vmethod_10()
		{
			return true;
		}

		// Token: 0x06001F18 RID: 7960
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal virtual bool vmethod_11()
		{
			return true;
		}

		// Token: 0x06001F19 RID: 7961
		// RVA: 0x000AE70C File Offset: 0x000AC90C
		internal virtual bool vmethod_12()
		{
			if (Class62.bool_12)
			{
				return false;
			}
			if (Vector2.Distance(Class800.smethod_19(), this.vector2_0) < 10f)
			{
				this.double_4 += Class115.double_9;
			}
			else
			{
				this.double_4 = 0.0;
			}
			this.vector2_0 = Class800.smethod_19();
			return this.double_4 > 1000.0;
		}

		// Token: 0x06001F1A RID: 7962
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal virtual bool vmethod_13()
		{
			return true;
		}

		// Token: 0x06001F1B RID: 7963
		// RVA: 0x000AE778 File Offset: 0x000AC978
		internal virtual bool vmethod_14()
		{
			return this.class413_0.vmethod_0() == 30 || this.class413_0.vmethod_0() == 60 || (this.class413_0.vmethod_0() > 99 && this.class413_0.vmethod_0() % 50 == 0);
		}

		// Token: 0x06001F1D RID: 7965
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void vmethod_15(Class304 class304_0)
		{
		}

		// Token: 0x06001F1F RID: 7967
		// RVA: 0x000AE854 File Offset: 0x000ACA54
		internal virtual void vmethod_16()
		{
			float float_ = this.class297_0.class911_0.float_4;
			if (this.class911_0 != null)
			{
				this.class911_0.float_4 = float_;
			}
			if (this.class911_2 != null)
			{
				this.class911_2.float_4 = float_;
			}
			if (this.class911_3 != null)
			{
				this.class911_3.float_4 = float_;
			}
			if (this.class911_1 != null)
			{
				this.class911_1.float_4 = float_;
			}
		}

		// Token: 0x06001F20 RID: 7968
		// RVA: 0x000AE8C4 File Offset: 0x000ACAC4
		protected virtual void vmethod_17()
		{
			if (Class341.class605_7 == ScoreMeterType.Colour)
			{
				this.class103_0 = new Class104(Class115.class115_0, this.class297_0);
				return;
			}
			if (Class341.class605_7 == ScoreMeterType.Error || Class876.smethod_5(Mods.Target))
			{
				if (Class62.smethod_1())
				{
					this.class103_0 = new Class106(Class115.class115_0, this.class297_0);
					return;
				}
				this.class103_0 = new Class105(Class115.class115_0, this.class297_0);
			}
		}

		// Token: 0x06001F21 RID: 7969
		// RVA: 0x0001981F File Offset: 0x00017A1F
		protected virtual void vmethod_18()
		{
			this.class666_0 = new Class666(this.class911_1);
		}

		// Token: 0x06001F22 RID: 7970
		// RVA: 0x000AE944 File Offset: 0x000ACB44
		internal virtual void vmethod_19()
		{
			Class885.smethod_27("hit0", Enum112.flag_6, true);
			Class885.smethod_27("hit50", Enum112.flag_6, true);
			Class885.smethod_27("hit100", Enum112.flag_6, true);
			Class885.smethod_27("hit100k", Enum112.flag_6, true);
			Class885.smethod_27("hit300", Enum112.flag_6, true);
			Class885.smethod_27("hit300g", Enum112.flag_6, true);
			Class885.smethod_27("hit300k", Enum112.flag_6, true);
		}

		// Token: 0x06001F0F RID: 7951
		// RVA: 0x0001976F File Offset: 0x0001796F
		protected virtual void vmethod_2(bool bool_2)
		{
			this.vmethod_24();
		}

		// Token: 0x06001F23 RID: 7971
		// RVA: 0x00019832 File Offset: 0x00017A32
		internal virtual void vmethod_20()
		{
			this.class410_0 = new Class410(this.class911_1);
		}

		// Token: 0x06001F24 RID: 7972
		// RVA: 0x00019845 File Offset: 0x00017A45
		internal virtual void vmethod_21(float float_0)
		{
			this.class911_2.float_0 = float_0;
			this.class297_0.class911_0.float_0 = float_0;
		}

		// Token: 0x06001F25 RID: 7973
		// RVA: 0x000AE9AC File Offset: 0x000ACBAC
		internal virtual void vmethod_22()
		{
			this.method_4();
			if (Class466.Current.int_1 > 0)
			{
				this.class410_0.int_0 = -Class466.Current.int_1;
			}
			if ((double)this.class297_0.list_3[0].StartTime * this.class410_0.double_0 < 200.0)
			{
				this.class410_0.double_0 = 200.0 / (double)(this.class297_0.list_3[0].StartTime + Class466.Current.int_1);
			}
			else if (this.class297_0.list_3[0].StartTime > 10000)
			{
				this.class410_0.int_0 = this.class297_0.list_3[0].StartTime - 10000;
			}
			if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.DoubleTime))
			{
				this.class410_0.double_0 *= 1.5;
			}
		}

		// Token: 0x06001F26 RID: 7974
		// RVA: 0x000AEAC0 File Offset: 0x000ACCC0
		internal virtual void vmethod_23()
		{
			Class62.bool_15 = Class876.smethod_6(Class62.class512_0.class623_0, Mods.Relax);
			Class62.bool_16 = Class876.smethod_6(Class62.class512_0.class623_0, Mods.Relax2);
			this.double_2 = (double)Class466.Current.method_13() * Class876.smethod_8(this.class512_0.class623_0);
			if (!Class876.smethod_6(Class62.class512_0.class623_0, Mods.SuddenDeath) && Class876.smethod_6(Class62.class512_0.class623_0, Mods.Easy))
			{
				this.int_0 = 2;
			}
			if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.Flashlight))
			{
				this.class911_3 = new Class911(true);
				this.class531_0 = new Class531(null, Enum115.const_2, Origins.Centre, Enum114.const_0, Vector2.get_Zero(), 1f, true, Color.get_Black(), null);
				this.vmethod_24();
				this.class911_3.Add(this.class531_0);
				this.class531_1 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, Vector2.get_Zero(), 0.989f, true, Color.get_TransparentBlack(), null);
				this.class531_1.bool_13 = false;
				this.class531_1.vector2_2 = new Vector2((float)Class115.int_22, (float)Class115.int_23);
				this.class911_3.Add(this.class531_1);
			}
		}

		// Token: 0x06001F27 RID: 7975
		// RVA: 0x000AEC24 File Offset: 0x000ACE24
		protected virtual void vmethod_24()
		{
			if (this.class531_0 == null)
			{
				return;
			}
			string name = "flashlightv2";
			this.bool_1 = true;
			byte[] array = ResourcesStore.get_ResourceManager().GetObject(name) as byte[];
			if (array == null)
			{
				this.bool_1 = false;
				name = "flashlight";
				array = (ResourcesStore.get_ResourceManager().GetObject(name) as byte[]);
			}
			byte[] array2 = Class33.smethod_4(array);
			byte[] arg_7D_0;
			if (!this.bool_1)
			{
				RuntimeHelpers.InitializeArray(arg_7D_0 = new byte[16], fieldof(Class918.struct71_0).FieldHandle);
			}
			else
			{
				RuntimeHelpers.InitializeArray(arg_7D_0 = new byte[16], fieldof(Class918.struct71_1).FieldHandle);
			}
			byte[] array3 = arg_7D_0;
			bool flag = false;
			for (int i = 0; i < 16; i++)
			{
				if (array2[i] != array3[i])
				{
					flag = true;
					IL_A3:
					if (flag)
					{
						Class47 arg_CA_0 = Class115.class47_0;
						if (Class427.voidDelegate_0 == null)
						{
							Class427.voidDelegate_0 = new VoidDelegate(Class427.smethod_0);
						}
						arg_CA_0.Add(Class427.voidDelegate_0, true);
					}
					this.class531_0.vmethod_7(Class731.smethod_6(array));
					return;
				}
			}
			goto IL_A3;
		}

		// Token: 0x06001F28 RID: 7976
		// RVA: 0x000AED14 File Offset: 0x000ACF14
		internal virtual void vmethod_25()
		{
			if (Class62.bool_27)
			{
				return;
			}
			if (!string.IsNullOrEmpty(Class466.Current.string_11) && !Class466.Current.bool_23 && !Class341.class606_32)
			{
				if (!Class885.smethod_9(Class466.Current.string_11, false) && !Class62.bool_27)
				{
					Class723.smethod_5("This beatmap is requesting a skin preference of '" + Class466.Current.string_11 + "'.  Please download this skin for the intended experience", Color.get_OrangeRed(), 6000, null);
					return;
				}
			}
			else
			{
				Class885.smethod_9(null, false);
			}
		}

		// Token: 0x06001F29 RID: 7977
		// RVA: 0x000AEDA0 File Offset: 0x000ACFA0
		internal virtual void vmethod_26()
		{
			if (this.vmethod_7() && !Class876.smethod_3(Class62.class512_0.class623_0))
			{
				Class531 class = new Class531(Class885.Load("play-unranked", Enum112.flag_6), Origins.Centre, new Vector2(320f, 45f), 0f, true, Color.get_White());
				class.method_15(2000);
				this.class62_0.class911_7.Add(class);
			}
		}

		// Token: 0x06001F2A RID: 7978
		internal abstract Class297 vmethod_27();

		// Token: 0x06001F2B RID: 7979
		// RVA: 0x00019864 File Offset: 0x00017A64
		internal virtual void vmethod_28()
		{
			this.class413_0 = new Class413(this.class911_1, "");
		}

		// Token: 0x06001F2C RID: 7980
		internal abstract void vmethod_29();

		// Token: 0x06001F10 RID: 7952
		// RVA: 0x00019777 File Offset: 0x00017977
		internal virtual bool vmethod_3()
		{
			return this.class410_0 == null || this.class410_0.method_2() >= 100.0;
		}

		// Token: 0x06001F2F RID: 7983
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void vmethod_30()
		{
		}

		// Token: 0x06001F31 RID: 7985
		// RVA: 0x000AEE64 File Offset: 0x000AD064
		internal virtual void vmethod_31()
		{
			if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.Flashlight))
			{
				if (this.class531_0.vmethod_6() == null || this.class911_3.list_2.Count == 0 || (Class115.bool_27 && !this.class531_0.vmethod_6().class748_0.method_0()) || (Class115.bool_26 && this.class531_0.vmethod_6().method_2() == null))
				{
					if (this.vmethod_7())
					{
						this.class512_0.bool_0 = false;
						this.class62_0.method_4();
					}
					return;
				}
				if (!Class62.bool_11)
				{
					if (Class62.bool_29 && this.class62_0.class531_0 != null)
					{
						this.class531_0.vector2_1 = new Vector2(Math.Max(0f, Math.Min(640f, this.class62_0.class531_0.vector2_1.X / Class115.float_4)), Math.Max(0f, Math.Min(480f, this.class62_0.class531_0.vector2_1.Y / Class115.float_4)));
					}
					Class321 class = this.class62_0.class304_0 as Class321;
					if (class != null && class.bool_12)
					{
						if (!this.class531_1.bool_3)
						{
							this.class531_1.float_3 = 0.8f;
						}
					}
					else if (this.class531_1.bool_3)
					{
						this.class531_1.float_3 = 0f;
					}
					if (Class115.bool_13)
					{
						if (Class872.bool_1)
						{
							if (this.class531_0.float_2 < 8f)
							{
								this.class531_0.float_2 += 0.1f;
							}
						}
						else if (this.class413_0.vmethod_0() < 100)
						{
							if (this.class531_0.float_2 > 3.2f)
							{
								this.class531_0.float_2 -= 0.1f;
							}
							if (this.class531_0.float_2 < 3.2f)
							{
								this.class531_0.float_2 += 0.1f;
							}
						}
						else if (this.class413_0.vmethod_0() < 200)
						{
							if (this.class531_0.float_2 > 2.6f)
							{
								this.class531_0.float_2 -= 0.1f;
							}
							if (this.class531_0.float_2 < 2.6f)
							{
								this.class531_0.float_2 += 0.1f;
							}
						}
						else
						{
							if (this.class531_0.float_2 > 2f)
							{
								this.class531_0.float_2 -= 0.1f;
							}
							if (this.class531_0.float_2 < 2f)
							{
								this.class531_0.float_2 += 0.1f;
							}
						}
					}
				}
				this.class911_3.Draw();
			}
		}

		// Token: 0x06001F33 RID: 7987
		// RVA: 0x000AF1BC File Offset: 0x000AD3BC
		internal virtual void vmethod_32()
		{
			if (this.class62_0.class304_0 != null)
			{
				bool flag = this.class62_0.class304_0 is Class321 && ((Class321)this.class62_0.class304_0).bool_12;
				this.vmethod_41(this.class62_0.class304_0.vmethod_17(Class802.vector2_0), this.class62_0.class304_0);
				bool flag2 = this.class62_0.class304_0 is Class321 && ((Class321)this.class62_0.class304_0).bool_12;
				this.class62_0.bool_21 |= (flag != flag2);
			}
		}

		// Token: 0x06001F34 RID: 7988
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void vmethod_33()
		{
		}

		// Token: 0x06001F35 RID: 7989
		// RVA: 0x000AF270 File Offset: 0x000AD470
		internal virtual void vmethod_34()
		{
			if (this.class410_0 != null && Class876.smethod_6(this.class512_0.class623_0, Mods.SuddenDeath) && this.class512_0.ushort_5 > 0)
			{
				this.class410_0.vmethod_10(0.0);
			}
		}

		// Token: 0x06001F36 RID: 7990
		// RVA: 0x000198CC File Offset: 0x00017ACC
		internal virtual void vmethod_35()
		{
			this.class413_0.vmethod_7();
		}

		// Token: 0x06001F37 RID: 7991
		// RVA: 0x000198D9 File Offset: 0x00017AD9
		internal virtual void vmethod_36()
		{
			if (!this.bool_0)
			{
			}
		}

		// Token: 0x06001F38 RID: 7992
		// RVA: 0x000AF2C0 File Offset: 0x000AD4C0
		internal virtual bool vmethod_37(bool bool_2)
		{
			if (!bool_2)
			{
				if (this.int_0 > 0)
				{
					this.method_3(false);
					return false;
				}
				if (!Class62.bool_6)
				{
					foreach (Class304 current in this.class297_0.list_4)
					{
						current.vmethod_18();
					}
					Class331.smethod_96();
					Class62.bool_6 = true;
					Class62.int_8 = Class331.int_7;
					if (Class62.Mode != PlayModes.OsuMania)
					{
						Class62.class512_0.list_1.Add(new Class14(Class331.int_7 + 5, this.vmethod_6().X, this.vmethod_6().Y, pButtonState.None));
					}
					if (Class876.smethod_6(this.class512_0.class623_0, Mods.Perfect))
					{
						Class62.smethod_4(false);
					}
					else
					{
						this.class339_0 = Class331.smethod_59("failsound", 100, Enum112.flag_6);
					}
				}
				return true;
			}
			else
			{
				if (this.int_0 > 0)
				{
					this.method_3(true);
					return false;
				}
				if (Class62.Mode != PlayModes.OsuMania)
				{
					if (Class62.Mode != PlayModes.Taiko)
					{
						this.class62_0.method_35(true);
						return true;
					}
				}
				return true;
			}
		}

		// Token: 0x06001F3A RID: 7994
		// RVA: 0x000AF4A8 File Offset: 0x000AD6A8
		internal virtual void vmethod_38()
		{
			this.class62_0.bool_25 = true;
			this.class512_0.bool_2 = true;
			this.class512_0.bool_4 = (this.int_1 - this.class512_0.int_0 <= 0);
			if (this.class410_0 != null && this.class410_0.method_6())
			{
				lock (this.class911_0.list_2)
				{
					using (List<Class530>.Enumerator enumerator = this.class911_0.list_2.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Class531 class = (Class531)enumerator.Current;
							class.method_16(700, Enum70.const_0);
						}
					}
				}
				lock (this.class911_2.list_2)
				{
					using (List<Class530>.Enumerator enumerator2 = this.class911_2.list_2.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							Class531 class2 = (Class531)enumerator2.Current;
							class2.method_16(700, Enum70.const_0);
						}
					}
				}
				this.class410_0.method_7(false);
			}
		}

		// Token: 0x06001F3C RID: 7996
		// RVA: 0x000AF610 File Offset: 0x000AD810
		internal virtual void vmethod_39(Enum61 enum61_0, double double_5, Class304 class304_0)
		{
			if (double_5 <= 0.0)
			{
				return;
			}
			if (this.class410_0 != null)
			{
				this.class410_0.vmethod_8();
				if (this.class410_0.method_2() > 180.0)
				{
					this.class410_0.vmethod_9();
				}
			}
		}

		// Token: 0x06001F11 RID: 7953
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal virtual bool vmethod_4()
		{
			return true;
		}

		// Token: 0x06001F3D RID: 7997
		// RVA: 0x000AF660 File Offset: 0x000AD860
		internal virtual bool vmethod_40()
		{
			return !Class872.bool_1 && ((Class62.bool_8 && Class62.bool_15) || (Class115.bool_13 && (Class802.buttonState_0 == 1 || Class802.buttonState_5 == 1)) || Class802.buttonState_0 != Class802.buttonState_1 || Class802.buttonState_5 != Class802.buttonState_6);
		}

		// Token: 0x06001F3E RID: 7998
		// RVA: 0x000AF6B8 File Offset: 0x000AD8B8
		internal virtual void vmethod_41(Enum61 enum61_0, Class304 class304_0)
		{
			if (enum61_0 == Enum61.flag_5)
			{
				return;
			}
			this.class62_0.class304_1 = class304_0;
			bool bool_ = class304_0.bool_5;
			if (this.bool_0)
			{
				this.class62_0.method_9(false);
			}
			bool flag = true;
			int num = 0;
			double num2 = 0.0;
			bool flag2 = false;
			Enum61 enum = enum61_0;
			if (enum > Enum61.flag_5)
			{
				enum &= ~(Enum61.flag_28 | Enum61.flag_31 | Enum61.flag_32);
			}
			Enum61 enum2 = enum;
			double num3;
			if (enum2 <= Enum61.flag_20)
			{
				if (enum2 <= Enum61.flag_9)
				{
					if (enum2 <= Enum61.flag_2)
					{
						if (enum2 == Enum61.flag_0)
						{
							num3 = 0.0;
							goto IL_B78;
						}
						if (enum2 == Enum61.flag_1)
						{
							num3 = this.class297_0.MapDifficultyRange((double)Class466.Current.DifficultyHpDrainRate, -4.0, -15.0, -28.0);
							flag = false;
							goto IL_B78;
						}
						if (enum2 == Enum61.flag_2)
						{
							num3 = this.class297_0.MapDifficultyRange((double)Class466.Current.DifficultyHpDrainRate, -4.0, -15.0, -28.0);
							goto IL_B78;
						}
					}
					else if (enum2 != Enum61.flag_3)
					{
						if (enum2 != Enum61.flag_4)
						{
							switch (enum2)
							{
							case Enum61.flag_40:
								num3 = 0.5 - (double)Class466.Current.DifficultyHpDrainRate * 0.05;
								num = 0;
								goto IL_B78;
							case Enum61.flag_9:
							{
								num = 10;
								num3 = this.double_1 * 3.0;
								Class321 class = this.class62_0.class304_0 as Class321;
								if (class != null && !Class885.smethod_25())
								{
									Class531 class2 = new Class531(Class885.Load("sliderpoint10", Enum112.flag_6), Enum115.const_0, Origins.Centre, Enum114.const_1, class.class538_0.vector2_1, 1f, false, Color.get_White(), null);
									class2.method_23(new Vector2(0f, -10f), 300, Enum70.const_1);
									class2.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class331.int_7 + 300, Class331.int_7 + 360, Enum70.const_0));
									this.class297_0.class911_0.Add(class2);
									goto IL_B78;
								}
								goto IL_B78;
							}
							}
						}
						else
						{
							num3 = (double)(-(double)(Class466.Current.DifficultyHpDrainRate + 1f)) * 1.5;
							if (bool_)
							{
								Class512 expr_262 = this.class512_0;
								expr_262.ushort_5 += 1;
								goto IL_B78;
							}
							goto IL_B78;
						}
					}
					else
					{
						num3 = this.class297_0.MapDifficultyRange((double)Class466.Current.DifficultyHpDrainRate, -6.0, -25.0, -40.0);
						if (bool_)
						{
							Class512 expr_2B4 = this.class512_0;
							expr_2B4.ushort_5 += 1;
							goto IL_B78;
						}
						goto IL_B78;
					}
				}
				else if (enum2 <= Enum61.flag_12)
				{
					if (enum2 != Enum61.flag_10)
					{
						if (enum2 == Enum61.flag_11)
						{
							if (bool_)
							{
								Class512 expr_3C1 = this.class512_0;
								expr_3C1.ushort_4 += 1;
							}
							if (this.bool_0)
							{
								this.int_3++;
							}
							return;
						}
						if (enum2 == Enum61.flag_12)
						{
							num = 30;
							num3 = this.double_1 * 4.0;
							Class321 class3 = this.class62_0.class304_0 as Class321;
							if (class3 != null && !Class885.smethod_25())
							{
								Class531 class4 = new Class531(Class885.Load("sliderpoint30", Enum112.flag_6), Enum115.const_0, Origins.Centre, Enum114.const_1, class3.class538_0.vector2_1, 1f, false, Color.get_White(), null);
								class4.method_23(new Vector2(0f, -10f), 300, Enum70.const_1);
								class4.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class331.int_7 + 300, Class331.int_7 + 360, Enum70.const_0));
								this.class297_0.class911_0.Add(class4);
								goto IL_B78;
							}
							goto IL_B78;
						}
					}
					else
					{
						num = 10;
						flag = false;
						num3 = this.double_1 * 3.0 * 0.10000000149011612;
						if (bool_)
						{
							Class512 expr_413 = this.class512_0;
							expr_413.ushort_2 += 1;
							goto IL_B78;
						}
						goto IL_B78;
					}
				}
				else
				{
					if (enum2 == Enum61.flag_13)
					{
						num = 30;
						num3 = this.double_1 * 4.0;
						goto IL_B78;
					}
					switch (enum2)
					{
					case Enum61.flag_14:
						num = 50;
						flag = !class304_0.IsType(HitObjectType.Slider);
						flag2 = true;
						num3 = this.double_1 * this.class297_0.MapDifficultyRange((double)Class466.Current.DifficultyHpDrainRate, 3.2, 0.4, 0.4);
						if (bool_)
						{
							Class512 expr_63F = this.class512_0;
							expr_63F.ushort_2 += 1;
							goto IL_B78;
						}
						goto IL_B78;
					case Enum61.flag_17:
						num = 50;
						flag = !class304_0.IsType(HitObjectType.Slider);
						flag2 = true;
						num3 = this.double_0 * 6.0 + this.double_1 * this.class297_0.MapDifficultyRange((double)Class466.Current.DifficultyHpDrainRate, 3.2, 0.4, 0.4);
						if (bool_)
						{
							Class512 expr_6BA = this.class512_0;
							expr_6BA.ushort_2 += 1;
							goto IL_B78;
						}
						goto IL_B78;
					default:
						switch (enum2)
						{
						case Enum61.flag_15:
							num = ((this is Class432) ? 150 : 100);
							flag = !class304_0.IsType(HitObjectType.Slider);
							flag2 = true;
							num3 = this.double_1 * this.class297_0.MapDifficultyRange((double)Class466.Current.DifficultyHpDrainRate, 17.6, 2.2, 2.2);
							if (bool_)
							{
								Class512 expr_4CB = this.class512_0;
								expr_4CB.ushort_0 += 1;
								goto IL_B78;
							}
							goto IL_B78;
						case Enum61.flag_18:
							num = 100;
							flag = !class304_0.IsType(HitObjectType.Slider);
							flag2 = true;
							num3 = this.double_0 * 6.0 + this.double_1 * this.class297_0.MapDifficultyRange((double)Class466.Current.DifficultyHpDrainRate, 17.6, 2.2, 2.2);
							if (bool_)
							{
								Class512 expr_546 = this.class512_0;
								expr_546.ushort_0 += 1;
								goto IL_B78;
							}
							goto IL_B78;
						case Enum61.flag_20:
							num = 100;
							flag = !class304_0.IsType(HitObjectType.Slider);
							flag2 = true;
							num3 = this.double_0 * 10.0 + this.double_1 * this.class297_0.MapDifficultyRange((double)Class466.Current.DifficultyHpDrainRate, 17.6, 2.2, 2.2);
							if (bool_)
							{
								Class512 expr_5C1 = this.class512_0;
								expr_5C1.ushort_0 += 1;
								Class512 expr_5D5 = this.class512_0;
								expr_5D5.ushort_4 += 1;
								goto IL_B78;
							}
							goto IL_B78;
						}
						break;
					}
				}
			}
			else if (enum2 <= Enum61.flag_27)
			{
				if (enum2 <= Enum61.flag_24)
				{
					switch (enum2)
					{
					case Enum61.flag_16:
						num = 300;
						flag = !class304_0.IsType(HitObjectType.Slider);
						flag2 = true;
						num3 = this.double_1 * 6.0;
						if (bool_)
						{
							Class512 expr_7B8 = this.class512_0;
							expr_7B8.ushort_1 += 1;
							goto IL_B78;
						}
						goto IL_B78;
					case Enum61.flag_19:
						num = 300;
						flag = !class304_0.IsType(HitObjectType.Slider);
						flag2 = true;
						num3 = this.double_0 * 6.0 + this.double_1 * 6.0;
						if (bool_)
						{
							Class512 expr_80E = this.class512_0;
							expr_80E.ushort_1 += 1;
							goto IL_B78;
						}
						goto IL_B78;
					case Enum61.flag_21:
						num = 300;
						flag = !class304_0.IsType(HitObjectType.Slider);
						flag2 = true;
						num3 = this.double_0 * 10.0 + this.double_1 * 6.0;
						if (bool_)
						{
							Class512 expr_864 = this.class512_0;
							expr_864.ushort_1 += 1;
							Class512 expr_878 = this.class512_0;
							expr_878.ushort_4 += 1;
							goto IL_B78;
						}
						goto IL_B78;
					case Enum61.flag_6 | Enum61.flag_7 | Enum61.flag_16:
						break;
					case Enum61.flag_22:
						num = 300;
						flag = !class304_0.IsType(HitObjectType.Slider);
						flag2 = true;
						num3 = this.double_0 * 14.0 + this.double_1 * 6.0;
						if (bool_)
						{
							Class512 expr_8CE = this.class512_0;
							expr_8CE.ushort_1 += 1;
							Class512 expr_8E2 = this.class512_0;
							expr_8E2.ushort_3 += 1;
							goto IL_B78;
						}
						goto IL_B78;
					default:
						if (enum2 != Enum61.flag_23)
						{
							if (enum2 == Enum61.flag_24)
							{
								num = 0;
								num3 = this.double_1 * 1.7;
								flag = false;
								goto IL_B78;
							}
						}
						else
						{
							num = 100;
							num3 = this.double_1 * 3.0;
							if (bool_)
							{
								Class512 expr_773 = this.class512_0;
								expr_773.ushort_0 += 1;
								goto IL_B78;
							}
							goto IL_B78;
						}
						break;
					}
				}
				else
				{
					if (enum2 == Enum61.flag_25)
					{
						num = 100;
						num3 = this.double_1 * 1.7;
						flag = false;
						goto IL_B78;
					}
					if (enum2 == Enum61.flag_26)
					{
						num = 1100;
						num3 = this.double_1 * 2.0;
						flag = false;
						goto IL_B78;
					}
					if (enum2 == Enum61.flag_27)
					{
						num = 300;
						flag = false;
						num3 = 0.0001;
						if (class304_0.bool_2)
						{
							num = (int)((float)num * 1.2f);
							goto IL_B78;
						}
						goto IL_B78;
					}
				}
			}
			else if (enum2 <= Enum61.flag_33)
			{
				if (enum2 == Enum61.flag_29)
				{
					num = 300;
					num3 = 0.0;
					flag = false;
					goto IL_B78;
				}
				if (enum2 == Enum61.flag_30)
				{
					flag = false;
					num = 300;
					flag2 = true;
					num3 = 0.0;
					goto IL_B78;
				}
				if (enum2 == Enum61.flag_33)
				{
					num = 50;
					flag2 = true;
					num3 = (double)(-(double)(Class466.Current.DifficultyHpDrainRate + 1f)) * 0.32;
					if (bool_)
					{
						Class512 expr_9D9 = this.class512_0;
						expr_9D9.ushort_2 += 1;
						goto IL_B78;
					}
					goto IL_B78;
				}
			}
			else if (enum2 <= Enum61.flag_35)
			{
				if (enum2 != Enum61.flag_34)
				{
					if (enum2 == Enum61.flag_35)
					{
						num = 200;
						flag2 = true;
						num3 = this.double_1 * (0.8 - (double)Class466.Current.DifficultyHpDrainRate * 0.08);
						if (bool_)
						{
							Class512 expr_A7F = this.class512_0;
							expr_A7F.ushort_4 += 1;
							goto IL_B78;
						}
						goto IL_B78;
					}
				}
				else
				{
					num = 100;
					flag2 = true;
					num3 = 0.0;
					if (bool_)
					{
						Class512 expr_AAF = this.class512_0;
						expr_AAF.ushort_0 += 1;
						goto IL_B78;
					}
					goto IL_B78;
				}
			}
			else if (enum2 != Enum61.flag_36)
			{
				if (enum2 == Enum61.flag_37)
				{
					num = Class420.int_1;
					flag2 = true;
					num3 = this.double_1 * (1.1 - (double)Class466.Current.DifficultyHpDrainRate * 0.1);
					if (bool_)
					{
						Class512 expr_B20 = this.class512_0;
						expr_B20.ushort_3 += 1;
						goto IL_B78;
					}
					goto IL_B78;
				}
			}
			else
			{
				num = 300;
				flag2 = true;
				num3 = this.double_1 * (1.0 - (double)Class466.Current.DifficultyHpDrainRate * 0.1);
				if (bool_)
				{
					Class512 expr_B6A = this.class512_0;
					expr_B6A.ushort_1 += 1;
					goto IL_B78;
				}
				goto IL_B78;
			}
			num3 = 0.0;
			flag = false;
			IL_B78:
			if (this.class512_0.playModes_0 == PlayModes.OsuMania)
			{
				int num4 = 0;
				double num5 = Class876.smethod_8(Class62.class512_0.class623_0 & Mods.ScoreIncreaseMods);
				Enum61 enum3 = enum;
				if (enum3 <= Enum61.flag_34)
				{
					if (enum3 != Enum61.flag_4)
					{
						if (enum3 != Enum61.flag_33)
						{
							if (enum3 == Enum61.flag_34)
							{
								this.double_3 -= 24.0 / num5;
								num4 = 8;
							}
						}
						else
						{
							this.double_3 -= 44.0 / num5;
							num4 = 4;
						}
					}
					else
					{
						this.double_3 = -56.0 / num5;
						num4 = 0;
					}
				}
				else if (enum3 != Enum61.flag_35)
				{
					if (enum3 != Enum61.flag_36)
					{
						if (enum3 == Enum61.flag_37)
						{
							this.double_3 += 2.0;
							num4 = 32;
						}
					}
					else
					{
						this.double_3 += 1.0;
						num4 = 32;
					}
				}
				else
				{
					this.double_3 -= 8.0 / num5;
					num4 = 16;
				}
				if (this.class512_0.ushort_6 != 0 && (int)this.class512_0.ushort_6 % Class420.int_4 == 0)
				{
					this.double_3 = (double)Class420.int_3;
				}
				this.double_3 = Math.Max(0.0, Math.Min(this.double_3, (double)Class420.int_3));
				num2 = Math.Sqrt(this.double_3) * (double)num4 * this.double_2 / (double)Class420.int_1;
			}
			int num6 = 0;
			if (enum61_0 > Enum61.flag_5 && (enum61_0 & Enum61.flag_41) > Enum61.flag_5)
			{
				if (num > 0)
				{
					if (!flag)
					{
						num += num / 5;
					}
				}
				else
				{
					num = class304_0.int_5 / 50 * 50;
				}
				if ((enum61_0 & Enum61.flag_32) > Enum61.flag_5)
				{
					num6 = -1;
				}
			}
			class304_0.int_5 = num;
			if (flag2)
			{
				switch (Class62.Mode)
				{
				case PlayModes.Taiko:
					num += (int)((double)(num / 35 * 2 * (Class466.Current.method_13() + 1)) * Class876.smethod_8(this.class512_0.class623_0)) * (Math.Min(100, this.class413_0.vmethod_0() + num6) / 10);
					if ((enum == Enum61.flag_30 && Class62.bool_38) || class304_0.bool_2)
					{
						num = (int)((float)num * 1.2f);
						goto IL_E34;
					}
					goto IL_E34;
				case PlayModes.OsuMania:
					this.class512_0.int_3 = (int)this.class512_0.double_0;
					num2 += (double)num * this.double_2 / (double)Class420.int_1;
					num = (int)num2;
					goto IL_E34;
				}
				num += (int)((double)Math.Max(0, this.class413_0.vmethod_0() - 1) * ((double)(num / 25) * this.double_2));
			}
			IL_E34:
			if (enum61_0 > Enum61.flag_5)
			{
				if ((enum61_0 & (Enum61.flag_31 | Enum61.flag_32)) > Enum61.flag_5)
				{
					if (num > 0)
					{
						if (!flag)
						{
							num += num / 5;
						}
					}
					else
					{
						num = class304_0.int_5 / 50 * 50;
					}
					if ((enum61_0 & Enum61.flag_32) > Enum61.flag_5)
					{
						flag = false;
					}
				}
				if ((enum61_0 & (Enum61.flag_28 | Enum61.flag_30)) > Enum61.flag_5)
				{
					if (flag)
					{
						if (class304_0.int_5 == 300)
						{
							Class512 expr_E8D = this.class512_0;
							expr_E8D.ushort_3 += 1;
						}
						else if (class304_0.int_5 == 150)
						{
							Class512 expr_EB0 = this.class512_0;
							expr_EB0.ushort_4 += 1;
						}
					}
					num *= 2;
				}
			}
			if (flag)
			{
				if (enum61_0 > Enum61.flag_5)
				{
					Class512 arg_EFA_0 = this.class512_0;
					int arg_EF5_0 = this.class512_0.int_0;
					Class413 expr_EE3 = this.class413_0;
					int val;
					expr_EE3.vmethod_1(val = expr_EE3.vmethod_0() + 1);
					arg_EFA_0.int_0 = Math.Max(arg_EF5_0, val);
					this.class512_0.ushort_6 = (ushort)this.class413_0.vmethod_0();
				}
				else
				{
					if (this.class413_0.vmethod_0() > 20 && !Class62.bool_15 && !Class62.bool_16)
					{
						Class331.smethod_61(Class331.smethod_37("combobreak", false, true, Enum112.flag_6), 100, 0f, false, 1f);
						if (Class115.bool_16)
						{
							Class115.class533_0.method_40(Color.get_Red(), 2000);
							Class115.class533_0.float_2 = 0.8f;
							Class115.class533_0.method_26(1f, 2000, Enum70.const_25);
						}
					}
					Class512 arg_FAC_0 = this.class512_0;
					this.class413_0.vmethod_1(0);
					arg_FAC_0.ushort_6 = 0;
					if (Class876.smethod_6(this.class512_0.class623_0, Mods.SuddenDeath))
					{
						this.class410_0.vmethod_10(0.0);
					}
				}
			}
			if (this.class62_0.enum110_0 != Enum110.const_0)
			{
				this.vmethod_39(enum61_0, num3, class304_0);
			}
			if (num3 > 0.0)
			{
				this.class410_0.vmethod_12(num3);
			}
			else
			{
				this.class410_0.vmethod_11(-num3);
			}
			if (bool_ || (enum61_0 & Enum61.flag_32) > Enum61.flag_5)
			{
				this.class512_0.int_3 += num;
				this.class512_0.double_0 += num2;
			}
			if (this.class62_0.enum110_0 == Enum110.const_2 && this.class103_0 != null)
			{
				this.class103_0.vmethod_1(enum61_0);
			}
			if (this.bool_0)
			{
				this.int_3++;
				this.class62_0.method_8();
			}
		}

		// Token: 0x06001F3F RID: 7999
		// RVA: 0x0001991F File Offset: 0x00017B1F
		internal virtual void vmethod_42()
		{
			if (this.class410_0 != null)
			{
				this.class410_0.method_9(190.0);
			}
		}

		// Token: 0x06001F40 RID: 8000
		// RVA: 0x000B075C File Offset: 0x000AE95C
		internal virtual void vmethod_43()
		{
			double num = Class562.smethod_2();
			for (int i = 0; i < Math.Min(16, this.class413_0.vmethod_0() / 6); i++)
			{
				int int_ = Class115.int_1 + Class562.smethod_1(300, 1000);
				if (num > 0.5 || this.class413_0.vmethod_0() >= 100)
				{
					Vector2 vector2_;
					vector2_..ctor(-10f, (float)Class562.smethod_1(0, 480));
					Class531 class = new Class531(this.class62_0.class731_0, Enum115.const_5, Origins.Centre, Enum114.const_0, vector2_, 0.05f, false, Color.get_White(), null);
					Class746 class2 = new Class746(TransformationType.Scale, 1f, Class562.smethod_6(1f, 3f), Class115.int_1, int_, Enum70.const_0);
					Class746 class3 = new Class746(TransformationType.Fade, 1f, 0f, Class115.int_1, int_, Enum70.const_0);
					Class746 class4 = new Class746(TransformationType.Rotation, Class562.smethod_6(-2f, 2f), Class562.smethod_6(-2f, 2f), Class115.int_1, int_, Enum70.const_0);
					class2.enum70_0 = Enum70.const_1;
					class3.enum70_0 = Enum70.const_1;
					class4.enum70_0 = Enum70.const_1;
					class.class26_0.Add(class2);
					class.class26_0.Add(class3);
					class.class26_0.Add(class4);
					this.class911_2.Add(class);
					Class730 class5 = Class115.class729_0.Add(class, null, false);
					class5.vector2_0 = new Vector2((float)Class562.smethod_1(100, 500), (float)Class562.smethod_1(-120, 0));
				}
				if (num <= 0.5 || this.class413_0.vmethod_0() >= 100)
				{
					Vector2 vector2_2;
					vector2_2..ctor((float)(Class115.smethod_43() + 10), (float)Class562.smethod_1(0, 480));
					Class531 class6 = new Class531(this.class62_0.class731_0, Enum115.const_5, Origins.Centre, Enum114.const_0, vector2_2, 0.05f, false, Color.get_White(), null);
					Class746 class7 = new Class746(TransformationType.Scale, 1f, Class562.smethod_6(1f, 2.5f), Class115.int_1, int_, Enum70.const_0);
					Class746 class8 = new Class746(TransformationType.Fade, 1f, 0f, Class115.int_1, int_, Enum70.const_0);
					Class746 class9 = new Class746(TransformationType.Rotation, Class562.smethod_6(-2f, 2f), Class562.smethod_6(-2f, 2f), Class115.int_1, int_, Enum70.const_0);
					class7.enum70_0 = Enum70.const_1;
					class8.enum70_0 = Enum70.const_1;
					class9.enum70_0 = Enum70.const_1;
					class6.class26_0.Add(class7);
					class6.class26_0.Add(class8);
					class6.class26_0.Add(class9);
					this.class911_2.Add(class6);
					Class730 class10 = Class115.class729_0.Add(class6, null, false);
					class10.vector2_0 = new Vector2((float)Class562.smethod_1(-500, -100), (float)Class562.smethod_1(-120, 0));
				}
			}
		}

		// Token: 0x06001F41 RID: 8001
		// RVA: 0x000B0A48 File Offset: 0x000AEC48
		internal virtual void vmethod_44()
		{
			double num = Class562.smethod_2();
			if (this.class731_0 != null && this.class731_0.Length > 0)
			{
				if (Class885.class547_0.bool_11)
				{
					this.int_2 = Class562.smethod_1(0, this.class731_0.Length);
				}
				Class531 class = new Class531(this.class731_0[this.int_2], Enum115.const_5, Origins.BottomLeft, Enum114.const_0, Vector2.get_Zero(), 1f, false, Color.get_White(), null);
				Vector2 vector2_ = (num > 0.5) ? new Vector2((float)Class115.smethod_43(), 480f) : new Vector2((float)(-(float)this.class731_0[this.int_2].method_0()) * 0.625f, 480f);
				Vector2 vector2_2 = (num > 0.5) ? new Vector2((float)Class115.smethod_43() - (float)this.class731_0[this.int_2].method_0() * 0.625f, 480f) : new Vector2(0f, 480f);
				if (num > 0.5)
				{
					class.method_45(true);
				}
				Class746 item = new Class746(vector2_, vector2_2, Class115.int_1, Class115.int_1 + 700, Enum70.const_1);
				class.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class115.int_1 + 200, Class115.int_1 + 1200, Enum70.const_2));
				class.class26_0.Add(item);
				this.class62_0.class911_4.Add(class);
				this.int_2 = (this.int_2 + 1) % this.class731_0.Length;
			}
			this.vmethod_43();
		}

		// Token: 0x06001F43 RID: 8003
		// RVA: 0x000B0E24 File Offset: 0x000AF024
		internal virtual void vmethod_45()
		{
			if (!this.class62_0.bool_37)
			{
				return;
			}
			int num = (int)(Class331.smethod_8() * 0.75 * 100.0 / (double)Class331.smethod_67());
			foreach (Class304 current in this.class62_0.class297_0.list_4)
			{
				int num2 = num;
				if (num2 + Class331.int_7 > current.EndTime)
				{
					num2 = current.EndTime - Class331.int_7;
				}
				if (num2 >= 0 && !current.bool_0 && current.vmethod_9())
				{
					float num3 = 0f;
					int num4 = Math.Max(25, 300 - (int)current.Colour.get_R() - (int)current.Colour.get_G() - (int)current.Colour.get_B());
					Color color_;
					color_..ctor((byte)Math.Min((int)current.Colour.get_R() + num4, 255), (byte)Math.Min((int)current.Colour.get_G() + num4, 255), (byte)Math.Min((int)current.Colour.get_B() + num4, 255));
					if (Class341.class606_29)
					{
						Class531 class = new Class531(Class885.Load("lighting", Enum112.flag_6), current.list_1[0].enum115_0, Origins.Centre, Enum114.const_2, current.Position, 0f, false, current.Colour, null);
						class.float_2 = 1.2f;
						class.class26_0.Add(new Class746(TransformationType.Fade, 0f, 0.5f, Class331.int_7, Class331.int_7 + 50, Enum70.const_0));
						class.class26_0.Add(new Class746(TransformationType.Fade, 0.5f, num3, Class331.int_7 + 50, Class331.int_7 + num2 * 2, Enum70.const_0));
						class.bool_7 = true;
						this.class62_0.class297_0.class911_0.Add(class);
					}
					foreach (Class531 current2 in current.vmethod_13())
					{
						if (current2 != null && current2.bool_3)
						{
							Class531 class2 = current2.Clone();
							class2.enum114_0 = Enum114.const_2;
							class2.float_0 += 0.1f;
							class2.bool_7 = true;
							class2.bool_0 = false;
							class2.color_0 = color_;
							List<Class746> arg_270_0 = class2.class26_0;
							if (Class427.predicate_0 == null)
							{
								Class427.predicate_0 = new Predicate<Class746>(Class427.smethod_1);
							}
							arg_270_0.RemoveAll(Class427.predicate_0);
							class2.class26_0.Add(new Class746(TransformationType.Fade, current2.float_3 * 0.3f, num3 * current2.float_3, Class331.int_7, Class331.int_7 + num2, Enum70.const_0));
							this.class62_0.class297_0.class911_0.Add(class2);
						}
					}
				}
			}
		}

		// Token: 0x06001F44 RID: 8004
		// RVA: 0x0001993D File Offset: 0x00017B3D
		internal virtual void vmethod_46(bool bool_2)
		{
			if (bool_2)
			{
				this.method_5();
			}
		}

		// Token: 0x06001F45 RID: 8005
		// RVA: 0x000B1160 File Offset: 0x000AF360
		internal virtual Enum111 vmethod_47(Class304 class304_0)
		{
			if (class304_0.IsType(HitObjectType.Normal))
			{
				int num = this.class297_0.list_4.IndexOf(class304_0);
				if (num > 0 && this.class297_0.list_4[num - 1].StackCount > 0 && this.class297_0.list_4[num - 1].vmethod_9() && !this.class297_0.list_4[num - 1].bool_0)
				{
					return Enum111.const_0;
				}
			}
			bool flag = true;
			foreach (Class304 current in this.class297_0.list_4)
			{
				if (current.StartTime + this.class297_0.HitWindow50 > Class331.int_7 && !current.bool_0)
				{
					if (current.StartTime < class304_0.StartTime && current != class304_0)
					{
						flag = false;
					}
					break;
				}
			}
			int num2 = Class62.bool_16 ? 200 : 0;
			if (flag && Math.Abs(class304_0.StartTime - Class331.int_7) < 400 - num2)
			{
				return Enum111.const_2;
			}
			return Enum111.const_1;
		}

		// Token: 0x06001F46 RID: 8006
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void vmethod_48(bool bool_2)
		{
		}

		// Token: 0x06001F47 RID: 8007
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void vmethod_49()
		{
		}

		// Token: 0x06001F12 RID: 7954
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal virtual bool vmethod_5()
		{
			return true;
		}

		// Token: 0x06001F48 RID: 8008
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void vmethod_50(Class531 class531_2)
		{
		}

		// Token: 0x06001F49 RID: 8009
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal virtual bool vmethod_51()
		{
			return false;
		}

		// Token: 0x06001F13 RID: 7955
		// RVA: 0x0001979C File Offset: 0x0001799C
		internal virtual Vector2 vmethod_6()
		{
			return Class115.smethod_58(Class802.vector2_0);
		}

		// Token: 0x06001F14 RID: 7956
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal virtual bool vmethod_7()
		{
			return true;
		}

		// Token: 0x06001F15 RID: 7957
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal virtual bool vmethod_8()
		{
			return false;
		}

		// Token: 0x06001F16 RID: 7958
		// RVA: 0x000197A8 File Offset: 0x000179A8
		internal virtual bool vmethod_9()
		{
			return (int)(this.class512_0.ushort_1 + this.class512_0.ushort_0 + this.class512_0.ushort_2 + this.class512_0.ushort_5) == this.class297_0.int_14;
		}
	}
}
