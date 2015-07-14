using System;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;

namespace ns30
{
	// Token: 0x020001FA RID: 506
	internal sealed class Class154 : CollectionBase
	{
		// Token: 0x170002A9 RID: 681
		public Class153 this[string string_0]
		{
			// Token: 0x060011C9 RID: 4553
			// RVA: 0x000606E0 File Offset: 0x0005E8E0
			get
			{
				foreach (Class153 class in this)
				{
					if (string.Compare(class.Name, string_0, true, CultureInfo.InvariantCulture) == 0)
					{
						return class;
					}
				}
				return null;
			}
		}

		// Token: 0x170002AA RID: 682
		public Class153 this[int int_0]
		{
			// Token: 0x060011CA RID: 4554
			// RVA: 0x00010D04 File Offset: 0x0000EF04
			get
			{
				return (Class153)base.List[int_0];
			}
		}

		// Token: 0x060011C1 RID: 4545
		// RVA: 0x00010CDD File Offset: 0x0000EEDD
		public void Add(Class153 class153_0)
		{
			base.List.Add(class153_0);
		}

		// Token: 0x060011C3 RID: 4547
		// RVA: 0x000603F4 File Offset: 0x0005E5F4
		private string method_0(string string_0)
		{
			int num = string_0.ToLower(CultureInfo.InvariantCulture).IndexOf("expires=");
			if (num > -1)
			{
				return Class158.smethod_5(string_0.Substring(num + "expires=".Length).Replace(",", "=="), string.Empty).Replace("==", ",");
			}
			return string.Empty;
		}

		// Token: 0x060011C4 RID: 4548
		// RVA: 0x0006045C File Offset: 0x0005E65C
		public void method_1(StringCollection stringCollection_0)
		{
			base.Clear();
			Class158 class158_ = new Class158();
			Class158.smethod_2(0, stringCollection_0, class158_);
			if (!Class174.smethod_2(Class158.smethod_4(stringCollection_0, class158_, "set-cookie2")))
			{
				this.method_2(stringCollection_0, class158_, "set-cookie2");
				return;
			}
			this.method_2(stringCollection_0, class158_, "set-cookie");
		}

		// Token: 0x060011C6 RID: 4550
		// RVA: 0x0006057C File Offset: 0x0005E77C
		private void method_2(StringCollection stringCollection_0, Class158 class158_0, string string_0)
		{
			foreach (Class157 class in class158_0)
			{
				if (string.Compare(class.Name, string_0, true, CultureInfo.InvariantCulture) == 0)
				{
					this.vmethod_1(Class158.smethod_3(stringCollection_0, class));
				}
			}
		}

		// Token: 0x060011C7 RID: 4551
		// RVA: 0x000605EC File Offset: 0x0005E7EC
		private void method_3(StringCollection stringCollection_0)
		{
			Class158 class = new Class158();
			Class158.smethod_2(0, stringCollection_0, class);
			for (int i = class.Count - 1; i >= 0; i--)
			{
				Class157 class2 = class[i];
				if (string.Compare(class2.Name, "cookie", true, CultureInfo.InvariantCulture) == 0)
				{
					Class158.smethod_7(stringCollection_0, class, class2);
				}
			}
		}

		// Token: 0x060011C8 RID: 4552
		// RVA: 0x00060644 File Offset: 0x0005E844
		public void method_4(StringCollection stringCollection_0)
		{
			this.method_3(stringCollection_0);
			string text = "";
			foreach (Class153 class153_ in this)
			{
				text = text + this.vmethod_0(class153_) + "; ";
			}
			if (!Class174.smethod_2(text))
			{
				text = text.Substring(0, text.Length - "; ".Length);
			}
			Class158.smethod_0(stringCollection_0, "Cookie", text);
		}

		// Token: 0x060011C2 RID: 4546
		// RVA: 0x00010CEC File Offset: 0x0000EEEC
		protected virtual string vmethod_0(Class153 class153_0)
		{
			return class153_0.Name + "=" + class153_0.Value;
		}

		// Token: 0x060011C5 RID: 4549
		// RVA: 0x000604AC File Offset: 0x0005E6AC
		protected virtual void vmethod_1(string string_0)
		{
			if (!Class174.smethod_2(string_0))
			{
				string text = string_0;
				string value = "";
				int num = string_0.IndexOf("=");
				if (num > -1)
				{
					text = string_0.Substring(0, num);
					value = Class158.smethod_5(string_0, text.ToLower(CultureInfo.InvariantCulture) + "=");
				}
				if (this[text] == null)
				{
					Class153 class = new Class153();
					this.Add(class);
					class.Name = text;
					class.Value = value;
					class.method_2(this.method_0(string_0));
					class.method_1(Class158.smethod_5(string_0, "domain="));
					class.Path = Class158.smethod_5(string_0, "path=");
					class.method_3(string_0.ToLower(CultureInfo.InvariantCulture).IndexOf("secure") > -1);
					class.method_0(string_0);
				}
			}
		}
	}
}
