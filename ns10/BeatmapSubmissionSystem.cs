using ns15;
using ns23;
using ns24;
using ns25;
using ns26;
using ns29;
using ns30;
using ns31;
using ns40;
using ns64;
using ns8;
using ns80;
using osu.GameModes.Edit;
using osu_common;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace ns10
{
	// Token: 0x02000664 RID: 1636
	internal sealed class BeatmapSubmissionSystem : Form2
	{
		// Token: 0x02000665 RID: 1637
		[CompilerGenerated]
		private sealed class Class866
		{
			// Token: 0x04002F3D RID: 12093
			public BeatmapSubmissionSystem beatmapSubmissionSystem_0;

			// Token: 0x04002F3C RID: 12092
			public bool bool_0;

			// Token: 0x060032F9 RID: 13049
			// RVA: 0x001579F4 File Offset: 0x00155BF4
			public void method_0()
			{
				using (Class297 class = new Class301(true))
				{
					Class296 current = Class466.Current;
					bool flag = false;
					try
					{
						for (int i = 0; i < this.beatmapSubmissionSystem_0.list_0.Count; i++)
						{
							Class296 class2 = this.beatmapSubmissionSystem_0.list_0[i];
							if (class2.int_3 != this.beatmapSubmissionSystem_0.int_2 || class2.int_2 != this.beatmapSubmissionSystem_0.int_3[i])
							{
								Class296 expr_55 = class2;
								Class466.smethod_21(expr_55);
								Class331.smethod_33(expr_55);
								class.method_8(class2, Mods.None);
								class.method_0();
								class2.int_3 = this.beatmapSubmissionSystem_0.int_2;
								class2.int_2 = this.beatmapSubmissionSystem_0.int_3[i];
								class.method_3(false, false, false);
								flag = true;
							}
							class2.method_19(class2.method_5());
						}
					}
					catch
					{
					}
					if (flag)
					{
						Class296 expr_D3 = current;
						Class466.smethod_21(expr_D3);
						Class331.smethod_33(expr_D3);
						this.beatmapSubmissionSystem_0.editor_0.method_3(current, false, false);
					}
					this.bool_0 = true;
				}
			}
		}

		// Token: 0x02000666 RID: 1638
		[CompilerGenerated]
		private sealed class Class867
		{
			// Token: 0x04002F3E RID: 12094
			public BeatmapSubmissionSystem.Class866 class866_0;

			// Token: 0x04002F3F RID: 12095
			public string[] string_0;

			// Token: 0x060032FB RID: 13051
			// RVA: 0x00025AF0 File Offset: 0x00023CF0
			public void method_0()
			{
				this.class866_0.beatmapSubmissionSystem_0.string_2 = this.string_0[3];
			}
		}

		// Token: 0x02000667 RID: 1639
		[CompilerGenerated]
		private sealed class Class868
		{
			// Token: 0x04002F40 RID: 12096
			public BeatmapSubmissionSystem beatmapSubmissionSystem_0;

			// Token: 0x04002F42 RID: 12098
			public Exception exception_0;

			// Token: 0x04002F41 RID: 12097
			public string string_0;

			// Token: 0x060032FD RID: 13053
			// RVA: 0x00157B24 File Offset: 0x00155D24
			public void method_0()
			{
				if (this.string_0 != null)
				{
					this.beatmapSubmissionSystem_0.method_11(this.string_0.Split(new char[]
					{
						'\n'
					}), 1);
				}
				if (!this.beatmapSubmissionSystem_0.bool_3)
				{
					IWin32Window arg_93_0 = this.beatmapSubmissionSystem_0;
					string arg_85_0 = Class41.GetString(OsuString.BeatmapSubmissionSystem_ErrorDuringUpload);
					string arg_80_0;
					if ((arg_80_0 = this.beatmapSubmissionSystem_0.string_0) == null)
					{
						arg_80_0 = (this.string_0 ?? this.exception_0.Message);
					}
					MessageBox.Show(arg_93_0, string.Format(arg_85_0, arg_80_0.Trim(new char[]
					{
						'\n',
						' '
					})), "osu!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
				}
				this.beatmapSubmissionSystem_0.Close();
			}
		}

		// Token: 0x02000668 RID: 1640
		[CompilerGenerated]
		private sealed class Class869
		{
			// Token: 0x04002F43 RID: 12099
			public BeatmapSubmissionSystem beatmapSubmissionSystem_0;

			// Token: 0x04002F44 RID: 12100
			public string string_0;

			// Token: 0x060032FF RID: 13055
			// RVA: 0x00025B0A File Offset: 0x00023D0A
			public void method_0()
			{
				this.beatmapSubmissionSystem_0.status.Text = this.string_0;
			}
		}

		// Token: 0x02000669 RID: 1641
		[CompilerGenerated]
		private sealed class Class870
		{
			// Token: 0x04002F46 RID: 12102
			public BeatmapSubmissionSystem beatmapSubmissionSystem_0;

			// Token: 0x04002F45 RID: 12101
			public double double_0;

			// Token: 0x04002F47 RID: 12103
			public long long_0;

			// Token: 0x04002F48 RID: 12104
			public long long_1;

			// Token: 0x06003301 RID: 13057
			// RVA: 0x00157BD8 File Offset: 0x00155DD8
			public void method_0()
			{
				float num = (float)this.long_0 / (float)this.long_1 * 100f;
				this.beatmapSubmissionSystem_0.progressBar1.Value = (int)num;
				int num2 = (int)((double)(this.long_1 - this.long_0) / this.double_0) % 60;
				int num3 = (int)((double)(this.long_1 - this.long_0) / this.double_0) / 60 + ((num2 > 20) ? 1 : 0);
				string str = "";
				if (num > 0f)
				{
					if (num3 >= 1)
					{
						str = string.Format("{0:0.0}% ({1} minute{2} remaining)", num, num3, (num3 != 1) ? "s" : "");
					}
					else if (num2 > 0)
					{
						str = string.Format("{0:0.0}% ({1} second{2} remaining)", num, num2, (num2 != 1) ? "s" : "");
					}
					else
					{
						str = string.Format("{0:0.0}%", num);
					}
				}
				string text = this.beatmapSubmissionSystem_0.status.Text;
				int num4 = text.IndexOf("...");
				if (num4 > 0)
				{
					text = text.Remove(num4) + "... " + str;
					this.beatmapSubmissionSystem_0.method_15(text);
				}
			}
		}

		// Token: 0x04002F3B RID: 12091
		[CompilerGenerated]
		private static Action<Class296> action_0;

		// Token: 0x04002F03 RID: 12035
		private readonly BackgroundWorker backgroundWorker_0 = new BackgroundWorker
		{
			WorkerSupportsCancellation = true
		};

		// Token: 0x04002F04 RID: 12036
		private readonly bool bool_1;

		// Token: 0x04002F05 RID: 12037
		private readonly bool bool_2;

		// Token: 0x04002F09 RID: 12041
		private bool bool_3;

		// Token: 0x04002F0A RID: 12042
		private bool bool_4 = true;

		// Token: 0x04002F0F RID: 12047
		private bool bool_5;

		// Token: 0x04002F13 RID: 12051
		private bool bool_6;

		// Token: 0x04002F14 RID: 12052
		private bool bool_7;

		// Token: 0x04002F22 RID: 12066
		private Button buttonCancel;

		// Token: 0x04002F2D RID: 12077
		private Button buttonHelpForum;

		// Token: 0x04002F32 RID: 12082
		private Button buttonModdingQueues;

		// Token: 0x04002F38 RID: 12088
		private Button buttonRankingCriteria;

		// Token: 0x04002F2F RID: 12079
		private Button buttonSubmissionFAQ;

		// Token: 0x04002F20 RID: 12064
		private Button buttonSubmit;

		// Token: 0x04002F26 RID: 12070
		private Button buttonUpload;

		// Token: 0x04002F27 RID: 12071
		private CheckBox checkLoad;

		// Token: 0x04002F28 RID: 12072
		private CheckBox checkNotify;

		// Token: 0x04002F08 RID: 12040
		private Class132 class132_0;

		// Token: 0x04002F15 RID: 12053
		private Class178 class178_0;

		// Token: 0x04002F16 RID: 12054
		private Class178 class178_1;

		// Token: 0x04002F3A RID: 12090
		[CompilerGenerated]
		private static Converter<string, int> converter_0;

		// Token: 0x04002F10 RID: 12048
		private DateTime dateTime_0;

		// Token: 0x04002F19 RID: 12057
		private double double_0;

		// Token: 0x04002F17 RID: 12055
		private Editor editor_0;

		// Token: 0x04002F1A RID: 12058
		private IContainer icontainer_0;

		// Token: 0x04002F0B RID: 12043
		private int int_0;

		// Token: 0x04002F0E RID: 12046
		private int int_1;

		// Token: 0x04002F11 RID: 12049
		private int int_2;

		// Token: 0x04002F12 RID: 12050
		private int[] int_3;

		// Token: 0x04002F18 RID: 12056
		private int int_4;

		// Token: 0x04002F1C RID: 12060
		private Label label1;

		// Token: 0x04002F31 RID: 12081
		private Label label10;

		// Token: 0x04002F29 RID: 12073
		private Label label5;

		// Token: 0x04002F2A RID: 12074
		private Label label6;

		// Token: 0x04002F37 RID: 12087
		private Label label7;

		// Token: 0x04002F2E RID: 12078
		private Label label8;

		// Token: 0x04002F2C RID: 12076
		private Label label9;

		// Token: 0x04002F30 RID: 12080
		private Label labelPreSubmissionInfo;

		// Token: 0x04002F02 RID: 12034
		private readonly List<Class296> list_0;

		// Token: 0x04002F07 RID: 12039
		private long long_0;

		// Token: 0x04002F25 RID: 12069
		private Panel panel1;

		// Token: 0x04002F2B RID: 12075
		private Panel panel2;

		// Token: 0x04002F36 RID: 12086
		private Panel panel3;

		// Token: 0x04002F35 RID: 12085
		private Panel panel4;

		// Token: 0x04002F34 RID: 12084
		private Panel panel5;

		// Token: 0x04002F33 RID: 12083
		private Panel panel6;

		// Token: 0x04002F1D RID: 12061
		private Panel panelForum;

		// Token: 0x04002F23 RID: 12067
		private Panel panelMain;

		// Token: 0x04002F39 RID: 12089
		[CompilerGenerated]
		private static Predicate<Class296> predicate_0;

		// Token: 0x04002F21 RID: 12065
		private ProgressBar progressBar1;

		// Token: 0x04002F1F RID: 12063
		private RadioButton radioButton1;

		// Token: 0x04002F1E RID: 12062
		private RadioButton radioButton2;

		// Token: 0x04002F24 RID: 12068
		private Label status;

		// Token: 0x04002F06 RID: 12038
		private string string_0;

		// Token: 0x04002F0C RID: 12044
		private string string_1;

		// Token: 0x04002F0D RID: 12045
		private string string_2;

		// Token: 0x04002F1B RID: 12059
		private TextBox textMessage;

		// Token: 0x060032D5 RID: 13013
		// RVA: 0x00154F74 File Offset: 0x00153174
		internal BeatmapSubmissionSystem(Editor editor_1, bool bool_8, bool bool_9)
		{
			this.editor_0 = editor_1;
			this.bool_1 = bool_8;
			this.bool_2 = bool_9;
			this.InitializeComponent();
			Editor.smethod_3(true);
			this.checkLoad.Checked = Class341.class606_35;
			this.checkNotify.Checked = Class341.class606_48;
			List<Class296> arg_8F_0 = Class466.list_3;
			if (BeatmapSubmissionSystem.predicate_0 == null)
			{
				BeatmapSubmissionSystem.predicate_0 = new Predicate<Class296>(BeatmapSubmissionSystem.smethod_3);
			}
			this.list_0 = arg_8F_0.FindAll(BeatmapSubmissionSystem.predicate_0);
			Class809.smethod_37(bStatus.Submitting, false);
			this.backgroundWorker_0.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.backgroundWorker_0_RunWorkerCompleted);
			this.backgroundWorker_0.DoWork += new DoWorkEventHandler(this.backgroundWorker_0_DoWork);
			this.backgroundWorker_0.RunWorkerAsync();
		}

		// Token: 0x060032D9 RID: 13017
		// RVA: 0x0015522C File Offset: 0x0015342C
		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			string text = string.Empty;
			if (Class466.Current.string_5 != Class115.class861_0.Name && (Class115.class861_0.enum30_0 & Enum30.flag_2) == Enum30.flag_0)
			{
				this.string_0 = Class41.GetString(OsuString.BeatmapSubmissionSystem_OwnershipError);
				return;
			}
			string text2 = this.method_17();
			if (text2 != null && File.Exists(text2))
			{
				try
				{
					this.class178_0 = new Class178(text2);
					(BitConverter.ToString(this.class178_0.method_4()) + BitConverter.ToString(this.class178_0.method_0())).Replace("-", "");
				}
				catch
				{
				}
				text = Class33.smethod_1(text2);
			}
			int num = this.method_9();
			string text3 = this.method_10();
			string text4 = string.Format("http://osu.ppy.sh/web/osu-osz2-bmsubmit-getid.php?u={0}&h={1}&s={2}&b={3}&z={4}", new object[]
			{
				Class341.class605_20,
				Class341.class605_17,
				num,
				text3,
				text
			});
			string text5 = string.Empty;
			try
			{
				Class133 class = new Class133(text4);
				text5 = class.method_2(false);
			}
			catch (Exception)
			{
			}
			if (this.method_12(e))
			{
				return;
			}
			if (string.IsNullOrEmpty(text5))
			{
				this.string_0 = Class41.GetString(OsuString.BeatmapSubmissionSystem_BSSConnectFailed) + Class41.GetString(OsuString.BeatmapSubmissionSystem_CheckConnection);
				return;
			}
			string[] array = text5.Split(new char[]
			{
				'\n'
			});
			if (this.method_11(array, 6))
			{
				return;
			}
			this.int_2 = Convert.ToInt32(array[1]);
			string[] arg_1A6_0 = array[2].Split(new char[]
			{
				','
			});
			if (BeatmapSubmissionSystem.converter_0 == null)
			{
				BeatmapSubmissionSystem.converter_0 = new Converter<string, int>(BeatmapSubmissionSystem.smethod_4);
			}
			this.int_3 = Array.ConvertAll<string, int>(arg_1A6_0, BeatmapSubmissionSystem.converter_0);
			this.bool_6 = (array[3] == "1" || this.class178_0 == null);
			int.TryParse(array[4], out this.int_4);
			this.bool_7 = (array.Length > 5 && array[5] == "1");
		}

		// Token: 0x060032DC RID: 13020
		// RVA: 0x00155590 File Offset: 0x00153790
		private void backgroundWorker_0_DoWork_1(object sender, DoWorkEventArgs e)
		{
			MethodInvoker methodInvoker = null;
			BeatmapSubmissionSystem.Class866 class = new BeatmapSubmissionSystem.Class866();
			class.beatmapSubmissionSystem_0 = this;
			class.bool_0 = false;
			this.method_15(Class41.GetString(OsuString.BeatmapSubmissionSystem_SynchronisingMaps));
			Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
			if (this.method_12(e))
			{
				return;
			}
			string text = string.Format("http://osu.ppy.sh/web/osu-get-beatmap-topic.php?u={0}&h={1}&s={2}", Class341.class605_20, Class341.class605_17, this.int_2);
			Class133 class2 = new Class133(text);
			string text2 = string.Empty;
			try
			{
				text2 = class2.method_2(false);
				if (!string.IsNullOrEmpty(text2) && text2[0] == '0')
				{
					BeatmapSubmissionSystem.Class867 class3 = new BeatmapSubmissionSystem.Class867();
					class3.class866_0 = class;
					class3.string_0 = text2.Split(new char[]
					{
						'\u0003'
					});
					this.int_1 = int.Parse(class3.string_0[1]);
					base.Invoke(new MethodInvoker(class3.method_0));
				}
				goto IL_EE;
			}
			catch
			{
				goto IL_EE;
			}
			IL_E7:
			Thread.Sleep(100);
			IL_EE:
			if (!class.bool_0)
			{
				goto IL_E7;
			}
			if (this.method_12(e))
			{
				return;
			}
			this.method_15(Class41.GetString(OsuString.BeatmapSubmissionSystem_CreatingPackage));
			string text3 = Path.GetTempPath() + this.int_2 + ".osz2";
			this.class178_1 = Class466.Current.method_64(text3, false);
			(BitConverter.ToString(this.class178_1.method_4()) + BitConverter.ToString(this.class178_1.method_0())).Replace("-", "");
			if (this.class178_1 == null)
			{
				this.string_0 = Class41.GetString(OsuString.BeatmapSubmissionSystem_CouldntCreatePackage) + Class41.GetString(OsuString.BeatmapSubmissionSystem_ExtraDiskSpace);
				this.method_14("-1", null);
				return;
			}
			this.long_0 = new FileInfo(this.class178_1.method_15()).Length;
			if (this.method_12(e))
			{
				return;
			}
			base.Invoke(new MethodInvoker(this.method_18));
			bool flag = this.list_0[0].string_14.Contains("Marathon");
			if (this.long_0 > 33554432L && !flag)
			{
				this.string_0 = Class41.GetString(OsuString.BeatmapSubmissionSystem_UploadFailed) + Class41.GetString(OsuString.BeatmapSubmissionSystem_BeatmapTooLarge);
				this.method_14("-1", null);
				return;
			}
			if (this.list_0.Count < 2 && !flag)
			{
				if (methodInvoker == null)
				{
					methodInvoker = new MethodInvoker(this.method_19);
				}
				base.Invoke(methodInvoker);
			}
			string string_ = string.Format("http://osu.ppy.sh/web/osu-osz2-bmsubmit-upload.php?u={0}&h={1}&t={2}&z={3}&s={4}", new object[]
			{
				Class341.class605_20,
				Class341.class605_17,
				this.bool_6 ? "1" : "2",
				"",
				this.int_2
			});
			byte[] byte_;
			if (!this.bool_6)
			{
				this.method_15(Class41.GetString(OsuString.BeatmapSubmissionSystem_PreparingChanges));
				this.dateTime_0 = DateTime.Now;
				Class51 class4 = new Class51();
				class4.method_0(new Delegate3(this.method_13));
				using (MemoryStream memoryStream = new MemoryStream())
				{
					class4.method_6(this.class178_0.method_15(), text3, memoryStream, Enum7.const_0);
					byte_ = memoryStream.ToArray();
					goto IL_33D;
				}
			}
			byte_ = File.ReadAllBytes(text3);
			IL_33D:
			if (this.method_12(e))
			{
				return;
			}
			this.method_15((!this.bool_4) ? Class41.GetString(OsuString.BeatmapSubmissionSystem_SendingChanges) : Class41.GetString(OsuString.BeatmapSubmissionSystem_Uploading));
			this.class132_0 = new Class132(string_, byte_, "osz2", "0");
			this.class132_0.method_4(180000);
			this.class132_0.method_5(new Class129.Delegate6(this.method_20));
			this.class132_0.method_6(new Class132.Delegate11(this.method_14));
			Class169.smethod_0(this.class132_0);
			this.dateTime_0 = DateTime.Now;
		}

		// Token: 0x060032E2 RID: 13026
		// RVA: 0x00155BC4 File Offset: 0x00153DC4
		private void backgroundWorker_0_DoWork_2(object sender, DoWorkEventArgs e)
		{
			string str;
			if (this.list_0[0].Artist.Length == 0)
			{
				str = this.list_0[0].Title;
			}
			else
			{
				str = this.list_0[0].string_12;
			}
			List<PlayModes> list = new List<PlayModes>();
			foreach (Class296 current in this.list_0)
			{
				if (!list.Contains(current.method_5()))
				{
					list.Add(current.method_5());
				}
			}
			if (list.Count > 1 || list[0] != PlayModes.Osu)
			{
				string text = string.Empty;
				foreach (PlayModes current2 in list)
				{
					text = text + current2 + "|";
				}
				text = text.TrimEnd(new char[]
				{
					'|'
				});
				str = str + " [" + text + "]";
			}
			this.method_15(Class41.GetString(OsuString.BeatmapSubmissionSystem_PostingToForums));
			Class162 class = new Class162();
			Class167 class2 = new Class167();
			class.method_26(class2);
			class2.Items.method_0("u", Class341.class605_20);
			class2.Items.method_0("p", Class341.class605_17);
			class2.Items.method_0("b", this.int_2.ToString());
			class2.Items.method_0("subject", str);
			class2.Items.method_0("message", this.string_1 + this.textMessage.Text.Replace("\r", ""));
			class2.Items.method_0("complete", this.radioButton2.Checked ? "1" : "0");
			if (this.checkNotify.Checked)
			{
				class2.Items.method_0("notify", "1");
			}
			string[] array = class.method_48("http://osu.ppy.sh/web/osu-osz2-bmsubmit-post.php");
			class.Close();
			this.int_1 = int.Parse(array[0]);
		}

		// Token: 0x060032DA RID: 13018
		// RVA: 0x00155458 File Offset: 0x00153658
		private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (this.string_0 != null)
			{
				if (!this.bool_3)
				{
					MessageBox.Show(this, this.string_0);
				}
				base.Close();
				return;
			}
			this.bool_4 = (this.int_2 != this.method_9());
			this.buttonUpload.Enabled = true;
			this.buttonUpload.Text = ((!this.bool_4) ? Class41.GetString(OsuString.BeatmapSubmissionSystem_UpdateBeatmap) : Class41.GetString(OsuString.BeatmapSubmissionSystem_UploadNewBeatmap));
			if (!this.bool_4)
			{
				this.labelPreSubmissionInfo.Text = (this.bool_7 ? Class41.GetString(OsuString.BeatmapSubmissionSystem_ResetBubbleStatus) : "");
			}
			else
			{
				this.labelPreSubmissionInfo.Text = string.Format(Class41.GetString(OsuString.BeatmapSubmissionSystem_AvailableUploadCount), this.int_4, (this.int_4 != 1) ? "s" : "");
			}
			this.method_15(this.bool_4 ? Class41.GetString(OsuString.BeatmapSubmissionSystem_ReadyToUpload) : Class41.GetString(OsuString.BeatmapSubmissionSystem_ReadyToUpdate));
			this.backgroundWorker_0.DoWork -= new DoWorkEventHandler(this.backgroundWorker_0_DoWork);
			this.backgroundWorker_0.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(this.backgroundWorker_0_RunWorkerCompleted);
		}

		// Token: 0x060032E3 RID: 13027
		// RVA: 0x00155E38 File Offset: 0x00154038
		private void backgroundWorker_0_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
		{
			if (!this.bool_3)
			{
				this.progressBar1.Value = 100;
			}
			this.method_15(Class41.GetString(OsuString.BeatmapSubmissionSystem_PostedToForums));
			List<Class296> arg_48_0 = this.list_0;
			if (BeatmapSubmissionSystem.action_0 == null)
			{
				BeatmapSubmissionSystem.action_0 = new Action<Class296>(BeatmapSubmissionSystem.smethod_5);
			}
			arg_48_0.ForEach(BeatmapSubmissionSystem.action_0);
			if (this.checkLoad.Checked)
			{
				Class115.smethod_90("http://osu.ppy.sh/forum/t/" + this.int_1, null);
			}
			base.Close();
		}

		// Token: 0x060032E9 RID: 13033
		// RVA: 0x00016831 File Offset: 0x00014A31
		private void buttonCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060032EB RID: 13035
		// RVA: 0x000259DD File Offset: 0x00023BDD
		private void buttonHelpForum_Click(object sender, EventArgs e)
		{
			Class115.smethod_90("http://osu.ppy.sh/forum/56", null);
		}

		// Token: 0x060032ED RID: 13037
		// RVA: 0x000259F7 File Offset: 0x00023BF7
		private void buttonModdingQueues_Click(object sender, EventArgs e)
		{
			Class115.smethod_90("http://osu.ppy.sh/forum/60", null);
		}

		// Token: 0x060032EA RID: 13034
		// RVA: 0x00024F9B File Offset: 0x0002319B
		private void buttonRankingCriteria_Click(object sender, EventArgs e)
		{
			Class115.smethod_90("http://osu.ppy.sh/wiki/Ranking_Criteria", null);
		}

		// Token: 0x060032EC RID: 13036
		// RVA: 0x000259EA File Offset: 0x00023BEA
		private void buttonSubmissionFAQ_Click(object sender, EventArgs e)
		{
			Class115.smethod_90("http://osu.ppy.sh/wiki/BSS", null);
		}

		// Token: 0x060032E1 RID: 13025
		// RVA: 0x00155B70 File Offset: 0x00153D70
		private void buttonSubmit_Click(object sender, EventArgs e)
		{
			this.backgroundWorker_0.DoWork += new DoWorkEventHandler(this.backgroundWorker_0_DoWork_2);
			this.backgroundWorker_0.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.backgroundWorker_0_RunWorkerCompleted_1);
			this.backgroundWorker_0.RunWorkerAsync();
			this.buttonSubmit.Enabled = false;
		}

		// Token: 0x060032DB RID: 13019
		// RVA: 0x00025944 File Offset: 0x00023B44
		private void buttonUpload_Click(object sender, EventArgs e)
		{
			this.panel1.Visible = false;
			this.backgroundWorker_0.DoWork += new DoWorkEventHandler(this.backgroundWorker_0_DoWork_1);
			this.backgroundWorker_0.RunWorkerAsync();
		}

		// Token: 0x060032E6 RID: 13030
		// RVA: 0x00025997 File Offset: 0x00023B97
		private void checkLoad_CheckedChanged(object sender, EventArgs e)
		{
			Class341.class606_35.Value = this.checkLoad.Checked;
			Class341.class606_48.Value = this.checkNotify.Checked;
			this.textMessage.Focus();
		}

		// Token: 0x060032EF RID: 13039
		// RVA: 0x00025A33 File Offset: 0x00023C33
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060032F0 RID: 13040
		// RVA: 0x00156028 File Offset: 0x00154228
		private void InitializeComponent()
		{
			this.buttonSubmit = new Button();
			this.buttonCancel = new Button();
			this.progressBar1 = new ProgressBar();
			this.status = new Label();
			this.panel1 = new Panel();
			this.panel2 = new Panel();
			this.panel6 = new Panel();
			this.label10 = new Label();
			this.buttonModdingQueues = new Button();
			this.panel5 = new Panel();
			this.label8 = new Label();
			this.buttonSubmissionFAQ = new Button();
			this.panel4 = new Panel();
			this.label9 = new Label();
			this.buttonHelpForum = new Button();
			this.panel3 = new Panel();
			this.label7 = new Label();
			this.buttonRankingCriteria = new Button();
			this.labelPreSubmissionInfo = new Label();
			this.label5 = new Label();
			this.buttonUpload = new Button();
			this.panelMain = new Panel();
			this.checkNotify = new CheckBox();
			this.checkLoad = new CheckBox();
			this.textMessage = new TextBox();
			this.label1 = new Label();
			this.panelForum = new Panel();
			this.label6 = new Label();
			this.radioButton2 = new RadioButton();
			this.radioButton1 = new RadioButton();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panelMain.SuspendLayout();
			this.panelForum.SuspendLayout();
			base.SuspendLayout();
			this.buttonSubmit.Enabled = false;
			this.buttonSubmit.Location = new Point(356, 341);
			this.buttonSubmit.Name = "buttonSubmit";
			this.buttonSubmit.Size = new Size(144, 37);
			this.buttonSubmit.TabIndex = 3;
			this.buttonSubmit.Text = Class41.GetString(OsuString.General_Submit);
			this.buttonSubmit.UseVisualStyleBackColor = true;
			this.buttonSubmit.Click += new EventHandler(this.buttonSubmit_Click);
			this.buttonCancel.DialogResult = DialogResult.Cancel;
			this.buttonCancel.Location = new Point(506, 341);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new Size(75, 37);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = Class41.GetString(OsuString.General_Cancel);
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new EventHandler(this.buttonCancel_Click);
			this.progressBar1.Location = new Point(5, 356);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new Size(345, 22);
			this.progressBar1.Style = ProgressBarStyle.Continuous;
			this.progressBar1.TabIndex = 4;
			this.status.AutoEllipsis = true;
			this.status.Location = new Point(4, 337);
			this.status.Name = "status";
			this.status.Size = new Size(346, 17);
			this.status.TabIndex = 9;
			this.status.Text = Class41.GetString(OsuString.BeatmapSubmissionSystem_Designer_CheckingBeatmapStatus);
			this.panel1.BackColor = SystemColors.ControlLightLight;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.labelPreSubmissionInfo);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.buttonUpload);
			this.panel1.Location = new Point(1, -3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(591, 335);
			this.panel1.TabIndex = 9;
			this.panel2.BackColor = Color.WhiteSmoke;
			this.panel2.Controls.Add(this.panel6);
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Location = new Point(10, 37);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(566, 202);
			this.panel2.TabIndex = 23;
			this.panel6.BackColor = Color.OldLace;
			this.panel6.Controls.Add(this.label10);
			this.panel6.Controls.Add(this.buttonModdingQueues);
			this.panel6.Location = new Point(0, 150);
			this.panel6.Margin = new Padding(0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new Size(566, 51);
			this.panel6.TabIndex = 26;
			this.label10.ForeColor = Color.Black;
			this.label10.Location = new Point(20, 5);
			this.label10.Name = "label10";
			this.label10.Size = new Size(289, 40);
			this.label10.TabIndex = 26;
			this.label10.Text = Class41.GetString(OsuString.BeatmapSubmissionSystem_Designer_AskModQueue);
			this.label10.TextAlign = ContentAlignment.MiddleLeft;
			this.buttonModdingQueues.BackColor = Color.White;
			this.buttonModdingQueues.FlatStyle = FlatStyle.Flat;
			this.buttonModdingQueues.Location = new Point(315, 10);
			this.buttonModdingQueues.Name = "buttonModdingQueues";
			this.buttonModdingQueues.Size = new Size(232, 30);
			this.buttonModdingQueues.TabIndex = 27;
			this.buttonModdingQueues.Text = Class41.GetString(OsuString.BeatmapSubmissionSystem_Designer_ModQueueForum);
			this.buttonModdingQueues.UseVisualStyleBackColor = false;
			this.buttonModdingQueues.Click += new EventHandler(this.buttonModdingQueues_Click);
			this.panel5.BackColor = Color.OldLace;
			this.panel5.Controls.Add(this.label8);
			this.panel5.Controls.Add(this.buttonSubmissionFAQ);
			this.panel5.Location = new Point(0, 50);
			this.panel5.Margin = new Padding(0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new Size(566, 51);
			this.panel5.TabIndex = 25;
			this.label8.ForeColor = Color.Black;
			this.label8.Location = new Point(20, 5);
			this.label8.Name = "label8";
			this.label8.Size = new Size(289, 41);
			this.label8.TabIndex = 23;
			this.label8.Text = Class41.GetString(OsuString.BeatmapSubmissionSystem_Designer_SubmissionWiki);
			this.label8.TextAlign = ContentAlignment.MiddleLeft;
			this.buttonSubmissionFAQ.BackColor = Color.White;
			this.buttonSubmissionFAQ.FlatStyle = FlatStyle.Flat;
			this.buttonSubmissionFAQ.Location = new Point(315, 10);
			this.buttonSubmissionFAQ.Name = "buttonSubmissionFAQ";
			this.buttonSubmissionFAQ.Size = new Size(232, 30);
			this.buttonSubmissionFAQ.TabIndex = 22;
			this.buttonSubmissionFAQ.Text = Class41.GetString(OsuString.BeatmapSubmissionSystem_Designer_SubmissionProcess);
			this.buttonSubmissionFAQ.UseVisualStyleBackColor = false;
			this.buttonSubmissionFAQ.Click += new EventHandler(this.buttonSubmissionFAQ_Click);
			this.panel4.BackColor = Color.FloralWhite;
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.buttonHelpForum);
			this.panel4.Location = new Point(0, 100);
			this.panel4.Margin = new Padding(0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new Size(566, 51);
			this.panel4.TabIndex = 25;
			this.label9.ForeColor = Color.Black;
			this.label9.Location = new Point(20, 5);
			this.label9.Name = "label9";
			this.label9.Size = new Size(289, 40);
			this.label9.TabIndex = 25;
			this.label9.Text = Class41.GetString(OsuString.BeatmapSubmissionSystem_Designer_GotQuestions);
			this.label9.TextAlign = ContentAlignment.MiddleLeft;
			this.buttonHelpForum.BackColor = Color.White;
			this.buttonHelpForum.FlatStyle = FlatStyle.Flat;
			this.buttonHelpForum.Location = new Point(315, 10);
			this.buttonHelpForum.Name = "buttonHelpForum";
			this.buttonHelpForum.Size = new Size(232, 30);
			this.buttonHelpForum.TabIndex = 24;
			this.buttonHelpForum.Text = Class41.GetString(OsuString.BeatmapSubmissionSystem_Designer_MappingHelpForum);
			this.buttonHelpForum.UseVisualStyleBackColor = false;
			this.buttonHelpForum.Click += new EventHandler(this.buttonHelpForum_Click);
			this.panel3.BackColor = Color.FloralWhite;
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.buttonRankingCriteria);
			this.panel3.Location = new Point(0, 0);
			this.panel3.Margin = new Padding(0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size(566, 51);
			this.panel3.TabIndex = 24;
			this.label7.ForeColor = Color.Black;
			this.label7.Location = new Point(20, 5);
			this.label7.Name = "label7";
			this.label7.Size = new Size(289, 41);
			this.label7.TabIndex = 23;
			this.label7.Text = Class41.GetString(OsuString.BeatmapSubmissionSystem_Designer_CheckGuidelines);
			this.label7.TextAlign = ContentAlignment.MiddleLeft;
			this.buttonRankingCriteria.BackColor = Color.White;
			this.buttonRankingCriteria.FlatStyle = FlatStyle.Flat;
			this.buttonRankingCriteria.Location = new Point(315, 9);
			this.buttonRankingCriteria.Name = "buttonRankingCriteria";
			this.buttonRankingCriteria.Size = new Size(232, 30);
			this.buttonRankingCriteria.TabIndex = 22;
			this.buttonRankingCriteria.Text = Class41.GetString(OsuString.BeatmapSubmissionSystem_Designer_BeatmapRankingCriteria);
			this.buttonRankingCriteria.UseVisualStyleBackColor = false;
			this.buttonRankingCriteria.Click += new EventHandler(this.buttonRankingCriteria_Click);
			this.labelPreSubmissionInfo.ForeColor = Color.FromArgb(192, 0, 0);
			this.labelPreSubmissionInfo.Location = new Point(10, 260);
			this.labelPreSubmissionInfo.Name = "labelPreSubmissionInfo";
			this.labelPreSubmissionInfo.Size = new Size(563, 19);
			this.labelPreSubmissionInfo.TabIndex = 20;
			this.labelPreSubmissionInfo.TextAlign = ContentAlignment.MiddleCenter;
			this.label5.ForeColor = Color.Black;
			this.label5.Location = new Point(12, 11);
			this.label5.Name = "label5";
			this.label5.Size = new Size(563, 19);
			this.label5.TabIndex = 17;
			this.label5.Text = Class41.GetString(OsuString.BeatmapSubmissionSystem_Designer_OneStepFromSharing);
			this.buttonUpload.BackColor = SystemColors.ControlLight;
			this.buttonUpload.Enabled = false;
			this.buttonUpload.Location = new Point(5, 284);
			this.buttonUpload.Name = "buttonUpload";
			this.buttonUpload.Size = new Size(576, 37);
			this.buttonUpload.TabIndex = 10;
			this.buttonUpload.Text = Class41.GetString(OsuString.BeatmapSubmissionSystem_Designer_PleaseWait);
			this.buttonUpload.UseVisualStyleBackColor = false;
			this.buttonUpload.Click += new EventHandler(this.buttonUpload_Click);
			this.panelMain.BackColor = SystemColors.ControlLightLight;
			this.panelMain.Controls.Add(this.checkNotify);
			this.panelMain.Controls.Add(this.checkLoad);
			this.panelMain.Controls.Add(this.textMessage);
			this.panelMain.Controls.Add(this.label1);
			this.panelMain.Controls.Add(this.panelForum);
			this.panelMain.Enabled = false;
			this.panelMain.Location = new Point(1, -3);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new Size(591, 335);
			this.panelMain.TabIndex = 8;
			this.checkNotify.AutoSize = true;
			this.checkNotify.Checked = true;
			this.checkNotify.CheckState = CheckState.Checked;
			this.checkNotify.Location = new Point(28, 295);
			this.checkNotify.Name = "checkNotify";
			this.checkNotify.Size = new Size(208, 19);
			this.checkNotify.TabIndex = 13;
			this.checkNotify.Text = Class41.GetString(OsuString.BeatmapSubmissionSystem_Designer_EmailNotificationOnReply);
			this.checkNotify.UseVisualStyleBackColor = true;
			this.checkNotify.CheckedChanged += new EventHandler(this.checkLoad_CheckedChanged);
			this.checkLoad.AutoSize = true;
			this.checkLoad.Location = new Point(344, 295);
			this.checkLoad.Name = "checkLoad";
			this.checkLoad.Size = new Size(200, 19);
			this.checkLoad.TabIndex = 9;
			this.checkLoad.Text = Class41.GetString(OsuString.BeatmapSubmissionSystem_Designer_LoadInBrowserAfterSubmission);
			this.checkLoad.UseVisualStyleBackColor = true;
			this.checkLoad.CheckedChanged += new EventHandler(this.checkLoad_CheckedChanged);
			this.textMessage.AcceptsReturn = true;
			this.textMessage.Location = new Point(8, 121);
			this.textMessage.Multiline = true;
			this.textMessage.Name = "textMessage";
			this.textMessage.ScrollBars = ScrollBars.Vertical;
			this.textMessage.Size = new Size(579, 161);
			this.textMessage.TabIndex = 0;
			this.label1.AutoSize = true;
			this.label1.Location = new Point(9, 101);
			this.label1.Name = "label1";
			this.label1.Size = new Size(94, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = Class41.GetString(OsuString.BeatmapSubmissionSystem_Designer_CreatorsWords);
			this.panelForum.Controls.Add(this.label6);
			this.panelForum.Controls.Add(this.radioButton2);
			this.panelForum.Controls.Add(this.radioButton1);
			this.panelForum.Location = new Point(8, 12);
			this.panelForum.Name = "panelForum";
			this.panelForum.Size = new Size(579, 83);
			this.panelForum.TabIndex = 2;
			this.label6.AutoEllipsis = true;
			this.label6.Location = new Point(4, 5);
			this.label6.Name = "label6";
			this.label6.Size = new Size(571, 19);
			this.label6.TabIndex = 10;
			this.label6.Text = Class41.GetString(OsuString.BeatmapSubmissionSystem_Designer_WhereToPostBeatmap);
			this.label6.TextAlign = ContentAlignment.MiddleCenter;
			this.radioButton2.Appearance = Appearance.Button;
			this.radioButton2.FlatAppearance.BorderColor = Color.Gainsboro;
			this.radioButton2.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 192, 128);
			this.radioButton2.FlatAppearance.MouseOverBackColor = Color.AntiqueWhite;
			this.radioButton2.FlatStyle = FlatStyle.Flat;
			this.radioButton2.Location = new Point(297, 26);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new Size(246, 48);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = Class41.GetString(OsuString.BeatmapSubmissionSystem_Designer_PendingBeatmaps);
			this.radioButton2.TextAlign = ContentAlignment.MiddleCenter;
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new EventHandler(this.radioButton2_CheckedChanged);
			this.radioButton1.Appearance = Appearance.Button;
			this.radioButton1.FlatAppearance.BorderColor = Color.Gainsboro;
			this.radioButton1.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 192, 128);
			this.radioButton1.FlatAppearance.MouseOverBackColor = Color.AntiqueWhite;
			this.radioButton1.FlatStyle = FlatStyle.Flat;
			this.radioButton1.Location = new Point(35, 26);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new Size(246, 48);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.Text = Class41.GetString(OsuString.BeatmapSubmissionSystem_Designer_WorkInProgress);
			this.radioButton1.TextAlign = ContentAlignment.MiddleCenter;
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.MouseUp += new MouseEventHandler(this.radioButton1_MouseUp);
			base.AcceptButton = this.buttonSubmit;
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new Size(593, 387);
			base.Controls.Add(this.progressBar1);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonSubmit);
			base.Controls.Add(this.status);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.panelMain);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "BeatmapSubmissionSystem";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Beatmap Submission System";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panelMain.ResumeLayout(false);
			this.panelMain.PerformLayout();
			this.panelForum.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x060032D7 RID: 13015
		// RVA: 0x001550F4 File Offset: 0x001532F4
		private string method_10()
		{
			string text = string.Empty;
			foreach (Class296 current in this.list_0)
			{
				text = text + current.int_2 + ",";
			}
			return text.TrimEnd(new char[]
			{
				','
			});
		}

		// Token: 0x060032D8 RID: 13016
		// RVA: 0x00155174 File Offset: 0x00153374
		private bool method_11(string[] string_3, int int_5)
		{
			try
			{
				int num = Convert.ToInt32(string_3[0]);
				switch (num)
				{
				case 0:
					return false;
				case 1:
					this.string_0 = Class41.GetString(OsuString.BeatmapSubmissionSystem_OwnershipError);
					break;
				case 2:
					this.string_0 = Class41.GetString(OsuString.BeatmapSubmissionSystem_NoLongerAvailable);
					break;
				case 3:
					this.string_0 = Class41.GetString(OsuString.BeatmapSubmissionSystem_AlreadyRanked);
					break;
				case 4:
					this.string_0 = Class41.GetString(OsuString.BeatmapSubmissionSystem_InGraveyard) + Class41.GetString(OsuString.BeatmapSubmissionSystem_UngraveyardMap);
					break;
				default:
					if (num > 4 || num < 0)
					{
						this.string_0 = string_3[1];
					}
					break;
				}
			}
			catch
			{
			}
			return true;
		}

		// Token: 0x060032DD RID: 13021
		// RVA: 0x00025974 File Offset: 0x00023B74
		private bool method_12(DoWorkEventArgs doWorkEventArgs_0)
		{
			if (!this.backgroundWorker_0.CancellationPending)
			{
				return false;
			}
			doWorkEventArgs_0.Cancel = true;
			return true;
		}

		// Token: 0x060032DE RID: 13022
		// RVA: 0x0002598D File Offset: 0x00023B8D
		private void method_13(object object_0, long long_1, long long_2)
		{
			this.method_16(long_1, long_2);
		}

		// Token: 0x060032DF RID: 13023
		// RVA: 0x00155994 File Offset: 0x00153B94
		private void method_14(string string_3, Exception exception_0)
		{
			MethodInvoker methodInvoker = null;
			BeatmapSubmissionSystem.Class868 class = new BeatmapSubmissionSystem.Class868();
			class.string_0 = string_3;
			class.exception_0 = exception_0;
			class.beatmapSubmissionSystem_0 = this;
			if (!this.bool_5 && class.exception_0 == null && !(class.string_0 != "0"))
			{
				this.backgroundWorker_0.DoWork -= new DoWorkEventHandler(this.backgroundWorker_0_DoWork_1);
				try
				{
					this.class178_1.Close();
					string text = this.method_17();
					if (!Directory.Exists(Path.GetDirectoryName(text)))
					{
						Directory.CreateDirectory(Path.GetDirectoryName(text));
					}
					if (this.class178_0 != null)
					{
						this.class178_0.Close();
					}
					File.Delete(text);
					File.Move(this.class178_1.method_15(), text);
				}
				catch
				{
				}
				this.method_15(this.bool_4 ? Class41.GetString(OsuString.BeatmapSubmissionSystem_Uploaded) : Class41.GetString(OsuString.BeatmapSubmissionSystem_Updated));
				base.Invoke(new MethodInvoker(this.method_21));
				return;
			}
			if (methodInvoker == null)
			{
				methodInvoker = new MethodInvoker(class.method_0);
			}
			base.Invoke(methodInvoker);
			if (this.class178_1 != null)
			{
				this.class178_1.Dispose();
				File.Delete(this.class178_1.method_15());
				this.class178_1 = null;
			}
		}

		// Token: 0x060032E4 RID: 13028
		// RVA: 0x00155EC0 File Offset: 0x001540C0
		private void method_15(string string_3)
		{
			BeatmapSubmissionSystem.Class869 class = new BeatmapSubmissionSystem.Class869();
			class.string_0 = string_3;
			class.beatmapSubmissionSystem_0 = this;
			if (this.bool_3)
			{
				return;
			}
			base.Invoke(new MethodInvoker(class.method_0));
		}

		// Token: 0x060032E5 RID: 13029
		// RVA: 0x00155EFC File Offset: 0x001540FC
		private void method_16(long long_1, long long_2)
		{
			BeatmapSubmissionSystem.Class870 class = new BeatmapSubmissionSystem.Class870();
			class.long_0 = long_1;
			class.long_1 = long_2;
			class.beatmapSubmissionSystem_0 = this;
			double totalSeconds = DateTime.Now.Subtract(this.dateTime_0).TotalSeconds;
			class.double_0 = ((totalSeconds > 5.0) ? ((double)class.long_0 / totalSeconds) : 0.0);
			this.double_0 = ((this.double_0 == 0.0) ? class.double_0 : (class.double_0 * 0.0099999997764825821 + this.double_0 * 0.99000000953674316));
			if (this.bool_3)
			{
				return;
			}
			base.Invoke(new MethodInvoker(class.method_0));
		}

		// Token: 0x060032EE RID: 13038
		// RVA: 0x00025A04 File Offset: 0x00023C04
		public string method_17()
		{
			if (Class466.Current.int_3 > 0)
			{
				return "Data/SubmissionCache/" + Class466.Current.int_3 + ".osz2";
			}
			return null;
		}

		// Token: 0x060032F3 RID: 13043
		// RVA: 0x0015746C File Offset: 0x0015566C
		[CompilerGenerated]
		private void method_18()
		{
			this.panelMain.Enabled = true;
			if (this.list_0.Count > 1)
			{
				this.radioButton1.Checked = (this.int_0 == -1);
				this.radioButton2.Checked = (this.int_0 == 0);
			}
			else
			{
				this.radioButton1.Checked = true;
				this.radioButton2.Checked = false;
			}
			this.string_1 = string.Concat(new string[]
			{
				"[size=85]This beatmap was submitted using in-game submission on ",
				DateTime.Now.ToLongDateString(),
				" at ",
				DateTime.Now.ToLongTimeString(),
				"[/size]\n"
			});
			this.string_1 = this.string_1 + "\n[b]Artist:[/b] " + this.list_0[0].Artist;
			this.string_1 = this.string_1 + "\n[b]Title:[/b] " + this.list_0[0].Title;
			if (this.list_0[0].string_13.Length > 0)
			{
				this.string_1 = this.string_1 + "\n[b]Source:[/b] " + this.list_0[0].string_13;
			}
			if (this.list_0[0].Tags.Length > 0)
			{
				this.string_1 = this.string_1 + "\n[b]Tags:[/b] " + this.list_0[0].Tags;
			}
			this.string_1 = this.string_1 + "\n[b]BPM:[/b] " + Math.Round(1000.0 / this.list_0[0].list_1[0].double_0 * 60.0, 2);
			this.string_1 = this.string_1 + "\n[b]Filesize:[/b] " + (this.long_0 / 1024L).ToString(Class115.numberFormatInfo_0) + "kb";
			this.string_1 += string.Format("\n[b]Play Time:[/b] {0:00}:{1:00}", this.list_0[0].int_16 / 60000, this.list_0[0].int_16 % 60000 / 1000);
			this.string_1 += "\n[b]Difficulties Available:[/b]\n[list]";
			foreach (Class296 current in this.list_0)
			{
				this.string_1 += string.Format("[*][url={0}]{1}{2}[/url] ({3} stars, {4} notes)\n", new object[]
				{
					"http://osu.ppy.sh/web/maps/" + Class34.smethod_7(Path.GetFileName(current.string_9)),
					(current.string_14.Length > 0) ? current.string_14 : "Normal",
					(current.method_5() == PlayModes.OsuMania) ? (" - " + (int)Math.Round((double)current.DifficultyCircleSize) + "Key") : "",
					Math.Round(current.method_16(current.method_5(), Mods.None), 2),
					current.int_11
				});
			}
			this.string_1 += "[/list]\n";
			object obj = this.string_1;
			this.string_1 = string.Concat(new object[]
			{
				obj,
				"\n[size=150][b]Download: [url=http://osu.ppy.sh/d/",
				this.int_2,
				"]",
				this.list_0[0].string_12,
				"[/url][/b][/size]"
			});
			if (this.bool_1)
			{
				object obj2 = this.string_1;
				this.string_1 = string.Concat(new object[]
				{
					obj2,
					"\n[size=120][b]Download: [url=http://osu.ppy.sh/d/",
					this.int_2,
					"n]",
					this.list_0[0].string_12,
					" (no video)[/url][/b][/size]"
				});
			}
			object obj3 = this.string_1;
			this.string_1 = string.Concat(new object[]
			{
				obj3,
				"\n[b]Information:[/b] [url=http://osu.ppy.sh/s/",
				this.int_2,
				"]Scores/Beatmap Listing[/url]"
			});
			this.string_1 += "\n---------------\n";
			this.textMessage.Text = Class41.GetString(OsuString.BeatmapSubmissionSystem_CreatorsWords);
			if (!string.IsNullOrEmpty(this.string_2))
			{
				if (this.string_2.IndexOf("---------------\n") > 0)
				{
					this.textMessage.Text = this.string_2.Remove(0, this.string_2.IndexOf("---------------") + 16).Trim(new char[]
					{
						'\n',
						'\r'
					}).Replace("\n", "\r\n");
				}
				else
				{
					this.textMessage.Text = this.string_2.Replace("\n", "\r\n");
				}
			}
			this.textMessage.Focus();
			this.textMessage.SelectAll();
		}

		// Token: 0x060032F4 RID: 13044
		// RVA: 0x00025A5A File Offset: 0x00023C5A
		[CompilerGenerated]
		private void method_19()
		{
			this.radioButton2.Enabled = false;
			this.radioButton2.Text = Class41.GetString(OsuString.BeatmapSubmissionSystem_PendingBeatmaps);
		}

		// Token: 0x060032F5 RID: 13045
		// RVA: 0x00025A7D File Offset: 0x00023C7D
		[CompilerGenerated]
		private void method_20(object object_0, long long_1, long long_2)
		{
			if (long_2 == 0L)
			{
				return;
			}
			if (long_1 == long_2)
			{
				this.method_15(Class41.GetString(OsuString.BeatmapSubmissionSystem_Distributing));
				return;
			}
			this.method_16(long_1, long_2);
		}

		// Token: 0x060032F6 RID: 13046
		// RVA: 0x00025AA9 File Offset: 0x00023CA9
		[CompilerGenerated]
		private void method_21()
		{
			if (!this.bool_3)
			{
				this.progressBar1.Value = 100;
			}
			this.buttonSubmit.Enabled = true;
			Class331.smethod_59("notify1", 100, Enum112.flag_5);
			Class115.FlashWindow(base.Handle, false);
		}

		// Token: 0x060032D6 RID: 13014
		// RVA: 0x0015505C File Offset: 0x0015325C
		private int method_9()
		{
			if (Class466.Current.int_3 > 0)
			{
				return Class466.Current.int_3;
			}
			if (this.class178_0 != null)
			{
				return Convert.ToInt32(this.class178_0.method_20(Enum9.const_9));
			}
			foreach (Class296 current in this.list_0)
			{
				if (current.int_3 > 0)
				{
					return current.int_3;
				}
			}
			return -1;
		}

		// Token: 0x060032E0 RID: 13024
		// RVA: 0x00155AE4 File Offset: 0x00153CE4
		protected override void OnClosing(CancelEventArgs e)
		{
			this.editor_0.method_15();
			this.bool_3 = true;
			if (this.class132_0 != null)
			{
				this.class132_0.Close();
			}
			if (this.backgroundWorker_0 != null)
			{
				this.backgroundWorker_0.CancelAsync();
			}
			base.OnClosing(e);
			Class115.smethod_6(false);
			Class809.smethod_37(bStatus.Editing, false);
			if (this.class178_0 != null)
			{
				this.class178_0.Dispose();
			}
			if (this.class178_1 != null)
			{
				this.class178_1.Dispose();
			}
			Class115.form_0.Focus();
		}

		// Token: 0x060032E7 RID: 13031
		// RVA: 0x000259CF File Offset: 0x00023BCF
		private void radioButton1_MouseUp(object sender, MouseEventArgs e)
		{
			this.textMessage.Focus();
		}

		// Token: 0x060032E8 RID: 13032
		// RVA: 0x00155FC4 File Offset: 0x001541C4
		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (this.list_0.Count < 2 && this.radioButton2.Checked)
			{
				MessageBox.Show(Class41.GetString(OsuString.BeatmapSubmissionSystem_SubmittingRequiresTwoDiffs), "Sorry");
				this.radioButton2.Checked = false;
				this.radioButton1.Checked = true;
			}
			this.textMessage.Focus();
		}

		// Token: 0x060032F1 RID: 13041
		// RVA: 0x0001A168 File Offset: 0x00018368
		[CompilerGenerated]
		private static bool smethod_3(Class296 class296_0)
		{
			return class296_0.method_3() == Class466.Current.method_3();
		}

		// Token: 0x060032F2 RID: 13042
		// RVA: 0x00025A52 File Offset: 0x00023C52
		[CompilerGenerated]
		private static int smethod_4(string string_3)
		{
			return Convert.ToInt32(string_3);
		}

		// Token: 0x060032F7 RID: 13047
		// RVA: 0x00025AE7 File Offset: 0x00023CE7
		[CompilerGenerated]
		private static void smethod_5(Class296 class296_0)
		{
			class296_0.bool_18 = false;
		}
	}
}
