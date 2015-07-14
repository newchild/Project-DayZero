using ns45;
using ns47;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ns54
{
	// Token: 0x020002F8 RID: 760
	internal sealed class Class281 : IDisposable, IEnumerable, IEnumerable<Class280>
	{
		// Token: 0x040011F8 RID: 4600
		private bool bool_0;

		// Token: 0x040011EF RID: 4591
		internal static readonly Class234 class234_0 = "peers";

		// Token: 0x040011F0 RID: 4592
		internal static readonly Class234 class234_1 = "interval";

		// Token: 0x040011F1 RID: 4593
		internal static readonly Class234 class234_2 = "min interval";

		// Token: 0x040011F2 RID: 4594
		internal static readonly Class234 class234_3 = "tracker id";

		// Token: 0x040011F3 RID: 4595
		internal static readonly Class234 class234_4 = "complete";

		// Token: 0x040011F4 RID: 4596
		internal static readonly Class234 class234_5 = "incomplete";

		// Token: 0x040011F5 RID: 4597
		internal static readonly Class234 class234_6 = "peer id";

		// Token: 0x040011F6 RID: 4598
		internal static readonly Class234 class234_7 = "port";

		// Token: 0x040011F7 RID: 4599
		internal static readonly Class234 class234_8 = "ip";

		// Token: 0x040011F9 RID: 4601
		private Dictionary<Class272, Class280> dictionary_0;

		// Token: 0x06001746 RID: 5958
		// RVA: 0x00014715 File Offset: 0x00012915
		public void Dispose()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x06001744 RID: 5956
		// RVA: 0x00072FA0 File Offset: 0x000711A0
		public IEnumerator<Class280> GetEnumerator()
		{
			this.method_0();
			IEnumerator<Class280> result;
			lock (this.dictionary_0)
			{
				result = new List<Class280>(this.dictionary_0.Values).GetEnumerator();
			}
			return result;
		}

		// Token: 0x06001743 RID: 5955
		// RVA: 0x000146F2 File Offset: 0x000128F2
		private void method_0()
		{
			if (this.bool_0)
			{
				throw new ObjectDisposedException(base.GetType().Name);
			}
		}

		// Token: 0x06001745 RID: 5957
		// RVA: 0x0001470D File Offset: 0x0001290D
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}
}
