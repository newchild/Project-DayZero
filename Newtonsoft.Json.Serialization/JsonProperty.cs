using Newtonsoft.Json.Utilities;
using System;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000111 RID: 273
	public sealed class JsonProperty
	{
		// Token: 0x04000472 RID: 1138
		private object _defaultValue;

		// Token: 0x04000471 RID: 1137
		internal bool _hasExplicitDefaultValue;

		// Token: 0x04000473 RID: 1139
		private bool _hasGeneratedDefaultValue;

		// Token: 0x04000474 RID: 1140
		private string _propertyName;

		// Token: 0x04000476 RID: 1142
		private Type _propertyType;

		// Token: 0x04000470 RID: 1136
		internal Required? _required;

		// Token: 0x04000475 RID: 1141
		internal bool _skipPropertyNameEscape;

		// Token: 0x170001E6 RID: 486
		public IAttributeProvider AttributeProvider
		{
			// Token: 0x06000ADB RID: 2779
			// RVA: 0x0000C7DE File Offset: 0x0000A9DE
			get;
			// Token: 0x06000ADC RID: 2780
			// RVA: 0x0000C7E6 File Offset: 0x0000A9E6
			set;
		}

		// Token: 0x170001E8 RID: 488
		public JsonConverter Converter
		{
			// Token: 0x06000ADF RID: 2783
			// RVA: 0x0000C810 File Offset: 0x0000AA10
			get;
			// Token: 0x06000AE0 RID: 2784
			// RVA: 0x0000C818 File Offset: 0x0000AA18
			set;
		}

		// Token: 0x170001E2 RID: 482
		public Type DeclaringType
		{
			// Token: 0x06000AD3 RID: 2771
			// RVA: 0x0000C79A File Offset: 0x0000A99A
			get;
			// Token: 0x06000AD4 RID: 2772
			// RVA: 0x0000C7A2 File Offset: 0x0000A9A2
			set;
		}

		// Token: 0x170001EE RID: 494
		public object DefaultValue
		{
			// Token: 0x06000AEB RID: 2795
			// RVA: 0x0000C876 File Offset: 0x0000AA76
			get
			{
				if (!this._hasExplicitDefaultValue)
				{
					return null;
				}
				return this._defaultValue;
			}
			// Token: 0x06000AEC RID: 2796
			// RVA: 0x0000C888 File Offset: 0x0000AA88
			set
			{
				this._hasExplicitDefaultValue = true;
				this._defaultValue = value;
			}
		}

		// Token: 0x170001F2 RID: 498
		public DefaultValueHandling? DefaultValueHandling
		{
			// Token: 0x06000AF4 RID: 2804
			// RVA: 0x0000C902 File Offset: 0x0000AB02
			get;
			// Token: 0x06000AF5 RID: 2805
			// RVA: 0x0000C90A File Offset: 0x0000AB0A
			set;
		}

		// Token: 0x170001F7 RID: 503
		public Predicate<object> GetIsSpecified
		{
			// Token: 0x06000AFE RID: 2814
			// RVA: 0x0000C957 File Offset: 0x0000AB57
			get;
			// Token: 0x06000AFF RID: 2815
			// RVA: 0x0000C95F File Offset: 0x0000AB5F
			set;
		}

		// Token: 0x170001ED RID: 493
		public bool HasMemberAttribute
		{
			// Token: 0x06000AE9 RID: 2793
			// RVA: 0x0000C865 File Offset: 0x0000AA65
			get;
			// Token: 0x06000AEA RID: 2794
			// RVA: 0x0000C86D File Offset: 0x0000AA6D
			set;
		}

		// Token: 0x170001EA RID: 490
		public bool Ignored
		{
			// Token: 0x06000AE3 RID: 2787
			// RVA: 0x0000C832 File Offset: 0x0000AA32
			get;
			// Token: 0x06000AE4 RID: 2788
			// RVA: 0x0000C83A File Offset: 0x0000AA3A
			set;
		}

		// Token: 0x170001F0 RID: 496
		public bool? IsReference
		{
			// Token: 0x06000AF0 RID: 2800
			// RVA: 0x0000C8E0 File Offset: 0x0000AAE0
			get;
			// Token: 0x06000AF1 RID: 2801
			// RVA: 0x0000C8E8 File Offset: 0x0000AAE8
			set;
		}

		// Token: 0x170001F9 RID: 505
		public JsonConverter ItemConverter
		{
			// Token: 0x06000B03 RID: 2819
			// RVA: 0x0000C981 File Offset: 0x0000AB81
			get;
			// Token: 0x06000B04 RID: 2820
			// RVA: 0x0000C989 File Offset: 0x0000AB89
			set;
		}

		// Token: 0x170001FA RID: 506
		public bool? ItemIsReference
		{
			// Token: 0x06000B05 RID: 2821
			// RVA: 0x0000C992 File Offset: 0x0000AB92
			get;
			// Token: 0x06000B06 RID: 2822
			// RVA: 0x0000C99A File Offset: 0x0000AB9A
			set;
		}

		// Token: 0x170001FC RID: 508
		public ReferenceLoopHandling? ItemReferenceLoopHandling
		{
			// Token: 0x06000B09 RID: 2825
			// RVA: 0x0000C9B4 File Offset: 0x0000ABB4
			get;
			// Token: 0x06000B0A RID: 2826
			// RVA: 0x0000C9BC File Offset: 0x0000ABBC
			set;
		}

		// Token: 0x170001FB RID: 507
		public TypeNameHandling? ItemTypeNameHandling
		{
			// Token: 0x06000B07 RID: 2823
			// RVA: 0x0000C9A3 File Offset: 0x0000ABA3
			get;
			// Token: 0x06000B08 RID: 2824
			// RVA: 0x0000C9AB File Offset: 0x0000ABAB
			set;
		}

		// Token: 0x170001E9 RID: 489
		public JsonConverter MemberConverter
		{
			// Token: 0x06000AE1 RID: 2785
			// RVA: 0x0000C821 File Offset: 0x0000AA21
			get;
			// Token: 0x06000AE2 RID: 2786
			// RVA: 0x0000C829 File Offset: 0x0000AA29
			set;
		}

		// Token: 0x170001F1 RID: 497
		public NullValueHandling? NullValueHandling
		{
			// Token: 0x06000AF2 RID: 2802
			// RVA: 0x0000C8F1 File Offset: 0x0000AAF1
			get;
			// Token: 0x06000AF3 RID: 2803
			// RVA: 0x0000C8F9 File Offset: 0x0000AAF9
			set;
		}

		// Token: 0x170001F4 RID: 500
		public ObjectCreationHandling? ObjectCreationHandling
		{
			// Token: 0x06000AF8 RID: 2808
			// RVA: 0x0000C924 File Offset: 0x0000AB24
			get;
			// Token: 0x06000AF9 RID: 2809
			// RVA: 0x0000C92C File Offset: 0x0000AB2C
			set;
		}

		// Token: 0x170001E3 RID: 483
		public int? Order
		{
			// Token: 0x06000AD5 RID: 2773
			// RVA: 0x0000C7AB File Offset: 0x0000A9AB
			get;
			// Token: 0x06000AD6 RID: 2774
			// RVA: 0x0000C7B3 File Offset: 0x0000A9B3
			set;
		}

		// Token: 0x170001E0 RID: 480
		internal JsonContract PropertyContract
		{
			// Token: 0x06000ACF RID: 2767
			// RVA: 0x0000C75F File Offset: 0x0000A95F
			get;
			// Token: 0x06000AD0 RID: 2768
			// RVA: 0x0000C767 File Offset: 0x0000A967
			set;
		}

		// Token: 0x170001E1 RID: 481
		public string PropertyName
		{
			// Token: 0x06000AD1 RID: 2769
			// RVA: 0x0000C770 File Offset: 0x0000A970
			get
			{
				return this._propertyName;
			}
			// Token: 0x06000AD2 RID: 2770
			// RVA: 0x0000C778 File Offset: 0x0000A978
			set
			{
				this._propertyName = value;
				this._skipPropertyNameEscape = !JavaScriptUtils.ShouldEscapeJavaScriptString(this._propertyName, JavaScriptUtils.HtmlCharEscapeFlags);
			}
		}

		// Token: 0x170001E7 RID: 487
		public Type PropertyType
		{
			// Token: 0x06000ADD RID: 2781
			// RVA: 0x0000C7EF File Offset: 0x0000A9EF
			get
			{
				return this._propertyType;
			}
			// Token: 0x06000ADE RID: 2782
			// RVA: 0x0000C7F7 File Offset: 0x0000A9F7
			set
			{
				if (this._propertyType != value)
				{
					this._propertyType = value;
					this._hasGeneratedDefaultValue = false;
				}
			}
		}

		// Token: 0x170001EB RID: 491
		public bool Readable
		{
			// Token: 0x06000AE5 RID: 2789
			// RVA: 0x0000C843 File Offset: 0x0000AA43
			get;
			// Token: 0x06000AE6 RID: 2790
			// RVA: 0x0000C84B File Offset: 0x0000AA4B
			set;
		}

		// Token: 0x170001F3 RID: 499
		public ReferenceLoopHandling? ReferenceLoopHandling
		{
			// Token: 0x06000AF6 RID: 2806
			// RVA: 0x0000C913 File Offset: 0x0000AB13
			get;
			// Token: 0x06000AF7 RID: 2807
			// RVA: 0x0000C91B File Offset: 0x0000AB1B
			set;
		}

		// Token: 0x170001EF RID: 495
		public Required Required
		{
			// Token: 0x06000AEE RID: 2798
			// RVA: 0x00041998 File Offset: 0x0003FB98
			get
			{
				Required? required = this._required;
				if (!required.HasValue)
				{
					return Required.Default;
				}
				return required.GetValueOrDefault();
			}
			// Token: 0x06000AEF RID: 2799
			// RVA: 0x0000C8D2 File Offset: 0x0000AAD2
			set
			{
				this._required = new Required?(value);
			}
		}

		// Token: 0x170001F8 RID: 504
		public Action<object, object> SetIsSpecified
		{
			// Token: 0x06000B00 RID: 2816
			// RVA: 0x0000C968 File Offset: 0x0000AB68
			get;
			// Token: 0x06000B01 RID: 2817
			// RVA: 0x0000C970 File Offset: 0x0000AB70
			set;
		}

		// Token: 0x170001F6 RID: 502
		public Predicate<object> ShouldSerialize
		{
			// Token: 0x06000AFC RID: 2812
			// RVA: 0x0000C946 File Offset: 0x0000AB46
			get;
			// Token: 0x06000AFD RID: 2813
			// RVA: 0x0000C94E File Offset: 0x0000AB4E
			set;
		}

		// Token: 0x170001F5 RID: 501
		public TypeNameHandling? TypeNameHandling
		{
			// Token: 0x06000AFA RID: 2810
			// RVA: 0x0000C935 File Offset: 0x0000AB35
			get;
			// Token: 0x06000AFB RID: 2811
			// RVA: 0x0000C93D File Offset: 0x0000AB3D
			set;
		}

		// Token: 0x170001E4 RID: 484
		public string UnderlyingName
		{
			// Token: 0x06000AD7 RID: 2775
			// RVA: 0x0000C7BC File Offset: 0x0000A9BC
			get;
			// Token: 0x06000AD8 RID: 2776
			// RVA: 0x0000C7C4 File Offset: 0x0000A9C4
			set;
		}

		// Token: 0x170001E5 RID: 485
		public IValueProvider ValueProvider
		{
			// Token: 0x06000AD9 RID: 2777
			// RVA: 0x0000C7CD File Offset: 0x0000A9CD
			get;
			// Token: 0x06000ADA RID: 2778
			// RVA: 0x0000C7D5 File Offset: 0x0000A9D5
			set;
		}

		// Token: 0x170001EC RID: 492
		public bool Writable
		{
			// Token: 0x06000AE7 RID: 2791
			// RVA: 0x0000C854 File Offset: 0x0000AA54
			get;
			// Token: 0x06000AE8 RID: 2792
			// RVA: 0x0000C85C File Offset: 0x0000AA5C
			set;
		}

		// Token: 0x06000AED RID: 2797
		// RVA: 0x0000C898 File Offset: 0x0000AA98
		internal object GetResolvedDefaultValue()
		{
			if (this._propertyType == null)
			{
				return null;
			}
			if (!this._hasExplicitDefaultValue && !this._hasGeneratedDefaultValue)
			{
				this._defaultValue = ReflectionUtils.GetDefaultValue(this.PropertyType);
				this._hasGeneratedDefaultValue = true;
			}
			return this._defaultValue;
		}

		// Token: 0x06000B02 RID: 2818
		// RVA: 0x0000C979 File Offset: 0x0000AB79
		public override string ToString()
		{
			return this.PropertyName;
		}

		// Token: 0x06000B0B RID: 2827
		// RVA: 0x0000C9C5 File Offset: 0x0000ABC5
		internal void WritePropertyName(JsonWriter writer)
		{
			if (this._skipPropertyNameEscape)
			{
				writer.WritePropertyName(this.PropertyName, false);
				return;
			}
			writer.WritePropertyName(this.PropertyName);
		}
	}
}
