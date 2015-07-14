using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ns14
{
	// Token: 0x020005C9 RID: 1481
	[Guid("000214F9-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	internal interface Interface21
	{
		// Token: 0x06002EEA RID: 12010
		void GetDescription([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder pszName, int cchMaxName);

		// Token: 0x06002EE7 RID: 12007
		void imethod_0([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder pszFile, int cchMaxPath, out IntPtr pfd, int fFlags);

		// Token: 0x06002EE8 RID: 12008
		void imethod_1(out IntPtr ppidl);

		// Token: 0x06002EF2 RID: 12018
		void imethod_10(out int piShowCmd);

		// Token: 0x06002EF3 RID: 12019
		void imethod_11(int iShowCmd);

		// Token: 0x06002EF4 RID: 12020
		void imethod_12([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder pszIconPath, int cchIconPath, out int piIcon);

		// Token: 0x06002EF5 RID: 12021
		void imethod_13([MarshalAs(UnmanagedType.LPWStr)] string pszIconPath, int iIcon);

		// Token: 0x06002EF6 RID: 12022
		void imethod_14([MarshalAs(UnmanagedType.LPWStr)] string pszPathRel, int dwReserved);

		// Token: 0x06002EF7 RID: 12023
		void imethod_15(IntPtr hwnd, int fFlags);

		// Token: 0x06002EF8 RID: 12024
		void imethod_16([MarshalAs(UnmanagedType.LPWStr)] string pszFile);

		// Token: 0x06002EE9 RID: 12009
		void imethod_2(IntPtr pidl);

		// Token: 0x06002EEB RID: 12011
		void imethod_3([MarshalAs(UnmanagedType.LPWStr)] string pszName);

		// Token: 0x06002EEC RID: 12012
		void imethod_4([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder pszDir, int cchMaxPath);

		// Token: 0x06002EED RID: 12013
		void imethod_5([MarshalAs(UnmanagedType.LPWStr)] string pszDir);

		// Token: 0x06002EEE RID: 12014
		void imethod_6([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder pszArgs, int cchMaxPath);

		// Token: 0x06002EEF RID: 12015
		void imethod_7([MarshalAs(UnmanagedType.LPWStr)] string pszArgs);

		// Token: 0x06002EF0 RID: 12016
		void imethod_8(out short pwHotkey);

		// Token: 0x06002EF1 RID: 12017
		void imethod_9(short wHotkey);
	}
}
