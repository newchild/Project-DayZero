using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns18;
using ns26;
using ns29;
using ns64;
using ns77;
using ns79;
using ns80;
using ns82;
using osu.Graphics.Sprites;
using osu_common;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Un4seen.Bass;

namespace ns16
{
	// Token: 0x02000396 RID: 918
	internal sealed class Class59 : Class57
	{
		// Token: 0x02000397 RID: 919
		[CompilerGenerated]
		private sealed class Class387
		{
			// Token: 0x04001690 RID: 5776
			public Class59 class59_0;

			// Token: 0x0400168F RID: 5775
			public Vector2 vector2_0;

			// Token: 0x06001C66 RID: 7270
			// RVA: 0x0001765A File Offset: 0x0001585A
			public void method_0(Class530 class530_0)
			{
				if (class530_0.bool_0)
				{
					class530_0.int_0 += (int)((this.vector2_0.X - this.class59_0.vector2_0.X) * 10f);
				}
			}
		}

		// Token: 0x0400168A RID: 5770
		private Class531 class531_0;

		// Token: 0x04001689 RID: 5769
		private Class731 class731_0;

		// Token: 0x04001688 RID: 5768
		private Class911 class911_0 = new Class911(true)
		{
			bool_6 = false
		};

		// Token: 0x0400168C RID: 5772
		private float[] float_3;

		// Token: 0x0400168E RID: 5774
		private float float_4;

		// Token: 0x0400168B RID: 5771
		private int int_2 = Class115.smethod_43() / 1 + 1;

		// Token: 0x0400168D RID: 5773
		private Vector2 vector2_0;

		// Token: 0x06001C60 RID: 7264
		// RVA: 0x00017632 File Offset: 0x00015832
		protected override void Dispose(bool bool_2)
		{
			this.class911_0.Dispose();
			base.Dispose(bool_2);
		}

		// Token: 0x06001C61 RID: 7265
		// RVA: 0x00017646 File Offset: 0x00015846
		public override void Draw()
		{
			this.class911_0.Draw();
			base.Draw();
		}

		// Token: 0x06001C62 RID: 7266
		// RVA: 0x00097F78 File Offset: 0x00096178
		public override void imethod_2()
		{
			if (Class115.bool_13)
			{
				int num = 0;
				try
				{
					num = Bass.BASS_ChannelGetLevel(Class331.class335_0.method_0());
				}
				catch
				{
				}
				int num2 = Utils.LowWord32(num);
				int num3 = Utils.HighWord32(num);
				this.float_4 = (Class331.smethod_82() ? 0.5f : (Math.Min(0.5f, Math.Max(0.1f, (float)(num2 + num3 - 30000) / 35536f)) * 0.4f));
				if (this.class911_0.list_2.Count > 0)
				{
					Action<Class530> action = null;
					Class59.Class387 class = new Class59.Class387();
					class.class59_0 = this;
					class.vector2_0 = Class802.vector2_0 / Class115.float_4;
					if (this.vector2_0 != Vector2.get_Zero() && this.vector2_0 != class.vector2_0)
					{
						List<Class530> arg_F1_0 = this.class911_0.list_2;
						if (action == null)
						{
							action = new Action<Class530>(class.method_0);
						}
						arg_F1_0.ForEach(action);
					}
					this.vector2_0 = class.vector2_0;
					for (int i = 0; i < this.int_2; i++)
					{
						if (this.float_3[i] > 0f && this.float_3[i] < (float)Class115.smethod_44())
						{
							this.float_3[i] += 0.05f;
						}
					}
				}
			}
			if (Class341.class606_76.Value && Class115.bool_13 && Class562.smethod_2() > (double)(1f - this.float_4))
			{
				Class531 class2 = this.class531_0.Clone();
				class2.vector2_1 = new Vector2(Class562.smethod_5((float)Class115.smethod_43()), -50f);
				class2.float_3 = Class562.smethod_5(0.7f);
				class2.float_2 = Class562.smethod_6(0.1f, 0.6f);
				class2.int_0 = Class562.smethod_1(-500, 500);
				class2.object_0 = Class562.smethod_1(-2, 2);
				this.class911_0.Add(class2);
			}
			this.class911_0.list_2.ForEach(new Action<Class530>(this.method_1));
			base.imethod_2();
		}

		// Token: 0x06001C5F RID: 7263
		// RVA: 0x00097E88 File Offset: 0x00096088
		public override void Initialize()
		{
			this.float_3 = new float[this.int_2];
			base.Initialize();
			new Class729();
			this.class731_0 = Class885.Load("menu-snow", Enum112.flag_6);
			if (this.class731_0 == null)
			{
				switch (Class62.Mode)
				{
				case PlayModes.Taiko:
					this.class731_0 = Class885.Load("mode-taiko-small", Enum112.flag_6);
					break;
				case PlayModes.CatchTheBeat:
					this.class731_0 = Class885.Load("mode-fruits-small", Enum112.flag_6);
					break;
				case PlayModes.OsuMania:
					this.class731_0 = Class885.Load("mode-mania-small", Enum112.flag_6);
					break;
				default:
					this.class731_0 = Class885.Load("mode-osu-small", Enum112.flag_6);
					break;
				}
			}
			this.class531_0 = new Class531(this.class731_0, Origins.Centre, Vector2.get_Zero(), 1f, true, Color.get_White());
			this.class531_0.origins_0 = Origins.Centre;
			this.class531_0.bool_7 = true;
			this.class531_0.bool_0 = true;
		}

		// Token: 0x06001C64 RID: 7268
		// RVA: 0x000981F8 File Offset: 0x000963F8
		[CompilerGenerated]
		private void method_1(Class530 class530_0)
		{
			Class531 class = class530_0 as Class531;
			if (!class530_0.bool_0)
			{
				return;
			}
			bool flag = class530_0.vector2_1.X >= 0f && class530_0.vector2_1.X < (float)Class115.smethod_43();
			int num = (int)Math.Min((float)(this.int_2 - 1), Math.Max(0f, class530_0.vector2_1.X / 1f));
			float num2 = flag ? this.float_3[num] : 0f;
			float num3 = class530_0.vector2_1.Y + class530_0.float_2 * ((float)class.int_1 / 1.6f / 2f);
			if (num3 >= (float)Class115.smethod_44() || (num2 > 0f && num2 <= num3))
			{
				class530_0.object_0 = 0;
				class530_0.int_0 = 0;
				class530_0.bool_0 = false;
				class530_0.method_16(60000, Enum70.const_0);
				if (!flag)
				{
					return;
				}
				this.float_3[num] = class530_0.vector2_1.Y + class530_0.float_2 * ((float)class.int_1 / 1.6f / 4f);
			}
			if (class530_0.int_0 != 0 || (int)class530_0.object_0 != 0)
			{
				class530_0.int_0 += (int)class530_0.object_0;
				class530_0.vector2_1.X = class530_0.vector2_1.X + (float)class530_0.int_0 / 5000f * (float)Class115.double_0;
				class530_0.vector2_1.Y = class530_0.vector2_1.Y + 1f * (float)Class115.double_0;
				class530_0.float_1 += (float)class530_0.int_0 / 10000f * (float)Class115.double_0 * 0.4f;
			}
		}
	}
}
