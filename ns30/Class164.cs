using System;
using System.Collections;
using System.Collections.Specialized;

namespace ns30
{
	// Token: 0x02000216 RID: 534
	internal sealed class Class164 : Class163
	{
		// Token: 0x04000E6B RID: 3691
		private string string_15;

		// Token: 0x04000E6C RID: 3692
		private string string_16;

		// Token: 0x04000E6D RID: 3693
		private string string_17;

		// Token: 0x04000E6E RID: 3694
		private string string_18;

		// Token: 0x04000E6F RID: 3695
		private string string_19;

		// Token: 0x04000E70 RID: 3696
		private string string_20;

		// Token: 0x04000E71 RID: 3697
		private string string_21;

		// Token: 0x04000E72 RID: 3698
		private string string_22;

		// Token: 0x04000E73 RID: 3699
		private string string_23;

		// Token: 0x04000E74 RID: 3700
		private string string_24;

		// Token: 0x060012F6 RID: 4854
		// RVA: 0x000634F4 File Offset: 0x000616F4
		public override void Clear()
		{
			base.method_2();
			try
			{
				base.Clear();
				this.method_38("*/*");
				this.method_40(string.Empty);
				this.method_42(string.Empty);
				this.method_44(string.Empty);
				this.method_46(string.Empty);
				this.method_48(string.Empty);
				this.method_50(string.Empty);
				this.method_52(string.Empty);
				this.method_54(string.Empty);
				this.method_56(string.Empty);
			}
			finally
			{
				base.method_3();
			}
		}

		// Token: 0x060012FA RID: 4858
		// RVA: 0x00011AA0 File Offset: 0x0000FCA0
		public string method_37()
		{
			return this.string_15;
		}

		// Token: 0x060012FB RID: 4859
		// RVA: 0x00011AA8 File Offset: 0x0000FCA8
		public void method_38(string string_25)
		{
			if (this.string_15 != string_25)
			{
				this.string_15 = string_25;
				base.method_6();
			}
		}

		// Token: 0x060012FC RID: 4860
		// RVA: 0x00011AC5 File Offset: 0x0000FCC5
		public string method_39()
		{
			return this.string_16;
		}

		// Token: 0x060012FD RID: 4861
		// RVA: 0x00011ACD File Offset: 0x0000FCCD
		public void method_40(string string_25)
		{
			if (this.string_16 != string_25)
			{
				this.string_16 = string_25;
				base.method_6();
			}
		}

		// Token: 0x060012FE RID: 4862
		// RVA: 0x00011AEA File Offset: 0x0000FCEA
		public string method_41()
		{
			return this.string_17;
		}

		// Token: 0x060012FF RID: 4863
		// RVA: 0x00011AF2 File Offset: 0x0000FCF2
		public void method_42(string string_25)
		{
			if (this.string_17 != string_25)
			{
				this.string_17 = string_25;
				base.method_6();
			}
		}

		// Token: 0x06001300 RID: 4864
		// RVA: 0x00011B0F File Offset: 0x0000FD0F
		public string method_43()
		{
			return this.string_18;
		}

		// Token: 0x06001301 RID: 4865
		// RVA: 0x00011B17 File Offset: 0x0000FD17
		public void method_44(string string_25)
		{
			if (this.string_18 != string_25)
			{
				this.string_18 = string_25;
				base.method_6();
			}
		}

		// Token: 0x06001302 RID: 4866
		// RVA: 0x00011B34 File Offset: 0x0000FD34
		public string method_45()
		{
			return this.string_19;
		}

		// Token: 0x06001303 RID: 4867
		// RVA: 0x00011B3C File Offset: 0x0000FD3C
		public void method_46(string string_25)
		{
			if (this.string_19 != string_25)
			{
				this.string_19 = string_25;
				base.method_6();
			}
		}

		// Token: 0x06001304 RID: 4868
		// RVA: 0x00011B59 File Offset: 0x0000FD59
		public string method_47()
		{
			return this.string_20;
		}

		// Token: 0x06001305 RID: 4869
		// RVA: 0x00011B61 File Offset: 0x0000FD61
		public void method_48(string string_25)
		{
			if (this.string_20 != string_25)
			{
				this.string_20 = string_25;
				base.method_6();
			}
		}

		// Token: 0x06001306 RID: 4870
		// RVA: 0x00011B7E File Offset: 0x0000FD7E
		public string method_49()
		{
			return this.string_21;
		}

		// Token: 0x06001307 RID: 4871
		// RVA: 0x00011B86 File Offset: 0x0000FD86
		public void method_50(string string_25)
		{
			if (this.string_21 != string_25)
			{
				this.string_21 = string_25;
				base.method_6();
			}
		}

		// Token: 0x06001308 RID: 4872
		// RVA: 0x00011BA3 File Offset: 0x0000FDA3
		public string method_51()
		{
			return this.string_22;
		}

		// Token: 0x06001309 RID: 4873
		// RVA: 0x00011BAB File Offset: 0x0000FDAB
		public void method_52(string string_25)
		{
			if (this.string_22 != string_25)
			{
				this.string_22 = string_25;
				base.method_6();
			}
		}

		// Token: 0x0600130A RID: 4874
		// RVA: 0x00011BC8 File Offset: 0x0000FDC8
		public string method_53()
		{
			return this.string_23;
		}

		// Token: 0x0600130B RID: 4875
		// RVA: 0x00011BD0 File Offset: 0x0000FDD0
		public void method_54(string string_25)
		{
			if (this.string_23 != string_25)
			{
				this.string_23 = string_25;
				base.method_6();
			}
		}

		// Token: 0x0600130C RID: 4876
		// RVA: 0x00011BED File Offset: 0x0000FDED
		public string method_55()
		{
			return this.string_24;
		}

		// Token: 0x0600130D RID: 4877
		// RVA: 0x00011BF5 File Offset: 0x0000FDF5
		public void method_56(string string_25)
		{
			if (this.string_24 != string_25)
			{
				this.string_24 = string_25;
				base.method_6();
			}
		}

		// Token: 0x060012F7 RID: 4855
		// RVA: 0x00063594 File Offset: 0x00061794
		protected override void vmethod_1(StringCollection stringCollection_0)
		{
			Class158.smethod_0(stringCollection_0, "Accept", this.method_37());
			Class158.smethod_0(stringCollection_0, "Accept-Charset", this.method_39());
			Class158.smethod_0(stringCollection_0, "Accept-Encoding", this.method_41());
			Class158.smethod_0(stringCollection_0, "Accept-Language", this.method_43());
			Class158.smethod_0(stringCollection_0, "Range", this.method_51());
			Class158.smethod_0(stringCollection_0, "Referer", this.method_53());
			Class158.smethod_0(stringCollection_0, "Host", this.method_47());
			Class158.smethod_0(stringCollection_0, "User-Agent", this.method_55());
			Class158.smethod_0(stringCollection_0, "Authorization", this.method_45());
			Class158.smethod_0(stringCollection_0, "Proxy-Authorization", this.method_49());
			base.vmethod_1(stringCollection_0);
		}

		// Token: 0x060012F8 RID: 4856
		// RVA: 0x00063654 File Offset: 0x00061854
		protected override void vmethod_2(IList ilist_0, Class158 class158_0)
		{
			base.vmethod_2(ilist_0, class158_0);
			this.method_38(Class158.smethod_4(ilist_0, class158_0, "Accept"));
			this.method_40(Class158.smethod_4(ilist_0, class158_0, "Accept-Charset"));
			this.method_42(Class158.smethod_4(ilist_0, class158_0, "Accept-Encoding"));
			this.method_44(Class158.smethod_4(ilist_0, class158_0, "Accept-Language"));
			this.method_46(Class158.smethod_4(ilist_0, class158_0, "Authorization"));
			this.method_48(Class158.smethod_4(ilist_0, class158_0, "Host"));
			this.method_50(Class158.smethod_4(ilist_0, class158_0, "Proxy-Authorization"));
			this.method_52(Class158.smethod_4(ilist_0, class158_0, "Range"));
			this.method_54(Class158.smethod_4(ilist_0, class158_0, "Referer"));
			this.method_56(Class158.smethod_4(ilist_0, class158_0, "User-Agent"));
		}

		// Token: 0x060012F9 RID: 4857
		// RVA: 0x00063720 File Offset: 0x00061920
		protected override void vmethod_5()
		{
			base.vmethod_5();
			base.method_5("Accept");
			base.method_5("Accept-Charset");
			base.method_5("Accept-Encoding");
			base.method_5("Accept-Language");
			base.method_5("Authorization");
			base.method_5("Host");
			base.method_5("Proxy-Authorization");
			base.method_5("Range");
			base.method_5("Referer");
			base.method_5("User-Agent");
		}
	}
}
