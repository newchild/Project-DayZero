using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000119 RID: 281
	internal static class JsonSchemaConstants
	{
		// Token: 0x040004C9 RID: 1225
		public const string AdditionalItemsPropertyName = "additionalItems";

		// Token: 0x040004CC RID: 1228
		public const string AdditionalPropertiesPropertyName = "additionalProperties";

		// Token: 0x040004DC RID: 1244
		public const string DefaultPropertyName = "default";

		// Token: 0x040004DA RID: 1242
		public const string DescriptionPropertyName = "description";

		// Token: 0x040004E0 RID: 1248
		public const string DisallowPropertyName = "disallow";

		// Token: 0x040004DE RID: 1246
		public const string DivisibleByPropertyName = "divisibleBy";

		// Token: 0x040004D7 RID: 1239
		public const string EnumPropertyName = "enum";

		// Token: 0x040004D1 RID: 1233
		public const string ExclusiveMaximumPropertyName = "exclusiveMaximum";

		// Token: 0x040004D0 RID: 1232
		public const string ExclusiveMinimumPropertyName = "exclusiveMinimum";

		// Token: 0x040004E1 RID: 1249
		public const string ExtendsPropertyName = "extends";

		// Token: 0x040004DB RID: 1243
		public const string FormatPropertyName = "format";

		// Token: 0x040004DF RID: 1247
		public const string HiddenPropertyName = "hidden";

		// Token: 0x040004E2 RID: 1250
		public const string IdPropertyName = "id";

		// Token: 0x040004C8 RID: 1224
		public const string ItemsPropertyName = "items";

		// Token: 0x040004E6 RID: 1254
		public static readonly IDictionary<string, JsonSchemaType> JsonSchemaTypeMapping = new Dictionary<string, JsonSchemaType>
		{
			{
				"string",
				JsonSchemaType.String
			},
			{
				"object",
				JsonSchemaType.Object
			},
			{
				"integer",
				JsonSchemaType.Integer
			},
			{
				"number",
				JsonSchemaType.Float
			},
			{
				"null",
				JsonSchemaType.Null
			},
			{
				"boolean",
				JsonSchemaType.Boolean
			},
			{
				"array",
				JsonSchemaType.Array
			},
			{
				"any",
				JsonSchemaType.Any
			}
		};

		// Token: 0x040004D3 RID: 1235
		public const string MaximumItemsPropertyName = "maxItems";

		// Token: 0x040004D5 RID: 1237
		public const string MaximumLengthPropertyName = "maxLength";

		// Token: 0x040004CF RID: 1231
		public const string MaximumPropertyName = "maximum";

		// Token: 0x040004D2 RID: 1234
		public const string MinimumItemsPropertyName = "minItems";

		// Token: 0x040004D6 RID: 1238
		public const string MinimumLengthPropertyName = "minLength";

		// Token: 0x040004CE RID: 1230
		public const string MinimumPropertyName = "minimum";

		// Token: 0x040004E5 RID: 1253
		public const string OptionLabelPropertyName = "label";

		// Token: 0x040004E4 RID: 1252
		public const string OptionValuePropertyName = "value";

		// Token: 0x040004CB RID: 1227
		public const string PatternPropertiesPropertyName = "patternProperties";

		// Token: 0x040004D4 RID: 1236
		public const string PatternPropertyName = "pattern";

		// Token: 0x040004C7 RID: 1223
		public const string PropertiesPropertyName = "properties";

		// Token: 0x040004D8 RID: 1240
		public const string ReadOnlyPropertyName = "readonly";

		// Token: 0x040004CA RID: 1226
		public const string RequiredPropertyName = "required";

		// Token: 0x040004CD RID: 1229
		public const string RequiresPropertyName = "requires";

		// Token: 0x040004D9 RID: 1241
		public const string TitlePropertyName = "title";

		// Token: 0x040004DD RID: 1245
		public const string TransientPropertyName = "transient";

		// Token: 0x040004C6 RID: 1222
		public const string TypePropertyName = "type";

		// Token: 0x040004E3 RID: 1251
		public const string UniqueItemsPropertyName = "uniqueItems";
	}
}
