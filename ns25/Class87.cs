using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ns29;
using ns78;
using ns79;
using ns80;
using ns9;
using osu.Graphics.Sprites;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns25
{
	// Token: 0x020006A6 RID: 1702
	internal sealed class Class87 : Class55
	{
		// Token: 0x020006A7 RID: 1703
		[CompilerGenerated]
		private sealed class Class902
		{
			// Token: 0x0400316A RID: 12650
			public float float_0;
		}

		// Token: 0x020006A8 RID: 1704
		[CompilerGenerated]
		private sealed class Class903
		{
			// Token: 0x0400316C RID: 12652
			public Class840 class840_0;

			// Token: 0x0400316B RID: 12651
			public Class87.Class902 class902_0;

			// Token: 0x0600352F RID: 13615
			// RVA: 0x00026EA4 File Offset: 0x000250A4
			public bool method_0(Class840 class840_1)
			{
				return Vector2.DistanceSquared(class840_1.vector2_0, this.class840_0.vector2_0) < this.class902_0.float_0;
			}
		}

		// Token: 0x04003167 RID: 12647
		private bool bool_2;

		// Token: 0x04003166 RID: 12646
		private Class531 class531_0;

		// Token: 0x04003165 RID: 12645
		internal Class911 class911_0;

		// Token: 0x04003168 RID: 12648
		private int int_2;

		// Token: 0x04003169 RID: 12649
		private List<Class840> list_0 = new List<Class840>();

		// Token: 0x06003527 RID: 13607
		// RVA: 0x00026E3C File Offset: 0x0002503C
		public Class87(Class114 class114_1) : base(class114_1)
		{
			this.class911_0 = new Class911(true);
		}

		// Token: 0x06003528 RID: 13608
		// RVA: 0x00026E5C File Offset: 0x0002505C
		protected override void Dispose(bool bool_3)
		{
			this.class911_0.Dispose();
			base.Dispose(bool_3);
		}

		// Token: 0x06003529 RID: 13609
		// RVA: 0x0016C210 File Offset: 0x0016A410
		public override void Draw()
		{
			if (!this.bool_2)
			{
				this.method_2();
			}
			if (this.class911_0.float_0 == 0f)
			{
				return;
			}
			this.class911_0.Draw();
			foreach (Class840 current in this.list_0)
			{
				Class115.class582_0.method_4((double)current.vector2_0.X, (double)current.vector2_0.Y, new Color(255, 85, 204, (byte)(this.class911_0.float_0 * 100f * Math.Min(2f, 1f + (float)(8 * current.int_0) / 100f))));
			}
			base.Draw();
		}

		// Token: 0x0600352A RID: 13610
		// RVA: 0x00026E70 File Offset: 0x00025070
		public override void imethod_2()
		{
			if (this.class911_0.float_0 == 0f)
			{
				return;
			}
			if (Class115.int_1 - this.int_2 > 5000)
			{
				this.method_1();
			}
			base.imethod_2();
		}

		// Token: 0x0600352B RID: 13611
		// RVA: 0x0016C2F8 File Offset: 0x0016A4F8
		private void method_1()
		{
			Class87.Class902 class = new Class87.Class902();
			this.list_0.Clear();
			Class115.smethod_43();
			float num = 1.54166663f;
			float num2 = 61f;
			float num3 = 1.55f;
			class.float_0 = 2f;
			lock (Class809.list_1)
			{
				foreach (Class861 current in Class809.list_1)
				{
					Class87.Class903 class2 = new Class87.Class903();
					class2.class902_0 = class;
					if (current.bool_10)
					{
						class2.class840_0 = new Class840(new Vector2((current.float_1 * num + (float)(Class115.smethod_43() / 2)) * Class115.float_4, ((-current.float_2 + 90f) * num3 + num2) * Class115.float_4 + (float)Class115.int_25), 0);
						Class840 class3 = this.list_0.Find(new Predicate<Class840>(class2.method_0));
						if (class3 != null)
						{
							class3.int_0++;
						}
						else
						{
							this.list_0.Add(class2.class840_0);
						}
					}
				}
			}
			this.int_2 = Class115.int_1;
		}

		// Token: 0x0600352C RID: 13612
		// RVA: 0x0016C454 File Offset: 0x0016A654
		private void method_2()
		{
			if (this.bool_2)
			{
				return;
			}
			this.class531_0 = new Class531(Class885.Load("worldmap", Enum112.flag_1), Enum115.const_6, Origins.TopCentre, Enum114.const_0, new Vector2(0f, 65f));
			this.class531_0.float_2 = 1f;
			this.class531_0.bool_0 = true;
			this.class911_0.Add(this.class531_0);
			this.bool_2 = true;
		}
	}
}
