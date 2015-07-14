using ns24;
using ns8;
using osu.GameModes.Edit;
using osu_common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns10
{
	// Token: 0x02000660 RID: 1632
	internal sealed class OpenDialog : Form2
	{
		// Token: 0x02000661 RID: 1633
		[CompilerGenerated]
		private sealed class Class863
		{
			// Token: 0x04002EFC RID: 12028
			public string string_0;

			// Token: 0x060032CF RID: 13007
			// RVA: 0x000258FE File Offset: 0x00023AFE
			public bool ctor>b__0(string string_1)
			{
				return string_1.EndsWith(Path.GetFileName(this.string_0));
			}
		}

		// Token: 0x02000662 RID: 1634
		[CompilerGenerated]
		private sealed class Class864
		{
			// Token: 0x04002EFD RID: 12029
			public Class296 class296_0;

			// Token: 0x060032D1 RID: 13009
			// RVA: 0x00025911 File Offset: 0x00023B11
			public bool method_0(Class865 class865_0)
			{
				return class865_0.string_0 == this.class296_0.string_9;
			}
		}

		// Token: 0x04002EF6 RID: 12022
		private bool bool_1;

		// Token: 0x04002EFA RID: 12026
		private CheckBox checkBoxAutosave;

		// Token: 0x04002EF5 RID: 12021
		private Class26<Class865> class26_0;

		// Token: 0x04002EF4 RID: 12020
		private Editor editor_0;

		// Token: 0x04002EF7 RID: 12023
		private IContainer icontainer_0;

		// Token: 0x04002EF9 RID: 12025
		private Label label1;

		// Token: 0x04002EF8 RID: 12024
		private ListBox listBox1;

		// Token: 0x04002EFB RID: 12027
		private Panel panel1;

		// Token: 0x060032C6 RID: 12998
		// RVA: 0x00154884 File Offset: 0x00152A84
		internal OpenDialog(bool bool_2)
		{
			this.editor_0 = Editor.editor_0;
			this.InitializeComponent();
			this.bool_1 = bool_2;
			if (bool_2)
			{
				this.checkBoxAutosave.Visible = false;
			}
			base.TopLevel = true;
			this.class26_0 = new Class26<Class865>();
			List<string> list = new List<string>(Class466.Current.bool_10 ? Class466.Current.method_44().method_16() : Directory.GetFiles(Class466.Current.method_3(), "*.osu"));
			if (Class466.Current.method_8() != null)
			{
				string[] files = Directory.GetFiles(Class466.Current.method_8(), "*.osu");
				string[] array = files;
				for (int i = 0; i < array.Length; i++)
				{
					string string_0 = array[i];
					if (!list.Exists((string string_1) => string_1.EndsWith(Path.GetFileName(string_0))))
					{
						list.Add(string_0);
					}
				}
			}
			if (Class466.Current.method_8() != null)
			{
				Class466.smethod_14(Class466.Current.method_8());
			}
			foreach (string current in list)
			{
				Class865 class2 = new Class865();
				Class296 class3 = Class466.smethod_24(Path.GetFileName(current));
				if (class3 == null)
				{
					class2.string_1 = "?NEW? " + Path.GetFileName(current);
					class2.string_0 = Path.GetFileName(current);
					class2.double_0 = 10.0;
				}
				else
				{
					class2.class296_0 = class3;
					class2.string_0 = class3.string_9;
					class2.string_1 = string.Format("{0}", class3.string_14);
					class2.double_0 = class3.method_27();
				}
				this.class26_0.method_0(class2);
			}
			foreach (Class865 current2 in this.class26_0)
			{
				this.listBox1.Items.Add(current2);
			}
			if (!bool_2)
			{
				this.method_9(Class466.Current);
				return;
			}
			Class865 class4 = new Class865();
			class4.string_1 = "None";
			this.class26_0.Insert(0, class4);
			this.listBox1.Items.Insert(0, class4);
			if (this.editor_0.class371_0.class297_1 == null)
			{
				this.listBox1.SelectedIndex = 0;
				return;
			}
			this.method_9(this.editor_0.class371_0.class297_1.class296_0);
		}

		// Token: 0x060032CC RID: 13004
		// RVA: 0x000258DF File Offset: 0x00023ADF
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060032CD RID: 13005
		// RVA: 0x00154C88 File Offset: 0x00152E88
		private void InitializeComponent()
		{
			this.listBox1 = new ListBox();
			this.label1 = new Label();
			this.checkBoxAutosave = new CheckBox();
			this.panel1 = new Panel();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.listBox1.Dock = DockStyle.Fill;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new Point(0, 0);
			this.listBox1.Margin = new Padding(0);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new Size(165, 116);
			this.listBox1.TabIndex = 0;
			this.listBox1.SelectedIndexChanged += new EventHandler(this.listBox1_SelectedIndexChanged);
			this.listBox1.DoubleClick += new EventHandler(this.listBox1_DoubleClick);
			this.label1.Location = new Point(4, 2);
			this.label1.Name = "label1";
			this.label1.Size = new Size(159, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "Available Difficulties:";
			this.checkBoxAutosave.AutoSize = true;
			this.checkBoxAutosave.FlatStyle = FlatStyle.System;
			this.checkBoxAutosave.Location = new Point(7, 142);
			this.checkBoxAutosave.Name = "checkBoxAutosave";
			this.checkBoxAutosave.Size = new Size(160, 20);
			this.checkBoxAutosave.TabIndex = 1;
			this.checkBoxAutosave.Text = "Save without prompting";
			this.checkBoxAutosave.UseVisualStyleBackColor = true;
			this.panel1.Controls.Add(this.listBox1);
			this.panel1.Location = new Point(7, 20);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(165, 116);
			this.panel1.TabIndex = 0;
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			base.ClientSize = new Size(179, 166);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.checkBoxAutosave);
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "OpenDialog";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.Manual;
			this.Text = "Difficulty Selection";
			base.KeyDown += new KeyEventHandler(this.OpenDialog_KeyDown);
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060032C9 RID: 13001
		// RVA: 0x0000653E File Offset: 0x0000473E
		private void listBox1_DoubleClick(object sender, EventArgs e)
		{
		}

		// Token: 0x060032CA RID: 13002
		// RVA: 0x00154B78 File Offset: 0x00152D78
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			string string_ = Class466.Current.string_9;
			string fileName = Path.GetFileName(this.method_10());
			if (string_ == fileName)
			{
				return;
			}
			if (!this.bool_1)
			{
				if (this.checkBoxAutosave.Checked)
				{
					this.editor_0.method_8(false);
				}
				else if (!this.editor_0.method_8(true))
				{
					this.method_9(Class466.Current);
					return;
				}
				if (!Class466.smethod_23(fileName))
				{
					Class466.smethod_12(false, false);
					Class466.smethod_23(fileName);
				}
				Class296 current = Class466.Current;
				if (current != null)
				{
					if (current.string_9 != string_)
					{
						this.editor_0.method_3(current, false, false);
						this.editor_0.method_18();
						return;
					}
				}
				else
				{
					Class466.smethod_23(string_);
					MessageBox.Show("Cannot load this file!");
				}
				return;
			}
			if (fileName == null)
			{
				this.editor_0.method_2(null);
				return;
			}
			Class296 class = Class466.smethod_24(fileName);
			if (class != null && class != Class466.Current)
			{
				if (class.method_5() == PlayModes.OsuMania)
				{
					if (!this.editor_0.method_2(class))
					{
						MessageBox.Show("Cannot load this file!");
					}
					return;
				}
			}
		}

		// Token: 0x060032C8 RID: 13000
		// RVA: 0x000258B6 File Offset: 0x00023AB6
		internal string method_10()
		{
			return ((Class865)this.listBox1.SelectedItem).string_0;
		}

		// Token: 0x060032C7 RID: 12999
		// RVA: 0x00154B34 File Offset: 0x00152D34
		private void method_9(Class296 class296_0)
		{
			OpenDialog.Class864 class = new OpenDialog.Class864();
			class.class296_0 = class296_0;
			int num = this.class26_0.FindIndex(new Predicate<Class865>(class.method_0));
			if (num >= 0)
			{
				this.listBox1.SelectedIndex = num;
			}
		}

		// Token: 0x060032CB RID: 13003
		// RVA: 0x000258CD File Offset: 0x00023ACD
		private void OpenDialog_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				base.Close();
			}
		}
	}
}
