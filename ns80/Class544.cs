using System;
using System.Collections.Generic;
using System.IO;

namespace ns80
{
	// Token: 0x02000450 RID: 1104
	internal abstract class Class544
	{
		// Token: 0x04001BD4 RID: 7124
		protected Dictionary<string, Class548> dictionary_0 = new Dictionary<string, Class548>();

		// Token: 0x060023B4 RID: 9140
		// RVA: 0x0001C29D File Offset: 0x0001A49D
		internal void method_0(string string_0)
		{
			this.dictionary_0.Add(string_0, new Class548(this));
		}

		// Token: 0x060023B5 RID: 9141
		internal abstract void vmethod_0();

		// Token: 0x060023B6 RID: 9142
		// RVA: 0x0001C2B1 File Offset: 0x0001A4B1
		internal virtual void vmethod_1(string string_0, string string_1)
		{
			if (string_1.StartsWith("["))
			{
				return;
			}
			this.dictionary_0[string_0].method_0(string_1);
		}

		// Token: 0x060023B7 RID: 9143
		// RVA: 0x000D7424 File Offset: 0x000D5624
		internal virtual void vmethod_2(StreamWriter streamWriter_0)
		{
			foreach (KeyValuePair<string, Class548> current in this.dictionary_0)
			{
				if (!current.Value.IsEmpty)
				{
					streamWriter_0.WriteLine('[' + current.Key + ']');
					foreach (string current2 in current.Value)
					{
						streamWriter_0.WriteLine(current2);
					}
				}
			}
		}
	}
}
