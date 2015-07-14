using System;
using System.Drawing;
using System.Windows.Forms;

namespace ns14
{
	// Token: 0x020004A2 RID: 1186
	internal static class Class611
	{
		// Token: 0x04001F60 RID: 8032
		private static float float_0;

		// Token: 0x060025F9 RID: 9721
		// RVA: 0x000E3B88 File Offset: 0x000E1D88
		internal static float smethod_0(Control control_0, bool bool_0)
		{
			if (!bool_0 && Class611.float_0 > 0f)
			{
				return Class611.float_0;
			}
			float result;
			using (Graphics graphics = control_0.CreateGraphics())
			{
				result = (Class611.float_0 = graphics.DpiX);
			}
			return result;
		}
	}
}
