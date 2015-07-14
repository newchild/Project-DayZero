using Microsoft.Xna.Framework.Input;
using System;
using System.Windows.Forms;

namespace ns9
{
	// Token: 0x020001CE RID: 462
	internal sealed class Class119 : Class118
	{
		// Token: 0x04000C7C RID: 3196
		private bool bool_0;

		// Token: 0x04000C7D RID: 3197
		private bool bool_1;

		// Token: 0x04000C7E RID: 3198
		private Class114 class114_0;

		// Token: 0x04000C7B RID: 3195
		private readonly Class122 class122_0;

		// Token: 0x06001062 RID: 4194
		// RVA: 0x0005659C File Offset: 0x0005479C
		public Class119(Class114 class114_1)
		{
			this.class114_0 = class114_1;
			this.class122_0 = new Class122();
			Mouse.set_WindowHandle(this.class122_0.vmethod_1());
			this.class122_0.vmethod_3(class114_1.method_1());
			this.class122_0.method_0(new EventHandler(this.method_13));
			this.class122_0.method_3(new EventHandler(this.method_14));
			this.class122_0.method_11(new EventHandler(this.method_16));
			this.class122_0.method_10(new EventHandler(this.method_15));
		}

		// Token: 0x06001064 RID: 4196
		// RVA: 0x00056640 File Offset: 0x00054840
		private void method_12(object sender, EventArgs e)
		{
			Class126.Struct18 struct;
			while (!Class126.PeekMessage(ref struct, IntPtr.Zero, 0u, 0u, 0u))
			{
				if (this.bool_1)
				{
					this.class122_0.Close();
				}
				else
				{
					base.method_9();
				}
			}
		}

		// Token: 0x06001066 RID: 4198
		// RVA: 0x00010068 File Offset: 0x0000E268
		private void method_13(object sender, EventArgs e)
		{
			base.method_6();
		}

		// Token: 0x06001067 RID: 4199
		// RVA: 0x00010070 File Offset: 0x0000E270
		private void method_14(object sender, EventArgs e)
		{
			base.method_7();
		}

		// Token: 0x06001068 RID: 4200
		// RVA: 0x00010078 File Offset: 0x0000E278
		private void method_15(object sender, EventArgs e)
		{
			base.method_10();
		}

		// Token: 0x06001069 RID: 4201
		// RVA: 0x00010080 File Offset: 0x0000E280
		private void method_16(object sender, EventArgs e)
		{
			base.method_11();
		}

		// Token: 0x0600106A RID: 4202
		// RVA: 0x0005667C File Offset: 0x0005487C
		internal override void Run()
		{
			if (this.bool_0)
			{
				throw new InvalidOperationException(Class127.smethod_13());
			}
			Exception ex = null;
			try
			{
				Application.Idle += new EventHandler(this.method_12);
				Application.Run(this.class122_0.method_20());
			}
			catch (OutOfMemoryException ex2)
			{
				ex = ex2;
			}
			finally
			{
				Application.Idle -= new EventHandler(this.method_12);
				this.bool_0 = true;
				if (ex == null || !(ex is OutOfMemoryException))
				{
					base.method_8();
				}
			}
		}

		// Token: 0x06001065 RID: 4197
		// RVA: 0x0001005F File Offset: 0x0000E25F
		internal override void vmethod_0()
		{
			this.bool_1 = true;
		}

		// Token: 0x06001063 RID: 4195
		// RVA: 0x00010057 File Offset: 0x0000E257
		internal override Class121 vmethod_1()
		{
			return this.class122_0;
		}
	}
}
