using Microsoft.Xna.Framework.Graphics;
using ns25;
using ns29;
using ns3;
using ns7;
using ns8;
using System;
using System.Collections.Generic;

namespace ns6
{
	// Token: 0x02000622 RID: 1570
	internal sealed class Class21 : Class20
	{
		// Token: 0x04002C59 RID: 11353
		internal bool bool_0;

		// Token: 0x04002C5A RID: 11354
		public bool bool_1;

		// Token: 0x04002C5B RID: 11355
		public bool bool_2;

		// Token: 0x04002C5D RID: 11357
		internal bool bool_3;

		// Token: 0x04002C5E RID: 11358
		private bool bool_4;

		// Token: 0x04002C5C RID: 11356
		private int int_1;

		// Token: 0x04002C57 RID: 11351
		internal List<Class841> list_0 = new List<Class841>();

		// Token: 0x04002C58 RID: 11352
		internal string string_2 = "";

		// Token: 0x0600309A RID: 12442
		// RVA: 0x000240B0 File Offset: 0x000222B0
		public Class21(Class32 class32_0) : base(class32_0)
		{
		}

		// Token: 0x06003099 RID: 12441
		// RVA: 0x00024084 File Offset: 0x00022284
		internal Class21(string string_3, bool bool_5)
		{
			this.string_0 = string_3;
			this.bool_1 = bool_5;
		}

		// Token: 0x0600309C RID: 12444
		// RVA: 0x0013AC68 File Offset: 0x00138E68
		public bool Join(bool bool_5)
		{
			bool_5 |= (this.string_0 == "#lobby");
			if (this.bool_0)
			{
				return true;
			}
			if (this.bool_3)
			{
				return false;
			}
			if (!bool_5 && this.int_1 > 0 && Class115.int_1 - this.int_1 < 10000)
			{
				return false;
			}
			this.int_1 = Class115.int_1;
			Class809.smethod_34(Enum3.const_63, new Struct16(this.string_0));
			this.list_0.Add(new Class841("Attempting to join channel...", "", Color.get_LightCoral()));
			this.bool_3 = true;
			return true;
		}

		// Token: 0x0600309B RID: 12443
		// RVA: 0x000240CF File Offset: 0x000222CF
		public void method_0(bool bool_5)
		{
			this.bool_4 = bool_5;
			if (bool_5)
			{
				this.bool_0 = true;
			}
		}

		// Token: 0x0600309D RID: 12445
		// RVA: 0x000240E2 File Offset: 0x000222E2
		public void method_1()
		{
			if (this.bool_0)
			{
				Class809.smethod_34(Enum3.const_78, new Struct16(this.string_0));
				this.bool_0 = false;
				this.bool_3 = false;
				this.string_2 = "";
			}
		}

		// Token: 0x0600309E RID: 12446
		// RVA: 0x0013AD08 File Offset: 0x00138F08
		internal void method_2()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			this.bool_3 = false;
			this.string_2 = "";
			this.list_0.Add(new Class841("Joined " + this.string_0 + "!", "", Color.get_YellowGreen()));
		}

		// Token: 0x0600309F RID: 12447
		// RVA: 0x0002411C File Offset: 0x0002231C
		internal void Reset()
		{
			if (this.bool_4)
			{
				return;
			}
			this.bool_0 = false;
			this.bool_3 = false;
			this.string_2 = "";
		}
	}
}
