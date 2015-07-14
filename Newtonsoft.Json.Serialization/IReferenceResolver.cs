using System;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000B0 RID: 176
	public interface IReferenceResolver
	{
		// Token: 0x060005DD RID: 1501
		void AddReference(object context, string reference, object value);

		// Token: 0x060005DB RID: 1499
		string GetReference(object context, object value);

		// Token: 0x060005DC RID: 1500
		bool IsReferenced(object context, object value);

		// Token: 0x060005DA RID: 1498
		object ResolveReference(object context, string reference);
	}
}
