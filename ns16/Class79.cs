using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns14;
using ns17;
using ns18;
using ns23;
using ns24;
using ns25;
using ns26;
using ns29;
using ns31;
using ns40;
using ns41;
using ns5;
using ns6;
using ns64;
using ns77;
using ns79;
using ns8;
using ns80;
using ns81;
using ns82;
using ns84;
using ns9;
using ns90;
using osu;
using osu.Graphics.Sprites;
using osu_common;
using osu_common.Helpers;
using osu_ui;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Un4seen.Bass;

namespace ns16
{
	// Token: 0x0200067E RID: 1662
	internal sealed class Class79 : Class61
	{
		// Token: 0x02000680 RID: 1664
		[CompilerGenerated]
		private sealed class Class878
		{
			// Token: 0x0400307E RID: 12414
			public Class79 class79_0;

			// Token: 0x06003408 RID: 13320
			// RVA: 0x00026450 File Offset: 0x00024650
			public void method_0(object sender, EventArgs e)
			{
				this.class79_0.class537_0.method_26(1.1f, 500, Enum70.const_33);
			}

			// Token: 0x06003409 RID: 13321
			// RVA: 0x0002646F File Offset: 0x0002466F
			public void method_1(object sender, EventArgs e)
			{
				this.class79_0.class537_0.method_26(1f, 500, Enum70.const_7);
			}

			// Token: 0x0600340A RID: 13322
			// RVA: 0x001660F8 File Offset: 0x001642F8
			public void method_2(object sender, EventArgs e)
			{
				if (!Class111.bool_2)
				{
					Class115.smethod_90(Class79.string_1, null);
					Class531 class = this.class79_0.class537_0.Clone();
					class.bool_7 = true;
					class.float_0 = 1f;
					class.method_17(400);
					this.class79_0.class911_3.Add(class);
				}
			}

			// Token: 0x0600340B RID: 13323
			// RVA: 0x0002648D File Offset: 0x0002468D
			public void method_3()
			{
				this.class79_0.class537_0.method_15(1000);
			}
		}

		// Token: 0x02000681 RID: 1665
		[CompilerGenerated]
		private sealed class Class879
		{
			// Token: 0x04003080 RID: 12416
			public bool bool_0;

			// Token: 0x0400307F RID: 12415
			public Class79 class79_0;

			// Token: 0x0600340D RID: 13325
			// RVA: 0x00166158 File Offset: 0x00164358
			public void method_0(Class531 class531_0)
			{
				class531_0.method_16(this.bool_0 ? 0 : 500, Enum70.const_0);
				class531_0.bool_1 = false;
				class531_0.method_19(class531_0.vector2_0 - new Vector2(100f, 0f), 2000, Enum70.const_1);
			}

			// Token: 0x0600340E RID: 13326
			// RVA: 0x000264A5 File Offset: 0x000246A5
			public void method_1(Class531 class531_0)
			{
				class531_0.method_16(this.bool_0 ? 0 : 500, Enum70.const_0);
			}

			// Token: 0x0600340F RID: 13327
			// RVA: 0x000264BE File Offset: 0x000246BE
			public void method_2(Class531 class531_0)
			{
				class531_0.method_14(this.bool_0 ? 0 : 500, Enum70.const_0);
			}
		}

		// Token: 0x0200067F RID: 1663
		private enum Enum109
		{
			// Token: 0x0400307C RID: 12412
			const_0,
			// Token: 0x0400307D RID: 12413
			const_1
		}

		// Token: 0x04003076 RID: 12406
		[CompilerGenerated]
		private static Action<Class531> action_0;

		// Token: 0x04003078 RID: 12408
		[CompilerGenerated]
		private static Action<Class531> action_1;

		// Token: 0x0400307A RID: 12410
		[CompilerGenerated]
		private static Action<Class531> action_2;

		// Token: 0x0400303A RID: 12346
		internal static bool bool_2 = true;

		// Token: 0x04003055 RID: 12373
		private bool bool_3;

		// Token: 0x04003059 RID: 12377
		internal static bool bool_4;

		// Token: 0x04003068 RID: 12392
		private Class296 class296_0;

		// Token: 0x04003067 RID: 12391
		private Class335 class335_0;

		// Token: 0x0400303F RID: 12351
		private Class531 class531_0;

		// Token: 0x04003040 RID: 12352
		private Class531 class531_1;

		// Token: 0x04003064 RID: 12388
		private Class531 class531_10;

		// Token: 0x0400306A RID: 12394
		private Class531 class531_11;

		// Token: 0x0400306B RID: 12395
		private Class531 class531_12;

		// Token: 0x04003041 RID: 12353
		private Class531 class531_2;

		// Token: 0x04003042 RID: 12354
		private Class531 class531_3;

		// Token: 0x04003044 RID: 12356
		private Class531 class531_4;

		// Token: 0x04003045 RID: 12357
		private Class531 class531_5;

		// Token: 0x0400304D RID: 12365
		private Class531 class531_6;

		// Token: 0x0400304E RID: 12366
		private Class531 class531_7;

		// Token: 0x04003062 RID: 12386
		private Class531 class531_8;

		// Token: 0x04003063 RID: 12387
		private Class531 class531_9;

		// Token: 0x0400303D RID: 12349
		private Class533 class533_0;

		// Token: 0x0400305E RID: 12382
		private Class533 class533_1;

		// Token: 0x0400305F RID: 12383
		private Class533 class533_2;

		// Token: 0x0400306C RID: 12396
		private Class533 class533_3;

		// Token: 0x0400303E RID: 12350
		private Class537 class537_0;

		// Token: 0x0400304A RID: 12362
		private Class56 class56_0;

		// Token: 0x0400304B RID: 12363
		private Class58 class58_0 = new Class58();

		// Token: 0x0400304C RID: 12364
		private Class59 class59_0 = new Class59();

		// Token: 0x0400305D RID: 12381
		private Class731 class731_0;

		// Token: 0x04003046 RID: 12358
		private Class911 class911_1;

		// Token: 0x04003047 RID: 12359
		private Class911 class911_2;

		// Token: 0x04003048 RID: 12360
		private Class911 class911_3;

		// Token: 0x04003049 RID: 12361
		private Class911 class911_4;

		// Token: 0x0400303B RID: 12347
		private readonly Dictionary<Class79.Enum109, List<Class531>> dictionary_0 = new Dictionary<Class79.Enum109, List<Class531>>();

		// Token: 0x0400303C RID: 12348
		private Class79.Enum109 enum109_0;

		// Token: 0x04003077 RID: 12407
		[CompilerGenerated]
		private static EventHandler eventHandler_4;

		// Token: 0x04003053 RID: 12371
		private float float_0;

		// Token: 0x04003057 RID: 12375
		private float float_1;

		// Token: 0x04003058 RID: 12376
		private float float_2;

		// Token: 0x0400305B RID: 12379
		private float float_3 = 0.5f;

		// Token: 0x0400305C RID: 12380
		private float float_4 = 0.5f;

		// Token: 0x04003060 RID: 12384
		private float float_5 = (float)(Class79.bool_2 ? -1 : 101);

		// Token: 0x04003065 RID: 12389
		private float float_6;

		// Token: 0x04003066 RID: 12390
		private float float_7;

		// Token: 0x04003043 RID: 12355
		private int int_2;

		// Token: 0x04003054 RID: 12372
		private int int_3;

		// Token: 0x04003056 RID: 12374
		private int int_4;

		// Token: 0x0400305A RID: 12378
		private int int_5;

		// Token: 0x04003069 RID: 12393
		public static int int_6 = 2400;

		// Token: 0x04003052 RID: 12370
		private List<Class531> list_0 = new List<Class531>();

		// Token: 0x04003061 RID: 12385
		private List<Class531> list_1 = new List<Class531>();

		// Token: 0x0400306F RID: 12399
		[CompilerGenerated]
		private static Predicate<Class746> predicate_0;

		// Token: 0x04003070 RID: 12400
		[CompilerGenerated]
		private static Predicate<Class746> predicate_1;

		// Token: 0x04003071 RID: 12401
		[CompilerGenerated]
		private static Predicate<Class746> predicate_2;

		// Token: 0x04003072 RID: 12402
		[CompilerGenerated]
		private static Predicate<Class746> predicate_3;

		// Token: 0x04003073 RID: 12403
		[CompilerGenerated]
		private static Predicate<Class746> predicate_4;

		// Token: 0x04003074 RID: 12404
		[CompilerGenerated]
		private static Predicate<Class746> predicate_5;

		// Token: 0x04003075 RID: 12405
		[CompilerGenerated]
		private static Predicate<Class746> predicate_6;

		// Token: 0x04003079 RID: 12409
		[CompilerGenerated]
		private static Predicate<Class531> predicate_7;

		// Token: 0x0400304F RID: 12367
		internal static string string_0;

		// Token: 0x04003050 RID: 12368
		internal static string string_1;

		// Token: 0x04003051 RID: 12369
		internal static string string_2;

		// Token: 0x0400306D RID: 12397
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_0;

		// Token: 0x0400306E RID: 12398
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_1;

		// Token: 0x060033C7 RID: 13255
		// RVA: 0x00162A48 File Offset: 0x00160C48
		internal Class79(Class114 class114_1) : base(class114_1)
		{
		}

		// Token: 0x060033DF RID: 13279
		// RVA: 0x001641E0 File Offset: 0x001623E0
		protected override void Dispose(bool bool_5)
		{
			Class115.voidDelegate_0 = (VoidDelegate)Delegate.Remove(Class115.voidDelegate_0, new VoidDelegate(this.method_5));
			Class570.smethod_1(new Class570.Delegate44(this.method_29));
			Class569.smethod_1(new Class569.Delegate43(this.method_4));
			Class115.smethod_76(new EventHandler(this.method_18));
			Class115.smethod_14(new VoidDelegate(this.method_2));
			Class809.smethod_11(new VoidDelegate(this.method_6));
			if (this.class911_3 != null)
			{
				this.class911_3.Dispose();
			}
			if (this.class911_4 != null)
			{
				this.class911_4.Dispose();
			}
			if (this.class911_1 != null)
			{
				this.class911_1.Dispose();
			}
			if (this.class56_0 != null)
			{
				this.class56_0.Dispose();
			}
			if (this.class533_1 != null)
			{
				this.class533_1.bool_0 = false;
			}
			if (this.class58_0 != null)
			{
				this.class58_0.Dispose();
			}
			if (this.class59_0 != null)
			{
				this.class59_0.Dispose();
			}
			if (this.class335_0 != null)
			{
				this.class335_0.Dispose();
			}
			base.Dispose(bool_5);
		}

		// Token: 0x060033E0 RID: 13280
		// RVA: 0x00164304 File Offset: 0x00162504
		public override void Draw()
		{
			int num = this.int_3;
			float num2 = 0f;
			int num3 = 0;
			this.int_3 = 0;
			if (this.float_5 < 0f && this.class531_9 != null)
			{
				List<Class746> arg_56_0 = this.class531_9.class26_0;
				if (Class79.predicate_1 == null)
				{
					Class79.predicate_1 = new Predicate<Class746>(Class79.smethod_6);
				}
				Class746 class = arg_56_0.Find(Class79.predicate_1);
				if (class != null)
				{
					class.float_1 = Math.Min(this.class531_9.float_3, Class562.smethod_6(0.05f, 0.2f));
				}
				this.class531_10.float_2 += (float)(0.0004 * Class115.double_0);
			}
			if (Class331.smethod_79())
			{
				num2 = (float)(Class115.int_1 % 1000);
				num3 = 1000;
				this.int_3 = Class115.int_1 / 1000;
			}
			else if (Class466.Current != null && !Class331.smethod_79() && Class331.smethod_17() && Class331.smethod_0() > 0.0)
			{
				num2 = (float)((int)(((double)Class331.int_7 + Class115.double_0 * 16.666666666666668 - Class331.smethod_12()) % Class331.smethod_8()));
				this.int_3 = (int)(((double)Class331.int_7 + Class115.double_0 * 16.666666666666668 - Class331.smethod_12()) / Class331.smethod_8());
				num3 = (int)Class331.smethod_8();
			}
			if (num != this.int_3)
			{
				if (this.class531_4.vmethod_1() && Class114.bool_0 && (Class331.int_1 > 0 || this.int_3 >= 16))
				{
					Class331.smethod_59("heartbeat", Class331.int_11, Enum112.flag_5);
				}
				this.method_20();
			}
			bool flag = Class331.smethod_82() && !Class331.smethod_79();
			if (Class331.bool_0)
			{
				this.float_2 = this.float_4;
			}
			float num4 = 1f - (this.float_6 - this.float_7) / 0.5f;
			float num5 = (num3 > 0) ? (num2 / (float)num3) : 0.5f;
			num3 = 1;
			float num6 = (float)Math.Pow(0.5, Class115.double_0);
			num2 = this.float_1 * num6 + Class778.smethod_2(1f - (num5 * 0.5f + num4 * 0.5f), 0f, 1f) * (1f - num6);
			this.float_1 = num2;
			this.class531_4.float_2 = Class778.smethod_11(num2, 1.05f + this.float_0, 1f + this.float_0, 1f);
			this.class531_5.float_3 = Class778.smethod_11(num2, flag ? 0.1f : 0.4f, 0f, (float)num3) * this.float_2;
			this.class531_5.float_2 = Class778.smethod_11(num2, 1.05f + this.float_0, 1.08f + this.float_0, (float)num3);
			this.class531_5.bool_7 = flag;
			this.class911_2.Draw();
			this.class911_3.Draw();
			this.class58_0.vector2_0 = -this.class911_3.vector2_0 + this.class531_4.vector2_1 + new Vector2((float)(Class115.smethod_43() / 2), (float)(Class115.smethod_44() / 2));
			this.class58_0.method_2(Class778.smethod_12((float)num3 - num2, 1.05f + this.float_0, 1.08f + this.float_0, (float)num3) * 150f + (float)((this.float_5 < 0f) ? 8 : 0));
			this.class58_0.float_4 = (1f - this.class531_4.vector2_1.X / -120f * 0.7f) * (flag ? 1f : 0.7f);
			this.class58_0.imethod_2();
			this.class58_0.Draw();
			this.class911_4.Draw();
			if (this.float_5 >= 0f)
			{
				this.class59_0.imethod_2();
				this.class59_0.Draw();
				if (this.class56_0 != null)
				{
					this.class56_0.Draw();
				}
			}
			if (this.class911_1 != null)
			{
				this.class911_1.Draw();
			}
			base.Draw();
		}

		// Token: 0x060033E2 RID: 13282
		// RVA: 0x001647E4 File Offset: 0x001629E4
		public override void imethod_2()
		{
			if (this.float_5 > 100f && !Class115.bool_16)
			{
				if (Class341.class606_57)
				{
					float num = Class802.vector2_0.X - (float)(Class115.int_22 / 2);
					float num2 = Class802.vector2_0.Y - (float)(Class115.int_23 / 2);
					this.class911_3.vector2_0 = new Vector2(num, num2) / Class115.float_4 / 60f;
				}
				else
				{
					this.class911_3.vector2_0 = Vector2.get_Zero();
				}
			}
			if (this.float_5 <= 100f && Class115.enum113_0 != Enum113.const_0)
			{
				if (this.float_5 >= 0f && Class115.bool_13 && Class115.int_1 > 1000)
				{
					this.float_5 += 5f;
				}
				this.class911_2.float_1 = (this.class911_3.float_1 = 1f - this.float_5 / 100f);
			}
			else if (Class79.bool_4)
			{
				this.class911_2.float_1 = Math.Max(0f, this.class911_2.float_1 - 0.01f * (float)Class115.double_0);
			}
			else
			{
				this.class911_2.float_1 = Math.Min(0.6f, this.class911_2.float_1 + 0.01f * (float)Class115.double_0);
			}
			if (Class331.class335_0 != null && this.class296_0 == Class331.class335_0.class296_0 && !Class114.bool_0 && Class331.int_11 > 40)
			{
				Class331.smethod_89(Class331.int_11 - 5, true);
			}
			if (this.bool_3 != Class331.smethod_82())
			{
				this.bool_3 = Class331.smethod_82();
				if (this.bool_3 && (this.int_4 == 0 || Class115.int_1 - this.int_4 > 500) && Math.Abs((double)Class331.int_7 - Class331.smethod_7().double_1) < 500.0)
				{
					int num3 = Class562.smethod_1(-1, 2);
					for (int i = 0; i < 100; i++)
					{
						int num4 = Class115.int_1 + i * 10;
						int num5 = num4 + Class562.smethod_1(300, 1300);
						Class746 class = new Class746(TransformationType.Scale, 1f, Class562.smethod_6(1f, Class341.class606_46 ? 2.1f : 2.8f), num4, num5, Enum70.const_0);
						Class746 class2 = new Class746(TransformationType.Fade, 1f, 0f, num4, num5, Enum70.const_0);
						Class746 class3 = new Class746(TransformationType.Rotation, Class562.smethod_6(-2f, 2f), Class562.smethod_6(-2f, 2f), num4, num5, Enum70.const_0);
						class.enum70_0 = Enum70.const_1;
						class2.enum70_0 = Enum70.const_1;
						class3.enum70_0 = Enum70.const_1;
						Vector2 vector2_;
						vector2_..ctor(100f, 490f);
						Class531 class4 = new Class531(this.class731_0, Enum115.const_5, Origins.Centre, Enum114.const_0, vector2_, 1f, false, Color.get_White(), null);
						class4.bool_7 = true;
						class4.class26_0.Add(class);
						class4.class26_0.Add(class2);
						class4.class26_0.Add(class3);
						this.class911_3.Add(class4);
						Class115.class729_0.Add(class4, new Vector2?(new Vector2((float)num3 * ((float)i - 50f) / 50f * 450f + (float)Class562.smethod_1(-50, 50), (float)Class562.smethod_1(-800, -700))), true).float_0 = 80f;
						vector2_..ctor((float)(Class115.smethod_43() - 100), 490f);
						Class531 class5 = new Class531(this.class731_0, Enum115.const_5, Origins.Centre, Enum114.const_0, vector2_, 1f, false, Color.get_White(), null);
						class5.bool_7 = true;
						class5.class26_0.Add(class);
						class5.class26_0.Add(class2);
						class5.class26_0.Add(class3);
						this.class911_3.Add(class5);
						Class115.class729_0.Add(class5, new Vector2?(new Vector2((float)num3 * ((float)i - 50f) / 50f * -450f + (float)Class562.smethod_1(-50, 50), (float)Class562.smethod_1(-800, -700))), true).float_0 = 80f;
					}
					this.int_4 = Class115.int_1;
				}
			}
			if (Class115.osuModes_0 == OsuModes.Exit)
			{
				this.float_0 -= (float)(Class115.double_0 * 0.003);
				this.class531_4.float_1 += (float)(Class115.double_0 * 0.001);
				this.class531_5.float_1 += (float)(Class115.double_0 * 0.001);
				this.class531_4.float_3 -= (float)(Class115.double_0 * 0.002);
				this.class531_5.float_3 -= (float)(Class115.double_0 * 0.002);
			}
			else if (!this.class531_4.vmethod_1() && this.float_0 >= 0f)
			{
				this.float_0 = Math.Max(this.float_0 - (float)(0.012 * Class115.double_0), 0f);
			}
			else
			{
				this.float_0 = Math.Min(this.float_0 + (float)(0.012 * Class115.double_0), 0.1f);
			}
			int num6 = 32768;
			float num7;
			float num8;
			if (Class331.class335_0 != null && Class331.class335_0.vmethod_4())
			{
				num7 = 0.5f;
				num8 = 0.5f;
			}
			else
			{
				int num9 = 0;
				try
				{
					num9 = Bass.BASS_ChannelGetLevel(Class331.class335_0.method_0());
				}
				catch
				{
				}
				int num10 = Utils.LowWord32(num9);
				int num11 = Utils.HighWord32(num9);
				num6 = num10 + num11;
				num7 = Math.Min(1f, Math.Max(0f, (float)(2 * num10 - 20000) / 45536f) / 2f);
				num8 = Math.Min(1f, Math.Max(0f, (float)(2 * num11 - 20000) / 45536f) / 2f);
			}
			this.method_21();
			if (Class331.smethod_79())
			{
				this.class531_6.method_16(50, Enum70.const_0);
				this.class531_7.method_16(50, Enum70.const_0);
			}
			else if (Class331.bool_0 && (Class331.smethod_82() || (Class331.int_0 % (int)Class331.smethod_18() == 0 && Class331.int_0 > 0)) && Class115.enum113_0 == Enum113.const_2)
			{
				int num12 = Math.Max(300, (int)Class331.smethod_8());
				if (!Class331.smethod_82() || Class331.int_0 % 2 == 0)
				{
					List<Class746> arg_6D7_0 = this.class531_6.class26_0;
					if (Class79.predicate_2 == null)
					{
						Class79.predicate_2 = new Predicate<Class746>(Class79.smethod_7);
					}
					arg_6D7_0.RemoveAll(Class79.predicate_2);
					this.class531_6.class26_0.Add(new Class746(TransformationType.Fade, this.class531_6.float_3, num7, Class115.int_1, Class115.int_1 + 64, Enum70.const_0));
					this.class531_6.class26_0.Add(new Class746(TransformationType.Fade, num7, 0f, Class115.int_1 + 64, Class115.int_1 + num12, Enum70.const_2));
				}
				if (!Class331.smethod_82() || Class331.int_0 % 2 == 1)
				{
					List<Class746> arg_778_0 = this.class531_7.class26_0;
					if (Class79.predicate_3 == null)
					{
						Class79.predicate_3 = new Predicate<Class746>(Class79.smethod_8);
					}
					arg_778_0.RemoveAll(Class79.predicate_3);
					this.class531_7.class26_0.Add(new Class746(TransformationType.Fade, this.class531_7.float_3, num8, Class115.int_1, Class115.int_1 + 64, Enum70.const_0));
					this.class531_7.class26_0.Add(new Class746(TransformationType.Fade, num8, 0f, Class115.int_1 + 64, Class115.int_1 + num12, Enum70.const_2));
				}
			}
			if (Class115.int_1 - this.int_2 >= 1000)
			{
				this.int_2 += 1000;
				this.method_19();
			}
			if (Class115.bool_13)
			{
				float num13 = Class331.smethod_82() ? 1f : (0.6f + Math.Min(1f, Math.Max(0f, (float)(num6 - 30000) / 35536f)) * 0.4f);
				this.float_6 = (float)num6 / 65536f * (float)Class331.int_11 / 100f;
				this.float_7 = this.float_7 * 0.9f + 0.1f * this.float_6;
				this.float_4 = this.float_4 * 0.8f + 0.2f * num13;
				if (num13 > this.float_3)
				{
					this.float_3 = Math.Min(1f, this.float_3 + 0.05f);
				}
				else
				{
					this.float_3 = Math.Max(0f, this.float_3 - 0.0007f);
				}
				if (Class115.enum32_0 == Enum32.const_2)
				{
					this.class533_2.Text = Class214.smethod_1(true);
				}
				else
				{
					this.class533_2.Text = null;
				}
			}
			if (this.class56_0 != null)
			{
				this.class56_0.imethod_2();
			}
			base.imethod_2();
		}

		// Token: 0x060033C9 RID: 13257
		// RVA: 0x00162BD8 File Offset: 0x00160DD8
		public override void Initialize()
		{
			base.Initialize();
			if (Class115.bool_16)
			{
				Class62.class512_0 = null;
			}
			Class802.smethod_1(false);
			Class570.smethod_0(new Class570.Delegate44(this.method_29));
			Class569.smethod_0(new Class569.Delegate43(this.method_4));
			Class115.smethod_13(new VoidDelegate(this.method_2));
			this.class911_3 = new Class911(true)
			{
				bool_7 = true
			};
			this.class911_2 = new Class911(true);
			this.class911_4 = new Class911(true);
			if (Class79.bool_2)
			{
				try
				{
					if (Class466.list_3.Count == 0 && Directory.GetFiles(Class466.smethod_17()).Length + Directory.GetDirectories(Class466.smethod_17()).Length < 6)
					{
						Class112.smethod_3(new Class854(3756, "3756 Peter Lambert - osu! tutorial.osz", "osu! tutorial", false, 0));
						Class112.smethod_3(new Class854(163112, "163112 Kuba Oms - My Love.osz", "Bundled map #1", false, 0));
						Class112.smethod_3(new Class854(140662, "140662 cYsmix feat. Emmy - Tear Rain.osz", "Bundled map #2", false, 0));
						Class112.smethod_3(new Class854(151878, "151878 Chasers - Lost.osz", "Bundled map #3", false, 0));
						Class112.smethod_3(new Class854(190390, "190390 Rameses B - Flaklypa.osz", "Bundled map #4", false, 0));
						Class112.smethod_3(new Class854(123593, "123593 Rostik - Liquid (Paul Rosenthal Remix).osz", "Bundled map #5", false, 0));
						Class112.smethod_3(new Class854(241526, "241526 Soleily - Renatus.osz", "Bundled map #6", false, 0));
					}
				}
				catch
				{
				}
				Class802.bool_13 = false;
				Class331.bool_1 = false;
				if (Class341.class606_84)
				{
					try
					{
						Class296 class = new Class296();
						class.string_1 = "welcome.mp3";
						class.method_45(new Class178(ResourcesStore.get_ResourceManager().GetStream("bgm_welcome"), false));
						class.Title = "Welcome to osu!";
						class.string_9 = "nekodex - welcome to osu! (peppy).osu";
						class.Artist = "nekodex";
						class.string_12 = "nekodex - Welcome to osu!";
						this.class296_0 = class;
					}
					catch
					{
						this.class296_0 = null;
					}
					if (this.class296_0 != null)
					{
						Class331.smethod_84(this.class296_0, false, false, true, true);
						Class466.smethod_21(this.class296_0);
					}
				}
				this.class911_1 = new Class911(true);
				this.class531_9 = new Class531(Class115.class731_0, Enum115.const_4, Origins.TopLeft, Enum114.const_0, Vector2.get_Zero(), 0.99999f, true, Color.get_Black(), null);
				this.class531_9.vector2_2 = new Vector2((float)Class115.int_22, (float)Class115.int_23);
				this.class531_9.bool_3 = true;
				this.class531_10 = new Class531(Class885.Load("welcome_text", ((Class809.class623_0 & Enum30.flag_3) > Enum30.flag_0) ? Enum112.flag_6 : Enum112.flag_1), Enum115.const_9, Origins.Centre, Enum114.const_0, new Vector2(0f, 0f), 1f, true, Color.get_White(), null);
				this.class531_10.float_3 = 0f;
				this.class531_10.bool_3 = true;
				Class115.class911_3.Add(this.class531_9);
				Class115.class911_3.Add(this.class531_10);
				Class115.class47_0.Add(new VoidDelegate(this.method_1), false);
			}
			else
			{
				this.method_5();
				Class115.voidDelegate_0 = (VoidDelegate)Delegate.Combine(Class115.voidDelegate_0, new VoidDelegate(this.method_5));
				this.method_3();
				this.method_8(true);
			}
			this.class531_4 = new Class539(Class885.Load("menu-osu", Enum112.flag_1), new Vector2(-120f, 0f), 0.98f, true, Color.get_White(), 300);
			this.class531_4.enum115_0 = Enum115.const_9;
			this.class531_4.method_2(new EventHandler(this.method_13));
			this.class531_4.bool_1 = true;
			this.class911_3.Add(this.class531_4);
			this.class58_0.vector2_0 = new Vector2((float)Class115.smethod_43(), (float)Class115.smethod_44()) / 2f + new Vector2(0f, 0f);
			foreach (Class79.Enum109 key in Enum.GetValues(typeof(Class79.Enum109)))
			{
				this.dictionary_0.Add(key, new List<Class531>());
			}
			this.method_9("play", new Vector2(-100f, -125f), new EventHandler(this.method_23), Class79.Enum109.const_0);
			this.method_9("edit", new Vector2(-100f, -60f), new EventHandler(this.method_26), Class79.Enum109.const_0);
			this.method_9("options", new Vector2(-100f, 5f), new EventHandler(this.method_27), Class79.Enum109.const_0);
			this.method_9("exit", new Vector2(-100f, 70f), new EventHandler(this.method_28), Class79.Enum109.const_0);
			this.method_9("freeplay", new Vector2(-100f, -92.5f), new EventHandler(this.method_16), Class79.Enum109.const_1);
			this.method_9("multiplayer", new Vector2(-100f, -27.5f), new EventHandler(this.method_15), Class79.Enum109.const_1);
			this.method_9("back", new Vector2(-100f, 37.5f), new EventHandler(this.method_17), Class79.Enum109.const_1);
			this.class531_5 = new Class531(Class885.Load("menu-osu", Enum112.flag_1), Enum115.const_9, Origins.Centre, Enum114.const_0, new Vector2(-120f, 0f), 0.981f, true, Color.get_White(), null);
			if (Class341.class606_46)
			{
				this.class531_5.method_8(true);
			}
			Class531 class2 = new Class531(Class885.Load("menu-copyright", Enum112.flag_1), Enum115.const_11, Origins.BottomLeft, Enum114.const_0, new Vector2(2f, 2f), 0.1f, true, Color.get_White(), null);
			class2.bool_1 = true;
			class2.list_1 = new List<Class746>();
			class2.list_1.Add(new Class746(Color.get_White(), new Color(255, 179, 59), 0, 100));
			class2.list_1.Add(new Class746(TransformationType.Scale, 1f, 1.15f, 0, 180, Enum70.const_1));
			class2.list_1.Add(new Class746(TransformationType.Scale, 1.15f, 1.05f, 180, 360, Enum70.const_2));
			class2.list_1.Add(new Class746(TransformationType.Scale, 1.05f, 1.1f, 360, 540, Enum70.const_1));
			class2.list_1.Add(new Class746(TransformationType.Scale, 1.1f, 1.07f, 540, 720, Enum70.const_2));
			class2.list_1.Add(new Class746(TransformationType.Scale, 1.07f, 1.085f, 720, 900, Enum70.const_1));
			class2.list_2 = new List<Class746>();
			class2.list_2.Add(new Class746(new Color(255, 179, 59), Color.get_White(), 0, 400));
			class2.list_2.Add(new Class746(TransformationType.Scale, 1.085f, 1f, 0, 600, Enum70.const_1));
			class2.method_2(new EventHandler(Class79.smethod_2));
			if (Class115.bool_16)
			{
				class2.method_8(true);
			}
			this.class911_4.Add(class2);
			this.class911_3.Add(this.class531_5);
			Class533 class3 = new Class533(string.Empty, 14f, new Vector2(210f, 0f), Vector2.get_Zero(), 0.95f, true, Color.get_White(), false);
			class3.method_58(true);
			this.class533_0 = class3;
			this.class911_4.Add(this.class533_0);
			this.list_0.Add(this.class533_0);
			this.method_19();
			string text = Class79.smethod_1();
			if (!string.IsNullOrEmpty(text))
			{
				this.class533_3 = new Class533(text, 16f, new Vector2(0f, 52f), new Vector2((float)Class115.int_22 / Class115.float_4, 0f), 1f, false, Color.get_White(), false);
				this.class533_3.enum115_0 = Enum115.const_12;
				this.class533_3.enum72_0 = Enum72.const_2;
				this.class533_3.origins_0 = Origins.TopCentre;
				this.class533_3.method_58(true);
				this.class533_3.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, Class115.int_1 + Class79.int_6, Class115.int_1 + Class79.int_6 + 1000, Enum70.const_0));
				this.class533_3.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class115.int_1 + Class79.int_6 + 12000, Class115.int_1 + Class79.int_6 + 12500, Enum70.const_0));
				this.class911_4.Add(this.class533_3);
			}
			this.class531_2 = new Class531(Class885.Load("menu-bat", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2((float)Class115.int_22 / Class115.float_4 - 50f, (float)Class115.int_23 / Class115.float_4 - 30f), 0.96f, true, Color.get_TransparentWhite(), null);
			this.class531_2.string_0 = Class41.GetString(OsuString.Menu_BAT);
			this.class531_2.bool_1 = true;
			this.class911_4.Add(this.class531_2);
			this.class531_3 = new Class531(Class885.Load("menu-subscriber", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2((float)Class115.int_22 / Class115.float_4 - 20f, (float)Class115.int_23 / Class115.float_4 - 30f), 0.96f, true, Color.get_TransparentWhite(), null);
			this.class531_3.string_0 = Class41.GetString(OsuString.Menu_Supporter);
			this.class531_3.bool_1 = true;
			this.class911_4.Add(this.class531_3);
			this.class531_1 = new Class531(Class885.Load("menu-osudirect", Enum112.flag_1), Enum115.const_10, Origins.CentreRight, Enum114.const_0, new Vector2(0f, 0f), 0.95f, true, Color.get_TransparentWhite(), null);
			this.class911_4.Add(this.class531_1);
			this.class531_0 = new Class531(Class885.Load("menu-osudirect-over", Enum112.flag_1), Enum115.const_10, Origins.CentreRight, Enum114.const_0, new Vector2(0f, 0f), 0.96f, true, Color.get_White(), null);
			this.class531_0.float_3 = 0.01f;
			this.class911_4.Add(this.class531_0);
			this.class531_0.bool_1 = true;
			this.class531_0.method_2(new EventHandler(this.method_30));
			this.class531_6 = new Class531(Class885.Load("menu-flash", Enum112.flag_1), Origins.CentreLeft, new Vector2(0f, 240f), 0.05f, true, Color.get_TransparentWhite());
			this.class531_6.bool_11 = true;
			this.class531_6.bool_7 = true;
			this.class531_6.vector2_2 = new Vector2(-1f, 4f);
			this.class911_3.Add(this.class531_6);
			this.class531_7 = new Class531(Class885.Load("menu-flash", Enum112.flag_1), Origins.CentreRight, new Vector2((float)Class115.int_22 / Class115.float_4, 240f), 0.05f, true, Color.get_TransparentWhite());
			this.class531_7.bool_7 = true;
			this.class531_7.bool_11 = true;
			this.class531_7.vector2_2 = new Vector2(1f, 4f);
			this.class911_3.Add(this.class531_7);
			this.class531_11 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, Vector2.get_Zero(), 0f, true, Color.get_Black(), null);
			this.class531_11.float_3 = (Class79.bool_2 ? 0f : 0.4f);
			this.class531_11.float_2 = 1.6f;
			this.class531_11.vector2_2 = new Vector2((float)Class115.smethod_43(), 54f);
			this.class911_4.Add(this.class531_11);
			this.class531_12 = new Class531(Class115.class731_0, Enum115.const_11, Origins.BottomLeft, Enum114.const_0, Vector2.get_Zero(), 0f, true, Color.get_Black(), null);
			this.class531_12.float_3 = (Class79.bool_2 ? 0f : 0.4f);
			this.class531_12.float_2 = 1.6f;
			this.class531_12.vector2_2 = new Vector2((float)Class115.smethod_43(), 54f);
			this.class911_4.Add(this.class531_12);
			this.method_7(true);
			Class809.smethod_10(new VoidDelegate(this.method_6));
			Class79.smethod_0(null, null);
			this.class731_0 = Class885.Load("star2", Enum112.flag_1);
			Class115.smethod_75(new EventHandler(this.method_18));
			if (Class79.bool_2)
			{
				Class115.double_8 = 0.0;
			}
			this.method_22(true, true);
			this.class533_2 = new Class533(null, 10f, new Vector2(0f, (float)(Class115.smethod_44() - 34)), 1f, true, Color.get_White());
			this.class533_2.method_57(Color.get_White());
			this.class533_2.origins_0 = Origins.TopLeft;
			this.class533_2.enum72_0 = Enum72.const_2;
			this.class911_4.Add(this.class533_2);
			Class115.smethod_0(false, false);
			if (!Class905.smethod_16() && !Class618.smethod_0().Contains(FrameworkVersion.dotnet45) && !Class618.smethod_0().Contains(FrameworkVersion.dotnet4))
			{
				string arg_DB5_0 = Class41.GetString(OsuString.Menu_NewFrameworkVersion);
				Color arg_DB5_1 = Color.get_Yellow();
				int arg_DB5_2 = 300000;
				if (Class79.voidDelegate_0 == null)
				{
					Class79.voidDelegate_0 = new VoidDelegate(Class79.smethod_3);
				}
				Class723.smethod_5(arg_DB5_0, arg_DB5_1, arg_DB5_2, Class79.voidDelegate_0);
			}
			Class115.class83_0.float_0 = 1f;
		}

		// Token: 0x060033C8 RID: 13256
		// RVA: 0x00162ABC File Offset: 0x00160CBC
		private void method_1()
		{
			if (Class115.long_0 < 5L)
			{
				Class115.class47_0.method_1(new VoidDelegate(this.method_1), 50, false);
				return;
			}
			Class115.class47_0.method_1(new VoidDelegate(this.method_36), 200, false);
			Class79.bool_2 = false;
			this.class531_9.method_25(0f, Class79.int_6, Enum70.const_0);
			Class109.smethod_1(false);
			this.class531_10.method_15(Class79.int_6);
			this.class531_10.float_2 = 0.9f;
			this.class531_10.vector2_2 = new Vector2(1f, 0f);
			this.class531_10.class26_0.Add(new Class746(TransformationType.VectorScale, new Vector2(1f, 0f), new Vector2(1f, 1f), Class115.int_1 + 200, Class115.int_1 + 600, Enum70.const_1));
			Class115.class47_0.method_1(new VoidDelegate(this.method_37), Class79.int_6, false);
		}

		// Token: 0x060033D3 RID: 13267
		// RVA: 0x00163E24 File Offset: 0x00162024
		private void method_10(object sender, EventArgs e)
		{
			Class531 class = (Class531)sender;
			if (!class.vmethod_6().string_0.Contains("-play") && !class.vmethod_6().string_0.Contains("-back"))
			{
				Class531 class2 = class.Clone();
				class2.bool_0 = false;
				class2.bool_7 = true;
				class2.float_0 = this.class531_4.float_0 - 0.001f;
				class2.color_0 = new Color(0, 78, 165, 255);
				class2.float_3 = 0.6f;
				List<Class746> arg_AD_0 = class2.class26_0;
				if (Class79.predicate_0 == null)
				{
					Class79.predicate_0 = new Predicate<Class746>(Class79.smethod_5);
				}
				if (arg_AD_0.Find(Class79.predicate_0) == null)
				{
					class2.method_16(500, Enum70.const_0);
				}
				this.class911_3.Add(class2);
			}
		}

		// Token: 0x060033D4 RID: 13268
		// RVA: 0x00163F00 File Offset: 0x00162100
		private void method_11(object sender, EventArgs e)
		{
			Class531 class = sender as Class531;
			if (class.object_0 == null)
			{
				return;
			}
			if (class.int_0 != (int)this.enum109_0)
			{
				return;
			}
			Class531 class2 = (Class531)class.object_0;
			class2.class26_0.Clear();
			class2.class26_0.AddRange(class.class26_0);
			class2.method_16(500, Enum70.const_0);
		}

		// Token: 0x060033D5 RID: 13269
		// RVA: 0x00163F60 File Offset: 0x00162160
		private void method_12(object sender, EventArgs e)
		{
			Class531 class = sender as Class531;
			if (this.enum109_0 != (Class79.Enum109)class.int_0)
			{
				return;
			}
			if (class.object_0 != null)
			{
				Class531 class2 = (Class531)class.object_0;
				class2.class26_0.Clear();
				class2.class26_0.AddRange(class.class26_0);
				class2.method_14(30, Enum70.const_0);
			}
			if (Class114.bool_0)
			{
				Class331.smethod_60("menuclick", 1f, Enum112.flag_5);
			}
		}

		// Token: 0x060033D6 RID: 13270
		// RVA: 0x0002620D File Offset: 0x0002440D
		private void method_13(object sender, EventArgs e)
		{
			this.float_0 -= 0.08f;
			if (this.method_14(false))
			{
				return;
			}
			if (this.enum109_0 == Class79.Enum109.const_0)
			{
				this.method_23(null, null);
				return;
			}
			this.method_16(null, null);
		}

		// Token: 0x060033D7 RID: 13271
		// RVA: 0x00026244 File Offset: 0x00024444
		private bool method_14(bool bool_5)
		{
			this.int_5 = Class115.int_1;
			if (Class79.bool_4)
			{
				if (!bool_5)
				{
					Class331.smethod_60("menuhit", 1f, Enum112.flag_5);
				}
				return true;
			}
			return false;
		}

		// Token: 0x060033D8 RID: 13272
		// RVA: 0x00163FD4 File Offset: 0x001621D4
		private void method_15(object sender, EventArgs e)
		{
			if (!Class809.smethod_21(true))
			{
				return;
			}
			if (!Class331.smethod_102())
			{
				return;
			}
			if (!Class809.bool_4)
			{
				Class723.smethod_1(Class41.GetString(OsuString.Lobby_Bancho_Fail), 3000);
				return;
			}
			Class331.smethod_60("menuhit", 1f, Enum112.flag_5);
			Class115.smethod_70(OsuModes.Lobby, false);
			Class70.bool_3 = Class111.bool_2;
			this.method_25(sender);
		}

		// Token: 0x060033D9 RID: 13273
		// RVA: 0x0002626F File Offset: 0x0002446F
		private void method_16(object sender, EventArgs e)
		{
			Class331.smethod_60("menuhit", 1f, Enum112.flag_5);
			Class115.smethod_70(OsuModes.SelectPlay, false);
			this.method_25(sender);
		}

		// Token: 0x060033DA RID: 13274
		// RVA: 0x00026290 File Offset: 0x00024490
		private void method_17(object sender, EventArgs e)
		{
			Class331.smethod_60("menuback", 1f, Enum112.flag_5);
			this.method_24(Class79.Enum109.const_0);
		}

		// Token: 0x060033DD RID: 13277
		// RVA: 0x000262BE File Offset: 0x000244BE
		private void method_18(object sender, EventArgs e)
		{
			Class115.smethod_76(new EventHandler(this.method_18));
		}

		// Token: 0x060033DE RID: 13278
		// RVA: 0x001640D0 File Offset: 0x001622D0
		private void method_19()
		{
			string text;
			if (Class341.class605_20.Value.Length > 0)
			{
				int num = Class115.int_1;
				int num2 = num / 3600000;
				num -= num2 * 3600000;
				int num3 = num / 60000;
				num -= num3 * 60000;
				int num4 = num / 1000;
				string arg;
				if (num2 > 0)
				{
					arg = string.Format("{0:00}:{1:00}:{2:00}", num2, num3, num4);
				}
				else if (num3 > 0)
				{
					arg = string.Format("{0:00}:{1:00}", num3, num4);
				}
				else
				{
					arg = string.Format(Class41.GetString(OsuString.Menu_RunningSeconds), num4);
				}
				text = string.Format(Class41.GetString(OsuString.Menu_GeneralInformation), Class466.list_3.Count, arg, DateTime.Now.ToShortTimeString());
			}
			else
			{
				text = string.Format(Class41.GetString(OsuString.Menu_GeneralInformation_Offline), Class466.list_3.Count);
			}
			this.class533_0.Text = text;
		}

		// Token: 0x060033CA RID: 13258
		// RVA: 0x000261DE File Offset: 0x000243DE
		private void method_2()
		{
			this.method_25(null);
		}

		// Token: 0x060033E1 RID: 13281
		// RVA: 0x0016473C File Offset: 0x0016293C
		private void method_20()
		{
			Class531 class = new Class531(Class885.Load("menu-osu-shockwave", Enum112.flag_1), Enum115.const_9, Origins.Centre, Enum114.const_0, this.class531_4.vector2_1, 0.2f, false, Color.get_White(), null);
			class.bool_7 = true;
			class.float_3 = 0.1f * this.float_4;
			class.method_16(1000, Enum70.const_0);
			class.class26_0.Add(new Class746(TransformationType.Scale, this.class531_4.float_2, this.class531_4.float_2 * 1.4f, Class115.int_1, Class115.int_1 + 1000, Enum70.const_1));
			this.class911_3.Add(class);
		}

		// Token: 0x060033E3 RID: 13283
		// RVA: 0x0016512C File Offset: 0x0016332C
		private void method_21()
		{
			if (!Class802.bool_13)
			{
				return;
			}
			bool flag = (double)Vector2.Distance(Class802.vector2_0, Class802.vector2_4) > 5.0 * Class115.double_0;
			if (!Class79.bool_4 && flag && Class114.bool_0)
			{
				this.int_5 = Class115.int_1;
			}
			if (this.int_5 > 0 && Class115.int_1 - this.int_5 > 6000 != Class79.bool_4)
			{
				this.method_22(!Class79.bool_4, false);
			}
			if (!flag && Class115.int_1 - this.int_5 >= 6000)
			{
				Class109.class911_0.float_0 = (this.class911_4.float_0 = (float)Math.Max(0.0099999997764825821, (double)Class109.class911_0.float_0 - 0.0010000000474974513 * Class115.double_0));
				return;
			}
			Class109.class911_0.float_0 = (this.class911_4.float_0 = (float)Math.Min(1.0, (double)Class109.class911_0.float_0 + 0.079999998211860657 * Class115.double_0));
		}

		// Token: 0x060033E4 RID: 13284
		// RVA: 0x0016524C File Offset: 0x0016344C
		private void method_22(bool bool_5, bool bool_6)
		{
			Action<Class531> action = null;
			Action<Class531> action2 = null;
			Action<Class531> action3 = null;
			Action<Class531> action4 = null;
			Class79.Class879 class = new Class79.Class879();
			class.bool_0 = bool_6;
			class.class79_0 = this;
			Class79.bool_4 = bool_5;
			Class115.class83_0.float_0 = (Class79.bool_4 ? 1f : 0.4f);
			if (Class79.bool_4)
			{
				List<Class531> arg_6F_0 = this.dictionary_0[this.enum109_0];
				if (action == null)
				{
					action = new Action<Class531>(class.method_0);
				}
				arg_6F_0.ForEach(action);
				List<Class531> arg_8C_0 = this.list_0;
				if (action2 == null)
				{
					action2 = new Action<Class531>(class.method_1);
				}
				arg_8C_0.ForEach(action2);
				this.class531_4.method_19(new Vector2(0f, this.class531_5.vector2_1.Y), class.bool_0 ? 0 : 2000, Enum70.const_1);
				this.class531_5.method_19(new Vector2(0f, this.class531_5.vector2_1.Y), class.bool_0 ? 0 : 2000, Enum70.const_1);
				return;
			}
			List<Class531> arg_11A_0 = this.list_0;
			if (action3 == null)
			{
				action3 = new Action<Class531>(class.method_2);
			}
			arg_11A_0.ForEach(action3);
			List<Class531> arg_141_0 = this.dictionary_0[this.enum109_0];
			if (action4 == null)
			{
				action4 = new Action<Class531>(this.method_39);
			}
			arg_141_0.ForEach(action4);
			this.class531_4.method_19(this.class531_4.vector2_0, 400, Enum70.const_1);
			this.class531_5.method_19(this.class531_4.vector2_0, 400, Enum70.const_1);
		}

		// Token: 0x060033E5 RID: 13285
		// RVA: 0x000262D1 File Offset: 0x000244D1
		private void method_23(object sender, EventArgs e)
		{
			if (!Class809.smethod_21(false))
			{
				return;
			}
			if (!Class331.smethod_102())
			{
				return;
			}
			if (this.enum109_0 == Class79.Enum109.const_0)
			{
				Class331.smethod_60("menuhit", 1f, Enum112.flag_5);
			}
			this.method_24(Class79.Enum109.const_1);
		}

		// Token: 0x060033E6 RID: 13286
		// RVA: 0x001653DC File Offset: 0x001635DC
		private void method_24(Class79.Enum109 enum109_1)
		{
			if (this.enum109_0 == enum109_1)
			{
				return;
			}
			bool flag = enum109_1 < this.enum109_0;
			this.enum109_0 = enum109_1;
			foreach (KeyValuePair<Class79.Enum109, List<Class531>> current in this.dictionary_0)
			{
				if (this.enum109_0 == current.Key)
				{
					using (List<Class531>.Enumerator enumerator2 = current.Value.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							Class531 current2 = enumerator2.Current;
							current2.class26_0.Clear();
							current2.vector2_1 = current2.vector2_0;
							if (!current2.vmethod_6().string_0.Contains("-over"))
							{
								current2.bool_1 = true;
							}
							if (current2.int_0 == (int)this.enum109_0)
							{
								current2.method_14(80, Enum70.const_0);
								current2.vector2_1 = current2.vector2_0 + new Vector2((float)(flag ? 15 : -30), 0f);
								current2.method_19(current2.vector2_0, 200, Enum70.const_1);
							}
						}
						continue;
					}
				}
				foreach (Class531 current3 in current.Value)
				{
					List<Class746> arg_140_0 = current3.class26_0;
					if (Class79.predicate_4 == null)
					{
						Class79.predicate_4 = new Predicate<Class746>(Class79.smethod_9);
					}
					arg_140_0.RemoveAll(Class79.predicate_4);
					current3.method_16(160, Enum70.const_0);
					current3.bool_1 = false;
				}
			}
		}

		// Token: 0x060033E7 RID: 13287
		// RVA: 0x001655C4 File Offset: 0x001637C4
		private void method_25(object object_0)
		{
			foreach (KeyValuePair<Class79.Enum109, List<Class531>> current in this.dictionary_0)
			{
				foreach (Class531 current2 in current.Value)
				{
					if (object_0 == null || (current2 != object_0 && current2 != ((Class531)object_0).object_0))
					{
						current2.class26_0.Clear();
						current2.method_22(new Vector2(-50f, 0f), 100);
						current2.method_16(100, Enum70.const_0);
					}
				}
			}
		}

		// Token: 0x060033E8 RID: 13288
		// RVA: 0x00165694 File Offset: 0x00163894
		private void method_26(object sender, EventArgs e)
		{
			if (!Class809.smethod_21(false))
			{
				return;
			}
			if (!Class331.smethod_102())
			{
				return;
			}
			if (this.method_14(false))
			{
				return;
			}
			Class62.Mode = PlayModes.Osu;
			Class331.smethod_60("menuhit", 1f, Enum112.flag_5);
			Class115.smethod_70(OsuModes.SelectEdit, false);
			this.method_25(sender);
		}

		// Token: 0x060033E9 RID: 13289
		// RVA: 0x00026304 File Offset: 0x00024504
		private void method_27(object sender, EventArgs e)
		{
			if (this.method_14(false))
			{
				return;
			}
			Class331.smethod_60("menuhit", 1f, Enum112.flag_5);
			Class115.class80_0.method_9(false);
			Class115.class80_0.method_8(true);
		}

		// Token: 0x060033EA RID: 13290
		// RVA: 0x00026337 File Offset: 0x00024537
		private void method_28(object sender, EventArgs e)
		{
			if (this.method_14(false))
			{
				return;
			}
			Class331.smethod_60("menuhit", 1f, Enum112.flag_5);
			Class115.smethod_69(Class111.bool_2);
		}

		// Token: 0x060033EB RID: 13291
		// RVA: 0x001656E4 File Offset: 0x001638E4
		private bool method_29(object object_0, Keys keys_0)
		{
			if (this.enum109_0 == Class79.Enum109.const_0)
			{
				if (keys_0 != 27)
				{
					switch (keys_0)
					{
					case 68:
						this.method_30(null, null);
						return true;
					case 69:
						this.method_26(null, null);
						return true;
					case 70:
						Class341.class606_27.method_1();
						return true;
					default:
						switch (keys_0)
						{
						case 79:
							this.method_27(null, null);
							return true;
						case 80:
							this.method_14(true);
							this.method_23(null, null);
							return true;
						case 81:
							break;
						default:
							return false;
						}
						break;
					}
				}
				Class115.smethod_69(true);
				return true;
			}
			if (this.method_14(false))
			{
				return false;
			}
			if (keys_0 <= 66)
			{
				if (keys_0 == 27 || keys_0 == 66)
				{
					this.method_17(null, null);
					return true;
				}
			}
			else
			{
				if (keys_0 == 77)
				{
					this.method_15(null, null);
					return true;
				}
				if (keys_0 == 80)
				{
					this.method_13(null, null);
					return true;
				}
			}
			return false;
		}

		// Token: 0x060033CB RID: 13259
		// RVA: 0x001639D8 File Offset: 0x00161BD8
		private void method_3()
		{
			Class115.class861_0.method_10(new Vector2(0f, 0f), false, 0);
			Class115.class861_0.list_0[0].float_0 = 0.8f;
			if (!Class115.bool_16)
			{
				this.class911_4.Add<Class531>(Class115.class861_0.list_0);
			}
		}

		// Token: 0x060033EC RID: 13292
		// RVA: 0x0002635E File Offset: 0x0002455E
		private void method_30(object sender, EventArgs e)
		{
			if ((Class809.class623_0 & Enum30.flag_3) == Enum30.flag_0)
			{
				return;
			}
			Class331.smethod_60("menuhit", 1f, Enum112.flag_5);
			Class115.smethod_70(OsuModes.OnlineSelection, false);
		}

		// Token: 0x060033ED RID: 13293
		// RVA: 0x001657BC File Offset: 0x001639BC
		private void method_31()
		{
			List<Class746> arg_28_0 = this.class531_8.class26_0;
			if (Class79.predicate_5 == null)
			{
				Class79.predicate_5 = new Predicate<Class746>(Class79.smethod_10);
			}
			arg_28_0.RemoveAll(Class79.predicate_5);
			this.class531_8.class26_0.Add(new Class746(TransformationType.Rotation, this.class531_8.float_1, this.class531_8.float_1 + 3.14159274f, Class115.int_1, Class115.int_1 + 1500, Enum70.const_1)
			{
				bool_0 = true,
				int_2 = 2500
			});
			this.class531_8.class26_0.Add(new Class746(TransformationType.Rotation, this.class531_8.float_1 + 3.14159274f, this.class531_8.float_1 + 6.28318548f, Class115.int_1 + 2500, Class115.int_1 + 4000, Enum70.const_2)
			{
				bool_0 = true,
				int_2 = 2500
			});
		}

		// Token: 0x060033EE RID: 13294
		// RVA: 0x001658B4 File Offset: 0x00163AB4
		private void method_32()
		{
			List<Class746> arg_28_0 = this.class531_8.class26_0;
			if (Class79.predicate_6 == null)
			{
				Class79.predicate_6 = new Predicate<Class746>(Class79.smethod_11);
			}
			arg_28_0.RemoveAll(Class79.predicate_6);
			this.class531_8.class26_0.Add(new Class746(TransformationType.Rotation, this.class531_8.float_1, this.class531_8.float_1 + 6.28318548f, Class115.int_1, Class115.int_1 + 2000, Enum70.const_0)
			{
				bool_0 = true
			});
		}

		// Token: 0x060033EF RID: 13295
		// RVA: 0x0016593C File Offset: 0x00163B3C
		private void method_33()
		{
			if (this.class531_8 != null)
			{
				return;
			}
			if (this.class537_0 != null)
			{
				this.class537_0.method_16(500, Enum70.const_0);
			}
			if (this.class533_3 != null && this.class533_3.Text.Length > 60)
			{
				this.class533_3.method_16(500, Enum70.const_0);
			}
			this.class531_8 = new Class531(Class885.Load("menu-update", Enum112.flag_1), Enum115.const_12, Origins.Centre, Enum114.const_0, new Vector2(0f, 22f), 0.96f, true, Color.get_TransparentWhite(), null);
			this.class531_8.method_14(500, Enum70.const_0);
			this.list_1.Add(this.class531_8);
			this.class911_4.Add(this.class531_8);
			this.method_31();
			Class746 class = new Class746(TransformationType.Fade, 1f, 0f, Class115.int_1 + 1500, Class115.int_1 + 2000, Enum70.const_0)
			{
				bool_0 = true,
				int_2 = 4000
			};
			Class746 class2 = new Class746(TransformationType.Fade, 0f, 1f, Class115.int_1 + 3500, Class115.int_1 + 4000, Enum70.const_0)
			{
				bool_0 = true,
				int_2 = 4000
			};
			Class533 class3 = new Class533(Class41.GetString(OsuString.Update_ClickToUpdate1), 14f, new Vector2((float)(Class115.smethod_43() / 2), (float)Class115.smethod_44() - 22f), 0.97f, true, Color.get_White());
			this.method_35(class3);
			class3.method_15(500);
			class3.class26_0.Add(class.Clone());
			class3.class26_0.Add(class2.Clone());
			this.class911_4.Add(class3);
			this.list_1.Add(class3);
			Class533 class4 = new Class533(Class41.GetString(OsuString.Update_ClickToUpdate2), 14f, new Vector2((float)(Class115.smethod_43() / 2), (float)Class115.smethod_44() - 22f), 0.97f, true, Color.get_TransparentWhite());
			this.method_35(class4);
			class4.class26_0.Add(class.method_1());
			class4.class26_0.Add(class2.method_1());
			this.class911_4.Add(class4);
			this.list_1.Add(class4);
		}

		// Token: 0x060033F0 RID: 13296
		// RVA: 0x00165B88 File Offset: 0x00163D88
		private void method_34()
		{
			List<Class531> arg_23_0 = this.list_1;
			if (Class79.action_0 == null)
			{
				Class79.action_0 = new Action<Class531>(Class79.smethod_12);
			}
			arg_23_0.ForEach(Class79.action_0);
			this.list_1.Clear();
			if (this.class537_0 != null)
			{
				this.class537_0.method_14(500, Enum70.const_0);
			}
			this.class531_8 = null;
		}

		// Token: 0x060033F1 RID: 13297
		// RVA: 0x00165BE8 File Offset: 0x00163DE8
		private void method_35(Class533 class533_4)
		{
			class533_4.method_35(new EventHandler(this.method_40));
			class533_4.method_37(new EventHandler(this.method_41));
			class533_4.bool_1 = true;
			class533_4.method_59(true);
			class533_4.bool_16 = true;
			class533_4.method_55(new Color(0, 0, 0, 100));
			class533_4.origins_0 = Origins.Centre;
			if (Class79.eventHandler_4 == null)
			{
				Class79.eventHandler_4 = new EventHandler(Class79.smethod_13);
			}
			class533_4.method_2(Class79.eventHandler_4);
		}

		// Token: 0x060033F2 RID: 13298
		// RVA: 0x00165C68 File Offset: 0x00163E68
		[CompilerGenerated]
		private void method_36()
		{
			if (Class341.class606_85)
			{
				Class331.smethod_59("welcome", 100, ((Class809.class623_0 & Enum30.flag_3) > Enum30.flag_0) ? Enum112.flag_5 : Enum112.flag_1);
			}
			this.class335_0 = Class331.smethod_57("welcome_piano", false);
			this.class335_0.vmethod_6(true);
			this.class58_0.class335_0 = this.class335_0;
			this.class58_0.float_0 = 20f;
		}

		// Token: 0x060033F3 RID: 13299
		// RVA: 0x00165CE0 File Offset: 0x00163EE0
		[CompilerGenerated]
		private void method_37()
		{
			this.class531_9.method_16(120, Enum70.const_0);
			this.class531_10.method_16(120, Enum70.const_0);
			this.float_5 = 0f;
			if (Class341.class606_84)
			{
				Class331.smethod_87();
			}
			Class331.bool_1 = true;
			Class109.smethod_1(true);
			this.method_5();
			Class115.voidDelegate_0 = (VoidDelegate)Delegate.Combine(Class115.voidDelegate_0, new VoidDelegate(this.method_5));
			this.class58_0.class335_0 = null;
			this.class58_0.float_0 = 1f;
			this.method_3();
			Class115.class861_0.method_15();
			this.class531_11.method_25(0.4f, 500, Enum70.const_0);
			this.class531_12.method_25(0.4f, 500, Enum70.const_0);
			this.method_6();
			Class115.class83_0.method_7(Enum50.flag_0, null);
			if (Class114.bool_0 && Class800.smethod_0())
			{
				Class802.smethod_30(new Vector2((float)(Class115.int_22 / 2), (float)(Class115.int_23 / 2 + (int)(60f * Class115.float_4))));
			}
			Class802.bool_13 = true;
			Class115.class47_0.method_1(new VoidDelegate(this.method_38), 800, false);
		}

		// Token: 0x060033F4 RID: 13300
		// RVA: 0x00026388 File Offset: 0x00024588
		[CompilerGenerated]
		private void method_38()
		{
			if (!Class115.smethod_33() && !Class115.class80_0.method_7())
			{
				Class115.smethod_80(false);
			}
			this.method_19();
		}

		// Token: 0x060033FB RID: 13307
		// RVA: 0x00166024 File Offset: 0x00164224
		[CompilerGenerated]
		private void method_39(Class531 class531_13)
		{
			if (class531_13.int_0 == (int)this.enum109_0)
			{
				class531_13.method_14(350, Enum70.const_0);
				class531_13.vector2_1 = class531_13.vector2_0 - new Vector2(100f, 0f);
				class531_13.method_19(class531_13.vector2_0, 400, Enum70.const_1);
			}
			if (class531_13.int_0 != -1)
			{
				class531_13.bool_1 = true;
			}
		}

		// Token: 0x060033CC RID: 13260
		// RVA: 0x00163A38 File Offset: 0x00161C38
		private void method_4(object object_0, List<Keys> list_2)
		{
			switch (list_2[0])
			{
			case 340:
				this.method_29(null, 27);
				return;
			case 341:
				this.method_29(null, 80);
				return;
			default:
				return;
			}
		}

		// Token: 0x06003400 RID: 13312
		// RVA: 0x000263B6 File Offset: 0x000245B6
		[CompilerGenerated]
		private void method_40(object sender, EventArgs e)
		{
			List<Class531> arg_23_0 = this.list_1;
			if (Class79.action_1 == null)
			{
				Class79.action_1 = new Action<Class531>(Class79.smethod_14);
			}
			arg_23_0.ForEach(Class79.action_1);
			this.method_32();
		}

		// Token: 0x06003401 RID: 13313
		// RVA: 0x00166090 File Offset: 0x00164290
		[CompilerGenerated]
		private void method_41(object sender, EventArgs e)
		{
			List<Class531> arg_23_0 = this.list_1;
			if (Class79.predicate_7 == null)
			{
				Class79.predicate_7 = new Predicate<Class531>(Class79.smethod_15);
			}
			if (arg_23_0.Find(Class79.predicate_7) != null)
			{
				return;
			}
			List<Class531> arg_4E_0 = this.list_1;
			if (Class79.action_2 == null)
			{
				Class79.action_2 = new Action<Class531>(Class79.smethod_16);
			}
			arg_4E_0.ForEach(Class79.action_2);
			this.method_31();
		}

		// Token: 0x060033CD RID: 13261
		// RVA: 0x00163A7C File Offset: 0x00161C7C
		private void method_5()
		{
			Enum32 enum32_ = Class115.enum32_0;
			if (enum32_ == Enum32.const_4)
			{
				this.method_33();
				return;
			}
			this.method_34();
		}

		// Token: 0x060033CF RID: 13263
		// RVA: 0x000261E7 File Offset: 0x000243E7
		private void method_6()
		{
			this.method_7(false);
		}

		// Token: 0x060033D0 RID: 13264
		// RVA: 0x00163AF0 File Offset: 0x00161CF0
		private void method_7(bool bool_5)
		{
			if (Class115.bool_16)
			{
				return;
			}
			if (this.float_5 >= 0f)
			{
				int num = Class115.int_1 + 250;
				if ((Class809.class623_0 & Enum30.flag_2) > Enum30.flag_0)
				{
					this.class531_2.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, num, num + 200, Enum70.const_0));
					this.class531_2.class26_0.Add(new Class746(TransformationType.Scale, 0.25f, 1f, num, num + 1200, Enum70.const_25));
					num += 400;
				}
				else
				{
					this.class531_2.method_16(100, Enum70.const_0);
				}
				if ((Class809.class623_0 & Enum30.flag_3) > Enum30.flag_0)
				{
					this.class531_3.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, num, num + 200, Enum70.const_0));
					this.class531_3.class26_0.Add(new Class746(TransformationType.Scale, 0.25f, 1f, num, num + 1200, Enum70.const_25));
					this.class531_0.method_25(0.01f, 200, Enum70.const_0);
					this.class531_0.class746_1 = new Class746(TransformationType.Fade, 0.01f, 1f, 0, 140, Enum70.const_0);
					this.class531_1.method_14(200, Enum70.const_0);
				}
				else
				{
					this.class531_3.method_16(100, Enum70.const_0);
					this.class531_0.method_16(100, Enum70.const_0);
					this.class531_0.class746_1 = null;
					this.class531_1.method_16(100, Enum70.const_0);
				}
				this.method_8(false);
			}
		}

		// Token: 0x060033D1 RID: 13265
		// RVA: 0x000261F0 File Offset: 0x000243F0
		private void method_8(bool bool_5)
		{
			this.class58_0.method_3(Class885.dictionary_7["MenuGlow"], bool_5);
		}

		// Token: 0x060033D2 RID: 13266
		// RVA: 0x00163C88 File Offset: 0x00161E88
		private void method_9(string string_3, Vector2 vector2_0, EventHandler eventHandler_5, Class79.Enum109 enum109_1)
		{
			Class531 class = new Class531(Class885.Load("menu-button-" + string_3, Enum112.flag_1), Enum115.const_9, Origins.TopLeft, Enum114.const_0, vector2_0, 0.8f - (float)enum109_1 / 10f, true, (enum109_1 == this.enum109_0) ? Color.get_White() : Color.get_TransparentWhite(), null);
			Class531 class2 = new Class531(Class885.Load("menu-button-" + string_3 + "-over", Enum112.flag_1), Enum115.const_9, Origins.TopLeft, Enum114.const_0, vector2_0, 0.81f - (float)enum109_1 / 10f, true, Color.get_TransparentWhite(), null);
			class.list_1 = new List<Class746>
			{
				new Class746(class.vector2_1, class.vector2_1 + new Vector2(20f, 0f), 0, 580, Enum70.const_0)
				{
					enum70_0 = Enum70.const_25
				}
			};
			class.list_2 = new List<Class746>
			{
				new Class746(Vector2.get_Zero(), class.vector2_1, 0, 400, Enum70.const_1)
				{
					enum70_0 = Enum70.const_7
				}
			};
			class.method_35(new EventHandler(this.method_12));
			class.method_37(new EventHandler(this.method_11));
			class.object_0 = class2;
			class.int_0 = (int)enum109_1;
			class.bool_1 = true;
			class.method_2(eventHandler_5);
			class.method_2(new EventHandler(this.method_10));
			class2.int_0 = -1;
			this.class911_3.Add(class);
			this.class911_3.Add(class2);
			this.dictionary_0[enum109_1].Add(class);
			this.dictionary_0[enum109_1].Add(class2);
		}

		// Token: 0x060033CE RID: 13262
		// RVA: 0x00163AA0 File Offset: 0x00161CA0
		internal static void smethod_0(string string_3, string string_4)
		{
			if (string_3 != null)
			{
				Class79.string_0 = ((string_3.Length < 4) ? null : string_3);
				Class79.string_1 = string_4;
			}
			Class47 arg_3E_0 = Class115.class47_0;
			if (Class79.voidDelegate_1 == null)
			{
				Class79.voidDelegate_1 = new VoidDelegate(Class79.smethod_4);
			}
			arg_3E_0.Add(Class79.voidDelegate_1, false);
		}

		// Token: 0x060033DB RID: 13275
		// RVA: 0x00164038 File Offset: 0x00162238
		private static string smethod_1()
		{
			if (Class115.bool_16)
			{
				return string.Empty;
			}
			if (!string.IsNullOrEmpty(Class344.string_0))
			{
				return string.Concat(new string[]
				{
					"Welcome to osu!",
					Class344.string_0,
					" (",
					Class344.smethod_1(),
					")."
				});
			}
			if (!Class341.class606_82)
			{
				return string.Empty;
			}
			int num = Class341.class608_8 % 30;
			Class341.class608_8.Value = (num + 1) % 30;
			return Class41.GetString(OsuString.MenuTip_1 + num);
		}

		// Token: 0x060033FD RID: 13309
		// RVA: 0x0001C292 File Offset: 0x0001A492
		[CompilerGenerated]
		private static bool smethod_10(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Rotation;
		}

		// Token: 0x060033FE RID: 13310
		// RVA: 0x0001C292 File Offset: 0x0001A492
		[CompilerGenerated]
		private static bool smethod_11(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Rotation;
		}

		// Token: 0x060033FF RID: 13311
		// RVA: 0x000249A7 File Offset: 0x00022BA7
		[CompilerGenerated]
		private static void smethod_12(Class531 class531_13)
		{
			class531_13.method_16(100, Enum70.const_0);
			class531_13.bool_0 = false;
		}

		// Token: 0x06003402 RID: 13314
		// RVA: 0x000263E6 File Offset: 0x000245E6
		[CompilerGenerated]
		private static void smethod_13(object sender, EventArgs e)
		{
			Class115.smethod_3(true);
		}

		// Token: 0x06003403 RID: 13315
		// RVA: 0x000263EE File Offset: 0x000245EE
		[CompilerGenerated]
		private static void smethod_14(Class531 class531_13)
		{
			class531_13.method_39(Color.get_YellowGreen(), 100, false, Enum70.const_0);
			class531_13.method_26(1.1f, 500, Enum70.const_1);
		}

		// Token: 0x06003404 RID: 13316
		// RVA: 0x00026412 File Offset: 0x00024612
		[CompilerGenerated]
		private static bool smethod_15(Class531 class531_13)
		{
			return class531_13.vmethod_1();
		}

		// Token: 0x06003405 RID: 13317
		// RVA: 0x0002641A File Offset: 0x0002461A
		[CompilerGenerated]
		private static void smethod_16(Class531 class531_13)
		{
			class531_13.method_39(Color.get_White(), 100, false, Enum70.const_0);
			class531_13.method_26(1f, 500, Enum70.const_1);
		}

		// Token: 0x060033DC RID: 13276
		// RVA: 0x000262AA File Offset: 0x000244AA
		private static void smethod_2(object sender, EventArgs e)
		{
			if (!Class111.bool_2)
			{
				Class115.smethod_90("http://osu.ppy.sh/", null);
			}
		}

		// Token: 0x060033F5 RID: 13301
		// RVA: 0x000263A9 File Offset: 0x000245A9
		[CompilerGenerated]
		private static void smethod_3()
		{
			Class115.smethod_90("http://www.microsoft.com/en-us/download/details.aspx?id=42643", null);
		}

		// Token: 0x060033F6 RID: 13302
		// RVA: 0x00165E18 File Offset: 0x00164018
		[CompilerGenerated]
		private static void smethod_4()
		{
			EventHandler eventHandler = null;
			EventHandler eventHandler2 = null;
			EventHandler eventHandler3 = null;
			VoidDelegate voidDelegate = null;
			Class79.Class878 class = new Class79.Class878();
			if (Class115.osuModes_1 != OsuModes.Menu)
			{
				return;
			}
			class.class79_0 = (Class115.class61_0 as Class79);
			if (class.class79_0 == null || class.class79_0.class531_8 != null)
			{
				return;
			}
			if (class.class79_0.class537_0 != null)
			{
				class.class79_0.class537_0.method_16(500, Enum70.const_0);
				class.class79_0.class537_0.bool_0 = false;
				class.class79_0.class537_0.bool_6 = true;
			}
			if (Class79.string_0 == null)
			{
				return;
			}
			Class79.string_2 = "Data/a/t" + Class33.smethod_2(Class79.string_0);
			try
			{
				class.class79_0.class537_0 = new Class537(Class79.string_0, Class79.string_2, 0, Vector2.get_Zero(), 0.99f)
				{
					enum115_0 = Enum115.const_12,
					origins_0 = Origins.BottomCentre,
					bool_0 = true
				};
				class.class79_0.class537_0.bool_6 = true;
				Class531 arg_11E_0 = class.class79_0.class537_0;
				if (eventHandler == null)
				{
					eventHandler = new EventHandler(class.method_0);
				}
				arg_11E_0.method_35(eventHandler);
				Class531 arg_141_0 = class.class79_0.class537_0;
				if (eventHandler2 == null)
				{
					eventHandler2 = new EventHandler(class.method_1);
				}
				arg_141_0.method_37(eventHandler2);
			}
			catch
			{
				class.class79_0.class537_0 = null;
			}
			if (class.class79_0.class537_0 != null)
			{
				if (!string.IsNullOrEmpty(Class79.string_1))
				{
					class.class79_0.class537_0.bool_1 = true;
					Class530 arg_1A5_0 = class.class79_0.class537_0;
					if (eventHandler3 == null)
					{
						eventHandler3 = new EventHandler(class.method_2);
					}
					arg_1A5_0.method_2(eventHandler3);
				}
				class.class79_0.class911_4.Add(class.class79_0.class537_0);
				Class537 arg_1E8_0 = class.class79_0.class537_0;
				if (voidDelegate == null)
				{
					voidDelegate = new VoidDelegate(class.method_3);
				}
				arg_1E8_0.method_55(voidDelegate);
			}
		}

		// Token: 0x060033F7 RID: 13303
		// RVA: 0x0001995D File Offset: 0x00017B5D
		[CompilerGenerated]
		private static bool smethod_5(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Fade;
		}

		// Token: 0x060033F8 RID: 13304
		// RVA: 0x0001995D File Offset: 0x00017B5D
		[CompilerGenerated]
		private static bool smethod_6(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Fade;
		}

		// Token: 0x060033F9 RID: 13305
		// RVA: 0x0001995D File Offset: 0x00017B5D
		[CompilerGenerated]
		private static bool smethod_7(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Fade;
		}

		// Token: 0x060033FA RID: 13306
		// RVA: 0x0001995D File Offset: 0x00017B5D
		[CompilerGenerated]
		private static bool smethod_8(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Fade;
		}

		// Token: 0x060033FC RID: 13308
		// RVA: 0x0001925A File Offset: 0x0001745A
		[CompilerGenerated]
		private static bool smethod_9(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Movement;
		}
	}
}
