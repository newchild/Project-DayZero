using Newtonsoft.Json.Utilities;
using Newtonsoft.Json.Utilities.LinqBridge;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Security.Permissions;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000127 RID: 295
	internal static class JsonTypeReflector
	{
		// Token: 0x04000520 RID: 1312
		public const string ArrayValuesPropertyName = "$values";

		// Token: 0x0400051C RID: 1308
		public const string IdPropertyName = "$id";

		// Token: 0x04000525 RID: 1317
		private static readonly ThreadSafeStore<Type, Func<object[], JsonConverter>> JsonConverterCreatorCache = new ThreadSafeStore<Type, Func<object[], JsonConverter>>(new Func<Type, Func<object[], JsonConverter>>(JsonTypeReflector.GetJsonConverterCreator));

		// Token: 0x0400051D RID: 1309
		public const string RefPropertyName = "$ref";

		// Token: 0x04000521 RID: 1313
		public const string ShouldSerializePrefix = "ShouldSerialize";

		// Token: 0x04000522 RID: 1314
		public const string SpecifiedPostfix = "Specified";

		// Token: 0x0400051E RID: 1310
		public const string TypePropertyName = "$type";

		// Token: 0x0400051F RID: 1311
		public const string ValuePropertyName = "$value";

		// Token: 0x04000523 RID: 1315
		private static bool? _dynamicCodeGeneration;

		// Token: 0x04000524 RID: 1316
		private static bool? _fullyTrusted;

		// Token: 0x17000250 RID: 592
		public static bool DynamicCodeGeneration
		{
			// Token: 0x06000C56 RID: 3158
			// RVA: 0x00047F6C File Offset: 0x0004616C
			get
			{
				if (!JsonTypeReflector._dynamicCodeGeneration.HasValue)
				{
					try
					{
						new ReflectionPermission(ReflectionPermissionFlag.MemberAccess).Demand();
						new ReflectionPermission(ReflectionPermissionFlag.RestrictedMemberAccess).Demand();
						new SecurityPermission(SecurityPermissionFlag.SkipVerification).Demand();
						new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
						new SecurityPermission(PermissionState.Unrestricted).Demand();
						JsonTypeReflector._dynamicCodeGeneration = new bool?(true);
					}
					catch (Exception)
					{
						JsonTypeReflector._dynamicCodeGeneration = new bool?(false);
					}
				}
				return JsonTypeReflector._dynamicCodeGeneration.Value;
			}
		}

		// Token: 0x17000251 RID: 593
		public static bool FullyTrusted
		{
			// Token: 0x06000C57 RID: 3159
			// RVA: 0x00047FF4 File Offset: 0x000461F4
			get
			{
				if (!JsonTypeReflector._fullyTrusted.HasValue)
				{
					try
					{
						new SecurityPermission(PermissionState.Unrestricted).Demand();
						JsonTypeReflector._fullyTrusted = new bool?(true);
					}
					catch (Exception)
					{
						JsonTypeReflector._fullyTrusted = new bool?(false);
					}
				}
				return JsonTypeReflector._fullyTrusted.Value;
			}
		}

		// Token: 0x17000252 RID: 594
		public static ReflectionDelegateFactory ReflectionDelegateFactory
		{
			// Token: 0x06000C58 RID: 3160
			// RVA: 0x0000D645 File Offset: 0x0000B845
			get
			{
				if (JsonTypeReflector.DynamicCodeGeneration)
				{
					return DynamicReflectionDelegateFactory.Instance;
				}
				return LateBoundReflectionDelegateFactory.Instance;
			}
		}

		// Token: 0x06000C50 RID: 3152
		// RVA: 0x00047DE8 File Offset: 0x00045FE8
		public static JsonConverter CreateJsonConverterInstance(Type converterType, object[] converterArgs)
		{
			Func<object[], JsonConverter> func = JsonTypeReflector.JsonConverterCreatorCache.Get(converterType);
			return func(converterArgs);
		}

		// Token: 0x06000C53 RID: 3155
		// RVA: 0x00047E58 File Offset: 0x00046058
		private static T GetAttribute<T>(Type type) where T : Attribute
		{
			T attribute = ReflectionUtils.GetAttribute<T>(type, true);
			if (attribute != null)
			{
				return attribute;
			}
			Type[] interfaces = type.GetInterfaces();
			for (int i = 0; i < interfaces.Length; i++)
			{
				Type attributeProvider = interfaces[i];
				attribute = ReflectionUtils.GetAttribute<T>(attributeProvider, true);
				if (attribute != null)
				{
					return attribute;
				}
			}
			return default(T);
		}

		// Token: 0x06000C54 RID: 3156
		// RVA: 0x00047EB8 File Offset: 0x000460B8
		private static T GetAttribute<T>(MemberInfo memberInfo) where T : Attribute
		{
			T attribute = ReflectionUtils.GetAttribute<T>(memberInfo, true);
			if (attribute != null)
			{
				return attribute;
			}
			if (memberInfo.DeclaringType != null)
			{
				Type[] interfaces = memberInfo.DeclaringType.GetInterfaces();
				for (int i = 0; i < interfaces.Length; i++)
				{
					Type targetType = interfaces[i];
					MemberInfo memberInfoFromType = ReflectionUtils.GetMemberInfoFromType(targetType, memberInfo);
					if (memberInfoFromType != null)
					{
						attribute = ReflectionUtils.GetAttribute<T>(memberInfoFromType, true);
						if (attribute != null)
						{
							return attribute;
						}
					}
				}
			}
			return default(T);
		}

		// Token: 0x06000C55 RID: 3157
		// RVA: 0x00047F34 File Offset: 0x00046134
		public static T GetAttribute<T>(object provider) where T : Attribute
		{
			Type type = provider as Type;
			if (type != null)
			{
				return JsonTypeReflector.GetAttribute<T>(type);
			}
			MemberInfo memberInfo = provider as MemberInfo;
			if (memberInfo != null)
			{
				return JsonTypeReflector.GetAttribute<T>(memberInfo);
			}
			return ReflectionUtils.GetAttribute<T>(provider, true);
		}

		// Token: 0x06000C4D RID: 3149
		// RVA: 0x0000D635 File Offset: 0x0000B835
		public static T GetCachedAttribute<T>(object attributeProvider) where T : Attribute
		{
			return CachedAttributeGetter<T>.GetAttribute(attributeProvider);
		}

		// Token: 0x06000C4F RID: 3151
		// RVA: 0x00047DAC File Offset: 0x00045FAC
		public static JsonConverter GetJsonConverter(object attributeProvider)
		{
			JsonConverterAttribute cachedAttribute = JsonTypeReflector.GetCachedAttribute<JsonConverterAttribute>(attributeProvider);
			if (cachedAttribute != null)
			{
				Func<object[], JsonConverter> func = JsonTypeReflector.JsonConverterCreatorCache.Get(cachedAttribute.ConverterType);
				if (func != null)
				{
					return func(cachedAttribute.ConverterParameters);
				}
			}
			return null;
		}

		// Token: 0x06000C51 RID: 3153
		// RVA: 0x00047E08 File Offset: 0x00046008
		private static Func<object[], JsonConverter> GetJsonConverterCreator(Type converterType)
		{
			Func<object> defaultConstructor = ReflectionUtils.HasDefaultConstructor(converterType, false) ? JsonTypeReflector.ReflectionDelegateFactory.CreateDefaultConstructor<object>(converterType) : null;
			return delegate(object[] parameters)
			{
				JsonConverter result;
				try
				{
					if (parameters != null)
					{
						Type[] types = Enumerable.ToArray<Type>(Enumerable.Select<object, Type>(parameters, (object param) => param.GetType()));
						ConstructorInfo constructor = converterType.GetConstructor(types);
						if (constructor == null)
						{
							throw new JsonException(StringUtils.FormatWith("No matching parameterized constructor found for '{0}'.", CultureInfo.InvariantCulture, converterType));
						}
						ObjectConstructor<object> objectConstructor = JsonTypeReflector.ReflectionDelegateFactory.CreateParametrizedConstructor(constructor);
						result = (JsonConverter)objectConstructor(parameters);
					}
					else
					{
						if (defaultConstructor == null)
						{
							throw new JsonException(StringUtils.FormatWith("No parameterless constructor defined for '{0}'.", CultureInfo.InvariantCulture, converterType));
						}
						result = (JsonConverter)defaultConstructor();
					}
				}
				catch (Exception innerException)
				{
					throw new JsonException(StringUtils.FormatWith("Error creating '{0}'.", CultureInfo.InvariantCulture, converterType), innerException);
				}
				return result;
			};
		}

		// Token: 0x06000C4E RID: 3150
		// RVA: 0x00047D7C File Offset: 0x00045F7C
		public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute)
		{
			JsonObjectAttribute cachedAttribute = JsonTypeReflector.GetCachedAttribute<JsonObjectAttribute>(objectType);
			if (cachedAttribute != null)
			{
				return cachedAttribute.MemberSerialization;
			}
			if (!ignoreSerializableAttribute)
			{
				SerializableAttribute cachedAttribute2 = JsonTypeReflector.GetCachedAttribute<SerializableAttribute>(objectType);
				if (cachedAttribute2 != null)
				{
					return MemberSerialization.Fields;
				}
			}
			return MemberSerialization.OptOut;
		}

		// Token: 0x06000C52 RID: 3154
		// RVA: 0x0000D63D File Offset: 0x0000B83D
		public static TypeConverter GetTypeConverter(Type type)
		{
			return TypeDescriptor.GetConverter(type);
		}
	}
}
