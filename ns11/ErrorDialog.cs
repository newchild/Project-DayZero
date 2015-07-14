using ns14;
using ns29;
using ns42;
using ns8;
using osu.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace ns11
{
	// Token: 0x020005A3 RID: 1443
	internal sealed class ErrorDialog : Form3
	{
		// Token: 0x020005A4 RID: 1444
		[CompilerGenerated]
		private sealed class Class766
		{
			// Token: 0x040026A9 RID: 9897
			public Exception exception_0;
		}

		// Token: 0x020005A5 RID: 1445
		[CompilerGenerated]
		private sealed class Class767
		{
			// Token: 0x040026AA RID: 9898
			public ErrorDialog.Class766 class766_0;

			// Token: 0x040026AC RID: 9900
			public StackTrace stackTrace_0;

			// Token: 0x040026AB RID: 9899
			public string string_0;

			// Token: 0x06002E50 RID: 11856
			// RVA: 0x0012C638 File Offset: 0x0012A838
			public void ctor>b__0(object sender, DoWorkEventArgs e)
			{
				Class764 class = new Class764();
				StringBuilder stringBuilder = new StringBuilder();
				foreach (StackFrame current in Class771.smethod_1(this.stackTrace_0.GetFrames()))
				{
					stringBuilder.AppendLine("METHOD " + current.GetMethod());
					stringBuilder.AppendLine("Module " + current.GetMethod().Module);
					stringBuilder.AppendLine(string.Concat(new object[]
					{
						"Il-Offset: ",
						current.GetILOffset(),
						" Jit-offset: ",
						current.GetNativeOffset()
					}));
					stringBuilder.AppendLine("IL code ");
					stringBuilder.AppendLine(Class771.smethod_0(current.GetMethod()));
					stringBuilder.AppendLine();
					MethodBody methodBody = current.GetMethod().GetMethodBody();
					List<ExceptionHandlingClause> list = (methodBody != null) ? new List<ExceptionHandlingClause>(methodBody.ExceptionHandlingClauses) : null;
					if (list != null && list.Count != 0)
					{
						stringBuilder.AppendLine("possible caught exceptions:");
						foreach (ExceptionHandlingClause current2 in list)
						{
							try
							{
								stringBuilder.AppendLine(string.Format("catchType:{0}, Flags:{1}, HandlerLength:{2}, HandlerOffset:{3}, TryLength:{4}, TryOffset:{5}", new object[]
								{
									current2.CatchType,
									current2.Flags,
									current2.HandlerLength,
									current2.HandlerOffset,
									current2.TryLength,
									current2.TryOffset
								}));
							}
							catch
							{
								stringBuilder.AppendLine("Unknown ExceptionType");
							}
						}
						stringBuilder.AppendLine("ENDMETHOD");
						stringBuilder.AppendLine();
					}
				}
				class.string_1 = stringBuilder.ToString();
				class.string_2 = this.string_0;
				class.string_3 = ((this.class766_0.exception_0 != null) ? this.class766_0.exception_0.GetType().ToString() : string.Empty);
				Class765.smethod_0(class);
			}
		}

		// Token: 0x040026A0 RID: 9888
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x040026A1 RID: 9889
		public static bool bool_1;

		// Token: 0x040026A5 RID: 9893
		private Button buttonReport;

		// Token: 0x040026A3 RID: 9891
		private Button buttonRestart;

		// Token: 0x040026A2 RID: 9890
		private IContainer icontainer_0;

		// Token: 0x040026A7 RID: 9895
		private Label label1;

		// Token: 0x040026A6 RID: 9894
		private Panel panel1;

		// Token: 0x040026A4 RID: 9892
		private PictureBox pippiBox;

		// Token: 0x040026A8 RID: 9896
		private TextBox textBoxDetails;

		// Token: 0x06002E40 RID: 11840
		// RVA: 0x00022EF7 File Offset: 0x000210F7
		public ErrorDialog(string string_0, bool bool_2) : this(new Exception(string_0), bool_2)
		{
		}

		// Token: 0x06002E41 RID: 11841
		// RVA: 0x0012BDB4 File Offset: 0x00129FB4
		public ErrorDialog(Exception exception_0, bool bool_2)
		{
			ErrorDialog.Class766 class = new ErrorDialog.Class766();
			class.exception_0 = exception_0;
			base..ctor();
			SplashScreen.smethod_3();
			ErrorDialog.bool_1 = true;
			base.method_1();
			base.ControlAdded += new ControlEventHandler(this.ErrorDialog_ControlAdded);
			base.ControlRemoved += new ControlEventHandler(this.ErrorDialog_ControlRemoved);
			this.InitializeComponent();
			StringBuilder stringBuilder = new StringBuilder();
			string[] array = class.exception_0.ToString().Split(new char[]
			{
				'\n'
			});
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				if (text.Contains("Microsoft.Xna.Framework.Game.Tick"))
				{
					break;
				}
				stringBuilder.AppendLine(text.Trim(new char[]
				{
					'\r'
				}));
			}
			string string_0 = stringBuilder.ToString();
			this.textBoxDetails.Text = string_0;
			StackTrace stackTrace_0 = new StackTrace(class.exception_0);
			if (bool_2)
			{
				this.backgroundWorker_0 = new BackgroundWorker();
				this.backgroundWorker_0.DoWork += delegate(object sender, DoWorkEventArgs e)
				{
					Class764 class3 = new Class764();
					StringBuilder stringBuilder2 = new StringBuilder();
					foreach (StackFrame current in Class771.smethod_1(stackTrace_0.GetFrames()))
					{
						stringBuilder2.AppendLine("METHOD " + current.GetMethod());
						stringBuilder2.AppendLine("Module " + current.GetMethod().Module);
						stringBuilder2.AppendLine(string.Concat(new object[]
						{
							"Il-Offset: ",
							current.GetILOffset(),
							" Jit-offset: ",
							current.GetNativeOffset()
						}));
						stringBuilder2.AppendLine("IL code ");
						stringBuilder2.AppendLine(Class771.smethod_0(current.GetMethod()));
						stringBuilder2.AppendLine();
						MethodBody methodBody = current.GetMethod().GetMethodBody();
						List<ExceptionHandlingClause> list = (methodBody != null) ? new List<ExceptionHandlingClause>(methodBody.ExceptionHandlingClauses) : null;
						if (list != null && list.Count != 0)
						{
							stringBuilder2.AppendLine("possible caught exceptions:");
							foreach (ExceptionHandlingClause current2 in list)
							{
								try
								{
									stringBuilder2.AppendLine(string.Format("catchType:{0}, Flags:{1}, HandlerLength:{2}, HandlerOffset:{3}, TryLength:{4}, TryOffset:{5}", new object[]
									{
										current2.CatchType,
										current2.Flags,
										current2.HandlerLength,
										current2.HandlerOffset,
										current2.TryLength,
										current2.TryOffset
									}));
								}
								catch
								{
									stringBuilder2.AppendLine("Unknown ExceptionType");
								}
							}
							stringBuilder2.AppendLine("ENDMETHOD");
							stringBuilder2.AppendLine();
						}
					}
					class3.string_1 = stringBuilder2.ToString();
					class3.string_2 = string_0;
					class3.string_3 = ((class.exception_0 != null) ? class.exception_0.GetType().ToString() : string.Empty);
					Class765.smethod_0(class3);
				};
				this.backgroundWorker_0.RunWorkerAsync();
			}
		}

		// Token: 0x06002E43 RID: 11843
		// RVA: 0x00022F14 File Offset: 0x00021114
		private void buttonReport_Click(object sender, EventArgs e)
		{
			Process.Start("http://osu.ppy.sh/forum/viewtopic.php?f=5&t=576");
		}

		// Token: 0x06002E42 RID: 11842
		// RVA: 0x00022F06 File Offset: 0x00021106
		private void buttonRestart_Click(object sender, EventArgs e)
		{
			Class905.smethod_11(false);
			base.Close();
		}

		// Token: 0x06002E4C RID: 11852
		// RVA: 0x00022F90 File Offset: 0x00021190
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002E49 RID: 11849
		// RVA: 0x00022F74 File Offset: 0x00021174
		private void ErrorDialog_ControlAdded(object sender, ControlEventArgs e)
		{
			this.method_10(e.Control);
		}

		// Token: 0x06002E4A RID: 11850
		// RVA: 0x00022F82 File Offset: 0x00021182
		private void ErrorDialog_ControlRemoved(object sender, ControlEventArgs e)
		{
			this.method_11(e.Control);
		}

		// Token: 0x06002E44 RID: 11844
		// RVA: 0x00022F21 File Offset: 0x00021121
		private void ErrorDialog_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.WindowsShutDown)
			{
				Class905.smethod_12();
			}
		}

		// Token: 0x06002E4B RID: 11851
		// RVA: 0x0012C014 File Offset: 0x0012A214
		private void ErrorDialog_MouseLeave(object sender, EventArgs e)
		{
			if (!base.ClientRectangle.Contains(base.PointToClient(Cursor.Position)))
			{
				this.textBoxDetails.Visible = false;
			}
		}

		// Token: 0x06002E4D RID: 11853
		// RVA: 0x0012C048 File Offset: 0x0012A248
		private void InitializeComponent()
		{
			this.textBoxDetails = new TextBox();
			this.label1 = new Label();
			this.pippiBox = new PictureBox();
			this.panel1 = new Panel();
			this.buttonRestart = new Button();
			this.buttonReport = new Button();
			((ISupportInitialize)this.pippiBox).BeginInit();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.textBoxDetails.BackColor = Color.White;
			this.textBoxDetails.BorderStyle = BorderStyle.None;
			this.textBoxDetails.ForeColor = Color.Gray;
			this.textBoxDetails.Location = new Point(0, 87);
			this.textBoxDetails.Multiline = true;
			this.textBoxDetails.Name = "textBoxDetails";
			this.textBoxDetails.ReadOnly = true;
			this.textBoxDetails.Size = new Size(364, 374);
			this.textBoxDetails.TabIndex = 9;
			this.textBoxDetails.Visible = false;
			this.textBoxDetails.Click += new EventHandler(this.textBoxDetails_Click);
			this.label1.BackColor = Color.Transparent;
			this.label1.Dock = DockStyle.Top;
			this.label1.Font = new Font("Segoe UI Semilight", 26.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.FromArgb(40, 106, 151);
			this.label1.Location = new Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new Size(364, 88);
			this.label1.TabIndex = 8;
			this.label1.Text = "osu! crashed";
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			this.pippiBox.Anchor = AnchorStyles.Bottom;
			this.pippiBox.BackgroundImageLayout = ImageLayout.None;
			this.pippiBox.Image = Resources.osu_crash;
			this.pippiBox.Location = new Point(-7, 87);
			this.pippiBox.Name = "pippiBox";
			this.pippiBox.Size = new Size(375, 374);
			this.pippiBox.TabIndex = 4;
			this.pippiBox.TabStop = false;
			this.pippiBox.Click += new EventHandler(this.pippiBox_Click);
			this.panel1.BackColor = Color.FromArgb(85, 85, 85);
			this.panel1.Controls.Add(this.buttonRestart);
			this.panel1.Controls.Add(this.buttonReport);
			this.panel1.Dock = DockStyle.Bottom;
			this.panel1.Location = new Point(0, 461);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(364, 100);
			this.panel1.TabIndex = 7;
			this.buttonRestart.FlatAppearance.BorderColor = Color.DimGray;
			this.buttonRestart.FlatAppearance.BorderSize = 0;
			this.buttonRestart.FlatAppearance.MouseDownBackColor = Color.FromArgb(61, 172, 220);
			this.buttonRestart.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 127, 161);
			this.buttonRestart.FlatStyle = FlatStyle.Flat;
			this.buttonRestart.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.buttonRestart.ForeColor = Color.White;
			this.buttonRestart.Location = new Point(7, 14);
			this.buttonRestart.Name = "buttonRestart";
			this.buttonRestart.Size = new Size(350, 35);
			this.buttonRestart.TabIndex = 2;
			this.buttonRestart.Text = "restart osu!";
			this.buttonRestart.UseVisualStyleBackColor = true;
			this.buttonRestart.Click += new EventHandler(this.buttonRestart_Click);
			this.buttonReport.FlatAppearance.BorderColor = Color.DimGray;
			this.buttonReport.FlatAppearance.BorderSize = 0;
			this.buttonReport.FlatStyle = FlatStyle.Flat;
			this.buttonReport.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.buttonReport.ForeColor = Color.White;
			this.buttonReport.Location = new Point(7, 57);
			this.buttonReport.Name = "buttonReport";
			this.buttonReport.Size = new Size(350, 35);
			this.buttonReport.TabIndex = 6;
			this.buttonReport.Text = "report an issue...";
			this.buttonReport.UseVisualStyleBackColor = true;
			this.buttonReport.Click += new EventHandler(this.buttonReport_Click);
			base.AutoScaleMode = AutoScaleMode.None;
			this.BackColor = Color.White;
			base.ClientSize = new Size(364, 561);
			base.Controls.Add(this.textBoxDetails);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pippiBox);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ErrorDialog";
			base.Opacity = 1.0;
			base.ShowIcon = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "oh no!";
			base.FormClosing += new FormClosingEventHandler(this.ErrorDialog_FormClosing);
			base.MouseLeave += new EventHandler(this.ErrorDialog_MouseLeave);
			((ISupportInitialize)this.pippiBox).EndInit();
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06002E47 RID: 11847
		// RVA: 0x0012BEF4 File Offset: 0x0012A0F4
		private void method_10(Control control_0)
		{
			control_0.MouseLeave += new EventHandler(this.ErrorDialog_MouseLeave);
			control_0.ControlAdded += new ControlEventHandler(this.ErrorDialog_ControlAdded);
			control_0.ControlRemoved += new ControlEventHandler(this.ErrorDialog_ControlRemoved);
			foreach (Control control_ in control_0.Controls)
			{
				this.method_10(control_);
			}
		}

		// Token: 0x06002E48 RID: 11848
		// RVA: 0x0012BF84 File Offset: 0x0012A184
		private void method_11(Control control_0)
		{
			control_0.MouseLeave -= new EventHandler(this.ErrorDialog_MouseLeave);
			control_0.ControlAdded -= new ControlEventHandler(this.ErrorDialog_ControlAdded);
			control_0.ControlRemoved -= new ControlEventHandler(this.ErrorDialog_ControlRemoved);
			foreach (Control control_ in control_0.Controls)
			{
				this.method_11(control_);
			}
		}

		// Token: 0x06002E45 RID: 11845
		// RVA: 0x00022F3A File Offset: 0x0002113A
		private void pippiBox_Click(object sender, EventArgs e)
		{
			this.textBoxDetails.Visible = !this.textBoxDetails.Visible;
		}

		// Token: 0x06002E46 RID: 11846
		// RVA: 0x00022F55 File Offset: 0x00021155
		private void textBoxDetails_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.textBoxDetails.SelectedText))
			{
				this.textBoxDetails.SelectAll();
			}
		}
	}
}
