using Newtonsoft.Json.Utilities;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;

namespace Newtonsoft.Json
{
	// Token: 0x020000CE RID: 206
	public sealed class JsonTextReader : JsonReader, IJsonLineInfo
	{
		// Token: 0x0400034F RID: 847
		private const int MaximumJavascriptIntegerCharacterLength = 380;

		// Token: 0x04000359 RID: 857
		internal PropertyNameTable NameTable;

		// Token: 0x0400034E RID: 846
		private const char UnicodeReplacementChar = '�';

		// Token: 0x04000357 RID: 855
		private StringBuffer _buffer;

		// Token: 0x04000353 RID: 851
		private int _charPos;

		// Token: 0x04000351 RID: 849
		private char[] _chars;

		// Token: 0x04000352 RID: 850
		private int _charsUsed;

		// Token: 0x04000356 RID: 854
		private bool _isEndOfFile;

		// Token: 0x04000355 RID: 853
		private int _lineNumber;

		// Token: 0x04000354 RID: 852
		private int _lineStartPos;

		// Token: 0x04000350 RID: 848
		private readonly TextReader _reader;

		// Token: 0x04000358 RID: 856
		private StringReference _stringReference;

		// Token: 0x17000129 RID: 297
		public int LineNumber
		{
			// Token: 0x06000727 RID: 1831
			// RVA: 0x0000A18A File Offset: 0x0000838A
			get
			{
				if (base.CurrentState == JsonReader.State.Start && this.LinePosition == 0)
				{
					return 0;
				}
				return this._lineNumber;
			}
		}

		// Token: 0x1700012A RID: 298
		public int LinePosition
		{
			// Token: 0x06000728 RID: 1832
			// RVA: 0x0000A1A4 File Offset: 0x000083A4
			get
			{
				return this._charPos - this._lineStartPos;
			}
		}

		// Token: 0x060006F9 RID: 1785
		// RVA: 0x00009F3A File Offset: 0x0000813A
		public JsonTextReader(TextReader reader)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			this._reader = reader;
			this._lineNumber = 1;
			this._chars = new char[1025];
		}

		// Token: 0x060006FD RID: 1789
		// RVA: 0x00009FB5 File Offset: 0x000081B5
		private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count)
		{
			Buffer.BlockCopy(src, srcOffset * 2, dst, dstOffset * 2, count * 2);
		}

		// Token: 0x0600070E RID: 1806
		// RVA: 0x0000A028 File Offset: 0x00008228
		private void ClearRecentString()
		{
			if (this._buffer != null)
			{
				this._buffer.Position = 0;
			}
			this._stringReference = default(StringReference);
		}

		// Token: 0x06000725 RID: 1829
		// RVA: 0x0000A154 File Offset: 0x00008354
		public override void Close()
		{
			base.Close();
			if (base.CloseInput && this._reader != null)
			{
				this._reader.Close();
			}
			if (this._buffer != null)
			{
				this._buffer.Clear();
			}
		}

		// Token: 0x06000717 RID: 1815
		// RVA: 0x00039DBC File Offset: 0x00037FBC
		private bool EatWhitespace(bool oneOrMore)
		{
			bool flag = false;
			bool flag2 = false;
			while (!flag)
			{
				char c = this._chars[this._charPos];
				char c2 = c;
				if (c2 != '\0')
				{
					if (c2 != '\n')
					{
						if (c2 != '\r')
						{
							if (c != ' ' && !char.IsWhiteSpace(c))
							{
								flag = true;
							}
							else
							{
								flag2 = true;
								this._charPos++;
							}
						}
						else
						{
							this.ProcessCarriageReturn(false);
						}
					}
					else
					{
						this.ProcessLineFeed();
					}
				}
				else if (this._charsUsed == this._charPos)
				{
					if (this.ReadData(false) == 0)
					{
						flag = true;
					}
				}
				else
				{
					this._charPos++;
				}
			}
			return !oneOrMore || flag2;
		}

		// Token: 0x06000701 RID: 1793
		// RVA: 0x00009FD2 File Offset: 0x000081D2
		private bool EnsureChars(int relativePosition, bool append)
		{
			return this._charPos + relativePosition < this._charsUsed || this.ReadChars(relativePosition, append);
		}

		// Token: 0x060006FA RID: 1786
		// RVA: 0x00009F6E File Offset: 0x0000816E
		private StringBuffer GetBuffer()
		{
			if (this._buffer == null)
			{
				this._buffer = new StringBuffer(1025);
			}
			else
			{
				this._buffer.Position = 0;
			}
			return this._buffer;
		}

		// Token: 0x06000726 RID: 1830
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		public bool HasLineInfo()
		{
			return true;
		}

		// Token: 0x0600071D RID: 1821
		// RVA: 0x0003A6EC File Offset: 0x000388EC
		private bool IsSeparator(char c)
		{
			if (c <= ')')
			{
				switch (c)
				{
				case '\t':
				case '\n':
				case '\r':
					break;
				case '\v':
				case '\f':
					goto IL_8E;
				default:
					if (c != ' ')
					{
						if (c != ')')
						{
							goto IL_8E;
						}
						if (base.CurrentState == JsonReader.State.Constructor || base.CurrentState == JsonReader.State.ConstructorStart)
						{
							return true;
						}
						return false;
					}
					break;
				}
				return true;
			}
			if (c <= '/')
			{
				if (c != ',')
				{
					if (c != '/')
					{
						goto IL_8E;
					}
					if (!this.EnsureChars(1, false))
					{
						return false;
					}
					char c2 = this._chars[this._charPos + 1];
					return c2 == '*' || c2 == '/';
				}
			}
			else if (c != ']')
			{
				if (c != '}')
				{
					goto IL_8E;
				}
			}
			return true;
			IL_8E:
			if (char.IsWhiteSpace(c))
			{
				return true;
			}
			return false;
		}

		// Token: 0x0600071B RID: 1819
		// RVA: 0x0003A688 File Offset: 0x00038888
		private bool MatchValue(string value)
		{
			if (!this.EnsureChars(value.Length - 1, true))
			{
				return false;
			}
			for (int i = 0; i < value.Length; i++)
			{
				if (this._chars[this._charPos + i] != value[i])
				{
					return false;
				}
			}
			this._charPos += value.Length;
			return true;
		}

		// Token: 0x0600071C RID: 1820
		// RVA: 0x0000A07C File Offset: 0x0000827C
		private bool MatchValueWithTrailingSeparator(string value)
		{
			return this.MatchValue(value) && (!this.EnsureChars(0, false) || this.IsSeparator(this._chars[this._charPos]) || this._chars[this._charPos] == '\0');
		}

		// Token: 0x060006FB RID: 1787
		// RVA: 0x00009F9C File Offset: 0x0000819C
		private void OnNewLine(int pos)
		{
			this._lineNumber++;
			this._lineStartPos = pos - 1;
		}

		// Token: 0x0600071A RID: 1818
		// RVA: 0x0003A474 File Offset: 0x00038674
		private void ParseComment()
		{
			this._charPos++;
			if (!this.EnsureChars(1, false))
			{
				throw JsonReaderException.Create(this, "Unexpected end while parsing comment.");
			}
			bool flag;
			if (this._chars[this._charPos] == '*')
			{
				flag = false;
			}
			else
			{
				if (this._chars[this._charPos] != '/')
				{
					throw JsonReaderException.Create(this, StringUtils.FormatWith("Error parsing comment. Expected: *, got {0}.", CultureInfo.InvariantCulture, this._chars[this._charPos]));
				}
				flag = true;
			}
			this._charPos++;
			int charPos = this._charPos;
			bool flag2 = false;
			while (!flag2)
			{
				char c = this._chars[this._charPos];
				if (c <= '\n')
				{
					if (c != '\0')
					{
						if (c == '\n')
						{
							if (flag)
							{
								this._stringReference = new StringReference(this._chars, charPos, this._charPos - charPos);
								flag2 = true;
							}
							this.ProcessLineFeed();
							continue;
						}
					}
					else
					{
						if (this._charsUsed != this._charPos)
						{
							this._charPos++;
							continue;
						}
						if (this.ReadData(true) != 0)
						{
							continue;
						}
						if (flag)
						{
							this._stringReference = new StringReference(this._chars, charPos, this._charPos - charPos);
							flag2 = true;
							continue;
						}
						throw JsonReaderException.Create(this, "Unexpected end while parsing comment.");
					}
				}
				else
				{
					if (c == '\r')
					{
						if (flag)
						{
							this._stringReference = new StringReference(this._chars, charPos, this._charPos - charPos);
							flag2 = true;
						}
						this.ProcessCarriageReturn(true);
						continue;
					}
					if (c == '*')
					{
						this._charPos++;
						if (!flag && this.EnsureChars(0, true) && this._chars[this._charPos] == '/')
						{
							this._stringReference = new StringReference(this._chars, charPos, this._charPos - charPos - 1);
							this._charPos++;
							flag2 = true;
							continue;
						}
						continue;
					}
				}
				this._charPos++;
			}
			base.SetToken(JsonToken.Comment, this._stringReference.ToString());
			this.ClearRecentString();
		}

		// Token: 0x06000718 RID: 1816
		// RVA: 0x00039E54 File Offset: 0x00038054
		private void ParseConstructor()
		{
			if (!this.MatchValueWithTrailingSeparator("new"))
			{
				throw JsonReaderException.Create(this, "Unexpected content while parsing JSON.");
			}
			this.EatWhitespace(false);
			int charPos = this._charPos;
			char c;
			while (true)
			{
				c = this._chars[this._charPos];
				if (c == '\0')
				{
					if (this._charsUsed != this._charPos)
					{
						goto IL_6F;
					}
					if (this.ReadData(true) == 0)
					{
						break;
					}
				}
				else
				{
					if (!char.IsLetterOrDigit(c))
					{
						goto IL_86;
					}
					this._charPos++;
				}
			}
			throw JsonReaderException.Create(this, "Unexpected end while parsing constructor.");
			IL_6F:
			int charPos2 = this._charPos;
			this._charPos++;
			goto IL_DA;
			IL_86:
			if (c == '\r')
			{
				charPos2 = this._charPos;
				this.ProcessCarriageReturn(true);
			}
			else if (c == '\n')
			{
				charPos2 = this._charPos;
				this.ProcessLineFeed();
			}
			else if (char.IsWhiteSpace(c))
			{
				charPos2 = this._charPos;
				this._charPos++;
			}
			else
			{
				if (c != '(')
				{
					throw JsonReaderException.Create(this, StringUtils.FormatWith("Unexpected character while parsing constructor: {0}.", CultureInfo.InvariantCulture, c));
				}
				charPos2 = this._charPos;
			}
			IL_DA:
			this._stringReference = new StringReference(this._chars, charPos, charPos2 - charPos);
			string value = this._stringReference.ToString();
			this.EatWhitespace(false);
			if (this._chars[this._charPos] != '(')
			{
				throw JsonReaderException.Create(this, StringUtils.FormatWith("Unexpected character while parsing constructor: {0}.", CultureInfo.InvariantCulture, this._chars[this._charPos]));
			}
			this._charPos++;
			this.ClearRecentString();
			base.SetToken(JsonToken.StartConstructor, value);
		}

		// Token: 0x06000721 RID: 1825
		// RVA: 0x0000A12B File Offset: 0x0000832B
		private void ParseFalse()
		{
			if (!this.MatchValueWithTrailingSeparator(JsonConvert.False))
			{
				throw JsonReaderException.Create(this, "Error parsing boolean value.");
			}
			base.SetToken(JsonToken.Boolean, false);
		}

		// Token: 0x0600071F RID: 1823
		// RVA: 0x0000A0E5 File Offset: 0x000082E5
		private void ParseNull()
		{
			if (!this.MatchValueWithTrailingSeparator(JsonConvert.Null))
			{
				throw JsonReaderException.Create(this, "Error parsing null value.");
			}
			base.SetToken(JsonToken.Null);
		}

		// Token: 0x06000719 RID: 1817
		// RVA: 0x00039FE8 File Offset: 0x000381E8
		private void ParseNumber()
		{
			this.ShiftBufferIfNeeded();
			char c = this._chars[this._charPos];
			int charPos = this._charPos;
			this.ReadNumberIntoBuffer();
			base.SetPostValueState(true);
			this._stringReference = new StringReference(this._chars, charPos, this._charPos - charPos);
			bool flag = char.IsDigit(c) && this._stringReference.Length == 1;
			bool flag2 = c == '0' && this._stringReference.Length > 1 && this._stringReference.Chars[this._stringReference.StartIndex + 1] != '.' && this._stringReference.Chars[this._stringReference.StartIndex + 1] != 'e' && this._stringReference.Chars[this._stringReference.StartIndex + 1] != 'E';
			object value;
			JsonToken newToken;
			if (this._readType == ReadType.ReadAsInt32)
			{
				if (flag)
				{
					value = (int)(c - '0');
				}
				else
				{
					if (flag2)
					{
						string text = this._stringReference.ToString();
						try
						{
							int num = text.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? Convert.ToInt32(text, 16) : Convert.ToInt32(text, 8);
							value = num;
							goto IL_186;
						}
						catch (Exception ex)
						{
							throw JsonReaderException.Create(this, StringUtils.FormatWith("Input string '{0}' is not a valid integer.", CultureInfo.InvariantCulture, text), ex);
						}
					}
					int num2;
					ParseResult parseResult = ConvertUtils.Int32TryParse(this._stringReference.Chars, this._stringReference.StartIndex, this._stringReference.Length, out num2);
					if (parseResult == ParseResult.Success)
					{
						value = num2;
					}
					else
					{
						if (parseResult == ParseResult.Overflow)
						{
							throw JsonReaderException.Create(this, StringUtils.FormatWith("JSON integer {0} is too large or small for an Int32.", CultureInfo.InvariantCulture, this._stringReference.ToString()));
						}
						throw JsonReaderException.Create(this, StringUtils.FormatWith("Input string '{0}' is not a valid integer.", CultureInfo.InvariantCulture, this._stringReference.ToString()));
					}
				}
				IL_186:
				newToken = JsonToken.Integer;
			}
			else if (this._readType == ReadType.ReadAsDecimal)
			{
				if (flag)
				{
					value = c - 48m;
				}
				else
				{
					if (flag2)
					{
						string text2 = this._stringReference.ToString();
						try
						{
							long value2 = text2.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? Convert.ToInt64(text2, 16) : Convert.ToInt64(text2, 8);
							value = Convert.ToDecimal(value2);
							goto IL_2A3;
						}
						catch (Exception ex2)
						{
							throw JsonReaderException.Create(this, StringUtils.FormatWith("Input string '{0}' is not a valid decimal.", CultureInfo.InvariantCulture, text2), ex2);
						}
					}
					string s = this._stringReference.ToString();
					decimal num3;
					if (!decimal.TryParse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, CultureInfo.InvariantCulture, out num3))
					{
						throw JsonReaderException.Create(this, StringUtils.FormatWith("Input string '{0}' is not a valid decimal.", CultureInfo.InvariantCulture, this._stringReference.ToString()));
					}
					value = num3;
				}
				IL_2A3:
				newToken = JsonToken.Float;
			}
			else if (flag)
			{
				value = (long)((ulong)c - 48uL);
				newToken = JsonToken.Integer;
			}
			else if (flag2)
			{
				string text3 = this._stringReference.ToString();
				try
				{
					value = (text3.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? Convert.ToInt64(text3, 16) : Convert.ToInt64(text3, 8));
				}
				catch (Exception ex3)
				{
					throw JsonReaderException.Create(this, StringUtils.FormatWith("Input string '{0}' is not a valid number.", CultureInfo.InvariantCulture, text3), ex3);
				}
				newToken = JsonToken.Integer;
			}
			else
			{
				long num4;
				ParseResult parseResult2 = ConvertUtils.Int64TryParse(this._stringReference.Chars, this._stringReference.StartIndex, this._stringReference.Length, out num4);
				if (parseResult2 == ParseResult.Success)
				{
					value = num4;
					newToken = JsonToken.Integer;
				}
				else
				{
					if (parseResult2 == ParseResult.Overflow)
					{
						throw JsonReaderException.Create(this, StringUtils.FormatWith("JSON integer {0} is too large or small for an Int64.", CultureInfo.InvariantCulture, this._stringReference.ToString()));
					}
					string text4 = this._stringReference.ToString();
					if (this._floatParseHandling == FloatParseHandling.Decimal)
					{
						decimal num5;
						if (!decimal.TryParse(text4, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, CultureInfo.InvariantCulture, out num5))
						{
							throw JsonReaderException.Create(this, StringUtils.FormatWith("Input string '{0}' is not a valid decimal.", CultureInfo.InvariantCulture, text4));
						}
						value = num5;
					}
					else
					{
						double num6;
						if (!double.TryParse(text4, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, CultureInfo.InvariantCulture, out num6))
						{
							throw JsonReaderException.Create(this, StringUtils.FormatWith("Input string '{0}' is not a valid number.", CultureInfo.InvariantCulture, text4));
						}
						value = num6;
					}
					newToken = JsonToken.Float;
				}
			}
			this.ClearRecentString();
			base.SetToken(newToken, value, false);
		}

		// Token: 0x06000724 RID: 1828
		// RVA: 0x0003A834 File Offset: 0x00038A34
		private void ParseNumberNaN()
		{
			if (!this.MatchValueWithTrailingSeparator(JsonConvert.NaN))
			{
				throw JsonReaderException.Create(this, "Error parsing NaN value.");
			}
			if (this._floatParseHandling == FloatParseHandling.Decimal)
			{
				throw new JsonReaderException("Cannot read NaN as a decimal.");
			}
			base.SetToken(JsonToken.Float, double.NaN);
		}

		// Token: 0x06000722 RID: 1826
		// RVA: 0x0003A794 File Offset: 0x00038994
		private void ParseNumberNegativeInfinity()
		{
			if (!this.MatchValueWithTrailingSeparator(JsonConvert.NegativeInfinity))
			{
				throw JsonReaderException.Create(this, "Error parsing negative infinity value.");
			}
			if (this._floatParseHandling == FloatParseHandling.Decimal)
			{
				throw new JsonReaderException("Cannot read -Infinity as a decimal.");
			}
			base.SetToken(JsonToken.Float, double.NegativeInfinity);
		}

		// Token: 0x06000723 RID: 1827
		// RVA: 0x0003A7E4 File Offset: 0x000389E4
		private void ParseNumberPositiveInfinity()
		{
			if (!this.MatchValueWithTrailingSeparator(JsonConvert.PositiveInfinity))
			{
				throw JsonReaderException.Create(this, "Error parsing positive infinity value.");
			}
			if (this._floatParseHandling == FloatParseHandling.Decimal)
			{
				throw new JsonReaderException("Cannot read Infinity as a decimal.");
			}
			base.SetToken(JsonToken.Float, double.PositiveInfinity);
		}

		// Token: 0x06000710 RID: 1808
		// RVA: 0x00039798 File Offset: 0x00037998
		private bool ParseObject()
		{
			while (true)
			{
				char c = this._chars[this._charPos];
				char c2 = c;
				if (c2 > '\r')
				{
					if (c2 == ' ')
					{
						goto IL_45;
					}
					if (c2 == '/')
					{
						goto IL_DC;
					}
					if (c2 == '}')
					{
						goto IL_C4;
					}
				}
				else if (c2 != '\0')
				{
					switch (c2)
					{
					case '\t':
						goto IL_45;
					case '\n':
						this.ProcessLineFeed();
						continue;
					case '\r':
						this.ProcessCarriageReturn(false);
						continue;
					}
				}
				else
				{
					if (this._charsUsed != this._charPos)
					{
						this._charPos++;
						continue;
					}
					if (this.ReadData(false) == 0)
					{
						break;
					}
					continue;
				}
				if (char.IsWhiteSpace(c))
				{
					this._charPos++;
					continue;
				}
				goto IL_BD;
				IL_45:
				this._charPos++;
			}
			return false;
			IL_BD:
			return this.ParseProperty();
			IL_C4:
			base.SetToken(JsonToken.EndObject);
			this._charPos++;
			return true;
			IL_DC:
			this.ParseComment();
			return true;
		}

		// Token: 0x0600070F RID: 1807
		// RVA: 0x00039618 File Offset: 0x00037818
		private bool ParsePostValue()
		{
			char c;
			while (true)
			{
				c = this._chars[this._charPos];
				char c2 = c;
				if (c2 <= ')')
				{
					if (c2 <= '\r')
					{
						if (c2 != '\0')
						{
							switch (c2)
							{
							case '\t':
								break;
							case '\n':
								this.ProcessLineFeed();
								continue;
							case '\v':
							case '\f':
								goto IL_3C;
							case '\r':
								this.ProcessCarriageReturn(false);
								continue;
							default:
								goto IL_3C;
							}
						}
						else
						{
							if (this._charsUsed != this._charPos)
							{
								this._charPos++;
								continue;
							}
							if (this.ReadData(false) == 0)
							{
								break;
							}
							continue;
						}
					}
					else if (c2 != ' ')
					{
						if (c2 != ')')
						{
							goto IL_3C;
						}
						goto IL_F1;
					}
					this._charPos++;
					continue;
				}
				if (c2 <= '/')
				{
					if (c2 == ',')
					{
						goto IL_111;
					}
					if (c2 == '/')
					{
						goto IL_109;
					}
				}
				else
				{
					if (c2 == ']')
					{
						goto IL_15B;
					}
					if (c2 == '}')
					{
						goto IL_143;
					}
				}
				IL_3C:
				if (!char.IsWhiteSpace(c))
				{
					goto IL_127;
				}
				this._charPos++;
			}
			this._currentState = JsonReader.State.Finished;
			return false;
			IL_F1:
			this._charPos++;
			base.SetToken(JsonToken.EndConstructor);
			return true;
			IL_109:
			this.ParseComment();
			return true;
			IL_111:
			this._charPos++;
			base.SetStateBasedOnCurrent();
			return false;
			IL_127:
			throw JsonReaderException.Create(this, StringUtils.FormatWith("After parsing a value an unexpected character was encountered: {0}.", CultureInfo.InvariantCulture, c));
			IL_143:
			this._charPos++;
			base.SetToken(JsonToken.EndObject);
			return true;
			IL_15B:
			this._charPos++;
			base.SetToken(JsonToken.EndArray);
			return true;
		}

		// Token: 0x06000711 RID: 1809
		// RVA: 0x00039888 File Offset: 0x00037A88
		private bool ParseProperty()
		{
			char c = this._chars[this._charPos];
			char c2;
			if (c != '"')
			{
				if (c != '\'')
				{
					if (this.ValidIdentifierChar(c))
					{
						c2 = '\0';
						this.ShiftBufferIfNeeded();
						this.ParseUnquotedProperty();
						goto IL_78;
					}
					throw JsonReaderException.Create(this, StringUtils.FormatWith("Invalid property identifier character: {0}.", CultureInfo.InvariantCulture, this._chars[this._charPos]));
				}
			}
			this._charPos++;
			c2 = c;
			this.ShiftBufferIfNeeded();
			this.ReadStringIntoBuffer(c2);
			IL_78:
			string text;
			if (this.NameTable != null)
			{
				text = this.NameTable.Get(this._stringReference.Chars, this._stringReference.StartIndex, this._stringReference.Length);
				if (text == null)
				{
					text = this._stringReference.ToString();
				}
			}
			else
			{
				text = this._stringReference.ToString();
			}
			this.EatWhitespace(false);
			if (this._chars[this._charPos] != ':')
			{
				throw JsonReaderException.Create(this, StringUtils.FormatWith("Invalid character after parsing property name. Expected ':' but got: {0}.", CultureInfo.InvariantCulture, this._chars[this._charPos]));
			}
			this._charPos++;
			base.SetToken(JsonToken.PropertyName, text);
			this._quoteChar = c2;
			this.ClearRecentString();
			return true;
		}

		// Token: 0x060006FC RID: 1788
		// RVA: 0x00038C9C File Offset: 0x00036E9C
		private void ParseString(char quote)
		{
			this._charPos++;
			this.ShiftBufferIfNeeded();
			this.ReadStringIntoBuffer(quote);
			base.SetPostValueState(true);
			if (this._readType == ReadType.ReadAsBytes)
			{
				byte[] value;
				if (this._stringReference.Length == 0)
				{
					value = new byte[0];
				}
				else
				{
					value = Convert.FromBase64CharArray(this._stringReference.Chars, this._stringReference.StartIndex, this._stringReference.Length);
				}
				base.SetToken(JsonToken.Bytes, value, false);
				return;
			}
			if (this._readType == ReadType.ReadAsString)
			{
				string value2 = this._stringReference.ToString();
				base.SetToken(JsonToken.String, value2, false);
				this._quoteChar = quote;
				return;
			}
			string text = this._stringReference.ToString();
			if (this._dateParseHandling != DateParseHandling.None)
			{
				DateParseHandling dateParseHandling;
				if (this._readType == ReadType.ReadAsDateTime)
				{
					dateParseHandling = DateParseHandling.DateTime;
				}
				else
				{
					dateParseHandling = this._dateParseHandling;
				}
				object value3;
				if (DateTimeUtils.TryParseDateTime(text, dateParseHandling, base.DateTimeZoneHandling, base.DateFormatString, base.Culture, out value3))
				{
					base.SetToken(JsonToken.Date, value3, false);
					return;
				}
			}
			base.SetToken(JsonToken.String, text, false);
			this._quoteChar = quote;
		}

		// Token: 0x0600071E RID: 1822
		// RVA: 0x0000A0BC File Offset: 0x000082BC
		private void ParseTrue()
		{
			if (!this.MatchValueWithTrailingSeparator(JsonConvert.True))
			{
				throw JsonReaderException.Create(this, "Error parsing boolean value.");
			}
			base.SetToken(JsonToken.Boolean, true);
		}

		// Token: 0x06000720 RID: 1824
		// RVA: 0x0000A108 File Offset: 0x00008308
		private void ParseUndefined()
		{
			if (!this.MatchValueWithTrailingSeparator(JsonConvert.Undefined))
			{
				throw JsonReaderException.Create(this, "Error parsing undefined value.");
			}
			base.SetToken(JsonToken.Undefined);
		}

		// Token: 0x0600070C RID: 1804
		// RVA: 0x00039460 File Offset: 0x00037660
		private char ParseUnicode()
		{
			if (!this.EnsureChars(4, true))
			{
				throw JsonReaderException.Create(this, "Unexpected end while parsing unicode character.");
			}
			string s = new string(this._chars, this._charPos, 4);
			char c = Convert.ToChar(int.Parse(s, NumberStyles.HexNumber, NumberFormatInfo.InvariantInfo));
			char result = c;
			this._charPos += 4;
			return result;
		}

		// Token: 0x06000713 RID: 1811
		// RVA: 0x000399D0 File Offset: 0x00037BD0
		private void ParseUnquotedProperty()
		{
			int charPos = this._charPos;
			char c2;
			while (true)
			{
				char c = this._chars[this._charPos];
				if (c == '\0')
				{
					if (this._charsUsed != this._charPos)
					{
						goto IL_67;
					}
					if (this.ReadData(true) == 0)
					{
						break;
					}
				}
				else
				{
					c2 = this._chars[this._charPos];
					if (!this.ValidIdentifierChar(c2))
					{
						goto IL_82;
					}
					this._charPos++;
				}
			}
			throw JsonReaderException.Create(this, "Unexpected end while parsing unquoted property name.");
			IL_67:
			this._stringReference = new StringReference(this._chars, charPos, this._charPos - charPos);
			return;
			IL_82:
			if (!char.IsWhiteSpace(c2))
			{
				if (c2 != ':')
				{
					throw JsonReaderException.Create(this, StringUtils.FormatWith("Invalid JavaScript property identifier character: {0}.", CultureInfo.InvariantCulture, c2));
				}
			}
			this._stringReference = new StringReference(this._chars, charPos, this._charPos - charPos);
		}

		// Token: 0x06000714 RID: 1812
		// RVA: 0x00039AA4 File Offset: 0x00037CA4
		private bool ParseValue()
		{
			char c;
			while (true)
			{
				c = this._chars[this._charPos];
				char c2 = c;
				if (c2 <= 'I')
				{
					if (c2 <= '\r')
					{
						if (c2 != '\0')
						{
							switch (c2)
							{
							case '\t':
								break;
							case '\n':
								this.ProcessLineFeed();
								continue;
							case '\v':
							case '\f':
								goto IL_62;
							case '\r':
								this.ProcessCarriageReturn(false);
								continue;
							default:
								goto IL_62;
							}
						}
						else
						{
							if (this._charsUsed != this._charPos)
							{
								this._charPos++;
								continue;
							}
							if (this.ReadData(false) == 0)
							{
								break;
							}
							continue;
						}
					}
					else
					{
						switch (c2)
						{
						case ' ':
							break;
						case '!':
							goto IL_62;
						case '"':
							goto IL_1AB;
						default:
							switch (c2)
							{
							case '\'':
								goto IL_1AB;
							case '(':
							case '*':
							case '+':
							case '.':
								goto IL_62;
							case ')':
								goto IL_154;
							case ',':
								goto IL_16C;
							case '-':
								goto IL_176;
							case '/':
								goto IL_1A3;
							default:
								if (c2 != 'I')
								{
									goto IL_62;
								}
								goto IL_14C;
							}
							break;
						}
					}
					this._charPos++;
					continue;
				}
				if (c2 <= 'f')
				{
					if (c2 == 'N')
					{
						goto IL_1EB;
					}
					switch (c2)
					{
					case '[':
						goto IL_1BC;
					case '\\':
						break;
					case ']':
						goto IL_1D3;
					default:
						if (c2 == 'f')
						{
							goto IL_1B4;
						}
						break;
					}
				}
				else
				{
					if (c2 == 'n')
					{
						goto IL_252;
					}
					switch (c2)
					{
					case 't':
						goto IL_242;
					case 'u':
						goto IL_24A;
					default:
						if (c2 == '{')
						{
							goto IL_22B;
						}
						break;
					}
				}
				IL_62:
				if (!char.IsWhiteSpace(c))
				{
					goto IL_1F3;
				}
				this._charPos++;
			}
			return false;
			IL_14C:
			this.ParseNumberPositiveInfinity();
			return true;
			IL_154:
			this._charPos++;
			base.SetToken(JsonToken.EndConstructor);
			return true;
			IL_16C:
			base.SetToken(JsonToken.Undefined);
			return true;
			IL_176:
			if (this.EnsureChars(1, true) && this._chars[this._charPos + 1] == 'I')
			{
				this.ParseNumberNegativeInfinity();
			}
			else
			{
				this.ParseNumber();
			}
			return true;
			IL_1A3:
			this.ParseComment();
			return true;
			IL_1AB:
			this.ParseString(c);
			return true;
			IL_1B4:
			this.ParseFalse();
			return true;
			IL_1BC:
			this._charPos++;
			base.SetToken(JsonToken.StartArray);
			return true;
			IL_1D3:
			this._charPos++;
			base.SetToken(JsonToken.EndArray);
			return true;
			IL_1EB:
			this.ParseNumberNaN();
			return true;
			IL_1F3:
			if (!char.IsNumber(c) && c != '-')
			{
				if (c != '.')
				{
					throw JsonReaderException.Create(this, StringUtils.FormatWith("Unexpected character encountered while parsing value: {0}.", CultureInfo.InvariantCulture, c));
				}
			}
			this.ParseNumber();
			return true;
			IL_22B:
			this._charPos++;
			base.SetToken(JsonToken.StartObject);
			return true;
			IL_242:
			this.ParseTrue();
			return true;
			IL_24A:
			this.ParseUndefined();
			return true;
			IL_252:
			if (this.EnsureChars(1, true))
			{
				char c3 = this._chars[this._charPos + 1];
				if (c3 == 'u')
				{
					this.ParseNull();
				}
				else
				{
					if (c3 != 'e')
					{
						throw JsonReaderException.Create(this, StringUtils.FormatWith("Unexpected character encountered while parsing value: {0}.", CultureInfo.InvariantCulture, this._chars[this._charPos]));
					}
					this.ParseConstructor();
				}
				return true;
			}
			throw JsonReaderException.Create(this, "Unexpected end.");
		}

		// Token: 0x06000716 RID: 1814
		// RVA: 0x00039D6C File Offset: 0x00037F6C
		private void ProcessCarriageReturn(bool append)
		{
			this._charPos++;
			if (this.EnsureChars(1, append) && this._chars[this._charPos] == '\n')
			{
				this._charPos++;
			}
			this.OnNewLine(this._charPos);
		}

		// Token: 0x06000715 RID: 1813
		// RVA: 0x0000A060 File Offset: 0x00008260
		private void ProcessLineFeed()
		{
			this._charPos++;
			this.OnNewLine(this._charPos);
		}

		// Token: 0x06000703 RID: 1795
		// RVA: 0x00009FEE File Offset: 0x000081EE
		[DebuggerStepThrough]
		public override bool Read()
		{
			this._readType = ReadType.Read;
			if (!this.ReadInternal())
			{
				base.SetToken(JsonToken.None);
				return false;
			}
			return true;
		}

		// Token: 0x06000704 RID: 1796
		// RVA: 0x0000623B File Offset: 0x0000443B
		public override byte[] ReadAsBytes()
		{
			return base.ReadAsBytesInternal();
		}

		// Token: 0x06000708 RID: 1800
		// RVA: 0x0000625B File Offset: 0x0000445B
		public override DateTime? ReadAsDateTime()
		{
			return base.ReadAsDateTimeInternal();
		}

		// Token: 0x06000705 RID: 1797
		// RVA: 0x00006243 File Offset: 0x00004443
		public override decimal? ReadAsDecimal()
		{
			return base.ReadAsDecimalInternal();
		}

		// Token: 0x06000706 RID: 1798
		// RVA: 0x0000624B File Offset: 0x0000444B
		public override int? ReadAsInt32()
		{
			return base.ReadAsInt32Internal();
		}

		// Token: 0x06000707 RID: 1799
		// RVA: 0x00006253 File Offset: 0x00004453
		public override string ReadAsString()
		{
			return base.ReadAsStringInternal();
		}

		// Token: 0x06000702 RID: 1794
		// RVA: 0x00038F90 File Offset: 0x00037190
		private bool ReadChars(int relativePosition, bool append)
		{
			if (this._isEndOfFile)
			{
				return false;
			}
			int num = this._charPos + relativePosition - this._charsUsed + 1;
			int num2 = 0;
			do
			{
				int num3 = this.ReadData(append, num - num2);
				if (num3 == 0)
				{
					break;
				}
				num2 += num3;
			}
			while (num2 < num);
			return num2 >= num;
		}

		// Token: 0x060006FF RID: 1791
		// RVA: 0x00009FC8 File Offset: 0x000081C8
		private int ReadData(bool append)
		{
			return this.ReadData(append, 0);
		}

		// Token: 0x06000700 RID: 1792
		// RVA: 0x00038E3C File Offset: 0x0003703C
		private int ReadData(bool append, int charsRequired)
		{
			if (this._isEndOfFile)
			{
				return 0;
			}
			if (this._charsUsed + charsRequired >= this._chars.Length - 1)
			{
				if (append)
				{
					int num = Math.Max(this._chars.Length * 2, this._charsUsed + charsRequired + 1);
					char[] array = new char[num];
					JsonTextReader.BlockCopyChars(this._chars, 0, array, 0, this._chars.Length);
					this._chars = array;
				}
				else
				{
					int num2 = this._charsUsed - this._charPos;
					if (num2 + charsRequired + 1 >= this._chars.Length)
					{
						char[] array2 = new char[num2 + charsRequired + 1];
						if (num2 > 0)
						{
							JsonTextReader.BlockCopyChars(this._chars, this._charPos, array2, 0, num2);
						}
						this._chars = array2;
					}
					else if (num2 > 0)
					{
						JsonTextReader.BlockCopyChars(this._chars, this._charPos, this._chars, 0, num2);
					}
					this._lineStartPos -= this._charPos;
					this._charPos = 0;
					this._charsUsed = num2;
				}
			}
			int count = this._chars.Length - this._charsUsed - 1;
			int num3 = this._reader.Read(this._chars, this._charsUsed, count);
			this._charsUsed += num3;
			if (num3 == 0)
			{
				this._isEndOfFile = true;
			}
			this._chars[this._charsUsed] = '\0';
			return num3;
		}

		// Token: 0x06000709 RID: 1801
		// RVA: 0x00038FDC File Offset: 0x000371DC
		internal override bool ReadInternal()
		{
			while (true)
			{
				switch (this._currentState)
				{
				case JsonReader.State.Start:
				case JsonReader.State.Property:
				case JsonReader.State.ArrayStart:
				case JsonReader.State.Array:
				case JsonReader.State.ConstructorStart:
				case JsonReader.State.Constructor:
					goto IL_56;
				case JsonReader.State.ObjectStart:
				case JsonReader.State.Object:
					goto IL_4D;
				case JsonReader.State.PostValue:
					if (this.ParsePostValue())
					{
						return true;
					}
					continue;
				case JsonReader.State.Finished:
					goto IL_7E;
				}
				break;
			}
			goto IL_5D;
			IL_4D:
			return this.ParseObject();
			IL_56:
			return this.ParseValue();
			IL_5D:
			throw JsonReaderException.Create(this, StringUtils.FormatWith("Unexpected state: {0}.", CultureInfo.InvariantCulture, base.CurrentState));
			IL_7E:
			if (!this.EnsureChars(0, false))
			{
				return false;
			}
			this.EatWhitespace(false);
			if (this._isEndOfFile)
			{
				return false;
			}
			if (this._chars[this._charPos] == '/')
			{
				this.ParseComment();
				return true;
			}
			throw JsonReaderException.Create(this, StringUtils.FormatWith("Additional text encountered after finished reading JSON content: {0}.", CultureInfo.InvariantCulture, this._chars[this._charPos]));
		}

		// Token: 0x0600070D RID: 1805
		// RVA: 0x000394C0 File Offset: 0x000376C0
		private void ReadNumberIntoBuffer()
		{
			int num = this._charPos;
			while (true)
			{
				char c = this._chars[num];
				if (c <= 'F')
				{
					if (c != '\0')
					{
						switch (c)
						{
						case '+':
						case '-':
						case '.':
						case '0':
						case '1':
						case '2':
						case '3':
						case '4':
						case '5':
						case '6':
						case '7':
						case '8':
						case '9':
						case 'A':
						case 'B':
						case 'C':
						case 'D':
						case 'E':
						case 'F':
							goto IL_3C;
						}
						break;
					}
					this._charPos = num;
					if (this._charsUsed == num && this.ReadData(true) != 0)
					{
						continue;
					}
					return;
				}
				else if (c != 'X')
				{
					switch (c)
					{
					case 'a':
					case 'b':
					case 'c':
					case 'd':
					case 'e':
					case 'f':
						break;
					default:
						if (c != 'x')
						{
							goto Block_3;
						}
						break;
					}
				}
				IL_3C:
				num++;
			}
			Block_3:
			this._charPos = num;
			char c2 = this._chars[this._charPos];
			if (!char.IsWhiteSpace(c2) && c2 != ',' && c2 != '}' && c2 != ']' && c2 != ')')
			{
				if (c2 != '/')
				{
					throw JsonReaderException.Create(this, StringUtils.FormatWith("Unexpected character encountered while parsing number: {0}.", CultureInfo.InvariantCulture, c2));
				}
			}
		}

		// Token: 0x0600070A RID: 1802
		// RVA: 0x000390C8 File Offset: 0x000372C8
		private void ReadStringIntoBuffer(char quote)
		{
			int num = this._charPos;
			int charPos = this._charPos;
			int num2 = this._charPos;
			StringBuffer stringBuffer = null;
			char c2;
			while (true)
			{
				char c = this._chars[num++];
				if (c <= '\r')
				{
					if (c != '\0')
					{
						if (c != '\n')
						{
							if (c == '\r')
							{
								this._charPos = num - 1;
								this.ProcessCarriageReturn(true);
								num = this._charPos;
							}
						}
						else
						{
							this._charPos = num - 1;
							this.ProcessLineFeed();
							num = this._charPos;
						}
					}
					else if (this._charsUsed == num - 1)
					{
						num--;
						if (this.ReadData(true) == 0)
						{
							goto IL_2B2;
						}
					}
				}
				else if (c != '"' && c != '\'')
				{
					if (c == '\\')
					{
						this._charPos = num;
						if (!this.EnsureChars(0, true))
						{
							goto IL_2D5;
						}
						int writeToPosition = num - 1;
						c2 = this._chars[num];
						char c3 = c2;
						char c4;
						if (c3 <= '\\')
						{
							if (c3 <= '\'')
							{
								if (c3 != '"' && c3 != '\'')
								{
									break;
								}
							}
							else if (c3 != '/')
							{
								if (c3 != '\\')
								{
									break;
								}
								num++;
								c4 = '\\';
								goto IL_211;
							}
							c4 = c2;
							num++;
						}
						else if (c3 <= 'f')
						{
							if (c3 != 'b')
							{
								if (c3 != 'f')
								{
									break;
								}
								num++;
								c4 = '\f';
							}
							else
							{
								num++;
								c4 = '\b';
							}
						}
						else
						{
							if (c3 != 'n')
							{
								switch (c3)
								{
								case 'r':
									num++;
									c4 = '\r';
									goto IL_211;
								case 't':
									num++;
									c4 = '\t';
									goto IL_211;
								case 'u':
									num++;
									this._charPos = num;
									c4 = this.ParseUnicode();
									if (StringUtils.IsLowSurrogate(c4))
									{
										c4 = '�';
									}
									else if (StringUtils.IsHighSurrogate(c4))
									{
										bool flag;
										do
										{
											flag = false;
											if (this.EnsureChars(2, true) && this._chars[this._charPos] == '\\' && this._chars[this._charPos + 1] == 'u')
											{
												char writeChar = c4;
												this._charPos += 2;
												c4 = this.ParseUnicode();
												if (!StringUtils.IsLowSurrogate(c4))
												{
													if (StringUtils.IsHighSurrogate(c4))
													{
														writeChar = '�';
														flag = true;
													}
													else
													{
														writeChar = '�';
													}
												}
												if (stringBuffer == null)
												{
													stringBuffer = this.GetBuffer();
												}
												this.WriteCharToBuffer(stringBuffer, writeChar, num2, writeToPosition);
												num2 = this._charPos;
											}
											else
											{
												c4 = '�';
											}
										}
										while (flag);
									}
									num = this._charPos;
									goto IL_211;
								}
								break;
							}
							num++;
							c4 = '\n';
						}
						IL_211:
						if (stringBuffer == null)
						{
							stringBuffer = this.GetBuffer();
						}
						this.WriteCharToBuffer(stringBuffer, c4, num2, writeToPosition);
						num2 = num;
					}
				}
				else if (this._chars[num - 1] == quote)
				{
					goto Block_26;
				}
			}
			goto IL_2F8;
			Block_26:
			num--;
			if (charPos == num2)
			{
				this._stringReference = new StringReference(this._chars, charPos, num - charPos);
			}
			else
			{
				if (stringBuffer == null)
				{
					stringBuffer = this.GetBuffer();
				}
				if (num > num2)
				{
					stringBuffer.Append(this._chars, num2, num - num2);
				}
				this._stringReference = new StringReference(stringBuffer.GetInternalBuffer(), 0, stringBuffer.Position);
			}
			num++;
			this._charPos = num;
			return;
			IL_2B2:
			this._charPos = num;
			throw JsonReaderException.Create(this, StringUtils.FormatWith("Unterminated string. Expected delimiter: {0}.", CultureInfo.InvariantCulture, quote));
			IL_2D5:
			this._charPos = num;
			throw JsonReaderException.Create(this, StringUtils.FormatWith("Unterminated string. Expected delimiter: {0}.", CultureInfo.InvariantCulture, quote));
			IL_2F8:
			num++;
			this._charPos = num;
			throw JsonReaderException.Create(this, StringUtils.FormatWith("Bad JSON escape sequence: {0}.", CultureInfo.InvariantCulture, "\\" + c2));
		}

		// Token: 0x060006FE RID: 1790
		// RVA: 0x00038DB4 File Offset: 0x00036FB4
		private void ShiftBufferIfNeeded()
		{
			int num = this._chars.Length;
			if ((double)(num - this._charPos) <= (double)num * 0.1)
			{
				int num2 = this._charsUsed - this._charPos;
				if (num2 > 0)
				{
					JsonTextReader.BlockCopyChars(this._chars, this._charPos, this._chars, 0, num2);
				}
				this._lineStartPos -= this._charPos;
				this._charPos = 0;
				this._charsUsed = num2;
				this._chars[this._charsUsed] = '\0';
			}
		}

		// Token: 0x06000712 RID: 1810
		// RVA: 0x0000A04A File Offset: 0x0000824A
		private bool ValidIdentifierChar(char value)
		{
			return char.IsLetterOrDigit(value) || value == '_' || value == '$';
		}

		// Token: 0x0600070B RID: 1803
		// RVA: 0x0000A009 File Offset: 0x00008209
		private void WriteCharToBuffer(StringBuffer buffer, char writeChar, int lastWritePosition, int writeToPosition)
		{
			if (writeToPosition > lastWritePosition)
			{
				buffer.Append(this._chars, lastWritePosition, writeToPosition - lastWritePosition);
			}
			buffer.Append(writeChar);
		}
	}
}
