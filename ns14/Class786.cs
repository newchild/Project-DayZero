using Microsoft.Win32;
using ns64;
using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace ns14
{
	// Token: 0x020005BD RID: 1469
	internal static class Class786
	{
		// Token: 0x020005BE RID: 1470
		private struct Struct52
		{
			// Token: 0x040026F0 RID: 9968
			public IntPtr intptr_0;

			// Token: 0x040026F2 RID: 9970
			public IntPtr intptr_1;

			// Token: 0x040026F1 RID: 9969
			public int int_0;
		}

		// Token: 0x06002ECB RID: 11979
		[SuppressUnmanagedCodeSecurity]
		[DllImport("user32.dll")]
		private static extern IntPtr FindWindowExA(IntPtr intptr_0, IntPtr intptr_1, string string_0, string string_1);

		// Token: 0x06002ECA RID: 11978
		[SuppressUnmanagedCodeSecurity]
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		internal static extern bool PostMessage(IntPtr intptr_0, uint uint_0, long long_0, long long_1);

		// Token: 0x06002EC9 RID: 11977
		[SuppressUnmanagedCodeSecurity]
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		internal static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

		// Token: 0x06002ECC RID: 11980
		// RVA: 0x001304CC File Offset: 0x0012E6CC
		private static IntPtr smethod_0(object object_0)
		{
			GCHandle gCHandle = GCHandle.Alloc(object_0, GCHandleType.Pinned);
			IntPtr result = gCHandle.AddrOfPinnedObject();
			gCHandle.Free();
			return result;
		}

		// Token: 0x06002ECD RID: 11981
		// RVA: 0x00023341 File Offset: 0x00021541
		internal static void smethod_1(bool bool_0, string string_0, string string_1, string string_2, string string_3)
		{
			if (Class341.class606_45)
			{
				Class786.smethod_3(bool_0, string_0, string_1, string_2, string_3);
			}
			if (Class341.class606_71)
			{
				Class786.smethod_2(bool_0, string_0, string_1, string_2, string_3);
			}
		}

		// Token: 0x06002ECE RID: 11982
		// RVA: 0x001304F4 File Offset: 0x0012E6F4
		internal static void smethod_2(bool bool_0, string string_0, string string_1, string string_2, string string_3)
		{
			string str;
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Yahoo\\Pager"))
			{
				if (registryKey == null)
				{
					return;
				}
				str = (string)registryKey.GetValue("Yahoo! User ID");
			}
			using (RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Yahoo\\Pager\\profiles\\" + str + "\\Custom Msgs", true))
			{
				if (registryKey2 == null)
				{
					return;
				}
				string text = string.Empty;
				if (bool_0)
				{
					text = string.Format("{0} {1} - {2} {3} (osu!)", new object[]
					{
						(string_0.Length > 0) ? (char.ToUpper(string_0[0]) + string_0.Substring(1)) : "",
						string_2,
						string_1,
						(string_3.Length > 0) ? "[{3}] " : ""
					});
				}
				registryKey2.SetValue("5_W", text);
				byte[] bytes = new ASCIIEncoding().GetBytes(text);
				registryKey2.SetValue("5_DND", bytes);
			}
			IntPtr intptr_ = Class786.FindWindowExA(IntPtr.Zero, IntPtr.Zero, "YahooBuddyMain", null);
			if (intptr_.ToInt32() > 0)
			{
				Class786.PostMessage(intptr_, 273u, 392L, 0L);
			}
		}

		// Token: 0x06002ECF RID: 11983
		// RVA: 0x0013065C File Offset: 0x0012E85C
		internal static void smethod_3(bool bool_0, string string_0, string string_1, string string_2, string string_3)
		{
			string text = string.Format("\\0Music\\0{0}\\0{1} {{0}} - {{1}} {2}({{2}})\\0{3}\\0{4}\\0osu!\\0{5}\\0\0", new object[]
			{
				bool_0 ? "1" : "0",
				(string_0.Length > 0) ? (char.ToUpper(string_0[0]) + string_0.Substring(1)) : "",
				(string_3.Length > 0) ? "[{3}] " : "",
				string_1,
				string_2,
				string_3
			});
			Class786.Struct52 struct;
			struct.intptr_0 = (IntPtr)1351;
			struct.intptr_1 = Class786.smethod_0(text);
			struct.int_0 = text.Length * 2;
			IntPtr intptr_ = Class786.FindWindowExA(IntPtr.Zero, IntPtr.Zero, "MsnMsgrUIManager", null);
			if (intptr_.ToInt32() > 0)
			{
				Class786.SendMessage(intptr_, 74u, IntPtr.Zero, Class786.smethod_0(struct));
			}
		}
	}
}
