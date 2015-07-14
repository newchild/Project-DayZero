using System;

namespace Amib.Threading.Internal
{
	// Token: 0x02000317 RID: 791
	internal sealed class CanceledWorkItemsGroup
	{
		// Token: 0x04001266 RID: 4710
		public static readonly CanceledWorkItemsGroup NotCanceledWorkItemsGroup = new CanceledWorkItemsGroup();

		// Token: 0x17000328 RID: 808
		public bool IsCanceled
		{
			// Token: 0x060017AA RID: 6058
			// RVA: 0x00014A37 File Offset: 0x00012C37
			get;
			// Token: 0x060017AB RID: 6059
			// RVA: 0x00014A3F File Offset: 0x00012C3F
			set;
		}

		// Token: 0x060017A9 RID: 6057
		// RVA: 0x00014A28 File Offset: 0x00012C28
		public CanceledWorkItemsGroup()
		{
			this.IsCanceled = false;
		}
	}
}
