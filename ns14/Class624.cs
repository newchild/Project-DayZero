using System;
using System.IO;
using System.Runtime.InteropServices;

namespace ns14
{
	// Token: 0x020004B4 RID: 1204
	internal sealed class Class624
	{
		// Token: 0x020004B5 RID: 1205
		[Flags]
		internal enum Enum56 : ushort
		{
			// Token: 0x04001F99 RID: 8089
			flag_0 = 4,
			// Token: 0x04001F9A RID: 8090
			flag_1 = 16,
			// Token: 0x04001F9B RID: 8091
			flag_2 = 64,
			// Token: 0x04001F9C RID: 8092
			flag_3 = 256,
			// Token: 0x04001F9D RID: 8093
			flag_4 = 1024,
			// Token: 0x04001F9E RID: 8094
			flag_5 = 16384
		}

		// Token: 0x020004B6 RID: 1206
		internal enum Enum57 : uint
		{
			// Token: 0x04001FA0 RID: 8096
			const_0 = 1u,
			// Token: 0x04001FA1 RID: 8097
			const_1,
			// Token: 0x04001FA2 RID: 8098
			const_2,
			// Token: 0x04001FA3 RID: 8099
			const_3
		}

		// Token: 0x020004B7 RID: 1207
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto, Pack = 1)]
		private struct Struct49
		{
			// Token: 0x04001FA9 RID: 8105
			[MarshalAs(UnmanagedType.Bool)]
			public bool bool_0;

			// Token: 0x04001FA8 RID: 8104
			public Class624.Enum56 enum56_0;

			// Token: 0x04001FA5 RID: 8101
			[MarshalAs(UnmanagedType.U4)]
			public Class624.Enum57 enum57_0;

			// Token: 0x04001FA4 RID: 8100
			public IntPtr intptr_0;

			// Token: 0x04001FAA RID: 8106
			public IntPtr intptr_1;

			// Token: 0x04001FA6 RID: 8102
			public string string_0;

			// Token: 0x04001FA7 RID: 8103
			public string string_1;

			// Token: 0x04001FAB RID: 8107
			public string string_2;
		}

		// Token: 0x0600264B RID: 9803
		[DllImport("shell32.dll", CharSet = CharSet.Auto)]
		private static extern int SHFileOperation(ref Class624.Struct49 struct49_0);

		// Token: 0x0600264C RID: 9804
		// RVA: 0x000E5EE4 File Offset: 0x000E40E4
		public static bool smethod_0(string string_0, Class624.Enum56 enum56_0)
		{
			string currentDirectory = Directory.GetCurrentDirectory();
			if (!string_0.StartsWith(currentDirectory))
			{
				string_0 = Path.Combine(currentDirectory, string_0);
			}
			bool result;
			try
			{
				Class624.Struct49 struct = default(Class624.Struct49);
				struct.enum57_0 = Class624.Enum57.const_2;
				struct.string_0 = string_0 + '\0' + '\0';
				struct.enum56_0 = (Class624.Enum56.flag_2 | enum56_0);
				Class624.SHFileOperation(ref struct);
				result = true;
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600264D RID: 9805
		// RVA: 0x0001DBB1 File Offset: 0x0001BDB1
		public static bool smethod_1(string string_0)
		{
			return Class624.smethod_0(string_0, Class624.Enum56.flag_0 | Class624.Enum56.flag_1 | Class624.Enum56.flag_4);
		}
	}
}
