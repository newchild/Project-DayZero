using Newtonsoft.Json.Utilities.LinqBridge;
using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020000F1 RID: 241
	public sealed class JsonSchemaResolver
	{
		// Token: 0x170001BC RID: 444
		public IList<JsonSchema> LoadedSchemas
		{
			// Token: 0x06000A03 RID: 2563
			// RVA: 0x0000C0A7 File Offset: 0x0000A2A7
			get;
			// Token: 0x06000A04 RID: 2564
			// RVA: 0x0000C0AF File Offset: 0x0000A2AF
			protected set;
		}

		// Token: 0x06000A05 RID: 2565
		// RVA: 0x0000C0B8 File Offset: 0x0000A2B8
		public JsonSchemaResolver()
		{
			this.LoadedSchemas = new List<JsonSchema>();
		}

		// Token: 0x06000A06 RID: 2566
		// RVA: 0x0003F13C File Offset: 0x0003D33C
		public virtual JsonSchema GetSchema(string reference)
		{
			JsonSchema jsonSchema = Enumerable.SingleOrDefault<JsonSchema>(this.LoadedSchemas, (JsonSchema s) => string.Equals(s.Id, reference, StringComparison.Ordinal));
			if (jsonSchema == null)
			{
				jsonSchema = Enumerable.SingleOrDefault<JsonSchema>(this.LoadedSchemas, (JsonSchema s) => string.Equals(s.Location, reference, StringComparison.Ordinal));
			}
			return jsonSchema;
		}
	}
}
