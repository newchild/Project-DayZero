using Newtonsoft.Json;
using ns15;
using ns30;
using ns8;
using osu_common.Helpers;
using osu_common.Updater;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace ns41
{
	// Token: 0x02000284 RID: 644
	internal static class Class214
	{
		// Token: 0x02000285 RID: 645
		[CompilerGenerated]
		private sealed class Class215
		{
			// Token: 0x0400109E RID: 4254
			public DownloadableFileInfo downloadableFileInfo_0;

			// Token: 0x060015DB RID: 5595
			// RVA: 0x00070B50 File Offset: 0x0006ED50
			public void method_0()
			{
				lock (Class214.list_0)
				{
					Class214.list_0.Remove(this.downloadableFileInfo_0);
				}
			}
		}

		// Token: 0x0400109C RID: 4252
		[CompilerGenerated]
		private static Action<DownloadableFileInfo> action_0;

		// Token: 0x04001092 RID: 4242
		private static Delegate26 delegate26_0;

		// Token: 0x04001097 RID: 4247
		public static Enum32 enum32_0;

		// Token: 0x04001094 RID: 4244
		public static Exception exception_0;

		// Token: 0x04001093 RID: 4243
		private static int int_0 = 0;

		// Token: 0x04001091 RID: 4241
		private static List<DownloadableFileInfo> list_0 = new List<DownloadableFileInfo>();

		// Token: 0x04001098 RID: 4248
		private static object object_0 = new object();

		// Token: 0x04001099 RID: 4249
		[CompilerGenerated]
		private static Predicate<DownloadableFileInfo> predicate_0;

		// Token: 0x0400109A RID: 4250
		[CompilerGenerated]
		private static Predicate<DownloadableFileInfo> predicate_1;

		// Token: 0x04001096 RID: 4246
		public static ReleaseStream releaseStream_0;

		// Token: 0x0400108F RID: 4239
		public static string string_0 = "http://osu.ppy.sh/web/check-updates.php";

		// Token: 0x04001090 RID: 4240
		public static string string_1 = "http://m1.ppy.sh/release/";

		// Token: 0x04001095 RID: 4245
		public static string string_2 = string.Empty;

		// Token: 0x0400109B RID: 4251
		[CompilerGenerated]
		private static ThreadStart threadStart_0;

		// Token: 0x0400108E RID: 4238
		private static Thread thread_0;

		// Token: 0x0400109D RID: 4253
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_0;

		// Token: 0x060015CB RID: 5579
		// RVA: 0x0006FE40 File Offset: 0x0006E040
		public static void Check(Delegate26 delegate26_1, ReleaseStream releaseStream_1, ThreadPriority threadPriority_0)
		{
			lock (Class214.object_0)
			{
				if (Class214.thread_0 == null)
				{
					Class214.releaseStream_0 = releaseStream_1;
					Class214.delegate26_0 = delegate26_1;
					Class214.smethod_2(Enum32.const_1);
					if (Class214.threadStart_0 == null)
					{
						Class214.threadStart_0 = new ThreadStart(Class214.smethod_10);
					}
					Class214.thread_0 = new Thread(Class214.threadStart_0);
					Class214.thread_0.IsBackground = true;
					Class214.thread_0.Priority = threadPriority_0;
					Class214.thread_0.Start();
				}
			}
		}

		// Token: 0x060015D1 RID: 5585
		// RVA: 0x000709A4 File Offset: 0x0006EBA4
		public static bool Cleanup(int int_1, bool bool_0)
		{
			int num = Math.Max(2, int_1 / 100);
			while (num-- > 0)
			{
				bool flag = true;
				if (bool_0)
				{
					try
					{
						if (File.Exists("_pending"))
						{
							File.Delete("_pending");
						}
					}
					catch
					{
						flag = false;
					}
					try
					{
						if (Directory.Exists("_pending"))
						{
							Directory.Delete("_pending", true);
						}
					}
					catch
					{
						flag = false;
					}
				}
				try
				{
					if (File.Exists("_staging"))
					{
						File.Delete("_staging");
					}
				}
				catch
				{
					flag = false;
				}
				try
				{
					if (Directory.Exists("_staging"))
					{
						Directory.Delete("_staging", true);
					}
					goto IL_9D;
				}
				catch
				{
					flag = false;
					goto IL_9D;
				}
				IL_91:
				Thread.Sleep(100);
				continue;
				IL_9D:
				if (flag)
				{
					return true;
				}
				goto IL_91;
			}
			return false;
		}

		// Token: 0x060015D2 RID: 5586
		// RVA: 0x00070A8C File Offset: 0x0006EC8C
		public static void Reset(bool bool_0)
		{
			if (bool_0)
			{
				Thread thread = Class214.thread_0;
				if (thread != null && thread.IsAlive)
				{
					thread.Abort();
					while (thread.IsAlive)
					{
						Thread.Sleep(20);
					}
				}
				Class214.thread_0 = null;
			}
			lock (Class214.list_0)
			{
				Class214.list_0.Clear();
			}
			Class214.int_0 = 0;
			Class214.Cleanup(5000, true);
			Class214.smethod_7();
		}

		// Token: 0x060015C9 RID: 5577
		// RVA: 0x0006FB0C File Offset: 0x0006DD0C
		public static float smethod_0()
		{
			float result;
			lock (Class214.list_0)
			{
				Class214.int_0 = Math.Max(Class214.list_0.Count, Class214.int_0);
				switch (Class214.int_0)
				{
				case 0:
					result = 0f;
					break;
				case 1:
					result = ((Class214.list_0.Count > 0) ? Class214.list_0[0].progress : 100f);
					break;
				default:
				{
					float num = (float)((Class214.int_0 - Class214.list_0.Count) * 100);
					foreach (DownloadableFileInfo current in Class214.list_0)
					{
						num += current.progress;
					}
					result = num / (float)(Class214.int_0 * 100) * 100f;
					break;
				}
				}
			}
			return result;
		}

		// Token: 0x060015CA RID: 5578
		// RVA: 0x0006FC0C File Offset: 0x0006DE0C
		public static string smethod_1(bool bool_0)
		{
			switch (Class214.enum32_0)
			{
			case Enum32.const_1:
				return Class41.GetString(OsuString.CommonUpdater_CheckingForUpdates);
			case Enum32.const_2:
			{
				string result;
				lock (Class214.list_0)
				{
					Class214.int_0 = Math.Max(Class214.list_0.Count, Class214.int_0);
					string str = (!bool_0 || Class214.smethod_0() <= 0f) ? string.Empty : (" (" + (int)Class214.smethod_0() + "%)");
					if (Class214.list_0.Count != 0 && Class214.int_0 != 0)
					{
						List<DownloadableFileInfo> arg_C8_0 = Class214.list_0;
						if (Class214.predicate_0 == null)
						{
							Class214.predicate_0 = new Predicate<DownloadableFileInfo>(Class214.smethod_8);
						}
						int count = arg_C8_0.FindAll(Class214.predicate_0).Count;
						if (count > 1)
						{
							if (Class214.int_0 == Class214.list_0.Count)
							{
								result = string.Format(Class41.GetString(OsuString.CommonUpdater_DownloadingRequiredFiles), Class214.int_0) + str;
							}
							else
							{
								result = string.Format(Class41.GetString(OsuString.CommonUpdater_DownloadingRequiredFiles2), Class214.int_0 - Class214.list_0.Count, Class214.int_0) + str;
							}
						}
						else
						{
							List<DownloadableFileInfo> arg_169_0 = Class214.list_0;
							if (Class214.predicate_1 == null)
							{
								Class214.predicate_1 = new Predicate<DownloadableFileInfo>(Class214.smethod_9);
							}
							DownloadableFileInfo downloadableFileInfo = arg_169_0.FindLast(Class214.predicate_1);
							if (downloadableFileInfo != null)
							{
								if (downloadableFileInfo.isPatching)
								{
									result = string.Format(Class41.GetString(OsuString.CommonUpdater_PatchingFilePercentage), downloadableFileInfo.filename) + str;
								}
								else
								{
									result = string.Format(Class41.GetString(OsuString.CommonUpdater_DownloadingFile), downloadableFileInfo.filename + ((downloadableFileInfo.url_patch != null) ? "_patch" : string.Empty)) + str;
								}
							}
							else
							{
								result = Class41.GetString(OsuString.CommonUpdater_PerformingUpdates);
							}
						}
					}
					else
					{
						result = Class41.GetString(OsuString.CommonUpdater_PerformingUpdates);
					}
				}
				return result;
			}
			case Enum32.const_3:
				return Class41.GetString(OsuString.CommonUpdater_ErrorOccurred);
			case Enum32.const_4:
				return Class41.GetString(OsuString.CommonUpdater_RestartRequired);
			default:
				return Class41.GetString(OsuString.CommonUpdater_Updated);
			}
		}

		// Token: 0x060015D6 RID: 5590
		// RVA: 0x00070B10 File Offset: 0x0006ED10
		[CompilerGenerated]
		private static void smethod_10()
		{
			try
			{
				Enum32 enum32_ = Class214.smethod_3();
				Class214.smethod_2(enum32_);
			}
			catch
			{
				Class214.smethod_2(Enum32.const_0);
			}
			Class214.delegate26_0 = null;
			Class214.thread_0 = null;
		}

		// Token: 0x060015D7 RID: 5591
		// RVA: 0x00013678 File Offset: 0x00011878
		[CompilerGenerated]
		private static void smethod_11(DownloadableFileInfo downloadableFileInfo_0)
		{
			Class214.list_0.Remove(downloadableFileInfo_0);
		}

		// Token: 0x060015D8 RID: 5592
		// RVA: 0x0000653E File Offset: 0x0000473E
		[CompilerGenerated]
		private static void smethod_12()
		{
		}

		// Token: 0x060015CC RID: 5580
		// RVA: 0x0001363B File Offset: 0x0001183B
		private static void smethod_2(Enum32 enum32_1)
		{
			if (Class214.enum32_0 == enum32_1)
			{
				return;
			}
			Class214.enum32_0 = enum32_1;
			if (Class214.delegate26_0 != null)
			{
				Class214.delegate26_0(enum32_1);
			}
		}

		// Token: 0x060015CD RID: 5581
		// RVA: 0x0006FED4 File Offset: 0x0006E0D4
		private static Enum32 smethod_3()
		{
			Enum32 result;
			try
			{
				Class53.smethod_0();
				Class214.Cleanup(10000, false);
				List<DownloadableFileInfo> list = null;
				string text = string.Empty;
				try
				{
					Class133 class = new Class133(string.Concat(new object[]
					{
						Class214.string_0,
						"?action=check&stream=",
						Class214.releaseStream_0.ToString().ToLower(),
						"&time=",
						DateTime.Now.Ticks
					}));
					text = class.method_2(true);
					if (text == "fallback")
					{
						result = Enum32.const_6;
						return result;
					}
					list = JsonConvert.DeserializeObject<List<DownloadableFileInfo>>(text);
				}
				catch (Exception ex)
				{
					Class214.exception_0 = ex;
					Class214.string_2 = text;
					result = Enum32.const_3;
					return result;
				}
				if (list != null)
				{
					if (list.Count != 0)
					{
						bool flag;
						List<DownloadableFileInfo> list2;
						while (true)
						{
							IL_1E5:
							flag = Directory.Exists("_pending");
							list2 = new List<DownloadableFileInfo>();
							using (List<DownloadableFileInfo>.Enumerator enumerator = list.GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									DownloadableFileInfo current = enumerator.Current;
									if (flag)
									{
										string text2 = "_pending/" + current.filename;
										if (File.Exists(text2))
										{
											if (Class214.smethod_4(text2, false) == current.file_hash)
											{
												continue;
											}
										}
										else if (File.Exists(current.filename))
										{
											if (Class214.smethod_4(current.filename, true) == current.file_hash)
											{
												continue;
											}
										}
										Class214.Reset(false);
										goto IL_1E5;
									}
									if (!File.Exists(current.filename))
									{
										list2.Add(current);
									}
									else if (Class214.smethod_4(current.filename, true) != current.file_hash)
									{
										list2.Add(current);
									}
									else if (current.filename == "osu!.exe" && Class214.smethod_4(current.filename, true) != Class214.smethod_4(current.filename, false))
									{
										Class53.smethod_2();
										goto IL_1E5;
									}
								}
								break;
							}
						}
						if (flag)
						{
							result = (Class214.smethod_6(false) ? Enum32.const_5 : Enum32.const_4);
							return result;
						}
						if (list2.Count == 0)
						{
							result = Enum32.const_0;
							return result;
						}
						Class214.int_0 = list2.Count;
						if (!Directory.Exists("_staging"))
						{
							DirectoryInfo directoryInfo = Directory.CreateDirectory("_staging");
							directoryInfo.Attributes = (FileAttributes.Hidden | FileAttributes.Directory);
						}
						Class214.smethod_2(Enum32.const_2);
						lock (Class214.list_0)
						{
							Class214.list_0.AddRange(list2);
						}
						using (List<DownloadableFileInfo>.Enumerator enumerator2 = list2.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								VoidDelegate voidDelegate = null;
								Class214.Class215 class2 = new Class214.Class215();
								class2.downloadableFileInfo_0 = enumerator2.Current;
								if (File.Exists(class2.downloadableFileInfo_0.filename))
								{
									string text3 = Class214.smethod_4(class2.downloadableFileInfo_0.filename, false);
									try
									{
										Class133 class3 = new Class133(string.Concat(new object[]
										{
											Class214.string_0,
											"?action=path&stream=",
											Class214.releaseStream_0.ToString().ToLower(),
											"&target=",
											class2.downloadableFileInfo_0.file_version,
											"&existing=",
											text3,
											"&time=",
											DateTime.Now.Ticks
										}));
										List<DownloadableFileInfo> list3 = JsonConvert.DeserializeObject<List<DownloadableFileInfo>>(class3.method_2(false));
										if (list3.Count > 1)
										{
											File.Copy(class2.downloadableFileInfo_0.filename, "_staging/" + class2.downloadableFileInfo_0.filename);
											bool flag2 = false;
											lock (Class214.list_0)
											{
												Class214.list_0.AddRange(list3.GetRange(0, list3.Count - 1));
											}
											Class214.int_0 += list3.Count - 1;
											try
											{
												foreach (DownloadableFileInfo current2 in list3)
												{
													try
													{
														if (current2.file_version == class2.downloadableFileInfo_0.file_version)
														{
															if (Class214.smethod_4("_staging/" + class2.downloadableFileInfo_0.filename, false) != class2.downloadableFileInfo_0.file_hash)
															{
																throw new Exception("patching failed to end with correct checksum.");
															}
															flag2 = true;
															break;
														}
														else
														{
															"_staging/" + current2.filename + "_patch";
															current2.Perform(true);
														}
													}
													finally
													{
														lock (Class214.list_0)
														{
															Class214.list_0.Remove(current2);
														}
													}
												}
												if (flag2)
												{
													lock (Class214.list_0)
													{
														Class214.list_0.Remove(class2.downloadableFileInfo_0);
													}
													continue;
												}
											}
											finally
											{
												lock (Class214.list_0)
												{
													List<DownloadableFileInfo> arg_51C_0 = list3;
													if (Class214.action_0 == null)
													{
														Class214.action_0 = new Action<DownloadableFileInfo>(Class214.smethod_11);
													}
													arg_51C_0.ForEach(Class214.action_0);
												}
											}
										}
									}
									catch
									{
									}
								}
								DownloadableFileInfo arg_56A_0 = class2.downloadableFileInfo_0;
								if (voidDelegate == null)
								{
									voidDelegate = new VoidDelegate(class2.method_0);
								}
								VoidDelegate arg_56A_1 = voidDelegate;
								if (Class214.voidDelegate_0 == null)
								{
									Class214.voidDelegate_0 = new VoidDelegate(Class214.smethod_12);
								}
								arg_56A_0.PerformThreaded(arg_56A_1, Class214.voidDelegate_0);
							}
							goto IL_5E0;
						}
						IL_58B:
						foreach (DownloadableFileInfo current3 in Class214.list_0)
						{
							if (current3.Error != null)
							{
								Class214.exception_0 = current3.Error;
								result = Enum32.const_3;
								return result;
							}
						}
						Thread.Sleep(100);
						IL_5E0:
						if (Class214.list_0.Count > 0)
						{
							goto IL_58B;
						}
						if (Class214.enum32_0 == Enum32.const_2)
						{
							if (Directory.Exists("_pending"))
							{
								Directory.Delete("_pending", true);
							}
							Class34.smethod_20("_staging", "_pending");
							Class53.dictionary_0["_ReleaseStream"] = Class214.releaseStream_0.ToString();
							result = (Class214.smethod_6(false) ? Enum32.const_5 : Enum32.const_4);
							return result;
						}
						result = Enum32.const_0;
						return result;
					}
				}
				Class214.exception_0 = new Exception("update file returned no results");
				result = Enum32.const_3;
			}
			catch (ThreadAbortException)
			{
				foreach (DownloadableFileInfo current4 in Class214.list_0)
				{
					current4.Abort();
				}
				result = Enum32.const_0;
			}
			catch (Exception ex2)
			{
				Class214.exception_0 = ex2;
				result = Enum32.const_3;
			}
			finally
			{
				Class53.smethod_1();
				Class214.thread_0 = null;
			}
			return result;
		}

		// Token: 0x060015CE RID: 5582
		// RVA: 0x0007073C File Offset: 0x0006E93C
		private static string smethod_4(string string_3, bool bool_0)
		{
			if (!File.Exists(string_3))
			{
				return null;
			}
			string result;
			if (bool_0)
			{
				try
				{
					if (!Class53.dictionary_0.ContainsKey("h_" + string_3))
					{
						Class53.dictionary_0["h_" + string_3] = Class214.smethod_4(string_3, false);
					}
					result = Class53.dictionary_0["h_" + string_3];
					return result;
				}
				catch (Exception)
				{
				}
			}
			try
			{
				using (Stream stream = File.Open(string_3, FileMode.Open, FileAccess.Read, FileShare.Read))
				{
					MD5 mD = MD5.Create();
					byte[] array = mD.ComputeHash(stream);
					StringBuilder stringBuilder = new StringBuilder();
					for (int i = 0; i < array.Length; i++)
					{
						stringBuilder.Append(array[i].ToString("x2"));
					}
					result = stringBuilder.ToString();
				}
			}
			catch (Exception)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060015CF RID: 5583
		// RVA: 0x00070834 File Offset: 0x0006EA34
		private static bool smethod_5(string string_3, string string_4, int int_1, int int_2, bool bool_0)
		{
			int millisecondsTimeout = int_1 / int_2;
			try
			{
				Class34.smethod_18(string_4 + "_old");
				goto IL_5C;
			}
			catch
			{
				goto IL_5C;
			}
			try
			{
				IL_1A:
				if (bool_0)
				{
					Class34.smethod_18(string_4);
				}
				else
				{
					File.Delete(string_4);
				}
			}
			catch
			{
			}
			try
			{
				File.Move(string_3, string_4);
				bool result = true;
				return result;
			}
			catch
			{
				try
				{
					File.Copy(string_3, string_4, true);
					Class34.smethod_18(string_3);
					bool result = true;
					return result;
				}
				catch
				{
				}
			}
			Thread.Sleep(millisecondsTimeout);
			IL_5C:
			if (int_2-- <= 0)
			{
				return false;
			}
			goto IL_1A;
		}

		// Token: 0x060015D0 RID: 5584
		// RVA: 0x000708E0 File Offset: 0x0006EAE0
		public static bool smethod_6(bool bool_0)
		{
			if (!Directory.Exists("_pending"))
			{
				return true;
			}
			Class53.smethod_0();
			try
			{
				string[] files = Directory.GetFiles("_pending");
				for (int i = 0; i < files.Length; i++)
				{
					string text = files[i];
					if (new FileInfo(text).Length == 0L)
					{
						Class34.smethod_18(text);
					}
					else
					{
						string fileName = Path.GetFileName(text);
						if (!Class214.smethod_5(text, fileName, 200, 5, bool_0))
						{
							bool result = false;
							return result;
						}
						Class53.dictionary_0["h_" + fileName] = Class214.smethod_4(fileName, false);
					}
				}
			}
			catch
			{
				bool result = false;
				return result;
			}
			Class214.Cleanup(5000, true);
			Class53.smethod_1();
			return true;
		}

		// Token: 0x060015D3 RID: 5587
		// RVA: 0x0001365E File Offset: 0x0001185E
		public static void smethod_7()
		{
			Class214.exception_0 = null;
			Class214.string_2 = string.Empty;
		}

		// Token: 0x060015D4 RID: 5588
		// RVA: 0x00013670 File Offset: 0x00011870
		[CompilerGenerated]
		private static bool smethod_8(DownloadableFileInfo downloadableFileInfo_0)
		{
			return downloadableFileInfo_0.isRunning;
		}

		// Token: 0x060015D5 RID: 5589
		// RVA: 0x00013670 File Offset: 0x00011870
		[CompilerGenerated]
		private static bool smethod_9(DownloadableFileInfo downloadableFileInfo_0)
		{
			return downloadableFileInfo_0.isRunning;
		}
	}
}
