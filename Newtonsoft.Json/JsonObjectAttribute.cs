using System;

namespace Newtonsoft.Json
{
	// Token: 0x020000B6 RID: 182
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = false)]
	public sealed class JsonObjectAttribute : JsonContainerAttribute
	{
		// Token: 0x040002D8 RID: 728
		internal Required? _itemRequired;

		// Token: 0x040002D7 RID: 727
		private MemberSerialization _memberSerialization;

		// Token: 0x170000CF RID: 207
		public Required ItemRequired
		{
			// Token: 0x060005F0 RID: 1520
			// RVA: 0x00035AC8 File Offset: 0x00033CC8
			get
			{
				Required? itemRequired = this._itemRequired;
				if (!itemRequired.HasValue)
				{
					return Required.Default;
				}
				return itemRequired.GetValueOrDefault();
			}
			// Token: 0x060005F1 RID: 1521
			// RVA: 0x000096B7 File Offset: 0x000078B7
			set
			{
				this._itemRequired = new Required?(value);
			}
		}

		// Token: 0x170000CE RID: 206
		public MemberSerialization MemberSerialization
		{
			// Token: 0x060005EE RID: 1518
			// RVA: 0x000096A6 File Offset: 0x000078A6
			get
			{
				return this._memberSerialization;
			}
			// Token: 0x060005EF RID: 1519
			// RVA: 0x000096AE File Offset: 0x000078AE
			set
			{
				this._memberSerialization = value;
			}
		}

		// Token: 0x060005F2 RID: 1522
		// RVA: 0x00006F82 File Offset: 0x00005182
		public JsonObjectAttribute()
		{
		}

		// Token: 0x060005F3 RID: 1523
		// RVA: 0x000096C5 File Offset: 0x000078C5
		public JsonObjectAttribute(MemberSerialization memberSerialization)
		{
			this.MemberSerialization = memberSerialization;
		}

		// Token: 0x060005F4 RID: 1524
		// RVA: 0x00006F8A File Offset: 0x0000518A
		public JsonObjectAttribute(string id) : base(id)
		{
		}
	}
}
