using System;
using System.Globalization;
using System.IO;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000AE RID: 174
	public sealed class JRaw : JValue
	{
		// Token: 0x060005D6 RID: 1494
		// RVA: 0x00009614 File Offset: 0x00007814
		public JRaw(JRaw other) : base(other)
		{
		}

		// Token: 0x060005D7 RID: 1495
		// RVA: 0x0000961D File Offset: 0x0000781D
		public JRaw(object rawJson) : base(rawJson, JTokenType.Raw)
		{
		}

		// Token: 0x060005D9 RID: 1497
		// RVA: 0x00009628 File Offset: 0x00007828
		internal override JToken CloneToken()
		{
			return new JRaw(this);
		}

		// Token: 0x060005D8 RID: 1496
		// RVA: 0x00035994 File Offset: 0x00033B94
		public static JRaw Create(JsonReader reader)
		{
			JRaw result;
			using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
			{
				using (JsonTextWriter jsonTextWriter = new JsonTextWriter(stringWriter))
				{
					jsonTextWriter.WriteToken(reader);
					result = new JRaw(stringWriter.ToString());
				}
			}
			return result;
		}
	}
}
