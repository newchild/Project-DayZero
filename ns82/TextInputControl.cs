using ns27;
using ns29;
using ns8;
using osu_common.Helpers;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace ns82
{
	// Token: 0x02000612 RID: 1554
	internal class TextInputControl : UserControl
	{
		// Token: 0x02000613 RID: 1555
		[CompilerGenerated]
		private sealed class Class807
		{
			// Token: 0x04002BE6 RID: 11238
			public bool bool_0;

			// Token: 0x04002BE5 RID: 11237
			public TextInputControl textInputControl_0;

			// Token: 0x0600302D RID: 12333
			// RVA: 0x00023BE1 File Offset: 0x00021DE1
			public void method_0()
			{
				this.textInputControl_0.TextBox.ReadOnly = !this.bool_0;
				if (this.bool_0)
				{
					Class802.smethod_25(this.textInputControl_0);
					return;
				}
				Class802.smethod_26(this.textInputControl_0);
			}
		}

		// Token: 0x04002BE2 RID: 11234
		internal bool bool_0;

		// Token: 0x04002BE1 RID: 11233
		internal Class754 class754_0;

		// Token: 0x04002BDC RID: 11228
		private Delegate0 delegate0_0;

		// Token: 0x04002BDB RID: 11227
		private EventHandler eventHandler_0;

		// Token: 0x04002BE3 RID: 11235
		private IContainer icontainer_0;

		// Token: 0x04002BE0 RID: 11232
		private KeyEventHandler keyEventHandler_0;

		// Token: 0x04002BE4 RID: 11236
		internal Class799 TextBox;

		// Token: 0x04002BDD RID: 11229
		private VoidDelegate voidDelegate_0;

		// Token: 0x04002BDE RID: 11230
		private VoidDelegate voidDelegate_1;

		// Token: 0x04002BDF RID: 11231
		private VoidDelegate voidDelegate_2;

		// Token: 0x170003A8 RID: 936
		public override bool Focused
		{
			// Token: 0x06003019 RID: 12313
			// RVA: 0x00023B44 File Offset: 0x00021D44
			get
			{
				return base.Focused || this.TextBox.Focused;
			}
		}

		// Token: 0x170003A9 RID: 937
		public override string Text
		{
			// Token: 0x06003017 RID: 12311
			// RVA: 0x00023AFB File Offset: 0x00021CFB
			get
			{
				return this.TextBox.Text;
			}
			// Token: 0x06003018 RID: 12312
			// RVA: 0x00023B08 File Offset: 0x00021D08
			set
			{
				this.TextBox.Text = value;
				if (this.TextBox.Text.Length >= 1)
				{
					this.TextBox.SelectionStart = this.TextBox.Text.Length;
				}
			}
		}

		// Token: 0x06003013 RID: 12307
		// RVA: 0x001370C8 File Offset: 0x001352C8
		internal TextInputControl(Class754 class754_1)
		{
			this.InitializeComponent();
			this.class754_0 = class754_1;
			this.TextBox.Font = new Font("Aller Light", class754_1.class533_0.method_60() * 1.14f);
			this.method_2();
			this.TextBox.ReadOnly = true;
			this.TextBox.KeyDown += new KeyEventHandler(this.TextBox_KeyDown);
			this.TextBox.KeyUp += new KeyEventHandler(this.TextBox_KeyUp);
			this.TextBox.method_1(new Delegate0(this.method_1));
			this.TextBox.method_2(new Delegate1(this.method_0));
		}

		// Token: 0x0600302A RID: 12330
		// RVA: 0x00023BBC File Offset: 0x00021DBC
		protected override void Dispose(bool disposing)
		{
			Class802.smethod_26(this);
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600302B RID: 12331
		// RVA: 0x0013763C File Offset: 0x0013583C
		private void InitializeComponent()
		{
			this.TextBox = new Class799();
			base.SuspendLayout();
			this.TextBox.BorderStyle = BorderStyle.None;
			this.TextBox.CausesValidation = false;
			this.TextBox.Cursor = Cursors.Arrow;
			this.TextBox.Dock = DockStyle.Fill;
			this.TextBox.HideSelection = false;
			this.TextBox.Location = new Point(0, 0);
			this.TextBox.Name = "TextBox";
			this.TextBox.Size = new Size(227, 20);
			this.TextBox.TabIndex = 0;
			this.TextBox.TabStop = false;
			this.TextBox.WordWrap = false;
			this.TextBox.TextChanged += new EventHandler(this.TextBox_TextChanged);
			this.TextBox.Leave += new EventHandler(this.TextBox_Leave);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CausesValidation = false;
			base.Controls.Add(this.TextBox);
			base.Location = new Point(0, 0);
			base.Name = "TextInputControl";
			base.Size = new Size(227, 20);
			base.PreviewKeyDown += new PreviewKeyDownEventHandler(this.TextInputControl_PreviewKeyDown);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003014 RID: 12308
		// RVA: 0x00023AB9 File Offset: 0x00021CB9
		private void method_0(bool bool_1)
		{
			if (bool_1)
			{
				if (this.voidDelegate_1 != null)
				{
					this.voidDelegate_1();
				}
				return;
			}
			if (this.voidDelegate_0 != null)
			{
				this.voidDelegate_0();
			}
		}

		// Token: 0x06003015 RID: 12309
		// RVA: 0x00023AE5 File Offset: 0x00021CE5
		private void method_1(string string_0)
		{
			if (this.delegate0_0 != null)
			{
				this.delegate0_0(string_0);
			}
		}

		// Token: 0x06003023 RID: 12323
		// RVA: 0x00137544 File Offset: 0x00135744
		internal void method_10(VoidDelegate voidDelegate_3)
		{
			VoidDelegate voidDelegate = this.voidDelegate_2;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Combine(voidDelegate2, voidDelegate_3);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref this.voidDelegate_2, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x06003028 RID: 12328
		// RVA: 0x001375CC File Offset: 0x001357CC
		public void method_11(KeyEventHandler keyEventHandler_1)
		{
			KeyEventHandler keyEventHandler = this.keyEventHandler_0;
			KeyEventHandler keyEventHandler2;
			do
			{
				keyEventHandler2 = keyEventHandler;
				KeyEventHandler value = (KeyEventHandler)Delegate.Combine(keyEventHandler2, keyEventHandler_1);
				keyEventHandler = Interlocked.CompareExchange<KeyEventHandler>(ref this.keyEventHandler_0, value, keyEventHandler2);
			}
			while (keyEventHandler != keyEventHandler2);
		}

		// Token: 0x06003029 RID: 12329
		// RVA: 0x00137604 File Offset: 0x00135804
		public void method_12(KeyEventHandler keyEventHandler_1)
		{
			KeyEventHandler keyEventHandler = this.keyEventHandler_0;
			KeyEventHandler keyEventHandler2;
			do
			{
				keyEventHandler2 = keyEventHandler;
				KeyEventHandler value = (KeyEventHandler)Delegate.Remove(keyEventHandler2, keyEventHandler_1);
				keyEventHandler = Interlocked.CompareExchange<KeyEventHandler>(ref this.keyEventHandler_0, value, keyEventHandler2);
			}
			while (keyEventHandler != keyEventHandler2);
		}

		// Token: 0x06003016 RID: 12310
		// RVA: 0x0013717C File Offset: 0x0013537C
		internal void method_2()
		{
			float num = this.class754_0.class533_0.vector2_9.X * Class115.float_4;
			base.Size = new Size((int)num, 0);
			base.Location = new Point((int)(this.class754_0.class533_0.method_28().X * Class115.float_4), (int)(this.class754_0.class533_0.method_28().Y * Class115.float_4) + 5000);
		}

		// Token: 0x0600301A RID: 12314
		// RVA: 0x00023B5B File Offset: 0x00021D5B
		internal bool method_3()
		{
			return !this.TextBox.ReadOnly;
		}

		// Token: 0x0600301B RID: 12315
		// RVA: 0x001371FC File Offset: 0x001353FC
		internal void method_4(bool bool_1)
		{
			TextInputControl.Class807 class = new TextInputControl.Class807();
			class.bool_0 = bool_1;
			class.textInputControl_0 = this;
			Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
		}

		// Token: 0x0600301E RID: 12318
		// RVA: 0x0013742C File Offset: 0x0013562C
		internal void method_5(EventHandler eventHandler_1)
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

		// Token: 0x0600301F RID: 12319
		// RVA: 0x00137464 File Offset: 0x00135664
		internal void method_6(EventHandler eventHandler_1)
		{
			EventHandler eventHandler = this.eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_1);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06003020 RID: 12320
		// RVA: 0x0013749C File Offset: 0x0013569C
		internal void method_7(Delegate0 delegate0_1)
		{
			Delegate0 delegate = this.delegate0_0;
			Delegate0 delegate2;
			do
			{
				delegate2 = delegate;
				Delegate0 value = (Delegate0)Delegate.Combine(delegate2, delegate0_1);
				delegate = Interlocked.CompareExchange<Delegate0>(ref this.delegate0_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06003021 RID: 12321
		// RVA: 0x001374D4 File Offset: 0x001356D4
		internal void method_8(VoidDelegate voidDelegate_3)
		{
			VoidDelegate voidDelegate = this.voidDelegate_0;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Combine(voidDelegate2, voidDelegate_3);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref this.voidDelegate_0, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x06003022 RID: 12322
		// RVA: 0x0013750C File Offset: 0x0013570C
		internal void method_9(VoidDelegate voidDelegate_3)
		{
			VoidDelegate voidDelegate = this.voidDelegate_1;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Combine(voidDelegate2, voidDelegate_3);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref this.voidDelegate_1, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x06003026 RID: 12326
		// RVA: 0x0013757C File Offset: 0x0013577C
		protected override void OnGotFocus(EventArgs e)
		{
			this.TextBox.Focus();
			if (this.TextBox.Text.Length >= 1)
			{
				this.TextBox.SelectionStart = this.TextBox.Text.Length;
			}
			base.OnGotFocus(e);
		}

		// Token: 0x0600301C RID: 12316
		// RVA: 0x00137234 File Offset: 0x00135434
		private void TextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (this.keyEventHandler_0 != null)
			{
				this.keyEventHandler_0(sender, e);
			}
			if (e.Control && e.Alt && e.KeyValue >= 48 && e.KeyValue <= 57)
			{
				return;
			}
			if (e.Control && e.KeyCode == Keys.Back)
			{
				if (this.Text.Length > 0 && this.TextBox.SelectionLength == 0)
				{
					int num = Math.Max(0, this.TextBox.SelectionStart);
					int num2 = num;
					while (num2 > 0 && char.IsWhiteSpace(this.Text[num2 - 1]))
					{
						num2--;
					}
					while (num2 > 0 && !char.IsWhiteSpace(this.Text[num2 - 1]))
					{
						num2--;
					}
					this.Text = this.Text.Remove(num2, num - num2);
					this.TextBox.SelectionStart = num2;
					this.class754_0.vmethod_3();
				}
				e.SuppressKeyPress = true;
				return;
			}
			if (e.Alt && !e.Control)
			{
				Keys keyCode = e.KeyCode;
				if (keyCode <= Keys.O)
				{
					switch (keyCode)
					{
					case Keys.D:
					case Keys.E:
					case Keys.F:
					case Keys.H:
						return;
					case Keys.G:
						break;
					default:
						if (keyCode == Keys.O)
						{
							return;
						}
						break;
					}
				}
				else
				{
					switch (keyCode)
					{
					case Keys.T:
					case Keys.V:
					case Keys.W:
						return;
					case Keys.U:
						break;
					default:
						if (keyCode == Keys.F4)
						{
							return;
						}
						break;
					}
				}
				e.SuppressKeyPress = true;
				return;
			}
			if (e.Shift && e.KeyCode == Keys.Delete)
			{
				e.SuppressKeyPress = true;
				return;
			}
			if (this.bool_0 && (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right))
			{
				e.SuppressKeyPress = true;
				return;
			}
			if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Escape || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F12 || e.KeyCode == Keys.F5)
			{
				e.SuppressKeyPress = true;
			}
		}

		// Token: 0x0600301D RID: 12317
		// RVA: 0x00023B6B File Offset: 0x00021D6B
		private void TextBox_KeyUp(object sender, KeyEventArgs e)
		{
			if (this.voidDelegate_2 != null)
			{
				this.voidDelegate_2();
			}
		}

		// Token: 0x06003025 RID: 12325
		// RVA: 0x00023B93 File Offset: 0x00021D93
		private void TextBox_Leave(object sender, EventArgs e)
		{
			Class802.smethod_27(true);
		}

		// Token: 0x06003027 RID: 12327
		// RVA: 0x00023B9C File Offset: 0x00021D9C
		private void TextBox_TextChanged(object sender, EventArgs e)
		{
			if (!this.method_3())
			{
				return;
			}
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(null, null);
			}
		}

		// Token: 0x06003024 RID: 12324
		// RVA: 0x00023B80 File Offset: 0x00021D80
		private void TextInputControl_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyData == Keys.Tab)
			{
				e.IsInputKey = false;
			}
		}
	}
}
