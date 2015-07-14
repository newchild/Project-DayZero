using Microsoft.Xna.Framework;
using ns81;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ns14
{
	// Token: 0x02000466 RID: 1126
	internal static class Class559
	{
		// Token: 0x02000467 RID: 1127
		internal static class Class560
		{
			// Token: 0x02000468 RID: 1128
			internal sealed class Class561 : NativeWindow
			{
				// Token: 0x04001E54 RID: 7764
				private Delegate42 delegate42_0;

				// Token: 0x06002489 RID: 9353
				// RVA: 0x0001CA07 File Offset: 0x0001AC07
				internal Class561(IntPtr intptr_0)
				{
					base.AssignHandle(intptr_0);
				}

				// Token: 0x0600248A RID: 9354
				// RVA: 0x0001CA16 File Offset: 0x0001AC16
				internal void Dispose()
				{
					this.ReleaseHandle();
				}

				// Token: 0x06002488 RID: 9352
				// RVA: 0x000DD0B8 File Offset: 0x000DB2B8
				internal void method_0(Delegate42 delegate42_1)
				{
					Delegate42 delegate = this.delegate42_0;
					Delegate42 delegate2;
					do
					{
						delegate2 = delegate;
						Delegate42 value = (Delegate42)Delegate.Combine(delegate2, delegate42_1);
						delegate = Interlocked.CompareExchange<Delegate42>(ref this.delegate42_0, value, delegate2);
					}
					while (delegate != delegate2);
				}

				// Token: 0x0600248B RID: 9355
				// RVA: 0x000DD0F0 File Offset: 0x000DB2F0
				protected override void WndProc(ref Message m)
				{
					if (this.delegate42_0 != null)
					{
						this.delegate42_0(ref m);
					}
					if (m.Result.ToInt32() < 0)
					{
						m.Result = new IntPtr(-m.Result.ToInt32() - 1);
						return;
					}
					base.WndProc(ref m);
				}
			}

			// Token: 0x06002487 RID: 9351
			// RVA: 0x0001C9E4 File Offset: 0x0001ABE4
			internal static Rectangle smethod_0()
			{
				return new Rectangle(Class559.GetSystemMetrics(76), Class559.GetSystemMetrics(77), Class559.GetSystemMetrics(78), Class559.GetSystemMetrics(79));
			}
		}

		// Token: 0x06002486 RID: 9350
		[DllImport("user32.dll")]
		public static extern bool GetPointerInfo(int int_0, ref Struct57 struct57_0);

		// Token: 0x06002485 RID: 9349
		[DllImport("user32.dll")]
		public static extern int GetRawInputData(IntPtr intptr_0, Enum84 enum84_0, ref Struct58 struct58_0, ref int int_0, int int_1);

		// Token: 0x06002483 RID: 9347
		[DllImport("user32.dll")]
		public static extern int GetSystemMetrics(int int_0);

		// Token: 0x06002480 RID: 9344
		[DllImport("Kernel32.dll")]
		internal static extern ushort GlobalAddAtom(string string_0);

		// Token: 0x06002481 RID: 9345
		[DllImport("Kernel32.dll")]
		internal static extern ushort GlobalDeleteAtom(ushort ushort_0);

		// Token: 0x06002484 RID: 9348
		[DllImport("user32.dll")]
		public static extern bool RegisterRawInputDevices([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] Struct63[] pRawInputDevices, int int_0, int int_1);

		// Token: 0x0600247F RID: 9343
		[DllImport("user32.dll")]
		public static extern bool RegisterTouchWindow(IntPtr intptr_0, int int_0);

		// Token: 0x06002482 RID: 9346
		[DllImport("user32.dll")]
		internal static extern int SetProp(IntPtr intptr_0, string string_0, int int_0);
	}
}
