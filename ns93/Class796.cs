using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns79;
using ns82;
using osu.Graphics.Sprites;
using osu_common;
using System;

namespace ns93
{
	// Token: 0x020005D3 RID: 1491
	internal sealed class Class796
	{
		// Token: 0x0400278F RID: 10127
		internal bool bool_0 = true;

		// Token: 0x0400278B RID: 10123
		private Class531 class531_0;

		// Token: 0x0400278C RID: 10124
		private Class533[] class533_0;

		// Token: 0x0400278D RID: 10125
		private Class799 class799_0;

		// Token: 0x0400278E RID: 10126
		internal Vector2 vector2_0;

		// Token: 0x170003A4 RID: 932
		internal Vector2 Position
		{
			// Token: 0x06002F18 RID: 12056
			// RVA: 0x00132004 File Offset: 0x00130204
			set
			{
				this.class531_0.vector2_1 = value;
				for (int i = 0; i < 10; i++)
				{
					this.class533_0[i].vector2_1 = value + new Vector2(0f, (float)(15 * i));
				}
			}
		}

		// Token: 0x06002F19 RID: 12057
		// RVA: 0x0013204C File Offset: 0x0013024C
		internal Class796(Class911 class911_0, Vector2 vector2_1, Class799 class799_1)
		{
			this.class531_0 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, vector2_1, 0.999f, true, Color.get_Gray(), null);
			this.class531_0.float_2 = 1.6f;
			this.class531_0.float_3 = 0f;
			class911_0.Add(this.class531_0);
			this.class799_0 = class799_1;
			this.vector2_0 = vector2_1;
			this.class533_0 = new Class533[10];
			for (int i = 0; i < 10; i++)
			{
				this.class533_0[i] = new Class533("", 15f, vector2_1 + new Vector2(0f, (float)(15 * i)), 1f, true, Color.get_White());
				this.class533_0[i].float_3 = 0f;
				class911_0.Add(this.class533_0[i]);
			}
		}

		// Token: 0x06002F1A RID: 12058
		// RVA: 0x00132134 File Offset: 0x00130334
		internal void method_0()
		{
			if (Class115.screenMode_0 == ScreenMode.Fullscreen)
			{
				return;
			}
			if (this.class799_0.list_0.Count != 0 && !(this.class799_0.Text == string.Empty))
			{
				this.method_1();
				float num = 90f;
				this.Position = this.vector2_0 + (this.bool_0 ? Vector2.get_Zero() : new Vector2(0f, (float)(-15 * this.class799_0.list_0.Count)));
				for (int i = 0; i < this.class799_0.list_0.Count; i++)
				{
					this.class533_0[i].Text = string.Format("{0}.{1}", i + 1, this.class799_0.list_0[i]);
					float x = this.class533_0[i].vmethod_11().X;
					if (x > num)
					{
						num = x;
					}
				}
				this.class531_0.vector2_2 = new Vector2(Math.Min(num, 250f), (float)(15 * this.class799_0.list_0.Count));
				return;
			}
			this.method_2();
		}

		// Token: 0x06002F1B RID: 12059
		// RVA: 0x00132260 File Offset: 0x00130460
		internal void method_1()
		{
			this.class531_0.float_3 = 1f;
			for (int i = 0; i < 10; i++)
			{
				this.class533_0[i].float_3 = 1f;
			}
		}

		// Token: 0x06002F1C RID: 12060
		// RVA: 0x0013229C File Offset: 0x0013049C
		internal void method_2()
		{
			this.class531_0.float_3 = 0f;
			for (int i = 0; i < 10; i++)
			{
				this.class533_0[i].float_3 = 0f;
				this.class533_0[i].Text = "";
			}
		}
	}
}
