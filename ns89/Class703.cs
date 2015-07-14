using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns24;
using ns77;
using ns79;
using ns80;
using osu.GameplayElements.Events;
using osu.Graphics.Sprites;
using System;
using System.IO;

namespace ns89
{
	// Token: 0x02000534 RID: 1332
	internal sealed class Class703 : Class702
	{
		// Token: 0x040023D6 RID: 9174
		private readonly bool bool_3;

		// Token: 0x040023D8 RID: 9176
		internal Class538 class538_0;

		// Token: 0x040023D9 RID: 9177
		internal double double_0;

		// Token: 0x040023DB RID: 9179
		private float float_0;

		// Token: 0x040023D5 RID: 9173
		private int int_3;

		// Token: 0x040023D7 RID: 9175
		private int int_4;

		// Token: 0x040023DA RID: 9178
		private int int_5;

		// Token: 0x040023D4 RID: 9172
		private readonly Origins origins_0;

		// Token: 0x040023DC RID: 9180
		private string[] string_1;

		// Token: 0x040023D3 RID: 9171
		private readonly Vector2 vector2_0;

		// Token: 0x06002B1F RID: 11039
		// RVA: 0x001173F8 File Offset: 0x001155F8
		internal Class703(Class531 class531_1, string string_2, int int_6, int int_7)
		{
			this.class531_0 = class531_1;
			this.class538_0 = (class531_1 as Class538);
			this.int_5 = 0;
			this.int_5 = int_6;
			this.eventTypes_0 = EventTypes.Animation;
			this.int_4 = int_7;
			this.string_0 = string_2.Replace(Class466.Current.method_3() + Path.DirectorySeparatorChar, string.Empty);
		}

		// Token: 0x06002B20 RID: 11040
		// RVA: 0x00117468 File Offset: 0x00115668
		internal Class703(string string_2, Vector2 vector2_1, Origins origins_1, StoryLayer storyLayer_1, int int_6, double double_1, bool bool_4, LoopTypes loopTypes_0)
		{
			this.vector2_0 = vector2_1;
			this.origins_0 = origins_1;
			this.int_3 = int_6;
			this.bool_3 = bool_4;
			this.double_0 = Math.Max(1.0, double_1);
			this.storyLayer_0 = storyLayer_1;
			this.float_0 = Class872.smethod_6(this.storyLayer_0);
			this.class538_0 = new Class538(null, Enum115.const_2, origins_1, Enum114.const_1, vector2_1, this.float_0, false, Color.get_White(), null);
			this.class538_0.loopTypes_0 = loopTypes_0;
			if (Class466.Current != null && Class466.Current.int_6 < 6)
			{
				this.class538_0.method_53(Math.Round(0.015 * double_1) * 1.186 * 16.666666666666668);
			}
			else
			{
				this.class538_0.method_53(double_1);
			}
			this.class531_0 = this.class538_0;
			this.eventTypes_0 = EventTypes.Animation;
			this.string_0 = string_2.Replace(Class466.Current.method_3() + Path.DirectorySeparatorChar, string.Empty);
			this.string_1 = new string[this.int_3];
			for (int i = 0; i < this.int_3; i++)
			{
				string text = this.string_0.Replace(".", i + ".");
				Class885.smethod_7(text);
				this.string_1[i] = text;
			}
			this.class538_0.method_41(new EventHandler(this.method_4));
		}

		// Token: 0x06002B25 RID: 11045
		// RVA: 0x001176B4 File Offset: 0x001158B4
		internal override Class702 Clone()
		{
			Class538 class531_ = (Class538)this.class538_0.Clone();
			return new Class703(class531_, this.string_0, this.int_2, this.int_0)
			{
				double_0 = this.double_0,
				int_3 = this.int_3,
				bool_2 = this.bool_2,
				storyLayer_0 = this.storyLayer_0,
				bool_1 = this.bool_1
			};
		}

		// Token: 0x06002B24 RID: 11044
		// RVA: 0x00117628 File Offset: 0x00115828
		internal override bool Load()
		{
			if (this.bool_0)
			{
				return false;
			}
			this.bool_0 = true;
			Class731[] array = null;
			if (this.bool_3)
			{
				array = Class885.smethod_27(Path.GetFileNameWithoutExtension(this.string_0), Enum112.flag_6, true);
			}
			if (!this.bool_3 || array == null)
			{
				array = new Class731[this.int_3];
				if (this.string_1 != null)
				{
					for (int i = 0; i < this.int_3; i++)
					{
						array[i] = Class885.Load(this.string_1[i], Enum112.flag_3);
					}
				}
			}
			this.class538_0.method_55(array);
			return true;
		}

		// Token: 0x06002B21 RID: 11041
		// RVA: 0x001175EC File Offset: 0x001157EC
		private void method_4(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				return;
			}
			if (!(bool)sender)
			{
				for (int i = 0; i < this.int_3; i++)
				{
					Class885.smethod_8(this.string_1[i]);
				}
			}
		}

		// Token: 0x06002B22 RID: 11042
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void vmethod_0(int int_6)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002B23 RID: 11043
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void vmethod_1(int int_6)
		{
			throw new NotImplementedException();
		}
	}
}
