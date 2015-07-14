using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;
using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;

namespace Newtonsoft.Json
{
	// Token: 0x020000D5 RID: 213
	public static class JsonConvert
	{
		// Token: 0x04000376 RID: 886
		public static readonly string False = "false";

		// Token: 0x0400037B RID: 891
		public static readonly string NaN = "NaN";

		// Token: 0x0400037A RID: 890
		public static readonly string NegativeInfinity = "-Infinity";

		// Token: 0x04000377 RID: 887
		public static readonly string Null = "null";

		// Token: 0x04000379 RID: 889
		public static readonly string PositiveInfinity = "Infinity";

		// Token: 0x04000375 RID: 885
		public static readonly string True = "true";

		// Token: 0x04000378 RID: 888
		public static readonly string Undefined = "undefined";

		// Token: 0x17000142 RID: 322
		public static Func<JsonSerializerSettings> DefaultSettings
		{
			// Token: 0x06000797 RID: 1943
			// RVA: 0x0000A76D File Offset: 0x0000896D
			get;
			// Token: 0x06000798 RID: 1944
			// RVA: 0x0000A774 File Offset: 0x00008974
			set;
		}

		// Token: 0x060007C5 RID: 1989
		// RVA: 0x0000A9E6 File Offset: 0x00008BE6
		public static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject)
		{
			return JsonConvert.DeserializeObject<T>(value);
		}

		// Token: 0x060007C6 RID: 1990
		// RVA: 0x0000A9EE File Offset: 0x00008BEE
		public static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject, JsonSerializerSettings settings)
		{
			return JsonConvert.DeserializeObject<T>(value, settings);
		}

		// Token: 0x060007C1 RID: 1985
		// RVA: 0x0000A9BF File Offset: 0x00008BBF
		public static object DeserializeObject(string value)
		{
			return JsonConvert.DeserializeObject(value, null, null);
		}

		// Token: 0x060007C4 RID: 1988
		// RVA: 0x0000A9DD File Offset: 0x00008BDD
		public static T DeserializeObject<T>(string value)
		{
			return JsonConvert.DeserializeObject<T>(value, null);
		}

		// Token: 0x060007C2 RID: 1986
		// RVA: 0x0000A9C9 File Offset: 0x00008BC9
		public static object DeserializeObject(string value, JsonSerializerSettings settings)
		{
			return JsonConvert.DeserializeObject(value, null, settings);
		}

		// Token: 0x060007C3 RID: 1987
		// RVA: 0x0000A9D3 File Offset: 0x00008BD3
		public static object DeserializeObject(string value, Type type)
		{
			return JsonConvert.DeserializeObject(value, type, null);
		}

		// Token: 0x060007C7 RID: 1991
		// RVA: 0x0000A9F7 File Offset: 0x00008BF7
		public static T DeserializeObject<T>(string value, params JsonConverter[] converters)
		{
			return (T)((object)JsonConvert.DeserializeObject(value, typeof(T), converters));
		}

		// Token: 0x060007C8 RID: 1992
		// RVA: 0x0000AA0F File Offset: 0x00008C0F
		public static T DeserializeObject<T>(string value, JsonSerializerSettings settings)
		{
			return (T)((object)JsonConvert.DeserializeObject(value, typeof(T), settings));
		}

		// Token: 0x060007C9 RID: 1993
		// RVA: 0x0003B2A0 File Offset: 0x000394A0
		public static object DeserializeObject(string value, Type type, params JsonConverter[] converters)
		{
			JsonSerializerSettings settings = (converters == null || converters.Length <= 0) ? null : new JsonSerializerSettings
			{
				Converters = converters
			};
			return JsonConvert.DeserializeObject(value, type, settings);
		}

		// Token: 0x060007CA RID: 1994
		// RVA: 0x0003B2D0 File Offset: 0x000394D0
		public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings)
		{
			ValidationUtils.ArgumentNotNull(value, "value");
			JsonSerializer jsonSerializer = JsonSerializer.CreateDefault(settings);
			if (!jsonSerializer.IsCheckAdditionalContentSet())
			{
				jsonSerializer.CheckAdditionalContent = true;
			}
			object result;
			using (JsonTextReader jsonTextReader = new JsonTextReader(new StringReader(value)))
			{
				result = jsonSerializer.Deserialize(jsonTextReader, type);
			}
			return result;
		}

		// Token: 0x060007D0 RID: 2000
		// RVA: 0x0000AA3A File Offset: 0x00008C3A
		public static XmlDocument DeserializeXmlNode(string value)
		{
			return JsonConvert.DeserializeXmlNode(value, null);
		}

		// Token: 0x060007D1 RID: 2001
		// RVA: 0x0000AA43 File Offset: 0x00008C43
		public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName)
		{
			return JsonConvert.DeserializeXmlNode(value, deserializeRootElementName, false);
		}

		// Token: 0x060007D2 RID: 2002
		// RVA: 0x0003B3E8 File Offset: 0x000395E8
		public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName, bool writeArrayAttribute)
		{
			XmlNodeConverter xmlNodeConverter = new XmlNodeConverter();
			xmlNodeConverter.DeserializeRootElementName = deserializeRootElementName;
			xmlNodeConverter.WriteArrayAttribute = writeArrayAttribute;
			return (XmlDocument)JsonConvert.DeserializeObject(value, typeof(XmlDocument), new JsonConverter[]
			{
				xmlNodeConverter
			});
		}

		// Token: 0x060007AA RID: 1962
		// RVA: 0x0000A8C1 File Offset: 0x00008AC1
		private static string EnsureDecimalPlace(string text)
		{
			if (text.IndexOf('.') != -1)
			{
				return text;
			}
			return text + ".0";
		}

		// Token: 0x060007A9 RID: 1961
		// RVA: 0x0003AF50 File Offset: 0x00039150
		private static string EnsureDecimalPlace(double value, string text)
		{
			if (!double.IsNaN(value) && !double.IsInfinity(value) && text.IndexOf('.') == -1 && text.IndexOf('E') == -1)
			{
				if (text.IndexOf('e') == -1)
				{
					return text + ".0";
				}
			}
			return text;
		}

		// Token: 0x060007A6 RID: 1958
		// RVA: 0x0000A848 File Offset: 0x00008A48
		private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			if (floatFormatHandling == FloatFormatHandling.Symbol || (!double.IsInfinity(value) && !double.IsNaN(value)))
			{
				return text;
			}
			if (floatFormatHandling != FloatFormatHandling.DefaultValue)
			{
				return quoteChar + text + quoteChar;
			}
			if (nullable)
			{
				return JsonConvert.Null;
			}
			return "0.0";
		}

		// Token: 0x060007CB RID: 1995
		// RVA: 0x0000AA27 File Offset: 0x00008C27
		public static void PopulateObject(string value, object target)
		{
			JsonConvert.PopulateObject(value, target, null);
		}

		// Token: 0x060007CC RID: 1996
		// RVA: 0x0003B330 File Offset: 0x00039530
		public static void PopulateObject(string value, object target, JsonSerializerSettings settings)
		{
			JsonSerializer jsonSerializer = JsonSerializer.CreateDefault(settings);
			using (JsonReader jsonReader = new JsonTextReader(new StringReader(value)))
			{
				jsonSerializer.Populate(jsonReader, target);
				if (jsonReader.Read() && jsonReader.TokenType != JsonToken.Comment)
				{
					throw new JsonSerializationException("Additional text found in JSON string after finishing deserializing object.");
				}
			}
		}

		// Token: 0x060007B8 RID: 1976
		// RVA: 0x0000A996 File Offset: 0x00008B96
		public static string SerializeObject(object value)
		{
			return JsonConvert.SerializeObject(value, null, null);
		}

		// Token: 0x060007B9 RID: 1977
		// RVA: 0x0000A9A0 File Offset: 0x00008BA0
		public static string SerializeObject(object value, Formatting formatting)
		{
			return JsonConvert.SerializeObject(value, formatting, null);
		}

		// Token: 0x060007BA RID: 1978
		// RVA: 0x0003B198 File Offset: 0x00039398
		public static string SerializeObject(object value, params JsonConverter[] converters)
		{
			JsonSerializerSettings settings = (converters == null || converters.Length <= 0) ? null : new JsonSerializerSettings
			{
				Converters = converters
			};
			return JsonConvert.SerializeObject(value, null, settings);
		}

		// Token: 0x060007BC RID: 1980
		// RVA: 0x0000A9AA File Offset: 0x00008BAA
		public static string SerializeObject(object value, JsonSerializerSettings settings)
		{
			return JsonConvert.SerializeObject(value, null, settings);
		}

		// Token: 0x060007BB RID: 1979
		// RVA: 0x0003B1C8 File Offset: 0x000393C8
		public static string SerializeObject(object value, Formatting formatting, params JsonConverter[] converters)
		{
			JsonSerializerSettings settings = (converters == null || converters.Length <= 0) ? null : new JsonSerializerSettings
			{
				Converters = converters
			};
			return JsonConvert.SerializeObject(value, null, formatting, settings);
		}

		// Token: 0x060007BD RID: 1981
		// RVA: 0x0003B1FC File Offset: 0x000393FC
		public static string SerializeObject(object value, Type type, JsonSerializerSettings settings)
		{
			JsonSerializer jsonSerializer = JsonSerializer.CreateDefault(settings);
			return JsonConvert.SerializeObjectInternal(value, type, jsonSerializer);
		}

		// Token: 0x060007BE RID: 1982
		// RVA: 0x0000A9B4 File Offset: 0x00008BB4
		public static string SerializeObject(object value, Formatting formatting, JsonSerializerSettings settings)
		{
			return JsonConvert.SerializeObject(value, null, formatting, settings);
		}

		// Token: 0x060007BF RID: 1983
		// RVA: 0x0003B218 File Offset: 0x00039418
		public static string SerializeObject(object value, Type type, Formatting formatting, JsonSerializerSettings settings)
		{
			JsonSerializer jsonSerializer = JsonSerializer.CreateDefault(settings);
			jsonSerializer.Formatting = formatting;
			return JsonConvert.SerializeObjectInternal(value, type, jsonSerializer);
		}

		// Token: 0x060007C0 RID: 1984
		// RVA: 0x0003B23C File Offset: 0x0003943C
		private static string SerializeObjectInternal(object value, Type type, JsonSerializer jsonSerializer)
		{
			StringBuilder sb = new StringBuilder(256);
			StringWriter stringWriter = new StringWriter(sb, CultureInfo.InvariantCulture);
			using (JsonTextWriter jsonTextWriter = new JsonTextWriter(stringWriter))
			{
				jsonTextWriter.Formatting = jsonSerializer.Formatting;
				jsonSerializer.Serialize(jsonTextWriter, value, type);
			}
			return stringWriter.ToString();
		}

		// Token: 0x060007CD RID: 1997
		// RVA: 0x0000AA31 File Offset: 0x00008C31
		public static string SerializeXmlNode(XmlNode node)
		{
			return JsonConvert.SerializeXmlNode(node, Formatting.None);
		}

		// Token: 0x060007CE RID: 1998
		// RVA: 0x0003B390 File Offset: 0x00039590
		public static string SerializeXmlNode(XmlNode node, Formatting formatting)
		{
			XmlNodeConverter xmlNodeConverter = new XmlNodeConverter();
			return JsonConvert.SerializeObject(node, formatting, new JsonConverter[]
			{
				xmlNodeConverter
			});
		}

		// Token: 0x060007CF RID: 1999
		// RVA: 0x0003B3B8 File Offset: 0x000395B8
		public static string SerializeXmlNode(XmlNode node, Formatting formatting, bool omitRootObject)
		{
			XmlNodeConverter xmlNodeConverter = new XmlNodeConverter
			{
				OmitRootObject = omitRootObject
			};
			return JsonConvert.SerializeObject(node, formatting, new JsonConverter[]
			{
				xmlNodeConverter
			});
		}

		// Token: 0x06000799 RID: 1945
		// RVA: 0x0000A77C File Offset: 0x0000897C
		public static string ToString(DateTime value)
		{
			return JsonConvert.ToString(value, DateFormatHandling.IsoDateFormat, DateTimeZoneHandling.RoundtripKind);
		}

		// Token: 0x0600079B RID: 1947
		// RVA: 0x0000A786 File Offset: 0x00008986
		public static string ToString(bool value)
		{
			if (!value)
			{
				return JsonConvert.False;
			}
			return JsonConvert.True;
		}

		// Token: 0x0600079C RID: 1948
		// RVA: 0x0000A796 File Offset: 0x00008996
		public static string ToString(char value)
		{
			return JsonConvert.ToString(char.ToString(value));
		}

		// Token: 0x0600079D RID: 1949
		// RVA: 0x0000A7A3 File Offset: 0x000089A3
		public static string ToString(Enum value)
		{
			return value.ToString("D");
		}

		// Token: 0x0600079E RID: 1950
		// RVA: 0x0000A7B0 File Offset: 0x000089B0
		public static string ToString(int value)
		{
			return value.ToString(null, CultureInfo.InvariantCulture);
		}

		// Token: 0x0600079F RID: 1951
		// RVA: 0x0000A7BF File Offset: 0x000089BF
		public static string ToString(short value)
		{
			return value.ToString(null, CultureInfo.InvariantCulture);
		}

		// Token: 0x060007A0 RID: 1952
		// RVA: 0x0000A7CE File Offset: 0x000089CE
		[CLSCompliant(false)]
		public static string ToString(ushort value)
		{
			return value.ToString(null, CultureInfo.InvariantCulture);
		}

		// Token: 0x060007A1 RID: 1953
		// RVA: 0x0000A7DD File Offset: 0x000089DD
		[CLSCompliant(false)]
		public static string ToString(uint value)
		{
			return value.ToString(null, CultureInfo.InvariantCulture);
		}

		// Token: 0x060007A2 RID: 1954
		// RVA: 0x0000A7EC File Offset: 0x000089EC
		public static string ToString(long value)
		{
			return value.ToString(null, CultureInfo.InvariantCulture);
		}

		// Token: 0x060007A3 RID: 1955
		// RVA: 0x0000A7FB File Offset: 0x000089FB
		[CLSCompliant(false)]
		public static string ToString(ulong value)
		{
			return value.ToString(null, CultureInfo.InvariantCulture);
		}

		// Token: 0x060007A4 RID: 1956
		// RVA: 0x0000A80A File Offset: 0x00008A0A
		public static string ToString(float value)
		{
			return JsonConvert.EnsureDecimalPlace((double)value, value.ToString("R", CultureInfo.InvariantCulture));
		}

		// Token: 0x060007A7 RID: 1959
		// RVA: 0x0000A886 File Offset: 0x00008A86
		public static string ToString(double value)
		{
			return JsonConvert.EnsureDecimalPlace(value, value.ToString("R", CultureInfo.InvariantCulture));
		}

		// Token: 0x060007AB RID: 1963
		// RVA: 0x0000A8DB File Offset: 0x00008ADB
		public static string ToString(byte value)
		{
			return value.ToString(null, CultureInfo.InvariantCulture);
		}

		// Token: 0x060007AC RID: 1964
		// RVA: 0x0000A8EA File Offset: 0x00008AEA
		[CLSCompliant(false)]
		public static string ToString(sbyte value)
		{
			return value.ToString(null, CultureInfo.InvariantCulture);
		}

		// Token: 0x060007AD RID: 1965
		// RVA: 0x0000A8F9 File Offset: 0x00008AF9
		public static string ToString(decimal value)
		{
			return JsonConvert.EnsureDecimalPlace(value.ToString(null, CultureInfo.InvariantCulture));
		}

		// Token: 0x060007AE RID: 1966
		// RVA: 0x0000A90D File Offset: 0x00008B0D
		public static string ToString(Guid value)
		{
			return JsonConvert.ToString(value, '"');
		}

		// Token: 0x060007B0 RID: 1968
		// RVA: 0x0000A917 File Offset: 0x00008B17
		public static string ToString(TimeSpan value)
		{
			return JsonConvert.ToString(value, '"');
		}

		// Token: 0x060007B2 RID: 1970
		// RVA: 0x0000A936 File Offset: 0x00008B36
		public static string ToString(Uri value)
		{
			if (value == null)
			{
				return JsonConvert.Null;
			}
			return JsonConvert.ToString(value, '"');
		}

		// Token: 0x060007B4 RID: 1972
		// RVA: 0x0000A95D File Offset: 0x00008B5D
		public static string ToString(string value)
		{
			return JsonConvert.ToString(value, '"');
		}

		// Token: 0x060007B7 RID: 1975
		// RVA: 0x0003AFD4 File Offset: 0x000391D4
		public static string ToString(object value)
		{
			if (value == null)
			{
				return JsonConvert.Null;
			}
			PrimitiveTypeCode typeCode = ConvertUtils.GetTypeCode(value.GetType());
			PrimitiveTypeCode primitiveTypeCode = typeCode;
			switch (primitiveTypeCode)
			{
			case PrimitiveTypeCode.Char:
				return JsonConvert.ToString((char)value);
			case PrimitiveTypeCode.CharNullable:
			case PrimitiveTypeCode.BooleanNullable:
			case PrimitiveTypeCode.SByteNullable:
			case PrimitiveTypeCode.Int16Nullable:
			case PrimitiveTypeCode.UInt16Nullable:
			case PrimitiveTypeCode.Int32Nullable:
			case PrimitiveTypeCode.ByteNullable:
			case PrimitiveTypeCode.UInt32Nullable:
			case PrimitiveTypeCode.Int64Nullable:
			case PrimitiveTypeCode.UInt64Nullable:
			case PrimitiveTypeCode.SingleNullable:
			case PrimitiveTypeCode.DoubleNullable:
				break;
			case PrimitiveTypeCode.Boolean:
				return JsonConvert.ToString((bool)value);
			case PrimitiveTypeCode.SByte:
				return JsonConvert.ToString((sbyte)value);
			case PrimitiveTypeCode.Int16:
				return JsonConvert.ToString((short)value);
			case PrimitiveTypeCode.UInt16:
				return JsonConvert.ToString((ushort)value);
			case PrimitiveTypeCode.Int32:
				return JsonConvert.ToString((int)value);
			case PrimitiveTypeCode.Byte:
				return JsonConvert.ToString((byte)value);
			case PrimitiveTypeCode.UInt32:
				return JsonConvert.ToString((uint)value);
			case PrimitiveTypeCode.Int64:
				return JsonConvert.ToString((long)value);
			case PrimitiveTypeCode.UInt64:
				return JsonConvert.ToString((ulong)value);
			case PrimitiveTypeCode.Single:
				return JsonConvert.ToString((float)value);
			case PrimitiveTypeCode.Double:
				return JsonConvert.ToString((double)value);
			case PrimitiveTypeCode.DateTime:
				return JsonConvert.ToString((DateTime)value);
			default:
				switch (primitiveTypeCode)
				{
				case PrimitiveTypeCode.Decimal:
					return JsonConvert.ToString((decimal)value);
				case PrimitiveTypeCode.DecimalNullable:
				case PrimitiveTypeCode.GuidNullable:
					break;
				case PrimitiveTypeCode.Guid:
					return JsonConvert.ToString((Guid)value);
				case PrimitiveTypeCode.TimeSpan:
					return JsonConvert.ToString((TimeSpan)value);
				default:
					switch (primitiveTypeCode)
					{
					case PrimitiveTypeCode.Uri:
						return JsonConvert.ToString((Uri)value);
					case PrimitiveTypeCode.String:
						return JsonConvert.ToString((string)value);
					case PrimitiveTypeCode.DBNull:
						return JsonConvert.Null;
					}
					break;
				}
				break;
			}
			throw new ArgumentException(StringUtils.FormatWith("Unsupported type: {0}. Use the JsonSerializer class to get the object's JSON representation.", CultureInfo.InvariantCulture, value.GetType()));
		}

		// Token: 0x060007AF RID: 1967
		// RVA: 0x0003AFA0 File Offset: 0x000391A0
		internal static string ToString(Guid value, char quoteChar)
		{
			string str = value.ToString("D", CultureInfo.InvariantCulture);
			string text = quoteChar.ToString(CultureInfo.InvariantCulture);
			return text + str + text;
		}

		// Token: 0x060007B1 RID: 1969
		// RVA: 0x0000A921 File Offset: 0x00008B21
		internal static string ToString(TimeSpan value, char quoteChar)
		{
			return JsonConvert.ToString(value.ToString(), quoteChar);
		}

		// Token: 0x060007B3 RID: 1971
		// RVA: 0x0000A94F File Offset: 0x00008B4F
		internal static string ToString(Uri value, char quoteChar)
		{
			return JsonConvert.ToString(value.OriginalString, quoteChar);
		}

		// Token: 0x060007B5 RID: 1973
		// RVA: 0x0000A967 File Offset: 0x00008B67
		public static string ToString(string value, char delimiter)
		{
			return JsonConvert.ToString(value, delimiter, StringEscapeHandling.Default);
		}

		// Token: 0x0600079A RID: 1946
		// RVA: 0x0003AEF0 File Offset: 0x000390F0
		public static string ToString(DateTime value, DateFormatHandling format, DateTimeZoneHandling timeZoneHandling)
		{
			DateTime value2 = DateTimeUtils.EnsureDateTime(value, timeZoneHandling);
			string result;
			using (StringWriter stringWriter = StringUtils.CreateStringWriter(64))
			{
				stringWriter.Write('"');
				DateTimeUtils.WriteDateTimeString(stringWriter, value2, format, null, CultureInfo.InvariantCulture);
				stringWriter.Write('"');
				result = stringWriter.ToString();
			}
			return result;
		}

		// Token: 0x060007B6 RID: 1974
		// RVA: 0x0000A971 File Offset: 0x00008B71
		public static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling)
		{
			if (delimiter != '"' && delimiter != '\'')
			{
				throw new ArgumentException("Delimiter must be a single or double quote.", "delimiter");
			}
			return JavaScriptUtils.ToEscapedJavaScriptString(value, delimiter, true, stringEscapeHandling);
		}

		// Token: 0x060007A5 RID: 1957
		// RVA: 0x0000A824 File Offset: 0x00008A24
		internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			return JsonConvert.EnsureFloatFormat((double)value, JsonConvert.EnsureDecimalPlace((double)value, value.ToString("R", CultureInfo.InvariantCulture)), floatFormatHandling, quoteChar, nullable);
		}

		// Token: 0x060007A8 RID: 1960
		// RVA: 0x0000A89F File Offset: 0x00008A9F
		internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			return JsonConvert.EnsureFloatFormat(value, JsonConvert.EnsureDecimalPlace(value, value.ToString("R", CultureInfo.InvariantCulture)), floatFormatHandling, quoteChar, nullable);
		}
	}
}
