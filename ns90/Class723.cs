using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns18;
using ns29;
using ns64;
using ns77;
using ns79;
using ns82;
using ns84;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns90
{
	// Token: 0x0200055F RID: 1375
	internal static class Class723
	{
		// Token: 0x02000560 RID: 1376
		[CompilerGenerated]
		private sealed class Class724
		{
			// Token: 0x040024E3 RID: 9443
			public int int_0;

			// Token: 0x040024E2 RID: 9442
			public string string_0;

			// Token: 0x06002CA1 RID: 11425
			// RVA: 0x0012160C File Offset: 0x0011F80C
			public void method_0()
			{
				int int_ = Class115.int_1;
				if (Class723.class533_0 != null && Class723.class533_0.float_3 > 0f)
				{
					Class723.smethod_3();
				}
				Class723.class533_0 = new Class533(this.string_0, 18f, new Vector2((float)(Class115.smethod_43() / 2), 240f), new Vector2((float)Class115.int_22 / Class115.float_4, 0f), 1f, false, Color.get_White(), false);
				Class723.class533_0.origins_0 = Origins.TopCentre;
				Class723.class533_0.enum72_0 = Enum72.const_2;
				Class723.class533_0.method_59(true);
				Class723.class533_0.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, int_, int_ + 100, Enum70.const_0));
				Class723.class533_0.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, int_ + this.int_0, int_ + this.int_0 + 150, Enum70.const_0));
				if (Class115.class911_3 != null)
				{
					Class115.class911_3.Add(Class723.class533_0);
				}
				float num = Class723.class533_0.vmethod_11().Y;
				Class533 expr_118_cp_0 = Class723.class533_0;
				expr_118_cp_0.vector2_1.Y = expr_118_cp_0.vector2_1.Y - num / 2f;
				num *= 1.5f;
				Class723.class531_0 = new Class531(Class115.class731_0, new Vector2(0f, 240f - num / 2f), 0.999f, false, new Color(0, 0, 0, 180));
				Class723.class531_0.float_2 = 1.6f;
				Class723.class531_0.origins_0 = Origins.TopLeft;
				Class723.class531_0.vector2_2 = new Vector2((float)Class115.smethod_43(), num);
				Class723.class531_0.class26_0.Add(new Class746(TransformationType.VectorScale, new Vector2((float)Class115.smethod_43(), 0f), Class723.class531_0.vector2_2, int_, int_ + 300, Enum70.const_30));
				Class723.class531_0.class26_0.Add(new Class746(new Vector2(0f, 240f), Class723.class531_0.vector2_0, int_, int_ + 300, Enum70.const_30));
				Class723.class531_0.class26_0.Add(new Class746(TransformationType.Fade, 0.7058824f, 0f, int_ + this.int_0, int_ + this.int_0 + 150, Enum70.const_0));
				if (Class115.class911_3 != null)
				{
					Class115.class911_3.Add(Class723.class531_0);
				}
			}
		}

		// Token: 0x02000561 RID: 1377
		[CompilerGenerated]
		private sealed class Class725
		{
			// Token: 0x040024E4 RID: 9444
			public string string_0;

			// Token: 0x06002CA3 RID: 11427
			// RVA: 0x00021D04 File Offset: 0x0001FF04
			public void method_0()
			{
				Class723.smethod_6(new Class722(this.string_0, this.string_0.Length * 100, Color.get_DarkRed(), null));
			}
		}

		// Token: 0x02000562 RID: 1378
		[CompilerGenerated]
		private sealed class Class726
		{
			// Token: 0x040024E6 RID: 9446
			public Color color_0;

			// Token: 0x040024E7 RID: 9447
			public int int_0;

			// Token: 0x040024E5 RID: 9445
			public string string_0;

			// Token: 0x040024E8 RID: 9448
			public VoidDelegate voidDelegate_0;

			// Token: 0x06002CA5 RID: 11429
			// RVA: 0x00021D2A File Offset: 0x0001FF2A
			public void method_0()
			{
				Class723.smethod_6(new Class722(this.string_0, this.int_0, this.color_0, this.voidDelegate_0));
			}
		}

		// Token: 0x02000563 RID: 1379
		[CompilerGenerated]
		private sealed class Class727
		{
			// Token: 0x02000564 RID: 1380
			private sealed class Class728
			{
				// Token: 0x040024EB RID: 9451
				public Class723.Class727 class727_0;

				// Token: 0x040024EC RID: 9452
				public float float_0;

				// Token: 0x06002CAA RID: 11434
				// RVA: 0x00021D4E File Offset: 0x0001FF4E
				public void method_0(Class530 class530_0)
				{
					class530_0.method_23(new Vector2(0f, -this.float_0), 800, Enum70.const_27);
				}
			}

			// Token: 0x040024E9 RID: 9449
			public Class722 class722_0;

			// Token: 0x040024EA RID: 9450
			private static Predicate<Class746> predicate_0;

			// Token: 0x06002CA7 RID: 11431
			// RVA: 0x00121878 File Offset: 0x0011FA78
			public void method_0()
			{
				Class723.Class727.Class728 class = new Class723.Class727.Class728();
				class.class727_0 = this;
				List<Class530> list = Class115.class911_3.method_11("notice");
				foreach (Class530 current in list)
				{
					List<Class746> arg_53_0 = current.class26_0;
					if (Class723.Class727.predicate_0 == null)
					{
						Class723.Class727.predicate_0 = new Predicate<Class746>(Class723.Class727.smethod_0);
					}
					Class746 class2 = arg_53_0.Find(Class723.Class727.predicate_0);
					if (class2 != null)
					{
						current.vector2_1 = class2.vector2_1;
						current.class26_0.Remove(class2);
					}
				}
				class.float_0 = this.class722_0.method_5();
				list.ForEach(new Action<Class530>(class.method_0));
				Class115.class911_3.Add<Class531>(this.class722_0.list_0);
			}

			// Token: 0x06002CA8 RID: 11432
			// RVA: 0x0001925A File Offset: 0x0001745A
			private static bool smethod_0(Class746 class746_0)
			{
				return class746_0.transformationType_0 == TransformationType.Movement;
			}
		}

		// Token: 0x040024DE RID: 9438
		private static Class531 class531_0;

		// Token: 0x040024DD RID: 9437
		private static Class533 class533_0;

		// Token: 0x040024DF RID: 9439
		private static Class722 class722_0;

		// Token: 0x040024E0 RID: 9440
		private static Enum67 enum67_0 = Enum67.const_1;

		// Token: 0x040024DC RID: 9436
		private static int int_0;

		// Token: 0x040024DB RID: 9435
		private static readonly Queue<Class722> queue_0 = new Queue<Class722>();

		// Token: 0x040024E1 RID: 9441
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_0;

		// Token: 0x06002C95 RID: 11413
		// RVA: 0x00021CA5 File Offset: 0x0001FEA5
		private static bool smethod_0()
		{
			return (!Class62.bool_12 || Class341.class606_50) && Class802.bool_13;
		}

		// Token: 0x06002C96 RID: 11414
		// RVA: 0x0012132C File Offset: 0x0011F52C
		internal static void smethod_1(string string_0, int int_1)
		{
			Class723.Class724 class = new Class723.Class724();
			class.string_0 = string_0;
			class.int_0 = int_1;
			if (class.string_0 == null)
			{
				return;
			}
			if (Class115.bool_16)
			{
				Class621.smethod_0(class.string_0);
				return;
			}
			Class115.class47_0.Add(new VoidDelegate(class.method_0), true);
		}

		// Token: 0x06002C97 RID: 11415
		// RVA: 0x00021CC1 File Offset: 0x0001FEC1
		internal static void smethod_2(object sender, EventArgs e)
		{
			Class723.smethod_3();
		}

		// Token: 0x06002C98 RID: 11416
		// RVA: 0x00021CC8 File Offset: 0x0001FEC8
		internal static void smethod_3()
		{
			Class47 arg_23_0 = Class115.class47_0;
			if (Class723.voidDelegate_0 == null)
			{
				Class723.voidDelegate_0 = new VoidDelegate(Class723.smethod_9);
			}
			arg_23_0.Add(Class723.voidDelegate_0, false);
		}

		// Token: 0x06002C99 RID: 11417
		// RVA: 0x00121380 File Offset: 0x0011F580
		internal static void smethod_4(string string_0)
		{
			Class723.Class725 class = new Class723.Class725();
			class.string_0 = string_0;
			Class115.class47_0.Add(new VoidDelegate(class.method_0), true);
		}

		// Token: 0x06002C9A RID: 11418
		// RVA: 0x001213B4 File Offset: 0x0011F5B4
		internal static void smethod_5(string string_0, Color color_0, int int_1, VoidDelegate voidDelegate_1)
		{
			Class723.Class726 class = new Class723.Class726();
			class.string_0 = string_0;
			class.color_0 = color_0;
			class.int_0 = int_1;
			class.voidDelegate_0 = voidDelegate_1;
			Class115.class47_0.Add(new VoidDelegate(class.method_0), true);
		}

		// Token: 0x06002C9B RID: 11419
		// RVA: 0x001213FC File Offset: 0x0011F5FC
		internal static void smethod_6(Class722 class722_1)
		{
			Class723.Class727 class = new Class723.Class727();
			class.class722_0 = class722_1;
			if (Class115.bool_16)
			{
				Class621.smethod_0(class.class722_0.string_0);
				return;
			}
			if (Class723.class722_0 != null && class.class722_0.string_0 == Class723.class722_0.string_0 && Class723.class722_0.method_0() + Class723.class722_0.int_0 > Class115.int_1)
			{
				return;
			}
			if (!Class723.smethod_0())
			{
				Class723.queue_0.Enqueue(class.class722_0);
				return;
			}
			Class723.class722_0 = class.class722_0;
			Class115.class47_0.Add(new VoidDelegate(class.method_0), true);
		}

		// Token: 0x06002C9C RID: 11420
		// RVA: 0x001214A8 File Offset: 0x0011F6A8
		internal static void smethod_7()
		{
			if (Class723.smethod_0())
			{
				if (Class115.int_1 > Class723.int_0 + 500 && Class723.queue_0.Count > 0)
				{
					Class723.int_0 = Class115.int_1;
					Class722 class722_ = Class723.queue_0.Dequeue();
					Class723.smethod_6(class722_);
					return;
				}
			}
			else if (!Class341.class606_50 && Class62.bool_12 && Class723.int_0 > 0)
			{
				Class723.int_0 = 0;
				using (List<Class530>.Enumerator enumerator = Class115.class911_3.method_11("notice").GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class531 class = (Class531)enumerator.Current;
						class.bool_0 = false;
						class.method_16(100, Enum70.const_0);
					}
				}
			}
		}

		// Token: 0x06002C9D RID: 11421
		// RVA: 0x0012157C File Offset: 0x0011F77C
		public static DialogResult smethod_8(string string_0, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
		{
			Class115.smethod_6(true);
			DialogResult result = MessageBox.Show(string_0, "osu!", messageBoxButtons_0, messageBoxIcon_0);
			Class115.smethod_6(false);
			return result;
		}

		// Token: 0x06002C9E RID: 11422
		// RVA: 0x001215A4 File Offset: 0x0011F7A4
		[CompilerGenerated]
		private static void smethod_9()
		{
			if (Class723.class533_0 == null)
			{
				return;
			}
			Class723.class533_0.method_16(300, Enum70.const_0);
			Class723.class533_0.method_23(new Vector2(0f, 15f), 600, Enum70.const_2);
			Class723.class533_0.bool_1 = false;
			Class723.class531_0.method_16(300, Enum70.const_0);
			Class723.class533_0 = null;
		}
	}
}
