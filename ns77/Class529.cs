using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ns77
{
	// Token: 0x0200044D RID: 1101
	internal sealed class Class529 : TraceListener
	{
		// Token: 0x04001BA9 RID: 7081
		private List<string> list_0;

		// Token: 0x0600237F RID: 9087
		// RVA: 0x000D65D8 File Offset: 0x000D47D8
		internal IEnumerable<string> method_0()
		{
			IEnumerable<string> result;
			lock (this.list_0)
			{
				List<string> list = new List<string>(this.list_0);
				this.list_0.Clear();
				result = list;
			}
			return result;
		}

		// Token: 0x0600237D RID: 9085
		// RVA: 0x000D6598 File Offset: 0x000D4798
		public override void Write(string message)
		{
			lock (this.list_0)
			{
				this.list_0.Add(message);
			}
		}

		// Token: 0x0600237E RID: 9086
		// RVA: 0x000D6598 File Offset: 0x000D4798
		public override void WriteLine(string message)
		{
			lock (this.list_0)
			{
				this.list_0.Add(message);
			}
		}
	}
}
