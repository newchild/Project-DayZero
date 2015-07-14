using Newtonsoft.Json.Utilities;
using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200011E RID: 286
	public sealed class JsonObjectContract : JsonContainerContract
	{
		// Token: 0x040004F9 RID: 1273
		private bool? _hasRequiredOrDefaultValueProperties;

		// Token: 0x040004FB RID: 1275
		private ConstructorInfo _overrideConstructor;

		// Token: 0x040004FC RID: 1276
		private ObjectConstructor<object> _overrideCreator;

		// Token: 0x040004FA RID: 1274
		private ConstructorInfo _parametrizedConstructor;

		// Token: 0x040004FD RID: 1277
		private ObjectConstructor<object> _parametrizedCreator;

		// Token: 0x1700022B RID: 555
		[Obsolete("ConstructorParameters is obsolete. Use CreatorParameters instead.")]
		public JsonPropertyCollection ConstructorParameters
		{
			// Token: 0x06000B9C RID: 2972
			// RVA: 0x0000CF39 File Offset: 0x0000B139
			get
			{
				return this.CreatorParameters;
			}
		}

		// Token: 0x1700022C RID: 556
		public JsonPropertyCollection CreatorParameters
		{
			// Token: 0x06000B9D RID: 2973
			// RVA: 0x0000CF41 File Offset: 0x0000B141
			get;
			// Token: 0x06000B9E RID: 2974
			// RVA: 0x0000CF49 File Offset: 0x0000B149
			private set;
		}

		// Token: 0x17000232 RID: 562
		public ExtensionDataGetter ExtensionDataGetter
		{
			// Token: 0x06000BA8 RID: 2984
			// RVA: 0x0000CFD3 File Offset: 0x0000B1D3
			get;
			// Token: 0x06000BA9 RID: 2985
			// RVA: 0x0000CFDB File Offset: 0x0000B1DB
			set;
		}

		// Token: 0x17000231 RID: 561
		public ExtensionDataSetter ExtensionDataSetter
		{
			// Token: 0x06000BA6 RID: 2982
			// RVA: 0x0000CFC2 File Offset: 0x0000B1C2
			get;
			// Token: 0x06000BA7 RID: 2983
			// RVA: 0x0000CFCA File Offset: 0x0000B1CA
			set;
		}

		// Token: 0x17000233 RID: 563
		internal bool HasRequiredOrDefaultValueProperties
		{
			// Token: 0x06000BAA RID: 2986
			// RVA: 0x000433A4 File Offset: 0x000415A4
			get
			{
				if (!this._hasRequiredOrDefaultValueProperties.HasValue)
				{
					this._hasRequiredOrDefaultValueProperties = new bool?(false);
					if (this.ItemRequired.GetValueOrDefault(Required.Default) != Required.Default)
					{
						this._hasRequiredOrDefaultValueProperties = new bool?(true);
					}
					else
					{
						foreach (JsonProperty current in this.Properties)
						{
							if (current.Required != Required.Default || ((current.DefaultValueHandling & DefaultValueHandling.Populate) == DefaultValueHandling.Populate && current.Writable))
							{
								this._hasRequiredOrDefaultValueProperties = new bool?(true);
								break;
							}
						}
					}
				}
				return this._hasRequiredOrDefaultValueProperties.Value;
			}
		}

		// Token: 0x17000229 RID: 553
		public Required? ItemRequired
		{
			// Token: 0x06000B98 RID: 2968
			// RVA: 0x0000CF17 File Offset: 0x0000B117
			get;
			// Token: 0x06000B99 RID: 2969
			// RVA: 0x0000CF1F File Offset: 0x0000B11F
			set;
		}

		// Token: 0x17000228 RID: 552
		public MemberSerialization MemberSerialization
		{
			// Token: 0x06000B96 RID: 2966
			// RVA: 0x0000CF06 File Offset: 0x0000B106
			get;
			// Token: 0x06000B97 RID: 2967
			// RVA: 0x0000CF0E File Offset: 0x0000B10E
			set;
		}

		// Token: 0x1700022D RID: 557
		[Obsolete("OverrideConstructor is obsolete. Use OverrideCreator instead.")]
		public ConstructorInfo OverrideConstructor
		{
			// Token: 0x06000B9F RID: 2975
			// RVA: 0x0000CF52 File Offset: 0x0000B152
			get
			{
				return this._overrideConstructor;
			}
			// Token: 0x06000BA0 RID: 2976
			// RVA: 0x0000CF5A File Offset: 0x0000B15A
			set
			{
				this._overrideConstructor = value;
				this._overrideCreator = ((value != null) ? JsonTypeReflector.ReflectionDelegateFactory.CreateParametrizedConstructor(value) : null);
			}
		}

		// Token: 0x1700022F RID: 559
		public ObjectConstructor<object> OverrideCreator
		{
			// Token: 0x06000BA3 RID: 2979
			// RVA: 0x0000CFA2 File Offset: 0x0000B1A2
			get
			{
				return this._overrideCreator;
			}
			// Token: 0x06000BA4 RID: 2980
			// RVA: 0x0000CFAA File Offset: 0x0000B1AA
			set
			{
				this._overrideCreator = value;
				this._overrideConstructor = null;
			}
		}

		// Token: 0x1700022E RID: 558
		[Obsolete("ParametrizedConstructor is obsolete. Use OverrideCreator instead.")]
		public ConstructorInfo ParametrizedConstructor
		{
			// Token: 0x06000BA1 RID: 2977
			// RVA: 0x0000CF7A File Offset: 0x0000B17A
			get
			{
				return this._parametrizedConstructor;
			}
			// Token: 0x06000BA2 RID: 2978
			// RVA: 0x0000CF82 File Offset: 0x0000B182
			set
			{
				this._parametrizedConstructor = value;
				this._parametrizedCreator = ((value != null) ? JsonTypeReflector.ReflectionDelegateFactory.CreateParametrizedConstructor(value) : null);
			}
		}

		// Token: 0x17000230 RID: 560
		internal ObjectConstructor<object> ParametrizedCreator
		{
			// Token: 0x06000BA5 RID: 2981
			// RVA: 0x0000CFBA File Offset: 0x0000B1BA
			get
			{
				return this._parametrizedCreator;
			}
		}

		// Token: 0x1700022A RID: 554
		public JsonPropertyCollection Properties
		{
			// Token: 0x06000B9A RID: 2970
			// RVA: 0x0000CF28 File Offset: 0x0000B128
			get;
			// Token: 0x06000B9B RID: 2971
			// RVA: 0x0000CF30 File Offset: 0x0000B130
			private set;
		}

		// Token: 0x06000BAB RID: 2987
		// RVA: 0x0000CFE4 File Offset: 0x0000B1E4
		public JsonObjectContract(Type underlyingType) : base(underlyingType)
		{
			this.ContractType = JsonContractType.Object;
			this.Properties = new JsonPropertyCollection(base.UnderlyingType);
			this.CreatorParameters = new JsonPropertyCollection(base.UnderlyingType);
		}

		// Token: 0x06000BAC RID: 2988
		// RVA: 0x0000D016 File Offset: 0x0000B216
		internal object GetUninitializedObject()
		{
			if (!JsonTypeReflector.FullyTrusted)
			{
				throw new JsonException(StringUtils.FormatWith("Insufficient permissions. Creating an uninitialized '{0}' type requires full trust.", CultureInfo.InvariantCulture, this.NonNullableUnderlyingType));
			}
			return FormatterServices.GetUninitializedObject(this.NonNullableUnderlyingType);
		}
	}
}
