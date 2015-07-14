using System;
using System.Text;
using System.Threading;

namespace ns30
{
	// Token: 0x02000227 RID: 551
	internal sealed class Class133 : Class129
	{
		// Token: 0x02000228 RID: 552
		// Token: 0x06001379 RID: 4985
		internal delegate void Delegate17(string string_0, Exception exception_0);

		// Token: 0x04000E9E RID: 3742
		private Class133.Delegate17 delegate17_0;

		// Token: 0x04000E9D RID: 3741
		private Class129.Delegate5 delegate5_0;

		// Token: 0x06001372 RID: 4978
		// RVA: 0x00010D1F File Offset: 0x0000EF1F
		public Class133(string string_1) : base(string_1)
		{
		}

		// Token: 0x06001371 RID: 4977
		// RVA: 0x00011FF9 File Offset: 0x000101F9
		public Class133(string string_1, string[] string_2) : base(string.Format(string_1, string_2))
		{
		}

		// Token: 0x06001373 RID: 4979
		// RVA: 0x00064288 File Offset: 0x00062488
		public void method_0(Class133.Delegate17 delegate17_1)
		{
			Class133.Delegate17 delegate = this.delegate17_0;
			Class133.Delegate17 delegate2;
			do
			{
				delegate2 = delegate;
				Class133.Delegate17 value = (Class133.Delegate17)Delegate.Combine(delegate2, delegate17_1);
				delegate = Interlocked.CompareExchange<Class133.Delegate17>(ref this.delegate17_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06001374 RID: 4980
		// RVA: 0x000642C0 File Offset: 0x000624C0
		public void method_1(Class133.Delegate17 delegate17_1)
		{
			Class133.Delegate17 delegate = this.delegate17_0;
			Class133.Delegate17 delegate2;
			do
			{
				delegate2 = delegate;
				Class133.Delegate17 value = (Class133.Delegate17)Delegate.Remove(delegate2, delegate17_1);
				delegate = Interlocked.CompareExchange<Class133.Delegate17>(ref this.delegate17_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06001376 RID: 4982
		// RVA: 0x000642F8 File Offset: 0x000624F8
		public string method_2(bool bool_2)
		{
			if (this.delegate5_0 != null)
			{
				this.delegate5_0();
			}
			string text = null;
			try
			{
				Class162 class = new Class162();
				string[] array = class.Get(this.string_0);
				class.Close();
				StringBuilder stringBuilder = new StringBuilder();
				int num = array.Length;
				for (int i = 0; i < num; i++)
				{
					stringBuilder.Append(((i > 0) ? "\n" : "") + array[i]);
				}
				text = stringBuilder.ToString();
				if (this.delegate17_0 != null)
				{
					this.delegate17_0(text, null);
				}
			}
			catch (Exception ex)
			{
				if (this.delegate17_0 != null)
				{
					this.delegate17_0(text, ex);
				}
				if (bool_2 && !(ex is ThreadAbortException))
				{
					throw;
				}
			}
			return text;
		}

		// Token: 0x06001375 RID: 4981
		// RVA: 0x00012008 File Offset: 0x00010208
		public override void Perform(bool bool_2)
		{
			this.method_2(bool_2);
		}

		// Token: 0x06001377 RID: 4983
		// RVA: 0x000643C8 File Offset: 0x000625C8
		public override void vmethod_0(Exception exception_0)
		{
			Console.Write("exception! - url " + this.string_0);
			if (this.delegate17_0 != null)
			{
				try
				{
					this.delegate17_0(null, exception_0);
				}
				catch
				{
				}
			}
		}
	}
}
