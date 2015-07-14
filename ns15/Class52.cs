using ns32;
using ns33;
using System;
using System.IO;
using System.Threading;

namespace ns15
{
	// Token: 0x020001B0 RID: 432
	internal sealed class Class52
	{
		// Token: 0x04000BC7 RID: 3015
		private Delegate3 delegate3_0;

		// Token: 0x04000BC8 RID: 3016
		private int int_0;

		// Token: 0x06000F21 RID: 3873
		// RVA: 0x00052A08 File Offset: 0x00050C08
		public void method_0(Delegate3 delegate3_1)
		{
			Delegate3 delegate = this.delegate3_0;
			Delegate3 delegate2;
			do
			{
				delegate2 = delegate;
				Delegate3 value = (Delegate3)Delegate.Combine(delegate2, delegate3_1);
				delegate = Interlocked.CompareExchange<Delegate3>(ref this.delegate3_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06000F23 RID: 3875
		// RVA: 0x00052AD8 File Offset: 0x00050CD8
		public void method_1(string string_0, string string_1, string string_2, Enum7 enum7_0)
		{
			long num;
			long num2;
			long num3;
			using (FileStream fileStream = File.OpenRead(string_2))
			{
				byte[] array = new byte[32];
				if (fileStream.Read(array, 0, 32) < 32)
				{
					throw new Exception("invalid patch file (too small)");
				}
				if (!Class52.smethod_1(array, "BSDIFF40", 0, 8))
				{
					throw new Exception("invalid patch file (no magic)");
				}
				num = (long)Class52.smethod_0(array, 8);
				num2 = (long)Class52.smethod_0(array, 16);
				num3 = (long)Class52.smethod_0(array, 24);
				if (num < 0L || num2 < 0L || num3 < 0L)
				{
					throw new Exception("invalid patch file (sizes are corrupt)");
				}
			}
			long long_ = num3 * 3L;
			byte[] array2;
			byte[] array3;
			byte[] array4;
			using (FileStream fileStream2 = File.OpenRead(string_2))
			{
				fileStream2.Seek(32L, SeekOrigin.Begin);
				array2 = new byte[num];
				fileStream2.Read(array2, 0, array2.Length);
				array3 = new byte[num2];
				fileStream2.Read(array3, 0, array3.Length);
				array4 = new byte[fileStream2.Length - fileStream2.Position];
				fileStream2.Read(array4, 0, array4.Length);
			}
			Stream stream;
			Stream stream2;
			Stream stream3;
			if (enum7_0 == Enum7.const_1)
			{
				stream = new Stream10(new MemoryStream(array2));
				stream2 = new Stream10(new MemoryStream(array3));
				stream3 = new Stream10(new MemoryStream(array4));
			}
			else
			{
				stream = new Stream4(new MemoryStream(array2), Enum12.const_1, Enum11.const_0);
				stream2 = new Stream4(new MemoryStream(array3), Enum12.const_1, Enum11.const_0);
				stream3 = new Stream4(new MemoryStream(array4), Enum12.const_1, Enum11.const_0);
			}
			int num4 = 1048573;
			byte[] array5;
			using (FileStream fileStream3 = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				long length = fileStream3.Length;
				array5 = new byte[(int)length];
				for (int i = 0; i < array5.Length; i += num4)
				{
					fileStream3.Read(array5, i, Math.Min(num4, array5.Length - i));
					this.method_2((long)i, long_);
				}
			}
			byte[] array6 = new byte[num3];
			long num5 = (long)array5.Length;
			int num6 = 0;
			int num7 = 0;
			int[] array7 = new int[3];
			byte[] array8 = new byte[8];
			while ((long)num6 < num3)
			{
				int num8;
				for (int j = 0; j <= 2; j++)
				{
					num8 = stream.Read(array8, 0, 8);
					if (num8 < 8)
					{
						throw new Exception("invalid patch file (corrupt)");
					}
					array7[j] = Class52.smethod_0(array8, 0);
				}
				if ((long)(num6 + array7[0]) > num3)
				{
					throw new Exception("invalid patch file (corrupt)");
				}
				num8 = 0;
				for (int k = num6; k < num6 + array7[0]; k += 65536)
				{
					num8 += stream2.Read(array6, k, Math.Min(65536, num6 + array7[0] - k));
					this.method_2(num3 + (long)num6 + (long)num8, long_);
				}
				if (num8 < array7[0])
				{
					throw new Exception("invalid patch file (corrupt)");
				}
				for (int l = 0; l < array7[0]; l++)
				{
					if (num7 + l >= 0 && (long)(num7 + l) < num5)
					{
						byte[] expr_2EB_cp_0 = array6;
						int expr_2EB_cp_1 = num6 + l;
						expr_2EB_cp_0[expr_2EB_cp_1] += array5[num7 + l];
					}
				}
				num6 += array7[0];
				num7 += array7[0];
				if ((long)num6 > num3)
				{
					throw new Exception("invalid patch file (corrupt)");
				}
				num8 = stream3.Read(array6, num6, array7[1]);
				if (num8 < array7[1])
				{
					throw new Exception("invalid patch file (corrupt)");
				}
				num6 += array7[1];
				num7 += array7[2];
			}
			stream.Close();
			stream2.Close();
			stream3.Close();
			using (FileStream fileStream4 = File.Create(string_1))
			{
				for (int m = 0; m < array6.Length; m += num4)
				{
					fileStream4.Write(array6, m, Math.Min(num4, array6.Length - m));
					this.method_2(num3 * 2L + (long)m, long_);
				}
			}
			if (this.delegate3_0 != null)
			{
				this.delegate3_0(this, 1L, 1L);
			}
		}

		// Token: 0x06000F24 RID: 3876
		// RVA: 0x00052F48 File Offset: 0x00051148
		private void method_2(long long_0, long long_1)
		{
			int num = this.int_0;
			this.int_0 = (int)((float)long_0 / (float)long_1 * 100f);
			if (num != this.int_0 && this.delegate3_0 != null)
			{
				this.delegate3_0(this, long_0, long_1);
			}
		}

		// Token: 0x06000F22 RID: 3874
		// RVA: 0x00052A40 File Offset: 0x00050C40
		private static int smethod_0(byte[] byte_0, int int_1)
		{
			int num = (int)(byte_0[7 + int_1] & 127);
			num *= 256;
			num += (int)byte_0[6 + int_1];
			num *= 256;
			num += (int)byte_0[5 + int_1];
			num *= 256;
			num += (int)byte_0[4 + int_1];
			num *= 256;
			num += (int)byte_0[3 + int_1];
			num *= 256;
			num += (int)byte_0[2 + int_1];
			num *= 256;
			num += (int)byte_0[1 + int_1];
			num *= 256;
			num += (int)byte_0[int_1];
			if ((byte_0[7 + int_1] & 128) > 0)
			{
				num = -num;
			}
			return num;
		}

		// Token: 0x06000F25 RID: 3877
		// RVA: 0x00052F90 File Offset: 0x00051190
		private static bool smethod_1(byte[] byte_0, string string_0, int int_1, int int_2)
		{
			for (int i = int_1; i < int_1 + int_2; i++)
			{
				if ((char)byte_0[i] != string_0[i])
				{
					return false;
				}
			}
			return true;
		}
	}
}
