using ns11;
using ns14;
using ns23;
using ns24;
using ns26;
using ns29;
using ns59;
using ns68;
using ns8;
using osu.Audio;
using osu.GameModes.Edit;
using osu.GameplayElements.HitObjects;
using osu.Properties;
using osu_common;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns10
{
	// Token: 0x0200066A RID: 1642
	internal sealed class TimingEntry : Form2
	{
		// Token: 0x0200066B RID: 1643
		[CompilerGenerated]
		private sealed class Class871
		{
			// Token: 0x04002FC7 RID: 12231
			public bool bool_0;

			// Token: 0x04002FC8 RID: 12232
			public int int_0;

			// Token: 0x04002FC9 RID: 12233
			public TimingEntry timingEntry_0;

			// Token: 0x06003362 RID: 13154
			// RVA: 0x0015F314 File Offset: 0x0015D514
			public void method_0()
			{
				if (this.timingEntry_0.chkAdjustBookmarkAndPreview.Checked)
				{
					if (this.bool_0)
					{
						this.timingEntry_0.editor_0.method_16(false);
					}
					int num = (int)(this.timingEntry_0.list_0[0].double_1 - Class331.smethod_14()[0].double_1);
					this.int_0 = 0;
					while (this.int_0 < this.timingEntry_0.editor_0.class297_0.list_1.Count)
					{
						List<int> list_;
						int index;
						(list_ = this.timingEntry_0.editor_0.class297_0.list_1)[index = this.int_0] = list_[index] + num;
						this.int_0++;
					}
					Class466.Current.int_14 += num;
					this.bool_0 = (num > 0);
					if (this.bool_0)
					{
						this.timingEntry_0.editor_0.bool_5 = true;
					}
				}
				Class331.smethod_15(this.timingEntry_0.list_0);
				int num2 = 0;
				switch (this.timingEntry_0.udBeatSnap.SelectedIndex)
				{
				case 0:
					num2 = 1;
					break;
				case 1:
					num2 = 2;
					break;
				case 2:
					num2 = 3;
					break;
				case 3:
					num2 = 4;
					break;
				case 4:
					num2 = 5;
					break;
				case 5:
					num2 = 6;
					break;
				case 6:
					num2 = 12;
					break;
				case 7:
					num2 = 24;
					break;
				}
				if (this.timingEntry_0.chkScaleObjects.Checked)
				{
					this.timingEntry_0.editor_0.class375_0.bool_3 = true;
					this.timingEntry_0.editor_0.class375_0.bool_4 = true;
				}
				else if (this.timingEntry_0.chkSnapObjects.Checked)
				{
					this.timingEntry_0.editor_0.class375_0.method_0(false, new int?(num2));
				}
				if (this.timingEntry_0.chkResnapSliders.Checked)
				{
					int int_ = this.timingEntry_0.editor_0.int_6;
					this.timingEntry_0.editor_0.int_6 = num2;
					this.timingEntry_0.editor_0.class297_0.vmethod_8(false, true);
					Class331.smethod_6(true);
					this.timingEntry_0.editor_0.class297_0.method_11(false, true);
					this.timingEntry_0.editor_0.int_6 = int_;
				}
				this.timingEntry_0.editor_0.class375_0.method_33();
				this.timingEntry_0.editor_0.class375_0.bool_6 = true;
				this.timingEntry_0.editor_0.bool_5 = true;
				Class331.smethod_6(true);
			}
		}

		// Token: 0x04002FBC RID: 12220
		private ToolStripMenuItem addControlPointToolStripMenuItem;

		// Token: 0x04002F57 RID: 12119
		private bool bool_1;

		// Token: 0x04002F58 RID: 12120
		private bool bool_2;

		// Token: 0x04002F59 RID: 12121
		private bool bool_3;

		// Token: 0x04002F5B RID: 12123
		private bool bool_4;

		// Token: 0x04002F8F RID: 12175
		private Button btnBulkMove;

		// Token: 0x04002F5E RID: 12126
		private Button btnCancel;

		// Token: 0x04002F83 RID: 12163
		private Button btnGameplayUseCurrent;

		// Token: 0x04002F79 RID: 12153
		private Button btnTimingUseCurrent;

		// Token: 0x04002FA1 RID: 12193
		private Button button1;

		// Token: 0x04002FA0 RID: 12192
		private Button button2;

		// Token: 0x04002F9F RID: 12191
		private Button button3;

		// Token: 0x04002F9E RID: 12190
		private Button button4;

		// Token: 0x04002F5D RID: 12125
		private Button buttonOk;

		// Token: 0x04002FBE RID: 12222
		private CheckBox chkAdjustBookmarkAndPreview;

		// Token: 0x04002F6B RID: 12139
		private CheckBox chkInherit;

		// Token: 0x04002FAC RID: 12204
		private CheckBox chkKiai;

		// Token: 0x04002FC5 RID: 12229
		private CheckBox chkOmitBarline;

		// Token: 0x04002FAD RID: 12205
		private CheckBox chkResnapSliders;

		// Token: 0x04002FAF RID: 12207
		private CheckBox chkScaleObjects;

		// Token: 0x04002FAE RID: 12206
		private CheckBox chkSnapObjects;

		// Token: 0x04002F54 RID: 12116
		private Class340 class340_0;

		// Token: 0x04002F55 RID: 12117
		private Class340 class340_1;

		// Token: 0x04002F56 RID: 12118
		private Class340 class340_2;

		// Token: 0x04002F71 RID: 12145
		private ColumnHeader columnHeader_0;

		// Token: 0x04002F72 RID: 12146
		private ColumnHeader columnHeader_1;

		// Token: 0x04002F73 RID: 12147
		private ColumnHeader columnHeader_2;

		// Token: 0x04002F74 RID: 12148
		private ColumnHeader columnHeader_3;

		// Token: 0x04002F75 RID: 12149
		private ColumnHeader columnHeader_4;

		// Token: 0x04002F8B RID: 12171
		private ColumnHeader columnHeader_5;

		// Token: 0x04002FB5 RID: 12213
		private ContextMenuStrip contextMenuStrip1;

		// Token: 0x04002FB7 RID: 12215
		private ToolStripMenuItem copyToolStripMenuItem;

		// Token: 0x04002FB6 RID: 12214
		private ToolStripMenuItem cutToolStripMenuItem;

		// Token: 0x04002F49 RID: 12105
		private const decimal decimal_0 = 0.5m;

		// Token: 0x04002F4A RID: 12106
		private const decimal decimal_1 = 2.0m;

		// Token: 0x04002F4B RID: 12107
		private const decimal decimal_2 = 0.1m;

		// Token: 0x04002F4C RID: 12108
		private const decimal decimal_3 = 4.0m;

		// Token: 0x04002F4D RID: 12109
		private const decimal decimal_4 = 0.1m;

		// Token: 0x04002F4E RID: 12110
		private const decimal decimal_5 = 10.0m;

		// Token: 0x04002FB9 RID: 12217
		private ToolStripMenuItem deleteToolStripMenuItem;

		// Token: 0x04002F4F RID: 12111
		private readonly Editor editor_0;

		// Token: 0x04002F50 RID: 12112
		private readonly Enum58 enum58_0;

		// Token: 0x04002F97 RID: 12183
		private GroupBox grpBulkDifficulty;

		// Token: 0x04002F8D RID: 12173
		private GroupBox grpBulkGeneral;

		// Token: 0x04002F91 RID: 12177
		private GroupBox grpBulkTimeSignature;

		// Token: 0x04002F81 RID: 12161
		private GroupBox grpDifficulty;

		// Token: 0x04002FAA RID: 12202
		private GroupBox grpEffects;

		// Token: 0x04002F82 RID: 12162
		private GroupBox grpGameplayGeneral;

		// Token: 0x04002F9D RID: 12189
		private GroupBox grpSampleset;

		// Token: 0x04002F77 RID: 12151
		private GroupBox grpTimingGeneral;

		// Token: 0x04002F6A RID: 12138
		private GroupBox grpTimingScale;

		// Token: 0x04002F78 RID: 12152
		private GroupBox grpTimingSignature;

		// Token: 0x04002FA4 RID: 12196
		private GroupBox grpVolume;

		// Token: 0x04002F5C RID: 12124
		private IContainer icontainer_0;

		// Token: 0x04002F76 RID: 12150
		private ImageList imageList_0;

		// Token: 0x04002F5A RID: 12122
		private int int_0 = -1;

		// Token: 0x04002FC2 RID: 12226
		private Label labelOmitBarline;

		// Token: 0x04002FB1 RID: 12209
		private Label lblBeatSnap;

		// Token: 0x04002F7B RID: 12155
		private Label lblBpm;

		// Token: 0x04002F92 RID: 12178
		private Label lblBulkCustomSignature;

		// Token: 0x04002F90 RID: 12176
		private Label lblBulkMove;

		// Token: 0x04002F7C RID: 12156
		private Label lblCustomSignature;

		// Token: 0x04002F84 RID: 12164
		private Label lblGameplayOffset;

		// Token: 0x04002FAB RID: 12203
		private Label lblKiai;

		// Token: 0x04002F8A RID: 12170
		private Label lblSliderMultiplier;

		// Token: 0x04002F7A RID: 12154
		private Label lblTimingOffset;

		// Token: 0x04002FA5 RID: 12197
		private Label lblVolume;

		// Token: 0x04002FA8 RID: 12200
		private LinkLabel linkLabel1;

		// Token: 0x04002FA9 RID: 12201
		private ListBox listSampleset;

		// Token: 0x04002F70 RID: 12144
		private Class617 listTimingPoints;

		// Token: 0x04002F51 RID: 12113
		private List<Class340> list_0;

		// Token: 0x04002F52 RID: 12114
		private List<Class340> list_1;

		// Token: 0x04002F53 RID: 12115
		private List<Class340> list_2;

		// Token: 0x04002FC3 RID: 12227
		private NumericUpDown nudCustom;

		// Token: 0x04002FBF RID: 12223
		private Panel panel1;

		// Token: 0x04002FC0 RID: 12224
		private Panel panel2;

		// Token: 0x04002FC1 RID: 12225
		private Panel panel3;

		// Token: 0x04002FB8 RID: 12216
		private ToolStripMenuItem pasteToolStripMenuItem;

		// Token: 0x04002F67 RID: 12135
		private Panel pnlTimingPoints;

		// Token: 0x04002F6C RID: 12140
		private Panel pnlToolStrip;

		// Token: 0x04002FC6 RID: 12230
		[CompilerGenerated]
		private static Predicate<Class340> predicate_0;

		// Token: 0x04002F94 RID: 12180
		private RadioButton radBulkCustomSignature;

		// Token: 0x04002F9B RID: 12187
		private RadioButton radBulkSlider100;

		// Token: 0x04002F9A RID: 12186
		private RadioButton radBulkSlider150;

		// Token: 0x04002F9C RID: 12188
		private RadioButton radBulkSlider75;

		// Token: 0x04002F99 RID: 12185
		private RadioButton radBulkSliderCustom;

		// Token: 0x04002F95 RID: 12181
		private RadioButton radBulkTimingQuad;

		// Token: 0x04002F96 RID: 12182
		private RadioButton radBulkTimingTriple;

		// Token: 0x04002F7E RID: 12158
		private RadioButton radCustomSignature;

		// Token: 0x04002FA2 RID: 12194
		private RadioButton radSamplesetCustom1;

		// Token: 0x04002FC4 RID: 12228
		private RadioButton radSamplesetCustom2;

		// Token: 0x04002FA3 RID: 12195
		private RadioButton radSamplesetDefault;

		// Token: 0x04002F88 RID: 12168
		private RadioButton radSlider100;

		// Token: 0x04002F87 RID: 12167
		private RadioButton radSlider150;

		// Token: 0x04002F89 RID: 12169
		private RadioButton radSlider75;

		// Token: 0x04002F86 RID: 12166
		private RadioButton radSliderCustom;

		// Token: 0x04002F7F RID: 12159
		private RadioButton radTimingQuad;

		// Token: 0x04002F80 RID: 12160
		private RadioButton radTimingTriple;

		// Token: 0x04002FBB RID: 12219
		private ToolStripMenuItem selectAllToolStripMenuItem;

		// Token: 0x04002F66 RID: 12134
		private TabPage tabAll;

		// Token: 0x04002F63 RID: 12131
		private TabPage tabAudio;

		// Token: 0x04002F8C RID: 12172
		private TabPage tabBulk;

		// Token: 0x04002F62 RID: 12130
		private TabPage tabGameplay;

		// Token: 0x04002F69 RID: 12137
		private TabPage tabGreens;

		// Token: 0x04002F68 RID: 12136
		private TabPage tabReds;

		// Token: 0x04002F60 RID: 12128
		private TabControl tabsLeft;

		// Token: 0x04002F65 RID: 12133
		private TabControl tabsRight;

		// Token: 0x04002F64 RID: 12132
		private TabPage tabStyle;

		// Token: 0x04002F61 RID: 12129
		private TabPage tabTiming;

		// Token: 0x04002FA7 RID: 12199
		private TrackBar tbVolume;

		// Token: 0x04002F6E RID: 12142
		private ToolStripButton toolAdd;

		// Token: 0x04002F6F RID: 12143
		private ToolStripButton toolRemove;

		// Token: 0x04002F6D RID: 12141
		private ToolStrip toolStrip1;

		// Token: 0x04002FBA RID: 12218
		private ToolStripSeparator toolStripMenuItem1;

		// Token: 0x04002FBD RID: 12221
		private ToolStripSeparator toolStripMenuItem2;

		// Token: 0x04002F5F RID: 12127
		private ToolTip toolTip_0;

		// Token: 0x04002FB0 RID: 12208
		private DomainUpDown udBeatSnap;

		// Token: 0x04002FB3 RID: 12211
		private NumericUpDown udBpm;

		// Token: 0x04002F93 RID: 12179
		private NumericUpDown udBulkMetronome;

		// Token: 0x04002F8E RID: 12174
		private NumericUpDown udBulkMove;

		// Token: 0x04002F98 RID: 12184
		private NumericUpDown udBulkSliderMultiplier;

		// Token: 0x04002FB4 RID: 12212
		private NumericUpDown udGameplayOffset;

		// Token: 0x04002F7D RID: 12157
		private NumericUpDown udMetronome;

		// Token: 0x04002F85 RID: 12165
		private NumericUpDown udSliderMultiplier;

		// Token: 0x04002FB2 RID: 12210
		private NumericUpDown udTimingOffset;

		// Token: 0x04002FA6 RID: 12198
		private NumericUpDown udVolume;

		// Token: 0x06003302 RID: 13058
		// RVA: 0x00157D0C File Offset: 0x00155F0C
		internal TimingEntry(Editor editor_1, Enum58 enum58_1, bool bool_5, bool bool_6)
		{
			this.editor_0 = editor_1;
			this.enum58_0 = enum58_1;
			this.InitializeComponent();
			this.imageList_0.ColorDepth = (Application.RenderWithVisualStyles ? ColorDepth.Depth32Bit : ColorDepth.Depth24Bit);
			this.imageList_0.Images.Clear();
			this.imageList_0.Images.Add(Resources.redbullet);
			this.imageList_0.Images.Add(Resources.greenbullet);
			if (Application.RenderWithVisualStyles)
			{
				foreach (TabPage tabPage in this.tabsLeft.TabPages)
				{
					tabPage.BackColor = SystemColors.ControlLightLight;
					foreach (Control control in tabPage.Controls)
					{
						TrackBar trackBar = control as TrackBar;
						if (trackBar != null)
						{
							trackBar.BackColor = SystemColors.ControlLightLight;
						}
					}
				}
			}
			Class601.smethod_6(this.listTimingPoints, "explorer");
			this.tabsLeft.TabPages.Remove(this.tabGameplay);
			this.tabsLeft.TabPages.Remove(this.tabBulk);
			this.tabsLeft.SelectedIndex = ((enum58_1 == Enum58.const_3) ? 1 : 0);
			this.list_0 = new List<Class340>();
			this.list_1 = new List<Class340>();
			foreach (Class340 current in Class331.smethod_14())
			{
				this.list_0.Add((Class340)current.Clone());
			}
			switch (editor_1.int_6)
			{
			case 1:
				this.udBeatSnap.SelectedIndex = 0;
				break;
			case 2:
				this.udBeatSnap.SelectedIndex = 1;
				break;
			case 3:
				this.udBeatSnap.SelectedIndex = 2;
				break;
			case 4:
				this.udBeatSnap.SelectedIndex = 3;
				break;
			case 6:
				this.udBeatSnap.SelectedIndex = 4;
				break;
			case 8:
				this.udBeatSnap.SelectedIndex = 5;
				break;
			}
			Form2.smethod_1(this.listTimingPoints);
			this.method_10(false);
			if (bool_6)
			{
				this.int_0 = (bool_5 ? Class331.int_2 : Class331.int_1);
				return;
			}
			this.int_0 = (bool_5 ? Class331.smethod_23((double)(Class331.int_7 + 50), true) : Class331.smethod_23((double)(Class331.int_7 + 50), false));
		}

		// Token: 0x0600334F RID: 13135
		// RVA: 0x00025E19 File Offset: 0x00024019
		private void addControlPointToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.toolAdd_Click(sender, EventArgs.Empty);
		}

		// Token: 0x06003332 RID: 13106
		// RVA: 0x0015A170 File Offset: 0x00158370
		private void btnBulkMove_Click(object sender, EventArgs e)
		{
			foreach (Class340 current in this.list_2)
			{
				current.double_1 += (double)((int)this.udBulkMove.Value);
			}
			this.udBulkMove.Value = 0m;
			this.method_12();
		}

		// Token: 0x06003313 RID: 13075
		// RVA: 0x00025B70 File Offset: 0x00023D70
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.bool_3 = false;
			base.Close();
		}

		// Token: 0x06003331 RID: 13105
		// RVA: 0x00025C7C File Offset: 0x00023E7C
		private void btnGameplayUseCurrent_Click(object sender, EventArgs e)
		{
			this.class340_0.double_1 = (double)Class331.int_7;
			this.udGameplayOffset.Value = (decimal)this.class340_0.double_1;
			this.method_12();
		}

		// Token: 0x0600332F RID: 13103
		// RVA: 0x00025C0F File Offset: 0x00023E0F
		private void btnTimingUseCurrent_Click(object sender, EventArgs e)
		{
			this.class340_0.double_1 = (double)((Class331.int_7 < 0) ? 0 : Class331.int_7);
			this.udTimingOffset.Value = (decimal)this.class340_0.double_1;
			this.method_12();
		}

		// Token: 0x06003335 RID: 13109
		// RVA: 0x00025CB1 File Offset: 0x00023EB1
		private void button1_Click(object sender, EventArgs e)
		{
			Class331.smethod_62(new Struct69(HitObjectSoundType.Normal, this.class340_0.sampleSet_0, this.class340_0.enum38_0, this.class340_0.int_0, SampleSet.None), 0f, false);
		}

		// Token: 0x06003336 RID: 13110
		// RVA: 0x00025CE6 File Offset: 0x00023EE6
		private void button2_Click(object sender, EventArgs e)
		{
			Class331.smethod_62(new Struct69(HitObjectSoundType.Whistle, this.class340_0.sampleSet_0, this.class340_0.enum38_0, this.class340_0.int_0, SampleSet.None), 0f, false);
		}

		// Token: 0x06003337 RID: 13111
		// RVA: 0x00025D1B File Offset: 0x00023F1B
		private void button3_Click(object sender, EventArgs e)
		{
			Class331.smethod_62(new Struct69(HitObjectSoundType.Finish, this.class340_0.sampleSet_0, this.class340_0.enum38_0, this.class340_0.int_0, SampleSet.None), 0f, false);
		}

		// Token: 0x06003338 RID: 13112
		// RVA: 0x00025D50 File Offset: 0x00023F50
		private void button4_Click(object sender, EventArgs e)
		{
			Class331.smethod_62(new Struct69(HitObjectSoundType.Clap, this.class340_0.sampleSet_0, this.class340_0.enum38_0, this.class340_0.int_0, SampleSet.None), 0f, false);
		}

		// Token: 0x06003312 RID: 13074
		// RVA: 0x00025B61 File Offset: 0x00023D61
		private void buttonOk_Click(object sender, EventArgs e)
		{
			this.bool_3 = true;
			base.Close();
		}

		// Token: 0x0600333A RID: 13114
		// RVA: 0x0015A31C File Offset: 0x0015851C
		private void chkInherit_CheckedChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			if (this.class340_0 == null)
			{
				return;
			}
			foreach (Class340 current in this.list_2)
			{
				if (this.chkInherit.Checked)
				{
					current.method_1(false);
					if (current.double_0 > 0.0)
					{
						current.double_0 = -100.0;
					}
				}
				else
				{
					current.double_0 = this.method_24(current);
					current.method_1(true);
				}
			}
			this.chkInherit.ThreeState = false;
			this.method_9();
			this.method_13(true);
		}

		// Token: 0x06003339 RID: 13113
		// RVA: 0x0015A28C File Offset: 0x0015848C
		private void chkKiai_CheckedChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			bool flag = true;
			foreach (Class340 current in this.list_2)
			{
				if (flag && this.method_26(current))
				{
					flag = false;
				}
				else
				{
					flag = false;
					current.method_3(this.chkKiai.Checked);
				}
			}
			this.chkKiai.ThreeState = false;
			this.method_9();
		}

		// Token: 0x06003354 RID: 13140
		// RVA: 0x0015AC98 File Offset: 0x00158E98
		private void chkOmitBarline_CheckedChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			foreach (Class340 current in this.list_2)
			{
				if (current.method_0())
				{
					if (this.chkOmitBarline.Checked)
					{
						current.enum39_0 |= Enum39.flag_2;
					}
					else
					{
						current.enum39_0 &= ~Enum39.flag_2;
					}
				}
			}
			this.chkOmitBarline.ThreeState = false;
			this.method_9();
		}

		// Token: 0x06003349 RID: 13129
		// RVA: 0x0015AC04 File Offset: 0x00158E04
		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{
			this.cutToolStripMenuItem.Enabled = (this.copyToolStripMenuItem.Enabled = (this.deleteToolStripMenuItem.Enabled = (this.list_2.Count > 0)));
			bool enabled = false;
			if (Clipboard.ContainsData(DataFormats.Text))
			{
				Class297.smethod_1(Class466.Current, (string)Clipboard.GetData(DataFormats.Text), ref enabled, true);
			}
			this.pasteToolStripMenuItem.Enabled = enabled;
			this.selectAllToolStripMenuItem.Enabled = (this.list_0.Count > 0);
		}

		// Token: 0x0600334B RID: 13131
		// RVA: 0x00025DF2 File Offset: 0x00023FF2
		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.method_28();
		}

		// Token: 0x0600334A RID: 13130
		// RVA: 0x00025DDE File Offset: 0x00023FDE
		private void cutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.method_28();
			this.toolRemove_Click(sender, EventArgs.Empty);
		}

		// Token: 0x0600334D RID: 13133
		// RVA: 0x00025E03 File Offset: 0x00024003
		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.toolRemove_Click(sender, EventArgs.Empty);
		}

		// Token: 0x06003356 RID: 13142
		// RVA: 0x00025E54 File Offset: 0x00024054
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06003357 RID: 13143
		// RVA: 0x0015AE8C File Offset: 0x0015908C
		private void InitializeComponent()
		{
			this.icontainer_0 = new Container();
			this.toolTip_0 = new ToolTip(this.icontainer_0);
			this.chkAdjustBookmarkAndPreview = new CheckBox();
			this.nudCustom = new NumericUpDown();
			this.buttonOk = new Button();
			this.btnCancel = new Button();
			this.tabsLeft = new TabControl();
			this.tabTiming = new TabPage();
			this.grpTimingSignature = new GroupBox();
			this.lblCustomSignature = new Label();
			this.udMetronome = new NumericUpDown();
			this.radCustomSignature = new RadioButton();
			this.radTimingQuad = new RadioButton();
			this.radTimingTriple = new RadioButton();
			this.grpTimingGeneral = new GroupBox();
			this.udTimingOffset = new NumericUpDown();
			this.udBpm = new NumericUpDown();
			this.btnTimingUseCurrent = new Button();
			this.lblTimingOffset = new Label();
			this.lblBpm = new Label();
			this.tabGameplay = new TabPage();
			this.grpDifficulty = new GroupBox();
			this.udSliderMultiplier = new NumericUpDown();
			this.radSliderCustom = new RadioButton();
			this.radSlider150 = new RadioButton();
			this.radSlider100 = new RadioButton();
			this.radSlider75 = new RadioButton();
			this.lblSliderMultiplier = new Label();
			this.grpGameplayGeneral = new GroupBox();
			this.udGameplayOffset = new NumericUpDown();
			this.btnGameplayUseCurrent = new Button();
			this.lblGameplayOffset = new Label();
			this.tabBulk = new TabPage();
			this.grpBulkDifficulty = new GroupBox();
			this.udBulkSliderMultiplier = new NumericUpDown();
			this.radBulkSliderCustom = new RadioButton();
			this.radBulkSlider150 = new RadioButton();
			this.radBulkSlider100 = new RadioButton();
			this.radBulkSlider75 = new RadioButton();
			this.grpBulkTimeSignature = new GroupBox();
			this.lblBulkCustomSignature = new Label();
			this.udBulkMetronome = new NumericUpDown();
			this.radBulkCustomSignature = new RadioButton();
			this.radBulkTimingQuad = new RadioButton();
			this.radBulkTimingTriple = new RadioButton();
			this.grpBulkGeneral = new GroupBox();
			this.udBulkMove = new NumericUpDown();
			this.btnBulkMove = new Button();
			this.lblBulkMove = new Label();
			this.tabAudio = new TabPage();
			this.grpVolume = new GroupBox();
			this.button4 = new Button();
			this.button3 = new Button();
			this.button2 = new Button();
			this.button1 = new Button();
			this.lblVolume = new Label();
			this.udVolume = new NumericUpDown();
			this.tbVolume = new TrackBar();
			this.grpSampleset = new GroupBox();
			this.panel2 = new Panel();
			this.listSampleset = new ListBox();
			this.linkLabel1 = new LinkLabel();
			this.radSamplesetCustom2 = new RadioButton();
			this.radSamplesetCustom1 = new RadioButton();
			this.radSamplesetDefault = new RadioButton();
			this.tabStyle = new TabPage();
			this.grpEffects = new GroupBox();
			this.panel3 = new Panel();
			this.labelOmitBarline = new Label();
			this.chkOmitBarline = new CheckBox();
			this.panel1 = new Panel();
			this.lblKiai = new Label();
			this.chkKiai = new CheckBox();
			this.tabsRight = new TabControl();
			this.tabAll = new TabPage();
			this.tabReds = new TabPage();
			this.tabGreens = new TabPage();
			this.pnlTimingPoints = new Panel();
			this.listTimingPoints = new Class617();
			this.columnHeader_0 = new ColumnHeader();
			this.columnHeader_1 = new ColumnHeader();
			this.columnHeader_2 = new ColumnHeader();
			this.columnHeader_3 = new ColumnHeader();
			this.columnHeader_4 = new ColumnHeader();
			this.columnHeader_5 = new ColumnHeader();
			this.contextMenuStrip1 = new ContextMenuStrip(this.icontainer_0);
			this.addControlPointToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripMenuItem2 = new ToolStripSeparator();
			this.cutToolStripMenuItem = new ToolStripMenuItem();
			this.copyToolStripMenuItem = new ToolStripMenuItem();
			this.pasteToolStripMenuItem = new ToolStripMenuItem();
			this.deleteToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripMenuItem1 = new ToolStripSeparator();
			this.selectAllToolStripMenuItem = new ToolStripMenuItem();
			this.imageList_0 = new ImageList(this.icontainer_0);
			this.grpTimingScale = new GroupBox();
			this.udBeatSnap = new DomainUpDown();
			this.lblBeatSnap = new Label();
			this.chkResnapSliders = new CheckBox();
			this.chkSnapObjects = new CheckBox();
			this.chkScaleObjects = new CheckBox();
			this.chkInherit = new CheckBox();
			this.pnlToolStrip = new Panel();
			this.toolStrip1 = new ToolStrip();
			this.toolAdd = new ToolStripButton();
			this.toolRemove = new ToolStripButton();
			((ISupportInitialize)this.nudCustom).BeginInit();
			this.tabsLeft.SuspendLayout();
			this.tabTiming.SuspendLayout();
			this.grpTimingSignature.SuspendLayout();
			((ISupportInitialize)this.udMetronome).BeginInit();
			this.grpTimingGeneral.SuspendLayout();
			((ISupportInitialize)this.udTimingOffset).BeginInit();
			((ISupportInitialize)this.udBpm).BeginInit();
			this.tabGameplay.SuspendLayout();
			this.grpDifficulty.SuspendLayout();
			((ISupportInitialize)this.udSliderMultiplier).BeginInit();
			this.grpGameplayGeneral.SuspendLayout();
			((ISupportInitialize)this.udGameplayOffset).BeginInit();
			this.tabBulk.SuspendLayout();
			this.grpBulkDifficulty.SuspendLayout();
			((ISupportInitialize)this.udBulkSliderMultiplier).BeginInit();
			this.grpBulkTimeSignature.SuspendLayout();
			((ISupportInitialize)this.udBulkMetronome).BeginInit();
			this.grpBulkGeneral.SuspendLayout();
			((ISupportInitialize)this.udBulkMove).BeginInit();
			this.tabAudio.SuspendLayout();
			this.grpVolume.SuspendLayout();
			((ISupportInitialize)this.udVolume).BeginInit();
			((ISupportInitialize)this.tbVolume).BeginInit();
			this.grpSampleset.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tabStyle.SuspendLayout();
			this.grpEffects.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabsRight.SuspendLayout();
			this.pnlTimingPoints.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.grpTimingScale.SuspendLayout();
			this.pnlToolStrip.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			base.SuspendLayout();
			this.toolTip_0.AutomaticDelay = 300;
			this.toolTip_0.AutoPopDelay = 10000;
			this.toolTip_0.InitialDelay = 300;
			this.toolTip_0.ReshowDelay = 60;
			this.chkAdjustBookmarkAndPreview.AutoSize = true;
			this.chkAdjustBookmarkAndPreview.FlatStyle = FlatStyle.System;
			this.chkAdjustBookmarkAndPreview.Location = new Point(191, 43);
			this.chkAdjustBookmarkAndPreview.Name = "chkAdjustBookmarkAndPreview";
			this.chkAdjustBookmarkAndPreview.Size = new Size(228, 20);
			this.chkAdjustBookmarkAndPreview.TabIndex = 5;
			this.chkAdjustBookmarkAndPreview.Text = "Adjust bookmarks and audio preview";
			this.toolTip_0.SetToolTip(this.chkAdjustBookmarkAndPreview, "Will be adjusted based on the offset change of the first control point only.");
			this.chkAdjustBookmarkAndPreview.UseVisualStyleBackColor = true;
			this.nudCustom.Location = new Point(133, 64);
			NumericUpDown arg_731_0 = this.nudCustom;
			int[] array = new int[4];
			array[0] = 2;
			arg_731_0.Minimum = new decimal(array);
			this.nudCustom.Name = "nudCustom";
			this.nudCustom.Size = new Size(54, 20);
			this.nudCustom.TabIndex = 6;
			this.toolTip_0.SetToolTip(this.nudCustom, "Custom sample set number");
			NumericUpDown arg_793_0 = this.nudCustom;
			int[] array2 = new int[4];
			array2[0] = 2;
			arg_793_0.Value = new decimal(array2);
			this.nudCustom.ValueChanged += new EventHandler(this.nudCustom_ValueChanged);
			this.buttonOk.DialogResult = DialogResult.OK;
			this.buttonOk.FlatStyle = FlatStyle.System;
			this.buttonOk.Location = new Point(4, 383);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new Size(397, 35);
			this.buttonOk.TabIndex = 2;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new EventHandler(this.buttonOk_Click);
			this.btnCancel.DialogResult = DialogResult.OK;
			this.btnCancel.FlatStyle = FlatStyle.System;
			this.btnCancel.Location = new Point(407, 383);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new Size(171, 35);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
			this.tabsLeft.Controls.Add(this.tabTiming);
			this.tabsLeft.Controls.Add(this.tabGameplay);
			this.tabsLeft.Controls.Add(this.tabBulk);
			this.tabsLeft.Controls.Add(this.tabAudio);
			this.tabsLeft.Controls.Add(this.tabStyle);
			this.tabsLeft.Location = new Point(4, 4);
			this.tabsLeft.Name = "tabsLeft";
			this.tabsLeft.SelectedIndex = 0;
			this.tabsLeft.Size = new Size(238, 297);
			this.tabsLeft.TabIndex = 10;
			this.tabTiming.Controls.Add(this.grpTimingSignature);
			this.tabTiming.Controls.Add(this.grpTimingGeneral);
			this.tabTiming.Location = new Point(4, 22);
			this.tabTiming.Name = "tabTiming";
			this.tabTiming.Padding = new Padding(3);
			this.tabTiming.Size = new Size(230, 271);
			this.tabTiming.TabIndex = 0;
			this.tabTiming.Text = "Timing";
			this.grpTimingSignature.Controls.Add(this.lblCustomSignature);
			this.grpTimingSignature.Controls.Add(this.udMetronome);
			this.grpTimingSignature.Controls.Add(this.radCustomSignature);
			this.grpTimingSignature.Controls.Add(this.radTimingQuad);
			this.grpTimingSignature.Controls.Add(this.radTimingTriple);
			this.grpTimingSignature.Location = new Point(6, 141);
			this.grpTimingSignature.Name = "grpTimingSignature";
			this.grpTimingSignature.Size = new Size(218, 124);
			this.grpTimingSignature.TabIndex = 1;
			this.grpTimingSignature.TabStop = false;
			this.grpTimingSignature.Text = "Time Signature (metronome)";
			this.lblCustomSignature.AutoSize = true;
			this.lblCustomSignature.Location = new Point(123, 75);
			this.lblCustomSignature.Name = "lblCustomSignature";
			this.lblCustomSignature.Size = new Size(21, 15);
			this.lblCustomSignature.TabIndex = 4;
			this.lblCustomSignature.Text = "/ 4";
			this.udMetronome.Location = new Point(73, 73);
			NumericUpDown arg_B93_0 = this.udMetronome;
			int[] array3 = new int[4];
			array3[0] = 8;
			arg_B93_0.Maximum = new decimal(array3);
			NumericUpDown arg_BAF_0 = this.udMetronome;
			int[] array4 = new int[4];
			array4[0] = 5;
			arg_BAF_0.Minimum = new decimal(array4);
			this.udMetronome.Name = "udMetronome";
			this.udMetronome.Size = new Size(44, 20);
			this.udMetronome.TabIndex = 3;
			NumericUpDown arg_BFE_0 = this.udMetronome;
			int[] array5 = new int[4];
			array5[0] = 5;
			arg_BFE_0.Value = new decimal(array5);
			this.udMetronome.ValueChanged += new EventHandler(this.udMetronome_ValueChanged);
			this.radCustomSignature.AutoSize = true;
			this.radCustomSignature.FlatStyle = FlatStyle.System;
			this.radCustomSignature.Location = new Point(9, 73);
			this.radCustomSignature.Name = "radCustomSignature";
			this.radCustomSignature.Size = new Size(64, 20);
			this.radCustomSignature.TabIndex = 2;
			this.radCustomSignature.TabStop = true;
			this.radCustomSignature.Text = "Other:";
			this.radCustomSignature.UseVisualStyleBackColor = true;
			this.radCustomSignature.CheckedChanged += new EventHandler(this.radCustomSignature_CheckedChanged);
			this.radTimingQuad.AutoSize = true;
			this.radTimingQuad.FlatStyle = FlatStyle.System;
			this.radTimingQuad.Location = new Point(9, 52);
			this.radTimingQuad.Name = "radTimingQuad";
			this.radTimingQuad.Size = new Size(114, 20);
			this.radTimingQuad.TabIndex = 1;
			this.radTimingQuad.TabStop = true;
			this.radTimingQuad.Text = "4 / 4 (common)";
			this.radTimingQuad.UseVisualStyleBackColor = true;
			this.radTimingQuad.CheckedChanged += new EventHandler(this.radTimingQuad_CheckedChanged);
			this.radTimingTriple.AutoSize = true;
			this.radTimingTriple.FlatStyle = FlatStyle.System;
			this.radTimingTriple.Location = new Point(9, 31);
			this.radTimingTriple.Name = "radTimingTriple";
			this.radTimingTriple.Size = new Size(92, 20);
			this.radTimingTriple.TabIndex = 0;
			this.radTimingTriple.TabStop = true;
			this.radTimingTriple.Text = "3 / 4 (waltz)";
			this.radTimingTriple.UseVisualStyleBackColor = true;
			this.radTimingTriple.CheckedChanged += new EventHandler(this.radTimingTriple_CheckedChanged);
			this.grpTimingGeneral.Controls.Add(this.udTimingOffset);
			this.grpTimingGeneral.Controls.Add(this.udBpm);
			this.grpTimingGeneral.Controls.Add(this.btnTimingUseCurrent);
			this.grpTimingGeneral.Controls.Add(this.lblTimingOffset);
			this.grpTimingGeneral.Controls.Add(this.lblBpm);
			this.grpTimingGeneral.Location = new Point(6, 6);
			this.grpTimingGeneral.Name = "grpTimingGeneral";
			this.grpTimingGeneral.Size = new Size(218, 129);
			this.grpTimingGeneral.TabIndex = 0;
			this.grpTimingGeneral.TabStop = false;
			this.grpTimingGeneral.Text = "General";
			this.udTimingOffset.Location = new Point(65, 47);
			NumericUpDown arg_EEF_0 = this.udTimingOffset;
			int[] array6 = new int[4];
			array6[0] = 100000000;
			arg_EEF_0.Maximum = new decimal(array6);
			this.udTimingOffset.Minimum = new decimal(new int[]
			{
				100000000,
				0,
				0,
				-2147483648
			});
			this.udTimingOffset.Name = "udTimingOffset";
			this.udTimingOffset.Size = new Size(147, 20);
			this.udTimingOffset.TabIndex = 6;
			this.udTimingOffset.ValueChanged += new EventHandler(this.udTimingOffset_ValueChanged);
			this.udBpm.DecimalPlaces = 3;
			this.udBpm.Location = new Point(65, 17);
			NumericUpDown arg_FA8_0 = this.udBpm;
			int[] array7 = new int[4];
			array7[0] = 10000;
			arg_FA8_0.Maximum = new decimal(array7);
			NumericUpDown arg_FC8_0 = this.udBpm;
			int[] array8 = new int[4];
			array8[0] = 15;
			arg_FC8_0.Minimum = new decimal(array8);
			this.udBpm.Name = "udBpm";
			this.udBpm.Size = new Size(147, 20);
			this.udBpm.TabIndex = 5;
			NumericUpDown arg_101B_0 = this.udBpm;
			int[] array9 = new int[4];
			array9[0] = 15;
			arg_101B_0.Value = new decimal(array9);
			this.udBpm.ValueChanged += new EventHandler(this.udBpm_ValueChanged);
			this.btnTimingUseCurrent.FlatStyle = FlatStyle.System;
			this.btnTimingUseCurrent.Location = new Point(6, 81);
			this.btnTimingUseCurrent.Name = "btnTimingUseCurrent";
			this.btnTimingUseCurrent.Size = new Size(206, 42);
			this.btnTimingUseCurrent.TabIndex = 4;
			this.btnTimingUseCurrent.Text = "Use Current Time";
			this.btnTimingUseCurrent.UseVisualStyleBackColor = true;
			this.btnTimingUseCurrent.Click += new EventHandler(this.btnTimingUseCurrent_Click);
			this.lblTimingOffset.AutoSize = true;
			this.lblTimingOffset.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.lblTimingOffset.Location = new Point(6, 49);
			this.lblTimingOffset.Name = "lblTimingOffset";
			this.lblTimingOffset.Size = new Size(43, 15);
			this.lblTimingOffset.TabIndex = 1;
			this.lblTimingOffset.Text = "Offset";
			this.lblBpm.AutoSize = true;
			this.lblBpm.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.lblBpm.Location = new Point(6, 19);
			this.lblBpm.Name = "lblBpm";
			this.lblBpm.Size = new Size(33, 15);
			this.lblBpm.TabIndex = 0;
			this.lblBpm.Text = "BPM";
			this.tabGameplay.Controls.Add(this.grpDifficulty);
			this.tabGameplay.Controls.Add(this.grpGameplayGeneral);
			this.tabGameplay.Location = new Point(4, 22);
			this.tabGameplay.Name = "tabGameplay";
			this.tabGameplay.Padding = new Padding(3);
			this.tabGameplay.Size = new Size(230, 271);
			this.tabGameplay.TabIndex = 1;
			this.tabGameplay.Text = "Timing";
			this.grpDifficulty.Controls.Add(this.udSliderMultiplier);
			this.grpDifficulty.Controls.Add(this.radSliderCustom);
			this.grpDifficulty.Controls.Add(this.radSlider150);
			this.grpDifficulty.Controls.Add(this.radSlider100);
			this.grpDifficulty.Controls.Add(this.radSlider75);
			this.grpDifficulty.Controls.Add(this.lblSliderMultiplier);
			this.grpDifficulty.Location = new Point(6, 141);
			this.grpDifficulty.Name = "grpDifficulty";
			this.grpDifficulty.Size = new Size(218, 124);
			this.grpDifficulty.TabIndex = 3;
			this.grpDifficulty.TabStop = false;
			this.grpDifficulty.Text = "Difficulty";
			this.udSliderMultiplier.DecimalPlaces = 2;
			this.udSliderMultiplier.Increment = new decimal(new int[]
			{
				1,
				0,
				0,
				65536
			});
			this.udSliderMultiplier.Location = new Point(91, 62);
			NumericUpDown arg_1391_0 = this.udSliderMultiplier;
			int[] array10 = new int[4];
			array10[0] = 2;
			arg_1391_0.Maximum = new decimal(array10);
			this.udSliderMultiplier.Minimum = new decimal(new int[]
			{
				5,
				0,
				0,
				65536
			});
			this.udSliderMultiplier.Name = "udSliderMultiplier";
			this.udSliderMultiplier.Size = new Size(61, 20);
			this.udSliderMultiplier.TabIndex = 5;
			NumericUpDown arg_1408_0 = this.udSliderMultiplier;
			int[] array11 = new int[4];
			array11[0] = 1;
			arg_1408_0.Value = new decimal(array11);
			this.udSliderMultiplier.ValueChanged += new EventHandler(this.udSliderMultiplier_ValueChanged);
			this.radSliderCustom.AutoSize = true;
			this.radSliderCustom.FlatStyle = FlatStyle.System;
			this.radSliderCustom.Location = new Point(9, 63);
			this.radSliderCustom.Name = "radSliderCustom";
			this.radSliderCustom.Size = new Size(76, 20);
			this.radSliderCustom.TabIndex = 4;
			this.radSliderCustom.TabStop = true;
			this.radSliderCustom.Text = "Custom:";
			this.radSliderCustom.UseVisualStyleBackColor = true;
			this.radSliderCustom.CheckedChanged += new EventHandler(this.radSliderCustom_CheckedChanged);
			this.radSlider150.AutoSize = true;
			this.radSlider150.FlatStyle = FlatStyle.System;
			this.radSlider150.Location = new Point(135, 37);
			this.radSlider150.Name = "radSlider150";
			this.radSlider150.Size = new Size(51, 20);
			this.radSlider150.TabIndex = 3;
			this.radSlider150.TabStop = true;
			this.radSlider150.Text = "1.5x";
			this.radSlider150.UseVisualStyleBackColor = true;
			this.radSlider150.CheckedChanged += new EventHandler(this.radSlider150_CheckedChanged);
			this.radSlider100.AutoSize = true;
			this.radSlider100.FlatStyle = FlatStyle.System;
			this.radSlider100.Location = new Point(72, 37);
			this.radSlider100.Name = "radSlider100";
			this.radSlider100.Size = new Size(51, 20);
			this.radSlider100.TabIndex = 2;
			this.radSlider100.TabStop = true;
			this.radSlider100.Text = "1.0x";
			this.radSlider100.UseVisualStyleBackColor = true;
			this.radSlider100.CheckedChanged += new EventHandler(this.radSlider100_CheckedChanged);
			this.radSlider75.AutoSize = true;
			this.radSlider75.FlatStyle = FlatStyle.System;
			this.radSlider75.Location = new Point(9, 37);
			this.radSlider75.Name = "radSlider75";
			this.radSlider75.Size = new Size(57, 20);
			this.radSlider75.TabIndex = 1;
			this.radSlider75.TabStop = true;
			this.radSlider75.Text = "0.75x";
			this.radSlider75.UseVisualStyleBackColor = true;
			this.radSlider75.CheckedChanged += new EventHandler(this.radSlider75_CheckedChanged);
			this.lblSliderMultiplier.AutoSize = true;
			this.lblSliderMultiplier.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.lblSliderMultiplier.Location = new Point(6, 19);
			this.lblSliderMultiplier.Name = "lblSliderMultiplier";
			this.lblSliderMultiplier.Size = new Size(146, 15);
			this.lblSliderMultiplier.TabIndex = 0;
			this.lblSliderMultiplier.Text = "Slider velocity multiplier:";
			this.grpGameplayGeneral.Controls.Add(this.udGameplayOffset);
			this.grpGameplayGeneral.Controls.Add(this.btnGameplayUseCurrent);
			this.grpGameplayGeneral.Controls.Add(this.lblGameplayOffset);
			this.grpGameplayGeneral.Location = new Point(6, 6);
			this.grpGameplayGeneral.Name = "grpGameplayGeneral";
			this.grpGameplayGeneral.Size = new Size(218, 129);
			this.grpGameplayGeneral.TabIndex = 2;
			this.grpGameplayGeneral.TabStop = false;
			this.grpGameplayGeneral.Text = "General";
			this.udGameplayOffset.Location = new Point(65, 34);
			NumericUpDown arg_17E8_0 = this.udGameplayOffset;
			int[] array12 = new int[4];
			array12[0] = 100000000;
			arg_17E8_0.Maximum = new decimal(array12);
			this.udGameplayOffset.Minimum = new decimal(new int[]
			{
				100,
				0,
				0,
				-2147483648
			});
			this.udGameplayOffset.Name = "udGameplayOffset";
			this.udGameplayOffset.Size = new Size(147, 20);
			this.udGameplayOffset.TabIndex = 7;
			this.udGameplayOffset.ValueChanged += new EventHandler(this.udGameplayOffset_ValueChanged);
			this.btnGameplayUseCurrent.FlatStyle = FlatStyle.System;
			this.btnGameplayUseCurrent.Location = new Point(6, 81);
			this.btnGameplayUseCurrent.Name = "btnGameplayUseCurrent";
			this.btnGameplayUseCurrent.Size = new Size(206, 42);
			this.btnGameplayUseCurrent.TabIndex = 4;
			this.btnGameplayUseCurrent.Text = "Use Current Time";
			this.btnGameplayUseCurrent.UseVisualStyleBackColor = true;
			this.btnGameplayUseCurrent.Click += new EventHandler(this.btnGameplayUseCurrent_Click);
			this.lblGameplayOffset.AutoSize = true;
			this.lblGameplayOffset.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.lblGameplayOffset.Location = new Point(6, 36);
			this.lblGameplayOffset.Name = "lblGameplayOffset";
			this.lblGameplayOffset.Size = new Size(43, 15);
			this.lblGameplayOffset.TabIndex = 1;
			this.lblGameplayOffset.Text = "Offset";
			this.tabBulk.Controls.Add(this.grpBulkDifficulty);
			this.tabBulk.Controls.Add(this.grpBulkTimeSignature);
			this.tabBulk.Controls.Add(this.grpBulkGeneral);
			this.tabBulk.Location = new Point(4, 22);
			this.tabBulk.Name = "tabBulk";
			this.tabBulk.Size = new Size(230, 271);
			this.tabBulk.TabIndex = 4;
			this.tabBulk.Text = "Timing";
			this.grpBulkDifficulty.Controls.Add(this.udBulkSliderMultiplier);
			this.grpBulkDifficulty.Controls.Add(this.radBulkSliderCustom);
			this.grpBulkDifficulty.Controls.Add(this.radBulkSlider150);
			this.grpBulkDifficulty.Controls.Add(this.radBulkSlider100);
			this.grpBulkDifficulty.Controls.Add(this.radBulkSlider75);
			this.grpBulkDifficulty.Location = new Point(6, 186);
			this.grpBulkDifficulty.Name = "grpBulkDifficulty";
			this.grpBulkDifficulty.Size = new Size(218, 77);
			this.grpBulkDifficulty.TabIndex = 4;
			this.grpBulkDifficulty.TabStop = false;
			this.grpBulkDifficulty.Text = "Slider velocity multiplier";
			this.udBulkSliderMultiplier.DecimalPlaces = 2;
			this.udBulkSliderMultiplier.Increment = new decimal(new int[]
			{
				1,
				0,
				0,
				65536
			});
			this.udBulkSliderMultiplier.Location = new Point(91, 47);
			NumericUpDown arg_1B2F_0 = this.udBulkSliderMultiplier;
			int[] array13 = new int[4];
			array13[0] = 2;
			arg_1B2F_0.Maximum = new decimal(array13);
			this.udBulkSliderMultiplier.Minimum = new decimal(new int[]
			{
				5,
				0,
				0,
				65536
			});
			this.udBulkSliderMultiplier.Name = "udBulkSliderMultiplier";
			this.udBulkSliderMultiplier.Size = new Size(61, 20);
			this.udBulkSliderMultiplier.TabIndex = 5;
			NumericUpDown arg_1BA6_0 = this.udBulkSliderMultiplier;
			int[] array14 = new int[4];
			array14[0] = 1;
			arg_1BA6_0.Value = new decimal(array14);
			this.udBulkSliderMultiplier.ValueChanged += new EventHandler(this.udBulkSliderMultiplier_ValueChanged);
			this.radBulkSliderCustom.AutoSize = true;
			this.radBulkSliderCustom.FlatStyle = FlatStyle.System;
			this.radBulkSliderCustom.Location = new Point(9, 48);
			this.radBulkSliderCustom.Name = "radBulkSliderCustom";
			this.radBulkSliderCustom.Size = new Size(76, 20);
			this.radBulkSliderCustom.TabIndex = 4;
			this.radBulkSliderCustom.TabStop = true;
			this.radBulkSliderCustom.Text = "Custom:";
			this.radBulkSliderCustom.UseVisualStyleBackColor = true;
			this.radBulkSliderCustom.CheckedChanged += new EventHandler(this.radBulkSliderCustom_CheckedChanged);
			this.radBulkSlider150.AutoSize = true;
			this.radBulkSlider150.FlatStyle = FlatStyle.System;
			this.radBulkSlider150.Location = new Point(135, 22);
			this.radBulkSlider150.Name = "radBulkSlider150";
			this.radBulkSlider150.Size = new Size(51, 20);
			this.radBulkSlider150.TabIndex = 3;
			this.radBulkSlider150.TabStop = true;
			this.radBulkSlider150.Text = "1.5x";
			this.radBulkSlider150.UseVisualStyleBackColor = true;
			this.radBulkSlider150.CheckedChanged += new EventHandler(this.radBulkSlider150_CheckedChanged);
			this.radBulkSlider100.AutoSize = true;
			this.radBulkSlider100.FlatStyle = FlatStyle.System;
			this.radBulkSlider100.Location = new Point(72, 22);
			this.radBulkSlider100.Name = "radBulkSlider100";
			this.radBulkSlider100.Size = new Size(51, 20);
			this.radBulkSlider100.TabIndex = 2;
			this.radBulkSlider100.TabStop = true;
			this.radBulkSlider100.Text = "1.0x";
			this.radBulkSlider100.UseVisualStyleBackColor = true;
			this.radBulkSlider100.CheckedChanged += new EventHandler(this.radBulkSlider100_CheckedChanged);
			this.radBulkSlider75.AutoSize = true;
			this.radBulkSlider75.FlatStyle = FlatStyle.System;
			this.radBulkSlider75.Location = new Point(9, 22);
			this.radBulkSlider75.Name = "radBulkSlider75";
			this.radBulkSlider75.Size = new Size(57, 20);
			this.radBulkSlider75.TabIndex = 1;
			this.radBulkSlider75.TabStop = true;
			this.radBulkSlider75.Text = "0.75x";
			this.radBulkSlider75.UseVisualStyleBackColor = true;
			this.radBulkSlider75.CheckedChanged += new EventHandler(this.radBulkSlider75_CheckedChanged);
			this.grpBulkTimeSignature.Controls.Add(this.lblBulkCustomSignature);
			this.grpBulkTimeSignature.Controls.Add(this.udBulkMetronome);
			this.grpBulkTimeSignature.Controls.Add(this.radBulkCustomSignature);
			this.grpBulkTimeSignature.Controls.Add(this.radBulkTimingQuad);
			this.grpBulkTimeSignature.Controls.Add(this.radBulkTimingTriple);
			this.grpBulkTimeSignature.Location = new Point(6, 83);
			this.grpBulkTimeSignature.Name = "grpBulkTimeSignature";
			this.grpBulkTimeSignature.Size = new Size(218, 97);
			this.grpBulkTimeSignature.TabIndex = 2;
			this.grpBulkTimeSignature.TabStop = false;
			this.grpBulkTimeSignature.Text = "Time Signature (metronome)";
			this.lblBulkCustomSignature.AutoSize = true;
			this.lblBulkCustomSignature.Location = new Point(123, 66);
			this.lblBulkCustomSignature.Name = "lblBulkCustomSignature";
			this.lblBulkCustomSignature.Size = new Size(21, 15);
			this.lblBulkCustomSignature.TabIndex = 4;
			this.lblBulkCustomSignature.Text = "/ 4";
			this.udBulkMetronome.Location = new Point(73, 64);
			NumericUpDown arg_1F8F_0 = this.udBulkMetronome;
			int[] array15 = new int[4];
			array15[0] = 7;
			arg_1F8F_0.Maximum = new decimal(array15);
			NumericUpDown arg_1FAE_0 = this.udBulkMetronome;
			int[] array16 = new int[4];
			array16[0] = 5;
			arg_1FAE_0.Minimum = new decimal(array16);
			this.udBulkMetronome.Name = "udBulkMetronome";
			this.udBulkMetronome.Size = new Size(44, 20);
			this.udBulkMetronome.TabIndex = 3;
			NumericUpDown arg_1FFD_0 = this.udBulkMetronome;
			int[] array17 = new int[4];
			array17[0] = 5;
			arg_1FFD_0.Value = new decimal(array17);
			this.udBulkMetronome.ValueChanged += new EventHandler(this.udBulkMetronome_ValueChanged);
			this.radBulkCustomSignature.AutoSize = true;
			this.radBulkCustomSignature.FlatStyle = FlatStyle.System;
			this.radBulkCustomSignature.Location = new Point(9, 64);
			this.radBulkCustomSignature.Name = "radBulkCustomSignature";
			this.radBulkCustomSignature.Size = new Size(64, 20);
			this.radBulkCustomSignature.TabIndex = 2;
			this.radBulkCustomSignature.TabStop = true;
			this.radBulkCustomSignature.Text = "Other:";
			this.radBulkCustomSignature.UseVisualStyleBackColor = true;
			this.radBulkCustomSignature.CheckedChanged += new EventHandler(this.radBulkCustomSignature_CheckedChanged);
			this.radBulkTimingQuad.AutoSize = true;
			this.radBulkTimingQuad.FlatStyle = FlatStyle.System;
			this.radBulkTimingQuad.Location = new Point(9, 43);
			this.radBulkTimingQuad.Name = "radBulkTimingQuad";
			this.radBulkTimingQuad.Size = new Size(114, 20);
			this.radBulkTimingQuad.TabIndex = 1;
			this.radBulkTimingQuad.TabStop = true;
			this.radBulkTimingQuad.Text = "4 / 4 (common)";
			this.radBulkTimingQuad.UseVisualStyleBackColor = true;
			this.radBulkTimingQuad.CheckedChanged += new EventHandler(this.radBulkTimingQuad_CheckedChanged);
			this.radBulkTimingTriple.AutoSize = true;
			this.radBulkTimingTriple.FlatStyle = FlatStyle.System;
			this.radBulkTimingTriple.Location = new Point(9, 22);
			this.radBulkTimingTriple.Name = "radBulkTimingTriple";
			this.radBulkTimingTriple.Size = new Size(92, 20);
			this.radBulkTimingTriple.TabIndex = 0;
			this.radBulkTimingTriple.TabStop = true;
			this.radBulkTimingTriple.Text = "3 / 4 (waltz)";
			this.radBulkTimingTriple.UseVisualStyleBackColor = true;
			this.radBulkTimingTriple.CheckedChanged += new EventHandler(this.radBulkTimingTriple_CheckedChanged);
			this.grpBulkGeneral.Controls.Add(this.udBulkMove);
			this.grpBulkGeneral.Controls.Add(this.btnBulkMove);
			this.grpBulkGeneral.Controls.Add(this.lblBulkMove);
			this.grpBulkGeneral.Location = new Point(6, 6);
			this.grpBulkGeneral.Name = "grpBulkGeneral";
			this.grpBulkGeneral.Size = new Size(218, 71);
			this.grpBulkGeneral.TabIndex = 0;
			this.grpBulkGeneral.TabStop = false;
			this.grpBulkGeneral.Text = "General";
			this.udBulkMove.Location = new Point(9, 39);
			NumericUpDown arg_22BF_0 = this.udBulkMove;
			int[] array18 = new int[4];
			array18[0] = 300000;
			arg_22BF_0.Maximum = new decimal(array18);
			this.udBulkMove.Minimum = new decimal(new int[]
			{
				300000,
				0,
				0,
				-2147483648
			});
			this.udBulkMove.Name = "udBulkMove";
			this.udBulkMove.Size = new Size(120, 20);
			this.udBulkMove.TabIndex = 3;
			this.udBulkMove.Enter += new EventHandler(this.udBulkMove_Enter);
			this.udBulkMove.Leave += new EventHandler(this.udBulkMove_Leave);
			this.btnBulkMove.FlatStyle = FlatStyle.System;
			this.btnBulkMove.Location = new Point(137, 37);
			this.btnBulkMove.Name = "btnBulkMove";
			this.btnBulkMove.Size = new Size(75, 23);
			this.btnBulkMove.TabIndex = 2;
			this.btnBulkMove.Text = "Move";
			this.btnBulkMove.UseVisualStyleBackColor = true;
			this.btnBulkMove.Click += new EventHandler(this.btnBulkMove_Click);
			this.lblBulkMove.AutoSize = true;
			this.lblBulkMove.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.lblBulkMove.Location = new Point(6, 19);
			this.lblBulkMove.Name = "lblBulkMove";
			this.lblBulkMove.Size = new Size(150, 15);
			this.lblBulkMove.TabIndex = 0;
			this.lblBulkMove.Text = "Move selected offsets by:";
			this.tabAudio.Controls.Add(this.grpVolume);
			this.tabAudio.Controls.Add(this.grpSampleset);
			this.tabAudio.Location = new Point(4, 22);
			this.tabAudio.Name = "tabAudio";
			this.tabAudio.Size = new Size(230, 271);
			this.tabAudio.TabIndex = 2;
			this.tabAudio.Text = "Audio";
			this.grpVolume.Controls.Add(this.button4);
			this.grpVolume.Controls.Add(this.button3);
			this.grpVolume.Controls.Add(this.button2);
			this.grpVolume.Controls.Add(this.button1);
			this.grpVolume.Controls.Add(this.lblVolume);
			this.grpVolume.Controls.Add(this.udVolume);
			this.grpVolume.Controls.Add(this.tbVolume);
			this.grpVolume.Location = new Point(6, 143);
			this.grpVolume.Name = "grpVolume";
			this.grpVolume.Size = new Size(218, 123);
			this.grpVolume.TabIndex = 4;
			this.grpVolume.TabStop = false;
			this.grpVolume.Text = "Volume";
			this.button4.FlatStyle = FlatStyle.System;
			this.button4.Location = new Point(114, 89);
			this.button4.Name = "button4";
			this.button4.Size = new Size(96, 25);
			this.button4.TabIndex = 7;
			this.button4.Text = "Clap";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new EventHandler(this.button4_Click);
			this.button3.FlatStyle = FlatStyle.System;
			this.button3.Location = new Point(114, 58);
			this.button3.Name = "button3";
			this.button3.Size = new Size(96, 25);
			this.button3.TabIndex = 6;
			this.button3.Text = "Finish";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new EventHandler(this.button3_Click);
			this.button2.FlatStyle = FlatStyle.System;
			this.button2.Location = new Point(9, 89);
			this.button2.Name = "button2";
			this.button2.Size = new Size(96, 25);
			this.button2.TabIndex = 5;
			this.button2.Text = "Whistle";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new EventHandler(this.button2_Click);
			this.button1.FlatStyle = FlatStyle.System;
			this.button1.Location = new Point(9, 58);
			this.button1.Name = "button1";
			this.button1.Size = new Size(96, 25);
			this.button1.TabIndex = 4;
			this.button1.Text = "Hit";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.lblVolume.AutoSize = true;
			this.lblVolume.Location = new Point(199, 27);
			this.lblVolume.Name = "lblVolume";
			this.lblVolume.Size = new Size(17, 15);
			this.lblVolume.TabIndex = 2;
			this.lblVolume.Text = "%";
			this.udVolume.Location = new Point(156, 23);
			this.udVolume.Name = "udVolume";
			this.udVolume.Size = new Size(43, 20);
			this.udVolume.TabIndex = 1;
			this.udVolume.ValueChanged += new EventHandler(this.udVolume_ValueChanged);
			this.tbVolume.LargeChange = 10;
			this.tbVolume.Location = new Point(2, 20);
			this.tbVolume.Maximum = 100;
			this.tbVolume.Minimum = 5;
			this.tbVolume.Name = "tbVolume";
			this.tbVolume.Size = new Size(147, 45);
			this.tbVolume.TabIndex = 0;
			this.tbVolume.TickFrequency = 5;
			this.tbVolume.Value = 5;
			this.tbVolume.ValueChanged += new EventHandler(this.tbVolume_ValueChanged);
			this.grpSampleset.Controls.Add(this.nudCustom);
			this.grpSampleset.Controls.Add(this.panel2);
			this.grpSampleset.Controls.Add(this.linkLabel1);
			this.grpSampleset.Controls.Add(this.radSamplesetCustom2);
			this.grpSampleset.Controls.Add(this.radSamplesetCustom1);
			this.grpSampleset.Controls.Add(this.radSamplesetDefault);
			this.grpSampleset.Location = new Point(6, 6);
			this.grpSampleset.Name = "grpSampleset";
			this.grpSampleset.Size = new Size(218, 117);
			this.grpSampleset.TabIndex = 3;
			this.grpSampleset.TabStop = false;
			this.grpSampleset.Text = "Sampleset";
			this.panel2.Controls.Add(this.listSampleset);
			this.panel2.Location = new Point(8, 22);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(103, 62);
			this.panel2.TabIndex = 5;
			this.listSampleset.Dock = DockStyle.Fill;
			this.listSampleset.FormattingEnabled = true;
			this.listSampleset.Items.AddRange(new object[]
			{
				"Normal",
				"Soft",
				"Drum"
			});
			this.listSampleset.Location = new Point(0, 0);
			this.listSampleset.Name = "listSampleset";
			this.listSampleset.Size = new Size(103, 62);
			this.listSampleset.TabIndex = 3;
			this.listSampleset.SelectedIndexChanged += new EventHandler(this.listSampleset_SelectedIndexChanged);
			this.linkLabel1.ActiveLinkColor = SystemColors.Highlight;
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.LinkColor = SystemColors.HotTrack;
			this.linkLabel1.Location = new Point(6, 93);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new Size(204, 15);
			this.linkLabel1.TabIndex = 4;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "How to add custom sample overrides";
			this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			this.radSamplesetCustom2.AutoSize = true;
			this.radSamplesetCustom2.FlatStyle = FlatStyle.System;
			this.radSamplesetCustom2.Location = new Point(117, 64);
			this.radSamplesetCustom2.Name = "radSamplesetCustom2";
			this.radSamplesetCustom2.Size = new Size(34, 20);
			this.radSamplesetCustom2.TabIndex = 2;
			this.radSamplesetCustom2.TabStop = true;
			this.radSamplesetCustom2.Text = " ";
			this.radSamplesetCustom2.UseVisualStyleBackColor = true;
			this.radSamplesetCustom2.CheckedChanged += new EventHandler(this.radSamplesetCustom2_CheckedChanged);
			this.radSamplesetCustom1.AutoSize = true;
			this.radSamplesetCustom1.FlatStyle = FlatStyle.System;
			this.radSamplesetCustom1.Location = new Point(117, 43);
			this.radSamplesetCustom1.Name = "radSamplesetCustom1";
			this.radSamplesetCustom1.Size = new Size(82, 20);
			this.radSamplesetCustom1.TabIndex = 1;
			this.radSamplesetCustom1.TabStop = true;
			this.radSamplesetCustom1.Text = "Custom 1";
			this.radSamplesetCustom1.UseVisualStyleBackColor = true;
			this.radSamplesetCustom1.CheckedChanged += new EventHandler(this.radSamplesetCustom1_CheckedChanged);
			this.radSamplesetDefault.AutoSize = true;
			this.radSamplesetDefault.FlatStyle = FlatStyle.System;
			this.radSamplesetDefault.Location = new Point(117, 22);
			this.radSamplesetDefault.Name = "radSamplesetDefault";
			this.radSamplesetDefault.Size = new Size(69, 20);
			this.radSamplesetDefault.TabIndex = 0;
			this.radSamplesetDefault.TabStop = true;
			this.radSamplesetDefault.Text = "Default";
			this.radSamplesetDefault.UseVisualStyleBackColor = true;
			this.radSamplesetDefault.CheckedChanged += new EventHandler(this.radSamplesetDefault_CheckedChanged);
			this.tabStyle.Controls.Add(this.grpEffects);
			this.tabStyle.Location = new Point(4, 22);
			this.tabStyle.Name = "tabStyle";
			this.tabStyle.Size = new Size(230, 271);
			this.tabStyle.TabIndex = 3;
			this.tabStyle.Text = "Style";
			this.grpEffects.Controls.Add(this.panel3);
			this.grpEffects.Controls.Add(this.chkOmitBarline);
			this.grpEffects.Controls.Add(this.panel1);
			this.grpEffects.Controls.Add(this.chkKiai);
			this.grpEffects.Location = new Point(6, 6);
			this.grpEffects.Name = "grpEffects";
			this.grpEffects.Size = new Size(218, 222);
			this.grpEffects.TabIndex = 0;
			this.grpEffects.TabStop = false;
			this.grpEffects.Text = "Effects";
			this.panel3.Controls.Add(this.labelOmitBarline);
			this.panel3.Location = new Point(6, 162);
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size(206, 49);
			this.panel3.TabIndex = 4;
			this.labelOmitBarline.Dock = DockStyle.Fill;
			this.labelOmitBarline.FlatStyle = FlatStyle.System;
			this.labelOmitBarline.Location = new Point(0, 0);
			this.labelOmitBarline.Name = "labelOmitBarline";
			this.labelOmitBarline.Size = new Size(206, 49);
			this.labelOmitBarline.TabIndex = 0;
			this.labelOmitBarline.Text = "Use this to remove the first bar line from this section in Taiko mode.";
			this.chkOmitBarline.AutoSize = true;
			this.chkOmitBarline.FlatStyle = FlatStyle.System;
			this.chkOmitBarline.Location = new Point(9, 135);
			this.chkOmitBarline.Name = "chkOmitBarline";
			this.chkOmitBarline.Size = new Size(124, 20);
			this.chkOmitBarline.TabIndex = 3;
			this.chkOmitBarline.Text = "Omit first bar line";
			this.chkOmitBarline.UseVisualStyleBackColor = true;
			this.chkOmitBarline.CheckedChanged += new EventHandler(this.chkOmitBarline_CheckedChanged);
			this.panel1.Controls.Add(this.lblKiai);
			this.panel1.Location = new Point(6, 48);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(206, 83);
			this.panel1.TabIndex = 2;
			this.lblKiai.Dock = DockStyle.Fill;
			this.lblKiai.FlatStyle = FlatStyle.System;
			this.lblKiai.Location = new Point(0, 0);
			this.lblKiai.Name = "lblKiai";
			this.lblKiai.Size = new Size(206, 83);
			this.lblKiai.TabIndex = 1;
			this.lblKiai.Text = "Fountains, flying stars, flashing beats. This is what you could call the \"epic chorus\" mode in osu!. It will emphasize a particular part of a song. Please don't overuse it.";
			this.chkKiai.AutoSize = true;
			this.chkKiai.FlatStyle = FlatStyle.System;
			this.chkKiai.Location = new Point(9, 22);
			this.chkKiai.Name = "chkKiai";
			this.chkKiai.Size = new Size(85, 20);
			this.chkKiai.TabIndex = 0;
			this.chkKiai.Text = "Kiai Mode";
			this.chkKiai.UseVisualStyleBackColor = true;
			this.chkKiai.CheckedChanged += new EventHandler(this.chkKiai_CheckedChanged);
			this.tabsRight.Controls.Add(this.tabAll);
			this.tabsRight.Controls.Add(this.tabReds);
			this.tabsRight.Controls.Add(this.tabGreens);
			this.tabsRight.Location = new Point(248, 4);
			this.tabsRight.Name = "tabsRight";
			this.tabsRight.SelectedIndex = 0;
			this.tabsRight.Size = new Size(330, 272);
			this.tabsRight.TabIndex = 11;
			this.tabsRight.SelectedIndexChanged += new EventHandler(this.tabsRight_SelectedIndexChanged);
			this.tabAll.BackColor = Color.Transparent;
			this.tabAll.Location = new Point(4, 22);
			this.tabAll.Name = "tabAll";
			this.tabAll.Padding = new Padding(3);
			this.tabAll.Size = new Size(322, 246);
			this.tabAll.TabIndex = 0;
			this.tabAll.Text = "All";
			this.tabAll.UseVisualStyleBackColor = true;
			this.tabReds.BackColor = Color.Transparent;
			this.tabReds.Location = new Point(4, 22);
			this.tabReds.Name = "tabReds";
			this.tabReds.Padding = new Padding(3);
			this.tabReds.Size = new Size(322, 246);
			this.tabReds.TabIndex = 1;
			this.tabReds.Text = "Timing Points";
			this.tabReds.UseVisualStyleBackColor = true;
			this.tabGreens.BackColor = Color.Transparent;
			this.tabGreens.Location = new Point(4, 22);
			this.tabGreens.Name = "tabGreens";
			this.tabGreens.Size = new Size(322, 246);
			this.tabGreens.TabIndex = 2;
			this.tabGreens.Text = "Inherited Points";
			this.tabGreens.UseVisualStyleBackColor = true;
			this.pnlTimingPoints.BackColor = Color.Transparent;
			this.pnlTimingPoints.Controls.Add(this.listTimingPoints);
			this.pnlTimingPoints.Location = new Point(251, 28);
			this.pnlTimingPoints.Name = "pnlTimingPoints";
			this.pnlTimingPoints.Size = new Size(323, 245);
			this.pnlTimingPoints.TabIndex = 12;
			this.listTimingPoints.BorderStyle = BorderStyle.None;
			this.listTimingPoints.Columns.AddRange(new ColumnHeader[]
			{
				this.columnHeader_0,
				this.columnHeader_1,
				this.columnHeader_2,
				this.columnHeader_3,
				this.columnHeader_4,
				this.columnHeader_5
			});
			this.listTimingPoints.ContextMenuStrip = this.contextMenuStrip1;
			this.listTimingPoints.Dock = DockStyle.Fill;
			this.listTimingPoints.FullRowSelect = true;
			this.listTimingPoints.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			this.listTimingPoints.HideSelection = false;
			this.listTimingPoints.Location = new Point(0, 0);
			this.listTimingPoints.Name = "listTimingPoints";
			this.listTimingPoints.Size = new Size(323, 245);
			this.listTimingPoints.SmallImageList = this.imageList_0;
			this.listTimingPoints.TabIndex = 0;
			this.listTimingPoints.UseCompatibleStateImageBehavior = false;
			this.listTimingPoints.View = View.Details;
			this.listTimingPoints.ItemActivate += new EventHandler(this.listTimingPoints_ItemActivate);
			this.listTimingPoints.SelectedIndexChanged += new EventHandler(this.listTimingPoints_SelectedIndexChanged);
			this.listTimingPoints.Click += new EventHandler(this.listTimingPoints_Click);
			this.listTimingPoints.KeyDown += new KeyEventHandler(this.listTimingPoints_KeyDown);
			this.listTimingPoints.KeyUp += new KeyEventHandler(this.listTimingPoints_KeyUp);
			this.listTimingPoints.Leave += new EventHandler(this.listTimingPoints_Leave);
			this.listTimingPoints.MouseUp += new MouseEventHandler(this.listTimingPoints_MouseUp);
			this.columnHeader_0.Text = "Offset";
			this.columnHeader_0.TextAlign = HorizontalAlignment.Right;
			this.columnHeader_0.Width = 81;
			this.columnHeader_1.Text = "BPM";
			this.columnHeader_1.Width = 58;
			this.columnHeader_2.Text = "Meter";
			this.columnHeader_2.Width = 44;
			this.columnHeader_3.Text = "Sample";
			this.columnHeader_3.Width = 51;
			this.columnHeader_4.Text = "Vol.";
			this.columnHeader_4.Width = 45;
			this.columnHeader_5.Text = "Ki";
			this.columnHeader_5.Width = 25;
			this.contextMenuStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.addControlPointToolStripMenuItem,
				this.toolStripMenuItem2,
				this.cutToolStripMenuItem,
				this.copyToolStripMenuItem,
				this.pasteToolStripMenuItem,
				this.deleteToolStripMenuItem,
				this.toolStripMenuItem1,
				this.selectAllToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new Size(171, 148);
			this.contextMenuStrip1.Opening += new CancelEventHandler(this.contextMenuStrip1_Opening);
			this.addControlPointToolStripMenuItem.Name = "addControlPointToolStripMenuItem";
			this.addControlPointToolStripMenuItem.Size = new Size(170, 22);
			this.addControlPointToolStripMenuItem.Text = "A&dd Control Point";
			this.addControlPointToolStripMenuItem.Click += new EventHandler(this.addControlPointToolStripMenuItem_Click);
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new Size(167, 6);
			this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			this.cutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
			this.cutToolStripMenuItem.Size = new Size(170, 22);
			this.cutToolStripMenuItem.Text = "Cu&t";
			this.cutToolStripMenuItem.Click += new EventHandler(this.cutToolStripMenuItem_Click);
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
			this.copyToolStripMenuItem.Size = new Size(170, 22);
			this.copyToolStripMenuItem.Text = "&Copy";
			this.copyToolStripMenuItem.Click += new EventHandler(this.copyToolStripMenuItem_Click);
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+V";
			this.pasteToolStripMenuItem.Size = new Size(170, 22);
			this.pasteToolStripMenuItem.Text = "&Paste";
			this.pasteToolStripMenuItem.Click += new EventHandler(this.pasteToolStripMenuItem_Click);
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.ShortcutKeyDisplayString = "Del";
			this.deleteToolStripMenuItem.Size = new Size(170, 22);
			this.deleteToolStripMenuItem.Text = "De&lete";
			this.deleteToolStripMenuItem.Click += new EventHandler(this.deleteToolStripMenuItem_Click);
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new Size(167, 6);
			this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			this.selectAllToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
			this.selectAllToolStripMenuItem.Size = new Size(170, 22);
			this.selectAllToolStripMenuItem.Text = "Select &All";
			this.selectAllToolStripMenuItem.Click += new EventHandler(this.selectAllToolStripMenuItem_Click);
			this.imageList_0.ColorDepth = ColorDepth.Depth24Bit;
			this.imageList_0.ImageSize = new Size(16, 16);
			this.imageList_0.TransparentColor = Color.Transparent;
			this.grpTimingScale.Controls.Add(this.chkAdjustBookmarkAndPreview);
			this.grpTimingScale.Controls.Add(this.udBeatSnap);
			this.grpTimingScale.Controls.Add(this.lblBeatSnap);
			this.grpTimingScale.Controls.Add(this.chkResnapSliders);
			this.grpTimingScale.Controls.Add(this.chkSnapObjects);
			this.grpTimingScale.Controls.Add(this.chkScaleObjects);
			this.grpTimingScale.Location = new Point(4, 303);
			this.grpTimingScale.Name = "grpTimingScale";
			this.grpTimingScale.Size = new Size(574, 74);
			this.grpTimingScale.TabIndex = 12;
			this.grpTimingScale.TabStop = false;
			this.grpTimingScale.Text = "When applying timing changes...";
			this.udBeatSnap.Items.Add("1/1");
			this.udBeatSnap.Items.Add("1/2");
			this.udBeatSnap.Items.Add("1/3");
			this.udBeatSnap.Items.Add("1/4");
			this.udBeatSnap.Items.Add("1/6");
			this.udBeatSnap.Items.Add("1/8");
			this.udBeatSnap.Items.Add("1/12");
			this.udBeatSnap.Items.Add("1/24");
			this.udBeatSnap.Location = new Point(478, 22);
			this.udBeatSnap.Name = "udBeatSnap";
			this.udBeatSnap.Size = new Size(48, 20);
			this.udBeatSnap.TabIndex = 4;
			this.udBeatSnap.Text = "1/4";
			this.lblBeatSnap.AutoSize = true;
			this.lblBeatSnap.FlatStyle = FlatStyle.System;
			this.lblBeatSnap.Location = new Point(340, 24);
			this.lblBeatSnap.Name = "lblBeatSnap";
			this.lblBeatSnap.Size = new Size(132, 15);
			this.lblBeatSnap.TabIndex = 3;
			this.lblBeatSnap.Text = "Use beat snap divisor of";
			this.chkResnapSliders.AutoSize = true;
			this.chkResnapSliders.FlatStyle = FlatStyle.System;
			this.chkResnapSliders.Location = new Point(191, 22);
			this.chkResnapSliders.Name = "chkResnapSliders";
			this.chkResnapSliders.Size = new Size(143, 20);
			this.chkResnapSliders.TabIndex = 2;
			this.chkResnapSliders.Text = "Resnap slider lengths";
			this.chkResnapSliders.UseVisualStyleBackColor = true;
			this.chkSnapObjects.AutoSize = true;
			this.chkSnapObjects.FlatStyle = FlatStyle.System;
			this.chkSnapObjects.Location = new Point(8, 43);
			this.chkSnapObjects.Name = "chkSnapObjects";
			this.chkSnapObjects.Size = new Size(176, 20);
			this.chkSnapObjects.TabIndex = 1;
			this.chkSnapObjects.Text = "Snap objects to new timing";
			this.chkSnapObjects.UseVisualStyleBackColor = true;
			this.chkScaleObjects.AutoSize = true;
			this.chkScaleObjects.FlatStyle = FlatStyle.System;
			this.chkScaleObjects.Location = new Point(8, 22);
			this.chkScaleObjects.Name = "chkScaleObjects";
			this.chkScaleObjects.Size = new Size(177, 20);
			this.chkScaleObjects.TabIndex = 0;
			this.chkScaleObjects.Text = "Scale objects to new timing";
			this.chkScaleObjects.UseVisualStyleBackColor = true;
			this.chkInherit.AutoSize = true;
			this.chkInherit.FlatStyle = FlatStyle.System;
			this.chkInherit.Location = new Point(252, 282);
			this.chkInherit.Name = "chkInherit";
			this.chkInherit.Size = new Size(196, 20);
			this.chkInherit.TabIndex = 15;
			this.chkInherit.Text = "Inherit previous timing settings";
			this.chkInherit.UseVisualStyleBackColor = true;
			this.chkInherit.CheckedChanged += new EventHandler(this.chkInherit_CheckedChanged);
			this.pnlToolStrip.Controls.Add(this.toolStrip1);
			this.pnlToolStrip.Location = new Point(509, 278);
			this.pnlToolStrip.Name = "pnlToolStrip";
			this.pnlToolStrip.Size = new Size(64, 25);
			this.pnlToolStrip.TabIndex = 16;
			this.toolStrip1.BackColor = SystemColors.Control;
			this.toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.toolAdd,
				this.toolRemove
			});
			this.toolStrip1.Location = new Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new Padding(0);
			this.toolStrip1.RenderMode = ToolStripRenderMode.System;
			this.toolStrip1.Size = new Size(64, 27);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			this.toolAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolAdd.Image = Resources.add;
			this.toolAdd.ImageTransparentColor = Color.Magenta;
			this.toolAdd.Margin = new Padding(0, 1, 8, 2);
			this.toolAdd.Name = "toolAdd";
			this.toolAdd.Overflow = ToolStripItemOverflow.Never;
			this.toolAdd.Padding = new Padding(2);
			this.toolAdd.Size = new Size(24, 24);
			this.toolAdd.Text = "Add Timing Section";
			this.toolAdd.Click += new EventHandler(this.toolAdd_Click);
			this.toolRemove.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolRemove.Image = Resources.sub;
			this.toolRemove.ImageTransparentColor = Color.Magenta;
			this.toolRemove.Name = "toolRemove";
			this.toolRemove.Padding = new Padding(2);
			this.toolRemove.Size = new Size(24, 24);
			this.toolRemove.Text = "Remove Timing Section";
			this.toolRemove.Click += new EventHandler(this.toolRemove_Click);
			base.AcceptButton = this.buttonOk;
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			base.CancelButton = this.btnCancel;
			base.ClientSize = new Size(582, 422);
			base.Controls.Add(this.pnlTimingPoints);
			base.Controls.Add(this.chkInherit);
			base.Controls.Add(this.grpTimingScale);
			base.Controls.Add(this.pnlToolStrip);
			base.Controls.Add(this.tabsRight);
			base.Controls.Add(this.tabsLeft);
			base.Controls.Add(this.buttonOk);
			base.Controls.Add(this.btnCancel);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "TimingEntry";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Timing and Control Points";
			base.FormClosing += new FormClosingEventHandler(this.TimingEntry_FormClosing);
			base.Load += new EventHandler(this.TimingEntry_Load);
			((ISupportInitialize)this.nudCustom).EndInit();
			this.tabsLeft.ResumeLayout(false);
			this.tabTiming.ResumeLayout(false);
			this.grpTimingSignature.ResumeLayout(false);
			this.grpTimingSignature.PerformLayout();
			((ISupportInitialize)this.udMetronome).EndInit();
			this.grpTimingGeneral.ResumeLayout(false);
			this.grpTimingGeneral.PerformLayout();
			((ISupportInitialize)this.udTimingOffset).EndInit();
			((ISupportInitialize)this.udBpm).EndInit();
			this.tabGameplay.ResumeLayout(false);
			this.grpDifficulty.ResumeLayout(false);
			this.grpDifficulty.PerformLayout();
			((ISupportInitialize)this.udSliderMultiplier).EndInit();
			this.grpGameplayGeneral.ResumeLayout(false);
			this.grpGameplayGeneral.PerformLayout();
			((ISupportInitialize)this.udGameplayOffset).EndInit();
			this.tabBulk.ResumeLayout(false);
			this.grpBulkDifficulty.ResumeLayout(false);
			this.grpBulkDifficulty.PerformLayout();
			((ISupportInitialize)this.udBulkSliderMultiplier).EndInit();
			this.grpBulkTimeSignature.ResumeLayout(false);
			this.grpBulkTimeSignature.PerformLayout();
			((ISupportInitialize)this.udBulkMetronome).EndInit();
			this.grpBulkGeneral.ResumeLayout(false);
			this.grpBulkGeneral.PerformLayout();
			((ISupportInitialize)this.udBulkMove).EndInit();
			this.tabAudio.ResumeLayout(false);
			this.grpVolume.ResumeLayout(false);
			this.grpVolume.PerformLayout();
			((ISupportInitialize)this.udVolume).EndInit();
			((ISupportInitialize)this.tbVolume).EndInit();
			this.grpSampleset.ResumeLayout(false);
			this.grpSampleset.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.tabStyle.ResumeLayout(false);
			this.grpEffects.ResumeLayout(false);
			this.grpEffects.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.tabsRight.ResumeLayout(false);
			this.pnlTimingPoints.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.grpTimingScale.ResumeLayout(false);
			this.grpTimingScale.PerformLayout();
			this.pnlToolStrip.ResumeLayout(false);
			this.pnlToolStrip.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003334 RID: 13108
		// RVA: 0x00024FB7 File Offset: 0x000231B7
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Class115.smethod_90("http://osu.ppy.sh/forum/t/729", null);
		}

		// Token: 0x06003333 RID: 13107
		// RVA: 0x0015A1F4 File Offset: 0x001583F4
		private void listSampleset_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			if (this.listSampleset.SelectedItem == null)
			{
				return;
			}
			SampleSet sampleSet_ = (SampleSet)Enum.Parse(typeof(SampleSet), this.listSampleset.SelectedItem.ToString());
			foreach (Class340 current in this.list_2)
			{
				current.sampleSet_0 = sampleSet_;
			}
			this.method_9();
		}

		// Token: 0x06003343 RID: 13123
		// RVA: 0x00025DC1 File Offset: 0x00023FC1
		private void listTimingPoints_Click(object sender, EventArgs e)
		{
			if (this.bool_4)
			{
				this.method_13(true);
			}
			this.listTimingPoints.Focus();
		}

		// Token: 0x06003341 RID: 13121
		// RVA: 0x00025DA4 File Offset: 0x00023FA4
		private void listTimingPoints_ItemActivate(object sender, EventArgs e)
		{
			if (this.class340_0 != null)
			{
				Class331.smethod_70((int)this.class340_0.double_1, false, false);
			}
		}

		// Token: 0x06003342 RID: 13122
		// RVA: 0x0015A970 File Offset: 0x00158B70
		private void listTimingPoints_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			if (keyCode != Keys.Delete)
			{
				switch (keyCode)
				{
				case Keys.A:
					if (e.Control)
					{
						this.method_27();
					}
					break;
				case Keys.B:
					break;
				case Keys.C:
					if (e.Control)
					{
						this.method_28();
					}
					break;
				default:
					switch (keyCode)
					{
					case Keys.V:
						if (e.Control)
						{
							this.method_29();
						}
						break;
					case Keys.X:
						if (e.Control)
						{
							this.method_28();
							this.toolRemove_Click(sender, EventArgs.Empty);
						}
						break;
					}
					break;
				}
			}
			else if (this.listTimingPoints.SelectedIndices.Count > 0)
			{
				this.toolRemove_Click(sender, EventArgs.Empty);
			}
			if (this.bool_4)
			{
				this.method_13(true);
			}
			this.listTimingPoints.Focus();
		}

		// Token: 0x06003344 RID: 13124
		// RVA: 0x00025DC1 File Offset: 0x00023FC1
		private void listTimingPoints_KeyUp(object sender, KeyEventArgs e)
		{
			if (this.bool_4)
			{
				this.method_13(true);
			}
			this.listTimingPoints.Focus();
		}

		// Token: 0x06003351 RID: 13137
		// RVA: 0x00025E27 File Offset: 0x00024027
		private void listTimingPoints_Leave(object sender, EventArgs e)
		{
			if (this.bool_4)
			{
				this.method_13(true);
			}
		}

		// Token: 0x06003350 RID: 13136
		// RVA: 0x00025E27 File Offset: 0x00024027
		private void listTimingPoints_MouseUp(object sender, MouseEventArgs e)
		{
			if (this.bool_4)
			{
				this.method_13(true);
			}
		}

		// Token: 0x0600333D RID: 13117
		// RVA: 0x00025D85 File Offset: 0x00023F85
		private void listTimingPoints_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			this.method_23();
			this.bool_2 = true;
			this.bool_4 = true;
		}

		// Token: 0x06003305 RID: 13061
		// RVA: 0x00158368 File Offset: 0x00156568
		private void method_10(bool bool_5)
		{
			this.bool_1 = true;
			int int_ = this.listTimingPoints.Items.IndexOf(this.listTimingPoints.TopItem);
			this.listTimingPoints.Items.Clear();
			if (this.list_2 == null)
			{
				bool_5 = false;
			}
			int index = 0;
			bool flag = false;
			Color backColor = Class610.smethod_4(Color.FromKnownColor(KnownColor.Control), Color.FromKnownColor(KnownColor.Window), 0.5f);
			foreach (Class340 current in this.list_0)
			{
				ListViewItem listViewItem = this.method_21(current);
				if (flag)
				{
					listViewItem.BackColor = backColor;
				}
				flag = !flag;
				if (bool_5)
				{
					int num = this.list_2.IndexOf(current, index);
					if (num >= 0)
					{
						listViewItem.Selected = true;
						index = num;
					}
				}
				this.listTimingPoints.Items.Add(listViewItem);
			}
			this.method_15(int_);
			this.bool_1 = false;
		}

		// Token: 0x06003306 RID: 13062
		// RVA: 0x00158470 File Offset: 0x00156670
		private void method_11()
		{
			Color color = Class610.smethod_4(Color.FromKnownColor(KnownColor.Control), Color.FromKnownColor(KnownColor.Window), 0.5f);
			Color color2 = Color.FromKnownColor(KnownColor.Window);
			bool flag = false;
			foreach (ListViewItem listViewItem in this.listTimingPoints.Items)
			{
				listViewItem.BackColor = (flag ? color : color2);
				flag = !flag;
			}
		}

		// Token: 0x06003307 RID: 13063
		// RVA: 0x00158504 File Offset: 0x00156704
		private void method_12()
		{
			int int_ = this.listTimingPoints.Items.IndexOf(this.listTimingPoints.TopItem);
			this.list_0.Sort();
			this.list_2.Sort();
			Form2.smethod_1(this.listTimingPoints);
			this.method_10(true);
			this.method_16(int_);
			Form2.smethod_2(this.listTimingPoints);
			this.bool_1 = false;
		}

		// Token: 0x06003308 RID: 13064
		// RVA: 0x00158570 File Offset: 0x00156770
		private void method_13(bool bool_5)
		{
			Predicate<Class340> predicate = null;
			Predicate<Class340> predicate2 = null;
			this.bool_4 = false;
			if (this.class340_0 == null)
			{
				this.tabsLeft.Enabled = false;
				this.chkInherit.Enabled = false;
				this.toolRemove.Enabled = false;
				return;
			}
			this.tabsLeft.Enabled = true;
			this.chkInherit.Enabled = true;
			this.toolRemove.Enabled = true;
			if (bool_5)
			{
				Form2.smethod_1(this.tabsLeft);
			}
			this.bool_1 = true;
			bool flag = false;
			bool flag2;
			if (flag2 = (this.list_2.Count > 1))
			{
				bool flag3 = this.tabsLeft.SelectedIndex == 0;
				if (!this.tabsLeft.TabPages.Contains(this.tabBulk))
				{
					this.tabsLeft.TabPages.Insert(0, this.tabBulk);
				}
				if (flag3)
				{
					this.tabsLeft.SelectedIndex = 0;
				}
				this.tabsLeft.TabPages.Remove(this.tabTiming);
				this.tabsLeft.TabPages.Remove(this.tabGameplay);
			}
			else if (flag = this.class340_0.method_0())
			{
				bool flag4 = this.tabsLeft.SelectedIndex == 0;
				if (!this.tabsLeft.TabPages.Contains(this.tabTiming))
				{
					this.tabsLeft.TabPages.Insert(0, this.tabTiming);
				}
				if (flag4)
				{
					this.tabsLeft.SelectedIndex = 0;
				}
				this.tabsLeft.TabPages.Remove(this.tabGameplay);
				this.tabsLeft.TabPages.Remove(this.tabBulk);
			}
			else
			{
				bool flag5 = this.tabsLeft.SelectedIndex == 0;
				if (!this.tabsLeft.TabPages.Contains(this.tabGameplay))
				{
					this.tabsLeft.TabPages.Insert(0, this.tabGameplay);
				}
				if (flag5)
				{
					this.tabsLeft.SelectedIndex = 0;
				}
				this.tabsLeft.TabPages.Remove(this.tabTiming);
				this.tabsLeft.TabPages.Remove(this.tabBulk);
			}
			if (flag2)
			{
				this.udBulkMove.Value = 0m;
				bool flag6 = this.class340_1 != null;
				bool flag7 = this.class340_2 != null;
				this.grpBulkTimeSignature.Enabled = flag6;
				this.radBulkTimingTriple.Enabled = flag6;
				this.radBulkTimingQuad.Enabled = flag6;
				this.radBulkCustomSignature.Enabled = flag6;
				this.udBulkMetronome.Enabled = flag6;
				this.grpBulkDifficulty.Enabled = flag7;
				this.radBulkSlider75.Enabled = flag7;
				this.radBulkSlider100.Enabled = flag7;
				this.radBulkSlider150.Enabled = flag7;
				this.radBulkSliderCustom.Enabled = flag7;
				this.udBulkSliderMultiplier.Enabled = flag7;
				if (flag6)
				{
					List<Class340> arg_2EE_0 = this.list_2;
					if (predicate == null)
					{
						predicate = new Predicate<Class340>(this.method_30);
					}
					if (arg_2EE_0.TrueForAll(predicate))
					{
						this.method_19(this.class340_1.enum37_0, this.radBulkTimingTriple, this.radBulkTimingQuad, this.radBulkCustomSignature, this.udBulkMetronome);
					}
					else
					{
						this.method_20(this.radBulkTimingTriple, this.radBulkTimingQuad, this.radBulkCustomSignature, this.udBulkMetronome);
					}
				}
				if (flag7)
				{
					List<Class340> arg_35C_0 = this.list_2;
					if (predicate2 == null)
					{
						predicate2 = new Predicate<Class340>(this.method_31);
					}
					if (arg_35C_0.TrueForAll(predicate2))
					{
						this.method_17(this.class340_2.double_0, this.radBulkSlider75, this.radBulkSlider100, this.radBulkSlider150, this.radBulkSliderCustom, this.udBulkSliderMultiplier);
					}
					else
					{
						this.method_18(this.radBulkSlider75, this.radBulkSlider100, this.radBulkSlider150, this.radBulkSliderCustom, this.udBulkSliderMultiplier);
					}
				}
			}
			else if (flag)
			{
				this.udTimingOffset.Value = this.method_14(this.class340_0.double_1, this.udTimingOffset.Minimum, this.udTimingOffset.Maximum);
				this.udBpm.Value = this.method_14(this.class340_0.method_5(), this.udBpm.Minimum, this.udBpm.Maximum);
				this.method_19(this.class340_0.enum37_0, this.radTimingTriple, this.radTimingQuad, this.radCustomSignature, this.udMetronome);
			}
			else
			{
				this.udGameplayOffset.Value = this.method_14(this.class340_0.double_1, this.udGameplayOffset.Minimum, this.udGameplayOffset.Maximum);
				this.method_17(this.class340_0.double_0, this.radSlider75, this.radSlider100, this.radSlider150, this.radSliderCustom, this.udSliderMultiplier);
			}
			if (this.list_2.TrueForAll(new Predicate<Class340>(this.method_32)))
			{
				try
				{
					this.listSampleset.SelectedItem = this.class340_0.sampleSet_0.ToString();
					goto IL_514;
				}
				catch (Exception)
				{
					this.listSampleset.SelectedItems.Clear();
					goto IL_514;
				}
			}
			this.listSampleset.SelectedItems.Clear();
			IL_514:
			if (this.list_2.TrueForAll(new Predicate<Class340>(this.method_33)))
			{
				this.radSamplesetDefault.Checked = (this.class340_0.enum38_0 == Enum38.const_0);
				this.radSamplesetCustom1.Checked = (this.class340_0.enum38_0 == Enum38.const_1);
				this.nudCustom.Enabled = (this.radSamplesetCustom2.Checked = (this.class340_0.enum38_0 >= Enum38.const_2));
				this.nudCustom.Value = Math.Max(2, Math.Min((int)this.class340_0.enum38_0, 100));
			}
			else
			{
				this.radSamplesetDefault.Checked = false;
				this.radSamplesetCustom1.Checked = false;
				Control arg_5E3_0 = this.nudCustom;
				this.radSamplesetCustom2.Checked = false;
				arg_5E3_0.Enabled = false;
			}
			this.tbVolume.Value = Math.Min(100, Math.Max(5, this.class340_0.int_0));
			this.udVolume.Value = this.class340_0.int_0;
			if (this.list_2.TrueForAll(new Predicate<Class340>(this.method_34)))
			{
				this.chkKiai.CheckState = (this.class340_0.method_2() ? CheckState.Checked : CheckState.Unchecked);
				this.chkKiai.ThreeState = false;
			}
			else
			{
				this.chkKiai.CheckState = CheckState.Indeterminate;
			}
			this.chkKiai.Enabled = (this.chkKiai.CheckState != CheckState.Unchecked || (this.list_2.Count == 1 && !this.method_26(this.list_2[0])) || this.list_2.Count > 1);
			Control arg_6EE_0 = this.chkOmitBarline;
			List<Class340> arg_6E9_0 = this.list_2;
			if (TimingEntry.predicate_0 == null)
			{
				TimingEntry.predicate_0 = new Predicate<Class340>(TimingEntry.smethod_3);
			}
			arg_6EE_0.Enabled = arg_6E9_0.Exists(TimingEntry.predicate_0);
			if (this.list_2.TrueForAll(new Predicate<Class340>(this.method_35)))
			{
				this.chkOmitBarline.CheckState = (((this.class340_0.enum39_0 & Enum39.flag_2) > Enum39.flag_0) ? CheckState.Checked : CheckState.Unchecked);
				this.chkOmitBarline.ThreeState = false;
			}
			else
			{
				this.chkOmitBarline.CheckState = CheckState.Indeterminate;
			}
			if (this.list_2.TrueForAll(new Predicate<Class340>(this.method_36)))
			{
				this.chkInherit.CheckState = (this.class340_0.method_0() ? CheckState.Unchecked : CheckState.Checked);
				this.chkInherit.ThreeState = false;
			}
			else
			{
				this.chkInherit.CheckState = CheckState.Indeterminate;
			}
			this.bool_1 = false;
			if (bool_5)
			{
				Form2.smethod_2(this.tabsLeft);
			}
		}

		// Token: 0x06003309 RID: 13065
		// RVA: 0x00025B22 File Offset: 0x00023D22
		private decimal method_14(double double_0, decimal decimal_6, decimal decimal_7)
		{
			if (double.IsNaN(double_0))
			{
				return decimal_6;
			}
			if (double.IsNegativeInfinity(double_0))
			{
				return decimal_6;
			}
			if (double.IsPositiveInfinity(double_0))
			{
				return decimal_7;
			}
			return (decimal)Math.Min((double)decimal_7, Math.Max((double)decimal_6, double_0));
		}

		// Token: 0x0600330A RID: 13066
		// RVA: 0x00158D38 File Offset: 0x00156F38
		private void method_15(int int_1)
		{
			int count = this.listTimingPoints.Items.Count;
			if (count == 0)
			{
				return;
			}
			if (int_1 < 0)
			{
				int_1 = 0;
			}
			if (int_1 >= count)
			{
				int_1 = count - 1;
			}
			try
			{
				this.listTimingPoints.EnsureVisible(int_1);
			}
			catch (ArgumentOutOfRangeException)
			{
			}
		}

		// Token: 0x0600330B RID: 13067
		// RVA: 0x00158D8C File Offset: 0x00156F8C
		private void method_16(int int_1)
		{
			int count = this.listTimingPoints.Items.Count;
			if (count == 0)
			{
				return;
			}
			if (int_1 < 0)
			{
				int_1 = 0;
			}
			if (int_1 >= count)
			{
				int_1 = count - 1;
			}
			try
			{
				this.listTimingPoints.EnsureVisible(count - 1);
				this.listTimingPoints.EnsureVisible(int_1);
			}
			catch (ArgumentOutOfRangeException)
			{
			}
		}

		// Token: 0x0600330C RID: 13068
		// RVA: 0x00158DF0 File Offset: 0x00156FF0
		private void method_17(double double_0, RadioButton radioButton_0, RadioButton radioButton_1, RadioButton radioButton_2, RadioButton radioButton_3, NumericUpDown numericUpDown_0)
		{
			radioButton_0.Checked = (double_0 == -133.333333333333);
			radioButton_1.Checked = (double_0 == -100.0);
			radioButton_2.Checked = (double_0 == -66.6666666666667);
			radioButton_3.Checked = (double_0 != -133.333333333333 && double_0 != -100.0 && double_0 != -66.6666666666667);
			numericUpDown_0.Enabled = radioButton_3.Checked;
			decimal num = (decimal)(-100.0 / double_0);
			switch (this.editor_0.playModes_0)
			{
			case PlayModes.Taiko:
				numericUpDown_0.Minimum = Math.Min(0.1m, num);
				numericUpDown_0.Maximum = Math.Max(4.0m, num);
				goto IL_13D;
			case PlayModes.OsuMania:
				numericUpDown_0.Minimum = Math.Min(0.1m, num);
				numericUpDown_0.Maximum = Math.Max(10.0m, num);
				goto IL_13D;
			}
			numericUpDown_0.Minimum = Math.Min(0.5m, num);
			numericUpDown_0.Maximum = Math.Max(2.0m, num);
			IL_13D:
			numericUpDown_0.Value = num;
		}

		// Token: 0x0600330D RID: 13069
		// RVA: 0x00158F44 File Offset: 0x00157144
		private void method_18(RadioButton radioButton_0, RadioButton radioButton_1, RadioButton radioButton_2, RadioButton radioButton_3, NumericUpDown numericUpDown_0)
		{
			radioButton_0.Checked = false;
			radioButton_1.Checked = false;
			radioButton_2.Checked = false;
			radioButton_3.Checked = false;
			numericUpDown_0.Enabled = false;
			switch (this.editor_0.playModes_0)
			{
			case PlayModes.Taiko:
				numericUpDown_0.Minimum = 0.1m;
				numericUpDown_0.Maximum = 4.0m;
				goto IL_B6;
			case PlayModes.OsuMania:
				numericUpDown_0.Minimum = 0.1m;
				numericUpDown_0.Maximum = 10.0m;
				goto IL_B6;
			}
			numericUpDown_0.Minimum = 0.5m;
			numericUpDown_0.Maximum = 2.0m;
			IL_B6:
			numericUpDown_0.Value = 1.0m;
		}

		// Token: 0x0600330E RID: 13070
		// RVA: 0x0015901C File Offset: 0x0015721C
		private void method_19(Enum37 enum37_0, RadioButton radioButton_0, RadioButton radioButton_1, RadioButton radioButton_2, NumericUpDown numericUpDown_0)
		{
			int num = 5;
			switch (enum37_0)
			{
			case Enum37.const_1:
				radioButton_0.Checked = true;
				radioButton_1.Checked = false;
				radioButton_2.Checked = false;
				numericUpDown_0.Enabled = false;
				break;
			case Enum37.const_0:
				radioButton_1.Checked = true;
				radioButton_0.Checked = false;
				radioButton_2.Checked = false;
				numericUpDown_0.Enabled = false;
				break;
			default:
				num = (int)enum37_0;
				radioButton_2.Checked = true;
				numericUpDown_0.Enabled = true;
				radioButton_0.Checked = false;
				radioButton_1.Checked = false;
				break;
			}
			numericUpDown_0.Minimum = Math.Min(5, num);
			numericUpDown_0.Maximum = Math.Max(7, num);
			numericUpDown_0.Value = num;
		}

		// Token: 0x0600330F RID: 13071
		// RVA: 0x001590D0 File Offset: 0x001572D0
		private void method_20(RadioButton radioButton_0, RadioButton radioButton_1, RadioButton radioButton_2, NumericUpDown numericUpDown_0)
		{
			radioButton_0.Checked = false;
			radioButton_1.Checked = false;
			radioButton_2.Checked = false;
			numericUpDown_0.Enabled = false;
			numericUpDown_0.Minimum = 5m;
			numericUpDown_0.Maximum = 7m;
			numericUpDown_0.Value = 5m;
		}

		// Token: 0x06003310 RID: 13072
		// RVA: 0x00159124 File Offset: 0x00157324
		private ListViewItem method_21(Class340 class340_3)
		{
			if (class340_3.method_0())
			{
				string[] array = new string[6];
				array[0] = string.Format("{0:00}:{1:00}:{2:000}", (int)class340_3.double_1 / 60000, (int)class340_3.double_1 % 60000 / 1000, (int)class340_3.double_1 % 1000);
				array[1] = class340_3.method_5().ToString("0.000");
				string[] arg_8B_0 = array;
				int arg_8B_1 = 2;
				int enum37_ = (int)class340_3.enum37_0;
				arg_8B_0[arg_8B_1] = enum37_.ToString() + "/4";
				string[] arg_C2_0 = array;
				int arg_C2_1 = 3;
				string arg_BD_0 = this.method_22(class340_3);
				string arg_BD_1;
				if (class340_3.enum38_0 <= Enum38.const_0)
				{
					arg_BD_1 = "";
				}
				else
				{
					string arg_B8_0 = ":C";
					int enum38_ = (int)class340_3.enum38_0;
					arg_BD_1 = arg_B8_0 + enum38_.ToString();
				}
				arg_C2_0[arg_C2_1] = arg_BD_0 + arg_BD_1;
				array[4] = class340_3.int_0 + "%";
				array[5] = (class340_3.method_2() ? "☆" : "");
				return new ListViewItem(array, 0);
			}
			string[] array2 = new string[6];
			array2[0] = string.Format("{0:00}:{1:00}:{2:000}", (int)class340_3.double_1 / 60000, (int)class340_3.double_1 % 60000 / 1000, (int)class340_3.double_1 % 1000);
			array2[1] = "x" + (-100.0 / class340_3.double_0).ToString("0.00");
			array2[2] = "";
			string[] arg_1B9_0 = array2;
			int arg_1B9_1 = 3;
			string arg_1B4_0 = this.method_22(class340_3);
			string arg_1B4_1;
			if (class340_3.enum38_0 <= Enum38.const_0)
			{
				arg_1B4_1 = "";
			}
			else
			{
				string arg_1AF_0 = ":C";
				int enum38_2 = (int)class340_3.enum38_0;
				arg_1B4_1 = arg_1AF_0 + enum38_2.ToString();
			}
			arg_1B9_0[arg_1B9_1] = arg_1B4_0 + arg_1B4_1;
			array2[4] = class340_3.int_0 + "%";
			array2[5] = (class340_3.method_2() ? "☆" : "");
			return new ListViewItem(array2, 1);
		}

		// Token: 0x06003311 RID: 13073
		// RVA: 0x00159324 File Offset: 0x00157524
		private string method_22(Class340 class340_3)
		{
			switch (class340_3.sampleSet_0)
			{
			case SampleSet.Normal:
				return "N";
			case SampleSet.Soft:
				return "S";
			case SampleSet.Drum:
				return "D";
			default:
				return "?";
			}
		}

		// Token: 0x06003314 RID: 13076
		// RVA: 0x00159364 File Offset: 0x00157564
		private void method_23()
		{
			this.list_2 = new List<Class340>();
			this.class340_1 = null;
			this.class340_2 = null;
			if (this.listTimingPoints.SelectedIndices.Count == 0)
			{
				this.class340_0 = null;
				return;
			}
			foreach (int index in this.listTimingPoints.SelectedIndices)
			{
				this.list_2.Add(this.list_0[index]);
				if (this.class340_1 == null || this.class340_2 == null)
				{
					if (this.list_0[index].method_0())
					{
						if (this.class340_1 == null)
						{
							this.class340_1 = this.list_0[index];
						}
					}
					else if (this.class340_2 == null)
					{
						this.class340_2 = this.list_0[index];
					}
				}
			}
			this.class340_0 = this.list_2[0];
		}

		// Token: 0x0600333E RID: 13118
		// RVA: 0x0015A764 File Offset: 0x00158964
		private double method_24(Class340 class340_3)
		{
			int num = this.list_0.IndexOf(class340_3);
			for (int i = num; i >= 0; i--)
			{
				Class340 class = this.list_0[i];
				if (class.method_0())
				{
					return class.double_0;
				}
			}
			return 500.0;
		}

		// Token: 0x06003340 RID: 13120
		// RVA: 0x0015A85C File Offset: 0x00158A5C
		private void method_25(bool bool_5, bool bool_6)
		{
			List<Class340> list = new List<Class340>();
			List<Class340> list2 = new List<Class340>();
			foreach (Class340 current in this.list_0)
			{
				if (current.method_0())
				{
					if (bool_5)
					{
						list.Add(current);
					}
					else
					{
						list2.Add(current);
					}
				}
				else if (bool_6)
				{
					list.Add(current);
				}
				else
				{
					list2.Add(current);
				}
			}
			foreach (Class340 current2 in this.list_1)
			{
				if (current2.method_0())
				{
					if (bool_5)
					{
						list.Add(current2);
					}
					else
					{
						list2.Add(current2);
					}
				}
				else if (bool_6)
				{
					list.Add(current2);
				}
				else
				{
					list2.Add(current2);
				}
			}
			list.Sort();
			list2.Sort();
			this.list_0 = list;
			this.list_1 = list2;
		}

		// Token: 0x06003345 RID: 13125
		// RVA: 0x0015AA3C File Offset: 0x00158C3C
		private bool method_26(Class340 class340_3)
		{
			Class340 class;
			if (this.list_1.Count == 0)
			{
				class = this.list_0[0];
			}
			else if (this.list_0.Count == 0)
			{
				class = this.list_1[0];
			}
			else
			{
				class = ((this.list_0[0].double_1 < this.list_1[0].double_1) ? this.list_0[0] : this.list_1[0]);
			}
			return class340_3 == class;
		}

		// Token: 0x06003346 RID: 13126
		// RVA: 0x0015AAC4 File Offset: 0x00158CC4
		private void method_27()
		{
			this.listTimingPoints.SelectedIndices.Clear();
			for (int i = 0; i < this.listTimingPoints.Items.Count; i++)
			{
				this.listTimingPoints.SelectedIndices.Add(i);
			}
		}

		// Token: 0x06003347 RID: 13127
		// RVA: 0x0015AB10 File Offset: 0x00158D10
		private void method_28()
		{
			if (this.list_2.Count == 0)
			{
				return;
			}
			string data = Class297.smethod_0(this.list_2);
			Clipboard.Clear();
			Clipboard.SetData(DataFormats.Text, data);
		}

		// Token: 0x06003348 RID: 13128
		// RVA: 0x0015AB48 File Offset: 0x00158D48
		private bool method_29()
		{
			if (!Clipboard.ContainsData(DataFormats.Text))
			{
				return false;
			}
			bool flag;
			List<Class340> collection = Class297.smethod_1(Class466.Current, (string)Clipboard.GetData(DataFormats.Text), ref flag, false);
			if (!flag)
			{
				return false;
			}
			this.listTimingPoints.SelectedIndices.Clear();
			this.list_2.Clear();
			this.list_0.AddRange(collection);
			this.list_2.AddRange(collection);
			this.method_12();
			this.method_23();
			this.method_13(true);
			this.listTimingPoints.Focus();
			if (this.listTimingPoints.SelectedIndices.Count > 0)
			{
				this.method_15(this.listTimingPoints.SelectedIndices[0]);
			}
			return true;
		}

		// Token: 0x06003358 RID: 13144
		// RVA: 0x00025E73 File Offset: 0x00024073
		[CompilerGenerated]
		private bool method_30(Class340 class340_3)
		{
			return !class340_3.method_0() || class340_3.enum37_0 == this.class340_1.enum37_0;
		}

		// Token: 0x06003359 RID: 13145
		// RVA: 0x00025E92 File Offset: 0x00024092
		[CompilerGenerated]
		private bool method_31(Class340 class340_3)
		{
			return class340_3.method_0() || class340_3.double_0 == this.class340_2.double_0;
		}

		// Token: 0x0600335A RID: 13146
		// RVA: 0x00025EB1 File Offset: 0x000240B1
		[CompilerGenerated]
		private bool method_32(Class340 class340_3)
		{
			return class340_3.sampleSet_0 == this.class340_0.sampleSet_0;
		}

		// Token: 0x0600335B RID: 13147
		// RVA: 0x00025EC6 File Offset: 0x000240C6
		[CompilerGenerated]
		private bool method_33(Class340 class340_3)
		{
			return class340_3.enum38_0 == this.class340_0.enum38_0;
		}

		// Token: 0x0600335C RID: 13148
		// RVA: 0x00025EDB File Offset: 0x000240DB
		[CompilerGenerated]
		private bool method_34(Class340 class340_3)
		{
			return class340_3.method_2() == this.class340_0.method_2();
		}

		// Token: 0x0600335E RID: 13150
		// RVA: 0x00025EF0 File Offset: 0x000240F0
		[CompilerGenerated]
		private bool method_35(Class340 class340_3)
		{
			return (class340_3.enum39_0 & Enum39.flag_2) == (this.class340_0.enum39_0 & Enum39.flag_2);
		}

		// Token: 0x0600335F RID: 13151
		// RVA: 0x00025F09 File Offset: 0x00024109
		[CompilerGenerated]
		private bool method_36(Class340 class340_3)
		{
			return class340_3.method_0() == this.class340_0.method_0();
		}

		// Token: 0x06003304 RID: 13060
		// RVA: 0x0015821C File Offset: 0x0015641C
		private void method_9()
		{
			this.bool_1 = true;
			if (this.listTimingPoints.SelectedIndices.Count == 0)
			{
				return;
			}
			Color backColor = Class610.smethod_4(Color.FromKnownColor(KnownColor.Control), Color.FromKnownColor(KnownColor.Window), 0.5f);
			foreach (int num in this.listTimingPoints.SelectedIndices)
			{
				ListViewItem listViewItem = this.method_21(this.list_0[num]);
				if (num % 2 == 0)
				{
					listViewItem.BackColor = backColor;
				}
				for (int i = 0; i < 6; i++)
				{
					this.listTimingPoints.Items[num].SubItems[i].Text = listViewItem.SubItems[i].Text;
					this.listTimingPoints.Items[num].SubItems[i].ForeColor = listViewItem.SubItems[i].ForeColor;
				}
				this.listTimingPoints.Items[num].ImageIndex = listViewItem.ImageIndex;
			}
			this.bool_1 = false;
		}

		// Token: 0x0600332A RID: 13098
		// RVA: 0x00159F98 File Offset: 0x00158198
		private void nudCustom_ValueChanged(object sender, EventArgs e)
		{
			if (!this.radSamplesetCustom2.Checked)
			{
				return;
			}
			foreach (Class340 current in this.list_2)
			{
				current.enum38_0 = (Enum38)((int)this.nudCustom.Value);
			}
			this.method_9();
		}

		// Token: 0x0600334C RID: 13132
		// RVA: 0x00025DFA File Offset: 0x00023FFA
		private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.method_29();
		}

		// Token: 0x06003320 RID: 13088
		// RVA: 0x00159994 File Offset: 0x00157B94
		private void radBulkCustomSignature_CheckedChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			if (this.radBulkCustomSignature.Checked)
			{
				this.radBulkTimingTriple.Checked = false;
				this.radBulkTimingQuad.Checked = false;
				this.udBulkMetronome.Enabled = true;
				this.method_9();
			}
		}

		// Token: 0x06003323 RID: 13091
		// RVA: 0x00159B38 File Offset: 0x00157D38
		private void radBulkSlider100_CheckedChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			if (this.radBulkSlider100.Checked)
			{
				this.radBulkSlider75.Checked = false;
				this.radBulkSlider150.Checked = false;
				this.radBulkSliderCustom.Checked = false;
				this.udBulkSliderMultiplier.Enabled = false;
				this.bool_1 = true;
				this.udBulkSliderMultiplier.Value = 1.0m;
				this.bool_1 = false;
				foreach (Class340 current in this.list_2)
				{
					if (!current.method_0())
					{
						current.double_0 = -100.0;
					}
				}
				this.method_9();
			}
		}

		// Token: 0x06003324 RID: 13092
		// RVA: 0x00159C10 File Offset: 0x00157E10
		private void radBulkSlider150_CheckedChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			if (this.radBulkSlider150.Checked)
			{
				this.radBulkSlider75.Checked = false;
				this.radBulkSlider100.Checked = false;
				this.radBulkSliderCustom.Checked = false;
				this.udBulkSliderMultiplier.Enabled = false;
				this.bool_1 = true;
				this.udBulkSliderMultiplier.Value = 1.5m;
				this.bool_1 = false;
				foreach (Class340 current in this.list_2)
				{
					if (!current.method_0())
					{
						current.double_0 = -66.6666666666667;
					}
				}
				this.method_9();
			}
		}

		// Token: 0x06003322 RID: 13090
		// RVA: 0x00159A58 File Offset: 0x00157C58
		private void radBulkSlider75_CheckedChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			if (this.radBulkSlider75.Checked)
			{
				this.radBulkSlider100.Checked = false;
				this.radBulkSlider150.Checked = false;
				this.radBulkSliderCustom.Checked = false;
				this.udBulkSliderMultiplier.Enabled = false;
				this.bool_1 = true;
				this.udBulkSliderMultiplier.Value = 0.750000000000002m;
				this.bool_1 = false;
				foreach (Class340 current in this.list_2)
				{
					if (!current.method_0())
					{
						current.double_0 = -133.333333333333;
					}
				}
				this.method_9();
			}
		}

		// Token: 0x06003325 RID: 13093
		// RVA: 0x00159CE8 File Offset: 0x00157EE8
		private void radBulkSliderCustom_CheckedChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			if (this.radBulkSliderCustom.Checked)
			{
				this.radBulkSlider75.Checked = false;
				this.radBulkSlider100.Checked = false;
				this.radBulkSlider150.Checked = false;
				this.udBulkSliderMultiplier.Enabled = true;
				this.method_9();
			}
		}

		// Token: 0x0600331F RID: 13087
		// RVA: 0x001598DC File Offset: 0x00157ADC
		private void radBulkTimingQuad_CheckedChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			if (this.radBulkTimingQuad.Checked)
			{
				this.radBulkTimingTriple.Checked = false;
				this.radBulkCustomSignature.Checked = false;
				this.udBulkMetronome.Enabled = false;
				this.bool_1 = true;
				this.udBulkMetronome.Value = 5m;
				this.bool_1 = false;
				foreach (Class340 current in this.list_2)
				{
					current.enum37_0 = Enum37.const_0;
				}
				this.method_9();
			}
		}

		// Token: 0x0600331E RID: 13086
		// RVA: 0x00159824 File Offset: 0x00157A24
		private void radBulkTimingTriple_CheckedChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			if (this.radBulkTimingTriple.Checked)
			{
				this.radBulkTimingQuad.Checked = false;
				this.radBulkCustomSignature.Checked = false;
				this.udBulkMetronome.Enabled = false;
				this.bool_1 = true;
				this.udBulkMetronome.Value = 5m;
				this.bool_1 = false;
				foreach (Class340 current in this.list_2)
				{
					current.enum37_0 = Enum37.const_1;
				}
				this.method_9();
			}
		}

		// Token: 0x06003317 RID: 13079
		// RVA: 0x0015954C File Offset: 0x0015774C
		private void radCustomSignature_CheckedChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			if (this.radCustomSignature.Checked)
			{
				this.radTimingTriple.Checked = false;
				this.radTimingQuad.Checked = false;
				this.udMetronome.Enabled = true;
				this.class340_0.enum37_0 = (Enum37)((int)this.udMetronome.Value);
				this.method_9();
			}
		}

		// Token: 0x06003328 RID: 13096
		// RVA: 0x00159E60 File Offset: 0x00158060
		private void radSamplesetCustom1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			if (this.radSamplesetCustom1.Checked)
			{
				this.radSamplesetDefault.Checked = false;
				this.radSamplesetCustom2.Checked = false;
				foreach (Class340 current in this.list_2)
				{
					current.enum38_0 = Enum38.const_1;
				}
				this.method_9();
			}
		}

		// Token: 0x06003329 RID: 13097
		// RVA: 0x00159EE8 File Offset: 0x001580E8
		private void radSamplesetCustom2_CheckedChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			if (this.radSamplesetCustom2.Checked)
			{
				this.nudCustom.Enabled = true;
				this.radSamplesetDefault.Checked = false;
				this.radSamplesetCustom1.Checked = false;
				foreach (Class340 current in this.list_2)
				{
					current.enum38_0 = (Enum38)((int)this.nudCustom.Value);
				}
				this.method_9();
				return;
			}
			this.nudCustom.Enabled = false;
		}

		// Token: 0x06003327 RID: 13095
		// RVA: 0x00159DD8 File Offset: 0x00157FD8
		private void radSamplesetDefault_CheckedChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			if (this.radSamplesetDefault.Checked)
			{
				this.radSamplesetCustom1.Checked = false;
				this.radSamplesetCustom2.Checked = false;
				foreach (Class340 current in this.list_2)
				{
					current.enum38_0 = Enum38.const_0;
				}
				this.method_9();
			}
		}

		// Token: 0x0600331A RID: 13082
		// RVA: 0x00159650 File Offset: 0x00157850
		private void radSlider100_CheckedChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			if (this.radSlider100.Checked)
			{
				this.radSlider75.Checked = false;
				this.radSlider150.Checked = false;
				this.radSliderCustom.Checked = false;
				this.udSliderMultiplier.Enabled = false;
				this.bool_1 = true;
				this.udSliderMultiplier.Value = 1.0m;
				this.bool_1 = false;
				this.class340_0.double_0 = -100.0;
				this.method_9();
			}
		}

		// Token: 0x0600331B RID: 13083
		// RVA: 0x001596E4 File Offset: 0x001578E4
		private void radSlider150_CheckedChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			if (this.radSlider150.Checked)
			{
				this.radSlider75.Checked = false;
				this.radSlider100.Checked = false;
				this.radSliderCustom.Checked = false;
				this.udSliderMultiplier.Enabled = false;
				this.bool_1 = true;
				this.udSliderMultiplier.Value = 1.5m;
				this.bool_1 = false;
				this.class340_0.double_0 = -66.6666666666667;
				this.method_9();
			}
		}

		// Token: 0x06003319 RID: 13081
		// RVA: 0x001595B4 File Offset: 0x001577B4
		private void radSlider75_CheckedChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			if (this.radSlider75.Checked)
			{
				this.radSlider100.Checked = false;
				this.radSlider150.Checked = false;
				this.radSliderCustom.Checked = false;
				this.udSliderMultiplier.Enabled = false;
				this.bool_1 = true;
				this.udSliderMultiplier.Value = 0.750000000000002m;
				this.bool_1 = false;
				this.class340_0.double_0 = -133.333333333333;
				this.method_9();
			}
		}

		// Token: 0x0600331C RID: 13084
		// RVA: 0x00159778 File Offset: 0x00157978
		private void radSliderCustom_CheckedChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			if (this.radSliderCustom.Checked)
			{
				this.radSlider75.Checked = false;
				this.radSlider100.Checked = false;
				this.radSlider150.Checked = false;
				this.udSliderMultiplier.Enabled = true;
				this.method_9();
			}
		}

		// Token: 0x06003316 RID: 13078
		// RVA: 0x001594E0 File Offset: 0x001576E0
		private void radTimingQuad_CheckedChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			if (this.radTimingQuad.Checked)
			{
				this.radTimingTriple.Checked = false;
				this.radCustomSignature.Checked = false;
				this.udMetronome.Enabled = false;
				this.udMetronome.Value = 5m;
				this.class340_0.enum37_0 = Enum37.const_0;
				this.method_9();
			}
		}

		// Token: 0x06003315 RID: 13077
		// RVA: 0x00159474 File Offset: 0x00157674
		private void radTimingTriple_CheckedChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			if (this.radTimingTriple.Checked)
			{
				this.radTimingQuad.Checked = false;
				this.radCustomSignature.Checked = false;
				this.udMetronome.Enabled = false;
				this.udMetronome.Value = 5m;
				this.class340_0.enum37_0 = Enum37.const_1;
				this.method_9();
			}
		}

		// Token: 0x0600334E RID: 13134
		// RVA: 0x00025E11 File Offset: 0x00024011
		private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.method_27();
		}

		// Token: 0x0600335D RID: 13149
		// RVA: 0x000165A1 File Offset: 0x000147A1
		[CompilerGenerated]
		private static bool smethod_3(Class340 class340_3)
		{
			return class340_3.method_0();
		}

		// Token: 0x0600333F RID: 13119
		// RVA: 0x0015A7B0 File Offset: 0x001589B0
		private void tabsRight_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (this.tabsRight.SelectedIndex)
			{
			case 0:
				this.method_25(true, true);
				break;
			case 1:
				this.method_25(true, false);
				break;
			case 2:
				this.method_25(false, true);
				break;
			}
			Form2.smethod_1(this.listTimingPoints);
			this.method_16(0);
			this.method_10(false);
			if (this.listTimingPoints.Items.Count > 0)
			{
				this.listTimingPoints.SelectedIndices.Add(0);
			}
			this.method_23();
			Form2.smethod_2(this.listTimingPoints);
			this.method_13(true);
			this.tabsRight.Focus();
		}

		// Token: 0x0600332B RID: 13099
		// RVA: 0x0015A010 File Offset: 0x00158210
		private void tbVolume_ValueChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			this.bool_1 = true;
			this.udVolume.Value = this.tbVolume.Value;
			this.bool_1 = false;
			foreach (Class340 current in this.list_2)
			{
				current.int_0 = this.tbVolume.Value;
			}
			this.method_9();
		}

		// Token: 0x06003355 RID: 13141
		// RVA: 0x0015AD34 File Offset: 0x00158F34
		private void TimingEntry_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!this.bool_3)
			{
				this.editor_0.method_17(true);
				return;
			}
			TimingEntry.Class871 class = new TimingEntry.Class871();
			class.timingEntry_0 = this;
			class.bool_0 = (this.list_0.Count != Class331.smethod_14().Count);
			this.method_25(true, true);
			bool flag = false;
			class.int_0 = 0;
			foreach (Class340 current in this.list_0)
			{
				if (current.method_0())
				{
					flag = true;
				}
				bool flag2 = class.int_0 < Class331.smethod_14().Count;
				if (flag && (class.bool_0 || !flag2))
				{
					break;
				}
				if (flag2)
				{
					class.bool_0 = !current.Equals(Class331.smethod_14()[class.int_0]);
					class.int_0++;
				}
			}
			if (class.bool_0)
			{
				this.editor_0.bool_5 = true;
			}
			else
			{
				this.editor_0.method_17(true);
			}
			if (!flag)
			{
				MessageBox.Show("At least one timing point is required.", "osu!", MessageBoxButtons.OK);
				base.DialogResult = DialogResult.None;
				return;
			}
			Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
		}

		// Token: 0x06003303 RID: 13059
		// RVA: 0x00157FE4 File Offset: 0x001561E4
		private void TimingEntry_Load(object sender, EventArgs e)
		{
			this.bool_1 = true;
			if (this.int_0 >= 0)
			{
				this.listTimingPoints.SelectedIndices.Add(this.int_0);
			}
			this.method_23();
			this.bool_1 = false;
			Form2.smethod_2(this.listTimingPoints);
			this.method_13(false);
			if (this.listTimingPoints.Items.Count > 0)
			{
				this.method_15(this.listTimingPoints.SelectedIndices[0]);
			}
			if (this.tabsLeft.TabPages.Contains(this.tabTiming))
			{
				switch (this.enum58_0)
				{
				case Enum58.const_0:
					base.ActiveControl = this.listTimingPoints;
					return;
				case Enum58.const_1:
					base.ActiveControl = this.udBpm;
					this.udBpm.Select(0, this.udBpm.Text.Length);
					return;
				case Enum58.const_2:
					base.ActiveControl = this.udTimingOffset;
					this.udTimingOffset.Select(0, this.udTimingOffset.Text.Length);
					return;
				case Enum58.const_3:
					this.tabsLeft.SelectedIndex = 1;
					base.ActiveControl = this.listSampleset;
					return;
				default:
					return;
				}
			}
			else
			{
				if (!this.tabsLeft.TabPages.Contains(this.tabGameplay))
				{
					if (this.tabsLeft.TabPages.Contains(this.tabBulk))
					{
						switch (this.enum58_0)
						{
						case Enum58.const_0:
							base.ActiveControl = this.listTimingPoints;
							return;
						case Enum58.const_1:
						case Enum58.const_2:
							base.ActiveControl = this.udBulkMove;
							this.udBulkMove.Select(0, this.udBulkMove.Text.Length);
							return;
						case Enum58.const_3:
							this.tabsLeft.SelectedIndex = 1;
							base.ActiveControl = this.listSampleset;
							break;
						default:
							return;
						}
					}
					return;
				}
				switch (this.enum58_0)
				{
				case Enum58.const_0:
					base.ActiveControl = this.listTimingPoints;
					return;
				case Enum58.const_1:
				case Enum58.const_2:
					base.ActiveControl = this.udGameplayOffset;
					this.udGameplayOffset.Select(0, this.udGameplayOffset.Text.Length);
					return;
				case Enum58.const_3:
					this.tabsLeft.SelectedIndex = 1;
					base.ActiveControl = this.listSampleset;
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x0600333B RID: 13115
		// RVA: 0x0015A3E0 File Offset: 0x001585E0
		private void toolAdd_Click(object sender, EventArgs e)
		{
			int int_ = this.listTimingPoints.Items.IndexOf(this.listTimingPoints.TopItem);
			bool flag = this.tabsRight.SelectedIndex == 1 || (this.tabsRight.SelectedIndex == 0 && this.listTimingPoints.SelectedIndices.Count == 0);
			Class340 class;
			if (this.listTimingPoints.SelectedIndices.Count > 0 && this.class340_0 != null)
			{
				double double_;
				if (flag)
				{
					double_ = this.method_24(this.class340_0);
				}
				else if (this.class340_0.method_0())
				{
					double_ = (this.class340_0.method_0() ? this.class340_0.double_0 : -100.0);
				}
				else
				{
					double_ = this.class340_0.double_0;
				}
				class = new Class340(this.bool_2 ? (this.class340_0.double_1 + 100.0) : ((double)Class331.int_7), double_, this.class340_0.enum37_0, this.class340_0.sampleSet_0, this.class340_0.enum38_0, this.class340_0.int_0, flag, this.class340_0.enum39_0);
			}
			else
			{
				class = new Class340(0.0, (double)(flag ? 500 : -100));
				class.method_1(flag);
			}
			this.list_0.Add(class);
			this.list_0.Sort();
			Form2.smethod_1(this.listTimingPoints);
			this.method_10(false);
			this.bool_1 = true;
			int num = this.list_0.IndexOf(class);
			this.listTimingPoints.SelectedIndices.Add(num);
			this.bool_1 = false;
			this.method_16(int_);
			this.method_15(num);
			this.listTimingPoints.Focus();
			Form2.smethod_2(this.listTimingPoints);
			this.method_23();
			this.method_13(true);
			this.bool_2 = true;
		}

		// Token: 0x0600333C RID: 13116
		// RVA: 0x0015A5CC File Offset: 0x001587CC
		private void toolRemove_Click(object sender, EventArgs e)
		{
			if (this.listTimingPoints.SelectedIndices.Count == 0)
			{
				return;
			}
			int num = Math.Max(this.listTimingPoints.SelectedIndices[0] - 1, 0);
			foreach (Class340 current in this.list_2)
			{
				this.list_0.Remove(current);
			}
			Form2.smethod_1(this.listTimingPoints);
			this.bool_1 = true;
			foreach (ListViewItem listViewItem in this.listTimingPoints.Items)
			{
				if (listViewItem.Selected)
				{
					this.listTimingPoints.Items.Remove(listViewItem);
				}
			}
			this.bool_1 = false;
			this.method_11();
			if (num < this.list_0.Count)
			{
				this.listTimingPoints.SelectedIndices.Add(num);
			}
			else if (this.list_0.Count > 0)
			{
				this.listTimingPoints.SelectedIndices.Add(this.list_0.Count - 1);
			}
			Form2.smethod_2(this.listTimingPoints);
			this.method_23();
			this.method_13(true);
			this.method_15(num);
			this.listTimingPoints.Focus();
			this.bool_2 = true;
			Form2.smethod_2(this.listTimingPoints);
		}

		// Token: 0x0600332D RID: 13101
		// RVA: 0x00025BAB File Offset: 0x00023DAB
		private void udBpm_ValueChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			this.class340_0.double_0 = 60000.0 / (double)this.udBpm.Value;
			this.method_9();
		}

		// Token: 0x06003321 RID: 13089
		// RVA: 0x001599E4 File Offset: 0x00157BE4
		private void udBulkMetronome_ValueChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			foreach (Class340 current in this.list_2)
			{
				current.enum37_0 = (Enum37)((int)this.udBulkMetronome.Value);
			}
			this.method_9();
		}

		// Token: 0x06003352 RID: 13138
		// RVA: 0x00025E38 File Offset: 0x00024038
		private void udBulkMove_Enter(object sender, EventArgs e)
		{
			base.AcceptButton = this.btnBulkMove;
		}

		// Token: 0x06003353 RID: 13139
		// RVA: 0x00025E46 File Offset: 0x00024046
		private void udBulkMove_Leave(object sender, EventArgs e)
		{
			base.AcceptButton = this.buttonOk;
		}

		// Token: 0x06003326 RID: 13094
		// RVA: 0x00159D44 File Offset: 0x00157F44
		private void udBulkSliderMultiplier_ValueChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			foreach (Class340 current in this.list_2)
			{
				if (!current.method_0())
				{
					current.double_0 = (double)(-100.0m / this.udBulkSliderMultiplier.Value);
				}
			}
			this.method_9();
		}

		// Token: 0x06003330 RID: 13104
		// RVA: 0x00025C4F File Offset: 0x00023E4F
		private void udGameplayOffset_ValueChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			this.class340_0.double_1 = (double)this.udGameplayOffset.Value;
			this.method_12();
		}

		// Token: 0x06003318 RID: 13080
		// RVA: 0x00025B7F File Offset: 0x00023D7F
		private void udMetronome_ValueChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			this.class340_0.enum37_0 = (Enum37)((int)this.udMetronome.Value);
			this.method_9();
		}

		// Token: 0x0600331D RID: 13085
		// RVA: 0x001597D4 File Offset: 0x001579D4
		private void udSliderMultiplier_ValueChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			this.class340_0.double_0 = (double)(-100.0m / this.udSliderMultiplier.Value);
			this.method_9();
		}

		// Token: 0x0600332E RID: 13102
		// RVA: 0x00025BE2 File Offset: 0x00023DE2
		private void udTimingOffset_ValueChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			this.class340_0.double_1 = (double)this.udTimingOffset.Value;
			this.method_12();
		}

		// Token: 0x0600332C RID: 13100
		// RVA: 0x0015A0A8 File Offset: 0x001582A8
		private void udVolume_ValueChanged(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				return;
			}
			this.bool_1 = true;
			this.udVolume.Value = Math.Min(100m, Math.Max(5m, this.udVolume.Value));
			this.tbVolume.Value = (int)this.udVolume.Value;
			this.bool_1 = false;
			foreach (Class340 current in this.list_2)
			{
				current.int_0 = (int)this.udVolume.Value;
			}
			this.method_9();
		}
	}
}
