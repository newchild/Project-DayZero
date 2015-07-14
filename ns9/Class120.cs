using System;
using System.Collections.Generic;
using System.Globalization;

namespace ns9
{
	// Token: 0x020001BE RID: 446
	internal sealed class Class120 : IServiceProvider
	{
		// Token: 0x04000C00 RID: 3072
		private Dictionary<Type, object> dictionary_0 = new Dictionary<Type, object>();

		// Token: 0x06000FA3 RID: 4003
		// RVA: 0x0000F67B File Offset: 0x0000D87B
		public object GetService(Type serviceType)
		{
			if (serviceType == null)
			{
				throw new ArgumentNullException(Class127.smethod_19());
			}
			if (this.dictionary_0.ContainsKey(serviceType))
			{
				return this.dictionary_0[serviceType];
			}
			return null;
		}

		// Token: 0x06000FA2 RID: 4002
		// RVA: 0x00053E58 File Offset: 0x00052058
		public void method_0(Type type_0, object object_0)
		{
			if (type_0 == null)
			{
				throw new ArgumentNullException(Class127.smethod_19());
			}
			if (object_0 == null)
			{
				throw new ArgumentNullException(Class127.smethod_18());
			}
			if (this.dictionary_0.ContainsKey(type_0))
			{
				throw new ArgumentException(Class127.smethod_16(), "type");
			}
			if (!type_0.IsAssignableFrom(object_0.GetType()))
			{
				throw new ArgumentException(string.Format(CultureInfo.CurrentUICulture, Class127.smethod_17(), new object[]
				{
					object_0.GetType().FullName,
					type_0.GetType().FullName
				}));
			}
			this.dictionary_0.Add(type_0, object_0);
		}

		// Token: 0x06000FA4 RID: 4004
		// RVA: 0x0000F6A7 File Offset: 0x0000D8A7
		public void method_1(Type type_0)
		{
			if (type_0 == null)
			{
				throw new ArgumentNullException(Class127.smethod_19());
			}
			this.dictionary_0.Remove(type_0);
		}
	}
}
