using Newtonsoft.Json.Serialization;
using System;
using System.Reflection;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000132 RID: 306
	internal sealed class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory
	{
		// Token: 0x04000533 RID: 1331
		private static readonly LateBoundReflectionDelegateFactory _instance = new LateBoundReflectionDelegateFactory();

		// Token: 0x17000253 RID: 595
		internal static ReflectionDelegateFactory Instance
		{
			// Token: 0x06000C8D RID: 3213
			// RVA: 0x0000D7DC File Offset: 0x0000B9DC
			get
			{
				return LateBoundReflectionDelegateFactory._instance;
			}
		}

		// Token: 0x06000C90 RID: 3216
		// RVA: 0x00048C7C File Offset: 0x00046E7C
		public override Func<T> CreateDefaultConstructor<T>(Type type)
		{
			ValidationUtils.ArgumentNotNull(type, "type");
			if (TypeExtensions.IsValueType(type))
			{
				return () => (T)((object)Activator.CreateInstance(type));
			}
			ConstructorInfo constructorInfo = ReflectionUtils.GetDefaultConstructor(type, true);
			return () => (T)((object)constructorInfo.Invoke(null));
		}

		// Token: 0x06000C91 RID: 3217
		// RVA: 0x00048CE0 File Offset: 0x00046EE0
		public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo)
		{
			ValidationUtils.ArgumentNotNull(propertyInfo, "propertyInfo");
			return (T o) => propertyInfo.GetValue(o, null);
		}

		// Token: 0x06000C92 RID: 3218
		// RVA: 0x00048D18 File Offset: 0x00046F18
		public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo)
		{
			ValidationUtils.ArgumentNotNull(fieldInfo, "fieldInfo");
			return (T o) => fieldInfo.GetValue(o);
		}

		// Token: 0x06000C8F RID: 3215
		// RVA: 0x00048C20 File Offset: 0x00046E20
		public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method)
		{
			ValidationUtils.ArgumentNotNull(method, "method");
			ConstructorInfo c = method as ConstructorInfo;
			if (c != null)
			{
				return (T o, object[] a) => c.Invoke(a);
			}
			return (T o, object[] a) => method.Invoke(o, a);
		}

		// Token: 0x06000C8E RID: 3214
		// RVA: 0x00048BCC File Offset: 0x00046DCC
		public override ObjectConstructor<object> CreateParametrizedConstructor(MethodBase method)
		{
			ValidationUtils.ArgumentNotNull(method, "method");
			ConstructorInfo constructorInfo = method as ConstructorInfo;
			if (constructorInfo != null)
			{
				return new ObjectConstructor<object>(constructorInfo.Invoke);
			}
			return (object[] a) => method.Invoke(null, a);
		}

		// Token: 0x06000C93 RID: 3219
		// RVA: 0x00048D50 File Offset: 0x00046F50
		public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo)
		{
			ValidationUtils.ArgumentNotNull(fieldInfo, "fieldInfo");
			return delegate(T o, object v)
			{
				fieldInfo.SetValue(o, v);
			};
		}

		// Token: 0x06000C94 RID: 3220
		// RVA: 0x00048D88 File Offset: 0x00046F88
		public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo)
		{
			ValidationUtils.ArgumentNotNull(propertyInfo, "propertyInfo");
			return delegate(T o, object v)
			{
				propertyInfo.SetValue(o, v, null);
			};
		}
	}
}
