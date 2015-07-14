using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns10;
using ns14;
using ns24;
using ns26;
using ns27;
using ns29;
using ns6;
using ns77;
using ns79;
using ns8;
using ns80;
using ns81;
using ns82;
using ns89;
using ns90;
using ns94;
using osu.GameModes.Edit;
using osu.GameplayElements.Events;
using osu.Graphics.Primitives;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns68
{
	// Token: 0x020004C9 RID: 1225
	internal sealed class Class376 : Class370
	{
		// Token: 0x020004CA RID: 1226
		[CompilerGenerated]
		private sealed class Class635
		{
			// Token: 0x040020DC RID: 8412
			public Class376 class376_0;

			// Token: 0x040020DB RID: 8411
			public Class533 class533_0;

			// Token: 0x040020DA RID: 8410
			public StoryLayer storyLayer_0;

			// Token: 0x060027A3 RID: 10147
			// RVA: 0x0001E873 File Offset: 0x0001CA73
			public void method_0(object sender, EventArgs e)
			{
				if (this.class376_0.class702_1 != null)
				{
					this.class533_0.bool_16 = true;
					this.class533_0.bool_18 = true;
				}
			}

			// Token: 0x060027A4 RID: 10148
			// RVA: 0x0001E89A File Offset: 0x0001CA9A
			public void method_1(object sender, EventArgs e)
			{
				this.class533_0.bool_16 = false;
				this.class533_0.bool_18 = true;
			}

			// Token: 0x060027A5 RID: 10149
			// RVA: 0x0001E8B4 File Offset: 0x0001CAB4
			public void method_2(object sender, EventArgs e)
			{
				if (this.class376_0.class702_1 != null)
				{
					this.class376_0.method_26(this.class376_0.class702_1, this.storyLayer_0);
					return;
				}
				this.class376_0.method_19(this.storyLayer_0);
			}
		}

		// Token: 0x020004CB RID: 1227
		[CompilerGenerated]
		private sealed class Class636
		{
			// Token: 0x040020DE RID: 8414
			public Class533 class533_0;

			// Token: 0x040020DD RID: 8413
			public Class376.Class635 class635_0;

			// Token: 0x040020DF RID: 8415
			public Class702 class702_0;

			// Token: 0x060027A7 RID: 10151
			// RVA: 0x0001E8F1 File Offset: 0x0001CAF1
			public void method_0(object sender, EventArgs e)
			{
				this.class533_0.method_53(new Color(92, 92, 92));
				this.class533_0.bool_18 = true;
			}

			// Token: 0x060027A8 RID: 10152
			// RVA: 0x0001E915 File Offset: 0x0001CB15
			public void method_1(object sender, EventArgs e)
			{
				this.class533_0.method_53(Color.get_TransparentWhite());
				this.class533_0.bool_18 = true;
			}

			// Token: 0x060027A9 RID: 10153
			// RVA: 0x000F697C File Offset: 0x000F4B7C
			public void method_2(object sender, EventArgs e)
			{
				if (this.class635_0.class376_0.editor_0.enum105_0 != Enum105.const_2)
				{
					return;
				}
				if ((!this.class702_0.class531_0.bool_3 || Class800.bool_0) && this.class702_0.class531_0.class26_0.Count > 0)
				{
					Class331.smethod_70(this.class702_0.class531_0.class26_0[0].int_0, false, false);
				}
				this.class635_0.class376_0.method_29(this.class702_0, false);
			}
		}

		// Token: 0x020004CC RID: 1228
		[CompilerGenerated]
		private sealed class Class637
		{
			// Token: 0x040020E0 RID: 8416
			public Class746 class746_0;

			// Token: 0x060027AB RID: 10155
			// RVA: 0x0001E933 File Offset: 0x0001CB33
			public bool method_0(Class746 class746_1)
			{
				return class746_1.int_0 == this.class746_0.int_1;
			}

			// Token: 0x060027AC RID: 10156
			// RVA: 0x0001E948 File Offset: 0x0001CB48
			public bool method_1(Class746 class746_1)
			{
				return class746_1.int_1 == this.class746_0.int_0;
			}
		}

		// Token: 0x020004CD RID: 1229
		[CompilerGenerated]
		private sealed class Class638
		{
			// Token: 0x040020E2 RID: 8418
			public Class376 class376_0;

			// Token: 0x040020E1 RID: 8417
			public Class94 class94_0;

			// Token: 0x060027AE RID: 10158
			// RVA: 0x000F6A0C File Offset: 0x000F4C0C
			public void method_0(object sender, EventArgs e)
			{
				if (this.class94_0.string_0 != null)
				{
					Class702 class;
					if (this.class94_0.bool_6)
					{
						class = new Class703(this.class94_0.string_0, new Vector2(320f, 240f), Origins.Centre, StoryLayer.Foreground, this.class94_0.int_3, this.class94_0.double_0, false, LoopTypes.LoopForever);
					}
					else
					{
						class = new Class706(this.class94_0.string_0, new Vector2(320f, 240f), Origins.Centre, StoryLayer.Foreground, false);
					}
					this.class376_0.class872_0.Add(class);
					this.class376_0.method_29(class, true);
					Class746 class2;
					this.class376_0.method_2(Class331.int_7, ref class2, true);
					this.class376_0.bool_2 = true;
				}
			}
		}

		// Token: 0x020004CE RID: 1230
		[CompilerGenerated]
		private sealed class Class639
		{
			// Token: 0x040020E3 RID: 8419
			public TransformationType transformationType_0;

			// Token: 0x060027B0 RID: 10160
			// RVA: 0x0001E95D File Offset: 0x0001CB5D
			public bool method_0(Class746 class746_0)
			{
				return class746_0.transformationType_0 == this.transformationType_0;
			}
		}

		// Token: 0x04002096 RID: 8342
		private bool bool_2 = true;

		// Token: 0x04002097 RID: 8343
		private bool bool_3;

		// Token: 0x040020AF RID: 8367
		private bool bool_4;

		// Token: 0x040020B0 RID: 8368
		private bool bool_5;

		// Token: 0x040020BC RID: 8380
		private bool bool_6;

		// Token: 0x040020C3 RID: 8387
		public bool bool_7;

		// Token: 0x04002091 RID: 8337
		private Class110 class110_0 = new Class110(new Rectangle(Class115.smethod_43() - 66, 80, 66, 290), Vector2.get_Zero(), true, 0f, Enum98.const_2)
		{
			bool_4 = false
		};

		// Token: 0x04002094 RID: 8340
		private Class531 class531_0;

		// Token: 0x04002098 RID: 8344
		private Class533 class533_0;

		// Token: 0x04002099 RID: 8345
		private Class533 class533_1;

		// Token: 0x0400209A RID: 8346
		private Class533 class533_2;

		// Token: 0x040020C6 RID: 8390
		private Class533 class533_3;

		// Token: 0x040020C7 RID: 8391
		private Class533 class533_4;

		// Token: 0x040020BA RID: 8378
		private Class702 class702_0;

		// Token: 0x040020BE RID: 8382
		internal Class702 class702_1;

		// Token: 0x040020BF RID: 8383
		private Class702 class702_2;

		// Token: 0x040020C8 RID: 8392
		private Class702 class702_3;

		// Token: 0x0400209C RID: 8348
		private Class762 class762_0;

		// Token: 0x0400209D RID: 8349
		private Class762 class762_1;

		// Token: 0x040020A6 RID: 8358
		private Class762 class762_10;

		// Token: 0x040020A7 RID: 8359
		private Class762 class762_11;

		// Token: 0x040020A8 RID: 8360
		private Class762 class762_12;

		// Token: 0x040020A9 RID: 8361
		private Class762 class762_13;

		// Token: 0x040020AA RID: 8362
		private Class762 class762_14;

		// Token: 0x040020AB RID: 8363
		private Class762 class762_15;

		// Token: 0x040020AC RID: 8364
		private Class762 class762_16;

		// Token: 0x040020AD RID: 8365
		private Class762 class762_17;

		// Token: 0x040020AE RID: 8366
		private Class762 class762_18;

		// Token: 0x0400209E RID: 8350
		private Class762 class762_2;

		// Token: 0x0400209F RID: 8351
		private Class762 class762_3;

		// Token: 0x040020A0 RID: 8352
		private Class762 class762_4;

		// Token: 0x040020A1 RID: 8353
		private Class762 class762_5;

		// Token: 0x040020A2 RID: 8354
		private Class762 class762_6;

		// Token: 0x040020A3 RID: 8355
		private Class762 class762_7;

		// Token: 0x040020A4 RID: 8356
		private Class762 class762_8;

		// Token: 0x040020A5 RID: 8357
		private Class762 class762_9;

		// Token: 0x040020B9 RID: 8377
		private Class872 class872_0;

		// Token: 0x040020C9 RID: 8393
		private Class883 class883_0;

		// Token: 0x0400209B RID: 8347
		private Class911 class911_1;

		// Token: 0x04002092 RID: 8338
		private readonly Dictionary<Class702, Class533> dictionary_0 = new Dictionary<Class702, Class533>();

		// Token: 0x040020B1 RID: 8369
		private Enum70 enum70_0;

		// Token: 0x04002093 RID: 8339
		private float float_0;

		// Token: 0x040020B7 RID: 8375
		private float float_1;

		// Token: 0x040020B8 RID: 8376
		private float float_2;

		// Token: 0x040020C1 RID: 8385
		internal int int_0;

		// Token: 0x040020C2 RID: 8386
		private int int_1;

		// Token: 0x040020C5 RID: 8389
		private int int_2;

		// Token: 0x040020BB RID: 8379
		private List<Class702> list_0 = new List<Class702>();

		// Token: 0x040020C0 RID: 8384
		private List<Class746> list_1;

		// Token: 0x040020C4 RID: 8388
		private List<Class702> list_2;

		// Token: 0x040020B2 RID: 8370
		private Origins origins_0;

		// Token: 0x040020CA RID: 8394
		[CompilerGenerated]
		private static Predicate<Class530> predicate_0;

		// Token: 0x040020CB RID: 8395
		[CompilerGenerated]
		private static Predicate<Class746> predicate_1;

		// Token: 0x040020D4 RID: 8404
		[CompilerGenerated]
		private static Predicate<Class746> predicate_10;

		// Token: 0x040020D5 RID: 8405
		[CompilerGenerated]
		private static Predicate<Class746> predicate_11;

		// Token: 0x040020D6 RID: 8406
		[CompilerGenerated]
		private static Predicate<Class746> predicate_12;

		// Token: 0x040020D7 RID: 8407
		[CompilerGenerated]
		private static Predicate<Class746> predicate_13;

		// Token: 0x040020D8 RID: 8408
		[CompilerGenerated]
		private static Predicate<Class702> predicate_14;

		// Token: 0x040020D9 RID: 8409
		[CompilerGenerated]
		private static Predicate<Class530> predicate_15;

		// Token: 0x040020CC RID: 8396
		[CompilerGenerated]
		private static Predicate<Class746> predicate_2;

		// Token: 0x040020CD RID: 8397
		[CompilerGenerated]
		private static Predicate<Class746> predicate_3;

		// Token: 0x040020CE RID: 8398
		[CompilerGenerated]
		private static Predicate<Class746> predicate_4;

		// Token: 0x040020CF RID: 8399
		[CompilerGenerated]
		private static Predicate<Class746> predicate_5;

		// Token: 0x040020D0 RID: 8400
		[CompilerGenerated]
		private static Predicate<Class746> predicate_6;

		// Token: 0x040020D1 RID: 8401
		[CompilerGenerated]
		private static Predicate<Class746> predicate_7;

		// Token: 0x040020D2 RID: 8402
		[CompilerGenerated]
		private static Predicate<Class746> predicate_8;

		// Token: 0x040020D3 RID: 8403
		[CompilerGenerated]
		private static Predicate<Class746> predicate_9;

		// Token: 0x040020B3 RID: 8371
		private TransformationType transformationType_0;

		// Token: 0x040020B4 RID: 8372
		private TransformationType transformationType_1;

		// Token: 0x04002095 RID: 8341
		private Vector2 vector2_0;

		// Token: 0x040020B5 RID: 8373
		private Vector2 vector2_1;

		// Token: 0x040020B6 RID: 8374
		private Vector2 vector2_2;

		// Token: 0x040020BD RID: 8381
		private Vector2 vector2_3;

		// Token: 0x06002748 RID: 10056
		// RVA: 0x000F2FB0 File Offset: 0x000F11B0
		public Class376(Editor editor_1) : base(editor_1)
		{
		}

		// Token: 0x06002771 RID: 10097
		// RVA: 0x0001E5F2 File Offset: 0x0001C7F2
		internal override void Dispose()
		{
			if (this.class911_1 != null)
			{
				this.class911_1.Dispose();
			}
			if (this.class110_0 != null)
			{
				this.class110_0.Dispose();
			}
			base.Dispose();
		}

		// Token: 0x0600276F RID: 10095
		// RVA: 0x000F6524 File Offset: 0x000F4724
		internal override void Draw()
		{
			if (this.class702_0 != null)
			{
				foreach (Class702 current in this.list_0)
				{
					if (current != this.class702_1)
					{
						this.method_30(current, Color.get_Silver());
					}
				}
				this.method_30(this.class702_0, (this.class702_0 == this.class702_1) ? Color.get_White() : Color.get_Silver());
			}
			this.method_0();
			if (this.class702_1 != null && this.class702_0 != this.class702_1)
			{
				this.method_30(this.class702_1, Color.get_White());
			}
			this.class911_1.Draw();
			base.Draw();
		}

		// Token: 0x0600273E RID: 10046
		// RVA: 0x0001E4E3 File Offset: 0x0001C6E3
		private void method_0()
		{
			this.class110_0.Draw();
		}

		// Token: 0x0600273F RID: 10047
		// RVA: 0x000F1DD0 File Offset: 0x000EFFD0
		private void method_1()
		{
			this.class110_0.imethod_2();
			if (this.class531_0 != null)
			{
				this.class531_0.vector2_1 = this.class531_0.vector2_0 + (Class800.smethod_19() - this.vector2_0) / Class115.float_4;
				List<Class530> arg_78_0 = this.class110_0.class911_0.list_2;
				if (Class376.predicate_0 == null)
				{
					Class376.predicate_0 = new Predicate<Class530>(Class376.smethod_1);
				}
				using (List<Class530>.Enumerator enumerator = arg_78_0.FindAll(Class376.predicate_0).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class531 class = (Class531)enumerator.Current;
						Class533 class2 = class as Class533;
						if (this.class531_0 != class && (class2 == null || !(class2.Text == "Background")))
						{
							if (class.vector2_0.Y > this.class531_0.vector2_1.Y - this.float_0 / 2f)
							{
								if (class.vector2_1 == class.vector2_0)
								{
									class.method_18(class.vector2_0 + new Vector2(0f, this.float_0), 80);
								}
							}
							else if (class.vector2_0.Y < this.class531_0.vector2_1.Y && class.vector2_1 != class.vector2_0)
							{
								class.method_18(class.vector2_0, 80);
							}
						}
					}
				}
			}
			if (this.bool_2)
			{
				this.class110_0.method_29(true);
				this.dictionary_0.Clear();
				float num = 0f;
				float num2 = 0.5f;
				float num3 = Class611.smethod_0(Class115.form_0, false) / 96f;
				for (int i = 0; i < this.class872_0.list_3.Length; i++)
				{
					Class376.Class635 class3 = new Class376.Class635();
					class3.class376_0 = this;
					bool flag = this.class872_0.bool_9[i];
					List<Class702> list = this.class872_0.list_3[i];
					class3.storyLayer_0 = (StoryLayer)i;
					class3.class533_0 = new Class533(class3.storyLayer_0.ToString(), 8f * num3, new Vector2(0f, num), num2, true, flag ? Color.get_Orange() : Color.get_LightGray());
					class3.class533_0.bool_17 = false;
					class3.class533_0.bool_15 = false;
					class3.class533_0.method_58(true);
					class3.class533_0.int_0 = 1;
					class3.class533_0.bool_1 = true;
					class3.class533_0.method_35(new EventHandler(class3.method_0));
					class3.class533_0.method_37(new EventHandler(class3.method_1));
					class3.class533_0.method_2(new EventHandler(class3.method_2));
					this.class110_0.class911_0.Add(class3.class533_0);
					if (this.float_0 == 0f)
					{
						this.float_0 = (class3.class533_0.vmethod_11().Y + 4f * num3) / Class115.float_4;
					}
					num += this.float_0;
					num2 += 0.0001f;
					if (flag)
					{
						foreach (Class702 current in list)
						{
							Class376.Class636 class4 = new Class376.Class636();
							class4.class635_0 = class3;
							if (current.class531_0 != null)
							{
								class4.class533_0 = new Class533((current.string_0.Length >= 4) ? current.string_0.Remove(current.string_0.Length - 4) : (current.string_0 + " "), 8f * num3, new Vector2(2f, num), num2, true, Color.get_White());
								class4.class533_0.bool_17 = false;
								class4.class533_0.bool_15 = false;
								class4.class533_0.bool_1 = true;
								class4.class533_0.method_58(true);
								class4.class533_0.object_0 = current;
								class4.class533_0.int_0 = 2;
								class4.class533_0.method_35(new EventHandler(class4.method_0));
								class4.class533_0.method_37(new EventHandler(class4.method_1));
								if (current == this.class702_1)
								{
									class4.class533_0.bool_16 = true;
									class4.class533_0.bool_19 = true;
								}
								class4.class702_0 = current;
								class4.class533_0.method_2(new EventHandler(class4.method_2));
								this.class110_0.class911_0.Add(class4.class533_0);
								num += (class4.class533_0.vmethod_11().Y + 4f * num3) / Class115.float_4;
								this.dictionary_0.Add(current, class4.class533_0);
								num2 += 0.0001f;
							}
						}
					}
				}
				this.class110_0.method_14(new Vector2(66f, num));
				this.bool_2 = false;
			}
		}

		// Token: 0x0600274F RID: 10063
		// RVA: 0x000F3A00 File Offset: 0x000F1C00
		private void method_10(bool bool_8)
		{
			if (this.int_2 == 0 && !bool_8)
			{
				this.int_2 = 1;
				this.class533_3.Text = "Scale\nFade\nRotation\nColour";
				return;
			}
			if (this.int_2 == 1 && bool_8)
			{
				this.int_2 = 0;
				this.class533_3.Text = "Movement\nScale\nFade\nRotation";
			}
		}

		// Token: 0x06002750 RID: 10064
		// RVA: 0x000F3A54 File Offset: 0x000F1C54
		private void method_11()
		{
			Class533 class = new Class533(Class41.GetString(OsuString.EditorModeDesign_LayerToggles), 10f, new Vector2(0f, 80f), 1f, true, Color.get_White());
			class.bool_16 = true;
			class.method_58(true);
			this.class911_0.Add(class);
			this.class762_2 = new Class762(Class41.GetString(OsuString.General_Background), 0.7f, new Vector2(2f, 95f), 1f, true, 0f);
			this.class911_0.Add<Class531>(this.class762_2.list_0);
			this.class762_2.method_8(new Delegate38(this.method_39));
			this.class762_3 = new Class762(Class41.GetString(OsuString.Editor_Design_Failing), 0.7f, new Vector2(2f, 110f), 1f, true, 0f);
			this.class911_0.Add<Class531>(this.class762_3.list_0);
			this.class762_3.method_8(new Delegate38(this.method_40));
			this.class762_5 = new Class762(Class41.GetString(OsuString.Editor_Design_Passing), 0.7f, new Vector2(2f, 125f), 1f, true, 0f);
			this.class911_0.Add<Class531>(this.class762_5.list_0);
			this.class762_5.method_8(new Delegate38(this.method_41));
			this.class762_4 = new Class762(Class41.GetString(OsuString.General_Foreground), 0.7f, new Vector2(2f, 140f), 1f, true, 0f);
			this.class911_0.Add<Class531>(this.class762_4.list_0);
			this.class762_4.method_8(new Delegate38(this.method_42));
			this.class762_1 = new Class762(Class41.GetString(OsuString.Editor_Design_HitObjects), 0.7f, new Vector2(2f, 155f), 1f, false, 0f);
			this.class911_0.Add<Class531>(this.class762_1.list_0);
			this.class762_1.method_8(new Delegate38(this.method_43));
			class = new Class533(Class41.GetString(OsuString.Editor_Design_Transformation), 10f, new Vector2(0f, 185f), 1f, true, Color.get_White());
			class.bool_16 = true;
			class.method_58(true);
			this.class911_0.Add(class);
			this.transformationType_0 = TransformationType.Movement;
			this.class762_11 = new Class762(Class41.GetString(OsuString.General_Move), 0.7f, new Vector2(2f, 200f), 1f, true, 0f);
			this.class911_0.Add<Class531>(this.class762_11.list_0);
			this.class762_11.method_8(new Delegate38(this.method_44));
			this.class762_13 = new Class762(Class41.GetString(OsuString.General_Scale), 0.7f, new Vector2(2f, 215f), 1f, false, 0f);
			this.class911_0.Add<Class531>(this.class762_13.list_0);
			this.class762_13.method_8(new Delegate38(this.method_45));
			this.class762_8 = new Class762(Class41.GetString(OsuString.General_Fade), 0.7f, new Vector2(2f, 230f), 1f, false, 0f);
			this.class911_0.Add<Class531>(this.class762_8.list_0);
			this.class762_8.method_8(new Delegate38(this.method_46));
			this.class762_12 = new Class762(Class41.GetString(OsuString.General_Rotate), 0.7f, new Vector2(2f, 245f), 1f, false, 0f);
			this.class911_0.Add<Class531>(this.class762_12.list_0);
			this.class762_12.method_8(new Delegate38(this.method_47));
			this.class762_15 = new Class762(Class41.GetString(OsuString.General_Colour), 0.7f, new Vector2(2f, 260f), 1f, false, 0f);
			this.class911_0.Add<Class531>(this.class762_15.list_0);
			this.class762_15.method_8(new Delegate38(this.method_48));
			class = new Class533(Class41.GetString(OsuString.Editor_Design_Tweening), 10f, new Vector2(0f, 275f), 1f, true, Color.get_White());
			class.bool_16 = true;
			class.method_58(true);
			this.class911_0.Add(class);
			this.class762_18 = new Class762(Class41.GetString(OsuString.General_Enabled), 0.7f, new Vector2(2f, 290f), 1f, false, 0f);
			this.class911_0.Add<Class531>(this.class762_18.list_0);
			this.class762_18.method_8(new Delegate38(this.method_49));
			class = new Class533(Class41.GetString(OsuString.Editor_Design_Easing), 10f, new Vector2(0f, 305f), 1f, true, Color.get_White());
			class.bool_16 = true;
			class.method_58(true);
			this.class911_0.Add(class);
			this.class762_16 = new Class762(Class41.GetString(OsuString.General_In), 0.7f, new Vector2(2f, 320f), 1f, false, 0f);
			this.class911_0.Add<Class531>(this.class762_16.list_0);
			this.class762_16.method_8(new Delegate38(this.method_50));
			this.class762_17 = new Class762(Class41.GetString(OsuString.General_Out), 0.7f, new Vector2(2f, 335f), 1f, false, 0f);
			this.class911_0.Add<Class531>(this.class762_17.list_0);
			this.class762_17.method_8(new Delegate38(this.method_51));
			class = new Class533(Class41.GetString(OsuString.General_Origin), 10f, new Vector2(0f, 365f), 1f, true, Color.get_White());
			class.bool_16 = true;
			class.method_58(true);
			this.class911_0.Add(class);
			this.class762_7 = new Class762(Class41.GetString(OsuString.General_TopLeft), 0.7f, new Vector2(2f, 380f), 1f, true, 0f);
			this.class762_7.method_8(new Delegate38(this.method_52));
			this.class911_0.Add<Class531>(this.class762_7.list_0);
			this.class762_6 = new Class762(Class41.GetString(OsuString.General_Centre), 0.7f, new Vector2(2f, 395f), 1f, false, 0f);
			this.class762_6.method_8(new Delegate38(this.method_53));
			this.class911_0.Add<Class531>(this.class762_6.list_0);
			class = new Class533(Class41.GetString(OsuString.General_Advanced), 10f, new Vector2(0f, 425f), 1f, true, Color.get_White());
			class.bool_16 = true;
			class.method_58(true);
			this.class911_0.Add(class);
			this.class762_0 = new Class762(Class41.GetString(OsuString.Editor_Design_DiffSpecific), 0.7f, new Vector2(2f, 440f), 1f, false, 0f);
			this.class911_0.Add<Class531>(this.class762_0.list_0);
			this.class762_0.method_8(new Delegate38(this.method_54));
		}

		// Token: 0x06002751 RID: 10065
		// RVA: 0x000F4230 File Offset: 0x000F2430
		private void method_12()
		{
			Class531 class = new Class531(Class115.class731_0, new Vector2(0f, 66f), 0f, true, new Color(0, 0, 0, 130));
			class.float_2 = 1.6f;
			class.vector2_2 = new Vector2(160f, 396f);
			this.class911_1.Add(class);
			this.class762_14 = new Class762(Class41.GetString(OsuString.Editor_Design_VectorScale), 0.7f, new Vector2(72f, 215f), 1f, false, 0f);
			this.class911_1.Add<Class531>(this.class762_14.list_0);
			this.class762_14.method_8(new Delegate38(this.method_55));
			this.class762_9 = new Class762(Class41.GetString(OsuString.Editor_Design_HorizontalFlip), 0.7f, new Vector2(72f, 230f), 1f, false, 0f);
			this.class911_1.Add<Class531>(this.class762_9.list_0);
			this.class762_9.method_8(new Delegate38(this.method_56));
			this.class762_10 = new Class762(Class41.GetString(OsuString.Editor_Design_VerticalFlip), 0.7f, new Vector2(72f, 245f), 1f, false, 0f);
			this.class911_1.Add<Class531>(this.class762_10.list_0);
			this.class762_10.method_8(new Delegate38(this.method_57));
		}

		// Token: 0x06002752 RID: 10066
		// RVA: 0x0001E516 File Offset: 0x0001C716
		private void method_13(object sender, EventArgs e)
		{
			this.method_14();
		}

		// Token: 0x06002753 RID: 10067
		// RVA: 0x000F43BC File Offset: 0x000F25BC
		private void method_14()
		{
			Class376.Class638 class = new Class376.Class638();
			class.class376_0 = this;
			class.class94_0 = new Class94();
			class.class94_0.method_2(new EventHandler(class.method_0));
			Class115.smethod_37(class.class94_0);
		}

		// Token: 0x06002754 RID: 10068
		// RVA: 0x0001E51E File Offset: 0x0001C71E
		private void method_15(bool bool_8)
		{
			if (this.bool_4 == bool_8)
			{
				return;
			}
			this.class762_0.method_6(bool_8);
			this.bool_4 = bool_8;
			if (this.class702_1 != null)
			{
				this.class702_1.bool_2 = bool_8;
			}
		}

		// Token: 0x06002755 RID: 10069
		// RVA: 0x000F4404 File Offset: 0x000F2604
		private void method_16(Origins origins_1)
		{
			if (this.origins_0 == origins_1)
			{
				return;
			}
			this.origins_0 = origins_1;
			this.class762_7.method_6(origins_1 == Origins.TopLeft);
			this.class762_6.method_6(origins_1 == Origins.Centre);
			if (this.class702_1 != null)
			{
				this.editor_0.method_16(false);
				this.class702_1.class531_0.origins_0 = origins_1;
				this.class702_1.class531_0.vmethod_9();
			}
		}

		// Token: 0x06002756 RID: 10070
		// RVA: 0x000F4478 File Offset: 0x000F2678
		private void method_17(TransformationType transformationType_2, bool bool_8)
		{
			Predicate<Class746> predicate = null;
			if (this.class702_1 != null)
			{
				TransformationType transformationType = this.transformationType_0;
				this.transformationType_0 = transformationType_2;
				List<Class746> arg_3A_0 = this.class702_1.class531_0.class26_0;
				if (predicate == null)
				{
					predicate = new Predicate<Class746>(this.method_58);
				}
				this.list_1 = arg_3A_0.FindAll(predicate);
				Class746 item;
				this.method_2(Class331.int_7, ref item, true);
				if (!bool_8)
				{
					this.class702_1.class531_0.class26_0.Remove(item);
				}
				this.transformationType_0 = transformationType;
			}
		}

		// Token: 0x06002757 RID: 10071
		// RVA: 0x000F44FC File Offset: 0x000F26FC
		private void method_18(TransformationType transformationType_2)
		{
			if (this.transformationType_0 == transformationType_2)
			{
				return;
			}
			this.class762_8.method_6(transformationType_2 == TransformationType.Fade);
			this.class762_13.method_6(transformationType_2 == TransformationType.Scale);
			this.class762_14.method_6(transformationType_2 == TransformationType.VectorScale);
			this.class762_11.method_6(transformationType_2 == TransformationType.Movement);
			this.class762_12.method_6(transformationType_2 == TransformationType.Rotation);
			this.class762_15.method_6(transformationType_2 == TransformationType.Colour);
			this.transformationType_0 = transformationType_2;
		}

		// Token: 0x06002758 RID: 10072
		// RVA: 0x000F457C File Offset: 0x000F277C
		internal void method_19(StoryLayer storyLayer_0)
		{
			this.class872_0.method_11(storyLayer_0);
			this.class762_2.method_6(this.class872_0.bool_9[0]);
			this.class762_4.method_6(this.class872_0.bool_9[3]);
			this.class762_3.method_6(this.class872_0.bool_9[1]);
			this.class762_5.method_6(this.class872_0.bool_9[2]);
			this.bool_2 = true;
		}

		// Token: 0x06002740 RID: 10048
		// RVA: 0x000F2348 File Offset: 0x000F0548
		private int method_2(int int_3, ref Class746 class746_0, bool bool_8)
		{
			Predicate<Class746> predicate = null;
			Predicate<Class746> predicate2 = null;
			Class376.Class637 class = new Class376.Class637();
			this.editor_0.bool_5 = true;
			int num = -1;
			class.class746_0 = null;
			class746_0 = null;
			if (this.class702_1 == null)
			{
				return num;
			}
			Class531 class2 = this.class702_1.class531_0;
			int i = this.list_1.Count - 1;
			while (i >= 0)
			{
				Class746 class3 = this.list_1[i];
				if (class3.int_1 == int_3)
				{
					class.class746_0 = class3;
					num = class2.class26_0.IndexOf(class3);
				}
				else if (class3.int_0 == int_3)
				{
					class.class746_0 = class3;
					num = class2.class26_0.IndexOf(class3);
				}
				else if (class3.int_0 == class3.int_1)
				{
					if (class3.int_1 > int_3)
					{
						class3.int_0 = int_3;
					}
					else
					{
						class3.int_1 = int_3;
					}
					class.class746_0 = class3;
					num = class2.class26_0.IndexOf(class3);
				}
				else if (class3.int_0 <= int_3 || i != 0)
				{
					if (i != this.list_1.Count - 1 || class3.int_1 >= Class331.int_7)
					{
						if (class3.int_1 > int_3)
						{
							if (class3.int_0 < int_3)
							{
								class.class746_0 = new Class746
								{
									int_0 = int_3,
									int_1 = class3.int_1,
									transformationType_0 = this.transformationType_0,
									vector2_1 = class3.vector2_1,
									float_1 = class3.float_1,
									color_1 = class3.color_1
								};
								class3.int_1 = int_3;
								num = class2.class26_0.IndexOf(class3) + 1;
								class2.class26_0.Insert(num, class.class746_0);
								break;
							}
							if (this.list_1[i - 1].int_1 < int_3)
							{
								num = class2.class26_0.IndexOf(class3);
								class.class746_0 = new Class746
								{
									int_0 = int_3,
									int_1 = class3.int_0,
									transformationType_0 = this.transformationType_0,
									vector2_1 = class3.vector2_0,
									float_1 = class3.float_0,
									color_1 = class3.color_0
								};
								class2.class26_0.Insert(num, class.class746_0);
								class.class746_0 = new Class746
								{
									int_0 = this.list_1[i - 1].int_1,
									int_1 = int_3,
									transformationType_0 = this.transformationType_0,
									vector2_0 = this.list_1[i - 1].vector2_1,
									float_0 = this.list_1[i - 1].float_1,
									color_0 = this.list_1[i - 1].color_1
								};
								class2.class26_0.Insert(num, class.class746_0);
								break;
							}
						}
						i--;
						continue;
					}
					class.class746_0 = new Class746
					{
						int_0 = class3.int_1,
						int_1 = int_3,
						transformationType_0 = this.transformationType_0,
						vector2_0 = class3.vector2_1,
						float_0 = class3.float_1,
						color_0 = class3.color_1
					};
					num = class2.class26_0.IndexOf(class3) + 1;
					class2.class26_0.Insert(num, class.class746_0);
				}
				else
				{
					class.class746_0 = new Class746
					{
						int_0 = int_3,
						int_1 = class3.int_0,
						transformationType_0 = this.transformationType_0,
						vector2_1 = class3.vector2_0,
						float_1 = class3.float_0,
						color_1 = class3.color_0
					};
					num = class2.class26_0.IndexOf(class3);
					class2.class26_0.Insert(num, class.class746_0);
				}
				IL_3FD:
				if (class.class746_0 == null)
				{
					if (!bool_8)
					{
						return -1;
					}
					class.class746_0 = new Class746
					{
						int_0 = int_3,
						int_1 = int_3,
						transformationType_0 = this.transformationType_0
					};
					class2.class26_0.Insert(0, class.class746_0);
				}
				bool flag = class.class746_0.int_0 == Class331.int_7;
				bool flag2 = class.class746_0.int_1 == Class331.int_7;
				if (flag && flag2)
				{
					this.method_24(class.class746_0);
					this.method_23(class.class746_0);
				}
				else if (flag2)
				{
					this.method_23(class.class746_0);
					List<Class746> arg_4C8_0 = this.list_1;
					if (predicate == null)
					{
						predicate = new Predicate<Class746>(class.method_0);
					}
					Class746 class4 = arg_4C8_0.Find(predicate);
					if (class4 != null)
					{
						this.method_24(class4);
					}
				}
				else if (flag)
				{
					this.method_24(class.class746_0);
					List<Class746> arg_509_0 = this.list_1;
					if (predicate2 == null)
					{
						predicate2 = new Predicate<Class746>(class.method_1);
					}
					Class746 class5 = arg_509_0.Find(predicate2);
					if (class5 != null)
					{
						this.method_23(class5);
					}
				}
				class746_0 = class.class746_0;
				return num;
			}
			goto IL_3FD;
		}

		// Token: 0x0600275A RID: 10074
		// RVA: 0x000F4E10 File Offset: 0x000F3010
		private void method_20()
		{
			if (!Class115.bool_13)
			{
				return;
			}
			if (!this.bool_6)
			{
				if (Class800.smethod_19().X < 40f * Class115.float_4 && this.vmethod_0())
				{
					this.class911_1.float_0 = Math.Min(1f, this.class911_1.float_0 + 0.08f);
					return;
				}
				if (Class800.smethod_19().X > 160f * Class115.float_4 || !this.vmethod_0())
				{
					this.class911_1.float_0 = Math.Max(0f, this.class911_1.float_0 - 0.08f);
					return;
				}
				if (this.class911_1.float_0 < 1f && this.class911_1.float_0 > 0.5f)
				{
					this.class911_1.float_0 = Math.Min(1f, this.class911_1.float_0 + 0.08f);
				}
			}
		}

		// Token: 0x0600275B RID: 10075
		// RVA: 0x000F4F08 File Offset: 0x000F3108
		private void method_21(Color color_0)
		{
			Class746 class = null;
			this.method_2(Class331.int_7, ref class, true);
			if (class == null)
			{
				return;
			}
			if (class.int_0 == Class331.int_7)
			{
				class.color_0 = color_0;
			}
			if (class.int_1 == Class331.int_7)
			{
				class.color_1 = color_0;
			}
			List<Class746> arg_60_0 = this.list_1;
			if (Class376.predicate_11 == null)
			{
				Class376.predicate_11 = new Predicate<Class746>(Class376.smethod_12);
			}
			Class746 class2 = arg_60_0.Find(Class376.predicate_11);
			if (class2 != null && class2 != class)
			{
				class2.color_1 = color_0;
			}
		}

		// Token: 0x0600275C RID: 10076
		// RVA: 0x000F4F8C File Offset: 0x000F318C
		private void method_22(float float_3, float float_4)
		{
			Predicate<Class746> predicate = null;
			Class376.Class639 class = new Class376.Class639();
			Class746 class2 = null;
			bool flag = false;
			class.transformationType_0 = TransformationType.None;
			if (this.transformationType_0 != TransformationType.Movement)
			{
				class.transformationType_0 = this.transformationType_0;
				this.transformationType_0 = TransformationType.Movement;
				List<Class746> arg_60_0 = this.class702_1.class531_0.class26_0;
				if (Class376.predicate_12 == null)
				{
					Class376.predicate_12 = new Predicate<Class746>(Class376.smethod_13);
				}
				this.list_1 = arg_60_0.FindAll(Class376.predicate_12);
			}
			this.method_2(Class331.int_7, ref class2, true);
			if (class2 == null)
			{
				return;
			}
			if (class2.int_0 == Class331.int_7)
			{
				Class746 expr_90_cp_0 = class2;
				expr_90_cp_0.vector2_0.X = expr_90_cp_0.vector2_0.X + float_3;
				Class746 expr_A3_cp_0 = class2;
				expr_A3_cp_0.vector2_0.Y = expr_A3_cp_0.vector2_0.Y + float_4;
			}
			if (class2.int_1 == Class331.int_7)
			{
				Class746 expr_C3_cp_0 = class2;
				expr_C3_cp_0.vector2_1.X = expr_C3_cp_0.vector2_1.X + float_3;
				Class746 expr_D6_cp_0 = class2;
				expr_D6_cp_0.vector2_1.Y = expr_D6_cp_0.vector2_1.Y + float_4;
			}
			List<Class746> arg_106_0 = this.list_1;
			if (Class376.predicate_13 == null)
			{
				Class376.predicate_13 = new Predicate<Class746>(Class376.smethod_14);
			}
			Class746 class3 = arg_106_0.Find(Class376.predicate_13);
			if (class3 != null && class3 != class2)
			{
				Class746 expr_119_cp_0 = class3;
				expr_119_cp_0.vector2_1.X = expr_119_cp_0.vector2_1.X + float_3;
				Class746 expr_12C_cp_0 = class3;
				expr_12C_cp_0.vector2_1.Y = expr_12C_cp_0.vector2_1.Y + float_4;
			}
			if (flag)
			{
				this.transformationType_0 = class.transformationType_0;
				List<Class746> arg_16C_0 = this.class702_1.class531_0.class26_0;
				if (predicate == null)
				{
					predicate = new Predicate<Class746>(class.method_0);
				}
				this.list_1 = arg_16C_0.FindAll(predicate);
			}
		}

		// Token: 0x0600275D RID: 10077
		// RVA: 0x000F5110 File Offset: 0x000F3310
		private void method_23(Class746 class746_0)
		{
			if (this.bool_6)
			{
				TransformationType transformationType = this.transformationType_0;
				switch (transformationType)
				{
				case TransformationType.Movement:
					class746_0.vector2_1 = this.vector2_3 + this.vector2_1;
					break;
				case TransformationType.Fade:
					class746_0.float_1 = Class778.smethod_2((this.float_1 * 200f + this.vector2_2.Y - this.vector2_3.Y) / 200f, 0f, 1f);
					break;
				case TransformationType.Movement | TransformationType.Fade:
					break;
				case TransformationType.Scale:
					class746_0.float_1 = Class778.smethod_2((this.float_1 * 100f + this.vector2_2.Y - this.vector2_3.Y) / 100f, 0.1f, 5f);
					break;
				default:
					if (transformationType != TransformationType.Rotation)
					{
						if (transformationType == TransformationType.VectorScale)
						{
							class746_0.vector2_1 = new Vector2(Class778.smethod_2((this.float_1 * 100f + this.vector2_2.X - this.vector2_3.X) / 100f, 0.1f, 5f), Class778.smethod_2((this.float_2 * 100f + this.vector2_2.Y - this.vector2_3.Y) / 100f, 0.1f, 5f));
						}
					}
					else
					{
						class746_0.float_1 = Class778.smethod_2((this.float_1 * 50f + this.vector2_2.Y - this.vector2_3.Y) / 50f, -50f, 50f);
					}
					break;
				}
			}
			else
			{
				TransformationType transformationType2 = this.transformationType_0;
				switch (transformationType2)
				{
				case TransformationType.Movement:
					class746_0.vector2_1 = this.class702_1.class531_0.vector2_1;
					break;
				case TransformationType.Fade:
					class746_0.float_1 = this.class702_1.class531_0.float_3;
					break;
				case TransformationType.Movement | TransformationType.Fade:
					break;
				case TransformationType.Scale:
					class746_0.float_1 = this.class702_1.class531_0.float_2;
					break;
				default:
					if (transformationType2 != TransformationType.Rotation)
					{
						if (transformationType2 == TransformationType.VectorScale)
						{
							class746_0.vector2_1 = this.class702_1.class531_0.vector2_2;
						}
					}
					else
					{
						class746_0.float_1 = this.class702_1.class531_0.float_1;
					}
					break;
				}
			}
			this.editor_0.bool_5 = true;
		}

		// Token: 0x0600275E RID: 10078
		// RVA: 0x000F5374 File Offset: 0x000F3574
		private void method_24(Class746 class746_0)
		{
			if (this.bool_6)
			{
				TransformationType transformationType = this.transformationType_0;
				switch (transformationType)
				{
				case TransformationType.Movement:
					class746_0.vector2_0 = this.vector2_3 + this.vector2_1;
					break;
				case TransformationType.Fade:
					class746_0.float_0 = Class778.smethod_2((this.float_1 * 200f + this.vector2_2.Y - this.vector2_3.Y) / 200f, 0f, 1f);
					break;
				case TransformationType.Movement | TransformationType.Fade:
					break;
				case TransformationType.Scale:
					class746_0.float_0 = Class778.smethod_2((this.float_1 * 100f + this.vector2_2.Y - this.vector2_3.Y) / 100f, 0.1f, 5f);
					break;
				default:
					if (transformationType != TransformationType.Rotation)
					{
						if (transformationType == TransformationType.VectorScale)
						{
							class746_0.vector2_0 = new Vector2(Class778.smethod_2((this.float_1 * 100f + this.vector2_2.X - this.vector2_3.X) / 100f, 0.1f, 5f), Class778.smethod_2((this.float_2 * 100f + this.vector2_2.Y - this.vector2_3.Y) / 100f, 0.1f, 5f));
						}
					}
					else
					{
						class746_0.float_0 = Class778.smethod_2((this.float_1 * 50f + this.vector2_2.Y - this.vector2_3.Y) / 50f, -50f, 50f);
					}
					break;
				}
			}
			else
			{
				TransformationType transformationType2 = this.transformationType_0;
				switch (transformationType2)
				{
				case TransformationType.Movement:
					class746_0.vector2_0 = this.class702_1.class531_0.vector2_1;
					break;
				case TransformationType.Fade:
					class746_0.float_0 = this.class702_1.class531_0.float_3;
					break;
				case TransformationType.Movement | TransformationType.Fade:
					break;
				case TransformationType.Scale:
					class746_0.float_0 = this.class702_1.class531_0.float_2;
					break;
				default:
					if (transformationType2 != TransformationType.Rotation)
					{
						if (transformationType2 == TransformationType.VectorScale)
						{
							class746_0.vector2_0 = this.class702_1.class531_0.vector2_2;
						}
					}
					else
					{
						class746_0.float_0 = this.class702_1.class531_0.float_1;
					}
					break;
				}
			}
			this.editor_0.bool_5 = true;
		}

		// Token: 0x06002762 RID: 10082
		// RVA: 0x000F56B0 File Offset: 0x000F38B0
		internal void method_25()
		{
			List<Class702> arg_28_0 = this.class872_0.list_1;
			if (Class376.predicate_14 == null)
			{
				Class376.predicate_14 = new Predicate<Class702>(Class376.smethod_15);
			}
			Class702 class = arg_28_0.Find(Class376.predicate_14);
			if (class != null)
			{
				this.class702_3 = class;
				if (this.class883_0 != null)
				{
					this.class883_0.SetValue((double)class.int_2, false);
				}
			}
		}

		// Token: 0x06002765 RID: 10085
		// RVA: 0x0001E58C File Offset: 0x0001C78C
		private void method_26(Class702 class702_4, StoryLayer storyLayer_0)
		{
			this.method_27(class702_4, storyLayer_0, -1);
		}

		// Token: 0x06002766 RID: 10086
		// RVA: 0x000F5C30 File Offset: 0x000F3E30
		private void method_27(Class702 class702_4, StoryLayer storyLayer_0, int int_3)
		{
			this.class872_0.Remove(class702_4);
			if (int_3 < 0)
			{
				this.class702_1.storyLayer_0 = storyLayer_0;
				this.class872_0.Add(class702_4);
			}
			else
			{
				this.class872_0.Add(class702_4, storyLayer_0, int_3);
			}
			if (!this.class872_0.bool_9[(int)storyLayer_0])
			{
				this.vmethod_17();
			}
			this.bool_2 = true;
		}

		// Token: 0x06002768 RID: 10088
		// RVA: 0x0001E597 File Offset: 0x0001C797
		private void method_28()
		{
			if (this.class702_1 != null)
			{
				this.editor_0.method_16(false);
				this.class872_0.Remove(this.class702_1);
				this.class702_1 = null;
				this.int_0 = -1;
				this.bool_2 = true;
			}
		}

		// Token: 0x0600276A RID: 10090
		// RVA: 0x000F5E10 File Offset: 0x000F4010
		private void method_29(Class702 class702_4, bool bool_8)
		{
			Class533 class;
			if (this.class702_1 != null && this.dictionary_0.TryGetValue(this.class702_1, out class))
			{
				class.bool_16 = false;
				class.bool_19 = false;
				class.bool_18 = true;
			}
			this.class702_1 = class702_4;
			if (bool_8)
			{
				this.vmethod_3();
			}
			if (class702_4 != null)
			{
				this.int_0 = this.list_2.IndexOf(this.class702_1);
			}
			else
			{
				this.int_0 = -1;
			}
			Class533 class2;
			if (this.class702_1 != null && this.dictionary_0.TryGetValue(this.class702_1, out class2))
			{
				class2.bool_16 = true;
				class2.bool_19 = true;
				class2.bool_18 = true;
			}
		}

		// Token: 0x06002741 RID: 10049
		// RVA: 0x000F287C File Offset: 0x000F0A7C
		private void method_3(int int_3)
		{
			if (this.class702_1 == null)
			{
				return;
			}
			this.editor_0.method_16(false);
			int num = -1;
			int num2 = -1;
			int i = 0;
			while (i < this.list_1.Count)
			{
				Class746 class = this.list_1[i];
				if (class.int_0 == int_3 && class.int_1 == int_3)
				{
					this.class702_1.class531_0.class26_0.Remove(class);
					return;
				}
				if (class.int_0 == int_3)
				{
					num2 = i;
					IL_82:
					if (num >= 0 && num2 >= 0)
					{
						Class746 class2 = this.list_1[num2];
						Class746 class3 = this.list_1[num];
						this.class702_1.class531_0.class26_0.Remove(class2);
						this.class702_1.class531_0.class26_0.Remove(class3);
						Class746 class4 = new Class746();
						class4.transformationType_0 = class3.transformationType_0;
						class4.vector2_1 = class2.vector2_1;
						class4.float_1 = class2.float_1;
						class4.color_1 = class2.color_1;
						class4.vector2_0 = class3.vector2_0;
						class4.float_0 = class3.float_0;
						class4.color_0 = class3.color_0;
						class4.int_0 = class3.int_0;
						class4.int_1 = class2.int_1;
						this.class702_1.class531_0.class26_0.Insert(num, class4);
						return;
					}
					if (num >= 0)
					{
						Class746 class5 = this.list_1[num];
						class5.int_1 = class5.int_0;
						class5.vector2_1 = class5.vector2_0;
						class5.float_1 = class5.float_0;
						class5.color_1 = class5.color_0;
					}
					if (num2 >= 0)
					{
						Class746 class6 = this.list_1[num2];
						class6.int_0 = class6.int_1;
						class6.vector2_0 = class6.vector2_1;
						class6.float_0 = class6.float_1;
						class6.color_0 = class6.color_1;
					}
					return;
				}
				else
				{
					if (class.int_1 == int_3)
					{
						num = i;
					}
					i++;
				}
			}
			goto IL_82;
		}

		// Token: 0x06002770 RID: 10096
		// RVA: 0x0001E5E3 File Offset: 0x0001C7E3
		private void method_30(Class702 class702_4, Color color_0)
		{
			class702_4.class531_0.method_32(color_0, 4);
		}

		// Token: 0x06002772 RID: 10098
		// RVA: 0x0001E620 File Offset: 0x0001C820
		public void method_31(bool bool_8)
		{
			this.bool_7 = bool_8;
			this.class297_0.class911_0.float_0 = (this.bool_7 ? 1f : 0.05f);
		}

		// Token: 0x06002774 RID: 10100
		// RVA: 0x000F66BC File Offset: 0x000F48BC
		internal void method_32(int int_3)
		{
			if (int_3 == 0)
			{
				return;
			}
			foreach (Class702 current in this.class872_0.list_1)
			{
				if (current is Class704 || current is Class706 || current is Class703 || current is Class707)
				{
					current.int_2 += int_3;
					current.int_0 += int_3;
					if (current.class531_0 != null)
					{
						foreach (Class746 current2 in current.class531_0.class26_0)
						{
							current2.int_0 += int_3;
							current2.int_1 += int_3;
						}
						if (current.class531_0.list_0 != null)
						{
							foreach (Class743 current3 in current.class531_0.list_0)
							{
								current3.int_1 += int_3;
							}
						}
					}
					foreach (List<Class744> current4 in current.dictionary_0.Values)
					{
						foreach (Class744 current5 in current4)
						{
							current5.int_1 += int_3;
							current5.int_3 += int_3;
							current5.int_2 += int_3;
						}
					}
				}
			}
		}

		// Token: 0x0600277D RID: 10109
		// RVA: 0x000F6904 File Offset: 0x000F4B04
		[CompilerGenerated]
		private void method_33(object sender, EventArgs e)
		{
			this.editor_0.method_16(false);
			if (this.transformationType_0 != TransformationType.Colour)
			{
				Class746 class;
				this.method_2(Class331.int_7, ref class, true);
				return;
			}
			ColorDialog colorDialog = new ColorDialog();
			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				this.method_21(new Color(colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B));
			}
		}

		// Token: 0x0600277E RID: 10110
		// RVA: 0x0001E6D3 File Offset: 0x0001C8D3
		[CompilerGenerated]
		private void method_34(object sender, EventArgs e)
		{
			this.method_3(Class331.int_7);
		}

		// Token: 0x0600277F RID: 10111
		// RVA: 0x0001E6E0 File Offset: 0x0001C8E0
		[CompilerGenerated]
		private void method_35(object sender, EventArgs e)
		{
			this.method_4();
		}

		// Token: 0x06002780 RID: 10112
		// RVA: 0x0001E6E8 File Offset: 0x0001C8E8
		[CompilerGenerated]
		private void method_36(object sender, EventArgs e)
		{
			this.method_5();
		}

		// Token: 0x06002781 RID: 10113
		// RVA: 0x0001E6F0 File Offset: 0x0001C8F0
		[CompilerGenerated]
		private void method_37(object sender, EventArgs e)
		{
			this.method_10(false);
		}

		// Token: 0x06002782 RID: 10114
		// RVA: 0x0001E6F9 File Offset: 0x0001C8F9
		[CompilerGenerated]
		private void method_38(object sender, EventArgs e)
		{
			this.method_10(true);
		}

		// Token: 0x06002783 RID: 10115
		// RVA: 0x0001E702 File Offset: 0x0001C902
		[CompilerGenerated]
		private void method_39(object object_0, bool bool_8)
		{
			this.method_19(StoryLayer.Background);
		}

		// Token: 0x06002742 RID: 10050
		// RVA: 0x000F2A98 File Offset: 0x000F0C98
		private void method_4()
		{
			if (this.class702_1 == null)
			{
				return;
			}
			List<Class746> arg_2C_0 = this.list_1;
			if (Class376.predicate_1 == null)
			{
				Class376.predicate_1 = new Predicate<Class746>(Class376.smethod_2);
			}
			Class746 class = arg_2C_0.FindLast(Class376.predicate_1);
			if (class == null)
			{
				return;
			}
			if (class.int_1 < Class331.int_7)
			{
				Class331.smethod_70(class.int_1, false, false);
				return;
			}
			if (class.int_0 < Class331.int_7)
			{
				Class331.smethod_70(class.int_0, false, false);
			}
		}

		// Token: 0x06002784 RID: 10116
		// RVA: 0x0001E70B File Offset: 0x0001C90B
		[CompilerGenerated]
		private void method_40(object object_0, bool bool_8)
		{
			this.method_19(StoryLayer.Fail);
		}

		// Token: 0x06002785 RID: 10117
		// RVA: 0x0001E714 File Offset: 0x0001C914
		[CompilerGenerated]
		private void method_41(object object_0, bool bool_8)
		{
			this.method_19(StoryLayer.Pass);
		}

		// Token: 0x06002786 RID: 10118
		// RVA: 0x0001E71D File Offset: 0x0001C91D
		[CompilerGenerated]
		private void method_42(object object_0, bool bool_8)
		{
			this.method_19(StoryLayer.Foreground);
		}

		// Token: 0x06002787 RID: 10119
		// RVA: 0x0001E726 File Offset: 0x0001C926
		[CompilerGenerated]
		private void method_43(object object_0, bool bool_8)
		{
			this.method_31(bool_8);
		}

		// Token: 0x06002788 RID: 10120
		// RVA: 0x0001E72F File Offset: 0x0001C92F
		[CompilerGenerated]
		private void method_44(object object_0, bool bool_8)
		{
			this.method_18(TransformationType.Movement);
		}

		// Token: 0x06002789 RID: 10121
		// RVA: 0x0001E738 File Offset: 0x0001C938
		[CompilerGenerated]
		private void method_45(object object_0, bool bool_8)
		{
			this.method_18(TransformationType.Scale);
		}

		// Token: 0x0600278A RID: 10122
		// RVA: 0x0001E741 File Offset: 0x0001C941
		[CompilerGenerated]
		private void method_46(object object_0, bool bool_8)
		{
			this.method_18(TransformationType.Fade);
		}

		// Token: 0x0600278B RID: 10123
		// RVA: 0x0001E74A File Offset: 0x0001C94A
		[CompilerGenerated]
		private void method_47(object object_0, bool bool_8)
		{
			this.method_18(TransformationType.Rotation);
		}

		// Token: 0x0600278C RID: 10124
		// RVA: 0x0001E753 File Offset: 0x0001C953
		[CompilerGenerated]
		private void method_48(object object_0, bool bool_8)
		{
			this.method_18(TransformationType.Colour);
		}

		// Token: 0x0600278D RID: 10125
		// RVA: 0x0001E75D File Offset: 0x0001C95D
		[CompilerGenerated]
		private void method_49(object object_0, bool bool_8)
		{
			this.method_6(bool_8);
		}

		// Token: 0x06002743 RID: 10051
		// RVA: 0x000F2B10 File Offset: 0x000F0D10
		private void method_5()
		{
			if (this.class702_1 == null)
			{
				return;
			}
			List<Class746> arg_2C_0 = this.list_1;
			if (Class376.predicate_2 == null)
			{
				Class376.predicate_2 = new Predicate<Class746>(Class376.smethod_3);
			}
			Class746 class = arg_2C_0.Find(Class376.predicate_2);
			if (class == null)
			{
				return;
			}
			if (class.int_0 > Class331.int_7)
			{
				Class331.smethod_70(class.int_0, false, false);
				return;
			}
			if (class.int_1 > Class331.int_7)
			{
				Class331.smethod_70(class.int_1, false, false);
			}
		}

		// Token: 0x0600278E RID: 10126
		// RVA: 0x0001E766 File Offset: 0x0001C966
		[CompilerGenerated]
		private void method_50(object object_0, bool bool_8)
		{
			this.method_7(bool_8 ? Enum70.const_2 : Enum70.const_0);
		}

		// Token: 0x0600278F RID: 10127
		// RVA: 0x0001E775 File Offset: 0x0001C975
		[CompilerGenerated]
		private void method_51(object object_0, bool bool_8)
		{
			this.method_7(bool_8 ? Enum70.const_1 : Enum70.const_0);
		}

		// Token: 0x06002790 RID: 10128
		// RVA: 0x0001E784 File Offset: 0x0001C984
		[CompilerGenerated]
		private void method_52(object object_0, bool bool_8)
		{
			this.method_16(Origins.TopLeft);
		}

		// Token: 0x06002791 RID: 10129
		// RVA: 0x0001E78D File Offset: 0x0001C98D
		[CompilerGenerated]
		private void method_53(object object_0, bool bool_8)
		{
			this.method_16(Origins.Centre);
		}

		// Token: 0x06002792 RID: 10130
		// RVA: 0x0001E796 File Offset: 0x0001C996
		[CompilerGenerated]
		private void method_54(object object_0, bool bool_8)
		{
			this.method_15(bool_8);
		}

		// Token: 0x06002793 RID: 10131
		// RVA: 0x0001E79F File Offset: 0x0001C99F
		[CompilerGenerated]
		private void method_55(object object_0, bool bool_8)
		{
			this.method_18(TransformationType.VectorScale);
		}

		// Token: 0x06002794 RID: 10132
		// RVA: 0x0001E7AC File Offset: 0x0001C9AC
		[CompilerGenerated]
		private void method_56(object object_0, bool bool_8)
		{
			this.method_17(TransformationType.ParameterFlipHorizontal, bool_8);
		}

		// Token: 0x06002795 RID: 10133
		// RVA: 0x0001E7B7 File Offset: 0x0001C9B7
		[CompilerGenerated]
		private void method_57(object object_0, bool bool_8)
		{
			this.method_17(TransformationType.ParameterFlipVertical, bool_8);
		}

		// Token: 0x06002796 RID: 10134
		// RVA: 0x0001E7C2 File Offset: 0x0001C9C2
		[CompilerGenerated]
		private bool method_58(Class746 class746_0)
		{
			return class746_0.transformationType_0 == this.transformationType_0;
		}

		// Token: 0x06002797 RID: 10135
		// RVA: 0x0001E7D2 File Offset: 0x0001C9D2
		[CompilerGenerated]
		private void method_59(Class531 class531_1)
		{
			class531_1.string_0 = string.Format(Class41.GetString(OsuString.EditorModeDesign_VideoOffsetTooltip), this.class702_3.int_2);
		}

		// Token: 0x06002744 RID: 10052
		// RVA: 0x000F2B88 File Offset: 0x000F0D88
		private void method_6(bool bool_8)
		{
			if (this.class702_1 == null)
			{
				return;
			}
			this.editor_0.method_16(false);
			if (!bool_8)
			{
				this.class762_16.method_6(false);
				this.class762_17.method_6(false);
			}
			if (!bool_8)
			{
				List<Class746> arg_21C_0 = this.list_1;
				if (Class376.predicate_6 == null)
				{
					Class376.predicate_6 = new Predicate<Class746>(Class376.smethod_7);
				}
				int num = arg_21C_0.FindIndex(Class376.predicate_6);
				if (num >= 0)
				{
					Class746 class = this.list_1[num];
					int index = this.class702_1.class531_0.class26_0.IndexOf(class);
					this.class702_1.class531_0.class26_0.RemoveAt(index);
					if (num == this.list_1.Count - 1 || this.list_1[num + 1].int_0 != class.int_1)
					{
						Class746 class2 = class.Clone();
						class2.int_0 = class2.int_1;
						class2.float_0 = class2.float_1;
						class2.vector2_0 = class2.vector2_1;
						class2.color_0 = class2.color_1;
						this.class702_1.class531_0.class26_0.Insert(index, class2);
					}
					if (num == 0 || this.list_1[num - 1].int_1 != class.int_0)
					{
						Class746 class3 = class.Clone();
						class3.int_1 = class3.int_0;
						class3.float_1 = class3.float_0;
						class3.vector2_1 = class3.vector2_0;
						class3.color_1 = class3.color_0;
						this.class702_1.class531_0.class26_0.Insert(index, class3);
					}
				}
				return;
			}
			List<Class746> arg_59_0 = this.list_1;
			if (Class376.predicate_3 == null)
			{
				Class376.predicate_3 = new Predicate<Class746>(Class376.smethod_4);
			}
			int num2 = arg_59_0.FindIndex(Class376.predicate_3);
			if (num2 >= 0)
			{
				return;
			}
			List<Class746> arg_87_0 = this.list_1;
			if (Class376.predicate_4 == null)
			{
				Class376.predicate_4 = new Predicate<Class746>(Class376.smethod_5);
			}
			num2 = arg_87_0.FindLastIndex(Class376.predicate_4);
			if (num2 < 0)
			{
				return;
			}
			Class746 class4 = this.list_1[num2];
			int num3 = -1;
			Class746 class5;
			if (class4.int_0 == class4.int_1)
			{
				num3 = this.class702_1.class531_0.class26_0.IndexOf(class4);
				class5 = class4;
			}
			else
			{
				class5 = class4.Clone();
				class5.int_0 = class5.int_1;
				class5.float_0 = class5.float_1;
				class5.vector2_0 = class5.vector2_1;
				class5.color_0 = class5.color_1;
			}
			List<Class746> arg_126_0 = this.list_1;
			if (Class376.predicate_5 == null)
			{
				Class376.predicate_5 = new Predicate<Class746>(Class376.smethod_6);
			}
			num2 = arg_126_0.FindIndex(Class376.predicate_5);
			if (num2 < 0)
			{
				return;
			}
			if (num3 >= 0)
			{
				this.class702_1.class531_0.class26_0.RemoveAt(num3);
			}
			class4 = this.list_1[num2];
			if (class4.int_0 == class4.int_1)
			{
				num3 = this.class702_1.class531_0.class26_0.IndexOf(class4);
				this.class702_1.class531_0.class26_0.RemoveAt(num3);
			}
			class5.float_1 = class4.float_0;
			class5.vector2_1 = class4.vector2_0;
			class5.color_1 = class4.color_0;
			class5.int_1 = class4.int_0;
			if (num3 >= 0)
			{
				this.class702_1.class531_0.class26_0.Insert(num3, class5);
				return;
			}
			this.class702_1.class531_0.class26_0.Insert(num2 + 1, class5);
		}

		// Token: 0x06002798 RID: 10136
		// RVA: 0x0001E7C2 File Offset: 0x0001C9C2
		[CompilerGenerated]
		private bool method_60(Class746 class746_0)
		{
			return class746_0.transformationType_0 == this.transformationType_0;
		}

		// Token: 0x0600279C RID: 10140
		// RVA: 0x0001E849 File Offset: 0x0001CA49
		[CompilerGenerated]
		private bool method_61(Class746 class746_0)
		{
			return class746_0.transformationType_0 == this.transformationType_1;
		}

		// Token: 0x06002745 RID: 10053
		// RVA: 0x000F2F04 File Offset: 0x000F1104
		private void method_7(Enum70 enum70_1)
		{
			if (this.class702_1 == null)
			{
				return;
			}
			this.editor_0.method_16(false);
			this.enum70_0 = enum70_1;
			this.class762_16.method_6(this.enum70_0 == Enum70.const_2);
			this.class762_17.method_6(this.enum70_0 == Enum70.const_1);
			if (!this.class762_18.method_2() && this.enum70_0 != Enum70.const_0)
			{
				this.class762_18.method_3(true);
			}
			List<Class746> arg_88_0 = this.list_1;
			if (Class376.predicate_7 == null)
			{
				Class376.predicate_7 = new Predicate<Class746>(Class376.smethod_8);
			}
			Class746 class = arg_88_0.Find(Class376.predicate_7);
			if (class != null)
			{
				class.enum70_0 = this.enum70_0;
			}
		}

		// Token: 0x0600274A RID: 10058
		// RVA: 0x0001E50D File Offset: 0x0001C70D
		private void method_8(object sender, EventArgs e)
		{
			this.method_9(null);
		}

		// Token: 0x0600274D RID: 10061
		// RVA: 0x000F30EC File Offset: 0x000F12EC
		internal void method_9(string string_0)
		{
			if (string_0 == null)
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.InitialDirectory = Path.GetFullPath(Class466.Current.method_3());
				openFileDialog.RestoreDirectory = true;
				if (DialogResult.Cancel != openFileDialog.ShowDialog(Class115.form_0))
				{
					this.method_9(openFileDialog.FileName);
				}
				return;
			}
			try
			{
				string text = Class466.Current.method_3() + "\\" + Path.GetFileName(string_0);
				if (string_0.IndexOf(Class466.Current.method_3(), StringComparison.CurrentCultureIgnoreCase) < 0)
				{
					try
					{
						File.Delete(text);
						File.Copy(string_0, text);
					}
					catch (Exception ex)
					{
						MessageBox.Show(Class41.GetString(OsuString.EditorModeDesign_ErrorCopyingBackgroundFile) + ex.Message);
					}
				}
				text = Class777.smethod_1(text, 1366, 768);
				Class702 class = this.class872_0.Add(Path.GetFileName(text), 0);
				this.editor_0.bool_5 = true;
				for (int i = 0; i < this.class872_0.list_1.Count; i++)
				{
					if (this.class872_0.list_1[i] != class && this.class872_0.list_1[i].eventTypes_0 == class.eventTypes_0)
					{
						this.class872_0.Remove(this.class872_0.list_1[i]);
						i--;
					}
				}
				if (class != null && class.eventTypes_0 == EventTypes.Video)
				{
					this.class702_3 = class;
					this.class883_0.SetValue((double)class.int_2, false);
				}
				else if (class != null && class.eventTypes_0 == EventTypes.Background)
				{
					Class466.Current.string_2 = Path.GetFileName(text);
				}
				this.editor_0.bool_5 = true;
				this.class872_0.method_21();
				this.class872_0.method_20();
			}
			catch (Exception)
			{
				MessageBox.Show(Class41.GetString(OsuString.EditorModeDesign_ErrorDuringImportProcess));
			}
		}

		// Token: 0x06002773 RID: 10099
		// RVA: 0x000F65F4 File Offset: 0x000F47F4
		internal override void Reset()
		{
			if (this.class762_2 == null)
			{
				return;
			}
			this.class762_2.method_6(true);
			this.class762_3.method_6(true);
			this.class762_5.method_6(true);
			this.class762_4.method_6(true);
			this.method_29(null, false);
			this.int_0 = -1;
			this.class702_0 = null;
			this.list_0.Clear();
			this.bool_2 = true;
			this.class872_0 = this.class297_0.class872_0;
			if (this.class872_0 != null)
			{
				this.method_25();
			}
			if (this.bool_0)
			{
				this.class872_0.class911_2.bool_9 = true;
				this.class872_0.class911_0.bool_9 = true;
				this.class872_0.class911_1.bool_9 = true;
			}
		}

		// Token: 0x0600275F RID: 10079
		// RVA: 0x0001E551 File Offset: 0x0001C751
		private static bool smethod_0(Class702 class702_4)
		{
			return class702_4.class531_0.vmethod_10(Class800.smethod_19(), 4);
		}

		// Token: 0x06002775 RID: 10101
		// RVA: 0x0001E64D File Offset: 0x0001C84D
		[CompilerGenerated]
		private static bool smethod_1(Class530 class530_0)
		{
			return class530_0.int_0 > 0;
		}

		// Token: 0x0600279A RID: 10138
		// RVA: 0x0001E7F9 File Offset: 0x0001C9F9
		[CompilerGenerated]
		private static bool smethod_10(Class746 class746_0)
		{
			return class746_0.int_0 <= Class331.int_7 && class746_0.int_1 >= Class331.int_7 && class746_0.transformationType_0 == TransformationType.ParameterFlipHorizontal;
		}

		// Token: 0x0600279B RID: 10139
		// RVA: 0x0001E821 File Offset: 0x0001CA21
		[CompilerGenerated]
		private static bool smethod_11(Class746 class746_0)
		{
			return class746_0.int_0 <= Class331.int_7 && class746_0.int_1 >= Class331.int_7 && class746_0.transformationType_0 == TransformationType.ParameterFlipVertical;
		}

		// Token: 0x0600279D RID: 10141
		// RVA: 0x0001E859 File Offset: 0x0001CA59
		[CompilerGenerated]
		private static bool smethod_12(Class746 class746_0)
		{
			return class746_0.int_1 == Class331.int_7;
		}

		// Token: 0x0600279E RID: 10142
		// RVA: 0x0001925A File Offset: 0x0001745A
		[CompilerGenerated]
		private static bool smethod_13(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Movement;
		}

		// Token: 0x0600279F RID: 10143
		// RVA: 0x0001E859 File Offset: 0x0001CA59
		[CompilerGenerated]
		private static bool smethod_14(Class746 class746_0)
		{
			return class746_0.int_1 == Class331.int_7;
		}

		// Token: 0x060027A0 RID: 10144
		// RVA: 0x0001E868 File Offset: 0x0001CA68
		[CompilerGenerated]
		private static bool smethod_15(Class702 class702_4)
		{
			return class702_4.eventTypes_0 == EventTypes.Video;
		}

		// Token: 0x060027A1 RID: 10145
		// RVA: 0x0001E64D File Offset: 0x0001C84D
		[CompilerGenerated]
		private static bool smethod_16(Class530 class530_0)
		{
			return class530_0.int_0 > 0;
		}

		// Token: 0x06002776 RID: 10102
		// RVA: 0x0001E658 File Offset: 0x0001C858
		[CompilerGenerated]
		private static bool smethod_2(Class746 class746_0)
		{
			return class746_0.int_0 < Class331.int_7 || class746_0.int_1 < Class331.int_7;
		}

		// Token: 0x06002777 RID: 10103
		// RVA: 0x0001E676 File Offset: 0x0001C876
		[CompilerGenerated]
		private static bool smethod_3(Class746 class746_0)
		{
			return class746_0.int_0 > Class331.int_7 || class746_0.int_1 > Class331.int_7;
		}

		// Token: 0x06002778 RID: 10104
		// RVA: 0x0001E694 File Offset: 0x0001C894
		[CompilerGenerated]
		private static bool smethod_4(Class746 class746_0)
		{
			return class746_0.int_0 <= Class331.int_7 && class746_0.int_1 >= Class331.int_7;
		}

		// Token: 0x06002779 RID: 10105
		// RVA: 0x0001E6B5 File Offset: 0x0001C8B5
		[CompilerGenerated]
		private static bool smethod_5(Class746 class746_0)
		{
			return class746_0.int_1 < Class331.int_7;
		}

		// Token: 0x0600277A RID: 10106
		// RVA: 0x0001E6C4 File Offset: 0x0001C8C4
		[CompilerGenerated]
		private static bool smethod_6(Class746 class746_0)
		{
			return class746_0.int_0 > Class331.int_7;
		}

		// Token: 0x0600277B RID: 10107
		// RVA: 0x0001E694 File Offset: 0x0001C894
		[CompilerGenerated]
		private static bool smethod_7(Class746 class746_0)
		{
			return class746_0.int_0 <= Class331.int_7 && class746_0.int_1 >= Class331.int_7;
		}

		// Token: 0x0600277C RID: 10108
		// RVA: 0x0001E694 File Offset: 0x0001C894
		[CompilerGenerated]
		private static bool smethod_8(Class746 class746_0)
		{
			return class746_0.int_0 <= Class331.int_7 && class746_0.int_1 >= Class331.int_7;
		}

		// Token: 0x06002799 RID: 10137
		// RVA: 0x0001E694 File Offset: 0x0001C894
		[CompilerGenerated]
		private static bool smethod_9(Class746 class746_0)
		{
			return class746_0.int_0 <= Class331.int_7 && class746_0.int_1 >= Class331.int_7;
		}

		// Token: 0x06002746 RID: 10054
		// RVA: 0x00016E41 File Offset: 0x00015041
		internal override bool vmethod_0()
		{
			return base.vmethod_0();
		}

		// Token: 0x06002747 RID: 10055
		// RVA: 0x0001E4F0 File Offset: 0x0001C6F0
		internal override void vmethod_1(bool bool_8)
		{
			base.vmethod_1(bool_8);
			this.class911_1.bool_6 = bool_8;
		}

		// Token: 0x06002767 RID: 10087
		// RVA: 0x000F5C94 File Offset: 0x000F3E94
		internal override bool vmethod_10(Keys keys_0, bool bool_8)
		{
			if (Class111.bool_2)
			{
				return false;
			}
			if (bool_8)
			{
				if (Class570.bool_0)
				{
					switch (keys_0)
					{
					case 49:
						this.method_19(StoryLayer.Background);
						return true;
					case 50:
						this.method_19(StoryLayer.Fail);
						return true;
					case 51:
						this.method_19(StoryLayer.Pass);
						return true;
					case 52:
						this.method_19(StoryLayer.Foreground);
						return true;
					default:
						switch (keys_0)
						{
						case 86:
							this.vmethod_19();
							return true;
						case 88:
							if (this.class702_1 != null)
							{
								this.class702_2 = this.class702_1.Clone();
							}
							this.method_28();
							return true;
						}
						break;
					}
				}
				else if (!Class570.bool_1)
				{
					if (keys_0 <= 68)
					{
						if (keys_0 == 46)
						{
							this.method_28();
							return true;
						}
						if (keys_0 == 65)
						{
							this.method_22(-1f, 0f);
							return true;
						}
						if (keys_0 == 68)
						{
							this.method_22(1f, 0f);
							return true;
						}
					}
					else
					{
						if (keys_0 == 73)
						{
							this.method_14();
							return true;
						}
						if (keys_0 == 83)
						{
							this.method_22(0f, 1f);
							return true;
						}
						if (keys_0 == 87)
						{
							this.method_22(0f, -1f);
							return true;
						}
					}
				}
			}
			if (this.class883_0.method_7())
			{
				if (Class570.bool_2)
				{
					this.class883_0.double_4 = 1.0;
				}
				else
				{
					this.class883_0.double_4 = 10.0;
				}
				return true;
			}
			return base.vmethod_10(keys_0, bool_8);
		}

		// Token: 0x0600276D RID: 10093
		// RVA: 0x000F6390 File Offset: 0x000F4590
		internal override void vmethod_11()
		{
			Class115.smethod_68(0.78125f, true);
			this.editor_0.method_65();
			this.editor_0.int_10 = 6;
			Class115.vector2_0.Y = Class115.vector2_0.Y - 16f;
			this.editor_0.class872_0.class911_1.vector2_0 = new Vector2(0f, 0f);
			this.editor_0.class872_0.class911_0.vector2_0 = new Vector2(0f, 0f);
			this.editor_0.class872_0.class911_2.vector2_0 = new Vector2(0f, 0f);
			this.method_31(this.bool_7);
			this.class872_0.class911_1.bool_9 = true;
			this.class872_0.class911_2.bool_9 = true;
			this.class872_0.class911_0.bool_9 = true;
			Class331.smethod_51(true);
			this.class110_0.method_32(1f);
			base.vmethod_11();
		}

		// Token: 0x0600276E RID: 10094
		// RVA: 0x000F649C File Offset: 0x000F469C
		internal override void vmethod_12()
		{
			this.class110_0.method_32(0f);
			this.class297_0.class911_0.float_0 = 1f;
			this.class911_1.float_0 = 0f;
			Class331.smethod_51(false);
			this.class872_0.class911_2.bool_9 = false;
			this.class872_0.class911_1.bool_9 = false;
			this.class872_0.class911_0.bool_9 = false;
			Class802.smethod_15();
			base.vmethod_12();
		}

		// Token: 0x06002769 RID: 10089
		// RVA: 0x0001E5D3 File Offset: 0x0001C7D3
		internal override void vmethod_17()
		{
			this.method_29(null, true);
			base.vmethod_17();
		}

		// Token: 0x0600274C RID: 10060
		// RVA: 0x000F3098 File Offset: 0x000F1298
		internal override void vmethod_18()
		{
			if (this.class702_1 != null)
			{
				this.class702_2 = this.class702_1;
			}
			try
			{
				Clipboard.SetText(Class331.int_10.ToString());
			}
			catch (Exception)
			{
				Class723.smethod_4(Class41.GetString(OsuString.General_Editor_ClipboardNotAvailable));
			}
		}

		// Token: 0x0600274B RID: 10059
		// RVA: 0x000F3018 File Offset: 0x000F1218
		internal override void vmethod_19()
		{
			if (this.class702_2 != null)
			{
				Class702 class = this.class702_2.Clone();
				this.editor_0.method_16(false);
				if (class.class531_0 != null && class.class531_0.class26_0.Count > 0)
				{
					int num = Class331.int_7 - class.class531_0.class26_0[0].int_0;
					class.class531_0.method_24(num);
				}
				this.class872_0.Add(class);
			}
		}

		// Token: 0x0600274E RID: 10062
		// RVA: 0x000F32EC File Offset: 0x000F14EC
		protected override void vmethod_2()
		{
			this.class911_1 = new Class911(true);
			this.class911_1.float_0 = 0f;
			this.class533_0 = new Class533(string.Empty, 10f, new Vector2((float)(Class115.smethod_43() - 200), 28f), Vector2.get_Zero(), 1f, true, Color.get_White(), true);
			this.class533_0.bool_17 = false;
			this.class533_0.bool_15 = false;
			this.class533_0.method_58(true);
			this.class533_1 = new Class533(string.Empty, 10f, new Vector2((float)(Class115.smethod_43() - 200), 56f), Vector2.get_Zero(), 1f, true, Color.get_White(), true);
			this.class533_1.bool_17 = false;
			this.class533_1.bool_15 = false;
			this.class533_1.method_58(true);
			this.class911_0.Add(this.class533_0);
			this.class911_0.Add(this.class533_1);
			this.method_11();
			this.method_12();
			Class760 class = new Class760(Class41.GetString(OsuString.Editor_Design_BackgroundImageVideo), new Vector2((float)(Class115.smethod_43() - 180), 6f), new Vector2(170f, 22.5f), 1f, new Color(112, 152, 252), new EventHandler(this.method_8), true, false, null);
			this.class911_0.Add<Class531>(class.list_0);
			this.class883_0 = new Class883(this.class911_0, -3000.0, 3000.0, (double)((this.class702_3 != null) ? this.class702_3.int_2 : 0), new Vector2((float)(Class115.smethod_43() - 130), 52f), 125);
			this.class533_4 = new Class533(Class41.GetString(OsuString.EditorModeDesign_VideoOffset), 12f, new Vector2((float)this.class883_0.int_0 / 2f + this.class883_0.method_0().X, 32f), 1f, true, Color.get_White());
			this.class533_4.object_0 = Enum105.const_2;
			this.class533_4.origins_0 = Origins.TopCentre;
			this.class911_0.Add(this.class533_4);
			this.class883_0.method_3(false);
			this.class883_0.bool_2 = true;
			this.class533_4.float_3 = 0f;
			Class533 class2 = new Class533(Class41.GetString(OsuString.EditorModeDesign_KeyframeControl), 10f, new Vector2(160f, 64f), 1f, true, Color.get_White());
			class2.bool_16 = true;
			class2.method_58(true);
			this.class911_0.Add(class2);
			Class531 class3 = new Class531(Class885.Load("editor-timeline-plus", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(250f, 70f), 1f, true, Color.get_White(), null);
			class3.float_2 = 0.8f;
			class3.bool_1 = true;
			class3.class746_0 = new Class746(TransformationType.Scale, 0.9f, 0.8f, 0, 200, Enum70.const_0);
			class3.method_2(new EventHandler(this.method_33));
			this.class911_0.Add(class3);
			class3 = new Class531(Class885.Load("editor-timeline-minus", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(265f, 70f), 1f, true, Color.get_White(), null);
			class3.float_2 = 0.8f;
			class3.bool_1 = true;
			class3.class746_0 = new Class746(TransformationType.Scale, 0.9f, 0.8f, 0, 200, Enum70.const_0);
			class3.method_2(new EventHandler(this.method_34));
			this.class911_0.Add(class3);
			class3 = new Class531(Class885.Load("editor-timeline-left", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(280f, 70f), 1f, true, Color.get_White(), null);
			class3.float_2 = 0.8f;
			class3.bool_1 = true;
			class3.class746_0 = new Class746(TransformationType.Scale, 0.9f, 0.8f, 0, 200, Enum70.const_0);
			class3.method_2(new EventHandler(this.method_35));
			this.class911_0.Add(class3);
			class3 = new Class531(Class885.Load("editor-timeline-right", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(295f, 70f), 1f, true, Color.get_White(), null);
			class3.float_2 = 0.8f;
			class3.bool_1 = true;
			class3.class746_0 = new Class746(TransformationType.Scale, 0.9f, 0.8f, 0, 200, Enum70.const_0);
			class3.method_2(new EventHandler(this.method_36));
			this.class911_0.Add(class3);
			class = new Class760("Sprite\nLibrary", new Vector2((float)(Class115.smethod_43() - 70), 372f), new Vector2(66f, 40f), 1f, Color.get_YellowGreen(), new EventHandler(this.method_13), true, false, null);
			this.class911_0.Add<Class531>(class.list_0);
			this.class533_2 = new Class533(string.Empty, 8f, new Vector2(-1f, -1f), Vector2.get_Zero(), 1f, true, Color.get_White(), true);
			this.class533_2.bool_17 = false;
			this.class533_2.bool_15 = false;
			this.class533_2.enum115_0 = Enum115.const_4;
			this.class911_0.Add(this.class533_2);
			this.class533_3 = new Class533("Movement\nScale\nFade\nRotation", 8.4f, new Vector2((float)this.editor_0.int_4, (float)this.editor_0.int_5), 1f, true, Color.get_White());
			this.class533_3.bool_16 = true;
			this.class533_3.method_58(true);
			this.class911_0.Add(this.class533_3);
			class3 = new Class531(Class885.Load("editor-button-play", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2((float)(this.editor_0.int_4 + 5), 70f), 1f, true, Color.get_White(), null);
			class3.float_1 = 1.5708f;
			class3.float_2 = 0.7f;
			class3.bool_1 = true;
			class3.class746_0 = new Class746(TransformationType.Scale, 0.8f, 0.7f, 0, 200, Enum70.const_0);
			class3.method_2(new EventHandler(this.method_37));
			this.class911_0.Add(class3);
			class3 = new Class531(Class885.Load("editor-button-play", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2((float)(this.editor_0.int_4 + 20), 70f), 1f, true, Color.get_White(), null);
			class3.float_1 = -1.5708f;
			class3.float_2 = 0.7f;
			class3.bool_1 = true;
			class3.class746_0 = new Class746(TransformationType.Scale, 0.8f, 0.7f, 0, 200, Enum70.const_0);
			class3.method_2(new EventHandler(this.method_38));
			this.class911_0.Add(class3);
			base.vmethod_2();
		}

		// Token: 0x06002749 RID: 10057
		// RVA: 0x0001E505 File Offset: 0x0001C705
		protected override void vmethod_21()
		{
			this.Reset();
		}

		// Token: 0x06002759 RID: 10073
		// RVA: 0x000F45FC File Offset: 0x000F27FC
		internal override void vmethod_3()
		{
			Action<Class531> action = null;
			Predicate<Class746> predicate = null;
			Predicate<Class746> predicate2 = null;
			this.class297_0.method_26();
			this.vector2_3 = Class800.smethod_19();
			float num = (float)Class115.int_22 * Class115.smethod_48();
			float num2 = (float)Class115.int_23 * Class115.smethod_48();
			Vector2 vector;
			vector..ctor(((float)Class115.int_22 - num) / 2f + (float)Class115.int_26, ((float)Class115.int_23 - num2) / 4f * 3f + (float)Class115.int_25);
			this.vector2_3 -= vector;
			this.vector2_3 = this.vector2_3 / num2 * 480f;
			this.method_20();
			if (Class115.bool_13)
			{
				float num3 = Class115.smethod_47() * (float)(Class115.class83_0.method_2() + this.class872_0.class911_1.int_3 + this.class872_0.class911_0.int_3 + this.class872_0.class911_2.int_3);
				this.class533_1.color_0 = ((num3 > 5f) ? Color.get_Red() : Color.get_White());
				this.class533_1.bool_16 = (num3 > 5f);
				this.class533_0.Text = string.Format("x:{0:0} y:{1:0}\n{2:#,0}ms", this.vector2_3.X, this.vector2_3.Y, Class331.int_7);
				this.class533_1.Text = string.Format("SB Load:{0:0.00}x", num3);
			}
			if (this.class702_3 != null)
			{
				this.class883_0.method_3(true);
				this.class533_4.float_3 = 1f;
				if (this.class883_0.method_7())
				{
					int int_ = (int)this.class883_0.double_1;
					this.class702_3.vmethod_0(int_);
					List<Class531> arg_1EA_0 = this.class883_0.list_0;
					if (action == null)
					{
						action = new Action<Class531>(this.method_59);
					}
					arg_1EA_0.ForEach(action);
				}
			}
			else
			{
				this.class883_0.method_3(false);
				this.class533_4.float_3 = 0f;
			}
			if (this.class702_1 != null)
			{
				List<Class746> arg_23D_0 = this.class702_1.class531_0.class26_0;
				if (predicate == null)
				{
					predicate = new Predicate<Class746>(this.method_60);
				}
				this.list_1 = arg_23D_0.FindAll(predicate);
				List<Class746> arg_26A_0 = this.list_1;
				if (Class376.predicate_8 == null)
				{
					Class376.predicate_8 = new Predicate<Class746>(Class376.smethod_9);
				}
				Class746 class = arg_26A_0.Find(Class376.predicate_8);
				this.bool_4 = this.class702_1.bool_2;
				this.class762_0.method_6(this.bool_4);
				this.origins_0 = this.class702_1.class531_0.origins_0;
				this.class762_7.method_6(this.origins_0 == Origins.TopLeft);
				this.class762_6.method_6(this.origins_0 == Origins.Centre);
				this.class762_18.method_6(class != null);
				this.enum70_0 = ((class == null) ? Enum70.const_0 : class.enum70_0);
				this.class762_16.method_6(this.enum70_0 == Enum70.const_2);
				this.class762_17.method_6(this.enum70_0 == Enum70.const_1);
				Class762 arg_360_0 = this.class762_9;
				List<Class746> arg_353_0 = this.class702_1.class531_0.class26_0;
				if (Class376.predicate_9 == null)
				{
					Class376.predicate_9 = new Predicate<Class746>(Class376.smethod_10);
				}
				arg_360_0.method_6(arg_353_0.FindAll(Class376.predicate_9).Count > 0);
				Class762 arg_3A5_0 = this.class762_10;
				List<Class746> arg_398_0 = this.class702_1.class531_0.class26_0;
				if (Class376.predicate_10 == null)
				{
					Class376.predicate_10 = new Predicate<Class746>(Class376.smethod_11);
				}
				arg_3A5_0.method_6(arg_398_0.FindAll(Class376.predicate_10).Count > 0);
				this.class533_2.vector2_1 = ((this.class702_1.class531_0.float_1 == 0f) ? new Vector2(this.class702_1.class531_0.rectangleF_0.method_0(), this.class702_1.class531_0.rectangleF_0.Top) : new Vector2(this.class702_1.class531_0.vector2_3.X, this.class702_1.class531_0.vector2_3.Y));
				this.class533_2.Text = string.Concat(new object[]
				{
					this.class702_1.string_0,
					" (",
					this.class702_1.storyLayer_0,
					(this.class702_1.int_1 > 0) ? (" - line " + this.class702_1.int_1) : string.Empty,
					")\n"
				});
				this.class533_2.float_3 = 1f;
			}
			else
			{
				this.class533_2.float_3 = 0f;
				this.class762_18.method_6(false);
				this.class762_16.method_6(false);
				this.class762_17.method_6(false);
			}
			if (this.bool_6)
			{
				if (Class570.bool_2)
				{
					if (Math.Abs(this.vector2_2.X - this.vector2_3.X) > Math.Abs(this.vector2_2.Y - this.vector2_3.Y))
					{
						this.vector2_3.Y = this.vector2_2.Y;
					}
					else
					{
						this.vector2_3.X = this.vector2_2.X;
					}
				}
				Class746 class2 = null;
				if (this.transformationType_0 != TransformationType.Colour)
				{
					this.method_2(Class331.int_7, ref class2, true);
				}
			}
			else
			{
				this.class702_0 = null;
				this.list_0.Clear();
				if (!this.editor_0.bool_17 && this.class911_1.float_0 < 1f)
				{
					this.list_2 = this.class872_0.method_2();
					if (this.list_2.Count > 0)
					{
						bool flag = Class570.bool_2;
						int count = this.list_2.Count;
						int num4 = (this.int_0 - 1 + count) % count;
						bool flag2 = true;
						int num5 = num4;
						while (num5 != num4 || flag2)
						{
							flag2 = false;
							Class702 class3 = this.list_2[num5];
							if (class3.class531_0.bool_3 && Class376.smethod_0(class3))
							{
								if (this.class702_0 == null)
								{
									this.class702_0 = class3;
									if (!flag)
									{
										break;
									}
								}
								else if (flag)
								{
									this.list_0.Add(class3);
								}
							}
							num5 = (num5 - 1 + count) % count;
						}
					}
				}
			}
			if (this.bool_5 && this.transformationType_1 != TransformationType.None)
			{
				int num6 = this.editor_0.method_71(Class802.point_0.X);
				if (!Class570.bool_2)
				{
					num6 = this.editor_0.class375_0.method_5((double)(num6 - this.int_1));
				}
				int arg_704_0 = num6;
				List<Class746> arg_6FA_0 = this.class702_1.class531_0.class26_0;
				if (predicate2 == null)
				{
					predicate2 = new Predicate<Class746>(this.method_61);
				}
				int num7 = arg_704_0 - arg_6FA_0.Find(predicate2).int_0;
				bool flag3 = true;
				int i = 0;
				while (i < this.class702_1.class531_0.class26_0.Count)
				{
					Class746 class4 = this.class702_1.class531_0.class26_0[i];
					if (class4.transformationType_0 != this.transformationType_1 || (class4.int_0 + num7 >= 0 && class4.int_0 + num7 < Class331.smethod_31()))
					{
						i++;
					}
					else
					{
						flag3 = false;
						IL_779:
						if (flag3)
						{
							for (int j = 0; j < this.class702_1.class531_0.class26_0.Count; j++)
							{
								Class746 class5 = this.class702_1.class531_0.class26_0[j];
								if (class5.transformationType_0 == this.transformationType_1)
								{
									class5.int_0 += num7;
									class5.int_1 += num7;
								}
							}
							this.class702_1.class531_0.class26_0.Sort();
							goto IL_801;
						}
						goto IL_801;
					}
				}
				goto IL_779;
			}
			IL_801:
			this.method_1();
		}

		// Token: 0x0600276B RID: 10091
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal override void vmethod_4()
		{
		}

		// Token: 0x0600276C RID: 10092
		// RVA: 0x000F5EB4 File Offset: 0x000F40B4
		internal override void vmethod_5()
		{
			Class115.class882_0.method_0();
			float num = (float)this.editor_0.rectangle_2.Height / 4f;
			Class115.class882_0.method_1(new Vector2((float)this.editor_0.rectangle_2.get_Left(), (float)this.editor_0.rectangle_2.get_Top() + num), Color.get_Gray());
			Class115.class882_0.method_1(new Vector2((float)this.editor_0.rectangle_2.get_Right(), (float)this.editor_0.rectangle_2.get_Top() + num), Color.get_Gray());
			Class115.class882_0.method_1(new Vector2((float)this.editor_0.rectangle_2.get_Left(), (float)this.editor_0.rectangle_2.get_Top() + num * 2f), Color.get_Gray());
			Class115.class882_0.method_1(new Vector2((float)this.editor_0.rectangle_2.get_Right(), (float)this.editor_0.rectangle_2.get_Top() + num * 2f), Color.get_Gray());
			Class115.class882_0.method_1(new Vector2((float)this.editor_0.rectangle_2.get_Left(), (float)this.editor_0.rectangle_2.get_Top() + num * 3f), Color.get_Gray());
			Class115.class882_0.method_1(new Vector2((float)this.editor_0.rectangle_2.get_Right(), (float)this.editor_0.rectangle_2.get_Top() + num * 3f), Color.get_Gray());
			if (this.class702_1 != null)
			{
				foreach (Class746 current in this.class702_1.class531_0.class26_0)
				{
					if ((this.int_2 != 0 || current.transformationType_0 != TransformationType.Colour) && (this.int_2 != 1 || current.transformationType_0 != TransformationType.Movement))
					{
						bool flag = false;
						bool flag2 = false;
						float num2 = 0f;
						float num3 = 0f;
						float num4 = (float)this.editor_0.rectangle_2.get_Top() - num * (float)this.int_2;
						TransformationType transformationType = current.transformationType_0;
						Color color_;
						if (transformationType <= TransformationType.Colour)
						{
							switch (transformationType)
							{
							case TransformationType.Movement:
							case TransformationType.Movement | TransformationType.Fade:
								goto IL_2AA;
							case TransformationType.Fade:
								color_ = Color.get_Pink();
								num4 += num * 2f;
								break;
							case TransformationType.Scale:
								color_ = Color.get_OrangeRed();
								num4 += num;
								break;
							default:
								if (transformationType != TransformationType.Rotation)
								{
									if (transformationType != TransformationType.Colour)
									{
										goto IL_2AA;
									}
									num4 += num * 4f;
									color_ = Color.get_BlanchedAlmond();
								}
								else
								{
									color_ = Color.get_Yellow();
									num4 += num * 3f;
								}
								break;
							}
						}
						else if (transformationType != TransformationType.ParameterFlipHorizontal && transformationType != TransformationType.ParameterFlipVertical)
						{
							if (transformationType != TransformationType.VectorScale)
							{
								goto IL_2AA;
							}
							color_ = Color.get_Yellow();
							num4 += num;
						}
						else
						{
							num4 += num * 3f;
							color_ = Color.get_LightBlue();
						}
						IL_2D5:
						if (current.int_0 >= this.editor_0.int_8 && current.int_0 <= this.editor_0.int_9)
						{
							flag = true;
							num2 = this.editor_0.method_70((double)current.int_0);
							Class115.class882_0.method_1(new Vector2(num2, num4), Color.get_Beige());
							Class115.class882_0.method_1(new Vector2(num2, num4 + 0.49f * num), Color.get_Beige());
						}
						if (current.int_1 >= this.editor_0.int_8 && current.int_1 <= this.editor_0.int_9)
						{
							flag2 = true;
							num3 = this.editor_0.method_70((double)current.int_1);
							Class115.class882_0.method_1(new Vector2(num3, num4 + 0.51f * num), Color.get_Beige());
							Class115.class882_0.method_1(new Vector2(num3, num4 + num), Color.get_Beige());
						}
						if (!flag && !flag2 && (current.int_0 >= this.editor_0.int_8 || current.int_1 <= this.editor_0.int_9))
						{
							continue;
						}
						if (flag)
						{
							Class115.class882_0.method_1(new Vector2(num2, num4 + 0.5f * num), color_);
						}
						else
						{
							Class115.class882_0.method_1(new Vector2((float)this.editor_0.rectangle_2.get_Left(), num4 + 0.5f * num), color_);
						}
						if (flag2)
						{
							Class115.class882_0.method_1(new Vector2(num3, num4 + 0.5f * num), color_);
							continue;
						}
						Class115.class882_0.method_1(new Vector2((float)this.editor_0.rectangle_2.get_Right(), num4 + 0.5f * num), color_);
						continue;
						IL_2AA:
						color_ = Color.get_YellowGreen();
						goto IL_2D5;
					}
				}
			}
			Class115.class882_0.method_2();
		}

		// Token: 0x06002760 RID: 10080
		// RVA: 0x000F55D8 File Offset: 0x000F37D8
		internal override bool vmethod_6()
		{
			if (!this.vmethod_0())
			{
				return false;
			}
			if (this.editor_0.class911_1.class531_1 != null || this.class911_0.class531_1 != null || this.class110_0.class911_0.class531_1 != null)
			{
				return false;
			}
			if (this.editor_0.bool_16 || this.editor_0.bool_17)
			{
				return false;
			}
			if (!this.bool_3 && this.class702_1 != null && this.class702_1 != this.class702_0 && Class376.smethod_0(this.class702_1))
			{
				this.bool_3 = true;
				return false;
			}
			if (this.class702_0 != null)
			{
				this.method_29(this.class702_0, false);
				return true;
			}
			if (this.editor_0.bool_15)
			{
				this.method_29(null, false);
				return true;
			}
			return base.vmethod_6();
		}

		// Token: 0x06002761 RID: 10081
		// RVA: 0x0001E564 File Offset: 0x0001C764
		internal override bool vmethod_7()
		{
			if (!this.bool_6 && this.bool_3)
			{
				this.vmethod_6();
				return true;
			}
			this.bool_3 = false;
			return base.vmethod_7();
		}

		// Token: 0x06002763 RID: 10083
		// RVA: 0x000F5710 File Offset: 0x000F3910
		internal override bool vmethod_8()
		{
			if (this.editor_0.bool_17)
			{
				return false;
			}
			this.editor_0.method_16(false);
			if (this.editor_0.bool_16)
			{
				if (this.class702_1 != null && this.class702_1.class531_0 != null)
				{
					float num = (float)this.editor_0.rectangle_2.Height / 4f;
					int i = 0;
					while (i < this.class702_1.class531_0.class26_0.Count)
					{
						float num2 = (float)this.editor_0.rectangle_2.get_Top() - (float)this.int_2 * num;
						Class746 class = this.class702_1.class531_0.class26_0[i];
						TransformationType transformationType = class.transformationType_0;
						switch (transformationType)
						{
						case TransformationType.Fade:
							num2 += num * 2f;
							break;
						case TransformationType.Movement | TransformationType.Fade:
							break;
						case TransformationType.Scale:
							num2 += num;
							break;
						default:
							if (transformationType != TransformationType.Rotation)
							{
								if (transformationType == TransformationType.Colour)
								{
									num2 += num * 4f;
								}
							}
							else
							{
								num2 += num * 3f;
							}
							break;
						}
						RectangleF rectangleF = new RectangleF(this.editor_0.method_70((double)class.int_0), num2, this.editor_0.method_70((double)class.int_1) - this.editor_0.method_70((double)class.int_0), num);
						if (!rectangleF.Contains(new Point(Class802.point_0.X, Class802.point_0.Y)))
						{
							i++;
						}
						else
						{
							this.transformationType_1 = class.transformationType_0;
							this.int_1 = this.editor_0.method_71((int)Class800.smethod_19().X) - class.int_0;
							IL_19C:
							if (this.transformationType_1 != TransformationType.None)
							{
								this.vector2_2 = new Vector2((float)Class802.point_0.X, (float)Class802.point_0.Y);
								this.bool_5 = true;
								base.vmethod_8();
								return true;
							}
							return false;
						}
					}
					goto IL_19C;
				}
				return false;
			}
			else
			{
				if (this.class110_0.class911_0.class531_1 != null && this.class110_0.class911_0.class531_1.int_0 == 2)
				{
					this.editor_0.bool_5 = true;
					this.class531_0 = this.class110_0.class911_0.class531_1;
					this.class531_0.float_0 = 1f;
					this.class110_0.class911_0.method_10();
					this.vector2_0 = Class800.smethod_19();
					return true;
				}
				if (this.class110_0.method_8())
				{
					return true;
				}
				if (this.editor_0.enum108_0 != Enum108.const_2 && this.editor_0.enum108_0 != Enum108.const_0)
				{
					return false;
				}
				if (this.class702_0 == null && (this.class702_1 == null || !Class376.smethod_0(this.class702_1)))
				{
					return false;
				}
				if (this.editor_0.class911_1.class531_1 != null || this.class911_0.class531_1 != null)
				{
					return false;
				}
				if (this.class702_1 == null)
				{
					return false;
				}
				TransformationType transformationType2 = this.transformationType_0;
				switch (transformationType2)
				{
				case TransformationType.Movement:
					this.vector2_1 = this.class702_1.class531_0.vector2_1 - this.vector2_3;
					break;
				case TransformationType.Fade:
					this.float_1 = this.class702_1.class531_0.float_3;
					break;
				case TransformationType.Movement | TransformationType.Fade:
					break;
				case TransformationType.Scale:
					this.float_1 = this.class702_1.class531_0.float_2;
					break;
				default:
					if (transformationType2 != TransformationType.Rotation)
					{
						if (transformationType2 == TransformationType.VectorScale)
						{
							this.float_1 = this.class702_1.class531_0.vector2_2.X;
							this.float_2 = this.class702_1.class531_0.vector2_2.Y;
						}
					}
					else
					{
						this.float_1 = this.class702_1.class531_0.float_1;
					}
					break;
				}
				this.vector2_2 = this.vector2_3;
				this.bool_6 = true;
				this.editor_0.bool_5 = true;
				base.vmethod_8();
				return true;
			}
		}

		// Token: 0x06002764 RID: 10084
		// RVA: 0x000F5AE8 File Offset: 0x000F3CE8
		internal override void vmethod_9()
		{
			this.bool_6 = false;
			this.bool_5 = false;
			this.transformationType_1 = TransformationType.None;
			if (this.class531_0 != null)
			{
				this.editor_0.bool_5 = true;
				this.class531_0.vector2_5 = Vector2.get_Zero();
				int num = 0;
				int num2 = 0;
				List<Class530> arg_6D_0 = this.class110_0.class911_0.list_2;
				if (Class376.predicate_15 == null)
				{
					Class376.predicate_15 = new Predicate<Class530>(Class376.smethod_16);
				}
				using (List<Class530>.Enumerator enumerator = arg_6D_0.FindAll(Class376.predicate_15).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class531 class = (Class531)enumerator.Current;
						if (class.class26_0.Count > 0)
						{
							class.vector2_1 = class.class26_0[0].vector2_1;
							class.class26_0.Clear();
						}
						if (class.vector2_0 == class.vector2_1)
						{
							if (class.int_0 == 1)
							{
								num++;
								num2 = 0;
							}
							else
							{
								num2++;
							}
						}
					}
				}
				Class702 class702_ = (Class702)this.class531_0.object_0;
				this.method_27(class702_, (StoryLayer)(num - 1), num2);
				this.class531_0 = null;
				this.bool_2 = true;
			}
			base.vmethod_9();
		}
	}
}
