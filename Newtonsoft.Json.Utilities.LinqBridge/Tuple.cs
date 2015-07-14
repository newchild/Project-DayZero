using System;
using System.Collections.Generic;
using System.Globalization;

namespace Newtonsoft.Json.Utilities.LinqBridge
{
	// Token: 0x02000099 RID: 153
	[Serializable]
	internal struct Tuple<TFirst, TSecond> : IEquatable<Tuple<TFirst, TSecond>>
	{
		// Token: 0x170000A9 RID: 169
		public TFirst First
		{
			// Token: 0x060004AE RID: 1198
			// RVA: 0x00008E63 File Offset: 0x00007063
			get;
			// Token: 0x060004AF RID: 1199
			// RVA: 0x00008E6B File Offset: 0x0000706B
			private set;
		}

		// Token: 0x170000AA RID: 170
		public TSecond Second
		{
			// Token: 0x060004B0 RID: 1200
			// RVA: 0x00008E74 File Offset: 0x00007074
			get;
			// Token: 0x060004B1 RID: 1201
			// RVA: 0x00008E7C File Offset: 0x0000707C
			private set;
		}

		// Token: 0x060004B2 RID: 1202
		// RVA: 0x00008E85 File Offset: 0x00007085
		public Tuple(TFirst first, TSecond second)
		{
			this = default(Tuple<TFirst, TSecond>);
			this.First = first;
			this.Second = second;
		}

		// Token: 0x060004B3 RID: 1203
		// RVA: 0x00008E9C File Offset: 0x0000709C
		public override bool Equals(object obj)
		{
			return obj != null && obj is Tuple<TFirst, TSecond> && base.Equals((Tuple<TFirst, TSecond>)obj);
		}

		// Token: 0x060004B4 RID: 1204
		// RVA: 0x00008EC6 File Offset: 0x000070C6
		public bool Equals(Tuple<TFirst, TSecond> other)
		{
			return EqualityComparer<TFirst>.Default.Equals(other.First, this.First) && EqualityComparer<TSecond>.Default.Equals(other.Second, this.Second);
		}

		// Token: 0x060004B5 RID: 1205
		// RVA: 0x0003309C File Offset: 0x0003129C
		public override int GetHashCode()
		{
			int num = 1999615890 + EqualityComparer<TFirst>.Default.GetHashCode(this.First);
			return -1521134295 * num + EqualityComparer<TSecond>.Default.GetHashCode(this.Second);
		}

		// Token: 0x060004B6 RID: 1206
		// RVA: 0x000330E0 File Offset: 0x000312E0
		public override string ToString()
		{
			return string.Format(CultureInfo.InvariantCulture, "{{ First = {0}, Second = {1} }}", new object[]
			{
				this.First,
				this.Second
			});
		}
	}
}
