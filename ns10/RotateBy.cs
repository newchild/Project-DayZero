using ns64;
using ns8;
using osu.GameModes.Edit;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns10
{
	// Token: 0x020004C6 RID: 1222
	internal sealed class RotateBy : Form2
	{
		// Token: 0x04002078 RID: 8312
		private TextBox angle;

		// Token: 0x04002073 RID: 8307
		private bool bool_1;

		// Token: 0x04002075 RID: 8309
		private Button btnCancel;

		// Token: 0x04002076 RID: 8310
		private Button btnOk;

		// Token: 0x04002071 RID: 8305
		private Editor editor_0;

		// Token: 0x0400207C RID: 8316
		private GroupBox gbDirection;

		// Token: 0x0400207D RID: 8317
		private GroupBox gbOrigin;

		// Token: 0x04002074 RID: 8308
		private IContainer icontainer_0;

		// Token: 0x04002072 RID: 8306
		private int int_0;

		// Token: 0x04002079 RID: 8313
		private Label lblDegree;

		// Token: 0x04002077 RID: 8311
		private Label lblRotate;

		// Token: 0x0400207B RID: 8315
		private RadioButton radAnticlockwise;

		// Token: 0x0400207A RID: 8314
		private RadioButton radClockwise;

		// Token: 0x0400207E RID: 8318
		private RadioButton radPlayfield;

		// Token: 0x0400207F RID: 8319
		private RadioButton radSelection;

		// Token: 0x04002080 RID: 8320
		private TrackBar trRotate;

		// Token: 0x06002728 RID: 10024
		// RVA: 0x0001E3E3 File Offset: 0x0001C5E3
		public RotateBy()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600272D RID: 10029
		// RVA: 0x000F0D5C File Offset: 0x000EEF5C
		private void angle_TextChanged(object sender, EventArgs e)
		{
			int num = 0;
			bool flag = int.TryParse(this.angle.Text, out num);
			this.btnOk.Enabled = flag;
			if (flag && num >= -180 && num <= 180)
			{
				this.trRotate.Value = num;
			}
			this.method_9();
		}

		// Token: 0x06002730 RID: 10032
		// RVA: 0x0001E433 File Offset: 0x0001C633
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.editor_0.method_19();
			this.editor_0.method_25();
			if (Class341.class606_25)
			{
				this.editor_0.bool_2 = false;
			}
		}

		// Token: 0x0600272A RID: 10026
		// RVA: 0x00016831 File Offset: 0x00014A31
		private void btnOk_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06002732 RID: 10034
		// RVA: 0x0001E495 File Offset: 0x0001C695
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002733 RID: 10035
		// RVA: 0x000F0DDC File Offset: 0x000EEFDC
		private void InitializeComponent()
		{
			this.btnCancel = new Button();
			this.btnOk = new Button();
			this.lblRotate = new Label();
			this.angle = new TextBox();
			this.lblDegree = new Label();
			this.radClockwise = new RadioButton();
			this.radAnticlockwise = new RadioButton();
			this.gbDirection = new GroupBox();
			this.gbOrigin = new GroupBox();
			this.radPlayfield = new RadioButton();
			this.radSelection = new RadioButton();
			this.trRotate = new TrackBar();
			this.gbDirection.SuspendLayout();
			this.gbOrigin.SuspendLayout();
			((ISupportInitialize)this.trRotate).BeginInit();
			base.SuspendLayout();
			this.btnCancel.DialogResult = DialogResult.Cancel;
			this.btnCancel.Location = new Point(202, 155);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new Size(86, 34);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
			this.btnOk.Location = new Point(12, 155);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new Size(182, 34);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new EventHandler(this.btnOk_Click);
			this.lblRotate.AutoSize = true;
			this.lblRotate.Location = new Point(22, 11);
			this.lblRotate.Name = "lblRotate";
			this.lblRotate.Size = new Size(162, 14);
			this.lblRotate.TabIndex = 5;
			this.lblRotate.Text = "Enter an angle to rotate by:";
			this.angle.Location = new Point(200, 31);
			this.angle.Name = "angle";
			this.angle.Size = new Size(48, 20);
			this.angle.TabIndex = 0;
			this.angle.Text = "0";
			this.angle.TextChanged += new EventHandler(this.angle_TextChanged);
			this.lblDegree.AutoSize = true;
			this.lblDegree.Location = new Point(250, 32);
			this.lblDegree.Name = "lblDegree";
			this.lblDegree.Size = new Size(13, 14);
			this.lblDegree.TabIndex = 7;
			this.lblDegree.Text = "°";
			this.radClockwise.AutoSize = true;
			this.radClockwise.Checked = true;
			this.radClockwise.Location = new Point(15, 20);
			this.radClockwise.Name = "radClockwise";
			this.radClockwise.Size = new Size(77, 18);
			this.radClockwise.TabIndex = 8;
			this.radClockwise.TabStop = true;
			this.radClockwise.Text = "Clockwise";
			this.radClockwise.UseVisualStyleBackColor = true;
			this.radClockwise.CheckedChanged += new EventHandler(this.radClockwise_CheckedChanged);
			this.radAnticlockwise.AutoSize = true;
			this.radAnticlockwise.Location = new Point(15, 41);
			this.radAnticlockwise.Name = "radAnticlockwise";
			this.radAnticlockwise.Size = new Size(103, 18);
			this.radAnticlockwise.TabIndex = 9;
			this.radAnticlockwise.Text = "Anti-Clockwise";
			this.radAnticlockwise.UseVisualStyleBackColor = true;
			this.gbDirection.Controls.Add(this.radClockwise);
			this.gbDirection.Controls.Add(this.radAnticlockwise);
			this.gbDirection.Location = new Point(12, 76);
			this.gbDirection.Name = "gbDirection";
			this.gbDirection.Size = new Size(132, 73);
			this.gbDirection.TabIndex = 10;
			this.gbDirection.TabStop = false;
			this.gbDirection.Text = "Direction";
			this.gbOrigin.Controls.Add(this.radPlayfield);
			this.gbOrigin.Controls.Add(this.radSelection);
			this.gbOrigin.Location = new Point(154, 76);
			this.gbOrigin.Name = "gbOrigin";
			this.gbOrigin.Size = new Size(134, 73);
			this.gbOrigin.TabIndex = 11;
			this.gbOrigin.TabStop = false;
			this.gbOrigin.Text = "Origin";
			this.radPlayfield.AutoSize = true;
			this.radPlayfield.Checked = true;
			this.radPlayfield.Location = new Point(15, 20);
			this.radPlayfield.Name = "radPlayfield";
			this.radPlayfield.Size = new Size(109, 18);
			this.radPlayfield.TabIndex = 8;
			this.radPlayfield.TabStop = true;
			this.radPlayfield.Text = "Playfield Centre";
			this.radPlayfield.UseVisualStyleBackColor = true;
			this.radPlayfield.CheckedChanged += new EventHandler(this.radPlayfield_CheckedChanged);
			this.radSelection.AutoSize = true;
			this.radSelection.Location = new Point(15, 41);
			this.radSelection.Name = "radSelection";
			this.radSelection.Size = new Size(116, 18);
			this.radSelection.TabIndex = 9;
			this.radSelection.Text = "Selection Centre";
			this.radSelection.UseVisualStyleBackColor = true;
			this.trRotate.LargeChange = 45;
			this.trRotate.Location = new Point(20, 30);
			this.trRotate.Maximum = 180;
			this.trRotate.Minimum = -180;
			this.trRotate.Name = "trRotate";
			this.trRotate.Size = new Size(174, 42);
			this.trRotate.TabIndex = 12;
			this.trRotate.TickFrequency = 45;
			this.trRotate.Scroll += new EventHandler(this.trRotate_Scroll);
			base.AcceptButton = this.btnOk;
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			base.CancelButton = this.btnCancel;
			base.ClientSize = new Size(297, 201);
			base.Controls.Add(this.trRotate);
			base.Controls.Add(this.gbOrigin);
			base.Controls.Add(this.gbDirection);
			base.Controls.Add(this.lblDegree);
			base.Controls.Add(this.angle);
			base.Controls.Add(this.lblRotate);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnOk);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "RotateBy";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Rotate by";
			base.FormClosing += new FormClosingEventHandler(this.RotateBy_FormClosing);
			this.gbDirection.ResumeLayout(false);
			this.gbDirection.PerformLayout();
			this.gbOrigin.ResumeLayout(false);
			this.gbOrigin.PerformLayout();
			((ISupportInitialize)this.trRotate).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600272B RID: 10027
		// RVA: 0x000F0CD4 File Offset: 0x000EEED4
		private void method_9()
		{
			int num;
			if (!int.TryParse(this.angle.Text, out num))
			{
				return;
			}
			this.editor_0.class371_0.method_37(-this.int_0, this.bool_1);
			this.int_0 = (this.radAnticlockwise.Checked ? -1 : 1) * num;
			this.bool_1 = this.radPlayfield.Checked;
			this.editor_0.class371_0.method_37(this.int_0, this.bool_1);
		}

		// Token: 0x06002729 RID: 10025
		// RVA: 0x000F0C84 File Offset: 0x000EEE84
		protected override void OnShown(EventArgs e)
		{
			this.editor_0 = Editor.editor_0;
			if (Class341.class606_25)
			{
				this.editor_0.bool_2 = true;
			}
			this.editor_0.method_16(false);
			this.angle.SelectAll();
			base.OnShown(e);
		}

		// Token: 0x0600272C RID: 10028
		// RVA: 0x0001E3F1 File Offset: 0x0001C5F1
		private void radClockwise_CheckedChanged(object sender, EventArgs e)
		{
			this.radAnticlockwise.Checked = !this.radClockwise.Checked;
			this.method_9();
		}

		// Token: 0x0600272E RID: 10030
		// RVA: 0x0001E412 File Offset: 0x0001C612
		private void radPlayfield_CheckedChanged(object sender, EventArgs e)
		{
			this.radSelection.Checked = !this.radPlayfield.Checked;
			this.method_9();
		}

		// Token: 0x06002731 RID: 10033
		// RVA: 0x0001E463 File Offset: 0x0001C663
		private void RotateBy_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.editor_0.bool_2 && Class341.class606_25.Value)
			{
				this.editor_0.bool_2 = false;
				this.editor_0.method_24();
			}
		}

		// Token: 0x0600272F RID: 10031
		// RVA: 0x000F0DB0 File Offset: 0x000EEFB0
		private void trRotate_Scroll(object sender, EventArgs e)
		{
			this.angle.Text = this.trRotate.Value.ToString();
		}
	}
}
