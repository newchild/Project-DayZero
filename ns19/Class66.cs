using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using ns17;
using ns26;
using ns27;
using ns29;
using ns30;
using ns64;
using ns79;
using ns80;
using ns82;
using ns84;
using osu;
using osu.Graphics.Primitives;
using osu.Graphics.Sprites;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns19
{
	// Token: 0x020003DC RID: 988
	internal sealed class Class66 : Class61
	{
		// Token: 0x020003DD RID: 989
		[CompilerGenerated]
		private sealed class Class438
		{
			// Token: 0x0400190A RID: 6410
			public Class66 class66_0;

			// Token: 0x0400190B RID: 6411
			public Class754 class754_0;

			// Token: 0x06001FBE RID: 8126
			// RVA: 0x00019F3B File Offset: 0x0001813B
			public void method_0(Class439 class439_0)
			{
				class439_0.method_1(this.class66_0.class756_0.method_29() || class439_0.vmethod_0(this.class754_0.Text));
			}
		}

		// Token: 0x04001906 RID: 6406
		private Class110 class110_0;

		// Token: 0x04001902 RID: 6402
		private Class533 class533_0;

		// Token: 0x04001903 RID: 6403
		private Class533 class533_1;

		// Token: 0x04001905 RID: 6405
		private Class756 class756_0;

		// Token: 0x04001907 RID: 6407
		private Class911 class911_1 = new Class911(true);

		// Token: 0x04001904 RID: 6404
		private Color color_0 = new Color(34, 34, 32);

		// Token: 0x04001909 RID: 6409
		[CompilerGenerated]
		private static EventHandler eventHandler_4;

		// Token: 0x04001908 RID: 6408
		private List<Class439> list_0;

		// Token: 0x06001FBA RID: 8122
		// RVA: 0x00019EE7 File Offset: 0x000180E7
		public Class66() : base(null)
		{
		}

		// Token: 0x06001FB9 RID: 8121
		// RVA: 0x00019EBD File Offset: 0x000180BD
		protected override void Dispose(bool bool_2)
		{
			this.class110_0.Dispose();
			this.class756_0.Dispose();
			this.class911_1.Dispose();
			base.Dispose(bool_2);
		}

		// Token: 0x06001FB7 RID: 8119
		// RVA: 0x00019E8B File Offset: 0x0001808B
		public override void Draw()
		{
			base.Draw();
			this.class110_0.Draw();
			this.class911_1.Draw();
		}

		// Token: 0x06001FB8 RID: 8120
		// RVA: 0x00019EAA File Offset: 0x000180AA
		public override void imethod_2()
		{
			base.imethod_2();
			this.class110_0.imethod_2();
		}

		// Token: 0x06001FB4 RID: 8116
		// RVA: 0x000B473C File Offset: 0x000B293C
		public override void Initialize()
		{
			this.class911_0.Add(new Class531(Class115.class731_0, Enum115.const_4, Origins.TopLeft, Enum114.const_0, Vector2.get_Zero(), 0f, true, this.color_0, null)
			{
				vector2_2 = new Vector2((float)Class115.int_22, (float)Class115.int_23)
			});
			Class533 class530_ = new Class533("Charts /", 28f, new Vector2(27.5f, 60f), 1f, true, Color.get_White())
			{
				origins_0 = Origins.BottomLeft
			};
			this.class911_0.Add(class530_);
			this.class533_0 = new Class533("All Charts", 20f, new Vector2(120f, 58f), 1f, true, new Color(254, 220, 97))
			{
				origins_0 = Origins.BottomLeft
			};
			this.class911_0.Add(this.class533_0);
			this.class756_0 = new Class756(18, new Vector2(27.5f, 33f), 20, Enum72.const_3);
			this.class756_0.method_3(new Class754.Delegate37(this.method_2));
			this.class911_0.Add<Class531>(this.class756_0.list_0);
			this.class911_0.Add(new Class540(new Vector2(27.5f, 62f), new Vector2((float)Class115.smethod_43() - 55f, 1f), 1f, Color.get_White()));
			this.class533_1 = new Class533("All  /  Monthly  /  Themed  /  Special", 14f, new Vector2(27.5f, 70f), 1f, true, Color.get_White())
			{
				origins_0 = Origins.TopLeft
			};
			this.class911_0.Add(this.class533_1);
			this.class110_0 = new Class110(new RectangleF(13.75f, 90f, (float)Class115.smethod_43() - 27.5f, (float)Class115.smethod_44() - 27.5f - 90f), Vector2.get_Zero(), true, 0f, Enum98.const_2);
			Class133 class = new Class133("http://osu.ppy.sh/web/osu-getcharts.php?u={0}&h={1}", new string[]
			{
				Class341.class605_20,
				Class341.class605_17
			});
			class.method_0(new Class133.Delegate17(this.method_3));
			Class169.smethod_0(class);
			if (Class66.eventHandler_4 == null)
			{
				Class66.eventHandler_4 = new EventHandler(Class66.smethod_0);
			}
			Class591 class2 = new Class591(Class66.eventHandler_4, true, false);
			this.class911_1.Add<Class531>(class2.list_0);
			base.Initialize();
		}

		// Token: 0x06001FB5 RID: 8117
		// RVA: 0x000B49C8 File Offset: 0x000B2BC8
		private void method_1()
		{
			int num = 0;
			foreach (Class439 current in this.list_0)
			{
				if (current.method_0())
				{
					current.class911_0.vector2_0.Y = (float)(-(float)num) * 90f;
					num++;
				}
				if (!this.class110_0.list_0.Contains(current.class911_0))
				{
					this.class110_0.method_30(current.class911_0);
				}
			}
			this.class110_0.method_14(new Vector2(0f, 90f * (float)num));
		}

		// Token: 0x06001FB6 RID: 8118
		// RVA: 0x000B4A84 File Offset: 0x000B2C84
		private void method_2(Class754 class754_0, bool bool_2)
		{
			Class66.Class438 class = new Class66.Class438();
			class.class754_0 = class754_0;
			class.class66_0 = this;
			if (this.list_0 == null)
			{
				return;
			}
			this.list_0.ForEach(new Action<Class439>(class.method_0));
			this.method_1();
		}

		// Token: 0x06001FBB RID: 8123
		// RVA: 0x00019F0D File Offset: 0x0001810D
		[CompilerGenerated]
		private void method_3(string string_0, Exception exception_0)
		{
			this.list_0 = JsonConvert.DeserializeObject<List<Class439>>(string_0);
			this.method_1();
		}

		// Token: 0x06001FBC RID: 8124
		// RVA: 0x00019F21 File Offset: 0x00018121
		[CompilerGenerated]
		private static void smethod_0(object sender, EventArgs e)
		{
			Class331.smethod_60("menuback", 1f, Enum112.flag_5);
			Class115.smethod_70(OsuModes.Menu, false);
		}
	}
}
