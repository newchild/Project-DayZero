using System;
using System.Collections.Generic;

namespace ns43
{
	// Token: 0x020002C6 RID: 710
	internal sealed class Class240
	{
		// Token: 0x04001167 RID: 4455
		public static readonly ArraySegment<byte> arraySegment_0 = new ArraySegment<byte>(new byte[0]);

		// Token: 0x04001164 RID: 4452
		internal static readonly int int_0 = 256;

		// Token: 0x04001165 RID: 4453
		internal static readonly int int_1 = 2048;

		// Token: 0x04001166 RID: 4454
		internal static readonly int int_2 = Class258.int_0 + 32;

		// Token: 0x04001168 RID: 4456
		private Queue<ArraySegment<byte>> queue_0;

		// Token: 0x04001169 RID: 4457
		private Queue<ArraySegment<byte>> queue_1;

		// Token: 0x0400116A RID: 4458
		private Queue<ArraySegment<byte>> queue_2;

		// Token: 0x0400116B RID: 4459
		private Queue<ArraySegment<byte>> queue_3;

		// Token: 0x060016AB RID: 5803
		// RVA: 0x00072454 File Offset: 0x00070654
		public Class240()
		{
			this.queue_3 = new Queue<ArraySegment<byte>>();
			this.queue_0 = new Queue<ArraySegment<byte>>();
			this.queue_1 = new Queue<ArraySegment<byte>>();
			this.queue_2 = new Queue<ArraySegment<byte>>();
			this.method_0(4, Enum34.const_2);
			this.method_0(4, Enum34.const_1);
			this.method_0(4, Enum34.const_0);
		}

		// Token: 0x060016AC RID: 5804
		// RVA: 0x000724AC File Offset: 0x000706AC
		private void method_0(int int_3, Enum34 enum34_0)
		{
			if (enum34_0 == Enum34.const_2)
			{
				while (int_3-- > 0)
				{
					this.queue_0.Enqueue(new ArraySegment<byte>(new byte[Class240.int_2], 0, Class240.int_2));
				}
				return;
			}
			if (enum34_0 == Enum34.const_1)
			{
				while (int_3-- > 0)
				{
					this.queue_1.Enqueue(new ArraySegment<byte>(new byte[Class240.int_1], 0, Class240.int_1));
				}
				return;
			}
			if (enum34_0 == Enum34.const_0)
			{
				while (int_3-- > 0)
				{
					this.queue_2.Enqueue(new ArraySegment<byte>(new byte[Class240.int_0], 0, Class240.int_0));
				}
				return;
			}
			throw new ArgumentException("Unsupported BufferType detected");
		}
	}
}
