using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns27;
using ns79;
using ns8;
using osu_common.Helpers;
using System;
using System.Collections.Generic;

namespace ns20
{
	// Token: 0x020003A4 RID: 932
	internal sealed class Class394 : Class390
	{
		// Token: 0x040016DF RID: 5855
		internal Class753 class753_0;

		// Token: 0x040016E0 RID: 5856
		private Interface18 interface18_0;

		// Token: 0x06001CC7 RID: 7367
		// RVA: 0x0009A120 File Offset: 0x00098320
		public Class394(OsuString osuString_0, IEnumerable<Class557> ienumerable_1, Interface18 interface18_1, EventHandler eventHandler_1)
		{
			this.interface18_0 = interface18_1;
			Interface19 interface = interface18_1 as Interface19;
			if (interface != null)
			{
				interface.imethod_2(new EventHandler(this.method_13));
			}
			string string = Class41.GetString(osuString_0);
			Class533 class = new Class533(string, 12f, Vector2.get_Zero(), 1f, true, Color.get_White());
			this.class911_0.Add(class);
			base.method_1(class.vmethod_11() + new Vector2(5f, 0f));
			this.class753_0 = new Class753(this.class911_0, string.Empty, new Vector2(base.method_0().X, 0f), 244f - base.method_0().X, 1f)
			{
				int_0 = 10
			};
			this.class753_0.method_0(new EventHandler(this.method_15));
			this.class753_0.method_1(new EventHandler(this.method_14));
			this.class753_0.class533_0.bool_2 = true;
			if (eventHandler_1 != null)
			{
				this.class753_0.method_0(eventHandler_1);
			}
			if (ienumerable_1 != null)
			{
				foreach (Class557 current in ienumerable_1)
				{
					this.class753_0.method_8(current);
					base.method_8(current.string_0);
				}
			}
			if (interface18_1 != null)
			{
				this.class753_0.method_18(interface18_1.imethod_0(), true);
			}
			base.method_8(string);
			base.method_8(osuString_0.ToString());
		}

		// Token: 0x06001CCB RID: 7371
		// RVA: 0x0009A2C8 File Offset: 0x000984C8
		public override void Dispose()
		{
			base.Dispose();
			Interface19 interface = this.interface18_0 as Interface19;
			if (interface != null)
			{
				interface.imethod_3(new EventHandler(this.method_13));
			}
		}

		// Token: 0x06001CC8 RID: 7368
		// RVA: 0x00017B13 File Offset: 0x00015D13
		private void method_13(object sender, EventArgs e)
		{
			this.class753_0.method_18(this.interface18_0.imethod_0(), true);
		}

		// Token: 0x06001CC9 RID: 7369
		// RVA: 0x00017B2D File Offset: 0x00015D2D
		private void method_14(object sender, EventArgs e)
		{
			base.method_3(this.class753_0.method_2() ? ((float)this.class753_0.list_1.Count * base.method_0().Y) : 0f);
		}

		// Token: 0x06001CCA RID: 7370
		// RVA: 0x00017B66 File Offset: 0x00015D66
		private void method_15(object sender, EventArgs e)
		{
			if (this.interface18_0 != null)
			{
				this.interface18_0.imethod_1(this.class753_0.object_0);
			}
			base.method_3(0f);
		}
	}
}
