using System;

namespace ns80
{
	// Token: 0x02000457 RID: 1111
	internal sealed class Class553
	{
		// Token: 0x04001BE4 RID: 7140
		internal string string_0;

		// Token: 0x04001BE5 RID: 7141
		internal string string_1;

		// Token: 0x060023E1 RID: 9185
		// RVA: 0x000D7F10 File Offset: 0x000D6110
		internal Class553(string string_2)
		{
			this.string_0 = string_2;
			if (string_2.Contains(":"))
			{
				string[] array = string_2.Trim().Split(new char[]
				{
					':'
				});
				if (array.Length > 1)
				{
					this.string_0 = array[0].Trim();
					this.string_1 = array[1].Trim();
				}
			}
		}

		// Token: 0x060023E2 RID: 9186
		// RVA: 0x0001C3E0 File Offset: 0x0001A5E0
		internal Class553(string string_2, string string_3)
		{
			this.string_0 = string_2;
			this.string_1 = string_3;
		}

		// Token: 0x060023E3 RID: 9187
		// RVA: 0x0001C3F6 File Offset: 0x0001A5F6
		public override string ToString()
		{
			if (string.IsNullOrEmpty(this.string_1))
			{
				return this.string_0;
			}
			return string.Format("{0}: {1}", this.string_0, this.string_1);
		}
	}
}
