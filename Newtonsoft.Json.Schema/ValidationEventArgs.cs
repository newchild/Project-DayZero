using Newtonsoft.Json.Utilities;
using System;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020000F5 RID: 245
	public sealed class ValidationEventArgs : EventArgs
	{
		// Token: 0x0400041E RID: 1054
		private readonly JsonSchemaException _ex;

		// Token: 0x170001BD RID: 445
		public JsonSchemaException Exception
		{
			// Token: 0x06000A13 RID: 2579
			// RVA: 0x0000C14A File Offset: 0x0000A34A
			get
			{
				return this._ex;
			}
		}

		// Token: 0x170001BF RID: 447
		public string Message
		{
			// Token: 0x06000A15 RID: 2581
			// RVA: 0x0000C15F File Offset: 0x0000A35F
			get
			{
				return this._ex.Message;
			}
		}

		// Token: 0x170001BE RID: 446
		public string Path
		{
			// Token: 0x06000A14 RID: 2580
			// RVA: 0x0000C152 File Offset: 0x0000A352
			get
			{
				return this._ex.Path;
			}
		}

		// Token: 0x06000A12 RID: 2578
		// RVA: 0x0000C130 File Offset: 0x0000A330
		internal ValidationEventArgs(JsonSchemaException ex)
		{
			ValidationUtils.ArgumentNotNull(ex, "ex");
			this._ex = ex;
		}
	}
}
