using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns10;
using ns11;
using ns12;
using ns14;
using ns17;
using ns18;
using ns20;
using ns23;
using ns24;
using ns25;
using ns26;
using ns29;
using ns42;
using ns59;
using ns6;
using ns64;
using ns68;
using ns69;
using ns76;
using ns79;
using ns8;
using ns80;
using ns81;
using ns82;
using ns84;
using ns89;
using ns9;
using ns90;
using ns94;
using osu.GameplayElements.Events;
using osu.Graphics.Sprites;
using osu.Input;
using osu_common;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace osu.GameModes.Edit
{
	// Token: 0x020004B9 RID: 1209
	internal sealed class Editor : Class61
	{
		// Token: 0x020004BA RID: 1210
		internal sealed class Class626
		{
			// Token: 0x04002013 RID: 8211
			internal int int_0;

			// Token: 0x04002014 RID: 8212
			internal List<Class340> list_0;

			// Token: 0x04002015 RID: 8213
			internal List<Class304> list_1;

			// Token: 0x04002016 RID: 8214
			internal List<Class702> list_2;

			// Token: 0x060026C5 RID: 9925
			// RVA: 0x000EB760 File Offset: 0x000E9960
			internal Class626(List<Class304> list_3, List<Class340> list_4, List<Class702> list_5)
			{
				this.int_0 = Editor.editor_0.class297_0.class296_0.int_14;
				this.list_0 = new List<Class340>(list_4);
				this.list_1 = new List<Class304>(list_3);
				this.list_2 = new List<Class702>(list_5);
			}
		}

		// Token: 0x020004BC RID: 1212
		[CompilerGenerated]
		private sealed class Class627
		{
			// Token: 0x0400201C RID: 8220
			public bool bool_0;

			// Token: 0x0400201D RID: 8221
			public Editor editor_0;

			// Token: 0x060026C7 RID: 9927
			// RVA: 0x000EB7B4 File Offset: 0x000E99B4
			public void method_0()
			{
				if (this.bool_0)
				{
					Class115.class47_0.method_1(new VoidDelegate(this.editor_0.method_12), 500, false);
					return;
				}
				MessageBox.Show(Class115.form_0, Class41.GetString(OsuString.Editor_FileOperations_SubmitDialog_1));
			}
		}

		// Token: 0x020004BD RID: 1213
		[CompilerGenerated]
		private sealed class Class628
		{
			// Token: 0x0400201E RID: 8222
			public string string_0;

			// Token: 0x060026C9 RID: 9929
			// RVA: 0x0001E0CA File Offset: 0x0001C2CA
			public bool method_0(Class702 class702_0)
			{
				return class702_0.string_0 == this.string_0;
			}
		}

		// Token: 0x020004BE RID: 1214
		[CompilerGenerated]
		private sealed class Class629
		{
			// Token: 0x0400201F RID: 8223
			public int int_0;

			// Token: 0x060026CB RID: 9931
			// RVA: 0x0001E0DD File Offset: 0x0001C2DD
			public bool method_0(Class304 class304_0)
			{
				return class304_0.StartTime > this.int_0;
			}
		}

		// Token: 0x020004BF RID: 1215
		[CompilerGenerated]
		private sealed class Class630
		{
			// Token: 0x04002020 RID: 8224
			public Class296 class296_0;

			// Token: 0x060026CD RID: 9933
			// RVA: 0x0001E0ED File Offset: 0x0001C2ED
			public bool method_0(Class296 class296_1)
			{
				return this.class296_0.string_4 == class296_1.string_4;
			}
		}

		// Token: 0x020004C0 RID: 1216
		[CompilerGenerated]
		private sealed class Class631
		{
			// Token: 0x04002021 RID: 8225
			public int int_0;

			// Token: 0x04002022 RID: 8226
			public int int_1;

			// Token: 0x060026CF RID: 9935
			// RVA: 0x000EB800 File Offset: 0x000E9A00
			public bool method_0(Class705 class705_0)
			{
				return (class705_0.int_2 >= this.int_0 && class705_0.int_2 <= this.int_1) || (class705_0.int_0 >= this.int_0 && class705_0.int_0 <= this.int_1);
			}
		}

		// Token: 0x020004BB RID: 1211
		internal enum GridSizes
		{
			// Token: 0x04002018 RID: 8216
			Tiny = 4,
			// Token: 0x04002019 RID: 8217
			Small = 8,
			// Token: 0x0400201A RID: 8218
			Medium = 16,
			// Token: 0x0400201B RID: 8219
			Large = 32
		}

		// Token: 0x0400200F RID: 8207
		[CompilerGenerated]
		private static Action<Class304> action_0;

		// Token: 0x04002012 RID: 8210
		[CompilerGenerated]
		private static Action<Class296> action_1;

		// Token: 0x04001FDD RID: 8157
		internal AiModWindow aiModWindow_0;

		// Token: 0x04001FD1 RID: 8145
		internal bool bool_10;

		// Token: 0x04001FD2 RID: 8146
		internal bool bool_11;

		// Token: 0x04001FD7 RID: 8151
		private bool bool_12;

		// Token: 0x04001FDE RID: 8158
		private static bool bool_13;

		// Token: 0x04001FE0 RID: 8160
		private bool bool_14;

		// Token: 0x04001FFA RID: 8186
		internal bool bool_15;

		// Token: 0x04001FFB RID: 8187
		internal bool bool_16;

		// Token: 0x04001FFD RID: 8189
		internal bool bool_17;

		// Token: 0x04001FB1 RID: 8113
		internal bool bool_2;

		// Token: 0x04001FB2 RID: 8114
		internal bool bool_3;

		// Token: 0x04001FB5 RID: 8117
		private bool bool_4;

		// Token: 0x04001FB6 RID: 8118
		internal bool bool_5;

		// Token: 0x04001FB8 RID: 8120
		internal bool bool_6;

		// Token: 0x04001FBA RID: 8122
		internal bool bool_7;

		// Token: 0x04001FCC RID: 8140
		private bool bool_8;

		// Token: 0x04001FD0 RID: 8144
		private bool bool_9;

		// Token: 0x04001FB9 RID: 8121
		internal Class297 class297_0;

		// Token: 0x04001FFE RID: 8190
		private Class370 class370_0;

		// Token: 0x04001FFF RID: 8191
		internal Class371 class371_0;

		// Token: 0x04002001 RID: 8193
		internal Class375 class375_0;

		// Token: 0x04002000 RID: 8192
		internal Class376 class376_0;

		// Token: 0x04001FBB RID: 8123
		private Class531 class531_0;

		// Token: 0x04001FBC RID: 8124
		private Class531 class531_1;

		// Token: 0x04001FDA RID: 8154
		private Class531 class531_10;

		// Token: 0x04001FBD RID: 8125
		private Class531 class531_2;

		// Token: 0x04001FBE RID: 8126
		private Class531 class531_3;

		// Token: 0x04001FCD RID: 8141
		private Class531[] class531_4;

		// Token: 0x04001FCE RID: 8142
		private Class531 class531_5;

		// Token: 0x04001FCF RID: 8143
		private Class531 class531_6;

		// Token: 0x04001FD3 RID: 8147
		private Class531 class531_7;

		// Token: 0x04001FD4 RID: 8148
		private Class531 class531_8;

		// Token: 0x04001FD6 RID: 8150
		private Class531 class531_9;

		// Token: 0x04001FD8 RID: 8152
		private Class533 class533_0;

		// Token: 0x04001FD9 RID: 8153
		private Class533 class533_1;

		// Token: 0x04001FB3 RID: 8115
		private Editor.Class626 class626_0;

		// Token: 0x04001FB7 RID: 8119
		internal Class872 class872_0;

		// Token: 0x04001FDB RID: 8155
		internal Class911 class911_1;

		// Token: 0x04001FDC RID: 8156
		internal Class911 class911_2;

		// Token: 0x04001FF3 RID: 8179
		internal Class911 class911_3;

		// Token: 0x04001FAF RID: 8111
		private readonly Color color_0 = Color.get_White();

		// Token: 0x04001FC0 RID: 8128
		private static Color color_1 = new Color(255, 146, 18, 140);

		// Token: 0x04001FE1 RID: 8161
		internal readonly Color color_10 = new Color(50, 128, 255, 225);

		// Token: 0x04001FE2 RID: 8162
		internal readonly Color color_11 = new Color(255, 255, 0, 225);

		// Token: 0x04001FE3 RID: 8163
		internal readonly Color color_12 = new Color(255, 0, 0, 225);

		// Token: 0x04001FE4 RID: 8164
		internal readonly Color color_13 = new Color(200, 0, 200, 225);

		// Token: 0x04001FE5 RID: 8165
		internal readonly Color color_14 = new Color(255, 255, 255, 220);

		// Token: 0x04001FE6 RID: 8166
		internal readonly Color color_15 = new Color(144, 64, 144, 225);

		// Token: 0x04001FE7 RID: 8167
		internal readonly Color color_16 = new Color(160, 160, 160, 225);

		// Token: 0x04001FE8 RID: 8168
		internal readonly Color color_17 = new Color(255, 255, 255, 255);

		// Token: 0x04001FC1 RID: 8129
		private static Color color_2 = new Color(255, 255, 255, 140);

		// Token: 0x04001FC2 RID: 8130
		private static Color color_3 = new Color(58, 110, 170, 240);

		// Token: 0x04001FC3 RID: 8131
		private static Color color_4 = new Color(255, 255, 255, 128);

		// Token: 0x04001FC4 RID: 8132
		private static Color color_5 = new Color(180, 20, 20, 150);

		// Token: 0x04001FC5 RID: 8133
		private static Color color_6 = new Color(156, 255, 0, 100);

		// Token: 0x04001FC6 RID: 8134
		private static Color color_7 = new Color(255, 247, 17, 150);

		// Token: 0x04001FC7 RID: 8135
		private static Color color_8 = new Color(255, 255, 255, 25);

		// Token: 0x04001FC8 RID: 8136
		private static Color color_9 = new Color(255, 255, 255, 75);

		// Token: 0x04002005 RID: 8197
		private ConvertToStream convertToStream_0;

		// Token: 0x04001FEE RID: 8174
		internal double double_0 = 250.0;

		// Token: 0x04001FB4 RID: 8116
		internal static Editor editor_0;

		// Token: 0x04001FCA RID: 8138
		internal Enum105 enum105_0;

		// Token: 0x04002007 RID: 8199
		private static Enum105 enum105_1;

		// Token: 0x04001FFC RID: 8188
		internal Enum107 enum107_0;

		// Token: 0x04001FED RID: 8173
		internal Enum108 enum108_0;

		// Token: 0x04001FF2 RID: 8178
		private static float float_0 = 1f;

		// Token: 0x04001FDF RID: 8159
		private GotoTime gotoTime_0;

		// Token: 0x04001FF5 RID: 8181
		internal int int_10 = 10;

		// Token: 0x04001FF6 RID: 8182
		internal int int_11 = Class115.smethod_43() - 220;

		// Token: 0x04001FCB RID: 8139
		internal int int_2;

		// Token: 0x04001FE9 RID: 8169
		internal readonly int int_3 = 35;

		// Token: 0x04001FEA RID: 8170
		internal readonly int int_4 = 20;

		// Token: 0x04001FEB RID: 8171
		internal readonly int int_5 = 25;

		// Token: 0x04001FEC RID: 8172
		internal int int_6;

		// Token: 0x04001FEF RID: 8175
		internal int int_7;

		// Token: 0x04001FF0 RID: 8176
		internal int int_8;

		// Token: 0x04001FF1 RID: 8177
		internal int int_9;

		// Token: 0x04001FF7 RID: 8183
		private List<Editor.Class626> list_0;

		// Token: 0x04001FB0 RID: 8112
		private OpenDialog openDialog_0;

		// Token: 0x04001FBF RID: 8127
		internal PlayModes playModes_0;

		// Token: 0x04002004 RID: 8196
		private Polygon polygon_0;

		// Token: 0x04002008 RID: 8200
		[CompilerGenerated]
		private static Predicate<Class304> predicate_0;

		// Token: 0x04002009 RID: 8201
		[CompilerGenerated]
		private static Predicate<Class702> predicate_1;

		// Token: 0x0400200A RID: 8202
		[CompilerGenerated]
		private static Predicate<Class702> predicate_2;

		// Token: 0x0400200B RID: 8203
		[CompilerGenerated]
		private static Predicate<Class746> predicate_3;

		// Token: 0x0400200C RID: 8204
		[CompilerGenerated]
		private static Predicate<Class746> predicate_4;

		// Token: 0x0400200D RID: 8205
		[CompilerGenerated]
		private static Predicate<Class746> predicate_5;

		// Token: 0x0400200E RID: 8206
		[CompilerGenerated]
		private static Predicate<Class746> predicate_6;

		// Token: 0x04002010 RID: 8208
		[CompilerGenerated]
		private static Predicate<Class296> predicate_7;

		// Token: 0x04002011 RID: 8209
		[CompilerGenerated]
		private static Predicate<Class296> predicate_8;

		// Token: 0x04001FC9 RID: 8137
		private static Rectangle rectangle_0;

		// Token: 0x04001FD5 RID: 8149
		private Rectangle rectangle_1;

		// Token: 0x04001FF4 RID: 8180
		internal Rectangle rectangle_2;

		// Token: 0x04002002 RID: 8194
		private RotateBy rotateBy_0;

		// Token: 0x04002006 RID: 8198
		private SampleImport sampleImport_0;

		// Token: 0x04002003 RID: 8195
		private ScaleBy scaleBy_0;

		// Token: 0x04001FF8 RID: 8184
		private Stack<Editor.Class626> stack_0;

		// Token: 0x04001FF9 RID: 8185
		private Stack<Editor.Class626> stack_1;

		// Token: 0x06002669 RID: 9833
		// RVA: 0x000E737C File Offset: 0x000E557C
		internal Editor(Class114 class114_1) : base(class114_1)
		{
			if (Class115.editorControl_0 == null)
			{
				Class115.editorControl_0 = new EditorControl();
			}
			Editor.editor_0 = this;
		}

		// Token: 0x0600267B RID: 9851
		// RVA: 0x000E8E14 File Offset: 0x000E7014
		internal void Clear()
		{
			switch (MessageBox.Show("Are you sure you want to clear all objects in the current difficulty?", "osu!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1))
			{
			case DialogResult.OK:
				this.class297_0.Clear();
				this.method_18();
				break;
			case DialogResult.Cancel:
				return;
			}
			this.bool_5 = true;
		}

		// Token: 0x0600266E RID: 9838
		// RVA: 0x000E7908 File Offset: 0x000E5B08
		protected override void Dispose(bool bool_18)
		{
			Predicate<Class296> predicate = null;
			Editor.Class630 class = new Editor.Class630();
			Class331.smethod_83();
			class.class296_0 = this.class297_0.class296_0;
			if (class.class296_0 != null)
			{
				List<Class296> arg_43_0 = Class466.list_3;
				if (predicate == null)
				{
					predicate = new Predicate<Class296>(class.method_0);
				}
				List<Class296> list = arg_43_0.FindAll(predicate);
				foreach (Class296 current in list)
				{
					current.bool_8 = false;
				}
				class.class296_0.method_11();
				foreach (Class296 current2 in list)
				{
					current2.submissionStatus_0 = SubmissionStatus.Unknown;
				}
				Class466.smethod_4(list);
			}
			if (this.class370_0 != null)
			{
				this.class370_0.vmethod_12();
			}
			Editor.editor_0 = null;
			if (this.class911_3 != null)
			{
				this.class911_3.Dispose();
			}
			if (this.class911_1 != null)
			{
				this.class911_1.Dispose();
			}
			if (this.class911_2 != null)
			{
				this.class911_2.Dispose();
			}
			if (this.class297_0 != null)
			{
				this.class297_0.Dispose();
			}
			Class115.smethod_68(1f, false);
			Class800.smethod_24();
			if (this.class375_0 != null)
			{
				this.class375_0.Dispose();
			}
			if (this.class371_0 != null)
			{
				this.class371_0.Dispose();
			}
			if (this.class376_0 != null)
			{
				this.class376_0.Dispose();
			}
			SampleImport.Clear();
			Class341.class608_2.Value = this.int_6;
			Class341.class608_3.Value = this.int_2;
			this.method_80();
			Class115.smethod_16(new VoidDelegate(this.method_26));
			Class331.smethod_28(new Class331.Delegate31(this.method_27));
			Class570.smethod_5(new Class570.Delegate45(this.method_78));
			base.Dispose(bool_18);
		}

		// Token: 0x06002677 RID: 9847
		// RVA: 0x000E8688 File Offset: 0x000E6888
		public override void Draw()
		{
			if (this.class872_0 == null)
			{
				return;
			}
			base.Draw();
			this.class872_0.method_4();
			this.class872_0.method_5();
			if (this.enum105_0 != Enum105.const_3 && this.playModes_0 != PlayModes.OsuMania)
			{
				this.class297_0.Draw();
			}
			this.method_37();
			if (this.aiModWindow_0 != null)
			{
				this.aiModWindow_0.Draw();
			}
			this.class911_1.Draw();
			this.method_68();
			this.method_36();
			this.class911_2.Draw();
			this.class370_0.Draw();
		}

		// Token: 0x060026BF RID: 9919
		// RVA: 0x0001E09F File Offset: 0x0001C29F
		[CompilerGenerated]
		private void gotoTime_0_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.gotoTime_0 = null;
		}

		// Token: 0x06002673 RID: 9843
		// RVA: 0x000E7FA4 File Offset: 0x000E61A4
		public override void imethod_2()
		{
			if (this.class872_0 == null)
			{
				return;
			}
			base.imethod_2();
			this.class872_0.method_6();
			if (!Class114.bool_0)
			{
				this.bool_7 = false;
			}
			this.class371_0.method_52();
			this.class370_0.vmethod_3();
			this.method_32();
			this.bool_15 = (Class115.smethod_66(Class802.vector2_0) && Class115.class89_0 == null);
			this.bool_16 = (this.rectangle_2.Contains(Class802.point_0) && Class115.class89_0 == null);
			this.bool_17 = this.rectangle_1.Contains(Class802.point_0);
			if (!this.bool_7)
			{
				this.enum108_0 = Enum108.const_0;
			}
			if (this.enum108_0 == Enum108.const_3 && !Class111.bool_2 && (Class115.int_1 % 125 < 16 || Class331.enum100_0 == Enum100.const_0))
			{
				Class331.smethod_70((int)((float)Class331.smethod_31() * ((float)(Class802.point_0.X - this.rectangle_1.get_Left()) / (float)this.rectangle_1.Width)), false, false);
			}
			if (Class115.bool_13)
			{
				bool flag;
				if ((flag = Class331.smethod_82()) != this.bool_9)
				{
					this.bool_9 = flag;
					if (flag)
					{
						List<Class746> arg_150_0 = this.class531_5.class26_0;
						if (Editor.predicate_3 == null)
						{
							Editor.predicate_3 = new Predicate<Class746>(Editor.smethod_8);
						}
						arg_150_0.RemoveAll(Editor.predicate_3);
						this.class531_5.class26_0.Add(new Class746(TransformationType.Fade, 0f, 0.9f, Class115.int_1, Class115.int_1 + 160, Enum70.const_1));
						this.class531_5.class26_0.Add(new Class746(TransformationType.MovementX, -40f, 0f, Class115.int_1, Class115.int_1 + 160, Enum70.const_1));
						this.class531_6.method_25(0.4f, 100, Enum70.const_0);
						List<Class746> arg_1F7_0 = this.class531_6.class26_0;
						if (Editor.predicate_4 == null)
						{
							Editor.predicate_4 = new Predicate<Class746>(Editor.smethod_9);
						}
						arg_1F7_0.RemoveAll(Editor.predicate_4);
						this.class531_6.class26_0.Add(new Class746(TransformationType.MovementX, -40f, 0f, Class115.int_1, Class115.int_1 + 160, Enum70.const_1));
					}
					else
					{
						this.class531_5.method_16(100, Enum70.const_0);
						List<Class746> arg_26D_0 = this.class531_5.class26_0;
						if (Editor.predicate_5 == null)
						{
							Editor.predicate_5 = new Predicate<Class746>(Editor.smethod_10);
						}
						arg_26D_0.RemoveAll(Editor.predicate_5);
						this.class531_5.class26_0.Add(new Class746(TransformationType.MovementX, 0f, -40f, Class115.int_1, Class115.int_1 + 160, Enum70.const_1));
						this.class531_6.method_16(100, Enum70.const_0);
						List<Class746> arg_2DE_0 = this.class531_6.class26_0;
						if (Editor.predicate_6 == null)
						{
							Editor.predicate_6 = new Predicate<Class746>(Editor.smethod_11);
						}
						arg_2DE_0.RemoveAll(Editor.predicate_6);
						this.class531_6.class26_0.Add(new Class746(TransformationType.MovementX, 0f, -40f, Class115.int_1, Class115.int_1 + 160, Enum70.const_1));
					}
				}
				if (flag && this.class531_6.class26_0.Count == 0)
				{
					this.class531_6.float_3 = 0.4f - (float)Class331.double_0 * 0.6f;
				}
			}
			if (this.bool_17 && !Editor.smethod_2())
			{
				if (this.class531_0.class26_0.Count == 0)
				{
					this.class531_0.method_14(200, Enum70.const_0);
					this.class531_9.method_14(200, Enum70.const_0);
					this.class531_2.method_14(200, Enum70.const_0);
					this.class531_1.method_14(200, Enum70.const_0);
					this.class531_3.method_14(200, Enum70.const_0);
				}
				this.bool_4 = false;
			}
			else if (!Editor.rectangle_0.Contains(Class802.point_0) && this.class531_0.float_3 == 1f)
			{
				this.class531_0.method_16(200, Enum70.const_0);
				this.class531_9.method_16(200, Enum70.const_0);
				this.class531_2.method_16(200, Enum70.const_0);
				this.class531_1.method_16(200, Enum70.const_0);
				this.class531_3.method_16(200, Enum70.const_0);
				this.bool_4 = false;
			}
			else if (this.class531_0.bool_3)
			{
				this.class371_0.method_52();
				this.bool_4 = true;
			}
			else
			{
				this.bool_4 = false;
			}
			if (Class115.bool_13)
			{
				if (Class331.int_7 >= 0)
				{
					this.class533_0.Text = string.Format("{0:00}:{1:00}:{2:000}", Class331.int_7 / 60000, Class331.int_7 % 60000 / 1000, Math.Max(0, Class331.int_7) % 1000);
				}
				else
				{
					this.class533_0.Text = string.Format("-{0:00}:{1:00}:{2:000}", -Class331.int_7 / 60000, -Class331.int_7 % 60000 / 1000, Math.Max(0, -Class331.int_7) % 1000);
					this.class533_1.Text = "intro";
				}
				if (Class331.int_7 < 0)
				{
					this.class533_1.Text = "intro";
				}
				else if (Class331.int_7 > Class331.smethod_31())
				{
					this.class533_1.Text = "outro";
				}
				else
				{
					this.class533_1.Text = string.Format("{0:0.0}%", (float)Class331.int_7 / (float)Class331.smethod_31() * 100f);
				}
			}
			this.class531_8.vector2_1 = new Vector2((float)this.rectangle_1.get_Left() + (float)Class331.int_7 / (float)Class331.smethod_31() * (float)this.rectangle_1.Width, (float)(this.rectangle_1.get_Top() + this.rectangle_1.Height / 2));
		}

		// Token: 0x0600266B RID: 9835
		// RVA: 0x000E74D4 File Offset: 0x000E56D4
		public override void Initialize()
		{
			Class858.smethod_4(false);
			Class296 current = Class466.Current;
			Class466.smethod_2(current);
			Class872.int_2 = 30;
			this.list_0 = new List<Editor.Class626>();
			this.stack_0 = new Stack<Editor.Class626>();
			this.stack_1 = new Stack<Editor.Class626>();
			this.class911_3 = new Class911(true);
			this.class297_0 = new Class301(true);
			Class876.Reset();
			Class876.class623_0 &= ~Mods.DoubleTime;
			Class62.class512_0 = null;
			Class115.editorControl_0.method_7(this);
			this.method_60();
			try
			{
				if (current.Title.Length == 0)
				{
					Class331.smethod_91();
					string text = Class34.smethod_19(current.string_1);
					if (text != current.string_1)
					{
						if (text.Length < 4)
						{
							text = "music.mp3";
						}
						if (Class34.smethod_14(current.string_1, text, true, true))
						{
							current.string_1 = text;
						}
					}
					Class331.smethod_84(current, true, false, true, false);
					current.Title = Class34.smethod_19(Class331.string_1);
					current.TitleUnicode = Class331.string_1;
					current.Artist = Class34.smethod_19(Class331.string_0);
					current.ArtistUnicode = Class331.string_0;
				}
				else
				{
					Class331.smethod_84(current, false, false, true, false);
				}
			}
			catch (Exception11)
			{
				Class723.smethod_1("Could not load audio file.", 2000);
				this.method_82(false);
				return;
			}
			if (this.method_3(current, false, false))
			{
				this.method_67(Class778.smethod_2(current.float_2, 0.1f, 8f));
				this.method_43();
				switch (current.method_5())
				{
				case PlayModes.Taiko:
					this.class371_0 = new Class373(this);
					break;
				case PlayModes.CatchTheBeat:
					this.class371_0 = new Class372(this);
					break;
				case PlayModes.OsuMania:
					this.class371_0 = new Class374(this);
					break;
				default:
					this.class371_0 = new Class371(this);
					break;
				}
				if (Class63.list_4 != null && Class63.list_4 != this.class297_0.list_1)
				{
					this.class297_0.list_1 = Class63.list_4;
					Editor.editor_0.bool_5 = true;
				}
				Class63.list_4 = null;
				this.playModes_0 = current.method_5();
				this.class375_0 = new Class375(this);
				this.class376_0 = new Class376(this);
				Class802.smethod_34(Enum96.const_8, new Delegate46(this.method_84), Enum98.const_2, Enum97.const_0);
				Class802.smethod_34(Enum96.const_6, new Delegate46(this.method_28), Enum98.const_2, Enum97.const_0);
				Class802.smethod_34(Enum96.const_5, new Delegate46(this.method_83), Enum98.const_2, Enum97.const_0);
				Class802.smethod_34(Enum96.const_3, new Delegate46(this.method_86), Enum98.const_2, Enum97.const_0);
				Class570.smethod_4(new Class570.Delegate45(this.method_78));
				Class802.smethod_34(Enum96.const_2, new Delegate46(this.method_87), Enum98.const_2, Enum97.const_0);
				Class802.smethod_34(Enum96.const_1, new Delegate46(this.method_74), Enum98.const_2, Enum97.const_0);
				Class802.smethod_34(Enum96.const_0, new Delegate46(this.method_75), Enum98.const_2, Enum97.const_0);
				Class802.smethod_34(Enum96.const_1, new Delegate46(this.method_72), Enum98.const_7, Enum97.const_0);
				Class802.smethod_34(Enum96.const_0, new Delegate46(this.method_73), Enum98.const_7, Enum97.const_0);
				Class115.smethod_15(new VoidDelegate(this.method_26));
				Class331.smethod_27(new Class331.Delegate31(this.method_27));
				this.class371_0.Initialize();
				this.class375_0.Initialize();
				this.class376_0.Initialize();
				Class115.editorControl_0.method_3(100);
				Class115.editorControl_0.method_6(Class371.dictionary_0[Enum106.flag_3]);
				this.method_42(Class341.class608_3, false);
				base.Initialize();
				Class331.smethod_89(100, false);
				if (Class331.smethod_14().Count == 0)
				{
					this.method_57(Enum105.const_3);
				}
				else
				{
					this.method_57((Editor.enum105_1 != Enum105.const_0) ? Editor.enum105_1 : Enum105.const_1);
				}
				Class115.editorControl_0.method_2(this.enum105_0);
				if (!Class115.bool_25 && Class115.int_28 <= 0)
				{
					if (current.int_7 > 0)
					{
						Class331.smethod_70(current.int_7, false, false);
					}
					else
					{
						Class331.smethod_70(0, false, false);
					}
				}
				else
				{
					Class331.smethod_70(Class115.int_28, false, false);
					Class115.int_28 = 0;
					Class115.bool_25 = false;
				}
				this.method_38(Class331.smethod_67());
				Class115.editorControl_0.method_11(Class331.smethod_18());
				Class723.smethod_2(null, null);
				Class115.class83_0.bool_2 = false;
				return;
			}
		}

		// Token: 0x0600264F RID: 9807
		// RVA: 0x000E5F60 File Offset: 0x000E4160
		internal void method_1()
		{
			this.class371_0.method_52();
			this.method_29(true);
			this.class297_0.method_3(false, false, false);
			Class466.Add(this.class297_0.class296_0);
			Class723.smethod_1(Class41.GetString(OsuString.Editor_FileOperations_SavedBeatmap), 1000);
			this.bool_5 = false;
		}

		// Token: 0x06002658 RID: 9816
		// RVA: 0x000E6400 File Offset: 0x000E4600
		internal void method_10(bool bool_18)
		{
			if (this.openDialog_0 != null && !this.openDialog_0.IsDisposed && this.openDialog_0.Visible)
			{
				this.openDialog_0.Focus();
				return;
			}
			this.openDialog_0 = new OpenDialog(bool_18);
			this.openDialog_0.Location = new Point(Class115.form_0.Location.X + 10, Class115.form_0.Location.Y + 55);
			this.openDialog_0.Show(Class115.form_0);
		}

		// Token: 0x06002659 RID: 9817
		// RVA: 0x000E6494 File Offset: 0x000E4694
		internal void method_11()
		{
			this.method_9();
			Class115.smethod_6(true);
			SongSetup songSetup = new SongSetup(true, false);
			if (songSetup.ShowDialog(Class115.form_0) == DialogResult.OK)
			{
				Class466.list_3.Sort();
				this.class297_0.class296_0.int_2 = 0;
				Class466.smethod_14(this.class297_0.class296_0.bool_10 ? this.class297_0.class296_0.method_8() : this.class297_0.class296_0.method_3());
				DialogResult dialogResult = MessageBox.Show(Class41.GetString(OsuString.Editor_FileOperations_SaveAsDialog), "osu!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
				if (dialogResult == DialogResult.Yes)
				{
					this.class297_0.Clear();
					this.class297_0.method_3(false, false, false);
				}
			}
			Class115.smethod_6(false);
		}

		// Token: 0x0600265A RID: 9818
		// RVA: 0x000E6558 File Offset: 0x000E4758
		internal void method_12()
		{
			Delegate1 delegate = null;
			bool flag = true;
			if (!Class115.smethod_33())
			{
				Class80 arg_21_0 = Class115.class80_0;
				if (delegate == null)
				{
					delegate = new Delegate1(this.method_94);
				}
				arg_21_0.method_6(delegate);
				Class115.smethod_80(false);
				return;
			}
			if (this.class297_0.int_14 == 0)
			{
				MessageBox.Show(Class115.form_0, Class41.GetString(OsuString.Editor_FileOperations_SubmitDialog_2));
				flag = false;
			}
			if (!flag)
			{
				Class115.smethod_6(false);
				return;
			}
			this.method_1();
			this.method_14();
			List<Class702> arg_8C_0 = this.class872_0.list_1;
			if (Editor.predicate_1 == null)
			{
				Editor.predicate_1 = new Predicate<Class702>(Editor.smethod_6);
			}
			bool arg_CE_1 = arg_8C_0.FindAll(Editor.predicate_1).Count > 0;
			List<Class702> arg_C1_0 = this.class872_0.list_1;
			if (Editor.predicate_2 == null)
			{
				Editor.predicate_2 = new Predicate<Class702>(Editor.smethod_7);
			}
			BeatmapSubmissionSystem beatmapSubmissionSystem = new BeatmapSubmissionSystem(this, arg_CE_1, arg_C1_0.FindAll(Editor.predicate_2).Count > 0);
			beatmapSubmissionSystem.StartPosition = FormStartPosition.CenterScreen;
			if (Class809.bool_4)
			{
				beatmapSubmissionSystem.Show(Class115.form_0);
				return;
			}
			beatmapSubmissionSystem.ShowDialog(Class115.form_0);
		}

		// Token: 0x0600265B RID: 9819
		// RVA: 0x000E6668 File Offset: 0x000E4868
		internal void method_13()
		{
			Class296 class296_ = this.class297_0.class296_0;
			if (class296_.bool_10)
			{
				return;
			}
			this.method_1();
			this.method_14();
			Class115.smethod_82(class296_.string_12 + ".osz", class296_.method_3());
		}

		// Token: 0x0600265C RID: 9820
		// RVA: 0x000E66B4 File Offset: 0x000E48B4
		internal void method_14()
		{
			Class296 class296_ = this.class297_0.class296_0;
			if (class296_.bool_10)
			{
				return;
			}
			try
			{
				Class34.smethod_18(class296_.method_3() + "/Thumbs.db");
			}
			catch
			{
			}
			List<string> list = new List<string>();
			string[] files = Directory.GetFiles(class296_.method_3());
			int i = 0;
			while (i < files.Length)
			{
				string text = files[i];
				Predicate<Class702> predicate = null;
				Editor.Class628 class = new Editor.Class628();
				string text2 = Path.GetExtension(text).TrimStart(new char[]
				{
					'.'
				}).ToLower();
				class.string_0 = Path.GetFileName(text);
				string key;
				if ((key = text2) == null)
				{
					goto IL_1DE;
				}
				if (Class918.dictionary_6 == null)
				{
					Class918.dictionary_6 = new Dictionary<string, int>(12)
					{
						{
							"osu",
							0
						},
						{
							"osb",
							1
						},
						{
							"wav",
							2
						},
						{
							"mp3",
							3
						},
						{
							"avi",
							4
						},
						{
							"mpg",
							5
						},
						{
							"wmv",
							6
						},
						{
							"flv",
							7
						},
						{
							"ogg",
							8
						},
						{
							"png",
							9
						},
						{
							"osz2",
							10
						},
						{
							"jpg",
							11
						}
					};
				}
				int num;
				if (!Class918.dictionary_6.TryGetValue(key, out num))
				{
					goto IL_1DE;
				}
				switch (num)
				{
				case 0:
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
				case 10:
					break;
				case 11:
					if (!(class.string_0 == "pause-overlay.jpg") && !(class.string_0 == "spinner-background.jpg"))
					{
						List<Class702> arg_1D7_0 = Editor.editor_0.class872_0.list_1;
						if (predicate == null)
						{
							predicate = new Predicate<Class702>(class.method_0);
						}
						if (arg_1D7_0.Find(predicate) == null)
						{
							goto IL_1DE;
						}
					}
					break;
				default:
					goto IL_1DE;
				}
				IL_1E5:
				i++;
				continue;
				IL_1DE:
				list.Add(text);
				goto IL_1E5;
			}
			if (list.Count > 0)
			{
				string text3 = string.Empty;
				foreach (string current in list)
				{
					text3 = text3 + current + '\n';
				}
				text3 = text3.Trim(new char[]
				{
					'\n'
				});
				if (DialogResult.Yes == MessageBox.Show(string.Concat(new object[]
				{
					Class41.GetString(OsuString.Editor_FileOperations_UnusedFilesInDirectoryDialog),
					'\n',
					'\n',
					text3
				}), "osu!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
				{
					foreach (string current2 in list)
					{
						try
						{
							Class34.smethod_18(current2);
						}
						catch
						{
						}
					}
				}
			}
		}

		// Token: 0x0600265E RID: 9822
		// RVA: 0x0001DC57 File Offset: 0x0001BE57
		public void method_15()
		{
			Class115.smethod_6(false);
			Editor.smethod_3(false);
		}

		// Token: 0x0600265F RID: 9823
		// RVA: 0x000E6DE4 File Offset: 0x000E4FE4
		internal void method_16(bool bool_18)
		{
			if (this.class297_0.list_3 == null)
			{
				return;
			}
			this.bool_5 = true;
			if (!this.bool_2 && (Class341.class606_25 || this.bool_3))
			{
				return;
			}
			this.class371_0.method_52();
			List<Class340> list = new List<Class340>();
			foreach (Class340 current in Class331.smethod_14())
			{
				list.Add((Class340)current.Clone());
			}
			List<Class304> list_ = this.class297_0.Clone();
			List<Class702> list_2 = this.class872_0.Clone();
			if (this.list_0.Count >= 20)
			{
				while (this.list_0.Count >= 20)
				{
					this.list_0.RemoveAt(0);
				}
			}
			this.list_0.Add(new Editor.Class626(list_, list, list_2));
			this.stack_1.Clear();
			if (!bool_18)
			{
				this.method_25();
			}
			else
			{
				while (this.stack_0.Count > 0)
				{
					this.stack_1.Push(this.stack_0.Pop());
				}
			}
			Class115.editorControl_0.menuItemRedo.Enabled = false;
			Class115.editorControl_0.menuItemUndo.Enabled = true;
		}

		// Token: 0x06002660 RID: 9824
		// RVA: 0x000E6F38 File Offset: 0x000E5138
		internal Editor.Class626 method_17(bool bool_18)
		{
			if ((!this.bool_2 && Class341.class606_25) || this.list_0.Count == 0)
			{
				return null;
			}
			Editor.Class626 result = this.list_0[this.list_0.Count - 1];
			this.list_0.RemoveAt(this.list_0.Count - 1);
			if (bool_18)
			{
				while (this.stack_1.Count > 0)
				{
					this.stack_0.Push(this.stack_1.Pop());
				}
				Class115.editorControl_0.menuItemRedo.Enabled = (this.stack_0.Count > 0);
				Class115.editorControl_0.menuItemUndo.Enabled = (this.list_0.Count > 0);
			}
			this.stack_1.Clear();
			return result;
		}

		// Token: 0x06002661 RID: 9825
		// RVA: 0x000E7008 File Offset: 0x000E5208
		internal void method_18()
		{
			this.stack_1.Clear();
			this.list_0.Clear();
			this.stack_0.Clear();
			Class115.editorControl_0.menuItemRedo.Enabled = false;
			Class115.editorControl_0.menuItemUndo.Enabled = false;
		}

		// Token: 0x06002662 RID: 9826
		// RVA: 0x000E7058 File Offset: 0x000E5258
		internal void method_19()
		{
			if (this.list_0.Count == 0)
			{
				return;
			}
			if (this.class370_0 == this.class371_0)
			{
				this.class371_0.method_21(false);
			}
			this.bool_5 = true;
			this.method_20();
			this.method_23(this.method_17(false));
			if (this.list_0.Count == 0)
			{
				Class115.editorControl_0.menuItemUndo.Enabled = false;
			}
			Class115.editorControl_0.menuItemRedo.Enabled = true;
		}

		// Token: 0x06002650 RID: 9808
		// RVA: 0x000E5FBC File Offset: 0x000E41BC
		internal bool method_2(Class296 class296_0)
		{
			if (this.class371_0.class297_1 != null)
			{
				this.class371_0.class297_1.Dispose();
				this.class371_0.class297_1 = null;
			}
			bool result;
			try
			{
				if (class296_0 == null)
				{
					this.class371_0.vmethod_36();
					result = false;
				}
				else
				{
					this.class371_0.class297_1 = new Class301(true);
					this.class371_0.class297_1.method_8(class296_0, Mods.None);
					this.class371_0.class297_1.Load(true);
					this.class371_0.class297_1.class421_0 = new Class421(this.class371_0.class297_1);
					this.class371_0.vmethod_36();
					result = true;
				}
			}
			catch (Exception)
			{
				this.class371_0.vmethod_36();
				result = false;
			}
			return result;
		}

		// Token: 0x06002663 RID: 9827
		// RVA: 0x0001DC65 File Offset: 0x0001BE65
		private void method_20()
		{
			this.class371_0.method_52();
			this.stack_0.Push(new Editor.Class626(this.class297_0.list_3, Class331.smethod_14(), this.class872_0.list_1));
		}

		// Token: 0x06002664 RID: 9828
		// RVA: 0x000E70D4 File Offset: 0x000E52D4
		internal void method_21()
		{
			if (this.stack_0.Count <= 0)
			{
				return;
			}
			this.bool_5 = true;
			this.method_22();
			this.method_23(this.stack_0.Pop());
			if (this.stack_0.Count == 0)
			{
				Class115.editorControl_0.menuItemRedo.Enabled = false;
			}
			Class115.editorControl_0.menuItemUndo.Enabled = true;
		}

		// Token: 0x06002665 RID: 9829
		// RVA: 0x0001DC9D File Offset: 0x0001BE9D
		private void method_22()
		{
			this.class371_0.method_52();
			this.list_0.Add(new Editor.Class626(this.class297_0.list_3, Class331.smethod_14(), this.class872_0.list_1));
		}

		// Token: 0x06002666 RID: 9830
		// RVA: 0x000E713C File Offset: 0x000E533C
		private void method_23(Editor.Class626 class626_1)
		{
			if (class626_1 != null && class626_1.list_1 != null && class626_1.list_0 != null && class626_1.list_2 != null)
			{
				this.class626_0 = class626_1;
				this.class371_0.method_52();
				this.class297_0.method_7(class626_1.list_1);
				this.class371_0.method_24();
				this.class872_0.method_12(class626_1.list_2);
				int int_ = this.class376_0.int_0;
				this.class376_0.Reset();
				bool flag = this.bool_2;
				this.bool_2 = false;
				this.bool_3 = true;
				this.class375_0.method_18();
				foreach (Class340 current in class626_1.list_0)
				{
					Class331.smethod_14().Add(current);
				}
				Class331.smethod_6(false);
				this.bool_3 = false;
				this.bool_2 = flag;
				this.class297_0.class296_0.int_14 = class626_1.int_0;
				this.class370_0.vmethod_11();
				this.class371_0.list_1.Clear();
				foreach (Class304 current2 in this.class297_0.list_3)
				{
					if (current2.method_2())
					{
						this.class371_0.list_1.Add(current2);
					}
				}
				if (this.class370_0 == this.class376_0 && int_ >= 0 && int_ < this.class872_0.method_2().Count)
				{
					this.class376_0.int_0 = int_;
					this.class376_0.class702_1 = this.class872_0.method_2()[int_];
				}
				this.class297_0.vmethod_15();
				return;
			}
		}

		// Token: 0x06002667 RID: 9831
		// RVA: 0x000E732C File Offset: 0x000E552C
		internal void method_24()
		{
			this.stack_1.Clear();
			this.stack_0.Clear();
			this.list_0.Clear();
			Class115.editorControl_0.menuItemUndo.Enabled = false;
			Class115.editorControl_0.menuItemRedo.Enabled = false;
		}

		// Token: 0x06002668 RID: 9832
		// RVA: 0x0001DCD5 File Offset: 0x0001BED5
		internal void method_25()
		{
			this.stack_0.Clear();
			Class115.editorControl_0.menuItemRedo.Enabled = false;
		}

		// Token: 0x0600266C RID: 9836
		// RVA: 0x0001DD01 File Offset: 0x0001BF01
		private void method_26()
		{
			if (this.bool_7)
			{
				this.method_87(null, null);
			}
		}

		// Token: 0x0600266D RID: 9837
		// RVA: 0x0000653E File Offset: 0x0000473E
		private void method_27(Class340 class340_0)
		{
		}

		// Token: 0x0600266F RID: 9839
		// RVA: 0x0001DD14 File Offset: 0x0001BF14
		private bool method_28(object object_0, EventArgs eventArgs_0)
		{
			this.bool_14 = false;
			return this.class370_0.vmethod_7();
		}

		// Token: 0x06002670 RID: 9840
		// RVA: 0x0001DD28 File Offset: 0x0001BF28
		internal void method_29(bool bool_18)
		{
			this.method_30(bool_18, false);
		}

		// Token: 0x06002651 RID: 9809
		// RVA: 0x000E608C File Offset: 0x000E428C
		internal bool method_3(Class296 class296_0, bool bool_18, bool bool_19)
		{
			if (bool_18 && this.method_6())
			{
				DialogResult dialogResult = Class723.smethod_8(Class41.GetString(OsuString.Editor_FileOperations_RevertFileToLastSavedState), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
				DialogResult dialogResult2 = dialogResult;
				if (dialogResult2 == DialogResult.Cancel)
				{
					return false;
				}
				if (dialogResult2 == DialogResult.No)
				{
					return false;
				}
			}
			Class115.smethod_79(Path.GetFileName(class296_0.string_9));
			Editor.editor_0.method_65();
			Class885.smethod_22();
			if (bool_19)
			{
				Class885.smethod_13(true);
			}
			Class331.smethod_84(class296_0, false, false, true, false);
			this.method_38(100);
			bool flag;
			bool result;
			try
			{
				this.class297_0.method_8(class296_0, Mods.None);
				flag = this.class297_0.method_0();
				goto IL_92;
			}
			catch (Exception9)
			{
				Class115.smethod_71(OsuModes.SelectEdit, true);
				result = false;
			}
			return result;
			IL_92:
			if (this.class371_0 != null && class296_0.method_5() != this.playModes_0)
			{
				Class115.smethod_70(OsuModes.Edit, true);
				return false;
			}
			this.class872_0 = this.class297_0.class872_0;
			this.class872_0.class911_1.bool_2 = true;
			this.class872_0.class911_0.bool_2 = true;
			this.class872_0.class911_2.bool_2 = true;
			if (!flag || class296_0.string_5.Length == 0)
			{
				if (this.class371_0 != null)
				{
					this.class371_0.method_6(0.800000011920929);
				}
				this.method_5(false);
			}
			class296_0.int_6 = 14;
			this.class297_0.method_12(false);
			if (this.class376_0 != null)
			{
				this.class376_0.Reset();
			}
			if (this.class370_0 != null)
			{
				this.class370_0.vmethod_11();
			}
			this.method_24();
			if (this.aiModWindow_0 != null)
			{
				this.aiModWindow_0.Reset();
			}
			this.method_30(false, true);
			Class115.editorControl_0.method_0();
			this.bool_5 = false;
			return true;
		}

		// Token: 0x06002671 RID: 9841
		// RVA: 0x000E7B08 File Offset: 0x000E5D08
		internal void method_30(bool bool_18, bool bool_19)
		{
			if (this.class297_0.list_3.Count == 0 && this.class872_0.list_0.Count > 0)
			{
				this.class872_0.method_19();
				return;
			}
			List<Class705> list = new List<Class705>();
			int num = 0;
			foreach (Class705 current in this.class872_0.list_0)
			{
				int num2 = this.class297_0.method_21(current);
				int num3 = current.int_2;
				int num4 = current.int_0;
				if (num2 > 0)
				{
					int num5 = this.class297_0.list_3[num2 - 1].EndTime;
					for (int i = num2 - 1; i >= 0; i--)
					{
						int endTime = this.class297_0.list_3[i].EndTime;
						if (endTime > num5)
						{
							num5 = endTime;
						}
					}
					num3 = num5 + 200;
				}
				if (num2 < this.class297_0.int_14)
				{
					num4 = this.class297_0.list_3[num2].StartTime - this.class297_0.PreEmpt;
				}
				if (bool_18 && (current.int_0 < this.class297_0.list_3[0].StartTime || current.int_2 > this.class297_0.list_3[this.class297_0.int_14 - 1].EndTime))
				{
					list.Add(current);
				}
				if (bool_18 && (current.int_2 < num || num4 < num3))
				{
					list.Add(current);
				}
				else
				{
					if (bool_19)
					{
						if (current.int_2 != num3)
						{
							current.bool_3 = true;
						}
						if (current.int_0 != Math.Max(num3, num4))
						{
							current.bool_4 = true;
						}
					}
					if (!current.bool_3)
					{
						current.int_2 = num3;
					}
					else if (current.int_2 < num3)
					{
						current.int_2 = num3;
						current.bool_3 = false;
					}
					else if (current.int_2 - 5000 + 200 > num3)
					{
						current.int_2 = num3 + 5000 - 200;
					}
					if (!current.bool_4)
					{
						current.int_0 = Math.Max(current.int_2, num4);
					}
					else if (current.int_0 > num4)
					{
						current.int_0 = Math.Max(current.int_2, num4);
						current.bool_4 = false;
					}
					else if (current.int_0 + 5000 - this.class297_0.PreEmpt < num4)
					{
						current.int_0 = Math.Max(current.int_2, num4) - 5000 + this.class297_0.PreEmpt;
					}
					if (num4 + this.class297_0.PreEmpt - current.int_2 - 200 < 50)
					{
						bool_18 = true;
						list.Add(current);
					}
					else if (current.int_0 - current.int_2 < 50)
					{
						if (!current.bool_3 && current.bool_4)
						{
							current.int_0 = current.int_2 + 50;
						}
						else if (current.bool_3 && !current.bool_4)
						{
							current.int_2 = current.int_0 - 50;
						}
					}
					num = current.int_0;
				}
			}
			if (bool_18)
			{
				foreach (Class705 current2 in list)
				{
					this.class872_0.Remove(current2);
				}
				if (this.class371_0 != null)
				{
					for (int j = this.class297_0.int_14 - 1; j > 0; j--)
					{
						Editor.Class631 class = new Editor.Class631();
						class.int_0 = 0;
						class.int_1 = this.class297_0.list_3[j].StartTime;
						bool flag = false;
						for (int k = j - 1; k >= 0; k--)
						{
							int endTime2 = this.class297_0.list_3[k].EndTime;
							if (endTime2 > class.int_0)
							{
								class.int_0 = endTime2;
								if (!(flag = (class.int_1 - class.int_0 > 5000)))
								{
									break;
								}
							}
						}
						if (flag && this.class872_0.list_0.Find(new Predicate<Class705>(class.method_0)) == null)
						{
							this.class371_0.method_3(class.int_0 + (class.int_1 - class.int_0) / 2, false);
						}
					}
				}
			}
		}

		// Token: 0x06002672 RID: 9842
		// RVA: 0x0001DD32 File Offset: 0x0001BF32
		public bool method_31(Class702 class702_0)
		{
			return class702_0 != null && class702_0.int_0 + 5000 - this.class297_0.PreEmpt * 2 - class702_0.int_2 <= 5000;
		}

		// Token: 0x06002674 RID: 9844
		// RVA: 0x000E85A8 File Offset: 0x000E67A8
		private void method_32()
		{
			this.class911_3.Clear(false);
			this.int_7 = (int)(6000f / this.method_66());
			this.int_8 = Class331.int_7 - this.int_7 / 2;
			this.int_9 = Class331.int_7 + this.int_7 / 2;
			this.class370_0.vmethod_4();
		}

		// Token: 0x06002675 RID: 9845
		// RVA: 0x0001DD64 File Offset: 0x0001BF64
		internal void method_33()
		{
			if (Class331.int_2 == Class331.smethod_14().Count - 1)
			{
				return;
			}
			Class331.smethod_70((int)Class331.smethod_14()[Class331.int_2 + 1].double_1, false, false);
		}

		// Token: 0x06002676 RID: 9846
		// RVA: 0x000E8608 File Offset: 0x000E6808
		internal void method_34()
		{
			if (Class331.int_2 < 0)
			{
				return;
			}
			if ((double)Class331.int_7 - Class331.smethod_14()[Class331.int_2].double_1 > 1000.0)
			{
				Class331.smethod_70((int)Class331.smethod_14()[Class331.int_2].double_1, false, false);
				return;
			}
			if (Class331.int_2 == 0)
			{
				return;
			}
			Class331.smethod_70((int)Class331.smethod_14()[Class331.int_2 - 1].double_1, false, false);
		}

		// Token: 0x06002678 RID: 9848
		// RVA: 0x0001DD98 File Offset: 0x0001BF98
		private float method_35(double double_1)
		{
			return (float)this.rectangle_1.X + (float)this.rectangle_1.Width * ((float)double_1 / (float)Class331.smethod_31());
		}

		// Token: 0x06002679 RID: 9849
		// RVA: 0x000E8720 File Offset: 0x000E6920
		private void method_36()
		{
			List<Class340> list = Class331.smethod_14();
			if (list == null)
			{
				return;
			}
			for (int i = 0; i < list.Count; i++)
			{
				Class340 class = list[i];
				if (class.method_2())
				{
					float num = this.method_35(class.double_1);
					float num2 = this.method_35((i == list.Count - 1) ? ((double)Class331.smethod_31()) : list[i + 1].double_1);
					Class115.class582_0.method_2(new Vector2(num, (float)this.rectangle_1.get_Top() + (float)this.rectangle_1.Height * 0.36f), new Vector2(num2, (float)this.rectangle_1.get_Top() + (float)this.rectangle_1.Height * 0.64f), Editor.color_1);
				}
			}
			foreach (Class705 current in this.class872_0.list_0)
			{
				float num3 = this.method_35((double)current.int_2);
				float num4 = this.method_35((double)current.int_0);
				Class115.class582_0.method_2(new Vector2(num3, (float)this.rectangle_1.get_Top() + (float)this.rectangle_1.Height * 0.4f), new Vector2(num4, (float)this.rectangle_1.get_Top() + (float)this.rectangle_1.Height * 0.6f), Editor.color_2);
			}
			float num5 = (float)(this.rectangle_1.get_Top() + this.rectangle_1.Height / 2);
			Class115.class882_0.method_0();
			Class115.class882_0.method_1(new Vector2((float)this.rectangle_1.get_Left(), num5), Editor.color_4);
			Class115.class882_0.method_1(new Vector2((float)this.rectangle_1.get_Right(), num5), Editor.color_4);
			Class296 class296_ = this.class297_0.class296_0;
			if (class296_.int_14 >= 0)
			{
				float num6 = this.method_35((double)class296_.int_14);
				Class115.class882_0.method_1(new Vector2(num6, (float)this.rectangle_1.get_Top()), Editor.color_7);
				Class115.class882_0.method_1(new Vector2(num6, (float)(this.rectangle_1.get_Top() + this.rectangle_1.Height)), Editor.color_7);
			}
			foreach (int current2 in this.class297_0.list_1)
			{
				float num7 = this.method_35((double)current2);
				Class115.class882_0.method_1(new Vector2(num7, (float)(this.rectangle_1.get_Top() + this.rectangle_1.Height / 2)), Editor.color_3);
				Class115.class882_0.method_1(new Vector2(num7, (float)(this.rectangle_1.get_Top() + this.rectangle_1.Height)), Editor.color_3);
			}
			for (int j = 0; j < list.Count; j++)
			{
				Class340 class2 = list[j];
				float num8 = this.method_35(class2.double_1);
				Color color = class2.method_0() ? Editor.color_5 : Editor.color_6;
				Class115.class882_0.method_1(new Vector2(num8, (float)this.rectangle_1.get_Top()), color);
				Class115.class882_0.method_1(new Vector2(num8, (float)(this.rectangle_1.get_Top() + this.rectangle_1.Height / 2)), color);
			}
			Class115.class882_0.method_2();
		}

		// Token: 0x0600267A RID: 9850
		// RVA: 0x000E8AE8 File Offset: 0x000E6CE8
		private void method_37()
		{
			if (this.int_2 < 1)
			{
				return;
			}
			float num = Class115.float_1 * (float)this.int_2;
			Vector2 vector2_ = Class115.vector2_0;
			Class115.class882_0.method_0();
			if (this.class297_0.class296_0.method_5() != PlayModes.OsuMania)
			{
				bool flag = false;
				for (float num2 = 0f; num2 <= Class115.float_3 + 1f; num2 += num)
				{
					if (!flag && num2 >= Class115.float_3 / 2f - 1f)
					{
						flag = true;
						Class115.class882_0.method_1(new Vector2(num2, 0f) + vector2_, Editor.color_9);
						Class115.class882_0.method_1(new Vector2(num2, Class115.float_0) + vector2_, Editor.color_9);
					}
					else
					{
						Class115.class882_0.method_1(new Vector2(num2, 0f) + vector2_, Editor.color_8);
						Class115.class882_0.method_1(new Vector2(num2, Class115.float_0) + vector2_, Editor.color_8);
					}
				}
				flag = false;
				for (float num3 = 0f; num3 <= Class115.float_0 + 1f; num3 += num)
				{
					if (!flag && num3 >= Class115.float_0 / 2f - 1f)
					{
						flag = true;
						Class115.class882_0.method_1(new Vector2(0f, num3) + vector2_, Editor.color_9);
						Class115.class882_0.method_1(new Vector2(Class115.float_3, num3) + vector2_, Editor.color_9);
					}
					else
					{
						Class115.class882_0.method_1(new Vector2(0f, num3) + vector2_, Editor.color_8);
						Class115.class882_0.method_1(new Vector2(Class115.float_3, num3) + vector2_, Editor.color_8);
					}
				}
			}
			if (this.enum105_0 == Enum105.const_2)
			{
				float num4 = (float)((int)((float)Class115.int_22 * Class115.smethod_48()));
				float num5 = (float)((int)((float)Class115.int_23 * Class115.smethod_48()));
				float num6 = ((float)Class115.int_22 - num4) / 2f + (float)Class115.int_26;
				float num7 = ((float)Class115.int_23 - num5) / 4f * 3f + (float)Class115.int_25;
				num4 = 640f * Class115.float_1;
				num5 = 480f * Class115.float_1;
				Class115.class882_0.method_1(new Vector2(num6, num7), Editor.color_8);
				Class115.class882_0.method_1(new Vector2(num6 + num4, num7), Editor.color_8);
				Class115.class882_0.method_1(new Vector2(num6 + num4, num7), Editor.color_8);
				Class115.class882_0.method_1(new Vector2(num6 + num4, num7 + num5), Editor.color_8);
				Class115.class882_0.method_1(new Vector2(num6 + num4, num7 + num5), Editor.color_8);
				Class115.class882_0.method_1(new Vector2(num6, num7 + num5), Editor.color_8);
				Class115.class882_0.method_1(new Vector2(num6, num7 + num5), Editor.color_8);
				Class115.class882_0.method_1(new Vector2(num6, num7), Editor.color_8);
			}
			Class115.class882_0.method_2();
		}

		// Token: 0x0600267E RID: 9854
		// RVA: 0x000E8EF0 File Offset: 0x000E70F0
		internal void method_38(int int_12)
		{
			if (int_12 >= 25 && int_12 <= 100)
			{
				bool flag = Math.Abs(Class331.smethod_67() - int_12) > 10;
				Class331.smethod_68(int_12);
				if (this.class531_7 != null)
				{
					float num = (float)(int_12 - 25) / 75f * 66f + 567f;
					this.class531_7.method_18(new Vector2(640f - num, 473f), flag ? 300 : 80);
					Class115.editorControl_0.method_3(int_12);
				}
				return;
			}
		}

		// Token: 0x0600267F RID: 9855
		// RVA: 0x0001DDC4 File Offset: 0x0001BFC4
		internal void method_39(Editor.GridSizes gridSizes_0)
		{
			this.method_40(gridSizes_0, true);
		}

		// Token: 0x06002652 RID: 9810
		// RVA: 0x0001DBE8 File Offset: 0x0001BDE8
		internal void method_4()
		{
			this.method_5(true);
		}

		// Token: 0x06002680 RID: 9856
		// RVA: 0x0001DDCE File Offset: 0x0001BFCE
		internal void method_40(Editor.GridSizes gridSizes_0, bool bool_18)
		{
			this.method_42((int)gridSizes_0, bool_18);
		}

		// Token: 0x06002681 RID: 9857
		// RVA: 0x0001DDD8 File Offset: 0x0001BFD8
		internal void method_41(int int_12)
		{
			this.method_42(int_12, true);
		}

		// Token: 0x06002682 RID: 9858
		// RVA: 0x000E8F74 File Offset: 0x000E7174
		internal void method_42(int int_12, bool bool_18)
		{
			this.int_2 = int_12;
			Class341.class608_3.Value = this.int_2;
			if (bool_18)
			{
				Class723.smethod_1("Grid Size: " + (Editor.GridSizes)int_12, 1000);
			}
			Class115.editorControl_0.method_4((Editor.GridSizes)int_12);
		}

		// Token: 0x06002683 RID: 9859
		// RVA: 0x000E8FC0 File Offset: 0x000E71C0
		private void method_43()
		{
			this.class911_1 = new Class911(true);
			this.class911_2 = new Class911(true);
			this.class533_0 = new Class533(string.Empty, 14f, new Vector2(10f, 463f), 1f, true, Color.get_White());
			this.class533_0.origins_0 = Origins.TopLeft;
			this.class533_0.bool_1 = true;
			this.class533_0.string_0 = "Jump to specific time.";
			this.class533_0.method_2(new EventHandler(this.method_44));
			this.class911_1.Add(this.class533_0);
			this.class531_5 = new Class531(Class885.Load("editor-kiai", Enum112.flag_1), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(0f, 66f), 0.98f, true, Color.get_White(), null);
			this.class531_5.float_3 = 0f;
			this.class911_1.Add(this.class531_5);
			this.class531_6 = new Class531(Class885.Load("editor-kiai", Enum112.flag_1), Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(0f, 66f), 1f, true, Color.get_White(), null);
			this.class531_6.float_3 = 0f;
			this.class531_6.bool_7 = true;
			this.class911_1.Add(this.class531_6);
			this.class533_1 = new Class533("", 12f, new Vector2(70f, 465f), 1f, true, Color.get_White());
			this.class911_1.Add(this.class533_1);
			this.class911_1.Add(new Class531(Class885.Load("editor-menu-bg-top", Enum112.flag_1), Enum115.const_5, Origins.TopLeft, Enum114.const_0, Vector2.get_Zero(), 0f, true, Color.get_White(), null)
			{
				vector2_2 = new Vector2(1024f * (float)Class115.smethod_43() / (float)Class115.int_20, 1f)
			});
			this.class911_1.Add(new Class531(Class885.Load("editor-menu-bg-bottom", Enum112.flag_1), Enum115.const_11, Origins.BottomLeft, Enum114.const_0, Vector2.get_Zero(), 0f, true, Color.get_White(), null)
			{
				vector2_2 = new Vector2(1024f * (float)Class115.smethod_43() / (float)Class115.int_20, 1f)
			});
			this.class911_1.Add(new Class531(Class885.Load("topmenu-bg", Enum112.flag_1), Enum115.const_5, Origins.TopLeft, Enum114.const_0, Vector2.get_Zero(), 0.1f, true, Color.get_White(), null));
			this.class531_10 = new Class531(Class885.Load("topmenu-selection", Enum112.flag_1), Enum115.const_5, Origins.TopLeft, Enum114.const_0, Vector2.get_Zero(), 0.8f, true, Color.get_White(), null);
			this.class911_1.Add(this.class531_10);
			if (Class115.bool_32)
			{
				this.class531_10.bool_7 = true;
			}
			Class531[] array = new Class531[4];
			array[1] = new Class531(Class885.Load("editor-compose-help", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(320f + Class115.smethod_45(), 240f), 1f, true, Color.get_TransparentWhite(), null);
			this.class531_4 = array;
			this.class911_1.Add<Class531>(this.class531_4);
			Class531 class = new Class531(Class885.Load("editor-timeline-plus", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(10f, 37f), 1f, true, Color.get_White(), null);
			class.bool_1 = true;
			class.class746_0 = new Class746(TransformationType.Scale, 1.1f, 1f, 0, 200, Enum70.const_0);
			class.method_2(new EventHandler(this.method_54));
			class.string_0 = "Increase timeline zoom";
			this.class911_1.Add(class);
			class = new Class531(Class885.Load("editor-timeline-minus", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(10f, 53f), 1f, true, Color.get_White(), null);
			class.bool_1 = true;
			class.class746_0 = new Class746(TransformationType.Scale, 1.1f, 1f, 0, 200, Enum70.const_0);
			class.string_0 = "Decrease timeline zoom";
			class.method_2(new EventHandler(this.method_55));
			this.class911_1.Add(class);
			float num = Class611.smethod_0(Class115.form_0, false) / 96f;
			Class533 class2 = new Class533(Editor.smethod_4(), 10f * num, new Vector2(70f, 70f), new Vector2((float)Class115.int_22 - 140f * Class115.float_4, Class115.float_0), 1f, false, Color.get_TransparentWhite(), true);
			class2.nullable_2 = new bool?(true);
			class2.bool_17 = false;
			class2.enum72_0 = Enum72.const_2;
			class2.bool_15 = false;
			class2.class26_0.Add(new Class746(TransformationType.Fade, 1f, 1f, Class115.int_1, Class115.int_1 + 10000, Enum70.const_0));
			class2.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class115.int_1 + 10000, Class115.int_1 + 10500, Enum70.const_0));
			this.class911_1.Add(class2);
			this.class531_8 = new Class531(Class885.Load("seekbar-over", Enum112.flag_1), Enum115.const_15, Origins.Centre, Enum114.const_0, new Vector2((float)this.rectangle_1.get_Left(), (float)(this.rectangle_1.get_Top() + this.rectangle_1.Height / 2)), 1f, true, Color.get_White(), null);
			this.class531_8.bool_7 = true;
			this.class911_2.Add(this.class531_8);
			int num2 = 0;
			if (this.class297_0.class296_0.method_5() == PlayModes.OsuMania)
			{
				num2 = (int)(25f + 30f * this.class297_0.class296_0.DifficultyCircleSize);
				Editor.rectangle_0.Width = Math.Max(400 + num2, Editor.rectangle_0.Width);
			}
			this.class531_0 = new Class531(Class885.Load("editor-timeline-plus", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2((float)(150 + num2), 450f), 1f, true, Color.get_TransparentWhite(), "bookmark");
			this.class531_0.bool_1 = true;
			this.class531_0.class746_0 = new Class746(TransformationType.Scale, 1.1f, 1f, 0, 200, Enum70.const_0);
			this.class531_0.method_2(new EventHandler(this.method_49));
			this.class531_0.string_0 = "Add new bookmark at current location (Ctrl+B)";
			this.class911_1.Add(this.class531_0);
			this.class531_9 = new Class531(Class885.Load("editor-timeline-minus", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2((float)(170 + num2), 450f), 1f, true, Color.get_TransparentWhite(), "bookmark");
			this.class531_9.bool_1 = true;
			this.class531_9.class746_0 = new Class746(TransformationType.Scale, 1.1f, 1f, 0, 200, Enum70.const_0);
			this.class531_9.string_0 = "Remove bookmark at current location (Ctrl+Shift+B)";
			this.class531_9.method_2(new EventHandler(this.method_48));
			this.class911_1.Add(this.class531_9);
			this.class531_2 = new Class531(Class885.Load("editor-timeline-left", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2((float)(190 + num2), 450f), 1f, true, Color.get_TransparentWhite(), "bookmark");
			this.class531_2.bool_1 = true;
			this.class531_2.class746_0 = new Class746(TransformationType.Scale, 1.1f, 1f, 0, 200, Enum70.const_0);
			this.class531_2.string_0 = "Seek to previous bookmark (Ctrl-LeftArrow)";
			this.class531_2.method_2(new EventHandler(this.method_45));
			this.class911_1.Add(this.class531_2);
			this.class531_1 = new Class531(Class885.Load("editor-timeline-right", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2((float)(210 + num2), 450f), 1f, true, Color.get_TransparentWhite(), "bookmark");
			this.class531_1.bool_1 = true;
			this.class531_1.string_0 = "Seek to next bookmark (Ctrl-RightArrow)";
			this.class531_1.class746_0 = new Class746(TransformationType.Scale, 1.1f, 1f, 0, 200, Enum70.const_0);
			this.class531_1.method_2(new EventHandler(this.method_46));
			this.class911_1.Add(this.class531_1);
			this.class531_3 = new Class531(Class885.Load("editor-timeline-reset", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2((float)(242 + num2), 450f), 1f, true, Color.get_TransparentWhite(), "bookmark");
			this.class531_3.bool_1 = true;
			this.class531_3.string_0 = "Reset all bookmarks";
			this.class531_3.class746_0 = new Class746(TransformationType.Scale, 1.1f, 1f, 0, 200, Enum70.const_0);
			this.class531_3.method_2(new EventHandler(this.method_47));
			this.class911_1.Add(this.class531_3);
			this.class531_7 = new Class531(Class885.Load("editor-rate-arrow", Enum112.flag_1), Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(18f, 483f), 1f, true, Color.get_White(), null);
			this.class911_1.Add(this.class531_7);
			Class746 class3 = new Class746(TransformationType.Fade, 0.5f, 1f, 0, 100, Enum70.const_0);
			class3.enum70_0 = Enum70.const_1;
			class = new Class531(Class885.Load("editor-rate-25", Enum112.flag_1), Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(85f, 470f), 1f, true, new Color(255, 255, 255, 128), null);
			class.bool_1 = true;
			class.class746_1 = class3;
			class.object_0 = 25;
			class.method_2(new EventHandler(this.method_58));
			this.class911_1.Add(class);
			class = new Class531(Class885.Load("editor-rate-50", Enum112.flag_1), Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(62f, 470f), 1f, true, new Color(255, 255, 255, 128), null);
			class.bool_1 = true;
			class.object_0 = 50;
			class.class746_1 = class3;
			class.method_2(new EventHandler(this.method_58));
			this.class911_1.Add(class);
			class = new Class531(Class885.Load("editor-rate-75", Enum112.flag_1), Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(41f, 470f), 1f, true, new Color(255, 255, 255, 128), null);
			class.bool_1 = true;
			class.object_0 = 75;
			class.method_2(new EventHandler(this.method_58));
			class.class746_1 = class3;
			this.class911_1.Add(class);
			class = new Class531(Class885.Load("editor-rate-100", Enum112.flag_1), Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(18f, 470f), 1f, true, new Color(255, 255, 255, 128), null);
			class.bool_1 = true;
			class.object_0 = 100;
			class.method_2(new EventHandler(this.method_58));
			class.class746_1 = class3;
			this.class911_1.Add(class);
			class = new Class531(Class885.Load("editor-rate-bg", Enum112.flag_1), Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(77f, 470f), 1f, true, Color.get_White(), null);
			this.class911_1.Add(class);
			class3 = new Class746(TransformationType.Scale, 1f, 1.2f, 0, 100, Enum70.const_0);
			class3.enum70_0 = Enum70.const_1;
			Class746 class4 = new Class746(TransformationType.Scale, 1.1f, 1.2f, 0, 100, Enum70.const_0);
			class4.enum70_0 = Enum70.const_1;
			class = new Class531(Class885.Load("editor-button-play", Enum112.flag_1), Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(245f, 470f), 1f, true, Color.get_White(), null);
			class.bool_1 = true;
			class.class746_0 = class4;
			class.class746_1 = class3;
			class.method_2(new EventHandler(this.method_50));
			this.class911_1.Add(class);
			class = new Class531(Class885.Load("editor-button-pause", Enum112.flag_1), Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(225f, 470f), 1f, true, Color.get_White(), null);
			class.bool_1 = true;
			class.class746_0 = class4;
			class.class746_1 = class3;
			class.method_2(new EventHandler(this.method_51));
			this.class911_1.Add(class);
			class = new Class531(Class885.Load("editor-button-stop", Enum112.flag_1), Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(205f, 470f), 1f, true, Color.get_White(), null);
			class.bool_1 = true;
			class.class746_0 = class4;
			class.class746_1 = class3;
			class.method_2(new EventHandler(this.method_52));
			this.class911_1.Add(class);
			class = new Class531(Class885.Load("editor-button-test", Enum112.flag_1), Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(175f, 470f), 1f, true, Color.get_White(), null);
			class.bool_1 = true;
			class.string_0 = "Enter test mode, where you can play through from the current location.\nThis requires saving your beatmap.";
			class.class746_0 = class4;
			class.class746_1 = class3;
			class.method_2(new EventHandler(this.method_53));
			this.class911_1.Add(class);
		}

		// Token: 0x06002684 RID: 9860
		// RVA: 0x000E9D0C File Offset: 0x000E7F0C
		private void method_44(object sender, EventArgs e)
		{
			if (!this.bool_12 && this.gotoTime_0 == null)
			{
				this.bool_14 = true;
				this.gotoTime_0 = new GotoTime(this.class533_0.Text);
				this.gotoTime_0.FormClosed += new FormClosedEventHandler(this.gotoTime_0_FormClosed);
				this.gotoTime_0.method_6(Origins.BottomLeft);
				return;
			}
		}

		// Token: 0x06002685 RID: 9861
		// RVA: 0x000E9D6C File Offset: 0x000E7F6C
		private void method_45(object sender, EventArgs e)
		{
			int num = -1;
			foreach (int current in this.class297_0.list_1)
			{
				if (current >= Class331.int_7 - 500)
				{
					break;
				}
				num = current;
			}
			if (num >= 0)
			{
				Class331.smethod_70(num, false, false);
			}
		}

		// Token: 0x06002686 RID: 9862
		// RVA: 0x000E9DDC File Offset: 0x000E7FDC
		private void method_46(object sender, EventArgs e)
		{
			foreach (int current in this.class297_0.list_1)
			{
				if (current > Class331.int_7 + 50)
				{
					Class331.smethod_70(current, false, false);
					break;
				}
			}
		}

		// Token: 0x06002687 RID: 9863
		// RVA: 0x0001DDE2 File Offset: 0x0001BFE2
		private void method_47(object sender, EventArgs e)
		{
			if (MessageBox.Show(Class115.form_0, "Remove all bookmarks?", "osu!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.OK)
			{
				this.class297_0.list_1.Clear();
				Editor.editor_0.bool_5 = true;
			}
		}

		// Token: 0x06002688 RID: 9864
		// RVA: 0x000E9E44 File Offset: 0x000E8044
		private void method_48(object sender, EventArgs e)
		{
			int num = -1;
			int num2 = -1;
			for (int i = 0; i < Editor.editor_0.class297_0.list_1.Count; i++)
			{
				int num3 = Math.Abs(Editor.editor_0.class297_0.list_1[i] - Class331.int_7);
				if (num3 < 2000 && (num3 < num2 || num2 == -1))
				{
					num = i;
					num2 = num3;
				}
			}
			if (num > -1)
			{
				Editor.editor_0.class297_0.list_1.RemoveAt(num);
				Editor.editor_0.bool_5 = true;
			}
			Editor.editor_0.class297_0.list_1.Sort();
		}

		// Token: 0x06002689 RID: 9865
		// RVA: 0x000E9EE4 File Offset: 0x000E80E4
		private void method_49(object sender, EventArgs e)
		{
			if (!this.class297_0.list_1.Contains(this.class375_0.method_5((double)Class331.int_7)))
			{
				this.class297_0.list_1.Add(this.class375_0.method_5((double)Class331.int_7));
				Editor.editor_0.bool_5 = true;
			}
			this.class297_0.list_1.Sort();
		}

		// Token: 0x06002653 RID: 9811
		// RVA: 0x000E6240 File Offset: 0x000E4440
		internal void method_5(bool bool_18)
		{
			this.method_9();
			Class115.smethod_6(true);
			SongSetup songSetup = new SongSetup(false, bool_18);
			songSetup.ShowDialog(Class115.form_0);
			Class115.smethod_6(false);
			if (!this.class297_0.class296_0.bool_5)
			{
				Class885.smethod_22();
			}
			this.class297_0.vmethod_0(false);
			this.class297_0.method_20(true);
		}

		// Token: 0x0600268A RID: 9866
		// RVA: 0x0001DE1A File Offset: 0x0001C01A
		private void method_50(object sender, EventArgs e)
		{
			if (Class331.enum100_0 == Enum100.const_1)
			{
				Class331.smethod_87();
				return;
			}
			this.method_59();
		}

		// Token: 0x0600268B RID: 9867
		// RVA: 0x0001DE30 File Offset: 0x0001C030
		private void method_51(object sender, EventArgs e)
		{
			this.method_59();
		}

		// Token: 0x0600268C RID: 9868
		// RVA: 0x000E9F50 File Offset: 0x000E8150
		private void method_52(object sender, EventArgs e)
		{
			Class331.smethod_90();
			foreach (Class304 current in this.class297_0.list_3)
			{
				current.vmethod_18();
			}
		}

		// Token: 0x0600268D RID: 9869
		// RVA: 0x0001DE38 File Offset: 0x0001C038
		private void method_53(object sender, EventArgs e)
		{
			this.method_7();
		}

		// Token: 0x0600268E RID: 9870
		// RVA: 0x000E9FB0 File Offset: 0x000E81B0
		private void method_54(object sender, EventArgs e)
		{
			Class296 arg_2F_0 = this.class297_0.class296_0;
			float float_;
			this.method_67(float_ = Class778.smethod_2(this.method_66() + 0.1f, 0.1f, 8f));
			arg_2F_0.float_2 = float_;
		}

		// Token: 0x0600268F RID: 9871
		// RVA: 0x000E9FF4 File Offset: 0x000E81F4
		private void method_55(object sender, EventArgs e)
		{
			Class296 arg_2F_0 = this.class297_0.class296_0;
			float float_;
			this.method_67(float_ = Class778.smethod_2(this.method_66() - 0.1f, 0.1f, 8f));
			arg_2F_0.float_2 = float_;
		}

		// Token: 0x06002690 RID: 9872
		// RVA: 0x000EA038 File Offset: 0x000E8238
		internal void method_56()
		{
			if (this.enum105_0 == Enum105.const_1)
			{
				if (this.class297_0.class296_0.method_5() != PlayModes.OsuMania)
				{
					if (!this.bool_8)
					{
						this.class531_4[1].method_14(100, Enum70.const_0);
					}
					else
					{
						this.class531_4[1].method_16(100, Enum70.const_0);
					}
					this.bool_8 = !this.bool_8;
					return;
				}
			}
		}

		// Token: 0x06002691 RID: 9873
		// RVA: 0x000EA0A0 File Offset: 0x000E82A0
		internal void method_57(Enum105 enum105_2)
		{
			if (this.bool_8)
			{
				this.method_56();
			}
			Class800.smethod_24();
			if (Class331.smethod_14().Count == 0 && enum105_2 != Enum105.const_3)
			{
				MessageBox.Show("Please time the song first!  This is imperative to creating a good beatmap.  Read the guide on the site if you don't understand timing, or ask in the Beatmap Help forum.", "denied", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			if (enum105_2 == this.enum105_0)
			{
				return;
			}
			this.enum105_0 = enum105_2;
			this.class531_10.method_19(new Vector2((float)((this.enum105_0 - Enum105.const_1) * 100), 0f), 300, Enum70.const_1);
			if (this.class370_0 != null)
			{
				this.class370_0.vmethod_12();
			}
			List<Class304> arg_AB_0 = this.class297_0.list_4;
			if (Editor.action_0 == null)
			{
				Editor.action_0 = new Action<Class304>(Editor.smethod_12);
			}
			arg_AB_0.ForEach(Editor.action_0);
			switch (enum105_2)
			{
			case Enum105.const_1:
				this.class370_0 = this.class371_0;
				break;
			case Enum105.const_2:
				this.class370_0 = this.class376_0;
				break;
			case Enum105.const_3:
				this.class370_0 = this.class375_0;
				break;
			}
			this.class370_0.vmethod_11();
			this.method_61();
			Class115.editorControl_0.method_2(enum105_2);
		}

		// Token: 0x06002692 RID: 9874
		// RVA: 0x000EA1BC File Offset: 0x000E83BC
		private void method_58(object sender, EventArgs e)
		{
			this.method_38((int)((Class531)sender).object_0);
			((Class531)sender).class26_0.Add(new Class746(TransformationType.Scale, 1.2f, 1f, Class115.int_1, Class115.int_1 + 100, Enum70.const_0));
		}

		// Token: 0x06002693 RID: 9875
		// RVA: 0x000EA210 File Offset: 0x000E8410
		internal void method_59()
		{
			Class331.smethod_88();
			foreach (Class304 current in this.class297_0.list_3)
			{
				current.vmethod_18();
			}
		}

		// Token: 0x06002654 RID: 9812
		// RVA: 0x0001DBF1 File Offset: 0x0001BDF1
		internal bool method_6()
		{
			this.class371_0.method_52();
			return this.class297_0.method_3(false, false, true);
		}

		// Token: 0x06002695 RID: 9877
		// RVA: 0x000EA2A8 File Offset: 0x000E84A8
		internal void method_60()
		{
			this.method_61();
			this.rectangle_1 = new Rectangle((int)(110f * Class115.float_4), (int)(460f * Class115.float_4 + (float)Class115.int_25), (int)(Class115.float_4 * (float)(Class115.smethod_43() - 370)), (int)(Class115.float_4 * 20f));
			Editor.rectangle_0 = new Rectangle((int)(110f * Class115.float_4), (int)(430f * Class115.float_4 + (float)Class115.int_25), (int)(Class115.float_4 * (float)(Class115.smethod_43() - 440)), (int)(Class115.float_4 * 40f));
		}

		// Token: 0x06002696 RID: 9878
		// RVA: 0x000EA34C File Offset: 0x000E854C
		private void method_61()
		{
			this.rectangle_2 = new Rectangle((int)(Class115.float_4 * (float)this.int_4), (int)(Class115.float_4 * (float)this.int_5 + (float)Class115.int_25), (int)(Class115.float_4 * (float)this.int_11), (int)(Class115.float_4 * (float)this.int_3));
		}

		// Token: 0x06002697 RID: 9879
		// RVA: 0x0001DE40 File Offset: 0x0001C040
		internal void method_62()
		{
			this.class370_0.vmethod_18();
		}

		// Token: 0x06002698 RID: 9880
		// RVA: 0x0001DE4D File Offset: 0x0001C04D
		internal void method_63()
		{
			this.class370_0.vmethod_19();
		}

		// Token: 0x06002699 RID: 9881
		// RVA: 0x0001DE5A File Offset: 0x0001C05A
		internal void method_64()
		{
			this.class370_0.vmethod_16();
		}

		// Token: 0x0600269A RID: 9882
		// RVA: 0x0001DE67 File Offset: 0x0001C067
		internal void method_65()
		{
			if (this.class370_0 != null)
			{
				this.class370_0.vmethod_17();
			}
		}

		// Token: 0x0600269B RID: 9883
		// RVA: 0x0001DE7C File Offset: 0x0001C07C
		internal float method_66()
		{
			return Editor.float_0;
		}

		// Token: 0x0600269C RID: 9884
		// RVA: 0x0001DE83 File Offset: 0x0001C083
		internal void method_67(float float_1)
		{
			Editor.float_0 = float_1;
			this.method_60();
		}

		// Token: 0x0600269D RID: 9885
		// RVA: 0x000EA3A4 File Offset: 0x000E85A4
		private void method_68()
		{
			if (Class331.smethod_17() && this.int_6 > 0)
			{
				this.double_0 = Class331.smethod_8() / (double)this.int_6;
			}
			else
			{
				this.double_0 = 250.0;
			}
			this.class370_0.vmethod_13();
			this.class911_3.Draw();
			Class115.class882_0.method_0();
			if (this.enum105_0 != Enum105.const_3 && Class331.smethod_14() != null)
			{
				int int_ = this.class297_0.class296_0.int_14;
				if (int_ >= 0 && int_ >= this.int_8 && int_ <= this.int_9)
				{
					float num = this.method_70((double)int_);
					Class115.class882_0.method_1(new Vector2(num, (float)this.rectangle_2.get_Top()), Editor.color_7);
					Class115.class882_0.method_1(new Vector2(num, (float)this.rectangle_2.get_Bottom()), Editor.color_7);
				}
				foreach (Class340 current in Class331.smethod_14())
				{
					if (current.double_1 >= (double)this.int_8 && current.double_1 <= (double)this.int_9)
					{
						Color color = current.method_0() ? new Color(180, 20, 20, 150) : new Color(156, 255, 0, 150);
						float num2 = this.method_70(current.double_1);
						Class115.class882_0.method_1(new Vector2(num2, (float)this.rectangle_2.get_Top()), color);
						Class115.class882_0.method_1(new Vector2(num2, (float)this.rectangle_2.get_Bottom()), color);
					}
				}
			}
			Class115.class882_0.method_1(new Vector2((float)this.rectangle_2.get_Left(), (float)this.rectangle_2.get_Bottom()), this.color_17);
			Class115.class882_0.method_1(new Vector2((float)this.rectangle_2.get_Right(), (float)this.rectangle_2.get_Bottom()), this.color_17);
			Class115.class882_0.method_1(new Vector2((float)(this.rectangle_2.get_Left() + this.rectangle_2.Width / 2 - 1), (float)this.rectangle_2.get_Top()), this.color_17);
			Class115.class882_0.method_1(new Vector2((float)(this.rectangle_2.get_Left() + this.rectangle_2.Width / 2 - 1), (float)this.rectangle_2.get_Bottom()), this.color_17);
			Class115.class882_0.method_1(new Vector2((float)(this.rectangle_2.get_Left() + this.rectangle_2.Width / 2 + 1), (float)this.rectangle_2.get_Top()), this.color_17);
			Class115.class882_0.method_1(new Vector2((float)(this.rectangle_2.get_Left() + this.rectangle_2.Width / 2 + 1), (float)this.rectangle_2.get_Bottom()), this.color_17);
			int num3;
			double num4;
			if (Class331.smethod_17() && Class331.smethod_8() > 0.0)
			{
				num3 = (int)Math.Floor(((double)this.int_8 - Class331.smethod_12()) / Class331.smethod_8());
				num4 = (double)num3 * Class331.smethod_8() + Class331.smethod_12();
			}
			else
			{
				num3 = 0;
				num4 = (double)this.int_8 / this.double_0;
			}
			int num5 = (int)((Class331.int_2 < 0) ? Enum37.const_0 : Class331.smethod_14()[Class331.int_2].enum37_0);
			if (this.double_0 > 1E-05)
			{
				int num6 = 0;
				for (double num7 = num4; num7 < (double)this.int_9; num7 += this.double_0)
				{
					int num8 = num6 % this.int_6;
					Color color2;
					if (num8 == 0)
					{
						color2 = this.color_14;
					}
					else if (num8 * 2 % this.int_6 == 0)
					{
						color2 = this.color_12;
					}
					else if (num8 * 3 % this.int_6 == 0)
					{
						color2 = this.color_13;
					}
					else if (num8 * 4 % this.int_6 == 0)
					{
						color2 = this.color_10;
					}
					else if (num8 * 6 % this.int_6 == 0)
					{
						color2 = this.color_15;
					}
					else if (num8 * 8 % this.int_6 == 0)
					{
						color2 = this.color_11;
					}
					else
					{
						color2 = this.color_16;
					}
					int bottom = this.rectangle_2.get_Bottom();
					if (num7 >= (double)this.int_8)
					{
						if (num6 % this.int_6 == 0)
						{
							Class115.class882_0.method_1(new Vector2(this.method_70(num7), (float)(this.rectangle_2.get_Bottom() - this.int_10 * ((num3 % num5 == 0) ? 2 : 1))), color2);
							Class115.class882_0.method_1(new Vector2(this.method_70(num7), (float)bottom), color2);
						}
						else
						{
							Class115.class882_0.method_1(new Vector2(this.method_70(num7), (float)(this.rectangle_2.get_Bottom() - this.int_10 / 8 * 7)), color2);
							Class115.class882_0.method_1(new Vector2(this.method_70(num7), (float)this.rectangle_2.get_Bottom()), color2);
						}
					}
					if (num6 % this.int_6 == 0)
					{
						num3++;
					}
					num6++;
				}
			}
			Color color3;
			color3..ctor(58, 110, 170, 240);
			foreach (int current2 in this.class297_0.list_1)
			{
				if (current2 >= this.int_8 && current2 <= this.int_9)
				{
					Class115.class882_0.method_1(new Vector2(this.method_70((double)current2), (float)this.rectangle_2.get_Top()), color3);
					Class115.class882_0.method_1(new Vector2(this.method_70((double)current2), (float)this.rectangle_2.get_Bottom()), color3);
				}
			}
			Class115.class882_0.method_2();
			this.class370_0.vmethod_5();
		}

		// Token: 0x0600269E RID: 9886
		// RVA: 0x000EA9BC File Offset: 0x000E8BBC
		internal float method_69(double double_1)
		{
			return (float)Math.Min(Math.Max((double)this.int_4 + (double_1 - (double)this.int_8) / (double)this.int_7 * (double)this.int_11, (double)this.int_4), (double)(this.int_4 + this.int_11));
		}

		// Token: 0x06002655 RID: 9813
		// RVA: 0x000E62A4 File Offset: 0x000E44A4
		internal void method_7()
		{
			Editor.enum105_1 = this.enum105_0;
			if (this.class297_0.list_3.Count == 0)
			{
				return;
			}
			if (Class331.enum100_0 == Enum100.const_1)
			{
				this.method_59();
			}
			this.class371_0.method_52();
			if (Class331.smethod_8() <= 0.0)
			{
				MessageBox.Show(Class41.GetString(OsuString.EditorControl_OneSectionRequiredWarning), "osu!", MessageBoxButtons.OK);
				return;
			}
			this.bool_3 = true;
			while (!Class331.smethod_14()[0].method_0())
			{
				Class331.smethod_14().RemoveAt(0);
				Class331.smethod_6(false);
			}
			this.bool_3 = false;
			this.method_80();
			this.method_89();
			Class115.bool_25 = true;
			Class115.int_28 = Class331.int_7;
			Class296 class296_ = this.class297_0.class296_0;
			Class62.Mode = class296_.method_5();
			List<Class304> arg_EC_0 = this.class297_0.list_3;
			if (Editor.predicate_0 == null)
			{
				Editor.predicate_0 = new Predicate<Class304>(Editor.smethod_5);
			}
			if (arg_EC_0.FindAll(Editor.predicate_0).Count == 0)
			{
				Class115.int_28 = 0;
			}
			if (this.bool_5 && !this.class297_0.method_3(true, false, false))
			{
				Class115.bool_25 = false;
				return;
			}
			if (class296_.method_16(class296_.method_5(), Mods.None) < 0.0)
			{
				class296_.method_19(class296_.method_5());
			}
			this.method_9();
			Class115.smethod_71(OsuModes.Play, false);
		}

		// Token: 0x0600269F RID: 9887
		// RVA: 0x000EAA0C File Offset: 0x000E8C0C
		internal float method_70(double double_1)
		{
			return (float)Math.Min(Math.Max((double)this.rectangle_2.get_Left() + (double_1 - (double)this.int_8) / (double)this.int_7 * (double)this.rectangle_2.Width, (double)this.rectangle_2.get_Left()), (double)this.rectangle_2.get_Right());
		}

		// Token: 0x060026A0 RID: 9888
		// RVA: 0x0001DE91 File Offset: 0x0001C091
		internal int method_71(int int_12)
		{
			return (int)((double)this.int_8 + (double)(int_12 - this.rectangle_2.get_Left()) / (double)this.rectangle_2.Width * (double)this.int_7);
		}

		// Token: 0x060026A1 RID: 9889
		// RVA: 0x0001DEBF File Offset: 0x0001C0BF
		private bool method_72(object object_0, EventArgs eventArgs_0)
		{
			if (Class570.bool_1)
			{
				if (this.bool_16)
				{
					this.method_54(null, null);
					return true;
				}
				if (this.class370_0.vmethod_24())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060026A2 RID: 9890
		// RVA: 0x0001DEEA File Offset: 0x0001C0EA
		private bool method_73(object object_0, EventArgs eventArgs_0)
		{
			if (Class570.bool_1)
			{
				if (this.bool_16)
				{
					this.method_55(null, null);
					return true;
				}
				if (this.class370_0.vmethod_25())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060026A3 RID: 9891
		// RVA: 0x0001DF15 File Offset: 0x0001C115
		private bool method_74(object object_0, EventArgs eventArgs_0)
		{
			if (this.class370_0.vmethod_23())
			{
				return true;
			}
			this.method_76(Class570.bool_2 ? 4 : 1);
			return true;
		}

		// Token: 0x060026A4 RID: 9892
		// RVA: 0x0001DF38 File Offset: 0x0001C138
		private bool method_75(object object_0, EventArgs eventArgs_0)
		{
			if (this.class370_0.vmethod_22())
			{
				return true;
			}
			this.method_77(Class570.bool_2 ? 4 : 1);
			return true;
		}

		// Token: 0x060026A5 RID: 9893
		// RVA: 0x000EAA68 File Offset: 0x000E8C68
		private void method_76(int int_12)
		{
			int num2;
			int num3;
			if (Class331.smethod_17())
			{
				if (Class331.enum100_0 == Enum100.const_1)
				{
					int_12 *= 250 / (int)Class331.smethod_8() + 1;
				}
				int num = (Class331.enum100_0 != Enum100.const_1) ? this.int_6 : 1;
				num2 = (int)(Class331.smethod_8() / (double)num) * int_12;
				num3 = this.class375_0.method_6((double)(Class331.int_7 - num2), (double)Class331.int_7);
				Class331.smethod_70(num3, this.enum105_0 == Enum105.const_2, false);
				return;
			}
			num2 = 1000 / this.int_6 * int_12;
			num3 = Class331.int_7 - num2;
			num3 -= num3 - 1000 / this.int_6 * Math.DivRem(num3, 1000 / this.int_6, out num2);
			if (num3 < 0)
			{
				num3 = 0;
			}
			Class331.smethod_70(num3, false, false);
		}

		// Token: 0x060026A6 RID: 9894
		// RVA: 0x000EAB2C File Offset: 0x000E8D2C
		private void method_77(int int_12)
		{
			int num2;
			int num3;
			if (Class331.smethod_17())
			{
				if (Class331.enum100_0 == Enum100.const_1)
				{
					int_12 *= 250 / (int)Class331.smethod_8() + 1;
				}
				int num = (Class331.enum100_0 != Enum100.const_1) ? this.int_6 : 1;
				num2 = (int)(Class331.smethod_8() / (double)num) * int_12;
				num3 = this.class375_0.method_6((double)(Class331.int_7 + num2), (double)Class331.int_7);
				Class331.smethod_70(num3, this.enum105_0 == Enum105.const_2, false);
				return;
			}
			num2 = 1000 / this.int_6 * int_12;
			num3 = Class331.int_7 + num2;
			num3 += 1000 / this.int_6 * Math.DivRem(num3, 1000 / this.int_6, out num2) - num3;
			Class331.smethod_70(num3, false, false);
		}

		// Token: 0x060026A7 RID: 9895
		// RVA: 0x000EABE8 File Offset: 0x000E8DE8
		private bool method_78(object object_0, Keys keys_0, bool bool_18)
		{
			if (Editor.bool_13)
			{
				return false;
			}
			if (this.bool_10 && Class331.enum100_0 == Enum100.const_1 && keys_0 == 27)
			{
				this.method_59();
				return true;
			}
			if (this.class370_0.vmethod_10(keys_0, bool_18))
			{
				return false;
			}
			if (Class570.bool_0)
			{
				switch (keys_0)
				{
				case 38:
					this.method_38(Math.Min(100, Class331.smethod_67() + (Class570.bool_2 ? 3 : 25)));
					return true;
				case 40:
					this.method_38(Math.Max(25, Class331.smethod_67() - (Class570.bool_2 ? 3 : 25)));
					return true;
				}
			}
			else
			{
				switch (keys_0)
				{
				case 37:
					this.method_76(Class570.bool_2 ? 4 : 1);
					return true;
				case 38:
					this.method_33();
					return true;
				case 39:
					this.method_77(Class570.bool_2 ? 4 : 1);
					return true;
				case 40:
					this.method_34();
					return true;
				}
			}
			if (bool_18)
			{
				if (Class570.bool_0)
				{
					switch (keys_0)
					{
					case 37:
						this.method_45(null, null);
						return true;
					case 38:
						break;
					case 39:
						this.method_46(null, null);
						return true;
					default:
						switch (keys_0)
						{
						case 49:
							this.method_39(Editor.GridSizes.Tiny);
							return true;
						case 50:
							this.method_39(Editor.GridSizes.Small);
							return true;
						case 51:
							this.method_39(Editor.GridSizes.Medium);
							return true;
						case 52:
							this.method_39(Editor.GridSizes.Large);
							return true;
						default:
							switch (keys_0)
							{
							case 65:
								if (Class570.bool_2)
								{
									this.method_79();
									return true;
								}
								break;
							case 66:
								if (Class570.bool_2)
								{
									this.method_48(null, null);
								}
								else
								{
									this.method_49(null, null);
								}
								return true;
							case 67:
								this.method_62();
								return true;
							case 68:
								if (Class570.bool_2)
								{
									this.method_92();
									return true;
								}
								break;
							case 70:
								if (Class570.bool_2)
								{
									this.method_93();
									return true;
								}
								break;
							case 73:
								if (Class570.bool_2)
								{
									this.method_88();
									return true;
								}
								this.class375_0.method_32();
								return true;
							case 76:
								this.method_3(this.class297_0.class296_0, true, Class570.bool_2);
								return true;
							case 78:
								this.Clear();
								return true;
							case 79:
								this.method_10(false);
								return true;
							case 80:
								if (Class570.bool_2)
								{
									this.class375_0.method_31(false);
								}
								else
								{
									this.class375_0.method_31(true);
								}
								return true;
							case 83:
								if (Class570.bool_2)
								{
									this.method_91();
									return true;
								}
								this.method_1();
								return true;
							case 85:
								if (Class570.bool_2)
								{
									this.method_12();
									return true;
								}
								break;
							case 89:
								this.method_21();
								return true;
							case 90:
								this.method_19();
								return true;
							}
							break;
						}
						break;
					}
				}
				if (!Class570.bool_0)
				{
					switch (Class795.smethod_4(keys_0, BindingTarget.Editor))
					{
					case Bindings.HelpToggle:
						this.method_56();
						break;
					case Bindings.JumpToBegin:
						this.class371_0.method_52();
						if (this.class297_0.int_14 == 0)
						{
							this.method_52(null, null);
							return true;
						}
						if (this.class297_0.list_3[0].StartTime == Class331.int_7)
						{
							this.method_52(null, null);
						}
						else
						{
							Class331.smethod_70(this.class297_0.list_3[0].StartTime, false, false);
						}
						return true;
					case Bindings.PlayFromBegin:
						Class331.smethod_87();
						return true;
					case Bindings.AudioPause:
						this.method_59();
						return true;
					case Bindings.JumpToEnd:
						if (this.class297_0.list_3.Count > 0 && Class331.int_7 < this.class297_0.list_3[this.class297_0.list_3.Count - 1].EndTime)
						{
							Class331.smethod_70(this.class297_0.list_3[this.class297_0.list_3.Count - 1].EndTime, false, false);
						}
						else
						{
							Class331.smethod_70(Math.Max(0, Class331.smethod_31() - 500), false, false);
						}
						return true;
					case Bindings.GridChange:
						this.method_41((this.int_2 * 2 <= 32) ? (this.int_2 * 2) : 4);
						return true;
					case Bindings.TimingSection:
						this.class375_0.method_31(true);
						return true;
					case Bindings.InheritingSection:
						this.class375_0.method_31(false);
						return true;
					case Bindings.RemoveSection:
						this.class375_0.method_32();
						return true;
					}
					if (keys_0 == 32)
					{
						this.method_59();
						return true;
					}
				}
				if (!Class570.bool_1)
				{
					if (keys_0 != 27)
					{
						switch (keys_0)
						{
						case 112:
							this.method_57(Enum105.const_1);
							return true;
						case 113:
							this.method_57(Enum105.const_2);
							return true;
						case 114:
							this.method_57(Enum105.const_3);
							return true;
						case 115:
							this.method_4();
							return true;
						case 116:
							this.method_7();
							return true;
						case 117:
							this.class375_0.method_12(Enum58.const_1);
							return true;
						}
					}
					else
					{
						if (this.bool_8)
						{
							this.method_56();
							return true;
						}
						if (this.class370_0.vmethod_15())
						{
							this.method_81();
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x060026A8 RID: 9896
		// RVA: 0x000EB104 File Offset: 0x000E9304
		internal void method_79()
		{
			if (this.aiModWindow_0 == null || this.aiModWindow_0.IsDisposed)
			{
				this.aiModWindow_0 = new AiModWindow(this);
			}
			this.aiModWindow_0.Run();
			if (!this.aiModWindow_0.Visible)
			{
				this.aiModWindow_0.Show(Class115.form_0);
			}
		}

		// Token: 0x06002656 RID: 9814
		// RVA: 0x0001DC0C File Offset: 0x0001BE0C
		internal bool method_8(bool bool_18)
		{
			if (this.bool_5)
			{
				this.class371_0.method_52();
				if (!this.class297_0.method_3(bool_18, false, false))
				{
					return false;
				}
				this.bool_5 = false;
			}
			return true;
		}

		// Token: 0x060026A9 RID: 9897
		// RVA: 0x0001DF5B File Offset: 0x0001C15B
		private void method_80()
		{
			if (this.aiModWindow_0 == null)
			{
				return;
			}
			this.aiModWindow_0.Close();
			this.aiModWindow_0 = null;
		}

		// Token: 0x060026AA RID: 9898
		// RVA: 0x0001DF78 File Offset: 0x0001C178
		internal bool method_81()
		{
			return this.method_82(true);
		}

		// Token: 0x060026AB RID: 9899
		// RVA: 0x000EB15C File Offset: 0x000E935C
		internal bool method_82(bool bool_18)
		{
			this.bool_6 = true;
			Editor.enum105_1 = Enum105.const_0;
			this.method_9();
			if (this.gotoTime_0 != null)
			{
				this.gotoTime_0.Close();
				this.gotoTime_0 = null;
			}
			Class115.smethod_6(true);
			if (this.class371_0 != null)
			{
				this.class371_0.method_52();
			}
			this.method_89();
			if (ErrorDialog.bool_1 && this.class297_0 != null && this.class297_0.list_3.Count == 0)
			{
				return false;
			}
			if (this.bool_5 && !this.class297_0.method_3(bool_18, false, false))
			{
				Class115.smethod_6(false);
				this.bool_6 = false;
				return false;
			}
			Class115.smethod_70(OsuModes.SelectEdit, false);
			Class296 class296_ = this.class297_0.class296_0;
			if (class296_.bool_2)
			{
				if (class296_.method_44() != null && class296_.method_44().method_16().Length > 0)
				{
					Class466.smethod_23(class296_.method_44().method_16()[0]);
				}
				else
				{
					List<Class296> arg_100_0 = Class466.list_3;
					if (Editor.predicate_7 == null)
					{
						Editor.predicate_7 = new Predicate<Class296>(Editor.smethod_13);
					}
					Class466.smethod_21(arg_100_0.Find(Editor.predicate_7));
				}
			}
			List<Class296> arg_12C_0 = Class466.list_3;
			if (Editor.predicate_8 == null)
			{
				Editor.predicate_8 = new Predicate<Class296>(Editor.smethod_14);
			}
			List<Class296> list = arg_12C_0.FindAll(Editor.predicate_8);
			List<Class296> arg_150_0 = list;
			if (Editor.action_1 == null)
			{
				Editor.action_1 = new Action<Class296>(Editor.smethod_15);
			}
			arg_150_0.ForEach(Editor.action_1);
			class296_.int_7 = Class331.int_7;
			Class115.int_28 = 0;
			Class115.bool_25 = false;
			Class115.smethod_6(false);
			return true;
		}

		// Token: 0x060026AC RID: 9900
		// RVA: 0x0001DF81 File Offset: 0x0001C181
		private bool method_83(object object_0, EventArgs eventArgs_0)
		{
			return !this.bool_4 && this.class370_0.vmethod_20();
		}

		// Token: 0x060026AD RID: 9901
		// RVA: 0x000EB2DC File Offset: 0x000E94DC
		private bool method_84(object object_0, EventArgs eventArgs_0)
		{
			if (this.bool_4 || (Class111.bool_2 && Class111.bool_1) || Class115.class89_0 != null || Class115.enum113_0 != Enum113.const_2 || Editor.smethod_2())
			{
				return false;
			}
			if (!this.bool_14)
			{
				if (this.gotoTime_0 != null)
				{
					this.gotoTime_0.Close();
				}
				this.gotoTime_0 = null;
			}
			if ((this.class911_1.class531_1 == null && this.class370_0.class911_0.class531_1 == null) || this.class370_0.vmethod_14())
			{
				this.class370_0.vmethod_6();
			}
			if (!this.class370_0.vmethod_14())
			{
				int x = Class802.point_0.X;
				if ((float)Class802.point_0.Y <= Class115.float_4 * 16f + (float)Class115.int_25 && Class802.point_0.Y >= Class115.int_25 && (float)x <= Class115.float_4 * 400f && x >= 0)
				{
					if ((float)x / (Class115.float_4 * 100f) >= 3f)
					{
						this.method_4();
					}
					else
					{
						this.method_57((Enum105)Math.Max(0f, (float)x / (Class115.float_4 * 100f) + 1f));
					}
					return true;
				}
			}
			if (this.bool_17 && !Class111.bool_2)
			{
				Class331.smethod_70((int)((float)Class331.smethod_31() * ((float)(Class802.point_0.X - this.rectangle_1.get_Left()) / (float)this.rectangle_1.Width)), false, false);
				return true;
			}
			return false;
		}

		// Token: 0x060026AE RID: 9902
		// RVA: 0x0001DF98 File Offset: 0x0001C198
		internal int method_85()
		{
			if (!Class331.smethod_17())
			{
				return Class331.int_7;
			}
			return this.class375_0.method_5((double)Class331.int_7);
		}

		// Token: 0x060026AF RID: 9903
		// RVA: 0x000EB468 File Offset: 0x000E9668
		private bool method_86(object object_0, EventArgs eventArgs_0)
		{
			if (Class115.class89_0 != null || Editor.smethod_2())
			{
				return false;
			}
			if (this.bool_4)
			{
				return false;
			}
			if (!this.bool_7)
			{
				this.bool_7 = true;
				if (this.class370_0.vmethod_8())
				{
					return true;
				}
				if (this.bool_17)
				{
					this.enum108_0 = Enum108.const_3;
					return true;
				}
			}
			return false;
		}

		// Token: 0x060026B0 RID: 9904
		// RVA: 0x0001DFB8 File Offset: 0x0001C1B8
		private bool method_87(object object_0, EventArgs eventArgs_0)
		{
			this.class370_0.vmethod_9();
			this.enum108_0 = Enum108.const_0;
			this.bool_7 = false;
			return false;
		}

		// Token: 0x060026B1 RID: 9905
		// RVA: 0x0001DFD4 File Offset: 0x0001C1D4
		public void method_88()
		{
			if (this.sampleImport_0 == null || this.sampleImport_0.IsDisposed)
			{
				this.sampleImport_0 = new SampleImport();
				this.sampleImport_0.Show(Class115.form_0);
			}
		}

		// Token: 0x060026B2 RID: 9906
		// RVA: 0x0001E006 File Offset: 0x0001C206
		internal void method_89()
		{
			if (this.sampleImport_0 != null && !this.sampleImport_0.IsDisposed)
			{
				this.sampleImport_0.Close();
				this.sampleImport_0 = null;
			}
		}

		// Token: 0x06002657 RID: 9815
		// RVA: 0x0001DC3B File Offset: 0x0001BE3B
		internal void method_9()
		{
			if (this.openDialog_0 != null)
			{
				this.openDialog_0.Close();
				this.openDialog_0 = null;
			}
		}

		// Token: 0x060026B3 RID: 9907
		// RVA: 0x000EB4C0 File Offset: 0x000E96C0
		public void method_90()
		{
			if (this.class370_0 == this.class371_0 && this.class371_0.list_1.Count != 0 && this.rotateBy_0 == null)
			{
				this.rotateBy_0 = new RotateBy();
				this.rotateBy_0.ShowDialog(Class115.form_0);
				this.rotateBy_0 = null;
				return;
			}
		}

		// Token: 0x060026B4 RID: 9908
		// RVA: 0x000EB51C File Offset: 0x000E971C
		public void method_91()
		{
			if (this.class370_0 == this.class371_0 && this.class371_0.list_1.Count != 0 && this.scaleBy_0 == null)
			{
				float num = this.class371_0.method_43(true);
				if (num == -1f)
				{
					num = 5f;
				}
				this.scaleBy_0 = new ScaleBy();
				this.scaleBy_0.method_0(0.5f);
				this.scaleBy_0.method_1(Math.Max(num, 1f));
				this.scaleBy_0.ShowDialog(Class115.form_0);
				this.scaleBy_0 = null;
				return;
			}
		}

		// Token: 0x060026B5 RID: 9909
		// RVA: 0x0001E02F File Offset: 0x0001C22F
		public void method_92()
		{
			if (this.class370_0 == this.class371_0 && this.polygon_0 == null)
			{
				this.polygon_0 = new Polygon();
				this.polygon_0.ShowDialog(Class115.form_0);
				this.polygon_0 = null;
				return;
			}
		}

		// Token: 0x060026B6 RID: 9910
		// RVA: 0x000EB5B8 File Offset: 0x000E97B8
		public void method_93()
		{
			if (this.class370_0 == this.class371_0 && this.class371_0.class321_1 != null && this.convertToStream_0 == null)
			{
				this.convertToStream_0 = new ConvertToStream(this.class371_0.class321_1);
				this.convertToStream_0.ShowDialog(Class115.form_0);
				this.convertToStream_0 = null;
				return;
			}
		}

		// Token: 0x060026B8 RID: 9912
		// RVA: 0x000EB618 File Offset: 0x000E9818
		[CompilerGenerated]
		private void method_94(bool bool_18)
		{
			Editor.Class627 class = new Editor.Class627();
			class.bool_0 = bool_18;
			class.editor_0 = this;
			Class115.class47_0.method_1(new VoidDelegate(class.method_0), 500, false);
		}

		// Token: 0x0600265D RID: 9821
		// RVA: 0x000E69DC File Offset: 0x000E4BDC
		internal static bool smethod_0(string string_0)
		{
			if (Editor.editor_0 != null)
			{
				if (Class115.osuModes_1 == OsuModes.Edit)
				{
					if (!Class331.smethod_79())
					{
						Class331.smethod_88();
					}
					int int_ = 0;
					if (int.TryParse(string_0, out int_))
					{
						Class331.smethod_70(int_, false, false);
						return true;
					}
					try
					{
						if (string_0.IndexOf('(') <= 0)
						{
							string[] array = string_0.Replace("-", string.Empty).Trim().Split(new char[]
							{
								':'
							});
							int num = 0;
							int num2;
							int num3;
							bool result;
							switch (array.Length)
							{
							case 2:
								num2 = int.Parse(array[0]);
								num3 = int.Parse(array[1]);
								break;
							case 3:
								num2 = int.Parse(array[0]);
								num3 = int.Parse(array[1]);
								num = int.Parse(array[2]);
								break;
							default:
								result = false;
								return result;
							}
							int int_2 = num2 * 60000 + num3 * 1000 + num;
							Class331.smethod_70(int_2, false, false);
							result = true;
							return result;
						}
						Editor.Class629 class = new Editor.Class629();
						class.int_0 = int.Parse(string_0.Substring(0, 2)) * 60000 + int.Parse(string_0.Substring(3, 2)) * 1000 + int.Parse(string_0.Substring(6, 3)) - 20;
						int num4 = Editor.editor_0.class297_0.list_3.FindIndex(new Predicate<Class304>(class.method_0));
						if (num4 < 0 || string_0.IndexOf(')') < 0)
						{
							Class331.smethod_70(class.int_0 + 20, false, false);
							bool result = true;
							return result;
						}
						Class331.smethod_70(Editor.editor_0.class297_0.list_3[num4].StartTime, false, false);
						Editor.editor_0.method_65();
						Editor.editor_0.method_57(Enum105.const_1);
						string[] array2 = string_0.Substring(11, string_0.IndexOf(')') - 11).Split(new char[]
						{
							','
						});
						if (array2.Length > 0 && array2[0].IndexOf('|') > 0)
						{
							string[] array3 = array2;
							for (int i = 0; i < array3.Length; i++)
							{
								string text = array3[i];
								string[] array4 = text.Split(new char[]
								{
									'|'
								});
								int num5 = 0;
								int num6 = 0;
								int.TryParse(array4[0], out num5);
								int.TryParse(array4[1], out num6);
								for (int j = num4; j < Editor.editor_0.class297_0.int_14; j++)
								{
									Class304 class2 = Editor.editor_0.class297_0.list_3[j];
									if (class2.StartTime == num5 && Editor.editor_0.class297_0.class421_0.method_43(class2.Position, false) == num6)
									{
										Editor.editor_0.class371_0.Select(class2);
									}
								}
							}
						}
						else
						{
							List<int> list = new List<int>();
							string[] array5 = array2;
							for (int k = 0; k < array5.Length; k++)
							{
								string s = array5[k];
								list.Add(int.Parse(s));
							}
							if (list.Count == 1)
							{
								Editor.editor_0.class371_0.Select(Editor.editor_0.class297_0.list_3[num4]);
							}
							else
							{
								for (int l = num4; l < Editor.editor_0.class297_0.int_14; l++)
								{
									if (Editor.editor_0.class297_0.list_3[l].ComboNumber == list[0])
									{
										Editor.editor_0.class371_0.Select(Editor.editor_0.class297_0.list_3[l]);
										list.RemoveAt(0);
									}
									if (list.Count == 0)
									{
										break;
									}
								}
							}
						}
					}
					catch (Exception)
					{
						Class723.smethod_4(Class41.GetString(OsuString.Editor_FileOperations_InvalidFormat));
						bool result = false;
						return result;
					}
					return true;
				}
			}
			Class723.smethod_4(Class41.GetString(OsuString.Editor_FileOperations_LoadSelectionRequirement));
			return false;
		}

		// Token: 0x0600266A RID: 9834
		// RVA: 0x0001DCF2 File Offset: 0x0001BEF2
		internal static bool smethod_1()
		{
			return Class331.smethod_14().Count > 0;
		}

		// Token: 0x060026BD RID: 9917
		// RVA: 0x0001E090 File Offset: 0x0001C290
		[CompilerGenerated]
		private static bool smethod_10(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.MovementX;
		}

		// Token: 0x060026BE RID: 9918
		// RVA: 0x0001E090 File Offset: 0x0001C290
		[CompilerGenerated]
		private static bool smethod_11(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.MovementX;
		}

		// Token: 0x060026C0 RID: 9920
		// RVA: 0x0001E0A8 File Offset: 0x0001C2A8
		[CompilerGenerated]
		private static void smethod_12(Class304 class304_0)
		{
			class304_0.vmethod_18();
		}

		// Token: 0x060026C1 RID: 9921
		// RVA: 0x0001E0B0 File Offset: 0x0001C2B0
		[CompilerGenerated]
		private static bool smethod_13(Class296 class296_0)
		{
			return !class296_0.bool_2 && class296_0.method_0();
		}

		// Token: 0x060026C2 RID: 9922
		// RVA: 0x0001E0C2 File Offset: 0x0001C2C2
		[CompilerGenerated]
		private static bool smethod_14(Class296 class296_0)
		{
			return class296_0.bool_2;
		}

		// Token: 0x060026C3 RID: 9923
		// RVA: 0x0001AC9B File Offset: 0x00018E9B
		[CompilerGenerated]
		private static void smethod_15(Class296 class296_0)
		{
			Class466.Remove(class296_0);
		}

		// Token: 0x0600267C RID: 9852
		// RVA: 0x0001DDBD File Offset: 0x0001BFBD
		internal static bool smethod_2()
		{
			return Editor.bool_13;
		}

		// Token: 0x0600267D RID: 9853
		// RVA: 0x000E8E64 File Offset: 0x000E7064
		internal static void smethod_3(bool bool_18)
		{
			if (Editor.bool_13 == bool_18)
			{
				return;
			}
			Editor.bool_13 = bool_18;
			if (Editor.smethod_2() && !Class331.smethod_79())
			{
				Class331.smethod_88();
			}
			Class115.editorControl_0.Enabled = !bool_18;
			Editor.editor_0.class370_0.vmethod_1(!bool_18);
			Editor.editor_0.class911_1.bool_6 = !bool_18;
			Editor.editor_0.class911_2.bool_6 = !bool_18;
			Editor.editor_0.class911_3.bool_6 = !bool_18;
		}

		// Token: 0x06002694 RID: 9876
		// RVA: 0x000EA270 File Offset: 0x000E8470
		private static string smethod_4()
		{
			int num = Class341.class608_4 % 34;
			Class341.class608_4.Value = (num + 1) % 34;
			return Class41.GetString(OsuString.EditorTip_1 + num);
		}

		// Token: 0x060026B7 RID: 9911
		// RVA: 0x0001E06B File Offset: 0x0001C26B
		[CompilerGenerated]
		private static bool smethod_5(Class304 class304_0)
		{
			return class304_0.EndTime > Class331.int_7;
		}

		// Token: 0x060026B9 RID: 9913
		// RVA: 0x0001E07A File Offset: 0x0001C27A
		[CompilerGenerated]
		private static bool smethod_6(Class702 class702_0)
		{
			return class702_0 is Class707;
		}

		// Token: 0x060026BA RID: 9914
		// RVA: 0x0001E085 File Offset: 0x0001C285
		[CompilerGenerated]
		private static bool smethod_7(Class702 class702_0)
		{
			return class702_0.eventTypes_0 == EventTypes.Sprite;
		}

		// Token: 0x060026BB RID: 9915
		// RVA: 0x0001E090 File Offset: 0x0001C290
		[CompilerGenerated]
		private static bool smethod_8(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.MovementX;
		}

		// Token: 0x060026BC RID: 9916
		// RVA: 0x0001E090 File Offset: 0x0001C290
		[CompilerGenerated]
		private static bool smethod_9(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.MovementX;
		}
	}
}
