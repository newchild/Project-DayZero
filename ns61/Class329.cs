using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns18;
using ns23;
using ns26;
using ns29;
using ns60;
using ns70;
using ns76;
using ns79;
using ns8;
using ns80;
using ns82;
using osu;
using osu.GameplayElements.HitObjects;
using osu.Graphics.Sprites;
using osu_common;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns61
{
	// Token: 0x02000559 RID: 1369
	internal sealed class Class329 : Class328
	{
		// Token: 0x040024C3 RID: 9411
		[CompilerGenerated]
		private static Action<Class746> action_2;

		// Token: 0x040024C5 RID: 9413
		[CompilerGenerated]
		private static Action<Class531> action_3;

		// Token: 0x040024BD RID: 9405
		private bool bool_10;

		// Token: 0x040024BE RID: 9406
		private byte byte_0;

		// Token: 0x040024C1 RID: 9409
		internal Class531 class531_11;

		// Token: 0x040024BF RID: 9407
		private int int_14;

		// Token: 0x040024C0 RID: 9408
		private int int_15;

		// Token: 0x040024C2 RID: 9410
		internal int int_16;

		// Token: 0x040024C4 RID: 9412
		[CompilerGenerated]
		private static Predicate<Class746> predicate_3;

		// Token: 0x040024C6 RID: 9414
		[CompilerGenerated]
		private static Predicate<Class746> predicate_4;

		// Token: 0x040024C7 RID: 9415
		[CompilerGenerated]
		private static Predicate<Class746> predicate_5;

		// Token: 0x06002C68 RID: 11368
		// RVA: 0x001203EC File Offset: 0x0011E5EC
		public Class329(Class297 class297_1, int int_17, int int_18, HitObjectSoundType hitObjectSoundType_0) : base(class297_1, int_17, int_18, hitObjectSoundType_0)
		{
			this.int_9 = (int)Math.Max(1f, (float)this.int_9 * 1.65f);
			this.int_16 = this.int_9;
			if (Class876.smethod_6(this.class297_0.class623_0, Mods.DoubleTime))
			{
				this.int_9 = Math.Max(1, (int)((float)this.int_9 * 0.75f));
			}
			if (Class876.smethod_6(this.class297_0.class623_0, Mods.HalfTime))
			{
				this.int_9 = Math.Max(1, (int)((float)this.int_9 * 1.5f));
			}
			if (this.class297_0.class911_0 != null)
			{
				this.class536_1.class26_0 = new Class26<Class746>(this.class531_6.class26_0);
				this.class536_1.Text = (this.int_9 + 1).ToString();
				this.class531_11 = new Class531(Class885.Load("spinner-warning", Enum112.flag_6), Enum115.const_1, Origins.Centre, Enum114.const_1, this.Position, Class911.smethod_4((float)(this.StartTime + 1)), false, Color.get_White(), null);
				this.list_1.Add(this.class531_11);
				this.class531_11.int_0 = -5;
				this.list_0.Add(this.class531_11);
				this.class531_11.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, int_17 - this.class297_0.PreEmpt, int_17 - (int)((double)this.class297_0.PreEmpt * 0.6), Enum70.const_0));
			}
			this.bool_2 = false;
		}

		// Token: 0x06002C70 RID: 11376
		// RVA: 0x00021AD9 File Offset: 0x0001FCD9
		internal override void Draw()
		{
			base.Draw();
		}

		// Token: 0x06002C73 RID: 11379
		// RVA: 0x00021AE1 File Offset: 0x0001FCE1
		[CompilerGenerated]
		private static void smethod_5(Class746 class746_1)
		{
			class746_1.float_0 *= 0.8f;
			class746_1.float_1 *= 0.8f;
		}

		// Token: 0x06002C74 RID: 11380
		// RVA: 0x00018A5A File Offset: 0x00016C5A
		[CompilerGenerated]
		private static bool smethod_6(Class746 class746_1)
		{
			return class746_1.transformationType_0 == TransformationType.Scale;
		}

		// Token: 0x06002C75 RID: 11381
		// RVA: 0x00017922 File Offset: 0x00015B22
		[CompilerGenerated]
		private static void smethod_7(Class531 class531_12)
		{
			class531_12.method_16(300, Enum70.const_0);
		}

		// Token: 0x06002C76 RID: 11382
		// RVA: 0x00018A5A File Offset: 0x00016C5A
		[CompilerGenerated]
		private static bool smethod_8(Class746 class746_1)
		{
			return class746_1.transformationType_0 == TransformationType.Scale;
		}

		// Token: 0x06002C77 RID: 11383
		// RVA: 0x00018A5A File Offset: 0x00016C5A
		[CompilerGenerated]
		private static bool smethod_9(Class746 class746_1)
		{
			return class746_1.transformationType_0 == TransformationType.Scale;
		}

		// Token: 0x06002C71 RID: 11377
		// RVA: 0x001208F0 File Offset: 0x0011EAF0
		internal override Enum61 vmethod_17(Vector2 vector2_1)
		{
			if (Class331.int_7 < this.StartTime || this.bool_10)
			{
				return Enum61.flag_5;
			}
			bool flag = false;
			bool flag2 = Class802.bool_4 || Class802.bool_6;
			bool flag3 = Class802.bool_19 || Class802.bool_21;
			if (Class62.bool_15 && (flag2 || flag3))
			{
				flag = true;
			}
			if (Class331.int_7 - this.int_15 >= 30 && !Class62.bool_15)
			{
				if (flag2)
				{
					if (this.byte_0 == 1)
					{
						this.int_15 = Class331.int_7;
						return Enum61.flag_5;
					}
					flag = true;
					this.byte_0 = 1;
				}
				else if (flag3)
				{
					if (this.byte_0 == 2)
					{
						this.int_15 = Class331.int_7;
						return Enum61.flag_5;
					}
					flag = true;
					this.byte_0 = 2;
				}
			}
			if (flag)
			{
				this.int_14 = Class331.int_7;
				this.double_5 += 0.03;
				this.int_9--;
				this.class536_1.Text = (this.int_9 + 1).ToString();
				List<Class746> arg_123_0 = this.class531_6.class26_0;
				if (Class329.predicate_4 == null)
				{
					Class329.predicate_4 = new Predicate<Class746>(Class329.smethod_8);
				}
				arg_123_0.RemoveAll(Class329.predicate_4);
				this.class531_6.class26_0.Add(new Class746(TransformationType.Scale, Math.Min(0.94f, this.class531_6.float_2 + 0.02f), 0.8f, Class331.int_7, Class331.int_7 + 400, Enum70.const_1));
				List<Class746> arg_198_0 = this.class536_1.class26_0;
				if (Class329.predicate_5 == null)
				{
					Class329.predicate_5 = new Predicate<Class746>(Class329.smethod_9);
				}
				arg_198_0.RemoveAll(Class329.predicate_5);
				this.class536_1.class26_0.Add(new Class746(TransformationType.Scale, this.class536_1.float_2, 1.6f - 0.6f * (float)this.int_9 / (float)this.int_16, Class331.int_7, Class331.int_7 + 60, Enum70.const_1));
			}
			if (this.int_9 < 0 && !this.bool_10)
			{
				this.EndTime = Class331.int_7;
				this.bool_10 = true;
			}
			this.double_5 *= Math.Pow(0.88, Class115.double_0);
			if (!flag)
			{
				return Enum61.flag_5;
			}
			return Enum61.flag_29;
		}

		// Token: 0x06002C6E RID: 11374
		// RVA: 0x00120788 File Offset: 0x0011E988
		internal override Enum61 vmethod_2()
		{
			this.bool_0 = true;
			this.double_4 = 0.0;
			this.vmethod_18();
			if (this.int_9 < 0)
			{
				Class331.smethod_59("spinner-osu", Class331.smethod_81(), Enum112.flag_6);
				if (this.class531_0 != null)
				{
					this.class531_0.class26_0.Clear();
				}
				List<Class746> arg_79_0 = this.class531_6.class26_0;
				if (Class329.predicate_3 == null)
				{
					Class329.predicate_3 = new Predicate<Class746>(Class329.smethod_6);
				}
				arg_79_0.RemoveAll(Class329.predicate_3);
				this.class531_6.class26_0.Add(new Class746(TransformationType.Scale, this.class531_6.float_2, this.class531_6.float_2 + 0.05f, Class331.int_7, Class331.int_7 + 300, Enum70.const_1));
				List<Class531> arg_E5_0 = this.list_1;
				if (Class329.action_3 == null)
				{
					Class329.action_3 = new Action<Class531>(Class329.smethod_7);
				}
				arg_E5_0.ForEach(Class329.action_3);
				this.EndTime = Class331.int_7;
				return Enum61.flag_30;
			}
			return Enum61.flag_1;
		}

		// Token: 0x06002C6F RID: 11375
		// RVA: 0x00120898 File Offset: 0x0011EA98
		internal override bool vmethod_20(Vector2 vector2_1, bool bool_11, float float_3)
		{
			return (!bool_11 && this.vmethod_9()) || (this.StartTime - this.class297_0.PreEmpt <= Class331.int_7 && this.StartTime + this.class297_0.HitWindow50 >= Class331.int_7 && !this.bool_0);
		}

		// Token: 0x06002C72 RID: 11378
		// RVA: 0x00021756 File Offset: 0x0001F956
		protected override int vmethod_22()
		{
			return (int)(600.0 / this.class297_0.SliderVelocityAt(this.StartTime) / 0.60000002384185791 * 1000.0);
		}

		// Token: 0x06002C6B RID: 11371
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected override void vmethod_23()
		{
		}

		// Token: 0x06002C6A RID: 11370
		// RVA: 0x00120590 File Offset: 0x0011E790
		internal override void vmethod_24()
		{
			if (Class115.bool_22)
			{
				this.int_12 -= 16;
			}
			Color color = (Class115.osuModes_1 != OsuModes.Play || (!Class876.smethod_6(this.class297_0.class623_0, Mods.SpunOut) && !Class62.bool_16)) ? Color.get_White() : Color.get_Gray();
			this.class531_6 = new Class531(Class885.Load("spinner-circle", Enum112.flag_5), Enum115.const_5, Origins.Centre, Enum114.const_1, new Vector2(320f, (float)(this.int_12 + 219)), Class911.smethod_4((float)this.EndTime), false, color, null);
			this.list_1.Add(this.class531_6);
			if (!Class876.smethod_6(this.class297_0.class623_0, Mods.Hidden))
			{
				Class885.Load("spinner-approachcircle", Enum112.flag_2);
				this.class531_0 = new Class531(Class885.Load("spinner-approachcircle", Enum112.flag_5), Enum115.const_5, Origins.Centre, Enum114.const_1, new Vector2(320f, (float)(this.int_12 + 219)), Class911.smethod_4((float)(this.EndTime - 2)), false, color, null);
				this.list_1.Add(this.class531_0);
			}
			this.class536_1 = new Class536("", Class885.class547_0.string_4, Class885.class547_0.int_1, Enum115.const_5, Origins.Centre, Enum114.const_1, new Vector2(320f, (float)(this.int_12 + 299)), Class911.smethod_4((float)(this.EndTime - 3)), false, color, true);
			this.list_1.Add(this.class536_1);
			this.class531_6.float_2 *= 0.8f;
		}

		// Token: 0x06002C69 RID: 11369
		// RVA: 0x00021A9C File Offset: 0x0001FC9C
		protected override Class746 vmethod_25()
		{
			return new Class746(TransformationType.Fade, 0f, 1f, this.StartTime - 1, this.StartTime + 200, Enum70.const_0);
		}

		// Token: 0x06002C6C RID: 11372
		// RVA: 0x00120728 File Offset: 0x0011E928
		protected override void vmethod_26()
		{
			base.vmethod_26();
			if (this.class531_0 != null)
			{
				this.class531_0.float_2 *= 0.8f;
				List<Class746> arg_4D_0 = this.class531_0.class26_0;
				if (Class329.action_2 == null)
				{
					Class329.action_2 = new Action<Class746>(Class329.smethod_5);
				}
				arg_4D_0.ForEach(Class329.action_2);
			}
		}

		// Token: 0x06002C6D RID: 11373
		// RVA: 0x00021AC3 File Offset: 0x0001FCC3
		internal override void vmethod_5(Vector2 vector2_1, bool bool_11)
		{
			this.class531_11.vector2_1 = vector2_1;
			base.vmethod_5(vector2_1, bool_11);
		}
	}
}
