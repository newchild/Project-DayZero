using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns79;
using ns8;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using System;
using System.Collections.Generic;

namespace ns20
{
	// Token: 0x020003A5 RID: 933
	internal sealed class Class395 : Class390
	{
		// Token: 0x040016E1 RID: 5857
		private Class531 class531_0;

		// Token: 0x040016E2 RID: 5858
		public Class533 class533_0;

		// Token: 0x06001CCC RID: 7372
		// RVA: 0x00017B91 File Offset: 0x00015D91
		public Class395(OsuString osuString_0) : this(Class41.GetString(osuString_0))
		{
			base.method_8(osuString_0.ToString());
		}

		// Token: 0x06001CCD RID: 7373
		// RVA: 0x0009A2FC File Offset: 0x000984FC
		public Class395(string string_0)
		{
			this.class533_0 = new Class533(string_0.ToUpper(), 12f, new Vector2(10f, 0f), 1f, true, Color.get_White());
			this.class533_0.bool_16 = true;
			this.class911_0.Add(this.class533_0);
			base.method_1(new Vector2(0f, 14f));
			this.class531_0 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(5f, 0f))
			{
				float_2 = 1.6f,
				vector2_2 = new Vector2(2f, 0f),
				bool_0 = true,
				bool_7 = true,
				color_0 = new Color(255, 255, 255, 40)
			};
			this.method_13();
			this.class911_0.Add(this.class531_0);
			base.method_8(string_0);
		}

		// Token: 0x06001CD0 RID: 7376
		// RVA: 0x0009A400 File Offset: 0x00098600
		private void method_13()
		{
			float num = base.method_0().Y + 5f;
			if (this.vmethod_0() != null)
			{
				foreach (Class390 current in this.vmethod_0())
				{
					if (!current.class911_0.bool_0)
					{
						num += current.method_0().Y + 10f;
					}
				}
			}
			this.class531_0.vector2_2.Y = num;
		}

		// Token: 0x06001CD1 RID: 7377
		// RVA: 0x00017BC2 File Offset: 0x00015DC2
		internal override IEnumerable<Class390> vmethod_0()
		{
			return base.vmethod_0();
		}

		// Token: 0x06001CD2 RID: 7378
		// RVA: 0x00017BCA File Offset: 0x00015DCA
		internal override void vmethod_1(IEnumerable<Class390> ienumerable_1)
		{
			base.vmethod_1(ienumerable_1);
			this.method_13();
		}

		// Token: 0x06001CCF RID: 7375
		// RVA: 0x00017BB4 File Offset: 0x00015DB4
		internal override void vmethod_2()
		{
			base.vmethod_2();
			this.method_13();
		}

		// Token: 0x06001CD3 RID: 7379
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal override bool vmethod_3()
		{
			return true;
		}

		// Token: 0x06001CCE RID: 7374
		// RVA: 0x00017BB0 File Offset: 0x00015DB0
		internal override int vmethod_4()
		{
			return 20;
		}
	}
}
