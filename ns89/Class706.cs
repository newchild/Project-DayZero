using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns24;
using ns79;
using ns80;
using osu.GameplayElements.Events;
using osu.Graphics.Sprites;
using System;
using System.IO;

namespace ns89
{
	// Token: 0x0200065C RID: 1628
	internal sealed class Class706 : Class702
	{
		// Token: 0x04002DDD RID: 11741
		private readonly bool bool_3;

		// Token: 0x04002DE0 RID: 11744
		private float float_0;

		// Token: 0x04002DDE RID: 11742
		private int int_3;

		// Token: 0x04002DDF RID: 11743
		private int int_4;

		// Token: 0x04002DDC RID: 11740
		private readonly Origins origins_0;

		// Token: 0x04002DDB RID: 11739
		private readonly Vector2 vector2_0;

		// Token: 0x06003212 RID: 12818
		// RVA: 0x00149194 File Offset: 0x00147394
		internal Class706(Class531 class531_1, string string_1, int int_5, int int_6)
		{
			this.class531_0 = class531_1;
			this.int_4 = 0;
			this.int_4 = int_5;
			this.int_3 = int_6;
			this.eventTypes_0 = EventTypes.Sprite;
			this.string_0 = string_1.Replace(Class466.Current.method_3() + Path.DirectorySeparatorChar, string.Empty);
		}

		// Token: 0x06003213 RID: 12819
		// RVA: 0x001491F8 File Offset: 0x001473F8
		internal Class706(string string_1, Vector2 vector2_1, Origins origins_1, StoryLayer storyLayer_1, bool bool_4)
		{
			this.vector2_0 = vector2_1;
			this.origins_0 = origins_1;
			this.bool_3 = bool_4;
			this.storyLayer_0 = storyLayer_1;
			this.eventTypes_0 = EventTypes.Sprite;
			this.float_0 = Class872.smethod_6(this.storyLayer_0);
			this.string_0 = string_1.Replace(Class466.Current.method_3() + Path.DirectorySeparatorChar, string.Empty);
			Class885.smethod_7(string_1);
			this.class531_0 = new Class531(null, Enum115.const_2, origins_1, Enum114.const_1, vector2_1, this.float_0, false, Color.get_White(), null);
			this.class531_0.method_41(new EventHandler(this.method_4));
		}

		// Token: 0x06003218 RID: 12824
		// RVA: 0x00149314 File Offset: 0x00147514
		internal override Class702 Clone()
		{
			Class531 class531_ = this.class531_0.Clone();
			return new Class706(class531_, this.string_0, this.int_2, this.int_0)
			{
				bool_2 = this.bool_2,
				eventTypes_0 = this.eventTypes_0,
				storyLayer_0 = this.storyLayer_0,
				bool_1 = this.bool_1,
				dictionary_0 = this.dictionary_0
			};
		}

		// Token: 0x06003215 RID: 12821
		// RVA: 0x001492A8 File Offset: 0x001474A8
		internal override bool Load()
		{
			if (this.bool_0)
			{
				return false;
			}
			this.bool_0 = true;
			if (this.bool_3)
			{
				this.class531_0.vmethod_7(Class885.Load(Path.GetFileNameWithoutExtension(this.string_0), Enum112.flag_6) ?? Class885.Load(this.string_0, Enum112.flag_6));
			}
			else
			{
				this.class531_0.vmethod_7(Class885.Load(this.string_0, Enum112.flag_3));
			}
			return true;
		}

		// Token: 0x06003214 RID: 12820
		// RVA: 0x00024E8E File Offset: 0x0002308E
		internal void method_4(object sender, EventArgs e)
		{
			if (!(bool)sender)
			{
				Class885.smethod_8(this.string_0);
			}
		}

		// Token: 0x06003216 RID: 12822
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void vmethod_0(int int_5)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06003217 RID: 12823
		// RVA: 0x000060D8 File Offset: 0x000042D8
		internal override void vmethod_1(int int_5)
		{
			throw new NotImplementedException();
		}
	}
}
