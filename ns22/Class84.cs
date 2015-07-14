using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns14;
using ns18;
using ns24;
using ns25;
using ns26;
using ns27;
using ns29;
using ns30;
using ns40;
using ns64;
using ns79;
using ns8;
using ns80;
using ns82;
using ns9;
using ns90;
using osu.GameModes.Play.Components;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns22
{
	// Token: 0x020004EC RID: 1260
	internal sealed class Class84 : Class55
	{
		// Token: 0x020004ED RID: 1261
		[CompilerGenerated]
		private sealed class Class654
		{
			// Token: 0x040021BB RID: 8635
			public bool bool_0;

			// Token: 0x060028B7 RID: 10423
			// RVA: 0x0001F5AC File Offset: 0x0001D7AC
			public void method_0(Class531 class531_0)
			{
				class531_0.method_8(!this.bool_0);
			}
		}

		// Token: 0x020004EE RID: 1262
		[CompilerGenerated]
		private sealed class Class655
		{
			// Token: 0x040021BC RID: 8636
			public Class84 class84_0;

			// Token: 0x040021BD RID: 8637
			public string string_0;

			// Token: 0x060028B9 RID: 10425
			// RVA: 0x00100488 File Offset: 0x000FE688
			public void method_0()
			{
				if (this.class84_0.int_8 < 0)
				{
					string[] array = this.string_0.Split(new char[]
					{
						'\n'
					});
					for (int i = 0; i < array.Length; i++)
					{
						string text = array[i];
						if (text.Length != 0)
						{
							string[] array2 = text.Split(new char[]
							{
								'\t'
							});
							if (array2.Length >= 4)
							{
								int num;
								int.TryParse(array2[0], NumberStyles.Integer, Class115.numberFormatInfo_0, out num);
								if (num != 0)
								{
									CommentTargets commentTargets_ = (CommentTargets)Enum.Parse(typeof(CommentTargets), array2[1], true);
									string string_ = array2[2];
									string string_2 = array2[3];
									this.class84_0.class26_0.method_0(new Class653(num, commentTargets_, string_, string_2));
								}
							}
						}
					}
					this.class84_0.int_8 = 0;
					Class115.class47_0.Add(new VoidDelegate(this.class84_0.method_16), true);
				}
			}
		}

		// Token: 0x020004EF RID: 1263
		[CompilerGenerated]
		private sealed class Class656
		{
			// Token: 0x040021BE RID: 8638
			public int int_0;

			// Token: 0x060028BB RID: 10427
			// RVA: 0x0001F5BD File Offset: 0x0001D7BD
			public void method_0(Class531 class531_0)
			{
				class531_0.method_23(new Vector2(0f, (float)this.int_0), 500, Enum70.const_1);
				class531_0.vector2_0.Y = class531_0.vector2_0.Y + (float)this.int_0;
			}
		}

		// Token: 0x040021B9 RID: 8633
		[CompilerGenerated]
		private static Action<Class531> action_0;

		// Token: 0x040021BA RID: 8634
		[CompilerGenerated]
		private static Action<Class531> action_1;

		// Token: 0x040021A4 RID: 8612
		private bool bool_2;

		// Token: 0x040021AA RID: 8618
		private bool bool_3;

		// Token: 0x040021B5 RID: 8629
		private Class26<Class653> class26_0 = new Class26<Class653>();

		// Token: 0x0400219D RID: 8605
		internal Class531 class531_0;

		// Token: 0x0400219E RID: 8606
		private Class531 class531_1;

		// Token: 0x0400219F RID: 8607
		private Class531 class531_2;

		// Token: 0x040021A0 RID: 8608
		private Class531 class531_3;

		// Token: 0x040021A1 RID: 8609
		private Class531 class531_4;

		// Token: 0x040021A2 RID: 8610
		private Class531 class531_5;

		// Token: 0x040021A3 RID: 8611
		private Class531 class531_6;

		// Token: 0x040021A9 RID: 8617
		private Class62 class62_0;

		// Token: 0x0400219C RID: 8604
		private Class754 class754_0;

		// Token: 0x040021AB RID: 8619
		private Class762 class762_0;

		// Token: 0x040021AC RID: 8620
		private Class762 class762_1;

		// Token: 0x040021AD RID: 8621
		private Class762 class762_2;

		// Token: 0x040021B7 RID: 8631
		private Class762 class762_3;

		// Token: 0x0400219B RID: 8603
		private Class911 class911_0;

		// Token: 0x040021A7 RID: 8615
		private CommentTargets commentTargets_0;

		// Token: 0x040021B1 RID: 8625
		private float float_0 = 80f;

		// Token: 0x040021B3 RID: 8627
		private float float_1 = 420f;

		// Token: 0x040021A8 RID: 8616
		private int int_2;

		// Token: 0x040021AE RID: 8622
		private int int_3;

		// Token: 0x040021AF RID: 8623
		private int int_4;

		// Token: 0x040021B0 RID: 8624
		private int int_5;

		// Token: 0x040021B2 RID: 8626
		private int int_6;

		// Token: 0x040021B4 RID: 8628
		private int int_7;

		// Token: 0x040021B6 RID: 8630
		private int int_8 = -1;

		// Token: 0x040021A5 RID: 8613
		private List<Class531> list_0 = new List<Class531>();

		// Token: 0x040021A6 RID: 8614
		private List<Class531> list_1 = new List<Class531>();

		// Token: 0x040021B8 RID: 8632
		private Vector2 vector2_0;

		// Token: 0x0600289A RID: 10394
		// RVA: 0x000FED08 File Offset: 0x000FCF08
		public Class84(Class62 class62_1) : base(Class115.class114_0)
		{
			this.class62_0 = class62_1;
		}

		// Token: 0x060028AD RID: 10413
		// RVA: 0x0001F517 File Offset: 0x0001D717
		protected override void Dispose(bool bool_4)
		{
			this.class911_0.Dispose();
			if (this.class754_0 != null)
			{
				this.class754_0.Dispose();
			}
			base.Dispose(bool_4);
		}

		// Token: 0x060028AE RID: 10414
		// RVA: 0x0001F53E File Offset: 0x0001D73E
		public override void Draw()
		{
			if (Class115.bool_16)
			{
				return;
			}
			this.class911_0.Draw();
			base.Draw();
		}

		// Token: 0x060028AF RID: 10415
		// RVA: 0x001002C8 File Offset: 0x000FE4C8
		public override void imethod_2()
		{
			if (this.class754_0 != null && !this.class754_0.vmethod_5() && Class331.int_7 - this.int_2 > 5000)
			{
				this.class754_0.Text = "Click to add a comment at the current time!";
				this.class754_0.vmethod_6(true);
			}
			base.imethod_2();
		}

		// Token: 0x0600289B RID: 10395
		// RVA: 0x000FED68 File Offset: 0x000FCF68
		public override void Initialize()
		{
			this.class911_0 = new Class911(true);
			this.class911_0.bool_1 = false;
			if (!Class802.smethod_0())
			{
				return;
			}
			this.method_10();
			this.method_8();
			if (this.method_1())
			{
				this.method_2();
			}
			base.Initialize();
		}

		// Token: 0x06002899 RID: 10393
		// RVA: 0x0001F4AF File Offset: 0x0001D6AF
		private bool method_1()
		{
			return Class466.Current.int_2 > 0;
		}

		// Token: 0x060028A4 RID: 10404
		// RVA: 0x000FF9C4 File Offset: 0x000FDBC4
		private void method_10()
		{
			string string_;
			if (Class802.bool_16)
			{
				string_ = "SPECTATOR MODE - Watching " + Class858.class861_0.Name + " play " + Class466.Current.string_6;
			}
			else
			{
				string_ = "REPLAY MODE - Watching " + Class802.class512_0.string_2 + " play " + Class466.Current.string_6;
			}
			Class533 class = new Class533(string_, 13f, new Vector2(320f, 460f), Vector2.get_Zero(), 0.4f, true, Color.get_White(), true);
			Class746 class2 = new Class746(TransformationType.Fade, 0f, 1f, Class115.int_1, Class115.int_1 + 4000, Enum70.const_0);
			class.class26_0.Add(class2);
			class2 = new Class746(new Vector2((float)Class115.smethod_43(), 60f), new Vector2(-class.vmethod_11().X, 60f), Class115.int_1, Class115.int_1 + (int)(class.vmethod_11().X * 52f), Enum70.const_0);
			class2.bool_0 = true;
			class.class26_0.Add(class2);
			this.class911_0.Add(class);
		}

		// Token: 0x060028A5 RID: 10405
		// RVA: 0x0001F4C6 File Offset: 0x0001D6C6
		private void method_11(object sender, EventArgs e)
		{
			Class858.smethod_4(true);
			this.class62_0.enum110_0 = Enum110.const_7;
		}

		// Token: 0x060028A6 RID: 10406
		// RVA: 0x000FFAE8 File Offset: 0x000FDCE8
		private void method_12(object sender, EventArgs e)
		{
			this.class62_0.method_39();
			if (Class802.enum99_0 == Enum99.const_2)
			{
				this.class531_0.vmethod_7(Class885.Load("overlay-2x", Enum112.flag_1));
				return;
			}
			if (Class802.enum99_0 == Enum99.const_0)
			{
				this.class531_0.vmethod_7(Class885.Load("overlay-1x", Enum112.flag_1));
				return;
			}
			if (Class802.enum99_0 == Enum99.const_1)
			{
				this.class531_0.vmethod_7(Class885.Load("overlay-half", Enum112.flag_1));
			}
		}

		// Token: 0x060028A7 RID: 10407
		// RVA: 0x0001F4DA File Offset: 0x0001D6DA
		private void method_13(Class754 class754_1, bool bool_4)
		{
			if (class754_1.Text == "Click to add a comment at the current time!")
			{
				class754_1.Text = string.Empty;
			}
			if (!Class62.bool_11)
			{
				Class331.smethod_88();
				Class62.bool_11 = true;
				this.int_2 = Class331.int_7;
			}
		}

		// Token: 0x060028A8 RID: 10408
		// RVA: 0x000FFB5C File Offset: 0x000FDD5C
		private void method_14(Class754 class754_1, bool bool_4)
		{
			Class130.Delegate7 delegate = null;
			if (this.commentTargets_0 == CommentTargets.None && bool_4)
			{
				Class723.smethod_1("Select a target for your comment first!", 1500);
				this.class754_0.Select();
				return;
			}
			if (bool_4 && this.class754_0.Text.Length > 0)
			{
				Class130 class = new Class130("http://osu.ppy.sh/web/osu-comment.php");
				class.method_0("u", Class341.class605_20);
				class.method_0("p", Class341.class605_17);
				class.method_0("s", Class466.Current.int_3.ToString());
				class.method_0("b", Class466.Current.int_2.ToString(Class115.numberFormatInfo_0));
				Class130 arg_CF_0 = class;
				string arg_CF_1 = "m";
				int playModes_ = (int)Class802.class512_0.playModes_0;
				arg_CF_0.method_0(arg_CF_1, playModes_.ToString(Class115.numberFormatInfo_0));
				class.method_0("r", Class802.class512_0.long_0.ToString(Class115.numberFormatInfo_0));
				class.method_0("target", this.commentTargets_0.ToString().ToLower());
				if (this.class531_6.color_0 != Color.get_White() && this.class531_6.color_0 != Color.get_TransparentWhite())
				{
					string string_ = Class610.smethod_5(this.class531_6.color_0);
					class.method_0("f", string_);
				}
				class.method_0("a", "post");
				class.method_0("starttime", this.int_2.ToString());
				class.method_0("comment", this.class754_0.Text);
				Class130 arg_1AC_0 = class;
				if (delegate == null)
				{
					delegate = new Class130.Delegate7(this.method_21);
				}
				arg_1AC_0.method_2(delegate);
				Class169.smethod_0(class);
				this.class754_0.vmethod_6(false);
				this.class754_0.Text = "Sending...";
			}
			if (this.class754_0.Text.Length == 0)
			{
				this.class754_0.Text = "Click to add a comment at the current time!";
			}
			this.method_4();
			if (Class62.bool_11)
			{
				Class331.smethod_88();
				Class62.bool_11 = false;
			}
		}

		// Token: 0x060028A9 RID: 10409
		// RVA: 0x000FFD78 File Offset: 0x000FDF78
		private void method_15(string string_0, Exception exception_0)
		{
			Class84.Class655 class = new Class84.Class655();
			class.string_0 = string_0;
			class.class84_0 = this;
			Class115.class47_0.Add(new VoidDelegate(class.method_0), false);
		}

		// Token: 0x060028AA RID: 10410
		// RVA: 0x000FFDB0 File Offset: 0x000FDFB0
		private void method_16()
		{
			if (this.class26_0 == null || this.class26_0.Count == 0)
			{
				return;
			}
			Class653 class = this.class26_0[this.int_8];
			int num = class.method_0();
			this.method_18(class.commentTargets_0);
			bool flag;
			if (flag = (class.commentTargets_0 != CommentTargets.Replay))
			{
				if (this.int_6 == 0 || this.int_6 < class.int_0 || this.float_0 > 300f)
				{
					this.float_0 = 80f;
					this.int_6 = class.int_0 + num;
				}
			}
			else if (this.int_7 == 0 || this.int_7 < class.int_0 || this.float_1 < 300f)
			{
				this.float_1 = 420f;
				this.int_7 = class.int_0 + num;
			}
			Class533 class2 = new Class533(class.string_1, 14f, new Vector2((float)(Class115.smethod_43() / 2), 240f), 0.8f, false, Color.get_White());
			class2.origins_0 = Origins.TopCentre;
			class2.bool_16 = true;
			class2.method_58(true);
			bool flag2 = true;
			string[] array = class.string_0.Split(new char[]
			{
				'|'
			});
			string a;
			if ((a = array[0]) != null)
			{
				if (!(a == "player"))
				{
					if (!(a == "creator"))
					{
						if (!(a == "bat"))
						{
							if (a == "subscriber")
							{
								class2.method_57(new Color(255, 223, 46));
								class2.method_61(17f);
							}
						}
						else
						{
							class2.method_57(Color.get_OrangeRed());
							class2.method_61(20f);
						}
					}
					else
					{
						class2.method_57(new Color(51, 224, 255));
						class2.method_61(18f);
						flag2 = false;
						class2.vector2_1 = new Vector2((float)(Class115.smethod_43() / 2), 40f);
						num = Math.Min(5000, Math.Max(3000, num));
					}
				}
				else
				{
					class2.method_57(new Color(33, 246, 22));
					flag2 = false;
					class2.method_61(18f);
					class2.vector2_1 = new Vector2((float)(Class115.smethod_43() / 2), 440f);
					num = Math.Min(5000, Math.Max(3000, num));
				}
			}
			if (array.Length > 1)
			{
				class2.method_57(Class610.smethod_6(array[1]));
			}
			Vector2 vector = class2.vmethod_11();
			class2.enum114_0 = Enum114.const_1;
			if (flag2)
			{
				Vector2 vector2_;
				vector2_..ctor((float)Class115.smethod_43() + vector.X / 2f, flag ? this.float_0 : this.float_1);
				new Vector2((float)(Class115.smethod_43() / 2), flag ? this.float_0 : this.float_1);
				Vector2 vector2_2;
				vector2_2..ctor(-vector.X / 2f, flag ? this.float_0 : this.float_1);
				class2.class26_0.Add(new Class746(vector2_, vector2_2, class.int_0, class.int_0 + num, Enum70.const_0));
				if (flag)
				{
					this.float_0 += vector.Y;
				}
				else
				{
					this.float_1 -= vector.Y;
				}
			}
			else
			{
				class2.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, class.int_0, class.int_0 + 200, Enum70.const_0));
				class2.class26_0.Add(new Class746(TransformationType.Scale, 1.8f, 1f, class.int_0, class.int_0 + 200, Enum70.const_1));
				class2.class26_0.Add(new Class746(TransformationType.Fade, 1f, 1f, class.int_0 + num, class.int_0 + num + 100, Enum70.const_0));
			}
			this.list_1.Add(class2);
			this.class911_0.Add(class2);
			if (!Class341.class606_54)
			{
				class2.method_8(true);
			}
			this.int_8++;
			if (this.int_8 == this.class26_0.Count)
			{
				this.method_17();
				return;
			}
			Class115.class47_0.Add(new VoidDelegate(this.method_16), true);
		}

		// Token: 0x060028AB RID: 10411
		// RVA: 0x00100208 File Offset: 0x000FE408
		private void method_17()
		{
			this.class762_0.Text = string.Format("Difficulty ({0:#,0})", this.int_3);
			this.class762_2.Text = string.Format("Player ({0:#,0})", this.int_4);
			this.class762_1.Text = string.Format("Song ({0:#,0})", this.int_5);
		}

		// Token: 0x060028AC RID: 10412
		// RVA: 0x00100278 File Offset: 0x000FE478
		private void method_18(CommentTargets commentTargets_1)
		{
			switch (commentTargets_1)
			{
			case CommentTargets.Map:
				this.int_3++;
				return;
			case CommentTargets.Song:
				this.int_5++;
				return;
			case CommentTargets.Replay:
				this.int_4++;
				return;
			default:
				return;
			}
		}

		// Token: 0x060028B0 RID: 10416
		// RVA: 0x00100320 File Offset: 0x000FE520
		internal void method_19(int int_9)
		{
			Class84.Class656 class = new Class84.Class656();
			class.int_0 = 55;
			if (this.class531_0 != null)
			{
				this.class531_0.method_23(new Vector2(0f, (float)class.int_0), 500, Enum70.const_1);
			}
			if (this.class531_1 != null)
			{
				this.class531_1.method_23(new Vector2(0f, (float)class.int_0), 500, Enum70.const_1);
			}
			if (this.class531_2 != null)
			{
				this.class531_2.method_23(new Vector2(0f, (float)class.int_0), 500, Enum70.const_1);
			}
			this.list_0.ForEach(new Action<Class531>(class.method_0));
		}

		// Token: 0x0600289C RID: 10396
		// RVA: 0x000FEDB8 File Offset: 0x000FCFB8
		private void method_2()
		{
			this.class531_3 = new Class531(Class885.Load("commentbox", Enum112.flag_1), Enum115.const_7, Origins.TopRight, Enum114.const_0, new Vector2(70f, this.class531_2.vector2_1.Y - 24f), 0.95f, true, Color.get_TransparentWhite(), "play");
			this.class531_3.int_1 = 52;
			this.list_0.Add(this.class531_3);
			this.class911_0.Add(this.class531_3);
			this.class531_4 = new Class531(Class885.Load("commentbox", Enum112.flag_1), Enum115.const_7, Origins.TopRight, Enum114.const_0, new Vector2(70f, this.class531_2.vector2_1.Y - 24f), 0.95f, true, Color.get_TransparentWhite(), "play");
			this.class531_4.int_1 = 1;
			this.class531_4.int_3 = 52;
			this.class531_4.vector2_2 = new Vector2(1f, 0f);
			Class531 expr_FF_cp_0 = this.class531_4;
			expr_FF_cp_0.vector2_1.Y = expr_FF_cp_0.vector2_1.Y + 32.5f;
			this.list_0.Add(this.class531_4);
			this.class911_0.Add(this.class531_4);
			this.class531_5 = new Class531(Class885.Load("commentbox", Enum112.flag_1), Enum115.const_7, Origins.TopRight, Enum114.const_0, new Vector2(70f, this.class531_2.vector2_1.Y - 24f + 32.5f), 0.95f, true, Color.get_TransparentWhite(), "play");
			this.class531_5.int_1 = 49;
			this.class531_5.int_3 = 53;
			this.list_0.Add(this.class531_5);
			this.class911_0.Add(this.class531_5);
			float num = (float)this.class531_3.int_4 * 0.625f;
			this.class754_0 = new Class754("Click to add a comment at the current time!", 12, new Vector2(this.class531_3.method_28().X - num + 6f, this.class531_3.vector2_1.Y + 17f + 6f), num - 24f, 1f, false);
			this.class754_0.method_18(new Color(51, 197, 234, 150));
			this.class754_0.class533_0.float_3 = 0f;
			this.class754_0.class533_0.int_7 = 0;
			this.class754_0.method_4(new Class754.Delegate37(this.method_13));
			this.class754_0.bool_4 = false;
			this.class754_0.method_2(new Class754.Delegate37(this.method_14));
			this.class754_0.int_0 = 80;
			this.class754_0.method_3(new Class754.Delegate37(this.method_3));
			this.list_0.AddRange(this.class754_0.list_0);
			this.class911_0.Add<Class531>(this.class754_0.list_0);
			this.class762_0 = new Class762("Difficulty", 0.7f, new Vector2(this.class531_3.method_28().X - 250f, this.class531_3.method_28().Y + 5f), 1f, false, 0f);
			this.class911_0.Add<Class531>(this.class762_0.list_0);
			this.class762_0.method_8(new Delegate38(this.method_5));
			this.class762_0.method_10(true);
			this.class762_0.method_4("Comment on this particular difficulty");
			this.list_0.AddRange(this.class762_0.list_0);
			this.class911_0.Add<Class531>(this.class762_0.list_0);
			this.class762_1 = new Class762("Song", 0.7f, new Vector2(this.class531_3.method_28().X - 170f, this.class531_3.method_28().Y + 5f), 1f, false, 0f);
			this.class911_0.Add<Class531>(this.class762_1.list_0);
			this.class762_1.method_8(new Delegate38(this.method_5));
			this.class762_1.method_4("Comment on this collection of beatmaps or the song");
			this.class762_1.method_10(true);
			this.list_0.AddRange(this.class762_1.list_0);
			this.class911_0.Add<Class531>(this.class762_1.list_0);
			this.class762_2 = new Class762("Player", 0.7f, new Vector2(this.class531_3.method_28().X - 90f, this.class531_3.method_28().Y + 5f), 1f, false, 0f);
			this.class911_0.Add<Class531>(this.class762_2.list_0);
			this.class762_2.method_4("Comment on the current replay (the specific person playing)");
			this.class762_2.method_8(new Delegate38(this.method_5));
			this.class762_2.method_10(true);
			if (Class802.class512_0.bool_1)
			{
				this.list_0.AddRange(this.class762_2.list_0);
				this.class911_0.Add<Class531>(this.class762_2.list_0);
			}
			this.vector2_0 = new Vector2(this.class531_5.method_28().X - 250f, this.class531_5.method_28().Y + 5f);
			this.class762_3 = new Class762("Show Comments", 0.7f, this.vector2_0, 1f, Class341.class606_54, 0f);
			this.class911_0.Add<Class531>(this.class762_3.list_0);
			this.class762_3.method_8(new Delegate38(this.method_7));
			this.class762_3.method_10(true);
			this.list_0.AddRange(this.class762_3.list_0);
			this.class911_0.Add<Class531>(this.class762_3.list_0);
			this.class531_6 = new Class531(Class115.class731_0, Enum115.const_5, Origins.Centre, Enum114.const_0, this.vector2_0 + new Vector2(124f, 1f), 0.96f, true, Color.get_TransparentWhite(), null);
			this.class531_6.float_3 = 0f;
			this.class531_6.vector2_2 = new Vector2(20f, 20f);
			this.class531_6.bool_1 = true;
			this.class531_6.method_2(new EventHandler(this.method_20));
			if (Class115.class861_0 != null && (Class115.class861_0.enum30_0 & Enum30.flag_3) > Enum30.flag_0)
			{
				this.list_0.Add(this.class531_6);
				this.class911_0.Add(this.class531_6);
				Class533 class = new Class533("Colour", 10.5f, this.vector2_0 + new Vector2(94f, 2f), 0.96f, true, Color.get_TransparentWhite());
				this.list_0.Add(class);
				this.class911_0.Add(class);
			}
			if (Class341.class606_54)
			{
				this.method_6();
			}
		}

		// Token: 0x060028B1 RID: 10417
		// RVA: 0x001003D0 File Offset: 0x000FE5D0
		[CompilerGenerated]
		private void method_20(object sender, EventArgs e)
		{
			if (!Class62.bool_11 && !Class802.bool_16)
			{
				Class331.smethod_88();
				Class62.bool_11 = true;
				this.int_2 = Class331.int_7;
			}
			if (Class115.class125_0.method_0())
			{
				Class723.smethod_5("Exit fullscreen mode to use the colour pick feature.", Color.get_Red(), 2000, null);
				return;
			}
			ColorDialog colorDialog = new ColorDialog();
			if (colorDialog.ShowDialog(Class115.form_0) == DialogResult.OK)
			{
				this.class531_6.color_0 = new Color(colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
			}
			if (!Class802.bool_16)
			{
				Class331.smethod_88();
				Class62.bool_11 = false;
			}
		}

		// Token: 0x060028B4 RID: 10420
		// RVA: 0x0001F55A File Offset: 0x0001D75A
		[CompilerGenerated]
		private void method_21(string string_0, Exception exception_0)
		{
			Class115.class47_0.Add(new VoidDelegate(this.method_22), false);
		}

		// Token: 0x060028B5 RID: 10421
		// RVA: 0x0001F573 File Offset: 0x0001D773
		[CompilerGenerated]
		private void method_22()
		{
			this.method_18(this.commentTargets_0);
			this.method_17();
			this.class754_0.Text = "Please wait before commenting again...";
			Class723.smethod_5("Your comment has been submitted!", Color.get_Orange(), 3000, null);
		}

		// Token: 0x0600289D RID: 10397
		// RVA: 0x0001F4BE File Offset: 0x0001D6BE
		private void method_3(Class754 class754_1, bool bool_4)
		{
			this.method_4();
		}

		// Token: 0x0600289E RID: 10398
		// RVA: 0x000FF504 File Offset: 0x000FD704
		private void method_4()
		{
			float num = this.class754_0.class533_0.vmethod_11().Y - 13.6f;
			this.class531_4.vector2_2.Y = num * 1.6f;
			this.class531_5.vector2_1.Y = this.class531_5.vector2_0.Y + num;
		}

		// Token: 0x0600289F RID: 10399
		// RVA: 0x000FF568 File Offset: 0x000FD768
		private void method_5(object object_0, bool bool_4)
		{
			if (object_0 == this.class762_2)
			{
				if (!Class802.class512_0.bool_1)
				{
					Class723.smethod_5("This replay is not stored online.  You can't comment on local replays.", Color.get_Red(), 4000, null);
				}
				else
				{
					this.commentTargets_0 = CommentTargets.Replay;
				}
			}
			else if (object_0 == this.class762_1)
			{
				this.commentTargets_0 = CommentTargets.Song;
			}
			else if (object_0 == this.class762_0)
			{
				this.commentTargets_0 = CommentTargets.Map;
			}
			this.class762_2.method_6(this.commentTargets_0 == CommentTargets.Replay);
			this.class762_1.method_6(this.commentTargets_0 == CommentTargets.Song);
			this.class762_0.method_6(this.commentTargets_0 == CommentTargets.Map);
		}

		// Token: 0x060028A0 RID: 10400
		// RVA: 0x000FF608 File Offset: 0x000FD808
		private void method_6()
		{
			if (this.bool_3)
			{
				return;
			}
			this.bool_3 = true;
			Class130 class = new Class130("http://osu.ppy.sh/web/osu-comment.php");
			class.method_0("u", Class341.class605_20);
			class.method_0("p", Class341.class605_17);
			class.method_0("b", Class466.Current.int_2.ToString());
			class.method_0("s", Class466.Current.int_3.ToString());
			class.method_0("r", Class802.class512_0.long_0.ToString(Class115.numberFormatInfo_0));
			Class130 arg_B5_0 = class;
			string arg_B5_1 = "m";
			int playModes_ = (int)Class802.class512_0.playModes_0;
			arg_B5_0.method_0(arg_B5_1, playModes_.ToString(Class115.numberFormatInfo_0));
			class.method_0("a", "get");
			class.method_2(new Class130.Delegate7(this.method_15));
			Class169.smethod_0(class);
		}

		// Token: 0x060028A1 RID: 10401
		// RVA: 0x000FF6F8 File Offset: 0x000FD8F8
		private void method_7(object object_0, bool bool_4)
		{
			Class84.Class654 class = new Class84.Class654();
			class.bool_0 = bool_4;
			this.method_6();
			Class341.class606_54.Value = class.bool_0;
			this.list_1.ForEach(new Action<Class531>(class.method_0));
		}

		// Token: 0x060028A2 RID: 10402
		// RVA: 0x000FF740 File Offset: 0x000FD940
		private void method_8()
		{
			Class746 class746_ = new Class746(Color.get_White(), new Color(255, 247, 197), 0, 100);
			int num = 85;
			if (this.method_1())
			{
				this.class531_2 = new Class531(Class885.Load("overlay-discussion", Enum112.flag_1), Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(40f, (float)num), 1f, true, Color.get_White(), "play");
				this.class531_2.method_15(500);
				this.class531_2.class746_1 = class746_;
				this.class531_2.bool_1 = true;
				this.class531_2.method_2(new EventHandler(this.method_9));
				this.class911_0.Add(this.class531_2);
				num += 20;
			}
			this.class531_0 = new Class531(Class885.Load("overlay-1x", Enum112.flag_1), Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(40f, (float)num), 1f, true, Color.get_White(), "play");
			this.class531_0.method_15(500);
			this.class531_0.class746_1 = class746_;
			this.class531_0.bool_1 = true;
			this.class531_0.method_2(new EventHandler(this.method_12));
			this.class911_0.Add(this.class531_0);
			num += 20;
			this.class531_1 = new Class531(Class885.Load("overlay-endreplay", Enum112.flag_1), Enum115.const_7, Origins.Centre, Enum114.const_0, new Vector2(40f, (float)num), 1f, true, Color.get_White(), "play");
			this.class531_1.method_15(500);
			this.class531_1.class746_1 = class746_;
			this.class531_1.bool_1 = true;
			this.class531_1.method_2(new EventHandler(this.method_11));
			this.class911_0.Add(this.class531_1);
			num += 20;
		}

		// Token: 0x060028A3 RID: 10403
		// RVA: 0x000FF920 File Offset: 0x000FDB20
		private void method_9(object sender, EventArgs e)
		{
			this.bool_2 = !this.bool_2;
			if (this.bool_2)
			{
				List<Class531> arg_3A_0 = this.list_0;
				if (Class84.action_0 == null)
				{
					Class84.action_0 = new Action<Class531>(Class84.smethod_0);
				}
				arg_3A_0.ForEach(Class84.action_0);
				this.class531_2.vmethod_7(Class885.Load("overlay-discussion2", Enum112.flag_1));
				return;
			}
			List<Class531> arg_79_0 = this.list_0;
			if (Class84.action_1 == null)
			{
				Class84.action_1 = new Action<Class531>(Class84.smethod_1);
			}
			arg_79_0.ForEach(Class84.action_1);
			this.class531_2.vmethod_7(Class885.Load("overlay-discussion", Enum112.flag_1));
		}

		// Token: 0x060028B2 RID: 10418
		// RVA: 0x00018A38 File Offset: 0x00016C38
		[CompilerGenerated]
		private static void smethod_0(Class531 class531_7)
		{
			class531_7.method_14(100, Enum70.const_0);
		}

		// Token: 0x060028B3 RID: 10419
		// RVA: 0x00018A43 File Offset: 0x00016C43
		[CompilerGenerated]
		private static void smethod_1(Class531 class531_7)
		{
			class531_7.method_16(100, Enum70.const_0);
		}
	}
}
