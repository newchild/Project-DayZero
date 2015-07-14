using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000116 RID: 278
	public sealed class JsonSchema
	{
		// Token: 0x0400049B RID: 1179
		private readonly string _internalId = Guid.NewGuid().ToString("N");

		// Token: 0x17000211 RID: 529
		public JsonSchema AdditionalItems
		{
			// Token: 0x06000B3B RID: 2875
			// RVA: 0x0000CB80 File Offset: 0x0000AD80
			get;
			// Token: 0x06000B3C RID: 2876
			// RVA: 0x0000CB88 File Offset: 0x0000AD88
			set;
		}

		// Token: 0x17000215 RID: 533
		public JsonSchema AdditionalProperties
		{
			// Token: 0x06000B43 RID: 2883
			// RVA: 0x0000CBC4 File Offset: 0x0000ADC4
			get;
			// Token: 0x06000B44 RID: 2884
			// RVA: 0x0000CBCC File Offset: 0x0000ADCC
			set;
		}

		// Token: 0x17000212 RID: 530
		public bool AllowAdditionalItems
		{
			// Token: 0x06000B3D RID: 2877
			// RVA: 0x0000CB91 File Offset: 0x0000AD91
			get;
			// Token: 0x06000B3E RID: 2878
			// RVA: 0x0000CB99 File Offset: 0x0000AD99
			set;
		}

		// Token: 0x17000217 RID: 535
		public bool AllowAdditionalProperties
		{
			// Token: 0x06000B47 RID: 2887
			// RVA: 0x0000CBE6 File Offset: 0x0000ADE6
			get;
			// Token: 0x06000B48 RID: 2888
			// RVA: 0x0000CBEE File Offset: 0x0000ADEE
			set;
		}

		// Token: 0x1700021B RID: 539
		public JToken Default
		{
			// Token: 0x06000B4F RID: 2895
			// RVA: 0x0000CC2A File Offset: 0x0000AE2A
			get;
			// Token: 0x06000B50 RID: 2896
			// RVA: 0x0000CC32 File Offset: 0x0000AE32
			set;
		}

		// Token: 0x17000220 RID: 544
		internal string DeferredReference
		{
			// Token: 0x06000B58 RID: 2904
			// RVA: 0x0000CC76 File Offset: 0x0000AE76
			get;
			// Token: 0x06000B59 RID: 2905
			// RVA: 0x0000CC7E File Offset: 0x0000AE7E
			set;
		}

		// Token: 0x17000203 RID: 515
		public string Description
		{
			// Token: 0x06000B1F RID: 2847
			// RVA: 0x0000CA92 File Offset: 0x0000AC92
			get;
			// Token: 0x06000B20 RID: 2848
			// RVA: 0x0000CA9A File Offset: 0x0000AC9A
			set;
		}

		// Token: 0x1700021A RID: 538
		public JsonSchemaType? Disallow
		{
			// Token: 0x06000B4D RID: 2893
			// RVA: 0x0000CC19 File Offset: 0x0000AE19
			get;
			// Token: 0x06000B4E RID: 2894
			// RVA: 0x0000CC21 File Offset: 0x0000AE21
			set;
		}

		// Token: 0x17000208 RID: 520
		public double? DivisibleBy
		{
			// Token: 0x06000B29 RID: 2857
			// RVA: 0x0000CAE7 File Offset: 0x0000ACE7
			get;
			// Token: 0x06000B2A RID: 2858
			// RVA: 0x0000CAEF File Offset: 0x0000ACEF
			set;
		}

		// Token: 0x17000219 RID: 537
		public IList<JToken> Enum
		{
			// Token: 0x06000B4B RID: 2891
			// RVA: 0x0000CC08 File Offset: 0x0000AE08
			get;
			// Token: 0x06000B4C RID: 2892
			// RVA: 0x0000CC10 File Offset: 0x0000AE10
			set;
		}

		// Token: 0x1700020C RID: 524
		public bool? ExclusiveMaximum
		{
			// Token: 0x06000B31 RID: 2865
			// RVA: 0x0000CB2B File Offset: 0x0000AD2B
			get;
			// Token: 0x06000B32 RID: 2866
			// RVA: 0x0000CB33 File Offset: 0x0000AD33
			set;
		}

		// Token: 0x1700020B RID: 523
		public bool? ExclusiveMinimum
		{
			// Token: 0x06000B2F RID: 2863
			// RVA: 0x0000CB1A File Offset: 0x0000AD1A
			get;
			// Token: 0x06000B30 RID: 2864
			// RVA: 0x0000CB22 File Offset: 0x0000AD22
			set;
		}

		// Token: 0x1700021C RID: 540
		public IList<JsonSchema> Extends
		{
			// Token: 0x06000B51 RID: 2897
			// RVA: 0x0000CC3B File Offset: 0x0000AE3B
			get;
			// Token: 0x06000B52 RID: 2898
			// RVA: 0x0000CC43 File Offset: 0x0000AE43
			set;
		}

		// Token: 0x1700021D RID: 541
		public string Format
		{
			// Token: 0x06000B53 RID: 2899
			// RVA: 0x0000CC4C File Offset: 0x0000AE4C
			get;
			// Token: 0x06000B54 RID: 2900
			// RVA: 0x0000CC54 File Offset: 0x0000AE54
			set;
		}

		// Token: 0x17000201 RID: 513
		public bool? Hidden
		{
			// Token: 0x06000B1B RID: 2843
			// RVA: 0x0000CA70 File Offset: 0x0000AC70
			get;
			// Token: 0x06000B1C RID: 2844
			// RVA: 0x0000CA78 File Offset: 0x0000AC78
			set;
		}

		// Token: 0x170001FD RID: 509
		public string Id
		{
			// Token: 0x06000B13 RID: 2835
			// RVA: 0x0000CA2C File Offset: 0x0000AC2C
			get;
			// Token: 0x06000B14 RID: 2836
			// RVA: 0x0000CA34 File Offset: 0x0000AC34
			set;
		}

		// Token: 0x1700021F RID: 543
		internal string InternalId
		{
			// Token: 0x06000B57 RID: 2903
			// RVA: 0x0000CC6E File Offset: 0x0000AE6E
			get
			{
				return this._internalId;
			}
		}

		// Token: 0x1700020F RID: 527
		public IList<JsonSchema> Items
		{
			// Token: 0x06000B37 RID: 2871
			// RVA: 0x0000CB5E File Offset: 0x0000AD5E
			get;
			// Token: 0x06000B38 RID: 2872
			// RVA: 0x0000CB66 File Offset: 0x0000AD66
			set;
		}

		// Token: 0x1700021E RID: 542
		internal string Location
		{
			// Token: 0x06000B55 RID: 2901
			// RVA: 0x0000CC5D File Offset: 0x0000AE5D
			get;
			// Token: 0x06000B56 RID: 2902
			// RVA: 0x0000CC65 File Offset: 0x0000AE65
			set;
		}

		// Token: 0x1700020A RID: 522
		public double? Maximum
		{
			// Token: 0x06000B2D RID: 2861
			// RVA: 0x0000CB09 File Offset: 0x0000AD09
			get;
			// Token: 0x06000B2E RID: 2862
			// RVA: 0x0000CB11 File Offset: 0x0000AD11
			set;
		}

		// Token: 0x1700020E RID: 526
		public int? MaximumItems
		{
			// Token: 0x06000B35 RID: 2869
			// RVA: 0x0000CB4D File Offset: 0x0000AD4D
			get;
			// Token: 0x06000B36 RID: 2870
			// RVA: 0x0000CB55 File Offset: 0x0000AD55
			set;
		}

		// Token: 0x17000207 RID: 519
		public int? MaximumLength
		{
			// Token: 0x06000B27 RID: 2855
			// RVA: 0x0000CAD6 File Offset: 0x0000ACD6
			get;
			// Token: 0x06000B28 RID: 2856
			// RVA: 0x0000CADE File Offset: 0x0000ACDE
			set;
		}

		// Token: 0x17000209 RID: 521
		public double? Minimum
		{
			// Token: 0x06000B2B RID: 2859
			// RVA: 0x0000CAF8 File Offset: 0x0000ACF8
			get;
			// Token: 0x06000B2C RID: 2860
			// RVA: 0x0000CB00 File Offset: 0x0000AD00
			set;
		}

		// Token: 0x1700020D RID: 525
		public int? MinimumItems
		{
			// Token: 0x06000B33 RID: 2867
			// RVA: 0x0000CB3C File Offset: 0x0000AD3C
			get;
			// Token: 0x06000B34 RID: 2868
			// RVA: 0x0000CB44 File Offset: 0x0000AD44
			set;
		}

		// Token: 0x17000206 RID: 518
		public int? MinimumLength
		{
			// Token: 0x06000B25 RID: 2853
			// RVA: 0x0000CAC5 File Offset: 0x0000ACC5
			get;
			// Token: 0x06000B26 RID: 2854
			// RVA: 0x0000CACD File Offset: 0x0000ACCD
			set;
		}

		// Token: 0x17000205 RID: 517
		public string Pattern
		{
			// Token: 0x06000B23 RID: 2851
			// RVA: 0x0000CAB4 File Offset: 0x0000ACB4
			get;
			// Token: 0x06000B24 RID: 2852
			// RVA: 0x0000CABC File Offset: 0x0000ACBC
			set;
		}

		// Token: 0x17000216 RID: 534
		public IDictionary<string, JsonSchema> PatternProperties
		{
			// Token: 0x06000B45 RID: 2885
			// RVA: 0x0000CBD5 File Offset: 0x0000ADD5
			get;
			// Token: 0x06000B46 RID: 2886
			// RVA: 0x0000CBDD File Offset: 0x0000ADDD
			set;
		}

		// Token: 0x17000210 RID: 528
		public bool PositionalItemsValidation
		{
			// Token: 0x06000B39 RID: 2873
			// RVA: 0x0000CB6F File Offset: 0x0000AD6F
			get;
			// Token: 0x06000B3A RID: 2874
			// RVA: 0x0000CB77 File Offset: 0x0000AD77
			set;
		}

		// Token: 0x17000214 RID: 532
		public IDictionary<string, JsonSchema> Properties
		{
			// Token: 0x06000B41 RID: 2881
			// RVA: 0x0000CBB3 File Offset: 0x0000ADB3
			get;
			// Token: 0x06000B42 RID: 2882
			// RVA: 0x0000CBBB File Offset: 0x0000ADBB
			set;
		}

		// Token: 0x17000200 RID: 512
		public bool? ReadOnly
		{
			// Token: 0x06000B19 RID: 2841
			// RVA: 0x0000CA5F File Offset: 0x0000AC5F
			get;
			// Token: 0x06000B1A RID: 2842
			// RVA: 0x0000CA67 File Offset: 0x0000AC67
			set;
		}

		// Token: 0x17000221 RID: 545
		internal bool ReferencesResolved
		{
			// Token: 0x06000B5A RID: 2906
			// RVA: 0x0000CC87 File Offset: 0x0000AE87
			get;
			// Token: 0x06000B5B RID: 2907
			// RVA: 0x0000CC8F File Offset: 0x0000AE8F
			set;
		}

		// Token: 0x170001FF RID: 511
		public bool? Required
		{
			// Token: 0x06000B17 RID: 2839
			// RVA: 0x0000CA4E File Offset: 0x0000AC4E
			get;
			// Token: 0x06000B18 RID: 2840
			// RVA: 0x0000CA56 File Offset: 0x0000AC56
			set;
		}

		// Token: 0x17000218 RID: 536
		public string Requires
		{
			// Token: 0x06000B49 RID: 2889
			// RVA: 0x0000CBF7 File Offset: 0x0000ADF7
			get;
			// Token: 0x06000B4A RID: 2890
			// RVA: 0x0000CBFF File Offset: 0x0000ADFF
			set;
		}

		// Token: 0x170001FE RID: 510
		public string Title
		{
			// Token: 0x06000B15 RID: 2837
			// RVA: 0x0000CA3D File Offset: 0x0000AC3D
			get;
			// Token: 0x06000B16 RID: 2838
			// RVA: 0x0000CA45 File Offset: 0x0000AC45
			set;
		}

		// Token: 0x17000202 RID: 514
		public bool? Transient
		{
			// Token: 0x06000B1D RID: 2845
			// RVA: 0x0000CA81 File Offset: 0x0000AC81
			get;
			// Token: 0x06000B1E RID: 2846
			// RVA: 0x0000CA89 File Offset: 0x0000AC89
			set;
		}

		// Token: 0x17000204 RID: 516
		public JsonSchemaType? Type
		{
			// Token: 0x06000B21 RID: 2849
			// RVA: 0x0000CAA3 File Offset: 0x0000ACA3
			get;
			// Token: 0x06000B22 RID: 2850
			// RVA: 0x0000CAAB File Offset: 0x0000ACAB
			set;
		}

		// Token: 0x17000213 RID: 531
		public bool UniqueItems
		{
			// Token: 0x06000B3F RID: 2879
			// RVA: 0x0000CBA2 File Offset: 0x0000ADA2
			get;
			// Token: 0x06000B40 RID: 2880
			// RVA: 0x0000CBAA File Offset: 0x0000ADAA
			set;
		}

		// Token: 0x06000B5C RID: 2908
		// RVA: 0x00041B08 File Offset: 0x0003FD08
		public JsonSchema()
		{
			this.AllowAdditionalProperties = true;
			this.AllowAdditionalItems = true;
		}

		// Token: 0x06000B5F RID: 2911
		// RVA: 0x0000CCA5 File Offset: 0x0000AEA5
		public static JsonSchema Parse(string json)
		{
			return JsonSchema.Parse(json, new JsonSchemaResolver());
		}

		// Token: 0x06000B60 RID: 2912
		// RVA: 0x00041B78 File Offset: 0x0003FD78
		public static JsonSchema Parse(string json, JsonSchemaResolver resolver)
		{
			ValidationUtils.ArgumentNotNull(json, "json");
			JsonSchema result;
			using (JsonReader jsonReader = new JsonTextReader(new StringReader(json)))
			{
				result = JsonSchema.Read(jsonReader, resolver);
			}
			return result;
		}

		// Token: 0x06000B5D RID: 2909
		// RVA: 0x0000CC98 File Offset: 0x0000AE98
		public static JsonSchema Read(JsonReader reader)
		{
			return JsonSchema.Read(reader, new JsonSchemaResolver());
		}

		// Token: 0x06000B5E RID: 2910
		// RVA: 0x00041B44 File Offset: 0x0003FD44
		public static JsonSchema Read(JsonReader reader, JsonSchemaResolver resolver)
		{
			ValidationUtils.ArgumentNotNull(reader, "reader");
			ValidationUtils.ArgumentNotNull(resolver, "resolver");
			JsonSchemaBuilder jsonSchemaBuilder = new JsonSchemaBuilder(resolver);
			return jsonSchemaBuilder.Read(reader);
		}

		// Token: 0x06000B63 RID: 2915
		// RVA: 0x00041BF8 File Offset: 0x0003FDF8
		public override string ToString()
		{
			StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
			this.WriteTo(new JsonTextWriter(stringWriter)
			{
				Formatting = Formatting.Indented
			});
			return stringWriter.ToString();
		}

		// Token: 0x06000B61 RID: 2913
		// RVA: 0x0000CCB2 File Offset: 0x0000AEB2
		public void WriteTo(JsonWriter writer)
		{
			this.WriteTo(writer, new JsonSchemaResolver());
		}

		// Token: 0x06000B62 RID: 2914
		// RVA: 0x00041BC4 File Offset: 0x0003FDC4
		public void WriteTo(JsonWriter writer, JsonSchemaResolver resolver)
		{
			ValidationUtils.ArgumentNotNull(writer, "writer");
			ValidationUtils.ArgumentNotNull(resolver, "resolver");
			JsonSchemaWriter jsonSchemaWriter = new JsonSchemaWriter(writer, resolver);
			jsonSchemaWriter.WriteSchema(this);
		}
	}
}
