using System;
using System.Collections.Generic;

namespace ns44
{
	// Token: 0x020002B0 RID: 688
	internal sealed class Class229 : IEquatable<Class229>, IComparable<Class229>
	{
		// Token: 0x04001122 RID: 4386
		private static Class228 class228_0 = new Class228(new byte[20]);

		// Token: 0x04001123 RID: 4387
		private static Class228 class228_1 = new Class228(new byte[]
		{
			255,
			255,
			255,
			255,
			255,
			255,
			255,
			255,
			255,
			255,
			255,
			255,
			255,
			255,
			255,
			255,
			255,
			255,
			255,
			255
		});

		// Token: 0x04001124 RID: 4388
		private Class228 class228_2;

		// Token: 0x04001125 RID: 4389
		private Class228 class228_3;

		// Token: 0x04001126 RID: 4390
		private List<Class225> list_0;

		// Token: 0x06001637 RID: 5687
		// RVA: 0x00013B57 File Offset: 0x00011D57
		public int CompareTo(Class229 obj)
		{
			return this.class228_3.CompareTo(obj.class228_3);
		}

		// Token: 0x06001638 RID: 5688
		// RVA: 0x00013B6A File Offset: 0x00011D6A
		public override bool Equals(object obj)
		{
			return this.Equals(obj as Class229);
		}

		// Token: 0x06001639 RID: 5689
		// RVA: 0x00013B78 File Offset: 0x00011D78
		public bool Equals(Class229 other)
		{
			return other != null && this.class228_3.Equals(other.class228_3) && this.class228_2.Equals(other.class228_2);
		}

		// Token: 0x0600163A RID: 5690
		// RVA: 0x00013BA5 File Offset: 0x00011DA5
		public override int GetHashCode()
		{
			return this.class228_3.GetHashCode() ^ this.class228_2.GetHashCode();
		}

		// Token: 0x0600163B RID: 5691
		// RVA: 0x00013BBE File Offset: 0x00011DBE
		public override string ToString()
		{
			return string.Format("Count: {2} Min: {0}  Max: {1}", this.class228_3, this.class228_2, this.list_0.Count);
		}
	}
}
