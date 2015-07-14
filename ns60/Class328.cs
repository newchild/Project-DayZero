using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns18;
using ns23;
using ns26;
using ns29;
using ns59;
using ns70;
using ns76;
using ns77;
using ns79;
using ns80;
using ns82;
using osu;
using osu.GameplayElements.HitObjects;
using osu.Graphics.Sprites;
using osu_common;
using System;
using System.Collections.Generic;

namespace ns60
{
	// Token: 0x02000558 RID: 1368
	internal class Class328 : Class325
	{
		// Token: 0x0400249B RID: 9371
		private bool bool_6;

		// Token: 0x040024A7 RID: 9383
		private bool bool_7;

		// Token: 0x040024AC RID: 9388
		private bool bool_8;

		// Token: 0x040024B9 RID: 9401
		private bool bool_9;

		// Token: 0x0400249A RID: 9370
		protected Class531 class531_0;

		// Token: 0x0400249C RID: 9372
		protected Class531 class531_1;

		// Token: 0x040024B6 RID: 9398
		private Class531 class531_10;

		// Token: 0x0400249D RID: 9373
		protected Class531 class531_2;

		// Token: 0x0400249E RID: 9374
		protected Class531 class531_3;

		// Token: 0x040024A0 RID: 9376
		protected Class531 class531_4;

		// Token: 0x040024A1 RID: 9377
		protected Class531 class531_5;

		// Token: 0x040024AE RID: 9390
		protected Class531 class531_6;

		// Token: 0x040024AF RID: 9391
		protected Class531 class531_7;

		// Token: 0x040024B0 RID: 9392
		protected Class531 class531_8;

		// Token: 0x040024B5 RID: 9397
		private Class531 class531_9;

		// Token: 0x0400249F RID: 9375
		protected Class536 class536_0;

		// Token: 0x040024AD RID: 9389
		protected Class536 class536_1;

		// Token: 0x040024A2 RID: 9378
		protected Class746 class746_0;

		// Token: 0x040024A4 RID: 9380
		private double double_1;

		// Token: 0x040024A6 RID: 9382
		private double double_2;

		// Token: 0x040024AA RID: 9386
		private double double_3;

		// Token: 0x040024B1 RID: 9393
		internal double double_4;

		// Token: 0x040024B2 RID: 9394
		protected double double_5;

		// Token: 0x040024B7 RID: 9399
		private float float_0;

		// Token: 0x040024B8 RID: 9400
		private float float_1;

		// Token: 0x040024BB RID: 9403
		private float float_2;

		// Token: 0x040024AB RID: 9387
		private int int_10;

		// Token: 0x040024B3 RID: 9395
		private int int_11;

		// Token: 0x040024B4 RID: 9396
		protected int int_12 = 45;

		// Token: 0x040024BC RID: 9404
		private int int_13;

		// Token: 0x040024A3 RID: 9379
		private int int_6;

		// Token: 0x040024A5 RID: 9381
		private int int_7;

		// Token: 0x040024A8 RID: 9384
		internal int int_8;

		// Token: 0x040024A9 RID: 9385
		internal int int_9;

		// Token: 0x040024BA RID: 9402
		private List<float> list_2;

		// Token: 0x1700039F RID: 927
		public override int ComboNumber
		{
			// Token: 0x06002C4F RID: 11343
			// RVA: 0x00006D2D File Offset: 0x00004F2D
			get
			{
				return 1;
			}
			// Token: 0x06002C50 RID: 11344
			// RVA: 0x0000653E File Offset: 0x0000473E
			set
			{
			}
		}

		// Token: 0x1700039E RID: 926
		public override Vector2 EndPosition
		{
			// Token: 0x06002C51 RID: 11345
			// RVA: 0x0001492A File Offset: 0x00012B2A
			get
			{
				return this.Position;
			}
			// Token: 0x06002C52 RID: 11346
			// RVA: 0x000219D8 File Offset: 0x0001FBD8
			set
			{
				this.Position = value;
			}
		}

		// Token: 0x06002C4C RID: 11340
		// RVA: 0x0011EAD8 File Offset: 0x0011CCD8
		internal Class328(Class297 class297_1, int int_14, int int_15, HitObjectSoundType hitObjectSoundType_0) : base(class297_1, int_14, int_15, hitObjectSoundType_0)
		{
			if (class297_1.class911_0 != null)
			{
				this.vmethod_24();
			}
			this.vmethod_26();
			if (class297_1.class911_0 != null)
			{
				this.vmethod_23();
			}
			this.bool_9 = true;
			this.list_2 = new List<float>(20);
		}

		// Token: 0x06002C5F RID: 11359
		// RVA: 0x0011FE90 File Offset: 0x0011E090
		internal override Class304 Clone()
		{
			Class304 class = new Class328(this.class297_0, this.StartTime, this.EndTime, this.SoundType);
			class.method_3(base.method_2());
			class.NewCombo = this.NewCombo;
			class.sampleSet_0 = this.sampleSet_0;
			class.sampleSet_1 = this.sampleSet_1;
			class.int_3 = this.int_3;
			class.int_2 = this.int_2;
			class.string_0 = this.string_0;
			return class;
		}

		// Token: 0x06002C5C RID: 11356
		// RVA: 0x0011FC64 File Offset: 0x0011DE64
		private void method_10(float float_3)
		{
			if (this.class531_7 != null && !this.bool_7)
			{
				this.class531_7.color_0 = new Color(3, 151, 255);
				if (this.class531_7.class26_0.Count > 0)
				{
					this.class531_7.class26_0[0].float_0 = Math.Min(1f, float_3 / 100f);
					this.class531_7.class26_0[0].float_1 = Math.Min(1f, float_3 / 100f);
				}
				this.class531_9.float_2 = (this.class531_10.float_2 = (this.class531_6.float_2 = (this.class531_8.float_2 = (this.class531_7.float_2 = 0.8f + Class778.smethod_11(float_3 / 100f, 0f, 0.2f, 1f)))));
			}
			float_3 = Math.Min(99f, float_3);
			int num = (int)float_3 % 10;
			int num2 = (int)float_3 / 10;
			if (Class885.class547_0.bool_8 || Class562.smethod_7((double)((float)num / 10f)))
			{
				num2++;
			}
			if (this.class531_4 != null)
			{
				this.class531_4.int_3 = (int)(69.2 * (double)(10 - num2));
				this.class531_4.int_1 = (int)(69.2 * (double)num2);
				this.class531_4.vector2_1.Y = (float)((double)this.int_12 + 43.25 * (double)(10 - num2));
			}
		}

		// Token: 0x06002C66 RID: 11366
		// RVA: 0x001200CC File Offset: 0x0011E2CC
		internal Enum61 method_11()
		{
			Enum61 result = Enum61.flag_5;
			if (this.int_8 != this.int_7)
			{
				this.int_10++;
				if (Class885.class547_0.bool_5)
				{
					Class331.smethod_56((float)this.int_10 / (float)this.int_9);
				}
				if (this.int_10 > this.int_9 + 3 && (this.int_10 - (this.int_9 + 3)) % 2 == 0)
				{
					if (this.class531_7 != null)
					{
						this.class531_7.method_40(Color.get_White(), 200);
					}
					result = Enum61.flag_26;
					if (!Class876.smethod_5(Mods.Cinema))
					{
						Class331.smethod_59("spinnerbonus", Class331.smethod_81(), Enum112.flag_6);
					}
					this.class536_1.Text = (1000 * (this.int_10 - (this.int_9 + 3)) / 2).ToString();
					this.class536_1.class26_0.Clear();
					this.class536_1.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class331.int_7, Class331.int_7 + 800, Enum70.const_0));
					this.class536_1.class26_0.Add(new Class746(TransformationType.Scale, 2f, 1.28f, Class331.int_7, Class331.int_7 + 800, Enum70.const_0));
					this.class536_1.class26_0[0].enum70_0 = Enum70.const_1;
					this.class536_1.class26_0[1].enum70_0 = Enum70.const_1;
					this.class536_1.class26_0.Add(new Class746(TransformationType.Fade, 0f, 0f, this.EndTime + 800, this.EndTime + 800, Enum70.const_0));
				}
				else if (this.int_10 > 1 && this.int_10 % 2 == 0)
				{
					result = Enum61.flag_25;
				}
				else if (this.int_10 > 1)
				{
					result = Enum61.flag_24;
				}
			}
			this.int_7 = this.int_8;
			return result;
		}

		// Token: 0x06002C67 RID: 11367
		// RVA: 0x001202C0 File Offset: 0x0011E4C0
		private void method_12(float float_3)
		{
			if (!this.bool_9 || Class62.class62_0 == null)
			{
				return;
			}
			if (float_3 < 100f || this.double_3 < 450.0)
			{
				return;
			}
			if (this.list_2.Count == 20)
			{
				this.float_2 -= this.list_2[0];
				this.list_2.RemoveAt(0);
			}
			this.float_2 += float_3;
			this.list_2.Add(float_3);
			if (this.list_2.Count < 20)
			{
				return;
			}
			float num = this.float_2 / (float)this.list_2.Count;
			int num2 = 0;
			for (int i = 0; i < 20; i++)
			{
				if (Math.Abs(this.list_2[i] - num) < 1f)
				{
					num2++;
				}
			}
			this.list_2.Clear();
			this.float_2 = 0f;
			this.int_13++;
			if (this.int_13 >= 5)
			{
				this.bool_9 = false;
			}
			if (num2 == 20)
			{
				Class62.class62_0.method_5();
				this.bool_9 = false;
			}
		}

		// Token: 0x06002C58 RID: 11352
		// RVA: 0x00021A47 File Offset: 0x0001FC47
		private float method_8()
		{
			if (this.class531_10 != null && this.class531_10.vmethod_6() != null)
			{
				return 0.5f;
			}
			return 1f;
		}

		// Token: 0x06002C5A RID: 11354
		// RVA: 0x0011FC00 File Offset: 0x0011DE00
		private void method_9()
		{
			float? arg_4F_0;
			if (!Class885.class547_0.bool_5)
			{
				arg_4F_0 = null;
			}
			else
			{
				float? num = new float?((float)this.int_10);
				float num2 = (float)this.int_9;
				arg_4F_0 = (num.HasValue ? new float?(num.GetValueOrDefault() / num2) : null);
			}
			Class331.smethod_64(arg_4F_0);
		}

		// Token: 0x06002C60 RID: 11360
		// RVA: 0x00021A70 File Offset: 0x0001FC70
		internal override void Select()
		{
			this.class531_6.color_0 = Color.get_BlueViolet();
		}

		// Token: 0x06002C5D RID: 11357
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_0(Color color_0)
		{
		}

		// Token: 0x06002C65 RID: 11365
		// RVA: 0x0011FF44 File Offset: 0x0011E144
		internal override Enum61 vmethod_17(Vector2 vector2_1)
		{
			if (!Class802.bool_25)
			{
				return Enum61.flag_5;
			}
			Vector2 vector = vector2_1 - this.class531_6.vector2_3;
			double num = Math.Atan2((double)vector.Y, (double)vector.X);
			float float_ = vector.LengthSquared();
			double num2 = num - this.double_1;
			this.method_12(float_);
			if (num - this.double_1 < -3.1415926535897931)
			{
				num2 = 6.2831853071795862 + num - this.double_1;
			}
			else if (this.double_1 - num < -3.1415926535897931)
			{
				num2 = -6.2831853071795862 - this.double_1 + num;
			}
			if (num2 == 0.0)
			{
				if (this.int_11++ < 1)
				{
					this.double_5 /= 3.0;
				}
				else
				{
					this.double_5 = 0.0;
				}
			}
			else
			{
				this.int_11 = 0;
				if (!Class62.bool_15 && ((Class802.buttonState_0 == null && Class802.buttonState_5 == null) || Class331.int_7 < this.StartTime || Class331.int_7 > this.EndTime))
				{
					num2 = 0.0;
				}
				if (Math.Abs(num2) < 3.1415926535897931 && Class115.double_1 > 0.0)
				{
					this.double_5 = num2 / 16.666666666666668;
				}
				else
				{
					this.double_5 = 0.0;
				}
			}
			this.double_1 = num;
			return this.method_11();
		}

		// Token: 0x06002C5B RID: 11355
		// RVA: 0x00021A69 File Offset: 0x0001FC69
		internal override void vmethod_18()
		{
			Class331.smethod_95();
		}

		// Token: 0x06002C54 RID: 11348
		// RVA: 0x00021A08 File Offset: 0x0001FC08
		internal override void vmethod_19(int int_14)
		{
			this.EndTime = Math.Max(this.StartTime, int_14);
			this.vmethod_26();
		}

		// Token: 0x06002C5E RID: 11358
		// RVA: 0x0011FE08 File Offset: 0x0011E008
		internal override Enum61 vmethod_2()
		{
			this.vmethod_18();
			if (this.class531_7 != null)
			{
				this.class531_7.method_16(300, Enum70.const_0);
			}
			this.bool_0 = true;
			Enum61 enum = Enum61.flag_3;
			if (this.int_10 > this.int_9 + 1)
			{
				enum = Enum61.flag_16;
			}
			else if (this.int_10 > this.int_9)
			{
				enum = Enum61.flag_15;
			}
			else if (this.int_10 > this.int_9 - 1)
			{
				enum = Enum61.flag_14;
			}
			if (enum > Enum61.flag_5)
			{
				this.vmethod_12();
			}
			return enum;
		}

		// Token: 0x06002C57 RID: 11351
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_21()
		{
		}

		// Token: 0x06002C4D RID: 11341
		// RVA: 0x0011EB30 File Offset: 0x0011CD30
		protected virtual void vmethod_23()
		{
			if (Class115.osuModes_1 == OsuModes.Play)
			{
				this.class531_5 = new Class531(Class885.Load("spinner-spin", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_1, new Vector2(320f, (float)(this.int_12 + 335)), Class911.smethod_2((float)(this.StartTime + 6)), false, Color.get_White(), null);
				this.class531_5.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, this.StartTime - Class297.int_2 / 2, this.StartTime, Enum70.const_0));
				this.class531_5.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, this.EndTime - Math.Min(400, this.EndTime - this.StartTime), this.EndTime, Enum70.const_0));
				this.list_1.Add(this.class531_5);
				this.class531_2 = new Class531(Class885.Load("spinner-clear", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_1, new Vector2(320f, (float)(this.int_12 + 115)), Class911.smethod_2((float)(this.StartTime + 7)), false, Color.get_White(), null);
				this.class531_2.class26_0.Add(new Class746(TransformationType.Fade, 0f, 0f, this.StartTime, this.EndTime, Enum70.const_0));
				this.list_1.Add(this.class531_2);
			}
			if (this.bool_6)
			{
				this.class531_7 = new Class531(Class885.Load("spinner-glow", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_1, new Vector2(320f, (float)(this.int_12 + 219)), Class911.smethod_2((float)(this.StartTime - 1)), false, Color.get_TransparentWhite(), null);
				this.class531_7.bool_7 = true;
				this.class531_7.class26_0.Add(new Class746(TransformationType.Fade, 0f, 0f, this.StartTime, this.EndTime, Enum70.const_0));
				this.list_1.Add(this.class531_7);
				Class530 arg_248_0 = this.class531_9;
				Class530 arg_242_0 = this.class531_10;
				Class530 arg_236_0 = this.class531_6;
				Class530 arg_22A_0 = this.class531_8;
				Class530 arg_21E_0 = this.class531_7;
				float arg_21E_1 = 0.8f;
				float num = 0.8f;
				arg_21E_0.float_2 = arg_21E_1;
				float arg_22A_1 = num;
				float num2 = 0.8f;
				arg_22A_0.float_2 = arg_22A_1;
				float arg_236_1 = num2;
				float num3 = 0.8f;
				arg_236_0.float_2 = arg_236_1;
				float arg_242_1 = num3;
				float num4 = 0.8f;
				arg_242_0.float_2 = arg_242_1;
				arg_248_0.float_2 = num4;
			}
		}

		// Token: 0x06002C4E RID: 11342
		// RVA: 0x0011ED8C File Offset: 0x0011CF8C
		internal virtual void vmethod_24()
		{
			if (Class115.bool_22)
			{
				this.int_12 -= 16;
			}
			Color color = (Class115.osuModes_1 != OsuModes.Play || Class62.class512_0 == null || (!Class876.smethod_6(this.class297_0.class623_0, Mods.SpunOut) && !Class62.bool_16)) ? Color.get_White() : Color.get_Gray();
			if (Class115.osuModes_1 == OsuModes.Play && Class885.class547_0.bool_7)
			{
				Class531 class = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_1, new Vector2(0f, 0f), Class911.smethod_2((float)(this.StartTime - 1)), false, Color.get_Black(), null);
				class.float_2 = 1.6f;
				class.vector2_2 = new Vector2(640f, (float)this.int_12);
				this.list_1.Add(class);
				if (Class115.bool_22)
				{
					class = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_1, new Vector2(0f, 461f), Class911.smethod_2((float)(this.StartTime - 1)), false, Color.get_Black(), null);
					class.float_2 = 1.6f;
					class.vector2_2 = new Vector2(640f, 19f);
					this.list_1.Add(class);
				}
			}
			this.bool_6 = (Class885.smethod_25() && (Class885.bool_2 || Class885.Load("spinner-circle", Enum112.flag_3) == null) && Class885.Load("spinner-background", Enum112.flag_2) == null);
			if (!this.bool_6)
			{
				Class731 class2 = null;
				if (!Class885.bool_2)
				{
					class2 = Class885.Load("spinner-background.jpg", Enum112.flag_3);
				}
				if (class2 == null)
				{
					class2 = Class885.Load("spinner-background", Enum112.flag_2 | Enum112.flag_3);
				}
				this.class531_1 = new Class531(class2, Enum115.const_5, Origins.Centre, Enum114.const_1, new Vector2(320f, (float)(this.int_12 + 219)), Class911.smethod_2((float)(this.StartTime - 1)), false, Class885.dictionary_7.ContainsKey("SpinnerBackground") ? Class885.dictionary_7["SpinnerBackground"] : new Color(100, 100, 100, 255), null);
				this.list_1.Add(this.class531_1);
			}
			if (this.bool_6)
			{
				this.class531_6 = new Class531(Class885.Load("spinner-top", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_1, new Vector2(320f, (float)(this.int_12 + 219)), Class911.smethod_2((float)(this.StartTime + 1)), false, color, null);
				this.list_1.Add(this.class531_6);
				this.class531_8 = new Class531(Class885.Load("spinner-bottom", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_1, new Vector2(320f, (float)(this.int_12 + 219)), Class911.smethod_2((float)this.StartTime), false, color, null);
				this.list_1.Add(this.class531_8);
				this.class531_9 = new Class531(Class885.Load("spinner-middle", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_1, new Vector2(320f, (float)(this.int_12 + 219)), Class911.smethod_2((float)(this.StartTime + 3)), false, Color.get_TransparentWhite(), null);
				this.list_1.Add(this.class531_9);
				this.class531_10 = new Class531(Class885.Load("spinner-middle2", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_1, new Vector2(320f, (float)(this.int_12 + 219)), Class911.smethod_2((float)(this.StartTime + 2)), false, Color.get_TransparentWhite(), null);
				this.list_1.Add(this.class531_10);
			}
			else
			{
				this.class531_6 = new Class531(Class885.Load("spinner-circle", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_1, new Vector2(320f, (float)(this.int_12 + 219)), Class911.smethod_2((float)this.StartTime), false, color, null);
				this.list_1.Add(this.class531_6);
			}
			if (!this.bool_6)
			{
				this.class531_4 = new Class531(Class885.Load("spinner-metre", Enum112.flag_6), Enum115.const_5, Origins.TopLeft, Enum114.const_1, new Vector2(0f, (float)this.int_12), Class911.smethod_2((float)(this.StartTime + 1)), false, color, null);
				this.class531_4.int_1 = 0;
				this.list_1.Add(this.class531_4);
			}
			if (Class115.osuModes_1 == OsuModes.Play)
			{
				this.class531_3 = new Class531(Class885.Load("spinner-rpm", Enum112.flag_6), Enum115.const_5, Origins.TopLeft, Enum114.const_1, new Vector2(233f, 445f), Class911.smethod_2((float)(this.StartTime + 3)), false, color, null);
				this.class536_0 = new Class536("", Class885.class547_0.string_4, Class885.class547_0.int_1, Enum115.const_5, Origins.TopRight, Enum114.const_1, new Vector2(400f, 448f), Class911.smethod_2((float)(this.StartTime + 4)), false, color, true);
				this.class536_0.float_2 = 0.9f;
				this.list_1.Add(this.class536_0);
				this.list_1.Add(this.class531_3);
			}
			if (this.class531_6.vmethod_6().enum112_0 != Enum112.flag_1 && !Class876.smethod_6(this.class297_0.class623_0, Mods.Hidden))
			{
				this.class531_0 = new Class531(Class885.Load("spinner-approachcircle", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_1, new Vector2(320f, (float)(this.int_12 + 219)), Class911.smethod_2((float)(this.StartTime + 2)), false, color, null);
				this.list_1.Add(this.class531_0);
			}
			this.class536_1 = new Class536("", Class885.class547_0.string_4, Class885.class547_0.int_1, Enum115.const_5, Origins.Centre, Enum114.const_1, new Vector2(320f, (float)(this.int_12 + 299)), Class911.smethod_2((float)(this.StartTime + 3)), false, color, true);
			if (this.class531_6.vmethod_6().enum112_0 == Enum112.flag_1)
			{
				this.class536_1.bool_7 = true;
			}
			this.list_1.Add(this.class536_1);
		}

		// Token: 0x06002C55 RID: 11349
		// RVA: 0x00021A22 File Offset: 0x0001FC22
		protected virtual Class746 vmethod_25()
		{
			return new Class746(TransformationType.Fade, 0f, 1f, this.StartTime - Class297.int_2, this.StartTime, Enum70.const_0);
		}

		// Token: 0x06002C56 RID: 11350
		// RVA: 0x0011F36C File Offset: 0x0011D56C
		protected virtual void vmethod_26()
		{
			foreach (Class531 current in this.list_1)
			{
				if (current.int_0 != -5)
				{
					current.class26_0.Clear();
					current.class26_0.Add(this.vmethod_25());
					current.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, this.EndTime, this.EndTime + Class297.int_3, Enum70.const_0));
				}
			}
			if (this.class531_0 != null)
			{
				this.class531_0.class26_0.Add(new Class746(TransformationType.Scale, 1.86f, 0.1f, this.StartTime, this.EndTime, Enum70.const_0));
			}
			this.class746_0 = new Class746(TransformationType.Rotation, 0f, 0f, this.StartTime, this.EndTime, Enum70.const_0);
			if (this.class531_6 != null)
			{
				this.class531_6.class26_0.Add(this.class746_0);
			}
			if (this.class536_0 != null)
			{
				this.class536_0.class26_0.Add(new Class746(this.class536_0.vector2_1 + new Vector2(0f, 50f), this.class536_0.vector2_1, this.StartTime - Class297.int_2, this.StartTime, Enum70.const_1));
			}
			if (this.class531_3 != null)
			{
				this.class531_3.class26_0.Add(new Class746(this.class531_3.vector2_1 + new Vector2(0f, 50f), this.class531_3.vector2_1, this.StartTime - Class297.int_2, this.StartTime, Enum70.const_1));
			}
			this.int_8 = 0;
			this.int_9 = (int)((double)((float)base.Length / 1000f) * this.class297_0.SpinnerRotationRatio);
			this.double_2 = 8E-05 + Math.Max(0.0, (5000.0 - (double)base.Length) / 1000.0 / 2000.0);
		}

		// Token: 0x06002C61 RID: 11361
		// RVA: 0x00021A82 File Offset: 0x0001FC82
		internal override void vmethod_3()
		{
			this.class531_6.color_0 = Color.get_White();
		}

		// Token: 0x06002C62 RID: 11362
		// RVA: 0x0011FF10 File Offset: 0x0011E110
		internal override void vmethod_4(int int_14)
		{
			int num = int_14 - this.StartTime;
			this.StartTime += num;
			this.vmethod_19(this.EndTime + num);
		}

		// Token: 0x06002C63 RID: 11363
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_5(Vector2 vector2_1, bool bool_10)
		{
		}

		// Token: 0x06002C59 RID: 11353
		// RVA: 0x0011F5A4 File Offset: 0x0011D7A4
		internal override void vmethod_6()
		{
			if (Class331.int_7 < this.EndTime && this.bool_0)
			{
				this.vmethod_7();
			}
			if (!this.bool_0 && Class802.bool_25 && Class331.int_7 >= this.StartTime)
			{
				this.int_6++;
				this.double_3 = this.double_3 * 0.9 + 0.1 * (Math.Abs(this.double_4) * 16.666666666666668 * 60.0) / 6.2831853071795862 * 60.0;
				if (this.class536_0 != null)
				{
					this.class536_0.Text = string.Format("{0:#,0}", this.double_3);
				}
				if (Class62.class62_0 != null && Class62.Mode == PlayModes.Osu)
				{
					Class62.class62_0.method_69((int)this.double_3);
				}
				if (this.class531_9 != null)
				{
					this.class531_9.color_0 = Class610.smethod_3(Color.get_White(), Color.get_Red(), (float)(Class331.int_7 - this.StartTime) / (float)base.Length);
				}
				if (Class115.osuModes_1 == OsuModes.Edit)
				{
					this.class746_0.float_1 = (float)((double)this.int_9 * 3.1415926535897931);
					this.float_0 = (float)(this.int_8 = (int)((double)((float)(Class331.int_7 - this.StartTime) / 1000f) * this.class297_0.SpinnerRotationRatio));
				}
				else if (Class331.int_7 < this.EndTime && Class331.int_7 > this.StartTime && !Class62.bool_13)
				{
					if (this.class531_6.class26_0.Contains(this.class746_0))
					{
						this.class531_6.class26_0.Remove(this.class746_0);
					}
					double num = this.double_2 * 16.666666666666668;
					if ((Class115.osuModes_1 == OsuModes.Play && Class876.smethod_6(this.class297_0.class623_0, Mods.SpunOut)) || Class62.bool_16)
					{
						this.double_4 = 0.03;
					}
					else if (this.double_5 > this.double_4)
					{
						this.double_4 += Math.Min(this.double_5 * 1.0 - this.double_4, (this.double_4 >= 0.0 || !Class62.bool_15) ? num : (num / 4.0));
					}
					else
					{
						this.double_4 += Math.Max(this.double_5 * 1.0 - this.double_4, (this.double_4 <= 0.0 || !Class62.bool_15) ? (-num) : (-num / 4.0));
					}
					this.double_4 = Math.Max(-0.05, Math.Min(this.double_4, 0.05));
					this.class531_6.float_1 = this.class531_6.float_1 + (float)(this.double_4 * (double)this.method_8() * 16.666666666666668);
					if (this.class531_10 != null)
					{
						this.class531_10.float_1 = this.class531_10.float_1 + (float)(this.double_4 * 16.666666666666668);
						this.class531_8.float_1 = this.class531_6.float_1 / 3f;
					}
					if (this.double_4 != 0.0)
					{
						this.method_9();
					}
					else
					{
						this.vmethod_18();
					}
					float num2;
					if (Class115.osuModes_1 == OsuModes.Play && Class876.smethod_6(this.class297_0.class623_0, Mods.DoubleTime))
					{
						num2 = (float)((double)(this.class531_6.float_1 / this.method_8()) / 3.1415926535897931 * 1.5);
					}
					else if (Class115.osuModes_1 == OsuModes.Play && Class876.smethod_6(this.class297_0.class623_0, Mods.HalfTime))
					{
						num2 = (float)((double)(this.class531_6.float_1 / this.method_8()) / 3.1415926535897931 * 0.75);
					}
					else
					{
						num2 = (float)((double)(this.class531_6.float_1 / this.method_8()) / 3.1415926535897931);
					}
					this.float_0 += Math.Abs(num2 - this.float_1);
					this.float_1 = num2;
				}
				this.int_8 = (int)this.float_0;
				this.method_10(Math.Abs(this.float_0) / (float)this.int_9 * 100f);
				if (this.int_10 >= this.int_9 && !this.bool_7)
				{
					if (this.class531_7 != null)
					{
						this.class531_7.color_0 = new Color(3, 151, 255);
					}
					this.bool_7 = true;
					if (this.class531_5 != null)
					{
						this.class531_5.method_16(100, Enum70.const_0);
						this.class531_2.class26_0.Clear();
						this.class531_2.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, Class331.int_7, Math.Min(this.EndTime, Class331.int_7 + 400), Enum70.const_1));
						this.class531_2.class26_0.Add(new Class746(TransformationType.Scale, 2f, 0.8f, Class331.int_7, Math.Min(this.EndTime, Class331.int_7 + 240), Enum70.const_1));
						this.class531_2.class26_0.Add(new Class746(TransformationType.Scale, 0.8f, 1f, Math.Min(this.EndTime, Class331.int_7 + 240), Math.Min(this.EndTime, Class331.int_7 + 400), Enum70.const_0));
						this.class531_2.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, this.EndTime - 50, this.EndTime, Enum70.const_0));
					}
				}
				if (this.int_10 > 0 && !this.bool_8 && this.class531_5 != null && Class331.int_7 > this.StartTime + 500)
				{
					this.class531_5.method_16(300, Enum70.const_0);
					this.bool_8 = true;
				}
				return;
			}
		}

		// Token: 0x06002C64 RID: 11364
		// RVA: 0x00021A94 File Offset: 0x0001FC94
		internal override void vmethod_7()
		{
			base.vmethod_7();
		}

		// Token: 0x06002C53 RID: 11347
		// RVA: 0x000219E1 File Offset: 0x0001FBE1
		internal override bool vmethod_9()
		{
			return Class331.int_7 >= this.StartTime - Class297.int_2 && Class331.int_7 <= this.EndTime;
		}
	}
}
