using Microsoft.Xna.Framework;
using ns59;
using ns64;
using ns8;
using osu.GameModes.Edit;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns10
{
	// Token: 0x02000378 RID: 888
	internal sealed class CoordinateForm : Form2
	{
		// Token: 0x04001564 RID: 5476
		private Button bt_cancel;

		// Token: 0x04001563 RID: 5475
		private Button bt_ok;

		// Token: 0x04001562 RID: 5474
		private CheckBox cb_relative;

		// Token: 0x0400155A RID: 5466
		private Editor editor_0;

		// Token: 0x0400155C RID: 5468
		private IContainer icontainer_0;

		// Token: 0x0400155D RID: 5469
		private Label label1;

		// Token: 0x0400155E RID: 5470
		private Label label2;

		// Token: 0x04001561 RID: 5473
		private Label label3;

		// Token: 0x0400155F RID: 5471
		private NumericUpDown nud_x;

		// Token: 0x04001560 RID: 5472
		private NumericUpDown nud_y;

		// Token: 0x0400155B RID: 5467
		private Vector2 vector2_0;

		// Token: 0x06001ADF RID: 6879
		// RVA: 0x000168CB File Offset: 0x00014ACB
		public CoordinateForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x06001AE2 RID: 6882
		// RVA: 0x000168D9 File Offset: 0x00014AD9
		private void bt_cancel_Click(object sender, EventArgs e)
		{
			this.editor_0.method_19();
			this.editor_0.method_25();
			if (Class341.class606_25)
			{
				this.editor_0.bool_2 = false;
			}
			base.Close();
		}

		// Token: 0x06001AE1 RID: 6881
		// RVA: 0x00016831 File Offset: 0x00014A31
		private void bt_ok_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06001AE6 RID: 6886
		// RVA: 0x00085898 File Offset: 0x00083A98
		private void cb_relative_CheckedChanged(object sender, EventArgs e)
		{
			if (this.cb_relative.Checked)
			{
				this.nud_x.Minimum = -512m;
				this.nud_y.Minimum = -384m;
				return;
			}
			this.nud_x.Minimum = 0m;
			this.nud_y.Minimum = 0m;
		}

		// Token: 0x06001AE9 RID: 6889
		// RVA: 0x00016917 File Offset: 0x00014B17
		private void CoordinateForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.editor_0.bool_2 && Class341.class606_25.Value)
			{
				this.editor_0.bool_2 = false;
				this.editor_0.method_24();
			}
		}

		// Token: 0x06001AEA RID: 6890
		// RVA: 0x00016949 File Offset: 0x00014B49
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001AEB RID: 6891
		// RVA: 0x00085900 File Offset: 0x00083B00
		private void InitializeComponent()
		{
			this.label1 = new Label();
			this.label2 = new Label();
			this.nud_x = new NumericUpDown();
			this.nud_y = new NumericUpDown();
			this.label3 = new Label();
			this.cb_relative = new CheckBox();
			this.bt_ok = new Button();
			this.bt_cancel = new Button();
			((ISupportInitialize)this.nud_x).BeginInit();
			((ISupportInitialize)this.nud_y).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new Size(109, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Move note(s) to...";
			this.label2.AutoSize = true;
			this.label2.Location = new Point(12, 35);
			this.label2.Name = "label2";
			this.label2.Size = new Size(18, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "X:";
			this.nud_x.BorderStyle = BorderStyle.FixedSingle;
			this.nud_x.Location = new Point(33, 33);
			NumericUpDown arg_16F_0 = this.nud_x;
			int[] array = new int[4];
			array[0] = 512;
			arg_16F_0.Maximum = new decimal(array);
			this.nud_x.Name = "nud_x";
			this.nud_x.Size = new Size(98, 21);
			this.nud_x.TabIndex = 2;
			this.nud_x.TextAlign = HorizontalAlignment.Center;
			this.nud_x.ValueChanged += new EventHandler(this.nud_x_ValueChanged);
			this.nud_x.KeyUp += new KeyEventHandler(this.nud_x_KeyUp);
			this.nud_y.BorderStyle = BorderStyle.FixedSingle;
			this.nud_y.Location = new Point(171, 33);
			NumericUpDown arg_21C_0 = this.nud_y;
			int[] array2 = new int[4];
			array2[0] = 384;
			arg_21C_0.Maximum = new decimal(array2);
			this.nud_y.Name = "nud_y";
			this.nud_y.Size = new Size(98, 21);
			this.nud_y.TabIndex = 4;
			this.nud_y.TextAlign = HorizontalAlignment.Center;
			this.nud_y.ValueChanged += new EventHandler(this.nud_y_ValueChanged);
			this.nud_y.KeyUp += new KeyEventHandler(this.nud_y_KeyUp);
			this.label3.AutoSize = true;
			this.label3.Location = new Point(150, 35);
			this.label3.Name = "label3";
			this.label3.Size = new Size(17, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "Y:";
			this.cb_relative.AutoSize = true;
			this.cb_relative.Location = new Point(15, 63);
			this.cb_relative.Name = "cb_relative";
			this.cb_relative.Size = new Size(136, 19);
			this.cb_relative.TabIndex = 5;
			this.cb_relative.Text = "Relative movement";
			this.cb_relative.UseVisualStyleBackColor = true;
			this.cb_relative.CheckedChanged += new EventHandler(this.cb_relative_CheckedChanged);
			this.bt_ok.Location = new Point(13, 90);
			this.bt_ok.Name = "bt_ok";
			this.bt_ok.Size = new Size(152, 32);
			this.bt_ok.TabIndex = 6;
			this.bt_ok.Text = "OK";
			this.bt_ok.UseVisualStyleBackColor = true;
			this.bt_ok.Click += new EventHandler(this.bt_ok_Click);
			this.bt_cancel.DialogResult = DialogResult.Cancel;
			this.bt_cancel.Location = new Point(171, 90);
			this.bt_cancel.Name = "bt_cancel";
			this.bt_cancel.Size = new Size(98, 32);
			this.bt_cancel.TabIndex = 7;
			this.bt_cancel.Text = "Cancel";
			this.bt_cancel.UseVisualStyleBackColor = true;
			this.bt_cancel.Click += new EventHandler(this.bt_cancel_Click);
			base.AcceptButton = this.bt_ok;
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			base.CancelButton = this.bt_cancel;
			base.ClientSize = new Size(282, 128);
			base.Controls.Add(this.bt_cancel);
			base.Controls.Add(this.bt_ok);
			base.Controls.Add(this.cb_relative);
			base.Controls.Add(this.nud_y);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.nud_x);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "CoordinateForm";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Coordinate ";
			base.TopMost = true;
			base.FormClosing += new FormClosingEventHandler(this.CoordinateForm_FormClosing);
			((ISupportInitialize)this.nud_x).EndInit();
			((ISupportInitialize)this.nud_y).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06001AE3 RID: 6883
		// RVA: 0x000857FC File Offset: 0x000839FC
		private void method_9()
		{
			int num = (int)this.nud_x.Value;
			int num2 = (int)this.nud_y.Value;
			bool checked;
			if (checked = this.cb_relative.Checked)
			{
				this.editor_0.class371_0.method_41(num - (int)this.vector2_0.X, num2 - (int)this.vector2_0.Y, checked);
			}
			else
			{
				this.editor_0.class371_0.method_41(num, num2, checked);
			}
			this.vector2_0.X = (float)num;
			this.vector2_0.Y = (float)num2;
		}

		// Token: 0x06001AE7 RID: 6887
		// RVA: 0x0001690F File Offset: 0x00014B0F
		private void nud_x_KeyUp(object sender, KeyEventArgs e)
		{
			this.method_9();
		}

		// Token: 0x06001AE4 RID: 6884
		// RVA: 0x0001690F File Offset: 0x00014B0F
		private void nud_x_ValueChanged(object sender, EventArgs e)
		{
			this.method_9();
		}

		// Token: 0x06001AE8 RID: 6888
		// RVA: 0x0001690F File Offset: 0x00014B0F
		private void nud_y_KeyUp(object sender, KeyEventArgs e)
		{
			this.method_9();
		}

		// Token: 0x06001AE5 RID: 6885
		// RVA: 0x0001690F File Offset: 0x00014B0F
		private void nud_y_ValueChanged(object sender, EventArgs e)
		{
			this.method_9();
		}

		// Token: 0x06001AE0 RID: 6880
		// RVA: 0x00085728 File Offset: 0x00083928
		protected override void OnShown(EventArgs e)
		{
			this.editor_0 = Editor.editor_0;
			if (Class341.class606_25)
			{
				this.editor_0.bool_2 = true;
			}
			this.editor_0.method_16(false);
			if (this.editor_0.class371_0.list_1.Count == 1)
			{
				Class304 class = this.editor_0.class371_0.list_1[0];
				float x = class.vector2_0.X;
				float y = class.vector2_0.Y;
				this.nud_y.Value = (decimal)y;
				this.nud_x.Value = (decimal)x;
				this.cb_relative.Checked = false;
			}
			else
			{
				this.cb_relative.Checked = true;
				this.vector2_0 = default(Vector2);
			}
			base.OnShown(e);
		}
	}
}
