using Newtonsoft.Json.Utilities;
using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000125 RID: 293
	internal sealed class JsonSerializerProxy : JsonSerializer
	{
		// Token: 0x0400051B RID: 1307
		private readonly JsonSerializer _serializer;

		// Token: 0x04000519 RID: 1305
		private readonly JsonSerializerInternalReader _serializerReader;

		// Token: 0x0400051A RID: 1306
		private readonly JsonSerializerInternalWriter _serializerWriter;

		// Token: 0x14000006 RID: 6
		public override event EventHandler<ErrorEventArgs> Error
		{
			// Token: 0x06000C0F RID: 3087
			// RVA: 0x0000D26A File Offset: 0x0000B46A
			add
			{
				this._serializer.Error += value;
			}
			// Token: 0x06000C10 RID: 3088
			// RVA: 0x0000D278 File Offset: 0x0000B478
			remove
			{
				this._serializer.Error -= value;
			}
		}

		// Token: 0x17000243 RID: 579
		public override SerializationBinder Binder
		{
			// Token: 0x06000C2C RID: 3116
			// RVA: 0x0000D3F2 File Offset: 0x0000B5F2
			get
			{
				return this._serializer.Binder;
			}
			// Token: 0x06000C2D RID: 3117
			// RVA: 0x0000D3FF File Offset: 0x0000B5FF
			set
			{
				this._serializer.Binder = value;
			}
		}

		// Token: 0x1700024F RID: 591
		public override bool CheckAdditionalContent
		{
			// Token: 0x06000C44 RID: 3140
			// RVA: 0x0000D536 File Offset: 0x0000B736
			get
			{
				return this._serializer.CheckAdditionalContent;
			}
			// Token: 0x06000C45 RID: 3141
			// RVA: 0x0000D543 File Offset: 0x0000B743
			set
			{
				this._serializer.CheckAdditionalContent = value;
			}
		}

		// Token: 0x17000242 RID: 578
		public override ConstructorHandling ConstructorHandling
		{
			// Token: 0x06000C2A RID: 3114
			// RVA: 0x0000D3D7 File Offset: 0x0000B5D7
			get
			{
				return this._serializer.ConstructorHandling;
			}
			// Token: 0x06000C2B RID: 3115
			// RVA: 0x0000D3E4 File Offset: 0x0000B5E4
			set
			{
				this._serializer.ConstructorHandling = value;
			}
		}

		// Token: 0x17000244 RID: 580
		public override StreamingContext Context
		{
			// Token: 0x06000C2E RID: 3118
			// RVA: 0x0000D40D File Offset: 0x0000B60D
			get
			{
				return this._serializer.Context;
			}
			// Token: 0x06000C2F RID: 3119
			// RVA: 0x0000D41A File Offset: 0x0000B61A
			set
			{
				this._serializer.Context = value;
			}
		}

		// Token: 0x17000239 RID: 569
		public override IContractResolver ContractResolver
		{
			// Token: 0x06000C18 RID: 3096
			// RVA: 0x0000D2E4 File Offset: 0x0000B4E4
			get
			{
				return this._serializer.ContractResolver;
			}
			// Token: 0x06000C19 RID: 3097
			// RVA: 0x0000D2F1 File Offset: 0x0000B4F1
			set
			{
				this._serializer.ContractResolver = value;
			}
		}

		// Token: 0x17000237 RID: 567
		public override JsonConverterCollection Converters
		{
			// Token: 0x06000C15 RID: 3093
			// RVA: 0x0000D2BC File Offset: 0x0000B4BC
			get
			{
				return this._serializer.Converters;
			}
		}

		// Token: 0x1700024D RID: 589
		public override CultureInfo Culture
		{
			// Token: 0x06000C40 RID: 3136
			// RVA: 0x0000D500 File Offset: 0x0000B700
			get
			{
				return this._serializer.Culture;
			}
			// Token: 0x06000C41 RID: 3137
			// RVA: 0x0000D50D File Offset: 0x0000B70D
			set
			{
				this._serializer.Culture = value;
			}
		}

		// Token: 0x17000246 RID: 582
		public override DateFormatHandling DateFormatHandling
		{
			// Token: 0x06000C32 RID: 3122
			// RVA: 0x0000D443 File Offset: 0x0000B643
			get
			{
				return this._serializer.DateFormatHandling;
			}
			// Token: 0x06000C33 RID: 3123
			// RVA: 0x0000D450 File Offset: 0x0000B650
			set
			{
				this._serializer.DateFormatHandling = value;
			}
		}

		// Token: 0x1700024C RID: 588
		public override string DateFormatString
		{
			// Token: 0x06000C3E RID: 3134
			// RVA: 0x0000D4E5 File Offset: 0x0000B6E5
			get
			{
				return this._serializer.DateFormatString;
			}
			// Token: 0x06000C3F RID: 3135
			// RVA: 0x0000D4F2 File Offset: 0x0000B6F2
			set
			{
				this._serializer.DateFormatString = value;
			}
		}

		// Token: 0x17000248 RID: 584
		public override DateParseHandling DateParseHandling
		{
			// Token: 0x06000C36 RID: 3126
			// RVA: 0x0000D479 File Offset: 0x0000B679
			get
			{
				return this._serializer.DateParseHandling;
			}
			// Token: 0x06000C37 RID: 3127
			// RVA: 0x0000D486 File Offset: 0x0000B686
			set
			{
				this._serializer.DateParseHandling = value;
			}
		}

		// Token: 0x17000247 RID: 583
		public override DateTimeZoneHandling DateTimeZoneHandling
		{
			// Token: 0x06000C34 RID: 3124
			// RVA: 0x0000D45E File Offset: 0x0000B65E
			get
			{
				return this._serializer.DateTimeZoneHandling;
			}
			// Token: 0x06000C35 RID: 3125
			// RVA: 0x0000D46B File Offset: 0x0000B66B
			set
			{
				this._serializer.DateTimeZoneHandling = value;
			}
		}

		// Token: 0x17000238 RID: 568
		public override DefaultValueHandling DefaultValueHandling
		{
			// Token: 0x06000C16 RID: 3094
			// RVA: 0x0000D2C9 File Offset: 0x0000B4C9
			get
			{
				return this._serializer.DefaultValueHandling;
			}
			// Token: 0x06000C17 RID: 3095
			// RVA: 0x0000D2D6 File Offset: 0x0000B4D6
			set
			{
				this._serializer.DefaultValueHandling = value;
			}
		}

		// Token: 0x17000249 RID: 585
		public override FloatFormatHandling FloatFormatHandling
		{
			// Token: 0x06000C38 RID: 3128
			// RVA: 0x0000D494 File Offset: 0x0000B694
			get
			{
				return this._serializer.FloatFormatHandling;
			}
			// Token: 0x06000C39 RID: 3129
			// RVA: 0x0000D4A1 File Offset: 0x0000B6A1
			set
			{
				this._serializer.FloatFormatHandling = value;
			}
		}

		// Token: 0x1700024A RID: 586
		public override FloatParseHandling FloatParseHandling
		{
			// Token: 0x06000C3A RID: 3130
			// RVA: 0x0000D4AF File Offset: 0x0000B6AF
			get
			{
				return this._serializer.FloatParseHandling;
			}
			// Token: 0x06000C3B RID: 3131
			// RVA: 0x0000D4BC File Offset: 0x0000B6BC
			set
			{
				this._serializer.FloatParseHandling = value;
			}
		}

		// Token: 0x17000245 RID: 581
		public override Formatting Formatting
		{
			// Token: 0x06000C30 RID: 3120
			// RVA: 0x0000D428 File Offset: 0x0000B628
			get
			{
				return this._serializer.Formatting;
			}
			// Token: 0x06000C31 RID: 3121
			// RVA: 0x0000D435 File Offset: 0x0000B635
			set
			{
				this._serializer.Formatting = value;
			}
		}

		// Token: 0x1700024E RID: 590
		public override int? MaxDepth
		{
			// Token: 0x06000C42 RID: 3138
			// RVA: 0x0000D51B File Offset: 0x0000B71B
			get
			{
				return this._serializer.MaxDepth;
			}
			// Token: 0x06000C43 RID: 3139
			// RVA: 0x0000D528 File Offset: 0x0000B728
			set
			{
				this._serializer.MaxDepth = value;
			}
		}

		// Token: 0x17000240 RID: 576
		public override MetadataPropertyHandling MetadataPropertyHandling
		{
			// Token: 0x06000C26 RID: 3110
			// RVA: 0x0000D3A1 File Offset: 0x0000B5A1
			get
			{
				return this._serializer.MetadataPropertyHandling;
			}
			// Token: 0x06000C27 RID: 3111
			// RVA: 0x0000D3AE File Offset: 0x0000B5AE
			set
			{
				this._serializer.MetadataPropertyHandling = value;
			}
		}

		// Token: 0x1700023A RID: 570
		public override MissingMemberHandling MissingMemberHandling
		{
			// Token: 0x06000C1A RID: 3098
			// RVA: 0x0000D2FF File Offset: 0x0000B4FF
			get
			{
				return this._serializer.MissingMemberHandling;
			}
			// Token: 0x06000C1B RID: 3099
			// RVA: 0x0000D30C File Offset: 0x0000B50C
			set
			{
				this._serializer.MissingMemberHandling = value;
			}
		}

		// Token: 0x1700023B RID: 571
		public override NullValueHandling NullValueHandling
		{
			// Token: 0x06000C1C RID: 3100
			// RVA: 0x0000D31A File Offset: 0x0000B51A
			get
			{
				return this._serializer.NullValueHandling;
			}
			// Token: 0x06000C1D RID: 3101
			// RVA: 0x0000D327 File Offset: 0x0000B527
			set
			{
				this._serializer.NullValueHandling = value;
			}
		}

		// Token: 0x1700023C RID: 572
		public override ObjectCreationHandling ObjectCreationHandling
		{
			// Token: 0x06000C1E RID: 3102
			// RVA: 0x0000D335 File Offset: 0x0000B535
			get
			{
				return this._serializer.ObjectCreationHandling;
			}
			// Token: 0x06000C1F RID: 3103
			// RVA: 0x0000D342 File Offset: 0x0000B542
			set
			{
				this._serializer.ObjectCreationHandling = value;
			}
		}

		// Token: 0x1700023E RID: 574
		public override PreserveReferencesHandling PreserveReferencesHandling
		{
			// Token: 0x06000C22 RID: 3106
			// RVA: 0x0000D36B File Offset: 0x0000B56B
			get
			{
				return this._serializer.PreserveReferencesHandling;
			}
			// Token: 0x06000C23 RID: 3107
			// RVA: 0x0000D378 File Offset: 0x0000B578
			set
			{
				this._serializer.PreserveReferencesHandling = value;
			}
		}

		// Token: 0x1700023D RID: 573
		public override ReferenceLoopHandling ReferenceLoopHandling
		{
			// Token: 0x06000C20 RID: 3104
			// RVA: 0x0000D350 File Offset: 0x0000B550
			get
			{
				return this._serializer.ReferenceLoopHandling;
			}
			// Token: 0x06000C21 RID: 3105
			// RVA: 0x0000D35D File Offset: 0x0000B55D
			set
			{
				this._serializer.ReferenceLoopHandling = value;
			}
		}

		// Token: 0x17000235 RID: 565
		public override IReferenceResolver ReferenceResolver
		{
			// Token: 0x06000C11 RID: 3089
			// RVA: 0x0000D286 File Offset: 0x0000B486
			get
			{
				return this._serializer.ReferenceResolver;
			}
			// Token: 0x06000C12 RID: 3090
			// RVA: 0x0000D293 File Offset: 0x0000B493
			set
			{
				this._serializer.ReferenceResolver = value;
			}
		}

		// Token: 0x1700024B RID: 587
		public override StringEscapeHandling StringEscapeHandling
		{
			// Token: 0x06000C3C RID: 3132
			// RVA: 0x0000D4CA File Offset: 0x0000B6CA
			get
			{
				return this._serializer.StringEscapeHandling;
			}
			// Token: 0x06000C3D RID: 3133
			// RVA: 0x0000D4D7 File Offset: 0x0000B6D7
			set
			{
				this._serializer.StringEscapeHandling = value;
			}
		}

		// Token: 0x17000236 RID: 566
		public override ITraceWriter TraceWriter
		{
			// Token: 0x06000C13 RID: 3091
			// RVA: 0x0000D2A1 File Offset: 0x0000B4A1
			get
			{
				return this._serializer.TraceWriter;
			}
			// Token: 0x06000C14 RID: 3092
			// RVA: 0x0000D2AE File Offset: 0x0000B4AE
			set
			{
				this._serializer.TraceWriter = value;
			}
		}

		// Token: 0x17000241 RID: 577
		public override FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			// Token: 0x06000C28 RID: 3112
			// RVA: 0x0000D3BC File Offset: 0x0000B5BC
			get
			{
				return this._serializer.TypeNameAssemblyFormat;
			}
			// Token: 0x06000C29 RID: 3113
			// RVA: 0x0000D3C9 File Offset: 0x0000B5C9
			set
			{
				this._serializer.TypeNameAssemblyFormat = value;
			}
		}

		// Token: 0x1700023F RID: 575
		public override TypeNameHandling TypeNameHandling
		{
			// Token: 0x06000C24 RID: 3108
			// RVA: 0x0000D386 File Offset: 0x0000B586
			get
			{
				return this._serializer.TypeNameHandling;
			}
			// Token: 0x06000C25 RID: 3109
			// RVA: 0x0000D393 File Offset: 0x0000B593
			set
			{
				this._serializer.TypeNameHandling = value;
			}
		}

		// Token: 0x06000C47 RID: 3143
		// RVA: 0x0000D568 File Offset: 0x0000B768
		public JsonSerializerProxy(JsonSerializerInternalReader serializerReader)
		{
			ValidationUtils.ArgumentNotNull(serializerReader, "serializerReader");
			this._serializerReader = serializerReader;
			this._serializer = serializerReader.Serializer;
		}

		// Token: 0x06000C48 RID: 3144
		// RVA: 0x0000D58E File Offset: 0x0000B78E
		public JsonSerializerProxy(JsonSerializerInternalWriter serializerWriter)
		{
			ValidationUtils.ArgumentNotNull(serializerWriter, "serializerWriter");
			this._serializerWriter = serializerWriter;
			this._serializer = serializerWriter.Serializer;
		}

		// Token: 0x06000C49 RID: 3145
		// RVA: 0x0000D5B4 File Offset: 0x0000B7B4
		internal override object DeserializeInternal(JsonReader reader, Type objectType)
		{
			if (this._serializerReader != null)
			{
				return this._serializerReader.Deserialize(reader, objectType, false);
			}
			return this._serializer.Deserialize(reader, objectType);
		}

		// Token: 0x06000C46 RID: 3142
		// RVA: 0x0000D551 File Offset: 0x0000B751
		internal JsonSerializerInternalBase GetInternalSerializer()
		{
			if (this._serializerReader != null)
			{
				return this._serializerReader;
			}
			return this._serializerWriter;
		}

		// Token: 0x06000C4A RID: 3146
		// RVA: 0x0000D5DA File Offset: 0x0000B7DA
		internal override void PopulateInternal(JsonReader reader, object target)
		{
			if (this._serializerReader != null)
			{
				this._serializerReader.Populate(reader, target);
				return;
			}
			this._serializer.Populate(reader, target);
		}

		// Token: 0x06000C4B RID: 3147
		// RVA: 0x0000D5FF File Offset: 0x0000B7FF
		internal override void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType)
		{
			if (this._serializerWriter != null)
			{
				this._serializerWriter.Serialize(jsonWriter, value, rootType);
				return;
			}
			this._serializer.Serialize(jsonWriter, value);
		}
	}
}
