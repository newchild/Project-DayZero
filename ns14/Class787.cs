using ns29;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ns14
{
	// Token: 0x020005C0 RID: 1472
	internal sealed class Class787
	{
		// Token: 0x06002ED0 RID: 11984
		[DllImport("user32.dll")]
		private static extern bool EnumDisplaySettings(string string_0, int int_0, ref Struct53 struct53_0);

		// Token: 0x06002ED7 RID: 11991
		[DllImport("user32.dll")]
		private static extern bool GetMonitorInfo(IntPtr intptr_0, ref Struct54 struct54_0);

		// Token: 0x06002ED8 RID: 11992
		[DllImport("user32.dll")]
		private static extern IntPtr MonitorFromWindow(IntPtr intptr_0, uint uint_0);

		// Token: 0x06002ED1 RID: 11985
		// RVA: 0x0013074C File Offset: 0x0012E94C
		internal static List<Size> smethod_0()
		{
			List<Size> list = new List<Size>();
			Struct53 struct = default(Struct53);
			int num = 0;
			while (Class787.EnumDisplaySettings(null, num, ref struct))
			{
				list.Add(new Size(struct.int_7, struct.int_8));
				num++;
			}
			return list;
		}

		// Token: 0x06002ED3 RID: 11987
		// RVA: 0x001307CC File Offset: 0x0012E9CC
		internal static Size smethod_1()
		{
			List<Size> list = Class787.smethod_0();
			Size result = new Size(640, 480);
			foreach (Size current in list)
			{
				if (current.Width > result.Width || (current.Width == result.Width && current.Height > result.Height))
				{
					result = current;
				}
			}
			return result;
		}

		// Token: 0x06002ED4 RID: 11988
		// RVA: 0x00130860 File Offset: 0x0012EA60
		private static Struct53? smethod_2()
		{
			Struct53 struct = default(Struct53);
			struct.short_2 = (short)Marshal.SizeOf(struct);
			if (Class787.EnumDisplaySettings(null, -1, ref struct))
			{
				return new Struct53?(struct);
			}
			return null;
		}

		// Token: 0x06002ED5 RID: 11989
		// RVA: 0x001308A4 File Offset: 0x0012EAA4
		internal static int smethod_3()
		{
			Struct53? struct = Class787.smethod_2();
			if (!struct.HasValue)
			{
				return 0;
			}
			return struct.Value.int_10;
		}

		// Token: 0x06002ED6 RID: 11990
		// RVA: 0x001308D0 File Offset: 0x0012EAD0
		internal static Size smethod_4()
		{
			Struct54 struct = new Struct54
			{
				int_0 = 40
			};
			IntPtr intptr_ = Class787.MonitorFromWindow(Class115.class114_0.method_4().vmethod_1(), 2u);
			Class787.GetMonitorInfo(intptr_, ref struct);
			return new Size(struct.struct55_0.int_2 - struct.struct55_0.int_0, struct.struct55_0.int_3 - struct.struct55_0.int_1);
		}

		// Token: 0x06002ED9 RID: 11993
		// RVA: 0x00130948 File Offset: 0x0012EB48
		internal static Point smethod_5()
		{
			Struct54 struct = new Struct54
			{
				int_0 = 40
			};
			IntPtr intptr_ = Class787.MonitorFromWindow(Class115.class114_0.method_4().vmethod_1(), 2u);
			Class787.GetMonitorInfo(intptr_, ref struct);
			return new Point(struct.struct55_0.int_0, struct.struct55_0.int_1);
		}

		// Token: 0x06002ED2 RID: 11986
		// RVA: 0x00130794 File Offset: 0x0012E994
		internal static string ToString(Size size_0)
		{
			return size_0.Width.ToString() + 'x' + size_0.Height.ToString();
		}
	}
}
