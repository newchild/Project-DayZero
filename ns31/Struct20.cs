using ns8;
using osu_common.Bancho;
using System;
using System.Runtime.CompilerServices;

namespace ns31
{
	// Token: 0x020001D5 RID: 469
	internal struct Struct20 : bSerializable
	{
		// Token: 0x04000C91 RID: 3217
		[CompilerGenerated]
		private byte[] byte_0;

		// Token: 0x04000C92 RID: 3218
		[CompilerGenerated]
		private DateTime dateTime_0;

		// Token: 0x04000C93 RID: 3219
		[CompilerGenerated]
		private DateTime dateTime_1;

		// Token: 0x04000C8F RID: 3215
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04000C90 RID: 3216
		[CompilerGenerated]
		private int int_1;

		// Token: 0x04000C8E RID: 3214
		[CompilerGenerated]
		private string string_0;

		// Token: 0x1700028B RID: 651
		public int Length
		{
			// Token: 0x060010A2 RID: 4258
			// RVA: 0x000102B3 File Offset: 0x0000E4B3
			[CompilerGenerated]
			get
			{
				return this.int_0;
			}
		}

		// Token: 0x060010AC RID: 4268
		// RVA: 0x00010308 File Offset: 0x0000E508
		public Struct20(string string_1, int int_2, int int_3, byte[] byte_1, DateTime dateTime_2, DateTime dateTime_3)
		{
			this = default(Struct20);
			this.method_1(string_1);
			this.method_4(int_2);
			this.method_2(int_3);
			this.method_6(byte_1);
			this.method_8(dateTime_2);
			this.method_10(dateTime_3);
		}

		// Token: 0x060010A0 RID: 4256
		// RVA: 0x000102A2 File Offset: 0x0000E4A2
		[CompilerGenerated]
		public string method_0()
		{
			return this.string_0;
		}

		// Token: 0x060010A1 RID: 4257
		// RVA: 0x000102AA File Offset: 0x0000E4AA
		[CompilerGenerated]
		private void method_1(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x060010AB RID: 4267
		// RVA: 0x000102FF File Offset: 0x0000E4FF
		[CompilerGenerated]
		private void method_10(DateTime dateTime_2)
		{
			this.dateTime_1 = dateTime_2;
		}

		// Token: 0x060010A3 RID: 4259
		// RVA: 0x000102BB File Offset: 0x0000E4BB
		[CompilerGenerated]
		private void method_2(int int_2)
		{
			this.int_0 = int_2;
		}

		// Token: 0x060010A4 RID: 4260
		// RVA: 0x000102C4 File Offset: 0x0000E4C4
		[CompilerGenerated]
		public int method_3()
		{
			return this.int_1;
		}

		// Token: 0x060010A5 RID: 4261
		// RVA: 0x000102CC File Offset: 0x0000E4CC
		[CompilerGenerated]
		private void method_4(int int_2)
		{
			this.int_1 = int_2;
		}

		// Token: 0x060010A6 RID: 4262
		// RVA: 0x000102D5 File Offset: 0x0000E4D5
		[CompilerGenerated]
		public byte[] method_5()
		{
			return this.byte_0;
		}

		// Token: 0x060010A7 RID: 4263
		// RVA: 0x000102DD File Offset: 0x0000E4DD
		[CompilerGenerated]
		private void method_6(byte[] byte_1)
		{
			this.byte_0 = byte_1;
		}

		// Token: 0x060010A8 RID: 4264
		// RVA: 0x000102E6 File Offset: 0x0000E4E6
		[CompilerGenerated]
		public DateTime method_7()
		{
			return this.dateTime_0;
		}

		// Token: 0x060010A9 RID: 4265
		// RVA: 0x000102EE File Offset: 0x0000E4EE
		[CompilerGenerated]
		private void method_8(DateTime dateTime_2)
		{
			this.dateTime_0 = dateTime_2;
		}

		// Token: 0x060010AA RID: 4266
		// RVA: 0x000102F7 File Offset: 0x0000E4F7
		[CompilerGenerated]
		public DateTime method_9()
		{
			return this.dateTime_1;
		}

		// Token: 0x060010AD RID: 4269
		// RVA: 0x00056BD8 File Offset: 0x00054DD8
		public void ReadFromStream(Class32 class32_0)
		{
			this.method_1(class32_0.ReadString());
			this.method_2(class32_0.ReadInt32());
			this.method_4(class32_0.ReadInt32());
			this.method_6(class32_0.ReadByteArray());
			this.method_8((DateTime)class32_0.method_4());
			this.method_10((DateTime)class32_0.method_4());
		}

		// Token: 0x060010AE RID: 4270
		// RVA: 0x00056C38 File Offset: 0x00054E38
		public void WriteToStream(Class31 class31_0)
		{
			class31_0.Write(this.method_0());
			class31_0.Write(this.Length);
			class31_0.Write(this.method_3());
			class31_0.method_2(this.method_5());
			class31_0.method_0(this.method_7());
			class31_0.method_0(this.method_9());
		}
	}
}
