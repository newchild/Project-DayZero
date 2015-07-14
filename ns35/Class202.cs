using ns37;
using System;

namespace ns35
{
	// Token: 0x0200025D RID: 605
	internal sealed class Class202
	{
		// Token: 0x04000F9D RID: 3997
		public Delegate19 delegate19_0;

		// Token: 0x04000F9E RID: 3998
		public Delegate20 delegate20_0;

		// Token: 0x04000F9F RID: 3999
		public Delegate21 delegate21_0;

		// Token: 0x04000FA0 RID: 4000
		public Delegate22 delegate22_0;

		// Token: 0x04000FA1 RID: 4001
		public Delegate23 delegate23_0;

		// Token: 0x04000FA2 RID: 4002
		public Delegate24 delegate24_0;

		// Token: 0x04000FA3 RID: 4003
		private TimeSpan timeSpan_0;

		// Token: 0x0600150D RID: 5389
		// RVA: 0x0006C6E4 File Offset: 0x0006A8E4
		public bool method_0(string string_0, Exception exception_0)
		{
			bool result = false;
			if (this.delegate23_0 != null)
			{
				Class184 class = new Class184(string_0, exception_0);
				this.delegate23_0(this, class);
				result = class.method_0();
			}
			return result;
		}

		// Token: 0x0600150E RID: 5390
		// RVA: 0x0006C718 File Offset: 0x0006A918
		public bool method_1(string string_0, Exception exception_0)
		{
			bool result = false;
			if (this.delegate24_0 != null)
			{
				Class184 class = new Class184(string_0, exception_0);
				this.delegate24_0(this, class);
				result = class.method_0();
			}
			return result;
		}

		// Token: 0x0600150F RID: 5391
		// RVA: 0x0006C74C File Offset: 0x0006A94C
		public bool method_2(string string_0)
		{
			bool result = true;
			if (this.delegate20_0 != null)
			{
				EventArgs7 eventArgs = new EventArgs7(string_0);
				this.delegate20_0(this, eventArgs);
				result = eventArgs.method_0();
			}
			return result;
		}

		// Token: 0x06001510 RID: 5392
		// RVA: 0x0006C780 File Offset: 0x0006A980
		public bool method_3(string string_0)
		{
			bool result = true;
			if (this.delegate22_0 != null)
			{
				EventArgs7 eventArgs = new EventArgs7(string_0);
				this.delegate22_0(this, eventArgs);
				result = eventArgs.method_0();
			}
			return result;
		}

		// Token: 0x06001511 RID: 5393
		// RVA: 0x0006C7B4 File Offset: 0x0006A9B4
		public bool method_4(string string_0, bool bool_0)
		{
			bool result = true;
			if (this.delegate19_0 != null)
			{
				EventArgs8 eventArgs = new EventArgs8(string_0, bool_0);
				this.delegate19_0(this, eventArgs);
				result = eventArgs.method_0();
			}
			return result;
		}

		// Token: 0x06001512 RID: 5394
		// RVA: 0x00012D1C File Offset: 0x00010F1C
		public TimeSpan method_5()
		{
			return this.timeSpan_0;
		}
	}
}
