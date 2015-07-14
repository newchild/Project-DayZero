using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns17;
using ns24;
using ns27;
using ns29;
using ns35;
using ns8;
using ns9;
using ns90;
using osu;
using osu_common.Helpers;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace ns19
{
	// Token: 0x0200051F RID: 1311
	internal sealed class Class77 : Class61
	{
		// Token: 0x02000520 RID: 1312
		[CompilerGenerated]
		private sealed class Class688
		{
			// Token: 0x02000521 RID: 1313
			private sealed class Class689
			{
				// Token: 0x04002333 RID: 9011
				public Class77.Class688 class688_0;

				// Token: 0x04002334 RID: 9012
				public Class89 class89_0;

				// Token: 0x06002A86 RID: 10886
				// RVA: 0x00020992 File Offset: 0x0001EB92
				public void method_0(object sender, EventArgs e)
				{
					this.class688_0.bool_0 = true;
					Class77.bool_4 = false;
				}

				// Token: 0x06002A87 RID: 10887
				// RVA: 0x000209A6 File Offset: 0x0001EBA6
				public void method_1(object sender, EventArgs e)
				{
					this.class688_0.bool_0 = false;
					Class77.bool_4 = false;
				}

				// Token: 0x06002A88 RID: 10888
				// RVA: 0x000209BA File Offset: 0x0001EBBA
				public void method_2()
				{
					Class115.smethod_37(this.class89_0);
				}
			}

			// Token: 0x04002331 RID: 9009
			public bool bool_0;

			// Token: 0x04002332 RID: 9010
			private static EventHandler eventHandler_0;

			// Token: 0x06002A83 RID: 10883
			// RVA: 0x00112BFC File Offset: 0x00110DFC
			public void method_0()
			{
				Class77.Class688.Class689 class = new Class77.Class688.Class689();
				class.class688_0 = this;
				class.class89_0 = new Class89(Class41.GetString(OsuString.BeatmapImport_FullProcess), false);
				Class89 arg_46_0 = class.class89_0;
				if (Class77.Class688.eventHandler_0 == null)
				{
					Class77.Class688.eventHandler_0 = new EventHandler(Class77.Class688.smethod_0);
				}
				arg_46_0.method_2(Class77.Class688.eventHandler_0);
				class.class89_0.method_3(Class41.GetString(OsuString.General_Confirm), Color.get_YellowGreen(), new EventHandler(class.method_0), true, false, true);
				class.class89_0.method_3(Class41.GetString(OsuString.General_Cancel), Color.get_OrangeRed(), new EventHandler(class.method_1), true, false, true);
				Class115.class47_0.Add(new VoidDelegate(class.method_2), false);
			}

			// Token: 0x06002A84 RID: 10884
			// RVA: 0x0002098A File Offset: 0x0001EB8A
			private static void smethod_0(object sender, EventArgs e)
			{
				Class77.bool_4 = false;
			}
		}

		// Token: 0x0400232B RID: 9003
		internal static bool bool_2;

		// Token: 0x0400232D RID: 9005
		private static bool bool_3 = true;

		// Token: 0x0400232F RID: 9007
		private static bool bool_4;

		// Token: 0x0400232C RID: 9004
		private static Class599 class599_0;

		// Token: 0x0400232A RID: 9002
		private static OsuModes osuModes_0 = OsuModes.Unknown;

		// Token: 0x0400232E RID: 9006
		private static Thread thread_0;

		// Token: 0x04002330 RID: 9008
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_0;

		// Token: 0x06002A74 RID: 10868
		// RVA: 0x001123D8 File Offset: 0x001105D8
		public Class77(Class114 class114_1, OsuModes osuModes_1) : base(class114_1)
		{
			Class77.osuModes_0 = osuModes_1;
			Class115.smethod_75(new EventHandler(this.method_1));
			Class115.double_8 = 0.0;
			Class115.enum113_0 = Enum113.const_2;
			Class77.class599_0 = new Class599(Class41.GetString(OsuString.BeatmapImport_CheckingForNewFiles));
			Class466.smethod_38(new Action<string>(Class77.class599_0.method_0));
		}

		// Token: 0x06002A75 RID: 10869
		// RVA: 0x000208D7 File Offset: 0x0001EAD7
		protected override void Dispose(bool bool_5)
		{
			if (Class77.class599_0 != null)
			{
				Class77.class599_0.Dispose();
				Class77.class599_0 = null;
			}
			base.Dispose(bool_5);
		}

		// Token: 0x06002A79 RID: 10873
		// RVA: 0x00020958 File Offset: 0x0001EB58
		public override void Draw()
		{
			if (Class77.class599_0 != null)
			{
				Class77.class599_0.Draw();
			}
			base.Draw();
		}

		// Token: 0x06002A7A RID: 10874
		// RVA: 0x0001A1E8 File Offset: 0x000183E8
		public override void imethod_2()
		{
			base.imethod_2();
		}

		// Token: 0x06002A77 RID: 10871
		// RVA: 0x0002090C File Offset: 0x0001EB0C
		private void method_1(object sender, EventArgs e)
		{
			Class115.smethod_76(new EventHandler(this.method_1));
			Class77.smethod_3();
		}

		// Token: 0x06002A72 RID: 10866
		// RVA: 0x000208BF File Offset: 0x0001EABF
		internal static bool smethod_0()
		{
			return Class77.bool_3;
		}

		// Token: 0x06002A73 RID: 10867
		// RVA: 0x000208C6 File Offset: 0x0001EAC6
		internal static void smethod_1(bool bool_5)
		{
			Class77.bool_2 = !bool_5;
			Class77.bool_3 = true;
		}

		// Token: 0x06002A76 RID: 10870
		// RVA: 0x000208F7 File Offset: 0x0001EAF7
		internal static bool smethod_2()
		{
			return Class77.thread_0 != null && Class77.thread_0.IsAlive;
		}

		// Token: 0x06002A78 RID: 10872
		// RVA: 0x00020924 File Offset: 0x0001EB24
		internal static void smethod_3()
		{
			if (!Class77.smethod_2())
			{
				Class77.thread_0 = new Thread(new ThreadStart(Class77.smethod_4));
				Class77.thread_0.IsBackground = true;
				Class77.thread_0.Start();
			}
		}

		// Token: 0x06002A7B RID: 10875
		// RVA: 0x00112444 File Offset: 0x00110644
		private static void smethod_4()
		{
			int num = -1;
			if (!Class77.smethod_5() && Class466.list_5.Count <= 0 && Class466.list_4.Count <= 0)
			{
				num = Directory.GetDirectories(Class466.smethod_17()).Length + Directory.GetFiles(Class466.smethod_17()).Length;
				if (Class466.int_1 != num)
				{
					string string;
					if (Class466.int_1 == 0)
					{
						string = Class41.GetString(OsuString.BeatmapImport_TimeToPopulateAnEmptyDatabase);
						Class77.bool_4 = false;
					}
					else if (Class466.int_1 < num)
					{
						string = Class41.GetString(OsuString.BeatmapImport_DetectedNewMapsAdded);
					}
					else
					{
						string = Class41.GetString(OsuString.BeatmapImport_DetectedMapsRemoved);
					}
					if (Class77.class599_0 != null)
					{
						Class77.class599_0.method_0(string);
					}
					Class77.bool_2 = true;
				}
			}
			else
			{
				Class77.bool_2 = false;
			}
			if (Class77.class599_0 != null)
			{
				Class466.smethod_38(new Action<string>(Class77.class599_0.method_0));
			}
			if (Class77.bool_2 && Class77.bool_4 && Class466.list_3.Count > 1000)
			{
				Class77.Class688 class = new Class77.Class688();
				class.bool_0 = false;
				Class115.smethod_87(new VoidDelegate(class.method_0));
				while (Class77.bool_4)
				{
					if (Class115.osuModes_1 != OsuModes.BeatmapImport)
					{
						break;
					}
					Thread.Sleep(50);
				}
				if (!class.bool_0)
				{
					Class115.class47_0.Add(new VoidDelegate(Class77.smethod_7), false);
					Class466.smethod_37();
					return;
				}
			}
			Class466.smethod_11(Class77.bool_2, Class77.bool_4);
			Class466.smethod_37();
			if (num >= 0)
			{
				Class466.int_1 = num;
			}
			Class115.class47_0.Add(new VoidDelegate(Class77.smethod_7), false);
		}

		// Token: 0x06002A7C RID: 10876
		// RVA: 0x001125C8 File Offset: 0x001107C8
		private static bool smethod_5()
		{
			bool result = false;
			string text = Class466.smethod_17();
			string[] files = Directory.GetFiles(Class466.smethod_17());
			for (int i = 0; i < files.Length; i++)
			{
				string text2 = files[i];
				string text3 = Path.GetExtension(text2).ToLower();
				string a;
				if ((a = text3) != null)
				{
					if (!(a == ".db"))
					{
						if (!(a == ".mp3") && !(a == ".osu"))
						{
							if (a == ".osz" || a == ".zip")
							{
								string fileName = Path.GetFileName(text2);
								string text4 = Path.GetFileNameWithoutExtension(text2).Replace("-novid", string.Empty);
								text4 = Class34.smethod_2(text4);
								if (Class77.class599_0 != null)
								{
									Class77.class599_0.method_0(string.Format(Class41.GetString(OsuString.BeatmapImport_Importing), (fileName.Length > 50) ? (fileName.Remove(50) + "...") : fileName));
								}
								int num = 212;
								string path = Path.Combine(Path.GetTempPath(), "osu!");
								string text5 = Path.Combine(path, "_beatmaps");
								Class34.smethod_18(text5);
								Class203 class = new Class203();
								try
								{
									class.method_6(text2, text5, ".*");
									if (class.method_0() > 0)
									{
										StringBuilder stringBuilder = new StringBuilder("Error extracting files: \n");
										for (int j = 0; j < class.list_0.Count; j++)
										{
											stringBuilder.Append(class.list_0[j] + "\n");
										}
										Class723.smethod_4(stringBuilder.ToString());
										bool flag = Class77.smethod_6(text5);
										class.method_13();
										if (!flag)
										{
											throw new Exception("Beatmap missing required files");
										}
									}
									int length = Path.GetFullPath(text).Length;
									int num2 = text4.Length;
									if (length + text4.Length * 2 >= num)
									{
										num2 = Class34.smethod_21(text5) - text5.Length;
									}
									int num3 = length + text4.Length + num2 - 248;
									if (num3 > 0)
									{
										if (num3 >= text4.Length - 1)
										{
											throw new PathTooLongException();
										}
										text4 = text4.Remove(text4.Length - num3);
									}
									FileInfo fileInfo = new FileInfo(text2);
									if ((fileInfo.Attributes & FileAttributes.ReadOnly) > (FileAttributes)0)
									{
										fileInfo.Attributes &= ~FileAttributes.ReadOnly;
									}
									string text6 = text + text4;
									Class34.smethod_20(text5, text6);
									Class466.int_1++;
									if (!Class466.list_4.Contains(text6))
									{
										Class466.list_4.Add(text6);
									}
									Class34.smethod_18(text2);
									goto IL_47F;
								}
								catch (Exception ex)
								{
									if (ex is PathTooLongException)
									{
										Class723.smethod_4(string.Format("File path is too long. Consider renaming the file or containing directory. \nFile: {0}", Path.GetFileName(text2)));
									}
									else
									{
										if (class.method_0() > 0)
										{
											StringBuilder stringBuilder2 = new StringBuilder("Error extracting files: \n");
											for (int k = 0; k < class.list_0.Count; k++)
											{
												stringBuilder2.Append(class.list_0[k] + "\n");
											}
											Class723.smethod_4(stringBuilder2.ToString());
											class.method_13();
										}
										Class723.smethod_4(string.Format(Class41.GetString(OsuString.BeatmapImport_FileCorrupt), fileName));
										Class765.smethod_0(new Class764(ex)
										{
											string_0 = "file corrupt"
										});
									}
									try
									{
										Directory.CreateDirectory(Class466.smethod_18());
										Class34.smethod_14(text2, Class466.smethod_18() + fileName, true, true);
									}
									catch
									{
									}
									try
									{
										Directory.Delete(text5, true);
									}
									catch
									{
									}
									goto IL_47F;
								}
								goto IL_395;
								IL_47F:
								result = true;
								goto IL_476;
							}
							goto IL_476;
						}
						IL_395:
						string fileName2 = Path.GetFileName(text2);
						if (Class77.class599_0 != null)
						{
							Class77.class599_0.method_0(string.Format(Class41.GetString(OsuString.BeatmapImport_Importing), (fileName2.Length > 50) ? (fileName2.Remove(50) + "...") : fileName2));
						}
						Class466.fileSystemWatcher_0.EnableRaisingEvents = false;
						string text7 = Path.Combine(text, Path.GetFileNameWithoutExtension(text2));
						if (!Directory.Exists(text7))
						{
							Directory.CreateDirectory(text7);
							Class466.list_4.Add(text7);
							Class466.int_1++;
						}
						text7 = Path.Combine(text7, fileName2);
						if (!Class34.smethod_14(text2, text7, true, false))
						{
							try
							{
								File.Copy(text2, text7);
							}
							catch
							{
								Class723.smethod_4(string.Format(Class41.GetString(OsuString.BeatmapImport_FileInUse), fileName2));
							}
						}
						Class466.fileSystemWatcher_0.EnableRaisingEvents = true;
						result = true;
					}
					else
					{
						Class34.smethod_18(text2);
					}
				}
				IL_476:;
			}
			return result;
		}

		// Token: 0x06002A7D RID: 10877
		// RVA: 0x00112AC0 File Offset: 0x00110CC0
		private static bool smethod_6(string string_0)
		{
			if (!Directory.Exists(string_0))
			{
				return false;
			}
			bool flag = false;
			int num = 0;
			string[] files = Directory.GetFiles(string_0);
			for (int i = 0; i < files.Length; i++)
			{
				string path = files[i];
				string text = Path.GetExtension(path).Replace(".", string.Empty).ToLower();
				string a;
				if ((a = text) != null)
				{
					if (!(a == "osu"))
					{
						if (a == "ogg" || a == "mp3")
						{
							flag = true;
						}
					}
					else
					{
						num++;
					}
				}
			}
			return flag && num > 0;
		}

		// Token: 0x06002A7E RID: 10878
		// RVA: 0x00112B58 File Offset: 0x00110D58
		private static void smethod_7()
		{
			Class466.bool_1 = false;
			Class77.bool_2 = false;
			Class77.bool_3 = false;
			if (Class77.osuModes_0 != OsuModes.Unknown)
			{
				Class115.smethod_71(Class77.osuModes_0, false);
			}
			Class77.osuModes_0 = OsuModes.Unknown;
			if (Class115.bool_16 && Class115.bool_17)
			{
				Class466.smethod_29();
			}
		}

		// Token: 0x06002A7F RID: 10879
		// RVA: 0x00112BA8 File Offset: 0x00110DA8
		public static void smethod_8(bool bool_5)
		{
			if (Class115.smethod_92())
			{
				return;
			}
			Class77.osuModes_0 = Class115.osuModes_1;
			Class77.bool_4 = bool_5;
			Class77.bool_2 = true;
			Class47 arg_41_0 = Class115.class47_0;
			if (Class77.voidDelegate_0 == null)
			{
				Class77.voidDelegate_0 = new VoidDelegate(Class77.smethod_9);
			}
			arg_41_0.Add(Class77.voidDelegate_0, false);
		}

		// Token: 0x06002A80 RID: 10880
		// RVA: 0x00020971 File Offset: 0x0001EB71
		[CompilerGenerated]
		private static void smethod_9()
		{
			Class115.smethod_71(OsuModes.BeatmapImport, true);
		}
	}
}
