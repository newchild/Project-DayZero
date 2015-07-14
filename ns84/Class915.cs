using Microsoft.Xna.Framework.Graphics;
using ns24;
using ns26;
using ns29;
using ns77;
using ns8;
using ns91;
using osudata.Libraries.FFmpeg;
using System;

namespace ns84
{
	// Token: 0x020006BC RID: 1724
	internal sealed class Class915 : IDisposable
	{
		// Token: 0x04003206 RID: 12806
		private readonly Class731[] class731_0;

		// Token: 0x04003203 RID: 12803
		private readonly int int_0;

		// Token: 0x04003204 RID: 12804
		internal readonly int int_1;

		// Token: 0x04003207 RID: 12807
		private readonly int int_2;

		// Token: 0x04003208 RID: 12808
		private int int_3 = -1;

		// Token: 0x04003209 RID: 12809
		private int int_4;

		// Token: 0x0400320A RID: 12810
		private int int_5;

		// Token: 0x0400320B RID: 12811
		private int int_6;

		// Token: 0x0400320C RID: 12812
		internal int int_7;

		// Token: 0x04003205 RID: 12805
		private readonly VideoDecoder videoDecoder_0;

		// Token: 0x060035A4 RID: 13732
		// RVA: 0x0016F304 File Offset: 0x0016D504
		internal Class915(string string_0)
		{
			byte[] array = Class466.Current.method_63(string_0);
			this.videoDecoder_0 = new VideoDecoder((int)((float)Class331.smethod_67() / 100f * 4f));
			this.videoDecoder_0.Open(array);
			this.int_2 = this.videoDecoder_0.get_width();
			this.int_0 = this.videoDecoder_0.get_height();
			this.class731_0 = new Class731[1];
			this.Initialize();
			this.int_1 = (int)this.videoDecoder_0.get_Length() * 1000;
			Class115.smethod_53(new Delegate1(this.method_1));
			Class115.smethod_50(new Delegate1(this.method_0));
		}

		// Token: 0x060035AE RID: 13742
		// RVA: 0x000272F4 File Offset: 0x000254F4
		public void Dispose()
		{
			GC.SuppressFinalize(this);
			this.Dispose(true);
		}

		// Token: 0x060035AF RID: 13743
		// RVA: 0x0016F4E8 File Offset: 0x0016D6E8
		public void Dispose(bool bool_0)
		{
			if (this.videoDecoder_0 != null)
			{
				this.videoDecoder_0.Dispose();
			}
			if (this.class731_0 != null)
			{
				Class731[] array = this.class731_0;
				for (int i = 0; i < array.Length; i++)
				{
					Class731 class = array[i];
					if (class != null)
					{
						class.Dispose();
					}
				}
			}
			Class115.smethod_54(new Delegate1(this.method_1));
			Class115.smethod_51(new Delegate1(this.method_0));
		}

		// Token: 0x060035AD RID: 13741
		// RVA: 0x0016F4B8 File Offset: 0x0016D6B8
		~Class915()
		{
			this.Dispose(false);
		}

		// Token: 0x060035A7 RID: 13735
		// RVA: 0x0016F3C4 File Offset: 0x0016D5C4
		private void Initialize()
		{
			byte[] array = new byte[this.int_2 * this.int_0 * 4];
			for (int i = 0; i < array.Length - 1; i++)
			{
				array[i] = ((i % 4 == 3) ? 255 : 0);
			}
			for (int j = 0; j < 1; j++)
			{
				Texture2D texture2D_ = Class115.bool_26 ? new Texture2D(Class115.class125_0.GraphicsDevice, this.int_2, this.int_0, 1, 0, 2, 1) : null;
				Class748 class748_ = Class115.bool_27 ? new Class748(this.int_2, this.int_0) : null;
				this.class731_0[j] = new Class731(texture2D_, class748_, this.int_2, this.int_0);
				this.class731_0[j].method_5(array);
			}
		}

		// Token: 0x060035A5 RID: 13733
		// RVA: 0x000272B0 File Offset: 0x000254B0
		private void method_0(bool bool_0)
		{
			if (!bool_0)
			{
				return;
			}
			this.method_2();
		}

		// Token: 0x060035A6 RID: 13734
		// RVA: 0x000272BC File Offset: 0x000254BC
		private void method_1(bool bool_0)
		{
			if (!bool_0)
			{
				return;
			}
			this.Initialize();
		}

		// Token: 0x060035A8 RID: 13736
		// RVA: 0x0016F488 File Offset: 0x0016D688
		private void method_2()
		{
			for (int i = 0; i < 1; i++)
			{
				if (this.class731_0[i] != null)
				{
					this.class731_0[i].Dispose();
				}
			}
		}

		// Token: 0x060035A9 RID: 13737
		// RVA: 0x000272C8 File Offset: 0x000254C8
		internal double method_3()
		{
			return this.videoDecoder_0.get_CurrentTime();
		}

		// Token: 0x060035AA RID: 13738
		// RVA: 0x000272D5 File Offset: 0x000254D5
		internal Class731 method_4()
		{
			return this.class731_0[this.int_4];
		}

		// Token: 0x060035AB RID: 13739
		// RVA: 0x000272E4 File Offset: 0x000254E4
		internal int method_5()
		{
			return this.int_2;
		}

		// Token: 0x060035AC RID: 13740
		// RVA: 0x000272EC File Offset: 0x000254EC
		internal int method_6()
		{
			return this.int_0;
		}

		// Token: 0x060035B0 RID: 13744
		// RVA: 0x0016F554 File Offset: 0x0016D754
		internal void method_7()
		{
			byte[] frame = this.videoDecoder_0.GetFrame(Class331.int_8 - this.int_7);
			if (frame == null)
			{
				return;
			}
			this.int_5++;
			this.int_3 = 0;
			this.int_4 = 0;
			this.class731_0[this.int_3].method_5(frame);
		}

		// Token: 0x060035B1 RID: 13745
		// RVA: 0x00027303 File Offset: 0x00025503
		public void Seek(int int_8, bool bool_0)
		{
			if (int_8 - this.int_6 < 2000 && !bool_0)
			{
				return;
			}
			this.int_6 = int_8;
			this.videoDecoder_0.Seek(int_8);
		}
	}
}
