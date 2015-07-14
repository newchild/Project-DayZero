using ns24;
using ns29;
using ns80;
using ns9;
using System;

namespace ns26
{
	// Token: 0x02000345 RID: 837
	internal sealed class Class88 : Class54
	{
		// Token: 0x04001354 RID: 4948
		private bool bool_1 = true;

		// Token: 0x04001355 RID: 4949
		private Class339 class339_0 = new Class339(Class331.smethod_37("nightcore-kick", false, true, Enum112.flag_5));

		// Token: 0x04001356 RID: 4950
		private Class339 class339_1 = new Class339(Class331.smethod_37("nightcore-finish", false, true, Enum112.flag_5));

		// Token: 0x04001357 RID: 4951
		private Class339 class339_2 = new Class339(Class331.smethod_37("nightcore-clap", false, true, Enum112.flag_5));

		// Token: 0x04001358 RID: 4952
		private Class339 class339_3 = new Class339(Class331.smethod_37("nightcore-hat", false, true, Enum112.flag_5));

		// Token: 0x04001353 RID: 4947
		private int int_1 = -1;

		// Token: 0x0600194A RID: 6474
		// RVA: 0x00078DCC File Offset: 0x00076FCC
		public Class88() : base(Class115.class115_0)
		{
		}

		// Token: 0x0600194C RID: 6476
		// RVA: 0x00078E54 File Offset: 0x00077054
		public override void imethod_2()
		{
			if (!Class331.smethod_17() || !Class331.bool_5 || (double)Class331.int_7 < Class331.smethod_12())
			{
				return;
			}
			int num = (int)(Class331.smethod_0() * 2.0 / Class331.smethod_8());
			if (num == this.int_1)
			{
				return;
			}
			this.int_1 = num;
			int num2 = num % (int)Class331.smethod_18();
			if (num % (int)((Enum37)8 * Class331.smethod_18()) == 0)
			{
				this.class339_0.method_10(true, true);
				bool flag = false;
				try
				{
					flag = (num > 0 || (Class331.smethod_14()[Class331.int_1].enum39_0 & Enum39.flag_2) == Enum39.flag_0);
				}
				catch
				{
				}
				if (flag)
				{
					this.class339_1.method_10(true, true);
				}
				return;
			}
			if (num2 % 4 == 0)
			{
				this.class339_0.method_10(true, true);
				return;
			}
			if (num2 % 4 == 2)
			{
				this.class339_2.method_10(true, true);
				return;
			}
			if (this.bool_1)
			{
				this.class339_3.method_10(true, true);
			}
		}

		// Token: 0x0600194B RID: 6475
		// RVA: 0x00015707 File Offset: 0x00013907
		public void Reset()
		{
			this.int_1 = -1;
			this.bool_1 = (Class466.Current.DifficultySliderTickRate % 2.0 == 0.0);
		}
	}
}
