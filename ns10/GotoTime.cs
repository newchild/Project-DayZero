using ns14;
using ns8;
using osu.GameModes.Edit;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns10
{
	// Token: 0x020004C3 RID: 1219
	internal sealed class GotoTime : Form2
	{
		// Token: 0x04002056 RID: 8278
		private IContainer icontainer_0;

		// Token: 0x04002058 RID: 8280
		private Label label1;

		// Token: 0x04002057 RID: 8279
		private TextBox time;

		// Token: 0x060026ED RID: 9965
		// RVA: 0x000ED798 File Offset: 0x000EB998
		public GotoTime(string string_0)
		{
			this.InitializeComponent();
			this.time.Text = string_0;
			this.time.SelectAll();
			if (Class601.smethod_1())
			{
				base.method_4(new EventHandler<EventArgs12>(this.method_9));
				this.Text = "";
				return;
			}
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			this.label1.Visible = false;
			this.time.Location = new Point(12, 12);
			base.ClientSize = new Size(base.ClientSize.Width, this.time.Height + 24);
			if (!Application.RenderWithVisualStyles)
			{
				this.BackColor = SystemColors.Control;
			}
		}

		// Token: 0x060026F1 RID: 9969
		// RVA: 0x0001E270 File Offset: 0x0001C470
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060026F0 RID: 9968
		// RVA: 0x0001E252 File Offset: 0x0001C452
		private void GotoTime_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((short)e.KeyChar == 27 || (short)e.KeyChar == 13)
			{
				base.Close();
			}
		}

		// Token: 0x060026F2 RID: 9970
		// RVA: 0x000ED850 File Offset: 0x000EBA50
		private void InitializeComponent()
		{
			this.label1 = new Label();
			this.time = new TextBox();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.label1.Location = new Point(12, 10);
			this.label1.Name = "label1";
			this.label1.Size = new Size(259, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "Jump to time: [mm:ss:ms] (combonumbers,...)";
			this.time.Location = new Point(12, 30);
			this.time.Name = "time";
			this.time.Size = new Size(287, 20);
			this.time.TabIndex = 0;
			this.time.TextChanged += new EventHandler(this.time_TextChanged);
			this.time.KeyPress += new KeyPressEventHandler(this.GotoTime_KeyPress);
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			this.BackColor = SystemColors.ControlLightLight;
			base.ClientSize = new Size(311, 43);
			base.ControlBox = false;
			base.Controls.Add(this.time);
			base.Controls.Add(this.label1);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "GotoTime";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.Manual;
			this.Text = "Jump to time: [mm:ss:ms] (combonumbers,...)";
			base.KeyPress += new KeyPressEventHandler(this.GotoTime_KeyPress);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060026EF RID: 9967
		// RVA: 0x0001E249 File Offset: 0x0001C449
		private void method_9(object sender, EventArgs12 e)
		{
			e.enum52_0 = Enum52.const_3;
		}

		// Token: 0x060026EE RID: 9966
		// RVA: 0x0001E231 File Offset: 0x0001C431
		private void time_TextChanged(object sender, EventArgs e)
		{
			Editor.smethod_0(this.time.Text.Trim());
		}
	}
}
