using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;
using Newtonsoft.Json.Utilities.LinqBridge;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000117 RID: 279
	internal sealed class JsonSchemaBuilder
	{
		// Token: 0x040004C3 RID: 1219
		private JsonSchema _currentSchema;

		// Token: 0x040004C2 RID: 1218
		private readonly IDictionary<string, JsonSchema> _documentSchemas;

		// Token: 0x040004C1 RID: 1217
		private readonly JsonSchemaResolver _resolver;

		// Token: 0x040004C4 RID: 1220
		private JObject _rootSchema;

		// Token: 0x040004C0 RID: 1216
		private readonly IList<JsonSchema> _stack;

		// Token: 0x17000222 RID: 546
		private JsonSchema CurrentSchema
		{
			// Token: 0x06000B67 RID: 2919
			// RVA: 0x0000CD1D File Offset: 0x0000AF1D
			get
			{
				return this._currentSchema;
			}
		}

		// Token: 0x06000B64 RID: 2916
		// RVA: 0x0000CCC0 File Offset: 0x0000AEC0
		public JsonSchemaBuilder(JsonSchemaResolver resolver)
		{
			this._stack = new List<JsonSchema>();
			this._documentSchemas = new Dictionary<string, JsonSchema>();
			this._resolver = resolver;
		}

		// Token: 0x06000B6B RID: 2923
		// RVA: 0x00041F80 File Offset: 0x00040180
		private JsonSchema BuildSchema(JToken token)
		{
			JObject jObject = token as JObject;
			if (jObject == null)
			{
				throw JsonException.Create(token, token.Path, StringUtils.FormatWith("Expected object while parsing schema object, got {0}.", CultureInfo.InvariantCulture, token.Type));
			}
			JToken value;
			if (jObject.TryGetValue("$ref", out value))
			{
				return new JsonSchema
				{
					DeferredReference = (string)value
				};
			}
			string text = token.Path.Replace(".", "/").Replace("[", "/").Replace("]", string.Empty);
			if (!string.IsNullOrEmpty(text))
			{
				text = "/" + text;
			}
			text = "#" + text;
			JsonSchema result;
			if (this._documentSchemas.TryGetValue(text, out result))
			{
				return result;
			}
			this.Push(new JsonSchema
			{
				Location = text
			});
			this.ProcessSchemaProperties(jObject);
			return this.Pop();
		}

		// Token: 0x06000B74 RID: 2932
		// RVA: 0x000429CC File Offset: 0x00040BCC
		internal static JsonSchemaType MapType(string type)
		{
			JsonSchemaType result;
			if (!JsonSchemaConstants.JsonSchemaTypeMapping.TryGetValue(type, out result))
			{
				throw new JsonException(StringUtils.FormatWith("Invalid JSON schema type: {0}", CultureInfo.InvariantCulture, type));
			}
			return result;
		}

		// Token: 0x06000B75 RID: 2933
		// RVA: 0x00042A00 File Offset: 0x00040C00
		internal static string MapType(JsonSchemaType type)
		{
			return Enumerable.Single<KeyValuePair<string, JsonSchemaType>>(JsonSchemaConstants.JsonSchemaTypeMapping, (KeyValuePair<string, JsonSchemaType> kv) => kv.Value == type).Key;
		}

		// Token: 0x06000B66 RID: 2918
		// RVA: 0x00041C2C File Offset: 0x0003FE2C
		private JsonSchema Pop()
		{
			JsonSchema currentSchema = this._currentSchema;
			this._stack.RemoveAt(this._stack.Count - 1);
			this._currentSchema = Enumerable.LastOrDefault<JsonSchema>(this._stack);
			return currentSchema;
		}

		// Token: 0x06000B70 RID: 2928
		// RVA: 0x0000CD7B File Offset: 0x0000AF7B
		private void ProcessAdditionalItems(JToken token)
		{
			if (token.Type == JTokenType.Boolean)
			{
				this.CurrentSchema.AllowAdditionalItems = (bool)token;
				return;
			}
			this.CurrentSchema.AdditionalItems = this.BuildSchema(token);
		}

		// Token: 0x06000B6F RID: 2927
		// RVA: 0x0000CD4B File Offset: 0x0000AF4B
		private void ProcessAdditionalProperties(JToken token)
		{
			if (token.Type == JTokenType.Boolean)
			{
				this.CurrentSchema.AllowAdditionalProperties = (bool)token;
				return;
			}
			this.CurrentSchema.AdditionalProperties = this.BuildSchema(token);
		}

		// Token: 0x06000B6E RID: 2926
		// RVA: 0x0004269C File Offset: 0x0004089C
		private void ProcessEnum(JToken token)
		{
			if (token.Type != JTokenType.Array)
			{
				throw JsonException.Create(token, token.Path, StringUtils.FormatWith("Expected Array token while parsing enum values, got {0}.", CultureInfo.InvariantCulture, token.Type));
			}
			this.CurrentSchema.Enum = new List<JToken>();
			foreach (JToken current in ((IEnumerable<JToken>)token))
			{
				this.CurrentSchema.Enum.Add(current.DeepClone());
			}
		}

		// Token: 0x06000B6D RID: 2925
		// RVA: 0x00042614 File Offset: 0x00040814
		private void ProcessExtends(JToken token)
		{
			IList<JsonSchema> list = new List<JsonSchema>();
			if (token.Type == JTokenType.Array)
			{
				using (IEnumerator<JToken> enumerator = ((IEnumerable<JToken>)token).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						JToken current = enumerator.Current;
						list.Add(this.BuildSchema(current));
					}
					goto IL_53;
				}
			}
			JsonSchema jsonSchema = this.BuildSchema(token);
			if (jsonSchema != null)
			{
				list.Add(jsonSchema);
			}
			IL_53:
			if (list.Count > 0)
			{
				this.CurrentSchema.Extends = list;
			}
		}

		// Token: 0x06000B72 RID: 2930
		// RVA: 0x000427F8 File Offset: 0x000409F8
		private void ProcessItems(JToken token)
		{
			this.CurrentSchema.Items = new List<JsonSchema>();
			switch (token.Type)
			{
			case JTokenType.Object:
				this.CurrentSchema.Items.Add(this.BuildSchema(token));
				this.CurrentSchema.PositionalItemsValidation = false;
				return;
			case JTokenType.Array:
				this.CurrentSchema.PositionalItemsValidation = true;
				foreach (JToken current in ((IEnumerable<JToken>)token))
				{
					this.CurrentSchema.Items.Add(this.BuildSchema(current));
				}
				return;
			default:
				throw JsonException.Create(token, token.Path, StringUtils.FormatWith("Expected array or JSON schema object, got {0}.", CultureInfo.InvariantCulture, token.Type));
			}
		}

		// Token: 0x06000B71 RID: 2929
		// RVA: 0x00042734 File Offset: 0x00040934
		private IDictionary<string, JsonSchema> ProcessProperties(JToken token)
		{
			IDictionary<string, JsonSchema> dictionary = new Dictionary<string, JsonSchema>();
			if (token.Type != JTokenType.Object)
			{
				throw JsonException.Create(token, token.Path, StringUtils.FormatWith("Expected Object token while parsing schema properties, got {0}.", CultureInfo.InvariantCulture, token.Type));
			}
			using (IEnumerator<JToken> enumerator = ((IEnumerable<JToken>)token).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					JProperty jProperty = (JProperty)enumerator.Current;
					if (dictionary.ContainsKey(jProperty.Name))
					{
						throw new JsonException(StringUtils.FormatWith("Property {0} has already been defined in schema.", CultureInfo.InvariantCulture, jProperty.Name));
					}
					dictionary.Add(jProperty.Name, this.BuildSchema(jProperty.Value));
				}
			}
			return dictionary;
		}

		// Token: 0x06000B6C RID: 2924
		// RVA: 0x0004206C File Offset: 0x0004026C
		private void ProcessSchemaProperties(JObject schemaObject)
		{
			foreach (KeyValuePair<string, JToken> current in schemaObject)
			{
				string key;
				switch (key = current.Key)
				{
				case "type":
					this.CurrentSchema.Type = this.ProcessType(current.Value);
					break;
				case "id":
					this.CurrentSchema.Id = (string)current.Value;
					break;
				case "title":
					this.CurrentSchema.Title = (string)current.Value;
					break;
				case "description":
					this.CurrentSchema.Description = (string)current.Value;
					break;
				case "properties":
					this.CurrentSchema.Properties = this.ProcessProperties(current.Value);
					break;
				case "items":
					this.ProcessItems(current.Value);
					break;
				case "additionalProperties":
					this.ProcessAdditionalProperties(current.Value);
					break;
				case "additionalItems":
					this.ProcessAdditionalItems(current.Value);
					break;
				case "patternProperties":
					this.CurrentSchema.PatternProperties = this.ProcessProperties(current.Value);
					break;
				case "required":
					this.CurrentSchema.Required = new bool?((bool)current.Value);
					break;
				case "requires":
					this.CurrentSchema.Requires = (string)current.Value;
					break;
				case "minimum":
					this.CurrentSchema.Minimum = new double?((double)current.Value);
					break;
				case "maximum":
					this.CurrentSchema.Maximum = new double?((double)current.Value);
					break;
				case "exclusiveMinimum":
					this.CurrentSchema.ExclusiveMinimum = new bool?((bool)current.Value);
					break;
				case "exclusiveMaximum":
					this.CurrentSchema.ExclusiveMaximum = new bool?((bool)current.Value);
					break;
				case "maxLength":
					this.CurrentSchema.MaximumLength = new int?((int)current.Value);
					break;
				case "minLength":
					this.CurrentSchema.MinimumLength = new int?((int)current.Value);
					break;
				case "maxItems":
					this.CurrentSchema.MaximumItems = new int?((int)current.Value);
					break;
				case "minItems":
					this.CurrentSchema.MinimumItems = new int?((int)current.Value);
					break;
				case "divisibleBy":
					this.CurrentSchema.DivisibleBy = new double?((double)current.Value);
					break;
				case "disallow":
					this.CurrentSchema.Disallow = this.ProcessType(current.Value);
					break;
				case "default":
					this.CurrentSchema.Default = current.Value.DeepClone();
					break;
				case "hidden":
					this.CurrentSchema.Hidden = new bool?((bool)current.Value);
					break;
				case "readonly":
					this.CurrentSchema.ReadOnly = new bool?((bool)current.Value);
					break;
				case "format":
					this.CurrentSchema.Format = (string)current.Value;
					break;
				case "pattern":
					this.CurrentSchema.Pattern = (string)current.Value;
					break;
				case "enum":
					this.ProcessEnum(current.Value);
					break;
				case "extends":
					this.ProcessExtends(current.Value);
					break;
				case "uniqueItems":
					this.CurrentSchema.UniqueItems = (bool)current.Value;
					break;
				}
			}
		}

		// Token: 0x06000B73 RID: 2931
		// RVA: 0x000428D0 File Offset: 0x00040AD0
		private JsonSchemaType? ProcessType(JToken token)
		{
			JTokenType type = token.Type;
			if (type == JTokenType.Array)
			{
				JsonSchemaType? jsonSchemaType = new JsonSchemaType?(JsonSchemaType.None);
				foreach (JToken current in ((IEnumerable<JToken>)token))
				{
					if (current.Type != JTokenType.String)
					{
						throw JsonException.Create(current, current.Path, StringUtils.FormatWith("Exception JSON schema type string token, got {0}.", CultureInfo.InvariantCulture, token.Type));
					}
					jsonSchemaType |= JsonSchemaBuilder.MapType((string)current);
				}
				return jsonSchemaType;
			}
			if (type != JTokenType.String)
			{
				throw JsonException.Create(token, token.Path, StringUtils.FormatWith("Expected array or JSON schema type string token, got {0}.", CultureInfo.InvariantCulture, token.Type));
			}
			return new JsonSchemaType?(JsonSchemaBuilder.MapType((string)token));
		}

		// Token: 0x06000B65 RID: 2917
		// RVA: 0x0000CCE5 File Offset: 0x0000AEE5
		private void Push(JsonSchema value)
		{
			this._currentSchema = value;
			this._stack.Add(value);
			this._resolver.LoadedSchemas.Add(value);
			this._documentSchemas.Add(value.Location, value);
		}

		// Token: 0x06000B68 RID: 2920
		// RVA: 0x00041C6C File Offset: 0x0003FE6C
		internal JsonSchema Read(JsonReader reader)
		{
			JToken jToken = JToken.ReadFrom(reader);
			this._rootSchema = (jToken as JObject);
			JsonSchema jsonSchema = this.BuildSchema(jToken);
			this.ResolveReferences(jsonSchema);
			return jsonSchema;
		}

		// Token: 0x06000B6A RID: 2922
		// RVA: 0x00041CA0 File Offset: 0x0003FEA0
		private JsonSchema ResolveReferences(JsonSchema schema)
		{
			if (schema.DeferredReference != null)
			{
				string text = schema.DeferredReference;
				bool flag;
				if (flag = text.StartsWith("#", StringComparison.Ordinal))
				{
					text = this.UnescapeReference(text);
				}
				JsonSchema jsonSchema = this._resolver.GetSchema(text);
				if (jsonSchema == null)
				{
					if (flag)
					{
						string[] array = schema.DeferredReference.TrimStart(new char[]
						{
							'#'
						}).Split(new char[]
						{
							'/'
						}, StringSplitOptions.RemoveEmptyEntries);
						JToken jToken = this._rootSchema;
						string[] array2 = array;
						for (int i = 0; i < array2.Length; i++)
						{
							string reference = array2[i];
							string text2 = this.UnescapeReference(reference);
							if (jToken.Type == JTokenType.Object)
							{
								jToken = jToken[text2];
							}
							else if (jToken.Type == JTokenType.Array || jToken.Type == JTokenType.Constructor)
							{
								int num;
								if (int.TryParse(text2, out num) && num >= 0 && num < Enumerable.Count<JToken>(jToken))
								{
									jToken = jToken[num];
								}
								else
								{
									jToken = null;
								}
							}
							if (jToken == null)
							{
								break;
							}
						}
						if (jToken != null)
						{
							jsonSchema = this.BuildSchema(jToken);
						}
					}
					if (jsonSchema == null)
					{
						throw new JsonException(StringUtils.FormatWith("Could not resolve schema reference '{0}'.", CultureInfo.InvariantCulture, schema.DeferredReference));
					}
				}
				schema = jsonSchema;
			}
			if (schema.ReferencesResolved)
			{
				return schema;
			}
			schema.ReferencesResolved = true;
			if (schema.Extends != null)
			{
				for (int j = 0; j < schema.Extends.Count; j++)
				{
					schema.Extends[j] = this.ResolveReferences(schema.Extends[j]);
				}
			}
			if (schema.Items != null)
			{
				for (int k = 0; k < schema.Items.Count; k++)
				{
					schema.Items[k] = this.ResolveReferences(schema.Items[k]);
				}
			}
			if (schema.AdditionalItems != null)
			{
				schema.AdditionalItems = this.ResolveReferences(schema.AdditionalItems);
			}
			if (schema.PatternProperties != null)
			{
				foreach (KeyValuePair<string, JsonSchema> current in Enumerable.ToList<KeyValuePair<string, JsonSchema>>(schema.PatternProperties))
				{
					schema.PatternProperties[current.Key] = this.ResolveReferences(current.Value);
				}
			}
			if (schema.Properties != null)
			{
				foreach (KeyValuePair<string, JsonSchema> current2 in Enumerable.ToList<KeyValuePair<string, JsonSchema>>(schema.Properties))
				{
					schema.Properties[current2.Key] = this.ResolveReferences(current2.Value);
				}
			}
			if (schema.AdditionalProperties != null)
			{
				schema.AdditionalProperties = this.ResolveReferences(schema.AdditionalProperties);
			}
			return schema;
		}

		// Token: 0x06000B69 RID: 2921
		// RVA: 0x0000CD25 File Offset: 0x0000AF25
		private string UnescapeReference(string reference)
		{
			return Uri.UnescapeDataString(reference).Replace("~1", "/").Replace("~0", "~");
		}
	}
}
