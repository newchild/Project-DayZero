using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns10
{
	// Token: 0x02000379 RID: 889
	internal sealed class FileColissionDialog : Form
	{
		// Token: 0x0200037A RID: 890
		internal enum Enum41
		{
			// Token: 0x0400157A RID: 5498
			const_0,
			// Token: 0x0400157B RID: 5499
			const_1,
			// Token: 0x0400157C RID: 5500
			const_2,
			// Token: 0x0400157D RID: 5501
			const_3,
			// Token: 0x0400157E RID: 5502
			const_4
		}

		// Token: 0x04001567 RID: 5479
		private Button BtnNo;

		// Token: 0x04001569 RID: 5481
		private Button BtnNoToAll;

		// Token: 0x04001566 RID: 5478
		private Button BtnYes;

		// Token: 0x04001568 RID: 5480
		private Button BtnYesToAll;

		// Token: 0x04001578 RID: 5496
		[CompilerGenerated]
		private FileColissionDialog.Enum41 enum41_0;

		// Token: 0x04001565 RID: 5477
		private IContainer icontainer_0;

		// Token: 0x0400156A RID: 5482
		private Label label1;

		// Token: 0x04001577 RID: 5495
		private Label label11;

		// Token: 0x04001570 RID: 5488
		private Label label2;

		// Token: 0x0400156E RID: 5486
		private Label label5;

		// Token: 0x04001571 RID: 5489
		private Label label6;

		// Token: 0x04001575 RID: 5493
		private Label label8;

		// Token: 0x0400156D RID: 5485
		private Label LblFilesizeExtracted;

		// Token: 0x04001574 RID: 5492
		private Label LblFilesizeOsz2;

		// Token: 0x0400156F RID: 5487
		private Label LblLocationExtracted;

		// Token: 0x04001576 RID: 5494
		private Label LblLocationOsz2;

		// Token: 0x0400156C RID: 5484
		private Label LblModifiedExtracted;

		// Token: 0x04001573 RID: 5491
		private Label LblModifiedOsz2;

		// Token: 0x0400156B RID: 5483
		private Panel panel1;

		// Token: 0x04001572 RID: 5490
		private Panel panel2;

		// Token: 0x06001AEE RID: 6894
		// RVA: 0x00085ED0 File Offset: 0x000840D0
		public FileColissionDialog(string string_0, int int_0, DateTime dateTime_0, string string_1, int int_1, DateTime dateTime_1)
		{
			this.InitializeComponent();
			this.LblLocationExtracted.Text = string_0;
			this.LblFilesizeExtracted.Text = string.Format("{0} KB", int_0 / 1024);
			this.LblModifiedExtracted.Text = dateTime_0.ToString();
			this.LblLocationOsz2.Text = string_1;
			this.LblFilesizeOsz2.Text = string.Format("{0} KB", int_1 / 1024);
			this.LblModifiedOsz2.Text = dateTime_1.ToString();
			base.DialogResult = DialogResult.Ignore;
		}

		// Token: 0x06001AEF RID: 6895
		// RVA: 0x00085F7C File Offset: 0x0008417C
		private void BtnNoToAll_Click(object sender, EventArgs e)
		{
			if (!(sender is Button))
			{
				return;
			}
			if (sender.Equals(this.BtnYes))
			{
				this.method_1(FileColissionDialog.Enum41.const_1);
			}
			else if (sender.Equals(this.BtnYesToAll))
			{
				this.method_1(FileColissionDialog.Enum41.const_2);
			}
			else if (sender.Equals(this.BtnNo))
			{
				this.method_1(FileColissionDialog.Enum41.const_3);
			}
			else if (sender.Equals(this.BtnNoToAll))
			{
				this.method_1(FileColissionDialog.Enum41.const_4);
			}
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x06001AF1 RID: 6897
		// RVA: 0x00016979 File Offset: 0x00014B79
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001AF2 RID: 6898
		// RVA: 0x00085FFC File Offset: 0x000841FC
		private void InitializeComponent()
		{
			this.BtnYes = new Button();
			this.BtnNo = new Button();
			this.BtnYesToAll = new Button();
			this.BtnNoToAll = new Button();
			this.label1 = new Label();
			this.panel1 = new Panel();
			this.LblModifiedExtracted = new Label();
			this.LblFilesizeExtracted = new Label();
			this.label5 = new Label();
			this.LblLocationExtracted = new Label();
			this.label2 = new Label();
			this.label6 = new Label();
			this.panel2 = new Panel();
			this.LblModifiedOsz2 = new Label();
			this.LblFilesizeOsz2 = new Label();
			this.label8 = new Label();
			this.LblLocationOsz2 = new Label();
			this.label11 = new Label();
			Label label = new Label();
			Label label2 = new Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			label.AutoSize = true;
			label.Location = new Point(4, 33);
			label.Name = "label4";
			label.Size = new Size(44, 13);
			label.TabIndex = 2;
			label.Text = "Filesize:";
			label2.AutoSize = true;
			label2.Location = new Point(4, 29);
			label2.Name = "label9";
			label2.Size = new Size(44, 13);
			label2.TabIndex = 2;
			label2.Text = "Filesize:";
			this.BtnYes.Location = new Point(80, 241);
			this.BtnYes.Name = "BtnYes";
			this.BtnYes.Size = new Size(75, 23);
			this.BtnYes.TabIndex = 0;
			this.BtnYes.Text = "Yes";
			this.BtnYes.UseVisualStyleBackColor = true;
			this.BtnYes.Click += new EventHandler(this.BtnNoToAll_Click);
			this.BtnNo.Location = new Point(176, 241);
			this.BtnNo.Name = "BtnNo";
			this.BtnNo.Size = new Size(75, 23);
			this.BtnNo.TabIndex = 1;
			this.BtnNo.Text = "No";
			this.BtnNo.UseVisualStyleBackColor = true;
			this.BtnNo.Click += new EventHandler(this.BtnNoToAll_Click);
			this.BtnYesToAll.Location = new Point(276, 241);
			this.BtnYesToAll.Name = "BtnYesToAll";
			this.BtnYesToAll.Size = new Size(75, 23);
			this.BtnYesToAll.TabIndex = 2;
			this.BtnYesToAll.Text = "Yes to all";
			this.BtnYesToAll.UseVisualStyleBackColor = true;
			this.BtnYesToAll.Click += new EventHandler(this.BtnNoToAll_Click);
			this.BtnNoToAll.Location = new Point(373, 241);
			this.BtnNoToAll.Name = "BtnNoToAll";
			this.BtnNoToAll.Size = new Size(75, 23);
			this.BtnNoToAll.TabIndex = 3;
			this.BtnNoToAll.Text = "No to all";
			this.BtnNoToAll.UseVisualStyleBackColor = true;
			this.BtnNoToAll.Click += new EventHandler(this.BtnNoToAll_Click);
			this.label1.Location = new Point(34, 21);
			this.label1.Name = "label1";
			this.label1.Size = new Size(249, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Do you want to replace the following file?";
			this.panel1.BorderStyle = BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.LblModifiedExtracted);
			this.panel1.Controls.Add(this.LblFilesizeExtracted);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(label);
			this.panel1.Controls.Add(this.LblLocationExtracted);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new Point(40, 45);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(470, 66);
			this.panel1.TabIndex = 5;
			this.LblModifiedExtracted.Location = new Point(87, 46);
			this.LblModifiedExtracted.Name = "LblModifiedExtracted";
			this.LblModifiedExtracted.Size = new Size(378, 13);
			this.LblModifiedExtracted.TabIndex = 5;
			this.LblFilesizeExtracted.Location = new Point(87, 33);
			this.LblFilesizeExtracted.Name = "LblFilesizeExtracted";
			this.LblFilesizeExtracted.Size = new Size(378, 13);
			this.LblFilesizeExtracted.TabIndex = 4;
			this.LblFilesizeExtracted.Click += new EventHandler(this.LblFilesizeExtracted_Click);
			this.label5.AutoSize = true;
			this.label5.Location = new Point(4, 46);
			this.label5.Name = "label5";
			this.label5.Size = new Size(75, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Date modified:";
			this.LblLocationExtracted.Location = new Point(84, 4);
			this.LblLocationExtracted.Name = "LblLocationExtracted";
			this.LblLocationExtracted.Size = new Size(381, 26);
			this.LblLocationExtracted.TabIndex = 1;
			this.label2.AutoSize = true;
			this.label2.Location = new Point(4, 4);
			this.label2.Name = "label2";
			this.label2.Size = new Size(51, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Location:";
			this.label6.AutoSize = true;
			this.label6.Location = new Point(37, 124);
			this.label6.Name = "label6";
			this.label6.Size = new Size(29, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "With";
			this.panel2.BorderStyle = BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.LblModifiedOsz2);
			this.panel2.Controls.Add(this.LblFilesizeOsz2);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(label2);
			this.panel2.Controls.Add(this.LblLocationOsz2);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Location = new Point(40, 153);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(470, 67);
			this.panel2.TabIndex = 7;
			this.LblModifiedOsz2.Location = new Point(87, 42);
			this.LblModifiedOsz2.Name = "LblModifiedOsz2";
			this.LblModifiedOsz2.Size = new Size(378, 13);
			this.LblModifiedOsz2.TabIndex = 5;
			this.LblFilesizeOsz2.Location = new Point(87, 29);
			this.LblFilesizeOsz2.Name = "LblFilesizeOsz2";
			this.LblFilesizeOsz2.Size = new Size(382, 13);
			this.LblFilesizeOsz2.TabIndex = 4;
			this.label8.AutoSize = true;
			this.label8.Location = new Point(4, 42);
			this.label8.Name = "label8";
			this.label8.Size = new Size(75, 13);
			this.label8.TabIndex = 3;
			this.label8.Text = "Date modified:";
			this.LblLocationOsz2.Location = new Point(84, 4);
			this.LblLocationOsz2.Name = "LblLocationOsz2";
			this.LblLocationOsz2.Size = new Size(381, 25);
			this.LblLocationOsz2.TabIndex = 1;
			this.label11.AutoSize = true;
			this.label11.Location = new Point(4, 4);
			this.label11.Name = "label11";
			this.label11.Size = new Size(51, 13);
			this.label11.TabIndex = 0;
			this.label11.Text = "Location:";
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			base.ClientSize = new Size(557, 288);
			base.ControlBox = false;
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.BtnNoToAll);
			base.Controls.Add(this.BtnYesToAll);
			base.Controls.Add(this.BtnNo);
			base.Controls.Add(this.BtnYes);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FileColissionDialog";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "Replace File?";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06001AF0 RID: 6896
		// RVA: 0x0000653E File Offset: 0x0000473E
		private void LblFilesizeExtracted_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001AEC RID: 6892
		// RVA: 0x00016968 File Offset: 0x00014B68
		[CompilerGenerated]
		public FileColissionDialog.Enum41 method_0()
		{
			return this.enum41_0;
		}

		// Token: 0x06001AED RID: 6893
		// RVA: 0x00016970 File Offset: 0x00014B70
		[CompilerGenerated]
		private void method_1(FileColissionDialog.Enum41 enum41_1)
		{
			this.enum41_0 = enum41_1;
		}
	}
}
