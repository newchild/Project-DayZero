using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns16;
using ns26;
using ns29;
using ns30;
using ns64;
using ns77;
using ns79;
using ns8;
using ns80;
using ns82;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns27
{
	// Token: 0x02000461 RID: 1121
	internal sealed class Class522 : Class520
	{
		// Token: 0x02000462 RID: 1122
		[CompilerGenerated]
		private sealed class Class555
		{
			// Token: 0x04001E4E RID: 7758
			public Class522 class522_0;

			// Token: 0x04001E4F RID: 7759
			public string string_0;

			// Token: 0x06002479 RID: 9337
			// RVA: 0x0001C991 File Offset: 0x0001AB91
			public void method_0()
			{
				this.class522_0.method_0(int.Parse(this.string_0, Class115.numberFormatInfo_0));
			}
		}

		// Token: 0x02000463 RID: 1123
		[CompilerGenerated]
		private sealed class Class556
		{
			// Token: 0x04001E50 RID: 7760
			public Class531 class531_0;

			// Token: 0x04001E51 RID: 7761
			public Class531 class531_1;

			// Token: 0x0600247B RID: 9339
			// RVA: 0x0001C9AE File Offset: 0x0001ABAE
			public void method_0()
			{
				this.class531_1.vector2_1 = this.class531_0.vector2_1;
			}
		}

		// Token: 0x04001E4A RID: 7754
		[CompilerGenerated]
		private static Action<Class530> action_0;

		// Token: 0x04001E4C RID: 7756
		[CompilerGenerated]
		private static Action<Class530> action_1;

		// Token: 0x04001E4D RID: 7757
		[CompilerGenerated]
		private static Action<Class530> action_2;

		// Token: 0x04001E3F RID: 7743
		private Class531 class531_0;

		// Token: 0x04001E40 RID: 7744
		private Class531 class531_1;

		// Token: 0x04001E42 RID: 7746
		private Class531 class531_2;

		// Token: 0x04001E44 RID: 7748
		private Class531 class531_3;

		// Token: 0x04001E49 RID: 7753
		private Class531 class531_4;

		// Token: 0x04001E41 RID: 7745
		private Class533 class533_0;

		// Token: 0x04001E43 RID: 7747
		private Class729 class729_0;

		// Token: 0x04001E45 RID: 7749
		private Class911 class911_1;

		// Token: 0x04001E4B RID: 7755
		[CompilerGenerated]
		private static EventHandler eventHandler_0;

		// Token: 0x04001E3E RID: 7742
		private int int_0;

		// Token: 0x04001E46 RID: 7750
		private int int_1;

		// Token: 0x04001E47 RID: 7751
		private int int_2;

		// Token: 0x04001E48 RID: 7752
		private int int_3;

		// Token: 0x1700037E RID: 894
		internal int Count
		{
			// Token: 0x06002465 RID: 9317
			// RVA: 0x0001C89E File Offset: 0x0001AA9E
			get
			{
				return this.int_2;
			}
		}

		// Token: 0x0600246E RID: 9326
		// RVA: 0x0001C8BF File Offset: 0x0001AABF
		internal override void Draw()
		{
			base.Draw();
			this.class911_1.Draw();
		}

		// Token: 0x06002467 RID: 9319
		// RVA: 0x000DC85C File Offset: 0x000DAA5C
		internal override void Initialize()
		{
			base.Initialize();
			this.class911_0.Add(this.class531_2 = new Class531("coins-buy", new Vector2(-35f, -10f), Enum112.flag_6, Origins.Centre, Enum115.const_6)
			{
				float_0 = 0.88f
			});
			this.class911_0.Add(this.class531_0 = new Class531("coins-bg", new Vector2(0f, -10f), Enum112.flag_6, Origins.Centre, Enum115.const_6)
			{
				float_0 = 0.9f
			});
			this.class911_0.Add(this.class531_1 = new Class531("coins", new Vector2(0f, -15f), Enum112.flag_6, Origins.Centre, Enum115.const_6)
			{
				float_0 = 0.98f,
				float_2 = 0.55f
			});
			this.class531_2.method_2(new EventHandler(this.method_1));
			this.class531_2.bool_1 = true;
			this.class531_2.class746_1 = new Class746(Color.get_White(), Color.get_HotPink(), 0, 100);
			Class911 arg_164_0 = this.class911_0;
			Class533 class = new Class533(string.Empty, 16f, new Vector2(0f, 0f), 1f, true, Color.get_White());
			class.enum115_0 = Enum115.const_6;
			class.origins_0 = Origins.Centre;
			class.method_58(false);
			arg_164_0.Add(this.class533_0 = class);
			List<Class530> arg_191_0 = this.class911_0.list_2;
			if (Class522.action_0 == null)
			{
				Class522.action_0 = new Action<Class530>(Class522.smethod_0);
			}
			arg_191_0.ForEach(Class522.action_0);
			Class133 class2 = new Class133(string.Format("http://osu.ppy.sh/web/coins.php?action=check&u={0}&h={1}&c={2}&cs={3}", new object[]
			{
				Class341.class605_20,
				Class341.class605_17,
				this.Count,
				this.method_7()
			}));
			class2.method_0(new Class133.Delegate17(this.method_5));
			Class169.smethod_0(class2);
		}

		// Token: 0x06002466 RID: 9318
		// RVA: 0x0001C8A6 File Offset: 0x0001AAA6
		internal void method_0(int int_4)
		{
			if (this.int_2 == int_4)
			{
				return;
			}
			this.int_2 = int_4;
			this.method_2();
		}

		// Token: 0x06002468 RID: 9320
		// RVA: 0x000DCA60 File Offset: 0x000DAC60
		private void method_1(object sender, EventArgs e)
		{
			if (this.class531_4 != null)
			{
				this.class531_4.bool_0 = false;
				this.class531_4 = null;
			}
			this.class911_1.Add(this.class531_4 = new Class531("coins-dialog", new Vector2(0f, 0f), Enum112.flag_6, Origins.Centre, Enum115.const_9)
			{
				float_0 = 0.9f
			});
			Class530 arg_7C_0 = this.class531_4;
			if (Class522.eventHandler_0 == null)
			{
				Class522.eventHandler_0 = new EventHandler(Class522.smethod_1);
			}
			arg_7C_0.method_2(Class522.eventHandler_0);
			this.class531_4.method_15(100);
			this.class531_4.bool_1 = true;
		}

		// Token: 0x06002477 RID: 9335
		// RVA: 0x0001C97E File Offset: 0x0001AB7E
		[CompilerGenerated]
		private void method_10()
		{
			this.class531_0.method_16(300, Enum70.const_0);
		}

		// Token: 0x06002469 RID: 9321
		// RVA: 0x000DCB08 File Offset: 0x000DAD08
		private void method_2()
		{
			if (!Class115.smethod_33())
			{
				return;
			}
			if (this.int_3 >= 0)
			{
				if (this.int_2 < 5)
				{
					this.class531_2.method_14(300, Enum70.const_0);
				}
				this.int_3 = Class115.int_1;
				return;
			}
			Class115.class47_0.method_1(new VoidDelegate(this.method_8), 500, false);
		}

		// Token: 0x0600246A RID: 9322
		// RVA: 0x000DCB68 File Offset: 0x000DAD68
		private void method_3()
		{
			if (this.int_3 < 0)
			{
				return;
			}
			this.int_3 = -1;
			List<Class530> arg_39_0 = this.class911_0.list_2;
			if (Class522.action_2 == null)
			{
				Class522.action_2 = new Action<Class530>(Class522.smethod_3);
			}
			arg_39_0.ForEach(Class522.action_2);
			this.class531_1.method_16(300, Enum70.const_0);
			this.class533_0.method_16(300, Enum70.const_0);
			this.class531_2.method_16(300, Enum70.const_0);
			Class115.class47_0.method_1(new VoidDelegate(this.method_10), 200, false);
		}

		// Token: 0x0600246B RID: 9323
		// RVA: 0x000DCC04 File Offset: 0x000DAE04
		internal bool method_4()
		{
			if (!Class115.smethod_33())
			{
				return true;
			}
			this.method_0(this.Count - 1);
			Class133 class = new Class133(string.Format("http://osu.ppy.sh/web/coins.php?action=use&u={0}&h={1}&c={2}&cs={3}", new object[]
			{
				Class341.class605_20,
				Class341.class605_17,
				this.Count,
				this.method_7()
			}));
			class.method_0(new Class133.Delegate17(this.method_5));
			Class169.smethod_0(class);
			return true;
		}

		// Token: 0x0600246C RID: 9324
		// RVA: 0x000DCC84 File Offset: 0x000DAE84
		private void method_5(string string_0, Exception exception_0)
		{
			Class522.Class555 class = new Class522.Class555();
			class.string_0 = string_0;
			class.class522_0 = this;
			Class115.class47_0.method_1(new VoidDelegate(class.method_0), Math.Max(0, Class79.int_6 - Class115.int_1), false);
		}

		// Token: 0x0600246D RID: 9325
		// RVA: 0x000DCCD0 File Offset: 0x000DAED0
		internal bool method_6()
		{
			Class522.Class556 class = new Class522.Class556();
			if (!Class115.smethod_33())
			{
				return true;
			}
			class.class531_0 = this.class531_3.Clone();
			class.class531_0.vector2_1 = Class802.vector2_0 / Class115.float_4;
			class.class531_0.float_0 = 0.99f;
			class.class531_0.method_16(1500, Enum70.const_0);
			this.class911_1.Add(class.class531_0);
			this.class729_0.Add(class.class531_0, new Vector2?(new Vector2((float)Class562.smethod_2() * 100f, (float)Class562.smethod_2() * -100f)), false);
			class.class531_1 = this.class531_3.Clone();
			class.class531_1.bool_7 = true;
			class.class531_1.method_30(new VoidDelegate(class.method_0));
			class.class531_1.method_16(500, Enum70.const_0);
			this.class911_1.Add(class.class531_1);
			Class331.smethod_59("coins-earn", 80, Enum112.flag_5);
			this.method_0(this.Count + 1);
			Class133 class2 = new Class133(string.Format("http://osu.ppy.sh/web/coins.php?action=earn&u={0}&h={1}&c={2}&cs={3}", new object[]
			{
				Class341.class605_20,
				Class341.class605_17,
				this.Count,
				this.method_7()
			}));
			class2.method_0(new Class133.Delegate17(this.method_5));
			Class169.smethod_0(class2);
			return true;
		}

		// Token: 0x06002470 RID: 9328
		// RVA: 0x0001C8D3 File Offset: 0x0001AAD3
		private string method_7()
		{
			return Class33.smethod_2(Class341.class605_20 + this.int_2 + "osuycoins");
		}

		// Token: 0x06002473 RID: 9331
		// RVA: 0x000DCFB0 File Offset: 0x000DB1B0
		[CompilerGenerated]
		private void method_8()
		{
			this.int_3 = Class115.int_1;
			List<Class530> arg_33_0 = this.class911_0.list_2;
			if (Class522.action_1 == null)
			{
				Class522.action_1 = new Action<Class530>(Class522.smethod_2);
			}
			arg_33_0.ForEach(Class522.action_1);
			this.class531_0.method_14(300, Enum70.const_0);
			Class115.class47_0.method_1(new VoidDelegate(this.method_9), 300, false);
		}

		// Token: 0x06002475 RID: 9333
		// RVA: 0x0001C923 File Offset: 0x0001AB23
		[CompilerGenerated]
		private void method_9()
		{
			this.class531_1.method_14(300, Enum70.const_0);
			this.class533_0.method_14(300, Enum70.const_0);
			if (this.int_2 < 5)
			{
				this.class531_2.method_14(300, Enum70.const_0);
			}
		}

		// Token: 0x06002471 RID: 9329
		// RVA: 0x0001C8F9 File Offset: 0x0001AAF9
		[CompilerGenerated]
		private static void smethod_0(Class530 class530_0)
		{
			class530_0.float_3 = 0f;
		}

		// Token: 0x06002472 RID: 9330
		// RVA: 0x0000653E File Offset: 0x0000473E
		[CompilerGenerated]
		private static void smethod_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06002474 RID: 9332
		// RVA: 0x0001C906 File Offset: 0x0001AB06
		[CompilerGenerated]
		private static void smethod_2(Class530 class530_0)
		{
			class530_0.method_23(new Vector2(0f, 35f), 500, Enum70.const_1);
		}

		// Token: 0x06002476 RID: 9334
		// RVA: 0x0001C961 File Offset: 0x0001AB61
		[CompilerGenerated]
		private static void smethod_3(Class530 class530_0)
		{
			class530_0.method_23(new Vector2(0f, -35f), 500, Enum70.const_2);
		}

		// Token: 0x0600246F RID: 9327
		// RVA: 0x000DCE4C File Offset: 0x000DB04C
		internal override void vmethod_0()
		{
			if (this.int_3 >= 0 && Class115.int_1 > this.int_3 + this.int_0)
			{
				this.method_3();
			}
			if (this.class531_2.vmethod_1())
			{
				this.method_2();
			}
			if (this.class533_0.float_3 == 1f && this.int_2 != this.int_1)
			{
				if (this.int_2 > this.int_1)
				{
					this.int_1++;
				}
				else
				{
					Class331.smethod_59("coins-use", 100, Enum112.flag_5);
					Class531 class = this.class531_3.Clone();
					class.vector2_1 = new Vector2((float)(Class115.smethod_43() / 2), 35f);
					class.float_2 = 0.5f;
					class.float_0 = 0.5f;
					class.method_16(1000, Enum70.const_0);
					this.class911_0.Add(class);
					this.class729_0.Add(class, null, false);
					this.int_1--;
				}
				this.class533_0.Text = this.int_1.ToString(Class115.numberFormatInfo_0);
				this.class533_0.method_57((this.int_1 > 0) ? Color.get_Gray() : Color.get_Red());
				this.method_2();
			}
			base.vmethod_0();
			this.class729_0.method_0();
		}
	}
}
