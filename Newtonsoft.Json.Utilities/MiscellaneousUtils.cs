using System;
using System.Globalization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200015B RID: 347
	internal static class MiscellaneousUtils
	{
		// Token: 0x06000D90 RID: 3472
		// RVA: 0x0004BD3C File Offset: 0x00049F3C
		public static int ByteArrayCompare(byte[] a1, byte[] a2)
		{
			int num = a1.Length.CompareTo(a2.Length);
			if (num != 0)
			{
				return num;
			}
			for (int i = 0; i < a1.Length; i++)
			{
				int num2 = a1[i].CompareTo(a2[i]);
				if (num2 != 0)
				{
					return num2;
				}
			}
			return 0;
		}

		// Token: 0x06000D8E RID: 3470
		// RVA: 0x0004BD0C File Offset: 0x00049F0C
		public static ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message)
		{
			string message2 = message + Environment.NewLine + StringUtils.FormatWith("Actual value was {0}.", CultureInfo.InvariantCulture, actualValue);
			return new ArgumentOutOfRangeException(paramName, message2);
		}

		// Token: 0x06000D94 RID: 3476
		// RVA: 0x0000E652 File Offset: 0x0000C852
		internal static string FormatValueForPrint(object value)
		{
			if (value == null)
			{
				return "{null}";
			}
			if (value is string)
			{
				return "\"" + value + "\"";
			}
			return value.ToString();
		}

		// Token: 0x06000D92 RID: 3474
		// RVA: 0x0004BD9C File Offset: 0x00049F9C
		public static string GetLocalName(string qualifiedName)
		{
			string text;
			string result;
			MiscellaneousUtils.GetQualifiedNameParts(qualifiedName, out text, out result);
			return result;
		}

		// Token: 0x06000D91 RID: 3473
		// RVA: 0x0004BD84 File Offset: 0x00049F84
		public static string GetPrefix(string qualifiedName)
		{
			string result;
			string text;
			MiscellaneousUtils.GetQualifiedNameParts(qualifiedName, out result, out text);
			return result;
		}

		// Token: 0x06000D93 RID: 3475
		// RVA: 0x0004BDB4 File Offset: 0x00049FB4
		public static void GetQualifiedNameParts(string qualifiedName, out string prefix, out string localName)
		{
			int num = qualifiedName.IndexOf(':');
			if (num != -1 && num != 0)
			{
				if (qualifiedName.Length - 1 != num)
				{
					prefix = qualifiedName.Substring(0, num);
					localName = qualifiedName.Substring(num + 1);
					return;
				}
			}
			prefix = null;
			localName = qualifiedName;
		}

		// Token: 0x06000D8F RID: 3471
		// RVA: 0x0000E623 File Offset: 0x0000C823
		public static string ToString(object value)
		{
			if (value == null)
			{
				return "{null}";
			}
			if (!(value is string))
			{
				return value.ToString();
			}
			return "\"" + value.ToString() + "\"";
		}

		// Token: 0x06000D8D RID: 3469
		// RVA: 0x0004BC54 File Offset: 0x00049E54
		public static bool ValueEquals(object objA, object objB)
		{
			if (objA == null && objB == null)
			{
				return true;
			}
			if (objA != null && objB == null)
			{
				return false;
			}
			if (objA == null && objB != null)
			{
				return false;
			}
			if (objA.GetType() == objB.GetType())
			{
				return objA.Equals(objB);
			}
			if (ConvertUtils.IsInteger(objA) && ConvertUtils.IsInteger(objB))
			{
				return Convert.ToDecimal(objA, CultureInfo.CurrentCulture).Equals(Convert.ToDecimal(objB, CultureInfo.CurrentCulture));
			}
			return (objA is double || objA is float || objA is decimal) && (objB is double || objB is float || objB is decimal) && MathUtils.ApproxEquals(Convert.ToDouble(objA, CultureInfo.CurrentCulture), Convert.ToDouble(objB, CultureInfo.CurrentCulture));
		}
	}
}
