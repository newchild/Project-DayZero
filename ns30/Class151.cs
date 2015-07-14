using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace ns30
{
	// Token: 0x0200022C RID: 556
	internal abstract class Class151 : Class150
	{
		// Token: 0x04000EA3 RID: 3747
		private bool bool_2;

		// Token: 0x04000EA4 RID: 3748
		private bool bool_3;

		// Token: 0x04000EA6 RID: 3750
		[CompilerGenerated]
		private bool bool_4;

		// Token: 0x04000EA5 RID: 3749
		private int int_2 = 10000;

		// Token: 0x0600138A RID: 5002
		// RVA: 0x0001208C File Offset: 0x0001028C
		[CompilerGenerated]
		public bool method_17()
		{
			return this.bool_4;
		}

		// Token: 0x0600138B RID: 5003
		// RVA: 0x00012094 File Offset: 0x00010294
		[CompilerGenerated]
		public void method_18(bool bool_5)
		{
			this.bool_4 = bool_5;
		}

		// Token: 0x0600138C RID: 5004
		// RVA: 0x0001209D File Offset: 0x0001029D
		public int method_19()
		{
			return this.int_2;
		}

		// Token: 0x0600138D RID: 5005
		// RVA: 0x000120A5 File Offset: 0x000102A5
		public void method_20(int int_3)
		{
			this.int_2 = int_3;
		}

		// Token: 0x0600138E RID: 5006
		// RVA: 0x000120AE File Offset: 0x000102AE
		private void method_21(Class146 class146_0)
		{
			if (class146_0.exception_0 != null)
			{
				throw class146_0.exception_0;
			}
		}

		// Token: 0x0600138F RID: 5007
		// RVA: 0x0006462C File Offset: 0x0006282C
		protected void method_22(SocketType socketType_0, ProtocolType protocolType_0)
		{
			try
			{
				base.method_11(new Socket(AddressFamily.InterNetwork, socketType_0, protocolType_0));
				base.method_10().ReceiveTimeout = 30000;
				base.method_10().SendTimeout = 30000;
				base.method_10().Blocking = true;
			}
			catch (SocketException ex)
			{
				throw new Exception2(ex.Message, ex.ErrorCode, ex);
			}
		}

		// Token: 0x06001391 RID: 5009
		// RVA: 0x000646D8 File Offset: 0x000628D8
		private void method_23(Stream stream_0)
		{
			this.bool_3 = false;
			if (base.method_8().method_1())
			{
				base.method_8().method_2(false);
				base.method_8().Read(stream_0);
				if (!this.method_17() || !base.method_0())
				{
					if (!base.method_0())
					{
						base.method_8().method_9();
					}
					return;
				}
			}
			this.bool_2 = true;
			base.method_8().Read(stream_0);
			if (this.bool_3)
			{
				base.Close(false);
				return;
			}
			this.bool_2 = false;
			if (stream_0 != null)
			{
				while (base.method_8().Read(stream_0) && !this.bool_3 && !base.method_15())
				{
				}
				if (this.bool_3)
				{
					base.Close(false);
				}
			}
		}

		// Token: 0x06001392 RID: 5010
		// RVA: 0x000120BF File Offset: 0x000102BF
		private void method_24(Stream stream_0)
		{
			if (!base.method_8().Write(stream_0))
			{
				while (!base.method_8().Write(stream_0))
				{
					if (base.method_15())
					{
						return;
					}
				}
				return;
			}
		}

		// Token: 0x06001396 RID: 5014
		// RVA: 0x000649D8 File Offset: 0x00062BD8
		private int method_25(byte[] byte_0, int int_3)
		{
			if (base.method_10() == null)
			{
				throw new Exception2("Connection is closed", 10038);
			}
			int result;
			try
			{
				result = base.method_10().Receive(byte_0, 0, int_3, SocketFlags.None);
			}
			catch (SocketException ex)
			{
				throw new Exception2(ex.Message, ex.ErrorCode, ex);
			}
			return result;
		}

		// Token: 0x06001398 RID: 5016
		// RVA: 0x000120E8 File Offset: 0x000102E8
		private void method_26(WaitHandle waitHandle_0, int int_3)
		{
			if (!base.method_7() && !waitHandle_0.WaitOne(int_3, false))
			{
				throw new Exception2("Timeout error occured", -1);
			}
		}

		// Token: 0x06001399 RID: 5017
		// RVA: 0x00064A78 File Offset: 0x00062C78
		private int method_27(byte[] byte_0, int int_3)
		{
			if (base.method_10() == null)
			{
				throw new Exception2("Connection is closed", 10038);
			}
			int int_4;
			try
			{
				Class146 class = new Class146(base.method_10());
				base.method_10().BeginSend(byte_0, 0, int_3, SocketFlags.None, new AsyncCallback(this.method_28), class);
				this.method_26(class.autoResetEvent_0, this.method_19());
				this.method_21(class);
				int_4 = class.int_0;
			}
			catch (SocketException ex)
			{
				throw new Exception2(ex.Message, ex.ErrorCode, ex);
			}
			return int_4;
		}

		// Token: 0x0600139A RID: 5018
		// RVA: 0x00064B10 File Offset: 0x00062D10
		private void method_28(IAsyncResult iasyncResult_0)
		{
			Class146 class = (Class146)iasyncResult_0.AsyncState;
			try
			{
				class.int_0 = class.socket_0.EndSend(iasyncResult_0);
			}
			catch (Exception exception_)
			{
				class.exception_0 = exception_;
			}
			finally
			{
				class.autoResetEvent_0.Set();
			}
		}

		// Token: 0x06001397 RID: 5015
		// RVA: 0x00064A34 File Offset: 0x00062C34
		public override void ReadData(Stream stream_0)
		{
			this.method_23(stream_0);
			while (true)
			{
				switch (base.method_8().method_5())
				{
				case Enum21.const_1:
					this.method_23(null);
					continue;
				case Enum21.const_2:
					this.vmethod_6(null);
					continue;
				}
				break;
			}
		}

		// Token: 0x06001390 RID: 5008
		// RVA: 0x0006469C File Offset: 0x0006289C
		public override void vmethod_0()
		{
			switch (base.method_8().method_5())
			{
			case Enum21.const_1:
				this.ReadData(null);
				return;
			case Enum21.const_2:
				this.vmethod_6(null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06001393 RID: 5011
		// RVA: 0x00064794 File Offset: 0x00062994
		protected internal override bool vmethod_1(IPAddress ipaddress_0, int int_3)
		{
			bool result;
			try
			{
				if (int_3 <= 0)
				{
					throw new Exception2("Invalid port number", -1);
				}
				IPEndPoint remoteEP = new IPEndPoint(ipaddress_0, int_3);
				IAsyncResult asyncResult = base.method_10().BeginConnect(remoteEP, null, null);
				if (!asyncResult.AsyncWaitHandle.WaitOne(6000, true) || !base.method_10().Connected)
				{
					base.method_10().Close();
					throw new Exception2("Timeout during connection to " + ipaddress_0.ToString(), 408);
				}
				result = true;
			}
			catch (SocketException ex)
			{
				throw new Exception2(ex.Message, ex.ErrorCode, ex);
			}
			return result;
		}

		// Token: 0x06001394 RID: 5012
		// RVA: 0x00064838 File Offset: 0x00062A38
		protected internal override bool vmethod_2(Stream stream_0)
		{
			int num = base.method_8().vmethod_1();
			if (num <= 0)
			{
				return true;
			}
			byte[] array = new byte[num];
			if (base.method_10() == null)
			{
				throw new Exception2("Connection is closed", 10038);
			}
			int num2;
			if (!this.bool_2 && !this.method_17())
			{
				try
				{
					base.method_10().Blocking = false;
					if (base.method_10().Available > 0)
					{
						num2 = base.method_10().Receive(array, 0, num, SocketFlags.None);
						if (num2 == 0)
						{
							this.bool_3 = true;
						}
					}
					else
					{
						num2 = 0;
					}
					goto IL_BF;
				}
				catch (SocketException ex)
				{
					if (ex.NativeErrorCode != 10035)
					{
						throw new Exception2(ex.Message, ex.ErrorCode, ex);
					}
					num2 = 0;
					goto IL_BF;
				}
			}
			base.method_10().Blocking = true;
			num2 = this.method_25(array, num);
			if (num2 == 0)
			{
				this.bool_3 = true;
			}
			IL_BF:
			if (num2 > 0)
			{
				stream_0.Write(array, 0, num2);
				base.method_8().vmethod_3(num2);
				return true;
			}
			return false;
		}

		// Token: 0x06001395 RID: 5013
		// RVA: 0x00064930 File Offset: 0x00062B30
		protected internal override bool vmethod_3(Stream stream_0)
		{
			int num = base.method_8().vmethod_1();
			if (num > 0)
			{
				byte[] array = new byte[num];
				long num2 = stream_0.Position;
				do
				{
					num = base.method_8().vmethod_1();
					if ((long)num > stream_0.Length - num2)
					{
						num = (int)(stream_0.Length - num2);
					}
					stream_0.Read(array, 0, num);
					int num3 = this.method_27(array, num);
					num2 += (long)num3;
					if (num3 < num)
					{
						stream_0.Seek(stream_0.Position - (long)num + (long)num3, SeekOrigin.Begin);
					}
					base.method_8().vmethod_3(num3);
					if (num2 >= stream_0.Length)
					{
						break;
					}
				}
				while (!base.method_15());
			}
			return true;
		}

		// Token: 0x0600139B RID: 5019
		// RVA: 0x00064B74 File Offset: 0x00062D74
		public override void vmethod_6(Stream stream_0)
		{
			this.method_24(stream_0);
			while (true)
			{
				switch (base.method_8().method_5())
				{
				case Enum21.const_1:
					this.ReadData(null);
					continue;
				case Enum21.const_2:
					this.method_24(null);
					continue;
				}
				break;
			}
		}

		// Token: 0x0600139C RID: 5020
		// RVA: 0x00064BB8 File Offset: 0x00062DB8
		public void WriteString(string string_0)
		{
			using (MemoryStream memoryStream = new MemoryStream())
			{
				byte[] bytes = Encoding.ASCII.GetBytes(string_0);
				memoryStream.Write(bytes, 0, bytes.Length);
				memoryStream.Seek(0L, SeekOrigin.Begin);
				this.vmethod_6(memoryStream);
			}
		}
	}
}
