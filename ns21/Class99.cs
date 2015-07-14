using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns14;
using ns24;
using ns27;
using ns29;
using ns30;
using ns40;
using ns6;
using ns64;
using ns76;
using ns77;
using ns79;
using ns8;
using ns80;
using ns82;
using ns84;
using ns90;
using osu;
using osu.Graphics.Sprites;
using osu_common;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace ns21
{
	// Token: 0x02000516 RID: 1302
	internal sealed class Class99 : Class89
	{
		// Token: 0x02000517 RID: 1303
		[CompilerGenerated]
		private sealed class Class683
		{
			// Token: 0x040022D6 RID: 8918
			public Class99 class99_0;

			// Token: 0x040022D4 RID: 8916
			public Dictionary<string, string> dictionary_0;

			// Token: 0x040022D5 RID: 8917
			public Dictionary<string, string> dictionary_1;

			// Token: 0x06002A23 RID: 10787
			// RVA: 0x00020520 File Offset: 0x0001E720
			public void method_0(object sender, EventArgs e)
			{
				Class115.smethod_90("http://osu.ppy.sh/p/chart/?ch=" + this.dictionary_1["chartId"], null);
			}

			// Token: 0x06002A24 RID: 10788
			// RVA: 0x00020542 File Offset: 0x0001E742
			public void method_1(object sender, EventArgs e)
			{
				Class115.smethod_90("http://osu.ppy.sh/b/" + this.dictionary_0["beatmapId"] + "&ch=" + this.dictionary_1["chartId"], null);
			}
		}

		// Token: 0x02000518 RID: 1304
		[CompilerGenerated]
		private sealed class Class684
		{
			// Token: 0x040022D9 RID: 8921
			private static Action<Class530> action_0;

			// Token: 0x040022DA RID: 8922
			private static Action<Class530> action_1;

			// Token: 0x040022D7 RID: 8919
			public Class99.Class683 class683_0;

			// Token: 0x040022D8 RID: 8920
			public int int_0;

			// Token: 0x06002A26 RID: 10790
			// RVA: 0x0010FEB8 File Offset: 0x0010E0B8
			public void method_0(object sender, EventArgs e)
			{
				List<Class530> arg_47_0 = this.class683_0.class99_0.class911_0.method_11("chart" + this.int_0);
				if (Class99.Class684.action_0 == null)
				{
					Class99.Class684.action_0 = new Action<Class530>(Class99.Class684.smethod_0);
				}
				arg_47_0.ForEach(Class99.Class684.action_0);
				Class533 class = sender as Class533;
				class.int_7 = 1;
				class.method_55(Color.get_White());
				class.bool_18 = true;
			}

			// Token: 0x06002A27 RID: 10791
			// RVA: 0x0010FF34 File Offset: 0x0010E134
			public void method_1(object sender, EventArgs e)
			{
				List<Class530> arg_47_0 = this.class683_0.class99_0.class911_0.method_11("chart" + this.int_0);
				if (Class99.Class684.action_1 == null)
				{
					Class99.Class684.action_1 = new Action<Class530>(Class99.Class684.smethod_1);
				}
				arg_47_0.ForEach(Class99.Class684.action_1);
				Class533 class = sender as Class533;
				class.int_7 = 0;
				class.bool_18 = true;
			}

			// Token: 0x06002A28 RID: 10792
			// RVA: 0x00020579 File Offset: 0x0001E779
			private static void smethod_0(Class530 class530_0)
			{
				class530_0.method_25(1f, 100, Enum70.const_1);
			}

			// Token: 0x06002A29 RID: 10793
			// RVA: 0x00020589 File Offset: 0x0001E789
			private static void smethod_1(Class530 class530_0)
			{
				class530_0.method_25(0.9f, 100, Enum70.const_2);
			}
		}

		// Token: 0x02000519 RID: 1305
		[CompilerGenerated]
		private sealed class Class685
		{
			// Token: 0x040022DB RID: 8923
			public Class99 class99_0;

			// Token: 0x040022DC RID: 8924
			public string[] string_0;
		}

		// Token: 0x0200051A RID: 1306
		[CompilerGenerated]
		private sealed class Class686
		{
			// Token: 0x040022DF RID: 8927
			public Class531 class531_0;

			// Token: 0x040022DD RID: 8925
			public Class99.Class685 class685_0;

			// Token: 0x040022E0 RID: 8928
			public int int_0;

			// Token: 0x040022DE RID: 8926
			public Vector2 vector2_0;

			// Token: 0x06002A2C RID: 10796
			// RVA: 0x0010FFA4 File Offset: 0x0010E1A4
			public void method_0(byte[] byte_0, Exception exception_0)
			{
				if (exception_0 != null)
				{
					return;
				}
				int num = this.class685_0.class99_0.method_1();
				Class731 class731_ = Class731.smethod_3(new MemoryStream(byte_0)
				{
					Position = 0L
				}, this.class685_0.string_0[this.int_0]);
				Class885.smethod_35(class731_);
				this.class685_0.class99_0.list_1[this.int_0].vmethod_7(class731_);
				this.class531_0 = new Class531(class731_, Origins.Centre, this.vector2_0, 0.96f + (float)this.int_0 * 0.001f, true, Color.get_TransparentWhite());
				this.class531_0.bool_7 = true;
				this.class531_0.class26_0.Add(new Class746(TransformationType.Scale, 1f, 2f, num + this.int_0 * 200, num + this.int_0 * 200 + 400, Enum70.const_0));
				this.class531_0.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, num + this.int_0 * 200, num + this.int_0 * 200 + 400, Enum70.const_0));
				this.class685_0.class99_0.vmethod_1(this.class531_0);
			}
		}

		// Token: 0x040022D3 RID: 8915
		[CompilerGenerated]
		private static Action<Class531> action_2;

		// Token: 0x040022C5 RID: 8901
		private readonly bool bool_5;

		// Token: 0x040022CA RID: 8906
		private bool bool_6;

		// Token: 0x040022CC RID: 8908
		private bool bool_7;

		// Token: 0x040022CF RID: 8911
		private bool bool_8;

		// Token: 0x040022C7 RID: 8903
		private readonly Class512 class512_0;

		// Token: 0x040022C8 RID: 8904
		private readonly Class531[] class531_1 = new Class531[10];

		// Token: 0x040022C4 RID: 8900
		private readonly Class533 class533_0;

		// Token: 0x040022C6 RID: 8902
		private readonly Class533 class533_1;

		// Token: 0x040022C3 RID: 8899
		private readonly Class754 class754_0;

		// Token: 0x040022CD RID: 8909
		private Class760 class760_0;

		// Token: 0x040022C1 RID: 8897
		private readonly Class762 class762_0;

		// Token: 0x040022CB RID: 8907
		internal Class762 class762_1;

		// Token: 0x040022D2 RID: 8914
		[CompilerGenerated]
		private static Class133.Delegate17 delegate17_0;

		// Token: 0x040022D1 RID: 8913
		[CompilerGenerated]
		private static EventHandler eventHandler_4;

		// Token: 0x040022C2 RID: 8898
		private readonly int int_1;

		// Token: 0x040022C9 RID: 8905
		private readonly int int_2;

		// Token: 0x040022CE RID: 8910
		private int int_3 = -1;

		// Token: 0x040022D0 RID: 8912
		private List<Class531> list_1;

		// Token: 0x06002A0F RID: 10767
		// RVA: 0x0010CD38 File Offset: 0x0010AF38
		public Class99(Class73 class73_0) : base("", true)
		{
			this.class512_0 = class73_0.class512_0;
			this.int_1 = Class908.smethod_2(this.class512_0, true, true);
			if (Class341.class605_20.Value.Length > 0)
			{
				string string_ = string.Concat(new string[]
				{
					"http://osu.ppy.sh/web/osu-rate.php?u=",
					Class341.class605_20,
					"&p=",
					Class341.class605_17,
					"&c=",
					Class466.Current.string_3
				});
				Class133 class = new Class133(string_);
				class.method_0(new Class133.Delegate17(this.method_16));
				Class169.smethod_0(class);
			}
			this.int_2 = 20;
			int num = Class115.int_21 - Class115.smethod_43();
			int num2 = (Class115.smethod_43() - num) / 2;
			bool flag;
			Class531 class2 = new Class533((flag = (this.int_1 > -1)) ? ("You achieved the #" + this.int_1 + " score on local rankings!") : "You failed to get a high score on the local rankings.\nBetter luck next time!", (float)(flag ? 22 : 18), new Vector2((float)num2, (float)this.int_2), 0.95f, true, flag ? new Color(255, 203, 33) : new Color(64, 51, 8));
			class2.origins_0 = Origins.Centre;
			Class746 item = new Class746(TransformationType.Fade, 0f, 1f, 0, 400, Enum70.const_0);
			class2.class26_0.Add(item);
			this.vmethod_1(class2);
			this.int_2 += 20;
			class2 = new Class533("Local player name:", 12f, new Vector2((float)(num2 - 110), (float)this.int_2), 0.95f, true, Color.get_White());
			this.class754_0 = new Class754(Class341.class605_20, 12, new Vector2((float)(num2 - 10), (float)this.int_2), 130f, 0.95f, false);
			this.class754_0.int_0 = 20;
			int num3 = Class115.smethod_43() - 160;
			this.class762_1 = new Class762("Export replay as .osr", new Vector2((float)num3, 10f), 0.95f, false);
			this.class762_0 = new Class762("Online Favourite", new Vector2((float)num3, 35f), 0.95f, Class466.Current.bool_19);
			this.vmethod_1(class2);
			this.class911_0.Add<Class531>(this.class754_0.list_0);
			this.class911_0.Add<Class531>(this.class762_1.list_0);
			if (Class466.Current.int_3 > 0 && Class341.class605_20.Value.Length > 0)
			{
				this.class911_0.Add<Class531>(this.class762_0.list_0);
			}
			this.bool_5 = ((Class466.Current.submissionStatus_0 == SubmissionStatus.Ranked || Class466.Current.submissionStatus_0 == SubmissionStatus.Approved) && Class341.class605_20.Value.Length > 0 && this.class512_0.bool_0);
			if (this.bool_5)
			{
				this.int_2 += 20;
				Class115.class861_0.method_10(new Vector2((float)(num2 - 100), (float)this.int_2), false, 0);
				Class115.class861_0.method_16(false);
				this.class911_0.Add<Class531>(Class115.class861_0.list_0);
				if (this.class512_0.enum66_0 < Enum66.const_2)
				{
					this.class512_0.method_16(new Delegate59(this.method_9));
					this.class533_0 = new Class533("Retrieving online ranking statistics...", 22f, new Vector2((float)(Class115.smethod_43() / 2), 180f), Vector2.get_Zero(), 1f, true, Color.get_White(), false);
					this.class533_0.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, 0, 200, Enum70.const_1));
					this.class533_0.class26_0.Add(new Class746(TransformationType.Scale, 0f, 1.2f, 0, 200, Enum70.const_1));
					this.class533_0.class26_0.Add(new Class746(TransformationType.Scale, 1.2f, 1f, 200, 1200, Enum70.const_1));
					this.class533_0.class26_0.Add(new Class746(TransformationType.Scale, 1f, 1.1f, 1200, 2400, Enum70.const_1));
					this.class533_0.class26_0[this.class533_0.class26_0.Count - 1].bool_0 = true;
					this.class533_0.class26_0[this.class533_0.class26_0.Count - 1].int_2 = 1200;
					this.class533_0.class26_0.Add(new Class746(TransformationType.Scale, 1.1f, 1f, 2400, 3600, Enum70.const_2));
					this.class533_0.class26_0[this.class533_0.class26_0.Count - 1].bool_0 = true;
					this.class533_0.class26_0[this.class533_0.class26_0.Count - 1].int_2 = 1200;
					this.class533_0.origins_0 = Origins.Centre;
					this.class911_0.Add(this.class533_0);
				}
				else
				{
					this.method_9(this.class512_0);
				}
			}
			this.class531_0.method_8(true);
			Color color_;
			color_..ctor(255, 255, 255, 220);
			this.vmethod_1(new Class531(Class885.Load("ranking-dialog-middle", Enum112.flag_1), new Vector2(168.75f, 0f), 0.5f, true, color_)
			{
				vector2_2 = new Vector2(((float)Class115.smethod_43() - 343.75f) * 1.6f, 1f)
			});
			Class531 class3 = new Class531(Class885.Load("ranking-dialog-left", Enum112.flag_1), new Vector2(0f, 0f), 0.5f, true, color_);
			this.vmethod_1(class3);
			class3 = new Class531(Class885.Load("ranking-dialog-right", Enum112.flag_1), Enum115.const_7, Origins.TopRight, Enum114.const_0, new Vector2(0f, 0f), 0.5f, true, color_, null);
			this.vmethod_1(class3);
			this.class533_1 = new Class533("Checking rating status...", 16f, new Vector2((float)(Class115.smethod_43() / 2), 355f), 0.98f, true, Color.get_White());
			this.class533_1.origins_0 = Origins.Centre;
			this.class533_1.method_57(Color.get_OrangeRed());
			this.class911_0.Add(this.class533_1);
			int num4 = 25;
			for (int i = 0; i < 10; i++)
			{
				this.class531_1[i] = new Class531(Class885.Load("star3", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2((float)(Class115.smethod_43() / 2 - 144 + 32 * i), this.class533_1.vector2_1.Y + (float)num4), 0.98f, true, new Color(0, 0, 0, 50), null);
				this.class531_1[i].int_0 = i + 1;
				this.class911_0.Add(this.class531_1[i]);
				this.class531_1[i] = new Class531(Class885.Load("star3", Enum112.flag_1), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2((float)(Class115.smethod_43() / 2 - 144 + 32 * i), this.class533_1.vector2_1.Y + (float)num4), 0.99f, true, Color.get_TransparentWhite(), null);
				this.class531_1[i].int_0 = i + 1;
				this.class911_0.Add(this.class531_1[i]);
			}
		}

		// Token: 0x06002A15 RID: 10773
		// RVA: 0x0010F1B4 File Offset: 0x0010D3B4
		internal override void Close(bool bool_9)
		{
			if (!this.bool_1)
			{
				return;
			}
			if (this.class512_0 != null)
			{
				this.class512_0.string_5 = null;
			}
			if (this.bool_5)
			{
				if (this.class762_0 != null && this.class762_0.method_2() && !Class466.Current.bool_19)
				{
					Class466.Current.bool_19 = true;
					Class133 class = new Class133(string.Format("http://osu.ppy.sh/web/osu-addfavourite.php?u={0}&h={1}&a={2}", Class341.class605_20, Class341.class605_17, Class466.Current.int_3));
					Class133 arg_9B_0 = class;
					if (Class99.delegate17_0 == null)
					{
						Class99.delegate17_0 = new Class133.Delegate17(Class99.smethod_3);
					}
					arg_9B_0.method_0(Class99.delegate17_0);
					Class169.smethod_0(class);
				}
				if (Class115.class861_0.list_0 != null)
				{
					Class115.class861_0.method_16(true);
					if (this.class911_0 != null)
					{
						foreach (Class531 current in Class115.class861_0.list_0)
						{
							this.class911_0.Remove(current);
						}
					}
					if (this.class911_0 != null)
					{
						this.class911_0.method_13<Class531>(Class115.class861_0.list_0);
					}
				}
			}
			this.method_13();
			base.Close(bool_9);
		}

		// Token: 0x06002A13 RID: 10771
		// RVA: 0x0002048F File Offset: 0x0001E68F
		protected override void Dispose(bool bool_9)
		{
			this.class512_0.method_17(new Delegate59(this.method_9));
			base.Dispose(bool_9);
		}

		// Token: 0x06002A1B RID: 10779
		// RVA: 0x0010F704 File Offset: 0x0010D904
		public override void imethod_2()
		{
			if (this.bool_1 && this.bool_7 && this.bool_5)
			{
				if (this.class512_0.int_1 > 0)
				{
					this.class533_0.Text = "Congratulations - you achieved online rank #" + this.class512_0.int_1 + "!";
					this.class533_0.class26_0.Add(new Class746(TransformationType.Scale, 1f, 1.1f, Class115.int_1, Class115.int_1 + 100, Enum70.const_1));
					this.class533_0.class26_0.Add(new Class746(TransformationType.Scale, 1.1f, 1f, Class115.int_1 + 100, Class115.int_1 + 200, Enum70.const_2));
					this.class533_0.method_57(Color.get_YellowGreen());
				}
				else
				{
					this.class533_0.Text = "You have previously set a higher online record.";
					this.class533_0.method_40(Color.get_OrangeRed(), 400);
					this.class533_0.class26_0.Add(new Class746(TransformationType.Rotation, 0f, 0.1f, Class115.int_1, Class115.int_1 + 50, Enum70.const_0));
					this.class533_0.class26_0.Add(new Class746(TransformationType.Rotation, 0.1f, -0.1f, Class115.int_1 + 50, Class115.int_1 + 150, Enum70.const_0));
					this.class533_0.class26_0.Add(new Class746(TransformationType.Rotation, -0.1f, 0f, Class115.int_1 + 150, Class115.int_1 + 200, Enum70.const_0));
				}
				if (!this.bool_8)
				{
					Class115.class861_0.method_15();
					this.bool_8 = true;
				}
				this.bool_7 = false;
			}
			if (this.bool_6)
			{
				int num = -1;
				for (int i = 0; i < 10; i++)
				{
					if (this.class531_1[i].vmethod_1())
					{
						num = i;
					}
				}
				for (int j = 0; j < 10; j++)
				{
					this.class531_1[j].method_39((j <= num) ? Color.get_White() : ((this.class531_1[j].object_0 == null) ? new Color(35, 162, 255) : ((Color)this.class531_1[j].object_0)), 100, false, Enum70.const_0);
				}
			}
		}

		// Token: 0x06002A14 RID: 10772
		// RVA: 0x0010D504 File Offset: 0x0010B704
		private void method_10()
		{
			EventHandler eventHandler = null;
			EventHandler eventHandler2 = null;
			Class99.Class683 class = new Class99.Class683();
			class.class99_0 = this;
			OsuModes osuModes_ = Class115.osuModes_1;
			if (osuModes_ != OsuModes.Rank)
			{
				switch (osuModes_)
				{
				case OsuModes.RankingVs:
				case OsuModes.RankingTagCoop:
				case OsuModes.RankingTeam:
					goto IL_47;
				case OsuModes.OnlineSelection:
				case OsuModes.OptionsOffsetWizard:
					IL_3F:
					this.bool_7 = false;
					return;
				}
				goto IL_3F;
			}
			IL_47:
			if (Class466.Current != null && this.class512_0 != null && this.class512_0.string_5 != null && this.class512_0.string_5.StartsWith("beatmapId"))
			{
				class.dictionary_0 = new Dictionary<string, string>();
				class.dictionary_1 = new Dictionary<string, string>();
				try
				{
					int num = base.method_1();
					if (this.bool_1 && !this.bool_8)
					{
						Class115.class861_0.method_15();
					}
					if (this.class533_0 != null)
					{
						this.class533_0.class26_0.Clear();
						this.class533_0.float_2 = 1f;
						this.class533_0.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, num, num + 500, Enum70.const_0));
					}
					Class731 class731_;
					switch (this.class512_0.playModes_0)
					{
					case PlayModes.Taiko:
						class731_ = Class885.Load("mode-taiko", Enum112.flag_6);
						break;
					case PlayModes.CatchTheBeat:
						class731_ = Class885.Load("mode-fruits", Enum112.flag_6);
						break;
					case PlayModes.OsuMania:
						class731_ = Class885.Load("mode-mania", Enum112.flag_6);
						break;
					default:
						class731_ = Class885.Load("mode-osu", Enum112.flag_6);
						break;
					}
					Class531 class2 = new Class531(class731_, Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(100f, 230f), 0.94f, true, Color.get_TransparentWhite(), null)
					{
						float_2 = 0.8f
					};
					class2.class26_0.Add(new Class746(TransformationType.Rotation, 0f, 0.1f, num, num + 5000, Enum70.const_1));
					class2.class26_0.Add(new Class746(TransformationType.Fade, 0f, 0.1f, num, num + 2000, Enum70.const_0));
					class2.bool_7 = true;
					this.vmethod_1(class2);
					Color color_;
					color_..ctor(42, 48, 48, 0);
					Color color;
					color..ctor(103, 157, 17, 255);
					Color color2;
					color2..ctor(203, 35, 18, 255);
					Color color3;
					color3..ctor(246, 233, 25, 255);
					int num2 = 3 + (Class115.smethod_43() - Class115.int_20) / 2;
					int num3 = 170;
					int num4 = num2;
					new Class746(TransformationType.Fade, 0.784313738f, 1f, 0, 100, Enum70.const_1);
					num4 += 100;
					Class533 class3 = new Class533("Map Rank", 9f, new Vector2((float)num4, 170f), new Vector2(69f, 0f), 0.95f, true, Color.get_White(), false);
					class3.method_53(color_);
					class3.float_3 = 0f;
					class3.bool_16 = true;
					class3.enum72_0 = Enum72.const_2;
					class3.bool_1 = true;
					class3.class26_0.Add(new Class746(TransformationType.Fade, 0f, 0.9f, num + 200 + (num4 + 170 - 150) / 4, num + 200 + (num4 + 170 - 150) * 2, Enum70.const_0));
					this.vmethod_1(class3);
					num4 += 70;
					class3 = new Class533("Overall", 9f, new Vector2((float)num4, 170f), new Vector2(69f, 0f), 0.95f, true, Color.get_White(), false);
					class3.method_53(color_);
					class3.bool_16 = true;
					class3.float_3 = 0f;
					class3.enum72_0 = Enum72.const_2;
					class3.bool_1 = true;
					class3.class26_0.Add(new Class746(TransformationType.Fade, 0f, 0.9f, num + 200 + (num4 + 170 - 150) / 4, num + 200 + (num4 + 170 - 150) * 2, Enum70.const_0));
					this.vmethod_1(class3);
					num4 += 70;
					class3 = new Class533("Accuracy", 9f, new Vector2((float)num4, 170f), new Vector2(69f, 0f), 0.95f, true, Color.get_White(), false);
					class3.method_53(color_);
					class3.bool_16 = true;
					class3.float_3 = 0f;
					class3.enum72_0 = Enum72.const_2;
					class3.bool_1 = true;
					class3.class26_0.Add(new Class746(TransformationType.Fade, 0f, 0.9f, num + 200 + (num4 + 170 - 150) / 4, num + 200 + (num4 + 170 - 150) * 2, Enum70.const_0));
					this.vmethod_1(class3);
					num4 += 70;
					class3 = new Class533("Ranked Score", 9f, new Vector2((float)num4, 170f), new Vector2(109f, 0f), 0.95f, true, Color.get_White(), false);
					class3.method_53(color_);
					class3.bool_16 = true;
					class3.float_3 = 0f;
					class3.enum72_0 = Enum72.const_2;
					class3.bool_1 = true;
					class3.class26_0.Add(new Class746(TransformationType.Fade, 0f, 0.9f, num + 200 + (num4 + 170 - 150) / 4, num + 200 + (num4 + 170 - 150) * 2, Enum70.const_0));
					this.vmethod_1(class3);
					num4 += 110;
					class3 = new Class533("Total Score", 9f, new Vector2((float)num4, 170f), new Vector2(109f, 0f), 0.95f, true, Color.get_White(), false);
					class3.method_53(color_);
					class3.bool_16 = true;
					class3.float_3 = 0f;
					class3.enum72_0 = Enum72.const_2;
					class3.bool_1 = true;
					class3.class26_0.Add(new Class746(TransformationType.Fade, 0f, 0.9f, num + 200 + (num4 + 170 - 150) / 4, num + 200 + (num4 + 170 - 150) * 2, Enum70.const_0));
					this.vmethod_1(class3);
					num4 += 110;
					class3 = new Class533("To Next Rank", 9f, new Vector2((float)num4, 170f), new Vector2(99f, 0f), 0.95f, true, Color.get_White(), false);
					class3.method_53(color_);
					class3.bool_16 = true;
					class3.float_3 = 0f;
					class3.enum72_0 = Enum72.const_2;
					class3.bool_1 = true;
					class3.class26_0.Add(new Class746(TransformationType.Fade, 0f, 0.9f, num + 200 + (num4 + 170 - 150) / 4, num + 200 + (num4 + 170 - 150) * 2, Enum70.const_0));
					this.vmethod_1(class3);
					num3 = 180;
					List<string> list = new List<string>();
					string[] array = this.class512_0.string_5.Split(new char[]
					{
						'\n'
					});
					string[] array2 = array[0].Split(new char[]
					{
						'|'
					});
					for (int i = 0; i < array2.Length; i++)
					{
						string text = array2[i];
						if (text.Length != 0 && !text.Contains("error:"))
						{
							int num5 = text.IndexOf(':');
							if (num5 >= 0)
							{
								class.dictionary_0[text.Remove(num5).Trim()] = text.Substring(num5 + 1).Trim();
							}
						}
					}
					if (class.dictionary_0.Count > 0)
					{
						DateTime now = DateTime.Now;
						string text2 = "unknown";
						if (!string.IsNullOrEmpty(class.dictionary_0["approvedDate"]))
						{
							try
							{
								text2 = DateTime.Parse(class.dictionary_0["approvedDate"], Class115.numberFormatInfo_0).ToString("MMM, yyyy", Class115.numberFormatInfo_0);
							}
							catch
							{
							}
						}
						int num6 = (int)((float)int.Parse(class.dictionary_0["beatmapPasscount"]) / (float)int.Parse(class.dictionary_0["beatmapPlaycount"]) * 100f);
						class3 = new Class533(string.Format("{2} by {3}\n{0:#,0} plays since {1} | {4}% pass rate", new object[]
						{
							int.Parse(class.dictionary_0["beatmapPlaycount"]),
							text2,
							Class466.Current.string_6,
							Class466.Current.string_5,
							num6
						}), 14f, new Vector2(170f, 301f), 0.951f, true, Color.get_White());
						class3.method_57(new Color(255, 255, 255, 71));
						class3.enum72_0 = Enum72.const_2;
						this.vmethod_1(class3);
					}
					for (int j = 1; j < array.Length; j++)
					{
						Class99.Class684 class4 = new Class99.Class684();
						class4.class683_0 = class;
						class4.int_0 = j;
						string text3 = array[j];
						if (text3.Length != 0)
						{
							class.dictionary_1 = new Dictionary<string, string>();
							string[] array3 = text3.Split(new char[]
							{
								'|'
							});
							for (int k = 0; k < array3.Length; k++)
							{
								string text4 = array3[k];
								if (text4.Length != 0)
								{
									int num7 = text4.IndexOf(':');
									if (num7 >= 0)
									{
										class.dictionary_1[text4.Remove(num7).Trim()] = text4.Substring(num7 + 1).Trim();
									}
								}
							}
							if (class.dictionary_1.Count != 0)
							{
								if (class.dictionary_1["achievements"].Length > 0)
								{
									list.AddRange(class.dictionary_1["achievements"].Split(new char[]
									{
										' '
									}));
								}
								Color color4 = (j % 2 == 0) ? new Color(20, 20, 20) : new Color(40, 40, 40);
								num4 = num2;
								EventHandler eventHandler3 = new EventHandler(class4.method_0);
								EventHandler eventHandler4 = new EventHandler(class4.method_1);
								if (class.dictionary_1["chartEndDate"].Length > 0)
								{
									DateTime d = DateTime.Parse(class.dictionary_1["chartEndDate"], Class115.numberFormatInfo_0);
									int days = (d - DateTime.Today).Days;
									int num8 = class.dictionary_1["chartName"].Split(new char[]
									{
										'\n'
									}).Length;
									this.vmethod_1(new Class533(string.Concat(new object[]
									{
										"(",
										days,
										(days != 1) ? " days" : " day",
										" left)"
									}), 8f, new Vector2((float)(num4 + 2), (float)(num3 + (num8 + 1) * 12)), new Vector2(95f, 0f), 0.951f, true, Color.get_White(), false)
									{
										class26_0 = 
										{
											new Class746(TransformationType.Fade, 0f, 0.9f, num + 200 + (num4 + num3 - 150) / 4, num + 200 + (num4 + num3 - 150) * 2, Enum70.const_0)
										},
										float_3 = 0f,
										enum72_0 = Enum72.const_2,
										object_0 = "chart" + j
									});
								}
								class3 = new Class533(class.dictionary_1["chartName"] + "\n\t", 11f, new Vector2((float)num4, (float)num3), new Vector2(99f, 0f), 0.95f, true, Color.get_Orange(), false);
								class3.method_53(color4);
								class3.class26_0.Add(new Class746(TransformationType.Fade, 0f, 0.9f, num + 200 + (num4 + num3 - 150) / 4, num + 200 + (num4 + num3 - 150) * 2, Enum70.const_0));
								class3.bool_16 = true;
								class3.float_3 = 0f;
								class3.enum72_0 = Enum72.const_2;
								class3.method_35(eventHandler3);
								class3.method_37(eventHandler4);
								class3.bool_1 = true;
								class3.string_0 = "View this ranking chart's info/ranking page.";
								if (class.dictionary_1["chartId"] == "overall")
								{
									if (this.class512_0 != null && class.dictionary_1.ContainsKey("onlineScoreId"))
									{
										this.class512_0.long_0 = long.Parse(class.dictionary_1["onlineScoreId"]);
									}
									Class530 arg_D20_0 = class3;
									if (Class99.eventHandler_4 == null)
									{
										Class99.eventHandler_4 = new EventHandler(Class99.smethod_2);
									}
									arg_D20_0.method_2(Class99.eventHandler_4);
								}
								else
								{
									Class530 arg_D3E_0 = class3;
									if (eventHandler == null)
									{
										eventHandler = new EventHandler(class.method_0);
									}
									arg_D3E_0.method_2(eventHandler);
								}
								class3.object_0 = "chart" + j;
								this.vmethod_1(class3);
								num4 += 100;
								long num9 = (long)int.Parse(class.dictionary_1["beatmapRankingAfter"]);
								long num10 = (long)int.Parse(class.dictionary_1["beatmapRankingBefore"]);
								long num11 = num10 - num9;
								if (class.dictionary_1["chartId"] == "overall" && num9 <= 100L && (num10 == 0L || num9 <= num10))
								{
									Class111.smethod_25(string.Format(Class41.GetString(OsuString.Userlog_TopRank), num9, Class466.Current.string_7, Class213.smethod_0(this.class512_0.playModes_0)));
								}
								if (num10 == 0L)
								{
									goto IL_113E;
								}
								if (num11 == 0L)
								{
									goto IL_113E;
								}
								if (num9 < num10)
								{
									class3 = new Class533(string.Format("#{0:#,0}\n" + ((num11 != 0L) ? " ({1}{2:#,0})" : "-"), num9, (num11 > 0L) ? "+" : "", num10 - num9), 11f, new Vector2((float)num4, (float)num3), new Vector2(69f, 0f), 0.95f, true, Color.get_White(), false);
									class3.method_53((num11 > 0L) ? color : ((num11 < 0L) ? color2 : color4));
									class3.class26_0.Add(new Class746(TransformationType.Fade, 0f, 0.9f, num + 200 + (num4 + num3 - 150) / 4, num + 200 + (num4 + num3 - 150) * 2, Enum70.const_0));
									class3.float_3 = 0f;
									class3.enum72_0 = Enum72.const_2;
									class3.method_35(eventHandler3);
									class3.method_37(eventHandler4);
									class3.object_0 = "chart" + j;
									class3.bool_1 = true;
									this.vmethod_1(class3);
								}
								else
								{
									this.vmethod_1(new Class533(string.Format("your best: #{0:#,0}", num10), 8f, new Vector2((float)(num4 + 2), (float)(num3 + 12)), new Vector2(65f, 0f), 0.951f, true, Color.get_White(), false)
									{
										class26_0 = 
										{
											new Class746(TransformationType.Fade, 0f, 0.9f, num + 200 + (num4 + num3 - 150) / 4, num + 200 + (num4 + num3 - 150) * 2, Enum70.const_0)
										},
										float_3 = 0f,
										enum72_0 = Enum72.const_2,
										object_0 = "chart" + j
									});
									class3 = new Class533(string.Format("#{0:#,0}\n\t", num9), 11f, new Vector2((float)num4, (float)num3), new Vector2(69f, 0f), 0.95f, true, Color.get_White(), false);
									class3.method_53(color4);
									class3.method_57(Color.get_Gray());
									class3.class26_0.Add(new Class746(TransformationType.Fade, 0f, 0.9f, num + 200 + (num4 + num3 - 150) / 4, num + 200 + (num4 + num3 - 150) * 2, Enum70.const_0));
									class3.float_3 = 0f;
									class3.enum72_0 = Enum72.const_2;
									class3.method_35(eventHandler3);
									class3.method_37(eventHandler4);
									class3.object_0 = "chart" + j;
									class3.bool_1 = true;
									this.vmethod_1(class3);
								}
								IL_123F:
								class3.string_0 = "Open beatmap's info/ranking page.";
								Class530 arg_1262_0 = class3;
								if (eventHandler2 == null)
								{
									eventHandler2 = new EventHandler(class.method_1);
								}
								arg_1262_0.method_2(eventHandler2);
								num4 += 70;
								num9 = (long)int.Parse(class.dictionary_1["rankAfter"]);
								num10 = (long)int.Parse(class.dictionary_1["rankBefore"]);
								num11 = ((num10 == 0L) ? 0L : (num10 - num9));
								class3 = new Class533(string.Format("#{0:#,0}\n" + ((num11 != 0L) ? " ({1}{2:#,0})" : "-"), num9, (num11 > 0L) ? "+" : "", num10 - num9), 11f, new Vector2((float)num4, (float)num3), new Vector2(69f, 0f), 0.95f, true, Color.get_White(), false);
								class3.method_53((num11 > 0L) ? color : ((num11 < 0L) ? color2 : color4));
								class3.class26_0.Add(new Class746(TransformationType.Fade, 0f, 0.9f, num + 200 + (num4 + num3 - 150) / 4, num + 200 + (num4 + num3 - 150) * 2, Enum70.const_0));
								class3.float_3 = 0f;
								class3.enum72_0 = Enum72.const_2;
								class3.method_35(eventHandler3);
								class3.method_37(eventHandler4);
								class3.object_0 = "chart" + j;
								class3.bool_1 = true;
								this.vmethod_1(class3);
								num4 += 70;
								float num12 = float.Parse(class.dictionary_1["accuracyAfter"], Class115.numberFormatInfo_0) * 100f;
								float num13 = float.Parse(class.dictionary_1["accuracyBefore"], Class115.numberFormatInfo_0) * 100f;
								float num14 = (float)Math.Round((double)(num12 - num13), 2);
								string arg_1484_0 = "{0:n}%\n";
								if (num14 == 0f)
								{
									goto IL_147F;
								}
								if (num13 == 0f)
								{
									goto IL_147F;
								}
								string arg_1484_1 = " ({1}{2:n}%)";
								IL_1484:
								class3 = new Class533(string.Format(arg_1484_0 + arg_1484_1, num12, (num14 > 0f) ? "+" : "", num12 - num13), 11f, new Vector2((float)num4, (float)num3), new Vector2(69f, 0f), 0.95f, true, Color.get_White(), false);
								class3.method_53((num14 > 0f) ? color : ((num14 < 0f) ? color2 : color4));
								class3.class26_0.Add(new Class746(TransformationType.Fade, 0f, 0.9f, num + 200 + (num4 + num3 - 150) / 4, num + 200 + (num4 + num3 - 150) * 2, Enum70.const_0));
								class3.float_3 = 0f;
								class3.enum72_0 = Enum72.const_2;
								class3.method_35(eventHandler3);
								class3.method_37(eventHandler4);
								class3.object_0 = "chart" + j;
								class3.bool_1 = true;
								this.vmethod_1(class3);
								num4 += 70;
								num9 = long.Parse(class.dictionary_1["rankedScoreAfter"]);
								num10 = long.Parse(class.dictionary_1["rankedScoreBefore"]);
								num11 = num9 - num10;
								class3 = new Class533(string.Format("{0:#,0}\n" + ((num11 != 0L) ? " ({1}{2:#,0})" : "-"), num9, (num11 > 0L) ? "+" : "", num9 - num10), 11f, new Vector2((float)num4, (float)num3), new Vector2(109f, 0f), 0.95f, true, Color.get_White(), false);
								class3.method_53((num11 > 0L) ? color : ((num11 < 0L) ? color2 : color4));
								class3.class26_0.Add(new Class746(TransformationType.Fade, 0f, 0.9f, num + 200 + (num4 + num3 - 150) / 4, num + 200 + (num4 + num3 - 150) * 2, Enum70.const_0));
								class3.float_3 = 0f;
								class3.enum72_0 = Enum72.const_2;
								class3.method_35(eventHandler3);
								class3.method_37(eventHandler4);
								class3.object_0 = "chart" + j;
								class3.bool_1 = true;
								this.vmethod_1(class3);
								num4 += 110;
								num9 = long.Parse(class.dictionary_1["totalScoreAfter"]);
								num10 = long.Parse(class.dictionary_1["totalScoreBefore"]);
								num11 = num9 - num10;
								class3 = new Class533(string.Format("{0:#,0}\n" + ((num11 != 0L) ? " ({1}{2:#,0})" : "-"), num9, (num11 > 0L) ? "+" : "", num9 - num10), 11f, new Vector2((float)num4, (float)num3), new Vector2(109f, 0f), 0.95f, true, Color.get_White(), false);
								class3.method_53((num11 > 0L) ? color : ((num11 < 0L) ? color2 : color4));
								class3.class26_0.Add(new Class746(TransformationType.Fade, 0f, 0.9f, num + 200 + (num4 + num3 - 150) / 4, num + 200 + (num4 + num3 - 150) * 2, Enum70.const_0));
								class3.float_3 = 0f;
								class3.enum72_0 = Enum72.const_2;
								class3.method_35(eventHandler3);
								class3.method_37(eventHandler4);
								class3.object_0 = "chart" + j;
								class3.bool_1 = true;
								this.vmethod_1(class3);
								num4 += 110;
								num9 = long.Parse(class.dictionary_1["toNextRank"]);
								string text5 = class.dictionary_1["toNextRankUser"];
								class3 = new Class533((num9 > 0L) ? string.Format("@{0:#,0}\n\t", num9) : "-\n\t", 11f, new Vector2((float)num4, (float)num3), new Vector2(99f, 0f), 0.95f, true, Color.get_White(), false);
								class3.method_53(color4);
								class3.class26_0.Add(new Class746(TransformationType.Fade, 0f, 0.9f, num + 200 + (num4 + num3 - 150) / 4, num + 200 + (num4 + num3 - 150) * 2, Enum70.const_0));
								class3.float_3 = 0f;
								class3.enum72_0 = Enum72.const_2;
								class3.method_35(eventHandler3);
								class3.method_37(eventHandler4);
								class3.object_0 = "chart" + j;
								class3.bool_1 = true;
								this.vmethod_1(class3);
								if (text5.Length > 0)
								{
									this.vmethod_1(new Class533((text5.Length > 0) ? ("to pass " + text5) : "-", 8f, new Vector2((float)(num4 + 2), (float)(num3 + 12)), new Vector2(95f, 0f), 0.951f, true, Color.get_White(), false)
									{
										class26_0 = 
										{
											new Class746(TransformationType.Fade, 0f, 0.9f, num + 200 + (num4 + num3 - 150) / 4, num + 200 + (num4 + num3 - 150) * 2, Enum70.const_0)
										},
										float_3 = 0f,
										enum72_0 = Enum72.const_2,
										object_0 = "chart" + j
									});
								}
								num3 += 24;
								goto IL_1AAC;
								IL_147F:
								arg_1484_1 = "-";
								goto IL_1484;
								IL_113E:
								class3 = new Class533(string.Format("#{0:#,0}", num9), 17f, new Vector2((float)num4, (float)num3), new Vector2(69f, 0f), 0.95f, true, Color.get_White(), num11 != 0L);
								class3.method_53((num11 == 0L) ? color4 : color3);
								class3.class26_0.Add(new Class746(TransformationType.Fade, 0f, 0.9f, num + 200 + (num4 + num3 - 150) / 4, num + 200 + (num4 + num3 - 150) * 2, Enum70.const_0));
								class3.float_3 = 0f;
								class3.enum72_0 = Enum72.const_2;
								class3.method_35(eventHandler3);
								class3.method_37(eventHandler4);
								class3.object_0 = "chart" + j;
								class3.bool_1 = true;
								this.vmethod_1(class3);
								goto IL_123F;
							}
						}
						IL_1AAC:;
					}
					this.method_15(list.ToArray());
				}
				catch (Exception exception_)
				{
					Class723.smethod_5("An error occurred when displaying the new ranking screen!\nThis has been reported and will be fixed soon!", Color.get_Red(), 5000, null);
					Class764 class5 = new Class764(exception_);
					string text6 = "response: \"" + this.class512_0.string_5 + "\"\n";
					if (class.dictionary_0 != null)
					{
						foreach (KeyValuePair<string, string> current in class.dictionary_0)
						{
							string text7 = text6;
							text6 = string.Concat(new string[]
							{
								text7,
								current.Key,
								" - ",
								current.Value,
								"\n"
							});
						}
					}
					text6 += "\n\n";
					if (class.dictionary_1 != null)
					{
						foreach (KeyValuePair<string, string> current2 in class.dictionary_1)
						{
							string text7 = text6;
							text6 = string.Concat(new string[]
							{
								text7,
								current2.Key,
								" - ",
								current2.Value,
								"\n"
							});
						}
					}
					class5.string_0 = text6;
					Class765.smethod_0(class5);
				}
				this.class512_0.string_5 = null;
				return;
			}
			this.bool_7 = false;
		}

		// Token: 0x06002A16 RID: 10774
		// RVA: 0x0010F304 File Offset: 0x0010D504
		protected void method_11(object sender, EventArgs e)
		{
			this.int_3 = ((Class531)sender).int_0;
			Class531[] array = this.class531_1;
			for (int i = 0; i < array.Length; i++)
			{
				Class531 class = array[i];
				if (class.int_0 > this.int_3)
				{
					class.object_0 = Color.get_Black();
				}
				else
				{
					class.object_0 = Color.get_YellowGreen();
				}
				if (class.float_2 > 1f)
				{
					class.class26_0.Add(new Class746(TransformationType.Scale, class.float_2, 1f, Class115.int_1, Class115.int_1 + 500, Enum70.const_0));
				}
			}
			string text = string.Concat(new object[]
			{
				"Vote (",
				this.int_3,
				" star",
				(this.int_3 > 1) ? "s" : "",
				")"
			});
			if (this.class760_0 == null)
			{
				this.class760_0 = new Class760(text, new Vector2(this.class531_1[9].vector2_1.X + 32f, this.class531_1[0].vector2_1.Y - 11f), new Vector2(140f, 24f), 0.98f, Color.get_YellowGreen(), new EventHandler(this.method_12), true, false, null);
				this.class911_0.Add<Class531>(this.class760_0.list_0);
				this.class911_0.Add<Class531>(this.class760_0.list_0);
			}
			else
			{
				this.class760_0.class533_0.Text = text;
			}
			List<Class531> arg_1CC_0 = this.class760_0.list_0;
			if (Class99.action_2 == null)
			{
				Class99.action_2 = new Action<Class531>(Class99.smethod_4);
			}
			arg_1CC_0.ForEach(Class99.action_2);
		}

		// Token: 0x06002A17 RID: 10775
		// RVA: 0x0010F4E4 File Offset: 0x0010D6E4
		private void method_12(object sender, EventArgs e)
		{
			string string_ = string.Concat(new object[]
			{
				"http://osu.ppy.sh/web/osu-rate.php?u=",
				Class341.class605_20,
				"&p=",
				Class341.class605_17,
				"&c=",
				Class466.Current.string_3,
				"&v=",
				this.int_3
			});
			Class133 class = new Class133(string_);
			class.method_0(new Class133.Delegate17(this.method_14));
			this.bool_6 = false;
			Class531[] array = this.class531_1;
			for (int i = 0; i < array.Length; i++)
			{
				Class531 class2 = array[i];
				class2.bool_1 = false;
				if (class2.int_0 > this.int_3)
				{
					class2.method_39(Color.get_Black(), 500, false, Enum70.const_0);
				}
				else
				{
					class2.method_39(Color.get_YellowGreen(), 500, false, Enum70.const_0);
				}
				if (class2.float_2 > 1f)
				{
					class2.class26_0.Add(new Class746(TransformationType.Scale, class2.float_2, 1f, Class115.int_1, Class115.int_1 + 500, Enum70.const_0));
				}
			}
			this.class533_1.Text = "Submitting rating...";
			this.class760_0.method_4();
			Class169.smethod_0(class);
		}

		// Token: 0x06002A18 RID: 10776
		// RVA: 0x0010F634 File Offset: 0x0010D834
		protected void method_13()
		{
			if (this.int_1 > -1)
			{
				if (this.class754_0.class533_0.Text.Length > 0)
				{
					this.class512_0.string_2 = this.class754_0.class533_0.Text;
				}
				if (this.class762_1.method_2())
				{
					Class908.smethod_6(this.class512_0, null);
				}
				Class908.smethod_2(this.class512_0, false, true);
			}
		}

		// Token: 0x06002A1A RID: 10778
		// RVA: 0x0010F6A8 File Offset: 0x0010D8A8
		protected void method_14(string string_0, Exception exception_0)
		{
			if (exception_0 != null)
			{
				return;
			}
			if (string_0.IndexOf('\n') > 0)
			{
				string_0 = string_0.Substring(string_0.IndexOf('\n') + 1);
			}
			this.class533_1.Text = "Thanks for your input!  This beatmap now has an average rating of " + string_0 + ".";
			this.method_17(float.Parse(string_0, Class115.numberFormatInfo_0));
		}

		// Token: 0x06002A1C RID: 10780
		// RVA: 0x0010F948 File Offset: 0x0010DB48
		private void method_15(string[] string_0)
		{
			Class99.Class685 class = new Class99.Class685();
			class.string_0 = string_0;
			class.class99_0 = this;
			if (class.string_0.Length == 0)
			{
				return;
			}
			if (this.bool_1)
			{
				Class723.smethod_1("Loading new achievements...", 1000);
			}
			this.list_1 = new List<Class531>();
			for (int i = 0; i < class.string_0.Length; i++)
			{
				Class99.Class686 class2 = new Class99.Class686();
				class2.class685_0 = class;
				if (class.string_0[i].Length != 0)
				{
					int num = base.method_1();
					class2.vector2_0 = new Vector2((float)(Class115.smethod_43() / 2 - 24) - (float)(class.string_0.Length * 42) / 2f + (float)(i * 84), 265f);
					class2.class531_0 = new Class531(Class885.Load("achievement-unknown", Enum112.flag_6), Origins.Centre, class2.vector2_0, 0.95f + (float)i * 0.001f, true, Color.get_TransparentWhite());
					class2.class531_0.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, num, num + 300, Enum70.const_0));
					this.vmethod_1(class2.class531_0);
					this.list_1.Add(class2.class531_0);
					class2.int_0 = i;
					Class131 class3 = new Class131("http://s.ppy.sh/images/achievements/" + class.string_0[i]);
					class3.method_0(new Class131.Delegate9(class2.method_0));
					Class169.smethod_0(class3);
				}
			}
		}

		// Token: 0x06002A1D RID: 10781
		// RVA: 0x0010FAC8 File Offset: 0x0010DCC8
		protected void method_16(string string_0, Exception exception_0)
		{
			if (exception_0 != null)
			{
				return;
			}
			string[] array = string_0.Split(new char[]
			{
				'\n'
			});
			int num = base.method_1();
			this.bool_6 = (array[0] == "ok");
			if (this.bool_6 && this.class512_0.playModes_0 == Class466.Current.method_5())
			{
				this.class533_1.Text = "Please take a second to rate this beatmap by clicking a star below!";
				for (int i = 0; i < 10; i++)
				{
					this.class531_1[i].method_2(new EventHandler(this.method_11));
					this.class531_1[i].method_39(new Color(66, 173, 255, 255), 100, false, Enum70.const_0);
					this.class531_1[i].class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, num + i * 50, num + i * 200, Enum70.const_1));
					this.class531_1[i].bool_1 = true;
					Class746 class = new Class746(TransformationType.Scale, 1f, 1.5f, 0, 300, Enum70.const_0);
					class.enum70_0 = Enum70.const_1;
					this.class531_1[i].class746_1 = class;
				}
				return;
			}
			this.class533_1.Text = "Rating is not available ";
			string a;
			if ((a = array[0]) != null && !(a == "alreadyvoted") && !(a == "owner"))
			{
				if (!(a == "auth fail"))
				{
					if (!(a == "no exist"))
					{
						if (a == "not ranked")
						{
							Class533 expr_196 = this.class533_1;
							expr_196.Text += "because this beatmap is not a ranked map.";
						}
					}
					else
					{
						Class533 expr_1B3 = this.class533_1;
						expr_1B3.Text += "because this beatmap has not been submitted yet.";
					}
				}
				else
				{
					Class533 expr_1D0 = this.class533_1;
					expr_1D0.Text += "because you are not logged in.";
				}
			}
			if (array.Length > 1)
			{
				this.class533_1.Text = "This map has an average rating of ";
				float num2 = float.Parse(array[1], Class115.numberFormatInfo_0);
				this.method_17(num2);
				Class533 expr_218 = this.class533_1;
				expr_218.Text += Math.Round((double)num2, 2).ToString();
			}
			this.class533_1.method_57(Color.get_OrangeRed());
		}

		// Token: 0x06002A1E RID: 10782
		// RVA: 0x0010FD20 File Offset: 0x0010DF20
		private void method_17(float float_1)
		{
			int num = base.method_1();
			for (int i = 0; i < 10; i++)
			{
				if (float_1 > (float)i)
				{
					Color color;
					color..ctor(253, 222, 48, 255);
					this.class531_1[i].float_3 = 0f;
					if (float_1 < (float)(i + 1))
					{
						color..ctor(253, 183, 43, 255);
						this.class531_1[i].class26_0.Add(new Class746(TransformationType.Fade, 0f, float_1 - (float)((int)float_1), num + i * 50, num + i * 200, Enum70.const_1));
					}
					else
					{
						this.class531_1[i].class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, num + i * 50, num + i * 200, Enum70.const_1));
					}
					this.class531_1[i].class26_0.Add(new Class746(TransformationType.Scale, 1.5f, 1f, num + i * 50, num + i * 200, Enum70.const_1));
					if (this.class531_1[i].bool_3)
					{
						this.class531_1[i].method_39(color, 100, false, Enum70.const_0);
					}
					else
					{
						this.class531_1[i].color_0 = color;
					}
				}
				else if (this.class531_1[i].bool_3)
				{
					this.class531_1[i].method_16(100, Enum70.const_0);
				}
				else
				{
					this.class531_1[i].color_0 = Color.get_TransparentWhite();
					this.class531_1[i].float_3 = 1f;
					this.class531_1[i].int_4 = 0;
				}
			}
		}

		// Token: 0x06002A10 RID: 10768
		// RVA: 0x0002044F File Offset: 0x0001E64F
		private void method_9(object object_0)
		{
			Class115.class47_0.Add(new VoidDelegate(this.method_10), true);
		}

		// Token: 0x06002A1F RID: 10783
		// RVA: 0x000204D4 File Offset: 0x0001E6D4
		[CompilerGenerated]
		private static void smethod_2(object sender, EventArgs e)
		{
			Class115.smethod_90("http://osu.ppy.sh/p/playerranking", null);
		}

		// Token: 0x06002A20 RID: 10784
		// RVA: 0x000204E1 File Offset: 0x0001E6E1
		[CompilerGenerated]
		private static void smethod_3(string string_0, Exception exception_0)
		{
			Class723.smethod_1((string_0.Length > 0) ? string_0 : "Online favourite added!", (string_0.Length > 0) ? 2000 : 1000);
		}

		// Token: 0x06002A21 RID: 10785
		// RVA: 0x0002050E File Offset: 0x0001E70E
		[CompilerGenerated]
		private static void smethod_4(Class531 class531_2)
		{
			class531_2.method_40(Color.get_White(), 500);
		}

		// Token: 0x06002A12 RID: 10770
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected override void vmethod_0()
		{
		}

		// Token: 0x06002A0E RID: 10766
		// RVA: 0x00006D86 File Offset: 0x00004F86
		protected override bool vmethod_2()
		{
			return false;
		}

		// Token: 0x06002A11 RID: 10769
		// RVA: 0x00020468 File Offset: 0x0001E668
		internal override void vmethod_3()
		{
			if (this.class512_0.enum66_0 == Enum66.const_2)
			{
				Class115.class861_0.method_15();
				this.bool_8 = true;
			}
			base.vmethod_3();
		}

		// Token: 0x06002A19 RID: 10777
		// RVA: 0x000204AF File Offset: 0x0001E6AF
		internal override bool vmethod_5(Keys keys_0)
		{
			if (this.bool_1 && !Class802.smethod_2())
			{
				if (keys_0 == 13 || keys_0 == 27)
				{
					this.Close(false);
				}
				return true;
			}
			return false;
		}
	}
}
