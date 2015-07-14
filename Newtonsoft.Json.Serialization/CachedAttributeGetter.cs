using Newtonsoft.Json.Utilities;
using System;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000129 RID: 297
	internal static class CachedAttributeGetter<T> where T : Attribute
	{
		// Token: 0x04000529 RID: 1321
		private static readonly ThreadSafeStore<object, T> TypeAttributeCache = new ThreadSafeStore<object, T>(new Func<object, T>(JsonTypeReflector.GetAttribute<T>));

		// Token: 0x06000C5D RID: 3165
		// RVA: 0x0000D679 File Offset: 0x0000B879
		public static T GetAttribute(object type)
		{
			return CachedAttributeGetter<T>.TypeAttributeCache.Get(type);
		}
	}
}
