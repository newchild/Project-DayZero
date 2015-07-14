using ns26;
using ns8;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns10
{
	// Token: 0x02000382 RID: 898
	internal sealed class VolumeDialog : Form2
	{
		// Token: 0x040015D9 RID: 5593
		private IContainer icontainer_0;

		// Token: 0x040015DB RID: 5595
		private Label label1;

		// Token: 0x040015DE RID: 5598
		private Label label4;

		// Token: 0x040015DC RID: 5596
		private Label lb_music;

		// Token: 0x040015DD RID: 5597
		private Label lb_sample;

		// Token: 0x040015DA RID: 5594
		private TrackBar tr_music;

		// Token: 0x040015DF RID: 5599
		private TrackBar tr_sample;

		// Token: 0x06001B41 RID: 6977
		// RVA: 0x00016D63 File Offset: 0x00014F63
		public VolumeDialog()
		{
			this.InitializeComponent();
		}

		// Token: 0x06001B45 RID: 6981
		// RVA: 0x00016D71 File Offset: 0x00014F71
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001B46 RID: 6982
		// RVA: 0x0008A654 File Offset: 0x00088854
		private void InitializeComponent()
		{
			this.tr_music = new TrackBar();
			this.label1 = new Label();
			this.lb_music = new Label();
			this.lb_sample = new Label();
			this.label4 = new Label();
			this.tr_sample = new TrackBar();
			((ISupportInitialize)this.tr_music).BeginInit();
			((ISupportInitialize)this.tr_sample).BeginInit();
			base.SuspendLayout();
			this.tr_music.Location = new Point(51, 12);
			this.tr_music.Maximum = 100;
			this.tr_music.Name = "tr_music";
			this.tr_music.Size = new Size(240, 45);
			this.tr_music.TabIndex = 0;
			this.tr_music.TickStyle = TickStyle.None;
			this.tr_music.Scroll += new EventHandler(this.tr_music_Scroll);
			this.label1.AutoSize = true;
			this.label1.Location = new Point(8, 17);
			this.label1.Name = "label1";
			this.label1.Size = new Size(35, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "Music";
			this.lb_music.AutoSize = true;
			this.lb_music.Location = new Point(296, 17);
			this.lb_music.Name = "lb_music";
			this.lb_music.Size = new Size(11, 12);
			this.lb_music.TabIndex = 2;
			this.lb_music.Text = "0";
			this.lb_sample.AutoSize = true;
			this.lb_sample.Location = new Point(296, 52);
			this.lb_sample.Name = "lb_sample";
			this.lb_sample.Size = new Size(11, 12);
			this.lb_sample.TabIndex = 5;
			this.lb_sample.Text = "0";
			this.label4.AutoSize = true;
			this.label4.Location = new Point(7, 52);
			this.label4.Name = "label4";
			this.label4.Size = new Size(41, 12);
			this.label4.TabIndex = 4;
			this.label4.Text = "Sample";
			this.tr_sample.Location = new Point(51, 47);
			this.tr_sample.Maximum = 100;
			this.tr_sample.Name = "tr_sample";
			this.tr_sample.Size = new Size(240, 45);
			this.tr_sample.TabIndex = 3;
			this.tr_sample.TickStyle = TickStyle.None;
			this.tr_sample.Scroll += new EventHandler(this.tr_sample_Scroll);
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			base.ClientSize = new Size(324, 89);
			base.Controls.Add(this.lb_sample);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.tr_sample);
			base.Controls.Add(this.lb_music);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.tr_music);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "VolumeDialog";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Volume";
			((ISupportInitialize)this.tr_music).EndInit();
			((ISupportInitialize)this.tr_sample).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06001B42 RID: 6978
		// RVA: 0x0008A55C File Offset: 0x0008875C
		protected override void OnShown(EventArgs e)
		{
			this.tr_music.Value = Class331.class608_1.Value;
			this.tr_sample.Value = Class331.class608_0.Value;
			this.lb_music.Text = Class331.class608_1.Value.ToString();
			this.lb_sample.Text = Class331.class608_0.Value.ToString();
			base.OnShown(e);
		}

		// Token: 0x06001B43 RID: 6979
		// RVA: 0x0008A5D4 File Offset: 0x000887D4
		private void tr_music_Scroll(object sender, EventArgs e)
		{
			this.lb_music.Text = this.tr_music.Value.ToString();
			Class331.class608_1.Value = this.tr_music.Value;
		}

		// Token: 0x06001B44 RID: 6980
		// RVA: 0x0008A614 File Offset: 0x00088814
		private void tr_sample_Scroll(object sender, EventArgs e)
		{
			this.lb_sample.Text = this.tr_sample.Value.ToString();
			Class331.class608_0.Value = this.tr_sample.Value;
		}
	}
}
