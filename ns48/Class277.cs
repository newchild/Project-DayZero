using ns45;
using System;

namespace ns48
{
	// Token: 0x020002F4 RID: 756
	internal sealed class Class277 : IEquatable<Class277>
	{
		// Token: 0x040011E7 RID: 4583
		internal Class272 class272_0;

		// Token: 0x040011E8 RID: 4584
		protected string string_0;

		// Token: 0x17000313 RID: 787
		public string Name
		{
			// Token: 0x06001734 RID: 5940
			// RVA: 0x00014627 File Offset: 0x00012827
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x06001735 RID: 5941
		// RVA: 0x0001462F File Offset: 0x0001282F
		public override bool Equals(object obj)
		{
			return this.Equals(obj as Class277);
		}

		// Token: 0x06001736 RID: 5942
		// RVA: 0x0001463D File Offset: 0x0001283D
		public bool Equals(Class277 other)
		{
			return other != null && Class272.smethod_0(this.class272_0, other.class272_0);
		}

		// Token: 0x06001737 RID: 5943
		// RVA: 0x00014655 File Offset: 0x00012855
		public override int GetHashCode()
		{
			return this.class272_0.GetHashCode();
		}

		// Token: 0x06001738 RID: 5944
		// RVA: 0x00014627 File Offset: 0x00012827
		public override string ToString()
		{
			return this.string_0;
		}
	}
}
