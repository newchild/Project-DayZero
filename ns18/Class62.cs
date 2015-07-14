using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns14;
using ns17;
using ns22;
using ns23;
using ns24;
using ns25;
using ns26;
using ns27;
using ns29;
using ns3;
using ns40;
using ns5;
using ns59;
using ns6;
using ns60;
using ns64;
using ns69;
using ns70;
using ns71;
using ns72;
using ns73;
using ns76;
using ns77;
using ns78;
using ns79;
using ns8;
using ns80;
using ns81;
using ns82;
using ns84;
using ns89;
using ns9;
using ns90;
using osu;
using osu.GameModes.Play.Components;
using osu.GameModes.Select;
using osu.GameplayElements.HitObjects;
using osu.Graphics.Sprites;
using osu.Input;
using osu.Input.Drawable;
using osu_common;
using osu_common.Bancho.Objects;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Threading;
using Un4seen.Bass;

namespace ns18
{
	// Token: 0x020003C4 RID: 964
	internal class Class62 : Class61
	{
		// Token: 0x020003C5 RID: 965
		[CompilerGenerated]
		private sealed class Class417
		{
			// Token: 0x04001871 RID: 6257
			public Class531 class531_0;

			// Token: 0x06001EB6 RID: 7862
			// RVA: 0x000192F7 File Offset: 0x000174F7
			public void method_0()
			{
				this.class531_0.bool_1 = true;
				this.class531_0.method_39(Color.get_White(), 100, false, Enum70.const_0);
			}
		}

		// Token: 0x020003C6 RID: 966
		[CompilerGenerated]
		private sealed class Class418
		{
			// Token: 0x04001872 RID: 6258
			public Class746 class746_0;

			// Token: 0x04001873 RID: 6259
			public Class746 class746_1;

			// Token: 0x06001EB8 RID: 7864
			// RVA: 0x0001931A File Offset: 0x0001751A
			public void method_0(Class531 class531_0)
			{
				class531_0.class26_0.Add(this.class746_0);
				class531_0.class26_0.Add(this.class746_1);
			}
		}

		// Token: 0x020003C7 RID: 967
		[CompilerGenerated]
		private sealed class Class419
		{
			// Token: 0x04001874 RID: 6260
			public Class746 class746_0;

			// Token: 0x04001875 RID: 6261
			public Class746 class746_1;

			// Token: 0x06001EBA RID: 7866
			// RVA: 0x0001933E File Offset: 0x0001753E
			public void method_0(Class531 class531_0)
			{
				class531_0.class26_0.Add(this.class746_0);
				class531_0.class26_0.Add(this.class746_1);
			}
		}

		// Token: 0x04001864 RID: 6244
		[CompilerGenerated]
		private static Action<Class296> action_0;

		// Token: 0x04001867 RID: 6247
		[CompilerGenerated]
		private static Action<Class531> action_1;

		// Token: 0x04001868 RID: 6248
		[CompilerGenerated]
		private static Action<Class530> action_2;

		// Token: 0x040017EB RID: 6123
		internal static bool bool_10 = true;

		// Token: 0x040017EC RID: 6124
		internal static bool bool_11;

		// Token: 0x040017ED RID: 6125
		internal static bool bool_12;

		// Token: 0x040017EF RID: 6127
		internal static bool bool_13;

		// Token: 0x040017F0 RID: 6128
		private bool bool_14;

		// Token: 0x040017F4 RID: 6132
		public static bool bool_15;

		// Token: 0x040017F5 RID: 6133
		public static bool bool_16;

		// Token: 0x040017FF RID: 6143
		internal bool bool_17;

		// Token: 0x04001801 RID: 6145
		internal static bool bool_18 = true;

		// Token: 0x04001805 RID: 6149
		private bool bool_19;

		// Token: 0x040017DC RID: 6108
		private bool bool_2;

		// Token: 0x04001807 RID: 6151
		protected bool bool_20;

		// Token: 0x0400180A RID: 6154
		internal bool bool_21;

		// Token: 0x0400180B RID: 6155
		private bool bool_22;

		// Token: 0x0400180E RID: 6158
		private static bool bool_23;

		// Token: 0x04001812 RID: 6162
		internal static bool bool_24;

		// Token: 0x04001813 RID: 6163
		internal bool bool_25;

		// Token: 0x0400181A RID: 6170
		private bool bool_26;

		// Token: 0x0400181C RID: 6172
		internal static bool bool_27;

		// Token: 0x04001836 RID: 6198
		private bool bool_28;

		// Token: 0x04001837 RID: 6199
		internal static bool bool_29;

		// Token: 0x040017DE RID: 6110
		private bool bool_3 = true;

		// Token: 0x0400183C RID: 6204
		internal bool bool_30;

		// Token: 0x0400183D RID: 6205
		private bool bool_31;

		// Token: 0x0400183E RID: 6206
		private bool bool_32;

		// Token: 0x04001840 RID: 6208
		private bool bool_33;

		// Token: 0x04001842 RID: 6210
		private static bool bool_34;

		// Token: 0x04001843 RID: 6211
		private static bool bool_35;

		// Token: 0x04001844 RID: 6212
		private bool bool_36;

		// Token: 0x04001848 RID: 6216
		internal bool bool_37;

		// Token: 0x04001849 RID: 6217
		internal static bool bool_38;

		// Token: 0x0400184A RID: 6218
		private bool bool_39;

		// Token: 0x040017E0 RID: 6112
		private bool bool_4;

		// Token: 0x0400184C RID: 6220
		internal static bool bool_40;

		// Token: 0x0400184F RID: 6223
		private static bool bool_41 = true;

		// Token: 0x04001852 RID: 6226
		internal static bool bool_42;

		// Token: 0x04001856 RID: 6230
		private bool bool_43;

		// Token: 0x04001857 RID: 6231
		private bool bool_44;

		// Token: 0x04001859 RID: 6233
		internal bool bool_45;

		// Token: 0x0400185A RID: 6234
		private bool bool_46;

		// Token: 0x0400185C RID: 6236
		public static bool bool_47;

		// Token: 0x040017E2 RID: 6114
		internal static bool bool_5 = false;

		// Token: 0x040017E4 RID: 6116
		internal static bool bool_6;

		// Token: 0x040017E6 RID: 6118
		internal static bool bool_7;

		// Token: 0x040017E8 RID: 6120
		internal static bool bool_8;

		// Token: 0x040017E9 RID: 6121
		internal static bool bool_9;

		// Token: 0x04001803 RID: 6147
		private Class107 class107_0;

		// Token: 0x04001802 RID: 6146
		private Class108 class108_0;

		// Token: 0x0400180C RID: 6156
		internal Class297 class297_0;

		// Token: 0x040017FA RID: 6138
		internal Class304 class304_0;

		// Token: 0x04001851 RID: 6225
		internal Class304 class304_1;

		// Token: 0x04001846 RID: 6214
		private Class335 class335_0;

		// Token: 0x0400181D RID: 6173
		internal Class427 class427_0;

		// Token: 0x0400183B RID: 6203
		internal static Class512 class512_0;

		// Token: 0x04001841 RID: 6209
		protected Class523 class523_0;

		// Token: 0x04001814 RID: 6164
		internal Class531 class531_0;

		// Token: 0x04001815 RID: 6165
		private Class531 class531_1;

		// Token: 0x0400181E RID: 6174
		private Class531 class531_2;

		// Token: 0x0400181F RID: 6175
		private Class531 class531_3;

		// Token: 0x0400185E RID: 6238
		private Class531 class531_4;

		// Token: 0x040017F6 RID: 6134
		public static Class533 class533_0;

		// Token: 0x04001828 RID: 6184
		protected Class533 class533_1;

		// Token: 0x04001825 RID: 6181
		private Class538 class538_0;

		// Token: 0x040017E7 RID: 6119
		internal static Class62 class62_0;

		// Token: 0x04001818 RID: 6168
		private Class658 class658_0;

		// Token: 0x04001823 RID: 6179
		protected internal Class660 class660_0;

		// Token: 0x040017F7 RID: 6135
		internal static Class664 class664_0;

		// Token: 0x04001835 RID: 6197
		internal Class731 class731_0;

		// Token: 0x04001808 RID: 6152
		private Class734 class734_0;

		// Token: 0x04001806 RID: 6150
		internal Class872 class872_0;

		// Token: 0x0400182A RID: 6186
		public static Class911 class911_1;

		// Token: 0x04001833 RID: 6195
		internal Class911 class911_10;

		// Token: 0x0400182B RID: 6187
		internal Class911 class911_2;

		// Token: 0x0400182C RID: 6188
		internal Class911 class911_3;

		// Token: 0x0400182D RID: 6189
		internal Class911 class911_4;

		// Token: 0x0400182E RID: 6190
		internal Class911 class911_5;

		// Token: 0x0400182F RID: 6191
		internal Class911 class911_6;

		// Token: 0x04001830 RID: 6192
		internal Class911 class911_7;

		// Token: 0x04001831 RID: 6193
		internal Class911 class911_8;

		// Token: 0x04001832 RID: 6194
		internal Class911 class911_9;

		// Token: 0x04001853 RID: 6227
		private Color color_0;

		// Token: 0x0400184E RID: 6222
		private Delegate55 delegate55_0;

		// Token: 0x04001834 RID: 6196
		internal Enum110 enum110_0;

		// Token: 0x040017D8 RID: 6104
		internal static Enum43 enum43_0;

		// Token: 0x040017E3 RID: 6115
		internal static float float_0 = 0f;

		// Token: 0x040017FE RID: 6142
		internal float float_1;

		// Token: 0x04001847 RID: 6215
		private float float_2;

		// Token: 0x0400183A RID: 6202
		protected InputOverlay inputOverlay_0;

		// Token: 0x040017F1 RID: 6129
		internal static int int_10;

		// Token: 0x040017F2 RID: 6130
		internal static int int_11;

		// Token: 0x040017F3 RID: 6131
		internal static int int_12 = 0;

		// Token: 0x040017F8 RID: 6136
		internal static int int_13;

		// Token: 0x040017FC RID: 6140
		private int int_14;

		// Token: 0x040017FD RID: 6141
		private int int_15;

		// Token: 0x04001800 RID: 6144
		private int int_16;

		// Token: 0x04001804 RID: 6148
		private int int_17;

		// Token: 0x04001809 RID: 6153
		private int int_18;

		// Token: 0x0400180D RID: 6157
		private int int_19;

		// Token: 0x040017D9 RID: 6105
		private int int_2;

		// Token: 0x0400180F RID: 6159
		protected int int_20;

		// Token: 0x04001819 RID: 6169
		private int int_21 = -1;

		// Token: 0x0400181B RID: 6171
		private int int_22 = -1;

		// Token: 0x04001824 RID: 6180
		protected int int_23;

		// Token: 0x04001826 RID: 6182
		internal int int_24;

		// Token: 0x04001827 RID: 6183
		internal int int_25;

		// Token: 0x04001829 RID: 6185
		private int int_26;

		// Token: 0x04001838 RID: 6200
		private int int_27 = -2147483648;

		// Token: 0x04001839 RID: 6201
		private int int_28 = 2147483647;

		// Token: 0x0400184B RID: 6219
		private int int_29;

		// Token: 0x040017DA RID: 6106
		private int int_3 = -1;

		// Token: 0x0400184D RID: 6221
		private int int_30;

		// Token: 0x04001850 RID: 6224
		private int int_31;

		// Token: 0x04001854 RID: 6228
		private int int_32;

		// Token: 0x04001858 RID: 6232
		private int int_33;

		// Token: 0x0400185D RID: 6237
		internal int int_34;

		// Token: 0x040017DB RID: 6107
		private int int_4;

		// Token: 0x040017DD RID: 6109
		private int int_5 = Class562.smethod_1(10, 50);

		// Token: 0x040017DF RID: 6111
		private int int_6;

		// Token: 0x040017E1 RID: 6113
		private int int_7 = Class115.int_1;

		// Token: 0x040017E5 RID: 6117
		internal static int int_8;

		// Token: 0x040017EE RID: 6126
		protected static int int_9 = 0;

		// Token: 0x040017F9 RID: 6137
		internal readonly List<Class531> list_0 = new List<Class531>();

		// Token: 0x04001817 RID: 6167
		private List<Class531> list_1;

		// Token: 0x04001845 RID: 6213
		private List<Class531> list_2 = new List<Class531>();

		// Token: 0x04001855 RID: 6229
		private List<Class531> list_3 = new List<Class531>();

		// Token: 0x040017FB RID: 6139
		private long long_0 = -1L;

		// Token: 0x04001822 RID: 6178
		private long long_1;

		// Token: 0x040017EA RID: 6122
		private static PlayModes playModes_0;

		// Token: 0x0400183F RID: 6207
		private PlayModes playModes_1;

		// Token: 0x04001865 RID: 6245
		[CompilerGenerated]
		private static Predicate<Class531> predicate_0;

		// Token: 0x04001866 RID: 6246
		[CompilerGenerated]
		private static Predicate<Class746> predicate_1;

		// Token: 0x04001869 RID: 6249
		[CompilerGenerated]
		private static Predicate<Class530> predicate_2;

		// Token: 0x0400186A RID: 6250
		[CompilerGenerated]
		private static Predicate<Struct13> predicate_3;

		// Token: 0x0400186B RID: 6251
		[CompilerGenerated]
		private static Predicate<Class304> predicate_4;

		// Token: 0x0400186C RID: 6252
		[CompilerGenerated]
		private static Predicate<Class746> predicate_5;

		// Token: 0x0400186D RID: 6253
		[CompilerGenerated]
		private static Predicate<Class304> predicate_6;

		// Token: 0x0400186E RID: 6254
		[CompilerGenerated]
		private static Predicate<bool> predicate_7;

		// Token: 0x0400186F RID: 6255
		[CompilerGenerated]
		private static Predicate<bool> predicate_8;

		// Token: 0x04001870 RID: 6256
		[CompilerGenerated]
		private static Predicate<Class304> predicate_9;

		// Token: 0x04001820 RID: 6176
		private Queue<int> queue_0;

		// Token: 0x0400185B RID: 6235
		private RankingType rankingType_0;

		// Token: 0x04001821 RID: 6177
		private string string_0;

		// Token: 0x04001810 RID: 6160
		private Vector2 vector2_0;

		// Token: 0x04001811 RID: 6161
		private Vector2 vector2_1;

		// Token: 0x04001816 RID: 6166
		private Vector2 vector2_2;

		// Token: 0x0400185F RID: 6239
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_0;

		// Token: 0x04001860 RID: 6240
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_1;

		// Token: 0x04001861 RID: 6241
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_2;

		// Token: 0x04001862 RID: 6242
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_3;

		// Token: 0x04001863 RID: 6243
		[CompilerGenerated]
		private static VoidDelegate voidDelegate_4;

		// Token: 0x17000367 RID: 871
		internal static PlayModes Mode
		{
			// Token: 0x06001E36 RID: 7734
			// RVA: 0x00018CB4 File Offset: 0x00016EB4
			get
			{
				return Class62.playModes_0;
			}
			// Token: 0x06001E37 RID: 7735
			// RVA: 0x00018CBB File Offset: 0x00016EBB
			set
			{
				if (value != Class62.playModes_0)
				{
					Class62.playModes_0 = value;
					if (Class466.list_3 != null)
					{
						List<Class296> arg_37_0 = Class466.list_3;
						if (Class62.action_0 == null)
						{
							Class62.action_0 = new Action<Class296>(Class62.smethod_15);
						}
						arg_37_0.ForEach(Class62.action_0);
					}
				}
			}
		}

		// Token: 0x06001E35 RID: 7733
		// RVA: 0x000A4C38 File Offset: 0x000A2E38
		internal Class62() : base(Class115.class114_0)
		{
			Class62.class62_0 = this;
		}

		// Token: 0x06001E66 RID: 7782
		// RVA: 0x000A9504 File Offset: 0x000A7704
		protected override void Dispose(bool bool_48)
		{
			if (Class876.smethod_5(Mods.Cinema))
			{
				Class876.class623_0 &= ~(Mods.Autoplay | Mods.Cinema);
			}
			if (this.class335_0 != null && this.class335_0 != Class331.class335_0 && this.class335_0.vmethod_2())
			{
				this.class335_0.Dispose();
			}
			if (this.class523_0 != null)
			{
				this.class523_0.Dispose();
			}
			if (Class341.class606_13)
			{
				this.class734_0.Dispose();
				this.class734_0 = null;
			}
			Class62.smethod_6(false);
			Class115.class115_0.method_6(new EventHandler(this.method_14));
			Class115.class115_0.method_8(new EventHandler(this.method_14));
			this.enum110_0 = Enum110.const_6;
			Class62.bool_15 = false;
			Class62.bool_16 = false;
			Class62.bool_11 = false;
			Class62.class512_0 = this.vmethod_19();
			Class62.class62_0 = null;
			Class62.class533_0 = null;
			this.method_44();
			Class331.smethod_83();
			Class331.smethod_101();
			this.method_23();
			if (!Class331.bool_5)
			{
				Class331.smethod_68(100);
				Bass.BASS_ChannelSetAttribute(Class331.class335_0.method_0(), 1, Class331.float_1);
			}
			if (this.class297_0 != null)
			{
				this.class297_0.Dispose();
			}
			if (this.class911_2 != null)
			{
				this.class911_2.Dispose();
			}
			if (this.class911_4 != null)
			{
				this.class911_4.Dispose();
			}
			if (this.class911_3 != null)
			{
				this.class911_3.Dispose();
			}
			if (this.class911_7 != null)
			{
				this.class911_7.Dispose();
			}
			if (this.class911_8 != null)
			{
				this.class911_8.Dispose();
			}
			if (this.class911_5 != null)
			{
				this.class911_5.Dispose();
			}
			if (this.class911_6 != null)
			{
				this.class911_6.Dispose();
			}
			if (this.class911_9 != null)
			{
				this.class911_9.Dispose();
			}
			if (this.class911_10 != null)
			{
				this.class911_10.Dispose();
			}
			if (Class62.class911_1 != null)
			{
				List<Class530> arg_20C_0 = Class62.class911_1.list_2;
				if (Class62.action_2 == null)
				{
					Class62.action_2 = new Action<Class530>(Class62.smethod_19);
				}
				arg_20C_0.ForEach(Class62.action_2);
				Class62.class911_1.Dispose();
				Class62.class911_1 = null;
			}
			if (this.class658_0 != null)
			{
				this.class658_0.Dispose();
			}
			if (this.class108_0 != null)
			{
				this.class108_0.Dispose();
			}
			if (this.class107_0 != null)
			{
				this.class107_0.Dispose();
			}
			if (this.inputOverlay_0 != null)
			{
				this.inputOverlay_0.Dispose();
			}
			if (Class62.class664_0 != null && !(this is Class64))
			{
				Class62.class664_0.Dispose();
				Class62.class664_0 = null;
			}
			if (Class62.bool_27)
			{
				Class62.int_10++;
			}
			else
			{
				Class62.int_10 = 0;
			}
			if (!Class802.smethod_0())
			{
				Class62.int_11++;
			}
			if (this.class427_0 != null)
			{
				this.class427_0.Dispose();
			}
			Class802.int_1 = 0;
			Class62.Mode = this.playModes_1;
			base.Dispose(bool_48);
			if (Class115.bool_16)
			{
				Class115.class533_0.float_3 = 1f;
			}
		}

		// Token: 0x06001E86 RID: 7814
		// RVA: 0x000ABAE4 File Offset: 0x000A9CE4
		public override void Draw()
		{
			if (this.enum110_0 != Enum110.const_0)
			{
				if (this.class427_0.class413_0.vmethod_0() == 0)
				{
					this.int_18 = 0;
				}
				if (this.class427_0.vmethod_14() && this.int_18 < this.class427_0.class413_0.vmethod_0())
				{
					this.bool_19 = true;
				}
				List<Class304> arg_78_0 = this.class297_0.list_4;
				if (Class62.predicate_9 == null)
				{
					Class62.predicate_9 = new Predicate<Class304>(Class62.smethod_27);
				}
				Class304 class = arg_78_0.Find(Class62.predicate_9);
				bool flag;
				if (!(flag = (!(this.class427_0 is Class432) && Class885.class547_0.bool_7 && class != null && this.vmethod_32())) || class.list_1[0].float_3 != 1f)
				{
					if (flag && Class115.bool_21)
					{
						this.class872_0.class911_1.float_1 = Math.Max(this.class872_0.class911_1.float_1, ((float)Class872.int_2 + class.list_1[0].float_3 * (float)(100 - Class872.int_2)) / 100f);
					}
					this.class872_0.method_4();
					if (Class466.Current.bool_14)
					{
						this.class872_0.method_5();
					}
					if (!Class62.bool_9)
					{
						this.method_65(Class778.smethod_2((float)(this.class427_0.class413_0.int_0 - 29) / 300f * ((this.class427_0.class410_0 != null) ? this.class427_0.class410_0.class531_0.float_3 : 0f), 0f, (float)Class466.smethod_22(Class341.class607_1, 0.05, 0.3, 0.8)));
					}
					if (!Class466.Current.bool_14)
					{
						this.class872_0.method_5();
					}
				}
				this.class911_6.float_1 = Class872.class872_0.class911_1.float_1;
				this.class911_6.Draw();
				this.class911_5.Draw();
				this.vmethod_29();
				this.class911_4.Draw();
				this.vmethod_27();
				this.class911_2.Draw();
				this.class911_3.float_0 = ((!Class62.bool_11 || this.list_1 == null) ? 1f : (1f - this.list_1[0].float_3));
				this.class911_3.Draw();
				this.vmethod_28();
				this.class911_7.Draw();
				if (this.class658_0 != null)
				{
					this.class658_0.Draw();
				}
				this.class911_8.Draw();
				if (this.inputOverlay_0 != null && Class802.smethod_0())
				{
					this.inputOverlay_0.Draw();
				}
				if (Class62.bool_11 || Class62.bool_29)
				{
					this.class911_9.Draw();
				}
				this.class911_10.Draw();
			}
			if (!this.class523_0.bool_0)
			{
				if (Class62.class911_1 != null)
				{
					Class62.class911_1.Draw();
				}
				this.class911_6.Draw();
				this.class523_0.Draw();
			}
			if (this.class108_0 != null)
			{
				this.class108_0.Draw();
			}
			if (this.class107_0 != null)
			{
				this.class107_0.Draw();
			}
			base.Draw();
		}

		// Token: 0x06001E6A RID: 7786
		// RVA: 0x000A9B6C File Offset: 0x000A7D6C
		public override void imethod_2()
		{
			if (this.method_45())
			{
				return;
			}
			if (this.inputOverlay_0 != null)
			{
				this.inputOverlay_0.imethod_2();
			}
			float num = (float)(Class341.class606_75.Value ? 1 : 0);
			float num2;
			if (!this.class523_0.bool_0)
			{
				num2 = 0f;
			}
			else if (Class331.int_7 < -1000 && this.int_24 > 6000)
			{
				num2 = 0f;
			}
			else if (this.bool_25)
			{
				num2 = 0f;
			}
			else
			{
				num2 = 1f;
			}
			if (Class115.bool_16)
			{
				this.class911_7.float_1 = (this.class911_8.float_1 = (Class872.class872_0.class911_0.float_1 - 0.5f) * 2f);
				Class115.class533_0.float_3 = Math.Min(1f, 1f - this.class911_7.float_1);
			}
			if ((Class62.bool_11 || Class62.bool_29) && this.list_1 != null && Class331.int_7 < this.int_24)
			{
				this.class538_0.float_3 = (1f - this.list_1[0].float_3) * 0.6f;
			}
			if (this.class911_4.float_0 != num2)
			{
				this.class911_4.float_0 = MathHelper.Clamp(this.class911_4.float_0 + ((num2 < this.class911_4.float_0) ? -0.07f : 0.07f) * (float)Class115.double_0, 0f, 1f);
				if (this.class297_0 != null)
				{
					this.class297_0.class911_0.float_0 = this.class911_4.float_0;
				}
				if (this.class427_0 != null)
				{
					this.class427_0.vmethod_21(this.class911_4.float_0);
				}
			}
			if (this.class911_7.float_0 != num && !this.bool_25)
			{
				this.class911_8.float_0 = (this.class911_7.float_0 = MathHelper.Clamp(this.class911_7.float_0 + ((num < this.class911_7.float_0) ? -0.07f : 0.07f) * (float)Class115.double_0, 0f, 1f));
			}
			else if (this.bool_25)
			{
				this.class911_8.float_0 = (this.class911_7.float_0 = this.class911_4.float_0 * num);
			}
			if (this.enum110_0 == Enum110.const_0 || Class115.enum113_0 == Enum113.const_0)
			{
				return;
			}
			if (Class802.smethod_0() && Class331.bool_2)
			{
				List<Struct13> arg_2AF_0 = Class62.class512_0.list_5;
				if (Class62.predicate_3 == null)
				{
					Class62.predicate_3 = new Predicate<Struct13>(Class62.smethod_21);
				}
				Struct13 struct13_ = arg_2AF_0.FindLast(Class62.predicate_3);
				this.method_47(struct13_);
			}
			if (this.enum110_0 == Enum110.const_1 && Class331.int_7 >= this.int_24)
			{
				this.method_16();
				this.enum110_0 = Enum110.const_2;
			}
			if (!Class802.smethod_0() && !(this is Class63))
			{
				this.method_12();
			}
			if (Class62.bool_6 && Class858.bool_1 && !Class802.smethod_0() && !this.bool_26)
			{
				Class858.smethod_3(Enum0.const_4, null);
				this.bool_26 = true;
			}
			if (Class62.int_9 > 0 && !Class62.bool_11 && !Class62.bool_29)
			{
				this.vmethod_13();
			}
			if (Class331.int_7 >= this.int_24 && Class331.enum100_0 == Enum100.const_1)
			{
				if (!this.bool_25)
				{
					if (this.class538_0.bool_3 && this.class538_0.int_0 != -1)
					{
						this.class538_0.int_0 = -1;
						this.vmethod_18();
					}
				}
				else if (!this.class538_0.bool_3 && this.class538_0.class26_0.Count == 0 && this.class872_0.int_0 - Class331.int_7 > 3000)
				{
					Class62.bool_42 = true;
					this.class538_0.bool_1 = true;
					this.class538_0.class26_0.Clear();
					this.class538_0.method_14(300, Enum70.const_0);
				}
			}
			if (Class115.int_1 - this.int_26 > 1000)
			{
				this.int_26 = Class115.int_1;
				if ((Class858.bool_1 && !Class802.smethod_0() && Class341.class606_55) || (Class802.bool_16 && Class858.list_1.Count > 0))
				{
					List<Class861> list = Class802.bool_16 ? Class858.list_1 : Class858.list_0;
					string text = string.Format(Class802.bool_16 ? Class41.GetString(OsuString.Player_OtherSpectators) : Class41.GetString(OsuString.Player_Spectators), list.Count);
					if (list.Count < 30)
					{
						text += ":";
						string text2 = "\n\n" + Class41.GetString(OsuString.Player_SpectatorsMissingBeatmap);
						int num3 = 0;
						lock (Class858.list_0)
						{
							foreach (Class861 current in list)
							{
								if (current.bool_0)
								{
									num3++;
									text2 = text2 + "\n" + current.Name;
								}
								else
								{
									text = text + "\n" + current.Name;
								}
							}
						}
						if (num3 > 0)
						{
							text += text2;
						}
					}
					if (this.class533_1 != null && this.class533_1.Text != text)
					{
						this.class533_1.Text = text;
					}
				}
				else if (this.class533_1 != null && this.class533_1.Text.Length > 0)
				{
					this.class533_1.Text = string.Empty;
				}
			}
			if (this.class108_0 != null)
			{
				this.class108_0.imethod_2();
				this.class911_9.bool_6 = !this.class108_0.bool_1;
				if (this.class538_0.int_0 != -1)
				{
					this.class538_0.bool_1 = (!this.class108_0.bool_1 && !Class62.bool_11);
				}
			}
			if (this.class107_0 != null)
			{
				this.class107_0.imethod_2();
			}
			this.class872_0.method_6();
			if (!Class114.bool_0 && Class62.bool_12 && !Class62.bool_11)
			{
				this.method_14(this, null);
			}
			if ((!Class802.smethod_0() || Class858.class861_0 == null) && Class72.class10_0 == null && Class115.enum113_0 == Enum113.const_2)
			{
				if (!Class111.bool_2 && ((Class570.bool_0 && Class570.smethod_9(82)) || Class570.smethod_9(Class795.smethod_3(Bindings.QuickRetry))))
				{
					if (Class115.double_8 <= 0.0)
					{
						Class115.class911_4.Clear(true);
						Class115.class531_0.method_8(false);
						Class115.class911_4.Add(Class115.class531_0);
					}
					Class115.double_8 = Math.Min(100.0, Class115.double_8 + (double)(10f * (float)Class115.double_0));
					if (Class115.double_8 == 100.0)
					{
						Class62.smethod_4(true);
					}
				}
				else if (Class115.double_8 > 0.0)
				{
					Class115.double_8 = Math.Max(0.0, Class115.double_8 - (double)(3f * (float)Class115.double_0));
				}
			}
			if (Class62.bool_11)
			{
				this.int_3 = -1;
				this.int_4 = -1;
				return;
			}
			if (Class62.bool_29)
			{
				if (!this.bool_28 || (this.list_1 != null && (this.list_1.Count <= 0 || this.list_1[0].bool_3)))
				{
					return;
				}
				this.method_57();
				this.class538_0.bool_1 = true;
				if (Class331.smethod_79() && !Class62.bool_13)
				{
					Class331.smethod_88();
				}
			}
			if (Class62.bool_23 && Class331.double_2 >= (double)this.int_34 && Class115.enum113_0 == Enum113.const_2 && this.bool_43)
			{
				Class62.bool_23 = false;
				if (Class331.bool_4)
				{
					Class331.smethod_101();
					if (Class331.int_7 > 1000)
					{
						Class331.smethod_70(Class331.int_7, false, true);
					}
				}
				Class331.smethod_93();
			}
			if (Class331.enum100_0 == Enum100.const_0 && !Class62.bool_13 && !Class62.bool_23 && !Class62.bool_24)
			{
				Class331.smethod_99();
				Class62.bool_24 = true;
			}
			this.class427_0.vmethod_36();
			this.method_53();
			this.class297_0.vmethod_15();
			if (!Class802.smethod_0() || Class802.bool_25 || this.bool_45)
			{
				this.class427_0.vmethod_32();
				this.method_52();
			}
			this.class297_0.vmethod_16();
			this.class427_0.method_2();
			this.method_46();
			this.method_58();
			this.vmethod_25();
			this.method_64();
			if (this.class533_1 != null)
			{
				float num4 = (Class62.class664_0 == null) ? 1f : Class62.class664_0.class911_0.float_0;
				this.class533_1.float_3 = (Class62.bool_11 ? Math.Max(num4, this.class911_9.float_0) : num4);
			}
			if (this.class427_0.class410_0 != null && this.class427_0.class410_0.method_2() <= 0.0 && !Class876.smethod_6(Class62.class512_0.class623_0, Mods.NoFail) && !Class62.bool_15 && !Class62.bool_16 && (!Class802.smethod_0() || Class802.bool_17) && !Class115.bool_25 && ((Class62.Mode == PlayModes.Taiko && Class331.int_7 > this.class297_0.list_3[0].EndTime) || (Class62.Mode != PlayModes.Taiko && Class331.int_7 > this.class297_0.list_3[0].StartTime)))
			{
				this.vmethod_22();
			}
			if (this.int_23 != Class62.class512_0.int_3 || (int)Class62.class512_0.ushort_5 != this.int_20 || Class62.bool_6 != this.bool_20)
			{
				this.vmethod_24();
				this.bool_20 = Class62.bool_6;
				this.int_23 = Class62.class512_0.int_3;
				this.int_20 = (int)Class62.class512_0.ushort_5;
				this.bool_21 = true;
			}
			if (Class62.bool_6)
			{
				this.method_50();
				return;
			}
			if (Class62.bool_13 && this.class427_0.class410_0.method_0() > this.class427_0.class410_0.method_2() - 5.0)
			{
				Class62.bool_13 = false;
				Class331.smethod_61(Class331.smethod_37("gos", false, true, Enum112.flag_6), 100, 0f, false, 1f);
				Class331.smethod_93();
			}
			this.method_10();
			if (Class62.bool_15 && Class62.Mode != PlayModes.Taiko)
			{
				foreach (Class304 current2 in this.class297_0.list_4)
				{
					if (current2.StartTime - Class331.int_7 < 12 && ((current2.IsType(HitObjectType.Normal) && !current2.bool_0) || (current2.IsType(HitObjectType.Slider) && !((Class321)current2).vmethod_25())))
					{
						this.method_70(this, null);
						if (Class115.bool_13)
						{
							Class746 item = new Class746(Color.get_Pink(), Color.get_White(), Class115.int_1, Class115.int_1 + 150);
							Class802.class531_0.class26_0.Add(item);
						}
					}
				}
			}
			if ((Class62.bool_15 || Class62.bool_16 || (Class62.bool_38 && (Class802.buttonState_0 == 1 || Class802.buttonState_5 == 1))) && Class115.bool_13 && (Class62.bool_8 || Class62.bool_9))
			{
				this.method_59(null);
			}
			if (Class62.bool_38)
			{
				this.class427_0.vmethod_45();
			}
			this.method_49();
			if (Class115.enum113_0 == Enum113.const_2 && !Class62.bool_23)
			{
				this.bool_30 = ((!Class115.bool_25 || Class331.int_9 > Class115.int_28) && (!Class802.smethod_0() || Class802.int_2 < Class331.int_9) && Class331.int_7 >= this.class297_0.list_3[0].StartTime - this.class297_0.PreEmpt && Class331.int_7 <= this.class297_0.list_3[this.class297_0.int_14 - 1].EndTime && this.int_22 < 0 && Class331.enum100_0 != Enum100.const_0 && this.method_48());
				this.method_54();
				if (this.class297_0.list_3[this.class297_0.int_14 - 1].EndTime + 3000 <= Class331.int_7 && (this.class872_0.list_1.Count == 0 || this.class872_0.int_0 - 500 <= Class331.int_7) && (this.bool_25 || this is Class64))
				{
					this.method_63();
				}
				if (Class872.bool_1 && Class872.class705_0 != null && Class331.int_7 > this.class297_0.list_3[0].StartTime && !this.bool_17)
				{
					List<Class304> arg_D43_0 = this.class297_0.list_4;
					if (Class62.predicate_4 == null)
					{
						Class62.predicate_4 = new Predicate<Class304>(Class62.smethod_22);
					}
					if (arg_D43_0.Find(Class62.predicate_4) == null)
					{
						this.method_61();
						this.class427_0.method_0();
						this.bool_17 = true;
						if (Class872.class705_0.Length > 5000 && Class62.class512_0.vmethod_2() > 5 && !Class62.bool_15 && !Class62.bool_16)
						{
							this.method_56();
						}
						if (Class872.class705_0.Length > 2880 && !this.bool_25 && !Class62.bool_6)
						{
							this.method_55();
							goto IL_DEC;
						}
						goto IL_DEC;
					}
				}
				if (!Class872.bool_1 && !this.bool_25 && !Class62.bool_6 && this.bool_17)
				{
					this.bool_17 = false;
					this.class427_0.method_1();
				}
			}
			IL_DEC:
			this.method_72();
			if (!Class872.bool_1 && !this.bool_25)
			{
				this.class427_0.class413_0.vmethod_6();
			}
			base.imethod_2();
			if (Class802.bool_16 && Class802.int_1 == Class858.int_0)
			{
				Class62.smethod_9();
				Class858.int_0 = -1;
			}
			this.bool_37 = false;
		}

		// Token: 0x06001E3A RID: 7738
		// RVA: 0x000A4CD4 File Offset: 0x000A2ED4
		public override void Initialize()
		{
			this.method_3();
			Class115.class115_0.method_5(new EventHandler(this.method_14));
			Class115.class115_0.method_7(new EventHandler(this.method_14));
			if (Class802.smethod_0())
			{
				Class62.Mode = ((Class802.class512_0 != null) ? Class802.class512_0.playModes_0 : PlayModes.Osu);
			}
			if (!Class802.smethod_0() && !Class876.smethod_5(Mods.Autoplay) && Class72.class10_0 == null)
			{
				Class62.int_12 = Class115.int_1;
			}
			this.playModes_1 = Class62.Mode;
			if (Class466.Current.method_5() != PlayModes.Osu)
			{
				Class62.Mode = Class466.Current.method_5();
				Class115.smethod_68(1f, true);
			}
			if (Class876.smethod_5(Mods.Cinema))
			{
				if (Class802.smethod_0())
				{
					Class876.class623_0 &= ~(Mods.Autoplay | Mods.Cinema);
				}
				else
				{
					if (Class466.Current.method_5() == PlayModes.Osu)
					{
						Class62.Mode = PlayModes.Osu;
					}
					Class872.int_2 = 0;
					Class872.smethod_1(true);
					Class872.smethod_3(true);
					Class885.bool_2 = false;
					Class331.bool_3 = false;
				}
			}
			else if (!Class115.bool_25)
			{
				this.class108_0 = new Class108(Class115.class114_0);
			}
			if (!Class62.bool_34 && Class341.class606_43)
			{
				Class62.bool_34 = true;
				Class723.smethod_5(string.Format(Class41.GetString(OsuString.InputManager_MouseButtonsDisabledWarning), Class795.smethod_3(Bindings.DisableMouseButtons)), Color.get_Beige(), 10000, null);
			}
			if (!Class62.bool_35 && !Class341.class606_75)
			{
				Class62.bool_35 = true;
				Class723.smethod_5(string.Format(Class41.GetString(OsuString.Player_InterfaceDisabledWarning), "Shift + " + Class795.smethod_3(Bindings.ToggleScoreboard)), Color.get_Beige(), 10000, null);
			}
			Class876.smethod_4(Mods.None);
			this.bool_45 = false;
			Class62.bool_15 = (Class876.smethod_5(Mods.Relax) && !Class802.smethod_0());
			Class62.bool_16 = (Class876.smethod_5(Mods.Relax2) && !Class802.smethod_0());
			if (Class115.bool_25 || ((Class876.smethod_5(Mods.Autoplay) || Class62.bool_16) && !Class802.smethod_0()))
			{
				this.bool_45 = true;
				Class858.smethod_4(false);
				if (!Class115.bool_25 && !Class62.bool_16)
				{
					Class802.smethod_1(true);
				}
				Class802.class512_0 = Class721.Create(Class62.playModes_0, "osu!", Class466.Current);
				Class802.class512_0.class623_0 = Class876.class623_0;
			}
			this.class911_2 = new Class911(true)
			{
				bool_4 = true
			};
			this.class911_4 = new Class911(true)
			{
				bool_4 = true,
				float_0 = 0f
			};
			this.class911_7 = new Class911
			{
				bool_4 = true,
				float_0 = 0f
			};
			this.class911_8 = new Class911(true)
			{
				bool_4 = true,
				float_0 = 0f
			};
			this.class911_5 = new Class911(true)
			{
				float_0 = 0f
			};
			this.class911_6 = new Class911(true);
			this.class911_9 = new Class911(true)
			{
				bool_4 = true,
				bool_1 = false
			};
			this.class911_10 = new Class911(true)
			{
				bool_4 = true
			};
			this.class911_3 = new Class911(true)
			{
				bool_4 = true
			};
			Class62.bool_11 = false;
			Class62.bool_6 = false;
			Class62.bool_13 = false;
			Class62.bool_8 = false;
			Class62.bool_9 = false;
			Class62.bool_7 = false;
			Class62.bool_23 = true;
			Class62.bool_29 = false;
			Class62.bool_42 = false;
			Class62.bool_24 = false;
			Class62.bool_38 = false;
			Class62.bool_40 = false;
			this.bool_33 = false;
			Class62.bool_47 = false;
			this.bool_14 = (Class466.Current.Title == "osu! tutorial");
			Class62.int_13 = 0;
			Class62.int_8 = 0;
			if (Class115.osuModes_2 != OsuModes.Play)
			{
				Class62.int_9 = 0;
			}
			if (Class62.class911_1 == null)
			{
				Class62.class911_1 = new Class911(true);
			}
			this.class531_4 = Class599.smethod_0(Class885.smethod_37());
			this.class531_4.method_15(400);
			Class62.class911_1.Add(this.class531_4);
			this.bool_36 = (!Class62.bool_27 && !Class802.smethod_0() && !Class115.bool_25);
			this.bool_46 = (Class115.osuModes_2 == OsuModes.Play);
			if (this.bool_36 && this.class108_0 != null && this.class108_0.method_3())
			{
				this.class108_0.method_14(!Class802.smethod_0() && Class858.class861_0 == null, this.bool_46);
			}
			this.class523_0 = new Class523(new VoidDelegate(this.vmethod_6), new Delegate2(this.vmethod_7));
			Class115.class83_0.bool_2 = false;
			base.Initialize();
		}

		// Token: 0x06001E26 RID: 7718
		// RVA: 0x000A4238 File Offset: 0x000A2438
		private bool method_1()
		{
			return !Class802.smethod_0() && !Class115.bool_25 && this.class427_0.vmethod_7() && Class466.Current.submissionStatus_0 != SubmissionStatus.NotSubmitted && Class466.Current.submissionStatus_0 != SubmissionStatus.Pending && !Class466.Current.bool_18 && Class876.smethod_3(Class62.class512_0.class623_0) && Class62.class512_0.bool_0 && this.bool_3 && (!Class466.Current.bool_3 || Class466.Current.bool_10);
		}

		// Token: 0x06001E2F RID: 7727
		// RVA: 0x000A4808 File Offset: 0x000A2A08
		private void method_10()
		{
			if (!Class802.smethod_0() && !Class115.bool_25)
			{
				if (this.int_3 == -1)
				{
					if (Class331.int_7 > 0)
					{
						this.int_3 = Class331.int_7;
						this.int_4 = Class115.int_1;
					}
				}
				else if (Class331.int_7 - this.int_3 >= 1000)
				{
					float num = 1f;
					if (Class876.smethod_5(Mods.DoubleTime))
					{
						num = 1.5f;
					}
					else if (Class876.smethod_5(Mods.HalfTime))
					{
						num = 0.75f;
					}
					float num2 = (float)(Class331.int_7 - this.int_3) * (1f / num);
					if (Math.Abs(num2 - (float)(Class115.int_1 - this.int_4)) > 60f)
					{
						if (++this.int_2 > 5)
						{
							Class723.smethod_4("There was an error during timing calculations.  If you continue to get this error, please update your AUDIO/SOUND CARD drivers!  Your score will not be submitted for this play.");
							Class62.class512_0.bool_0 = false;
							Class47 arg_104_0 = Class115.class47_0;
							if (Class62.voidDelegate_3 == null)
							{
								Class62.voidDelegate_3 = new VoidDelegate(Class62.smethod_13);
							}
							arg_104_0.method_1(Class62.voidDelegate_3, 200, false);
							this.int_2 = -500;
						}
					}
					else
					{
						this.int_2 = 0;
					}
					this.int_3 = -1;
				}
				if ((Class62.enum43_0 & Enum43.flag_1) == Enum43.flag_0)
				{
					long num3 = DateTime.Now.Ticks / 10000L;
					if (this.long_0 == -1L)
					{
						if (Class331.int_7 > 0)
						{
							this.long_0 = num3;
							this.int_15 = Class115.int_1;
							return;
						}
					}
					else if (Math.Abs(num3 - this.long_0 - (long)(Class115.int_1 - this.int_15)) > 2000L)
					{
						this.int_14++;
						if (this.int_14 > 4)
						{
							Class62.enum43_0 |= Enum43.flag_1;
						}
						this.long_0 = num3;
						this.int_15 = Class115.int_1;
					}
				}
			}
		}

		// Token: 0x06001E31 RID: 7729
		// RVA: 0x00018C91 File Offset: 0x00016E91
		internal void method_11()
		{
			throw new ObjectDisposedException("WildCatTracer");
		}

		// Token: 0x06001E32 RID: 7730
		// RVA: 0x000A4B18 File Offset: 0x000A2D18
		public void method_12()
		{
			if (!Class62.class512_0.bool_0)
			{
				return;
			}
			if (this.bool_25 && Class115.process_0 == null)
			{
				Class115.process_0 = new Process[0];
				if (Class62.voidDelegate_4 == null)
				{
					Class62.voidDelegate_4 = new VoidDelegate(Class62.smethod_14);
				}
				Class115.smethod_88(Class62.voidDelegate_4, false, ThreadPriority.Normal);
			}
			if (this.int_31 == 0 && (Class331.int_7 < this.class297_0.list_3[0].StartTime || Class331.enum100_0 != Enum100.const_1))
			{
				return;
			}
			if (this.int_31 > 0 && Class115.int_1 - this.int_31 > (Class872.bool_1 ? 8000 : 6000))
			{
				Class62.class512_0.bool_0 = false;
				Class723.smethod_1("Score submission disabled due to system lag.", 3000);
			}
			this.int_31 = Class115.int_1;
		}

		// Token: 0x06001E33 RID: 7731
		// RVA: 0x00018C9D File Offset: 0x00016E9D
		internal bool method_13()
		{
			return this.class538_0 != null && this.class538_0.vmethod_1();
		}

		// Token: 0x06001E3B RID: 7739
		// RVA: 0x000A519C File Offset: 0x000A339C
		private void method_14(object sender, EventArgs e)
		{
			if (!Class62.bool_11)
			{
				if (!Class62.bool_12 || Class72.class10_0 != null)
				{
					return;
				}
				this.vmethod_16();
			}
			if (this.list_1 == null)
			{
				return;
			}
			List<Class531> arg_4A_0 = this.list_1;
			if (Class62.predicate_0 == null)
			{
				Class62.predicate_0 = new Predicate<Class531>(Class62.smethod_16);
			}
			using (List<Class531>.Enumerator enumerator = arg_4A_0.FindAll(Class62.predicate_0).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VoidDelegate voidDelegate = null;
					Class62.Class417 class = new Class62.Class417();
					class.class531_0 = enumerator.Current;
					if (Class114.bool_0)
					{
						Class47 arg_90_0 = Class115.class47_0;
						if (voidDelegate == null)
						{
							voidDelegate = new VoidDelegate(class.method_0);
						}
						arg_90_0.method_1(voidDelegate, 500, false);
					}
					else
					{
						class.class531_0.bool_1 = false;
						class.class531_0.method_39(Color.get_DarkGray(), 100, false, Enum70.const_0);
					}
				}
			}
		}

		// Token: 0x06001E3C RID: 7740
		// RVA: 0x000A528C File Offset: 0x000A348C
		private void method_15()
		{
			if (Class466.Current.bool_21 && !Class62.bool_27 && !Class115.bool_25)
			{
				Class531 class = new Class531(Class885.Load("epilepsy", Enum112.flag_1), Enum115.const_9, Origins.Centre, Enum114.const_0, Vector2.get_Zero(), 1f, false, Color.get_TransparentWhite(), null);
				class.method_14(200, Enum70.const_0);
				class.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class115.int_1 + 3000, Class115.int_1 + 3400, Enum70.const_0));
				this.class911_6.Add(class);
				this.list_2.Add(class);
			}
		}

		// Token: 0x06001E3F RID: 7743
		// RVA: 0x000A5A98 File Offset: 0x000A3C98
		private void method_16()
		{
			foreach (Class531 current in this.list_2)
			{
				current.method_16(200, Enum70.const_0);
			}
			this.list_2.Clear();
		}

		// Token: 0x06001E40 RID: 7744
		// RVA: 0x000A5AFC File Offset: 0x000A3CFC
		private void method_17()
		{
			Class331.bool_5 = Class876.smethod_6(Class62.class512_0.class623_0, Mods.Nightcore);
			if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.DoubleTime))
			{
				Class331.smethod_68(150);
			}
			else if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.HalfTime))
			{
				Class331.smethod_68(75);
			}
			this.method_8();
			this.class335_0 = Class331.class335_0;
			if (this.class335_0 != null)
			{
				this.float_2 = this.class335_0.vmethod_0();
			}
			if (Class331.smethod_84(Class466.Current, false, false, false, false))
			{
				Class331.smethod_87();
				Class331.smethod_90();
			}
		}

		// Token: 0x06001E41 RID: 7745
		// RVA: 0x000A5BB4 File Offset: 0x000A3DB4
		private void method_18()
		{
			if ((Class115.bool_25 && Class115.int_28 > this.class297_0.list_3[0].StartTime) || Class802.int_2 > 0)
			{
				Class331.double_2 = (double)this.int_34;
				for (int i = 0; i < this.class297_0.int_14; i++)
				{
					if (this.class297_0.list_3[i].EndTime <= Class331.int_7)
					{
						this.class297_0.list_3[i].bool_0 = true;
						this.class427_0.class410_0.vmethod_10(this.class297_0.list_3[i].double_0);
					}
				}
				Class62.bool_38 = Class331.smethod_7().method_2();
			}
		}

		// Token: 0x06001E42 RID: 7746
		// RVA: 0x000A5C7C File Offset: 0x000A3E7C
		private void method_19()
		{
			if (Class341.class605_2 != ProgressBarTypes.Off && !Class62.bool_15 && !Class62.bool_16)
			{
				ProgressBarTypes progressBarTypes = Class341.class605_2;
				if (progressBarTypes == ProgressBarTypes.Pie)
				{
					this.class658_0 = new Class659(this.class911_8, this.class427_0.class666_0.vector2_0);
					return;
				}
				this.class658_0 = new Class658(this.class911_8, Class341.class605_2, this.class427_0.class666_0.method_0());
			}
		}

		// Token: 0x06001E27 RID: 7719
		// RVA: 0x000A42CC File Offset: 0x000A24CC
		private bool method_2()
		{
			return (Class331.int_7 - this.int_24 > 8000 || Class62.class512_0.bool_2) && Class62.class512_0.int_3 > 10000 && Class62.class512_0.bool_0 && this.int_6 > 0 && this.class427_0.int_3 > 0 && this.int_6 == this.class427_0.int_3 && this.bool_32;
		}

		// Token: 0x06001E44 RID: 7748
		// RVA: 0x000A6064 File Offset: 0x000A4264
		private void method_20()
		{
			if (this.bool_14)
			{
				return;
			}
			if (Class62.int_10 > 1)
			{
				Class533 class = new Class533(string.Format(Class41.GetString(OsuString.Player_RetriesCounting), Class62.int_10), 14f, new Vector2(0f, 30f), 1f, false, Color.get_White());
				class.bool_16 = true;
				class.vmethod_11();
				class.class26_0.Add(new Class746(new Vector2(-20f, 30f), class.vector2_0, Class115.int_1 + 1000, Class115.int_1 + 1500, Enum70.const_1));
				class.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, Class115.int_1 + 1000, Class115.int_1 + 1500, Enum70.const_0));
				class.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class115.int_1 + 3500, Class115.int_1 + 4500, Enum70.const_0));
				this.class911_8.Add(class);
			}
			if (!Class802.smethod_0() && Class62.int_10 > 0 && Class62.int_10 % 10 == 0)
			{
				Class111.smethod_25(string.Format(Class41.GetString(OsuString.Userlog_RetryCount), Class62.int_10, Class466.Current.string_7, Class213.smethod_0(Class62.Mode)));
			}
			if (!Class802.smethod_0() && Class62.int_11 > 0 && Class62.int_11 % 50 == 0)
			{
				Class111.smethod_25(string.Format(Class41.GetString(OsuString.Userlog_PlayCount), Class62.int_11));
			}
			if (Class115.bool_25 || !this.class427_0.vmethod_4())
			{
				return;
			}
			if (string.IsNullOrEmpty(Class466.Current.string_10))
			{
				return;
			}
			string[] array = Class466.Current.string_10.Split(new char[]
			{
				'\n'
			});
			List<Class533> list = new List<Class533>();
			Vector2 vector2_;
			vector2_..ctor(0f, -90f);
			int num = 200;
			int num2 = 3800 + array.Length * 800;
			float num3 = 1f;
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				string text = array2[i];
				float num4 = 40f;
				bool flag = true;
				Color color_ = Color.get_White();
				int num5 = 500;
				string string_ = text;
				if (text.Length != 0)
				{
					if (text[0] == '[')
					{
						string text2 = text.Substring(1, text.IndexOf(']') - 1);
						string[] array3 = text2.Split(new char[]
						{
							','
						});
						for (int j = 0; j < array3.Length; j++)
						{
							string text3 = array3[j];
							string[] array4 = text3.Split(new char[]
							{
								':'
							});
							string a;
							if (array4.Length == 2 && (a = array4[0]) != null)
							{
								if (!(a == "size"))
								{
									if (!(a == "bold"))
									{
										if (!(a == "colour"))
										{
											if (!(a == "wait"))
											{
												if (!(a == "time"))
												{
													if (a == "hold")
													{
														num2 = num + int.Parse(array4[1]);
													}
												}
												else
												{
													num = int.Parse(array4[1]);
													num2 = num + 4000 + array.Length * 800;
												}
											}
											else
											{
												num5 = int.Parse(array4[1]);
											}
										}
										else
										{
											string[] array5 = array4[1].Split(new char[]
											{
												'.'
											});
											if (array5.Length == 3)
											{
												color_ = new Color(byte.Parse(array5[0]), byte.Parse(array5[1]), byte.Parse(array5[2]));
											}
										}
									}
									else
									{
										flag = (array4[1] == "1");
									}
								}
								else
								{
									float.TryParse(array4[1], out num4);
								}
							}
						}
						string_ = text.Substring(text.IndexOf(']') + 1);
					}
					num += num5;
					num2 += num5;
					Class533 class2 = new Class533(string_, num4, vector2_, 0.87f, false, color_);
					class2.enum114_0 = Enum114.const_1;
					class2.method_58(true);
					class2.bool_16 = flag;
					class2.enum115_0 = Enum115.const_9;
					class2.origins_0 = Origins.Centre;
					class2.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, (int)((float)num * num3), (int)((float)(num + 500) * num3), Enum70.const_0));
					class2.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, (int)((float)num2 * num3), (int)((float)(num2 + 500) * num3), Enum70.const_0));
					this.class911_6.Add(class2);
					list.Add(class2);
					class2 = new Class533(string_, num4 * 2f, vector2_, 0.86f, false, color_);
					class2.enum114_0 = Enum114.const_1;
					class2.bool_7 = true;
					class2.method_58(true);
					class2.bool_16 = flag;
					class2.enum115_0 = Enum115.const_9;
					class2.origins_0 = Origins.Centre;
					class2.class26_0.Add(new Class746(TransformationType.Fade, 0f, 0.1f, (int)((float)num * num3), (int)((float)(num + 500) * num3), Enum70.const_0));
					class2.class26_0.Add(new Class746(TransformationType.Fade, 0.1f, 0f, (int)((float)num2 * num3), (int)((float)(num2 + 500) * num3), Enum70.const_0));
					this.class911_6.Add(class2);
					list.Add(class2);
					num += 200;
					vector2_.Y += 60f * (num4 / 40f);
				}
			}
			for (int k = 0; k < list.Count; k++)
			{
				bool flag2 = k / 2 % 2 == 0;
				bool flag3 = k % 2 == 1;
				Class533 class3 = list[k];
				float num6 = class3.vmethod_11().X * 0.625f / 2f;
				Class533 expr_5F0_cp_0 = class3;
				expr_5F0_cp_0.vector2_1.Y = expr_5F0_cp_0.vector2_1.Y - (50f + vector2_.Y / 2f);
				if (flag2)
				{
					class3.class26_0.Add(new Class746(class3.vector2_1 - new Vector2(flag3 ? num6 : 50f, 0f), class3.vector2_1 - new Vector2(flag3 ? (-num6) : -50f, 0f), class3.class26_0[0].int_0, class3.class26_0[1].int_1, Enum70.const_0));
				}
				else
				{
					class3.class26_0.Add(new Class746(class3.vector2_1 - new Vector2(flag3 ? (-num6) : -50f, 0f), class3.vector2_1 - new Vector2(flag3 ? num6 : 50f, 0f), class3.class26_0[0].int_0, class3.class26_0[1].int_1, Enum70.const_0));
				}
			}
		}

		// Token: 0x06001E46 RID: 7750
		// RVA: 0x000A6810 File Offset: 0x000A4A10
		private void method_21()
		{
			Class802.smethod_34(Enum96.const_8, new Delegate46(this.method_71), Enum98.const_2, Enum97.const_0);
			Class802.smethod_34(Enum96.const_7, new Delegate46(this.method_70), Enum98.const_2, Enum97.const_0);
			Class570.smethod_0(new Class570.Delegate44(this.vmethod_15));
			Class331.smethod_27(new Class331.Delegate31(this.method_24));
			Class331.smethod_2(new VoidDelegate(this.method_22));
			this.class297_0.method_13(new Class297.Delegate34(this.method_73));
		}

		// Token: 0x06001E47 RID: 7751
		// RVA: 0x00018D5D File Offset: 0x00016F5D
		private void method_22()
		{
			this.bool_37 = true;
		}

		// Token: 0x06001E48 RID: 7752
		// RVA: 0x000A6890 File Offset: 0x000A4A90
		private void method_23()
		{
			Class570.smethod_1(new Class570.Delegate44(this.vmethod_15));
			Class331.smethod_28(new Class331.Delegate31(this.method_24));
			Class331.smethod_3(new VoidDelegate(this.method_22));
			if (this.class297_0 != null)
			{
				this.class297_0.method_14(new Class297.Delegate34(this.method_73));
			}
		}

		// Token: 0x06001E49 RID: 7753
		// RVA: 0x00018D66 File Offset: 0x00016F66
		private void method_24(Class340 class340_0)
		{
			if (Class62.bool_38 != class340_0.method_2())
			{
				Class62.bool_38 = class340_0.method_2();
				this.class427_0.vmethod_46(Class62.bool_38);
			}
		}

		// Token: 0x06001E4B RID: 7755
		// RVA: 0x000A68F0 File Offset: 0x000A4AF0
		private void method_25()
		{
			this.class538_0 = new Class538(Class885.smethod_27("play-skip", Enum112.flag_6, true), Enum115.const_7, Origins.BottomRight, Enum114.const_0, new Vector2(0f, 480f), (float)(Class115.bool_21 ? 1 : 0), true, new Color(255, 255, 255, 153));
			this.class538_0.method_61();
			this.class538_0.method_2(new EventHandler(this.method_31));
			this.class538_0.bool_1 = (this.class108_0 == null);
			this.class538_0.class746_1 = new Class746(TransformationType.Fade, 0.6f, 1f, 0, 300, Enum70.const_0);
			this.class538_0.float_3 = 0f;
			int num = this.int_24;
			if (this.int_24 == 0)
			{
				int num2 = this.int_24 = Class331.int_7;
				if (Class331.smethod_17())
				{
					num = (int)((double)this.class297_0.list_3[0].StartTime - Class331.smethod_8() * (double)((Class331.smethod_8() < 500.0) ? 8 : 4));
				}
				else
				{
					num = this.class297_0.list_3[0].StartTime - 2000;
				}
			}
			if (num - Math.Min(this.int_33, -this.int_34) > 1200 + this.class297_0.PreEmpt)
			{
				this.int_24 = num;
				this.class538_0.method_14(400, Enum70.const_0);
				this.class911_10.Add(this.class538_0);
				this.enum110_0 = Enum110.const_1;
			}
			else
			{
				this.enum110_0 = Enum110.const_2;
				this.int_24 = 0;
			}
			if (Class802.smethod_0() && (!Class802.bool_16 || Class802.int_2 != 0))
			{
				if (Class62.int_9 > 0)
				{
					this.vmethod_13();
				}
				return;
			}
			Class62.class512_0.list_1.Insert(0, new Class14(0, 256f, -500f, pButtonState.None));
			Class62.class512_0.list_1.Insert(1, new Class14(this.int_24 - 1, 256f, -500f, pButtonState.None));
		}

		// Token: 0x06001E4C RID: 7756
		// RVA: 0x000A6B04 File Offset: 0x000A4D04
		protected void method_26(int int_35)
		{
			if (this.enum110_0 != Enum110.const_6)
			{
				if (this.enum110_0 != Enum110.const_7)
				{
					Class331.smethod_83();
					Class331.bool_5 = Class876.smethod_6(Class62.class512_0.class623_0, Mods.Nightcore);
					if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.DoubleTime))
					{
						Class331.smethod_68(150);
					}
					else if (Class876.smethod_6(Class62.class512_0.class623_0, Mods.HalfTime))
					{
						Class331.smethod_68(75);
					}
					this.method_8();
					Class331.smethod_89(100, false);
					if (this.int_34 > int_35)
					{
						Class331.smethod_100(-this.int_34, false);
					}
					else
					{
						Class331.double_2 = (double)this.int_34;
						Class331.smethod_70(int_35, false, false);
					}
					this.bool_43 = true;
					return;
				}
			}
		}

		// Token: 0x06001E4D RID: 7757
		// RVA: 0x000A6BD8 File Offset: 0x000A4DD8
		private void method_27()
		{
			this.int_33 = 0;
			if (Class115.bool_25)
			{
				this.int_33 = Class115.int_28;
			}
			else if (Class802.smethod_0() && Class802.int_2 > 0)
			{
				this.int_33 = Class802.int_2 + 5;
			}
			this.int_34 = Class466.Current.int_1;
			this.int_34 = Math.Max(-this.class872_0.int_1, this.int_34);
			int num = (Class62.playModes_0 == PlayModes.OsuMania) ? 1800 : Math.Max(1800, this.class297_0.PreEmpt);
			int num2 = (this.class297_0.list_3.Count > 0) ? this.class297_0.list_3[0].StartTime : 0;
			this.int_34 = Math.Max(num - num2, this.int_34);
			if (Class466.Current.int_6 > 3 && Class331.int_1 >= 0)
			{
				Class331.smethod_48(Class331.smethod_14()[Class331.int_2].sampleSet_0, false);
			}
			if (Class466.Current.int_13 != 0)
			{
				Class723.smethod_1(string.Format(Class41.GetString(OsuString.Player_LocalBeatmapOffset), Class466.Current.int_13), 1000);
			}
			Class331.smethod_6(true);
		}

		// Token: 0x06001E4F RID: 7759
		// RVA: 0x00018DB2 File Offset: 0x00016FB2
		private void method_28(object object_0)
		{
			Class466.Current.method_51(new Delegate52(this.method_28));
			Class115.class47_0.Add(new VoidDelegate(this.method_29), false);
		}

		// Token: 0x06001E50 RID: 7760
		// RVA: 0x000A6DA8 File Offset: 0x000A4FA8
		private void method_29()
		{
			this.method_20();
			if (!Class115.bool_16 && this.class427_0.vmethod_5() && !Class62.bool_15 && !Class62.bool_16)
			{
				if (Class62.class664_0 == null)
				{
					List<Class512> list = (Class466.Current.list_0 == null || Class466.Current.list_0.Count <= 0) ? Class908.smethod_0(Class466.Current.string_3, Class62.Mode) : Class466.Current.list_0;
					if (list == null || list.Count == 0)
					{
						return;
					}
					this.class660_0 = new Class660(0, Class62.class512_0.string_2 ?? "-", Class62.Mode);
					this.class660_0.bool_1 = true;
					Class62.class664_0 = new Class664(6, this.class660_0, this.class427_0.vmethod_0(), Class802.smethod_0() || Class341.class606_53.Value);
					if (this.class427_0.vmethod_1())
					{
						Class62.class664_0.method_1(true);
					}
					Class62.class664_0.bool_2 = true;
					if (Class802.smethod_0() || Class341.class606_53)
					{
						Class62.class664_0.method_3(string.Format(Class41.GetString(OsuString.Player_ToggleScoreboard), Class795.smethod_3(Bindings.ToggleScoreboard).ToString()));
					}
					Class62.class664_0.bool_1 = true;
					Class62.class664_0.class911_0.float_0 = 0f;
					Class660 class = null;
					foreach (Class512 current in list)
					{
						Class62.class664_0.int_2++;
						bool flag = current.string_2 == this.class660_0.string_0;
						if (this.rankingType_0 != RankingType.Local && flag)
						{
							if ((Class466.Current.class512_0 == null || Class466.Current.class512_0.int_3 != current.int_3 || this.rankingType_0 != RankingType.Top) && (Class802.class512_0 == null || !(current.dateTime_0 == Class802.class512_0.dateTime_0)))
							{
								class = new Class660(current.int_1, current, Class62.Mode);
							}
						}
						else
						{
							Class660 class660_ = new Class660(current.int_1, current, Class62.Mode);
							Class62.class664_0.Add(class660_);
						}
					}
					if (Class466.Current.class512_0 != null && (!Class802.smethod_0() || Class802.class512_0.string_2 != Class115.class861_0.Name) && class == null)
					{
						class = new Class660(Class466.Current.class512_0.int_1, Class466.Current.class512_0, Class62.Mode);
					}
					if (class != null)
					{
						class.bool_1 = true;
						class.bool_4 = false;
						Class62.class664_0.Add(class);
						class.class531_0.color_0 = new Color(255, 69, 0, 150);
					}
					foreach (Class660 current2 in Class62.class664_0.list_0)
					{
						if (current2.class512_0 != null && current2.class512_0.class861_0 != null && Class111.list_4.Contains(current2.class512_0.class861_0.int_1))
						{
							current2.class531_0.color_0 = new Color(255, 97, 175, 180);
						}
					}
					Class62.class664_0.vmethod_1(false);
					Class62.class664_0.method_2(false);
				}
				return;
			}
		}

		// Token: 0x06001E28 RID: 7720
		// RVA: 0x00018C65 File Offset: 0x00016E65
		private void method_3()
		{
			Class62.enum43_0 = Enum43.flag_0;
		}

		// Token: 0x06001E51 RID: 7761
		// RVA: 0x000A7158 File Offset: 0x000A5358
		private void method_30()
		{
			double num = (double)this.class297_0.list_3[0].StartTime;
			double num2 = Class331.smethod_21(num);
			double num3 = Class331.smethod_22(num, true);
			if (num3 < 0.0)
			{
				num3 = Class331.smethod_22(0.0, true);
			}
			double num4 = num2 - 5.0;
			double num5 = num3;
			if (num5 <= 333.0)
			{
				num5 *= 2.0;
			}
			if (Class466.Current.enum65_0 == Enum65.const_3)
			{
				num5 /= 2.0;
			}
			else if (Class466.Current.enum65_0 == Enum65.const_2)
			{
				num5 *= 2.0;
			}
			num -= num5 * (double)Class466.Current.int_8;
			if (num4 >= num)
			{
				while (num4 > num - num5)
				{
					num4 -= num5;
				}
			}
			int num6 = 1;
			while (num4 < num - num5 / (double)num6)
			{
				num4 += num5;
				double num7 = (double)((float)(num4 - num2)) / num3 % 4.0;
				if (num7 > 1.5 && num7 < 3.5)
				{
					num6 = 2;
				}
				else
				{
					num6 = 1;
				}
			}
			num4 -= num5;
			bool flag = num4 - 4.0 * num5 > 0.0;
			int num8 = (int)num4;
			int num9 = (int)num5;
			bool flag2 = !Class876.smethod_5(Mods.Target);
			if (!Class876.smethod_5(Mods.Target) && (!flag || Class466.Current.enum65_0 == Enum65.const_0 || !this.class427_0.vmethod_10()))
			{
				if (this.class297_0.list_3[0].StartTime > 6000)
				{
					int num10 = this.class297_0.list_3[0].StartTime - this.class297_0.PreEmpt;
					for (int i = 0; i < 1300; i += 200)
					{
						Class62.Class419 class = new Class62.Class419();
						class.class746_0 = new Class746(TransformationType.Fade, 0f, 1f, num10 - 1000 + i, num10 - 1000 + i, Enum70.const_0);
						class.class746_1 = new Class746(TransformationType.Fade, 1f, 0f, num10 - 900 + i, num10 - 900 + i, Enum70.const_0);
						this.list_0.ForEach(new Action<Class531>(class.method_0));
					}
				}
				return;
			}
			this.int_24 = num8 - 6 * num9;
			this.int_25 = num8 - 3 * num9;
			Class531 class2 = new Class531(Class885.Load("ready", Enum112.flag_6), Enum115.const_9, Origins.Centre, Enum114.const_1, new Vector2(0f, 0f), 0.91f, false, Color.get_TransparentWhite(), null);
			if (flag2)
			{
				Class331.list_1.Add(new Class338((int)((double)num8 - 5.9 * (double)num9), Class331.smethod_37("readys", false, true, Enum112.flag_6), 100, false));
			}
			class2.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, num8 - 6 * num9, num8 - 5 * num9, Enum70.const_0));
			if (!Class885.smethod_25())
			{
				class2.class26_0.Add(new Class746(TransformationType.Scale, 3f, 1f, num8 - 6 * num9, num8 - 5 * num9, Enum70.const_0));
				class2.class26_0.Add(new Class746(TransformationType.Rotation, -0.4f, 0f, num8 - 6 * num9, num8 - 5 * num9, Enum70.const_0));
			}
			class2.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, num8 - 4 * num9, num8 - 3 * num9, Enum70.const_0));
			class2.class26_0.Add(new Class746(TransformationType.Scale, 1f, Class885.smethod_25() ? 1.2f : 1.8f, num8 - 4 * num9, num8 - 3 * num9, Enum70.const_0));
			Class531 class3 = new Class531(Class885.Load("count3", Enum112.flag_6), Class885.smethod_25() ? Enum115.const_9 : Enum115.const_5, Class885.smethod_25() ? Origins.Centre : Origins.TopLeft, Enum114.const_1, new Vector2(0f, 0f), 0.9f, false, Color.get_TransparentWhite(), null);
			Class531 class4 = new Class531(Class885.Load("count2", Enum112.flag_6), Class885.smethod_25() ? Enum115.const_9 : Enum115.const_7, Class885.smethod_25() ? Origins.Centre : Origins.TopRight, Enum114.const_1, new Vector2(0f, 0f), 0.89f, false, Color.get_TransparentWhite(), null);
			Class531 class5 = new Class531(Class885.Load("count1", Enum112.flag_6), Enum115.const_9, Origins.Centre, Enum114.const_1, new Vector2(0f, 0f), 0.88f, false, Color.get_TransparentWhite(), null);
			Class531 class6 = new Class531(Class885.Load("go", Enum112.flag_6), Enum115.const_9, Origins.Centre, Enum114.const_1, new Vector2(0f, 0f), 0.91f, false, Color.get_TransparentWhite(), null);
			if (flag2)
			{
				if (Class331.smethod_37("count3s", false, true, Enum112.flag_6) != -1)
				{
					Class331.list_1.Add(new Class338(num8 - 3 * num9, Class331.smethod_37("count3s", false, true, Enum112.flag_6), 100, false));
					Class331.list_1.Add(new Class338(num8 - 2 * num9, Class331.smethod_37("count2s", false, true, Enum112.flag_6), 100, false));
					Class331.list_1.Add(new Class338(num8 - num9, Class331.smethod_37("count1s", false, true, Enum112.flag_6), 100, false));
					Class331.list_1.Add(new Class338(num8, Class331.smethod_37("gos", false, true, Enum112.flag_6), 100, false));
				}
				else
				{
					Class331.list_1.Add(new Class338(num8 - 3 * num9, Class331.smethod_37("count", false, true, Enum112.flag_6), 100, false));
					Class331.list_1.Add(new Class338(num8 - 2 * num9, Class331.smethod_37("count", false, true, Enum112.flag_6), 100, false));
					Class331.list_1.Add(new Class338(num8 - num9, Class331.smethod_37("count", false, true, Enum112.flag_6), 100, false));
					Class331.list_1.Add(new Class338(num8, Class331.smethod_37("count", false, true, Enum112.flag_6), 100, false));
				}
			}
			class3.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, num8 - (int)(3.2 * (double)num9), num8 - 3 * num9, Enum70.const_0));
			class4.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, num8 - (int)(2.2 * (double)num9), num8 - 2 * num9, Enum70.const_0));
			class5.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, num8 - (int)(1.2 * (double)num9), num8 - num9, Enum70.const_0));
			if (Class885.smethod_25())
			{
				class3.class26_0.Add(new Class746(TransformationType.Scale, 1.4f, 1f, num8 - (int)(3.2 * (double)num9), num8 - 3 * num9, Enum70.const_0));
				class4.class26_0.Add(new Class746(TransformationType.Scale, 1.4f, 1f, num8 - (int)(2.2 * (double)num9), num8 - 2 * num9, Enum70.const_0));
				class5.class26_0.Add(new Class746(TransformationType.Scale, 1.4f, 1f, num8 - (int)(1.2 * (double)num9), num8 - num9, Enum70.const_0));
				class3.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, num8 - (int)(2.2 * (double)num9), num8 - (int)(2.0 * (double)num9), Enum70.const_0));
				class4.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, num8 - (int)(1.2 * (double)num9), num8 - (int)(1.0 * (double)num9), Enum70.const_0));
				class5.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, num8 - (int)(0.2 * (double)num9), num8 - (int)(0.0 * (double)num9), Enum70.const_0));
			}
			else
			{
				class3.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, num8 - (int)(0.2 * (double)num9), num8 + (int)(0.2 * (double)num9), Enum70.const_0));
				class4.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, num8 - (int)(0.2 * (double)num9), num8 + (int)(0.2 * (double)num9), Enum70.const_0));
				class5.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, num8 - (int)(0.2 * (double)num9), num8 + (int)(0.2 * (double)num9), Enum70.const_0));
			}
			if (Class885.smethod_25())
			{
				class6.class26_0.Add(new Class746(TransformationType.Scale, 1.4f, 1f, num8 - (int)(0.6 * (double)num9), num8 + (int)(0.2 * (double)num9), Enum70.const_0));
				class6.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, num8 - (int)(0.2 * (double)num9), num8, Enum70.const_0));
			}
			else
			{
				class6.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, num8 - (int)(0.6 * (double)num9), num8, Enum70.const_0));
				Class746 class7 = new Class746(TransformationType.Rotation, -4f, 0f, num8 - (int)(0.6 * (double)num9), num8 + (int)(0.2 * (double)num9), Enum70.const_0);
				class7.enum70_0 = Enum70.const_1;
				class6.class26_0.Add(class7);
				class7 = new Class746(TransformationType.Scale, 0.2f, 1f, num8 - (int)(0.6 * (double)num9), num8 + (int)(0.2 * (double)num9), Enum70.const_0);
				class7.enum70_0 = Enum70.const_1;
				class6.class26_0.Add(class7);
			}
			class6.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, num8 + (int)(0.3 * (double)num9), num8 + num9, Enum70.const_0));
			class2.bool_9 = true;
			class3.bool_9 = true;
			class4.bool_9 = true;
			class5.bool_9 = true;
			class6.bool_9 = true;
			this.class911_4.Add(class2);
			this.class911_4.Add(class3);
			this.class911_4.Add(class4);
			this.class911_4.Add(class5);
			this.class911_4.Add(class6);
		}

		// Token: 0x06001E53 RID: 7763
		// RVA: 0x00018DE1 File Offset: 0x00016FE1
		private void method_31(object sender, EventArgs e)
		{
			Class115.class47_0.method_1(new VoidDelegate(this.method_76), Class562.smethod_1(0, 300), false);
		}

		// Token: 0x06001E56 RID: 7766
		// RVA: 0x000A7D90 File Offset: 0x000A5F90
		protected bool method_32()
		{
			int num = (this.int_34 < 10000) ? (-this.int_34) : 0;
			return !(this is Class64) && Class331.int_7 < num - (Class802.smethod_0() ? 50 : 0) && this.int_24 > 6000;
		}

		// Token: 0x06001E57 RID: 7767
		// RVA: 0x000A7DE4 File Offset: 0x000A5FE4
		protected void method_33(Class296 class296_0)
		{
			lock (Class858.object_0)
			{
				string string_ = string.Empty;
				Class512 class = Class802.class512_0;
				bool flag;
				string_ = ((flag = (Class802.smethod_0() && class != null)) ? (Class802.bool_16 ? Class858.class861_0.Name : class.string_2) : Class341.class605_20.Value);
				if (Class62.smethod_1())
				{
					Class62.class512_0 = new Class513(class296_0, string_);
				}
				else
				{
					Class62.class512_0 = Class721.Create(Class62.playModes_0, string_, class296_0);
				}
				Class62.class512_0.bool_0 &= Class62.bool_18;
				Class62.class512_0.class623_0 = (flag ? class.class623_0 : Class876.class623_0);
				if (flag && !Class802.bool_16)
				{
					Class62.class512_0.list_1 = Class802.class512_0.list_1;
				}
				if (Class802.smethod_0() || Class115.bool_25)
				{
					Class62.class512_0.bool_0 = false;
				}
				Class62.class512_0.method_5();
				this.class427_0.method_4();
				if (this.class297_0 != null)
				{
					this.class297_0.int_11 = 0;
					this.class297_0.int_12 = 0;
				}
				this.method_8();
				Class62.bool_10 = true;
			}
		}

		// Token: 0x06001E58 RID: 7768
		// RVA: 0x000A7F48 File Offset: 0x000A6148
		private string method_34()
		{
			if (this.class427_0.class413_0 == null)
			{
				return string.Empty;
			}
			return string.Concat(new object[]
			{
				(int)(Class62.class512_0.int_3 * 2 + this.class427_0.class413_0.vmethod_0() + Class331.smethod_67() * 5 + (Class115.bool_25 ? 2 : 3) + Class62.class512_0.class623_0),
				"9",
				(int)(Class466.Current.method_12() * 4.0 * (double)(this.class427_0.class413_0.vmethod_0() % 11 + 1)),
				(int)Math.Sqrt(Math.Pow((double)this.class427_0.class413_0.vmethod_0(), 4.0) % 89.0),
				(!Class802.smethod_0() || Class115.bool_25) ? "5" : "9"
			});
		}

		// Token: 0x06001E5B RID: 7771
		// RVA: 0x000A8428 File Offset: 0x000A6628
		internal void method_35(bool bool_48)
		{
			if (this.bool_39 == bool_48)
			{
				return;
			}
			this.bool_39 = bool_48;
			this.class297_0.class911_0.float_1 = (bool_48 ? 0.5f : 0f);
			this.class297_0.class911_0.float_2 = (bool_48 ? 0.65f : 0f);
			this.class297_0.vmethod_0(bool_48);
			Class885.smethod_10(this.class297_0);
			Class297.smethod_14();
		}

		// Token: 0x06001E5C RID: 7772
		// RVA: 0x00018E2B File Offset: 0x0001702B
		private void method_36(int int_35)
		{
			if (Class331.int_7 > this.int_28 + 5000 && !Class802.smethod_0() && !Class115.bool_25)
			{
				return;
			}
			Class435.smethod_1(int_35);
			((Class300)this.class297_0).method_38(Class331.int_7);
		}

		// Token: 0x06001E5D RID: 7773
		// RVA: 0x000A84A0 File Offset: 0x000A66A0
		private void method_37(int int_35)
		{
			if (Class62.bool_11 || Class62.bool_29)
			{
				Class723.smethod_1(Class41.GetString(OsuString.Player_OffsetChangeUnpause), 1000);
				return;
			}
			if (Class331.int_7 > this.int_28 + 10000 && !Class115.bool_25 && !Class872.bool_1)
			{
				return;
			}
			if (Class115.int_1 - this.int_29 < 150)
			{
				return;
			}
			this.int_29 = Class115.int_1;
			Class466.Current.int_13 = Math.Max(-1000, Math.Min(1000, Class466.Current.int_13 + int_35));
			Class723.smethod_1(string.Format(Class41.GetString(OsuString.Player_LocalBeatmapOffsetSet), Class466.Current.int_13), 1000);
		}

		// Token: 0x06001E5E RID: 7774
		// RVA: 0x000A856C File Offset: 0x000A676C
		private bool method_38(int int_35)
		{
			Action<Class531> action = null;
			if (int_35 != 0)
			{
				if (this.int_32 < 0)
				{
					this.int_32 = ((int_35 == -1) ? 2 : (Class62.bool_6 ? 1 : 0));
					Class731 class731_ = Class885.Load("play-warningarrow", Enum112.flag_5);
					Class531 class = new Class531(class731_, Enum115.const_9, Origins.Centre, Enum114.const_0, new Vector2(-170f, this.list_1[this.int_32 + 2].vector2_1.Y), 1f, true, Class115.bool_32 ? new Color(0, 114, 255) : Color.get_White(), null);
					class.float_2 = 0.8f;
					class.method_15(300);
					class.class26_0.Add(new Class746(TransformationType.MovementX, class.vector2_1.X - 170f, class.vector2_1.X, Class115.int_1, Class115.int_1 + 300, Enum70.const_2));
					Class746 class2 = new Class746(TransformationType.MovementX, class.vector2_1.X, class.vector2_1.X - 45f, Class115.int_1 + 300, Class115.int_1 + 600, Enum70.const_1);
					class2.bool_0 = true;
					class2.int_2 = 300;
					class2.byte_0 = 101;
					class.class26_0.Add(class2);
					class2 = new Class746(TransformationType.MovementX, class.vector2_1.X - 45f, class.vector2_1.X, Class115.int_1 + 600, Class115.int_1 + 900, Enum70.const_2);
					class2.bool_0 = true;
					class2.int_2 = 300;
					class2.byte_0 = 102;
					class.class26_0.Add(class2);
					this.class911_9.Add(class);
					this.list_3.Add(class);
					class = new Class531(class731_, Enum115.const_9, Origins.Centre, Enum114.const_0, new Vector2(170f, this.list_1[this.int_32 + 2].vector2_1.Y), 1f, true, Class115.bool_32 ? new Color(0, 114, 255) : Color.get_White(), null);
					class.method_45(true);
					class.float_2 = 0.8f;
					class.method_15(300);
					class.class26_0.Add(new Class746(TransformationType.MovementX, class.vector2_1.X + 170f, class.vector2_1.X, Class115.int_1, Class115.int_1 + 300, Enum70.const_2));
					class2 = new Class746(TransformationType.MovementX, class.vector2_1.X, class.vector2_1.X + 45f, Class115.int_1 + 300, Class115.int_1 + 600, Enum70.const_1);
					class2.bool_0 = true;
					class2.int_2 = 300;
					class2.byte_0 = 201;
					class.class26_0.Add(class2);
					class2 = new Class746(TransformationType.MovementX, class.vector2_1.X + 45f, class.vector2_1.X, Class115.int_1 + 600, Class115.int_1 + 900, Enum70.const_2);
					class2.bool_0 = true;
					class2.int_2 = 300;
					class2.byte_0 = 202;
					class.class26_0.Add(class2);
					this.class911_9.Add(class);
					this.list_3.Add(class);
				}
				else
				{
					Class331.smethod_36(null, "menuclick", 1f, false);
					this.int_32 = (Class62.bool_6 ? ((this.int_32 + int_35 + 1) % 2 + 1) : ((this.int_32 + int_35 + 3) % 3));
					List<Class531> arg_3F9_0 = this.list_3;
					if (action == null)
					{
						action = new Action<Class531>(this.method_77);
					}
					arg_3F9_0.ForEach(action);
				}
				return true;
			}
			switch (this.int_32)
			{
			case 0:
				this.method_40(null, null);
				return true;
			case 1:
				this.method_42(null, null);
				return true;
			case 2:
				this.method_41(null, null);
				return true;
			default:
				this.vmethod_16();
				return true;
			}
		}

		// Token: 0x06001E5F RID: 7775
		// RVA: 0x000A8978 File Offset: 0x000A6B78
		internal void method_39()
		{
			bool flag = Class876.smethod_6(Class62.class512_0.class623_0, Mods.DoubleTime);
			bool flag2 = Class876.smethod_6(Class62.class512_0.class623_0, Mods.HalfTime);
			switch (Class802.enum99_0)
			{
			case Enum99.const_0:
				if (flag)
				{
					Class802.enum99_0 = Enum99.const_1;
				}
				else
				{
					Class802.enum99_0 = Enum99.const_2;
				}
				break;
			case Enum99.const_1:
				Class802.enum99_0 = Enum99.const_0;
				break;
			case Enum99.const_2:
				Class802.enum99_0 = Enum99.const_1;
				break;
			}
			switch (Class802.enum99_0)
			{
			case Enum99.const_0:
				if (flag)
				{
					Class331.smethod_68(150);
					return;
				}
				if (flag2)
				{
					Class331.smethod_68(75);
					return;
				}
				Class331.smethod_68(100);
				return;
			case Enum99.const_1:
				if (flag)
				{
					Class331.smethod_68(75);
					return;
				}
				Class331.smethod_68(50);
				return;
			case Enum99.const_2:
				if (flag2)
				{
					Class331.smethod_68(150);
					return;
				}
				Class331.smethod_68(200);
				return;
			default:
				return;
			}
		}

		// Token: 0x06001E29 RID: 7721
		// RVA: 0x00018C6D File Offset: 0x00016E6D
		internal void method_4()
		{
			Class62.enum43_0 |= Enum43.flag_8;
		}

		// Token: 0x06001E61 RID: 7777
		// RVA: 0x00018E6A File Offset: 0x0001706A
		private void method_40(object sender, EventArgs e)
		{
			Class331.smethod_60("menuback", 1f, Enum112.flag_5);
			this.vmethod_16();
		}

		// Token: 0x06001E62 RID: 7778
		// RVA: 0x00018E83 File Offset: 0x00017083
		private void method_41(object sender, EventArgs e)
		{
			Class331.smethod_60("menuback", 1f, Enum112.flag_5);
			if (Class115.bool_25)
			{
				Class115.smethod_70(OsuModes.Edit, false);
				return;
			}
			Class115.smethod_70(OsuModes.SelectPlay, false);
		}

		// Token: 0x06001E63 RID: 7779
		// RVA: 0x00018EAC File Offset: 0x000170AC
		private void method_42(object sender, EventArgs e)
		{
			Class331.smethod_59("menuhit", 100, Enum112.flag_5);
			Class62.smethod_4(false);
		}

		// Token: 0x06001E65 RID: 7781
		// RVA: 0x00018F01 File Offset: 0x00017101
		private void method_43(object sender, EventArgs e)
		{
			if (this.list_1[0].bool_3)
			{
				return;
			}
			((Class531)sender).bool_1 = false;
			this.bool_28 = true;
		}

		// Token: 0x06001E67 RID: 7783
		// RVA: 0x000A980C File Offset: 0x000A7A0C
		internal void method_44()
		{
			if (!this.bool_3)
			{
				this.method_11();
				Environment.Exit(-1);
			}
			if (Class62.class512_0 == null)
			{
				return;
			}
			if (!Class802.smethod_0())
			{
				Class62.class512_0.int_5 = Class62.int_12;
				Class62.class512_0.dateTime_0 = DateTime.Now;
			}
			if (Class341.class606_24)
			{
				return;
			}
			if (this.bool_31 && this.method_1() && this.method_2())
			{
				if (this.class427_0.bool_0)
				{
					this.class427_0.int_3++;
					this.method_9(false);
				}
				this.method_6();
				if (!Class62.class512_0.bool_2)
				{
					if (!Class62.bool_6)
					{
						Class62.class512_0.bool_3 = true;
					}
					Class62.class512_0.int_2 = ((Class62.int_8 == 0) ? Class331.int_7 : Class62.int_8);
				}
				else if (Class115.class522_0 != null)
				{
					Class115.class522_0.method_6();
				}
				Class62.class512_0.method_11();
				if (Class466.Current.bool_13)
				{
					Class466.Current.bool_13 = false;
					return;
				}
			}
			else
			{
				Class62.class512_0.bool_0 = false;
			}
		}

		// Token: 0x06001E69 RID: 7785
		// RVA: 0x000A9934 File Offset: 0x000A7B34
		internal bool method_45()
		{
			VoidDelegate voidDelegate = null;
			if (this.class523_0.bool_0)
			{
				return false;
			}
			this.class523_0.vmethod_0();
			if (this.class108_0 != null)
			{
				this.class108_0.imethod_2();
			}
			if (this.class335_0 != null)
			{
				if (this.float_2 > (this.bool_44 ? 0f : 0.4f))
				{
					this.float_2 -= (float)(0.02 * Class115.double_0);
				}
				this.class335_0.vmethod_1(Math.Max(0f, this.float_2));
			}
			if (this.bool_44 && Class62.bool_47)
			{
				Class115.smethod_71(Class115.osuModes_1, true);
				this.bool_44 = false;
				return true;
			}
			if (this.bool_44 && this.vmethod_17() && (this.class335_0 == null || this.float_2 <= 0f))
			{
				if (Class62.class911_1 != null && Class62.class911_1.list_2.Count != 0)
				{
					List<Class530> arg_11B_0 = Class62.class911_1.list_2;
					if (Class62.predicate_2 == null)
					{
						Class62.predicate_2 = new Predicate<Class530>(Class62.smethod_20);
					}
					if (!arg_11B_0.TrueForAll(Class62.predicate_2))
					{
						goto IL_1DC;
					}
				}
				if (this.class108_0 == null || !this.class108_0.bool_1 || this is Class64)
				{
					if (this.class108_0 != null)
					{
						this.class108_0.method_15(new bool?(true));
					}
					this.class523_0.method_1();
					Class62.bool_40 = true;
					Class331.smethod_90();
					if (this.int_34 > this.int_33)
					{
						Class331.smethod_100(-this.int_34, true);
					}
					this.class872_0.method_20();
					Class47 arg_1D5_0 = Class115.class47_0;
					if (voidDelegate == null)
					{
						voidDelegate = new VoidDelegate(this.method_78);
					}
					arg_1D5_0.method_1(voidDelegate, (Class115.bool_25 || Class802.smethod_0() || this is Class64) ? 0 : Class562.smethod_1(0, 600), false);
					goto IL_214;
				}
			}
			IL_1DC:
			Class331.int_7 = -this.int_34;
			Class331.int_8 = -this.int_34;
			if (this.class658_0 != null)
			{
				this.class658_0.vmethod_0((float)((this.int_34 != 0) ? -1 : 0));
			}
			IL_214:
			if (this.class872_0 != null)
			{
				this.class872_0.method_6();
			}
			return true;
		}

		// Token: 0x06001E6B RID: 7787
		// RVA: 0x000AA9E0 File Offset: 0x000A8BE0
		private void method_46()
		{
			float num;
			if (Class331.int_7 > this.class297_0.list_3[0].StartTime)
			{
				num = ((float)Class331.int_7 - (float)this.class297_0.list_3[0].StartTime) / (float)(this.int_27 - this.class297_0.list_3[0].StartTime);
			}
			else
			{
				num = -1f + ((float)Class331.int_7 + (float)this.int_34) / (float)(this.int_34 + this.class297_0.list_3[0].StartTime);
			}
			if (this.class658_0 != null)
			{
				this.class658_0.vmethod_0(Class778.smethod_2(num, -2f, 1f));
			}
		}

		// Token: 0x06001E6C RID: 7788
		// RVA: 0x000AAAA8 File Offset: 0x000A8CA8
		private void method_47(Struct13 struct13_0)
		{
			Class512 class = Class721.Create(Class62.Mode, struct13_0, Class62.class512_0.string_2);
			class.list_0 = Class62.class512_0.list_0;
			class.list_1 = Class62.class512_0.list_1;
			this.class427_0.class512_0 = (Class62.class512_0 = class);
			this.class427_0.class410_0.vmethod_10(Class62.class512_0.double_1);
			this.class427_0.class413_0.vmethod_1((int)Class62.class512_0.ushort_6);
			this.class427_0.class666_0.int_1 = Class62.class512_0.int_3;
		}

		// Token: 0x06001E6D RID: 7789
		// RVA: 0x00018F2A File Offset: 0x0001712A
		private bool method_48()
		{
			return this.queue_0.Count == 0 || Class331.int_7 <= this.queue_0.Peek() || Class466.Current.int_6 < 8;
		}

		// Token: 0x06001E6F RID: 7791
		// RVA: 0x000AAB4C File Offset: 0x000A8D4C
		private void method_49()
		{
			if (Class872.bool_1)
			{
				this.int_22 = Class331.int_7;
				if (Class115.bool_13 && this.int_17++ > 1)
				{
					this.int_17 = 0;
					this.method_59(null);
				}
				if (this.queue_0.Count > 0)
				{
					while (this.queue_0.Peek() < Class331.int_7)
					{
						this.queue_0.Dequeue();
						if (this.queue_0.Count == 0)
						{
							break;
						}
					}
				}
			}
			if (this.int_22 >= 0 && this.class297_0.list_4.FindIndex(new Predicate<Class304>(this.method_79)) >= 0)
			{
				this.int_22 = -1;
			}
		}

		// Token: 0x06001E2A RID: 7722
		// RVA: 0x00018C7F File Offset: 0x00016E7F
		internal void method_5()
		{
			Class62.enum43_0 |= Enum43.flag_9;
		}

		// Token: 0x06001E70 RID: 7792
		// RVA: 0x000AAC08 File Offset: 0x000A8E08
		private void method_50()
		{
			if (Class331.float_1 > 101f)
			{
				if (Class115.bool_13)
				{
					Bass.BASS_ChannelSetAttribute(Class331.class335_0.method_0(), 1, Class331.float_1);
					if (this.class297_0.class911_0.float_0 > 0f)
					{
						this.class297_0.class911_0.float_0 = Math.Max(0f, this.class297_0.class911_0.float_0 - 0.007f);
					}
					this.class427_0.vmethod_21(this.class297_0.class911_0.float_0);
					foreach (Class304 current in this.class297_0.list_4)
					{
						foreach (Class531 current2 in current.list_1)
						{
							List<Class746> arg_ED_0 = current2.class26_0;
							if (Class62.predicate_5 == null)
							{
								Class62.predicate_5 = new Predicate<Class746>(Class62.smethod_23);
							}
							arg_ED_0.RemoveAll(Class62.predicate_5);
							current2.bool_0 = true;
							current2.vector2_1 = new Vector2(current2.vector2_1.X, (current2.vector2_1.Y < 0f) ? (current2.vector2_1.Y * 0.6f) : (current2.vector2_1.Y * 1.01f));
							if (current2.float_1 == 0f)
							{
								current2.float_1 += Class562.smethod_6(-0.02f, 0.02f);
							}
							else if (current2.float_1 > 0f)
							{
								current2.float_1 += 0.01f;
							}
							else
							{
								current2.float_1 -= 0.01f;
							}
						}
					}
					Class331.float_1 -= 300f;
					return;
				}
			}
			else if (Class115.enum113_0 == Enum113.const_2)
			{
				this.vmethod_23();
			}
		}

		// Token: 0x06001E71 RID: 7793
		// RVA: 0x000AAE44 File Offset: 0x000A9044
		private void method_51()
		{
			if (Class885.class547_0.list_1.Count != 0)
			{
				if (this.int_30 != this.class427_0.class413_0.vmethod_0())
				{
					int num = Class885.class547_0.list_1.BinarySearch(this.class427_0.class413_0.vmethod_0());
					if (num >= 0)
					{
						Class331.smethod_59("comboburst-" + num, 100, Enum112.flag_6);
					}
					this.int_30 = this.class427_0.class413_0.vmethod_0();
					return;
				}
			}
		}

		// Token: 0x06001E72 RID: 7794
		// RVA: 0x00018F97 File Offset: 0x00017197
		protected void method_52()
		{
			this.class427_0.class666_0.vmethod_0(this.vmethod_19().int_3);
			this.class427_0.class666_0.method_1(this.vmethod_19().vmethod_1() * 100f);
		}

		// Token: 0x06001E74 RID: 7796
		// RVA: 0x000AAED0 File Offset: 0x000A90D0
		internal void method_53()
		{
			Class304 arg_38_1;
			if (!Class62.bool_6)
			{
				List<Class304> arg_30_0 = this.class297_0.list_4;
				if (Class62.predicate_6 == null)
				{
					Class62.predicate_6 = new Predicate<Class304>(Class62.smethod_24);
				}
				arg_38_1 = arg_30_0.Find(Class62.predicate_6);
			}
			else
			{
				arg_38_1 = null;
			}
			this.class304_0 = arg_38_1;
			Class62.bool_8 = (this.class304_0 != null && this.class304_0.IsType(HitObjectType.Slider));
			Class62.bool_9 = (this.class304_0 != null && this.class304_0.IsType(HitObjectType.Spinner));
		}

		// Token: 0x06001E75 RID: 7797
		// RVA: 0x000AAF54 File Offset: 0x000A9154
		protected internal void method_54()
		{
			if (this.bool_25)
			{
				return;
			}
			if (!this.bool_30 && !Class62.bool_13 && ((Class331.int_7 > 0 && Class331.enum100_0 == Enum100.const_0) || Class331.int_7 > this.int_27 + 200))
			{
				Class62.class512_0.list_4.Add(this.class427_0.vmethod_3());
				List<bool> arg_85_0 = Class62.class512_0.list_4;
				if (Class62.predicate_7 == null)
				{
					Class62.predicate_7 = new Predicate<bool>(Class62.smethod_25);
				}
				int arg_C0_0 = arg_85_0.FindAll(Class62.predicate_7).Count;
				List<bool> arg_B6_0 = Class62.class512_0.list_4;
				if (Class62.predicate_8 == null)
				{
					Class62.predicate_8 = new Predicate<bool>(Class62.smethod_26);
				}
				this.method_62(arg_C0_0 > arg_B6_0.FindAll(Class62.predicate_8).Count);
				if (Class802.smethod_0() || Class115.bool_25 || !this.vmethod_21() || this.class427_0.vmethod_9())
				{
					this.vmethod_20();
					return;
				}
				this.class427_0.class410_0.vmethod_10(0.0);
			}
		}

		// Token: 0x06001E78 RID: 7800
		// RVA: 0x000AB070 File Offset: 0x000A9270
		private void method_55()
		{
			if (this.bool_14 || !this.class427_0.vmethod_11())
			{
				return;
			}
			Class62.class512_0.list_4.Add(Class62.bool_10);
			int length = Class872.class705_0.Length;
			int num = (length / 2 > 2880) ? (Class872.class705_0.int_2 + length / 2) : (Class872.class705_0.int_0 - 2880);
			if (Class62.bool_10)
			{
				Class331.list_1.Add(new Class338(num + 20, Class331.smethod_37("sectionpass", false, true, Enum112.flag_6), 100, false));
				this.class531_3.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, num + 20, num + 20, Enum70.const_0));
				this.class531_3.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, num + 100, num + 100, Enum70.const_0));
				this.class531_3.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, num + 160, num + 160, Enum70.const_0));
				this.class531_3.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, num + 230, num + 230, Enum70.const_0));
				this.class531_3.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, num + 280, num + 280, Enum70.const_0));
				this.class531_3.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, num + 1280, num + 1480, Enum70.const_0));
				return;
			}
			Class331.list_1.Add(new Class338(num + 130, Class331.smethod_37("sectionfail", false, true, Enum112.flag_6), 100, false));
			this.class531_2.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, num + 130, num + 130, Enum70.const_0));
			this.class531_2.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, num + 230, num + 230, Enum70.const_0));
			this.class531_2.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, num + 280, num + 280, Enum70.const_0));
			this.class531_2.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, num + 1280, num + 1480, Enum70.const_0));
		}

		// Token: 0x06001E79 RID: 7801
		// RVA: 0x000AB304 File Offset: 0x000A9504
		private void method_56()
		{
			if (!this.bool_14 && !Class876.smethod_5(Mods.Cinema))
			{
				this.vmethod_19().bool_2 = true;
				Rankings rankings = this.vmethod_19().vmethod_4();
				this.vmethod_19().bool_2 = false;
				if (rankings < Rankings.F)
				{
					Vector2 vector2_ = (Class341.class605_2 != ProgressBarTypes.Pie) ? this.class427_0.class666_0.vector2_0 : (this.class658_0.vector2_0 + new Vector2(28f, 0f));
					Class531 class = new Class531(Class885.Load("ranking-" + rankings + "-small", Enum112.flag_6), Enum115.const_7, Origins.Centre, Enum114.const_1, vector2_, 0.9f, false, Color.get_TransparentWhite(), null);
					if (Class341.class606_75.Value)
					{
						class.object_0 = "rankletter";
						class.float_2 = 0.5f;
						class.bool_7 = true;
						class.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class331.int_7 + 400, Class331.int_7 + 1600, Enum70.const_1));
						class.class26_0.Add(new Class746(TransformationType.Scale, 0.8f, 1.3f, Class331.int_7 + 400, Class331.int_7 + 1600, Enum70.const_1));
						this.class911_3.Add(class);
						class = new Class531(Class885.Load("ranking-" + rankings + "-small", Enum112.flag_6), Enum115.const_7, Origins.Centre, Enum114.const_1, vector2_, 0.9f, false, Color.get_TransparentWhite(), null);
						class.object_0 = "rankletter";
						class.float_2 = 0.8f;
					}
					class.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, Class331.int_7 + 400, Class331.int_7 + 700, Enum70.const_1));
					class.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class872.class705_0.int_0 - 1000, Class872.class705_0.int_0 - 700, Enum70.const_2));
					this.class911_8.Add(class);
				}
				return;
			}
		}

		// Token: 0x06001E7A RID: 7802
		// RVA: 0x000AB524 File Offset: 0x000A9724
		private void method_57()
		{
			if (this.class531_0 != null)
			{
				using (List<Class530>.Enumerator enumerator = this.class911_2.method_11("pausecursor").GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class531 class = (Class531)enumerator.Current;
						class.bool_0 = false;
						class.method_16(40, Enum70.const_0);
					}
				}
				this.class531_0 = null;
				this.class531_1 = null;
			}
			Class62.bool_29 = false;
			this.bool_28 = false;
		}

		// Token: 0x06001E7B RID: 7803
		// RVA: 0x000AB5B4 File Offset: 0x000A97B4
		private void method_58()
		{
			if (Class115.bool_13)
			{
				this.vector2_0 = Class802.class531_0.vector2_1 / Class115.float_4 - this.vector2_1;
				this.vector2_1 = Class802.class531_0.vector2_1 / Class115.float_4;
			}
		}

		// Token: 0x06001E80 RID: 7808
		// RVA: 0x000AB780 File Offset: 0x000A9980
		private void method_59(Color? nullable_0)
		{
			if (Class331.smethod_79() || this.vmethod_5())
			{
				return;
			}
			if (Class62.bool_12 && !this.class427_0.vmethod_51())
			{
				return;
			}
			if (!nullable_0.HasValue)
			{
				nullable_0 = new Color?(this.color_0);
			}
			int num = Class115.int_1 + Class562.smethod_1(300, 1000);
			Class531 class = new Class531(this.class731_0, Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(Class802.class531_0.vector2_1.X, Class802.class531_0.vector2_1.Y) / Class115.float_4, 0.05f, false, nullable_0.Value, null);
			Class746 class2 = new Class746(TransformationType.Scale, 1f, Class562.smethod_5(Class341.class606_46 ? 1.1f : 2f), Class115.int_1, num, Enum70.const_0);
			Class746 item = new Class746(TransformationType.Fade, Class802.class531_0.float_3, 0f, Class115.int_1, num, Enum70.const_0);
			Class746 class3 = new Class746(TransformationType.Rotation, (float)(Class562.smethod_2() * 4.0 - 2.0), Class562.smethod_6(-2f, 2f), Class115.int_1, num, Enum70.const_0);
			Vector2 vector = this.vector2_0 * 4f;
			if ((Class62.bool_15 || Class62.bool_16 || Class62.bool_38) && !Class872.bool_1)
			{
				if (!Class62.bool_8 && !Class62.bool_9)
				{
					vector..ctor((float)Class562.smethod_1(-500, 500), (float)Class562.smethod_1(-500, 500));
				}
			}
			else if (Class802.buttonState_0 == 1 && Class802.buttonState_5 == 1)
			{
				vector += new Vector2((float)Class562.smethod_1(-460, 460), (float)Class562.smethod_1(-160, 160));
			}
			else if (Class802.buttonState_0 == 1)
			{
				vector += new Vector2((float)Class562.smethod_1(-460, 0), (float)Class562.smethod_1(-40, 40));
			}
			else if (Class802.buttonState_5 == 1)
			{
				vector += new Vector2((float)Class562.smethod_1(0, 460), (float)Class562.smethod_1(-40, 40));
			}
			class2.enum70_0 = Enum70.const_1;
			class3.enum70_0 = Enum70.const_1;
			class.class26_0.Add(class2);
			class.class26_0.Add(item);
			class.class26_0.Add(class3);
			class.bool_7 = true;
			this.class911_3.Add(class);
			Class115.class729_0.Add(class, new Vector2?(vector), false);
		}

		// Token: 0x06001E2B RID: 7723
		// RVA: 0x000A4348 File Offset: 0x000A2548
		private void method_6()
		{
			try
			{
				if (!Class115.smethod_24())
				{
					Class62.enum43_0 |= Enum43.flag_4;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001E81 RID: 7809
		// RVA: 0x00019011 File Offset: 0x00017211
		internal void method_60(Enum61 enum61_0)
		{
			this.method_62((enum61_0 & Enum61.flag_8) > Enum61.flag_5);
		}

		// Token: 0x06001E82 RID: 7810
		// RVA: 0x0001901F File Offset: 0x0001721F
		internal void method_61()
		{
			this.method_62(this.class427_0.vmethod_3());
		}

		// Token: 0x06001E83 RID: 7811
		// RVA: 0x000ABA18 File Offset: 0x000A9C18
		internal void method_62(bool bool_48)
		{
			if (this.bool_14)
			{
				return;
			}
			if (bool_48 == Class62.bool_10)
			{
				return;
			}
			this.class427_0.vmethod_48(bool_48);
			Class62.bool_10 = bool_48;
			if (Class62.playModes_0 != PlayModes.Taiko && this.class872_0.bool_12)
			{
				this.class872_0.method_8(0.2f);
			}
		}

		// Token: 0x06001E84 RID: 7812
		// RVA: 0x000ABA70 File Offset: 0x000A9C70
		internal void method_63()
		{
			if (Class858.bool_1 && !Class802.smethod_0())
			{
				Class858.smethod_3(Enum0.const_3, null);
			}
			if (Class115.bool_25)
			{
				Class802.smethod_1(false);
				Class115.smethod_70(OsuModes.Edit, false);
				return;
			}
			if (Class62.class512_0.vmethod_4() == Rankings.F && !(this is Class64))
			{
				Class723.smethod_4(Class41.GetString(OsuString.Player_ErrorDuringScoreCalculation));
				Class115.smethod_70(OsuModes.SelectPlay, false);
				return;
			}
			this.vmethod_26(false);
		}

		// Token: 0x06001E8B RID: 7819
		// RVA: 0x000ABE90 File Offset: 0x000AA090
		private void method_64()
		{
			if (Class341.class606_4)
			{
				if (Class62.bool_11)
				{
					Class733.bool_1 = false;
					return;
				}
				if (this.class427_0.class410_0 != null && this.class427_0.class410_0.method_2() < 40.0 && !Class115.bool_25 && !Class62.bool_15 && !Class62.bool_16 && this.class427_0.vmethod_13() && this.vmethod_30() && Class115.enum113_0 == Enum113.const_2)
				{
					Class733.bool_1 = true;
					if (!Class62.bool_6)
					{
						Class733.float_1 = 0.0001f;
						Class733.float_0 = 1f;
						Class733.float_2 = (float)Math.Max(0.0, (40.0 - this.class427_0.class410_0.method_0()) / 160.0);
						Class733.bool_2 = false;
						Class733.bool_0 = false;
						return;
					}
					if (Class115.bool_13)
					{
						Class733.float_1 = 0.006f * ((Class331.float_0 - Class331.float_1) / Class331.float_0);
						Class733.float_2 = (float)Math.Max(0.0, (40.0 - this.class427_0.class410_0.method_0()) / 160.0);
						Class733.bool_2 = false;
						Class733.bool_0 = false;
						Class733.float_0 = Math.Min(1f, Class733.float_0 + 0.01f);
						return;
					}
				}
				else
				{
					if (Class62.bool_9 && !Class733.bool_1)
					{
						Class328 class = (Class328)this.class304_0;
						Class733.float_1 = 0.008f;
						Class733.float_2 = 0f;
						Class733.bool_1 = true;
						Class733.bool_2 = false;
						Class733.bool_0 = true;
						Class733.float_0 = Math.Min(0.5f, Math.Max(0f, (float)(Math.Abs(class.int_8) - class.int_9 + 1) / ((float)class.int_9 * 0.6f)));
						return;
					}
					if (this.float_1 > 0f)
					{
						Class733.float_1 = 0.0001f;
						Class733.float_2 = 0f;
						Class733.bool_1 = true;
						Class733.bool_2 = false;
						Class733.bool_0 = true;
						Class733.float_0 = this.float_1 * 0.2f;
						this.float_1 -= (float)(0.05 * Class115.double_0);
						return;
					}
					Class733.bool_1 = false;
				}
			}
		}

		// Token: 0x06001E8C RID: 7820
		// RVA: 0x000AC0FC File Offset: 0x000AA2FC
		internal void method_65(float float_3)
		{
			if (float_3 != 0f && !Class876.smethod_5(Mods.Cinema))
			{
				if (this.bool_19)
				{
					if (Class885.class547_0.list_1.Count == 0)
					{
						int num = Class331.smethod_37("comboburst-" + this.int_16, false, true, Enum112.flag_6);
						if (num == -1)
						{
							if (this.int_16 > 0)
							{
								num = Class331.smethod_37("comboburst-0", false, true, Enum112.flag_6);
								this.int_16 = 1;
							}
							else
							{
								num = Class331.smethod_37("comboburst", false, true, Enum112.flag_6);
							}
						}
						else
						{
							this.int_16++;
						}
						Class331.smethod_61(num, 100, 0f, false, 1f);
					}
					this.int_18 = this.class427_0.class413_0.vmethod_0();
					this.bool_19 = false;
					if (Class872.int_2 != 100)
					{
						this.class872_0.method_8(Class341.class606_12 ? 0.8f : 0.4f);
					}
					this.float_1 = 1f;
					this.class427_0.vmethod_44();
				}
				if (Class341.class606_13)
				{
					this.class734_0.Draw(float_3, this.class427_0.class413_0.vmethod_0());
				}
				return;
			}
		}

		// Token: 0x06001E8D RID: 7821
		// RVA: 0x000AC23C File Offset: 0x000AA43C
		public void method_66(Delegate55 delegate55_1)
		{
			Delegate55 delegate = this.delegate55_0;
			Delegate55 delegate2;
			do
			{
				delegate2 = delegate;
				Delegate55 value = (Delegate55)Delegate.Combine(delegate2, delegate55_1);
				delegate = Interlocked.CompareExchange<Delegate55>(ref this.delegate55_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06001E8E RID: 7822
		// RVA: 0x000AC274 File Offset: 0x000AA474
		public void method_67(Delegate55 delegate55_1)
		{
			Delegate55 delegate = this.delegate55_0;
			Delegate55 delegate2;
			do
			{
				delegate2 = delegate;
				Delegate55 value = (Delegate55)Delegate.Remove(delegate2, delegate55_1);
				delegate = Interlocked.CompareExchange<Delegate55>(ref this.delegate55_0, value, delegate2);
			}
			while (delegate != delegate2);
		}

		// Token: 0x06001E92 RID: 7826
		// RVA: 0x000AC3FC File Offset: 0x000AA5FC
		internal void method_68(Class304 class304_2, int? nullable_0)
		{
			if (Class62.class512_0.list_2 != null)
			{
				if (nullable_0.HasValue)
				{
					Class62.class512_0.list_2.Add(nullable_0.Value);
				}
				else
				{
					Class62.class512_0.list_2.Add(Class331.int_7 - class304_2.StartTime);
				}
			}
			if (this.class427_0.class103_0 != null)
			{
				this.class427_0.class103_0.vmethod_2(class304_2, nullable_0);
			}
		}

		// Token: 0x06001E93 RID: 7827
		// RVA: 0x0001905C File Offset: 0x0001725C
		internal void method_69(int int_35)
		{
			if (Class62.class512_0.list_3 != null)
			{
				Class62.class512_0.list_3.Add(int_35);
			}
		}

		// Token: 0x06001E2C RID: 7724
		// RVA: 0x000A4380 File Offset: 0x000A2580
		private void method_7()
		{
			if (Class802.smethod_0() || this.enum110_0 != Enum110.const_2 || Class62.bool_11 || Class872.bool_1 || Class62.bool_38)
			{
				return;
			}
			if (this.bool_2 || Class62.bool_9 || (!Class876.smethod_6(Class62.class512_0.class623_0, Mods.Flashlight) && !Class876.smethod_5(Mods.Flashlight)))
			{
				return;
			}
			if (this.class427_0.class413_0.vmethod_0() < 200)
			{
				return;
			}
			this.int_5--;
			if (this.class427_0.class531_0 != null && this.class427_0.class531_0.float_3 < 1f)
			{
				this.method_4();
			}
			if (this.int_5 > 0)
			{
				return;
			}
			Vector2 vector = Class802.vector2_0;
			switch (Class62.Mode)
			{
			case PlayModes.Taiko:
				vector = new Vector2(550f + Class115.smethod_45(), 190f) * Class115.float_1;
				break;
			case PlayModes.CatchTheBeat:
				vector = new Vector2(320f + Class115.smethod_45(), 60f) * Class115.float_1;
				break;
			case PlayModes.OsuMania:
				vector = new Vector2(320f + Class115.smethod_45(), 400f) * Class115.float_1;
				break;
			default:
			{
				vector = Class802.vector2_0;
				float num = vector.X - 240f * Class115.float_4;
				float num2 = vector.X + 240f * Class115.float_4;
				if (num < (float)Class115.int_26)
				{
					vector.X = num2;
				}
				else if (num2 > (float)(Class115.int_22 - Class115.int_26))
				{
					vector.X = num;
				}
				else
				{
					vector.X = num;
				}
				vector.Y = Math.Min(Math.Max(110f * Class115.float_4, vector.Y), (float)(Class115.int_23 - 10));
				break;
			}
			}
			Color[] array = Class115.smethod_41(vector, 5);
			if (array != null)
			{
				int num3 = 0;
				for (int i = 0; i < 5; i++)
				{
					if (array[i].get_R() > 10 || array[i].get_G() > 10 || array[i].get_B() > 10)
					{
						num3++;
					}
				}
				if (num3 >= 3)
				{
					if (Class62.voidDelegate_0 == null)
					{
						Class62.voidDelegate_0 = new VoidDelegate(Class62.smethod_10);
					}
					Class115.smethod_87(Class62.voidDelegate_0);
					this.method_4();
				}
			}
			this.bool_2 = true;
		}

		// Token: 0x06001E94 RID: 7828
		// RVA: 0x000AC470 File Offset: 0x000AA670
		private bool method_70(object object_0, EventArgs eventArgs_0)
		{
			if (Class115.enum113_0 == Enum113.const_0)
			{
				return false;
			}
			if (Class62.bool_6 || Class62.bool_11 || Class62.bool_29 || Class62.bool_13)
			{
				return false;
			}
			if (!Class800.bool_1 && !Class62.bool_15 && Class62.Mode != PlayModes.Taiko)
			{
				return false;
			}
			if (Class62.bool_15 && object_0 == null && Class62.Mode != PlayModes.Taiko)
			{
				return false;
			}
			if (Class62.bool_24)
			{
				return false;
			}
			Vector2 vector = Class802.smethod_0() ? Class802.vector2_1 : Class115.smethod_58(Class802.vector2_0);
			Class304 class;
			if (Class62.bool_16)
			{
				class = this.class297_0.method_18(vector.X, vector.Y, true, 100f);
			}
			else
			{
				class = this.class297_0.method_17(vector.X, vector.Y, true);
			}
			if (class != null)
			{
				this.bool_32 = true;
				switch (this.class427_0.vmethod_47(class))
				{
				case Enum111.const_1:
					class.vmethod_21();
					break;
				case Enum111.const_2:
					if (class.IsType(HitObjectType.Normal))
					{
						Enum61 enum = this.class297_0.vmethod_10(class);
						this.bool_21 = true;
						if (enum > Enum61.flag_5)
						{
							if (Class62.bool_15 || Class62.bool_38 || Class62.bool_16)
							{
								for (int i = 0; i < ((!Class341.class606_46) ? 6 : 5); i++)
								{
									this.method_59(new Color?(class.Colour));
								}
							}
							this.method_68(class, null);
							this.vmethod_31(class);
						}
					}
					else if (class.IsType(HitObjectType.Slider))
					{
						Class321 class2 = class as Class321;
						if (!class2.vmethod_25())
						{
							if (class2.vmethod_26() > Enum61.flag_5)
							{
								this.class304_0 = class;
								this.class427_0.vmethod_41(Enum61.flag_12, class);
								this.bool_21 = true;
								this.method_68(class, null);
								if (Class62.bool_15 || Class62.bool_16)
								{
									for (int j = 0; j < 6; j++)
									{
										this.method_59(new Color?(class.Colour));
									}
								}
							}
							else
							{
								this.class427_0.vmethod_41(Enum61.flag_2, class);
							}
						}
					}
					break;
				}
			}
			if (this.delegate55_0 != null)
			{
				this.delegate55_0(class);
			}
			return true;
		}

		// Token: 0x06001E95 RID: 7829
		// RVA: 0x0001907A File Offset: 0x0001727A
		private bool method_71(object object_0, EventArgs eventArgs_0)
		{
			if (Class115.enum113_0 == Enum113.const_0)
			{
				return false;
			}
			if (Class800.smethod_5() == 1 && Class115.osuModes_1 == OsuModes.Play && !(this is Class64) && !Class341.class606_44 && !Class802.smethod_0())
			{
				this.vmethod_16();
				return true;
			}
			return false;
		}

		// Token: 0x06001E97 RID: 7831
		// RVA: 0x000AC6B0 File Offset: 0x000AA8B0
		private void method_72()
		{
			if ((!Class802.smethod_0() || (Class802.bool_16 && Class802.int_2 == 0)) && Class331.enum100_0 == Enum100.const_1 && !Class62.bool_6 && !Class62.bool_11 && !(this is Class63))
			{
				pButtonState pButtonState = Class800.smethod_38(Class802.bool_3, Class802.bool_5, Class802.bool_18, Class802.bool_20, Class570.smethod_9(Class795.smethod_3(Bindings.OsuSmoke)));
				Vector2 vector = this.class427_0.vmethod_6();
				if (Class802.bool_11 && Class802.pButtonState_0 == pButtonState)
				{
					pButtonState pButtonState2 = pButtonState;
					if (Class802.bool_4)
					{
						pButtonState &= ~pButtonState.Left1;
					}
					if (Class802.bool_6)
					{
						pButtonState &= ~pButtonState.Left2;
					}
					if (Class802.bool_4)
					{
						pButtonState &= ~pButtonState.Right1;
					}
					if (Class802.bool_21)
					{
						pButtonState &= ~pButtonState.Right2;
					}
					if (pButtonState != pButtonState2)
					{
						Class14 class = new Class14(Class331.int_7 - 1, vector.X, vector.Y, pButtonState);
						Class62.class512_0.list_1.Add(class);
						Class858.smethod_1(class);
					}
				}
				Class14 class2;
				if (Class62.Mode == PlayModes.OsuMania)
				{
					class2 = new Class14(Class331.int_7, (float)Class802.smethod_17(), (float)Class435.int_0, pButtonState.None);
				}
				else
				{
					class2 = new Class14(Class331.int_7, vector.X, vector.Y, pButtonState);
				}
				bool flag = (Class62.bool_9 && Class115.bool_13) || this.bool_21 || Class802.pButtonState_0 != pButtonState;
				if (this.class427_0.class413_0.vmethod_0() != this.class427_0.class413_0.int_1)
				{
					this.class427_0.class413_0.int_1 = this.class427_0.class413_0.vmethod_0();
					flag = true;
				}
				flag |= this.class427_0.vmethod_40();
				Class802.pButtonState_0 = pButtonState;
				if (Class115.bool_13 || flag)
				{
					Class858.smethod_1(class2);
					Class62.class512_0.list_1.Add(class2);
					if (this.bool_21)
					{
						this.bool_21 = false;
					}
				}
				return;
			}
		}

		// Token: 0x06001E98 RID: 7832
		// RVA: 0x000AC89C File Offset: 0x000AAA9C
		private void method_73(Enum61 enum61_0, string string_1, Class304 class304_2)
		{
			this.class304_1 = class304_2;
			this.class427_0.vmethod_41(enum61_0, class304_2);
			if ((enum61_0 & Enum61.flag_39) > Enum61.flag_5 && this.class297_0.class304_0.double_0 > 0.0)
			{
				Class62.class512_0.list_0.Add(new Vector2((float)Class331.int_7, (float)Math.Min(1.0, this.class427_0.class410_0.method_2() / this.class297_0.class304_0.double_0)));
			}
			this.method_51();
		}

		// Token: 0x06001EA3 RID: 7843
		// RVA: 0x00019125 File Offset: 0x00017325
		[CompilerGenerated]
		private void method_74()
		{
			if (this.bool_31 && this.class427_0.class413_0.vmethod_0() > 0 && this.class427_0.class413_0.vmethod_0() % 100 == 0)
			{
				Class115.class522_0.method_6();
			}
		}

		// Token: 0x06001EA4 RID: 7844
		// RVA: 0x00019162 File Offset: 0x00017362
		[CompilerGenerated]
		private void method_75(Class530 class530_0)
		{
			class530_0.method_16((this.bool_36 || this.class531_4.float_3 > 0f) ? 500 : 0, Enum70.const_0);
		}

		// Token: 0x06001EA5 RID: 7845
		// RVA: 0x0001918D File Offset: 0x0001738D
		[CompilerGenerated]
		private void method_76()
		{
			this.vmethod_13();
		}

		// Token: 0x06001EA6 RID: 7846
		// RVA: 0x000ACB64 File Offset: 0x000AAD64
		[CompilerGenerated]
		private void method_77(Class531 class531_5)
		{
			List<Class746> arg_23_0 = class531_5.class26_0;
			if (Class62.predicate_1 == null)
			{
				Class62.predicate_1 = new Predicate<Class746>(Class62.smethod_17);
			}
			arg_23_0.RemoveAll(Class62.predicate_1);
			class531_5.class26_0.Add(new Class746(TransformationType.MovementY, class531_5.vector2_1.Y, this.list_1[this.int_32 + 2].vector2_1.Y, Class115.int_1, Class115.int_1 + 100, Enum70.const_1));
		}

		// Token: 0x06001EAB RID: 7851
		// RVA: 0x000191C9 File Offset: 0x000173C9
		[CompilerGenerated]
		private void method_78()
		{
			if (this.class335_0 != null && Class331.class335_0 != this.class335_0 && this.class335_0.vmethod_2())
			{
				this.class335_0.Dispose();
			}
			this.method_26(this.int_33);
		}

		// Token: 0x06001EAE RID: 7854
		// RVA: 0x00019238 File Offset: 0x00017438
		[CompilerGenerated]
		private bool method_79(Class304 class304_2)
		{
			return class304_2.StartTime <= Class331.int_7 && class304_2.StartTime >= this.int_22;
		}

		// Token: 0x06001E2D RID: 7725
		// RVA: 0x000A4600 File Offset: 0x000A2800
		internal void method_8()
		{
			this.string_0 = this.method_34();
			if (!string.IsNullOrEmpty(this.string_0))
			{
				long.TryParse(this.string_0, out this.long_1);
				this.long_1 *= 2L;
			}
		}

		// Token: 0x06001E2E RID: 7726
		// RVA: 0x000A4650 File Offset: 0x000A2850
		internal void method_9(bool bool_48)
		{
			this.int_6++;
			string text = this.method_34();
			if (Class115.int_1 - this.int_7 > 30000)
			{
				this.int_7 = Class115.int_1;
			}
			if (Class62.class512_0.class623_0 != Class876.class623_0)
			{
				Class62.enum43_0 |= Enum43.flag_2;
			}
			if (this.int_6 % 20 == 0 && Class115.smethod_86())
			{
				Class62.enum43_0 |= Enum43.flag_10;
			}
			if (bool_48 || text != this.string_0 || long.Parse(text) * 2L != this.long_1 || this.class427_0.class413_0.vmethod_0() > Class62.class512_0.int_0)
			{
				if (this.enum110_0 == Enum110.const_0)
				{
					return;
				}
				Class62.enum43_0 |= Enum43.flag_4;
				if (this.enum110_0 == Enum110.const_7 || Class802.smethod_0() || Class115.bool_25)
				{
					return;
				}
				Class62.class512_0.bool_0 = false;
				this.bool_3 = false;
				if (!this.bool_4)
				{
					Class115.class47_0.method_1(new VoidDelegate(this.method_11), Class562.smethod_1(1000, 6000), false);
					Class47 arg_165_0 = Class115.class47_0;
					if (Class62.voidDelegate_1 == null)
					{
						Class62.voidDelegate_1 = new VoidDelegate(Class62.smethod_11);
					}
					arg_165_0.method_1(Class62.voidDelegate_1, Class562.smethod_1(1000, 6000), false);
					Class47 arg_19C_0 = Class115.class47_0;
					if (Class62.voidDelegate_2 == null)
					{
						Class62.voidDelegate_2 = new VoidDelegate(Class62.smethod_12);
					}
					arg_19C_0.method_1(Class62.voidDelegate_2, Class562.smethod_1(10000, 15000), false);
					this.bool_4 = true;
				}
			}
		}

		// Token: 0x06001E30 RID: 7728
		// RVA: 0x000A49E8 File Offset: 0x000A2BE8
		internal static void smethod_0(Vector2 vector2_3, Vector2 vector2_4)
		{
			if (!Class802.smethod_0() && !Class115.bool_25 && Class114.bool_0)
			{
				float num;
				if ((vector2_3 == Vector2.get_Zero() && vector2_4 != Vector2.get_Zero()) || (vector2_3 != Vector2.get_Zero() && vector2_4 == Vector2.get_Zero()))
				{
					num = 3.14159274f;
				}
				else if (vector2_3 == Vector2.get_Zero() && vector2_4 == Vector2.get_Zero())
				{
					num = 0f;
				}
				else
				{
					num = (float)(Math.Abs(Math.Atan2((double)vector2_4.Y, (double)vector2_4.X)) - Math.Abs(Math.Atan2((double)vector2_3.Y, (double)vector2_3.X)));
					num = Math.Abs(num);
				}
				float num2 = (float)Math.Pow(0.99, Class115.double_0);
				Class62.float_0 = num2 * Class62.float_0 + (1f - num2) * num;
				if ((double)Class62.float_0 > 2.3561944901923448)
				{
					if (Class62.bool_12 && !Class62.bool_5)
					{
						Class62.enum43_0 |= Enum43.flag_12;
						return;
					}
					Class62.bool_5 = true;
				}
				return;
			}
		}

		// Token: 0x06001E38 RID: 7736
		// RVA: 0x00018CF9 File Offset: 0x00016EF9
		internal static bool smethod_1()
		{
			return (Class876.smethod_5(Mods.Target) && !Class802.smethod_0()) || (Class802.class512_0 != null && Class876.smethod_6(Class802.class512_0.class623_0, Mods.Target));
		}

		// Token: 0x06001E9C RID: 7836
		// RVA: 0x000190B9 File Offset: 0x000172B9
		[CompilerGenerated]
		private static void smethod_10()
		{
			Class62.class512_0.memoryStream_0 = Class115.smethod_42();
		}

		// Token: 0x06001E9D RID: 7837
		// RVA: 0x000190CA File Offset: 0x000172CA
		[CompilerGenerated]
		private static void smethod_11()
		{
			throw new MethodAccessException();
		}

		// Token: 0x06001E9E RID: 7838
		// RVA: 0x000190D1 File Offset: 0x000172D1
		[CompilerGenerated]
		private static void smethod_12()
		{
			Environment.Exit(-1);
		}

		// Token: 0x06001E9F RID: 7839
		// RVA: 0x000190D9 File Offset: 0x000172D9
		[CompilerGenerated]
		private static void smethod_13()
		{
			Class62.enum43_0 |= Enum43.flag_1;
		}

		// Token: 0x06001EA0 RID: 7840
		// RVA: 0x000190E7 File Offset: 0x000172E7
		[CompilerGenerated]
		private static void smethod_14()
		{
			Class115.process_0 = Process.GetProcesses();
		}

		// Token: 0x06001EA1 RID: 7841
		// RVA: 0x000190F3 File Offset: 0x000172F3
		[CompilerGenerated]
		private static void smethod_15(Class296 class296_0)
		{
			class296_0.list_0.Clear();
			class296_0.class512_0 = null;
		}

		// Token: 0x06001EA2 RID: 7842
		// RVA: 0x00019107 File Offset: 0x00017307
		[CompilerGenerated]
		private static bool smethod_16(Class531 class531_5)
		{
			return class531_5.object_0 == "back" || class531_5.object_0 == "retry";
		}

		// Token: 0x06001EA7 RID: 7847
		// RVA: 0x00019196 File Offset: 0x00017396
		[CompilerGenerated]
		private static bool smethod_17(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.MovementY;
		}

		// Token: 0x06001EA8 RID: 7848
		// RVA: 0x000191A5 File Offset: 0x000173A5
		[CompilerGenerated]
		private static void smethod_18(Class531 class531_5)
		{
			class531_5.method_16(200, Enum70.const_0);
			class531_5.bool_0 = false;
		}

		// Token: 0x06001EA9 RID: 7849
		// RVA: 0x000ACBE8 File Offset: 0x000AADE8
		[CompilerGenerated]
		private static void smethod_19(Class530 class530_0)
		{
			Class531 class = class530_0 as Class531;
			if (class != null && class.vmethod_6() != null)
			{
				class.vmethod_6().bool_4 = true;
			}
		}

		// Token: 0x06001E39 RID: 7737
		// RVA: 0x00018D32 File Offset: 0x00016F32
		public static bool smethod_2()
		{
			return Class62.class62_0 != null && Class62.class62_0.int_24 > 0 && Class331.int_7 < Class62.class62_0.int_24;
		}

		// Token: 0x06001EAA RID: 7850
		// RVA: 0x000191BA File Offset: 0x000173BA
		[CompilerGenerated]
		private static bool smethod_20(Class530 class530_0)
		{
			return class530_0.float_3 == 0f;
		}

		// Token: 0x06001EAC RID: 7852
		// RVA: 0x00019204 File Offset: 0x00017404
		[CompilerGenerated]
		private static bool smethod_21(Struct13 struct13_0)
		{
			return struct13_0.int_1 < Class331.int_7;
		}

		// Token: 0x06001EAD RID: 7853
		// RVA: 0x00019214 File Offset: 0x00017414
		[CompilerGenerated]
		private static bool smethod_22(Class304 class304_2)
		{
			return !class304_2.bool_0 && Math.Abs(class304_2.EndTime - Class331.int_7) < 500;
		}

		// Token: 0x06001EAF RID: 7855
		// RVA: 0x0001925A File Offset: 0x0001745A
		[CompilerGenerated]
		private static bool smethod_23(Class746 class746_0)
		{
			return class746_0.transformationType_0 == TransformationType.Movement;
		}

		// Token: 0x06001EB0 RID: 7856
		// RVA: 0x00019265 File Offset: 0x00017465
		[CompilerGenerated]
		private static bool smethod_24(Class304 class304_2)
		{
			return class304_2.StartTime != class304_2.EndTime && class304_2.vmethod_16() <= Class331.int_7 && (class304_2.vmethod_15() >= Class331.int_7 || !class304_2.bool_0);
		}

		// Token: 0x06001EB1 RID: 7857
		// RVA: 0x00007F8B File Offset: 0x0000618B
		[CompilerGenerated]
		private static bool smethod_25(bool bool_48)
		{
			return bool_48;
		}

		// Token: 0x06001EB2 RID: 7858
		// RVA: 0x0001929C File Offset: 0x0001749C
		[CompilerGenerated]
		private static bool smethod_26(bool bool_48)
		{
			return !bool_48;
		}

		// Token: 0x06001EB3 RID: 7859
		// RVA: 0x000192A2 File Offset: 0x000174A2
		[CompilerGenerated]
		private static bool smethod_27(Class304 class304_2)
		{
			return class304_2 is Class328 && !class304_2.bool_0 && class304_2.list_1[0].bool_3;
		}

		// Token: 0x06001E54 RID: 7764
		// RVA: 0x00018E05 File Offset: 0x00017005
		internal static void smethod_3()
		{
			if (Class62.class62_0 == null)
			{
				return;
			}
			Class62.int_9 = Math.Max(0, Class62.int_9) + 1;
		}

		// Token: 0x06001E64 RID: 7780
		// RVA: 0x00018EC2 File Offset: 0x000170C2
		internal static void smethod_4(bool bool_48)
		{
			Class62.bool_27 = true;
			if (Class62.class62_0 != null)
			{
				Class62.class62_0.enum110_0 = Enum110.const_6;
			}
			if (bool_48)
			{
				Class62.smethod_3();
				Class115.smethod_70(OsuModes.Play, true);
				Class115.double_8 = 100.0;
				return;
			}
			Class115.smethod_70(OsuModes.Play, true);
		}

		// Token: 0x06001E8F RID: 7823
		// RVA: 0x000AC2AC File Offset: 0x000AA4AC
		public static void smethod_5()
		{
			if (Class115.osuModes_1 == OsuModes.Play && Class62.class62_0 != null)
			{
				try
				{
					Class62.bool_12 = (!Class62.bool_24 && Class62.class62_0.enum110_0 == Enum110.const_2 && Class62.class62_0.class297_0 != null && Class62.class62_0.class297_0.int_14 > 0 && Class331.int_7 >= Class62.class62_0.class297_0.vmethod_3().vmethod_16() - Class62.class62_0.class297_0.PreEmpt && Class331.int_7 <= Class62.class62_0.class297_0.vmethod_4().vmethod_15() + Class62.class62_0.class297_0.HitWindow50 && !Class62.bool_6 && !Class62.bool_11 && !Class872.bool_1 && !Class62.class512_0.bool_2 && (!Class802.smethod_0() || Class802.bool_12 || Class62.bool_16));
				}
				catch
				{
					Class62.bool_12 = false;
				}
				return;
			}
			Class62.bool_12 = false;
		}

		// Token: 0x06001E90 RID: 7824
		// RVA: 0x000AC3C4 File Offset: 0x000AA5C4
		private static void smethod_6(bool bool_48)
		{
			if (!Class62.bool_41)
			{
				return;
			}
			try
			{
				Class62.smethod_7(bool_48);
			}
			catch
			{
				Class62.bool_41 = false;
			}
		}

		// Token: 0x06001E91 RID: 7825
		// RVA: 0x0001904E File Offset: 0x0001724E
		private static void smethod_7(bool bool_48)
		{
			GCSettings.LatencyMode = (bool_48 ? GCLatencyMode.LowLatency : GCLatencyMode.Interactive);
		}

		// Token: 0x06001E99 RID: 7833
		// RVA: 0x000AC934 File Offset: 0x000AAB34
		public static Struct13 smethod_8()
		{
			Struct13 result;
			try
			{
				Class62 class = Class62.class62_0;
				if (class == null)
				{
					result = default(Struct13);
				}
				else
				{
					Struct13 struct = new Struct13
					{
						ushort_1 = Class62.class512_0.ushort_1,
						ushort_0 = Class62.class512_0.ushort_0,
						ushort_2 = Class62.class512_0.ushort_2,
						ushort_3 = Class62.class512_0.ushort_3,
						ushort_4 = Class62.class512_0.ushort_4,
						ushort_5 = Class62.class512_0.ushort_5,
						int_2 = Class62.class512_0.int_3,
						ushort_7 = (ushort)Class62.class512_0.int_0,
						ushort_6 = (ushort)class.class427_0.class413_0.vmethod_0(),
						bool_1 = Class62.class512_0.bool_4,
						int_0 = ((class.class427_0.class410_0 != null) ? ((int)class.class427_0.class410_0.method_2()) : 0),
						int_1 = Class331.int_7,
						bool_0 = !Class62.bool_6
					};
					result = struct;
				}
			}
			catch
			{
				result = default(Struct13);
			}
			return result;
		}

		// Token: 0x06001E9A RID: 7834
		// RVA: 0x000ACA88 File Offset: 0x000AAC88
		public static void smethod_9()
		{
			Struct13 struct13_ = Class858.struct13_0;
			Class62.class512_0.ushort_1 = struct13_.ushort_1;
			Class62.class512_0.ushort_0 = struct13_.ushort_0;
			Class62.class512_0.ushort_2 = struct13_.ushort_2;
			Class62.class512_0.ushort_3 = struct13_.ushort_3;
			Class62.class512_0.ushort_4 = struct13_.ushort_4;
			Class62.class512_0.ushort_5 = struct13_.ushort_5;
			Class62.class512_0.int_3 = struct13_.int_2;
			Class62.class512_0.double_0 = (double)struct13_.int_2;
			Class62.class512_0.int_0 = (int)struct13_.ushort_7;
			Class62.class62_0.class427_0.class413_0.method_1((int)struct13_.ushort_6);
			Class62.class512_0.bool_4 = struct13_.bool_1;
		}

		// Token: 0x06001E4A RID: 7754
		// RVA: 0x00018D90 File Offset: 0x00016F90
		protected virtual void vmethod_10()
		{
			if (!Class115.bool_25 && !Class62.bool_16 && !Class62.bool_15)
			{
				Class802.smethod_1(false);
			}
			Class858.Reset();
		}

		// Token: 0x06001E4E RID: 7758
		// RVA: 0x000A6D18 File Offset: 0x000A4F18
		protected virtual void vmethod_11()
		{
			this.rankingType_0 = Class341.class605_5;
			if (Class466.Current.submissionStatus_0 < SubmissionStatus.Ranked || this.rankingType_0 == RankingType.Local)
			{
				this.rankingType_0 = RankingType.Local;
				this.method_29();
				return;
			}
			if (Class466.Current.list_0 != null && Class466.Current.list_0.Count != 0)
			{
				this.method_29();
				return;
			}
			Class466.Current.method_48(true, false, Class341.class605_5);
			Class466.Current.method_50(new Delegate52(this.method_28));
		}

		// Token: 0x06001E52 RID: 7762
		// RVA: 0x000A7BF8 File Offset: 0x000A5DF8
		protected virtual void vmethod_12()
		{
			Class885.smethod_27("lighting", Enum112.flag_6, true);
			this.class731_0 = Class885.Load("star2", Enum112.flag_6);
			this.color_0 = Class885.class547_0.dictionary_1["StarBreakAdditive"];
			this.class427_0.vmethod_19();
		}

		// Token: 0x06001E55 RID: 7765
		// RVA: 0x000A7C48 File Offset: 0x000A5E48
		internal virtual bool vmethod_13()
		{
			if (Class115.osuModes_1 == OsuModes.Play && !Class62.bool_11 && !Class62.bool_29 && this.bool_43)
			{
				if (Class331.int_7 < this.int_24 && !this.bool_25)
				{
					if (!Class62.bool_7)
					{
						if (this.enum110_0 == Enum110.const_1)
						{
							Class115.double_8 = 80.0;
							Class115.enum113_0 = Enum113.const_1;
							Class331.smethod_60("menuhit", 1f, Enum112.flag_5);
							this.method_16();
							bool flag;
							if (!(flag = this.method_32()))
							{
								Class62.bool_7 = true;
								this.class538_0.bool_1 = false;
								this.enum110_0 = Enum110.const_2;
							}
							int num = flag ? 0 : (this.int_24 + Class562.smethod_1(-80, 90));
							Class331.smethod_96();
							Class331.smethod_70(num, false, false);
							this.int_3 = -1;
							Class858.smethod_3(Enum0.const_2, null);
							if (!flag)
							{
								this.class427_0.vmethod_42();
							}
							Class62.int_9--;
							return true;
						}
					}
					return false;
				}
				if (Class62.bool_42 && !this.bool_22)
				{
					this.bool_22 = true;
					Class331.smethod_60("menuhit", 1f, Enum112.flag_5);
					this.method_63();
					this.enum110_0 = Enum110.const_6;
				}
				return true;
			}
			return false;
		}

		// Token: 0x06001E59 RID: 7769
		// RVA: 0x00018E21 File Offset: 0x00017021
		protected virtual bool vmethod_14()
		{
			Class115.smethod_70(OsuModes.SelectPlay, false);
			return true;
		}

		// Token: 0x06001E5A RID: 7770
		// RVA: 0x000A8050 File Offset: 0x000A6250
		protected virtual bool vmethod_15(object object_0, Keys keys_0)
		{
			if (Class115.enum113_0 != Enum113.const_2)
			{
				return false;
			}
			Bindings bindings = Class795.smethod_10(keys_0);
			if (!this.class523_0.bool_0)
			{
				if (bindings != Bindings.Pause)
				{
					if (keys_0 != 27)
					{
						return false;
					}
				}
				return this.vmethod_14();
			}
			this.bool_32 = true;
			if (bindings != Bindings.Pause)
			{
				if (keys_0 != 27)
				{
					if (keys_0 == Class795.smethod_3(Bindings.Skip))
					{
						this.method_31(null, null);
						return true;
					}
					if (Class62.playModes_0 == PlayModes.OsuMania)
					{
						if ((Class570.bool_0 && keys_0 == 187) || bindings == Bindings.IncreaseSpeed)
						{
							this.method_36(1);
							return true;
						}
						if ((Class570.bool_0 && keys_0 == 189) || bindings == Bindings.DecreaseSpeed)
						{
							this.method_36(-1);
							return true;
						}
					}
					switch (bindings)
					{
					case Bindings.IncreaseSpeed:
						if (Class62.Mode == PlayModes.OsuMania)
						{
							this.method_36(1);
							return true;
						}
						break;
					case Bindings.DecreaseSpeed:
						if (Class62.playModes_0 == PlayModes.OsuMania)
						{
							this.method_36(-1);
							return true;
						}
						break;
					case Bindings.ToggleScoreboard:
						if (Class570.bool_2)
						{
							Class341.class606_75.method_1();
							Class723.smethod_1(Class41.GetString(Class341.class606_75 ? OsuString.Player_InterfaceEnabled : OsuString.Player_InterfaceDisabled), 1000);
						}
						else
						{
							if (Class62.class664_0 == null)
							{
								return false;
							}
							Class62.class664_0.bool_0 = !Class62.class664_0.bool_0;
							if (Class872.bool_1)
							{
								if (!Class62.class664_0.bool_0)
								{
									Class62.class664_0.method_3(Class41.GetString(OsuString.Player_ScoreBoardShowStatus));
								}
								else
								{
									Class62.class664_0.method_3(Class41.GetString(OsuString.Player_ScoreBoardShowStatus2));
								}
							}
							if (!Class802.smethod_0())
							{
								Class341.class606_53.Value = Class62.class664_0.bool_0;
							}
						}
						return true;
					case Bindings.IncreaseAudioOffset:
						this.method_37(Class570.bool_1 ? 1 : 5);
						return true;
					case Bindings.DecreaseAudioOffset:
						this.method_37(Class570.bool_1 ? -1 : -5);
						return true;
					}
					if (Class62.bool_11 && !Class802.smethod_0())
					{
						if (Class62.bool_6 && keys_0 == 112 && Class62.class512_0 != null)
						{
							this.method_44();
							Class802.class512_0 = Class62.class512_0;
							Class802.smethod_1(true);
							Class802.bool_17 = true;
							Class115.smethod_71(OsuModes.Play, true);
							return true;
						}
						switch (Class62.Mode)
						{
						case PlayModes.Osu:
							if (bindings != Bindings.Skip && keys_0 != 13)
							{
								if (keys_0 != 32)
								{
									if (keys_0 == 40)
									{
										return this.method_38(1);
									}
									if (keys_0 == 38)
									{
										return this.method_38(-1);
									}
									break;
								}
							}
							return this.method_38(0);
						case PlayModes.Taiko:
							if (bindings != Bindings.Skip && keys_0 != 13 && keys_0 != 32 && bindings != Bindings.TaikoInnerLeft)
							{
								if (bindings != Bindings.TaikoInnerRight)
								{
									if (keys_0 != 40)
									{
										if (bindings != Bindings.TaikoOuterRight)
										{
											if (keys_0 == 38 || bindings == Bindings.TaikoOuterLeft)
											{
												return this.method_38(-1);
											}
											break;
										}
									}
									return this.method_38(1);
								}
							}
							return this.method_38(0);
						case PlayModes.CatchTheBeat:
							if (bindings != Bindings.Skip && keys_0 != 13 && keys_0 != 32)
							{
								if (bindings != Bindings.FruitsDash)
								{
									if (keys_0 != 40)
									{
										if (bindings != Bindings.FruitsRight)
										{
											if (keys_0 == 38 || bindings == Bindings.FruitsLeft)
											{
												return this.method_38(-1);
											}
											break;
										}
									}
									return this.method_38(1);
								}
							}
							return this.method_38(0);
						case PlayModes.OsuMania:
							if (bindings != Bindings.Skip && keys_0 != 13)
							{
								if (keys_0 != 341)
								{
									if (keys_0 != 40)
									{
										if (keys_0 != 343)
										{
											if (keys_0 == 38 || keys_0 == 342)
											{
												return this.method_38(-1);
											}
											break;
										}
									}
									return this.method_38(1);
								}
							}
							return this.method_38(0);
						}
					}
					return false;
				}
			}
			if (this.bool_25)
			{
				this.method_63();
			}
			else if (!(this is Class64) && (Class802.smethod_0() || Class62.bool_6))
			{
				if (Class115.bool_25)
				{
					Class802.smethod_1(false);
					Class115.smethod_70(OsuModes.Edit, false);
				}
				else if (Class802.smethod_0())
				{
					Class858.smethod_4(true);
					this.enum110_0 = Enum110.const_7;
				}
				if (Class62.bool_11)
				{
					if (Class115.bool_25)
					{
						Class115.smethod_70(OsuModes.Edit, false);
					}
					else
					{
						Class115.smethod_70(OsuModes.SelectPlay, false);
					}
				}
				else
				{
					Class331.float_1 = 300f;
				}
			}
			else
			{
				this.vmethod_16();
			}
			return true;
		}

		// Token: 0x06001E60 RID: 7776
		// RVA: 0x000A8A58 File Offset: 0x000A6C58
		internal virtual void vmethod_16()
		{
			if (this.class911_2 == null || (Class62.bool_6 && Class62.bool_11) || !this.bool_43)
			{
				return;
			}
			if (!Class331.bool_4 && !Class115.bool_25 && !Class62.bool_6 && !Class802.smethod_0() && !Class62.bool_29 && !Class62.bool_11 && !Class872.bool_1 && this.int_19 != 0 && Class331.int_7 - this.int_19 < 1000)
			{
				Class723.smethod_4(Class41.GetString(OsuString.Player_WaitBeforePausing));
				return;
			}
			if (this.bool_25)
			{
				this.method_63();
				return;
			}
			Class62.bool_11 = !Class62.bool_11;
			if (this.class108_0 != null)
			{
				this.class108_0.method_15(new bool?(Class802.smethod_0() || Class858.class861_0 != null || !Class62.bool_11));
			}
			this.int_32 = -1;
			Class809.smethod_36(false);
			Class62.smethod_6(!Class62.bool_11);
			if (!Class62.bool_11)
			{
				Class62.bool_29 = true;
				List<Class531> arg_731_0 = this.list_3;
				if (Class62.action_1 == null)
				{
					Class62.action_1 = new Action<Class531>(Class62.smethod_18);
				}
				arg_731_0.ForEach(Class62.action_1);
				this.list_3.Clear();
				if (!Class331.bool_4 && !Class802.smethod_0() && !(this is Class63) && !this.class427_0.vmethod_8() && !Class62.bool_16 && !Class62.bool_15)
				{
					if (this.class531_0 == null)
					{
						if (!Class872.bool_1)
						{
							this.class531_0 = new Class539(Class885.Load("cursor", Enum112.flag_1), this.vector2_2, 0.99f, true, Color.get_Orange(), 20);
							this.class531_0.enum115_0 = Enum115.const_15;
							this.class531_0.bool_1 = true;
							this.class531_0.string_0 = Class41.GetString(OsuString.Player_ClickToResume);
							this.class531_0.float_2 = 1.2f;
							this.class531_0.class746_1 = new Class746(Color.get_Orange(), Color.get_White(), 0, 200);
							this.class531_0.method_2(new EventHandler(this.method_43));
							this.class531_0.object_0 = "pausecursor";
							this.class911_2.Add(this.class531_0);
							this.class531_0 = new Class531(Class885.Load("cursor", Enum112.flag_1), Enum115.const_15, Origins.Centre, Enum114.const_0, this.vector2_2, 1f, true, Color.get_Orange(), null);
							this.class531_0.object_0 = "pausecursor";
							this.class531_0.bool_7 = true;
							this.class911_2.Add(this.class531_0);
							Class746 class = new Class746(TransformationType.Scale, 1.2f, 3f, Class115.int_1, Class115.int_1 + 1000, Enum70.const_0);
							class.bool_0 = true;
							this.class531_0.class26_0.Add(class);
							class = new Class746(TransformationType.Fade, 1f, 0f, Class115.int_1, Class115.int_1 + 1000, Enum70.const_1);
							class.bool_0 = true;
							this.class531_0.class26_0.Add(class);
							this.class531_1 = new Class531(Class885.Load("unpause", Enum112.flag_1), Enum115.const_9, Origins.Centre, Enum114.const_0, Vector2.get_Zero(), 0.9f, true, Color.get_White(), null);
							this.class911_2.Add(this.class531_1);
							this.class531_1.object_0 = "pausecursor";
						}
						else
						{
							this.bool_28 = true;
						}
					}
				}
				else
				{
					Class858.smethod_3(Enum0.const_6, null);
					this.bool_28 = true;
				}
				if (this.list_1 != null)
				{
					this.list_1[0].method_16(Class115.bool_16 ? 0 : 800, Enum70.const_0);
					this.list_1[1].method_16(Class115.bool_16 ? 0 : 800, Enum70.const_0);
					this.list_1[2].method_16(Class115.bool_16 ? 0 : 300, Enum70.const_0);
					this.list_1[3].method_16(Class115.bool_16 ? 0 : 300, Enum70.const_0);
					if (this.list_1.Count > 4)
					{
						this.list_1[2].bool_1 = false;
						this.list_1[3].bool_1 = false;
						this.list_1[4].bool_1 = false;
						this.list_1[4].method_16(Class115.bool_16 ? 0 : 300, Enum70.const_0);
					}
				}
				return;
			}
			if (this.class531_0 == null)
			{
				this.vector2_2 = new Vector2(Class778.smethod_2(Class802.vector2_0.X, 1f, (float)Class115.rectangle_0.Width), Class778.smethod_2(Class802.vector2_0.Y, 1f, (float)(Class115.rectangle_0.Height - 1)));
			}
			Class858.smethod_3(Enum0.const_5, null);
			this.method_57();
			this.int_19 = Class331.int_7;
			foreach (Class304 current in this.class297_0.list_4)
			{
				current.vmethod_18();
			}
			this.class538_0.bool_1 = false;
			if (!Class331.smethod_79())
			{
				Class331.smethod_88();
			}
			if (this.list_1 == null)
			{
				this.list_1 = new List<Class531>();
				Class531 class2 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, Vector2.get_Zero(), 0.98f, true, Color.get_TransparentBlack(), null);
				class2.vector2_2 = new Vector2((float)Class115.int_22, (float)Class115.int_23);
				class2.bool_13 = false;
				this.list_1.Add(class2);
				class2 = new Class531(Class885.Load("pause-overlay.jpg", Enum112.flag_3) ?? Class885.Load("pause-overlay", Enum112.flag_6), Enum115.const_9, Origins.Centre, Enum114.const_0, Vector2.get_Zero(), 0.985f, true, Color.get_TransparentWhite(), null);
				this.list_1.Add(class2);
				if (Class802.smethod_0())
				{
					class2 = new Class531(Class885.Load("menu-osu", Enum112.flag_6), Enum115.const_9, Origins.Centre, Enum114.const_0, Vector2.get_Zero(), 0.99f, true, new Color(100, 100, 100, 0), null);
					if (Class115.bool_16)
					{
						class2.method_8(true);
					}
					class2.float_2 = 0.6f;
					this.list_1.Add(class2);
					Class62.class533_0 = new Class533(string.Empty, 20f, new Vector2((float)(Class115.smethod_43() / 2), 240f), 1f, true, Color.get_TransparentWhite());
					if (Class115.bool_16)
					{
						Class62.class533_0.method_8(true);
					}
					Class62.class533_0.origins_0 = Origins.Centre;
					this.list_1.Add(Class62.class533_0);
				}
				else
				{
					class2 = new Class531(Class885.Load("pause-continue", Enum112.flag_6), Enum115.const_9, Origins.Centre, Enum114.const_0, new Vector2(0f, -100f), 1f, true, Color.get_TransparentWhite(), null);
					class2.method_2(new EventHandler(this.method_40));
					class2.bool_1 = true;
					class2.class746_1 = new Class746(TransformationType.Scale, 1f, 1.1f, 0, 300, Enum70.const_0);
					class2.class746_1.enum70_0 = Enum70.const_1;
					this.list_1.Add(class2);
					class2 = new Class531(Class885.Load("pause-retry", Enum112.flag_6), Enum115.const_9, Origins.Centre, Enum114.const_0, new Vector2(0f, 10f), 1f, true, Color.get_TransparentWhite(), null);
					class2.object_0 = "retry";
					class2.method_2(new EventHandler(this.method_42));
					class2.bool_1 = true;
					class2.class746_1 = new Class746(TransformationType.Scale, 1f, 1.1f, 0, 300, Enum70.const_0);
					class2.class746_1.enum70_0 = Enum70.const_1;
					this.list_1.Add(class2);
					class2 = new Class531(Class885.Load("pause-back", Enum112.flag_6), Enum115.const_9, Origins.Centre, Enum114.const_0, new Vector2(0f, 120f), 1f, true, Color.get_TransparentWhite(), null);
					class2.object_0 = "back";
					class2.method_2(new EventHandler(this.method_41));
					class2.bool_1 = true;
					class2.class746_1 = new Class746(TransformationType.Scale, 1f, 1.1f, 0, 300, Enum70.const_0);
					class2.class746_1.enum70_0 = Enum70.const_1;
				}
				this.list_1.Add(class2);
				this.class911_9.Add<Class531>(this.list_1);
			}
			if (Class802.smethod_0())
			{
				this.list_1[0].class26_0.Add(new Class746(TransformationType.Fade, 0f, 0.5f, Class115.int_1, Class115.int_1 + 500, Enum70.const_0));
				this.list_1[2].method_14(500, Enum70.const_0);
				this.list_1[3].method_14(500, Enum70.const_0);
				return;
			}
			this.list_1[0].class26_0.Clear();
			if (Class885.smethod_25())
			{
				this.list_1[0].class26_0.Add(new Class746(TransformationType.Fade, this.list_1[0].float_3, 0.8f, Class115.int_1, Class115.int_1 + 300, Enum70.const_0));
			}
			else
			{
				this.list_1[0].class26_0.Add(new Class746(TransformationType.Fade, this.list_1[0].float_3, 0.95f, Class115.int_1, Class115.int_1 + 300, Enum70.const_0));
			}
			if (!Class62.bool_6)
			{
				this.list_1[1].method_14(300, Enum70.const_0);
				this.list_1[2].method_14(300, Enum70.const_0);
			}
			else
			{
				Class531 class3 = new Class531(Class885.Load("fail-background", Enum112.flag_6), Enum115.const_9, Origins.Centre, Enum114.const_0, Vector2.get_Zero(), 0.985f, true, Color.get_TransparentWhite(), null);
				class3.float_2 = 768f / (float)class3.int_5;
				class3.method_15(600);
				this.class911_9.Add(class3);
				Class533 class4 = new Class533(Class41.GetString(OsuString.Player_PressToViewReplay), 16f, new Vector2(10f, 10f), 0.987f, true, Color.get_White());
				class4.bool_16 = true;
				class4.method_58(true);
				this.class911_9.Add(class4);
			}
			this.list_1[3].method_14(300, Enum70.const_0);
			this.list_1[4].method_14(300, Enum70.const_0);
			this.list_1[2].bool_1 = true;
			this.list_1[3].bool_1 = true;
			this.list_1[4].bool_1 = true;
		}

		// Token: 0x06001E68 RID: 7784
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		protected virtual bool vmethod_17()
		{
			return true;
		}

		// Token: 0x06001E6E RID: 7790
		// RVA: 0x00018F5C File Offset: 0x0001715C
		protected virtual void vmethod_18()
		{
			this.class538_0.vmethod_2(false);
			this.class538_0.bool_1 = false;
			this.class538_0.class26_0.Clear();
			this.class538_0.method_16(200, Enum70.const_0);
		}

		// Token: 0x06001E73 RID: 7795
		// RVA: 0x00018FD5 File Offset: 0x000171D5
		internal virtual Class512 vmethod_19()
		{
			return Class62.class512_0;
		}

		// Token: 0x06001E76 RID: 7798
		// RVA: 0x00018FDC File Offset: 0x000171DC
		protected virtual void vmethod_20()
		{
			this.class911_2.method_13<Class531>(this.list_0);
			this.class427_0.vmethod_38();
		}

		// Token: 0x06001E77 RID: 7799
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		protected virtual bool vmethod_21()
		{
			return true;
		}

		// Token: 0x06001E7C RID: 7804
		// RVA: 0x00018FFA File Offset: 0x000171FA
		internal virtual void vmethod_22()
		{
			this.class427_0.vmethod_37(false);
		}

		// Token: 0x06001E7D RID: 7805
		// RVA: 0x00019009 File Offset: 0x00017209
		protected virtual void vmethod_23()
		{
			this.vmethod_16();
		}

		// Token: 0x06001E7E RID: 7806
		// RVA: 0x000AB608 File Offset: 0x000A9808
		protected virtual void vmethod_24()
		{
			if (Class62.class512_0.list_5.Count == 0 || Class331.int_7 > Class62.class512_0.list_5[Class62.class512_0.list_5.Count - 1].int_1)
			{
				Class62.class512_0.list_5.Add(Class62.smethod_8());
			}
			this.method_7();
		}

		// Token: 0x06001E7F RID: 7807
		// RVA: 0x000AB66C File Offset: 0x000A986C
		protected virtual void vmethod_25()
		{
			if (Class62.class664_0 != null && this.class660_0 != null)
			{
				if (Class115.bool_13)
				{
					if (!this.bool_25 && !Class62.bool_6 && (Class872.bool_1 || Class62.class664_0.bool_0))
					{
						if (Class62.class664_0.class911_0.float_0 < 1f)
						{
							Class62.class664_0.class911_0.float_0 = Math.Min(1f, Class62.class664_0.class911_0.float_0 + 0.08f);
						}
					}
					else if (Class62.class664_0.class911_0.float_0 > 0f)
					{
						Class62.class664_0.class911_0.float_0 = Math.Max(0f, Class62.class664_0.class911_0.float_0 - 0.08f);
					}
				}
				if (this.class660_0 != null && this.class660_0.int_3 != Class62.class512_0.int_3)
				{
					this.class660_0.vmethod_0(Class62.class512_0);
					Class62.class664_0.vmethod_1(false);
				}
			}
		}

		// Token: 0x06001E85 RID: 7813
		// RVA: 0x00019032 File Offset: 0x00017232
		internal virtual void vmethod_26(bool bool_48)
		{
			Class115.smethod_70(OsuModes.Rank, false);
		}

		// Token: 0x06001E87 RID: 7815
		// RVA: 0x000ABE3C File Offset: 0x000AA03C
		protected virtual void vmethod_27()
		{
			this.class427_0.vmethod_30();
			if (this.inputOverlay_0 != null && Class341.class606_34 && !Class802.smethod_0())
			{
				this.inputOverlay_0.Draw();
			}
			this.class297_0.Draw();
			this.class427_0.Draw();
		}

		// Token: 0x06001E88 RID: 7816
		// RVA: 0x0000653E File Offset: 0x0000473E
		protected virtual void vmethod_28()
		{
		}

		// Token: 0x06001E89 RID: 7817
		// RVA: 0x0001903B File Offset: 0x0001723B
		protected virtual void vmethod_29()
		{
			if (Class62.class664_0 != null)
			{
				Class62.class664_0.Draw();
			}
		}

		// Token: 0x06001E8A RID: 7818
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		protected virtual bool vmethod_30()
		{
			return true;
		}

		// Token: 0x06001E96 RID: 7830
		// RVA: 0x0000653E File Offset: 0x0000473E
		internal virtual void vmethod_31(Class304 class304_2)
		{
		}

		// Token: 0x06001E9B RID: 7835
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		protected virtual bool vmethod_32()
		{
			return true;
		}

		// Token: 0x06001E34 RID: 7732
		// RVA: 0x000A4BF0 File Offset: 0x000A2DF0
		public virtual bool vmethod_5()
		{
			Class427 class = this.class427_0;
			return class != null && class.vmethod_12() && !Class62.bool_11 && (this.class108_0 == null || !this.class108_0.bool_1) && Class115.class89_0 == null;
		}

		// Token: 0x06001E3D RID: 7741
		// RVA: 0x000A5338 File Offset: 0x000A3538
		protected virtual void vmethod_6()
		{
			VoidDelegate voidDelegate = null;
			Class296 current = Class466.Current;
			switch (Class62.Mode)
			{
			case PlayModes.Osu:
				if (Class62.smethod_1())
				{
					this.class427_0 = new Class430(this);
				}
				else
				{
					this.class427_0 = new Class429(this);
				}
				break;
			case PlayModes.Taiko:
				this.class427_0 = new Class432(this);
				break;
			case PlayModes.CatchTheBeat:
				this.class427_0 = new Class431(this);
				break;
			case PlayModes.OsuMania:
				this.class427_0 = new Class428(this);
				break;
			}
			this.method_33(current);
			this.class297_0 = this.class427_0.class297_0;
			current.method_11();
			this.method_15();
			if (!Class802.smethod_0())
			{
				current.dateTime_0 = DateTime.Now;
				if (Class115.class522_0 != null)
				{
					Class115.class522_0.method_4();
				}
			}
			else
			{
				this.bool_33 = true;
			}
			this.class427_0.vmethod_25();
			bool flag = false;
			try
			{
				this.method_17();
			}
			catch (Exception11)
			{
				flag = true;
			}
			this.class297_0.method_8(current, Class62.class512_0.class623_0);
			this.class297_0.Load(false);
			if (this.class297_0.int_14 == 0 || (Class331.smethod_14() != null && Class331.smethod_14().Count == 0))
			{
				base.Initialize();
				this.vmethod_14();
				Class723.smethod_4(Class41.GetString(OsuString.Player_CantLoadBeatmap));
				return;
			}
			foreach (Class304 current2 in this.class297_0.list_3)
			{
				if (current2.EndTime > this.int_27)
				{
					this.int_27 = current2.EndTime;
				}
				if (current2.StartTime < this.int_28)
				{
					this.int_28 = current2.StartTime;
				}
			}
			this.class872_0 = this.class297_0.class872_0;
			this.method_27();
			this.class427_0.Initialize();
			if (Class115.class522_0 != null)
			{
				Class413 arg_1E0_0 = this.class427_0.class413_0;
				if (voidDelegate == null)
				{
					voidDelegate = new VoidDelegate(this.method_74);
				}
				arg_1E0_0.method_2(voidDelegate);
			}
			this.class427_0.vmethod_21(0f);
			this.method_33(current);
			this.class297_0.method_27(true);
			if (Class331.class335_0 == null || Class331.class335_0.vmethod_2() || flag)
			{
				if (Class858.class861_0 != null)
				{
					Class858.smethod_4(false);
				}
				this.vmethod_14();
				Class723.smethod_4(Class41.GetString(OsuString.Player_CantLoadAudio));
				return;
			}
			this.vmethod_12();
			if (!this.bool_45 && Class802.smethod_0() && !Class802.bool_16 && Class802.class512_0.list_1.Count == 0)
			{
				if (Class858.class861_0 != null)
				{
					Class115.smethod_70(OsuModes.Rank, false);
				}
				else
				{
					Class115.smethod_70(OsuModes.SelectPlay, false);
				}
				Class802.smethod_1(false);
				Class723.smethod_4(Class41.GetString(OsuString.Player_CantLoadReplay));
				return;
			}
			Class809.smethod_36(false);
			if (this.bool_45)
			{
				this.class427_0.vmethod_29();
				if (Class62.bool_16 && !Class802.smethod_0())
				{
					Class62.class512_0.list_1 = new List<Class14>();
					Class62.class512_0.string_2 = Class341.class605_20;
				}
				else
				{
					Class802.class512_0 = Class62.class512_0;
				}
			}
			this.vmethod_10();
			Class115.class47_0.Add(new VoidDelegate(this.method_19), false);
			if (Class341.class606_13)
			{
				this.class734_0 = new Class734();
			}
			this.method_30();
			this.method_25();
			this.vmethod_9();
			this.bool_31 = this.method_1();
			this.vmethod_11();
			this.vmethod_8();
			if (Class341.class606_34 || Class802.smethod_0())
			{
				switch (Class62.Mode)
				{
				case PlayModes.Osu:
					this.inputOverlay_0 = new InputOverlay();
					break;
				case PlayModes.CatchTheBeat:
					this.inputOverlay_0 = new InputOverlay();
					break;
				}
			}
			this.method_18();
			this.method_21();
			if (this.class108_0 != null)
			{
				this.class108_0.method_5();
			}
			if (this.bool_36 && !this.bool_46 && Thread.CurrentThread != Class115.thread_2)
			{
				Thread.Sleep((this is Class64) ? 5000 : 950);
			}
			if (Class858.bool_1 && !Class802.smethod_0() && !Class62.bool_27 && (Class809.class623_0 & Enum30.flag_3) > Enum30.flag_0 && Class341.class606_67.Value)
			{
				string text = Class111.smethod_55(null);
				text = string.Concat(new object[]
				{
					'\u0001',
					"ACTION ",
					text.Substring(4),
					'\u0001'
				});
				Class111.smethod_45(text, "#spectator", false);
			}
			Class62.bool_27 = false;
		}

		// Token: 0x06001E3E RID: 7742
		// RVA: 0x000A57F4 File Offset: 0x000A39F4
		protected virtual bool vmethod_7(bool bool_48)
		{
			if (!bool_48)
			{
				Class115.smethod_70((Class115.osuModes_2 != OsuModes.Play) ? Class115.osuModes_2 : OsuModes.Menu, true);
				Class723.smethod_5(Class41.GetString(OsuString.Player_CantLoadBeatmap), Color.get_Red(), 5000, null);
				Class765.smethod_0(new Class764(this.class523_0.exception_0)
				{
					string_0 = Class466.Current.method_3()
				});
				return true;
			}
			Class115.smethod_79(Class466.Current.string_6);
			Class62.smethod_6(true);
			this.bool_44 = true;
			if (Class62.class911_1 != null)
			{
				Class62.class911_1.list_2.ForEach(new Action<Class530>(this.method_75));
			}
			int num = 0;
			float num2 = 0f;
			int num3 = 610;
			foreach (Mods mods in Enum.GetValues(typeof(Mods)))
			{
				if (Class876.smethod_6(Class62.class512_0.class623_0, mods) && (mods != Mods.DoubleTime || !Class876.smethod_6(Class62.class512_0.class623_0, Mods.Nightcore)) && (mods != Mods.SuddenDeath || !Class876.smethod_6(Class62.class512_0.class623_0, Mods.Perfect)))
				{
					Class746 class = new Class746(TransformationType.Scale, 2f, 1f, Class115.int_1 + num, Class115.int_1 + num + 400, Enum70.const_0);
					class.enum70_0 = Enum70.const_1;
					Class746 item = new Class746(TransformationType.Fade, 0f, 1f, Class115.int_1 + num, Class115.int_1 + num + 400, Enum70.const_0);
					Class531 class2 = new Class531(Class885.Load("selection-mod-" + mods.ToString().ToLower(), Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2((float)num3, 94f), 0.9f + num2, Class802.smethod_0(), Color.get_TransparentWhite(), null);
					if (!Class802.smethod_0())
					{
						class2.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class115.int_1 + num, Class115.int_1 + num + 5000, Enum70.const_0));
					}
					class2.class26_0.Add(item);
					class2.class26_0.Add(class);
					this.class911_7.Add(class2);
					num += 500;
					num2 += 1E-05f;
					num3 -= 10;
				}
			}
			this.class427_0.vmethod_49();
			return false;
		}

		// Token: 0x06001E43 RID: 7747
		// RVA: 0x000A5D00 File Offset: 0x000A3F00
		protected virtual void vmethod_8()
		{
			this.queue_0 = new Queue<int>();
			if (this.class872_0.list_0.Count > 0)
			{
				this.class531_3 = new Class531(Class885.Load("section-pass", Enum112.flag_6), Enum115.const_9, Origins.Centre, Enum114.const_1, Vector2.get_Zero(), 1f, true, Color.get_TransparentWhite(), null);
				this.class531_2 = new Class531(Class885.Load("section-fail", Enum112.flag_6), Enum115.const_9, Origins.Centre, Enum114.const_1, Vector2.get_Zero(), 1f, true, Color.get_TransparentWhite(), null);
				if (this.class427_0.vmethod_11())
				{
					this.class911_2.Add(this.class531_3);
					this.class911_2.Add(this.class531_2);
					this.list_0.Add(new Class531(Class885.Load("play-warningarrow", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_1, new Vector2(80f, 100f), 1f, false, Class885.smethod_25() ? Color.get_Red() : Color.get_White(), null));
					this.list_0.Add(new Class531(Class885.Load("play-warningarrow", Enum112.flag_6), Enum115.const_11, Origins.Centre, Enum114.const_1, new Vector2(80f, 100f), 1f, false, Class885.smethod_25() ? Color.get_Red() : Color.get_White(), null));
					this.list_0.Add(new Class531(Class885.Load("play-warningarrow", Enum112.flag_6), Enum115.const_7, Origins.Centre, Enum114.const_1, new Vector2(80f, 100f), 1f, false, Class885.smethod_25() ? Color.get_Red() : Color.get_White(), null));
					this.list_0.Add(new Class531(Class885.Load("play-warningarrow", Enum112.flag_6), Enum115.const_13, Origins.Centre, Enum114.const_1, new Vector2(80f, 100f), 1f, false, Class885.smethod_25() ? Color.get_Red() : Color.get_White(), null));
					this.list_0[2].method_45(true);
					this.list_0[3].method_45(true);
					this.class911_2.Add<Class531>(this.list_0);
				}
				foreach (Class705 current in this.class872_0.list_0)
				{
					if (this.class427_0.vmethod_11())
					{
						for (int i = 0; i < 1300; i += 200)
						{
							Class62.Class418 class = new Class62.Class418();
							class.class746_0 = new Class746(TransformationType.Fade, 0f, 1f, current.int_0 - 1000 + i, current.int_0 - 1000 + i, Enum70.const_0);
							class.class746_1 = new Class746(TransformationType.Fade, 1f, 0f, current.int_0 - 900 + i, current.int_0 - 900 + i, Enum70.const_0);
							this.list_0.ForEach(new Action<Class531>(class.method_0));
						}
					}
					if (current.int_0 > Class331.int_7 && current.int_2 > this.class297_0.list_3[0].StartTime)
					{
						this.queue_0.Enqueue(this.class297_0.list_3[this.class297_0.method_23(current)].EndTime);
					}
				}
			}
		}

		// Token: 0x06001E45 RID: 7749
		// RVA: 0x000A6794 File Offset: 0x000A4994
		protected virtual void vmethod_9()
		{
			this.class533_1 = new Class533(string.Empty, 11f, new Vector2(0f, 80f), 1f, true, Color.get_White());
			this.class533_1.method_58(true);
			if (Class115.bool_16)
			{
				return;
			}
			if ((!Class802.smethod_0() && Class341.class606_55) || Class802.bool_16)
			{
				this.class911_10.Add(this.class533_1);
			}
		}
	}
}
