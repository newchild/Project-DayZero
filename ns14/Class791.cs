using System;
using System.Runtime.InteropServices.ComTypes;

namespace ns14
{
	// Token: 0x020005C8 RID: 1480
	internal static class Class791
	{
		// Token: 0x06002EE6 RID: 12006
		// RVA: 0x00130DC8 File Offset: 0x0012EFC8
		internal static void Create(string string_0, string string_1, string string_2)
		{
			try
			{
				Interface21 interface = (Interface21)new Class790();
				interface.imethod_16(string_1);
				interface.imethod_3(string_2);
				IPersistFile persistFile = (IPersistFile)interface;
				persistFile.Save(string_0, false);
			}
			catch (Exception)
			{
			}
		}
	}
}
