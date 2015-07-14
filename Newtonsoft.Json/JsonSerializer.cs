using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

namespace Newtonsoft.Json
{
	// Token: 0x020000D7 RID: 215
	public class JsonSerializer
	{
		// Token: 0x0400038A RID: 906
		internal SerializationBinder _binder;

		// Token: 0x04000397 RID: 919
		private bool? _checkAdditionalContent;

		// Token: 0x04000385 RID: 901
		internal ConstructorHandling _constructorHandling;

		// Token: 0x0400038B RID: 907
		internal StreamingContext _context;

		// Token: 0x04000388 RID: 904
		internal IContractResolver _contractResolver;

		// Token: 0x04000387 RID: 903
		internal JsonConverterCollection _converters;

		// Token: 0x04000394 RID: 916
		private CultureInfo _culture;

		// Token: 0x0400038E RID: 910
		private DateFormatHandling? _dateFormatHandling;

		// Token: 0x04000398 RID: 920
		private string _dateFormatString;

		// Token: 0x04000399 RID: 921
		private bool _dateFormatStringSet;

		// Token: 0x04000390 RID: 912
		private DateParseHandling? _dateParseHandling;

		// Token: 0x0400038F RID: 911
		private DateTimeZoneHandling? _dateTimeZoneHandling;

		// Token: 0x04000384 RID: 900
		internal DefaultValueHandling _defaultValueHandling;

		// Token: 0x04000391 RID: 913
		private FloatFormatHandling? _floatFormatHandling;

		// Token: 0x04000392 RID: 914
		private FloatParseHandling? _floatParseHandling;

		// Token: 0x0400038D RID: 909
		private Formatting? _formatting;

		// Token: 0x04000395 RID: 917
		private int? _maxDepth;

		// Token: 0x04000396 RID: 918
		private bool _maxDepthSet;

		// Token: 0x04000386 RID: 902
		internal MetadataPropertyHandling _metadataPropertyHandling;

		// Token: 0x04000381 RID: 897
		internal MissingMemberHandling _missingMemberHandling;

		// Token: 0x04000383 RID: 899
		internal NullValueHandling _nullValueHandling;

		// Token: 0x04000382 RID: 898
		internal ObjectCreationHandling _objectCreationHandling;

		// Token: 0x0400037F RID: 895
		internal PreserveReferencesHandling _preserveReferencesHandling;

		// Token: 0x04000380 RID: 896
		internal ReferenceLoopHandling _referenceLoopHandling;

		// Token: 0x0400038C RID: 908
		private IReferenceResolver _referenceResolver;

		// Token: 0x04000393 RID: 915
		private StringEscapeHandling? _stringEscapeHandling;

		// Token: 0x04000389 RID: 905
		internal ITraceWriter _traceWriter;

		// Token: 0x0400037E RID: 894
		internal FormatterAssemblyStyle _typeNameAssemblyFormat;

		// Token: 0x0400037D RID: 893
		internal TypeNameHandling _typeNameHandling;

		public virtual event EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> Error;

		// Token: 0x17000144 RID: 324
		public virtual SerializationBinder Binder
		{
			// Token: 0x060007DF RID: 2015
			// RVA: 0x0000AAA3 File Offset: 0x00008CA3
			get
			{
				return this._binder;
			}
			// Token: 0x060007E0 RID: 2016
			// RVA: 0x0000AAAB File Offset: 0x00008CAB
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value", "Serialization binder cannot be null.");
				}
				this._binder = value;
			}
		}

		// Token: 0x1700015D RID: 349
		public virtual bool CheckAdditionalContent
		{
			// Token: 0x06000810 RID: 2064
			// RVA: 0x0003B64C File Offset: 0x0003984C
			get
			{
				return this._checkAdditionalContent ?? false;
			}
			// Token: 0x06000811 RID: 2065
			// RVA: 0x0000AD2B File Offset: 0x00008F2B
			set
			{
				this._checkAdditionalContent = new bool?(value);
			}
		}

		// Token: 0x1700014E RID: 334
		public virtual ConstructorHandling ConstructorHandling
		{
			// Token: 0x060007F3 RID: 2035
			// RVA: 0x0000ABF8 File Offset: 0x00008DF8
			get
			{
				return this._constructorHandling;
			}
			// Token: 0x060007F4 RID: 2036
			// RVA: 0x0000AC00 File Offset: 0x00008E00
			set
			{
				if (value < ConstructorHandling.Default || value > ConstructorHandling.AllowNonPublicDefaultConstructor)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._constructorHandling = value;
			}
		}

		// Token: 0x17000152 RID: 338
		public virtual StreamingContext Context
		{
			// Token: 0x060007FA RID: 2042
			// RVA: 0x0000AC75 File Offset: 0x00008E75
			get
			{
				return this._context;
			}
			// Token: 0x060007FB RID: 2043
			// RVA: 0x0000AC7D File Offset: 0x00008E7D
			set
			{
				this._context = value;
			}
		}

		// Token: 0x17000151 RID: 337
		public virtual IContractResolver ContractResolver
		{
			// Token: 0x060007F8 RID: 2040
			// RVA: 0x0000AC5B File Offset: 0x00008E5B
			get
			{
				return this._contractResolver;
			}
			// Token: 0x060007F9 RID: 2041
			// RVA: 0x0000AC63 File Offset: 0x00008E63
			set
			{
				this._contractResolver = (value ?? DefaultContractResolver.Instance);
			}
		}

		// Token: 0x17000150 RID: 336
		public virtual JsonConverterCollection Converters
		{
			// Token: 0x060007F7 RID: 2039
			// RVA: 0x0000AC40 File Offset: 0x00008E40
			get
			{
				if (this._converters == null)
				{
					this._converters = new JsonConverterCollection();
				}
				return this._converters;
			}
		}

		// Token: 0x1700015B RID: 347
		public virtual CultureInfo Culture
		{
			// Token: 0x0600080C RID: 2060
			// RVA: 0x0000AD09 File Offset: 0x00008F09
			get
			{
				return this._culture ?? JsonSerializerSettings.DefaultCulture;
			}
			// Token: 0x0600080D RID: 2061
			// RVA: 0x0000AD1A File Offset: 0x00008F1A
			set
			{
				this._culture = value;
			}
		}

		// Token: 0x17000154 RID: 340
		public virtual DateFormatHandling DateFormatHandling
		{
			// Token: 0x060007FE RID: 2046
			// RVA: 0x0003B518 File Offset: 0x00039718
			get
			{
				DateFormatHandling? dateFormatHandling = this._dateFormatHandling;
				if (!dateFormatHandling.HasValue)
				{
					return DateFormatHandling.IsoDateFormat;
				}
				return dateFormatHandling.GetValueOrDefault();
			}
			// Token: 0x060007FF RID: 2047
			// RVA: 0x0000AC94 File Offset: 0x00008E94
			set
			{
				this._dateFormatHandling = new DateFormatHandling?(value);
			}
		}

		// Token: 0x1700015A RID: 346
		public virtual string DateFormatString
		{
			// Token: 0x0600080A RID: 2058
			// RVA: 0x0000ACE8 File Offset: 0x00008EE8
			get
			{
				return this._dateFormatString ?? "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";
			}
			// Token: 0x0600080B RID: 2059
			// RVA: 0x0000ACF9 File Offset: 0x00008EF9
			set
			{
				this._dateFormatString = value;
				this._dateFormatStringSet = true;
			}
		}

		// Token: 0x17000156 RID: 342
		public virtual DateParseHandling DateParseHandling
		{
			// Token: 0x06000802 RID: 2050
			// RVA: 0x0003B568 File Offset: 0x00039768
			get
			{
				DateParseHandling? dateParseHandling = this._dateParseHandling;
				if (!dateParseHandling.HasValue)
				{
					return DateParseHandling.DateTime;
				}
				return dateParseHandling.GetValueOrDefault();
			}
			// Token: 0x06000803 RID: 2051
			// RVA: 0x0000ACB0 File Offset: 0x00008EB0
			set
			{
				this._dateParseHandling = new DateParseHandling?(value);
			}
		}

		// Token: 0x17000155 RID: 341
		public virtual DateTimeZoneHandling DateTimeZoneHandling
		{
			// Token: 0x06000800 RID: 2048
			// RVA: 0x0003B540 File Offset: 0x00039740
			get
			{
				DateTimeZoneHandling? dateTimeZoneHandling = this._dateTimeZoneHandling;
				if (!dateTimeZoneHandling.HasValue)
				{
					return DateTimeZoneHandling.RoundtripKind;
				}
				return dateTimeZoneHandling.GetValueOrDefault();
			}
			// Token: 0x06000801 RID: 2049
			// RVA: 0x0000ACA2 File Offset: 0x00008EA2
			set
			{
				this._dateTimeZoneHandling = new DateTimeZoneHandling?(value);
			}
		}

		// Token: 0x1700014C RID: 332
		public virtual DefaultValueHandling DefaultValueHandling
		{
			// Token: 0x060007EF RID: 2031
			// RVA: 0x0000ABB0 File Offset: 0x00008DB0
			get
			{
				return this._defaultValueHandling;
			}
			// Token: 0x060007F0 RID: 2032
			// RVA: 0x0000ABB8 File Offset: 0x00008DB8
			set
			{
				if (value < DefaultValueHandling.Include || value > DefaultValueHandling.IgnoreAndPopulate)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._defaultValueHandling = value;
			}
		}

		// Token: 0x17000158 RID: 344
		public virtual FloatFormatHandling FloatFormatHandling
		{
			// Token: 0x06000806 RID: 2054
			// RVA: 0x0003B5B8 File Offset: 0x000397B8
			get
			{
				FloatFormatHandling? floatFormatHandling = this._floatFormatHandling;
				if (!floatFormatHandling.HasValue)
				{
					return FloatFormatHandling.String;
				}
				return floatFormatHandling.GetValueOrDefault();
			}
			// Token: 0x06000807 RID: 2055
			// RVA: 0x0000ACCC File Offset: 0x00008ECC
			set
			{
				this._floatFormatHandling = new FloatFormatHandling?(value);
			}
		}

		// Token: 0x17000157 RID: 343
		public virtual FloatParseHandling FloatParseHandling
		{
			// Token: 0x06000804 RID: 2052
			// RVA: 0x0003B590 File Offset: 0x00039790
			get
			{
				FloatParseHandling? floatParseHandling = this._floatParseHandling;
				if (!floatParseHandling.HasValue)
				{
					return FloatParseHandling.Double;
				}
				return floatParseHandling.GetValueOrDefault();
			}
			// Token: 0x06000805 RID: 2053
			// RVA: 0x0000ACBE File Offset: 0x00008EBE
			set
			{
				this._floatParseHandling = new FloatParseHandling?(value);
			}
		}

		// Token: 0x17000153 RID: 339
		public virtual Formatting Formatting
		{
			// Token: 0x060007FC RID: 2044
			// RVA: 0x0003B4F0 File Offset: 0x000396F0
			get
			{
				Formatting? formatting = this._formatting;
				if (!formatting.HasValue)
				{
					return Formatting.None;
				}
				return formatting.GetValueOrDefault();
			}
			// Token: 0x060007FD RID: 2045
			// RVA: 0x0000AC86 File Offset: 0x00008E86
			set
			{
				this._formatting = new Formatting?(value);
			}
		}

		// Token: 0x1700015C RID: 348
		public virtual int? MaxDepth
		{
			// Token: 0x0600080E RID: 2062
			// RVA: 0x0000AD23 File Offset: 0x00008F23
			get
			{
				return this._maxDepth;
			}
			// Token: 0x0600080F RID: 2063
			// RVA: 0x0003B608 File Offset: 0x00039808
			set
			{
				if (value <= 0)
				{
					throw new ArgumentException("Value must be positive.", "value");
				}
				this._maxDepth = value;
				this._maxDepthSet = true;
			}
		}

		// Token: 0x1700014F RID: 335
		public virtual MetadataPropertyHandling MetadataPropertyHandling
		{
			// Token: 0x060007F5 RID: 2037
			// RVA: 0x0000AC1C File Offset: 0x00008E1C
			get
			{
				return this._metadataPropertyHandling;
			}
			// Token: 0x060007F6 RID: 2038
			// RVA: 0x0000AC24 File Offset: 0x00008E24
			set
			{
				if (value < MetadataPropertyHandling.Default || value > MetadataPropertyHandling.Ignore)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._metadataPropertyHandling = value;
			}
		}

		// Token: 0x1700014A RID: 330
		public virtual MissingMemberHandling MissingMemberHandling
		{
			// Token: 0x060007EB RID: 2027
			// RVA: 0x0000AB68 File Offset: 0x00008D68
			get
			{
				return this._missingMemberHandling;
			}
			// Token: 0x060007EC RID: 2028
			// RVA: 0x0000AB70 File Offset: 0x00008D70
			set
			{
				if (value < MissingMemberHandling.Ignore || value > MissingMemberHandling.Error)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._missingMemberHandling = value;
			}
		}

		// Token: 0x1700014B RID: 331
		public virtual NullValueHandling NullValueHandling
		{
			// Token: 0x060007ED RID: 2029
			// RVA: 0x0000AB8C File Offset: 0x00008D8C
			get
			{
				return this._nullValueHandling;
			}
			// Token: 0x060007EE RID: 2030
			// RVA: 0x0000AB94 File Offset: 0x00008D94
			set
			{
				if (value < NullValueHandling.Include || value > NullValueHandling.Ignore)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._nullValueHandling = value;
			}
		}

		// Token: 0x1700014D RID: 333
		public virtual ObjectCreationHandling ObjectCreationHandling
		{
			// Token: 0x060007F1 RID: 2033
			// RVA: 0x0000ABD4 File Offset: 0x00008DD4
			get
			{
				return this._objectCreationHandling;
			}
			// Token: 0x060007F2 RID: 2034
			// RVA: 0x0000ABDC File Offset: 0x00008DDC
			set
			{
				if (value < ObjectCreationHandling.Auto || value > ObjectCreationHandling.Replace)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._objectCreationHandling = value;
			}
		}

		// Token: 0x17000148 RID: 328
		public virtual PreserveReferencesHandling PreserveReferencesHandling
		{
			// Token: 0x060007E7 RID: 2023
			// RVA: 0x0000AB20 File Offset: 0x00008D20
			get
			{
				return this._preserveReferencesHandling;
			}
			// Token: 0x060007E8 RID: 2024
			// RVA: 0x0000AB28 File Offset: 0x00008D28
			set
			{
				if (value < PreserveReferencesHandling.None || value > PreserveReferencesHandling.All)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._preserveReferencesHandling = value;
			}
		}

		// Token: 0x17000149 RID: 329
		public virtual ReferenceLoopHandling ReferenceLoopHandling
		{
			// Token: 0x060007E9 RID: 2025
			// RVA: 0x0000AB44 File Offset: 0x00008D44
			get
			{
				return this._referenceLoopHandling;
			}
			// Token: 0x060007EA RID: 2026
			// RVA: 0x0000AB4C File Offset: 0x00008D4C
			set
			{
				if (value < ReferenceLoopHandling.Error || value > ReferenceLoopHandling.Serialize)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._referenceLoopHandling = value;
			}
		}

		// Token: 0x17000143 RID: 323
		public virtual IReferenceResolver ReferenceResolver
		{
			// Token: 0x060007DD RID: 2013
			// RVA: 0x0000AA7F File Offset: 0x00008C7F
			get
			{
				return this.GetReferenceResolver();
			}
			// Token: 0x060007DE RID: 2014
			// RVA: 0x0000AA87 File Offset: 0x00008C87
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value", "Reference resolver cannot be null.");
				}
				this._referenceResolver = value;
			}
		}

		// Token: 0x17000159 RID: 345
		public virtual StringEscapeHandling StringEscapeHandling
		{
			// Token: 0x06000808 RID: 2056
			// RVA: 0x0003B5E0 File Offset: 0x000397E0
			get
			{
				StringEscapeHandling? stringEscapeHandling = this._stringEscapeHandling;
				if (!stringEscapeHandling.HasValue)
				{
					return StringEscapeHandling.Default;
				}
				return stringEscapeHandling.GetValueOrDefault();
			}
			// Token: 0x06000809 RID: 2057
			// RVA: 0x0000ACDA File Offset: 0x00008EDA
			set
			{
				this._stringEscapeHandling = new StringEscapeHandling?(value);
			}
		}

		// Token: 0x17000145 RID: 325
		public virtual ITraceWriter TraceWriter
		{
			// Token: 0x060007E1 RID: 2017
			// RVA: 0x0000AAC7 File Offset: 0x00008CC7
			get
			{
				return this._traceWriter;
			}
			// Token: 0x060007E2 RID: 2018
			// RVA: 0x0000AACF File Offset: 0x00008CCF
			set
			{
				this._traceWriter = value;
			}
		}

		// Token: 0x17000147 RID: 327
		public virtual FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			// Token: 0x060007E5 RID: 2021
			// RVA: 0x0000AAFC File Offset: 0x00008CFC
			get
			{
				return this._typeNameAssemblyFormat;
			}
			// Token: 0x060007E6 RID: 2022
			// RVA: 0x0000AB04 File Offset: 0x00008D04
			set
			{
				if (value < FormatterAssemblyStyle.Simple || value > FormatterAssemblyStyle.Full)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._typeNameAssemblyFormat = value;
			}
		}

		// Token: 0x17000146 RID: 326
		public virtual TypeNameHandling TypeNameHandling
		{
			// Token: 0x060007E3 RID: 2019
			// RVA: 0x0000AAD8 File Offset: 0x00008CD8
			get
			{
				return this._typeNameHandling;
			}
			// Token: 0x060007E4 RID: 2020
			// RVA: 0x0000AAE0 File Offset: 0x00008CE0
			set
			{
				if (value < TypeNameHandling.None || value > TypeNameHandling.Auto)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._typeNameHandling = value;
			}
		}

		// Token: 0x06000813 RID: 2067
		// RVA: 0x0003B674 File Offset: 0x00039874
		public JsonSerializer()
		{
			this._referenceLoopHandling = ReferenceLoopHandling.Error;
			this._missingMemberHandling = MissingMemberHandling.Ignore;
			this._nullValueHandling = NullValueHandling.Include;
			this._defaultValueHandling = DefaultValueHandling.Include;
			this._objectCreationHandling = ObjectCreationHandling.Auto;
			this._preserveReferencesHandling = PreserveReferencesHandling.None;
			this._constructorHandling = ConstructorHandling.Default;
			this._typeNameHandling = TypeNameHandling.None;
			this._metadataPropertyHandling = MetadataPropertyHandling.Default;
			this._context = JsonSerializerSettings.DefaultContext;
			this._binder = DefaultSerializationBinder.Instance;
			this._culture = JsonSerializerSettings.DefaultCulture;
			this._contractResolver = DefaultContractResolver.Instance;
		}

		// Token: 0x06000818 RID: 2072
		// RVA: 0x0003B75C File Offset: 0x0003995C
		private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings)
		{
			if (!CollectionUtils.IsNullOrEmpty<JsonConverter>(settings.Converters))
			{
				for (int i = 0; i < settings.Converters.Count; i++)
				{
					serializer.Converters.Insert(i, settings.Converters[i]);
				}
			}
			if (settings._typeNameHandling.HasValue)
			{
				serializer.TypeNameHandling = settings.TypeNameHandling;
			}
			if (settings._metadataPropertyHandling.HasValue)
			{
				serializer.MetadataPropertyHandling = settings.MetadataPropertyHandling;
			}
			if (settings._typeNameAssemblyFormat.HasValue)
			{
				serializer.TypeNameAssemblyFormat = settings.TypeNameAssemblyFormat;
			}
			if (settings._preserveReferencesHandling.HasValue)
			{
				serializer.PreserveReferencesHandling = settings.PreserveReferencesHandling;
			}
			if (settings._referenceLoopHandling.HasValue)
			{
				serializer.ReferenceLoopHandling = settings.ReferenceLoopHandling;
			}
			if (settings._missingMemberHandling.HasValue)
			{
				serializer.MissingMemberHandling = settings.MissingMemberHandling;
			}
			if (settings._objectCreationHandling.HasValue)
			{
				serializer.ObjectCreationHandling = settings.ObjectCreationHandling;
			}
			if (settings._nullValueHandling.HasValue)
			{
				serializer.NullValueHandling = settings.NullValueHandling;
			}
			if (settings._defaultValueHandling.HasValue)
			{
				serializer.DefaultValueHandling = settings.DefaultValueHandling;
			}
			if (settings._constructorHandling.HasValue)
			{
				serializer.ConstructorHandling = settings.ConstructorHandling;
			}
			if (settings._context.HasValue)
			{
				serializer.Context = settings.Context;
			}
			if (settings._checkAdditionalContent.HasValue)
			{
				serializer._checkAdditionalContent = settings._checkAdditionalContent;
			}
			if (settings.Error != null)
			{
				serializer.Error += settings.Error;
			}
			if (settings.ContractResolver != null)
			{
				serializer.ContractResolver = settings.ContractResolver;
			}
			if (settings.ReferenceResolver != null)
			{
				serializer.ReferenceResolver = settings.ReferenceResolver;
			}
			if (settings.TraceWriter != null)
			{
				serializer.TraceWriter = settings.TraceWriter;
			}
			if (settings.Binder != null)
			{
				serializer.Binder = settings.Binder;
			}
			if (settings._formatting.HasValue)
			{
				serializer._formatting = settings._formatting;
			}
			if (settings._dateFormatHandling.HasValue)
			{
				serializer._dateFormatHandling = settings._dateFormatHandling;
			}
			if (settings._dateTimeZoneHandling.HasValue)
			{
				serializer._dateTimeZoneHandling = settings._dateTimeZoneHandling;
			}
			if (settings._dateParseHandling.HasValue)
			{
				serializer._dateParseHandling = settings._dateParseHandling;
			}
			if (settings._dateFormatStringSet)
			{
				serializer._dateFormatString = settings._dateFormatString;
				serializer._dateFormatStringSet = settings._dateFormatStringSet;
			}
			if (settings._floatFormatHandling.HasValue)
			{
				serializer._floatFormatHandling = settings._floatFormatHandling;
			}
			if (settings._floatParseHandling.HasValue)
			{
				serializer._floatParseHandling = settings._floatParseHandling;
			}
			if (settings._stringEscapeHandling.HasValue)
			{
				serializer._stringEscapeHandling = settings._stringEscapeHandling;
			}
			if (settings._culture != null)
			{
				serializer._culture = settings._culture;
			}
			if (settings._maxDepthSet)
			{
				serializer._maxDepth = settings._maxDepth;
				serializer._maxDepthSet = settings._maxDepthSet;
			}
		}

		// Token: 0x06000814 RID: 2068
		// RVA: 0x0000AD46 File Offset: 0x00008F46
		public static JsonSerializer Create()
		{
			return new JsonSerializer();
		}

		// Token: 0x06000815 RID: 2069
		// RVA: 0x0003B6F4 File Offset: 0x000398F4
		public static JsonSerializer Create(JsonSerializerSettings settings)
		{
			JsonSerializer jsonSerializer = JsonSerializer.Create();
			if (settings != null)
			{
				JsonSerializer.ApplySerializerSettings(jsonSerializer, settings);
			}
			return jsonSerializer;
		}

		// Token: 0x06000816 RID: 2070
		// RVA: 0x0003B714 File Offset: 0x00039914
		public static JsonSerializer CreateDefault()
		{
			Func<JsonSerializerSettings> defaultSettings = JsonConvert.DefaultSettings;
			JsonSerializerSettings settings = (defaultSettings != null) ? defaultSettings() : null;
			return JsonSerializer.Create(settings);
		}

		// Token: 0x06000817 RID: 2071
		// RVA: 0x0003B73C File Offset: 0x0003993C
		public static JsonSerializer CreateDefault(JsonSerializerSettings settings)
		{
			JsonSerializer jsonSerializer = JsonSerializer.CreateDefault();
			if (settings != null)
			{
				JsonSerializer.ApplySerializerSettings(jsonSerializer, settings);
			}
			return jsonSerializer;
		}

		// Token: 0x0600081C RID: 2076
		// RVA: 0x0000AD66 File Offset: 0x00008F66
		public object Deserialize(JsonReader reader)
		{
			return this.Deserialize(reader, null);
		}

		// Token: 0x0600081E RID: 2078
		// RVA: 0x0000AD7F File Offset: 0x00008F7F
		public T Deserialize<T>(JsonReader reader)
		{
			return (T)((object)this.Deserialize(reader, typeof(T)));
		}

		// Token: 0x0600081D RID: 2077
		// RVA: 0x0000AD70 File Offset: 0x00008F70
		public object Deserialize(TextReader reader, Type objectType)
		{
			return this.Deserialize(new JsonTextReader(reader), objectType);
		}

		// Token: 0x0600081F RID: 2079
		// RVA: 0x0000AD97 File Offset: 0x00008F97
		public object Deserialize(JsonReader reader, Type objectType)
		{
			return this.DeserializeInternal(reader, objectType);
		}

		// Token: 0x06000820 RID: 2080
		// RVA: 0x0003BADC File Offset: 0x00039CDC
		internal virtual object DeserializeInternal(JsonReader reader, Type objectType)
		{
			ValidationUtils.ArgumentNotNull(reader, "reader");
			CultureInfo previousCulture;
			DateTimeZoneHandling? previousDateTimeZoneHandling;
			DateParseHandling? previousDateParseHandling;
			FloatParseHandling? previousFloatParseHandling;
			int? previousMaxDepth;
			string previousDateFormatString;
			this.SetupReader(reader, out previousCulture, out previousDateTimeZoneHandling, out previousDateParseHandling, out previousFloatParseHandling, out previousMaxDepth, out previousDateFormatString);
			TraceJsonReader traceJsonReader = (this.TraceWriter == null || this.TraceWriter.LevelFilter < TraceLevel.Verbose) ? null : new TraceJsonReader(reader);
			JsonSerializerInternalReader jsonSerializerInternalReader = new JsonSerializerInternalReader(this);
			object result = jsonSerializerInternalReader.Deserialize(traceJsonReader ?? reader, objectType, this.CheckAdditionalContent);
			if (traceJsonReader != null)
			{
				this.TraceWriter.Trace(TraceLevel.Verbose, "Deserialized JSON: " + Environment.NewLine + traceJsonReader.GetJson(), null);
			}
			this.ResetReader(reader, previousCulture, previousDateTimeZoneHandling, previousDateParseHandling, previousFloatParseHandling, previousMaxDepth, previousDateFormatString);
			return result;
		}

		// Token: 0x06000829 RID: 2089
		// RVA: 0x0000ADF1 File Offset: 0x00008FF1
		internal JsonConverter GetMatchingConverter(Type type)
		{
			return JsonSerializer.GetMatchingConverter(this._converters, type);
		}

		// Token: 0x0600082A RID: 2090
		// RVA: 0x0003C170 File Offset: 0x0003A370
		internal static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, Type objectType)
		{
			if (converters != null)
			{
				for (int i = 0; i < converters.Count; i++)
				{
					JsonConverter jsonConverter = converters[i];
					if (jsonConverter.CanConvert(objectType))
					{
						return jsonConverter;
					}
				}
			}
			return null;
		}

		// Token: 0x06000828 RID: 2088
		// RVA: 0x0000ADD6 File Offset: 0x00008FD6
		internal IReferenceResolver GetReferenceResolver()
		{
			if (this._referenceResolver == null)
			{
				this._referenceResolver = new DefaultReferenceResolver();
			}
			return this._referenceResolver;
		}

		// Token: 0x06000812 RID: 2066
		// RVA: 0x0000AD39 File Offset: 0x00008F39
		internal bool IsCheckAdditionalContentSet()
		{
			return this._checkAdditionalContent.HasValue;
		}

		// Token: 0x0600082B RID: 2091
		// RVA: 0x0003C1A8 File Offset: 0x0003A3A8
		internal void OnError(Newtonsoft.Json.Serialization.ErrorEventArgs e)
		{
			EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> error = this.Error;
			if (error != null)
			{
				error(this, e);
			}
		}

		// Token: 0x06000819 RID: 2073
		// RVA: 0x0000AD4D File Offset: 0x00008F4D
		public void Populate(TextReader reader, object target)
		{
			this.Populate(new JsonTextReader(reader), target);
		}

		// Token: 0x0600081A RID: 2074
		// RVA: 0x0000AD5C File Offset: 0x00008F5C
		public void Populate(JsonReader reader, object target)
		{
			this.PopulateInternal(reader, target);
		}

		// Token: 0x0600081B RID: 2075
		// RVA: 0x0003BA38 File Offset: 0x00039C38
		internal virtual void PopulateInternal(JsonReader reader, object target)
		{
			ValidationUtils.ArgumentNotNull(reader, "reader");
			ValidationUtils.ArgumentNotNull(target, "target");
			CultureInfo previousCulture;
			DateTimeZoneHandling? previousDateTimeZoneHandling;
			DateParseHandling? previousDateParseHandling;
			FloatParseHandling? previousFloatParseHandling;
			int? previousMaxDepth;
			string previousDateFormatString;
			this.SetupReader(reader, out previousCulture, out previousDateTimeZoneHandling, out previousDateParseHandling, out previousFloatParseHandling, out previousMaxDepth, out previousDateFormatString);
			TraceJsonReader traceJsonReader = (this.TraceWriter == null || this.TraceWriter.LevelFilter < TraceLevel.Verbose) ? null : new TraceJsonReader(reader);
			JsonSerializerInternalReader jsonSerializerInternalReader = new JsonSerializerInternalReader(this);
			jsonSerializerInternalReader.Populate(traceJsonReader ?? reader, target);
			if (traceJsonReader != null)
			{
				this.TraceWriter.Trace(TraceLevel.Verbose, "Deserialized JSON: " + Environment.NewLine + traceJsonReader.GetJson(), null);
			}
			this.ResetReader(reader, previousCulture, previousDateTimeZoneHandling, previousDateParseHandling, previousFloatParseHandling, previousMaxDepth, previousDateFormatString);
		}

		// Token: 0x06000822 RID: 2082
		// RVA: 0x0003BDAC File Offset: 0x00039FAC
		private void ResetReader(JsonReader reader, CultureInfo previousCulture, DateTimeZoneHandling? previousDateTimeZoneHandling, DateParseHandling? previousDateParseHandling, FloatParseHandling? previousFloatParseHandling, int? previousMaxDepth, string previousDateFormatString)
		{
			if (previousCulture != null)
			{
				reader.Culture = previousCulture;
			}
			if (previousDateTimeZoneHandling.HasValue)
			{
				reader.DateTimeZoneHandling = previousDateTimeZoneHandling.Value;
			}
			if (previousDateParseHandling.HasValue)
			{
				reader.DateParseHandling = previousDateParseHandling.Value;
			}
			if (previousFloatParseHandling.HasValue)
			{
				reader.FloatParseHandling = previousFloatParseHandling.Value;
			}
			if (this._maxDepthSet)
			{
				reader.MaxDepth = previousMaxDepth;
			}
			if (this._dateFormatStringSet)
			{
				reader.DateFormatString = previousDateFormatString;
			}
			JsonTextReader jsonTextReader = reader as JsonTextReader;
			if (jsonTextReader != null)
			{
				jsonTextReader.NameTable = null;
			}
		}

		// Token: 0x06000823 RID: 2083
		// RVA: 0x0000ADA1 File Offset: 0x00008FA1
		public void Serialize(TextWriter textWriter, object value)
		{
			this.Serialize(new JsonTextWriter(textWriter), value);
		}

		// Token: 0x06000826 RID: 2086
		// RVA: 0x0000ADCB File Offset: 0x00008FCB
		public void Serialize(JsonWriter jsonWriter, object value)
		{
			this.SerializeInternal(jsonWriter, value, null);
		}

		// Token: 0x06000824 RID: 2084
		// RVA: 0x0000ADB0 File Offset: 0x00008FB0
		public void Serialize(JsonWriter jsonWriter, object value, Type objectType)
		{
			this.SerializeInternal(jsonWriter, value, objectType);
		}

		// Token: 0x06000825 RID: 2085
		// RVA: 0x0000ADBB File Offset: 0x00008FBB
		public void Serialize(TextWriter textWriter, object value, Type objectType)
		{
			this.Serialize(new JsonTextWriter(textWriter), value, objectType);
		}

		// Token: 0x06000827 RID: 2087
		// RVA: 0x0003BE38 File Offset: 0x0003A038
		internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType)
		{
			ValidationUtils.ArgumentNotNull(jsonWriter, "jsonWriter");
			Formatting? formatting = null;
			if (this._formatting.HasValue && jsonWriter.Formatting != this._formatting)
			{
				formatting = new Formatting?(jsonWriter.Formatting);
				jsonWriter.Formatting = this._formatting.Value;
			}
			DateFormatHandling? dateFormatHandling = null;
			if (this._dateFormatHandling.HasValue && jsonWriter.DateFormatHandling != this._dateFormatHandling)
			{
				dateFormatHandling = new DateFormatHandling?(jsonWriter.DateFormatHandling);
				jsonWriter.DateFormatHandling = this._dateFormatHandling.Value;
			}
			DateTimeZoneHandling? dateTimeZoneHandling = null;
			if (this._dateTimeZoneHandling.HasValue && jsonWriter.DateTimeZoneHandling != this._dateTimeZoneHandling)
			{
				dateTimeZoneHandling = new DateTimeZoneHandling?(jsonWriter.DateTimeZoneHandling);
				jsonWriter.DateTimeZoneHandling = this._dateTimeZoneHandling.Value;
			}
			FloatFormatHandling? floatFormatHandling = null;
			if (this._floatFormatHandling.HasValue && jsonWriter.FloatFormatHandling != this._floatFormatHandling)
			{
				floatFormatHandling = new FloatFormatHandling?(jsonWriter.FloatFormatHandling);
				jsonWriter.FloatFormatHandling = this._floatFormatHandling.Value;
			}
			StringEscapeHandling? stringEscapeHandling = null;
			if (this._stringEscapeHandling.HasValue && jsonWriter.StringEscapeHandling != this._stringEscapeHandling)
			{
				stringEscapeHandling = new StringEscapeHandling?(jsonWriter.StringEscapeHandling);
				jsonWriter.StringEscapeHandling = this._stringEscapeHandling.Value;
			}
			CultureInfo cultureInfo = null;
			if (this._culture != null && !this._culture.Equals(jsonWriter.Culture))
			{
				cultureInfo = jsonWriter.Culture;
				jsonWriter.Culture = this._culture;
			}
			string dateFormatString = null;
			if (this._dateFormatStringSet && jsonWriter.DateFormatString != this._dateFormatString)
			{
				dateFormatString = jsonWriter.DateFormatString;
				jsonWriter.DateFormatString = this._dateFormatString;
			}
			TraceJsonWriter traceJsonWriter = (this.TraceWriter == null || this.TraceWriter.LevelFilter < TraceLevel.Verbose) ? null : new TraceJsonWriter(jsonWriter);
			JsonSerializerInternalWriter jsonSerializerInternalWriter = new JsonSerializerInternalWriter(this);
			jsonSerializerInternalWriter.Serialize(traceJsonWriter ?? jsonWriter, value, objectType);
			if (traceJsonWriter != null)
			{
				this.TraceWriter.Trace(TraceLevel.Verbose, "Serialized JSON: " + Environment.NewLine + traceJsonWriter.GetJson(), null);
			}
			if (formatting.HasValue)
			{
				jsonWriter.Formatting = formatting.Value;
			}
			if (dateFormatHandling.HasValue)
			{
				jsonWriter.DateFormatHandling = dateFormatHandling.Value;
			}
			if (dateTimeZoneHandling.HasValue)
			{
				jsonWriter.DateTimeZoneHandling = dateTimeZoneHandling.Value;
			}
			if (floatFormatHandling.HasValue)
			{
				jsonWriter.FloatFormatHandling = floatFormatHandling.Value;
			}
			if (stringEscapeHandling.HasValue)
			{
				jsonWriter.StringEscapeHandling = stringEscapeHandling.Value;
			}
			if (this._dateFormatStringSet)
			{
				jsonWriter.DateFormatString = dateFormatString;
			}
			if (cultureInfo != null)
			{
				jsonWriter.Culture = cultureInfo;
			}
		}

		// Token: 0x06000821 RID: 2081
		// RVA: 0x0003BB80 File Offset: 0x00039D80
		private void SetupReader(JsonReader reader, out CultureInfo previousCulture, out DateTimeZoneHandling? previousDateTimeZoneHandling, out DateParseHandling? previousDateParseHandling, out FloatParseHandling? previousFloatParseHandling, out int? previousMaxDepth, out string previousDateFormatString)
		{
			if (this._culture != null && !this._culture.Equals(reader.Culture))
			{
				previousCulture = reader.Culture;
				reader.Culture = this._culture;
			}
			else
			{
				previousCulture = null;
			}
			if (this._dateTimeZoneHandling.HasValue && reader.DateTimeZoneHandling != this._dateTimeZoneHandling)
			{
				previousDateTimeZoneHandling = new DateTimeZoneHandling?(reader.DateTimeZoneHandling);
				reader.DateTimeZoneHandling = this._dateTimeZoneHandling.Value;
			}
			else
			{
				previousDateTimeZoneHandling = null;
			}
			if (this._dateParseHandling.HasValue && reader.DateParseHandling != this._dateParseHandling)
			{
				previousDateParseHandling = new DateParseHandling?(reader.DateParseHandling);
				reader.DateParseHandling = this._dateParseHandling.Value;
			}
			else
			{
				previousDateParseHandling = null;
			}
			if (this._floatParseHandling.HasValue && reader.FloatParseHandling != this._floatParseHandling)
			{
				previousFloatParseHandling = new FloatParseHandling?(reader.FloatParseHandling);
				reader.FloatParseHandling = this._floatParseHandling.Value;
			}
			else
			{
				previousFloatParseHandling = null;
			}
			if (this._maxDepthSet && reader.MaxDepth != this._maxDepth)
			{
				previousMaxDepth = reader.MaxDepth;
				reader.MaxDepth = this._maxDepth;
			}
			else
			{
				previousMaxDepth = null;
			}
			if (this._dateFormatStringSet && reader.DateFormatString != this._dateFormatString)
			{
				previousDateFormatString = reader.DateFormatString;
				reader.DateFormatString = this._dateFormatString;
			}
			else
			{
				previousDateFormatString = null;
			}
			JsonTextReader jsonTextReader = reader as JsonTextReader;
			if (jsonTextReader != null)
			{
				DefaultContractResolver defaultContractResolver = this._contractResolver as DefaultContractResolver;
				if (defaultContractResolver != null)
				{
					jsonTextReader.NameTable = defaultContractResolver.GetState().NameTable;
				}
			}
		}
	}
}
