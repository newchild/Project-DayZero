using System;
using System.IO;

namespace ns14
{
	// Token: 0x020005C3 RID: 1475
	internal sealed class Stream17 : FileStream
	{
		// Token: 0x0400271E RID: 10014
		private bool bool_0;

		// Token: 0x0400271B RID: 10011
		private static object object_0 = new object();

		// Token: 0x0400271C RID: 10012
		private string string_0;

		// Token: 0x0400271D RID: 10013
		private string string_1;

		// Token: 0x06002EDA RID: 11994
		// RVA: 0x001309A4 File Offset: 0x0012EBA4
		public Stream17(string string_2) : base(string_2 + "." + DateTime.Now.Ticks, FileMode.Create)
		{
			this.string_1 = base.Name;
			this.string_0 = string_2;
		}

		// Token: 0x06002EDC RID: 11996
		// RVA: 0x00130A1C File Offset: 0x0012EC1C
		protected override void Dispose(bool disposing)
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			base.Dispose(disposing);
			lock (Stream17.object_0)
			{
				if (File.Exists(this.string_1))
				{
					try
					{
						File.Delete(this.string_0);
						File.Move(this.string_1, this.string_0);
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x06002EDB RID: 11995
		// RVA: 0x001309E8 File Offset: 0x0012EBE8
		~Stream17()
		{
			if (!this.bool_0)
			{
				base.Dispose();
			}
		}
	}
}
