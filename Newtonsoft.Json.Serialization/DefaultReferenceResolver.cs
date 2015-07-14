using Newtonsoft.Json.Utilities;
using System;
using System.Globalization;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000B1 RID: 177
	internal sealed class DefaultReferenceResolver : IReferenceResolver
	{
		// Token: 0x040002C9 RID: 713
		private int _referenceCount;

		// Token: 0x060005E1 RID: 1505
		// RVA: 0x00009630 File Offset: 0x00007830
		public void AddReference(object context, string reference, object value)
		{
			this.GetMappings(context).Set(reference, value);
		}

		// Token: 0x060005DE RID: 1502
		// RVA: 0x000359FC File Offset: 0x00033BFC
		private BidirectionalDictionary<string, object> GetMappings(object context)
		{
			JsonSerializerInternalBase jsonSerializerInternalBase;
			if (context is JsonSerializerInternalBase)
			{
				jsonSerializerInternalBase = (JsonSerializerInternalBase)context;
			}
			else
			{
				if (!(context is JsonSerializerProxy))
				{
					throw new JsonException("The DefaultReferenceResolver can only be used internally.");
				}
				jsonSerializerInternalBase = ((JsonSerializerProxy)context).GetInternalSerializer();
			}
			return jsonSerializerInternalBase.DefaultReferenceMappings;
		}

		// Token: 0x060005E0 RID: 1504
		// RVA: 0x00035A64 File Offset: 0x00033C64
		public string GetReference(object context, object value)
		{
			BidirectionalDictionary<string, object> mappings = this.GetMappings(context);
			string text;
			if (!mappings.TryGetBySecond(value, out text))
			{
				this._referenceCount++;
				text = this._referenceCount.ToString(CultureInfo.InvariantCulture);
				mappings.Set(text, value);
			}
			return text;
		}

		// Token: 0x060005E2 RID: 1506
		// RVA: 0x00035AAC File Offset: 0x00033CAC
		public bool IsReferenced(object context, object value)
		{
			string text;
			return this.GetMappings(context).TryGetBySecond(value, out text);
		}

		// Token: 0x060005DF RID: 1503
		// RVA: 0x00035A44 File Offset: 0x00033C44
		public object ResolveReference(object context, string reference)
		{
			object result;
			this.GetMappings(context).TryGetByFirst(reference, out result);
			return result;
		}
	}
}
