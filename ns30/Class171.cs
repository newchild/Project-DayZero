using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;

namespace ns30
{
	// Token: 0x02000220 RID: 544
	internal sealed class Class171
	{
		// Token: 0x04000E96 RID: 3734
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04000E8F RID: 3727
		internal Class150 class150_0;

		// Token: 0x04000E92 RID: 3730
		private Enum21 enum21_0;

		// Token: 0x04000E91 RID: 3729
		private int int_0;

		// Token: 0x04000E95 RID: 3733
		private int int_1;

		// Token: 0x04000E90 RID: 3728
		private IPAddress ipaddress_0;

		// Token: 0x04000E93 RID: 3731
		private string string_0;

		// Token: 0x04000E94 RID: 3732
		private string string_1;

		// Token: 0x06001357 RID: 4951
		// RVA: 0x00011EED File Offset: 0x000100ED
		public virtual void Close(bool bool_1)
		{
			this.method_9();
		}

		// Token: 0x06001359 RID: 4953
		// RVA: 0x00011F18 File Offset: 0x00010118
		public virtual void CopyTo(Class171 class171_0)
		{
			class171_0.int_0 = this.method_4();
			class171_0.string_1 = this.method_7();
			class171_0.string_0 = this.method_6();
			class171_0.ipaddress_0 = this.method_3();
			class171_0.int_1 = this.method_8();
		}

		// Token: 0x0600134D RID: 4941
		// RVA: 0x00011E9B File Offset: 0x0001009B
		public Class150 method_0()
		{
			return this.class150_0;
		}

		// Token: 0x0600134E RID: 4942
		// RVA: 0x00011EA3 File Offset: 0x000100A3
		[CompilerGenerated]
		public bool method_1()
		{
			return this.bool_0;
		}

		// Token: 0x0600134F RID: 4943
		// RVA: 0x00011EAB File Offset: 0x000100AB
		[CompilerGenerated]
		public void method_2(bool bool_1)
		{
			this.bool_0 = bool_1;
		}

		// Token: 0x06001350 RID: 4944
		// RVA: 0x00011EB4 File Offset: 0x000100B4
		public IPAddress method_3()
		{
			return this.ipaddress_0;
		}

		// Token: 0x06001351 RID: 4945
		// RVA: 0x00011EBC File Offset: 0x000100BC
		public int method_4()
		{
			return this.int_0;
		}

		// Token: 0x06001352 RID: 4946
		// RVA: 0x00011EC4 File Offset: 0x000100C4
		public Enum21 method_5()
		{
			return this.enum21_0;
		}

		// Token: 0x06001353 RID: 4947
		// RVA: 0x00011ECC File Offset: 0x000100CC
		public string method_6()
		{
			return this.string_0;
		}

		// Token: 0x06001354 RID: 4948
		// RVA: 0x00011ED4 File Offset: 0x000100D4
		public string method_7()
		{
			return this.string_1;
		}

		// Token: 0x06001355 RID: 4949
		// RVA: 0x00011EDC File Offset: 0x000100DC
		public int method_8()
		{
			return this.int_1;
		}

		// Token: 0x06001356 RID: 4950
		// RVA: 0x00011EE4 File Offset: 0x000100E4
		public void method_9()
		{
			this.enum21_0 = Enum21.const_0;
		}

		// Token: 0x0600135B RID: 4955
		// RVA: 0x00011F56 File Offset: 0x00010156
		public virtual bool Read(Stream stream_0)
		{
			this.method_9();
			return this.method_0().vmethod_2(stream_0);
		}

		// Token: 0x06001358 RID: 4952
		// RVA: 0x00011EF5 File Offset: 0x000100F5
		public virtual bool vmethod_0(IPAddress ipaddress_1, int int_2)
		{
			this.method_9();
			this.ipaddress_0 = ipaddress_1;
			this.int_1 = int_2;
			return this.method_0().vmethod_1(ipaddress_1, int_2);
		}

		// Token: 0x0600135A RID: 4954
		// RVA: 0x00063F8C File Offset: 0x0006218C
		public virtual int vmethod_1()
		{
			if (this.method_0().method_1() < 1)
			{
				throw new Exception2("Invalid Batch Size", -1);
			}
			if (this.method_0().method_6() > -1L && this.method_0().method_6() - this.method_0().long_0 < (long)this.method_0().method_1())
			{
				return (int)(this.method_0().method_6() - this.method_0().long_0);
			}
			return this.method_0().method_1();
		}

		// Token: 0x0600135C RID: 4956
		// RVA: 0x00011F6A File Offset: 0x0001016A
		protected internal virtual void vmethod_2()
		{
			this.method_0().vmethod_5(new EventArgs());
		}

		// Token: 0x0600135D RID: 4957
		// RVA: 0x00064014 File Offset: 0x00062214
		protected internal virtual void vmethod_3(int int_2)
		{
			Class150 class = this.method_0();
			class.long_0 += (long)int_2;
			Class150 class2 = this.method_0();
			class2.long_3 += (long)int_2;
			this.method_0().vmethod_4(new EventArgs6(this.method_0().long_3, this.method_0().long_2));
		}

		// Token: 0x0600135E RID: 4958
		// RVA: 0x00011F7C File Offset: 0x0001017C
		public virtual bool Write(Stream stream_0)
		{
			this.method_9();
			return stream_0.Length == 0L || this.method_0().vmethod_3(stream_0);
		}
	}
}
