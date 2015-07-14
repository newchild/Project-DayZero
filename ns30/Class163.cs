using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Threading;

namespace ns30
{
	// Token: 0x0200020D RID: 525
	[TypeConverter(typeof(ExpandableObjectConverter))]
	internal class Class163
	{
		// Token: 0x04000E45 RID: 3653
		private Class173 class173_0 = new Class173();

		// Token: 0x04000E4A RID: 3658
		private EventHandler eventHandler_0;

		// Token: 0x04000E49 RID: 3657
		private int int_0;

		// Token: 0x04000E39 RID: 3641
		private string string_0;

		// Token: 0x04000E3A RID: 3642
		private string string_1;

		// Token: 0x04000E43 RID: 3651
		private string string_10;

		// Token: 0x04000E44 RID: 3652
		private string[] string_11;

		// Token: 0x04000E46 RID: 3654
		private string string_12;

		// Token: 0x04000E47 RID: 3655
		private string string_13;

		// Token: 0x04000E48 RID: 3656
		private string string_14;

		// Token: 0x04000E3B RID: 3643
		private string string_2;

		// Token: 0x04000E3C RID: 3644
		private string string_3;

		// Token: 0x04000E3D RID: 3645
		private string string_4;

		// Token: 0x04000E3E RID: 3646
		private string string_5;

		// Token: 0x04000E3F RID: 3647
		private string string_6;

		// Token: 0x04000E40 RID: 3648
		private string string_7;

		// Token: 0x04000E41 RID: 3649
		private string string_8;

		// Token: 0x04000E42 RID: 3650
		private string string_9;

		// Token: 0x0600129C RID: 4764
		// RVA: 0x0001154D File Offset: 0x0000F74D
		public Class163()
		{
			this.Clear();
			this.vmethod_5();
		}

		// Token: 0x060012A1 RID: 4769
		// RVA: 0x00062AD4 File Offset: 0x00060CD4
		public virtual void Clear()
		{
			this.method_2();
			try
			{
				this.method_8(string.Empty);
				this.method_12(string.Empty);
				this.method_10(string.Empty);
				this.method_14(string.Empty);
				this.method_16(string.Empty);
				this.method_18(string.Empty);
				this.method_20(string.Empty);
				this.method_22(string.Empty);
				this.method_24(string.Empty);
				this.method_26(string.Empty);
				this.method_28(string.Empty);
				this.method_32(string.Empty);
				this.method_34(string.Empty);
				this.method_36(string.Empty);
				this.method_30(null);
			}
			finally
			{
				this.method_3();
			}
		}

		// Token: 0x0600129B RID: 4763
		// RVA: 0x00062A50 File Offset: 0x00060C50
		public void method_0(EventHandler eventHandler_1)
		{
			EventHandler eventHandler = this.eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_1);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600129F RID: 4767
		// RVA: 0x00011585 File Offset: 0x0000F785
		public void method_1(StringCollection stringCollection_0)
		{
			this.vmethod_1(stringCollection_0);
		}

		// Token: 0x060012AE RID: 4782
		// RVA: 0x0001163A File Offset: 0x0000F83A
		public void method_10(string string_15)
		{
			if (this.string_1 != string_15)
			{
				this.string_1 = string_15;
				this.method_6();
			}
		}

		// Token: 0x060012AF RID: 4783
		// RVA: 0x00011657 File Offset: 0x0000F857
		public string method_11()
		{
			return this.string_2;
		}

		// Token: 0x060012B0 RID: 4784
		// RVA: 0x0001165F File Offset: 0x0000F85F
		public void method_12(string string_15)
		{
			if (this.string_2 != string_15)
			{
				this.string_2 = string_15;
				this.method_6();
			}
		}

		// Token: 0x060012B1 RID: 4785
		// RVA: 0x0001167C File Offset: 0x0000F87C
		public string method_13()
		{
			return this.string_3;
		}

		// Token: 0x060012B2 RID: 4786
		// RVA: 0x00011684 File Offset: 0x0000F884
		public void method_14(string string_15)
		{
			if (this.string_3 != string_15)
			{
				this.string_3 = string_15;
				this.method_6();
			}
		}

		// Token: 0x060012B3 RID: 4787
		// RVA: 0x000116A1 File Offset: 0x0000F8A1
		public string method_15()
		{
			return this.string_4;
		}

		// Token: 0x060012B4 RID: 4788
		// RVA: 0x000116A9 File Offset: 0x0000F8A9
		public void method_16(string string_15)
		{
			if (this.string_4 != string_15)
			{
				this.string_4 = string_15;
				this.method_6();
			}
		}

		// Token: 0x060012B5 RID: 4789
		// RVA: 0x000116C6 File Offset: 0x0000F8C6
		public string method_17()
		{
			return this.string_5;
		}

		// Token: 0x060012B6 RID: 4790
		// RVA: 0x000116CE File Offset: 0x0000F8CE
		public void method_18(string string_15)
		{
			if (this.string_5 != string_15)
			{
				this.string_5 = string_15;
				this.method_6();
			}
		}

		// Token: 0x060012B7 RID: 4791
		// RVA: 0x000116EB File Offset: 0x0000F8EB
		public string method_19()
		{
			return this.string_6;
		}

		// Token: 0x060012A0 RID: 4768
		// RVA: 0x0001158E File Offset: 0x0000F78E
		public void method_2()
		{
			this.int_0++;
		}

		// Token: 0x060012B8 RID: 4792
		// RVA: 0x000116F3 File Offset: 0x0000F8F3
		public void method_20(string string_15)
		{
			if (this.string_6 != string_15)
			{
				this.string_6 = string_15;
				this.method_6();
			}
		}

		// Token: 0x060012B9 RID: 4793
		// RVA: 0x00011710 File Offset: 0x0000F910
		public string method_21()
		{
			return this.string_7;
		}

		// Token: 0x060012BA RID: 4794
		// RVA: 0x00011718 File Offset: 0x0000F918
		public void method_22(string string_15)
		{
			if (this.string_7 != string_15)
			{
				this.string_7 = string_15;
				this.method_6();
			}
		}

		// Token: 0x060012BB RID: 4795
		// RVA: 0x00011735 File Offset: 0x0000F935
		public string method_23()
		{
			return this.string_8;
		}

		// Token: 0x060012BC RID: 4796
		// RVA: 0x0001173D File Offset: 0x0000F93D
		public void method_24(string string_15)
		{
			if (this.string_8 != string_15)
			{
				this.string_8 = string_15;
				this.method_6();
			}
		}

		// Token: 0x060012BD RID: 4797
		// RVA: 0x0001175A File Offset: 0x0000F95A
		public string method_25()
		{
			return this.string_9;
		}

		// Token: 0x060012BE RID: 4798
		// RVA: 0x00011762 File Offset: 0x0000F962
		public void method_26(string string_15)
		{
			if (this.string_9 != string_15)
			{
				this.string_9 = string_15;
				this.method_6();
			}
		}

		// Token: 0x060012BF RID: 4799
		// RVA: 0x0001177F File Offset: 0x0000F97F
		public string method_27()
		{
			return this.string_10;
		}

		// Token: 0x060012C0 RID: 4800
		// RVA: 0x00011787 File Offset: 0x0000F987
		public void method_28(string string_15)
		{
			if (this.string_10 != string_15)
			{
				this.string_10 = string_15;
				this.method_6();
			}
		}

		// Token: 0x060012C1 RID: 4801
		// RVA: 0x000117A4 File Offset: 0x0000F9A4
		public string[] method_29()
		{
			return this.string_11;
		}

		// Token: 0x060012A2 RID: 4770
		// RVA: 0x0001159E File Offset: 0x0000F79E
		public void method_3()
		{
			if (this.int_0 > 0)
			{
				this.int_0--;
				this.method_6();
			}
		}

		// Token: 0x060012C2 RID: 4802
		// RVA: 0x000117AC File Offset: 0x0000F9AC
		public void method_30(string[] string_15)
		{
			this.string_11 = string_15;
			this.method_6();
		}

		// Token: 0x060012C3 RID: 4803
		// RVA: 0x000117BB File Offset: 0x0000F9BB
		public string method_31()
		{
			return this.string_12;
		}

		// Token: 0x060012C4 RID: 4804
		// RVA: 0x000117C3 File Offset: 0x0000F9C3
		public void method_32(string string_15)
		{
			if (this.string_12 != string_15)
			{
				this.string_12 = string_15;
				this.method_6();
			}
		}

		// Token: 0x060012C5 RID: 4805
		// RVA: 0x000117E0 File Offset: 0x0000F9E0
		public string method_33()
		{
			return this.string_13;
		}

		// Token: 0x060012C6 RID: 4806
		// RVA: 0x000117E8 File Offset: 0x0000F9E8
		public void method_34(string string_15)
		{
			if (this.string_13 != string_15)
			{
				this.string_13 = string_15;
				this.method_6();
			}
		}

		// Token: 0x060012C7 RID: 4807
		// RVA: 0x00011805 File Offset: 0x0000FA05
		public string method_35()
		{
			return this.string_14;
		}

		// Token: 0x060012C8 RID: 4808
		// RVA: 0x0001180D File Offset: 0x0000FA0D
		public void method_36(string string_15)
		{
			if (this.string_14 != string_15)
			{
				this.string_14 = string_15;
				this.method_6();
			}
		}

		// Token: 0x060012A7 RID: 4775
		// RVA: 0x00062DB4 File Offset: 0x00060FB4
		public void method_4(IList ilist_0)
		{
			this.method_2();
			try
			{
				this.Clear();
				Class158 class = new Class158();
				Class158.smethod_2(0, ilist_0, class);
				this.vmethod_2(ilist_0, class);
				Class173 class2 = new Class173();
				foreach (Class157 class3 in class)
				{
					if (!this.class173_0.Contains(class3.Name, true))
					{
						class2.Add(class3.Name + ": " + Class158.smethod_3(ilist_0, class3));
					}
				}
				if (class2.Count > 0)
				{
					this.method_30(class2.ToArray());
				}
			}
			finally
			{
				this.method_3();
			}
		}

		// Token: 0x060012A8 RID: 4776
		// RVA: 0x000115D8 File Offset: 0x0000F7D8
		protected void method_5(string string_15)
		{
			if (!this.class173_0.Contains(string_15, true))
			{
				this.class173_0.Add(string_15);
			}
		}

		// Token: 0x060012AA RID: 4778
		// RVA: 0x000115F6 File Offset: 0x0000F7F6
		public void method_6()
		{
			if (this.int_0 == 0)
			{
				this.vmethod_3();
			}
		}

		// Token: 0x060012AB RID: 4779
		// RVA: 0x00011606 File Offset: 0x0000F806
		public string method_7()
		{
			return this.string_0;
		}

		// Token: 0x060012AC RID: 4780
		// RVA: 0x0001160E File Offset: 0x0000F80E
		public void method_8(string string_15)
		{
			if (this.string_0 != string_15)
			{
				this.string_0 = string_15;
				this.method_6();
				this.string_0 = string_15;
			}
		}

		// Token: 0x060012AD RID: 4781
		// RVA: 0x00011632 File Offset: 0x0000F832
		public string method_9()
		{
			return this.string_1;
		}

		// Token: 0x0600129D RID: 4765
		// RVA: 0x0001156C File Offset: 0x0000F76C
		public static string smethod_0(string string_15, string string_16, string string_17)
		{
			if (!Class174.smethod_2(string_17))
			{
				return string.Format("{0}; {1}={2}", string_15, string_16, string_17);
			}
			return string_15;
		}

		// Token: 0x0600129E RID: 4766
		// RVA: 0x00062A88 File Offset: 0x00060C88
		protected virtual void vmethod_0(StringCollection stringCollection_0)
		{
			string string_ = this.method_21();
			if (!Class174.smethod_2(string_))
			{
				string_ = Class163.smethod_0(Class163.smethod_0(string_, "boundary", this.method_7()), "charset", this.method_11());
				Class158.smethod_0(stringCollection_0, "Content-Type", string_);
			}
		}

		// Token: 0x060012A3 RID: 4771
		// RVA: 0x00062BA4 File Offset: 0x00060DA4
		protected virtual void vmethod_1(StringCollection stringCollection_0)
		{
			Class158.smethod_0(stringCollection_0, "Content-Encoding", this.method_15());
			Class158.smethod_0(stringCollection_0, "Content-Language", this.method_17());
			Class158.smethod_0(stringCollection_0, "Content-Length", this.method_19());
			Class158.smethod_0(stringCollection_0, "Content-Version", this.method_23());
			this.vmethod_0(stringCollection_0);
			Class158.smethod_0(stringCollection_0, "Date", this.method_25());
			Class158.smethod_0(stringCollection_0, "Expires", this.method_27());
			Class158.smethod_0(stringCollection_0, "LastModified", this.method_31());
			Class158.smethod_0(stringCollection_0, "Transfer-Encoding", this.method_35());
			Class158.smethod_0(stringCollection_0, "Cache-Control", this.method_9());
			Class158.smethod_0(stringCollection_0, "Connection", this.method_13());
			Class158.smethod_0(stringCollection_0, "Proxy-Connection", this.method_33());
			if (this.method_29() != null)
			{
				stringCollection_0.AddRange(this.method_29());
			}
		}

		// Token: 0x060012A4 RID: 4772
		// RVA: 0x00062C88 File Offset: 0x00060E88
		protected virtual void vmethod_2(IList ilist_0, Class158 class158_0)
		{
			this.method_10(Class158.smethod_4(ilist_0, class158_0, "Cache-Control"));
			this.method_14(Class158.smethod_4(ilist_0, class158_0, "Connection"));
			this.method_16(Class158.smethod_4(ilist_0, class158_0, "Content-Encoding"));
			this.method_18(Class158.smethod_4(ilist_0, class158_0, "Content-Language"));
			this.method_20(Class158.smethod_4(ilist_0, class158_0, "Content-Length"));
			this.method_24(Class158.smethod_4(ilist_0, class158_0, "Content-Version"));
			this.method_26(Class158.smethod_4(ilist_0, class158_0, "Date"));
			this.method_28(Class158.smethod_4(ilist_0, class158_0, "Expires"));
			this.method_32(Class158.smethod_4(ilist_0, class158_0, "Last-Modified"));
			this.method_34(Class158.smethod_4(ilist_0, class158_0, "Proxy-Connection"));
			this.method_36(Class158.smethod_4(ilist_0, class158_0, "Transfer-Encoding"));
			this.vmethod_4(ilist_0, class158_0);
		}

		// Token: 0x060012A5 RID: 4773
		// RVA: 0x000115BD File Offset: 0x0000F7BD
		protected virtual void vmethod_3()
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, EventArgs.Empty);
			}
		}

		// Token: 0x060012A6 RID: 4774
		// RVA: 0x00062D64 File Offset: 0x00060F64
		protected virtual void vmethod_4(IList ilist_0, Class158 class158_0)
		{
			string text = Class158.smethod_4(ilist_0, class158_0, "Content-Type");
			this.method_22(Class158.smethod_5(text, string.Empty));
			this.method_8(Class158.smethod_5(text, "boundary="));
			this.method_12(Class158.smethod_5(text, "charset="));
		}

		// Token: 0x060012A9 RID: 4777
		// RVA: 0x00062E8C File Offset: 0x0006108C
		protected virtual void vmethod_5()
		{
			this.method_5("Cache-Control");
			this.method_5("Connection");
			this.method_5("Content-Encoding");
			this.method_5("Content-Language");
			this.method_5("Content-Length");
			this.method_5("Content-Type");
			this.method_5("Content-Version");
			this.method_5("Date");
			this.method_5("Expires");
			this.method_5("Last-Modified");
			this.method_5("Proxy-Connection");
			this.method_5("Transfer-Encoding");
		}
	}
}
