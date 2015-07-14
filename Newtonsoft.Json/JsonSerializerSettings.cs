using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

namespace Newtonsoft.Json
{
	// Token: 0x020000B7 RID: 183
	public sealed class JsonSerializerSettings
	{
		// Token: 0x040002EB RID: 747
		internal const bool DefaultCheckAdditionalContent = false;

		// Token: 0x040002DF RID: 735
		internal const ConstructorHandling DefaultConstructorHandling = ConstructorHandling.Default;

		// Token: 0x040002ED RID: 749
		internal static readonly StreamingContext DefaultContext;

		// Token: 0x040002EE RID: 750
		internal static readonly CultureInfo DefaultCulture;

		// Token: 0x040002E4 RID: 740
		internal const DateFormatHandling DefaultDateFormatHandling = DateFormatHandling.IsoDateFormat;

		// Token: 0x040002EC RID: 748
		internal const string DefaultDateFormatString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

		// Token: 0x040002E6 RID: 742
		internal const DateParseHandling DefaultDateParseHandling = DateParseHandling.DateTime;

		// Token: 0x040002E5 RID: 741
		internal const DateTimeZoneHandling DefaultDateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind;

		// Token: 0x040002DC RID: 732
		internal const DefaultValueHandling DefaultDefaultValueHandling = DefaultValueHandling.Include;

		// Token: 0x040002E8 RID: 744
		internal const FloatFormatHandling DefaultFloatFormatHandling = FloatFormatHandling.String;

		// Token: 0x040002E7 RID: 743
		internal const FloatParseHandling DefaultFloatParseHandling = FloatParseHandling.Double;

		// Token: 0x040002EA RID: 746
		internal const FormatterAssemblyStyle DefaultFormatterAssemblyStyle = FormatterAssemblyStyle.Simple;

		// Token: 0x040002E3 RID: 739
		internal const Formatting DefaultFormatting = Formatting.None;

		// Token: 0x040002E1 RID: 737
		internal const MetadataPropertyHandling DefaultMetadataPropertyHandling = MetadataPropertyHandling.Default;

		// Token: 0x040002DA RID: 730
		internal const MissingMemberHandling DefaultMissingMemberHandling = MissingMemberHandling.Ignore;

		// Token: 0x040002DB RID: 731
		internal const NullValueHandling DefaultNullValueHandling = NullValueHandling.Include;

		// Token: 0x040002DD RID: 733
		internal const ObjectCreationHandling DefaultObjectCreationHandling = ObjectCreationHandling.Auto;

		// Token: 0x040002DE RID: 734
		internal const PreserveReferencesHandling DefaultPreserveReferencesHandling = PreserveReferencesHandling.None;

		// Token: 0x040002D9 RID: 729
		internal const ReferenceLoopHandling DefaultReferenceLoopHandling = ReferenceLoopHandling.Error;

		// Token: 0x040002E9 RID: 745
		internal const StringEscapeHandling DefaultStringEscapeHandling = StringEscapeHandling.Default;

		// Token: 0x040002E2 RID: 738
		internal const FormatterAssemblyStyle DefaultTypeNameAssemblyFormat = FormatterAssemblyStyle.Simple;

		// Token: 0x040002E0 RID: 736
		internal const TypeNameHandling DefaultTypeNameHandling = TypeNameHandling.None;

		// Token: 0x040002F7 RID: 759
		internal bool? _checkAdditionalContent;

		// Token: 0x04000304 RID: 772
		internal ConstructorHandling? _constructorHandling;

		// Token: 0x04000303 RID: 771
		internal StreamingContext? _context;

		// Token: 0x040002F6 RID: 758
		internal CultureInfo _culture;

		// Token: 0x040002F0 RID: 752
		internal DateFormatHandling? _dateFormatHandling;

		// Token: 0x040002FA RID: 762
		internal string _dateFormatString;

		// Token: 0x040002FB RID: 763
		internal bool _dateFormatStringSet;

		// Token: 0x040002F2 RID: 754
		internal DateParseHandling? _dateParseHandling;

		// Token: 0x040002F1 RID: 753
		internal DateTimeZoneHandling? _dateTimeZoneHandling;

		// Token: 0x040002FD RID: 765
		internal DefaultValueHandling? _defaultValueHandling;

		// Token: 0x040002F3 RID: 755
		internal FloatFormatHandling? _floatFormatHandling;

		// Token: 0x040002F4 RID: 756
		internal FloatParseHandling? _floatParseHandling;

		// Token: 0x040002EF RID: 751
		internal Formatting? _formatting;

		// Token: 0x040002F8 RID: 760
		internal int? _maxDepth;

		// Token: 0x040002F9 RID: 761
		internal bool _maxDepthSet;

		// Token: 0x04000306 RID: 774
		internal MetadataPropertyHandling? _metadataPropertyHandling;

		// Token: 0x04000301 RID: 769
		internal MissingMemberHandling? _missingMemberHandling;

		// Token: 0x040002FF RID: 767
		internal NullValueHandling? _nullValueHandling;

		// Token: 0x04000300 RID: 768
		internal ObjectCreationHandling? _objectCreationHandling;

		// Token: 0x040002FE RID: 766
		internal PreserveReferencesHandling? _preserveReferencesHandling;

		// Token: 0x04000302 RID: 770
		internal ReferenceLoopHandling? _referenceLoopHandling;

		// Token: 0x040002F5 RID: 757
		internal StringEscapeHandling? _stringEscapeHandling;

		// Token: 0x040002FC RID: 764
		internal FormatterAssemblyStyle? _typeNameAssemblyFormat;

		// Token: 0x04000305 RID: 773
		internal TypeNameHandling? _typeNameHandling;

		// Token: 0x170000DE RID: 222
		public SerializationBinder Binder
		{
			// Token: 0x06000611 RID: 1553
			// RVA: 0x000097A4 File Offset: 0x000079A4
			get;
			// Token: 0x06000612 RID: 1554
			// RVA: 0x000097AC File Offset: 0x000079AC
			set;
		}

		// Token: 0x170000EB RID: 235
		public bool CheckAdditionalContent
		{
			// Token: 0x0600062B RID: 1579
			// RVA: 0x00035E08 File Offset: 0x00034008
			get
			{
				return this._checkAdditionalContent ?? false;
			}
			// Token: 0x0600062C RID: 1580
			// RVA: 0x00009879 File Offset: 0x00007A79
			set
			{
				this._checkAdditionalContent = new bool?(value);
			}
		}

		// Token: 0x170000DA RID: 218
		public ConstructorHandling ConstructorHandling
		{
			// Token: 0x06000609 RID: 1545
			// RVA: 0x00035C58 File Offset: 0x00033E58
			get
			{
				ConstructorHandling? constructorHandling = this._constructorHandling;
				if (!constructorHandling.HasValue)
				{
					return ConstructorHandling.Default;
				}
				return constructorHandling.GetValueOrDefault();
			}
			// Token: 0x0600060A RID: 1546
			// RVA: 0x00009763 File Offset: 0x00007963
			set
			{
				this._constructorHandling = new ConstructorHandling?(value);
			}
		}

		// Token: 0x170000E0 RID: 224
		public StreamingContext Context
		{
			// Token: 0x06000615 RID: 1557
			// RVA: 0x00035C80 File Offset: 0x00033E80
			get
			{
				StreamingContext? context = this._context;
				if (!context.HasValue)
				{
					return JsonSerializerSettings.DefaultContext;
				}
				return context.GetValueOrDefault();
			}
			// Token: 0x06000616 RID: 1558
			// RVA: 0x000097C6 File Offset: 0x000079C6
			set
			{
				this._context = new StreamingContext?(value);
			}
		}

		// Token: 0x170000DB RID: 219
		public IContractResolver ContractResolver
		{
			// Token: 0x0600060B RID: 1547
			// RVA: 0x00009771 File Offset: 0x00007971
			get;
			// Token: 0x0600060C RID: 1548
			// RVA: 0x00009779 File Offset: 0x00007979
			set;
		}

		// Token: 0x170000D5 RID: 213
		public IList<JsonConverter> Converters
		{
			// Token: 0x060005FF RID: 1535
			// RVA: 0x0000971A File Offset: 0x0000791A
			get;
			// Token: 0x06000600 RID: 1536
			// RVA: 0x00009722 File Offset: 0x00007922
			set;
		}

		// Token: 0x170000EA RID: 234
		public CultureInfo Culture
		{
			// Token: 0x06000629 RID: 1577
			// RVA: 0x0000985F File Offset: 0x00007A5F
			get
			{
				return this._culture ?? JsonSerializerSettings.DefaultCulture;
			}
			// Token: 0x0600062A RID: 1578
			// RVA: 0x00009870 File Offset: 0x00007A70
			set
			{
				this._culture = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		public DateFormatHandling DateFormatHandling
		{
			// Token: 0x0600061D RID: 1565
			// RVA: 0x00035D18 File Offset: 0x00033F18
			get
			{
				DateFormatHandling? dateFormatHandling = this._dateFormatHandling;
				if (!dateFormatHandling.HasValue)
				{
					return DateFormatHandling.IsoDateFormat;
				}
				return dateFormatHandling.GetValueOrDefault();
			}
			// Token: 0x0600061E RID: 1566
			// RVA: 0x0000980B File Offset: 0x00007A0B
			set
			{
				this._dateFormatHandling = new DateFormatHandling?(value);
			}
		}

		// Token: 0x170000E1 RID: 225
		public string DateFormatString
		{
			// Token: 0x06000617 RID: 1559
			// RVA: 0x000097D4 File Offset: 0x000079D4
			get
			{
				return this._dateFormatString ?? "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";
			}
			// Token: 0x06000618 RID: 1560
			// RVA: 0x000097E5 File Offset: 0x000079E5
			set
			{
				this._dateFormatString = value;
				this._dateFormatStringSet = true;
			}
		}

		// Token: 0x170000E6 RID: 230
		public DateParseHandling DateParseHandling
		{
			// Token: 0x06000621 RID: 1569
			// RVA: 0x00035D68 File Offset: 0x00033F68
			get
			{
				DateParseHandling? dateParseHandling = this._dateParseHandling;
				if (!dateParseHandling.HasValue)
				{
					return DateParseHandling.DateTime;
				}
				return dateParseHandling.GetValueOrDefault();
			}
			// Token: 0x06000622 RID: 1570
			// RVA: 0x00009827 File Offset: 0x00007A27
			set
			{
				this._dateParseHandling = new DateParseHandling?(value);
			}
		}

		// Token: 0x170000E5 RID: 229
		public DateTimeZoneHandling DateTimeZoneHandling
		{
			// Token: 0x0600061F RID: 1567
			// RVA: 0x00035D40 File Offset: 0x00033F40
			get
			{
				DateTimeZoneHandling? dateTimeZoneHandling = this._dateTimeZoneHandling;
				if (!dateTimeZoneHandling.HasValue)
				{
					return DateTimeZoneHandling.RoundtripKind;
				}
				return dateTimeZoneHandling.GetValueOrDefault();
			}
			// Token: 0x06000620 RID: 1568
			// RVA: 0x00009819 File Offset: 0x00007A19
			set
			{
				this._dateTimeZoneHandling = new DateTimeZoneHandling?(value);
			}
		}

		// Token: 0x170000D4 RID: 212
		public DefaultValueHandling DefaultValueHandling
		{
			// Token: 0x060005FD RID: 1533
			// RVA: 0x00035B90 File Offset: 0x00033D90
			get
			{
				DefaultValueHandling? defaultValueHandling = this._defaultValueHandling;
				if (!defaultValueHandling.HasValue)
				{
					return DefaultValueHandling.Include;
				}
				return defaultValueHandling.GetValueOrDefault();
			}
			// Token: 0x060005FE RID: 1534
			// RVA: 0x0000970C File Offset: 0x0000790C
			set
			{
				this._defaultValueHandling = new DefaultValueHandling?(value);
			}
		}

		// Token: 0x170000DF RID: 223
		public EventHandler<ErrorEventArgs> Error
		{
			// Token: 0x06000613 RID: 1555
			// RVA: 0x000097B5 File Offset: 0x000079B5
			get;
			// Token: 0x06000614 RID: 1556
			// RVA: 0x000097BD File Offset: 0x000079BD
			set;
		}

		// Token: 0x170000E7 RID: 231
		public FloatFormatHandling FloatFormatHandling
		{
			// Token: 0x06000623 RID: 1571
			// RVA: 0x00035D90 File Offset: 0x00033F90
			get
			{
				FloatFormatHandling? floatFormatHandling = this._floatFormatHandling;
				if (!floatFormatHandling.HasValue)
				{
					return FloatFormatHandling.String;
				}
				return floatFormatHandling.GetValueOrDefault();
			}
			// Token: 0x06000624 RID: 1572
			// RVA: 0x00009835 File Offset: 0x00007A35
			set
			{
				this._floatFormatHandling = new FloatFormatHandling?(value);
			}
		}

		// Token: 0x170000E8 RID: 232
		public FloatParseHandling FloatParseHandling
		{
			// Token: 0x06000625 RID: 1573
			// RVA: 0x00035DB8 File Offset: 0x00033FB8
			get
			{
				FloatParseHandling? floatParseHandling = this._floatParseHandling;
				if (!floatParseHandling.HasValue)
				{
					return FloatParseHandling.Double;
				}
				return floatParseHandling.GetValueOrDefault();
			}
			// Token: 0x06000626 RID: 1574
			// RVA: 0x00009843 File Offset: 0x00007A43
			set
			{
				this._floatParseHandling = new FloatParseHandling?(value);
			}
		}

		// Token: 0x170000E3 RID: 227
		public Formatting Formatting
		{
			// Token: 0x0600061B RID: 1563
			// RVA: 0x00035CF0 File Offset: 0x00033EF0
			get
			{
				Formatting? formatting = this._formatting;
				if (!formatting.HasValue)
				{
					return Formatting.None;
				}
				return formatting.GetValueOrDefault();
			}
			// Token: 0x0600061C RID: 1564
			// RVA: 0x000097FD File Offset: 0x000079FD
			set
			{
				this._formatting = new Formatting?(value);
			}
		}

		// Token: 0x170000E2 RID: 226
		public int? MaxDepth
		{
			// Token: 0x06000619 RID: 1561
			// RVA: 0x000097F5 File Offset: 0x000079F5
			get
			{
				return this._maxDepth;
			}
			// Token: 0x0600061A RID: 1562
			// RVA: 0x00035CAC File Offset: 0x00033EAC
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

		// Token: 0x170000D8 RID: 216
		public MetadataPropertyHandling MetadataPropertyHandling
		{
			// Token: 0x06000605 RID: 1541
			// RVA: 0x00035C08 File Offset: 0x00033E08
			get
			{
				MetadataPropertyHandling? metadataPropertyHandling = this._metadataPropertyHandling;
				if (!metadataPropertyHandling.HasValue)
				{
					return MetadataPropertyHandling.Default;
				}
				return metadataPropertyHandling.GetValueOrDefault();
			}
			// Token: 0x06000606 RID: 1542
			// RVA: 0x00009747 File Offset: 0x00007947
			set
			{
				this._metadataPropertyHandling = new MetadataPropertyHandling?(value);
			}
		}

		// Token: 0x170000D1 RID: 209
		public MissingMemberHandling MissingMemberHandling
		{
			// Token: 0x060005F7 RID: 1527
			// RVA: 0x00035B18 File Offset: 0x00033D18
			get
			{
				MissingMemberHandling? missingMemberHandling = this._missingMemberHandling;
				if (!missingMemberHandling.HasValue)
				{
					return MissingMemberHandling.Ignore;
				}
				return missingMemberHandling.GetValueOrDefault();
			}
			// Token: 0x060005F8 RID: 1528
			// RVA: 0x000096E2 File Offset: 0x000078E2
			set
			{
				this._missingMemberHandling = new MissingMemberHandling?(value);
			}
		}

		// Token: 0x170000D3 RID: 211
		public NullValueHandling NullValueHandling
		{
			// Token: 0x060005FB RID: 1531
			// RVA: 0x00035B68 File Offset: 0x00033D68
			get
			{
				NullValueHandling? nullValueHandling = this._nullValueHandling;
				if (!nullValueHandling.HasValue)
				{
					return NullValueHandling.Include;
				}
				return nullValueHandling.GetValueOrDefault();
			}
			// Token: 0x060005FC RID: 1532
			// RVA: 0x000096FE File Offset: 0x000078FE
			set
			{
				this._nullValueHandling = new NullValueHandling?(value);
			}
		}

		// Token: 0x170000D2 RID: 210
		public ObjectCreationHandling ObjectCreationHandling
		{
			// Token: 0x060005F9 RID: 1529
			// RVA: 0x00035B40 File Offset: 0x00033D40
			get
			{
				ObjectCreationHandling? objectCreationHandling = this._objectCreationHandling;
				if (!objectCreationHandling.HasValue)
				{
					return ObjectCreationHandling.Auto;
				}
				return objectCreationHandling.GetValueOrDefault();
			}
			// Token: 0x060005FA RID: 1530
			// RVA: 0x000096F0 File Offset: 0x000078F0
			set
			{
				this._objectCreationHandling = new ObjectCreationHandling?(value);
			}
		}

		// Token: 0x170000D6 RID: 214
		public PreserveReferencesHandling PreserveReferencesHandling
		{
			// Token: 0x06000601 RID: 1537
			// RVA: 0x00035BB8 File Offset: 0x00033DB8
			get
			{
				PreserveReferencesHandling? preserveReferencesHandling = this._preserveReferencesHandling;
				if (!preserveReferencesHandling.HasValue)
				{
					return PreserveReferencesHandling.None;
				}
				return preserveReferencesHandling.GetValueOrDefault();
			}
			// Token: 0x06000602 RID: 1538
			// RVA: 0x0000972B File Offset: 0x0000792B
			set
			{
				this._preserveReferencesHandling = new PreserveReferencesHandling?(value);
			}
		}

		// Token: 0x170000D0 RID: 208
		public ReferenceLoopHandling ReferenceLoopHandling
		{
			// Token: 0x060005F5 RID: 1525
			// RVA: 0x00035AF0 File Offset: 0x00033CF0
			get
			{
				ReferenceLoopHandling? referenceLoopHandling = this._referenceLoopHandling;
				if (!referenceLoopHandling.HasValue)
				{
					return ReferenceLoopHandling.Error;
				}
				return referenceLoopHandling.GetValueOrDefault();
			}
			// Token: 0x060005F6 RID: 1526
			// RVA: 0x000096D4 File Offset: 0x000078D4
			set
			{
				this._referenceLoopHandling = new ReferenceLoopHandling?(value);
			}
		}

		// Token: 0x170000DC RID: 220
		public IReferenceResolver ReferenceResolver
		{
			// Token: 0x0600060D RID: 1549
			// RVA: 0x00009782 File Offset: 0x00007982
			get;
			// Token: 0x0600060E RID: 1550
			// RVA: 0x0000978A File Offset: 0x0000798A
			set;
		}

		// Token: 0x170000E9 RID: 233
		public StringEscapeHandling StringEscapeHandling
		{
			// Token: 0x06000627 RID: 1575
			// RVA: 0x00035DE0 File Offset: 0x00033FE0
			get
			{
				StringEscapeHandling? stringEscapeHandling = this._stringEscapeHandling;
				if (!stringEscapeHandling.HasValue)
				{
					return StringEscapeHandling.Default;
				}
				return stringEscapeHandling.GetValueOrDefault();
			}
			// Token: 0x06000628 RID: 1576
			// RVA: 0x00009851 File Offset: 0x00007A51
			set
			{
				this._stringEscapeHandling = new StringEscapeHandling?(value);
			}
		}

		// Token: 0x170000DD RID: 221
		public ITraceWriter TraceWriter
		{
			// Token: 0x0600060F RID: 1551
			// RVA: 0x00009793 File Offset: 0x00007993
			get;
			// Token: 0x06000610 RID: 1552
			// RVA: 0x0000979B File Offset: 0x0000799B
			set;
		}

		// Token: 0x170000D9 RID: 217
		public FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			// Token: 0x06000607 RID: 1543
			// RVA: 0x00035C30 File Offset: 0x00033E30
			get
			{
				FormatterAssemblyStyle? typeNameAssemblyFormat = this._typeNameAssemblyFormat;
				if (!typeNameAssemblyFormat.HasValue)
				{
					return FormatterAssemblyStyle.Simple;
				}
				return typeNameAssemblyFormat.GetValueOrDefault();
			}
			// Token: 0x06000608 RID: 1544
			// RVA: 0x00009755 File Offset: 0x00007955
			set
			{
				this._typeNameAssemblyFormat = new FormatterAssemblyStyle?(value);
			}
		}

		// Token: 0x170000D7 RID: 215
		public TypeNameHandling TypeNameHandling
		{
			// Token: 0x06000603 RID: 1539
			// RVA: 0x00035BE0 File Offset: 0x00033DE0
			get
			{
				TypeNameHandling? typeNameHandling = this._typeNameHandling;
				if (!typeNameHandling.HasValue)
				{
					return TypeNameHandling.None;
				}
				return typeNameHandling.GetValueOrDefault();
			}
			// Token: 0x06000604 RID: 1540
			// RVA: 0x00009739 File Offset: 0x00007939
			set
			{
				this._typeNameHandling = new TypeNameHandling?(value);
			}
		}

		// Token: 0x0600062D RID: 1581
		// RVA: 0x00009887 File Offset: 0x00007A87
		static JsonSerializerSettings()
		{
			JsonSerializerSettings.DefaultContext = default(StreamingContext);
			JsonSerializerSettings.DefaultCulture = CultureInfo.InvariantCulture;
		}

		// Token: 0x0600062E RID: 1582
		// RVA: 0x0000989E File Offset: 0x00007A9E
		public JsonSerializerSettings()
		{
			this.Converters = new List<JsonConverter>();
		}
	}
}
