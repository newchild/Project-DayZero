using System;
using System.Runtime.InteropServices;

namespace ns1
{
	// Token: 0x02000009 RID: 9
	internal sealed class Class6
	{
		// Token: 0x0200000C RID: 12
		[Guid("0000000c-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		[ComImport]
		public interface Interface0
		{
			// Token: 0x06000028 RID: 40
			void imethod_0(IntPtr pv, uint cb, out uint pcbRead);

			// Token: 0x06000029 RID: 41
			void imethod_1(IntPtr pv, uint cb, out uint pcbWritten);

			// Token: 0x06000032 RID: 50
			void imethod_10(out Class6.Interface0 ppstm);

			// Token: 0x0600002A RID: 42
			void imethod_2(long dlibMove, uint dwOrigin, out ulong plibNewPosition);

			// Token: 0x0600002B RID: 43
			void imethod_3(ulong libNewSize);

			// Token: 0x0600002C RID: 44
			void imethod_4(Class6.Interface0 pstm, ulong cb, out ulong pcbRead, out ulong pcbWritten);

			// Token: 0x0600002D RID: 45
			void imethod_5(uint grfCommitFlags);

			// Token: 0x0600002E RID: 46
			void imethod_6();

			// Token: 0x0600002F RID: 47
			void imethod_7(ulong libOffset, ulong cb, uint dwLockType);

			// Token: 0x06000030 RID: 48
			void imethod_8(ulong libOffset, ulong cb, uint dwLockType);

			// Token: 0x06000031 RID: 49
			void imethod_9(out Class6.Struct1 pstatstg, uint grfStatFlag);
		}

		// Token: 0x0200000D RID: 13
		[Guid("7c23ff90-33af-11d3-95da-00a024a85b51"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		[ComImport]
		internal interface Interface1
		{
			// Token: 0x06000033 RID: 51
			void imethod_0(Class6.Interface2 pName);

			// Token: 0x06000034 RID: 52
			void imethod_1(out Class6.Interface2 ppName);

			// Token: 0x06000035 RID: 53
			void imethod_2([MarshalAs(UnmanagedType.LPWStr)] string szName, int pvValue, uint cbValue, uint dwFlags);

			// Token: 0x06000036 RID: 54
			void imethod_3([MarshalAs(UnmanagedType.LPWStr)] string szName, out int pvValue, ref uint pcbValue, uint dwFlags);

			// Token: 0x06000037 RID: 55
			void imethod_4(out int wzDynamicDir, ref uint pdwSize);
		}

		// Token: 0x0200000E RID: 14
		[Guid("CD193BC0-B4BC-11d2-9833-00C04FC31D2E"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		[ComImport]
		internal interface Interface2
		{
			// Token: 0x06000038 RID: 56
			[PreserveSig]
			int imethod_0(uint PropertyId, IntPtr pvProperty, uint cbProperty);

			// Token: 0x06000039 RID: 57
			[PreserveSig]
			int imethod_1(uint PropertyId, IntPtr pvProperty, ref uint pcbProperty);

			// Token: 0x0600003A RID: 58
			[PreserveSig]
			int imethod_2();

			// Token: 0x0600003B RID: 59
			[PreserveSig]
			int imethod_3(IntPtr szDisplayName, ref uint pccDisplayName, uint dwDisplayFlags);

			// Token: 0x0600003C RID: 60
			[PreserveSig]
			int imethod_4(object refIID, object pAsmBindSink, Class6.Interface1 pApplicationContext, [MarshalAs(UnmanagedType.LPWStr)] string szCodeBase, long llFlags, int pvReserved, uint cbReserved, out int ppv);

			// Token: 0x0600003D RID: 61
			[PreserveSig]
			int imethod_5(out uint lpcwBuffer, out int pwzName);

			// Token: 0x0600003E RID: 62
			[PreserveSig]
			int imethod_6(out uint pdwVersionHi, out uint pdwVersionLow);

			// Token: 0x0600003F RID: 63
			[PreserveSig]
			int imethod_7(Class6.Interface2 pName, uint dwCmpFlags);

			// Token: 0x06000040 RID: 64
			[PreserveSig]
			int imethod_8(out Class6.Interface2 pName);
		}

		// Token: 0x0200000F RID: 15
		[Guid("9e3aaeb4-d1cd-11d2-bab9-00c04f8eceae"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		[ComImport]
		internal interface Interface3
		{
			// Token: 0x06000041 RID: 65
			void imethod_0([MarshalAs(UnmanagedType.LPWStr)] string pszName, uint dwFormat, uint dwFlags, uint dwMaxSize, out Class6.Interface0 ppStream);

			// Token: 0x06000042 RID: 66
			void imethod_1(Class6.Interface2 pName);

			// Token: 0x06000043 RID: 67
			void imethod_2(uint dwFlags);

			// Token: 0x06000044 RID: 68
			void imethod_3(uint dwFlags);
		}

		// Token: 0x02000010 RID: 16
		[Guid("e707dcde-d1cd-11d2-bab9-00c04f8eceae"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		[ComImport]
		internal interface Interface4
		{
			// Token: 0x06000045 RID: 69
			[PreserveSig]
			int imethod_0(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName, IntPtr pvReserved, out uint pulDisposition);

			// Token: 0x06000046 RID: 70
			[PreserveSig]
			int imethod_1(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName, IntPtr pAsmInfo);

			// Token: 0x06000047 RID: 71
			[PreserveSig]
			int imethod_2(uint dwFlags, IntPtr pvReserved, out Class6.Interface3 ppAsmItem, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName);

			// Token: 0x06000048 RID: 72
			[PreserveSig]
			int imethod_3(out object ppAsmScavenger);

			// Token: 0x06000049 RID: 73
			[PreserveSig]
			int imethod_4(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszManifestFilePath, IntPtr pvReserved);
		}

		// Token: 0x0200000A RID: 10
		public struct Struct0
		{
			// Token: 0x0400002D RID: 45
			public int int_0;

			// Token: 0x0400002E RID: 46
			public int int_1;
		}

		// Token: 0x0200000B RID: 11
		public struct Struct1
		{
			// Token: 0x04000031 RID: 49
			public Guid guid_0;

			// Token: 0x04000033 RID: 51
			public int int_0;

			// Token: 0x04000034 RID: 52
			public int int_1;

			// Token: 0x04000035 RID: 53
			public int int_2;

			// Token: 0x04000038 RID: 56
			public int int_3;

			// Token: 0x04000039 RID: 57
			public int int_4;

			// Token: 0x04000030 RID: 48
			public long long_0;

			// Token: 0x04000037 RID: 55
			public string string_0;

			// Token: 0x0400002F RID: 47
			public Class6.Struct0 struct0_0;

			// Token: 0x04000032 RID: 50
			public Class6.Struct0 struct0_1;

			// Token: 0x04000036 RID: 54
			public Class6.Struct0 struct0_2;
		}

		// Token: 0x06000026 RID: 38
		[DllImport("fusion", CharSet = CharSet.Auto)]
		internal static extern int CreateAssemblyCache(ref Class6.Interface4 interface4_0, uint uint_0);

		// Token: 0x06000027 RID: 39
		// RVA: 0x00028520 File Offset: 0x00026720
		public static int smethod_0(string string_0)
		{
			Class6.Interface4 interface = null;
			int num = Class6.CreateAssemblyCache(ref interface, 0u);
			if (num != 0)
			{
				return num;
			}
			return interface.imethod_4(0u, string_0, IntPtr.Zero);
		}
	}
}
