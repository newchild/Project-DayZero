using ns14;
using ns29;
using ns41;
using ns64;
using ns76;
using ns8;
using osu.Properties;
using osu_common.Helpers;
using osu_common.Updater;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace ns11
{
	// Token: 0x020005A7 RID: 1447
	internal sealed class Maintenance : Form2
	{
		// Token: 0x020005A8 RID: 1448
		[CompilerGenerated]
		private sealed class Class768
		{
			// Token: 0x040026C6 RID: 9926
			public float float_0;

			// Token: 0x040026C5 RID: 9925
			public Maintenance maintenance_0;

			// Token: 0x040026C7 RID: 9927
			public OsuString osuString_0;

			// Token: 0x06002E6A RID: 11882
			// RVA: 0x0012DB04 File Offset: 0x0012BD04
			public void method_0()
			{
				if (this.float_0 <= 0f)
				{
					this.maintenance_0.progressBar1.Value = 0;
					this.maintenance_0.label1.Text = Class41.GetString(this.osuString_0);
					return;
				}
				this.maintenance_0.progressBar1.Value = (int)this.float_0;
				this.maintenance_0.label1.Text = (int)this.float_0 + "%";
			}
		}

		// Token: 0x020005A9 RID: 1449
		[CompilerGenerated]
		private sealed class Class769
		{
			// Token: 0x040026C8 RID: 9928
			public bool bool_0;

			// Token: 0x06002E6C RID: 11884
			// RVA: 0x000230A0 File Offset: 0x000212A0
			public void method_0()
			{
				Class41.smethod_0(null, false, new VoidDelegate(this.method_1), Resources.en);
			}

			// Token: 0x06002E6D RID: 11885
			// RVA: 0x000230BB File Offset: 0x000212BB
			public void method_1()
			{
				this.bool_0 = true;
			}
		}

		// Token: 0x020005AA RID: 1450
		[CompilerGenerated]
		private sealed class Class770
		{
			// Token: 0x040026CA RID: 9930
			public Maintenance maintenance_0;

			// Token: 0x040026C9 RID: 9929
			public string string_0;

			// Token: 0x06002E6F RID: 11887
			// RVA: 0x0012DB88 File Offset: 0x0012BD88
			public void method_0()
			{
				FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
				folderBrowserDialog.Description = Class41.GetString(OsuString.Maintenance_ChooseInstallFolder);
				folderBrowserDialog.ShowNewFolderButton = true;
				folderBrowserDialog.SelectedPath = Environment.CurrentDirectory;
				if (folderBrowserDialog.ShowDialog(this.maintenance_0) != DialogResult.OK)
				{
					this.maintenance_0.string_0 = this.string_0;
					return;
				}
				this.maintenance_0.string_0 = folderBrowserDialog.SelectedPath;
				if (!Directory.Exists(this.maintenance_0.string_0))
				{
					this.maintenance_0.string_0 = this.string_0;
					return;
				}
				if (File.Exists(Path.Combine(this.maintenance_0.string_0, "osu!.cfg")))
				{
					return;
				}
				if (Directory.GetDirectories(this.maintenance_0.string_0).Length + Directory.GetFiles(this.maintenance_0.string_0).Length > 0)
				{
					this.maintenance_0.string_0 = Path.Combine(this.maintenance_0.string_0, "osu!");
				}
			}
		}

		// Token: 0x040026B2 RID: 9906
		private BackgroundWorker backgroundWorker_0 = new BackgroundWorker();

		// Token: 0x040026BC RID: 9916
		private bool bool_1;

		// Token: 0x040026BD RID: 9917
		private bool bool_2;

		// Token: 0x040026B3 RID: 9907
		private Class48 class48_0;

		// Token: 0x040026C4 RID: 9924
		[CompilerGenerated]
		private static Delegate26 delegate26_0;

		// Token: 0x040026B4 RID: 9908
		private float float_0;

		// Token: 0x040026BE RID: 9918
		private IContainer icontainer_0;

		// Token: 0x040026B6 RID: 9910
		private Image image_0 = Resources.updater_grid1;

		// Token: 0x040026B7 RID: 9911
		private Image image_1 = Resources.updater_grid2;

		// Token: 0x040026B8 RID: 9912
		private Image image_2 = Resources.updater_grid3;

		// Token: 0x040026B9 RID: 9913
		private Image image_3 = Resources.updater_grid4;

		// Token: 0x040026C0 RID: 9920
		private Label label;

		// Token: 0x040026C1 RID: 9921
		private Label label1;

		// Token: 0x040026C3 RID: 9923
		private Class612 linkLabel1;

		// Token: 0x040026C2 RID: 9922
		private PictureBox pictureBox1;

		// Token: 0x040026BF RID: 9919
		private Control0 progressBar1;

		// Token: 0x040026BA RID: 9914
		private string string_0 = Environment.CurrentDirectory;

		// Token: 0x040026BB RID: 9915
		private string string_1 = string.Empty;

		// Token: 0x040026B5 RID: 9909
		private System.Windows.Forms.Timer timer_1 = new System.Windows.Forms.Timer();

		// Token: 0x06002E53 RID: 11859
		// RVA: 0x0012C8D8 File Offset: 0x0012AAD8
		public Maintenance(Enum74 enum74_0)
		{
			this.InitializeComponent();
			switch (enum74_0)
			{
			case Enum74.const_0:
				this.backgroundWorker_0.DoWork += new DoWorkEventHandler(this.backgroundWorker_0_DoWork_2);
				break;
			case Enum74.const_1:
				this.backgroundWorker_0.DoWork += new DoWorkEventHandler(this.backgroundWorker_0_DoWork_3);
				break;
			case Enum74.const_2:
				if (!Class905.bool_1)
				{
					base.TopMost = false;
				}
				base.ShowInTaskbar = true;
				this.Text = "osu! updater";
				this.backgroundWorker_0.DoWork += new DoWorkEventHandler(this.backgroundWorker_0_DoWork_1);
				break;
			case Enum74.const_3:
				if (!Class905.bool_1)
				{
					base.TopMost = false;
				}
				base.ShowInTaskbar = true;
				this.Text = "osu! uninstaller";
				this.backgroundWorker_0.DoWork += new DoWorkEventHandler(this.backgroundWorker_0_DoWork);
				break;
			}
			this.backgroundWorker_0.WorkerReportsProgress = true;
			this.backgroundWorker_0.ProgressChanged += new ProgressChangedEventHandler(this.backgroundWorker_0_ProgressChanged);
			this.backgroundWorker_0.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.backgroundWorker_0_RunWorkerCompleted);
			this.backgroundWorker_0.RunWorkerAsync();
			this.timer_1.Tick += new EventHandler(this.timer_1_Tick);
			this.timer_1.Interval = 10;
			this.timer_1.Start();
		}

		// Token: 0x06002E5B RID: 11867
		// RVA: 0x0012CCC4 File Offset: 0x0012AEC4
		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			if (!Class905.smethod_14())
			{
				Class905.smethod_13("-uninstall", false);
				return;
			}
			try
			{
				this.method_10();
				this.method_9(0f, OsuString.Maintenance_Bye);
				int i = 10;
				while (i > 0)
				{
					this.method_11(string.Format(Class41.GetString(OsuString.Maintenance_Uninstall) + '\n' + Class41.GetString(OsuString.Maintenance_Uninstall2), i), true);
					Thread.Sleep(1000);
					i--;
					while (this.string_0 == null)
					{
						Thread.Sleep(100);
					}
				}
				this.method_11(Class41.GetString(OsuString.Maintenance_Uninstalling), true);
				string[] directories = Directory.GetDirectories(Environment.CurrentDirectory);
				int num = directories.Length + 8;
				int num2 = 0;
				string[] array = directories;
				for (int j = 0; j < array.Length; j++)
				{
					string path = array[j];
					this.method_9((float)((int)((float)(++num2) / (float)num * 100f)), OsuString.Maintenance_Hi);
					try
					{
						Directory.Delete(path, true);
					}
					catch
					{
					}
					Thread.Sleep(100);
				}
				try
				{
					this.method_9((float)((int)((float)(++num2) / (float)num * 100f)), OsuString.Maintenance_Hi);
					Directory.Delete(Environment.CurrentDirectory, true);
				}
				catch
				{
				}
				try
				{
					this.method_9((float)((int)((float)(++num2) / (float)num * 100f)), OsuString.Maintenance_Hi);
					string[] files = Directory.GetFiles(Environment.CurrentDirectory);
					for (int k = 0; k < files.Length; k++)
					{
						string text = files[k];
						Class34.smethod_17(text);
					}
				}
				catch
				{
				}
				try
				{
					this.method_9((float)((int)((float)(++num2) / (float)num * 100f)), OsuString.Maintenance_Hi);
					Directory.Delete(Environment.CurrentDirectory);
				}
				catch
				{
				}
				try
				{
					this.method_9((float)((int)((float)(++num2) / (float)num * 100f)), OsuString.Maintenance_Hi);
					Class34.smethod_17(Environment.CurrentDirectory);
				}
				catch
				{
				}
				try
				{
					this.method_9((float)((int)((float)(++num2) / (float)num * 100f)), OsuString.Maintenance_Hi);
					Class793.smethod_0();
				}
				catch
				{
				}
				try
				{
					this.method_9((float)((int)((float)(++num2) / (float)num * 100f)), OsuString.Maintenance_Hi);
					File.Delete(Maintenance.smethod_3());
					File.Delete(Maintenance.smethod_4());
				}
				catch
				{
				}
				try
				{
					this.method_9((float)((int)((float)(++num2) / (float)num * 100f)), OsuString.Maintenance_Hi);
					Class34.smethod_5("osu!");
					Class34.smethod_5("osu");
				}
				catch
				{
				}
				this.method_9(100f, OsuString.Maintenance_Hi);
				this.method_11(Class41.GetString(OsuString.Maintenance_Farewell), true);
				Thread.Sleep(5000);
			}
			catch
			{
			}
		}

		// Token: 0x06002E5C RID: 11868
		// RVA: 0x0012D034 File Offset: 0x0012B234
		private void backgroundWorker_0_DoWork_1(object sender, DoWorkEventArgs e)
		{
			this.method_10();
			try
			{
				ReleaseStream releaseStream_ = ReleaseStream.Stable;
				bool flag = File.Exists("Microsoft.Xna.Framework.dll") && File.Exists("x3daudio1_1.dll");
				bool flag2 = File.Exists("osu!.cfg") || (!flag && Directory.GetFiles(Environment.CurrentDirectory).Length == 1);
				if (!flag)
				{
					string text;
					while (true)
					{
						IL_1AF:
						if (!flag2)
						{
							this.string_0 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "osu!");
							this.label.Click += new EventHandler(this.label_Click);
							int i = 10;
							while (i > 0)
							{
								this.method_11(string.Format(Class41.GetString(OsuString.Maintenance_InstallationPath) + '\n' + Class41.GetString(OsuString.Maintenance_InstallationPath2), this.string_0, i), true);
								Thread.Sleep(1000);
								i--;
								while (this.string_0 == null)
								{
									Thread.Sleep(100);
								}
							}
							this.label.Click -= new EventHandler(this.label_Click);
						}
						while (this.string_0 != Environment.CurrentDirectory)
						{
							text = Path.Combine(this.string_0, "osu!.exe");
							try
							{
								if (!Directory.Exists(this.string_0))
								{
									Directory.CreateDirectory(this.string_0);
								}
								try
								{
									File.Delete(text);
								}
								catch (IOException)
								{
								}
								byte[] array = File.ReadAllBytes(Class905.smethod_0());
								using (FileStream fileStream = File.Create(text))
								{
									fileStream.Write(array, 0, array.Length);
								}
								goto IL_1BA;
							}
							catch (UnauthorizedAccessException)
							{
								if (Class905.smethod_14())
								{
									goto IL_1BA;
								}
								if (!Class905.smethod_13("-allowuserwrites " + this.string_0, true))
								{
									goto IL_1AF;
								}
							}
						}
						goto IL_1C7;
					}
					IL_1BA:
					Process.Start(text);
					Class905.smethod_12();
				}
				try
				{
					IL_1C7:
					if (flag)
					{
						releaseStream_ = Class341.class605_25.Value;
					}
				}
				catch
				{
					Class905.smethod_11(true);
				}
				this.method_11(string.Empty, false);
				while (true)
				{
					this.method_9(0f, OsuString.Maintenance_Hi);
					if (flag)
					{
						Class341.smethod_4();
					}
					if (Maintenance.delegate26_0 == null)
					{
						Maintenance.delegate26_0 = new Delegate26(Maintenance.smethod_5);
					}
					Class214.Check(Maintenance.delegate26_0, releaseStream_, ThreadPriority.Normal);
					while (true)
					{
						switch (Class214.enum32_0)
						{
						case Enum32.const_0:
							goto IL_2E6;
						case Enum32.const_1:
							this.method_11(Class214.smethod_1(false), this.bool_1);
							this.method_9(0f, OsuString.Maintenance_Hi);
							Thread.Sleep(20);
							continue;
						case Enum32.const_2:
							this.method_11(Class214.smethod_1(false), false);
							this.method_9(Class214.smethod_0(), OsuString.Maintenance_Hi);
							Thread.Sleep(20);
							continue;
						case Enum32.const_3:
							goto IL_291;
						case Enum32.const_4:
						case Enum32.const_5:
							goto IL_303;
						}
						goto Block_13;
					}
					IL_291:
					Class214.Reset(true);
					this.method_9(0f, OsuString.Maintenance_Hi);
					this.method_11(Class41.GetString(OsuString.Maintenance_ErrorOccurred), true);
					Thread.Sleep(5000);
				}
				Block_13:
				goto IL_314;
				IL_2E6:
				this.method_11(Class41.GetString(OsuString.CommonUpdater_Updated), true);
				Thread.Sleep(1000);
				goto IL_314;
				IL_303:
				this.method_11(Class41.GetString(OsuString.CommonUpdater_Updated), false);
				IL_314:
				if (!Class905.smethod_16() && !flag)
				{
					Class791.Create(Maintenance.smethod_3(), Path.Combine(Environment.CurrentDirectory, "osu!.exe"), "osu!");
					Class791.Create(Maintenance.smethod_4(), Path.Combine(Environment.CurrentDirectory, "osu!.exe"), "osu!");
				}
				this.class48_0.Dispose();
				base.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error occured (please report this!):\\n\\n" + ex.ToString());
			}
		}

		// Token: 0x06002E5E RID: 11870
		// RVA: 0x0012D488 File Offset: 0x0012B688
		private void backgroundWorker_0_DoWork_2(object sender, DoWorkEventArgs e)
		{
			if (Directory.Exists("Avatars"))
			{
				string[] files = Directory.GetFiles("Avatars");
				for (int i = 0; i < files.Length; i++)
				{
					File.Delete(files[i]);
					this.backgroundWorker_0.ReportProgress((int)((float)i / (float)files.Length * 100f));
				}
				Directory.Delete("Avatars", true);
			}
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06002E5F RID: 11871
		// RVA: 0x0012D4F0 File Offset: 0x0012B6F0
		private void backgroundWorker_0_DoWork_3(object sender, DoWorkEventArgs e)
		{
			Class908.dictionary_0.Clear();
			if (!Directory.Exists("Data\\r"))
			{
				return;
			}
			string[] files = Directory.GetFiles("Data\\r");
			for (int i = 0; i < files.Length; i++)
			{
				string text = files[i];
				Class908.smethod_5(text, false);
				this.backgroundWorker_0.ReportProgress((int)((float)i / (float)files.Length * 100f));
			}
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06002E59 RID: 11865
		// RVA: 0x00023015 File Offset: 0x00021215
		private void backgroundWorker_0_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			this.progressBar1.Value = e.ProgressPercentage;
		}

		// Token: 0x06002E58 RID: 11864
		// RVA: 0x00016831 File Offset: 0x00014A31
		private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			base.Close();
		}

		// Token: 0x06002E64 RID: 11876
		// RVA: 0x00023057 File Offset: 0x00021257
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002E65 RID: 11877
		// RVA: 0x0012D5B0 File Offset: 0x0012B7B0
		private void InitializeComponent()
		{
			this.label = new Label();
			this.progressBar1 = new Control0();
			this.label1 = new Label();
			this.pictureBox1 = new PictureBox();
			this.linkLabel1 = new Class612();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.label.BackColor = Color.Transparent;
			this.label.Dock = DockStyle.Bottom;
			this.label.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label.ForeColor = Color.FromArgb(85, 85, 85);
			this.label.Location = new Point(0, 295);
			this.label.Name = "label";
			this.label.Size = new Size(380, 55);
			this.label.TabIndex = 1;
			this.label.Text = "osu! is performing some maintenance";
			this.label.TextAlign = ContentAlignment.TopCenter;
			this.label.MouseEnter += new EventHandler(this.label_MouseEnter);
			this.label.MouseLeave += new EventHandler(this.label_MouseLeave);
			this.progressBar1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.progressBar1.BackColor = Color.FromArgb(85, 85, 85);
			this.progressBar1.ForeColor = Color.FromArgb(255, 102, 170);
			this.progressBar1.Location = new Point(20, 220);
			this.progressBar1.Margin = new Padding(0);
			this.progressBar1.Maximum = 100;
			this.progressBar1.Minimum = 0;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.method_2(Color.FromArgb(255, 102, 170));
			this.progressBar1.Size = new Size(340, 5);
			this.progressBar1.TabIndex = 0;
			this.progressBar1.Value = 0;
			this.label1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new Font("Segoe UI", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.FromArgb(85, 85, 85);
			this.label1.Location = new Point(117, 260);
			this.label1.Name = "label1";
			this.label1.Size = new Size(146, 35);
			this.label1.TabIndex = 2;
			this.label1.Text = "Hi!";
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			this.pictureBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.pictureBox1.BackColor = Color.Transparent;
			this.pictureBox1.Image = Resources.updater_logo;
			this.pictureBox1.Location = new Point(117, 37);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(146, 146);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.linkLabel1.ActiveLinkColor = Color.FromArgb(246, 99, 165);
			this.linkLabel1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.BackColor = Color.Transparent;
			this.linkLabel1.LinkColor = Color.FromArgb(56, 56, 56);
			this.linkLabel1.Location = new Point(342, 3);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new Size(35, 15);
			this.linkLabel1.TabIndex = 5;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "help?";
			this.linkLabel1.TextAlign = ContentAlignment.TopRight;
			this.linkLabel1.VisitedLinkColor = Color.FromArgb(56, 56, 56);
			this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			this.BackColor = Color.FromArgb(241, 239, 241);
			base.ClientSize = new Size(380, 350);
			base.Controls.Add(this.linkLabel1);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.label);
			base.Controls.Add(this.progressBar1);
			this.DoubleBuffered = true;
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Maintenance";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Maintenance";
			base.TopMost = true;
			((ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06002E5D RID: 11869
		// RVA: 0x0012D448 File Offset: 0x0012B648
		private void label_Click(object sender, EventArgs e)
		{
			Maintenance.Class770 class = new Maintenance.Class770();
			class.maintenance_0 = this;
			class.string_0 = this.string_0;
			this.string_0 = null;
			base.Invoke(new MethodInvoker(class.method_0));
		}

		// Token: 0x06002E61 RID: 11873
		// RVA: 0x00023028 File Offset: 0x00021228
		private void label_MouseEnter(object sender, EventArgs e)
		{
			this.bool_2 = true;
			this.method_11(null, false);
		}

		// Token: 0x06002E62 RID: 11874
		// RVA: 0x00023039 File Offset: 0x00021239
		private void label_MouseLeave(object sender, EventArgs e)
		{
			this.bool_2 = false;
			this.method_11(null, false);
		}

		// Token: 0x06002E63 RID: 11875
		// RVA: 0x0002304A File Offset: 0x0002124A
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://osu.zendesk.com/hc/en-us/articles/201584269");
		}

		// Token: 0x06002E5A RID: 11866
		// RVA: 0x0012CBD8 File Offset: 0x0012ADD8
		private void method_10()
		{
			try
			{
				MethodInvoker methodInvoker = null;
				Maintenance.Class769 class = new Maintenance.Class769();
				SplashScreen.smethod_3();
				base.method_1();
				class.bool_0 = Class41.bool_0;
				if (!class.bool_0)
				{
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(class.method_0);
					}
					base.Invoke(methodInvoker);
					int num = 20000;
					while (!class.bool_0)
					{
						if ((num -= 100) <= 0)
						{
							break;
						}
						this.method_11("Downloading localisation...", true);
						Thread.Sleep(100);
					}
				}
				try
				{
					IL_69:
					this.class48_0 = new Class48(Class905.guid_0, 500);
				}
				catch (Exception0)
				{
					if (!Class905.smethod_16())
					{
						this.method_11(Class41.GetString(OsuString.Maintenance_OsuIsAlreadyRunning), true);
						Thread.Sleep(100);
						goto IL_69;
					}
				}
				this.method_11(null, false);
				this.method_9(0f, OsuString.Maintenance_Hi);
			}
			catch
			{
			}
		}

		// Token: 0x06002E60 RID: 11872
		// RVA: 0x0012D55C File Offset: 0x0012B75C
		private void method_11(string string_2, bool bool_3)
		{
			if (string_2 != null)
			{
				this.bool_1 = bool_3;
				this.string_1 = string_2;
			}
			if (!this.bool_2 && !this.bool_1)
			{
				base.Invoke(new MethodInvoker(this.method_13));
				return;
			}
			base.Invoke(new MethodInvoker(this.method_12));
		}

		// Token: 0x06002E67 RID: 11879
		// RVA: 0x00023076 File Offset: 0x00021276
		[CompilerGenerated]
		private void method_12()
		{
			this.label.Text = this.string_1;
		}

		// Token: 0x06002E68 RID: 11880
		// RVA: 0x00023089 File Offset: 0x00021289
		[CompilerGenerated]
		private void method_13()
		{
			this.label.Text = Class41.GetString(OsuString.CommonUpdater_UpdatingGeneral);
		}

		// Token: 0x06002E57 RID: 11863
		// RVA: 0x0012CB9C File Offset: 0x0012AD9C
		private void method_9(float float_1, OsuString osuString_0)
		{
			Maintenance.Class768 class = new Maintenance.Class768();
			class.float_0 = float_1;
			class.osuString_0 = osuString_0;
			class.maintenance_0 = this;
			base.Invoke(new MethodInvoker(class.method_0));
		}

		// Token: 0x06002E56 RID: 11862
		// RVA: 0x00022FF9 File Offset: 0x000211F9
		protected override void OnClosing(CancelEventArgs e)
		{
			if (this.timer_1 != null)
			{
				this.timer_1.Dispose();
			}
			base.OnClosing(e);
		}

		// Token: 0x06002E55 RID: 11861
		// RVA: 0x0012CA80 File Offset: 0x0012AC80
		protected override void OnPaint(PaintEventArgs pevent)
		{
			Image image;
			Image image2;
			switch ((int)(this.float_0 % 4f))
			{
			case 1:
				image = this.image_1;
				image2 = this.image_2;
				break;
			case 2:
				image = this.image_2;
				image2 = this.image_3;
				break;
			case 3:
				image = this.image_3;
				image2 = this.image_0;
				break;
			default:
				image = this.image_0;
				image2 = this.image_1;
				break;
			}
			Graphics graphics = pevent.Graphics;
			float num = pevent.Graphics.DpiX / 96f;
			int width = (int)Math.Ceiling((double)(380f * num));
			int height = (int)Math.Ceiling((double)(350f * num));
			graphics.DrawImage(image, new Rectangle(0, 0, width, height), 0, 0, 380, 350, GraphicsUnit.Pixel);
			ColorMatrix colorMatrix = new ColorMatrix();
			ImageAttributes imageAttributes = new ImageAttributes();
			colorMatrix.Matrix33 = this.float_0 % 1f;
			imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
			graphics.DrawImage(image2, new Rectangle(0, 0, width, height), 0, 0, 380, 350, GraphicsUnit.Pixel, imageAttributes);
			base.OnPaint(pevent);
		}

		// Token: 0x06002E51 RID: 11857
		// RVA: 0x00022FAF File Offset: 0x000211AF
		private static string smethod_3()
		{
			return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "osu!.lnk");
		}

		// Token: 0x06002E52 RID: 11858
		// RVA: 0x00022FC2 File Offset: 0x000211C2
		private static string smethod_4()
		{
			return Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu), "Programs"), "osu!.lnk");
		}

		// Token: 0x06002E66 RID: 11878
		// RVA: 0x0000653E File Offset: 0x0000473E
		[CompilerGenerated]
		private static void smethod_5(Enum32 enum32_0)
		{
		}

		// Token: 0x06002E54 RID: 11860
		// RVA: 0x00022FDF File Offset: 0x000211DF
		private void timer_1_Tick(object sender, EventArgs e)
		{
			this.float_0 += 0.01f;
			base.Invalidate();
		}
	}
}
