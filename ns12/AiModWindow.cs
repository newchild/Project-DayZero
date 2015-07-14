using Microsoft.Xna.Framework.Graphics;
using ns11;
using ns14;
using ns23;
using ns26;
using ns29;
using ns55;
using ns59;
using ns65;
using ns8;
using ns85;
using osu.GameModes.Edit;
using osu.GameModes.Edit.AiMod;
using osu.GameModes.Edit.AiMod.Reports;
using osu.GameplayElements.HitObjects;
using osu.Properties;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns12
{
	// Token: 0x020004C1 RID: 1217
	internal sealed class AiModWindow : Form2
	{
		// Token: 0x020004C2 RID: 1218
		[CompilerGenerated]
		private sealed class Class632
		{
			// Token: 0x04002055 RID: 8277
			public HitObjectBase hitObjectBase_0;

			// Token: 0x060026EC RID: 9964
			// RVA: 0x0001E21C File Offset: 0x0001C41C
			public bool method_0(Class304 class304_0)
			{
				return class304_0.StartTime == this.hitObjectBase_0.StartTime;
			}
		}

		// Token: 0x0400202A RID: 8234
		private AiReport aiReport_0;

		// Token: 0x04002032 RID: 8242
		private BeatmapDifficulty beatmapDifficulty_0;

		// Token: 0x04002023 RID: 8227
		internal static bool bool_1;

		// Token: 0x04002026 RID: 8230
		private bool bool_2;

		// Token: 0x04002029 RID: 8233
		private bool bool_3;

		// Token: 0x0400202B RID: 8235
		private bool bool_4;

		// Token: 0x0400202C RID: 8236
		private bool bool_5;

		// Token: 0x04002035 RID: 8245
		private Button buttonRun;

		// Token: 0x0400204E RID: 8270
		private CheckBox cb_ds;

		// Token: 0x04002024 RID: 8228
		private Class356 class356_0 = new Class356();

		// Token: 0x0400202F RID: 8239
		private Color color_0 = Color.FromArgb(0, 16, 112, 16);

		// Token: 0x04002030 RID: 8240
		private Color color_1 = Color.FromArgb(0, 120, 80, 16);

		// Token: 0x04002031 RID: 8241
		private Color color_2 = Color.FromArgb(0, 136, 16, 16);

		// Token: 0x04002034 RID: 8244
		private DataGridView dataGridView1;

		// Token: 0x0400202D RID: 8237
		internal Dictionary<AiModType, List<AiReport>> dictionary_0 = new Dictionary<AiModType, List<AiReport>>();

		// Token: 0x04002025 RID: 8229
		private readonly Editor editor_0;

		// Token: 0x04002045 RID: 8261
		private GroupBox grpRight;

		// Token: 0x04002033 RID: 8243
		private IContainer icontainer_0;

		// Token: 0x04002050 RID: 8272
		private DataGridViewTextBoxColumn Information;

		// Token: 0x04002027 RID: 8231
		private int int_0;

		// Token: 0x04002028 RID: 8232
		private int int_1;

		// Token: 0x0400204B RID: 8267
		private Label label1;

		// Token: 0x04002049 RID: 8265
		private Label label2;

		// Token: 0x04002047 RID: 8263
		private Label label3;

		// Token: 0x0400204A RID: 8266
		private Label lblDifficulty;

		// Token: 0x04002046 RID: 8262
		private Label lblErrors;

		// Token: 0x04002048 RID: 8264
		private Label lblWarnings;

		// Token: 0x0400202E RID: 8238
		private List<AiModRuleset> list_0 = new List<AiModRuleset>();

		// Token: 0x04002044 RID: 8260
		private Class614 monochromeLabel1;

		// Token: 0x04002042 RID: 8258
		private Class614 monochromeLabel3;

		// Token: 0x04002040 RID: 8256
		private Class614 monochromeLabel4;

		// Token: 0x04002043 RID: 8259
		private Class614 monoDifficulty;

		// Token: 0x0400203F RID: 8255
		private Class614 monoErrors;

		// Token: 0x04002041 RID: 8257
		private Class614 monoWarnings;

		// Token: 0x0400203D RID: 8253
		private Panel panel1;

		// Token: 0x0400204C RID: 8268
		private Panel panel2;

		// Token: 0x0400203E RID: 8254
		private Class613 pnlGlass;

		// Token: 0x0400203C RID: 8252
		private Class615 pnlTop;

		// Token: 0x04002052 RID: 8274
		[CompilerGenerated]
		private static Predicate<AiModRuleset> predicate_0;

		// Token: 0x04002053 RID: 8275
		[CompilerGenerated]
		private static Predicate<AiReport> predicate_1;

		// Token: 0x04002054 RID: 8276
		[CompilerGenerated]
		private static Predicate<AiReport> predicate_2;

		// Token: 0x0400204F RID: 8271
		private DataGridViewImageColumn SeverityColumn;

		// Token: 0x04002036 RID: 8246
		private TabControl tabControl1;

		// Token: 0x04002037 RID: 8247
		private TabPage tabPage1;

		// Token: 0x04002038 RID: 8248
		private TabPage tabPage2;

		// Token: 0x04002039 RID: 8249
		private TabPage tabPage3;

		// Token: 0x0400203A RID: 8250
		private TabPage tabPage4;

		// Token: 0x0400203B RID: 8251
		private TabPage tabPage5;

		// Token: 0x0400204D RID: 8269
		private TabPage tabPage6;

		// Token: 0x04002051 RID: 8273
		private DataGridViewLinkColumn Time;

		// Token: 0x060026D0 RID: 9936
		// RVA: 0x000EB84C File Offset: 0x000E9A4C
		internal AiModWindow(Editor editor_1)
		{
			this.editor_0 = editor_1;
			this.InitializeComponent();
			base.StartPosition = FormStartPosition.CenterScreen;
			base.method_4(new EventHandler<EventArgs12>(this.method_12));
			base.method_5(new EventHandler(this.method_15));
			this.pnlTop.method_0(true);
			this.method_15(this, EventArgs.Empty);
			this.dataGridView1.ColumnHeadersHeight = (int)(23f * Class611.smethod_0(this, false) / 96f);
		}

		// Token: 0x060026E2 RID: 9954
		// RVA: 0x0001E19B File Offset: 0x0001C39B
		private void AiModWindow_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\u001b')
			{
				e.Handled = true;
				this.Close();
			}
		}

		// Token: 0x060026D1 RID: 9937
		// RVA: 0x0000653E File Offset: 0x0000473E
		private void AiModWindow_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060026DA RID: 9946
		// RVA: 0x000EBD28 File Offset: 0x000E9F28
		private void buttonRun_Click(object sender, EventArgs e)
		{
			this.dataGridView1.Rows.Clear();
			this.dictionary_0.Clear();
			if (this.list_0.Count == 0)
			{
				this.list_0.Add(Class365.smethod_0());
				this.list_0.Add(Class365.smethod_3());
				this.list_0.Add(Class365.smethod_1());
				this.list_0.Add(Class365.smethod_2());
				this.list_0.Add(Class365.smethod_4());
				this.list_0.AddRange(this.class356_0.list_0);
			}
			Class297 class297_ = Editor.editor_0.class297_0;
			class297_.method_30();
			foreach (AiModRuleset current in this.list_0)
			{
				List<AiReport> list = current.Run(class297_);
				if (list != null)
				{
					if (!this.dictionary_0.ContainsKey(current.Type))
					{
						this.dictionary_0[current.Type] = new List<AiReport>();
					}
					this.dictionary_0[current.Type].AddRange(list);
				}
			}
			List<AiModRuleset> arg_13F_0 = this.list_0;
			if (AiModWindow.predicate_0 == null)
			{
				AiModWindow.predicate_0 = new Predicate<AiModRuleset>(AiModWindow.smethod_4);
			}
			this.beatmapDifficulty_0 = ((Class287)arg_13F_0.Find(AiModWindow.predicate_0)).beatmapDifficulty_0;
			int num = 0;
			this.dictionary_0[AiModType.All] = new List<AiReport>();
			foreach (KeyValuePair<AiModType, List<AiReport>> current2 in this.dictionary_0)
			{
				this.tabControl1.TabPages[(int)current2.Key].Text = string.Concat(new object[]
				{
					current2.Key.ToString(),
					" (",
					current2.Value.Count,
					")"
				});
				if (current2.Key != AiModType.All)
				{
					num += current2.Value.Count;
					this.dictionary_0[AiModType.All].AddRange(current2.Value);
				}
			}
			if (num == 0)
			{
				this.dictionary_0[AiModType.All].Add(new AiReport(-1, Severity.Info, Class41.GetString(OsuString.AIModWindow_NoProblemsFound), 0, null));
			}
			this.tabControl1_SelectedIndexChanged(null, null);
			this.method_11();
		}

		// Token: 0x060026E3 RID: 9955
		// RVA: 0x0001E1B4 File Offset: 0x0001C3B4
		private void cb_ds_CheckedChanged(object sender, EventArgs e)
		{
			AiModWindow.bool_1 = this.cb_ds.Checked;
			this.buttonRun_Click(null, null);
		}

		// Token: 0x060026D2 RID: 9938
		// RVA: 0x0001E105 File Offset: 0x0001C305
		internal new void Close()
		{
			this.bool_3 = true;
			base.Close();
		}

		// Token: 0x060026D7 RID: 9943
		// RVA: 0x000EBAF0 File Offset: 0x000E9CF0
		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			if (this.dataGridView1.SelectedRows.Count != 0 && !this.bool_4 && this.bool_5)
			{
				this.aiReport_0 = (this.dataGridView1.SelectedRows[0].Tag as AiReport);
				if (this.aiReport_0.RelatedHitObjects.Count > 0)
				{
					this.editor_0.class371_0.Select(this.aiReport_0.RelatedHitObjects.ToArray());
				}
				if (this.aiReport_0.Time != -1)
				{
					Class331.smethod_70(this.aiReport_0.Time, false, false);
				}
				return;
			}
			this.aiReport_0 = null;
		}

		// Token: 0x060026E5 RID: 9957
		// RVA: 0x0001E1CE File Offset: 0x0001C3CE
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060026D8 RID: 9944
		// RVA: 0x000EBBA0 File Offset: 0x000E9DA0
		internal void Draw()
		{
			if (!base.Visible)
			{
				return;
			}
			if (!this.bool_5)
			{
				this.bool_5 = true;
				this.dataGridView1.ClearSelection();
			}
			if (this.aiReport_0 != null)
			{
				AiReportOneObject aiReportOneObject = this.aiReport_0 as AiReportOneObject;
				AiReportTwoObjects aiReportTwoObjects = this.aiReport_0 as AiReportTwoObjects;
				this.aiReport_0.Draw();
				Class304 class = null;
				Class304 class2 = null;
				this.aiReport_0.Check();
				if (aiReportTwoObjects != null)
				{
					class = this.method_10(aiReportTwoObjects.h1);
					class2 = this.method_10(aiReportTwoObjects.h2);
				}
				else if (aiReportOneObject != null)
				{
					class = this.method_10(aiReportOneObject.h1);
				}
				if (class != null && class2 != null)
				{
					if (class.vmethod_9() && class2.vmethod_9())
					{
						Class880 class880_ = new Class880(Class115.smethod_61(class.EndPosition), Class115.smethod_61(class2.Position));
						bool flag = aiReportTwoObjects.Check();
						Class115.interface16_0.Draw(class880_, 8f, (Class115.int_1 % 1000 > 500 || flag) ? Color.get_Black() : Color.get_White());
						Class115.interface16_0.Draw(class880_, 5f, flag ? Color.get_YellowGreen() : Color.get_Red());
						return;
					}
				}
				else if (class != null && class.vmethod_9())
				{
					class.Select();
				}
			}
		}

		// Token: 0x060026E6 RID: 9958
		// RVA: 0x000EC3C4 File Offset: 0x000EA5C4
		private void InitializeComponent()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			this.dataGridView1 = new DataGridView();
			this.pnlTop = new Class615();
			this.cb_ds = new CheckBox();
			this.panel2 = new Panel();
			this.tabControl1 = new TabControl();
			this.tabPage1 = new TabPage();
			this.tabPage2 = new TabPage();
			this.tabPage3 = new TabPage();
			this.tabPage4 = new TabPage();
			this.tabPage5 = new TabPage();
			this.tabPage6 = new TabPage();
			this.panel1 = new Panel();
			this.grpRight = new GroupBox();
			this.lblErrors = new Label();
			this.label3 = new Label();
			this.lblWarnings = new Label();
			this.label2 = new Label();
			this.lblDifficulty = new Label();
			this.label1 = new Label();
			this.pnlGlass = new Class613();
			this.monoErrors = new Class614();
			this.monochromeLabel4 = new Class614();
			this.monoWarnings = new Class614();
			this.monochromeLabel3 = new Class614();
			this.monoDifficulty = new Class614();
			this.monochromeLabel1 = new Class614();
			this.buttonRun = new Button();
			this.SeverityColumn = new DataGridViewImageColumn();
			this.Information = new DataGridViewTextBoxColumn();
			this.Time = new DataGridViewLinkColumn();
			((ISupportInitialize)this.dataGridView1).BeginInit();
			this.pnlTop.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.grpRight.SuspendLayout();
			this.pnlGlass.SuspendLayout();
			base.SuspendLayout();
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			dataGridViewCellStyle.BackColor = Color.WhiteSmoke;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView1.Columns.AddRange(new DataGridViewColumn[]
			{
				this.SeverityColumn,
				this.Information,
				this.Time
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Microsoft YaHei UI", 9f);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = Color.NavajoWhite;
			dataGridViewCellStyle2.SelectionForeColor = Color.Black;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.Dock = DockStyle.Fill;
			this.dataGridView1.Location = new Point(0, 103);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridView1.ScrollBars = ScrollBars.Vertical;
			this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.ShowCellErrors = false;
			this.dataGridView1.ShowEditingIcon = false;
			this.dataGridView1.ShowRowErrors = false;
			this.dataGridView1.Size = new Size(424, 343);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.SelectionChanged += new EventHandler(this.dataGridView1_SelectionChanged);
			this.pnlTop.method_0(false);
			this.pnlTop.Controls.Add(this.cb_ds);
			this.pnlTop.Controls.Add(this.panel2);
			this.pnlTop.Controls.Add(this.panel1);
			this.pnlTop.Controls.Add(this.buttonRun);
			this.pnlTop.Dock = DockStyle.Top;
			this.pnlTop.Location = new Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Padding = new Padding(1);
			this.pnlTop.Size = new Size(424, 103);
			this.pnlTop.TabIndex = 0;
			this.cb_ds.AutoSize = true;
			this.cb_ds.Location = new Point(116, 13);
			this.cb_ds.Name = "cb_ds";
			this.cb_ds.Size = new Size(145, 19);
			this.cb_ds.TabIndex = 13;
			this.cb_ds.Text = "Check distance snap";
			this.cb_ds.UseVisualStyleBackColor = true;
			this.cb_ds.CheckedChanged += new EventHandler(this.cb_ds_CheckedChanged);
			this.panel2.Controls.Add(this.tabControl1);
			this.panel2.Location = new Point(2, 83);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(440, 31);
			this.panel2.TabIndex = 12;
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Controls.Add(this.tabPage6);
			this.tabControl1.Dock = DockStyle.Fill;
			this.tabControl1.Font = new Font("Segoe UI", 8f);
			this.tabControl1.Location = new Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new Size(440, 31);
			this.tabControl1.TabIndex = 10;
			this.tabControl1.SelectedIndexChanged += new EventHandler(this.tabControl1_SelectedIndexChanged);
			this.tabPage1.Location = new Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new Padding(3);
			this.tabPage1.Size = new Size(432, 5);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "All";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.tabPage2.Location = new Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new Padding(3);
			this.tabPage2.Size = new Size(432, 5);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Compose";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.tabPage3.Location = new Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new Size(432, 5);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Design";
			this.tabPage3.UseVisualStyleBackColor = true;
			this.tabPage4.Location = new Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new Size(432, 5);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Timing";
			this.tabPage4.UseVisualStyleBackColor = true;
			this.tabPage5.Location = new Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new Size(432, 5);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Meta";
			this.tabPage5.UseVisualStyleBackColor = true;
			this.tabPage6.Location = new Point(4, 22);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Padding = new Padding(3);
			this.tabPage6.Size = new Size(432, 5);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "Mapset";
			this.tabPage6.UseVisualStyleBackColor = true;
			this.panel1.Controls.Add(this.grpRight);
			this.panel1.Controls.Add(this.pnlGlass);
			this.panel1.Dock = DockStyle.Right;
			this.panel1.Location = new Point(274, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(149, 101);
			this.panel1.TabIndex = 11;
			this.grpRight.Controls.Add(this.lblErrors);
			this.grpRight.Controls.Add(this.label3);
			this.grpRight.Controls.Add(this.lblWarnings);
			this.grpRight.Controls.Add(this.label2);
			this.grpRight.Controls.Add(this.lblDifficulty);
			this.grpRight.Controls.Add(this.label1);
			this.grpRight.Location = new Point(4, 6);
			this.grpRight.Name = "grpRight";
			this.grpRight.Size = new Size(133, 69);
			this.grpRight.TabIndex = 1;
			this.grpRight.TabStop = false;
			this.lblErrors.AutoSize = true;
			this.lblErrors.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblErrors.ForeColor = Color.FromArgb(136, 16, 16);
			this.lblErrors.Location = new Point(63, 46);
			this.lblErrors.Name = "lblErrors";
			this.lblErrors.Size = new Size(39, 13);
			this.lblErrors.TabIndex = 5;
			this.lblErrors.Text = "errors";
			this.label3.AutoSize = true;
			this.label3.Location = new Point(2, 45);
			this.label3.Name = "label3";
			this.label3.Size = new Size(46, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "Errors:";
			this.lblWarnings.AutoSize = true;
			this.lblWarnings.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblWarnings.ForeColor = Color.FromArgb(120, 80, 16);
			this.lblWarnings.Location = new Point(63, 31);
			this.lblWarnings.Name = "lblWarnings";
			this.lblWarnings.Size = new Size(57, 13);
			this.lblWarnings.TabIndex = 3;
			this.lblWarnings.Text = "warnings";
			this.label2.AutoSize = true;
			this.label2.Location = new Point(2, 30);
			this.label2.Name = "label2";
			this.label2.Size = new Size(65, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Warnings:";
			this.lblDifficulty.AutoSize = true;
			this.lblDifficulty.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblDifficulty.ForeColor = Color.FromArgb(16, 112, 16);
			this.lblDifficulty.Location = new Point(63, 16);
			this.lblDifficulty.Name = "lblDifficulty";
			this.lblDifficulty.Size = new Size(55, 13);
			this.lblDifficulty.TabIndex = 1;
			this.lblDifficulty.Text = "difficulty";
			this.label1.AutoSize = true;
			this.label1.Location = new Point(2, 15);
			this.label1.Name = "label1";
			this.label1.Size = new Size(59, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Difficulty:";
			this.pnlGlass.BackColor = Color.FromArgb(128, 255, 255, 255);
			this.pnlGlass.Controls.Add(this.monoErrors);
			this.pnlGlass.Controls.Add(this.monochromeLabel4);
			this.pnlGlass.Controls.Add(this.monoWarnings);
			this.pnlGlass.Controls.Add(this.monochromeLabel3);
			this.pnlGlass.Controls.Add(this.monoDifficulty);
			this.pnlGlass.Controls.Add(this.monochromeLabel1);
			this.pnlGlass.Location = new Point(12, 0);
			this.pnlGlass.Name = "pnlGlass";
			this.pnlGlass.Size = new Size(135, 65);
			this.pnlGlass.TabIndex = 0;
			this.pnlGlass.Visible = false;
			this.monoErrors.AutoSize = true;
			this.monoErrors.BackColor = Color.Transparent;
			this.monoErrors.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.monoErrors.ForeColor = Color.FromArgb(136, 16, 16);
			this.monoErrors.Location = new Point(63, 41);
			this.monoErrors.Name = "monoErrors";
			this.monoErrors.Size = new Size(39, 13);
			this.monoErrors.TabIndex = 5;
			this.monoErrors.Text = "errors";
			this.monochromeLabel4.AutoSize = true;
			this.monochromeLabel4.BackColor = Color.Transparent;
			this.monochromeLabel4.Location = new Point(3, 40);
			this.monochromeLabel4.Name = "monochromeLabel4";
			this.monochromeLabel4.Size = new Size(46, 15);
			this.monochromeLabel4.TabIndex = 4;
			this.monochromeLabel4.Text = "Errors:";
			this.monoWarnings.AutoSize = true;
			this.monoWarnings.BackColor = Color.Transparent;
			this.monoWarnings.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.monoWarnings.ForeColor = Color.FromArgb(120, 80, 16);
			this.monoWarnings.Location = new Point(63, 26);
			this.monoWarnings.Name = "monoWarnings";
			this.monoWarnings.Size = new Size(57, 13);
			this.monoWarnings.TabIndex = 3;
			this.monoWarnings.Text = "warnings";
			this.monochromeLabel3.AutoSize = true;
			this.monochromeLabel3.BackColor = Color.Transparent;
			this.monochromeLabel3.Location = new Point(3, 25);
			this.monochromeLabel3.Name = "monochromeLabel3";
			this.monochromeLabel3.Size = new Size(65, 15);
			this.monochromeLabel3.TabIndex = 2;
			this.monochromeLabel3.Text = "Warnings:";
			this.monoDifficulty.AutoSize = true;
			this.monoDifficulty.BackColor = Color.Transparent;
			this.monoDifficulty.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.monoDifficulty.ForeColor = Color.FromArgb(16, 112, 16);
			this.monoDifficulty.Location = new Point(63, 11);
			this.monoDifficulty.Name = "monoDifficulty";
			this.monoDifficulty.Size = new Size(55, 13);
			this.monoDifficulty.TabIndex = 1;
			this.monoDifficulty.Text = "difficulty";
			this.monochromeLabel1.AutoSize = true;
			this.monochromeLabel1.BackColor = Color.Transparent;
			this.monochromeLabel1.Location = new Point(3, 10);
			this.monochromeLabel1.Name = "monochromeLabel1";
			this.monochromeLabel1.Size = new Size(59, 15);
			this.monochromeLabel1.TabIndex = 0;
			this.monochromeLabel1.Text = "Difficulty:";
			this.buttonRun.BackColor = Color.Transparent;
			this.buttonRun.Location = new Point(9, 29);
			this.buttonRun.Margin = new Padding(8);
			this.buttonRun.Name = "buttonRun";
			this.buttonRun.Size = new Size(91, 43);
			this.buttonRun.TabIndex = 3;
			this.buttonRun.Text = "Refresh";
			this.buttonRun.UseVisualStyleBackColor = false;
			this.buttonRun.Click += new EventHandler(this.buttonRun_Click);
			this.SeverityColumn.FillWeight = 25.29443f;
			this.SeverityColumn.HeaderText = "";
			this.SeverityColumn.MinimumWidth = 14;
			this.SeverityColumn.Name = "SeverityColumn";
			this.Information.FillWeight = 251.94f;
			this.Information.HeaderText = "Information";
			this.Information.Name = "Information";
			this.Information.ReadOnly = true;
			this.Time.FillWeight = 78.6944f;
			this.Time.HeaderText = "Time";
			this.Time.Name = "Time";
			this.Time.ReadOnly = true;
			this.Time.SortMode = DataGridViewColumnSortMode.Automatic;
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			base.ClientSize = new Size(424, 446);
			base.Controls.Add(this.dataGridView1);
			base.Controls.Add(this.pnlTop);
			base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			this.MinimumSize = new Size(440, 320);
			base.Name = "AiModWindow";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "AiMod";
			base.Load += new EventHandler(this.AiModWindow_Load);
			base.KeyPress += new KeyPressEventHandler(this.AiModWindow_KeyPress);
			((ISupportInitialize)this.dataGridView1).EndInit();
			this.pnlTop.ResumeLayout(false);
			this.pnlTop.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.grpRight.ResumeLayout(false);
			this.grpRight.PerformLayout();
			this.pnlGlass.ResumeLayout(false);
			this.pnlGlass.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x060026D9 RID: 9945
		// RVA: 0x000EBCEC File Offset: 0x000E9EEC
		private Class304 method_10(HitObjectBase hitObjectBase_0)
		{
			AiModWindow.Class632 class = new AiModWindow.Class632();
			class.hitObjectBase_0 = hitObjectBase_0;
			return this.editor_0.class297_0.list_3.Find(new Predicate<Class304>(class.method_0));
		}

		// Token: 0x060026DD RID: 9949
		// RVA: 0x000EBFBC File Offset: 0x000EA1BC
		private void method_11()
		{
			if (this.dictionary_0.Count == 0)
			{
				return;
			}
			List<AiReport> arg_37_0 = this.dictionary_0[AiModType.All];
			if (AiModWindow.predicate_1 == null)
			{
				AiModWindow.predicate_1 = new Predicate<AiReport>(AiModWindow.smethod_5);
			}
			int count = arg_37_0.FindAll(AiModWindow.predicate_1).Count;
			List<AiReport> arg_6B_0 = this.dictionary_0[AiModType.All];
			if (AiModWindow.predicate_2 == null)
			{
				AiModWindow.predicate_2 = new Predicate<AiReport>(AiModWindow.smethod_6);
			}
			int count2 = arg_6B_0.FindAll(AiModWindow.predicate_2).Count;
			this.monoDifficulty.Text = this.beatmapDifficulty_0.ToString();
			this.monoWarnings.Text = count2.ToString();
			this.monoErrors.Text = count.ToString();
			this.lblDifficulty.Text = this.beatmapDifficulty_0.ToString();
			this.lblWarnings.Text = count2.ToString();
			this.lblErrors.Text = count.ToString();
			this.monoWarnings.ForeColor = ((count2 > 0) ? this.color_1 : Color.Black);
			this.monoErrors.ForeColor = ((count > 0) ? this.color_2 : Color.Black);
			this.lblWarnings.ForeColor = ((count2 > 0) ? this.color_1 : Color.Black);
			this.lblErrors.ForeColor = ((count > 0) ? this.color_2 : Color.Black);
		}

		// Token: 0x060026DE RID: 9950
		// RVA: 0x000EC130 File Offset: 0x000EA330
		private void method_12(object sender, EventArgs12 e)
		{
			if (base.PointToClient(e.point_0).Y < this.pnlTop.Height && e.enum52_0 == Enum52.const_3)
			{
				e.enum52_0 = Enum52.const_4;
			}
		}

		// Token: 0x060026DF RID: 9951
		// RVA: 0x000EC170 File Offset: 0x000EA370
		private void method_13()
		{
			if (!this.bool_2)
			{
				this.int_0 = this.buttonRun.Left;
				this.int_1 = this.buttonRun.Bottom - this.pnlGlass.Bottom;
				this.pnlGlass.Visible = true;
				this.grpRight.Visible = false;
				this.pnlTop.BackColor = Color.Transparent;
				this.panel2.BackColor = Color.Black;
				base.FormBorderStyle = FormBorderStyle.Sizable;
				this.buttonRun.Top -= this.int_1;
				this.buttonRun.Left -= this.int_0;
				this.pnlTop.Height -= this.int_1;
				this.panel2.Top -= this.int_1;
			}
			Class601.smethod_2(this, new Struct48(0, 0, this.pnlTop.Height, 0));
			this.bool_2 = true;
		}

		// Token: 0x060026E0 RID: 9952
		// RVA: 0x000EC278 File Offset: 0x000EA478
		private void method_14()
		{
			if (this.bool_2)
			{
				this.grpRight.Visible = true;
				this.pnlGlass.Visible = false;
				this.pnlTop.BackColor = Color.FromKnownColor(KnownColor.Control);
				this.panel2.BackColor = Control.DefaultBackColor;
				base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
				this.buttonRun.Top += this.int_1;
				this.buttonRun.Left += this.int_0;
				this.pnlTop.Height += this.int_1;
				this.panel2.Top += this.int_1;
			}
			Class601.smethod_2(this, new Struct48(0, 0, 0, 0));
			this.bool_2 = false;
		}

		// Token: 0x060026E1 RID: 9953
		// RVA: 0x0001E185 File Offset: 0x0001C385
		private void method_15(object sender, EventArgs e)
		{
			if (Class601.smethod_0())
			{
				this.method_13();
				return;
			}
			this.method_14();
		}

		// Token: 0x060026E7 RID: 9959
		// RVA: 0x0001E1ED File Offset: 0x0001C3ED
		[CompilerGenerated]
		private void method_16()
		{
			this.editor_0.aiModWindow_0 = null;
		}

		// Token: 0x060026D6 RID: 9942
		// RVA: 0x000EB928 File Offset: 0x000E9B28
		private void method_9(List<AiReport> list_1)
		{
			this.bool_4 = true;
			DataGridViewRow[] array = new DataGridViewRow[list_1.Count];
			this.dataGridView1.Rows.Clear();
			int num = 0;
			foreach (AiReport current in list_1)
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)this.dataGridView1.RowTemplate.Clone();
				DataGridViewImageCell dataGridViewImageCell = new DataGridViewImageCell();
				switch (current.Severity)
				{
				case Severity.Info:
					dataGridViewImageCell.Value = Resources.aimod_info;
					break;
				case Severity.Warning:
					dataGridViewImageCell.Value = Resources.aimod_warning;
					break;
				case Severity.Error:
					dataGridViewImageCell.Value = Resources.aimod_error;
					break;
				}
				dataGridViewRow.Cells.Add(dataGridViewImageCell);
				dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell());
				dataGridViewRow.Cells.Add(new DataGridViewLinkCell());
				dataGridViewRow.Cells[2].Value = ((current.Time != -1) ? string.Format("{0:00}:{1:00}:{2:000}", current.Time / 60000, current.Time % 60000 / 1000, Math.Max(0, current.Time) % 1000) : string.Empty);
				dataGridViewRow.Cells[1].Value = current.Information;
				dataGridViewRow.Tag = current;
				array[num++] = dataGridViewRow;
			}
			this.dataGridView1.Rows.AddRange(array);
			this.dataGridView1.ClearSelection();
			this.bool_4 = false;
		}

		// Token: 0x060026D5 RID: 9941
		// RVA: 0x0001E15E File Offset: 0x0001C35E
		protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);
		}

		// Token: 0x060026D3 RID: 9939
		// RVA: 0x0001E114 File Offset: 0x0001C314
		protected override void OnClosing(CancelEventArgs e)
		{
			Class115.class47_0.Add(new VoidDelegate(this.method_16), false);
			e.Cancel = !this.bool_3;
			this.class356_0.Dispose();
			base.Hide();
			base.OnClosing(e);
		}

		// Token: 0x060026D4 RID: 9940
		// RVA: 0x0001E154 File Offset: 0x0001C354
		internal void Reset()
		{
			this.buttonRun_Click(null, null);
		}

		// Token: 0x060026DC RID: 9948
		// RVA: 0x0001E154 File Offset: 0x0001C354
		internal void Run()
		{
			this.buttonRun_Click(null, null);
		}

		// Token: 0x060026E4 RID: 9956
		// RVA: 0x000EC348 File Offset: 0x000EA548
		internal static bool smethod_3(int int_2, bool bool_6)
		{
			int num = Editor.editor_0.class375_0.method_7((double)int_2, 16, (double)int_2);
			int num2 = Editor.editor_0.class375_0.method_7((double)int_2, 12, (double)int_2);
			bool flag;
			if (bool_6)
			{
				flag = (Math.Abs(num - int_2) <= 1 || Math.Abs(num2 - int_2) <= 1);
			}
			else
			{
				flag = (Math.Abs(num - int_2) < 1 || Math.Abs(num2 - int_2) < 1);
			}
			return !flag;
		}

		// Token: 0x060026E8 RID: 9960
		// RVA: 0x0001E1FB File Offset: 0x0001C3FB
		[CompilerGenerated]
		private static bool smethod_4(AiModRuleset aiModRuleset_0)
		{
			return aiModRuleset_0.Type == AiModType.Meta;
		}

		// Token: 0x060026E9 RID: 9961
		// RVA: 0x0001E206 File Offset: 0x0001C406
		[CompilerGenerated]
		private static bool smethod_5(AiReport aiReport_1)
		{
			return aiReport_1.Severity == Severity.Error;
		}

		// Token: 0x060026EA RID: 9962
		// RVA: 0x0001E211 File Offset: 0x0001C411
		[CompilerGenerated]
		private static bool smethod_6(AiReport aiReport_1)
		{
			return aiReport_1.Severity == Severity.Warning;
		}

		// Token: 0x060026DB RID: 9947
		// RVA: 0x0001E167 File Offset: 0x0001C367
		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_9(this.dictionary_0[(AiModType)this.tabControl1.SelectedIndex]);
		}
	}
}
