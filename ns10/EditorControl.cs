using ns24;
using ns26;
using ns29;
using ns59;
using ns64;
using ns68;
using ns8;
using ns89;
using ns90;
using ns94;
using osu.GameModes.Edit;
using osu_common;
using osu_common.Helpers;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns10
{
	// Token: 0x0200065F RID: 1631
	internal sealed class EditorControl : UserControl
	{
		// Token: 0x04002EA9 RID: 11945
		private ToolStripMenuItem addTimingPointToolStripMenuItem;

		// Token: 0x04002ED1 RID: 11985
		private ToolStripMenuItem addTimingToolStripMenuItem;

		// Token: 0x04002EEB RID: 12011
		private ToolStripMenuItem asReferenceToolStripMenuItem;

		// Token: 0x04002E93 RID: 11923
		private ToolStripMenuItem audioRate100ToolStripMenuItem;

		// Token: 0x04002E90 RID: 11920
		private ToolStripMenuItem audioRate25ToolStripMenuItem;

		// Token: 0x04002E91 RID: 11921
		private ToolStripMenuItem audioRate50ToolStripMenuItem;

		// Token: 0x04002E92 RID: 11922
		private ToolStripMenuItem audioRate75ToolStripMenuItem;

		// Token: 0x04002E8F RID: 11919
		private ToolStripMenuItem audioRateToolStripMenuItem;

		// Token: 0x04002EEC RID: 12012
		private ToolStripMenuItem autoToolStripMenuItem;

		// Token: 0x04002E9F RID: 11935
		private ToolStripMenuItem beatSnappingToolStripMenuItem;

		// Token: 0x04002EE9 RID: 12009
		private ToolStripMenuItem bmsbmeToolStripMenuItem;

		// Token: 0x04002EA1 RID: 11937
		private ToolStripMenuItem bPMOffsetToolStripMenuItem;

		// Token: 0x04002E89 RID: 11913
		private ToolStripMenuItem cloneToolStripMenuItem;

		// Token: 0x04002E7D RID: 11901
		private ToolStripMenuItem composeToolStripMenu;

		// Token: 0x04002E8C RID: 11916
		private ToolStripMenuItem composeToolStripMenuItem;

		// Token: 0x04002EE4 RID: 12004
		private ToolStripMenuItem convertSliderToStreamToolStripMenuItem;

		// Token: 0x04002E84 RID: 11908
		private ToolStripMenuItem copyToolStripMenuItem;

		// Token: 0x04002E83 RID: 11907
		private ToolStripMenuItem cutToolStripMenuItem;

		// Token: 0x04002EAB RID: 11947
		private ToolStripMenuItem deleteTimingPointToolStripMenuItem;

		// Token: 0x04002E86 RID: 11910
		private ToolStripMenuItem deleteToolStripMenuItem;

		// Token: 0x04002ED8 RID: 11992
		private ToolStripMenuItem designToolStripMenu;

		// Token: 0x04002E8D RID: 11917
		private ToolStripMenuItem designToolStripMenuItem;

		// Token: 0x04002EEF RID: 12015
		private ToolStripMenuItem disableUndoStatesToolStripMenuItem;

		// Token: 0x04002E8B RID: 11915
		private ToolStripMenuItem displayInlineHlpeToolStripMenuItem;

		// Token: 0x04002EB4 RID: 11956
		private ToolStripMenuItem doubleTripletsToolStripMenuItem;

		// Token: 0x04002E77 RID: 11895
		private Editor editor_0;

		// Token: 0x04002E7B RID: 11899
		private ToolStripMenuItem editToolStripMenu;

		// Token: 0x04002EA6 RID: 11942
		private ToolStripMenuItem eighthBeatsToolStripMenuItem;

		// Token: 0x04002EE5 RID: 12005
		private ToolStripMenuItem enableLiveMappingModeToolStripMenuItem;

		// Token: 0x04002E82 RID: 11906
		private ToolStripMenuItem exitToolStripMenuItem;

		// Token: 0x04002EDC RID: 11996
		private ToolStripMenuItem extractMapPackageToolStripMenuItem;

		// Token: 0x04002E7A RID: 11898
		private ToolStripMenuItem fileToolStripMenu;

		// Token: 0x04002E94 RID: 11924
		private ToolStripMenuItem flipHorizontallyToolStripMenuItem;

		// Token: 0x04002E95 RID: 11925
		private ToolStripMenuItem flipVerticallyToolStripMenuItem;

		// Token: 0x04002EF2 RID: 12018
		private ToolStripMenuItem followPointsToolStripMenuItem;

		// Token: 0x04002EA3 RID: 11939
		private ToolStripMenuItem fullBeatsToolStripMenuItem;

		// Token: 0x04002E99 RID: 11929
		private ToolStripMenuItem gridLevelToolStripMenuItem;

		// Token: 0x04002E9B RID: 11931
		private ToolStripMenuItem gridSize2ToolStripMenuItem;

		// Token: 0x04002E9C RID: 11932
		private ToolStripMenuItem gridSize3ToolStripMenuItem;

		// Token: 0x04002EA4 RID: 11940
		private ToolStripMenuItem halfBeatsToolStripMenuItem;

		// Token: 0x04002E7E RID: 11902
		private ToolStripMenuItem helpToolStripMenu;

		// Token: 0x04002EF1 RID: 12017
		private ToolStripMenuItem hitAnimationsToolStripMenuItem;

		// Token: 0x04002E78 RID: 11896
		private IContainer icontainer_0;

		// Token: 0x04002EE8 RID: 12008
		private ToolStripMenuItem importBMSToolStripMenuItem;

		// Token: 0x04002ED7 RID: 11991
		private ToolStripMenuItem loadSoftToolStripMenuItem;

		// Token: 0x04002E80 RID: 11904
		private ToolStripMenuItem loadToolStripMenuItem;

		// Token: 0x04002EB8 RID: 11960
		internal ToolStripMenuItem menuItemRedo;

		// Token: 0x04002EB7 RID: 11959
		internal ToolStripMenuItem menuItemUndo;

		// Token: 0x04002E79 RID: 11897
		private MenuStrip menuStrip1;

		// Token: 0x04002EBE RID: 11966
		private ToolStripMenuItem metronomeClicksToolStripMenuItem;

		// Token: 0x04002E9D RID: 11933
		private ToolStripMenuItem mostPreciseToolStripMenuItem;

		// Token: 0x04002E9A RID: 11930
		private ToolStripMenuItem mostSparseToolStripMenuItem;

		// Token: 0x04002ED9 RID: 11993
		private ToolStripMenuItem moveAllElementsInTimeToolStripMenuItem;

		// Token: 0x04002EE7 RID: 12007
		private ToolStripMenuItem moveAllNotesToolStripMenuItem;

		// Token: 0x04002E7F RID: 11903
		private ToolStripMenuItem newToolStripMenuItem;

		// Token: 0x04002E97 RID: 11927
		private ToolStripMenuItem nudgeBackwardToolStripMenuItem;

		// Token: 0x04002E98 RID: 11928
		private ToolStripMenuItem nudgeOneMeasureRightToolStripMenuItem;

		// Token: 0x04002ED5 RID: 11989
		private ToolStripMenuItem openAiModToolStripMenuItem;

		// Token: 0x04002EE1 RID: 12001
		private ToolStripMenuItem openosbInNotepadToolStripMenuItem;

		// Token: 0x04002ECE RID: 11982
		private ToolStripMenuItem openOsuInNotepad;

		// Token: 0x04002ECC RID: 11980
		private ToolStripMenuItem openSongFolder;

		// Token: 0x04002EB1 RID: 11953
		private ToolStripMenuItem openToolStripMenuItem;

		// Token: 0x04002EB3 RID: 11955
		private ToolStripMenuItem packageForDistributionToolStripMenuItem;

		// Token: 0x04002E85 RID: 11909
		private ToolStripMenuItem pasteToolStripMenuItem;

		// Token: 0x04002EE3 RID: 12003
		private ToolStripMenuItem polygonStripMenuItem;

		// Token: 0x04002EA5 RID: 11941
		private ToolStripMenuItem quarterBeatsToolStripMenuItem;

		// Token: 0x04002ECA RID: 11978
		private ToolStripMenuItem quickReplyToolStripMenuItem;

		// Token: 0x04002EBD RID: 11965
		private ToolStripMenuItem recalculateSlidersToolStripMenuItem;

		// Token: 0x04002ED4 RID: 11988
		private ToolStripMenuItem resetAllSamplesToolStripMenuItem;

		// Token: 0x04002EAD RID: 11949
		private ToolStripMenuItem resetAllTimingsToolStripMenuItem;

		// Token: 0x04002EDF RID: 11999
		private ToolStripMenuItem resetBreaksToolStripMenuItem;

		// Token: 0x04002EDE RID: 11998
		private ToolStripMenuItem resetComboColoursToolStripMenuItem;

		// Token: 0x04002ECF RID: 11983
		private ToolStripMenuItem resetSliderStripMenuItem;

		// Token: 0x04002EBA RID: 11962
		private ToolStripMenuItem resnapAllNotesToolStripMenuItem;

		// Token: 0x04002EAA RID: 11946
		private ToolStripMenuItem retimeCurrentPointToolStripMenuItem;

		// Token: 0x04002EB0 RID: 11952
		private ToolStripMenuItem reverseSelectionToolStripMenuItem;

		// Token: 0x04002EB6 RID: 11958
		private ToolStripMenuItem rotateAnticlockwiseToolStripMenuItem;

		// Token: 0x04002EB5 RID: 11957
		private ToolStripMenuItem rotateClockwiseToolStripMenuItem;

		// Token: 0x04002ED0 RID: 11984
		private ToolStripMenuItem rotationByToolStripMenuItem;

		// Token: 0x04002EE6 RID: 12006
		private ToolStripMenuItem sampleImportToolStripMenuItem;

		// Token: 0x04002EB2 RID: 11954
		private ToolStripMenuItem saveAsToolStripMenuItem;

		// Token: 0x04002E81 RID: 11905
		private ToolStripMenuItem saveToolStripMenuItem;

		// Token: 0x04002EE0 RID: 12000
		private ToolStripMenuItem scaleByToolStripMenuItem;

		// Token: 0x04002E87 RID: 11911
		private ToolStripMenuItem selectAllToolStripMenuItem;

		// Token: 0x04002EBC RID: 11964
		private ToolStripMenuItem setPreviewPointToCurrentPositionToolStripMenuItem;

		// Token: 0x04002EED RID: 12013
		private ToolStripMenuItem showSampleNameToolStripMenuItem;

		// Token: 0x04002EE2 RID: 12002
		private ToolStripMenuItem showVideoToolStripMenuItem;

		// Token: 0x04002EC2 RID: 11970
		private ToolStripMenuItem signature34;

		// Token: 0x04002EC1 RID: 11969
		private ToolStripMenuItem signature44;

		// Token: 0x04002EF0 RID: 12016
		private ToolStripMenuItem snakingSlidersToolStripMenuItem;

		// Token: 0x04002EAE RID: 11950
		private ToolStripMenuItem snapAllNotesToolStripMenuItem;

		// Token: 0x04002EA2 RID: 11938
		private ToolStripMenuItem snapDivisorToolStripMenuItem;

		// Token: 0x04002EC4 RID: 11972
		private ToolStripMenuItem songSetupToolStripMenuItem;

		// Token: 0x04002EF3 RID: 12019
		private ToolStripMenuItem stackingToolStripMenuItem;

		// Token: 0x04002EBF RID: 11967
		private ToolStripMenuItem submitToolStripMenuItem;

		// Token: 0x04002EC3 RID: 11971
		private ToolStripMenuItem testBeatmapToolStripMenuItem;

		// Token: 0x04002ECB RID: 11979
		private ToolStripMenuItem thisBeatmapsInformationPageToolStripMenuItem;

		// Token: 0x04002EC9 RID: 11977
		private ToolStripMenuItem thisBeatmapsThreadToolStripMenuItem;

		// Token: 0x04002ED2 RID: 11986
		private ToolStripMenuItem timingSetupToolStripMenuItem;

		// Token: 0x04002EC0 RID: 11968
		private ToolStripMenuItem timingSignatureToolStripMenuItem;

		// Token: 0x04002EA0 RID: 11936
		private ToolStripMenuItem timingToolStripMenu;

		// Token: 0x04002E8E RID: 11918
		private ToolStripMenuItem timingToolStripMenuItem;

		// Token: 0x04002E88 RID: 11912
		private ToolStripSeparator toolStripSeparator1;

		// Token: 0x04002EBB RID: 11963
		private ToolStripSeparator toolStripSeparator10;

		// Token: 0x04002EC6 RID: 11974
		private ToolStripSeparator toolStripSeparator11;

		// Token: 0x04002EC5 RID: 11973
		private ToolStripSeparator toolStripSeparator12;

		// Token: 0x04002ECD RID: 11981
		private ToolStripSeparator toolStripSeparator13;

		// Token: 0x04002ED3 RID: 11987
		private ToolStripSeparator toolStripSeparator14;

		// Token: 0x04002ED6 RID: 11990
		private ToolStripSeparator toolStripSeparator15;

		// Token: 0x04002EDA RID: 11994
		private ToolStripSeparator toolStripSeparator16;

		// Token: 0x04002EDD RID: 11997
		private ToolStripSeparator toolStripSeparator17;

		// Token: 0x04002E8A RID: 11914
		private ToolStripSeparator toolStripSeparator2;

		// Token: 0x04002E96 RID: 11926
		private ToolStripSeparator toolStripSeparator3;

		// Token: 0x04002EDB RID: 11995
		private ToolStripSeparator toolStripSeparator4;

		// Token: 0x04002E9E RID: 11934
		private ToolStripSeparator toolStripSeparator5;

		// Token: 0x04002EA8 RID: 11944
		private ToolStripSeparator toolStripSeparator6;

		// Token: 0x04002EAC RID: 11948
		private ToolStripSeparator toolStripSeparator7;

		// Token: 0x04002EAF RID: 11951
		private ToolStripSeparator toolStripSeparator8;

		// Token: 0x04002EB9 RID: 11961
		private ToolStripSeparator toolStripSeparator9;

		// Token: 0x04002EEA RID: 12010
		private ToolStripMenuItem totalLoadToolStripMenuItem;

		// Token: 0x04002EA7 RID: 11943
		private ToolStripMenuItem tripletsToolStripMenuItem;

		// Token: 0x04002EC7 RID: 11975
		private ToolStripMenuItem viewFAQToolStripMenuItem;

		// Token: 0x04002E7C RID: 11900
		private ToolStripMenuItem viewToolStripMenu;

		// Token: 0x04002EEE RID: 12014
		private ToolStripMenuItem volumeToolStripMenuItem;

		// Token: 0x04002EC8 RID: 11976
		private ToolStripMenuItem webToolStripMenu;

		// Token: 0x0600324F RID: 12879
		// RVA: 0x000250B9 File Offset: 0x000232B9
		internal EditorControl()
		{
			this.InitializeComponent();
			this.method_12();
		}

		// Token: 0x060032AB RID: 12971
		// RVA: 0x0002564E File Offset: 0x0002384E
		private void addTimingPointToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Class115.class47_0.Add(new VoidDelegate(this.method_15), false);
		}

		// Token: 0x060032B7 RID: 12983
		// RVA: 0x0002578D File Offset: 0x0002398D
		private void addTimingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.class375_0.method_31(true);
		}

		// Token: 0x0600326E RID: 12910
		// RVA: 0x0002524E File Offset: 0x0002344E
		private void asReferenceToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_10(true);
		}

		// Token: 0x06003299 RID: 12953
		// RVA: 0x0002551B File Offset: 0x0002371B
		private void audioRate100ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_38(100);
		}

		// Token: 0x06003296 RID: 12950
		// RVA: 0x000254EE File Offset: 0x000236EE
		private void audioRate25ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_38(25);
		}

		// Token: 0x06003297 RID: 12951
		// RVA: 0x000254FD File Offset: 0x000236FD
		private void audioRate50ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_38(50);
		}

		// Token: 0x06003298 RID: 12952
		// RVA: 0x0002550C File Offset: 0x0002370C
		private void audioRate75ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_38(75);
		}

		// Token: 0x060032A6 RID: 12966
		// RVA: 0x000255D6 File Offset: 0x000237D6
		private void autoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.class371_0.method_70();
		}

		// Token: 0x0600329A RID: 12954
		// RVA: 0x0002552A File Offset: 0x0002372A
		private void beatSnappingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.class371_0.method_9(Enum106.flag_3);
		}

		// Token: 0x0600326C RID: 12908
		// RVA: 0x0015085C File Offset: 0x0014EA5C
		private void bmsbmeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.editor_0.class297_0.class296_0.method_5() != PlayModes.OsuMania)
			{
				Class723.smethod_1(Class41.GetString(OsuString.EditorControl_OnlyAvailableForMania), 2000);
				return;
			}
			Class115.smethod_6(true);
			ImportBMS importBMS = new ImportBMS();
			importBMS.ShowDialog();
			Class115.smethod_6(false);
		}

		// Token: 0x060032AF RID: 12975
		// RVA: 0x000256C7 File Offset: 0x000238C7
		private void bPMOffsetToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Class115.class47_0.Add(new VoidDelegate(this.method_16), false);
		}

		// Token: 0x06003273 RID: 12915
		// RVA: 0x000252A3 File Offset: 0x000234A3
		private void cloneToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.class371_0.method_34();
		}

		// Token: 0x06003286 RID: 12934
		// RVA: 0x000253C4 File Offset: 0x000235C4
		private void composeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_57(Enum105.const_1);
		}

		// Token: 0x060032A7 RID: 12967
		// RVA: 0x00150C1C File Offset: 0x0014EE1C
		private void composeToolStripMenu_DropDownOpening(object sender, EventArgs e)
		{
			if (this.editor_0.enum105_0 != Enum105.const_1)
			{
				this.polygonStripMenuItem.Enabled = false;
				this.convertSliderToStreamToolStripMenuItem.Enabled = false;
				return;
			}
			this.polygonStripMenuItem.Enabled = true;
			if (this.editor_0.class371_0.class321_1 != null)
			{
				this.convertSliderToStreamToolStripMenuItem.Enabled = true;
				return;
			}
			this.convertSliderToStreamToolStripMenuItem.Enabled = false;
		}

		// Token: 0x060032A3 RID: 12963
		// RVA: 0x000255BC File Offset: 0x000237BC
		private void convertSliderToStreamToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_93();
		}

		// Token: 0x06003271 RID: 12913
		// RVA: 0x00025289 File Offset: 0x00023489
		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_62();
		}

		// Token: 0x06003270 RID: 12912
		// RVA: 0x00025277 File Offset: 0x00023477
		private void cutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.class371_0.vmethod_32();
		}

		// Token: 0x060032AD RID: 12973
		// RVA: 0x000256A4 File Offset: 0x000238A4
		private void deleteTimingPointToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Class115.class47_0.Add(new VoidDelegate(this.editor_0.class375_0.method_32), false);
		}

		// Token: 0x06003274 RID: 12916
		// RVA: 0x000252B5 File Offset: 0x000234B5
		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.class371_0.vmethod_35();
		}

		// Token: 0x06003287 RID: 12935
		// RVA: 0x000253D2 File Offset: 0x000235D2
		private void designToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_57(Enum105.const_2);
		}

		// Token: 0x060032A9 RID: 12969
		// RVA: 0x000255E8 File Offset: 0x000237E8
		private void designToolStripMenu_DropDownOpening(object sender, EventArgs e)
		{
			if (this.editor_0.enum105_0 != Enum105.const_2)
			{
				this.moveAllElementsInTimeToolStripMenuItem.Enabled = false;
				return;
			}
			this.moveAllElementsInTimeToolStripMenuItem.Enabled = true;
		}

		// Token: 0x06003295 RID: 12949
		// RVA: 0x00150AF4 File Offset: 0x0014ECF4
		private void disableUndoStatesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.disableUndoStatesToolStripMenuItem.Checked = !this.disableUndoStatesToolStripMenuItem.Checked;
			Class341.class606_25.Value = this.disableUndoStatesToolStripMenuItem.Checked;
			if (Class341.class606_25)
			{
				this.editor_0.method_18();
			}
		}

		// Token: 0x060032BD RID: 12989
		// RVA: 0x000257F7 File Offset: 0x000239F7
		private void displayInlineHlpeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_56();
		}

		// Token: 0x06003250 RID: 12880
		// RVA: 0x000250CD File Offset: 0x000232CD
		internal new void Dispose()
		{
			this.method_8();
			base.Parent = null;
			base.Dispose();
		}

		// Token: 0x060032BF RID: 12991
		// RVA: 0x00025804 File Offset: 0x00023A04
		protected override void Dispose(bool disposing)
		{
			this.editor_0 = null;
			Class115.editorControl_0 = null;
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060032A0 RID: 12960
		// RVA: 0x0002559C File Offset: 0x0002379C
		private void doubleTripletsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.class371_0.method_4(6);
		}

		// Token: 0x06003285 RID: 12933
		// RVA: 0x001509AC File Offset: 0x0014EBAC
		private void editToolStripMenu_DropDownOpening(object sender, EventArgs e)
		{
			bool flag;
			if (this.editor_0.class371_0.list_1.Count != 0)
			{
				if (this.editor_0.enum105_0 == Enum105.const_1)
				{
					flag = true;
					goto IL_2D;
				}
			}
			flag = false;
			IL_2D:
			this.reverseSelectionToolStripMenuItem.Enabled = flag;
			this.flipHorizontallyToolStripMenuItem.Enabled = flag;
			this.flipVerticallyToolStripMenuItem.Enabled = flag;
			this.rotateClockwiseToolStripMenuItem.Enabled = flag;
			this.rotateAnticlockwiseToolStripMenuItem.Enabled = flag;
			this.rotationByToolStripMenuItem.Enabled = flag;
			this.scaleByToolStripMenuItem.Enabled = flag;
			if (flag)
			{
				flag = (this.editor_0.enum105_0 == Enum105.const_1);
			}
			this.cloneToolStripMenuItem.Enabled = flag;
			this.nudgeBackwardToolStripMenuItem.Enabled = flag;
			this.nudgeOneMeasureRightToolStripMenuItem.Enabled = flag;
		}

		// Token: 0x0600329E RID: 12958
		// RVA: 0x00025576 File Offset: 0x00023776
		private void eighthBeatsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.class371_0.method_4(8);
		}

		// Token: 0x060032A4 RID: 12964
		// RVA: 0x00150BB0 File Offset: 0x0014EDB0
		private void enableLiveMappingModeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.bool_10 = !this.editor_0.bool_10;
			this.enableLiveMappingModeToolStripMenuItem.Checked = this.editor_0.bool_10;
			Class723.smethod_1(this.editor_0.bool_10 ? Class41.GetString(OsuString.EditorModeCompose_LiveMappingEnabled) : Class41.GetString(OsuString.EditorModeCompose_LiveMappingDisabled), 3000);
		}

		// Token: 0x06003260 RID: 12896
		// RVA: 0x000251D1 File Offset: 0x000233D1
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_81();
		}

		// Token: 0x0600326A RID: 12906
		// RVA: 0x0015072C File Offset: 0x0014E92C
		private void extractMapPackageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Class296 class296_ = this.editor_0.class297_0.class296_0;
			if (!class296_.bool_10)
			{
				MessageBox.Show(Class41.GetString(OsuString.EditorControl_BeatmapAlreadyExtracted));
				return;
			}
			if (!class296_.method_10())
			{
				MessageBox.Show(Class41.GetString(OsuString.EditorControl_BeatmapProtectedFromExtraction));
				return;
			}
			if (!class296_.method_72(Class296.Enum64.const_0, false))
			{
				MessageBox.Show(Class41.GetString(OsuString.EditorControl_ExtractionFailed));
				return;
			}
			string fileName = string.Format("{0}\\explorer.exe", Environment.GetEnvironmentVariable("windir"));
			try
			{
				Process.Start(new ProcessStartInfo(fileName)
				{
					Arguments = "/n," + class296_.method_8()
				});
			}
			catch
			{
			}
		}

		// Token: 0x0600326F RID: 12911
		// RVA: 0x0002525C File Offset: 0x0002345C
		private void fileToolStripMenu_DropDownOpening(object sender, EventArgs e)
		{
			this.asReferenceToolStripMenuItem.Enabled = (this.editor_0.playModes_0 == PlayModes.OsuMania);
		}

		// Token: 0x06003276 RID: 12918
		// RVA: 0x000252D4 File Offset: 0x000234D4
		private void flipHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.class371_0.vmethod_33();
		}

		// Token: 0x06003277 RID: 12919
		// RVA: 0x000252E6 File Offset: 0x000234E6
		private void flipVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.class371_0.vmethod_34();
		}

		// Token: 0x06003292 RID: 12946
		// RVA: 0x000254BE File Offset: 0x000236BE
		private void followPointsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.followPointsToolStripMenuItem.Checked = !this.followPointsToolStripMenuItem.Checked;
			Class341.class606_21.Value = this.followPointsToolStripMenuItem.Checked;
		}

		// Token: 0x0600329B RID: 12955
		// RVA: 0x0002553D File Offset: 0x0002373D
		private void fullBeatsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.class371_0.method_4(1);
		}

		// Token: 0x0600328A RID: 12938
		// RVA: 0x000253FD File Offset: 0x000235FD
		private void gridSize2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_39(Editor.GridSizes.Medium);
		}

		// Token: 0x0600328B RID: 12939
		// RVA: 0x0002540C File Offset: 0x0002360C
		private void gridSize3ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_39(Editor.GridSizes.Small);
		}

		// Token: 0x0600329C RID: 12956
		// RVA: 0x00025550 File Offset: 0x00023750
		private void halfBeatsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.class371_0.method_4(2);
		}

		// Token: 0x06003291 RID: 12945
		// RVA: 0x000254AA File Offset: 0x000236AA
		private void hitAnimationsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.method_9(new VoidDelegate(this.method_14));
		}

		// Token: 0x060032C0 RID: 12992
		// RVA: 0x00150DDC File Offset: 0x0014EFDC
		private void InitializeComponent()
		{
			this.menuStrip1 = new MenuStrip();
			this.fileToolStripMenu = new ToolStripMenuItem();
			this.newToolStripMenuItem = new ToolStripMenuItem();
			this.openToolStripMenuItem = new ToolStripMenuItem();
			this.totalLoadToolStripMenuItem = new ToolStripMenuItem();
			this.asReferenceToolStripMenuItem = new ToolStripMenuItem();
			this.saveToolStripMenuItem = new ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator15 = new ToolStripSeparator();
			this.loadSoftToolStripMenuItem = new ToolStripMenuItem();
			this.loadToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator12 = new ToolStripSeparator();
			this.testBeatmapToolStripMenuItem = new ToolStripMenuItem();
			this.openAiModToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator17 = new ToolStripSeparator();
			this.submitToolStripMenuItem = new ToolStripMenuItem();
			this.packageForDistributionToolStripMenuItem = new ToolStripMenuItem();
			this.extractMapPackageToolStripMenuItem = new ToolStripMenuItem();
			this.importBMSToolStripMenuItem = new ToolStripMenuItem();
			this.bmsbmeToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator13 = new ToolStripSeparator();
			this.openSongFolder = new ToolStripMenuItem();
			this.openOsuInNotepad = new ToolStripMenuItem();
			this.openosbInNotepadToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator11 = new ToolStripSeparator();
			this.exitToolStripMenuItem = new ToolStripMenuItem();
			this.editToolStripMenu = new ToolStripMenuItem();
			this.menuItemUndo = new ToolStripMenuItem();
			this.menuItemRedo = new ToolStripMenuItem();
			this.toolStripSeparator9 = new ToolStripSeparator();
			this.cutToolStripMenuItem = new ToolStripMenuItem();
			this.copyToolStripMenuItem = new ToolStripMenuItem();
			this.pasteToolStripMenuItem = new ToolStripMenuItem();
			this.deleteToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.selectAllToolStripMenuItem = new ToolStripMenuItem();
			this.cloneToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator3 = new ToolStripSeparator();
			this.reverseSelectionToolStripMenuItem = new ToolStripMenuItem();
			this.flipHorizontallyToolStripMenuItem = new ToolStripMenuItem();
			this.flipVerticallyToolStripMenuItem = new ToolStripMenuItem();
			this.rotateClockwiseToolStripMenuItem = new ToolStripMenuItem();
			this.rotateAnticlockwiseToolStripMenuItem = new ToolStripMenuItem();
			this.rotationByToolStripMenuItem = new ToolStripMenuItem();
			this.scaleByToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator14 = new ToolStripSeparator();
			this.resetSliderStripMenuItem = new ToolStripMenuItem();
			this.resetAllSamplesToolStripMenuItem = new ToolStripMenuItem();
			this.resetComboColoursToolStripMenuItem = new ToolStripMenuItem();
			this.resetBreaksToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator2 = new ToolStripSeparator();
			this.nudgeBackwardToolStripMenuItem = new ToolStripMenuItem();
			this.nudgeOneMeasureRightToolStripMenuItem = new ToolStripMenuItem();
			this.viewToolStripMenu = new ToolStripMenuItem();
			this.composeToolStripMenuItem = new ToolStripMenuItem();
			this.designToolStripMenuItem = new ToolStripMenuItem();
			this.timingToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator4 = new ToolStripSeparator();
			this.songSetupToolStripMenuItem = new ToolStripMenuItem();
			this.timingSetupToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator16 = new ToolStripSeparator();
			this.volumeToolStripMenuItem = new ToolStripMenuItem();
			this.gridLevelToolStripMenuItem = new ToolStripMenuItem();
			this.mostSparseToolStripMenuItem = new ToolStripMenuItem();
			this.gridSize2ToolStripMenuItem = new ToolStripMenuItem();
			this.gridSize3ToolStripMenuItem = new ToolStripMenuItem();
			this.mostPreciseToolStripMenuItem = new ToolStripMenuItem();
			this.showVideoToolStripMenuItem = new ToolStripMenuItem();
			this.showSampleNameToolStripMenuItem = new ToolStripMenuItem();
			this.snakingSlidersToolStripMenuItem = new ToolStripMenuItem();
			this.hitAnimationsToolStripMenuItem = new ToolStripMenuItem();
			this.followPointsToolStripMenuItem = new ToolStripMenuItem();
			this.stackingToolStripMenuItem = new ToolStripMenuItem();
			this.disableUndoStatesToolStripMenuItem = new ToolStripMenuItem();
			this.composeToolStripMenu = new ToolStripMenuItem();
			this.snapDivisorToolStripMenuItem = new ToolStripMenuItem();
			this.fullBeatsToolStripMenuItem = new ToolStripMenuItem();
			this.halfBeatsToolStripMenuItem = new ToolStripMenuItem();
			this.quarterBeatsToolStripMenuItem = new ToolStripMenuItem();
			this.eighthBeatsToolStripMenuItem = new ToolStripMenuItem();
			this.tripletsToolStripMenuItem = new ToolStripMenuItem();
			this.doubleTripletsToolStripMenuItem = new ToolStripMenuItem();
			this.audioRateToolStripMenuItem = new ToolStripMenuItem();
			this.audioRate25ToolStripMenuItem = new ToolStripMenuItem();
			this.audioRate50ToolStripMenuItem = new ToolStripMenuItem();
			this.audioRate75ToolStripMenuItem = new ToolStripMenuItem();
			this.audioRate100ToolStripMenuItem = new ToolStripMenuItem();
			this.beatSnappingToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator5 = new ToolStripSeparator();
			this.polygonStripMenuItem = new ToolStripMenuItem();
			this.convertSliderToStreamToolStripMenuItem = new ToolStripMenuItem();
			this.enableLiveMappingModeToolStripMenuItem = new ToolStripMenuItem();
			this.sampleImportToolStripMenuItem = new ToolStripMenuItem();
			this.autoToolStripMenuItem = new ToolStripMenuItem();
			this.designToolStripMenu = new ToolStripMenuItem();
			this.moveAllElementsInTimeToolStripMenuItem = new ToolStripMenuItem();
			this.timingToolStripMenu = new ToolStripMenuItem();
			this.timingSignatureToolStripMenuItem = new ToolStripMenuItem();
			this.signature44 = new ToolStripMenuItem();
			this.signature34 = new ToolStripMenuItem();
			this.metronomeClicksToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator6 = new ToolStripSeparator();
			this.addTimingToolStripMenuItem = new ToolStripMenuItem();
			this.addTimingPointToolStripMenuItem = new ToolStripMenuItem();
			this.retimeCurrentPointToolStripMenuItem = new ToolStripMenuItem();
			this.deleteTimingPointToolStripMenuItem = new ToolStripMenuItem();
			this.snapAllNotesToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator8 = new ToolStripSeparator();
			this.bPMOffsetToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator7 = new ToolStripSeparator();
			this.resnapAllNotesToolStripMenuItem = new ToolStripMenuItem();
			this.moveAllNotesToolStripMenuItem = new ToolStripMenuItem();
			this.recalculateSlidersToolStripMenuItem = new ToolStripMenuItem();
			this.resetAllTimingsToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator10 = new ToolStripSeparator();
			this.setPreviewPointToCurrentPositionToolStripMenuItem = new ToolStripMenuItem();
			this.webToolStripMenu = new ToolStripMenuItem();
			this.thisBeatmapsInformationPageToolStripMenuItem = new ToolStripMenuItem();
			this.thisBeatmapsThreadToolStripMenuItem = new ToolStripMenuItem();
			this.quickReplyToolStripMenuItem = new ToolStripMenuItem();
			this.helpToolStripMenu = new ToolStripMenuItem();
			this.displayInlineHlpeToolStripMenuItem = new ToolStripMenuItem();
			this.viewFAQToolStripMenuItem = new ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.menuStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.fileToolStripMenu,
				this.editToolStripMenu,
				this.viewToolStripMenu,
				this.composeToolStripMenu,
				this.designToolStripMenu,
				this.timingToolStripMenu,
				this.webToolStripMenu,
				this.helpToolStripMenu
			});
			this.menuStrip1.Location = new Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.MenuActivate += new EventHandler(this.menuStrip1_MenuActivate);
			this.menuStrip1.MenuDeactivate += new EventHandler(this.menuStrip1_MenuDeactivate);
			this.fileToolStripMenu.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.newToolStripMenuItem,
				this.openToolStripMenuItem,
				this.saveToolStripMenuItem,
				this.saveAsToolStripMenuItem,
				this.toolStripSeparator15,
				this.loadSoftToolStripMenuItem,
				this.loadToolStripMenuItem,
				this.toolStripSeparator12,
				this.testBeatmapToolStripMenuItem,
				this.openAiModToolStripMenuItem,
				this.toolStripSeparator17,
				this.submitToolStripMenuItem,
				this.packageForDistributionToolStripMenuItem,
				this.extractMapPackageToolStripMenuItem,
				this.importBMSToolStripMenuItem,
				this.toolStripSeparator13,
				this.openSongFolder,
				this.openOsuInNotepad,
				this.openosbInNotepadToolStripMenuItem,
				this.toolStripSeparator11,
				this.exitToolStripMenuItem
			});
			this.fileToolStripMenu.Name = "fileToolStripMenu";
			this.fileToolStripMenu.Size = new Size(37, 20);
			this.fileToolStripMenu.Text = "&File";
			this.fileToolStripMenu.DropDownOpening += new EventHandler(this.fileToolStripMenu_DropDownOpening);
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
			this.newToolStripMenuItem.Size = new Size(257, 22);
			this.newToolStripMenuItem.Text = "Clear All &Notes";
			this.newToolStripMenuItem.Click += new EventHandler(this.newToolStripMenuItem_Click);
			this.openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.totalLoadToolStripMenuItem,
				this.asReferenceToolStripMenuItem
			});
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
			this.openToolStripMenuItem.Size = new Size(257, 22);
			this.openToolStripMenuItem.Text = "&Open Difficulty...";
			this.openToolStripMenuItem.Click += new EventHandler(this.openToolStripMenuItem_Click);
			this.totalLoadToolStripMenuItem.Name = "totalLoadToolStripMenuItem";
			this.totalLoadToolStripMenuItem.Size = new Size(146, 22);
			this.totalLoadToolStripMenuItem.Text = "For Editing";
			this.totalLoadToolStripMenuItem.Click += new EventHandler(this.totalLoadToolStripMenuItem_Click);
			this.asReferenceToolStripMenuItem.Enabled = false;
			this.asReferenceToolStripMenuItem.Name = "asReferenceToolStripMenuItem";
			this.asReferenceToolStripMenuItem.Size = new Size(146, 22);
			this.asReferenceToolStripMenuItem.Text = "For Reference";
			this.asReferenceToolStripMenuItem.Click += new EventHandler(this.asReferenceToolStripMenuItem_Click);
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
			this.saveToolStripMenuItem.Size = new Size(257, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			this.saveToolStripMenuItem.Click += new EventHandler(this.saveToolStripMenuItem_Click);
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new Size(257, 22);
			this.saveAsToolStripMenuItem.Text = "Save &as New Difficulty...";
			this.saveAsToolStripMenuItem.Click += new EventHandler(this.saveAsToolStripMenuItem_Click);
			this.toolStripSeparator15.Name = "toolStripSeparator15";
			this.toolStripSeparator15.Size = new Size(254, 6);
			this.loadSoftToolStripMenuItem.Name = "loadSoftToolStripMenuItem";
			this.loadSoftToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+L";
			this.loadSoftToolStripMenuItem.Size = new Size(257, 22);
			this.loadSoftToolStripMenuItem.Text = "&Revert to Saved";
			this.loadSoftToolStripMenuItem.Click += new EventHandler(this.loadSoftToolStripMenuItem_Click);
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+L";
			this.loadToolStripMenuItem.Size = new Size(257, 22);
			this.loadToolStripMenuItem.Text = "Revert to Saved (Full)";
			this.loadToolStripMenuItem.Click += new EventHandler(this.loadToolStripMenuItem_Click);
			this.toolStripSeparator12.Name = "toolStripSeparator12";
			this.toolStripSeparator12.Size = new Size(254, 6);
			this.testBeatmapToolStripMenuItem.Name = "testBeatmapToolStripMenuItem";
			this.testBeatmapToolStripMenuItem.ShortcutKeyDisplayString = "F5";
			this.testBeatmapToolStripMenuItem.Size = new Size(257, 22);
			this.testBeatmapToolStripMenuItem.Text = "&Test Beatmap";
			this.testBeatmapToolStripMenuItem.Click += new EventHandler(this.testBeatmapToolStripMenuItem_Click);
			this.openAiModToolStripMenuItem.Name = "openAiModToolStripMenuItem";
			this.openAiModToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+A";
			this.openAiModToolStripMenuItem.Size = new Size(257, 22);
			this.openAiModToolStripMenuItem.Text = "Open Ai&Mod";
			this.openAiModToolStripMenuItem.Click += new EventHandler(this.openAiModToolStripMenuItem_Click);
			this.toolStripSeparator17.Name = "toolStripSeparator17";
			this.toolStripSeparator17.Size = new Size(254, 6);
			this.submitToolStripMenuItem.Name = "submitToolStripMenuItem";
			this.submitToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+U";
			this.submitToolStripMenuItem.Size = new Size(257, 22);
			this.submitToolStripMenuItem.Text = "&Upload Beatmap...";
			this.submitToolStripMenuItem.Click += new EventHandler(this.submitToolStripMenuItem_Click);
			this.packageForDistributionToolStripMenuItem.Name = "packageForDistributionToolStripMenuItem";
			this.packageForDistributionToolStripMenuItem.Size = new Size(257, 22);
			this.packageForDistributionToolStripMenuItem.Text = "&Export Package...";
			this.packageForDistributionToolStripMenuItem.Click += new EventHandler(this.packageForDistributionToolStripMenuItem_Click);
			this.extractMapPackageToolStripMenuItem.Name = "extractMapPackageToolStripMenuItem";
			this.extractMapPackageToolStripMenuItem.Size = new Size(257, 22);
			this.extractMapPackageToolStripMenuItem.Text = "Extract Map Package";
			this.extractMapPackageToolStripMenuItem.Click += new EventHandler(this.extractMapPackageToolStripMenuItem_Click);
			this.importBMSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.bmsbmeToolStripMenuItem
			});
			this.importBMSToolStripMenuItem.Name = "importBMSToolStripMenuItem";
			this.importBMSToolStripMenuItem.Size = new Size(257, 22);
			this.importBMSToolStripMenuItem.Text = "Import from...";
			this.bmsbmeToolStripMenuItem.Name = "bmsbmeToolStripMenuItem";
			this.bmsbmeToolStripMenuItem.Size = new Size(126, 22);
			this.bmsbmeToolStripMenuItem.Text = "bms/bme";
			this.bmsbmeToolStripMenuItem.Click += new EventHandler(this.bmsbmeToolStripMenuItem_Click);
			this.toolStripSeparator13.Name = "toolStripSeparator13";
			this.toolStripSeparator13.Size = new Size(254, 6);
			this.openSongFolder.Name = "openSongFolder";
			this.openSongFolder.Size = new Size(257, 22);
			this.openSongFolder.Text = "Open Song Fold&er";
			this.openSongFolder.Click += new EventHandler(this.openSongFolder_Click);
			this.openOsuInNotepad.Name = "openOsuInNotepad";
			this.openOsuInNotepad.Size = new Size(257, 22);
			this.openOsuInNotepad.Text = "Open .osu in Notepad";
			this.openOsuInNotepad.Click += new EventHandler(this.openOsuInNotepad_Click);
			this.openosbInNotepadToolStripMenuItem.Name = "openosbInNotepadToolStripMenuItem";
			this.openosbInNotepadToolStripMenuItem.Size = new Size(257, 22);
			this.openosbInNotepadToolStripMenuItem.Text = "Open .osb in Notepad";
			this.openosbInNotepadToolStripMenuItem.Click += new EventHandler(this.openosbInNotepadToolStripMenuItem_Click);
			this.toolStripSeparator11.Name = "toolStripSeparator11";
			this.toolStripSeparator11.Size = new Size(254, 6);
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeyDisplayString = "Esc";
			this.exitToolStripMenuItem.Size = new Size(257, 22);
			this.exitToolStripMenuItem.Text = "E&xit...";
			this.exitToolStripMenuItem.Click += new EventHandler(this.exitToolStripMenuItem_Click);
			this.editToolStripMenu.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.menuItemUndo,
				this.menuItemRedo,
				this.toolStripSeparator9,
				this.cutToolStripMenuItem,
				this.copyToolStripMenuItem,
				this.pasteToolStripMenuItem,
				this.deleteToolStripMenuItem,
				this.toolStripSeparator1,
				this.selectAllToolStripMenuItem,
				this.cloneToolStripMenuItem,
				this.toolStripSeparator3,
				this.reverseSelectionToolStripMenuItem,
				this.flipHorizontallyToolStripMenuItem,
				this.flipVerticallyToolStripMenuItem,
				this.rotateClockwiseToolStripMenuItem,
				this.rotateAnticlockwiseToolStripMenuItem,
				this.rotationByToolStripMenuItem,
				this.scaleByToolStripMenuItem,
				this.toolStripSeparator14,
				this.resetSliderStripMenuItem,
				this.resetAllSamplesToolStripMenuItem,
				this.resetComboColoursToolStripMenuItem,
				this.resetBreaksToolStripMenuItem,
				this.toolStripSeparator2,
				this.nudgeBackwardToolStripMenuItem,
				this.nudgeOneMeasureRightToolStripMenuItem
			});
			this.editToolStripMenu.Name = "editToolStripMenu";
			this.editToolStripMenu.Size = new Size(39, 20);
			this.editToolStripMenu.Text = "&Edit";
			this.editToolStripMenu.DropDownOpening += new EventHandler(this.editToolStripMenu_DropDownOpening);
			this.menuItemUndo.Enabled = false;
			this.menuItemUndo.Name = "menuItemUndo";
			this.menuItemUndo.ShortcutKeyDisplayString = "Ctrl+Z";
			this.menuItemUndo.Size = new Size(246, 22);
			this.menuItemUndo.Text = "Undo";
			this.menuItemUndo.Click += new EventHandler(this.menuItemUndo_Click);
			this.menuItemRedo.Enabled = false;
			this.menuItemRedo.Name = "menuItemRedo";
			this.menuItemRedo.ShortcutKeyDisplayString = "Ctrl+Y";
			this.menuItemRedo.Size = new Size(246, 22);
			this.menuItemRedo.Text = "Redo";
			this.menuItemRedo.Click += new EventHandler(this.menuItemRedo_Click);
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new Size(243, 6);
			this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			this.cutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
			this.cutToolStripMenuItem.Size = new Size(246, 22);
			this.cutToolStripMenuItem.Text = "Cu&t";
			this.cutToolStripMenuItem.Click += new EventHandler(this.cutToolStripMenuItem_Click);
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
			this.copyToolStripMenuItem.Size = new Size(246, 22);
			this.copyToolStripMenuItem.Text = "&Copy";
			this.copyToolStripMenuItem.Click += new EventHandler(this.copyToolStripMenuItem_Click);
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+V";
			this.pasteToolStripMenuItem.Size = new Size(246, 22);
			this.pasteToolStripMenuItem.Text = "&Paste";
			this.pasteToolStripMenuItem.Click += new EventHandler(this.pasteToolStripMenuItem_Click);
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.ShortcutKeyDisplayString = "Del";
			this.deleteToolStripMenuItem.Size = new Size(246, 22);
			this.deleteToolStripMenuItem.Text = "&Delete";
			this.deleteToolStripMenuItem.Click += new EventHandler(this.deleteToolStripMenuItem_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(243, 6);
			this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			this.selectAllToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
			this.selectAllToolStripMenuItem.Size = new Size(246, 22);
			this.selectAllToolStripMenuItem.Text = "Select &All";
			this.selectAllToolStripMenuItem.Click += new EventHandler(this.selectAllToolStripMenuItem_Click);
			this.cloneToolStripMenuItem.Name = "cloneToolStripMenuItem";
			this.cloneToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+D";
			this.cloneToolStripMenuItem.Size = new Size(246, 22);
			this.cloneToolStripMenuItem.Text = "C&lone";
			this.cloneToolStripMenuItem.Click += new EventHandler(this.cloneToolStripMenuItem_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new Size(243, 6);
			this.reverseSelectionToolStripMenuItem.Name = "reverseSelectionToolStripMenuItem";
			this.reverseSelectionToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+G";
			this.reverseSelectionToolStripMenuItem.Size = new Size(246, 22);
			this.reverseSelectionToolStripMenuItem.Text = "&Reverse Selection";
			this.reverseSelectionToolStripMenuItem.Click += new EventHandler(this.reverseSelectionToolStripMenuItem_Click);
			this.flipHorizontallyToolStripMenuItem.Name = "flipHorizontallyToolStripMenuItem";
			this.flipHorizontallyToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+H";
			this.flipHorizontallyToolStripMenuItem.Size = new Size(246, 22);
			this.flipHorizontallyToolStripMenuItem.Text = "Flip &Horizontally";
			this.flipHorizontallyToolStripMenuItem.Click += new EventHandler(this.flipHorizontallyToolStripMenuItem_Click);
			this.flipVerticallyToolStripMenuItem.Name = "flipVerticallyToolStripMenuItem";
			this.flipVerticallyToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+J";
			this.flipVerticallyToolStripMenuItem.Size = new Size(246, 22);
			this.flipVerticallyToolStripMenuItem.Text = "Flip &Vertically";
			this.flipVerticallyToolStripMenuItem.Click += new EventHandler(this.flipVerticallyToolStripMenuItem_Click);
			this.rotateClockwiseToolStripMenuItem.Name = "rotateClockwiseToolStripMenuItem";
			this.rotateClockwiseToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+>";
			this.rotateClockwiseToolStripMenuItem.Size = new Size(246, 22);
			this.rotateClockwiseToolStripMenuItem.Text = "Rotate 90° Cl&ockwise";
			this.rotateClockwiseToolStripMenuItem.Click += new EventHandler(this.rotateClockwiseToolStripMenuItem_Click);
			this.rotateAnticlockwiseToolStripMenuItem.Name = "rotateAnticlockwiseToolStripMenuItem";
			this.rotateAnticlockwiseToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+<";
			this.rotateAnticlockwiseToolStripMenuItem.Size = new Size(246, 22);
			this.rotateAnticlockwiseToolStripMenuItem.Text = "Rotate 90° Antic&lockwise";
			this.rotateAnticlockwiseToolStripMenuItem.Click += new EventHandler(this.rotateAnticlockwiseToolStripMenuItem_Click);
			this.rotationByToolStripMenuItem.Name = "rotationByToolStripMenuItem";
			this.rotationByToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+R";
			this.rotationByToolStripMenuItem.Size = new Size(246, 22);
			this.rotationByToolStripMenuItem.Text = "Rotate by...";
			this.rotationByToolStripMenuItem.Click += new EventHandler(this.rotationByToolStripMenuItem_Click);
			this.scaleByToolStripMenuItem.Name = "scaleByToolStripMenuItem";
			this.scaleByToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+S";
			this.scaleByToolStripMenuItem.Size = new Size(246, 22);
			this.scaleByToolStripMenuItem.Text = "Scale by...";
			this.scaleByToolStripMenuItem.Click += new EventHandler(this.scaleByToolStripMenuItem_Click);
			this.toolStripSeparator14.Name = "toolStripSeparator14";
			this.toolStripSeparator14.Size = new Size(243, 6);
			this.resetSliderStripMenuItem.Name = "resetSliderStripMenuItem";
			this.resetSliderStripMenuItem.ShortcutKeyDisplayString = "";
			this.resetSliderStripMenuItem.Size = new Size(246, 22);
			this.resetSliderStripMenuItem.Text = "Reset selected objects' samples";
			this.resetSliderStripMenuItem.Click += new EventHandler(this.resetSliderStripMenuItem_Click);
			this.resetAllSamplesToolStripMenuItem.ForeColor = Color.Red;
			this.resetAllSamplesToolStripMenuItem.Name = "resetAllSamplesToolStripMenuItem";
			this.resetAllSamplesToolStripMenuItem.Size = new Size(246, 22);
			this.resetAllSamplesToolStripMenuItem.Text = "Reset all samples";
			this.resetAllSamplesToolStripMenuItem.Click += new EventHandler(this.resetAllSamplesToolStripMenuItem_Click);
			this.resetComboColoursToolStripMenuItem.ForeColor = Color.Red;
			this.resetComboColoursToolStripMenuItem.Name = "resetComboColoursToolStripMenuItem";
			this.resetComboColoursToolStripMenuItem.Size = new Size(246, 22);
			this.resetComboColoursToolStripMenuItem.Text = "Reset combo colours";
			this.resetComboColoursToolStripMenuItem.Click += new EventHandler(this.resetComboColoursToolStripMenuItem_Click);
			this.resetBreaksToolStripMenuItem.ForeColor = Color.Red;
			this.resetBreaksToolStripMenuItem.Name = "resetBreaksToolStripMenuItem";
			this.resetBreaksToolStripMenuItem.Size = new Size(246, 22);
			this.resetBreaksToolStripMenuItem.Text = "Reset breaks";
			this.resetBreaksToolStripMenuItem.Click += new EventHandler(this.resetBreaksToolStripMenuItem_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new Size(243, 6);
			this.nudgeBackwardToolStripMenuItem.Name = "nudgeBackwardToolStripMenuItem";
			this.nudgeBackwardToolStripMenuItem.ShortcutKeyDisplayString = "J";
			this.nudgeBackwardToolStripMenuItem.Size = new Size(246, 22);
			this.nudgeBackwardToolStripMenuItem.Text = "Nudge &Backward";
			this.nudgeBackwardToolStripMenuItem.Click += new EventHandler(this.nudgeBackwardToolStripMenuItem_Click);
			this.nudgeOneMeasureRightToolStripMenuItem.Name = "nudgeOneMeasureRightToolStripMenuItem";
			this.nudgeOneMeasureRightToolStripMenuItem.ShortcutKeyDisplayString = "K";
			this.nudgeOneMeasureRightToolStripMenuItem.Size = new Size(246, 22);
			this.nudgeOneMeasureRightToolStripMenuItem.Text = "Nudge &Forward";
			this.nudgeOneMeasureRightToolStripMenuItem.Click += new EventHandler(this.nudgeOneMeasureRightToolStripMenuItem_Click);
			this.viewToolStripMenu.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.composeToolStripMenuItem,
				this.designToolStripMenuItem,
				this.timingToolStripMenuItem,
				this.toolStripSeparator4,
				this.songSetupToolStripMenuItem,
				this.timingSetupToolStripMenuItem,
				this.toolStripSeparator16,
				this.volumeToolStripMenuItem,
				this.gridLevelToolStripMenuItem,
				this.showVideoToolStripMenuItem,
				this.showSampleNameToolStripMenuItem,
				this.snakingSlidersToolStripMenuItem,
				this.hitAnimationsToolStripMenuItem,
				this.followPointsToolStripMenuItem,
				this.stackingToolStripMenuItem,
				this.disableUndoStatesToolStripMenuItem
			});
			this.viewToolStripMenu.Name = "viewToolStripMenu";
			this.viewToolStripMenu.Size = new Size(44, 20);
			this.viewToolStripMenu.Text = "&View";
			this.composeToolStripMenuItem.Checked = true;
			this.composeToolStripMenuItem.CheckState = CheckState.Checked;
			this.composeToolStripMenuItem.Name = "composeToolStripMenuItem";
			this.composeToolStripMenuItem.ShortcutKeyDisplayString = "F1";
			this.composeToolStripMenuItem.Size = new Size(180, 22);
			this.composeToolStripMenuItem.Text = "&Compose";
			this.composeToolStripMenuItem.Click += new EventHandler(this.composeToolStripMenuItem_Click);
			this.designToolStripMenuItem.Name = "designToolStripMenuItem";
			this.designToolStripMenuItem.ShortcutKeyDisplayString = "F2";
			this.designToolStripMenuItem.Size = new Size(180, 22);
			this.designToolStripMenuItem.Text = "&Design";
			this.designToolStripMenuItem.Click += new EventHandler(this.designToolStripMenuItem_Click);
			this.timingToolStripMenuItem.Name = "timingToolStripMenuItem";
			this.timingToolStripMenuItem.ShortcutKeyDisplayString = "F3";
			this.timingToolStripMenuItem.Size = new Size(180, 22);
			this.timingToolStripMenuItem.Text = "&Timing";
			this.timingToolStripMenuItem.Click += new EventHandler(this.timingToolStripMenuItem_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new Size(177, 6);
			this.songSetupToolStripMenuItem.Name = "songSetupToolStripMenuItem";
			this.songSetupToolStripMenuItem.ShortcutKeyDisplayString = "F4";
			this.songSetupToolStripMenuItem.Size = new Size(180, 22);
			this.songSetupToolStripMenuItem.Text = "Song &Setup...";
			this.songSetupToolStripMenuItem.Click += new EventHandler(this.songSetupToolStripMenuItem_Click);
			this.timingSetupToolStripMenuItem.Name = "timingSetupToolStripMenuItem";
			this.timingSetupToolStripMenuItem.ShortcutKeyDisplayString = "F6";
			this.timingSetupToolStripMenuItem.Size = new Size(180, 22);
			this.timingSetupToolStripMenuItem.Text = "Timing Setup...";
			this.timingSetupToolStripMenuItem.Click += new EventHandler(this.timingSetupToolStripMenuItem_Click);
			this.toolStripSeparator16.Name = "toolStripSeparator16";
			this.toolStripSeparator16.Size = new Size(177, 6);
			this.volumeToolStripMenuItem.Name = "volumeToolStripMenuItem";
			this.volumeToolStripMenuItem.Size = new Size(180, 22);
			this.volumeToolStripMenuItem.Text = "Volume";
			this.volumeToolStripMenuItem.Click += new EventHandler(this.volumeToolStripMenuItem_Click);
			this.gridLevelToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.mostSparseToolStripMenuItem,
				this.gridSize2ToolStripMenuItem,
				this.gridSize3ToolStripMenuItem,
				this.mostPreciseToolStripMenuItem
			});
			this.gridLevelToolStripMenuItem.Name = "gridLevelToolStripMenuItem";
			this.gridLevelToolStripMenuItem.ShortcutKeyDisplayString = "G";
			this.gridLevelToolStripMenuItem.Size = new Size(180, 22);
			this.gridLevelToolStripMenuItem.Text = "&Grid Level";
			this.mostSparseToolStripMenuItem.Name = "mostSparseToolStripMenuItem";
			this.mostSparseToolStripMenuItem.Size = new Size(158, 22);
			this.mostSparseToolStripMenuItem.Text = "&1 (Most sparse)";
			this.mostSparseToolStripMenuItem.Click += new EventHandler(this.mostSparseToolStripMenuItem_Click);
			this.gridSize2ToolStripMenuItem.Checked = true;
			this.gridSize2ToolStripMenuItem.CheckState = CheckState.Checked;
			this.gridSize2ToolStripMenuItem.Name = "gridSize2ToolStripMenuItem";
			this.gridSize2ToolStripMenuItem.Size = new Size(158, 22);
			this.gridSize2ToolStripMenuItem.Text = "&2";
			this.gridSize2ToolStripMenuItem.Click += new EventHandler(this.gridSize2ToolStripMenuItem_Click);
			this.gridSize3ToolStripMenuItem.Name = "gridSize3ToolStripMenuItem";
			this.gridSize3ToolStripMenuItem.Size = new Size(158, 22);
			this.gridSize3ToolStripMenuItem.Text = "&3";
			this.gridSize3ToolStripMenuItem.Click += new EventHandler(this.gridSize3ToolStripMenuItem_Click);
			this.mostPreciseToolStripMenuItem.Name = "mostPreciseToolStripMenuItem";
			this.mostPreciseToolStripMenuItem.Size = new Size(158, 22);
			this.mostPreciseToolStripMenuItem.Text = "&4 (Most precise)";
			this.mostPreciseToolStripMenuItem.Click += new EventHandler(this.mostPreciseToolStripMenuItem_Click);
			this.showVideoToolStripMenuItem.Name = "showVideoToolStripMenuItem";
			this.showVideoToolStripMenuItem.Size = new Size(180, 22);
			this.showVideoToolStripMenuItem.Text = "Show Video";
			this.showVideoToolStripMenuItem.Click += new EventHandler(this.showVideoToolStripMenuItem_Click);
			this.showSampleNameToolStripMenuItem.Name = "showSampleNameToolStripMenuItem";
			this.showSampleNameToolStripMenuItem.Size = new Size(180, 22);
			this.showSampleNameToolStripMenuItem.Text = "Show Sample Name";
			this.showSampleNameToolStripMenuItem.Click += new EventHandler(this.showSampleNameToolStripMenuItem_Click);
			this.snakingSlidersToolStripMenuItem.Name = "snakingSlidersToolStripMenuItem";
			this.snakingSlidersToolStripMenuItem.Size = new Size(180, 22);
			this.snakingSlidersToolStripMenuItem.Text = "Snaking Sliders";
			this.snakingSlidersToolStripMenuItem.Click += new EventHandler(this.snakingSlidersToolStripMenuItem_Click);
			this.hitAnimationsToolStripMenuItem.Name = "hitAnimationsToolStripMenuItem";
			this.hitAnimationsToolStripMenuItem.Size = new Size(180, 22);
			this.hitAnimationsToolStripMenuItem.Text = "Hit Animations";
			this.hitAnimationsToolStripMenuItem.Click += new EventHandler(this.hitAnimationsToolStripMenuItem_Click);
			this.followPointsToolStripMenuItem.Name = "followPointsToolStripMenuItem";
			this.followPointsToolStripMenuItem.Size = new Size(180, 22);
			this.followPointsToolStripMenuItem.Text = "Follow Points";
			this.followPointsToolStripMenuItem.Click += new EventHandler(this.followPointsToolStripMenuItem_Click);
			this.stackingToolStripMenuItem.Name = "stackingToolStripMenuItem";
			this.stackingToolStripMenuItem.Size = new Size(180, 22);
			this.stackingToolStripMenuItem.Text = "Stacking";
			this.stackingToolStripMenuItem.Click += new EventHandler(this.stackingToolStripMenuItem_Click);
			this.disableUndoStatesToolStripMenuItem.Name = "disableUndoStatesToolStripMenuItem";
			this.disableUndoStatesToolStripMenuItem.Size = new Size(180, 22);
			this.disableUndoStatesToolStripMenuItem.Text = "Disable Undo States";
			this.disableUndoStatesToolStripMenuItem.Click += new EventHandler(this.disableUndoStatesToolStripMenuItem_Click);
			this.composeToolStripMenu.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.snapDivisorToolStripMenuItem,
				this.audioRateToolStripMenuItem,
				this.beatSnappingToolStripMenuItem,
				this.toolStripSeparator5,
				this.polygonStripMenuItem,
				this.convertSliderToStreamToolStripMenuItem,
				this.enableLiveMappingModeToolStripMenuItem,
				this.sampleImportToolStripMenuItem,
				this.autoToolStripMenuItem
			});
			this.composeToolStripMenu.Name = "composeToolStripMenu";
			this.composeToolStripMenu.Size = new Size(70, 20);
			this.composeToolStripMenu.Text = "&Compose";
			this.composeToolStripMenu.DropDownOpening += new EventHandler(this.composeToolStripMenu_DropDownOpening);
			this.snapDivisorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.fullBeatsToolStripMenuItem,
				this.halfBeatsToolStripMenuItem,
				this.quarterBeatsToolStripMenuItem,
				this.eighthBeatsToolStripMenuItem,
				this.tripletsToolStripMenuItem,
				this.doubleTripletsToolStripMenuItem
			});
			this.snapDivisorToolStripMenuItem.Name = "snapDivisorToolStripMenuItem";
			this.snapDivisorToolStripMenuItem.ShortcutKeyDisplayString = "M";
			this.snapDivisorToolStripMenuItem.Size = new Size(269, 22);
			this.snapDivisorToolStripMenuItem.Text = "Snap Di&visor";
			this.fullBeatsToolStripMenuItem.Name = "fullBeatsToolStripMenuItem";
			this.fullBeatsToolStripMenuItem.Size = new Size(179, 22);
			this.fullBeatsToolStripMenuItem.Text = "1/1 Full Beats";
			this.fullBeatsToolStripMenuItem.Click += new EventHandler(this.fullBeatsToolStripMenuItem_Click);
			this.halfBeatsToolStripMenuItem.Checked = true;
			this.halfBeatsToolStripMenuItem.CheckState = CheckState.Checked;
			this.halfBeatsToolStripMenuItem.Name = "halfBeatsToolStripMenuItem";
			this.halfBeatsToolStripMenuItem.Size = new Size(179, 22);
			this.halfBeatsToolStripMenuItem.Text = "1/2 Half Beats";
			this.halfBeatsToolStripMenuItem.Click += new EventHandler(this.halfBeatsToolStripMenuItem_Click);
			this.quarterBeatsToolStripMenuItem.Name = "quarterBeatsToolStripMenuItem";
			this.quarterBeatsToolStripMenuItem.Size = new Size(179, 22);
			this.quarterBeatsToolStripMenuItem.Text = "1/4 Quarter Beats";
			this.quarterBeatsToolStripMenuItem.Click += new EventHandler(this.quarterBeatsToolStripMenuItem_Click);
			this.eighthBeatsToolStripMenuItem.Name = "eighthBeatsToolStripMenuItem";
			this.eighthBeatsToolStripMenuItem.Size = new Size(179, 22);
			this.eighthBeatsToolStripMenuItem.Text = "1/8 Eighth Beats";
			this.eighthBeatsToolStripMenuItem.Click += new EventHandler(this.eighthBeatsToolStripMenuItem_Click);
			this.tripletsToolStripMenuItem.Name = "tripletsToolStripMenuItem";
			this.tripletsToolStripMenuItem.Size = new Size(179, 22);
			this.tripletsToolStripMenuItem.Text = "1/3 Triplets*";
			this.tripletsToolStripMenuItem.Click += new EventHandler(this.tripletsToolStripMenuItem_Click);
			this.doubleTripletsToolStripMenuItem.Name = "doubleTripletsToolStripMenuItem";
			this.doubleTripletsToolStripMenuItem.Size = new Size(179, 22);
			this.doubleTripletsToolStripMenuItem.Text = "1/6 Double Triplets*";
			this.doubleTripletsToolStripMenuItem.Click += new EventHandler(this.doubleTripletsToolStripMenuItem_Click);
			this.audioRateToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.audioRate25ToolStripMenuItem,
				this.audioRate50ToolStripMenuItem,
				this.audioRate75ToolStripMenuItem,
				this.audioRate100ToolStripMenuItem
			});
			this.audioRateToolStripMenuItem.Name = "audioRateToolStripMenuItem";
			this.audioRateToolStripMenuItem.Size = new Size(269, 22);
			this.audioRateToolStripMenuItem.Text = "Audio &Rate";
			this.audioRate25ToolStripMenuItem.Name = "audioRate25ToolStripMenuItem";
			this.audioRate25ToolStripMenuItem.Size = new Size(102, 22);
			this.audioRate25ToolStripMenuItem.Text = "25%";
			this.audioRate25ToolStripMenuItem.Click += new EventHandler(this.audioRate25ToolStripMenuItem_Click);
			this.audioRate50ToolStripMenuItem.Name = "audioRate50ToolStripMenuItem";
			this.audioRate50ToolStripMenuItem.Size = new Size(102, 22);
			this.audioRate50ToolStripMenuItem.Text = "50%";
			this.audioRate50ToolStripMenuItem.Click += new EventHandler(this.audioRate50ToolStripMenuItem_Click);
			this.audioRate75ToolStripMenuItem.Name = "audioRate75ToolStripMenuItem";
			this.audioRate75ToolStripMenuItem.Size = new Size(102, 22);
			this.audioRate75ToolStripMenuItem.Text = "75%";
			this.audioRate75ToolStripMenuItem.Click += new EventHandler(this.audioRate75ToolStripMenuItem_Click);
			this.audioRate100ToolStripMenuItem.Checked = true;
			this.audioRate100ToolStripMenuItem.CheckState = CheckState.Checked;
			this.audioRate100ToolStripMenuItem.Name = "audioRate100ToolStripMenuItem";
			this.audioRate100ToolStripMenuItem.Size = new Size(102, 22);
			this.audioRate100ToolStripMenuItem.Text = "100%";
			this.audioRate100ToolStripMenuItem.Click += new EventHandler(this.audioRate100ToolStripMenuItem_Click);
			this.beatSnappingToolStripMenuItem.Name = "beatSnappingToolStripMenuItem";
			this.beatSnappingToolStripMenuItem.ShortcutKeyDisplayString = "T";
			this.beatSnappingToolStripMenuItem.Size = new Size(269, 22);
			this.beatSnappingToolStripMenuItem.Text = "&Grid Snapping";
			this.beatSnappingToolStripMenuItem.Click += new EventHandler(this.beatSnappingToolStripMenuItem_Click);
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new Size(266, 6);
			this.polygonStripMenuItem.Name = "polygonStripMenuItem";
			this.polygonStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+D";
			this.polygonStripMenuItem.Size = new Size(269, 22);
			this.polygonStripMenuItem.Text = "Create &Polygon Circles";
			this.polygonStripMenuItem.Click += new EventHandler(this.polygonStripMenuItem_Click);
			this.convertSliderToStreamToolStripMenuItem.Name = "convertSliderToStreamToolStripMenuItem";
			this.convertSliderToStreamToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+F";
			this.convertSliderToStreamToolStripMenuItem.Size = new Size(272, 22);
			this.convertSliderToStreamToolStripMenuItem.Text = "Convert slider to &stream";
			this.convertSliderToStreamToolStripMenuItem.Click += new EventHandler(this.convertSliderToStreamToolStripMenuItem_Click);
			this.enableLiveMappingModeToolStripMenuItem.Name = "enableLiveMappingModeToolStripMenuItem";
			this.enableLiveMappingModeToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Tab";
			this.enableLiveMappingModeToolStripMenuItem.Size = new Size(269, 22);
			this.enableLiveMappingModeToolStripMenuItem.Text = "Enable live mapping mode";
			this.enableLiveMappingModeToolStripMenuItem.Click += new EventHandler(this.enableLiveMappingModeToolStripMenuItem_Click);
			this.sampleImportToolStripMenuItem.Name = "sampleImportToolStripMenuItem";
			this.sampleImportToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+I";
			this.sampleImportToolStripMenuItem.Size = new Size(269, 22);
			this.sampleImportToolStripMenuItem.Text = "Sample import";
			this.sampleImportToolStripMenuItem.Click += new EventHandler(this.sampleImportToolStripMenuItem_Click);
			this.autoToolStripMenuItem.Name = "autoToolStripMenuItem";
			this.autoToolStripMenuItem.Size = new Size(269, 22);
			this.autoToolStripMenuItem.Text = "Auto volume balance";
			this.autoToolStripMenuItem.Visible = false;
			this.autoToolStripMenuItem.Click += new EventHandler(this.autoToolStripMenuItem_Click);
			this.designToolStripMenu.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.moveAllElementsInTimeToolStripMenuItem
			});
			this.designToolStripMenu.Name = "designToolStripMenu";
			this.designToolStripMenu.Size = new Size(55, 20);
			this.designToolStripMenu.Text = "&Design";
			this.designToolStripMenu.DropDownOpening += new EventHandler(this.designToolStripMenu_DropDownOpening);
			this.moveAllElementsInTimeToolStripMenuItem.Name = "moveAllElementsInTimeToolStripMenuItem";
			this.moveAllElementsInTimeToolStripMenuItem.Size = new Size(219, 22);
			this.moveAllElementsInTimeToolStripMenuItem.Text = "Move all elements in time...";
			this.moveAllElementsInTimeToolStripMenuItem.Click += new EventHandler(this.moveAllElementsInTimeToolStripMenuItem_Click);
			this.timingToolStripMenu.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.timingSignatureToolStripMenuItem,
				this.metronomeClicksToolStripMenuItem,
				this.toolStripSeparator6,
				this.addTimingToolStripMenuItem,
				this.addTimingPointToolStripMenuItem,
				this.retimeCurrentPointToolStripMenuItem,
				this.deleteTimingPointToolStripMenuItem,
				this.snapAllNotesToolStripMenuItem,
				this.toolStripSeparator8,
				this.bPMOffsetToolStripMenuItem,
				this.toolStripSeparator7,
				this.resnapAllNotesToolStripMenuItem,
				this.moveAllNotesToolStripMenuItem,
				this.recalculateSlidersToolStripMenuItem,
				this.resetAllTimingsToolStripMenuItem,
				this.toolStripSeparator10,
				this.setPreviewPointToCurrentPositionToolStripMenuItem
			});
			this.timingToolStripMenu.Name = "timingToolStripMenu";
			this.timingToolStripMenu.Size = new Size(57, 20);
			this.timingToolStripMenu.Text = "&Timing";
			this.timingSignatureToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.signature44,
				this.signature34
			});
			this.timingSignatureToolStripMenuItem.Name = "timingSignatureToolStripMenuItem";
			this.timingSignatureToolStripMenuItem.Size = new Size(268, 22);
			this.timingSignatureToolStripMenuItem.Text = "Time Signature";
			this.signature44.Name = "signature44";
			this.signature44.Size = new Size(183, 22);
			this.signature44.Text = "4/4 (Common Time)";
			this.signature44.Click += new EventHandler(this.signature44_Click);
			this.signature34.Name = "signature34";
			this.signature34.Size = new Size(183, 22);
			this.signature34.Text = "3/4 (Waltz/Triple)";
			this.signature34.Click += new EventHandler(this.signature34_Click);
			this.metronomeClicksToolStripMenuItem.Checked = true;
			this.metronomeClicksToolStripMenuItem.CheckState = CheckState.Checked;
			this.metronomeClicksToolStripMenuItem.Name = "metronomeClicksToolStripMenuItem";
			this.metronomeClicksToolStripMenuItem.Size = new Size(268, 22);
			this.metronomeClicksToolStripMenuItem.Text = "&Metronome Clicks";
			this.metronomeClicksToolStripMenuItem.Click += new EventHandler(this.metronomeClicksToolStripMenuItem_Click);
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new Size(265, 6);
			this.addTimingToolStripMenuItem.Name = "addTimingToolStripMenuItem";
			this.addTimingToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+P";
			this.addTimingToolStripMenuItem.Size = new Size(268, 22);
			this.addTimingToolStripMenuItem.Text = "&Add Timing Section";
			this.addTimingToolStripMenuItem.Click += new EventHandler(this.addTimingToolStripMenuItem_Click);
			this.addTimingPointToolStripMenuItem.Name = "addTimingPointToolStripMenuItem";
			this.addTimingPointToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+P";
			this.addTimingPointToolStripMenuItem.Size = new Size(268, 22);
			this.addTimingPointToolStripMenuItem.Text = "Add &Inheriting Section";
			this.addTimingPointToolStripMenuItem.Click += new EventHandler(this.addTimingPointToolStripMenuItem_Click);
			this.retimeCurrentPointToolStripMenuItem.Name = "retimeCurrentPointToolStripMenuItem";
			this.retimeCurrentPointToolStripMenuItem.ShortcutKeyDisplayString = "";
			this.retimeCurrentPointToolStripMenuItem.Size = new Size(268, 22);
			this.retimeCurrentPointToolStripMenuItem.Text = "&Reset Current Section";
			this.retimeCurrentPointToolStripMenuItem.Click += new EventHandler(this.retimeCurrentPointToolStripMenuItem_Click);
			this.deleteTimingPointToolStripMenuItem.Name = "deleteTimingPointToolStripMenuItem";
			this.deleteTimingPointToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+I";
			this.deleteTimingPointToolStripMenuItem.Size = new Size(268, 22);
			this.deleteTimingPointToolStripMenuItem.Text = "&Delete Timing Section";
			this.deleteTimingPointToolStripMenuItem.Click += new EventHandler(this.deleteTimingPointToolStripMenuItem_Click);
			this.snapAllNotesToolStripMenuItem.ForeColor = Color.Black;
			this.snapAllNotesToolStripMenuItem.Name = "snapAllNotesToolStripMenuItem";
			this.snapAllNotesToolStripMenuItem.Size = new Size(268, 22);
			this.snapAllNotesToolStripMenuItem.Text = "Re&snap Current Section";
			this.snapAllNotesToolStripMenuItem.Click += new EventHandler(this.snapAllNotesToolStripMenuItem_Click);
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new Size(265, 6);
			this.bPMOffsetToolStripMenuItem.Name = "bPMOffsetToolStripMenuItem";
			this.bPMOffsetToolStripMenuItem.ShortcutKeyDisplayString = "F6";
			this.bPMOffsetToolStripMenuItem.Size = new Size(268, 22);
			this.bPMOffsetToolStripMenuItem.Text = "Timing &Setup...";
			this.bPMOffsetToolStripMenuItem.Click += new EventHandler(this.bPMOffsetToolStripMenuItem_Click);
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new Size(265, 6);
			this.resnapAllNotesToolStripMenuItem.ForeColor = Color.Red;
			this.resnapAllNotesToolStripMenuItem.Name = "resnapAllNotesToolStripMenuItem";
			this.resnapAllNotesToolStripMenuItem.Size = new Size(268, 22);
			this.resnapAllNotesToolStripMenuItem.Text = "Res&nap All Notes";
			this.resnapAllNotesToolStripMenuItem.Click += new EventHandler(this.resnapAllNotesToolStripMenuItem_Click);
			this.moveAllNotesToolStripMenuItem.ForeColor = Color.Red;
			this.moveAllNotesToolStripMenuItem.Name = "moveAllNotesToolStripMenuItem";
			this.moveAllNotesToolStripMenuItem.Size = new Size(268, 22);
			this.moveAllNotesToolStripMenuItem.Text = "Move all notes in time...";
			this.moveAllNotesToolStripMenuItem.Click += new EventHandler(this.moveAllNotesToolStripMenuItem_Click);
			this.recalculateSlidersToolStripMenuItem.ForeColor = Color.Red;
			this.recalculateSlidersToolStripMenuItem.Name = "recalculateSlidersToolStripMenuItem";
			this.recalculateSlidersToolStripMenuItem.Size = new Size(268, 22);
			this.recalculateSlidersToolStripMenuItem.Text = "Re&calculate Slider Lengths";
			this.recalculateSlidersToolStripMenuItem.Click += new EventHandler(this.recalculateSlidersToolStripMenuItem_Click);
			this.resetAllTimingsToolStripMenuItem.ForeColor = Color.Red;
			this.resetAllTimingsToolStripMenuItem.Name = "resetAllTimingsToolStripMenuItem";
			this.resetAllTimingsToolStripMenuItem.Size = new Size(268, 22);
			this.resetAllTimingsToolStripMenuItem.Text = "Delete All Timing Sections";
			this.resetAllTimingsToolStripMenuItem.Click += new EventHandler(this.resetAllTimingsToolStripMenuItem_Click);
			this.toolStripSeparator10.Name = "toolStripSeparator10";
			this.toolStripSeparator10.Size = new Size(265, 6);
			this.setPreviewPointToCurrentPositionToolStripMenuItem.Name = "setPreviewPointToCurrentPositionToolStripMenuItem";
			this.setPreviewPointToCurrentPositionToolStripMenuItem.Size = new Size(268, 22);
			this.setPreviewPointToCurrentPositionToolStripMenuItem.Text = "Set Current Position as &Preview Point";
			this.setPreviewPointToCurrentPositionToolStripMenuItem.Click += new EventHandler(this.setPreviewPointToCurrentPositionToolStripMenuItem_Click);
			this.webToolStripMenu.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.thisBeatmapsInformationPageToolStripMenuItem,
				this.thisBeatmapsThreadToolStripMenuItem,
				this.quickReplyToolStripMenuItem
			});
			this.webToolStripMenu.Name = "webToolStripMenu";
			this.webToolStripMenu.Size = new Size(43, 20);
			this.webToolStripMenu.Text = "&Web";
			this.thisBeatmapsInformationPageToolStripMenuItem.Name = "thisBeatmapsInformationPageToolStripMenuItem";
			this.thisBeatmapsInformationPageToolStripMenuItem.Size = new Size(249, 22);
			this.thisBeatmapsInformationPageToolStripMenuItem.Text = "This Beatmap's &Information Page";
			this.thisBeatmapsInformationPageToolStripMenuItem.Click += new EventHandler(this.thisBeatmapsInformationPageToolStripMenuItem_Click);
			this.thisBeatmapsThreadToolStripMenuItem.Name = "thisBeatmapsThreadToolStripMenuItem";
			this.thisBeatmapsThreadToolStripMenuItem.Size = new Size(249, 22);
			this.thisBeatmapsThreadToolStripMenuItem.Text = "This Beatmap's &Thread";
			this.thisBeatmapsThreadToolStripMenuItem.Click += new EventHandler(this.thisBeatmapsThreadToolStripMenuItem_Click);
			this.quickReplyToolStripMenuItem.Name = "quickReplyToolStripMenuItem";
			this.quickReplyToolStripMenuItem.Size = new Size(249, 22);
			this.quickReplyToolStripMenuItem.Text = "Quick &Reply";
			this.quickReplyToolStripMenuItem.Click += new EventHandler(this.quickReplyToolStripMenuItem_Click);
			this.helpToolStripMenu.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.displayInlineHlpeToolStripMenuItem,
				this.viewFAQToolStripMenuItem
			});
			this.helpToolStripMenu.Name = "helpToolStripMenu";
			this.helpToolStripMenu.Size = new Size(44, 20);
			this.helpToolStripMenu.Text = "&Help";
			this.displayInlineHlpeToolStripMenuItem.Name = "displayInlineHlpeToolStripMenuItem";
			this.displayInlineHlpeToolStripMenuItem.Size = new Size(177, 22);
			this.displayInlineHlpeToolStripMenuItem.Text = "Show &in-game help";
			this.displayInlineHlpeToolStripMenuItem.Click += new EventHandler(this.displayInlineHlpeToolStripMenuItem_Click);
			this.viewFAQToolStripMenuItem.Name = "viewFAQToolStripMenuItem";
			this.viewFAQToolStripMenuItem.Size = new Size(177, 22);
			this.viewFAQToolStripMenuItem.Text = "View &FAQ...";
			this.viewFAQToolStripMenuItem.Click += new EventHandler(this.viewFAQToolStripMenuItem_Click);
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			base.Controls.Add(this.menuStrip1);
			base.Name = "EditorControl";
			base.Size = new Size(800, 24);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003269 RID: 12905
		// RVA: 0x00025220 File Offset: 0x00023420
		private void loadSoftToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_3(this.editor_0.class297_0.class296_0, true, false);
		}

		// Token: 0x0600325E RID: 12894
		// RVA: 0x000251A4 File Offset: 0x000233A4
		private void loadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_3(this.editor_0.class297_0.class296_0, true, true);
		}

		// Token: 0x0600327D RID: 12925
		// RVA: 0x00025348 File Offset: 0x00023548
		private void menuItemRedo_Click(object sender, EventArgs e)
		{
			this.editor_0.method_21();
		}

		// Token: 0x0600327C RID: 12924
		// RVA: 0x0002533B File Offset: 0x0002353B
		private void menuItemUndo_Click(object sender, EventArgs e)
		{
			this.editor_0.method_19();
		}

		// Token: 0x06003253 RID: 12883
		// RVA: 0x000250E2 File Offset: 0x000232E2
		private void menuStrip1_MenuActivate(object sender, EventArgs e)
		{
			Class115.smethod_6(true);
			this.enableLiveMappingModeToolStripMenuItem.Checked = this.editor_0.bool_10;
		}

		// Token: 0x06003254 RID: 12884
		// RVA: 0x00025100 File Offset: 0x00023300
		private void menuStrip1_MenuDeactivate(object sender, EventArgs e)
		{
			Class115.smethod_6(false);
		}

		// Token: 0x06003251 RID: 12881
		// RVA: 0x0015044C File Offset: 0x0014E64C
		internal void method_0()
		{
			Class296 class296_ = this.editor_0.class297_0.class296_0;
			this.thisBeatmapsInformationPageToolStripMenuItem.Enabled = (class296_.int_2 != 0);
			this.thisBeatmapsThreadToolStripMenuItem.Enabled = (class296_.int_2 != 0);
			this.quickReplyToolStripMenuItem.Enabled = (class296_.int_2 != 0);
			this.packageForDistributionToolStripMenuItem.Enabled = !class296_.bool_10;
			this.openSongFolder.Enabled = (!class296_.bool_10 || class296_.method_8() != null);
			this.submitToolStripMenuItem.Enabled = !class296_.bool_10;
			this.extractMapPackageToolStripMenuItem.Enabled = class296_.bool_10;
			this.openosbInNotepadToolStripMenuItem.Enabled = class296_.method_68(class296_.method_43());
			this.showVideoToolStripMenuItem.Checked = Class341.class606_17;
			this.snakingSlidersToolStripMenuItem.Checked = Class341.class606_19;
			this.hitAnimationsToolStripMenuItem.Checked = Class341.class606_20;
			this.followPointsToolStripMenuItem.Checked = Class341.class606_21;
			this.stackingToolStripMenuItem.Checked = Class341.class606_22;
			this.disableUndoStatesToolStripMenuItem.Checked = Class341.class606_25;
			if (class296_.method_5() == PlayModes.OsuMania)
			{
				this.autoToolStripMenuItem.Visible = true;
			}
			this.method_1();
			if (Class371.dictionary_0 != null)
			{
				this.beatSnappingToolStripMenuItem.Checked = Class371.dictionary_0[Enum106.flag_3];
			}
		}

		// Token: 0x06003252 RID: 12882
		// RVA: 0x0000653E File Offset: 0x0000473E
		private void method_1()
		{
		}

		// Token: 0x060032A1 RID: 12961
		// RVA: 0x00150B48 File Offset: 0x0014ED48
		internal void method_10(int int_0)
		{
			this.fullBeatsToolStripMenuItem.Checked = (int_0 == 1);
			this.halfBeatsToolStripMenuItem.Checked = (int_0 == 2);
			this.quarterBeatsToolStripMenuItem.Checked = (int_0 == 4);
			this.eighthBeatsToolStripMenuItem.Checked = (int_0 == 8);
			this.tripletsToolStripMenuItem.Checked = (int_0 == 3);
			this.doubleTripletsToolStripMenuItem.Checked = (int_0 == 6);
		}

		// Token: 0x060032B6 RID: 12982
		// RVA: 0x0002576D File Offset: 0x0002396D
		internal void method_11(Enum37 enum37_0)
		{
			this.signature34.Checked = (enum37_0 == Enum37.const_1);
			this.signature44.Checked = (enum37_0 == Enum37.const_0);
		}

		// Token: 0x060032C1 RID: 12993
		// RVA: 0x00154000 File Offset: 0x00152200
		private void method_12()
		{
			this.fileToolStripMenu.Text = Class41.GetString(OsuString.General_File);
			this.editToolStripMenu.Text = Class41.GetString(OsuString.SongSelection_Edit);
			this.viewToolStripMenu.Text = Class41.GetString(OsuString.General_View);
			this.composeToolStripMenu.Text = Class41.GetString(OsuString.Editor_Compose);
			this.designToolStripMenu.Text = Class41.GetString(OsuString.Editor_Design);
			this.timingToolStripMenu.Text = Class41.GetString(OsuString.Editor_Timing);
			this.webToolStripMenu.Text = Class41.GetString(OsuString.General_Web);
			this.helpToolStripMenu.Text = Class41.GetString(OsuString.General_Help);
			this.newToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_File_ClearAllNotes);
			this.openToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_File_OpenDifficulty);
			this.totalLoadToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_File_ForEditing);
			this.asReferenceToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_File_ForReference);
			this.saveToolStripMenuItem.Text = Class41.GetString(OsuString.General_Save);
			this.saveAsToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_File_SaveAsNewDifficulty);
			this.loadSoftToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_File_RevertToSaved);
			this.loadToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_File_RevertToSavedFull);
			this.testBeatmapToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_File_TestBeatmap);
			this.openAiModToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_File_OpenAiMod);
			this.submitToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_File_UploadBeatmap);
			this.packageForDistributionToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_File_ExportPackage);
			this.extractMapPackageToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_File_ExtractMapPackage);
			this.importBMSToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_File_ImportFrom);
			this.bmsbmeToolStripMenuItem.Text = "bms/bme";
			this.openSongFolder.Text = Class41.GetString(OsuString.EditorMenuItem_File_OpenSongFolder);
			this.openOsuInNotepad.Text = Class41.GetString(OsuString.EditorMenuItem_File_OpenOsuInNotepad);
			this.openosbInNotepadToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_File_OpenOsbInNotepad);
			this.exitToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_File_Exit);
			this.menuItemUndo.Text = Class41.GetString(OsuString.EditorMenuItem_Edit_Undo);
			this.menuItemRedo.Text = Class41.GetString(OsuString.EditorMenuItem_Edit_Redo);
			this.cutToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Edit_Cut);
			this.copyToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Edit_Copy);
			this.pasteToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Edit_Paste);
			this.deleteToolStripMenuItem.Text = Class41.GetString(OsuString.General_Delete);
			this.selectAllToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Edit_SelectAll);
			this.cloneToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Edit_Clone);
			this.reverseSelectionToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Edit_ReverseSelection);
			this.flipHorizontallyToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Edit_FlipHorizontally);
			this.flipVerticallyToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Edit_FlipVertically);
			this.rotateClockwiseToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Edit_Rotate90Clockwise);
			this.rotateAnticlockwiseToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Edit_Rotate90Anticlockwise);
			this.rotationByToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Edit_RotateBy);
			this.scaleByToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Edit_ScaleBy);
			this.resetSliderStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Edit_ResetSelectedObjectsSamples);
			this.resetAllSamplesToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Edit_ResetAllSamples);
			this.resetComboColoursToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Edit_ResetComboColours);
			this.resetBreaksToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Edit_ResetBreaks);
			this.nudgeBackwardToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Edit_NudgeBackward);
			this.nudgeOneMeasureRightToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Edit_NudgeForward);
			this.composeToolStripMenuItem.Text = Class41.GetString(OsuString.Editor_Compose);
			this.designToolStripMenuItem.Text = Class41.GetString(OsuString.Editor_Design);
			this.timingToolStripMenuItem.Text = Class41.GetString(OsuString.Editor_Timing);
			this.songSetupToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_View_SongSetup);
			this.timingSetupToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_View_TimingSetup);
			this.volumeToolStripMenuItem.Text = Class41.GetString(OsuString.Options_Audio_Volume);
			this.gridLevelToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_View_GridLevel);
			this.mostSparseToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_View_MostSparse);
			this.gridSize2ToolStripMenuItem.Text = "2";
			this.gridSize3ToolStripMenuItem.Text = "3";
			this.mostPreciseToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_View_MostPrecise);
			this.showVideoToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_View_ShowVideo);
			this.showSampleNameToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_View_ShowSampleName);
			this.snakingSlidersToolStripMenuItem.Text = Class41.GetString(OsuString.Options_Editor_Snaking_Sliders);
			this.hitAnimationsToolStripMenuItem.Text = Class41.GetString(OsuString.Options_Editor_Hit_Animations);
			this.followPointsToolStripMenuItem.Text = Class41.GetString(OsuString.Options_Editor_Follow_Points);
			this.stackingToolStripMenuItem.Text = Class41.GetString(OsuString.Options_Editor_Stacking);
			this.disableUndoStatesToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_View_DisableUndoStates);
			this.snapDivisorToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Compose_SnapDivisor);
			this.fullBeatsToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Compose_FullBeats);
			this.halfBeatsToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Compose_HalfBeats);
			this.quarterBeatsToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Compose_QuarterBeats);
			this.eighthBeatsToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Compose_EighthBeats);
			this.tripletsToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Compose_Triplets);
			this.doubleTripletsToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Compose_DoubleTriplets);
			this.audioRateToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Compose_AudioRate);
			this.audioRate25ToolStripMenuItem.Text = "25%";
			this.audioRate50ToolStripMenuItem.Text = "50%";
			this.audioRate75ToolStripMenuItem.Text = "75%";
			this.audioRate100ToolStripMenuItem.Text = "100%";
			this.beatSnappingToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Compose_GridSnapping);
			this.polygonStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Compose_CreatePolygonCircles);
			this.convertSliderToStreamToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Compose_ConvertSliderToStream);
			this.enableLiveMappingModeToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Compose_EnableLiveMappingMode);
			this.sampleImportToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Compose_SampleImport);
			this.autoToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Compose_AutoVolumeBalance);
			this.moveAllElementsInTimeToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Design_MoveAllElementsInTime);
			this.timingSignatureToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Timing_TimeSignature);
			this.signature44.Text = Class41.GetString(OsuString.EditorMenuItem_Timing_44Time);
			this.signature34.Text = Class41.GetString(OsuString.EditorMenuItem_Timing_34Time);
			this.metronomeClicksToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Timing_MetronomeClicks);
			this.addTimingToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Timing_AddTimingSection);
			this.addTimingPointToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Timing_AddInheritingSection);
			this.retimeCurrentPointToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Timing_ResetCurrentSection);
			this.deleteTimingPointToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Timing_DeleteTimingSection);
			this.snapAllNotesToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Timing_ResnapCurrentSection);
			this.bPMOffsetToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_View_TimingSetup);
			this.resnapAllNotesToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Timing_ResnapAllNotes);
			this.moveAllNotesToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Timing_MoveAllNotesInTime);
			this.recalculateSlidersToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Timing_RecalculateSliderLengths);
			this.resetAllTimingsToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Timing_DeleteAllTimingSections);
			this.setPreviewPointToCurrentPositionToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Timing_SetCurrentPositionAsPreviewPoint);
			this.thisBeatmapsInformationPageToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Web_ThisBeatmapsInformationPage);
			this.thisBeatmapsThreadToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Web_ThisBeatmapsThread);
			this.quickReplyToolStripMenuItem.Text = Class41.GetString(OsuString.SongSelection_Reply);
			this.displayInlineHlpeToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Help_ShowInGameHelp);
			this.viewFAQToolStripMenuItem.Text = Class41.GetString(OsuString.EditorMenuItem_Help_ViewFAQ);
		}

		// Token: 0x060032C2 RID: 12994
		// RVA: 0x00025830 File Offset: 0x00023A30
		[CompilerGenerated]
		private void method_13()
		{
			this.showVideoToolStripMenuItem.Checked = !this.showVideoToolStripMenuItem.Checked;
			Class341.class606_17.Value = this.showVideoToolStripMenuItem.Checked;
		}

		// Token: 0x060032C3 RID: 12995
		// RVA: 0x00025860 File Offset: 0x00023A60
		[CompilerGenerated]
		private void method_14()
		{
			this.hitAnimationsToolStripMenuItem.Checked = !this.hitAnimationsToolStripMenuItem.Checked;
			Class341.class606_20.Value = this.hitAnimationsToolStripMenuItem.Checked;
		}

		// Token: 0x060032C4 RID: 12996
		// RVA: 0x00025890 File Offset: 0x00023A90
		[CompilerGenerated]
		private void method_15()
		{
			this.editor_0.class375_0.method_31(false);
		}

		// Token: 0x060032C5 RID: 12997
		// RVA: 0x000258A3 File Offset: 0x00023AA3
		[CompilerGenerated]
		private void method_16()
		{
			this.editor_0.class375_0.method_12(Enum58.const_1);
		}

		// Token: 0x06003255 RID: 12885
		// RVA: 0x00025108 File Offset: 0x00023308
		internal void method_2(Enum105 enum105_0)
		{
			this.composeToolStripMenuItem.Checked = (enum105_0 == Enum105.const_1);
			this.designToolStripMenuItem.Checked = (enum105_0 == Enum105.const_2);
			this.timingToolStripMenuItem.Checked = (enum105_0 == Enum105.const_3);
		}

		// Token: 0x06003256 RID: 12886
		// RVA: 0x001505D8 File Offset: 0x0014E7D8
		internal void method_3(int int_0)
		{
			this.audioRate25ToolStripMenuItem.Checked = (int_0 == 25);
			this.audioRate50ToolStripMenuItem.Checked = (int_0 == 50);
			this.audioRate75ToolStripMenuItem.Checked = (int_0 == 75);
			this.audioRate100ToolStripMenuItem.Checked = (int_0 == 100);
		}

		// Token: 0x06003257 RID: 12887
		// RVA: 0x00025137 File Offset: 0x00023337
		internal void method_4(Editor.GridSizes gridSizes_0)
		{
			this.mostSparseToolStripMenuItem.Checked = (gridSizes_0 == Editor.GridSizes.Large);
			this.gridSize2ToolStripMenuItem.Checked = (gridSizes_0 == Editor.GridSizes.Medium);
			this.gridSize3ToolStripMenuItem.Checked = (gridSizes_0 == Editor.GridSizes.Small);
			this.mostPreciseToolStripMenuItem.Checked = (gridSizes_0 == Editor.GridSizes.Tiny);
		}

		// Token: 0x06003258 RID: 12888
		// RVA: 0x00025177 File Offset: 0x00023377
		internal void method_5(bool bool_0)
		{
			this.beatSnappingToolStripMenuItem.Checked = bool_0;
		}

		// Token: 0x06003259 RID: 12889
		// RVA: 0x00025177 File Offset: 0x00023377
		internal void method_6(bool bool_0)
		{
			this.beatSnappingToolStripMenuItem.Checked = bool_0;
		}

		// Token: 0x0600325A RID: 12890
		// RVA: 0x00025185 File Offset: 0x00023385
		internal void method_7(Editor editor_1)
		{
			this.editor_0 = editor_1;
		}

		// Token: 0x0600325B RID: 12891
		// RVA: 0x0002518E File Offset: 0x0002338E
		internal void method_8()
		{
			this.editor_0 = null;
		}

		// Token: 0x0600325C RID: 12892
		// RVA: 0x00150628 File Offset: 0x0014E828
		private void method_9(VoidDelegate voidDelegate_0)
		{
			DialogResult dialogResult;
			if (this.editor_0.bool_5)
			{
				dialogResult = MessageBox.Show(Class41.GetString(OsuString.EditorControl_BeatmapMustBeSavedDialog), "osu!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
				if (dialogResult == DialogResult.Yes)
				{
					this.editor_0.method_1();
				}
				else if (dialogResult == DialogResult.Cancel)
				{
					return;
				}
			}
			else
			{
				dialogResult = DialogResult.Yes;
			}
			voidDelegate_0();
			this.editor_0.method_3(this.editor_0.class297_0.class296_0, dialogResult == DialogResult.No, true);
		}

		// Token: 0x060032B3 RID: 12979
		// RVA: 0x0002570C File Offset: 0x0002390C
		private void metronomeClicksToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.metronomeClicksToolStripMenuItem.Checked = !this.metronomeClicksToolStripMenuItem.Checked;
			this.editor_0.class375_0.class366_0.bool_0 = this.metronomeClicksToolStripMenuItem.Checked;
		}

		// Token: 0x0600328C RID: 12940
		// RVA: 0x0002541A File Offset: 0x0002361A
		private void mostPreciseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_39(Editor.GridSizes.Tiny);
		}

		// Token: 0x06003289 RID: 12937
		// RVA: 0x000253EE File Offset: 0x000235EE
		private void mostSparseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_39(Editor.GridSizes.Large);
		}

		// Token: 0x060032A8 RID: 12968
		// RVA: 0x00150C88 File Offset: 0x0014EE88
		private void moveAllElementsInTimeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Class115.smethod_6(true);
			MoveEvents moveEvents = new MoveEvents();
			moveEvents.ShowDialog();
			Class115.smethod_6(false);
		}

		// Token: 0x060032B9 RID: 12985
		// RVA: 0x00150DB4 File Offset: 0x0014EFB4
		private void moveAllNotesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Class115.smethod_6(true);
			MoveNotes moveNotes = new MoveNotes();
			moveNotes.ShowDialog();
			Class115.smethod_6(false);
		}

		// Token: 0x0600325D RID: 12893
		// RVA: 0x00025197 File Offset: 0x00023397
		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.Clear();
		}

		// Token: 0x0600327E RID: 12926
		// RVA: 0x00025355 File Offset: 0x00023555
		private void nudgeBackwardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.class371_0.method_31();
		}

		// Token: 0x0600327F RID: 12927
		// RVA: 0x00025367 File Offset: 0x00023567
		private void nudgeOneMeasureRightToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.class371_0.method_32();
		}

		// Token: 0x06003268 RID: 12904
		// RVA: 0x00025213 File Offset: 0x00023413
		private void openAiModToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_79();
		}

		// Token: 0x0600326B RID: 12907
		// RVA: 0x001507E8 File Offset: 0x0014E9E8
		private void openosbInNotepadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Class296 class296_ = this.editor_0.class297_0.class296_0;
			if (!class296_.method_68(class296_.method_43()))
			{
				return;
			}
			if (!class296_.bool_10)
			{
				Class115.smethod_90("notepad.exe", class296_.method_3() + "\\" + class296_.method_43());
				return;
			}
			string text = class296_.method_71(class296_.method_43(), false);
			if (text != null)
			{
				Class115.smethod_90("notepad.exe", text);
			}
		}

		// Token: 0x06003267 RID: 12903
		// RVA: 0x001506D8 File Offset: 0x0014E8D8
		private void openOsuInNotepad_Click(object sender, EventArgs e)
		{
			Class296 class296_ = this.editor_0.class297_0.class296_0;
			if (!class296_.bool_10)
			{
				Class115.smethod_90("notepad.exe", class296_.method_46());
				return;
			}
			string text = class296_.method_71(class296_.string_9, false);
			if (text != null)
			{
				Class115.smethod_90("notepad.exe", text);
			}
		}

		// Token: 0x06003266 RID: 12902
		// RVA: 0x0015069C File Offset: 0x0014E89C
		private void openSongFolder_Click(object sender, EventArgs e)
		{
			Class296 class296_ = this.editor_0.class297_0.class296_0;
			Class115.smethod_83(class296_.bool_10 ? class296_.method_8() : class296_.method_3());
		}

		// Token: 0x06003262 RID: 12898
		// RVA: 0x0000653E File Offset: 0x0000473E
		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06003263 RID: 12899
		// RVA: 0x000251EC File Offset: 0x000233EC
		private void packageForDistributionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_13();
		}

		// Token: 0x06003272 RID: 12914
		// RVA: 0x00025296 File Offset: 0x00023496
		private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_63();
		}

		// Token: 0x060032A2 RID: 12962
		// RVA: 0x000255AF File Offset: 0x000237AF
		private void polygonStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_92();
		}

		// Token: 0x0600329D RID: 12957
		// RVA: 0x00025563 File Offset: 0x00023763
		private void quarterBeatsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.class371_0.method_4(4);
		}

		// Token: 0x060032BC RID: 12988
		// RVA: 0x000257E0 File Offset: 0x000239E0
		private void quickReplyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.class297_0.class296_0.method_56();
		}

		// Token: 0x060032B2 RID: 12978
		// RVA: 0x000256E0 File Offset: 0x000238E0
		private void recalculateSlidersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (DialogResult.OK == MessageBox.Show(Class41.GetString(OsuString.EditorControl_RecalculateSlidersMessage), "osu!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation))
			{
				this.editor_0.class375_0.method_30();
			}
		}

		// Token: 0x06003281 RID: 12929
		// RVA: 0x0002538B File Offset: 0x0002358B
		private void resetAllSamplesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (DialogResult.OK == MessageBox.Show(Class41.GetString(OsuString.EditorControl_ResetSamplesWarning), "osu!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation))
			{
				this.editor_0.class371_0.method_58();
			}
		}

		// Token: 0x060032AA RID: 12970
		// RVA: 0x00025611 File Offset: 0x00023811
		private void resetAllTimingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (DialogResult.Yes == MessageBox.Show(Class41.GetString(OsuString.EditorControl_ResetTimingsWarning), "osu!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
			{
				Class115.class47_0.Add(new VoidDelegate(this.editor_0.class375_0.method_18), false);
			}
		}

		// Token: 0x06003283 RID: 12931
		// RVA: 0x0015092C File Offset: 0x0014EB2C
		private void resetBreaksToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_16(false);
			foreach (Class705 current in this.editor_0.class872_0.list_0)
			{
				current.bool_3 = false;
				current.bool_4 = false;
			}
			this.editor_0.method_30(true, false);
		}

		// Token: 0x06003282 RID: 12930
		// RVA: 0x001508B0 File Offset: 0x0014EAB0
		private void resetComboColoursToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_16(false);
			foreach (Class304 current in this.editor_0.class297_0.list_3)
			{
				current.int_0 = 0;
			}
			this.editor_0.class297_0.method_20(false);
		}

		// Token: 0x06003280 RID: 12928
		// RVA: 0x00025379 File Offset: 0x00023579
		private void resetSliderStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.class371_0.method_44();
		}

		// Token: 0x060032B0 RID: 12976
		// RVA: 0x00150D18 File Offset: 0x0014EF18
		private void resnapAllNotesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (DialogResult.Yes == MessageBox.Show(Class41.GetString(OsuString.EditorControl_SnapAllNotesWarning), "osu!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
			{
				this.editor_0.class375_0.method_0(false, null);
			}
		}

		// Token: 0x060032AC RID: 12972
		// RVA: 0x00025667 File Offset: 0x00023867
		private void retimeCurrentPointToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (DialogResult.Yes == MessageBox.Show(Class41.GetString(OsuString.EditorControl_ResetCurrentTimingWarning), "osu!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
			{
				Class115.class47_0.Add(new VoidDelegate(this.editor_0.class375_0.method_8), false);
			}
		}

		// Token: 0x06003278 RID: 12920
		// RVA: 0x000252F8 File Offset: 0x000234F8
		private void reverseSelectionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.class371_0.method_33();
		}

		// Token: 0x0600327A RID: 12922
		// RVA: 0x0002531C File Offset: 0x0002351C
		private void rotateAnticlockwiseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.class371_0.method_35();
		}

		// Token: 0x06003279 RID: 12921
		// RVA: 0x0002530A File Offset: 0x0002350A
		private void rotateClockwiseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.class371_0.method_36();
		}

		// Token: 0x0600327B RID: 12923
		// RVA: 0x0002532E File Offset: 0x0002352E
		private void rotationByToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_90();
		}

		// Token: 0x060032A5 RID: 12965
		// RVA: 0x000255C9 File Offset: 0x000237C9
		private void sampleImportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_88();
		}

		// Token: 0x06003261 RID: 12897
		// RVA: 0x000251DF File Offset: 0x000233DF
		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_11();
		}

		// Token: 0x0600325F RID: 12895
		// RVA: 0x000251C4 File Offset: 0x000233C4
		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_1();
		}

		// Token: 0x06003284 RID: 12932
		// RVA: 0x000253B7 File Offset: 0x000235B7
		private void scaleByToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_91();
		}

		// Token: 0x06003275 RID: 12917
		// RVA: 0x000252C7 File Offset: 0x000234C7
		private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_64();
		}

		// Token: 0x060032B1 RID: 12977
		// RVA: 0x00150D5C File Offset: 0x0014EF5C
		private void setPreviewPointToCurrentPositionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Class331.int_7 >= 0 && Class331.int_7 != this.editor_0.class297_0.class296_0.int_14)
			{
				this.editor_0.method_16(false);
				this.editor_0.class297_0.class296_0.int_14 = Class331.int_7;
			}
		}

		// Token: 0x0600328F RID: 12943
		// RVA: 0x00025449 File Offset: 0x00023649
		private void showSampleNameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.showSampleNameToolStripMenuItem.Checked = !this.showSampleNameToolStripMenuItem.Checked;
			this.editor_0.bool_11 = this.showSampleNameToolStripMenuItem.Checked;
		}

		// Token: 0x0600328E RID: 12942
		// RVA: 0x00025435 File Offset: 0x00023635
		private void showVideoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.method_9(new VoidDelegate(this.method_13));
		}

		// Token: 0x060032B5 RID: 12981
		// RVA: 0x0002575A File Offset: 0x0002395A
		private void signature34_Click(object sender, EventArgs e)
		{
			this.editor_0.class375_0.method_29(Enum37.const_1);
		}

		// Token: 0x060032B4 RID: 12980
		// RVA: 0x00025747 File Offset: 0x00023947
		private void signature44_Click(object sender, EventArgs e)
		{
			this.editor_0.class375_0.method_29(Enum37.const_0);
		}

		// Token: 0x06003290 RID: 12944
		// RVA: 0x0002547A File Offset: 0x0002367A
		private void snakingSlidersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.snakingSlidersToolStripMenuItem.Checked = !this.snakingSlidersToolStripMenuItem.Checked;
			Class341.class606_19.Value = this.snakingSlidersToolStripMenuItem.Checked;
		}

		// Token: 0x060032AE RID: 12974
		// RVA: 0x00150CB0 File Offset: 0x0014EEB0
		private void snapAllNotesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Class331.smethod_8() > 0.0)
			{
				if (DialogResult.Yes == MessageBox.Show(Class41.GetString(OsuString.EditorControl_SnapNotesCurrentTimingWarning), "osu!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
				{
					this.editor_0.class375_0.method_0(true, null);
					return;
				}
			}
			else
			{
				MessageBox.Show(Class41.GetString(OsuString.EditorControl_OneSectionRequiredWarning), "osu!", MessageBoxButtons.OK);
			}
		}

		// Token: 0x0600328D RID: 12941
		// RVA: 0x00025428 File Offset: 0x00023628
		private void songSetupToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_4();
		}

		// Token: 0x06003293 RID: 12947
		// RVA: 0x00150A70 File Offset: 0x0014EC70
		private void stackingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.stackingToolStripMenuItem.Checked = !this.stackingToolStripMenuItem.Checked;
			Class341.class606_22.Value = this.stackingToolStripMenuItem.Checked;
			if (!this.stackingToolStripMenuItem.Checked)
			{
				this.editor_0.class297_0.method_30();
			}
		}

		// Token: 0x06003264 RID: 12900
		// RVA: 0x000251F9 File Offset: 0x000233F9
		private void submitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_12();
		}

		// Token: 0x06003265 RID: 12901
		// RVA: 0x00025206 File Offset: 0x00023406
		private void testBeatmapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_7();
		}

		// Token: 0x060032BA RID: 12986
		// RVA: 0x000257B2 File Offset: 0x000239B2
		private void thisBeatmapsInformationPageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.class297_0.class296_0.method_54();
		}

		// Token: 0x060032BB RID: 12987
		// RVA: 0x000257C9 File Offset: 0x000239C9
		private void thisBeatmapsThreadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.class297_0.class296_0.method_55();
		}

		// Token: 0x060032B8 RID: 12984
		// RVA: 0x000257A0 File Offset: 0x000239A0
		private void timingSetupToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.class375_0.method_11();
		}

		// Token: 0x06003288 RID: 12936
		// RVA: 0x000253E0 File Offset: 0x000235E0
		private void timingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_57(Enum105.const_3);
		}

		// Token: 0x0600326D RID: 12909
		// RVA: 0x00025240 File Offset: 0x00023440
		private void totalLoadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.method_10(false);
		}

		// Token: 0x0600329F RID: 12959
		// RVA: 0x00025589 File Offset: 0x00023789
		private void tripletsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.editor_0.class371_0.method_4(3);
		}

		// Token: 0x060032BE RID: 12990
		// RVA: 0x00024F8E File Offset: 0x0002318E
		private void viewFAQToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Class115.smethod_90("http://osu.ppy.sh/p/faq/?n=5", null);
		}

		// Token: 0x06003294 RID: 12948
		// RVA: 0x00150AC8 File Offset: 0x0014ECC8
		private void volumeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Class115.smethod_6(true);
			VolumeDialog volumeDialog = new VolumeDialog();
			volumeDialog.Show(Class115.form_0);
			Class115.smethod_6(false);
		}
	}
}
