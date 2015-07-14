using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;
using Newtonsoft.Json.Utilities.LinqBridge;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000F8 RID: 248
	public class DefaultContractResolver : IContractResolver
	{
		// Token: 0x020000F9 RID: 249
		internal struct DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue> : IDisposable, IEnumerable, IEnumerator, IEnumerator<KeyValuePair<object, object>>, IEnumerable<KeyValuePair<object, object>>
		{
			// Token: 0x0400042F RID: 1071
			private readonly IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;

			// Token: 0x170001C6 RID: 454
			public KeyValuePair<object, object> Current
			{
				// Token: 0x06000A55 RID: 2645
				// RVA: 0x00040FC8 File Offset: 0x0003F1C8
				get
				{
					KeyValuePair<TEnumeratorKey, TEnumeratorValue> current = this._e.Current;
					object arg_30_0 = current.Key;
					KeyValuePair<TEnumeratorKey, TEnumeratorValue> current2 = this._e.Current;
					return new KeyValuePair<object, object>(arg_30_0, current2.Value);
				}
			}

			// Token: 0x170001C7 RID: 455
			object IEnumerator.Current
			{
				// Token: 0x06000A57 RID: 2647
				// RVA: 0x0000C282 File Offset: 0x0000A482
				get
				{
					return this.Current;
				}
			}

			// Token: 0x06000A52 RID: 2642
			// RVA: 0x0000C242 File Offset: 0x0000A442
			public DictionaryEnumerator(IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e)
			{
				ValidationUtils.ArgumentNotNull(e, "e");
				this._e = e.GetEnumerator();
			}

			// Token: 0x06000A56 RID: 2646
			// RVA: 0x0000C275 File Offset: 0x0000A475
			public void Dispose()
			{
				this._e.Dispose();
			}

			// Token: 0x06000A58 RID: 2648
			// RVA: 0x0000C28F File Offset: 0x0000A48F
			public IEnumerator<KeyValuePair<object, object>> GetEnumerator()
			{
				return this;
			}

			// Token: 0x06000A53 RID: 2643
			// RVA: 0x0000C25B File Offset: 0x0000A45B
			public bool MoveNext()
			{
				return this._e.MoveNext();
			}

			// Token: 0x06000A54 RID: 2644
			// RVA: 0x0000C268 File Offset: 0x0000A468
			public void Reset()
			{
				this._e.Reset();
			}

			// Token: 0x06000A59 RID: 2649
			// RVA: 0x0000C28F File Offset: 0x0000A48F
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this;
			}
		}

		// Token: 0x04000420 RID: 1056
		private static readonly JsonConverter[] BuiltInConverters = new JsonConverter[]
		{
			new XmlNodeConverter(),
			new BinaryConverter(),
			new DataSetConverter(),
			new DataTableConverter(),
			new KeyValuePairConverter(),
			new BsonObjectIdConverter(),
			new RegexConverter()
		};

		// Token: 0x04000421 RID: 1057
		private static readonly object TypeContractCacheLock = new object();

		// Token: 0x0400041F RID: 1055
		private static readonly IContractResolver _instance = new DefaultContractResolver(true);

		// Token: 0x04000423 RID: 1059
		private readonly DefaultContractResolverState _instanceState = new DefaultContractResolverState();

		// Token: 0x04000424 RID: 1060
		private readonly bool _sharedCache;

		// Token: 0x04000422 RID: 1058
		private static readonly DefaultContractResolverState _sharedState = new DefaultContractResolverState();

		// Token: 0x170001C2 RID: 450
		[Obsolete("DefaultMembersSearchFlags is obsolete. To modify the members serialized inherit from DefaultContractResolver and override the GetSerializableMembers method instead.")]
		public BindingFlags DefaultMembersSearchFlags
		{
			// Token: 0x06000A1D RID: 2589
			// RVA: 0x0000C17A File Offset: 0x0000A37A
			get;
			// Token: 0x06000A1E RID: 2590
			// RVA: 0x0000C182 File Offset: 0x0000A382
			set;
		}

		// Token: 0x170001C1 RID: 449
		public bool DynamicCodeGeneration
		{
			// Token: 0x06000A1C RID: 2588
			// RVA: 0x0000C173 File Offset: 0x0000A373
			get
			{
				return JsonTypeReflector.DynamicCodeGeneration;
			}
		}

		// Token: 0x170001C5 RID: 453
		public bool IgnoreSerializableAttribute
		{
			// Token: 0x06000A23 RID: 2595
			// RVA: 0x0000C1AD File Offset: 0x0000A3AD
			get;
			// Token: 0x06000A24 RID: 2596
			// RVA: 0x0000C1B5 File Offset: 0x0000A3B5
			set;
		}

		// Token: 0x170001C4 RID: 452
		public bool IgnoreSerializableInterface
		{
			// Token: 0x06000A21 RID: 2593
			// RVA: 0x0000C19C File Offset: 0x0000A39C
			get;
			// Token: 0x06000A22 RID: 2594
			// RVA: 0x0000C1A4 File Offset: 0x0000A3A4
			set;
		}

		// Token: 0x170001C0 RID: 448
		internal static IContractResolver Instance
		{
			// Token: 0x06000A1B RID: 2587
			// RVA: 0x0000C16C File Offset: 0x0000A36C
			get
			{
				return DefaultContractResolver._instance;
			}
		}

		// Token: 0x170001C3 RID: 451
		public bool SerializeCompilerGeneratedMembers
		{
			// Token: 0x06000A1F RID: 2591
			// RVA: 0x0000C18B File Offset: 0x0000A38B
			get;
			// Token: 0x06000A20 RID: 2592
			// RVA: 0x0000C193 File Offset: 0x0000A393
			set;
		}

		// Token: 0x06000A25 RID: 2597
		// RVA: 0x0000C1BE File Offset: 0x0000A3BE
		public DefaultContractResolver() : this(false)
		{
		}

		// Token: 0x06000A26 RID: 2598
		// RVA: 0x0000C1C7 File Offset: 0x0000A3C7
		public DefaultContractResolver(bool shareCache)
		{
			this.DefaultMembersSearchFlags = (BindingFlags.Instance | BindingFlags.Public);
			this.IgnoreSerializableAttribute = true;
			this._sharedCache = shareCache;
		}

		// Token: 0x06000A40 RID: 2624
		// RVA: 0x00040728 File Offset: 0x0003E928
		internal static bool CanConvertToString(Type type)
		{
			TypeConverter converter = ConvertUtils.GetConverter(type);
			return (converter != null && !(converter is ComponentConverter) && !(converter is ReferenceConverter) && converter.GetType() != typeof(TypeConverter) && converter.CanConvertTo(typeof(string))) || type == typeof(Type) || type.IsSubclassOf(typeof(Type));
		}

		// Token: 0x06000A38 RID: 2616
		// RVA: 0x000404E8 File Offset: 0x0003E6E8
		protected virtual JsonArrayContract CreateArrayContract(Type objectType)
		{
			JsonArrayContract jsonArrayContract = new JsonArrayContract(objectType);
			this.InitializeContract(jsonArrayContract);
			return jsonArrayContract;
		}

		// Token: 0x06000A2F RID: 2607
		// RVA: 0x0003FEF4 File Offset: 0x0003E0F4
		protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties)
		{
			ParameterInfo[] parameters = constructor.GetParameters();
			JsonPropertyCollection jsonPropertyCollection = new JsonPropertyCollection(constructor.DeclaringType);
			ParameterInfo[] array = parameters;
			for (int i = 0; i < array.Length; i++)
			{
				ParameterInfo parameterInfo = array[i];
				JsonProperty jsonProperty = (parameterInfo.Name != null) ? memberProperties.GetClosestMatchProperty(parameterInfo.Name) : null;
				if (jsonProperty != null && jsonProperty.PropertyType != parameterInfo.ParameterType)
				{
					jsonProperty = null;
				}
				if (jsonProperty != null || parameterInfo.Name != null)
				{
					JsonProperty jsonProperty2 = this.CreatePropertyFromConstructorParameter(jsonProperty, parameterInfo);
					if (jsonProperty2 != null)
					{
						jsonPropertyCollection.AddProperty(jsonProperty2);
					}
				}
			}
			return jsonPropertyCollection;
		}

		// Token: 0x06000A3D RID: 2621
		// RVA: 0x000405BC File Offset: 0x0003E7BC
		protected virtual JsonContract CreateContract(Type objectType)
		{
			if (DefaultContractResolver.IsJsonPrimitiveType(objectType))
			{
				return this.CreatePrimitiveContract(objectType);
			}
			Type type = ReflectionUtils.EnsureNotNullableType(objectType);
			JsonContainerAttribute cachedAttribute = JsonTypeReflector.GetCachedAttribute<JsonContainerAttribute>(type);
			if (cachedAttribute is JsonObjectAttribute)
			{
				return this.CreateObjectContract(objectType);
			}
			if (cachedAttribute is JsonArrayAttribute)
			{
				return this.CreateArrayContract(objectType);
			}
			if (cachedAttribute is JsonDictionaryAttribute)
			{
				return this.CreateDictionaryContract(objectType);
			}
			if (type == typeof(JToken) || type.IsSubclassOf(typeof(JToken)))
			{
				return this.CreateLinqContract(objectType);
			}
			if (CollectionUtils.IsDictionaryType(type))
			{
				return this.CreateDictionaryContract(objectType);
			}
			if (typeof(IEnumerable).IsAssignableFrom(type))
			{
				return this.CreateArrayContract(objectType);
			}
			if (DefaultContractResolver.CanConvertToString(type))
			{
				return this.CreateStringContract(objectType);
			}
			if (!this.IgnoreSerializableInterface && typeof(ISerializable).IsAssignableFrom(type))
			{
				return this.CreateISerializableContract(objectType);
			}
			if (DefaultContractResolver.IsIConvertible(type))
			{
				return this.CreatePrimitiveContract(type);
			}
			return this.CreateObjectContract(objectType);
		}

		// Token: 0x06000A37 RID: 2615
		// RVA: 0x000404B8 File Offset: 0x0003E6B8
		protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType)
		{
			JsonDictionaryContract jsonDictionaryContract = new JsonDictionaryContract(objectType);
			this.InitializeContract(jsonDictionaryContract);
			jsonDictionaryContract.PropertyNameResolver = new Func<string, string>(this.ResolvePropertyName);
			return jsonDictionaryContract;
		}

		// Token: 0x06000A3B RID: 2619
		// RVA: 0x0004053C File Offset: 0x0003E73C
		protected virtual JsonISerializableContract CreateISerializableContract(Type objectType)
		{
			JsonISerializableContract jsonISerializableContract = new JsonISerializableContract(objectType);
			this.InitializeContract(jsonISerializableContract);
			ConstructorInfo constructor = jsonISerializableContract.NonNullableUnderlyingType.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			}, null);
			if (constructor != null)
			{
				ObjectConstructor<object> iSerializableCreator = JsonTypeReflector.ReflectionDelegateFactory.CreateParametrizedConstructor(constructor);
				jsonISerializableContract.ISerializableCreator = iSerializableCreator;
			}
			return jsonISerializableContract;
		}

		// Token: 0x06000A3A RID: 2618
		// RVA: 0x00040520 File Offset: 0x0003E720
		protected virtual JsonLinqContract CreateLinqContract(Type objectType)
		{
			JsonLinqContract jsonLinqContract = new JsonLinqContract(objectType);
			this.InitializeContract(jsonLinqContract);
			return jsonLinqContract;
		}

		// Token: 0x06000A44 RID: 2628
		// RVA: 0x00040A5C File Offset: 0x0003EC5C
		protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member)
		{
			IValueProvider result;
			if (this.DynamicCodeGeneration)
			{
				result = new DynamicValueProvider(member);
			}
			else
			{
				result = new ReflectionValueProvider(member);
			}
			return result;
		}

		// Token: 0x06000A2A RID: 2602
		// RVA: 0x0003FAF4 File Offset: 0x0003DCF4
		protected virtual JsonObjectContract CreateObjectContract(Type objectType)
		{
			JsonObjectContract jsonObjectContract = new JsonObjectContract(objectType);
			this.InitializeContract(jsonObjectContract);
			bool ignoreSerializableAttribute = this.IgnoreSerializableAttribute;
			jsonObjectContract.MemberSerialization = JsonTypeReflector.GetObjectMemberSerialization(jsonObjectContract.NonNullableUnderlyingType, ignoreSerializableAttribute);
			CollectionUtils.AddRange<JsonProperty>(jsonObjectContract.Properties, this.CreateProperties(jsonObjectContract.NonNullableUnderlyingType, jsonObjectContract.MemberSerialization));
			JsonObjectAttribute cachedAttribute = JsonTypeReflector.GetCachedAttribute<JsonObjectAttribute>(jsonObjectContract.NonNullableUnderlyingType);
			if (cachedAttribute != null)
			{
				jsonObjectContract.ItemRequired = cachedAttribute._itemRequired;
			}
			if (jsonObjectContract.IsInstantiable)
			{
				ConstructorInfo attributeConstructor = this.GetAttributeConstructor(jsonObjectContract.NonNullableUnderlyingType);
				if (attributeConstructor != null)
				{
					jsonObjectContract.OverrideConstructor = attributeConstructor;
					CollectionUtils.AddRange<JsonProperty>(jsonObjectContract.CreatorParameters, this.CreateConstructorParameters(attributeConstructor, jsonObjectContract.Properties));
				}
				else if (jsonObjectContract.MemberSerialization == MemberSerialization.Fields)
				{
					if (JsonTypeReflector.FullyTrusted)
					{
						jsonObjectContract.DefaultCreator = new Func<object>(jsonObjectContract.GetUninitializedObject);
					}
				}
				else if (jsonObjectContract.DefaultCreator == null || jsonObjectContract.DefaultCreatorNonPublic)
				{
					ConstructorInfo parametrizedConstructor = this.GetParametrizedConstructor(jsonObjectContract.NonNullableUnderlyingType);
					if (parametrizedConstructor != null)
					{
						jsonObjectContract.ParametrizedConstructor = parametrizedConstructor;
						CollectionUtils.AddRange<JsonProperty>(jsonObjectContract.CreatorParameters, this.CreateConstructorParameters(parametrizedConstructor, jsonObjectContract.Properties));
					}
				}
			}
			MemberInfo extensionDataMemberForType = this.GetExtensionDataMemberForType(jsonObjectContract.NonNullableUnderlyingType);
			if (extensionDataMemberForType != null)
			{
				DefaultContractResolver.SetExtensionDataDelegates(jsonObjectContract, extensionDataMemberForType);
			}
			return jsonObjectContract;
		}

		// Token: 0x06000A39 RID: 2617
		// RVA: 0x00040504 File Offset: 0x0003E704
		protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType)
		{
			JsonPrimitiveContract jsonPrimitiveContract = new JsonPrimitiveContract(objectType);
			this.InitializeContract(jsonPrimitiveContract);
			return jsonPrimitiveContract;
		}

		// Token: 0x06000A43 RID: 2627
		// RVA: 0x00040970 File Offset: 0x0003EB70
		protected virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			List<MemberInfo> serializableMembers = this.GetSerializableMembers(type);
			if (serializableMembers == null)
			{
				throw new JsonSerializationException("Null collection of seralizable members returned.");
			}
			JsonPropertyCollection jsonPropertyCollection = new JsonPropertyCollection(type);
			foreach (MemberInfo current in serializableMembers)
			{
				JsonProperty jsonProperty = this.CreateProperty(current, memberSerialization);
				if (jsonProperty != null)
				{
					DefaultContractResolverState state = this.GetState();
					lock (state.NameTable)
					{
						jsonProperty.PropertyName = state.NameTable.Add(jsonProperty.PropertyName);
					}
					jsonPropertyCollection.AddProperty(jsonProperty);
				}
			}
			return Enumerable.ToList<JsonProperty>(Enumerable.OrderBy<JsonProperty, int>(jsonPropertyCollection, delegate(JsonProperty p)
			{
				int? order = p.Order;
				if (!order.HasValue)
				{
					return -1;
				}
				return order.GetValueOrDefault();
			}));
		}

		// Token: 0x06000A45 RID: 2629
		// RVA: 0x00040A84 File Offset: 0x0003EC84
		protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
		{
			JsonProperty jsonProperty = new JsonProperty();
			jsonProperty.PropertyType = ReflectionUtils.GetMemberUnderlyingType(member);
			jsonProperty.DeclaringType = member.DeclaringType;
			jsonProperty.ValueProvider = this.CreateMemberValueProvider(member);
			jsonProperty.AttributeProvider = new ReflectionAttributeProvider(member);
			bool flag;
			this.SetPropertySettingsFromAttributes(jsonProperty, member, member.Name, member.DeclaringType, memberSerialization, out flag);
			if (memberSerialization != MemberSerialization.Fields)
			{
				jsonProperty.Readable = ReflectionUtils.CanReadMemberValue(member, flag);
				jsonProperty.Writable = ReflectionUtils.CanSetMemberValue(member, flag, jsonProperty.HasMemberAttribute);
			}
			else
			{
				jsonProperty.Readable = true;
				jsonProperty.Writable = true;
			}
			jsonProperty.ShouldSerialize = this.CreateShouldSerializeTest(member);
			this.SetIsSpecifiedActions(jsonProperty, member, flag);
			return jsonProperty;
		}

		// Token: 0x06000A30 RID: 2608
		// RVA: 0x0003FF80 File Offset: 0x0003E180
		protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo)
		{
			JsonProperty jsonProperty = new JsonProperty();
			jsonProperty.PropertyType = parameterInfo.ParameterType;
			jsonProperty.AttributeProvider = new ReflectionAttributeProvider(parameterInfo);
			bool flag;
			this.SetPropertySettingsFromAttributes(jsonProperty, parameterInfo, parameterInfo.Name, parameterInfo.Member.DeclaringType, MemberSerialization.OptOut, out flag);
			jsonProperty.Readable = false;
			jsonProperty.Writable = true;
			if (matchingMemberProperty != null)
			{
				jsonProperty.PropertyName = ((jsonProperty.PropertyName != parameterInfo.Name) ? jsonProperty.PropertyName : matchingMemberProperty.PropertyName);
				jsonProperty.Converter = (jsonProperty.Converter ?? matchingMemberProperty.Converter);
				jsonProperty.MemberConverter = (jsonProperty.MemberConverter ?? matchingMemberProperty.MemberConverter);
				if (!jsonProperty._hasExplicitDefaultValue && matchingMemberProperty._hasExplicitDefaultValue)
				{
					jsonProperty.DefaultValue = matchingMemberProperty.DefaultValue;
				}
				JsonProperty arg_E2_0 = jsonProperty;
				Required? required = jsonProperty._required;
				arg_E2_0._required = (required.HasValue ? new Required?(required.GetValueOrDefault()) : matchingMemberProperty._required);
				JsonProperty arg_10C_0 = jsonProperty;
				bool? isReference = jsonProperty.IsReference;
				arg_10C_0.IsReference = (isReference.HasValue ? new bool?(isReference.GetValueOrDefault()) : matchingMemberProperty.IsReference);
				JsonProperty arg_137_0 = jsonProperty;
				NullValueHandling? nullValueHandling = jsonProperty.NullValueHandling;
				arg_137_0.NullValueHandling = (nullValueHandling.HasValue ? new NullValueHandling?(nullValueHandling.GetValueOrDefault()) : matchingMemberProperty.NullValueHandling);
				JsonProperty arg_162_0 = jsonProperty;
				DefaultValueHandling? defaultValueHandling = jsonProperty.DefaultValueHandling;
				arg_162_0.DefaultValueHandling = (defaultValueHandling.HasValue ? new DefaultValueHandling?(defaultValueHandling.GetValueOrDefault()) : matchingMemberProperty.DefaultValueHandling);
				JsonProperty arg_18D_0 = jsonProperty;
				ReferenceLoopHandling? referenceLoopHandling = jsonProperty.ReferenceLoopHandling;
				arg_18D_0.ReferenceLoopHandling = (referenceLoopHandling.HasValue ? new ReferenceLoopHandling?(referenceLoopHandling.GetValueOrDefault()) : matchingMemberProperty.ReferenceLoopHandling);
				JsonProperty arg_1B8_0 = jsonProperty;
				ObjectCreationHandling? objectCreationHandling = jsonProperty.ObjectCreationHandling;
				arg_1B8_0.ObjectCreationHandling = (objectCreationHandling.HasValue ? new ObjectCreationHandling?(objectCreationHandling.GetValueOrDefault()) : matchingMemberProperty.ObjectCreationHandling);
				JsonProperty arg_1E3_0 = jsonProperty;
				TypeNameHandling? typeNameHandling = jsonProperty.TypeNameHandling;
				arg_1E3_0.TypeNameHandling = (typeNameHandling.HasValue ? new TypeNameHandling?(typeNameHandling.GetValueOrDefault()) : matchingMemberProperty.TypeNameHandling);
			}
			return jsonProperty;
		}

		// Token: 0x06000A47 RID: 2631
		// RVA: 0x00040D3C File Offset: 0x0003EF3C
		private Predicate<object> CreateShouldSerializeTest(MemberInfo member)
		{
			MethodInfo method = member.DeclaringType.GetMethod("ShouldSerialize" + member.Name, ReflectionUtils.EmptyTypes);
			if (method != null)
			{
				if (method.ReturnType == typeof(bool))
				{
					MethodCall<object, object> shouldSerializeCall = JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(method);
					return (object o) => (bool)shouldSerializeCall(o, new object[0]);
				}
			}
			return null;
		}

		// Token: 0x06000A3C RID: 2620
		// RVA: 0x000405A0 File Offset: 0x0003E7A0
		protected virtual JsonStringContract CreateStringContract(Type objectType)
		{
			JsonStringContract jsonStringContract = new JsonStringContract(objectType);
			this.InitializeContract(jsonStringContract);
			return jsonStringContract;
		}

		// Token: 0x06000A2D RID: 2605
		// RVA: 0x0003FE10 File Offset: 0x0003E010
		private ConstructorInfo GetAttributeConstructor(Type objectType)
		{
			IList<ConstructorInfo> list = Enumerable.ToList<ConstructorInfo>(Enumerable.Where<ConstructorInfo>(objectType.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), (ConstructorInfo c) => c.IsDefined(typeof(JsonConstructorAttribute), true)));
			if (list.Count > 1)
			{
				throw new JsonException("Multiple constructors with the JsonConstructorAttribute.");
			}
			if (list.Count == 1)
			{
				return list[0];
			}
			if (objectType == typeof(Version))
			{
				return objectType.GetConstructor(new Type[]
				{
					typeof(int),
					typeof(int),
					typeof(int),
					typeof(int)
				});
			}
			return null;
		}

		// Token: 0x06000A35 RID: 2613
		// RVA: 0x0004029C File Offset: 0x0003E49C
		private void GetCallbackMethodsForType(Type type, out List<SerializationCallback> onSerializing, out List<SerializationCallback> onSerialized, out List<SerializationCallback> onDeserializing, out List<SerializationCallback> onDeserialized, out List<SerializationErrorCallback> onError)
		{
			onSerializing = null;
			onSerialized = null;
			onDeserializing = null;
			onDeserialized = null;
			onError = null;
			foreach (Type current in this.GetClassHierarchyForType(type))
			{
				MethodInfo currentCallback = null;
				MethodInfo currentCallback2 = null;
				MethodInfo currentCallback3 = null;
				MethodInfo currentCallback4 = null;
				MethodInfo currentCallback5 = null;
				MethodInfo[] methods = current.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				for (int i = 0; i < methods.Length; i++)
				{
					MethodInfo methodInfo = methods[i];
					if (!methodInfo.ContainsGenericParameters)
					{
						Type type2 = null;
						ParameterInfo[] parameters = methodInfo.GetParameters();
						if (DefaultContractResolver.IsValidCallback(methodInfo, parameters, typeof(OnSerializingAttribute), currentCallback, ref type2))
						{
							onSerializing = (onSerializing ?? new List<SerializationCallback>());
							onSerializing.Add(JsonContract.CreateSerializationCallback(methodInfo));
							currentCallback = methodInfo;
						}
						if (DefaultContractResolver.IsValidCallback(methodInfo, parameters, typeof(OnSerializedAttribute), currentCallback2, ref type2))
						{
							onSerialized = (onSerialized ?? new List<SerializationCallback>());
							onSerialized.Add(JsonContract.CreateSerializationCallback(methodInfo));
							currentCallback2 = methodInfo;
						}
						if (DefaultContractResolver.IsValidCallback(methodInfo, parameters, typeof(OnDeserializingAttribute), currentCallback3, ref type2))
						{
							onDeserializing = (onDeserializing ?? new List<SerializationCallback>());
							onDeserializing.Add(JsonContract.CreateSerializationCallback(methodInfo));
							currentCallback3 = methodInfo;
						}
						if (DefaultContractResolver.IsValidCallback(methodInfo, parameters, typeof(OnDeserializedAttribute), currentCallback4, ref type2))
						{
							onDeserialized = (onDeserialized ?? new List<SerializationCallback>());
							onDeserialized.Add(JsonContract.CreateSerializationCallback(methodInfo));
							currentCallback4 = methodInfo;
						}
						if (DefaultContractResolver.IsValidCallback(methodInfo, parameters, typeof(OnErrorAttribute), currentCallback5, ref type2))
						{
							onError = (onError ?? new List<SerializationErrorCallback>());
							onError.Add(JsonContract.CreateSerializationErrorCallback(methodInfo));
							currentCallback5 = methodInfo;
						}
					}
				}
			}
		}

		// Token: 0x06000A36 RID: 2614
		// RVA: 0x00040478 File Offset: 0x0003E678
		private List<Type> GetClassHierarchyForType(Type type)
		{
			List<Type> list = new List<Type>();
			for (Type type2 = type; type2 != null; type2 = TypeExtensions.BaseType(type2))
			{
				if (type2 == typeof(object))
				{
					break;
				}
				list.Add(type2);
			}
			list.Reverse();
			return list;
		}

		// Token: 0x06000A42 RID: 2626
		// RVA: 0x00040920 File Offset: 0x0003EB20
		internal static string GetClrTypeFullName(Type type)
		{
			if (!TypeExtensions.IsGenericTypeDefinition(type) && TypeExtensions.ContainsGenericParameters(type))
			{
				return string.Format(CultureInfo.InvariantCulture, "{0}.{1}", new object[]
				{
					type.Namespace,
					type.Name
				});
			}
			return type.FullName;
		}

		// Token: 0x06000A32 RID: 2610
		// RVA: 0x0000C20E File Offset: 0x0000A40E
		private Func<object> GetDefaultCreator(Type createdType)
		{
			return JsonTypeReflector.ReflectionDelegateFactory.CreateDefaultConstructor<object>(createdType);
		}

		// Token: 0x06000A2B RID: 2603
		// RVA: 0x0003FC20 File Offset: 0x0003DE20
		private MemberInfo GetExtensionDataMemberForType(Type type)
		{
			IEnumerable<MemberInfo> source = Enumerable.SelectMany<Type, MemberInfo>(this.GetClassHierarchyForType(type), delegate(Type baseType)
			{
				IList<MemberInfo> list = new List<MemberInfo>();
				CollectionUtils.AddRange<MemberInfo>(list, baseType.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
				CollectionUtils.AddRange<MemberInfo>(list, baseType.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
				return list;
			});
			return Enumerable.LastOrDefault<MemberInfo>(source, delegate(MemberInfo m)
			{
				MemberTypes memberTypes = TypeExtensions.MemberType(m);
				if (memberTypes != MemberTypes.Property && memberTypes != MemberTypes.Field)
				{
					return false;
				}
				if (!m.IsDefined(typeof(JsonExtensionDataAttribute), false))
				{
					return false;
				}
				Type memberUnderlyingType = ReflectionUtils.GetMemberUnderlyingType(m);
				Type type2;
				if (ReflectionUtils.ImplementsGenericDefinition(memberUnderlyingType, typeof(IDictionary<, >), out type2))
				{
					Type type3 = type2.GetGenericArguments()[0];
					Type type4 = type2.GetGenericArguments()[1];
					if (type3.IsAssignableFrom(typeof(string)) && type4.IsAssignableFrom(typeof(JToken)))
					{
						return true;
					}
				}
				throw new JsonException(StringUtils.FormatWith("Invalid extension data attribute on '{0}'. Member '{1}' type must implement IDictionary<string, JToken>.", CultureInfo.InvariantCulture, DefaultContractResolver.GetClrTypeFullName(m.DeclaringType), m.Name));
			});
		}

		// Token: 0x06000A2E RID: 2606
		// RVA: 0x0003FEC4 File Offset: 0x0003E0C4
		private ConstructorInfo GetParametrizedConstructor(Type objectType)
		{
			IList<ConstructorInfo> list = Enumerable.ToList<ConstructorInfo>(objectType.GetConstructors(BindingFlags.Instance | BindingFlags.Public));
			if (list.Count == 1)
			{
				return list[0];
			}
			return null;
		}

		// Token: 0x06000A4A RID: 2634
		// RVA: 0x0000C21B File Offset: 0x0000A41B
		public string GetResolvedPropertyName(string propertyName)
		{
			return this.ResolvePropertyName(propertyName);
		}

		// Token: 0x06000A29 RID: 2601
		// RVA: 0x0003F974 File Offset: 0x0003DB74
		protected virtual List<MemberInfo> GetSerializableMembers(Type objectType)
		{
			bool ignoreSerializableAttribute = this.IgnoreSerializableAttribute;
			MemberSerialization objectMemberSerialization = JsonTypeReflector.GetObjectMemberSerialization(objectType, ignoreSerializableAttribute);
			List<MemberInfo> list = Enumerable.ToList<MemberInfo>(Enumerable.Where<MemberInfo>(ReflectionUtils.GetFieldsAndProperties(objectType, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic), (MemberInfo m) => !ReflectionUtils.IsIndexedProperty(m)));
			List<MemberInfo> list2 = new List<MemberInfo>();
			if (objectMemberSerialization != MemberSerialization.Fields)
			{
				List<MemberInfo> list3 = Enumerable.ToList<MemberInfo>(Enumerable.Where<MemberInfo>(ReflectionUtils.GetFieldsAndProperties(objectType, this.DefaultMembersSearchFlags), (MemberInfo m) => !ReflectionUtils.IsIndexedProperty(m)));
				using (List<MemberInfo>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						MemberInfo current = enumerator.Current;
						if (this.SerializeCompilerGeneratedMembers || !current.IsDefined(typeof(CompilerGeneratedAttribute), true))
						{
							if (list3.Contains(current))
							{
								list2.Add(current);
							}
							else if (JsonTypeReflector.GetAttribute<JsonPropertyAttribute>(current) != null)
							{
								list2.Add(current);
							}
							else if (objectMemberSerialization == MemberSerialization.Fields && TypeExtensions.MemberType(current) == MemberTypes.Field)
							{
								list2.Add(current);
							}
						}
					}
					return list2;
				}
			}
			foreach (MemberInfo current2 in list)
			{
				FieldInfo fieldInfo = current2 as FieldInfo;
				if (fieldInfo != null && !fieldInfo.IsStatic)
				{
					list2.Add(current2);
				}
			}
			return list2;
		}

		// Token: 0x06000A27 RID: 2599
		// RVA: 0x0000C1F0 File Offset: 0x0000A3F0
		internal DefaultContractResolverState GetState()
		{
			if (this._sharedCache)
			{
				return DefaultContractResolver._sharedState;
			}
			return this._instanceState;
		}

		// Token: 0x06000A33 RID: 2611
		// RVA: 0x00040178 File Offset: 0x0003E378
		private void InitializeContract(JsonContract contract)
		{
			JsonContainerAttribute cachedAttribute = JsonTypeReflector.GetCachedAttribute<JsonContainerAttribute>(contract.NonNullableUnderlyingType);
			if (cachedAttribute != null)
			{
				contract.IsReference = cachedAttribute._isReference;
			}
			contract.Converter = this.ResolveContractConverter(contract.NonNullableUnderlyingType);
			contract.InternalConverter = JsonSerializer.GetMatchingConverter(DefaultContractResolver.BuiltInConverters, contract.NonNullableUnderlyingType);
			if (contract.IsInstantiable && (ReflectionUtils.HasDefaultConstructor(contract.CreatedType, true) || TypeExtensions.IsValueType(contract.CreatedType)))
			{
				contract.DefaultCreator = this.GetDefaultCreator(contract.CreatedType);
				contract.DefaultCreatorNonPublic = (!TypeExtensions.IsValueType(contract.CreatedType) && ReflectionUtils.GetDefaultConstructor(contract.CreatedType) == null);
			}
			this.ResolveCallbackMethods(contract, contract.NonNullableUnderlyingType);
		}

		// Token: 0x06000A3F RID: 2623
		// RVA: 0x000406D4 File Offset: 0x0003E8D4
		internal static bool IsIConvertible(Type t)
		{
			return (typeof(IConvertible).IsAssignableFrom(t) || (ReflectionUtils.IsNullableType(t) && typeof(IConvertible).IsAssignableFrom(Nullable.GetUnderlyingType(t)))) && !typeof(JToken).IsAssignableFrom(t);
		}

		// Token: 0x06000A3E RID: 2622
		// RVA: 0x000406B4 File Offset: 0x0003E8B4
		internal static bool IsJsonPrimitiveType(Type t)
		{
			PrimitiveTypeCode typeCode = ConvertUtils.GetTypeCode(t);
			return typeCode != PrimitiveTypeCode.Empty && typeCode != PrimitiveTypeCode.Object;
		}

		// Token: 0x06000A41 RID: 2625
		// RVA: 0x00040798 File Offset: 0x0003E998
		private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, ref Type prevAttributeType)
		{
			if (!method.IsDefined(attributeType, false))
			{
				return false;
			}
			if (currentCallback != null)
			{
				throw new JsonException(StringUtils.FormatWith("Invalid attribute. Both '{0}' and '{1}' in type '{2}' have '{3}'.", CultureInfo.InvariantCulture, method, currentCallback, DefaultContractResolver.GetClrTypeFullName(method.DeclaringType), attributeType));
			}
			if (prevAttributeType != null)
			{
				throw new JsonException(StringUtils.FormatWith("Invalid Callback. Method '{3}' in type '{2}' has both '{0}' and '{1}'.", CultureInfo.InvariantCulture, prevAttributeType, attributeType, DefaultContractResolver.GetClrTypeFullName(method.DeclaringType), method));
			}
			if (method.IsVirtual)
			{
				throw new JsonException(StringUtils.FormatWith("Virtual Method '{0}' of type '{1}' cannot be marked with '{2}' attribute.", CultureInfo.InvariantCulture, method, DefaultContractResolver.GetClrTypeFullName(method.DeclaringType), attributeType));
			}
			if (method.ReturnType != typeof(void))
			{
				throw new JsonException(StringUtils.FormatWith("Serialization Callback '{1}' in type '{0}' must return void.", CultureInfo.InvariantCulture, DefaultContractResolver.GetClrTypeFullName(method.DeclaringType), method));
			}
			if (attributeType == typeof(OnErrorAttribute))
			{
				if (parameters == null || parameters.Length != 2 || parameters[0].ParameterType != typeof(StreamingContext) || parameters[1].ParameterType != typeof(ErrorContext))
				{
					throw new JsonException(StringUtils.FormatWith("Serialization Error Callback '{1}' in type '{0}' must have two parameters of type '{2}' and '{3}'.", CultureInfo.InvariantCulture, DefaultContractResolver.GetClrTypeFullName(method.DeclaringType), method, typeof(StreamingContext), typeof(ErrorContext)));
				}
			}
			else if (parameters == null || parameters.Length != 1 || parameters[0].ParameterType != typeof(StreamingContext))
			{
				throw new JsonException(StringUtils.FormatWith("Serialization Callback '{1}' in type '{0}' must have a single parameter of type '{2}'.", CultureInfo.InvariantCulture, DefaultContractResolver.GetClrTypeFullName(method.DeclaringType), method, typeof(StreamingContext)));
			}
			prevAttributeType = attributeType;
			return true;
		}

		// Token: 0x06000A34 RID: 2612
		// RVA: 0x00040230 File Offset: 0x0003E430
		private void ResolveCallbackMethods(JsonContract contract, Type t)
		{
			List<SerializationCallback> list;
			List<SerializationCallback> list2;
			List<SerializationCallback> list3;
			List<SerializationCallback> list4;
			List<SerializationErrorCallback> list5;
			this.GetCallbackMethodsForType(t, out list, out list2, out list3, out list4, out list5);
			if (list != null)
			{
				CollectionUtils.AddRange<SerializationCallback>(contract.OnSerializingCallbacks, list);
			}
			if (list2 != null)
			{
				CollectionUtils.AddRange<SerializationCallback>(contract.OnSerializedCallbacks, list2);
			}
			if (list3 != null)
			{
				CollectionUtils.AddRange<SerializationCallback>(contract.OnDeserializingCallbacks, list3);
			}
			if (list4 != null)
			{
				CollectionUtils.AddRange<SerializationCallback>(contract.OnDeserializedCallbacks, list4);
			}
			if (list5 != null)
			{
				CollectionUtils.AddRange<SerializationErrorCallback>(contract.OnErrorCallbacks, list5);
			}
		}

		// Token: 0x06000A28 RID: 2600
		// RVA: 0x0003F8D4 File Offset: 0x0003DAD4
		public virtual JsonContract ResolveContract(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			DefaultContractResolverState state = this.GetState();
			ResolverContractKey key = new ResolverContractKey(base.GetType(), type);
			Dictionary<ResolverContractKey, JsonContract> contractCache = state.ContractCache;
			JsonContract jsonContract;
			if (contractCache == null || !contractCache.TryGetValue(key, out jsonContract))
			{
				jsonContract = this.CreateContract(type);
				lock (DefaultContractResolver.TypeContractCacheLock)
				{
					contractCache = state.ContractCache;
					Dictionary<ResolverContractKey, JsonContract> dictionary = (contractCache != null) ? new Dictionary<ResolverContractKey, JsonContract>(contractCache) : new Dictionary<ResolverContractKey, JsonContract>();
					dictionary[key] = jsonContract;
					state.ContractCache = dictionary;
				}
			}
			return jsonContract;
		}

		// Token: 0x06000A31 RID: 2609
		// RVA: 0x0000C206 File Offset: 0x0000A406
		protected virtual JsonConverter ResolveContractConverter(Type objectType)
		{
			return JsonTypeReflector.GetJsonConverter(objectType);
		}

		// Token: 0x06000A49 RID: 2633
		// RVA: 0x000085AF File Offset: 0x000067AF
		protected internal virtual string ResolvePropertyName(string propertyName)
		{
			return propertyName;
		}

		// Token: 0x06000A2C RID: 2604
		// RVA: 0x0003FC7C File Offset: 0x0003DE7C
		private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member)
		{
			JsonExtensionDataAttribute attribute = ReflectionUtils.GetAttribute<JsonExtensionDataAttribute>(member);
			if (attribute == null)
			{
				return;
			}
			Type memberUnderlyingType = ReflectionUtils.GetMemberUnderlyingType(member);
			Type type;
			ReflectionUtils.ImplementsGenericDefinition(memberUnderlyingType, typeof(IDictionary<, >), out type);
			Type type2 = type.GetGenericArguments()[0];
			Type type3 = type.GetGenericArguments()[1];
			bool isJTokenValueType = typeof(JToken).IsAssignableFrom(type3);
			Type type4;
			if (ReflectionUtils.IsGenericDefinition(memberUnderlyingType, typeof(IDictionary<, >)))
			{
				type4 = typeof(Dictionary<, >).MakeGenericType(new Type[]
				{
					type2,
					type3
				});
			}
			else
			{
				type4 = memberUnderlyingType;
			}
			MethodInfo method = memberUnderlyingType.GetMethod("Add", new Type[]
			{
				type2,
				type3
			});
			Func<object, object> getExtensionDataDictionary = JsonTypeReflector.ReflectionDelegateFactory.CreateGet<object>(member);
			Action<object, object> setExtensionDataDictionary = JsonTypeReflector.ReflectionDelegateFactory.CreateSet<object>(member);
			Func<object> createExtensionDataDictionary = JsonTypeReflector.ReflectionDelegateFactory.CreateDefaultConstructor<object>(type4);
			MethodCall<object, object> setExtensionDataDictionaryValue = JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(method);
			ExtensionDataSetter extensionDataSetter = delegate(object o, string key, object value)
			{
				object obj = getExtensionDataDictionary(o);
				if (obj == null)
				{
					obj = createExtensionDataDictionary();
					setExtensionDataDictionary(o, obj);
				}
				if (isJTokenValueType && !(value is JToken))
				{
					value = ((value != null) ? JToken.FromObject(value) : JValue.CreateNull());
				}
				setExtensionDataDictionaryValue(obj, new object[]
				{
					key,
					value
				});
			};
			Type type5 = typeof(DefaultContractResolver.DictionaryEnumerator<, >).MakeGenericType(new Type[]
			{
				type2,
				type3
			});
			ConstructorInfo method2 = Enumerable.First<ConstructorInfo>(type5.GetConstructors());
			ObjectConstructor<object> createEnumerableWrapper = JsonTypeReflector.ReflectionDelegateFactory.CreateParametrizedConstructor(method2);
			ExtensionDataGetter extensionDataGetter = delegate(object o)
			{
				object obj = getExtensionDataDictionary(o);
				if (obj == null)
				{
					return null;
				}
				return (IEnumerable<KeyValuePair<object, object>>)createEnumerableWrapper(new object[]
				{
					obj
				});
			};
			if (attribute.ReadData)
			{
				contract.ExtensionDataSetter = extensionDataSetter;
			}
			if (attribute.WriteData)
			{
				contract.ExtensionDataGetter = extensionDataGetter;
			}
		}

		// Token: 0x06000A48 RID: 2632
		// RVA: 0x00040DA8 File Offset: 0x0003EFA8
		private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess)
		{
			MemberInfo memberInfo = member.DeclaringType.GetProperty(member.Name + "Specified");
			if (memberInfo == null)
			{
				memberInfo = member.DeclaringType.GetField(member.Name + "Specified");
			}
			if (memberInfo != null)
			{
				if (ReflectionUtils.GetMemberUnderlyingType(memberInfo) == typeof(bool))
				{
					Func<object, object> specifiedPropertyGet = JsonTypeReflector.ReflectionDelegateFactory.CreateGet<object>(memberInfo);
					property.GetIsSpecified = ((object o) => (bool)specifiedPropertyGet(o));
					if (ReflectionUtils.CanSetMemberValue(memberInfo, allowNonPublicAccess, false))
					{
						property.SetIsSpecified = JsonTypeReflector.ReflectionDelegateFactory.CreateSet<object>(memberInfo);
					}
					return;
				}
			}
		}

		// Token: 0x06000A46 RID: 2630
		// RVA: 0x00040B2C File Offset: 0x0003ED2C
		private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess)
		{
			JsonPropertyAttribute attribute = JsonTypeReflector.GetAttribute<JsonPropertyAttribute>(attributeProvider);
			if (attribute != null)
			{
				property.HasMemberAttribute = true;
			}
			string propertyName;
			if (attribute != null && attribute.PropertyName != null)
			{
				propertyName = attribute.PropertyName;
			}
			else
			{
				propertyName = name;
			}
			property.PropertyName = this.ResolvePropertyName(propertyName);
			property.UnderlyingName = name;
			bool flag = false;
			if (attribute != null)
			{
				property._required = attribute._required;
				property.Order = attribute._order;
				property.DefaultValueHandling = attribute._defaultValueHandling;
				flag = true;
			}
			bool flag2 = JsonTypeReflector.GetAttribute<JsonIgnoreAttribute>(attributeProvider) != null || JsonTypeReflector.GetAttribute<JsonExtensionDataAttribute>(attributeProvider) != null || JsonTypeReflector.GetAttribute<NonSerializedAttribute>(attributeProvider) != null;
			if (memberSerialization != MemberSerialization.OptIn)
			{
				bool flag3 = false;
				property.Ignored = (flag2 || flag3);
			}
			else
			{
				property.Ignored = (flag2 || !flag);
			}
			property.Converter = JsonTypeReflector.GetJsonConverter(attributeProvider);
			property.MemberConverter = JsonTypeReflector.GetJsonConverter(attributeProvider);
			DefaultValueAttribute attribute2 = JsonTypeReflector.GetAttribute<DefaultValueAttribute>(attributeProvider);
			if (attribute2 != null)
			{
				property.DefaultValue = attribute2.Value;
			}
			property.NullValueHandling = ((attribute != null) ? attribute._nullValueHandling : null);
			property.ReferenceLoopHandling = ((attribute != null) ? attribute._referenceLoopHandling : null);
			property.ObjectCreationHandling = ((attribute != null) ? attribute._objectCreationHandling : null);
			property.TypeNameHandling = ((attribute != null) ? attribute._typeNameHandling : null);
			property.IsReference = ((attribute != null) ? attribute._isReference : null);
			property.ItemIsReference = ((attribute != null) ? attribute._itemIsReference : null);
			property.ItemConverter = ((attribute == null || attribute.ItemConverterType == null) ? null : JsonTypeReflector.CreateJsonConverterInstance(attribute.ItemConverterType, attribute.ItemConverterParameters));
			property.ItemReferenceLoopHandling = ((attribute != null) ? attribute._itemReferenceLoopHandling : null);
			property.ItemTypeNameHandling = ((attribute != null) ? attribute._itemTypeNameHandling : null);
			allowNonPublicAccess = false;
			if ((this.DefaultMembersSearchFlags & BindingFlags.NonPublic) == BindingFlags.NonPublic)
			{
				allowNonPublicAccess = true;
			}
			if (attribute != null)
			{
				allowNonPublicAccess = true;
			}
			if (memberSerialization == MemberSerialization.Fields)
			{
				allowNonPublicAccess = true;
			}
		}
	}
}
