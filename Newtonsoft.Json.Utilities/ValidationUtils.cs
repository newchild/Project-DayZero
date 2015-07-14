using System;
using System.Globalization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000162 RID: 354
	internal static class ValidationUtils
	{
		// Token: 0x06000DF0 RID: 3568
		// RVA: 0x0000E982 File Offset: 0x0000CB82
		public static void ArgumentNotNull(object value, string parameterName)
		{
			if (value == null)
			{
				throw new ArgumentNullException(parameterName);
			}
		}

		// Token: 0x06000DEE RID: 3566
		// RVA: 0x0000E92B File Offset: 0x0000CB2B
		public static void ArgumentNotNullOrEmpty(string value, string parameterName)
		{
			if (value == null)
			{
				throw new ArgumentNullException(parameterName);
			}
			if (value.Length == 0)
			{
				throw new ArgumentException(StringUtils.FormatWith("'{0}' cannot be empty.", CultureInfo.InvariantCulture, parameterName), parameterName);
			}
		}

		// Token: 0x06000DEF RID: 3567
		// RVA: 0x0000E956 File Offset: 0x0000CB56
		public static void ArgumentTypeIsEnum(Type enumType, string parameterName)
		{
			ValidationUtils.ArgumentNotNull(enumType, "enumType");
			if (!TypeExtensions.IsEnum(enumType))
			{
				throw new ArgumentException(StringUtils.FormatWith("Type {0} is not an Enum.", CultureInfo.InvariantCulture, enumType), parameterName);
			}
		}
	}
}
