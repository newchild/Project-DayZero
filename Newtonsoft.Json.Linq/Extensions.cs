using Newtonsoft.Json.Utilities;
using Newtonsoft.Json.Utilities.LinqBridge;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000D8 RID: 216
	[ExtensionAttribute2]
	public static class Extensions
	{
		// Token: 0x0600082C RID: 2092
		// RVA: 0x0000ADFF File Offset: 0x00008FFF
		[ExtensionAttribute2]
		public static IJEnumerable<JToken> Ancestors<T>(IEnumerable<T> source) where T : JToken
		{
			ValidationUtils.ArgumentNotNull(source, "source");
			return Extensions.AsJEnumerable(Enumerable.SelectMany<T, JToken>(source, (T j) => j.Ancestors()));
		}

		// Token: 0x0600082D RID: 2093
		// RVA: 0x0000AE23 File Offset: 0x00009023
		[ExtensionAttribute2]
		public static IJEnumerable<JToken> AncestorsAndSelf<T>(IEnumerable<T> source) where T : JToken
		{
			ValidationUtils.ArgumentNotNull(source, "source");
			return Extensions.AsJEnumerable(Enumerable.SelectMany<T, JToken>(source, (T j) => j.AncestorsAndSelf()));
		}

		// Token: 0x0600083C RID: 2108
		// RVA: 0x0000AF26 File Offset: 0x00009126
		[ExtensionAttribute2]
		public static IJEnumerable<JToken> AsJEnumerable(IEnumerable<JToken> source)
		{
			return Extensions.AsJEnumerable<JToken>(source);
		}

		// Token: 0x0600083D RID: 2109
		// RVA: 0x0000AF2E File Offset: 0x0000912E
		[ExtensionAttribute2]
		public static IJEnumerable<T> AsJEnumerable<T>(IEnumerable<T> source) where T : JToken
		{
			if (source == null)
			{
				return null;
			}
			if (source is IJEnumerable<T>)
			{
				return (IJEnumerable<T>)source;
			}
			return new JEnumerable<T>(source);
		}

		// Token: 0x06000838 RID: 2104
		// RVA: 0x0000AEF5 File Offset: 0x000090F5
		[ExtensionAttribute2]
		public static IJEnumerable<JToken> Children<T>(IEnumerable<T> source) where T : JToken
		{
			return Extensions.AsJEnumerable(Extensions.Children<T, JToken>(source));
		}

		// Token: 0x06000839 RID: 2105
		// RVA: 0x0000AF02 File Offset: 0x00009102
		[ExtensionAttribute2]
		public static IEnumerable<U> Children<T, U>(IEnumerable<T> source) where T : JToken
		{
			ValidationUtils.ArgumentNotNull(source, "source");
			return Extensions.Convert<JToken, U>(Enumerable.SelectMany<T, JToken>(source, (T c) => c.Children()));
		}

		// Token: 0x0600083A RID: 2106
		// RVA: 0x0003C220 File Offset: 0x0003A420
		[ExtensionAttribute2]
		internal static IEnumerable<U> Convert<T, U>(IEnumerable<T> source) where T : JToken
		{
			Extensions.<Convert>d__11<T, U> <Convert>d__ = new Extensions.<Convert>d__11<T, U>(-2);
			<Convert>d__.<>3__source = source;
			return <Convert>d__;
		}

		// Token: 0x0600083B RID: 2107
		// RVA: 0x0003C240 File Offset: 0x0003A440
		[ExtensionAttribute2]
		internal static U Convert<T, U>(T token) where T : JToken
		{
			if (token == null)
			{
				return default(U);
			}
			if (token is U && typeof(U) != typeof(IComparable) && typeof(U) != typeof(IFormattable))
			{
				return (U)((object)token);
			}
			JValue jValue = token as JValue;
			if (jValue == null)
			{
				throw new InvalidCastException(StringUtils.FormatWith("Cannot cast {0} to {1}.", CultureInfo.InvariantCulture, token.GetType(), typeof(T)));
			}
			if (jValue.Value is U)
			{
				return (U)((object)jValue.Value);
			}
			Type type = typeof(U);
			if (ReflectionUtils.IsNullableType(type))
			{
				if (jValue.Value == null)
				{
					return default(U);
				}
				type = Nullable.GetUnderlyingType(type);
			}
			return (U)((object)System.Convert.ChangeType(jValue.Value, type, CultureInfo.InvariantCulture));
		}

		// Token: 0x0600082E RID: 2094
		// RVA: 0x0000AE47 File Offset: 0x00009047
		[ExtensionAttribute2]
		public static IJEnumerable<JToken> Descendants<T>(IEnumerable<T> source) where T : JContainer
		{
			ValidationUtils.ArgumentNotNull(source, "source");
			return Extensions.AsJEnumerable(Enumerable.SelectMany<T, JToken>(source, (T j) => j.Descendants()));
		}

		// Token: 0x0600082F RID: 2095
		// RVA: 0x0000AE6B File Offset: 0x0000906B
		[ExtensionAttribute2]
		public static IJEnumerable<JToken> DescendantsAndSelf<T>(IEnumerable<T> source) where T : JContainer
		{
			ValidationUtils.ArgumentNotNull(source, "source");
			return Extensions.AsJEnumerable(Enumerable.SelectMany<T, JToken>(source, (T j) => j.DescendantsAndSelf()));
		}

		// Token: 0x06000830 RID: 2096
		// RVA: 0x0000AE8F File Offset: 0x0000908F
		[ExtensionAttribute2]
		public static IJEnumerable<JProperty> Properties(IEnumerable<JObject> source)
		{
			ValidationUtils.ArgumentNotNull(source, "source");
			return Extensions.AsJEnumerable<JProperty>(Enumerable.SelectMany<JObject, JProperty>(source, (JObject d) => d.Properties()));
		}

		// Token: 0x06000835 RID: 2101
		// RVA: 0x0000AEED File Offset: 0x000090ED
		[ExtensionAttribute2]
		public static U Value<U>(IEnumerable<JToken> value)
		{
			return Extensions.Value<JToken, U>(value);
		}

		// Token: 0x06000836 RID: 2102
		// RVA: 0x0003C1C8 File Offset: 0x0003A3C8
		[ExtensionAttribute2]
		public static U Value<T, U>(IEnumerable<T> value) where T : JToken
		{
			ValidationUtils.ArgumentNotNull(value, "source");
			JToken jToken = value as JToken;
			if (jToken == null)
			{
				throw new ArgumentException("Source value must be a JToken.");
			}
			return Extensions.Convert<JToken, U>(jToken);
		}

		// Token: 0x06000832 RID: 2098
		// RVA: 0x0000AED2 File Offset: 0x000090D2
		[ExtensionAttribute2]
		public static IJEnumerable<JToken> Values(IEnumerable<JToken> source)
		{
			return Extensions.Values(source, null);
		}

		// Token: 0x06000834 RID: 2100
		// RVA: 0x0000AEE4 File Offset: 0x000090E4
		[ExtensionAttribute2]
		public static IEnumerable<U> Values<U>(IEnumerable<JToken> source)
		{
			return Extensions.Values<JToken, U>(source, null);
		}

		// Token: 0x06000831 RID: 2097
		// RVA: 0x0000AEC4 File Offset: 0x000090C4
		[ExtensionAttribute2]
		public static IJEnumerable<JToken> Values(IEnumerable<JToken> source, object key)
		{
			return Extensions.AsJEnumerable(Extensions.Values<JToken, JToken>(source, key));
		}

		// Token: 0x06000833 RID: 2099
		// RVA: 0x0000AEDB File Offset: 0x000090DB
		[ExtensionAttribute2]
		public static IEnumerable<U> Values<U>(IEnumerable<JToken> source, object key)
		{
			return Extensions.Values<JToken, U>(source, key);
		}

		// Token: 0x06000837 RID: 2103
		// RVA: 0x0003C1FC File Offset: 0x0003A3FC
		[ExtensionAttribute2]
		internal static IEnumerable<U> Values<T, U>(IEnumerable<T> source, object key) where T : JToken
		{
			Extensions.<Values>d__6<T, U> <Values>d__ = new Extensions.<Values>d__6<T, U>(-2);
			<Values>d__.<>3__source = source;
			<Values>d__.<>3__key = key;
			return <Values>d__;
		}
	}
}
