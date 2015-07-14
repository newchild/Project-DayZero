using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns29;
using ns6;
using ns79;
using ns8;
using ns81;
using ns82;
using ns84;
using osu;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace ns27
{
	// Token: 0x02000594 RID: 1428
	internal class Class754 : IDisposable
	{
		// Token: 0x02000595 RID: 1429
		// Token: 0x06002DCD RID: 11725
		internal delegate void Delegate37(Class754 class754_0, bool bool_0);

		// Token: 0x0400263E RID: 9790
		internal bool bool_0;

		// Token: 0x04002641 RID: 9793
		protected bool bool_1;

		// Token: 0x04002642 RID: 9794
		protected bool bool_2;

		// Token: 0x04002643 RID: 9795
		public bool bool_3;

		// Token: 0x04002650 RID: 9808
		internal bool bool_4 = true;

		// Token: 0x04002651 RID: 9809
		private bool bool_5;

		// Token: 0x04002652 RID: 9810
		[CompilerGenerated]
		private bool bool_6;

		// Token: 0x04002640 RID: 9792
		protected Class531 class531_0;

		// Token: 0x0400263A RID: 9786
		internal readonly Class533 class533_0;

		// Token: 0x0400264C RID: 9804
		internal Class533 class533_1;

		// Token: 0x0400263C RID: 9788
		internal Color color_0 = Color.get_White();

		// Token: 0x0400264E RID: 9806
		private Color color_1 = new Color(50, 50, 50, 200);

		// Token: 0x0400264F RID: 9807
		private Color color_2 = new Color(50, 50, 50, 80);

		// Token: 0x04002648 RID: 9800
		private Class754.Delegate37 delegate37_0;

		// Token: 0x04002649 RID: 9801
		private Class754.Delegate37 delegate37_1;

		// Token: 0x0400264A RID: 9802
		private Class754.Delegate37 delegate37_2;

		// Token: 0x04002646 RID: 9798
		internal float float_0;

		// Token: 0x0400264B RID: 9803
		private float float_1;

		// Token: 0x0400263D RID: 9789
		internal int int_0;

		// Token: 0x04002644 RID: 9796
		private int int_1;

		// Token: 0x04002645 RID: 9797
		private int int_2;

		// Token: 0x0400264D RID: 9805
		internal int int_3 = 2;

		// Token: 0x04002653 RID: 9811
		[CompilerGenerated]
		private int int_4;

		// Token: 0x0400263B RID: 9787
		internal List<Class531> list_0 = new List<Class531>();

		// Token: 0x0400263F RID: 9791
		internal string string_0;

		// Token: 0x04002647 RID: 9799
		internal TextInputControl textInputControl_0;

		// Token: 0x170003A1 RID: 929
		internal virtual string Text
		{
			// Token: 0x06002DC5 RID: 11717
			// RVA: 0x0012998C File Offset: 0x00127B8C
			get
			{
				Control1 control = this.textInputControl_0 as Control1;
				if (control == null)
				{
					return this.class533_0.Text;
				}
				return control.method_14();
			}
			// Token: 0x06002DC6 RID: 11718
			// RVA: 0x000228B1 File Offset: 0x00020AB1
			set
			{
				if (value == this.class533_0.Text)
				{
					return;
				}
				this.textInputControl_0.Text = value;
				this.class533_0.Text = this.textInputControl_0.Text;
				this.method_12();
			}
		}

		// Token: 0x06002DB1 RID: 11697
		// RVA: 0x00128FE8 File Offset: 0x001271E8
		public Class754(string string_1, int int_5, Vector2 vector2_0, float float_2, float float_3, bool bool_7)
		{
			this.method_8(int_5);
			this.float_1 = float_2;
			this.class533_0 = new Class533(string.Empty, (float)int_5, vector2_0, new Vector2(float_2, 0f), float_3, true, Color.get_White(), false);
			this.class533_0.bool_16 = true;
			this.class533_0.method_53(this.color_2);
			this.class533_0.method_57(Color.get_White());
			this.class533_0.enum72_0 = Enum72.const_1;
			this.class533_0.bool_1 = true;
			this.class533_0.bool_2 = true;
			this.class533_0.method_55(new Color(180, 180, 180));
			this.class533_0.int_7 = 2;
			this.class531_0 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, vector2_0, float_3 + 0.001f, true, Color.get_TransparentWhite(), null);
			this.class531_0.vector2_2 = new Vector2(2f, (float)int_5 * 1.5f);
			this.class531_0.method_8(true);
			Class531 expr_15D_cp_0 = this.class531_0;
			expr_15D_cp_0.vector2_1.Y = expr_15D_cp_0.vector2_1.Y + (float)this.int_3;
			this.list_0.Add(this.class531_0);
			if (bool_7)
			{
				this.textInputControl_0 = new Control1(this);
			}
			else
			{
				this.textInputControl_0 = new TextInputControl(this);
			}
			this.textInputControl_0.method_7(new Delegate0(this.method_11));
			this.textInputControl_0.method_9(new VoidDelegate(this.method_9));
			this.textInputControl_0.method_8(new VoidDelegate(this.method_10));
			this.class533_1 = new Class533(string.Empty, (float)int_5, this.class531_0.vector2_1, float_3 + 0.002f, true, Color.get_PaleVioletRed());
			this.list_0.Add(this.class533_1);
			this.bool_5 = true;
			this.textInputControl_0.class754_0 = this;
			this.class533_0.method_2(new EventHandler(this.method_14));
			Class802.smethod_34(Enum96.const_8, new Delegate46(this.method_16), Enum98.const_8, Enum97.const_2);
			this.textInputControl_0.method_5(new EventHandler(this.vmethod_0));
			this.textInputControl_0.method_11(new KeyEventHandler(this.vmethod_2));
			this.list_0.Add(this.class533_0);
			this.Text = string_1;
		}

		// Token: 0x06002DB6 RID: 11702
		// RVA: 0x00129334 File Offset: 0x00127534
		public void Dispose()
		{
			this.delegate37_1 = null;
			this.delegate37_2 = null;
			this.delegate37_0 = null;
			Class115.form_0.Controls.Remove(this.textInputControl_0);
			this.textInputControl_0.Dispose();
			GC.SuppressFinalize(this);
			this.Dispose(false);
		}

		// Token: 0x06002DB7 RID: 11703
		// RVA: 0x00129384 File Offset: 0x00127584
		private void Dispose(bool bool_7)
		{
			Class802.smethod_35(Enum96.const_8, new Delegate46(this.method_16), Enum98.const_8);
			this.textInputControl_0.method_6(new EventHandler(this.vmethod_0));
			this.textInputControl_0.method_12(new KeyEventHandler(this.vmethod_2));
			if (Class115.osuModes_1 != OsuModes.Exit)
			{
				this.vmethod_4(false);
			}
		}

		// Token: 0x06002DB5 RID: 11701
		// RVA: 0x00129304 File Offset: 0x00127504
		~Class754()
		{
			this.Dispose(true);
		}

		// Token: 0x06002DA8 RID: 11688
		// RVA: 0x000227AE File Offset: 0x000209AE
		[CompilerGenerated]
		internal bool method_0()
		{
			return this.bool_6;
		}

		// Token: 0x06002DA9 RID: 11689
		// RVA: 0x000227B6 File Offset: 0x000209B6
		[CompilerGenerated]
		private void method_1(bool bool_7)
		{
			this.bool_6 = bool_7;
		}

		// Token: 0x06002DB3 RID: 11699
		// RVA: 0x000227C8 File Offset: 0x000209C8
		private void method_10()
		{
			this.method_13();
		}

		// Token: 0x06002DB4 RID: 11700
		// RVA: 0x0012929C File Offset: 0x0012749C
		private void method_11(string string_1)
		{
			this.method_13();
			this.class533_1.vector2_1 = this.class531_0.vector2_1;
			Class533 expr_27_cp_0 = this.class533_1;
			expr_27_cp_0.vector2_1.Y = expr_27_cp_0.vector2_1.Y - (float)this.int_3;
			this.class533_1.method_40(Color.get_White(), 200);
			this.class533_1.Text = string_1;
		}

		// Token: 0x06002DB9 RID: 11705
		// RVA: 0x001294D0 File Offset: 0x001276D0
		private void method_12()
		{
			float y = (this.float_0 > this.method_21().Y) ? this.float_0 : (this.method_0() ? this.float_0 : this.method_21().Y);
			this.class533_0.vector2_9.Y = y;
			this.class533_0.bool_18 = true;
			this.method_6(false);
		}

		// Token: 0x06002DBA RID: 11706
		// RVA: 0x000227D0 File Offset: 0x000209D0
		private void method_13()
		{
			this.class533_1.Text = string.Empty;
		}

		// Token: 0x06002DBE RID: 11710
		// RVA: 0x00022805 File Offset: 0x00020A05
		private void method_14(object sender, EventArgs e)
		{
			if (this.bool_3)
			{
				return;
			}
			Class115.class47_0.Add(new VoidDelegate(this.method_15), true);
		}

		// Token: 0x06002DBF RID: 11711
		// RVA: 0x00129800 File Offset: 0x00127A00
		private void method_15()
		{
			if (this.bool_3)
			{
				return;
			}
			if (!this.method_0())
			{
				this.string_0 = this.class533_0.Text;
				if (this.bool_0)
				{
					this.class533_0.Text = string.Empty;
				}
				this.method_1(true);
				this.class533_0.method_55(this.color_0);
				this.class533_0.method_53(this.color_1);
				this.textInputControl_0.Text = this.class533_0.Text;
				this.textInputControl_0.method_4(true);
				this.class531_0.class26_0.Clear();
				this.class531_0.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0.4f, Class115.int_1, Class115.int_1 + 1000, Enum70.const_0)
				{
					enum70_0 = Enum70.const_1,
					bool_0 = true
				});
				this.int_1 = -1;
				this.method_7();
				this.vmethod_3();
				this.method_12();
			}
		}

		// Token: 0x06002DC0 RID: 11712
		// RVA: 0x00022827 File Offset: 0x00020A27
		private bool method_16(object object_0, EventArgs eventArgs_0)
		{
			if (this.method_0() && !this.bool_3 && Class800.bool_4)
			{
				if (!this.class533_0.rectangleF_0.Contains(Class800.smethod_15()))
				{
					this.vmethod_4(this.bool_4);
				}
				return false;
			}
			return false;
		}

		// Token: 0x06002DC1 RID: 11713
		// RVA: 0x00022866 File Offset: 0x00020A66
		internal void method_17(Color color_3)
		{
			this.color_1 = color_3;
			if (this.method_0())
			{
				this.class533_0.method_53(color_3);
			}
		}

		// Token: 0x06002DC2 RID: 11714
		// RVA: 0x00022883 File Offset: 0x00020A83
		internal void method_18(Color color_3)
		{
			this.color_2 = color_3;
			if (!this.method_0())
			{
				this.class533_0.method_53(color_3);
			}
		}

		// Token: 0x06002DC9 RID: 11721
		// RVA: 0x000228F7 File Offset: 0x00020AF7
		internal void method_19(bool bool_7)
		{
			if (bool_7)
			{
				this.method_1(false);
			}
			this.method_15();
		}

		// Token: 0x06002DAA RID: 11690
		// RVA: 0x00128EE0 File Offset: 0x001270E0
		internal void method_2(Class754.Delegate37 delegate37_3)
		{
			Class754.Delegate37 delegate = this.delegate37_0;
			Class754.Delegate37 delegate2;
			do
			{
				delegate2 = delegate;
				Class754.Delegate37 value = (Class754.Delegate37)Delegate.Combine(delegate2, delegate37_3);
				delegate = Interlocked.CompareExchange<Class754.Delegate37>(ref this.delegate37_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06002DCA RID: 11722
		// RVA: 0x00022909 File Offset: 0x00020B09
		internal void method_20(bool bool_7)
		{
			if (bool_7)
			{
				this.method_1(true);
			}
			this.vmethod_4(false);
		}

		// Token: 0x06002DCB RID: 11723
		// RVA: 0x0002291C File Offset: 0x00020B1C
		public Vector2 method_21()
		{
			return this.class533_0.vmethod_11();
		}

		// Token: 0x06002DAB RID: 11691
		// RVA: 0x00128F18 File Offset: 0x00127118
		public void method_3(Class754.Delegate37 delegate37_3)
		{
			Class754.Delegate37 delegate = this.delegate37_1;
			Class754.Delegate37 delegate2;
			do
			{
				delegate2 = delegate;
				Class754.Delegate37 value = (Class754.Delegate37)Delegate.Combine(delegate2, delegate37_3);
				delegate = Interlocked.CompareExchange<Class754.Delegate37>(ref this.delegate37_1, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06002DAC RID: 11692
		// RVA: 0x00128F50 File Offset: 0x00127150
		public void method_4(Class754.Delegate37 delegate37_3)
		{
			Class754.Delegate37 delegate = this.delegate37_2;
			Class754.Delegate37 delegate2;
			do
			{
				delegate2 = delegate;
				Class754.Delegate37 value = (Class754.Delegate37)Delegate.Combine(delegate2, delegate37_3);
				delegate = Interlocked.CompareExchange<Class754.Delegate37>(ref this.delegate37_2, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06002DAD RID: 11693
		// RVA: 0x00128F88 File Offset: 0x00127188
		protected void method_5(bool bool_7)
		{
			Class754.Delegate37 delegate = this.delegate37_0;
			if (delegate != null)
			{
				delegate(this, bool_7);
			}
		}

		// Token: 0x06002DAE RID: 11694
		// RVA: 0x00128FA8 File Offset: 0x001271A8
		private void method_6(bool bool_7)
		{
			Class754.Delegate37 delegate = this.delegate37_1;
			if (delegate != null)
			{
				delegate(this, bool_7);
			}
		}

		// Token: 0x06002DAF RID: 11695
		// RVA: 0x00128FC8 File Offset: 0x001271C8
		private void method_7()
		{
			Class754.Delegate37 delegate = this.delegate37_2;
			if (delegate != null)
			{
				delegate(this, false);
			}
		}

		// Token: 0x06002DB0 RID: 11696
		// RVA: 0x000227BF File Offset: 0x000209BF
		[CompilerGenerated]
		private void method_8(int int_5)
		{
			this.int_4 = int_5;
		}

		// Token: 0x06002DB2 RID: 11698
		// RVA: 0x000227C8 File Offset: 0x000209C8
		private void method_9()
		{
			this.method_13();
		}

		// Token: 0x06002DC4 RID: 11716
		// RVA: 0x000228A0 File Offset: 0x00020AA0
		public void Select()
		{
			if (this.bool_3)
			{
				return;
			}
			this.method_15();
		}

		// Token: 0x06002DB8 RID: 11704
		// RVA: 0x001293E4 File Offset: 0x001275E4
		protected virtual void vmethod_0(object sender, EventArgs e)
		{
			if (this.bool_3)
			{
				return;
			}
			this.method_13();
			if (this.int_0 != 0 && this.textInputControl_0.Text.Length > this.int_0 && !this.bool_1)
			{
				this.textInputControl_0.Text = this.class533_0.Text;
				this.class533_0.method_55(Color.get_Red());
			}
			else
			{
				this.class533_0.method_57(this.bool_5 ? Color.get_White() : new Color(180, 180, 180));
				this.class533_0.Text = this.textInputControl_0.Text;
				this.class533_0.method_55(this.bool_5 ? this.color_0 : new Color(180, 180, 180));
				this.method_6(true);
			}
			this.method_12();
		}

		// Token: 0x06002DBB RID: 11707
		// RVA: 0x00129538 File Offset: 0x00127738
		internal virtual bool vmethod_1(object object_0, Keys keys_0, bool bool_7)
		{
			if (!this.textInputControl_0.TextBox.bool_0 && (this.textInputControl_0.TextBox.int_0 <= 0 || Class115.int_1 - this.textInputControl_0.TextBox.int_0 >= Class111.int_1))
			{
				if (this.method_0() && bool_7)
				{
					if (keys_0 != 13)
					{
						if (keys_0 != 27)
						{
							switch (keys_0)
							{
							case 119:
							case 120:
								break;
							default:
								if (Class570.bool_0)
								{
									switch (keys_0)
									{
									case 37:
									case 39:
										break;
									case 38:
										return false;
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
									return true;
								}
								return false;
							}
						}
						this.vmethod_4(false);
						return true;
					}
					this.vmethod_4(true);
					return true;
				}
				return false;
			}
			return true;
		}

		// Token: 0x06002DBC RID: 11708
		// RVA: 0x000227E2 File Offset: 0x000209E2
		protected virtual void vmethod_2(object sender, KeyEventArgs e)
		{
			if (!this.method_0())
			{
				return;
			}
			Class115.class47_0.Add(new VoidDelegate(this.vmethod_3), true);
		}

		// Token: 0x06002DBD RID: 11709
		// RVA: 0x00129648 File Offset: 0x00127848
		internal virtual void vmethod_3()
		{
			this.class531_0.method_8(!this.method_0() || (this.bool_2 && this.bool_1) || this.class533_0.Text.Length == this.int_0);
			int num = Math.Max(0, this.textInputControl_0.TextBox.SelectionStart);
			if (this.bool_2 && this.bool_1)
			{
				this.textInputControl_0.TextBox.SelectionStart = this.textInputControl_0.TextBox.Text.Length;
			}
			this.int_1 = this.int_2;
			this.int_2 = num;
			if (this.int_1 != this.int_2)
			{
				Vector2 vector = this.class533_0.method_66(0, Math.Min(this.class533_0.Text.Length, this.int_2));
				vector.X -= 3f;
				vector.Y -= 3f;
				int num2 = (int)Math.Max(0.0, Math.Floor((double)(vector.X / this.float_1)));
				Class531 expr_126 = this.class531_0;
				expr_126.method_8(expr_126.method_7() | num2 > 0);
				float num3 = (float)num2 * vector.Y;
				float val = vector.X - (float)(num2 * 6);
				this.class531_0.vector2_1 = this.class533_0.method_28();
				Class531 expr_170_cp_0 = this.class531_0;
				expr_170_cp_0.vector2_1.X = expr_170_cp_0.vector2_1.X + Math.Max(0f, val);
				Class531 expr_193_cp_0 = this.class531_0;
				expr_193_cp_0.vector2_1.Y = expr_193_cp_0.vector2_1.Y + ((float)this.int_3 + num3);
			}
		}

		// Token: 0x06002DC3 RID: 11715
		// RVA: 0x00129900 File Offset: 0x00127B00
		protected virtual void vmethod_4(bool bool_7)
		{
			if (this.bool_3)
			{
				return;
			}
			if (this.method_0())
			{
				this.method_1(false);
				this.class533_0.method_55(new Color(180, 180, 180));
				this.class533_0.method_53(this.color_2);
				this.textInputControl_0.method_4(false);
				this.class531_0.class26_0.Clear();
				this.class531_0.method_16(50, Enum70.const_0);
				this.method_5(bool_7);
				this.method_12();
			}
		}

		// Token: 0x06002DC7 RID: 11719
		// RVA: 0x000228EF File Offset: 0x00020AEF
		public virtual bool vmethod_5()
		{
			return this.bool_5;
		}

		// Token: 0x06002DC8 RID: 11720
		// RVA: 0x001299BC File Offset: 0x00127BBC
		public virtual void vmethod_6(bool bool_7)
		{
			if (this.bool_5 == bool_7)
			{
				return;
			}
			this.bool_5 = bool_7;
			this.class533_0.bool_1 = this.bool_5;
			this.class533_0.method_57(this.bool_5 ? Color.get_White() : new Color(180, 180, 180));
			if (this.method_0())
			{
				this.vmethod_4(this.bool_4);
			}
		}
	}
}
