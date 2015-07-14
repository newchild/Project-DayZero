using Microsoft.Xna.Framework;
using ns26;
using ns60;
using ns64;
using ns8;
using osu.GameModes.Edit;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns10
{
	// Token: 0x02000377 RID: 887
	internal sealed class ConvertToStream : Form2
	{
		// Token: 0x0400154C RID: 5452
		private bool bool_1;

		// Token: 0x04001559 RID: 5465
		private Button btnCancel;

		// Token: 0x04001558 RID: 5464
		private Button btnOk;

		// Token: 0x0400154B RID: 5451
		private Class321 class321_0;

		// Token: 0x04001557 RID: 5463
		private DomainUpDown domainBeatSnap;

		// Token: 0x0400154D RID: 5453
		private double double_0;

		// Token: 0x0400154A RID: 5450
		private Editor editor_0;

		// Token: 0x0400154E RID: 5454
		private IContainer icontainer_0;

		// Token: 0x04001555 RID: 5461
		private Label label1;

		// Token: 0x04001556 RID: 5462
		private Label label2;

		// Token: 0x04001553 RID: 5459
		private NumericUpDown numericCount;

		// Token: 0x04001554 RID: 5460
		private NumericUpDown numericDistanceSnap;

		// Token: 0x0400154F RID: 5455
		private RadioButton radCount;

		// Token: 0x04001550 RID: 5456
		private RadioButton radDistanceSnap;

		// Token: 0x04001551 RID: 5457
		private TrackBar trackCount;

		// Token: 0x04001552 RID: 5458
		private TrackBar trackDistanceSnap;

		// Token: 0x06001ACD RID: 6861
		// RVA: 0x00084A04 File Offset: 0x00082C04
		internal ConvertToStream(Class321 class321_1)
		{
			this.editor_0 = Editor.editor_0;
			this.InitializeComponent();
			this.class321_0 = class321_1;
			this.bool_1 = true;
			int int_ = this.editor_0.int_6;
			if (int_ != 3)
			{
				if (int_ != 6)
				{
					this.domainBeatSnap.SelectedIndex = 3;
					goto IL_55;
				}
			}
			this.domainBeatSnap.SelectedIndex = 2;
			IL_55:
			this.bool_1 = false;
		}

		// Token: 0x06001AD8 RID: 6872
		// RVA: 0x00016839 File Offset: 0x00014A39
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.editor_0.method_19();
			this.editor_0.method_25();
			if (Class341.class606_25)
			{
				this.editor_0.bool_2 = false;
			}
		}

		// Token: 0x06001AD7 RID: 6871
		// RVA: 0x00016831 File Offset: 0x00014A31
		private void btnOk_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06001ADC RID: 6876
		// RVA: 0x0001687A File Offset: 0x00014A7A
		private void ConvertToStream_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.editor_0.bool_2 && Class341.class606_25.Value)
			{
				this.editor_0.bool_2 = false;
				this.editor_0.method_24();
			}
		}

		// Token: 0x06001ADD RID: 6877
		// RVA: 0x000168AC File Offset: 0x00014AAC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001ADB RID: 6875
		// RVA: 0x00016869 File Offset: 0x00014A69
		private void domainBeatSnap_SelectedItemChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			this.method_11();
		}

		// Token: 0x06001ADE RID: 6878
		// RVA: 0x00084E0C File Offset: 0x0008300C
		private void InitializeComponent()
		{
			this.btnOk = new Button();
			this.btnCancel = new Button();
			this.domainBeatSnap = new DomainUpDown();
			this.label2 = new Label();
			this.label1 = new Label();
			this.numericDistanceSnap = new NumericUpDown();
			this.radCount = new RadioButton();
			this.numericCount = new NumericUpDown();
			this.radDistanceSnap = new RadioButton();
			this.trackDistanceSnap = new TrackBar();
			this.trackCount = new TrackBar();
			((ISupportInitialize)this.numericDistanceSnap).BeginInit();
			((ISupportInitialize)this.numericCount).BeginInit();
			((ISupportInitialize)this.trackDistanceSnap).BeginInit();
			((ISupportInitialize)this.trackCount).BeginInit();
			base.SuspendLayout();
			this.btnOk.DialogResult = DialogResult.OK;
			this.btnOk.FlatStyle = FlatStyle.System;
			this.btnOk.Location = new Point(12, 138);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new Size(170, 34);
			this.btnOk.TabIndex = 8;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new EventHandler(this.btnOk_Click);
			this.btnCancel.DialogResult = DialogResult.Cancel;
			this.btnCancel.FlatStyle = FlatStyle.System;
			this.btnCancel.Location = new Point(188, 138);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new Size(110, 34);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
			this.domainBeatSnap.Items.Add("1/1");
			this.domainBeatSnap.Items.Add("1/2");
			this.domainBeatSnap.Items.Add("1/3");
			this.domainBeatSnap.Items.Add("1/4");
			this.domainBeatSnap.Items.Add("1/6");
			this.domainBeatSnap.Items.Add("1/8");
			this.domainBeatSnap.Location = new Point(236, 102);
			this.domainBeatSnap.Name = "domainBeatSnap";
			this.domainBeatSnap.Size = new Size(50, 20);
			this.domainBeatSnap.TabIndex = 7;
			this.domainBeatSnap.Text = "fixme";
			this.domainBeatSnap.SelectedItemChanged += new EventHandler(this.domainBeatSnap_SelectedItemChanged);
			this.label2.AutoSize = true;
			this.label2.Location = new Point(130, 104);
			this.label2.Name = "label2";
			this.label2.Size = new Size(99, 15);
			this.label2.TabIndex = 8;
			this.label2.Text = "Beat snap divisor:";
			this.label1.AutoSize = true;
			this.label1.Location = new Point(286, 54);
			this.label1.Name = "label1";
			this.label1.Size = new Size(12, 15);
			this.label1.TabIndex = 7;
			this.label1.Text = "x";
			this.numericDistanceSnap.DecimalPlaces = 2;
			this.numericDistanceSnap.Increment = new decimal(new int[]
			{
				1,
				0,
				0,
				65536
			});
			this.numericDistanceSnap.Location = new Point(236, 57);
			NumericUpDown arg_3ED_0 = this.numericDistanceSnap;
			int[] array = new int[4];
			array[0] = 9;
			arg_3ED_0.Maximum = new decimal(array);
			this.numericDistanceSnap.Minimum = new decimal(new int[]
			{
				1,
				0,
				0,
				65536
			});
			this.numericDistanceSnap.Name = "numericDistanceSnap";
			this.numericDistanceSnap.Size = new Size(50, 20);
			this.numericDistanceSnap.TabIndex = 6;
			this.numericDistanceSnap.Value = new decimal(new int[]
			{
				10,
				0,
				0,
				65536
			});
			this.numericDistanceSnap.ValueChanged += new EventHandler(this.numericDistanceSnap_ValueChanged);
			this.radCount.AutoSize = true;
			this.radCount.FlatStyle = FlatStyle.System;
			this.radCount.Location = new Point(12, 12);
			this.radCount.Name = "radCount";
			this.radCount.Size = new Size(114, 20);
			this.radCount.TabIndex = 0;
			this.radCount.Text = "By object count";
			this.radCount.UseVisualStyleBackColor = true;
			this.radCount.CheckedChanged += new EventHandler(this.radCount_CheckedChanged);
			this.numericCount.Enabled = false;
			this.numericCount.Location = new Point(236, 12);
			NumericUpDown arg_54E_0 = this.numericCount;
			int[] array2 = new int[4];
			array2[0] = 1;
			arg_54E_0.Minimum = new decimal(array2);
			this.numericCount.Name = "numericCount";
			this.numericCount.Size = new Size(50, 20);
			this.numericCount.TabIndex = 4;
			NumericUpDown arg_59D_0 = this.numericCount;
			int[] array3 = new int[4];
			array3[0] = 5;
			arg_59D_0.Value = new decimal(array3);
			this.numericCount.ValueChanged += new EventHandler(this.numericCount_ValueChanged);
			this.radDistanceSnap.AutoSize = true;
			this.radDistanceSnap.Checked = true;
			this.radDistanceSnap.FlatStyle = FlatStyle.System;
			this.radDistanceSnap.Location = new Point(12, 57);
			this.radDistanceSnap.Name = "radDistanceSnap";
			this.radDistanceSnap.Size = new Size(119, 20);
			this.radDistanceSnap.TabIndex = 1;
			this.radDistanceSnap.TabStop = true;
			this.radDistanceSnap.Text = "By distance snap";
			this.radDistanceSnap.UseVisualStyleBackColor = true;
			this.radDistanceSnap.CheckedChanged += new EventHandler(this.radDistanceSnap_CheckedChanged);
			this.trackDistanceSnap.Location = new Point(125, 52);
			this.trackDistanceSnap.Maximum = 500;
			this.trackDistanceSnap.Minimum = 10;
			this.trackDistanceSnap.Name = "trackDistanceSnap";
			this.trackDistanceSnap.Size = new Size(104, 45);
			this.trackDistanceSnap.TabIndex = 5;
			this.trackDistanceSnap.TickFrequency = 50;
			this.trackDistanceSnap.Value = 100;
			this.trackDistanceSnap.Scroll += new EventHandler(this.trackDistanceSnap_Scroll);
			this.trackCount.Enabled = false;
			this.trackCount.LargeChange = 4;
			this.trackCount.Location = new Point(125, 7);
			this.trackCount.Maximum = 17;
			this.trackCount.Minimum = 1;
			this.trackCount.Name = "trackCount";
			this.trackCount.Size = new Size(104, 45);
			this.trackCount.TabIndex = 3;
			this.trackCount.TickFrequency = 4;
			this.trackCount.Value = 5;
			this.trackCount.ValueChanged += new EventHandler(this.trackCount_ValueChanged);
			base.AcceptButton = this.btnOk;
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			base.CancelButton = this.btnCancel;
			base.ClientSize = new Size(310, 184);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnOk);
			base.Controls.Add(this.domainBeatSnap);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.numericDistanceSnap);
			base.Controls.Add(this.radCount);
			base.Controls.Add(this.numericCount);
			base.Controls.Add(this.radDistanceSnap);
			base.Controls.Add(this.trackDistanceSnap);
			base.Controls.Add(this.trackCount);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ConvertToStream";
			this.Text = "Convert slider to stream";
			base.FormClosing += new FormClosingEventHandler(this.ConvertToStream_FormClosing);
			((ISupportInitialize)this.numericDistanceSnap).EndInit();
			((ISupportInitialize)this.numericCount).EndInit();
			((ISupportInitialize)this.trackDistanceSnap).EndInit();
			((ISupportInitialize)this.trackCount).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06001AD2 RID: 6866
		// RVA: 0x0001677C File Offset: 0x0001497C
		private void method_10(NumericUpDown numericUpDown_0, decimal decimal_0)
		{
			if (decimal_0 <= numericUpDown_0.Minimum)
			{
				numericUpDown_0.Value = numericUpDown_0.Minimum;
				return;
			}
			if (decimal_0 >= numericUpDown_0.Maximum)
			{
				numericUpDown_0.Value = numericUpDown_0.Maximum;
				return;
			}
			numericUpDown_0.Value = decimal_0;
		}

		// Token: 0x06001AD9 RID: 6873
		// RVA: 0x00084C48 File Offset: 0x00082E48
		private void method_11()
		{
			int startTime = this.class321_0.StartTime;
			double spatialLength = this.class321_0.SpatialLength;
			double num = (double)this.method_12();
			int num2;
			double num3;
			if (this.radCount.Checked)
			{
				num2 = (int)this.numericCount.Value;
				num3 = spatialLength / (double)Math.Max(1, num2 - 1);
			}
			else
			{
				num3 = this.class321_0.double_2 * Class331.smethod_22((double)startTime, false) * (double)this.numericDistanceSnap.Value / (num * 1000.0);
				num2 = (int)((spatialLength + 1.0) / num3) + 1;
			}
			if (num3 == this.double_0)
			{
				return;
			}
			double num4 = 0.0;
			double num5 = Class331.smethod_22((double)startTime, false) / num;
			double num6 = (double)startTime;
			this.editor_0.bool_3 = true;
			this.editor_0.class371_0.vmethod_35();
			this.editor_0.bool_3 = false;
			for (int i = 0; i < num2; i++)
			{
				Vector2 vector2_ = this.class321_0.method_19((float)num4);
				Class306 class = new Class306(this.editor_0.class297_0, vector2_, (int)num6, i == 0 && this.class321_0.NewCombo, false, false, false, 0);
				this.editor_0.class297_0.Add(class, true);
				this.editor_0.class371_0.Select(class);
				num6 += num5;
				num4 += num3;
			}
			this.editor_0.class297_0.method_20(true);
		}

		// Token: 0x06001ADA RID: 6874
		// RVA: 0x00084DC8 File Offset: 0x00082FC8
		private int method_12()
		{
			switch (this.domainBeatSnap.SelectedIndex)
			{
			case 0:
				return 1;
			case 1:
				return 2;
			case 2:
				return 3;
			case 3:
				return 4;
			case 4:
				return 6;
			case 5:
				return 8;
			default:
				return 1;
			}
		}

		// Token: 0x06001AD1 RID: 6865
		// RVA: 0x00016747 File Offset: 0x00014947
		private void method_9(TrackBar trackBar_0, int int_0)
		{
			if (int_0 <= trackBar_0.Minimum)
			{
				trackBar_0.Value = trackBar_0.Minimum;
				return;
			}
			if (int_0 >= trackBar_0.Maximum)
			{
				trackBar_0.Value = trackBar_0.Maximum;
				return;
			}
			trackBar_0.Value = int_0;
		}

		// Token: 0x06001AD5 RID: 6869
		// RVA: 0x000167F6 File Offset: 0x000149F6
		private void numericCount_ValueChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			this.bool_1 = true;
			this.method_9(this.trackCount, (int)this.numericCount.Value);
			this.bool_1 = false;
			this.method_11();
		}

		// Token: 0x06001AD6 RID: 6870
		// RVA: 0x00084BEC File Offset: 0x00082DEC
		private void numericDistanceSnap_ValueChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			this.bool_1 = true;
			this.method_9(this.trackDistanceSnap, (int)(this.numericDistanceSnap.Value * 100.0m));
			this.bool_1 = false;
			this.method_11();
		}

		// Token: 0x06001ACE RID: 6862
		// RVA: 0x00084A70 File Offset: 0x00082C70
		protected override void OnShown(EventArgs e)
		{
			this.editor_0 = Editor.editor_0;
			if (Class341.class606_25)
			{
				this.editor_0.bool_2 = true;
			}
			this.editor_0.method_16(false);
			this.editor_0.method_65();
			this.editor_0.class297_0.Remove(this.class321_0, false);
			this.method_11();
			base.OnShown(e);
		}

		// Token: 0x06001ACF RID: 6863
		// RVA: 0x00084ADC File Offset: 0x00082CDC
		private void radCount_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radCount.Checked)
			{
				this.radDistanceSnap.Checked = false;
				this.trackCount.Enabled = true;
				this.numericCount.Enabled = true;
				this.trackDistanceSnap.Enabled = false;
				this.numericDistanceSnap.Enabled = false;
				this.method_11();
			}
		}

		// Token: 0x06001AD0 RID: 6864
		// RVA: 0x00084B38 File Offset: 0x00082D38
		private void radDistanceSnap_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radDistanceSnap.Checked)
			{
				this.radCount.Checked = false;
				this.trackCount.Enabled = false;
				this.numericCount.Enabled = false;
				this.trackDistanceSnap.Enabled = true;
				this.numericDistanceSnap.Enabled = true;
				this.method_11();
			}
		}

		// Token: 0x06001AD3 RID: 6867
		// RVA: 0x000167BB File Offset: 0x000149BB
		private void trackCount_ValueChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			this.bool_1 = true;
			this.method_10(this.numericCount, this.trackCount.Value);
			this.bool_1 = false;
			this.method_11();
		}

		// Token: 0x06001AD4 RID: 6868
		// RVA: 0x00084B94 File Offset: 0x00082D94
		private void trackDistanceSnap_Scroll(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			this.bool_1 = true;
			this.method_10(this.numericDistanceSnap, this.trackDistanceSnap.Value * 0.01m);
			this.bool_1 = false;
			this.method_11();
		}
	}
}
