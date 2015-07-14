using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns18;
using ns24;
using ns25;
using ns26;
using ns27;
using ns29;
using ns6;
using ns64;
using ns77;
using ns79;
using ns8;
using ns80;
using ns81;
using ns82;
using ns89;
using ns9;
using ns90;
using osu;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns22
{
	// Token: 0x020003D5 RID: 981
	internal sealed class Class108 : Class54
	{
		// Token: 0x040018EB RID: 6379
		[CompilerGenerated]
		private static Action<Class530> action_0;

		// Token: 0x040018DD RID: 6365
		internal bool bool_1;

		// Token: 0x040018E3 RID: 6371
		private bool bool_2;

		// Token: 0x040018E4 RID: 6372
		private bool bool_3;

		// Token: 0x040018E5 RID: 6373
		private bool bool_4;

		// Token: 0x040018E7 RID: 6375
		private bool bool_5;

		// Token: 0x040018E8 RID: 6376
		private bool bool_6;

		// Token: 0x040018E9 RID: 6377
		private bool bool_7 = Class802.smethod_0() || Class858.class861_0 != null;

		// Token: 0x040018DB RID: 6363
		private Class531 class531_0;

		// Token: 0x040018DF RID: 6367
		private Class762 class762_0;

		// Token: 0x040018E0 RID: 6368
		private Class762 class762_1;

		// Token: 0x040018E1 RID: 6369
		private Class762 class762_2;

		// Token: 0x040018E2 RID: 6370
		private Class762 class762_3;

		// Token: 0x040018DE RID: 6366
		private Class883 class883_0;

		// Token: 0x040018DA RID: 6362
		private readonly Class911 class911_0 = new Class911(true);

		// Token: 0x040018D9 RID: 6361
		private int int_1 = 150;

		// Token: 0x040018DC RID: 6364
		private int int_2;

		// Token: 0x040018EA RID: 6378
		[CompilerGenerated]
		private static Predicate<Class296> predicate_0;

		// Token: 0x040018E6 RID: 6374
		private Vector2 vector2_0;

		// Token: 0x06001F75 RID: 8053
		// RVA: 0x000B1E60 File Offset: 0x000B0060
		public Class108(Class114 class114_1) : base(class114_1)
		{
			this.Initialize();
			this.method_4();
		}

		// Token: 0x06001F78 RID: 8056
		// RVA: 0x000B20D4 File Offset: 0x000B02D4
		protected override void Dispose(bool bool_8)
		{
			Action<Class296> action = null;
			if (this.bool_4)
			{
				List<Class296> arg_2C_0 = Class466.list_3;
				if (Class108.predicate_0 == null)
				{
					Class108.predicate_0 = new Predicate<Class296>(Class108.smethod_0);
				}
				List<Class296> arg_42_0 = arg_2C_0.FindAll(Class108.predicate_0);
				if (action == null)
				{
					action = new Action<Class296>(this.method_16);
				}
				arg_42_0.ForEach(action);
			}
			this.class911_0.Dispose();
			this.class883_0.Dispose();
			base.Dispose(bool_8);
			if (this.bool_2)
			{
				Class885.smethod_13(true);
				Class62.bool_27 = false;
			}
			if (this.bool_3)
			{
				Class331.smethod_46();
			}
			Class872.smethod_1(true);
			Class872.smethod_3(Class341.class606_69);
			Class885.bool_2 = false;
			Class331.bool_3 = false;
			Class872.int_2 = 30;
		}

		// Token: 0x06001F84 RID: 8068
		// RVA: 0x000B2980 File Offset: 0x000B0B80
		internal void Draw()
		{
			if (!this.bool_1 && this.bool_7 && this.class531_0.vector2_1 == this.class531_0.vector2_0)
			{
				return;
			}
			this.class911_0.Draw();
			Class62.class62_0.class911_9.float_0 = 1f - Math.Max(0f, (this.class531_0.vector2_0.Y - this.class531_0.vector2_1.Y - 45f - 30f) / (float)(this.int_1 - 45 - 30));
		}

		// Token: 0x06001F85 RID: 8069
		// RVA: 0x000B2A24 File Offset: 0x000B0C24
		public override void imethod_2()
		{
			if (!this.bool_5 && Vector2.Distance(this.vector2_0, Class800.smethod_19()) > 30f)
			{
				this.bool_5 = true;
			}
			bool flag = !Class111.bool_2 && Class800.smethod_17().Y > (float)this.method_2() && Class800.smethod_17().Y < (float)(Class115.smethod_44() + 20) && Class800.smethod_19().X > 0f && Class800.smethod_19().X < (float)Class115.int_22 && this.bool_5;
			if (((!this.bool_7 && (Class62.bool_11 || (Class872.bool_1 && Class872.class705_0 == null))) || (Class64.class64_0 == null && Class802.smethod_0() && !Class62.class62_0.method_13() && Class111.class911_0.class531_1 == null)) && flag && Class114.bool_0)
			{
				this.method_14(false, false);
			}
			else if (!flag && this.bool_1)
			{
				this.method_15(null);
			}
			base.imethod_2();
		}

		// Token: 0x06001F79 RID: 8057
		// RVA: 0x000B2190 File Offset: 0x000B0390
		public override void Initialize()
		{
			int num = this.method_2() + 45;
			int num2 = 0;
			this.vector2_0 = Class800.smethod_19();
			this.class531_0 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(0f, (float)num), 0.68f, true, this.method_3() ? new Color(0, 78, 155) : Color.get_DarkGray(), null);
			this.class531_0.float_2 = 1.6f;
			this.class531_0.vector2_2 = new Vector2((float)this.method_1(), 3f);
			this.class911_0.Add(this.class531_0);
			num += 3;
			this.class531_0 = new Class531(Class115.class731_0, Enum115.const_5, Origins.TopLeft, Enum114.const_0, new Vector2(0f, (float)num), 0.68f, true, new Color(0, 0, 0, 180), null);
			this.class531_0.float_2 = 1.6f;
			this.class531_0.vector2_2 = new Vector2((float)this.method_1(), (float)this.int_1);
			this.class911_0.Add(this.class531_0);
			this.class911_0.Add(new Class533("Visual", 24f, new Vector2((float)num2, (float)num), Vector2.get_Zero(), 0.99f, true, Color.get_LightBlue(), true)
			{
				bool_16 = true
			});
			num += 15;
			this.class911_0.Add(new Class533("Settings", 22f, new Vector2((float)(num2 + 50), (float)num), Vector2.get_Zero(), 1f, true, Color.get_White(), true)
			{
				bool_16 = true
			});
			bool flag = this.method_3();
			if (!this.method_3())
			{
				Class911 arg_205_0 = this.class911_0;
				Class533 class = new Class533(Class41.GetString(OsuString.FunSpoiler_PlayFirst), 15f, new Vector2((float)(Class115.smethod_43() / 2), (float)num), new Vector2(480f, 0f), 1f, true, Color.get_OrangeRed(), true);
				class.method_59(true);
				class.origins_0 = Origins.Centre;
				class.bool_16 = true;
				class.bool_15 = false;
				arg_205_0.Add(class);
			}
			num += 30;
			this.class911_0.Add(new Class533(Class41.GetString(OsuString.FunSpoiler_BackgroundDim), 10f, new Vector2((float)(num2 + 20), (float)num), new Vector2((float)this.method_1(), 20f), 0.99f, true, Color.get_White(), true)
			{
				bool_16 = true,
				bool_15 = false
			});
			this.class911_0.Add(new Class533(Class41.GetString(OsuString.FunSpoiler_Toggles), 10f, new Vector2((float)(num2 + 20 + 240), (float)num), new Vector2((float)this.method_1(), 20f), 0.99f, true, flag ? Color.get_White() : Color.get_DarkGray(), true)
			{
				bool_16 = true,
				bool_15 = false
			});
			num += 20;
			this.class883_0 = new Class883(this.class911_0, 0.0, (double)(flag ? 100 : 60), (double)(Class466.Current.nullable_0 ?? Class341.class608_1.Value), new Vector2((float)(num2 + 20), (float)num), 200);
			this.class883_0.method_5(new EventHandler(this.method_10));
			this.method_11();
			this.class762_0 = new Class762(Class41.GetString(OsuString.FunSpoiler_Storyboard), 0.8f, new Vector2((float)(num2 + 20 + 240), (float)num), 0.99f, false, 0f);
			this.class762_0.method_1(flag || Class466.Current.bool_21);
			this.class762_0.method_8(new Delegate38(this.method_8));
			this.class911_0.Add<Class531>(this.class762_0.list_0);
			this.class762_1 = new Class762(Class41.GetString(OsuString.FunSpoiler_Video), 0.8f, new Vector2((float)(num2 + 40 + 480), (float)num), 0.99f, false, 0f);
			this.class762_1.method_1(false);
			this.class762_1.method_8(new Delegate38(this.method_9));
			this.class911_0.Add<Class531>(this.class762_1.list_0);
			num += 20;
			this.class762_2 = new Class762(Class41.GetString(OsuString.FunSpoiler_Skin), 0.8f, new Vector2((float)(num2 + 20 + 240), (float)num), 0.99f, false, 0f);
			this.class762_2.method_8(new Delegate38(this.method_7));
			this.class762_2.method_1(flag);
			this.class911_0.Add<Class531>(this.class762_2.list_0);
			num += 20;
			this.class762_3 = new Class762(Class41.GetString(OsuString.FunSpoiler_Hitsounds), 0.8f, new Vector2((float)(num2 + 20 + 240), (float)num), 0.99f, false, 0f);
			this.class762_3.method_8(new Delegate38(this.method_6));
			this.class762_3.method_1(flag);
			this.class911_0.Add<Class531>(this.class762_3.list_0);
			this.class911_0.bool_1 = false;
			base.Initialize();
		}

		// Token: 0x06001F72 RID: 8050
		// RVA: 0x00019B4D File Offset: 0x00017D4D
		internal int method_1()
		{
			return Class115.smethod_43();
		}

		// Token: 0x06001F7E RID: 8062
		// RVA: 0x000B26E0 File Offset: 0x000B08E0
		private void method_10(object sender, EventArgs e)
		{
			this.method_12();
			Class872.int_2 = (int)this.class883_0.double_1;
			if (Class872.int_2 != Class341.class608_1.Value)
			{
				Class466.Current.nullable_0 = new int?(Class872.int_2);
			}
			this.bool_4 = true;
			this.method_11();
		}

		// Token: 0x06001F7F RID: 8063
		// RVA: 0x00019C08 File Offset: 0x00017E08
		private void method_11()
		{
			this.class883_0.method_4(string.Format(Class41.GetString(OsuString.FunSpoiler_Dim_Tooltip), Class872.int_2, this.class883_0.double_2));
		}

		// Token: 0x06001F80 RID: 8064
		// RVA: 0x000B2738 File Offset: 0x000B0938
		private void method_12()
		{
			if (Class466.Current.bool_26)
			{
				return;
			}
			Class466.Current.bool_26 = true;
			Class466.Current.bool_25 = !Class341.class606_69;
			Class466.Current.bool_24 = !Class341.class606_56;
			Class466.Current.bool_23 = Class341.class606_32;
			Class466.Current.bool_22 = Class341.class606_31;
		}

		// Token: 0x06001F81 RID: 8065
		// RVA: 0x00019C3E File Offset: 0x00017E3E
		private void method_13()
		{
			if (Class62.bool_40 && (Class64.class10_0 == null || Class64.bool_48))
			{
				Class723.smethod_1(Class41.GetString(OsuString.FunSpoiler_Restart), 1000);
				return;
			}
			Class62.bool_47 = true;
		}

		// Token: 0x06001F82 RID: 8066
		// RVA: 0x000B27B4 File Offset: 0x000B09B4
		internal void method_14(bool bool_8, bool bool_9)
		{
			if (Class115.bool_16)
			{
				return;
			}
			if (this.int_2 == 0)
			{
				List<Class530> arg_38_0 = this.class911_0.list_2;
				if (Class108.action_0 == null)
				{
					Class108.action_0 = new Action<Class530>(Class108.smethod_1);
				}
				arg_38_0.ForEach(Class108.action_0);
			}
			this.bool_6 = bool_8;
			this.int_2 = Class115.int_1;
			if (bool_8)
			{
				this.int_2 += 500;
			}
			if (this.bool_1)
			{
				return;
			}
			if (bool_9)
			{
				this.class911_0.list_2.ForEach(new Action<Class530>(this.method_17));
			}
			else
			{
				this.class911_0.list_2.ForEach(new Action<Class530>(this.method_18));
			}
			this.bool_1 = true;
		}

		// Token: 0x06001F83 RID: 8067
		// RVA: 0x000B2874 File Offset: 0x000B0A74
		internal void method_15(bool? nullable_0)
		{
			if (Class115.int_1 >= this.int_2 && (!(nullable_0 == this.bool_7) || this.bool_1))
			{
				if (nullable_0.HasValue)
				{
					this.bool_7 = nullable_0.Value;
				}
				float num = (float)(this.bool_7 ? 0 : 45);
				using (List<Class530>.Enumerator enumerator = this.class911_0.list_2.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class531 class = (Class531)enumerator.Current;
						float num2 = class.vector2_0.Y - num;
						bool flag = class.vector2_1.Y >= num2;
						class.method_21(num2, flag ? 400 : 600, flag ? Enum70.const_2 : Enum70.const_33);
					}
				}
				this.class883_0.method_22();
				this.bool_1 = false;
				return;
			}
		}

		// Token: 0x06001F86 RID: 8070
		// RVA: 0x000B2B2C File Offset: 0x000B0D2C
		[CompilerGenerated]
		private void method_16(Class296 class296_0)
		{
			class296_0.bool_22 = this.class762_3.method_2();
			class296_0.bool_23 = this.class762_2.method_2();
			class296_0.bool_24 = this.class762_0.method_2();
			if (Class341.class606_69 && Class115.osuModes_1 != OsuModes.Edit && !Class115.bool_25)
			{
				class296_0.bool_25 = Class466.Current.bool_25;
			}
			class296_0.nullable_0 = new int?((int)this.class883_0.double_1);
		}

		// Token: 0x06001F89 RID: 8073
		// RVA: 0x00019C87 File Offset: 0x00017E87
		[CompilerGenerated]
		private void method_17(Class530 class530_0)
		{
			class530_0.vector2_1.Y = class530_0.vector2_0.Y - (float)this.int_1;
		}

		// Token: 0x06001F8A RID: 8074
		// RVA: 0x00019CA7 File Offset: 0x00017EA7
		[CompilerGenerated]
		private void method_18(Class530 class530_0)
		{
			class530_0.method_21(class530_0.vector2_0.Y - (float)this.int_1, 400, Enum70.const_1);
		}

		// Token: 0x06001F73 RID: 8051
		// RVA: 0x00019B54 File Offset: 0x00017D54
		private int method_2()
		{
			return Class115.smethod_44() - (this.bool_1 ? this.int_1 : 45);
		}

		// Token: 0x06001F74 RID: 8052
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		public bool method_3()
		{
			return true;
		}

		// Token: 0x06001F76 RID: 8054
		// RVA: 0x000B1EB4 File Offset: 0x000B00B4
		private void method_4()
		{
			bool flag = this.method_3();
			if (Class466.Current.bool_26)
			{
				this.class883_0.SetValue((double)(Class872.int_2 = (Class466.Current.nullable_0 ?? Class341.class608_1.Value)), true);
				Class762 arg_7E_0 = this.class762_0;
				bool expr_75 = (!flag && !Class466.Current.bool_21) || !Class466.Current.bool_24;
				Class872.smethod_1(expr_75);
				arg_7E_0.method_6(!expr_75);
				Class762 arg_AE_0 = this.class762_1;
				bool expr_A5 = Class341.class606_69 && !Class466.Current.bool_25;
				Class872.smethod_3(expr_A5);
				arg_AE_0.method_6(!expr_A5);
				this.class762_2.method_6(Class885.bool_2 = (flag && Class466.Current.bool_23));
				this.class762_3.method_6(Class331.bool_3 = (flag && Class466.Current.bool_22));
			}
			else
			{
				this.class883_0.SetValue((double)(Class872.int_2 = Class341.class608_1.Value), true);
				Class762 arg_130_0 = this.class762_0;
				bool expr_127 = Class341.class606_56;
				Class872.smethod_1(expr_127);
				arg_130_0.method_6(!expr_127);
				Class762 arg_14E_0 = this.class762_1;
				bool expr_145 = Class341.class606_69;
				Class872.smethod_3(expr_145);
				arg_14E_0.method_6(!expr_145);
				this.class762_2.method_6(Class885.bool_2 = Class341.class606_32);
				this.class762_3.method_6(Class331.bool_3 = Class341.class606_31);
			}
			this.method_11();
		}

		// Token: 0x06001F77 RID: 8055
		// RVA: 0x000B2050 File Offset: 0x000B0250
		internal void method_5()
		{
			if (Class62.class62_0 == null)
			{
				return;
			}
			Class872 class872_ = Class62.class62_0.class872_0;
			if (class872_ == null)
			{
				return;
			}
			Class762 expr_1D = this.class762_0;
			expr_1D.method_1(expr_1D.method_0() & (this.class762_0.method_2() || class872_.bool_11));
			this.class762_1.method_1(Class341.class606_69 && (this.class762_1.method_2() || class872_.list_5.Count > 0));
		}

		// Token: 0x06001F7A RID: 8058
		// RVA: 0x00019B6E File Offset: 0x00017D6E
		private void method_6(object object_0, bool bool_8)
		{
			this.method_12();
			Class466.Current.bool_22 = bool_8;
			this.bool_3 = true;
			this.bool_4 = true;
			this.method_13();
		}

		// Token: 0x06001F7B RID: 8059
		// RVA: 0x00019B95 File Offset: 0x00017D95
		private void method_7(object object_0, bool bool_8)
		{
			this.method_12();
			Class466.Current.bool_23 = bool_8;
			this.bool_2 = true;
			this.bool_4 = true;
			this.method_13();
		}

		// Token: 0x06001F7C RID: 8060
		// RVA: 0x00019BBC File Offset: 0x00017DBC
		private void method_8(object object_0, bool bool_8)
		{
			this.method_12();
			Class466.Current.bool_24 = bool_8;
			Class872.smethod_1(!bool_8);
			this.bool_4 = true;
		}

		// Token: 0x06001F7D RID: 8061
		// RVA: 0x00019BDF File Offset: 0x00017DDF
		private void method_9(object object_0, bool bool_8)
		{
			this.method_12();
			Class466.Current.bool_25 = bool_8;
			Class872.smethod_3(!bool_8);
			this.bool_4 = true;
			this.method_13();
		}

		// Token: 0x06001F87 RID: 8071
		// RVA: 0x00019C70 File Offset: 0x00017E70
		[CompilerGenerated]
		private static bool smethod_0(Class296 class296_0)
		{
			return class296_0.string_4 == Class466.Current.string_4;
		}

		// Token: 0x06001F88 RID: 8072
		// RVA: 0x000B2BB0 File Offset: 0x000B0DB0
		[CompilerGenerated]
		private static void smethod_1(Class530 class530_0)
		{
			Class533 class = class530_0 as Class533;
			if (class != null && class.class731_0 == null)
			{
				class.vmethod_11();
			}
		}
	}
}
