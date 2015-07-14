using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;

namespace ns30
{
	// Token: 0x02000213 RID: 531
	internal sealed class Class167 : Component, ISupportInitialize
	{
		// Token: 0x04000E62 RID: 3682
		private bool bool_0;

		// Token: 0x04000E63 RID: 3683
		private bool bool_1;

		// Token: 0x04000E60 RID: 3680
		private Class164 class164_0;

		// Token: 0x04000E64 RID: 3684
		private Class168 class168_0;

		// Token: 0x04000E5E RID: 3678
		private int int_0;

		// Token: 0x04000E67 RID: 3687
		private int int_1;

		// Token: 0x04000E59 RID: 3673
		private static readonly object object_0 = new object();

		// Token: 0x04000E5A RID: 3674
		private static readonly object object_1 = new object();

		// Token: 0x04000E5B RID: 3675
		private static readonly object object_2 = new object();

		// Token: 0x04000E5C RID: 3676
		private static readonly object object_3 = new object();

		// Token: 0x04000E5D RID: 3677
		private static readonly object object_4 = new object();

		// Token: 0x04000E5F RID: 3679
		internal Stream stream_0;

		// Token: 0x04000E61 RID: 3681
		private string[] string_0;

		// Token: 0x04000E65 RID: 3685
		private string[] string_1;

		// Token: 0x04000E66 RID: 3686
		private Timer timer_0;

		// Token: 0x170002C1 RID: 705
		public Class168 Items
		{
			// Token: 0x060012DC RID: 4828
			// RVA: 0x00011922 File Offset: 0x0000FB22
			get
			{
				return this.class168_0;
			}
		}

		// Token: 0x060012D9 RID: 4825
		// RVA: 0x0001190C File Offset: 0x0000FB0C
		public Class167()
		{
			this.method_8();
		}

		// Token: 0x060012DF RID: 4831
		// RVA: 0x0001192A File Offset: 0x0000FB2A
		public void BeginInit()
		{
			this.int_1++;
		}

		// Token: 0x060012E0 RID: 4832
		// RVA: 0x0001193A File Offset: 0x0000FB3A
		public void EndInit()
		{
			if (this.int_1 > 0)
			{
				this.int_1--;
			}
			this.method_13();
		}

		// Token: 0x060012DA RID: 4826
		// RVA: 0x0001191A File Offset: 0x0000FB1A
		public Class164 method_0()
		{
			return this.class164_0;
		}

		// Token: 0x060012DB RID: 4827
		// RVA: 0x00062F20 File Offset: 0x00061120
		public string[] method_1()
		{
			if (this.string_0 == null)
			{
				this.bool_0 = true;
				try
				{
					this.vmethod_1();
				}
				finally
				{
					this.bool_0 = false;
				}
				Class173 class = new Class173();
				this.method_0().method_1(class);
				this.string_0 = class.ToArray();
			}
			return this.string_0;
		}

		// Token: 0x060012E9 RID: 4841
		// RVA: 0x0001199F File Offset: 0x0000FB9F
		protected internal bool method_10()
		{
			return this.method_0().method_21().ToLower(CultureInfo.InvariantCulture).Equals("application/x-www-form-urlencoded");
		}

		// Token: 0x060012EA RID: 4842
		// RVA: 0x000119C0 File Offset: 0x0000FBC0
		protected internal bool method_11()
		{
			return this.method_0().method_21().ToLower(CultureInfo.InvariantCulture).IndexOf("multipart/") > -1;
		}

		// Token: 0x060012ED RID: 4845
		// RVA: 0x000119E4 File Offset: 0x0000FBE4
		private void method_12(object object_5)
		{
			this.timer_0.Dispose();
		}

		// Token: 0x060012EE RID: 4846
		// RVA: 0x000119F1 File Offset: 0x0000FBF1
		public void method_13()
		{
			if (this.int_1 == 0)
			{
				if (!this.bool_0)
				{
					this.method_0().method_8(string.Empty);
				}
				this.string_0 = null;
				this.string_1 = null;
				this.vmethod_2(EventArgs.Empty);
			}
		}

		// Token: 0x060012EF RID: 4847
		// RVA: 0x00011A2C File Offset: 0x0000FC2C
		protected internal void method_14()
		{
			if (this.int_1 == 0 && !this.bool_0)
			{
				this.method_0().method_22(this.vmethod_0());
			}
		}

		// Token: 0x060012DD RID: 4829
		// RVA: 0x00062F80 File Offset: 0x00061180
		public Stream method_2()
		{
			this.bool_0 = true;
			try
			{
				this.method_9();
			}
			finally
			{
				this.bool_0 = false;
			}
			Stream7 stream = new Stream7();
			try
			{
				this.method_6(stream);
			}
			catch
			{
				stream.Close();
				throw;
			}
			return stream;
		}

		// Token: 0x060012DE RID: 4830
		// RVA: 0x00062FDC File Offset: 0x000611DC
		public long method_3()
		{
			string str = this.method_4();
			long num = 0L;
			foreach (Class147 class147_ in this.Items)
			{
				num += this.method_5(class147_);
			}
			if (this.method_11())
			{
				return num + (long)(("\r\n--" + str + "\r\n").Length * this.Items.Count + ("--" + str + "--\r\n").Length);
			}
			if (this.method_10())
			{
				num += (long)("&".Length * (this.Items.Count - 1));
			}
			return num;
		}

		// Token: 0x060012E1 RID: 4833
		// RVA: 0x000630B8 File Offset: 0x000612B8
		protected internal string method_4()
		{
			DateTime now = DateTime.Now;
			string text = string.Format(CultureInfo.InvariantCulture, "{0}{1}{2}{3}{4}{5}", new object[]
			{
				now.Month.ToString("X2", CultureInfo.InvariantCulture),
				now.Day.ToString("X2", CultureInfo.InvariantCulture),
				now.Hour.ToString("X2", CultureInfo.InvariantCulture),
				now.Minute.ToString("X2", CultureInfo.InvariantCulture),
				now.Second.ToString("X2", CultureInfo.InvariantCulture),
				now.Millisecond.ToString("X2", CultureInfo.InvariantCulture)
			});
			return string.Format(CultureInfo.InvariantCulture, "---------------------------{0}", new object[]
			{
				text.Substring(0, 12)
			});
		}

		// Token: 0x060012E3 RID: 4835
		// RVA: 0x00063250 File Offset: 0x00061450
		private long method_5(Class147 class147_0)
		{
			long length;
			using (Stream stream = class147_0.vmethod_0())
			{
				length = stream.Length;
			}
			return length;
		}

		// Token: 0x060012E4 RID: 4836
		// RVA: 0x00063288 File Offset: 0x00061488
		private void method_6(Stream7 stream7_0)
		{
			for (int i = 0; i < this.Items.Count; i++)
			{
				string str = string.Empty;
				if (this.method_11())
				{
					str = "--" + this.method_0().method_7() + "\r\n";
					if (i > 0)
					{
						str = "\r\n" + str;
					}
				}
				else if (i > 0 && this.method_10())
				{
					str = "&";
				}
				if (!Class174.smethod_2(str))
				{
					stream7_0.method_0(new Stream8(str));
				}
				stream7_0.method_0(this.Items[i].vmethod_0());
			}
			if (this.method_11())
			{
				stream7_0.method_0(new Stream8("\r\n--" + this.method_0().method_7() + "--\r\n"));
			}
		}

		// Token: 0x060012E5 RID: 4837
		// RVA: 0x00011959 File Offset: 0x0000FB59
		private void method_7(object sender, EventArgs e)
		{
			this.method_13();
		}

		// Token: 0x060012E6 RID: 4838
		// RVA: 0x00063354 File Offset: 0x00061554
		private void method_8()
		{
			this.class168_0 = new Class168(this);
			this.class164_0 = new Class164();
			this.class164_0.method_0(new EventHandler(this.method_7));
			this.int_1 = 0;
			this.string_1 = null;
			this.string_0 = null;
			this.bool_0 = false;
			this.stream_0 = null;
			this.int_0 = 8192;
			Assembly assembly = Assembly.Load("System.Windows.Forms, Version=" + ((Environment.Version.Major > 1) ? "2.0.0.0" : "1.0.3300.0") + ", Culture=neutral, PublicKeyToken=b77a5c561934e089");
			this.bool_1 = (bool)assembly.GetType("System.Windows.Forms.SystemInformation").InvokeMember("UserInteractive", BindingFlags.Static | BindingFlags.Public | BindingFlags.GetProperty, null, null, null);
			if (!this.bool_1)
			{
				this.timer_0 = new Timer(new TimerCallback(this.method_12), null, 1800000, 1800000);
			}
		}

		// Token: 0x060012E7 RID: 4839
		// RVA: 0x00011961 File Offset: 0x0000FB61
		private void method_9()
		{
			if (this.method_11())
			{
				if (Class174.smethod_2(this.method_0().method_7()))
				{
					this.method_0().method_8(this.method_4());
					return;
				}
			}
			else
			{
				this.method_0().method_8(string.Empty);
			}
		}

		// Token: 0x060012E2 RID: 4834
		// RVA: 0x000631B8 File Offset: 0x000613B8
		protected virtual string vmethod_0()
		{
			bool flag = this.Items.Count > 0;
			foreach (Class147 class in this.Items)
			{
				if (class is Class149)
				{
					string result = "multipart/form-data";
					return result;
				}
				flag = (flag && class is Class148);
			}
			if (!flag)
			{
				return string.Empty;
			}
			return "application/x-www-form-urlencoded";
		}

		// Token: 0x060012E8 RID: 4840
		// RVA: 0x00063440 File Offset: 0x00061640
		protected virtual void vmethod_1()
		{
			this.method_9();
			this.method_0().method_20(this.method_3().ToString());
			if (this.method_0().method_19().Equals("0"))
			{
				this.method_0().method_20("");
			}
		}

		// Token: 0x060012EB RID: 4843
		// RVA: 0x00063494 File Offset: 0x00061694
		protected virtual void vmethod_2(EventArgs eventArgs_0)
		{
			EventHandler eventHandler = (EventHandler)base.Events[Class167.object_0];
			if (eventHandler != null)
			{
				eventHandler(this, eventArgs_0);
			}
		}

		// Token: 0x060012EC RID: 4844
		// RVA: 0x000634C4 File Offset: 0x000616C4
		protected internal virtual void vmethod_3(EventArgs2 eventArgs2_0)
		{
			Delegate12 delegate = (Delegate12)base.Events[Class167.object_2];
			if (delegate != null)
			{
				delegate(this, eventArgs2_0);
			}
		}
	}
}
