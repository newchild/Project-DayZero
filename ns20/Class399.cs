using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns79;
using ns84;
using osu_common.Helpers;
using System;

namespace ns20
{
	// Token: 0x020003AE RID: 942
	internal sealed class Class399 : Class390
	{
		// Token: 0x04001739 RID: 5945
		private Class533 class533_0;

		// Token: 0x0400173A RID: 5946
		internal VoidDelegate voidDelegate_0;

		// Token: 0x06001D48 RID: 7496
		// RVA: 0x0009ED04 File Offset: 0x0009CF04
		public Class399(string string_0, VoidDelegate voidDelegate_1)
		{
			this.class533_0 = new Class533(string_0, 12f, new Vector2(0f, 0f), new Vector2(244f, 0f), 1f, true, Color.get_White(), true);
			this.class533_0.enum72_0 = Enum72.const_0;
			this.class533_0.bool_1 = true;
			this.class533_0.method_2(new EventHandler(this.method_13));
			this.class533_0.bool_2 = true;
			this.class911_0.Add(this.class533_0);
			base.method_1(this.class533_0.vmethod_11() + new Vector2(0f, 0f));
			base.method_8(string_0);
			if (voidDelegate_1 != null)
			{
				this.voidDelegate_0 = voidDelegate_1;
			}
		}

		// Token: 0x06001D49 RID: 7497
		// RVA: 0x000181EE File Offset: 0x000163EE
		private void method_13(object sender, EventArgs e)
		{
			if (this.voidDelegate_0 != null)
			{
				this.voidDelegate_0();
			}
		}

		// Token: 0x06001D4B RID: 7499
		// RVA: 0x00018203 File Offset: 0x00016403
		internal void method_14(string string_0)
		{
			this.class533_0.Text = string_0;
		}

		// Token: 0x06001D4A RID: 7498
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal override bool vmethod_3()
		{
			return false;
		}
	}
}
