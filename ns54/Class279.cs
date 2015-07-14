using System;

namespace ns54
{
	// Token: 0x020002F6 RID: 758
	internal sealed class Class279 : IEquatable<Class279>
	{
		// Token: 0x040011EE RID: 4590
		private object object_0;

		// Token: 0x06001740 RID: 5952
		// RVA: 0x000146BF File Offset: 0x000128BF
		public override bool Equals(object obj)
		{
			return this.Equals(obj as Class279);
		}

		// Token: 0x06001741 RID: 5953
		// RVA: 0x000146CD File Offset: 0x000128CD
		public bool Equals(Class279 other)
		{
			return other != null && this.object_0.Equals(other.object_0);
		}

		// Token: 0x06001742 RID: 5954
		// RVA: 0x000146E5 File Offset: 0x000128E5
		public override int GetHashCode()
		{
			return this.object_0.GetHashCode();
		}
	}
}
