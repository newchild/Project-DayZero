using System;
using System.IO;
using System.Runtime.InteropServices;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Fx;

namespace ns26
{
	// Token: 0x02000343 RID: 835
	internal sealed class Class336 : Class335
	{
		// Token: 0x0400134A RID: 4938
		private BASS_FILEPROCS bass_FILEPROCS_0;

		// Token: 0x04001349 RID: 4937
		internal bool bool_4;

		// Token: 0x0400134B RID: 4939
		private byte[] byte_0 = new byte[32768];

		// Token: 0x0400134D RID: 4941
		private double double_1 = 100.0;

		// Token: 0x04001346 RID: 4934
		internal Enum100 enum100_0;

		// Token: 0x04001347 RID: 4935
		private float float_0;

		// Token: 0x04001348 RID: 4936
		private float float_1;

		// Token: 0x0400134C RID: 4940
		private float float_2 = -1f;

		// Token: 0x04001342 RID: 4930
		internal int int_1;

		// Token: 0x04001343 RID: 4931
		internal int int_2;

		// Token: 0x04001344 RID: 4932
		internal int int_3;

		// Token: 0x04001345 RID: 4933
		internal Stream stream_0;

		// Token: 0x1700035B RID: 859
		internal override double Position
		{
			// Token: 0x06001933 RID: 6451
			// RVA: 0x000155DD File Offset: 0x000137DD
			get
			{
				return Bass.BASS_ChannelBytes2Seconds(base.method_0(), Bass.BASS_ChannelGetPosition(base.method_0())) * 1000.0;
			}
		}

		// Token: 0x06001926 RID: 6438
		// RVA: 0x000788B8 File Offset: 0x00076AB8
		internal Class336(Stream stream_1, bool bool_5, bool bool_6)
		{
			this.bass_FILEPROCS_0 = new BASS_FILEPROCS(new FILECLOSEPROC(this.method_5), new FILELENPROC(this.method_6), new FILEREADPROC(this.method_7), new FILESEEKPROC(this.method_8));
			this.vmethod_3(bool_5);
			this.bool_4 = bool_6;
			BASSFlag bASSFlag = this.vmethod_2() ? 0 : 2228224;
			this.stream_0 = stream_1;
			if (this.stream_0 == null)
			{
				throw new Exception11();
			}
			this.stream_0.Seek(0L, SeekOrigin.Begin);
			this.int_3 = Bass.BASS_StreamCreateFileUser(0, bASSFlag, this.bass_FILEPROCS_0, IntPtr.Zero);
			if (this.vmethod_2())
			{
				base.method_1(this.int_1 = this.int_3);
			}
			else
			{
				base.method_1(this.int_1 = BassFx.BASS_FX_TempoCreate(this.int_3, bool_6 ? 4 : 0));
				this.int_2 = BassFx.BASS_FX_ReverseCreate(this.int_3, 5f, 0);
				Bass.BASS_ChannelSetAttribute(base.method_0(), 65554, 1f);
				Bass.BASS_ChannelSetAttribute(base.method_0(), 65557, 4f);
				Bass.BASS_ChannelSetAttribute(base.method_0(), 65555, 30f);
			}
			this.double_0 = Bass.BASS_ChannelBytes2Seconds(base.method_0(), Bass.BASS_ChannelGetLength(base.method_0())) * 1000.0;
			Bass.BASS_ChannelGetAttribute(base.method_0(), 1, ref this.float_0);
			this.float_1 = this.float_0;
		}

		// Token: 0x06001929 RID: 6441
		// RVA: 0x0001556E File Offset: 0x0001376E
		public override void Dispose()
		{
			base.Dispose();
			this.enum100_0 = Enum100.const_0;
			this.method_3();
			if (this.stream_0 != null)
			{
				this.stream_0.Dispose();
				this.stream_0 = null;
			}
		}

		// Token: 0x06001928 RID: 6440
		// RVA: 0x00078AD8 File Offset: 0x00076CD8
		internal void method_3()
		{
			if (base.method_0() != 0)
			{
				Bass.BASS_ChannelStop(base.method_0());
			}
			if (this.int_1 != 0)
			{
				Bass.BASS_StreamFree(this.int_1);
			}
			if (this.int_2 != 0)
			{
				Bass.BASS_StreamFree(this.int_2);
			}
			if (this.int_3 != 0)
			{
				Bass.BASS_StreamFree(this.int_3);
			}
			base.method_1(0);
			this.int_1 = 0;
			this.int_2 = 0;
			this.int_3 = 0;
		}

		// Token: 0x0600192C RID: 6444
		// RVA: 0x00078B54 File Offset: 0x00076D54
		internal bool method_4()
		{
			if (this.bool_0)
			{
				return false;
			}
			if (1 == Bass.BASS_ChannelIsActive(base.method_0()))
			{
				Bass.BASS_ChannelPause(base.method_0());
				this.enum100_0 = Enum100.const_0;
				return true;
			}
			Bass.BASS_ChannelPlay(base.method_0(), false);
			this.enum100_0 = Enum100.const_1;
			return false;
		}

		// Token: 0x0600192F RID: 6447
		// RVA: 0x00078BA4 File Offset: 0x00076DA4
		private void method_5(IntPtr intptr_0)
		{
			if (this.stream_0 == null)
			{
				return;
			}
			try
			{
				this.stream_0.Close();
			}
			catch
			{
			}
		}

		// Token: 0x06001930 RID: 6448
		// RVA: 0x00078BDC File Offset: 0x00076DDC
		private long method_6(IntPtr intptr_0)
		{
			if (this.stream_0 == null)
			{
				return 0L;
			}
			try
			{
				return this.stream_0.Length;
			}
			catch
			{
			}
			return 0L;
		}

		// Token: 0x06001931 RID: 6449
		// RVA: 0x00078C28 File Offset: 0x00076E28
		private int method_7(IntPtr intptr_0, int int_4, IntPtr intptr_1)
		{
			if (this.stream_0 == null)
			{
				return 0;
			}
			try
			{
				if (int_4 > this.byte_0.Length)
				{
					this.byte_0 = new byte[int_4];
				}
				int result;
				if (!this.stream_0.CanRead)
				{
					result = 0;
					return result;
				}
				int num = this.stream_0.Read(this.byte_0, 0, int_4);
				Marshal.Copy(this.byte_0, 0, intptr_0, int_4);
				result = num;
				return result;
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06001932 RID: 6450
		// RVA: 0x00078CA4 File Offset: 0x00076EA4
		private bool method_8(long long_0, IntPtr intptr_0)
		{
			if (this.stream_0 == null)
			{
				return false;
			}
			try
			{
				return this.stream_0.Seek(long_0, SeekOrigin.Begin) == long_0;
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x0600193C RID: 6460
		// RVA: 0x00078CE4 File Offset: 0x00076EE4
		private void method_9()
		{
			if (!this.vmethod_12())
			{
				Bass.BASS_ChannelSetAttribute(base.method_0(), 1, (float)((double)this.float_1 * this.double_1 / 100.0));
				Bass.BASS_ChannelSetAttribute(base.method_0(), 65536, 0f);
				return;
			}
			Bass.BASS_ChannelSetAttribute(base.method_0(), 1, this.float_1);
			Bass.BASS_ChannelSetAttribute(base.method_0(), 65536, (float)(this.double_1 - 100.0));
		}

		// Token: 0x06001927 RID: 6439
		// RVA: 0x00078A70 File Offset: 0x00076C70
		internal override void Reset()
		{
			Bass.BASS_ChannelSetAttribute(base.method_0(), 2, Class331.smethod_77() / 100f);
			Bass.BASS_ChannelSetAttribute(base.method_0(), 1, this.float_0);
			Bass.BASS_ChannelSetAttribute(base.method_0(), 65536, (float)(Class331.smethod_67() - 100));
			this.float_1 = this.float_0;
			base.Reset();
		}

		// Token: 0x0600192E RID: 6446
		// RVA: 0x000155C4 File Offset: 0x000137C4
		internal override void Seek(double double_2)
		{
			Bass.BASS_ChannelSetPosition(base.method_0(), double_2 / 1000.0);
		}

		// Token: 0x06001935 RID: 6453
		// RVA: 0x0001560F File Offset: 0x0001380F
		internal override float vmethod_0()
		{
			return this.float_2;
		}

		// Token: 0x06001936 RID: 6454
		// RVA: 0x00015617 File Offset: 0x00013817
		internal override void vmethod_1(float float_3)
		{
			if (this.float_2 == float_3)
			{
				return;
			}
			this.float_2 = float_3;
			Bass.BASS_ChannelSetAttribute(this.int_1, 2, this.float_2);
			Bass.BASS_ChannelSetAttribute(this.int_2, 2, this.float_2);
		}

		// Token: 0x0600193A RID: 6458
		// RVA: 0x00015667 File Offset: 0x00013867
		public override double vmethod_10()
		{
			return this.double_1;
		}

		// Token: 0x0600193B RID: 6459
		// RVA: 0x0001566F File Offset: 0x0001386F
		public override void vmethod_11(double double_2)
		{
			if (double_2 == this.double_1)
			{
				return;
			}
			this.double_1 = double_2;
			this.method_9();
		}

		// Token: 0x06001938 RID: 6456
		// RVA: 0x00015650 File Offset: 0x00013850
		public override bool vmethod_12()
		{
			return base.vmethod_12();
		}

		// Token: 0x06001939 RID: 6457
		// RVA: 0x00015658 File Offset: 0x00013858
		public override void vmethod_13(bool bool_5)
		{
			base.vmethod_13(bool_5);
			this.method_9();
		}

		// Token: 0x0600192A RID: 6442
		// RVA: 0x00006D86 File Offset: 0x00004F86
		internal override bool vmethod_4()
		{
			return false;
		}

		// Token: 0x0600192D RID: 6445
		// RVA: 0x000155AE File Offset: 0x000137AE
		internal override void vmethod_6(bool bool_5)
		{
			this.enum100_0 = Enum100.const_1;
			Bass.BASS_ChannelPlay(base.method_0(), bool_5);
		}

		// Token: 0x0600192B RID: 6443
		// RVA: 0x0001559D File Offset: 0x0001379D
		internal override void vmethod_7()
		{
			if (this.vmethod_8())
			{
				this.method_4();
			}
		}

		// Token: 0x06001934 RID: 6452
		// RVA: 0x000155FF File Offset: 0x000137FF
		public override bool vmethod_8()
		{
			return Bass.BASS_ChannelIsActive(base.method_0()) == 1;
		}

		// Token: 0x06001937 RID: 6455
		// RVA: 0x0000653E File Offset: 0x0000473E
		public override void vmethod_9()
		{
		}
	}
}
