using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020000ED RID: 237
	internal sealed class JsonSchemaModel
	{
		// Token: 0x170001AE RID: 430
		public JsonSchemaModel AdditionalItems
		{
			// Token: 0x060009D3 RID: 2515
			// RVA: 0x0000BF2B File Offset: 0x0000A12B
			get;
			// Token: 0x060009D4 RID: 2516
			// RVA: 0x0000BF33 File Offset: 0x0000A133
			set;
		}

		// Token: 0x170001AD RID: 429
		public JsonSchemaModel AdditionalProperties
		{
			// Token: 0x060009D1 RID: 2513
			// RVA: 0x0000BF1A File Offset: 0x0000A11A
			get;
			// Token: 0x060009D2 RID: 2514
			// RVA: 0x0000BF22 File Offset: 0x0000A122
			set;
		}

		// Token: 0x170001B1 RID: 433
		public bool AllowAdditionalItems
		{
			// Token: 0x060009D9 RID: 2521
			// RVA: 0x0000BF5E File Offset: 0x0000A15E
			get;
			// Token: 0x060009DA RID: 2522
			// RVA: 0x0000BF66 File Offset: 0x0000A166
			set;
		}

		// Token: 0x170001B0 RID: 432
		public bool AllowAdditionalProperties
		{
			// Token: 0x060009D7 RID: 2519
			// RVA: 0x0000BF4D File Offset: 0x0000A14D
			get;
			// Token: 0x060009D8 RID: 2520
			// RVA: 0x0000BF55 File Offset: 0x0000A155
			set;
		}

		// Token: 0x170001B4 RID: 436
		public JsonSchemaType Disallow
		{
			// Token: 0x060009DF RID: 2527
			// RVA: 0x0000BF91 File Offset: 0x0000A191
			get;
			// Token: 0x060009E0 RID: 2528
			// RVA: 0x0000BF99 File Offset: 0x0000A199
			set;
		}

		// Token: 0x170001A2 RID: 418
		public double? DivisibleBy
		{
			// Token: 0x060009BB RID: 2491
			// RVA: 0x0000BE5F File Offset: 0x0000A05F
			get;
			// Token: 0x060009BC RID: 2492
			// RVA: 0x0000BE67 File Offset: 0x0000A067
			set;
		}

		// Token: 0x170001B3 RID: 435
		public IList<JToken> Enum
		{
			// Token: 0x060009DD RID: 2525
			// RVA: 0x0000BF80 File Offset: 0x0000A180
			get;
			// Token: 0x060009DE RID: 2526
			// RVA: 0x0000BF88 File Offset: 0x0000A188
			set;
		}

		// Token: 0x170001A6 RID: 422
		public bool ExclusiveMaximum
		{
			// Token: 0x060009C3 RID: 2499
			// RVA: 0x0000BEA3 File Offset: 0x0000A0A3
			get;
			// Token: 0x060009C4 RID: 2500
			// RVA: 0x0000BEAB File Offset: 0x0000A0AB
			set;
		}

		// Token: 0x170001A5 RID: 421
		public bool ExclusiveMinimum
		{
			// Token: 0x060009C1 RID: 2497
			// RVA: 0x0000BE92 File Offset: 0x0000A092
			get;
			// Token: 0x060009C2 RID: 2498
			// RVA: 0x0000BE9A File Offset: 0x0000A09A
			set;
		}

		// Token: 0x170001AA RID: 426
		public IList<JsonSchemaModel> Items
		{
			// Token: 0x060009CB RID: 2507
			// RVA: 0x0000BEE7 File Offset: 0x0000A0E7
			get;
			// Token: 0x060009CC RID: 2508
			// RVA: 0x0000BEEF File Offset: 0x0000A0EF
			set;
		}

		// Token: 0x170001A4 RID: 420
		public double? Maximum
		{
			// Token: 0x060009BF RID: 2495
			// RVA: 0x0000BE81 File Offset: 0x0000A081
			get;
			// Token: 0x060009C0 RID: 2496
			// RVA: 0x0000BE89 File Offset: 0x0000A089
			set;
		}

		// Token: 0x170001A8 RID: 424
		public int? MaximumItems
		{
			// Token: 0x060009C7 RID: 2503
			// RVA: 0x0000BEC5 File Offset: 0x0000A0C5
			get;
			// Token: 0x060009C8 RID: 2504
			// RVA: 0x0000BECD File Offset: 0x0000A0CD
			set;
		}

		// Token: 0x170001A1 RID: 417
		public int? MaximumLength
		{
			// Token: 0x060009B9 RID: 2489
			// RVA: 0x0000BE4E File Offset: 0x0000A04E
			get;
			// Token: 0x060009BA RID: 2490
			// RVA: 0x0000BE56 File Offset: 0x0000A056
			set;
		}

		// Token: 0x170001A3 RID: 419
		public double? Minimum
		{
			// Token: 0x060009BD RID: 2493
			// RVA: 0x0000BE70 File Offset: 0x0000A070
			get;
			// Token: 0x060009BE RID: 2494
			// RVA: 0x0000BE78 File Offset: 0x0000A078
			set;
		}

		// Token: 0x170001A7 RID: 423
		public int? MinimumItems
		{
			// Token: 0x060009C5 RID: 2501
			// RVA: 0x0000BEB4 File Offset: 0x0000A0B4
			get;
			// Token: 0x060009C6 RID: 2502
			// RVA: 0x0000BEBC File Offset: 0x0000A0BC
			set;
		}

		// Token: 0x170001A0 RID: 416
		public int? MinimumLength
		{
			// Token: 0x060009B7 RID: 2487
			// RVA: 0x0000BE3D File Offset: 0x0000A03D
			get;
			// Token: 0x060009B8 RID: 2488
			// RVA: 0x0000BE45 File Offset: 0x0000A045
			set;
		}

		// Token: 0x170001AC RID: 428
		public IDictionary<string, JsonSchemaModel> PatternProperties
		{
			// Token: 0x060009CF RID: 2511
			// RVA: 0x0000BF09 File Offset: 0x0000A109
			get;
			// Token: 0x060009D0 RID: 2512
			// RVA: 0x0000BF11 File Offset: 0x0000A111
			set;
		}

		// Token: 0x170001A9 RID: 425
		public IList<string> Patterns
		{
			// Token: 0x060009C9 RID: 2505
			// RVA: 0x0000BED6 File Offset: 0x0000A0D6
			get;
			// Token: 0x060009CA RID: 2506
			// RVA: 0x0000BEDE File Offset: 0x0000A0DE
			set;
		}

		// Token: 0x170001AF RID: 431
		public bool PositionalItemsValidation
		{
			// Token: 0x060009D5 RID: 2517
			// RVA: 0x0000BF3C File Offset: 0x0000A13C
			get;
			// Token: 0x060009D6 RID: 2518
			// RVA: 0x0000BF44 File Offset: 0x0000A144
			set;
		}

		// Token: 0x170001AB RID: 427
		public IDictionary<string, JsonSchemaModel> Properties
		{
			// Token: 0x060009CD RID: 2509
			// RVA: 0x0000BEF8 File Offset: 0x0000A0F8
			get;
			// Token: 0x060009CE RID: 2510
			// RVA: 0x0000BF00 File Offset: 0x0000A100
			set;
		}

		// Token: 0x1700019E RID: 414
		public bool Required
		{
			// Token: 0x060009B3 RID: 2483
			// RVA: 0x0000BE1B File Offset: 0x0000A01B
			get;
			// Token: 0x060009B4 RID: 2484
			// RVA: 0x0000BE23 File Offset: 0x0000A023
			set;
		}

		// Token: 0x1700019F RID: 415
		public JsonSchemaType Type
		{
			// Token: 0x060009B5 RID: 2485
			// RVA: 0x0000BE2C File Offset: 0x0000A02C
			get;
			// Token: 0x060009B6 RID: 2486
			// RVA: 0x0000BE34 File Offset: 0x0000A034
			set;
		}

		// Token: 0x170001B2 RID: 434
		public bool UniqueItems
		{
			// Token: 0x060009DB RID: 2523
			// RVA: 0x0000BF6F File Offset: 0x0000A16F
			get;
			// Token: 0x060009DC RID: 2524
			// RVA: 0x0000BF77 File Offset: 0x0000A177
			set;
		}

		// Token: 0x060009E1 RID: 2529
		// RVA: 0x0000BFA2 File Offset: 0x0000A1A2
		public JsonSchemaModel()
		{
			this.Type = JsonSchemaType.Any;
			this.AllowAdditionalProperties = true;
			this.AllowAdditionalItems = true;
			this.Required = false;
		}

		// Token: 0x060009E3 RID: 2531
		// RVA: 0x0003E96C File Offset: 0x0003CB6C
		private static void Combine(JsonSchemaModel model, JsonSchema schema)
		{
			model.Required = (model.Required || (schema.Required ?? false));
			model.Type &= (schema.Type ?? JsonSchemaType.Any);
			model.MinimumLength = MathUtils.Max(model.MinimumLength, schema.MinimumLength);
			model.MaximumLength = MathUtils.Min(model.MaximumLength, schema.MaximumLength);
			model.DivisibleBy = MathUtils.Max(model.DivisibleBy, schema.DivisibleBy);
			model.Minimum = MathUtils.Max(model.Minimum, schema.Minimum);
			model.Maximum = MathUtils.Max(model.Maximum, schema.Maximum);
			model.ExclusiveMinimum = (model.ExclusiveMinimum || (schema.ExclusiveMinimum ?? false));
			model.ExclusiveMaximum = (model.ExclusiveMaximum || (schema.ExclusiveMaximum ?? false));
			model.MinimumItems = MathUtils.Max(model.MinimumItems, schema.MinimumItems);
			model.MaximumItems = MathUtils.Min(model.MaximumItems, schema.MaximumItems);
			model.PositionalItemsValidation = (model.PositionalItemsValidation || schema.PositionalItemsValidation);
			model.AllowAdditionalProperties = (model.AllowAdditionalProperties && schema.AllowAdditionalProperties);
			model.AllowAdditionalItems = (model.AllowAdditionalItems && schema.AllowAdditionalItems);
			model.UniqueItems = (model.UniqueItems || schema.UniqueItems);
			if (schema.Enum != null)
			{
				if (model.Enum == null)
				{
					model.Enum = new List<JToken>();
				}
				CollectionUtils.AddRangeDistinct<JToken>(model.Enum, schema.Enum, JToken.EqualityComparer);
			}
			model.Disallow |= (schema.Disallow ?? JsonSchemaType.None);
			if (schema.Pattern != null)
			{
				if (model.Patterns == null)
				{
					model.Patterns = new List<string>();
				}
				CollectionUtils.AddDistinct<string>(model.Patterns, schema.Pattern);
			}
		}

		// Token: 0x060009E2 RID: 2530
		// RVA: 0x0003E91C File Offset: 0x0003CB1C
		public static JsonSchemaModel Create(IList<JsonSchema> schemata)
		{
			JsonSchemaModel jsonSchemaModel = new JsonSchemaModel();
			foreach (JsonSchema current in schemata)
			{
				JsonSchemaModel.Combine(jsonSchemaModel, current);
			}
			return jsonSchemaModel;
		}
	}
}
