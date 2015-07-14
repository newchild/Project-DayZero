using System;
using System.Collections.Generic;

namespace ns48
{
	// Token: 0x020002EE RID: 750
	internal sealed class Class273<T> : List<T>, ICloneable
	{
		// Token: 0x0600171F RID: 5919
		// RVA: 0x0000ECAC File Offset: 0x0000CEAC
		public Class273()
		{
		}

		// Token: 0x06001720 RID: 5920
		// RVA: 0x0000ECB4 File Offset: 0x0000CEB4
		public Class273(IEnumerable<T> ienumerable_0) : base(ienumerable_0)
		{
		}

		// Token: 0x06001721 RID: 5921
		// RVA: 0x0000ECBD File Offset: 0x0000CEBD
		public Class273(int int_0) : base(int_0)
		{
		}

		// Token: 0x06001723 RID: 5923
		// RVA: 0x0001453E File Offset: 0x0001273E
		public Class273<T> Clone()
		{
			return new Class273<T>(this);
		}

		// Token: 0x06001722 RID: 5922
		// RVA: 0x00014536 File Offset: 0x00012736
		object ICloneable.Clone()
		{
			return this.Clone();
		}
	}
}
