using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000AD RID: 173
	public class JValue : JToken, IComparable<JValue>, IEquatable<JValue>, IConvertible, IComparable, IFormattable
	{
		// Token: 0x040002C4 RID: 708
		private object _value;

		// Token: 0x040002C3 RID: 707
		private JTokenType _valueType;

		// Token: 0x170000C8 RID: 200
		public override bool HasValues
		{
			// Token: 0x060005AD RID: 1453
			// RVA: 0x00006D86 File Offset: 0x00004F86
			get
			{
				return false;
			}
		}

		// Token: 0x170000C9 RID: 201
		public override JTokenType Type
		{
			// Token: 0x060005B7 RID: 1463
			// RVA: 0x000094C5 File Offset: 0x000076C5
			get
			{
				return this._valueType;
			}
		}

		// Token: 0x170000CA RID: 202
		public new object Value
		{
			// Token: 0x060005B8 RID: 1464
			// RVA: 0x000094CD File Offset: 0x000076CD
			get
			{
				return this._value;
			}
			// Token: 0x060005B9 RID: 1465
			// RVA: 0x0003566C File Offset: 0x0003386C
			set
			{
				Type type = (this._value != null) ? this._value.GetType() : null;
				Type type2 = (value != null) ? value.GetType() : null;
				if (type != type2)
				{
					this._valueType = JValue.GetValueType(new JTokenType?(this._valueType), value);
				}
				this._value = value;
			}
		}

		// Token: 0x0600059E RID: 1438
		// RVA: 0x000093C7 File Offset: 0x000075C7
		public JValue(JValue other) : this(other.Value, other.Type)
		{
		}

		// Token: 0x0600059F RID: 1439
		// RVA: 0x000093DB File Offset: 0x000075DB
		public JValue(long value) : this(value, JTokenType.Integer)
		{
		}

		// Token: 0x060005A0 RID: 1440
		// RVA: 0x000093EA File Offset: 0x000075EA
		public JValue(decimal value) : this(value, JTokenType.Float)
		{
		}

		// Token: 0x060005A1 RID: 1441
		// RVA: 0x000093F9 File Offset: 0x000075F9
		public JValue(char value) : this(value, JTokenType.String)
		{
		}

		// Token: 0x060005A2 RID: 1442
		// RVA: 0x00009408 File Offset: 0x00007608
		[CLSCompliant(false)]
		public JValue(ulong value) : this(value, JTokenType.Integer)
		{
		}

		// Token: 0x060005A3 RID: 1443
		// RVA: 0x00009417 File Offset: 0x00007617
		public JValue(double value) : this(value, JTokenType.Float)
		{
		}

		// Token: 0x060005A4 RID: 1444
		// RVA: 0x00009426 File Offset: 0x00007626
		public JValue(float value) : this(value, JTokenType.Float)
		{
		}

		// Token: 0x060005A5 RID: 1445
		// RVA: 0x00009435 File Offset: 0x00007635
		public JValue(DateTime value) : this(value, JTokenType.Date)
		{
		}

		// Token: 0x060005A6 RID: 1446
		// RVA: 0x00009445 File Offset: 0x00007645
		public JValue(bool value) : this(value, JTokenType.Boolean)
		{
		}

		// Token: 0x060005A7 RID: 1447
		// RVA: 0x00009455 File Offset: 0x00007655
		public JValue(string value) : this(value, JTokenType.String)
		{
		}

		// Token: 0x060005A8 RID: 1448
		// RVA: 0x0000945F File Offset: 0x0000765F
		public JValue(Guid value) : this(value, JTokenType.Guid)
		{
		}

		// Token: 0x060005A9 RID: 1449
		// RVA: 0x0000946F File Offset: 0x0000766F
		public JValue(Uri value) : this(value, (value != null) ? JTokenType.Uri : JTokenType.Null)
		{
		}

		// Token: 0x060005AA RID: 1450
		// RVA: 0x00009487 File Offset: 0x00007687
		public JValue(TimeSpan value) : this(value, JTokenType.TimeSpan)
		{
		}

		// Token: 0x060005AB RID: 1451
		// RVA: 0x00035258 File Offset: 0x00033458
		public JValue(object value) : this(value, JValue.GetValueType(null, value))
		{
		}

		// Token: 0x0600059D RID: 1437
		// RVA: 0x000093B1 File Offset: 0x000075B1
		internal JValue(object value, JTokenType type)
		{
			this._value = value;
			this._valueType = type;
		}

		// Token: 0x060005B0 RID: 1456
		// RVA: 0x00009497 File Offset: 0x00007697
		internal override JToken CloneToken()
		{
			return new JValue(this);
		}

		// Token: 0x060005AE RID: 1454
		// RVA: 0x000352A4 File Offset: 0x000334A4
		internal static int Compare(JTokenType valueType, object objA, object objB)
		{
			if (objA == null && objB == null)
			{
				return 0;
			}
			if (objA != null && objB == null)
			{
				return 1;
			}
			if (objA == null && objB != null)
			{
				return -1;
			}
			switch (valueType)
			{
			case JTokenType.Comment:
			case JTokenType.String:
			case JTokenType.Raw:
			{
				string strA = Convert.ToString(objA, CultureInfo.InvariantCulture);
				string strB = Convert.ToString(objB, CultureInfo.InvariantCulture);
				return string.CompareOrdinal(strA, strB);
			}
			case JTokenType.Integer:
				if (objA is ulong || objB is ulong || objA is decimal || objB is decimal)
				{
					return Convert.ToDecimal(objA, CultureInfo.InvariantCulture).CompareTo(Convert.ToDecimal(objB, CultureInfo.InvariantCulture));
				}
				if (!(objA is float) && !(objB is float) && !(objA is double) && !(objB is double))
				{
					return Convert.ToInt64(objA, CultureInfo.InvariantCulture).CompareTo(Convert.ToInt64(objB, CultureInfo.InvariantCulture));
				}
				return JValue.CompareFloat(objA, objB);
			case JTokenType.Float:
				return JValue.CompareFloat(objA, objB);
			case JTokenType.Boolean:
			{
				bool flag = Convert.ToBoolean(objA, CultureInfo.InvariantCulture);
				bool value = Convert.ToBoolean(objB, CultureInfo.InvariantCulture);
				return flag.CompareTo(value);
			}
			case JTokenType.Date:
			{
				DateTime dateTime = (DateTime)objA;
				DateTime value2 = Convert.ToDateTime(objB, CultureInfo.InvariantCulture);
				return dateTime.CompareTo(value2);
			}
			case JTokenType.Bytes:
			{
				if (!(objB is byte[]))
				{
					throw new ArgumentException("Object must be of type byte[].");
				}
				byte[] array = objA as byte[];
				byte[] array2 = objB as byte[];
				if (array == null)
				{
					return -1;
				}
				if (array2 == null)
				{
					return 1;
				}
				return MiscellaneousUtils.ByteArrayCompare(array, array2);
			}
			case JTokenType.Guid:
			{
				if (!(objB is Guid))
				{
					throw new ArgumentException("Object must be of type Guid.");
				}
				Guid guid = (Guid)objA;
				Guid value3 = (Guid)objB;
				return guid.CompareTo(value3);
			}
			case JTokenType.Uri:
			{
				if (!(objB is Uri))
				{
					throw new ArgumentException("Object must be of type Uri.");
				}
				Uri uri = (Uri)objA;
				Uri uri2 = (Uri)objB;
				return Comparer<string>.Default.Compare(uri.ToString(), uri2.ToString());
			}
			case JTokenType.TimeSpan:
			{
				if (!(objB is TimeSpan))
				{
					throw new ArgumentException("Object must be of type TimeSpan.");
				}
				TimeSpan timeSpan = (TimeSpan)objA;
				TimeSpan value4 = (TimeSpan)objB;
				return timeSpan.CompareTo(value4);
			}
			}
			throw MiscellaneousUtils.CreateArgumentOutOfRangeException("valueType", valueType, StringUtils.FormatWith("Unexpected value type: {0}", CultureInfo.InvariantCulture, valueType));
		}

		// Token: 0x060005AF RID: 1455
		// RVA: 0x000354F4 File Offset: 0x000336F4
		private static int CompareFloat(object objA, object objB)
		{
			double d = Convert.ToDouble(objA, CultureInfo.InvariantCulture);
			double num = Convert.ToDouble(objB, CultureInfo.InvariantCulture);
			if (MathUtils.ApproxEquals(d, num))
			{
				return 0;
			}
			return d.CompareTo(num);
		}

		// Token: 0x060005C5 RID: 1477
		// RVA: 0x0000955F File Offset: 0x0000775F
		public int CompareTo(JValue obj)
		{
			if (obj == null)
			{
				return 1;
			}
			return JValue.Compare(this._valueType, this._value, obj._value);
		}

		// Token: 0x060005B1 RID: 1457
		// RVA: 0x0000949F File Offset: 0x0000769F
		public static JValue CreateComment(string value)
		{
			return new JValue(value, JTokenType.Comment);
		}

		// Token: 0x060005B3 RID: 1459
		// RVA: 0x000094B1 File Offset: 0x000076B1
		public static JValue CreateNull()
		{
			return new JValue(null, JTokenType.Null);
		}

		// Token: 0x060005B2 RID: 1458
		// RVA: 0x000094A8 File Offset: 0x000076A8
		public static JValue CreateString(string value)
		{
			return new JValue(value, JTokenType.String);
		}

		// Token: 0x060005B4 RID: 1460
		// RVA: 0x000094BB File Offset: 0x000076BB
		public static JValue CreateUndefined()
		{
			return new JValue(null, JTokenType.Undefined);
		}

		// Token: 0x060005AC RID: 1452
		// RVA: 0x0003527C File Offset: 0x0003347C
		internal override bool DeepEquals(JToken node)
		{
			JValue jValue = node as JValue;
			return jValue != null && (jValue == this || JValue.ValuesEquals(this, jValue));
		}

		// Token: 0x060005BD RID: 1469
		// RVA: 0x00009507 File Offset: 0x00007707
		public bool Equals(JValue other)
		{
			return other != null && JValue.ValuesEquals(this, other);
		}

		// Token: 0x060005BE RID: 1470
		// RVA: 0x000358EC File Offset: 0x00033AEC
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			JValue jValue = obj as JValue;
			if (jValue != null)
			{
				return this.Equals(jValue);
			}
			return base.Equals(obj);
		}

		// Token: 0x060005BB RID: 1467
		// RVA: 0x000358B8 File Offset: 0x00033AB8
		internal override int GetDeepHashCode()
		{
			int num = (this._value != null) ? this._value.GetHashCode() : 0;
			int valueType = (int)this._valueType;
			return valueType.GetHashCode() ^ num;
		}

		// Token: 0x060005BF RID: 1471
		// RVA: 0x00009515 File Offset: 0x00007715
		public override int GetHashCode()
		{
			if (this._value == null)
			{
				return 0;
			}
			return this._value.GetHashCode();
		}

		// Token: 0x060005B6 RID: 1462
		// RVA: 0x00035634 File Offset: 0x00033834
		private static JTokenType GetStringValueType(JTokenType? current)
		{
			if (!current.HasValue)
			{
				return JTokenType.String;
			}
			JTokenType value = current.Value;
			if (value != JTokenType.Comment && value != JTokenType.String)
			{
				if (value != JTokenType.Raw)
				{
					return JTokenType.String;
				}
			}
			return current.Value;
		}

		// Token: 0x060005B5 RID: 1461
		// RVA: 0x0003552C File Offset: 0x0003372C
		private static JTokenType GetValueType(JTokenType? current, object value)
		{
			if (value == null)
			{
				return JTokenType.Null;
			}
			if (value == DBNull.Value)
			{
				return JTokenType.Null;
			}
			if (value is string)
			{
				return JValue.GetStringValueType(current);
			}
			if (value is long || value is int || value is short || value is sbyte || value is ulong || value is uint || value is ushort || value is byte)
			{
				return JTokenType.Integer;
			}
			if (value is Enum)
			{
				return JTokenType.Integer;
			}
			if (value is double || value is float || value is decimal)
			{
				return JTokenType.Float;
			}
			if (value is DateTime)
			{
				return JTokenType.Date;
			}
			if (value is byte[])
			{
				return JTokenType.Bytes;
			}
			if (value is bool)
			{
				return JTokenType.Boolean;
			}
			if (value is Guid)
			{
				return JTokenType.Guid;
			}
			if (value is Uri)
			{
				return JTokenType.Uri;
			}
			if (value is TimeSpan)
			{
				return JTokenType.TimeSpan;
			}
			throw new ArgumentException(StringUtils.FormatWith("Could not determine JSON object type for type {0}.", CultureInfo.InvariantCulture, value.GetType()));
		}

		// Token: 0x060005C4 RID: 1476
		// RVA: 0x00035958 File Offset: 0x00033B58
		int IComparable.CompareTo(object obj)
		{
			if (obj == null)
			{
				return 1;
			}
			object objB = (obj is JValue) ? ((JValue)obj).Value : obj;
			return JValue.Compare(this._valueType, this._value, objB);
		}

		// Token: 0x060005C6 RID: 1478
		// RVA: 0x0000957D File Offset: 0x0000777D
		TypeCode IConvertible.GetTypeCode()
		{
			if (this._value == null)
			{
				return TypeCode.Empty;
			}
			return System.Type.GetTypeCode(this._value.GetType());
		}

		// Token: 0x060005C7 RID: 1479
		// RVA: 0x00009599 File Offset: 0x00007799
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return (bool)this;
		}

		// Token: 0x060005CA RID: 1482
		// RVA: 0x000095B1 File Offset: 0x000077B1
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return (byte)this;
		}

		// Token: 0x060005C8 RID: 1480
		// RVA: 0x000095A1 File Offset: 0x000077A1
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return (char)this;
		}

		// Token: 0x060005D4 RID: 1492
		// RVA: 0x00009603 File Offset: 0x00007803
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			return (DateTime)this;
		}

		// Token: 0x060005D3 RID: 1491
		// RVA: 0x000095FB File Offset: 0x000077FB
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return (decimal)this;
		}

		// Token: 0x060005D2 RID: 1490
		// RVA: 0x000095F2 File Offset: 0x000077F2
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return (double)this;
		}

		// Token: 0x060005CB RID: 1483
		// RVA: 0x000095B9 File Offset: 0x000077B9
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return (short)this;
		}

		// Token: 0x060005CD RID: 1485
		// RVA: 0x000095C9 File Offset: 0x000077C9
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return (int)this;
		}

		// Token: 0x060005CF RID: 1487
		// RVA: 0x000095D9 File Offset: 0x000077D9
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return (long)this;
		}

		// Token: 0x060005C9 RID: 1481
		// RVA: 0x000095A9 File Offset: 0x000077A9
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return (sbyte)this;
		}

		// Token: 0x060005D1 RID: 1489
		// RVA: 0x000095E9 File Offset: 0x000077E9
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return (float)this;
		}

		// Token: 0x060005D5 RID: 1493
		// RVA: 0x0000960B File Offset: 0x0000780B
		object IConvertible.ToType(Type conversionType, IFormatProvider provider)
		{
			return base.ToObject(conversionType);
		}

		// Token: 0x060005CC RID: 1484
		// RVA: 0x000095C1 File Offset: 0x000077C1
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return (ushort)this;
		}

		// Token: 0x060005CE RID: 1486
		// RVA: 0x000095D1 File Offset: 0x000077D1
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return (uint)this;
		}

		// Token: 0x060005D0 RID: 1488
		// RVA: 0x000095E1 File Offset: 0x000077E1
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return (ulong)this;
		}

		// Token: 0x060005C0 RID: 1472
		// RVA: 0x0000952C File Offset: 0x0000772C
		public override string ToString()
		{
			if (this._value == null)
			{
				return string.Empty;
			}
			return this._value.ToString();
		}

		// Token: 0x060005C1 RID: 1473
		// RVA: 0x00009547 File Offset: 0x00007747
		public string ToString(string format)
		{
			return this.ToString(format, CultureInfo.CurrentCulture);
		}

		// Token: 0x060005C2 RID: 1474
		// RVA: 0x00009555 File Offset: 0x00007755
		public string ToString(IFormatProvider formatProvider)
		{
			return this.ToString(null, formatProvider);
		}

		// Token: 0x060005C3 RID: 1475
		// RVA: 0x00035918 File Offset: 0x00033B18
		public string ToString(string format, IFormatProvider formatProvider)
		{
			if (this._value == null)
			{
				return string.Empty;
			}
			IFormattable formattable = this._value as IFormattable;
			if (formattable != null)
			{
				return formattable.ToString(format, formatProvider);
			}
			return this._value.ToString();
		}

		// Token: 0x060005BC RID: 1468
		// RVA: 0x000094D5 File Offset: 0x000076D5
		private static bool ValuesEquals(JValue v1, JValue v2)
		{
			return v1 == v2 || (v1._valueType == v2._valueType && JValue.Compare(v1._valueType, v1._value, v2._value) == 0);
		}

		// Token: 0x060005BA RID: 1466
		// RVA: 0x000356C0 File Offset: 0x000338C0
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			if (converters != null && converters.Length > 0 && this._value != null)
			{
				JsonConverter matchingConverter = JsonSerializer.GetMatchingConverter(converters, this._value.GetType());
				if (matchingConverter != null && matchingConverter.CanWrite)
				{
					matchingConverter.WriteJson(writer, this._value, JsonSerializer.CreateDefault());
					return;
				}
			}
			switch (this._valueType)
			{
			case JTokenType.Comment:
				writer.WriteComment((this._value != null) ? this._value.ToString() : null);
				return;
			case JTokenType.Integer:
				writer.WriteValue(Convert.ToInt64(this._value, CultureInfo.InvariantCulture));
				return;
			case JTokenType.Float:
				if (this._value is decimal)
				{
					writer.WriteValue((decimal)this._value);
					return;
				}
				if (this._value is double)
				{
					writer.WriteValue((double)this._value);
					return;
				}
				if (this._value is float)
				{
					writer.WriteValue((float)this._value);
					return;
				}
				writer.WriteValue(Convert.ToDouble(this._value, CultureInfo.InvariantCulture));
				return;
			case JTokenType.String:
				writer.WriteValue((this._value != null) ? this._value.ToString() : null);
				return;
			case JTokenType.Boolean:
				writer.WriteValue(Convert.ToBoolean(this._value, CultureInfo.InvariantCulture));
				return;
			case JTokenType.Null:
				writer.WriteNull();
				return;
			case JTokenType.Undefined:
				writer.WriteUndefined();
				return;
			case JTokenType.Date:
				writer.WriteValue(Convert.ToDateTime(this._value, CultureInfo.InvariantCulture));
				return;
			case JTokenType.Raw:
				writer.WriteRawValue((this._value != null) ? this._value.ToString() : null);
				return;
			case JTokenType.Bytes:
				writer.WriteValue((byte[])this._value);
				return;
			case JTokenType.Guid:
			case JTokenType.Uri:
			case JTokenType.TimeSpan:
				writer.WriteValue((this._value != null) ? this._value.ToString() : null);
				return;
			default:
				throw MiscellaneousUtils.CreateArgumentOutOfRangeException("TokenType", this._valueType, "Unexpected token type.");
			}
		}
	}
}
