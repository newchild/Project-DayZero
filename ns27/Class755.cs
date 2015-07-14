using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns29;
using ns6;
using ns81;
using System;

namespace ns27
{
	// Token: 0x02000596 RID: 1430
	internal class Class755 : Class754
	{
		// Token: 0x04002654 RID: 9812
		private bool bool_7;

		// Token: 0x04002655 RID: 9813
		private string string_1;

		// Token: 0x170003A2 RID: 930
		internal override string Text
		{
			// Token: 0x06002DDE RID: 11742
			// RVA: 0x00022A07 File Offset: 0x00020C07
			get
			{
				if (this.bool_1)
				{
					return string.Empty;
				}
				return base.Text;
			}
			// Token: 0x06002DDF RID: 11743
			// RVA: 0x00022A1D File Offset: 0x00020C1D
			set
			{
				this.bool_1 = (value == this.string_1);
				base.Text = value;
				this.vmethod_3();
			}
		}

		// Token: 0x06002DD0 RID: 11728
		// RVA: 0x00129A30 File Offset: 0x00127C30
		public Class755(int int_5, Vector2 vector2_0, float float_2, bool bool_8, float float_3) : base(string.Empty, int_5, vector2_0, float_2, float_3, false)
		{
			if (bool_8)
			{
				this.class533_0.int_7 = 0;
				base.method_18(Color.get_TransparentWhite());
				base.method_17(Color.get_TransparentWhite());
				this.class533_0.bool_16 = true;
			}
		}

		// Token: 0x06002DD1 RID: 11729
		// RVA: 0x00022929 File Offset: 0x00020B29
		internal bool method_22()
		{
			return !this.textInputControl_0.bool_0;
		}

		// Token: 0x06002DD2 RID: 11730
		// RVA: 0x00022939 File Offset: 0x00020B39
		internal void method_23(bool bool_8)
		{
			this.textInputControl_0.bool_0 = !bool_8;
		}

		// Token: 0x06002DD3 RID: 11731
		// RVA: 0x0002294A File Offset: 0x00020B4A
		internal bool method_24()
		{
			return this.bool_7 && this.vmethod_5();
		}

		// Token: 0x06002DD4 RID: 11732
		// RVA: 0x0002295C File Offset: 0x00020B5C
		internal void method_25(bool bool_8)
		{
			if (this.bool_7 == bool_8)
			{
				return;
			}
			this.bool_7 = bool_8;
			if (bool_8)
			{
				base.method_19(true);
				return;
			}
			this.vmethod_4(false);
		}

		// Token: 0x06002DDB RID: 11739
		// RVA: 0x000229A2 File Offset: 0x00020BA2
		public string method_26()
		{
			return this.string_1;
		}

		// Token: 0x06002DDC RID: 11740
		// RVA: 0x000229AA File Offset: 0x00020BAA
		public void method_27(string string_2)
		{
			this.bool_2 = (string_2.Length > 0);
			this.bool_1 = true;
			this.string_1 = string_2;
			this.Text = this.string_1;
			this.vmethod_3();
		}

		// Token: 0x06002DDD RID: 11741
		// RVA: 0x000229DB File Offset: 0x00020BDB
		internal void method_28()
		{
			this.Text = (this.method_26() ?? string.Empty);
			if (this.bool_2)
			{
				this.bool_1 = true;
			}
			this.vmethod_3();
		}

		// Token: 0x06002DDA RID: 11738
		// RVA: 0x00129BF0 File Offset: 0x00127DF0
		protected override void vmethod_0(object sender, EventArgs e)
		{
			if (this.bool_2)
			{
				if (!this.bool_1)
				{
					if (this.textInputControl_0.Text.Length == 0)
					{
						this.bool_1 = true;
						this.textInputControl_0.Text = this.string_1;
					}
				}
				else if (this.textInputControl_0.Text.Length < this.string_1.Length)
				{
					this.bool_1 = true;
					this.textInputControl_0.Text = this.string_1;
				}
				else
				{
					string text = this.textInputControl_0.Text.Replace(this.string_1, "");
					if (text.Length > 0 && text != this.textInputControl_0.Text)
					{
						this.bool_1 = false;
						this.textInputControl_0.Text = text;
					}
				}
			}
			base.vmethod_0(sender, e);
		}

		// Token: 0x06002DD7 RID: 11735
		// RVA: 0x00129AAC File Offset: 0x00127CAC
		internal override bool vmethod_1(object object_0, Keys keys_0, bool bool_8)
		{
			if (this.textInputControl_0.TextBox.bool_0 || (this.textInputControl_0.TextBox.int_0 > 0 && Class115.int_1 - this.textInputControl_0.TextBox.int_0 < Class111.int_1))
			{
				return true;
			}
			if (!base.method_0())
			{
				return false;
			}
			if (Class570.bool_0)
			{
				switch (keys_0)
				{
				case 37:
				case 39:
					return this.method_22();
				case 38:
					break;
				default:
					switch (keys_0)
					{
					case 65:
						return this.Text.Length > 0;
					case 66:
						return false;
					case 67:
						break;
					default:
						switch (keys_0)
						{
						case 86:
							return true;
						case 87:
							return false;
						case 88:
							break;
						default:
							return false;
						}
						break;
					}
					return this.textInputControl_0.TextBox.SelectionLength > 0;
				}
			}
			return false;
		}

		// Token: 0x06002DD9 RID: 11737
		// RVA: 0x00129B84 File Offset: 0x00127D84
		internal override void vmethod_3()
		{
			int length = this.textInputControl_0.TextBox.Text.Length;
			if (!this.method_22() && this.textInputControl_0.TextBox.SelectionStart != length)
			{
				this.textInputControl_0.TextBox.SelectionStart = this.textInputControl_0.TextBox.Text.Length;
			}
			base.vmethod_3();
		}

		// Token: 0x06002DD8 RID: 11736
		// RVA: 0x00022989 File Offset: 0x00020B89
		protected override void vmethod_4(bool bool_8)
		{
			if (!this.method_24())
			{
				base.vmethod_4(bool_8);
				return;
			}
			base.method_5(bool_8);
		}

		// Token: 0x06002DD5 RID: 11733
		// RVA: 0x00022981 File Offset: 0x00020B81
		public override bool vmethod_5()
		{
			return base.vmethod_5();
		}

		// Token: 0x06002DD6 RID: 11734
		// RVA: 0x00129A80 File Offset: 0x00127C80
		public override void vmethod_6(bool bool_8)
		{
			if (this.vmethod_5() == bool_8)
			{
				return;
			}
			base.vmethod_6(bool_8);
			if (bool_8)
			{
				base.method_19(true);
			}
		}
	}
}
