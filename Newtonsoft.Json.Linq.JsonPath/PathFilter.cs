using Newtonsoft.Json.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x02000046 RID: 70
	internal abstract class PathFilter
	{
		// Token: 0x060001F6 RID: 502
		public abstract IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch);

		// Token: 0x060001F7 RID: 503
		// RVA: 0x0002C750 File Offset: 0x0002A950
		protected static JToken GetTokenIndex(JToken t, bool errorWhenNoMatch, int index)
		{
			JArray jArray = t as JArray;
			JConstructor jConstructor = t as JConstructor;
			if (jArray != null)
			{
				if (jArray.Count > index)
				{
					return jArray[index];
				}
				if (errorWhenNoMatch)
				{
					throw new JsonException(StringUtils.FormatWith("Index {0} outside the bounds of JArray.", CultureInfo.InvariantCulture, index));
				}
				return null;
			}
			else if (jConstructor != null)
			{
				if (jConstructor.Count > index)
				{
					return jConstructor[index];
				}
				if (errorWhenNoMatch)
				{
					throw new JsonException(StringUtils.FormatWith("Index {0} outside the bounds of JConstructor.", CultureInfo.InvariantCulture, index));
				}
				return null;
			}
			else
			{
				if (errorWhenNoMatch)
				{
					throw new JsonException(StringUtils.FormatWith("Index {0} not valid on {1}.", CultureInfo.InvariantCulture, index, t.GetType().Name));
				}
				return null;
			}
		}
	}
}
