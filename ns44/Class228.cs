using System;

namespace ns44
{
	// Token: 0x020002AF RID: 687
	internal sealed class Class228 : IComparable, IComparable<Class228>, IEquatable<Class228>
	{
		// Token: 0x04001121 RID: 4385
		private byte[] byte_0;

		// Token: 0x04001120 RID: 4384
		private Class219 class219_0;

		// Token: 0x0400111F RID: 4383
		private static readonly Random random_0 = new Random();

		// Token: 0x0600162A RID: 5674
		// RVA: 0x00013A5D File Offset: 0x00011C5D
		internal Class228(byte[] byte_1) : this(new Class219(byte_1))
		{
			this.byte_0 = byte_1;
		}

		// Token: 0x0600162B RID: 5675
		// RVA: 0x00013A72 File Offset: 0x00011C72
		private Class228(Class219 class219_1)
		{
			this.class219_0 = class219_1;
		}

		// Token: 0x06001630 RID: 5680
		// RVA: 0x00013AC1 File Offset: 0x00011CC1
		public int CompareTo(object target)
		{
			return this.CompareTo(target as Class228);
		}

		// Token: 0x06001631 RID: 5681
		// RVA: 0x000719B4 File Offset: 0x0006FBB4
		public int CompareTo(Class228 obj)
		{
			if (obj == null)
			{
				return 1;
			}
			Class219.Enum33 enum = this.class219_0.Compare(obj.class219_0);
			if (enum == Class219.Enum33.const_1)
			{
				return 0;
			}
			if (enum == Class219.Enum33.const_2)
			{
				return 1;
			}
			return -1;
		}

		// Token: 0x0600162C RID: 5676
		// RVA: 0x00013A81 File Offset: 0x00011C81
		public override bool Equals(object obj)
		{
			return this.Equals(obj as Class228);
		}

		// Token: 0x0600162D RID: 5677
		// RVA: 0x00013A8F File Offset: 0x00011C8F
		public bool Equals(Class228 other)
		{
			return other != null && this.class219_0.Equals(other.class219_0);
		}

		// Token: 0x0600162E RID: 5678
		// RVA: 0x00013AA7 File Offset: 0x00011CA7
		public override int GetHashCode()
		{
			return this.class219_0.GetHashCode();
		}

		// Token: 0x06001629 RID: 5673
		// RVA: 0x00013A55 File Offset: 0x00011C55
		internal byte[] method_0()
		{
			return this.byte_0;
		}

		// Token: 0x06001632 RID: 5682
		// RVA: 0x00013ACF File Offset: 0x00011CCF
		internal Class228 method_1(Class228 class228_0)
		{
			return new Class228(this.class219_0.method_1(class228_0.class219_0));
		}

		// Token: 0x06001633 RID: 5683
		// RVA: 0x00013AE7 File Offset: 0x00011CE7
		public static bool smethod_0(Class228 class228_0, Class228 class228_1)
		{
			Class228.smethod_1(class228_0, class228_1);
			return Class219.smethod_3(class228_0.class219_0, class228_1.class219_0);
		}

		// Token: 0x06001634 RID: 5684
		// RVA: 0x00013B01 File Offset: 0x00011D01
		private static void smethod_1(Class228 class228_0, Class228 class228_1)
		{
			if (Class228.smethod_2(class228_0, null))
			{
				throw new ArgumentNullException("first");
			}
			if (Class228.smethod_2(class228_1, null))
			{
				throw new ArgumentNullException("second");
			}
		}

		// Token: 0x06001635 RID: 5685
		// RVA: 0x00013B2B File Offset: 0x00011D2B
		public static bool smethod_2(Class228 class228_0, Class228 class228_1)
		{
			if (class228_0 == null)
			{
				return class228_1 == null;
			}
			return class228_1 != null && Class219.smethod_2(class228_0.class219_0, class228_1.class219_0);
		}

		// Token: 0x0600162F RID: 5679
		// RVA: 0x00013AB4 File Offset: 0x00011CB4
		public override string ToString()
		{
			return this.class219_0.ToString();
		}
	}
}
