using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace ns30
{
	// Token: 0x020001F8 RID: 504
	internal abstract class Class150 : IDisposable
	{
		// Token: 0x04000DDB RID: 3547
		internal bool bool_0;

		// Token: 0x04000DDF RID: 3551
		private bool bool_1;

		// Token: 0x04000DE0 RID: 3552
		private Class171 class171_0;

		// Token: 0x04000DE1 RID: 3553
		public Delegate16 delegate16_0;

		// Token: 0x04000DE2 RID: 3554
		public EventHandler eventHandler_0;

		// Token: 0x04000DDC RID: 3548
		private int int_0 = 8192;

		// Token: 0x04000DE6 RID: 3558
		[CompilerGenerated]
		private int int_1;

		// Token: 0x04000DDD RID: 3549
		internal long long_0;

		// Token: 0x04000DDE RID: 3550
		private long long_1 = -1L;

		// Token: 0x04000DE4 RID: 3556
		internal long long_2;

		// Token: 0x04000DE5 RID: 3557
		internal long long_3;

		// Token: 0x04000DE3 RID: 3555
		private Socket socket_0;

		// Token: 0x060011A4 RID: 4516
		// RVA: 0x00060208 File Offset: 0x0005E408
		public void Close(bool bool_2)
		{
			try
			{
				if (this.method_0())
				{
					this.method_12(bool_2);
				}
			}
			finally
			{
				this.method_16();
			}
		}

		// Token: 0x060011A3 RID: 4515
		// RVA: 0x00010BB8 File Offset: 0x0000EDB8
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060011A7 RID: 4519
		// RVA: 0x00010BDE File Offset: 0x0000EDDE
		protected virtual void Dispose(bool bool_2)
		{
			this.Close(false);
		}

		// Token: 0x060011A8 RID: 4520
		// RVA: 0x00060240 File Offset: 0x0005E440
		~Class150()
		{
			try
			{
				this.Dispose(false);
			}
			catch
			{
			}
		}

		// Token: 0x06001197 RID: 4503
		// RVA: 0x00010B49 File Offset: 0x0000ED49
		public bool method_0()
		{
			return this.bool_0;
		}

		// Token: 0x06001198 RID: 4504
		// RVA: 0x00010B51 File Offset: 0x0000ED51
		public int method_1()
		{
			return this.int_0;
		}

		// Token: 0x060011A1 RID: 4513
		// RVA: 0x00010BA7 File Offset: 0x0000EDA7
		public Socket method_10()
		{
			return this.socket_0;
		}

		// Token: 0x060011A2 RID: 4514
		// RVA: 0x00010BAF File Offset: 0x0000EDAF
		public void method_11(Socket socket_1)
		{
			this.socket_0 = socket_1;
		}

		// Token: 0x060011A5 RID: 4517
		// RVA: 0x00010BC7 File Offset: 0x0000EDC7
		public void method_12(bool bool_2)
		{
			this.method_8().Close(bool_2);
			if (bool_2)
			{
				this.vmethod_0();
			}
		}

		// Token: 0x060011AA RID: 4522
		// RVA: 0x00010BE7 File Offset: 0x0000EDE7
		public void method_13(long long_4, long long_5)
		{
			this.long_3 = long_4;
			this.long_0 = 0L;
			this.long_2 = long_5;
		}

		// Token: 0x060011AC RID: 4524
		// RVA: 0x00010C06 File Offset: 0x0000EE06
		protected internal bool method_14()
		{
			return this.long_1 > -1L && this.long_1 <= this.long_0;
		}

		// Token: 0x060011AD RID: 4525
		// RVA: 0x00010C2C File Offset: 0x0000EE2C
		protected bool method_15()
		{
			return this.method_7() || this.method_14();
		}

		// Token: 0x060011B4 RID: 4532
		// RVA: 0x00060378 File Offset: 0x0005E578
		private void method_16()
		{
			lock (this)
			{
				this.bool_0 = false;
				if (this.socket_0 != null)
				{
					try
					{
						if (this.socket_0.Connected)
						{
							this.socket_0.Shutdown(SocketShutdown.Both);
							this.socket_0.Close();
						}
					}
					catch
					{
					}
				}
				this.socket_0 = null;
			}
		}

		// Token: 0x06001199 RID: 4505
		// RVA: 0x00010B59 File Offset: 0x0000ED59
		public void method_2(int int_2)
		{
			this.int_0 = int_2;
		}

		// Token: 0x0600119A RID: 4506
		// RVA: 0x00010B62 File Offset: 0x0000ED62
		[CompilerGenerated]
		public int method_3()
		{
			return this.int_1;
		}

		// Token: 0x0600119B RID: 4507
		// RVA: 0x00010B6A File Offset: 0x0000ED6A
		[CompilerGenerated]
		public void method_4(int int_2)
		{
			this.int_1 = int_2;
		}

		// Token: 0x0600119C RID: 4508
		// RVA: 0x00010B73 File Offset: 0x0000ED73
		public long method_5()
		{
			return this.long_3;
		}

		// Token: 0x0600119D RID: 4509
		// RVA: 0x00010B7B File Offset: 0x0000ED7B
		public long method_6()
		{
			return this.long_1;
		}

		// Token: 0x0600119E RID: 4510
		// RVA: 0x00010B83 File Offset: 0x0000ED83
		public bool method_7()
		{
			return this.bool_1;
		}

		// Token: 0x0600119F RID: 4511
		// RVA: 0x00010B8B File Offset: 0x0000ED8B
		public Class171 method_8()
		{
			if (this.class171_0 == null)
			{
				throw new Exception2("NetworkStream is required", -1);
			}
			return this.class171_0;
		}

		// Token: 0x060011A0 RID: 4512
		// RVA: 0x000601B8 File Offset: 0x0005E3B8
		public void method_9(Class171 class171_1)
		{
			if (this.class171_0 != class171_1)
			{
				if (this.class171_0 != null && class171_1 != null)
				{
					this.class171_0.CopyTo(class171_1);
				}
				this.class171_0 = null;
				this.class171_0 = class171_1;
				if (this.class171_0 != null)
				{
					this.class171_0.class150_0 = this;
				}
			}
		}

		// Token: 0x060011B3 RID: 4531
		public abstract void ReadData(Stream stream_0);

		// Token: 0x060011A9 RID: 4521
		// RVA: 0x00060280 File Offset: 0x0005E480
		public static IPAddress smethod_0(string string_0)
		{
			IPAddress result2;
			try
			{
				if (Class174.smethod_2(string_0))
				{
					throw new Exception2("Invalid host address", -1);
				}
				if (Class150.smethod_1(string_0))
				{
					IPAddress result = IPAddress.Parse(string_0);
					return result;
				}
				IPAddress[] addressList = Dns.GetHostEntry(string_0).AddressList;
				for (int i = 0; i < addressList.Length; i++)
				{
					IPAddress iPAddress = addressList[i];
					if (iPAddress.AddressFamily.Equals(AddressFamily.InterNetwork))
					{
						IPAddress result = iPAddress;
						return result;
					}
				}
				result2 = null;
			}
			catch (SocketException ex)
			{
				throw new Exception2(ex.Message, ex.ErrorCode, ex);
			}
			return result2;
		}

		// Token: 0x060011AB RID: 4523
		// RVA: 0x00060320 File Offset: 0x0005E520
		private static bool smethod_1(string string_0)
		{
			if (Class174.smethod_2(string_0))
			{
				return false;
			}
			string[] array = Class174.smethod_1(string_0, '.');
			if (array.Length != 4)
			{
				return false;
			}
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				string input = array2[i];
				if (!Regex.IsMatch(input, "^\\d+$"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060011A6 RID: 4518
		public abstract void vmethod_0();

		// Token: 0x060011AE RID: 4526
		protected internal abstract bool vmethod_1(IPAddress ipaddress_0, int int_2);

		// Token: 0x060011AF RID: 4527
		protected internal abstract bool vmethod_2(Stream stream_0);

		// Token: 0x060011B0 RID: 4528
		protected internal abstract bool vmethod_3(Stream stream_0);

		// Token: 0x060011B1 RID: 4529
		// RVA: 0x00010C3E File Offset: 0x0000EE3E
		protected internal virtual void vmethod_4(EventArgs6 eventArgs6_0)
		{
			if (this.delegate16_0 != null)
			{
				this.delegate16_0(this, eventArgs6_0);
			}
		}

		// Token: 0x060011B2 RID: 4530
		// RVA: 0x00010C55 File Offset: 0x0000EE55
		protected internal virtual void vmethod_5(EventArgs eventArgs_0)
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, eventArgs_0);
			}
		}

		// Token: 0x060011B5 RID: 4533
		public abstract void vmethod_6(Stream stream_0);
	}
}
