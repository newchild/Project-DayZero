using ns29;
using ns8;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ns82
{
	// Token: 0x020005FC RID: 1532
	internal sealed class Class799 : TextBox
	{
		// Token: 0x020005FD RID: 1533
		internal struct Struct68
		{
			// Token: 0x04002B28 RID: 11048
			public uint uint_0;

			// Token: 0x04002B29 RID: 11049
			public uint uint_1;

			// Token: 0x04002B2A RID: 11050
			public uint uint_2;

			// Token: 0x04002B2B RID: 11051
			public uint uint_3;

			// Token: 0x04002B2C RID: 11052
			public uint uint_4;

			// Token: 0x04002B2D RID: 11053
			public uint uint_5;

			// Token: 0x04002B2E RID: 11054
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.U4)]
			public uint[] uint_6;
		}

		// Token: 0x04002B23 RID: 11043
		internal bool bool_0;

		// Token: 0x04002B26 RID: 11046
		private Delegate0 delegate0_0;

		// Token: 0x04002B27 RID: 11047
		private Delegate1 delegate1_0;

		// Token: 0x04002B24 RID: 11044
		internal int int_0;

		// Token: 0x04002B25 RID: 11045
		internal List<string> list_0 = new List<string>();

		// Token: 0x06002F74 RID: 12148
		[SuppressUnmanagedCodeSecurity]
		[DllImport("imm32.dll", CharSet = CharSet.Auto)]
		public static extern uint ImmGetCandidateList(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, uint uint_1);

		// Token: 0x06002F72 RID: 12146
		[SuppressUnmanagedCodeSecurity]
		[DllImport("imm32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int ImmGetCompositionString(IntPtr intptr_0, int int_1, byte[] byte_0, int int_2);

		// Token: 0x06002F71 RID: 12145
		[SuppressUnmanagedCodeSecurity]
		[DllImport("Imm32.dll")]
		private static extern IntPtr ImmGetContext(IntPtr intptr_0);

		// Token: 0x06002F73 RID: 12147
		[SuppressUnmanagedCodeSecurity]
		[DllImport("Imm32.dll")]
		private static extern bool ImmReleaseContext(IntPtr intptr_0, IntPtr intptr_1);

		// Token: 0x06002F76 RID: 12150
		// RVA: 0x00133A00 File Offset: 0x00131C00
		private void method_0(string string_0)
		{
			Delegate0 delegate = this.delegate0_0;
			if (delegate != null)
			{
				delegate(string_0);
			}
		}

		// Token: 0x06002F77 RID: 12151
		// RVA: 0x00133A20 File Offset: 0x00131C20
		internal void method_1(Delegate0 delegate0_1)
		{
			Delegate0 delegate = this.delegate0_0;
			Delegate0 delegate2;
			do
			{
				delegate2 = delegate;
				Delegate0 value = (Delegate0)Delegate.Combine(delegate2, delegate0_1);
				delegate = Interlocked.CompareExchange<Delegate0>(ref this.delegate0_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06002F78 RID: 12152
		// RVA: 0x00133A58 File Offset: 0x00131C58
		internal void method_2(Delegate1 delegate1_1)
		{
			Delegate1 delegate = this.delegate1_0;
			Delegate1 delegate2;
			do
			{
				delegate2 = delegate;
				Delegate1 value = (Delegate1)Delegate.Combine(delegate2, delegate1_1);
				delegate = Interlocked.CompareExchange<Delegate1>(ref this.delegate1_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06002F75 RID: 12149
		// RVA: 0x00133770 File Offset: 0x00131970
		protected override void WndProc(ref Message m)
		{
			int msg = m.Msg;
			if (msg != 123)
			{
				switch (msg)
				{
				case 269:
					this.bool_0 = true;
					if (this.delegate1_0 != null)
					{
						this.delegate1_0(true);
					}
					base.Parent.Location = new Point(base.Parent.Location.X, base.Parent.Location.Y - 5000);
					break;
				case 270:
					this.bool_0 = false;
					this.int_0 = Class115.int_1;
					if (this.delegate1_0 != null)
					{
						this.delegate1_0(false);
					}
					base.Parent.Location = new Point(base.Parent.Location.X, base.Parent.Location.Y + 5000);
					break;
				case 271:
					if (((int)m.LParam & 8) > 0)
					{
						IntPtr intPtr = Class799.ImmGetContext(base.Handle);
						int num = Class799.ImmGetCompositionString(intPtr, 8, null, 0);
						byte[] array = new byte[num];
						Class799.ImmGetCompositionString(intPtr, 8, array, num);
						Class799.ImmReleaseContext(base.Handle, intPtr);
						this.method_0(Encoding.Unicode.GetString(array));
					}
					break;
				default:
					if (msg == 642)
					{
						switch (m.WParam.ToInt32())
						{
						case 3:
						case 5:
						{
							IntPtr intPtr2 = Class799.ImmGetContext(base.Handle);
							uint num2 = Class799.ImmGetCandidateList(intPtr2, 0u, IntPtr.Zero, 0u);
							this.list_0.Clear();
							if (num2 > 0u)
							{
								IntPtr intPtr3 = Marshal.AllocHGlobal((int)num2);
								num2 = Class799.ImmGetCandidateList(intPtr2, 0u, intPtr3, num2);
								Class799.Struct68 struct = (Class799.Struct68)Marshal.PtrToStructure(intPtr3, typeof(Class799.Struct68));
								if (struct.uint_2 > 1u)
								{
									int num3 = (int)struct.uint_4;
									while ((long)num3 < (long)((ulong)struct.uint_2) && (long)num3 - (long)((ulong)struct.uint_4) <= (long)((ulong)(struct.uint_5 - 1u)))
									{
										int num4 = Marshal.ReadInt32(intPtr3, 24 + 4 * num3);
										IntPtr ptr = (IntPtr)(intPtr3.ToInt32() + num4);
										string item = Marshal.PtrToStringUni(ptr);
										this.list_0.Add(item);
										num3++;
									}
								}
								Marshal.FreeHGlobal(intPtr3);
							}
							Class799.ImmReleaseContext(base.Handle, intPtr2);
							break;
						}
						case 4:
							this.list_0.Clear();
							break;
						}
					}
					break;
				}
				base.WndProc(ref m);
				return;
			}
		}
	}
}
