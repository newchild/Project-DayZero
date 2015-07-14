using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns18;
using ns24;
using ns29;
using ns59;
using ns6;
using ns64;
using ns8;
using ns80;
using ns89;
using ns9;
using ns90;
using osu;
using osu.Audio;
using osu.GameplayElements.HitObjects;
using osu_common;
using osu_common.Helpers;
using osu_gameplay;
using osu_ui;
using osudata;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Tags;

namespace ns26
{
	// Token: 0x0200033C RID: 828
	internal static class Class331
	{
		// Token: 0x0200033E RID: 830
		[CompilerGenerated]
		private sealed class Class332
		{
			// Token: 0x04001332 RID: 4914
			public int int_0;

			// Token: 0x06001904 RID: 6404
			// RVA: 0x0001548C File Offset: 0x0001368C
			public bool method_0(Class340 class340_0)
			{
				return class340_0.method_0() && class340_0.double_1 < (double)this.int_0;
			}

			// Token: 0x06001905 RID: 6405
			// RVA: 0x000154A7 File Offset: 0x000136A7
			public bool method_1(Class340 class340_0)
			{
				return class340_0.double_1 < (double)this.int_0;
			}
		}

		// Token: 0x0200033F RID: 831
		[CompilerGenerated]
		private sealed class Class333
		{
			// Token: 0x04001333 RID: 4915
			public int int_0;

			// Token: 0x04001334 RID: 4916
			private static VoidDelegate voidDelegate_0;

			// Token: 0x04001335 RID: 4917
			private static VoidDelegate voidDelegate_1;

			// Token: 0x04001336 RID: 4918
			private static VoidDelegate voidDelegate_2;

			// Token: 0x06001907 RID: 6407
			// RVA: 0x000786EC File Offset: 0x000768EC
			public void method_0()
			{
				while (this.int_0 != Class331.int_18)
				{
					if (this.int_0 > Class331.int_18)
					{
						this.int_0 -= Math.Max(1, (this.int_0 - Class331.int_18) / 10);
					}
					else
					{
						this.int_0 += Math.Max(1, (Class331.int_18 - this.int_0) / 10);
					}
					if (this.int_0 != 0)
					{
						if (this.int_0 < 0 && !Class331.smethod_71())
						{
							Class47 arg_97_0 = Class115.class47_0;
							if (Class331.Class333.voidDelegate_0 == null)
							{
								Class331.Class333.voidDelegate_0 = new VoidDelegate(Class331.Class333.smethod_0);
							}
							arg_97_0.Add(Class331.Class333.voidDelegate_0, false);
						}
						else if (this.int_0 > 0 && Class331.smethod_71())
						{
							Class47 arg_D1_0 = Class115.class47_0;
							if (Class331.Class333.voidDelegate_1 == null)
							{
								Class331.Class333.voidDelegate_1 = new VoidDelegate(Class331.Class333.smethod_1);
							}
							arg_D1_0.Add(Class331.Class333.voidDelegate_1, false);
						}
						else
						{
							Class331.float_1 = (float)Math.Abs(this.int_0);
							Class47 arg_10C_0 = Class115.class47_0;
							if (Class331.Class333.voidDelegate_2 == null)
							{
								Class331.Class333.voidDelegate_2 = new VoidDelegate(Class331.Class333.smethod_2);
							}
							arg_10C_0.Add(Class331.Class333.voidDelegate_2, false);
						}
						Thread.Sleep(20);
					}
				}
				Class331.thread_0 = null;
			}

			// Token: 0x06001908 RID: 6408
			// RVA: 0x000154B8 File Offset: 0x000136B8
			private static void smethod_0()
			{
				Class331.smethod_72(!Class331.smethod_71());
			}

			// Token: 0x06001909 RID: 6409
			// RVA: 0x000154B8 File Offset: 0x000136B8
			private static void smethod_1()
			{
				Class331.smethod_72(!Class331.smethod_71());
			}

			// Token: 0x0600190A RID: 6410
			// RVA: 0x000154C7 File Offset: 0x000136C7
			private static void smethod_2()
			{
				Bass.BASS_ChannelSetAttribute(Class331.class335_0.method_0(), 1, Class331.float_1);
			}
		}

		// Token: 0x02000340 RID: 832
		[CompilerGenerated]
		private sealed class Class334
		{
			// Token: 0x04001337 RID: 4919
			public string string_0;

			// Token: 0x0600190C RID: 6412
			// RVA: 0x000154DF File Offset: 0x000136DF
			public bool method_0(BASS_DEVICEINFO bass_DEVICEINFO_0)
			{
				return bass_DEVICEINFO_0.name == this.string_0;
			}
		}

		// Token: 0x0200033D RID: 829
		// Token: 0x06001900 RID: 6400
		internal delegate void Delegate31(Class340 class340_0);

		// Token: 0x0400132F RID: 4911
		[CompilerGenerated]
		private static Action<Class339> action_0;

		// Token: 0x040012EE RID: 4846
		internal static bool bool_0;

		// Token: 0x040012F4 RID: 4852
		internal static bool bool_1 = true;

		// Token: 0x040012F5 RID: 4853
		internal static bool bool_2;

		// Token: 0x040012F6 RID: 4854
		internal static bool bool_3;

		// Token: 0x040012F7 RID: 4855
		internal static bool bool_4;

		// Token: 0x04001303 RID: 4867
		internal static bool bool_5 = false;

		// Token: 0x04001323 RID: 4899
		private static bool bool_6;

		// Token: 0x04001324 RID: 4900
		private static bool bool_7;

		// Token: 0x04001329 RID: 4905
		internal static bool bool_8;

		// Token: 0x04001311 RID: 4881
		internal static Class335 class335_0;

		// Token: 0x04001315 RID: 4885
		internal static Class608 class608_0;

		// Token: 0x04001316 RID: 4886
		internal static Class608 class608_1;

		// Token: 0x04001318 RID: 4888
		internal static Class608 class608_2;

		// Token: 0x04001319 RID: 4889
		internal static Class88 class88_0;

		// Token: 0x040012F2 RID: 4850
		private static Class331.Delegate31 delegate31_0;

		// Token: 0x040012F3 RID: 4851
		private static Class331.Delegate31 delegate31_1;

		// Token: 0x040012F8 RID: 4856
		private static readonly Dictionary<string, int> dictionary_0 = new Dictionary<string, int>();

		// Token: 0x040012F9 RID: 4857
		private static readonly Dictionary<string, int> dictionary_1 = new Dictionary<string, int>();

		// Token: 0x040012FA RID: 4858
		private static readonly Dictionary<string, int> dictionary_2 = new Dictionary<string, int>();

		// Token: 0x0400131B RID: 4891
		internal static Dictionary<string, string> dictionary_3 = new Dictionary<string, string>();

		// Token: 0x0400131D RID: 4893
		internal static Dictionary<int, long> dictionary_4 = new Dictionary<int, long>();

		// Token: 0x040012ED RID: 4845
		internal static double double_0;

		// Token: 0x040012FD RID: 4861
		private static double double_1 = 0.0;

		// Token: 0x04001314 RID: 4884
		internal static double double_2;

		// Token: 0x0400132A RID: 4906
		internal static double double_3;

		// Token: 0x040012FB RID: 4859
		internal static Enum100 enum100_0;

		// Token: 0x04001309 RID: 4873
		private static Enum38 enum38_0;

		// Token: 0x0400130B RID: 4875
		private static Enum38 enum38_1;

		// Token: 0x04001313 RID: 4883
		private static Enum38 enum38_2;

		// Token: 0x0400130F RID: 4879
		internal static float float_0;

		// Token: 0x04001310 RID: 4880
		internal static float float_1;

		// Token: 0x0400131A RID: 4890
		internal static float float_2;

		// Token: 0x04001328 RID: 4904
		private static float float_3;

		// Token: 0x040012EC RID: 4844
		internal static int int_0;

		// Token: 0x040012EF RID: 4847
		internal static int int_1 = -1;

		// Token: 0x04001307 RID: 4871
		internal static int int_10 = 0;

		// Token: 0x04001317 RID: 4887
		internal static int int_11;

		// Token: 0x0400131C RID: 4892
		internal static int int_12;

		// Token: 0x0400131E RID: 4894
		internal static int[,,] int_13 = new int[4, 3, 3];

		// Token: 0x0400131F RID: 4895
		internal static int[,,] int_14 = new int[1, 3, 3];

		// Token: 0x04001320 RID: 4896
		internal static int[,,] int_15 = new int[2, 3, 3];

		// Token: 0x04001321 RID: 4897
		private static int int_16;

		// Token: 0x04001325 RID: 4901
		private static int int_17;

		// Token: 0x04001327 RID: 4903
		private static int int_18;

		// Token: 0x0400132E RID: 4910
		private static int int_19;

		// Token: 0x040012F1 RID: 4849
		internal static int int_2 = -1;

		// Token: 0x040012FE RID: 4862
		internal static int int_3;

		// Token: 0x040012FF RID: 4863
		private static int int_4;

		// Token: 0x04001300 RID: 4864
		private static int int_5;

		// Token: 0x04001301 RID: 4865
		private static int int_6;

		// Token: 0x04001304 RID: 4868
		internal static int int_7 = 0;

		// Token: 0x04001305 RID: 4869
		internal static int int_8 = 0;

		// Token: 0x04001306 RID: 4870
		internal static int int_9 = 0;

		// Token: 0x040012FC RID: 4860
		private static List<Class339> list_0 = new List<Class339>();

		// Token: 0x04001302 RID: 4866
		internal static List<Class338> list_1 = new List<Class338>();

		// Token: 0x0400132C RID: 4908
		internal static List<BASS_DEVICEINFO> list_2 = new List<BASS_DEVICEINFO>();

		// Token: 0x04001330 RID: 4912
		[CompilerGenerated]
		private static Predicate<Class339> predicate_0;

		// Token: 0x04001331 RID: 4913
		[CompilerGenerated]
		private static Predicate<BASS_DEVICEINFO> predicate_1;

		// Token: 0x0400130A RID: 4874
		internal static SampleSet sampleSet_0 = SampleSet.None;

		// Token: 0x0400130C RID: 4876
		private static SampleSet sampleSet_1 = SampleSet.None;

		// Token: 0x0400130D RID: 4877
		private static SampleSet sampleSet_2 = SampleSet.None;

		// Token: 0x04001322 RID: 4898
		private static SampleSet[] sampleSet_3 = new SampleSet[]
		{
			SampleSet.Normal,
			SampleSet.Soft,
			SampleSet.Drum
		};

		// Token: 0x0400130E RID: 4878
		internal static string string_0;

		// Token: 0x04001312 RID: 4882
		internal static string string_1;

		// Token: 0x0400132D RID: 4909
		internal static string string_2 = null;

		// Token: 0x04001326 RID: 4902
		private static Thread thread_0;

		// Token: 0x040012F0 RID: 4848
		private static VoidDelegate voidDelegate_0;

		// Token: 0x04001308 RID: 4872
		private static VoidDelegate voidDelegate_1;

		// Token: 0x0400132B RID: 4907
		private static VoidDelegate voidDelegate_2;

		// Token: 0x060018C2 RID: 6338
		// RVA: 0x00076D9C File Offset: 0x00074F9C
		internal static void Initialize()
		{
			if (!Class331.bool_6)
			{
				Class115.class47_0.method_1(new VoidDelegate(Class331.smethod_105), 500, true);
				BassNet.Registration("poo@poo.com", "2X25242411252422");
				Class331.bool_6 = true;
			}
			Class331.class608_2.vmethod_0();
			Class331.class608_2.imethod_2(new EventHandler(Class331.smethod_35));
			Class331.class608_2.imethod_2(new EventHandler(Class331.smethod_34));
			Class331.class608_0.vmethod_0();
			Class331.class608_0.imethod_2(new EventHandler(Class331.smethod_35));
			Class331.class608_1.vmethod_0();
			Class331.class608_1.imethod_2(new EventHandler(Class331.smethod_34));
			Class331.smethod_43();
		}

		// Token: 0x06001890 RID: 6288
		// RVA: 0x0001506E File Offset: 0x0001326E
		internal static double smethod_0()
		{
			return (double)Class331.int_7 - Class331.smethod_12();
		}

		// Token: 0x06001891 RID: 6289
		// RVA: 0x000759E0 File Offset: 0x00073BE0
		internal static void smethod_1()
		{
			Class331.smethod_6(false);
			List<Class340> list = Class331.smethod_14();
			if (Class466.Current != null && list != null && list.Count > Class331.int_2 && Class331.int_2 >= 0 && Class466.Current.int_6 > 3)
			{
				Class331.smethod_48(list[Class331.int_2].sampleSet_0, false);
			}
		}

		// Token: 0x0600189A RID: 6298
		// RVA: 0x00075E24 File Offset: 0x00074024
		internal static double smethod_10()
		{
			List<Class340> list = Class331.smethod_14();
			if (list == null || list.Count == 0)
			{
				return 0.0;
			}
			int count = list.Count;
			if (count > 0 && Class331.int_1 >= 0 && Class331.int_2 >= 0 && Class331.int_2 < count && Class331.int_1 < count)
			{
				return list[Class331.int_1].double_0;
			}
			return 0.0;
		}

		// Token: 0x060018F5 RID: 6389
		// RVA: 0x00015416 File Offset: 0x00013616
		internal static void smethod_100(int int_20, bool bool_9)
		{
			Class331.bool_4 = true;
			Class331.int_7 = int_20;
			Class331.int_10 = int_20;
			Class331.double_1 = (double)int_20;
			Class331.bool_8 = false;
			Class331.double_2 = (double)Class331.int_12;
			if (!bool_9)
			{
				Class331.enum100_0 = Enum100.const_1;
			}
		}

		// Token: 0x060018F6 RID: 6390
		// RVA: 0x0001544B File Offset: 0x0001364B
		internal static void smethod_101()
		{
			Class331.bool_4 = false;
		}

		// Token: 0x060018F7 RID: 6391
		// RVA: 0x00015453 File Offset: 0x00013653
		internal static bool smethod_102()
		{
			if (Class331.string_2 != null)
			{
				return true;
			}
			Class723.smethod_5("No compatible audio device detected. You must plug in a valid audio device in order to play osu!", Color.get_Red(), 4000, null);
			return false;
		}

		// Token: 0x060018F8 RID: 6392
		// RVA: 0x000782CC File Offset: 0x000764CC
		internal static void smethod_103(VoidDelegate voidDelegate_3)
		{
			VoidDelegate voidDelegate = Class331.voidDelegate_2;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Combine(voidDelegate2, voidDelegate_3);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref Class331.voidDelegate_2, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x060018F9 RID: 6393
		// RVA: 0x00078300 File Offset: 0x00076500
		internal static bool smethod_104(string string_3)
		{
			Class331.Class334 class = new Class331.Class334();
			Class331.list_2 = new List<BASS_DEVICEINFO>(Bass.BASS_GetDeviceInfos());
			if (Class331.voidDelegate_2 != null)
			{
				Class331.voidDelegate_2();
			}
			string text = Class331.string_2;
			class.string_0 = string_3;
			if (string.IsNullOrEmpty(string_3))
			{
				List<BASS_DEVICEINFO> arg_5F_0 = Class331.list_2;
				if (Class331.predicate_1 == null)
				{
					Class331.predicate_1 = new Predicate<BASS_DEVICEINFO>(Class331.smethod_108);
				}
				BASS_DEVICEINFO bASS_DEVICEINFO = arg_5F_0.Find(Class331.predicate_1);
				if (bASS_DEVICEINFO != null)
				{
					class.string_0 = bASS_DEVICEINFO.name;
				}
			}
			int num = Bass.BASS_GetDevice();
			BASS_DEVICEINFO bASS_DEVICEINFO2 = Bass.BASS_GetDeviceInfo(num);
			bool flag = bASS_DEVICEINFO2 != null && bASS_DEVICEINFO2.get_IsEnabled() && bASS_DEVICEINFO2.get_IsInitialized();
			if (class.string_0 == text && flag)
			{
				return true;
			}
			if (class.string_0 == null)
			{
				return false;
			}
			int num2 = Class331.list_2.FindIndex(new Predicate<BASS_DEVICEINFO>(class.method_0));
			BASS_DEVICEINFO bASS_DEVICEINFO3 = Bass.BASS_GetDeviceInfo(num2);
			if (flag && (bASS_DEVICEINFO3 == null || !bASS_DEVICEINFO3.get_IsEnabled()))
			{
				return true;
			}
			Class336 class2 = Class331.class335_0 as Class336;
			bool flag2 = class2 != null && class2.enum100_0 != Enum100.const_0;
			if (class.string_0 != null && text != null)
			{
				if (class2 != null)
				{
					class2.method_3();
				}
				Class331.smethod_44();
				Bass.BASS_Free();
			}
			if (bASS_DEVICEINFO3 != null && Bass.BASS_Init(num2, 44100, 0, Class115.class115_0.method_4().vmethod_1(), null))
			{
				Class331.string_2 = class.string_0;
				Bass.BASS_SetConfig(0, 100);
				Bass.BASS_SetConfig(12, 500);
				Bass.BASS_SetConfig(1, 10);
				if (Class331.bool_6)
				{
					Class331.Initialize();
					Class331.smethod_42();
					if (class2 != null && class2.class296_0 != null)
					{
						Class331.class335_0 = Class335.smethod_0(class2.class296_0, class2.vmethod_2(), class2.bool_4);
						Class331.class335_0.vmethod_1(class2.vmethod_0());
						Class331.class335_0.vmethod_11(class2.vmethod_10());
						Class331.class335_0.Seek((double)Class331.int_10);
						if (flag2)
						{
							Class331.class335_0.vmethod_6(false);
						}
					}
				}
				return true;
			}
			if (string_3 == null)
			{
				Class331.string_2 = null;
				return false;
			}
			return Class331.smethod_104(null);
		}

		// Token: 0x060018FA RID: 6394
		// RVA: 0x00078524 File Offset: 0x00076724
		private static void smethod_105()
		{
			int num = 0;
			BASS_DEVICEINFO[] array = Bass.BASS_GetDeviceInfos();
			for (int i = 0; i < array.Length; i++)
			{
				BASS_DEVICEINFO bASS_DEVICEINFO = array[i];
				if (bASS_DEVICEINFO.driver != null)
				{
					bool flag = bASS_DEVICEINFO.name == Class331.string_2;
					if (bASS_DEVICEINFO.get_IsEnabled())
					{
						if (flag && !bASS_DEVICEINFO.get_IsDefault() && string.IsNullOrEmpty(Class341.class605_12.Value))
						{
							Class331.smethod_104(null);
						}
						num++;
					}
					else if (flag)
					{
						Class331.smethod_104(Class341.class605_12.Value);
					}
				}
			}
			if (Class331.int_19 != num)
			{
				if (Class331.int_19 > 0)
				{
					Class331.smethod_104(Class341.class605_12.Value);
					if (num > Class331.int_19)
					{
						Class723.smethod_5(Class41.GetString(OsuString.AudioEngine_NewDeviceDetected), Color.get_YellowGreen(), 5000, null);
					}
				}
				Class331.int_19 = num;
			}
		}

		// Token: 0x060018FB RID: 6395
		// RVA: 0x00015474 File Offset: 0x00013674
		[CompilerGenerated]
		private static void smethod_106(Class339 class339_0)
		{
			class339_0.method_4();
		}

		// Token: 0x060018FC RID: 6396
		// RVA: 0x0001547C File Offset: 0x0001367C
		[CompilerGenerated]
		private static bool smethod_107(Class339 class339_0)
		{
			return class339_0.bool_1;
		}

		// Token: 0x060018FD RID: 6397
		// RVA: 0x00015484 File Offset: 0x00013684
		[CompilerGenerated]
		private static bool smethod_108(BASS_DEVICEINFO bass_DEVICEINFO_0)
		{
			return bass_DEVICEINFO_0.get_IsDefault();
		}

		// Token: 0x0600189B RID: 6299
		// RVA: 0x0001508A File Offset: 0x0001328A
		internal static double smethod_11()
		{
			if (Class331.smethod_8() > 0.0)
			{
				return 1000.0 / Class331.smethod_8() * 60.0;
			}
			return 0.0;
		}

		// Token: 0x0600189C RID: 6300
		// RVA: 0x00075E94 File Offset: 0x00074094
		internal static double smethod_12()
		{
			List<Class340> list = Class331.smethod_14();
			if (list == null || list.Count == 0)
			{
				return 0.0;
			}
			int count = list.Count;
			if (count != 0 && Class331.int_1 >= 0 && Class331.int_1 < count)
			{
				return list[Class331.int_1].double_1;
			}
			return 0.0;
		}

		// Token: 0x0600189D RID: 6301
		// RVA: 0x00075EF0 File Offset: 0x000740F0
		internal static void smethod_13(double double_4)
		{
			List<Class340> list = Class331.smethod_14();
			if (list == null)
			{
				return;
			}
			if (list.Count > 0)
			{
				if (Class331.int_1 >= 0)
				{
					list[Class331.int_1].double_1 = double_4;
				}
				else
				{
					list[0].double_1 = double_4;
				}
			}
			else
			{
				list.Add(new Class340(double_4, 0.0));
			}
			list.Sort();
		}

		// Token: 0x0600189E RID: 6302
		// RVA: 0x000150BF File Offset: 0x000132BF
		internal static List<Class340> smethod_14()
		{
			if (Class331.smethod_32() == null)
			{
				return null;
			}
			return Class331.smethod_32().list_1;
		}

		// Token: 0x0600189F RID: 6303
		// RVA: 0x000150D4 File Offset: 0x000132D4
		internal static void smethod_15(List<Class340> list_3)
		{
			Class331.smethod_32().list_1 = list_3;
			Class331.int_1 = 0;
			Class331.int_2 = 0;
		}

		// Token: 0x060018A0 RID: 6304
		// RVA: 0x000150ED File Offset: 0x000132ED
		internal static List<Class340> smethod_16()
		{
			if (Class331.smethod_32() == null)
			{
				return null;
			}
			return Class331.smethod_32().method_7();
		}

		// Token: 0x060018A1 RID: 6305
		// RVA: 0x00075F58 File Offset: 0x00074158
		internal static bool smethod_17()
		{
			List<Class340> list = Class331.smethod_14();
			return list != null && (Class331.int_1 < list.Count && Class331.int_1 >= 0) && Class331.smethod_8() > 0.0;
		}

		// Token: 0x060018A2 RID: 6306
		// RVA: 0x00075F98 File Offset: 0x00074198
		internal static Enum37 smethod_18()
		{
			List<Class340> list = Class331.smethod_14();
			if (list != null && list.Count > 0 && Class331.int_1 >= 0)
			{
				return list[Class331.int_1].enum37_0;
			}
			return Enum37.const_0;
		}

		// Token: 0x060018A3 RID: 6307
		// RVA: 0x00075FD4 File Offset: 0x000741D4
		internal static void smethod_19(Enum37 enum37_0)
		{
			List<Class340> list = Class331.smethod_14();
			if (list != null && list.Count > 0)
			{
				if (Class331.int_1 >= 0)
				{
					list[Class331.int_1].enum37_0 = enum37_0;
				}
				return;
			}
		}

		// Token: 0x06001892 RID: 6290
		// RVA: 0x00075A3C File Offset: 0x00073C3C
		internal static void smethod_2(VoidDelegate voidDelegate_3)
		{
			VoidDelegate voidDelegate = Class331.voidDelegate_0;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Combine(voidDelegate2, voidDelegate_3);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref Class331.voidDelegate_0, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x060018A4 RID: 6308
		// RVA: 0x00076010 File Offset: 0x00074210
		internal static double smethod_20(double double_4)
		{
			Class296 class = Class331.smethod_32();
			if (class != null)
			{
				return class.method_34(double_4);
			}
			return 0.0;
		}

		// Token: 0x060018A5 RID: 6309
		// RVA: 0x00076038 File Offset: 0x00074238
		internal static double smethod_21(double double_4)
		{
			Class296 class = Class331.smethod_32();
			if (class != null)
			{
				return class.method_35(double_4);
			}
			return 0.0;
		}

		// Token: 0x060018A6 RID: 6310
		// RVA: 0x00076060 File Offset: 0x00074260
		internal static double smethod_22(double double_4, bool bool_9)
		{
			Class296 class = Class331.smethod_32();
			if (class != null)
			{
				return class.method_36(double_4, bool_9);
			}
			return 0.0;
		}

		// Token: 0x060018A7 RID: 6311
		// RVA: 0x00076088 File Offset: 0x00074288
		internal static int smethod_23(double double_4, bool bool_9)
		{
			Class296 class = Class331.smethod_32();
			if (class != null)
			{
				return class.method_38(double_4, bool_9);
			}
			return -1;
		}

		// Token: 0x060018A8 RID: 6312
		// RVA: 0x000760A8 File Offset: 0x000742A8
		internal static Class340 smethod_24(double double_4)
		{
			Class296 class = Class331.smethod_32();
			if (class != null)
			{
				return class.method_39(double_4);
			}
			return null;
		}

		// Token: 0x060018A9 RID: 6313
		// RVA: 0x00015102 File Offset: 0x00013302
		internal static Class340 smethod_25(double double_4, List<Class340> list_3)
		{
			return Class296.smethod_1(double_4, list_3);
		}

		// Token: 0x060018AA RID: 6314
		// RVA: 0x000760C8 File Offset: 0x000742C8
		private static void smethod_26(Class340 class340_0)
		{
			Class331.Delegate31 delegate = Class331.delegate31_0;
			if (delegate != null)
			{
				delegate(class340_0);
			}
		}

		// Token: 0x060018AB RID: 6315
		// RVA: 0x000760E8 File Offset: 0x000742E8
		internal static void smethod_27(Class331.Delegate31 delegate31_2)
		{
			Class331.Delegate31 delegate = Class331.delegate31_1;
			Class331.Delegate31 delegate2;
			do
			{
				delegate2 = delegate;
				Class331.Delegate31 value = (Class331.Delegate31)Delegate.Combine(delegate2, delegate31_2);
				delegate = Interlocked.CompareExchange<Class331.Delegate31>(ref Class331.delegate31_1, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x060018AC RID: 6316
		// RVA: 0x0007611C File Offset: 0x0007431C
		internal static void smethod_28(Class331.Delegate31 delegate31_2)
		{
			Class331.Delegate31 delegate = Class331.delegate31_1;
			Class331.Delegate31 delegate2;
			do
			{
				delegate2 = delegate;
				Class331.Delegate31 value = (Class331.Delegate31)Delegate.Remove(delegate2, delegate31_2);
				delegate = Interlocked.CompareExchange<Class331.Delegate31>(ref Class331.delegate31_1, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x060018AD RID: 6317
		// RVA: 0x00076150 File Offset: 0x00074350
		private static void smethod_29(Class340 class340_0)
		{
			Class331.Delegate31 delegate = Class331.delegate31_1;
			if (delegate != null)
			{
				delegate(class340_0);
			}
		}

		// Token: 0x06001893 RID: 6291
		// RVA: 0x00075A70 File Offset: 0x00073C70
		internal static void smethod_3(VoidDelegate voidDelegate_3)
		{
			VoidDelegate voidDelegate = Class331.voidDelegate_0;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Remove(voidDelegate2, voidDelegate_3);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref Class331.voidDelegate_0, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x060018AE RID: 6318
		// RVA: 0x0001510B File Offset: 0x0001330B
		internal static bool smethod_30()
		{
			return 1 == Bass.BASS_ChannelIsActive(Class331.int_5) || 1 == Bass.BASS_ChannelIsActive(Class331.int_4);
		}

		// Token: 0x060018AF RID: 6319
		// RVA: 0x00015129 File Offset: 0x00013329
		internal static int smethod_31()
		{
			if (Class331.class335_0 != null)
			{
				return (int)Class331.class335_0.double_0;
			}
			return 0;
		}

		// Token: 0x060018B0 RID: 6320
		// RVA: 0x0001513F File Offset: 0x0001333F
		internal static Class296 smethod_32()
		{
			if (Class331.class335_0 != null)
			{
				return Class331.class335_0.class296_0;
			}
			return null;
		}

		// Token: 0x060018B1 RID: 6321
		// RVA: 0x00015154 File Offset: 0x00013354
		internal static void smethod_33(Class296 class296_0)
		{
			Class331.class335_0.class296_0 = class296_0;
		}

		// Token: 0x060018B2 RID: 6322
		// RVA: 0x00015161 File Offset: 0x00013361
		private static void smethod_34(object sender, EventArgs e)
		{
			Class331.smethod_89(Class331.int_11, false);
		}

		// Token: 0x060018B3 RID: 6323
		// RVA: 0x00076170 File Offset: 0x00074370
		private static void smethod_35(object sender, EventArgs e)
		{
			float num = Class331.smethod_78() / 100f * (float)Class331.smethod_81() / 100f;
			Bass.BASS_ChannelSetAttribute(Class331.int_4, 2, num);
			Bass.BASS_ChannelSetAttribute(Class331.int_5, 2, num);
			Bass.BASS_ChannelSetAttribute(Class331.int_6, 2, num);
			lock (Class331.list_0)
			{
				List<Class339> arg_6E_0 = Class331.list_0;
				if (Class331.action_0 == null)
				{
					Class331.action_0 = new Action<Class339>(Class331.smethod_106);
				}
				arg_6E_0.ForEach(Class331.action_0);
			}
		}

		// Token: 0x060018B4 RID: 6324
		// RVA: 0x0007620C File Offset: 0x0007440C
		internal static void smethod_36(int? nullable_0, string string_3, float float_4, bool bool_9)
		{
			if (!Class114.bool_0)
			{
				return;
			}
			if (!nullable_0.HasValue)
			{
				nullable_0 = new int?(100);
			}
			if (Class115.int_1 - Class331.int_16 > 50 || bool_9)
			{
				Class331.int_16 = Class115.int_1;
				Class331.smethod_60(string_3, float_4, Enum112.flag_5);
			}
		}

		// Token: 0x060018B5 RID: 6325
		// RVA: 0x00076258 File Offset: 0x00074458
		internal static int smethod_37(string string_3, bool bool_9, bool bool_10, Enum112 enum112_0)
		{
			if (Class115.bool_16 && !Class115.bool_17 && Class115.int_2 != 0)
			{
				return -1;
			}
			BASSFlag bASSFlag = 131072;
			if (bool_9)
			{
				bASSFlag |= 4;
			}
			string text = string_3;
			if (!bool_10)
			{
				string text2 = Class331.sampleSet_0.ToString().ToLower() + "-";
				if (Class115.osuModes_1 == OsuModes.Play && Class62.Mode == PlayModes.Taiko)
				{
					text2 = "taiko-" + text2;
					if (Class466.Current != null && Class466.Current.method_5() != PlayModes.Taiko)
					{
						enum112_0 &= ~Enum112.flag_3;
					}
				}
				text = text2 + text;
			}
			int num = -1;
			if ((enum112_0 & Enum112.flag_3) > Enum112.flag_0 && !Class331.bool_3 && (bool_10 || (!bool_10 && Class331.enum38_0 != Enum38.const_0)) && Class466.Current != null)
			{
				int num2 = (int)Class331.enum38_0;
				string text3 = text + ((bool_10 || num2 <= 1) ? string.Empty : num2.ToString());
				if (!Class331.dictionary_0.TryGetValue(text3, out num))
				{
					num = -1;
					for (int i = 0; i < 3; i++)
					{
						string str;
						if (i == 0)
						{
							str = ".wav";
						}
						else if (i == 1)
						{
							str = ".mp3";
						}
						else
						{
							str = ".ogg";
						}
						byte[] array = Class466.Current.method_63(text3 + str) ?? ((Class466.Current.int_6 < 5) ? Class466.Current.method_63(string_3 + str) : null);
						if (array != null)
						{
							if (array.Length >= 1024)
							{
								if ((num = Bass.BASS_SampleLoad(array, 0L, array.Length, 8, bASSFlag)) == -1)
								{
									goto IL_181;
								}
							}
							else
							{
								num = Bass.BASS_SampleCreate(0, 44100, 2, 8, bASSFlag);
							}
							IL_1A0:
							Class331.dictionary_0[text3] = num;
							goto IL_1AD;
						}
						IL_181:;
					}
					goto IL_1A0;
				}
			}
			IL_1AD:
			if (num != -1)
			{
				return num;
			}
			if ((enum112_0 & Enum112.flag_2) > Enum112.flag_0 && !Class885.smethod_24() && Class341.class606_59 && !Class331.dictionary_2.TryGetValue(text, out num))
			{
				num = -1;
				for (int j = 0; j < 3; j++)
				{
					string arg;
					if (j == 0)
					{
						arg = "wav";
					}
					else if (j == 1)
					{
						arg = "mp3";
					}
					else
					{
						arg = "ogg";
					}
					string text4 = string.Format("Skins/{0}/{1}.{2}", Class885.class547_0.string_2, text, arg);
					if (File.Exists(text4) && (num = Bass.BASS_SampleLoad(text4, 0L, 0, 8, bASSFlag)) != -1)
					{
						break;
					}
				}
				Class331.dictionary_2[text] = num;
			}
			if (num != -1)
			{
				return num;
			}
			if ((enum112_0 & Enum112.flag_1) == Enum112.flag_0)
			{
				return -1;
			}
			if (Class331.dictionary_1.TryGetValue(text, out num))
			{
				return num;
			}
			byte[] array2 = ResourcesStore.get_ResourceManager().GetObject(text) as byte[];
			if (array2 == null)
			{
				array2 = (ResourcesStore.get_ResourceManager().GetObject(text) as byte[]);
			}
			if (array2 == null)
			{
				array2 = (ResourcesStore.get_ResourceManager().GetObject(text) as byte[]);
			}
			if (array2 == null)
			{
				Class331.dictionary_1[text] = -1;
				return -1;
			}
			return Class331.dictionary_1[text] = (num = Bass.BASS_SampleLoad(array2, 0L, array2.Length, 5, bASSFlag));
		}

		// Token: 0x060018B6 RID: 6326
		// RVA: 0x0007655C File Offset: 0x0007475C
		internal static int smethod_38(string string_3, bool bool_9, bool bool_10, bool bool_11)
		{
			BASSFlag bASSFlag = 131072;
			if (bool_9)
			{
				bASSFlag |= 4;
			}
			int num = -1;
			string text = string_3;
			string str = string.Empty;
			bool flag = false;
			if (string_3.IndexOf('.') > 0)
			{
				text = string_3.Substring(0, string_3.LastIndexOf('.'));
			}
			else
			{
				flag = true;
			}
			if (bool_10 && text.Contains("slider"))
			{
				bASSFlag &= -5;
				str = "$slider$";
			}
			if (Class331.dictionary_0.TryGetValue(str + text, out num) && !bool_11)
			{
				return num;
			}
			byte[] array = null;
			if (!flag && Class466.Current.method_68(string_3))
			{
				array = (Class466.Current.method_63(string_3) ?? ((Class466.Current.int_6 < 5) ? Class466.Current.method_63(string_3) : null));
			}
			else
			{
				string str2 = ".wav";
				for (int i = 0; i < 3; i++)
				{
					if (i == 1)
					{
						str2 = ".ogg";
					}
					else if (i == 2)
					{
						str2 = ".mp3";
					}
					array = (Class466.Current.method_63(text + str2) ?? ((Class466.Current.int_6 < 5) ? Class466.Current.method_63(string_3 + str2) : null));
					if (array != null)
					{
						break;
					}
				}
			}
			if (array != null)
			{
				if (array.Length < 1024)
				{
					num = Bass.BASS_SampleCreate(0, 44100, 2, 8, bASSFlag);
				}
				else
				{
					num = Bass.BASS_SampleLoad(array, 0L, array.Length, 8, bASSFlag);
				}
			}
			string key = str + text;
			int num2 = -1;
			if (Class331.dictionary_0.TryGetValue(key, out num2) && num2 != -1)
			{
				Bass.BASS_SampleFree(num2);
			}
			Class331.dictionary_0[key] = num;
			return num;
		}

		// Token: 0x060018B7 RID: 6327
		// RVA: 0x000766F8 File Offset: 0x000748F8
		internal static void smethod_39(string string_3)
		{
			int num = -1;
			if (Class331.dictionary_0.TryGetValue(string_3, out num))
			{
				if (num != -1)
				{
					Bass.BASS_SampleFree(num);
				}
				Class331.dictionary_0.Remove(string_3);
			}
		}

		// Token: 0x06001894 RID: 6292
		// RVA: 0x00075AA4 File Offset: 0x00073CA4
		private static void smethod_4()
		{
			double num = Class331.smethod_8();
			double num2 = Class331.smethod_0() % num;
			Class331.double_0 = num2 / num;
			int num3 = (int)(Class331.smethod_0() / num) + (((double)Class331.int_7 < Class331.smethod_12()) ? -1 : 0);
			if (num3 != Class331.int_0)
			{
				Class331.bool_0 = true;
				if (Class331.voidDelegate_0 != null)
				{
					Class331.voidDelegate_0();
				}
				Class331.int_0 = num3;
				return;
			}
			Class331.bool_0 = false;
		}

		// Token: 0x060018B8 RID: 6328
		// RVA: 0x00076730 File Offset: 0x00074930
		internal static List<string> smethod_40()
		{
			List<string> list = new List<string>(Class331.dictionary_0.Count);
			string[] files = Directory.GetFiles(Class466.Current.method_3());
			string[] array = files;
			for (int i = 0; i < array.Length; i++)
			{
				string path = array[i];
				string fileName = Path.GetFileName(path);
				string extension;
				if ((extension = Path.GetExtension(path)) != null && (extension == ".wav" || extension == ".ogg" || extension == ".mp3"))
				{
					list.Add(fileName);
				}
			}
			return list;
		}

		// Token: 0x060018B9 RID: 6329
		// RVA: 0x000767C0 File Offset: 0x000749C0
		internal static void smethod_41(Enum38 enum38_3)
		{
			Class331.enum38_0 = enum38_3;
			SampleSet[] array = Class331.sampleSet_3;
			for (int i = 0; i < array.Length; i++)
			{
				SampleSet sampleSet = array[i];
				Class331.sampleSet_0 = sampleSet;
				Class331.smethod_37("hitnormal", false, false, Enum112.flag_6);
				Class331.smethod_37("hitfinish", false, false, Enum112.flag_6);
				Class331.smethod_37("hitwhistle", false, false, Enum112.flag_6);
				Class331.smethod_37("hitclap", false, false, Enum112.flag_6);
				Class331.smethod_37("sliderslide", true, false, Enum112.flag_6);
				Class331.smethod_37("sliderwhistle", true, false, Enum112.flag_6);
				Class331.smethod_37("slidertick", false, false, Enum112.flag_6);
			}
		}

		// Token: 0x060018BA RID: 6330
		// RVA: 0x00076854 File Offset: 0x00074A54
		internal static void smethod_42()
		{
			SampleSet sampleSet = Class331.sampleSet_0;
			Enum38[] array = new Enum38[]
			{
				Enum38.const_0,
				Enum38.const_1,
				Enum38.const_2
			};
			Enum38[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				Enum38 enum = array2[i];
				Class331.enum38_0 = enum;
				int num = 0;
				SampleSet[] array3 = Class331.sampleSet_3;
				for (int j = 0; j < array3.Length; j++)
				{
					SampleSet sampleSet2 = array3[j];
					Class331.sampleSet_0 = sampleSet2;
					Class331.int_13[0, num, (int)enum] = Class331.smethod_37("hitnormal", false, false, Enum112.flag_6);
					Class331.int_13[2, num, (int)enum] = Class331.smethod_37("hitfinish", false, false, Enum112.flag_6);
					Class331.int_13[1, num, (int)enum] = Class331.smethod_37("hitwhistle", false, false, Enum112.flag_6);
					Class331.int_13[3, num, (int)enum] = Class331.smethod_37("hitclap", false, false, Enum112.flag_6);
					Class331.int_14[0, num, (int)enum] = Class331.smethod_37("slidertick", false, false, Enum112.flag_6);
					Class331.int_15[0, num, (int)enum] = Class331.smethod_37("sliderslide", true, false, Enum112.flag_6);
					Class331.int_15[1, num, (int)enum] = Class331.smethod_37("sliderwhistle", true, false, Enum112.flag_6);
					num++;
				}
			}
			Class331.sampleSet_0 = SampleSet.Soft;
			Class331.enum38_0 = Enum38.const_1;
			Class331.smethod_37("failsound", false, true, Enum112.flag_6);
			Class331.smethod_37("spinnerspin", true, true, Enum112.flag_6);
			Class331.smethod_37("spinnerbonus", false, true, Enum112.flag_6);
			Class331.smethod_37("spinner-osu", false, true, Enum112.flag_6);
			Class331.smethod_37("sectionpass", false, true, Enum112.flag_6);
			Class331.smethod_37("sectionfail", false, true, Enum112.flag_6);
			Class331.smethod_37("readys", false, true, Enum112.flag_6);
			Class331.smethod_37("count3s", false, true, Enum112.flag_6);
			Class331.smethod_37("count2s", false, true, Enum112.flag_6);
			Class331.smethod_37("count1s", false, true, Enum112.flag_6);
			Class331.smethod_37("gos", false, true, Enum112.flag_6);
			Class331.smethod_37("combobreak", false, true, Enum112.flag_6);
			int num2 = 0;
			while (Class331.smethod_37("comboburst-" + num2, false, true, Enum112.flag_6) != -1)
			{
				num2++;
			}
			if (num2 == 0)
			{
				Class331.smethod_37("comboburst", false, true, Enum112.flag_6);
			}
			Class331.smethod_37("applause", false, true, Enum112.flag_6);
			Class331.enum38_0 = Enum38.const_0;
			Class331.enum38_1 = Class331.enum38_0;
			Class331.smethod_43();
			Class331.sampleSet_0 = sampleSet;
		}

		// Token: 0x060018BB RID: 6331
		// RVA: 0x00076AA8 File Offset: 0x00074CA8
		internal static void smethod_43()
		{
			Class331.smethod_37("menuback", false, true, Enum112.flag_5);
			Class331.smethod_37("menuhit", false, true, Enum112.flag_5);
			Class331.smethod_37("menuclick", false, true, Enum112.flag_5);
			Class331.smethod_37("metronomehigh", false, true, Enum112.flag_5);
			Class331.smethod_37("metronomelow", false, true, Enum112.flag_5);
		}

		// Token: 0x060018BC RID: 6332
		// RVA: 0x0001516E File Offset: 0x0001336E
		internal static void smethod_44()
		{
			Class331.smethod_45(Class331.dictionary_2);
			Class331.smethod_45(Class331.dictionary_0);
			Class331.smethod_45(Class331.dictionary_1);
		}

		// Token: 0x060018BD RID: 6333
		// RVA: 0x00076AFC File Offset: 0x00074CFC
		private static void smethod_45(Dictionary<string, int> dictionary_5)
		{
			foreach (int current in dictionary_5.Values)
			{
				Bass.BASS_SampleFree(current);
			}
			dictionary_5.Clear();
		}

		// Token: 0x060018BE RID: 6334
		// RVA: 0x0001518E File Offset: 0x0001338E
		internal static void smethod_46()
		{
			Class331.smethod_45(Class331.dictionary_0);
		}

		// Token: 0x060018BF RID: 6335
		// RVA: 0x0001519A File Offset: 0x0001339A
		internal static void smethod_47()
		{
			Class331.smethod_45(Class331.dictionary_2);
		}

		// Token: 0x060018C0 RID: 6336
		// RVA: 0x00076B58 File Offset: 0x00074D58
		internal static void smethod_48(SampleSet sampleSet_4, bool bool_9)
		{
			if (!bool_9 && ((sampleSet_4 == Class331.sampleSet_0 && Class331.smethod_74() == Class331.enum38_0) || (Class115.osuModes_1 != OsuModes.Play && Class115.osuModes_1 != OsuModes.Edit && Class115.osuModes_1 != OsuModes.SkinSelect)))
			{
				return;
			}
			if (sampleSet_4 == SampleSet.None)
			{
				sampleSet_4 = SampleSet.Normal;
			}
			Class331.sampleSet_0 = sampleSet_4;
			Class331.enum38_0 = Class331.smethod_74();
			Class331.smethod_37("hitnormal", false, false, Enum112.flag_6);
			Class331.smethod_37("hitfinish", false, false, Enum112.flag_6);
			Class331.smethod_37("hitwhistle", false, false, Enum112.flag_6);
			Class331.smethod_37("hitclap", false, false, Enum112.flag_6);
			Class331.smethod_37("slidertick", false, false, Enum112.flag_6);
			if (Class331.int_6 != 0 && 1 == Bass.BASS_ChannelIsActive(Class331.int_6))
			{
				Bass.BASS_ChannelStop(Class331.int_6);
			}
			Class331.int_6 = Bass.BASS_SampleGetChannel(Class331.smethod_37("spinnerspin", true, true, Enum112.flag_6), false);
			float num = Class331.smethod_78() / 100f * (float)Class331.smethod_81() / 100f;
			Bass.BASS_ChannelSetAttribute(Class331.int_6, 2, num);
			if (bool_9 || Class331.sampleSet_1 == SampleSet.None)
			{
				Class331.smethod_49(sampleSet_4, sampleSet_4, bool_9);
			}
		}

		// Token: 0x060018C1 RID: 6337
		// RVA: 0x00076C60 File Offset: 0x00074E60
		internal static void smethod_49(SampleSet sampleSet_4, SampleSet sampleSet_5, bool bool_9)
		{
			if (sampleSet_4 == SampleSet.None)
			{
				sampleSet_4 = Class331.sampleSet_0;
			}
			if (sampleSet_5 == SampleSet.None)
			{
				sampleSet_5 = sampleSet_4;
			}
			bool flag = Class331.enum38_0 != Class331.enum38_1 || sampleSet_4 != Class331.sampleSet_1;
			bool flag2 = Class331.enum38_0 != Class331.enum38_1 || sampleSet_5 != Class331.sampleSet_2;
			if (!bool_9 && ((!flag && !flag2) || (Class115.osuModes_1 != OsuModes.Play && Class115.osuModes_1 != OsuModes.Edit && Class115.osuModes_1 != OsuModes.SkinSelect)))
			{
				return;
			}
			Class331.enum38_1 = Class331.enum38_0;
			if (flag)
			{
				if (Class331.int_4 != 0 && 1 == Bass.BASS_ChannelIsActive(Class331.int_4))
				{
					Bass.BASS_ChannelStop(Class331.int_4);
				}
				Class331.sampleSet_1 = sampleSet_4;
				Class331.int_4 = Bass.BASS_SampleGetChannel(Class331.smethod_66(HitObjectSoundType.Normal, Class331.sampleSet_1, Class331.enum38_0, Enum101.const_2), false);
			}
			if (flag2)
			{
				if (Class331.int_5 != 0 && 1 == Bass.BASS_ChannelIsActive(Class331.int_5))
				{
					Bass.BASS_ChannelStop(Class331.int_5);
				}
				Class331.sampleSet_2 = sampleSet_5;
				Class331.int_5 = Bass.BASS_SampleGetChannel(Class331.smethod_66(HitObjectSoundType.Whistle, Class331.sampleSet_2, Class331.enum38_0, Enum101.const_2), false);
			}
			float num = Class331.smethod_78() / 100f * (float)Class331.smethod_81() / 100f;
			Bass.BASS_ChannelSetAttribute(Class331.int_4, 2, num);
			Bass.BASS_ChannelSetAttribute(Class331.int_5, 2, num);
		}

		// Token: 0x06001895 RID: 6293
		// RVA: 0x0001507C File Offset: 0x0001327C
		internal static void smethod_5()
		{
			Class331.int_1 = -1;
			Class331.int_2 = -1;
		}

		// Token: 0x060018C3 RID: 6339
		// RVA: 0x000151A6 File Offset: 0x000133A6
		internal static bool smethod_50()
		{
			return Class331.bool_7;
		}

		// Token: 0x060018C4 RID: 6340
		// RVA: 0x00076E5C File Offset: 0x0007505C
		internal static void smethod_51(bool bool_9)
		{
			Class331.bool_7 = bool_9;
			if (!Class331.bool_7 && Class331.bool_4)
			{
				if (Class331.int_7 < 0)
				{
					Class331.smethod_101();
					Class331.smethod_70(0, false, false);
					return;
				}
				if (Class331.int_7 > Class331.smethod_31())
				{
					Class331.smethod_101();
					Class331.smethod_70(Class331.smethod_31(), false, false);
				}
			}
		}

		// Token: 0x060018C5 RID: 6341
		// RVA: 0x00076EB0 File Offset: 0x000750B0
		internal static void smethod_52()
		{
			if (Class331.class335_0 == null)
			{
				return;
			}
			Class331.class335_0.vmethod_9();
			if (Class331.smethod_50())
			{
				if (Class331.int_7 >= -Class331.int_12 && Class331.int_7 <= Class331.smethod_31())
				{
					if (Class331.bool_4)
					{
						Class331.bool_4 = false;
						Class331.bool_8 = false;
						Class331.int_3 = -1;
						if (Class331.enum100_0 == Enum100.const_1 && !Class331.class335_0.vmethod_8())
						{
							Class331.class335_0.Seek((double)(Class331.int_10 + Class331.int_12));
							Class331.class335_0.vmethod_6(true);
						}
					}
				}
				else if (!Class331.bool_4 && Class331.enum100_0 != Enum100.const_1)
				{
					Class331.bool_4 = true;
					Class331.class335_0.vmethod_7();
				}
			}
			if (!Class331.bool_4 && Class331.enum100_0 != Enum100.const_0 && (Class331.class335_0 == null || Class331.class335_0.Position == Class331.class335_0.double_0))
			{
				Class331.enum100_0 = Enum100.const_0;
			}
			double num = (double)Class331.smethod_67() / 100.0 * (double)(Class331.float_1 / Class331.float_0);
			double num2 = Class115.double_9 * num * (double)(Class331.smethod_71() ? -1 : 1);
			if (Class331.bool_4)
			{
				if (Class331.enum100_0 == Enum100.const_1 && num2 < 60.0)
				{
					Class331.double_2 += num2;
					Class331.double_1 += num2;
				}
			}
			else if (Class331.bool_8)
			{
				Class331.double_1 = (double)Class331.int_3;
				Class331.int_17 = Class115.int_1;
			}
			else if (Class331.class335_0 != null)
			{
				double position = Class331.class335_0.Position;
				bool flag;
				if (!(flag = (Class331.enum100_0 != Enum100.const_1 || Class331.double_1 == 0.0 || position == 0.0 || Class62.bool_6)))
				{
					double num3 = Class331.double_1 + num2;
					double num4 = num3 - position;
					num3 -= num4 / 8.0;
					num4 = num3 - position;
					double num5 = (double)((Class115.int_1 - Class331.int_17 < 1500 || Class331.smethod_67() < 100) ? 11 : 33);
					if (Math.Abs(num4) > num5 * 2.0)
					{
						flag = true;
						if (Class331.float_1 == Class331.float_0)
						{
						}
					}
					else if (num4 < -num5)
					{
						Class331.double_1 += num2 * 2.0;
						Class331.int_17 = Class115.int_1;
					}
					else if (num4 < num5)
					{
						Class331.double_1 = num3;
					}
					else
					{
						Class331.double_1 += num2 / 2.0;
						Class331.int_17 = Class115.int_1;
					}
				}
				if (flag)
				{
					Class331.double_1 = position;
					Class331.int_17 = Class115.int_1;
				}
			}
			else
			{
				Class331.double_1 = 0.0;
			}
			Class331.int_10 = (int)Math.Round(Class331.double_1);
			int arg_2CC_0;
			if (Class466.Current != null && Class466.Current.int_6 < 5)
			{
				if (Class115.osuModes_1 != OsuModes.Edit)
				{
					arg_2CC_0 = 24;
					goto IL_2CC;
				}
			}
			arg_2CC_0 = 0;
			IL_2CC:
			Class331.int_12 = arg_2CC_0;
			Class331.int_12 += ((Class115.osuModes_1 == OsuModes.Edit || Class466.Current == null) ? 0 : (Class466.Current.int_13 + Class466.Current.int_12));
			if (Class331.smethod_67() < 100)
			{
				Class331.int_12 -= (int)((float)(100 - Class331.smethod_67()) / 75f * 5f);
			}
			Class331.int_12 -= (int)((float)Class331.smethod_67() / 100f * (float)Class341.class608_9);
			if (!Class331.bool_8 && (Class331.enum100_0 != Enum100.const_0 || Class331.int_7 != 0))
			{
				Class331.int_7 = Class331.int_10 - Class331.int_12;
			}
			else
			{
				Class331.int_7 = Class331.int_10;
			}
			Class331.int_8 = Class331.int_7;
		}

		// Token: 0x060018C6 RID: 6342
		// RVA: 0x0007724C File Offset: 0x0007544C
		internal static void smethod_53()
		{
			if (Class115.bool_13 && (Class115.enum113_0 == Enum113.const_1 || Class115.enum113_0 == Enum113.const_2) && Class331.int_11 < 100 && (Class115.osuModes_1 != OsuModes.Rank || Class331.int_11 < 50))
			{
				Class331.smethod_89(Class331.int_11 + 2, false);
			}
			Class331.int_9 = Class331.int_7;
			Class331.smethod_52();
			if (Class331.enum100_0 == Enum100.const_2)
			{
				Class331.smethod_6(false);
				Class331.enum100_0 = Enum100.const_1;
			}
			Class331.smethod_54();
			if (Class115.osuModes_1 != OsuModes.BeatmapImport && (Class115.osuModes_1 != OsuModes.Play || Class62.bool_40))
			{
				Class331.float_2 = (float)((double)Class331.float_2 * 0.9 + (double)(Class331.int_7 - Class331.int_9) * 0.1);
				Class331.smethod_1();
				if (Class331.class335_0 == null || (!Class331.class335_0.vmethod_8() && !Class331.bool_4))
				{
					Class331.enum100_0 = Enum100.const_0;
				}
				Class331.smethod_55();
				Class331.double_3 = (double)(Class331.int_7 - Class331.int_9);
				Class331.bool_2 = (Class331.class335_0 != null && Class331.class335_0.bool_1);
				Class331.smethod_4();
				if (Class331.class88_0 != null)
				{
					Class331.class88_0.imethod_2();
				}
			}
			if (!Class331.bool_4 && Class331.smethod_71() && Class331.int_7 <= 0)
			{
				Class331.smethod_72(false);
				Class331.smethod_87();
			}
			if (Class115.bool_13)
			{
				Class789.smethod_0();
			}
		}

		// Token: 0x060018C7 RID: 6343
		// RVA: 0x000773A4 File Offset: 0x000755A4
		private static void smethod_54()
		{
			lock (Class331.list_0)
			{
				foreach (Class339 current in Class331.list_0)
				{
					if (current.method_13())
					{
						current.Dispose();
					}
				}
				List<Class339> arg_6B_0 = Class331.list_0;
				if (Class331.predicate_0 == null)
				{
					Class331.predicate_0 = new Predicate<Class339>(Class331.smethod_107);
				}
				arg_6B_0.RemoveAll(Class331.predicate_0);
			}
		}

		// Token: 0x060018C8 RID: 6344
		// RVA: 0x00077448 File Offset: 0x00075648
		private static void smethod_55()
		{
			if (Class331.enum100_0 != Enum100.const_1)
			{
				return;
			}
			int num = Class331.int_7;
			foreach (Class338 current in Class331.list_1)
			{
				if (current.int_1 <= num && current.int_1 > num - 400)
				{
					if (!current.bool_0)
					{
						current.class339_0 = Class331.smethod_61(current.int_0, current.int_2, 0f, true, 1f);
						current.bool_0 = true;
					}
				}
				else if (Class115.osuModes_1 == OsuModes.Edit)
				{
					current.bool_0 = false;
				}
			}
		}

		// Token: 0x060018C9 RID: 6345
		// RVA: 0x000151AD File Offset: 0x000133AD
		internal static void smethod_56(float float_4)
		{
			Bass.BASS_ChannelSetAttribute(Class331.int_6, 1, (float)Math.Min(100000, 20000 + (int)(40000f * float_4)));
		}

		// Token: 0x060018CA RID: 6346
		// RVA: 0x00077500 File Offset: 0x00075700
		internal static Class335 smethod_57(string string_3, bool bool_9)
		{
			byte[] array = ResourcesStore.get_ResourceManager().GetObject(string_3) as byte[];
			if (array == null)
			{
				array = (ResourcesStore.get_ResourceManager().GetObject(string_3) as byte[]);
			}
			if (array == null)
			{
				array = (ResourcesStore.get_ResourceManager().GetObject(string_3) as byte[]);
			}
			return Class331.smethod_58(array, false);
		}

		// Token: 0x060018CB RID: 6347
		// RVA: 0x00077550 File Offset: 0x00075750
		internal static Class335 smethod_58(byte[] byte_0, bool bool_9)
		{
			if (byte_0 == null)
			{
				return null;
			}
			MemoryStream stream_ = new MemoryStream(byte_0);
			Class335 class = new Class336(stream_, false, false);
			class.vmethod_1(Class331.smethod_77() / 100f);
			return class;
		}

		// Token: 0x060018CC RID: 6348
		// RVA: 0x00077584 File Offset: 0x00075784
		internal static Class339 smethod_59(string string_3, int int_20, Enum112 enum112_0)
		{
			Class339 class = new Class339(Class331.smethod_37(string_3, false, true, enum112_0));
			class.method_0((float)int_20 / 100f);
			Class339 class2 = class;
			lock (Class331.list_0)
			{
				Class331.list_0.Add(class2);
			}
			class2.method_10(true, false);
			return class2;
		}

		// Token: 0x06001896 RID: 6294
		// RVA: 0x00075B10 File Offset: 0x00073D10
		internal static void smethod_6(bool bool_9)
		{
			try
			{
				Predicate<Class340> predicate = null;
				Predicate<Class340> predicate2 = null;
				Class331.Class332 class = new Class331.Class332();
				List<Class340> list = Class331.smethod_14();
				class.int_0 = Class331.int_7 + 5;
				if (list != null && list.Count > 0)
				{
					if (bool_9)
					{
						list.Sort();
					}
					if (!bool_9 && Class331.int_1 >= 0)
					{
						if (Class331.enum100_0 == Enum100.const_1)
						{
							int count = list.Count;
							for (int i = Class331.int_2 + 1; i < count; i++)
							{
								Class340 class2 = list[i];
								if (class2.double_1 > (double)class.int_0)
								{
									break;
								}
								Class331.int_2 = i;
								Class331.smethod_29(class2);
								if (class2.method_0())
								{
									Class331.int_1 = i;
									Class331.smethod_26(class2);
								}
							}
							goto IL_170;
						}
					}
					int num = Class331.int_1;
					int num2 = Class331.int_2;
					List<Class340> arg_D8_0 = list;
					if (predicate == null)
					{
						predicate = new Predicate<Class340>(class.method_0);
					}
					Class331.int_1 = arg_D8_0.FindLastIndex(predicate);
					if (Class331.int_1 < 0)
					{
						Class331.int_1 = 0;
					}
					List<Class340> arg_106_0 = list;
					if (predicate2 == null)
					{
						predicate2 = new Predicate<Class340>(class.method_1);
					}
					Class331.int_2 = arg_106_0.FindLastIndex(predicate2);
					if (Class331.int_2 < 0)
					{
						Class331.int_2 = 0;
					}
					if (num != Class331.int_1)
					{
						Class331.smethod_26(list[Class331.int_1]);
					}
					if (num2 != Class331.int_2)
					{
						Class331.smethod_29(list[Class331.int_2]);
						Class331.int_0 = -999;
					}
				}
				else
				{
					Class331.int_1 = -1;
					Class331.int_2 = -1;
					Class331.int_0 = -999;
				}
				IL_170:;
			}
			catch
			{
				Class331.int_1 = -1;
				Class331.int_2 = -1;
				Class331.int_0 = -999;
			}
		}

		// Token: 0x060018CD RID: 6349
		// RVA: 0x000775EC File Offset: 0x000757EC
		internal static Class339 smethod_60(string string_3, float float_4, Enum112 enum112_0)
		{
			Class339 class = new Class339(Class331.smethod_37(string_3, false, true, enum112_0));
			class.method_2(0.4f);
			class.method_3(float_4);
			Class339 class2 = class;
			lock (Class331.list_0)
			{
				Class331.list_0.Add(class2);
			}
			class2.method_10(true, false);
			return class2;
		}

		// Token: 0x060018CE RID: 6350
		// RVA: 0x00077658 File Offset: 0x00075858
		internal static Class339 smethod_61(int int_20, int int_21, float float_4, bool bool_9, float float_5)
		{
			if (int_20 == -1)
			{
				return null;
			}
			if (bool_9 && Class331.class335_0.vmethod_10() != 100.0 && Class331.class335_0.vmethod_14())
			{
				float_5 = 1f + ((float)Class331.class335_0.vmethod_10() - 100f) / 100f;
			}
			Class339 class = new Class339(int_20);
			class.method_8(int_20);
			class.method_0((float)int_21 / 100f);
			class.method_1(float_4);
			class.method_3(float_5);
			Class339 class2 = class;
			lock (Class331.list_0)
			{
				Class331.list_0.Add(class2);
			}
			class2.method_10(true, false);
			return class2;
		}

		// Token: 0x060018CF RID: 6351
		// RVA: 0x00077714 File Offset: 0x00075914
		internal static void smethod_62(Struct69 struct69_0, float float_4, bool bool_9)
		{
			int num = bool_9 ? Math.Max(8, struct69_0.int_0) : struct69_0.int_0;
			SampleSet sampleSet_ = (struct69_0.sampleSet_1 == SampleSet.None) ? struct69_0.sampleSet_0 : struct69_0.sampleSet_1;
			if (struct69_0.hitObjectSoundType_0.IsType(HitObjectSoundType.Normal))
			{
				Class331.smethod_61(Class331.smethod_66(HitObjectSoundType.Normal, struct69_0.sampleSet_0, struct69_0.enum38_0, Enum101.const_0), (int)((double)num * 0.8), float_4, true, 1f);
			}
			if (struct69_0.hitObjectSoundType_0.IsType(HitObjectSoundType.Finish))
			{
				Class331.smethod_61(Class331.smethod_66(HitObjectSoundType.Finish, sampleSet_, struct69_0.enum38_0, Enum101.const_0), num, float_4, true, 1f);
			}
			if (struct69_0.hitObjectSoundType_0.IsType(HitObjectSoundType.Whistle))
			{
				Class331.smethod_61(Class331.smethod_66(HitObjectSoundType.Whistle, sampleSet_, struct69_0.enum38_0, Enum101.const_0), (int)((double)num * 0.85), float_4, true, 1f);
			}
			if (struct69_0.hitObjectSoundType_0.IsType(HitObjectSoundType.Clap))
			{
				Class331.smethod_61(Class331.smethod_66(HitObjectSoundType.Clap, sampleSet_, struct69_0.enum38_0, Enum101.const_0), (int)((double)num * 0.85), float_4, true, 1f);
			}
		}

		// Token: 0x060018D0 RID: 6352
		// RVA: 0x00077830 File Offset: 0x00075A30
		internal static void smethod_63(HitObjectSoundType hitObjectSoundType_0, SampleSet sampleSet_4, SampleSet sampleSet_5, bool bool_9, float? nullable_0)
		{
			Class331.smethod_49(sampleSet_4, sampleSet_5, false);
			if ((bool_9 || !hitObjectSoundType_0.IsType(HitObjectSoundType.Whistle)) && 1 != Bass.BASS_ChannelIsActive(Class331.int_4))
			{
				Bass.BASS_ChannelSetAttribute(Class331.int_4, 2, (float)Class331.smethod_80() / 100f);
				Bass.BASS_ChannelPlay(Class331.int_4, true);
			}
			if (hitObjectSoundType_0.IsType(HitObjectSoundType.Whistle) && 1 != Bass.BASS_ChannelIsActive(Class331.int_5))
			{
				Bass.BASS_ChannelSetAttribute(Class331.int_5, 2, (float)Class331.smethod_80() / 100f);
				Bass.BASS_ChannelPlay(Class331.int_5, true);
			}
			if (nullable_0.HasValue)
			{
				Bass.BASS_ChannelSetAttribute(Class331.int_4, 3, nullable_0.Value);
				Bass.BASS_ChannelSetAttribute(Class331.int_5, 3, nullable_0.Value);
			}
		}

		// Token: 0x060018D1 RID: 6353
		// RVA: 0x000151D4 File Offset: 0x000133D4
		internal static void smethod_64(float? nullable_0)
		{
			if (nullable_0.HasValue)
			{
				Class331.smethod_56(nullable_0.Value);
			}
			Bass.BASS_ChannelPlay(Class331.int_6, false);
			Bass.BASS_ChannelSetAttribute(Class331.int_6, 2, (float)Class331.smethod_80() / 100f);
		}

		// Token: 0x060018D2 RID: 6354
		// RVA: 0x0001520F File Offset: 0x0001340F
		internal static void smethod_65(Struct69 struct69_0, float float_4)
		{
			Class331.smethod_61(Class331.smethod_66(struct69_0.hitObjectSoundType_0, struct69_0.sampleSet_0, struct69_0.enum38_0, Enum101.const_1), struct69_0.int_0, float_4, false, 1f);
		}

		// Token: 0x060018D3 RID: 6355
		// RVA: 0x000778EC File Offset: 0x00075AEC
		private static int smethod_66(HitObjectSoundType hitObjectSoundType_0, SampleSet sampleSet_4, Enum38 enum38_3, Enum101 enum101_0)
		{
			int num = 0;
			if (enum101_0 != Enum101.const_1)
			{
				switch (hitObjectSoundType_0)
				{
				case HitObjectSoundType.Normal:
					num = 0;
					break;
				case HitObjectSoundType.Whistle:
					num = 1;
					break;
				case HitObjectSoundType.Normal | HitObjectSoundType.Whistle:
					break;
				case HitObjectSoundType.Finish:
					num = 2;
					break;
				default:
					if (hitObjectSoundType_0 == HitObjectSoundType.Clap)
					{
						num = 3;
					}
					break;
				}
			}
			switch (sampleSet_4)
			{
			case SampleSet.None:
			case SampleSet.Soft:
			{
				int num2 = 1;
				goto IL_5D;
			}
			case SampleSet.Normal:
			{
				IL_53:
				int num2 = 0;
				goto IL_5D;
			}
			case SampleSet.Drum:
			{
				int num2 = 2;
				goto IL_5D;
			}
			}
			goto IL_53;
			IL_5D:
			int num3 = (int)enum38_3;
			if (num3 <= 2)
			{
				if (num3 < 0)
				{
					num3 = 0;
				}
				switch (enum101_0)
				{
				case Enum101.const_0:
				{
					int num2;
					return Class331.int_13[num, num2, num3];
				}
				case Enum101.const_1:
				{
					int num2;
					return Class331.int_14[num, num2, num3];
				}
				case Enum101.const_2:
				{
					int num2;
					return Class331.int_15[num, num2, num3];
				}
				default:
					return -1;
				}
			}
			else
			{
				string key = string.Empty;
				string arg_CF_0;
				if (Class115.osuModes_1 == OsuModes.Play)
				{
					if (Class62.Mode == PlayModes.Taiko)
					{
						arg_CF_0 = "taiko-";
						goto IL_CF;
					}
				}
				arg_CF_0 = string.Empty;
				IL_CF:
				string text = arg_CF_0;
				switch (enum101_0)
				{
				case Enum101.const_0:
					key = string.Format("{0}{1}-hit{2}{3}", new object[]
					{
						text,
						sampleSet_4.ToString().ToLower(),
						hitObjectSoundType_0.ToString().ToLower(),
						num3
					});
					break;
				case Enum101.const_1:
					key = string.Format("{0}{1}-slidertick{2}", text, sampleSet_4.ToString().ToLower(), num3);
					break;
				case Enum101.const_2:
					key = string.Format("{0}{1}-slider{2}{3}", new object[]
					{
						text,
						sampleSet_4.ToString().ToLower(),
						(hitObjectSoundType_0 == HitObjectSoundType.Normal) ? "slide" : hitObjectSoundType_0.ToString().ToLower(),
						num3
					});
					break;
				}
				int num4 = -1;
				if (Class331.dictionary_0.TryGetValue(key, out num4) && num4 != -1)
				{
					return num4;
				}
				if (num > 3)
				{
					return -1;
				}
				switch (enum101_0)
				{
				case Enum101.const_0:
				{
					int num2;
					return Class331.int_13[num, num2, 0];
				}
				case Enum101.const_1:
				{
					int num2;
					return Class331.int_14[num, num2, 0];
				}
				case Enum101.const_2:
				{
					int num2;
					return Class331.int_15[num, num2, 0];
				}
				default:
					return -1;
				}
			}
		}

		// Token: 0x060018D4 RID: 6356
		// RVA: 0x00015240 File Offset: 0x00013440
		internal static int smethod_67()
		{
			return (int)Class331.class335_0.vmethod_10();
		}

		// Token: 0x060018D5 RID: 6357
		// RVA: 0x0001524D File Offset: 0x0001344D
		internal static void smethod_68(int int_20)
		{
			Class331.int_17 = 0;
			Class331.class335_0.vmethod_13(!Class331.bool_5);
			Class331.class335_0.vmethod_11((double)int_20);
		}

		// Token: 0x060018D6 RID: 6358
		// RVA: 0x00077B14 File Offset: 0x00075D14
		private static void smethod_69()
		{
			if (!Class331.bool_8)
			{
				return;
			}
			Class331.class335_0.Seek((double)(Class331.int_3 + ((Class331.int_3 != 0) ? Class331.int_12 : 0)));
			Class331.bool_8 = false;
			Class331.bool_4 = false;
			Class331.smethod_52();
			Class331.int_9 = Class331.int_7;
		}

		// Token: 0x06001897 RID: 6295
		// RVA: 0x00075CC4 File Offset: 0x00073EC4
		internal static Class340 smethod_7()
		{
			List<Class340> list = Class331.smethod_14();
			if (list == null || list.Count == 0)
			{
				return null;
			}
			if (Class331.int_2 >= 0 && Class331.int_2 < list.Count)
			{
				return list[Class331.int_2];
			}
			return list[0];
		}

		// Token: 0x060018D7 RID: 6359
		// RVA: 0x00077B64 File Offset: 0x00075D64
		internal static void smethod_70(int int_20, bool bool_9, bool bool_10)
		{
			if (Class331.int_10 == int_20 && Class331.int_7 == int_20 && !bool_10)
			{
				return;
			}
			Class331.smethod_5();
			Class872.bool_13 = true;
			if (int_20 < 0 && !bool_9 && !Class331.bool_4)
			{
				int_20 = 0;
			}
			else if (int_20 > Class331.smethod_31() && !bool_9)
			{
				int_20 = Class331.smethod_31();
			}
			if (Class331.bool_4)
			{
				if ((double)int_20 > Class331.double_1)
				{
					Class331.double_2 += (double)int_20 - Class331.double_1;
				}
				Class331.double_1 = (double)int_20;
				Class331.smethod_52();
			}
			if (!Class331.bool_4 || bool_10)
			{
				if (Class331.enum100_0 != Enum100.const_0)
				{
					if (Math.Abs(int_20 - Class331.int_7) > 200 || bool_10)
					{
						Class331.class335_0.Seek((double)(int_20 + Class331.int_12));
					}
					Class331.enum100_0 = Enum100.const_2;
					Class331.smethod_52();
					Class331.int_9 = Class331.int_7;
				}
				else
				{
					Class331.int_3 = int_20;
					Class331.bool_8 = true;
					Class331.smethod_52();
				}
			}
			Class331.smethod_6(false);
		}

		// Token: 0x060018D8 RID: 6360
		// RVA: 0x00015273 File Offset: 0x00013473
		internal static bool smethod_71()
		{
			return Class331.class335_0 != null && Class331.class335_0.bool_1;
		}

		// Token: 0x060018D9 RID: 6361
		// RVA: 0x00015288 File Offset: 0x00013488
		internal static void smethod_72(bool bool_9)
		{
			if (Class331.class335_0 != null)
			{
				Class331.class335_0.vmethod_5(bool_9);
			}
		}

		// Token: 0x060018DA RID: 6362
		// RVA: 0x00077C4C File Offset: 0x00075E4C
		internal static void smethod_73(float float_4)
		{
			Class331.Class333 class = new Class331.Class333();
			Class331.int_18 = (int)(Class331.float_0 * float_4);
			if (Class331.thread_0 != null)
			{
				return;
			}
			int num = (int)Class331.float_1;
			class.int_0 = num * (Class331.smethod_71() ? -1 : 1);
			Class331.thread_0 = Class115.smethod_88(new VoidDelegate(class.method_0), false, ThreadPriority.Normal);
		}

		// Token: 0x060018DB RID: 6363
		// RVA: 0x00077CA8 File Offset: 0x00075EA8
		internal static Enum38 smethod_74()
		{
			List<Class340> list = Class331.smethod_14();
			if (list != null && list.Count > 0 && Class331.int_2 >= 0 && Class331.int_2 < list.Count && Class331.smethod_32().int_6 > 3)
			{
				return list[Class331.int_2].enum38_0;
			}
			return Class331.enum38_2;
		}

		// Token: 0x060018DC RID: 6364
		// RVA: 0x0001529C File Offset: 0x0001349C
		internal static void smethod_75(Enum38 enum38_3)
		{
			Class331.enum38_2 = enum38_3;
		}

		// Token: 0x060018DD RID: 6365
		// RVA: 0x000152A4 File Offset: 0x000134A4
		internal static int smethod_76()
		{
			if (Class331.smethod_32() != null)
			{
				return Class331.smethod_32().int_14;
			}
			return 0;
		}

		// Token: 0x060018DE RID: 6366
		// RVA: 0x000152B9 File Offset: 0x000134B9
		internal static float smethod_77()
		{
			return (float)(Class331.class608_1.Value * Class331.class608_2.Value) / 100f;
		}

		// Token: 0x060018DF RID: 6367
		// RVA: 0x000152D7 File Offset: 0x000134D7
		internal static float smethod_78()
		{
			return (float)(Class331.class608_0.Value * Class331.class608_2.Value) / 100f;
		}

		// Token: 0x060018E0 RID: 6368
		// RVA: 0x000152F5 File Offset: 0x000134F5
		internal static bool smethod_79()
		{
			return Class331.enum100_0 == Enum100.const_0;
		}

		// Token: 0x06001898 RID: 6296
		// RVA: 0x00075D0C File Offset: 0x00073F0C
		internal static double smethod_8()
		{
			List<Class340> list = Class331.smethod_14();
			if (list == null || list.Count == 0)
			{
				return 0.0;
			}
			int count = list.Count;
			bool flag = count > 0 && Class331.int_1 >= 0 && Class331.int_1 < count;
			bool flag2 = Class331.int_2 > Class331.int_1 && Class331.int_2 < count;
			if (flag)
			{
				if (flag2)
				{
					double num = list[Class331.int_2].double_0;
					if (num < 0.0)
					{
						return list[Class331.int_1].double_0;
					}
				}
				return list[Class331.int_1].double_0;
			}
			return 0.0;
		}

		// Token: 0x060018E1 RID: 6369
		// RVA: 0x000152FF File Offset: 0x000134FF
		internal static int smethod_80()
		{
			return (int)((float)Class331.smethod_81() * Class331.smethod_78() / 100f);
		}

		// Token: 0x060018E2 RID: 6370
		// RVA: 0x00077D00 File Offset: 0x00075F00
		internal static int smethod_81()
		{
			if (Class331.smethod_32() == null)
			{
				return 100;
			}
			List<Class340> list = Class331.smethod_14();
			if (list != null && Class331.int_2 >= 0 && list.Count > Class331.int_2)
			{
				return Math.Max(8, list[Class331.int_2].int_0);
			}
			return Class331.smethod_32().int_15;
		}

		// Token: 0x060018E3 RID: 6371
		// RVA: 0x00077D58 File Offset: 0x00075F58
		internal static bool smethod_82()
		{
			Class340 class = Class331.smethod_7();
			return class != null && class.method_2();
		}

		// Token: 0x060018E4 RID: 6372
		// RVA: 0x00015314 File Offset: 0x00013514
		internal static void smethod_83()
		{
			Class331.smethod_72(false);
			Class331.bool_5 = false;
			Class331.smethod_68(100);
			Class331.float_1 = Class331.float_0;
			Class331.smethod_5();
			if (Class331.class335_0 != null)
			{
				Class331.class335_0.Reset();
			}
		}

		// Token: 0x060018E5 RID: 6373
		// RVA: 0x00077D78 File Offset: 0x00075F78
		internal static bool smethod_84(Class296 class296_0, bool bool_9, bool bool_10, bool bool_11, bool bool_12)
		{
			if (!class296_0.bool_8)
			{
				class296_0.method_11();
			}
			if (Class331.bool_5)
			{
				if (Class331.class88_0 == null)
				{
					Class331.class88_0 = new Class88();
				}
				Class331.class88_0.Reset();
			}
			else
			{
				if (Class331.class88_0 != null)
				{
					Class331.class88_0.Dispose();
				}
				Class331.class88_0 = null;
			}
			if (Class331.class335_0 != null && !Class331.class335_0.bool_0 && (!Class331.class335_0.vmethod_2() || bool_10) && Class331.class335_0.class296_0 != null && class296_0.method_3() == Class331.class335_0.class296_0.method_3() && class296_0.string_1 == Class331.class335_0.class296_0.string_1)
			{
				Class331.class335_0.class296_0 = class296_0;
				return false;
			}
			if (bool_11)
			{
				Class331.smethod_91();
			}
			Class331.class335_0 = Class335.smethod_0(class296_0, bool_10, bool_12);
			if (Class331.voidDelegate_1 != null)
			{
				Class331.voidDelegate_1();
			}
			if (bool_9)
			{
				try
				{
					TAG_INFO tAG_INFO = new TAG_INFO();
					if (BassTags.BASS_TAG_GetFromFile(Class331.class335_0.method_0(), tAG_INFO))
					{
						Class331.string_0 = tAG_INFO.artist;
						Class331.string_1 = tAG_INFO.title;
					}
					else
					{
						Class331.string_0 = Class41.GetString(OsuString.AudioEngine_Unknown);
						Class331.string_1 = Class41.GetString(OsuString.AudioEngine_Unknown);
					}
				}
				catch
				{
					Class331.string_0 = Class41.GetString(OsuString.AudioEngine_Unknown);
					Class331.string_1 = Class41.GetString(OsuString.AudioEngine_Unknown);
				}
			}
			Bass.BASS_ChannelGetAttribute(Class331.class335_0.method_0(), 1, ref Class331.float_1);
			if (Class331.float_1 <= 0f)
			{
				Class331.float_1 = 44100f;
			}
			Class331.float_0 = Class331.float_1;
			Class331.smethod_83();
			Class111.smethod_56(false, false);
			return true;
		}

		// Token: 0x060018E6 RID: 6374
		// RVA: 0x00077F30 File Offset: 0x00076130
		internal static TAG_INFO smethod_85()
		{
			if (Class331.class335_0.method_0() != 0)
			{
				TAG_INFO result;
				try
				{
					TAG_INFO tAG_INFO = new TAG_INFO();
					if (!BassTags.BASS_TAG_GetFromFile(Class331.class335_0.method_0(), tAG_INFO))
					{
						goto IL_31;
					}
					result = tAG_INFO;
				}
				catch
				{
					result = null;
				}
				return result;
			}
			IL_31:
			return null;
		}

		// Token: 0x060018E7 RID: 6375
		// RVA: 0x00077F80 File Offset: 0x00076180
		internal static bool smethod_86(Class296 class296_0, bool bool_9, bool bool_10, bool bool_11)
		{
			Class331.bool_4 = false;
			Class331.smethod_5();
			bool flag;
			bool result;
			try
			{
				flag = !Class331.smethod_84(class296_0, false, bool_11, true, false);
				goto IL_31;
			}
			catch (UnauthorizedAccessException)
			{
				Class723.smethod_4(Class41.GetString(OsuString.AudioEngine_NoPermissions));
				result = false;
			}
			return result;
			IL_31:
			if (flag && bool_9 && Class331.double_1 / (double)Class331.smethod_31() < 0.98000001907348633 && Class331.smethod_67() == 100)
			{
				Class331.smethod_89(Class331.int_11 / 3, false);
			}
			else
			{
				if (bool_10)
				{
					Class331.class335_0.Seek((double)((Class331.smethod_76() == -1) ? ((int)((double)Class331.smethod_31() * 0.4)) : Class331.smethod_76()));
				}
				Class331.smethod_89(0, true);
			}
			Class331.class335_0.vmethod_6(false);
			Class331.enum100_0 = Enum100.const_1;
			return flag;
		}

		// Token: 0x060018E8 RID: 6376
		// RVA: 0x00015349 File Offset: 0x00013549
		internal static void smethod_87()
		{
			Class331.smethod_69();
			Class331.class335_0.vmethod_6(true);
			Class331.enum100_0 = Enum100.const_2;
		}

		// Token: 0x060018E9 RID: 6377
		// RVA: 0x0007804C File Offset: 0x0007624C
		internal static bool smethod_88()
		{
			if (Class331.bool_4)
			{
				if (Class331.enum100_0 != Enum100.const_1)
				{
					Class331.enum100_0 = Enum100.const_1;
					Class331.smethod_98();
					return false;
				}
				Class331.enum100_0 = Enum100.const_0;
				Class331.smethod_97();
				return true;
			}
			else
			{
				if (Class331.class335_0.vmethod_8())
				{
					Class331.enum100_0 = Enum100.const_0;
					Class331.smethod_97();
					Class331.class335_0.vmethod_7();
					return true;
				}
				Class331.smethod_69();
				Class331.smethod_98();
				Class331.enum100_0 = Enum100.const_2;
				Class331.class335_0.vmethod_6(false);
				return false;
			}
		}

		// Token: 0x060018EA RID: 6378
		// RVA: 0x000780C4 File Offset: 0x000762C4
		internal static void smethod_89(int int_20, bool bool_9)
		{
			Class331.int_11 = Math.Max(Math.Min(100, int_20), bool_9 ? 0 : 10);
			float num = Class331.smethod_77() / 100f * (float)Class331.int_11 / 100f;
			Class331.float_3 = num;
			if (Class331.class335_0 != null)
			{
				Class331.class335_0.vmethod_1(num);
			}
		}

		// Token: 0x06001899 RID: 6297
		// RVA: 0x00075DC4 File Offset: 0x00073FC4
		internal static void smethod_9(double double_4)
		{
			List<Class340> list = Class331.smethod_14();
			if (list == null)
			{
				return;
			}
			if (list.Count <= 0)
			{
				list.Add(new Class340(0.0, double_4));
				return;
			}
			if (Class331.int_1 >= 0)
			{
				list[Class331.int_1].double_0 = double_4;
				return;
			}
			list[0].double_0 = double_4;
		}

		// Token: 0x060018EB RID: 6379
		// RVA: 0x00015361 File Offset: 0x00013561
		internal static void smethod_90()
		{
			Class331.int_7 = 0;
			Class331.int_8 = 0;
			Class331.int_3 = 0;
			Class331.bool_8 = true;
			if (Class331.class335_0 != null)
			{
				Class331.class335_0.method_2();
			}
			Class331.enum100_0 = Enum100.const_0;
		}

		// Token: 0x060018EC RID: 6380
		// RVA: 0x00015392 File Offset: 0x00013592
		internal static void smethod_91()
		{
			if (Class331.class335_0 != null)
			{
				Class331.class335_0.Dispose();
				Class331.class335_0 = null;
			}
			Class331.bool_8 = false;
		}

		// Token: 0x060018ED RID: 6381
		// RVA: 0x00078120 File Offset: 0x00076320
		internal static void smethod_92()
		{
			Class331.smethod_96();
			foreach (Class338 current in Class331.list_1)
			{
				if (current.bool_2)
				{
					Bass.BASS_SampleFree(current.int_0);
				}
			}
			Class331.list_1.Clear();
		}

		// Token: 0x060018EE RID: 6382
		// RVA: 0x000153B1 File Offset: 0x000135B1
		internal static void smethod_93()
		{
			if (Class331.bool_4)
			{
				if (Class331.enum100_0 != Enum100.const_1)
				{
					Class331.enum100_0 = Enum100.const_1;
					Class331.smethod_98();
				}
				return;
			}
			Class331.smethod_69();
			Class331.class335_0.vmethod_6(false);
			Class331.enum100_0 = Enum100.const_2;
		}

		// Token: 0x060018EF RID: 6383
		// RVA: 0x000153E4 File Offset: 0x000135E4
		internal static void smethod_94()
		{
			Bass.BASS_ChannelPause(Class331.int_4);
			Bass.BASS_ChannelPause(Class331.int_5);
		}

		// Token: 0x060018F0 RID: 6384
		// RVA: 0x000153FC File Offset: 0x000135FC
		internal static void smethod_95()
		{
			Bass.BASS_ChannelPause(Class331.int_6);
		}

		// Token: 0x060018F1 RID: 6385
		// RVA: 0x00078190 File Offset: 0x00076390
		internal static void smethod_96()
		{
			foreach (Class338 current in Class331.list_1)
			{
				if (current.class339_0 != null)
				{
					current.class339_0.method_11(true);
				}
			}
		}

		// Token: 0x060018F2 RID: 6386
		// RVA: 0x000781F0 File Offset: 0x000763F0
		internal static void smethod_97()
		{
			foreach (Class338 current in Class331.list_1)
			{
				if (current.class339_0 != null && current.class339_0.method_12())
				{
					current.class339_0.method_14();
					current.bool_1 = true;
				}
			}
		}

		// Token: 0x060018F3 RID: 6387
		// RVA: 0x00078264 File Offset: 0x00076464
		internal static void smethod_98()
		{
			foreach (Class338 current in Class331.list_1)
			{
				if (current.bool_1)
				{
					current.class339_0.method_10(false, false);
					current.bool_1 = false;
				}
			}
		}

		// Token: 0x060018F4 RID: 6388
		// RVA: 0x00015409 File Offset: 0x00013609
		internal static void smethod_99()
		{
			Class331.smethod_100(Class331.int_10, false);
		}
	}
}
