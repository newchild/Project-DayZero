using System;

namespace Newtonsoft.Json
{
	// Token: 0x02000163 RID: 355
	public enum WriteState
	{
		// Token: 0x040005D8 RID: 1496
		Error,
		// Token: 0x040005D9 RID: 1497
		Closed,
		// Token: 0x040005DA RID: 1498
		Object,
		// Token: 0x040005DB RID: 1499
		Array,
		// Token: 0x040005DC RID: 1500
		Constructor,
		// Token: 0x040005DD RID: 1501
		Property,
		// Token: 0x040005DE RID: 1502
		Start
	}
}
