using Microsoft.Xna.Framework;
using ns64;
using osu.GameModes.Edit;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns10
{
	// Token: 0x0200037F RID: 895
	internal sealed class ScaleBy : Form
	{
		// Token: 0x040015B0 RID: 5552
		private bool bool_0;

		// Token: 0x040015B1 RID: 5553
		private bool bool_1;

		// Token: 0x040015B2 RID: 5554
		private bool bool_2;

		// Token: 0x040015BB RID: 5563
		private Button btnCancel;

		// Token: 0x040015BA RID: 5562
		private Button btnOk;

		// Token: 0x040015C0 RID: 5568
		private CheckBox chkAxisX;

		// Token: 0x040015C1 RID: 5569
		private CheckBox chkAxisY;

		// Token: 0x040015AE RID: 5550
		private Editor editor_0;

		// Token: 0x040015AF RID: 5551
		private float float_0;

		// Token: 0x040015B3 RID: 5555
		private float float_1 = 0.5f;

		// Token: 0x040015B4 RID: 5556
		private float float_2 = 2f;

		// Token: 0x040015B7 RID: 5559
		private GroupBox gbApplyTo;

		// Token: 0x040015B6 RID: 5558
		private GroupBox gbOrigin;

		// Token: 0x040015B5 RID: 5557
		private IContainer icontainer_0;

		// Token: 0x040015BD RID: 5565
		private Label lblMul;

		// Token: 0x040015BF RID: 5567
		private Label lblScale;

		// Token: 0x040015B8 RID: 5560
		private RadioButton radPlayfield;

		// Token: 0x040015B9 RID: 5561
		private RadioButton radSelection;

		// Token: 0x040015BC RID: 5564
		private TrackBar trScale;

		// Token: 0x040015BE RID: 5566
		private TextBox txtScale;

		// Token: 0x06001B1C RID: 6940
		// RVA: 0x00016B45 File Offset: 0x00014D45
		public ScaleBy()
		{
			this.InitializeComponent();
		}

		// Token: 0x06001B25 RID: 6949
		// RVA: 0x00016B8A File Offset: 0x00014D8A
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.editor_0.method_19();
			this.editor_0.method_25();
			if (Class341.class606_25)
			{
				this.editor_0.bool_2 = false;
			}
			base.Close();
		}

		// Token: 0x06001B26 RID: 6950
		// RVA: 0x00016831 File Offset: 0x00014A31
		private void btnOk_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06001B27 RID: 6951
		// RVA: 0x00016BC0 File Offset: 0x00014DC0
		private void chkAxisX_CheckedChanged(object sender, EventArgs e)
		{
			this.method_2();
			this.btnOk.Enabled = (this.chkAxisX.Checked || this.chkAxisY.Checked);
		}

		// Token: 0x06001B28 RID: 6952
		// RVA: 0x00016BC0 File Offset: 0x00014DC0
		private void chkAxisY_CheckedChanged(object sender, EventArgs e)
		{
			this.method_2();
			this.btnOk.Enabled = (this.chkAxisX.Checked || this.chkAxisY.Checked);
		}

		// Token: 0x06001B2A RID: 6954
		// RVA: 0x00016C20 File Offset: 0x00014E20
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001B2B RID: 6955
		// RVA: 0x00088D38 File Offset: 0x00086F38
		private void InitializeComponent()
		{
			this.gbOrigin = new GroupBox();
			this.radPlayfield = new RadioButton();
			this.radSelection = new RadioButton();
			this.btnCancel = new Button();
			this.trScale = new TrackBar();
			this.lblMul = new Label();
			this.txtScale = new TextBox();
			this.lblScale = new Label();
			this.btnOk = new Button();
			this.gbApplyTo = new GroupBox();
			this.chkAxisX = new CheckBox();
			this.chkAxisY = new CheckBox();
			this.gbOrigin.SuspendLayout();
			((ISupportInitialize)this.trScale).BeginInit();
			this.gbApplyTo.SuspendLayout();
			base.SuspendLayout();
			this.gbOrigin.Controls.Add(this.radPlayfield);
			this.gbOrigin.Controls.Add(this.radSelection);
			this.gbOrigin.Location = new Point(12, 73);
			this.gbOrigin.Name = "gbOrigin";
			this.gbOrigin.Size = new Size(144, 73);
			this.gbOrigin.TabIndex = 19;
			this.gbOrigin.TabStop = false;
			this.gbOrigin.Text = "Origin";
			this.radPlayfield.AutoSize = true;
			this.radPlayfield.Checked = true;
			this.radPlayfield.Location = new Point(10, 20);
			this.radPlayfield.Name = "radPlayfield";
			this.radPlayfield.Size = new Size(108, 19);
			this.radPlayfield.TabIndex = 8;
			this.radPlayfield.TabStop = true;
			this.radPlayfield.Text = "Playfield Centre";
			this.radPlayfield.UseVisualStyleBackColor = true;
			this.radSelection.AutoSize = true;
			this.radSelection.Location = new Point(10, 41);
			this.radSelection.Name = "radSelection";
			this.radSelection.Size = new Size(111, 19);
			this.radSelection.TabIndex = 9;
			this.radSelection.Text = "Selection Centre";
			this.radSelection.UseVisualStyleBackColor = true;
			this.radSelection.CheckedChanged += new EventHandler(this.radSelection_CheckedChanged);
			this.btnCancel.DialogResult = DialogResult.Cancel;
			this.btnCancel.Location = new Point(162, 152);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new Size(95, 34);
			this.btnCancel.TabIndex = 15;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
			this.trScale.LargeChange = 100;
			this.trScale.Location = new Point(12, 28);
			this.trScale.Maximum = 2000;
			this.trScale.Minimum = 100;
			this.trScale.Name = "trScale";
			this.trScale.Size = new Size(174, 45);
			this.trScale.SmallChange = 10;
			this.trScale.TabIndex = 20;
			this.trScale.TickFrequency = 100;
			this.trScale.Value = 100;
			this.trScale.Scroll += new EventHandler(this.trScale_Scroll);
			this.lblMul.AutoSize = true;
			this.lblMul.Location = new Point(242, 30);
			this.lblMul.Name = "lblMul";
			this.lblMul.Size = new Size(15, 15);
			this.lblMul.TabIndex = 17;
			this.lblMul.Text = "×";
			this.txtScale.Location = new Point(192, 29);
			this.txtScale.Name = "txtScale";
			this.txtScale.Size = new Size(48, 23);
			this.txtScale.TabIndex = 13;
			this.txtScale.Text = "0";
			this.txtScale.TextChanged += new EventHandler(this.txtScale_TextChanged);
			this.lblScale.AutoSize = true;
			this.lblScale.Location = new Point(14, 9);
			this.lblScale.Name = "lblScale";
			this.lblScale.Size = new Size(207, 15);
			this.lblScale.TabIndex = 16;
			this.lblScale.Text = "Scale the selected objects’ spacing by:";
			this.btnOk.Location = new Point(12, 152);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new Size(144, 34);
			this.btnOk.TabIndex = 14;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new EventHandler(this.btnOk_Click);
			this.gbApplyTo.Controls.Add(this.chkAxisY);
			this.gbApplyTo.Controls.Add(this.chkAxisX);
			this.gbApplyTo.Location = new Point(162, 73);
			this.gbApplyTo.Name = "gbApplyTo";
			this.gbApplyTo.Size = new Size(94, 73);
			this.gbApplyTo.TabIndex = 21;
			this.gbApplyTo.TabStop = false;
			this.gbApplyTo.Text = "Apply to";
			this.chkAxisX.AutoSize = true;
			this.chkAxisX.Checked = true;
			this.chkAxisX.CheckState = CheckState.Checked;
			this.chkAxisX.Location = new Point(9, 20);
			this.chkAxisX.Name = "chkAxisX";
			this.chkAxisX.Size = new Size(57, 19);
			this.chkAxisX.TabIndex = 0;
			this.chkAxisX.Text = "X-axis";
			this.chkAxisX.UseVisualStyleBackColor = true;
			this.chkAxisX.CheckedChanged += new EventHandler(this.chkAxisX_CheckedChanged);
			this.chkAxisY.AutoSize = true;
			this.chkAxisY.Checked = true;
			this.chkAxisY.CheckState = CheckState.Checked;
			this.chkAxisY.Location = new Point(9, 42);
			this.chkAxisY.Name = "chkAxisY";
			this.chkAxisY.Size = new Size(57, 19);
			this.chkAxisY.TabIndex = 1;
			this.chkAxisY.Text = "Y-axis";
			this.chkAxisY.UseVisualStyleBackColor = true;
			this.chkAxisY.CheckedChanged += new EventHandler(this.chkAxisY_CheckedChanged);
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			base.ClientSize = new Size(268, 198);
			base.Controls.Add(this.gbApplyTo);
			base.Controls.Add(this.gbOrigin);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.trScale);
			base.Controls.Add(this.lblMul);
			base.Controls.Add(this.txtScale);
			base.Controls.Add(this.lblScale);
			base.Controls.Add(this.btnOk);
			this.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ScaleBy";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Scale by";
			base.TopMost = true;
			base.FormClosing += new FormClosingEventHandler(this.ScaleBy_FormClosing);
			this.gbOrigin.ResumeLayout(false);
			this.gbOrigin.PerformLayout();
			((ISupportInitialize)this.trScale).EndInit();
			this.gbApplyTo.ResumeLayout(false);
			this.gbApplyTo.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06001B1E RID: 6942
		// RVA: 0x00088AF0 File Offset: 0x00086CF0
		public void method_0(float float_3)
		{
			int num = (int)(float_3 * 1000f);
			if ((float)num >= this.float_2 * 1000f)
			{
				throw new ArgumentOutOfRangeException();
			}
			this.float_1 = (float)num * 0.001f;
			this.trScale.Minimum = num;
		}

		// Token: 0x06001B1F RID: 6943
		// RVA: 0x00088B38 File Offset: 0x00086D38
		public void method_1(float float_3)
		{
			int num = (int)(float_3 * 1000f);
			if ((float)num <= this.float_1 * 1000f)
			{
				throw new ArgumentOutOfRangeException();
			}
			this.float_2 = (float)num * 0.001f;
			this.trScale.Maximum = num;
		}

		// Token: 0x06001B20 RID: 6944
		// RVA: 0x00088B80 File Offset: 0x00086D80
		private void method_2()
		{
			float num = (float)this.trScale.Value * 0.001f;
			this.editor_0.class371_0.method_38(new Vector2(this.bool_1 ? (1f / this.float_0) : 1f, this.bool_2 ? (1f / this.float_0) : 1f), this.bool_0);
			this.float_0 = num;
			this.bool_0 = this.radPlayfield.Checked;
			this.bool_1 = this.chkAxisX.Checked;
			this.bool_2 = this.chkAxisY.Checked;
			this.editor_0.class371_0.method_38(new Vector2(this.bool_1 ? num : 1f, this.bool_2 ? num : 1f), this.radPlayfield.Checked);
		}

		// Token: 0x06001B21 RID: 6945
		// RVA: 0x00088C6C File Offset: 0x00086E6C
		private void method_3(float float_3, bool bool_3)
		{
			float num = Math.Max(Math.Min(float_3, this.float_2), this.float_1);
			int value = (int)(num * 1000f);
			if (!this.trScale.Focused || bool_3)
			{
				this.trScale.Value = value;
			}
			if (!this.txtScale.Focused || bool_3)
			{
				this.txtScale.Text = num.ToString("0.000");
			}
			this.method_2();
		}

		// Token: 0x06001B1D RID: 6941
		// RVA: 0x00088A88 File Offset: 0x00086C88
		protected override void OnShown(EventArgs e)
		{
			this.editor_0 = Editor.editor_0;
			if (Class341.class606_25)
			{
				this.editor_0.bool_2 = true;
			}
			this.editor_0.method_16(false);
			this.float_0 = 1f;
			this.method_3(1f, true);
			this.txtScale.SelectAll();
			base.OnShown(e);
		}

		// Token: 0x06001B22 RID: 6946
		// RVA: 0x00016B69 File Offset: 0x00014D69
		private void radSelection_CheckedChanged(object sender, EventArgs e)
		{
			this.radPlayfield.Checked = !this.radSelection.Checked;
			this.method_2();
		}

		// Token: 0x06001B29 RID: 6953
		// RVA: 0x00016BEE File Offset: 0x00014DEE
		private void ScaleBy_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.editor_0.bool_2 && Class341.class606_25.Value)
			{
				this.editor_0.bool_2 = false;
				this.editor_0.method_24();
			}
		}

		// Token: 0x06001B24 RID: 6948
		// RVA: 0x00088D10 File Offset: 0x00086F10
		private void trScale_Scroll(object sender, EventArgs e)
		{
			float float_ = (float)this.trScale.Value * 0.001f;
			this.method_3(float_, false);
		}

		// Token: 0x06001B23 RID: 6947
		// RVA: 0x00088CE4 File Offset: 0x00086EE4
		private void txtScale_TextChanged(object sender, EventArgs e)
		{
			float float_;
			if (!float.TryParse(this.txtScale.Text, out float_))
			{
				return;
			}
			this.method_3(float_, false);
		}
	}
}
