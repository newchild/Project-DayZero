using System;

namespace ns8
{
	// Token: 0x02000192 RID: 402
	internal sealed class Class29
	{
		// Token: 0x040006FB RID: 1787
		public Enum4 enum4_0 = Enum4.const_3;

		// Token: 0x040006FA RID: 1786
		private uint[] uint_0;

		// Token: 0x040006FC RID: 1788
		private uint uint_1;

		// Token: 0x06000E6A RID: 3690
		// RVA: 0x0000ED31 File Offset: 0x0000CF31
		public void method_0(uint[] uint_2, Enum4 enum4_1)
		{
			if (enum4_1 == Enum4.const_3)
			{
				throw new ArgumentException("Encryption method can't be none");
			}
			if (uint_2.Length != 4)
			{
				throw new ArgumentException("Encryption key has to be 4 words long");
			}
			this.uint_0 = uint_2;
			this.enum4_0 = enum4_1;
		}

		// Token: 0x06000E6B RID: 3691
		// RVA: 0x0000ED61 File Offset: 0x0000CF61
		private void method_1()
		{
			if (this.enum4_0 == Enum4.const_3)
			{
				new ArgumentException("Encryption method has to be set first");
			}
		}

		// Token: 0x06000E74 RID: 3700
		// RVA: 0x0004EB48 File Offset: 0x0004CD48
		private unsafe void method_10(uint* pUint_0, uint* pUint_1)
		{
			uint num = *pUint_0;
			uint num2 = pUint_0[1];
			uint num3 = 0u;
			for (uint num4 = 0u; num4 < 32u; num4 += 1u)
			{
				num += ((num2 << 4 ^ num2 >> 5) + num2 ^ num3 + this.uint_0[(int)((UIntPtr)(num3 & 3u))]);
				num3 += 2654435769u;
				num2 += ((num << 4 ^ num >> 5) + num ^ num3 + this.uint_0[(int)((UIntPtr)(num3 >> 11 & 3u))]);
			}
			*pUint_1 = num;
			pUint_1[1] = num2;
		}

		// Token: 0x06000E75 RID: 3701
		// RVA: 0x0004EBB8 File Offset: 0x0004CDB8
		private unsafe void method_11(uint* pUint_0, uint* pUint_1)
		{
			uint num = *pUint_0;
			uint num2 = pUint_0[1];
			uint num3 = 3337565984u;
			for (uint num4 = 0u; num4 < 32u; num4 += 1u)
			{
				num2 -= ((num << 4 ^ num >> 5) + num ^ num3 + this.uint_0[(int)((UIntPtr)(num3 >> 11 & 3u))]);
				num3 -= 2654435769u;
				num -= ((num2 << 4 ^ num2 >> 5) + num2 ^ num3 + this.uint_0[(int)((UIntPtr)(num3 & 3u))]);
			}
			*pUint_1 = num;
			pUint_1[1] = num2;
		}

		// Token: 0x06000E76 RID: 3702
		// RVA: 0x0004EC2C File Offset: 0x0004CE2C
		private unsafe void method_12(uint* pUint_0)
		{
			uint num = 6u + 52u / this.uint_1;
			uint num2 = 0u;
			uint num3 = pUint_0[this.uint_1 - 1u];
			do
			{
				num2 += 2654435769u;
				uint num4 = num2 >> 2 & 3u;
				uint num5;
				uint num6;
				for (num5 = 0u; num5 < this.uint_1 - 1u; num5 += 1u)
				{
					num6 = pUint_0[num5 + 1u];
					num3 = (pUint_0[num5] += ((num3 >> 5 ^ num6 << 2) + (num6 >> 3 ^ num3 << 4) ^ (num2 ^ num6) + (this.uint_0[(int)((UIntPtr)((num5 & 3u) ^ num4))] ^ num3)));
				}
				num6 = *pUint_0;
				num3 = (pUint_0[this.uint_1 - 1u] += ((num3 >> 5 ^ num6 << 2) + (num6 >> 3 ^ num3 << 4) ^ (num2 ^ num6) + (this.uint_0[(int)((UIntPtr)((num5 & 3u) ^ num4))] ^ num3)));
			}
			while ((num -= 1u) > 0u);
		}

		// Token: 0x06000E77 RID: 3703
		// RVA: 0x0004ED04 File Offset: 0x0004CF04
		private unsafe void method_13(uint* pUint_0)
		{
			uint num = 6u + 52u / this.uint_1;
			uint num2 = num * 2654435769u;
			uint num3 = *pUint_0;
			do
			{
				uint num4 = num2 >> 2 & 3u;
				uint num5;
				uint num6;
				for (num5 = this.uint_1 - 1u; num5 > 0u; num5 -= 1u)
				{
					num6 = pUint_0[num5 - 1u];
					num3 = (pUint_0[num5] -= ((num6 >> 5 ^ num3 << 2) + (num3 >> 3 ^ num6 << 4) ^ (num2 ^ num3) + (this.uint_0[(int)((UIntPtr)((num5 & 3u) ^ num4))] ^ num6)));
				}
				num6 = pUint_0[this.uint_1 - 1u];
				num3 = (*pUint_0 -= ((num6 >> 5 ^ num3 << 2) + (num3 >> 3 ^ num6 << 4) ^ (num2 ^ num3) + (this.uint_0[(int)((UIntPtr)((num5 & 3u) ^ num4))] ^ num6)));
			}
			while ((num2 -= 2654435769u) != 0u);
		}

		// Token: 0x06000E78 RID: 3704
		// RVA: 0x0004EDD0 File Offset: 0x0004CFD0
		private unsafe void method_14(byte* pByte_0, int int_0)
		{
			uint[] array;
			uint* ptr;
			if ((array = this.uint_0) != null && array.Length != 0)
			{
				fixed (uint* ptr = &array[0])
				{
				}
			}
			else
			{
				ptr = null;
			}
			byte* ptr2 = (byte*)ptr;
			byte b = 0;
			for (int i = 0; i < int_0; i++)
			{
				pByte_0[i] = (byte)(((int)pByte_0[i] + (ptr2[i % 16] >> 2)) % 256);
				byte* expr_44 = pByte_0 + i;
				*expr_44 ^= Class29.smethod_0(ptr2[15 - i % 16], (byte)(((int)b + int_0 - i) % 7));
				pByte_0[i] = Class29.smethod_1(pByte_0[i], ~b % 7);
				b = pByte_0[i];
			}
			ptr = null;
		}

		// Token: 0x06000E79 RID: 3705
		// RVA: 0x0004EE60 File Offset: 0x0004D060
		private unsafe void method_15(byte* pByte_0, int int_0)
		{
			uint[] array;
			uint* ptr;
			if ((array = this.uint_0) != null && array.Length != 0)
			{
				fixed (uint* ptr = &array[0])
				{
				}
			}
			else
			{
				ptr = null;
			}
			byte* ptr2 = (byte*)ptr;
			byte b = 0;
			for (int i = 0; i < int_0; i++)
			{
				byte b2 = pByte_0[i];
				pByte_0[i] = Class29.smethod_0(pByte_0[i], ~b % 7);
				byte* expr_43 = pByte_0 + i;
				*expr_43 ^= Class29.smethod_0(ptr2[15 - i % 16], (byte)(((int)b + int_0 - i) % 7));
				pByte_0[i] = (byte)(((int)pByte_0[i] - (ptr2[i % 16] >> 2)) % 256);
				b = b2;
			}
			ptr = null;
		}

		// Token: 0x06000E6C RID: 3692
		// RVA: 0x0004E7F4 File Offset: 0x0004C9F4
		private unsafe void method_2(byte* pByte_0, int int_0, bool bool_0)
		{
			uint num = (uint)(int_0 / 64);
			uint num2 = (uint)(int_0 % 64);
			uint* ptr = (uint*)pByte_0;
			uint num3 = 16u;
			this.uint_1 = 16u;
			uint num4 = 6u + 52u / this.uint_1;
			if (bool_0)
			{
				for (uint num5 = 0u; num5 < num; num5 += 1u)
				{
					this.method_12(ptr);
					ptr += 16;
				}
			}
			else
			{
				for (uint num6 = 0u; num6 < num; num6 += 1u)
				{
					uint num7 = num4 * 2654435769u;
					uint num8 = *ptr;
					do
					{
						uint num9 = num7 >> 2 & 3u;
						uint num10;
						uint num11;
						for (num10 = num3 - 1u; num10 > 0u; num10 -= 1u)
						{
							num11 = ptr[num10 - 1u];
							num8 = (ptr[num10] -= ((num11 >> 5 ^ num8 << 2) + (num8 >> 3 ^ num11 << 4) ^ (num7 ^ num8) + (this.uint_0[(int)((UIntPtr)((num10 & 3u) ^ num9))] ^ num11)));
						}
						num11 = ptr[num3 - 1u];
						num8 = (*ptr -= ((num11 >> 5 ^ num8 << 2) + (num8 >> 3 ^ num11 << 4) ^ (num7 ^ num8) + (this.uint_0[(int)((UIntPtr)((num10 & 3u) ^ num9))] ^ num11)));
					}
					while ((num7 -= 2654435769u) != 0u);
					ptr += 16;
				}
			}
			if (num2 == 0u)
			{
				return;
			}
			this.uint_1 = num2 / 4u;
			if (this.uint_1 > 1u)
			{
				if (bool_0)
				{
					this.method_12(ptr);
				}
				else
				{
					this.method_13(ptr);
				}
				num2 -= this.uint_1 * 4u;
				if (num2 == 0u)
				{
					return;
				}
			}
			byte* pByte_ = pByte_0 + ((long)int_0 - (long)((ulong)num2));
			if (bool_0)
			{
				this.method_14(pByte_, (int)num2);
				return;
			}
			this.method_15(pByte_, (int)num2);
		}

		// Token: 0x06000E6D RID: 3693
		// RVA: 0x0004E98C File Offset: 0x0004CB8C
		private unsafe void method_3(byte* pByte_0, byte* pByte_1, int int_0, bool bool_0)
		{
			uint num = (uint)(int_0 / 8);
			uint num2 = (uint)(int_0 % 8);
			uint* ptr = (uint*)(pByte_0 - 8);
			uint* ptr2 = (uint*)(pByte_1 - 8);
			if (bool_0)
			{
				int num3 = 0;
				while ((long)num3 < (long)((ulong)num))
				{
					this.method_10(ptr += 2, ptr2 += 2);
					num3++;
				}
			}
			else
			{
				int num4 = 0;
				while ((long)num4 < (long)((ulong)num))
				{
					this.method_11(ptr += 2, ptr2 += 2);
					num4++;
				}
			}
			if (num2 == 0u)
			{
				return;
			}
			byte* ptr3 = pByte_0 + int_0;
			byte* ptr4 = ptr3 - num2;
			byte* ptr5 = pByte_1 + int_0 - num2;
			do
			{
				ptr5 = ptr4++;
				ptr5++;
			}
			while (ptr4 != ptr3);
			if (bool_0)
			{
				this.method_14(ptr5 - num2, (int)num2);
				return;
			}
			this.method_15(ptr5 - num2, (int)num2);
		}

		// Token: 0x06000E6E RID: 3694
		// RVA: 0x0000ED77 File Offset: 0x0000CF77
		private unsafe void method_4(byte* pByte_0, int int_0, bool bool_0)
		{
			if (bool_0)
			{
				this.method_14(pByte_0, int_0);
				return;
			}
			this.method_15(pByte_0, int_0);
		}

		// Token: 0x06000E6F RID: 3695
		// RVA: 0x0004EA48 File Offset: 0x0004CC48
		private unsafe void method_5(byte* pByte_0, int int_0, bool bool_0)
		{
			switch (this.enum4_0)
			{
			case Enum4.const_0:
				this.method_6(pByte_0, pByte_0, int_0, bool_0);
				return;
			case Enum4.const_1:
				this.method_2(pByte_0, int_0, bool_0);
				return;
			case Enum4.const_2:
				this.method_4(pByte_0, int_0, bool_0);
				return;
			case Enum4.const_3:
				this.method_1();
				return;
			default:
				return;
			}
		}

		// Token: 0x06000E70 RID: 3696
		// RVA: 0x0004EA98 File Offset: 0x0004CC98
		private unsafe void method_6(byte* pByte_0, byte* pByte_1, int int_0, bool bool_0)
		{
			switch (this.enum4_0)
			{
			case Enum4.const_0:
				this.method_3(pByte_0, pByte_1, int_0, bool_0);
				return;
			case Enum4.const_1:
			case Enum4.const_2:
				throw new NotSupportedException();
			case Enum4.const_3:
				this.method_1();
				return;
			default:
				return;
			}
		}

		// Token: 0x06000E71 RID: 3697
		// RVA: 0x0004EADC File Offset: 0x0004CCDC
		public unsafe void method_7(byte[] byte_0, byte[] byte_1, int int_0, int int_1, int int_2, bool bool_0)
		{
			byte* ptr;
			if (byte_0 != null && byte_0.Length != 0)
			{
				fixed (byte* ptr = &byte_0[0])
				{
				}
			}
			else
			{
				ptr = null;
			}
			byte* ptr2;
			if (byte_1 != null && byte_1.Length != 0)
			{
				fixed (byte* ptr2 = &byte_1[0])
				{
				}
			}
			else
			{
				ptr2 = null;
			}
			if (ptr2 == null)
			{
				this.method_5(ptr + int_0, int_2, bool_0);
			}
			else
			{
				this.method_6(ptr + int_0, ptr2 + int_1, int_2, bool_0);
			}
			ptr = null;
			ptr2 = null;
		}

		// Token: 0x06000E72 RID: 3698
		// RVA: 0x0000ED8D File Offset: 0x0000CF8D
		public void method_8(byte[] byte_0, int int_0, int int_1)
		{
			this.method_7(byte_0, null, int_0, 0, int_1, false);
		}

		// Token: 0x06000E73 RID: 3699
		// RVA: 0x0000ED9B File Offset: 0x0000CF9B
		public void method_9(byte[] byte_0, int int_0, int int_1)
		{
			this.method_7(byte_0, null, int_0, 0, int_1, true);
		}

		// Token: 0x06000E7A RID: 3706
		// RVA: 0x0000EDA9 File Offset: 0x0000CFA9
		private static byte smethod_0(byte byte_0, byte byte_1)
		{
			return (byte)((int)byte_0 << (int)byte_1 | byte_0 >> (int)(8 - byte_1));
		}

		// Token: 0x06000E7B RID: 3707
		// RVA: 0x0000EDBB File Offset: 0x0000CFBB
		private static byte smethod_1(byte byte_0, byte byte_1)
		{
			return (byte)(byte_0 >> (int)byte_1 | (int)byte_0 << (int)(8 - byte_1));
		}
	}
}
