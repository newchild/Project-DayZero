using Newtonsoft.Json.Utilities.LinqBridge;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200015C RID: 348
	[ExtensionAttribute2]
	internal static class ReflectionUtils
	{
		// Token: 0x040005C8 RID: 1480
		public static readonly Type[] EmptyTypes;

		// Token: 0x06000D95 RID: 3477
		// RVA: 0x0000E67C File Offset: 0x0000C87C
		static ReflectionUtils()
		{
			ReflectionUtils.EmptyTypes = Type.EmptyTypes;
		}

		// Token: 0x06000DAF RID: 3503
		// RVA: 0x0004C3F8 File Offset: 0x0004A5F8
		public static bool CanReadMemberValue(MemberInfo member, bool nonPublic)
		{
			MemberTypes memberTypes = TypeExtensions.MemberType(member);
			if (memberTypes == MemberTypes.Field)
			{
				FieldInfo fieldInfo = (FieldInfo)member;
				return nonPublic || fieldInfo.IsPublic;
			}
			if (memberTypes != MemberTypes.Property)
			{
				return false;
			}
			PropertyInfo propertyInfo = (PropertyInfo)member;
			return propertyInfo.CanRead && (nonPublic || propertyInfo.GetGetMethod(nonPublic) != null);
		}

		// Token: 0x06000DB0 RID: 3504
		// RVA: 0x0004C454 File Offset: 0x0004A654
		public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly)
		{
			MemberTypes memberTypes = TypeExtensions.MemberType(member);
			if (memberTypes == MemberTypes.Field)
			{
				FieldInfo fieldInfo = (FieldInfo)member;
				return !fieldInfo.IsLiteral && (!fieldInfo.IsInitOnly || canSetReadOnly) && (nonPublic || fieldInfo.IsPublic);
			}
			if (memberTypes != MemberTypes.Property)
			{
				return false;
			}
			PropertyInfo propertyInfo = (PropertyInfo)member;
			return propertyInfo.CanWrite && (nonPublic || propertyInfo.GetSetMethod(nonPublic) != null);
		}

		// Token: 0x06000DA1 RID: 3489
		// RVA: 0x0000E739 File Offset: 0x0000C939
		public static Type EnsureNotNullableType(Type t)
		{
			if (!ReflectionUtils.IsNullableType(t))
			{
				return t;
			}
			return Nullable.GetUnderlyingType(t);
		}

		// Token: 0x06000DB8 RID: 3512
		// RVA: 0x0004C86C File Offset: 0x0004AA6C
		private static int? GetAssemblyDelimiterIndex(string fullyQualifiedTypeName)
		{
			int num = 0;
			for (int i = 0; i < fullyQualifiedTypeName.Length; i++)
			{
				char c = fullyQualifiedTypeName[i];
				char c2 = c;
				if (c2 != ',')
				{
					switch (c2)
					{
					case '[':
						num++;
						break;
					case ']':
						num--;
						break;
					}
				}
				else if (num == 0)
				{
					return new int?(i);
				}
			}
			return null;
		}

		// Token: 0x06000DB3 RID: 3507
		// RVA: 0x0000E763 File Offset: 0x0000C963
		public static T GetAttribute<T>(object attributeProvider) where T : Attribute
		{
			return ReflectionUtils.GetAttribute<T>(attributeProvider, true);
		}

		// Token: 0x06000DB4 RID: 3508
		// RVA: 0x0004C67C File Offset: 0x0004A87C
		public static T GetAttribute<T>(object attributeProvider, bool inherit) where T : Attribute
		{
			T[] attributes = ReflectionUtils.GetAttributes<T>(attributeProvider, inherit);
			if (attributes == null)
			{
				return default(T);
			}
			return Enumerable.FirstOrDefault<T>(attributes);
		}

		// Token: 0x06000DB5 RID: 3509
		// RVA: 0x0004C6A4 File Offset: 0x0004A8A4
		public static T[] GetAttributes<T>(object attributeProvider, bool inherit) where T : Attribute
		{
			Attribute[] attributes = ReflectionUtils.GetAttributes(attributeProvider, typeof(T), inherit);
			T[] array = attributes as T[];
			if (array != null)
			{
				return array;
			}
			return Enumerable.ToArray<T>(Enumerable.Cast<T>(attributes));
		}

		// Token: 0x06000DB6 RID: 3510
		// RVA: 0x0004C6DC File Offset: 0x0004A8DC
		public static Attribute[] GetAttributes(object attributeProvider, Type attributeType, bool inherit)
		{
			ValidationUtils.ArgumentNotNull(attributeProvider, "attributeProvider");
			if (attributeProvider is Type)
			{
				Type type = (Type)attributeProvider;
				object[] source = (attributeType != null) ? type.GetCustomAttributes(attributeType, inherit) : type.GetCustomAttributes(inherit);
				Attribute[] array = Enumerable.ToArray<Attribute>(Enumerable.Cast<Attribute>(source));
				if (inherit && type.BaseType != null)
				{
					array = Enumerable.ToArray<Attribute>(Enumerable.Union<Attribute>(array, ReflectionUtils.GetAttributes(type.BaseType, attributeType, inherit)));
				}
				return array;
			}
			if (attributeProvider is Assembly)
			{
				Assembly element = (Assembly)attributeProvider;
				if (attributeType == null)
				{
					return Attribute.GetCustomAttributes(element);
				}
				return Attribute.GetCustomAttributes(element, attributeType);
			}
			else if (attributeProvider is MemberInfo)
			{
				MemberInfo element2 = (MemberInfo)attributeProvider;
				if (attributeType == null)
				{
					return Attribute.GetCustomAttributes(element2, inherit);
				}
				return Attribute.GetCustomAttributes(element2, attributeType, inherit);
			}
			else if (attributeProvider is Module)
			{
				Module element3 = (Module)attributeProvider;
				if (attributeType == null)
				{
					return Attribute.GetCustomAttributes(element3, inherit);
				}
				return Attribute.GetCustomAttributes(element3, attributeType, inherit);
			}
			else
			{
				if (!(attributeProvider is ParameterInfo))
				{
					ICustomAttributeProvider customAttributeProvider = (ICustomAttributeProvider)attributeProvider;
					object[] array2 = (attributeType != null) ? customAttributeProvider.GetCustomAttributes(attributeType, inherit) : customAttributeProvider.GetCustomAttributes(inherit);
					return (Attribute[])array2;
				}
				ParameterInfo element4 = (ParameterInfo)attributeProvider;
				if (attributeType == null)
				{
					return Attribute.GetCustomAttributes(element4, inherit);
				}
				return Attribute.GetCustomAttributes(element4, attributeType, inherit);
			}
		}

		// Token: 0x06000D97 RID: 3479
		// RVA: 0x0004BE40 File Offset: 0x0004A040
		[ExtensionAttribute2]
		public static MethodInfo GetBaseDefinition(PropertyInfo propertyInfo)
		{
			ValidationUtils.ArgumentNotNull(propertyInfo, "propertyInfo");
			MethodInfo methodInfo = propertyInfo.GetGetMethod();
			if (methodInfo != null)
			{
				return methodInfo.GetBaseDefinition();
			}
			methodInfo = propertyInfo.GetSetMethod();
			if (methodInfo != null)
			{
				return methodInfo.GetBaseDefinition();
			}
			return null;
		}

		// Token: 0x06000DBB RID: 3515
		// RVA: 0x0004C988 File Offset: 0x0004AB88
		private static void GetChildPrivateFields(IList<MemberInfo> initialFields, Type targetType, BindingFlags bindingAttr)
		{
			if ((bindingAttr & BindingFlags.NonPublic) != BindingFlags.Default)
			{
				BindingFlags bindingAttr2 = ReflectionUtils.RemoveFlag(bindingAttr, BindingFlags.Public);
				while ((targetType = TypeExtensions.BaseType(targetType)) != null)
				{
					IEnumerable<MemberInfo> collection = Enumerable.Cast<MemberInfo>(Enumerable.Where<FieldInfo>(targetType.GetFields(bindingAttr2), (FieldInfo f) => f.IsPrivate));
					CollectionUtils.AddRange<MemberInfo>(initialFields, collection);
				}
			}
		}

		// Token: 0x06000DBE RID: 3518
		// RVA: 0x0004CA54 File Offset: 0x0004AC54
		private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, Type targetType, BindingFlags bindingAttr)
		{
			while ((targetType = TypeExtensions.BaseType(targetType)) != null)
			{
				PropertyInfo[] properties = targetType.GetProperties(bindingAttr);
				for (int i = 0; i < properties.Length; i++)
				{
					PropertyInfo subTypeProperty2 = properties[i];
					PropertyInfo subTypeProperty = subTypeProperty2;
					if (!ReflectionUtils.IsPublic(subTypeProperty))
					{
						int num = CollectionUtils.IndexOf<PropertyInfo>(initialProperties, (PropertyInfo p) => p.Name == subTypeProperty.Name);
						if (num == -1)
						{
							initialProperties.Add(subTypeProperty);
						}
						else
						{
							PropertyInfo property = initialProperties[num];
							if (!ReflectionUtils.IsPublic(property))
							{
								initialProperties[num] = subTypeProperty;
							}
						}
					}
					else if (!ReflectionUtils.IsVirtual(subTypeProperty))
					{
						int num2 = CollectionUtils.IndexOf<PropertyInfo>(initialProperties, (PropertyInfo p) => p.Name == subTypeProperty.Name && p.DeclaringType == subTypeProperty.DeclaringType);
						if (num2 == -1)
						{
							initialProperties.Add(subTypeProperty);
						}
					}
					else
					{
						int num3 = CollectionUtils.IndexOf<PropertyInfo>(initialProperties, (PropertyInfo p) => p.Name == subTypeProperty.Name && ReflectionUtils.IsVirtual(p) && ReflectionUtils.GetBaseDefinition(p) != null && ReflectionUtils.GetBaseDefinition(p).DeclaringType.IsAssignableFrom(subTypeProperty.DeclaringType));
						if (num3 == -1)
						{
							initialProperties.Add(subTypeProperty);
						}
					}
				}
			}
		}

		// Token: 0x06000DA8 RID: 3496
		// RVA: 0x0004C120 File Offset: 0x0004A320
		public static Type GetCollectionItemType(Type type)
		{
			ValidationUtils.ArgumentNotNull(type, "type");
			if (type.IsArray)
			{
				return type.GetElementType();
			}
			Type type2;
			if (ReflectionUtils.ImplementsGenericDefinition(type, typeof(IEnumerable<>), out type2))
			{
				if (TypeExtensions.IsGenericTypeDefinition(type2))
				{
					throw new Exception(StringUtils.FormatWith("Type {0} is not a collection.", CultureInfo.InvariantCulture, type));
				}
				return type2.GetGenericArguments()[0];
			}
			else
			{
				if (!typeof(IEnumerable).IsAssignableFrom(type))
				{
					throw new Exception(StringUtils.FormatWith("Type {0} is not a collection.", CultureInfo.InvariantCulture, type));
				}
				return null;
			}
		}

		// Token: 0x06000D9D RID: 3485
		// RVA: 0x0000E6EA File Offset: 0x0000C8EA
		public static ConstructorInfo GetDefaultConstructor(Type t)
		{
			return ReflectionUtils.GetDefaultConstructor(t, false);
		}

		// Token: 0x06000D9E RID: 3486
		// RVA: 0x0004BF48 File Offset: 0x0004A148
		public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic)
		{
			BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Public;
			if (nonPublic)
			{
				bindingFlags |= BindingFlags.NonPublic;
			}
			return Enumerable.SingleOrDefault<ConstructorInfo>(t.GetConstructors(bindingFlags), (ConstructorInfo c) => !Enumerable.Any<ParameterInfo>(c.GetParameters()));
		}

		// Token: 0x06000DC0 RID: 3520
		// RVA: 0x0004CBC0 File Offset: 0x0004ADC0
		public static object GetDefaultValue(Type type)
		{
			if (!TypeExtensions.IsValueType(type))
			{
				return null;
			}
			PrimitiveTypeCode typeCode = ConvertUtils.GetTypeCode(type);
			switch (typeCode)
			{
			case PrimitiveTypeCode.Char:
			case PrimitiveTypeCode.SByte:
			case PrimitiveTypeCode.Int16:
			case PrimitiveTypeCode.UInt16:
			case PrimitiveTypeCode.Int32:
			case PrimitiveTypeCode.Byte:
			case PrimitiveTypeCode.UInt32:
				return 0;
			case PrimitiveTypeCode.CharNullable:
			case PrimitiveTypeCode.BooleanNullable:
			case PrimitiveTypeCode.SByteNullable:
			case PrimitiveTypeCode.Int16Nullable:
			case PrimitiveTypeCode.UInt16Nullable:
			case PrimitiveTypeCode.Int32Nullable:
			case PrimitiveTypeCode.ByteNullable:
			case PrimitiveTypeCode.UInt32Nullable:
			case PrimitiveTypeCode.Int64Nullable:
			case PrimitiveTypeCode.UInt64Nullable:
			case PrimitiveTypeCode.SingleNullable:
			case PrimitiveTypeCode.DoubleNullable:
				break;
			case PrimitiveTypeCode.Boolean:
				return false;
			case PrimitiveTypeCode.Int64:
			case PrimitiveTypeCode.UInt64:
				return 0L;
			case PrimitiveTypeCode.Single:
				return 0f;
			case PrimitiveTypeCode.Double:
				return 0.0;
			case PrimitiveTypeCode.DateTime:
				return default(DateTime);
			default:
				switch (typeCode)
				{
				case PrimitiveTypeCode.Decimal:
					return 0m;
				case PrimitiveTypeCode.Guid:
					return default(Guid);
				}
				break;
			}
			if (ReflectionUtils.IsNullable(type))
			{
				return null;
			}
			return Activator.CreateInstance(type);
		}

		// Token: 0x06000DA9 RID: 3497
		// RVA: 0x0004C1AC File Offset: 0x0004A3AC
		public static void GetDictionaryKeyValueTypes(Type dictionaryType, out Type keyType, out Type valueType)
		{
			ValidationUtils.ArgumentNotNull(dictionaryType, "type");
			Type type;
			if (ReflectionUtils.ImplementsGenericDefinition(dictionaryType, typeof(IDictionary<, >), out type))
			{
				if (TypeExtensions.IsGenericTypeDefinition(type))
				{
					throw new Exception(StringUtils.FormatWith("Type {0} is not a dictionary.", CultureInfo.InvariantCulture, dictionaryType));
				}
				Type[] genericArguments = type.GetGenericArguments();
				keyType = genericArguments[0];
				valueType = genericArguments[1];
				return;
			}
			else
			{
				if (!typeof(IDictionary).IsAssignableFrom(dictionaryType))
				{
					throw new Exception(StringUtils.FormatWith("Type {0} is not a dictionary.", CultureInfo.InvariantCulture, dictionaryType));
				}
				keyType = null;
				valueType = null;
				return;
			}
		}

		// Token: 0x06000DBA RID: 3514
		// RVA: 0x0004C954 File Offset: 0x0004AB54
		public static IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr)
		{
			ValidationUtils.ArgumentNotNull(targetType, "targetType");
			List<MemberInfo> list = new List<MemberInfo>(targetType.GetFields(bindingAttr));
			ReflectionUtils.GetChildPrivateFields(list, targetType, bindingAttr);
			return Enumerable.Cast<FieldInfo>(list);
		}

		// Token: 0x06000DB1 RID: 3505
		// RVA: 0x0004C4C8 File Offset: 0x0004A6C8
		public static List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr)
		{
			List<MemberInfo> list = new List<MemberInfo>();
			CollectionUtils.AddRange<MemberInfo>(list, ReflectionUtils.GetFields(type, bindingAttr));
			CollectionUtils.AddRange<MemberInfo>(list, ReflectionUtils.GetProperties(type, bindingAttr));
			List<MemberInfo> list2 = new List<MemberInfo>(list.Count);
			foreach (IGrouping<string, MemberInfo> current in Enumerable.GroupBy<MemberInfo, string>(list, (MemberInfo m) => m.Name))
			{
				int num = Enumerable.Count<MemberInfo>(current);
				IList<MemberInfo> list3 = Enumerable.ToList<MemberInfo>(current);
				if (num == 1)
				{
					list2.Add(Enumerable.First<MemberInfo>(list3));
				}
				else
				{
					IList<MemberInfo> list4 = new List<MemberInfo>();
					foreach (MemberInfo current2 in list3)
					{
						if (list4.Count == 0)
						{
							list4.Add(current2);
						}
						else if (!ReflectionUtils.IsOverridenGenericMember(current2, bindingAttr) || current2.Name == "Item")
						{
							list4.Add(current2);
						}
					}
					list2.AddRange(list4);
				}
			}
			return list2;
		}

		// Token: 0x06000DB9 RID: 3513
		// RVA: 0x0004C8D4 File Offset: 0x0004AAD4
		public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo)
		{
			MemberTypes memberTypes = TypeExtensions.MemberType(memberInfo);
			if (memberTypes == MemberTypes.Property)
			{
				PropertyInfo propertyInfo = (PropertyInfo)memberInfo;
				Type[] types = Enumerable.ToArray<Type>(Enumerable.Select<ParameterInfo, Type>(propertyInfo.GetIndexParameters(), (ParameterInfo p) => p.ParameterType));
				return targetType.GetProperty(propertyInfo.Name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, propertyInfo.PropertyType, types, null);
			}
			return Enumerable.SingleOrDefault<MemberInfo>(targetType.GetMember(memberInfo.Name, TypeExtensions.MemberType(memberInfo), BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic));
		}

		// Token: 0x06000DAA RID: 3498
		// RVA: 0x0004C238 File Offset: 0x0004A438
		public static Type GetMemberUnderlyingType(MemberInfo member)
		{
			ValidationUtils.ArgumentNotNull(member, "member");
			MemberTypes memberTypes = TypeExtensions.MemberType(member);
			switch (memberTypes)
			{
			case MemberTypes.Event:
				return ((EventInfo)member).EventHandlerType;
			case MemberTypes.Constructor | MemberTypes.Event:
				break;
			case MemberTypes.Field:
				return ((FieldInfo)member).FieldType;
			default:
				if (memberTypes == MemberTypes.Method)
				{
					return ((MethodInfo)member).ReturnType;
				}
				if (memberTypes == MemberTypes.Property)
				{
					return ((PropertyInfo)member).PropertyType;
				}
				break;
			}
			throw new ArgumentException("MemberInfo must be of type FieldInfo, PropertyInfo, EventInfo or MethodInfo", "member");
		}

		// Token: 0x06000DAD RID: 3501
		// RVA: 0x0004C2E4 File Offset: 0x0004A4E4
		public static object GetMemberValue(MemberInfo member, object target)
		{
			ValidationUtils.ArgumentNotNull(member, "member");
			ValidationUtils.ArgumentNotNull(target, "target");
			MemberTypes memberTypes = TypeExtensions.MemberType(member);
			if (memberTypes == MemberTypes.Field)
			{
				return ((FieldInfo)member).GetValue(target);
			}
			if (memberTypes != MemberTypes.Property)
			{
				throw new ArgumentException(StringUtils.FormatWith("MemberInfo '{0}' is not of type FieldInfo or PropertyInfo", CultureInfo.InvariantCulture, CultureInfo.InvariantCulture, member.Name), "member");
			}
			object value;
			try
			{
				value = ((PropertyInfo)member).GetValue(target, null);
			}
			catch (TargetParameterCountException innerException)
			{
				throw new ArgumentException(StringUtils.FormatWith("MemberInfo '{0}' has index parameters", CultureInfo.InvariantCulture, member.Name), innerException);
			}
			return value;
		}

		// Token: 0x06000D99 RID: 3481
		// RVA: 0x0000E6B9 File Offset: 0x0000C8B9
		public static Type GetObjectType(object v)
		{
			if (v == null)
			{
				return null;
			}
			return v.GetType();
		}

		// Token: 0x06000DBC RID: 3516
		// RVA: 0x0004C9E8 File Offset: 0x0004ABE8
		public static IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr)
		{
			ValidationUtils.ArgumentNotNull(targetType, "targetType");
			List<PropertyInfo> list = new List<PropertyInfo>(targetType.GetProperties(bindingAttr));
			ReflectionUtils.GetChildPrivateProperties(list, targetType, bindingAttr);
			for (int i = 0; i < list.Count; i++)
			{
				PropertyInfo propertyInfo = list[i];
				if (propertyInfo.DeclaringType != targetType)
				{
					PropertyInfo value = (PropertyInfo)ReflectionUtils.GetMemberInfoFromType(propertyInfo.DeclaringType, propertyInfo);
					list[i] = value;
				}
			}
			return list;
		}

		// Token: 0x06000D9A RID: 3482
		// RVA: 0x0004BE7C File Offset: 0x0004A07C
		public static string GetTypeName(Type t, FormatterAssemblyStyle assemblyFormat, SerializationBinder binder)
		{
			string assemblyQualifiedName = t.AssemblyQualifiedName;
			switch (assemblyFormat)
			{
			case FormatterAssemblyStyle.Simple:
				return ReflectionUtils.RemoveAssemblyDetails(assemblyQualifiedName);
			case FormatterAssemblyStyle.Full:
				return assemblyQualifiedName;
			default:
				throw new ArgumentOutOfRangeException();
			}
		}

		// Token: 0x06000D9C RID: 3484
		// RVA: 0x0000E6C6 File Offset: 0x0000C8C6
		public static bool HasDefaultConstructor(Type t, bool nonPublic)
		{
			ValidationUtils.ArgumentNotNull(t, "t");
			return TypeExtensions.IsValueType(t) || ReflectionUtils.GetDefaultConstructor(t, nonPublic) != null;
		}

		// Token: 0x06000DA3 RID: 3491
		// RVA: 0x0004BFB0 File Offset: 0x0004A1B0
		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition)
		{
			Type type2;
			return ReflectionUtils.ImplementsGenericDefinition(type, genericInterfaceDefinition, out type2);
		}

		// Token: 0x06000DA4 RID: 3492
		// RVA: 0x0004BFC8 File Offset: 0x0004A1C8
		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, out Type implementingType)
		{
			ValidationUtils.ArgumentNotNull(type, "type");
			ValidationUtils.ArgumentNotNull(genericInterfaceDefinition, "genericInterfaceDefinition");
			if (TypeExtensions.IsInterface(genericInterfaceDefinition) && TypeExtensions.IsGenericTypeDefinition(genericInterfaceDefinition))
			{
				if (TypeExtensions.IsInterface(type) && TypeExtensions.IsGenericType(type))
				{
					Type genericTypeDefinition = type.GetGenericTypeDefinition();
					if (genericInterfaceDefinition == genericTypeDefinition)
					{
						implementingType = type;
						return true;
					}
				}
				Type[] interfaces = type.GetInterfaces();
				for (int i = 0; i < interfaces.Length; i++)
				{
					Type type2 = interfaces[i];
					if (TypeExtensions.IsGenericType(type2))
					{
						Type genericTypeDefinition2 = type2.GetGenericTypeDefinition();
						if (genericInterfaceDefinition == genericTypeDefinition2)
						{
							implementingType = type2;
							return true;
						}
					}
				}
				implementingType = null;
				return false;
			}
			throw new ArgumentNullException(StringUtils.FormatWith("'{0}' is not a generic interface definition.", CultureInfo.InvariantCulture, genericInterfaceDefinition));
		}

		// Token: 0x06000DA5 RID: 3493
		// RVA: 0x0004C074 File Offset: 0x0004A274
		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition)
		{
			Type type2;
			return ReflectionUtils.InheritsGenericDefinition(type, genericClassDefinition, out type2);
		}

		// Token: 0x06000DA6 RID: 3494
		// RVA: 0x0004C08C File Offset: 0x0004A28C
		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, out Type implementingType)
		{
			ValidationUtils.ArgumentNotNull(type, "type");
			ValidationUtils.ArgumentNotNull(genericClassDefinition, "genericClassDefinition");
			if (!TypeExtensions.IsClass(genericClassDefinition) || !TypeExtensions.IsGenericTypeDefinition(genericClassDefinition))
			{
				throw new ArgumentNullException(StringUtils.FormatWith("'{0}' is not a generic class definition.", CultureInfo.InvariantCulture, genericClassDefinition));
			}
			return ReflectionUtils.InheritsGenericDefinitionInternal(type, genericClassDefinition, out implementingType);
		}

		// Token: 0x06000DA7 RID: 3495
		// RVA: 0x0004C0E0 File Offset: 0x0004A2E0
		private static bool InheritsGenericDefinitionInternal(Type currentType, Type genericClassDefinition, out Type implementingType)
		{
			if (TypeExtensions.IsGenericType(currentType))
			{
				Type genericTypeDefinition = currentType.GetGenericTypeDefinition();
				if (genericClassDefinition == genericTypeDefinition)
				{
					implementingType = currentType;
					return true;
				}
			}
			if (TypeExtensions.BaseType(currentType) == null)
			{
				implementingType = null;
				return false;
			}
			return ReflectionUtils.InheritsGenericDefinitionInternal(TypeExtensions.BaseType(currentType), genericClassDefinition, out implementingType);
		}

		// Token: 0x06000DA2 RID: 3490
		// RVA: 0x0004BF8C File Offset: 0x0004A18C
		public static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition)
		{
			if (!TypeExtensions.IsGenericType(type))
			{
				return false;
			}
			Type genericTypeDefinition = type.GetGenericTypeDefinition();
			return genericTypeDefinition == genericInterfaceDefinition;
		}

		// Token: 0x06000DAB RID: 3499
		// RVA: 0x0004C2B8 File Offset: 0x0004A4B8
		public static bool IsIndexedProperty(MemberInfo member)
		{
			ValidationUtils.ArgumentNotNull(member, "member");
			PropertyInfo propertyInfo = member as PropertyInfo;
			return propertyInfo != null && ReflectionUtils.IsIndexedProperty(propertyInfo);
		}

		// Token: 0x06000DAC RID: 3500
		// RVA: 0x0000E74B File Offset: 0x0000C94B
		public static bool IsIndexedProperty(PropertyInfo property)
		{
			ValidationUtils.ArgumentNotNull(property, "property");
			return property.GetIndexParameters().Length > 0;
		}

		// Token: 0x06000DBF RID: 3519
		// RVA: 0x0004CB84 File Offset: 0x0004AD84
		public static bool IsMethodOverridden(Type currentType, Type methodDeclaringType, string method)
		{
			return Enumerable.Any<MethodInfo>(currentType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), (MethodInfo info) => info.Name == method && info.DeclaringType != methodDeclaringType && info.GetBaseDefinition().DeclaringType == methodDeclaringType);
		}

		// Token: 0x06000D9F RID: 3487
		// RVA: 0x0000E6F3 File Offset: 0x0000C8F3
		public static bool IsNullable(Type t)
		{
			ValidationUtils.ArgumentNotNull(t, "t");
			return !TypeExtensions.IsValueType(t) || ReflectionUtils.IsNullableType(t);
		}

		// Token: 0x06000DA0 RID: 3488
		// RVA: 0x0000E710 File Offset: 0x0000C910
		public static bool IsNullableType(Type t)
		{
			ValidationUtils.ArgumentNotNull(t, "t");
			return TypeExtensions.IsGenericType(t) && t.GetGenericTypeDefinition() == typeof(Nullable<>);
		}

		// Token: 0x06000DB2 RID: 3506
		// RVA: 0x0004C608 File Offset: 0x0004A808
		private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr)
		{
			if (TypeExtensions.MemberType(memberInfo) != MemberTypes.Property)
			{
				return false;
			}
			PropertyInfo propertyInfo = (PropertyInfo)memberInfo;
			if (!ReflectionUtils.IsVirtual(propertyInfo))
			{
				return false;
			}
			Type declaringType = propertyInfo.DeclaringType;
			if (!TypeExtensions.IsGenericType(declaringType))
			{
				return false;
			}
			Type genericTypeDefinition = declaringType.GetGenericTypeDefinition();
			if (genericTypeDefinition == null)
			{
				return false;
			}
			MemberInfo[] member = genericTypeDefinition.GetMember(propertyInfo.Name, bindingAttr);
			if (member.Length == 0)
			{
				return false;
			}
			Type memberUnderlyingType = ReflectionUtils.GetMemberUnderlyingType(member[0]);
			return memberUnderlyingType.IsGenericParameter;
		}

		// Token: 0x06000D98 RID: 3480
		// RVA: 0x0000E688 File Offset: 0x0000C888
		public static bool IsPublic(PropertyInfo property)
		{
			return (property.GetGetMethod() != null && property.GetGetMethod().IsPublic) || (property.GetSetMethod() != null && property.GetSetMethod().IsPublic);
		}

		// Token: 0x06000D96 RID: 3478
		// RVA: 0x0004BDFC File Offset: 0x00049FFC
		[ExtensionAttribute2]
		public static bool IsVirtual(PropertyInfo propertyInfo)
		{
			ValidationUtils.ArgumentNotNull(propertyInfo, "propertyInfo");
			MethodInfo methodInfo = propertyInfo.GetGetMethod();
			if (methodInfo != null && methodInfo.IsVirtual)
			{
				return true;
			}
			methodInfo = propertyInfo.GetSetMethod();
			return methodInfo != null && methodInfo.IsVirtual;
		}

		// Token: 0x06000D9B RID: 3483
		// RVA: 0x0004BEB0 File Offset: 0x0004A0B0
		private static string RemoveAssemblyDetails(string fullyQualifiedTypeName)
		{
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = false;
			bool flag2 = false;
			for (int i = 0; i < fullyQualifiedTypeName.Length; i++)
			{
				char c = fullyQualifiedTypeName[i];
				char c2 = c;
				if (c2 != ',')
				{
					switch (c2)
					{
					case '[':
						flag = false;
						flag2 = false;
						stringBuilder.Append(c);
						goto IL_77;
					case ']':
						flag = false;
						flag2 = false;
						stringBuilder.Append(c);
						goto IL_77;
					}
					if (!flag2)
					{
						stringBuilder.Append(c);
					}
				}
				else if (!flag)
				{
					flag = true;
					stringBuilder.Append(c);
				}
				else
				{
					flag2 = true;
				}
				IL_77:;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000DBD RID: 3517
		// RVA: 0x0000E76C File Offset: 0x0000C96C
		[ExtensionAttribute2]
		public static BindingFlags RemoveFlag(BindingFlags bindingAttr, BindingFlags flag)
		{
			if ((bindingAttr & flag) != flag)
			{
				return bindingAttr;
			}
			return bindingAttr ^ flag;
		}

		// Token: 0x06000DAE RID: 3502
		// RVA: 0x0004C388 File Offset: 0x0004A588
		public static void SetMemberValue(MemberInfo member, object target, object value)
		{
			ValidationUtils.ArgumentNotNull(member, "member");
			ValidationUtils.ArgumentNotNull(target, "target");
			MemberTypes memberTypes = TypeExtensions.MemberType(member);
			if (memberTypes == MemberTypes.Field)
			{
				((FieldInfo)member).SetValue(target, value);
				return;
			}
			if (memberTypes != MemberTypes.Property)
			{
				throw new ArgumentException(StringUtils.FormatWith("MemberInfo '{0}' must be of type FieldInfo or PropertyInfo", CultureInfo.InvariantCulture, member.Name), "member");
			}
			((PropertyInfo)member).SetValue(target, value, null);
		}

		// Token: 0x06000DB7 RID: 3511
		// RVA: 0x0004C80C File Offset: 0x0004AA0C
		public static void SplitFullyQualifiedTypeName(string fullyQualifiedTypeName, out string typeName, out string assemblyName)
		{
			int? assemblyDelimiterIndex = ReflectionUtils.GetAssemblyDelimiterIndex(fullyQualifiedTypeName);
			if (assemblyDelimiterIndex.HasValue)
			{
				typeName = fullyQualifiedTypeName.Substring(0, assemblyDelimiterIndex.Value).Trim();
				assemblyName = fullyQualifiedTypeName.Substring(assemblyDelimiterIndex.Value + 1, fullyQualifiedTypeName.Length - assemblyDelimiterIndex.Value - 1).Trim();
				return;
			}
			typeName = fullyQualifiedTypeName;
			assemblyName = null;
		}
	}
}
