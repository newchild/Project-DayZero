using Microsoft.Xna.Framework;
using ns14;
using ns79;
using ns8;
using ns80;
using osu.Graphics.Sprites;
using osu_common.Helpers;
using System;

namespace ns20
{
	// Token: 0x020003A2 RID: 930
	internal sealed class Class392 : Class390
	{
		// Token: 0x040016DA RID: 5850
		private bool bool_1;

		// Token: 0x040016DB RID: 5851
		private Class533 class533_0;

		// Token: 0x040016D8 RID: 5848
		internal FontAwesome fontAwesome_0;

		// Token: 0x040016D9 RID: 5849
		internal string string_0;

		// Token: 0x06001CBA RID: 7354
		// RVA: 0x00099EAC File Offset: 0x000980AC
		public Class392(OsuString osuString_0, FontAwesome fontAwesome_1)
		{
			this.fontAwesome_0 = fontAwesome_1;
			base.method_8(fontAwesome_1.ToString());
			base.method_8(osuString_0.ToString());
			this.string_0 = Class41.GetString(osuString_0);
			base.method_8(this.string_0);
			Class533 class = new Class533(this.string_0.ToUpper(), 24f, Vector2.get_Zero(), 0f, true, Class885.color_3);
			class.float_3 = 0.4f;
			class.origins_0 = Origins.TopRight;
			class.enum115_0 = Enum115.const_7;
			class.method_58(false);
			this.class533_0 = class;
			this.class911_0.Add(this.class533_0);
			base.method_1(new Vector2(0f, 10f));
			base.method_8(this.string_0);
		}

		// Token: 0x06001CBC RID: 7356
		// RVA: 0x00099F80 File Offset: 0x00098180
		public void method_13(bool bool_2)
		{
			if (bool_2 == this.bool_1)
			{
				return;
			}
			this.bool_1 = bool_2;
			if (this.bool_1)
			{
				this.class533_0.method_14(100, Enum70.const_0);
				this.class533_0.method_39(Class610.smethod_1(Class885.color_3, 0.4f), 100, false, Enum70.const_0);
				return;
			}
			this.class533_0.method_25(0.4f, 100, Enum70.const_0);
			this.class533_0.method_39(Class885.color_3, 100, false, Enum70.const_0);
		}

		// Token: 0x06001CBB RID: 7355
		// RVA: 0x00006D2D File Offset: 0x00004F2D
		internal override bool vmethod_3()
		{
			return true;
		}
	}
}
