using ns29;
using ns8;
using osu_common.Helpers;
using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns77
{
	// Token: 0x0200047D RID: 1149
	internal sealed class Class523 : Class520
	{
		// Token: 0x0200047E RID: 1150
		[CompilerGenerated]
		private sealed class Class581
		{
			// Token: 0x04001EB2 RID: 7858
			public bool bool_0;

			// Token: 0x04001EB3 RID: 7859
			public bool bool_1;

			// Token: 0x04001EB1 RID: 7857
			public Class523 class523_0;

			// Token: 0x06002500 RID: 9472
			// RVA: 0x000DEA2C File Offset: 0x000DCC2C
			public void method_0()
			{
				if (this.class523_0.bool_1)
				{
					return;
				}
				this.class523_0.bool_0 = (this.class523_0.delegate2_0 == null || !this.bool_1 || this.class523_0.delegate2_0(this.bool_0));
				if (this.class523_0.bool_0)
				{
					Class115.bool_31 = false;
				}
			}
		}

		// Token: 0x04001EAB RID: 7851
		public bool bool_0;

		// Token: 0x04001EB0 RID: 7856
		private bool bool_1;

		// Token: 0x04001EAD RID: 7853
		private Delegate2 delegate2_0;

		// Token: 0x04001EAF RID: 7855
		public Exception exception_0;

		// Token: 0x04001EAE RID: 7854
		private Thread thread_0;

		// Token: 0x04001EAC RID: 7852
		private VoidDelegate voidDelegate_0;

		// Token: 0x060024FA RID: 9466
		// RVA: 0x0001CDB8 File Offset: 0x0001AFB8
		public Class523(VoidDelegate voidDelegate_1, Delegate2 delegate2_1) : base(false)
		{
			Class115.bool_31 = true;
			this.voidDelegate_0 = voidDelegate_1;
			this.delegate2_0 = delegate2_1;
			this.thread_0 = Class115.smethod_87(new VoidDelegate(this.method_0));
		}

		// Token: 0x060024FE RID: 9470
		// RVA: 0x000DE9DC File Offset: 0x000DCBDC
		internal override void Dispose(bool bool_2)
		{
			this.bool_1 = true;
			if (this.thread_0 != null && this.thread_0.IsAlive && this.thread_0 != Class115.thread_2)
			{
				this.thread_0.Abort();
			}
			Class115.bool_31 = false;
			base.Dispose(bool_2);
		}

		// Token: 0x060024FB RID: 9467
		// RVA: 0x000DE938 File Offset: 0x000DCB38
		private void method_0()
		{
			if (this.bool_1)
			{
				return;
			}
			bool bool_ = true;
			try
			{
				this.voidDelegate_0();
			}
			catch (Exception ex)
			{
				bool_ = false;
				this.exception_0 = ex;
			}
			if (this.bool_1)
			{
				return;
			}
			this.method_2(bool_, true);
		}

		// Token: 0x060024FC RID: 9468
		// RVA: 0x0001CDEC File Offset: 0x0001AFEC
		internal void method_1()
		{
			this.method_2(true, false);
		}

		// Token: 0x060024FD RID: 9469
		// RVA: 0x000DE98C File Offset: 0x000DCB8C
		private void method_2(bool bool_2, bool bool_3)
		{
			Class523.Class581 class = new Class523.Class581();
			class.bool_0 = bool_2;
			class.bool_1 = bool_3;
			class.class523_0 = this;
			if (this.bool_0 && !class.bool_0)
			{
				return;
			}
			Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
		}
	}
}
