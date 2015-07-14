using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace ns9
{
	// Token: 0x020001CF RID: 463
	internal sealed class Class122 : Class121
	{
		// Token: 0x04000C7F RID: 3199
		private bool bool_0;

		// Token: 0x04000C80 RID: 3200
		private bool bool_1;

		// Token: 0x04000C82 RID: 3202
		private EventHandler eventHandler_5;

		// Token: 0x04000C83 RID: 3203
		private EventHandler eventHandler_6;

		// Token: 0x04000C81 RID: 3201
		public Form1 form1_0 = new Form1();

		// Token: 0x0600106D RID: 4205
		// RVA: 0x00056780 File Offset: 0x00054980
		public Class122()
		{
			base.Title = Class122.smethod_2();
			this.form1_0.method_4(new EventHandler(this.method_16));
			this.form1_0.method_2(new EventHandler(this.method_14));
			this.form1_0.method_3(new EventHandler(this.method_15));
			this.form1_0.method_0(new EventHandler(this.method_12));
			this.form1_0.method_1(new EventHandler(this.method_13));
			this.form1_0.method_5(new EventHandler(this.method_17));
			this.form1_0.Closing += new CancelEventHandler(this.form1_0_Closing);
			this.form1_0.Paint += new PaintEventHandler(this.form1_0_Paint);
			this.form1_0.BackColor = Color.Black;
		}

		// Token: 0x0600106F RID: 4207
		// RVA: 0x0001009D File Offset: 0x0000E29D
		internal void Close()
		{
			if (this.form1_0 != null)
			{
				this.form1_0.Close();
				this.form1_0 = null;
			}
		}

		// Token: 0x06001076 RID: 4214
		// RVA: 0x000100C1 File Offset: 0x0000E2C1
		private void form1_0_Closing(object sender, CancelEventArgs e)
		{
			base.method_8();
		}

		// Token: 0x06001077 RID: 4215
		// RVA: 0x000100C9 File Offset: 0x0000E2C9
		private void form1_0_Paint(object sender, PaintEventArgs e)
		{
			if (!this.bool_0)
			{
				base.OnPaint();
			}
		}

		// Token: 0x0600106B RID: 4203
		// RVA: 0x00056710 File Offset: 0x00054910
		internal void method_10(EventHandler eventHandler_7)
		{
			EventHandler eventHandler = this.eventHandler_5;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_7);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_5, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600106C RID: 4204
		// RVA: 0x00056748 File Offset: 0x00054948
		internal void method_11(EventHandler eventHandler_7)
		{
			EventHandler eventHandler = this.eventHandler_6;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_7);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_6, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06001074 RID: 4212
		// RVA: 0x000100B9 File Offset: 0x0000E2B9
		private void method_12(object sender, EventArgs e)
		{
			base.method_6();
		}

		// Token: 0x06001075 RID: 4213
		// RVA: 0x000100C1 File Offset: 0x0000E2C1
		private void method_13(object sender, EventArgs e)
		{
			base.method_8();
		}

		// Token: 0x06001078 RID: 4216
		// RVA: 0x000100D9 File Offset: 0x0000E2D9
		private void method_14(object sender, EventArgs e)
		{
			this.method_18();
		}

		// Token: 0x06001079 RID: 4217
		// RVA: 0x000100E1 File Offset: 0x0000E2E1
		private void method_15(object sender, EventArgs e)
		{
			base.method_9();
		}

		// Token: 0x0600107A RID: 4218
		// RVA: 0x000100E9 File Offset: 0x0000E2E9
		private void method_16(object sender, EventArgs e)
		{
			this.method_19();
		}

		// Token: 0x0600107B RID: 4219
		// RVA: 0x000100F1 File Offset: 0x0000E2F1
		private void method_17(object sender, EventArgs e)
		{
			base.method_7();
		}

		// Token: 0x0600107C RID: 4220
		// RVA: 0x000100F9 File Offset: 0x0000E2F9
		protected void method_18()
		{
			if (this.eventHandler_5 != null)
			{
				this.eventHandler_5(this, EventArgs.Empty);
			}
		}

		// Token: 0x0600107D RID: 4221
		// RVA: 0x00010114 File Offset: 0x0000E314
		protected void method_19()
		{
			if (this.eventHandler_6 != null)
			{
				this.eventHandler_6(this, EventArgs.Empty);
			}
		}

		// Token: 0x06001083 RID: 4227
		// RVA: 0x00010152 File Offset: 0x0000E352
		internal Form method_20()
		{
			return this.form1_0;
		}

		// Token: 0x06001070 RID: 4208
		// RVA: 0x00056874 File Offset: 0x00054A74
		internal static string smethod_0(Screen screen_0)
		{
			string result = screen_0.DeviceName;
			int num = screen_0.DeviceName.IndexOf('\0');
			if (num != -1)
			{
				result = screen_0.DeviceName.Substring(0, num);
			}
			return result;
		}

		// Token: 0x06001072 RID: 4210
		// RVA: 0x000568E0 File Offset: 0x00054AE0
		private static string smethod_1(Assembly assembly_0)
		{
			if (assembly_0 != null)
			{
				AssemblyTitleAttribute[] array = (AssemblyTitleAttribute[])assembly_0.GetCustomAttributes(typeof(AssemblyTitleAttribute), true);
				if (array != null && array.Length > 0)
				{
					return array[0].Title;
				}
			}
			return null;
		}

		// Token: 0x06001073 RID: 4211
		// RVA: 0x0005691C File Offset: 0x00054B1C
		private static string smethod_2()
		{
			string text = Class122.smethod_1(Assembly.GetEntryAssembly());
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			try
			{
				Uri uri = new Uri(Application.ExecutablePath);
				return Path.GetFileNameWithoutExtension(uri.LocalPath);
			}
			catch (ArgumentNullException)
			{
			}
			catch (UriFormatException)
			{
			}
			return Class127.smethod_3();
		}

		// Token: 0x0600107E RID: 4222
		// RVA: 0x00056980 File Offset: 0x00054B80
		internal static Screen smethod_3(GraphicsAdapter graphicsAdapter_0)
		{
			Screen[] allScreens = Screen.AllScreens;
			for (int i = 0; i < allScreens.Length; i++)
			{
				Screen screen = allScreens[i];
				if (Class122.smethod_0(screen) == graphicsAdapter_0.get_DeviceName())
				{
					return screen;
				}
			}
			throw new ArgumentException(Class127.smethod_7(), "adapter");
		}

		// Token: 0x0600107F RID: 4223
		// RVA: 0x000569D0 File Offset: 0x00054BD0
		internal static Screen smethod_4(string string_1)
		{
			if (string.IsNullOrEmpty(string_1))
			{
				throw new ArgumentException(Class127.smethod_15());
			}
			Screen[] allScreens = Screen.AllScreens;
			for (int i = 0; i < allScreens.Length; i++)
			{
				Screen screen = allScreens[i];
				if (Class122.smethod_0(screen) == string_1)
				{
					return screen;
				}
			}
			throw new ArgumentException(Class127.smethod_8(), "screenDeviceName");
		}

		// Token: 0x06001080 RID: 4224
		// RVA: 0x00056A2C File Offset: 0x00054C2C
		internal static Screen smethod_5(IntPtr intptr_0)
		{
			int num = 0;
			Screen screen = null;
			Class126.Struct19 struct;
			Class126.GetWindowRect(intptr_0, ref struct);
			Rectangle rectangle = new Rectangle(struct.int_0, struct.int_1, struct.int_2 - struct.int_0, struct.int_3 - struct.int_1);
			Screen[] allScreens = Screen.AllScreens;
			for (int i = 0; i < allScreens.Length; i++)
			{
				Screen screen2 = allScreens[i];
				Rectangle rectangle2 = rectangle;
				rectangle2.Intersect(screen2.Bounds);
				int num2 = rectangle2.Width * rectangle2.Height;
				if (num2 > num)
				{
					num = num2;
					screen = screen2;
				}
			}
			if (screen == null)
			{
				screen = Screen.AllScreens[0];
			}
			return screen;
		}

		// Token: 0x06001082 RID: 4226
		// RVA: 0x00010145 File Offset: 0x0000E345
		public override Rectangle vmethod_0()
		{
			return this.form1_0.method_16();
		}

		// Token: 0x06001084 RID: 4228
		// RVA: 0x0001015A File Offset: 0x0000E35A
		public override IntPtr vmethod_1()
		{
			if (this.form1_0 != null)
			{
				return this.form1_0.Handle;
			}
			return IntPtr.Zero;
		}

		// Token: 0x06001085 RID: 4229
		// RVA: 0x00010175 File Offset: 0x0000E375
		public override bool vmethod_2()
		{
			return this.form1_0 != null && this.form1_0.method_18();
		}

		// Token: 0x06001086 RID: 4230
		// RVA: 0x0001018C File Offset: 0x0000E38C
		internal override void vmethod_3(bool bool_2)
		{
			this.bool_1 = bool_2;
			if (this.form1_0 != null)
			{
				this.form1_0.method_19(bool_2);
			}
		}

		// Token: 0x06001087 RID: 4231
		// RVA: 0x000101A9 File Offset: 0x0000E3A9
		public override string vmethod_4()
		{
			if (this.form1_0 == null)
			{
				return string.Empty;
			}
			if (this.form1_0.method_17() == null)
			{
				return string.Empty;
			}
			return Class122.smethod_0(this.form1_0.method_17());
		}

		// Token: 0x0600106E RID: 4206
		// RVA: 0x00010088 File Offset: 0x0000E288
		public override void vmethod_5(bool bool_2)
		{
			this.form1_0.method_6(bool_2);
			this.bool_0 = true;
		}

		// Token: 0x06001071 RID: 4209
		// RVA: 0x000568A8 File Offset: 0x00054AA8
		public override void vmethod_6(string string_1, int int_2, int int_3)
		{
			try
			{
				this.form1_0.method_7(string_1, int_2, int_3);
			}
			finally
			{
				this.bool_0 = false;
			}
		}

		// Token: 0x06001081 RID: 4225
		// RVA: 0x0001012F File Offset: 0x0000E32F
		protected override void vmethod_7(string string_1)
		{
			if (this.form1_0 != null)
			{
				this.form1_0.Text = string_1;
			}
		}
	}
}
