using System;
using System.Text;

namespace ns14
{
	// Token: 0x020005A1 RID: 1441
	internal sealed class Class764
	{
		// Token: 0x0400269E RID: 9886
		public byte[] byte_0;

		// Token: 0x0400269A RID: 9882
		internal string string_0 = string.Empty;

		// Token: 0x0400269B RID: 9883
		internal string string_1 = string.Empty;

		// Token: 0x0400269C RID: 9884
		internal string string_2 = string.Empty;

		// Token: 0x0400269D RID: 9885
		public string string_3 = string.Empty;

		// Token: 0x06002E3D RID: 11837
		// RVA: 0x00022EC3 File Offset: 0x000210C3
		internal Class764()
		{
		}

		// Token: 0x06002E3E RID: 11838
		// RVA: 0x0012BA74 File Offset: 0x00129C74
		internal Class764(Exception exception_0)
		{
			this.string_3 = exception_0.GetType().ToString();
			StringBuilder stringBuilder = new StringBuilder();
			string[] array = exception_0.ToString().Split(new char[]
			{
				'\n'
			});
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				if (text.Contains("Microsoft.Xna.Framework.Game.Tick"))
				{
					break;
				}
				stringBuilder.AppendLine(text.Trim(new char[]
				{
					'\r'
				}));
			}
			this.string_2 = stringBuilder.ToString();
		}
	}
}
