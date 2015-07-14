using System;
using System.Globalization;

namespace ns30
{
	// Token: 0x0200022F RID: 559
	internal sealed class Class176
	{
		// Token: 0x04000EAB RID: 3755
		private int int_0;

		// Token: 0x04000EA7 RID: 3751
		private string string_0;

		// Token: 0x04000EA8 RID: 3752
		private string string_1;

		// Token: 0x04000EA9 RID: 3753
		private string string_2;

		// Token: 0x04000EAA RID: 3754
		private string string_3;

		// Token: 0x04000EAC RID: 3756
		private string string_4;

		// Token: 0x04000EAE RID: 3758
		private string string_5;

		// Token: 0x04000EAD RID: 3757
		private Uri uri_0;

		// Token: 0x060013A2 RID: 5026
		// RVA: 0x00064D14 File Offset: 0x00062F14
		private void method_0(Uri uri_1)
		{
			this.uri_0 = uri_1;
			this.string_2 = string.Empty;
			this.int_0 = 80;
			this.string_0 = string.Empty;
			this.string_1 = string.Empty;
			this.string_5 = string.Empty;
			this.string_3 = string.Empty;
			this.string_4 = string.Empty;
			if (this.uri_0 != null)
			{
				this.string_2 = this.uri_0.Host;
				this.int_0 = this.uri_0.Port;
				this.string_0 = this.uri_0.PathAndQuery;
				this.string_1 = this.uri_0.AbsoluteUri;
				this.string_4 = this.uri_0.Scheme;
				int num = this.uri_0.UserInfo.IndexOf(':');
				if (num > 0)
				{
					this.string_5 = this.uri_0.UserInfo.Substring(0, num);
					this.string_3 = this.uri_0.UserInfo.Substring(num + 1);
					return;
				}
				this.string_5 = this.uri_0.UserInfo;
			}
		}

		// Token: 0x060013A5 RID: 5029
		// RVA: 0x00012132 File Offset: 0x00010332
		public string method_1()
		{
			return this.string_0;
		}

		// Token: 0x060013A6 RID: 5030
		// RVA: 0x0001213A File Offset: 0x0001033A
		public string method_2()
		{
			return this.string_1;
		}

		// Token: 0x060013A7 RID: 5031
		// RVA: 0x00012142 File Offset: 0x00010342
		public string method_3()
		{
			return this.string_2;
		}

		// Token: 0x060013A8 RID: 5032
		// RVA: 0x0001214A File Offset: 0x0001034A
		public int method_4()
		{
			return this.int_0;
		}

		// Token: 0x060013A9 RID: 5033
		// RVA: 0x00012152 File Offset: 0x00010352
		public string method_5()
		{
			return this.string_4;
		}

		// Token: 0x060013AA RID: 5034
		// RVA: 0x0001215A File Offset: 0x0001035A
		public Uri method_6()
		{
			return this.uri_0;
		}

		// Token: 0x060013A3 RID: 5027
		// RVA: 0x00064E34 File Offset: 0x00063034
		public void Parse(string string_6)
		{
			try
			{
				this.method_0(new Uri(string_6));
			}
			catch (UriFormatException)
			{
				if (string_6 != "*")
				{
					if (Class174.smethod_2(string_6) || string_6.ToLower(CultureInfo.InvariantCulture).IndexOf(Uri.UriSchemeHttp) >= 0)
					{
						throw;
					}
					this.method_0(new Uri(Uri.UriSchemeHttp + Uri.SchemeDelimiter + string_6));
				}
				else
				{
					this.method_0(null);
					this.string_2 = "*";
					this.int_0 = 80;
					this.string_0 = "/";
					this.string_1 = "http://*/";
					this.string_5 = string.Empty;
					this.string_3 = string.Empty;
					this.string_4 = Uri.UriSchemeHttp;
				}
			}
		}

		// Token: 0x060013A4 RID: 5028
		// RVA: 0x00012123 File Offset: 0x00010323
		public void Parse(Uri uri_1, string string_6)
		{
			this.method_0(new Uri(uri_1, string_6));
		}
	}
}
