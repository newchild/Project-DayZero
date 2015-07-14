using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000033 RID: 51
	public sealed class KeyValuePairConverter : JsonConverter
	{
		// Token: 0x040000CA RID: 202
		private const string KeyName = "Key";

		// Token: 0x040000CC RID: 204
		private static readonly ThreadSafeStore<Type, ReflectionObject> ReflectionObjectPerType = new ThreadSafeStore<Type, ReflectionObject>(new Func<Type, ReflectionObject>(KeyValuePairConverter.InitializeReflectionObject));

		// Token: 0x040000CB RID: 203
		private const string ValueName = "Value";

		// Token: 0x060001A0 RID: 416
		// RVA: 0x0002BDD4 File Offset: 0x00029FD4
		public override bool CanConvert(Type objectType)
		{
			Type type = ReflectionUtils.IsNullableType(objectType) ? Nullable.GetUnderlyingType(objectType) : objectType;
			return TypeExtensions.IsValueType(type) && TypeExtensions.IsGenericType(type) && type.GetGenericTypeDefinition() == typeof(KeyValuePair<, >);
		}

		// Token: 0x0600019D RID: 413
		// RVA: 0x0002BBE0 File Offset: 0x00029DE0
		private static ReflectionObject InitializeReflectionObject(Type t)
		{
			IList<Type> genericArguments = t.GetGenericArguments();
			Type type = genericArguments[0];
			Type type2 = genericArguments[1];
			return ReflectionObject.Create(t, t.GetConstructor(new Type[]
			{
				type,
				type2
			}), new string[]
			{
				"Key",
				"Value"
			});
		}

		// Token: 0x060001A1 RID: 417
		// RVA: 0x00006DFA File Offset: 0x00004FFA
		private static void ReadAndAssert(JsonReader reader)
		{
			if (!reader.Read())
			{
				throw JsonSerializationException.Create(reader, "Unexpected end when reading KeyValuePair.");
			}
		}

		// Token: 0x0600019F RID: 415
		// RVA: 0x0002BCE4 File Offset: 0x00029EE4
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			bool flag;
			Type key = (flag = ReflectionUtils.IsNullableType(objectType)) ? Nullable.GetUnderlyingType(objectType) : objectType;
			ReflectionObject reflectionObject = KeyValuePairConverter.ReflectionObjectPerType.Get(key);
			if (reader.TokenType != JsonToken.Null)
			{
				object obj = null;
				object obj2 = null;
				KeyValuePairConverter.ReadAndAssert(reader);
				while (reader.TokenType == JsonToken.PropertyName)
				{
					string a = reader.Value.ToString();
					if (string.Equals(a, "Key", StringComparison.OrdinalIgnoreCase))
					{
						KeyValuePairConverter.ReadAndAssert(reader);
						obj = serializer.Deserialize(reader, reflectionObject.GetType("Key"));
					}
					else if (string.Equals(a, "Value", StringComparison.OrdinalIgnoreCase))
					{
						KeyValuePairConverter.ReadAndAssert(reader);
						obj2 = serializer.Deserialize(reader, reflectionObject.GetType("Value"));
					}
					else
					{
						reader.Skip();
					}
					KeyValuePairConverter.ReadAndAssert(reader);
				}
				return reflectionObject.Creator(new object[]
				{
					obj,
					obj2
				});
			}
			if (!flag)
			{
				throw JsonSerializationException.Create(reader, "Cannot convert null value to KeyValuePair.");
			}
			return null;
		}

		// Token: 0x0600019E RID: 414
		// RVA: 0x0002BC3C File Offset: 0x00029E3C
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			ReflectionObject reflectionObject = KeyValuePairConverter.ReflectionObjectPerType.Get(value.GetType());
			DefaultContractResolver defaultContractResolver = serializer.ContractResolver as DefaultContractResolver;
			writer.WriteStartObject();
			writer.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName("Key") : "Key");
			serializer.Serialize(writer, reflectionObject.GetValue(value, "Key"), reflectionObject.GetType("Key"));
			writer.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName("Value") : "Value");
			serializer.Serialize(writer, reflectionObject.GetValue(value, "Value"), reflectionObject.GetType("Value"));
			writer.WriteEndObject();
		}
	}
}
