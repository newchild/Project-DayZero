using System;
using System.Runtime.InteropServices;

namespace ns42
{
	// Token: 0x02000570 RID: 1392
	internal sealed class Class735
	{
		// Token: 0x06002CFC RID: 11516
		[DllImport("user32.dll")]
		public static extern int ChangeDisplaySettings(ref Struct51 struct51_0, int int_0);

		// Token: 0x06002CFB RID: 11515
		[DllImport("user32.dll")]
		public static extern int EnumDisplaySettings(string string_0, int int_0, ref Struct51 struct51_0);
	}
}
