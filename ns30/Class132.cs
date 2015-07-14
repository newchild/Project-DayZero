using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns30
{
	// Token: 0x02000201 RID: 513
	internal sealed class Class132 : Class129
	{
		// Token: 0x02000202 RID: 514
		// Token: 0x06001215 RID: 4629
		internal delegate void Delegate11(string string_0, Exception exception_0);

		// Token: 0x04000DFA RID: 3578
		private readonly byte[] byte_0;

		// Token: 0x04000DFD RID: 3581
		private Class162 class162_0;

		// Token: 0x04000DFE RID: 3582
		public Class167 class167_0 = new Class167();

		// Token: 0x04000E01 RID: 3585
		private Class132.Delegate11 delegate11_0;

		// Token: 0x04000DFF RID: 3583
		private Class129.Delegate5 delegate5_0;

		// Token: 0x04000E00 RID: 3584
		private Class129.Delegate6 delegate6_0;

		// Token: 0x04000E02 RID: 3586
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04000E03 RID: 3587
		[CompilerGenerated]
		private int int_1;

		// Token: 0x04000E04 RID: 3588
		[CompilerGenerated]
		private int int_2;

		// Token: 0x04000DFB RID: 3579
		private readonly string string_1;

		// Token: 0x04000DFC RID: 3580
		private readonly string string_2;

		// Token: 0x06001206 RID: 4614
		// RVA: 0x00060C34 File Offset: 0x0005EE34
		public Class132(string string_3, byte[] byte_1, string string_4, string string_5) : base(string_3)
		{
			this.byte_0 = byte_1;
			this.method_0(8192);
			this.string_1 = string_4;
			this.string_2 = string_5;
			this.method_2(-1);
			this.method_4(-1);
		}

		// Token: 0x06001213 RID: 4627
		// RVA: 0x00010FE8 File Offset: 0x0000F1E8
		public void Close()
		{
			if (this.class162_0 != null)
			{
				this.class162_0.Close();
			}
		}

		// Token: 0x06001207 RID: 4615
		// RVA: 0x00010F7A File Offset: 0x0000F17A
		[CompilerGenerated]
		public void method_0(int int_3)
		{
			this.int_0 = int_3;
		}

		// Token: 0x06001208 RID: 4616
		// RVA: 0x00010F83 File Offset: 0x0000F183
		[CompilerGenerated]
		public int method_1()
		{
			return this.int_1;
		}

		// Token: 0x06001209 RID: 4617
		// RVA: 0x00010F8B File Offset: 0x0000F18B
		[CompilerGenerated]
		public void method_2(int int_3)
		{
			this.int_1 = int_3;
		}

		// Token: 0x0600120A RID: 4618
		// RVA: 0x00010F94 File Offset: 0x0000F194
		[CompilerGenerated]
		public int method_3()
		{
			return this.int_2;
		}

		// Token: 0x0600120B RID: 4619
		// RVA: 0x00010F9C File Offset: 0x0000F19C
		[CompilerGenerated]
		public void method_4(int int_3)
		{
			this.int_2 = int_3;
		}

		// Token: 0x0600120C RID: 4620
		// RVA: 0x00060C84 File Offset: 0x0005EE84
		public void method_5(Class129.Delegate6 delegate6_1)
		{
			Class129.Delegate6 delegate = this.delegate6_0;
			Class129.Delegate6 delegate2;
			do
			{
				delegate2 = delegate;
				Class129.Delegate6 value = (Class129.Delegate6)Delegate.Combine(delegate2, delegate6_1);
				delegate = Interlocked.CompareExchange<Class129.Delegate6>(ref this.delegate6_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x0600120D RID: 4621
		// RVA: 0x00060CBC File Offset: 0x0005EEBC
		public void method_6(Class132.Delegate11 delegate11_1)
		{
			Class132.Delegate11 delegate = this.delegate11_0;
			Class132.Delegate11 delegate2;
			do
			{
				delegate2 = delegate;
				Class132.Delegate11 value = (Class132.Delegate11)Delegate.Combine(delegate2, delegate11_1);
				delegate = Interlocked.CompareExchange<Class132.Delegate11>(ref this.delegate11_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x0600120F RID: 4623
		// RVA: 0x00060CF4 File Offset: 0x0005EEF4
		public string method_7(bool bool_2)
		{
			if (this.delegate5_0 != null)
			{
				this.delegate5_0();
			}
			this.class162_0 = new Class162();
			this.class162_0.method_26(this.class167_0);
			this.class162_0.method_12(new EventHandler(this.method_8));
			MemoryStream memoryStream = new MemoryStream();
			try
			{
				Class149 class = this.class167_0.Items.method_1(this.string_1, this.string_2);
				class.method_4(this.byte_0);
				this.class162_0.method_33(new Delegate16(this.method_9));
				this.class162_0.method_50(this.string_0, this.class167_0, memoryStream);
				this.class162_0.method_34(new Delegate16(this.method_9));
			}
			catch (ThreadAbortException)
			{
				this.class162_0.Close();
				if (this.delegate11_0 != null)
				{
					this.delegate11_0(null, new Exception4());
				}
				string result = null;
				return result;
			}
			catch (Exception ex)
			{
				this.class162_0.Close();
				if (this.delegate11_0 != null)
				{
					this.delegate11_0(null, ex);
				}
				if (bool_2 && !(ex is ThreadAbortException))
				{
					throw;
				}
				string result = null;
				return result;
			}
			finally
			{
				this.class162_0.method_13(new EventHandler(this.method_8));
			}
			this.class162_0.Close();
			memoryStream.Position = 0L;
			StreamReader streamReader = new StreamReader(memoryStream);
			string text = streamReader.ReadToEnd();
			if (this.delegate11_0 != null)
			{
				this.delegate11_0(text, null);
			}
			return text;
		}

		// Token: 0x06001210 RID: 4624
		// RVA: 0x00060EA4 File Offset: 0x0005F0A4
		private void method_8(object sender, EventArgs e)
		{
			if (this.method_1() > 0)
			{
				this.class162_0.method_5().method_10().SendTimeout = this.method_1();
			}
			if (this.method_3() > 0)
			{
				this.class162_0.method_5().method_10().ReceiveTimeout = this.method_3();
			}
		}

		// Token: 0x06001211 RID: 4625
		// RVA: 0x00010FAF File Offset: 0x0000F1AF
		private void method_9(object sender, EventArgs6 e)
		{
			if (this.delegate6_0 != null)
			{
				this.delegate6_0(this, e.method_0(), e.method_1());
			}
		}

		// Token: 0x0600120E RID: 4622
		// RVA: 0x00010FA5 File Offset: 0x0000F1A5
		public override void Perform(bool bool_2)
		{
			this.method_7(bool_2);
		}

		// Token: 0x06001212 RID: 4626
		// RVA: 0x00010FD1 File Offset: 0x0000F1D1
		public override void vmethod_0(Exception exception_0)
		{
			if (this.delegate11_0 != null)
			{
				this.delegate11_0(null, exception_0);
			}
		}
	}
}
