using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns27;
using ns79;
using ns8;
using osu_common.Helpers;
using System;

namespace ns20
{
	// Token: 0x020003A1 RID: 929
	internal sealed class Class391 : Class390
	{
		// Token: 0x040016D7 RID: 5847
		private Class760 class760_0;

		// Token: 0x06001CB8 RID: 7352
		// RVA: 0x000179E7 File Offset: 0x00015BE7
		public Class391(OsuString osuString_0, Color color_0, EventHandler eventHandler_1) : this(Class41.GetString(osuString_0), color_0, eventHandler_1)
		{
			base.method_8(osuString_0.ToString());
		}

		// Token: 0x06001CB9 RID: 7353
		// RVA: 0x00099E30 File Offset: 0x00098030
		public Class391(string string_0, Color color_0, EventHandler eventHandler_1)
		{
			base.method_1(new Vector2(244f, 20f));
			this.class760_0 = new Class760(string_0, new Vector2(0f, 0f), base.method_0(), 1f, color_0, eventHandler_1, false, false, new float?(12f));
			this.class911_0.Add<Class531>(this.class760_0.list_0);
			base.method_8(string_0);
		}
	}
}
