using Microsoft.Xna.Framework.Graphics;
using System;
using System.IO;

namespace ns80
{
	// Token: 0x02000458 RID: 1112
	internal sealed class Class545 : Class544
	{
		// Token: 0x04001BE6 RID: 7142
		internal Color color_0 = Color.get_Red();

		// Token: 0x04001BE7 RID: 7143
		private Color? nullable_0 = null;

		// Token: 0x04001BE8 RID: 7144
		private Color? nullable_1 = null;

		// Token: 0x060023E6 RID: 9190
		// RVA: 0x0001C422 File Offset: 0x0001A622
		internal Class545()
		{
			base.method_0("CatchTheBeat");
		}

		// Token: 0x060023E4 RID: 9188
		// RVA: 0x000D7F74 File Offset: 0x000D6174
		internal Color method_1()
		{
			Color? color = this.nullable_0;
			if (!color.HasValue)
			{
				return this.color_0;
			}
			return color.GetValueOrDefault();
		}

		// Token: 0x060023E5 RID: 9189
		// RVA: 0x000D7FA0 File Offset: 0x000D61A0
		internal Color method_2()
		{
			Color? color = this.nullable_1;
			if (!color.HasValue)
			{
				return this.color_0;
			}
			return color.GetValueOrDefault();
		}

		// Token: 0x060023E7 RID: 9191
		// RVA: 0x000D7FCC File Offset: 0x000D61CC
		internal override void vmethod_0()
		{
			this.dictionary_0["CatchTheBeat"].method_3<Color>("HyperDash", ref this.color_0);
			this.dictionary_0["CatchTheBeat"].method_3<Color?>("HyperDashAfterImage", ref this.nullable_0);
			this.dictionary_0["CatchTheBeat"].method_3<Color?>("HyperDashFruit", ref this.nullable_1);
		}

		// Token: 0x060023E8 RID: 9192
		// RVA: 0x000D803C File Offset: 0x000D623C
		internal override void vmethod_2(StreamWriter streamWriter_0)
		{
			this.dictionary_0["CatchTheBeat"].WriteValue("HyperDash", "ColourHyperDash", false);
			this.dictionary_0["CatchTheBeat"].WriteValue<Color>("HyperDashAfterImage", this.method_1(), this.color_0, false);
			this.dictionary_0["CatchTheBeat"].WriteValue<Color>("HyperDashFruit", this.method_2(), this.color_0, false);
			base.vmethod_2(streamWriter_0);
		}
	}
}
