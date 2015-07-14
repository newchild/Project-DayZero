using System;
using System.Collections;

namespace ns14
{
	// Token: 0x02000465 RID: 1125
	internal static class Class558
	{
		// Token: 0x0600247E RID: 9342
		// RVA: 0x000DD024 File Offset: 0x000DB224
		internal static bool smethod_0<TEnum>(string string_0, ref TEnum gparam_0)
		{
			if (string_0 == null)
			{
				throw new ArgumentNullException();
			}
			if (string_0.Length > 0)
			{
				IEnumerator enumerator = Enum.GetValues(typeof(TEnum)).GetEnumerator();
				bool result;
				try
				{
					while (enumerator.MoveNext())
					{
						object current = enumerator.Current;
						if (string_0.StartsWith(current.ToString()))
						{
							gparam_0 = (TEnum)((object)current);
							result = true;
							return result;
						}
					}
					goto IL_6C;
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
				return result;
			}
			IL_6C:
			gparam_0 = default(TEnum);
			return false;
		}
	}
}
