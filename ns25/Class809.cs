using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns15;
using ns16;
using ns18;
using ns24;
using ns26;
using ns29;
using ns3;
using ns30;
using ns4;
using ns40;
using ns5;
using ns6;
using ns64;
using ns7;
using ns76;
using ns77;
using ns78;
using ns79;
using ns8;
using ns80;
using ns82;
using ns90;
using osu;
using osu.Graphics.Sprites;
using osu_common;
using osu_common.Bancho;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace ns25
{
	// Token: 0x02000616 RID: 1558
	internal static class Class809
	{
		// Token: 0x02000617 RID: 1559
		[CompilerGenerated]
		private sealed class Class810
		{
			// Token: 0x02000618 RID: 1560
			private sealed class Class811
			{
				// Token: 0x04002C44 RID: 11332
				public Class531 class531_0;

				// Token: 0x04002C43 RID: 11331
				public Class809.Class810 class810_0;

				// Token: 0x06003086 RID: 12422
				// RVA: 0x00023FCD File Offset: 0x000221CD
				public void method_0()
				{
					Class802.bool_13 = false;
					Class331.class608_2.Value = 0;
					Class115.class911_3.Add(this.class531_0);
				}
			}

			// Token: 0x04002C37 RID: 11319
			public Class11 class11_0;

			// Token: 0x04002C3E RID: 11326
			public Class13 class13_0;

			// Token: 0x04002C40 RID: 11328
			public Class16 class16_0;

			// Token: 0x04002C3D RID: 11325
			public Class17 class17_0;

			// Token: 0x04002C3A RID: 11322
			public Class19 class19_0;

			// Token: 0x04002C3B RID: 11323
			public int int_0;

			// Token: 0x04002C38 RID: 11320
			public string string_0;

			// Token: 0x04002C39 RID: 11321
			public string string_1;

			// Token: 0x04002C3F RID: 11327
			public string string_2;

			// Token: 0x04002C41 RID: 11329
			public string string_3;

			// Token: 0x04002C3C RID: 11324
			public Struct14 struct14_0;

			// Token: 0x04002C42 RID: 11330
			private static VoidDelegate voidDelegate_0;

			// Token: 0x06003077 RID: 12407
			// RVA: 0x00023F1B File Offset: 0x0002211B
			public void method_0()
			{
				Class111.smethod_24(this.class11_0, false, true);
			}

			// Token: 0x06003078 RID: 12408
			// RVA: 0x00023F2A File Offset: 0x0002212A
			public void method_1()
			{
				Class111.smethod_29(this.string_0, this.string_1);
			}

			// Token: 0x06003081 RID: 12417
			// RVA: 0x00023F87 File Offset: 0x00022187
			public void method_10()
			{
				Class115.smethod_88(new VoidDelegate(this.method_12), false, ThreadPriority.Normal);
			}

			// Token: 0x06003082 RID: 12418
			// RVA: 0x00023F9D File Offset: 0x0002219D
			public bool method_11(Class527 class527_0)
			{
				return class527_0.class861_0 != null && class527_0.class861_0.int_1 == this.class19_0.int_2;
			}

			// Token: 0x06003083 RID: 12419
			// RVA: 0x0013AAE4 File Offset: 0x00138CE4
			public void method_12()
			{
				Class809.Class810.Class811 class = new Class809.Class810.Class811();
				class.class810_0 = this;
				Class115.class47_0.Add(new VoidDelegate(Class115.smethod_26), false);
				int value = Class331.class608_2.Value;
				class.class531_0 = new Class531(Class115.class731_0, Enum115.const_4, Origins.TopLeft, Enum114.const_0, Vector2.get_Zero(), 0f, true, Color.get_Black(), null);
				class.class531_0.vector2_2 = new Vector2((float)Class115.int_22, (float)(Class115.int_23 + Class115.int_25));
				class.class531_0.float_3 = 1f;
				Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
				Class723.smethod_1(this.string_3, 5000);
				Console.Beep(2000, 100);
				Console.Beep(2600, 100);
				Thread.Sleep(100);
				class.class531_0.method_17(5000);
				class.class531_0.bool_0 = false;
				Class47 arg_10B_0 = Class115.class47_0;
				if (Class809.Class810.voidDelegate_0 == null)
				{
					Class809.Class810.voidDelegate_0 = new VoidDelegate(Class809.Class810.smethod_0);
				}
				arg_10B_0.Add(Class809.Class810.voidDelegate_0, false);
				Thread.Sleep(2000);
				Class802.bool_13 = true;
				Class331.class608_2.Value = value;
			}

			// Token: 0x06003079 RID: 12409
			// RVA: 0x0013A9A8 File Offset: 0x00138BA8
			public void method_2()
			{
				Class111.smethod_62(this.class19_0);
				Class527 class = Class527.list_0.Find(new Predicate<Class527>(this.method_11));
				if (class != null)
				{
					class.class861_1.method_6(this.class19_0);
				}
				if (this.class19_0.int_2 == Class115.class861_0.int_1)
				{
					Class115.class861_0.method_6(this.class19_0);
					Class111.smethod_4(this.class19_0.class12_0.playModes_0);
				}
			}

			// Token: 0x0600307A RID: 12410
			// RVA: 0x00023F3D File Offset: 0x0002213D
			public void method_3()
			{
				Class111.smethod_59(this.int_0);
			}

			// Token: 0x0600307B RID: 12411
			// RVA: 0x0013AA28 File Offset: 0x00138C28
			public void method_4()
			{
				foreach (int current in this.struct14_0.list_0)
				{
					Class111.smethod_59(current);
				}
			}

			// Token: 0x0600307C RID: 12412
			// RVA: 0x0013AA80 File Offset: 0x00138C80
			public void method_5()
			{
				Class111.smethod_60(this.class17_0);
				if (this.class17_0.int_1 == Class115.class861_0.int_1 && this.class17_0.bool_0)
				{
					Class115.class861_0.method_5(this.class17_0);
					Class341.class605_20.Value = this.class17_0.string_0;
				}
			}

			// Token: 0x0600307D RID: 12413
			// RVA: 0x00023F4A File Offset: 0x0002214A
			public void method_6()
			{
				Class858.smethod_0(this.class13_0);
			}

			// Token: 0x0600307E RID: 12414
			// RVA: 0x00023F57 File Offset: 0x00022157
			public bool method_7(Class21 class21_0)
			{
				return class21_0.string_0 == this.string_2;
			}

			// Token: 0x0600307F RID: 12415
			// RVA: 0x00023F6A File Offset: 0x0002216A
			public void method_8()
			{
				Class111.smethod_8(this.string_2, true, true);
			}

			// Token: 0x06003080 RID: 12416
			// RVA: 0x00023F7A File Offset: 0x0002217A
			public void method_9()
			{
				Class466.smethod_6(this.class16_0);
			}

			// Token: 0x06003084 RID: 12420
			// RVA: 0x00023FC1 File Offset: 0x000221C1
			private static void smethod_0()
			{
				Thread.Sleep(2000);
			}
		}

		// Token: 0x02000619 RID: 1561
		[CompilerGenerated]
		private sealed class Class812
		{
			// Token: 0x04002C45 RID: 11333
			public Class809.Class810 class810_0;

			// Token: 0x04002C46 RID: 11334
			public string string_0;

			// Token: 0x06003088 RID: 12424
			// RVA: 0x0013AC1C File Offset: 0x00138E1C
			public void method_0()
			{
				Class809.smethod_43(new string[]
				{
					this.string_0
				});
			}
		}

		// Token: 0x0200061A RID: 1562
		[CompilerGenerated]
		private sealed class Class813
		{
			// Token: 0x04002C48 RID: 11336
			public Class10 class10_0;

			// Token: 0x04002C47 RID: 11335
			public Class809.Class810 class810_0;

			// Token: 0x0600308A RID: 12426
			// RVA: 0x00023FF0 File Offset: 0x000221F0
			public void method_0()
			{
				Class70.smethod_2(this.class10_0);
			}
		}

		// Token: 0x0200061B RID: 1563
		[CompilerGenerated]
		private sealed class Class814
		{
			// Token: 0x04002C49 RID: 11337
			public Class809.Class810 class810_0;

			// Token: 0x04002C4A RID: 11338
			public Struct16 struct16_0;

			// Token: 0x0600308C RID: 12428
			// RVA: 0x0013AC40 File Offset: 0x00138E40
			public void method_0()
			{
				Class10 class10_ = Class72.class10_0;
				if (class10_ != null)
				{
					class10_.gamePassword = this.struct16_0.string_0;
				}
			}
		}

		// Token: 0x0200061C RID: 1564
		[CompilerGenerated]
		private sealed class Class815
		{
			// Token: 0x04002C4C RID: 11340
			public Class10 class10_0;

			// Token: 0x04002C4B RID: 11339
			public Class809.Class810 class810_0;

			// Token: 0x0600308E RID: 12430
			// RVA: 0x00023FFD File Offset: 0x000221FD
			public void method_0()
			{
				Class72.smethod_4(this.class10_0);
			}
		}

		// Token: 0x0200061D RID: 1565
		[CompilerGenerated]
		private sealed class Class816
		{
			// Token: 0x04002C4E RID: 11342
			public Class10 class10_0;

			// Token: 0x04002C4D RID: 11341
			public Class809.Class810 class810_0;

			// Token: 0x06003090 RID: 12432
			// RVA: 0x0002400A File Offset: 0x0002220A
			public void method_0()
			{
				if (Class72.class10_0 != null)
				{
					this.class10_0.gamePassword = Class72.class10_0.gamePassword;
				}
				Class72.class10_0 = this.class10_0;
				Class70.smethod_7();
			}
		}

		// Token: 0x0200061E RID: 1566
		[CompilerGenerated]
		private sealed class Class817
		{
			// Token: 0x04002C50 RID: 11344
			public bool bool_0;

			// Token: 0x04002C51 RID: 11345
			public Class21 class21_0;

			// Token: 0x04002C4F RID: 11343
			public Class809.Class810 class810_0;

			// Token: 0x06003092 RID: 12434
			// RVA: 0x00024038 File Offset: 0x00022238
			public void method_0()
			{
				Class111.smethod_9(this.class21_0, this.bool_0, false);
			}
		}

		// Token: 0x0200061F RID: 1567
		[CompilerGenerated]
		private sealed class Class818
		{
			// Token: 0x04002C52 RID: 11346
			public Class809.Class810 class810_0;

			// Token: 0x04002C53 RID: 11347
			public string string_0;

			// Token: 0x06003094 RID: 12436
			// RVA: 0x0002404D File Offset: 0x0002224D
			public void method_0()
			{
				Class111.smethod_10(this.string_0);
			}
		}

		// Token: 0x02000620 RID: 1568
		[CompilerGenerated]
		private sealed class Class819
		{
			// Token: 0x04002C54 RID: 11348
			public Class809.Class810 class810_0;

			// Token: 0x04002C55 RID: 11349
			public int int_0;

			// Token: 0x06003096 RID: 12438
			// RVA: 0x0002405A File Offset: 0x0002225A
			public void method_0()
			{
				Class111.smethod_72(this.int_0);
			}
		}

		// Token: 0x02000621 RID: 1569
		[CompilerGenerated]
		private sealed class Class820
		{
			// Token: 0x04002C56 RID: 11350
			public string string_0;

			// Token: 0x06003098 RID: 12440
			// RVA: 0x00024067 File Offset: 0x00022267
			public bool method_0(Class861 class861_0)
			{
				return string.Compare(class861_0.Name, this.string_0, true) == 0 && Class809.bool_4;
			}
		}

		// Token: 0x04002C32 RID: 11314
		[CompilerGenerated]
		private static Action<Class21> action_0;

		// Token: 0x04002BEF RID: 11247
		private static bool bool_0 = true;

		// Token: 0x04002BF3 RID: 11251
		private static bool bool_1 = true;

		// Token: 0x04002C09 RID: 11273
		private static bool bool_10;

		// Token: 0x04002C0A RID: 11274
		private static bool bool_11 = true;

		// Token: 0x04002C10 RID: 11280
		private static bool bool_12 = true;

		// Token: 0x04002C15 RID: 11285
		internal static bool bool_13;

		// Token: 0x04002C1A RID: 11290
		internal static bool bool_14;

		// Token: 0x04002C25 RID: 11301
		private static bool bool_15;

		// Token: 0x04002C26 RID: 11302
		private static bool bool_16;

		// Token: 0x04002C28 RID: 11304
		private static bool bool_17;

		// Token: 0x04002C2A RID: 11306
		private static bool bool_18;

		// Token: 0x04002C2B RID: 11307
		private static bool bool_19;

		// Token: 0x04002BF5 RID: 11253
		private static bool bool_2 = false;

		// Token: 0x04002BF7 RID: 11255
		internal static bool bool_3;

		// Token: 0x04002BF8 RID: 11256
		public static bool bool_4;

		// Token: 0x04002BFA RID: 11258
		private static bool bool_5 = true;

		// Token: 0x04002BFB RID: 11259
		public static bool bool_6;

		// Token: 0x04002BFC RID: 11260
		internal static bool bool_7;

		// Token: 0x04002C01 RID: 11265
		internal static bool bool_8;

		// Token: 0x04002C06 RID: 11270
		private static bool bool_9 = true;

		// Token: 0x04002C0C RID: 11276
		private static bStatus bStatus_0;

		// Token: 0x04002C23 RID: 11299
		private static Class162 class162_0;

		// Token: 0x04002C03 RID: 11267
		private static Class25 class25_0 = new Class25(new byte[32768], 0, 32768);

		// Token: 0x04002C12 RID: 11282
		private static Class31 class31_0 = new Class31(new MemoryStream());

		// Token: 0x04002C27 RID: 11303
		private static Class531 class531_0;

		// Token: 0x04002C00 RID: 11264
		internal static Class623<Enum30> class623_0 = Enum30.flag_0;

		// Token: 0x04002C11 RID: 11281
		internal static DateTime dateTime_0;

		// Token: 0x04002C2E RID: 11310
		[CompilerGenerated]
		private static Class133.Delegate17 delegate17_0;

		// Token: 0x04002C2F RID: 11311
		[CompilerGenerated]
		private static Class133.Delegate17 delegate17_1;

		// Token: 0x04002BF2 RID: 11250
		private static Dictionary<string, List<string>> dictionary_0 = new Dictionary<string, List<string>>();

		// Token: 0x04002C0E RID: 11278
		internal static Dictionary<int, Class861> dictionary_1 = new Dictionary<int, Class861>(16384);

		// Token: 0x04002C07 RID: 11271
		private static Enum3 enum3_0;

		// Token: 0x04002C24 RID: 11300
		private static Enum3 enum3_1;

		// Token: 0x04002C16 RID: 11286
		private static EventHandler eventHandler_0;

		// Token: 0x04002BF4 RID: 11252
		private static int int_0 = 0;

		// Token: 0x04002BF9 RID: 11257
		private static int int_1 = 3000;

		// Token: 0x04002C1B RID: 11291
		private static int int_10;

		// Token: 0x04002C1C RID: 11292
		private static int int_11 = 0;

		// Token: 0x04002C20 RID: 11296
		internal static int int_12;

		// Token: 0x04002C21 RID: 11297
		internal static int int_13;

		// Token: 0x04002C22 RID: 11298
		private static int int_14;

		// Token: 0x04002C29 RID: 11305
		public static int int_15;

		// Token: 0x04002BFD RID: 11261
		private static int int_2;

		// Token: 0x04002BFE RID: 11262
		private static int int_3;

		// Token: 0x04002BFF RID: 11263
		private static int int_4 = -1;

		// Token: 0x04002C02 RID: 11266
		internal static int int_5 = 80000;

		// Token: 0x04002C04 RID: 11268
		private static int int_6;

		// Token: 0x04002C05 RID: 11269
		private static int int_7;

		// Token: 0x04002C13 RID: 11283
		private static int int_8 = 8192;

		// Token: 0x04002C14 RID: 11284
		internal static int int_9;

		// Token: 0x04002BF1 RID: 11249
		private static List<string> list_0 = new List<string>(Class809.string_0);

		// Token: 0x04002C0F RID: 11279
		internal static List<Class861> list_1 = new List<Class861>(16384);

		// Token: 0x04002C08 RID: 11272
		internal static long long_0;

		// Token: 0x04002C0B RID: 11275
		internal static long long_1;

		// Token: 0x04002C1D RID: 11293
		private static object object_0 = new object();

		// Token: 0x04002BF6 RID: 11254
		private static Queue<Class23> queue_0 = new Queue<Class23>();

		// Token: 0x04002C1E RID: 11294
		private static Stream stream_0;

		// Token: 0x04002BF0 RID: 11248
		private static readonly string[] string_0 = new string[]
		{
			"http://c.ppy.sh",
			"http://c1.ppy.sh"
		};

		// Token: 0x04002C19 RID: 11289
		private static string string_1;

		// Token: 0x04002C1F RID: 11295
		private static string string_2;

		// Token: 0x04002C0D RID: 11277
		private static Thread thread_0;

		// Token: 0x04002C17 RID: 11287
		private static VoidDelegate voidDelegate_0;

		// Token: 0x04002C18 RID: 11288
		private static VoidDelegate voidDelegate_1;

		// Token: 0x04002C2C RID: 11308
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_2;

		// Token: 0x04002C2D RID: 11309
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_3;

		// Token: 0x04002C30 RID: 11312
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_4;

		// Token: 0x04002C31 RID: 11313
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_5;

		// Token: 0x04002C33 RID: 11315
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_6;

		// Token: 0x04002C34 RID: 11316
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_7;

		// Token: 0x04002C35 RID: 11317
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_8;

		// Token: 0x04002C36 RID: 11318
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_9;

		// Token: 0x06003051 RID: 12369
		// RVA: 0x00023D6B File Offset: 0x00021F6B
		private static void Initialize()
		{
			Class856.Initialize();
			Class809.smethod_2();
		}

		// Token: 0x06003050 RID: 12368
		// RVA: 0x0013895C File Offset: 0x00136B5C
		private static void Run()
		{
			Class809.Initialize();
			Class809.smethod_12();
			while (true)
			{
				if (!Class809.bool_11)
				{
					goto IL_17D;
				}
				IL_14:
				if (!Class809.bool_14 && Class115.smethod_33())
				{
					if (Class809.bool_7 || Class115.int_1 - Class809.int_3 > Class809.int_5)
					{
						if (Class809.bool_4)
						{
							Class809.smethod_16(Class41.GetString(OsuString.BanchoClient_ConnectionTimedOut), Class809.int_1);
						}
						Class809.smethod_12();
					}
				}
				else
				{
					Class115.class525_0.method_0(false);
					if (Class809.bool_4)
					{
						Class809.smethod_17(true);
					}
				}
				if (!Class809.bool_4)
				{
					Thread.Sleep((!Class115.smethod_33() || Class809.bool_14) ? 1000 : 50);
					continue;
				}
				if (Class809.bool_15)
				{
					Class809.smethod_18();
					continue;
				}
				Class809.smethod_24();
				try
				{
					Class809.smethod_22(false);
					Class809.smethod_23();
					goto IL_189;
				}
				catch (Exception ex)
				{
					Class809.smethod_32(true);
					int num = (ex is Exception3) ? ((Exception3)ex).method_0() : -1;
					if (num == 403)
					{
						Class809.smethod_16(Class41.GetString(OsuString.BanchoClient_ConnectionTimedOut), Class809.int_1);
					}
					else if (num == 520)
					{
						Class809.smethod_13();
						if (Class809.int_4 != 520)
						{
							Class809.smethod_32(false);
						}
					}
					else if (!(ex is SocketException) && !(ex is Exception2))
					{
						Class809.smethod_16(Class41.GetString(OsuString.BanchoClient_ConnectionTimedOut), Class809.int_1);
						Class809.int_1 = Math.Min(120000, (int)((double)Class809.int_1 * 1.5));
					}
					else
					{
						Class809.smethod_13();
					}
					Class809.int_4 = num;
					Thread.Sleep(1000);
					goto IL_189;
				}
				goto IL_17D;
				IL_189:
				Thread.Sleep(20);
				continue;
				IL_17D:
				if (!Class809.bool_4)
				{
					break;
				}
				goto IL_14;
			}
		}

		// Token: 0x0600303C RID: 12348
		// RVA: 0x00137D7C File Offset: 0x00135F7C
		internal static void smethod_0()
		{
			if (Class809.bool_0)
			{
				if (Class809.voidDelegate_2 == null)
				{
					Class809.voidDelegate_2 = new VoidDelegate(Class809.smethod_44);
				}
				Class115.smethod_88(Class809.voidDelegate_2, false, ThreadPriority.Normal);
			}
			Class809.bool_0 = false;
			if (Class809.voidDelegate_3 == null)
			{
				Class809.voidDelegate_3 = new VoidDelegate(Class809.smethod_45);
			}
			Class115.smethod_88(Class809.voidDelegate_3, false, ThreadPriority.Normal);
		}

		// Token: 0x0600303D RID: 12349
		// RVA: 0x00137DE0 File Offset: 0x00135FE0
		private static string smethod_1(string string_3)
		{
			string result = string.Empty;
			if (string.IsNullOrEmpty(string_3))
			{
				return result;
			}
			try
			{
				using (Icon icon = Icon.ExtractAssociatedIcon(string_3))
				{
					using (MemoryStream memoryStream = new MemoryStream())
					{
						icon.Save(memoryStream);
						result = Class33.smethod_3(memoryStream.ToArray());
					}
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06003046 RID: 12358
		// RVA: 0x00138028 File Offset: 0x00136228
		internal static void smethod_10(VoidDelegate voidDelegate_10)
		{
			VoidDelegate voidDelegate = Class809.voidDelegate_1;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Combine(voidDelegate2, voidDelegate_10);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref Class809.voidDelegate_1, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x06003047 RID: 12359
		// RVA: 0x0013805C File Offset: 0x0013625C
		internal static void smethod_11(VoidDelegate voidDelegate_10)
		{
			VoidDelegate voidDelegate = Class809.voidDelegate_1;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Remove(voidDelegate2, voidDelegate_10);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref Class809.voidDelegate_1, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x06003048 RID: 12360
		// RVA: 0x00138090 File Offset: 0x00136290
		internal static void smethod_12()
		{
			Class809.bool_7 = false;
			Class809.smethod_32(false);
			if (!Class115.smethod_33())
			{
				Class809.class623_0 = Enum30.flag_0;
				return;
			}
			if (!Class809.bool_2 && !Class115.bool_16)
			{
				Class115.class525_0.Text = Class41.GetString(OsuString.BanchoClient_FindingClosestServer);
				Class809.smethod_14();
				int num = 5000;
				int num2 = 100;
				while (!Class809.bool_2 && (num -= num2) > 0)
				{
					Thread.Sleep(num2);
				}
			}
			if (Class809.bool_3)
			{
				Class115.class525_0.Text = Class41.GetString(OsuString.BanchoClient_ConnectionLost);
			}
			else
			{
				Class115.class525_0.Text = Class41.GetString(OsuString.BanchoClient_ConnectingToBancho);
			}
			try
			{
				Class809.int_5 = 80000;
				Class809.smethod_18();
				Class111.list_1[0].list_0.Add(new Class841(Class41.GetString(OsuString.BanchoClient_Connecting), string.Empty, Color.get_OrangeRed()));
				Class809.smethod_13();
				Class809.stream_0 = new MemoryStream();
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (StreamWriter streamWriter = new StreamWriter(memoryStream))
					{
						streamWriter.NewLine = "\n";
						streamWriter.WriteLine(Class341.class605_20);
						streamWriter.WriteLine(Class341.class605_17);
						streamWriter.WriteLine("{0}|{1}|{2}|{3}|{4}", new object[]
						{
							Class344.smethod_0(),
							TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).Hours,
							Class341.class606_15 ? "1" : "0",
							Class115.string_0,
							Class341.class606_0 ? "1" : "0"
						});
						streamWriter.Flush();
						memoryStream.Position = 0L;
						string[] string_ = new string[]
						{
							"Content-Length: " + memoryStream.Length,
							"osu-version: " + Class344.smethod_0()
						};
						string[] array = Class809.class162_0.method_61("POST", Class809.smethod_3(), string_, memoryStream, Class809.stream_0);
						string[] array2 = array;
						for (int i = 0; i < array2.Length; i++)
						{
							string text = array2[i];
							int num3 = text.IndexOf(':');
							if (num3 > 0)
							{
								string text2 = text.Remove(num3).Trim().ToLower();
								string text3 = text.Substring(num3 + 1).Trim();
								string a;
								if ((a = text2) != null && a == "cho-token")
								{
									Class809.string_2 = text3;
								}
							}
						}
					}
				}
				if (Class809.string_2 == null)
				{
					throw new Exception("no token");
				}
				Class809.bool_4 = true;
				Class809.int_1 = 3000;
				Class115.class525_0.Text = Class41.GetString(OsuString.BanchoClient_LoggingIn);
				Class809.int_3 = Class115.int_1;
				Class809.bool_5 = true;
				Class809.bool_18 = false;
				Class809.string_1 = null;
			}
			catch (Exception ex)
			{
				Class809.bool_13 = false;
				Class169.smethod_0(new Class133(string.Format("http://osu.ppy.sh/web/bancho_connect.php?v={0}&u={1}&h={2}&fail={3}", new object[]
				{
					Class344.smethod_0(),
					Class341.class605_20,
					Class341.class605_17,
					Class809.smethod_3()
				})));
				Class809.smethod_15();
				if (Class809.bool_18 && Class809.int_9 <= 10)
				{
					Class809.smethod_16(Class41.GetString(OsuString.BanchoClient_BanchoRestart), 30000);
				}
				else
				{
					if (Class809.int_9 > 3)
					{
						Class809.bool_2 = false;
					}
					if (Class809.int_9 == 5)
					{
						Class765.smethod_0(new Class764(new Exception(ex.ToString()))
						{
							string_0 = "connection (" + Class809.smethod_3() + ")"
						});
					}
					if (Class809.int_9 % 2 == 0)
					{
						Class809.int_0++;
					}
					if (Class809.int_9 > 1)
					{
						Class809.smethod_16(Class809.string_1 ?? Class41.GetString(OsuString.BanchoClient_ConnectionFailedWillKeepRetrying), 30000);
					}
					else
					{
						Class809.smethod_16(Class809.string_1 ?? Class41.GetString(OsuString.BanchoClient_ConnectionFailedRetryingIn30s), 30000);
					}
				}
			}
		}

		// Token: 0x06003049 RID: 12361
		// RVA: 0x001384F0 File Offset: 0x001366F0
		private static void smethod_13()
		{
			try
			{
				if (Class809.class162_0 != null)
				{
					Class809.class162_0.Dispose();
				}
			}
			catch
			{
			}
			Class162 class = new Class162();
			class.method_11(8000);
			Class809.class162_0 = class;
		}

		// Token: 0x0600304A RID: 12362
		// RVA: 0x0013853C File Offset: 0x0013673C
		private static void smethod_14()
		{
			string text = "";
			try
			{
				foreach (FrameworkVersion current in Class618.smethod_0())
				{
					text = text + current + "|";
				}
			}
			catch
			{
				text = "fail";
			}
			char[] expr_5D_cp_0 = Class115.char_0;
			int expr_5D_cp_1 = 4;
			expr_5D_cp_0[expr_5D_cp_1] += '\u0001';
			Class133 class = new Class133(string.Format("http://osu.ppy.sh/web/bancho_connect.php?v={0}&u={1}&h={2}&fx={3}&mx={4}", new object[]
			{
				Class344.smethod_0(),
				Class341.class605_20,
				Class341.class605_17,
				text.Trim(new char[]
				{
					'|'
				}),
				new string(Class115.char_0)
			}));
			Class133 arg_E6_0 = class;
			if (Class809.delegate17_0 == null)
			{
				Class809.delegate17_0 = new Class133.Delegate17(Class809.smethod_46);
			}
			arg_E6_0.method_0(Class809.delegate17_0);
			Class169.smethod_0(class);
		}

		// Token: 0x0600304B RID: 12363
		// RVA: 0x00138658 File Offset: 0x00136858
		private static void smethod_15()
		{
			if (Class809.string_1 != null)
			{
				return;
			}
			Class133 class = new Class133("http://osu.ppy.sh/web/osu-checktweets.php");
			Class133 arg_31_0 = class;
			if (Class809.delegate17_1 == null)
			{
				Class809.delegate17_1 = new Class133.Delegate17(Class809.smethod_47);
			}
			arg_31_0.method_0(Class809.delegate17_1);
			Class169.smethod_0(class);
		}

		// Token: 0x0600304C RID: 12364
		// RVA: 0x001386A4 File Offset: 0x001368A4
		private static void smethod_16(string string_3, int int_16)
		{
			if (Class809.bool_5)
			{
				Class809.bool_5 = false;
				Class809.int_9 = 0;
			}
			Class115.class525_0.Text = string_3;
			Class809.int_9++;
			Class809.int_3 = Class115.int_1;
			Class809.int_5 = int_16 + Class562.smethod_1(-int_16 / 4, int_16 / 4);
			Class809.smethod_17(false);
		}

		// Token: 0x0600304D RID: 12365
		// RVA: 0x00138700 File Offset: 0x00136900
		internal static void smethod_17(bool bool_20)
		{
			if (Class809.bool_4 && !Class809.bool_15)
			{
				Class809.smethod_32(false);
				if (Class115.class525_0 != null && Class115.class525_0.Text == Class41.GetString(OsuString.BanchoClient_LoggingIn))
				{
					Class115.class525_0.Text = Class41.GetString(OsuString.BanchoClient_Disconnected);
				}
				Class809.smethod_34(Enum3.const_2, new Struct12(0));
				if (bool_20)
				{
					Class809.int_5 = 80000;
				}
				Class809.bool_15 = true;
				return;
			}
		}

		// Token: 0x0600304E RID: 12366
		// RVA: 0x0013877C File Offset: 0x0013697C
		private static void smethod_18()
		{
			bool flag = Class809.bool_4;
			Class809.smethod_32(false);
			if (flag && Class809.queue_0.Count > 0)
			{
				try
				{
					Class809.smethod_22(false);
				}
				catch
				{
				}
				if (Class809.bool_3)
				{
					Class809.queue_0.Clear();
				}
			}
			Class809.bool_15 = false;
			Class809.bool_4 = false;
			Class809.bool_6 = false;
			Class809.int_11 = 0;
			if (Class115.class861_0 != null)
			{
				Class115.class861_0.bool_6 = false;
			}
			Class70.enum59_0 = Enum59.const_0;
			Class47 arg_8B_0 = Class115.class47_0;
			if (Class809.voidDelegate_4 == null)
			{
				Class809.voidDelegate_4 = new VoidDelegate(Class809.smethod_48);
			}
			arg_8B_0.Add(Class809.voidDelegate_4, false);
			Class809.string_2 = null;
			Class809.bool_3 = false;
			Class856.smethod_1();
			if (!Class809.bool_10)
			{
				if (flag)
				{
					Class809.class623_0 = Enum30.flag_0;
					Class47 arg_D9_0 = Class115.class47_0;
					if (Class809.voidDelegate_5 == null)
					{
						Class809.voidDelegate_5 = new VoidDelegate(Class809.smethod_49);
					}
					arg_D9_0.Add(Class809.voidDelegate_5, false);
					Class466.list_0 = null;
					Class466.list_1 = null;
				}
				Class858.Cleanup();
				Class115.class47_0.Add(new VoidDelegate(Class111.smethod_65), false);
				Class213.int_0 = 0;
				Class115.class47_0.Add(new VoidDelegate(Class111.smethod_64), false);
			}
			Class809.smethod_25(true, 7);
			List<Class21> arg_14C_0 = Class111.list_1;
			if (Class809.action_0 == null)
			{
				Class809.action_0 = new Action<Class21>(Class809.smethod_50);
			}
			arg_14C_0.ForEach(Class809.action_0);
			Class111.smethod_10("#multiplayer");
			Class111.smethod_10("#spectator");
			Class111.list_4.Clear();
		}

		// Token: 0x0600304F RID: 12367
		// RVA: 0x00138908 File Offset: 0x00136B08
		public static bool smethod_19()
		{
			if (Class809.thread_0 != null)
			{
				return false;
			}
			Class809.smethod_20();
			Class809.thread_0 = new Thread(new ThreadStart(Class809.Run));
			Class809.thread_0.Priority = ThreadPriority.Highest;
			Class809.thread_0.IsBackground = true;
			Class809.thread_0.Start();
			return true;
		}

		// Token: 0x0600303E RID: 12350
		// RVA: 0x00137E64 File Offset: 0x00136064
		private static void smethod_2()
		{
			string text = string.Empty;
			try
			{
				if (Class905.smethod_16())
				{
					text = "runningunderwine";
				}
				else
				{
					NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
					for (int i = 0; i < allNetworkInterfaces.Length; i++)
					{
						NetworkInterface networkInterface = allNetworkInterfaces[i];
						text = text + networkInterface.GetPhysicalAddress() + ".";
					}
				}
			}
			catch
			{
				text = string.Empty;
			}
			Class115.smethod_23();
			Class115.string_0 = string.Concat(new string[]
			{
				Class33.smethod_1(Class905.smethod_0()),
				":",
				text,
				":",
				Class33.smethod_2(text),
				":",
				Class33.smethod_2(Class115.class623_1),
				":",
				Class33.smethod_2(Class115.class623_2),
				":"
			});
		}

		// Token: 0x06003052 RID: 12370
		// RVA: 0x00138B10 File Offset: 0x00136D10
		private static void smethod_20()
		{
			Class809.class531_0 = new Class531(Class885.Load("menu-connection", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2((float)Class115.int_22 / Class115.float_4 - 80f, (float)Class115.int_23 / Class115.float_4 - 30f), 0.96f, true, Color.get_TransparentWhite(), null);
			Class115.class911_2.Add(Class809.class531_0);
		}

		// Token: 0x06003053 RID: 12371
		// RVA: 0x00023D77 File Offset: 0x00021F77
		internal static bool smethod_21(bool bool_20)
		{
			return !Class905.bool_0 || (Class809.bool_4 && (Class809.class623_0 & Enum30.flag_2) != Enum30.flag_0);
		}

		// Token: 0x06003054 RID: 12372
		// RVA: 0x00138B7C File Offset: 0x00136D7C
		private static void smethod_22(bool bool_20)
		{
			if (!bool_20 && (!Class809.bool_3 || Class809.stream_0 != null))
			{
				return;
			}
			Class809.int_12 = 1000;
			if (!Class111.bool_2 && (!Class802.bool_16 || Class115.osuModes_1 != OsuModes.Play))
			{
				Class809.int_12 *= 1 + Class115.smethod_91() / 10000;
				Class809.int_12 *= 1 + Class809.int_14;
			}
			Class809.int_12 = Math.Min(22000, Math.Max(1000, Class809.int_12));
			if (Class115.bool_16)
			{
				Class809.int_12 = 1000;
			}
			if (Class809.bool_16)
			{
				Class809.int_12 = 0;
			}
			if (Class809.queue_0.Count == 0)
			{
				if (Class115.int_1 - Class809.int_3 < Class809.int_12)
				{
					return;
				}
				Class809.smethod_34(Enum3.const_4, null);
				Class809.int_14++;
			}
			else
			{
				Class809.int_14 = 0;
			}
			Class23[] array = Class809.queue_0.ToArray();
			try
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					Class809.bool_16 = false;
					while (Class809.queue_0.Count > 0 && memoryStream.Length < 6144L)
					{
						Class23 class;
						lock (Class809.object_0)
						{
							class = Class809.queue_0.Dequeue();
						}
						Class809.long_1 += (long)class.method_0(memoryStream, Class809.class31_0);
					}
					if (memoryStream.Length > 0L)
					{
						memoryStream.Position = 0L;
						Class809.stream_0 = new MemoryStream();
						Class809.class162_0.method_61("POST", Class809.smethod_3(), new string[]
						{
							"Content-Length: " + memoryStream.Length,
							"osu-token: " + Class809.string_2
						}, memoryStream, Class809.stream_0);
						Class809.int_3 = Class115.int_1;
						Class809.int_13++;
					}
				}
			}
			catch
			{
				lock (Class809.object_0)
				{
					if (Class809.queue_0.Count == 0)
					{
						Class23[] array2 = array;
						for (int i = 0; i < array2.Length; i++)
						{
							Class23 item = array2[i];
							Class809.queue_0.Enqueue(item);
						}
					}
				}
				throw;
			}
			Class809.int_11 = 0;
			Class809.smethod_32(false);
		}

		// Token: 0x06003055 RID: 12373
		// RVA: 0x00138E2C File Offset: 0x0013702C
		private static void smethod_23()
		{
			bool flag = Class809.enum3_1 == Enum3.const_4;
			int num = Math.Max(0, Class809.int_10 - Class115.int_1);
			if (Class809.stream_0 != null)
			{
				if (Class809.stream_0.Length == 0L)
				{
					Class809.stream_0 = null;
					return;
				}
				if (Class809.stream_0.Length > 4096L)
				{
					Class809.bool_16 = true;
				}
				Class809.stream_0.Position = 0L;
			}
			while (Class809.bool_4 && Class809.stream_0 != null)
			{
				int num2 = Class809.stream_0.Read(Class809.class25_0.byte_0, Class809.class25_0.int_0 + Class809.int_6, Math.Min(Class809.int_7 - Class809.int_6, (int)Class809.stream_0.Length));
				if (Class809.stream_0.Position == Class809.stream_0.Length)
				{
					Class809.stream_0 = null;
				}
				Class809.int_6 += num2;
				Class809.long_0 += (long)num2;
				if (Class809.bool_9 && Class809.int_6 == Class809.int_7)
				{
					Class809.enum3_0 = (Enum3)Class809.class25_0.Reader.ReadUInt16();
					Class809.class25_0.Reader.ReadByte();
					int int_ = (int)Class809.class25_0.Reader.ReadUInt32();
					Class809.smethod_25(false, int_);
				}
				if (Class809.int_6 == Class809.int_7)
				{
					Class809.Class810 class = new Class809.Class810();
					switch (Class809.enum3_0)
					{
					case Enum3.const_5:
						Class115.class861_0.int_1 = new Struct12(Class809.class25_0.Reader).int_0;
						switch (Class115.class861_0.int_1)
						{
						case -6:
							Class723.smethod_5(Class41.GetString(OsuString.BanchoClient_NeedSupporter), Color.get_Red(), 60000, null);
							Class53.smethod_0();
							Class53.dictionary_0["u_UpdaterTestBuild"] = "0";
							Class53.smethod_1();
							Class809.bool_14 = true;
							Class809.smethod_17(true);
							break;
						case -5:
							Class723.smethod_5(Class41.GetString(OsuString.BanchoClient_ErrorOccurred), Color.get_Red(), 4400, null);
							Class809.smethod_16(Class41.GetString(OsuString.BanchoClient_ConnectionFailedRetryingIn30s), 30000);
							break;
						case -4:
						case -3:
							Class723.smethod_5("You are banned.  If you think this is an error please contact osu! accounts at accounts@ppy.sh.", Color.get_Red(), 60000, null);
							Class723.smethod_5(Class41.GetString(OsuString.BanchoClient_NoMoreAccounts), Color.get_Red(), 60000, null);
							Class809.bool_14 = true;
							Class341.class605_17.Value = string.Empty;
							Class809.smethod_5(false);
							Class809.dateTime_0 = DateTime.Now.AddDays(1.0);
							Class809.smethod_17(true);
							break;
						case -2:
							Class723.smethod_5(Class41.GetString(OsuString.BanchoClient_OldVersion), Color.get_Red(), 8400, null);
							Class115.smethod_0(true, false);
							Class809.bool_14 = true;
							Class809.smethod_17(true);
							break;
						case -1:
							Class723.smethod_5(Class41.GetString(OsuString.BanchoClient_AuthenticationFailed), Color.get_Red(), 10000, null);
							Class341.class605_17.Value = string.Empty;
							Class809.smethod_17(true);
							if (Class809.eventHandler_0 != null)
							{
								Class809.eventHandler_0(false, null);
							}
							break;
						default:
							Class809.bStatus_0 = bStatus.Idle;
							Class809.smethod_36(false);
							Class809.bool_3 = true;
							Class115.class525_0.Text = Class41.GetString(OsuString.BanchoClient_ReceivingData);
							if (Class809.voidDelegate_0 != null)
							{
								Class809.voidDelegate_0();
							}
							if (Class809.eventHandler_0 != null)
							{
								Class809.eventHandler_0(true, null);
							}
							break;
						}
						break;
					case Enum3.const_7:
						if (flag && num < Class809.int_12)
						{
							num += Class562.smethod_1(0, (Class809.int_12 - num) / 2);
						}
						Class809.int_10 = num + Class115.int_1;
						class.class11_0 = new Class11(Class809.class25_0.Reader);
						Class115.class47_0.method_1(new VoidDelegate(class.method_0), num, false);
						break;
					case Enum3.const_8:
						if (Class809.bool_4 && Class809.class623_0 != Enum30.flag_0 && Class809.class623_0 != Class115.class861_0.enum30_0)
						{
							Class115.smethod_69(false);
						}
						Class809.smethod_34(Enum3.const_4, null);
						break;
					case Enum3.const_9:
					{
						string text = new Struct16(Class809.class25_0.Reader).string_0;
						class.string_0 = text.Substring(0, text.IndexOf(">>>>"));
						class.string_1 = text.Remove(0, text.IndexOf(">>>>") + 4);
						Class115.class47_0.Add(new VoidDelegate(class.method_1), false);
						break;
					}
					case Enum3.const_11:
						class.class19_0 = new Class19(Class809.class25_0.Reader);
						Class115.class47_0.Add(new VoidDelegate(class.method_2), false);
						break;
					case Enum3.const_12:
					{
						Class18 class2 = new Class18(Class809.class25_0.Reader);
						Class111.smethod_63(class2.int_0, class2.enum1_0);
						break;
					}
					case Enum3.const_13:
						lock (Class858.list_0)
						{
							Class861 class3 = Class809.smethod_28(new Struct12(Class809.class25_0.Reader).int_0, true);
							if (class3 == null)
							{
								break;
							}
							class3.bool_0 = false;
							if (!Class858.list_0.Contains(class3))
							{
								Class858.list_0.Add(class3);
							}
							Class858.bool_1 = true;
							Class858.list_0.Sort();
							break;
						}
						goto IL_6EB;
					case Enum3.const_14:
						goto IL_6EB;
					case Enum3.const_15:
						goto IL_748;
					case Enum3.const_19:
						Class115.smethod_0(false, true);
						break;
					case Enum3.const_22:
						Class809.smethod_28(new Struct12(Class809.class25_0.Reader).int_0, true).bool_0 = true;
						break;
					case Enum3.const_23:
					{
						Class47 arg_7D9_0 = Class115.class47_0;
						if (Class809.voidDelegate_8 == null)
						{
							Class809.voidDelegate_8 = new VoidDelegate(Class809.smethod_53);
						}
						arg_7D9_0.Add(Class809.voidDelegate_8, false);
						break;
					}
					case Enum3.const_24:
						Class723.smethod_5(new Struct16(Class809.class25_0.Reader).string_0.Replace("\\n", '\n'.ToString()), Color.get_Orange(), 30000, null);
						break;
					case Enum3.const_26:
					case Enum3.const_27:
						try
						{
							Class809.Class813 class4 = new Class809.Class813();
							class4.class810_0 = class;
							class4.class10_0 = new Class10(Class809.class25_0.Reader);
							Class115.class47_0.Add(new VoidDelegate(class4.method_0), false);
							break;
						}
						catch
						{
							break;
						}
						goto IL_86A;
					case Enum3.const_28:
						goto IL_86A;
					case Enum3.const_36:
						try
						{
							Class809.Class816 class5 = new Class809.Class816();
							class5.class810_0 = class;
							class5.class10_0 = new Class10(Class809.class25_0.Reader);
							Class115.class47_0.Add(new VoidDelegate(class5.method_0), false);
							break;
						}
						catch
						{
							break;
						}
						goto IL_8D1;
					case Enum3.const_37:
						goto IL_8D1;
					case Enum3.const_42:
						lock (Class858.list_0)
						{
							Class861 class6 = Class809.smethod_28(new Struct12(Class809.class25_0.Reader).int_0, true);
							if (class6.int_1 == Class115.class861_0.int_1)
							{
								break;
							}
							if (!Class858.list_1.Contains(class6))
							{
								Class858.list_1.Add(class6);
							}
							else
							{
								class6.bool_0 = false;
							}
							Class858.list_1.Sort();
							break;
						}
						goto IL_969;
					case Enum3.const_43:
						goto IL_969;
					case Enum3.const_46:
						goto IL_9AC;
					case Enum3.const_48:
						goto IL_9F5;
					case Enum3.const_50:
						Class72.smethod_5();
						break;
					case Enum3.const_53:
						if (Class115.osuModes_1 == OsuModes.Play && Class70.enum59_0 == Enum59.const_5)
						{
							Class64.bool_48 = true;
						}
						break;
					case Enum3.const_57:
						if (Class115.osuModes_1 == OsuModes.Play && Class70.enum59_0 == Enum59.const_5)
						{
							Class64.smethod_31(new Struct12(Class809.class25_0.Reader).int_0);
						}
						break;
					case Enum3.const_58:
						if (Class115.osuModes_1 == OsuModes.Play && Class70.enum59_0 == Enum59.const_5)
						{
							Class64.smethod_33();
						}
						break;
					case Enum3.const_61:
						if (Class115.osuModes_1 == OsuModes.Play && Class70.enum59_0 == Enum59.const_5)
						{
							Class62.smethod_3();
						}
						break;
					case Enum3.const_64:
					{
						class.string_2 = new Struct16(Class809.class25_0.Reader).string_0;
						Class21 class7 = Class111.list_1.Find(new Predicate<Class21>(class.method_7));
						if (class7 != null)
						{
							class7.method_2();
						}
						else
						{
							Class115.class47_0.Add(new VoidDelegate(class.method_8), false);
						}
						if (!Class809.bool_6)
						{
							Class809.bool_6 = true;
							Class115.class525_0.Text = Class41.GetString(OsuString.BanchoClient_WelcomeToBancho);
							Class115.class525_0.method_0(false);
							Class111.list_1[0].list_0.Add(new Class841(string.Format(Class41.GetString(OsuString.BanchoClient_WelcomeUser), Class341.class605_20), string.Empty, Color.get_White()));
							Class111.list_1[0].list_0.Add(new Class841(Class41.GetString(OsuString.BanchoClient_CommandHelp), string.Empty, Color.get_LightGray()));
							Class111.list_1[0].list_0.Add(new Class841(Class41.GetString(OsuString.BanchoClient_Behaviour), string.Empty, Color.get_LightGray()));
						}
						break;
					}
					case Enum3.const_65:
					case Enum3.const_67:
					{
						Class809.Class817 class8 = new Class809.Class817();
						class8.class810_0 = class;
						class8.bool_0 = (Class809.enum3_0 == Enum3.const_67);
						class8.class21_0 = new Class21(Class809.class25_0.Reader);
						if (!string.IsNullOrEmpty(class8.class21_0.string_0))
						{
							Class115.class47_0.Add(new VoidDelegate(class8.method_0), false);
						}
						break;
					}
					case Enum3.const_66:
					{
						Class809.Class818 class9 = new Class809.Class818();
						class9.class810_0 = class;
						class9.string_0 = new Struct16(Class809.class25_0.Reader).string_0;
						Class115.class47_0.Add(new VoidDelegate(class9.method_0), false);
						break;
					}
					case Enum3.const_69:
						class.class16_0 = new Class16(Class809.class25_0.Reader);
						Class115.class47_0.Add(new VoidDelegate(class.method_9), false);
						break;
					case Enum3.const_71:
					{
						Class809.bool_8 = true;
						Class809.class623_0 = (Enum30)new Struct12(Class809.class25_0.Reader).int_0;
						Class47 arg_D2E_0 = Class115.class47_0;
						if (Class809.voidDelegate_7 == null)
						{
							Class809.voidDelegate_7 = new VoidDelegate(Class809.smethod_52);
						}
						arg_D2E_0.Add(Class809.voidDelegate_7, false);
						break;
					}
					case Enum3.const_72:
						Class111.smethod_66(new Struct14(Class809.class25_0.Reader).list_0);
						break;
					case Enum3.const_75:
						Class213.int_0 = new Struct12(Class809.class25_0.Reader).int_0;
						break;
					case Enum3.const_76:
					{
						string text2 = new Struct16(Class809.class25_0.Reader).string_0;
						if (text2 == null)
						{
							Class79.smethod_0(null, null);
						}
						else
						{
							string[] array = text2.Split(new char[]
							{
								'|'
							});
							Class79.smethod_0(array[0], (array.Length > 1) ? array[1] : null);
						}
						break;
					}
					case Enum3.const_80:
						Class809.smethod_0();
						break;
					case Enum3.const_81:
						if (Class115.osuModes_1 == OsuModes.Play && Class70.enum59_0 == Enum59.const_5)
						{
							Class64.smethod_32(new Struct12(Class809.class25_0.Reader).int_0);
						}
						break;
					case Enum3.const_83:
						class.class17_0 = new Class17(Class809.class25_0.Reader);
						Class115.class47_0.Add(new VoidDelegate(class.method_5), false);
						break;
					case Enum3.const_86:
					{
						int int_2 = new Struct12(Class809.class25_0.Reader).int_0;
						Class809.bool_18 = true;
						Class809.smethod_16(Class41.GetString(OsuString.BanchoClient_BanchoRestart), int_2);
						break;
					}
					case Enum3.const_88:
					{
						Class11 class10 = new Class11(Class809.class25_0.Reader);
						Class861 class11 = Class809.smethod_30(class10.object_0.ToString());
						if (class11 != null && (Class341.class606_1 || class11.bool_3))
						{
							Class111.smethod_24(class10, false, true);
						}
						break;
					}
					case Enum3.const_89:
					{
						Class47 arg_EE6_0 = Class115.class47_0;
						if (Class809.voidDelegate_9 == null)
						{
							Class809.voidDelegate_9 = new VoidDelegate(Class809.smethod_54);
						}
						arg_EE6_0.Add(Class809.voidDelegate_9, false);
						break;
					}
					case Enum3.const_91:
						try
						{
							Class809.Class814 class12 = new Class809.Class814();
							class12.class810_0 = class;
							class12.struct16_0 = new Struct16(Class809.class25_0.Reader);
							Class115.class47_0.Add(new VoidDelegate(class12.method_0), false);
							break;
						}
						catch
						{
							break;
						}
						goto IL_F3E;
					case Enum3.const_92:
						goto IL_F3E;
					case Enum3.const_94:
					{
						Class809.Class819 class13 = new Class809.Class819();
						class13.class810_0 = class;
						class13.int_0 = new Struct12(Class809.class25_0.Reader).int_0;
						Class115.class47_0.Add(new VoidDelegate(class13.method_0), false);
						break;
					}
					case Enum3.const_95:
						class.int_0 = new Struct12(Class809.class25_0.Reader).int_0;
						Class115.class47_0.Add(new VoidDelegate(class.method_3), false);
						break;
					case Enum3.const_96:
						class.struct14_0 = new Struct14(Class809.class25_0.Reader);
						Class115.class47_0.Add(new VoidDelegate(class.method_4), false);
						break;
					case Enum3.const_100:
					{
						Class11 class14 = new Class11(Class809.class25_0.Reader);
						Class861 class15 = Class809.smethod_30(class14.string_1);
						Class111.class21_0.list_0.Add(new Class841(string.Format(Class41.GetString(OsuString.Bancho_NoFriendPMBlocked), class15.Name), string.Empty, Color.get_OrangeRed()));
						break;
					}
					case Enum3.const_101:
					{
						Class11 class16 = new Class11(Class809.class25_0.Reader);
						Class111.class21_0.list_0.Add(new Class841(string.Format(Class41.GetString(OsuString.Bancho_TargetIsSilenced), class16.string_1), string.Empty, Color.get_OrangeRed()));
						break;
					}
					case Enum3.const_102:
						Class115.smethod_0(true, true);
						break;
					case Enum3.const_103:
						if (Class115.smethod_91() >= new Struct12(Class809.class25_0.Reader).int_0 && Class72.class10_0 == null)
						{
							Class809.smethod_42();
						}
						break;
					case Enum3.const_104:
						Class809.bool_19 = true;
						break;
					case Enum3.const_105:
						class.string_3 = new Struct16(Class809.class25_0.Reader).string_0;
						Class115.class47_0.method_1(new VoidDelegate(class.method_10), Class562.smethod_1(3000, 8000), false);
						break;
					case Enum3.const_106:
						if (Class115.osuModes_1 == OsuModes.Play && Class70.enum59_0 == Enum59.const_5 && Class64.class64_0 != null)
						{
							Class64.class64_0.vmethod_26(true);
						}
						break;
					case Enum3.const_107:
						if (!Class809.bool_1)
						{
							Class723.smethod_5(Class41.GetString(OsuString.BanchoClient_TournamentMatchFinished), Color.get_LightBlue(), 5000, null);
							Class47 arg_11E8_0 = Class115.class47_0;
							if (Class809.voidDelegate_6 == null)
							{
								Class809.voidDelegate_6 = new VoidDelegate(Class809.smethod_51);
							}
							arg_11E8_0.method_1(Class809.voidDelegate_6, 5000, false);
						}
						else
						{
							Class809.Class812 class17 = new Class809.Class812();
							class17.class810_0 = class;
							class17.string_0 = new Struct16(Class809.class25_0.Reader).string_0;
							Class723.smethod_5(string.Format(Class41.GetString(OsuString.BanchoClient_TournamentMatchReady), 5), Color.get_LightBlue(), 5000, null);
							Class115.class47_0.method_1(new VoidDelegate(class17.method_0), 5000, false);
						}
						break;
					}
					IL_125C:
					Class809.smethod_25(true, 7);
					continue;
					IL_6EB:
					lock (Class858.list_0)
					{
						Class861 class18 = Class809.smethod_28(new Struct12(Class809.class25_0.Reader).int_0, true);
						class18.bool_0 = false;
						Class858.list_0.Remove(class18);
						if (Class858.list_0.Count == 0)
						{
							Class858.bool_1 = false;
						}
						goto IL_125C;
					}
					IL_748:
					if (Class858.class861_0 != null)
					{
						class.class13_0 = new Class13(Class809.class25_0.Reader);
						Class115.class47_0.Add(new VoidDelegate(class.method_6), false);
						goto IL_125C;
					}
					goto IL_125C;
					IL_86A:
					Class70.smethod_3(new Struct12(Class809.class25_0.Reader).int_0);
					goto IL_125C;
					IL_8D1:
					Class115.class47_0.Add(new VoidDelegate(Class70.smethod_6), false);
					goto IL_125C;
					IL_969:
					lock (Class858.list_0)
					{
						Class861 item = Class809.smethod_28(new Struct12(Class809.class25_0.Reader).int_0, true);
						Class858.list_1.Remove(item);
						goto IL_125C;
					}
					try
					{
						IL_9AC:
						Class809.Class815 class19 = new Class809.Class815();
						class19.class810_0 = class;
						class19.class10_0 = new Class10(Class809.class25_0.Reader);
						Class115.class47_0.Add(new VoidDelegate(class19.method_0), false);
						goto IL_125C;
					}
					catch
					{
						goto IL_125C;
					}
					IL_9F5:
					if (Class115.osuModes_1 == OsuModes.Play && Class70.enum59_0 == Enum59.const_5)
					{
						Class64.smethod_29(new Struct13(Class809.class25_0.Reader));
						goto IL_125C;
					}
					if (Class115.osuModes_1 == OsuModes.MatchSetup)
					{
						Class72.smethod_6(new Struct13(Class809.class25_0.Reader));
						goto IL_125C;
					}
					goto IL_125C;
					IL_F3E:
					int num3 = new Struct12(Class809.class25_0.Reader).int_0;
					if (num3 <= 0)
					{
						Class809.smethod_5(true);
						goto IL_125C;
					}
					Class809.smethod_5(false);
					Class809.dateTime_0 = DateTime.Now.AddSeconds((double)num3);
					goto IL_125C;
				}
			}
			Class809.int_4 = -1;
		}

		// Token: 0x06003056 RID: 12374
		// RVA: 0x0013A10C File Offset: 0x0013830C
		private static void smethod_24()
		{
			bool flag;
			if ((flag = (Class115.int_1 - Class809.int_2 > 150000)) != (bStatus.Afk == Class809.bStatus_0))
			{
				if (flag)
				{
					Class809.smethod_37(bStatus.Afk, false);
					return;
				}
				Class809.smethod_36(false);
			}
		}

		// Token: 0x06003057 RID: 12375
		// RVA: 0x00023D98 File Offset: 0x00021F98
		private static void smethod_25(bool bool_20, int int_16)
		{
			Class809.class25_0.memoryStream_0.Seek(0L, SeekOrigin.Begin);
			Class809.bool_9 = bool_20;
			Class809.int_7 = int_16;
			Class809.int_6 = 0;
		}

		// Token: 0x06003058 RID: 12376
		// RVA: 0x0013A148 File Offset: 0x00138348
		internal static void smethod_26()
		{
			try
			{
				Class809.smethod_17(true);
				Class809.smethod_18();
			}
			catch
			{
			}
		}

		// Token: 0x06003059 RID: 12377
		// RVA: 0x0013A178 File Offset: 0x00138378
		internal static void smethod_27()
		{
			if (!Class809.bool_11)
			{
				return;
			}
			Class809.bool_10 = true;
			try
			{
				Class809.smethod_17(true);
			}
			catch
			{
			}
		}

		// Token: 0x0600305A RID: 12378
		// RVA: 0x0013A1B0 File Offset: 0x001383B0
		internal static Class861 smethod_28(int int_16, bool bool_20)
		{
			Class861 class;
			if (Class809.dictionary_1.TryGetValue(int_16, out class))
			{
				class.method_18(bool_20, false);
				return class;
			}
			return null;
		}

		// Token: 0x0600305B RID: 12379
		// RVA: 0x00023DC6 File Offset: 0x00021FC6
		internal static Class861 smethod_29(string string_3)
		{
			if (string.IsNullOrEmpty(string_3))
			{
				return null;
			}
			return Class809.smethod_30(string_3) ?? Class809.smethod_31(string_3);
		}

		// Token: 0x0600303F RID: 12351
		// RVA: 0x00023D17 File Offset: 0x00021F17
		private static string smethod_3()
		{
			return Class809.list_0[(Class809.int_0 < 0) ? 0 : (Class809.int_0 % Class809.list_0.Count)];
		}

		// Token: 0x0600305C RID: 12380
		// RVA: 0x0013A1D8 File Offset: 0x001383D8
		internal static Class861 smethod_30(string string_3)
		{
			Predicate<Class861> predicate = null;
			Class809.Class820 class = new Class809.Class820();
			class.string_0 = string_3;
			Class861 result;
			lock (Class809.list_1)
			{
				List<Class861> arg_31_0 = Class809.list_1;
				if (predicate == null)
				{
					predicate = new Predicate<Class861>(class.method_0);
				}
				result = arg_31_0.Find(predicate);
			}
			return result;
		}

		// Token: 0x0600305D RID: 12381
		// RVA: 0x00023DE2 File Offset: 0x00021FE2
		internal static Class861 smethod_31(string string_3)
		{
			return Class809.smethod_30(string_3.Replace(' ', '_'));
		}

		// Token: 0x0600305E RID: 12382
		// RVA: 0x0013A238 File Offset: 0x00138438
		private static void smethod_32(bool bool_20)
		{
			if (bool_20 == Class809.bool_17)
			{
				return;
			}
			Class809.bool_17 = bool_20;
			lock (Class911.object_0)
			{
				if (Class809.bool_17)
				{
					Class809.class531_0.class26_0.Clear();
					Class809.class531_0.method_25(0.6f, 500, Enum70.const_0);
					Class809.class531_0.class26_0.Add(new Class746(TransformationType.Fade, 0.6f, 0.4f, Class115.int_1 + 500, Class115.int_1 + 2100, Enum70.const_0)
					{
						bool_0 = true,
						int_2 = 500
					});
					Class809.class531_0.class26_0.Add(new Class746(TransformationType.Fade, 0.4f, 0.6f, Class115.int_1 + 2100, Class115.int_1 + 2600, Enum70.const_0)
					{
						bool_0 = true,
						int_2 = 2000
					});
				}
				else
				{
					Class809.class531_0.class26_0.Clear();
					Class809.class531_0.method_16(500, Enum70.const_0);
				}
			}
		}

		// Token: 0x0600305F RID: 12383
		// RVA: 0x00023DF3 File Offset: 0x00021FF3
		internal static void smethod_33(Enum3 enum3_2, int int_16)
		{
			Class809.enum3_1 = enum3_2;
			Class809.smethod_35(new Class23(enum3_2, new Struct12(int_16), false));
		}

		// Token: 0x06003060 RID: 12384
		// RVA: 0x00023E12 File Offset: 0x00022012
		internal static void smethod_34(Enum3 enum3_2, bSerializable bSerializable_0)
		{
			Class809.enum3_1 = enum3_2;
			Class809.smethod_35(new Class23(enum3_2, bSerializable_0, false));
		}

		// Token: 0x06003061 RID: 12385
		// RVA: 0x0013A35C File Offset: 0x0013855C
		internal static void smethod_35(Class23 class23_0)
		{
			Class809.enum3_1 = class23_0.enum3_0;
			lock (Class809.object_0)
			{
				Class809.queue_0.Enqueue(class23_0);
			}
		}

		// Token: 0x06003062 RID: 12386
		// RVA: 0x00023E27 File Offset: 0x00022027
		internal static void smethod_36(bool bool_20)
		{
			Class809.smethod_37(bStatus.Unknown, bool_20);
		}

		// Token: 0x06003063 RID: 12387
		// RVA: 0x0013A3A4 File Offset: 0x001385A4
		internal static void smethod_37(bStatus bStatus_1, bool bool_20)
		{
			string text = string.Empty;
			string string_ = string.Empty;
			int num = 0;
			Mods mods_ = Mods.None;
			bool flag = false;
			if (bStatus_1 == bStatus.Unknown)
			{
				if (Class466.Current != null)
				{
					text = (Class802.smethod_0() ? (((Class858.class861_0 != null) ? Class858.class861_0.Name : Class802.class512_0.string_2) + " play ") : string.Empty) + Class466.Current.string_6;
					string_ = Class466.Current.string_3;
					num = Class466.Current.int_2;
					mods_ = Class876.class623_0;
				}
				bStatus_1 = bStatus.Idle;
				OsuModes osuModes_ = Class115.osuModes_1;
				switch (osuModes_)
				{
				case OsuModes.Edit:
					if (!(Class466.Current.string_5 == Class341.class605_20) && Class466.Current.string_5.Length != 0)
					{
						bStatus_1 = bStatus.Modding;
					}
					else
					{
						bStatus_1 = bStatus.Editing;
					}
					flag = true;
					break;
				case OsuModes.Play:
					if (Class802.smethod_0())
					{
						bStatus_1 = bStatus.Watching;
					}
					else if (Class115.bool_25)
					{
						bStatus_1 = bStatus.Testing;
					}
					else if (Class70.enum59_0 == Enum59.const_5)
					{
						bStatus_1 = bStatus.Multiplaying;
					}
					else
					{
						bStatus_1 = bStatus.Playing;
					}
					flag = true;
					break;
				default:
					switch (osuModes_)
					{
					case OsuModes.Lobby:
					case OsuModes.MatchSetup:
					case OsuModes.SelectMulti:
						bStatus_1 = bStatus.Multiplayer;
						goto IL_140;
					case OsuModes.OnlineSelection:
						bStatus_1 = bStatus.OsuDirect;
						goto IL_140;
					}
					text = string.Empty;
					string_ = string.Empty;
					break;
				}
			}
			IL_140:
			if (bStatus_1 == Class809.bStatus_0 && !bool_20)
			{
				return;
			}
			Class809.bStatus_0 = bStatus_1;
			Class809.smethod_34(Enum3.const_0, new Class12(Class809.bStatus_0, flag, text, string_, num, mods_, Class62.Mode));
		}

		// Token: 0x06003064 RID: 12388
		// RVA: 0x00023E30 File Offset: 0x00022030
		public static void smethod_38()
		{
			Class809.int_2 = Class115.int_1;
		}

		// Token: 0x06003065 RID: 12389
		// RVA: 0x0013A520 File Offset: 0x00138720
		public static void smethod_39(Class861 class861_0)
		{
			lock (Class809.list_1)
			{
				Class809.list_1.Add(class861_0);
			}
			lock (Class809.dictionary_1)
			{
				Class809.dictionary_1.Add(class861_0.int_1, class861_0);
			}
		}

		// Token: 0x06003040 RID: 12352
		// RVA: 0x00023D3E File Offset: 0x00021F3E
		internal static bool smethod_4()
		{
			if (Class809.bool_12)
			{
				return true;
			}
			if (DateTime.Now > Class809.dateTime_0)
			{
				Class809.bool_12 = true;
				return true;
			}
			return false;
		}

		// Token: 0x06003066 RID: 12390
		// RVA: 0x0013A590 File Offset: 0x00138790
		public static void smethod_40(Class861 class861_0)
		{
			class861_0.bool_10 = false;
			Class809.int_15++;
			lock (Class809.dictionary_1)
			{
				Class809.dictionary_1.Remove(class861_0.int_1);
			}
		}

		// Token: 0x06003067 RID: 12391
		// RVA: 0x00023E3C File Offset: 0x0002203C
		public static void smethod_41()
		{
			Class809.bool_7 = true;
			Class115.class525_0.Text = Class41.GetString(OsuString.BanchoClient_Reconnecting);
			Class809.smethod_17(true);
		}

		// Token: 0x06003068 RID: 12392
		// RVA: 0x00023E5E File Offset: 0x0002205E
		internal static void smethod_42()
		{
			Class809.bool_13 = !Class809.bool_13;
			Class809.smethod_41();
		}

		// Token: 0x06003069 RID: 12393
		// RVA: 0x00023E72 File Offset: 0x00022072
		internal static void smethod_43(string[] string_3)
		{
			Class809.bool_1 = (string_3 == Class809.string_0);
			Class809.list_0.Clear();
			Class809.list_0.AddRange(string_3);
			Class809.int_0 = 0;
			if (Class809.thread_0 != null)
			{
				Class809.smethod_41();
			}
		}

		// Token: 0x0600306A RID: 12394
		// RVA: 0x0013A5E8 File Offset: 0x001387E8
		[CompilerGenerated]
		private static void smethod_44()
		{
			while (Class115.osuModes_1 == OsuModes.Play)
			{
				Thread.Sleep(500);
			}
			try
			{
				ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\CIMV2", "SELECT * FROM CIM_DataFile where FileName = 'LL' and FileSize < 128");
				foreach (ManagementBaseObject current in managementObjectSearcher.Get())
				{
					try
					{
						string text = File.ReadAllText(current["Name"].ToString());
						Class133 class129_ = new Class133(string.Format("http://osu.ppy.sh/web/bancho_connect.php?v={0}&u={1}&h={2}&x={3}", new object[]
						{
							Class344.smethod_0(),
							Class341.class605_20,
							Class341.class605_17,
							text.Replace("\n\r", "-")
						}));
						Class169.smethod_0(class129_);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600306B RID: 12395
		// RVA: 0x0013A6F0 File Offset: 0x001388F0
		[CompilerGenerated]
		private static void smethod_45()
		{
			if (Class341.class605_8 == ScreenMode.Fullscreen)
			{
				while (!Class115.bool_11)
				{
					Thread.Sleep(1000);
				}
			}
			Process[] processes = Process.GetProcesses();
			StringBuilder stringBuilder = new StringBuilder();
			Process[] array = processes;
			for (int i = 0; i < array.Length; i++)
			{
				Process process = array[i];
				string text = string.Empty;
				string text2 = string.Empty;
				try
				{
					text2 = process.MainModule.FileName;
					FileInfo fileInfo = new FileInfo(text2);
					if (fileInfo != null)
					{
						text = Class33.smethod_2(fileInfo.Length.ToString()) + " " + text;
					}
				}
				catch
				{
				}
				stringBuilder.AppendLine(string.Concat(new string[]
				{
					Class809.smethod_1(text2),
					" ",
					text,
					" | ",
					process.ProcessName,
					" (",
					process.MainWindowTitle,
					")"
				}));
			}
			byte[] byte_ = Class737.smethod_0();
			Class765.smethod_0(new Class764(new Exception("monitor"))
			{
				string_0 = stringBuilder.ToString(),
				byte_0 = byte_
			});
		}

		// Token: 0x0600306C RID: 12396
		// RVA: 0x0013A83C File Offset: 0x00138A3C
		[CompilerGenerated]
		private static void smethod_46(string string_3, Exception exception_0)
		{
			if (exception_0 == null && string_3.Length != 0 && !string_3.Contains("<"))
			{
				List<string> list = null;
				if (Class809.dictionary_0.TryGetValue(string_3, out list) && !Class809.list_0.Contains(list[0]))
				{
					Class809.list_0.InsertRange((string_3.Length > 2) ? 0 : 1, list);
				}
				Class809.bool_2 = true;
				return;
			}
		}

		// Token: 0x0600306D RID: 12397
		// RVA: 0x00023EA8 File Offset: 0x000220A8
		[CompilerGenerated]
		private static void smethod_47(string string_3, Exception exception_0)
		{
			if (exception_0 == null && string_3.Length != 0 && !string_3.Contains("<"))
			{
				Class809.string_1 = string_3;
				Class809.int_0 = -10;
				return;
			}
			Class809.string_1 = null;
		}

		// Token: 0x0600306E RID: 12398
		// RVA: 0x00023ED6 File Offset: 0x000220D6
		[CompilerGenerated]
		private static void smethod_48()
		{
			Class72.class10_0 = null;
		}

		// Token: 0x0600306F RID: 12399
		// RVA: 0x00023EDE File Offset: 0x000220DE
		[CompilerGenerated]
		private static void smethod_49()
		{
			if (Class809.voidDelegate_1 != null)
			{
				Class809.voidDelegate_1();
			}
		}

		// Token: 0x06003041 RID: 12353
		// RVA: 0x00023D63 File Offset: 0x00021F63
		internal static void smethod_5(bool bool_20)
		{
			Class809.bool_12 = bool_20;
		}

		// Token: 0x06003070 RID: 12400
		// RVA: 0x00023EF1 File Offset: 0x000220F1
		[CompilerGenerated]
		private static void smethod_50(Class21 class21_0)
		{
			class21_0.Reset();
		}

		// Token: 0x06003071 RID: 12401
		// RVA: 0x00023EF9 File Offset: 0x000220F9
		[CompilerGenerated]
		private static void smethod_51()
		{
			Class809.smethod_43(Class809.string_0);
		}

		// Token: 0x06003072 RID: 12402
		// RVA: 0x00023EDE File Offset: 0x000220DE
		[CompilerGenerated]
		private static void smethod_52()
		{
			if (Class809.voidDelegate_1 != null)
			{
				Class809.voidDelegate_1();
			}
		}

		// Token: 0x06003073 RID: 12403
		// RVA: 0x00023F05 File Offset: 0x00022105
		[CompilerGenerated]
		private static void smethod_53()
		{
			if (!Class111.bool_2)
			{
				Class111.smethod_21(false);
			}
		}

		// Token: 0x06003074 RID: 12404
		// RVA: 0x00023F14 File Offset: 0x00022114
		[CompilerGenerated]
		private static void smethod_54()
		{
			Class111.smethod_71();
		}

		// Token: 0x06003042 RID: 12354
		// RVA: 0x00137F58 File Offset: 0x00136158
		internal static void smethod_6(EventHandler eventHandler_1)
		{
			EventHandler eventHandler = Class809.eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_1);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref Class809.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06003043 RID: 12355
		// RVA: 0x00137F8C File Offset: 0x0013618C
		internal static void smethod_7(EventHandler eventHandler_1)
		{
			EventHandler eventHandler = Class809.eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_1);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref Class809.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06003044 RID: 12356
		// RVA: 0x00137FC0 File Offset: 0x001361C0
		internal static void smethod_8(VoidDelegate voidDelegate_10)
		{
			VoidDelegate voidDelegate = Class809.voidDelegate_0;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Combine(voidDelegate2, voidDelegate_10);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref Class809.voidDelegate_0, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x06003045 RID: 12357
		// RVA: 0x00137FF4 File Offset: 0x001361F4
		internal static void smethod_9(VoidDelegate voidDelegate_10)
		{
			VoidDelegate voidDelegate = Class809.voidDelegate_0;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Remove(voidDelegate2, voidDelegate_10);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref Class809.voidDelegate_0, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}
	}
}
