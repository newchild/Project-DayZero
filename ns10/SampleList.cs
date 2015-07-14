using ns26;
using ns8;
using ns89;
using osu.GameModes.Edit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns10
{
	// Token: 0x0200037E RID: 894
	internal sealed class SampleList : Form2
	{
		// Token: 0x040015AC RID: 5548
		private Button b_close;

		// Token: 0x040015AD RID: 5549
		private Button b_del;

		// Token: 0x040015A9 RID: 5545
		private Editor editor_0;

		// Token: 0x040015AA RID: 5546
		private IContainer icontainer_0;

		// Token: 0x040015AB RID: 5547
		private ListBox lb_sample;

		// Token: 0x06001B16 RID: 6934
		// RVA: 0x00016B18 File Offset: 0x00014D18
		public SampleList()
		{
			this.InitializeComponent();
		}

		// Token: 0x06001B18 RID: 6936
		// RVA: 0x00016831 File Offset: 0x00014A31
		private void b_close_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06001B19 RID: 6937
		// RVA: 0x00088780 File Offset: 0x00086980
		private void b_del_Click(object sender, EventArgs e)
		{
			if (this.lb_sample.SelectedItems != null && this.lb_sample.SelectedItems.Count != 0)
			{
				this.editor_0.method_16(false);
				foreach (Class704 class702_ in this.lb_sample.SelectedItems)
				{
					this.editor_0.class872_0.Remove(class702_);
				}
				return;
			}
		}

		// Token: 0x06001B1A RID: 6938
		// RVA: 0x00016B26 File Offset: 0x00014D26
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001B1B RID: 6939
		// RVA: 0x00088818 File Offset: 0x00086A18
		private void InitializeComponent()
		{
			this.lb_sample = new ListBox();
			this.b_close = new Button();
			this.b_del = new Button();
			base.SuspendLayout();
			this.lb_sample.FormattingEnabled = true;
			this.lb_sample.ItemHeight = 12;
			this.lb_sample.Location = new Point(12, 12);
			this.lb_sample.Name = "lb_sample";
			this.lb_sample.SelectionMode = SelectionMode.MultiExtended;
			this.lb_sample.Size = new Size(262, 328);
			this.lb_sample.TabIndex = 17;
			this.b_close.DialogResult = DialogResult.Cancel;
			this.b_close.Location = new Point(187, 350);
			this.b_close.Name = "b_close";
			this.b_close.Size = new Size(87, 30);
			this.b_close.TabIndex = 18;
			this.b_close.Text = "Close";
			this.b_close.UseVisualStyleBackColor = true;
			this.b_close.Click += new EventHandler(this.b_close_Click);
			this.b_del.DialogResult = DialogResult.Cancel;
			this.b_del.Location = new Point(12, 350);
			this.b_del.Name = "b_del";
			this.b_del.Size = new Size(159, 30);
			this.b_del.TabIndex = 19;
			this.b_del.Text = "Delete";
			this.b_del.UseVisualStyleBackColor = true;
			this.b_del.Click += new EventHandler(this.b_del_Click);
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			base.CancelButton = this.b_close;
			base.ClientSize = new Size(286, 392);
			base.Controls.Add(this.b_del);
			base.Controls.Add(this.b_close);
			base.Controls.Add(this.lb_sample);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "SampleList";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Sample events list";
			base.ResumeLayout(false);
		}

		// Token: 0x06001B17 RID: 6935
		// RVA: 0x000886D8 File Offset: 0x000868D8
		protected override void OnShown(EventArgs e)
		{
			this.editor_0 = Editor.editor_0;
			List<Class704> list_ = this.editor_0.class872_0.list_2;
			foreach (Class704 current in list_)
			{
				this.lb_sample.Items.Add(current);
				if (current.int_2 == Class331.int_7)
				{
					this.lb_sample.SetSelected(this.lb_sample.Items.Count - 1, true);
				}
			}
			base.OnShown(e);
		}
	}
}
