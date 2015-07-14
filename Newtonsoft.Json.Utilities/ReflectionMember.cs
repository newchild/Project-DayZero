using Newtonsoft.Json.Serialization;
using System;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200013D RID: 317
	internal sealed class ReflectionMember
	{
		// Token: 0x17000255 RID: 597
		public Func<object, object> Getter
		{
			// Token: 0x06000CB5 RID: 3253
			// RVA: 0x0000D8F2 File Offset: 0x0000BAF2
			get;
			// Token: 0x06000CB6 RID: 3254
			// RVA: 0x0000D8FA File Offset: 0x0000BAFA
			set;
		}

		// Token: 0x17000254 RID: 596
		public Type MemberType
		{
			// Token: 0x06000CB3 RID: 3251
			// RVA: 0x0000D8E1 File Offset: 0x0000BAE1
			get;
			// Token: 0x06000CB4 RID: 3252
			// RVA: 0x0000D8E9 File Offset: 0x0000BAE9
			set;
		}

		// Token: 0x17000256 RID: 598
		public Action<object, object> Setter
		{
			// Token: 0x06000CB7 RID: 3255
			// RVA: 0x0000D903 File Offset: 0x0000BB03
			get;
			// Token: 0x06000CB8 RID: 3256
			// RVA: 0x0000D90B File Offset: 0x0000BB0B
			set;
		}
	}
}
