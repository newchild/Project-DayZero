using System;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;

namespace ns30
{
	// Token: 0x0200021A RID: 538
	internal sealed class Class165 : Class163
	{
		// Token: 0x04000E7A RID: 3706
		private string string_15;

		// Token: 0x04000E7B RID: 3707
		private string string_16;

		// Token: 0x04000E7C RID: 3708
		private string string_17;

		// Token: 0x04000E7D RID: 3709
		private string[] string_18;

		// Token: 0x04000E7E RID: 3710
		private string string_19;

		// Token: 0x04000E7F RID: 3711
		private string string_20;

		// Token: 0x04000E80 RID: 3712
		private string string_21;

		// Token: 0x04000E81 RID: 3713
		private string[] string_22;

		// Token: 0x04000E82 RID: 3714
		private string string_23;

		// Token: 0x04000E83 RID: 3715
		private string string_24;

		// Token: 0x170002C3 RID: 707
		public string Location
		{
			// Token: 0x06001331 RID: 4913
			// RVA: 0x00011DD2 File Offset: 0x0000FFD2
			get
			{
				return this.string_21;
			}
			// Token: 0x06001332 RID: 4914
			// RVA: 0x00011DDA File Offset: 0x0000FFDA
			set
			{
				if (this.string_21 != value)
				{
					this.string_21 = value;
					base.method_6();
				}
			}
		}

		// Token: 0x0600131F RID: 4895
		// RVA: 0x00063844 File Offset: 0x00061A44
		public override void Clear()
		{
			base.method_2();
			try
			{
				base.Clear();
				this.method_40(string.Empty);
				this.method_42(string.Empty);
				this.method_44(string.Empty);
				this.method_46(null);
				this.method_48(string.Empty);
				this.method_50(string.Empty);
				this.Location = string.Empty;
				this.method_52(null);
				this.method_54(string.Empty);
				this.method_56(string.Empty);
			}
			finally
			{
				base.method_3();
			}
		}

		// Token: 0x06001320 RID: 4896
		// RVA: 0x000638DC File Offset: 0x00061ADC
		private string[] method_37(IList ilist_0, Class158 class158_0, string string_25)
		{
			ArrayList arrayList = new ArrayList();
			foreach (Class157 class in class158_0)
			{
				if (string.Compare(string_25, class.Name, true, CultureInfo.InvariantCulture) == 0)
				{
					arrayList.Add(Class158.smethod_3(ilist_0, class));
				}
			}
			return (string[])arrayList.ToArray(typeof(string));
		}

		// Token: 0x06001324 RID: 4900
		// RVA: 0x00063BB4 File Offset: 0x00061DB4
		private void method_38(StringCollection stringCollection_0, string string_25, IEnumerable ienumerable_0)
		{
			if (ienumerable_0 != null)
			{
				foreach (string string_26 in ienumerable_0)
				{
					Class158.smethod_0(stringCollection_0, string_25, string_26);
				}
			}
		}

		// Token: 0x06001325 RID: 4901
		// RVA: 0x00011D02 File Offset: 0x0000FF02
		public string method_39()
		{
			return this.string_15;
		}

		// Token: 0x06001326 RID: 4902
		// RVA: 0x00011D0A File Offset: 0x0000FF0A
		public void method_40(string string_25)
		{
			if (this.string_15 != string_25)
			{
				this.string_15 = string_25;
				base.method_6();
			}
		}

		// Token: 0x06001327 RID: 4903
		// RVA: 0x00011D27 File Offset: 0x0000FF27
		public string method_41()
		{
			return this.string_16;
		}

		// Token: 0x06001328 RID: 4904
		// RVA: 0x00011D2F File Offset: 0x0000FF2F
		public void method_42(string string_25)
		{
			if (this.string_16 != string_25)
			{
				this.string_16 = string_25;
				base.method_6();
			}
		}

		// Token: 0x06001329 RID: 4905
		// RVA: 0x00011D4C File Offset: 0x0000FF4C
		public string method_43()
		{
			return this.string_17;
		}

		// Token: 0x0600132A RID: 4906
		// RVA: 0x00011D54 File Offset: 0x0000FF54
		public void method_44(string string_25)
		{
			if (this.string_17 != string_25)
			{
				this.string_17 = string_25;
				base.method_6();
			}
		}

		// Token: 0x0600132B RID: 4907
		// RVA: 0x00011D71 File Offset: 0x0000FF71
		public string[] method_45()
		{
			return this.string_18;
		}

		// Token: 0x0600132C RID: 4908
		// RVA: 0x00011D79 File Offset: 0x0000FF79
		public void method_46(string[] string_25)
		{
			this.string_18 = string_25;
			base.method_6();
		}

		// Token: 0x0600132D RID: 4909
		// RVA: 0x00011D88 File Offset: 0x0000FF88
		public string method_47()
		{
			return this.string_19;
		}

		// Token: 0x0600132E RID: 4910
		// RVA: 0x00011D90 File Offset: 0x0000FF90
		public void method_48(string string_25)
		{
			if (this.string_19 != string_25)
			{
				this.string_19 = string_25;
				base.method_6();
			}
		}

		// Token: 0x0600132F RID: 4911
		// RVA: 0x00011DAD File Offset: 0x0000FFAD
		public string method_49()
		{
			return this.string_20;
		}

		// Token: 0x06001330 RID: 4912
		// RVA: 0x00011DB5 File Offset: 0x0000FFB5
		public void method_50(string string_25)
		{
			if (this.string_20 != string_25)
			{
				this.string_20 = string_25;
				base.method_6();
			}
		}

		// Token: 0x06001333 RID: 4915
		// RVA: 0x00011DF7 File Offset: 0x0000FFF7
		public string[] method_51()
		{
			return this.string_22;
		}

		// Token: 0x06001334 RID: 4916
		// RVA: 0x00011DFF File Offset: 0x0000FFFF
		public void method_52(string[] string_25)
		{
			this.string_22 = string_25;
			base.method_6();
		}

		// Token: 0x06001335 RID: 4917
		// RVA: 0x00011E0E File Offset: 0x0001000E
		public string method_53()
		{
			return this.string_23;
		}

		// Token: 0x06001336 RID: 4918
		// RVA: 0x00011E16 File Offset: 0x00010016
		public void method_54(string string_25)
		{
			if (this.string_23 != string_25)
			{
				this.string_23 = string_25;
				base.method_6();
			}
		}

		// Token: 0x06001337 RID: 4919
		// RVA: 0x00011E33 File Offset: 0x00010033
		public string method_55()
		{
			return this.string_24;
		}

		// Token: 0x06001338 RID: 4920
		// RVA: 0x00011E3B File Offset: 0x0001003B
		public void method_56(string string_25)
		{
			if (this.string_24 != string_25)
			{
				this.string_24 = string_25;
				base.method_6();
			}
		}

		// Token: 0x06001321 RID: 4897
		// RVA: 0x00063968 File Offset: 0x00061B68
		protected override void vmethod_1(StringCollection stringCollection_0)
		{
			Class158.smethod_0(stringCollection_0, "Allow", this.method_43());
			Class158.smethod_0(stringCollection_0, "Accept-Ranges", this.method_39());
			Class158.smethod_0(stringCollection_0, "Age", this.method_41());
			Class158.smethod_0(stringCollection_0, "Content-Range", this.method_47());
			Class158.smethod_0(stringCollection_0, "Content-Encoding", base.method_15());
			Class158.smethod_0(stringCollection_0, "ETag", this.method_49());
			Class158.smethod_0(stringCollection_0, "Location", this.Location);
			Class158.smethod_0(stringCollection_0, "Retry-After", this.method_53());
			Class158.smethod_0(stringCollection_0, "Server", this.method_55());
			this.method_38(stringCollection_0, "WWW-Authenticate", this.method_45());
			this.method_38(stringCollection_0, "Proxy-Authenticate", this.method_51());
			base.vmethod_1(stringCollection_0);
		}

		// Token: 0x06001322 RID: 4898
		// RVA: 0x00063A3C File Offset: 0x00061C3C
		protected override void vmethod_2(IList ilist_0, Class158 class158_0)
		{
			base.vmethod_2(ilist_0, class158_0);
			this.method_40(Class158.smethod_4(ilist_0, class158_0, "Accept-Ranges"));
			this.method_42(Class158.smethod_4(ilist_0, class158_0, "Age"));
			this.method_44(Class158.smethod_4(ilist_0, class158_0, "Allow"));
			this.method_48(Class158.smethod_4(ilist_0, class158_0, "Content-Range"));
			base.method_16(Class158.smethod_4(ilist_0, class158_0, "Content-Encoding"));
			this.method_50(Class158.smethod_4(ilist_0, class158_0, "ETag"));
			this.Location = Class158.smethod_4(ilist_0, class158_0, "Location");
			this.method_54(Class158.smethod_4(ilist_0, class158_0, "Retry-After"));
			this.method_56(Class158.smethod_4(ilist_0, class158_0, "Server"));
			this.method_46(this.method_37(ilist_0, class158_0, "WWW-Authenticate"));
			this.method_52(this.method_37(ilist_0, class158_0, "Proxy-Authenticate"));
		}

		// Token: 0x06001323 RID: 4899
		// RVA: 0x00063B1C File Offset: 0x00061D1C
		protected override void vmethod_5()
		{
			base.vmethod_5();
			base.method_5("Accept-Ranges");
			base.method_5("Age");
			base.method_5("Allow");
			base.method_5("WWW-Authenticate");
			base.method_5("Content-Range");
			base.method_5("Content-Encoding");
			base.method_5("ETag");
			base.method_5("Location");
			base.method_5("Proxy-Authenticate");
			base.method_5("Retry-After");
			base.method_5("Server");
			base.method_5("Transfer-Encoding");
		}
	}
}
