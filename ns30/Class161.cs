using System;
using System.ComponentModel;
using System.Net.Sockets;

namespace ns30
{
	// Token: 0x0200020A RID: 522
	internal abstract class Class161 : Component
	{
		// Token: 0x04000E12 RID: 3602
		private bool bool_0;

		// Token: 0x04000E11 RID: 3601
		private Class152 class152_0;

		// Token: 0x04000E13 RID: 3603
		private int int_0;

		// Token: 0x04000E0E RID: 3598
		private static readonly object object_0 = new object();

		// Token: 0x04000E0F RID: 3599
		private static readonly object object_1 = new object();

		// Token: 0x04000E10 RID: 3600
		private static readonly object object_2 = new object();

		// Token: 0x04000E14 RID: 3604
		private string string_0;

		// Token: 0x06001244 RID: 4676
		// RVA: 0x00061488 File Offset: 0x0005F688
		protected Class161()
		{
			int arg_10_0 = Environment.Version.Major;
			this.class152_0 = new Class152();
			this.method_2(8192);
			this.method_11(30000);
			this.method_4(0);
			this.int_0 = this.vmethod_0();
			this.string_0 = string.Empty;
		}

		// Token: 0x06001253 RID: 4691
		// RVA: 0x000614E8 File Offset: 0x0005F6E8
		public void Close()
		{
			bool flag = this.method_0();
			this.vmethod_1();
			if (flag)
			{
				this.OnClosed(EventArgs.Empty);
			}
		}

		// Token: 0x06001254 RID: 4692
		// RVA: 0x00061510 File Offset: 0x0005F710
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (this.class152_0 != null)
				{
					this.Close();
					this.class152_0.Dispose();
					this.class152_0 = null;
				}
				base.Dispose(disposing);
			}
			catch
			{
			}
		}

		// Token: 0x06001245 RID: 4677
		// RVA: 0x0001119D File Offset: 0x0000F39D
		public bool method_0()
		{
			return this.method_5() != null && this.method_5().method_0();
		}

		// Token: 0x06001246 RID: 4678
		// RVA: 0x000111B4 File Offset: 0x0000F3B4
		public int method_1()
		{
			return this.method_5().method_1();
		}

		// Token: 0x0600124F RID: 4687
		// RVA: 0x0001127D File Offset: 0x0000F47D
		public int method_10()
		{
			return this.method_5().method_19();
		}

		// Token: 0x06001250 RID: 4688
		// RVA: 0x0001128A File Offset: 0x0000F48A
		public void method_11(int int_1)
		{
			if (this.method_10() != int_1)
			{
				this.method_5().method_20(int_1);
				this.vmethod_3(new PropertyChangedEventArgs("TimeOut"));
			}
		}

		// Token: 0x06001251 RID: 4689
		// RVA: 0x000112B1 File Offset: 0x0000F4B1
		public void method_12(EventHandler eventHandler_0)
		{
			base.Events.AddHandler(Class161.object_2, eventHandler_0);
		}

		// Token: 0x06001252 RID: 4690
		// RVA: 0x000112C4 File Offset: 0x0000F4C4
		public void method_13(EventHandler eventHandler_0)
		{
			base.Events.RemoveHandler(Class161.object_2, eventHandler_0);
		}

		// Token: 0x0600125B RID: 4699
		// RVA: 0x000615EC File Offset: 0x0005F7EC
		public void method_14()
		{
			if (!this.method_0())
			{
				try
				{
					this.vmethod_2();
					this.vmethod_4(EventArgs.Empty);
				}
				catch
				{
					this.bool_0 = true;
					try
					{
						this.Close();
					}
					catch (SocketException)
					{
					}
					catch (Exception2)
					{
					}
					this.bool_0 = false;
					throw;
				}
			}
		}

		// Token: 0x06001247 RID: 4679
		// RVA: 0x000111C1 File Offset: 0x0000F3C1
		public void method_2(int int_1)
		{
			if (this.method_1() != int_1)
			{
				this.method_5().method_2(int_1);
				this.vmethod_3(new PropertyChangedEventArgs("BatchSize"));
			}
		}

		// Token: 0x06001248 RID: 4680
		// RVA: 0x000111E8 File Offset: 0x0000F3E8
		public int method_3()
		{
			return this.method_5().method_3();
		}

		// Token: 0x06001249 RID: 4681
		// RVA: 0x000111F5 File Offset: 0x0000F3F5
		public void method_4(int int_1)
		{
			if (this.method_3() != int_1)
			{
				this.method_5().method_4(int_1);
				this.vmethod_3(new PropertyChangedEventArgs("BitsPerSec"));
			}
		}

		// Token: 0x0600124A RID: 4682
		// RVA: 0x0001121C File Offset: 0x0000F41C
		public Class152 method_5()
		{
			return this.class152_0;
		}

		// Token: 0x0600124B RID: 4683
		// RVA: 0x00011224 File Offset: 0x0000F424
		public int method_6()
		{
			return this.int_0;
		}

		// Token: 0x0600124C RID: 4684
		// RVA: 0x0001122C File Offset: 0x0000F42C
		public void method_7(int int_1)
		{
			if (this.int_0 != int_1)
			{
				this.int_0 = int_1;
				this.vmethod_3(new PropertyChangedEventArgs("Port"));
			}
		}

		// Token: 0x0600124D RID: 4685
		// RVA: 0x0001124E File Offset: 0x0000F44E
		public string method_8()
		{
			return this.string_0;
		}

		// Token: 0x0600124E RID: 4686
		// RVA: 0x00011256 File Offset: 0x0000F456
		public void method_9(string string_1)
		{
			if (this.string_0 != string_1)
			{
				this.string_0 = string_1;
				this.vmethod_3(new PropertyChangedEventArgs("Server"));
			}
		}

		// Token: 0x06001259 RID: 4697
		// RVA: 0x0006158C File Offset: 0x0005F78C
		protected virtual void OnClosed(EventArgs eventArgs_0)
		{
			EventHandler eventHandler = (EventHandler)base.Events[Class161.object_1];
			if (eventHandler != null)
			{
				eventHandler(this, eventArgs_0);
			}
		}

		// Token: 0x06001255 RID: 4693
		// RVA: 0x00006D86 File Offset: 0x00004F86
		protected virtual int vmethod_0()
		{
			return 0;
		}

		// Token: 0x06001256 RID: 4694
		// RVA: 0x000112D7 File Offset: 0x0000F4D7
		protected virtual void vmethod_1()
		{
			if (this.method_5() != null)
			{
				this.method_5().Close(true);
			}
		}

		// Token: 0x06001257 RID: 4695
		// RVA: 0x000112ED File Offset: 0x0000F4ED
		protected virtual void vmethod_2()
		{
			if (this.method_1() < 1)
			{
				throw new Exception2("Invalid Batch Size", -1);
			}
			this.vmethod_5(this.method_8(), this.method_6());
		}

		// Token: 0x06001258 RID: 4696
		// RVA: 0x0006155C File Offset: 0x0005F75C
		protected virtual void vmethod_3(PropertyChangedEventArgs propertyChangedEventArgs_0)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = (PropertyChangedEventHandler)base.Events[Class161.object_0];
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, propertyChangedEventArgs_0);
			}
		}

		// Token: 0x0600125A RID: 4698
		// RVA: 0x000615BC File Offset: 0x0005F7BC
		protected virtual void vmethod_4(EventArgs eventArgs_0)
		{
			EventHandler eventHandler = (EventHandler)base.Events[Class161.object_2];
			if (eventHandler != null)
			{
				eventHandler(this, eventArgs_0);
			}
		}

		// Token: 0x0600125C RID: 4700
		// RVA: 0x00011316 File Offset: 0x0000F516
		protected virtual void vmethod_5(string string_1, int int_1)
		{
			this.method_5().method_9(new Class171());
			this.method_5().method_29(Class150.smethod_0(string_1), int_1);
		}
	}
}
