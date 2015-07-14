using System;

namespace Newtonsoft.Json
{
	// Token: 0x020000B5 RID: 181
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Parameter, AllowMultiple = false)]
	public sealed class JsonConverterAttribute : Attribute
	{
		// Token: 0x040002D5 RID: 725
		private readonly Type _converterType;

		// Token: 0x170000CD RID: 205
		public object[] ConverterParameters
		{
			// Token: 0x060005EA RID: 1514
			// RVA: 0x00009668 File Offset: 0x00007868
			get;
			// Token: 0x060005EB RID: 1515
			// RVA: 0x00009670 File Offset: 0x00007870
			private set;
		}

		// Token: 0x170000CC RID: 204
		public Type ConverterType
		{
			// Token: 0x060005E9 RID: 1513
			// RVA: 0x00009660 File Offset: 0x00007860
			get
			{
				return this._converterType;
			}
		}

		// Token: 0x060005EC RID: 1516
		// RVA: 0x00009679 File Offset: 0x00007879
		public JsonConverterAttribute(Type converterType)
		{
			if (converterType == null)
			{
				throw new ArgumentNullException("converterType");
			}
			this._converterType = converterType;
		}

		// Token: 0x060005ED RID: 1517
		// RVA: 0x00009696 File Offset: 0x00007896
		public JsonConverterAttribute(Type converterType, params object[] converterParameters) : this(converterType)
		{
			this.ConverterParameters = converterParameters;
		}
	}
}
