using ns64;
using ns68;
using ns8;
using osu.GameModes.Edit;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns10
{
	// Token: 0x02000380 RID: 896
	internal sealed class Polygon : Form2
	{
		// Token: 0x040015C4 RID: 5572
		private Button btnCancel;

		// Token: 0x040015C6 RID: 5574
		private Button btnOk;

		// Token: 0x040015C2 RID: 5570
		private Editor editor_0;

		// Token: 0x040015C3 RID: 5571
		private IContainer icontainer_0;

		// Token: 0x040015D0 RID: 5584
		private Label label1;

		// Token: 0x040015CB RID: 5579
		private Label lblAngleVal;

		// Token: 0x040015C7 RID: 5575
		private Label lblDS;

		// Token: 0x040015CA RID: 5578
		private Label lblDSVal;

		// Token: 0x040015CD RID: 5581
		private Label lblEdge;

		// Token: 0x040015C8 RID: 5576
		private Label lblOffset;

		// Token: 0x040015CC RID: 5580
		private Label lblRepeat;

		// Token: 0x040015CF RID: 5583
		private NumericUpDown nudCount;

		// Token: 0x040015CE RID: 5582
		private NumericUpDown nudRepeat;

		// Token: 0x040015C9 RID: 5577
		private TrackBar trAngle;

		// Token: 0x040015C5 RID: 5573
		private TrackBar trDS;

		// Token: 0x06001B2C RID: 6956
		// RVA: 0x00016C3F File Offset: 0x00014E3F
		public Polygon()
		{
			this.InitializeComponent();
		}

		// Token: 0x06001B30 RID: 6960
		// RVA: 0x00016C4D File Offset: 0x00014E4D
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

		// Token: 0x06001B2F RID: 6959
		// RVA: 0x00016831 File Offset: 0x00014A31
		private void btnOk_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06001B36 RID: 6966
		// RVA: 0x00016CEA File Offset: 0x00014EEA
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001B37 RID: 6967
		// RVA: 0x000897C0 File Offset: 0x000879C0
		private void InitializeComponent()
		{
			this.btnCancel = new Button();
			this.trDS = new TrackBar();
			this.btnOk = new Button();
			this.lblDS = new Label();
			this.lblOffset = new Label();
			this.trAngle = new TrackBar();
			this.lblDSVal = new Label();
			this.lblAngleVal = new Label();
			this.lblRepeat = new Label();
			this.lblEdge = new Label();
			this.nudRepeat = new NumericUpDown();
			this.nudCount = new NumericUpDown();
			this.label1 = new Label();
			((ISupportInitialize)this.trDS).BeginInit();
			((ISupportInitialize)this.trAngle).BeginInit();
			((ISupportInitialize)this.nudRepeat).BeginInit();
			((ISupportInitialize)this.nudCount).BeginInit();
			base.SuspendLayout();
			this.btnCancel.DialogResult = DialogResult.Cancel;
			this.btnCancel.Location = new Point(242, 163);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new Size(95, 34);
			this.btnCancel.TabIndex = 15;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
			this.trDS.Location = new Point(138, 40);
			this.trDS.Maximum = 20;
			this.trDS.Minimum = 1;
			this.trDS.Name = "trDS";
			this.trDS.Size = new Size(205, 45);
			this.trDS.TabIndex = 1;
			this.trDS.Value = 1;
			this.trDS.Scroll += new EventHandler(this.trDS_Scroll);
			this.btnOk.Location = new Point(10, 163);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new Size(226, 34);
			this.btnOk.TabIndex = 14;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new EventHandler(this.btnOk_Click);
			this.lblDS.AutoSize = true;
			this.lblDS.Location = new Point(12, 45);
			this.lblDS.Name = "lblDS";
			this.lblDS.Size = new Size(89, 17);
			this.lblDS.TabIndex = 22;
			this.lblDS.Text = "Distance snap";
			this.lblOffset.AutoSize = true;
			this.lblOffset.Location = new Point(12, 81);
			this.lblOffset.Name = "lblOffset";
			this.lblOffset.Size = new Size(79, 17);
			this.lblOffset.TabIndex = 23;
			this.lblOffset.Text = "Offset angle";
			this.trAngle.Location = new Point(138, 77);
			this.trAngle.Maximum = 180;
			this.trAngle.Name = "trAngle";
			this.trAngle.Size = new Size(205, 45);
			this.trAngle.TabIndex = 24;
			this.trAngle.TickFrequency = 45;
			this.trAngle.Scroll += new EventHandler(this.trAngle_Scroll);
			this.lblDSVal.AutoSize = true;
			this.lblDSVal.Location = new Point(110, 46);
			this.lblDSVal.Name = "lblDSVal";
			this.lblDSVal.Size = new Size(15, 17);
			this.lblDSVal.TabIndex = 25;
			this.lblDSVal.Text = "0";
			this.lblAngleVal.AutoSize = true;
			this.lblAngleVal.Location = new Point(110, 81);
			this.lblAngleVal.Name = "lblAngleVal";
			this.lblAngleVal.Size = new Size(20, 17);
			this.lblAngleVal.TabIndex = 26;
			this.lblAngleVal.Text = "0°";
			this.lblRepeat.AutoSize = true;
			this.lblRepeat.Location = new Point(27, 127);
			this.lblRepeat.Name = "lblRepeat";
			this.lblRepeat.Size = new Size(49, 17);
			this.lblRepeat.TabIndex = 27;
			this.lblRepeat.Text = "Repeat";
			this.lblEdge.AutoSize = true;
			this.lblEdge.Location = new Point(186, 127);
			this.lblEdge.Name = "lblEdge";
			this.lblEdge.Size = new Size(43, 17);
			this.lblEdge.TabIndex = 28;
			this.lblEdge.Text = "Points";
			this.nudRepeat.Location = new Point(76, 124);
			NumericUpDown arg_543_0 = this.nudRepeat;
			int[] array = new int[4];
			array[0] = 10;
			arg_543_0.Maximum = new decimal(array);
			NumericUpDown arg_55F_0 = this.nudRepeat;
			int[] array2 = new int[4];
			array2[0] = 1;
			arg_55F_0.Minimum = new decimal(array2);
			this.nudRepeat.Name = "nudRepeat";
			this.nudRepeat.Size = new Size(62, 21);
			this.nudRepeat.TabIndex = 29;
			this.nudRepeat.TextAlign = HorizontalAlignment.Center;
			NumericUpDown arg_5B8_0 = this.nudRepeat;
			int[] array3 = new int[4];
			array3[0] = 1;
			arg_5B8_0.Value = new decimal(array3);
			this.nudRepeat.ValueChanged += new EventHandler(this.nudRepeat_ValueChanged);
			this.nudCount.Location = new Point(253, 125);
			NumericUpDown arg_602_0 = this.nudCount;
			int[] array4 = new int[4];
			array4[0] = 3;
			arg_602_0.Minimum = new decimal(array4);
			this.nudCount.Name = "nudCount";
			this.nudCount.Size = new Size(77, 21);
			this.nudCount.TabIndex = 30;
			this.nudCount.TextAlign = HorizontalAlignment.Center;
			NumericUpDown arg_65E_0 = this.nudCount;
			int[] array5 = new int[4];
			array5[0] = 3;
			arg_65E_0.Value = new decimal(array5);
			this.nudCount.ValueChanged += new EventHandler(this.nudCount_ValueChanged);
			this.label1.AutoSize = true;
			this.label1.Location = new Point(15, 13);
			this.label1.Name = "label1";
			this.label1.Size = new Size(300, 17);
			this.label1.TabIndex = 31;
			this.label1.Text = "Try smaller distance snap if you need more points";
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			base.ClientSize = new Size(349, 213);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.nudCount);
			base.Controls.Add(this.nudRepeat);
			base.Controls.Add(this.lblEdge);
			base.Controls.Add(this.lblRepeat);
			base.Controls.Add(this.lblAngleVal);
			base.Controls.Add(this.lblDSVal);
			base.Controls.Add(this.lblOffset);
			base.Controls.Add(this.lblDS);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnOk);
			base.Controls.Add(this.trAngle);
			base.Controls.Add(this.trDS);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Polygon";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Polygonal Circle Creation";
			base.TopMost = true;
			base.FormClosing += new FormClosingEventHandler(this.Polygon_FormClosing);
			((ISupportInitialize)this.trDS).EndInit();
			((ISupportInitialize)this.trAngle).EndInit();
			((ISupportInitialize)this.nudRepeat).EndInit();
			((ISupportInitialize)this.nudCount).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06001B2E RID: 6958
		// RVA: 0x000896CC File Offset: 0x000878CC
		private void method_9()
		{
			this.editor_0.class371_0.method_40((int)this.nudCount.Value, (int)this.nudRepeat.Value, (double)this.trAngle.Value * 3.14159 / 180.0, (double)this.trDS.Value / 10.0);
		}

		// Token: 0x06001B34 RID: 6964
		// RVA: 0x00016CB0 File Offset: 0x00014EB0
		private void nudCount_ValueChanged(object sender, EventArgs e)
		{
			this.method_9();
		}

		// Token: 0x06001B33 RID: 6963
		// RVA: 0x00016CB0 File Offset: 0x00014EB0
		private void nudRepeat_ValueChanged(object sender, EventArgs e)
		{
			this.method_9();
		}

		// Token: 0x06001B2D RID: 6957
		// RVA: 0x000895B4 File Offset: 0x000877B4
		protected override void OnShown(EventArgs e)
		{
			this.editor_0 = Editor.editor_0;
			if (Class341.class606_25)
			{
				this.editor_0.bool_2 = true;
			}
			this.editor_0.method_16(false);
			this.editor_0.bool_3 = true;
			this.nudCount.Select();
			this.trDS.Value = (int)(Class341.class607_2 * 10.0);
			if (this.trDS.Value < 1)
			{
				this.trDS.Value = 1;
			}
			this.nudCount.Maximum = this.editor_0.class371_0.method_39((double)this.trDS.Value / 10.0);
			this.lblDSVal.Text = string.Format("{0:0.0#}×", Class341.class607_2);
			this.editor_0.class371_0.vmethod_17();
			this.editor_0.class371_0.method_48(Class371.Enum42.const_0);
			this.editor_0.bool_3 = false;
			base.OnShown(e);
			this.method_9();
		}

		// Token: 0x06001B35 RID: 6965
		// RVA: 0x00016CB8 File Offset: 0x00014EB8
		private void Polygon_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.editor_0.bool_2 && Class341.class606_25.Value)
			{
				this.editor_0.bool_2 = false;
				this.editor_0.method_24();
			}
		}

		// Token: 0x06001B32 RID: 6962
		// RVA: 0x00016C83 File Offset: 0x00014E83
		private void trAngle_Scroll(object sender, EventArgs e)
		{
			this.lblAngleVal.Text = string.Format("{0}°", this.trAngle.Value);
			this.method_9();
		}

		// Token: 0x06001B31 RID: 6961
		// RVA: 0x00089744 File Offset: 0x00087944
		private void trDS_Scroll(object sender, EventArgs e)
		{
			this.lblDSVal.Text = string.Format("{0:0.0#}×", (double)this.trDS.Value / 10.0);
			this.nudCount.Maximum = this.editor_0.class371_0.method_39((double)this.trDS.Value / 10.0);
			this.method_9();
		}
	}
}
