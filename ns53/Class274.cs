using System;
using System.Collections.Generic;
using System.Threading;

namespace ns53
{
	// Token: 0x020002F0 RID: 752
	internal sealed class Class274 : IDisposable
	{
		// Token: 0x020002F1 RID: 753
		private struct Struct46 : IComparable<Class274.Struct46>
		{
			// Token: 0x040011E0 RID: 4576
			public DateTime dateTime_0;

			// Token: 0x040011E1 RID: 4577
			public Delegate30 delegate30_0;

			// Token: 0x040011E2 RID: 4578
			public object object_0;

			// Token: 0x040011DF RID: 4575
			public TimeSpan timeSpan_0;

			// Token: 0x040011DE RID: 4574
			public uint uint_0;

			// Token: 0x0600172C RID: 5932
			// RVA: 0x00014590 File Offset: 0x00012790
			public int CompareTo(Class274.Struct46 obj)
			{
				return this.dateTime_0.CompareTo(obj.dateTime_0);
			}

			// Token: 0x0600172D RID: 5933
			// RVA: 0x000145A4 File Offset: 0x000127A4
			public override string ToString()
			{
				return string.Format("{0} ({1})", this.uint_0, this.dateTime_0);
			}
		}

		// Token: 0x040011DC RID: 4572
		private AutoResetEvent autoResetEvent_0 = new AutoResetEvent(false);

		// Token: 0x040011DB RID: 4571
		private bool bool_0;

		// Token: 0x040011DD RID: 4573
		private List<Class274.Struct46> list_0 = new List<Class274.Struct46>();

		// Token: 0x040011DA RID: 4570
		private static uint uint_0 = 1u;

		// Token: 0x06001728 RID: 5928
		// RVA: 0x00072E4C File Offset: 0x0007104C
		public void Clear()
		{
			lock (this.list_0)
			{
				this.list_0.Clear();
				this.autoResetEvent_0.Set();
			}
		}

		// Token: 0x06001729 RID: 5929
		// RVA: 0x00014546 File Offset: 0x00012746
		public void Dispose()
		{
			if (this.bool_0)
			{
				return;
			}
			this.Clear();
			this.autoResetEvent_0.Close();
			this.bool_0 = true;
		}
	}
}
