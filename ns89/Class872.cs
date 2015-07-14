using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns18;
using ns23;
using ns24;
using ns26;
using ns29;
using ns59;
using ns64;
using ns70;
using ns77;
using ns79;
using ns8;
using ns80;
using ns90;
using osu;
using osu.GameplayElements.Events;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns89
{
	// Token: 0x0200066E RID: 1646
	internal sealed class Class872 : IDisposable
	{
		// Token: 0x0200066F RID: 1647
		[CompilerGenerated]
		private sealed class Class873
		{
			// Token: 0x04003007 RID: 12295
			public float float_0;

			// Token: 0x0600339B RID: 13211
			// RVA: 0x001615E4 File Offset: 0x0015F7E4
			public void method_0(Class530 class530_0)
			{
				Class531 class = class530_0 as Class531;
				if (class != null)
				{
					class530_0.vector2_2 = new Vector2((class530_0.vector2_2.X < 0f) ? (-this.float_0) : this.float_0, 768f / (float)class.int_5);
				}
			}
		}

		// Token: 0x02000670 RID: 1648
		[CompilerGenerated]
		private sealed class Class874
		{
			// Token: 0x0400300A RID: 12298
			public Class872 class872_0;

			// Token: 0x04003008 RID: 12296
			public int int_0;

			// Token: 0x04003009 RID: 12297
			public int int_1;

			// Token: 0x0600339D RID: 13213
			// RVA: 0x00161634 File Offset: 0x0015F834
			public void method_0()
			{
				for (int i = this.int_0; i < this.int_1; i++)
				{
					Class702 class = this.class872_0.list_1[i];
					if (!class.bool_0)
					{
						class.Load();
					}
				}
				this.class872_0.int_4 = this.int_1;
			}
		}

		// Token: 0x02000671 RID: 1649
		[CompilerGenerated]
		private sealed class Class875
		{
			// Token: 0x0400300D RID: 12301
			public bool bool_0;

			// Token: 0x0400300E RID: 12302
			public bool bool_1;

			// Token: 0x0400300B RID: 12299
			public Class427 class427_0;

			// Token: 0x0400300C RID: 12300
			public Class531 class531_0;

			// Token: 0x0400300F RID: 12303
			public Class872 class872_0;

			// Token: 0x0600339F RID: 13215
			// RVA: 0x00026112 File Offset: 0x00024312
			public void method_0(Class531 class531_1)
			{
				if (this.bool_0)
				{
					class531_1.vector2_1 = this.class531_0.vector2_1;
				}
				if (this.bool_1)
				{
					this.class427_0.vmethod_50(class531_1);
				}
				this.class872_0.bool_8 = true;
			}
		}

		// Token: 0x04003004 RID: 12292
		[CompilerGenerated]
		private static Action<Class530> action_0;

		// Token: 0x04003005 RID: 12293
		[CompilerGenerated]
		private static Action<Class530> action_1;

		// Token: 0x04002FD4 RID: 12244
		internal bool bool_0;

		// Token: 0x04002FD7 RID: 12247
		internal static bool bool_1;

		// Token: 0x04002FED RID: 12269
		internal bool bool_10;

		// Token: 0x04002FF5 RID: 12277
		public bool bool_11;

		// Token: 0x04002FF6 RID: 12278
		public bool bool_12;

		// Token: 0x04002FF7 RID: 12279
		internal static bool bool_13;

		// Token: 0x04002FFE RID: 12286
		[CompilerGenerated]
		private bool bool_14;

		// Token: 0x04002FD8 RID: 12248
		private static bool bool_2 = true;

		// Token: 0x04002FD9 RID: 12249
		private static bool bool_3 = true;

		// Token: 0x04002FE1 RID: 12257
		private bool bool_4 = true;

		// Token: 0x04002FE2 RID: 12258
		private bool bool_5;

		// Token: 0x04002FE3 RID: 12259
		private bool bool_6 = true;

		// Token: 0x04002FE4 RID: 12260
		private bool bool_7;

		// Token: 0x04002FE5 RID: 12261
		private bool bool_8;

		// Token: 0x04002FEC RID: 12268
		internal bool[] bool_9;

		// Token: 0x04002FF1 RID: 12273
		private readonly Class297 class297_0;

		// Token: 0x04002FDC RID: 12252
		private readonly Class531 class531_0;

		// Token: 0x04002FDD RID: 12253
		private readonly Class531 class531_1;

		// Token: 0x04002FD5 RID: 12245
		internal Class702 class702_0;

		// Token: 0x04002FD6 RID: 12246
		internal static Class705 class705_0;

		// Token: 0x04002FD2 RID: 12242
		internal static Class872 class872_0;

		// Token: 0x04002FE6 RID: 12262
		internal Class911 class911_0;

		// Token: 0x04002FE7 RID: 12263
		internal Class911 class911_1;

		// Token: 0x04002FE8 RID: 12264
		internal Class911 class911_2;

		// Token: 0x04002FE9 RID: 12265
		internal Class911 class911_3 = new Class911(true)
		{
			float_0 = 0f
		};

		// Token: 0x04002FD3 RID: 12243
		internal static Color color_0;

		// Token: 0x04003001 RID: 12289
		[CompilerGenerated]
		private static Comparison<Class705> comparison_0;

		// Token: 0x04002FFB RID: 12283
		private static Delegate51 delegate51_0;

		// Token: 0x04002FFA RID: 12282
		private static Delegate55 delegate55_0;

		// Token: 0x04002FDA RID: 12250
		private static float float_0;

		// Token: 0x04002FDB RID: 12251
		private float float_1;

		// Token: 0x04002FF2 RID: 12274
		private float float_2 = 1f;

		// Token: 0x04002FF4 RID: 12276
		private static float float_3 = 0f;

		// Token: 0x04002FEF RID: 12271
		public int int_0;

		// Token: 0x04002FF0 RID: 12272
		public int int_1;

		// Token: 0x04002FF3 RID: 12275
		internal static int int_2 = Class341.class608_1;

		// Token: 0x04002FF8 RID: 12280
		private int int_3;

		// Token: 0x04002FF9 RID: 12281
		private int int_4;

		// Token: 0x04002FDE RID: 12254
		internal List<Class705> list_0;

		// Token: 0x04002FDF RID: 12255
		internal List<Class702> list_1;

		// Token: 0x04002FE0 RID: 12256
		internal List<Class704> list_2;

		// Token: 0x04002FEA RID: 12266
		internal List<Class702>[] list_3;

		// Token: 0x04002FEB RID: 12267
		internal List<Class702>[] list_4;

		// Token: 0x04002FEE RID: 12270
		internal List<Class541> list_5 = new List<Class541>();

		// Token: 0x04002FFF RID: 12287
		[CompilerGenerated]
		private static Predicate<Class702> predicate_0;

		// Token: 0x04003000 RID: 12288
		[CompilerGenerated]
		private static Predicate<Class702> predicate_1;

		// Token: 0x04003002 RID: 12290
		[CompilerGenerated]
		private static Predicate<Class702> predicate_2;

		// Token: 0x04003003 RID: 12291
		[CompilerGenerated]
		private static Predicate<Class702> predicate_3;

		// Token: 0x04003006 RID: 12294
		[CompilerGenerated]
		private static Predicate<Class705> predicate_4;

		// Token: 0x04002FFC RID: 12284
		private static VoidDelegate voidDelegate_0;

		// Token: 0x04002FFD RID: 12285
		private static VoidDelegate voidDelegate_1;

		// Token: 0x0600336C RID: 13164
		// RVA: 0x0015FA24 File Offset: 0x0015DC24
		internal Class872(Class297 class297_1)
		{
			Class872.Class873 class = new Class872.Class873();
			Class872.class872_0 = this;
			this.class297_0 = class297_1;
			Class872.color_0 = new Color(163, 162, 255);
			this.class531_1 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(0f, 0f), 0.9f, true, Color.get_TransparentBlack(), null);
			this.class531_1.bool_13 = false;
			this.class531_1.vector2_2 = new Vector2((float)Class115.int_22, (float)Class115.int_23 * 0.125f);
			this.class531_0 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(0f, (float)((double)Class115.int_19 * 0.875)), 0.9f, true, Color.get_TransparentBlack(), null);
			this.class531_0.bool_13 = false;
			this.class531_0.vector2_2 = new Vector2((float)Class115.int_22, (float)Class115.int_23 * 0.125f);
			this.class911_3.Add(new Class531(Class885.Load("masking-border", Enum112.flag_5), Enum115.const_6, Origins.TopRight, Enum114.const_0, new Vector2(-319.5f, 0f))
			{
				bool_0 = true,
				nullable_2 = new bool?(true)
			});
			Class911 arg_1B9_0 = this.class911_3;
			Class531 class2 = new Class531(Class885.Load("masking-border", Enum112.flag_5), Enum115.const_6, Origins.TopLeft, Enum114.const_0, new Vector2(319.5f, 0f));
			class2.method_45(true);
			class2.bool_0 = true;
			class2.nullable_2 = new bool?(true);
			arg_1B9_0.Add(class2);
			class.float_0 = 1f + Math.Max(0f, (float)Class115.smethod_43() * 1.6f / 2f - 172f - 512f) / 170f;
			this.class911_3.list_2.ForEach(new Action<Class530>(class.method_0));
			this.Reset();
		}

		// Token: 0x06003370 RID: 13168
		// RVA: 0x0015FF54 File Offset: 0x0015E154
		internal void Add(Class702 class702_1)
		{
			if (class702_1.int_0 > this.int_0)
			{
				this.int_0 = class702_1.int_0;
			}
			if (class702_1.int_2 < this.int_1)
			{
				this.int_1 = class702_1.int_2;
			}
			this.list_1.Add(class702_1);
			if (class702_1.class531_0 != null && this.bool_9[(int)class702_1.storyLayer_0])
			{
				this.bool_11 = true;
				if (class702_1.storyLayer_0 == StoryLayer.Background)
				{
					if (this.class702_0 != null && class702_1.string_0 == this.class702_0.string_0)
					{
						this.bool_0 = true;
					}
					if (!this.class911_0.bool_4)
					{
						this.class911_0.Add(class702_1.class531_0);
					}
				}
				else if (!this.class911_2.bool_4)
				{
					this.class911_2.Add(class702_1.class531_0);
				}
			}
			if (class702_1.storyLayer_0 == StoryLayer.Fail || class702_1.storyLayer_0 == StoryLayer.Pass)
			{
				this.bool_12 = true;
			}
			switch (class702_1.eventTypes_0)
			{
			case EventTypes.Video:
				this.list_5.Add((Class541)class702_1.class531_0);
				return;
			case EventTypes.Break:
				this.list_0.Add((Class705)class702_1);
				this.list_0.Sort();
				return;
			case EventTypes.Colour:
				break;
			case EventTypes.Sprite:
			case EventTypes.Animation:
				this.list_3[(int)class702_1.storyLayer_0].Add(class702_1);
				break;
			case EventTypes.Sample:
			{
				this.list_4[(int)class702_1.storyLayer_0].Add(class702_1);
				Class704 class = (Class704)class702_1;
				Class331.list_1.Add(class.class338_0);
				this.list_2.Add(class);
				this.list_2.Sort();
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x06003372 RID: 13170
		// RVA: 0x00160240 File Offset: 0x0015E440
		internal Class702 Add(string string_0, int int_5)
		{
			this.float_1 += 0.001f;
			try
			{
				string text = Path.GetExtension(string_0).ToLower();
				Class531 class = null;
				string key;
				switch (key = text)
				{
				case ".png":
				case ".jpg":
				case ".jpeg":
				{
					Class731 class2 = Class885.Load(string_0, Enum112.flag_3);
					Class531 class3 = null;
					if (class2 == null && Class115.osuModes_1 == OsuModes.Play && !Class115.bool_25)
					{
						Class466.Current.object_0 = false;
					}
					else
					{
						class3 = new Class531(class2, Enum115.const_3, Origins.Centre, Enum114.const_1, Vector2.get_Zero());
					}
					Class702 class4 = new Class706(class3, string_0, -100000, 1000 * Class331.smethod_31());
					if (class4.class531_0 == null)
					{
						Class723.smethod_1(Class41.GetString(OsuString.OsuIsAngry), 5000);
					}
					else
					{
						class4.class531_0.bool_0 = true;
						class4.class531_0.float_0 = this.float_1;
					}
					class4.eventTypes_0 = EventTypes.Background;
					class4.bool_2 = true;
					this.class702_0 = class4;
					this.list_1.Add(class4);
					class4.bool_1 = true;
					if (class4.class531_0 != null)
					{
						this.class911_1.method_9(class4.class531_0);
					}
					Class702 result = class4;
					return result;
				}
				case ".avi":
				case ".mpg":
				case ".flv":
				case ".wmv":
				{
					Class702 result;
					if (!Class466.Current.method_68(string_0))
					{
						result = null;
						return result;
					}
					if (Class872.smethod_2())
					{
						if (Class115.osuModes_1 == OsuModes.Edit || Class115.bool_25)
						{
							if (!Class341.class606_17)
							{
								goto IL_21F;
							}
						}
						try
						{
							class = new Class541(string_0, int_5);
							class.float_2 = (float)Class115.int_20 / (float)class.int_4;
							this.list_5.Add((Class541)class);
						}
						catch (Exception)
						{
							Class723.smethod_4("Video playback failed.  This could be due to missing dll files (try running the updater).");
						}
					}
					IL_21F:
					Class702 class4 = new Class707(class as Class541, string_0, int_5);
					if (class != null)
					{
						class.float_0 = this.float_1;
						class.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, int_5, int_5 + 1000, Enum70.const_0));
						class.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, ((Class541)class).int_7 - 1000, ((Class541)class).int_7, Enum70.const_0));
						this.class911_1.method_9(class);
						class4.class531_0.float_0 = this.float_1;
					}
					class4.bool_2 = true;
					this.list_1.Add(class4);
					result = class4;
					return result;
				}
				}
				throw new Exception("moo");
			}
			catch (Exception)
			{
				Class723.smethod_4("An error occurred while adding this file.");
			}
			return null;
		}

		// Token: 0x06003371 RID: 13169
		// RVA: 0x001600FC File Offset: 0x0015E2FC
		public void Add(Class702 class702_1, StoryLayer storyLayer_0, int int_5)
		{
			if (class702_1.int_0 > this.int_0)
			{
				this.int_0 = class702_1.int_0;
			}
			if (class702_1.int_2 < this.int_1)
			{
				this.int_1 = class702_1.int_2;
			}
			class702_1.storyLayer_0 = storyLayer_0;
			this.list_1.Add(class702_1);
			if (int_5 > this.list_3[(int)storyLayer_0].Count - 1)
			{
				this.list_3[(int)storyLayer_0].Add(class702_1);
			}
			else
			{
				this.list_3[(int)storyLayer_0].Insert(int_5, class702_1);
			}
			int count = this.list_3[(int)storyLayer_0].Count;
			for (int i = int_5; i < count - 1; i++)
			{
				this.list_3[(int)storyLayer_0][i].class531_0.float_0 = this.list_3[(int)storyLayer_0][i + 1].class531_0.float_0;
			}
			this.list_3[(int)storyLayer_0][count - 1].class531_0.float_0 = Class872.smethod_6(class702_1.storyLayer_0);
			if (class702_1.class531_0 != null)
			{
				if (class702_1.storyLayer_0 == StoryLayer.Background)
				{
					this.class911_0.Add(class702_1.class531_0);
					this.class911_0.method_10();
					return;
				}
				this.class911_2.Add(class702_1.class531_0);
				this.class911_2.method_10();
			}
		}

		// Token: 0x06003380 RID: 13184
		// RVA: 0x00160EB8 File Offset: 0x0015F0B8
		public List<Class702> Clone()
		{
			List<Class702> list = new List<Class702>();
			foreach (Class702 current in this.list_1)
			{
				if (!current.bool_1)
				{
					list.Add(current.Clone());
				}
			}
			return list;
		}

		// Token: 0x06003376 RID: 13174
		// RVA: 0x00160668 File Offset: 0x0015E868
		public void Dispose()
		{
			foreach (Class541 current in this.list_5)
			{
				current.Dispose();
			}
			this.list_5.Clear();
			if (this.class911_1 != null)
			{
				this.class911_1.Dispose();
			}
			if (this.class911_0 != null)
			{
				this.class911_0.Dispose();
			}
			if (this.class911_2 != null)
			{
				this.class911_2.Dispose();
			}
			if (this.class911_3 != null)
			{
				this.class911_3.Dispose();
			}
			Class872.delegate51_0 = null;
			Class872.delegate55_0 = null;
			Class872.voidDelegate_0 = null;
			Class872.voidDelegate_1 = null;
			Class872.class872_0 = null;
		}

		// Token: 0x0600336A RID: 13162
		// RVA: 0x00025F56 File Offset: 0x00024156
		internal bool method_0()
		{
			return this.class911_2.method_3();
		}

		// Token: 0x0600336B RID: 13163
		// RVA: 0x0015F9D4 File Offset: 0x0015DBD4
		internal void method_1(bool bool_15)
		{
			this.class911_2.method_4(bool_15, new bool?(true));
			this.class911_0.method_4(bool_15, new bool?(true));
			this.class911_2.bool_7 = !bool_15;
			this.class911_0.bool_7 = !bool_15;
		}

		// Token: 0x0600337D RID: 13181
		// RVA: 0x0002600C File Offset: 0x0002420C
		internal void method_10()
		{
			if (Class115.osuModes_1 != OsuModes.Edit)
			{
				this.list_1.Sort();
			}
			List<Class705> arg_36_0 = this.list_0;
			if (Class872.comparison_0 == null)
			{
				Class872.comparison_0 = new Comparison<Class705>(Class872.smethod_15);
			}
			arg_36_0.Sort(Class872.comparison_0);
		}

		// Token: 0x0600337F RID: 13183
		// RVA: 0x00160DAC File Offset: 0x0015EFAC
		internal void method_11(StoryLayer storyLayer_0)
		{
			if (this.bool_9[(int)storyLayer_0])
			{
				List<Class702> arg_31_0 = this.list_3[(int)storyLayer_0];
				if (Class872.predicate_2 == null)
				{
					Class872.predicate_2 = new Predicate<Class702>(Class872.smethod_16);
				}
				using (List<Class702>.Enumerator enumerator = arg_31_0.FindAll(Class872.predicate_2).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class702 current = enumerator.Current;
						current.class531_0.method_8(true);
					}
					goto IL_CD;
				}
			}
			List<Class702> arg_91_0 = this.list_3[(int)storyLayer_0];
			if (Class872.predicate_3 == null)
			{
				Class872.predicate_3 = new Predicate<Class702>(Class872.smethod_17);
			}
			foreach (Class702 current2 in arg_91_0.FindAll(Class872.predicate_3))
			{
				current2.class531_0.method_8(false);
			}
			IL_CD:
			this.bool_9[(int)storyLayer_0] = !this.bool_9[(int)storyLayer_0];
		}

		// Token: 0x06003381 RID: 13185
		// RVA: 0x00160F20 File Offset: 0x0015F120
		internal void method_12(List<Class702> list_6)
		{
			this.Reset();
			foreach (Class702 current in list_6)
			{
				if (!current.bool_1)
				{
					this.Add(current);
					current.method_3();
				}
			}
			List<Class530> arg_6E_0 = this.class911_0.list_2;
			if (Class872.action_0 == null)
			{
				Class872.action_0 = new Action<Class530>(Class872.smethod_18);
			}
			arg_6E_0.ForEach(Class872.action_0);
			List<Class530> arg_9B_0 = this.class911_2.list_2;
			if (Class872.action_1 == null)
			{
				Class872.action_1 = new Action<Class530>(Class872.smethod_19);
			}
			arg_9B_0.ForEach(Class872.action_1);
			this.method_13();
		}

		// Token: 0x06003382 RID: 13186
		// RVA: 0x0002606F File Offset: 0x0002426F
		private void method_13()
		{
			if (this.class702_0 != null && this.class702_0.class531_0 != null)
			{
				this.class702_0.class531_0.method_8(true);
			}
		}

		// Token: 0x06003383 RID: 13187
		// RVA: 0x00026097 File Offset: 0x00024297
		[CompilerGenerated]
		internal bool method_14()
		{
			return this.bool_14;
		}

		// Token: 0x06003384 RID: 13188
		// RVA: 0x0002609F File Offset: 0x0002429F
		[CompilerGenerated]
		private void method_15(bool bool_15)
		{
			this.bool_14 = bool_15;
		}

		// Token: 0x06003385 RID: 13189
		// RVA: 0x00160FE4 File Offset: 0x0015F1E4
		public void method_16(bool bool_15, bool bool_16)
		{
			try
			{
				List<Class705> arg_23_0 = this.list_0;
				if (Class872.predicate_4 == null)
				{
					Class872.predicate_4 = new Predicate<Class705>(Class872.smethod_20);
				}
				Class705 class = arg_23_0.Find(Class872.predicate_4);
				int num = (!bool_16 || class == null) ? 2147483647 : class.int_0;
				if (bool_15)
				{
					this.method_10();
					if (Class872.bool_2 || !bool_16)
					{
						foreach (Class702 current in this.list_1)
						{
							if (current.class531_0 != null)
							{
								if (current.class531_0.class26_0.Count != 0 && current.class531_0.class26_0[0].int_0 > num)
								{
									break;
								}
								if (!current.class531_0.method_7() || !bool_16)
								{
									current.Load();
								}
							}
							this.int_3++;
						}
					}
					this.method_15(true);
					if (bool_16)
					{
						this.int_3 = 0;
					}
					else
					{
						this.int_4 = this.int_3;
					}
				}
				else if (this.int_3 < this.list_1.Count)
				{
					VoidDelegate voidDelegate = null;
					Class872.Class874 class2 = new Class872.Class874();
					class2.class872_0 = this;
					if (!this.method_14())
					{
						return;
					}
					if (this.int_4 < this.int_3)
					{
						return;
					}
					bool flag = Class872.class705_0 != null && Class872.class705_0.int_2 + 1000 < Class331.int_7 && Class331.int_7 < Class872.class705_0.int_0 - 1000;
					bool flag2 = false;
					class2.int_0 = this.int_3;
					class2.int_1 = class2.int_0;
					while (class2.int_1 < this.list_1.Count)
					{
						Class702 class3 = this.list_1[class2.int_1];
						if (!class3.bool_0 && class3.class531_0 != null && class3.class531_0.class26_0.Count != 0)
						{
							flag2 = true;
							if (class3.int_2 >= Class331.int_7 + (flag ? 10000 : 2000))
							{
								if (class3.int_2 > num || class2.int_1 - class2.int_0 >= (flag ? 4 : 1))
								{
									break;
								}
							}
						}
						else if (!flag2)
						{
							class2.int_0++;
						}
						class2.int_1++;
					}
					int num2 = class2.int_1 - class2.int_0;
					if (flag2 && num2 > 0)
					{
						if (voidDelegate == null)
						{
							voidDelegate = new VoidDelegate(class2.method_0);
						}
						Class115.smethod_87(voidDelegate);
					}
					else
					{
						this.int_4 = class2.int_1;
					}
					this.int_3 = class2.int_1;
				}
				this.int_3 = Math.Min(this.int_3, this.list_1.Count);
			}
			catch
			{
				this.int_3++;
			}
		}

		// Token: 0x06003387 RID: 13191
		// RVA: 0x0016133C File Offset: 0x0015F53C
		internal void method_17(Class304 class304_0)
		{
			Delegate55 delegate = Class872.delegate55_0;
			if (delegate != null)
			{
				delegate(class304_0);
			}
		}

		// Token: 0x06003389 RID: 13193
		// RVA: 0x00161390 File Offset: 0x0015F590
		internal void method_18(Struct69 struct69_0)
		{
			Delegate51 delegate = Class872.delegate51_0;
			if (delegate != null)
			{
				delegate(struct69_0);
			}
		}

		// Token: 0x0600338E RID: 13198
		// RVA: 0x000260A8 File Offset: 0x000242A8
		public void method_19()
		{
			new List<Class705>(this.list_0).ForEach(new Action<Class705>(this.Remove));
		}

		// Token: 0x0600336E RID: 13166
		// RVA: 0x0015FEF0 File Offset: 0x0015E0F0
		public List<Class702> method_2()
		{
			List<Class702> list = new List<Class702>();
			for (int i = 0; i < this.bool_9.Length; i++)
			{
				if (this.bool_9[i])
				{
					List<Class702> arg_3F_0 = list;
					List<Class702> arg_3A_0 = this.list_3[i];
					if (Class872.predicate_1 == null)
					{
						Class872.predicate_1 = new Predicate<Class702>(Class872.smethod_14);
					}
					arg_3F_0.AddRange(arg_3A_0.FindAll(Class872.predicate_1));
				}
			}
			return list;
		}

		// Token: 0x0600338F RID: 13199
		// RVA: 0x00161450 File Offset: 0x0015F650
		internal void method_20()
		{
			if (this.bool_0 && Class872.bool_2)
			{
				Class115.class83_0.method_6(true);
				this.bool_8 = true;
				return;
			}
			Class872.Class875 class = new Class872.Class875();
			class.class872_0 = this;
			class.class427_0 = Class427.class427_0;
			class.class531_0 = ((this.class702_0 == null || this.class702_0.class531_0 == null) ? null : this.class702_0.class531_0);
			bool flag = this.bool_11 && Class872.bool_2;
			class.bool_0 = (class.class531_0 != null && class.class531_0.vector2_1 != Vector2.get_Zero());
			class.bool_1 = (class.class427_0 != null && !this.bool_11);
			Enum50 enum = flag ? (this.method_0() ? Enum50.flag_3 : Enum50.flag_1) : Enum50.flag_0;
			if (class.bool_0 && (enum & Enum50.flag_1) == (Enum50)0)
			{
				enum = Enum50.flag_3;
			}
			this.bool_8 = false;
			Class115.class83_0.method_7(enum, new Class83.Delegate35(class.method_0));
		}

		// Token: 0x06003390 RID: 13200
		// RVA: 0x00161554 File Offset: 0x0015F754
		internal void method_21()
		{
			this.method_13();
			using (List<Class530>.Enumerator enumerator = this.class911_1.list_2.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Class531 class = (Class531)enumerator.Current;
					if (class.vmethod_6() != Class115.class731_0)
					{
						class.method_46(!this.bool_11 || this.method_0() || Class466.Current.bool_24, false);
					}
				}
			}
		}

		// Token: 0x0600336F RID: 13167
		// RVA: 0x00025F63 File Offset: 0x00024163
		internal void method_3(Color color_1)
		{
			Class872.color_0 = color_1;
		}

		// Token: 0x06003374 RID: 13172
		// RVA: 0x00025F6B File Offset: 0x0002416B
		internal void method_4()
		{
			this.class911_1.Draw();
			this.class911_0.Draw();
		}

		// Token: 0x06003375 RID: 13173
		// RVA: 0x00025F85 File Offset: 0x00024185
		internal void method_5()
		{
			this.class911_2.Draw();
			if (this.bool_11 && Class872.bool_2)
			{
				this.class911_3.Draw();
			}
		}

		// Token: 0x06003377 RID: 13175
		// RVA: 0x00160730 File Offset: 0x0015E930
		internal void method_6()
		{
			float num = (float)((!this.bool_8 || !Class872.bool_2) ? 0 : 1);
			float num2 = this.method_0() ? 0f : num;
			if (this.class911_2.float_0 != num)
			{
				this.class911_0.float_0 = (this.class911_2.float_0 = MathHelper.Clamp(this.class911_2.float_0 + ((num < this.class911_2.float_0) ? -0.07f : 0.07f) * (float)Class115.double_0, 0f, 1f));
			}
			if (this.class911_3.float_0 != num2)
			{
				this.class911_3.float_0 = MathHelper.Clamp(this.class911_3.float_0 + ((num2 < this.class911_3.float_0) ? -0.07f : 0.07f) * (float)Class115.double_0, 0f, 1f);
			}
			bool flag = false;
			if (this.class297_0.int_14 > 0)
			{
				if (this.bool_6 && Class331.int_7 > this.class297_0.vmethod_3().vmethod_16() - this.class297_0.PreEmpt)
				{
					this.bool_6 = false;
				}
				else if (!this.bool_7 && Class331.int_7 > this.class297_0.vmethod_4().vmethod_15() + this.class297_0.HitWindow50)
				{
					this.bool_7 = true;
				}
			}
			else
			{
				this.bool_6 = true;
				this.bool_7 = false;
			}
			if (Class115.osuModes_1 == OsuModes.Play && (this.bool_6 || this.bool_7))
			{
				flag = true;
			}
			for (int i = 0; i < this.list_0.Count; i++)
			{
				Class705 class = this.list_0[i];
				if (Class331.int_7 >= class.int_2 && Class331.int_7 <= class.int_0)
				{
					flag = true;
					Class872.class705_0 = class;
					IL_1CB:
					if (Class115.osuModes_1 == OsuModes.Play && Class62.bool_10 != this.bool_5)
					{
						this.bool_5 = Class62.bool_10;
						if (this.bool_5)
						{
							Class872.smethod_10();
						}
						else
						{
							Class872.smethod_12();
						}
						for (int j = 0; j < this.list_3[1].Count; j++)
						{
							Class702 class2 = this.list_3[1][j];
							class2.class531_0.method_8(this.bool_5);
						}
						for (int k = 0; k < this.list_4[1].Count; k++)
						{
							Class702 class3 = this.list_4[1][k];
							if (this.bool_5)
							{
								Class331.list_1.Remove(((Class704)class3).class338_0);
							}
							else
							{
								Class331.list_1.Add(((Class704)class3).class338_0);
							}
						}
						if (!this.bool_4)
						{
							for (int l = 0; l < this.list_3[2].Count; l++)
							{
								Class702 class4 = this.list_3[2][l];
								class4.class531_0.method_8(!this.bool_5);
							}
							for (int m = 0; m < this.list_4[2].Count; m++)
							{
								Class702 class5 = this.list_4[2][m];
								if (this.bool_5)
								{
									Class331.list_1.Add(((Class704)class5).class338_0);
								}
								else
								{
									Class331.list_1.Remove(((Class704)class5).class338_0);
								}
							}
						}
						this.bool_4 = false;
					}
					if (Class115.osuModes_1 == OsuModes.Play && flag != Class872.bool_1 && !flag)
					{
						Class723.smethod_3();
					}
					Class872.bool_1 = flag;
					if (!flag)
					{
						Class872.class705_0 = null;
					}
					this.method_7();
					this.method_9();
					if (Class115.bool_13 && Class872.bool_2)
					{
						this.method_16(false, true);
					}
					return;
				}
			}
			goto IL_1CB;
		}

		// Token: 0x06003378 RID: 13176
		// RVA: 0x00160AE8 File Offset: 0x0015ECE8
		private void method_7()
		{
			this.bool_10 = false;
			if (Class872.bool_3)
			{
				using (List<Class541>.Enumerator enumerator = this.list_5.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class541 current = enumerator.Current;
						this.float_2 = 1f - current.float_3;
						current.method_51();
						if (current.class915_0 != null)
						{
							double num = Math.Abs(current.class915_0.method_3() - (double)(Class331.int_8 - current.method_49()));
							if (num > (double)((float)(250 * Class331.smethod_67()) / 100f))
							{
								current.method_52(Class872.bool_13);
								Class872.bool_13 = false;
							}
						}
					}
					return;
				}
			}
			this.float_2 = 1f;
		}

		// Token: 0x06003379 RID: 13177
		// RVA: 0x00025FAE File Offset: 0x000241AE
		internal void method_8(float float_4)
		{
			if (Class872.smethod_5() == 100)
			{
				return;
			}
			Class872.float_3 -= (float)Math.Ceiling((double)((Class872.float_3 - (float)Class872.smethod_4()) * Math.Min(1f, float_4)));
		}

		// Token: 0x0600337C RID: 13180
		// RVA: 0x00160BB8 File Offset: 0x0015EDB8
		private void method_9()
		{
			if (!Class115.bool_13)
			{
				return;
			}
			if (Class872.float_3 > (float)Class872.smethod_5() + 1.401298E-45f)
			{
				Class872.float_3 -= (Class872.float_3 - (float)Class872.smethod_5()) / 15f;
			}
			else if (!Class872.bool_1 && Class872.float_3 < (float)Class872.smethod_5())
			{
				Class872.float_3 += ((float)Class872.smethod_5() - Class872.float_3) / 15f;
				if (Class115.osuModes_1 == OsuModes.Play && this.class531_1.int_0 == 1 && Class466.Current.bool_11)
				{
					this.class531_1.method_16(200, Enum70.const_0);
					this.class531_0.method_16(200, Enum70.const_0);
				}
				this.class531_1.int_0 = 0;
			}
			else if (Class872.bool_1 && (Class872.float_3 != (float)Class872.smethod_4() || this.class531_1.int_0 == 0))
			{
				if (Class872.float_3 > (float)Class872.smethod_4())
				{
					Class872.float_3 -= (Class872.float_3 - (float)Class872.smethod_4()) / 15f;
				}
				else
				{
					Class872.float_3 += ((float)Class872.smethod_4() - Class872.float_3) / 15f;
				}
				if (Class115.osuModes_1 == OsuModes.Play && this.class531_1.int_0 == 0 && !this.bool_7 && !this.bool_6 && Class466.Current.bool_11)
				{
					this.class531_1.method_14(200, Enum70.const_0);
					this.class531_0.method_14(200, Enum70.const_0);
				}
				this.class531_1.int_0 = 1;
			}
			float num = Class872.float_3 / 100f;
			this.class911_1.float_1 = num;
			this.class911_0.float_1 = num;
			this.class911_2.float_1 = num;
			this.class911_3.float_1 = num;
			Class115.class83_0.float_0 = (1f - num) * this.float_2;
		}

		// Token: 0x06003373 RID: 13171
		// RVA: 0x00160570 File Offset: 0x0015E770
		internal void Remove(Class702 class702_1)
		{
			if (!this.list_1.Contains(class702_1))
			{
				return;
			}
			this.list_1.Remove(class702_1);
			switch (class702_1.eventTypes_0)
			{
			case EventTypes.Background:
			case EventTypes.Sprite:
			case EventTypes.Animation:
				if (class702_1.storyLayer_0 == StoryLayer.Background)
				{
					this.class911_0.Remove(class702_1.class531_0);
					this.class911_1.Remove(class702_1.class531_0);
				}
				else
				{
					this.class911_2.Remove(class702_1.class531_0);
				}
				this.list_3[(int)class702_1.storyLayer_0].Remove(class702_1);
				return;
			case EventTypes.Video:
				this.list_5.Remove((Class541)class702_1.class531_0);
				return;
			case EventTypes.Break:
				this.list_0.Remove((Class705)class702_1);
				return;
			case EventTypes.Colour:
				break;
			case EventTypes.Sample:
			{
				Class704 class = (Class704)class702_1;
				Class331.list_1.Remove(class.class338_0);
				this.list_2.Remove(class);
				break;
			}
			default:
				return;
			}
		}

		// Token: 0x0600336D RID: 13165
		// RVA: 0x0015FC4C File Offset: 0x0015DE4C
		private void Reset()
		{
			Class872.float_0 = 0f;
			this.float_1 = 0.4f;
			this.int_3 = 0;
			float num = (this.class911_0 != null) ? this.class911_0.float_1 : 0f;
			this.class911_1 = new Class911(true);
			this.class911_0 = new Class911
			{
				bool_7 = true,
				float_0 = 0f
			};
			this.class911_2 = new Class911
			{
				bool_7 = true,
				float_0 = 0f
			};
			this.class911_3.float_0 = 0f;
			this.class911_0.float_1 = num;
			this.class911_1.float_1 = num;
			this.class911_2.float_1 = num;
			Class872.float_3 = (float)((int)(num * 100f));
			if (Class115.osuModes_1 == OsuModes.Play)
			{
				this.class911_0.bool_4 = true;
				this.class911_1.bool_4 = true;
				this.class911_2.bool_4 = true;
			}
			int length = Enum.GetValues(typeof(StoryLayer)).Length;
			this.list_3 = new List<Class702>[length];
			this.list_4 = new List<Class702>[length];
			this.bool_9 = new bool[length];
			for (int i = 0; i < this.list_3.Length; i++)
			{
				this.list_3[i] = new List<Class702>();
				this.list_4[i] = new List<Class702>();
				this.bool_9[i] = true;
			}
			this.list_5.Clear();
			this.list_2 = new List<Class704>();
			this.list_0 = new List<Class705>();
			if (this.list_1 != null)
			{
				List<Class702> arg_1B6_0 = this.list_1;
				if (Class872.predicate_0 == null)
				{
					Class872.predicate_0 = new Predicate<Class702>(Class872.smethod_13);
				}
				this.list_1 = arg_1B6_0.FindAll(Class872.predicate_0);
				using (List<Class702>.Enumerator enumerator = this.list_1.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class702 current = enumerator.Current;
						if (current.class531_0 != null)
						{
							this.class911_1.Add(current.class531_0);
							Class707 class = current as Class707;
							if (class != null && class.class541_0 != null)
							{
								this.list_5.Add(class.class541_0);
							}
						}
					}
					goto IL_23C;
				}
			}
			this.list_1 = new List<Class702>();
			IL_23C:
			this.class911_1.Add(this.class531_1);
			this.class911_1.Add(this.class531_0);
			this.method_1(Class466.Current.bool_12);
			Class872.delegate51_0 = null;
			Class872.delegate55_0 = null;
			Class872.voidDelegate_0 = null;
			Class872.voidDelegate_1 = null;
		}

		// Token: 0x06003366 RID: 13158
		// RVA: 0x00025F26 File Offset: 0x00024126
		internal static bool smethod_0()
		{
			return Class872.bool_2;
		}

		// Token: 0x06003367 RID: 13159
		// RVA: 0x00025F2D File Offset: 0x0002412D
		internal static void smethod_1(bool bool_15)
		{
			if (bool_15 == Class872.bool_2)
			{
				return;
			}
			Class872.bool_2 = bool_15;
			if (Class872.class872_0 != null)
			{
				Class872.class872_0.method_20();
			}
		}

		// Token: 0x0600338B RID: 13195
		// RVA: 0x001613E4 File Offset: 0x0015F5E4
		private static void smethod_10()
		{
			VoidDelegate voidDelegate = Class872.voidDelegate_0;
			if (voidDelegate != null)
			{
				voidDelegate();
			}
		}

		// Token: 0x0600338C RID: 13196
		// RVA: 0x00161400 File Offset: 0x0015F600
		internal static void smethod_11(VoidDelegate voidDelegate_2)
		{
			VoidDelegate voidDelegate = Class872.voidDelegate_1;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Combine(voidDelegate2, voidDelegate_2);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref Class872.voidDelegate_1, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}

		// Token: 0x0600338D RID: 13197
		// RVA: 0x00161434 File Offset: 0x0015F634
		private static void smethod_12()
		{
			VoidDelegate voidDelegate = Class872.voidDelegate_1;
			if (voidDelegate != null)
			{
				voidDelegate();
			}
		}

		// Token: 0x06003391 RID: 13201
		// RVA: 0x000260C6 File Offset: 0x000242C6
		[CompilerGenerated]
		private static bool smethod_13(Class702 class702_1)
		{
			return class702_1.bool_1;
		}

		// Token: 0x06003392 RID: 13202
		// RVA: 0x000260CE File Offset: 0x000242CE
		[CompilerGenerated]
		private static bool smethod_14(Class702 class702_1)
		{
			return class702_1.class531_0 != null;
		}

		// Token: 0x06003393 RID: 13203
		// RVA: 0x0002106D File Offset: 0x0001F26D
		[CompilerGenerated]
		private static int smethod_15(Class705 class705_1, Class705 class705_2)
		{
			return class705_1.int_2.CompareTo(class705_2.int_2);
		}

		// Token: 0x06003394 RID: 13204
		// RVA: 0x000260CE File Offset: 0x000242CE
		[CompilerGenerated]
		private static bool smethod_16(Class702 class702_1)
		{
			return class702_1.class531_0 != null;
		}

		// Token: 0x06003395 RID: 13205
		// RVA: 0x000260CE File Offset: 0x000242CE
		[CompilerGenerated]
		private static bool smethod_17(Class702 class702_1)
		{
			return class702_1.class531_0 != null;
		}

		// Token: 0x06003396 RID: 13206
		// RVA: 0x0001B162 File Offset: 0x00019362
		[CompilerGenerated]
		private static void smethod_18(Class530 class530_0)
		{
			class530_0.method_10();
		}

		// Token: 0x06003397 RID: 13207
		// RVA: 0x0001B162 File Offset: 0x00019362
		[CompilerGenerated]
		private static void smethod_19(Class530 class530_0)
		{
			class530_0.method_10();
		}

		// Token: 0x06003368 RID: 13160
		// RVA: 0x00025F4F File Offset: 0x0002414F
		internal static bool smethod_2()
		{
			return Class872.bool_3;
		}

		// Token: 0x06003398 RID: 13208
		// RVA: 0x000260DC File Offset: 0x000242DC
		[CompilerGenerated]
		private static bool smethod_20(Class705 class705_1)
		{
			return class705_1.int_2 > Class331.int_7;
		}

		// Token: 0x06003369 RID: 13161
		// RVA: 0x0015F95C File Offset: 0x0015DB5C
		internal static void smethod_3(bool bool_15)
		{
			if (bool_15 == Class872.bool_3)
			{
				return;
			}
			Class872.bool_3 = bool_15;
			if (Class872.class872_0 != null)
			{
				foreach (Class531 current in Class872.class872_0.list_5)
				{
					current.method_8(!Class872.bool_3);
				}
			}
		}

		// Token: 0x0600337A RID: 13178
		// RVA: 0x00025FE4 File Offset: 0x000241E4
		private static int smethod_4()
		{
			return Math.Max(0, Class872.int_2 - 30);
		}

		// Token: 0x0600337B RID: 13179
		// RVA: 0x00025FF4 File Offset: 0x000241F4
		private static int smethod_5()
		{
			return Math.Max(Class872.smethod_4(), Math.Min(100, Class872.int_2));
		}

		// Token: 0x0600337E RID: 13182
		// RVA: 0x00026049 File Offset: 0x00024249
		internal static float smethod_6(StoryLayer storyLayer_0)
		{
			Class872.float_0 += 0.0001f;
			return 0.5f + (float)storyLayer_0 * 0.1f + Class872.float_0;
		}

		// Token: 0x06003386 RID: 13190
		// RVA: 0x00161308 File Offset: 0x0015F508
		internal static void smethod_7(Delegate55 delegate55_1)
		{
			Delegate55 delegate = Class872.delegate55_0;
			Delegate55 delegate2;
			do
			{
				delegate2 = delegate;
				Delegate55 value = (Delegate55)Delegate.Combine(delegate2, delegate55_1);
				delegate = Interlocked.CompareExchange<Delegate55>(ref Class872.delegate55_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06003388 RID: 13192
		// RVA: 0x0016135C File Offset: 0x0015F55C
		internal static void smethod_8(Delegate51 delegate51_1)
		{
			Delegate51 delegate = Class872.delegate51_0;
			Delegate51 delegate2;
			do
			{
				delegate2 = delegate;
				Delegate51 value = (Delegate51)Delegate.Combine(delegate2, delegate51_1);
				delegate = Interlocked.CompareExchange<Delegate51>(ref Class872.delegate51_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x0600338A RID: 13194
		// RVA: 0x001613B0 File Offset: 0x0015F5B0
		internal static void smethod_9(VoidDelegate voidDelegate_2)
		{
			VoidDelegate voidDelegate = Class872.voidDelegate_0;
			VoidDelegate voidDelegate2;
			do
			{
				voidDelegate2 = voidDelegate;
				VoidDelegate value = (VoidDelegate)Delegate.Combine(voidDelegate2, voidDelegate_2);
				voidDelegate = Interlocked.CompareExchange<VoidDelegate>(ref Class872.voidDelegate_0, value, voidDelegate2);
			}
			while (voidDelegate != voidDelegate2);
		}
	}
}
