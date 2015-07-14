using ns29;
using osu.Graphics.Sprites;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ns8
{
	// Token: 0x02000376 RID: 886
	internal class Form2 : Form0
	{
		// Token: 0x04001548 RID: 5448
		private EventHandler<EventArgs12> eventHandler_0;

		// Token: 0x04001549 RID: 5449
		private EventHandler eventHandler_1;

		// Token: 0x04001547 RID: 5447
		private Font font_0;

		// Token: 0x17000365 RID: 869
		public override Font Font
		{
			// Token: 0x06001ABE RID: 6846
			// RVA: 0x000846C4 File Offset: 0x000828C4
			get
			{
				try
				{
					if (this.font_0 != null)
					{
						return this.font_0;
					}
					if (Environment.OSVersion.Version.Major < 6)
					{
						Font dialogFont = SystemFonts.DialogFont;
						this.font_0 = new Font(dialogFont.Name, 8f, dialogFont.Style, GraphicsUnit.Point);
					}
					else
					{
						Font messageBoxFont = SystemFonts.MessageBoxFont;
						this.font_0 = new Font(messageBoxFont.Name, 9f, messageBoxFont.Style, GraphicsUnit.Point);
					}
				}
				catch
				{
					Font font = base.Font;
					this.font_0 = new Font(font.Name, 8f, font.Style, GraphicsUnit.Point);
				}
				return this.font_0;
			}
			// Token: 0x06001ABF RID: 6847
			// RVA: 0x000166D0 File Offset: 0x000148D0
			set
			{
				base.Font = value;
			}
		}

		// Token: 0x06001AC6 RID: 6854
		[DllImport("user32.dll")]
		private static extern bool GetCursorPos(ref Point point_0);

		// Token: 0x06001ABD RID: 6845
		// RVA: 0x00084688 File Offset: 0x00082888
		public void Invoke(MethodInvoker methodInvoker_0)
		{
			if (!base.IsDisposed && base.IsHandleCreated)
			{
				try
				{
					base.Invoke(methodInvoker_0);
				}
				catch
				{
				}
				return;
			}
		}

		// Token: 0x06001ABA RID: 6842
		// RVA: 0x00084590 File Offset: 0x00082790
		private void method_0()
		{
			Font font = this.Font;
			new Font(font.Name, 5f, font.Style, GraphicsUnit.Point);
			this.method_2(font, this);
		}

		// Token: 0x06001ABB RID: 6843
		// RVA: 0x000166B4 File Offset: 0x000148B4
		protected void method_1()
		{
			if (Class905.smethod_16())
			{
				return;
			}
			this.Invoke(new MethodInvoker(this.method_8));
		}

		// Token: 0x06001ABC RID: 6844
		// RVA: 0x000845C4 File Offset: 0x000827C4
		private void method_2(Font font_1, Control control_0)
		{
			Font font = new Font(font_1.Name, 5f, font_1.Style, GraphicsUnit.Point);
			foreach (Control control in control_0.Controls)
			{
				Font font2 = control.Font;
				string familyName = this.method_3(font2.Name) ? font_1.Name : font2.Name;
				control.Font = font;
				control.Font = new Font(familyName, font2.Size, font2.Style, font2.Unit);
				this.method_2(font_1, control);
			}
		}

		// Token: 0x06001AC0 RID: 6848
		// RVA: 0x00084780 File Offset: 0x00082980
		private bool method_3(string string_0)
		{
			string_0 = string_0.ToLowerInvariant();
			return string_0 == "system" || string_0 == "ms sans serif" || string_0 == "microsoft sans serif" || string_0 == "tahoma" || string_0 == "segoe ui";
		}

		// Token: 0x06001AC2 RID: 6850
		// RVA: 0x00084880 File Offset: 0x00082A80
		internal void method_4(EventHandler<EventArgs12> eventHandler_2)
		{
			EventHandler<EventArgs12> eventHandler = this.eventHandler_0;
			EventHandler<EventArgs12> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs12> value = (EventHandler<EventArgs12>)Delegate.Combine(eventHandler2, eventHandler_2);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs12>>(ref this.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06001AC3 RID: 6851
		// RVA: 0x000848B8 File Offset: 0x00082AB8
		internal void method_5(EventHandler eventHandler_2)
		{
			EventHandler eventHandler = this.eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_2);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06001AC4 RID: 6852
		// RVA: 0x000166D9 File Offset: 0x000148D9
		internal void method_6(Origins origins_0)
		{
			this.method_7(origins_0);
			base.Show();
		}

		// Token: 0x06001AC5 RID: 6853
		// RVA: 0x000848F0 File Offset: 0x00082AF0
		private void method_7(Origins origins_0)
		{
			Point point = Form2.smethod_0();
			switch (origins_0)
			{
			case Origins.TopLeft:
			case Origins.CentreLeft:
			case Origins.BottomLeft:
				base.Left = point.X;
				break;
			case Origins.Centre:
			case Origins.BottomCentre:
			case Origins.TopCentre:
				base.Left = point.X - base.Width / 2;
				break;
			case Origins.TopRight:
			case Origins.CentreRight:
			case Origins.BottomRight:
				base.Left = point.X - base.Width;
				break;
			}
			switch (origins_0)
			{
			case Origins.TopLeft:
			case Origins.TopRight:
			case Origins.TopCentre:
				base.Top = point.Y;
				return;
			case Origins.Centre:
			case Origins.CentreLeft:
			case Origins.CentreRight:
				base.Top = point.Y - base.Height / 2;
				return;
			case Origins.BottomCentre:
			case Origins.BottomLeft:
			case Origins.BottomRight:
				base.Top = point.Y - base.Height;
				break;
			case Origins.Custom:
				break;
			default:
				return;
			}
		}

		// Token: 0x06001ACC RID: 6860
		// RVA: 0x0001671A File Offset: 0x0001491A
		[CompilerGenerated]
		private void method_8()
		{
			if (!this.Focused && base.WindowState == FormWindowState.Normal)
			{
				base.WindowState = FormWindowState.Minimized;
				base.Show();
				base.WindowState = FormWindowState.Normal;
				base.Activate();
				return;
			}
		}

		// Token: 0x06001AB9 RID: 6841
		// RVA: 0x000166A5 File Offset: 0x000148A5
		protected override void OnLoad(EventArgs e)
		{
			this.method_0();
			base.OnLoad(e);
		}

		// Token: 0x06001AC8 RID: 6856
		[DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr intptr_0, int int_0, bool bool_1, int int_1);

		// Token: 0x06001AC7 RID: 6855
		// RVA: 0x000849DC File Offset: 0x00082BDC
		private static Point smethod_0()
		{
			Point result = default(Point);
			if (!Form2.GetCursorPos(ref result))
			{
				throw new InvalidOperationException();
			}
			return result;
		}

		// Token: 0x06001AC9 RID: 6857
		// RVA: 0x000166E8 File Offset: 0x000148E8
		internal static void smethod_1(Control control_0)
		{
			Form2.SendMessage(control_0.Handle, 11, false, 0);
		}

		// Token: 0x06001ACA RID: 6858
		// RVA: 0x000166FA File Offset: 0x000148FA
		internal static void smethod_2(Control control_0)
		{
			Form2.SendMessage(control_0.Handle, 11, true, 0);
			control_0.Refresh();
		}

		// Token: 0x06001AC1 RID: 6849
		// RVA: 0x000847E4 File Offset: 0x000829E4
		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			int msg = m.Msg;
			if (msg != 132)
			{
				if (msg != 798)
				{
					return;
				}
				if (this.eventHandler_1 == null)
				{
					return;
				}
				this.eventHandler_1(this, EventArgs.Empty);
				return;
			}
			else
			{
				if (this.eventHandler_0 == null)
				{
					return;
				}
				int num = (int)m.LParam;
				EventArgs12 eventArgs = new EventArgs12((Enum52)((int)m.Result), new Point(num & 65535, num >> 16));
				this.eventHandler_0(this, eventArgs);
				m.Result = (IntPtr)((long)eventArgs.enum52_0);
				return;
			}
		}
	}
}
