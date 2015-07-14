using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;
using Newtonsoft.Json.Utilities.LinqBridge;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x0200011A RID: 282
	public sealed class JsonSchemaGenerator
	{
		// Token: 0x0200011B RID: 283
		private sealed class TypeSchema
		{
			// Token: 0x17000227 RID: 551
			public JsonSchema Schema
			{
				// Token: 0x06000B91 RID: 2961
				// RVA: 0x0000CEB9 File Offset: 0x0000B0B9
				get;
				// Token: 0x06000B92 RID: 2962
				// RVA: 0x0000CEC1 File Offset: 0x0000B0C1
				private set;
			}

			// Token: 0x17000226 RID: 550
			public Type Type
			{
				// Token: 0x06000B8F RID: 2959
				// RVA: 0x0000CEA8 File Offset: 0x0000B0A8
				get;
				// Token: 0x06000B90 RID: 2960
				// RVA: 0x0000CEB0 File Offset: 0x0000B0B0
				private set;
			}

			// Token: 0x06000B93 RID: 2963
			// RVA: 0x0000CECA File Offset: 0x0000B0CA
			public TypeSchema(Type type, JsonSchema schema)
			{
				ValidationUtils.ArgumentNotNull(type, "type");
				ValidationUtils.ArgumentNotNull(schema, "schema");
				this.Type = type;
				this.Schema = schema;
			}
		}

		// Token: 0x040004E7 RID: 1255
		private IContractResolver _contractResolver;

		// Token: 0x040004EA RID: 1258
		private JsonSchema _currentSchema;

		// Token: 0x040004E8 RID: 1256
		private JsonSchemaResolver _resolver;

		// Token: 0x040004E9 RID: 1257
		private readonly IList<JsonSchemaGenerator.TypeSchema> _stack = new List<JsonSchemaGenerator.TypeSchema>();

		// Token: 0x17000224 RID: 548
		public IContractResolver ContractResolver
		{
			// Token: 0x06000B7B RID: 2939
			// RVA: 0x0000CDCD File Offset: 0x0000AFCD
			get
			{
				if (this._contractResolver == null)
				{
					return DefaultContractResolver.Instance;
				}
				return this._contractResolver;
			}
			// Token: 0x06000B7C RID: 2940
			// RVA: 0x0000CDE3 File Offset: 0x0000AFE3
			set
			{
				this._contractResolver = value;
			}
		}

		// Token: 0x17000225 RID: 549
		private JsonSchema CurrentSchema
		{
			// Token: 0x06000B7D RID: 2941
			// RVA: 0x0000CDEC File Offset: 0x0000AFEC
			get
			{
				return this._currentSchema;
			}
		}

		// Token: 0x17000223 RID: 547
		public UndefinedSchemaIdHandling UndefinedSchemaIdHandling
		{
			// Token: 0x06000B79 RID: 2937
			// RVA: 0x0000CDBC File Offset: 0x0000AFBC
			get;
			// Token: 0x06000B7A RID: 2938
			// RVA: 0x0000CDC4 File Offset: 0x0000AFC4
			set;
		}

		// Token: 0x06000B88 RID: 2952
		// RVA: 0x0000CE7B File Offset: 0x0000B07B
		private JsonSchemaType AddNullType(JsonSchemaType type, Required valueRequired)
		{
			if (valueRequired != Required.Always)
			{
				return type | JsonSchemaType.Null;
			}
			return type;
		}

		// Token: 0x06000B80 RID: 2944
		// RVA: 0x0000CE24 File Offset: 0x0000B024
		public JsonSchema Generate(Type type)
		{
			return this.Generate(type, new JsonSchemaResolver(), false);
		}

		// Token: 0x06000B81 RID: 2945
		// RVA: 0x0000CE33 File Offset: 0x0000B033
		public JsonSchema Generate(Type type, JsonSchemaResolver resolver)
		{
			return this.Generate(type, resolver, false);
		}

		// Token: 0x06000B82 RID: 2946
		// RVA: 0x0000CE3E File Offset: 0x0000B03E
		public JsonSchema Generate(Type type, bool rootSchemaNullable)
		{
			return this.Generate(type, new JsonSchemaResolver(), rootSchemaNullable);
		}

		// Token: 0x06000B83 RID: 2947
		// RVA: 0x0000CE4D File Offset: 0x0000B04D
		public JsonSchema Generate(Type type, JsonSchemaResolver resolver, bool rootSchemaNullable)
		{
			ValidationUtils.ArgumentNotNull(type, "type");
			ValidationUtils.ArgumentNotNull(resolver, "resolver");
			this._resolver = resolver;
			return this.GenerateInternal(type, (!rootSchemaNullable) ? Required.Always : Required.Default, false);
		}

		// Token: 0x06000B87 RID: 2951
		// RVA: 0x00042BE0 File Offset: 0x00040DE0
		private JsonSchema GenerateInternal(Type type, Required valueRequired, bool required)
		{
			ValidationUtils.ArgumentNotNull(type, "type");
			string typeId = this.GetTypeId(type, false);
			string typeId2 = this.GetTypeId(type, true);
			if (!string.IsNullOrEmpty(typeId))
			{
				JsonSchema schema = this._resolver.GetSchema(typeId);
				if (schema != null)
				{
					if (valueRequired != Required.Always && !JsonSchemaGenerator.HasFlag(schema.Type, JsonSchemaType.Null))
					{
						schema.Type |= JsonSchemaType.Null;
					}
					if (required && schema.Required != true)
					{
						schema.Required = new bool?(true);
					}
					return schema;
				}
			}
			if (Enumerable.Any<JsonSchemaGenerator.TypeSchema>(this._stack, (JsonSchemaGenerator.TypeSchema tc) => tc.Type == type))
			{
				throw new JsonException(StringUtils.FormatWith("Unresolved circular reference for type '{0}'. Explicitly define an Id for the type using a JsonObject/JsonArray attribute or automatically generate a type Id using the UndefinedSchemaIdHandling property.", CultureInfo.InvariantCulture, type));
			}
			JsonContract jsonContract = this.ContractResolver.ResolveContract(type);
			JsonConverter jsonConverter;
			if ((jsonConverter = jsonContract.Converter) != null || (jsonConverter = jsonContract.InternalConverter) != null)
			{
				JsonSchema schema2 = jsonConverter.GetSchema();
				if (schema2 != null)
				{
					return schema2;
				}
			}
			this.Push(new JsonSchemaGenerator.TypeSchema(type, new JsonSchema()));
			if (typeId2 != null)
			{
				this.CurrentSchema.Id = typeId2;
			}
			if (required)
			{
				this.CurrentSchema.Required = new bool?(true);
			}
			this.CurrentSchema.Title = this.GetTitle(type);
			this.CurrentSchema.Description = this.GetDescription(type);
			if (jsonConverter == null)
			{
				switch (jsonContract.ContractType)
				{
				case JsonContractType.Object:
					this.CurrentSchema.Type = new JsonSchemaType?(this.AddNullType(JsonSchemaType.Object, valueRequired));
					this.CurrentSchema.Id = this.GetTypeId(type, false);
					this.GenerateObjectSchema(type, (JsonObjectContract)jsonContract);
					goto IL_4C4;
				case JsonContractType.Array:
				{
					this.CurrentSchema.Type = new JsonSchemaType?(this.AddNullType(JsonSchemaType.Array, valueRequired));
					this.CurrentSchema.Id = this.GetTypeId(type, false);
					JsonArrayAttribute cachedAttribute = JsonTypeReflector.GetCachedAttribute<JsonArrayAttribute>(type);
					bool flag = cachedAttribute == null || cachedAttribute.AllowNullItems;
					Type collectionItemType = ReflectionUtils.GetCollectionItemType(type);
					if (collectionItemType != null)
					{
						this.CurrentSchema.Items = new List<JsonSchema>();
						this.CurrentSchema.Items.Add(this.GenerateInternal(collectionItemType, (!flag) ? Required.Always : Required.Default, false));
						goto IL_4C4;
					}
					goto IL_4C4;
				}
				case JsonContractType.Primitive:
				{
					this.CurrentSchema.Type = new JsonSchemaType?(this.GetJsonSchemaType(type, valueRequired));
					if (!(this.CurrentSchema.Type == JsonSchemaType.Integer) || !TypeExtensions.IsEnum(type) || type.IsDefined(typeof(FlagsAttribute), true))
					{
						goto IL_4C4;
					}
					this.CurrentSchema.Enum = new List<JToken>();
					IList<EnumValue<long>> namesAndValues = EnumUtils.GetNamesAndValues<long>(type);
					using (IEnumerator<EnumValue<long>> enumerator = namesAndValues.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							EnumValue<long> current = enumerator.Current;
							JToken item = JToken.FromObject(current.Value);
							this.CurrentSchema.Enum.Add(item);
						}
						goto IL_4C4;
					}
					break;
				}
				case JsonContractType.String:
					break;
				case JsonContractType.Dictionary:
				{
					this.CurrentSchema.Type = new JsonSchemaType?(this.AddNullType(JsonSchemaType.Object, valueRequired));
					Type type2;
					Type type3;
					ReflectionUtils.GetDictionaryKeyValueTypes(type, out type2, out type3);
					if (type2 == null)
					{
						goto IL_4C4;
					}
					JsonContract jsonContract2 = this.ContractResolver.ResolveContract(type2);
					if (jsonContract2.ContractType == JsonContractType.Primitive)
					{
						this.CurrentSchema.AdditionalProperties = this.GenerateInternal(type3, Required.Default, false);
						goto IL_4C4;
					}
					goto IL_4C4;
				}
				case JsonContractType.Dynamic:
					goto IL_455;
				case JsonContractType.Serializable:
					this.CurrentSchema.Type = new JsonSchemaType?(this.AddNullType(JsonSchemaType.Object, valueRequired));
					this.CurrentSchema.Id = this.GetTypeId(type, false);
					this.GenerateISerializableContract(type, (JsonISerializableContract)jsonContract);
					goto IL_4C4;
				case JsonContractType.Linq:
					this.CurrentSchema.Type = new JsonSchemaType?(JsonSchemaType.Any);
					goto IL_4C4;
				default:
					goto IL_455;
				}
				JsonSchemaType value = (!ReflectionUtils.IsNullable(jsonContract.UnderlyingType)) ? JsonSchemaType.String : this.AddNullType(JsonSchemaType.String, valueRequired);
				this.CurrentSchema.Type = new JsonSchemaType?(value);
				goto IL_4C4;
				IL_455:
				throw new JsonException(StringUtils.FormatWith("Unexpected contract type: {0}", CultureInfo.InvariantCulture, jsonContract));
			}
			this.CurrentSchema.Type = new JsonSchemaType?(JsonSchemaType.Any);
			IL_4C4:
			return this.Pop().Schema;
		}

		// Token: 0x06000B8B RID: 2955
		// RVA: 0x0000CE87 File Offset: 0x0000B087
		private void GenerateISerializableContract(Type type, JsonISerializableContract contract)
		{
			this.CurrentSchema.AllowAdditionalProperties = true;
		}

		// Token: 0x06000B8A RID: 2954
		// RVA: 0x000430CC File Offset: 0x000412CC
		private void GenerateObjectSchema(Type type, JsonObjectContract contract)
		{
			this.CurrentSchema.Properties = new Dictionary<string, JsonSchema>();
			foreach (JsonProperty current in contract.Properties)
			{
				if (!current.Ignored)
				{
					bool flag = current.NullValueHandling == NullValueHandling.Ignore || this.HasFlag(current.DefaultValueHandling.GetValueOrDefault(), DefaultValueHandling.Ignore) || current.ShouldSerialize != null || current.GetIsSpecified != null;
					JsonSchema jsonSchema = this.GenerateInternal(current.PropertyType, current.Required, !flag);
					if (current.DefaultValue != null)
					{
						jsonSchema.Default = JToken.FromObject(current.DefaultValue);
					}
					this.CurrentSchema.Properties.Add(current.PropertyName, jsonSchema);
				}
			}
			if (TypeExtensions.IsSealed(type))
			{
				this.CurrentSchema.AllowAdditionalProperties = false;
			}
		}

		// Token: 0x06000B85 RID: 2949
		// RVA: 0x00042B48 File Offset: 0x00040D48
		private string GetDescription(Type type)
		{
			JsonContainerAttribute cachedAttribute = JsonTypeReflector.GetCachedAttribute<JsonContainerAttribute>(type);
			if (cachedAttribute != null && !string.IsNullOrEmpty(cachedAttribute.Description))
			{
				return cachedAttribute.Description;
			}
			DescriptionAttribute attribute = ReflectionUtils.GetAttribute<DescriptionAttribute>(type);
			if (attribute != null)
			{
				return attribute.Description;
			}
			return null;
		}

		// Token: 0x06000B8D RID: 2957
		// RVA: 0x00043280 File Offset: 0x00041480
		private JsonSchemaType GetJsonSchemaType(Type type, Required valueRequired)
		{
			JsonSchemaType jsonSchemaType = JsonSchemaType.None;
			if (valueRequired != Required.Always && ReflectionUtils.IsNullable(type))
			{
				jsonSchemaType = JsonSchemaType.Null;
				if (ReflectionUtils.IsNullableType(type))
				{
					type = Nullable.GetUnderlyingType(type);
				}
			}
			PrimitiveTypeCode typeCode = ConvertUtils.GetTypeCode(type);
			switch (typeCode)
			{
			case PrimitiveTypeCode.Empty:
			case PrimitiveTypeCode.Object:
				return jsonSchemaType | JsonSchemaType.String;
			case PrimitiveTypeCode.Char:
				return jsonSchemaType | JsonSchemaType.String;
			case PrimitiveTypeCode.Boolean:
				return jsonSchemaType | JsonSchemaType.Boolean;
			case PrimitiveTypeCode.SByte:
			case PrimitiveTypeCode.Int16:
			case PrimitiveTypeCode.UInt16:
			case PrimitiveTypeCode.Int32:
			case PrimitiveTypeCode.Byte:
			case PrimitiveTypeCode.UInt32:
			case PrimitiveTypeCode.Int64:
			case PrimitiveTypeCode.UInt64:
				return jsonSchemaType | JsonSchemaType.Integer;
			case PrimitiveTypeCode.Single:
			case PrimitiveTypeCode.Double:
			case PrimitiveTypeCode.Decimal:
				return jsonSchemaType | JsonSchemaType.Float;
			case PrimitiveTypeCode.DateTime:
				return jsonSchemaType | JsonSchemaType.String;
			case PrimitiveTypeCode.Guid:
			case PrimitiveTypeCode.TimeSpan:
			case PrimitiveTypeCode.Uri:
			case PrimitiveTypeCode.String:
			case PrimitiveTypeCode.Bytes:
				return jsonSchemaType | JsonSchemaType.String;
			case PrimitiveTypeCode.DBNull:
				return jsonSchemaType | JsonSchemaType.Null;
			}
			throw new JsonException(StringUtils.FormatWith("Unexpected type code '{0}' for type '{1}'.", CultureInfo.InvariantCulture, typeCode, type));
		}

		// Token: 0x06000B84 RID: 2948
		// RVA: 0x00042B1C File Offset: 0x00040D1C
		private string GetTitle(Type type)
		{
			JsonContainerAttribute cachedAttribute = JsonTypeReflector.GetCachedAttribute<JsonContainerAttribute>(type);
			if (cachedAttribute != null && !string.IsNullOrEmpty(cachedAttribute.Title))
			{
				return cachedAttribute.Title;
			}
			return null;
		}

		// Token: 0x06000B86 RID: 2950
		// RVA: 0x00042B88 File Offset: 0x00040D88
		private string GetTypeId(Type type, bool explicitOnly)
		{
			JsonContainerAttribute cachedAttribute = JsonTypeReflector.GetCachedAttribute<JsonContainerAttribute>(type);
			if (cachedAttribute != null && !string.IsNullOrEmpty(cachedAttribute.Id))
			{
				return cachedAttribute.Id;
			}
			if (explicitOnly)
			{
				return null;
			}
			switch (this.UndefinedSchemaIdHandling)
			{
			case UndefinedSchemaIdHandling.UseTypeName:
				return type.FullName;
			case UndefinedSchemaIdHandling.UseAssemblyQualifiedName:
				return type.AssemblyQualifiedName;
			default:
				return null;
			}
		}

		// Token: 0x06000B89 RID: 2953
		// RVA: 0x00006E28 File Offset: 0x00005028
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			return (value & flag) == flag;
		}

		// Token: 0x06000B8C RID: 2956
		// RVA: 0x000431E0 File Offset: 0x000413E0
		internal static bool HasFlag(JsonSchemaType? value, JsonSchemaType flag)
		{
			return !value.HasValue || (value & flag) == flag || (flag == JsonSchemaType.Integer && (value & JsonSchemaType.Float) == JsonSchemaType.Float);
		}

		// Token: 0x06000B7F RID: 2943
		// RVA: 0x00042AB8 File Offset: 0x00040CB8
		private JsonSchemaGenerator.TypeSchema Pop()
		{
			JsonSchemaGenerator.TypeSchema result = this._stack[this._stack.Count - 1];
			this._stack.RemoveAt(this._stack.Count - 1);
			JsonSchemaGenerator.TypeSchema typeSchema = Enumerable.LastOrDefault<JsonSchemaGenerator.TypeSchema>(this._stack);
			if (typeSchema != null)
			{
				this._currentSchema = typeSchema.Schema;
			}
			else
			{
				this._currentSchema = null;
			}
			return result;
		}

		// Token: 0x06000B7E RID: 2942
		// RVA: 0x0000CDF4 File Offset: 0x0000AFF4
		private void Push(JsonSchemaGenerator.TypeSchema typeSchema)
		{
			this._currentSchema = typeSchema.Schema;
			this._stack.Add(typeSchema);
			this._resolver.LoadedSchemas.Add(typeSchema.Schema);
		}
	}
}
