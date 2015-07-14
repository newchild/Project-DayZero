using Microsoft.Xna.Framework;
using ns20;
using ns27;
using ns29;
using ns64;
using ns79;
using ns8;
using osu;
using osu_common;
using osu_common.Updater;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns11
{
	// Token: 0x020004A3 RID: 1187
	internal sealed class Configuration : Form3
	{
		// Token: 0x04001F71 RID: 8049
		private Button buttonRepair;

		// Token: 0x04001F6D RID: 8045
		private Button buttonResetSettings;

		// Token: 0x04001F6C RID: 8044
		private Button buttonStartOsu;

		// Token: 0x04001F68 RID: 8040
		private CheckBox checkBoxFullScreen;

		// Token: 0x04001F62 RID: 8034
		private Class753 class753_0 = new Class753(null, string.Empty, Vector2.get_Zero());

		// Token: 0x04001F65 RID: 8037
		private ComboBox comboBoxFrameLimiter;

		// Token: 0x04001F67 RID: 8039
		private ComboBox comboBoxRenderer;

		// Token: 0x04001F72 RID: 8050
		private ComboBox comboBoxResolutions;

		// Token: 0x04001F6A RID: 8042
		private GroupBox groupBox1;

		// Token: 0x04001F6E RID: 8046
		private GroupBox groupBox2;

		// Token: 0x04001F63 RID: 8035
		private IContainer icontainer_0;

		// Token: 0x04001F6F RID: 8047
		private Label label3;

		// Token: 0x04001F64 RID: 8036
		private Label labelFrameLimiter;

		// Token: 0x04001F66 RID: 8038
		private Label labelRenderer;

		// Token: 0x04001F69 RID: 8041
		private Label labelResolution;

		// Token: 0x04001F6B RID: 8043
		private Panel panel1;

		// Token: 0x04001F70 RID: 8048
		private ComboBox releaseStreams;

		// Token: 0x04001F61 RID: 8033
		private ReleaseStream releaseStream_0 = Class341.class605_25.Value;

		// Token: 0x060025FA RID: 9722
		// RVA: 0x0001D7AC File Offset: 0x0001B9AC
		public Configuration()
		{
			this.InitializeComponent();
			this.method_10();
		}

		// Token: 0x060025FE RID: 9726
		// RVA: 0x000E3EF4 File Offset: 0x000E20F4
		private void buttonRepair_Click(object sender, EventArgs e)
		{
			try
			{
				Class341.smethod_3();
			}
			catch
			{
			}
			Class905.smethod_11(false);
		}

		// Token: 0x060025FD RID: 9725
		// RVA: 0x000E3E98 File Offset: 0x000E2098
		protected void buttonResetSettings_Click(object sender, EventArgs e)
		{
			Class341.class605_8.Reset();
			Class341.class605_26.Reset();
			Class341.class605_18.Reset();
			Class341.class608_11.Reset();
			Class341.class608_5.Reset();
			Class341.class608_12.Reset();
			Class341.class608_6.Reset();
			this.method_10();
		}

		// Token: 0x060025FC RID: 9724
		// RVA: 0x000E3E1C File Offset: 0x000E201C
		protected void buttonStartOsu_Click(object sender, EventArgs e)
		{
			Class341.class605_18.Value = this.comboBoxRenderer.SelectedItem.ToString().Trim().ToLower();
			Class341.class605_8.Value = (this.checkBoxFullScreen.Checked ? ScreenMode.Fullscreen : ScreenMode.Windowed);
			base.DialogResult = DialogResult.OK;
			try
			{
				Class341.smethod_3();
			}
			catch
			{
				base.DialogResult = DialogResult.Abort;
			}
			base.Close();
		}

		// Token: 0x06002602 RID: 9730
		// RVA: 0x0001D825 File Offset: 0x0001BA25
		private void checkBoxFullScreen_CheckedChanged(object sender, EventArgs e)
		{
			Class341.class605_8.Value = (this.checkBoxFullScreen.Checked ? ScreenMode.Fullscreen : ScreenMode.Windowed);
			this.method_10();
		}

		// Token: 0x06002601 RID: 9729
		// RVA: 0x0001D7FF File Offset: 0x0001B9FF
		private void comboBoxFrameLimiter_SelectedIndexChanged(object sender, EventArgs e)
		{
			Class341.class605_26.Value = (FrameSync)((Class557)this.comboBoxFrameLimiter.SelectedItem).object_0;
		}

		// Token: 0x06002603 RID: 9731
		// RVA: 0x0001D848 File Offset: 0x0001BA48
		private void comboBoxRenderer_SelectedIndexChanged(object sender, EventArgs e)
		{
			Class341.class605_18.Value = ((this.comboBoxRenderer.SelectedIndex == 0) ? "opengl" : "d3d");
		}

		// Token: 0x06002604 RID: 9732
		// RVA: 0x000E3F90 File Offset: 0x000E2190
		private void comboBoxResolutions_SelectedIndexChanged(object sender, EventArgs e)
		{
			Class557 class = (Class557)this.comboBoxResolutions.SelectedItem;
			if (class.object_0 == null)
			{
				if (this.comboBoxResolutions.Items.Count <= this.comboBoxResolutions.SelectedIndex + 1)
				{
					return;
				}
				class = (Class557)this.comboBoxResolutions.SelectedItem;
			}
			string[] array = ((string)class.object_0).Split(new char[]
			{
				'x'
			});
			int value = int.Parse(array[0]);
			int value2 = int.Parse(array[1]);
			if (Class341.class606_74.Value)
			{
				Class341.class608_12.Value = value;
				Class341.class608_6.Value = value2;
				return;
			}
			Class341.class608_11.Value = value;
			Class341.class608_5.Value = value2;
		}

		// Token: 0x060025FF RID: 9727
		// RVA: 0x0001D7E6 File Offset: 0x0001B9E6
		private void Configuration_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.WindowsShutDown || base.DialogResult == DialogResult.Cancel)
			{
				Class905.smethod_12();
			}
		}

		// Token: 0x06002605 RID: 9733
		// RVA: 0x0001D86D File Offset: 0x0001BA6D
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002606 RID: 9734
		// RVA: 0x000E4054 File Offset: 0x000E2254
		private void InitializeComponent()
		{
			this.groupBox2 = new GroupBox();
			this.label3 = new Label();
			this.releaseStreams = new ComboBox();
			this.panel1 = new Panel();
			this.buttonRepair = new Button();
			this.buttonStartOsu = new Button();
			this.buttonResetSettings = new Button();
			this.groupBox1 = new GroupBox();
			this.labelRenderer = new Label();
			this.checkBoxFullScreen = new CheckBox();
			this.comboBoxRenderer = new ComboBox();
			this.labelResolution = new Label();
			this.labelFrameLimiter = new Label();
			this.comboBoxFrameLimiter = new ComboBox();
			this.comboBoxResolutions = new ComboBox();
			this.groupBox2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.releaseStreams);
			this.groupBox2.Location = new Point(13, 159);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new Size(336, 69);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Recovery";
			this.label3.AutoSize = true;
			this.label3.ForeColor = Color.Black;
			this.label3.Location = new Point(5, 33);
			this.label3.Margin = new Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new Size(89, 15);
			this.label3.TabIndex = 1;
			this.label3.Text = "Release Stream:";
			this.releaseStreams.DropDownStyle = ComboBoxStyle.DropDownList;
			this.releaseStreams.FormattingEnabled = true;
			this.releaseStreams.Location = new Point(99, 30);
			this.releaseStreams.Margin = new Padding(2, 3, 2, 3);
			this.releaseStreams.Name = "releaseStreams";
			this.releaseStreams.Size = new Size(227, 21);
			this.releaseStreams.TabIndex = 0;
			this.releaseStreams.SelectedIndexChanged += new EventHandler(this.releaseStreams_SelectedIndexChanged);
			this.panel1.BackColor = Color.FromArgb(85, 85, 85);
			this.panel1.Controls.Add(this.buttonRepair);
			this.panel1.Controls.Add(this.buttonStartOsu);
			this.panel1.Controls.Add(this.buttonResetSettings);
			this.panel1.Dock = DockStyle.Bottom;
			this.panel1.Location = new Point(0, 244);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(361, 141);
			this.panel1.TabIndex = 8;
			this.buttonRepair.FlatAppearance.BorderColor = Color.DimGray;
			this.buttonRepair.FlatAppearance.BorderSize = 0;
			this.buttonRepair.FlatAppearance.MouseDownBackColor = Color.FromArgb(205, 18, 18);
			this.buttonRepair.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 44, 44);
			this.buttonRepair.FlatStyle = FlatStyle.Flat;
			this.buttonRepair.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.buttonRepair.ForeColor = Color.White;
			this.buttonRepair.Location = new Point(7, 98);
			this.buttonRepair.Name = "buttonRepair";
			this.buttonRepair.Size = new Size(350, 35);
			this.buttonRepair.TabIndex = 7;
			this.buttonRepair.Text = "repair osu!";
			this.buttonRepair.UseVisualStyleBackColor = true;
			this.buttonRepair.Click += new EventHandler(this.buttonRepair_Click);
			this.buttonStartOsu.FlatAppearance.BorderColor = Color.DimGray;
			this.buttonStartOsu.FlatAppearance.BorderSize = 0;
			this.buttonStartOsu.FlatAppearance.MouseDownBackColor = Color.FromArgb(61, 172, 220);
			this.buttonStartOsu.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 127, 161);
			this.buttonStartOsu.FlatStyle = FlatStyle.Flat;
			this.buttonStartOsu.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.buttonStartOsu.ForeColor = Color.White;
			this.buttonStartOsu.Location = new Point(7, 14);
			this.buttonStartOsu.Name = "buttonStartOsu";
			this.buttonStartOsu.Size = new Size(350, 35);
			this.buttonStartOsu.TabIndex = 2;
			this.buttonStartOsu.Text = "start osu!";
			this.buttonStartOsu.UseVisualStyleBackColor = true;
			this.buttonStartOsu.Click += new EventHandler(this.buttonStartOsu_Click);
			this.buttonResetSettings.FlatAppearance.BorderColor = Color.DimGray;
			this.buttonResetSettings.FlatAppearance.BorderSize = 0;
			this.buttonResetSettings.FlatStyle = FlatStyle.Flat;
			this.buttonResetSettings.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.buttonResetSettings.ForeColor = Color.White;
			this.buttonResetSettings.Location = new Point(7, 57);
			this.buttonResetSettings.Name = "buttonResetSettings";
			this.buttonResetSettings.Size = new Size(350, 35);
			this.buttonResetSettings.TabIndex = 6;
			this.buttonResetSettings.Text = "reset settings";
			this.buttonResetSettings.UseVisualStyleBackColor = true;
			this.buttonResetSettings.Click += new EventHandler(this.buttonResetSettings_Click);
			this.groupBox1.Controls.Add(this.comboBoxResolutions);
			this.groupBox1.Controls.Add(this.labelRenderer);
			this.groupBox1.Controls.Add(this.checkBoxFullScreen);
			this.groupBox1.Controls.Add(this.comboBoxRenderer);
			this.groupBox1.Controls.Add(this.labelResolution);
			this.groupBox1.Controls.Add(this.labelFrameLimiter);
			this.groupBox1.Controls.Add(this.comboBoxFrameLimiter);
			this.groupBox1.Location = new Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new Size(336, 134);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Graphics";
			this.labelRenderer.AutoSize = true;
			this.labelRenderer.ForeColor = Color.Black;
			this.labelRenderer.Location = new Point(5, 64);
			this.labelRenderer.Margin = new Padding(2, 0, 2, 0);
			this.labelRenderer.Name = "labelRenderer";
			this.labelRenderer.Size = new Size(54, 15);
			this.labelRenderer.TabIndex = 1;
			this.labelRenderer.Text = "Renderer";
			this.checkBoxFullScreen.AutoSize = true;
			this.checkBoxFullScreen.ForeColor = Color.Black;
			this.checkBoxFullScreen.Location = new Point(239, 63);
			this.checkBoxFullScreen.Margin = new Padding(2, 3, 2, 3);
			this.checkBoxFullScreen.Name = "checkBoxFullScreen";
			this.checkBoxFullScreen.Size = new Size(83, 19);
			this.checkBoxFullScreen.TabIndex = 2;
			this.checkBoxFullScreen.Text = "Full Screen";
			this.checkBoxFullScreen.UseVisualStyleBackColor = true;
			this.checkBoxFullScreen.CheckedChanged += new EventHandler(this.checkBoxFullScreen_CheckedChanged);
			this.comboBoxRenderer.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBoxRenderer.FormattingEnabled = true;
			this.comboBoxRenderer.Location = new Point(100, 61);
			this.comboBoxRenderer.Margin = new Padding(2, 3, 2, 3);
			this.comboBoxRenderer.Name = "comboBoxRenderer";
			this.comboBoxRenderer.Size = new Size(127, 21);
			this.comboBoxRenderer.TabIndex = 0;
			this.comboBoxRenderer.SelectedIndexChanged += new EventHandler(this.comboBoxRenderer_SelectedIndexChanged);
			this.labelResolution.AutoSize = true;
			this.labelResolution.ForeColor = Color.Black;
			this.labelResolution.Location = new Point(5, 29);
			this.labelResolution.Margin = new Padding(2, 0, 2, 0);
			this.labelResolution.Name = "labelResolution";
			this.labelResolution.Size = new Size(63, 15);
			this.labelResolution.TabIndex = 1;
			this.labelResolution.Text = "Resolution";
			this.labelFrameLimiter.AutoSize = true;
			this.labelFrameLimiter.ForeColor = Color.Black;
			this.labelFrameLimiter.Location = new Point(5, 100);
			this.labelFrameLimiter.Margin = new Padding(2, 0, 2, 0);
			this.labelFrameLimiter.Name = "labelFrameLimiter";
			this.labelFrameLimiter.Size = new Size(80, 15);
			this.labelFrameLimiter.TabIndex = 1;
			this.labelFrameLimiter.Text = "Frame Limiter";
			this.comboBoxFrameLimiter.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBoxFrameLimiter.FormattingEnabled = true;
			this.comboBoxFrameLimiter.Location = new Point(100, 97);
			this.comboBoxFrameLimiter.Margin = new Padding(2, 3, 2, 3);
			this.comboBoxFrameLimiter.Name = "comboBoxFrameLimiter";
			this.comboBoxFrameLimiter.Size = new Size(227, 21);
			this.comboBoxFrameLimiter.TabIndex = 0;
			this.comboBoxFrameLimiter.SelectedIndexChanged += new EventHandler(this.comboBoxFrameLimiter_SelectedIndexChanged);
			this.comboBoxResolutions.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBoxResolutions.FormattingEnabled = true;
			this.comboBoxResolutions.Location = new Point(100, 25);
			this.comboBoxResolutions.Margin = new Padding(2, 3, 2, 3);
			this.comboBoxResolutions.Name = "comboBoxResolutions";
			this.comboBoxResolutions.Size = new Size(227, 23);
			this.comboBoxResolutions.TabIndex = 3;
			this.comboBoxResolutions.SelectedIndexChanged += new EventHandler(this.comboBoxResolutions_SelectedIndexChanged);
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.BackColor = SystemColors.Control;
			base.ClientSize = new Size(361, 385);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.groupBox1);
			this.Font = new Font("Segoe UI", 9f);
			this.ForeColor = Color.Black;
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.Margin = new Padding(2, 3, 2, 3);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Configuration";
			base.Opacity = 1.0;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "osu! configuration";
			base.TopMost = true;
			base.FormClosing += new FormClosingEventHandler(this.Configuration_FormClosing);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x060025FB RID: 9723
		// RVA: 0x000E3BDC File Offset: 0x000E1DDC
		protected void method_10()
		{
			this.checkBoxFullScreen.Checked = (Class341.class605_8.Value == ScreenMode.Fullscreen);
			this.releaseStreams.Items.Clear();
			foreach (Class557 current in Class80.smethod_5())
			{
				this.releaseStreams.Items.Add(current);
				if ((ReleaseStream)current.object_0 == Class341.class605_25.Value)
				{
					this.releaseStreams.SelectedItem = current;
				}
			}
			this.comboBoxRenderer.Items.Clear();
			this.comboBoxRenderer.Items.Add("OpenGL");
			this.comboBoxRenderer.Items.Add("DirectX");
			this.comboBoxRenderer.SelectedIndex = ((Class341.class605_18 == "opengl") ? 0 : 1);
			this.comboBoxFrameLimiter.Items.Clear();
			foreach (Class557 current2 in Class80.smethod_6())
			{
				this.comboBoxFrameLimiter.Items.Add(current2);
				if ((FrameSync)current2.object_0 == Class341.class605_26.Value)
				{
					this.comboBoxFrameLimiter.SelectedItem = current2;
				}
			}
			this.comboBoxResolutions.Items.Clear();
			Class80.smethod_4(this.class753_0);
			foreach (Class533 current3 in this.class753_0.list_1)
			{
				if (!(current3 is Class534))
				{
					Class557 class = new Class557(current3.Text, current3.object_0);
					this.comboBoxResolutions.Items.Add(class);
					if ((string)current3.object_0 == (string)this.class753_0.object_0)
					{
						this.comboBoxResolutions.SelectedItem = class;
					}
				}
			}
		}

		// Token: 0x06002600 RID: 9728
		// RVA: 0x000E3F24 File Offset: 0x000E2124
		private void releaseStreams_SelectedIndexChanged(object sender, EventArgs e)
		{
			Class341.class605_25.Value = (ReleaseStream)((Class557)this.releaseStreams.SelectedItem).object_0;
			this.buttonStartOsu.Enabled = (this.releaseStream_0 == Class341.class605_25.Value);
			this.buttonResetSettings.Enabled = (this.releaseStream_0 == Class341.class605_25.Value);
		}
	}
}
