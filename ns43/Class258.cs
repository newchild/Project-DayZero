using System;

namespace ns43
{
	// Token: 0x020002D8 RID: 728
	internal sealed class Class258 : IComparable<Class258>
	{
		// Token: 0x04001194 RID: 4500
		internal static readonly int int_0 = 16384;

		// Token: 0x04001196 RID: 4502
		private int int_1;

		// Token: 0x04001195 RID: 4501
		private Struct43[] struct43_0;

		// Token: 0x17000307 RID: 775
		public int Index
		{
			// Token: 0x060016DC RID: 5852
			// RVA: 0x00014278 File Offset: 0x00012478
			get
			{
				return this.int_1;
			}
		}

		// Token: 0x17000306 RID: 774
		public Struct43 this[int int_2]
		{
			// Token: 0x060016DB RID: 5851
			// RVA: 0x00014265 File Offset: 0x00012465
			get
			{
				return this.struct43_0[int_2];
			}
		}

		// Token: 0x060016DD RID: 5853
		// RVA: 0x00072904 File Offset: 0x00070B04
		public int CompareTo(Class258 obj)
		{
			if (obj != null)
			{
				return this.Index.CompareTo(obj.Index);
			}
			return 1;
		}

		// Token: 0x060016DE RID: 5854
		// RVA: 0x0007292C File Offset: 0x00070B2C
		public override bool Equals(object obj)
		{
			Class258 class = obj as Class258;
			return class != null && this.int_1.Equals(class.int_1);
		}

		// Token: 0x060016DF RID: 5855
		// RVA: 0x00014278 File Offset: 0x00012478
		public override int GetHashCode()
		{
			return this.int_1;
		}
	}
}
