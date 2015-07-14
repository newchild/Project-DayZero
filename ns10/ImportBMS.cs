using ns29;
using ns67;
using ns8;
using osu;
using osu.GameModes.Edit;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns10
{
	// Token: 0x0200037B RID: 891
	internal sealed class ImportBMS : Form2
	{
		// Token: 0x04001589 RID: 5513
		private Button b_cancel;

		// Token: 0x04001580 RID: 5504
		private Button b_file;

		// Token: 0x04001588 RID: 5512
		private Button b_start;

		// Token: 0x04001587 RID: 5511
		private CheckBox cb_clear;

		// Token: 0x0400158B RID: 5515
		private CheckBox cb_effect;

		// Token: 0x04001584 RID: 5508
		private ComboBox cb_encode;

		// Token: 0x04001585 RID: 5509
		private CheckBox cb_image;

		// Token: 0x04001582 RID: 5506
		private CheckBox cb_meta;

		// Token: 0x04001586 RID: 5510
		private CheckBox cb_sample;

		// Token: 0x0400157F RID: 5503
		private IContainer icontainer_0;

		// Token: 0x04001583 RID: 5507
		private Label label1;

		// Token: 0x0400158A RID: 5514
		private OpenFileDialog openFileDialog_0;

		// Token: 0x04001581 RID: 5505
		private TextBox tb_file;

		// Token: 0x06001AF3 RID: 6899
		// RVA: 0x00016998 File Offset: 0x00014B98
		public ImportBMS()
		{
			this.InitializeComponent();
		}

		// Token: 0x06001AF7 RID: 6903
		// RVA: 0x00016831 File Offset: 0x00014A31
		private void b_cancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06001AF5 RID: 6901
		// RVA: 0x000169BB File Offset: 0x00014BBB
		private void b_file_Click(object sender, EventArgs e)
		{
			if (this.openFileDialog_0.ShowDialog() == DialogResult.OK)
			{
				this.tb_file.Text = this.openFileDialog_0.FileName;
			}
		}

		// Token: 0x06001AF8 RID: 6904
		// RVA: 0x00086A38 File Offset: 0x00084C38
		private void b_start_Click(object sender, EventArgs e)
		{
			if (this.tb_file.Text == "")
			{
				MessageBox.Show("Select a bms file first!");
				return;
			}
			Editor editor_ = Editor.editor_0;
			editor_.method_16(false);
			if (this.cb_clear.Checked)
			{
				editor_.class297_0.Clear();
			}
			if (!this.cb_effect.Checked)
			{
				editor_.class872_0.list_2.Clear();
			}
			Class368 class = new Class368(editor_);
			class.bool_2 = this.cb_image.Checked;
			class.bool_0 = this.cb_sample.Checked;
			class.bool_1 = this.cb_effect.Checked;
			class.bool_3 = this.cb_meta.Checked;
			if (class.method_0(this.tb_file.Text, this.cb_encode.SelectedItem.ToString()))
			{
				class.Clear();
				base.Close();
				editor_.class297_0.method_3(false, false, false);
				Class115.smethod_70(OsuModes.Edit, true);
				return;
			}
			base.Close();
		}

		// Token: 0x06001AF6 RID: 6902
		// RVA: 0x000169E1 File Offset: 0x00014BE1
		private void cb_meta_CheckedChanged(object sender, EventArgs e)
		{
			this.cb_encode.Enabled = this.cb_meta.Checked;
		}

		// Token: 0x06001AF9 RID: 6905
		// RVA: 0x000169F9 File Offset: 0x00014BF9
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001AFA RID: 6906
		// RVA: 0x00086B44 File Offset: 0x00084D44
		private void InitializeComponent()
		{
			this.b_file = new Button();
			this.tb_file = new TextBox();
			this.cb_meta = new CheckBox();
			this.label1 = new Label();
			this.cb_encode = new ComboBox();
			this.cb_image = new CheckBox();
			this.cb_sample = new CheckBox();
			this.cb_clear = new CheckBox();
			this.b_start = new Button();
			this.b_cancel = new Button();
			this.openFileDialog_0 = new OpenFileDialog();
			this.cb_effect = new CheckBox();
			base.SuspendLayout();
			this.b_file.Location = new Point(11, 11);
			this.b_file.Name = "b_file";
			this.b_file.Size = new Size(75, 23);
			this.b_file.TabIndex = 0;
			this.b_file.Text = "Select file";
			this.b_file.UseVisualStyleBackColor = true;
			this.b_file.Click += new EventHandler(this.b_file_Click);
			this.tb_file.BorderStyle = BorderStyle.FixedSingle;
			this.tb_file.Location = new Point(92, 12);
			this.tb_file.Name = "tb_file";
			this.tb_file.ReadOnly = true;
			this.tb_file.Size = new Size(244, 21);
			this.tb_file.TabIndex = 1;
			this.cb_meta.AutoSize = true;
			this.cb_meta.Location = new Point(12, 48);
			this.cb_meta.Name = "cb_meta";
			this.cb_meta.Size = new Size(115, 21);
			this.cb_meta.TabIndex = 2;
			this.cb_meta.Text = "Override meta ";
			this.cb_meta.UseVisualStyleBackColor = true;
			this.cb_meta.CheckedChanged += new EventHandler(this.cb_meta_CheckedChanged);
			this.label1.AutoSize = true;
			this.label1.Location = new Point(153, 49);
			this.label1.Name = "label1";
			this.label1.Size = new Size(74, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "File encode";
			this.cb_encode.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cb_encode.Enabled = false;
			this.cb_encode.FormattingEnabled = true;
			this.cb_encode.Items.AddRange(new object[]
			{
				"utf-8",
				"gb2312",
				"big5",
				"shift_jis"
			});
			this.cb_encode.Location = new Point(233, 49);
			this.cb_encode.Name = "cb_encode";
			this.cb_encode.Size = new Size(103, 20);
			this.cb_encode.TabIndex = 4;
			this.cb_image.AutoSize = true;
			this.cb_image.Checked = true;
			this.cb_image.CheckState = CheckState.Checked;
			this.cb_image.Location = new Point(12, 79);
			this.cb_image.Name = "cb_image";
			this.cb_image.Size = new Size(193, 21);
			this.cb_image.TabIndex = 5;
			this.cb_image.Text = "Override background image";
			this.cb_image.UseVisualStyleBackColor = true;
			this.cb_sample.AutoSize = true;
			this.cb_sample.Location = new Point(12, 112);
			this.cb_sample.Name = "cb_sample";
			this.cb_sample.Size = new Size(148, 21);
			this.cb_sample.TabIndex = 6;
			this.cb_sample.Text = "Ignore note samples";
			this.cb_sample.UseVisualStyleBackColor = true;
			this.cb_clear.AutoSize = true;
			this.cb_clear.Checked = true;
			this.cb_clear.CheckState = CheckState.Checked;
			this.cb_clear.Location = new Point(12, 183);
			this.cb_clear.Name = "cb_clear";
			this.cb_clear.Size = new Size(196, 21);
			this.cb_clear.TabIndex = 7;
			this.cb_clear.Text = "Clear all notes before import";
			this.cb_clear.UseVisualStyleBackColor = true;
			this.b_start.Location = new Point(12, 226);
			this.b_start.Name = "b_start";
			this.b_start.Size = new Size(215, 38);
			this.b_start.TabIndex = 8;
			this.b_start.Text = "Start";
			this.b_start.UseVisualStyleBackColor = true;
			this.b_start.Click += new EventHandler(this.b_start_Click);
			this.b_cancel.Location = new Point(244, 226);
			this.b_cancel.Name = "b_cancel";
			this.b_cancel.Size = new Size(93, 38);
			this.b_cancel.TabIndex = 9;
			this.b_cancel.Text = "Cancel";
			this.b_cancel.UseVisualStyleBackColor = true;
			this.b_cancel.Click += new EventHandler(this.b_cancel_Click);
			this.openFileDialog_0.FileName = "openFileDialog1";
			this.openFileDialog_0.Filter = "BMS file|*.bms;*.bme";
			this.cb_effect.AutoSize = true;
			this.cb_effect.Location = new Point(12, 144);
			this.cb_effect.Name = "cb_effect";
			this.cb_effect.Size = new Size(154, 21);
			this.cb_effect.TabIndex = 10;
			this.cb_effect.Text = "Ignore effect samples";
			this.cb_effect.UseVisualStyleBackColor = true;
			base.AcceptButton = this.b_start;
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			base.ClientSize = new Size(349, 282);
			base.Controls.Add(this.cb_effect);
			base.Controls.Add(this.b_cancel);
			base.Controls.Add(this.b_start);
			base.Controls.Add(this.cb_clear);
			base.Controls.Add(this.cb_sample);
			base.Controls.Add(this.cb_image);
			base.Controls.Add(this.cb_encode);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.cb_meta);
			base.Controls.Add(this.tb_file);
			base.Controls.Add(this.b_file);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ImportBMS";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Import from bms";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06001AF4 RID: 6900
		// RVA: 0x000169A6 File Offset: 0x00014BA6
		protected override void OnShown(EventArgs e)
		{
			this.cb_encode.SelectedIndex = 0;
			base.OnShown(e);
		}
	}
}
