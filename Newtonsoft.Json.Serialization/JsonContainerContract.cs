using Newtonsoft.Json.Utilities;
using System;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000062 RID: 98
	public class JsonContainerContract : JsonContract
	{
		// Token: 0x04000197 RID: 407
		private JsonContract _finalItemContract;

		// Token: 0x04000196 RID: 406
		private JsonContract _itemContract;

		// Token: 0x17000075 RID: 117
		internal JsonContract FinalItemContract
		{
			// Token: 0x060002B3 RID: 691
			// RVA: 0x00007901 File Offset: 0x00005B01
			get
			{
				return this._finalItemContract;
			}
		}

		// Token: 0x17000074 RID: 116
		internal JsonContract ItemContract
		{
			// Token: 0x060002B1 RID: 689
			// RVA: 0x000078BF File Offset: 0x00005ABF
			get
			{
				return this._itemContract;
			}
			// Token: 0x060002B2 RID: 690
			// RVA: 0x000078C7 File Offset: 0x00005AC7
			set
			{
				this._itemContract = value;
				if (this._itemContract != null)
				{
					this._finalItemContract = (TypeExtensions.IsSealed(this._itemContract.UnderlyingType) ? this._itemContract : null);
					return;
				}
				this._finalItemContract = null;
			}
		}

		// Token: 0x17000076 RID: 118
		public JsonConverter ItemConverter
		{
			// Token: 0x060002B4 RID: 692
			// RVA: 0x00007909 File Offset: 0x00005B09
			get;
			// Token: 0x060002B5 RID: 693
			// RVA: 0x00007911 File Offset: 0x00005B11
			set;
		}

		// Token: 0x17000077 RID: 119
		public bool? ItemIsReference
		{
			// Token: 0x060002B6 RID: 694
			// RVA: 0x0000791A File Offset: 0x00005B1A
			get;
			// Token: 0x060002B7 RID: 695
			// RVA: 0x00007922 File Offset: 0x00005B22
			set;
		}

		// Token: 0x17000078 RID: 120
		public ReferenceLoopHandling? ItemReferenceLoopHandling
		{
			// Token: 0x060002B8 RID: 696
			// RVA: 0x0000792B File Offset: 0x00005B2B
			get;
			// Token: 0x060002B9 RID: 697
			// RVA: 0x00007933 File Offset: 0x00005B33
			set;
		}

		// Token: 0x17000079 RID: 121
		public TypeNameHandling? ItemTypeNameHandling
		{
			// Token: 0x060002BA RID: 698
			// RVA: 0x0000793C File Offset: 0x00005B3C
			get;
			// Token: 0x060002BB RID: 699
			// RVA: 0x00007944 File Offset: 0x00005B44
			set;
		}

		// Token: 0x060002BC RID: 700
		// RVA: 0x0002F264 File Offset: 0x0002D464
		internal JsonContainerContract(Type underlyingType) : base(underlyingType)
		{
			JsonContainerAttribute cachedAttribute = JsonTypeReflector.GetCachedAttribute<JsonContainerAttribute>(underlyingType);
			if (cachedAttribute != null)
			{
				if (cachedAttribute.ItemConverterType != null)
				{
					this.ItemConverter = JsonTypeReflector.CreateJsonConverterInstance(cachedAttribute.ItemConverterType, cachedAttribute.ItemConverterParameters);
				}
				this.ItemIsReference = cachedAttribute._itemIsReference;
				this.ItemReferenceLoopHandling = cachedAttribute._itemReferenceLoopHandling;
				this.ItemTypeNameHandling = cachedAttribute._itemTypeNameHandling;
			}
		}
	}
}
