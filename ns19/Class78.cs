using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns17;
using ns26;
using ns27;
using ns29;
using ns30;
using ns6;
using ns64;
using ns74;
using ns79;
using ns8;
using ns80;
using ns81;
using ns82;
using ns9;
using osu;
using osu.Graphics.Sprites;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns19
{
	// Token: 0x02000528 RID: 1320
	internal sealed class Class78 : Class61
	{
		// Token: 0x02000529 RID: 1321
		[CompilerGenerated]
		private sealed class Class694
		{
			// Token: 0x04002383 RID: 9091
			public Class690 class690_0;

			// Token: 0x04002384 RID: 9092
			public Class78 class78_0;

			// Token: 0x06002AD0 RID: 10960
			// RVA: 0x001156F8 File Offset: 0x001138F8
			public void method_0(object sender, EventArgs e)
			{
				lock (this.class78_0.list_0)
				{
					this.class78_0.list_0.Remove(this.class690_0);
				}
				this.class78_0.bool_2 = true;
				this.class690_0.Dispose();
			}
		}

		// Token: 0x04002380 RID: 9088
		[CompilerGenerated]
		private static Action<Class690> action_0;

		// Token: 0x04002381 RID: 9089
		[CompilerGenerated]
		private static Action<Class690> action_1;

		// Token: 0x04002382 RID: 9090
		[CompilerGenerated]
		private static Action<Class690> action_2;

		// Token: 0x04002379 RID: 9081
		private bool bool_2;

		// Token: 0x0400237A RID: 9082
		private readonly bool bool_3;

		// Token: 0x0400237C RID: 9084
		private bool bool_4;

		// Token: 0x0400237F RID: 9087
		private bool bool_5;

		// Token: 0x04002373 RID: 9075
		private readonly Class110 class110_0;

		// Token: 0x04002371 RID: 9073
		private readonly Class531 class531_0;

		// Token: 0x04002372 RID: 9074
		private readonly Class533 class533_0;

		// Token: 0x04002374 RID: 9076
		private readonly Class533 class533_1;

		// Token: 0x0400236F RID: 9071
		private readonly Class753 class753_0;

		// Token: 0x04002370 RID: 9072
		private readonly Class753 class753_1;

		// Token: 0x04002375 RID: 9077
		private readonly Class755 class755_0;

		// Token: 0x0400236E RID: 9070
		private readonly Class762 class762_0;

		// Token: 0x04002376 RID: 9078
		private readonly Class911 class911_1;

		// Token: 0x04002377 RID: 9079
		private readonly Class911 class911_2;

		// Token: 0x0400237B RID: 9083
		private int int_2;

		// Token: 0x0400237E RID: 9086
		private int int_3;

		// Token: 0x0400236D RID: 9069
		private readonly List<Class690> list_0;

		// Token: 0x04002378 RID: 9080
		private string string_0;

		// Token: 0x0400237D RID: 9085
		private string string_1;

		// Token: 0x06002ABC RID: 10940
		// RVA: 0x00114AFC File Offset: 0x00112CFC
		public Class78(Class114 class114_1)
		{
			EventHandler eventHandler = null;
			EventHandler eventHandler2 = null;
			EventHandler eventHandler3 = null;
			this.list_0 = new List<Class690>();
			base..ctor(class114_1);
			if (Class331.enum100_0 == Enum100.const_1)
			{
				this.bool_3 = true;
				Class331.smethod_88();
			}
			this.class911_1 = new Class911(true);
			this.class110_0 = new Class110(new Rectangle(0, 82, Class115.smethod_43() - 4 - 120, 350), Vector2.get_Zero(), true, 0f, Enum98.const_2);
			this.class911_2 = new Class911(true);
			this.class533_1 = new Class533("Type a search to begin.", 11f, new Vector2(20f, 40f), 1f, true, Color.get_YellowGreen());
			this.class533_1.bool_16 = true;
			this.class911_1.Add(this.class533_1);
			this.class533_0 = new Class533("", 16f, new Vector2(20f, 80f), 1f, true, Color.get_White());
			this.class911_1.Add(this.class533_0);
			this.class755_0 = new Class755(18, new Vector2(20f, 20f), 300f, false, 1.1f);
			this.class755_0.method_3(delegate(Class754 class754_0, bool bool_6)
			{
				this.int_2 = Class115.int_1 + 600;
			});
			this.class911_2.Add<Class531>(this.class755_0.list_0);
			this.class531_0 = new Class531(Class885.Load("searching", Enum112.flag_1), new Vector2(320f, 240f), 1f, true, Color.get_TransparentWhite());
			this.class531_0.origins_0 = Origins.Centre;
			this.class531_0.vmethod_9();
			Class115.class911_0.Add(this.class531_0);
			Class591 class = new Class591(new EventHandler(this.method_5), true, false);
			this.class911_2.Add<Class531>(class.list_0);
			int num = 330;
			string arg_230_0 = "Newest Maps";
			Vector2 arg_230_1 = new Vector2(330f, 20f);
			Vector2 arg_230_2 = new Vector2(100f, 20f);
			float arg_230_3 = 1f;
			Color arg_230_4 = Color.get_Orange();
			if (eventHandler == null)
			{
				eventHandler = new EventHandler(this.method_8);
			}
			Class760 class2 = new Class760(arg_230_0, arg_230_1, arg_230_2, arg_230_3, arg_230_4, eventHandler, true, false, null);
			this.class911_1.Add<Class531>(class2.list_0);
			num += 105;
			string arg_296_0 = "Top Rated";
			Vector2 arg_296_1 = new Vector2((float)num, 20f);
			Vector2 arg_296_2 = new Vector2(100f, 20f);
			float arg_296_3 = 1f;
			Color arg_296_4 = Color.get_OrangeRed();
			if (eventHandler2 == null)
			{
				eventHandler2 = new EventHandler(this.method_9);
			}
			class2 = new Class760(arg_296_0, arg_296_1, arg_296_2, arg_296_3, arg_296_4, eventHandler2, true, false, null);
			this.class911_1.Add<Class531>(class2.list_0);
			num += 105;
			string arg_2FC_0 = "Most Played";
			Vector2 arg_2FC_1 = new Vector2((float)num, 20f);
			Vector2 arg_2FC_2 = new Vector2(100f, 20f);
			float arg_2FC_3 = 1f;
			Color arg_2FC_4 = Color.get_SkyBlue();
			if (eventHandler3 == null)
			{
				eventHandler3 = new EventHandler(this.method_10);
			}
			class2 = new Class760(arg_2FC_0, arg_2FC_1, arg_2FC_2, arg_2FC_3, arg_2FC_4, eventHandler3, true, false, null);
			this.class911_1.Add<Class531>(class2.list_0);
			Class533 class3 = new Class533("Display:", 11f, new Vector2(5f, 55f), 1f, true, Color.get_White());
			class3.bool_16 = true;
			this.class911_1.Add(class3);
			this.class762_0 = new Class762("Show already downloaded maps", 0.88f, new Vector2(320f, 54f), 1f, false, 0f);
			this.class911_1.Add<Class531>(this.class762_0.list_0);
			this.class762_0.method_8(new Delegate38(this.method_1));
			this.class753_0 = new Class753(this.class911_2, "", new Vector2(50f, 54f));
			this.class753_0.method_9("All", 4);
			this.class753_0.method_9("Ranked", 0);
			this.class753_0.method_9("Ranked (Played)", 7);
			this.class753_0.method_9("Qualified", 3);
			this.class753_0.method_9("Pending/Help", 2);
			this.class753_0.method_9("Graveyard", 5);
			this.class753_0.method_18(4, true);
			this.class753_0.method_0(new EventHandler(this.method_2));
			class3 = new Class533("Mode:", 11f, new Vector2(180f, 55f), 1f, true, Color.get_White());
			class3.bool_16 = true;
			this.class911_1.Add(class3);
			this.class753_1 = new Class753(this.class911_2, "", new Vector2(220f, 54f), 85f, 1f);
			this.class753_1.method_9("All", -1);
			this.class753_1.method_9("osu!", 0);
			this.class753_1.method_9("Taiko", 1);
			this.class753_1.method_9("Catch the Beat", 2);
			this.class753_1.method_9("osu!mania", 3);
			this.class753_1.method_18(-1, true);
			this.class753_1.method_0(new EventHandler(this.method_3));
			Class570.smethod_4(new Class570.Delegate45(this.method_4));
		}

		// Token: 0x06002AC1 RID: 10945
		// RVA: 0x001150A8 File Offset: 0x001132A8
		protected override void Dispose(bool bool_6)
		{
			List<Class690> arg_23_0 = this.list_0;
			if (Class78.action_0 == null)
			{
				Class78.action_0 = new Action<Class690>(Class78.smethod_0);
			}
			arg_23_0.ForEach(Class78.action_0);
			Class570.smethod_5(new Class570.Delegate45(this.method_4));
			this.class911_1.Dispose();
			this.class911_2.Dispose();
			this.class110_0.Dispose();
			this.class755_0.Dispose();
			Class115.class911_0.Remove(this.class531_0);
			base.Dispose(bool_6);
			if (this.bool_3)
			{
				Class331.smethod_88();
			}
		}

		// Token: 0x06002AC6 RID: 10950
		// RVA: 0x00020C4A File Offset: 0x0001EE4A
		public override void Draw()
		{
			this.class911_1.Draw();
			this.class110_0.Draw();
			this.class911_2.Draw();
			base.Draw();
		}

		// Token: 0x06002AC7 RID: 10951
		// RVA: 0x001154AC File Offset: 0x001136AC
		public override void imethod_2()
		{
			this.class755_0.method_25(!Class111.bool_2);
			bool flag;
			if (this.string_0 == null)
			{
				this.string_0 = "Newest";
				this.bool_4 = false;
				this.method_6(true);
				flag = false;
			}
			else
			{
				flag = (this.int_2 >= 0 && this.int_2 <= Class115.int_1);
			}
			if (flag)
			{
				bool flag2 = this.class755_0.Text != this.string_0;
				if (this.class755_0.Text.Length == 0)
				{
					if (flag2 && this.string_0 != "Newest" && this.string_0 != "Top Rated" && this.string_0 != "Most Played")
					{
						this.string_0 = "Newest";
						this.method_6(true);
					}
				}
				else if (!this.bool_4 && flag2)
				{
					this.string_0 = this.class755_0.Text;
					this.method_6(true);
					this.int_2 = -1;
				}
			}
			this.class110_0.imethod_2();
			if (this.class110_0.vector2_3.Y > this.class110_0.vector2_2.Y - this.class110_0.rectangleF_0.Height && this.bool_5 && !this.bool_4)
			{
				this.int_3++;
				this.method_6(false);
			}
			if (this.bool_2)
			{
				this.class531_0.method_16(200, Enum70.const_0);
				int num = 0;
				lock (this.list_0)
				{
					foreach (Class690 current in this.list_0)
					{
						if (current.method_2(new Vector2(10f, (float)num)))
						{
							this.class110_0.class911_0.Add<Class531>(current.list_0);
						}
						num += 30;
					}
				}
				this.class110_0.method_14(new Vector2(640f, (float)(num + 30)));
				this.bool_4 = false;
				this.bool_2 = false;
			}
			base.imethod_2();
		}

		// Token: 0x06002ABD RID: 10941
		// RVA: 0x00020C05 File Offset: 0x0001EE05
		public override void Initialize()
		{
			this.class753_0.method_18(0, false);
			base.Initialize();
		}

		// Token: 0x06002ABE RID: 10942
		// RVA: 0x00020C20 File Offset: 0x0001EE20
		private void method_1(object object_0, bool bool_6)
		{
			this.method_6(true);
		}

		// Token: 0x06002ACB RID: 10955
		// RVA: 0x00020CDE File Offset: 0x0001EEDE
		[CompilerGenerated]
		private void method_10(object sender, EventArgs e)
		{
			this.string_0 = "Most Played";
			this.class755_0.method_28();
			this.class753_0.method_18(0, false);
		}

		// Token: 0x06002ABF RID: 10943
		// RVA: 0x00020C29 File Offset: 0x0001EE29
		private void method_2(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.string_0))
			{
				this.string_0 = "Newest";
			}
			this.method_6(true);
		}

		// Token: 0x06002AC0 RID: 10944
		// RVA: 0x00020C29 File Offset: 0x0001EE29
		private void method_3(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.string_0))
			{
				this.string_0 = "Newest";
			}
			this.method_6(true);
		}

		// Token: 0x06002AC2 RID: 10946
		// RVA: 0x00115140 File Offset: 0x00113340
		private bool method_4(object object_0, Keys keys_0, bool bool_6)
		{
			if (!bool_6)
			{
				return false;
			}
			if (keys_0 == 13)
			{
				this.int_2 = Class115.int_1;
				return true;
			}
			if (keys_0 == 27)
			{
				this.method_5(null, null);
				return true;
			}
			return false;
		}

		// Token: 0x06002AC3 RID: 10947
		// RVA: 0x00019F21 File Offset: 0x00018121
		private void method_5(object sender, EventArgs e)
		{
			Class331.smethod_60("menuback", 1f, Enum112.flag_5);
			Class115.smethod_70(OsuModes.Menu, false);
		}

		// Token: 0x06002AC4 RID: 10948
		// RVA: 0x00115178 File Offset: 0x00113378
		private void method_6(bool bool_6)
		{
			if (this.bool_4)
			{
				return;
			}
			if (bool_6)
			{
				this.int_3 = 0;
				this.bool_5 = false;
			}
			this.bool_4 = true;
			Class133 class = new Class133(string.Format("http://osu.ppy.sh/web/osu-search.php?u={0}&h={1}&r={2}&q={3}&m={4}&p={5}", new object[]
			{
				Class341.class605_20,
				Class341.class605_17,
				(int)this.class753_0.object_0,
				Class34.smethod_8(this.string_0),
				(int)this.class753_1.object_0,
				this.int_3
			}));
			class.method_0(new Class133.Delegate17(this.method_7));
			Class169.smethod_0(class);
			this.class533_1.Text = (bool_6 ? "Searching..." : "Loading...");
			if (bool_6)
			{
				this.class531_0.method_14(200, Enum70.const_0);
				List<Class690> arg_FF_0 = this.list_0;
				if (Class78.action_1 == null)
				{
					Class78.action_1 = new Action<Class690>(Class78.smethod_1);
				}
				arg_FF_0.ForEach(Class78.action_1);
			}
		}

		// Token: 0x06002AC5 RID: 10949
		// RVA: 0x0011528C File Offset: 0x0011348C
		private void method_7(string string_2, Exception exception_0)
		{
			lock (this.list_0)
			{
				if (this.int_3 == 0)
				{
					List<Class690> arg_39_0 = this.list_0;
					if (Class78.action_2 == null)
					{
						Class78.action_2 = new Action<Class690>(Class78.smethod_2);
					}
					arg_39_0.ForEach(Class78.action_2);
					this.list_0.Clear();
					this.class110_0.method_17(Vector2.get_Zero(), 0f);
				}
				string[] array = string_2.Split(new char[]
				{
					'\n'
				});
				try
				{
					int num = int.Parse(array[0]);
					this.string_1 = string.Empty;
					if (num < 0)
					{
						this.class533_1.Text = "Error: " + array[1];
					}
					else
					{
						for (int i = 1; i < array.Length; i++)
						{
							Class78.Class694 class = new Class78.Class694();
							class.class78_0 = this;
							if (array[i].Length != 0)
							{
								class.class690_0 = new Class690(array[i]);
								class.class690_0.method_7(new EventHandler(class.method_0));
								if (this.class762_0.method_2() || !class.class690_0.bool_1)
								{
									this.list_0.Add(class.class690_0);
								}
							}
						}
						this.bool_5 = (num > 100 && this.int_3 != 39);
						num = Math.Min(100, num);
						int num2 = this.int_3 * 100 + num;
						if (this.bool_5)
						{
							this.class533_1.Text = "Over " + num2 + " results found.";
						}
						else
						{
							this.class533_1.Text = string.Concat(new object[]
							{
								num2,
								" result",
								(num2 != 1) ? "s" : "",
								" found."
							});
						}
					}
				}
				catch
				{
				}
			}
			this.bool_2 = true;
		}

		// Token: 0x06002AC9 RID: 10953
		// RVA: 0x00020C88 File Offset: 0x0001EE88
		[CompilerGenerated]
		private void method_8(object sender, EventArgs e)
		{
			this.string_0 = "Newest";
			this.class755_0.method_28();
			this.class753_0.method_18(0, false);
		}

		// Token: 0x06002ACA RID: 10954
		// RVA: 0x00020CB3 File Offset: 0x0001EEB3
		[CompilerGenerated]
		private void method_9(object sender, EventArgs e)
		{
			this.string_0 = "Top Rated";
			this.class755_0.method_28();
			this.class753_0.method_18(0, false);
		}

		// Token: 0x06002ACC RID: 10956
		// RVA: 0x00020D09 File Offset: 0x0001EF09
		[CompilerGenerated]
		private static void smethod_0(Class690 class690_0)
		{
			class690_0.Dispose();
		}

		// Token: 0x06002ACD RID: 10957
		// RVA: 0x00020D11 File Offset: 0x0001EF11
		[CompilerGenerated]
		private static void smethod_1(Class690 class690_0)
		{
			class690_0.method_9();
		}

		// Token: 0x06002ACE RID: 10958
		// RVA: 0x00020D09 File Offset: 0x0001EF09
		[CompilerGenerated]
		private static void smethod_2(Class690 class690_0)
		{
			class690_0.Dispose();
		}
	}
}
