using ns29;
using ns79;
using osu.Graphics.Sprites;
using System;
using System.Collections.Generic;

namespace ns83
{
	// Token: 0x0200047C RID: 1148
	internal sealed class Class580
	{
		// Token: 0x04001EA8 RID: 7848
		internal int int_0;

		// Token: 0x04001EAA RID: 7850
		internal int int_1;

		// Token: 0x04001EA7 RID: 7847
		internal List<Class531> list_0;

		// Token: 0x04001EA9 RID: 7849
		internal string string_0;

		// Token: 0x060024F9 RID: 9465
		// RVA: 0x000DE888 File Offset: 0x000DCA88
		internal void method_0()
		{
			foreach (Class531 current in this.list_0)
			{
				current.class26_0.Add(new Class746(TransformationType.Fade, 0f, 0.8f, Class115.int_1, Class115.int_1 + 100, Enum70.const_0));
				current.class26_0.Add(new Class746(TransformationType.Fade, 0.8f, 0f, Class115.int_1 + this.int_0, Class115.int_1 + this.int_0 + 150, Enum70.const_0));
			}
		}
	}
}
