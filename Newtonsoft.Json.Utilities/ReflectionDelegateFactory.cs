using Newtonsoft.Json.Serialization;
using System;
using System.Globalization;
using System.Reflection;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200012E RID: 302
	internal abstract class ReflectionDelegateFactory
	{
		// Token: 0x06000C6F RID: 3183
		public abstract Func<T> CreateDefaultConstructor<T>(Type type);

		// Token: 0x06000C6B RID: 3179
		// RVA: 0x00048370 File Offset: 0x00046570
		public Func<T, object> CreateGet<T>(MemberInfo memberInfo)
		{
			PropertyInfo propertyInfo = memberInfo as PropertyInfo;
			if (propertyInfo != null)
			{
				return this.CreateGet<T>(propertyInfo);
			}
			FieldInfo fieldInfo = memberInfo as FieldInfo;
			if (fieldInfo == null)
			{
				throw new Exception(StringUtils.FormatWith("Could not create getter for {0}.", CultureInfo.InvariantCulture, memberInfo));
			}
			return this.CreateGet<T>(fieldInfo);
		}

		// Token: 0x06000C70 RID: 3184
		public abstract Func<T, object> CreateGet<T>(PropertyInfo propertyInfo);

		// Token: 0x06000C71 RID: 3185
		public abstract Func<T, object> CreateGet<T>(FieldInfo fieldInfo);

		// Token: 0x06000C6D RID: 3181
		public abstract MethodCall<T, object> CreateMethodCall<T>(MethodBase method);

		// Token: 0x06000C6E RID: 3182
		public abstract ObjectConstructor<object> CreateParametrizedConstructor(MethodBase method);

		// Token: 0x06000C6C RID: 3180
		// RVA: 0x000483B8 File Offset: 0x000465B8
		public Action<T, object> CreateSet<T>(MemberInfo memberInfo)
		{
			PropertyInfo propertyInfo = memberInfo as PropertyInfo;
			if (propertyInfo != null)
			{
				return this.CreateSet<T>(propertyInfo);
			}
			FieldInfo fieldInfo = memberInfo as FieldInfo;
			if (fieldInfo == null)
			{
				throw new Exception(StringUtils.FormatWith("Could not create setter for {0}.", CultureInfo.InvariantCulture, memberInfo));
			}
			return this.CreateSet<T>(fieldInfo);
		}

		// Token: 0x06000C72 RID: 3186
		public abstract Action<T, object> CreateSet<T>(FieldInfo fieldInfo);

		// Token: 0x06000C73 RID: 3187
		public abstract Action<T, object> CreateSet<T>(PropertyInfo propertyInfo);
	}
}
