using ns27;
using osu_common.Helpers;
using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace ns82
{
	// Token: 0x02000614 RID: 1556
	internal sealed class Control1 : TextInputControl
	{
		// Token: 0x04002BE7 RID: 11239
		[CompilerGenerated]
		private string string_0;

		// Token: 0x170003AA RID: 938
		public override string Text
		{
			// Token: 0x0600302F RID: 12335
			// RVA: 0x00023C59 File Offset: 0x00021E59
			get
			{
				return this.method_16('*', this.TextBox.Text.Length);
			}
			// Token: 0x06003030 RID: 12336
			// RVA: 0x00023C73 File Offset: 0x00021E73
			set
			{
				base.Text = value;
				this.method_15(value);
			}
		}

		// Token: 0x0600302E RID: 12334
		// RVA: 0x00023C1B File Offset: 0x00021E1B
		public Control1(Class754 class754_1) : base(class754_1)
		{
			this.method_15(this.TextBox.Text);
			base.method_10(new VoidDelegate(this.method_13));
			base.method_11(new KeyEventHandler(this.method_17));
		}

		// Token: 0x06003031 RID: 12337
		// RVA: 0x00023C83 File Offset: 0x00021E83
		private void method_13()
		{
			this.method_15(this.TextBox.Text);
		}

		// Token: 0x06003032 RID: 12338
		// RVA: 0x00023C96 File Offset: 0x00021E96
		[CompilerGenerated]
		internal string method_14()
		{
			return this.string_0;
		}

		// Token: 0x06003033 RID: 12339
		// RVA: 0x00023C9E File Offset: 0x00021E9E
		[CompilerGenerated]
		private void method_15(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x06003034 RID: 12340
		// RVA: 0x001377A4 File Offset: 0x001359A4
		private string method_16(char char_0, int int_0)
		{
			StringBuilder stringBuilder = new StringBuilder(int_0);
			for (int i = 0; i < int_0; i++)
			{
				stringBuilder.Append(char_0);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003035 RID: 12341
		// RVA: 0x00023CA7 File Offset: 0x00021EA7
		private void method_17(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.C)
			{
				e.SuppressKeyPress = true;
			}
		}
	}
}
