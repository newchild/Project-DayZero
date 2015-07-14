using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;
using Newtonsoft.Json.Utilities.LinqBridge;
using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020000F3 RID: 243
	internal sealed class JsonSchemaWriter
	{
		// Token: 0x04000418 RID: 1048
		private readonly JsonSchemaResolver _resolver;

		// Token: 0x04000417 RID: 1047
		private readonly JsonWriter _writer;

		// Token: 0x06000A0A RID: 2570
		// RVA: 0x0000C0F3 File Offset: 0x0000A2F3
		public JsonSchemaWriter(JsonWriter writer, JsonSchemaResolver resolver)
		{
			ValidationUtils.ArgumentNotNull(writer, "writer");
			this._writer = writer;
			this._resolver = resolver;
		}

		// Token: 0x06000A0B RID: 2571
		// RVA: 0x0003F18C File Offset: 0x0003D38C
		private void ReferenceOrWriteSchema(JsonSchema schema)
		{
			if (schema.Id != null && this._resolver.GetSchema(schema.Id) != null)
			{
				this._writer.WriteStartObject();
				this._writer.WritePropertyName("$ref");
				this._writer.WriteValue(schema.Id);
				this._writer.WriteEndObject();
				return;
			}
			this.WriteSchema(schema);
		}

		// Token: 0x06000A0E RID: 2574
		// RVA: 0x0003F720 File Offset: 0x0003D920
		private void WriteItems(JsonSchema schema)
		{
			if (schema.Items == null && !schema.PositionalItemsValidation)
			{
				return;
			}
			this._writer.WritePropertyName("items");
			if (schema.PositionalItemsValidation)
			{
				this._writer.WriteStartArray();
				if (schema.Items != null)
				{
					foreach (JsonSchema current in schema.Items)
					{
						this.ReferenceOrWriteSchema(current);
					}
				}
				this._writer.WriteEndArray();
				return;
			}
			if (schema.Items != null && schema.Items.Count > 0)
			{
				this.ReferenceOrWriteSchema(schema.Items[0]);
				return;
			}
			this._writer.WriteStartObject();
			this._writer.WriteEndObject();
		}

		// Token: 0x06000A10 RID: 2576
		// RVA: 0x0000C114 File Offset: 0x0000A314
		private void WritePropertyIfNotNull(JsonWriter writer, string propertyName, object value)
		{
			if (value != null)
			{
				writer.WritePropertyName(propertyName);
				writer.WriteValue(value);
			}
		}

		// Token: 0x06000A0C RID: 2572
		// RVA: 0x0003F1F4 File Offset: 0x0003D3F4
		public void WriteSchema(JsonSchema schema)
		{
			ValidationUtils.ArgumentNotNull(schema, "schema");
			if (!this._resolver.LoadedSchemas.Contains(schema))
			{
				this._resolver.LoadedSchemas.Add(schema);
			}
			this._writer.WriteStartObject();
			this.WritePropertyIfNotNull(this._writer, "id", schema.Id);
			this.WritePropertyIfNotNull(this._writer, "title", schema.Title);
			this.WritePropertyIfNotNull(this._writer, "description", schema.Description);
			this.WritePropertyIfNotNull(this._writer, "required", schema.Required);
			this.WritePropertyIfNotNull(this._writer, "readonly", schema.ReadOnly);
			this.WritePropertyIfNotNull(this._writer, "hidden", schema.Hidden);
			this.WritePropertyIfNotNull(this._writer, "transient", schema.Transient);
			if (schema.Type.HasValue)
			{
				this.WriteType("type", this._writer, schema.Type.Value);
			}
			if (!schema.AllowAdditionalProperties)
			{
				this._writer.WritePropertyName("additionalProperties");
				this._writer.WriteValue(schema.AllowAdditionalProperties);
			}
			else if (schema.AdditionalProperties != null)
			{
				this._writer.WritePropertyName("additionalProperties");
				this.ReferenceOrWriteSchema(schema.AdditionalProperties);
			}
			if (!schema.AllowAdditionalItems)
			{
				this._writer.WritePropertyName("additionalItems");
				this._writer.WriteValue(schema.AllowAdditionalItems);
			}
			else if (schema.AdditionalItems != null)
			{
				this._writer.WritePropertyName("additionalItems");
				this.ReferenceOrWriteSchema(schema.AdditionalItems);
			}
			this.WriteSchemaDictionaryIfNotNull(this._writer, "properties", schema.Properties);
			this.WriteSchemaDictionaryIfNotNull(this._writer, "patternProperties", schema.PatternProperties);
			this.WriteItems(schema);
			this.WritePropertyIfNotNull(this._writer, "minimum", schema.Minimum);
			this.WritePropertyIfNotNull(this._writer, "maximum", schema.Maximum);
			this.WritePropertyIfNotNull(this._writer, "exclusiveMinimum", schema.ExclusiveMinimum);
			this.WritePropertyIfNotNull(this._writer, "exclusiveMaximum", schema.ExclusiveMaximum);
			this.WritePropertyIfNotNull(this._writer, "minLength", schema.MinimumLength);
			this.WritePropertyIfNotNull(this._writer, "maxLength", schema.MaximumLength);
			this.WritePropertyIfNotNull(this._writer, "minItems", schema.MinimumItems);
			this.WritePropertyIfNotNull(this._writer, "maxItems", schema.MaximumItems);
			this.WritePropertyIfNotNull(this._writer, "divisibleBy", schema.DivisibleBy);
			this.WritePropertyIfNotNull(this._writer, "format", schema.Format);
			this.WritePropertyIfNotNull(this._writer, "pattern", schema.Pattern);
			if (schema.Enum != null)
			{
				this._writer.WritePropertyName("enum");
				this._writer.WriteStartArray();
				foreach (JToken current in schema.Enum)
				{
					current.WriteTo(this._writer, new JsonConverter[0]);
				}
				this._writer.WriteEndArray();
			}
			if (schema.Default != null)
			{
				this._writer.WritePropertyName("default");
				schema.Default.WriteTo(this._writer, new JsonConverter[0]);
			}
			if (schema.Disallow.HasValue)
			{
				this.WriteType("disallow", this._writer, schema.Disallow.Value);
			}
			if (schema.Extends != null && schema.Extends.Count > 0)
			{
				this._writer.WritePropertyName("extends");
				if (schema.Extends.Count == 1)
				{
					this.ReferenceOrWriteSchema(schema.Extends[0]);
				}
				else
				{
					this._writer.WriteStartArray();
					foreach (JsonSchema current2 in schema.Extends)
					{
						this.ReferenceOrWriteSchema(current2);
					}
					this._writer.WriteEndArray();
				}
			}
			this._writer.WriteEndObject();
		}

		// Token: 0x06000A0D RID: 2573
		// RVA: 0x0003F6AC File Offset: 0x0003D8AC
		private void WriteSchemaDictionaryIfNotNull(JsonWriter writer, string propertyName, IDictionary<string, JsonSchema> properties)
		{
			if (properties != null)
			{
				writer.WritePropertyName(propertyName);
				writer.WriteStartObject();
				foreach (KeyValuePair<string, JsonSchema> current in properties)
				{
					writer.WritePropertyName(current.Key);
					this.ReferenceOrWriteSchema(current.Value);
				}
				writer.WriteEndObject();
			}
		}

		// Token: 0x06000A0F RID: 2575
		// RVA: 0x0003F7F8 File Offset: 0x0003D9F8
		private void WriteType(string propertyName, JsonWriter writer, JsonSchemaType type)
		{
			IList<JsonSchemaType> list;
			if (Enum.IsDefined(typeof(JsonSchemaType), type))
			{
				list = new List<JsonSchemaType>
				{
					type
				};
			}
			else
			{
				list = Enumerable.ToList<JsonSchemaType>(Enumerable.Where<JsonSchemaType>(EnumUtils.GetFlagsValues<JsonSchemaType>(type), (JsonSchemaType v) => v != JsonSchemaType.None));
			}
			if (list.Count == 0)
			{
				return;
			}
			writer.WritePropertyName(propertyName);
			if (list.Count == 1)
			{
				writer.WriteValue(JsonSchemaBuilder.MapType(list[0]));
				return;
			}
			writer.WriteStartArray();
			foreach (JsonSchemaType current in list)
			{
				writer.WriteValue(JsonSchemaBuilder.MapType(current));
			}
			writer.WriteEndArray();
		}
	}
}
