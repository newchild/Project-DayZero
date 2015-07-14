using System;
using System.IO;
using System.Threading;

namespace ns30
{
	// Token: 0x020001FB RID: 507
	internal sealed class Class131 : Class129
	{
		// Token: 0x020001FC RID: 508
		// Token: 0x060011D1 RID: 4561
		internal delegate void Delegate9(byte[] byte_0, Exception exception_0);

		// Token: 0x04000DEE RID: 3566
		private Class129.Delegate5 delegate5_0;

		// Token: 0x04000DEF RID: 3567
		private Class131.Delegate9 delegate9_0;

		// Token: 0x060011CC RID: 4556
		// RVA: 0x00010D1F File Offset: 0x0000EF1F
		public Class131(string string_1) : base(string_1)
		{
		}

		// Token: 0x060011CD RID: 4557
		// RVA: 0x0006074C File Offset: 0x0005E94C
		public void method_0(Class131.Delegate9 delegate9_1)
		{
			Class131.Delegate9 delegate = this.delegate9_0;
			Class131.Delegate9 delegate2;
			do
			{
				delegate2 = delegate;
				Class131.Delegate9 value = (Class131.Delegate9)Delegate.Combine(delegate2, delegate9_1);
				delegate = Interlocked.CompareExchange<Class131.Delegate9>(ref this.delegate9_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x060011CE RID: 4558
		// RVA: 0x00060784 File Offset: 0x0005E984
		public override void Perform(bool bool_2)
		{
			try
			{
				if (this.delegate5_0 != null)
				{
					this.delegate5_0();
				}
				using (Stream stream = new MemoryStream())
				{
					using (Class162 class = new Class162())
					{
						class.Get(this.string_0, stream);
					}
					stream.Position = 0L;
					byte[] array = new byte[stream.Length];
					stream.Read(array, 0, (int)stream.Length);
					if (this.delegate9_0 != null)
					{
						this.delegate9_0(array, null);
					}
				}
			}
			catch (Exception ex)
			{
				if (this.delegate9_0 != null)
				{
					this.delegate9_0(null, ex);
				}
				if (bool_2 && !(ex is ThreadAbortException))
				{
					throw;
				}
			}
		}

		// Token: 0x060011CF RID: 4559
		// RVA: 0x00010D28 File Offset: 0x0000EF28
		public override void vmethod_0(Exception exception_0)
		{
			Console.Write("exception! - url " + this.string_0);
			this.delegate9_0(null, exception_0);
		}
	}
}
