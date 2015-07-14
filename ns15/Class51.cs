using ns32;
using ns33;
using System;
using System.IO;
using System.Text;
using System.Threading;

namespace ns15
{
	// Token: 0x020001AE RID: 430
	internal sealed class Class51
	{
		// Token: 0x04000BC5 RID: 3013
		private Delegate3 delegate3_0;

		// Token: 0x04000BC6 RID: 3014
		private int int_0;

		// Token: 0x06000F12 RID: 3858
		// RVA: 0x00051C5C File Offset: 0x0004FE5C
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

		// Token: 0x06000F13 RID: 3859
		// RVA: 0x00051C94 File Offset: 0x0004FE94
		private void method_1(int[] int_1, int[] int_2, int int_3, int int_4, int int_5)
		{
			int i;
			int num;
			int num2;
			int j;
			if (int_4 < 16)
			{
				for (i = int_3; i < int_3 + int_4; i += num)
				{
					num = 1;
					num2 = int_2[int_1[i] + int_5];
					j = 1;
					while (i + j < int_3 + int_4)
					{
						if (int_2[int_1[i + j] + int_5] < num2)
						{
							num2 = int_2[int_1[i + j] + int_5];
							num = 0;
						}
						if (int_2[int_1[i + j] + int_5] == num2)
						{
							int num3 = int_1[i + num];
							int_1[i + num] = int_1[i + j];
							int_1[i + j] = num3;
							num++;
						}
						j++;
					}
					for (j = 0; j < num; j++)
					{
						int_2[int_1[i + j]] = i + num - 1;
					}
					if (num == 1)
					{
						int_1[i] = -1;
					}
				}
				return;
			}
			num2 = int_2[int_1[int_3 + int_4 / 2] + int_5];
			int num4 = 0;
			int num5 = 0;
			for (j = int_3; j < int_3 + int_4; j++)
			{
				if (int_2[int_1[j] + int_5] < num2)
				{
					num4++;
				}
				if (int_2[int_1[j] + int_5] == num2)
				{
					num5++;
				}
			}
			num4 += int_3;
			num5 += num4;
			j = int_3;
			num = 0;
			i = 0;
			while (j < num4)
			{
				if (int_2[int_1[j] + int_5] < num2)
				{
					j++;
				}
				else if (int_2[int_1[j] + int_5] == num2)
				{
					int num6 = int_1[j];
					int_1[j] = int_1[num4 + num];
					int_1[num4 + num] = num6;
					num++;
				}
				else
				{
					int num7 = int_1[j];
					int_1[j] = int_1[num5 + i];
					int_1[num5 + i] = num7;
					i++;
				}
			}
			while (num4 + num < num5)
			{
				if (int_2[int_1[num4 + num] + int_5] == num2)
				{
					num++;
				}
				else
				{
					int num8 = int_1[num4 + num];
					int_1[num4 + num] = int_1[num5 + i];
					int_1[num5 + i] = num8;
					i++;
				}
			}
			if (num4 > int_3)
			{
				this.method_1(int_1, int_2, int_3, num4 - int_3, int_5);
			}
			for (j = 0; j < num5 - num4; j++)
			{
				int_2[int_1[num4 + j]] = num5 - 1;
			}
			if (num4 == num5 - 1)
			{
				int_1[num4] = -1;
			}
			if (int_3 + int_4 > num5)
			{
				this.method_1(int_1, int_2, num5, int_3 + int_4 - num5, int_5);
			}
		}

		// Token: 0x06000F14 RID: 3860
		// RVA: 0x00051E88 File Offset: 0x00050088
		private void method_2(int[] int_1, int[] int_2, byte[] byte_0, int int_3)
		{
			int[] array = new int[256];
			for (int i = 0; i < int_3; i++)
			{
				array[(int)byte_0[i]]++;
			}
			for (int j = 1; j < 256; j++)
			{
				array[j] += array[j - 1];
			}
			for (int k = 255; k > 0; k--)
			{
				array[k] = array[k - 1];
			}
			array[0] = 0;
			for (int l = 0; l < int_3; l++)
			{
				int_1[++array[(int)byte_0[l]]] = l;
			}
			int_1[0] = int_3;
			for (int m = 0; m < int_3; m++)
			{
				int_2[m] = array[(int)byte_0[m]];
			}
			int_2[int_3] = 0;
			for (int n = 1; n < 256; n++)
			{
				if (array[n] == array[n - 1] + 1)
				{
					int_1[array[n]] = -1;
				}
			}
			int_1[0] = -1;
			int num = 1;
			while (int_1[0] != -(int_3 + 1))
			{
				int num2 = 0;
				int num3 = 0;
				while (num3 < int_3 + 1)
				{
					this.method_7((long)num3, (long)int_3);
					if (int_1[num3] < 0)
					{
						num2 -= int_1[num3];
						num3 -= int_1[num3];
					}
					else
					{
						if (num2 != 0)
						{
							int_1[num3 - num2] = -num2;
						}
						num2 = int_2[int_1[num3]] + 1 - num3;
						this.method_1(int_1, int_2, num3, num2, num);
						num3 += num2;
						num2 = 0;
					}
				}
				if (num2 != 0)
				{
					int_1[num3 - num2] = -num2;
				}
				num += num;
			}
			for (int num4 = 0; num4 < int_3 + 1; num4++)
			{
				int_1[int_2[num4]] = num4;
			}
		}

		// Token: 0x06000F16 RID: 3862
		// RVA: 0x0005206C File Offset: 0x0005026C
		private int method_3(int[] int_1, byte[] byte_0, int int_2, byte[] byte_1, int int_3, int int_4, int int_5, int int_6, ref int int_7)
		{
			if (int_6 - int_5 < 2)
			{
				int num = Class51.smethod_0(byte_0, int_1[int_5], int_2, byte_1, int_3, int_4);
				int num2 = Class51.smethod_0(byte_0, int_1[int_6], int_2, byte_1, int_3, int_4);
				if (num > num2)
				{
					int_7 = int_1[int_5];
					return num;
				}
				int_7 = int_1[int_6];
				return num2;
			}
			else
			{
				int num = int_5 + (int_6 - int_5) / 2;
				int num3 = Class51.smethod_1(byte_0, int_1[num], byte_1, int_3, Math.Min(int_2 - int_1[num], int_4 - int_3));
				if (num3 < 0)
				{
					return this.method_3(int_1, byte_0, int_2, byte_1, int_3, int_4, num, int_6, ref int_7);
				}
				return this.method_3(int_1, byte_0, int_2, byte_1, int_3, int_4, int_5, num, ref int_7);
			}
		}

		// Token: 0x06000F17 RID: 3863
		// RVA: 0x00052110 File Offset: 0x00050310
		private void method_4(int int_1, byte[] byte_0)
		{
			int num;
			if (int_1 < 0)
			{
				num = -int_1;
			}
			else
			{
				num = int_1;
			}
			for (int i = 0; i < 7; i++)
			{
				byte_0[i] = (byte)(num % 256);
				num -= (int)byte_0[i];
				num /= 256;
			}
			byte_0[7] = (byte)(num % 256);
			if (int_1 < 0)
			{
				int expr_46_cp_1 = 7;
				byte_0[expr_46_cp_1] |= 128;
			}
		}

		// Token: 0x06000F19 RID: 3865
		// RVA: 0x000521A4 File Offset: 0x000503A4
		private Stream method_5(Enum7 enum7_0, Stream stream_0)
		{
			switch (enum7_0)
			{
			case Enum7.const_0:
				return new Stream4(stream_0, Enum12.const_0, Enum11.const_0, true);
			case Enum7.const_1:
				return new Stream2(stream_0);
			default:
				return null;
			}
		}

		// Token: 0x06000F1A RID: 3866
		// RVA: 0x000521D4 File Offset: 0x000503D4
		public void method_6(string string_0, string string_1, Stream stream_0, Enum7 enum7_0)
		{
			int num = 0;
			int num2;
			byte[] array;
			int num3;
			using (FileStream fileStream = File.OpenRead(string_0))
			{
				num2 = (int)fileStream.Length;
				array = new byte[num2];
				num3 = num2 * 9;
				for (int i = 0; i < num2; i += 65536)
				{
					fileStream.Read(array, i, Math.Min(65536, num2 - i));
					this.method_7((long)(num + i), (long)num3);
				}
				num = num2;
			}
			int[] int_ = new int[num2 + 1];
			int[] int_2 = new int[num2 + 1];
			this.method_2(int_, int_2, array, num2);
			int num4;
			byte[] array2;
			using (FileStream fileStream2 = File.OpenRead(string_1))
			{
				num4 = (int)fileStream2.Length;
				array2 = new byte[num4];
				num3 += num4 * 7 - num2 * 7;
				for (int j = 0; j < num4; j += 65536)
				{
					fileStream2.Read(array2, j, Math.Min(65536, num4 - j));
					this.method_7((long)(num + j), (long)num3);
				}
				num += num4;
			}
			byte[] array3 = new byte[num4 + 1];
			byte[] array4 = new byte[num4 + 1];
			int num5 = 0;
			int num6 = 0;
			using (BinaryWriter binaryWriter = new BinaryWriter(stream_0))
			{
				binaryWriter.Write(Encoding.ASCII.GetBytes("BSDIFF40"));
				binaryWriter.Write(0L);
				binaryWriter.Write(0L);
				binaryWriter.Write((long)num4);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (Stream stream = this.method_5(enum7_0, memoryStream))
					{
						int num7 = 0;
						int k = 0;
						int num8 = 0;
						int num9 = 0;
						int num10 = 0;
						int num11 = 0;
						while (k < num4)
						{
							int num12 = 0;
							int l;
							for (k = (l = k + num8); k < num4; k++)
							{
								num8 = this.method_3(int_, array, num2, array2, k, num4, 0, num2, ref num7);
								while (l < k + num8)
								{
									if (l + num11 < num2 && array[l + num11] == array2[l])
									{
										num12++;
									}
									l++;
								}
								if ((num8 == num12 && num8 != 0) || num8 > num12 + 8)
								{
									break;
								}
								if (k + num11 < num2 && array[k + num11] == array2[k])
								{
									num12--;
								}
							}
							if (num8 != num12 || k == num4)
							{
								int num13 = 0;
								int num14 = 0;
								int num15 = 0;
								int num16 = 0;
								int num17 = 0;
								int num18 = 0;
								int num19 = 0;
								int num20 = 0;
								while (num9 + num20 < k && num10 + num20 < num2)
								{
									if (array[num10 + num20] == array2[num9 + num20])
									{
										num13++;
									}
									num20++;
									if (num13 * 2 - num20 > num14 * 2 - num15)
									{
										num14 = num13;
										num15 = num20;
									}
								}
								if (k < num4)
								{
									num13 = 0;
									int num21 = 1;
									while (k >= num9 + num21 && num7 >= num21)
									{
										if (array[num7 - num21] == array2[k - num21])
										{
											num13++;
										}
										if (num13 * 2 - num21 > num16 * 2 - num17)
										{
											num16 = num13;
											num17 = num21;
										}
										num21++;
									}
								}
								if (num9 + num15 > k - num17)
								{
									int num22 = num9 + num15 - (k - num17);
									num13 = 0;
									for (int m = 0; m < num22; m++)
									{
										if (array2[num9 + num15 - num22 + m] == array[num10 + num15 - num22 + m])
										{
											num13++;
										}
										if (array2[k - num17 + m] == array[num7 - num17 + m])
										{
											num13--;
										}
										if (num13 > num18)
										{
											num18 = num13;
											num19 = m + 1;
										}
									}
									num15 += num19 - num22;
									num17 -= num19;
								}
								for (int n = 0; n < num15; n++)
								{
									array3[num5 + n] = array2[num9 + n] - array[num10 + n];
								}
								for (int num23 = 0; num23 < k - num17 - (num9 + num15); num23++)
								{
									array4[num6 + num23] = array2[num9 + num15 + num23];
								}
								num5 += num15;
								num6 += k - num17 - (num9 + num15);
								byte[] array5 = new byte[8];
								this.method_4(num15, array5);
								stream.Write(array5, 0, 8);
								this.method_4(k - num17 - (num9 + num15), array5);
								stream.Write(array5, 0, 8);
								this.method_4(num7 - num17 - (num10 + num15), array5);
								stream.Write(array5, 0, 8);
								num9 = k - num17;
								num10 = num7 - num17;
								num11 = num7 - k;
							}
							this.method_7((long)(num + k), (long)num3);
						}
						num += num4;
					}
					byte[] array6 = memoryStream.ToArray();
					num3 += array6.Length - num4;
					for (int num24 = 0; num24 < array6.Length; num24 += 65536)
					{
						binaryWriter.Write(array6, num24, Math.Min(65536, array6.Length - num24));
						this.method_7((long)(num + num24), (long)num3);
					}
					num += array6.Length;
				}
				binaryWriter.Flush();
				long num25 = binaryWriter.BaseStream.Position - 32L;
				using (MemoryStream memoryStream2 = new MemoryStream())
				{
					using (Stream stream2 = this.method_5(enum7_0, memoryStream2))
					{
						num3 += num5 - num4;
						for (int num26 = 0; num26 < num5; num26 += 65536)
						{
							stream2.Write(array3, num26, Math.Min(65536, num5 - num26));
							this.method_7((long)(num + num26), (long)num3);
						}
						num += num5;
					}
					byte[] array7 = memoryStream2.ToArray();
					num3 += array7.Length - num4;
					for (int num27 = 0; num27 < array7.Length; num27 += 65536)
					{
						binaryWriter.Write(array7, num27, Math.Min(65536, array7.Length - num27));
						this.method_7((long)(num += num27), (long)num3);
					}
				}
				binaryWriter.Flush();
				long value = binaryWriter.BaseStream.Position - num25 - 32L;
				using (MemoryStream memoryStream3 = new MemoryStream())
				{
					using (Stream stream3 = this.method_5(enum7_0, memoryStream3))
					{
						num3 += num6 - num4;
						for (int num28 = 0; num28 < num6; num28 += 65536)
						{
							stream3.Write(array4, num28, Math.Min(65536, num6 - num28));
							this.method_7((long)(num + num28), (long)num3);
						}
						num += num6;
					}
					byte[] array8 = memoryStream3.ToArray();
					num3 += array8.Length - num4;
					for (int num29 = 0; num29 < array8.Length; num29 += 65536)
					{
						binaryWriter.Write(array8, num29, Math.Min(65536, array8.Length - num29));
						this.method_7((long)(num + num29), (long)num3);
					}
				}
				binaryWriter.Flush();
				binaryWriter.Seek(8, SeekOrigin.Begin);
				binaryWriter.Write(num25);
				binaryWriter.Write(value);
				if (this.delegate3_0 != null)
				{
					this.delegate3_0(this, 1L, 1L);
				}
			}
		}

		// Token: 0x06000F1B RID: 3867
		// RVA: 0x000529C0 File Offset: 0x00050BC0
		private void method_7(long long_0, long long_1)
		{
			int num = this.int_0;
			this.int_0 = (int)((float)long_0 / (float)long_1 * 100f);
			if (num != this.int_0 && this.delegate3_0 != null)
			{
				this.delegate3_0(this, long_0, long_1);
			}
		}

		// Token: 0x06000F15 RID: 3861
		// RVA: 0x00052038 File Offset: 0x00050238
		private static int smethod_0(byte[] byte_0, int int_1, int int_2, byte[] byte_1, int int_3, int int_4)
		{
			int num = 0;
			while (num < int_2 - int_1 && num < int_4 - int_3 && byte_0[num + int_1] == byte_1[num + int_3])
			{
				num++;
			}
			return num;
		}

		// Token: 0x06000F18 RID: 3864
		// RVA: 0x00052178 File Offset: 0x00050378
		private static int smethod_1(byte[] byte_0, int int_1, byte[] byte_1, int int_2, int int_3)
		{
			int num = 0;
			int num2 = 0;
			while (num2 < int_3 && num == 0)
			{
				num = (int)(byte_0[num2 + int_1] - byte_1[num2 + int_2]);
				num2++;
			}
			return num;
		}
	}
}
