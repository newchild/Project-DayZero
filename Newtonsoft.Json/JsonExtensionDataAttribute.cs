using System;

namespace Newtonsoft.Json
{
	// Token: 0x02000041 RID: 65
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	public sealed class JsonExtensionDataAttribute : Attribute
	{
		// Token: 0x17000040 RID: 64
		public bool ReadData
		{
			// Token: 0x060001D7 RID: 471
			// RVA: 0x00006FDB File Offset: 0x000051DB
			get;
			// Token: 0x060001D8 RID: 472
			// RVA: 0x00006FE3 File Offset: 0x000051E3
			set;
		}

		// Token: 0x1700003F RID: 63
		public bool WriteData
		{
			// Token: 0x060001D5 RID: 469
			// RVA: 0x00006FCA File Offset: 0x000051CA
			get;
			// Token: 0x060001D6 RID: 470
			// RVA: 0x00006FD2 File Offset: 0x000051D2
			set;
		}

		// Token: 0x060001D9 RID: 473
		// RVA: 0x00006FEC File Offset: 0x000051EC
		public JsonExtensionDataAttribute()
		{
			this.WriteData = true;
			this.ReadData = true;
		}
	}
}
