using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns14;
using ns16;
using ns17;
using ns24;
using ns25;
using ns26;
using ns27;
using ns29;
using ns3;
using ns40;
using ns6;
using ns64;
using ns7;
using ns78;
using ns79;
using ns8;
using ns80;
using ns81;
using ns82;
using ns84;
using ns9;
using ns90;
using osu;
using osu.Graphics.Primitives;
using osu.Graphics.Sprites;
using osu_common;
using osu_common.Bancho.Objects;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns5
{
	// Token: 0x020004DD RID: 1245
	internal sealed class Class70 : Class61
	{
		// Token: 0x020004DE RID: 1246
		[CompilerGenerated]
		private sealed class Class646
		{
			// Token: 0x0400214F RID: 8527
			public PlayModes playModes_0;

			// Token: 0x06002836 RID: 10294
			// RVA: 0x000FAE68 File Offset: 0x000F9068
			public bool method_0(Class838 class838_0)
			{
				bMatch bMatch_ = class838_0.bMatch_0;
				return !bMatch_.method_0() && !bMatch_.inProgress && bMatch_.method_4() != 0 && (Class341.class608_14.Value == -1 || bMatch_.playMode == this.playModes_0);
			}
		}

		// Token: 0x020004DF RID: 1247
		[CompilerGenerated]
		private sealed class Class647
		{
			// Token: 0x04002150 RID: 8528
			public Class10 class10_0;

			// Token: 0x06002838 RID: 10296
			// RVA: 0x0001F054 File Offset: 0x0001D254
			public bool method_0(Class838 class838_0)
			{
				return class838_0.bMatch_0.matchId == this.class10_0.matchId;
			}
		}

		// Token: 0x020004E0 RID: 1248
		[CompilerGenerated]
		private sealed class Class648
		{
			// Token: 0x04002151 RID: 8529
			public int int_0;

			// Token: 0x0600283A RID: 10298
			// RVA: 0x0001F06E File Offset: 0x0001D26E
			public bool method_0(Class838 class838_0)
			{
				return class838_0.bMatch_0.matchId == this.int_0;
			}
		}

		// Token: 0x0400214D RID: 8525
		[CompilerGenerated]
		private static Action<Class531> action_0;

		// Token: 0x0400214E RID: 8526
		[CompilerGenerated]
		private static Action<Class531> action_1;

		// Token: 0x04002135 RID: 8501
		internal static bool bool_2;

		// Token: 0x0400213A RID: 8506
		internal static bool bool_3;

		// Token: 0x0400213E RID: 8510
		private static bool bool_4;

		// Token: 0x04002138 RID: 8504
		private readonly Class110 class110_0 = new Class110(new Rectangle(0, 75, Class115.smethod_43(), 216), Vector2.get_Zero(), true, 0f, Enum98.const_2);

		// Token: 0x0400213B RID: 8507
		private Class533 class533_0;

		// Token: 0x04002143 RID: 8515
		private Class533 class533_1;

		// Token: 0x0400213F RID: 8511
		private Class592 class592_0;

		// Token: 0x04002147 RID: 8519
		private Class754 class754_0;

		// Token: 0x04002140 RID: 8512
		private Class762 class762_0;

		// Token: 0x04002141 RID: 8513
		private Class762 class762_1;

		// Token: 0x04002142 RID: 8514
		private Class762 class762_2;

		// Token: 0x04002145 RID: 8517
		private Class762 class762_3;

		// Token: 0x04002146 RID: 8518
		private Class762 class762_4;

		// Token: 0x04002139 RID: 8505
		private Class911 class911_1;

		// Token: 0x04002144 RID: 8516
		private Class911 class911_2;

		// Token: 0x04002148 RID: 8520
		[CompilerGenerated]
		private static Delegate38 delegate38_0;

		// Token: 0x04002149 RID: 8521
		[CompilerGenerated]
		private static Delegate38 delegate38_1;

		// Token: 0x0400214A RID: 8522
		[CompilerGenerated]
		private static Delegate38 delegate38_2;

		// Token: 0x0400214B RID: 8523
		[CompilerGenerated]
		private static Delegate38 delegate38_3;

		// Token: 0x0400214C RID: 8524
		[CompilerGenerated]
		private static Delegate38 delegate38_4;

		// Token: 0x04002137 RID: 8503
		internal static Enum59 enum59_0;

		// Token: 0x04002136 RID: 8502
		internal static List<Class838> list_0 = new List<Class838>();

		// Token: 0x0400213C RID: 8508
		private string string_0;

		// Token: 0x0400213D RID: 8509
		private string string_1;

		// Token: 0x06002818 RID: 10264
		// RVA: 0x0001EEDB File Offset: 0x0001D0DB
		public Class70(Class114 class114_1) : base(class114_1)
		{
		}

		// Token: 0x06002820 RID: 10272
		// RVA: 0x000FA5E4 File Offset: 0x000F87E4
		protected override void Dispose(bool bool_5)
		{
			Class570.smethod_5(new Class570.Delegate45(this.method_2));
			Class809.smethod_9(new VoidDelegate(this.method_1));
			Class70.smethod_1(false);
			this.class911_1.Dispose();
			this.class911_2.Dispose();
			this.class110_0.Dispose();
			Class70.list_0.Clear();
			this.class754_0.Dispose();
			base.Dispose(bool_5);
		}

		// Token: 0x06002822 RID: 10274
		// RVA: 0x0001EF4D File Offset: 0x0001D14D
		public override void Draw()
		{
			this.class911_1.Draw();
			this.class911_2.Draw();
			this.class110_0.Draw();
			base.Draw();
		}

		// Token: 0x06002823 RID: 10275
		// RVA: 0x000FA658 File Offset: 0x000F8858
		public override void imethod_2()
		{
			if (!Class809.bool_4 && Class115.enum113_0 == Enum113.const_2)
			{
				Class115.smethod_70(OsuModes.Menu, false);
				Class723.smethod_4(Class41.GetString(OsuString.Lobby_Bancho_Fail));
			}
			this.class911_1.float_1 = ((Enum59.const_1 != Class70.enum59_0) ? 0.6f : 0f);
			if (Class70.bool_2)
			{
				int num = 0;
				lock (Class70.list_0)
				{
					Class70.list_0.Sort();
					int num2 = 0;
					foreach (Class838 current in Class70.list_0)
					{
						if (this.method_6(current))
						{
							num2++;
							bool flag;
							if ((flag = current.method_0(new Vector2(3f, (float)num))) || current.bool_0)
							{
								List<Class531> arg_D1_0 = current.list_0;
								if (Class70.action_0 == null)
								{
									Class70.action_0 = new Action<Class531>(Class70.smethod_13);
								}
								arg_D1_0.ForEach(Class70.action_0);
							}
							if (flag)
							{
								this.class110_0.class911_0.Add<Class531>(current.list_0);
							}
							current.bool_0 = false;
							num += 49;
						}
						else if (!current.bool_0)
						{
							if (current.list_0 != null)
							{
								List<Class531> arg_130_0 = current.list_0;
								if (Class70.action_1 == null)
								{
									Class70.action_1 = new Action<Class531>(Class70.smethod_14);
								}
								arg_130_0.ForEach(Class70.action_1);
							}
							current.bool_0 = true;
						}
					}
					this.class533_1.Text = string.Format(Class41.GetString(OsuString.Lobby_FilteredMatches), num2, Class70.list_0.Count);
					if (num2 > 0)
					{
						this.class533_0.method_16(50, Enum70.const_0);
					}
					else
					{
						this.class533_0.Text = (Class809.bool_6 ? this.string_0 : this.string_1);
						this.class533_0.method_14(50, Enum70.const_0);
					}
				}
				this.class110_0.method_14(new Vector2(640f, (float)(num + 50)));
				Class70.bool_2 = false;
			}
			this.class110_0.imethod_2();
			base.imethod_2();
		}

		// Token: 0x06002819 RID: 10265
		// RVA: 0x000F9B80 File Offset: 0x000F7D80
		public override void Initialize()
		{
			Class72.class10_0 = null;
			Class858.smethod_4(false);
			this.string_0 = Class41.GetString(OsuString.Lobby_NoMatch);
			this.string_1 = Class41.GetString(OsuString.General_Loading);
			this.class911_1 = new Class911(true);
			this.class911_2 = new Class911(true);
			this.class911_2.method_18(new RectangleF(0f, 40f, 640f, 35f));
			Class809.smethod_8(new VoidDelegate(this.method_1));
			Class570.smethod_4(new Class570.Delegate45(this.method_2));
			Class533 class530_ = new Class533(Class41.GetString(OsuString.Lobby_Header), 24f, new Vector2(0f, 0f), 0.955f, true, new Color(255, 255, 255, 255));
			this.class911_1.Add(class530_);
			this.class533_1 = new Class533(this.string_1, 12f, new Vector2(170f, 8f), 0.955f, true, new Color(255, 255, 255, 255));
			this.class911_1.Add(this.class533_1);
			Class531 class = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(0f, 40f), 0.1f, true, new Color(0, 0, 0, 180), null);
			class.float_2 = 1.6f;
			class.vector2_2 = new Vector2((float)Class115.smethod_43(), 281f);
			this.class911_1.Add(class);
			Class760 class2 = new Class760(Class41.GetString(OsuString.Lobby_NewGame), new Vector2((float)(Class115.smethod_43() / 2 - 100), 293f), new Vector2(200f, 25f), 0.92f, new Color(99, 139, 228), new EventHandler(this.method_4), true, false, null);
			this.class911_1.Add<Class531>(class2.list_0);
			class2 = new Class760(Class41.GetString(OsuString.Lobby_QuickJoin), new Vector2((float)(Class115.smethod_43() / 2 + 110), 293f), new Vector2(200f, 25f), 0.92f, Color.get_YellowGreen(), new EventHandler(this.method_3), true, false, null);
			this.class911_1.Add<Class531>(class2.list_0);
			class2 = new Class760(Class41.GetString(OsuString.Lobby_BackToMenu), new Vector2((float)(Class115.smethod_43() / 2 - 310), 293f), new Vector2(200f, 25f), 0.92f, new Color(235, 160, 62), new EventHandler(this.method_5), true, false, null);
			this.class911_1.Add<Class531>(class2.list_0);
			this.class533_0 = new Class533(this.string_1, 18f, new Vector2((float)(Class115.smethod_43() / 2), 180f), new Vector2(400f, 0f), 1f, true, Color.get_White(), false);
			this.class533_0.bool_16 = true;
			this.class533_0.float_3 = 0f;
			this.class533_0.enum72_0 = Enum72.const_2;
			this.class533_0.origins_0 = Origins.Centre;
			this.class911_1.Add(this.class533_0);
			this.class592_0 = new Class592(this.class911_1, 6, new Vector2(50f, 40f), 0.98f, false, Color.get_Crimson(), 0, false);
			this.class592_0.Add(Class41.GetString(OsuString.Lobby_All), -1, false);
			this.class592_0.Add(Class213.smethod_0(PlayModes.Osu), 0, false);
			this.class592_0.Add(Class213.smethod_0(PlayModes.Taiko), 1, false);
			this.class592_0.Add(Class213.smethod_0(PlayModes.CatchTheBeat), 2, false);
			this.class592_0.Add(Class213.smethod_0(PlayModes.OsuMania), 3, false);
			this.class592_0.method_3(Class341.class608_14.Value, true, false);
			this.class592_0.method_0(new EventHandler(this.method_7));
			this.class762_2 = new Class762(Class41.GetString(OsuString.Lobby_ExistMapOnly), 0.8f, new Vector2(5f, 2f), 1f, Class341.class606_36, 0f);
			this.class911_2.Add<Class531>(this.class762_2.list_0);
			Class762 arg_4BC_0 = this.class762_2;
			if (Class70.delegate38_0 == null)
			{
				Class70.delegate38_0 = new Delegate38(Class70.smethod_8);
			}
			arg_4BC_0.method_8(Class70.delegate38_0);
			this.class762_3 = new Class762(Class41.GetString(OsuString.Lobby_FriendOnly), 0.8f, new Vector2(5f, 19f), 1f, Class341.class606_37, 0f);
			this.class911_2.Add<Class531>(this.class762_3.list_0);
			Class762 arg_537_0 = this.class762_3;
			if (Class70.delegate38_1 == null)
			{
				Class70.delegate38_1 = new Delegate38(Class70.smethod_9);
			}
			arg_537_0.method_8(Class70.delegate38_1);
			this.class762_4 = new Class762(Class41.GetString(OsuString.Lobby_InProgress), 0.8f, new Vector2(360f, 19f), 1f, Class341.class606_39, 0f);
			this.class911_2.Add<Class531>(this.class762_4.list_0);
			Class762 arg_5B2_0 = this.class762_4;
			if (Class70.delegate38_2 == null)
			{
				Class70.delegate38_2 = new Delegate38(Class70.smethod_10);
			}
			arg_5B2_0.method_8(Class70.delegate38_2);
			this.class762_0 = new Class762(Class41.GetString(OsuString.Lobby_ShowFull), 0.8f, new Vector2(180f, 2f), 1f, Class341.class606_38, 0f);
			this.class911_2.Add<Class531>(this.class762_0.list_0);
			Class762 arg_62D_0 = this.class762_0;
			if (Class70.delegate38_3 == null)
			{
				Class70.delegate38_3 = new Delegate38(Class70.smethod_11);
			}
			arg_62D_0.method_8(Class70.delegate38_3);
			this.class762_1 = new Class762(Class41.GetString(OsuString.Lobby_ShowLocked), 0.8f, new Vector2(180f, 19f), 1f, Class341.class606_40, 0f);
			this.class911_2.Add<Class531>(this.class762_1.list_0);
			Class762 arg_6A8_0 = this.class762_1;
			if (Class70.delegate38_4 == null)
			{
				Class70.delegate38_4 = new Delegate38(Class70.smethod_12);
			}
			arg_6A8_0.method_8(Class70.delegate38_4);
			Class533 class3 = new Class533(Class41.GetString(OsuString.Lobby_Search), 14f, new Vector2(360f, 2f), 1f, true, Color.get_White());
			this.class911_2.Add(class3);
			this.class754_0 = new Class754(string.Empty, 14, new Vector2(360f + class3.vmethod_11().X, 2f), 134f, 1f, false);
			this.class754_0.int_0 = 20;
			this.class754_0.method_3(new Class754.Delegate37(this.method_8));
			this.class911_2.Add<Class531>(this.class754_0.list_0);
			base.Initialize();
			if (Class466.Current == null || string.IsNullOrEmpty(Class466.Current.string_4) || !Class466.Current.bool_4)
			{
				Class109.smethod_3(true, false);
			}
			Class70.smethod_0();
			Class70.bool_2 = true;
			if (!Class111.bool_2)
			{
				if (Class111.bool_1)
				{
					Class111.smethod_19();
				}
				Class111.smethod_21(false);
			}
		}

		// Token: 0x0600281A RID: 10266
		// RVA: 0x0001EF0D File Offset: 0x0001D10D
		private void method_1()
		{
			Class70.smethod_0();
		}

		// Token: 0x0600281B RID: 10267
		// RVA: 0x000FA340 File Offset: 0x000F8540
		private bool method_2(object object_0, Keys keys_0, bool bool_5)
		{
			if (!bool_5)
			{
				return false;
			}
			if (keys_0 == 27)
			{
				this.method_5(null, null);
				return true;
			}
			return false;
		}

		// Token: 0x0600281C RID: 10268
		// RVA: 0x000FA364 File Offset: 0x000F8564
		private void method_3(object sender, EventArgs e)
		{
			Predicate<Class838> predicate = null;
			Class70.Class646 class = new Class70.Class646();
			class.playModes_0 = (PlayModes)Class341.class608_14.Value;
			List<Class838> list = null;
			lock (Class70.list_0)
			{
				List<Class838> arg_44_0 = Class70.list_0;
				if (predicate == null)
				{
					predicate = new Predicate<Class838>(class.method_0);
				}
				list = arg_44_0.FindAll(predicate);
			}
			if (list.Count <= 0)
			{
				Class723.smethod_5(Class41.GetString(OsuString.Lobby_QuickJoin_Fail), Color.get_Red(), 1500, null);
				return;
			}
			List<bMatch> list2 = new List<bMatch>();
			for (int i = 0; i < list.Count; i++)
			{
				bMatch bMatch_ = list[i].bMatch_0;
				int num = 0;
				int num2 = 0;
				for (int j = 0; j < bMatch_.slotId.Length; j++)
				{
					if (bMatch_.slotId[j] > 0)
					{
						Class861 class2 = Class809.smethod_28(bMatch_.slotId[j], true);
						if (class2 != null)
						{
							num2++;
							num += class2.int_3;
						}
					}
				}
				int num3 = num / Math.Max(1, num2);
				if ((double)Math.Abs(num3 - Class115.class861_0.int_3) < (double)Class115.class861_0.int_3 * 0.3)
				{
					list2.Add(bMatch_);
				}
			}
			if (list2.Count > 5)
			{
				int index = Class562.smethod_0(list2.Count);
				Class70.smethod_5(list2[index], null);
				return;
			}
			int index2 = Class562.smethod_0(list.Count);
			Class70.smethod_5(list[index2].bMatch_0, null);
		}

		// Token: 0x0600281D RID: 10269
		// RVA: 0x000FA4FC File Offset: 0x000F86FC
		private void method_4(object sender, EventArgs e)
		{
			if (!Class809.bool_4)
			{
				Class723.smethod_4(Class41.GetString(OsuString.Lobby_LoginFirst));
				return;
			}
			if (Class70.enum59_0 == Enum59.const_3)
			{
				return;
			}
			if (Class466.list_3.Count == 0)
			{
				Class723.smethod_4(Class41.GetString(OsuString.Lobby_NoBeatmapsAvailable));
				return;
			}
			if (Class466.Current == null)
			{
				Class466.smethod_21(Class466.list_3[0]);
			}
			Class97 class89_ = new Class97();
			Class115.smethod_37(class89_);
		}

		// Token: 0x06002821 RID: 10273
		// RVA: 0x00019F21 File Offset: 0x00018121
		private void method_5(object sender, EventArgs e)
		{
			Class331.smethod_60("menuback", 1f, Enum112.flag_5);
			Class115.smethod_70(OsuModes.Menu, false);
		}

		// Token: 0x06002824 RID: 10276
		// RVA: 0x000FA8A0 File Offset: 0x000F8AA0
		private bool method_6(Class838 class838_0)
		{
			bool flag = this.class754_0.class533_0.Text.Length > 0;
			if (Class341.class608_14.Value >= 0 && class838_0.bMatch_0.playMode != (PlayModes)Class341.class608_14.Value && !flag)
			{
				return false;
			}
			if (!this.class762_0.method_2() && class838_0.bMatch_0.method_4() == 0 && !flag)
			{
				return false;
			}
			if (!this.class762_4.method_2() && class838_0.bMatch_0.inProgress)
			{
				return false;
			}
			if (this.class762_3.method_2())
			{
				bool flag2 = false;
				for (int i = 0; i < 16; i++)
				{
					if (class838_0.bMatch_0.slotId[i] >= 0)
					{
						Class861 class = Class809.smethod_28(class838_0.bMatch_0.slotId[i], true);
						if (class != null && class.bool_3)
						{
							flag2 = true;
							IL_CC:
							if (!flag2)
							{
								return false;
							}
							goto IL_D1;
						}
					}
				}
				goto IL_CC;
			}
			IL_D1:
			if (!this.class762_1.method_2() && class838_0.bMatch_0.method_0() && !flag)
			{
				return false;
			}
			if (Class341.class606_36 && Class466.smethod_25(class838_0.bMatch_0.beatmapChecksum) == null && !flag)
			{
				return false;
			}
			if (flag)
			{
				string value = this.class754_0.class533_0.Text.ToLower();
				bool result = false;
				if (class838_0.bMatch_0.gameName.ToLower().Contains(value))
				{
					result = true;
				}
				else if (class838_0.bMatch_0.beatmapName.ToLower().Contains(value))
				{
					result = true;
				}
				else
				{
					for (int j = 0; j < 8; j++)
					{
						if (class838_0.bMatch_0.slotId[j] >= 0)
						{
							Class861 class2 = Class809.smethod_28(class838_0.bMatch_0.slotId[j], true);
							if (class2 != null && class2.Name.ToLower().Contains(value))
							{
								result = true;
								break;
							}
						}
					}
				}
				return result;
			}
			return true;
		}

		// Token: 0x0600282B RID: 10283
		// RVA: 0x0001EFB4 File Offset: 0x0001D1B4
		[CompilerGenerated]
		private void method_7(object sender, EventArgs e)
		{
			Class341.class608_14.Value = (int)this.class592_0.class750_1.object_0;
			Class70.bool_2 = true;
		}

		// Token: 0x06002831 RID: 10289
		// RVA: 0x000FADB8 File Offset: 0x000F8FB8
		[CompilerGenerated]
		private void method_8(Class754 class754_1, bool bool_5)
		{
			Class70.bool_2 = true;
			if (this.class754_0.Text.Length > 0)
			{
				this.class762_3.method_9();
				this.class762_0.method_9();
				this.class762_1.method_9();
				this.class762_2.method_9();
				this.class592_0.method_3(-1, true, false);
				return;
			}
			this.class762_3.method_11();
			this.class762_0.method_11();
			this.class762_1.method_11();
			this.class762_2.method_11();
			this.class592_0.method_3(Class341.class608_14.Value, true, false);
		}

		// Token: 0x0600281E RID: 10270
		// RVA: 0x0001EF14 File Offset: 0x0001D114
		internal static void smethod_0()
		{
			if (Class70.bool_4)
			{
				return;
			}
			Class70.bool_4 = true;
			Class70.list_0.Clear();
			Class70.enum59_0 = Enum59.const_1;
			Class809.smethod_34(Enum3.const_30, null);
			Class111.smethod_40(Class111.smethod_8("#lobby", false, true));
		}

		// Token: 0x0600281F RID: 10271
		// RVA: 0x000FA568 File Offset: 0x000F8768
		internal static void smethod_1(bool bool_5)
		{
			if (!Class70.bool_4)
			{
				return;
			}
			Class70.bool_4 = false;
			Class70.list_0.Clear();
			Class809.smethod_34(Enum3.const_29, null);
			if (Class70.enum59_0 == Enum59.const_1)
			{
				Class111.smethod_10("#lobby");
				if (!Class70.bool_3 && Class111.bool_2)
				{
					Class111.smethod_21(true);
				}
				Class70.enum59_0 = Enum59.const_0;
			}
			if (bool_5)
			{
				Class331.smethod_60("menuback", 1f, Enum112.flag_5);
				Class70.enum59_0 = Enum59.const_0;
				Class115.smethod_70(OsuModes.Menu, false);
			}
		}

		// Token: 0x0600282E RID: 10286
		// RVA: 0x0001F001 File Offset: 0x0001D201
		[CompilerGenerated]
		private static void smethod_10(object object_0, bool bool_5)
		{
			Class341.class606_39.Value = bool_5;
			Class70.bool_2 = true;
		}

		// Token: 0x0600282F RID: 10287
		// RVA: 0x0001F014 File Offset: 0x0001D214
		[CompilerGenerated]
		private static void smethod_11(object object_0, bool bool_5)
		{
			Class341.class606_38.Value = bool_5;
			Class70.bool_2 = true;
		}

		// Token: 0x06002830 RID: 10288
		// RVA: 0x0001F027 File Offset: 0x0001D227
		[CompilerGenerated]
		private static void smethod_12(object object_0, bool bool_5)
		{
			Class341.class606_40.Value = bool_5;
			Class70.bool_2 = true;
		}

		// Token: 0x06002832 RID: 10290
		// RVA: 0x0001F03A File Offset: 0x0001D23A
		[CompilerGenerated]
		private static void smethod_13(Class531 class531_0)
		{
			class531_0.method_15(500);
		}

		// Token: 0x06002833 RID: 10291
		// RVA: 0x00017922 File Offset: 0x00015B22
		[CompilerGenerated]
		private static void smethod_14(Class531 class531_0)
		{
			class531_0.method_16(300, Enum70.const_0);
		}

		// Token: 0x06002825 RID: 10277
		// RVA: 0x000FAA78 File Offset: 0x000F8C78
		public static void smethod_2(Class10 class10_0)
		{
			Predicate<Class838> predicate = null;
			Class70.Class647 class = new Class70.Class647();
			class.class10_0 = class10_0;
			if (Class72.class10_0 != null && Class72.class10_0.matchId == class.class10_0.matchId)
			{
				Class72.smethod_1(class.class10_0);
			}
			lock (Class70.list_0)
			{
				List<Class838> arg_5A_0 = Class70.list_0;
				if (predicate == null)
				{
					predicate = new Predicate<Class838>(class.method_0);
				}
				int num = arg_5A_0.FindIndex(predicate);
				if (num < 0)
				{
					Class70.list_0.Add(new Class838(class.class10_0));
				}
				else
				{
					Class70.list_0[num].bMatch_0 = class.class10_0;
				}
			}
			Class70.bool_2 = true;
		}

		// Token: 0x06002826 RID: 10278
		// RVA: 0x000FAB38 File Offset: 0x000F8D38
		public static void smethod_3(int int_2)
		{
			Predicate<Class838> predicate = null;
			Class70.Class648 class = new Class70.Class648();
			class.int_0 = int_2;
			if (Class72.class10_0 != null && Class72.class10_0.matchId == class.int_0)
			{
				Class72.smethod_2();
			}
			lock (Class70.list_0)
			{
				List<Class838> arg_54_0 = Class70.list_0;
				if (predicate == null)
				{
					predicate = new Predicate<Class838>(class.method_0);
				}
				List<Class838> list = arg_54_0.FindAll(predicate);
				foreach (Class838 current in list)
				{
					if (current.list_0 != null)
					{
						foreach (Class531 current2 in current.list_0)
						{
							current2.method_16(50, Enum70.const_0);
							current2.bool_0 = false;
						}
					}
					lock (Class70.list_0)
					{
						Class70.list_0.Remove(current);
					}
				}
			}
			Class70.bool_2 = true;
		}

		// Token: 0x06002827 RID: 10279
		// RVA: 0x000FAC7C File Offset: 0x000F8E7C
		public static void smethod_4(int int_2, string string_2)
		{
			if (Class70.enum59_0 == Enum59.const_2)
			{
				return;
			}
			Class723.smethod_1(Class41.GetString(OsuString.Lobby_Join), 1500);
			Class809.smethod_34(Enum3.const_32, new Struct15(int_2, string_2 ?? Class72.class10_0.gamePassword));
			Class70.enum59_0 = Enum59.const_2;
		}

		// Token: 0x06002828 RID: 10280
		// RVA: 0x000FACD0 File Offset: 0x000F8ED0
		public static void smethod_5(bMatch bMatch_0, string string_2)
		{
			if (Class70.enum59_0 == Enum59.const_2)
			{
				return;
			}
			if (bMatch_0.method_3() > bMatch_0.method_1())
			{
				if (Class70.enum59_0 == Enum59.const_1)
				{
					if (bMatch_0.method_0() && string.IsNullOrEmpty(string_2))
					{
						Class96 class89_ = new Class96(bMatch_0);
						Class115.smethod_37(class89_);
						return;
					}
					goto IL_5C;
				}
			}
			Class723.smethod_4(Class41.GetString(OsuString.Lobby_MatchFull));
			Class331.smethod_59("match-leave", 100, Enum112.flag_5);
			IL_5C:
			Class72.class10_0 = new Class10(bMatch_0);
			if (string_2 != null)
			{
				Class72.class10_0.gamePassword = string_2;
			}
			Class70.smethod_4(bMatch_0.matchId, string_2);
		}

		// Token: 0x06002829 RID: 10281
		// RVA: 0x0001EF78 File Offset: 0x0001D178
		public static void smethod_6()
		{
			Class72.class10_0 = null;
			Class723.smethod_1(Class41.GetString(OsuString.Lobby_Join_Fail), 2000);
			Class331.smethod_59("match-leave", 100, Enum112.flag_5);
			Class70.enum59_0 = ((Class115.osuModes_1 == OsuModes.Lobby) ? Enum59.const_1 : Enum59.const_0);
		}

		// Token: 0x0600282A RID: 10282
		// RVA: 0x000FAD60 File Offset: 0x000F8F60
		public static void smethod_7()
		{
			Class331.smethod_59("match-join", 100, Enum112.flag_5);
			switch (Class70.enum59_0)
			{
			case Enum59.const_2:
				Class72.bool_4 = false;
				Class70.enum59_0 = Enum59.const_4;
				break;
			case Enum59.const_3:
				Class72.bool_4 = true;
				Class70.enum59_0 = Enum59.const_4;
				break;
			}
			Class115.smethod_70(OsuModes.MatchSetup, true);
		}

		// Token: 0x0600282C RID: 10284
		// RVA: 0x0001EFDB File Offset: 0x0001D1DB
		[CompilerGenerated]
		private static void smethod_8(object object_0, bool bool_5)
		{
			Class341.class606_36.Value = bool_5;
			Class70.bool_2 = true;
		}

		// Token: 0x0600282D RID: 10285
		// RVA: 0x0001EFEE File Offset: 0x0001D1EE
		[CompilerGenerated]
		private static void smethod_9(object object_0, bool bool_5)
		{
			Class341.class606_37.Value = bool_5;
			Class70.bool_2 = true;
		}
	}
}
