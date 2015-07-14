using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;
using Newtonsoft.Json.Utilities.LinqBridge;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000124 RID: 292
	internal sealed class JsonSerializerInternalWriter : JsonSerializerInternalBase
	{
		// Token: 0x04000518 RID: 1304
		private JsonSerializerProxy _internalSerializer;

		// Token: 0x04000515 RID: 1301
		private JsonContract _rootContract;

		// Token: 0x04000516 RID: 1302
		private int _rootLevel;

		// Token: 0x04000517 RID: 1303
		private readonly List<object> _serializeStack = new List<object>();

		// Token: 0x06000BEA RID: 3050
		// RVA: 0x0000D1F5 File Offset: 0x0000B3F5
		public JsonSerializerInternalWriter(JsonSerializer serializer) : base(serializer)
		{
		}

		// Token: 0x06000BFB RID: 3067
		// RVA: 0x00046FC8 File Offset: 0x000451C8
		private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, out JsonContract memberContract, out object memberValue)
		{
			if (!property.Ignored && property.Readable && this.ShouldSerialize(writer, property, value) && this.IsSpecified(writer, property, value))
			{
				if (property.PropertyContract == null)
				{
					property.PropertyContract = this.Serializer._contractResolver.ResolveContract(property.PropertyType);
				}
				memberValue = property.ValueProvider.GetValue(value);
				memberContract = (property.PropertyContract.IsSealed ? property.PropertyContract : this.GetContractSafe(memberValue));
				if (this.ShouldWriteProperty(memberValue, property))
				{
					if (this.ShouldWriteReference(memberValue, property, memberContract, contract, member))
					{
						property.WritePropertyName(writer);
						this.WriteReference(writer, memberValue);
						return false;
					}
					if (!this.CheckForCircularReference(writer, memberValue, property, memberContract, contract, member))
					{
						return false;
					}
					if (memberValue == null)
					{
						JsonObjectContract jsonObjectContract = contract as JsonObjectContract;
						Required required = property._required ?? (((jsonObjectContract != null) ? jsonObjectContract.ItemRequired : null) ?? Required.Default);
						if (required == Required.Always)
						{
							throw JsonSerializationException.Create(null, writer.ContainerPath, StringUtils.FormatWith("Cannot write a null value for property '{0}'. Property requires a value.", CultureInfo.InvariantCulture, property.PropertyName), null);
						}
					}
					return true;
				}
			}
			memberContract = null;
			memberValue = null;
			return false;
		}

		// Token: 0x06000BF3 RID: 3059
		// RVA: 0x00046A3C File Offset: 0x00044C3C
		private bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			if (value != null && contract.ContractType != JsonContractType.Primitive)
			{
				if (contract.ContractType != JsonContractType.String)
				{
					ReferenceLoopHandling? referenceLoopHandling = null;
					if (property != null)
					{
						referenceLoopHandling = property.ReferenceLoopHandling;
					}
					if (!referenceLoopHandling.HasValue && containerProperty != null)
					{
						referenceLoopHandling = containerProperty.ItemReferenceLoopHandling;
					}
					if (!referenceLoopHandling.HasValue && containerContract != null)
					{
						referenceLoopHandling = containerContract.ItemReferenceLoopHandling;
					}
					if (this._serializeStack.IndexOf(value) != -1)
					{
						string text = "Self referencing loop detected";
						if (property != null)
						{
							text += StringUtils.FormatWith(" for property '{0}'", CultureInfo.InvariantCulture, property.PropertyName);
						}
						text += StringUtils.FormatWith(" with type '{0}'.", CultureInfo.InvariantCulture, value.GetType());
						switch (referenceLoopHandling.GetValueOrDefault(this.Serializer._referenceLoopHandling))
						{
						case ReferenceLoopHandling.Error:
							throw JsonSerializationException.Create(null, writer.ContainerPath, text, null);
						case ReferenceLoopHandling.Ignore:
							if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= TraceLevel.Verbose)
							{
								this.TraceWriter.Trace(TraceLevel.Verbose, JsonPosition.FormatMessage(null, writer.Path, text + ". Skipping serializing self referenced value."), null);
							}
							return false;
						case ReferenceLoopHandling.Serialize:
							if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= TraceLevel.Verbose)
							{
								this.TraceWriter.Trace(TraceLevel.Verbose, JsonPosition.FormatMessage(null, writer.Path, text + ". Serializing self referenced value."), null);
							}
							return true;
						}
					}
					return true;
				}
			}
			return true;
		}

		// Token: 0x06000BED RID: 3053
		// RVA: 0x0000D225 File Offset: 0x0000B425
		private JsonContract GetContractSafe(object value)
		{
			if (value == null)
			{
				return null;
			}
			return this.Serializer._contractResolver.ResolveContract(value.GetType());
		}

		// Token: 0x06000BEC RID: 3052
		// RVA: 0x0000D209 File Offset: 0x0000B409
		private JsonSerializerProxy GetInternalSerializer()
		{
			if (this._internalSerializer == null)
			{
				this._internalSerializer = new JsonSerializerProxy(this);
			}
			return this._internalSerializer;
		}

		// Token: 0x06000C0B RID: 3083
		// RVA: 0x00047BF4 File Offset: 0x00045DF4
		private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, out bool escape)
		{
			if (contract.ContractType == JsonContractType.Primitive)
			{
				JsonPrimitiveContract jsonPrimitiveContract = (JsonPrimitiveContract)contract;
				if (jsonPrimitiveContract.TypeCode != PrimitiveTypeCode.DateTime)
				{
					if (jsonPrimitiveContract.TypeCode != PrimitiveTypeCode.DateTimeNullable)
					{
						escape = true;
						return Convert.ToString(name, CultureInfo.InvariantCulture);
					}
				}
				escape = false;
				StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
				DateTimeUtils.WriteDateTimeString(stringWriter, (DateTime)name, writer.DateFormatHandling, writer.DateFormatString, writer.Culture);
				return stringWriter.ToString();
			}
			string result;
			if (JsonSerializerInternalWriter.TryConvertToString(name, name.GetType(), out result))
			{
				escape = true;
				return result;
			}
			escape = true;
			return name.ToString();
		}

		// Token: 0x06000BF5 RID: 3061
		// RVA: 0x00046C2C File Offset: 0x00044E2C
		private string GetReference(JsonWriter writer, object value)
		{
			string result;
			try
			{
				string reference = this.Serializer.GetReferenceResolver().GetReference(this, value);
				result = reference;
			}
			catch (Exception ex)
			{
				throw JsonSerializationException.Create(null, writer.ContainerPath, StringUtils.FormatWith("Error writing object reference for '{0}'.", CultureInfo.InvariantCulture, value.GetType()), ex);
			}
			return result;
		}

		// Token: 0x06000C0C RID: 3084
		// RVA: 0x0000D242 File Offset: 0x0000B442
		private void HandleError(JsonWriter writer, int initialDepth)
		{
			base.ClearErrorContext();
			if (writer.WriteState == WriteState.Property)
			{
				writer.WriteNull();
			}
			while (writer.Top > initialDepth)
			{
				writer.WriteEnd();
			}
		}

		// Token: 0x06000BFF RID: 3071
		// RVA: 0x00006E28 File Offset: 0x00005028
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			return (value & flag) == flag;
		}

		// Token: 0x06000C00 RID: 3072
		// RVA: 0x00006E28 File Offset: 0x00005028
		private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag)
		{
			return (value & flag) == flag;
		}

		// Token: 0x06000C01 RID: 3073
		// RVA: 0x00006E28 File Offset: 0x00005028
		private bool HasFlag(TypeNameHandling value, TypeNameHandling flag)
		{
			return (value & flag) == flag;
		}

		// Token: 0x06000C0E RID: 3086
		// RVA: 0x00047D04 File Offset: 0x00045F04
		private bool IsSpecified(JsonWriter writer, JsonProperty property, object target)
		{
			if (property.GetIsSpecified == null)
			{
				return true;
			}
			bool flag = property.GetIsSpecified(target);
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= TraceLevel.Verbose)
			{
				this.TraceWriter.Trace(TraceLevel.Verbose, JsonPosition.FormatMessage(null, writer.Path, StringUtils.FormatWith("IsSpecified result for property '{0}' on {1}: {2}", CultureInfo.InvariantCulture, property.PropertyName, property.DeclaringType, flag)), null);
			}
			return flag;
		}

		// Token: 0x06000BF9 RID: 3065
		// RVA: 0x00046D90 File Offset: 0x00044F90
		private void OnSerialized(JsonWriter writer, JsonContract contract, object value)
		{
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= TraceLevel.Info)
			{
				this.TraceWriter.Trace(TraceLevel.Info, JsonPosition.FormatMessage(null, writer.Path, StringUtils.FormatWith("Finished serializing {0}", CultureInfo.InvariantCulture, contract.UnderlyingType)), null);
			}
			contract.InvokeOnSerialized(value, this.Serializer._context);
		}

		// Token: 0x06000BF8 RID: 3064
		// RVA: 0x00046D2C File Offset: 0x00044F2C
		private void OnSerializing(JsonWriter writer, JsonContract contract, object value)
		{
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= TraceLevel.Info)
			{
				this.TraceWriter.Trace(TraceLevel.Info, JsonPosition.FormatMessage(null, writer.Path, StringUtils.FormatWith("Started serializing {0}", CultureInfo.InvariantCulture, contract.UnderlyingType)), null);
			}
			contract.InvokeOnSerializing(value, this.Serializer._context);
		}

		// Token: 0x06000BF0 RID: 3056
		// RVA: 0x000468E8 File Offset: 0x00044AE8
		private bool? ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			bool? result = null;
			if (property != null)
			{
				result = property.IsReference;
			}
			if (!result.HasValue && containerProperty != null)
			{
				result = containerProperty.ItemIsReference;
			}
			if (!result.HasValue && collectionContract != null)
			{
				result = collectionContract.ItemIsReference;
			}
			if (!result.HasValue)
			{
				result = contract.IsReference;
			}
			return result;
		}

		// Token: 0x06000BEB RID: 3051
		// RVA: 0x0004663C File Offset: 0x0004483C
		public void Serialize(JsonWriter jsonWriter, object value, Type objectType)
		{
			if (jsonWriter == null)
			{
				throw new ArgumentNullException("jsonWriter");
			}
			this._rootContract = ((objectType != null) ? this.Serializer._contractResolver.ResolveContract(objectType) : null);
			this._rootLevel = this._serializeStack.Count + 1;
			JsonContract contractSafe = this.GetContractSafe(value);
			try
			{
				this.SerializeValue(jsonWriter, value, contractSafe, null, null, null);
			}
			catch (Exception ex)
			{
				if (!base.IsErrorHandled(null, contractSafe, null, null, jsonWriter.Path, ex))
				{
					base.ClearErrorContext();
					throw;
				}
				this.HandleError(jsonWriter, 0);
			}
			finally
			{
				this._rootContract = null;
			}
		}

		// Token: 0x06000C02 RID: 3074
		// RVA: 0x00047298 File Offset: 0x00045498
		private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			if (this.ShouldWriteReference(value, null, contract, collectionContract, containerProperty))
			{
				this.WriteReference(writer, value);
				return;
			}
			if (!this.CheckForCircularReference(writer, value, null, contract, collectionContract, containerProperty))
			{
				return;
			}
			this._serializeStack.Add(value);
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= TraceLevel.Info)
			{
				this.TraceWriter.Trace(TraceLevel.Info, JsonPosition.FormatMessage(null, writer.Path, StringUtils.FormatWith("Started serializing {0} with converter {1}.", CultureInfo.InvariantCulture, value.GetType(), converter.GetType())), null);
			}
			converter.WriteJson(writer, value, this.GetInternalSerializer());
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= TraceLevel.Info)
			{
				this.TraceWriter.Trace(TraceLevel.Info, JsonPosition.FormatMessage(null, writer.Path, StringUtils.FormatWith("Finished serializing {0} with converter {1}.", CultureInfo.InvariantCulture, value.GetType(), converter.GetType())), null);
			}
			this._serializeStack.RemoveAt(this._serializeStack.Count - 1);
		}

		// Token: 0x06000C0A RID: 3082
		// RVA: 0x000479FC File Offset: 0x00045BFC
		private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			IWrappedDictionary wrappedDictionary = values as IWrappedDictionary;
			object obj = (wrappedDictionary != null) ? wrappedDictionary.UnderlyingDictionary : values;
			this.OnSerializing(writer, contract, obj);
			this._serializeStack.Add(obj);
			this.WriteObjectStart(writer, obj, contract, member, collectionContract, containerProperty);
			if (contract.ItemContract == null)
			{
				contract.ItemContract = this.Serializer._contractResolver.ResolveContract(contract.DictionaryValueType ?? typeof(object));
			}
			if (contract.KeyContract == null)
			{
				contract.KeyContract = this.Serializer._contractResolver.ResolveContract(contract.DictionaryKeyType ?? typeof(object));
			}
			int top = writer.Top;
			foreach (DictionaryEntry dictionaryEntry in values)
			{
				bool escape;
				string text = this.GetPropertyName(writer, dictionaryEntry.Key, contract.KeyContract, out escape);
				text = ((contract.PropertyNameResolver != null) ? contract.PropertyNameResolver(text) : text);
				try
				{
					object value = dictionaryEntry.Value;
					JsonContract jsonContract = contract.FinalItemContract ?? this.GetContractSafe(value);
					if (this.ShouldWriteReference(value, null, jsonContract, contract, member))
					{
						writer.WritePropertyName(text, escape);
						this.WriteReference(writer, value);
					}
					else if (this.CheckForCircularReference(writer, value, null, jsonContract, contract, member))
					{
						writer.WritePropertyName(text, escape);
						this.SerializeValue(writer, value, jsonContract, null, contract, member);
					}
				}
				catch (Exception ex)
				{
					if (!base.IsErrorHandled(obj, contract, text, null, writer.ContainerPath, ex))
					{
						throw;
					}
					this.HandleError(writer, top);
				}
			}
			writer.WriteEndObject();
			this._serializeStack.RemoveAt(this._serializeStack.Count - 1);
			this.OnSerialized(writer, contract, obj);
		}

		// Token: 0x06000C07 RID: 3079
		// RVA: 0x00047744 File Offset: 0x00045944
		private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			if (!JsonTypeReflector.FullyTrusted)
			{
				string text = "Type '{0}' implements ISerializable but cannot be serialized using the ISerializable interface because the current application is not fully trusted and ISerializable can expose secure data." + Environment.NewLine + "To fix this error either change the environment to be fully trusted, change the application to not deserialize the type, add JsonObjectAttribute to the type or change the JsonSerializer setting ContractResolver to use a new DefaultContractResolver with IgnoreSerializableInterface set to true." + Environment.NewLine;
				text = StringUtils.FormatWith(text, CultureInfo.InvariantCulture, value.GetType());
				throw JsonSerializationException.Create(null, writer.ContainerPath, text, null);
			}
			this.OnSerializing(writer, contract, value);
			this._serializeStack.Add(value);
			this.WriteObjectStart(writer, value, contract, member, collectionContract, containerProperty);
			SerializationInfo serializationInfo = new SerializationInfo(contract.UnderlyingType, new FormatterConverter());
			value.GetObjectData(serializationInfo, this.Serializer._context);
			SerializationInfoEnumerator enumerator = serializationInfo.GetEnumerator();
			while (enumerator.MoveNext())
			{
				SerializationEntry current = enumerator.Current;
				JsonContract contractSafe = this.GetContractSafe(current.Value);
				if (this.ShouldWriteReference(current.Value, null, contractSafe, contract, member))
				{
					writer.WritePropertyName(current.Name);
					this.WriteReference(writer, current.Value);
				}
				else if (this.CheckForCircularReference(writer, current.Value, null, contractSafe, contract, member))
				{
					writer.WritePropertyName(current.Name);
					this.SerializeValue(writer, current.Value, contractSafe, null, contract, member);
				}
			}
			writer.WriteEndObject();
			this._serializeStack.RemoveAt(this._serializeStack.Count - 1);
			this.OnSerialized(writer, contract, value);
		}

		// Token: 0x06000C03 RID: 3075
		// RVA: 0x00047398 File Offset: 0x00045598
		private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			IWrappedCollection wrappedCollection = values as IWrappedCollection;
			object obj = (wrappedCollection != null) ? wrappedCollection.UnderlyingCollection : values;
			this.OnSerializing(writer, contract, obj);
			this._serializeStack.Add(obj);
			bool flag = this.WriteStartArray(writer, obj, contract, member, collectionContract, containerProperty);
			writer.WriteStartArray();
			int top = writer.Top;
			int num = 0;
			foreach (object current in values)
			{
				try
				{
					JsonContract jsonContract = contract.FinalItemContract ?? this.GetContractSafe(current);
					if (this.ShouldWriteReference(current, null, jsonContract, contract, member))
					{
						this.WriteReference(writer, current);
					}
					else if (this.CheckForCircularReference(writer, current, null, jsonContract, contract, member))
					{
						this.SerializeValue(writer, current, jsonContract, null, contract, member);
					}
				}
				catch (Exception ex)
				{
					if (!base.IsErrorHandled(obj, contract, num, null, writer.ContainerPath, ex))
					{
						throw;
					}
					this.HandleError(writer, top);
				}
				finally
				{
					num++;
				}
			}
			writer.WriteEndArray();
			if (flag)
			{
				writer.WriteEndObject();
			}
			this._serializeStack.RemoveAt(this._serializeStack.Count - 1);
			this.OnSerialized(writer, contract, obj);
		}

		// Token: 0x06000C04 RID: 3076
		// RVA: 0x00047504 File Offset: 0x00045704
		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			this.OnSerializing(writer, contract, values);
			this._serializeStack.Add(values);
			bool flag = this.WriteStartArray(writer, values, contract, member, collectionContract, containerProperty);
			this.SerializeMultidimensionalArray(writer, values, contract, member, writer.Top, new int[0]);
			if (flag)
			{
				writer.WriteEndObject();
			}
			this._serializeStack.RemoveAt(this._serializeStack.Count - 1);
			this.OnSerialized(writer, contract, values);
		}

		// Token: 0x06000C05 RID: 3077
		// RVA: 0x00047578 File Offset: 0x00045778
		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, int[] indices)
		{
			int num = indices.Length;
			int[] array = new int[num + 1];
			for (int i = 0; i < num; i++)
			{
				array[i] = indices[i];
			}
			writer.WriteStartArray();
			int j = 0;
			while (j < values.GetLength(num))
			{
				array[num] = j;
				if (array.Length == values.Rank)
				{
					object value = values.GetValue(array);
					try
					{
						JsonContract jsonContract = contract.FinalItemContract ?? this.GetContractSafe(value);
						if (this.ShouldWriteReference(value, null, jsonContract, contract, member))
						{
							this.WriteReference(writer, value);
						}
						else if (this.CheckForCircularReference(writer, value, null, jsonContract, contract, member))
						{
							this.SerializeValue(writer, value, jsonContract, null, contract, member);
						}
						goto IL_DE;
					}
					catch (Exception ex)
					{
						if (!base.IsErrorHandled(values, contract, j, null, writer.ContainerPath, ex))
						{
							throw;
						}
						this.HandleError(writer, initialDepth + 1);
						goto IL_DE;
					}
					goto IL_CE;
				}
				goto IL_CE;
				IL_DE:
				j++;
				continue;
				IL_CE:
				this.SerializeMultidimensionalArray(writer, values, contract, member, initialDepth + 1, array);
				goto IL_DE;
			}
			writer.WriteEndArray();
		}

		// Token: 0x06000BFA RID: 3066
		// RVA: 0x00046DF4 File Offset: 0x00044FF4
		private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			this.OnSerializing(writer, contract, value);
			this._serializeStack.Add(value);
			this.WriteObjectStart(writer, value, contract, member, collectionContract, containerProperty);
			int top = writer.Top;
			for (int i = 0; i < contract.Properties.Count; i++)
			{
				JsonProperty jsonProperty = contract.Properties[i];
				try
				{
					JsonContract valueContract;
					object value2;
					if (this.CalculatePropertyValues(writer, value, contract, member, jsonProperty, out valueContract, out value2))
					{
						jsonProperty.WritePropertyName(writer);
						this.SerializeValue(writer, value2, valueContract, jsonProperty, contract, member);
					}
				}
				catch (Exception ex)
				{
					if (!base.IsErrorHandled(value, contract, jsonProperty.PropertyName, null, writer.ContainerPath, ex))
					{
						throw;
					}
					this.HandleError(writer, top);
				}
			}
			if (contract.ExtensionDataGetter != null)
			{
				IEnumerable<KeyValuePair<object, object>> enumerable = contract.ExtensionDataGetter(value);
				if (enumerable != null)
				{
					foreach (KeyValuePair<object, object> current in enumerable)
					{
						JsonContract contractSafe = this.GetContractSafe(current.Key);
						JsonContract contractSafe2 = this.GetContractSafe(current.Value);
						bool flag;
						string propertyName = this.GetPropertyName(writer, current.Key, contractSafe, out flag);
						if (this.ShouldWriteReference(current.Value, null, contractSafe2, contract, member))
						{
							writer.WritePropertyName(propertyName);
							this.WriteReference(writer, current.Value);
						}
						else if (this.CheckForCircularReference(writer, current.Value, null, contractSafe2, contract, member))
						{
							writer.WritePropertyName(propertyName);
							this.SerializeValue(writer, current.Value, contractSafe2, null, contract, member);
						}
					}
				}
			}
			writer.WriteEndObject();
			this._serializeStack.RemoveAt(this._serializeStack.Count - 1);
			this.OnSerialized(writer, contract, value);
		}

		// Token: 0x06000BEE RID: 3054
		// RVA: 0x000466EC File Offset: 0x000448EC
		private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			if (contract.TypeCode == PrimitiveTypeCode.Bytes && this.ShouldWriteType(TypeNameHandling.Objects, contract, member, containerContract, containerProperty))
			{
				writer.WriteStartObject();
				this.WriteTypeProperty(writer, contract.CreatedType);
				writer.WritePropertyName("$value", false);
				JsonWriter.WriteValue(writer, contract.TypeCode, value);
				writer.WriteEndObject();
				return;
			}
			JsonWriter.WriteValue(writer, contract.TypeCode, value);
		}

		// Token: 0x06000BF7 RID: 3063
		// RVA: 0x00046CF4 File Offset: 0x00044EF4
		private void SerializeString(JsonWriter writer, object value, JsonStringContract contract)
		{
			this.OnSerializing(writer, contract, value);
			string value2;
			JsonSerializerInternalWriter.TryConvertToString(value, contract.UnderlyingType, out value2);
			writer.WriteValue(value2);
			this.OnSerialized(writer, contract, value);
		}

		// Token: 0x06000BEF RID: 3055
		// RVA: 0x00046754 File Offset: 0x00044954
		private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			JsonConverter arg_65_0;
			if (member != null)
			{
				if ((arg_65_0 = member.Converter) != null)
				{
					goto IL_65;
				}
			}
			if (containerProperty != null)
			{
				if ((arg_65_0 = containerProperty.ItemConverter) != null)
				{
					goto IL_65;
				}
			}
			if (containerContract != null)
			{
				if ((arg_65_0 = containerContract.ItemConverter) != null)
				{
					goto IL_65;
				}
			}
			if ((arg_65_0 = valueContract.Converter) == null)
			{
				arg_65_0 = (this.Serializer.GetMatchingConverter(valueContract.UnderlyingType) ?? valueContract.InternalConverter);
			}
			IL_65:
			JsonConverter jsonConverter = arg_65_0;
			if (jsonConverter != null && jsonConverter.CanWrite)
			{
				this.SerializeConvertable(writer, jsonConverter, value, valueContract, containerContract, containerProperty);
				return;
			}
			switch (valueContract.ContractType)
			{
			case JsonContractType.Object:
				this.SerializeObject(writer, value, (JsonObjectContract)valueContract, member, containerContract, containerProperty);
				return;
			case JsonContractType.Array:
			{
				JsonArrayContract jsonArrayContract = (JsonArrayContract)valueContract;
				if (!jsonArrayContract.IsMultidimensionalArray)
				{
					this.SerializeList(writer, (IEnumerable)value, jsonArrayContract, member, containerContract, containerProperty);
					return;
				}
				this.SerializeMultidimensionalArray(writer, (Array)value, jsonArrayContract, member, containerContract, containerProperty);
				return;
			}
			case JsonContractType.Primitive:
				this.SerializePrimitive(writer, value, (JsonPrimitiveContract)valueContract, member, containerContract, containerProperty);
				return;
			case JsonContractType.String:
				this.SerializeString(writer, value, (JsonStringContract)valueContract);
				return;
			case JsonContractType.Dictionary:
			{
				JsonDictionaryContract jsonDictionaryContract = (JsonDictionaryContract)valueContract;
				this.SerializeDictionary(writer, (value is IDictionary) ? ((IDictionary)value) : jsonDictionaryContract.CreateWrapper(value), jsonDictionaryContract, member, containerContract, containerProperty);
				return;
			}
			case JsonContractType.Dynamic:
				break;
			case JsonContractType.Serializable:
				this.SerializeISerializable(writer, (ISerializable)value, (JsonISerializableContract)valueContract, member, containerContract, containerProperty);
				return;
			case JsonContractType.Linq:
				((JToken)value).WriteTo(writer, Enumerable.ToArray<JsonConverter>(this.Serializer.Converters));
				break;
			default:
				return;
			}
		}

		// Token: 0x06000C0D RID: 3085
		// RVA: 0x00047C8C File Offset: 0x00045E8C
		private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target)
		{
			if (property.ShouldSerialize == null)
			{
				return true;
			}
			bool flag = property.ShouldSerialize(target);
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= TraceLevel.Verbose)
			{
				this.TraceWriter.Trace(TraceLevel.Verbose, JsonPosition.FormatMessage(null, writer.Path, StringUtils.FormatWith("ShouldSerialize result for property '{0}' on {1}: {2}", CultureInfo.InvariantCulture, property.PropertyName, property.DeclaringType, flag)), null);
			}
			return flag;
		}

		// Token: 0x06000C08 RID: 3080
		// RVA: 0x00047894 File Offset: 0x00045A94
		private bool ShouldWriteDynamicProperty(object memberValue)
		{
			return (this.Serializer._nullValueHandling != NullValueHandling.Ignore || memberValue != null) && (!this.HasFlag(this.Serializer._defaultValueHandling, DefaultValueHandling.Ignore) || (memberValue != null && !MiscellaneousUtils.ValueEquals(memberValue, ReflectionUtils.GetDefaultValue(memberValue.GetType()))));
		}

		// Token: 0x06000BF2 RID: 3058
		// RVA: 0x000469D8 File Offset: 0x00044BD8
		private bool ShouldWriteProperty(object memberValue, JsonProperty property)
		{
			return (property.NullValueHandling.GetValueOrDefault(this.Serializer._nullValueHandling) != NullValueHandling.Ignore || memberValue != null) && (!this.HasFlag(property.DefaultValueHandling.GetValueOrDefault(this.Serializer._defaultValueHandling), DefaultValueHandling.Ignore) || !MiscellaneousUtils.ValueEquals(memberValue, property.GetResolvedDefaultValue()));
		}

		// Token: 0x06000BF1 RID: 3057
		// RVA: 0x00046940 File Offset: 0x00044B40
		private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			if (value == null)
			{
				return false;
			}
			if (valueContract.ContractType != JsonContractType.Primitive)
			{
				if (valueContract.ContractType != JsonContractType.String)
				{
					bool? flag = this.ResolveIsReference(valueContract, property, collectionContract, containerProperty);
					if (!flag.HasValue)
					{
						if (valueContract.ContractType == JsonContractType.Array)
						{
							flag = new bool?(this.HasFlag(this.Serializer._preserveReferencesHandling, PreserveReferencesHandling.Arrays));
						}
						else
						{
							flag = new bool?(this.HasFlag(this.Serializer._preserveReferencesHandling, PreserveReferencesHandling.Objects));
						}
					}
					return flag.Value && this.Serializer.GetReferenceResolver().IsReferenced(this, value);
				}
			}
			return false;
		}

		// Token: 0x06000C09 RID: 3081
		// RVA: 0x000478E4 File Offset: 0x00045AE4
		private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			TypeNameHandling value = ((member != null) ? member.TypeNameHandling : null) ?? (((containerProperty != null) ? containerProperty.ItemTypeNameHandling : null) ?? (((containerContract != null) ? containerContract.ItemTypeNameHandling : null) ?? this.Serializer._typeNameHandling));
			if (this.HasFlag(value, typeNameHandlingFlag))
			{
				return true;
			}
			if (this.HasFlag(value, TypeNameHandling.Auto))
			{
				if (member != null)
				{
					if (contract.UnderlyingType != member.PropertyContract.CreatedType)
					{
						return true;
					}
				}
				else if (containerContract != null)
				{
					if (containerContract.ItemContract == null || contract.UnderlyingType != containerContract.ItemContract.CreatedType)
					{
						return true;
					}
				}
				else if (this._rootContract != null && this._serializeStack.Count == this._rootLevel && contract.UnderlyingType != this._rootContract.CreatedType)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000BF6 RID: 3062
		// RVA: 0x00046C88 File Offset: 0x00044E88
		internal static bool TryConvertToString(object value, Type type, out string s)
		{
			TypeConverter converter = ConvertUtils.GetConverter(type);
			if (converter != null && !(converter is ComponentConverter) && converter.GetType() != typeof(TypeConverter) && converter.CanConvertTo(typeof(string)))
			{
				s = converter.ConvertToInvariantString(value);
				return true;
			}
			if (value is Type)
			{
				s = ((Type)value).AssemblyQualifiedName;
				return true;
			}
			s = null;
			return false;
		}

		// Token: 0x06000BFC RID: 3068
		// RVA: 0x00047138 File Offset: 0x00045338
		private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			writer.WriteStartObject();
			if (this.ResolveIsReference(contract, member, collectionContract, containerProperty) ?? this.HasFlag(this.Serializer._preserveReferencesHandling, PreserveReferencesHandling.Objects))
			{
				this.WriteReferenceIdProperty(writer, contract.UnderlyingType, value);
			}
			if (this.ShouldWriteType(TypeNameHandling.Objects, contract, member, collectionContract, containerProperty))
			{
				this.WriteTypeProperty(writer, contract.UnderlyingType);
			}
		}

		// Token: 0x06000BF4 RID: 3060
		// RVA: 0x00046BB0 File Offset: 0x00044DB0
		private void WriteReference(JsonWriter writer, object value)
		{
			string reference = this.GetReference(writer, value);
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= TraceLevel.Info)
			{
				this.TraceWriter.Trace(TraceLevel.Info, JsonPosition.FormatMessage(null, writer.Path, StringUtils.FormatWith("Writing object reference to Id '{0}' for {1}.", CultureInfo.InvariantCulture, reference, value.GetType())), null);
			}
			writer.WriteStartObject();
			writer.WritePropertyName("$ref", false);
			writer.WriteValue(reference);
			writer.WriteEndObject();
		}

		// Token: 0x06000BFD RID: 3069
		// RVA: 0x000471AC File Offset: 0x000453AC
		private void WriteReferenceIdProperty(JsonWriter writer, Type type, object value)
		{
			string reference = this.GetReference(writer, value);
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= TraceLevel.Verbose)
			{
				this.TraceWriter.Trace(TraceLevel.Verbose, JsonPosition.FormatMessage(null, writer.Path, StringUtils.FormatWith("Writing object reference Id '{0}' for {1}.", CultureInfo.InvariantCulture, reference, type)), null);
			}
			writer.WritePropertyName("$id", false);
			writer.WriteValue(reference);
		}

		// Token: 0x06000C06 RID: 3078
		// RVA: 0x00047684 File Offset: 0x00045884
		private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			bool flag = this.ResolveIsReference(contract, member, containerContract, containerProperty) ?? this.HasFlag(this.Serializer._preserveReferencesHandling, PreserveReferencesHandling.Arrays);
			bool flag2 = this.ShouldWriteType(TypeNameHandling.Arrays, contract, member, containerContract, containerProperty);
			bool result;
			if (result = (flag || flag2))
			{
				writer.WriteStartObject();
				if (flag)
				{
					this.WriteReferenceIdProperty(writer, contract.UnderlyingType, values);
				}
				if (flag2)
				{
					this.WriteTypeProperty(writer, values.GetType());
				}
				writer.WritePropertyName("$values", false);
			}
			if (contract.ItemContract == null)
			{
				contract.ItemContract = this.Serializer._contractResolver.ResolveContract(contract.CollectionItemType ?? typeof(object));
			}
			return result;
		}

		// Token: 0x06000BFE RID: 3070
		// RVA: 0x00047218 File Offset: 0x00045418
		private void WriteTypeProperty(JsonWriter writer, Type type)
		{
			string typeName = ReflectionUtils.GetTypeName(type, this.Serializer._typeNameAssemblyFormat, this.Serializer._binder);
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= TraceLevel.Verbose)
			{
				this.TraceWriter.Trace(TraceLevel.Verbose, JsonPosition.FormatMessage(null, writer.Path, StringUtils.FormatWith("Writing type name '{0}' for {1}.", CultureInfo.InvariantCulture, typeName, type)), null);
			}
			writer.WritePropertyName("$type", false);
			writer.WriteValue(typeName);
		}
	}
}
