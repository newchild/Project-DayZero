using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities.LinqBridge;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000153 RID: 339
	internal static class EnumUtils
	{
		// Token: 0x040005A9 RID: 1449
		private static readonly ThreadSafeStore<Type, BidirectionalDictionary<string, string>> EnumMemberNamesPerType = new ThreadSafeStore<Type, BidirectionalDictionary<string, string>>(new Func<Type, BidirectionalDictionary<string, string>>(EnumUtils.InitializeEnumType));

		// Token: 0x06000D53 RID: 3411
		// RVA: 0x0004ADA0 File Offset: 0x00048FA0
		public static IList<T> GetFlagsValues<T>(T value) where T : struct
		{
			Type typeFromHandle = typeof(T);
			if (!typeFromHandle.IsDefined(typeof(FlagsAttribute), false))
			{
				throw new ArgumentException(StringUtils.FormatWith("Enum type {0} is not a set of flags.", CultureInfo.InvariantCulture, typeFromHandle));
			}
			Type underlyingType = Enum.GetUnderlyingType(value.GetType());
			ulong num = Convert.ToUInt64(value, CultureInfo.InvariantCulture);
			IList<EnumValue<ulong>> namesAndValues = EnumUtils.GetNamesAndValues<T>();
			IList<T> list = new List<T>();
			foreach (EnumValue<ulong> current in namesAndValues)
			{
				if ((num & current.Value) == current.Value && current.Value != 0uL)
				{
					list.Add((T)((object)Convert.ChangeType(current.Value, underlyingType, CultureInfo.CurrentCulture)));
				}
			}
			if (list.Count == 0 && Enumerable.SingleOrDefault<EnumValue<ulong>>(namesAndValues, (EnumValue<ulong> v) => v.Value == 0uL) != null)
			{
				list.Add(default(T));
			}
			return list;
		}

		// Token: 0x06000D57 RID: 3415
		// RVA: 0x0004B05C File Offset: 0x0004925C
		public static IList<string> GetNames(Type enumType)
		{
			if (!TypeExtensions.IsEnum(enumType))
			{
				throw new ArgumentException("Type '" + enumType.Name + "' is not an enum.");
			}
			List<string> list = new List<string>();
			IEnumerable<FieldInfo> enumerable = Enumerable.Where<FieldInfo>(enumType.GetFields(), (FieldInfo f) => f.IsLiteral);
			foreach (FieldInfo current in enumerable)
			{
				list.Add(current.Name);
			}
			return list;
		}

		// Token: 0x06000D54 RID: 3412
		// RVA: 0x0000E3AE File Offset: 0x0000C5AE
		public static IList<EnumValue<ulong>> GetNamesAndValues<T>() where T : struct
		{
			return EnumUtils.GetNamesAndValues<ulong>(typeof(T));
		}

		// Token: 0x06000D55 RID: 3413
		// RVA: 0x0004AEC4 File Offset: 0x000490C4
		public static IList<EnumValue<TUnderlyingType>> GetNamesAndValues<TUnderlyingType>(Type enumType) where TUnderlyingType : struct
		{
			if (enumType == null)
			{
				throw new ArgumentNullException("enumType");
			}
			ValidationUtils.ArgumentTypeIsEnum(enumType, "enumType");
			IList<object> values = EnumUtils.GetValues(enumType);
			IList<string> names = EnumUtils.GetNames(enumType);
			IList<EnumValue<TUnderlyingType>> list = new List<EnumValue<TUnderlyingType>>();
			for (int i = 0; i < values.Count; i++)
			{
				try
				{
					list.Add(new EnumValue<TUnderlyingType>(names[i], (TUnderlyingType)((object)Convert.ChangeType(values[i], typeof(TUnderlyingType), CultureInfo.CurrentCulture))));
				}
				catch (OverflowException innerException)
				{
					throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Value from enum with the underlying type of {0} cannot be added to dictionary with a value type of {1}. Value was too large: {2}", new object[]
					{
						Enum.GetUnderlyingType(enumType),
						typeof(TUnderlyingType),
						Convert.ToUInt64(values[i], CultureInfo.InvariantCulture)
					}), innerException);
				}
			}
			return list;
		}

		// Token: 0x06000D56 RID: 3414
		// RVA: 0x0004AFB0 File Offset: 0x000491B0
		public static IList<object> GetValues(Type enumType)
		{
			if (!TypeExtensions.IsEnum(enumType))
			{
				throw new ArgumentException("Type '" + enumType.Name + "' is not an enum.");
			}
			List<object> list = new List<object>();
			IEnumerable<FieldInfo> enumerable = Enumerable.Where<FieldInfo>(enumType.GetFields(), (FieldInfo f) => f.IsLiteral);
			foreach (FieldInfo current in enumerable)
			{
				object value = current.GetValue(enumType);
				list.Add(value);
			}
			return list;
		}

		// Token: 0x06000D52 RID: 3410
		// RVA: 0x0004AD20 File Offset: 0x00048F20
		private static BidirectionalDictionary<string, string> InitializeEnumType(Type type)
		{
			BidirectionalDictionary<string, string> bidirectionalDictionary = new BidirectionalDictionary<string, string>(StringComparer.OrdinalIgnoreCase, StringComparer.OrdinalIgnoreCase);
			FieldInfo[] fields = type.GetFields();
			for (int i = 0; i < fields.Length; i++)
			{
				FieldInfo fieldInfo = fields[i];
				string name = fieldInfo.Name;
				string name2 = fieldInfo.Name;
				string text;
				if (bidirectionalDictionary.TryGetBySecond(name2, out text))
				{
					throw new InvalidOperationException(StringUtils.FormatWith("Enum name '{0}' already exists on enum '{1}'.", CultureInfo.InvariantCulture, name2, type.Name));
				}
				bidirectionalDictionary.Set(name, name2);
			}
			return bidirectionalDictionary;
		}

		// Token: 0x06000D58 RID: 3416
		// RVA: 0x0004B100 File Offset: 0x00049300
		public static object ParseEnumName(string enumText, bool isNullable, Type t)
		{
			if (enumText == string.Empty && isNullable)
			{
				return null;
			}
			BidirectionalDictionary<string, string> map = EnumUtils.EnumMemberNamesPerType.Get(t);
			string value;
			if (enumText.IndexOf(',') != -1)
			{
				string[] array = enumText.Split(new char[]
				{
					','
				});
				for (int i = 0; i < array.Length; i++)
				{
					string enumText2 = array[i].Trim();
					array[i] = EnumUtils.ResolvedEnumName(map, enumText2);
				}
				value = string.Join(", ", array);
			}
			else
			{
				value = EnumUtils.ResolvedEnumName(map, enumText);
			}
			return Enum.Parse(t, value, true);
		}

		// Token: 0x06000D5A RID: 3418
		// RVA: 0x0004B20C File Offset: 0x0004940C
		private static string ResolvedEnumName(BidirectionalDictionary<string, string> map, string enumText)
		{
			string text;
			map.TryGetBySecond(enumText, out text);
			text = (text ?? enumText);
			return text;
		}

		// Token: 0x06000D59 RID: 3417
		// RVA: 0x0004B190 File Offset: 0x00049390
		public static string ToEnumName(Type enumType, string enumText, bool camelCaseText)
		{
			BidirectionalDictionary<string, string> bidirectionalDictionary = EnumUtils.EnumMemberNamesPerType.Get(enumType);
			string[] array = enumText.Split(new char[]
			{
				','
			});
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i].Trim();
				string text2;
				bidirectionalDictionary.TryGetByFirst(text, out text2);
				text2 = (text2 ?? text);
				if (camelCaseText)
				{
					text2 = StringUtils.ToCamelCase(text2);
				}
				array[i] = text2;
			}
			return string.Join(", ", array);
		}
	}
}
