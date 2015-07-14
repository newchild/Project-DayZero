using System;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000045 RID: 69
	public sealed class JsonMergeSettings
	{
		// Token: 0x040000FD RID: 253
		private MergeArrayHandling _mergeArrayHandling;

		// Token: 0x17000044 RID: 68
		public MergeArrayHandling MergeArrayHandling
		{
			// Token: 0x060001F3 RID: 499
			// RVA: 0x000071B1 File Offset: 0x000053B1
			get
			{
				return this._mergeArrayHandling;
			}
			// Token: 0x060001F4 RID: 500
			// RVA: 0x000071B9 File Offset: 0x000053B9
			set
			{
				if (value < MergeArrayHandling.Concat || value > MergeArrayHandling.Merge)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._mergeArrayHandling = value;
			}
		}
	}
}
