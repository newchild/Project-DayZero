using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns17;
using ns24;
using ns26;
using ns27;
using ns29;
using ns30;
using ns31;
using ns48;
using ns64;
using ns8;
using ns9;
using ns90;
using osu;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns19
{
	// Token: 0x020003E2 RID: 994
	internal sealed class Class67 : Class61
	{
		// Token: 0x020003E3 RID: 995
		[CompilerGenerated]
		private sealed class Class442
		{
			// Token: 0x0400192B RID: 6443
			public Class296 class296_0;

			// Token: 0x06001FF6 RID: 8182
			// RVA: 0x0001A20E File Offset: 0x0001840E
			public void method_0()
			{
				Class77.smethod_1(true);
				Class466.list_5.Add(Path.GetFullPath(this.class296_0.method_3()));
			}
		}

		// Token: 0x020003E4 RID: 996
		[CompilerGenerated]
		private sealed class Class443
		{
			// Token: 0x0400192E RID: 6446
			public byte[] byte_0;

			// Token: 0x0400192C RID: 6444
			public Class67.Class442 class442_0;

			// Token: 0x0400192F RID: 6447
			public int int_0;

			// Token: 0x0400192D RID: 6445
			public string string_0;

			// Token: 0x06001FF8 RID: 8184
			// RVA: 0x0001A230 File Offset: 0x00018430
			public void method_0(string string_1, Exception exception_0)
			{
				if (exception_0 == null)
				{
					this.string_0 = string_1;
				}
			}

			// Token: 0x06001FF9 RID: 8185
			// RVA: 0x0001A23C File Offset: 0x0001843C
			public void method_1(byte[] byte_1, Exception exception_0)
			{
				if (exception_0 == null)
				{
					this.byte_0 = byte_1;
				}
			}

			// Token: 0x06001FFA RID: 8186
			// RVA: 0x0001A248 File Offset: 0x00018448
			public void method_2(Struct20 struct20_0)
			{
				this.int_0 += struct20_0.method_3();
			}
		}

		// Token: 0x020003E5 RID: 997
		[CompilerGenerated]
		private sealed class Class444
		{
			// Token: 0x04001931 RID: 6449
			public Class67.Class442 class442_0;

			// Token: 0x04001930 RID: 6448
			public Class67.Class443 class443_0;

			// Token: 0x04001932 RID: 6450
			public string string_0;

			// Token: 0x06001FFC RID: 8188
			// RVA: 0x0001A25E File Offset: 0x0001845E
			public void method_0()
			{
				Class723.smethod_5(this.string_0, Color.get_Cyan(), 3000, null);
			}
		}

		// Token: 0x020003E6 RID: 998
		[CompilerGenerated]
		private sealed class Class445
		{
			// Token: 0x04001934 RID: 6452
			public Class67.Class442 class442_0;

			// Token: 0x04001933 RID: 6451
			public Class67.Class443 class443_0;

			// Token: 0x04001935 RID: 6453
			public Struct20 struct20_0;

			// Token: 0x06001FFE RID: 8190
			// RVA: 0x000B62B4 File Offset: 0x000B44B4
			public bool method_0(Struct20 struct20_1)
			{
				string arg_15_0 = struct20_1.method_0();
				Struct20 struct = this.struct20_0;
				if (arg_15_0 == struct.method_0())
				{
					byte[] arg_31_0 = struct20_1.method_5();
					Struct20 struct2 = this.struct20_0;
					return Class275.smethod_1(arg_31_0, struct2.method_5());
				}
				return false;
			}
		}

		// Token: 0x020003E7 RID: 999
		[CompilerGenerated]
		private sealed class Class446
		{
			// Token: 0x04001939 RID: 6457
			public byte[] byte_0;

			// Token: 0x04001938 RID: 6456
			public Class67.Class442 class442_0;

			// Token: 0x04001937 RID: 6455
			public Class67.Class443 class443_0;

			// Token: 0x04001936 RID: 6454
			public Class67.Class445 class445_0;

			// Token: 0x06002000 RID: 8192
			// RVA: 0x0001A276 File Offset: 0x00018476
			public void method_0(byte[] byte_1, Exception exception_0)
			{
				if (exception_0 == null)
				{
					this.byte_0 = byte_1;
				}
			}
		}

		// Token: 0x020003E8 RID: 1000
		[CompilerGenerated]
		private sealed class Class447
		{
			// Token: 0x0400193D RID: 6461
			public Class67.Class442 class442_0;

			// Token: 0x0400193C RID: 6460
			public Class67.Class443 class443_0;

			// Token: 0x0400193B RID: 6459
			public Class67.Class445 class445_0;

			// Token: 0x0400193A RID: 6458
			public Class67.Class446 class446_0;

			// Token: 0x0400193E RID: 6462
			public string string_0;

			// Token: 0x06002002 RID: 8194
			// RVA: 0x0001A282 File Offset: 0x00018482
			public void method_0()
			{
				Class723.smethod_5(this.string_0, Color.get_Cyan(), 3300, null);
			}
		}

		// Token: 0x020003E9 RID: 1001
		[CompilerGenerated]
		private sealed class Class448
		{
			// Token: 0x04001940 RID: 6464
			public Class67.Class442 class442_0;

			// Token: 0x0400193F RID: 6463
			public Class67.Class443 class443_0;

			// Token: 0x04001941 RID: 6465
			public string string_0;

			// Token: 0x06002004 RID: 8196
			// RVA: 0x0001A29A File Offset: 0x0001849A
			public void method_0()
			{
				Class723.smethod_5(this.string_0, Color.get_Cyan(), 3300, null);
			}
		}

		// Token: 0x0400192A RID: 6442
		private Class599 class599_0;

		// Token: 0x04001929 RID: 6441
		private readonly OsuModes osuModes_0;

		// Token: 0x06001FEC RID: 8172
		// RVA: 0x000B5BCC File Offset: 0x000B3DCC
		public Class67(Class114 class114_1, OsuModes osuModes_1) : base(class114_1)
		{
			this.osuModes_0 = osuModes_1;
			Class115.smethod_75(new EventHandler(this.method_1));
			Class115.double_8 = 0.0;
			Class115.enum113_0 = Enum113.const_2;
			this.class599_0 = new Class599("Updating package " + Class466.Current.method_3());
		}

		// Token: 0x06001FED RID: 8173
		// RVA: 0x0001A1B3 File Offset: 0x000183B3
		protected override void Dispose(bool bool_2)
		{
			this.class599_0.Dispose();
			base.Dispose(bool_2);
		}

		// Token: 0x06001FF1 RID: 8177
		// RVA: 0x0001A1D5 File Offset: 0x000183D5
		public override void Draw()
		{
			this.class599_0.Draw();
			base.Draw();
		}

		// Token: 0x06001FF2 RID: 8178
		// RVA: 0x0001A1E8 File Offset: 0x000183E8
		public override void imethod_2()
		{
			base.imethod_2();
		}

		// Token: 0x06001FEE RID: 8174
		// RVA: 0x000B5C2C File Offset: 0x000B3E2C
		private void method_1(object sender, EventArgs e)
		{
			Class115.smethod_76(new EventHandler(this.method_1));
			new Thread(new ThreadStart(this.method_2))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x06001FEF RID: 8175
		// RVA: 0x0001A1C7 File Offset: 0x000183C7
		private void method_2()
		{
			this.method_3();
			this.method_4();
		}

		// Token: 0x06001FF0 RID: 8176
		// RVA: 0x000B5C6C File Offset: 0x000B3E6C
		private void method_3()
		{
			VoidDelegate voidDelegate = null;
			Class67.Class442 class = new Class67.Class442();
			class.class296_0 = Class466.Current;
			if (class.class296_0.method_44() == null)
			{
				throw new Exception("Can only update osz2 Packages.");
			}
			Class331.smethod_90();
			Class331.smethod_91();
			Class67.Class443 class2 = new Class67.Class443();
			class2.class442_0 = class;
			List<Struct20> list = class.class296_0.method_44().method_30();
			Class178 class3 = class.class296_0.method_44();
			Class133 class4 = new Class133(string.Format("http://osu.ppy.sh/web/osu-osz2-getfileinfo.php?u={0}&h={1}&s={2}", Class341.class605_20, Class341.class605_17, class.class296_0.int_3));
			this.class599_0.method_0("Dowloading package version information");
			class2.string_0 = null;
			class4.method_0(new Class133.Delegate17(class2.method_0));
			try
			{
				class4.method_2(false);
			}
			catch
			{
			}
			if (class2.string_0 != null && !(class2.string_0.Trim() == "") && !class2.string_0.StartsWith("5\n"))
			{
				string[] array = class2.string_0.Split(new char[]
				{
					'\n'
				});
				string[] array2 = array[0].Split(new char[]
				{
					'|'
				});
				List<Struct20> list2 = new List<Struct20>(array2.Length);
				this.class599_0.method_0("Cross-referencing version information");
				string[] array3 = array2;
				for (int i = 0; i < array3.Length; i++)
				{
					string text = array3[i];
					string[] array4 = text.Split(new char[]
					{
						':'
					});
					string string_ = array4[0];
					int int_ = Convert.ToInt32(array4[1]);
					int int_2 = Convert.ToInt32(array4[2]);
					byte[] byte_ = Class34.smethod_23(array4[3]);
					DateTime dateTime_ = DateTime.FromBinary(Convert.ToInt64(array4[4]));
					DateTime dateTime_2 = DateTime.FromBinary(Convert.ToInt64(array4[5]));
					Struct20 item = new Struct20(string_, int_, int_2, byte_, dateTime_, dateTime_2);
					list2.Add(item);
				}
				this.class599_0.method_0("Downloading and updating files:");
				using (List<Struct20>.Enumerator enumerator = list2.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class67.Class445 class5 = new Class67.Class445();
						class5.class443_0 = class2;
						class5.class442_0 = class;
						class5.struct20_0 = enumerator.Current;
						Class67.Class446 class6 = new Class67.Class446();
						class6.class445_0 = class5;
						class6.class443_0 = class2;
						class6.class442_0 = class;
						List<Struct20> arg_280_0 = list;
						Predicate<Struct20> match = new Predicate<Struct20>(class5.method_0);
						if (arg_280_0.FindIndex(match) == -1)
						{
							if (class3.method_7())
							{
								Struct20 struct20_ = class5.struct20_0;
								if (Class178.smethod_7(struct20_.method_0()))
								{
									continue;
								}
							}
							Class599 arg_2CF_0 = this.class599_0;
							string arg_2CA_0 = "Updating ";
							Struct20 struct20_2 = class5.struct20_0;
							arg_2CF_0.method_0(arg_2CA_0 + struct20_2.method_0() + "...");
							string arg_31E_0 = "http://osu.ppy.sh/web/osu-osz2-getfilecontents.php?u={0}&h={1}&s={2}&f={3}";
							object[] array5 = new object[4];
							array5[0] = Class341.class605_20;
							array5[1] = Class341.class605_17;
							array5[2] = class.class296_0.int_3;
							object[] arg_31B_0 = array5;
							int arg_31B_1 = 3;
							Struct20 struct20_3 = class5.struct20_0;
							arg_31B_0[arg_31B_1] = struct20_3.method_0();
							string string_2 = string.Format(arg_31E_0, array5);
							class6.byte_0 = null;
							Class131 class7 = new Class131(string_2);
							class7.method_0(new Class131.Delegate9(class6.method_0));
							try
							{
								class7.Perform(false);
								goto IL_39A;
							}
							catch
							{
								goto IL_39A;
							}
							IL_357:
							Class178 arg_390_0 = class3;
							Struct20 struct20_4 = class5.struct20_0;
							string arg_390_1 = struct20_4.method_0();
							byte[] arg_390_2 = class6.byte_0;
							Struct20 struct20_5 = class5.struct20_0;
							DateTime arg_390_3 = struct20_5.method_7();
							Struct20 struct20_6 = class5.struct20_0;
							arg_390_0.method_28(arg_390_1, arg_390_2, arg_390_3, struct20_6.method_9(), true);
							continue;
							IL_39A:
							if (class6.byte_0 == null)
							{
								Class67.Class447 class8 = new Class67.Class447();
								class8.class446_0 = class6;
								class8.class445_0 = class5;
								class8.class443_0 = class2;
								class8.class442_0 = class;
								Class67.Class447 arg_3EE_0 = class8;
								string arg_3E9_0 = "Failed to update: Dowloading {0} failed.";
								Struct20 struct20_7 = class5.struct20_0;
								arg_3EE_0.string_0 = string.Format(arg_3E9_0, struct20_7.method_0());
								Class115.class47_0.Add(new VoidDelegate(class8.method_0), false);
								return;
							}
							goto IL_357;
						}
					}
				}
				this.class599_0.method_0("Saving changes...");
				class3.method_32(true);
				Class134.smethod_2(class3);
				this.class599_0.method_0("Updating metadata...");
				string string_3 = string.Format("http://osu.ppy.sh/web/osu-osz2-getrawheader.php?u={0}&h={1}&s={2}", Class341.class605_20, Class341.class605_17, class.class296_0.int_3);
				class2.byte_0 = null;
				Class131 class9 = new Class131(string_3);
				class9.method_0(new Class131.Delegate9(class2.method_1));
				class9.Perform(false);
				if (class2.byte_0 != null && class2.byte_0.Length >= 60)
				{
					int num = Convert.ToInt32(array[1]);
					class2.int_0 = 0;
					list2.ForEach(new Action<Struct20>(class2.method_2));
					Class178.smethod_8(class.class296_0.method_3(), list2, num, (long)(num + class2.int_0));
					using (FileStream fileStream = File.Open(class.class296_0.method_3(), FileMode.Open, FileAccess.Write))
					{
						fileStream.Write(class2.byte_0, 0, class2.byte_0.Length);
					}
					Class47 arg_559_0 = Class115.class47_0;
					if (voidDelegate == null)
					{
						voidDelegate = new VoidDelegate(class.method_0);
					}
					arg_559_0.Add(voidDelegate, false);
					return;
				}
				Class67.Class448 class10 = new Class67.Class448();
				class10.class443_0 = class2;
				class10.class442_0 = class;
				class10.string_0 = "Failed to update: recieving header failed, please try to redownload.";
				Class115.class47_0.Add(new VoidDelegate(class10.method_0), false);
				return;
			}
			Class67.Class444 class11 = new Class67.Class444();
			class11.class443_0 = class2;
			class11.class442_0 = class;
			class11.string_0 = "Failed to update: Could not connect to the update service";
			Class115.class47_0.method_1(new VoidDelegate(class11.method_0), 100, false);
		}

		// Token: 0x06001FF3 RID: 8179
		// RVA: 0x0001A1F0 File Offset: 0x000183F0
		private void method_4()
		{
			Class466.bool_1 = false;
			Class115.smethod_71(this.osuModes_0, false);
		}

		// Token: 0x06001FF4 RID: 8180
		// RVA: 0x0001A204 File Offset: 0x00018404
		internal static void smethod_0()
		{
			Class115.smethod_71(OsuModes.PackageUpdater, true);
		}
	}
}
