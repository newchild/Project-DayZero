using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200014F RID: 335
	[ExtensionAttribute2]
	internal static class DateTimeUtils
	{
		// Token: 0x0400059C RID: 1436
		private const int DaysPer100Years = 36524;

		// Token: 0x0400059D RID: 1437
		private const int DaysPer400Years = 146097;

		// Token: 0x0400059E RID: 1438
		private const int DaysPer4Years = 1461;

		// Token: 0x0400059F RID: 1439
		private const int DaysPerYear = 365;

		// Token: 0x040005A2 RID: 1442
		private static readonly int[] DaysToMonth365;

		// Token: 0x040005A3 RID: 1443
		private static readonly int[] DaysToMonth366;

		// Token: 0x040005A1 RID: 1441
		internal static readonly long InitialJavaScriptDateTicks;

		// Token: 0x040005A0 RID: 1440
		private const long TicksPerDay = 864000000000L;

		// Token: 0x06000D12 RID: 3346
		// RVA: 0x0000DE85 File Offset: 0x0000C085
		static DateTimeUtils()
		{
			DateTimeUtils.InitialJavaScriptDateTicks = 621355968000000000L;
			DateTimeUtils.DaysToMonth365 = new int[]
			{
				0,
				31,
				59,
				90,
				120,
				151,
				181,
				212,
				243,
				273,
				304,
				334,
				365
			};
			DateTimeUtils.DaysToMonth366 = new int[]
			{
				0,
				31,
				60,
				91,
				121,
				152,
				182,
				213,
				244,
				274,
				305,
				335,
				366
			};
		}

		// Token: 0x06000D1B RID: 3355
		// RVA: 0x0000DEF0 File Offset: 0x0000C0F0
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime)
		{
			return DateTimeUtils.ConvertDateTimeToJavaScriptTicks(dateTime, true);
		}

		// Token: 0x06000D1A RID: 3354
		// RVA: 0x0004A348 File Offset: 0x00048548
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset)
		{
			long universialTicks = DateTimeUtils.ToUniversalTicks(dateTime, offset);
			return DateTimeUtils.UniversialTicksToJavaScriptTicks(universialTicks);
		}

		// Token: 0x06000D1C RID: 3356
		// RVA: 0x0004A364 File Offset: 0x00048564
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc)
		{
			long universialTicks = convertToUtc ? DateTimeUtils.ToUniversalTicks(dateTime) : dateTime.Ticks;
			return DateTimeUtils.UniversialTicksToJavaScriptTicks(universialTicks);
		}

		// Token: 0x06000D1E RID: 3358
		// RVA: 0x0004A3AC File Offset: 0x000485AC
		internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks)
		{
			DateTime result = new DateTime(javaScriptTicks * 10000L + DateTimeUtils.InitialJavaScriptDateTicks, DateTimeKind.Utc);
			return result;
		}

		// Token: 0x06000D26 RID: 3366
		// RVA: 0x0000DEF9 File Offset: 0x0000C0F9
		private static void CopyIntToCharArray(char[] chars, int start, int value, int digits)
		{
			while (digits-- != 0)
			{
				chars[start + digits] = (char)(value % 10 + 48);
				value /= 10;
			}
		}

		// Token: 0x06000D15 RID: 3349
		// RVA: 0x0004A1FC File Offset: 0x000483FC
		internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone)
		{
			switch (timeZone)
			{
			case DateTimeZoneHandling.Local:
				value = DateTimeUtils.SwitchToLocalTime(value);
				break;
			case DateTimeZoneHandling.Utc:
				value = DateTimeUtils.SwitchToUtcTime(value);
				break;
			case DateTimeZoneHandling.Unspecified:
				value = new DateTime(value.Ticks, DateTimeKind.Unspecified);
				break;
			case DateTimeZoneHandling.RoundtripKind:
				break;
			default:
				throw new ArgumentException("Invalid date time handling value.");
			}
			return value;
		}

		// Token: 0x06000D28 RID: 3368
		// RVA: 0x0004A9F4 File Offset: 0x00048BF4
		private static void GetDateValues(DateTime td, out int year, out int month, out int day)
		{
			long ticks = td.Ticks;
			int i = (int)(ticks / 864000000000L);
			int num = i / 146097;
			i -= num * 146097;
			int num2 = i / 36524;
			if (num2 == 4)
			{
				num2 = 3;
			}
			i -= num2 * 36524;
			int num3 = i / 1461;
			i -= num3 * 1461;
			int num4 = i / 365;
			if (num4 == 4)
			{
				num4 = 3;
			}
			year = num * 400 + num2 * 100 + num3 * 4 + num4 + 1;
			i -= num4 * 365;
			int[] array = (num4 == 3 && (num3 != 24 || num2 == 3)) ? DateTimeUtils.DaysToMonth366 : DateTimeUtils.DaysToMonth365;
			int num5 = i >> 6;
			while (i >= array[num5])
			{
				num5++;
			}
			month = num5;
			day = i - array[num5 - 1] + 1;
		}

		// Token: 0x06000D13 RID: 3347
		// RVA: 0x0000DEC3 File Offset: 0x0000C0C3
		[ExtensionAttribute2]
		public static TimeSpan GetUtcOffset(DateTime d)
		{
			return TimeZone.CurrentTimeZone.GetUtcOffset(d);
		}

		// Token: 0x06000D16 RID: 3350
		// RVA: 0x0004A250 File Offset: 0x00048450
		private static DateTime SwitchToLocalTime(DateTime value)
		{
			switch (value.Kind)
			{
			case DateTimeKind.Unspecified:
				return new DateTime(value.Ticks, DateTimeKind.Local);
			case DateTimeKind.Utc:
				return value.ToLocalTime();
			case DateTimeKind.Local:
				return value;
			default:
				return value;
			}
		}

		// Token: 0x06000D17 RID: 3351
		// RVA: 0x0004A290 File Offset: 0x00048490
		private static DateTime SwitchToUtcTime(DateTime value)
		{
			switch (value.Kind)
			{
			case DateTimeKind.Unspecified:
				return new DateTime(value.Ticks, DateTimeKind.Utc);
			case DateTimeKind.Utc:
				return value;
			case DateTimeKind.Local:
				return value.ToUniversalTime();
			default:
				return value;
			}
		}

		// Token: 0x06000D14 RID: 3348
		// RVA: 0x0004A1C0 File Offset: 0x000483C0
		public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind)
		{
			switch (kind)
			{
			case DateTimeKind.Unspecified:
				return XmlDateTimeSerializationMode.Unspecified;
			case DateTimeKind.Utc:
				return XmlDateTimeSerializationMode.Utc;
			case DateTimeKind.Local:
				return XmlDateTimeSerializationMode.Local;
			default:
				throw MiscellaneousUtils.CreateArgumentOutOfRangeException("kind", kind, "Unexpected DateTimeKind value.");
			}
		}

		// Token: 0x06000D18 RID: 3352
		// RVA: 0x0000DED0 File Offset: 0x0000C0D0
		private static long ToUniversalTicks(DateTime dateTime)
		{
			if (dateTime.Kind == DateTimeKind.Utc)
			{
				return dateTime.Ticks;
			}
			return DateTimeUtils.ToUniversalTicks(dateTime, DateTimeUtils.GetUtcOffset(dateTime));
		}

		// Token: 0x06000D19 RID: 3353
		// RVA: 0x0004A2D0 File Offset: 0x000484D0
		private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset)
		{
			if (dateTime.Kind == DateTimeKind.Utc || dateTime == DateTime.MaxValue || dateTime == DateTime.MinValue)
			{
				return dateTime.Ticks;
			}
			long num = dateTime.Ticks - offset.Ticks;
			if (num > 3155378975999999999L)
			{
				return 3155378975999999999L;
			}
			if (num < 0L)
			{
				return 0L;
			}
			return num;
		}

		// Token: 0x06000D22 RID: 3362
		// RVA: 0x0004A6E8 File Offset: 0x000488E8
		private static bool TryParseDateExact(string text, DateParseHandling dateParseHandling, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out object dt)
		{
			DateTime dateTime;
			if (DateTime.TryParseExact(text, dateFormatString, culture, DateTimeStyles.RoundtripKind, out dateTime))
			{
				dateTime = DateTimeUtils.EnsureDateTime(dateTime, dateTimeZoneHandling);
				dt = dateTime;
				return true;
			}
			dt = null;
			return false;
		}

		// Token: 0x06000D1F RID: 3359
		// RVA: 0x0004A3D4 File Offset: 0x000485D4
		internal static bool TryParseDateIso(string text, DateParseHandling dateParseHandling, DateTimeZoneHandling dateTimeZoneHandling, out object dt)
		{
			DateTimeParser dateTimeParser = default(DateTimeParser);
			if (!dateTimeParser.Parse(text))
			{
				dt = null;
				return false;
			}
			DateTime dateTime = new DateTime(dateTimeParser.Year, dateTimeParser.Month, dateTimeParser.Day, dateTimeParser.Hour, dateTimeParser.Minute, dateTimeParser.Second);
			dateTime = dateTime.AddTicks((long)dateTimeParser.Fraction);
			switch (dateTimeParser.Zone)
			{
			case ParserTimeZone.Utc:
				dateTime = new DateTime(dateTime.Ticks, DateTimeKind.Utc);
				break;
			case ParserTimeZone.LocalWestOfUtc:
			{
				TimeSpan timeSpan = new TimeSpan(dateTimeParser.ZoneHour, dateTimeParser.ZoneMinute, 0);
				long num = dateTime.Ticks + timeSpan.Ticks;
				if (num <= DateTime.MaxValue.Ticks)
				{
					dateTime = new DateTime(num, DateTimeKind.Utc).ToLocalTime();
				}
				else
				{
					num += DateTimeUtils.GetUtcOffset(dateTime).Ticks;
					if (num > DateTime.MaxValue.Ticks)
					{
						num = DateTime.MaxValue.Ticks;
					}
					dateTime = new DateTime(num, DateTimeKind.Local);
				}
				break;
			}
			case ParserTimeZone.LocalEastOfUtc:
			{
				TimeSpan timeSpan2 = new TimeSpan(dateTimeParser.ZoneHour, dateTimeParser.ZoneMinute, 0);
				long num = dateTime.Ticks - timeSpan2.Ticks;
				if (num >= DateTime.MinValue.Ticks)
				{
					dateTime = new DateTime(num, DateTimeKind.Utc).ToLocalTime();
				}
				else
				{
					num += DateTimeUtils.GetUtcOffset(dateTime).Ticks;
					if (num < DateTime.MinValue.Ticks)
					{
						num = DateTime.MinValue.Ticks;
					}
					dateTime = new DateTime(num, DateTimeKind.Local);
				}
				break;
			}
			}
			dt = DateTimeUtils.EnsureDateTime(dateTime, dateTimeZoneHandling);
			return true;
		}

		// Token: 0x06000D21 RID: 3361
		// RVA: 0x0004A63C File Offset: 0x0004883C
		private static bool TryParseDateMicrosoft(string text, DateParseHandling dateParseHandling, DateTimeZoneHandling dateTimeZoneHandling, out object dt)
		{
			string text2 = text.Substring(6, text.Length - 8);
			DateTimeKind dateTimeKind = DateTimeKind.Utc;
			int num = text2.IndexOf('+', 1);
			if (num == -1)
			{
				num = text2.IndexOf('-', 1);
			}
			if (num != -1)
			{
				dateTimeKind = DateTimeKind.Local;
				text2 = text2.Substring(0, num);
			}
			long javaScriptTicks;
			if (!long.TryParse(text2, NumberStyles.Integer, CultureInfo.InvariantCulture, out javaScriptTicks))
			{
				dt = null;
				return false;
			}
			DateTime dateTime = DateTimeUtils.ConvertJavaScriptTicksToDateTime(javaScriptTicks);
			DateTime value;
			switch (dateTimeKind)
			{
			case DateTimeKind.Unspecified:
				value = DateTime.SpecifyKind(dateTime.ToLocalTime(), DateTimeKind.Unspecified);
				goto IL_8E;
			case DateTimeKind.Local:
				value = dateTime.ToLocalTime();
				goto IL_8E;
			}
			value = dateTime;
			IL_8E:
			dt = DateTimeUtils.EnsureDateTime(value, dateTimeZoneHandling);
			return true;
		}

		// Token: 0x06000D20 RID: 3360
		// RVA: 0x0004A594 File Offset: 0x00048794
		internal static bool TryParseDateTime(string s, DateParseHandling dateParseHandling, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out object dt)
		{
			if (s.Length > 0)
			{
				if (s[0] == '/')
				{
					if (s.StartsWith("/Date(", StringComparison.Ordinal) && s.EndsWith(")/", StringComparison.Ordinal) && DateTimeUtils.TryParseDateMicrosoft(s, dateParseHandling, dateTimeZoneHandling, out dt))
					{
						return true;
					}
				}
				else if (s.Length >= 19 && s.Length <= 40 && char.IsDigit(s[0]) && s[10] == 'T' && DateTimeUtils.TryParseDateIso(s, dateParseHandling, dateTimeZoneHandling, out dt))
				{
					return true;
				}
				if (!string.IsNullOrEmpty(dateFormatString) && DateTimeUtils.TryParseDateExact(s, dateParseHandling, dateTimeZoneHandling, dateFormatString, culture, out dt))
				{
					return true;
				}
			}
			dt = null;
			return false;
		}

		// Token: 0x06000D1D RID: 3357
		// RVA: 0x0004A38C File Offset: 0x0004858C
		private static long UniversialTicksToJavaScriptTicks(long universialTicks)
		{
			return (universialTicks - DateTimeUtils.InitialJavaScriptDateTicks) / 10000L;
		}

		// Token: 0x06000D27 RID: 3367
		// RVA: 0x0004A980 File Offset: 0x00048B80
		internal static int WriteDateTimeOffset(char[] chars, int start, TimeSpan offset, DateFormatHandling format)
		{
			chars[start++] = ((offset.Ticks >= 0L) ? '+' : '-');
			int value = Math.Abs(offset.Hours);
			DateTimeUtils.CopyIntToCharArray(chars, start, value, 2);
			start += 2;
			if (format == DateFormatHandling.IsoDateFormat)
			{
				chars[start++] = ':';
			}
			int value2 = Math.Abs(offset.Minutes);
			DateTimeUtils.CopyIntToCharArray(chars, start, value2, 2);
			start += 2;
			return start;
		}

		// Token: 0x06000D23 RID: 3363
		// RVA: 0x0004A720 File Offset: 0x00048920
		internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture)
		{
			if (string.IsNullOrEmpty(formatString))
			{
				char[] array = new char[64];
				int count = DateTimeUtils.WriteDateTimeString(array, 0, value, null, value.Kind, format);
				writer.Write(array, 0, count);
				return;
			}
			writer.Write(value.ToString(formatString, culture));
		}

		// Token: 0x06000D24 RID: 3364
		// RVA: 0x0004A774 File Offset: 0x00048974
		internal static int WriteDateTimeString(char[] chars, int start, DateTime value, TimeSpan? offset, DateTimeKind kind, DateFormatHandling format)
		{
			int num2;
			if (format == DateFormatHandling.MicrosoftDateFormat)
			{
				TimeSpan offset2 = offset ?? DateTimeUtils.GetUtcOffset(value);
				long num = DateTimeUtils.ConvertDateTimeToJavaScriptTicks(value, offset2);
				"\\/Date(".CopyTo(0, chars, start, 7);
				num2 = start + 7;
				string text = num.ToString(CultureInfo.InvariantCulture);
				text.CopyTo(0, chars, num2, text.Length);
				num2 += text.Length;
				switch (kind)
				{
				case DateTimeKind.Unspecified:
					if (value != DateTime.MaxValue && value != DateTime.MinValue)
					{
						num2 = DateTimeUtils.WriteDateTimeOffset(chars, num2, offset2, format);
					}
					break;
				case DateTimeKind.Local:
					num2 = DateTimeUtils.WriteDateTimeOffset(chars, num2, offset2, format);
					break;
				}
				")\\/".CopyTo(0, chars, num2, 3);
				num2 += 3;
			}
			else
			{
				num2 = DateTimeUtils.WriteDefaultIsoDate(chars, start, value);
				switch (kind)
				{
				case DateTimeKind.Utc:
					chars[num2++] = 'Z';
					break;
				case DateTimeKind.Local:
					num2 = DateTimeUtils.WriteDateTimeOffset(chars, num2, offset ?? DateTimeUtils.GetUtcOffset(value), format);
					break;
				}
			}
			return num2;
		}

		// Token: 0x06000D25 RID: 3365
		// RVA: 0x0004A898 File Offset: 0x00048A98
		internal static int WriteDefaultIsoDate(char[] chars, int start, DateTime dt)
		{
			int num = 19;
			int value;
			int value2;
			int value3;
			DateTimeUtils.GetDateValues(dt, out value, out value2, out value3);
			DateTimeUtils.CopyIntToCharArray(chars, start, value, 4);
			chars[start + 4] = '-';
			DateTimeUtils.CopyIntToCharArray(chars, start + 5, value2, 2);
			chars[start + 7] = '-';
			DateTimeUtils.CopyIntToCharArray(chars, start + 8, value3, 2);
			chars[start + 10] = 'T';
			DateTimeUtils.CopyIntToCharArray(chars, start + 11, dt.Hour, 2);
			chars[start + 13] = ':';
			DateTimeUtils.CopyIntToCharArray(chars, start + 14, dt.Minute, 2);
			chars[start + 16] = ':';
			DateTimeUtils.CopyIntToCharArray(chars, start + 17, dt.Second, 2);
			int num2 = (int)(dt.Ticks % 10000000L);
			if (num2 != 0)
			{
				int num3 = 7;
				while (num2 % 10 == 0)
				{
					num3--;
					num2 /= 10;
				}
				chars[start + 19] = '.';
				DateTimeUtils.CopyIntToCharArray(chars, start + 20, num2, num3);
				num += num3 + 1;
			}
			return start + num;
		}
	}
}
