using ns8;
using osu.GameModes.Edit;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns10
{
	// Token: 0x02000381 RID: 897
	internal sealed class MoveNotes : Form2
	{
		// Token: 0x040015D4 RID: 5588
		private TextBox amount;

		// Token: 0x040015D7 RID: 5591
		private Button btnCancel;

		// Token: 0x040015D6 RID: 5590
		private Button btnOk;

		// Token: 0x040015D1 RID: 5585
		private Editor editor_0;

		// Token: 0x040015D2 RID: 5586
		private IContainer icontainer_0;

		// Token: 0x040015D3 RID: 5587
		private Label label1;

		// Token: 0x040015D8 RID: 5592
		private Label label2;

		// Token: 0x040015D5 RID: 5589
		private TrackBar trOffset;

		// Token: 0x06001B38 RID: 6968
		// RVA: 0x00016D09 File Offset: 0x00014F09
		public MoveNotes()
		{
			this.InitializeComponent();
		}

		// Token: 0x06001B3B RID: 6971
		// RVA: 0x0008A088 File Offset: 0x00088288
		private void amount_TextChanged(object sender, EventArgs e)
		{
			int val = 0;
			bool flag = int.TryParse(this.amount.Text, out val);
			this.btnOk.Enabled = flag;
			if (flag)
			{
				this.trOffset.Value = Math.Max(-60000, Math.Min(60000, val));
			}
		}

		// Token: 0x06001B3E RID: 6974
		// RVA: 0x0000653E File Offset: 0x0000473E
		private void btnCancel_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001B3D RID: 6973
		// RVA: 0x00016D36 File Offset: 0x00014F36
		private void btnOk_Click(object sender, EventArgs e)
		{
			this.method_9();
			base.Close();
		}

		// Token: 0x06001B3F RID: 6975
		// RVA: 0x00016D44 File Offset: 0x00014F44
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001B40 RID: 6976
		// RVA: 0x0008A108 File Offset: 0x00088308
		private void InitializeComponent()
		{
			this.label1 = new Label();
			this.amount = new TextBox();
			this.trOffset = new TrackBar();
			this.btnOk = new Button();
			this.btnCancel = new Button();
			this.label2 = new Label();
			((ISupportInitialize)this.trOffset).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new Size(265, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "Enter the number of milliseconds to shift by:";
			this.amount.Location = new Point(187, 29);
			this.amount.Name = "amount";
			this.amount.Size = new Size(83, 21);
			this.amount.TabIndex = 0;
			this.amount.Text = "0";
			this.amount.TextChanged += new EventHandler(this.amount_TextChanged);
			this.trOffset.LargeChange = 45;
			this.trOffset.Location = new Point(7, 28);
			this.trOffset.Maximum = 60000;
			this.trOffset.Minimum = -60000;
			this.trOffset.Name = "trOffset";
			this.trOffset.Size = new Size(174, 45);
			this.trOffset.TabIndex = 12;
			this.trOffset.TickFrequency = 5000;
			this.trOffset.Scroll += new EventHandler(this.trOffset_Scroll);
			this.btnOk.FlatStyle = FlatStyle.System;
			this.btnOk.Location = new Point(12, 81);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new Size(169, 34);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new EventHandler(this.btnOk_Click);
			this.btnCancel.DialogResult = DialogResult.Cancel;
			this.btnCancel.FlatStyle = FlatStyle.System;
			this.btnCancel.Location = new Point(187, 81);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new Size(110, 34);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
			this.label2.AutoSize = true;
			this.label2.Location = new Point(274, 33);
			this.label2.Name = "label2";
			this.label2.Size = new Size(25, 17);
			this.label2.TabIndex = 7;
			this.label2.Text = "ms";
			base.AcceptButton = this.btnOk;
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			base.CancelButton = this.btnCancel;
			base.ClientSize = new Size(309, 127);
			base.Controls.Add(this.trOffset);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.amount);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnOk);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "MoveNotes";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Move all notes...";
			((ISupportInitialize)this.trOffset).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06001B3A RID: 6970
		// RVA: 0x0008A054 File Offset: 0x00088254
		private void method_9()
		{
			int int_;
			if (!int.TryParse(this.amount.Text, out int_))
			{
				return;
			}
			this.editor_0.class375_0.method_2(int_);
		}

		// Token: 0x06001B39 RID: 6969
		// RVA: 0x00016D17 File Offset: 0x00014F17
		protected override void OnShown(EventArgs e)
		{
			this.editor_0 = Editor.editor_0;
			this.amount.SelectAll();
			base.OnShown(e);
		}

		// Token: 0x06001B3C RID: 6972
		// RVA: 0x0008A0DC File Offset: 0x000882DC
		private void trOffset_Scroll(object sender, EventArgs e)
		{
			this.amount.Text = this.trOffset.Value.ToString();
		}
	}
}
