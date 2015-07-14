using System;

namespace Newtonsoft.Json
{
	// Token: 0x020000CF RID: 207
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
	public sealed class JsonPropertyAttribute : Attribute
	{
		// Token: 0x0400035B RID: 859
		internal DefaultValueHandling? _defaultValueHandling;

		// Token: 0x0400035F RID: 863
		internal bool? _isReference;

		// Token: 0x04000362 RID: 866
		internal bool? _itemIsReference;

		// Token: 0x04000363 RID: 867
		internal ReferenceLoopHandling? _itemReferenceLoopHandling;

		// Token: 0x04000364 RID: 868
		internal TypeNameHandling? _itemTypeNameHandling;

		// Token: 0x0400035A RID: 858
		internal NullValueHandling? _nullValueHandling;

		// Token: 0x0400035D RID: 861
		internal ObjectCreationHandling? _objectCreationHandling;

		// Token: 0x04000360 RID: 864
		internal int? _order;

		// Token: 0x0400035C RID: 860
		internal ReferenceLoopHandling? _referenceLoopHandling;

		// Token: 0x04000361 RID: 865
		internal Required? _required;

		// Token: 0x0400035E RID: 862
		internal TypeNameHandling? _typeNameHandling;

		// Token: 0x1700012E RID: 302
		public DefaultValueHandling DefaultValueHandling
		{
			// Token: 0x0600072F RID: 1839
			// RVA: 0x0003A8AC File Offset: 0x00038AAC
			get
			{
				DefaultValueHandling? defaultValueHandling = this._defaultValueHandling;
				if (!defaultValueHandling.HasValue)
				{
					return DefaultValueHandling.Include;
				}
				return defaultValueHandling.GetValueOrDefault();
			}
			// Token: 0x06000730 RID: 1840
			// RVA: 0x0000A1E3 File Offset: 0x000083E3
			set
			{
				this._defaultValueHandling = new DefaultValueHandling?(value);
			}
		}

		// Token: 0x17000132 RID: 306
		public bool IsReference
		{
			// Token: 0x06000737 RID: 1847
			// RVA: 0x0003A94C File Offset: 0x00038B4C
			get
			{
				return this._isReference ?? false;
			}
			// Token: 0x06000738 RID: 1848
			// RVA: 0x0000A21B File Offset: 0x0000841B
			set
			{
				this._isReference = new bool?(value);
			}
		}

		// Token: 0x1700012C RID: 300
		public object[] ItemConverterParameters
		{
			// Token: 0x0600072B RID: 1835
			// RVA: 0x0000A1C4 File Offset: 0x000083C4
			get;
			// Token: 0x0600072C RID: 1836
			// RVA: 0x0000A1CC File Offset: 0x000083CC
			set;
		}

		// Token: 0x1700012B RID: 299
		public Type ItemConverterType
		{
			// Token: 0x06000729 RID: 1833
			// RVA: 0x0000A1B3 File Offset: 0x000083B3
			get;
			// Token: 0x0600072A RID: 1834
			// RVA: 0x0000A1BB File Offset: 0x000083BB
			set;
		}

		// Token: 0x17000138 RID: 312
		public bool ItemIsReference
		{
			// Token: 0x06000743 RID: 1859
			// RVA: 0x0003AA14 File Offset: 0x00038C14
			get
			{
				return this._itemIsReference ?? false;
			}
			// Token: 0x06000744 RID: 1860
			// RVA: 0x0000A272 File Offset: 0x00008472
			set
			{
				this._itemIsReference = new bool?(value);
			}
		}

		// Token: 0x17000136 RID: 310
		public ReferenceLoopHandling ItemReferenceLoopHandling
		{
			// Token: 0x0600073F RID: 1855
			// RVA: 0x0003A9C4 File Offset: 0x00038BC4
			get
			{
				ReferenceLoopHandling? itemReferenceLoopHandling = this._itemReferenceLoopHandling;
				if (!itemReferenceLoopHandling.HasValue)
				{
					return ReferenceLoopHandling.Error;
				}
				return itemReferenceLoopHandling.GetValueOrDefault();
			}
			// Token: 0x06000740 RID: 1856
			// RVA: 0x0000A256 File Offset: 0x00008456
			set
			{
				this._itemReferenceLoopHandling = new ReferenceLoopHandling?(value);
			}
		}

		// Token: 0x17000137 RID: 311
		public TypeNameHandling ItemTypeNameHandling
		{
			// Token: 0x06000741 RID: 1857
			// RVA: 0x0003A9EC File Offset: 0x00038BEC
			get
			{
				TypeNameHandling? itemTypeNameHandling = this._itemTypeNameHandling;
				if (!itemTypeNameHandling.HasValue)
				{
					return TypeNameHandling.None;
				}
				return itemTypeNameHandling.GetValueOrDefault();
			}
			// Token: 0x06000742 RID: 1858
			// RVA: 0x0000A264 File Offset: 0x00008464
			set
			{
				this._itemTypeNameHandling = new TypeNameHandling?(value);
			}
		}

		// Token: 0x1700012D RID: 301
		public NullValueHandling NullValueHandling
		{
			// Token: 0x0600072D RID: 1837
			// RVA: 0x0003A884 File Offset: 0x00038A84
			get
			{
				NullValueHandling? nullValueHandling = this._nullValueHandling;
				if (!nullValueHandling.HasValue)
				{
					return NullValueHandling.Include;
				}
				return nullValueHandling.GetValueOrDefault();
			}
			// Token: 0x0600072E RID: 1838
			// RVA: 0x0000A1D5 File Offset: 0x000083D5
			set
			{
				this._nullValueHandling = new NullValueHandling?(value);
			}
		}

		// Token: 0x17000130 RID: 304
		public ObjectCreationHandling ObjectCreationHandling
		{
			// Token: 0x06000733 RID: 1843
			// RVA: 0x0003A8FC File Offset: 0x00038AFC
			get
			{
				ObjectCreationHandling? objectCreationHandling = this._objectCreationHandling;
				if (!objectCreationHandling.HasValue)
				{
					return ObjectCreationHandling.Auto;
				}
				return objectCreationHandling.GetValueOrDefault();
			}
			// Token: 0x06000734 RID: 1844
			// RVA: 0x0000A1FF File Offset: 0x000083FF
			set
			{
				this._objectCreationHandling = new ObjectCreationHandling?(value);
			}
		}

		// Token: 0x17000133 RID: 307
		public int Order
		{
			// Token: 0x06000739 RID: 1849
			// RVA: 0x0003A974 File Offset: 0x00038B74
			get
			{
				int? order = this._order;
				if (!order.HasValue)
				{
					return 0;
				}
				return order.GetValueOrDefault();
			}
			// Token: 0x0600073A RID: 1850
			// RVA: 0x0000A229 File Offset: 0x00008429
			set
			{
				this._order = new int?(value);
			}
		}

		// Token: 0x17000135 RID: 309
		public string PropertyName
		{
			// Token: 0x0600073D RID: 1853
			// RVA: 0x0000A245 File Offset: 0x00008445
			get;
			// Token: 0x0600073E RID: 1854
			// RVA: 0x0000A24D File Offset: 0x0000844D
			set;
		}

		// Token: 0x1700012F RID: 303
		public ReferenceLoopHandling ReferenceLoopHandling
		{
			// Token: 0x06000731 RID: 1841
			// RVA: 0x0003A8D4 File Offset: 0x00038AD4
			get
			{
				ReferenceLoopHandling? referenceLoopHandling = this._referenceLoopHandling;
				if (!referenceLoopHandling.HasValue)
				{
					return ReferenceLoopHandling.Error;
				}
				return referenceLoopHandling.GetValueOrDefault();
			}
			// Token: 0x06000732 RID: 1842
			// RVA: 0x0000A1F1 File Offset: 0x000083F1
			set
			{
				this._referenceLoopHandling = new ReferenceLoopHandling?(value);
			}
		}

		// Token: 0x17000134 RID: 308
		public Required Required
		{
			// Token: 0x0600073B RID: 1851
			// RVA: 0x0003A99C File Offset: 0x00038B9C
			get
			{
				Required? required = this._required;
				if (!required.HasValue)
				{
					return Required.Default;
				}
				return required.GetValueOrDefault();
			}
			// Token: 0x0600073C RID: 1852
			// RVA: 0x0000A237 File Offset: 0x00008437
			set
			{
				this._required = new Required?(value);
			}
		}

		// Token: 0x17000131 RID: 305
		public TypeNameHandling TypeNameHandling
		{
			// Token: 0x06000735 RID: 1845
			// RVA: 0x0003A924 File Offset: 0x00038B24
			get
			{
				TypeNameHandling? typeNameHandling = this._typeNameHandling;
				if (!typeNameHandling.HasValue)
				{
					return TypeNameHandling.None;
				}
				return typeNameHandling.GetValueOrDefault();
			}
			// Token: 0x06000736 RID: 1846
			// RVA: 0x0000A20D File Offset: 0x0000840D
			set
			{
				this._typeNameHandling = new TypeNameHandling?(value);
			}
		}

		// Token: 0x06000745 RID: 1861
		// RVA: 0x00006EDE File Offset: 0x000050DE
		public JsonPropertyAttribute()
		{
		}

		// Token: 0x06000746 RID: 1862
		// RVA: 0x0000A280 File Offset: 0x00008480
		public JsonPropertyAttribute(string propertyName)
		{
			this.PropertyName = propertyName;
		}
	}
}
