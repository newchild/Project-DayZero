using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns79;
using ns84;
using System;
using System.Runtime.CompilerServices;

namespace ns20
{
	// Token: 0x020003B1 RID: 945
	internal sealed class Class401 : Class390
	{
		// Token: 0x04001740 RID: 5952
		private Class533 class533_0;

		// Token: 0x04001741 RID: 5953
		[CompilerGenerated]
		private static EventHandler eventHandler_1;

		// Token: 0x06001D59 RID: 7513
		// RVA: 0x0009EF80 File Offset: 0x0009D180
		public Class401(string string_0)
		{
			int num = 20;
			this.class533_0 = new Class533(string_0, 12f, new Vector2(0f, 10f), new Vector2(244f, 0f), 1f, true, Color.get_White(), true);
			this.class533_0.enum72_0 = Enum72.const_2;
			this.class533_0.bool_1 = true;
			this.class533_0.method_2(delegate(object sender, EventArgs e)
			{
				Class115.smethod_90("http://osu.ppy.sh/p/changelog?v=" + Class344.smethod_0(), null);
			});
			this.class533_0.bool_2 = true;
			this.class911_0.Add(this.class533_0);
			base.method_1(base.method_0() + new Vector2(0f, (float)num));
			base.method_8("version");
		}

		// Token: 0x06001D5A RID: 7514
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal override bool vmethod_3()
		{
			return true;
		}
	}
}
