using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns18;
using ns22;
using ns23;
using ns24;
using ns26;
using ns29;
using ns3;
using ns59;
using ns61;
using ns64;
using ns70;
using ns76;
using ns77;
using ns79;
using ns80;
using ns82;
using osu.GameplayElements.HitObjects;
using osu.Graphics.Sprites;
using osu.Input;
using osu_common;
using osu_common.Bancho.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns73
{
	// Token: 0x0200051D RID: 1309
	internal sealed class Class432 : Class427
	{
		// Token: 0x0200051E RID: 1310
		[CompilerGenerated]
		private sealed class Class687
		{
			// Token: 0x04002329 RID: 9001
			public bool bool_0;

			// Token: 0x04002328 RID: 9000
			public Class432 class432_0;

			// Token: 0x04002327 RID: 8999
			public List<Class531> list_0;

			// Token: 0x06002A71 RID: 10865
			// RVA: 0x0011233C File Offset: 0x0011053C
			public void method_0(Class531 class531_0)
			{
				Class531 class = class531_0.Clone();
				class.float_0 += 0.0001f;
				class.method_15(200);
				class531_0.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class331.int_7 + 200, Class331.int_7 + 200, Enum70.const_0));
				if (this.bool_0)
				{
					class.vmethod_7(this.class432_0.class731_1);
				}
				else
				{
					class.vmethod_7(this.class432_0.class731_2);
				}
				this.list_0.Add(class);
			}
		}

		// Token: 0x04002324 RID: 8996
		[CompilerGenerated]
		private static Action<Class304> action_0;

		// Token: 0x04002326 RID: 8998
		[CompilerGenerated]
		private static Action<Class14> action_1;

		// Token: 0x04002313 RID: 8979
		private Class304 class304_0;

		// Token: 0x04002312 RID: 8978
		private Class524 class524_0;

		// Token: 0x0400231A RID: 8986
		private Class531 class531_10;

		// Token: 0x0400230E RID: 8974
		private Class531 class531_2;

		// Token: 0x0400230F RID: 8975
		private Class531 class531_3;

		// Token: 0x04002310 RID: 8976
		private Class531 class531_4;

		// Token: 0x04002311 RID: 8977
		private Class531 class531_5;

		// Token: 0x04002316 RID: 8982
		private Class531 class531_6;

		// Token: 0x04002317 RID: 8983
		private Class531 class531_7;

		// Token: 0x04002318 RID: 8984
		private Class531 class531_8;

		// Token: 0x04002319 RID: 8985
		private Class531 class531_9;

		// Token: 0x0400231D RID: 8989
		private Class533 class533_0;

		// Token: 0x0400231B RID: 8987
		private Class731 class731_1;

		// Token: 0x0400231C RID: 8988
		private Class731 class731_2;

		// Token: 0x04002314 RID: 8980
		private int int_4;

		// Token: 0x0400230D RID: 8973
		private readonly List<Class531> list_0 = new List<Class531>();

		// Token: 0x04002315 RID: 8981
		private List<Class531> list_1 = new List<Class531>();

		// Token: 0x0400231E RID: 8990
		[CompilerGenerated]
		private static Predicate<Class304> predicate_1;

		// Token: 0x0400231F RID: 8991
		[CompilerGenerated]
		private static Predicate<Class531> predicate_2;

		// Token: 0x04002320 RID: 8992
		[CompilerGenerated]
		private static Predicate<Class531> predicate_3;

		// Token: 0x04002321 RID: 8993
		[CompilerGenerated]
		private static Predicate<Class746> predicate_4;

		// Token: 0x04002322 RID: 8994
		[CompilerGenerated]
		private static Predicate<Class304> predicate_5;

		// Token: 0x04002323 RID: 8995
		[CompilerGenerated]
		private static Predicate<Class304> predicate_6;

		// Token: 0x04002325 RID: 8997
		[CompilerGenerated]
		private static Predicate<Class304> predicate_7;

		// Token: 0x06002A3B RID: 10811
		// RVA: 0x00020662 File Offset: 0x0001E862
		public Class432(Class62 class62_1) : base(class62_1)
		{
		}

		// Token: 0x06002A4A RID: 10826
		// RVA: 0x000206DD File Offset: 0x0001E8DD
		public override void Dispose()
		{
			if (this.bool_0)
			{
				this.class524_0.Dispose();
			}
			base.Dispose();
		}

		// Token: 0x06002A4B RID: 10827
		// RVA: 0x000206F8 File Offset: 0x0001E8F8
		internal override void Draw()
		{
			if (!this.bool_0)
			{
				return;
			}
			base.Draw();
			this.class524_0.class911_0.float_0 = this.class911_0.float_0;
			this.class524_0.Draw();
			this.method_6();
		}

		// Token: 0x06002A5B RID: 10843
		// RVA: 0x001111D0 File Offset: 0x0010F3D0
		internal override void Initialize()
		{
			Class802.bool_11 = true;
			base.Initialize();
			List<Class304> arg_35_0 = this.class297_0.list_3;
			if (Class432.predicate_7 == null)
			{
				Class432.predicate_7 = new Predicate<Class304>(Class432.smethod_10);
			}
			this.class304_0 = arg_35_0.Find(Class432.predicate_7);
		}

		// Token: 0x06002A4D RID: 10829
		// RVA: 0x001106B0 File Offset: 0x0010E8B0
		private void method_6()
		{
			if (this.class531_10 == null)
			{
				return;
			}
			float num;
			while ((num = (this.class531_10.vector2_1.X + (float)this.class531_10.int_4 * this.class531_10.float_2 * 0.625f) * Class115.float_4) <= (float)Class115.int_22)
			{
				Class531 class = this.class531_10;
				this.class531_10 = this.class531_10.Clone();
				this.list_1.Add(this.class531_10);
				float num2 = num / Class115.float_4;
				float x = class.class26_0[0].vector2_1.X;
				this.class531_10.vector2_1.X = num2;
				this.class531_10.class26_0[0].vector2_0.X = num2;
				this.class531_10.class26_0[0].vector2_1.X = x;
				this.class531_10.class26_0[0].int_0 = Class331.int_7;
				this.class531_10.class26_0[0].int_1 = (int)((float)Class331.int_7 + (x - num2) / (class.class26_0[0].vector2_1.X - class.class26_0[0].vector2_0.X) * (float)class.class26_0[0].method_0());
				this.class62_0.class911_4.Add(this.class531_10);
			}
		}

		// Token: 0x06002A69 RID: 10857
		// RVA: 0x001122F0 File Offset: 0x001104F0
		[CompilerGenerated]
		private void method_7(Class304 class304_1)
		{
			Class324 class = class304_1 as Class324;
			if (class != null)
			{
				class.class306_0.class538_0.method_50(this.int_4);
				return;
			}
			Class310 class2 = class304_1 as Class310;
			if (class2 != null)
			{
				class2.class538_0.method_50(this.int_4);
			}
		}

		// Token: 0x06002A6E RID: 10862
		// RVA: 0x0002089E File Offset: 0x0001EA9E
		[CompilerGenerated]
		private static bool smethod_10(Class304 class304_1)
		{
			return class304_1.IsType(HitObjectType.Normal);
		}

		// Token: 0x06002A6F RID: 10863
		// RVA: 0x000208A7 File Offset: 0x0001EAA7
		[CompilerGenerated]
		private static void smethod_11(Class14 class14_0)
		{
			class14_0.float_0 = -150f;
			class14_0.float_1 = -150f;
		}

		// Token: 0x06002A49 RID: 10825
		// RVA: 0x001104A4 File Offset: 0x0010E6A4
		internal static bool smethod_2(int int_5)
		{
			double num = Class331.smethod_10();
			return Class331.smethod_0() % (num * 2.0 / (double)int_5) >= num / (double)int_5;
		}

		// Token: 0x06002A66 RID: 10854
		// RVA: 0x0002084F File Offset: 0x0001EA4F
		[CompilerGenerated]
		private static bool smethod_3(Class304 class304_1)
		{
			return class304_1 is Class310;
		}

		// Token: 0x06002A67 RID: 10855
		// RVA: 0x0002085A File Offset: 0x0001EA5A
		[CompilerGenerated]
		private static bool smethod_4(Class531 class531_11)
		{
			return class531_11.class26_0[0].int_1 < Class331.int_7;
		}

		// Token: 0x06002A68 RID: 10856
		// RVA: 0x00020874 File Offset: 0x0001EA74
		[CompilerGenerated]
		private static bool smethod_5(Class531 class531_11)
		{
			return !class531_11.bool_0;
		}

		// Token: 0x06002A6A RID: 10858
		// RVA: 0x00018A5A File Offset: 0x00016C5A
		[CompilerGenerated]
		private static bool smethod_6(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Scale;
		}

		// Token: 0x06002A6B RID: 10859
		// RVA: 0x0002084F File Offset: 0x0001EA4F
		[CompilerGenerated]
		private static bool smethod_7(Class304 class304_1)
		{
			return class304_1 is Class310;
		}

		// Token: 0x06002A6C RID: 10860
		// RVA: 0x0002087F File Offset: 0x0001EA7F
		[CompilerGenerated]
		private static bool smethod_8(Class304 class304_1)
		{
			return !(class304_1 is Class324);
		}

		// Token: 0x06002A6D RID: 10861
		// RVA: 0x0002088D File Offset: 0x0001EA8D
		[CompilerGenerated]
		private static void smethod_9(Class304 class304_1)
		{
			class304_1.double_0 = 200.0;
		}

		// Token: 0x06002A3F RID: 10815
		// RVA: 0x000206B9 File Offset: 0x0001E8B9
		internal override Vector2 vmethod_0()
		{
			return new Vector2(0f, 264f);
		}

		// Token: 0x06002A43 RID: 10819
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal override bool vmethod_10()
		{
			return false;
		}

		// Token: 0x06002A44 RID: 10820
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal override bool vmethod_11()
		{
			return false;
		}

		// Token: 0x06002A46 RID: 10822
		// RVA: 0x0001FDB0 File Offset: 0x0001DFB0
		internal override bool vmethod_12()
		{
			return Class62.bool_12 || base.vmethod_12() || Class802.smethod_0();
		}

		// Token: 0x06002A42 RID: 10818
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal override bool vmethod_13()
		{
			return false;
		}

		// Token: 0x06002A62 RID: 10850
		// RVA: 0x0002081A File Offset: 0x0001EA1A
		internal override bool vmethod_14()
		{
			return this.class413_0.vmethod_0() == 50 || (this.class413_0.vmethod_0() > 99 && this.class413_0.vmethod_0() % 100 == 0);
		}

		// Token: 0x06002A50 RID: 10832
		// RVA: 0x00110838 File Offset: 0x0010EA38
		internal override void vmethod_15(Class304 class304_1)
		{
			Class310 class = class304_1 as Class310;
			Class324 class2 = class304_1 as Class324;
			if ((class != null && class.int_5 > 0) || (class2 != null && class2.bool_15))
			{
				Class731 class3;
				Class731 class4;
				if (class != null)
				{
					class3 = class.class531_1.vmethod_6();
					class4 = class.class538_0.vmethod_6();
				}
				else
				{
					class3 = class2.class306_0.class531_1.vmethod_6();
					class4 = class2.class306_0.class538_0.vmethod_6();
				}
				float num = 1f - 0.03f * Class911.smethod_4((class304_1 != null) ? ((float)class304_1.StartTime) : 0.1f) / 0.8f;
				Class531 class5 = new Class531(class3, Enum115.const_1, Origins.Centre, Enum114.const_1, Class303.vector2_0, num, true, (class304_1 != null) ? class304_1.Colour : new Color(252, 184, 6), null);
				class5.float_2 = ((class304_1 != null) ? class304_1.list_1[0].float_2 : 0.7f);
				this.class911_1.Add(class5);
				class5.vector2_0.X = Class115.smethod_57(this.class410_0.method_8());
				class5.int_0 = 169;
				this.list_0.Add(class5);
				class5 = new Class531(class4, Enum115.const_1, Origins.Centre, Enum114.const_1, Class303.vector2_0, num + 0.0001f, true, Color.get_White(), null);
				class5.float_2 = ((class304_1 != null) ? class304_1.list_1[0].float_2 : 0.7f);
				class5.vector2_0.X = Class115.smethod_57(this.class410_0.method_8());
				class5.int_0 = 169;
				this.class911_1.Add(class5);
				this.list_0.Add(class5);
				if (Class62.bool_38)
				{
					List<Class746> arg_1D9_0 = this.class531_6.class26_0;
					if (Class432.predicate_4 == null)
					{
						Class432.predicate_4 = new Predicate<Class746>(Class432.smethod_6);
					}
					arg_1D9_0.RemoveAll(Class432.predicate_4);
					this.class531_6.class26_0.Add(new Class746(TransformationType.Scale, 0.85f, 0.7f, Class115.int_1, Class115.int_1 + 80, Enum70.const_1));
				}
			}
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			if (Class62.bool_15 && class != null)
			{
				flag = Class802.bool_4;
				flag2 = Class802.bool_6;
				flag3 = Class802.bool_19;
				flag4 = Class802.bool_21;
				Class802.bool_4 = (class.method_9() && (flag3 || flag));
				Class802.bool_6 = (class.method_9() && (flag4 || flag2));
				Class802.bool_19 = (!class.method_9() && (flag3 || flag));
				Class802.bool_21 = (!class.method_9() && (flag4 || flag2));
			}
			if (Class802.bool_4 || Class802.bool_6)
			{
				Class340 class6 = this.class297_0.class296_0.method_39((double)(Class331.int_7 + 2));
				Struct69 struct69_ = new Struct69(HitObjectSoundType.Normal, Class331.sampleSet_0, Class331.smethod_74(), class6.int_0, Class331.sampleSet_0);
				Class331.smethod_62(struct69_, Class802.bool_4 ? -0.2f : 0.2f, true);
				if (Class802.bool_4)
				{
					this.class531_2.class26_0.Clear();
					this.class531_2.class26_0.Add(new Class746(TransformationType.Fade, this.class531_2.float_3, 1f, Class115.int_1, Class115.int_1 + (int)((1f - this.class531_2.float_3) * 80f), Enum70.const_1));
					this.class531_2.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class115.int_1 + 100, Class115.int_1 + 150, Enum70.const_0));
				}
				if (Class802.bool_6)
				{
					this.class531_3.class26_0.Clear();
					this.class531_3.class26_0.Add(new Class746(TransformationType.Fade, this.class531_3.float_3, 1f, Class115.int_1, Class115.int_1 + (int)((1f - this.class531_3.float_3) * 80f), Enum70.const_1));
					this.class531_3.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class115.int_1 + 100, Class115.int_1 + 150, Enum70.const_0));
				}
			}
			if (Class802.bool_19 || Class802.bool_21)
			{
				Class340 class7 = this.class297_0.class296_0.method_39((double)(Class331.int_7 + 2));
				Struct69 struct69_2 = new Struct69(HitObjectSoundType.Clap, Class331.sampleSet_0, Class331.smethod_74(), class7.int_0, Class331.sampleSet_0);
				Class331.smethod_62(struct69_2, Class802.bool_19 ? -0.2f : 0.2f, true);
				if (Class802.bool_19)
				{
					this.class531_4.class26_0.Clear();
					this.class531_4.class26_0.Add(new Class746(TransformationType.Fade, this.class531_4.float_3, 1f, Class115.int_1, Class115.int_1 + (int)((1f - this.class531_4.float_3) * 80f), Enum70.const_1));
					this.class531_4.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class115.int_1 + 100, Class115.int_1 + 150, Enum70.const_0));
				}
				if (Class802.bool_21)
				{
					this.class531_5.class26_0.Clear();
					this.class531_5.class26_0.Add(new Class746(TransformationType.Fade, this.class531_5.float_3, 1f, Class115.int_1, Class115.int_1 + (int)((1f - this.class531_5.float_3) * 80f), Enum70.const_1));
					this.class531_5.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class115.int_1 + 100, Class115.int_1 + 150, Enum70.const_0));
				}
			}
			if (Class62.bool_15 && class != null)
			{
				Class802.bool_4 = flag;
				Class802.bool_6 = flag2;
				Class802.bool_19 = flag3;
				Class802.bool_21 = flag4;
			}
		}

		// Token: 0x06002A47 RID: 10823
		// RVA: 0x000206CA File Offset: 0x0001E8CA
		protected override void vmethod_18()
		{
			this.class666_0 = new Class667(this.class911_1);
		}

		// Token: 0x06002A54 RID: 10836
		// RVA: 0x00020770 File Offset: 0x0001E970
		internal override void vmethod_20()
		{
			this.class410_0 = new Class412(this.class911_1);
		}

		// Token: 0x06002A52 RID: 10834
		// RVA: 0x00110E3C File Offset: 0x0010F03C
		internal override void vmethod_22()
		{
			double arg_7F_0 = 200.0;
			double arg_46_0 = 0.36;
			List<Class304> arg_3B_0 = this.class297_0.list_3;
			if (Class432.predicate_5 == null)
			{
				Class432.predicate_5 = new Predicate<Class304>(Class432.smethod_7);
			}
			this.double_1 = arg_7F_0 / (arg_46_0 * (double)arg_3B_0.FindAll(Class432.predicate_5).Count * this.class297_0.MapDifficultyRange((double)this.class297_0.class296_0.DifficultyHpDrainRate, 0.5, 0.75, 0.98000001907348633));
			this.double_0 = 0.0;
			List<Class304> arg_BD_0 = this.class297_0.list_3;
			if (Class432.predicate_6 == null)
			{
				Class432.predicate_6 = new Predicate<Class304>(Class432.smethod_8);
			}
			this.int_1 = arg_BD_0.FindAll(Class432.predicate_6).Count;
			if (Class115.bool_25)
			{
				for (int i = 0; i < this.class297_0.int_14; i++)
				{
					Class304 class = this.class297_0.list_3[i];
					if (class is Class310)
					{
						Enum61 enum;
						if (class.Finish)
						{
							enum = (Enum61.flag_16 | Enum61.flag_28);
						}
						else
						{
							enum = Enum61.flag_16;
						}
						this.vmethod_41(enum, class);
					}
					else if (class is Class324)
					{
						Class324 class2 = (Class324)class;
						Enum61 enum = Enum61.flag_27;
						if (class2.Finish)
						{
							enum |= Enum61.flag_28;
						}
						for (int j = 0; j < class2.list_11.Count; j++)
						{
							this.vmethod_41(enum, class);
						}
					}
					else if (class is Class329)
					{
						Class329 class3 = (Class329)class;
						for (int k = 0; k < class3.int_9 + 1; k++)
						{
							this.vmethod_41(Enum61.flag_29, class);
						}
						this.vmethod_41(Enum61.flag_30, class);
					}
				}
				Class63 class4 = this.class62_0 as Class63;
				if (class4 != null)
				{
					class4.int_38 = Class62.class512_0.int_3;
					class4.int_37 = this.class413_0.vmethod_0();
				}
				Class62.class512_0.int_3 = 0;
				this.class413_0.vmethod_1(0);
			}
			List<Class304> arg_231_0 = this.class297_0.list_3;
			if (Class432.action_0 == null)
			{
				Class432.action_0 = new Action<Class304>(Class432.smethod_9);
			}
			arg_231_0.ForEach(Class432.action_0);
			base.vmethod_22();
		}

		// Token: 0x06002A48 RID: 10824
		// RVA: 0x00110418 File Offset: 0x0010E618
		internal override void vmethod_23()
		{
			base.vmethod_23();
			if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.Flashlight))
			{
				Class531 class = new Class531(Class115.class731_0, Enum115.const_2, Origins.TopLeft, Enum114.const_0, new Vector2(640f, 0f), 0f, true, Color.get_Black(), null);
				class.float_2 = 1.6f;
				class.vector2_2 = new Vector2((float)(Class115.smethod_43() - 640), (float)Class115.smethod_44());
				this.class911_3.Add(class);
			}
		}

		// Token: 0x06002A5C RID: 10844
		// RVA: 0x000207D4 File Offset: 0x0001E9D4
		internal override void vmethod_25()
		{
			if (Class341.class606_66)
			{
				Class885.smethod_9("taiko", false);
				return;
			}
			Class885.smethod_9(null, false);
		}

		// Token: 0x06002A5E RID: 10846
		// RVA: 0x001112E0 File Offset: 0x0010F4E0
		internal override void vmethod_26()
		{
			this.class297_0.class911_0.bool_8 = false;
			this.class524_0 = new Class524();
			this.class524_0.Initialize();
			this.class524_0.Position = new Vector2(0f, 160f);
			this.class531_7 = new Class531(Class885.Load("approachcircle", Enum112.flag_5), Enum115.const_1, Origins.Centre, Enum114.const_0, Class303.vector2_0, 0.021f, true, new Color(255, 255, 255, 180), null);
			this.class531_7.float_2 = 0.73f;
			this.class297_0.class911_0.Add(this.class531_7);
			this.class531_7 = new Class531(Class885.Load("taikobigcircle", Enum112.flag_5), Enum115.const_1, Origins.Centre, Enum114.const_0, Class303.vector2_0, 0.021f, true, new Color(255, 255, 255, 120), null);
			this.class531_7.float_2 = 0.7f;
			this.class297_0.class911_0.Add(this.class531_7);
			this.class531_6 = new Class531(Class885.Load("taiko-glow", Enum112.flag_5), Enum115.const_1, Origins.Centre, Enum114.const_0, Class303.vector2_0, 0.02f, true, new Color(255, 228, 0, 0), null);
			this.class531_6.float_2 = 0.7f;
			this.class297_0.class911_0.Add(this.class531_6);
			this.class531_9 = new Class531(Class885.Load("taiko-bar-left", Enum112.flag_5), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(0f, 135f), 0.95f, true, Color.get_White(), null);
			this.class297_0.class911_0.Add(this.class531_9);
			if (Class885.class547_0.double_0 >= 2.1)
			{
				this.class531_7 = new Class531(Class885.Load("taiko-bar-right", Enum112.flag_5), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(0f, 135f), 0f, true, Color.get_White(), null);
				this.class531_8 = new Class531(Class885.Load("taiko-bar-right-glow", Enum112.flag_5), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(0f, 135f), 0.0001f, true, Color.get_TransparentWhite(), null);
			}
			else
			{
				this.class531_7 = new Class531(Class885.Load("taiko-bar-right", Enum112.flag_5), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(113f, 135f), 0f, true, Color.get_White(), null);
				this.class531_8 = new Class531(Class885.Load("taiko-bar-right-glow", Enum112.flag_5), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(113f, 135f), 0.0001f, true, Color.get_TransparentWhite(), null);
			}
			if (Class115.bool_21)
			{
				this.class531_8.vector2_2 = (this.class531_7.vector2_2 = new Vector2(2f + (float)(2 * Class115.int_26) / Class115.float_5 / (float)this.class531_7.vmethod_6().method_0(), 1f));
			}
			this.class297_0.class911_0.Add(this.class531_7);
			this.class297_0.class911_0.Add(this.class531_8);
			if (!Class876.smethod_5(Mods.Cinema))
			{
				Class531 class = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(0f, 253f), 0f, true, Color.get_Black(), null);
				class.bool_13 = false;
				class.float_3 = 0.9f;
				class.vector2_2 = new Vector2((float)Class115.int_22, 36f * Class115.float_4);
				this.class62_0.class911_5.Add(class);
				Class533 class2 = new Class533(Class466.Current.method_75(), 19f, new Vector2(-20f, 271f), 1E-05f, true, Color.get_TransparentWhite());
				class2.origins_0 = Origins.CentreRight;
				class2.enum115_0 = Enum115.const_7;
				class2.bool_16 = true;
				class2.method_62("skin-taiko");
				this.class533_0 = class2;
				this.class62_0.class911_5.Add(this.class533_0);
			}
			if (Class115.bool_21 && Class876.smethod_6(Class62.class512_0.class623_0, Mods.Hidden))
			{
				Class531 class3 = new Class531(Class885.Load("taiko-bar-right", Enum112.flag_5), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2((float)Class115.smethod_43() - (float)(2 * Class115.int_26) / Class115.float_4, 135f), 0.1f, true, new Color(0, 0, 0, 255), null);
				class3.int_4 = (int)((float)(2 * Class115.int_26) / Class115.float_5) + 1;
				this.class62_0.class911_4.Add(class3);
			}
			int num = (Class885.class547_0.double_0 >= 2.1) ? 5 : 0;
			Class533 class4 = new Class533(Class795.smethod_5(Bindings.TaikoInnerLeft), 18f, new Vector2((float)(25 + num), 185f), Vector2.get_Zero(), 0.98f, false, Color.get_White(), true);
			class4.bool_16 = true;
			class4.method_16(5000, Enum70.const_0);
			this.class297_0.class911_0.Add(class4);
			class4 = new Class533(Class795.smethod_5(Bindings.TaikoInnerRight), 18f, new Vector2((float)(64 + num), 185f), Vector2.get_Zero(), 0.98f, false, Color.get_White(), true);
			class4.bool_16 = true;
			class4.method_16(5000, Enum70.const_0);
			this.class297_0.class911_0.Add(class4);
			class4 = new Class533(Class795.smethod_5(Bindings.TaikoOuterLeft), 18f, new Vector2((float)(8 + num), 158f), Vector2.get_Zero(), 0.98f, false, Color.get_White(), true);
			class4.bool_16 = true;
			class4.method_16(5000, Enum70.const_0);
			this.class297_0.class911_0.Add(class4);
			class4 = new Class533(Class795.smethod_5(Bindings.TaikoOuterRight), 18f, new Vector2((float)(75 + num), 158f), Vector2.get_Zero(), 0.98f, false, Color.get_White(), true);
			class4.bool_16 = true;
			class4.method_16(5000, Enum70.const_0);
			this.class297_0.class911_0.Add(class4);
			if (Class885.class547_0.double_0 >= 2.1)
			{
				this.class531_2 = new Class531(Class885.Load("taiko-drum-inner", Enum112.flag_5), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(0f, 135f), 0.96f, true, Color.get_TransparentWhite(), null);
				this.class297_0.class911_0.Add(this.class531_2);
				this.class531_3 = new Class531(Class885.Load("taiko-drum-inner", Enum112.flag_5), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(56f, 135f), 0.96f, true, Color.get_TransparentWhite(), null);
				this.class531_3.method_45(true);
				this.class297_0.class911_0.Add(this.class531_3);
				this.class531_4 = new Class531(Class885.Load("taiko-drum-outer", Enum112.flag_5), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(0f, 135f), 0.96f, true, Color.get_TransparentWhite(), null);
				this.class531_4.method_45(true);
				this.class297_0.class911_0.Add(this.class531_4);
				this.class531_5 = new Class531(Class885.Load("taiko-drum-outer", Enum112.flag_5), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(56f, 135f), 0.96f, true, Color.get_TransparentWhite(), null);
				this.class297_0.class911_0.Add(this.class531_5);
			}
			else
			{
				this.class531_2 = new Class531(Class885.Load("taiko-drum-inner", Enum112.flag_5), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(18f, 166f), 0.96f, true, Color.get_TransparentWhite(), null);
				this.class297_0.class911_0.Add(this.class531_2);
				this.class531_3 = new Class531(Class885.Load("taiko-drum-inner", Enum112.flag_5), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(54f, 166f), 0.96f, true, Color.get_TransparentWhite(), null);
				this.class531_3.method_45(true);
				this.class297_0.class911_0.Add(this.class531_3);
				this.class531_4 = new Class531(Class885.Load("taiko-drum-outer", Enum112.flag_5), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(8f, 158f), 0.96f, true, Color.get_TransparentWhite(), null);
				this.class531_4.method_45(true);
				this.class297_0.class911_0.Add(this.class531_4);
				this.class531_5 = new Class531(Class885.Load("taiko-drum-outer", Enum112.flag_5), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(53f, 158f), 0.96f, true, Color.get_TransparentWhite(), null);
				this.class297_0.class911_0.Add(this.class531_5);
			}
			if (!this.class62_0.class872_0.bool_11 || this.class62_0.class872_0.class911_0.method_2() + this.class62_0.class872_0.class911_2.method_2() < 10)
			{
				this.class531_10 = new Class531(Class885.Load("taiko-slider", Enum112.flag_5), Enum115.const_5, Origins.TopLeft, Enum114.const_1, new Vector2(0f, 0f), 0f, false, Color.get_White(), null);
				this.class62_0.class911_4.Add(this.class531_10);
				this.class531_10.float_2 = 1.4f;
				this.class531_10.class26_0.Add(new Class746(Vector2.get_Zero(), new Vector2(-1400f, 0f), -this.class62_0.int_34, -this.class62_0.int_34 + 34400, Enum70.const_0));
				this.list_1.Add(this.class531_10);
			}
			if (Class341.class606_12)
			{
				this.class731_0 = Class885.smethod_27("taiko-flower-group", Enum112.flag_6, true);
			}
			Class885.Load("taiko-bar-right-glow", Enum112.flag_5);
			this.class731_1 = Class885.Load("taiko-slider", Enum112.flag_5);
			this.class731_2 = Class885.Load("taiko-slider-fail", Enum112.flag_5);
			base.vmethod_26();
		}

		// Token: 0x06002A51 RID: 10833
		// RVA: 0x00020755 File Offset: 0x0001E955
		internal override Class297 vmethod_27()
		{
			return new Class303(true);
		}

		// Token: 0x06002A53 RID: 10835
		// RVA: 0x0002075D File Offset: 0x0001E95D
		internal override void vmethod_28()
		{
			this.class413_0 = new Class415(this.class911_1);
		}

		// Token: 0x06002A65 RID: 10853
		// RVA: 0x00111FE0 File Offset: 0x001101E0
		internal override void vmethod_29()
		{
			Class802.class512_0.list_1 = new List<Class14>();
			List<Class14> list = Class802.class512_0.list_1;
			bool flag = true;
			list.Add(new Class14(-100000, 320f, 240f, pButtonState.None));
			list.Add(new Class14(this.class297_0.list_3[0].StartTime - 1000, 320f, 240f, pButtonState.None));
			for (int i = 0; i < this.class297_0.int_14; i++)
			{
				Class304 class = this.class297_0.list_3[i];
				Class329 class2 = class as Class329;
				if (class2 != null)
				{
					int num = 0;
					int num2 = 0;
					int num3 = class2.int_9 + 1;
					int num4 = class.Length / num3;
					for (int j = class.StartTime; j < class.EndTime; j += num4)
					{
						pButtonState pButtonState_;
						switch (num)
						{
						case 1:
							pButtonState_ = pButtonState.Right1;
							break;
						case 2:
							pButtonState_ = pButtonState.Left2;
							break;
						case 3:
							pButtonState_ = pButtonState.Right2;
							break;
						default:
							pButtonState_ = pButtonState.Left1;
							break;
						}
						list.Add(new Class14(j, class.Position.X, class.Position.Y, pButtonState_));
						num = (num + 1) % 4;
						if (++num2 > num3)
						{
							break;
						}
					}
				}
				else if (class is Class324)
				{
					Class324 class3 = class as Class324;
					double num5 = class3.method_33();
					double num6 = (double)class3.StartTime;
					for (int k = 0; k < class3.list_11.Count; k++)
					{
						list.Add(new Class14((int)num6, class.Position.X, class.Position.Y, flag ? pButtonState.Left1 : pButtonState.Left2));
						num6 += num5;
						flag = !flag;
					}
				}
				else
				{
					pButtonState pButtonState_;
					if (!class.Whistle && !class.Clap)
					{
						if (class.Finish)
						{
							pButtonState_ = (pButtonState.Left1 | pButtonState.Left2);
						}
						else
						{
							pButtonState_ = (flag ? pButtonState.Left1 : pButtonState.Left2);
						}
					}
					else if (class.Finish)
					{
						pButtonState_ = (pButtonState.Right1 | pButtonState.Right2);
					}
					else
					{
						pButtonState_ = (flag ? pButtonState.Right1 : pButtonState.Right2);
					}
					list.Add(new Class14(class.StartTime, class.Position.X, class.Position.Y, pButtonState_));
				}
				list.Add(new Class14(class.EndTime + 1, class.EndPosition.X, class.EndPosition.Y, pButtonState.None));
				if (i < this.class297_0.int_14 - 1)
				{
					int num7 = this.class297_0.list_3[i + 1].StartTime - 1000;
					if (num7 > class.EndTime)
					{
						list.Add(new Class14(num7, class.EndPosition.X, class.EndPosition.Y, pButtonState.None));
					}
				}
				flag = !flag;
			}
			Class62.class512_0.list_1 = Class802.class512_0.list_1;
			Class62.class512_0.string_2 = "mekkadosu!";
			List<Class14> arg_2FE_0 = Class802.class512_0.list_1;
			if (Class432.action_1 == null)
			{
				Class432.action_1 = new Action<Class14>(Class432.smethod_11);
			}
			arg_2FE_0.ForEach(Class432.action_1);
		}

		// Token: 0x06002A59 RID: 10841
		// RVA: 0x000207C0 File Offset: 0x0001E9C0
		internal override bool vmethod_3()
		{
			return this.class512_0.vmethod_1() > 0.8f;
		}

		// Token: 0x06002A58 RID: 10840
		// RVA: 0x00020783 File Offset: 0x0001E983
		internal override void vmethod_31()
		{
			if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.Flashlight))
			{
				this.class531_0.vector2_1 = new Vector2(208f, 208f);
			}
			base.vmethod_31();
		}

		// Token: 0x06002A4C RID: 10828
		// RVA: 0x001104D4 File Offset: 0x0010E6D4
		internal override void vmethod_33()
		{
			Action<Class304> action = null;
			this.class524_0.vmethod_0();
			if (this.list_1.Count > 1)
			{
				List<Class531> arg_3E_0 = this.list_1;
				if (Class432.predicate_2 == null)
				{
					Class432.predicate_2 = new Predicate<Class531>(Class432.smethod_4);
				}
				arg_3E_0.RemoveAll(Class432.predicate_2);
			}
			if (Class115.bool_13)
			{
				foreach (Class531 current in this.list_0)
				{
					Class531 expr_6E_cp_0 = current;
					expr_6E_cp_0.vector2_1.X = expr_6E_cp_0.vector2_1.X + (current.vector2_0.X - current.vector2_1.X + 2f) * 0.065f;
					current.float_2 *= 0.965f;
					Class531 expr_B5_cp_0 = current;
					expr_B5_cp_0.vector2_1.Y = expr_B5_cp_0.vector2_1.Y - (float)current.int_0 / 11.5f;
					current.int_0 -= 7;
					if (current.int_0 < 70 && current.class26_0.Count < 1)
					{
						current.method_16(300, Enum70.const_0);
					}
					if (current.int_0 < -32)
					{
						current.bool_0 = false;
					}
				}
				List<Class531> arg_150_0 = this.list_0;
				if (Class432.predicate_3 == null)
				{
					Class432.predicate_3 = new Predicate<Class531>(Class432.smethod_5);
				}
				arg_150_0.RemoveAll(Class432.predicate_3);
			}
			if (this.class413_0.vmethod_0() >= 50)
			{
				this.int_4 = (((this.class413_0.vmethod_0() >= 150) ? Class432.smethod_2(2) : Class432.smethod_2(1)) ? 0 : 1);
				List<Class304> arg_1B2_0 = this.class297_0.list_4;
				if (action == null)
				{
					action = new Action<Class304>(this.method_7);
				}
				arg_1B2_0.ForEach(action);
			}
			base.vmethod_33();
		}

		// Token: 0x06002A57 RID: 10839
		// RVA: 0x00111110 File Offset: 0x0010F310
		internal override bool vmethod_37(bool bool_2)
		{
			return (this.class304_0 == null || this.class304_0.bool_0) && (this.class297_0.list_3[this.class297_0.int_14 - 1].bool_0 || Class876.smethod_6(this.class512_0.class623_0, Mods.SuddenDeath)) && ((this.class512_0.vmethod_2() > 0 && this.class512_0.vmethod_3() == 0) | (this.class512_0.double_1 < 100.0 && !Class876.smethod_6(this.class512_0.class623_0, Mods.NoFail))) && base.vmethod_37(bool_2);
		}

		// Token: 0x06002A56 RID: 10838
		// RVA: 0x00111088 File Offset: 0x0010F288
		internal override void vmethod_38()
		{
			this.class512_0.bool_2 = (this.class410_0.method_2() > 100.0);
			if (!this.class512_0.bool_2 && !Class876.smethod_6(this.class512_0.class623_0, Mods.NoFail | Mods.Relax) && !Class115.bool_25)
			{
				this.class410_0.vmethod_10(0.0);
				return;
			}
			this.class524_0.method_1(Enum60.const_4, true);
			base.vmethod_38();
		}

		// Token: 0x06002A4F RID: 10831
		// RVA: 0x00020735 File Offset: 0x0001E935
		internal override void vmethod_39(Enum61 enum61_0, double double_5, Class304 class304_1)
		{
			if (enum61_0 == Enum61.flag_30)
			{
				this.class524_0.method_1(Enum60.const_4, true);
			}
			base.vmethod_39(enum61_0, double_5, class304_1);
		}

		// Token: 0x06002A3C RID: 10812
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal override bool vmethod_4()
		{
			return false;
		}

		// Token: 0x06002A55 RID: 10837
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal override bool vmethod_40()
		{
			return false;
		}

		// Token: 0x06002A61 RID: 10849
		// RVA: 0x000207F7 File Offset: 0x0001E9F7
		internal override void vmethod_41(Enum61 enum61_0, Class304 class304_1)
		{
			if (enum61_0 != Enum61.flag_5)
			{
				this.class62_0.method_62(enum61_0 != Enum61.flag_3);
			}
			base.vmethod_41(enum61_0, class304_1);
		}

		// Token: 0x06002A5A RID: 10842
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_42()
		{
		}

		// Token: 0x06002A63 RID: 10851
		// RVA: 0x00111DF8 File Offset: 0x0010FFF8
		internal override void vmethod_44()
		{
			this.class524_0.method_1(Enum60.const_4, true);
			if (this.class731_0 != null && this.class731_0.Length > 0)
			{
				Class531 class = new Class531(this.class731_0[this.int_2], Origins.BottomCentre, new Vector2(54f, 141f), 0.05f, false, Color.get_White());
				class.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, Class115.int_1, Class115.int_1 + 200, Enum70.const_0));
				class.class26_0.Add(new Class746(TransformationType.Scale, 0.6f, 1f, Class115.int_1, Class115.int_1 + 800, Enum70.const_1));
				class.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class115.int_1 + 1600, Class115.int_1 + 1900, Enum70.const_2));
				this.class62_0.class911_4.Add(class);
				this.int_2 = (this.int_2 + 1) % this.class731_0.Length;
			}
			this.vmethod_43();
		}

		// Token: 0x06002A5D RID: 10845
		// RVA: 0x0011121C File Offset: 0x0010F41C
		internal override void vmethod_46(bool bool_2)
		{
			if (bool_2)
			{
				this.class531_6.class26_0.Clear();
				this.class531_6.method_14(100, Enum70.const_0);
				this.class531_6.class26_0.Add(new Class746(TransformationType.Scale, 0.1f, 0.7f, Class115.int_1, Class115.int_1 + 120, Enum70.const_1));
				this.class531_8.method_14(150, Enum70.const_0);
				this.class524_0.method_1(Enum60.const_3, false);
			}
			else
			{
				this.class531_6.class26_0.Clear();
				this.class531_6.method_16(600, Enum70.const_0);
				this.class531_8.method_16(150, Enum70.const_0);
				this.class524_0.method_1(Enum60.const_1, false);
			}
			base.vmethod_46(bool_2);
		}

		// Token: 0x06002A4E RID: 10830
		// RVA: 0x0000B7FB File Offset: 0x000099FB
		internal override Enum111 vmethod_47(Class304 class304_1)
		{
			return Enum111.const_2;
		}

		// Token: 0x06002A64 RID: 10852
		// RVA: 0x00111F14 File Offset: 0x00110114
		internal override void vmethod_48(bool bool_2)
		{
			Class432.Class687 class = new Class432.Class687();
			class.bool_0 = bool_2;
			class.class432_0 = this;
			if (class.bool_0)
			{
				this.class524_0.method_1(Class62.bool_38 ? Enum60.const_3 : Enum60.const_1, false);
			}
			else
			{
				this.class524_0.method_1(Enum60.const_2, false);
			}
			class.list_0 = new List<Class531>();
			this.list_1.ForEach(new Action<Class531>(class.method_0));
			this.class62_0.class911_4.Add<Class531>(class.list_0);
			this.list_1 = class.list_0;
			if (class.list_0.Count > 0)
			{
				this.class531_10 = class.list_0[class.list_0.Count - 1];
			}
			base.vmethod_48(class.bool_0);
		}

		// Token: 0x06002A5F RID: 10847
		// RVA: 0x00111CD8 File Offset: 0x0010FED8
		internal override void vmethod_49()
		{
			base.vmethod_49();
			if (this.class533_0 != null)
			{
				this.class533_0.method_15(200);
				this.class533_0.method_19(this.class533_0.vector2_1 + new Vector2(25f, 0f), 500, Enum70.const_1);
			}
		}

		// Token: 0x06002A3E RID: 10814
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal override bool vmethod_5()
		{
			return true;
		}

		// Token: 0x06002A60 RID: 10848
		// RVA: 0x00111D38 File Offset: 0x0010FF38
		internal override void vmethod_50(Class531 class531_11)
		{
			if (Class876.smethod_5(Mods.Cinema))
			{
				return;
			}
			if (this.class62_0.class872_0.class702_0 != null && this.class62_0.class872_0.class702_0.class531_0 != null)
			{
				Class531 class531_12 = this.class62_0.class872_0.class702_0.class531_0;
				class531_11.vector2_1.Y = class531_11.vector2_1.Y + ((float)Class115.smethod_44() - (float)(Class115.smethod_44() - 289) / 2f - 240f);
				class531_11.vector2_5.Y = class531_12.vector2_5.Y + 15f * ((float)class531_11.int_6 / (float)class531_11.int_5 / 1.333f);
				return;
			}
		}

		// Token: 0x06002A3D RID: 10813
		// RVA: 0x00020681 File Offset: 0x0001E881
		internal override Vector2 vmethod_6()
		{
			return new Vector2((float)((Class802.bool_3 || Class802.bool_18) ? 0 : ((Class802.bool_5 || Class802.bool_20) ? 640 : 320)), 9999f);
		}

		// Token: 0x06002A40 RID: 10816
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal override bool vmethod_7()
		{
			return true;
		}

		// Token: 0x06002A41 RID: 10817
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal override bool vmethod_8()
		{
			return true;
		}

		// Token: 0x06002A45 RID: 10821
		// RVA: 0x001103C8 File Offset: 0x0010E5C8
		internal override bool vmethod_9()
		{
			List<Class304> arg_28_0 = this.class297_0.list_3;
			if (Class432.predicate_1 == null)
			{
				Class432.predicate_1 = new Predicate<Class304>(Class432.smethod_3);
			}
			int count = arg_28_0.FindAll(Class432.predicate_1).Count;
			return count == this.class512_0.vmethod_2();
		}
	}
}
