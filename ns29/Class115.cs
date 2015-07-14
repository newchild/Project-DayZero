using Microsoft.Win32;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns10;
using ns11;
using ns14;
using ns16;
using ns17;
using ns18;
using ns19;
using ns20;
using ns21;
using ns22;
using ns23;
using ns24;
using ns25;
using ns26;
using ns27;
using ns35;
using ns40;
using ns41;
using ns5;
using ns6;
using ns64;
using ns76;
using ns77;
using ns78;
using ns79;
using ns8;
using ns80;
using ns81;
using ns82;
using ns84;
using ns85;
using ns86;
using ns9;
using ns90;
using ns91;
using osu;
using osu.GameModes.Edit;
using osu.GameModes.Options;
using osu.GameModes.Other;
using osu.Graphics.OpenGl;
using osu.Graphics.Sprites;
using osu.Input;
using osu.Properties;
using osu_common;
using osu_common.Helpers;
using osudata;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using Un4seen.Bass;

namespace ns29
{
	// Token: 0x02000350 RID: 848
	internal sealed class Class115 : Class114
	{
		// Token: 0x02000351 RID: 849
		[CompilerGenerated]
		private sealed class Class345
		{
			// Token: 0x02000352 RID: 850
			private sealed class Class346
			{
				// Token: 0x040014F0 RID: 5360
				public Class115.Class345 class345_0;

				// Token: 0x040014F1 RID: 5361
				public string string_0;

				// Token: 0x06001A43 RID: 6723
				// RVA: 0x0001633E File Offset: 0x0001453E
				public void method_0()
				{
					Class115.smethod_90("http://osu.ppy.sh/p/changelog?v=" + Class344.smethod_0() + "&l=" + this.string_0, null);
				}
			}

			// Token: 0x040014EE RID: 5358
			public Enum32 enum32_0;

			// Token: 0x040014EF RID: 5359
			private static VoidDelegate voidDelegate_0;

			// Token: 0x06001A40 RID: 6720
			// RVA: 0x000809B4 File Offset: 0x0007EBB4
			public void method_0()
			{
				if (this.enum32_0 == Class115.enum32_0)
				{
					return;
				}
				Class115.enum32_0 = this.enum32_0;
				VoidDelegate voidDelegate = Class115.voidDelegate_0;
				if (voidDelegate != null)
				{
					voidDelegate();
				}
				Class115.Class345.Class346 class = new Class115.Class345.Class346();
				class.class345_0 = this;
				switch (Class115.enum32_0)
				{
				case Enum32.const_0:
					Class341.class608_17.Value = 0;
					break;
				case Enum32.const_1:
				case Enum32.const_2:
					break;
				case Enum32.const_3:
					goto IL_160;
				case Enum32.const_4:
				{
					Class341.smethod_13();
					Class341.class608_17.Value = 0;
					bool flag = !Class341.class606_64.Value;
					Class341.class606_64.Value = true;
					if (Class115.bool_10)
					{
						Class115.smethod_3(false);
					}
					else if (Class115.osuModes_1 != OsuModes.Menu && flag)
					{
						Class723.smethod_5(Class41.GetString(OsuString.General_NewVersion), Color.get_Pink(), 10000, null);
					}
					Class115.bool_9 = true;
					return;
				}
				case Enum32.const_5:
					Class341.class608_17.Value = 0;
					Class341.class606_64.Value = false;
					Class341.smethod_3();
					class.string_0 = Class341.class605_15;
					Class723.smethod_5(string.Format(Class41.GetString(OsuString.Update_Complete), Class344.smethod_0()) + '\n' + Class41.GetString(OsuString.GameBase_Updater_Changelog), Color.get_Pink(), 10000, new VoidDelegate(class.method_0));
					return;
				case Enum32.const_6:
					if (File.Exists("osume.exe"))
					{
						Class115.class115_0.method_12();
						Class115.smethod_90("osume.exe", null);
						return;
					}
					goto IL_160;
				default:
					return;
				}
				return;
				IL_160:
				Class341.class606_64.Value = false;
				if (Class214.exception_0 != null)
				{
					if (Class115.Class345.voidDelegate_0 == null)
					{
						Class115.Class345.voidDelegate_0 = new VoidDelegate(Class115.Class345.smethod_0);
					}
					Class115.smethod_88(Class115.Class345.voidDelegate_0, false, ThreadPriority.Normal);
				}
				Class341.smethod_4();
				Class341.class608_17.Value++;
			}

			// Token: 0x06001A41 RID: 6721
			// RVA: 0x00080B70 File Offset: 0x0007ED70
			private static void smethod_0()
			{
				Class765.smethod_0(new Class764(Class214.exception_0)
				{
					string_0 = "update error",
					string_1 = (Class214.string_2 ?? string.Empty)
				});
				Class214.smethod_7();
			}
		}

		// Token: 0x02000353 RID: 851
		[CompilerGenerated]
		private sealed class Class347
		{
			// Token: 0x040014F6 RID: 5366
			public bool bool_0;

			// Token: 0x040014F3 RID: 5363
			public int? nullable_0;

			// Token: 0x040014F4 RID: 5364
			public int? nullable_1;

			// Token: 0x040014F5 RID: 5365
			public ScreenMode? nullable_2;

			// Token: 0x040014F2 RID: 5362
			public Point point_0;

			// Token: 0x06001A45 RID: 6725
			// RVA: 0x00016360 File Offset: 0x00014560
			public void method_0()
			{
				Class115.smethod_20(this.nullable_0, this.nullable_1, this.nullable_2, this.bool_0, false);
			}

			// Token: 0x06001A46 RID: 6726
			// RVA: 0x00016380 File Offset: 0x00014580
			public void method_1()
			{
				Class115.form_0.Location = this.point_0;
			}

			// Token: 0x06001A47 RID: 6727
			// RVA: 0x00016380 File Offset: 0x00014580
			public void method_2()
			{
				Class115.form_0.Location = this.point_0;
			}
		}

		// Token: 0x02000354 RID: 852
		[CompilerGenerated]
		private sealed class Class348
		{
			// Token: 0x040014F7 RID: 5367
			public bool bool_0;

			// Token: 0x06001A49 RID: 6729
			// RVA: 0x00016392 File Offset: 0x00014592
			public void method_0()
			{
				Class905.smethod_13(this.bool_0 ? "-setassociations" : "-setpermissions", true);
			}
		}

		// Token: 0x02000355 RID: 853
		[CompilerGenerated]
		private sealed class Class349
		{
			// Token: 0x040014F8 RID: 5368
			public Class89 class89_0;

			// Token: 0x06001A4B RID: 6731
			// RVA: 0x000163AF File Offset: 0x000145AF
			public void method_0()
			{
				this.class89_0.class911_0.Dispose();
			}
		}

		// Token: 0x02000356 RID: 854
		[CompilerGenerated]
		private sealed class Class350
		{
			// Token: 0x040014FA RID: 5370
			public bool bool_0;

			// Token: 0x040014F9 RID: 5369
			public OsuModes osuModes_0;

			// Token: 0x06001A4D RID: 6733
			// RVA: 0x00080BB4 File Offset: 0x0007EDB4
			public void method_0()
			{
				if (this.osuModes_0 == Class115.osuModes_1 && !this.bool_0)
				{
					return;
				}
				Class115.enum113_0 = Enum113.const_2;
				List<Class89> list = new List<Class89>();
				foreach (Class89 current in Class115.list_2)
				{
					if (current.bool_2)
					{
						list.Add(current);
					}
				}
				foreach (Class89 current2 in list)
				{
					current2.Close(false);
				}
				Class115.osuModes_0 = this.osuModes_0;
				Class115.smethod_72(null, null);
				if (Class115.eventHandler_4 != null)
				{
					Class115.eventHandler_4(null, null);
				}
			}
		}

		// Token: 0x02000357 RID: 855
		[CompilerGenerated]
		private sealed class Class351
		{
			// Token: 0x040014FB RID: 5371
			public string string_0;

			// Token: 0x06001A4F RID: 6735
			// RVA: 0x00080C98 File Offset: 0x0007EE98
			public void method_0()
			{
				string text = string.Format("osu!{0} {1} {2}", Class344.string_0, Class344.string_1, (this.string_0.Length > 0) ? ("- " + this.string_0) : string.Empty).Trim();
				if (Class115.bool_17)
				{
					text += string.Format(" Primary", new object[0]);
				}
				Class115.class115_0.method_4().Title = text;
			}
		}

		// Token: 0x02000358 RID: 856
		[CompilerGenerated]
		private sealed class Class352
		{
			// Token: 0x040014FC RID: 5372
			public string string_0;

			// Token: 0x06001A51 RID: 6737
			// RVA: 0x000163C1 File Offset: 0x000145C1
			public void method_0(object sender, EventArgs e)
			{
				Editor.editor_0.class376_0.method_9(this.string_0);
			}
		}

		// Token: 0x02000359 RID: 857
		[CompilerGenerated]
		private sealed class Class353
		{
			// Token: 0x040014FD RID: 5373
			public Class115.Class352 class352_0;

			// Token: 0x040014FE RID: 5374
			public string string_0;

			// Token: 0x06001A53 RID: 6739
			// RVA: 0x000163D8 File Offset: 0x000145D8
			public bool method_0(Class296 class296_0)
			{
				return class296_0.bool_10 && class296_0.method_3() == this.string_0;
			}
		}

		// Token: 0x0200035A RID: 858
		[CompilerGenerated]
		private sealed class Class354
		{
			// Token: 0x040014FF RID: 5375
			public Class115.Class352 class352_0;

			// Token: 0x04001500 RID: 5376
			public VoidDelegate voidDelegate_0;

			// Token: 0x06001A55 RID: 6741
			// RVA: 0x000163F5 File Offset: 0x000145F5
			public void method_0()
			{
				Class111.smethod_41(this.class352_0.string_0);
				Class809.smethod_11(this.voidDelegate_0);
			}
		}

		// Token: 0x0200035B RID: 859
		[CompilerGenerated]
		private sealed class Class355
		{
			// Token: 0x04001501 RID: 5377
			public string string_0;

			// Token: 0x04001502 RID: 5378
			public string string_1;

			// Token: 0x06001A57 RID: 6743
			// RVA: 0x00080D14 File Offset: 0x0007EF14
			public void method_0()
			{
				if (Class115.form_0 != null)
				{
					if (Class115.class125_0 != null && Class115.class125_0.method_0())
					{
						Class115.form_0.WindowState = FormWindowState.Minimized;
					}
					Class115.form_0.TopMost = false;
					Class114.bool_0 = false;
				}
				try
				{
					ProcessStartInfo startInfo = new ProcessStartInfo(this.string_0, this.string_1);
					Process.Start(startInfo);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x040014E4 RID: 5348
		[CompilerGenerated]
		private static Action<Class530> action_0;

		// Token: 0x040014B3 RID: 5299
		internal static BaseGLControl baseGLControl_0;

		// Token: 0x04001431 RID: 5169
		private static bool bool_10;

		// Token: 0x0400143F RID: 5183
		internal static bool bool_11;

		// Token: 0x04001442 RID: 5186
		internal static bool bool_12;

		// Token: 0x04001447 RID: 5191
		internal static bool bool_13;

		// Token: 0x04001453 RID: 5203
		internal static bool bool_14 = true;

		// Token: 0x0400145B RID: 5211
		public static bool bool_15;

		// Token: 0x0400145D RID: 5213
		internal static bool bool_16;

		// Token: 0x0400145F RID: 5215
		internal static bool bool_17;

		// Token: 0x04001461 RID: 5217
		internal static bool bool_18;

		// Token: 0x04001462 RID: 5218
		internal static bool bool_19;

		// Token: 0x04001478 RID: 5240
		internal static bool bool_20 = true;

		// Token: 0x04001496 RID: 5270
		internal static bool bool_21;

		// Token: 0x04001497 RID: 5271
		internal static bool bool_22;

		// Token: 0x0400149F RID: 5279
		private static bool bool_23;

		// Token: 0x040014A2 RID: 5282
		private static bool bool_24;

		// Token: 0x040014A3 RID: 5283
		internal static bool bool_25;

		// Token: 0x040014AC RID: 5292
		internal static bool bool_26;

		// Token: 0x040014B4 RID: 5300
		internal static bool bool_27;

		// Token: 0x040014BC RID: 5308
		private static bool bool_28;

		// Token: 0x040014C2 RID: 5314
		private bool bool_29;

		// Token: 0x040014C8 RID: 5320
		internal static bool bool_30;

		// Token: 0x040014CA RID: 5322
		public static bool bool_31;

		// Token: 0x040014CB RID: 5323
		public static bool bool_32;

		// Token: 0x040014D0 RID: 5328
		private bool bool_33;

		// Token: 0x040014D2 RID: 5330
		private static bool bool_34;

		// Token: 0x040014D3 RID: 5331
		internal static bool bool_35;

		// Token: 0x0400142F RID: 5167
		private static bool bool_9;

		// Token: 0x04001434 RID: 5172
		internal static char[] char_0 = new char[]
		{
			'b',
			'a',
			'n',
			'c',
			'h',
			'o'
		};

		// Token: 0x040014BD RID: 5309
		internal static Class109 class109_0;

		// Token: 0x04001435 RID: 5173
		private static Class111 class111_0;

		// Token: 0x040014BB RID: 5307
		private Class112 class112_0;

		// Token: 0x0400143B RID: 5179
		internal static Class114 class114_0;

		// Token: 0x0400143E RID: 5182
		internal static Class115 class115_0;

		// Token: 0x0400143D RID: 5181
		internal static Class125 class125_0;

		// Token: 0x040014A8 RID: 5288
		internal static readonly Class47 class47_0 = new Class47();

		// Token: 0x04001458 RID: 5208
		internal static Class521 class521_0;

		// Token: 0x04001463 RID: 5219
		internal static Class522 class522_0;

		// Token: 0x0400145A RID: 5210
		internal static Class525 class525_0;

		// Token: 0x04001446 RID: 5190
		internal static Class531 class531_0;

		// Token: 0x04001460 RID: 5216
		internal static Class533 class533_0;

		// Token: 0x040014AF RID: 5295
		internal static Class533 class533_1;

		// Token: 0x040014B7 RID: 5303
		internal static Class535 class535_0;

		// Token: 0x04001440 RID: 5184
		internal static Class582 class582_0;

		// Token: 0x04001433 RID: 5171
		internal static Class605<string> class605_0;

		// Token: 0x0400149E RID: 5278
		internal static Class61 class61_0;

		// Token: 0x040014C5 RID: 5317
		internal static Class623<string> class623_0 = "unknown";

		// Token: 0x040014C6 RID: 5318
		internal static Class623<string> class623_1 = "unknown";

		// Token: 0x040014C7 RID: 5319
		internal static Class623<string> class623_2 = "unknown";

		// Token: 0x04001459 RID: 5209
		internal static Class729 class729_0 = new Class729();

		// Token: 0x04001452 RID: 5202
		internal static Class731 class731_0;

		// Token: 0x040014BE RID: 5310
		internal static Class80 class80_0;

		// Token: 0x0400145C RID: 5212
		internal static Class81 class81_0;

		// Token: 0x04001464 RID: 5220
		internal static Class83 class83_0;

		// Token: 0x040014B8 RID: 5304
		internal static Class861 class861_0;

		// Token: 0x04001445 RID: 5189
		internal static Class882 class882_0;

		// Token: 0x040014A9 RID: 5289
		internal static Class89 class89_0;

		// Token: 0x0400144A RID: 5194
		internal static Class911 class911_0;

		// Token: 0x0400144B RID: 5195
		internal static Class911 class911_1;

		// Token: 0x0400144C RID: 5196
		internal static Class911 class911_2;

		// Token: 0x0400144D RID: 5197
		internal static Class911 class911_3;

		// Token: 0x0400144E RID: 5198
		internal static Class911 class911_4;

		// Token: 0x0400144F RID: 5199
		internal static Class911 class911_5;

		// Token: 0x04001481 RID: 5249
		internal static ContentManager contentManager_0;

		// Token: 0x0400143C RID: 5180
		private static Control control_0;

		// Token: 0x04001432 RID: 5170
		private static DateTime dateTime_0;

		// Token: 0x04001494 RID: 5268
		private static Delegate1 delegate1_0;

		// Token: 0x04001495 RID: 5269
		private static Delegate1 delegate1_1;

		// Token: 0x0400143A RID: 5178
		internal static double double_0;

		// Token: 0x04001448 RID: 5192
		internal static double double_1;

		// Token: 0x040014AD RID: 5293
		private static double double_10 = 8.0;

		// Token: 0x040014AE RID: 5294
		private static double double_11 = 4.0;

		// Token: 0x040014B0 RID: 5296
		internal static double double_12;

		// Token: 0x040014B1 RID: 5297
		internal static double double_13;

		// Token: 0x040014B2 RID: 5298
		internal static double double_14;

		// Token: 0x04001454 RID: 5204
		internal static double double_2;

		// Token: 0x04001455 RID: 5205
		private static double double_3;

		// Token: 0x04001456 RID: 5206
		private static double double_4;

		// Token: 0x04001457 RID: 5207
		private static double double_5;

		// Token: 0x04001465 RID: 5221
		internal static double double_6;

		// Token: 0x0400147E RID: 5246
		private double double_7;

		// Token: 0x0400149A RID: 5274
		internal static double double_8;

		// Token: 0x040014A1 RID: 5281
		internal static double double_9;

		// Token: 0x04001437 RID: 5175
		internal static EditorControl editorControl_0;

		// Token: 0x0400149B RID: 5275
		internal static Enum113 enum113_0 = Enum113.const_2;

		// Token: 0x0400142E RID: 5166
		internal static Enum32 enum32_0;

		// Token: 0x040014E8 RID: 5352
		[CompilerGenerated]
		private static EventHandler eventHandler_10;

		// Token: 0x040014E9 RID: 5353
		[CompilerGenerated]
		private static EventHandler eventHandler_11;

		// Token: 0x040014ED RID: 5357
		[CompilerGenerated]
		private static EventHandler eventHandler_12;

		// Token: 0x040014A6 RID: 5286
		private static EventHandler eventHandler_4;

		// Token: 0x040014A7 RID: 5287
		private static EventHandler eventHandler_5;

		// Token: 0x040014DE RID: 5342
		[CompilerGenerated]
		private static EventHandler eventHandler_6;

		// Token: 0x040014DF RID: 5343
		[CompilerGenerated]
		private static EventHandler eventHandler_7;

		// Token: 0x040014E0 RID: 5344
		[CompilerGenerated]
		private static EventHandler eventHandler_8;

		// Token: 0x040014E7 RID: 5351
		[CompilerGenerated]
		private static EventHandler eventHandler_9;

		// Token: 0x04001484 RID: 5252
		internal static float float_0 = (float)Class115.int_23 * 0.8f;

		// Token: 0x04001487 RID: 5255
		internal static float float_1;

		// Token: 0x04001488 RID: 5256
		internal static float float_2 = 1f;

		// Token: 0x04001489 RID: 5257
		internal static float float_3 = (float)Class115.int_22 * 0.8f;

		// Token: 0x0400148F RID: 5263
		internal static float float_4;

		// Token: 0x040014B9 RID: 5305
		internal static float float_5;

		// Token: 0x040014BA RID: 5306
		internal static float float_6;

		// Token: 0x04001438 RID: 5176
		internal static Form form_0;

		// Token: 0x04001441 RID: 5185
		internal static Interface16 interface16_0;

		// Token: 0x04001444 RID: 5188
		internal static int int_0;

		// Token: 0x04001451 RID: 5201
		internal static int int_1;

		// Token: 0x04001479 RID: 5241
		private int int_10;

		// Token: 0x0400147A RID: 5242
		private int[] int_11 = new int[60];

		// Token: 0x0400147B RID: 5243
		private int int_12 = -1;

		// Token: 0x0400147C RID: 5244
		private int int_13 = 20;

		// Token: 0x0400147D RID: 5245
		private int int_14;

		// Token: 0x0400147F RID: 5247
		private int int_15;

		// Token: 0x04001480 RID: 5248
		private static int int_16;

		// Token: 0x04001482 RID: 5250
		internal static int int_17 = 384;

		// Token: 0x04001483 RID: 5251
		internal static int int_18 = 512;

		// Token: 0x0400148A RID: 5258
		internal static int int_19 = 480;

		// Token: 0x0400145E RID: 5214
		internal static int int_2;

		// Token: 0x0400148B RID: 5259
		internal static int int_20 = 640;

		// Token: 0x0400148C RID: 5260
		internal static int int_21 = 820;

		// Token: 0x0400148D RID: 5261
		internal static int int_22 = 640;

		// Token: 0x0400148E RID: 5262
		internal static int int_23 = 480;

		// Token: 0x04001490 RID: 5264
		internal static int int_24 = 768;

		// Token: 0x04001491 RID: 5265
		internal static int int_25;

		// Token: 0x04001492 RID: 5266
		internal static int int_26;

		// Token: 0x04001493 RID: 5267
		private static int int_27 = 0;

		// Token: 0x040014A4 RID: 5284
		internal static int int_28;

		// Token: 0x040014B5 RID: 5301
		internal static int int_29;

		// Token: 0x04001466 RID: 5222
		private static int int_3 = 0;

		// Token: 0x040014B6 RID: 5302
		internal static int int_30;

		// Token: 0x040014C3 RID: 5315
		private int int_31;

		// Token: 0x040014C4 RID: 5316
		public static int int_32;

		// Token: 0x040014CF RID: 5327
		internal static int int_33;

		// Token: 0x04001467 RID: 5223
		private static int int_4 = 0;

		// Token: 0x04001473 RID: 5235
		private static int int_5 = 1;

		// Token: 0x04001474 RID: 5236
		private static int int_6 = 2;

		// Token: 0x04001475 RID: 5237
		private static int int_7 = 4;

		// Token: 0x04001476 RID: 5238
		private static int int_8 = 8;

		// Token: 0x04001477 RID: 5239
		private static int int_9 = 786;

		// Token: 0x04001436 RID: 5174
		private static List<Class89> list_2 = new List<Class89>();

		// Token: 0x040014CE RID: 5326
		public static long long_0;

		// Token: 0x04001439 RID: 5177
		private static NotifyIcon notifyIcon_0;

		// Token: 0x04001443 RID: 5187
		internal static readonly NumberFormatInfo numberFormatInfo_0 = new CultureInfo("en-US", false).NumberFormat;

		// Token: 0x0400149C RID: 5276
		internal static OsuModes osuModes_0 = OsuModes.Menu;

		// Token: 0x0400149D RID: 5277
		internal static OsuModes osuModes_1 = OsuModes.Unknown;

		// Token: 0x040014A0 RID: 5280
		internal static OsuModes osuModes_2 = OsuModes.Unknown;

		// Token: 0x040014CD RID: 5325
		internal static Point point_0;

		// Token: 0x040014E1 RID: 5345
		[CompilerGenerated]
		private static Predicate<Class296> predicate_0;

		// Token: 0x040014E6 RID: 5350
		[CompilerGenerated]
		private static Predicate<Class750> predicate_1;

		// Token: 0x040014D1 RID: 5329
		internal static Process[] process_0;

		// Token: 0x040014C0 RID: 5312
		private static Queue<VoidDelegate> queue_0 = new Queue<VoidDelegate>();

		// Token: 0x04001498 RID: 5272
		internal static Rectangle rectangle_0;

		// Token: 0x04001499 RID: 5273
		internal static Rectangle rectangle_1;

		// Token: 0x040014AB RID: 5291
		internal static Rectangle rectangle_2;

		// Token: 0x04001470 RID: 5232
		internal static ScreenMode screenMode_0;

		// Token: 0x040014CC RID: 5324
		internal static Size size_0;

		// Token: 0x04001449 RID: 5193
		internal static SpriteBatch spriteBatch_0;

		// Token: 0x04001450 RID: 5200
		internal static Stopwatch stopwatch_0 = new Stopwatch();

		// Token: 0x04001471 RID: 5233
		internal static string string_0;

		// Token: 0x040014A5 RID: 5285
		private readonly string string_1;

		// Token: 0x040014C9 RID: 5321
		internal static string string_2 = "osu!";

		// Token: 0x040014AA RID: 5290
		private static TextInputControl textInputControl_0;

		// Token: 0x040014DD RID: 5341
		[CompilerGenerated]
		private static ThreadStart threadStart_0;

		// Token: 0x04001472 RID: 5234
		private static Thread thread_0;

		// Token: 0x040014BF RID: 5311
		private static Thread thread_1;

		// Token: 0x040014C1 RID: 5313
		internal static Thread thread_2;

		// Token: 0x04001485 RID: 5253
		internal static Vector2 vector2_0;

		// Token: 0x04001486 RID: 5254
		internal static Vector2 vector2_1;

		// Token: 0x04001430 RID: 5168
		internal static VoidDelegate voidDelegate_0;

		// Token: 0x04001468 RID: 5224
		private static VoidDelegate voidDelegate_1;

		// Token: 0x040014D5 RID: 5333
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_10;

		// Token: 0x040014D6 RID: 5334
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_11;

		// Token: 0x040014D7 RID: 5335
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_12;

		// Token: 0x040014D8 RID: 5336
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_13;

		// Token: 0x040014D9 RID: 5337
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_14;

		// Token: 0x040014DA RID: 5338
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_15;

		// Token: 0x040014DB RID: 5339
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_16;

		// Token: 0x040014DC RID: 5340
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_17;

		// Token: 0x040014E2 RID: 5346
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_18;

		// Token: 0x040014E3 RID: 5347
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_19;

		// Token: 0x04001469 RID: 5225
		private static VoidDelegate voidDelegate_2;

		// Token: 0x040014E5 RID: 5349
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_20;

		// Token: 0x040014EA RID: 5354
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_21;

		// Token: 0x040014EB RID: 5355
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_22;

		// Token: 0x040014EC RID: 5356
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_23;

		// Token: 0x0400146A RID: 5226
		private static VoidDelegate voidDelegate_3;

		// Token: 0x0400146B RID: 5227
		private static VoidDelegate voidDelegate_4;

		// Token: 0x0400146C RID: 5228
		private static VoidDelegate voidDelegate_5;

		// Token: 0x0400146D RID: 5229
		private static VoidDelegate voidDelegate_6;

		// Token: 0x0400146E RID: 5230
		private static VoidDelegate voidDelegate_7;

		// Token: 0x0400146F RID: 5231
		private static VoidDelegate voidDelegate_8;

		// Token: 0x040014D4 RID: 5332
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_9;

		// Token: 0x060019B0 RID: 6576
		// RVA: 0x0007B4A4 File Offset: 0x000796A4
		internal Class115(string string_3)
		{
			this.string_1 = string_3;
			Application.EnableVisualStyles();
			Class115.form_0 = (Form)Control.FromHandle(base.method_4().vmethod_1());
			string filePath = Environment.CurrentDirectory + "\\" + Process.GetCurrentProcess().ProcessName.Replace(".vshost", string.Empty) + ".exe";
			try
			{
				Class115.form_0.Icon = Icon.ExtractAssociatedIcon(filePath);
			}
			catch
			{
			}
			Class115.form_0.AllowDrop = true;
			Class115.form_0.FormClosing += new FormClosingEventHandler(this.method_29);
			Class115.form_0.DragEnter += new DragEventHandler(Class115.smethod_10);
			Class115.form_0.DragDrop += new DragEventHandler(Class115.smethod_9);
			Class115.form_0.Deactivate += new EventHandler(this.method_27);
			Class115.form_0.Activated += new EventHandler(this.method_28);
			Class115.form_0.SizeChanged += new EventHandler(this.method_26);
			Class115.smethod_77(new EventHandler(Class115.smethod_72));
			Class115.thread_2 = Thread.CurrentThread;
			Class115.class114_0 = this;
			Class115.class115_0 = this;
			Class341.Initialize();
			if (Class341.class608_17 == 5)
			{
				Class341.class608_17.Value = 0;
				Class341.smethod_3();
				Class905.smethod_11(false);
			}
			string arg_1A9_0 = Class341.class605_3;
			bool arg_1A9_1 = Class341.class605_15 != Class344.smethod_0();
			if (Class115.voidDelegate_13 == null)
			{
				Class115.voidDelegate_13 = new VoidDelegate(Class115.smethod_102);
			}
			Class41.smethod_0(arg_1A9_0, arg_1A9_1, Class115.voidDelegate_13, Resources.en);
			KeyboardState state = Keyboard.GetState();
			if (state.IsKeyDown(160) || state.IsKeyDown(161))
			{
				Configuration configuration = new Configuration();
				configuration.ShowDialog();
			}
			if (Class905.smethod_16())
			{
				Class341.class605_18.Value = "d3d";
				Class341.class605_26.Value = FrameSync.Limit120;
			}
			if (Class341.class605_18 == "opengl")
			{
				Class115.bool_27 = true;
			}
			else
			{
				Class115.bool_26 = true;
			}
			this.bool_6 = Class115.bool_26;
			Class115.class125_0 = new Class125(this);
			Class115.class125_0.method_15(Class341.smethod_0());
			Class115.class125_0.method_16(new EventHandler<EventArgs1>(Class115.smethod_7));
			if (Class341.dictionary_0.ContainsKey("GraphicsFix"))
			{
				Class115.class125_0.method_13(54);
				Class115.class125_0.method_7(9);
			}
			Class115.contentManager_0 = new ResourceContentManager(base.method_3(), ResourcesStore.get_ResourceManager());
			Class115.size_0 = Class787.smethod_4();
			Class115.point_0 = Class787.smethod_5();
			Class115.smethod_4();
		}

		// Token: 0x060019E2 RID: 6626
		// RVA: 0x0007E318 File Offset: 0x0007C518
		protected override void Draw()
		{
			lock (BaseGLControl.object_0)
			{
				while (!this.bool_33)
				{
					Monitor.Wait(BaseGLControl.object_0);
				}
				try
				{
					Class911.smethod_1();
					Class115.double_14 += 1.0;
					Class911 class = null;
					if (Class802.bool_13)
					{
						class = Class911.smethod_5();
					}
					if (class != null && class.class531_1 != null)
					{
						Class115.class535_0.Text = class.class531_1.string_0;
					}
					else
					{
						Class115.class535_0.Text = null;
					}
					Class297.smethod_13();
					Class802.smethod_21();
					if (Class115.bool_27)
					{
						Gl.glClear(16384u);
					}
					if (Class115.bool_26)
					{
						Class115.class125_0.GraphicsDevice.Clear(Color.get_Black());
					}
					bool flag = Class802.smethod_0() && Class115.osuModes_1 == OsuModes.Play;
					if (Class115.bool_26 && Class341.class606_4)
					{
						Class733.smethod_1();
					}
					Class115.class83_0.Draw();
					base.Draw();
					Class115.class911_0.Draw();
					if (flag)
					{
						Class115.class911_1.Draw();
					}
					Class115.class80_0.Draw();
					this.class112_0.Draw();
					Class115.class911_2.Draw();
					Class115.class111_0.Draw();
					Class109.Draw();
					Class115.class81_0.Draw();
					if (Class115.class522_0 != null)
					{
						Class115.class522_0.Draw();
					}
					if (Class115.class89_0 != null)
					{
						Class115.class89_0.Draw();
					}
					Class115.class911_3.Draw();
					Class115.class525_0.Draw();
					if (!flag)
					{
						Class115.class911_1.Draw();
					}
					Class115.class911_5.Draw();
					if (Class115.enum113_0 != Enum113.const_2 || Class115.class911_4.float_0 > 0f)
					{
						Class115.class911_4.Draw();
					}
					if (Class115.class521_0 != null)
					{
						Class115.class521_0.Draw();
					}
					Class115.class83_0.method_5();
					if (Class115.bool_26 && Class341.class606_4)
					{
						Class733.smethod_2();
					}
					if (Class115.bool_27)
					{
						Class115.baseGLControl_0.Draw();
					}
				}
				catch (Exception exception_)
				{
					if (Class115.int_16++ > 1 || Class115.osuModes_1 == OsuModes.Exit || Class115.osuModes_0 == OsuModes.Exit)
					{
						throw;
					}
					Class115.smethod_39(exception_);
				}
			}
			Class115.long_0 += 1L;
		}

		// Token: 0x06001A14 RID: 6676
		[SuppressUnmanagedCodeSecurity]
		[DllImport("user32.dll")]
		internal static extern bool FlashWindow(IntPtr intptr_0, bool bool_36);

		// Token: 0x06001A15 RID: 6677
		[DllImport("user32.dll")]
		public static extern bool GetLayeredWindowAttributes(IntPtr intptr_0, ref IntPtr intptr_1, ref IntPtr intptr_2, ref IntPtr intptr_3);

		// Token: 0x060019C8 RID: 6600
		// RVA: 0x0007C7E4 File Offset: 0x0007A9E4
		protected override void Initialize()
		{
			if (Class115.bool_16)
			{
				Class344.string_0 = "tourney";
				Class331.class608_2.Value = 35;
				Class331.class608_1.Value = (Class115.bool_17 ? 100 : 0);
				Class331.class608_0.Value = ((Class115.int_2 == 0) ? 100 : 0);
				Class115.form_0.FormBorderStyle = FormBorderStyle.None;
				string value = Tournament.class43_0.GetValue<string>("privateserver", "");
				if (!string.IsNullOrEmpty(value))
				{
					Class809.smethod_43(new string[]
					{
						value
					});
				}
				Class47 arg_AB_0 = Class115.class47_0;
				if (Class115.voidDelegate_17 == null)
				{
					Class115.voidDelegate_17 = new VoidDelegate(Class115.smethod_106);
				}
				arg_AB_0.Add(Class115.voidDelegate_17, true);
			}
			if (Class115.threadStart_0 == null)
			{
				Class115.threadStart_0 = new ThreadStart(Class115.smethod_107);
			}
			Class115.thread_0 = new Thread(Class115.threadStart_0);
			Class115.bool_32 = (File.Exists("osu!gameplay.dll") && File.Exists("osu!ui.dll"));
			Class747.Initialize();
			Class62.Mode = Class68.class605_0;
			Class115.thread_0.IsBackground = true;
			Class115.thread_0.Start();
			Class115.control_0 = Control.FromHandle(base.method_4().vmethod_1());
			string a = "\\\\.\\DISPLAY" + Class341.class608_13;
			Class115.class114_0.method_4().method_4(new EventHandler(this.method_30));
			Class115.form_0.LocationChanged += new EventHandler(Class115.smethod_27);
			Class115.form_0.SizeChanged += new EventHandler(Class115.smethod_27);
			Class115.form_0.ResizeEnd += new EventHandler(Class115.smethod_27);
			Class115.form_0.Activated += new EventHandler(Class115.smethod_27);
			Class115.form_0.ClientSizeChanged += new EventHandler(Class115.smethod_27);
			if (Class115.eventHandler_6 == null)
			{
				Class115.eventHandler_6 = new EventHandler(Class115.smethod_108);
			}
			base.method_5(Class115.eventHandler_6);
			if (Class115.eventHandler_7 == null)
			{
				Class115.eventHandler_7 = new EventHandler(Class115.smethod_109);
			}
			base.method_7(Class115.eventHandler_7);
			if (a != Screen.PrimaryScreen.DeviceName)
			{
				try
				{
					Class115.class114_0.method_4().vmethod_5(Class341.class605_8 == ScreenMode.Fullscreen);
					Class115.class114_0.method_4().vmethod_6(a, Class341.class608_11, Class341.class608_5);
				}
				catch
				{
					try
					{
						Class341.class608_13.Value = int.Parse(Screen.PrimaryScreen.DeviceName[Screen.PrimaryScreen.DeviceName.Length - 1].ToString());
					}
					catch
					{
					}
				}
				Class115.int_30 = Screen.PrimaryScreen.Bounds.Width;
				Class115.int_29 = Screen.PrimaryScreen.Bounds.Height;
			}
			List<string> list = new List<string>
			{
				"1812a3605d6a596a67b5f2250f82307d",
				"83d489cce95f15b275e480de15bafa88",
				"f3bf7a5f31a97c2e01dbfd88d49fdcb0",
				"80ea471ed63c89c4b7db3c3b70ee20a3"
			};
			try
			{
				if (!Directory.Exists(Class115.class605_0))
				{
					Directory.CreateDirectory(Class115.class605_0);
				}
				if (!Directory.Exists("Skins"))
				{
					Directory.CreateDirectory("Skins");
				}
				if (!Directory.Exists("Data"))
				{
					Directory.CreateDirectory("Data");
				}
				if (!Directory.Exists("Data/r"))
				{
					Directory.CreateDirectory("Data/r");
				}
				if (!Directory.Exists("Data/a"))
				{
					Directory.CreateDirectory("Data/a");
				}
				File.Delete("error_update.txt");
				try
				{
					List<string> list2 = new List<string>();
					list2.AddRange(Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)));
					list2.AddRange(Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)));
					foreach (string current in list2)
					{
						if (list.Contains(Class33.smethod_2("osu!" + Path.GetFileName(current).ToLower())))
						{
							Class115.bool_35 = true;
						}
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
			try
			{
				new Font("Aller Light", 10f);
			}
			catch (Exception)
			{
				Class792.smethod_0("You don't seem to have the Windows default font 'Tahoma' installed.  Please obtain and install this font!");
			}
			Class466.Initialize(false);
			if (Class115.bool_27)
			{
				Class115.smethod_32();
			}
			Class802.Initialize();
			Class115.class911_2 = new Class911(true);
			Class115.class911_2.bool_14 = true;
			Class115.class911_3 = new Class911(true);
			Class115.class911_3.bool_14 = true;
			Class115.class911_4 = new Class911(true);
			Class115.class911_0 = new Class911();
			Class115.class911_1 = new Class911(true)
			{
				bool_6 = false
			};
			Class115.class911_5 = new Class911(true);
			if (Class115.bool_16)
			{
				Class115.class533_0 = new Class533(string.Empty, 90f, new Vector2(3f, 3f), 1f, true, Color.get_Yellow());
				Class115.class533_0.enum115_0 = Enum115.const_5;
				Class115.class533_0.origins_0 = Origins.TopLeft;
				Class115.class533_0.method_58(true);
				Class115.class533_0.bool_16 = true;
				Class533 arg_545_0 = Class115.class533_0;
				if (Class115.eventHandler_8 == null)
				{
					Class115.eventHandler_8 = new EventHandler(Class115.smethod_110);
				}
				arg_545_0.method_51(Class115.eventHandler_8);
				Class115.class911_3.Add(Class115.class533_0);
				Class621.bool_0 = true;
			}
			Class115.float_4 = (float)Class115.int_23 / (float)Class115.int_19;
			Class115.class731_0 = Class731.smethod_8(new byte[]
			{
				255,
				255,
				255,
				255
			}, 1, 1, false);
			Class115.class531_0 = new Class531(Class115.class731_0, Enum115.const_4, Origins.TopLeft, Enum114.const_0, Vector2.get_Zero(), 0f, true, Color.get_Black(), null);
			Class115.smethod_20(null, null, null, false, false);
			Class885.Initialize();
			Class331.Initialize();
			Class115.class83_0 = new Class83();
			Class115.class525_0 = new Class525();
			Class115.class911_4.Add(Class115.class531_0);
			float arg_615_0 = Class611.smethod_0(Class115.form_0, false) / 96f;
			Class115.class535_0 = new Class535(string.Empty, 11f, Vector2.get_Zero(), Vector2.get_Zero(), 1f, true, Color.get_White(), false);
			Class115.class911_5.Add(Class115.class535_0);
			Class115.class533_1 = new Class536(string.Empty, "fps", 4, Enum115.const_5, Origins.BottomRight, Enum114.const_0, new Vector2(0f, (float)Class115.smethod_44()), 1f, true, Color.get_White(), true)
			{
				bool_21 = true
			};
			Class115.class533_1.nullable_2 = new bool?(true);
			if (Class341.class606_27)
			{
				Class115.class911_3.Add(Class115.class533_1);
			}
			if (Class115.bool_26)
			{
				Class115.int_0 = Class115.class125_0.GraphicsDevice.get_GraphicsDeviceCapabilities().get_PixelShaderVersion().Major;
			}
			Class115.class80_0 = new Class80(this);
			this.class112_0 = new Class112(this);
			Class115.class111_0 = new Class111(this);
			Class115.class81_0 = new Class81();
			Class115.class109_0 = new Class109(this);
			Class115.class861_0 = new Class861(Class341.class605_20);
			Class115.class861_0.method_10(new Vector2(0f, 0f), false, 0);
			Class115.class861_0.method_16(true);
			Class115.class861_0.list_0[0].bool_12 = true;
			Class115.class861_0.list_0[0].method_2(new EventHandler(Class115.smethod_34));
			Class809.smethod_19();
			OsuModes osuModes = Class115.smethod_81(new string[]
			{
				this.string_1
			});
			Class115.osuModes_0 = ((osuModes != OsuModes.Unknown) ? osuModes : Class115.osuModes_0);
			if (Class115.bool_30)
			{
				List<Class296> arg_7E7_0 = Class466.list_3;
				if (Class115.predicate_0 == null)
				{
					Class115.predicate_0 = new Predicate<Class296>(Class115.smethod_111);
				}
				Class466.smethod_21(arg_7E7_0.Find(Class115.predicate_0));
				Class876.class623_0 |= Mods.Autoplay;
				Class115.osuModes_0 = OsuModes.Play;
			}
			base.method_0().Add(Class115.class111_0);
			base.method_0().Add(this.class112_0);
			base.method_0().Add(Class115.class109_0);
			Class115.enum113_0 = Enum113.const_3;
			Class115.smethod_72(this, null);
			Class798.Initialize();
			Class115.smethod_26();
			base.Initialize();
			if (!string.IsNullOrEmpty(Class341.class605_15))
			{
				Class341.class608_17.Value = 0;
				if (Class341.class605_15 != Class344.smethod_0())
				{
					Class115.smethod_2(Enum32.const_5);
				}
				else if (Class341.class606_64)
				{
					Class115.smethod_2(Enum32.const_5);
				}
			}
			Class341.class605_15.Value = Class344.smethod_0();
			Class115.stopwatch_0.Start();
			Class77.smethod_3();
		}

		// Token: 0x060019AF RID: 6575
		// RVA: 0x0007B41C File Offset: 0x0007961C
		internal double method_25()
		{
			switch (Class341.class605_26.Value)
			{
			case FrameSync.Limit120:
				return 8.3333333333333339;
			case FrameSync.Unlimited:
				if (!Class62.bool_12)
				{
					return 8.3333333333333339;
				}
				return 0.01;
			case FrameSync.CompletelyUnlimited:
				return 0.01;
			case FrameSync.Limit240:
				return 1000.0 / (double)Class341.class608_0.Value;
			}
			return 16.666666666666668;
		}

		// Token: 0x060019B1 RID: 6577
		// RVA: 0x0007B778 File Offset: 0x00079978
		private void method_26(object sender, EventArgs e)
		{
			if (Class115.form_0.WindowState == FormWindowState.Maximized)
			{
				Class115.form_0.WindowState = FormWindowState.Normal;
				Class115.smethod_20(null, null, new ScreenMode?(ScreenMode.BorderlessWindow), true, false);
			}
		}

		// Token: 0x060019B9 RID: 6585
		// RVA: 0x0007BAE8 File Offset: 0x00079CE8
		private void method_27(object sender, EventArgs e)
		{
			if (Class115.bool_16)
			{
				return;
			}
			if (Class62.bool_12 && !Class802.smethod_0())
			{
				Class115.form_0.BringToFront();
				Class115.form_0.Focus();
				Class115.form_0.TopMost = true;
			}
			else
			{
				Class115.form_0.TopMost = false;
			}
			if (Class115.voidDelegate_5 != null)
			{
				Class115.voidDelegate_5();
			}
		}

		// Token: 0x060019BA RID: 6586
		// RVA: 0x00015E48 File Offset: 0x00014048
		private void method_28(object sender, EventArgs e)
		{
			if (Class115.voidDelegate_4 != null)
			{
				Class115.voidDelegate_4();
			}
		}

		// Token: 0x060019BB RID: 6587
		// RVA: 0x0007BB4C File Offset: 0x00079D4C
		private void method_29(object sender, FormClosingEventArgs e)
		{
			if (Class111.bool_1 && Class111.bool_2)
			{
				Class111.smethod_21(false);
				e.Cancel = true;
				return;
			}
			switch (Class115.osuModes_1)
			{
			case OsuModes.Edit:
			{
				Editor editor = Class115.class61_0 as Editor;
				if (editor != null)
				{
					editor.method_81();
				}
				e.Cancel = true;
				return;
			}
			case OsuModes.Play:
				Class858.smethod_4(true);
				if (Class115.class61_0 is Class64)
				{
					Class72.smethod_3();
				}
				else if (Class115.bool_25)
				{
					Class115.smethod_70(OsuModes.Edit, false);
				}
				else
				{
					Class115.smethod_70(OsuModes.SelectPlay, false);
				}
				e.Cancel = true;
				return;
			case OsuModes.SkinSelect:
			case OsuModes.Lobby:
			case OsuModes.OnlineSelection:
			case OsuModes.OptionsOffsetWizard:
				Class115.smethod_70(OsuModes.Menu, false);
				e.Cancel = true;
				return;
			case OsuModes.Rank:
				Class115.smethod_70(OsuModes.SelectPlay, false);
				e.Cancel = true;
				return;
			case OsuModes.MatchSetup:
				Class115.smethod_70(OsuModes.Lobby, false);
				e.Cancel = true;
				return;
			case OsuModes.RankingVs:
			case OsuModes.RankingTagCoop:
			case OsuModes.RankingTeam:
				Class115.smethod_70(OsuModes.MatchSetup, false);
				e.Cancel = true;
				return;
			}
			if (Class115.osuModes_1 != OsuModes.Exit && Class115.osuModes_1 != OsuModes.Update)
			{
				Class115.smethod_69(false);
				e.Cancel = true;
			}
		}

		// Token: 0x060019D4 RID: 6612
		// RVA: 0x0007D630 File Offset: 0x0007B830
		private void method_30(object sender, EventArgs e)
		{
			if (Class115.bool_14)
			{
				return;
			}
			string deviceName = Screen.FromHandle(Class115.class114_0.method_4().vmethod_1()).DeviceName;
			try
			{
				Class341.class608_13.Value = ((deviceName.IndexOf("2") >= 0) ? 2 : 1);
			}
			catch
			{
			}
		}

		// Token: 0x060019D7 RID: 6615
		// RVA: 0x0007D690 File Offset: 0x0007B890
		private void method_31(int int_34)
		{
			if (this.int_12 == -1)
			{
				this.method_32();
			}
			if (this.int_11[this.int_12] == this.int_13)
			{
				this.int_11[this.int_12] = int_34;
				int num = 0;
				int[] array = this.int_11;
				for (int i = 0; i < array.Length; i++)
				{
					int val = array[i];
					num = Math.Max(num, val);
					if (num == int_34)
					{
						break;
					}
				}
				this.int_13 = num;
			}
			else
			{
				this.int_11[this.int_12] = int_34;
			}
			this.int_12 = (this.int_12 + 1) % 60;
		}

		// Token: 0x060019D8 RID: 6616
		// RVA: 0x0007D720 File Offset: 0x0007B920
		private void method_32()
		{
			for (int i = 0; i < 60; i++)
			{
				this.int_11[i] = 20;
			}
			this.int_12 = 0;
			this.int_13 = 20;
		}

		// Token: 0x060019DA RID: 6618
		// RVA: 0x0007DAE8 File Offset: 0x0007BCE8
		private void method_33()
		{
			if (Class115.bool_16)
			{
				return;
			}
			OsuModes osuModes = Class115.osuModes_1;
			if (osuModes != OsuModes.Play && osuModes != OsuModes.MatchSetup)
			{
				if (osuModes != OsuModes.BeatmapImport)
				{
					this.int_14 = Class115.int_1;
					try
					{
						Class341.smethod_3();
						Class476.smethod_6(false);
						Class908.smethod_3(false);
						Class466.smethod_29();
						Class856.smethod_0();
					}
					catch
					{
					}
					return;
				}
			}
		}

		// Token: 0x060019DC RID: 6620
		// RVA: 0x0007DBF4 File Offset: 0x0007BDF4
		private void method_34()
		{
			double num;
			if ((Class341.class605_26.Value != FrameSync.CompletelyUnlimited || Class115.osuModes_1 == OsuModes.BeatmapImport) && (!Class62.bool_12 || Class341.class605_26.Value != FrameSync.Unlimited))
			{
				num = (double)Class115.stopwatch_0.ElapsedTicks / (double)Stopwatch.Frequency * 1000.0;
				if (num - Class115.double_4 < this.method_25())
				{
					double num2 = this.method_25() - (num - Class115.double_4);
					int num3 = (int)Math.Floor(num2);
					Class115.double_5 += num2 - (double)num3;
					int num4 = (int)Math.Round(Class115.double_5);
					num4 = Math.Max(num4, -num3);
					Class115.double_5 -= (double)num4;
					num3 += num4;
					if (num3 > 0)
					{
						Thread.Sleep(num3);
					}
					double num5 = (double)Class115.stopwatch_0.ElapsedTicks / (double)Stopwatch.Frequency * 1000.0;
					Class115.double_5 += (double)num3 - (num5 - num);
				}
				else
				{
					double num6 = num - Class115.double_4 - this.method_25();
					Class115.double_5 = -num6;
				}
			}
			num = (double)Class115.stopwatch_0.ElapsedTicks / (double)Stopwatch.Frequency * 1000.0;
			Class115.double_2 = Class115.double_4;
			Class115.double_4 = num;
			Class115.int_1 = (int)Math.Round(Class115.double_4, 0);
			if (Class115.double_4 - Class115.double_3 < 16.666666666666668 && !Class115.bool_14)
			{
				Class115.bool_13 = false;
			}
			else
			{
				if (!Class115.bool_14 && (Class62.bool_9 || Class62.bool_8 || Class802.smethod_0() || (!Class115.bool_11 && Class114.bool_0 && (double)Class115.int_1 - Class115.double_3 <= 500.0)))
				{
					Class115.double_1 = Class115.double_4 - Class115.double_3;
					Class115.double_3 = Class115.double_4 - (Class115.double_1 - 16.666666666666668);
				}
				else
				{
					Class115.double_1 = Class115.double_4 - Class115.double_3;
					Class115.double_3 = Class115.double_4 - 16.666666666666668;
				}
				Class115.bool_13 = true;
				Class115.bool_14 = false;
			}
			Class115.double_9 = Class115.double_4 - Class115.double_2;
			Class115.double_0 = Class115.double_9 / 16.666666666666668;
			Class115.double_6 += Class115.double_9;
		}

		// Token: 0x060019DE RID: 6622
		// RVA: 0x0007DE38 File Offset: 0x0007C038
		private void method_35()
		{
			if (Class341.class606_27 && (Class802.bool_13 || this.int_15 > 0))
			{
				Class115.double_12 += Class115.double_9;
				Class115.double_13 += Class115.double_9;
				int num = Class114.bool_0 ? ((int)Math.Ceiling(1000.0 / this.method_25())) : 60;
				if (Class115.double_12 > 250.0)
				{
					Class115.double_12 -= 250.0;
					this.int_15 = ((Class115.double_14 == 0.0) ? 0 : ((int)Math.Ceiling(Math.Min(Class115.double_14 * 1000.0 / Class115.double_13, (double)num))));
					Class115.double_14 = 0.0;
					Class115.double_13 = 0.0;
				}
				double num2 = Math.Pow(0.05, Class115.double_9 / 1000.0);
				this.double_7 = this.double_7 * num2 + (double)this.int_15 * (1.0 - num2);
				if (Class115.bool_13)
				{
					if (Class115.class533_1 != null)
					{
						Class115.class533_1.Text = string.Format("{0:#,#}\\", (int)Math.Round(this.double_7));
					}
					if (num < 1000 && this.double_7 < (double)(num / 2))
					{
						Class115.class533_1.color_0 = Color.get_Pink();
					}
					else
					{
						Class115.class533_1.color_0 = Color.get_White();
					}
					Class115.class533_1.float_2 = Math.Max(1f, 768f / (float)Class115.int_23);
					Class115.class533_1.vector2_1.X = (float)(Class115.smethod_43() - (Class111.smethod_2() ? 12 : 2)) - Class115.class533_1.vector2_4.X / 1024f;
				}
			}
		}

		// Token: 0x060019DF RID: 6623
		// RVA: 0x0007E028 File Offset: 0x0007C228
		private void method_36()
		{
			if (Class115.enum113_0 != Enum113.const_2 || Class115.double_8 > 0.0)
			{
				if (Class341.class606_4 && !Class115.class531_0.method_7())
				{
					Class733.bool_1 = true;
					Class733.float_1 = 0.004f;
					Class733.bool_0 = false;
					Class733.bool_2 = false;
					Class733.float_0 = Class778.smethod_2((float)Class115.double_8, 0f, 100f) / 100f;
				}
				if (Class115.enum113_0 == Enum113.const_1)
				{
					if (Class115.double_8 <= 0.0)
					{
						Class115.enum113_0 = Enum113.const_2;
						if (Class115.eventHandler_4 != null)
						{
							Class115.eventHandler_4(this, null);
						}
					}
					else
					{
						Class115.double_8 = Math.Max(-1.0, Class115.double_8 - Class115.double_11 * Class115.double_0);
					}
				}
				else if (Class115.enum113_0 == Enum113.const_0)
				{
					if (Class115.double_8 >= 100.0)
					{
						Class115.enum113_0 = Enum113.const_3;
						if (Class115.eventHandler_5 != null)
						{
							Class115.eventHandler_5(this, null);
						}
					}
					else
					{
						Class115.double_8 = Math.Min(100.0, Class115.double_8 + Class115.double_10 * Class115.double_0);
						if (Class115.osuModes_0 != OsuModes.Exit)
						{
							if (Class115.osuModes_0 != OsuModes.Update)
							{
								if (Class115.osuModes_1 != OsuModes.Play)
								{
									Class331.smethod_89(Class331.int_11 - 5, false);
									goto IL_1EA;
								}
								if (Class331.int_11 > 50)
								{
									Class331.smethod_89(Class331.int_11 - 1, false);
									goto IL_1EA;
								}
								goto IL_1EA;
							}
						}
						Class331.smethod_89((int)(100.0 * Math.Pow(1.0 - Class115.double_8 / 100.0, 3.0)), true);
						Class115.form_0.Opacity = Math.Min(1.0, 3.0 - 3.0 * Class115.double_8 / 100.0);
					}
				}
			}
			IL_1EA:
			Class115.class911_4.float_0 = Class778.smethod_2((float)Class115.double_8, 0f, 100f) / 100f;
		}

		// Token: 0x06001A10 RID: 6672
		// RVA: 0x000160F3 File Offset: 0x000142F3
		internal void method_37()
		{
			this.bool_29 = true;
			base.vmethod_9();
		}

		// Token: 0x06001A13 RID: 6675
		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern bool SetForegroundWindow(IntPtr intptr_0);

		// Token: 0x060019AB RID: 6571
		// RVA: 0x0007B1EC File Offset: 0x000793EC
		internal static void smethod_0(bool bool_36, bool bool_37)
		{
			switch (Class115.enum32_0)
			{
			case Enum32.const_1:
			case Enum32.const_2:
				return;
			default:
			{
				Class115.bool_10 |= bool_36;
				if (!bool_36 && !bool_37 && (DateTime.Now - Class115.dateTime_0).TotalSeconds < 1800.0)
				{
					return;
				}
				if (Class115.bool_16)
				{
					return;
				}
				if (!string.IsNullOrEmpty(Class344.string_0) && DateTime.Now < DateTime.ParseExact(20150414.ToString(), "yyyyMMdd", Class115.numberFormatInfo_0).AddDays(7.0))
				{
					return;
				}
				Class115.smethod_2(Enum32.const_1);
				Class115.dateTime_0 = DateTime.Now;
				Class47 arg_CC_0 = Class115.class47_0;
				if (Class115.voidDelegate_9 == null)
				{
					Class115.voidDelegate_9 = new VoidDelegate(Class115.smethod_98);
				}
				arg_CC_0.Add(Class115.voidDelegate_9, false);
				return;
			}
			}
		}

		// Token: 0x060019AC RID: 6572
		// RVA: 0x0007B2CC File Offset: 0x000794CC
		internal static string smethod_1(string string_3, bool bool_36)
		{
			if (bool_36 && Class341.dictionary_0.ContainsKey("h_" + string_3))
			{
				return Class341.dictionary_0["h_" + string_3].ToString();
			}
			return (Class341.dictionary_0["h_" + string_3] = Class33.smethod_1(string_3)).ToString();
		}

		// Token: 0x060019B8 RID: 6584
		// RVA: 0x0007BAA8 File Offset: 0x00079CA8
		private static void smethod_10(object sender, DragEventArgs e)
		{
			bool dataPresent = e.Data.GetDataPresent(DataFormats.FileDrop);
			bool dataPresent2 = e.Data.GetDataPresent(DataFormats.Text);
			e.Effect = ((dataPresent || dataPresent2) ? DragDropEffects.Copy : DragDropEffects.None);
		}

		// Token: 0x06001A26 RID: 6694
		// RVA: 0x0001621C File Offset: 0x0001441C
		[CompilerGenerated]
		private static void smethod_100()
		{
			Class115.smethod_3(false);
		}

		// Token: 0x06001A27 RID: 6695
		// RVA: 0x00016224 File Offset: 0x00014424
		[CompilerGenerated]
		private static void smethod_101()
		{
			if (Class115.enum32_0 != Enum32.const_4)
			{
				if (Class115.enum32_0 != Enum32.const_5)
				{
					Class115.smethod_70(OsuModes.Update, false);
					return;
				}
			}
			Class115.smethod_85(null);
		}

		// Token: 0x06001A28 RID: 6696
		// RVA: 0x00080574 File Offset: 0x0007E774
		[CompilerGenerated]
		private static void smethod_102()
		{
			if (Class115.int_1 > 0)
			{
				Class47 arg_42_0 = Class115.class47_0;
				if (Class115.voidDelegate_14 == null)
				{
					Class115.voidDelegate_14 = new VoidDelegate(Class115.smethod_103);
				}
				arg_42_0.method_1(Class115.voidDelegate_14, Math.Max(0, Class79.int_6 + 500 - Class115.int_1), false);
				return;
			}
			Class341.class605_3.Value = Class41.string_0;
		}

		// Token: 0x06001A29 RID: 6697
		// RVA: 0x00016246 File Offset: 0x00014446
		[CompilerGenerated]
		private static void smethod_103()
		{
			Class341.class605_3.Value = Class41.string_0;
		}

		// Token: 0x06001A2A RID: 6698
		// RVA: 0x00016257 File Offset: 0x00014457
		[CompilerGenerated]
		private static void smethod_104()
		{
			Class885.smethod_9(null, true);
		}

		// Token: 0x06001A2B RID: 6699
		// RVA: 0x00016261 File Offset: 0x00014461
		[CompilerGenerated]
		private static void smethod_105()
		{
			Class601.smethod_4(Class115.control_0);
			Class601.smethod_3(Class115.control_0);
		}

		// Token: 0x06001A2C RID: 6700
		// RVA: 0x000805D8 File Offset: 0x0007E7D8
		[CompilerGenerated]
		private static void smethod_106()
		{
			Class115.form_0.StartPosition = FormStartPosition.Manual;
			if (Class115.bool_17)
			{
				Class115.form_0.Location = new Point(0, 0);
				return;
			}
			Vector2 vector = Tournament.smethod_2(Class115.int_2, true);
			Class115.form_0.Location = new Point((int)vector.X, (int)vector.Y);
			Class115.form_0.TopMost = true;
		}

		// Token: 0x06001A2D RID: 6701
		// RVA: 0x00016277 File Offset: 0x00014477
		[CompilerGenerated]
		private static void smethod_107()
		{
			if (!Class115.bool_16)
			{
				Class115.smethod_30();
				Class115.smethod_29(false);
				Class788.smethod_0();
			}
			Class784.smethod_0(Class115.string_2);
		}

		// Token: 0x06001A2E RID: 6702
		// RVA: 0x00080640 File Offset: 0x0007E840
		[CompilerGenerated]
		private static void smethod_108(object sender, EventArgs e)
		{
			if (Class115.bool_27)
			{
				if (Class341.class605_8 == ScreenMode.Fullscreen)
				{
					Class47 arg_39_0 = Class115.class47_0;
					if (Class115.voidDelegate_18 == null)
					{
						Class115.voidDelegate_18 = new VoidDelegate(Class115.smethod_112);
					}
					arg_39_0.Add(Class115.voidDelegate_18, false);
					return;
				}
			}
		}

		// Token: 0x06001A2F RID: 6703
		// RVA: 0x0008068C File Offset: 0x0007E88C
		[CompilerGenerated]
		private static void smethod_109(object sender, EventArgs e)
		{
			if (Class115.bool_27)
			{
				if (Class341.class605_8 == ScreenMode.Fullscreen)
				{
					Class47 arg_39_0 = Class115.class47_0;
					if (Class115.voidDelegate_19 == null)
					{
						Class115.voidDelegate_19 = new VoidDelegate(Class115.smethod_113);
					}
					arg_39_0.Add(Class115.voidDelegate_19, false);
					return;
				}
			}
		}

		// Token: 0x060019BC RID: 6588
		// RVA: 0x0007BC80 File Offset: 0x00079E80
		internal static void smethod_11(VoidDelegate voidDelegate_24)
		{
			VoidDelegate voidDelegate = Class115.voidDelegate_1;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Combine(voidDelegate2, voidDelegate_24);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref Class115.voidDelegate_1, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x06001A30 RID: 6704
		// RVA: 0x0001629A File Offset: 0x0001449A
		[CompilerGenerated]
		private static void smethod_110(object sender, EventArgs e)
		{
			Class115.class533_0.float_3 = 1f;
		}

		// Token: 0x06001A31 RID: 6705
		// RVA: 0x000162AB File Offset: 0x000144AB
		[CompilerGenerated]
		private static bool smethod_111(Class296 class296_0)
		{
			return class296_0.method_5() == PlayModes.Osu;
		}

		// Token: 0x06001A32 RID: 6706
		// RVA: 0x000806D8 File Offset: 0x0007E8D8
		[CompilerGenerated]
		private static void smethod_112()
		{
			if (Class115.size_0.Width != Class341.class608_12 || Class115.size_0.Height != Class341.class608_6)
			{
				Class736.smethod_0(Class341.class608_12, Class341.class608_6);
			}
		}

		// Token: 0x06001A33 RID: 6707
		// RVA: 0x0008072C File Offset: 0x0007E92C
		[CompilerGenerated]
		private static void smethod_113()
		{
			Class115.form_0.WindowState = FormWindowState.Minimized;
			if (Class115.size_0.Width != Class341.class608_12 || Class115.size_0.Height != Class341.class608_6)
			{
				Class736.smethod_0(Class115.size_0.Width, Class115.size_0.Height);
			}
		}

		// Token: 0x06001A34 RID: 6708
		// RVA: 0x000162B6 File Offset: 0x000144B6
		[CompilerGenerated]
		private static void smethod_114(Class530 class530_0)
		{
			class530_0.method_16(180, Enum70.const_0);
			class530_0.bool_0 = false;
		}

		// Token: 0x06001A35 RID: 6709
		// RVA: 0x000162CB File Offset: 0x000144CB
		[CompilerGenerated]
		private static void smethod_115()
		{
			Class115.int_16--;
		}

		// Token: 0x06001A36 RID: 6710
		// RVA: 0x000162D9 File Offset: 0x000144D9
		[CompilerGenerated]
		private static bool smethod_116(Class750 class750_0)
		{
			return class750_0.bool_0 && class750_0.class533_0.Text != null && !class750_0.class533_0.Text.StartsWith("#");
		}

		// Token: 0x06001A37 RID: 6711
		// RVA: 0x0001630A File Offset: 0x0001450A
		[CompilerGenerated]
		private static void smethod_117(object sender, EventArgs e)
		{
			Class115.smethod_70(OsuModes.Exit, false);
		}

		// Token: 0x06001A38 RID: 6712
		// RVA: 0x00016313 File Offset: 0x00014513
		[CompilerGenerated]
		private static void smethod_118(object sender, EventArgs e)
		{
			Class115.bool_23 = false;
		}

		// Token: 0x06001A39 RID: 6713
		// RVA: 0x00016313 File Offset: 0x00014513
		[CompilerGenerated]
		private static void smethod_119(object sender, EventArgs e)
		{
			Class115.bool_23 = false;
		}

		// Token: 0x060019BD RID: 6589
		// RVA: 0x0007BCB4 File Offset: 0x00079EB4
		internal static void smethod_12(VoidDelegate voidDelegate_24)
		{
			VoidDelegate voidDelegate = Class115.voidDelegate_2;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Combine(voidDelegate2, voidDelegate_24);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref Class115.voidDelegate_2, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x06001A3A RID: 6714
		// RVA: 0x0001631B File Offset: 0x0001451B
		[CompilerGenerated]
		private static void smethod_120()
		{
			Class115.smethod_80(true);
		}

		// Token: 0x06001A3B RID: 6715
		// RVA: 0x00016323 File Offset: 0x00014523
		[CompilerGenerated]
		private static void smethod_121()
		{
			Class115.FlashWindow(Class115.form_0.Handle, true);
		}

		// Token: 0x06001A3C RID: 6716
		// RVA: 0x0008078C File Offset: 0x0007E98C
		[CompilerGenerated]
		private static void smethod_122()
		{
			if (Class115.bool_27)
			{
				Class115.baseGLControl_0.method_0(true);
			}
			while (true)
			{
				VoidDelegate voidDelegate = null;
				lock (Class115.queue_0)
				{
					if (Class115.queue_0.Count != 0)
					{
						voidDelegate = Class115.queue_0.Dequeue();
					}
				}
				try
				{
					if (voidDelegate != null)
					{
						voidDelegate();
					}
				}
				catch
				{
				}
				try
				{
					Thread.Sleep(20);
				}
				catch
				{
				}
			}
		}

		// Token: 0x06001A3D RID: 6717
		// RVA: 0x00016336 File Offset: 0x00014536
		[CompilerGenerated]
		private static void smethod_123(object sender, EventArgs e)
		{
			Class115.smethod_96(false);
		}

		// Token: 0x060019BE RID: 6590
		// RVA: 0x0007BCE8 File Offset: 0x00079EE8
		internal static void smethod_13(VoidDelegate voidDelegate_24)
		{
			VoidDelegate voidDelegate = Class115.voidDelegate_3;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Combine(voidDelegate2, voidDelegate_24);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref Class115.voidDelegate_3, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x060019BF RID: 6591
		// RVA: 0x0007BD1C File Offset: 0x00079F1C
		internal static void smethod_14(VoidDelegate voidDelegate_24)
		{
			VoidDelegate voidDelegate = Class115.voidDelegate_3;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Remove(voidDelegate2, voidDelegate_24);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref Class115.voidDelegate_3, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x060019C0 RID: 6592
		// RVA: 0x0007BD50 File Offset: 0x00079F50
		internal static void smethod_15(VoidDelegate voidDelegate_24)
		{
			VoidDelegate voidDelegate = Class115.voidDelegate_5;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Combine(voidDelegate2, voidDelegate_24);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref Class115.voidDelegate_5, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x060019C1 RID: 6593
		// RVA: 0x0007BD84 File Offset: 0x00079F84
		internal static void smethod_16(VoidDelegate voidDelegate_24)
		{
			VoidDelegate voidDelegate = Class115.voidDelegate_5;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Remove(voidDelegate2, voidDelegate_24);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref Class115.voidDelegate_5, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x060019C2 RID: 6594
		// RVA: 0x0007BDB8 File Offset: 0x00079FB8
		private static void smethod_17(VoidDelegate voidDelegate_24)
		{
			VoidDelegate voidDelegate = Class115.voidDelegate_6;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Combine(voidDelegate2, voidDelegate_24);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref Class115.voidDelegate_6, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x060019C4 RID: 6596
		// RVA: 0x0007BF54 File Offset: 0x0007A154
		internal static void smethod_18(VoidDelegate voidDelegate_24)
		{
			VoidDelegate voidDelegate = Class115.voidDelegate_7;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Combine(voidDelegate2, voidDelegate_24);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref Class115.voidDelegate_7, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x060019C5 RID: 6597
		// RVA: 0x0007BF88 File Offset: 0x0007A188
		internal static void smethod_19(VoidDelegate voidDelegate_24)
		{
			VoidDelegate voidDelegate = Class115.voidDelegate_7;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Remove(voidDelegate2, voidDelegate_24);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref Class115.voidDelegate_7, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x060019AD RID: 6573
		// RVA: 0x0007B334 File Offset: 0x00079534
		internal static void smethod_2(Enum32 enum32_1)
		{
			Class115.Class345 class = new Class115.Class345();
			class.enum32_0 = enum32_1;
			Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
		}

		// Token: 0x060019C6 RID: 6598
		// RVA: 0x0007BFBC File Offset: 0x0007A1BC
		internal static void smethod_20(int? nullable_0, int? nullable_1, ScreenMode? nullable_2, bool bool_36, bool bool_37)
		{
			VoidDelegate voidDelegate = null;
			VoidDelegate voidDelegate2 = null;
			VoidDelegate voidDelegate3 = null;
			Class115.Class347 class = new Class115.Class347();
			class.nullable_0 = nullable_0;
			class.nullable_1 = nullable_1;
			class.nullable_2 = nullable_2;
			class.bool_0 = bool_36;
			if (class.nullable_0 == Class115.int_22 && class.nullable_1 == Class115.int_23 && class.nullable_2 == Class115.screenMode_0 && !bool_37)
			{
				return;
			}
			if (Class115.voidDelegate_8 == null && !Class115.bool_14 && !bool_37)
			{
				Class115.size_0 = Class787.smethod_4();
				Class115.point_0 = Class787.smethod_5();
				if (voidDelegate == null)
				{
					voidDelegate = new VoidDelegate(class.method_0);
				}
				Class115.voidDelegate_8 = voidDelegate;
				Class115.smethod_70(Class115.osuModes_1, true);
				return;
			}
			bool flag = Class115.smethod_93();
			Size size = Class115.size_0;
			class.point_0 = Class115.point_0;
			Class115.screenMode_0 = (class.nullable_2 ?? Class341.class605_8);
			if (class.nullable_0.HasValue && class.nullable_1.HasValue)
			{
				Class115.int_22 = class.nullable_0.Value;
				Class115.int_23 = class.nullable_1.Value;
				if (class.bool_0)
				{
					switch (Class115.screenMode_0)
					{
					case ScreenMode.Windowed:
					case ScreenMode.BorderlessWindow:
						Class341.class608_11.Value = Class115.int_22;
						Class341.class608_5.Value = Class115.int_23;
						break;
					case ScreenMode.Fullscreen:
						Class341.class608_12.Value = Class115.int_22;
						Class341.class608_6.Value = Class115.int_23;
						break;
					}
				}
			}
			else
			{
				switch (Class115.screenMode_0)
				{
				case ScreenMode.Windowed:
					Class115.int_22 = Class341.class608_11;
					Class115.int_23 = Class341.class608_5;
					break;
				case ScreenMode.Fullscreen:
					Class115.int_22 = Class341.class608_12;
					Class115.int_23 = Class341.class608_6;
					break;
				case ScreenMode.BorderlessWindow:
					Class115.int_22 = size.Width;
					Class115.int_23 = size.Height;
					break;
				}
				if (Class115.int_22 == 9999 || Class115.int_23 == 9999)
				{
					class.bool_0 = true;
					switch (Class115.screenMode_0)
					{
					case ScreenMode.Windowed:
					case ScreenMode.BorderlessWindow:
						Class115.int_22 = (Class341.class608_11.Value = size.Width);
						Class115.int_23 = (Class341.class608_5.Value = size.Height);
						break;
					case ScreenMode.Fullscreen:
					{
						Size size2 = Class787.smethod_1();
						Class115.int_22 = (Class341.class608_12.Value = size2.Width);
						Class115.int_23 = (Class341.class608_6.Value = size2.Height);
						break;
					}
					}
				}
			}
			if (Class115.screenMode_0 != ScreenMode.Fullscreen)
			{
				ScreenMode arg_33E_0;
				if (Class115.int_22 == size.Width)
				{
					if (Class115.int_23 == size.Height)
					{
						arg_33E_0 = ScreenMode.BorderlessWindow;
						goto IL_33E;
					}
				}
				arg_33E_0 = ScreenMode.Windowed;
				IL_33E:
				Class115.screenMode_0 = arg_33E_0;
			}
			if (class.bool_0)
			{
				Class341.class605_8.Value = Class115.screenMode_0;
			}
			Class115.int_27 = (Class115.bool_27 ? Class787.smethod_3() : Class115.class125_0.GraphicsDevice.get_DisplayMode().get_RefreshRate());
			if ((float)Class115.int_23 > (float)Class115.int_22 * 0.8f)
			{
				Class115.int_23 = (int)((float)Class115.int_22 * 0.8f);
			}
			Class115.int_23 -= Class115.int_25;
			if (!Class115.bool_26)
			{
				Class115.int_25 = 0;
			}
			switch (Class115.screenMode_0)
			{
			case ScreenMode.Windowed:
				if (!Class115.bool_16)
				{
					Class115.form_0.FormBorderStyle = FormBorderStyle.FixedSingle;
					Class115.form_0.Invalidate();
				}
				break;
			case ScreenMode.Fullscreen:
				Class115.form_0.FormBorderStyle = FormBorderStyle.None;
				Class115.form_0.Invalidate();
				break;
			case ScreenMode.BorderlessWindow:
			{
				Class115.form_0.FormBorderStyle = FormBorderStyle.None;
				Class115.form_0.Invalidate();
				Class47 arg_44F_0 = Class115.class47_0;
				if (voidDelegate2 == null)
				{
					voidDelegate2 = new VoidDelegate(class.method_1);
				}
				arg_44F_0.method_1(voidDelegate2, 250, false);
				break;
			}
			}
			Class115.class125_0.method_11(Class115.int_22);
			Class115.class125_0.method_9(Class115.int_23 + (Class115.bool_12 ? Class115.editorControl_0.Height : 0));
			Class115.class125_0.method_1(Class115.screenMode_0 == ScreenMode.Fullscreen);
			Class115.class125_0.method_19();
			if (Class115.bool_26)
			{
				Class115.int_22 = Class115.class125_0.GraphicsDevice.get_PresentationParameters().get_BackBufferWidth();
				Class115.int_23 = Class115.class125_0.GraphicsDevice.get_PresentationParameters().get_BackBufferHeight() - (Class115.bool_12 ? Class115.editorControl_0.Height : 0);
			}
			switch (Class115.screenMode_0)
			{
			case ScreenMode.Windowed:
				if (!Class115.bool_16)
				{
					Class115.form_0.FormBorderStyle = FormBorderStyle.FixedSingle;
					Class115.form_0.Invalidate();
				}
				break;
			case ScreenMode.Fullscreen:
				Class115.form_0.FormBorderStyle = FormBorderStyle.None;
				Class115.form_0.Invalidate();
				break;
			case ScreenMode.BorderlessWindow:
			{
				Class115.form_0.FormBorderStyle = FormBorderStyle.None;
				Class115.form_0.Invalidate();
				Class47 arg_577_0 = Class115.class47_0;
				if (voidDelegate3 == null)
				{
					voidDelegate3 = new VoidDelegate(class.method_2);
				}
				arg_577_0.method_1(voidDelegate3, 250, false);
				break;
			}
			}
			if (Class115.screenMode_0 != ScreenMode.Fullscreen && Class601.smethod_0())
			{
				Class47 arg_5B3_0 = Class115.class47_0;
				if (Class115.voidDelegate_16 == null)
				{
					Class115.voidDelegate_16 = new VoidDelegate(Class115.smethod_105);
				}
				arg_5B3_0.method_1(Class115.voidDelegate_16, 250, false);
			}
			Class115.float_4 = (float)Class115.int_23 / (float)Class115.int_19;
			Class115.float_6 = 1f / Class115.float_4;
			Class115.float_5 = (float)Class115.int_23 / (float)Class115.int_24;
			Class747.smethod_10();
			Class802.textInputControl_0.Location = new Point((int)((double)Class115.int_22 * 0.015), Class115.int_23 - (int)((double)Class115.int_23 * 0.052) + 2000);
			foreach (TextInputControl current in Class802.list_3)
			{
				current.method_2();
			}
			if (Class885.interface17_0 != null)
			{
				Class885.interface17_0.Dispose();
				Class885.interface17_0 = null;
			}
			Class885.smethod_11();
			if (Class115.osuModes_2 != OsuModes.Unknown && Class115.smethod_93() != flag)
			{
				Class885.smethod_33(true);
			}
			if (Class115.editorControl_0 != null)
			{
				Class115.editorControl_0.Width = Class115.int_22;
			}
			if (Class115.class531_0 != null)
			{
				Class115.class531_0.vector2_2 = new Vector2((float)Class115.int_22, (float)(Class115.int_23 + Class115.int_25));
			}
			Class115.smethod_68(Class115.float_2, true);
			Class115.rectangle_0 = new Rectangle(-1 + Class115.int_26, -1, Class115.int_22 - Class115.int_26 * 2 + 1, Class115.int_23 + Class115.int_25 + 1);
			Class115.rectangle_1 = new Rectangle(-1, -1, Class115.int_22 + 1, Class115.int_23 + Class115.int_25 + 1);
			Class911.rectangleF_0.Width = (float)((int)Math.Ceiling((double)((float)Class115.int_22 / Class115.float_4)));
			Class911.rectangle_0 = new Rectangle(0, 0, Class115.int_22, Class115.int_23 + Class115.int_25);
			if (Class115.bool_26)
			{
				Class297.smethod_12();
			}
			if (Class115.bool_27)
			{
				ScreenMode screenMode = Class115.screenMode_0;
				if (screenMode == ScreenMode.Fullscreen)
				{
					Class736.smethod_0(Class115.int_22, Class115.int_23);
				}
				else
				{
					Class736.smethod_0(size.Width, size.Height);
				}
				Class115.baseGLControl_0.BaseGLControl_SizeChanged(null, null);
			}
			if (Class115.class111_0 != null)
			{
				Class111.smethod_70();
			}
			Class115.smethod_28();
			if (Class115.voidDelegate_7 != null)
			{
				Class115.voidDelegate_7();
			}
		}

		// Token: 0x060019C7 RID: 6599
		// RVA: 0x0007C7B4 File Offset: 0x0007A9B4
		internal static int smethod_21(Enum114 enum114_0)
		{
			switch (enum114_0)
			{
			case Enum114.const_0:
				return Class115.int_1;
			case Enum114.const_1:
			case Enum114.const_2:
				return Class331.int_7;
			default:
				return 0;
			}
		}

		// Token: 0x060019C9 RID: 6601
		// RVA: 0x0007D150 File Offset: 0x0007B350
		private static string smethod_22()
		{
			char[] expr_0B_cp_0 = Class115.char_0;
			int expr_0B_cp_1 = 0;
			expr_0B_cp_0[expr_0B_cp_1] += '\u0001';
			return Class33.smethod_2(string.Concat(new object[]
			{
				Class115.class623_1,
				8,
				512,
				Class115.class623_2
			}));
		}

		// Token: 0x060019CA RID: 6602
		// RVA: 0x0007D1B8 File Offset: 0x0007B3B8
		internal static string smethod_23()
		{
			try
			{
				string text = Class793.smethod_2().ToString();
				char[] expr_1F_cp_0 = Class115.char_0;
				int expr_1F_cp_1 = 1;
				expr_1F_cp_0[expr_1F_cp_1] += '\u0001';
				Class115.class623_1.Value = Class33.smethod_2(text);
			}
			catch
			{
			}
			try
			{
				char[] expr_4D_cp_0 = Class115.char_0;
				int expr_4D_cp_1 = 2;
				expr_4D_cp_0[expr_4D_cp_1] += '\u0001';
				Class115.class623_2.Value = Class33.smethod_2(Class115.smethod_25("Win32_DiskDrive", new string[]
				{
					"Signature",
					"SerialNumber"
				}));
			}
			catch
			{
			}
			Class115.class623_2.bool_0 = false;
			Class115.class623_1.bool_0 = false;
			Class115.class623_0.Value = Class115.smethod_22();
			return Class115.class623_1 + "|" + Class115.class623_2;
		}

		// Token: 0x060019CB RID: 6603
		// RVA: 0x0007D2B8 File Offset: 0x0007B4B8
		internal static bool smethod_24()
		{
			return Class115.int_1 == 0 || (Class115.smethod_22() == Class115.class623_0.Value && Class115.class623_1.int_1 <= 3 + Class115.int_33 && Class115.class623_2.int_1 <= 3 + Class115.int_33);
		}

		// Token: 0x060019CC RID: 6604
		// RVA: 0x0007D310 File Offset: 0x0007B510
		internal static string smethod_25(string string_3, string[] string_4)
		{
			char[] expr_0B_cp_0 = Class115.char_0;
			int expr_0B_cp_1 = 3;
			expr_0B_cp_0[expr_0B_cp_1] += '\u0001';
			try
			{
				ManagementClass managementClass = new ManagementClass(string_3);
				ManagementObjectCollection instances = managementClass.GetInstances();
				using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ManagementObject managementObject = (ManagementObject)enumerator.Current;
						for (int i = 0; i < string_4.Length; i++)
						{
							string propertyName = string_4[i];
							try
							{
								if (managementObject[propertyName] != null)
								{
									return managementObject[propertyName].ToString();
								}
							}
							catch
							{
							}
						}
					}
				}
			}
			catch
			{
			}
			return string.Empty;
		}

		// Token: 0x060019CD RID: 6605
		// RVA: 0x00015E5B File Offset: 0x0001405B
		internal static void smethod_26()
		{
			Class115.form_0.BringToFront();
			Class115.SetForegroundWindow(Class115.form_0.Handle);
		}

		// Token: 0x060019CE RID: 6606
		// RVA: 0x00015E77 File Offset: 0x00014077
		private static void smethod_27(object sender, EventArgs e)
		{
			Class115.smethod_28();
		}

		// Token: 0x060019CF RID: 6607
		// RVA: 0x00015E7E File Offset: 0x0001407E
		private static void smethod_28()
		{
			Class115.rectangle_2 = Class115.form_0.RectangleToScreen(Class115.form_0.ClientRectangle);
		}

		// Token: 0x060019D0 RID: 6608
		// RVA: 0x0007D3E4 File Offset: 0x0007B5E4
		internal static void smethod_29(bool bool_36)
		{
			if (!bool_36 && Class341.class605_16.Value == Class344.smethod_0())
			{
				return;
			}
			bool flag = true;
			if (Class793.smethod_2() == Guid.Empty)
			{
				flag = false;
			}
			if (!Class34.smethod_3("osu!", Class905.smethod_0()))
			{
				if (flag &= Class34.smethod_4("osz", "osu!", "osu! beatmap", Class905.smethod_0(), false))
				{
					flag &= Class34.smethod_4("osz2", "osu!", "osu! beatmap v2", Class905.smethod_0(), false);
				}
				if (flag)
				{
					flag &= Class34.smethod_4("osr", "osu!", "osu! replay", Class905.smethod_0(), false);
				}
				if (flag)
				{
					flag &= Class34.smethod_4("osk", "osu!", "osu! skin", Class905.smethod_0(), false);
				}
				if (Registry.ClassesRoot.GetValue(string.Empty, string.Empty).ToString() == "osu")
				{
					Registry.ClassesRoot.DeleteValue(string.Empty, false);
				}
			}
			if (!Class34.smethod_3("osu", Class905.smethod_0()) && !Class34.smethod_4(string.Empty, "osu", "osu! url handler", Class905.smethod_0(), true))
			{
				flag = false;
			}
			if (!Class793.smethod_1())
			{
				flag = false;
			}
			if (!flag && !bool_36)
			{
				Class115.smethod_31(true);
				Class341.class605_16.Value = Class344.smethod_0();
			}
		}

		// Token: 0x060019AE RID: 6574
		// RVA: 0x0007B368 File Offset: 0x00079568
		internal static void smethod_3(bool bool_36)
		{
			if (!bool_36 && Class115.enum32_0 != Enum32.const_4 && Class115.enum32_0 != Enum32.const_3)
			{
				return;
			}
			OsuModes osuModes = Class115.osuModes_1;
			if (osuModes != OsuModes.Menu)
			{
				switch (osuModes)
				{
				case OsuModes.SelectEdit:
				case OsuModes.SelectPlay:
					break;
				default:
				{
					Class47 arg_56_0 = Class115.class47_0;
					if (Class115.voidDelegate_11 == null)
					{
						Class115.voidDelegate_11 = new VoidDelegate(Class115.smethod_100);
					}
					arg_56_0.method_1(Class115.voidDelegate_11, 1000, false);
					return;
				}
				}
			}
			if (!bool_36)
			{
				Class723.smethod_1(Class41.GetString(OsuString.Update_Restart), 120000);
			}
			Class47 arg_A1_0 = Class115.class47_0;
			if (Class115.voidDelegate_12 == null)
			{
				Class115.voidDelegate_12 = new VoidDelegate(Class115.smethod_101);
			}
			arg_A1_0.method_1(Class115.voidDelegate_12, bool_36 ? 0 : 6000, false);
		}

		// Token: 0x060019D1 RID: 6609
		// RVA: 0x0007D53C File Offset: 0x0007B73C
		private static void smethod_30()
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			if (oSVersion.Platform == PlatformID.Win32NT)
			{
				if (oSVersion.Version.Major == 6)
				{
					try
					{
						Directory.CreateDirectory(".test");
						Directory.Delete(".test");
					}
					catch (Exception)
					{
						Class115.smethod_31(false);
						try
						{
							if (Directory.Exists(".test"))
							{
								Directory.Delete(".test");
							}
						}
						catch
						{
						}
					}
					return;
				}
			}
		}

		// Token: 0x060019D2 RID: 6610
		// RVA: 0x0007D5C0 File Offset: 0x0007B7C0
		internal static void smethod_31(bool bool_36)
		{
			VoidDelegate voidDelegate = null;
			Class115.Class348 class = new Class115.Class348();
			class.bool_0 = bool_36;
			if (!Class905.smethod_14())
			{
				Class47 arg_48_0 = Class115.class47_0;
				if (voidDelegate == null)
				{
					voidDelegate = new VoidDelegate(class.method_0);
				}
				arg_48_0.method_1(voidDelegate, Math.Max(500, Class79.int_6 + 500 - Class115.int_1), false);
				return;
			}
			Class115.smethod_29(true);
			if (class.bool_0)
			{
				return;
			}
			Class905.smethod_15(null);
		}

		// Token: 0x060019D3 RID: 6611
		// RVA: 0x00015E99 File Offset: 0x00014099
		private static void smethod_32()
		{
			if (Class115.baseGLControl_0 != null)
			{
				return;
			}
			Class115.baseGLControl_0 = new BaseGLControl();
			Class115.form_0.Controls.Add(Class115.baseGLControl_0);
			Class115.class115_0.vmethod_4(true);
		}

		// Token: 0x060019D5 RID: 6613
		// RVA: 0x00015ECC File Offset: 0x000140CC
		internal static bool smethod_33()
		{
			return !string.IsNullOrEmpty(Class341.class605_17) && !string.IsNullOrEmpty(Class341.class605_20);
		}

		// Token: 0x060019D6 RID: 6614
		// RVA: 0x00015EF3 File Offset: 0x000140F3
		internal static void smethod_34(object sender, EventArgs e)
		{
			if (!Class115.smethod_33())
			{
				Class115.smethod_80(false);
				return;
			}
			Class527.smethod_0(Class115.class861_0, false);
		}

		// Token: 0x060019DB RID: 6619
		// RVA: 0x0007DB50 File Offset: 0x0007BD50
		private static void smethod_35()
		{
			if (Class115.list_2.Count > 0 && Class115.class89_0 == null && (!Class62.bool_12 || (Class111.bool_2 && Class111.bool_1)))
			{
				TextInputControl textInputControl = Class802.smethod_28();
				if (textInputControl != null && textInputControl.method_3())
				{
					Class115.textInputControl_0 = textInputControl;
					Class115.textInputControl_0.method_4(false);
				}
				Class115.class89_0 = Class115.list_2[0];
				Class115.class89_0.vmethod_3();
				Class115.class89_0.vmethod_4();
				Class115.class89_0.method_2(new EventHandler(Class115.smethod_38));
			}
			if (Class115.class89_0 != null)
			{
				Class115.class89_0.imethod_2();
			}
		}

		// Token: 0x060019DD RID: 6621
		// RVA: 0x00015F0E File Offset: 0x0001410E
		private static void smethod_36()
		{
			if (Class114.bool_0)
			{
				Class788.smethod_0();
			}
			else
			{
				Class788.smethod_1();
			}
			if (Class114.bool_0 && Class62.bool_12 && !Class802.smethod_0())
			{
				Class794.smethod_1();
				return;
			}
			Class794.smethod_2();
		}

		// Token: 0x060019E0 RID: 6624
		// RVA: 0x00015F43 File Offset: 0x00014143
		internal static void smethod_37(Class89 class89_1)
		{
			Class115.list_2.Add(class89_1);
		}

		// Token: 0x060019E1 RID: 6625
		// RVA: 0x0007E244 File Offset: 0x0007C444
		private static void smethod_38(object sender, EventArgs e)
		{
			Class115.Class349 class = new Class115.Class349();
			if (Class115.class89_0 == null)
			{
				return;
			}
			List<Class530> arg_3A_0 = Class115.class89_0.class911_0.list_2;
			if (Class115.action_0 == null)
			{
				Class115.action_0 = new Action<Class530>(Class115.smethod_114);
			}
			arg_3A_0.ForEach(Class115.action_0);
			class.class89_0 = Class115.class89_0;
			Class115.class47_0.method_1(new VoidDelegate(class.method_0), 180, false);
			Class115.class911_2.Add<Class530>(Class115.class89_0.class911_0.list_2);
			Class115.class89_0 = null;
			if (Class115.textInputControl_0 != null)
			{
				Class115.textInputControl_0.method_4(true);
				Class115.textInputControl_0 = null;
			}
			Class115.list_2.Remove((Class89)sender);
			Class115.class115_0.method_0().Remove((Interface6)sender);
		}

		// Token: 0x060019E3 RID: 6627
		// RVA: 0x0007E598 File Offset: 0x0007C798
		private static void smethod_39(Exception exception_0)
		{
			if (Class115.int_16 == 1)
			{
				Class765.smethod_0(new Class764(exception_0)
				{
					string_0 = "soft handle"
				});
				Class723.smethod_5("An error occurred somewhere in osu! and has been reported. osu! will attempt to keep running.", Color.get_Red(), 5000, null);
			}
			if (exception_0 is MissingFieldException || exception_0 is MissingMethodException || exception_0 is MissingMemberException)
			{
				Class115.smethod_70(OsuModes.Update, false);
			}
			Class47 arg_7C_0 = Class115.class47_0;
			if (Class115.voidDelegate_20 == null)
			{
				Class115.voidDelegate_20 = new VoidDelegate(Class115.smethod_115);
			}
			arg_7C_0.method_1(Class115.voidDelegate_20, 1000, false);
		}

		// Token: 0x060019B2 RID: 6578
		// RVA: 0x00015DC9 File Offset: 0x00013FC9
		internal static void smethod_4()
		{
			Class331.smethod_104(Class341.class605_12.Value);
			if (Class115.bool_16)
			{
				Class331.class608_2.Value = 0;
			}
		}

		// Token: 0x060019E6 RID: 6630
		// RVA: 0x00015F50 File Offset: 0x00014150
		internal static bool smethod_40()
		{
			return Class115.bool_26;
		}

		// Token: 0x060019E7 RID: 6631
		// RVA: 0x0007E814 File Offset: 0x0007CA14
		internal static Color[] smethod_41(Vector2 vector2_2, int int_34)
		{
			Color[] result;
			try
			{
				if (Class115.bool_26)
				{
					Texture2D texture2D = new Texture2D(Class115.class125_0.GraphicsDevice, Class115.class125_0.GraphicsDevice.get_Viewport().get_Width(), Class115.class125_0.GraphicsDevice.get_Viewport().get_Height(), 1, 1, 2, 0);
					Class115.class125_0.GraphicsDevice.ResolveBackBuffer(texture2D);
					Color[] array = new Color[int_34];
					Rectangle value;
					value..ctor((int)vector2_2.X, (int)vector2_2.Y, 1, int_34);
					texture2D.GetData<Color>(0, new Rectangle?(value), array, 0, int_34);
					texture2D.Dispose();
					result = array;
				}
				else
				{
					Color[] array2 = new Color[int_34];
					using (Bitmap bitmap = new Bitmap(Class115.int_22, Class115.int_23, PixelFormat.Format32bppArgb))
					{
						BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, bitmap.PixelFormat);
						Gl.glReadPixels(0, 0, Class115.int_22, Class115.int_23, 32993u, 5121u, bitmapData.Scan0);
						bitmap.UnlockBits(bitmapData);
						for (int i = 0; i < int_34; i++)
						{
							Color pixel = bitmap.GetPixel((int)vector2_2.X, (int)vector2_2.Y + i);
							array2[i] = new Color(pixel.R, pixel.G, pixel.B);
						}
					}
					result = array2;
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060019E8 RID: 6632
		// RVA: 0x0007E9D0 File Offset: 0x0007CBD0
		internal static MemoryStream smethod_42()
		{
			MemoryStream result;
			try
			{
				MemoryStream memoryStream = new MemoryStream();
				if (Class115.bool_26)
				{
					using (Texture2D texture2D = new Texture2D(Class115.class125_0.GraphicsDevice, Class115.class125_0.GraphicsDevice.get_Viewport().get_Width(), Class115.class125_0.GraphicsDevice.get_Viewport().get_Height(), 1, 1, 2, 0))
					{
						Class115.class125_0.GraphicsDevice.ResolveBackBuffer(texture2D);
						string tempFileName = Path.GetTempFileName();
						texture2D.Save(tempFileName, 1);
						memoryStream = new MemoryStream(File.ReadAllBytes(tempFileName));
						File.Delete(tempFileName);
						result = memoryStream;
						return result;
					}
				}
				using (Bitmap bitmap = new Bitmap(Class115.int_22, Class115.int_23, PixelFormat.Format32bppArgb))
				{
					BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, bitmap.PixelFormat);
					Gl.glReadPixels(0, 0, Class115.int_22, Class115.int_23, 32993u, 5121u, bitmapData.Scan0);
					bitmap.UnlockBits(bitmapData);
					bitmap.RotateFlip(RotateFlipType.Rotate180FlipX);
					bitmap.Save(memoryStream, ImageFormat.Jpeg);
				}
				result = memoryStream;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060019E9 RID: 6633
		// RVA: 0x00015F57 File Offset: 0x00014157
		internal static int smethod_43()
		{
			return (int)Math.Ceiling((double)((float)Class115.int_22 / Class115.float_4));
		}

		// Token: 0x060019EA RID: 6634
		// RVA: 0x00015F6C File Offset: 0x0001416C
		internal static int smethod_44()
		{
			return (int)Math.Ceiling((double)((float)Class115.int_23 / Class115.float_4));
		}

		// Token: 0x060019EB RID: 6635
		// RVA: 0x00015F81 File Offset: 0x00014181
		internal static float smethod_45()
		{
			return (float)Class115.int_26 / Class115.float_4;
		}

		// Token: 0x060019EC RID: 6636
		// RVA: 0x00015F8F File Offset: 0x0001418F
		internal static float smethod_46()
		{
			return (float)Class115.smethod_43() / (float)Class115.int_20;
		}

		// Token: 0x060019ED RID: 6637
		// RVA: 0x00015F9E File Offset: 0x0001419E
		internal static float smethod_47()
		{
			return 1f / (Class115.float_2 * Class115.float_2 * (float)Class115.int_20 * (float)Class115.int_19);
		}

		// Token: 0x060019EE RID: 6638
		// RVA: 0x00015FBF File Offset: 0x000141BF
		internal static float smethod_48()
		{
			return Class115.float_0 / (float)Class115.int_17 / Class115.float_4;
		}

		// Token: 0x060019EF RID: 6639
		// RVA: 0x00015FD4 File Offset: 0x000141D4
		internal static Rectangle smethod_49()
		{
			return new Rectangle((int)Class115.vector2_0.X, (int)Class115.vector2_0.Y, (int)Class115.float_3, (int)Class115.float_0);
		}

		// Token: 0x060019B3 RID: 6579
		// RVA: 0x00015DED File Offset: 0x00013FED
		internal static bool smethod_5()
		{
			return Class115.bool_24;
		}

		// Token: 0x060019F0 RID: 6640
		// RVA: 0x0007EB4C File Offset: 0x0007CD4C
		internal static void smethod_50(Delegate1 delegate1_2)
		{
			Delegate1 delegate = Class115.delegate1_0;
			Delegate1 delegate2;
			do
			{
				delegate2 = delegate;
				Delegate1 value = (Delegate1)Delegate.Combine(delegate2, delegate1_2);
				delegate = Interlocked.CompareExchange<Delegate1>(ref Class115.delegate1_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x060019F1 RID: 6641
		// RVA: 0x0007EB80 File Offset: 0x0007CD80
		internal static void smethod_51(Delegate1 delegate1_2)
		{
			Delegate1 delegate = Class115.delegate1_0;
			Delegate1 delegate2;
			do
			{
				delegate2 = delegate;
				Delegate1 value = (Delegate1)Delegate.Remove(delegate2, delegate1_2);
				delegate = Interlocked.CompareExchange<Delegate1>(ref Class115.delegate1_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x060019F2 RID: 6642
		// RVA: 0x0007EBB4 File Offset: 0x0007CDB4
		private static void smethod_52(bool bool_36)
		{
			Delegate1 delegate = Class115.delegate1_0;
			if (delegate != null)
			{
				delegate(bool_36);
			}
		}

		// Token: 0x060019F3 RID: 6643
		// RVA: 0x0007EBD4 File Offset: 0x0007CDD4
		internal static void smethod_53(Delegate1 delegate1_2)
		{
			Delegate1 delegate = Class115.delegate1_1;
			Delegate1 delegate2;
			do
			{
				delegate2 = delegate;
				Delegate1 value = (Delegate1)Delegate.Combine(delegate2, delegate1_2);
				delegate = Interlocked.CompareExchange<Delegate1>(ref Class115.delegate1_1, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x060019F4 RID: 6644
		// RVA: 0x0007EC08 File Offset: 0x0007CE08
		internal static void smethod_54(Delegate1 delegate1_2)
		{
			Delegate1 delegate = Class115.delegate1_1;
			Delegate1 delegate2;
			do
			{
				delegate2 = delegate;
				Delegate1 value = (Delegate1)Delegate.Remove(delegate2, delegate1_2);
				delegate = Interlocked.CompareExchange<Delegate1>(ref Class115.delegate1_1, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x060019F5 RID: 6645
		// RVA: 0x0007EC3C File Offset: 0x0007CE3C
		private static void smethod_55(bool bool_36)
		{
			Delegate1 delegate = Class115.delegate1_1;
			if (delegate != null)
			{
				delegate(bool_36);
			}
		}

		// Token: 0x060019F6 RID: 6646
		// RVA: 0x00015FFD File Offset: 0x000141FD
		internal static Vector2 smethod_56(Vector2 vector2_2)
		{
			return vector2_2 * Class115.float_4 + new Vector2((float)Class115.int_26, (float)Class115.int_25);
		}

		// Token: 0x060019F7 RID: 6647
		// RVA: 0x00016020 File Offset: 0x00014220
		internal static float smethod_57(float float_7)
		{
			return (float_7 - Class115.vector2_1.X) / Class115.float_1;
		}

		// Token: 0x060019F8 RID: 6648
		// RVA: 0x00016034 File Offset: 0x00014234
		internal static Vector2 smethod_58(Vector2 vector2_2)
		{
			return (vector2_2 - Class115.vector2_0) / Class115.float_1;
		}

		// Token: 0x060019F9 RID: 6649
		// RVA: 0x0001604B File Offset: 0x0001424B
		internal static float smethod_59(float float_7)
		{
			return float_7 * Class115.float_1 + Class115.vector2_0.X;
		}

		// Token: 0x060019B4 RID: 6580
		// RVA: 0x00015DF4 File Offset: 0x00013FF4
		internal static void smethod_6(bool bool_36)
		{
			if (Class115.bool_24 == bool_36)
			{
				return;
			}
			Class115.bool_24 = bool_36;
			Class115.form_0.TopMost = bool_36;
			Class800.smethod_26();
			Class800.smethod_45();
		}

		// Token: 0x060019FA RID: 6650
		// RVA: 0x0001605F File Offset: 0x0001425F
		internal static float smethod_60(float float_7)
		{
			return float_7 * Class115.float_1 + Class115.vector2_0.Y;
		}

		// Token: 0x060019FB RID: 6651
		// RVA: 0x0007EC5C File Offset: 0x0007CE5C
		internal static Vector2 smethod_61(Vector2 vector2_2)
		{
			Vector2 result = vector2_2;
			Class115.smethod_62(ref result);
			return result;
		}

		// Token: 0x060019FC RID: 6652
		// RVA: 0x00016073 File Offset: 0x00014273
		internal static void smethod_62(ref Vector2 vector2_2)
		{
			Vector2.Multiply(ref vector2_2, Class115.float_1, ref vector2_2);
			Vector2.Add(ref vector2_2, ref Class115.vector2_0, ref vector2_2);
		}

		// Token: 0x060019FD RID: 6653
		// RVA: 0x0001608D File Offset: 0x0001428D
		internal static void smethod_63(ref Vector2 vector2_2)
		{
			Vector2.Multiply(ref vector2_2, Class115.float_1, ref vector2_2);
			Vector2.Add(ref vector2_2, ref Class115.vector2_1, ref vector2_2);
		}

		// Token: 0x060019FE RID: 6654
		// RVA: 0x000160A7 File Offset: 0x000142A7
		internal static void smethod_64(ref Class880 class880_0)
		{
			Class115.smethod_62(ref class880_0.vector2_0);
			Class115.smethod_62(ref class880_0.vector2_1);
		}

		// Token: 0x060019FF RID: 6655
		// RVA: 0x0007EC74 File Offset: 0x0007CE74
		internal static Class880 smethod_65(Class880 class880_0)
		{
			return new Class880(Class115.smethod_61(class880_0.vector2_0), Class115.smethod_61(class880_0.vector2_1));
		}

		// Token: 0x06001A00 RID: 6656
		// RVA: 0x0007ECA0 File Offset: 0x0007CEA0
		internal static bool smethod_66(Vector2 vector2_2)
		{
			return Class115.smethod_49().Contains(new Point((int)vector2_2.X, (int)vector2_2.Y));
		}

		// Token: 0x06001A01 RID: 6657
		// RVA: 0x0007ECD0 File Offset: 0x0007CED0
		internal static bool smethod_67(Vector2 vector2_2)
		{
			return vector2_2.X >= 0f && vector2_2.X <= (float)Class115.int_18 && vector2_2.Y >= 0f && vector2_2.Y <= (float)Class115.int_17;
		}

		// Token: 0x06001A02 RID: 6658
		// RVA: 0x0007ED1C File Offset: 0x0007CF1C
		internal static void smethod_68(float float_7, bool bool_36)
		{
			if (Class115.float_2 == float_7 && !bool_36)
			{
				return;
			}
			Class115.float_2 = float_7;
			Class115.float_3 = (float)Class115.int_18 * Class115.float_4 * float_7;
			Class115.float_0 = (float)Class115.int_18 * Class115.float_4 * float_7 * 0.75f;
			Class115.bool_22 = (Class115.osuModes_1 != OsuModes.Edit && Class62.Mode == PlayModes.Osu);
			float num = Class115.bool_22 ? (-16f * Class115.float_4) : 0f;
			Class115.vector2_0 = new Vector2(((float)Class115.int_22 - Class115.float_3) / 2f, ((float)Class115.int_23 - Class115.float_0) / 4f * 3f + (float)Class115.int_25 + num);
			Class115.vector2_1 = new Vector2(0f, ((float)Class115.int_23 - Class115.float_0) / 4f * 3f + (float)Class115.int_25 + num);
			Class115.float_1 = Class115.float_0 / (float)Class115.int_17;
			Class115.int_26 = (int)(((float)Class115.int_22 - (float)(Class115.int_23 * 4) / 3f) / 2f);
			Class115.bool_21 = (Class115.int_26 > 0);
			Class297.smethod_4(true);
		}

		// Token: 0x06001A03 RID: 6659
		// RVA: 0x0007EE50 File Offset: 0x0007D050
		internal static void smethod_69(bool bool_36)
		{
			bool flag = Class112.list_0.Count > 0;
			List<Class750> arg_35_0 = Class111.class594_0.list_1;
			if (Class115.predicate_1 == null)
			{
				Class115.predicate_1 = new Predicate<Class750>(Class115.smethod_116);
			}
			bool flag2 = arg_35_0.FindAll(Class115.predicate_1).Count > 0;
			if (Class115.bool_16)
			{
				Class115.smethod_70(OsuModes.Exit, false);
				return;
			}
			if (!flag && !flag2 && !Class341.class606_14 && !bool_36)
			{
				Class115.smethod_70(OsuModes.Exit, false);
				return;
			}
			if (Class115.bool_23)
			{
				return;
			}
			Class115.bool_23 = true;
			string text = "Are you sure you want to exit osu!?";
			if (flag)
			{
				text = "Exiting will cancel all active downloads!\n" + text;
			}
			else if (flag2)
			{
				text = "You have unread chat messages.\n" + text;
			}
			string arg_DE_0 = text;
			if (Class115.eventHandler_9 == null)
			{
				Class115.eventHandler_9 = new EventHandler(Class115.smethod_117);
			}
			EventHandler arg_DE_1 = Class115.eventHandler_9;
			if (Class115.eventHandler_10 == null)
			{
				Class115.eventHandler_10 = new EventHandler(Class115.smethod_118);
			}
			Class101 class = new Class101(arg_DE_0, arg_DE_1, Class115.eventHandler_10);
			Class89 arg_102_0 = class;
			if (Class115.eventHandler_11 == null)
			{
				Class115.eventHandler_11 = new EventHandler(Class115.smethod_119);
			}
			arg_102_0.method_2(Class115.eventHandler_11);
			Class115.smethod_37(class);
		}

		// Token: 0x060019B5 RID: 6581
		// RVA: 0x00015E1A File Offset: 0x0001401A
		private static void smethod_7(object sender, EventArgs1 e)
		{
			if (e.method_0().method_6().get_IsFullScreen())
			{
				e.method_0().method_6().set_FullScreenRefreshRateInHz(Class341.class608_10);
			}
		}

		// Token: 0x06001A04 RID: 6660
		// RVA: 0x0007EF6C File Offset: 0x0007D16C
		internal static void smethod_70(OsuModes osuModes_3, bool bool_36)
		{
			if (Class115.osuModes_1 == OsuModes.Edit && !((Editor)Class115.class61_0).bool_6 && !((Editor)Class115.class61_0).method_81())
			{
				return;
			}
			if (osuModes_3 != OsuModes.Exit && osuModes_3 != OsuModes.Update && (!Class809.smethod_21(false) || !Class331.smethod_102()))
			{
				osuModes_3 = OsuModes.Menu;
				bool_36 = true;
			}
			if (Class115.bool_16)
			{
				switch (osuModes_3)
				{
				case OsuModes.Exit:
				case OsuModes.Rank:
				case OsuModes.Busy:
					goto IL_A7;
				case OsuModes.SelectPlay:
					osuModes_3 = OsuModes.Menu;
					goto IL_A7;
				}
				if (Class115.osuModes_1 == OsuModes.Play && !Class331.smethod_79() && (Class802.bool_17 || (Class62.class62_0 != null && Class62.class62_0.enum110_0 == Enum110.const_4)))
				{
					return;
				}
				IL_A7:
				if (Class115.osuModes_1 == OsuModes.Rank && osuModes_3 == OsuModes.Play && Class115.double_6 < 10000.0)
				{
					return;
				}
			}
			Class723.smethod_2(null, null);
			if (osuModes_3 == Class115.osuModes_1 && !bool_36)
			{
				return;
			}
			if (osuModes_3 == Class115.osuModes_0 && !bool_36)
			{
				return;
			}
			Class621.smethod_1("Changing to {0} mode.", new string[]
			{
				osuModes_3.ToString()
			});
			List<Class89> list = new List<Class89>();
			foreach (Class89 current in Class115.list_2)
			{
				if (current.bool_2)
				{
					list.Add(current);
				}
			}
			foreach (Class89 current2 in list)
			{
				current2.Close(false);
			}
			Class115.osuModes_0 = osuModes_3;
			Class115.class531_0.method_8(false);
			Class115.double_10 = 10.0;
			Class115.class911_4.Clear(true);
			Class115.class911_4.Add(Class115.class531_0);
			OsuModes osuModes = osuModes_3;
			if (osuModes == OsuModes.Exit)
			{
				if (Class115.voidDelegate_3 != null)
				{
					Class115.voidDelegate_3();
				}
				if (Class341.class606_85 && (Class115.enum32_0 != Enum32.const_4 || !Class905.bool_2) && !Class115.bool_16)
				{
					Class115.double_10 = 0.6;
					Class331.smethod_59("seeya", 100, ((Class809.class623_0 & Enum30.flag_3) > Enum30.flag_0) ? Enum112.flag_5 : Enum112.flag_1);
				}
				else
				{
					Class115.double_10 = 5.0;
				}
				Class802.bool_13 = false;
			}
			Class115.enum113_0 = Enum113.const_0;
		}

		// Token: 0x06001A05 RID: 6661
		// RVA: 0x0007F1D4 File Offset: 0x0007D3D4
		internal static void smethod_71(OsuModes osuModes_3, bool bool_36)
		{
			Class115.Class350 class = new Class115.Class350();
			class.osuModes_0 = osuModes_3;
			class.bool_0 = bool_36;
			Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
		}

		// Token: 0x06001A06 RID: 6662
		// RVA: 0x0007F20C File Offset: 0x0007D40C
		private static void smethod_72(object sender, EventArgs e)
		{
			if (Class115.osuModes_0 != OsuModes.Play || Class115.osuModes_2 != OsuModes.Play)
			{
				Class115.smethod_78();
			}
			Class798.smethod_1();
			OsuModes osuModes = Class115.osuModes_0;
			if (osuModes != OsuModes.Rank)
			{
				switch (osuModes)
				{
				case OsuModes.RankingVs:
				case OsuModes.RankingTagCoop:
				case OsuModes.RankingTeam:
					goto IL_49;
				case OsuModes.OnlineSelection:
				case OsuModes.OptionsOffsetWizard:
					IL_44:
					Class331.smethod_92();
					goto IL_49;
				}
				goto IL_44;
			}
			IL_49:
			Class115.bool_14 = true;
			Class115.osuModes_1 = Class115.osuModes_0;
			if (Class115.voidDelegate_1 != null)
			{
				Class115.voidDelegate_1();
				Class115.voidDelegate_1 = null;
			}
			if (Class115.voidDelegate_2 != null)
			{
				Class115.voidDelegate_2();
			}
			if (Class115.osuModes_1 != OsuModes.Menu)
			{
				Class115.class80_0.method_24(false);
			}
			if (Class115.class61_0 != null)
			{
				Class115.class115_0.method_0().Remove(Class115.class61_0);
				Class115.class61_0.Dispose();
				Class115.class61_0 = null;
			}
			if (Class115.osuModes_1 == OsuModes.Exit)
			{
				Class115.class115_0.method_12();
			}
			else
			{
				if (Class115.osuModes_2 != OsuModes.Unknown)
				{
					if (Class115.osuModes_2 != Class115.osuModes_1)
					{
						Class885.smethod_9(null, false);
					}
					else
					{
						Class885.smethod_12(false);
					}
				}
				Class733.float_2 = 0f;
				ScreenMode screenMode = Class341.class605_8;
				Class115.double_6 = 0.0;
				switch (Class115.osuModes_1)
				{
				case OsuModes.Edit:
				case OsuModes.SelectEdit:
					if (screenMode == ScreenMode.Fullscreen)
					{
						screenMode = ScreenMode.BorderlessWindow;
					}
					break;
				case OsuModes.Play:
					if (Class115.bool_25 && screenMode == ScreenMode.Fullscreen)
					{
						screenMode = ScreenMode.BorderlessWindow;
					}
					break;
				}
				bool flag = false;
				if (Class115.osuModes_1 == OsuModes.Edit)
				{
					if (Class115.editorControl_0 == null)
					{
						Class115.editorControl_0 = new EditorControl();
					}
					if (!Class115.bool_12)
					{
						Class115.bool_12 = true;
						Class115.editorControl_0.Parent = Class115.control_0;
						Class115.int_25 = Class115.editorControl_0.Height;
						flag = true;
					}
				}
				else
				{
					if (Class115.editorControl_0 != null)
					{
						Class115.editorControl_0.Dispose();
						Class115.editorControl_0 = null;
					}
					if (Class115.bool_12)
					{
						Class115.bool_12 = false;
						Class115.int_25 = 0;
						flag = true;
					}
				}
				if (!Class115.bool_16)
				{
					if (screenMode == Class115.screenMode_0 && !flag)
					{
						if (Class115.voidDelegate_8 != null)
						{
							Class115.voidDelegate_8();
						}
					}
					else
					{
						Class115.smethod_20(null, null, new ScreenMode?(screenMode), false, flag);
					}
					Class115.voidDelegate_8 = null;
				}
				Class115.smethod_68(Class115.float_2, true);
				Class802.smethod_3(Class111.bool_2);
				Class802.string_0 = string.Empty;
				Class331.bool_8 = false;
				bool bool_ = false;
				Class115.smethod_89(true);
				bool maximizeBox = false;
				switch (Class115.osuModes_1)
				{
				case OsuModes.Menu:
					maximizeBox = true;
					if (Class115.osuModes_2 != OsuModes.Unknown)
					{
						Class79.bool_2 = false;
					}
					bool_ = true;
					Class115.class61_0 = new Class79(Class115.class115_0);
					break;
				case OsuModes.Edit:
					Class331.smethod_83();
					Class331.smethod_90();
					Class115.class61_0 = new Editor(Class115.class115_0);
					break;
				case OsuModes.Play:
					if (Class115.osuModes_2 != OsuModes.MatchSetup && Class64.class10_0 == null)
					{
						if (Class115.bool_25)
						{
							Class115.class61_0 = new Class63();
						}
						else if (!Class802.smethod_0() && !Class802.bool_16 && !Class876.smethod_5(Mods.Autoplay))
						{
							Class115.class61_0 = new Class62();
						}
						else
						{
							Class115.class61_0 = new Class65();
						}
					}
					else
					{
						Class115.class61_0 = new Class64(Class72.class10_0);
					}
					break;
				case OsuModes.SelectEdit:
				case OsuModes.SelectPlay:
				case OsuModes.SelectMulti:
					maximizeBox = true;
					if (!Class77.smethod_0() && (Class115.osuModes_2 == OsuModes.BeatmapImport || Class466.list_3.Count != 0))
					{
						Class115.class61_0 = new Class68(Class115.class115_0);
					}
					else
					{
						Class115.class61_0 = new Class77(Class115.class115_0, Class115.osuModes_1);
						Class115.osuModes_1 = OsuModes.BeatmapImport;
					}
					break;
				case OsuModes.SkinSelect:
					maximizeBox = true;
					Class115.class61_0 = new Class71(Class115.class115_0);
					break;
				case OsuModes.Rank:
					Class115.class61_0 = new Class73(Class115.class115_0);
					break;
				case OsuModes.Update:
					Class905.smethod_10();
					Class115.class115_0.method_12();
					goto IL_551;
				case OsuModes.Busy:
					goto IL_551;
				case OsuModes.Lobby:
					maximizeBox = true;
					bool_ = true;
					Class115.class61_0 = new Class70(Class115.class115_0);
					break;
				case OsuModes.MatchSetup:
					if (Class77.smethod_0())
					{
						Class115.class61_0 = new Class77(Class115.class115_0, Class115.osuModes_1);
						Class115.osuModes_1 = OsuModes.BeatmapImport;
					}
					else
					{
						Class115.class61_0 = new Class72(Class115.class115_0);
					}
					break;
				case OsuModes.RankingVs:
					Class115.class61_0 = new Class74(Class115.class115_0);
					break;
				case OsuModes.OnlineSelection:
					maximizeBox = true;
					Class115.class61_0 = new Class78(Class115.class115_0);
					break;
				case OsuModes.OptionsOffsetWizard:
					maximizeBox = true;
					bool_ = true;
					Class115.class61_0 = new Class69(Class115.class115_0);
					break;
				case OsuModes.RankingTagCoop:
					Class115.class61_0 = new Class76(Class115.class115_0);
					break;
				case OsuModes.RankingTeam:
					Class115.class61_0 = new Class75(Class115.class115_0);
					break;
				case OsuModes.BeatmapImport:
					Class115.class61_0 = new Class77(Class115.class115_0, (Class115.osuModes_2 == OsuModes.Unknown) ? OsuModes.Menu : Class115.osuModes_2);
					break;
				case OsuModes.PackageUpdater:
					Class115.class61_0 = new Class67(Class115.class115_0, Class115.osuModes_2);
					break;
				case OsuModes.Benchmark:
					Class115.class61_0 = new Benchmark(Class115.class115_0);
					break;
				case OsuModes.Tourney:
					Class115.class61_0 = new Tournament(Class115.class115_0);
					break;
				case OsuModes.Charts:
					Class115.class61_0 = new Class66();
					break;
				}
				if (Class115.form_0.FormBorderStyle != FormBorderStyle.None)
				{
					Class115.form_0.MaximizeBox = maximizeBox;
				}
				Class109.smethod_1(bool_);
				Class115.smethod_28();
				Class115.class115_0.method_0().Add(Class115.class61_0);
			}
			IL_551:
			Class115.osuModes_2 = Class115.osuModes_1;
		}

		// Token: 0x06001A07 RID: 6663
		// RVA: 0x000160C1 File Offset: 0x000142C1
		internal static void smethod_73()
		{
			Class809.smethod_36(false);
			Class115.smethod_74();
			Class111.smethod_56(false, false);
		}

		// Token: 0x06001A08 RID: 6664
		// RVA: 0x000160D5 File Offset: 0x000142D5
		internal static void smethod_74()
		{
			if (Class115.enum113_0 != Enum113.const_2)
			{
				Class115.double_8 = 140.0;
			}
			Class115.enum113_0 = Enum113.const_1;
		}

		// Token: 0x06001A09 RID: 6665
		// RVA: 0x0007F774 File Offset: 0x0007D974
		internal static void smethod_75(EventHandler eventHandler_13)
		{
			EventHandler eventHandler = Class115.eventHandler_4;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_13);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref Class115.eventHandler_4, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06001A0A RID: 6666
		// RVA: 0x0007F7A8 File Offset: 0x0007D9A8
		internal static void smethod_76(EventHandler eventHandler_13)
		{
			EventHandler eventHandler = Class115.eventHandler_4;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_13);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref Class115.eventHandler_4, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06001A0B RID: 6667
		// RVA: 0x0007F7DC File Offset: 0x0007D9DC
		internal static void smethod_77(EventHandler eventHandler_13)
		{
			EventHandler eventHandler = Class115.eventHandler_5;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_13);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref Class115.eventHandler_5, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06001A0C RID: 6668
		// RVA: 0x0007F810 File Offset: 0x0007DA10
		internal static void smethod_78()
		{
			string text = string.Empty;
			Class861 class = Class858.class861_0;
			if (class != null)
			{
				text = text + " (watching " + class.Name + ")";
			}
			Class115.smethod_79(text);
		}

		// Token: 0x06001A0D RID: 6669
		// RVA: 0x0007F84C File Offset: 0x0007DA4C
		internal static void smethod_79(string string_3)
		{
			Class115.Class351 class = new Class115.Class351();
			class.string_0 = string_3;
			if (Class341.class605_8 == ScreenMode.Fullscreen)
			{
				return;
			}
			Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
		}

		// Token: 0x060019B6 RID: 6582
		// RVA: 0x0007B7BC File Offset: 0x000799BC
		internal static bool smethod_8(object object_0, Keys keys_0)
		{
			Bindings bindings = Class795.smethod_10(keys_0);
			Bindings bindings2 = bindings;
			if (bindings2 != Bindings.ToggleFrameLimiter)
			{
				switch (bindings2)
				{
				case Bindings.Screenshot:
					Class737.smethod_1(Class570.bool_2);
					return true;
				case Bindings.DisableMouseButtons:
					Class341.class606_43.method_1();
					Class723.smethod_1("Mouse buttons are " + (Class341.class606_43 ? "disabled" : "enabled") + ".", 1000);
					return true;
				case Bindings.BossKey:
					Class115.smethod_96(true);
					return true;
				}
				if (keys_0 != 13)
				{
					switch (keys_0)
					{
					case 82:
						if (Class570.bool_0 && Class115.bool_16)
						{
							Class861 class = Class858.class861_0;
							if (class == null)
							{
								class = Class809.smethod_30(Class115.class533_0.Text);
							}
							if (class != null)
							{
								Class858.smethod_4(true);
								Class858.smethod_5(class);
							}
						}
						break;
					case 83:
						if (Class115.osuModes_1 != OsuModes.Play && Class115.osuModes_1 != OsuModes.Edit && Class570.bool_2 && Class570.bool_1 && Class570.bool_0)
						{
							Class885.smethod_33(true);
							if (Class115.voidDelegate_15 == null)
							{
								Class115.voidDelegate_15 = new VoidDelegate(Class115.smethod_104);
							}
							Class115.smethod_11(Class115.voidDelegate_15);
							if (Class115.smethod_97())
							{
								Class115.smethod_70(Class115.osuModes_1, true);
							}
							Class723.smethod_1("Skin reloaded.", 2000);
							return true;
						}
						break;
					}
				}
				else if (Class570.bool_1)
				{
					if (Class115.bool_27)
					{
						return false;
					}
					OsuModes osuModes = Class115.osuModes_1;
					if (osuModes != OsuModes.Menu && osuModes != OsuModes.SelectPlay)
					{
						if (osuModes != OsuModes.Lobby)
						{
							return false;
						}
					}
					Class341.class606_74.method_1();
					return true;
				}
				return false;
			}
			switch (Class341.class605_26.Value)
			{
			case FrameSync.Limit120:
				Class341.class605_26.Value = FrameSync.Limit240;
				return true;
			case FrameSync.VSync:
				Class341.class605_26.Value = FrameSync.Limit120;
				return true;
			case FrameSync.Unlimited:
				Class341.class605_26.Value = FrameSync.CompletelyUnlimited;
				return true;
			case FrameSync.LowLatencyVSync:
				Class341.class605_26.Value = FrameSync.Limit120;
				return true;
			case FrameSync.Limit240:
				Class341.class605_26.Value = FrameSync.Unlimited;
				return true;
			}
			Class341.class605_26.Value = FrameSync.Limit120;
			return true;
		}

		// Token: 0x06001A0E RID: 6670
		// RVA: 0x0007F88C File Offset: 0x0007DA8C
		internal static void smethod_80(bool bool_36)
		{
			if (Class115.bool_16)
			{
				return;
			}
			if (Class115.bool_28 && !bool_36)
			{
				return;
			}
			Class115.bool_28 = true;
			if (Class114.bool_0 && !Class115.thread_0.IsAlive)
			{
				Class115.smethod_6(true);
				Class115.class80_0.method_8(true);
				Class115.class80_0.method_9(true);
				Class115.smethod_6(false);
				Class115.bool_28 = false;
				return;
			}
			Class47 arg_7A_0 = Class115.class47_0;
			if (Class115.voidDelegate_21 == null)
			{
				Class115.voidDelegate_21 = new VoidDelegate(Class115.smethod_120);
			}
			arg_7A_0.method_1(Class115.voidDelegate_21, 100, false);
		}

		// Token: 0x06001A0F RID: 6671
		// RVA: 0x0007F918 File Offset: 0x0007DB18
		internal static OsuModes smethod_81(string[] string_3)
		{
			EventHandler eventHandler = null;
			Class115.Class352 class = new Class115.Class352();
			if (string_3 != null && string_3.Length != 0 && (string_3.Length != 1 || !string.IsNullOrEmpty(string_3[0])))
			{
				class.string_0 = string_3[0];
				string text = string.Empty;
				try
				{
					text = Path.GetExtension(class.string_0).Trim(new char[]
					{
						'.'
					}).ToLower();
				}
				catch
				{
					OsuModes result = OsuModes.Unknown;
					return result;
				}
				try
				{
					OsuModes result;
					string key;
					switch (key = text)
					{
					case "osz2":
					case "zip":
					case "osz":
					{
						string fullPath = Path.GetFullPath(Class466.smethod_17());
						int i = 0;
						while (i < string_3.Length)
						{
							string path = string_3[i];
							Class115.Class353 class2 = new Class115.Class353();
							class2.class352_0 = class;
							string text2 = Path.GetFileName(path);
							int num2 = fullPath.Length + text2.Length - 248;
							if (num2 <= 0)
							{
								goto IL_211;
							}
							int num3 = text2.Length - num2;
							if (num3 > text.Length + 1)
							{
								text2 = text2.Remove(num3) + "." + text;
								goto IL_211;
							}
							Class723.smethod_5("Error moving " + text2 + ". Path is too long.", Color.get_Red(), 1000, null);
							IL_260:
							i++;
							continue;
							IL_211:
							class2.string_0 = Class466.smethod_17() + text2;
							Class296 class3 = Class466.list_3.Find(new Predicate<Class296>(class2.method_0));
							if (class3 != null)
							{
								Class466.smethod_21(class3);
								goto IL_260;
							}
							if (Class34.smethod_14(path, class2.string_0, true, true))
							{
								Class77.smethod_1(true);
								goto IL_260;
							}
							if (Class466.list_5.Contains(class2.string_0))
							{
								Class466.list_5.Remove(class2.string_0);
							}
							Class792.smethod_0("Error moving file " + text2);
							result = OsuModes.Unknown;
							return result;
						}
						OsuModes osuModes = Class115.osuModes_1;
						switch (osuModes)
						{
						case OsuModes.Edit:
						case OsuModes.Play:
							Class723.smethod_1("New beatmap available - visit song select to finish importing!", 1000);
							result = OsuModes.Unknown;
							return result;
						case OsuModes.Exit:
							break;
						case OsuModes.SelectEdit:
							goto IL_2C5;
						default:
							switch (osuModes)
							{
							case OsuModes.MatchSetup:
							case OsuModes.SelectMulti:
								goto IL_2C5;
							}
							break;
						}
						result = OsuModes.SelectPlay;
						return result;
						IL_2C5:
						result = Class115.osuModes_1;
						return result;
					}
					case "ogg":
					case "mp3":
						Class77.smethod_1(true);
						for (int j = 0; j < string_3.Length; j++)
						{
							string text3 = string_3[j];
							string destFileName = Class466.smethod_17() + Path.GetFileName(text3);
							Class34.smethod_18(destFileName);
							File.Copy(text3, destFileName);
						}
						result = OsuModes.SelectEdit;
						return result;
					case "osr":
					{
						Class512 class4 = Class908.smethod_4(class.string_0);
						OsuModes osuModes2 = Class115.osuModes_1;
						switch (osuModes2)
						{
						case OsuModes.Edit:
						case OsuModes.Play:
							break;
						default:
							if (osuModes2 != OsuModes.MatchSetup)
							{
								if (Class72.class10_0 != null)
								{
									Class723.smethod_1("Replay has been loaded.", 1000);
									result = OsuModes.Unknown;
									return result;
								}
								if (class4 != null)
								{
									Class296 class5 = Class466.smethod_25(class4.string_1);
									if (Class466.Current != class5)
									{
										Class466.smethod_21(class5);
										Class331.smethod_86(class5, true, false, true);
									}
									Class802.class512_0 = class4;
									Class802.smethod_1(true);
									result = OsuModes.Rank;
									return result;
								}
								result = OsuModes.Unknown;
								return result;
							}
							break;
						}
						Class723.smethod_1("Replay has been loaded.", 1000);
						result = OsuModes.Unknown;
						return result;
					}
					case "osk":
						for (int k = 0; k < string_3.Length; k++)
						{
							string path2 = string_3[k];
							string fileName = Path.GetFileName(path2);
							string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
							try
							{
								string path3 = Path.Combine("Skins", fileNameWithoutExtension);
								string text4 = Path.Combine(Path.Combine(Application.StartupPath, "Skins"), fileName);
								Class34.smethod_14(path2, text4, true, true);
								string text5 = Path.Combine(Path.Combine(Path.GetTempPath(), "osu!"), fileNameWithoutExtension);
								if (!Directory.Exists(text5))
								{
									Directory.CreateDirectory(text5);
								}
								Class203 class6 = new Class203();
								class6.method_6(text4, text5, ".*");
								FileInfo fileInfo = new FileInfo(text4);
								if ((fileInfo.Attributes & FileAttributes.ReadOnly) > (FileAttributes)0)
								{
									fileInfo.Attributes &= ~FileAttributes.ReadOnly;
								}
								Class34.smethod_20(text5, path3);
								Class34.smethod_18(text4);
								int num4 = 5;
								while (Directory.GetFiles(path3).Length < 1 && num4-- > 0)
								{
									string[] directories = Directory.GetDirectories(path3);
									Class34.smethod_20(directories[0], path3);
								}
								Class341.class605_19.Value = fileNameWithoutExtension;
							}
							catch
							{
								Class723.smethod_4("Unable to import skin \"" + fileName + "\".");
							}
						}
						Class802.smethod_1(false);
						result = OsuModes.SkinSelect;
						return result;
					case "avi":
					case "mpg":
					case "flv":
					case "jpg":
					case "png":
					{
						if (Class115.osuModes_1 == OsuModes.Menu && (Class809.class623_0 & Enum30.flag_3) > Enum30.flag_0 && (text == "png" || text == "jpg"))
						{
							Class885.smethod_36();
							string destFileName2 = Class34.smethod_15(Path.Combine(Path.Combine("Skins", Class885.class547_0.string_2), "menu-background.jpg"));
							Class34.smethod_18(destFileName2);
							File.Copy(class.string_0, destFileName2);
							Class885.smethod_9(Class341.class605_19, true);
							result = OsuModes.Menu;
							return result;
						}
						if (Class115.osuModes_1 != OsuModes.Edit)
						{
							Class723.smethod_4(Class41.GetString(OsuString.General_File_EnterEditor));
							result = OsuModes.Unknown;
							return result;
						}
						string arg_62D_0 = "Would you like to use \"" + Path.GetFileName(class.string_0) + "\" as your map's background?";
						if (eventHandler == null)
						{
							eventHandler = new EventHandler(class.method_0);
						}
						Class101 class89_ = new Class101(arg_62D_0, eventHandler, null);
						Class115.smethod_37(class89_);
						result = OsuModes.Unknown;
						return result;
					}
					}
					if (class.string_0.StartsWith("osu://"))
					{
						if (Class809.bool_4)
						{
							Class111.smethod_41(class.string_0);
						}
						else
						{
							Class115.Class354 class7 = new Class115.Class354();
							class7.class352_0 = class;
							class7.voidDelegate_0 = null;
							class7.voidDelegate_0 = new VoidDelegate(class7.method_0);
							Class809.smethod_10(class7.voidDelegate_0);
						}
						result = OsuModes.Unknown;
						return result;
					}
					if (!class.string_0.StartsWith("-") && class.string_0.Contains("."))
					{
						Class723.smethod_4(Class41.GetString(OsuString.General_File_UnknownType) + " (" + class.string_0 + ")");
					}
					result = OsuModes.Unknown;
					return result;
				}
				catch (Exception ex)
				{
					Class792.smethod_0(string.Concat(new object[]
					{
						"Error moving file ",
						string_3,
						"\n",
						ex
					}));
				}
				return OsuModes.Unknown;
			}
			return OsuModes.Unknown;
		}

		// Token: 0x06001A11 RID: 6673
		// RVA: 0x000800B0 File Offset: 0x0007E2B0
		internal static void smethod_82(string string_3, string string_4)
		{
			if (!Directory.Exists("Exports"))
			{
				Directory.CreateDirectory("Exports");
			}
			string string_5 = "Exports\\" + Class34.smethod_1(string_3);
			Class204.smethod_1(932);
			Class203 class = new Class203();
			class.method_4(string_5, string_4, true, "[^z]+$");
			Class723.smethod_5(string_3 + " has been exported.  Opening the Exports folder...", Color.get_YellowGreen(), 6000, null);
			Class115.smethod_83("Exports");
		}

		// Token: 0x06001A12 RID: 6674
		// RVA: 0x00016102 File Offset: 0x00014302
		internal static void smethod_83(string string_3)
		{
			if (string.IsNullOrEmpty(string_3))
			{
				return;
			}
			if (string_3[string_3.Length - 1] != Path.DirectorySeparatorChar)
			{
				string_3 += Path.DirectorySeparatorChar;
			}
			Class115.smethod_90(string_3, null);
		}

		// Token: 0x06001A16 RID: 6678
		// RVA: 0x00080128 File Offset: 0x0007E328
		internal static void smethod_84()
		{
			if (Class115.bool_16)
			{
				return;
			}
			try
			{
				if (Class341.class606_7)
				{
					Class331.smethod_59("match-start", 100, Enum112.flag_5);
				}
				Control arg_44_0 = Class115.form_0;
				if (Class115.voidDelegate_22 == null)
				{
					Class115.voidDelegate_22 = new VoidDelegate(Class115.smethod_121);
				}
				arg_44_0.Invoke(Class115.voidDelegate_22);
			}
			catch
			{
			}
		}

		// Token: 0x06001A17 RID: 6679
		// RVA: 0x0001613B File Offset: 0x0001433B
		internal static void smethod_85(VoidDelegate voidDelegate_24)
		{
			if (voidDelegate_24 != null)
			{
				Class115.smethod_17(voidDelegate_24);
			}
			Class905.bool_2 = true;
			Class115.smethod_70(OsuModes.Exit, false);
		}

		// Token: 0x06001A18 RID: 6680
		// RVA: 0x00080194 File Offset: 0x0007E394
		internal static bool smethod_86()
		{
			try
			{
				IntPtr zero = IntPtr.Zero;
				IntPtr zero2 = IntPtr.Zero;
				IntPtr intPtr = new IntPtr(2);
				if (Class115.GetLayeredWindowAttributes(Class115.form_0.Handle, ref zero, ref zero2, ref intPtr))
				{
					return zero2.ToInt32() < 255;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06001A19 RID: 6681
		// RVA: 0x000801FC File Offset: 0x0007E3FC
		internal static Thread smethod_87(VoidDelegate voidDelegate_24)
		{
			if (!Class115.bool_11 && (!Class115.bool_27 || BaseGLControl.bool_0))
			{
				lock (Class115.queue_0)
				{
					if (voidDelegate_24 != null)
					{
						Class115.queue_0.Enqueue(voidDelegate_24);
					}
					if (Class115.queue_0.Count > 0 && (Class115.thread_1 == null || !Class115.thread_1.IsAlive))
					{
						if (Class115.voidDelegate_23 == null)
						{
							Class115.voidDelegate_23 = new VoidDelegate(Class115.smethod_122);
						}
						Class115.thread_1 = Class115.smethod_88(Class115.voidDelegate_23, false, ThreadPriority.Normal);
					}
				}
				return Class115.thread_1;
			}
			if (voidDelegate_24 != null)
			{
				Class115.class47_0.Add(voidDelegate_24, true);
			}
			return Class115.thread_2;
		}

		// Token: 0x06001A1A RID: 6682
		// RVA: 0x000802B8 File Offset: 0x0007E4B8
		internal static Thread smethod_88(VoidDelegate voidDelegate_24, bool bool_36, ThreadPriority threadPriority_0)
		{
			Thread result;
			try
			{
				Thread thread = new Thread(new ThreadStart(voidDelegate_24.Invoke));
				thread.IsBackground = !bool_36;
				thread.Priority = threadPriority_0;
				thread.Start();
				return thread;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001A1B RID: 6683
		// RVA: 0x00016153 File Offset: 0x00014353
		internal static void smethod_89(bool bool_36)
		{
			if (Class115.int_1 - Class115.int_32 < 5000 && !bool_36)
			{
				return;
			}
			Class115.int_32 = Class115.int_1;
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}

		// Token: 0x060019B7 RID: 6583
		// RVA: 0x0007B9E4 File Offset: 0x00079BE4
		private static void smethod_9(object sender, DragEventArgs e)
		{
			try
			{
				Array array = (Array)e.Data.GetData(DataFormats.FileDrop);
				OsuModes osuModes = OsuModes.Unknown;
				if (array != null)
				{
					string[] array2 = new string[array.Length];
					for (int i = 0; i < array.Length; i++)
					{
						array2[i] = array.GetValue(i).ToString();
					}
					osuModes = Class115.smethod_81(array2);
				}
				else
				{
					string text = e.Data.GetData(DataFormats.Text) as string;
					if (text.StartsWith("http"))
					{
						Class111.smethod_41(text);
					}
					else
					{
						osuModes = Class115.smethod_81(new string[]
						{
							text
						});
					}
				}
				if (osuModes != OsuModes.Unknown)
				{
					Class115.smethod_70(osuModes, true);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06001A1C RID: 6684
		// RVA: 0x00080308 File Offset: 0x0007E508
		internal static void smethod_90(string string_3, string string_4)
		{
			Class115.Class355 class = new Class115.Class355();
			class.string_0 = string_3;
			class.string_1 = string_4;
			if (Class115.bool_16)
			{
				return;
			}
			Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
		}

		// Token: 0x06001A1D RID: 6685
		// RVA: 0x0001617F File Offset: 0x0001437F
		public static int smethod_91()
		{
			return Class115.int_1 - Class802.int_4;
		}

		// Token: 0x06001A1E RID: 6686
		// RVA: 0x0001618C File Offset: 0x0001438C
		public static bool smethod_92()
		{
			return Class115.class89_0 != null || Class115.list_2.Count > 0;
		}

		// Token: 0x06001A1F RID: 6687
		// RVA: 0x000161A4 File Offset: 0x000143A4
		public static bool smethod_93()
		{
			return (Class115.int_23 >= 800 || Class341.class606_28) && !Class341.class606_42;
		}

		// Token: 0x06001A20 RID: 6688
		// RVA: 0x00080348 File Offset: 0x0007E548
		public static bool smethod_94()
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Platform == PlatformID.Win32NT && oSVersion.Version.Major >= 6 && oSVersion.Version.Minor >= 3;
		}

		// Token: 0x06001A21 RID: 6689
		// RVA: 0x000161CD File Offset: 0x000143CD
		internal static void smethod_95()
		{
			if (Class115.spriteBatch_0 == null)
			{
				return;
			}
			Class115.spriteBatch_0.Dispose();
			Class115.spriteBatch_0 = new SpriteBatch(Class115.class125_0.GraphicsDevice);
		}

		// Token: 0x06001A22 RID: 6690
		// RVA: 0x00080388 File Offset: 0x0007E588
		public static void smethod_96(bool bool_36)
		{
			if (bool_36 == Class115.bool_34)
			{
				return;
			}
			Class115.bool_34 = bool_36;
			if (Class115.bool_34)
			{
				if (Class115.notifyIcon_0 == null)
				{
					Class115.notifyIcon_0 = new NotifyIcon();
					Class115.notifyIcon_0.Icon = Class115.form_0.Icon;
					NotifyIcon arg_60_0 = Class115.notifyIcon_0;
					if (Class115.eventHandler_12 == null)
					{
						Class115.eventHandler_12 = new EventHandler(Class115.smethod_123);
					}
					arg_60_0.Click += Class115.eventHandler_12;
				}
				Class115.notifyIcon_0.Visible = true;
				if (Class341.class606_6)
				{
					Class115.notifyIcon_0.ShowBalloonTip(10000, Class41.GetString(OsuString.BossKeyActivated), Class41.GetString(OsuString.BossKeyActivated_Tooltip), ToolTipIcon.Info);
					Class341.class606_6.Value = false;
				}
				Class115.form_0.WindowState = FormWindowState.Minimized;
				Class115.form_0.Visible = false;
				Class62 class62_ = Class62.class62_0;
				if (class62_ != null && (!(class62_ is Class64) || !Class62.bool_40) && !Class331.smethod_79() && !Class62.bool_11 && !Class802.smethod_0())
				{
					class62_.vmethod_16();
				}
				Class115.int_3 = Class331.class608_2.Value;
				Class331.class608_2.Value = 0;
				return;
			}
			Class115.form_0.Visible = true;
			Class115.form_0.WindowState = FormWindowState.Normal;
			Class115.form_0.ShowInTaskbar = true;
			Class115.notifyIcon_0.Visible = false;
			Class115.smethod_26();
			Class331.class608_2.Value = Class115.int_3;
		}

		// Token: 0x06001A23 RID: 6691
		// RVA: 0x000804E4 File Offset: 0x0007E6E4
		public static bool smethod_97()
		{
			OsuModes osuModes = Class115.osuModes_1;
			if (osuModes != OsuModes.Play && osuModes != OsuModes.Rank)
			{
				switch (osuModes)
				{
				case OsuModes.RankingVs:
				case OsuModes.RankingTagCoop:
				case OsuModes.RankingTeam:
					return false;
				case OsuModes.OnlineSelection:
				case OsuModes.OptionsOffsetWizard:
					return true;
				}
				return true;
			}
			return false;
		}

		// Token: 0x06001A24 RID: 6692
		// RVA: 0x000161F5 File Offset: 0x000143F5
		[CompilerGenerated]
		private static void smethod_98()
		{
			if (Class115.voidDelegate_10 == null)
			{
				Class115.voidDelegate_10 = new VoidDelegate(Class115.smethod_99);
			}
			Class115.smethod_88(Class115.voidDelegate_10, false, ThreadPriority.Normal);
		}

		// Token: 0x06001A25 RID: 6693
		// RVA: 0x00080520 File Offset: 0x0007E720
		[CompilerGenerated]
		private static void smethod_99()
		{
			while (Class115.osuModes_1 == OsuModes.Play)
			{
				Thread.Sleep(1000);
			}
			Class214.Check(new Delegate26(Class115.smethod_2), Class341.class605_25.Value, (Class115.osuModes_1 == OsuModes.Menu || Class115.osuModes_1 == OsuModes.Unknown) ? ThreadPriority.Highest : ThreadPriority.BelowNormal);
		}

		// Token: 0x060019E4 RID: 6628
		// RVA: 0x0007E628 File Offset: 0x0007C828
		protected override void vmethod_4(bool bool_36)
		{
			lock (BaseGLControl.object_0)
			{
				base.vmethod_4(bool_36);
				Class115.class882_0 = new Class882();
				Class297.smethod_12();
				if (!Class115.bool_26)
				{
					if (Class885.interface17_0 != null)
					{
						Class885.interface17_0.Dispose();
					}
					Class885.interface17_0 = null;
					Class885.smethod_11();
				}
				Class731 class = Class731.smethod_8(new byte[]
				{
					255,
					255,
					255,
					255
				}, 1, 1, false);
				GC.SuppressFinalize(class);
				if (Class115.class731_0 != null)
				{
					Class115.class731_0.method_3(class.method_2());
					Class115.class731_0.bool_2 = false;
				}
				else
				{
					Class115.class731_0 = class;
				}
				if (Class115.class582_0 == null)
				{
					Class115.class582_0 = new Class582();
				}
				Class115.class582_0.method_0(Class115.class125_0.GraphicsDevice, Class115.contentManager_0);
				Class115.interface16_0 = Class115.class582_0;
				if (Class115.bool_26)
				{
					if (Class115.spriteBatch_0 != null)
					{
						Class115.spriteBatch_0.Dispose();
					}
					Class115.spriteBatch_0 = new SpriteBatch(Class115.class125_0.GraphicsDevice);
					Class885.smethod_33(false);
					Class115.smethod_55(bool_36);
					Class733.Initialize();
					if (Class885.interface17_0 != null)
					{
						Class885.interface17_0.Dispose();
					}
					Class885.interface17_0 = null;
					Class885.smethod_11();
				}
				this.bool_33 = true;
				Monitor.PulseAll(BaseGLControl.object_0);
			}
		}

		// Token: 0x060019C3 RID: 6595
		// RVA: 0x0007BDEC File Offset: 0x00079FEC
		protected override void vmethod_7(object sender, EventArgs e)
		{
			if (Class115.voidDelegate_6 != null)
			{
				Class115.voidDelegate_6();
			}
			Class809.smethod_27();
			Class786.smethod_1(false, string.Empty, string.Empty, string.Empty, string.Empty);
			if (Class115.osuModes_1 == OsuModes.Edit)
			{
				try
				{
					((Editor)Class115.class61_0).method_81();
				}
				catch (Exception)
				{
				}
			}
			try
			{
				Class341.smethod_3();
			}
			catch
			{
			}
			Class466.smethod_29();
			Class856.smethod_0();
			try
			{
				Class908.smethod_3(false);
			}
			catch
			{
			}
			try
			{
				Class476.smethod_6(false);
			}
			catch
			{
			}
			try
			{
				if (Class115.osuModes_1 == OsuModes.Play && !Class802.smethod_0())
				{
					Class62.class62_0.method_44();
				}
			}
			catch
			{
			}
			Class788.smethod_1();
			Class115.class911_0.Dispose();
			Class115.class911_2.Dispose();
			Class115.class911_3.Dispose();
			if (Class341.class606_70)
			{
				Class808.smethod_1();
			}
			Cursor.Show();
			Cursor.Clip = Class802.rectangle_0;
			try
			{
				Directory.Delete("Data\\a", true);
			}
			catch
			{
			}
			try
			{
				Bass.BASS_Free();
			}
			catch
			{
			}
			Class802.Dispose();
			base.vmethod_7(sender, e);
		}

		// Token: 0x060019E5 RID: 6629
		// RVA: 0x0007E788 File Offset: 0x0007C988
		protected override void vmethod_8(bool bool_36)
		{
			lock (BaseGLControl.object_0)
			{
				this.bool_33 = false;
				if (bool_36)
				{
					if (Class115.bool_26 && Class115.class731_0 != null && Class115.class731_0.method_2() != null)
					{
						Class115.class731_0.method_2().Dispose();
					}
					if (Class115.contentManager_0 != null)
					{
						Class115.contentManager_0.Unload();
					}
					Class885.smethod_31();
				}
				Class733.smethod_0();
				Class115.smethod_52(bool_36);
			}
		}

		// Token: 0x060019D9 RID: 6617
		// RVA: 0x0007D754 File Offset: 0x0007B954
		protected override void vmethod_9()
		{
			Thread.Sleep(0);
			try
			{
				Class115.bool_11 = (base.method_4().vmethod_2() || (base.method_4().vmethod_0().X < -10000 && base.method_4().vmethod_0().Y < -10000));
				bool flag = Class341.class605_26.Value == FrameSync.LowLatencyVSync && Class115.int_27 > 0;
				double num = 0.0;
				Class115.class114_0.bool_7 = (Class115.bool_11 && !Class62.bool_12 && !Class62.bool_9 && !Class802.bool_16);
				if ((Class115.bool_11 || Class115.smethod_5() || !Class114.bool_0 || Class115.bool_31) && !Class62.bool_12 && !Class62.bool_9 && !Class802.bool_16 && !Class802.smethod_0())
				{
					if (Class115.smethod_91() > 30000 && Class115.int_1 - this.int_14 > 120000 && Class115.int_1 - this.int_14 > Class115.smethod_91())
					{
						Class115.smethod_88(new VoidDelegate(this.method_33), true, ThreadPriority.Normal);
						this.int_14 = Class115.int_1;
					}
					Thread.Sleep(16);
				}
				else if (flag)
				{
					int num2 = (1800 - this.int_13 * Class115.int_27 * 3) / (2 * Class115.int_27);
					if (num2 > 0 && num2 <= 1000 / Class115.int_27)
					{
						Thread.Sleep(num2);
					}
				}
				else
				{
					this.int_12 = -1;
				}
				if (flag)
				{
					num = (double)Class115.stopwatch_0.ElapsedTicks / (double)Stopwatch.Frequency * 1000.0;
				}
				if (Class115.class521_0 != null)
				{
					Class115.class521_0.vmethod_0();
				}
				this.method_34();
				Class115.class47_0.method_0();
				this.method_35();
				Class115.smethod_35();
				bool bool_ = Class733.bool_1;
				this.bool_29 = false;
				Class733.bool_1 = false;
				this.method_36();
				Class115.class729_0.method_0();
				Class115.class525_0.vmethod_0();
				Class115.class83_0.imethod_2();
				Class115.class80_0.imethod_2();
				Class115.class81_0.imethod_2();
				if (Class115.class522_0 != null)
				{
					Class115.class522_0.vmethod_0();
				}
				Class802.smethod_12();
				if (!this.bool_29)
				{
					Class733.bool_1 = bool_;
				}
				if (Class115.bool_13)
				{
					Class723.smethod_7();
					Class589.smethod_0();
					if (Class115.int_1 / 10000 != this.int_10)
					{
						this.int_10 = Class115.int_1 / 10000;
						Class885.Cleanup();
					}
					if (Class115.int_1 / 1000 != this.int_31)
					{
						this.int_31 = Class115.int_1 / 1000;
						Class802.smethod_27(false);
						Class115.smethod_36();
					}
				}
				if (Class115.bool_30 && Class115.int_1 > 120000)
				{
					Class115.smethod_69(false);
				}
				if (flag)
				{
					this.method_31((int)((double)Class115.stopwatch_0.ElapsedTicks / (double)Stopwatch.Frequency * 1000.0 - num + 1.0));
				}
			}
			catch (Exception exception_)
			{
				if (Class115.int_16++ > 1 || Class115.osuModes_1 == OsuModes.Exit || Class115.osuModes_0 == OsuModes.Exit)
				{
					throw;
				}
				Class115.smethod_39(exception_);
			}
			Class115.smethod_87(null);
			if (Class115.bool_16 && !Class115.bool_17)
			{
				Class861 class = Class858.class861_0;
				Class115.class533_0.Text = ((class == null) ? string.Empty : class.Name);
				if (Class115.int_1 > 40000 && Class115.int_1 - Class784.int_0 > 10000)
				{
					Class115.smethod_69(false);
				}
			}
		}
	}
}
