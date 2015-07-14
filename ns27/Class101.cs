using Microsoft.Xna.Framework.Graphics;
using System;

namespace ns27
{
	// Token: 0x0200058E RID: 1422
	internal sealed class Class101 : Class89
	{
		// Token: 0x06002D72 RID: 11634
		// RVA: 0x00022563 File Offset: 0x00020763
		internal Class101(string string_0, EventHandler eventHandler_4, EventHandler eventHandler_5) : base(string_0, true)
		{
			base.method_3("Yes", Color.get_YellowGreen(), eventHandler_4, true, false, true);
			base.method_3("No", Color.get_OrangeRed(), eventHandler_5, true, false, true);
		}
	}
}
