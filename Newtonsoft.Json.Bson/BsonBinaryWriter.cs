using Newtonsoft.Json.Utilities;
using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000018 RID: 24
	internal sealed class BsonBinaryWriter
	{
		// Token: 0x0400004A RID: 74
		private static readonly Encoding Encoding = new UTF8Encoding(false);

		// Token: 0x0400004C RID: 76
		private byte[] _largeByteBuffer;

		// Token: 0x0400004B RID: 75
		private readonly BinaryWriter _writer;

		// Token: 0x17000001 RID: 1
		public DateTimeKind DateTimeKindHandling
		{
			// Token: 0x0600004A RID: 74
			// RVA: 0x00005ED2 File Offset: 0x000040D2
			get;
			// Token: 0x0600004B RID: 75
			// RVA: 0x00005EDA File Offset: 0x000040DA
			set;
		}

		// Token: 0x0600004C RID: 76
		// RVA: 0x00005EE3 File Offset: 0x000040E3
		public BsonBinaryWriter(BinaryWriter writer)
		{
			this.DateTimeKindHandling = DateTimeKind.Utc;
			this._writer = writer;
		}

		// Token: 0x06000053 RID: 83
		// RVA: 0x00005F55 File Offset: 0x00004155
		private int CalculateSize(int stringByteCount)
		{
			return stringByteCount + 1;
		}

		// Token: 0x06000055 RID: 85
		// RVA: 0x000289C0 File Offset: 0x00026BC0
		private int CalculateSize(BsonToken t)
		{
			switch (t.Type)
			{
			case BsonType.Number:
				return 8;
			case BsonType.String:
			{
				BsonString bsonString = (BsonString)t;
				string text = (string)bsonString.Value;
				bsonString.ByteCount = ((text != null) ? BsonBinaryWriter.Encoding.GetByteCount(text) : 0);
				bsonString.CalculatedSize = this.CalculateSizeWithLength(bsonString.ByteCount, bsonString.IncludeLength);
				return bsonString.CalculatedSize;
			}
			case BsonType.Object:
			{
				BsonObject bsonObject = (BsonObject)t;
				int num = 4;
				foreach (BsonProperty current in bsonObject)
				{
					int num2 = 1 + this.CalculateSize(current.Name);
					num2 += this.CalculateSize(current.Value);
					num += num2;
				}
				num++;
				bsonObject.CalculatedSize = num;
				return num;
			}
			case BsonType.Array:
			{
				BsonArray bsonArray = (BsonArray)t;
				int num3 = 4;
				ulong num4 = 0uL;
				foreach (BsonToken current2 in bsonArray)
				{
					num3++;
					num3 += this.CalculateSize(MathUtils.IntLength(num4));
					num3 += this.CalculateSize(current2);
					num4 += 1uL;
				}
				num3++;
				bsonArray.CalculatedSize = num3;
				return bsonArray.CalculatedSize;
			}
			case BsonType.Binary:
			{
				BsonBinary bsonBinary = (BsonBinary)t;
				byte[] array = (byte[])bsonBinary.Value;
				bsonBinary.CalculatedSize = 5 + array.Length;
				return bsonBinary.CalculatedSize;
			}
			case BsonType.Undefined:
			case BsonType.Null:
				return 0;
			case BsonType.Oid:
				return 12;
			case BsonType.Boolean:
				return 1;
			case BsonType.Date:
				return 8;
			case BsonType.Regex:
			{
				BsonRegex bsonRegex = (BsonRegex)t;
				int num5 = 0 + this.CalculateSize(bsonRegex.Pattern);
				num5 += this.CalculateSize(bsonRegex.Options);
				bsonRegex.CalculatedSize = num5;
				return bsonRegex.CalculatedSize;
			}
			case BsonType.Integer:
				return 4;
			case BsonType.Long:
				return 8;
			}
			throw new ArgumentOutOfRangeException("t", StringUtils.FormatWith("Unexpected token when writing BSON: {0}", CultureInfo.InvariantCulture, t.Type));
		}

		// Token: 0x06000054 RID: 84
		// RVA: 0x000289A8 File Offset: 0x00026BA8
		private int CalculateSizeWithLength(int stringByteCount, bool includeSize)
		{
			int num = includeSize ? 5 : 1;
			return num + stringByteCount;
		}

		// Token: 0x0600004E RID: 78
		// RVA: 0x00005F06 File Offset: 0x00004106
		public void Close()
		{
			this._writer.Close();
		}

		// Token: 0x0600004D RID: 77
		// RVA: 0x00005EF9 File Offset: 0x000040F9
		public void Flush()
		{
			this._writer.Flush();
		}

		// Token: 0x06000051 RID: 81
		// RVA: 0x00005F24 File Offset: 0x00004124
		private void WriteString(string s, int byteCount, int? calculatedlengthPrefix)
		{
			if (calculatedlengthPrefix.HasValue)
			{
				this._writer.Write(calculatedlengthPrefix.Value);
			}
			this.WriteUtf8Bytes(s, byteCount);
			this._writer.Write(0);
		}

		// Token: 0x0600004F RID: 79
		// RVA: 0x00005F13 File Offset: 0x00004113
		public void WriteToken(BsonToken t)
		{
			this.CalculateSize(t);
			this.WriteTokenInternal(t);
		}

		// Token: 0x06000050 RID: 80
		// RVA: 0x0002854C File Offset: 0x0002674C
		private void WriteTokenInternal(BsonToken t)
		{
			switch (t.Type)
			{
			case BsonType.Number:
			{
				BsonValue bsonValue = (BsonValue)t;
				this._writer.Write(Convert.ToDouble(bsonValue.Value, CultureInfo.InvariantCulture));
				return;
			}
			case BsonType.String:
			{
				BsonString bsonString = (BsonString)t;
				this.WriteString((string)bsonString.Value, bsonString.ByteCount, new int?(bsonString.CalculatedSize - 4));
				return;
			}
			case BsonType.Object:
			{
				BsonObject bsonObject = (BsonObject)t;
				this._writer.Write(bsonObject.CalculatedSize);
				foreach (BsonProperty current in bsonObject)
				{
					this._writer.Write((sbyte)current.Value.Type);
					this.WriteString((string)current.Name.Value, current.Name.ByteCount, null);
					this.WriteTokenInternal(current.Value);
				}
				this._writer.Write(0);
				return;
			}
			case BsonType.Array:
			{
				BsonArray bsonArray = (BsonArray)t;
				this._writer.Write(bsonArray.CalculatedSize);
				ulong num = 0uL;
				foreach (BsonToken current2 in bsonArray)
				{
					this._writer.Write((sbyte)current2.Type);
					this.WriteString(num.ToString(CultureInfo.InvariantCulture), MathUtils.IntLength(num), null);
					this.WriteTokenInternal(current2);
					num += 1uL;
				}
				this._writer.Write(0);
				return;
			}
			case BsonType.Binary:
			{
				BsonBinary bsonBinary = (BsonBinary)t;
				byte[] array = (byte[])bsonBinary.Value;
				this._writer.Write(array.Length);
				this._writer.Write((byte)bsonBinary.BinaryType);
				this._writer.Write(array);
				return;
			}
			case BsonType.Undefined:
			case BsonType.Null:
				return;
			case BsonType.Oid:
			{
				BsonValue bsonValue2 = (BsonValue)t;
				byte[] buffer = (byte[])bsonValue2.Value;
				this._writer.Write(buffer);
				return;
			}
			case BsonType.Boolean:
			{
				BsonValue bsonValue3 = (BsonValue)t;
				this._writer.Write((bool)bsonValue3.Value);
				return;
			}
			case BsonType.Date:
			{
				BsonValue bsonValue4 = (BsonValue)t;
				long value = 0L;
				if (bsonValue4.Value is DateTime)
				{
					DateTime dateTime = (DateTime)bsonValue4.Value;
					if (this.DateTimeKindHandling == DateTimeKind.Utc)
					{
						dateTime = dateTime.ToUniversalTime();
					}
					else if (this.DateTimeKindHandling == DateTimeKind.Local)
					{
						dateTime = dateTime.ToLocalTime();
					}
					value = DateTimeUtils.ConvertDateTimeToJavaScriptTicks(dateTime, false);
				}
				this._writer.Write(value);
				return;
			}
			case BsonType.Regex:
			{
				BsonRegex bsonRegex = (BsonRegex)t;
				this.WriteString((string)bsonRegex.Pattern.Value, bsonRegex.Pattern.ByteCount, null);
				this.WriteString((string)bsonRegex.Options.Value, bsonRegex.Options.ByteCount, null);
				return;
			}
			case BsonType.Integer:
			{
				BsonValue bsonValue5 = (BsonValue)t;
				this._writer.Write(Convert.ToInt32(bsonValue5.Value, CultureInfo.InvariantCulture));
				return;
			}
			case BsonType.Long:
			{
				BsonValue bsonValue6 = (BsonValue)t;
				this._writer.Write(Convert.ToInt64(bsonValue6.Value, CultureInfo.InvariantCulture));
				return;
			}
			}
			throw new ArgumentOutOfRangeException("t", StringUtils.FormatWith("Unexpected token when writing BSON: {0}", CultureInfo.InvariantCulture, t.Type));
		}

		// Token: 0x06000052 RID: 82
		// RVA: 0x00028930 File Offset: 0x00026B30
		public void WriteUtf8Bytes(string s, int byteCount)
		{
			if (s != null)
			{
				if (this._largeByteBuffer == null)
				{
					this._largeByteBuffer = new byte[256];
				}
				if (byteCount <= 256)
				{
					BsonBinaryWriter.Encoding.GetBytes(s, 0, s.Length, this._largeByteBuffer, 0);
					this._writer.Write(this._largeByteBuffer, 0, byteCount);
					return;
				}
				byte[] bytes = BsonBinaryWriter.Encoding.GetBytes(s);
				this._writer.Write(bytes);
			}
		}
	}
}
