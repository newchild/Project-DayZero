using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns24;
using ns25;
using ns26;
using ns29;
using ns5;
using ns76;
using ns79;
using ns8;
using ns80;
using ns81;
using osu.Graphics.Sprites;
using osu_common;
using osu_common.Bancho.Objects;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns78
{
	// Token: 0x02000638 RID: 1592
	internal sealed class Class838 : IComparable<Class838>
	{
		// Token: 0x02000639 RID: 1593
		[CompilerGenerated]
		private sealed class Class839
		{
			// Token: 0x04002D07 RID: 11527
			public Class537 class537_0;

			// Token: 0x04002D08 RID: 11528
			public Class838 class838_0;

			// Token: 0x0600314C RID: 12620
			// RVA: 0x0014362C File Offset: 0x0014182C
			public void method_0()
			{
				this.class537_0.class26_0.Add(new Class746(TransformationType.Scale, 0f, this.class537_0.float_2, Class115.int_1, Class115.int_1 + 200, Enum70.const_1));
				if (!this.class838_0.bool_0)
				{
					this.class537_0.method_14(500, Enum70.const_0);
				}
			}
		}

		// Token: 0x04002CF2 RID: 11506
		internal bMatch bMatch_0;

		// Token: 0x04002CFC RID: 11516
		internal bool bool_0;

		// Token: 0x04002D00 RID: 11520
		private bool bool_1;

		// Token: 0x04002CF4 RID: 11508
		private Class531 class531_0;

		// Token: 0x04002CF9 RID: 11513
		private Class531 class531_1;

		// Token: 0x04002CFB RID: 11515
		private Class531 class531_2;

		// Token: 0x04002D01 RID: 11521
		private Class531 class531_3;

		// Token: 0x04002CF5 RID: 11509
		private Class533 class533_0;

		// Token: 0x04002CF6 RID: 11510
		private Class533 class533_1;

		// Token: 0x04002CF7 RID: 11511
		private Class533 class533_2;

		// Token: 0x04002CF8 RID: 11512
		private Class533 class533_3;

		// Token: 0x04002CFA RID: 11514
		private Class537 class537_0;

		// Token: 0x04002D03 RID: 11523
		private static readonly Color color_0 = Color.get_YellowGreen();

		// Token: 0x04002D04 RID: 11524
		private static readonly Color color_1 = Color.get_OrangeRed();

		// Token: 0x04002D05 RID: 11525
		private static readonly Color color_2 = new Color(0, 0, 0, 100);

		// Token: 0x04002D06 RID: 11526
		private float float_0;

		// Token: 0x04002CF3 RID: 11507
		internal List<Class531> list_0;

		// Token: 0x04002CFD RID: 11517
		private List<Class537> list_1 = new List<Class537>();

		// Token: 0x04002CFE RID: 11518
		private List<Class531> list_2 = new List<Class531>();

		// Token: 0x04002CFF RID: 11519
		private string string_0;

		// Token: 0x04002D02 RID: 11522
		private Vector2 vector2_0;

		// Token: 0x06003141 RID: 12609
		// RVA: 0x00024631 File Offset: 0x00022831
		public Class838(bMatch bMatch_1)
		{
			this.bMatch_0 = bMatch_1;
		}

		// Token: 0x06003145 RID: 12613
		// RVA: 0x00024691 File Offset: 0x00022891
		public int CompareTo(Class838 obj)
		{
			return this.bMatch_0.matchId.CompareTo(obj.bMatch_0.matchId);
		}

		// Token: 0x06003142 RID: 12610
		// RVA: 0x0014298C File Offset: 0x00140B8C
		public bool method_0(Vector2 vector2_1)
		{
			EventHandler eventHandler = null;
			EventHandler eventHandler2 = null;
			EventHandler eventHandler3 = null;
			EventHandler eventHandler4 = null;
			bool result;
			if (result = (this.list_0 == null))
			{
				this.vector2_0 = vector2_1;
				this.list_0 = new List<Class531>();
				this.class531_0 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, vector2_1, 0.89f, true, new Color(255, 255, 255, 25), null);
				this.class531_0.vector2_2 = new Vector2((float)(Class115.smethod_43() - 15), 48f);
				this.class531_0.float_2 = 1.6f;
				Class531 arg_A1_0 = this.class531_0;
				if (eventHandler == null)
				{
					eventHandler = new EventHandler(this.method_3);
				}
				arg_A1_0.method_35(eventHandler);
				Class531 arg_BD_0 = this.class531_0;
				if (eventHandler2 == null)
				{
					eventHandler2 = new EventHandler(this.method_4);
				}
				arg_BD_0.method_37(eventHandler2);
				this.class531_0.bool_2 = true;
				this.class531_0.method_2(new EventHandler(this.method_2));
				this.class533_0 = new Class533(string.Empty, 12f, vector2_1 + new Vector2(20f, 0f), 0.9f, true, Color.get_White());
				this.class533_0.bool_16 = true;
				this.list_0.Add(this.class533_0);
				this.class533_1 = new Class533(string.Empty, 11f, vector2_1 + new Vector2(56f, 13f), 0.9f, true, Color.get_White());
				this.list_0.Add(this.class533_1);
				this.class533_2 = new Class533(string.Empty, 12f, vector2_1 + new Vector2(240f, 0f), 0.9f, true, Color.get_White());
				this.class533_2.bool_16 = true;
				this.list_0.Add(this.class533_2);
				this.class533_3 = new Class533(string.Empty, 11f, vector2_1 + new Vector2(240f, 11f), 0.9f, true, Color.get_White());
				this.list_0.Add(this.class533_3);
				this.class531_1 = new Class531(Class885.Load("lobby-lock", Enum112.flag_1), vector2_1 + new Vector2(3f, 5f), 0.895f, true, Color.get_TransparentWhite());
				this.list_0.Add(this.class531_1);
				this.class531_3 = new Class531(null, vector2_1 + new Vector2(0f, 3f), 0.894f, true, Color.get_White());
				this.list_0.Add(this.class531_3);
				Vector2 vector2_2 = vector2_1 + new Vector2(210f, 24f);
				this.class537_0 = new Class537(null, null, 200, vector2_2, 0.920001f);
				this.class531_2 = new Class531(Class885.Load("lobby-avatar", Enum112.flag_1), Origins.Centre, vector2_2, 0.92f, true, Class838.color_1);
				this.class531_2.float_3 = 1f;
				this.class531_2.float_2 = 1f;
				this.class531_2.bool_1 = true;
				Class531 arg_330_0 = this.class531_2;
				if (eventHandler3 == null)
				{
					eventHandler3 = new EventHandler(this.method_5);
				}
				arg_330_0.method_37(eventHandler3);
				this.class531_2.bool_2 = true;
				this.class531_2.method_2(new EventHandler(this.method_2));
				this.list_0.Add(this.class537_0);
				this.list_0.Add(this.class531_2);
				this.float_0 = ((Class115.bool_21 || !this.bMatch_0.method_9()) ? 1f : 0.75f);
				for (int i = 0; i < bMatch.smethod_0() - 1; i++)
				{
					vector2_2 = vector2_1 + new Vector2((float)i * 33f * this.float_0 + 251.4f, 34.4f);
					this.list_1.Add(new Class537(null, null, 200, vector2_2, 0.920001f));
					Class531 class = new Class531(Class885.Load("lobby-avatar", Enum112.flag_1), Origins.Centre, vector2_2, 0.92f, true, Color.get_TransparentWhite());
					class.float_3 = 0f;
					class.float_2 = 0.58f * this.float_0;
					class.bool_1 = true;
					Class531 arg_448_0 = class;
					if (eventHandler4 == null)
					{
						eventHandler4 = new EventHandler(this.method_6);
					}
					arg_448_0.method_37(eventHandler4);
					class.method_2(new EventHandler(this.method_2));
					class.bool_2 = true;
					this.list_2.Add(class);
				}
				this.list_0.AddRange(this.list_2);
				foreach (Class537 current in this.list_1)
				{
					this.list_0.Add(current);
				}
				this.list_0.Add(this.class531_0);
			}
			else
			{
				foreach (Class531 current2 in this.list_0)
				{
					Vector2 vector2_3 = vector2_1 + (current2.vector2_0 - this.vector2_0);
					current2.method_19(vector2_3, 500, Enum70.const_1);
				}
			}
			this.class531_1.method_8(!this.bMatch_0.method_0());
			float num = 0f;
			float num2 = 0f;
			float num3 = 1000f;
			float num4 = 0f;
			float num5 = 1000000f;
			float num6 = 0f;
			bool flag = false;
			int num7 = 0;
			int num8 = -1;
			for (int j = 0; j < bMatch.smethod_0(); j++)
			{
				VoidDelegate voidDelegate = null;
				Class838.Class839 class2 = new Class838.Class839();
				class2.class838_0 = this;
				int num9 = this.bMatch_0.slotId[j];
				Class531 class3;
				if (num9 != this.bMatch_0.hostId)
				{
					num8++;
					if (num8 >= this.list_1.Count)
					{
						break;
					}
					class2.class537_0 = this.list_1[num8];
					class3 = this.list_2[num8];
					if (this.bMatch_0.slotStatus[j] != SlotStatus.flag_1)
					{
						class3.method_8(false);
						if (this.bMatch_0.slotStatus[j] != SlotStatus.flag_0)
						{
							class3.bool_1 = true;
							class3.method_39(Class838.color_1, 200, false, Enum70.const_0);
							class3.method_25(1f, 200, Enum70.const_0);
						}
						else
						{
							class3.bool_1 = false;
							class3.method_39(Class838.color_0, 200, false, Enum70.const_0);
							class3.method_25(0.392156869f, 200, Enum70.const_0);
						}
					}
					else
					{
						class3.bool_1 = false;
						class3.method_39(Class838.color_2, 200, false, Enum70.const_0);
						class3.method_25(0.392156869f, 200, Enum70.const_0);
					}
				}
				else
				{
					class2.class537_0 = this.class537_0;
					class3 = this.class531_2;
				}
				if (num9 >= 0)
				{
					Class861 class4 = Class809.smethod_28(num9, true);
					if (class4 != null)
					{
						num += class4.float_0;
						num2 += (float)class4.int_3;
						if (class4.float_0 < num3)
						{
							num3 = class4.float_0;
						}
						if (class4.float_0 > num4)
						{
							num4 = class4.float_0;
						}
						if ((float)class4.int_3 < num5)
						{
							if (class4.int_3 == 0)
							{
								flag = true;
							}
							else
							{
								num5 = (float)class4.int_3;
							}
						}
						if ((float)class4.int_3 > num6)
						{
							num6 = (float)class4.int_3;
						}
						num7++;
						if (string.IsNullOrEmpty(class3.string_0) || class3.string_0.StartsWith(Class861.string_9))
						{
							class3.string_0 = string.Format(string.Concat(new object[]
							{
								class4.Name,
								" (#",
								class4.int_3,
								")\n",
								class4.string_5
							}), new object[0]);
						}
						if (class2.class537_0.object_0 != class4)
						{
							class2.class537_0.object_0 = class4;
							if (class4.method_3(class2.class537_0, ((class2.class537_0 == this.class537_0) ? 63f : 36f) * this.float_0))
							{
								Class537 arg_85F_0 = class2.class537_0;
								if (voidDelegate == null)
								{
									voidDelegate = new VoidDelegate(class2.method_0);
								}
								arg_85F_0.method_55(voidDelegate);
							}
						}
					}
				}
				else if (class2.class537_0.object_0 != null)
				{
					class3.string_0 = null;
					class2.class537_0.object_0 = null;
					class2.class537_0.vmethod_7(null);
					class2.class537_0.method_16(500, Enum70.const_0);
				}
			}
			num /= (float)num7;
			num2 /= (float)num7;
			switch (this.bMatch_0.playMode)
			{
			case PlayModes.Osu:
				this.class531_3.vmethod_7(Class885.Load("mode-osu-small", Enum112.flag_1));
				break;
			case PlayModes.Taiko:
				this.class531_3.vmethod_7(Class885.Load("mode-taiko-small", Enum112.flag_1));
				break;
			case PlayModes.CatchTheBeat:
				this.class531_3.vmethod_7(Class885.Load("mode-fruits-small", Enum112.flag_1));
				break;
			case PlayModes.OsuMania:
				this.class531_3.vmethod_7(Class885.Load("mode-mania-small", Enum112.flag_1));
				break;
			}
			bool flag2 = this.bool_1;
			if (this.string_0 != this.bMatch_0.beatmapChecksum)
			{
				this.bool_1 = (!string.IsNullOrEmpty(this.bMatch_0.beatmapChecksum) && Class466.smethod_25(this.bMatch_0.beatmapChecksum) != null);
				this.string_0 = this.bMatch_0.beatmapChecksum;
			}
			this.class531_0.bool_1 = true;
			if (flag2 != this.bool_1)
			{
				this.class531_0.color_0 = (this.bool_1 ? new Color(185, 64, 255, 25) : new Color(202, 202, 202, 25));
			}
			this.class533_0.color_0 = (this.bMatch_0.inProgress ? Color.get_Gray() : Color.get_White());
			this.class533_2.color_0 = (this.bMatch_0.inProgress ? Color.get_Gray() : Color.get_White());
			this.class533_0.Text = string.Format("{0} ({3})\r\n{1} / {2} ", new object[]
			{
				Class34.smethod_0(this.bMatch_0.playMode.ToString()),
				this.bMatch_0.method_1(),
				this.bMatch_0.method_3(),
				Class34.smethod_0(this.bMatch_0.matchTeamType.ToString())
			});
			if (flag)
			{
				this.class533_1.Text = "rank: " + string.Format((num6 > 0f) ? "{0:#,#} - ?" : " ?", num5, num6);
			}
			else
			{
				this.class533_1.Text = "rank: " + string.Format((num5 != num6) ? "{0:#,#} - {1:#,#}" : "{0:#,#}", num5, num6);
			}
			this.class533_2.Text = this.bMatch_0.gameName + " " + (this.bMatch_0.inProgress ? Class41.GetString(OsuString.LobbyMatch_InProgress) : string.Empty);
			this.class533_3.Text = (string.IsNullOrEmpty(this.bMatch_0.beatmapChecksum) ? Class41.GetString(OsuString.LobbyMatch_ChangingBeatmap) : string.Format("{0}{1}", Class876.smethod_11(this.bMatch_0.activeMods, true, true), this.bMatch_0.beatmapName));
			this.class533_3.color_0 = new Color(255, 215, 109);
			return result;
		}

		// Token: 0x06003143 RID: 12611
		// RVA: 0x00024656 File Offset: 0x00022856
		private void method_1()
		{
			if (!this.class531_0.rectangleF_0.Contains(Class800.smethod_15()))
			{
				this.class531_0.method_39(Class610.smethod_7(this.class531_0.color_0, 25), 100, false, Enum70.const_0);
			}
		}

		// Token: 0x06003144 RID: 12612
		// RVA: 0x001435B0 File Offset: 0x001417B0
		private void method_2(object sender, EventArgs e)
		{
			Class331.smethod_36(null, "click-short-confirm", 1f, false);
			Class70.smethod_5(this.bMatch_0, null);
		}

		// Token: 0x06003146 RID: 12614
		// RVA: 0x001435E4 File Offset: 0x001417E4
		[CompilerGenerated]
		private void method_3(object sender, EventArgs e)
		{
			this.class531_0.method_39(Class610.smethod_7(this.class531_0.color_0, 50), 100, false, Enum70.const_0);
			Class331.smethod_36(null, "click-short", 1f, false);
		}

		// Token: 0x06003147 RID: 12615
		// RVA: 0x000246AE File Offset: 0x000228AE
		[CompilerGenerated]
		private void method_4(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x06003148 RID: 12616
		// RVA: 0x000246AE File Offset: 0x000228AE
		[CompilerGenerated]
		private void method_5(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x06003149 RID: 12617
		// RVA: 0x000246AE File Offset: 0x000228AE
		[CompilerGenerated]
		private void method_6(object sender, EventArgs e)
		{
			this.method_1();
		}
	}
}
