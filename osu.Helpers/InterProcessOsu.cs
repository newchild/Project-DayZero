using ns14;
using ns18;
using ns19;
using ns24;
using ns25;
using ns26;
using ns29;
using ns6;
using ns76;
using ns78;
using ns82;
using ns89;
using osu_common.Helpers;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace osu.Helpers
{
	// Token: 0x020005B3 RID: 1459
	public sealed class InterProcessOsu : MarshalByRefObject
	{
		// Token: 0x020005B5 RID: 1461
		[CompilerGenerated]
		private sealed class Class779
		{
			// Token: 0x040026E1 RID: 9953
			public string string_0;

			// Token: 0x06002EB4 RID: 11956
			// RVA: 0x000232C8 File Offset: 0x000214C8
			public void method_0()
			{
				Class115.smethod_26();
				Class111.smethod_41(this.string_0);
			}
		}

		// Token: 0x020005B6 RID: 1462
		[CompilerGenerated]
		private sealed class Class780
		{
			// Token: 0x040026E3 RID: 9955
			public int int_0;

			// Token: 0x040026E2 RID: 9954
			public long long_0;

			// Token: 0x06002EB6 RID: 11958
			// RVA: 0x00130158 File Offset: 0x0012E358
			public void method_0()
			{
				long num = Class115.stopwatch_0.ElapsedMilliseconds - this.long_0;
				if (Class115.osuModes_1 == OsuModes.Menu && Math.Abs((long)Class331.int_7 - num - (long)this.int_0) > 50L)
				{
					Class331.smethod_70(this.int_0 + (int)num, false, false);
				}
			}
		}

		// Token: 0x020005B7 RID: 1463
		[CompilerGenerated]
		private sealed class Class781
		{
			// Token: 0x040026E4 RID: 9956
			public int int_0;

			// Token: 0x06002EB8 RID: 11960
			// RVA: 0x001301B0 File Offset: 0x0012E3B0
			public void method_0()
			{
				Class861 class = Class809.smethod_28(this.int_0, true);
				if (class != null && class == Class858.class861_0)
				{
					if (Class115.class533_0 != null)
					{
						Class115.class533_0.Text = class.Name;
					}
					return;
				}
				Class858.smethod_4(true);
				if (class != null)
				{
					Class858.smethod_5(class);
				}
			}
		}

		// Token: 0x020005B8 RID: 1464
		[CompilerGenerated]
		private sealed class Class782
		{
			// Token: 0x040026E5 RID: 9957
			public Class296 class296_0;

			// Token: 0x040026E6 RID: 9958
			public InterProcessOsu interProcessOsu_0;

			// Token: 0x040026E7 RID: 9959
			public string string_0;

			// Token: 0x06002EBA RID: 11962
			// RVA: 0x000232DA File Offset: 0x000214DA
			public void method_0()
			{
				Class466.smethod_21(this.class296_0);
				Class331.smethod_86(Class466.Current, true, true, false);
			}

			// Token: 0x06002EBB RID: 11963
			// RVA: 0x000232F5 File Offset: 0x000214F5
			public void method_1(object sender, EventArgs e)
			{
				Class77.smethod_8(false);
				Class115.class47_0.Add(new VoidDelegate(this.method_2), true);
			}

			// Token: 0x06002EBC RID: 11964
			// RVA: 0x00023314 File Offset: 0x00021514
			public void method_2()
			{
				this.interProcessOsu_0.method_12(this.string_0);
			}
		}

		// Token: 0x020005B9 RID: 1465
		[CompilerGenerated]
		private sealed class Class783
		{
			// Token: 0x040026E8 RID: 9960
			public OsuModes osuModes_0;

			// Token: 0x06002EBE RID: 11966
			// RVA: 0x00023327 File Offset: 0x00021527
			public void method_0()
			{
				Class115.smethod_70(this.osuModes_0, false);
			}
		}

		// Token: 0x020005B4 RID: 1460
		[Serializable]
		public sealed class ClientData
		{
			// Token: 0x040026DD RID: 9949
			public int AudioTime;

			// Token: 0x040026D9 RID: 9945
			public bool Buffering;

			// Token: 0x040026DA RID: 9946
			public OsuModes Mode;

			// Token: 0x040026DF RID: 9951
			public bool OverridePause;

			// Token: 0x040026DE RID: 9950
			public int ReplayTime;

			// Token: 0x040026DC RID: 9948
			public int Score;

			// Token: 0x040026E0 RID: 9952
			public bool SkipCalculations;

			// Token: 0x040026DB RID: 9947
			public int SpectatingID;
		}

		// Token: 0x040026D8 RID: 9944
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_0;

		// Token: 0x06002E9E RID: 11934
		// RVA: 0x0012FD9C File Offset: 0x0012DF9C
		public void method_0(string string_0)
		{
			VoidDelegate voidDelegate = null;
			InterProcessOsu.Class779 class = new InterProcessOsu.Class779();
			class.string_0 = string_0;
			if (class.string_0.StartsWith("osu://"))
			{
				Class47 arg_38_0 = Class115.class47_0;
				if (voidDelegate == null)
				{
					voidDelegate = new VoidDelegate(class.method_0);
				}
				arg_38_0.Add(voidDelegate, false);
				return;
			}
			OsuModes osuModes = Class115.smethod_81(new string[]
			{
				class.string_0
			});
			if (osuModes != OsuModes.Unknown)
			{
				if (Class115.bool_11 && Class115.form_0.Visible)
				{
					Class115.form_0.WindowState = FormWindowState.Normal;
					Class115.smethod_26();
				}
				Class115.smethod_70(osuModes, true);
			}
		}

		// Token: 0x06002E9F RID: 11935
		// RVA: 0x0002320E File Offset: 0x0002140E
		public bool method_1()
		{
			Class115.smethod_96(false);
			return true;
		}

		// Token: 0x06002EA8 RID: 11944
		// RVA: 0x0012FFB4 File Offset: 0x0012E1B4
		public void method_10(int int_0)
		{
			InterProcessOsu.Class781 class = new InterProcessOsu.Class781();
			class.int_0 = int_0;
			if (Class115.bool_16)
			{
				if (Class115.enum113_0 == Enum113.const_2)
				{
					Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
					return;
				}
			}
		}

		// Token: 0x06002EA9 RID: 11945
		// RVA: 0x0002324A File Offset: 0x0002144A
		public void method_11()
		{
			Class47 arg_23_0 = Class115.class47_0;
			if (InterProcessOsu.voidDelegate_0 == null)
			{
				InterProcessOsu.voidDelegate_0 = new VoidDelegate(InterProcessOsu.smethod_0);
			}
			arg_23_0.Add(InterProcessOsu.voidDelegate_0, false);
		}

		// Token: 0x06002EAA RID: 11946
		// RVA: 0x0012FFF8 File Offset: 0x0012E1F8
		public void method_12(string string_0)
		{
			VoidDelegate voidDelegate = null;
			EventHandler eventHandler = null;
			InterProcessOsu.Class782 class = new InterProcessOsu.Class782();
			class.string_0 = string_0;
			class.interProcessOsu_0 = this;
			if (!Class115.bool_16)
			{
				return;
			}
			if (Class115.enum113_0 != Enum113.const_2)
			{
				return;
			}
			if (Class115.osuModes_1 == OsuModes.Play)
			{
				return;
			}
			class.class296_0 = Class466.smethod_25(class.string_0);
			if (class.class296_0 == null && !Class115.bool_17)
			{
				Class466.Initialize(true);
				class.class296_0 = Class466.smethod_25(class.string_0);
			}
			if (Class466.Current == class.class296_0)
			{
				return;
			}
			if (class.class296_0 != null)
			{
				Class47 arg_97_0 = Class115.class47_0;
				if (voidDelegate == null)
				{
					voidDelegate = new VoidDelegate(class.method_0);
				}
				arg_97_0.Add(voidDelegate, false);
				return;
			}
			string arg_B5_0 = class.string_0;
			if (eventHandler == null)
			{
				eventHandler = new EventHandler(class.method_1);
			}
			Class112.smethod_6(arg_B5_0, eventHandler, null);
		}

		// Token: 0x06002EAB RID: 11947
		// RVA: 0x001300C0 File Offset: 0x0012E2C0
		public int method_13()
		{
			if (!Class115.bool_16)
			{
				return 0;
			}
			Class62 class62_ = Class62.class62_0;
			if (class62_ != null && class62_.enum110_0 == Enum110.const_0)
			{
				return 0;
			}
			Class512 class512_ = Class62.class512_0;
			if (class512_ == null)
			{
				return 0;
			}
			if (!Class62.bool_6)
			{
				return class512_.int_3;
			}
			return 0;
		}

		// Token: 0x06002EAC RID: 11948
		// RVA: 0x00023274 File Offset: 0x00021474
		public void method_14(int int_0)
		{
			if (!Class115.bool_16)
			{
				return;
			}
			Class872.int_2 = int_0;
		}

		// Token: 0x06002EAD RID: 11949
		// RVA: 0x00023284 File Offset: 0x00021484
		public OsuModes method_15()
		{
			Class784.int_0 = Class115.int_1;
			return Class115.osuModes_1;
		}

		// Token: 0x06002EAE RID: 11950
		// RVA: 0x00130104 File Offset: 0x0012E304
		public int method_16()
		{
			Class861 class861_ = Class858.class861_0;
			if (class861_ == null)
			{
				return 0;
			}
			return class861_.int_1;
		}

		// Token: 0x06002EAF RID: 11951
		// RVA: 0x00130124 File Offset: 0x0012E324
		public void method_17(OsuModes osuModes_0)
		{
			InterProcessOsu.Class783 class = new InterProcessOsu.Class783();
			class.osuModes_0 = osuModes_0;
			Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
		}

		// Token: 0x06002EA0 RID: 11936
		// RVA: 0x00023217 File Offset: 0x00021417
		public void method_2()
		{
			Class784.smethod_2();
			Class115.smethod_70(OsuModes.Exit, false);
		}

		// Token: 0x06002EA1 RID: 11937
		// RVA: 0x0012FE30 File Offset: 0x0012E030
		public InterProcessOsu.ClientData method_3()
		{
			return new InterProcessOsu.ClientData
			{
				Buffering = this.method_6(),
				AudioTime = this.method_4(),
				ReplayTime = this.method_5(),
				SpectatingID = this.method_16(),
				Score = this.method_13(),
				Mode = this.method_15(),
				SkipCalculations = Class115.bool_19
			};
		}

		// Token: 0x06002EA2 RID: 11938
		// RVA: 0x0012FE98 File Offset: 0x0012E098
		public int method_4()
		{
			Class512 class512_ = Class802.class512_0;
			if (Class802.smethod_0() && Class802.bool_16 && Class858.class861_0 != null && Class115.bool_16 && class512_ != null && class512_.list_1 != null && class512_.list_1.Count != 0 && !Class62.bool_6)
			{
				return Class331.int_7;
			}
			return 2147483647;
		}

		// Token: 0x06002EA3 RID: 11939
		// RVA: 0x0012FEF4 File Offset: 0x0012E0F4
		public int method_5()
		{
			Class512 class512_ = Class802.class512_0;
			if (Class802.smethod_0() && Class802.bool_16 && Class858.class861_0 != null && Class115.bool_16 && class512_ != null && class512_.list_1 != null && class512_.list_1.Count != 0 && !Class62.bool_6)
			{
				return class512_.list_1[class512_.list_1.Count - 1].int_0;
			}
			return 2147483647;
		}

		// Token: 0x06002EA4 RID: 11940
		// RVA: 0x00023225 File Offset: 0x00021425
		public bool method_6()
		{
			return Class115.bool_18;
		}

		// Token: 0x06002EA5 RID: 11941
		// RVA: 0x0002322C File Offset: 0x0002142C
		public void method_7()
		{
			Class115.bool_18 = !Class115.bool_18;
		}

		// Token: 0x06002EA6 RID: 11942
		// RVA: 0x0002323B File Offset: 0x0002143B
		public void method_8()
		{
			Class115.bool_19 = !Class115.bool_19;
		}

		// Token: 0x06002EA7 RID: 11943
		// RVA: 0x0012FF68 File Offset: 0x0012E168
		public void method_9(int int_0)
		{
			InterProcessOsu.Class780 class = new InterProcessOsu.Class780();
			class.int_0 = int_0;
			if (Class115.enum113_0 != Enum113.const_2)
			{
				return;
			}
			class.long_0 = Class115.stopwatch_0.ElapsedMilliseconds;
			Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
		}

		// Token: 0x06002EB1 RID: 11953
		// RVA: 0x00023295 File Offset: 0x00021495
		[CompilerGenerated]
		private static void smethod_0()
		{
			if (!Class115.bool_16)
			{
				return;
			}
			if (Class115.enum113_0 != Enum113.const_2)
			{
				return;
			}
			Class466.Initialize(true);
			if (Class115.osuModes_1 != OsuModes.Play)
			{
				Class858.smethod_4(true);
				Class858.smethod_5(Class858.class861_0);
			}
		}
	}
}
