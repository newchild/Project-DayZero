using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;
using Newtonsoft.Json.Utilities.LinqBridge;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Serialization;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000121 RID: 289
	internal sealed class JsonSerializerInternalReader : JsonSerializerInternalBase
	{
		// Token: 0x02000122 RID: 290
		internal enum PropertyPresence
		{
			// Token: 0x04000511 RID: 1297
			None,
			// Token: 0x04000512 RID: 1298
			Null,
			// Token: 0x04000513 RID: 1299
			Value
		}

		// Token: 0x04000509 RID: 1289
		private JsonSerializerProxy _internalSerializer;

		// Token: 0x06000BB5 RID: 2997
		// RVA: 0x0000D110 File Offset: 0x0000B310
		public JsonSerializerInternalReader(JsonSerializer serializer) : base(serializer)
		{
		}

		// Token: 0x06000BCA RID: 3018
		// RVA: 0x00044AD8 File Offset: 0x00042CD8
		private void AddReference(JsonReader reader, string id, object value)
		{
			try
			{
				if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= TraceLevel.Verbose)
				{
					this.TraceWriter.Trace(TraceLevel.Verbose, JsonPosition.FormatMessage(reader as IJsonLineInfo, reader.Path, StringUtils.FormatWith("Read object reference Id '{0}' for {1}.", CultureInfo.InvariantCulture, id, value.GetType())), null);
				}
				this.Serializer.GetReferenceResolver().AddReference(this, id, value);
			}
			catch (Exception ex)
			{
				throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Error reading object reference '{0}'.", CultureInfo.InvariantCulture, id), ex);
			}
		}

		// Token: 0x06000BC9 RID: 3017
		// RVA: 0x00044940 File Offset: 0x00042B40
		private bool CalculatePropertyDetails(JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, out bool useExistingValue, out object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue)
		{
			currentValue = null;
			useExistingValue = false;
			propertyContract = null;
			gottenCurrentValue = false;
			if (property.Ignored)
			{
				return true;
			}
			JsonToken tokenType = reader.TokenType;
			if (property.PropertyContract == null)
			{
				property.PropertyContract = this.GetContractSafe(property.PropertyType);
			}
			ObjectCreationHandling valueOrDefault = property.ObjectCreationHandling.GetValueOrDefault(this.Serializer._objectCreationHandling);
			if (valueOrDefault != ObjectCreationHandling.Replace && (tokenType == JsonToken.StartArray || tokenType == JsonToken.StartObject) && property.Readable)
			{
				currentValue = property.ValueProvider.GetValue(target);
				gottenCurrentValue = true;
				if (currentValue != null)
				{
					propertyContract = this.GetContractSafe(currentValue.GetType());
					useExistingValue = (!propertyContract.IsReadOnlyOrFixedSize && !TypeExtensions.IsValueType(propertyContract.UnderlyingType));
				}
			}
			if (!property.Writable && !useExistingValue)
			{
				return true;
			}
			if (property.NullValueHandling.GetValueOrDefault(this.Serializer._nullValueHandling) == NullValueHandling.Ignore && tokenType == JsonToken.Null)
			{
				return true;
			}
			if (this.HasFlag(property.DefaultValueHandling.GetValueOrDefault(this.Serializer._defaultValueHandling), DefaultValueHandling.Ignore) && !this.HasFlag(property.DefaultValueHandling.GetValueOrDefault(this.Serializer._defaultValueHandling), DefaultValueHandling.Populate) && JsonTokenUtils.IsPrimitiveToken(tokenType) && MiscellaneousUtils.ValueEquals(reader.Value, property.GetResolvedDefaultValue()))
			{
				return true;
			}
			if (currentValue == null)
			{
				propertyContract = property.PropertyContract;
			}
			else
			{
				propertyContract = this.GetContractSafe(currentValue.GetType());
				if (propertyContract != property.PropertyContract)
				{
					propertyConverter = this.GetConverter(propertyContract, property.MemberConverter, containerContract, containerProperty);
				}
			}
			return false;
		}

		// Token: 0x06000BC4 RID: 3012
		// RVA: 0x0000D14D File Offset: 0x0000B34D
		private void CheckedRead(JsonReader reader)
		{
			if (!reader.Read())
			{
				throw JsonSerializationException.Create(reader, "Unexpected end when deserializing object.");
			}
		}

		// Token: 0x06000BDD RID: 3037
		// RVA: 0x0004639C File Offset: 0x0004459C
		private bool CheckPropertyName(JsonReader reader, string memberName)
		{
			if (this.Serializer.MetadataPropertyHandling == MetadataPropertyHandling.ReadAhead && memberName != null && (memberName == "$id" || memberName == "$ref" || memberName == "$type" || memberName == "$values"))
			{
				reader.Skip();
				return true;
			}
			return false;
		}

		// Token: 0x06000BD5 RID: 3029
		// RVA: 0x00045544 File Offset: 0x00043744
		private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id)
		{
			Type underlyingType = contract.UnderlyingType;
			if (!JsonTypeReflector.FullyTrusted)
			{
				string text = "Type '{0}' implements ISerializable but cannot be deserialized using the ISerializable interface because the current application is not fully trusted and ISerializable can expose secure data." + Environment.NewLine + "To fix this error either change the environment to be fully trusted, change the application to not deserialize the type, add JsonObjectAttribute to the type or change the JsonSerializer setting ContractResolver to use a new DefaultContractResolver with IgnoreSerializableInterface set to true." + Environment.NewLine;
				text = StringUtils.FormatWith(text, CultureInfo.InvariantCulture, underlyingType);
				throw JsonSerializationException.Create(reader, text);
			}
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= TraceLevel.Info)
			{
				this.TraceWriter.Trace(TraceLevel.Info, JsonPosition.FormatMessage(reader as IJsonLineInfo, reader.Path, StringUtils.FormatWith("Deserializing {0} using ISerializable constructor.", CultureInfo.InvariantCulture, contract.UnderlyingType)), null);
			}
			SerializationInfo serializationInfo = new SerializationInfo(contract.UnderlyingType, new JsonFormatterConverter(this, contract, member));
			bool flag = false;
			string text2;
			do
			{
				JsonToken tokenType = reader.TokenType;
				switch (tokenType)
				{
				case JsonToken.PropertyName:
					text2 = reader.Value.ToString();
					if (!reader.Read())
					{
						goto IL_119;
					}
					serializationInfo.AddValue(text2, JToken.ReadFrom(reader));
					break;
				case JsonToken.Comment:
					break;
				default:
					if (tokenType != JsonToken.EndObject)
					{
						goto Block_7;
					}
					flag = true;
					break;
				}
				if (flag)
				{
					break;
				}
			}
			while (reader.Read());
			goto IL_131;
			Block_7:
			throw JsonSerializationException.Create(reader, "Unexpected token when deserializing object: " + reader.TokenType);
			IL_119:
			throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Unexpected end when setting {0}'s value.", CultureInfo.InvariantCulture, text2));
			IL_131:
			if (!flag)
			{
				this.ThrowUnexpectedEndException(reader, contract, serializationInfo, "Unexpected end when deserializing object.");
			}
			if (contract.ISerializableCreator == null)
			{
				throw JsonSerializationException.Create(reader, StringUtils.FormatWith("ISerializable type '{0}' does not have a valid constructor. To correctly implement ISerializable a constructor that takes SerializationInfo and StreamingContext parameters should be present.", CultureInfo.InvariantCulture, underlyingType));
			}
			object obj = contract.ISerializableCreator(new object[]
			{
				serializationInfo,
				this.Serializer._context
			});
			if (id != null)
			{
				this.AddReference(reader, id, obj);
			}
			this.OnDeserializing(reader, contract, obj);
			this.OnDeserialized(reader, contract, obj);
			return obj;
		}

		// Token: 0x06000BD6 RID: 3030
		// RVA: 0x00045708 File Offset: 0x00043908
		internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, JsonProperty member)
		{
			JsonContract contractSafe = this.GetContractSafe(type);
			JsonConverter converter = this.GetConverter(contractSafe, null, contract, member);
			JsonReader reader = token.CreateReader();
			this.CheckedRead(reader);
			object result;
			if (converter != null && converter.CanRead)
			{
				result = this.DeserializeConvertable(converter, reader, type, null);
			}
			else
			{
				result = this.CreateValueInternal(reader, type, contractSafe, null, contract, member, null);
			}
			return result;
		}

		// Token: 0x06000BBB RID: 3003
		// RVA: 0x0004388C File Offset: 0x00041A8C
		private JToken CreateJObject(JsonReader reader)
		{
			ValidationUtils.ArgumentNotNull(reader, "reader");
			JToken token;
			using (JTokenWriter jTokenWriter = new JTokenWriter())
			{
				jTokenWriter.WriteStartObject();
				while (true)
				{
					if (reader.TokenType == JsonToken.PropertyName)
					{
						string text = (string)reader.Value;
						while (reader.Read())
						{
							if (reader.TokenType != JsonToken.Comment)
							{
								break;
							}
						}
						if (!this.CheckPropertyName(reader, text))
						{
							jTokenWriter.WritePropertyName(text);
							jTokenWriter.WriteToken(reader, true, true);
						}
					}
					else if (reader.TokenType != JsonToken.Comment)
					{
						break;
					}
					if (!reader.Read())
					{
						goto Block_4;
					}
				}
				jTokenWriter.WriteEndObject();
				token = jTokenWriter.Token;
				return token;
				Block_4:
				throw JsonSerializationException.Create(reader, "Unexpected end when deserializing object.");
			}
			return token;
		}

		// Token: 0x06000BBA RID: 3002
		// RVA: 0x000437F4 File Offset: 0x000419F4
		private JToken CreateJToken(JsonReader reader, JsonContract contract)
		{
			ValidationUtils.ArgumentNotNull(reader, "reader");
			if (contract != null)
			{
				if (contract.UnderlyingType == typeof(JRaw))
				{
					return JRaw.Create(reader);
				}
				if (reader.TokenType == JsonToken.Null && contract.UnderlyingType != typeof(JValue) && contract.UnderlyingType != typeof(JToken))
				{
					return null;
				}
			}
			JToken token;
			using (JTokenWriter jTokenWriter = new JTokenWriter())
			{
				jTokenWriter.WriteToken(reader);
				token = jTokenWriter.Token;
			}
			return token;
		}

		// Token: 0x06000BC5 RID: 3013
		// RVA: 0x00044574 File Offset: 0x00042774
		private object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id)
		{
			if (this.HasNoDefinedType(contract))
			{
				return this.CreateJToken(reader, contract);
			}
			JsonArrayContract jsonArrayContract = this.EnsureArrayContract(reader, objectType, contract);
			object result;
			if (existingValue == null)
			{
				bool flag;
				IList list = this.CreateNewList(reader, jsonArrayContract, out flag);
				if (flag)
				{
					if (id != null)
					{
						throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Cannot preserve reference to array or readonly list, or list created from a non-default constructor: {0}.", CultureInfo.InvariantCulture, contract.UnderlyingType));
					}
					if (contract.OnSerializingCallbacks.Count > 0)
					{
						throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Cannot call OnSerializing on an array or readonly list, or list created from a non-default constructor: {0}.", CultureInfo.InvariantCulture, contract.UnderlyingType));
					}
					if (contract.OnErrorCallbacks.Count > 0)
					{
						throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Cannot call OnError on an array or readonly list, or list created from a non-default constructor: {0}.", CultureInfo.InvariantCulture, contract.UnderlyingType));
					}
					if (!jsonArrayContract.HasParametrizedCreator && !jsonArrayContract.IsArray)
					{
						throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Cannot deserialize readonly or fixed size list: {0}.", CultureInfo.InvariantCulture, contract.UnderlyingType));
					}
				}
				if (!jsonArrayContract.IsMultidimensionalArray)
				{
					this.PopulateList(list, reader, jsonArrayContract, member, id);
				}
				else
				{
					this.PopulateMultidimensionalArray(list, reader, jsonArrayContract, member, id);
				}
				if (flag)
				{
					if (jsonArrayContract.IsMultidimensionalArray)
					{
						list = CollectionUtils.ToMultidimensionalArray(list, jsonArrayContract.CollectionItemType, contract.CreatedType.GetArrayRank());
					}
					else
					{
						if (!jsonArrayContract.IsArray)
						{
							return jsonArrayContract.ParametrizedCreator(new object[]
							{
								list
							});
						}
						Array array = Array.CreateInstance(jsonArrayContract.CollectionItemType, list.Count);
						list.CopyTo(array, 0);
						list = array;
					}
				}
				else if (list is IWrappedCollection)
				{
					return ((IWrappedCollection)list).UnderlyingCollection;
				}
				result = list;
			}
			else
			{
				if (!jsonArrayContract.CanDeserialize)
				{
					throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Cannot populate list type {0}.", CultureInfo.InvariantCulture, contract.CreatedType));
				}
				result = this.PopulateList(jsonArrayContract.ShouldCreateWrapper ? jsonArrayContract.CreateWrapper(existingValue) : ((IList)existingValue), reader, jsonArrayContract, member, id);
			}
			return result;
		}

		// Token: 0x06000BCE RID: 3022
		// RVA: 0x00044CEC File Offset: 0x00042EEC
		private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator)
		{
			if (contract.IsReadOnlyOrFixedSize)
			{
				createdFromNonDefaultCreator = true;
				return contract.CreateTemporaryDictionary();
			}
			if (contract.DefaultCreator != null && (!contract.DefaultCreatorNonPublic || this.Serializer._constructorHandling == ConstructorHandling.AllowNonPublicDefaultConstructor))
			{
				object obj = contract.DefaultCreator();
				if (contract.ShouldCreateWrapper)
				{
					obj = contract.CreateWrapper(obj);
				}
				createdFromNonDefaultCreator = false;
				return (IDictionary)obj;
			}
			if (contract.HasParametrizedCreator)
			{
				createdFromNonDefaultCreator = true;
				return contract.CreateTemporaryDictionary();
			}
			if (!contract.IsInstantiable)
			{
				throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.", CultureInfo.InvariantCulture, contract.UnderlyingType));
			}
			throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Unable to find a default constructor to use for type {0}.", CultureInfo.InvariantCulture, contract.UnderlyingType));
		}

		// Token: 0x06000BCD RID: 3021
		// RVA: 0x00044C00 File Offset: 0x00042E00
		private IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator)
		{
			if (!contract.CanDeserialize)
			{
				throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Cannot create and populate list type {0}.", CultureInfo.InvariantCulture, contract.CreatedType));
			}
			if (contract.IsReadOnlyOrFixedSize)
			{
				createdFromNonDefaultCreator = true;
				IList list = contract.CreateTemporaryCollection();
				if (contract.ShouldCreateWrapper)
				{
					list = contract.CreateWrapper(list);
				}
				return list;
			}
			if (contract.DefaultCreator != null && (!contract.DefaultCreatorNonPublic || this.Serializer._constructorHandling == ConstructorHandling.AllowNonPublicDefaultConstructor))
			{
				object obj = contract.DefaultCreator();
				if (contract.ShouldCreateWrapper)
				{
					obj = contract.CreateWrapper(obj);
				}
				createdFromNonDefaultCreator = false;
				return (IList)obj;
			}
			if (contract.HasParametrizedCreator)
			{
				createdFromNonDefaultCreator = true;
				return contract.CreateTemporaryCollection();
			}
			if (!contract.IsInstantiable)
			{
				throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.", CultureInfo.InvariantCulture, contract.UnderlyingType));
			}
			throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Unable to find a constructor to use for type {0}.", CultureInfo.InvariantCulture, contract.UnderlyingType));
		}

		// Token: 0x06000BDB RID: 3035
		// RVA: 0x00046004 File Offset: 0x00044204
		public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, out bool createdFromNonDefaultCreator)
		{
			object obj = null;
			if (objectContract.OverrideCreator != null)
			{
				if (objectContract.CreatorParameters.Count > 0)
				{
					createdFromNonDefaultCreator = true;
					return this.CreateObjectUsingCreatorWithParameters(reader, objectContract, containerMember, objectContract.OverrideCreator, id);
				}
				obj = objectContract.OverrideCreator(new object[0]);
			}
			else if (objectContract.DefaultCreator != null && (!objectContract.DefaultCreatorNonPublic || this.Serializer._constructorHandling == ConstructorHandling.AllowNonPublicDefaultConstructor || objectContract.ParametrizedCreator == null))
			{
				obj = objectContract.DefaultCreator();
			}
			else if (objectContract.ParametrizedCreator != null)
			{
				createdFromNonDefaultCreator = true;
				return this.CreateObjectUsingCreatorWithParameters(reader, objectContract, containerMember, objectContract.ParametrizedCreator, id);
			}
			if (obj != null)
			{
				createdFromNonDefaultCreator = false;
				return obj;
			}
			if (!objectContract.IsInstantiable)
			{
				throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.", CultureInfo.InvariantCulture, objectContract.UnderlyingType));
			}
			throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Unable to find a constructor to use for type {0}. A class should either have a default constructor, one constructor with arguments or a constructor marked with the JsonConstructor attribute.", CultureInfo.InvariantCulture, objectContract.UnderlyingType));
		}

		// Token: 0x06000BBF RID: 3007
		// RVA: 0x00043BB8 File Offset: 0x00041DB8
		private object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue)
		{
			Type type = objectType;
			string text;
			if (this.Serializer.MetadataPropertyHandling == MetadataPropertyHandling.Ignore)
			{
				this.CheckedRead(reader);
				text = null;
			}
			else if (this.Serializer.MetadataPropertyHandling == MetadataPropertyHandling.ReadAhead)
			{
				JTokenReader jTokenReader = reader as JTokenReader;
				if (jTokenReader == null)
				{
					JToken jToken = JToken.ReadFrom(reader);
					jTokenReader = (JTokenReader)jToken.CreateReader();
					jTokenReader.Culture = reader.Culture;
					jTokenReader.DateFormatString = reader.DateFormatString;
					jTokenReader.DateParseHandling = reader.DateParseHandling;
					jTokenReader.DateTimeZoneHandling = reader.DateTimeZoneHandling;
					jTokenReader.FloatParseHandling = reader.FloatParseHandling;
					jTokenReader.SupportMultipleContent = reader.SupportMultipleContent;
					this.CheckedRead(jTokenReader);
					reader = jTokenReader;
				}
				object result;
				if (this.ReadMetadataPropertiesToken(jTokenReader, ref type, ref contract, member, containerContract, containerMember, existingValue, out result, out text))
				{
					return result;
				}
			}
			else
			{
				this.CheckedRead(reader);
				object result2;
				if (this.ReadMetadataProperties(reader, ref type, ref contract, member, containerContract, containerMember, existingValue, out result2, out text))
				{
					return result2;
				}
			}
			if (this.HasNoDefinedType(contract))
			{
				return this.CreateJObject(reader);
			}
			switch (contract.ContractType)
			{
			case JsonContractType.Object:
			{
				bool flag = false;
				JsonObjectContract jsonObjectContract = (JsonObjectContract)contract;
				object obj;
				if (existingValue != null && (type == objectType || type.IsAssignableFrom(existingValue.GetType())))
				{
					obj = existingValue;
				}
				else
				{
					obj = this.CreateNewObject(reader, jsonObjectContract, member, containerMember, text, out flag);
				}
				if (flag)
				{
					return obj;
				}
				return this.PopulateObject(obj, reader, jsonObjectContract, member, text);
			}
			case JsonContractType.Primitive:
			{
				JsonPrimitiveContract contract2 = (JsonPrimitiveContract)contract;
				if (this.Serializer.MetadataPropertyHandling != MetadataPropertyHandling.Ignore && reader.TokenType == JsonToken.PropertyName && string.Equals(reader.Value.ToString(), "$value", StringComparison.Ordinal))
				{
					this.CheckedRead(reader);
					if (reader.TokenType == JsonToken.StartObject)
					{
						throw JsonSerializationException.Create(reader, "Unexpected token when deserializing primitive value: " + reader.TokenType);
					}
					object result3 = this.CreateValueInternal(reader, type, contract2, member, null, null, existingValue);
					this.CheckedRead(reader);
					return result3;
				}
				break;
			}
			case JsonContractType.Dictionary:
			{
				JsonDictionaryContract jsonDictionaryContract = (JsonDictionaryContract)contract;
				object result4;
				if (existingValue == null)
				{
					bool flag2;
					IDictionary dictionary = this.CreateNewDictionary(reader, jsonDictionaryContract, out flag2);
					if (flag2)
					{
						if (text != null)
						{
							throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Cannot preserve reference to readonly dictionary, or dictionary created from a non-default constructor: {0}.", CultureInfo.InvariantCulture, contract.UnderlyingType));
						}
						if (contract.OnSerializingCallbacks.Count > 0)
						{
							throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Cannot call OnSerializing on readonly dictionary, or dictionary created from a non-default constructor: {0}.", CultureInfo.InvariantCulture, contract.UnderlyingType));
						}
						if (contract.OnErrorCallbacks.Count > 0)
						{
							throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Cannot call OnError on readonly list, or dictionary created from a non-default constructor: {0}.", CultureInfo.InvariantCulture, contract.UnderlyingType));
						}
						if (!jsonDictionaryContract.HasParametrizedCreator)
						{
							throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Cannot deserialize readonly or fixed size dictionary: {0}.", CultureInfo.InvariantCulture, contract.UnderlyingType));
						}
					}
					this.PopulateDictionary(dictionary, reader, jsonDictionaryContract, member, text);
					if (flag2)
					{
						return jsonDictionaryContract.ParametrizedCreator(new object[]
						{
							dictionary
						});
					}
					if (dictionary is IWrappedDictionary)
					{
						return ((IWrappedDictionary)dictionary).UnderlyingDictionary;
					}
					result4 = dictionary;
				}
				else
				{
					result4 = this.PopulateDictionary(jsonDictionaryContract.ShouldCreateWrapper ? jsonDictionaryContract.CreateWrapper(existingValue) : ((IDictionary)existingValue), reader, jsonDictionaryContract, member, text);
				}
				return result4;
			}
			case JsonContractType.Serializable:
			{
				JsonISerializableContract contract3 = (JsonISerializableContract)contract;
				return this.CreateISerializable(reader, contract3, member, text);
			}
			}
			string text2 = "Cannot deserialize the current JSON object (e.g. {{\"name\":\"value\"}}) into type '{0}' because the type requires a {1} to deserialize correctly." + Environment.NewLine + "To fix this error either change the JSON to a {1} or change the deserialized type so that it is a normal .NET type (e.g. not a primitive type like integer, not a collection type like an array or List<T>) that can be deserialized from a JSON object. JsonObjectAttribute can also be added to the type to force it to deserialize from a JSON object." + Environment.NewLine;
			text2 = StringUtils.FormatWith(text2, CultureInfo.InvariantCulture, type, this.GetExpectedDescription(contract));
			throw JsonSerializationException.Create(reader, text2);
		}

		// Token: 0x06000BD7 RID: 3031
		// RVA: 0x00045760 File Offset: 0x00043960
		private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, ObjectConstructor<object> creator, string id)
		{
			ValidationUtils.ArgumentNotNull(creator, "creator");
			Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> arg_70_0;
			if (!contract.HasRequiredOrDefaultValueProperties && !this.HasFlag(this.Serializer._defaultValueHandling, DefaultValueHandling.Populate))
			{
				arg_70_0 = null;
			}
			else
			{
				arg_70_0 = Enumerable.ToDictionary<JsonProperty, JsonProperty, JsonSerializerInternalReader.PropertyPresence>(contract.Properties, (JsonProperty m) => m, (JsonProperty m) => JsonSerializerInternalReader.PropertyPresence.None);
			}
			Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> dictionary = arg_70_0;
			Type underlyingType = contract.UnderlyingType;
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= TraceLevel.Info)
			{
				string arg = string.Join(", ", Enumerable.ToArray<string>(Enumerable.Select<JsonProperty, string>(contract.CreatorParameters, (JsonProperty p) => p.PropertyName)));
				this.TraceWriter.Trace(TraceLevel.Info, JsonPosition.FormatMessage(reader as IJsonLineInfo, reader.Path, StringUtils.FormatWith("Deserializing {0} using creator with parameters: {1}.", CultureInfo.InvariantCulture, contract.UnderlyingType, arg)), null);
			}
			IDictionary<string, object> dictionary3;
			IDictionary<JsonProperty, object> dictionary2 = this.ResolvePropertyAndCreatorValues(contract, containerProperty, reader, underlyingType, out dictionary3);
			object[] array = new object[contract.CreatorParameters.Count];
			IDictionary<JsonProperty, object> dictionary4 = new Dictionary<JsonProperty, object>();
			foreach (KeyValuePair<JsonProperty, object> current in dictionary2)
			{
				JsonProperty property = current.Key;
				JsonProperty jsonProperty;
				if (contract.CreatorParameters.Contains(property))
				{
					jsonProperty = property;
				}
				else
				{
					jsonProperty = StringUtils.ForgivingCaseSensitiveFind<JsonProperty>(contract.CreatorParameters, (JsonProperty p) => p.PropertyName, property.UnderlyingName);
				}
				if (jsonProperty != null)
				{
					int num = contract.CreatorParameters.IndexOf(jsonProperty);
					array[num] = current.Value;
				}
				else
				{
					dictionary4.Add(current);
				}
				if (dictionary != null)
				{
					JsonProperty jsonProperty2 = Enumerable.FirstOrDefault<JsonProperty>(dictionary.Keys, (JsonProperty p) => p.PropertyName == property.PropertyName);
					if (jsonProperty2 != null)
					{
						dictionary[jsonProperty2] = ((current.Value == null) ? JsonSerializerInternalReader.PropertyPresence.Null : JsonSerializerInternalReader.PropertyPresence.Value);
					}
				}
			}
			object obj = creator(array);
			if (id != null)
			{
				this.AddReference(reader, id, obj);
			}
			this.OnDeserializing(reader, contract, obj);
			foreach (KeyValuePair<JsonProperty, object> current2 in dictionary4)
			{
				JsonProperty key = current2.Key;
				object value = current2.Value;
				if (this.ShouldSetPropertyValue(key, value))
				{
					key.ValueProvider.SetValue(obj, value);
				}
				else if (!key.Writable && value != null)
				{
					JsonContract jsonContract = this.Serializer._contractResolver.ResolveContract(key.PropertyType);
					if (jsonContract.ContractType == JsonContractType.Array)
					{
						JsonArrayContract jsonArrayContract = (JsonArrayContract)jsonContract;
						object value2 = key.ValueProvider.GetValue(obj);
						if (value2 == null)
						{
							continue;
						}
						IWrappedCollection wrappedCollection = jsonArrayContract.CreateWrapper(value2);
						IWrappedCollection wrappedCollection2 = jsonArrayContract.CreateWrapper(value);
						IEnumerator enumerator3 = wrappedCollection2.GetEnumerator();
						try
						{
							while (enumerator3.MoveNext())
							{
								object current3 = enumerator3.Current;
								wrappedCollection.Add(current3);
							}
							continue;
						}
						finally
						{
							IDisposable disposable = enumerator3 as IDisposable;
							if (disposable != null)
							{
								disposable.Dispose();
							}
						}
					}
					if (jsonContract.ContractType == JsonContractType.Dictionary)
					{
						JsonDictionaryContract jsonDictionaryContract = (JsonDictionaryContract)jsonContract;
						object value3 = key.ValueProvider.GetValue(obj);
						if (value3 != null)
						{
							IDictionary dictionary5 = jsonDictionaryContract.ShouldCreateWrapper ? jsonDictionaryContract.CreateWrapper(value3) : ((IDictionary)value3);
							IDictionary dictionary6 = jsonDictionaryContract.ShouldCreateWrapper ? jsonDictionaryContract.CreateWrapper(value) : ((IDictionary)value);
							foreach (DictionaryEntry dictionaryEntry in dictionary6)
							{
								dictionary5.Add(dictionaryEntry.Key, dictionaryEntry.Value);
							}
						}
					}
				}
			}
			if (dictionary3 != null)
			{
				foreach (KeyValuePair<string, object> current4 in dictionary3)
				{
					contract.ExtensionDataSetter(obj, current4.Key, current4.Value);
				}
			}
			this.EndObject(obj, reader, contract, reader.Depth, dictionary);
			this.OnDeserialized(reader, contract, obj);
			return obj;
		}

		// Token: 0x06000BBC RID: 3004
		// RVA: 0x00043948 File Offset: 0x00041B48
		private object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue)
		{
			if (contract != null && contract.ContractType == JsonContractType.Linq)
			{
				return this.CreateJToken(reader, contract);
			}
			while (true)
			{
				switch (reader.TokenType)
				{
				case JsonToken.StartObject:
					goto IL_78;
				case JsonToken.StartArray:
					goto IL_8A;
				case JsonToken.StartConstructor:
					goto IL_99;
				case JsonToken.Comment:
					if (reader.Read())
					{
						continue;
					}
					goto IL_B5;
				case JsonToken.Raw:
					goto IL_C1;
				case JsonToken.Integer:
				case JsonToken.Float:
				case JsonToken.Boolean:
				case JsonToken.Date:
				case JsonToken.Bytes:
					goto IL_175;
				case JsonToken.String:
					goto IL_D2;
				case JsonToken.Null:
				case JsonToken.Undefined:
					goto IL_131;
				}
				break;
			}
			goto IL_159;
			IL_78:
			return this.CreateObject(reader, objectType, contract, member, containerContract, containerMember, existingValue);
			IL_8A:
			return this.CreateList(reader, objectType, contract, member, existingValue, null);
			IL_99:
			string value = reader.Value.ToString();
			return this.EnsureType(reader, value, CultureInfo.InvariantCulture, contract, objectType);
			IL_B5:
			throw JsonSerializationException.Create(reader, "Unexpected end when deserializing object.");
			IL_C1:
			return new JRaw((string)reader.Value);
			IL_D2:
			string text = (string)reader.Value;
			if (string.IsNullOrEmpty(text) && objectType != typeof(string) && objectType != typeof(object) && contract != null && contract.IsNullable)
			{
				return null;
			}
			if (objectType == typeof(byte[]))
			{
				return Convert.FromBase64String(text);
			}
			return this.EnsureType(reader, text, CultureInfo.InvariantCulture, contract, objectType);
			IL_131:
			if (objectType == typeof(DBNull))
			{
				return DBNull.Value;
			}
			return this.EnsureType(reader, reader.Value, CultureInfo.InvariantCulture, contract, objectType);
			IL_159:
			throw JsonSerializationException.Create(reader, "Unexpected token while deserializing object: " + reader.TokenType);
			IL_175:
			return this.EnsureType(reader, reader.Value, CultureInfo.InvariantCulture, contract, objectType);
		}

		// Token: 0x06000BB8 RID: 3000
		// RVA: 0x000436F4 File Offset: 0x000418F4
		public object Deserialize(JsonReader reader, Type objectType, bool checkAdditionalContent)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			JsonContract contractSafe = this.GetContractSafe(objectType);
			object result;
			try
			{
				JsonConverter converter = this.GetConverter(contractSafe, null, null, null);
				if (reader.TokenType == JsonToken.None && !this.ReadForType(reader, contractSafe, converter != null))
				{
					if (contractSafe != null && !contractSafe.IsNullable)
					{
						throw JsonSerializationException.Create(reader, StringUtils.FormatWith("No JSON content found and type '{0}' is not nullable.", CultureInfo.InvariantCulture, contractSafe.UnderlyingType));
					}
					result = null;
				}
				else
				{
					object obj;
					if (converter != null && converter.CanRead)
					{
						obj = this.DeserializeConvertable(converter, reader, objectType, null);
					}
					else
					{
						obj = this.CreateValueInternal(reader, objectType, contractSafe, null, null, null, null);
					}
					if (checkAdditionalContent && reader.Read() && reader.TokenType != JsonToken.Comment)
					{
						throw new JsonSerializationException("Additional text found in JSON string after finishing deserializing object.");
					}
					result = obj;
				}
			}
			catch (Exception ex)
			{
				if (!base.IsErrorHandled(null, contractSafe, null, reader as IJsonLineInfo, reader.Path, ex))
				{
					base.ClearErrorContext();
					throw;
				}
				this.HandleError(reader, false, 0);
				result = null;
			}
			return result;
		}

		// Token: 0x06000BD8 RID: 3032
		// RVA: 0x00045C64 File Offset: 0x00043E64
		private object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, object existingValue)
		{
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= TraceLevel.Info)
			{
				this.TraceWriter.Trace(TraceLevel.Info, JsonPosition.FormatMessage(reader as IJsonLineInfo, reader.Path, StringUtils.FormatWith("Started deserializing {0} with converter {1}.", CultureInfo.InvariantCulture, objectType, converter.GetType())), null);
			}
			object result = converter.ReadJson(reader, objectType, existingValue, this.GetInternalSerializer());
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= TraceLevel.Info)
			{
				this.TraceWriter.Trace(TraceLevel.Info, JsonPosition.FormatMessage(reader as IJsonLineInfo, reader.Path, StringUtils.FormatWith("Finished deserializing {0} with converter {1}.", CultureInfo.InvariantCulture, objectType, converter.GetType())), null);
			}
			return result;
		}

		// Token: 0x06000BDF RID: 3039
		// RVA: 0x00046468 File Offset: 0x00044668
		private void EndObject(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> propertiesPresence)
		{
			if (propertiesPresence != null)
			{
				foreach (KeyValuePair<JsonProperty, JsonSerializerInternalReader.PropertyPresence> current in propertiesPresence)
				{
					JsonProperty key = current.Key;
					JsonSerializerInternalReader.PropertyPresence value = current.Value;
					if (value != JsonSerializerInternalReader.PropertyPresence.None)
					{
						if (value != JsonSerializerInternalReader.PropertyPresence.Null)
						{
							continue;
						}
					}
					try
					{
						Required required = key._required ?? (contract.ItemRequired ?? Required.Default);
						switch (value)
						{
						case JsonSerializerInternalReader.PropertyPresence.None:
							if (required != Required.AllowNull)
							{
								if (required != Required.Always)
								{
									if (key.PropertyContract == null)
									{
										key.PropertyContract = this.GetContractSafe(key.PropertyType);
									}
									if (this.HasFlag(key.DefaultValueHandling.GetValueOrDefault(this.Serializer._defaultValueHandling), DefaultValueHandling.Populate) && key.Writable && !key.Ignored)
									{
										key.ValueProvider.SetValue(newObject, this.EnsureType(reader, key.GetResolvedDefaultValue(), CultureInfo.InvariantCulture, key.PropertyContract, key.PropertyType));
										break;
									}
									break;
								}
							}
							throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Required property '{0}' not found in JSON.", CultureInfo.InvariantCulture, key.PropertyName));
						case JsonSerializerInternalReader.PropertyPresence.Null:
							if (required == Required.Always)
							{
								throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Required property '{0}' expects a value but got null.", CultureInfo.InvariantCulture, key.PropertyName));
							}
							break;
						}
					}
					catch (Exception ex)
					{
						if (!base.IsErrorHandled(newObject, contract, key.PropertyName, reader as IJsonLineInfo, reader.Path, ex))
						{
							throw;
						}
						this.HandleError(reader, true, initialDepth);
					}
				}
			}
		}

		// Token: 0x06000BC3 RID: 3011
		// RVA: 0x0004450C File Offset: 0x0004270C
		private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract)
		{
			if (contract == null)
			{
				throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Could not resolve type '{0}' to a JsonContract.", CultureInfo.InvariantCulture, objectType));
			}
			JsonArrayContract jsonArrayContract = contract as JsonArrayContract;
			if (jsonArrayContract == null)
			{
				string text = "Cannot deserialize the current JSON array (e.g. [1,2,3]) into type '{0}' because the type requires a {1} to deserialize correctly." + Environment.NewLine + "To fix this error either change the JSON to a {1} or change the deserialized type to an array or a type that implements a collection interface (e.g. ICollection, IList) like List<T> that can be deserialized from a JSON array. JsonArrayAttribute can also be added to the type to force it to deserialize from a JSON array." + Environment.NewLine;
				text = StringUtils.FormatWith(text, CultureInfo.InvariantCulture, objectType, this.GetExpectedDescription(contract));
				throw JsonSerializationException.Create(reader, text);
			}
			return jsonArrayContract;
		}

		// Token: 0x06000BC7 RID: 3015
		// RVA: 0x00044748 File Offset: 0x00042948
		private object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, Type targetType)
		{
			if (targetType == null)
			{
				return value;
			}
			Type objectType = ReflectionUtils.GetObjectType(value);
			if (objectType == targetType)
			{
				return value;
			}
			if (value == null && contract.IsNullable)
			{
				return null;
			}
			object result;
			try
			{
				if (contract.IsConvertable)
				{
					JsonPrimitiveContract jsonPrimitiveContract = (JsonPrimitiveContract)contract;
					if (contract.IsEnum)
					{
						if (value is string)
						{
							result = Enum.Parse(contract.NonNullableUnderlyingType, value.ToString(), true);
							return result;
						}
						if (ConvertUtils.IsInteger(jsonPrimitiveContract.TypeCode))
						{
							result = Enum.ToObject(contract.NonNullableUnderlyingType, value);
							return result;
						}
					}
					result = Convert.ChangeType(value, contract.NonNullableUnderlyingType, culture);
				}
				else
				{
					result = ConvertUtils.ConvertOrCast(value, culture, contract.NonNullableUnderlyingType);
				}
			}
			catch (Exception ex)
			{
				throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Error converting value {0} to type '{1}'.", CultureInfo.InvariantCulture, MiscellaneousUtils.FormatValueForPrint(value), targetType), ex);
			}
			return result;
		}

		// Token: 0x06000BB7 RID: 2999
		// RVA: 0x0000D119 File Offset: 0x0000B319
		private JsonContract GetContractSafe(Type type)
		{
			if (type == null)
			{
				return null;
			}
			return this.Serializer._contractResolver.ResolveContract(type);
		}

		// Token: 0x06000BBE RID: 3006
		// RVA: 0x00043B38 File Offset: 0x00041D38
		private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			JsonConverter result = null;
			if (memberConverter != null)
			{
				result = memberConverter;
			}
			else if (containerProperty != null && containerProperty.ItemConverter != null)
			{
				result = containerProperty.ItemConverter;
			}
			else if (containerContract != null && containerContract.ItemConverter != null)
			{
				result = containerContract.ItemConverter;
			}
			else if (contract != null)
			{
				JsonConverter matchingConverter;
				if (contract.Converter != null)
				{
					result = contract.Converter;
				}
				else if ((matchingConverter = this.Serializer.GetMatchingConverter(contract.UnderlyingType)) != null)
				{
					result = matchingConverter;
				}
				else if (contract.InternalConverter != null)
				{
					result = contract.InternalConverter;
				}
			}
			return result;
		}

		// Token: 0x06000BBD RID: 3005
		// RVA: 0x00043AE0 File Offset: 0x00041CE0
		internal string GetExpectedDescription(JsonContract contract)
		{
			switch (contract.ContractType)
			{
			case JsonContractType.Object:
			case JsonContractType.Dictionary:
			case JsonContractType.Serializable:
				return "JSON object (e.g. {\"name\":\"value\"})";
			case JsonContractType.Array:
				return "JSON array (e.g. [1,2,3])";
			case JsonContractType.Primitive:
				return "JSON primitive value (e.g. string, number, boolean, null)";
			case JsonContractType.String:
				return "JSON string value";
			}
			throw new ArgumentOutOfRangeException();
		}

		// Token: 0x06000BB9 RID: 3001
		// RVA: 0x0000D131 File Offset: 0x0000B331
		private JsonSerializerProxy GetInternalSerializer()
		{
			if (this._internalSerializer == null)
			{
				this._internalSerializer = new JsonSerializerProxy(this);
			}
			return this._internalSerializer;
		}

		// Token: 0x06000BE1 RID: 3041
		// RVA: 0x0000D1AC File Offset: 0x0000B3AC
		private void HandleError(JsonReader reader, bool readPastError, int initialDepth)
		{
			base.ClearErrorContext();
			if (readPastError)
			{
				reader.Skip();
				while (reader.Depth > initialDepth + 1)
				{
					if (!reader.Read())
					{
						return;
					}
				}
			}
		}

		// Token: 0x06000BCB RID: 3019
		// RVA: 0x00006E28 File Offset: 0x00005028
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			return (value & flag) == flag;
		}

		// Token: 0x06000BC6 RID: 3014
		// RVA: 0x0000D163 File Offset: 0x0000B363
		private bool HasNoDefinedType(JsonContract contract)
		{
			return contract == null || contract.UnderlyingType == typeof(object) || contract.ContractType == JsonContractType.Linq;
		}

		// Token: 0x06000BD0 RID: 3024
		// RVA: 0x00044E08 File Offset: 0x00043008
		private void OnDeserialized(JsonReader reader, JsonContract contract, object value)
		{
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= TraceLevel.Info)
			{
				this.TraceWriter.Trace(TraceLevel.Info, JsonPosition.FormatMessage(reader as IJsonLineInfo, reader.Path, StringUtils.FormatWith("Finished deserializing {0}", CultureInfo.InvariantCulture, contract.UnderlyingType)), null);
			}
			contract.InvokeOnDeserialized(value, this.Serializer._context);
		}

		// Token: 0x06000BCF RID: 3023
		// RVA: 0x00044DA0 File Offset: 0x00042FA0
		private void OnDeserializing(JsonReader reader, JsonContract contract, object value)
		{
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= TraceLevel.Info)
			{
				this.TraceWriter.Trace(TraceLevel.Info, JsonPosition.FormatMessage(reader as IJsonLineInfo, reader.Path, StringUtils.FormatWith("Started deserializing {0}", CultureInfo.InvariantCulture, contract.UnderlyingType)), null);
			}
			contract.InvokeOnDeserializing(value, this.Serializer._context);
		}

		// Token: 0x06000BB6 RID: 2998
		// RVA: 0x0004356C File Offset: 0x0004176C
		public void Populate(JsonReader reader, object target)
		{
			ValidationUtils.ArgumentNotNull(target, "target");
			Type type = target.GetType();
			JsonContract jsonContract = this.Serializer._contractResolver.ResolveContract(type);
			if (reader.TokenType == JsonToken.None)
			{
				reader.Read();
			}
			if (reader.TokenType == JsonToken.StartArray)
			{
				if (jsonContract.ContractType == JsonContractType.Array)
				{
					JsonArrayContract jsonArrayContract = (JsonArrayContract)jsonContract;
					this.PopulateList(jsonArrayContract.ShouldCreateWrapper ? jsonArrayContract.CreateWrapper(target) : ((IList)target), reader, jsonArrayContract, null, null);
					return;
				}
				throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Cannot populate JSON array onto type '{0}'.", CultureInfo.InvariantCulture, type));
			}
			else
			{
				if (reader.TokenType != JsonToken.StartObject)
				{
					throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Unexpected initial token '{0}' when populating object. Expected JSON object or array.", CultureInfo.InvariantCulture, reader.TokenType));
				}
				this.CheckedRead(reader);
				string id = null;
				if (this.Serializer.MetadataPropertyHandling != MetadataPropertyHandling.Ignore && reader.TokenType == JsonToken.PropertyName && string.Equals(reader.Value.ToString(), "$id", StringComparison.Ordinal))
				{
					this.CheckedRead(reader);
					id = ((reader.Value != null) ? reader.Value.ToString() : null);
					this.CheckedRead(reader);
				}
				if (jsonContract.ContractType == JsonContractType.Dictionary)
				{
					JsonDictionaryContract jsonDictionaryContract = (JsonDictionaryContract)jsonContract;
					this.PopulateDictionary(jsonDictionaryContract.ShouldCreateWrapper ? jsonDictionaryContract.CreateWrapper(target) : ((IDictionary)target), reader, jsonDictionaryContract, null, id);
					return;
				}
				if (jsonContract.ContractType == JsonContractType.Object)
				{
					this.PopulateObject(target, reader, (JsonObjectContract)jsonContract, null, id);
					return;
				}
				throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Cannot populate JSON object onto type '{0}'.", CultureInfo.InvariantCulture, type));
			}
		}

		// Token: 0x06000BD1 RID: 3025
		// RVA: 0x00044E70 File Offset: 0x00043070
		private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id)
		{
			IWrappedDictionary wrappedDictionary = dictionary as IWrappedDictionary;
			object obj = (wrappedDictionary != null) ? wrappedDictionary.UnderlyingDictionary : dictionary;
			if (id != null)
			{
				this.AddReference(reader, id, obj);
			}
			this.OnDeserializing(reader, contract, obj);
			int depth = reader.Depth;
			if (contract.KeyContract == null)
			{
				contract.KeyContract = this.GetContractSafe(contract.DictionaryKeyType);
			}
			if (contract.ItemContract == null)
			{
				contract.ItemContract = this.GetContractSafe(contract.DictionaryValueType);
			}
			JsonConverter jsonConverter = contract.ItemConverter ?? this.GetConverter(contract.ItemContract, null, contract, containerProperty);
			PrimitiveTypeCode primitiveTypeCode = (contract.KeyContract is JsonPrimitiveContract) ? ((JsonPrimitiveContract)contract.KeyContract).TypeCode : PrimitiveTypeCode.Empty;
			bool flag = false;
			while (true)
			{
				JsonToken tokenType = reader.TokenType;
				switch (tokenType)
				{
				case JsonToken.PropertyName:
				{
					object obj2 = reader.Value;
					if (!this.CheckPropertyName(reader, obj2.ToString()))
					{
						try
						{
							try
							{
								DateParseHandling dateParseHandling;
								switch (primitiveTypeCode)
								{
								case PrimitiveTypeCode.DateTime:
								case PrimitiveTypeCode.DateTimeNullable:
									dateParseHandling = DateParseHandling.DateTime;
									break;
								default:
									dateParseHandling = DateParseHandling.None;
									break;
								}
								object obj3;
								if (dateParseHandling != DateParseHandling.None && DateTimeUtils.TryParseDateTime(obj2.ToString(), dateParseHandling, reader.DateTimeZoneHandling, reader.DateFormatString, reader.Culture, out obj3))
								{
									obj2 = obj3;
								}
								else
								{
									obj2 = this.EnsureType(reader, obj2, CultureInfo.InvariantCulture, contract.KeyContract, contract.DictionaryKeyType);
								}
							}
							catch (Exception ex)
							{
								throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Could not convert string '{0}' to dictionary key type '{1}'. Create a TypeConverter to convert from the string to the key type object.", CultureInfo.InvariantCulture, reader.Value, contract.DictionaryKeyType), ex);
							}
							if (!this.ReadForType(reader, contract.ItemContract, jsonConverter != null))
							{
								throw JsonSerializationException.Create(reader, "Unexpected end when deserializing object.");
							}
							object value;
							if (jsonConverter != null && jsonConverter.CanRead)
							{
								value = this.DeserializeConvertable(jsonConverter, reader, contract.DictionaryValueType, null);
							}
							else
							{
								value = this.CreateValueInternal(reader, contract.DictionaryValueType, contract.ItemContract, null, contract, containerProperty, null);
							}
							dictionary[obj2] = value;
							break;
						}
						catch (Exception ex2)
						{
							if (!base.IsErrorHandled(obj, contract, obj2, reader as IJsonLineInfo, reader.Path, ex2))
							{
								throw;
							}
							this.HandleError(reader, true, depth);
							break;
						}
						goto IL_20B;
					}
					break;
				}
				case JsonToken.Comment:
					break;
				default:
					goto IL_20B;
				}
				IL_216:
				if (flag)
				{
					break;
				}
				if (!reader.Read())
				{
					break;
				}
				continue;
				IL_20B:
				if (tokenType != JsonToken.EndObject)
				{
					goto Block_10;
				}
				flag = true;
				goto IL_216;
			}
			goto IL_23B;
			Block_10:
			throw JsonSerializationException.Create(reader, "Unexpected token when deserializing object: " + reader.TokenType);
			IL_23B:
			if (!flag)
			{
				this.ThrowUnexpectedEndException(reader, contract, obj, "Unexpected end when deserializing object.");
			}
			this.OnDeserialized(reader, contract, obj);
			return obj;
		}

		// Token: 0x06000BD4 RID: 3028
		// RVA: 0x0004538C File Offset: 0x0004358C
		private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id)
		{
			IWrappedCollection wrappedCollection = list as IWrappedCollection;
			object obj = (wrappedCollection != null) ? wrappedCollection.UnderlyingCollection : list;
			if (id != null)
			{
				this.AddReference(reader, id, obj);
			}
			if (list.IsFixedSize)
			{
				reader.Skip();
				return obj;
			}
			this.OnDeserializing(reader, contract, obj);
			int depth = reader.Depth;
			if (contract.ItemContract == null)
			{
				contract.ItemContract = this.GetContractSafe(contract.CollectionItemType);
			}
			JsonConverter converter = this.GetConverter(contract.ItemContract, null, contract, containerProperty);
			int? num = null;
			bool flag = false;
			do
			{
				try
				{
					if (!this.ReadForType(reader, contract.ItemContract, converter != null))
					{
						break;
					}
					JsonToken tokenType = reader.TokenType;
					if (tokenType != JsonToken.Comment)
					{
						if (tokenType == JsonToken.EndArray)
						{
							flag = true;
						}
						else
						{
							object value;
							if (converter != null && converter.CanRead)
							{
								value = this.DeserializeConvertable(converter, reader, contract.CollectionItemType, null);
							}
							else
							{
								value = this.CreateValueInternal(reader, contract.CollectionItemType, contract.ItemContract, null, contract, containerProperty, null);
							}
							list.Add(value);
						}
					}
				}
				catch (Exception ex)
				{
					JsonPosition position = reader.GetPosition(depth);
					if (!base.IsErrorHandled(obj, contract, position.Position, reader as IJsonLineInfo, reader.Path, ex))
					{
						throw;
					}
					this.HandleError(reader, true, depth);
					if (num.HasValue && num == position.Position)
					{
						throw JsonSerializationException.Create(reader, "Infinite loop detected from error handling.", ex);
					}
					num = new int?(position.Position);
				}
			}
			while (!flag);
			if (!flag)
			{
				this.ThrowUnexpectedEndException(reader, contract, obj, "Unexpected end when deserializing array.");
			}
			this.OnDeserialized(reader, contract, obj);
			return obj;
		}

		// Token: 0x06000BD2 RID: 3026
		// RVA: 0x000450F0 File Offset: 0x000432F0
		private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id)
		{
			int arrayRank = contract.UnderlyingType.GetArrayRank();
			if (id != null)
			{
				this.AddReference(reader, id, list);
			}
			this.OnDeserializing(reader, contract, list);
			JsonContract contractSafe = this.GetContractSafe(contract.CollectionItemType);
			JsonConverter converter = this.GetConverter(contractSafe, null, contract, containerProperty);
			int? num = null;
			Stack<IList> stack = new Stack<IList>();
			stack.Push(list);
			IList list2 = list;
			bool flag = false;
			while (true)
			{
				int depth = reader.Depth;
				if (stack.Count == arrayRank)
				{
					try
					{
						if (!this.ReadForType(reader, contractSafe, converter != null))
						{
							goto IL_214;
						}
						JsonToken tokenType = reader.TokenType;
						if (tokenType != JsonToken.Comment)
						{
							if (tokenType == JsonToken.EndArray)
							{
								stack.Pop();
								list2 = stack.Peek();
								num = null;
							}
							else
							{
								object value;
								if (converter != null && converter.CanRead)
								{
									value = this.DeserializeConvertable(converter, reader, contract.CollectionItemType, null);
								}
								else
								{
									value = this.CreateValueInternal(reader, contract.CollectionItemType, contractSafe, null, contract, containerProperty, null);
								}
								list2.Add(value);
							}
						}
					}
					catch (Exception ex)
					{
						JsonPosition position = reader.GetPosition(depth);
						if (!base.IsErrorHandled(list, contract, position.Position, reader as IJsonLineInfo, reader.Path, ex))
						{
							throw;
						}
						this.HandleError(reader, true, depth);
						if (num.HasValue && num == position.Position)
						{
							throw JsonSerializationException.Create(reader, "Infinite loop detected from error handling.", ex);
						}
						num = new int?(position.Position);
					}
				}
				else
				{
					if (!reader.Read())
					{
						goto IL_214;
					}
					JsonToken tokenType2 = reader.TokenType;
					if (tokenType2 != JsonToken.StartArray)
					{
						if (tokenType2 != JsonToken.Comment)
						{
							if (tokenType2 != JsonToken.EndArray)
							{
								break;
							}
							stack.Pop();
							if (stack.Count > 0)
							{
								list2 = stack.Peek();
							}
							else
							{
								flag = true;
							}
						}
					}
					else
					{
						IList list3 = new List<object>();
						list2.Add(list3);
						stack.Push(list3);
						list2 = list3;
					}
				}
				if (flag)
				{
					goto Block_9;
				}
			}
			throw JsonSerializationException.Create(reader, "Unexpected token when deserializing multidimensional array: " + reader.TokenType);
			Block_9:
			IL_214:
			if (!flag)
			{
				this.ThrowUnexpectedEndException(reader, contract, list, "Unexpected end when deserializing array.");
			}
			this.OnDeserialized(reader, contract, list);
			return list;
		}

		// Token: 0x06000BDC RID: 3036
		// RVA: 0x000460F0 File Offset: 0x000442F0
		private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id)
		{
			this.OnDeserializing(reader, contract, newObject);
			Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> arg_6D_0;
			if (!contract.HasRequiredOrDefaultValueProperties && !this.HasFlag(this.Serializer._defaultValueHandling, DefaultValueHandling.Populate))
			{
				arg_6D_0 = null;
			}
			else
			{
				arg_6D_0 = Enumerable.ToDictionary<JsonProperty, JsonProperty, JsonSerializerInternalReader.PropertyPresence>(contract.Properties, (JsonProperty m) => m, (JsonProperty m) => JsonSerializerInternalReader.PropertyPresence.None);
			}
			Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> dictionary = arg_6D_0;
			if (id != null)
			{
				this.AddReference(reader, id, newObject);
			}
			int depth = reader.Depth;
			bool flag = false;
			while (true)
			{
				JsonToken tokenType = reader.TokenType;
				switch (tokenType)
				{
				case JsonToken.PropertyName:
				{
					string text = reader.Value.ToString();
					if (!this.CheckPropertyName(reader, text))
					{
						try
						{
							JsonProperty closestMatchProperty = contract.Properties.GetClosestMatchProperty(text);
							if (closestMatchProperty == null)
							{
								if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= TraceLevel.Verbose)
								{
									this.TraceWriter.Trace(TraceLevel.Verbose, JsonPosition.FormatMessage(reader as IJsonLineInfo, reader.Path, StringUtils.FormatWith("Could not find member '{0}' on {1}", CultureInfo.InvariantCulture, text, contract.UnderlyingType)), null);
								}
								if (this.Serializer._missingMemberHandling == MissingMemberHandling.Error)
								{
									throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Could not find member '{0}' on object of type '{1}'", CultureInfo.InvariantCulture, text, contract.UnderlyingType.Name));
								}
								if (!reader.Read())
								{
									break;
								}
								this.SetExtensionData(contract, member, reader, text, newObject);
								break;
							}
							else
							{
								if (closestMatchProperty.PropertyContract == null)
								{
									closestMatchProperty.PropertyContract = this.GetContractSafe(closestMatchProperty.PropertyType);
								}
								JsonConverter converter = this.GetConverter(closestMatchProperty.PropertyContract, closestMatchProperty.MemberConverter, contract, member);
								if (!this.ReadForType(reader, closestMatchProperty.PropertyContract, converter != null))
								{
									throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Unexpected end when setting {0}'s value.", CultureInfo.InvariantCulture, text));
								}
								this.SetPropertyPresence(reader, closestMatchProperty, dictionary);
								if (!this.SetPropertyValue(closestMatchProperty, converter, contract, member, reader, newObject))
								{
									this.SetExtensionData(contract, member, reader, text, newObject);
								}
								break;
							}
						}
						catch (Exception ex)
						{
							if (!base.IsErrorHandled(newObject, contract, text, reader as IJsonLineInfo, reader.Path, ex))
							{
								throw;
							}
							this.HandleError(reader, true, depth);
							break;
						}
						goto IL_22C;
					}
					break;
				}
				case JsonToken.Comment:
					break;
				default:
					goto IL_22C;
				}
				IL_236:
				if (flag)
				{
					break;
				}
				if (!reader.Read())
				{
					break;
				}
				continue;
				IL_22C:
				if (tokenType != JsonToken.EndObject)
				{
					goto Block_9;
				}
				flag = true;
				goto IL_236;
			}
			goto IL_25A;
			Block_9:
			throw JsonSerializationException.Create(reader, "Unexpected token when deserializing object: " + reader.TokenType);
			IL_25A:
			if (!flag)
			{
				this.ThrowUnexpectedEndException(reader, contract, newObject, "Unexpected end when deserializing object.");
			}
			this.EndObject(newObject, reader, contract, depth, dictionary);
			this.OnDeserialized(reader, contract, newObject);
			return newObject;
		}

		// Token: 0x06000BDA RID: 3034
		// RVA: 0x00045F6C File Offset: 0x0004416C
		private bool ReadForType(JsonReader reader, JsonContract contract, bool hasConverter)
		{
			if (hasConverter)
			{
				return reader.Read();
			}
			switch ((contract != null) ? contract.InternalReadType : ReadType.Read)
			{
			case ReadType.Read:
				while (reader.Read())
				{
					if (reader.TokenType != JsonToken.Comment)
					{
						return true;
					}
				}
				return false;
			case ReadType.ReadAsInt32:
				reader.ReadAsInt32();
				break;
			case ReadType.ReadAsBytes:
				reader.ReadAsBytes();
				break;
			case ReadType.ReadAsString:
				reader.ReadAsString();
				break;
			case ReadType.ReadAsDecimal:
				reader.ReadAsDecimal();
				break;
			case ReadType.ReadAsDateTime:
				reader.ReadAsDateTime();
				break;
			default:
				throw new ArgumentOutOfRangeException();
			}
			return reader.TokenType != JsonToken.None;
		}

		// Token: 0x06000BC1 RID: 3009
		// RVA: 0x00044168 File Offset: 0x00042368
		private bool ReadMetadataProperties(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id)
		{
			id = null;
			newValue = null;
			if (reader.TokenType == JsonToken.PropertyName)
			{
				string text = reader.Value.ToString();
				if (text.Length > 0 && text[0] == '$')
				{
					string text2;
					do
					{
						text = reader.Value.ToString();
						bool flag;
						if (string.Equals(text, "$ref", StringComparison.Ordinal))
						{
							this.CheckedRead(reader);
							if (reader.TokenType != JsonToken.String && reader.TokenType != JsonToken.Null)
							{
								goto Block_11;
							}
							text2 = ((reader.Value != null) ? reader.Value.ToString() : null);
							this.CheckedRead(reader);
							if (text2 != null)
							{
								goto IL_157;
							}
							flag = true;
						}
						else if (string.Equals(text, "$type", StringComparison.Ordinal))
						{
							this.CheckedRead(reader);
							string qualifiedTypeName = reader.Value.ToString();
							this.ResolveTypeName(reader, ref objectType, ref contract, member, containerContract, containerMember, qualifiedTypeName);
							this.CheckedRead(reader);
							flag = true;
						}
						else if (string.Equals(text, "$id", StringComparison.Ordinal))
						{
							this.CheckedRead(reader);
							id = ((reader.Value != null) ? reader.Value.ToString() : null);
							this.CheckedRead(reader);
							flag = true;
						}
						else
						{
							if (string.Equals(text, "$values", StringComparison.Ordinal))
							{
								goto IL_1DE;
							}
							flag = false;
						}
						if (!flag)
						{
							break;
						}
					}
					while (reader.TokenType == JsonToken.PropertyName);
					return false;
					Block_11:
					throw JsonSerializationException.Create(reader, StringUtils.FormatWith("JSON reference {0} property must have a string or null value.", CultureInfo.InvariantCulture, "$ref"));
					IL_157:
					if (reader.TokenType == JsonToken.PropertyName)
					{
						throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Additional content found in JSON reference object. A JSON reference object should only have a {0} property.", CultureInfo.InvariantCulture, "$ref"));
					}
					newValue = this.Serializer.GetReferenceResolver().ResolveReference(this, text2);
					if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= TraceLevel.Info)
					{
						this.TraceWriter.Trace(TraceLevel.Info, JsonPosition.FormatMessage(reader as IJsonLineInfo, reader.Path, StringUtils.FormatWith("Resolved object reference '{0}' to {1}.", CultureInfo.InvariantCulture, text2, newValue.GetType())), null);
					}
					return true;
					IL_1DE:
					this.CheckedRead(reader);
					object obj = this.CreateList(reader, objectType, contract, member, existingValue, id);
					this.CheckedRead(reader);
					newValue = obj;
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000BC0 RID: 3008
		// RVA: 0x00043F40 File Offset: 0x00042140
		private bool ReadMetadataPropertiesToken(JTokenReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id)
		{
			id = null;
			newValue = null;
			if (reader.TokenType == JsonToken.StartObject)
			{
				JObject jObject = (JObject)reader.CurrentToken;
				JToken jToken = jObject["$ref"];
				if (jToken != null)
				{
					if (jToken.Type != JTokenType.String && jToken.Type != JTokenType.Null)
					{
						throw JsonSerializationException.Create(jToken, jToken.Path, StringUtils.FormatWith("JSON reference {0} property must have a string or null value.", CultureInfo.InvariantCulture, "$ref"), null);
					}
					JToken parent = jToken.Parent;
					JToken jToken2 = null;
					if (parent.Next != null)
					{
						jToken2 = parent.Next;
					}
					else if (parent.Previous != null)
					{
						jToken2 = parent.Previous;
					}
					string text = (string)jToken;
					if (text != null)
					{
						if (jToken2 != null)
						{
							throw JsonSerializationException.Create(jToken2, jToken2.Path, StringUtils.FormatWith("Additional content found in JSON reference object. A JSON reference object should only have a {0} property.", CultureInfo.InvariantCulture, "$ref"), null);
						}
						newValue = this.Serializer.GetReferenceResolver().ResolveReference(this, text);
						if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= TraceLevel.Info)
						{
							this.TraceWriter.Trace(TraceLevel.Info, JsonPosition.FormatMessage(reader, reader.Path, StringUtils.FormatWith("Resolved object reference '{0}' to {1}.", CultureInfo.InvariantCulture, text, newValue.GetType())), null);
						}
						reader.Skip();
						return true;
					}
				}
				JToken jToken3 = jObject["$type"];
				if (jToken3 != null)
				{
					string qualifiedTypeName = (string)jToken3;
					JsonReader reader2 = jToken3.CreateReader();
					this.CheckedRead(reader2);
					this.ResolveTypeName(reader2, ref objectType, ref contract, member, containerContract, containerMember, qualifiedTypeName);
					JToken jToken4 = jObject["$value"];
					if (jToken4 != null)
					{
						while (true)
						{
							this.CheckedRead(reader);
							if (reader.TokenType == JsonToken.PropertyName && (string)reader.Value == "$value")
							{
								break;
							}
							this.CheckedRead(reader);
							reader.Skip();
						}
						return false;
					}
				}
				JToken jToken5 = jObject["$id"];
				if (jToken5 != null)
				{
					id = (string)jToken5;
				}
				JToken jToken6 = jObject["$values"];
				if (jToken6 != null)
				{
					JsonReader reader3 = jToken6.CreateReader();
					this.CheckedRead(reader3);
					newValue = this.CreateList(reader3, objectType, contract, member, existingValue, id);
					reader.Skip();
					return true;
				}
			}
			this.CheckedRead(reader);
			return false;
		}

		// Token: 0x06000BD9 RID: 3033
		// RVA: 0x00045D18 File Offset: 0x00043F18
		private IDictionary<JsonProperty, object> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, Type objectType, out IDictionary<string, object> extensionData)
		{
			extensionData = ((contract.ExtensionDataSetter != null) ? new Dictionary<string, object>() : null);
			IDictionary<JsonProperty, object> dictionary = new Dictionary<JsonProperty, object>();
			bool flag = false;
			string text;
			do
			{
				JsonToken tokenType = reader.TokenType;
				switch (tokenType)
				{
				case JsonToken.PropertyName:
				{
					text = reader.Value.ToString();
					JsonProperty jsonProperty = contract.CreatorParameters.GetClosestMatchProperty(text) ?? contract.Properties.GetClosestMatchProperty(text);
					if (jsonProperty != null)
					{
						if (jsonProperty.PropertyContract == null)
						{
							jsonProperty.PropertyContract = this.GetContractSafe(jsonProperty.PropertyType);
						}
						JsonConverter converter = this.GetConverter(jsonProperty.PropertyContract, jsonProperty.MemberConverter, contract, containerProperty);
						if (!this.ReadForType(reader, jsonProperty.PropertyContract, converter != null))
						{
							goto IL_1F9;
						}
						if (!jsonProperty.Ignored)
						{
							if (jsonProperty.PropertyContract == null)
							{
								jsonProperty.PropertyContract = this.GetContractSafe(jsonProperty.PropertyType);
							}
							object value;
							if (converter != null && converter.CanRead)
							{
								value = this.DeserializeConvertable(converter, reader, jsonProperty.PropertyType, null);
							}
							else
							{
								value = this.CreateValueInternal(reader, jsonProperty.PropertyType, jsonProperty.PropertyContract, jsonProperty, contract, containerProperty, null);
							}
							dictionary[jsonProperty] = value;
							break;
						}
					}
					else
					{
						if (!reader.Read())
						{
							goto IL_210;
						}
						if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= TraceLevel.Verbose)
						{
							this.TraceWriter.Trace(TraceLevel.Verbose, JsonPosition.FormatMessage(reader as IJsonLineInfo, reader.Path, StringUtils.FormatWith("Could not find member '{0}' on {1}.", CultureInfo.InvariantCulture, text, contract.UnderlyingType)), null);
						}
						if (this.Serializer._missingMemberHandling == MissingMemberHandling.Error)
						{
							goto Block_15;
						}
					}
					if (extensionData != null)
					{
						object value2 = this.CreateValueInternal(reader, null, null, null, contract, containerProperty, null);
						extensionData[text] = value2;
					}
					else
					{
						reader.Skip();
					}
					break;
				}
				case JsonToken.Comment:
					break;
				default:
					if (tokenType != JsonToken.EndObject)
					{
						goto Block_17;
					}
					flag = true;
					break;
				}
				if (flag)
				{
					break;
				}
			}
			while (reader.Read());
			return dictionary;
			Block_15:
			throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Could not find member '{0}' on object of type '{1}'", CultureInfo.InvariantCulture, text, objectType.Name));
			Block_17:
			throw JsonSerializationException.Create(reader, "Unexpected token when deserializing object: " + reader.TokenType);
			IL_1F9:
			throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Unexpected end when setting {0}'s value.", CultureInfo.InvariantCulture, text));
			IL_210:
			throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Unexpected end when setting {0}'s value.", CultureInfo.InvariantCulture, text));
		}

		// Token: 0x06000BC2 RID: 3010
		// RVA: 0x00044380 File Offset: 0x00042580
		private void ResolveTypeName(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName)
		{
			TypeNameHandling typeNameHandling = ((member != null) ? member.TypeNameHandling : null) ?? (((containerContract != null) ? containerContract.ItemTypeNameHandling : null) ?? (((containerMember != null) ? containerMember.ItemTypeNameHandling : null) ?? this.Serializer._typeNameHandling));
			if (typeNameHandling != TypeNameHandling.None)
			{
				string typeName;
				string assemblyName;
				ReflectionUtils.SplitFullyQualifiedTypeName(qualifiedTypeName, out typeName, out assemblyName);
				Type type;
				try
				{
					type = this.Serializer._binder.BindToType(assemblyName, typeName);
				}
				catch (Exception ex)
				{
					throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Error resolving type specified in JSON '{0}'.", CultureInfo.InvariantCulture, qualifiedTypeName), ex);
				}
				if (type == null)
				{
					throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Type specified in JSON '{0}' was not resolved.", CultureInfo.InvariantCulture, qualifiedTypeName));
				}
				if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= TraceLevel.Verbose)
				{
					this.TraceWriter.Trace(TraceLevel.Verbose, JsonPosition.FormatMessage(reader as IJsonLineInfo, reader.Path, StringUtils.FormatWith("Resolved type '{0}' to {1}.", CultureInfo.InvariantCulture, qualifiedTypeName, type)), null);
				}
				if (objectType != null && !objectType.IsAssignableFrom(type))
				{
					throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Type specified in JSON '{0}' is not compatible with '{1}'.", CultureInfo.InvariantCulture, type.AssemblyQualifiedName, objectType.AssemblyQualifiedName));
				}
				objectType = type;
				contract = this.GetContractSafe(type);
			}
		}

		// Token: 0x06000BDE RID: 3038
		// RVA: 0x000463FC File Offset: 0x000445FC
		private void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, object o)
		{
			if (contract.ExtensionDataSetter != null)
			{
				try
				{
					object value = this.CreateValueInternal(reader, null, null, null, contract, member, null);
					contract.ExtensionDataSetter(o, memberName, value);
					return;
				}
				catch (Exception ex)
				{
					throw JsonSerializationException.Create(reader, StringUtils.FormatWith("Error setting value in extension data for type '{0}'.", CultureInfo.InvariantCulture, contract.UnderlyingType), ex);
				}
			}
			reader.Skip();
		}

		// Token: 0x06000BE0 RID: 3040
		// RVA: 0x0000D185 File Offset: 0x0000B385
		private void SetPropertyPresence(JsonReader reader, JsonProperty property, Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> requiredProperties)
		{
			if (property != null && requiredProperties != null)
			{
				requiredProperties[property] = ((reader.TokenType == JsonToken.Null || reader.TokenType == JsonToken.Undefined) ? JsonSerializerInternalReader.PropertyPresence.Null : JsonSerializerInternalReader.PropertyPresence.Value);
			}
		}

		// Token: 0x06000BC8 RID: 3016
		// RVA: 0x00044828 File Offset: 0x00042A28
		private bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target)
		{
			bool flag;
			object value;
			JsonContract contract;
			bool flag2;
			if (this.CalculatePropertyDetails(property, ref propertyConverter, containerContract, containerProperty, reader, target, out flag, out value, out contract, out flag2))
			{
				return false;
			}
			object obj;
			if (propertyConverter != null && propertyConverter.CanRead)
			{
				if (!flag2 && target != null && property.Readable)
				{
					value = property.ValueProvider.GetValue(target);
				}
				obj = this.DeserializeConvertable(propertyConverter, reader, property.PropertyType, value);
			}
			else
			{
				obj = this.CreateValueInternal(reader, property.PropertyType, contract, property, containerContract, containerProperty, flag ? value : null);
			}
			if ((!flag || obj != value) && this.ShouldSetPropertyValue(property, obj))
			{
				property.ValueProvider.SetValue(target, obj);
				if (property.SetIsSpecified != null)
				{
					if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= TraceLevel.Verbose)
					{
						this.TraceWriter.Trace(TraceLevel.Verbose, JsonPosition.FormatMessage(reader as IJsonLineInfo, reader.Path, StringUtils.FormatWith("IsSpecified for property '{0}' on {1} set to true.", CultureInfo.InvariantCulture, property.PropertyName, property.DeclaringType)), null);
					}
					property.SetIsSpecified(target, true);
				}
				return true;
			}
			return flag;
		}

		// Token: 0x06000BCC RID: 3020
		// RVA: 0x00044B70 File Offset: 0x00042D70
		private bool ShouldSetPropertyValue(JsonProperty property, object value)
		{
			return (property.NullValueHandling.GetValueOrDefault(this.Serializer._nullValueHandling) != NullValueHandling.Ignore || value != null) && (!this.HasFlag(property.DefaultValueHandling.GetValueOrDefault(this.Serializer._defaultValueHandling), DefaultValueHandling.Ignore) || this.HasFlag(property.DefaultValueHandling.GetValueOrDefault(this.Serializer._defaultValueHandling), DefaultValueHandling.Populate) || !MiscellaneousUtils.ValueEquals(value, property.GetResolvedDefaultValue())) && property.Writable;
		}

		// Token: 0x06000BD3 RID: 3027
		// RVA: 0x00045340 File Offset: 0x00043540
		private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object currentObject, string message)
		{
			try
			{
				throw JsonSerializationException.Create(reader, message);
			}
			catch (Exception ex)
			{
				if (!base.IsErrorHandled(currentObject, contract, null, reader as IJsonLineInfo, reader.Path, ex))
				{
					throw;
				}
				this.HandleError(reader, false, 0);
			}
		}
	}
}
