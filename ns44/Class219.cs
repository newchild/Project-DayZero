using System;

namespace ns44
{
	// Token: 0x020002A5 RID: 677
	internal sealed class Class219
	{
		// Token: 0x020002A7 RID: 679
		private sealed class Class220
		{
			// Token: 0x06001603 RID: 5635
			// RVA: 0x000714C8 File Offset: 0x0006F6C8
			public static Class219.Enum33 Compare(Class219 class219_0, Class219 class219_1)
			{
				uint num = class219_0.uint_0;
				uint num2 = class219_1.uint_0;
				while (num > 0u && class219_0.uint_1[(int)((UIntPtr)(num - 1u))] == 0u)
				{
					num -= 1u;
				}
				while (num2 > 0u && class219_1.uint_1[(int)((UIntPtr)(num2 - 1u))] == 0u)
				{
					num2 -= 1u;
				}
				if (num == 0u && num2 == 0u)
				{
					return Class219.Enum33.const_1;
				}
				if (num < num2)
				{
					return Class219.Enum33.const_0;
				}
				if (num > num2)
				{
					return Class219.Enum33.const_2;
				}
				uint num3;
				for (num3 = num - 1u; num3 != 0u; num3 -= 1u)
				{
					if (class219_0.uint_1[(int)((UIntPtr)num3)] != class219_1.uint_1[(int)((UIntPtr)num3)])
					{
						break;
					}
				}
				if (class219_0.uint_1[(int)((UIntPtr)num3)] < class219_1.uint_1[(int)((UIntPtr)num3)])
				{
					return Class219.Enum33.const_0;
				}
				if (class219_0.uint_1[(int)((UIntPtr)num3)] > class219_1.uint_1[(int)((UIntPtr)num3)])
				{
					return Class219.Enum33.const_2;
				}
				return Class219.Enum33.const_1;
			}

			// Token: 0x06001604 RID: 5636
			// RVA: 0x00071578 File Offset: 0x0006F778
			public static uint smethod_0(Class219 class219_0, uint uint_0)
			{
				ulong num = 0uL;
				uint uint_ = class219_0.uint_0;
				while (uint_-- > 0u)
				{
					num <<= 32;
					num |= (ulong)class219_0.uint_1[(int)((UIntPtr)uint_)];
					class219_0.uint_1[(int)((UIntPtr)uint_)] = (uint)(num / (ulong)uint_0);
					num %= (ulong)uint_0;
				}
				class219_0.method_0();
				return (uint)num;
			}
		}

		// Token: 0x020002A6 RID: 678
		public enum Enum33
		{
			// Token: 0x04001100 RID: 4352
			const_0 = -1,
			// Token: 0x04001101 RID: 4353
			const_1,
			// Token: 0x04001102 RID: 4354
			const_2
		}

		// Token: 0x040010FD RID: 4349
		private uint uint_0 = 1u;

		// Token: 0x040010FE RID: 4350
		private uint[] uint_1;

		// Token: 0x060015F4 RID: 5620
		// RVA: 0x000137AC File Offset: 0x000119AC
		public Class219(uint[] uint_2)
		{
			this.uint_1 = uint_2;
			this.uint_0 = (uint)this.uint_1.Length;
			this.method_0();
		}

		// Token: 0x060015F5 RID: 5621
		// RVA: 0x000137D6 File Offset: 0x000119D6
		public Class219(Class219 class219_0)
		{
			this.uint_1 = (uint[])class219_0.uint_1.Clone();
			this.uint_0 = class219_0.uint_0;
		}

		// Token: 0x060015F6 RID: 5622
		// RVA: 0x00071270 File Offset: 0x0006F470
		public Class219(byte[] byte_0)
		{
			this.uint_0 = (uint)byte_0.Length >> 2;
			int num = byte_0.Length & 3;
			if (num != 0)
			{
				this.uint_0 += 1u;
			}
			this.uint_1 = new uint[this.uint_0];
			int i = byte_0.Length - 1;
			int num2 = 0;
			while (i >= 3)
			{
				this.uint_1[num2] = (uint)((int)byte_0[i - 3] << 24 | (int)byte_0[i - 2] << 16 | (int)byte_0[i - 1] << 8 | (int)byte_0[i]);
				i -= 4;
				num2++;
			}
			switch (num)
			{
			case 1:
				this.uint_1[(int)((UIntPtr)(this.uint_0 - 1u))] = (uint)byte_0[0];
				break;
			case 2:
				this.uint_1[(int)((UIntPtr)(this.uint_0 - 1u))] = (uint)((int)byte_0[0] << 8 | (int)byte_0[1]);
				break;
			case 3:
				this.uint_1[(int)((UIntPtr)(this.uint_0 - 1u))] = (uint)((int)byte_0[0] << 16 | (int)byte_0[1] << 8 | (int)byte_0[2]);
				break;
			}
			this.method_0();
		}

		// Token: 0x060015FB RID: 5627
		// RVA: 0x0001388A File Offset: 0x00011A8A
		public Class219.Enum33 Compare(Class219 class219_0)
		{
			return Class219.Class220.Compare(this, class219_0);
		}

		// Token: 0x06001601 RID: 5633
		// RVA: 0x000138AB File Offset: 0x00011AAB
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (obj is int)
			{
				return (int)obj >= 0 && Class219.smethod_0(this, (uint)obj);
			}
			return Class219.Class220.Compare(this, (Class219)obj) == Class219.Enum33.const_1;
		}

		// Token: 0x060015FF RID: 5631
		// RVA: 0x00071448 File Offset: 0x0006F648
		public override int GetHashCode()
		{
			uint num = 0u;
			for (uint num2 = 0u; num2 < this.uint_0; num2 += 1u)
			{
				num ^= this.uint_1[(int)((UIntPtr)num2)];
			}
			return (int)num;
		}

		// Token: 0x060015FE RID: 5630
		// RVA: 0x000713F8 File Offset: 0x0006F5F8
		private void method_0()
		{
			while (this.uint_0 > 0u && this.uint_1[(int)((UIntPtr)(this.uint_0 - 1u))] == 0u)
			{
				this.uint_0 -= 1u;
			}
			if (this.uint_0 == 0u)
			{
				this.uint_0 += 1u;
			}
		}

		// Token: 0x06001602 RID: 5634
		// RVA: 0x00071478 File Offset: 0x0006F678
		internal Class219 method_1(Class219 class219_0)
		{
			int num = Math.Min(this.uint_1.Length, class219_0.uint_1.Length);
			uint[] array = new uint[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = (this.uint_1[i] ^ class219_0.uint_1[i]);
			}
			return new Class219(array);
		}

		// Token: 0x060015F7 RID: 5623
		// RVA: 0x00013807 File Offset: 0x00011A07
		public static bool smethod_0(Class219 class219_0, uint uint_2)
		{
			if (class219_0.uint_0 != 1u)
			{
				class219_0.method_0();
			}
			return class219_0.uint_0 == 1u && class219_0.uint_1[0] == uint_2;
		}

		// Token: 0x060015F8 RID: 5624
		// RVA: 0x0001382E File Offset: 0x00011A2E
		public static bool smethod_1(Class219 class219_0, uint uint_2)
		{
			if (class219_0.uint_0 != 1u)
			{
				class219_0.method_0();
			}
			return class219_0.uint_0 != 1u || class219_0.uint_1[0] != uint_2;
		}

		// Token: 0x060015F9 RID: 5625
		// RVA: 0x00013858 File Offset: 0x00011A58
		public static bool smethod_2(Class219 class219_0, Class219 class219_1)
		{
			return class219_0 == class219_1 || (!Class219.smethod_2(null, class219_0) && !Class219.smethod_2(null, class219_1) && Class219.Class220.Compare(class219_0, class219_1) == Class219.Enum33.const_1);
		}

		// Token: 0x060015FA RID: 5626
		// RVA: 0x0001387E File Offset: 0x00011A7E
		public static bool smethod_3(Class219 class219_0, Class219 class219_1)
		{
			return Class219.Class220.Compare(class219_0, class219_1) < Class219.Enum33.const_1;
		}

		// Token: 0x06001600 RID: 5632
		// RVA: 0x000138A1 File Offset: 0x00011AA1
		public override string ToString()
		{
			return this.ToString(10u);
		}

		// Token: 0x060015FC RID: 5628
		// RVA: 0x00013893 File Offset: 0x00011A93
		public string ToString(uint uint_2)
		{
			return this.ToString(uint_2, "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ");
		}

		// Token: 0x060015FD RID: 5629
		// RVA: 0x00071368 File Offset: 0x0006F568
		public string ToString(uint uint_2, string string_0)
		{
			if ((long)string_0.Length < (long)((ulong)uint_2))
			{
				throw new ArgumentException("charSet length less than radix", "characterSet");
			}
			if (uint_2 == 1u)
			{
				throw new ArgumentException("There is no such thing as radix one notation", "radix");
			}
			if (Class219.smethod_0(this, 0u))
			{
				return "0";
			}
			if (Class219.smethod_0(this, 1u))
			{
				return "1";
			}
			string text = "";
			Class219 class219_ = new Class219(this);
			while (Class219.smethod_1(class219_, 0u))
			{
				uint index = Class219.Class220.smethod_0(class219_, uint_2);
				text = string_0[(int)index] + text;
			}
			return text;
		}
	}
}
