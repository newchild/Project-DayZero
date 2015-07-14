using System;
using System.Text;

namespace ns48
{
	// Token: 0x020002F5 RID: 757
	internal sealed class Class278 : IEquatable<Class278>
	{
		// Token: 0x040011EC RID: 4588
		private Enum36 enum36_0;

		// Token: 0x040011E9 RID: 4585
		private int int_0;

		// Token: 0x040011ED RID: 4589
		private int int_1;

		// Token: 0x040011EA RID: 4586
		private long long_0;

		// Token: 0x040011EB RID: 4587
		private string string_0;

		// Token: 0x0600173C RID: 5948
		// RVA: 0x0001467A File Offset: 0x0001287A
		public override bool Equals(object obj)
		{
			return this.Equals(obj as Class278);
		}

		// Token: 0x0600173D RID: 5949
		// RVA: 0x00014688 File Offset: 0x00012888
		public bool Equals(Class278 other)
		{
			return other != null && this.string_0 == other.string_0 && this.long_0 == other.long_0;
		}

		// Token: 0x0600173E RID: 5950
		// RVA: 0x000146B2 File Offset: 0x000128B2
		public override int GetHashCode()
		{
			return this.string_0.GetHashCode();
		}

		// Token: 0x06001739 RID: 5945
		// RVA: 0x00014662 File Offset: 0x00012862
		public int method_0()
		{
			return this.int_0;
		}

		// Token: 0x0600173A RID: 5946
		// RVA: 0x0001466A File Offset: 0x0001286A
		public Enum36 method_1()
		{
			return this.enum36_0;
		}

		// Token: 0x0600173B RID: 5947
		// RVA: 0x00014672 File Offset: 0x00012872
		public int method_2()
		{
			return this.int_1;
		}

		// Token: 0x0600173F RID: 5951
		// RVA: 0x00072F38 File Offset: 0x00071138
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder(32);
			stringBuilder.Append("File: ");
			stringBuilder.Append(this.string_0);
			stringBuilder.Append(" StartIndex: ");
			stringBuilder.Append(this.method_2());
			stringBuilder.Append(" EndIndex: ");
			stringBuilder.Append(this.method_0());
			return stringBuilder.ToString();
		}
	}
}
