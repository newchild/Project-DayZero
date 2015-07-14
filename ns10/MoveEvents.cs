using ns29;
using ns8;
using osu.GameModes.Edit;
using osu_common.Helpers;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns10
{
	// Token: 0x0200037C RID: 892
	internal sealed class MoveEvents : Form2
	{
		// Token: 0x0400158F RID: 5519
		private TextBox amount;

		// Token: 0x04001591 RID: 5521
		private Button button1;

		// Token: 0x04001592 RID: 5522
		private Button button2;

		// Token: 0x0400158C RID: 5516
		private Editor editor_0;

		// Token: 0x0400158D RID: 5517
		private IContainer icontainer_0;

		// Token: 0x0400158E RID: 5518
		private Label label1;

		// Token: 0x04001593 RID: 5523
		private Label label2;

		// Token: 0x04001590 RID: 5520
		private TrackBar trackBar1;

		// Token: 0x06001AFB RID: 6907
		// RVA: 0x00016A18 File Offset: 0x00014C18
		public MoveEvents()
		{
			this.InitializeComponent();
		}

		// Token: 0x06001AFF RID: 6911
		// RVA: 0x000872C8 File Offset: 0x000854C8
		private void amount_TextChanged(object sender, EventArgs e)
		{
			int val = 0;
			bool flag = int.TryParse(this.amount.Text, out val);
			this.button1.Enabled = flag;
			if (flag)
			{
				this.trackBar1.Value = Math.Max(-60000, Math.Min(60000, val));
			}
		}

		// Token: 0x06001AFD RID: 6909
		// RVA: 0x00016A51 File Offset: 0x00014C51
		private void button1_Click(object sender, EventArgs e)
		{
			this.method_9();
			base.Close();
		}

		// Token: 0x06001B01 RID: 6913
		// RVA: 0x00016A5F File Offset: 0x00014C5F
		private void button2_Click(object sender, EventArgs e)
		{
			Class115.class47_0.Add(new VoidDelegate(this.editor_0.method_19), false);
		}

		// Token: 0x06001B02 RID: 6914
		// RVA: 0x00016A7D File Offset: 0x00014C7D
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001B03 RID: 6915
		// RVA: 0x00087348 File Offset: 0x00085548
		private void InitializeComponent()
		{
			this.label1 = new Label();
			this.amount = new TextBox();
			this.trackBar1 = new TrackBar();
			this.button1 = new Button();
			this.button2 = new Button();
			this.label2 = new Label();
			((ISupportInitialize)this.trackBar1).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new Size(241, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "Enter the number of milliseconds to shift by:";
			this.amount.Location = new Point(187, 29);
			this.amount.Name = "amount";
			this.amount.Size = new Size(83, 20);
			this.amount.TabIndex = 0;
			this.amount.Text = "0";
			this.amount.TextChanged += new EventHandler(this.amount_TextChanged);
			this.trackBar1.LargeChange = 45;
			this.trackBar1.Location = new Point(7, 28);
			this.trackBar1.Maximum = 60000;
			this.trackBar1.Minimum = -60000;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new Size(174, 45);
			this.trackBar1.TabIndex = 12;
			this.trackBar1.TickFrequency = 5000;
			this.trackBar1.Scroll += new EventHandler(this.trackBar1_Scroll);
			this.button1.FlatStyle = FlatStyle.System;
			this.button1.Location = new Point(12, 81);
			this.button1.Name = "button1";
			this.button1.Size = new Size(169, 34);
			this.button1.TabIndex = 1;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.button2.DialogResult = DialogResult.Cancel;
			this.button2.FlatStyle = FlatStyle.System;
			this.button2.Location = new Point(187, 81);
			this.button2.Name = "button2";
			this.button2.Size = new Size(110, 34);
			this.button2.TabIndex = 2;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new EventHandler(this.button2_Click);
			this.label2.AutoSize = true;
			this.label2.Location = new Point(274, 33);
			this.label2.Name = "label2";
			this.label2.Size = new Size(23, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "ms";
			base.AcceptButton = this.button1;
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			base.CancelButton = this.button2;
			base.ClientSize = new Size(309, 127);
			base.Controls.Add(this.trackBar1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.amount);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "MoveEvents";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Move all events...";
			((ISupportInitialize)this.trackBar1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06001AFE RID: 6910
		// RVA: 0x00087294 File Offset: 0x00085494
		private void method_9()
		{
			int int_;
			if (!int.TryParse(this.amount.Text, out int_))
			{
				return;
			}
			this.editor_0.class376_0.method_32(int_);
		}

		// Token: 0x06001AFC RID: 6908
		// RVA: 0x00016A26 File Offset: 0x00014C26
		protected override void OnShown(EventArgs e)
		{
			this.editor_0 = Editor.editor_0;
			this.editor_0.method_16(false);
			this.amount.SelectAll();
			base.OnShown(e);
		}

		// Token: 0x06001B00 RID: 6912
		// RVA: 0x0008731C File Offset: 0x0008551C
		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			this.amount.Text = this.trackBar1.Value.ToString();
		}
	}
}
