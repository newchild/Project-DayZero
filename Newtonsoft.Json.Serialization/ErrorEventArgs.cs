using System;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000105 RID: 261
	public sealed class ErrorEventArgs : EventArgs
	{
		// Token: 0x170001CE RID: 462
		public object CurrentObject
		{
			// Token: 0x06000A82 RID: 2690
			// RVA: 0x0000C4B4 File Offset: 0x0000A6B4
			get;
			// Token: 0x06000A83 RID: 2691
			// RVA: 0x0000C4BC File Offset: 0x0000A6BC
			private set;
		}

		// Token: 0x170001CF RID: 463
		public ErrorContext ErrorContext
		{
			// Token: 0x06000A84 RID: 2692
			// RVA: 0x0000C4C5 File Offset: 0x0000A6C5
			get;
			// Token: 0x06000A85 RID: 2693
			// RVA: 0x0000C4CD File Offset: 0x0000A6CD
			private set;
		}

		// Token: 0x06000A86 RID: 2694
		// RVA: 0x0000C4D6 File Offset: 0x0000A6D6
		public ErrorEventArgs(object currentObject, ErrorContext errorContext)
		{
			this.CurrentObject = currentObject;
			this.ErrorContext = errorContext;
		}
	}
}
