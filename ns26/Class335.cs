using ns24;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace ns26
{
	// Token: 0x02000342 RID: 834
	internal abstract class Class335 : IDisposable
	{
		// Token: 0x0400133C RID: 4924
		internal bool bool_0;

		// Token: 0x0400133D RID: 4925
		internal bool bool_1;

		// Token: 0x0400133F RID: 4927
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x04001341 RID: 4929
		[CompilerGenerated]
		private bool bool_3;

		// Token: 0x0400133B RID: 4923
		internal Class296 class296_0;

		// Token: 0x0400133E RID: 4926
		internal double double_0;

		// Token: 0x04001340 RID: 4928
		[CompilerGenerated]
		private int int_0;

		// Token: 0x1700035A RID: 858
		internal abstract double Position
		{
			// Token: 0x06001917 RID: 6423
			get;
		}

		// Token: 0x0600190F RID: 6415
		// RVA: 0x000154F2 File Offset: 0x000136F2
		public virtual void Dispose()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x0600190E RID: 6414
		// RVA: 0x00078884 File Offset: 0x00076A84
		~Class335()
		{
			if (!this.bool_0)
			{
				this.Dispose();
			}
		}

		// Token: 0x06001918 RID: 6424
		// RVA: 0x0001551E File Offset: 0x0001371E
		[CompilerGenerated]
		internal int method_0()
		{
			return this.int_0;
		}

		// Token: 0x06001919 RID: 6425
		// RVA: 0x00015526 File Offset: 0x00013726
		[CompilerGenerated]
		internal void method_1(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x0600191F RID: 6431
		// RVA: 0x0001552F File Offset: 0x0001372F
		internal void method_2()
		{
			this.vmethod_7();
			this.Seek(0.0);
		}

		// Token: 0x06001915 RID: 6421
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void Reset()
		{
		}

		// Token: 0x0600191A RID: 6426
		internal abstract void Seek(double double_1);

		// Token: 0x0600190D RID: 6413
		// RVA: 0x00078828 File Offset: 0x00076A28
		internal static Class335 smethod_0(Class296 class296_1, bool bool_4, bool bool_5)
		{
			Stream stream = class296_1.method_60();
			Class335 class;
			if (stream == null)
			{
				class = new Class337
				{
					double_0 = (double)((class296_1.int_16 < 0) ? 600000 : (class296_1.int_16 + 10000))
				};
			}
			else
			{
				class = new Class336(stream, bool_4, bool_5);
			}
			if (class != null)
			{
				class.class296_0 = class296_1;
			}
			return class;
		}

		// Token: 0x06001910 RID: 6416
		internal abstract float vmethod_0();

		// Token: 0x06001911 RID: 6417
		internal abstract void vmethod_1(float float_0);

		// Token: 0x06001920 RID: 6432
		public abstract double vmethod_10();

		// Token: 0x06001921 RID: 6433
		public abstract void vmethod_11(double double_1);

		// Token: 0x06001922 RID: 6434
		// RVA: 0x00015546 File Offset: 0x00013746
		[CompilerGenerated]
		public virtual bool vmethod_12()
		{
			return this.bool_3;
		}

		// Token: 0x06001923 RID: 6435
		// RVA: 0x0001554E File Offset: 0x0001374E
		[CompilerGenerated]
		public virtual void vmethod_13(bool bool_4)
		{
			this.bool_3 = bool_4;
		}

		// Token: 0x06001924 RID: 6436
		// RVA: 0x00015557 File Offset: 0x00013757
		internal virtual bool vmethod_14()
		{
			return this.class296_0 != null && this.class296_0.bool_17;
		}

		// Token: 0x06001912 RID: 6418
		// RVA: 0x00015504 File Offset: 0x00013704
		[CompilerGenerated]
		internal virtual bool vmethod_2()
		{
			return this.bool_2;
		}

		// Token: 0x06001913 RID: 6419
		// RVA: 0x0001550C File Offset: 0x0001370C
		[CompilerGenerated]
		internal virtual void vmethod_3(bool bool_4)
		{
			this.bool_2 = bool_4;
		}

		// Token: 0x06001914 RID: 6420
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal virtual bool vmethod_4()
		{
			return true;
		}

		// Token: 0x06001916 RID: 6422
		// RVA: 0x00015515 File Offset: 0x00013715
		internal virtual void vmethod_5(bool bool_4)
		{
			this.bool_1 = bool_4;
		}

		// Token: 0x0600191B RID: 6427
		internal abstract void vmethod_6(bool bool_4);

		// Token: 0x0600191C RID: 6428
		internal abstract void vmethod_7();

		// Token: 0x0600191D RID: 6429
		public abstract bool vmethod_8();

		// Token: 0x0600191E RID: 6430
		public abstract void vmethod_9();
	}
}
