using System;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000104 RID: 260
	public sealed class ErrorContext
	{
		// Token: 0x170001C9 RID: 457
		public Exception Error
		{
			// Token: 0x06000A78 RID: 2680
			// RVA: 0x0000C45F File Offset: 0x0000A65F
			get;
			// Token: 0x06000A79 RID: 2681
			// RVA: 0x0000C467 File Offset: 0x0000A667
			private set;
		}

		// Token: 0x170001CD RID: 461
		public bool Handled
		{
			// Token: 0x06000A80 RID: 2688
			// RVA: 0x0000C4A3 File Offset: 0x0000A6A3
			get;
			// Token: 0x06000A81 RID: 2689
			// RVA: 0x0000C4AB File Offset: 0x0000A6AB
			set;
		}

		// Token: 0x170001CB RID: 459
		public object Member
		{
			// Token: 0x06000A7C RID: 2684
			// RVA: 0x0000C481 File Offset: 0x0000A681
			get;
			// Token: 0x06000A7D RID: 2685
			// RVA: 0x0000C489 File Offset: 0x0000A689
			private set;
		}

		// Token: 0x170001CA RID: 458
		public object OriginalObject
		{
			// Token: 0x06000A7A RID: 2682
			// RVA: 0x0000C470 File Offset: 0x0000A670
			get;
			// Token: 0x06000A7B RID: 2683
			// RVA: 0x0000C478 File Offset: 0x0000A678
			private set;
		}

		// Token: 0x170001CC RID: 460
		public string Path
		{
			// Token: 0x06000A7E RID: 2686
			// RVA: 0x0000C492 File Offset: 0x0000A692
			get;
			// Token: 0x06000A7F RID: 2687
			// RVA: 0x0000C49A File Offset: 0x0000A69A
			private set;
		}

		// Token: 0x170001C8 RID: 456
		internal bool Traced
		{
			// Token: 0x06000A76 RID: 2678
			// RVA: 0x0000C44E File Offset: 0x0000A64E
			get;
			// Token: 0x06000A77 RID: 2679
			// RVA: 0x0000C456 File Offset: 0x0000A656
			set;
		}

		// Token: 0x06000A75 RID: 2677
		// RVA: 0x0000C429 File Offset: 0x0000A629
		internal ErrorContext(object originalObject, object member, string path, Exception error)
		{
			this.OriginalObject = originalObject;
			this.Member = member;
			this.Error = error;
			this.Path = path;
		}
	}
}
