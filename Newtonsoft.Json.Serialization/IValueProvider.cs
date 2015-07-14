using System;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000102 RID: 258
	public interface IValueProvider
	{
		// Token: 0x06000A71 RID: 2673
		object GetValue(object target);

		// Token: 0x06000A70 RID: 2672
		void SetValue(object target, object value);
	}
}
