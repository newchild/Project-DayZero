using Microsoft.Xna.Framework.Graphics;
using ns11;
using ns14;
using ns23;
using ns24;
using ns26;
using ns29;
using ns59;
using ns64;
using ns8;
using ns80;
using ns89;
using osu.Audio;
using osu.GameModes.Edit;
using osu.GameplayElements.HitObjects;
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
	// Token: 0x0200065E RID: 1630
	internal sealed class SongSetup : Form2
	{
		// Token: 0x04002E47 RID: 11847
		private ComboBox allowedModes;

		// Token: 0x04002E5A RID: 11866
		private TrackBar approachRate;

		// Token: 0x04002DEF RID: 11759
		private TextBox artist;

		// Token: 0x04002DF0 RID: 11760
		private Label artistLabel;

		// Token: 0x04002E63 RID: 11875
		private TextBox artistRomanised;

		// Token: 0x04002E1B RID: 11803
		private Class616 backgroundColour;

		// Token: 0x04002DE3 RID: 11747
		private readonly bool bool_1;

		// Token: 0x04002DE4 RID: 11748
		private readonly bool bool_2;

		// Token: 0x04002DE5 RID: 11749
		private bool bool_3 = true;

		// Token: 0x04002DE6 RID: 11750
		private bool bool_4 = true;

		// Token: 0x04002DE7 RID: 11751
		private bool bool_5;

		// Token: 0x04002DE8 RID: 11752
		private bool bool_6;

		// Token: 0x04002E02 RID: 11778
		private Button button1;

		// Token: 0x04002E1F RID: 11807
		private Button buttonAddCombo;

		// Token: 0x04002E45 RID: 11845
		private Button buttonClap;

		// Token: 0x04002E04 RID: 11780
		private Button buttonFinish;

		// Token: 0x04002E06 RID: 11782
		private Button buttonHit;

		// Token: 0x04002DEC RID: 11756
		private Button buttonOk;

		// Token: 0x04002E20 RID: 11808
		private Button buttonRemoveCombo;

		// Token: 0x04002E30 RID: 11824
		private Button buttonSampleReset;

		// Token: 0x04002E31 RID: 11825
		private Button buttonVolumeReset;

		// Token: 0x04002E05 RID: 11781
		private Button buttonWhistle;

		// Token: 0x04002E6E RID: 11886
		private CheckBox cb_maniaSpecial;

		// Token: 0x04002E2C RID: 11820
		private CheckBox checkCountdown;

		// Token: 0x04002E55 RID: 11861
		private CheckBox checkEpilepsy;

		// Token: 0x04002E42 RID: 11842
		private CheckBox checkLetterbox;

		// Token: 0x04002E75 RID: 11893
		private CheckBox checkSamplesMatchPlaybackRate;

		// Token: 0x04002E46 RID: 11846
		private CheckBox checkStoryOverFire;

		// Token: 0x04002E71 RID: 11889
		private CheckBox checkWidescreen;

		// Token: 0x04002DFF RID: 11775
		private TrackBar circleSize;

		// Token: 0x04002DE9 RID: 11753
		private Class616[] class616_0;

		// Token: 0x04002E0E RID: 11790
		private ColorDialog colorDialog_0;

		// Token: 0x04002E0C RID: 11788
		private Class616 combo1;

		// Token: 0x04002E11 RID: 11793
		private Class616 combo2;

		// Token: 0x04002E10 RID: 11792
		private Class616 combo3;

		// Token: 0x04002E0F RID: 11791
		private Class616 combo4;

		// Token: 0x04002E12 RID: 11794
		private Class616 combo5;

		// Token: 0x04002E5E RID: 11870
		private Class616 combo6;

		// Token: 0x04002E60 RID: 11872
		private Class616 combo7;

		// Token: 0x04002E5F RID: 11871
		private Class616 combo8;

		// Token: 0x04002E24 RID: 11812
		private ComboBox comboBox1;

		// Token: 0x04002E73 RID: 11891
		private CheckBox coopmode;

		// Token: 0x04002E33 RID: 11827
		private RadioButton countdownDouble;

		// Token: 0x04002E32 RID: 11826
		private RadioButton countdownHalf;

		// Token: 0x04002E34 RID: 11828
		private RadioButton countdownNormal;

		// Token: 0x04002DF1 RID: 11761
		private TextBox creator;

		// Token: 0x04002E0D RID: 11789
		private CheckBox customColour;

		// Token: 0x04002DE2 RID: 11746
		private Editor editor_0;

		// Token: 0x04002DF4 RID: 11764
		private GroupBox groupBox1;

		// Token: 0x04002E37 RID: 11831
		private GroupBox groupBox10;

		// Token: 0x04002E41 RID: 11841
		private GroupBox groupBox11;

		// Token: 0x04002E43 RID: 11843
		private GroupBox groupBox12;

		// Token: 0x04002DF5 RID: 11765
		private GroupBox groupBox2;

		// Token: 0x04002E03 RID: 11779
		private GroupBox groupBox3;

		// Token: 0x04002E74 RID: 11892
		private GroupBox groupBox4;

		// Token: 0x04002E07 RID: 11783
		private GroupBox groupBox5;

		// Token: 0x04002E0B RID: 11787
		private GroupBox groupBox6;

		// Token: 0x04002E23 RID: 11811
		private GroupBox groupBox7;

		// Token: 0x04002E1A RID: 11802
		private GroupBox groupBox8;

		// Token: 0x04002E36 RID: 11830
		private GroupBox groupBox9;

		// Token: 0x04002E2F RID: 11823
		private Panel hideSampleSettings;

		// Token: 0x04002E2E RID: 11822
		private Panel hideSampleVolume;

		// Token: 0x04002DF3 RID: 11763
		private TrackBar hpDrainRate;

		// Token: 0x04002DEB RID: 11755
		private IContainer icontainer_0;

		// Token: 0x04002DF2 RID: 11762
		private Label label1;

		// Token: 0x04002E00 RID: 11776
		private Label label10;

		// Token: 0x04002DFC RID: 11772
		private Label label11;

		// Token: 0x04002DFD RID: 11773
		private Label label12;

		// Token: 0x04002DFE RID: 11774
		private Label label13;

		// Token: 0x04002E01 RID: 11777
		private Label label14;

		// Token: 0x04002E1E RID: 11806
		private Label label15;

		// Token: 0x04002E25 RID: 11813
		private Label label16;

		// Token: 0x04002E72 RID: 11890
		private Label label17;

		// Token: 0x04002DF6 RID: 11766
		private Label label2;

		// Token: 0x04002E27 RID: 11815
		private Label label23;

		// Token: 0x04002E28 RID: 11816
		private Label label24;

		// Token: 0x04002E29 RID: 11817
		private Label label25;

		// Token: 0x04002E38 RID: 11832
		private Label label26;

		// Token: 0x04002E39 RID: 11833
		private Label label27;

		// Token: 0x04002E3A RID: 11834
		private Label label28;

		// Token: 0x04002E3D RID: 11837
		private Label label29;

		// Token: 0x04002DED RID: 11757
		private Label label3;

		// Token: 0x04002E48 RID: 11848
		private Label label30;

		// Token: 0x04002E62 RID: 11874
		private Label label31;

		// Token: 0x04002E49 RID: 11849
		private Label label32;

		// Token: 0x04002E4A RID: 11850
		private Label label33;

		// Token: 0x04002E4B RID: 11851
		private Label label34;

		// Token: 0x04002E4F RID: 11855
		private Label label35;

		// Token: 0x04002E50 RID: 11856
		private Label label36;

		// Token: 0x04002E51 RID: 11857
		private Label label37;

		// Token: 0x04002E70 RID: 11888
		private Label label38;

		// Token: 0x04002E4E RID: 11854
		private Label label39;

		// Token: 0x04002DF7 RID: 11767
		private Label label4;

		// Token: 0x04002E4D RID: 11853
		private Label label40;

		// Token: 0x04002E4C RID: 11852
		private Label label41;

		// Token: 0x04002E54 RID: 11860
		private Label label42;

		// Token: 0x04002E53 RID: 11859
		private Label label43;

		// Token: 0x04002E52 RID: 11858
		private Label label44;

		// Token: 0x04002E57 RID: 11863
		private Label label45;

		// Token: 0x04002E58 RID: 11864
		private Label label46;

		// Token: 0x04002E59 RID: 11865
		private Label label47;

		// Token: 0x04002E56 RID: 11862
		private Label label48;

		// Token: 0x04002E5C RID: 11868
		private Label label49;

		// Token: 0x04002DFB RID: 11771
		private Label label5;

		// Token: 0x04002E5D RID: 11869
		private Label label50;

		// Token: 0x04002E65 RID: 11877
		private Label label52;

		// Token: 0x04002E1D RID: 11805
		private Label label6;

		// Token: 0x04002DF8 RID: 11768
		private Label label7;

		// Token: 0x04002DF9 RID: 11769
		private Label label8;

		// Token: 0x04002E09 RID: 11785
		private LinkLabel linkLabel1;

		// Token: 0x04002E08 RID: 11784
		private LinkLabel linkLabel2;

		// Token: 0x04002E19 RID: 11801
		private LinkLabel linkLabel4;

		// Token: 0x04002E2D RID: 11821
		private LinkLabel linkLabel5;

		// Token: 0x04002E67 RID: 11879
		private ListBox listSampleset;

		// Token: 0x04002DFA RID: 11770
		private TrackBar overallDifficulty;

		// Token: 0x04002E68 RID: 11880
		private Panel panel1;

		// Token: 0x04002E6C RID: 11884
		private Panel panel10;

		// Token: 0x04002E6D RID: 11885
		private Panel panel11;

		// Token: 0x04002E69 RID: 11881
		private Panel panel2;

		// Token: 0x04002E6A RID: 11882
		private Panel panel3;

		// Token: 0x04002E6B RID: 11883
		private Panel panel4;

		// Token: 0x04002E6F RID: 11887
		private Panel panel5;

		// Token: 0x04002E35 RID: 11829
		private Panel panelCountdownRate;

		// Token: 0x04002E61 RID: 11873
		private Panel panelRomanisedArtist;

		// Token: 0x04002E64 RID: 11876
		private Panel panelRomanisedTitle;

		// Token: 0x04002DEA RID: 11754
		private PlayModes playModes_0;

		// Token: 0x04002E76 RID: 11894
		[CompilerGenerated]
		private static Predicate<string> predicate_0;

		// Token: 0x04002E0A RID: 11786
		private CheckBox sampleCustom;

		// Token: 0x04002E44 RID: 11844
		private ComboBox skinPreference;

		// Token: 0x04002E3C RID: 11836
		private TextBox source;

		// Token: 0x04002E3B RID: 11835
		private TrackBar stackLeniency;

		// Token: 0x04002E13 RID: 11795
		private TabControl tabControl1;

		// Token: 0x04002E14 RID: 11796
		private TabPage tabPage1;

		// Token: 0x04002E16 RID: 11798
		private TabPage tabPage2;

		// Token: 0x04002E17 RID: 11799
		private TabPage tabPage3;

		// Token: 0x04002E15 RID: 11797
		private TabPage tabPage4;

		// Token: 0x04002E21 RID: 11809
		private TabPage tabPage5;

		// Token: 0x04002E22 RID: 11810
		private TabPage tabPage6;

		// Token: 0x04002E3F RID: 11839
		private TextBox tags;

		// Token: 0x04002E40 RID: 11840
		private Label tagsLabel;

		// Token: 0x04002E26 RID: 11814
		private TextBox textBox7;

		// Token: 0x04002E2A RID: 11818
		private TextBox textBox8;

		// Token: 0x04002E2B RID: 11819
		private TextBox textBox9;

		// Token: 0x04002DEE RID: 11758
		private TextBox title;

		// Token: 0x04002E66 RID: 11878
		private TextBox titleRomanised;

		// Token: 0x04002E3E RID: 11838
		private ToolTip toolTip_0;

		// Token: 0x04002E5B RID: 11867
		private NumericUpDown udCountdownOffset;

		// Token: 0x04002E1C RID: 11804
		private ComboBox version;

		// Token: 0x04002E18 RID: 11800
		private TrackBar volume1;

		// Token: 0x0600321E RID: 12830
		// RVA: 0x00149384 File Offset: 0x00147584
		internal SongSetup(bool bool_7, bool bool_8)
		{
			this.bool_1 = bool_7;
			this.bool_2 = bool_8;
			this.editor_0 = Editor.editor_0;
			this.InitializeComponent();
			if (Application.RenderWithVisualStyles)
			{
				foreach (TabPage tabPage in this.tabControl1.TabPages)
				{
					tabPage.BackColor = SystemColors.ControlLightLight;
				}
				foreach (Control control in base.Controls)
				{
					if (control is TrackBar)
					{
						TrackBar trackBar = (TrackBar)control;
						trackBar.BackColor = SystemColors.ControlLightLight;
					}
				}
			}
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x06003249 RID: 12873
		// RVA: 0x0014AA6C File Offset: 0x00148C6C
		private void allowedModes_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.allowedModes.SelectedIndex == 3)
			{
				this.method_11(this.circleSize, Class466.Current.DifficultyCircleSize / (float)(this.coopmode.Checked ? 2 : 1), 1f, 9f, 1.0);
				this.coopmode.Visible = true;
			}
			else
			{
				this.method_11(this.circleSize, Class466.Current.DifficultyCircleSize, 2f, 7f, 10.0);
				this.coopmode.Visible = false;
			}
			this.bool_6 = true;
		}

		// Token: 0x0600323F RID: 12863
		// RVA: 0x00024FF8 File Offset: 0x000231F8
		private void allowedModes_TextChanged(object sender, EventArgs e)
		{
			this.bool_6 = true;
		}

		// Token: 0x0600323C RID: 12860
		// RVA: 0x0014A360 File Offset: 0x00148560
		private void approachRate_Scroll(object sender, EventArgs e)
		{
			TrackBar trackBar = sender as TrackBar;
			if (!this.bool_5)
			{
				trackBar.Value = (int)Math.Round((double)trackBar.Value / 10.0) * 10;
			}
			this.method_12(trackBar, 0.1);
			this.bool_6 = true;
		}

		// Token: 0x0600323E RID: 12862
		// RVA: 0x0014A6D4 File Offset: 0x001488D4
		private void artist_TextChanged(object sender, EventArgs e)
		{
			string a = Class34.smethod_19(this.artist.Text);
			bool flag;
			if (flag = (a == this.artist.Text))
			{
				this.artistRomanised.Text = this.artist.Text;
			}
			this.panelRomanisedArtist.Enabled = !flag;
			this.artistRomanised.Text = Class34.smethod_19(this.artistRomanised.Text);
			this.bool_6 = true;
		}

		// Token: 0x06003232 RID: 12850
		// RVA: 0x0014A528 File Offset: 0x00148728
		private void backgroundColour_Click(object sender, EventArgs e)
		{
			this.colorDialog_0.Color = this.backgroundColour.BackColor;
			if (this.colorDialog_0.ShowDialog() == DialogResult.OK)
			{
				this.backgroundColour.method_1(this.colorDialog_0.Color);
				this.bool_6 = true;
			}
		}

		// Token: 0x06003228 RID: 12840
		// RVA: 0x00024F7F File Offset: 0x0002317F
		private void button1_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x06003236 RID: 12854
		// RVA: 0x0014A578 File Offset: 0x00148778
		private void buttonAddCombo_Click(object sender, EventArgs e)
		{
			int num = this.method_10();
			this.colorDialog_0.Color = Color.FromArgb(240, 240, 240);
			if (this.colorDialog_0.ShowDialog() == DialogResult.OK)
			{
				this.class616_0[num].method_1(this.colorDialog_0.Color);
				this.class616_0[num].Visible = true;
				this.class616_0[num].bool_1 = true;
				this.method_9();
				this.customColour.Checked = true;
				this.bool_6 = true;
			}
		}

		// Token: 0x0600322C RID: 12844
		// RVA: 0x0014A4A8 File Offset: 0x001486A8
		private void buttonClap_Click(object sender, EventArgs e)
		{
			Struct69 struct69_ = this.method_13();
			struct69_.hitObjectSoundType_0 = HitObjectSoundType.Clap;
			Class331.smethod_62(struct69_, 0f, false);
		}

		// Token: 0x0600322B RID: 12843
		// RVA: 0x0014A480 File Offset: 0x00148680
		private void buttonFinish_Click(object sender, EventArgs e)
		{
			Struct69 struct69_ = this.method_13();
			struct69_.hitObjectSoundType_0 = HitObjectSoundType.Finish;
			Class331.smethod_62(struct69_, 0f, false);
		}

		// Token: 0x06003229 RID: 12841
		// RVA: 0x0014A430 File Offset: 0x00148630
		private void buttonHit_Click(object sender, EventArgs e)
		{
			Struct69 struct69_ = this.method_13();
			struct69_.hitObjectSoundType_0 = HitObjectSoundType.Normal;
			Class331.smethod_62(struct69_, 0f, false);
		}

		// Token: 0x06003224 RID: 12836
		// RVA: 0x00149D98 File Offset: 0x00147F98
		private void buttonOk_Click(object sender, EventArgs e)
		{
			if (!this.bool_6)
			{
				base.DialogResult = DialogResult.OK;
				base.Close();
				return;
			}
			PlayModes selectedIndex = (PlayModes)this.allowedModes.SelectedIndex;
			if (selectedIndex == PlayModes.OsuMania && this.playModes_0 != selectedIndex)
			{
				if (MessageBox.Show("You changed play mode, do you want to save changes and clear all notes?", "Song Setup", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
				{
					return;
				}
				this.editor_0.class297_0.Clear();
			}
			else if (this.bool_2 && MessageBox.Show("Do you want to save changes to this beatmap?", "Song Setup", MessageBoxButtons.OKCancel) != DialogResult.OK)
			{
				return;
			}
			Class297 class297_ = this.editor_0.class297_0;
			Class296 class296_ = class297_.class296_0;
			class296_.Title = this.titleRomanised.Text;
			class296_.TitleUnicode = this.title.Text;
			class296_.Artist = this.artistRomanised.Text;
			class296_.ArtistUnicode = this.artist.Text;
			class296_.string_5 = this.creator.Text;
			class296_.string_14 = this.version.Text;
			class296_.string_13 = this.source.Text;
			class296_.Tags = this.tags.Text;
			class296_.DifficultyHpDrainRate = (float)this.hpDrainRate.Value / 10f;
			class296_.DifficultyOverall = (float)this.overallDifficulty.Value / 10f;
			class296_.DifficultyCircleSize = ((this.allowedModes.SelectedIndex == 3) ? ((float)(this.circleSize.Value * (this.coopmode.Checked ? 2 : 1))) : ((float)this.circleSize.Value / 10f));
			class296_.DifficultyApproachRate = (float)this.approachRate.Value / 10f;
			class296_.float_1 = (float)this.stackLeniency.Value / 10f;
			class296_.bool_21 = this.checkEpilepsy.Checked;
			class296_.int_8 = (int)this.udCountdownOffset.Value;
			if (this.bool_1)
			{
				class296_.int_2 = 0;
			}
			class296_.method_6(selectedIndex);
			if (class296_.method_5() == PlayModes.OsuMania)
			{
				class296_.DifficultyCircleSize = Math.Min(18f, Math.Max(class296_.DifficultyCircleSize, 1f));
				class296_.bool_16 = this.cb_maniaSpecial.Checked;
			}
			Class885.smethod_10(class297_);
			class296_.string_11 = ((this.skinPreference.SelectedIndex > 0) ? this.skinPreference.Text : "");
			class296_.bool_11 = this.checkLetterbox.Checked;
			class296_.bool_12 = this.checkWidescreen.Checked;
			class296_.bool_14 = !this.checkStoryOverFire.Checked;
			if (!this.checkCountdown.Checked)
			{
				class296_.enum65_0 = Enum65.const_0;
			}
			else if (this.countdownNormal.Checked)
			{
				class296_.enum65_0 = Enum65.const_1;
			}
			else if (this.countdownHalf.Checked)
			{
				class296_.enum65_0 = Enum65.const_2;
			}
			else if (this.countdownDouble.Checked)
			{
				class296_.enum65_0 = Enum65.const_3;
			}
			class296_.int_15 = this.volume1.Value;
			class296_.bool_5 = this.customColour.Checked;
			if (this.checkSamplesMatchPlaybackRate.Enabled)
			{
				class296_.bool_17 = this.checkSamplesMatchPlaybackRate.Checked;
			}
			if (this.customColour.Checked)
			{
				int capacity = this.method_10();
				List<Color> list = new List<Color>(capacity);
				int i = 0;
				while (i < 8 && this.class616_0[i].bool_1)
				{
					list.Add(this.class616_0[i].method_0());
					i++;
				}
				list.Insert(0, list[list.Count - 1]);
				list.RemoveAt(list.Count - 1);
				for (i = 0; i < list.Count; i++)
				{
					Class885.dictionary_6["Combo" + (i + 1).ToString()] = new Color(list[i].R, list[i].G, list[i].B);
				}
				while (i < 8)
				{
					Class885.dictionary_6["Combo" + (i + 1).ToString()] = Color.get_TransparentBlack();
					i++;
				}
			}
			if (Class872.class872_0 != null)
			{
				Class872.class872_0.method_3(new Color(this.backgroundColour.method_0().R, this.backgroundColour.method_0().G, this.backgroundColour.method_0().B));
			}
			Struct69 struct = this.method_13();
			if (Class331.smethod_14().Count > 0)
			{
				if (this.bool_3)
				{
					foreach (Class340 current in Class331.smethod_14())
					{
						current.sampleSet_0 = struct.sampleSet_0;
						current.enum38_0 = struct.enum38_0;
					}
				}
				if (this.bool_4)
				{
					foreach (Class340 current2 in Class331.smethod_14())
					{
						current2.int_0 = struct.int_0;
					}
				}
			}
			base.Enabled = false;
			base.Invalidate();
			class297_.vmethod_8(false, false);
			this.editor_0.method_30(true, false);
			if (!class297_.method_3(false, this.bool_1, false))
			{
				base.DialogResult = DialogResult.Cancel;
			}
			else
			{
				base.DialogResult = DialogResult.OK;
			}
			this.editor_0.method_3(class296_, false, false);
			base.Close();
		}

		// Token: 0x06003237 RID: 12855
		// RVA: 0x0014A608 File Offset: 0x00148808
		private void buttonRemoveCombo_Click(object sender, EventArgs e)
		{
			int num = this.method_10();
			this.class616_0[num - 1].Visible = false;
			this.class616_0[num - 1].bool_1 = false;
			this.method_9();
			this.customColour.Checked = true;
			this.bool_6 = true;
		}

		// Token: 0x06003239 RID: 12857
		// RVA: 0x0002500E File Offset: 0x0002320E
		private void buttonSampleReset_Click(object sender, EventArgs e)
		{
			this.hideSampleSettings.Visible = false;
			this.bool_3 = true;
			this.bool_6 = true;
		}

		// Token: 0x0600323A RID: 12858
		// RVA: 0x0002502A File Offset: 0x0002322A
		private void buttonVolumeReset_Click(object sender, EventArgs e)
		{
			this.hideSampleVolume.Visible = false;
			this.bool_4 = true;
			this.bool_6 = true;
		}

		// Token: 0x0600322A RID: 12842
		// RVA: 0x0014A458 File Offset: 0x00148658
		private void buttonWhistle_Click(object sender, EventArgs e)
		{
			Struct69 struct69_ = this.method_13();
			struct69_.hitObjectSoundType_0 = HitObjectSoundType.Whistle;
			Class331.smethod_62(struct69_, 0f, false);
		}

		// Token: 0x06003248 RID: 12872
		// RVA: 0x00024FF8 File Offset: 0x000231F8
		private void cb_maniaSpecial_CheckedChanged(object sender, EventArgs e)
		{
			this.bool_6 = true;
		}

		// Token: 0x0600323B RID: 12859
		// RVA: 0x00025046 File Offset: 0x00023246
		private void checkCountdown_CheckedChanged(object sender, EventArgs e)
		{
			this.panelCountdownRate.Enabled = this.checkCountdown.Checked;
			this.bool_6 = true;
		}

		// Token: 0x06003227 RID: 12839
		// RVA: 0x0014A3B4 File Offset: 0x001485B4
		private void circleSize_Scroll(object sender, EventArgs e)
		{
			TrackBar trackBar = sender as TrackBar;
			if (this.allowedModes.SelectedIndex != 3 && !this.bool_5)
			{
				trackBar.Value = (int)Math.Round((double)trackBar.Value / 10.0) * 10;
			}
			this.method_12(trackBar, (this.allowedModes.SelectedIndex == 3) ? 1.0 : 0.1);
			this.bool_6 = true;
		}

		// Token: 0x0600324A RID: 12874
		// RVA: 0x0014AB10 File Offset: 0x00148D10
		private void circleSize_ValueChanged(object sender, EventArgs e)
		{
			this.coopmode.Enabled = (Class466.Current.method_5() == PlayModes.OsuMania && this.circleSize.Value >= 5);
			if (!this.coopmode.Enabled)
			{
				this.coopmode.Checked = false;
			}
		}

		// Token: 0x06003230 RID: 12848
		// RVA: 0x0014A4D0 File Offset: 0x001486D0
		private void combo1_Click(object sender, EventArgs e)
		{
			Class616 class = (Class616)sender;
			this.colorDialog_0.Color = class.method_0();
			if (this.colorDialog_0.ShowDialog() == DialogResult.OK)
			{
				class.method_1(this.colorDialog_0.Color);
				this.customColour.Checked = true;
				this.bool_6 = true;
			}
		}

		// Token: 0x0600324B RID: 12875
		// RVA: 0x00024FF8 File Offset: 0x000231F8
		private void coopmode_CheckedChanged(object sender, EventArgs e)
		{
			this.bool_6 = true;
		}

		// Token: 0x0600322F RID: 12847
		// RVA: 0x00024FA8 File Offset: 0x000231A8
		private void customColour_CheckedChanged(object sender, EventArgs e)
		{
			this.method_9();
			this.bool_6 = true;
		}

		// Token: 0x0600324C RID: 12876
		// RVA: 0x00025083 File Offset: 0x00023283
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06003225 RID: 12837
		// RVA: 0x0014A360 File Offset: 0x00148560
		private void hpDrainRate_Scroll(object sender, EventArgs e)
		{
			TrackBar trackBar = sender as TrackBar;
			if (!this.bool_5)
			{
				trackBar.Value = (int)Math.Round((double)trackBar.Value / 10.0) * 10;
			}
			this.method_12(trackBar, 0.1);
			this.bool_6 = true;
		}

		// Token: 0x0600324D RID: 12877
		// RVA: 0x0014AB64 File Offset: 0x00148D64
		private void InitializeComponent()
		{
			this.icontainer_0 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(SongSetup));
			this.colorDialog_0 = new ColorDialog();
			this.comboBox1 = new ComboBox();
			this.label16 = new Label();
			this.textBox7 = new TextBox();
			this.label23 = new Label();
			this.label24 = new Label();
			this.label25 = new Label();
			this.textBox8 = new TextBox();
			this.textBox9 = new TextBox();
			this.toolTip_0 = new ToolTip(this.icontainer_0);
			this.source = new TextBox();
			this.version = new ComboBox();
			this.tags = new TextBox();
			this.cb_maniaSpecial = new CheckBox();
			this.buttonOk = new Button();
			this.button1 = new Button();
			this.tabControl1 = new TabControl();
			this.tabPage1 = new TabPage();
			this.groupBox1 = new GroupBox();
			this.panelRomanisedArtist = new Panel();
			this.label31 = new Label();
			this.artistRomanised = new TextBox();
			this.panelRomanisedTitle = new Panel();
			this.label52 = new Label();
			this.titleRomanised = new TextBox();
			this.label29 = new Label();
			this.label14 = new Label();
			this.title = new TextBox();
			this.label3 = new Label();
			this.label1 = new Label();
			this.artistLabel = new Label();
			this.creator = new TextBox();
			this.artist = new TextBox();
			this.tagsLabel = new Label();
			this.groupBox5 = new GroupBox();
			this.panel10 = new Panel();
			this.label30 = new Label();
			this.linkLabel2 = new LinkLabel();
			this.linkLabel1 = new LinkLabel();
			this.tabPage4 = new TabPage();
			this.groupBox2 = new GroupBox();
			this.coopmode = new CheckBox();
			this.label41 = new Label();
			this.label40 = new Label();
			this.label39 = new Label();
			this.label48 = new Label();
			this.label17 = new Label();
			this.label45 = new Label();
			this.label46 = new Label();
			this.label47 = new Label();
			this.approachRate = new TrackBar();
			this.label10 = new Label();
			this.label11 = new Label();
			this.label12 = new Label();
			this.label13 = new Label();
			this.circleSize = new TrackBar();
			this.label6 = new Label();
			this.label7 = new Label();
			this.label8 = new Label();
			this.overallDifficulty = new TrackBar();
			this.label5 = new Label();
			this.label4 = new Label();
			this.label2 = new Label();
			this.hpDrainRate = new TrackBar();
			this.tabPage2 = new TabPage();
			this.groupBox4 = new GroupBox();
			this.checkSamplesMatchPlaybackRate = new CheckBox();
			this.groupBox3 = new GroupBox();
			this.hideSampleSettings = new Panel();
			this.buttonSampleReset = new Button();
			this.label34 = new Label();
			this.panel11 = new Panel();
			this.listSampleset = new ListBox();
			this.panel1 = new Panel();
			this.label32 = new Label();
			this.buttonClap = new Button();
			this.hideSampleVolume = new Panel();
			this.buttonVolumeReset = new Button();
			this.label33 = new Label();
			this.label15 = new Label();
			this.volume1 = new TrackBar();
			this.buttonHit = new Button();
			this.linkLabel4 = new LinkLabel();
			this.buttonWhistle = new Button();
			this.sampleCustom = new CheckBox();
			this.buttonFinish = new Button();
			this.tabPage3 = new TabPage();
			this.groupBox8 = new GroupBox();
			this.panel2 = new Panel();
			this.label35 = new Label();
			this.backgroundColour = new Class616();
			this.groupBox6 = new GroupBox();
			this.combo8 = new Class616();
			this.combo7 = new Class616();
			this.combo6 = new Class616();
			this.buttonRemoveCombo = new Button();
			this.buttonAddCombo = new Button();
			this.combo5 = new Class616();
			this.combo4 = new Class616();
			this.combo3 = new Class616();
			this.combo2 = new Class616();
			this.combo1 = new Class616();
			this.customColour = new CheckBox();
			this.tabPage5 = new TabPage();
			this.groupBox12 = new GroupBox();
			this.label44 = new Label();
			this.skinPreference = new ComboBox();
			this.groupBox11 = new GroupBox();
			this.checkEpilepsy = new CheckBox();
			this.checkStoryOverFire = new CheckBox();
			this.checkLetterbox = new CheckBox();
			this.checkWidescreen = new CheckBox();
			this.groupBox7 = new GroupBox();
			this.panel3 = new Panel();
			this.label36 = new Label();
			this.panelCountdownRate = new Panel();
			this.udCountdownOffset = new NumericUpDown();
			this.label49 = new Label();
			this.label50 = new Label();
			this.label43 = new Label();
			this.countdownDouble = new RadioButton();
			this.countdownNormal = new RadioButton();
			this.countdownHalf = new RadioButton();
			this.linkLabel5 = new LinkLabel();
			this.checkCountdown = new CheckBox();
			this.tabPage6 = new TabPage();
			this.groupBox10 = new GroupBox();
			this.panel5 = new Panel();
			this.label38 = new Label();
			this.label42 = new Label();
			this.allowedModes = new ComboBox();
			this.groupBox9 = new GroupBox();
			this.panel4 = new Panel();
			this.label37 = new Label();
			this.label26 = new Label();
			this.label27 = new Label();
			this.label28 = new Label();
			this.stackLeniency = new TrackBar();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panelRomanisedArtist.SuspendLayout();
			this.panelRomanisedTitle.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.panel10.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((ISupportInitialize)this.approachRate).BeginInit();
			((ISupportInitialize)this.circleSize).BeginInit();
			((ISupportInitialize)this.overallDifficulty).BeginInit();
			((ISupportInitialize)this.hpDrainRate).BeginInit();
			this.tabPage2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.hideSampleSettings.SuspendLayout();
			this.panel11.SuspendLayout();
			this.panel1.SuspendLayout();
			this.hideSampleVolume.SuspendLayout();
			((ISupportInitialize)this.volume1).BeginInit();
			this.tabPage3.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.groupBox12.SuspendLayout();
			this.groupBox11.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panelCountdownRate.SuspendLayout();
			((ISupportInitialize)this.udCountdownOffset).BeginInit();
			this.tabPage6.SuspendLayout();
			this.groupBox10.SuspendLayout();
			this.panel5.SuspendLayout();
			this.groupBox9.SuspendLayout();
			this.panel4.SuspendLayout();
			((ISupportInitialize)this.stackLeniency).BeginInit();
			base.SuspendLayout();
			this.colorDialog_0.FullOpen = true;
			this.comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[]
			{
				"Easy",
				"Normal",
				"Hard",
				"Insane"
			});
			this.comboBox1.Location = new Point(108, 96);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new Size(240, 21);
			this.comboBox1.TabIndex = 36;
			this.label16.AutoSize = true;
			this.label16.Location = new Point(55, 99);
			this.label16.Name = "label16";
			this.label16.Size = new Size(47, 13);
			this.label16.TabIndex = 15;
			this.label16.Text = "Difficulty";
			this.textBox7.Location = new Point(107, 44);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new Size(241, 20);
			this.textBox7.TabIndex = 1;
			this.label23.AutoSize = true;
			this.label23.Location = new Point(76, 47);
			this.label23.Name = "label23";
			this.label23.Size = new Size(27, 13);
			this.label23.TabIndex = 8;
			this.label23.Text = "Title";
			this.label24.AutoSize = true;
			this.label24.Location = new Point(17, 73);
			this.label24.Name = "label24";
			this.label24.Size = new Size(86, 13);
			this.label24.TabIndex = 13;
			this.label24.Text = "Beatmap Creator";
			this.label25.AutoSize = true;
			this.label25.Location = new Point(73, 21);
			this.label25.Name = "label25";
			this.label25.Size = new Size(30, 13);
			this.label25.TabIndex = 10;
			this.label25.Text = "Artist";
			this.textBox8.Location = new Point(107, 70);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new Size(241, 20);
			this.textBox8.TabIndex = 2;
			this.textBox9.Location = new Point(107, 18);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new Size(241, 20);
			this.textBox9.TabIndex = 0;
			this.toolTip_0.AutomaticDelay = 200;
			this.source.Location = new Point(141, 170);
			this.source.Name = "source";
			this.source.Size = new Size(218, 20);
			this.source.TabIndex = 6;
			this.toolTip_0.SetToolTip(this.source, "If this song is from a series/game, name it here.");
			this.source.TextChanged += new EventHandler(this.allowedModes_TextChanged);
			this.version.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.version.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.version.FormattingEnabled = true;
			this.version.Items.AddRange(new object[]
			{
				"Easy",
				"Normal",
				"Hard",
				"Insane"
			});
			this.version.Location = new Point(141, 145);
			this.version.Name = "version";
			this.version.Size = new Size(218, 21);
			this.version.TabIndex = 5;
			this.toolTip_0.SetToolTip(this.version, "While defaults in the drop-down are well-known, you may use any difficulty name you like.");
			this.version.TextChanged += new EventHandler(this.allowedModes_TextChanged);
			this.tags.Location = new Point(141, 195);
			this.tags.Name = "tags";
			this.tags.Size = new Size(218, 20);
			this.tags.TabIndex = 7;
			this.toolTip_0.SetToolTip(this.tags, "Any words which can be used to identify this beatmap.  Separate with spaces.");
			this.tags.TextChanged += new EventHandler(this.allowedModes_TextChanged);
			this.cb_maniaSpecial.AutoSize = true;
			this.cb_maniaSpecial.Location = new Point(8, 45);
			this.cb_maniaSpecial.Name = "cb_maniaSpecial";
			this.cb_maniaSpecial.Size = new Size(223, 19);
			this.cb_maniaSpecial.TabIndex = 53;
			this.cb_maniaSpecial.Text = "Use special style(N+1 style) for mania";
			this.toolTip_0.SetToolTip(this.cb_maniaSpecial, "Notice: The left most column is used as special column");
			this.cb_maniaSpecial.UseVisualStyleBackColor = true;
			this.cb_maniaSpecial.CheckedChanged += new EventHandler(this.cb_maniaSpecial_CheckedChanged);
			this.buttonOk.FlatStyle = FlatStyle.System;
			this.buttonOk.Location = new Point(4, 392);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new Size(232, 34);
			this.buttonOk.TabIndex = 1;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new EventHandler(this.buttonOk_Click);
			this.button1.DialogResult = DialogResult.OK;
			this.button1.FlatStyle = FlatStyle.System;
			this.button1.Location = new Point(242, 392);
			this.button1.Name = "button1";
			this.button1.Size = new Size(139, 34);
			this.button1.TabIndex = 2;
			this.button1.Text = "Cancel";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Controls.Add(this.tabPage6);
			this.tabControl1.Dock = DockStyle.Top;
			this.tabControl1.Location = new Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new Size(385, 386);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.SelectedIndexChanged += new EventHandler(this.tabControl1_SelectedIndexChanged);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Controls.Add(this.groupBox5);
			this.tabPage1.Location = new Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new Padding(3);
			this.tabPage1.Size = new Size(377, 360);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "General";
			this.groupBox1.Controls.Add(this.panelRomanisedArtist);
			this.groupBox1.Controls.Add(this.panelRomanisedTitle);
			this.groupBox1.Controls.Add(this.source);
			this.groupBox1.Controls.Add(this.label29);
			this.groupBox1.Controls.Add(this.version);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.title);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.artistLabel);
			this.groupBox1.Controls.Add(this.creator);
			this.groupBox1.Controls.Add(this.artist);
			this.groupBox1.Controls.Add(this.tags);
			this.groupBox1.Controls.Add(this.tagsLabel);
			this.groupBox1.Location = new Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new Size(365, 223);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Song and Map Metadata";
			this.panelRomanisedArtist.Controls.Add(this.label31);
			this.panelRomanisedArtist.Controls.Add(this.artistRomanised);
			this.panelRomanisedArtist.Enabled = false;
			this.panelRomanisedArtist.Location = new Point(5, 45);
			this.panelRomanisedArtist.Name = "panelRomanisedArtist";
			this.panelRomanisedArtist.Size = new Size(356, 23);
			this.panelRomanisedArtist.TabIndex = 1;
			this.label31.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.label31.Location = new Point(1, 2);
			this.label31.Name = "label31";
			this.label31.Size = new Size(131, 16);
			this.label31.TabIndex = 46;
			this.label31.Text = "Romanised Artist";
			this.label31.TextAlign = ContentAlignment.TopRight;
			this.artistRomanised.Location = new Point(136, 0);
			this.artistRomanised.Name = "artistRomanised";
			this.artistRomanised.Size = new Size(218, 20);
			this.artistRomanised.TabIndex = 1;
			this.artistRomanised.TextChanged += new EventHandler(this.artist_TextChanged);
			this.panelRomanisedTitle.Controls.Add(this.label52);
			this.panelRomanisedTitle.Controls.Add(this.titleRomanised);
			this.panelRomanisedTitle.Enabled = false;
			this.panelRomanisedTitle.Location = new Point(6, 95);
			this.panelRomanisedTitle.Name = "panelRomanisedTitle";
			this.panelRomanisedTitle.Size = new Size(355, 23);
			this.panelRomanisedTitle.TabIndex = 3;
			this.label52.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.label52.Location = new Point(0, 2);
			this.label52.Name = "label52";
			this.label52.Size = new Size(131, 16);
			this.label52.TabIndex = 47;
			this.label52.Text = "Romanised Title";
			this.label52.TextAlign = ContentAlignment.TopRight;
			this.titleRomanised.Location = new Point(135, 0);
			this.titleRomanised.Name = "titleRomanised";
			this.titleRomanised.Size = new Size(218, 20);
			this.titleRomanised.TabIndex = 3;
			this.titleRomanised.TextChanged += new EventHandler(this.title_TextChanged);
			this.label29.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.label29.Location = new Point(32, 172);
			this.label29.Name = "label29";
			this.label29.Size = new Size(105, 16);
			this.label29.TabIndex = 37;
			this.label29.Text = "Source";
			this.label29.TextAlign = ContentAlignment.TopRight;
			this.label14.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.label14.Location = new Point(32, 147);
			this.label14.Name = "label14";
			this.label14.Size = new Size(105, 16);
			this.label14.TabIndex = 15;
			this.label14.Text = "Difficulty";
			this.label14.TextAlign = ContentAlignment.TopRight;
			this.title.Location = new Point(141, 70);
			this.title.Name = "title";
			this.title.Size = new Size(218, 20);
			this.title.TabIndex = 2;
			this.title.TextChanged += new EventHandler(this.title_TextChanged);
			this.label3.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.label3.Location = new Point(32, 72);
			this.label3.Name = "label3";
			this.label3.Size = new Size(105, 16);
			this.label3.TabIndex = 8;
			this.label3.Text = "Title";
			this.label3.TextAlign = ContentAlignment.TopRight;
			this.label1.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.label1.Location = new Point(5, 122);
			this.label1.Name = "label1";
			this.label1.Size = new Size(132, 16);
			this.label1.TabIndex = 13;
			this.label1.Text = "Beatmap Creator";
			this.label1.TextAlign = ContentAlignment.TopRight;
			this.artistLabel.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.artistLabel.Location = new Point(32, 22);
			this.artistLabel.Name = "artistLabel";
			this.artistLabel.Size = new Size(105, 16);
			this.artistLabel.TabIndex = 10;
			this.artistLabel.Text = "Artist";
			this.artistLabel.TextAlign = ContentAlignment.TopRight;
			this.creator.Location = new Point(141, 120);
			this.creator.Name = "creator";
			this.creator.Size = new Size(218, 20);
			this.creator.TabIndex = 4;
			this.creator.TextChanged += new EventHandler(this.allowedModes_TextChanged);
			this.artist.Location = new Point(141, 20);
			this.artist.Name = "artist";
			this.artist.Size = new Size(218, 20);
			this.artist.TabIndex = 0;
			this.artist.TextChanged += new EventHandler(this.artist_TextChanged);
			this.tagsLabel.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.tagsLabel.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.tagsLabel.Location = new Point(32, 197);
			this.tagsLabel.Name = "tagsLabel";
			this.tagsLabel.Size = new Size(105, 16);
			this.tagsLabel.TabIndex = 39;
			this.tagsLabel.Text = "Tags";
			this.tagsLabel.TextAlign = ContentAlignment.TopRight;
			this.groupBox5.Controls.Add(this.panel10);
			this.groupBox5.Controls.Add(this.linkLabel2);
			this.groupBox5.Controls.Add(this.linkLabel1);
			this.groupBox5.Location = new Point(6, 234);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new Size(365, 118);
			this.groupBox5.TabIndex = 6;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "A quick note";
			this.panel10.Controls.Add(this.label30);
			this.panel10.Location = new Point(6, 18);
			this.panel10.Name = "panel10";
			this.panel10.Size = new Size(353, 70);
			this.panel10.TabIndex = 42;
			this.label30.Dock = DockStyle.Fill;
			this.label30.ForeColor = Color.Red;
			this.label30.Location = new Point(0, 0);
			this.label30.Name = "label30";
			this.label30.Size = new Size(353, 70);
			this.label30.TabIndex = 41;
			this.label30.Text = "Due to the large number of beatmap submissions, the standard of approval is relatively high.  Please ensure your beatmap is at least timed properly, or it will likely be ignored!";
			this.linkLabel2.ActiveLinkColor = SystemColors.Highlight;
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.LinkColor = SystemColors.HotTrack;
			this.linkLabel2.Location = new Point(182, 91);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new Size(150, 15);
			this.linkLabel2.TabIndex = 34;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Official Submission Criteria";
			this.linkLabel2.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			this.linkLabel1.ActiveLinkColor = SystemColors.Highlight;
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.LinkColor = SystemColors.HotTrack;
			this.linkLabel1.Location = new Point(31, 91);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new Size(100, 15);
			this.linkLabel1.TabIndex = 33;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Editor Guide/FAQ";
			this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			this.tabPage4.Controls.Add(this.groupBox2);
			this.tabPage4.Location = new Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new Size(377, 360);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Difficulty";
			this.tabPage4.Enter += new EventHandler(this.tabPage4_Enter);
			this.groupBox2.Controls.Add(this.coopmode);
			this.groupBox2.Controls.Add(this.label41);
			this.groupBox2.Controls.Add(this.label40);
			this.groupBox2.Controls.Add(this.label39);
			this.groupBox2.Controls.Add(this.label48);
			this.groupBox2.Controls.Add(this.label17);
			this.groupBox2.Controls.Add(this.label45);
			this.groupBox2.Controls.Add(this.label46);
			this.groupBox2.Controls.Add(this.label47);
			this.groupBox2.Controls.Add(this.approachRate);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.circleSize);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.overallDifficulty);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.hpDrainRate);
			this.groupBox2.Location = new Point(4, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new Size(365, 351);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Difficulty";
			this.coopmode.AutoSize = true;
			this.coopmode.Location = new Point(12, 124);
			this.coopmode.Name = "coopmode";
			this.coopmode.Size = new Size(94, 19);
			this.coopmode.TabIndex = 60;
			this.coopmode.Text = "Co-op mode";
			this.coopmode.UseVisualStyleBackColor = true;
			this.coopmode.CheckedChanged += new EventHandler(this.coopmode_CheckedChanged);
			this.label41.Location = new Point(9, 293);
			this.label41.Name = "label41";
			this.label41.Size = new Size(350, 25);
			this.label41.TabIndex = 49;
			this.label41.Text = "The harshness of the hit window and the difficulty of spinners";
			this.label40.Location = new Point(9, 145);
			this.label40.Name = "label40";
			this.label40.Size = new Size(350, 19);
			this.label40.TabIndex = 48;
			this.label40.Text = "The radial size of hit circles and sliders";
			this.label39.Location = new Point(9, 69);
			this.label39.Name = "label39";
			this.label39.Size = new Size(350, 21);
			this.label39.TabIndex = 47;
			this.label39.Text = "The constant rate of health-bar drain throughout the song";
			this.label48.Location = new Point(9, 218);
			this.label48.Name = "label48";
			this.label48.Size = new Size(350, 19);
			this.label48.TabIndex = 54;
			this.label48.Text = "The speed at which objects appear";
			this.label17.AutoSize = true;
			this.label17.Font = new Font("Segoe UI", 9f, FontStyle.Italic);
			this.label17.Location = new Point(66, 331);
			this.label17.Name = "label17";
			this.label17.Size = new Size(229, 15);
			this.label17.TabIndex = 59;
			this.label17.Text = "Hold shift for precise difficulty adjustment.";
			this.label45.AutoSize = true;
			this.label45.Location = new Point(327, 196);
			this.label45.Name = "label45";
			this.label45.Size = new Size(28, 15);
			this.label45.TabIndex = 53;
			this.label45.Text = "Fast";
			this.label45.TextAlign = ContentAlignment.TopRight;
			this.label46.AutoSize = true;
			this.label46.Location = new Point(122, 196);
			this.label46.Name = "label46";
			this.label46.Size = new Size(32, 15);
			this.label46.TabIndex = 52;
			this.label46.Text = "Slow";
			this.label47.AutoSize = true;
			this.label47.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.label47.Location = new Point(10, 176);
			this.label47.Name = "label47";
			this.label47.Size = new Size(89, 15);
			this.label47.TabIndex = 51;
			this.label47.Text = "Approach Rate";
			this.approachRate.Location = new Point(118, 168);
			this.approachRate.Name = "approachRate";
			this.approachRate.Size = new Size(241, 45);
			this.approachRate.TabIndex = 2;
			this.approachRate.TickFrequency = 10;
			this.approachRate.Value = 10;
			this.approachRate.Scroll += new EventHandler(this.approachRate_Scroll);
			this.approachRate.MouseCaptureChanged += new EventHandler(this.stackLeniency_MouseCaptureChanged);
			this.approachRate.MouseDown += new MouseEventHandler(this.stackLeniency_MouseDown);
			this.label10.AutoSize = true;
			this.label10.Location = new Point(216, 124);
			this.label10.Name = "label10";
			this.label10.Size = new Size(47, 15);
			this.label10.TabIndex = 31;
			this.label10.Text = "Normal";
			this.label11.AutoSize = true;
			this.label11.Location = new Point(319, 124);
			this.label11.Name = "label11";
			this.label11.Size = new Size(36, 15);
			this.label11.TabIndex = 30;
			this.label11.Text = "Small";
			this.label11.TextAlign = ContentAlignment.TopRight;
			this.label12.AutoSize = true;
			this.label12.Location = new Point(122, 124);
			this.label12.Name = "label12";
			this.label12.Size = new Size(36, 15);
			this.label12.TabIndex = 29;
			this.label12.Text = "Large";
			this.label13.AutoSize = true;
			this.label13.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.label13.Location = new Point(10, 102);
			this.label13.Name = "label13";
			this.label13.Size = new Size(64, 15);
			this.label13.TabIndex = 27;
			this.label13.Text = "Circle Size";
			this.circleSize.LargeChange = 1;
			this.circleSize.Location = new Point(118, 93);
			this.circleSize.Name = "circleSize";
			this.circleSize.Size = new Size(241, 45);
			this.circleSize.TabIndex = 1;
			this.circleSize.TickFrequency = 10;
			this.circleSize.Scroll += new EventHandler(this.circleSize_Scroll);
			this.circleSize.ValueChanged += new EventHandler(this.circleSize_ValueChanged);
			this.circleSize.MouseCaptureChanged += new EventHandler(this.stackLeniency_MouseCaptureChanged);
			this.circleSize.MouseDown += new MouseEventHandler(this.stackLeniency_MouseDown);
			this.label6.AutoSize = true;
			this.label6.Location = new Point(314, 270);
			this.label6.Name = "label6";
			this.label6.Size = new Size(41, 15);
			this.label6.TabIndex = 20;
			this.label6.Text = "Insane";
			this.label6.TextAlign = ContentAlignment.TopRight;
			this.label7.AutoSize = true;
			this.label7.Location = new Point(122, 270);
			this.label7.Name = "label7";
			this.label7.Size = new Size(30, 15);
			this.label7.TabIndex = 19;
			this.label7.Text = "Easy";
			this.label8.AutoSize = true;
			this.label8.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.label8.Location = new Point(10, 250);
			this.label8.Name = "label8";
			this.label8.Size = new Size(102, 15);
			this.label8.TabIndex = 17;
			this.label8.Text = "Overall Difficulty";
			this.overallDifficulty.Location = new Point(118, 241);
			this.overallDifficulty.Name = "overallDifficulty";
			this.overallDifficulty.Size = new Size(241, 45);
			this.overallDifficulty.TabIndex = 3;
			this.overallDifficulty.TickFrequency = 10;
			this.overallDifficulty.Value = 10;
			this.overallDifficulty.Scroll += new EventHandler(this.overallDifficulty_Scroll);
			this.overallDifficulty.MouseCaptureChanged += new EventHandler(this.stackLeniency_MouseCaptureChanged);
			this.overallDifficulty.MouseDown += new MouseEventHandler(this.stackLeniency_MouseDown);
			this.label5.AutoSize = true;
			this.label5.Location = new Point(314, 47);
			this.label5.Name = "label5";
			this.label5.Size = new Size(41, 15);
			this.label5.TabIndex = 16;
			this.label5.Text = "Insane";
			this.label5.TextAlign = ContentAlignment.TopRight;
			this.label4.AutoSize = true;
			this.label4.Location = new Point(122, 47);
			this.label4.Name = "label4";
			this.label4.Size = new Size(30, 15);
			this.label4.TabIndex = 15;
			this.label4.Text = "Easy";
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.label2.Location = new Point(10, 28);
			this.label2.Name = "label2";
			this.label2.Size = new Size(85, 15);
			this.label2.TabIndex = 14;
			this.label2.Text = "HP Drain Rate";
			this.hpDrainRate.Location = new Point(118, 19);
			this.hpDrainRate.Name = "hpDrainRate";
			this.hpDrainRate.Size = new Size(241, 45);
			this.hpDrainRate.TabIndex = 0;
			this.hpDrainRate.TickFrequency = 10;
			this.hpDrainRate.Value = 10;
			this.hpDrainRate.Scroll += new EventHandler(this.hpDrainRate_Scroll);
			this.hpDrainRate.MouseCaptureChanged += new EventHandler(this.stackLeniency_MouseCaptureChanged);
			this.hpDrainRate.MouseDown += new MouseEventHandler(this.stackLeniency_MouseDown);
			this.tabPage2.Controls.Add(this.groupBox4);
			this.tabPage2.Controls.Add(this.groupBox3);
			this.tabPage2.Location = new Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new Padding(3);
			this.tabPage2.Size = new Size(377, 360);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Audio";
			this.groupBox4.Controls.Add(this.checkSamplesMatchPlaybackRate);
			this.groupBox4.Location = new Point(6, 282);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new Size(365, 44);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Misc. Toggles";
			this.checkSamplesMatchPlaybackRate.AutoSize = true;
			this.checkSamplesMatchPlaybackRate.Location = new Point(8, 21);
			this.checkSamplesMatchPlaybackRate.Name = "checkSamplesMatchPlaybackRate";
			this.checkSamplesMatchPlaybackRate.Size = new Size(329, 19);
			this.checkSamplesMatchPlaybackRate.TabIndex = 0;
			this.checkSamplesMatchPlaybackRate.Text = "Samples match playback rate (for fully-hitsounded maps)";
			this.checkSamplesMatchPlaybackRate.UseVisualStyleBackColor = true;
			this.checkSamplesMatchPlaybackRate.CheckedChanged += new EventHandler(this.allowedModes_TextChanged);
			this.groupBox3.Controls.Add(this.hideSampleSettings);
			this.groupBox3.Controls.Add(this.panel11);
			this.groupBox3.Controls.Add(this.panel1);
			this.groupBox3.Controls.Add(this.buttonClap);
			this.groupBox3.Controls.Add(this.hideSampleVolume);
			this.groupBox3.Controls.Add(this.label15);
			this.groupBox3.Controls.Add(this.volume1);
			this.groupBox3.Controls.Add(this.buttonHit);
			this.groupBox3.Controls.Add(this.linkLabel4);
			this.groupBox3.Controls.Add(this.buttonWhistle);
			this.groupBox3.Controls.Add(this.sampleCustom);
			this.groupBox3.Controls.Add(this.buttonFinish);
			this.groupBox3.Location = new Point(6, 6);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new Size(365, 270);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Default Sample Settings";
			this.hideSampleSettings.Controls.Add(this.buttonSampleReset);
			this.hideSampleSettings.Controls.Add(this.label34);
			this.hideSampleSettings.Location = new Point(8, 22);
			this.hideSampleSettings.Name = "hideSampleSettings";
			this.hideSampleSettings.Size = new Size(353, 73);
			this.hideSampleSettings.TabIndex = 40;
			this.hideSampleSettings.Visible = false;
			this.buttonSampleReset.FlatStyle = FlatStyle.System;
			this.buttonSampleReset.Location = new Point(226, 40);
			this.buttonSampleReset.Name = "buttonSampleReset";
			this.buttonSampleReset.Size = new Size(123, 23);
			this.buttonSampleReset.TabIndex = 0;
			this.buttonSampleReset.Text = "Reset Settings";
			this.buttonSampleReset.UseVisualStyleBackColor = true;
			this.buttonSampleReset.Click += new EventHandler(this.buttonSampleReset_Click);
			this.label34.AutoSize = true;
			this.label34.Location = new Point(5, 4);
			this.label34.Name = "label34";
			this.label34.Size = new Size(337, 30);
			this.label34.TabIndex = 46;
			this.label34.Text = "This beatmap has timing-section dependent volume settings.  \r\nYou can therefore not set beatmap-wide settings here.";
			this.panel11.Controls.Add(this.listSampleset);
			this.panel11.Location = new Point(11, 22);
			this.panel11.Name = "panel11";
			this.panel11.Size = new Size(133, 73);
			this.panel11.TabIndex = 44;
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
			this.listSampleset.Size = new Size(133, 73);
			this.listSampleset.TabIndex = 42;
			this.listSampleset.SelectedValueChanged += new EventHandler(this.listSampleset_SelectedValueChanged);
			this.panel1.Controls.Add(this.label32);
			this.panel1.Location = new Point(6, 207);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(353, 57);
			this.panel1.TabIndex = 43;
			this.label32.Dock = DockStyle.Fill;
			this.label32.Location = new Point(0, 0);
			this.label32.Name = "label32";
			this.label32.Size = new Size(353, 57);
			this.label32.TabIndex = 37;
			this.label32.Text = "Sample settings (sets and volume) can also be assigned independently for each timing section via the timing setup panel (F6 in the editor).";
			this.buttonClap.FlatStyle = FlatStyle.System;
			this.buttonClap.Location = new Point(280, 170);
			this.buttonClap.Name = "buttonClap";
			this.buttonClap.Size = new Size(79, 23);
			this.buttonClap.TabIndex = 5;
			this.buttonClap.Text = "Clap";
			this.buttonClap.UseVisualStyleBackColor = true;
			this.buttonClap.Click += new EventHandler(this.buttonClap_Click);
			this.hideSampleVolume.Controls.Add(this.buttonVolumeReset);
			this.hideSampleVolume.Controls.Add(this.label33);
			this.hideSampleVolume.Location = new Point(8, 101);
			this.hideSampleVolume.Name = "hideSampleVolume";
			this.hideSampleVolume.Size = new Size(353, 65);
			this.hideSampleVolume.TabIndex = 41;
			this.hideSampleVolume.Visible = false;
			this.buttonVolumeReset.FlatStyle = FlatStyle.System;
			this.buttonVolumeReset.Location = new Point(226, 40);
			this.buttonVolumeReset.Name = "buttonVolumeReset";
			this.buttonVolumeReset.Size = new Size(123, 23);
			this.buttonVolumeReset.TabIndex = 1;
			this.buttonVolumeReset.Text = "Reset Settings";
			this.buttonVolumeReset.UseVisualStyleBackColor = true;
			this.buttonVolumeReset.Click += new EventHandler(this.buttonVolumeReset_Click);
			this.label33.Location = new Point(4, 4);
			this.label33.Name = "label33";
			this.label33.Size = new Size(345, 41);
			this.label33.TabIndex = 45;
			this.label33.Text = "This beatmap has timing-section dependent volume settings.  \r\nYou can therefore not set beatmap-wide settings here.";
			this.label15.AutoSize = true;
			this.label15.Location = new Point(8, 101);
			this.label15.Name = "label15";
			this.label15.Size = new Size(90, 15);
			this.label15.TabIndex = 39;
			this.label15.Text = "Sample Volume";
			this.volume1.LargeChange = 500;
			this.volume1.Location = new Point(6, 119);
			this.volume1.Maximum = 100;
			this.volume1.Name = "volume1";
			this.volume1.Size = new Size(353, 45);
			this.volume1.SmallChange = 5;
			this.volume1.TabIndex = 37;
			this.volume1.TickFrequency = 10;
			this.volume1.Value = 100;
			this.volume1.Scroll += new EventHandler(this.volume1_Scroll);
			this.volume1.MouseCaptureChanged += new EventHandler(this.stackLeniency_MouseCaptureChanged);
			this.volume1.MouseDown += new MouseEventHandler(this.stackLeniency_MouseDown);
			this.buttonHit.FlatStyle = FlatStyle.System;
			this.buttonHit.Location = new Point(5, 170);
			this.buttonHit.Name = "buttonHit";
			this.buttonHit.Size = new Size(75, 23);
			this.buttonHit.TabIndex = 2;
			this.buttonHit.Text = "Normal";
			this.buttonHit.UseVisualStyleBackColor = true;
			this.buttonHit.Click += new EventHandler(this.buttonHit_Click);
			this.linkLabel4.AutoSize = true;
			this.linkLabel4.LinkColor = SystemColors.HotTrack;
			this.linkLabel4.Location = new Point(150, 45);
			this.linkLabel4.Name = "linkLabel4";
			this.linkLabel4.Size = new Size(204, 15);
			this.linkLabel4.TabIndex = 38;
			this.linkLabel4.TabStop = true;
			this.linkLabel4.Text = "How to add custom sample overrides";
			this.linkLabel4.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
			this.buttonWhistle.FlatStyle = FlatStyle.System;
			this.buttonWhistle.Location = new Point(98, 170);
			this.buttonWhistle.Name = "buttonWhistle";
			this.buttonWhistle.Size = new Size(75, 23);
			this.buttonWhistle.TabIndex = 3;
			this.buttonWhistle.Text = "Whistle";
			this.buttonWhistle.UseVisualStyleBackColor = true;
			this.buttonWhistle.Click += new EventHandler(this.buttonWhistle_Click);
			this.sampleCustom.AutoSize = true;
			this.sampleCustom.FlatStyle = FlatStyle.System;
			this.sampleCustom.Location = new Point(153, 22);
			this.sampleCustom.Name = "sampleCustom";
			this.sampleCustom.Size = new Size(161, 20);
			this.sampleCustom.TabIndex = 37;
			this.sampleCustom.Text = "Enable custom overrides";
			this.sampleCustom.UseVisualStyleBackColor = true;
			this.sampleCustom.CheckedChanged += new EventHandler(this.sampleCustom_CheckedChanged);
			this.buttonFinish.FlatStyle = FlatStyle.System;
			this.buttonFinish.Location = new Point(190, 170);
			this.buttonFinish.Name = "buttonFinish";
			this.buttonFinish.Size = new Size(75, 23);
			this.buttonFinish.TabIndex = 4;
			this.buttonFinish.Text = "Finish";
			this.buttonFinish.UseVisualStyleBackColor = true;
			this.buttonFinish.Click += new EventHandler(this.buttonFinish_Click);
			this.tabPage3.Controls.Add(this.groupBox8);
			this.tabPage3.Controls.Add(this.groupBox6);
			this.tabPage3.Location = new Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new Size(377, 360);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Colours";
			this.groupBox8.Controls.Add(this.panel2);
			this.groupBox8.Controls.Add(this.backgroundColour);
			this.groupBox8.Location = new Point(3, 208);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new Size(365, 115);
			this.groupBox8.TabIndex = 39;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Playfield Background";
			this.panel2.Controls.Add(this.label35);
			this.panel2.Location = new Point(6, 57);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(353, 52);
			this.panel2.TabIndex = 48;
			this.label35.Dock = DockStyle.Fill;
			this.label35.Location = new Point(0, 0);
			this.label35.Name = "label35";
			this.label35.Size = new Size(353, 52);
			this.label35.TabIndex = 47;
			this.label35.Text = "Please note that this colour is dimmed in both editor compose mode and in gameplay during playtime.  It will be the exact shade of the chosen colour during breaks.";
			this.backgroundColour.FlatAppearance.BorderColor = Color.Black;
			this.backgroundColour.FlatAppearance.BorderSize = 2;
			this.backgroundColour.FlatStyle = FlatStyle.Flat;
			this.backgroundColour.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.backgroundColour.ForeColor = Color.White;
			this.backgroundColour.Location = new Point(7, 19);
			this.backgroundColour.Name = "backgroundColour";
			this.backgroundColour.Size = new Size(352, 32);
			this.backgroundColour.method_1(Color.Empty);
			this.backgroundColour.TabIndex = 2;
			this.backgroundColour.Text = "Background Colour";
			this.backgroundColour.UseVisualStyleBackColor = false;
			this.backgroundColour.Click += new EventHandler(this.backgroundColour_Click);
			this.groupBox6.Controls.Add(this.combo8);
			this.groupBox6.Controls.Add(this.combo7);
			this.groupBox6.Controls.Add(this.combo6);
			this.groupBox6.Controls.Add(this.buttonRemoveCombo);
			this.groupBox6.Controls.Add(this.buttonAddCombo);
			this.groupBox6.Controls.Add(this.combo5);
			this.groupBox6.Controls.Add(this.combo4);
			this.groupBox6.Controls.Add(this.combo3);
			this.groupBox6.Controls.Add(this.combo2);
			this.groupBox6.Controls.Add(this.combo1);
			this.groupBox6.Controls.Add(this.customColour);
			this.groupBox6.Location = new Point(3, 3);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new Size(365, 202);
			this.groupBox6.TabIndex = 20;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Hitcircle/Slider Combos";
			this.combo8.FlatAppearance.BorderColor = Color.Black;
			this.combo8.FlatAppearance.BorderSize = 2;
			this.combo8.FlatStyle = FlatStyle.Flat;
			this.combo8.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.combo8.ForeColor = Color.White;
			this.combo8.Location = new Point(185, 121);
			this.combo8.Name = "combo8";
			this.combo8.Size = new Size(172, 32);
			this.combo8.method_1(Color.Empty);
			this.combo8.TabIndex = 46;
			this.combo8.Text = "Combo 8";
			this.combo8.UseVisualStyleBackColor = false;
			this.combo8.Click += new EventHandler(this.combo1_Click);
			this.combo7.FlatAppearance.BorderColor = Color.Black;
			this.combo7.FlatAppearance.BorderSize = 2;
			this.combo7.FlatStyle = FlatStyle.Flat;
			this.combo7.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.combo7.ForeColor = Color.White;
			this.combo7.Location = new Point(7, 121);
			this.combo7.Name = "combo7";
			this.combo7.Size = new Size(172, 32);
			this.combo7.method_1(Color.Empty);
			this.combo7.TabIndex = 45;
			this.combo7.Text = "Combo 7";
			this.combo7.UseVisualStyleBackColor = false;
			this.combo7.Click += new EventHandler(this.combo1_Click);
			this.combo6.FlatAppearance.BorderColor = Color.Black;
			this.combo6.FlatAppearance.BorderSize = 2;
			this.combo6.FlatStyle = FlatStyle.Flat;
			this.combo6.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.combo6.ForeColor = Color.White;
			this.combo6.Location = new Point(185, 87);
			this.combo6.Name = "combo6";
			this.combo6.Size = new Size(172, 32);
			this.combo6.method_1(Color.Empty);
			this.combo6.TabIndex = 44;
			this.combo6.Text = "Combo 6";
			this.combo6.UseVisualStyleBackColor = false;
			this.combo6.Click += new EventHandler(this.combo1_Click);
			this.buttonRemoveCombo.FlatStyle = FlatStyle.System;
			this.buttonRemoveCombo.Location = new Point(185, 164);
			this.buttonRemoveCombo.Name = "buttonRemoveCombo";
			this.buttonRemoveCombo.Size = new Size(172, 32);
			this.buttonRemoveCombo.TabIndex = 43;
			this.buttonRemoveCombo.Text = "Remove Combo Colour";
			this.buttonRemoveCombo.UseVisualStyleBackColor = true;
			this.buttonRemoveCombo.Click += new EventHandler(this.buttonRemoveCombo_Click);
			this.buttonAddCombo.FlatStyle = FlatStyle.System;
			this.buttonAddCombo.Location = new Point(136, 186);
			this.buttonAddCombo.Name = "buttonAddCombo";
			this.buttonAddCombo.Size = new Size(172, 32);
			this.buttonAddCombo.TabIndex = 42;
			this.buttonAddCombo.Text = "New Combo Colour";
			this.buttonAddCombo.UseVisualStyleBackColor = true;
			this.buttonAddCombo.Click += new EventHandler(this.buttonAddCombo_Click);
			this.combo5.FlatAppearance.BorderColor = Color.Black;
			this.combo5.FlatAppearance.BorderSize = 2;
			this.combo5.FlatStyle = FlatStyle.Flat;
			this.combo5.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.combo5.ForeColor = Color.White;
			this.combo5.Location = new Point(7, 87);
			this.combo5.Name = "combo5";
			this.combo5.Size = new Size(172, 32);
			this.combo5.method_1(Color.Empty);
			this.combo5.TabIndex = 41;
			this.combo5.Text = "Combo 5";
			this.combo5.UseVisualStyleBackColor = false;
			this.combo5.Click += new EventHandler(this.combo1_Click);
			this.combo4.FlatAppearance.BorderColor = Color.Black;
			this.combo4.FlatAppearance.BorderSize = 2;
			this.combo4.FlatStyle = FlatStyle.Flat;
			this.combo4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.combo4.ForeColor = Color.White;
			this.combo4.Location = new Point(185, 53);
			this.combo4.Name = "combo4";
			this.combo4.Size = new Size(172, 32);
			this.combo4.method_1(Color.Empty);
			this.combo4.TabIndex = 4;
			this.combo4.Text = "Combo 4";
			this.combo4.UseVisualStyleBackColor = false;
			this.combo4.Click += new EventHandler(this.combo1_Click);
			this.combo3.FlatAppearance.BorderColor = Color.Black;
			this.combo3.FlatAppearance.BorderSize = 2;
			this.combo3.FlatStyle = FlatStyle.Flat;
			this.combo3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.combo3.ForeColor = Color.White;
			this.combo3.Location = new Point(7, 53);
			this.combo3.Name = "combo3";
			this.combo3.Size = new Size(172, 32);
			this.combo3.method_1(Color.Empty);
			this.combo3.TabIndex = 3;
			this.combo3.Text = "Combo 3";
			this.combo3.UseVisualStyleBackColor = false;
			this.combo3.Click += new EventHandler(this.combo1_Click);
			this.combo2.BackColor = Color.Transparent;
			this.combo2.FlatAppearance.BorderColor = Color.Black;
			this.combo2.FlatAppearance.BorderSize = 2;
			this.combo2.FlatStyle = FlatStyle.Flat;
			this.combo2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.combo2.ForeColor = Color.White;
			this.combo2.Location = new Point(185, 19);
			this.combo2.Name = "combo2";
			this.combo2.Size = new Size(172, 32);
			this.combo2.method_1(Color.Empty);
			this.combo2.TabIndex = 2;
			this.combo2.Text = "Combo 2";
			this.combo2.UseVisualStyleBackColor = false;
			this.combo2.Click += new EventHandler(this.combo1_Click);
			this.combo1.FlatAppearance.BorderColor = Color.Black;
			this.combo1.FlatAppearance.BorderSize = 2;
			this.combo1.FlatStyle = FlatStyle.Flat;
			this.combo1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.combo1.ForeColor = Color.White;
			this.combo1.Location = new Point(7, 19);
			this.combo1.Name = "combo1";
			this.combo1.Size = new Size(172, 32);
			this.combo1.method_1(Color.Empty);
			this.combo1.TabIndex = 1;
			this.combo1.Text = "Combo 1";
			this.combo1.UseVisualStyleBackColor = false;
			this.combo1.Click += new EventHandler(this.combo1_Click);
			this.customColour.AutoSize = true;
			this.customColour.FlatStyle = FlatStyle.System;
			this.customColour.Location = new Point(12, 171);
			this.customColour.Name = "customColour";
			this.customColour.Size = new Size(156, 20);
			this.customColour.TabIndex = 0;
			this.customColour.Text = "Enable Custom Colours";
			this.customColour.UseVisualStyleBackColor = true;
			this.customColour.CheckedChanged += new EventHandler(this.customColour_CheckedChanged);
			this.tabPage5.Controls.Add(this.groupBox12);
			this.tabPage5.Controls.Add(this.groupBox11);
			this.tabPage5.Controls.Add(this.groupBox7);
			this.tabPage5.Location = new Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new Size(377, 360);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Design";
			this.groupBox12.Controls.Add(this.label44);
			this.groupBox12.Controls.Add(this.skinPreference);
			this.groupBox12.Location = new Point(6, 311);
			this.groupBox12.Name = "groupBox12";
			this.groupBox12.Size = new Size(365, 41);
			this.groupBox12.TabIndex = 41;
			this.groupBox12.TabStop = false;
			this.groupBox12.Text = "Skinning";
			this.label44.AutoSize = true;
			this.label44.Location = new Point(6, 19);
			this.label44.Name = "label44";
			this.label44.Size = new Size(83, 15);
			this.label44.TabIndex = 50;
			this.label44.Text = "Preferred Skin:";
			this.skinPreference.FlatStyle = FlatStyle.System;
			this.skinPreference.FormattingEnabled = true;
			this.skinPreference.Items.AddRange(new object[]
			{
				"User's preference (No Change)"
			});
			this.skinPreference.Location = new Point(95, 16);
			this.skinPreference.Name = "skinPreference";
			this.skinPreference.Size = new Size(263, 21);
			this.skinPreference.TabIndex = 55;
			this.skinPreference.TextChanged += new EventHandler(this.allowedModes_TextChanged);
			this.groupBox11.Controls.Add(this.checkEpilepsy);
			this.groupBox11.Controls.Add(this.checkStoryOverFire);
			this.groupBox11.Controls.Add(this.checkLetterbox);
			this.groupBox11.Controls.Add(this.checkWidescreen);
			this.groupBox11.Location = new Point(6, 189);
			this.groupBox11.Name = "groupBox11";
			this.groupBox11.Size = new Size(365, 116);
			this.groupBox11.TabIndex = 40;
			this.groupBox11.TabStop = false;
			this.groupBox11.Text = "Misc. Toggles";
			this.checkEpilepsy.AutoSize = true;
			this.checkEpilepsy.FlatStyle = FlatStyle.System;
			this.checkEpilepsy.Location = new Point(10, 66);
			this.checkEpilepsy.Name = "checkEpilepsy";
			this.checkEpilepsy.Size = new Size(330, 20);
			this.checkEpilepsy.TabIndex = 54;
			this.checkEpilepsy.Text = "Display epilepsy warning (storyboard has quick strobing)";
			this.checkEpilepsy.UseVisualStyleBackColor = true;
			this.checkEpilepsy.CheckedChanged += new EventHandler(this.allowedModes_TextChanged);
			this.checkStoryOverFire.AutoSize = true;
			this.checkStoryOverFire.FlatStyle = FlatStyle.System;
			this.checkStoryOverFire.Location = new Point(10, 44);
			this.checkStoryOverFire.Name = "checkStoryOverFire";
			this.checkStoryOverFire.Size = new Size(247, 20);
			this.checkStoryOverFire.TabIndex = 53;
			this.checkStoryOverFire.Text = "Display storyboard in front of combo fire";
			this.checkStoryOverFire.UseVisualStyleBackColor = true;
			this.checkStoryOverFire.CheckedChanged += new EventHandler(this.allowedModes_TextChanged);
			this.checkLetterbox.AutoSize = true;
			this.checkLetterbox.FlatStyle = FlatStyle.System;
			this.checkLetterbox.Location = new Point(10, 88);
			this.checkLetterbox.Name = "checkLetterbox";
			this.checkLetterbox.Size = new Size(156, 20);
			this.checkLetterbox.TabIndex = 52;
			this.checkLetterbox.Text = "Letterbox during breaks";
			this.checkLetterbox.UseVisualStyleBackColor = true;
			this.checkLetterbox.CheckedChanged += new EventHandler(this.allowedModes_TextChanged);
			this.checkWidescreen.AutoSize = true;
			this.checkWidescreen.FlatStyle = FlatStyle.System;
			this.checkWidescreen.Location = new Point(10, 22);
			this.checkWidescreen.Margin = new Padding(6);
			this.checkWidescreen.Name = "checkWidescreen";
			this.checkWidescreen.Size = new Size(138, 20);
			this.checkWidescreen.TabIndex = 55;
			this.checkWidescreen.Text = "Widescreen Support";
			this.checkWidescreen.UseVisualStyleBackColor = true;
			this.checkWidescreen.CheckedChanged += new EventHandler(this.allowedModes_TextChanged);
			this.groupBox7.Controls.Add(this.panel3);
			this.groupBox7.Controls.Add(this.panelCountdownRate);
			this.groupBox7.Controls.Add(this.linkLabel5);
			this.groupBox7.Controls.Add(this.checkCountdown);
			this.groupBox7.Location = new Point(6, 4);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new Size(365, 179);
			this.groupBox7.TabIndex = 1;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Countdown";
			this.panel3.Controls.Add(this.label36);
			this.panel3.Location = new Point(3, 40);
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size(356, 50);
			this.panel3.TabIndex = 49;
			this.label36.Dock = DockStyle.Fill;
			this.label36.Location = new Point(0, 0);
			this.label36.Name = "label36";
			this.label36.Size = new Size(356, 50);
			this.label36.TabIndex = 48;
			this.label36.Text = "If this is checked, an \"Are you ready? 3, 2, 1, GO!\" countdown will be inserted at the beginning of the beatmap, assuming there is enough time to do so.";
			this.panelCountdownRate.Controls.Add(this.udCountdownOffset);
			this.panelCountdownRate.Controls.Add(this.label49);
			this.panelCountdownRate.Controls.Add(this.label50);
			this.panelCountdownRate.Controls.Add(this.label43);
			this.panelCountdownRate.Controls.Add(this.countdownDouble);
			this.panelCountdownRate.Controls.Add(this.countdownNormal);
			this.panelCountdownRate.Controls.Add(this.countdownHalf);
			this.panelCountdownRate.Dock = DockStyle.Bottom;
			this.panelCountdownRate.Location = new Point(3, 90);
			this.panelCountdownRate.Name = "panelCountdownRate";
			this.panelCountdownRate.Size = new Size(359, 86);
			this.panelCountdownRate.TabIndex = 2;
			this.udCountdownOffset.Location = new Point(137, 27);
			NumericUpDown arg_49DA_0 = this.udCountdownOffset;
			int[] array = new int[4];
			array[0] = 3;
			arg_49DA_0.Maximum = new decimal(array);
			this.udCountdownOffset.Name = "udCountdownOffset";
			this.udCountdownOffset.Size = new Size(49, 20);
			this.udCountdownOffset.TabIndex = 51;
			this.udCountdownOffset.ValueChanged += new EventHandler(this.allowedModes_TextChanged);
			this.label49.AutoSize = true;
			this.label49.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.label49.Location = new Point(3, 29);
			this.label49.Name = "label49";
			this.label49.Size = new Size(113, 15);
			this.label49.TabIndex = 50;
			this.label49.Text = "Countdown Offset:";
			this.label50.AutoSize = true;
			this.label50.Location = new Point(3, 50);
			this.label50.Name = "label50";
			this.label50.Size = new Size(327, 30);
			this.label50.TabIndex = 52;
			this.label50.Text = "If the countdown sounds off-time, use this to make it appear\r\none or more beats early.";
			this.label43.AutoSize = true;
			this.label43.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.label43.Location = new Point(3, 3);
			this.label43.Name = "label43";
			this.label43.Size = new Size(112, 15);
			this.label43.TabIndex = 49;
			this.label43.Text = "Countdown Speed:";
			this.countdownDouble.AutoSize = true;
			this.countdownDouble.FlatStyle = FlatStyle.System;
			this.countdownDouble.Location = new Point(275, 1);
			this.countdownDouble.Name = "countdownDouble";
			this.countdownDouble.Size = new Size(69, 20);
			this.countdownDouble.TabIndex = 43;
			this.countdownDouble.Text = "Double";
			this.countdownDouble.UseVisualStyleBackColor = true;
			this.countdownDouble.CheckedChanged += new EventHandler(this.allowedModes_TextChanged);
			this.countdownNormal.AutoSize = true;
			this.countdownNormal.Checked = true;
			this.countdownNormal.FlatStyle = FlatStyle.System;
			this.countdownNormal.Location = new Point(206, 1);
			this.countdownNormal.Name = "countdownNormal";
			this.countdownNormal.Size = new Size(71, 20);
			this.countdownNormal.TabIndex = 42;
			this.countdownNormal.TabStop = true;
			this.countdownNormal.Text = "Normal";
			this.countdownNormal.UseVisualStyleBackColor = true;
			this.countdownNormal.CheckedChanged += new EventHandler(this.allowedModes_TextChanged);
			this.countdownHalf.AutoSize = true;
			this.countdownHalf.FlatStyle = FlatStyle.System;
			this.countdownHalf.Location = new Point(137, 1);
			this.countdownHalf.Name = "countdownHalf";
			this.countdownHalf.Size = new Size(53, 20);
			this.countdownHalf.TabIndex = 40;
			this.countdownHalf.Text = "Half";
			this.countdownHalf.UseVisualStyleBackColor = true;
			this.countdownHalf.CheckedChanged += new EventHandler(this.allowedModes_TextChanged);
			this.linkLabel5.ActiveLinkColor = SystemColors.Highlight;
			this.linkLabel5.AutoSize = true;
			this.linkLabel5.LinkColor = SystemColors.HotTrack;
			this.linkLabel5.Location = new Point(201, 19);
			this.linkLabel5.Name = "linkLabel5";
			this.linkLabel5.Size = new Size(158, 15);
			this.linkLabel5.TabIndex = 39;
			this.linkLabel5.TabStop = true;
			this.linkLabel5.Text = "Customising the countdown";
			this.linkLabel5.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
			this.checkCountdown.AutoSize = true;
			this.checkCountdown.FlatStyle = FlatStyle.System;
			this.checkCountdown.Location = new Point(10, 19);
			this.checkCountdown.Name = "checkCountdown";
			this.checkCountdown.Size = new Size(131, 20);
			this.checkCountdown.TabIndex = 0;
			this.checkCountdown.Text = "Enable countdown";
			this.checkCountdown.UseVisualStyleBackColor = true;
			this.checkCountdown.CheckedChanged += new EventHandler(this.checkCountdown_CheckedChanged);
			this.tabPage6.Controls.Add(this.groupBox10);
			this.tabPage6.Controls.Add(this.groupBox9);
			this.tabPage6.Location = new Point(4, 22);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Size = new Size(377, 360);
			this.tabPage6.TabIndex = 4;
			this.tabPage6.Text = "Advanced";
			this.groupBox10.Controls.Add(this.cb_maniaSpecial);
			this.groupBox10.Controls.Add(this.panel5);
			this.groupBox10.Controls.Add(this.label42);
			this.groupBox10.Controls.Add(this.allowedModes);
			this.groupBox10.Location = new Point(6, 141);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new Size(365, 158);
			this.groupBox10.TabIndex = 40;
			this.groupBox10.TabStop = false;
			this.groupBox10.Text = "Mode Specific";
			this.panel5.Controls.Add(this.label38);
			this.panel5.Location = new Point(1, 77);
			this.panel5.Name = "panel5";
			this.panel5.Size = new Size(353, 66);
			this.panel5.TabIndex = 52;
			this.label38.Dock = DockStyle.Top;
			this.label38.Location = new Point(0, 0);
			this.label38.Name = "label38";
			this.label38.Size = new Size(353, 77);
			this.label38.TabIndex = 50;
			this.label38.Text = componentResourceManager.GetString("label38.Text");
			this.label42.AutoSize = true;
			this.label42.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.label42.Location = new Point(6, 22);
			this.label42.Name = "label42";
			this.label42.Size = new Size(95, 15);
			this.label42.TabIndex = 51;
			this.label42.Text = "Allowed Modes:";
			this.allowedModes.FlatStyle = FlatStyle.System;
			this.allowedModes.FormattingEnabled = true;
			this.allowedModes.Items.AddRange(new object[]
			{
				"All",
				"Taiko",
				"Catch the Beat",
				"osu!mania"
			});
			this.allowedModes.Location = new Point(118, 19);
			this.allowedModes.Name = "allowedModes";
			this.allowedModes.Size = new Size(236, 21);
			this.allowedModes.TabIndex = 41;
			this.allowedModes.SelectedIndexChanged += new EventHandler(this.allowedModes_SelectedIndexChanged);
			this.allowedModes.TextChanged += new EventHandler(this.allowedModes_TextChanged);
			this.groupBox9.Controls.Add(this.panel4);
			this.groupBox9.Controls.Add(this.label26);
			this.groupBox9.Controls.Add(this.label27);
			this.groupBox9.Controls.Add(this.label28);
			this.groupBox9.Controls.Add(this.stackLeniency);
			this.groupBox9.Location = new Point(6, 4);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new Size(365, 131);
			this.groupBox9.TabIndex = 2;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Stacking";
			this.panel4.Controls.Add(this.label37);
			this.panel4.Location = new Point(7, 69);
			this.panel4.Name = "panel4";
			this.panel4.Size = new Size(351, 56);
			this.panel4.TabIndex = 50;
			this.label37.Dock = DockStyle.Fill;
			this.label37.Location = new Point(0, 0);
			this.label37.Name = "label37";
			this.label37.Size = new Size(351, 56);
			this.label37.TabIndex = 49;
			this.label37.Text = "In play mode, osu! automatically stacks notes which occur at the same location.  Increasing this value means it is more likely to snap notes of further time-distance.";
			this.label26.AutoSize = true;
			this.label26.Location = new Point(279, 51);
			this.label26.Name = "label26";
			this.label26.Size = new Size(75, 15);
			this.label26.TabIndex = 20;
			this.label26.Text = "Always Stack";
			this.label26.TextAlign = ContentAlignment.TopRight;
			this.label27.AutoSize = true;
			this.label27.Location = new Point(122, 51);
			this.label27.Name = "label27";
			this.label27.Size = new Size(70, 15);
			this.label27.TabIndex = 19;
			this.label27.Text = "Rarely Stack";
			this.label28.AutoSize = true;
			this.label28.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.label28.Location = new Point(6, 24);
			this.label28.Name = "label28";
			this.label28.Size = new Size(93, 15);
			this.label28.TabIndex = 18;
			this.label28.Text = "Stack Leniency:";
			this.stackLeniency.Location = new Point(118, 21);
			this.stackLeniency.Minimum = 2;
			this.stackLeniency.Name = "stackLeniency";
			this.stackLeniency.Size = new Size(241, 45);
			this.stackLeniency.TabIndex = 17;
			this.stackLeniency.Value = 7;
			this.stackLeniency.Scroll += new EventHandler(this.stackLeniency_Scroll);
			this.stackLeniency.MouseCaptureChanged += new EventHandler(this.stackLeniency_MouseCaptureChanged);
			this.stackLeniency.MouseDown += new MouseEventHandler(this.stackLeniency_MouseDown);
			base.AcceptButton = this.buttonOk;
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			base.CancelButton = this.button1;
			base.ClientSize = new Size(385, 430);
			base.Controls.Add(this.tabControl1);
			base.Controls.Add(this.buttonOk);
			base.Controls.Add(this.button1);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "SongSetup";
			base.Opacity = 1.0;
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Song Setup";
			base.Load += new EventHandler(this.SongSetup_Load);
			base.KeyDown += new KeyEventHandler(this.SongSetup_KeyDown);
			base.KeyUp += new KeyEventHandler(this.SongSetup_KeyUp);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panelRomanisedArtist.ResumeLayout(false);
			this.panelRomanisedArtist.PerformLayout();
			this.panelRomanisedTitle.ResumeLayout(false);
			this.panelRomanisedTitle.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.panel10.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((ISupportInitialize)this.approachRate).EndInit();
			((ISupportInitialize)this.circleSize).EndInit();
			((ISupportInitialize)this.overallDifficulty).EndInit();
			((ISupportInitialize)this.hpDrainRate).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.hideSampleSettings.ResumeLayout(false);
			this.hideSampleSettings.PerformLayout();
			this.panel11.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.hideSampleVolume.ResumeLayout(false);
			((ISupportInitialize)this.volume1).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.tabPage5.ResumeLayout(false);
			this.groupBox12.ResumeLayout(false);
			this.groupBox12.PerformLayout();
			this.groupBox11.ResumeLayout(false);
			this.groupBox11.PerformLayout();
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panelCountdownRate.ResumeLayout(false);
			this.panelCountdownRate.PerformLayout();
			((ISupportInitialize)this.udCountdownOffset).EndInit();
			this.tabPage6.ResumeLayout(false);
			this.groupBox10.ResumeLayout(false);
			this.groupBox10.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.groupBox9.ResumeLayout(false);
			this.groupBox9.PerformLayout();
			this.panel4.ResumeLayout(false);
			((ISupportInitialize)this.stackLeniency).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0600322D RID: 12845
		// RVA: 0x00024F8E File Offset: 0x0002318E
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Class115.smethod_90("http://osu.ppy.sh/p/faq/?n=5", null);
		}

		// Token: 0x0600322E RID: 12846
		// RVA: 0x00024F9B File Offset: 0x0002319B
		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Class115.smethod_90("http://osu.ppy.sh/wiki/Ranking_Criteria", null);
		}

		// Token: 0x06003231 RID: 12849
		// RVA: 0x00024FB7 File Offset: 0x000231B7
		private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Class115.smethod_90("http://osu.ppy.sh/forum/t/729", null);
		}

		// Token: 0x06003238 RID: 12856
		// RVA: 0x00025001 File Offset: 0x00023201
		private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Class115.smethod_90("http://osu.ppy.sh/forum/t/2003", null);
		}

		// Token: 0x06003246 RID: 12870
		// RVA: 0x00024FF8 File Offset: 0x000231F8
		private void listSampleset_SelectedValueChanged(object sender, EventArgs e)
		{
			this.bool_6 = true;
		}

		// Token: 0x06003223 RID: 12835
		// RVA: 0x00149D6C File Offset: 0x00147F6C
		private int method_10()
		{
			int num = 0;
			while (num < 8 && this.class616_0[num].bool_1)
			{
				num++;
			}
			return num;
		}

		// Token: 0x06003240 RID: 12864
		// RVA: 0x0014A750 File Offset: 0x00148950
		private void method_11(TrackBar trackBar_0, float float_0, float float_1, float float_2, double double_0)
		{
			float_0 = Math.Max(0f, Math.Min(10f, float_0));
			if (float_0 <= float_1)
			{
				trackBar_0.Minimum = (int)Math.Round((double)float_0 * double_0);
			}
			else
			{
				trackBar_0.Minimum = (int)Math.Round((double)float_1 * double_0);
			}
			if (float_0 >= float_2)
			{
				trackBar_0.Maximum = (int)Math.Round((double)float_0 * double_0);
			}
			else
			{
				trackBar_0.Maximum = (int)Math.Round((double)float_2 * double_0);
			}
			trackBar_0.Value = (int)Math.Round((double)float_0 * double_0);
		}

		// Token: 0x06003242 RID: 12866
		// RVA: 0x0014A830 File Offset: 0x00148A30
		private void method_12(TrackBar trackBar_0, double double_0)
		{
			this.toolTip_0.Show(((double)trackBar_0.Value * double_0).ToString(), this.tabPage4, trackBar_0.Right + 2, trackBar_0.Top + 4);
		}

		// Token: 0x06003245 RID: 12869
		// RVA: 0x0014A870 File Offset: 0x00148A70
		private Struct69 method_13()
		{
			Enum38 enum38_ = Enum38.const_0;
			SampleSet sampleSet_;
			if (this.bool_3)
			{
				if (this.listSampleset.SelectedItem == null)
				{
					sampleSet_ = SampleSet.None;
				}
				else
				{
					sampleSet_ = (SampleSet)Enum.Parse(typeof(SampleSet), this.listSampleset.SelectedItem.ToString());
				}
				if (this.sampleCustom.Checked)
				{
					enum38_ = Enum38.const_1;
				}
			}
			else
			{
				sampleSet_ = Class331.smethod_7().sampleSet_0;
				enum38_ = Class331.smethod_7().enum38_0;
			}
			int int_;
			if (this.bool_4)
			{
				int_ = this.volume1.Value;
			}
			else
			{
				int_ = Class331.smethod_7().int_0;
			}
			return new Struct69(HitObjectSoundType.None, sampleSet_, enum38_, int_, SampleSet.None);
		}

		// Token: 0x06003222 RID: 12834
		// RVA: 0x00149D0C File Offset: 0x00147F0C
		private void method_9()
		{
			int num = this.method_10();
			if (this.buttonAddCombo.Visible = (num < 8))
			{
				this.buttonAddCombo.Location = this.class616_0[num].Location;
			}
			this.buttonRemoveCombo.Enabled = (num > 2);
			this.buttonAddCombo.Enabled = (num < 8);
		}

		// Token: 0x06003226 RID: 12838
		// RVA: 0x0014A360 File Offset: 0x00148560
		private void overallDifficulty_Scroll(object sender, EventArgs e)
		{
			TrackBar trackBar = sender as TrackBar;
			if (!this.bool_5)
			{
				trackBar.Value = (int)Math.Round((double)trackBar.Value / 10.0) * 10;
			}
			this.method_12(trackBar, 0.1);
			this.bool_6 = true;
		}

		// Token: 0x06003235 RID: 12853
		// RVA: 0x00024FF8 File Offset: 0x000231F8
		private void sampleCustom_CheckedChanged(object sender, EventArgs e)
		{
			this.bool_6 = true;
		}

		// Token: 0x0600324E RID: 12878
		// RVA: 0x000250A2 File Offset: 0x000232A2
		[CompilerGenerated]
		private static bool smethod_3(string string_0)
		{
			return string_0.EndsWith(Path.GetFileName(Class466.Current.string_9));
		}

		// Token: 0x06003220 RID: 12832
		// RVA: 0x00024F17 File Offset: 0x00023117
		private void SongSetup_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.ShiftKey || e.KeyCode == Keys.LShiftKey || e.KeyCode == Keys.RShiftKey)
			{
				this.bool_5 = true;
				e.Handled = true;
			}
		}

		// Token: 0x06003221 RID: 12833
		// RVA: 0x00024F4B File Offset: 0x0002314B
		private void SongSetup_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.ShiftKey || e.KeyCode == Keys.LShiftKey || e.KeyCode == Keys.RShiftKey)
			{
				this.bool_5 = false;
				e.Handled = true;
			}
		}

		// Token: 0x0600321F RID: 12831
		// RVA: 0x00149494 File Offset: 0x00147694
		private void SongSetup_Load(object sender, EventArgs e)
		{
			this.class616_0 = new Class616[]
			{
				this.combo1,
				this.combo2,
				this.combo3,
				this.combo4,
				this.combo5,
				this.combo6,
				this.combo7,
				this.combo8
			};
			List<string> list = Class466.Current.bool_10 ? new List<string>(Class466.Current.method_44().method_16()) : null;
			bool arg_B5_0;
			if (list != null && !this.bool_1)
			{
				List<string> arg_AD_0 = list;
				if (SongSetup.predicate_0 == null)
				{
					SongSetup.predicate_0 = new Predicate<string>(SongSetup.smethod_3);
				}
				arg_B5_0 = arg_AD_0.Exists(SongSetup.predicate_0);
			}
			else
			{
				arg_B5_0 = false;
			}
			bool flag = arg_B5_0;
			this.version.Enabled = !flag;
			this.title.Text = ((!string.IsNullOrEmpty(Class466.Current.TitleUnicode)) ? Class466.Current.TitleUnicode : Class466.Current.Title);
			this.titleRomanised.Text = (string.IsNullOrEmpty(Class466.Current.Title) ? Class34.smethod_19(Class466.Current.TitleUnicode) : Class466.Current.Title);
			this.artist.Text = ((!string.IsNullOrEmpty(Class466.Current.ArtistUnicode)) ? Class466.Current.ArtistUnicode : Class466.Current.Artist);
			this.artistRomanised.Text = (string.IsNullOrEmpty(Class466.Current.Artist) ? Class34.smethod_19(Class466.Current.ArtistUnicode) : Class466.Current.Artist);
			this.creator.Text = ((Class466.Current.string_5.Length > 0) ? Class466.Current.string_5 : Class341.class605_20.Value);
			this.source.Text = Class466.Current.string_13;
			if (this.creator.Text == Class341.class605_20 || flag)
			{
				this.creator.Enabled = false;
			}
			this.version.Text = Class466.Current.string_14;
			this.coopmode.Checked = (Class466.Current.method_5() == PlayModes.OsuMania && Class466.Current.DifficultyCircleSize >= 10f);
			this.method_11(this.hpDrainRate, Class466.Current.DifficultyHpDrainRate, 0f, 10f, 10.0);
			if (this.allowedModes.SelectedIndex == 3)
			{
				this.method_11(this.circleSize, Class466.Current.DifficultyCircleSize / (float)(this.coopmode.Checked ? 2 : 1), 1f, 9f, 1.0);
			}
			else
			{
				this.method_11(this.circleSize, Class466.Current.DifficultyCircleSize, 2f, 7f, 10.0);
			}
			this.method_11(this.approachRate, Class466.Current.DifficultyApproachRate, 0f, 10f, 10.0);
			this.method_11(this.overallDifficulty, Class466.Current.DifficultyOverall, 0f, 10f, 10.0);
			this.listSampleset.SelectedItem = Class331.sampleSet_0.ToString();
			this.tags.Text = Class466.Current.Tags;
			this.source.Text = Class466.Current.string_13;
			this.sampleCustom.Checked = (Class331.smethod_74() == Enum38.const_1);
			this.checkEpilepsy.Checked = Class466.Current.bool_21;
			this.udCountdownOffset.Value = Class466.Current.int_8;
			this.checkLetterbox.Enabled = !Class872.class872_0.bool_11;
			this.stackLeniency.Value = (int)Math.Max(2.0, Math.Round((double)(Class466.Current.float_1 * 10f)));
			this.allowedModes.SelectedIndex = (int)Class466.Current.method_5();
			this.playModes_0 = Class466.Current.method_5();
			this.volume1.Value = Class466.Current.int_15;
			if (Class466.Current.method_0())
			{
				this.checkSamplesMatchPlaybackRate.Checked = Class466.Current.bool_17;
			}
			else
			{
				this.checkSamplesMatchPlaybackRate.Checked = true;
				this.checkSamplesMatchPlaybackRate.Enabled = false;
			}
			this.checkCountdown.Checked = (Class466.Current.enum65_0 != Enum65.const_0);
			this.checkLetterbox.Checked = Class466.Current.bool_11;
			this.checkWidescreen.Checked = (Class466.Current.bool_12 || this.bool_1);
			this.checkStoryOverFire.Checked = !Class466.Current.bool_14;
			if (Class466.Current.enum65_0 == Enum65.const_0)
			{
				this.countdownNormal.Checked = true;
			}
			else
			{
				this.countdownDouble.Checked = (Class466.Current.enum65_0 == Enum65.const_3);
				this.countdownHalf.Checked = (Class466.Current.enum65_0 == Enum65.const_2);
				this.countdownNormal.Checked = (Class466.Current.enum65_0 == Enum65.const_1);
			}
			Class885.smethod_30();
			foreach (string current in Class885.list_0)
			{
				this.skinPreference.Items.Add(current);
			}
			if (!string.IsNullOrEmpty(Class466.Current.string_11))
			{
				this.skinPreference.Text = Class466.Current.string_11;
			}
			else
			{
				this.skinPreference.SelectedIndex = 0;
			}
			this.panelCountdownRate.Enabled = this.checkCountdown.Checked;
			if (Class331.smethod_14().Count > 0)
			{
				SampleSet sampleSet_ = Class331.smethod_14()[0].sampleSet_0;
				Enum38 enum38_ = Class331.smethod_14()[0].enum38_0;
				int int_ = Class331.smethod_14()[0].int_0;
				foreach (Class340 current2 in Class331.smethod_14())
				{
					if (current2.sampleSet_0 != sampleSet_ || current2.enum38_0 != enum38_ || current2.enum38_0 >= Enum38.const_2)
					{
						this.hideSampleSettings.Visible = true;
						this.bool_3 = false;
					}
					if (current2.int_0 != int_)
					{
						this.hideSampleVolume.Visible = true;
						this.bool_4 = false;
					}
				}
				this.volume1.Value = int_;
			}
			List<Color> list2 = new List<Color>(4);
			for (int i = 0; i < 8; i++)
			{
				Color item = Class778.smethod_6(Class885.smethod_23("Combo" + (i + 1).ToString(), true));
				if (i < 2 || item.A > 0)
				{
					list2.Add(item);
				}
			}
			while (list2.Count < 2)
			{
				list2.Add(Color.FromArgb(240, 240, 240));
			}
			list2.Add(list2[0]);
			list2.RemoveAt(0);
			int j;
			for (j = 0; j < list2.Count; j++)
			{
				this.class616_0[j].method_1(list2[j]);
				this.class616_0[j].Visible = true;
				this.class616_0[j].bool_1 = true;
			}
			while (j < 8)
			{
				this.class616_0[j].Visible = false;
				this.class616_0[j].bool_1 = false;
				j++;
			}
			this.backgroundColour.method_1(Class778.smethod_6(Class872.color_0));
			this.method_9();
			this.customColour.Checked = Class466.Current.bool_5;
			this.cb_maniaSpecial.Checked = Class466.Current.bool_16;
			if (!this.bool_1 && !flag)
			{
				this.artist.Select();
			}
			else
			{
				this.version.Text = string.Empty;
				this.version.Select();
				this.artist.Enabled = false;
				this.title.Enabled = false;
			}
			this.bool_6 = false;
		}

		// Token: 0x06003243 RID: 12867
		// RVA: 0x00025065 File Offset: 0x00023265
		private void stackLeniency_MouseCaptureChanged(object sender, EventArgs e)
		{
			this.toolTip_0.Hide(this.tabPage4);
			this.toolTip_0.RemoveAll();
		}

		// Token: 0x06003241 RID: 12865
		// RVA: 0x0014A7D8 File Offset: 0x001489D8
		private void stackLeniency_MouseDown(object sender, MouseEventArgs e)
		{
			if ((sender == this.circleSize && this.allowedModes.SelectedIndex == 3) || sender == this.stackLeniency)
			{
				this.method_12((TrackBar)sender, 1.0);
				return;
			}
			this.method_12((TrackBar)sender, 0.1);
		}

		// Token: 0x06003244 RID: 12868
		// RVA: 0x00024FDA File Offset: 0x000231DA
		private void stackLeniency_Scroll(object sender, EventArgs e)
		{
			this.method_12((TrackBar)sender, 1.0);
			this.bool_6 = true;
		}

		// Token: 0x06003233 RID: 12851
		// RVA: 0x00024FC4 File Offset: 0x000231C4
		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.tabControl1.SelectedIndex == 3)
			{
				this.method_9();
			}
		}

		// Token: 0x06003247 RID: 12871
		// RVA: 0x0014A914 File Offset: 0x00148B14
		private void tabPage4_Enter(object sender, EventArgs e)
		{
			if (this.allowedModes.SelectedIndex == 3)
			{
				this.label13.Text = "Key Count";
				this.label40.Text = "The column count";
				this.circleSize.Minimum = (int)Math.Round(1.0);
				this.circleSize.Maximum = (int)Math.Round(9.0);
				this.circleSize.TickFrequency = 1;
				this.label12.Text = "1";
				this.label10.Text = "";
				this.label11.Text = "      9";
				this.approachRate.Enabled = false;
				return;
			}
			this.label13.Text = "Circle Size";
			this.label40.Text = "The radial size of hit circles and sliders";
			this.circleSize.Minimum = (int)Math.Round(20.0);
			this.circleSize.Maximum = (int)Math.Round(70.0);
			this.circleSize.TickFrequency = 10;
			this.label12.Text = "Large";
			this.label10.Text = "Normal";
			this.label11.Text = "Small";
			this.approachRate.Enabled = true;
		}

		// Token: 0x0600323D RID: 12861
		// RVA: 0x0014A658 File Offset: 0x00148858
		private void title_TextChanged(object sender, EventArgs e)
		{
			string a = Class34.smethod_19(this.title.Text);
			bool flag;
			if (flag = (a == this.title.Text))
			{
				this.titleRomanised.Text = this.title.Text;
			}
			this.panelRomanisedTitle.Enabled = !flag;
			this.titleRomanised.Text = Class34.smethod_19(this.titleRomanised.Text);
			this.bool_6 = true;
		}

		// Token: 0x06003234 RID: 12852
		// RVA: 0x00024FDA File Offset: 0x000231DA
		private void volume1_Scroll(object sender, EventArgs e)
		{
			this.method_12((TrackBar)sender, 1.0);
			this.bool_6 = true;
		}
	}
}
