using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns79;
using ns80;
using osu.Graphics.Sprites;
using System;
using System.Collections.Generic;

namespace ns20
{
	// Token: 0x020003AD RID: 941
	internal sealed class Class404
	{
		// Token: 0x04001738 RID: 5944
		private bool bool_0;

		// Token: 0x04001733 RID: 5939
		internal Class392 class392_0;

		// Token: 0x04001734 RID: 5940
		private Class531 class531_0;

		// Token: 0x04001735 RID: 5941
		private Class531 class531_1;

		// Token: 0x04001737 RID: 5943
		private Class533 class533_0;

		// Token: 0x04001736 RID: 5942
		private Class534 class534_0;

		// Token: 0x04001732 RID: 5938
		internal List<Class531> list_0 = new List<Class531>();

		// Token: 0x06001D41 RID: 7489
		// RVA: 0x0009E9F8 File Offset: 0x0009CBF8
		public Class404(Class392 class392_1, EventHandler eventHandler_0)
		{
			this.class392_0 = class392_1;
			this.class531_0 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, Vector2.get_Zero(), 0.1f, true, new Color(8, 8, 8, 191), null);
			this.class531_0.float_3 = 0.01f;
			this.class531_0.float_2 = 1.6f;
			this.class531_0.vector2_2 = new Vector2(160f, 40f);
			this.class531_0.bool_1 = true;
			this.class531_0.method_2(eventHandler_0);
			this.class531_0.bool_2 = true;
			this.class531_0.method_35(new EventHandler(this.method_1));
			this.class531_0.method_37(new EventHandler(this.method_0));
			this.class531_0.object_0 = this.class392_0;
			this.list_0.Add(this.class531_0);
			this.class531_1 = new Class531(Class115.class731_0, Enum115.const_7, Origins.TopRight, Enum114.const_0, Vector2.get_Zero(), 0.11f, true, Class885.color_1, null);
			this.class531_1.float_3 = 0f;
			this.class531_1.float_2 = 1.6f;
			this.class531_1.vector2_2 = new Vector2(4f, 40f);
			this.list_0.Add(this.class531_1);
			this.class534_0 = new Class534(class392_1.fontAwesome_0, 18f, new Vector2(20f, 20f))
			{
				color_0 = new Color(153, 153, 153)
			};
			this.list_0.Add(this.class534_0);
			this.class533_0 = new Class533(class392_1.string_0, 14f, new Vector2(45f, 20f), 0.5f, true, Color.get_White())
			{
				origins_0 = Origins.CentreLeft
			};
			this.list_0.Add(this.class533_0);
		}

		// Token: 0x06001D42 RID: 7490
		// RVA: 0x00018163 File Offset: 0x00016363
		private void method_0(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				this.class534_0.method_39(new Color(153, 153, 153), 100, false, Enum70.const_0);
			}
		}

		// Token: 0x06001D43 RID: 7491
		// RVA: 0x00018191 File Offset: 0x00016391
		private void method_1(object sender, EventArgs e)
		{
			this.class534_0.method_39(Color.get_White(), 100, false, Enum70.const_0);
		}

		// Token: 0x06001D44 RID: 7492
		// RVA: 0x0009EC04 File Offset: 0x0009CE04
		internal void method_2(Vector2 vector2_0)
		{
			foreach (Class531 current in this.list_0)
			{
				current.method_18(new Vector2(current.vector2_0.X + vector2_0.X, current.vector2_0.Y + vector2_0.Y), 0);
			}
		}

		// Token: 0x06001D45 RID: 7493
		// RVA: 0x000181A8 File Offset: 0x000163A8
		internal void method_3()
		{
			this.class534_0.method_25(0.2f, 100, Enum70.const_0);
			this.class533_0.method_25(0.2f, 100, Enum70.const_0);
		}

		// Token: 0x06001D46 RID: 7494
		// RVA: 0x000181D0 File Offset: 0x000163D0
		internal void method_4()
		{
			this.class534_0.method_14(100, Enum70.const_0);
			this.class533_0.method_14(100, Enum70.const_0);
		}

		// Token: 0x06001D47 RID: 7495
		// RVA: 0x0009EC84 File Offset: 0x0009CE84
		internal void method_5(bool bool_1)
		{
			if (this.bool_0 == bool_1)
			{
				return;
			}
			this.bool_0 = bool_1;
			if (this.bool_0)
			{
				this.class531_0.method_14(100, Enum70.const_0);
				this.class531_1.method_14(300, Enum70.const_7);
				this.method_1(null, null);
				return;
			}
			this.class531_0.method_25(0.01f, 300, Enum70.const_0);
			this.class531_1.method_16(300, Enum70.const_7);
			this.method_0(null, null);
		}
	}
}
