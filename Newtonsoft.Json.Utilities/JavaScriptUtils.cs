using Newtonsoft.Json.Utilities.LinqBridge;
using System;
using System.Collections.Generic;
using System.IO;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000155 RID: 341
	internal static class JavaScriptUtils
	{
		// Token: 0x040005B0 RID: 1456
		internal static readonly bool[] DoubleQuoteCharEscapeFlags;

		// Token: 0x040005AE RID: 1454
		private const string EscapedUnicodeText = "!";

		// Token: 0x040005B1 RID: 1457
		internal static readonly bool[] HtmlCharEscapeFlags;

		// Token: 0x040005AF RID: 1455
		internal static readonly bool[] SingleQuoteCharEscapeFlags;

		// Token: 0x06000D62 RID: 3426
		// RVA: 0x0004B22C File Offset: 0x0004942C
		static JavaScriptUtils()
		{
			JavaScriptUtils.SingleQuoteCharEscapeFlags = new bool[128];
			JavaScriptUtils.DoubleQuoteCharEscapeFlags = new bool[128];
			JavaScriptUtils.HtmlCharEscapeFlags = new bool[128];
			IList<char> list = new List<char>
			{
				'\n',
				'\r',
				'\t',
				'\\',
				'\f',
				'\b'
			};
			for (int i = 0; i < 32; i++)
			{
				list.Add((char)i);
			}
			foreach (char current in Enumerable.Union<char>(list, new char[]
			{
				'\''
			}))
			{
				JavaScriptUtils.SingleQuoteCharEscapeFlags[(int)current] = true;
			}
			foreach (char current2 in Enumerable.Union<char>(list, new char[]
			{
				'"'
			}))
			{
				JavaScriptUtils.DoubleQuoteCharEscapeFlags[(int)current2] = true;
			}
			foreach (char current3 in Enumerable.Union<char>(list, new char[]
			{
				'"',
				'\'',
				'<',
				'>',
				'&'
			}))
			{
				JavaScriptUtils.HtmlCharEscapeFlags[(int)current3] = true;
			}
		}

		// Token: 0x06000D63 RID: 3427
		// RVA: 0x0000E418 File Offset: 0x0000C618
		public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar)
		{
			if (stringEscapeHandling == StringEscapeHandling.EscapeHtml)
			{
				return JavaScriptUtils.HtmlCharEscapeFlags;
			}
			if (quoteChar == '"')
			{
				return JavaScriptUtils.DoubleQuoteCharEscapeFlags;
			}
			return JavaScriptUtils.SingleQuoteCharEscapeFlags;
		}

		// Token: 0x06000D64 RID: 3428
		// RVA: 0x0004B3BC File Offset: 0x000495BC
		public static bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags)
		{
			if (s == null)
			{
				return false;
			}
			for (int i = 0; i < s.Length; i++)
			{
				char c = s[i];
				if ((int)c >= charEscapeFlags.Length || charEscapeFlags[(int)c])
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000D66 RID: 3430
		// RVA: 0x0000E434 File Offset: 0x0000C634
		public static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters)
		{
			return JavaScriptUtils.ToEscapedJavaScriptString(value, delimiter, appendDelimiters, StringEscapeHandling.Default);
		}

		// Token: 0x06000D67 RID: 3431
		// RVA: 0x0004B630 File Offset: 0x00049830
		public static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling)
		{
			bool[] charEscapeFlags = JavaScriptUtils.GetCharEscapeFlags(stringEscapeHandling, delimiter);
			string result;
			using (StringWriter stringWriter = StringUtils.CreateStringWriter(StringUtils.GetLength(value) ?? 16))
			{
				char[] array = null;
				JavaScriptUtils.WriteEscapedJavaScriptString(stringWriter, value, delimiter, appendDelimiters, charEscapeFlags, stringEscapeHandling, ref array);
				result = stringWriter.ToString();
			}
			return result;
		}

		// Token: 0x06000D65 RID: 3429
		// RVA: 0x0004B3FC File Offset: 0x000495FC
		public static void WriteEscapedJavaScriptString(TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, ref char[] writeBuffer)
		{
			if (appendDelimiters)
			{
				writer.Write(delimiter);
			}
			if (s != null)
			{
				int num = 0;
				for (int i = 0; i < s.Length; i++)
				{
					char c = s[i];
					if ((int)c >= charEscapeFlags.Length || charEscapeFlags[(int)c])
					{
						char c2 = c;
						string text;
						if (c2 <= '\\')
						{
							switch (c2)
							{
							case '\b':
								text = "\\b";
								break;
							case '\t':
								text = "\\t";
								break;
							case '\n':
								text = "\\n";
								break;
							case '\v':
								goto IL_C3;
							case '\f':
								text = "\\f";
								break;
							case '\r':
								text = "\\r";
								break;
							default:
								if (c2 != '\\')
								{
									goto IL_C3;
								}
								text = "\\\\";
								break;
							}
						}
						else
						{
							if (c2 != '\u0085')
							{
								switch (c2)
								{
								case '\u2028':
									text = "\\u2028";
									goto IL_12E;
								case '\u2029':
									text = "\\u2029";
									goto IL_12E;
								}
								goto IL_C3;
							}
							text = "\\u0085";
						}
						IL_12E:
						if (text == null)
						{
							goto IL_1C5;
						}
						bool flag = string.Equals(text, "!");
						if (i > num)
						{
							int num2 = i - num + (flag ? 6 : 0);
							int num3 = flag ? 6 : 0;
							if (writeBuffer == null || writeBuffer.Length < num2)
							{
								char[] array = new char[num2];
								if (flag)
								{
									Array.Copy(writeBuffer, array, 6);
								}
								writeBuffer = array;
							}
							s.CopyTo(num, writeBuffer, num3, num2 - num3);
							writer.Write(writeBuffer, num3, num2 - num3);
						}
						num = i + 1;
						if (!flag)
						{
							writer.Write(text);
							goto IL_1C5;
						}
						writer.Write(writeBuffer, 0, 6);
						goto IL_1C5;
						IL_C3:
						if ((int)c >= charEscapeFlags.Length)
						{
							if (stringEscapeHandling != StringEscapeHandling.EscapeNonAscii)
							{
								text = null;
								goto IL_12E;
							}
						}
						if (c == '\'' && stringEscapeHandling != StringEscapeHandling.EscapeHtml)
						{
							text = "\\'";
							goto IL_12E;
						}
						if (c == '"' && stringEscapeHandling != StringEscapeHandling.EscapeHtml)
						{
							text = "\\\"";
							goto IL_12E;
						}
						if (writeBuffer == null)
						{
							writeBuffer = new char[6];
						}
						StringUtils.ToCharAsUnicode(c, writeBuffer);
						text = "!";
						goto IL_12E;
					}
					IL_1C5:;
				}
				if (num == 0)
				{
					writer.Write(s);
				}
				else
				{
					int num4 = s.Length - num;
					if (writeBuffer == null || writeBuffer.Length < num4)
					{
						writeBuffer = new char[num4];
					}
					s.CopyTo(num, writeBuffer, 0, num4);
					writer.Write(writeBuffer, 0, num4);
				}
			}
			if (appendDelimiters)
			{
				writer.Write(delimiter);
			}
		}
	}
}
