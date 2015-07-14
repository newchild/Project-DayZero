using System;

namespace ns47
{
	// Token: 0x020002B4 RID: 692
	internal sealed class Class233 : Class230, IComparable<Class233>
	{
		// Token: 0x04001129 RID: 4393
		internal long long_0;

		// Token: 0x0600166C RID: 5740
		// RVA: 0x00013DED File Offset: 0x00011FED
		public int CompareTo(object object_0)
		{
			if (!(object_0 is Class233) && !(object_0 is long) && !(object_0 is int))
			{
				return -1;
			}
			return this.CompareTo((Class233)object_0);
		}

		// Token: 0x0600166D RID: 5741
		// RVA: 0x00013E15 File Offset: 0x00012015
		public int CompareTo(Class233 obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("other");
			}
			return this.long_0.CompareTo(obj.long_0);
		}

		// Token: 0x0600166E RID: 5742
		// RVA: 0x00013E36 File Offset: 0x00012036
		public int CompareTo(long long_1)
		{
			return this.long_0.CompareTo(long_1);
		}

		// Token: 0x0600166A RID: 5738
		// RVA: 0x00071D3C File Offset: 0x0006FF3C
		public override int Encode(byte[] byte_0, int int_0)
		{
			long num = this.long_0;
			int num2 = int_0 + 1;
			byte_0[int_0] = 105;
			if (num < 0L)
			{
				byte_0[num2++] = 45;
				num = -num;
			}
			long num3 = 0L;
			for (long num4 = num; num4 != 0L; num4 /= 10L)
			{
				num3 = num3 * 10L + num4 % 10L;
			}
			for (long num5 = num3; num5 != 0L; num5 /= 10L)
			{
				byte_0[num2++] = (byte)(num5 % 10L + 48L);
			}
			if (num == 0L)
			{
				byte_0[num2++] = 48;
			}
			long num6 = num;
			while (num6 % 10L == 0L)
			{
				if (num == 0L)
				{
					break;
				}
				byte_0[num2++] = 48;
				num6 /= 10L;
			}
			byte_0[num2++] = 101;
			return num2 - int_0;
		}

		// Token: 0x0600166F RID: 5743
		// RVA: 0x00071EB0 File Offset: 0x000700B0
		public override bool Equals(object obj)
		{
			Class233 class = obj as Class233;
			return class != null && this.long_0 == class.long_0;
		}

		// Token: 0x06001670 RID: 5744
		// RVA: 0x00013E44 File Offset: 0x00012044
		public override int GetHashCode()
		{
			return this.long_0.GetHashCode();
		}

		// Token: 0x06001671 RID: 5745
		// RVA: 0x00013E51 File Offset: 0x00012051
		public override string ToString()
		{
			return this.long_0.ToString();
		}

		// Token: 0x0600166B RID: 5739
		// RVA: 0x00071E54 File Offset: 0x00070054
		public override int vmethod_0()
		{
			long num = this.long_0;
			int num2 = 2;
			if (num == 0L)
			{
				return num2 + 1;
			}
			if (num < 0L)
			{
				num = -num;
				num2++;
			}
			for (long num3 = num; num3 != 0L; num3 /= 10L)
			{
				num2++;
			}
			return num2;
		}
	}
}
