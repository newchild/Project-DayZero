using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000149 RID: 329
	internal static class ConvertUtils
	{
		// Token: 0x0200014B RID: 331
		internal enum ConvertResult
		{
			// Token: 0x04000594 RID: 1428
			Success,
			// Token: 0x04000595 RID: 1429
			CannotConvertNull,
			// Token: 0x04000596 RID: 1430
			NotInstantiableType,
			// Token: 0x04000597 RID: 1431
			NoValidConversion
		}

		// Token: 0x0200014A RID: 330
		internal struct TypeConvertKey : IEquatable<ConvertUtils.TypeConvertKey>
		{
			// Token: 0x04000591 RID: 1425
			private readonly Type _initialType;

			// Token: 0x04000592 RID: 1426
			private readonly Type _targetType;

			// Token: 0x1700025E RID: 606
			public Type InitialType
			{
				// Token: 0x06000CEF RID: 3311
				// RVA: 0x0000DAB9 File Offset: 0x0000BCB9
				get
				{
					return this._initialType;
				}
			}

			// Token: 0x1700025F RID: 607
			public Type TargetType
			{
				// Token: 0x06000CF0 RID: 3312
				// RVA: 0x0000DAC1 File Offset: 0x0000BCC1
				get
				{
					return this._targetType;
				}
			}

			// Token: 0x06000CF1 RID: 3313
			// RVA: 0x0000DAC9 File Offset: 0x0000BCC9
			public TypeConvertKey(Type initialType, Type targetType)
			{
				this._initialType = initialType;
				this._targetType = targetType;
			}

			// Token: 0x06000CF3 RID: 3315
			// RVA: 0x0000DAF2 File Offset: 0x0000BCF2
			public override bool Equals(object obj)
			{
				return obj is ConvertUtils.TypeConvertKey && this.Equals((ConvertUtils.TypeConvertKey)obj);
			}

			// Token: 0x06000CF4 RID: 3316
			// RVA: 0x0000DB0A File Offset: 0x0000BD0A
			public bool Equals(ConvertUtils.TypeConvertKey other)
			{
				return this._initialType == other._initialType && this._targetType == other._targetType;
			}

			// Token: 0x06000CF2 RID: 3314
			// RVA: 0x0000DAD9 File Offset: 0x0000BCD9
			public override int GetHashCode()
			{
				return this._initialType.GetHashCode() ^ this._targetType.GetHashCode();
			}
		}

		// Token: 0x04000590 RID: 1424
		private static readonly ThreadSafeStore<ConvertUtils.TypeConvertKey, Func<object, object>> CastConverters = new ThreadSafeStore<ConvertUtils.TypeConvertKey, Func<object, object>>(new Func<ConvertUtils.TypeConvertKey, Func<object, object>>(ConvertUtils.CreateCastConverter));

		// Token: 0x0400058F RID: 1423
		private static readonly TypeInformation[] PrimitiveTypeCodes = new TypeInformation[]
		{
			new TypeInformation
			{
				Type = typeof(object),
				TypeCode = PrimitiveTypeCode.Empty
			},
			new TypeInformation
			{
				Type = typeof(object),
				TypeCode = PrimitiveTypeCode.Object
			},
			new TypeInformation
			{
				Type = typeof(object),
				TypeCode = PrimitiveTypeCode.DBNull
			},
			new TypeInformation
			{
				Type = typeof(bool),
				TypeCode = PrimitiveTypeCode.Boolean
			},
			new TypeInformation
			{
				Type = typeof(char),
				TypeCode = PrimitiveTypeCode.Char
			},
			new TypeInformation
			{
				Type = typeof(sbyte),
				TypeCode = PrimitiveTypeCode.SByte
			},
			new TypeInformation
			{
				Type = typeof(byte),
				TypeCode = PrimitiveTypeCode.Byte
			},
			new TypeInformation
			{
				Type = typeof(short),
				TypeCode = PrimitiveTypeCode.Int16
			},
			new TypeInformation
			{
				Type = typeof(ushort),
				TypeCode = PrimitiveTypeCode.UInt16
			},
			new TypeInformation
			{
				Type = typeof(int),
				TypeCode = PrimitiveTypeCode.Int32
			},
			new TypeInformation
			{
				Type = typeof(uint),
				TypeCode = PrimitiveTypeCode.UInt32
			},
			new TypeInformation
			{
				Type = typeof(long),
				TypeCode = PrimitiveTypeCode.Int64
			},
			new TypeInformation
			{
				Type = typeof(ulong),
				TypeCode = PrimitiveTypeCode.UInt64
			},
			new TypeInformation
			{
				Type = typeof(float),
				TypeCode = PrimitiveTypeCode.Single
			},
			new TypeInformation
			{
				Type = typeof(double),
				TypeCode = PrimitiveTypeCode.Double
			},
			new TypeInformation
			{
				Type = typeof(decimal),
				TypeCode = PrimitiveTypeCode.Decimal
			},
			new TypeInformation
			{
				Type = typeof(DateTime),
				TypeCode = PrimitiveTypeCode.DateTime
			},
			new TypeInformation
			{
				Type = typeof(object),
				TypeCode = PrimitiveTypeCode.Empty
			},
			new TypeInformation
			{
				Type = typeof(string),
				TypeCode = PrimitiveTypeCode.String
			}
		};

		// Token: 0x0400058E RID: 1422
		private static readonly Dictionary<Type, PrimitiveTypeCode> TypeCodeMap = new Dictionary<Type, PrimitiveTypeCode>
		{
			{
				typeof(char),
				PrimitiveTypeCode.Char
			},
			{
				typeof(char?),
				PrimitiveTypeCode.CharNullable
			},
			{
				typeof(bool),
				PrimitiveTypeCode.Boolean
			},
			{
				typeof(bool?),
				PrimitiveTypeCode.BooleanNullable
			},
			{
				typeof(sbyte),
				PrimitiveTypeCode.SByte
			},
			{
				typeof(sbyte?),
				PrimitiveTypeCode.SByteNullable
			},
			{
				typeof(short),
				PrimitiveTypeCode.Int16
			},
			{
				typeof(short?),
				PrimitiveTypeCode.Int16Nullable
			},
			{
				typeof(ushort),
				PrimitiveTypeCode.UInt16
			},
			{
				typeof(ushort?),
				PrimitiveTypeCode.UInt16Nullable
			},
			{
				typeof(int),
				PrimitiveTypeCode.Int32
			},
			{
				typeof(int?),
				PrimitiveTypeCode.Int32Nullable
			},
			{
				typeof(byte),
				PrimitiveTypeCode.Byte
			},
			{
				typeof(byte?),
				PrimitiveTypeCode.ByteNullable
			},
			{
				typeof(uint),
				PrimitiveTypeCode.UInt32
			},
			{
				typeof(uint?),
				PrimitiveTypeCode.UInt32Nullable
			},
			{
				typeof(long),
				PrimitiveTypeCode.Int64
			},
			{
				typeof(long?),
				PrimitiveTypeCode.Int64Nullable
			},
			{
				typeof(ulong),
				PrimitiveTypeCode.UInt64
			},
			{
				typeof(ulong?),
				PrimitiveTypeCode.UInt64Nullable
			},
			{
				typeof(float),
				PrimitiveTypeCode.Single
			},
			{
				typeof(float?),
				PrimitiveTypeCode.SingleNullable
			},
			{
				typeof(double),
				PrimitiveTypeCode.Double
			},
			{
				typeof(double?),
				PrimitiveTypeCode.DoubleNullable
			},
			{
				typeof(DateTime),
				PrimitiveTypeCode.DateTime
			},
			{
				typeof(DateTime?),
				PrimitiveTypeCode.DateTimeNullable
			},
			{
				typeof(decimal),
				PrimitiveTypeCode.Decimal
			},
			{
				typeof(decimal?),
				PrimitiveTypeCode.DecimalNullable
			},
			{
				typeof(Guid),
				PrimitiveTypeCode.Guid
			},
			{
				typeof(Guid?),
				PrimitiveTypeCode.GuidNullable
			},
			{
				typeof(TimeSpan),
				PrimitiveTypeCode.TimeSpan
			},
			{
				typeof(TimeSpan?),
				PrimitiveTypeCode.TimeSpanNullable
			},
			{
				typeof(Uri),
				PrimitiveTypeCode.Uri
			},
			{
				typeof(string),
				PrimitiveTypeCode.String
			},
			{
				typeof(byte[]),
				PrimitiveTypeCode.Bytes
			},
			{
				typeof(DBNull),
				PrimitiveTypeCode.DBNull
			}
		};

		// Token: 0x06000CE3 RID: 3299
		// RVA: 0x00049558 File Offset: 0x00047758
		public static object Convert(object initialValue, CultureInfo culture, Type targetType)
		{
			object result;
			switch (ConvertUtils.TryConvertInternal(initialValue, culture, targetType, out result))
			{
			case ConvertUtils.ConvertResult.Success:
				return result;
			case ConvertUtils.ConvertResult.CannotConvertNull:
				throw new Exception(StringUtils.FormatWith("Can not convert null {0} into non-nullable {1}.", CultureInfo.InvariantCulture, initialValue.GetType(), targetType));
			case ConvertUtils.ConvertResult.NotInstantiableType:
				throw new ArgumentException(StringUtils.FormatWith("Target type {0} is not a value type or a non-abstract class.", CultureInfo.InvariantCulture, targetType), "targetType");
			case ConvertUtils.ConvertResult.NoValidConversion:
				throw new InvalidOperationException(StringUtils.FormatWith("Can not convert from {0} to {1}.", CultureInfo.InvariantCulture, initialValue.GetType(), targetType));
			default:
				throw new InvalidOperationException("Unexpected conversion result.");
			}
		}

		// Token: 0x06000CE6 RID: 3302
		// RVA: 0x00049850 File Offset: 0x00047A50
		public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType)
		{
			if (targetType == typeof(object))
			{
				return initialValue;
			}
			if (initialValue == null && ReflectionUtils.IsNullable(targetType))
			{
				return null;
			}
			object result;
			if (ConvertUtils.TryConvert(initialValue, culture, targetType, out result))
			{
				return result;
			}
			return ConvertUtils.EnsureTypeAssignable(initialValue, ReflectionUtils.GetObjectType(initialValue), targetType);
		}

		// Token: 0x06000CE2 RID: 3298
		// RVA: 0x000494D8 File Offset: 0x000476D8
		private static Func<object, object> CreateCastConverter(ConvertUtils.TypeConvertKey t)
		{
			MethodInfo method = t.TargetType.GetMethod("op_Implicit", new Type[]
			{
				t.InitialType
			});
			if (method == null)
			{
				method = t.TargetType.GetMethod("op_Explicit", new Type[]
				{
					t.InitialType
				});
			}
			if (method == null)
			{
				return null;
			}
			MethodCall<object, object> call = JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(method);
			return (object o) => call(null, new object[]
			{
				o
			});
		}

		// Token: 0x06000CE7 RID: 3303
		// RVA: 0x00049894 File Offset: 0x00047A94
		private static object EnsureTypeAssignable(object value, Type initialType, Type targetType)
		{
			Type type = (value != null) ? value.GetType() : null;
			if (value != null)
			{
				if (targetType.IsAssignableFrom(type))
				{
					return value;
				}
				Func<object, object> func = ConvertUtils.CastConverters.Get(new ConvertUtils.TypeConvertKey(type, targetType));
				if (func != null)
				{
					return func(value);
				}
			}
			else if (ReflectionUtils.IsNullable(targetType))
			{
				return null;
			}
			throw new ArgumentException(StringUtils.FormatWith("Could not cast or convert from {0} to {1}.", CultureInfo.InvariantCulture, (initialType != null) ? initialType.ToString() : "{null}", targetType));
		}

		// Token: 0x06000CE9 RID: 3305
		// RVA: 0x0000DAB1 File Offset: 0x0000BCB1
		internal static TypeConverter GetConverter(Type t)
		{
			return JsonTypeReflector.GetTypeConverter(t);
		}

		// Token: 0x06000CDD RID: 3293
		// RVA: 0x00049424 File Offset: 0x00047624
		public static PrimitiveTypeCode GetTypeCode(Type t)
		{
			bool flag;
			return ConvertUtils.GetTypeCode(t, out flag);
		}

		// Token: 0x06000CDE RID: 3294
		// RVA: 0x0004943C File Offset: 0x0004763C
		public static PrimitiveTypeCode GetTypeCode(Type t, out bool isEnum)
		{
			PrimitiveTypeCode result;
			if (ConvertUtils.TypeCodeMap.TryGetValue(t, out result))
			{
				isEnum = false;
				return result;
			}
			if (TypeExtensions.IsEnum(t))
			{
				isEnum = true;
				return ConvertUtils.GetTypeCode(Enum.GetUnderlyingType(t));
			}
			if (ReflectionUtils.IsNullableType(t))
			{
				Type underlyingType = Nullable.GetUnderlyingType(t);
				if (TypeExtensions.IsEnum(underlyingType))
				{
					Type t2 = typeof(Nullable<>).MakeGenericType(new Type[]
					{
						Enum.GetUnderlyingType(underlyingType)
					});
					isEnum = true;
					return ConvertUtils.GetTypeCode(t2);
				}
			}
			isEnum = false;
			return PrimitiveTypeCode.Object;
		}

		// Token: 0x06000CDF RID: 3295
		// RVA: 0x000494BC File Offset: 0x000476BC
		public static TypeInformation GetTypeInformation(IConvertible convertable)
		{
			return ConvertUtils.PrimitiveTypeCodes[(int)convertable.GetTypeCode()];
		}

		// Token: 0x06000CEB RID: 3307
		// RVA: 0x00049A14 File Offset: 0x00047C14
		public static ParseResult Int32TryParse(char[] chars, int start, int length, out int value)
		{
			value = 0;
			if (length == 0)
			{
				return ParseResult.Invalid;
			}
			bool flag;
			if (flag = (chars[start] == '-'))
			{
				if (length == 1)
				{
					return ParseResult.Invalid;
				}
				start++;
				length--;
			}
			int num = start + length;
			for (int i = start; i < num; i++)
			{
				int num2 = (int)(chars[i] - '0');
				if (num2 < 0 || num2 > 9)
				{
					return ParseResult.Invalid;
				}
				int num3 = 10 * value - num2;
				if (num3 > value)
				{
					for (i++; i < num; i++)
					{
						num2 = (int)(chars[i] - '0');
						if (num2 < 0 || num2 > 9)
						{
							return ParseResult.Invalid;
						}
					}
					return ParseResult.Overflow;
				}
				value = num3;
			}
			if (!flag)
			{
				if (value == -2147483648)
				{
					return ParseResult.Overflow;
				}
				value = -value;
			}
			return ParseResult.Success;
		}

		// Token: 0x06000CEC RID: 3308
		// RVA: 0x00049AB0 File Offset: 0x00047CB0
		public static ParseResult Int64TryParse(char[] chars, int start, int length, out long value)
		{
			value = 0L;
			if (length == 0)
			{
				return ParseResult.Invalid;
			}
			bool flag;
			if (flag = (chars[start] == '-'))
			{
				if (length == 1)
				{
					return ParseResult.Invalid;
				}
				start++;
				length--;
			}
			int num = start + length;
			for (int i = start; i < num; i++)
			{
				int num2 = (int)(chars[i] - '0');
				if (num2 < 0 || num2 > 9)
				{
					return ParseResult.Invalid;
				}
				long num3 = 10L * value - (long)num2;
				if (num3 > value)
				{
					for (i++; i < num; i++)
					{
						num2 = (int)(chars[i] - '0');
						if (num2 < 0 || num2 > 9)
						{
							return ParseResult.Invalid;
						}
					}
					return ParseResult.Overflow;
				}
				value = num3;
			}
			if (!flag)
			{
				if (value == -9223372036854775808L)
				{
					return ParseResult.Overflow;
				}
				value = -value;
			}
			return ParseResult.Success;
		}

		// Token: 0x06000CE0 RID: 3296
		// RVA: 0x0000DA97 File Offset: 0x0000BC97
		public static bool IsConvertible(Type t)
		{
			return typeof(IConvertible).IsAssignableFrom(t);
		}

		// Token: 0x06000CEA RID: 3306
		// RVA: 0x000499B4 File Offset: 0x00047BB4
		public static bool IsInteger(object value)
		{
			switch (ConvertUtils.GetTypeCode(value.GetType()))
			{
			case PrimitiveTypeCode.SByte:
			case PrimitiveTypeCode.Int16:
			case PrimitiveTypeCode.UInt16:
			case PrimitiveTypeCode.Int32:
			case PrimitiveTypeCode.Byte:
			case PrimitiveTypeCode.UInt32:
			case PrimitiveTypeCode.Int64:
			case PrimitiveTypeCode.UInt64:
				return true;
			case PrimitiveTypeCode.SByteNullable:
			case PrimitiveTypeCode.Int16Nullable:
			case PrimitiveTypeCode.UInt16Nullable:
			case PrimitiveTypeCode.Int32Nullable:
			case PrimitiveTypeCode.ByteNullable:
			case PrimitiveTypeCode.UInt32Nullable:
			case PrimitiveTypeCode.Int64Nullable:
				return false;
			}
			return false;
		}

		// Token: 0x06000CE1 RID: 3297
		// RVA: 0x0000DAA9 File Offset: 0x0000BCA9
		public static TimeSpan ParseTimeSpan(string input)
		{
			return TimeSpan.Parse(input);
		}

		// Token: 0x06000CE8 RID: 3304
		// RVA: 0x00049908 File Offset: 0x00047B08
		public static object ToValue(INullable nullableValue)
		{
			if (nullableValue == null)
			{
				return null;
			}
			if (nullableValue is SqlInt32)
			{
				return ConvertUtils.ToValue((SqlInt32)nullableValue);
			}
			if (nullableValue is SqlInt64)
			{
				return ConvertUtils.ToValue((SqlInt64)nullableValue);
			}
			if (nullableValue is SqlBoolean)
			{
				return ConvertUtils.ToValue((SqlBoolean)nullableValue);
			}
			if (nullableValue is SqlString)
			{
				return ConvertUtils.ToValue((SqlString)nullableValue);
			}
			if (!(nullableValue is SqlDateTime))
			{
				throw new ArgumentException(StringUtils.FormatWith("Unsupported INullable type: {0}", CultureInfo.InvariantCulture, nullableValue.GetType()));
			}
			return ConvertUtils.ToValue((SqlDateTime)nullableValue);
		}

		// Token: 0x06000CE4 RID: 3300
		// RVA: 0x000495E8 File Offset: 0x000477E8
		private static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, out object value)
		{
			bool result;
			try
			{
				if (ConvertUtils.TryConvertInternal(initialValue, culture, targetType, out value) == ConvertUtils.ConvertResult.Success)
				{
					result = true;
				}
				else
				{
					value = null;
					result = false;
				}
			}
			catch
			{
				value = null;
				result = false;
			}
			return result;
		}

		// Token: 0x06000CED RID: 3309
		// RVA: 0x00049B60 File Offset: 0x00047D60
		public static bool TryConvertGuid(string s, out Guid g)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			Regex regex = new Regex("^[A-Fa-f0-9]{32}$|^({|\\()?[A-Fa-f0-9]{8}-([A-Fa-f0-9]{4}-){3}[A-Fa-f0-9]{12}(}|\\))?$|^({)?[0xA-Fa-f0-9]{3,10}(, {0,1}[0xA-Fa-f0-9]{3,6}){2}, {0,1}({)([0xA-Fa-f0-9]{3,4}, {0,1}){7}[0xA-Fa-f0-9]{3,4}(}})$");
			Match match = regex.Match(s);
			if (match.Success)
			{
				g = new Guid(s);
				return true;
			}
			g = Guid.Empty;
			return false;
		}

		// Token: 0x06000CE5 RID: 3301
		// RVA: 0x00049624 File Offset: 0x00047824
		private static ConvertUtils.ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, Type targetType, out object value)
		{
			if (initialValue == null)
			{
				throw new ArgumentNullException("initialValue");
			}
			if (ReflectionUtils.IsNullableType(targetType))
			{
				targetType = Nullable.GetUnderlyingType(targetType);
			}
			Type type = initialValue.GetType();
			if (targetType == type)
			{
				value = initialValue;
				return ConvertUtils.ConvertResult.Success;
			}
			if (ConvertUtils.IsConvertible(initialValue.GetType()) && ConvertUtils.IsConvertible(targetType))
			{
				if (TypeExtensions.IsEnum(targetType))
				{
					if (initialValue is string)
					{
						value = Enum.Parse(targetType, initialValue.ToString(), true);
						return ConvertUtils.ConvertResult.Success;
					}
					if (ConvertUtils.IsInteger(initialValue))
					{
						value = Enum.ToObject(targetType, initialValue);
						return ConvertUtils.ConvertResult.Success;
					}
				}
				value = System.Convert.ChangeType(initialValue, targetType, culture);
				return ConvertUtils.ConvertResult.Success;
			}
			if (initialValue is byte[] && targetType == typeof(Guid))
			{
				value = new Guid((byte[])initialValue);
				return ConvertUtils.ConvertResult.Success;
			}
			if (initialValue is Guid && targetType == typeof(byte[]))
			{
				value = ((Guid)initialValue).ToByteArray();
				return ConvertUtils.ConvertResult.Success;
			}
			if (initialValue is string)
			{
				if (targetType == typeof(Guid))
				{
					value = new Guid((string)initialValue);
					return ConvertUtils.ConvertResult.Success;
				}
				if (targetType == typeof(Uri))
				{
					value = new Uri((string)initialValue, UriKind.RelativeOrAbsolute);
					return ConvertUtils.ConvertResult.Success;
				}
				if (targetType == typeof(TimeSpan))
				{
					value = ConvertUtils.ParseTimeSpan((string)initialValue);
					return ConvertUtils.ConvertResult.Success;
				}
				if (targetType == typeof(byte[]))
				{
					value = System.Convert.FromBase64String((string)initialValue);
					return ConvertUtils.ConvertResult.Success;
				}
				if (typeof(Type).IsAssignableFrom(targetType))
				{
					value = Type.GetType((string)initialValue, true);
					return ConvertUtils.ConvertResult.Success;
				}
			}
			TypeConverter converter = ConvertUtils.GetConverter(type);
			if (converter != null && converter.CanConvertTo(targetType))
			{
				value = converter.ConvertTo(null, culture, initialValue, targetType);
				return ConvertUtils.ConvertResult.Success;
			}
			TypeConverter converter2 = ConvertUtils.GetConverter(targetType);
			if (converter2 != null && converter2.CanConvertFrom(type))
			{
				value = converter2.ConvertFrom(null, culture, initialValue);
				return ConvertUtils.ConvertResult.Success;
			}
			if (initialValue == DBNull.Value)
			{
				if (ReflectionUtils.IsNullable(targetType))
				{
					value = ConvertUtils.EnsureTypeAssignable(null, type, targetType);
					return ConvertUtils.ConvertResult.Success;
				}
				value = null;
				return ConvertUtils.ConvertResult.CannotConvertNull;
			}
			else
			{
				if (initialValue is INullable)
				{
					value = ConvertUtils.EnsureTypeAssignable(ConvertUtils.ToValue((INullable)initialValue), type, targetType);
					return ConvertUtils.ConvertResult.Success;
				}
				if (!TypeExtensions.IsInterface(targetType) && !TypeExtensions.IsGenericTypeDefinition(targetType) && !TypeExtensions.IsAbstract(targetType))
				{
					value = null;
					return ConvertUtils.ConvertResult.NoValidConversion;
				}
				value = null;
				return ConvertUtils.ConvertResult.NotInstantiableType;
			}
		}
	}
}
