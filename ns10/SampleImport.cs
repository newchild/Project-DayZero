using ns24;
using ns26;
using ns29;
using ns8;
using ns89;
using ns90;
using osu.GameModes.Edit;
using osu.GameplayElements.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ns10
{
	// Token: 0x0200037D RID: 893
	internal sealed class SampleImport : Form2
	{
		// Token: 0x0400159A RID: 5530
		private Button b_apply;

		// Token: 0x04001599 RID: 5529
		private Button b_cancel;

		// Token: 0x040015A1 RID: 5537
		private Button b_del;

		// Token: 0x040015A8 RID: 5544
		private Button b_list;

		// Token: 0x0400159B RID: 5531
		private Button b_open;

		// Token: 0x0400159D RID: 5533
		private Button b_play;

		// Token: 0x0400159C RID: 5532
		private Button b_reset;

		// Token: 0x040015A7 RID: 5543
		private Button b_sample;

		// Token: 0x040015A4 RID: 5540
		private CheckBox cb_basic;

		// Token: 0x04001597 RID: 5527
		private Class339 class339_0;

		// Token: 0x04001594 RID: 5524
		private Editor editor_0;

		// Token: 0x040015A2 RID: 5538
		private GroupBox groupBox1;

		// Token: 0x04001598 RID: 5528
		private IContainer icontainer_0;

		// Token: 0x040015A0 RID: 5536
		private Label label1;

		// Token: 0x040015A5 RID: 5541
		private Label label3;

		// Token: 0x0400159E RID: 5534
		private ListBox lb_sample;

		// Token: 0x04001596 RID: 5526
		private static List<string> list_0;

		// Token: 0x040015A3 RID: 5539
		private NumericUpDown nud_custom;

		// Token: 0x0400159F RID: 5535
		private NumericUpDown nud_vol;

		// Token: 0x04001595 RID: 5525
		internal static string string_0 = "";

		// Token: 0x040015A6 RID: 5542
		private ToolTip toolTip_0;

		// Token: 0x06001B04 RID: 6916
		// RVA: 0x00016A9C File Offset: 0x00014C9C
		public SampleImport()
		{
			this.InitializeComponent();
		}

		// Token: 0x06001B0A RID: 6922
		// RVA: 0x00087978 File Offset: 0x00085B78
		private void b_apply_Click(object sender, EventArgs e)
		{
			if (this.cb_basic.Checked)
			{
				this.editor_0.method_16(false);
				this.editor_0.class371_0.method_69((int)this.nud_custom.Value, (int)this.nud_vol.Value);
			}
			else
			{
				if (this.lb_sample.SelectedItem == null)
				{
					Class723.smethod_1("You havn't selected a sample yet.", 2000);
					return;
				}
				string a = this.lb_sample.SelectedItem.ToString();
				this.editor_0.method_16(false);
				if (a == "None")
				{
					this.editor_0.class371_0.method_68(string.Empty, (int)this.nud_vol.Value);
				}
				else
				{
					this.editor_0.class371_0.method_68(a, (int)this.nud_vol.Value);
				}
			}
			Class723.smethod_1("Done", 1000);
		}

		// Token: 0x06001B0B RID: 6923
		// RVA: 0x00016831 File Offset: 0x00014A31
		private void b_cancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06001B0D RID: 6925
		// RVA: 0x00087AD4 File Offset: 0x00085CD4
		private void b_del_Click(object sender, EventArgs e)
		{
			if (this.lb_sample.SelectedItem == null)
			{
				return;
			}
			string text = this.lb_sample.SelectedItem.ToString();
			if (text == "None")
			{
				return;
			}
			Class331.smethod_39(text.Substring(0, text.LastIndexOf('.')));
			this.lb_sample.Items.RemoveAt(this.lb_sample.SelectedIndex);
			SampleImport.list_0.Remove(text);
			string path = Path.Combine(Class466.Current.method_3(), text);
			if (File.Exists(path))
			{
				File.Delete(path);
			}
		}

		// Token: 0x06001B11 RID: 6929
		// RVA: 0x00087C00 File Offset: 0x00085E00
		private void b_list_Click(object sender, EventArgs e)
		{
			SampleList sampleList = new SampleList();
			sampleList.ShowDialog(Class115.form_0);
		}

		// Token: 0x06001B07 RID: 6919
		// RVA: 0x000877FC File Offset: 0x000859FC
		private void b_open_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Sample file|*.wav;*.ogg;*.mp3";
			if (openFileDialog.ShowDialog(Class115.form_0) == DialogResult.OK)
			{
				this.method_9(openFileDialog.FileName);
			}
		}

		// Token: 0x06001B08 RID: 6920
		// RVA: 0x00087834 File Offset: 0x00085A34
		private void b_play_Click(object sender, EventArgs e)
		{
			if (this.lb_sample.SelectedItem == null)
			{
				return;
			}
			string text = this.lb_sample.SelectedItem.ToString();
			if (text == "None")
			{
				return;
			}
			if (this.class339_0 != null)
			{
				this.class339_0.method_11(true);
				this.class339_0 = null;
			}
			int num = Class331.smethod_38(text, false, false, false);
			if (num != -1)
			{
				this.class339_0 = Class331.smethod_61(num, (int)this.nud_vol.Value, 0f, false, 1f);
			}
		}

		// Token: 0x06001B0C RID: 6924
		// RVA: 0x00087A74 File Offset: 0x00085C74
		private void b_reset_Click(object sender, EventArgs e)
		{
			this.editor_0.method_16(false);
			if (this.cb_basic.Checked)
			{
				this.editor_0.class371_0.method_69(0, 0);
			}
			else
			{
				this.editor_0.class371_0.method_68(string.Empty, 0);
			}
			Class723.smethod_1("Selected objects' hit samples have been reset.", 2000);
		}

		// Token: 0x06001B0F RID: 6927
		// RVA: 0x00087B68 File Offset: 0x00085D68
		private void b_sample_Click(object sender, EventArgs e)
		{
			if (this.lb_sample.SelectedItem == null)
			{
				return;
			}
			string text = this.lb_sample.SelectedItem.ToString();
			if (text == "None")
			{
				return;
			}
			int int_ = Class331.smethod_38(text, false, false, false);
			Class704 class = new Class704(int_, text, Class331.int_7, StoryLayer.Background, (int)this.nud_vol.Value);
			class.bool_2 = true;
			this.editor_0.method_16(false);
			this.editor_0.class872_0.Add(class);
			Class723.smethod_1("Done", 1000);
		}

		// Token: 0x06001B06 RID: 6918
		// RVA: 0x00016AAA File Offset: 0x00014CAA
		internal static void Clear()
		{
			if (SampleImport.list_0 != null)
			{
				SampleImport.list_0.Clear();
			}
			SampleImport.list_0 = null;
		}

		// Token: 0x06001B13 RID: 6931
		// RVA: 0x00016AED File Offset: 0x00014CED
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001B14 RID: 6932
		// RVA: 0x00087C6C File Offset: 0x00085E6C
		private void InitializeComponent()
		{
			this.icontainer_0 = new Container();
			this.b_cancel = new Button();
			this.b_apply = new Button();
			this.b_open = new Button();
			this.b_reset = new Button();
			this.b_play = new Button();
			this.lb_sample = new ListBox();
			this.nud_vol = new NumericUpDown();
			this.label1 = new Label();
			this.b_del = new Button();
			this.groupBox1 = new GroupBox();
			this.nud_custom = new NumericUpDown();
			this.cb_basic = new CheckBox();
			this.label3 = new Label();
			this.toolTip_0 = new ToolTip(this.icontainer_0);
			this.b_sample = new Button();
			this.b_list = new Button();
			((ISupportInitialize)this.nud_vol).BeginInit();
			this.groupBox1.SuspendLayout();
			((ISupportInitialize)this.nud_custom).BeginInit();
			base.SuspendLayout();
			this.b_cancel.DialogResult = DialogResult.Cancel;
			this.b_cancel.Location = new Point(333, 305);
			this.b_cancel.Name = "b_cancel";
			this.b_cancel.Size = new Size(86, 30);
			this.b_cancel.TabIndex = 4;
			this.b_cancel.Text = "Cancel";
			this.b_cancel.UseVisualStyleBackColor = true;
			this.b_cancel.Click += new EventHandler(this.b_cancel_Click);
			this.b_apply.Location = new Point(283, 219);
			this.b_apply.Name = "b_apply";
			this.b_apply.Size = new Size(86, 30);
			this.b_apply.TabIndex = 3;
			this.b_apply.Text = "Apply";
			this.toolTip_0.SetToolTip(this.b_apply, "Apply to selected notes");
			this.b_apply.UseVisualStyleBackColor = true;
			this.b_apply.Click += new EventHandler(this.b_apply_Click);
			this.b_open.Location = new Point(232, 178);
			this.b_open.Name = "b_open";
			this.b_open.Size = new Size(86, 30);
			this.b_open.TabIndex = 6;
			this.b_open.Text = "Import";
			this.b_open.UseVisualStyleBackColor = true;
			this.b_open.Click += new EventHandler(this.b_open_Click);
			this.b_reset.Location = new Point(232, 305);
			this.b_reset.Name = "b_reset";
			this.b_reset.Size = new Size(86, 30);
			this.b_reset.TabIndex = 14;
			this.b_reset.Text = "Reset";
			this.toolTip_0.SetToolTip(this.b_reset, "Reset selected notes' sample");
			this.b_reset.UseVisualStyleBackColor = true;
			this.b_reset.Click += new EventHandler(this.b_reset_Click);
			this.b_play.Location = new Point(284, 136);
			this.b_play.Name = "b_play";
			this.b_play.Size = new Size(86, 30);
			this.b_play.TabIndex = 15;
			this.b_play.Text = "Play";
			this.b_play.UseVisualStyleBackColor = true;
			this.b_play.Click += new EventHandler(this.b_play_Click);
			this.lb_sample.FormattingEnabled = true;
			this.lb_sample.ItemHeight = 12;
			this.lb_sample.Location = new Point(8, 11);
			this.lb_sample.Name = "lb_sample";
			this.lb_sample.Size = new Size(204, 328);
			this.lb_sample.TabIndex = 16;
			this.lb_sample.SelectedIndexChanged += new EventHandler(this.lb_sample_SelectedIndexChanged);
			this.lb_sample.DoubleClick += new EventHandler(this.lb_sample_DoubleClick);
			NumericUpDown arg_43B_0 = this.nud_vol;
			int[] array = new int[4];
			array[0] = 5;
			arg_43B_0.Increment = new decimal(array);
			this.nud_vol.Location = new Point(95, 58);
			NumericUpDown arg_46B_0 = this.nud_vol;
			int[] array2 = new int[4];
			array2[0] = 8;
			arg_46B_0.Minimum = new decimal(array2);
			this.nud_vol.Name = "nud_vol";
			this.nud_vol.Size = new Size(85, 21);
			this.nud_vol.TabIndex = 17;
			this.nud_vol.TextAlign = HorizontalAlignment.Center;
			NumericUpDown arg_4C5_0 = this.nud_vol;
			int[] array3 = new int[4];
			array3[0] = 70;
			arg_4C5_0.Value = new decimal(array3);
			this.label1.AutoSize = true;
			this.label1.Location = new Point(12, 60);
			this.label1.Name = "label1";
			this.label1.Size = new Size(51, 15);
			this.label1.TabIndex = 18;
			this.label1.Text = "Volume";
			this.b_del.Location = new Point(334, 178);
			this.b_del.Name = "b_del";
			this.b_del.Size = new Size(85, 29);
			this.b_del.TabIndex = 19;
			this.b_del.Text = "Delete";
			this.b_del.UseVisualStyleBackColor = true;
			this.b_del.Click += new EventHandler(this.b_del_Click);
			this.groupBox1.Controls.Add(this.nud_vol);
			this.groupBox1.Controls.Add(this.nud_custom);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cb_basic);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new Point(232, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new Size(187, 119);
			this.groupBox1.TabIndex = 20;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Basic";
			this.nud_custom.Location = new Point(95, 26);
			NumericUpDown arg_6AC_0 = this.nud_custom;
			int[] array4 = new int[4];
			array4[0] = 1000;
			arg_6AC_0.Maximum = new decimal(array4);
			this.nud_custom.Name = "nud_custom";
			this.nud_custom.Size = new Size(85, 21);
			this.nud_custom.TabIndex = 21;
			this.nud_custom.TextAlign = HorizontalAlignment.Center;
			this.toolTip_0.SetToolTip(this.nud_custom, "0: Default\r\n1-1000: Custom");
			this.cb_basic.AutoSize = true;
			this.cb_basic.Location = new Point(15, 92);
			this.cb_basic.Name = "cb_basic";
			this.cb_basic.Size = new Size(128, 19);
			this.cb_basic.TabIndex = 2;
			this.cb_basic.Text = "Use basic sample";
			this.cb_basic.UseVisualStyleBackColor = true;
			this.label3.AutoSize = true;
			this.label3.Location = new Point(12, 28);
			this.label3.Name = "label3";
			this.label3.Size = new Size(69, 15);
			this.label3.TabIndex = 1;
			this.label3.Text = "CustomSet";
			this.b_sample.Location = new Point(232, 262);
			this.b_sample.Name = "b_sample";
			this.b_sample.Size = new Size(86, 30);
			this.b_sample.TabIndex = 21;
			this.b_sample.Text = "Sample";
			this.toolTip_0.SetToolTip(this.b_sample, "Add as a sample event");
			this.b_sample.UseVisualStyleBackColor = true;
			this.b_sample.Click += new EventHandler(this.b_sample_Click);
			this.b_list.Location = new Point(334, 262);
			this.b_list.Name = "b_list";
			this.b_list.Size = new Size(86, 30);
			this.b_list.TabIndex = 22;
			this.b_list.Text = "Sample List";
			this.b_list.UseVisualStyleBackColor = true;
			this.b_list.Click += new EventHandler(this.b_list_Click);
			base.AcceptButton = this.b_apply;
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			base.CancelButton = this.b_cancel;
			base.ClientSize = new Size(431, 351);
			base.Controls.Add(this.b_list);
			base.Controls.Add(this.b_sample);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.b_del);
			base.Controls.Add(this.lb_sample);
			base.Controls.Add(this.b_play);
			base.Controls.Add(this.b_reset);
			base.Controls.Add(this.b_open);
			base.Controls.Add(this.b_cancel);
			base.Controls.Add(this.b_apply);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "SampleImport";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Sample import";
			base.FormClosing += new FormClosingEventHandler(this.SampleImport_FormClosing);
			((ISupportInitialize)this.nud_vol).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((ISupportInitialize)this.nud_custom).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06001B0E RID: 6926
		// RVA: 0x00016AC3 File Offset: 0x00014CC3
		private void lb_sample_DoubleClick(object sender, EventArgs e)
		{
			this.b_play_Click(null, null);
		}

		// Token: 0x06001B12 RID: 6930
		// RVA: 0x00087C20 File Offset: 0x00085E20
		private void lb_sample_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.lb_sample.SelectedItem == null)
			{
				return;
			}
			string a = this.lb_sample.SelectedItem.ToString();
			if (a == "None")
			{
				SampleImport.string_0 = "";
				return;
			}
			SampleImport.string_0 = a;
		}

		// Token: 0x06001B09 RID: 6921
		// RVA: 0x000878C0 File Offset: 0x00085AC0
		private void method_9(string string_1)
		{
			try
			{
				string text = string_1.Substring(string_1.LastIndexOf(Path.DirectorySeparatorChar) + 1);
				string text2 = Class466.Current.method_3() + Path.DirectorySeparatorChar + text;
				if (File.Exists(text2))
				{
					File.Delete(text2);
				}
				File.Copy(string_1, text2);
				int num = Class331.smethod_38(text, false, false, true);
				MessageBox.Show("Loaded!");
				this.lb_sample.Items.Add(text);
				SampleImport.list_0.Add(text);
				if (num == 0)
				{
					Class723.smethod_1("You have added an invaild sample", 2000);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("An error occurred during the import process.  This could mean the wav/mp3/ogg file is unreadable by osu!");
			}
		}

		// Token: 0x06001B05 RID: 6917
		// RVA: 0x0008779C File Offset: 0x0008599C
		protected override void OnShown(EventArgs e)
		{
			this.editor_0 = Editor.editor_0;
			if (SampleImport.list_0 == null)
			{
				SampleImport.list_0 = Class331.smethod_40();
			}
			this.lb_sample.Items.Add("None");
			this.lb_sample.Items.AddRange(SampleImport.list_0.ToArray());
			base.OnShown(e);
		}

		// Token: 0x06001B10 RID: 6928
		// RVA: 0x00016ACD File Offset: 0x00014CCD
		private void SampleImport_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.class339_0 != null)
			{
				this.class339_0.method_11(true);
			}
			SampleImport.string_0 = "";
		}
	}
}
