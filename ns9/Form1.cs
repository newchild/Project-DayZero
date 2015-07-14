using Microsoft.Xna.Framework;
using ns8;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ns9
{
	// Token: 0x020001CC RID: 460
	internal sealed class Form1 : Form0
	{
		// Token: 0x04000C61 RID: 3169
		private bool bool_1;

		// Token: 0x04000C73 RID: 3187
		private bool bool_10;

		// Token: 0x04000C62 RID: 3170
		private bool bool_2 = true;

		// Token: 0x04000C63 RID: 3171
		private bool bool_3;

		// Token: 0x04000C65 RID: 3173
		private bool bool_4 = true;

		// Token: 0x04000C66 RID: 3174
		private bool bool_5;

		// Token: 0x04000C67 RID: 3175
		private bool bool_6;

		// Token: 0x04000C68 RID: 3176
		private bool bool_7;

		// Token: 0x04000C69 RID: 3177
		private bool bool_8 = true;

		// Token: 0x04000C6B RID: 3179
		private bool bool_9;

		// Token: 0x04000C7A RID: 3194
		private Delegate4 delegate4_0;

		// Token: 0x04000C74 RID: 3188
		private EventHandler eventHandler_0;

		// Token: 0x04000C75 RID: 3189
		private EventHandler eventHandler_1;

		// Token: 0x04000C76 RID: 3190
		private EventHandler eventHandler_2;

		// Token: 0x04000C77 RID: 3191
		private EventHandler eventHandler_3;

		// Token: 0x04000C78 RID: 3192
		private EventHandler eventHandler_4;

		// Token: 0x04000C79 RID: 3193
		private EventHandler eventHandler_5;

		// Token: 0x04000C6E RID: 3182
		private FormBorderStyle formBorderStyle_0;

		// Token: 0x04000C6C RID: 3180
		private FormWindowState formWindowState_0;

		// Token: 0x04000C70 RID: 3184
		private FormWindowState formWindowState_1;

		// Token: 0x04000C64 RID: 3172
		private bool? nullable_0;

		// Token: 0x04000C6D RID: 3181
		private Rectangle rectangle_0;

		// Token: 0x04000C6F RID: 3183
		private Rectangle rectangle_1;

		// Token: 0x04000C71 RID: 3185
		private Screen screen_0;

		// Token: 0x04000C6A RID: 3178
		private Size size_0;

		// Token: 0x04000C72 RID: 3186
		private Size size_1 = Size.Empty;

		// Token: 0x06001045 RID: 4165
		// RVA: 0x00055CD8 File Offset: 0x00053ED8
		public Form1()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CausesValidation = false;
			base.ClientSize = new Size(292, 266);
			base.ResizeBegin += new EventHandler(this.Form1_ResizeBegin);
			base.ClientSizeChanged += new EventHandler(this.Form1_ClientSizeChanged);
			base.Resize += new EventHandler(this.Form1_Resize);
			base.LocationChanged += new EventHandler(this.Form1_LocationChanged);
			base.ResizeEnd += new EventHandler(this.Form1_ResizeEnd);
			base.MouseEnter += new EventHandler(this.Form1_MouseEnter);
			base.MouseLeave += new EventHandler(this.Form1_MouseLeave);
			base.ResumeLayout(false);
			try
			{
				this.bool_5 = true;
				this.formWindowState_0 = base.WindowState;
				this.screen_0 = Class122.smethod_5(base.Handle);
				base.SetStyle(ControlStyles.Opaque | ControlStyles.AllPaintingInWmPaint, false);
				base.ClientSize = new Size(Class121.int_1, Class121.int_0);
				this.method_14();
			}
			finally
			{
				this.bool_5 = false;
			}
		}

		// Token: 0x06001047 RID: 4167
		// RVA: 0x0000FEBA File Offset: 0x0000E0BA
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001049 RID: 4169
		// RVA: 0x0000FEC3 File Offset: 0x0000E0C3
		private void Form1_ClientSizeChanged(object sender, EventArgs e)
		{
			this.method_15();
		}

		// Token: 0x0600104A RID: 4170
		// RVA: 0x0000FECB File Offset: 0x0000E0CB
		private void Form1_LocationChanged(object sender, EventArgs e)
		{
			if (this.bool_10)
			{
				this.bool_2 = false;
			}
			this.method_15();
		}

		// Token: 0x0600104B RID: 4171
		// RVA: 0x0000FEE2 File Offset: 0x0000E0E2
		private void Form1_MouseEnter(object sender, EventArgs e)
		{
			if (!this.bool_8 && !this.bool_6)
			{
				this.bool_6 = true;
			}
		}

		// Token: 0x0600104C RID: 4172
		// RVA: 0x0000FEFB File Offset: 0x0000E0FB
		private void Form1_MouseLeave(object sender, EventArgs e)
		{
			if (this.bool_6)
			{
				this.bool_6 = false;
			}
		}

		// Token: 0x0600104D RID: 4173
		// RVA: 0x000560B4 File Offset: 0x000542B4
		private void Form1_Resize(object sender, EventArgs e)
		{
			if (this.formWindowState_0 != base.WindowState)
			{
				this.formWindowState_0 = base.WindowState;
				this.bool_4 = true;
				this.method_12(false);
				base.Invalidate();
			}
			if (this.bool_10 && base.ClientSize != this.size_1)
			{
				base.Invalidate();
			}
		}

		// Token: 0x0600104E RID: 4174
		// RVA: 0x0000FF0C File Offset: 0x0000E10C
		private void Form1_ResizeBegin(object sender, EventArgs e)
		{
			this.size_1 = base.ClientSize;
			this.bool_10 = true;
			this.method_11();
		}

		// Token: 0x0600104F RID: 4175
		// RVA: 0x0000FF27 File Offset: 0x0000E127
		private void Form1_ResizeEnd(object sender, EventArgs e)
		{
			this.bool_10 = false;
			if (base.ClientSize != this.size_1)
			{
				this.bool_2 = false;
				this.method_12(false);
			}
			this.bool_4 = true;
			this.method_9();
		}

		// Token: 0x0600103F RID: 4159
		// RVA: 0x00055B88 File Offset: 0x00053D88
		internal void method_0(EventHandler eventHandler_6)
		{
			EventHandler eventHandler = this.eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_6);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06001040 RID: 4160
		// RVA: 0x00055BC0 File Offset: 0x00053DC0
		internal void method_1(EventHandler eventHandler_6)
		{
			EventHandler eventHandler = this.eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_6);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06001053 RID: 4179
		// RVA: 0x0000FF91 File Offset: 0x0000E191
		private void method_10()
		{
			if (this.eventHandler_3 != null)
			{
				this.eventHandler_3(this, EventArgs.Empty);
			}
		}

		// Token: 0x06001054 RID: 4180
		// RVA: 0x0000FFAC File Offset: 0x0000E1AC
		private void method_11()
		{
			if (this.eventHandler_4 != null)
			{
				this.eventHandler_4(this, EventArgs.Empty);
			}
		}

		// Token: 0x06001055 RID: 4181
		// RVA: 0x0000FFC7 File Offset: 0x0000E1C7
		private void method_12(bool bool_11)
		{
			if ((!this.bool_5 || bool_11) && this.eventHandler_5 != null)
			{
				this.eventHandler_5(this, EventArgs.Empty);
			}
		}

		// Token: 0x06001056 RID: 4182
		// RVA: 0x00056178 File Offset: 0x00054378
		private void method_13(string string_0, int int_0, int int_1, bool bool_11)
		{
			Screen screen = Class122.smethod_4(string_0);
			Rectangle bounds = Screen.GetBounds(new Point(screen.Bounds.X, screen.Bounds.Y));
			int x;
			int y;
			if (string_0 != Class122.smethod_0(this.method_17()))
			{
				x = bounds.X;
				y = bounds.Y;
			}
			else
			{
				x = this.screen_0.Bounds.X;
				y = this.screen_0.Bounds.Y;
			}
			if (this.bool_7)
			{
				Size size = this.SizeFromClientSize(new Size(int_0, int_1));
				if (this.formWindowState_1 == FormWindowState.Maximized)
				{
					int x2 = this.rectangle_1.X - this.screen_0.Bounds.X + x;
					int y2 = this.rectangle_1.Y - this.screen_0.Bounds.Y + y;
					this.SetBoundsCore(x2, y2, this.rectangle_1.Width, this.rectangle_1.Height, BoundsSpecified.All);
				}
				else if (bool_11)
				{
					int x3 = x + bounds.Width / 2 - size.Width / 2;
					int y3 = y + bounds.Height / 2 - size.Height / 2;
					this.SetBoundsCore(x3, y3, size.Width, size.Height, BoundsSpecified.All);
				}
				else
				{
					int x4 = this.rectangle_0.X - this.screen_0.Bounds.X + x;
					int y4 = this.rectangle_0.Y - this.screen_0.Bounds.Y + y;
					this.SetBoundsCore(x4, y4, size.Width, size.Height, BoundsSpecified.All);
				}
				base.WindowState = this.formWindowState_1;
				this.bool_7 = false;
				return;
			}
			if (base.WindowState == FormWindowState.Normal)
			{
				int num;
				int num2;
				if (bool_11)
				{
					Size size2 = this.SizeFromClientSize(new Size(int_0, int_1));
					num = x + bounds.Width / 2 - size2.Width / 2;
					num2 = y + bounds.Height / 2 - size2.Height / 2;
				}
				else
				{
					num = x + base.Bounds.X - this.screen_0.Bounds.X;
					num2 = y + base.Bounds.Y - this.screen_0.Bounds.Y;
				}
				if (num != base.Location.X || num2 != base.Location.Y)
				{
					base.Location = new Point(num, num2);
				}
				if (base.ClientSize.Width != int_0 || base.ClientSize.Height != int_1)
				{
					base.ClientSize = new Size(int_0, int_1);
				}
			}
		}

		// Token: 0x06001057 RID: 4183
		// RVA: 0x0000FFED File Offset: 0x0000E1ED
		private void method_14()
		{
			if (!this.bool_1)
			{
				if (!this.bool_7)
				{
					base.FormBorderStyle = FormBorderStyle.FixedSingle;
					return;
				}
			}
			else if (!this.bool_7)
			{
				base.FormBorderStyle = FormBorderStyle.Sizable;
			}
		}

		// Token: 0x06001058 RID: 4184
		// RVA: 0x00056460 File Offset: 0x00054660
		private void method_15()
		{
			if (!this.bool_5)
			{
				Screen obj = Screen.FromHandle(base.Handle);
				if (this.screen_0 == null || !this.screen_0.Equals(obj))
				{
					this.screen_0 = obj;
					if (this.screen_0 != null)
					{
						this.method_10();
					}
				}
			}
		}

		// Token: 0x0600105A RID: 4186
		// RVA: 0x00056524 File Offset: 0x00054724
		internal Rectangle method_16()
		{
			Point point = base.PointToScreen(Point.Empty);
			return new Rectangle(point.X, point.Y, base.ClientSize.Width, base.ClientSize.Height);
		}

		// Token: 0x0600105B RID: 4187
		// RVA: 0x00010016 File Offset: 0x0000E216
		internal Screen method_17()
		{
			return this.screen_0;
		}

		// Token: 0x0600105C RID: 4188
		// RVA: 0x0005656C File Offset: 0x0005476C
		public bool method_18()
		{
			return base.ClientSize.Width == 0 || base.ClientSize.Height == 0;
		}

		// Token: 0x0600105D RID: 4189
		// RVA: 0x0001001E File Offset: 0x0000E21E
		internal void method_19(bool bool_11)
		{
			if (this.bool_8 != bool_11)
			{
				this.bool_8 = bool_11;
				if (this.bool_8)
				{
					if (this.bool_6)
					{
						this.bool_6 = false;
						return;
					}
				}
				else if (!this.bool_6)
				{
					this.bool_6 = true;
				}
			}
		}

		// Token: 0x06001041 RID: 4161
		// RVA: 0x00055BF8 File Offset: 0x00053DF8
		internal void method_2(EventHandler eventHandler_6)
		{
			EventHandler eventHandler = this.eventHandler_2;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_6);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06001042 RID: 4162
		// RVA: 0x00055C30 File Offset: 0x00053E30
		internal void method_3(EventHandler eventHandler_6)
		{
			EventHandler eventHandler = this.eventHandler_3;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_6);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_3, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06001043 RID: 4163
		// RVA: 0x00055C68 File Offset: 0x00053E68
		internal void method_4(EventHandler eventHandler_6)
		{
			EventHandler eventHandler = this.eventHandler_4;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_6);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_4, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06001044 RID: 4164
		// RVA: 0x00055CA0 File Offset: 0x00053EA0
		internal void method_5(EventHandler eventHandler_6)
		{
			EventHandler eventHandler = this.eventHandler_5;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_6);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_5, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06001046 RID: 4166
		// RVA: 0x00055E34 File Offset: 0x00054034
		internal void method_6(bool bool_11)
		{
			this.size_0 = base.ClientSize;
			if (bool_11 && !this.bool_7)
			{
				this.formBorderStyle_0 = base.FormBorderStyle;
				this.formWindowState_1 = base.WindowState;
				this.rectangle_0 = base.Bounds;
				if (base.WindowState == FormWindowState.Maximized)
				{
					this.rectangle_1 = base.RestoreBounds;
				}
			}
			if (bool_11 != this.bool_7)
			{
				this.bool_3 = true;
				this.bool_9 = base.Visible;
				base.Visible = false;
			}
			else
			{
				this.bool_3 = false;
			}
			if (!bool_11 && this.bool_7)
			{
				base.TopMost = false;
				base.FormBorderStyle = this.formBorderStyle_0;
				if (this.formWindowState_1 == FormWindowState.Maximized)
				{
					this.SetBoundsCore(this.screen_0.Bounds.X, this.screen_0.Bounds.Y, this.rectangle_1.Width, this.rectangle_1.Height, BoundsSpecified.Size);
				}
				else
				{
					this.SetBoundsCore(this.screen_0.Bounds.X, this.screen_0.Bounds.Y, this.rectangle_0.Width, this.rectangle_0.Height, BoundsSpecified.Size);
				}
			}
			if (bool_11 != this.bool_7)
			{
				base.SendToBack();
			}
			this.nullable_0 = new bool?(bool_11);
		}

		// Token: 0x06001048 RID: 4168
		// RVA: 0x00055F90 File Offset: 0x00054190
		internal void method_7(string string_0, int int_0, int int_1)
		{
			if (!this.nullable_0.HasValue)
			{
				throw new InvalidOperationException(Class127.smethod_10());
			}
			bool flag = false;
			if (this.nullable_0.Value)
			{
				Screen screen = Class122.smethod_4(string_0);
				Rectangle bounds = Screen.GetBounds(new Point(screen.Bounds.X, screen.Bounds.Y));
				if (!this.bool_7)
				{
					flag = true;
					base.TopMost = true;
					base.FormBorderStyle = FormBorderStyle.None;
					base.WindowState = FormWindowState.Normal;
					base.BringToFront();
				}
				base.Location = new Point(bounds.X, bounds.Y);
				base.ClientSize = new Size(bounds.Width, bounds.Height);
				this.bool_7 = true;
			}
			else
			{
				if (this.bool_7)
				{
					flag = true;
					base.BringToFront();
				}
				this.method_13(string_0, int_0, int_1, this.bool_2);
			}
			if (this.bool_3)
			{
				base.Visible = this.bool_9;
			}
			if (flag && this.size_0 != base.ClientSize)
			{
				this.method_12(true);
			}
			this.nullable_0 = null;
		}

		// Token: 0x06001050 RID: 4176
		// RVA: 0x00056110 File Offset: 0x00054310
		private void method_8(bool bool_11)
		{
			if (bool_11)
			{
				this.bool_4 = true;
				this.bool_5 = false;
				if (this.bool_7)
				{
					base.TopMost = true;
				}
				if (this.eventHandler_0 != null)
				{
					this.eventHandler_0(this, EventArgs.Empty);
					return;
				}
			}
			else
			{
				if (this.eventHandler_1 != null)
				{
					this.eventHandler_1(this, EventArgs.Empty);
				}
				this.bool_5 = true;
			}
		}

		// Token: 0x06001052 RID: 4178
		// RVA: 0x0000FF76 File Offset: 0x0000E176
		private void method_9()
		{
			if (this.eventHandler_2 != null)
			{
				this.eventHandler_2(this, EventArgs.Empty);
			}
		}

		// Token: 0x06001051 RID: 4177
		// RVA: 0x0000FF5E File Offset: 0x0000E15E
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			if (this.bool_4)
			{
				base.OnPaintBackground(e);
				this.bool_4 = false;
			}
		}

		// Token: 0x06001059 RID: 4185
		// RVA: 0x000564AC File Offset: 0x000546AC
		protected override void WndProc(ref Message m)
		{
			if (m.Msg == 28)
			{
				bool bool_ = m.WParam != IntPtr.Zero;
				this.method_8(bool_);
			}
			if (this.delegate4_0 != null)
			{
				this.delegate4_0(ref m);
			}
			if (m.Result.ToInt32() < 0)
			{
				m.Result = new IntPtr(-m.Result.ToInt32() - 1);
				return;
			}
			base.WndProc(ref m);
		}
	}
}
