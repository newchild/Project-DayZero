using System;

namespace Newtonsoft.Json
{
	// Token: 0x020000B3 RID: 179
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
	public sealed class JsonArrayAttribute : JsonContainerAttribute
	{
		// Token: 0x040002CF RID: 719
		private bool _allowNullItems;

		// Token: 0x170000CB RID: 203
		public bool AllowNullItems
		{
			// Token: 0x060005E4 RID: 1508
			// RVA: 0x00009640 File Offset: 0x00007840
			get
			{
				return this._allowNullItems;
			}
			// Token: 0x060005E5 RID: 1509
			// RVA: 0x00009648 File Offset: 0x00007848
			set
			{
				this._allowNullItems = value;
			}
		}

		// Token: 0x060005E6 RID: 1510
		// RVA: 0x00006F82 File Offset: 0x00005182
		public JsonArrayAttribute()
		{
		}

		// Token: 0x060005E7 RID: 1511
		// RVA: 0x00009651 File Offset: 0x00007851
		public JsonArrayAttribute(bool allowNullItems)
		{
			this._allowNullItems = allowNullItems;
		}

		// Token: 0x060005E8 RID: 1512
		// RVA: 0x00006F8A File Offset: 0x0000518A
		public JsonArrayAttribute(string id) : base(id)
		{
		}
	}
}
