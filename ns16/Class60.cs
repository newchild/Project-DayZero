using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns25;
using ns29;
using ns40;
using ns77;
using ns79;
using ns80;
using ns82;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns16
{
	// Token: 0x02000398 RID: 920
	internal sealed class Class60 : Class57
	{
		// Token: 0x02000399 RID: 921
		[CompilerGenerated]
		private sealed class Class388
		{
			// Token: 0x0200039A RID: 922
			private sealed class Class389
			{
				// Token: 0x040016A1 RID: 5793
				public Class60.Class388 class388_0;

				// Token: 0x040016A2 RID: 5794
				public List<Color> list_0;

				// Token: 0x06001C73 RID: 7283
				// RVA: 0x000176CD File Offset: 0x000158CD
				public void method_0()
				{
					this.class388_0.class60_0.method_3(this.list_0, true);
					if (this.class388_0.voidDelegate_0 != null)
					{
						this.class388_0.voidDelegate_0();
					}
				}
			}

			// Token: 0x0400169E RID: 5790
			public Class60 class60_0;

			// Token: 0x0400169F RID: 5791
			public Stream stream_0;

			// Token: 0x040016A0 RID: 5792
			public VoidDelegate voidDelegate_0;

			// Token: 0x06001C71 RID: 7281
			// RVA: 0x000988F4 File Offset: 0x00096AF4
			public void method_0()
			{
				Class60.Class388.Class389 class = new Class60.Class388.Class389();
				class.class388_0 = this;
				class.list_0 = new List<Color>();
				if (this.stream_0 != null)
				{
					using (Bitmap bitmap = (Bitmap)Image.FromStream(this.stream_0, false, false))
					{
						for (int i = 0; i < 50; i++)
						{
							class.list_0.Add(Class778.smethod_5(bitmap.GetPixel(Class562.smethod_0(bitmap.Width), Class562.smethod_0(bitmap.Height))));
						}
					}
					this.stream_0.Dispose();
				}
				else
				{
					class.list_0.Add(new Color(255, 195, 83));
					class.list_0.Add(new Color(151, 1, 90));
					class.list_0.Add(new Color(47, 102, 159));
					class.list_0.Add(new Color(47, 102, 159));
					class.list_0.Add(new Color(255, 5, 76));
					for (int j = 0; j < 2; j++)
					{
						byte b = (byte)Class562.smethod_1(224, 256);
						class.list_0.Add(new Color(b, b, b));
					}
				}
				Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
			}
		}

		// Token: 0x04001693 RID: 5779
		internal bool bool_2 = true;

		// Token: 0x04001694 RID: 5780
		internal bool bool_3 = true;

		// Token: 0x04001695 RID: 5781
		internal bool bool_4 = true;

		// Token: 0x04001696 RID: 5782
		internal bool bool_5 = true;

		// Token: 0x04001697 RID: 5783
		internal bool bool_6 = true;

		// Token: 0x04001699 RID: 5785
		private bool bool_7 = true;

		// Token: 0x0400169A RID: 5786
		private Class911 class911_0 = new Class911(true);

		// Token: 0x04001691 RID: 5777
		internal float float_3 = 100f;

		// Token: 0x04001692 RID: 5778
		internal float float_4 = 1f;

		// Token: 0x04001698 RID: 5784
		internal float float_5 = 1.4f;

		// Token: 0x0400169D RID: 5789
		[CompilerGenerated]
		private List<Color> list_0;

		// Token: 0x0400169B RID: 5787
		private long long_0;

		// Token: 0x0400169C RID: 5788
		private Vector2? nullable_0 = null;

		// Token: 0x06001C69 RID: 7273
		// RVA: 0x000983B0 File Offset: 0x000965B0
		public Class60()
		{
			this.method_2(new List<Color>());
		}

		// Token: 0x06001C6C RID: 7276
		// RVA: 0x000176A5 File Offset: 0x000158A5
		protected override void Dispose(bool bool_8)
		{
			this.class911_0.Dispose();
			base.Dispose(bool_8);
		}

		// Token: 0x06001C6D RID: 7277
		// RVA: 0x000176B9 File Offset: 0x000158B9
		public override void Draw()
		{
			this.class911_0.Draw();
			base.Draw();
		}

		// Token: 0x06001C6E RID: 7278
		// RVA: 0x000984F0 File Offset: 0x000966F0
		public override void imethod_2()
		{
			base.imethod_2();
			if (Class115.double_9 > 50.0)
			{
				return;
			}
			if (this.bool_5)
			{
				if (Class79.bool_4)
				{
					this.class911_0.float_1 = Math.Max(0f, this.class911_0.float_1 - 0.01f * (float)Class115.double_0);
				}
				else
				{
					this.class911_0.float_1 = Math.Min(0.6f, this.class911_0.float_1 + 0.01f * (float)Class115.double_0);
				}
			}
			bool flag = this.bool_6 && Class115.double_9 > 16.666666666666668;
			if (Class115.bool_13)
			{
				long num;
				this.long_0 = (num = this.long_0) + 1L;
				if (num % (flag ? 10L : 6L) == 0L)
				{
					int num2 = 0;
					while ((float)num2 < this.float_3)
					{
						this.method_5(false);
						num2++;
					}
				}
			}
			if (this.bool_3)
			{
				float num3 = 0f;
				int num4 = 40;
				for (int i = 0; i < num4; i++)
				{
					num3 += 2f * this.float_1[i] * (float)(num4 - i) / (float)num4;
				}
				this.float_3 = Math.Max(this.float_3, (float)Math.Min((double)num3 * 1.5, 6.0));
			}
			if (this.bool_7)
			{
				this.float_3 *= 1f - 0.05f * (float)Class115.double_0;
			}
			float num5 = (this.float_4 + this.float_3) * (float)Class115.double_0 * 0.5f;
			using (List<Class530>.Enumerator enumerator = this.class911_0.list_2.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Class531 class = (Class531)enumerator.Current;
					Class531 expr_1C6_cp_0 = class;
					expr_1C6_cp_0.vector2_1.Y = expr_1C6_cp_0.vector2_1.Y - num5 * (0.2f + this.float_5 * (1f - class.float_2));
					if (!Class115.bool_16)
					{
						Class531 expr_200_cp_0 = class;
						expr_200_cp_0.vector2_1.Y = expr_200_cp_0.vector2_1.Y + Class802.vector2_3.Y / Class115.float_4 * (0.2f + (1f - class.float_2) / 1f) * 0.02f;
						Class531 expr_243_cp_0 = class;
						expr_243_cp_0.vector2_1.X = expr_243_cp_0.vector2_1.X + Class802.vector2_3.X / Class115.float_4 * (0.2f + (1f - class.float_2) / 1f) * 0.02f;
					}
					if (class.vector2_1.Y < -50f)
					{
						class.bool_0 = false;
					}
				}
			}
			if (this.bool_4)
			{
				this.class911_0.float_0 = (float)Math.Pow((double)Math.Max((float)(this.bool_3 ? 1 : 0), Math.Min(1f, num5 / 10f)), 3.0);
			}
		}

		// Token: 0x06001C67 RID: 7271
		// RVA: 0x00017694 File Offset: 0x00015894
		[CompilerGenerated]
		internal List<Color> method_1()
		{
			return this.list_0;
		}

		// Token: 0x06001C68 RID: 7272
		// RVA: 0x0001769C File Offset: 0x0001589C
		[CompilerGenerated]
		private void method_2(List<Color> list_1)
		{
			this.list_0 = list_1;
		}

		// Token: 0x06001C6A RID: 7274
		// RVA: 0x00098434 File Offset: 0x00096634
		internal void method_3(List<Color> list_1, bool bool_8)
		{
			this.method_2(list_1);
			if (bool_8)
			{
				using (List<Class530>.Enumerator enumerator = this.class911_0.list_2.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class531 class = (Class531)enumerator.Current;
						class.method_39(list_1[Class562.smethod_1(0, list_1.Count)], 0, false, Enum70.const_0);
					}
				}
			}
		}

		// Token: 0x06001C6B RID: 7275
		// RVA: 0x000984B4 File Offset: 0x000966B4
		internal void method_4(Stream stream_0, VoidDelegate voidDelegate_0)
		{
			Class60.Class388 class = new Class60.Class388();
			class.stream_0 = stream_0;
			class.voidDelegate_0 = voidDelegate_0;
			class.class60_0 = this;
			Class115.smethod_88(new VoidDelegate(class.method_0), false, ThreadPriority.Normal);
		}

		// Token: 0x06001C6F RID: 7279
		// RVA: 0x0009880C File Offset: 0x00096A0C
		private void method_5(bool bool_8)
		{
			if (this.bool_2 && this.method_1().Count != 0)
			{
				Color color_ = this.method_1()[Class562.smethod_1(0, this.method_1().Count)];
				float num = Class562.smethod_6(0.2f, 1f);
				Class731 class = Class885.Load("triangle", ((Class809.class623_0 & Enum30.flag_3) > Enum30.flag_0) ? Enum112.flag_6 : Enum112.flag_1);
				class.bool_1 = false;
				Class531 class530_ = new Class531(class, Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(Class562.smethod_5((float)Class115.smethod_43()), bool_8 ? Class562.smethod_5((float)Class115.smethod_44()) : ((float)Class115.smethod_44() + 50f)), 0.8f - num * 0.01f, true, Color.get_White(), null)
				{
					color_0 = color_,
					float_2 = num
				};
				this.class911_0.Add(class530_);
				return;
			}
		}
	}
}
