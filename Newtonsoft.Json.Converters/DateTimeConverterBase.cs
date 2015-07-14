using System;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000032 RID: 50
	public abstract class DateTimeConverterBase : JsonConverter
	{
		// Token: 0x0600019B RID: 411
		// RVA: 0x00006DD9 File Offset: 0x00004FD9
		public override bool CanConvert(Type objectType)
		{
			if (objectType != typeof(DateTime))
			{
				if (objectType != typeof(DateTime?))
				{
					return false;
				}
			}
			return true;
		}
	}
}
