using Newtonsoft.Json.Utilities.LinqBridge;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020000F0 RID: 240
	internal sealed class JsonSchemaNode
	{
		// Token: 0x170001BB RID: 443
		public JsonSchemaNode AdditionalItems
		{
			// Token: 0x060009FB RID: 2555
			// RVA: 0x0000C085 File Offset: 0x0000A285
			get;
			// Token: 0x060009FC RID: 2556
			// RVA: 0x0000C08D File Offset: 0x0000A28D
			set;
		}

		// Token: 0x170001BA RID: 442
		public JsonSchemaNode AdditionalProperties
		{
			// Token: 0x060009F9 RID: 2553
			// RVA: 0x0000C074 File Offset: 0x0000A274
			get;
			// Token: 0x060009FA RID: 2554
			// RVA: 0x0000C07C File Offset: 0x0000A27C
			set;
		}

		// Token: 0x170001B5 RID: 437
		public string Id
		{
			// Token: 0x060009EF RID: 2543
			// RVA: 0x0000C01F File Offset: 0x0000A21F
			get;
			// Token: 0x060009F0 RID: 2544
			// RVA: 0x0000C027 File Offset: 0x0000A227
			private set;
		}

		// Token: 0x170001B9 RID: 441
		public List<JsonSchemaNode> Items
		{
			// Token: 0x060009F7 RID: 2551
			// RVA: 0x0000C063 File Offset: 0x0000A263
			get;
			// Token: 0x060009F8 RID: 2552
			// RVA: 0x0000C06B File Offset: 0x0000A26B
			private set;
		}

		// Token: 0x170001B8 RID: 440
		public Dictionary<string, JsonSchemaNode> PatternProperties
		{
			// Token: 0x060009F5 RID: 2549
			// RVA: 0x0000C052 File Offset: 0x0000A252
			get;
			// Token: 0x060009F6 RID: 2550
			// RVA: 0x0000C05A File Offset: 0x0000A25A
			private set;
		}

		// Token: 0x170001B7 RID: 439
		public Dictionary<string, JsonSchemaNode> Properties
		{
			// Token: 0x060009F3 RID: 2547
			// RVA: 0x0000C041 File Offset: 0x0000A241
			get;
			// Token: 0x060009F4 RID: 2548
			// RVA: 0x0000C049 File Offset: 0x0000A249
			private set;
		}

		// Token: 0x170001B6 RID: 438
		public ReadOnlyCollection<JsonSchema> Schemas
		{
			// Token: 0x060009F1 RID: 2545
			// RVA: 0x0000C030 File Offset: 0x0000A230
			get;
			// Token: 0x060009F2 RID: 2546
			// RVA: 0x0000C038 File Offset: 0x0000A238
			private set;
		}

		// Token: 0x060009FD RID: 2557
		// RVA: 0x0003EFE0 File Offset: 0x0003D1E0
		public JsonSchemaNode(JsonSchema schema)
		{
			this.Schemas = new ReadOnlyCollection<JsonSchema>(new JsonSchema[]
			{
				schema
			});
			this.Properties = new Dictionary<string, JsonSchemaNode>();
			this.PatternProperties = new Dictionary<string, JsonSchemaNode>();
			this.Items = new List<JsonSchemaNode>();
			this.Id = JsonSchemaNode.GetId(this.Schemas);
		}

		// Token: 0x060009FE RID: 2558
		// RVA: 0x0003F03C File Offset: 0x0003D23C
		private JsonSchemaNode(JsonSchemaNode source, JsonSchema schema)
		{
			this.Schemas = new ReadOnlyCollection<JsonSchema>(Enumerable.ToList<JsonSchema>(Enumerable.Union<JsonSchema>(source.Schemas, new JsonSchema[]
			{
				schema
			})));
			this.Properties = new Dictionary<string, JsonSchemaNode>(source.Properties);
			this.PatternProperties = new Dictionary<string, JsonSchemaNode>(source.PatternProperties);
			this.Items = new List<JsonSchemaNode>(source.Items);
			this.AdditionalProperties = source.AdditionalProperties;
			this.AdditionalItems = source.AdditionalItems;
			this.Id = JsonSchemaNode.GetId(this.Schemas);
		}

		// Token: 0x060009FF RID: 2559
		// RVA: 0x0000C096 File Offset: 0x0000A296
		public JsonSchemaNode Combine(JsonSchema schema)
		{
			return new JsonSchemaNode(this, schema);
		}

		// Token: 0x06000A00 RID: 2560
		// RVA: 0x0003F0D4 File Offset: 0x0003D2D4
		public static string GetId(IEnumerable<JsonSchema> schemata)
		{
			return string.Join("-", Enumerable.ToArray<string>(Enumerable.OrderBy<string, string>(Enumerable.Select<JsonSchema, string>(schemata, (JsonSchema s) => s.InternalId), (string id) => id, StringComparer.Ordinal)));
		}
	}
}
