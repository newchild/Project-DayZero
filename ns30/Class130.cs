using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns30
{
	// Token: 0x020001D3 RID: 467
	internal sealed class Class130 : Class129
	{
		// Token: 0x020001D4 RID: 468
		// Token: 0x0600109D RID: 4253
		internal delegate void Delegate7(string string_0, Exception exception_0);

		// Token: 0x04000C88 RID: 3208
		private Class162 class162_0;

		// Token: 0x04000C8C RID: 3212
		private Class167 class167_0;

		// Token: 0x04000C89 RID: 3209
		private Class129.Delegate5 delegate5_0;

		// Token: 0x04000C8A RID: 3210
		private Class129.Delegate6 delegate6_0;

		// Token: 0x04000C8B RID: 3211
		private Class130.Delegate7 delegate7_0;

		// Token: 0x04000C8D RID: 3213
		[CompilerGenerated]
		private int int_0;

		// Token: 0x06001094 RID: 4244
		// RVA: 0x0001021D File Offset: 0x0000E41D
		public Class130(string string_1) : base(string_1)
		{
			this.method_1(8192);
			this.class162_0 = new Class162();
			this.class167_0 = new Class167();
			this.class162_0.method_26(this.class167_0);
		}

		// Token: 0x06001095 RID: 4245
		// RVA: 0x00010258 File Offset: 0x0000E458
		public void method_0(string string_1, string string_2)
		{
			this.class167_0.Items.method_0(string_1, string_2);
		}

		// Token: 0x06001096 RID: 4246
		// RVA: 0x0001026D File Offset: 0x0000E46D
		[CompilerGenerated]
		public void method_1(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x06001097 RID: 4247
		// RVA: 0x00056AD4 File Offset: 0x00054CD4
		public void method_2(Class130.Delegate7 delegate7_1)
		{
			Class130.Delegate7 delegate = this.delegate7_0;
			Class130.Delegate7 delegate2;
			do
			{
				delegate2 = delegate;
				Class130.Delegate7 value = (Class130.Delegate7)Delegate.Combine(delegate2, delegate7_1);
				delegate = Interlocked.CompareExchange<Class130.Delegate7>(ref this.delegate7_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06001099 RID: 4249
		// RVA: 0x00056B0C File Offset: 0x00054D0C
		public string method_3(bool bool_2)
		{
			if (this.delegate5_0 != null)
			{
				this.delegate5_0();
			}
			MemoryStream memoryStream = new MemoryStream();
			try
			{
				this.class162_0.method_33(new Delegate16(this.method_4));
				this.class162_0.method_50(this.string_0, this.class167_0, memoryStream);
				this.class162_0.method_34(new Delegate16(this.method_4));
			}
			catch (Exception ex)
			{
				if (bool_2 && !(ex is ThreadAbortException))
				{
					throw;
				}
			}
			this.class162_0.Close();
			memoryStream.Position = 0L;
			StreamReader streamReader = new StreamReader(memoryStream);
			string text = streamReader.ReadToEnd();
			if (this.delegate7_0 != null)
			{
				this.delegate7_0(text, null);
			}
			return text;
		}

		// Token: 0x0600109A RID: 4250
		// RVA: 0x00010280 File Offset: 0x0000E480
		private void method_4(object sender, EventArgs6 e)
		{
			if (this.delegate6_0 != null)
			{
				this.delegate6_0(this, e.method_0(), e.method_1());
			}
		}

		// Token: 0x06001098 RID: 4248
		// RVA: 0x00010276 File Offset: 0x0000E476
		public override void Perform(bool bool_2)
		{
			this.method_3(bool_2);
		}

		// Token: 0x0600109B RID: 4251
		// RVA: 0x000060D8 File Offset: 0x000042D8
		public override void vmethod_0(Exception exception_0)
		{
			throw new NotImplementedException();
		}
	}
}
