using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities.LinqBridge;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200015F RID: 351
	[ExtensionAttribute2]
	internal static class StringUtils
	{
		// Token: 0x040005D2 RID: 1490
		public const char CarriageReturn = '\r';

		// Token: 0x040005D0 RID: 1488
		public const string CarriageReturnLineFeed = "\r\n";

		// Token: 0x040005D1 RID: 1489
		public const string Empty = "";

		// Token: 0x040005D3 RID: 1491
		public const char LineFeed = '\n';

		// Token: 0x040005D4 RID: 1492
		public const char Tab = '\t';

		// Token: 0x06000DD2 RID: 3538
		// RVA: 0x0004CE10 File Offset: 0x0004B010
		public static StringWriter CreateStringWriter(int capacity)
		{
			StringBuilder sb = new StringBuilder(capacity);
			return new StringWriter(sb, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000DDA RID: 3546
		// RVA: 0x0000E869 File Offset: 0x0000CA69
		[ExtensionAttribute2]
		public static bool EndsWith(string source, char value)
		{
			return source.Length > 0 && source[source.Length - 1] == value;
		}

		// Token: 0x06000DD5 RID: 3541
		// RVA: 0x0004CEAC File Offset: 0x0004B0AC
		[ExtensionAttribute2]
		public static TSource ForgivingCaseSensitiveFind<TSource>(IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (valueSelector == null)
			{
				throw new ArgumentNullException("valueSelector");
			}
			IEnumerable<TSource> source2 = Enumerable.Where<TSource>(source, (TSource s) => string.Equals(valueSelector(s), testValue, StringComparison.OrdinalIgnoreCase));
			if (Enumerable.Count<TSource>(source2) <= 1)
			{
				return Enumerable.SingleOrDefault<TSource>(source2);
			}
			IEnumerable<TSource> source3 = Enumerable.Where<TSource>(source, (TSource s) => string.Equals(valueSelector(s), testValue, StringComparison.Ordinal));
			return Enumerable.SingleOrDefault<TSource>(source3);
		}

		// Token: 0x06000DCB RID: 3531
		// RVA: 0x0004CD28 File Offset: 0x0004AF28
		[ExtensionAttribute2]
		public static string FormatWith(string format, IFormatProvider provider, object arg0)
		{
			return StringUtils.FormatWith(format, provider, new object[]
			{
				arg0
			});
		}

		// Token: 0x06000DCF RID: 3535
		// RVA: 0x0000E820 File Offset: 0x0000CA20
		[ExtensionAttribute2]
		private static string FormatWith(string format, IFormatProvider provider, params object[] args)
		{
			ValidationUtils.ArgumentNotNull(format, "format");
			return string.Format(provider, format, args);
		}

		// Token: 0x06000DCC RID: 3532
		// RVA: 0x0004CD48 File Offset: 0x0004AF48
		[ExtensionAttribute2]
		public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1)
		{
			return StringUtils.FormatWith(format, provider, new object[]
			{
				arg0,
				arg1
			});
		}

		// Token: 0x06000DCD RID: 3533
		// RVA: 0x0004CD6C File Offset: 0x0004AF6C
		[ExtensionAttribute2]
		public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2)
		{
			return StringUtils.FormatWith(format, provider, new object[]
			{
				arg0,
				arg1,
				arg2
			});
		}

		// Token: 0x06000DCE RID: 3534
		// RVA: 0x0004CD98 File Offset: 0x0004AF98
		[ExtensionAttribute2]
		public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3)
		{
			return StringUtils.FormatWith(format, provider, new object[]
			{
				arg0,
				arg1,
				arg2,
				arg3
			});
		}

		// Token: 0x06000DD3 RID: 3539
		// RVA: 0x0004CE34 File Offset: 0x0004B034
		public static int? GetLength(string value)
		{
			if (value == null)
			{
				return null;
			}
			return new int?(value.Length);
		}

		// Token: 0x06000DD7 RID: 3543
		// RVA: 0x0000E842 File Offset: 0x0000CA42
		public static bool IsHighSurrogate(char c)
		{
			return char.IsHighSurrogate(c);
		}

		// Token: 0x06000DD8 RID: 3544
		// RVA: 0x0000E84A File Offset: 0x0000CA4A
		public static bool IsLowSurrogate(char c)
		{
			return char.IsLowSurrogate(c);
		}

		// Token: 0x06000DD0 RID: 3536
		// RVA: 0x0004CDC8 File Offset: 0x0004AFC8
		public static bool IsWhiteSpace(string s)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (s.Length == 0)
			{
				return false;
			}
			for (int i = 0; i < s.Length; i++)
			{
				if (!char.IsWhiteSpace(s[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000DD1 RID: 3537
		// RVA: 0x0000E835 File Offset: 0x0000CA35
		public static string NullEmptyString(string s)
		{
			if (!string.IsNullOrEmpty(s))
			{
				return s;
			}
			return null;
		}

		// Token: 0x06000DD9 RID: 3545
		// RVA: 0x0000E852 File Offset: 0x0000CA52
		[ExtensionAttribute2]
		public static bool StartsWith(string source, char value)
		{
			return source.Length > 0 && source[0] == value;
		}

		// Token: 0x06000DD6 RID: 3542
		// RVA: 0x0004CF34 File Offset: 0x0004B134
		public static string ToCamelCase(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return s;
			}
			if (!char.IsUpper(s[0]))
			{
				return s;
			}
			char[] array = s.ToCharArray();
			for (int i = 0; i < array.Length; i++)
			{
				bool flag = i + 1 < array.Length;
				if (i > 0 && flag && !char.IsUpper(array[i + 1]))
				{
					break;
				}
				array[i] = char.ToLower(array[i], CultureInfo.InvariantCulture);
			}
			return new string(array);
		}

		// Token: 0x06000DD4 RID: 3540
		// RVA: 0x0004CE5C File Offset: 0x0004B05C
		public static void ToCharAsUnicode(char c, char[] buffer)
		{
			buffer[0] = '\\';
			buffer[1] = 'u';
			buffer[2] = MathUtils.IntToHex((int)(c >> 12 & '\u000f'));
			buffer[3] = MathUtils.IntToHex((int)(c >> 8 & '\u000f'));
			buffer[4] = MathUtils.IntToHex((int)(c >> 4 & '\u000f'));
			buffer[5] = MathUtils.IntToHex((int)(c & '\u000f'));
		}
	}
}
