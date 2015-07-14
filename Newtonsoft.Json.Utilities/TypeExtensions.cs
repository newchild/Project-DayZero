using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000161 RID: 353
	[ExtensionAttribute2]
	internal static class TypeExtensions
	{
		// Token: 0x06000DE5 RID: 3557
		// RVA: 0x0000E8F3 File Offset: 0x0000CAF3
		[ExtensionAttribute2]
		public static Assembly Assembly(Type type)
		{
			return type.Assembly;
		}

		// Token: 0x06000DED RID: 3565
		// RVA: 0x0004D010 File Offset: 0x0004B210
		[ExtensionAttribute2]
		public static bool AssignableToTypeName(Type type, string fullTypeName)
		{
			Type type2;
			return TypeExtensions.AssignableToTypeName(type, fullTypeName, out type2);
		}

		// Token: 0x06000DEC RID: 3564
		// RVA: 0x0004CFA4 File Offset: 0x0004B1A4
		[ExtensionAttribute2]
		public static bool AssignableToTypeName(Type type, string fullTypeName, out Type match)
		{
			for (Type type2 = type; type2 != null; type2 = TypeExtensions.BaseType(type2))
			{
				if (string.Equals(type2.FullName, fullTypeName, StringComparison.Ordinal))
				{
					match = type2;
					return true;
				}
			}
			Type[] interfaces = type.GetInterfaces();
			for (int i = 0; i < interfaces.Length; i++)
			{
				Type type3 = interfaces[i];
				if (string.Equals(type3.Name, fullTypeName, StringComparison.Ordinal))
				{
					match = type;
					return true;
				}
			}
			match = null;
			return false;
		}

		// Token: 0x06000DE4 RID: 3556
		// RVA: 0x0000E8EB File Offset: 0x0000CAEB
		[ExtensionAttribute2]
		public static Type BaseType(Type type)
		{
			return type.BaseType;
		}

		// Token: 0x06000DE0 RID: 3552
		// RVA: 0x0000E8CB File Offset: 0x0000CACB
		[ExtensionAttribute2]
		public static bool ContainsGenericParameters(Type type)
		{
			return type.ContainsGenericParameters;
		}

		// Token: 0x06000DE9 RID: 3561
		// RVA: 0x0000E913 File Offset: 0x0000CB13
		[ExtensionAttribute2]
		public static bool IsAbstract(Type type)
		{
			return type.IsAbstract;
		}

		// Token: 0x06000DE7 RID: 3559
		// RVA: 0x0000E903 File Offset: 0x0000CB03
		[ExtensionAttribute2]
		public static bool IsClass(Type type)
		{
			return type.IsClass;
		}

		// Token: 0x06000DE6 RID: 3558
		// RVA: 0x0000E8FB File Offset: 0x0000CAFB
		[ExtensionAttribute2]
		public static bool IsEnum(Type type)
		{
			return type.IsEnum;
		}

		// Token: 0x06000DE2 RID: 3554
		// RVA: 0x0000E8DB File Offset: 0x0000CADB
		[ExtensionAttribute2]
		public static bool IsGenericType(Type type)
		{
			return type.IsGenericType;
		}

		// Token: 0x06000DE3 RID: 3555
		// RVA: 0x0000E8E3 File Offset: 0x0000CAE3
		[ExtensionAttribute2]
		public static bool IsGenericTypeDefinition(Type type)
		{
			return type.IsGenericTypeDefinition;
		}

		// Token: 0x06000DE1 RID: 3553
		// RVA: 0x0000E8D3 File Offset: 0x0000CAD3
		[ExtensionAttribute2]
		public static bool IsInterface(Type type)
		{
			return type.IsInterface;
		}

		// Token: 0x06000DE8 RID: 3560
		// RVA: 0x0000E90B File Offset: 0x0000CB0B
		[ExtensionAttribute2]
		public static bool IsSealed(Type type)
		{
			return type.IsSealed;
		}

		// Token: 0x06000DEB RID: 3563
		// RVA: 0x0000E923 File Offset: 0x0000CB23
		[ExtensionAttribute2]
		public static bool IsValueType(Type type)
		{
			return type.IsValueType;
		}

		// Token: 0x06000DEA RID: 3562
		// RVA: 0x0000E91B File Offset: 0x0000CB1B
		[ExtensionAttribute2]
		public static bool IsVisible(Type type)
		{
			return type.IsVisible;
		}

		// Token: 0x06000DDF RID: 3551
		// RVA: 0x0000E8C3 File Offset: 0x0000CAC3
		[ExtensionAttribute2]
		public static MemberTypes MemberType(MemberInfo memberInfo)
		{
			return memberInfo.MemberType;
		}

		// Token: 0x06000DDE RID: 3550
		// RVA: 0x0000E8BB File Offset: 0x0000CABB
		[ExtensionAttribute2]
		public static MethodInfo Method(Delegate d)
		{
			return d.Method;
		}
	}
}
