using ns30;
using ns8;
using System;
using System.IO;
using System.Threading;

namespace osu_common.Libraries.NetLib
{
	// Token: 0x020001FF RID: 511
	public sealed class FileNetRequest : Class129
	{
		// Token: 0x02000200 RID: 512
		// Token: 0x06001203 RID: 4611
		internal delegate void Delegate10(string string_0, Exception exception_0);

		// Token: 0x04000DF5 RID: 3573
		private Class162 class162_0;

		// Token: 0x04000DF8 RID: 3576
		private FileNetRequest.Delegate10 delegate10_0;

		// Token: 0x04000DF6 RID: 3574
		private Class129.Delegate5 delegate5_0;

		// Token: 0x04000DF7 RID: 3575
		private Class129.Delegate6 delegate6_0;

		// Token: 0x04000DF9 RID: 3577
		private FileStream fileStream_0;

		// Token: 0x04000DF4 RID: 3572
		public string string_1;

		// Token: 0x060011FA RID: 4602
		// RVA: 0x00010F53 File Offset: 0x0000F153
		public FileNetRequest(string string_2, string string_3) : base(string_3)
		{
			this.string_1 = string_2;
		}

		// Token: 0x06001200 RID: 4608
		// RVA: 0x00060BBC File Offset: 0x0005EDBC
		public override void Abort()
		{
			try
			{
				if (this.class162_0 != null)
				{
					this.class162_0.Close();
				}
				if (this.fileStream_0 != null)
				{
					this.fileStream_0.Close();
				}
				File.Delete(this.string_1);
			}
			catch
			{
			}
			if (this.delegate10_0 != null)
			{
				this.delegate10_0(this.string_1, new Exception("aborted"));
			}
		}

		// Token: 0x060011FB RID: 4603
		// RVA: 0x00060990 File Offset: 0x0005EB90
		public void method_0(Class129.Delegate5 delegate5_1)
		{
			Class129.Delegate5 delegate = this.delegate5_0;
			Class129.Delegate5 delegate2;
			do
			{
				delegate2 = delegate;
				Class129.Delegate5 value = (Class129.Delegate5)Delegate.Combine(delegate2, delegate5_1);
				delegate = Interlocked.CompareExchange<Class129.Delegate5>(ref this.delegate5_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x060011FC RID: 4604
		// RVA: 0x000609C8 File Offset: 0x0005EBC8
		public void method_1(Class129.Delegate6 delegate6_1)
		{
			Class129.Delegate6 delegate = this.delegate6_0;
			Class129.Delegate6 delegate2;
			do
			{
				delegate2 = delegate;
				Class129.Delegate6 value = (Class129.Delegate6)Delegate.Combine(delegate2, delegate6_1);
				delegate = Interlocked.CompareExchange<Class129.Delegate6>(ref this.delegate6_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x060011FD RID: 4605
		// RVA: 0x00060A00 File Offset: 0x0005EC00
		public void method_2(FileNetRequest.Delegate10 delegate10_1)
		{
			FileNetRequest.Delegate10 delegate = this.delegate10_0;
			FileNetRequest.Delegate10 delegate2;
			do
			{
				delegate2 = delegate;
				FileNetRequest.Delegate10 value = (FileNetRequest.Delegate10)Delegate.Combine(delegate2, delegate10_1);
				delegate = Interlocked.CompareExchange<FileNetRequest.Delegate10>(ref this.delegate10_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x060011FF RID: 4607
		// RVA: 0x00060B68 File Offset: 0x0005ED68
		private void method_3(object sender, EventArgs6 e)
		{
			if (this.delegate6_0 != null)
			{
				this.delegate6_0(this, Math.Max(0L, Math.Min(e.method_1(), e.method_0())), Math.Max(e.method_0(), e.method_1()));
			}
		}

		// Token: 0x060011FE RID: 4606
		// RVA: 0x00060A38 File Offset: 0x0005EC38
		public override void Perform(bool bool_2)
		{
			if (this.delegate5_0 != null)
			{
				this.delegate5_0();
			}
			string directoryName = Path.GetDirectoryName(this.string_1);
			if (directoryName != string.Empty && !Directory.Exists(directoryName))
			{
				Directory.CreateDirectory(directoryName);
			}
			using (this.fileStream_0 = new FileStream(this.string_1, FileMode.Create, FileAccess.Write, FileShare.Write, 4096))
			{
				try
				{
					this.class162_0 = new Class162();
					this.class162_0.method_32(new Delegate16(this.method_3));
					this.class162_0.Get(this.string_0, this.fileStream_0);
					this.class162_0.Close();
				}
				catch (Exception ex)
				{
					if (this.delegate10_0 != null)
					{
						this.delegate10_0(this.string_1, ex);
					}
					this.fileStream_0.Close();
					Class34.smethod_18(this.string_1);
					if (bool_2 && !(ex is ThreadAbortException))
					{
						throw;
					}
					return;
				}
			}
			if (this.delegate10_0 != null)
			{
				this.delegate10_0(this.string_1, null);
			}
		}

		// Token: 0x06001201 RID: 4609
		// RVA: 0x00010F63 File Offset: 0x0000F163
		public override void vmethod_0(Exception exception_0)
		{
			if (this.delegate10_0 != null)
			{
				this.delegate10_0(null, exception_0);
			}
		}
	}
}
