using System;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200006A RID: 106
	internal struct DateTimeParser
	{
		// Token: 0x040001B1 RID: 433
		public int Day;

		// Token: 0x040001B5 RID: 437
		public int Fraction;

		// Token: 0x040001B2 RID: 434
		public int Hour;

		// Token: 0x040001C2 RID: 450
		private static readonly int LzHH;

		// Token: 0x040001C3 RID: 451
		private static readonly int LzHH_;

		// Token: 0x040001C4 RID: 452
		private static readonly int LzHH_mm;

		// Token: 0x040001C5 RID: 453
		private static readonly int LzHH_mm_;

		// Token: 0x040001C6 RID: 454
		private static readonly int LzHH_mm_ss;

		// Token: 0x040001BC RID: 444
		private static readonly int Lzyyyy;

		// Token: 0x040001BD RID: 445
		private static readonly int Lzyyyy_;

		// Token: 0x040001BE RID: 446
		private static readonly int Lzyyyy_MM;

		// Token: 0x040001BF RID: 447
		private static readonly int Lzyyyy_MM_;

		// Token: 0x040001C0 RID: 448
		private static readonly int Lzyyyy_MM_dd;

		// Token: 0x040001C1 RID: 449
		private static readonly int Lzyyyy_MM_ddT;

		// Token: 0x040001C7 RID: 455
		private static readonly int Lz_;

		// Token: 0x040001C8 RID: 456
		private static readonly int Lz_zz;

		// Token: 0x040001AE RID: 430
		private const short MaxFractionDigits = 7;

		// Token: 0x040001B3 RID: 435
		public int Minute;

		// Token: 0x040001B0 RID: 432
		public int Month;

		// Token: 0x040001BB RID: 443
		private static readonly int[] Power10;

		// Token: 0x040001B4 RID: 436
		public int Second;

		// Token: 0x040001AF RID: 431
		public int Year;

		// Token: 0x040001B8 RID: 440
		public ParserTimeZone Zone;

		// Token: 0x040001B6 RID: 438
		public int ZoneHour;

		// Token: 0x040001B7 RID: 439
		public int ZoneMinute;

		// Token: 0x040001BA RID: 442
		private int _length;

		// Token: 0x040001B9 RID: 441
		private string _text;

		// Token: 0x06000303 RID: 771
		// RVA: 0x0002F5EC File Offset: 0x0002D7EC
		static DateTimeParser()
		{
			DateTimeParser.Power10 = new int[]
			{
				-1,
				10,
				100,
				1000,
				10000,
				100000,
				1000000
			};
			DateTimeParser.Lzyyyy = "yyyy".Length;
			DateTimeParser.Lzyyyy_ = "yyyy-".Length;
			DateTimeParser.Lzyyyy_MM = "yyyy-MM".Length;
			DateTimeParser.Lzyyyy_MM_ = "yyyy-MM-".Length;
			DateTimeParser.Lzyyyy_MM_dd = "yyyy-MM-dd".Length;
			DateTimeParser.Lzyyyy_MM_ddT = "yyyy-MM-ddT".Length;
			DateTimeParser.LzHH = "HH".Length;
			DateTimeParser.LzHH_ = "HH:".Length;
			DateTimeParser.LzHH_mm = "HH:mm".Length;
			DateTimeParser.LzHH_mm_ = "HH:mm:".Length;
			DateTimeParser.LzHH_mm_ss = "HH:mm:ss".Length;
			DateTimeParser.Lz_ = "-".Length;
			DateTimeParser.Lz_zz = "-zz".Length;
		}

		// Token: 0x06000304 RID: 772
		// RVA: 0x00007F1D File Offset: 0x0000611D
		public bool Parse(string text)
		{
			this._text = text;
			this._length = text.Length;
			return this.ParseDate(0) && this.ParseChar(DateTimeParser.Lzyyyy_MM_dd, 'T') && this.ParseTimeAndZoneAndWhitespace(DateTimeParser.Lzyyyy_MM_ddT);
		}

		// Token: 0x0600030A RID: 778
		// RVA: 0x0002FA74 File Offset: 0x0002DC74
		private bool Parse2Digit(int start, out int num)
		{
			if (start + 1 < this._length)
			{
				int num2 = (int)(this._text[start] - '0');
				int num3 = (int)(this._text[start + 1] - '0');
				if (0 <= num2 && num2 < 10 && 0 <= num3 && num3 < 10)
				{
					num = num2 * 10 + num3;
					return true;
				}
			}
			num = 0;
			return false;
		}

		// Token: 0x06000309 RID: 777
		// RVA: 0x0002F9D8 File Offset: 0x0002DBD8
		private bool Parse4Digit(int start, out int num)
		{
			if (start + 3 < this._length)
			{
				int num2 = (int)(this._text[start] - '0');
				int num3 = (int)(this._text[start + 1] - '0');
				int num4 = (int)(this._text[start + 2] - '0');
				int num5 = (int)(this._text[start + 3] - '0');
				if (0 <= num2 && num2 < 10 && 0 <= num3 && num3 < 10 && 0 <= num4 && num4 < 10 && 0 <= num5 && num5 < 10)
				{
					num = ((num2 * 10 + num3) * 10 + num4) * 10 + num5;
					return true;
				}
			}
			num = 0;
			return false;
		}

		// Token: 0x0600030B RID: 779
		// RVA: 0x00007F6F File Offset: 0x0000616F
		private bool ParseChar(int start, char ch)
		{
			return start < this._length && this._text[start] == ch;
		}

		// Token: 0x06000305 RID: 773
		// RVA: 0x0002F6D4 File Offset: 0x0002D8D4
		private bool ParseDate(int start)
		{
			return this.Parse4Digit(start, out this.Year) && 1 <= this.Year && this.ParseChar(start + DateTimeParser.Lzyyyy, '-') && this.Parse2Digit(start + DateTimeParser.Lzyyyy_, out this.Month) && 1 <= this.Month && this.Month <= 12 && this.ParseChar(start + DateTimeParser.Lzyyyy_MM, '-') && this.Parse2Digit(start + DateTimeParser.Lzyyyy_MM_, out this.Day) && 1 <= this.Day && this.Day <= DateTime.DaysInMonth(this.Year, this.Month);
		}

		// Token: 0x06000307 RID: 775
		// RVA: 0x0002F788 File Offset: 0x0002D988
		private bool ParseTime(ref int start)
		{
			if (this.Parse2Digit(start, out this.Hour) && this.Hour < 24 && this.ParseChar(start + DateTimeParser.LzHH, ':') && this.Parse2Digit(start + DateTimeParser.LzHH_, out this.Minute) && this.Minute < 60 && this.ParseChar(start + DateTimeParser.LzHH_mm, ':') && this.Parse2Digit(start + DateTimeParser.LzHH_mm_, out this.Second) && this.Second < 60)
			{
				start += DateTimeParser.LzHH_mm_ss;
				if (this.ParseChar(start, '.'))
				{
					this.Fraction = 0;
					int num = 0;
					while (++start < this._length && num < 7)
					{
						int num2 = (int)(this._text[start] - '0');
						if (num2 < 0 || num2 > 9)
						{
							break;
						}
						this.Fraction = this.Fraction * 10 + num2;
						num++;
					}
					if (num < 7)
					{
						if (num == 0)
						{
							return false;
						}
						this.Fraction *= DateTimeParser.Power10[7 - num];
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x06000306 RID: 774
		// RVA: 0x00007F5A File Offset: 0x0000615A
		private bool ParseTimeAndZoneAndWhitespace(int start)
		{
			return this.ParseTime(ref start) && this.ParseZone(start);
		}

		// Token: 0x06000308 RID: 776
		// RVA: 0x0002F8B4 File Offset: 0x0002DAB4
		private bool ParseZone(int start)
		{
			if (start < this._length)
			{
				char c = this._text[start];
				if (c != 'Z')
				{
					if (c != 'z')
					{
						if (start + 2 < this._length && this.Parse2Digit(start + DateTimeParser.Lz_, out this.ZoneHour) && this.ZoneHour <= 99)
						{
							switch (c)
							{
							case '+':
								this.Zone = ParserTimeZone.LocalEastOfUtc;
								start += DateTimeParser.Lz_zz;
								break;
							case '-':
								this.Zone = ParserTimeZone.LocalWestOfUtc;
								start += DateTimeParser.Lz_zz;
								break;
							}
						}
						if (start >= this._length)
						{
							goto IL_10B;
						}
						if (this.ParseChar(start, ':'))
						{
							start++;
							if (start + 1 < this._length && this.Parse2Digit(start, out this.ZoneMinute) && this.ZoneMinute <= 99)
							{
								start += 2;
								goto IL_10B;
							}
							goto IL_10B;
						}
						else
						{
							if (start + 1 < this._length && this.Parse2Digit(start, out this.ZoneMinute) && this.ZoneMinute <= 99)
							{
								start += 2;
								goto IL_10B;
							}
							goto IL_10B;
						}
					}
				}
				this.Zone = ParserTimeZone.Utc;
				start++;
			}
			IL_10B:
			return start == this._length;
		}
	}
}
