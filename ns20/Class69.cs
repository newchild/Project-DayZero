using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ns17;
using ns24;
using ns26;
using ns27;
using ns29;
using ns64;
using ns79;
using ns8;
using ns80;
using ns81;
using ns82;
using ns84;
using ns9;
using osu;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns20
{
	// Token: 0x020004DC RID: 1244
	internal sealed class Class69 : Class61
	{
		// Token: 0x04002134 RID: 8500
		[CompilerGenerated]
		private static Action<Class531> action_0;

		// Token: 0x0400212A RID: 8490
		private bool bool_2;

		// Token: 0x0400212B RID: 8491
		private bool bool_3;

		// Token: 0x0400212C RID: 8492
		private bool bool_4;

		// Token: 0x04002129 RID: 8489
		private Class296 class296_0;

		// Token: 0x04002126 RID: 8486
		private Class531 class531_0;

		// Token: 0x04002124 RID: 8484
		private Class533 class533_0;

		// Token: 0x04002125 RID: 8485
		private Class762 class762_0;

		// Token: 0x04002130 RID: 8496
		private Class762 class762_1;

		// Token: 0x04002131 RID: 8497
		private Class762 class762_2;

		// Token: 0x04002123 RID: 8483
		private Class911 class911_1;

		// Token: 0x04002133 RID: 8499
		private double double_0;

		// Token: 0x04002128 RID: 8488
		private int int_2;

		// Token: 0x0400212D RID: 8493
		private int int_3;

		// Token: 0x0400212E RID: 8494
		private int int_4;

		// Token: 0x0400212F RID: 8495
		private int int_5;

		// Token: 0x04002132 RID: 8498
		private int int_6;

		// Token: 0x04002127 RID: 8487
		private List<Class531> list_0;

		// Token: 0x06002807 RID: 10247
		// RVA: 0x0001EDAF File Offset: 0x0001CFAF
		internal Class69(Class114 class114_1) : base(class114_1)
		{
		}

		// Token: 0x06002813 RID: 10259
		// RVA: 0x0001EE8D File Offset: 0x0001D08D
		protected override void Dispose(bool bool_5)
		{
			Class570.smethod_5(new Class570.Delegate45(this.method_8));
			this.class911_1.Dispose();
			base.Dispose(bool_5);
		}

		// Token: 0x06002816 RID: 10262
		// RVA: 0x0001EEB2 File Offset: 0x0001D0B2
		public override void Draw()
		{
			this.class911_1.Draw();
			base.Draw();
		}

		// Token: 0x06002814 RID: 10260
		// RVA: 0x000F991C File Offset: 0x000F7B1C
		public override void imethod_2()
		{
			this.method_1(false);
			if (this.int_2 == 0)
			{
				this.int_2 = (int)((double)((float)(1120 - Class115.smethod_43()) / 120f) * Class331.smethod_8());
			}
			if (this.int_6 == 0)
			{
				this.int_6 = (int)((double)((float)(560 - Class115.smethod_43() / 2) / 120f) * Class331.smethod_8());
			}
			if (this.double_0 == 0.0)
			{
				this.double_0 = Class331.smethod_8() / 2.0;
			}
			double num = Class331.smethod_0();
			int num2 = (int)((num + (double)this.int_6) / this.double_0);
			if (num2 > this.int_5)
			{
				this.int_5 = num2;
				if (this.method_10(this.int_5))
				{
					this.method_9();
				}
			}
			int num3 = (int)(num / this.double_0);
			if (num3 < this.int_4)
			{
				this.method_1(true);
			}
			else if (num3 > this.int_4)
			{
				this.int_4 = num3;
				if (this.bool_4 && !this.bool_3)
				{
					if (this.method_10(this.int_4))
					{
						Class331.smethod_59("metronomelow", 100, Enum112.flag_5);
						this.class531_0.class26_0.Add(new Class746(Color.get_White(), Color.get_Black(), Class115.int_1, Class115.int_1 + 80));
					}
				}
				else if (this.bool_4 && num > (double)(this.int_3 + this.int_6 / 2))
				{
					this.bool_3 = false;
				}
			}
			for (int i = 0; i < this.list_0.Count; i++)
			{
				if (this.list_0[i].vector2_1.X <= (float)(Class115.smethod_43() - 560))
				{
					this.class911_1.Remove(this.list_0[i]);
					this.list_0.RemoveAt(i);
				}
			}
			if (this.bool_2)
			{
				List<Class531> arg_1F1_0 = this.list_0;
				if (Class69.action_0 == null)
				{
					Class69.action_0 = new Action<Class531>(Class69.smethod_1);
				}
				arg_1F1_0.ForEach(Class69.action_0);
				this.bool_2 = false;
			}
			base.imethod_2();
		}

		// Token: 0x06002808 RID: 10248
		// RVA: 0x000F93A4 File Offset: 0x000F75A4
		public override void Initialize()
		{
			Class570.smethod_4(new Class570.Delegate45(this.method_8));
			Class802.smethod_34(Enum96.const_1, new Delegate46(this.method_2), Enum98.const_2, Enum97.const_0);
			Class802.smethod_34(Enum96.const_0, new Delegate46(this.method_4), Enum98.const_2, Enum97.const_0);
			this.class911_1 = new Class911(true);
			Class591 class = new Class591(new EventHandler(Class69.smethod_0), true, false);
			this.class911_1.Add<Class531>(class.list_0);
			Class533 class2 = new Class533(Class41.GetString(OsuString.OptionsOffsetWizard_Instructions), 16f, new Vector2((float)(Class115.smethod_43() / 2), 400f), new Vector2(500f, 0f), 0.8f, true, Color.get_White(), false);
			class2.enum72_0 = Enum72.const_2;
			class2.origins_0 = Origins.TopCentre;
			this.class911_1.Add(class2);
			this.class531_0 = new Class531(Class885.Load("options-offset-tick", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2((float)(Class115.smethod_43() / 2), 240f), 0.8f, true, Color.get_White(), null);
			this.class531_0.vector2_2 = new Vector2(0.1f, 2f);
			this.class911_1.Add(this.class531_0);
			this.class533_0 = new Class533(Class41.GetString(OsuString.OptionsOffsetWizard_UniversalOffset), 30f, new Vector2(50f, 20f), 0.8f, true, Color.get_White());
			this.class911_1.Add(this.class533_0);
			this.class533_0 = new Class533(Class341.class608_9.ToString(), 30f, new Vector2(50f + this.class533_0.vmethod_11().X, 20f), 0.8f, true, Color.get_YellowGreen());
			this.class533_0.bool_16 = true;
			this.class911_1.Add(this.class533_0);
			this.class762_0 = new Class762(Class41.GetString(OsuString.OptionsOffsetWizard_TickOther), new Vector2(50f, 80f), 0.8f, false);
			this.class911_1.Add<Class531>(this.class762_0.list_0);
			this.class762_0.method_8(new Delegate38(this.method_6));
			this.class762_2 = new Class762(Class41.GetString(OsuString.OptionsOffsetWizard_HalfTick), new Vector2(50f, 60f), 0.8f, false);
			this.class911_1.Add<Class531>(this.class762_2.list_0);
			this.class762_2.method_8(new Delegate38(this.method_5));
			this.class762_1 = new Class762(Class41.GetString(OsuString.OptionsOffsetWizard_DoubleTick), new Vector2(150f, 60f), 0.8f, false);
			this.class911_1.Add<Class531>(this.class762_1.list_0);
			this.class762_1.method_8(new Delegate38(this.method_7));
			this.class762_0.method_9();
			this.list_0 = new List<Class531>();
			if (Class331.class335_0.vmethod_2())
			{
				Class331.smethod_84(Class466.Current, false, false, true, false);
				Class331.smethod_83();
				Class331.smethod_87();
			}
			base.Initialize();
			this.method_1(false);
		}

		// Token: 0x06002809 RID: 10249
		// RVA: 0x000F96D0 File Offset: 0x000F78D0
		private void method_1(bool bool_5)
		{
			if (Class466.Current == this.class296_0 && !bool_5)
			{
				return;
			}
			this.class296_0 = Class466.Current;
			this.int_4 = 0;
			this.double_0 = 0.0;
			this.int_6 = 0;
			this.int_2 = 0;
			this.int_5 = 0;
			this.bool_2 = true;
		}

		// Token: 0x06002815 RID: 10261
		// RVA: 0x000F9B2C File Offset: 0x000F7D2C
		private bool method_10(int int_7)
		{
			int num = 2;
			if (this.class762_1.method_2())
			{
				num = 1;
			}
			else if (this.class762_2.method_2())
			{
				num = 4;
			}
			int num2 = 0;
			if (this.class762_2.method_2() && this.class762_0.method_2())
			{
				num2 = 2;
			}
			return int_7 % num == num2;
		}

		// Token: 0x0600280A RID: 10250
		// RVA: 0x0001EDB8 File Offset: 0x0001CFB8
		private bool method_2(object object_0, EventArgs eventArgs_0)
		{
			this.method_3(1);
			return true;
		}

		// Token: 0x0600280B RID: 10251
		// RVA: 0x0001EDC2 File Offset: 0x0001CFC2
		private void method_3(int int_7)
		{
			Class341.class608_9.Value += int_7;
			this.class533_0.Text = Class341.class608_9.ToString();
			this.class533_0.method_40(Color.get_White(), 200);
		}

		// Token: 0x0600280C RID: 10252
		// RVA: 0x0001EE00 File Offset: 0x0001D000
		private bool method_4(object object_0, EventArgs eventArgs_0)
		{
			this.method_3(-1);
			return true;
		}

		// Token: 0x0600280E RID: 10254
		// RVA: 0x0001EE0A File Offset: 0x0001D00A
		private void method_5(object object_0, bool bool_5)
		{
			if (bool_5)
			{
				this.class762_0.method_11();
				this.class762_1.method_6(false);
			}
			else
			{
				this.class762_0.method_9();
			}
			this.bool_2 = true;
			this.bool_4 = false;
			this.bool_3 = true;
		}

		// Token: 0x0600280F RID: 10255
		// RVA: 0x0001EE48 File Offset: 0x0001D048
		private void method_6(object object_0, bool bool_5)
		{
			this.bool_2 = true;
			this.bool_4 = false;
			this.bool_3 = true;
		}

		// Token: 0x06002810 RID: 10256
		// RVA: 0x0001EE5F File Offset: 0x0001D05F
		private void method_7(object object_0, bool bool_5)
		{
			this.class762_2.method_6(false);
			this.class762_0.method_9();
			this.bool_2 = true;
			this.bool_4 = false;
			this.bool_3 = true;
		}

		// Token: 0x06002811 RID: 10257
		// RVA: 0x000F972C File Offset: 0x000F792C
		private bool method_8(object object_0, Keys keys_0, bool bool_5)
		{
			if (keys_0 != 27)
			{
				switch (keys_0)
				{
				case 38:
					if (Class570.bool_2)
					{
						this.method_3(5);
					}
					else
					{
						this.method_3(1);
					}
					return true;
				case 40:
					if (Class570.bool_2)
					{
						this.method_3(-5);
					}
					else
					{
						this.method_3(-1);
					}
					return true;
				}
				return false;
			}
			Class69.smethod_0(object_0, null);
			return true;
		}

		// Token: 0x06002812 RID: 10258
		// RVA: 0x000F9794 File Offset: 0x000F7994
		private void method_9()
		{
			Class531 class = new Class531(Class885.Load("options-offset-tick", Enum112.flag_6), Enum115.const_5, Origins.Centre, Enum114.const_0, new Vector2(560f, 240f), 0.8f, true, Color.get_White(), null);
			class.class26_0.Add(new Class746(TransformationType.Fade, 0f, 1f, Class115.int_1, Class115.int_1 + 300, Enum70.const_0));
			class.class26_0.Add(new Class746(TransformationType.Fade, 1f, 0f, Class115.int_1 + this.int_2 - 300, Class115.int_1 + this.int_2, Enum70.const_0));
			class.class26_0.Add(new Class746(TransformationType.Movement, new Vector2(560f, 240f), new Vector2((float)(Class115.smethod_43() - 560), 240f), Class115.int_1, Class115.int_1 + this.int_2, Enum70.const_0));
			class.vector2_2 = new Vector2(0.3f, 1f);
			class.class26_0.Add(new Class746(TransformationType.VectorScale, new Vector2(1f, 1f), new Vector2(0.3f, 1f), Class115.int_1 + this.int_2 / 2, Class115.int_1 + this.int_2 / 2 + 100, Enum70.const_0));
			this.class911_1.Add(class);
			this.list_0.Add(class);
			if (!this.bool_4)
			{
				this.bool_4 = true;
				this.int_3 = (int)Class331.smethod_0();
			}
		}

		// Token: 0x0600280D RID: 10253
		// RVA: 0x00019F21 File Offset: 0x00018121
		private static void smethod_0(object sender, EventArgs e)
		{
			Class331.smethod_60("menuback", 1f, Enum112.flag_5);
			Class115.smethod_70(OsuModes.Menu, false);
		}

		// Token: 0x06002817 RID: 10263
		// RVA: 0x0001EEC6 File Offset: 0x0001D0C6
		[CompilerGenerated]
		private static void smethod_1(Class531 class531_1)
		{
			class531_1.method_16(300, Enum70.const_0);
			class531_1.bool_0 = false;
		}
	}
}
