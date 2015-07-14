using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns18;
using ns26;
using ns29;
using ns6;
using ns64;
using ns79;
using ns80;
using ns81;
using ns82;
using ns9;
using osu;
using osu.Graphics.Sprites;
using osu.Input;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns22
{
	// Token: 0x020003B7 RID: 951
	internal sealed class Class81 : Class55
	{
		// Token: 0x0400177C RID: 6012
		private Class531 class531_0;

		// Token: 0x04001775 RID: 6005
		private Class85 class85_0;

		// Token: 0x04001776 RID: 6006
		private Class85 class85_1;

		// Token: 0x04001777 RID: 6007
		private Class85 class85_2;

		// Token: 0x04001779 RID: 6009
		private Class85 class85_3;

		// Token: 0x0400177A RID: 6010
		private Class911 class911_0 = new Class911(true);

		// Token: 0x0400177B RID: 6011
		private int int_2;

		// Token: 0x04001778 RID: 6008
		private List<Class85> list_0 = new List<Class85>();

		// Token: 0x0400177D RID: 6013
		[CompilerGenerated]
		private static Predicate<Class85> predicate_0;

		// Token: 0x06001D86 RID: 7558
		// RVA: 0x000A0AB8 File Offset: 0x0009ECB8
		public Class81() : base(Class115.class114_0)
		{
			this.list_0.Add(this.class85_1 = new Class85(Class331.class608_0, "effect volume", new Vector2(-100f, 170f), 0.8f, false, new EventHandler(this.method_1)));
			this.list_0.Add(this.class85_0 = new Class85(Class331.class608_2, "master volume", new Vector2(0f, 140f), 1f, true, new EventHandler(this.method_1)));
			this.list_0.Add(this.class85_2 = new Class85(Class331.class608_1, "music volume", new Vector2(100f, 170f), 0.8f, false, new EventHandler(this.method_1)));
			this.class911_0.Add(this.class531_0 = new Class531(Class885.Load("volume-background-gradient", Enum112.flag_1), Enum115.const_11, Origins.BottomLeft, Enum114.const_0, Vector2.get_Zero(), 0f, true, Color.get_TransparentWhite(), null));
			this.class85_0.vmethod_0(new EventHandler(this.method_2));
			this.class85_3 = this.class85_0;
			Class802.smethod_34(Enum96.const_1, new Delegate46(this.method_5), Enum98.const_1, Enum97.const_1);
			Class802.smethod_34(Enum96.const_0, new Delegate46(this.method_6), Enum98.const_1, Enum97.const_1);
			Class802.smethod_34(Enum96.const_1, new Delegate46(this.method_7), Enum98.const_7, Enum97.const_1);
			Class802.smethod_34(Enum96.const_0, new Delegate46(this.method_8), Enum98.const_7, Enum97.const_1);
			Class802.smethod_34(Enum96.const_1, new Delegate46(this.method_9), Enum98.const_8, Enum97.const_1);
			Class802.smethod_34(Enum96.const_0, new Delegate46(this.method_10), Enum98.const_8, Enum97.const_1);
		}

		// Token: 0x06001D8A RID: 7562
		// RVA: 0x000184E5 File Offset: 0x000166E5
		protected override void Dispose(bool bool_2)
		{
			base.Dispose(bool_2);
			this.class911_0.Dispose();
			this.class85_0.Dispose();
			this.class85_1.Dispose();
			this.class85_2.Dispose();
		}

		// Token: 0x06001D88 RID: 7560
		// RVA: 0x000A0C88 File Offset: 0x0009EE88
		public override void Draw()
		{
			this.class531_0.vector2_2 = new Vector2((float)Class115.int_22 * 1.6f, 1f);
			this.class911_0.Draw();
			this.class85_0.Draw();
			this.class85_1.Draw();
			this.class85_2.Draw();
			base.Draw();
		}

		// Token: 0x06001D89 RID: 7561
		// RVA: 0x000184BC File Offset: 0x000166BC
		public override void imethod_2()
		{
			this.class85_0.imethod_2();
			this.class85_1.imethod_2();
			this.class85_2.imethod_2();
			base.imethod_2();
		}

		// Token: 0x06001D96 RID: 7574
		// RVA: 0x000185E3 File Offset: 0x000167E3
		public override bool imethod_8()
		{
			List<Class85> arg_23_0 = this.list_0;
			if (Class81.predicate_0 == null)
			{
				Class81.predicate_0 = new Predicate<Class85>(Class81.smethod_0);
			}
			return arg_23_0.Find(Class81.predicate_0) != null;
		}

		// Token: 0x06001D85 RID: 7557
		// RVA: 0x0001847C File Offset: 0x0001667C
		private void method_1(object sender, EventArgs e)
		{
			this.method_4(sender as Class85);
		}

		// Token: 0x06001D92 RID: 7570
		// RVA: 0x00018599 File Offset: 0x00016799
		private bool method_10(object object_0, EventArgs eventArgs_0)
		{
			return this.imethod_8() && this.method_6(object_0, eventArgs_0);
		}

		// Token: 0x06001D93 RID: 7571
		// RVA: 0x000185AD File Offset: 0x000167AD
		private bool method_11(int int_3)
		{
			if (!this.method_13())
			{
				return false;
			}
			if (Class62.bool_12)
			{
				this.class85_0.method_6(int_3);
			}
			else if (this.method_3())
			{
				this.class85_3.method_6(int_3);
			}
			return true;
		}

		// Token: 0x06001D94 RID: 7572
		// RVA: 0x000A0D3C File Offset: 0x0009EF3C
		internal bool method_12(object object_0, Keys keys_0, bool bool_2)
		{
			Predicate<Class85> predicate = null;
			Predicate<Class85> predicate2 = null;
			if (!this.method_13() || (!Class570.bool_1 && Class115.osuModes_1 == OsuModes.Play && Class62.bool_11))
			{
				return false;
			}
			if (bool_2)
			{
				this.int_2 = 0;
			}
			else if (++this.int_2 < 4)
			{
				return true;
			}
			switch (Class795.smethod_10(keys_0))
			{
			case Bindings.VolumeIncrease:
				this.method_11(5);
				return true;
			case Bindings.VolumeDecrease:
				this.method_11(-5);
				return true;
			default:
				if (this.class85_0.imethod_8())
				{
					switch (keys_0)
					{
					case 37:
					{
						List<Class85> arg_CD_0 = this.list_0;
						int arg_BE_0 = this.list_0.Count;
						List<Class85> arg_B9_0 = this.list_0;
						if (predicate == null)
						{
							predicate = new Predicate<Class85>(this.method_14);
						}
						this.method_4(arg_CD_0[(arg_BE_0 + arg_B9_0.FindIndex(predicate) - 1) % this.list_0.Count]);
						return true;
					}
					case 39:
					{
						List<Class85> arg_116_0 = this.list_0;
						int arg_107_0 = this.list_0.Count;
						List<Class85> arg_102_0 = this.list_0;
						if (predicate2 == null)
						{
							predicate2 = new Predicate<Class85>(this.method_15);
						}
						this.method_4(arg_116_0[(arg_107_0 + arg_102_0.FindIndex(predicate2) + 1) % this.list_0.Count]);
						return true;
					}
					}
				}
				return false;
			}
		}

		// Token: 0x06001D95 RID: 7573
		// RVA: 0x000A0E84 File Offset: 0x0009F084
		internal bool method_13()
		{
			bool result;
			if (!(result = (Class570.bool_1 || this.imethod_8())) && (Class111.smethod_12() || (Class111.bool_2 && Class111.bool_1)))
			{
				return false;
			}
			OsuModes osuModes_ = Class115.osuModes_1;
			switch (osuModes_)
			{
			case OsuModes.Menu:
				break;
			case OsuModes.Edit:
				return result;
			case OsuModes.Play:
				if (!Class341.class606_44)
				{
					return true;
				}
				return result;
			default:
				if (osuModes_ != OsuModes.MatchSetup)
				{
					return result;
				}
				break;
			}
			return true;
		}

		// Token: 0x06001D98 RID: 7576
		// RVA: 0x0001861F File Offset: 0x0001681F
		[CompilerGenerated]
		private bool method_14(Class85 class85_4)
		{
			return class85_4 == this.class85_3;
		}

		// Token: 0x06001D99 RID: 7577
		// RVA: 0x0001861F File Offset: 0x0001681F
		[CompilerGenerated]
		private bool method_15(Class85 class85_4)
		{
			return class85_4 == this.class85_3;
		}

		// Token: 0x06001D87 RID: 7559
		// RVA: 0x0001848A File Offset: 0x0001668A
		private void method_2(object sender, EventArgs e)
		{
			if (this.class85_0.imethod_8())
			{
				this.class531_0.method_14(300, Enum70.const_0);
				return;
			}
			this.class531_0.method_16(300, Enum70.const_0);
		}

		// Token: 0x06001D8B RID: 7563
		// RVA: 0x000A0CEC File Offset: 0x0009EEEC
		private bool method_3()
		{
			bool result;
			if (!(result = this.class85_0.imethod_8()))
			{
				this.method_4(this.class85_0);
			}
			this.class85_0.vmethod_1(true);
			this.class85_1.vmethod_1(true);
			this.class85_2.vmethod_1(true);
			return result;
		}

		// Token: 0x06001D8C RID: 7564
		// RVA: 0x0001851A File Offset: 0x0001671A
		private void method_4(Class85 class85_4)
		{
			if (this.class85_3 == class85_4)
			{
				return;
			}
			this.class85_3.method_2(false);
			this.class85_3 = class85_4;
			this.class85_3.method_2(true);
			this.method_3();
		}

		// Token: 0x06001D8D RID: 7565
		// RVA: 0x0001854C File Offset: 0x0001674C
		private bool method_5(object object_0, EventArgs eventArgs_0)
		{
			return this.method_11(5);
		}

		// Token: 0x06001D8E RID: 7566
		// RVA: 0x00018555 File Offset: 0x00016755
		private bool method_6(object object_0, EventArgs eventArgs_0)
		{
			return this.method_11(-5);
		}

		// Token: 0x06001D8F RID: 7567
		// RVA: 0x0001855F File Offset: 0x0001675F
		private bool method_7(object object_0, EventArgs eventArgs_0)
		{
			return Class570.bool_1 && this.method_5(object_0, eventArgs_0);
		}

		// Token: 0x06001D90 RID: 7568
		// RVA: 0x00018572 File Offset: 0x00016772
		private bool method_8(object object_0, EventArgs eventArgs_0)
		{
			return Class570.bool_1 && this.method_6(object_0, eventArgs_0);
		}

		// Token: 0x06001D91 RID: 7569
		// RVA: 0x00018585 File Offset: 0x00016785
		private bool method_9(object object_0, EventArgs eventArgs_0)
		{
			return this.imethod_8() && this.method_5(object_0, eventArgs_0);
		}

		// Token: 0x06001D9A RID: 7578
		// RVA: 0x0001862A File Offset: 0x0001682A
		[CompilerGenerated]
		private static bool smethod_0(Class85 class85_4)
		{
			return class85_4.method_5();
		}

		// Token: 0x06001D97 RID: 7575
		// RVA: 0x00018613 File Offset: 0x00016813
		public override void vmethod_1(bool bool_2)
		{
			throw new InvalidOperationException("nope");
		}
	}
}
