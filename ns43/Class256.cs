using System;

namespace ns43
{
	// Token: 0x020002D6 RID: 726
	internal sealed class Class256
	{
		// Token: 0x04001193 RID: 4499
		private string string_0;

		// Token: 0x04001192 RID: 4498
		private Uri uri_0;

		// Token: 0x060016D7 RID: 5847
		// RVA: 0x00014238 File Offset: 0x00012438
		public override bool Equals(object obj)
		{
			return this.Equals(obj as Class256);
		}

		// Token: 0x060016D8 RID: 5848
		// RVA: 0x000728A8 File Offset: 0x00070AA8
		public bool Equals(Class256 class256_0)
		{
			if (class256_0 == null)
			{
				return false;
			}
			if (string.IsNullOrEmpty(this.string_0) && string.IsNullOrEmpty(class256_0.string_0))
			{
				return this.uri_0.Host.Equals(class256_0.uri_0.Host);
			}
			return this.string_0 == class256_0.string_0;
		}

		// Token: 0x060016D9 RID: 5849
		// RVA: 0x00014246 File Offset: 0x00012446
		public override int GetHashCode()
		{
			return this.uri_0.Host.GetHashCode();
		}

		// Token: 0x060016D6 RID: 5846
		// RVA: 0x00014230 File Offset: 0x00012430
		public Uri method_0()
		{
			return this.uri_0;
		}

		// Token: 0x060016DA RID: 5850
		// RVA: 0x00014258 File Offset: 0x00012458
		public override string ToString()
		{
			return this.uri_0.ToString();
		}
	}
}
